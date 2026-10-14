using Godot;

namespace NationalSpire;

/// <summary>市场专用样式在主线程按类别缓存，不修改全局主题或字体。</summary>
internal static class MarketVisuals
{
    private static readonly Dictionary<(string, bool, bool), StyleBoxFlat> Cards = [];
    public static Color Accent(string sector) => new(sector switch {
        "训练装备" => "e4b367", "电竞设备" => "a99aef", "日常消费" => "70d4bc", _ => "81b8ec" });
    public static StyleBoxFlat Card(string sector, bool selected, bool hover = false)
    {
        var key = (sector, selected, hover);
        if (Cards.TryGetValue(key, out var style)) return style;
        var accent = Accent(sector);
        style = CareerVisuals.Box("0e1e2b", "345363", 9, 12);
        style.BgColor = new Color(new Color("10202d").Lerp(accent, selected ? .19f : hover ? .13f : .055f), .94f);
        style.BorderColor = new Color(accent, selected ? .95f : hover ? .65f : .26f);
        style.BorderWidthLeft = selected ? 4 : 3;
        return Cards[key] = style;
    }
    public static void Style(Button button, string sector, bool selected = false)
    {
        button.AddThemeStyleboxOverride("normal", Card(sector, selected));
        button.AddThemeStyleboxOverride("hover", Card(sector, selected, true));
        button.AddThemeStyleboxOverride("pressed", Card(sector, true));
    }
    public static Color LevelColor(int level) => new(level switch {
        <= 2 => "b96c7c", <= 4 => "e4ab65", <= 6 => "70d4bc", <= 8 => "ad9ded", _ => "f0cf85" });
}

internal partial class MarketAssetButton : Button
{
    private readonly Label _name = new(), _sector = new(), _price = new(), _change = new();
    private readonly TextureRect _icon = new() { CustomMinimumSize = new(23, 23), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize,
        StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore };
    internal MarketAssetButton()
    {
        SizeFlagsHorizontal = SizeFlags.ExpandFill; CustomMinimumSize = new(0, 92);
        var margin = new MarginContainer { MouseFilter = MouseFilterEnum.Ignore };
        margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        foreach (var side in new[] { "left", "right", "top", "bottom" }) margin.AddThemeConstantOverride("margin_" + side, side == "left" ? 14 : 9);
        AddChild(margin);
        var box = new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore }; margin.AddChild(box);
        var heading = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }; box.AddChild(heading); heading.AddChild(_icon); heading.AddChild(_name);
        box.AddChild(_sector);
        var quote = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }; box.AddChild(quote); quote.AddChild(_price); quote.AddChild(_change);
        foreach (var label in new[] { _name, _sector, _price, _change })
        {
            label.MouseFilter = MouseFilterEnum.Ignore; label.ClipText = true; label.SizeFlagsHorizontal = SizeFlags.ExpandFill;
            label.AddThemeFontSizeOverride("font_size", label == _sector ? 12 : 16);
        }
        _name.SizeFlagsStretchRatio = 5; _change.HorizontalAlignment = HorizontalAlignment.Right;
        _name.AddThemeColorOverride("font_color", new Color("e5eef2"));
    }
    internal void Bind(MarketAsset asset, MarketQuote quote, bool watched, bool selected)
    {
        _name.Text = (watched ? "★ " : "") + asset.Name; _sector.Text = asset.Country + "  /  " + asset.Sector;
        _sector.AddThemeColorOverride("font_color", MarketVisuals.Accent(asset.Sector));
        _icon.Texture = LifestyleArt.Icon(asset.Sector);
        _price.Text = asset.Forex ? quote.Price.ToString("0.0000") : CareerMoney.Format(quote.Price);
        decimal change = quote.Price / quote.Previous - 1;
        _change.Text = $"{change:+0.00%;-0.00%;0.00%}";
        _change.AddThemeColorOverride("font_color", change >= 0 ? CareerVisuals.Teal : new Color("f095a3"));
        TooltipText = asset.Name + " · " + asset.Country + " · " + asset.Sector;
        MarketVisuals.Style(this, asset.Sector, selected);
    }
}

internal partial class DevelopmentGauge : Control
{
    public int Level { get; init; }
    public DevelopmentGauge() { CustomMinimumSize = new(0, 16); SizeFlagsHorizontal = SizeFlags.ExpandFill; MouseFilter = MouseFilterEnum.Ignore; Resized += QueueRedraw; }
    public override void _Draw()
    {
        float width = (Size.X - 8 * 4) / 9;
        var color = MarketVisuals.LevelColor(Level);
        for (int i = 0; i < 9; i++)
        {
            var rect = new Rect2(i * (width + 4), 1, width, Size.Y - 2);
            DrawRect(rect, i < Level ? color : new Color("0b1822"));
            DrawRect(rect, new Color(color, i < Level ? .8f : .22f), false, 1);
        }
    }
}
