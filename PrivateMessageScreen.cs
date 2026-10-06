using Godot;
using System.Text.Json;

namespace NationalSpire;

public partial class CareerScreen
{
    private Control? _privateOverlay;
    private VBoxContainer? _privateList, _privateBody;
    private Label? _privateTitle, _privateStatus;
    private ScrollContainer? _privateScroll;
    private TextEdit? _privateInput;
    private Button? _privateSend, _privateBadge;
    private HBoxContainer? _privateHeading;
    private VBoxContainer? _privateAttachments;
    private ScrollContainer? _privateAttachmentScroll;
    private readonly Dictionary<string, List<PrivateOffer>> _privateAttachmentDrafts = [];
    private List<PrivateOffer> PrivateAttachments => _privateAttachmentDrafts.TryGetValue(_privatePerson, out var items) ? items : _privateAttachmentDrafts[_privatePerson] = [];
    private VBoxContainer? _privateProposal;
    private string _privateProposalSignature = "";
    private string _privatePerson = "", _privateQuery = "", _privateSignature = "", _privateListSignature = "";
    private double _privateClock;
    private int _privateVisible = 40;
    private readonly Dictionary<string, string> _privateDrafts = [];
    private readonly HashSet<string> _privateExpandedReasoning = [];
    private int _privateScrollRevision;
    private static Label PrivateText(string value, int size, Color color)
    { var label = Text(value, size, color); label.Text = value; return label; }

    private void OpenPrivateMessages(string person = "")
    {
        if (_privateOverlay != null) { if (person.Length > 0) SelectPrivate(person); return; }
        var shade = new ColorRect { Name = "PrivateMessages", Color = new Color("0a121d"), MouseFilter = MouseFilterEnum.Stop, ZIndex = 22 };
        _privateOverlay = shade; _stage.AddChild(shade); shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var margin = new MarginContainer(); shade.AddChild(margin); margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        foreach (string edge in new[] { "left", "right", "top", "bottom" }) margin.AddThemeConstantOverride("margin_" + edge, 30);
        var layout = new VBoxContainer(); layout.AddThemeConstantOverride("separation", 18); margin.AddChild(layout);
        var header = new HBoxContainer(); header.AddThemeConstantOverride("separation", 16); layout.AddChild(header);
        var brand = new VBoxContainer(); brand.AddThemeConstantOverride("separation", 3); header.AddChild(brand);
        brand.AddChild(PrivateLine("私信", 30, _gold));
        brand.AddChild(PrivateLine("国运尖塔 · 选手通讯", 14, _muted));
        header.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill });
        header.AddChild(PrivateButton("提示词预览", PreviewPrivatePrompt, 170));
        header.AddChild(PrivateButton("记忆管理", PrivateMemory, 145));
        var settings = PrivateButton("", PrivateSettings, 52); settings.TooltipText = "聊天记录设置"; settings.AddChild(new PrivateIcon { Gear = true, MouseFilter = MouseFilterEnum.Ignore }); header.AddChild(settings);
        header.AddChild(PrivateButton("关闭", ClosePrivateMessages, 100));
        _privateProposal = new VBoxContainer(); _privateProposal.AddThemeConstantOverride("separation", 10); layout.AddChild(_privateProposal);
        _privateProposalSignature = "";
        var columns = new HBoxContainer { SizeFlagsVertical = SizeFlags.ExpandFill }; columns.AddThemeConstantOverride("separation", 14); layout.AddChild(columns);
        var left = new PanelContainer(); left.CustomMinimumSize = new(290, 0); left.SizeFlagsHorizontal = SizeFlags.Fill; columns.AddChild(left);
        left.AddThemeStyleboxOverride("panel", CareerVisuals.Box("101b29", "3c5265", 12, 16));
        var sidebar = Inner(left); sidebar.AddThemeConstantOverride("separation", 18);
        var search = new LineEdit { PlaceholderText = "搜索选手", CustomMinimumSize = new(260, 48) }; sidebar.AddChild(search);
        search.TextChanged += value => { _privateQuery = value; _privateListSignature = ""; RefreshPrivateList(); };
        var listScroll = new ScrollContainer { SizeFlagsVertical = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; sidebar.AddChild(listScroll);
        _privateList = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; _privateList.AddThemeConstantOverride("separation", 12); listScroll.AddChild(_privateList);
        var main = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; columns.AddChild(main);
        main.AddThemeStyleboxOverride("panel", CareerVisuals.Box("182838", "405b70", 12, 24));
        var chat = Inner(main); chat.AddThemeConstantOverride("separation", 14);
        _privateHeading = new HBoxContainer(); _privateHeading.AddThemeConstantOverride("separation", 18); chat.AddChild(_privateHeading);
        _privateTitle = Text("选择一位选手", 25, _ink); _privateHeading.AddChild(_privateTitle);
        _privateScroll = new BroadcastScroll { SizeFlagsVertical = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; chat.AddChild(_privateScroll);
        _privateBody = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ExpandFill }; _privateBody.AddThemeConstantOverride("separation", 18); _privateScroll.AddChild(_privateBody);
        _privateStatus = Text("", 14, _muted); chat.AddChild(_privateStatus);
        var composer = new PanelContainer(); composer.AddThemeStyleboxOverride("panel", CareerVisuals.Box("0d1926", "688498", 10, 14)); chat.AddChild(composer);
        var composerBody = new VBoxContainer(); composerBody.AddThemeConstantOverride("separation", 12); composer.AddChild(composerBody);
        _privateAttachmentScroll = new ScrollContainer { HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled, Visible = false }; composerBody.AddChild(_privateAttachmentScroll);
        _privateAttachments = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; _privateAttachments.AddThemeConstantOverride("separation", 8); _privateAttachmentScroll.AddChild(_privateAttachments);
        _privateInput = new TextEdit { Name = "PrivateMessageInput", PlaceholderText = "发送消息…", CustomMinimumSize = new(0, 68), WrapMode = TextEdit.LineWrappingMode.Boundary, SizeFlagsHorizontal = SizeFlags.ExpandFill };
        _privateInput.AddThemeStyleboxOverride("normal", new StyleBoxEmpty()); _privateInput.AddThemeStyleboxOverride("focus", new StyleBoxEmpty());
        _privateInput.AddThemeFontSizeOverride("font_size", 18); composerBody.AddChild(_privateInput);
        _privateInput.GuiInput += input => { if (input is InputEventKey { Pressed: true, Echo: false, CtrlPressed: true, Keycode: Key.Enter }) { _privateInput.AcceptEvent(); SendPrivate(); } };
        var actions = new HBoxContainer(); actions.AddThemeConstantOverride("separation", 14); composerBody.AddChild(actions);
        actions.AddChild(PrivateButton("＋", PrivateActions, 54));
        actions.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill });
        actions.AddChild(PrivateLine("Ctrl+Enter 发送", 14, _muted));
        _privateSend = PrivateButton("发送", SendPrivate, 150); actions.AddChild(_privateSend);
        _privateSend.AddThemeStyleboxOverride("normal", CareerVisuals.Box("d9bd7e", "f0dca7", 8, 12));
        _privateSend.AddThemeColorOverride("font_color", new Color("172330"));
        _privateSignature = _privateListSignature = ""; RefreshPrivateList();
        if (person.Length == 0 && PrivateMessages.CanChat(ViewData, PrivateMessages.Mailbox(ViewData).LastPerson)) person = PrivateMessages.Mailbox(ViewData).LastPerson;
        if (person.Length == 0) person = PrivateMessages.Mailbox(ViewData).Conversations.Values.OrderByDescending(c => c.LastReplyOrder).ThenByDescending(c => c.Turns.LastOrDefault()?.Day ?? 0).FirstOrDefault()?.PersonId ?? "";
        if (person.Length > 0 && PrivateMessages.CanChat(ViewData, person)) SelectPrivate(person);
        else { PrivateEmpty("选择一位选手", "搜索姓名，或从选手档案发起私信。"); _privateSend.Disabled = true; }
    }
    private void ClosePrivateMessages()
    {
        if (_privateOverlay == null) return;
        if (_privatePerson.Length > 0 && _privateInput != null) _privateDrafts[_privatePerson] = _privateInput.Text;
        _privateOverlay.QueueFree(); _privateOverlay = null; _privatePerson = "";
        _boundData = ViewData; Render();
    }
    private void SelectPrivate(string person)
    {
        if (!PrivateMessages.CanChat(ViewData, person)) return;
        if (_privatePerson.Length > 0) _privateDrafts[_privatePerson] = _privateInput!.Text;
        _privatePerson = person; _privateInput!.Text = _privateDrafts.GetValueOrDefault(person, "");
        _privateSend!.Disabled = false;
        RefreshPrivateAttachments(); _privateListSignature = "";
        _privateSignature = ""; _privateVisible = 40;
        PrivateMessages.Conversation(ViewData, person);
        PrivateCommand("dm-select", new()); RefreshPrivateChat();
    }
    private void TickPrivate(double delta)
    {
        _privateClock += delta; if (_privateClock < .12) return; _privateClock = 0;
        var box = PrivateMessages.Mailbox(ViewData);
        int unread = box.Conversations.Values.Sum(c => Math.Max(0, c.Turns.Count(t => t.Status == "complete") - c.SeenCount));
        if (_privateBadge != null) { _privateBadge.TooltipText = unread > 0 ? $"私信 · {unread} 条未读" : "私信"; _privateBadge.Modulate = unread > 0 ? CareerVisuals.Gold : Colors.White; }
        if (_privateOverlay == null) return;
        _multiplayer?.Refresh(); RefreshPrivateProposal(); RefreshPrivateList(); RefreshPrivateChat();
    }
    private void RefreshPrivateProposal()
    {
        if (_privateProposal == null || _multiplayer == null) return;
        string signature = _multiplayer.ProposalId + _multiplayer.ProposalText + _multiplayer.HasVoted;
        if (signature == _privateProposalSignature) return;
        _privateProposalSignature = signature; CareerVisuals.ClearContent(_privateProposal);
        if (_multiplayer.ProposalId.Length == 0) return;
        _privateProposal.AddChild(Text(_multiplayer.ProposalText, 17, _gold));
        var buttons = new HBoxContainer(); buttons.AddThemeConstantOverride("separation", 14); _privateProposal.AddChild(buttons);
        var approve = PrivateButton(_multiplayer.HasVoted ? "已准备，等待队友" : "准备开赛", () => _multiplayer.Send("confirm", _multiplayer.ProposalId), 220);
        approve.Disabled = _multiplayer.HasVoted; buttons.AddChild(approve);
        if (_multiplayer.Host || _multiplayer.HasVoted) buttons.AddChild(PrivateButton("取消安排", () => _multiplayer.Send("cancel"), 160));
    }
    private void RefreshPrivateList()
    {
        if (_privateList == null || !IsInstanceValid(_privateList)) return;
        var data = ViewData; var box = PrivateMessages.Mailbox(data);
        string signature = _privatePerson + _privateQuery + string.Join('|', box.Conversations.Select(p => p.Key + p.Value.Turns.Count + ":" + p.Value.Turns.LastOrDefault()?.Status + ":" + p.Value.SeenCount + ":" + p.Value.MemoryRevision + ":" + p.Value.LastReplyOrder));
        if (_privateListSignature == signature) return; _privateListSignature = signature; CareerVisuals.ClearContent(_privateList);
        var candidates = _privateQuery.Length > 0 ? data.People.Where(p => PrivateMessages.CanChat(data, p.Id) && (p.PublicName.Contains(_privateQuery, StringComparison.OrdinalIgnoreCase) || p.Name.Contains(_privateQuery, StringComparison.OrdinalIgnoreCase))).Take(40)
            : box.Conversations.Values.OrderByDescending(c => c.LastReplyOrder).ThenByDescending(c => c.Turns.LastOrDefault()?.Day ?? 0).Select(c => CareerEngine.Person(data, c.PersonId)).OfType<CareerPerson>();
        foreach (var p in candidates)
        {
            var c = box.Conversations.GetValueOrDefault(p.Id); int unread = c == null ? 0 : c.Turns.Count(t => t.Status == "complete") - c.SeenCount;
            var button = PrivateButton("", () => SelectPrivate(p.Id), 0); button.SizeFlagsHorizontal = SizeFlags.ExpandFill; button.CustomMinimumSize = new(0, 82); _privateList.AddChild(button);
            button.AddThemeStyleboxOverride("normal", CareerVisuals.Box(p.Id == _privatePerson ? "334b60" : "142536", p.Id == _privatePerson ? "d8bc7e" : "334b60", 8, 10));
            var inset = new MarginContainer(); button.AddChild(inset); inset.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
            foreach (var edge in new[] { "left", "right", "top", "bottom" }) inset.AddThemeConstantOverride("margin_" + edge, 10);
            var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 10); inset.AddChild(row); row.AddChild(Avatar(data, p.Id, 40, false));
            var entry = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; entry.AddThemeConstantOverride("separation", 8); row.AddChild(entry);
            var name = PrivateLine(p.PublicName + (unread > 0 ? "  ●" : ""), 17, _ink); name.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; entry.AddChild(name);
            string preview = c?.Turns.LastOrDefault(t => !(t.UserDeleted && t.ReplyDeleted)) is { } t ? t.Status == "complete" && !t.ReplyDeleted ? t.Reply : t.User : "开始聊天";
            if (preview.Length > 25) preview = preview[..25] + "…";
            var snippet = PrivateLine(preview.Replace('\n', ' '), 14, _muted); snippet.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis;
            entry.AddChild(snippet); PrivateIgnoreMouse(inset);
        }
        if (_privateList.GetChildCount() == 0) _privateList.AddChild(Text("搜索选手，或从档案发起私信。", 16, _muted));
    }
    private void RefreshPrivateChat(bool follow = true)
    {
        if (_privatePerson.Length == 0 || _privateBody == null || _privateInput == null) return;
        var data = ViewData; var c = PrivateMessages.Conversation(data, _privatePerson); var r = PrivateMessages.Relation(data, _privatePerson);
        string live = AiService.PrivateLive.TryGetValue(AiService.PrivateKey(data, _privatePerson), out var update) && c.Turns.LastOrDefault() is { Status: "sending" } last && last.Id == update.Turn ? update.Text : "";
        string thinking = AiService.PrivateReasoningLive.TryGetValue(AiService.PrivateKey(data, _privatePerson), out var thought) && c.Turns.LastOrDefault() is { Status: "sending" } current && current.Id == thought.Turn ? thought.Text : "";
        string signature = data.Day + "|" + c.MemoryRevision + "|" + c.SummaryStatus + c.Turns.Count + "|" + c.Turns.LastOrDefault()?.Status + "|" + c.Turns.LastOrDefault()?.Reply + "|" + c.Turns.LastOrDefault()?.Error + "|" + live + "|" + thinking.Length + "|" + c.SummaryError + "|" + string.Join(',', c.Offers.Select(o => o.State)) + r.Revision;
        signature += "|" + CareerTraining.MoodLevel(CareerEngine.Person(data, _privatePerson)!, data.Day);
        if (signature == _privateSignature) return; _privateSignature = signature;
        bool bottom = _privateScroll!.ScrollVertical >= _privateScroll.GetVScrollBar().MaxValue - _privateScroll.Size.Y - 90 || c.Turns.Count < 3;
        CareerVisuals.ClearContent(_privateHeading!);
        _privateHeading!.AddChild(PrivateIdentity(data, _privatePerson, true));
        CareerVisuals.ClearContent(_privateBody);
        if (c.Turns.Count > _privateVisible) _privateBody.AddChild(PrivateButton("查看更早消息", () => { _privateVisible += 40; _privateSignature = ""; RefreshPrivateChat(); }, 180));
        foreach (var turn in c.Turns.TakeLast(_privateVisible))
        {
            if (turn.UserDeleted && turn.ReplyDeleted) continue;
            _privateBody.AddChild(Text($"第 {turn.Season} 赛季 · 第 {SeasonCalendar.Day(data, turn.Day)} 天", 12, _muted));
            if (turn.Arbitration is { } ruling) _privateBody.AddChild(ArbitrationCard(data, ruling));
            else if (turn.RequestKind == "arbitration") _privateBody.AddChild(Text("尖塔仲裁 · " + (turn.Status == "failed" ? "审理中断" : "正在审理"), 20, _gold));
            if (!turn.UserDeleted) AddPrivateBubble(turn.User, true, turn);
            string reasoning = turn.Status == "sending" && turn.Id == thought.Turn ? thinking : turn.Reasoning;
            if (reasoning.Length > 0 && !turn.ReplyDeleted) AddPrivateReasoning(turn, reasoning);
            string reply = turn.Status == "sending" && turn.Id == update.Turn ? live : turn.Reply;
            if (reply.Length > 0 && !turn.ReplyDeleted) AddPrivateBubble(reply, false, turn);
            if (turn.Learning is { } learning && !turn.ReplyDeleted)
                AddPrivateLearning(turn, learning);
            foreach (var change in turn.ProfileChanges.Where(_ => !turn.ReplyDeleted)) AddPrivateProfileChange(change);
            if (turn.Mood is { } mood && !turn.ReplyDeleted) AddPrivateMood(mood);
            if (turn.Status == "failed")
            {
                _privateBody.AddChild(PrivateText(turn.Error, 15, new Color("ee929d")));
                if (turn == c.Turns.Last()) _privateBody.AddChild(PrivateButton("重试这条回复", () => PrivateCommand("dm-retry", new()), 180));
            }
            else if (turn.Error.Length > 0) _privateBody.AddChild(PrivateText(turn.Error, 14, _muted));
            foreach (var offer in c.Offers.Where(o => o.TurnId == turn.Id)) AddPrivateOffer(data, offer);
        }
        if (!c.Turns.Any(t => !(t.UserDeleted && t.ReplyDeleted)))
        {
            PrivateEmpty("开始聊天", "消息与邀约会保存在这里。");
        }
        bool busy = c.Turns.Any(t => t.Status is "queued" or "sending");
        _privateSend!.Text = busy ? "停止生成" : "发送";
        _privateStatus!.Text = c.SummaryError.Length > 0 ? c.SummaryError : busy ? "正在回复…" : c.SummaryStatus;
        _privateStatus.Visible = _privateStatus.Text.Length > 0;
        int completed = c.Turns.Count(t => t.Status == "complete");
        if (c.SeenCount < completed) PrivateCommand("dm-read", new());
        if (bottom && follow) _ = ScrollPrivateToBottom();
    }
    private async Task ScrollPrivateToBottom()
    {
        int revision = ++_privateScrollRevision;
        for (int i = 0; i < 3; i++) await ToSignal(GetTree(), SceneTree.SignalName.ProcessFrame);
        if (revision == _privateScrollRevision && _privateOverlay != null && IsInstanceValid(_privateScroll)) _privateScroll!.ScrollVertical = (int)_privateScroll.GetVScrollBar().MaxValue;
    }
    private async Task FocusPrivateReasoning(string turn)
    {
        int revision = ++_privateScrollRevision;
        for (int i = 0; i < 3; i++) await ToSignal(GetTree(), SceneTree.SignalName.ProcessFrame);
        if (revision != _privateScrollRevision || _privateOverlay == null || !IsInstanceValid(_privateBody)) return;
        var section = _privateBody!.GetChildren().OfType<Control>().FirstOrDefault(c => c.HasMeta("reasoning_turn") && c.GetMeta("reasoning_turn").AsString() == turn);
        if (section != null) _privateScroll!.EnsureControlVisible(section);
    }
    private void AddPrivateBubble(string text, bool player, PrivateTurn turn)
    {
        var row = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, Alignment = player ? BoxContainer.AlignmentMode.End : BoxContainer.AlignmentMode.Begin }; row.AddThemeConstantOverride("separation", 8); _privateBody!.AddChild(row);
        var blank = new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(65, 0) };
        if (player) row.AddChild(blank);
        var bubble = new PanelContainer { CustomMinimumSize = new(player && turn.Attachments.Count > 0 ? 640 : Math.Clamp(text.Length * 18 + 40, 200, 680), 0) };
        bubble.AddThemeStyleboxOverride("panel", CareerVisuals.Box(player ? "304b60" : "223649", player ? "597f98" : "405c72", 10, 16)); row.AddChild(bubble);
        var content = new VBoxContainer(); content.AddThemeConstantOverride("separation", 8); bubble.AddChild(content);
        if (text.Length > 0) content.AddChild(PrivateSelectableText(text, 19, _ink));
        if (player) foreach (var a in turn.Attachments) content.AddChild(PrivateAttachmentCard(a, false));
        var more = PrivateButton("···", () => PrivateMessageMenu(turn, player), 42); more.TooltipText = player ? "管理消息" : "管理消息与重新生成"; row.AddChild(more);
        if (!player) row.AddChild(blank);
    }
    private void SendPrivate()
    {
        if (_privatePerson.Length == 0) return;
        var c = PrivateMessages.Conversation(ViewData, _privatePerson);
        if (c.Turns.Any(t => t.Status is "queued" or "sending")) { PrivateCommand("dm-stop", new()); return; }
        string text = _privateInput!.Text;
        if (string.IsNullOrWhiteSpace(text) && PrivateAttachments.Count == 0) return;
        string person = _privatePerson; var attachments = PrivateAttachments.ToList();
        PrivateCommand("dm-send", new() { Text = text, Attachments = attachments }, () =>
        {
            if (_privateAttachmentDrafts.TryGetValue(person, out var pending)) pending.RemoveAll(a => attachments.Contains(a));
            if (_privatePerson == person && _privateInput != null && IsInstanceValid(_privateInput)) { if (_privateInput.Text == text) _privateInput.Text = ""; RefreshPrivateAttachments(); }
        });
    }
    private void PrivateCommand(string kind, PrivateMessageCommand command, Action? accepted = null)
    {
        string person = _privatePerson;
        if (_multiplayer != null)
        { _multiplayer.Send(kind, person, JsonSerializer.Serialize(command), accepted: () => { accepted?.Invoke(); _multiplayer.Refresh(); _privateSignature = ""; }); return; }
        var data = ViewData;
        try
        {
            if (PrivateMessageCommands.Apply(data, kind, person, command) is { } error) { _privateStatus!.Text = error; return; }
            CareerStore.Save(data); accepted?.Invoke(); _privateSignature = "";
            if (kind == "dm-confirm" && PrivateMessages.Conversation(data, person).Offers.FirstOrDefault(o => o.Id == command.Offer) is { Kind: "publish" } published)
                _ = AiService.ProcessInteractionsAsync([published.MatchId], data);
            if (kind == "dm-arbitration-apology" && CareerEngine.Person(data, person)!.Arbitrations.FirstOrDefault(r => r.Id == command.Entry) is { PostId.Length: > 0 } ruling)
                _ = AiService.ProcessInteractionsAsync([ruling.PostId], data);
            if (kind is "dm-send" or "dm-retry" or "dm-regenerate" or "dm-arbitrate") _ = AiService.ProcessPrivateAsync(() => CareerStore.IsCurrent(data) ? data : null, CareerStore.Save, person);
            if (kind == "dm-summary") _ = AiService.SummarizePrivateManually(() => CareerStore.IsCurrent(data) ? data : null, CareerStore.Save, person);
        }
        catch (Exception e) { if (_privateStatus != null) _privateStatus.Text = AiService.FailureReason(e); }
    }
    private void PrivateSettings()
    {
        var current = PrivateMessages.Mailbox(ViewData).Settings; SpinBox? maximum = null, recent = null, limit = null, merge = null; Label? error = null;
        ShowCareerDialog("聊天记录", "总结在后台进行，聊天可以继续。原始记录完整保留。", () =>
        {
            var settings = new PrivateHistorySettings { MaximumRounds = (int)maximum!.Value, RecentRounds = (int)recent!.Value, SmallSummaryLimit = (int)limit!.Value, MergeOldest = (int)merge!.Value };
            try { settings.Validate(); PrivateCommand("dm-settings", new() { Settings = settings }); return true; }
            catch (Exception e) { error!.Text = e.Message; return false; }
        }, "保存", box =>
        {
            SpinBox Field(string label, int value, int min, int max)
            {
                var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 30); box.AddChild(row); row.AddChild(Text(label, 17, _ink));
                var input = new SpinBox { MinValue = min, MaxValue = max, Value = value, CustomMinimumSize = new(160, 45) }; row.AddChild(input); return input;
            }
            maximum = Field("超过多少轮开始总结", current.MaximumRounds, 5, 500);
            recent = Field("总结后保留此前轮数", current.RecentRounds, 0, 499);
            limit = Field("聊天摘要达到多少条时合并", current.SmallSummaryLimit, 2, 100);
            merge = Field("每次合并最旧的几条摘要", current.MergeOldest, 2, 100);
            box.AddChild(Text("保留轮数另加当前一轮。提示词在模组设置中修改。", 14, _muted));
            error = Text("", 15, new Color("ee929d")); box.AddChild(error);
        });
    }
    private void PreviewPrivatePrompt()
    {
        if (_privatePerson.Length == 0) return;
        var d = ViewData; var c = PrivateMessages.Conversation(d, _privatePerson);
        // 预览包含当前草稿，既不保存也不发送。
        var copy = JsonSerializer.Deserialize<PrivateConversation>(JsonSerializer.Serialize(c))!;
        var pending = copy.Turns.LastOrDefault(t => t.Status is "queued" or "sending");
        if (pending == null) { pending = new() { Day = d.Day, Season = d.Season, User = _privateInput?.Text ?? "", Attachments = PrivateAttachments.ToList() }; copy.Turns.Add(pending); }
        string preview = string.Join("\n\n────────────────\n\n", PrivateMessagePrompts.Compose(d, copy, pending).Select(m => m["role"] + "\n" + m["content"]));
        ShowCareerDialog("私信提示词预览", "当前草稿与实际上下文。交互格式由模组管理。", () => true, "关闭", box =>
        {
            var edit = new TextEdit { Text = preview, Editable = false, CustomMinimumSize = new(950, 580), WrapMode = TextEdit.LineWrappingMode.Boundary }; edit.AddThemeFontSizeOverride("font_size", 16); box.AddChild(edit);
            box.AddChild(PrivateButton("复制完整提示词", () => DisplayServer.ClipboardSet(preview), 200));
        }, showCancel: false);
    }
    private void PrivateActions()
    {
        if (_privatePerson.Length == 0) return;
        ShowCareerDialog("添加到消息", "选好后可以继续输入，发送时一并附上。", () => true, "关闭", box =>
        {
            var grid = new GridContainer { Columns = 2 }; grid.AddThemeConstantOverride("h_separation", 16); grid.AddThemeConstantOverride("v_separation", 16); box.AddChild(grid);
            void Choice(string title, string detail, Action action) { var b = PrivateButton(title + "\n" + detail, () => { _cancelDialog?.Invoke(); action(); }, 300); b.CustomMinimumSize = new(300, 86); grid.AddChild(b); }
            Choice("约一局", "选择日期与进阶", PrivateMatchPicker);
            Choice("复盘比赛", "附上真实比赛记录", () => PrivateSharePicker("result"));
            Choice("尖塔仲裁", "申请官方审理与裁决", PrivateArbitrationDialog);
            Choice("分享帖子", "选择一篇社区讨论", () => PrivateSharePicker("post"));
            var target = CareerEngine.Person(ViewData, _privatePerson);
            if (OwnedClubs.CanOperate(ViewData) && target != null && target.ClubId != ViewData.Esports.ClubId && OwnedClubs.IsRecruitable(target))
                Choice("商谈合同", "邀请对方提出条件", () => AttachPrivate(new() { Kind = "contract" }));
        }, showCancel: false);
    }
    private void PrivateMatchPicker()
    {
        var data = ViewData; int season = data.Season, day = 0; int ascension = 0; string mode = "切磋";
        Label? selected = null; VBoxContainer? calendar = null; Label? error = null;
        void Calendar()
        {
            CareerVisuals.ClearContent(calendar!);
            var grid = new GridContainer { Columns = 7 }; grid.AddThemeConstantOverride("h_separation", 8); grid.AddThemeConstantOverride("v_separation", 8); calendar!.AddChild(grid);
            for (int n = 1; n <= SeasonCalendar.Length(data, season); n++)
            {
                int date = n; int absolute = SeasonCalendar.Start(data, season) + date;
                var entries = PrivateAppointments.Schedule(data, _privatePerson, absolute);
                string busy = string.Join("\n", entries.Select(e => e.Description));
                var button = PrivateButton(date + (entries.Any(e => e.Occupied) ? "\n有安排" : entries.Count > 0 ? "\n可报名" : "\n空闲"), () => { day = date; selected!.Text = $"第{season}赛季第{day}天"; foreach (var child in grid.GetChildren().OfType<Button>()) child.Modulate = child.Name == "Day" + date ? CareerVisuals.Teal : Colors.White; }, 96);
                button.Name = "Day" + date;
                button.Disabled = absolute < data.Day; button.TooltipText = busy; button.CustomMinimumSize = new(96, 68); grid.AddChild(button);
            }
            for (int date = 1; date <= SeasonCalendar.Length(data, season); date++)
            {
                string busy = PrivateAppointments.Busy(data, _privatePerson, SeasonCalendar.Start(data, season) + date);
                if (busy.Length > 0) calendar.AddChild(Text($"第{date}天 · {busy}", 14, _muted));
            }
        }
        ShowCareerDialog("约一局", "已有赛程显示在日历中。选好后附到消息。", () =>
        {
            var request = new PrivateOffer { Kind = "match", Season = season, Day = day, Ascension = ascension, Mode = mode };
            if (PrivateAppointments.Error(ViewData, _privatePerson, request) is { } reason) { error!.Text = reason; return false; }
            AttachPrivate(request); return true;
        }, "添加到消息", box =>
        {
            var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 18); box.AddChild(row);
            var seasonPicker = new OptionButton(); seasonPicker.AddItem("本赛季"); seasonPicker.AddItem("下赛季"); row.AddChild(seasonPicker);
            seasonPicker.ItemSelected += index => { season = data.Season + (int)index; day = 0; selected!.Text = "请选择日期"; Calendar(); };
            var asc = new SpinBox { MinValue = 0, MaxValue = 10, Prefix = "进阶", CustomMinimumSize = new(160, 45) }; asc.ValueChanged += value => ascension = (int)value; row.AddChild(asc);
            var modes = new OptionButton(); modes.AddItem("朋友切磋"); modes.AddItem("公开挑战"); modes.ItemSelected += index => mode = index == 0 ? "切磋" : "挑战"; row.AddChild(modes);
            selected = Text("请选择日期", 17, CareerVisuals.Teal); box.AddChild(selected);
            var scroll = new ScrollContainer { CustomMinimumSize = new(740, 440), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);
            calendar = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; calendar.AddThemeConstantOverride("separation", 12); scroll.AddChild(calendar); Calendar();
            error = Text("", 15, new Color("ee929d")); box.AddChild(error);
        });
    }
    private void AddPrivateOffer(CareerData data, PrivateOffer offer)
    {
        if (offer.Kind == "publish")
        {
            var postCard = new PanelContainer(); postCard.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203448", "b89e67", 8, 16)); _privateBody!.AddChild(postCard);
            var contents = Inner(postCard); contents.AddThemeConstantOverride("separation", 14);
            contents.AddChild(PrivateText((offer.Id.StartsWith("arbitration-") ? "官方要求 · 公开致歉" : "社区发帖") + " · " + (offer.State == "已确认" ? "已发布" : offer.State), 16, _gold));
            contents.AddChild(PrivateSelectableText(offer.Title, 21, _ink));
            contents.AddChild(PrivateSelectableText(offer.Detail, 17, _ink));
            var actions = new HBoxContainer(); actions.AddThemeConstantOverride("separation", 16); contents.AddChild(actions);
            if (offer.State == "待确认")
            {
                actions.AddChild(PrivateButton(offer.Id.StartsWith("arbitration-") ? "要求公开道歉" : "确认发布", () => PrivateCommand("dm-confirm", new() { Offer = offer.Id }), 130));
                actions.AddChild(PrivateButton("拒绝", () => PrivateCommand("dm-decline", new() { Offer = offer.Id }), 90));
            }
            else if (CommunityThreads.All(data).FirstOrDefault(p => p.Id == offer.MatchId) is { } post)
                actions.AddChild(PrivateButton("查看帖子 ↗", () => { ClosePrivateMessages(); OpenPost(post); }, 150));
            return;
        }
        var card = new PanelContainer(); card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("2c3947", "b89e67", 8, 16)); _privateBody!.AddChild(card);
        var box = Inner(card); box.AddThemeConstantOverride("separation", 14);
        box.AddChild(Text((offer.Kind == "match" ? "约战" : "合同报价") + " · " + offer.State, 20, _gold));
        if (offer.Kind == "match") box.AddChild(Text($"第{offer.Season}赛季第{offer.Day}天 · 进阶{offer.Ascension} · {offer.Mode}", 17, _ink));
        else
        {
            box.AddChild(PrivateText($"签字费 ${offer.Signing:#,0.##}  ·  周薪 ${offer.Wage:#,0.##}\n胜场奖金 ${offer.WinBonus:#,0.##}  ·  {offer.Weeks}周  ·  {offer.Role}", 17, _ink));
            if (CareerEngine.Person(data, _privatePerson) is { ClubId.Length: > 0 } p && p.ClubId != data.Esports.OwnedClub?.ClubId) box.AddChild(Text("转会费 " + CareerMoney.Format(OwnedClubs.TransferFee(p)) + " · 下赛季加盟", 15, _muted));
        }
        if (offer.Detail.Length > 0) box.AddChild(PrivateText(offer.Detail, 15, _muted));
        if (offer.State == "待确认")
        {
            string replacement = "";
            OptionButton? replacementPicker = null;
            bool needsReplacement = offer.Kind == "contract" && offer.Role == "首发";
            if (offer.Kind == "contract" && offer.Role == "首发" && OwnedClubs.CanOperate(data))
            {
                var ids = OwnedClubs.ReplaceableStarters(data);
                if (ids.Count == 0) box.AddChild(Text(OwnedClubs.StarterReplacementError(data, "")!, 16, _muted));
                else
                {
                    box.AddChild(Text("接替哪位首发（原首发转入轮换）", 16, _muted));
                    replacementPicker = new OptionButton { Name = "PrivateContractReplacement", SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new Vector2(0, 50) };
                    box.AddChild(replacementPicker); replacementPicker.AddItem("选择首发");
                    foreach (string id in ids) replacementPicker.AddItem(CareerEngine.DisplayName(data, id));
                    replacementPicker.ItemSelected += index => replacement = index > 0 ? ids[(int)index - 1] : "";
                }
            }
            var actions = new HBoxContainer(); actions.AddThemeConstantOverride("separation", 14); box.AddChild(actions);
            var confirm = PrivateButton(offer.Kind == "match" ? "确认安排" : "确认签约", () =>
            {
                string detail = offer.Kind == "match" ? $"第{offer.Season}赛季第{offer.Day}天 · 进阶{offer.Ascension} · {offer.Mode}"
                    : $"首次支付 ${(offer.Signing + (CareerEngine.Person(ViewData, _privatePerson) is { ClubId.Length: > 0 } p ? OwnedClubs.TransferFee(p) * 10 : 0)):#,0.##}；每周 ${offer.Wage:#,0.##}，每次获胜 ${offer.WinBonus:#,0.##}。合同 {offer.Weeks} 周，进入{offer.Role}阵容。";
                if (offer.Kind == "match") { PrivateCommand("dm-confirm", new() { Offer = offer.Id }); return; }
                ShowCareerDialog("确认" + (offer.Kind == "match" ? "约战" : "合同"), detail, () => { PrivateCommand("dm-confirm", new() { Offer = offer.Id, Replacement = replacement }); return true; });
            }, 160);
            if (offer.Kind == "contract") confirm.Disabled = !OwnedClubs.CanOperate(data) || needsReplacement;
            if (replacementPicker != null) replacementPicker.ItemSelected += _ => confirm.Disabled = OwnedClubs.StarterReplacementError(data, replacement) != null;
            actions.AddChild(confirm);
            actions.AddChild(PrivateButton("拒绝", () => PrivateCommand("dm-decline", new() { Offer = offer.Id }), 110));
        }
        else if (offer.State == "已确认" && offer.Kind == "match" && data.Matches.Any(m => m.Id == offer.MatchId && m.Status == "待赛"))
            box.AddChild(PrivateButton("取消约战", () => PrivateCommand("dm-decline", new() { Offer = offer.Id }), 140));
    }
    private void PrivateProfile(CareerData data, CareerPerson person)
    {
        if (!PrivateMessages.CanChat(data, person.Id)) return;
        if (person.Arbitrations.Count > 0) { var official = ProfileSection("官方仲裁档案"); foreach (var record in person.Arbitrations.OrderByDescending(r => r.Day)) official.AddChild(ArbitrationCard(data, record)); }
        var box = ProfileSection("与你的关系");
        box.AddChild(PrivateIdentity(data, person.Id, false));
        box.AddChild(PrivateButton("发送私信", () => OpenPrivateMessages(person.Id), 160));
    }
}

public partial class PrivateIcon : Control
{
    public bool Gear { get; set; }
    public override void _Ready() => SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
    public override void _Draw()
    {
        var center = Size / 2; var color = CareerVisuals.Ink;
        if (!Gear)
        {
            var rect = new Rect2(center - new Vector2(13, 9), new Vector2(26, 18)); DrawRect(rect, color, false, 1.8f);
            DrawLine(rect.Position, center + new Vector2(0, 2), color, 1.8f, true); DrawLine(rect.Position + new Vector2(26, 0), center + new Vector2(0, 2), color, 1.8f, true);
        }
        else
        {
            DrawArc(center, 8, 0, Mathf.Tau, 32, color, 2, true); DrawArc(center, 3, 0, Mathf.Tau, 24, color, 2, true);
            for (int i = 0; i < 8; i++) { var direction = Vector2.FromAngle(i * Mathf.Tau / 8); DrawLine(center + direction * 8, center + direction * 12, color, 3, true); }
        }
    }
}
