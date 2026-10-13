using Godot;
using ForexSpire;
using System.Globalization;

namespace NationalSpire;

public partial class ForexChart : Control
{
    public ForexCandle[] Bars { get; init; } = [];
    public int VisibleBars { get; init; } = 60;
    public int Digits { get; init; } = 4;
    public override void _Ready() { Resized += QueueRedraw; QueueRedraw(); }
    public override void _Draw()
    {
        DrawRect(new Rect2(Vector2.Zero, Size), new Color("0e2023"));
        if (Bars.Length == 0 || Size.X < 150 || Size.Y < 80) return;
        float left = 10, right = Size.X - 76, top = 15, bottom = Size.Y - 25;
        int start = Math.Max(0, Bars.Length - VisibleBars), count = Bars.Length - start;
        double min = Bars.Skip(start).Min(c => c.Low), max = Bars.Skip(start).Max(c => c.High);
        double padding = Math.Max((max - min) * .09, Math.Max(Math.Abs(max) * .001, .00001));
        min -= padding; max += padding;
        float Y(double value) => bottom - (float)((value - min) / (max - min)) * (bottom - top);
        var font = GetThemeDefaultFont();
        for (int i = 0; i <= 4; i++)
        {
            float y = top + (bottom - top) * i / 4;
            DrawLine(new(left, y), new(right, y), new Color("24413c"));
            DrawString(font, new(right + 6, y + 4), (max - (max - min) * i / 4).ToString("F" + Digits, CultureInfo.InvariantCulture),
                fontSize: 11, modulate: new Color("7e9a94"));
        }
        float step = (right - left) / count, width = Math.Max(2, Math.Min(12, step * .65f));
        for (int i = 0; i < count; i++)
        {
            var candle = Bars[start + i]; float x = left + (i + .5f) * step;
            Color color = candle.Close >= candle.Open ? new("8fddb1") : new("f19aa8");
            DrawLine(new(x, Y(candle.High)), new(x, Y(candle.Low)), color, 1, true);
            float bodyTop = Math.Min(Y(candle.Open), Y(candle.Close));
            float height = Math.Max(1.5f, Math.Abs(Y(candle.Open) - Y(candle.Close)));
            DrawRect(new(new Vector2(x - width / 2, bodyTop), new Vector2(width, height)), color);
            if (i % 10 == 0) DrawLine(new(x, top), new(x, bottom), new Color("1c343630"), 1);
        }
        float currentY = Y(Bars[^1].Close);
        DrawDashedLine(new(left, currentY), new(right, currentY), new Color("c9d8a8"), 1, 4);
        string Day(ForexCandle c) => c.Day < 1 ? "历史" : "D" + c.Day;
        DrawString(font, new(left, Size.Y - 6), Day(Bars[start]), fontSize: 11, modulate: new Color("5f7d78"));
        DrawString(font, new(Math.Max(left, right - 45), Size.Y - 6), Day(Bars[^1]), fontSize: 11, modulate: new Color("5f7d78"));
    }
}
