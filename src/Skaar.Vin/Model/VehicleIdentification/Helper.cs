using Skaar.VehicleData.Model.Geographic;

namespace Skaar.VehicleData.Model.VehicleIdentification;

static class Helper
{
    public static string? GetProductionNumber(ReadOnlySpan<char> vin)
    {
        if (vin.Length < 17)
        {
            return null;
        }

        if(Geographic.Helper.GetArea(vin) == Area.NorthAmerica || Geographic.Helper.GetCountry(vin) == Country.China)
        {
            return vin[11..17].ToString();
        }

        return null;
    }
    
    public static string? GetVehicleIdentifierSection(ReadOnlySpan<char> vin)
    {
        if (vin.Length < 17)
        {
            return null;
        }

        var area = Geographic.Helper.GetArea(vin);
        if (Manufacturer.Helper.IsSmallManufacturer(vin))
        {
            if (area == Area.Europe)
            {
                return vin[12..].ToString();
            }
            return vin[14..].ToString();
        }
        if(area == Area.Europe)
        {
            return vin[9..].ToString();
        }
        return vin[11..].ToString();
    }
}