using Godot;

namespace NationalSpire;

/// <summary>交互时才创建补间；静止时复用绘制结果，不改变容器尺寸和点击区域。</summary>
public partial class BroadcastButton : Button
{
    private Tween? _hoverTween, _pressTween;
    private float _highlight, _press;
    private bool _hovered;
    public bool Primary { get; set; }
    public override void _Ready()
    {
        MouseEntered += () => { _hovered = true; Highlight(); };
        MouseExited += () => { _hovered = false; Highlight(); };
        FocusEntered += Highlight; FocusExited += Highlight;
        ButtonDown += () =>
        {
            if (Disabled) return;
            _pressTween?.Kill(); _press = 1; QueueRedraw();
            _pressTween = CreateTween();
            _pressTween.TweenMethod(Callable.From<float>(v => { _press = v; QueueRedraw(); }), 1f, 0f, .24);
        };
        Resized += QueueRedraw;
    }
    private void Highlight()
    {
        _hoverTween?.Kill();
        float target = !Disabled && (_hovered || HasFocus()) ? 1 : 0;
        _hoverTween = CreateTween().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Cubic);
        _hoverTween.TweenMethod(Callable.From<float>(v => { _highlight = v; QueueRedraw(); }), _highlight, target, .16);
    }
    public override void _Draw()
    {
        if (Disabled) return;
        var accent = CareerVisuals.Teal;
        if (_highlight > .001f)
        {
            DrawRect(new Rect2(4, 4, Size.X - 8, Size.Y - 8), new Color(accent, _highlight * .045f));
            DrawLine(new Vector2(14, Size.Y - 5), new Vector2(14 + Math.Max(0, Size.X - 28) * _highlight, Size.Y - 5), new Color(accent, _highlight), 2, true);
        }
        if (_press > .001f) DrawRect(new Rect2(Vector2.Zero, Size), new Color(accent, _press * .15f));
    }
    public override void _ExitTree() { _hoverTween?.Kill(); _pressTween?.Kill(); }
}

public partial class BroadcastBackdrop : Control
{
    public override void _Ready() { MouseFilter = MouseFilterEnum.Ignore; Resized += QueueRedraw; }
    public override void _Draw()
    {
        float w = Size.X, h = Size.Y;
        DrawRect(new Rect2(Vector2.Zero, Size), new Color("090e18"));
        DrawColoredPolygon([new(w * .42f, 0), new(w, 0), new(w, h * .65f), new(w * .12f, h)], new Color("0e1b29"));
        DrawColoredPolygon([new(w * .72f, 0), new(w * .88f, 0), new(w * .47f, h), new(w * .31f, h)], new Color("112531"));
        for (int i = 0; i < 10; i++)
            DrawLine(new Vector2(w * .55f + i * 46, 0), new Vector2(w * .15f + i * 46, h), new Color("69dcd008"), 1);
        DrawLine(new Vector2(w * .88f, 0), new Vector2(w * .47f, h), new Color("86bca521"), 1, true);
        DrawRect(new Rect2(0, 0, w * .28f, 3), CareerVisuals.Lime);
        DrawRect(new Rect2(w * .28f + 6, 0, w * .11f, 3), CareerVisuals.Teal);
    }
}

public partial class BroadcastScroll : ScrollContainer
{
    private Tween? _wheelTween;
    private int _target, _direction;
    public void StopMotion() { _wheelTween?.Kill(); _wheelTween = null; _direction = 0; }
    public override void _Ready()
    {
        GetVScrollBar().GuiInput += input => { if (input is InputEventMouseButton { Pressed: true, ButtonIndex: MouseButton.Left }) StopMotion(); };
    }
    public override void _Input(InputEvent input)
    {
        if (!IsVisibleInTree() || input is not InputEventMouseButton wheel || wheel.ButtonIndex is not (MouseButton.WheelUp or MouseButton.WheelDown)) return;
        if (!GetGlobalRect().HasPoint(wheel.Position)) return;
        // 在原生 GUI 分发前消费滚轮，同一次输入只有一个滚动来源。编辑器、数值框和嵌套滚动区保留自己的输入。
        var hovered = GetViewport().GuiGetHoveredControl();
        Node? current = hovered;
        while (current != null && current != this)
        {
            if (current is SpinBox or TextEdit or ScrollContainer or Popup) return;
            current = current.GetParent();
        }
        if (hovered != null && current != this) return;
        GetViewport().SetInputAsHandled();
        if (wheel.Pressed) ScrollWheel(wheel.ButtonIndex == MouseButton.WheelDown ? 1 : -1, wheel.Factor);
    }
    internal void ScrollWheel(int direction, double factor)
    {
        var bar = GetVScrollBar();
        int maximum = Math.Max(0, (int)(bar.MaxValue - bar.Page));
        if (maximum == 0) { StopMotion(); return; }
        bool continuing = _wheelTween?.IsRunning() == true && direction == _direction;
        int origin = continuing ? _target : ScrollVertical;
        int target = Math.Clamp(origin + (int)(86 * Math.Clamp(factor, .1, 4) * direction), 0, maximum);
        // 快速滚轮最多领先当前画面三格，触底后保留既有补间，避免反复重启。
        target = Math.Clamp(target, Math.Max(0, ScrollVertical - 258), Math.Min(maximum, ScrollVertical + 258));
        if (continuing && target == _target) return;
        StopMotion();
        if (target == ScrollVertical) return;
        _target = target; _direction = direction;
        _wheelTween = CreateTween().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Cubic);
        _wheelTween.TweenMethod(Callable.From<float>(v => ScrollVertical = Math.Clamp((int)v, 0, Math.Max(0, (int)(bar.MaxValue - bar.Page)))), (float)ScrollVertical, (float)target, .13);
    }
    public override void _GuiInput(InputEvent input)
    {
        if (input is InputEventPanGesture or InputEventScreenDrag || input is InputEventMouseButton { Pressed: true, ButtonIndex: MouseButton.Left }) StopMotion();
    }
    public override void _ExitTree() => StopMotion();
}

/// <summary>独立的短时转场装饰，保持滚动内容的位置和点击区域稳定。</summary>
public partial class BroadcastTransition : Control
{
    private float _progress;
    public float Progress { get => _progress; set { _progress = value; QueueRedraw(); } }
    public override void _Draw()
    {
        float x = (Size.X + 180) * _progress - 160;
        float alpha = MathF.Sin(MathF.PI * _progress) * .055f;
        DrawColoredPolygon([new(x, 0), new(x + 90, 0), new(x - 30, Size.Y), new(x - 120, Size.Y)], new Color(CareerVisuals.Teal, alpha));
        DrawLine(new Vector2(0, 1), new Vector2(Math.Min(Size.X, 180) * _progress, 1), new Color(CareerVisuals.Teal, alpha * 5), 2);
    }
}

public partial class BroadcastPanel : PanelContainer
{
    public Color Accent { get; set; } = new("527783");
    public override void _Ready() { Resized += QueueRedraw; }
    public override void _Draw()
    {
        DrawLine(new Vector2(18, 1), new Vector2(Math.Min(Size.X - 18, 76), 1), Accent, 2, true);
        DrawLine(new Vector2(Size.X - 34, 12), new Vector2(Size.X - 20, 12), new Color(Accent, .45f), 1, true);
    }
}

/// <summary>角色原画与静态竞技几何图案共用缓存纹理，尺寸变化时重新绘制。</summary>
public partial class BroadcastPortrait : Control
{
    public AvatarArt Art { get; set; } = new(null, CareerVisuals.Teal, "");
    public override void _Ready() { MouseFilter = MouseFilterEnum.Ignore; Resized += QueueRedraw; }
    public override void _Draw()
    {
        float w = Size.X, h = Size.Y;
        DrawRect(new Rect2(Vector2.Zero, Size), new Color("101d30"));
        DrawColoredPolygon([new(w * .35f, 0), new(w, 0), new(w, h), new(0, h)], new Color(Art.Accent, .19f));
        for (int i = 0; i < 6; i++)
            DrawLine(new Vector2(w * .5f + i * 20, 0), new Vector2(i * 20, h), new Color(Art.Accent, .13f), 2, true);
        DrawArc(new Vector2(w * .55f, h * .46f), Math.Min(w, h) * .42f, -.5f, 4.6f, 48, new Color(Art.Accent, .5f), 2, true);
        if (Art.Texture is { } texture && GodotObject.IsInstanceValid(texture))
        {
            var source = texture.GetSize();
            float scale = Math.Min((w - 24) / source.X, (h - 18) / source.Y);
            var size = source * scale;
            DrawTextureRect(texture, new Rect2((Size - size) / 2, size), false);
        }
        DrawColoredPolygon([new(w - 48, h), new(w, h - 48), new(w, h)], CareerVisuals.Lime);
        DrawLine(new Vector2(12, h - 13), new Vector2(w * .48f, h - 13), CareerVisuals.Lime, 3, true);
    }
}

public partial class CareerScreen
{
    private Tween? _pageTween;
    private string _visualLocation = "";
    private BroadcastTransition? _pageEffect;
    private void AnimatePage()
    {
        string location = $"{_tab}:{_personId}:{_postId}:{_worldSection}:{_competitionId}:{_profileFilter}:{_communityFilter}";
        _pageTween?.Kill(); _content.Modulate = Colors.White;
        if (_pageEffect != null) _pageEffect.Hide();
        if (_visualLocation == location) return;
        _visualLocation = location;
        int version = _renderVersion;
        Callable.From(() =>
        {
            if (!IsInsideTree() || IsQueuedForDeletion() || version != _renderVersion) return;
            if (_pageEffect == null)
            {
                _pageEffect = new BroadcastTransition { MouseFilter = MouseFilterEnum.Ignore, ClipContents = true };
                _stage.AddChild(_pageEffect);
            }
            _pageEffect.Position = _stage.GetGlobalTransform().AffineInverse() * _scroll.GlobalPosition;
            _pageEffect.Size = _scroll.Size; _pageEffect.Progress = 0; _pageEffect.Show();
            _content.Modulate = new Color(1, 1, 1, .55f);
            _pageTween = CreateTween().SetParallel().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Cubic);
            _pageTween.TweenProperty(_content, "modulate:a", 1f, .20);
            _pageTween.TweenMethod(Callable.From<float>(v => _pageEffect.Progress = v), 0f, 1f, .28);
            _pageTween.Chain().TweenCallback(Callable.From(() => _pageEffect.Hide()));
        }).CallDeferred();
    }
    private static Button FilterButton(string title, bool selected, Action action, float width)
    {
        var button = Button(title, action, width);
        button.ToggleMode = true; button.SetPressedNoSignal(selected);
        button.AddThemeStyleboxOverride("pressed", CareerVisuals.Box("28434c", "699396", 6, 14));
        button.AddThemeColorOverride("font_pressed_color", CareerVisuals.Ink);
        button.TooltipText = selected ? "当前筛选：" + title : "切换到：" + title;
        return button;
    }
    private static void Emphasize(Button button)
    {
        if (button is BroadcastButton broadcast) broadcast.Primary = true;
        button.AddThemeStyleboxOverride("normal", CareerVisuals.Box("31545b", "668c91", 5, 16));
        button.AddThemeStyleboxOverride("hover", CareerVisuals.Box("3b6269", "83a4a5", 5, 16));
        button.AddThemeStyleboxOverride("pressed", CareerVisuals.Box("24434b", "668c91", 5, 16));
        foreach (string state in new[] { "font_color", "font_hover_color", "font_pressed_color" }) button.AddThemeColorOverride(state, CareerVisuals.Ink);
    }
    private Control PlayerBanner(CareerData data, string id)
    {
        var person = CareerEngine.Person(data, id);
        var profile = id == "player" ? data.PlayerCard : person;
        var panel = new BroadcastPanel { Accent = CareerVisuals.Lime, SizeFlagsHorizontal = SizeFlags.ExpandFill };
        panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("172a3a", "426474", 8, 24));
        var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 26); panel.AddChild(row);
        row.AddChild(Avatar(data, id, 104, false));
        var words = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; words.AddThemeConstantOverride("separation", 10); row.AddChild(words);
        words.AddChild(Text((profile?.Role ?? EsportsWorld.LicenseName(data)) + (person != null && ClubCoaching.IsCoach(person) ? " · 俱乐部教练" : ""), 14, CareerVisuals.Teal));
        words.AddChild(Text(CareerEngine.DisplayName(data, id), 32, _ink));
        if (id != "player" && profile is { Handle.Length: > 0, Name.Length: > 0 }) words.AddChild(Text("姓名  " + profile.Name, 15, _muted));
        words.AddChild(Text((person?.Country ?? data.Esports.Country) + "   /   " + EsportsWorld.ClubName(data, person?.ClubId ?? data.Esports.ClubId), 17, _gold));
        var identity = AvatarHonors.ForPerson(data, id);
        if (identity.Frame.Grade > 0 || identity.Role.Length > 0)
            words.AddChild(Text(identity.Description, 14, new Color(identity.Frame.Color)));
        var rating = new VBoxContainer { CustomMinimumSize = new Vector2(175, 0) }; rating.AddThemeConstantOverride("separation", 10); row.AddChild(rating);
        rating.AddChild(Text("生涯评分", 14, _muted));
        rating.AddChild(Text((person?.Rating ?? data.Rating).ToString(), 38, CareerVisuals.Lime));
        int highest = id == "player" || data.HumanIds.Contains(id) ? identity.Ascension : person?.MaxAscension ?? -1;
        rating.AddChild(Text("生涯最高通关", 14, _muted));
        var best = Text(highest < 0 ? "暂无通关" : $"进阶 {highest}", 20, _gold); best.Name = "ProfileHighestClear"; rating.AddChild(best);
        return panel;
    }

    private Control Matchup(CareerData data, CareerMatch match)
    {
        var row = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };
        void Side(bool ours)
        {
            var panel = Card(); row.AddChild(panel); var column = Inner(panel);
            var ids = _multiplayer == null ? new[] { ours ? "player" : match.OpponentId } :
                ours ? _multiplayer.Team.Select(m => m.Id).ToArray() : _multiplayer.Opponents(match).ToArray();
            column.AddChild(Text(ours ? "PLAYER    /    我方阵容" : "OPPONENT    /    对方阵容", 12, CareerVisuals.Teal));
            if (_multiplayer != null) column.AddChild(Text($"{ids.Length} 人共同出战 · 按整队结果判定", 15, _muted));
            foreach (string id in ids)
            {
                column.AddChild(PersonLink(data, id, CareerEngine.DisplayName(data, id) + "   ↗", 54));
                var person = CareerEngine.Person(data, id);
                string character = id == "player" ? data.SelectedCharacter : person?.Character ?? "";
                character = GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == character)?.Title.GetFormattedText() ?? character;
                column.AddChild(Text((person?.Country ?? data.Esports.Country) + "   ·   " + character, 15, _muted));
            }
        }
        Side(true);
        var center = Text("VS", 36, CareerVisuals.Lime); center.SizeFlagsHorizontal = SizeFlags.ShrinkCenter;
        center.VerticalAlignment = VerticalAlignment.Center; center.CustomMinimumSize = new Vector2(72, 0); center.HorizontalAlignment = HorizontalAlignment.Center; row.AddChild(center);
        Side(false); return row;
    }
}
