using Shouldly;

namespace Skaar.VehicleData.Tests;

public class ManufaturerTests
{
    [Theory]
    [InlineData("WB1051808BZV83859", "BMW Motorrad")]
    [InlineData("WMWRF31050TF48662", "MINI car")]
    public void GetManufacturer_WithValidVin_ReturnsManufacturer(string vin, string manufacturer)
    {
        var target = Vin.Parse(vin);
        target.Manufacturer.ShouldBe(manufacturer);
    }
}