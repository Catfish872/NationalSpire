using Godot;

namespace NationalSpire;

public partial class EventStoryView
{
    internal EventOpeningChoice Opening { get; private set; } = new();
    internal Action? EditMaterial, EditPeople;
    private HBoxContainer _openingCards = null!;
    private Label _materialSummary = null!, _peopleSummary = null!;

    private void BuildOpeningCards()
    {
        _openingCards = new HBoxContainer();
        _openingCards.AddThemeConstantOverride("separation", 12); _reading.AddChild(_openingCards);
        Label Card(string title, string icon, string name, Action edit)
        {
            var b = ActionButton("", edit); b.Name = name; b.AccessibilityName = title;
            b.SizeFlagsHorizontal = SizeFlags.ExpandFill; b.CustomMinimumSize = new(0, 98);
            _openingCards.AddChild(b);
            var col = new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore, Alignment = BoxContainer.AlignmentMode.Center };
            b.AddChild(col); col.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
            col.OffsetLeft = 14; col.OffsetRight = -14; col.AddThemeConstantOverride("separation", 6);
            var header = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }; col.AddChild(header);
            header.AddChild(CareerScreen.Glyph(icon, 19, CareerVisuals.Teal));
            var label = Words(title, 17, Ink); label.MouseFilter = MouseFilterEnum.Ignore;
            label.SizeFlagsHorizontal = SizeFlags.ExpandFill; header.AddChild(label);
            header.AddChild(CareerScreen.Glyph("chevron-right", 15, Muted));
            var summary = Words("随机", 16, Muted); summary.MouseFilter = MouseFilterEnum.Ignore;
            summary.CustomMinimumSize = new(0, 44); summary.VerticalAlignment = VerticalAlignment.Top;
            summary.MaxLinesVisible = 2; summary.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis;
            col.AddChild(summary); return summary;
        }
        _materialSummary = Card("事件素材","book-open","EventMaterial",() => EditMaterial?.Invoke());
        _peopleSummary = Card("参与人物","users-round","EventPeople",() => EditPeople?.Invoke());
    }
    internal void SetOpening(EventOpeningChoice value, CareerData data)
    {
        Opening = value;
        void Summary(Label label, string? detail)
        {
            label.Text = detail ?? "随机"; label.AddThemeColorOverride("font_color", detail == null ? Muted : CareerVisuals.Teal);
            label.GetParent().GetParent<Button>().TooltipText = detail ?? "随机";
        }
        Summary(_materialSummary, value.Material?.Detail);
        Summary(_peopleSummary, value.People switch { null => null, { Length: 0 } => "玩家独自经历",
            var people => string.Join("、", people.Select(p => GroupChats.Name(data,p))) });
    }
}

public partial class CareerScreen
{
    private static void EventModeTabs(VBoxContainer parent, string[] names, int initial, Action<int> select)
    {
        var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 8); parent.AddChild(row);
        var group = new ButtonGroup();
        for (int i = 0; i < names.Length; ++i)
        {
            int index = i;
            var tab = OpeningControls.Chip(row, group, names[i], i == initial, () => select(index));
            tab.SizeFlagsHorizontal = SizeFlags.ExpandFill;
        }
    }
    private void EditEventPeople(EventStoryView view)
    {
        var data = ViewData; var previous = view.Opening.People;
        var chosen = previous?.ToHashSet(StringComparer.Ordinal) ?? new();
        int mode = previous == null ? 0 : chosen.Count == 0 ? 1 : 2;
        Button? confirm = null;
        void Update() { if (confirm != null) confirm.Disabled = mode == 2 && chosen.Count == 0; }
        ShowCareerDialog("参与人物", "", () =>
        {
            view.SetOpening(view.Opening with { People = mode switch { 0 => null, 1 => [], _ => chosen.ToArray() } }, data);
            return true;
        }, "采用选择", box =>
        {
            var picker = new VBoxContainer(); picker.AddThemeConstantOverride("separation", 10);
            var note = OpeningControls.Label("");
            void ShowMode(int value)
            {
                mode = value; note.Visible = mode != 2; picker.Visible = mode == 2;
                note.Text = mode == 0 ? "让故事决定今天会遇见谁，也可能是独自度过的一天。" : "这次只写玩家自己的经历。";
                if (mode == 2 && picker.GetChildCount() == 0)
                    PeoplePicker(picker, PrivateMessages.ChatCandidates(data).ToArray(), chosen, false, Update, 224);
                Update();
            }
            EventModeTabs(box, ["随机","玩家独自经历","指定人物"], mode, ShowMode);
            box.AddChild(note); box.AddChild(picker); ShowMode(mode);
        }, footer: (_,_,b) => { confirm = b; Update(); });
    }

    private void EditEventMaterial(EventStoryView view)
    {
        var d = ViewData; var previous = view.Opening.Material;
        int mode = previous == null ? 0 : previous.Category.Length == 0 ? 2 : 1;
        RandomEventSeed? selected = mode == 1 ? previous : null;
        string input = mode == 2 ? previous!.Detail : "";
        Button? confirm = null;
        void Update() { if (confirm != null) confirm.Disabled = mode == 1 && selected == null; }
        ShowCareerDialog("事件素材", "", () =>
        {
            var seed = mode switch { 1 => selected, 2 when !string.IsNullOrWhiteSpace(input) => new RandomEventSeed("",input.Trim()), _ => null };
            view.SetOpening(view.Opening with { Material = seed }, d); return true;
        }, "采用选择", box =>
        {
            var note = OpeningControls.Label("从当前事件池抽取一段生活片刻，遇见怎样的故事，留到开始时揭晓。");
            var library = new VBoxContainer(); library.AddThemeConstantOverride("separation", 9);
            var write = new VBoxContainer(); write.AddThemeConstantOverride("separation", 9);
            var editor = new TextEdit { Name = "EventSeedInput", Text = input, PlaceholderText = "写下故事的开端，例如雨停后的旧书店里，有人留下一张没有署名的书签……",
                WrapMode = TextEdit.LineWrappingMode.Boundary, CustomMinimumSize = new(0,140) };
            write.AddChild(editor); write.AddChild(OpeningControls.Label("这段文字只用于今天的际遇。",14));
            editor.TextChanged += () => input = editor.Text;
            void ShowMode(int value)
            {
                mode = value; note.Visible = mode == 0; library.Visible = mode == 1; write.Visible = mode == 2;
                if (mode == 1 && library.GetChildCount() == 0) LoadEventLibrary(library, selected, value => { selected = value; Update(); });
                Update();
            }
            EventModeTabs(box, ["随机","从事件池选择","自己填写"], mode, ShowMode);
            box.AddChild(note); box.AddChild(library); box.AddChild(write); ShowMode(mode);
        }, footer: (_,_,b) => { confirm = b; Update(); });
    }
    private async void LoadEventLibrary(VBoxContainer box, RandomEventSeed? current, Action<RandomEventSeed> choose)
    {
        if (_multiplayer is not Coop.CoopCareerSession room) { DrawEventLibrary(box,EventPools.Get(ViewData.Ai).Random,current,choose); return; }
        var status = OpeningControls.Label("正在读取事件池…"); box.AddChild(status);
        using var cancel = new CancellationTokenSource();
        box.TreeExiting += cancel.Cancel;
        RandomEventSeed[] entries;
        try
        {
            entries = await room.ReadEventPool(cancel.Token);
        }
        catch (OperationCanceledException) when (cancel.IsCancellationRequested) { return; }
        catch (Exception error) when (error is TimeoutException or IOException)
        {
            status.Text = "暂时未能读取房主的事件池。";
            Button? retry = null; retry = TextLink("重新读取", () => { retry!.Hide(); status.Hide(); LoadEventLibrary(box,current,choose); }); box.AddChild(retry);
            return;
        }
        finally { if (IsInstanceValid(box)) box.TreeExiting -= cancel.Cancel; }
        if (!cancel.IsCancellationRequested) { status.Hide(); DrawEventLibrary(box,entries,current,choose); }
    }
    private void DrawEventLibrary(VBoxContainer box, RandomEventSeed[] entries, RandomEventSeed? current, Action<RandomEventSeed> choose)
    {
        var search = new LineEdit { Name = "EventSeedSearch", PlaceholderText = "搜索素材内容", CustomMinimumSize = new(0,42) }; box.AddChild(search);
        var categories = new HFlowContainer(); categories.AddThemeConstantOverride("h_separation",6); categories.AddThemeConstantOverride("v_separation",4); box.AddChild(categories);
        var scroll = new ScrollContainer { CustomMinimumSize = new(0,206), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);
        var list = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; list.AddThemeConstantOverride("separation",6); scroll.AddChild(list);
        string filter = "全部"; var filters = new ButtonGroup(); var options = new ButtonGroup();
        var detail = OpeningControls.Label("",15,CareerVisuals.Teal); detail.CustomMinimumSize = new(0,40); detail.MaxLinesVisible = 2; detail.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; box.AddChild(detail);
        void Summary() { detail.Text = current == null ? "请选择一条素材" : "已选  ·  " + current.Detail; detail.TooltipText = current?.Detail ?? ""; }
        void Refresh()
        {
            CareerVisuals.ClearContent(list); scroll.ScrollVertical = 0;
            var results = entries.Where(s => (filter == "全部" || s.Category == filter) && s.Detail.Contains(search.Text.Trim(),StringComparison.OrdinalIgnoreCase)).ToArray();
            if (results.Length == 0) { list.AddChild(OpeningControls.Label("没有找到符合条件的素材。")); return; }
            int shown = 0;
            void More()
            {
                foreach (var seed in results.Skip(shown).Take(12))
                {
                    var b = new BroadcastButton { Text = seed.Detail, TooltipText = seed.Detail, Alignment = HorizontalAlignment.Left,
                        AutowrapMode = TextServer.AutowrapMode.WordSmart, ToggleMode = true, ButtonGroup = options,
                        ButtonPressed = seed == current, CustomMinimumSize = new(0,41) };
                    b.AddThemeFontSizeOverride("font_size",16); list.AddChild(b);
                    b.Pressed += () => { current = seed; choose(seed); Summary(); };
                }
                shown += 12;
                if (shown < results.Length)
                {
                    Button? more = null; more = TextLink("查看更多素材", () => { list.RemoveChild(more!); more!.QueueFree(); More(); }); list.AddChild(more);
                }
            }
            More();
        }
        foreach (var category in entries.Select(s=>s.Category).Distinct().Prepend("全部"))
            OpeningControls.Chip(categories,filters,category,filter==category,()=> { filter=category; Refresh(); });
        search.TextChanged += _ => Refresh(); Summary(); Refresh();
    }
}
