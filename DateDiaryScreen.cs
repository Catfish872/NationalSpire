using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private Button DateDiaryButton(Action open, int width)
    {
        var button = PrivateButton("约会日记", open, width);
        button.AddThemeStyleboxOverride("normal", CareerVisuals.Box("69465a", "e5a1c1", 8, 10));
        button.AddThemeStyleboxOverride("hover", CareerVisuals.Box("895b75", "ffc8df", 8, 10));
        return button;
    }
    private void AddCompletedDateCard(CareerData data, string person, PrivateOffer offer)
    {
                var completed = new PanelContainer { Name = "CompletedDateCard" };
                completed.AddThemeStyleboxOverride("panel", CareerVisuals.Box("353042", "cf9db9", 10, 12)); _privateBody!.AddChild(completed);
                var summary = new HBoxContainer(); summary.AddThemeConstantOverride("separation", 12); completed.AddChild(summary);
                var title = PrivateLine(offer.Title, 23, _gold); title.Name = "CompletedDateTitle";
                title.SizeFlagsHorizontal = SizeFlags.ShrinkBegin; title.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; title.ClipText = true;
                title.SizeFlagsVertical = SizeFlags.ShrinkCenter; summary.AddChild(title);
                var timing = PrivateLine($"{GameCalendar.Text(data, PrivateAppointments.Date(data, offer))} · {offer.State}", 16, _muted);
                timing.Name = "CompletedDateTime"; timing.SizeFlagsHorizontal = SizeFlags.ShrinkBegin; timing.SizeFlagsVertical = SizeFlags.ShrinkCenter; summary.AddChild(timing);
                summary.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill });
                var diary = DateDiaryButton(() => DateDiaryEntryDialog(data, person, offer.Id), 120);
                diary.Name = "CompletedDateDiary"; summary.AddChild(diary);
                void FitTitle() => title.CustomMinimumSize = new(Math.Min(title.GetThemeFont("font").GetStringSize(title.Text, fontSize: 23).X,
                    Math.Max(0, summary.Size.X - timing.GetCombinedMinimumSize().X - diary.GetCombinedMinimumSize().X - 36)), 0);
                summary.Resized += FitTitle; FitTitle(); return;
    }
    private void DateDiaryDialog(CareerData data, string person)
        => DateDiaryEntryDialog(data, person, "");
    private void DateDiaryEntryDialog(CareerData data, string person, string offerId)
    {
        var conversation = PrivateMessages.Conversation(data, person);
        var memories = DateSceneMemories.ForPerson(data, person, out string memoryWarning);
        var references = DateDiaries.ForPerson(data, person);
        var diaries = references.Select(e => e.Diary).ToList();
        foreach (var memory in memories.Where(m => diaries.All(d => d.OfferId != m.OfferId)))
        {
            var source = PrivateMessages.Mailbox(data).Conversations.GetValueOrDefault(memory.Host);
            diaries.Add(source == null ? new() { OfferId = memory.OfferId, Title = memory.Title, Season = memory.Season, Day = memory.Day }
                : DateDiaries.Records(source).FirstOrDefault(d => d.OfferId == memory.OfferId) ?? new() { OfferId = memory.OfferId, Title = memory.Title, Season = memory.Season, Day = memory.Day });
        }
        ShowCareerDialog("约会日记 · " + CareerEngine.DisplayName(data, person), "", () => true, "关闭", box =>
        {
            if (memoryWarning.Length > 0) box.AddChild(Text(memoryWarning, 16, _muted));
            var scroll = new BroadcastScroll { Name = "DateDiaryScroll", CustomMinimumSize = new(760, 440), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);
            var list = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; list.AddThemeConstantOverride("separation", 18); scroll.AddChild(list);
            foreach (var diary in diaries.OrderByDescending(d => d.OfferId == offerId).ThenByDescending(d => d.Season).ThenByDescending(d => d.Day))
            {
                var card = new PanelContainer { Name = "DateDiaryEntry" }; card.SetMeta("offer_id", diary.OfferId);
                card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("292e40", diary.OfferId == offerId ? "efb4d0" : "ad7b97", 8, 18)); list.AddChild(card);
                var body = new VBoxContainer(); body.AddThemeConstantOverride("separation", 12); card.AddChild(body);
                body.AddChild(Text($"{GameCalendar.Text(data, SeasonCalendar.Start(data, diary.Season) + diary.Day)} · {diary.Title}", 22, new Color("efb4d0")));
                body.AddChild(Text("地点 · " + diary.Location, 17, _muted)); body.AddChild(Text("内容 · " + diary.Content, 17, _ink));
                string host = references.FirstOrDefault(e => e.Diary.OfferId == diary.OfferId).Host ?? person;
                bool ended = PrivateMessages.Mailbox(data).Conversations.GetValueOrDefault(host)?.DateSceneStates.GetValueOrDefault(diary.OfferId) == "ended" || memories.Any(m => m.OfferId == diary.OfferId);
                body.AddChild(Text(diary.Summary.Length > 0 ? diary.Summary : ended ? "约会已结束，等待对方整理日记。" : "约会进行中，结束后记录这次相处的感想。", 20, _ink));
                var memory = memories.FirstOrDefault(m => m.OfferId == diary.OfferId);
                var actions = new HBoxContainer { Alignment = BoxContainer.AlignmentMode.End }; actions.AddThemeConstantOverride("separation", 12); body.AddChild(actions);
                var erase = PrivateButton("", () => DeleteDateDiaryDialog(data, person, diary, memory), 48);
                erase.Name = "DateEraseMemory"; erase.TooltipText = "管理这段回忆";
                erase.CustomMinimumSize = new(48, 48); erase.AddChild(new DateMemoryEraser { MouseFilter = MouseFilterEnum.Ignore }); actions.AddChild(erase);
                if (memory != null)
                {
                    var enter = PrivateButton("进入回忆", () => OpenDateMemory(data, person, memory), 150);
                    enter.Name = "DateEnterMemory"; actions.AddChild(enter);
                }
            }
        }, showCancel: false);
    }
    private void DeleteDateDiaryDialog(CareerData data, string person, DateDiary diary, DateSceneMemory? memory)
    {
        _cancelDialog?.Invoke();
        ShowCareerDialog("是否删除这段回忆？", "删除回忆对话：清除录制的对话与画面，保留日记摘要。\n删除整篇日记：一并移除该场约会的日记和回忆。\n已产生的角色记忆、关系和游戏结果保持原状。", () => true, "取消", showCancel: false);
        var cancel = _dialogOverlay!.FindChild("CareerDialogConfirm", true, false) as Button;
        var row = (HBoxContainer)cancel!.GetParent();
        cancel.CustomMinimumSize = new(180, 48);
        void Back()
        {
            if (!IsInsideTree() || !CareerStore.IsCurrent(data)) return;
            _cancelDialog?.Invoke(); DateDiaryEntryDialog(ViewData, person, diary.OfferId);
        }
        var error = Text("", 16, _muted); row.GetParent().AddChild(error);
        var clear = PrivateButton("删除回忆对话", () =>
        {
            try { DateSceneMemories.Delete(data, diary.OfferId); if (_dateMemory?.Memory.OfferId == diary.OfferId) _dateMemory = null; Back(); }
            catch (Exception e) { error.Text = "删除失败：" + e.Message; }
        }, 180); clear.Name = "DateDeleteReplay"; clear.CustomMinimumSize = new(180, 48); clear.Disabled = memory == null; row.AddChild(clear);
        var remove = PrivateButton("删除整篇日记", () =>
        {
            string owner = memory?.Host ?? DateDiaries.ForPerson(data, person).FirstOrDefault(e => e.Diary.OfferId == diary.OfferId).Host ?? person;
            void Removed()
            {
                try { DateSceneMemories.Delete(data, diary.OfferId); if (_dateMemory?.Memory.OfferId == diary.OfferId) _dateMemory = null; Back(); }
                catch (Exception e) { if (IsInstanceValid(error)) error.Text = "日记已删除，回忆文件清理失败：" + e.Message; }
            }
            if (memory != null && !PrivateMessages.Mailbox(data).Conversations.ContainsKey(owner))
            { Removed(); return; }
            PrivateCommand("dm-date-diary-delete", new() { Offer = diary.OfferId }, Removed, owner, message => error.Text = message);
        }, 180); remove.Name = "DateDeleteDiary"; remove.CustomMinimumSize = new(180, 48); row.AddChild(remove);
        cancel.Pressed += () => Callable.From(Back).CallDeferred();
    }
}

public partial class DateMemoryEraser : Control
{
    public override void _Ready() => SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
    public override void _Draw()
    {
        Vector2 c = Size / 2; var ink = CareerVisuals.Ink;
        Vector2[] p = [c + new Vector2(-12, 3), c + new Vector2(2, -11), c + new Vector2(12, -1), c + new Vector2(1, 10), c + new Vector2(-5, 10), c + new Vector2(-12, 3)];
        DrawPolyline(p, ink, 1.8f, true); DrawLine(c + new Vector2(-6, -3), c + new Vector2(4, 7), ink, 1.8f, true);
        DrawLine(c + new Vector2(1, 10), c + new Vector2(13, 10), ink, 1.8f, true);
    }
}
