using Skaar.VehicleData.Model.Geographic;

namespace Skaar.VehicleData.Model.Plant;

static class Helper
{
    public static char? GetPlantCode(ReadOnlySpan<char> vin)
    {
        if (vin.Length < 11)
        {
            return null;
        }

        if(Geographic.Helper.GetArea(vin) == Area.NorthAmerica || Geographic.Helper.GetCountry(vin) == Country.China)
        {
            return vin[10];
        }

        return null;
    }
}