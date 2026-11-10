using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private static readonly string[] ButtonStates = ["normal", "hover", "pressed", "hover_pressed", "disabled"];

    private static Theme? _dashboardTheme;
    private static Theme DashboardTheme()
    {
        if (_dashboardTheme!=null && IsInstanceValid(_dashboardTheme)) return _dashboardTheme;
        var theme=(Theme)CareerVisuals.CreateTheme().Duplicate(false);
        theme.DefaultFont=CareerVisuals.InterfaceText();
        return _dashboardTheme=theme;
    }

    private static ColorRect Hairline(string color="3a536080") => new()
    {
        Color=new Color(color), CustomMinimumSize=new(0,1), MouseFilter=MouseFilterEnum.Ignore
    };

    private static void ButtonIcon(Button button, string icon, int size, bool trailing=false)
    {
        button.Icon = NavigationIcon(icon); button.ExpandIcon = true;
        button.IconAlignment = trailing ? HorizontalAlignment.Right : HorizontalAlignment.Left;
        button.AddThemeConstantOverride("icon_max_width",size);
        button.AddThemeConstantOverride("h_separation",10);
    }

    private static Button TextLink(string title, Action action, int size=15, bool underline=false, string? icon=null)
    {
        var button = new Button { Text=title, MouseDefaultCursorShape=CursorShape.PointingHand,
            SizeFlagsHorizontal=SizeFlags.ShrinkBegin, SizeFlagsVertical=SizeFlags.ShrinkCenter };
        button.AddThemeFontSizeOverride("font_size",size);
        ButtonSurface(button,"00000000","00000000","00000000","00000000");
        button.AddThemeColorOverride("font_color",CareerVisuals.Teal);
        foreach (string state in new[]{"font_hover_color","font_focus_color","font_pressed_color","font_hover_pressed_color"})
            button.AddThemeColorOverride(state,CareerVisuals.Gold);
        button.AddThemeStyleboxOverride("focus",new StyleBoxEmpty());
        if (icon != null)
        {
            ButtonIcon(button,icon,17,trailing:true);
            button.CustomMinimumSize = new(Mathf.Ceil(CareerVisuals.InterfaceText().GetStringSize(title,fontSize:size).X)+27,30);
            foreach (string state in new[]{"normal","hover","focus","pressed","hover_pressed"})
                button.AddThemeColorOverride("icon_"+state+"_color",state=="normal"?CareerVisuals.Teal:CareerVisuals.Gold);
        }
        if (underline) button.Draw+=()=>button.DrawLine(new(0,button.Size.Y-1),new(button.Size.X,button.Size.Y-1),
            button.IsHovered() || button.HasFocus() ? CareerVisuals.Gold : CareerVisuals.Teal);
        button.MouseEntered+=button.QueueRedraw; button.MouseExited+=button.QueueRedraw;
        button.Pressed+=action;
        return button;
    }

    // Shared only by ButtonSurface; callers replace the override to change a state.
    private static readonly Dictionary<(string Fill, string Border, int Radius, int Padding), StyleBoxFlat> SurfaceStyles = new();
    private static StyleBoxFlat SurfaceStyle(string fill, string border, int radius, int padding)
    {
        var key = (fill, border, radius, padding);
        if (!SurfaceStyles.TryGetValue(key, out var style))
            SurfaceStyles[key] = style = CareerVisuals.Box(fill, border, radius, padding);
        return style;
    }

    // Godot includes the largest style margin from every state in a Button's minimum size.
    private static void ButtonSurface(Button button, string fill, string border, string hoverFill,
        string hoverBorder, int padding = 0, int radius = 5)
    {
        foreach (var state in ButtonStates)
        {
            bool hover = state is "hover" or "pressed" or "hover_pressed";
            button.AddThemeStyleboxOverride(state, SurfaceStyle(hover ? hoverFill : fill,
                hover ? hoverBorder : border, radius, padding));
        }
        var focus = SurfaceStyle("00000000", "80e7db", radius, 0);
        button.AddThemeStyleboxOverride("focus", focus);
    }

    private static Button FramedAction(string title, Action action, string? icon = null,
        bool trailing = false, int width = 0, int height = 42, bool quiet = false, Color? ink = null, Color? iconColor = null)
    {
        var button = new Button { Text = title, CustomMinimumSize = new(width,height),
            MouseDefaultCursorShape = CursorShape.PointingHand, ExpandIcon = true,
            IconAlignment = trailing ? HorizontalAlignment.Right : HorizontalAlignment.Left };
        button.AddThemeFontSizeOverride("font_size", 17);
        button.AddThemeConstantOverride("h_separation", 9);
        button.AddThemeColorOverride("font_color",ink??CareerVisuals.Ink);
        ButtonSurface(button, quiet ? "00000000" : "1d3040", quiet ? "304a5a" : "395365", "28434c", "658c91", 6);
        if (icon != null)
        {
            button.Text=""; button.AccessibilityName=title;
            var group=new HBoxContainer {Name="ButtonCaption",Alignment=BoxContainer.AlignmentMode.Center,MouseFilter=MouseFilterEnum.Ignore};
            group.AddThemeConstantOverride("separation",9); button.AddChild(group); group.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
            var label=DashboardLabel(title,17,ink??CareerVisuals.Ink); label.SizeFlagsHorizontal=SizeFlags.ShrinkCenter;
            if(!trailing) group.AddChild(Glyph(icon,19,iconColor??ink??CareerVisuals.Ink));
            group.AddChild(label);
            if(trailing) group.AddChild(Glyph(icon,17,iconColor??ink??CareerVisuals.Ink));
            button.CustomMinimumSize=new(Math.Max(width,group.GetCombinedMinimumSize().X+24),height);
        }
        button.Pressed += action;
        return button;
    }

    private static CheckButton DashboardSwitch(string label,bool value,Action<bool> changed,int width,int height)
    {
        var toggle = new CheckButton { Text = label, ButtonPressed = value, Alignment = HorizontalAlignment.Left,
            SizeFlagsVertical = SizeFlags.ShrinkCenter, CustomMinimumSize = new(width,height), MouseDefaultCursorShape = CursorShape.PointingHand };
        toggle.Toggled += on => changed(on);
        return toggle;
    }

    private static TextureRect Glyph(string name, int size, Color color)
    {
        return new TextureRect { Texture = NavigationIcon(name), CustomMinimumSize = new(size,size),
            ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered,
            SizeFlagsVertical = SizeFlags.ShrinkCenter, MouseFilter = MouseFilterEnum.Ignore, SelfModulate = color };
    }

    private static Label DashboardLabel(string title, int size, Color color, bool wrap = false)
    {
        var label = Text(title,size,color);
        label.AutowrapMode = wrap ? TextServer.AutowrapMode.WordSmart : TextServer.AutowrapMode.Off;
        label.AddThemeConstantOverride("line_spacing", 1);
        return label;
    }

    private static MarginContainer Inset(int horizontal, int vertical)
    {
        var inset = new MarginContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore };
        inset.AddThemeConstantOverride("margin_left", horizontal);
        inset.AddThemeConstantOverride("margin_right", horizontal);
        inset.AddThemeConstantOverride("margin_top", vertical);
        inset.AddThemeConstantOverride("margin_bottom", vertical);
        return inset;
    }

    // Content participates in minimum-size negotiation. One hit surface covers the complete row.
    private static Button ActionRow(Container parent, string name, string title, Action action, Control content,
        int height, int insetX, int insetY, string fill, string border, string hover)
    {
        var row = new MarginContainer { Name = name, CustomMinimumSize = new(0,height), SizeFlagsHorizontal = SizeFlags.ExpandFill };
        parent.AddChild(row);
        var button = new Button { Name = "Action", AccessibilityName = title, MouseDefaultCursorShape = CursorShape.PointingHand };
        ButtonSurface(button, fill, border, hover, border);
        button.Pressed += action;
        row.AddChild(button);
        var inset = Inset(insetX,insetY);
        row.AddChild(inset);
        inset.AddChild(content);
        content.MouseFilter = MouseFilterEnum.Ignore;
        return button;
    }

    private static void Baseline(Control strip)
    {
        strip.Draw += () => strip.DrawLine(new(0,strip.Size.Y-1),new(strip.Size.X,strip.Size.Y-1),new Color("47627299"));
        strip.Resized += strip.QueueRedraw;
    }
}
