using Godot;

namespace NationalSpire;

/// <summary>日历日期的选中底色与悬停线条独立；日期、赛事、关系共用一行。</summary>
public partial class CalendarDayButton : Button
{
    private const int CopyBottom=13;
    public string Number { get; init; } = "";
    public string Description { get; init; } = "";
    public List<(string Icon,string Title)> Markers { get; init; } = [];
    public bool CalendarLayout { get; init; }
    public int CalendarHeight { get; init; } = 98;
    public bool PlanWindow { get; init; }
    public int Day { get; init; }
    public bool Preview { get; set; }
    internal void SetPlanPreview(bool value)
    {
        if (Preview==value) return;
        Preview=value; SelectDate(Selected);
    }
    public string SecondLine { get; init; } = "";
    public bool Today { get; init; }
    public bool Selected { get; set; }
    public bool HasMatch { get; init; }
    public bool Registered { get; init; }
    public string? Bond { get; init; }
    public bool Wedding { get; init; }
    public bool Question { get; init; }
    private HBoxContainer _heading = null!;
    private Label _description = null!;
    private Label? _secondary;
    private VBoxContainer? _copy;
    private HFlowContainer? _markers;
    private Tween? _hoverTween, _pressTween;
    private float _hover, _press;
    public void SelectDate(bool selected)
    {
        Selected = selected;
        foreach (string state in new[] { "normal", "hover", "pressed", "hover_pressed" })
        {
            string fill=Selected || state!="normal" ? "28495a" : Preview ? "244550" : CalendarLayout ? Today ? "294957" : "142532" : "1d3040";
            AddThemeStyleboxOverride(state,CareerVisuals.Box(fill,CalendarLayout && (Selected || Preview)?"80e7db":"395365",CalendarLayout?5:8,0));
        }
        QueueRedraw();
    }
    public override void _Ready()
    {
        CustomMinimumSize = new(0, CalendarLayout ? CalendarHeight : 88); SizeFlagsHorizontal = SizeFlags.ExpandFill;
        SelectDate(Selected);
        AddThemeStyleboxOverride("focus", new StyleBoxEmpty());
        _heading = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore, Alignment = CalendarLayout ? BoxContainer.AlignmentMode.Begin : BoxContainer.AlignmentMode.Center };
        _heading.AddThemeConstantOverride("separation", 8); AddChild(_heading);
        if (Question && !CalendarLayout)
        {
            _heading.AddChild(new EventEmblem { CustomMinimumSize = new(24, 24), SizeFlagsVertical = SizeFlags.ShrinkCenter });
        }
        var number = new Label { Name = "CalendarNumber", Text = Number, MouseFilter = MouseFilterEnum.Ignore };
        number.AddThemeFontSizeOverride("font_size", CalendarLayout ? 21 : 18); _heading.AddChild(number);
        if (CalendarLayout && Today) { var today=new Label {Text="今天"};today.AddThemeFontSizeOverride("font_size",12);today.AddThemeColorOverride("font_color",CareerVisuals.Teal);_heading.AddChild(today); }
        if (Today) number.AddThemeFontOverride("font", CareerVisuals.InterfaceText(700));
        if (HasMatch && !CalendarLayout)
        {
            var swords = new TextureRect { Name = "CalendarMatchIcon", Texture = AffectionArt.Texture(Registered ? "calendar-crossed-swords" : "calendar-sword"),
                CustomMinimumSize = new(22, 22), SizeFlagsVertical = SizeFlags.ShrinkCenter, ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize,
                StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore };
            _heading.AddChild(swords);
        }
        if (Bond != null && !CalendarLayout)
        {
            var host = new Control { Name = "CalendarRelationship", CustomMinimumSize = new(22, 22), SizeFlagsVertical = SizeFlags.ShrinkCenter, MouseFilter = MouseFilterEnum.Ignore };
            _heading.AddChild(host);
            var date = new TextureRect { Texture = AffectionArt.Texture("calendar-date"), ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize,
                StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered, MouseFilter = MouseFilterEnum.Ignore };
            host.AddChild(date); date.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        }
        if (Wedding && !CalendarLayout) _heading.AddChild(new GiftRingMark { Name = "CalendarWedding", CustomMinimumSize = new(22, 22), SizeFlagsVertical = SizeFlags.ShrinkCenter });
        if (!CalendarLayout && !HasMatch && Bond == null && !Wedding && !Question)
        {
            var dot = new Label { Text = "·", MouseFilter = MouseFilterEnum.Ignore }; dot.AddThemeFontSizeOverride("font_size", 18); _heading.AddChild(dot);
        }
        _description = new Label { Name = "CalendarDescription", Text = Description, HorizontalAlignment = HorizontalAlignment.Center,
            AutowrapMode = TextServer.AutowrapMode.WordSmart,
            MaxLinesVisible = 2, MouseFilter = MouseFilterEnum.Ignore };
        _description.AddThemeFontSizeOverride("font_size", CalendarLayout ? Description=="训练 / 新闻" ? 12 : 14 : 16);
        if (!CalendarLayout) AddChild(_description);
        if (CalendarLayout)
        {
            _markers = new HFlowContainer {MouseFilter=MouseFilterEnum.Ignore,Alignment=FlowContainer.AlignmentMode.End};
            _markers.AddThemeConstantOverride("h_separation",2);_markers.AddThemeConstantOverride("v_separation",1);AddChild(_markers);
            foreach(var (icon,_) in Markers)
            {
                Control mark = icon=="question" ? new EventEmblem() : icon=="wedding" ? new GiftRingMark() :
                    new TextureRect {Texture=AffectionArt.Texture(icon),ExpandMode=TextureRect.ExpandModeEnum.IgnoreSize,StretchMode=TextureRect.StretchModeEnum.KeepAspectCentered};
                mark.MouseFilter=MouseFilterEnum.Ignore;mark.CustomMinimumSize=new(16,16);_markers.AddChild(mark);
            }
            _copy=new VBoxContainer { Name="CalendarCopy",GrowVertical=GrowDirection.Begin,Alignment=BoxContainer.AlignmentMode.End,MouseFilter=MouseFilterEnum.Ignore };
            AddChild(_copy); _copy.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
            _copy.OffsetLeft=7; _copy.OffsetRight=-7; _copy.OffsetTop=39; _copy.OffsetBottom=-CopyBottom;
            _copy.AddThemeConstantOverride("separation",4);
            _description.AddThemeConstantOverride("line_spacing",1);
            _description.AddThemeColorOverride("font_color",Description=="训练 / 新闻" ? CareerVisuals.Muted : CareerVisuals.Ink);
            _description.MaxLinesVisible=-1; _description.HorizontalAlignment=HorizontalAlignment.Left;
            _copy.AddChild(_description);
            _secondary=new Label {Name="CalendarDetail",Text=SecondLine,Visible=SecondLine.Length>0,
                AutowrapMode=TextServer.AutowrapMode.WordSmart,MouseFilter=MouseFilterEnum.Ignore};
            _secondary.AddThemeFontSizeOverride("font_size",12); _secondary.AddThemeConstantOverride("line_spacing",1);
            _secondary.AddThemeColorOverride("font_color",CareerVisuals.Muted); _copy.AddChild(_secondary);
            _copy.MinimumSizeChanged+=FitCalendarCopy;
            TooltipText = string.Join("\n", new[] { Description, SecondLine }.Concat(Markers.Select(m=>m.Title)).Where(s=>s.Length>0).Distinct()); ClipContents = true;
        }
        MouseEntered += () => Hover(1); MouseExited += () => Hover(0);
        ButtonDown += () => { _pressTween?.Kill(); _press = 1; QueueRedraw(); _pressTween = CreateTween(); _pressTween.TweenMethod(Callable.From<float>(v => { _press = v; QueueRedraw(); }), 1f, 0f, .24); };
        Resized += Layout; Layout();
    }
    private void Layout()
    {
        if (_heading == null) return;
        if (_markers != null)
        {
            float x = Math.Max(Today ? 65 : 39, _heading.GetCombinedMinimumSize().X+14);
            float width = Math.Max(18,Size.X-x-7);
            int perRow = Math.Max(1,(int)((width+2)/18));
            int rows = (Markers.Count+perRow-1)/perRow;
            _heading.Position=new(8,6); _heading.Size=new(x,33);
            _markers.Position=new(x,13); _markers.Size=new(width,Math.Max(16,rows*18));
            float copyWidth=Math.Max(1,Size.X-14);
            if (copyWidth<50) return;
            string detail=SecondLine;
            int split=detail.IndexOf(" · 对手：",StringComparison.Ordinal);
            if(split>=0 && _secondary!.GetThemeFont("font").GetStringSize(detail.Split('\n')[0],fontSize:12).X>copyWidth)
                detail=detail[..split]+"\n"+detail[(split+3)..];
            if(_secondary!.Text!=detail) _secondary.Text=detail;
            _copy!.OffsetTop=Math.Max(39,16+rows*18);
            FitCalendarCopy();
            QueueRedraw(); return;
        }
        _heading.Position = new(8, CalendarLayout ? 0 : 17); _heading.Size = new(Math.Max(0, Size.X - 16), 26);
        _description.Position = new(4, CalendarLayout ? CustomMinimumSize.Y-55 : 47); _description.Size = new(Math.Max(0, Size.X - 16), 36); QueueRedraw();
    }
    private void FitCalendarCopy()
    {
        if (_copy==null) return;
        // Let the same Labels that draw the glyphs negotiate their wrapped line heights.
        float height=Math.Max(CalendarHeight,Mathf.Ceil(_copy.OffsetTop+_copy.GetCombinedMinimumSize().Y+CopyBottom));
        if(!Mathf.IsEqualApprox(CustomMinimumSize.Y,height)) CustomMinimumSize=new(0,height);
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
        if (Preview) DrawRect(new Rect2(3,3,Size.X-6,Size.Y-6),new Color(CareerVisuals.Teal,.05f));
        if (PlanWindow) DrawLine(new(7, Size.Y - 3), new(Size.X - 7, Size.Y - 3), CareerVisuals.Teal, 2, true);
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
    public override void _ExitTree() { _hoverTween?.Kill(); _pressTween?.Kill(); }
}
