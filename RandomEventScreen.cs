using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private EventStoryView? _eventView;
    private string _eventId = "", _eventSignature = "";
    private void EventCards(CareerData d, VBoxContainer parent, int day)
    {
        foreach (var e in d.Life.RandomEvents.Where(e => e.Day == day && e.State != "skipped"))
        {
            var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); parent.AddChild(row);
            var button = new EventStoryButton { Name = "QuestionEvent_" + e.Id, Caption = e.State == "complete" ? e.Title : "今日际遇", Detail = e.State == "complete" ? "查看你的选择与这段经历" : day > d.Day ? GameCalendar.Text(d, day) + " · 随机事件" : "生活中的另一种可能", Mark = "?", CustomMinimumSize = new(0, 92), SizeFlagsHorizontal = SizeFlags.ExpandFill };
            button.Disabled = day != d.Day && e.State != "complete";
            button.Pressed += () => OpenRandomEvent(e.Id); row.AddChild(button);
            if (e.State != "complete")
            {
                var skip = Button("跳过事件", () => EventCommand("event-skip", id: e.Id), 116);
                skip.Name = "SkipCalendarEvent_" + e.Id; skip.SizeFlagsVertical = SizeFlags.ShrinkCenter; row.AddChild(skip);
            }
        }
    }
    private void OpenRandomEvent(string id)
    {
        if (_eventView != null)
        {
            if (_eventId == id) { _eventView.Show(); RefreshRandomEvent(); return; }
            _eventView.QueueFree(); _eventView = null;
        }
        LoadChatPreferences(); _eventId = id; _eventSignature = "";
        var view = new EventStoryView(); _eventView = view;
        view.Paint = (label, value) => PaintMentionText(label, ViewData, value, RandomEvents.Find(ViewData, id)?.People, true);
        view.OpenPerson = OpenMention;
        view.Settings = RandomEventSettings;
        view.ContinueJourney = ContinueEventJourney;
        _stage.AddChild(view); view.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        view.Public.SetPressedNoSignal(ChatPreferences.GetValue(ChatPreferenceKey, "event-public", false).AsBool());
        view.Public.Toggled += value => { ChatPreferences.SetValue(ChatPreferenceKey, "event-public", value); WriteChatPreferences(); };
        view.Close = () => { view.QueueFree(); _eventView = null; Render(); };
        view.Start = () => EventCommand("event-start"); view.Stop = () => EventCommand("event-stop"); view.Skip = () => EventCommand("event-skip");
        view.Custom = action => EventCommand("event-custom", action: action);
        view.ConfirmCustom = () => EventCommand("event-custom-choose", publicly: view.Public.ButtonPressed);
        view.Choose = index => EventCommand("event-choose", index, view.Public.ButtonPressed);
        view.Tick = RefreshRandomEvent; RefreshRandomEvent();
    }
    private void RandomEventSettings()
    {
        var current = ViewData.Life;
        CheckButton? enabled = null; SpinBox? minimum = null, maximum = null;
        ShowCareerDialog("随机事件设置", "在设定的天数范围内随机安排下一次际遇。", () =>
        {
            minimum!.Apply(); maximum!.Apply();
            int min = (int)minimum.Value, max = (int)maximum.Value;
            bool on = enabled!.ButtonPressed;
            if (!MultiplayerCommand("event-settings", on ? "enabled" : "disabled", max.ToString(System.Globalization.CultureInfo.InvariantCulture), min,
                accepted: () => { _eventSignature = ""; RefreshRandomEvent(); }))
            {
                RandomEvents.SetFrequency(ViewData, on, min, max); CareerStore.Save(ViewData);
                _eventSignature = ""; RefreshRandomEvent();
            }
            return true;
        }, "保存设置", box =>
        {
            enabled = new CheckButton { Name = "RandomEventsEnabled", Text = "启用随机事件", ButtonPressed = current.RandomEventsEnabled, CustomMinimumSize = new(0, 44) }; box.AddChild(enabled);
            var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 18); box.AddChild(row);
            SpinBox Field(string caption, int value, string name)
            {
                var panel = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };
                panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("142936", "466371", 8, 18)); row.AddChild(panel);
                var fields = new VBoxContainer(); fields.AddThemeConstantOverride("separation", 12); panel.AddChild(fields);
                fields.AddChild(Text(caption, 17, _muted));
                var input = new SpinBox { Name = name, MinValue = 1, MaxValue = int.MaxValue, Step = 1, Value = value,
                    Suffix = "天", UpdateOnTextChanged = true, Editable = current.RandomEventsEnabled, CustomMinimumSize = new(220, 48), SizeFlagsHorizontal = SizeFlags.ExpandFill };
                fields.AddChild(input); return input;
            }
            minimum = Field("最小间隔", current.RandomEventMinDays, "RandomEventMinimum");
            maximum = Field("最大间隔", current.RandomEventMaxDays, "RandomEventMaximum");
            maximum.MinValue = minimum.Value;
            minimum.ValueChanged += value => maximum.MinValue = value;
            enabled.Toggled += value => { minimum.Editable = value; maximum.Editable = value; };
            box.AddChild(Text("保存后重新安排未来尚未展开的事件。当天事件和已经生成的故事继续保留。", 16, _muted));
        });
    }
    private void EventCommand(string kind, int option = 0, bool publicly = false, string? id = null, string? action = null)
    {
        string target = id ?? _eventId;
        void Updated() { if (_eventView != null) RefreshRandomEvent(); else Render(); }
        if (MultiplayerCommand(kind, target, action ?? (publicly ? "public" : "private"), option, accepted: Updated)) return;
        var d = ViewData; string? error = kind switch
        {
            "event-custom" => RandomEvents.Custom(d, target, action ?? ""), "event-custom-choose" => RandomEvents.ChooseCustom(d, target, publicly),
            "event-start" => RandomEvents.Start(d, target), "event-skip" => RandomEvents.Skip(d, target), "event-stop" => RandomEvents.Stop(d, target),
            "event-choose" => RandomEvents.Choose(d, target, option, publicly), _ => null
        };
        if (error != null) { if (_eventView != null) { _eventView.Status.Text = error; _eventView.Status.Show(); } else ShowCareerDialog("随机事件", error, () => true, "关闭", showCancel: false); return; }
        CareerStore.Save(d); Updated();
        if (kind is "event-start" or "event-custom") _ = AiService.ProcessEventAsync(() => CareerStore.IsCurrent(d) ? d : null, CareerStore.Save, target);
    }
    private void RefreshRandomEvent()
    {
        if (_eventView == null || !IsInstanceValid(_eventView)) return;
        var d = ViewData; var e = RandomEvents.Find(d, _eventId); if (e == null) { _eventView.Close?.Invoke(); return; }
        var live = e.State == "generating" || e.CustomState == "generating" ? AiService.EventLive.GetValueOrDefault(AiService.EventKey(d, e.Id)) : null;
        string signature = e.State + e.CustomState + e.CustomAction + e.CustomOption?.Result + e.CustomReasoning + e.Title + e.Error + e.Options.Count + e.Selected + live?.Title + live?.Story + live?.Options + live?.Reasoning + live?.Phase + AiService.EventBusy(d, e.Id) + CareerMoney.Balance(d) + _eventView.CustomInputText;
        if (_eventSignature == signature) return; _eventSignature = signature;
        _eventView.Display(d, e, live, AiService.EventBusy(d, e.Id) || live != null);
    }
}

public partial class EventStoryView : Control
{
    public Action? Close, Start, Stop, Skip, Tick, ContinueJourney, Settings;
    public Action<int>? Choose;
    public Action<RichTextLabel, string>? Paint;
    public Action<Variant>? OpenPerson;
    public CheckButton Public { get; private set; } = null!;
    public Label Status { get; private set; } = null!;
    private Label _title = null!, _date = null!, _chapter = null!, _artTitle = null!, _phase = null!;
    private RichTextLabel _story = null!, _result = null!, _people = null!, _thought = null!, _decision = null!;
    private VBoxContainer _effects = null!;
    private Button _continue = null!, _stay = null!;
    private VBoxContainer _options = null!, _resultBox = null!, _reading = null!;
    private HBoxContainer _columns = null!;
    private Control _artSpace = null!;
    private PanelContainer _paper = null!;
    private ScrollContainer _scroll = null!, _thinkingScroll = null!;
    private EventStoryButton _start = null!;
    private Button _skip = null!, _retry = null!, _stop = null!, _history = null!, _thinking = null!;
    private TextureRect _image = null!;
    private ShaderMaterial _imageMaterial = null!;
    private Texture2D? _ownedImage;
    private string _artId = "\0", _storyText = "", _resultText = "", _choiceSignature = "", _lastState = "";
    private double _poll;
    private bool _showHistory;
    private static readonly Color Ink = new("e4e8e8"), Muted = new("a8bdc8"), Gold = new("e7ca91");
    public override void _Ready()
    {
        Name = "RandomEventView"; ZIndex = 35; MouseFilter = MouseFilterEnum.Stop;
        var shade = new ColorRect { Color = new("0c1722"), MouseFilter = MouseFilterEnum.Ignore }; AddChild(shade); shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        _image = new TextureRect { ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCovered, MouseFilter = MouseFilterEnum.Ignore };
        AddChild(_image); _image.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        _imageMaterial = new ShaderMaterial { Shader = new Shader { Code = "shader_type canvas_item; uniform float original = 0.0; void fragment(){ vec4 t=texture(TEXTURE, UV); float cover=mix(smoothstep(0.12,0.72,UV.x)*0.82+0.12,smoothstep(0.35,0.74,UV.x)*0.35,original); cover=max(cover,smoothstep(0.55,0.92,UV.y)*0.88); cover=max(cover,(1.0-smoothstep(0.0,0.17,UV.y))*0.8); COLOR=vec4(mix(t.rgb,vec3(0.047,0.09,0.13),cover),t.a); }" } };
        _image.Material = _imageMaterial;
        var margin = new MarginContainer(); AddChild(margin); margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        foreach (string side in new[] { "left", "right", "top", "bottom" }) margin.AddThemeConstantOverride("margin_" + side, side is "left" or "right" ? 32 : 22);
        var body = new VBoxContainer(); body.AddThemeConstantOverride("separation", 18); margin.AddChild(body);
        var header = new HBoxContainer(); header.AddThemeConstantOverride("separation", 12); body.AddChild(header);
        header.AddChild(new EventEmblem { CustomMinimumSize = new(34, 34) });
        _date = Words("际遇", 17, Muted); _date.SizeFlagsHorizontal = SizeFlags.ExpandFill; header.AddChild(_date);
        var exit = ActionButton("返回", () => Close?.Invoke()); exit.Name = "CloseRandomEvent"; header.AddChild(exit);
        _columns = new HBoxContainer { SizeFlagsVertical = SizeFlags.ExpandFill }; _columns.AddThemeConstantOverride("separation", 26); body.AddChild(_columns);
        _artSpace = new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = .38f }; _columns.AddChild(_artSpace);
        var artMargin = new MarginContainer(); _artSpace.AddChild(artMargin); artMargin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        artMargin.AddThemeConstantOverride("margin_bottom", 28); artMargin.AddThemeConstantOverride("margin_left", 16);
        var caption = new VBoxContainer { Alignment = BoxContainer.AlignmentMode.End }; caption.AddThemeConstantOverride("separation", 10); artMargin.AddChild(caption);
        _chapter = Words("一段尚未展开的故事", 15, CareerVisuals.Teal); caption.AddChild(_chapter);
        _artTitle = Words("生活的另一面", 30, Gold); caption.AddChild(_artTitle);
        _people = Rich(17); caption.AddChild(_people);
        _paper = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = .62f };
        _paper.AddThemeStyleboxOverride("panel", CareerVisuals.Box("101e2be8", "526774", 12, 24)); _columns.AddChild(_paper);
        var column = new VBoxContainer(); column.AddThemeConstantOverride("separation", 16); _paper.AddChild(column);
        _title = Words("未知的际遇", 30, Gold); column.AddChild(_title);
        _phase = Words("", 14, CareerVisuals.Teal); column.AddChild(_phase);
        _scroll = new ScrollContainer { SizeFlagsVertical = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; column.AddChild(_scroll);
        _reading = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; _reading.AddThemeConstantOverride("separation", 12); _scroll.AddChild(_reading);
        var readingTools = new HFlowContainer(); readingTools.AddThemeConstantOverride("h_separation", 10); _reading.AddChild(readingTools);
        _thinking = ActionButton("思考过程 ▸", () => { _thinkingScroll.Visible = !_thinkingScroll.Visible; _thinking.Text = _thinkingScroll.Visible ? "思考过程 ▾" : "思考过程 ▸"; }); _thinking.SizeFlagsHorizontal = SizeFlags.ShrinkBegin; readingTools.AddChild(_thinking);
        _thinkingScroll = new ScrollContainer { CustomMinimumSize = new(0, 150), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled, Visible = false }; _reading.AddChild(_thinkingScroll);
        _thought = Rich(15); _thought.AddThemeColorOverride("default_color", Muted); _thinkingScroll.AddChild(_thought);
        _history = ActionButton("阅读故事经过 ▸", () => { _showHistory = !_showHistory; _story.Visible = _showHistory; _history.Text = _showHistory ? "收起故事经过 ▾" : "阅读故事经过 ▸"; }); _history.SizeFlagsHorizontal = SizeFlags.ShrinkBegin; readingTools.AddChild(_history);
        _story = Rich(20); _story.Name = "EventStory"; _reading.AddChild(_story);
        _start = new EventStoryButton { Caption = "展开这段故事", Detail = "人物、赛程与此刻的生活，在这里相遇", Mark = "?", CustomMinimumSize = new(0, 100) }; _start.Pressed += () => Start?.Invoke(); _reading.AddChild(_start);
        _options = new VBoxContainer(); _options.AddThemeConstantOverride("separation", 12); _reading.AddChild(_options);
        BuildCustomAction(_reading);
        _resultBox = new VBoxContainer(); _resultBox.AddThemeConstantOverride("separation", 16); _reading.AddChild(_resultBox);
        _resultBox.AddChild(Words("你的选择", 14, Muted));
        var decisionPanel = new PanelContainer(); decisionPanel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203a46", "748577", 8, 18)); _resultBox.AddChild(decisionPanel);
        _decision = Rich(20); _decision.AddThemeColorOverride("default_color", Gold); decisionPanel.AddChild(_decision);
        _result = Rich(21); _result.Name = "EventResult"; _resultBox.AddChild(_result);
        _effects = new VBoxContainer(); _effects.AddThemeConstantOverride("separation", 10); _resultBox.AddChild(_effects);
        Status = Words("", 15, new("dfbdac")); column.AddChild(Status);
        var footer = new HBoxContainer(); footer.AddThemeConstantOverride("separation", 12); body.AddChild(footer);
        Public = new CheckButton { Text = "公开这段经历", TooltipText = "所选结局可成为后续社区报道的材料。", CustomMinimumSize = new(0, 42) }; footer.AddChild(Public);
        footer.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill });
        var settings = ActionButton("设置", () => Settings?.Invoke()); settings.Name = "RandomEventSettings"; footer.AddChild(settings);
        _stop = ActionButton("停止生成", () => Stop?.Invoke()); _stop.Name = "StopRandomEvent"; footer.AddChild(_stop);
        _retry = ActionButton("重新生成", () => Start?.Invoke()); _retry.Name = "RetryRandomEvent"; footer.AddChild(_retry);
        _skip = ActionButton("跳过事件", () => Skip?.Invoke()); _skip.Name = "SkipRandomEvent"; footer.AddChild(_skip);
        _stay = ActionButton("留在当天", () => Close?.Invoke()); _stay.Name = "StayAfterEvent"; footer.AddChild(_stay);
        _continue = ActionButton("继续前往", () => ContinueJourney?.Invoke()); _continue.Name = "ContinueEventJourney"; footer.AddChild(_continue);
        Resized += Layout; Layout();
    }
    private void Layout()
    {
        if (_columns == null) return;
        _artSpace.SizeFlagsStretchRatio = Size.X < 1250 ? .28f : .38f;
        _paper.SizeFlagsStretchRatio = 1 - _artSpace.SizeFlagsStretchRatio;
    }
    private static Label Words(string text, int size, Color color)
    {
        var label = new Label { Text = text, AutowrapMode = TextServer.AutowrapMode.WordSmart };
        label.AddThemeFontSizeOverride("font_size", size); label.AddThemeColorOverride("font_color", color); return label;
    }
    private RichTextLabel Rich(int size)
    {
        var text = new RichTextLabel { FitContent = true, ScrollActive = false, SelectionEnabled = true, SizeFlagsHorizontal = SizeFlags.ExpandFill };
        text.AddThemeFontSizeOverride("normal_font_size", size); text.AddThemeConstantOverride("line_separation", 7); text.AddThemeColorOverride("default_color", Ink);
        text.AddThemeStyleboxOverride("focus", new StyleBoxEmpty());
        text.MetaClicked += meta => OpenPerson?.Invoke(meta); return text;
    }
    private static Button ActionButton(string text, Action action)
    {
        var button = new Button { Text = text, CustomMinimumSize = new(112, 42), MouseDefaultCursorShape = CursorShape.PointingHand };
        foreach (string state in new[] { "normal", "hover", "pressed" }) button.AddThemeStyleboxOverride(state, CareerVisuals.Box(state == "normal" ? "172c3c" : "2c4c5b", state == "normal" ? "476373" : "8abfb8", 7, 12));
        button.AddThemeColorOverride("font_color", Ink); button.Pressed += action; return button;
    }
    private void SetText(RichTextLabel label, string text) { if (Paint != null) Paint(label, text); else label.Text = text; }
    public void Display(CareerData d, RandomEventRecord e, EventLive? live, bool busy)
    {
        bool complete = e.State == "complete", generating = e.State == "generating", customBusy = e.CustomState == "generating", skipped = e.State == "skipped";
        if (_lastState != e.State) { if (complete) { _scroll.ScrollVertical = 0; _showHistory = false; } _lastState = e.State; }
        string art = RandomEventArt.Select(e);
        if (_artId != art)
        {
            _image.Texture = null; _ownedImage?.Dispose(); _ownedImage = null;
            var texture = RandomEventArt.Load(art); _image.Texture = texture; if (!art.StartsWith("game:")) _ownedImage = texture;
            _imageMaterial.SetShaderParameter("original", art.StartsWith("game:") ? 1f : 0f); _artId = art;
        }
        _chapter.Text = e.Seed.Length == 0 ? "一段尚未展开的故事" : RandomEventArt.Category(e) + " · " + (complete ? "已经留下的回忆" : "此刻的生活");
        _artTitle.Text = complete ? "故事告一段落" : generating ? "故事正在发生" : "生活的另一面";
        SetText(_people, string.Join("\n", e.People.Select(id => GroupChats.Name(d, id))));
        _date.Text = "际遇  /  " + GameCalendar.Text(d, e.Day);
        _title.Text = live?.Title is { Length: > 0 } title && title != "未知的际遇" ? title : e.Title;
        string story = customBusy ? e.Story : live?.Story ?? e.Story;
        if (e.State == "waiting") story = "赛程之外，也有值得停留的片刻。\n\n从这里展开一段故事，或把今天留给其他安排。";
        if (skipped) story = "你把这段时间留给了其他安排。";
        if (generating && story.Length == 0) story = "故事正在酝酿，人物与此刻的经历将在这里相遇。";
        if (_storyText != story) { _storyText = story; SetText(_story, story); }
        _story.Visible = !complete || _showHistory; _history.Visible = complete;
        _start.Visible = e.State == "waiting";
        _stop.Visible = (generating || customBusy) && busy;
        _retry.Visible = !complete && !skipped && e.State != "waiting" && (!generating || !busy);
        _retry.Visible &= !customBusy; _retry.Disabled = busy; _retry.Text = e.State == "failed" || generating ? "重试生成" : "重新生成";
        _skip.Visible = !complete && !skipped;
        Public.Visible = !complete && !skipped;
        Status.Text = PlayerFacingText.LongError(e.Error); Status.Visible = e.Error.Length > 0;
        _phase.Text = complete ? (e.Public ? "已完成 · 公开经历" : "已完成 · 私密经历") : skipped ? "已跳过" : generating ? (live?.Phase ?? "正在恢复请求") + (live?.Options > 0 ? " · 已收到" + live.Options + "个选项" : "") : e.State == "ready" ? "选择一个行动，让这段故事落下句点" : "";
        _phase.Visible = _phase.Text.Length > 0;
        string thought = customBusy ? live?.Reasoning ?? e.CustomReasoning : _customExpanded ? e.CustomReasoning : e.Reasoning; _thinking.Visible = thought.Length > 0;
        if (_thought.Text != thought) _thought.Text = thought;
        if (!_thinking.Visible) _thinkingScroll.Visible = false;
        _resultBox.Visible = complete;
        _continue.Visible = (complete || skipped) && d.Journey.Destination > d.Day;
        _continue.Text = "继续前往 " + GameCalendar.Text(d, d.Journey.Destination);
        _stay.Visible = complete || skipped;
        if (complete)
        {
            var chosen = e.Options[e.Selected]; string result = chosen.Text + "\n" + chosen.Result;
            if (_resultText != result)
            {
                _resultText = result; SetText(_decision, chosen.Text); SetText(_result, chosen.Result);
                ShowResultEffects(d, chosen);
            }
        }
        DisplayCustom(d, e, customBusy ? live : null, busy);
        var choices = e.State == "ready" ? e.Options : live?.Choices ?? [];
        var errors = choices.Select(o => RandomEventEffects.Check(d, e, o)).ToArray();
        string signature = e.State + ":" + busy + ":" + choices.Count + ":" + string.Join("|", errors);
        if (_choiceSignature == signature) return; _choiceSignature = signature;
        CareerVisuals.ClearContent(_options);
        if (e.State is "ready" or "generating")
            for (int i = 0; i < choices.Count; i++)
            {
                int index = i; var option = choices[i]; string? error = errors[i];
                var button = new EventStoryButton { Name = "EventOption_" + i, Caption = option.Text, Detail = RandomEventEffects.Preview(d, option), Mark = (i + 1).ToString(), Disabled = generating || busy || customBusy || error != null, TooltipText = error ?? "", Paint = Paint };
                button.Pressed += () => Choose?.Invoke(index); _options.AddChild(button);
                if (error != null) _options.AddChild(Words(error, 14, new("d0aaa0")));
            }
    }
    private void ShowResultEffects(CareerData data, RandomEventOption option) => ShowResultEffects(data, option, _effects);
    private void ShowResultEffects(CareerData data, RandomEventOption option, VBoxContainer _effects)
    {
        CareerVisuals.ClearContent(_effects); _effects.Visible = option.Effects.Count > 0;
        if (!_effects.Visible) return;
        _effects.AddChild(Words("这次经历带来的变化", 14, Muted));
        var tiles = new HFlowContainer(); tiles.AddThemeConstantOverride("h_separation", 10); tiles.AddThemeConstantOverride("v_separation", 10); _effects.AddChild(tiles);
        foreach (var effect in option.Effects)
        {
            bool detail = effect.ContainsKey("impression") || effect.ContainsKey("challenge") || effect.ContainsKey("status");
            var card = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };
            card.AddThemeStyleboxOverride("panel", CareerVisuals.Box(detail ? "172d39" : "203a46", "3d5965", 7, 12));
            var label = Rich(16); label.CustomMinimumSize = new(detail ? 0 : 160, 0);
            label.AddThemeColorOverride("default_color", CareerVisuals.Teal);
            SetText(label, RandomEventEffects.Preview(data, new RandomEventOption { Effects = [effect] }));
            card.AddChild(label); if (detail) _effects.AddChild(card); else tiles.AddChild(card);
        }
    }
    public override void _Process(double delta) { _poll += delta; if (_poll >= .12) { _poll = 0; Tick?.Invoke(); } }
    public override void _ExitTree() { _image.Texture = null; _ownedImage?.Dispose(); _imageMaterial.Shader.Dispose(); _imageMaterial.Dispose(); }
}

public partial class EventStoryButton : Button
{
    private StyleBoxFlat _normal = null!, _hover = null!, _disabled = null!;
    private string _caption = "";
    private RichTextLabel? _captionLabel;
    public Action<RichTextLabel, string>? Paint;
    public string Caption { get => _caption; set { _caption = value; if (_captionLabel != null) { if (Paint != null) Paint(_captionLabel, value); else _captionLabel.Text = value; } } }
    public string Detail { get; set; } = "";
    public string Mark { get; set; } = "?";
    public override void _Ready()
    {
        _normal = CareerVisuals.Box("1b3040", "456374", 8, 0); _hover = CareerVisuals.Box("294451", "94c4bd", 8, 0); _disabled = CareerVisuals.Box("17232e", "456374", 8, 0);
        MouseDefaultCursorShape = CursorShape.PointingHand;
        foreach (string state in new[] { "normal", "hover", "pressed", "focus", "disabled" }) AddThemeStyleboxOverride(state, new StyleBoxEmpty());
        var margin = new MarginContainer { MouseFilter = MouseFilterEnum.Ignore }; AddChild(margin); margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        margin.AddThemeConstantOverride("margin_left", 72); margin.AddThemeConstantOverride("margin_right", 20); margin.AddThemeConstantOverride("margin_top", 17); margin.AddThemeConstantOverride("margin_bottom", 17);
        var box = new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore }; box.AddThemeConstantOverride("separation", 8); margin.AddChild(box);
        _captionLabel = new RichTextLabel { FitContent = true, ScrollActive = false, MouseFilter = MouseFilterEnum.Ignore }; _captionLabel.AddThemeFontSizeOverride("normal_font_size", 20); _captionLabel.AddThemeColorOverride("default_color", new("ecdbb9")); box.AddChild(_captionLabel); Caption = _caption;
        var detail = new Label { Text = Detail, AutowrapMode = TextServer.AutowrapMode.WordSmart, MouseFilter = MouseFilterEnum.Ignore }; detail.AddThemeFontSizeOverride("font_size", 15); detail.AddThemeColorOverride("font_color", new("aac1c9")); box.AddChild(detail);
        if (Mark == "?")
        {
            var emblem = new EventEmblem { Size = new(44, 44), AnchorTop = .5f, AnchorBottom = .5f, OffsetTop = -22, OffsetBottom = 22, OffsetLeft = 14, OffsetRight = 58 }; AddChild(emblem);
        }
        void ResizeContent() { CustomMinimumSize = new(0, Math.Max(88, box.GetCombinedMinimumSize().Y + 36)); QueueRedraw(); }
        box.MinimumSizeChanged += ResizeContent; Resized += QueueRedraw; MouseEntered += QueueRedraw; MouseExited += QueueRedraw; FocusEntered += QueueRedraw; FocusExited += QueueRedraw;
        ResizeContent();
    }
    public override void _Draw()
    {
        float w = Size.X, h = Size.Y; bool active = !Disabled && (IsHovered() || HasFocus());
        Color edge = new(active ? "94c4bd" : "456374");
        DrawStyleBox(Disabled ? _disabled : active ? _hover : _normal, new Rect2(Vector2.Zero, Size));
        DrawLine(new(14, 1), new(Math.Min(66, w - 14), 1), new("c9b27d"), 2, true);
        if (Mark != "?")
        {
            var c = new Vector2(35, h / 2); DrawCircle(c, 18, new Color("10212d")); DrawArc(c, 18, 0, Mathf.Tau, 40, edge, 1, true);
            var font = GetThemeFont("font"); int size = 19;
            float width = font.GetStringSize(Mark, fontSize: size).X;
            DrawString(font, c + new Vector2(-width / 2, (font.GetAscent(size) - font.GetDescent(size)) / 2), Mark, fontSize: size, modulate: new("dfc994"));
        }
    }
}
