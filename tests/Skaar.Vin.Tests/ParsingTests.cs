using Shouldly;

namespace Skaar.Vin.Tests;

public class ParsingTests
{
    [Theory]
    [InlineData("WB1051808BZV83859", true, "WB1051808BZV83859")]
    [InlineData("wb1051808bzv83859", true, "WB1051808BZV83859")]
    [InlineData("wbIO5i8o8bzv83859", true, "WB1051808BZV83859")]
    [InlineData("wbIO5i8o8bzv8385", false, "WB1051808BZV8385")] //To short
    [InlineData("", false, "")] //To short
    public void TryParse_WithString_ParsesAndCleansString(string input, bool success, string expected)
    {
        Vin.TryParse(input, null, out var vin).ShouldBe(success);
        vin.ToString().ShouldBe(expected);
    }
    
    [Fact]
    public void Equal_TwoEqualValues_ComparesEqual()
    {
        var vin1 = Vin.Parse("WB1051808BZV83859");
        var vin2 = Vin.Parse("wbi051808bzv83859");
        
        vin1.Equals(vin2).ShouldBeTrue();
        vin1.GetHashCode().ShouldBe(vin2.GetHashCode());
        (vin1 == vin2).ShouldBeTrue();
    }
}