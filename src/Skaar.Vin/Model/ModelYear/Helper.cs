using Skaar.VehicleData.Model.Geographic;

namespace Skaar.VehicleData.Model.ModelYear;

static class Helper
{
    public static Year? GetModelYear(ReadOnlySpan<char> vin)
    {
        if (vin.Length < 10)
        {
            return null;
        }

        if (Geographic.Helper.GetArea(vin) == Area.Europe)
        {
            return null;
        } 

        var startYears = char.IsNumber(vin[6]) ? (1980, 2001) : (2010, 2031); 
        
        return vin[9] switch
        {
            'U' or 'Z' or '0' => null, // Not used
            >= 'A' and <= 'Y' => vin[9] - 'A' + startYears.Item1,
            >= '1' and <= '9' => vin[9] - '1' + startYears.Item2,
            _ => null
        };
    }
}