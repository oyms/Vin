using Shouldly;
using Skaar.VehicleData.Model;

namespace Skaar.VehicleData.Tests;

public class ModelYearTests(ITestOutputHelper outputHelper)
{
    [Theory]
    [InlineData("1GTEK19088Z308534", 2008)]
    [InlineData("1FTRX12W56KD82369", 2006)]
    [InlineData("JTDBR32E532008032", 2003)]
    [InlineData("1FMFU20508LA80220", 2008)]
    [InlineData("KMHTC6AE0DU136852", 2013)]
    [InlineData("2G1WB5EK5A1133735", 2010)]
    [InlineData("3N1CE2CP0EL431597", 2014)]
    [InlineData("KNALD124555070950", 2005)]
    [InlineData("SALFR2BG3EH415787", null)] //European
    [InlineData("WV1ZZZEB8PH007114", null)] //European
    [InlineData("WMWRF31050TF48662", null)] //European
    [InlineData("WBADM6342YGU13769", null)] //European
    public void GetModelYear_WithString_ReturnsModelYear(string input, int? expected)
    {
        var vin = Vin.Parse(input);
        outputHelper.WriteLine(vin.Dump(GetDumpOptions()));
        vin.ModelYear.ShouldBe(expected);
    }

    private DumpOptions GetDumpOptions()
    {
        var result = new DumpOptions();
        result.CustomInstanceFormatters.AddFormatter<Year>(x => x.ToString());
        return result;
    }
}