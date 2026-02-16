using Skaar.ValueType;

namespace Skaar.Vin;

/// <summary>
/// A value type representing a VIN (Vehicle Identification Number).
/// </summary>
/// <seealso href="https://en.wikipedia.org/wiki/Vehicle_identification_number"/>
[ValueType]
public partial struct Vin
{
    private ReadOnlySpan<char> Clean(ReadOnlySpan<char> value)
    {
        var buffer = new char[value.Length];

        int written = 0;
        for (int i = 0; i < value.Length; i++)
        {
            char c = value[i];

            if (!char.IsLetterOrDigit(c))
                continue;

            if ((uint)(c - 'a') <= ('z' - 'a'))
                c = (char)(c - 32);
            else
                c = char.ToUpperInvariant(c);

            c = c switch
            {
                'I' => '1',
                'O' => '0',
                _ => c
            };

            buffer[written++] = c;
        }

        return buffer.AsSpan(0, written);
    }

    private bool ValueIsValid(ReadOnlySpan<char> value)
    {
        return value.Length == 17;
    }
}