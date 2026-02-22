using System.Text.Json;
using Shouldly;

namespace Skaar.VehicleData.Tests;

public class SerializingTests(ITestOutputHelper output)
{
    [Fact]
    public void SerializeAndDeserialize_Vin_RoundTrips()
    {
        var vin = Vin.Parse("WB1051808BZV83859");
        var json = JsonSerializer.Serialize(vin);
        output.WriteLine("Serialized VIN: {0}", json);
        
        var deserializedVin = JsonSerializer.Deserialize<Vin>(json);
        deserializedVin.IsValid.ShouldBe(true);
        deserializedVin.ShouldBe(vin);
    }

    [Fact]
    public void SerializeAndDeserialize_Object_RoundTrips()
    {
        var target = new
        {
            Name = "Test Vehicle",
            Vin = Vin.Parse("WB1051808BZV83859"),
            OtherVins = new[] { (Vin)"1GTEK19088Z308534", (Vin)"1FTRX12W56KD82369" }
        };
        var type = target.GetType();
        
        var json = JsonSerializer.Serialize(target);
        output.WriteLine("Serialized Object: {0}", json);
        
        dynamic deserializedTarget = JsonSerializer.Deserialize(json, type)!;
        Assert.Equal(target.Name, deserializedTarget.Name);
        Assert.Equal(target.Vin, deserializedTarget.Vin);
        Assert.Equivalent(target.OtherVins, deserializedTarget.OtherVins);
    }
}