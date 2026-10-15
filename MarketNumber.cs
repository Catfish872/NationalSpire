using System.Globalization;
using System.Numerics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NationalSpire;

/// <summary>成交数量及中间金额采用28位小数，整数部分按实际数值扩展。</summary>
[JsonConverter(typeof(MarketNumberConverter))]
public readonly record struct MarketNumber : IComparable<MarketNumber>
{
    private static readonly BigInteger Scale = BigInteger.Pow(10, 28);
    private readonly BigInteger value;
    private MarketNumber(BigInteger scaled) => value = scaled;
    public static implicit operator MarketNumber(decimal number)
    {
        var bits = decimal.GetBits(number);
        var integer = (BigInteger)(uint)bits[0] | ((BigInteger)(uint)bits[1] << 32) | ((BigInteger)(uint)bits[2] << 64);
        integer *= BigInteger.Pow(10, 28 - ((bits[3] >> 16) & 255));
        return new(bits[3] < 0 ? -integer : integer);
    }
    public static explicit operator decimal(MarketNumber number)
        => decimal.Parse(number.ToString(), NumberStyles.Number, CultureInfo.InvariantCulture);
    public static explicit operator double(MarketNumber number) => (double)number.value / (double)Scale;
    public static MarketNumber operator +(MarketNumber a, MarketNumber b) => new(a.value + b.value);
    public static MarketNumber operator -(MarketNumber a, MarketNumber b) => new(a.value - b.value);
    public static MarketNumber operator -(MarketNumber a) => new(-a.value);
    public static MarketNumber operator *(MarketNumber a, MarketNumber b) => new(a.value * b.value / Scale);
    public static MarketNumber operator /(MarketNumber a, MarketNumber b) => new(a.value * Scale / b.value);
    public static bool operator <(MarketNumber a, MarketNumber b) => a.value < b.value;
    public static bool operator >(MarketNumber a, MarketNumber b) => a.value > b.value;
    public static bool operator <=(MarketNumber a, MarketNumber b) => a.value <= b.value;
    public static bool operator >=(MarketNumber a, MarketNumber b) => a.value >= b.value;
    public int CompareTo(MarketNumber other) => value.CompareTo(other.value);
    public static MarketNumber Max(MarketNumber a, MarketNumber b) => a >= b ? a : b;
    public static MarketNumber Round(MarketNumber number, int digits)
    {
        var step = BigInteger.Pow(10, 28 - digits);
        var whole = BigInteger.DivRem(number.value, step, out var rest);
        int compare = (BigInteger.Abs(rest) * 2).CompareTo(step);
        if (compare > 0 || compare == 0 && !whole.IsEven) whole += number.value.Sign;
        return new(whole * step);
    }
    public override string ToString() => ToString(null);
    public string ToString(string? format)
    {
        var n = format == null ? this : Round(this, format.Contains(".##") ? 2 : 0);
        var integer = BigInteger.DivRem(BigInteger.Abs(n.value), Scale, out var fraction);
        string decimals = fraction.IsZero ? "" : "." + fraction.ToString("D28", CultureInfo.InvariantCulture).TrimEnd('0');
        return (n.value.Sign < 0 ? "-" : "") + integer.ToString(format?.Contains(',') == true ? "N0" : "D", CultureInfo.InvariantCulture) + decimals;
    }
    public static MarketNumber Parse(string text)
    {
        int exponentAt = text.IndexOfAny(['e', 'E']);
        int exponent = exponentAt < 0 ? 0 : int.Parse(text[(exponentAt + 1)..], CultureInfo.InvariantCulture);
        if (exponentAt >= 0) text = text[..exponentAt];
        int point = text.IndexOf('.'), places = point < 0 ? 0 : text.Length - point - 1;
        var integer = BigInteger.Parse(text.Replace(".", ""), CultureInfo.InvariantCulture);
        int shift = 28 + exponent - places;
        return new(shift >= 0 ? integer * BigInteger.Pow(10, shift) : integer / BigInteger.Pow(10, -shift));
    }
}

public sealed class MarketNumberConverter : JsonConverter<MarketNumber>
{
    public override MarketNumber Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
    {
        using var document = JsonDocument.ParseValue(ref reader);
        return MarketNumber.Parse(document.RootElement.GetRawText());
    }
    public override void Write(Utf8JsonWriter writer, MarketNumber value, JsonSerializerOptions options)
        => writer.WriteRawValue(value.ToString());
}
