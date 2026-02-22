using Skaar.ValueType;
using Skaar.VehicleData.Model;
using Helper = Skaar.VehicleData.Model.VehicleIdentification.Helper;

namespace Skaar.VehicleData;

/// <summary>
/// A value type representing a VIN (Vehicle Identification Number).
/// </summary>
/// <seealso href="https://en.wikipedia.org/wiki/Vehicle_identification_number"/>
[ValueType]
public partial struct Vin
{
    private ReadOnlySpan<char> Clean(ReadOnlySpan<char> value)
    {
        var buffer = new char[value.Length];

        int written = 0;
        for (int i = 0; i < value.Length; i++)
        {
            char c = value[i];

            if (!char.IsLetterOrDigit(c))
                continue;

            if ((uint)(c - 'a') <= ('z' - 'a'))
                c = (char)(c - 32);
            else
                c = char.ToUpperInvariant(c);

            c = c switch
            {
                'I' => '1',
                'O' => '0',
                'Q' => '0',
                _ => c
            };

            buffer[written++] = c;
        }

        return buffer.AsSpan(0, written);
    }

    private bool ValueIsValid(ReadOnlySpan<char> value)
    {
        return value.Length == 17;
    }

    /// <summary>
    /// The geographic region (based on the first character of the VIN)
    /// </summary>
    /// <seealso href="https://standards.iso.org/iso/3780/ed-4/en/Current%20WMI%20World%20Codes%20chart%204.13.21.pdf"/>
    public Model.Geographic.Area GeographicArea => IsValid ? Model.Geographic.Helper.GetArea(_value.Span) : default;
    
    /// <summary>
    /// The country (based on the first and second character of the VIN)
    /// </summary>
    /// <seealso href="https://standards.iso.org/iso/3780/ed-4/en/Current%20WMI%20World%20Codes%20chart%204.13.21.pdf"/>
    public Model.Geographic.Country Country => IsValid ? Model.Geographic.Helper.GetCountry(_value.Span) : default;
    
    /// <summary>
    /// Manufacturer, based on the first three characters of the VIN (the WMI - World Manufacturer Identifier)
    /// </summary>
    /// <remarks>Based on
    /// <see href="https://en.wikibooks.org/wiki/Vehicle_Identification_Numbers_(VIN_codes)/World_Manufacturer_Identifier_(WMI)"/>.
    /// The data is incomplete and may not be up to date, but it should cover the most common manufacturers.
    /// It is also possible that some manufacturers are missing or misclassified, especially for less common or older vehicles.
    /// </remarks>
    public string? Manufacturer => IsValid ? Model.Manufacturer.Helper.GetManufacturer(_value.Span) : null;
    
    /// <summary>
    /// Model year (usually based on the 10th character of the VIN, but may be missing for European vehicles)
    /// </summary>
    public Year? ModelYear => IsValid ? Model.ModelYear.Helper.GetModelYear(_value.Span) : null;
    
    /// <summary>
    /// Plant code (usually based on the 11th character of the VIN, but may be missing for non-North American and non-Chinese vehicles)
    /// </summary>
    public char? PlantCode => IsValid ? Model.Plant.Helper.GetPlantCode(_value.Span) : null;

    /// <summary>
    /// Vehicle's serial number or production number (usually based on the last 6 characters of the VIN, but may be missing for non-North American and non-Chinese vehicles)
    /// </summary>
    public string? ProductionNumber => IsValid ? Helper.GetProductionNumber(_value.Span) : null;
    
    /// <summary>
    /// The last section, identifying the vehicle. Depending on the manufacturer and region, this may be based on different characters of the VIN, but it is usually the last 6 to 8 characters. It may be missing for some vehicles, especially older or European ones.
    /// </summary>
    public string? VehicleIdentifierSection => IsValid ? Model.VehicleIdentification.Helper.GetVehicleIdentifierSection(_value.Span)  : null;
}