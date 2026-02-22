namespace Skaar.VehicleData.Model.Manufacturer;

static class Helper
{
    private static readonly WeakReference<Manufacturers> MainLookup = new(new Manufacturers());
    private static readonly WeakReference<SmallManufacturers> SecondaryLookup = new(new SmallManufacturers());

    public static string? GetManufacturer(ReadOnlySpan<char> value)
    {
        if (value.Length < 3) return null;
        var mainWmi = value[..3].ToString();
        if (value[2] == '9')
        {
            if (!SecondaryLookup.TryGetTarget(out var secondary))
            {
                secondary = new SmallManufacturers();
                SecondaryLookup.SetTarget(secondary);
            }

            var result = secondary.GetManufacturer(mainWmi, value[11..14].ToString());
            if (result is not null) return result;
        }

        if (!MainLookup.TryGetTarget(out var main))
        {
            main = new Manufacturers();
            MainLookup.SetTarget(main);
        }

        return main.GetManufacturer(mainWmi);
    }

    public static bool IsSmallManufacturer(ReadOnlySpan<char> value)
    {
        if (value.Length < 3) return false;
        return value[2] == '9';
    }
}