using Godot;

namespace NationalSpire;

/// <summary>商城购买标记使用独立静态样式；不持有玩家资料，不修改全局主题。</summary>
internal static class ConsumerVisuals
{
    private static readonly Dictionary<(bool, bool), StyleBoxFlat> Styles = [];
    private static readonly Dictionary<(bool Current, bool Selected, bool Hover), StyleBoxFlat> Products = [];
    public static void ProductStyle(Button button, bool current, bool selected)
    {
        StyleBoxFlat Get(bool active, bool hover)
        {
            if (Products.TryGetValue((current, active, hover), out var cached)) return cached;
            var style = (StyleBoxFlat)Style(current, false).Duplicate();
            style.BgColor = new Color("10202d").Lerp(Accent(current), active ? .18f : hover ? .12f : .04f);
            style.BorderColor = new Color(Accent(current), active ? .95f : hover ? .7f : .3f);
            style.BorderWidthLeft = active ? 4 : 2;
            return Products[(current, active, hover)] = style;
        }
        button.AddThemeStyleboxOverride("normal", Get(selected, false));
        button.AddThemeStyleboxOverride("hover", Get(selected, true));
        button.AddThemeStyleboxOverride("pressed", Get(true, false));
    }
    public static Color Accent(bool current) => current ? CareerVisuals.Teal : new Color("e4c780");
    public static StyleBoxFlat Style(bool current, bool badge)
    {
        if (Styles.TryGetValue((current, badge), out var style)) return style;
        var accent = Accent(current);
        style = CareerVisuals.Box("10232e", "345363", badge ? 7 : 12, badge ? 7 : 16);
        style.BgColor = new Color(new Color("10202d").Lerp(accent, badge ? .16f : .065f), .98f);
        style.BorderColor = new Color(accent, badge ? .8f : .55f);
        if (!badge) style.BorderWidthLeft = 3;
        return Styles[(current, badge)] = style;
    }
}

/// <summary>购买勾选、收藏徽章、体验票根与宣发次数；单个绘制控件，无逐帧动画。</summary>
internal partial class ConsumerSeal : Control
{
    public bool Current { get; init; }
    public bool Ticket { get; init; }
    public bool Promo { get; init; }
    public int Count { get; init; }
    public ConsumerSeal() { CustomMinimumSize = new(24, 24); MouseFilter = MouseFilterEnum.Ignore; }
    public override void _Draw()
    {
        var color = ConsumerVisuals.Accent(Current);
        if (Promo)
        {
            for (int i = 0; i < ConsumerCatalog.PromoPerSeason; i++)
            {
                var rect = new Rect2(i * 8, 6, 5, 13);
                DrawRect(rect, i < Count ? color : new Color(color, .12f));
                DrawRect(rect, new Color(color, .7f), false);
            }
        }
        else if (Ticket)
        {
            DrawRect(new Rect2(2, 5, 20, 14), new Color(color, .18f));
            DrawRect(new Rect2(2, 5, 20, 14), color, false, 1.5f);
            DrawLine(new(16, 6), new(16, 18), color, 1.5f, true);
            DrawLine(new(5, 10), new(12, 10), color, 1.5f, true);
            DrawLine(new(5, 14), new(10, 14), color, 1.5f, true);
        }
        else if (Current)
        {
            DrawCircle(new(12, 12), 10, new Color(color, .2f));
            DrawArc(new(12, 12), 10, 0, Mathf.Tau, 32, color, 1.5f, true);
            DrawPolyline([new(6, 12), new(10, 16), new(18, 8)], color, 2.5f, true);
        }
        else
        {
            DrawColoredPolygon([new(12, 2), new(22, 12), new(12, 22), new(2, 12)], new Color(color, .2f));
            DrawPolyline([new(12, 2), new(22, 12), new(12, 22), new(2, 12), new(12, 2)], color, 1.5f, true);
            DrawCircle(new(12, 12), 3, color);
        }
    }
}
