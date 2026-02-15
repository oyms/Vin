using Skaar.ValueType;

namespace Skaar.Vin;

[ValueType]
public partial struct Vin
{
    private ReadOnlySpan<char> Clean(ReadOnlySpan<char> value)
    {
      return Helper.Clean.RemoveNonLettersOrDigits(value);   
    }
}