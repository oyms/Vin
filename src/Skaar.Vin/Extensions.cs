using System.ComponentModel;
using System.Reflection;
using Skaar.VehicleData.Model.Geographic;

namespace Skaar.VehicleData;

public static class Extensions
{
    extension(Country country)
    {
        /// <summary>
        /// Get the ISO 3166 code for the country
        /// </summary>
        /// <returns>The two-letter country code in upper case.</returns>
        public string GetIsoCountryCode()
        {
            var memberInfo = typeof(Country).GetMember(country.ToString()).FirstOrDefault();
            var attribute = memberInfo?.GetCustomAttribute<IsoCountryCodeAttribute>();
            return attribute?.CountryCode ?? string.Empty;
        }
        
        /// <summary>
        /// Get a display name of the country
        /// </summary>
        public string GetDisplayName()
        {
            var memberInfo = typeof(Country).GetMember(country.ToString()).FirstOrDefault();
            var attribute = memberInfo?.GetCustomAttribute<DescriptionAttribute>();
            return attribute?.Description ?? country.ToString();
        }
    }
}