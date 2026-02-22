namespace Skaar.VehicleData.Model.Geographic;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
public sealed class IsoCountryCodeAttribute(string countryCode) : Attribute
{
    public string CountryCode { get; } = countryCode;
}