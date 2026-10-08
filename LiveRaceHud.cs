using Godot;

namespace NationalSpire;

/// <summary>紧凑转播面板；标题区拖动，收起状态保留独立恢复入口。</summary>
public partial class LiveRaceHud : PanelContainer
{
    public event Action<BroadcastUiState>? LayoutChanged;
    private Label _status = null!, _title = null!;
    private VBoxContainer _details = null!, _speechStack = null!;
    private sealed class Speech(PanelContainer panel, string topic, double remaining, string speaker, string text, AvatarArt? art, AvatarIdentity? identity)
    { public PanelContainer Panel = panel; public string Topic = topic; public double Remaining = remaining; public Tween? Fade; public bool Expiring;
      public string Speaker = speaker, Text = text; public AvatarArt? Art = art; public AvatarIdentity? Identity = identity; public float Travel;
      public float Speed = Random.Shared.Next(81, 100) * 1.3f, OffsetY = Random.Shared.Next(-5, 6); public int Lane; }
    private readonly List<Speech> _speeches = [];
    private Button _toggle = null!;
    private Button _mode = null!;
    private Control _floating = null!;
    private bool _collapsed, _dragging, _resizePending;
    private Vector2 _dragStart, _positionStart;
    private BroadcastUiState _layout = new();
    private const float ExpandedWidth = 326;
    public override void _Ready()
    {
        Name = "NationalSpireLive"; MouseFilter = MouseFilterEnum.Ignore; Theme = CareerVisuals.CreateTheme(); ZIndex = 101;
        AddThemeStyleboxOverride("panel", CareerVisuals.Box("10212bdc", "426372", 6, 7));
        SetAnchorsAndOffsetsPreset(LayoutPreset.TopLeft);
        var body = new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore }; body.AddThemeConstantOverride("separation", 3); AddChild(body);
        body.MinimumSizeChanged += () => _resizePending = true;
        var heading = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }; body.AddChild(heading);
        _title = Label("⠿  赛事转播", 14, CareerVisuals.Teal); _title.SizeFlagsHorizontal = SizeFlags.ExpandFill;
        _title.AutowrapMode = TextServer.AutowrapMode.Off; _title.ClipText = true;
        _title.MouseFilter = MouseFilterEnum.Stop; _title.MouseDefaultCursorShape = CursorShape.Move;
        _title.TooltipText = "按住拖动转播位置"; _title.GuiInput += DragInput; heading.AddChild(_title);
        _toggle = new Button { Text = "−", TooltipText = "收起转播", FocusMode = FocusModeEnum.None, CustomMinimumSize = new Vector2(23, 23) };
        _toggle.AddThemeFontSizeOverride("font_size", 14);
        foreach (var state in new[] { "normal", "hover", "pressed", "focus" })
            _toggle.AddThemeStyleboxOverride(state, CareerVisuals.Box(state == "normal" ? "172b3500" : "25404a", "426372", 3, 2));
        _toggle.Pressed += () => { _layout.Collapsed = !_collapsed; SetCollapsed(_layout.Collapsed); RestorePosition(); LayoutChanged?.Invoke(_layout); }; heading.AddChild(_toggle);
        _mode = new Button { Name = "BroadcastMode", Text = "弹幕", TooltipText = "切换为上方弹幕", FocusMode = FocusModeEnum.None, CustomMinimumSize = new(52, 23) };
        _mode.AddThemeFontSizeOverride("font_size", 13); heading.AddChild(_mode);
        _mode.Pressed += () => { SetMode(!_layout.Floating); LayoutChanged?.Invoke(_layout); };
        _floating = new Control { Name = "NationalSpireFloatingComments", MouseFilter = MouseFilterEnum.Ignore, ClipContents = true, ZIndex = 100, Theme = Theme };
        GetParent().AddChild(_floating); _floating.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        // 隐藏时仍保留正文排版宽度，展开后的最小高度始终按正常宽度计算。
        _details = new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore, CustomMinimumSize = new Vector2(ExpandedWidth - 14, 0) }; body.AddChild(_details);
        _status = Label("正在连接赛场", 13, CareerVisuals.Ink); _details.AddChild(_status);
        _status.CustomMinimumSize = new Vector2(ExpandedWidth - 14, 0);
        _status.MouseFilter = MouseFilterEnum.Stop; _status.MouseDefaultCursorShape = CursorShape.Move;
        _status.TooltipText = "按住拖动转播位置";
        _status.GuiInput += input => DragInput(input, _status);
        _speechStack = new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore, Visible = false }; _details.AddChild(_speechStack);
        ((Control)GetParent()).Resized += RestorePosition;
        Restore(new());
    }
    private static Label Label(string text, int size, Color color)
    {
        var label = new Label { Text = text, AutowrapMode = TextServer.AutowrapMode.WordSmart, MouseFilter = MouseFilterEnum.Ignore, SizeFlagsHorizontal = SizeFlags.ExpandFill };
        label.AddThemeFontSizeOverride("font_size", size); label.AddThemeColorOverride("font_color", color); return label;
    }
    public void Restore(BroadcastUiState layout)
    {
        _layout = layout; SetMode(layout.Floating); SetCollapsed(layout.Collapsed); RestorePosition();
        Callable.From(RestorePosition).CallDeferred();
    }
    private Vector2 Area => ((Control)GetParent()).Size;
    private void RestorePosition()
    {
        FitHeight();
        var room = (Area - Size).Max(Vector2.Zero);
        Position = _layout.X < 0 ? new Vector2(Math.Max(0, Area.X - Size.X - 18), 90)
            : _layout.PositionVersion >= 2 ? new Vector2(Area.X * _layout.X, Area.Y * _layout.Y) : new Vector2(room.X * _layout.X, room.Y * _layout.Y);
        ClampPosition();
    }
    private void ClampPosition() => Position = Position.Clamp(Vector2.Zero, (Area - Size).Max(Vector2.Zero));
    private void SetCollapsed(bool value)
    {
        _collapsed = value; _details.Visible = !value; _mode.Visible = !value; _title.Text = value ? "转播" : "⠿ " + _raceName;
        _floating.Visible = _layout.Floating && !value;
        _toggle.Text = value ? "+" : "−"; _toggle.TooltipText = value ? "展开转播" : "收起转播";
        FitHeight(); ClampPosition();
        Callable.From(() => { FitHeight(); ClampPosition(); }).CallDeferred();
    }
    private string _raceName = "赛事转播";
    public void AddAction(string title, Action action)
    {
        var button = new Button { Text = title, FocusMode = FocusModeEnum.None };
        button.AddThemeFontSizeOverride("font_size", 13); button.Pressed += action; _details.AddChild(button);
    }
    public void SetRace(string name, string status, int hp, int maxHp, bool otherAct, double seconds)
    {
        _raceName = name; if (!_collapsed) _title.Text = "⠿ " + name;
        _status.Text = status + $" · 生命 {hp}/{maxHp}" + (otherAct ? " · 不同幕" : "");
    }
    private PanelContainer SpeechPanel(string speaker, string text, string topic, AvatarArt? art, AvatarIdentity? identity, bool floating)
    {
        var panel = new PanelContainer { MouseFilter = MouseFilterEnum.Ignore };
        bool audience = topic.StartsWith("audience_") || topic.StartsWith("reply_");
        bool thought = topic.StartsWith("thought_");
        panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box(audience ? "18383df5" : thought ? "273149f5" : topic == "rival_dead" || topic == "player_danger" ? "493139f5" : "382d48f5", audience ? "5b9e99" : thought ? "8592b8" : "b99467", 5, 9));
        BoxContainer words = floating ? new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore } : new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore }; panel.AddChild(words);
        words.AddThemeConstantOverride("separation", floating ? 12 : 4);
        var byline = Label(speaker, 13, thought ? new Color("c4b1f0") : audience ? new Color("9ddbd0") : CareerVisuals.Gold);
        var content = Label(floating ? text.Replace("\r", "").Replace("\n", " ") : text, 16, thought ? new Color("ded3f4") : CareerVisuals.Ink);
        if (floating) { byline.AutowrapMode = content.AutowrapMode = TextServer.AutowrapMode.Off; byline.SizeFlagsHorizontal = content.SizeFlagsHorizontal = SizeFlags.ShrinkBegin; }
        byline.CustomMinimumSize = content.CustomMinimumSize = new Vector2(ExpandedWidth - 32, 0);
        if (floating) byline.CustomMinimumSize = content.CustomMinimumSize = Vector2.Zero;
        if (art != null)
        {
            byline.CustomMinimumSize = floating ? Vector2.Zero : new Vector2(ExpandedWidth - 74, 0);
            var heading = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore };
            heading.AddThemeConstantOverride("separation", 6);
            heading.AddChild(new CareerAvatar { Art = art, Identity = identity, CustomMinimumSize = new Vector2(30, 30), SizeFlagsVertical = SizeFlags.ShrinkCenter });
            heading.AddChild(byline); words.AddChild(heading);
        }
        else words.AddChild(byline);
        words.AddChild(content); return panel;
    }
    public void Say(string speaker, string text, string topic = "", AvatarArt? art = null, AvatarIdentity? identity = null)
    {
        if (topic is "player_champion" or "player_finished")
            foreach (var old in _speeches.ToList()) RemoveSpeech(old);
        if (topic is "rival_dead" or "rival_clear")
            foreach (var old in _speeches.Where(s => s.Topic.StartsWith("rival_") || s.Topic.StartsWith("gap_") || s.Topic.StartsWith("thought_")).ToList()) RemoveSpeech(old);
        while (_speeches.Count >= 3)
            RemoveSpeech(_speeches.FirstOrDefault(s => s.Topic is not ("rival_dead" or "rival_clear" or "player_champion" or "player_finished")) ?? _speeches[0]);
        var panel = SpeechPanel(speaker, text, topic, art, identity, _layout.Floating);
        (_layout.Floating ? _floating : _speechStack).AddChild(panel);
        _speechStack.Visible = !_layout.Floating;
        var item = new Speech(panel, topic, Math.Clamp(text.Length * .19 + 5, 14, 21), speaker, text, art, identity);
        var lanes = Enumerable.Range(0, 3).Where(i => !_speeches.Any(s => s.Lane == i)).ToArray();
        item.Lane = lanes[Random.Shared.Next(lanes.Length)]; _speeches.Add(item);
        if (_layout.Floating) PlaceFloating(item);
        panel.Modulate = new Color(1, 1, 1, .2f); item.Fade = CreateTween(); item.Fade.TweenProperty(panel, "modulate:a", 1f, .18);
        _resizePending = true;
    }
    private void SetMode(bool floating)
    {
        bool changed = _layout.Floating != floating || _speeches.Any(s => (s.Panel.GetParent() == _floating) != floating);
        _layout.Floating = floating; _mode.Text = floating ? "列表" : "弹幕"; _mode.TooltipText = floating ? "切换为列表显示" : "切换为上方弹幕";
        _floating.Visible = floating && !_collapsed; _speechStack.Visible = !floating && _speeches.Count > 0;
        if (!changed) return;
        foreach (var item in _speeches)
        {
            item.Fade?.Kill(); item.Expiring = false;
            item.Panel.GetParent().RemoveChild(item.Panel); item.Panel.QueueFree();
            item.Panel = SpeechPanel(item.Speaker, item.Text, item.Topic, item.Art, item.Identity, floating);
            (floating ? _floating : _speechStack).AddChild(item.Panel);
            if (floating) { item.Travel = 0; PlaceFloating(item); }
        }
        _resizePending = true;
    }
    private void PlaceFloating(Speech item)
    {
        item.Panel.Size = item.Panel.GetCombinedMinimumSize();
        float top = 32 + item.OffsetY;
        for (int lane = 0; lane <= item.Lane; lane++)
        {
            // 弹幕轨道避开可拖动的选手信息，避免正文经过面板时受到遮挡。
            if (!_collapsed && top < Position.Y + Size.Y && top + item.Panel.Size.Y > Position.Y)
                top = Position.Y + Size.Y + 12 + Math.Abs(item.OffsetY);
            if (lane < item.Lane) top += 58;
        }
        item.Panel.Position = new Vector2(Area.X - item.Travel, top);
    }
    private void RemoveSpeech(Speech item)
    {
        item.Fade?.Kill(); _speeches.Remove(item); item.Panel.GetParent().RemoveChild(item.Panel); item.Panel.QueueFree();
        _speechStack.Visible = !_layout.Floating && _speeches.Count > 0; _resizePending = true;
    }
    public override void _Process(double delta)
    {
        if (_resizePending && !_dragging) { _resizePending = false; RestorePosition(); }
        foreach (var item in _speeches.ToList())
        {
            if (_layout.Floating)
            {
                item.Travel += (float)delta * item.Speed; PlaceFloating(item);
                if (item.Panel.Position.X + item.Panel.Size.X < 0) RemoveSpeech(item);
                continue;
            }
            item.Remaining -= delta;
            if (item.Remaining > 0 || item.Expiring) continue;
            item.Expiring = true; item.Fade?.Kill(); item.Fade = CreateTween(); item.Fade.TweenProperty(item.Panel, "modulate:a", 0f, .25);
            item.Fade.TweenCallback(Callable.From(() => RemoveSpeech(item)));
        }
    }
    private void DragInput(InputEvent input) => DragInput(input, _title);
    private void DragInput(InputEvent input, Control surface)
    {
        if (input is InputEventMouseButton { ButtonIndex: MouseButton.Left, Pressed: true } mouse)
        { BeginDrag(surface.GetGlobalTransformWithCanvas() * mouse.Position); surface.AcceptEvent(); }
    }
    private Vector2 ParentPoint(Vector2 viewportPoint) => ((Control)GetParent()).GetGlobalTransformWithCanvas().AffineInverse() * viewportPoint;
    private void BeginDrag(Vector2 point) { _dragging = true; _dragStart = ParentPoint(point); _positionStart = Position; }
    private static bool Hit(Control surface, Vector2 point) => surface.IsVisibleInTree()
        && new Rect2(Vector2.Zero, surface.Size).HasPoint(surface.GetGlobalTransformWithCanvas().AffineInverse() * point);
    public override void _Input(InputEvent input)
    {
        if (!IsVisibleInTree()) { _dragging = false; return; }
        if (input is InputEventMouseButton { ButtonIndex: MouseButton.Left, Pressed: true } press
            && !Hit(_toggle, press.Position) && !Hit(_mode, press.Position) && (Hit(_title, press.Position) || Hit(_status, press.Position)))
            BeginDrag(press.Position);
        if (!_dragging) return;
        if (input is InputEventMouseMotion motion) { Position = _positionStart + ParentPoint(motion.Position) - _dragStart; ClampPosition(); }
        if (input is InputEventMouseButton { ButtonIndex: MouseButton.Left, Pressed: false }) { _dragging = false; PublishLayout(); }
        GetViewport().SetInputAsHandled();
    }
    private void PublishLayout()
    {
        var area = Area.Max(Vector2.One);
        _layout = new BroadcastUiState { Floating = _layout.Floating, PositionVersion = 2, Collapsed = _collapsed, X = Math.Clamp(Position.X / area.X, 0, 1), Y = Math.Clamp(Position.Y / area.Y, 0, 1) };
        LayoutChanged?.Invoke(_layout);
    }
    private void FitHeight() => Size = new Vector2(_collapsed ? 90 : ExpandedWidth, GetCombinedMinimumSize().Y);
    public override void _ExitTree() { foreach (var item in _speeches) item.Fade?.Kill(); if (GetParent() is Control parent) parent.Resized -= RestorePosition; if (GodotObject.IsInstanceValid(_floating)) _floating.QueueFree(); }
}

/// <summary>仅绘制已走路线，地图缩放和拖动由原生父控件处理。</summary>
public partial class RivalMapOverlay : Control
{
    public Vector2 BadgeOffset { get; set; } = new(25, -48);
    public AvatarIdentity? Identity { get; set; }
    public AvatarArt Art { get; set; } = new(null, CareerVisuals.Teal, "");
    private Vector2[] _path = [];
    private Vector2? _marker;
    private PanelContainer _badge = null!;
    private Label _label = null!;
    private CareerAvatar _avatar = null!;
    private Tween? _move;
    private string _signature = "";
    public override void _Ready()
    {
        MouseFilter = MouseFilterEnum.Ignore; ZIndex = 10; Theme = CareerVisuals.CreateTheme();
        _badge = new PanelContainer { MouseFilter = MouseFilterEnum.Ignore, CustomMinimumSize = new Vector2(125, 72) };
        _badge.AddThemeStyleboxOverride("panel", CareerVisuals.Box("10232deb", "70baba", 8, 6)); AddChild(_badge);
        var row = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }; _badge.AddChild(row);
        _avatar = new CareerAvatar { Art = Art, Identity = Identity, CustomMinimumSize = new Vector2(42, 42), SizeFlagsVertical = SizeFlags.ShrinkCenter }; row.AddChild(_avatar);
        _label = new Label { MouseFilter = MouseFilterEnum.Ignore }; _label.AddThemeFontSizeOverride("font_size", 14); row.AddChild(_label);
    }
    public void RefreshArt(AvatarArt art) { Art = art; _avatar.Art = art; }
    public void UpdateState(List<Vector2> path, Vector2? marker, string name, int hp, int max, bool dead)
    {
        string signature = string.Join(';', path) + ":" + marker + ":" + hp + ":" + dead;
        if (_signature == signature) return;
        _signature = signature; _path = path.ToArray();
        _label.Text = name + $"\n{hp}/{max}" + (dead ? " · 已出局" : "");
        if (marker is { } at)
        {
            var destination = at + BadgeOffset;
            _badge.Show();
            if (_marker != marker)
            {
                _move?.Kill();
                if (_marker == null) _badge.Position = destination;
                else { _move = CreateTween().SetTrans(Tween.TransitionType.Cubic).SetEase(Tween.EaseType.Out); _move.TweenProperty(_badge, "position", destination, .45); }
            }
        }
        else _badge.Hide();
        _marker = marker; QueueRedraw();
    }
    public override void _Draw()
    {
        if (_path.Length > 1) DrawPolyline(_path, new Color("70baba88"), 3, true);
        foreach (var point in _path) DrawArc(point, 20, 0, Mathf.Tau, 24, new Color("70baba99"), 2, true);
    }
    public override void _ExitTree() => _move?.Kill();
}
