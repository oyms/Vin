using System.Diagnostics;
using Skaar.ValueType;

namespace Skaar.VehicleData.Model;

/// <summary>
/// This type represents a year.
/// </summary>
[DebuggerDisplay("{_value:0000}")]
[ValueType<int>]
public partial struct Year : System.Numerics.ISubtractionOperators<Year, Year, int>
{
    public static int operator -(Year left, Year right) => left._value - right._value;
    public static explicit operator Year(DateOnly date) => date.Year;
    public static explicit operator Year(DateTime date) => date.Year;
    public static explicit operator Year(DateTimeOffset date) => date.Year;
    public static implicit operator DateOnly(Year year) => new(year._value, 1, 1);
    public static implicit operator DateTime(Year year) => new(year._value, 1, 1);
    public static implicit operator DateTimeOffset(Year year) => new(year, TimeSpan.Zero);
}