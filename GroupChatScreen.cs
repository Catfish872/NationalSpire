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
        var previous = CaptureLocation() with { Group = _privateGroup, ChatScroll = _privateScroll!.ScrollVertical };
        ClosePrivateMessagesCore(false);
        Visit(() => { _tab = "选手档案"; _personId = person; });
        _backHistory.Pop(); _backHistory.Push(previous); UpdateNavigation();
    }
    private async Task RestoreGroupScroll(string group, int position)
    {
        var tree = GetTree();
        for (int i = 0; i < 2; i++)
        {
            await ToSignal(tree, SceneTree.SignalName.ProcessFrame);
            if (!IsInstanceValid(this) || IsQueuedForDeletion() || _privateOverlay == null || _privateGroup != group) return;
        }
        _privateScroll!.ScrollVertical = position;
    }
    private void AddGroupList()
    {
        if (_chatFilter == "私信") return;
        foreach (var g in GroupChats.Visible(ViewData).Where(g => _privateQuery.Length == 0 || g.Name.Contains(_privateQuery, StringComparison.OrdinalIgnoreCase) || g.Members.Any(id => GroupChats.Name(ViewData, id).Contains(_privateQuery, StringComparison.OrdinalIgnoreCase)))
            .OrderByDescending(g => g.Turns.LastOrDefault()?.Order ?? g.Entries.LastOrDefault()?.Order ?? 0))
        {
            int unread = g.Turns.Count(t => t.Status == "complete") - g.Seen.GetValueOrDefault(GroupChats.Human(ViewData));
            var button = PrivateButton("", () => SelectGroup(g.Id), 0); button.CustomMinimumSize = new(0, 82); button.SizeFlagsHorizontal = SizeFlags.ExpandFill;
            button.AddThemeStyleboxOverride("normal", CareerVisuals.Box(g.Id == _privateGroup ? "334b60" : "142536", g.Id == _privateGroup ? "d8bc7e" : "334b60", 8, 10));
            _privateList!.AddChild(button);
            var inset = new MarginContainer(); button.AddChild(inset); inset.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
            foreach (var edge in new[] { "left", "right", "top", "bottom" }) inset.AddThemeConstantOverride("margin_" + edge, 12);
            var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); inset.AddChild(row);
            var emblem = PrivateLine("群", 23, CareerVisuals.Teal); emblem.CustomMinimumSize = new(38, 0); emblem.SizeFlagsHorizontal = SizeFlags.ShrinkBegin; row.AddChild(emblem);
            var text = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; text.AddThemeConstantOverride("separation", 6); row.AddChild(text);
            var title = PrivateLine(g.Name + (unread > 0 ? "  ●" : ""), 17, _ink); title.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; text.AddChild(title);
            string snippet = g.Turns.LastOrDefault()?.Replies.LastOrDefault()?.Text ?? g.Turns.LastOrDefault()?.Text ?? $"{g.Members.Count} 位成员";
            var preview = PrivateLine(snippet.Replace('\n', ' '), 14, _muted); preview.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; text.AddChild(preview); PrivateIgnoreMouse(inset);
        }
    }
    private void SelectGroup(string id)
    {
        if (_privateOverlay == null) OpenPrivateMessages();
        if (_privateInput != null) _privateDrafts[ChatDraftKey] = _privateInput.Text;
        _privateGroup = id; _privatePerson = ""; _groupSignature = _privateListSignature = _groupError = ""; _privateVisible = 40;
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
        if (bottom) _ = ScrollPrivateToBottom();
    }
    private void RefreshGroupChat()
    {
        var g = CurrentGroup; if (g == null || _privateBody == null) return;
        string live = AiService.GroupLive.GetValueOrDefault(AiService.GroupKey(ViewData, g.Id), "");
        var thought = AiService.GroupReasoningLive.GetValueOrDefault(AiService.GroupKey(ViewData, g.Id));
        bool busy = GroupChats.Busy(g);
        string signature = g.Id + ":" + g.Revision + ":" + g.Turns.LastOrDefault()?.Status + ":" + _privateVisible + ":" + g.SummaryStatus + g.SummaryError + ":" + ViewData.Day;
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
        _privateHeading.AddChild(PrivateButton("群成员", () => GroupMemberPicker(g, people => GroupCommand("group-add", new() { People = people })), 110));
        if (busy) _privateHeading.AddChild(PrivateButton("停止生成", () => GroupCommand("group-stop", new()), 110));
        CareerVisuals.ClearContent(_privateBody);
        if (g.Turns.Count > _privateVisible) _privateBody.AddChild(PrivateButton("查看更早消息", () => { _privateVisible += 40; _groupSignature = ""; RefreshGroupChat(); }, 180));
        long first = g.Turns.Count > _privateVisible ? g.Turns[^_privateVisible].Order : 0;
        var notices = new Queue<GroupEntry>(g.Entries.Where(e => e.Order >= first).OrderBy(e => e.Order));
        int lastDay = 0;
        void NoticesThrough(long order)
        {
            while (notices.TryPeek(out var entry) && entry.Order <= order)
            {
                notices.Dequeue(); lastDay = entry.Day;
                _privateBody.AddChild(PrivateLine(PrivateAppointments.DateText(ViewData, entry.Day) + " · " + entry.Text, 13, _muted));
            }
        }
        var events = g.Entries.Where(e => e.Order >= first).Select(e => (e.Order, Notice: (GroupEntry?)e, Turn: (GroupTurn?)null))
            .Concat(g.Turns.TakeLast(_privateVisible).Select(t => (t.Order, Notice: (GroupEntry?)null, Turn: (GroupTurn?)t))).OrderBy(x => x.Order);
        foreach (var item in events)
        {
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
        if (!g.Turns.Any()) _privateBody.AddChild(PrivateText("开始群聊", 20, _muted));
        if (bottom) _ = ScrollPrivateToBottom();
        if (g.Seen.GetValueOrDefault(GroupChats.Human(ViewData)) < g.Turns.Count(t => t.Status == "complete")) GroupCommand("group-read", new());
    }
    private RichTextLabel GroupBubble(string person, string text, List<PrivateOffer>? attachments = null)
    {
        bool self = person == GroupChats.Human(ViewData);
        var row = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; row.AddThemeConstantOverride("separation", 12); _privateBody!.AddChild(row);
        if (self) row.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(40, 0) });
        else row.AddChild(Avatar(ViewData, person, 38, open: () => OpenGroupPerson(person)));
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
        void Send(string kind, PrivateMessageCommand command) => GroupCommand("group-offer-" + kind, new() { Lane = e.Lane, Interaction = command });
        if (o.Kind == "training" && ClubCoaching.TrainingPlans(ViewData).FirstOrDefault(p => p.Id == o.Id) is { } plan) { PrivateTrainingCard(ViewData, plan, _privateBody!, Send); return; }
        if (o.Kind == "lineup" && ViewData.Esports.LineupRequests.FirstOrDefault(r => r.Id == o.Id) is { } request) { PrivateLineupCard(ViewData, request, _privateBody!, Send); return; }
        var card = new PanelContainer(); card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203448", "668d9b", 10, 16)); _privateBody!.AddChild(card);
        var box = Inner(card); box.AddThemeConstantOverride("separation", 10);
        string title = o.Kind switch { "match" => "约战", "contract" => "合同报价", "activity" => o.Title, "publish" => "社区发帖", "training" => "训练计划", "lineup" => "阵容调整", "favour" => "好感调整", _ => o.Kind };
        box.AddChild(PrivateText(GroupChats.Name(ViewData, e.Person) + " · " + title + " · " + o.State, 18, _gold));
        if (o.Kind == "contract") box.AddChild(PrivateText($"签字费 ${o.Signing:#,0.##} · 周薪 ${o.Wage:#,0.##}\n胜场奖金 ${o.WinBonus:#,0.##} · {o.Weeks}周 · {o.Role}", 16, _ink));
        if (o.Kind is "match" or "activity") box.AddChild(PrivateText($"第{o.Season}赛季第{o.Day}天" + (o.Kind == "match" ? $" · A{o.Ascension} · {o.Mode}" : " · " + string.Join("、", o.Participants.Select(id => GroupChats.Name(ViewData, id)))), 16, _ink));
        if (o.Kind == "publish") box.AddChild(PrivateText(o.Title, 19, _ink));
        if (o.Kind == "favour") box.AddChild(PrivateText($"对{GroupChats.Name(ViewData, e.Target.Length > 0 ? e.Target : e.Human)}的好感 {o.FavourBefore} → {o.FavourTargets.LastOrDefault()}", 17, _ink));
        if (o.Detail.Length > 0) box.AddChild(PrivateSelectableText(o.Detail, 16, _ink));
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
            if (o.Kind == "activity" && o.State == "已确认" && PrivateAppointments.Date(ViewData, o) == ViewData.Day) Action("确认赴约", "attend");
            if (o.Kind == "activity" && o.State == "已确认") Action("取消", "decline");
        }
    }
    private void SendGroup()
    {
        if (CurrentGroup is not { } g || GroupChats.Busy(g)) return;
        string text = _privateInput!.Text; var attachments = PrivateAttachments.ToList(); string key = ChatDraftKey;
        GroupCommand("group-send", new() { Text = text, Attachments = attachments }, () =>
        { if (ChatDraftKey == key) { _privateInput.Text = ""; PrivateAttachments.Clear(); RefreshPrivateAttachments(); } });
    }
    private void GroupCommand(string kind, GroupCommand command, Action? accepted = null)
    {
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
    private void GroupMemberPicker(GroupChat? group, Action<List<string>> accept, bool existing = false, string title = "", bool single = false)
    {
        var selected = new HashSet<string>(); string search = "", filter = "全部"; Label? count = null;
        var d = ViewData;
        var opponents = d.Results.AsEnumerable().Reverse().SelectMany(r => r.OpponentParticipants.Append(r.OpponentId)).Distinct().Select((id, i) => (id, i)).ToDictionary(x => x.id, x => x.i);
        var authors = CommunityThreads.All(d).OrderByDescending(p => p.Day).SelectMany(p => p.Replies.AsEnumerable().Reverse().Select(r => r.AuthorId).Prepend(p.AuthorId)).Distinct().Select((id, i) => (id, i)).ToDictionary(x => x.id, x => x.i);
        var familiar = d.Life.Mailbox.Conversations.Where(c => c.Value.Turns.Any(t => t.Status == "complete")).Select(c => c.Key)
            .Concat(d.Life.Mailbox.Relations.Keys).Concat(GroupChats.Visible(d).SelectMany(g => g.Turns).SelectMany(t => t.Replies).Select(r => r.Author)).ToHashSet();
        var candidates = d.People.Where(p => p.Id != GroupChats.Human(d) && (group == null || existing == group.Members.Contains(p.Id))).ToArray();
        CareerPerson[] people = []; ScrollContainer? scroll = null; Control? list = null;
        var rows = new List<(HBoxContainer Row, CheckBox Check)>();
        const int rowHeight = 64;
        void ShowRows()
        {
            using var timing = UiPerformance.Measure(UiPerformance.Work.MemberRows);
            if (scroll == null || list == null) return;
            int first = Math.Clamp(scroll.ScrollVertical / rowHeight, 0, Math.Max(0, people.Length - 1));
            int visible = Math.Min(people.Length - first, (int)Math.Ceiling(Math.Max(330, scroll.Size.Y) / rowHeight) + 1);
            while (rows.Count < visible)
            {
                var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); list.AddChild(row);
                var check = new CheckBox { SizeFlagsHorizontal = SizeFlags.ExpandFill, TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis };
                row.AddChild(check); rows.Add((row, check));
                check.Toggled += value =>
                {
                    string id = check.GetMeta("person").AsString();
                    if (value) { if (single) selected.Clear(); selected.Add(id); } else selected.Remove(id);
                    count!.Text = "已选择 " + selected.Count + " 人";
                    if (single) foreach (var other in rows) other.Check.SetPressedNoSignal(selected.Contains(other.Check.GetMeta("person", "").AsString()));
                };
            }
            for (int i = 0; i < rows.Count; i++)
            {
                var (row, check) = rows[i]; row.Visible = i < visible; if (i >= visible) continue;
                var person = people[first + i];
                if (check.GetMeta("person", "").AsString() != person.Id)
                {
                    foreach (var old in row.GetChildren().OfType<CareerAvatar>()) { old.Hide(); old.QueueFree(); }
                    var avatar = Avatar(d, person.Id, 36, false); row.AddChild(avatar); row.MoveChild(avatar, 0);
                    check.SetMeta("person", person.Id); check.Text = person.PublicName + " · " + person.Role;
                    check.TooltipText = check.Text;
                }
                check.SetPressedNoSignal(selected.Contains(person.Id));
                row.Position = new(0, (first + i) * rowHeight); row.Size = new(list.Size.X, rowHeight - 8);
            }
        }
        void Refresh()
        {
            using var timing = UiPerformance.Measure(UiPerformance.Work.MemberFilter);
            people = candidates.Where(p => p.PublicName.Contains(search, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(search, StringComparison.OrdinalIgnoreCase))
                .Where(p => filter switch
                {
                    "熟悉的人" => familiar.Contains(p.Id),
                    "同俱乐部" => d.Esports.ClubId.Length > 0 && p.ClubId == d.Esports.ClubId,
                    "近期对手" => opponents.ContainsKey(p.Id), "近期发帖回帖者" => authors.ContainsKey(p.Id), _ => true
                }).OrderBy(p => filter == "近期对手" ? opponents[p.Id] : filter == "近期发帖回帖者" ? authors[p.Id] : selected.Contains(p.Id) ? -1 : 0).ToArray();
            list!.CustomMinimumSize = new(0, people.Length * rowHeight); scroll!.ScrollVertical = 0; ShowRows();
        }
        ShowCareerDialog(title.Length > 0 ? title : group == null ? "新建群聊" : "添加群成员", "", () => { var chosen = selected.ToList(); Callable.From(() => accept(chosen)).CallDeferred(); return true; }, group == null ? "创建" : "确定", box =>
        {
            if (group == null) { var name = new LineEdit { Text = _groupCreateName, PlaceholderText = "群聊名称" }; name.TextChanged += value => _groupCreateName = value; box.AddChild(name); }
            var searchBox = new LineEdit { PlaceholderText = "搜索名称", CustomMinimumSize = new(600, 44) }; searchBox.TextChanged += value => { search = value; Refresh(); }; box.AddChild(searchBox);
            var picker = new OptionButton { CustomMinimumSize = new(0, 42) }; foreach (string f in new[] { "全部", "熟悉的人", "同俱乐部", "近期对手", "近期发帖回帖者" }) picker.AddItem(f); picker.ItemSelected += index => { filter = picker.GetItemText((int)index); Refresh(); }; box.AddChild(picker);
            if (group != null && !existing) box.AddChild(PrivateText("当前成员：" + string.Join("、", group.Members.Select(id => GroupChats.Name(d, id))), 15, _muted));
            scroll = new ScrollContainer { CustomMinimumSize = new(600, 330), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);
            list = new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill }; scroll.AddChild(list);
            scroll.GetVScrollBar().ValueChanged += _ => ShowRows(); list.Resized += ShowRows; scroll.Resized += ShowRows;
            count = PrivateLine("已选择 0 人", 15, CareerVisuals.Teal); box.AddChild(count); Refresh();
        });
    }
}
