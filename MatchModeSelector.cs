using Godot;

namespace NationalSpire;

/// <summary>赛前页面与约会开局共用的模式、进阶选择栏。</summary>
public partial class MatchModeSelector : HBoxContainer
{
    public event Action<string, int>? Changed;
    public string Mode { get; private set; } = MatchModes.Standard;
    public int Level => _levels[Mode];
    public int RecordedAscension => MatchModes.RecordedAscension(Mode, Level);
    private readonly Dictionary<string, int> _levels = [];
    private readonly Dictionary<string, Button> _modes = [];
    private static readonly Dictionary<string, Texture2D> CenteredIcons = [];
    private Label _number = null!, _name = null!;
    private Button _previous = null!, _next = null!;
    private int _required;
    private bool _editable;

    public MatchModeSelector() { }
    public MatchModeSelector(CareerData data, CareerMatch match, bool editable = true)
    {
        Name = "MatchModeSelector"; _required = match.RequiredAscension; _editable = editable;
        Mode = MatchModes.Preferred(data, match);
        AddThemeConstantOverride("separation", 8);
        foreach (string mode in MatchModes.All.Where(MatchModes.Available))
        {
            _levels[mode] = MatchModes.PreferredLevel(data, match, mode);
            string path = mode switch
            {
                MatchModes.Blitz => "res://images/packed/character_select/blitz_top_bar_icon.png",
                MatchModes.Dread => "res://images/packed/character_select/dread_top_bar_icon.png",
                _ => "res://images/atlases/ui_atlas.sprites/top_bar/top_bar_ascension.tres"
            };
            var button = new Button { Name = mode + "Mode", Icon = CenteredIcon(path), IconAlignment = HorizontalAlignment.Center, ExpandIcon = true, ToggleMode = true,
                TooltipText = MatchModes.Name(mode), Disabled = !editable, CustomMinimumSize = new(46, 44),
                FocusMode = FocusModeEnum.None };
            button.AddThemeConstantOverride("icon_max_width", 30);
            button.AddThemeStyleboxOverride("normal", Style(mode, false, false));
            button.AddThemeStyleboxOverride("disabled", Style(mode, false, false));
            button.AddThemeStyleboxOverride("hover", Style(mode, false, true));
            button.AddThemeStyleboxOverride("pressed", Style(mode, true, false));
            button.AddThemeStyleboxOverride("hover_pressed", Style(mode, true, true));
            button.Pressed += () =>
            {
                if (Mode == mode) { button.SetPressedNoSignal(true); return; }
                Mode = mode; Refresh(); Changed?.Invoke(Mode, Level);
            };
            _modes.Add(mode, button); AddChild(button);
        }
        _name = new Label { CustomMinimumSize = new(82, 0), VerticalAlignment = VerticalAlignment.Center };
        _name.AddThemeFontSizeOverride("font_size", 16); AddChild(_name);
        _previous = Arrow("left", () => Adjust(-1)); AddChild(_previous);
        _number = new Label { Name = "MatchAscension", CustomMinimumSize = new(40, 44),
            HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center };
        _number.AddThemeFontSizeOverride("font_size", 28); AddChild(_number);
        _next = Arrow("right", () => Adjust(1)); AddChild(_next);
        Refresh();
    }
    private static Color Tint(string mode) => new(mode switch
    { MatchModes.Blitz => "71daca", MatchModes.Dread => "df9bb7", _ => "e9ba79" });
    private static Texture2D CenteredIcon(string path)
    {
        if (CenteredIcons.TryGetValue(path, out var cached)) return cached;
        var original = ResourceLoader.Load<Texture2D>(path);
        // 保持纹理原有尺寸，只将可见图形两侧的透明留白调整为相等。
        Rect2 region; Texture2D texture; Vector2 padding;
        if (original is AtlasTexture atlas)
        { region = atlas.Region; texture = atlas.Atlas; padding = atlas.Margin.Size; }
        else
        {
            using var image = original.GetImage();
            region = image.GetUsedRect(); texture = original; padding = original.GetSize() - region.Size;
        }
        var centered = new AtlasTexture { Atlas = texture, Region = region, Margin = new Rect2(padding / 2, padding) };
        CenteredIcons.Add(path, centered); return centered;
    }
    private static StyleBoxFlat Style(string mode, bool selected, bool hover)
    {
        var color = Tint(mode);
        return new StyleBoxFlat { BgColor = new(color, selected ? hover ? .22f : .14f : hover ? .09f : 0),
            BorderColor = new(color, .9f), BorderWidthBottom = selected ? 2 : 0,
            CornerRadiusTopLeft = 7, CornerRadiusTopRight = 7, CornerRadiusBottomLeft = 7, CornerRadiusBottomRight = 7,
            ContentMarginLeft = 7, ContentMarginRight = 7, ContentMarginTop = 5, ContentMarginBottom = 5 };
    }
    private Button Arrow(string direction, Action action)
    {
        var button = new Button { Name = "Ascension" + direction, ExpandIcon = true, CustomMinimumSize = new(30, 38),
            Icon = CenteredIcon("res://images/atlases/ui_atlas.sprites/settings_tiny_" + direction + "_arrow.tres"), IconAlignment = HorizontalAlignment.Center,
            FocusMode = FocusModeEnum.None };
        button.AddThemeConstantOverride("icon_max_width", 16);
        button.AddThemeStyleboxOverride("normal", new StyleBoxEmpty());
        button.AddThemeStyleboxOverride("disabled", new StyleBoxEmpty());
        button.AddThemeStyleboxOverride("hover", CareerVisuals.Box("29475466", "00000000", 5, 4));
        button.AddThemeStyleboxOverride("pressed", CareerVisuals.Box("34596999", "00000000", 5, 4));
        button.Pressed += action; return button;
    }
    private void Adjust(int change)
    {
        _levels[Mode] = Math.Clamp(Level + change, MatchModes.Minimum(Mode, _required), MatchModes.Maximum(Mode));
        Refresh(); Changed?.Invoke(Mode, Level);
    }
    private void Refresh()
    {
        foreach (var (mode, button) in _modes) button.SetPressedNoSignal(mode == Mode);
        _name.Text = MatchModes.Name(Mode); _name.Modulate = Tint(Mode);
        _number.Text = Level.ToString(); _number.Modulate = Tint(Mode);
        _previous.Disabled = !_editable || Mode == MatchModes.Dread || Level <= MatchModes.Minimum(Mode, _required);
        _next.Disabled = !_editable || Mode == MatchModes.Dread || Level >= MatchModes.Maximum(Mode);
        _previous.Modulate = new Color(1, 1, 1, _previous.Disabled ? .25f : .9f);
        _next.Modulate = new Color(1, 1, 1, _next.Disabled ? .25f : .9f);
    }
}
