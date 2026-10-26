using Godot;
using System.Text.Json;

namespace NationalSpire;

public partial class CareerScreen
{
    private string _privateGroup = "", _chatFilter = "全部", _groupSignature = "", _groupError = "";
    private string ChatDraftKey => _privateGroup.Length > 0 ? "group:" + _privateGroup : _privatePerson;
    private GroupChat? CurrentGroup => ViewData.Chats.Groups.FirstOrDefault(g => g.Id == _privateGroup);
    private void GroupSidebar(VBoxContainer sidebar)
    {
        var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 6); sidebar.AddChild(row);
        foreach (string filter in new[] { "全部", "私信", "群聊" })
        {
            var b = PrivateButton(filter, () => { _chatFilter = filter; _privateListSignature = ""; RefreshPrivateList(); }, 68); b.Name = "ChatFilter" + filter; row.AddChild(b);
        }
        row.AddChild(PrivateButton("＋", () => GroupMemberPicker(null, people => GroupCommand("group-create", new() { People = people, Text = _groupCreateName })), 42));
    }
    private string _groupCreateName = "新群聊";
    private void OpenGroupPerson(string person)
    {
        var previous = CaptureLocation() with { Group = _privateGroup, ChatScroll = _privateScroll!.ScrollVertical, ChatPage = ChatPage };
        ClosePrivateMessagesCore(false);
        Visit(() => { _tab = "选手档案"; _personId = person; });
        _backHistory.Pop(); _backHistory.Push(previous); UpdateNavigation();
    }
    private Task RestoreGroupScroll(string group, int position) => _privateGroup == group ? ScrollChatTo(position) : Task.CompletedTask;
    private void SelectGroup(string id, int page = -1)
    {
        if (_privateOverlay == null) { OpenPrivateMessages(group: id, page: page); return; }
        if (_privateInput != null) _privateDrafts[ChatDraftKey] = _privateInput.Text;
        _privateGroup = id; _privatePerson = ""; _groupSignature = _privateListSignature = _groupError = "";
        ResetChatPage(); BindChatPage(true);
        if (page >= 0) { _groupPages.Move(page); InvalidateChatPage(0); }
        SaveChatPreferences();
        _privateInput!.Text = _privateDrafts.GetValueOrDefault(ChatDraftKey, "");
        RefreshPrivateAttachments(); RefreshPrivateList(); RefreshGroupChat();
    }
    private GroupStreamParser? _groupStreamParser;
    private string _groupStreamRaw = "", _groupStreamThought = "";
    private Action<string>? _groupReasoningUpdate;
    private readonly List<RichTextLabel?> _groupStreamLabels = [];
    private void UpdateGroupStream(GroupChat g, string live, string thought)
    {
        if (_groupStreamParser == null || live == _groupStreamRaw && thought == _groupStreamThought) return;
        if (!live.StartsWith(_groupStreamRaw, StringComparison.Ordinal)) { _groupSignature = ""; RefreshGroupChat(); return; }
        bool bottom = _privateScroll!.ScrollVertical >= _privateScroll.GetVScrollBar().MaxValue - _privateScroll.Size.Y - 90;
        using var timing = UiPerformance.Measure(UiPerformance.Work.GroupRender, "通讯");
        _groupReasoningUpdate?.Invoke(thought); _groupStreamThought = thought;
        _groupStreamParser.Feed(live[_groupStreamRaw.Length..]); _groupStreamRaw = live;
        for (int i = 0; i < _groupStreamParser.Messages.Count; i++)
        {
            var speech = _groupStreamParser.Messages[i]; string text = speech.Body.ToString().Trim();
            if (i == _groupStreamLabels.Count)
            {
                string person = g.Resolve(speech.Author);
                _groupStreamLabels.Add(GroupChats.SpeechUnavailable(ViewData, g, person).Length == 0 ? GroupBubble(person, text) : null);
            }
            if (_groupStreamLabels[i] is { } label && label.Text != text) label.Text = text;
        }
        if (bottom && ChatAtLatest) _ = ScrollPrivateToBottom();
    }
    private void RefreshGroupChat()
    {
        var g = CurrentGroup; if (g == null || _privateBody == null) return;
        BindChatPage(ChatAtBottom);
        string live = AiService.GroupLive.GetValueOrDefault(AiService.GroupKey(ViewData, g.Id), "");
        var thought = AiService.GroupReasoningLive.GetValueOrDefault(AiService.GroupKey(ViewData, g.Id));
        bool busy = GroupChats.Busy(g);
        string signature = g.Id + ":" + g.Revision + ":" + g.Turns.LastOrDefault()?.Status + ":" + _groupPages.Page + ":" + _groupPages.Size + ":" + g.SummaryStatus + g.SummaryError + ":" + ViewData.Day;
        signature += ":" + string.Join(",", g.Members.Select(id => GroupChats.CanSpeak(ViewData, id)));
        _privateSend!.Text = busy ? "正在回复…" : "发送"; _privateSend.Disabled = busy;
        _privateStatus!.Text = _groupError.Length > 0 ? _groupError : g.SummaryError.Length > 0 ? g.SummaryError : g.SummaryStatus; _privateStatus.Visible = _privateStatus.Text.Length > 0;
        if (signature == _groupSignature) { UpdateGroupStream(g, live, thought.Text ?? ""); return; } _groupSignature = signature;
        _groupStreamParser = null; _groupStreamLabels.Clear(); _groupReasoningUpdate = null;
        _groupStreamRaw = ""; _groupStreamThought = thought.Text ?? "";
        using var timing = UiPerformance.Measure(UiPerformance.Work.GroupRender, "通讯");
        bool bottom = _privateScroll!.ScrollVertical >= _privateScroll.GetVScrollBar().MaxValue - _privateScroll.Size.Y - 90;
        CareerVisuals.ClearContent(_privateHeading!);
        var heading = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; _privateHeading!.AddChild(heading);
        heading.AddChild(PrivateLine(g.Name, 26, _gold)); heading.AddChild(PrivateLine(g.Members.Count + " 位成员", 14, _muted));
        if (busy) _privateHeading.AddChild(PrivateButton("停止生成", () => GroupCommand("group-stop", new()), 110));
        CareerVisuals.ClearContent(_privateBody);
        var visibleTurns = _groupPages.Visible.ToArray();
        long first = _groupPages.Page == 0 ? 0 : visibleTurns.FirstOrDefault()?.Order ?? 0;
        long end = _groupPages.Next?.Order ?? long.MaxValue;
        var completions = TrainingCompletions(g.Forgotten ? [] : g.Interactions.Values.SelectMany(c => c.Offers), first, end);
        var entries = g.Entries.Where(e => e.Order >= first && e.Order < end).OrderBy(e => e.Order).ToArray();
        var notices = new Queue<GroupEntry>(entries);
        int lastDay = 0;
        void NoticesThrough(long order)
        {
            while (notices.TryPeek(out var entry) && entry.Order <= order)
            {
                notices.Dequeue(); lastDay = entry.Day;
                TrainingCompletionsThrough(completions, entry.Order);
                _privateBody.AddChild(PrivateLine(PrivateAppointments.DateText(ViewData, entry.Day) + " · " + entry.Text, 13, _muted));
            }
            TrainingCompletionsThrough(completions, order);
        }
        var events = entries.Select(e => (e.Order, Notice: (GroupEntry?)e, Turn: (GroupTurn?)null))
            .Concat(visibleTurns.Select(t => (t.Order, Notice: (GroupEntry?)null, Turn: (GroupTurn?)t))).OrderBy(x => x.Order);
        foreach (var item in events)
        {
            TrainingCompletionsThrough(completions, item.Order);
            if (item.Notice != null) { NoticesThrough(item.Notice.Order); continue; }
            var t = item.Turn!;
            if (lastDay != t.Day) { _privateBody.AddChild(PrivateLine(PrivateAppointments.DateText(ViewData, t.Day), 13, _muted)); lastDay = t.Day; }
            if (t.Text.Length > 0 || t.Attachments.Count > 0) GroupBubble(t.Sender, t.Text, t.Attachments);
            string reasoning = t.Status == "sending" && thought.Turn == t.Id ? thought.Text ?? "" : t.Reasoning;
            if (reasoning.Length > 0 || t.Status == "sending")
            {
                var updateReasoning = AddChatReasoning(t.Id, reasoning);
                if (t.Status == "sending") _groupReasoningUpdate = updateReasoning;
            }
            if (t.Status == "complete") foreach (var r in t.Replies) { NoticesThrough(r.Order); GroupBubble(r.Author, r.Text); }
            else
            {
                var parser = new GroupStreamParser(); parser.Feed(t.Status == "sending" && live.Length > 0 ? live : t.Raw);
                foreach (var (r, i) in parser.Messages.Select((r, i) => (r, i)))
                {
                    RichTextLabel? label = null; string person = g.Resolve(r.Author);
                    if (GroupChats.SpeechUnavailable(ViewData, g, person).Length == 0)
                    { NoticesThrough(i < t.SpeechOrders.Count ? t.SpeechOrders[i] : t.Order); label = GroupBubble(person, r.Body.ToString()); }
                    if (t.Status == "sending") _groupStreamLabels.Add(label);
                }
                if (t.Status == "sending") { _groupStreamParser = parser; _groupStreamRaw = live.Length > 0 ? live : t.Raw; }
            }
            foreach (var e in t.Effects)
            {
                if (e.Text.Length > 0)
                {
                    var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 8); _privateBody.AddChild(row);
                    row.AddChild(Avatar(ViewData, e.Person, 24, false)); row.AddChild(PrivateText(GroupChats.Name(ViewData, e.Person) + " · " + e.Text, 14, CareerVisuals.Teal));
                }
                if (g.Interactions.TryGetValue(e.Lane, out var lane)) foreach (var offer in lane.Offers.Where(o => o.TurnId == e.Turn)) GroupOffer(g, e, offer);
            }
            foreach (string notice in t.Notices)
            {
                if (notice.Contains("当前版本暂不支持 NPC 间约战"))
                {
                    var card = new PanelContainer(); card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203448", "668d9b", 10, 16));
                    _privateBody.AddChild(card); Inner(card).AddChild(PrivateText(notice, 16, _ink));
                }
                else _privateBody.AddChild(PrivateText(notice, 14, _muted));
            }
            if (t.Error.Length > 0) _privateBody.AddChild(PrivateText(t.Error, 14, new Color("ee929d")));
            if (t == g.Turns.LastOrDefault() && !busy)
            {
                if (t.Status == "failed") _privateBody.AddChild(PrivateButton("重试这轮回复", () => GroupCommand("group-retry", new()), 180));
                else if (t.Status == "complete" && (t.Replies.Count > 0 || t.Raw.Length > 0) && t.ArbitrationTargets.Count == 0) _privateBody.AddChild(PrivateButton("重新生成本轮", () => GroupCommand("group-regenerate", new()), 180));
            }
        }
        TrainingCompletionsThrough(completions, long.MaxValue);
        if (_groupPages.Count == 0 && entries.Length == 0) _privateBody.AddChild(PrivateText("开始群聊", 20, _muted));
        if (ChatAtLatest && g.Seen.GetValueOrDefault(GroupChats.Human(ViewData)) < g.Turns.Count(t => t.Status == "complete")) GroupCommand("group-read", new());
        FinishChatPage(bottom);
    }
    private RichTextLabel GroupBubble(string person, string text, List<PrivateOffer>? attachments = null)
    {
        bool self = person == GroupChats.Human(ViewData);
        var row = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; row.AddThemeConstantOverride("separation", 12); _privateBody!.AddChild(row);
        if (self) row.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(40, 0) });
        else
        {
            var portrait = new VBoxContainer { Name = "GroupSpeaker_" + person, SizeFlagsVertical = SizeFlags.ShrinkBegin };
            portrait.AddThemeConstantOverride("separation", 3); row.AddChild(portrait);
            portrait.AddChild(Avatar(ViewData, person, 38, open: () => OpenGroupPerson(person)));
            if (!GroupChats.IsHuman(ViewData, person))
            {
                var badge = new Control { Name = "GroupFavour_" + person, CustomMinimumSize = new(38, 42), TooltipText = "对你的好感：" + PrivateMessages.Relation(ViewData, person).Favour };
                portrait.AddChild(badge); badge.AddChild(new AffectionBadge { Relation = PrivateMessages.Relation(ViewData, person), Compact = true });
            }
        }
        var contents = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = 4 }; contents.AddThemeConstantOverride("separation", 5); row.AddChild(contents);
        contents.AddChild(PrivateLine(GroupChats.Name(ViewData, person), 14, self ? _gold : CareerVisuals.Teal));
        var bubble = new PanelContainer(); bubble.AddThemeStyleboxOverride("panel", CareerVisuals.Box(self ? "304b60" : "223649", self ? "597f98" : "405c72", 10, 14)); contents.AddChild(bubble);
        var inner = Inner(bubble); var message = PrivateSelectableText(text.Trim(), 18, _ink); inner.AddChild(message);
        if (attachments != null) foreach (var a in attachments) inner.AddChild(PrivateAttachmentCard(a, false));
        if (!self) row.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(40, 0) });
        return message;
    }
    private void GroupOffer(GroupChat g, GroupEffect e, PrivateOffer o)
    {
        if (o.Kind is "gift" or OathAttachments.Kind) { GiftReceipt(o); return; }
        void Send(string kind, PrivateMessageCommand command) => GroupCommand("group-offer-" + kind, new() { Lane = e.Lane, Interaction = command });
        if (o.Kind == "training" && ClubCoaching.TrainingPlans(ViewData).FirstOrDefault(p => p.Id == o.Id) is { } plan) { PrivateTrainingCard(ViewData, plan, _privateBody!, Send); return; }
        if (o.Kind == "lineup" && ViewData.Esports.LineupRequests.FirstOrDefault(r => r.Id == o.Id) is { } request) { PrivateLineupCard(ViewData, request, _privateBody!, Send); return; }
        var card = new PanelContainer(); card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203448", "668d9b", 10, 16)); _privateBody!.AddChild(card);
        var box = Inner(card); box.AddThemeConstantOverride("separation", 10);
        string title = o.Kind switch { "match" => "约战", "contract" => "合同报价", "activity" => o.Title, "publish" => "社区发帖", "training" => "训练计划", "lineup" => "阵容调整", "favour" => "好感调整", _ => o.Kind };
        box.AddChild(PrivateText(GroupChats.Name(ViewData, e.Person) + " · " + title + " · " + o.State, 18, _gold));
        if (o.Kind == "contract") box.AddChild(PrivateText($"签字费 ${o.Signing:#,0.##} · 周薪 ${o.Wage:#,0.##}\n胜场奖金 ${o.WinBonus:#,0.##} · {o.Weeks}周 · {o.Role}", 16, _ink));
        if (o.Kind is "match" or "activity") box.AddChild(PrivateText($"{GameCalendar.Text(ViewData, PrivateAppointments.Date(ViewData, o))}" + (o.Kind == "match" ? $" · A{o.Ascension} · {o.Mode}" : " · " + string.Join("、", o.Participants.Select(id => GroupChats.Name(ViewData, id)))), 16, _ink));
        if (o.Kind == "publish") box.AddChild(PrivateText(o.Title, 19, _ink));
        if (o.Kind == "favour") box.AddChild(PrivateText($"对{GroupChats.Name(ViewData, e.Target.Length > 0 ? e.Target : e.Human)}的好感 {o.FavourBefore} → {o.FavourTargets.LastOrDefault()}", 17, _ink));
        if (o.Detail.Length > 0) box.AddChild(PrivateSelectableText(o.Detail, 16, _ink));
        if (o.Kind == "activity" && WeddingAppointments.IsWedding(o)) box.AddChild(PrivateSelectableText(WeddingAppointments.Description(ViewData, o), 15, _muted));
        string replacement = "";
        if (o.Kind == "contract" && o.Role == "首发" && o.State == "待确认")
        {
            var ids = OwnedClubs.ReplaceableStarters(ViewData); var choices = new OptionButton(); choices.AddItem("选择接替的首发");
            foreach (var id in ids) choices.AddItem(GroupChats.Name(ViewData, id)); choices.ItemSelected += n => replacement = n > 0 ? ids[(int)n - 1] : ""; box.AddChild(choices);
        }
        var actions = new HBoxContainer(); actions.AddThemeConstantOverride("separation", 12); box.AddChild(actions);
        void Action(string label, string kind) => actions.AddChild(PrivateButton(label, () => GroupCommand("group-offer-" + kind, new() { Lane = e.Lane, Interaction = new() { Offer = o.Id, Replacement = replacement } }), 110));
        if (o.Kind == "publish" && CommunityThreads.All(ViewData).FirstOrDefault(p => p.Id == o.MatchId) is { } post) actions.AddChild(PrivateButton("查看帖子 ↗", () => { ClosePrivateMessages(); OpenPost(post); }, 140));
        if (e.Human == GroupChats.Human(ViewData))
        {
            if (o.State == "待确认") { Action(o.Kind == "favour" ? "应用" : o.Kind == "publish" ? "确认发布" : "确认", "confirm"); Action(o.Kind == "favour" ? "保留原值" : "拒绝", "decline"); }
            if (o.Kind == "activity" && o.State == "已确认" && PrivateAppointments.Date(ViewData, o) == ViewData.Day)
            {
                Action("私密赴约", "attend");
                actions.AddChild(PrivateButton("公开赴约", () => Send("attend", new() { Offer = o.Id, Part = "public" }), 120));
            }
            if (o.Kind == "activity" && o.State == "已确认") Action("取消", "decline");
            if (o.Kind == "activity" && o.Participants.Contains(GroupChats.Human(ViewData))
                && (o.State == "已赴约" || o.State == "已确认" && PrivateAppointments.Date(ViewData, o) == ViewData.Day))
            {
                string group = _privateGroup;
                var date = new DateChoiceButton { Name = "GroupDate", Caption = "进入多人约会", CustomMinimumSize = new(180, 48), SizeFlagsVertical = SizeFlags.ShrinkCenter };
                date.Pressed += () => GroupCommand("group-offer-date", new() { Lane = e.Lane, Interaction = new() { Offer = o.Id } }, () =>
                {
                    if (DateGroupBridge.Find(ViewData, group, o.Id) is { } scene)
                    { OpenPrivateMessages(scene.Conversation.PersonId); OpenDateScene(scene.Offer.Id); }
                });
                actions.AddChild(date);
            }
        }
    }
    private void SendGroup()
    {
        if (CurrentGroup is not { } g || GroupChats.Busy(g)) return;
        string text = _privateInput!.Text; var attachments = PrivateAttachments.ToList(); string key = ChatDraftKey;
        GroupCommand("group-send", new() { Text = text, Attachments = attachments }, () =>
        { if (ChatDraftKey == key) { _privateInput.Text = ""; PrivateAttachments.Clear(); RefreshPrivateAttachments(); LatestChatPage(); } });
    }
    private void GroupCommand(string kind, GroupCommand command, Action? accepted = null)
    {
        command.ToolMode = AiSettingsStore.Load(ViewData.Ai).ChatTools;
        string id = _privateGroup;
        if (_multiplayer != null) { _multiplayer.Send(kind, id, JsonSerializer.Serialize(command), accepted: () => { accepted?.Invoke(); _multiplayer.Refresh(); _groupSignature = _privateListSignature = ""; if (kind == "group-create") SelectGroup(GroupChats.Visible(ViewData).Last().Id); }); return; }
        var d = ViewData;
        try
        {
            if (GroupChats.Command(d, kind, id, command) is { } error) { CareerStore.Save(d); _groupSignature = ""; _privateStatus!.Text = _groupError = error; _privateStatus.Visible = true; return; }
            CareerStore.Save(d); accepted?.Invoke(); _groupSignature = _privateListSignature = ""; if (kind != "group-read") _groupError = "";
            if (kind == "group-create") { SelectGroup(GroupChats.Visible(d).Last().Id); return; }
            if (kind is "group-send" or "group-retry" or "group-regenerate" or "group-arbitrate") _ = AiService.ProcessGroupAsync(() => CareerStore.IsCurrent(d) ? d : null, CareerStore.Save, id);
            if (kind == "group-summary") _ = AiService.SummarizeGroupAsync(() => CareerStore.IsCurrent(d) ? d : null, CareerStore.Save, id, command.Text);
            if (kind == "group-offer-confirm") _ = AiService.ProcessInteractionsAsync(CommunityThreads.PendingIds(d).ToArray(), d);
        }
        catch (Exception ex) { _privateStatus!.Text = _groupError = AiService.FailureReason(ex); _privateStatus.Visible = true; }
    }
    private void GroupMemberPicker(GroupChat? group, Action<List<string>> accept, bool existing = false, string title = "", bool single = false, bool showPortraits = false)
    {
        var selected = new HashSet<string>(); var d = ViewData;
        var candidates = d.People.Where(p => p.Id != GroupChats.Human(d) && (group == null || existing == group.Members.Contains(p.Id))).ToArray();
        ShowCareerDialog(title.Length > 0 ? title : group == null ? "新建群聊" : "添加群成员", "", () =>
        { var chosen = selected.ToList(); Callable.From(() => accept(chosen)).CallDeferred(); return true; }, group == null ? "创建" : "确定", box =>
        {
            if (group == null) { var name = new LineEdit { Text = _groupCreateName, PlaceholderText = "群聊名称" }; name.TextChanged += value => _groupCreateName = value; box.AddChild(name); }
            if (group != null && !existing) box.AddChild(PrivateText("当前成员：" + string.Join("、", group.Members.Select(id => GroupChats.Name(d, id))), 15, _muted));
            PeoplePicker(box, candidates, selected, single, () => { }, 300, showPortraits);
        });
    }
}
