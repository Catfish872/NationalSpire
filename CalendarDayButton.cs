using Godot;

namespace NationalSpire;

/// <summary>日历日期的选中底色与悬停线条独立；日期、赛事、关系共用一行。</summary>
public partial class CalendarDayButton : Button
{
    public string Number { get; init; } = "";
    public string Description { get; init; } = "";
    public bool Today { get; init; }
    public bool Selected { get; set; }
    public bool HasMatch { get; init; }
    public bool Registered { get; init; }
    public string? Bond { get; init; }
    public bool Wedding { get; init; }
    public bool Question { get; init; }
    private HBoxContainer _heading = null!;
    private Label _description = null!;
    private Tween? _hoverTween, _pressTween;
    private FontVariation? _bold;
    private float _hover, _press;
    public void SelectDate(bool selected)
    {
        Selected = selected;
        foreach (string state in new[] { "normal", "hover", "pressed", "hover_pressed" })
            AddThemeStyleboxOverride(state, CareerVisuals.Box(Selected || state != "normal" ? "28495a" : "1d3040", "395365", 8, 0));
        QueueRedraw();
    }
    public override void _Ready()
    {
        CustomMinimumSize = new(0, 88); SizeFlagsHorizontal = SizeFlags.ExpandFill;
        SelectDate(Selected);
        AddThemeStyleboxOverride("focus", new StyleBoxEmpty());
        _heading = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore, Alignment = BoxContainer.AlignmentMode.Center };
        _heading.AddThemeConstantOverride("separation", 8); AddChild(_heading);
        if (Question)
        {
            _heading.AddChild(new EventEmblem { CustomMinimumSize = new(24, 24), SizeFlagsVertical = SizeFlags.ShrinkCenter });
        }
        var number = new Label { Name = "CalendarNumber", Text = Number, MouseFilter = MouseFilterEnum.Ignore };
        number.AddThemeFontSizeOverride("font_size", 18); _heading.AddChild(number);
        if (Today) { _bold = new FontVariation { BaseFont = number.GetThemeFont("font"), VariationEmbolden = 1 }; number.AddThemeFontOverride("font", _bold); }
        if (HasMatch)
        {
            var swords = new TextureRect { Name = "CalendarMatchIcon", Texture = AffectionArt.Texture(Registered ? "calendar-crossed-swords" : "calendar-sword"),
                CustomMinimumSize = new(22, 22), SizeFlagsVertical = SizeFlags.ShrinkCenter, ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize,
                StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore };
            _heading.AddChild(swords);
        }
        if (Bond != null)
        {
            var host = new Control { Name = "CalendarRelationship", CustomMinimumSize = new(22, 22), SizeFlagsVertical = SizeFlags.ShrinkCenter, MouseFilter = MouseFilterEnum.Ignore };
            _heading.AddChild(host);
            var date = new TextureRect { Texture = AffectionArt.Texture("calendar-date"), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize,
                StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore };
            host.AddChild(date); date.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        }
        if (Wedding) _heading.AddChild(new GiftRingMark { Name = "CalendarWedding", CustomMinimumSize = new(22, 22), SizeFlagsVertical = SizeFlags.ShrinkCenter });
        if (!HasMatch && Bond == null && !Wedding && !Question)
        {
            var dot = new Label { Text = "·", MouseFilter = MouseFilterEnum.Ignore }; dot.AddThemeFontSizeOverride("font_size", 18); _heading.AddChild(dot);
        }
        _description = new Label { Name = "CalendarDescription", Text = Description, HorizontalAlignment = HorizontalAlignment.Center,
            AutowrapMode = TextServer.AutowrapMode.WordSmart, TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis,
            MaxLinesVisible = 2, MouseFilter = MouseFilterEnum.Ignore };
        _description.AddThemeFontSizeOverride("font_size", 16); AddChild(_description);
        MouseEntered += () => Hover(1); MouseExited += () => Hover(0);
        ButtonDown += () => { _pressTween?.Kill(); _press = 1; QueueRedraw(); _pressTween = CreateTween(); _pressTween.TweenMethod(Callable.From<float>(v => { _press = v; QueueRedraw(); }), 1f, 0f, .24); };
        Resized += Layout; Layout();
    }
    private void Layout()
    {
        if (_heading == null) return;
        _heading.Position = new(8, 17); _heading.Size = new(Math.Max(0, Size.X - 16), 26);
        _description.Position = new(8, 47); _description.Size = new(Math.Max(0, Size.X - 16), 36); QueueRedraw();
    }
    private void Hover(float value)
    {
        _hoverTween?.Kill(); _hoverTween = CreateTween().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Cubic);
        _hoverTween.TweenMethod(Callable.From<float>(v => { _hover = v; QueueRedraw(); }), _hover, value, .16);
    }
    private void Sweep(Vector2[] points, float fraction)
    {
        float length = 0; for (int i = 1; i < points.Length; i++) length += points[i - 1].DistanceTo(points[i]);
        float remaining = length * fraction; var path = new List<Vector2> { points[0] };
        for (int i = 1; i < points.Length && remaining > 0; i++)
        {
            float segment = points[i - 1].DistanceTo(points[i]); path.Add(points[i - 1].Lerp(points[i], Math.Min(1, remaining / segment))); remaining -= segment;
        }
        if (path.Count > 1) DrawPolyline(path.ToArray(), CareerVisuals.Teal, 2, true);
    }
    public override void _Draw()
    {
        if (Selected || _hover > .001f) DrawRect(new Rect2(4, 4, Size.X - 8, Size.Y - 8), new Color(CareerVisuals.Teal, .045f * (Selected ? 1 : _hover)));
        if (Today)
        {
            DrawLine(new(5, 10), new(5, Size.Y - 10), CareerVisuals.Teal, 2, true);
            DrawLine(new(Size.X - 5, 10), new(Size.X - 5, Size.Y - 10), CareerVisuals.Teal, 2, true);
            if (_hover > .001f)
            {
                var top = new List<Vector2>(); var bottom = new List<Vector2>();
                for (int i = 0; i <= 8; i++) { float angle = Mathf.Pi + i * Mathf.Pi / 16; top.Add(new Vector2(10, 10) + Vector2.FromAngle(angle) * 5); bottom.Add(new Vector2(10, Size.Y - 10) + Vector2.FromAngle(Mathf.Pi - i * Mathf.Pi / 16) * 5); }
                for (int i = 0; i <= 8; i++) { float angle = -Mathf.Pi / 2 + i * Mathf.Pi / 16; top.Add(new Vector2(Size.X - 10, 10) + Vector2.FromAngle(angle) * 5); bottom.Add(new Vector2(Size.X - 10, Size.Y - 10) + Vector2.FromAngle(Mathf.Pi / 2 - i * Mathf.Pi / 16) * 5); }
                top.Reverse(); Sweep(top.ToArray(), _hover); Sweep(bottom.ToArray(), _hover);
            }
        }
        else if (_hover > .001f) DrawLine(new(14, Size.Y - 5), new(14 + Math.Max(0, Size.X - 28) * _hover, Size.Y - 5), new Color(CareerVisuals.Teal, _hover), 2, true);
        if (_press > .001f) DrawRect(new Rect2(Vector2.Zero, Size), new Color(CareerVisuals.Teal, _press * .15f));
    }
    public override void _ExitTree() { _hoverTween?.Kill(); _pressTween?.Kill(); _bold?.Dispose(); }
}
