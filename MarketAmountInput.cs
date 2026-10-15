using Godot;
using System.Globalization;

namespace NationalSpire;

/// <summary>保留玩家输入的十进制原值；SpinBox的浮点值用于原生步进和光标交互。</summary>
internal partial class MarketAmountInput : SpinBox
{
    private decimal? _entered;
    internal decimal Amount => _entered ?? (decimal)Value;
    internal MarketAmountInput()
    {
        GetLineEdit().TextChanged += text =>
        {
            _entered = decimal.TryParse(text.Trim().TrimStart('$').Trim(), NumberStyles.Float | NumberStyles.AllowThousands,
                CultureInfo.InvariantCulture, out var amount) ? amount : null;
        };
        ValueChanged += value =>
        {
            // 原生步进会再次舍入浮点表示；仅据此识别控件是否换了数值，交易仍使用十进制原值。
            if (_entered is { } entered && Math.Abs((double)entered - value) > 4 * Math.Abs(Math.BitIncrement(value) - value)) _entered = null;
        };
    }
    internal void SetAmount(decimal amount)
    {
        _entered = amount; SetValueNoSignal((double)amount);
    }
}
