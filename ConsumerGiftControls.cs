using Godot;
using System.Globalization;

namespace NationalSpire;

/// <summary>商城与赠礼共用的横向整数输入，支持按钮和光标编辑。</summary>
public partial class ConsumerQuantity : HBoxContainer
{
    public int Value { get; private set; }
    public bool Valid { get; private set; } = true;
    public int Minimum { get; init; }
    public int Maximum { get; init; } = int.MaxValue;
    public event Action? Changed;
    private LineEdit _number = null!;
    public string InputText => _number.Text;
    public ConsumerQuantity()
    {
        AddThemeConstantOverride("separation", 0);
        SizeFlagsHorizontal = SizeFlags.ShrinkBegin; SizeFlagsVertical = SizeFlags.ShrinkCenter;
    }
    public void Initialize(int value)
    {
        Button Action(string text, int delta)
        {
            var b = new Button { Text = text, CustomMinimumSize = new(32, 48), FocusMode = FocusModeEnum.None };
            foreach (var (state, fill) in new[] { ("normal", "243e52"), ("hover", "34556b"), ("pressed", "304f60") })
            {
                var style = CareerVisuals.Box(fill, "55778c", 6, 5);
                if (delta < 0) style.CornerRadiusTopRight = style.CornerRadiusBottomRight = style.BorderWidthRight = 0;
                else style.CornerRadiusTopLeft = style.CornerRadiusBottomLeft = style.BorderWidthLeft = 0;
                b.AddThemeStyleboxOverride(state, style);
            }
            foreach (string state in new[] { "font_color", "font_hover_color", "font_pressed_color", "font_focus_color" }) b.AddThemeColorOverride(state, new Color("c8ebed"));
            b.AddThemeFontSizeOverride("font_size", 17);
            b.Pressed += () => { SetValue((int)Math.Clamp((long)Value + delta, Minimum, Maximum)); Changed?.Invoke(); }; return b;
        }
        AddChild(Action("-", -1));
        _number = new LineEdit { Alignment = HorizontalAlignment.Center, CustomMinimumSize = new(40, 48), SelectAllOnFocus = true, MaxLength = 10 };
        _number.AddThemeConstantOverride("minimum_character_width", 1);
        _number.AddThemeStyleboxOverride("normal", CareerVisuals.Box("102331", "55778c", 0, 4));
        _number.AddThemeStyleboxOverride("focus", CareerVisuals.Box("193345", "8bd4d8", 0, 4));
        _number.AddThemeFontSizeOverride("font_size", 17); AddChild(_number); AddChild(Action("+", 1));
        SetValue(value);
        _number.TextChanged += text =>
        {
            RestoreText(text); Changed?.Invoke();
        };
    }
    public void RestoreText(string text)
    {
        _number.Text = text;
        Valid = int.TryParse(text, NumberStyles.None, CultureInfo.InvariantCulture, out int next) && next >= Minimum && next <= Maximum;
        if (Valid) Value = next;
        _number.Modulate = Valid ? Colors.White : new Color("f397a9");
    }
    public void SetValue(int value)
    { Value = Math.Clamp(value, Minimum, Maximum); Valid = true; _number.Text = Value.ToString(CultureInfo.InvariantCulture); _number.Modulate = Colors.White; }
}

public partial class GiftRingMark : Control
{
    public bool Completed { get; init; }
    public GiftRingMark() { CustomMinimumSize = new(20, 20); MouseFilter = MouseFilterEnum.Ignore; }
    public override void _Draw() => DrawDiamond(this, new Rect2(Vector2.Zero, Size), Completed, Colors.White);
    public static void DrawDiamond(CanvasItem canvas, Rect2 bounds, bool completed, Color color)
    {
        var center = bounds.GetCenter(); float scale = Math.Min(bounds.Size.X, bounds.Size.Y) / 20;
        Vector2[] gem = [center + new Vector2(-4, -6) * scale, center + new Vector2(4, -6) * scale, center + new Vector2(8, -1) * scale, center + new Vector2(0, 7) * scale, center + new Vector2(-8, -1) * scale];
        if (completed) canvas.DrawColoredPolygon(gem, color);
        else
        {
            canvas.DrawPolyline([.. gem, gem[0]], color, 1.5f * scale, true);
            canvas.DrawLine(gem[4], gem[2], color, scale, true);
        }
    }
}

public partial class CareerScreen
{
    private static void PickerRing(HBoxContainer row, CareerData data, string person)
    {
        var button = row.GetChildren().OfType<Button>().FirstOrDefault(); if (button == null) return;
        foreach (var previous in button.GetChildren().OfType<GiftRingMark>().ToArray()) { button.RemoveChild(previous); previous.QueueFree(); }
        var relation = PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(person);
        foreach (string state in new[] { "normal", "hover", "pressed", "hover_pressed", "disabled", "focus" })
        {
            string key = "gift_ring_padding_" + state;
            if (relation?.RingReceived != true && !button.HasMeta(key)) continue;
            if (button.GetThemeStylebox(state) is not StyleBoxFlat original) continue;
            if (!button.HasMeta(key)) button.SetMeta(key, original.ContentMarginRight);
            var style = (StyleBoxFlat)original.Duplicate();
            style.ContentMarginRight = button.GetMeta(key).AsSingle() + (relation?.RingReceived == true ? 28 : 0);
            button.AddThemeStyleboxOverride(state, style);
        }
        if (relation?.RingReceived != true) return;
        var mark = new GiftRingMark { Name = "PickerOathMark", Completed = relation.WeddingCompleted };
        button.AddChild(mark); mark.SetAnchorsAndOffsetsPreset(LayoutPreset.CenterRight);
        mark.OffsetLeft = -32; mark.OffsetRight = -12; mark.OffsetTop = -10; mark.OffsetBottom = 10;
    }
}
