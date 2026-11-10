using Godot;

namespace NationalSpire;

public static class CareerVisuals
{
    private static Font? _font;
    private static Theme? _theme;

    private static Font InterfaceFont()
    {
        if (_font != null && GodotObject.IsInstanceValid(_font)) return _font;
        // 与原版简体中文 MegaLabel 使用相同的 MSDF 字体，保持界面缩放后的字形清晰。
        // 只读取共享资源，不修改原版字体；资源路径变化或独立界面测试时保留中文回退。
        const string path = "res://themes/fonts/zhs/noto_sans_mono_cjksc_regular_shared.tres";
        if (ResourceLoader.Exists(path) && ResourceLoader.Load<Font>(path) is { } font) return _font = font;
        return _font = new SystemFont
        {
            FontNames = ["Microsoft YaHei UI", "Microsoft YaHei", "Noto Sans CJK SC"],
            AllowSystemFallback = true, MultichannelSignedDistanceField = true,
            MsdfPixelRange = 24, MsdfSize = 48
        };
    }
    private static readonly Dictionary<(int Weight,int Tracking),FontVariation> TextFonts = new();
    private static Font? _rasterFace;
    private static readonly Lazy<SystemFont> ColorEmoji = new(() => new SystemFont {
        FontNames = ["Segoe UI Emoji", "Apple Color Emoji", "Noto Color Emoji"],
        AllowSystemFallback = true, MultichannelSignedDistanceField = false
    });
    internal static Font EmojiFont => ColorEmoji.Value;
    private static int _fontDensity = 1;

    internal static void FitTextDensity(float outputScale)
    {
        int density = Mathf.NearestPo2(Math.Max(1, Mathf.CeilToInt(outputScale - .001f)));
        if (density == _fontDensity) return;
        _fontDensity = density;
        if (_rasterFace is FontFile file) file.Oversampling = density;
        else if (_rasterFace is SystemFont system) system.Oversampling = density;
    }

    internal static Font InterfaceText(int weight = 400, int tracking = 0)
    {
        if (TextFonts.TryGetValue((weight,tracking),out var cached) && GodotObject.IsInstanceValid(cached)) return cached;
        var native = InterfaceFont();
        var variant = native is FontVariation original ? (FontVariation)original.Duplicate(false) : new FontVariation { BaseFont = native };
        variant.Fallbacks = [EmojiFont, .. variant.Fallbacks];
        variant.SpacingGlyph += tracking;
        if (weight >= 700) variant.VariationEmbolden += .6f;
        return TextFonts[(weight,tracking)] = variant;
    }

    private static FontVariation? _cashFont;
    internal static Font CashFont()
    {
        if (_cashFont != null && GodotObject.IsInstanceValid(_cashFont)) return _cashFont;
        // The large balance needs filled outlines at the physical display density.
        // All mixed UI text and avatar badges keep the game's original MSDF rendering.
        var variant = (FontVariation)InterfaceText(700,2).Duplicate(false);
        _rasterFace = (Font)variant.BaseFont.Duplicate(false);
        if (_rasterFace is FontFile file) { file.MultichannelSignedDistanceField = false; file.Oversampling = _fontDensity; }
        else if (_rasterFace is SystemFont system) { system.MultichannelSignedDistanceField = false; system.Oversampling = _fontDensity; }
        variant.BaseFont = _rasterFace;
        return _cashFont = variant;
    }

    public static readonly Color Ink = new("f2f6fa"), Muted = new("aabecb"), Gold = new("eed39b"), Teal = new("80e7db"), Lime = new("c4f36b");
    public static void ClearContent(Node parent)
    {
        using var timing = UiPerformance.Measure(UiPerformance.Work.Clear);
        // 保留父级主题直到销毁，避免移出场景树时全部文本切回默认字体并重新排版。
        // 隐藏后容器立即忽略旧内容，真正销毁交给帧末处理。
        foreach (var child in parent.GetChildren())
        {
            if (child.IsQueuedForDeletion()) continue;
            if (child is CanvasItem item) item.Hide();
            child.ProcessMode = Node.ProcessModeEnum.Disabled;
            child.Name = "Retired_" + child.GetInstanceId();
            child.QueueFree();
        }
    }
    public static Node? FindContent(Node parent, string name)
    {
        foreach (var child in parent.GetChildren())
        {
            if (child.IsQueuedForDeletion()) continue;
            if (child.Name == name) return child;
            if (FindContent(child, name) is { } found) return found;
        }
        return null;
    }
    public static StyleBoxFlat Box(string fill, string border = "304554", int radius = 8, int padding = 20) => new()
    {
        BgColor = new Color(fill), BorderColor = new Color(border), BorderWidthLeft = 1, BorderWidthRight = 1,
        BorderWidthTop = 1, BorderWidthBottom = 1, CornerRadiusTopLeft = radius, CornerRadiusTopRight = radius,
        CornerRadiusBottomLeft = radius, CornerRadiusBottomRight = radius,
        ContentMarginLeft = padding, ContentMarginRight = padding, ContentMarginTop = padding, ContentMarginBottom = padding
    };
    public static Theme CreateTheme()
    {
        if (_theme != null && GodotObject.IsInstanceValid(_theme)) return _theme;
        var theme = new Theme { DefaultFontSize = 19 };
        theme.DefaultFont = InterfaceText(tracking: 0);
        foreach (string type in new[] { "Button", "OptionButton", "MenuButton", "CheckBox" })
        {
            theme.SetStylebox("normal", type, Box("1d3040", "395365", 8, 14));
            theme.SetStylebox("hover", type, Box("28495a", "70d4bc", 8, 14));
            theme.SetStylebox("pressed", type, Box("304f60", "e5c18b", 8, 14));
            theme.SetStylebox("hover_pressed", type, Box("304f60", "70d4bc", 8, 14));
            theme.SetStylebox("disabled", type, Box("111e2b", "263746", 8, 14));
            var focus = Box("00000000", "789aa4", 8, 0);
            focus.BorderWidthLeft = focus.BorderWidthTop = focus.BorderWidthRight = focus.BorderWidthBottom = 2;
            theme.SetStylebox("focus", type, focus);
            theme.SetColor("font_color", type, Ink);
            theme.SetColor("font_hover_color", type, Colors.White);
            theme.SetColor("font_pressed_color", type, Gold);
            theme.SetColor("font_disabled_color", type, new Color("9baebb"));
        }
        // 覆盖原版主题的复选图标；所有状态使用同样尺寸，文字位置不随按下状态变化。
        foreach (bool selected in new[] { false, true })
        {
            using var image = new Image();
            image.LoadSvgFromString("<svg xmlns='http://www.w3.org/2000/svg' width='20' height='20'><rect x='1' y='1' width='18' height='18' rx='4' fill='#142536' stroke='#82b8bc' stroke-width='2'/>"
                + (selected ? "<path d='M5 10 L9 14 L15 6' fill='none' stroke='#70d4bc' stroke-width='2.5'/>" : "") + "</svg>");
            var icon = ImageTexture.CreateFromImage(image);
            string state = selected ? "checked" : "unchecked";
            theme.SetIcon(state, "CheckBox", icon); theme.SetIcon(state + "_disabled", "CheckBox", icon);
        }
        theme.SetConstant("h_separation", "CheckBox", 10);
        foreach (bool on in new[] {false,true})
        foreach (bool disabled in new[] {false,true})
        {
            using var svg = new Image();
            string track = disabled ? "#384956" : on ? "#80e7db" : "#546774";
            string knob = disabled ? "#9ca9b0" : on ? "#123b3b" : "#e0e8eb";
            svg.LoadSvgFromString($"<svg xmlns='http://www.w3.org/2000/svg' width='34' height='20'><rect x='1' y='1' width='32' height='18' rx='9' fill='{track}'/><circle cx='{(on?24:10)}' cy='10' r='6' fill='{knob}'/></svg>");
            var icon = ImageTexture.CreateFromImage(svg);
            string key = (on ? "checked" : "unchecked") + (disabled ? "_disabled" : "");
            theme.SetIcon(key,"CheckButton",icon);
        }
        foreach (string state in new[]{"normal","disabled","pressed","hover","hover_pressed"})
        {
            bool lit=state is "pressed" or "hover" or "hover_pressed";
            theme.SetStylebox(state,"CheckButton",Box(lit?"28434c":"142632",lit?"658c91":"395365",5,6));
        }
        theme.SetStylebox("focus","CheckButton",Box("00000000","80e7db",5,0));
        theme.SetFontSize("font_size","CheckButton",15);
        theme.SetConstant("check_v_offset","CheckButton",0);
        theme.SetConstant("h_separation","CheckButton",8);
        theme.SetStylebox("normal", "LineEdit", Box("101c2a", "395365", 8, 12));
        theme.SetStylebox("focus", "LineEdit", Box("172e3e", "70d4bc", 8, 12));
        theme.SetStylebox("panel", "PopupMenu", Box("122331"));
        theme.SetStylebox("hover", "PopupMenu", Box("28495a", radius: 4, padding: 8));
        theme.SetColor("font_color", "Label", Ink);
        theme.SetColor("font_color", "LineEdit", Ink);
        theme.SetColor("font_placeholder_color", "LineEdit", Muted);
        theme.SetColor("font_color", "TextEdit", Ink);
        theme.SetColor("font_placeholder_color", "TextEdit", Muted);
        theme.SetColor("caret_color", "TextEdit", Gold);
        theme.SetStylebox("scroll", "VScrollBar", Box("0b1520", "0b1520", 3, 4));
        theme.SetStylebox("grabber", "VScrollBar", Box("425c6b", "425c6b", 3, 4));
        theme.SetStylebox("grabber_highlight", "VScrollBar", Box("69dfd3", "69dfd3", 3, 4));
        theme.SetStylebox("grabber_pressed", "VScrollBar", Box("c4f36b", "c4f36b", 3, 4));
        theme.SetConstant("separation", "VBoxContainer", 12);
        theme.SetConstant("separation", "HBoxContainer", 16);
        return _theme = theme;
    }
}

public partial class CareerArt : Control
{
    public bool Compact { get; set; }
    public override void _Ready() { MouseFilter = MouseFilterEnum.Ignore; Resized += QueueRedraw; }
    public override void _Draw()
    {
        var center = new Vector2(Size.X * (Compact ? .5f : .65f), Size.Y * .47f);
        float r = Math.Min(Size.X, Size.Y) * .34f;
        var faint = new Color(.44f, .83f, .74f, .14f);
        DrawArc(center, r, 0, Mathf.Tau, 96, faint, 1.5f, true);
        DrawArc(center, r * .78f, -.8f, 3.6f, 64, new Color("587e72"), 2, true);
        DrawLine(center + new Vector2(-r * 1.35f, 0), center + new Vector2(r * 1.35f, 0), faint, 1, true);
        DrawLine(center + new Vector2(0, -r * 1.35f), center + new Vector2(0, r * 1.35f), faint, 1, true);
        Vector2 P(float x, float y) => center + new Vector2(x, y) * r;
        DrawColoredPolygon([P(-.6f, .85f), P(-.38f, -.12f), P(-.14f, .05f), P(.1f, -1.02f), P(.34f, -.35f), P(.44f, .85f)], new Color("355c56"));
        DrawPolyline([P(-.6f,.85f), P(-.38f,-.12f), P(-.14f,.05f), P(.1f,-1.02f), P(.34f,-.35f), P(.44f,.85f)], CareerVisuals.Gold, 2, true);
        for (int i = 0; i < 4; i++) DrawLine(P(-.05f, .16f + i * .17f), P(.23f, .16f + i * .17f), new Color("9ba886"), 2, true);
        DrawCircle(P(.1f, -1.13f), 4, CareerVisuals.Gold);
    }
}
