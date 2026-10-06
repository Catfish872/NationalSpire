using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private Control PrivateIdentity(CareerData data, string id, bool showProfile)
    {
        var person = CareerEngine.Person(data, id)!;
        var relation = PrivateMessages.Relation(data, id);
        var panel = new PanelContainer { Name = "PrivateIdentity", SizeFlagsHorizontal = SizeFlags.ExpandFill };
        panel.AddThemeStyleboxOverride("panel", new StyleBoxEmpty());
        panel.AddChild(new PrivateOrnament { MouseFilter = MouseFilterEnum.Ignore });
        var inset = new MarginContainer(); panel.AddChild(inset);
        inset.AddThemeConstantOverride("margin_bottom", 20);
        inset.AddThemeConstantOverride("margin_top", 8);
        var content = new VBoxContainer(); content.AddThemeConstantOverride("separation", 22); inset.AddChild(content);
        var identity = new HBoxContainer(); identity.AddThemeConstantOverride("separation", 20); content.AddChild(identity);
        identity.AddChild(Avatar(data, id, 72, false));
        var name = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ShrinkCenter };
        name.AddThemeConstantOverride("separation", 9); identity.AddChild(name);
        name.AddChild(PrivateText(person.PublicName, 26, _ink));
        name.AddChild(PrivateText(person.Role + "  /  " + person.Country, 14, _muted));
        double mood = CareerTraining.MoodLevel(person, data.Day);
        if (mood != 0) name.AddChild(PrivateText($"{(mood > 0 ? "状态振奋" : "状态低落")} · 剩余 {CareerTraining.MoodUntil(person, data.Day) - data.Day} 天", 15, mood > 0 ? CareerVisuals.Teal : new Color("ffb6b6")));
        if (showProfile) identity.AddChild(PrivateButton("选手档案 ↗", () => { ClosePrivateMessages(); Visit(() => { _tab = "选手档案"; _personId = id; }); }, 130));
        var favour = new VBoxContainer { Name = "FavourMedal", CustomMinimumSize = new(94, 0), TooltipText = "对你的好感 · -100 至 100" };
        favour.AddThemeConstantOverride("separation", 8); identity.AddChild(favour);
        var medal = new Control { CustomMinimumSize = new(94, 78) }; favour.AddChild(medal);
        medal.AddChild(new PrivateOrnament { Kind = "favour", MouseFilter = MouseFilterEnum.Ignore });
        var number = PrivateLine(relation.Favour.ToString(), 24, _gold); medal.AddChild(number);
        number.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect); number.OffsetBottom = -6; number.HorizontalAlignment = HorizontalAlignment.Center; number.VerticalAlignment = VerticalAlignment.Center;
        var caption = PrivateLine("好感", 14, _muted); favour.AddChild(caption); caption.HorizontalAlignment = HorizontalAlignment.Center;
        var details = new HBoxContainer(); details.AddThemeConstantOverride("separation", 24); content.AddChild(details);
        var relationship = new HBoxContainer { CustomMinimumSize = new(225, 0), SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = 1 };
        relationship.AddThemeConstantOverride("separation", 12); details.AddChild(relationship);
        var emblem = new Control { CustomMinimumSize = new(36, 48) }; relationship.AddChild(emblem);
        emblem.AddChild(new PrivateOrnament { Kind = "bond", MouseFilter = MouseFilterEnum.Ignore });
        var relationText = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; relationText.AddThemeConstantOverride("separation", 8); relationship.AddChild(relationText);
        relationText.AddChild(PrivateLine("交往关系", 13, _gold));
        relationText.AddChild(PrivateText(relation.Relationship == "初识" ? PrivateMessages.RelationshipLabel(relation.Favour) : relation.Relationship, 18, _ink));
        details.AddChild(new VSeparator { Modulate = new Color("688498") });
        var impression = new VBoxContainer { Name = "PrivateImpression", SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = 2 };
        impression.AddThemeConstantOverride("separation", 8); details.AddChild(impression);
        impression.AddChild(PrivateLine("对你的印象", 13, CareerVisuals.Teal));
        impression.AddChild(PrivateText(relation.Impression.Length > 0 ? relation.Impression : "还没有留下具体印象", 18, relation.Impression.Length > 0 ? _ink : _muted));
        return panel;
    }
    private void AddPrivateProfileChange(PrivateProfileChange change)
    {
        var card = new PanelContainer(); card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203448", "668d9b", 8, 16)); _privateBody!.AddChild(card);
        var box = new VBoxContainer(); box.AddThemeConstantOverride("separation", 10); card.AddChild(box);
        box.AddChild(PrivateText("档案变化 · " + PrivateProfileChanges.Label(change.Field), 18, _gold));
        box.AddChild(PrivateSelectableText("之前  " + (change.Before.Length > 0 ? change.Before : "未填写"), 15, _muted));
        box.AddChild(PrivateSelectableText("现在  " + change.After, 17, _ink));
        box.AddChild(PrivateSelectableText(change.Reason, 15, CareerVisuals.Teal));
    }
    private void AddPrivateLearning(PrivateTurn turn, PrivateLearning learning)
    {
        var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); _privateBody!.AddChild(row);
        var icon = new Control { CustomMinimumSize = new(32, 40) }; row.AddChild(icon);
        icon.AddChild(new PrivateOrnament { Kind = "summary", MouseFilter = MouseFilterEnum.Ignore });
        var content = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; content.AddThemeConstantOverride("separation", 5); row.AddChild(content);
        double change = (learning.After - learning.Before) * 100;
        content.AddChild(PrivateText($"{(change >= 0 ? "长期学习" : "错误理解")} · {learning.Topic}  {change:+0.00;-0.00;0.00}%", 16, change >= 0 ? CareerVisuals.Teal : new Color("ffb6b6")));
        content.AddChild(PrivateText($"进阶 {learning.Ascension} 通关率 {learning.Before:P2} → {learning.After:P2}", 14, _muted));
        if (!string.IsNullOrWhiteSpace(learning.Reason)) row.AddChild(PrivateButton("详情", () => ShowCareerDialog("水平变化", learning.Reason, () => true, "关闭", showCancel: false), 62));
    }
    private void AddPrivateMood(PrivateMood mood)
    {
        var card = new PanelContainer(); var style = CareerVisuals.Box("102431", "456577", 5, 14); style.BorderWidthLeft = 3;
        style.BorderColor = mood.Strength >= 0 ? CareerVisuals.Teal : new Color("d69299"); card.AddThemeStyleboxOverride("panel", style); _privateBody!.AddChild(card);
        var content = new VBoxContainer(); content.AddThemeConstantOverride("separation", 9); card.AddChild(content);
        var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 16); content.AddChild(row);
        var heading = PrivateText($"{(mood.Strength == 0 ? "恢复正常" : mood.Strength > 0 ? "受到鼓舞" : "心态受影响")} · 短期状态", 17, style.BorderColor); heading.SizeFlagsHorizontal = SizeFlags.ExpandFill; row.AddChild(heading);
        row.AddChild(PrivateLine(mood.Strength == 0 ? "状态影响已解除" : ViewData.Day >= mood.Day + mood.Days ? "已结束" : $"持续 {mood.Days} 天 · 逐日消退", 14, _muted));
        content.AddChild(PrivateText($"进阶 {mood.Ascension} 通关率 {mood.Before:P2} → {mood.After:P2}", 16, _ink));
        if (!string.IsNullOrWhiteSpace(mood.Reason)) content.AddChild(PrivateText(mood.Reason, 15, _muted));
    }
    private void AddPrivateReasoning(PrivateTurn turn, string text)
    {
        bool expanded = _privateExpandedReasoning.Contains(turn.Id);
        var section = new VBoxContainer { Name = "PrivateReasoning", SizeFlagsHorizontal = SizeFlags.ExpandFill }; section.AddThemeConstantOverride("separation", 10); _privateBody!.AddChild(section);
        section.SetMeta("reasoning_turn", turn.Id);
        section.AddChild(PrivateButton(expanded ? "思考过程 ▾" : "思考过程 ▸", () =>
        {
            if (!_privateExpandedReasoning.Add(turn.Id)) _privateExpandedReasoning.Remove(turn.Id);
            _privateSignature = ""; RefreshPrivateChat(false); _ = FocusPrivateReasoning(turn.Id);
        }, 145));
        if (!expanded) return;
        var panel = new PanelContainer(); panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("10202d", "41586a", 6, 18)); section.AddChild(panel);
        var scroll = new ScrollContainer { CustomMinimumSize = new(0, 150), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; panel.AddChild(scroll);
        var label = PrivateSelectableText(text, 16, _muted); scroll.AddChild(label);
    }
    private static RichTextLabel PrivateSelectableText(string text, int size, Color color)
    {
        var label = new RichTextLabel { Name = "PrivateSelectableText", Text = text, FitContent = true, ScrollActive = false,
            SelectionEnabled = true, BbcodeEnabled = false, AutowrapMode = TextServer.AutowrapMode.WordSmart,
            SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Pass };
        label.AddThemeStyleboxOverride("focus", new StyleBoxEmpty());
        label.AddThemeFontSizeOverride("normal_font_size", size); label.AddThemeColorOverride("default_color", color);
        return label;
    }
    private static void PrivateIgnoreMouse(Node parent)
    { if (parent is Control control) control.MouseFilter = MouseFilterEnum.Ignore; foreach (var child in parent.GetChildren()) PrivateIgnoreMouse(child); }
    private static Label PrivateLine(string text, int size, Color color)
    { var label = PrivateText(text, size, color); label.AutowrapMode = TextServer.AutowrapMode.Off; return label; }
    private static Button PrivateButton(string text, Action action, float width = 0)
    {
        var button = new Button { Text = text, CustomMinimumSize = new(width, 42), SizeFlagsHorizontal = SizeFlags.ShrinkBegin, SizeFlagsVertical = SizeFlags.ShrinkCenter };
        button.AddThemeFontSizeOverride("font_size", 16);
        button.AddThemeStyleboxOverride("normal", CareerVisuals.Box("273d50", "506c81", 8, 10));
        button.AddThemeStyleboxOverride("hover", CareerVisuals.Box("3a566e", "b9d6e8", 8, 10));
        button.Pressed += action; return button;
    }
    private void PrivateEmpty(string title, string detail)
    {
        var center = new CenterContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 180) }; _privateBody!.AddChild(center);
        var box = new VBoxContainer { CustomMinimumSize = new(480, 0) }; box.AddThemeConstantOverride("separation", 16); center.AddChild(box);
        var iconSpace = new Control { CustomMinimumSize = new(0, 48) }; box.AddChild(iconSpace); iconSpace.AddChild(new PrivateIcon { Modulate = _gold });
        var heading = PrivateLine(title, 24, _ink); heading.HorizontalAlignment = HorizontalAlignment.Center; box.AddChild(heading);
        var caption = PrivateLine(detail, 17, _muted); caption.HorizontalAlignment = HorizontalAlignment.Center; box.AddChild(caption);
    }
    private static string PrivateAttachmentHeading(PrivateOffer a) => a.Kind is "post" or "result"
        ? a.Detail.Split('\n', 2)[0] is { Length: > 0 } title ? title : PrivateMessages.AttachmentTitle(a)
        : PrivateMessages.AttachmentTitle(a);
    private PanelContainer PrivateAttachmentCard(PrivateOffer a, bool draft)
    {
        var card = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };
        var style = CareerVisuals.Box("203448", "526e84", 6, 10); style.BorderWidthLeft = 3; style.BorderColor = _gold; card.AddThemeStyleboxOverride("panel", style);
        var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); card.AddChild(row);
        var copy = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; copy.AddThemeConstantOverride("separation", 4); row.AddChild(copy);
        var title = PrivateLine(PrivateAttachmentHeading(a), 17, _ink); title.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; title.TooltipText = PrivateAttachmentHeading(a); copy.AddChild(title);
        string kind = a.Kind == "post" ? "帖子" : a.Kind == "result" ? "比赛记录" : a.Kind == "match" ? "比赛邀约" : "合同邀约";
        string excerpt = a.Detail.Contains('\n') ? a.Detail[(a.Detail.IndexOf('\n') + 1)..].Replace('\n', ' ') : a.Detail;
        var description = PrivateLine(kind + (excerpt.Length > 0 ? "  ·  " + excerpt : ""), 15, _muted); description.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; copy.AddChild(description);
        row.AddChild(PrivateButton("查看", () => PreviewPrivateAttachment(a), 60));
        if (draft) { var remove = PrivateButton("×", () => { PrivateAttachments.Remove(a); RefreshPrivateAttachments(); }, 36); remove.TooltipText = "移除这条附件"; row.AddChild(remove); }
        return card;
    }
    private void PreviewPrivateAttachment(PrivateOffer a, bool attach = false)
    {
        ShowCareerDialog(attach ? "确认引用" : "引用内容", "", () => { if (attach) AttachPrivate(a); return true; }, attach ? "附到消息" : "关闭", box =>
        {
            int height = Math.Clamp(100 + (a.Detail.Length / 38 + a.Detail.Count(ch => ch == '\n')) * 29, 170, 420);
            var scroll = new ScrollContainer { CustomMinimumSize = new(820, height), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);
            var body = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; body.AddThemeConstantOverride("separation", 18); scroll.AddChild(body);
            body.AddChild(PrivateText(PrivateAttachmentHeading(a), 23, _gold));
            string detail = a.Detail.Contains('\n') ? a.Detail[(a.Detail.IndexOf('\n') + 1)..] : a.Detail;
            body.AddChild(PrivateSelectableText(detail.Length > 0 ? detail : PrivateMessages.AttachmentTitle(a), 19, _ink));
        }, showCancel: attach);
    }
    private void AttachPrivate(PrivateOffer attachment)
    {
        if (PrivateAttachments.Count >= 8) { _privateStatus!.Text = "每条消息最多附加 8 项。"; return; }
        PrivateAttachments.Add(attachment); RefreshPrivateAttachments(); _privateInput?.GrabFocus();
    }
    private void RefreshPrivateAttachments()
    {
        if (_privateAttachments == null || _privateAttachmentScroll == null) return;
        bool follow = _privateScroll != null && _privateScroll.ScrollVertical >= _privateScroll.GetVScrollBar().MaxValue - _privateScroll.Size.Y - 90;
        CareerVisuals.ClearContent(_privateAttachments);
        foreach (var a in PrivateAttachments) _privateAttachments.AddChild(PrivateAttachmentCard(a, true));
        _privateAttachmentScroll.Visible = PrivateAttachments.Count > 0;
        _privateAttachmentScroll.CustomMinimumSize = new(0, PrivateAttachments.Count > 1 ? 146 : 72);
        if (follow) _ = ScrollPrivateToBottom();
    }
    private void PrivateSharePicker(string kind)
    {
        var data = ViewData;
        ShowCareerDialog(kind == "result" ? "选择比赛" : "选择帖子", "", () => true, "关闭", box =>
        {
            var scroll = new ScrollContainer { CustomMinimumSize = new(730, 420), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);
            var list = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; list.AddThemeConstantOverride("separation", 12); scroll.AddChild(list);
            var choices = kind == "result" ? data.Results.AsEnumerable().Reverse().Take(30).Select(r => (Id: r.MatchId, Label: $"第{r.Day}天 · {r.Event} · {r.Outcome}"))
                : CommunityThreads.All(data).OrderByDescending(p => p.Day).Take(50).Select(p => (Id: p.Id, Label: $"第{p.Day}天 · {p.Title}"));
            foreach (var entry in choices)
            {
                var a = new PrivateOffer { Kind = kind, MatchId = entry.Id };
                if (PrivateMessages.PrepareAttachments(data, _privatePerson, [a]) != null) continue;
                var choice = PrivateButton("", () =>
                {
                    _cancelDialog?.Invoke(); PreviewPrivateAttachment(a, true);
                }, 0); choice.SizeFlagsHorizontal = SizeFlags.ExpandFill; choice.CustomMinimumSize = new(0, 104); list.AddChild(choice);
                var margin = new MarginContainer(); choice.AddChild(margin); margin.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
                foreach (var edge in new[] { "left", "right", "top", "bottom" }) margin.AddThemeConstantOverride("margin_" + edge, 14);
                var copy = new VBoxContainer(); copy.AddThemeConstantOverride("separation", 9); margin.AddChild(copy);
                var title = PrivateLine(entry.Label, 18, _ink); title.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; copy.AddChild(title);
                var preview = PrivateLine((a.Detail.Contains('\n') ? a.Detail[(a.Detail.IndexOf('\n') + 1)..] : a.Detail).Replace('\n', ' '), 16, _muted); preview.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; copy.AddChild(preview);
                PrivateIgnoreMouse(margin);
            }
            if (list.GetChildCount() == 0) list.AddChild(Text("暂无可分享的记录", 18, _muted));
        }, showCancel: false);
    }
    private static TextEdit PrivateEditor(string text, int width = 790, int height = 330)
    {
        var input = new TextEdit { Text = text, CustomMinimumSize = new(width, height), WrapMode = TextEdit.LineWrappingMode.Boundary };
        input.AddThemeFontSizeOverride("font_size", 18); input.AddThemeStyleboxOverride("normal", CareerVisuals.Box("101d2a", "3a576b", 10, 16)); return input;
    }
    private void PrivateMessageMenu(PrivateTurn turn, bool player)
    {
        ShowCareerDialog("管理消息", player ? "修改文字不撤销已发生的好感、水平变化与确认事项。" : "编辑只修改文字。重新生成会撤回本条回复的交互，再生成新回复。", () => true, "关闭", box =>
        {
            var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 16); box.AddChild(row);
            row.AddChild(PrivateButton("编辑消息", () => { _cancelDialog?.Invoke(); EditPrivateMessage(turn, player); }, 220));
            row.AddChild(PrivateButton("删除消息", () => { _cancelDialog?.Invoke(); DeletePrivateMessage(turn, player); }, 220));
            if (!player)
            {
                var c = PrivateMessages.Conversation(ViewData, _privatePerson);
                var regenerate = PrivateButton("重新生成", () => { _cancelDialog?.Invoke(); PrivateCommand("dm-regenerate", new() { Entry = turn.Id }); }, 160);
                regenerate.Disabled = turn != c.Turns.LastOrDefault() || turn.Status != "complete" || turn.UserDeleted || turn.RequestKind == "arbitration";
                regenerate.TooltipText = regenerate.Disabled ? "可重新生成最新一条完整回复。" : "撤回本条回复的交互，再生成新的回复与交互。";
                row.AddChild(regenerate);
            }
        }, showCancel: false);
    }
    private void EditPrivateMessage(PrivateTurn turn, bool player)
    {
        TextEdit? input = null;
        ShowCareerDialog("编辑消息", "已有总结需在记忆管理中单独修改。", () =>
        {
            if (string.IsNullOrWhiteSpace(input!.Text)) return false;
            PrivateCommand("dm-edit", new() { Entry = turn.Id, Part = player ? "user" : "reply", Text = input.Text }); return true;
        }, "保存", box => { input = PrivateEditor(player ? turn.User : turn.Reply); box.AddChild(input); });
    }
    private void DeletePrivateMessage(PrivateTurn turn, bool player) => ShowCareerDialog("删除这条消息", "同时删除这条消息的未确认交互。总结及已确认事项保留。", () =>
    { PrivateCommand("dm-delete", new() { Entry = turn.Id, Part = player ? "user" : "reply" }); return true; }, "删除");
    private void PrivateMemory()
    {
        if (_privatePerson.Length == 0) { _privateStatus!.Text = "请先选择一位选手。"; return; }
        var data = ViewData; var c = PrivateMessages.Conversation(data, _privatePerson);
        ShowCareerDialog("聊天记忆", "", () => true, "关闭", box =>
        {
            var heading = new HBoxContainer(); heading.AddThemeConstantOverride("separation", 20); box.AddChild(heading);
            var emblem = new Control { CustomMinimumSize = new(68, 72) }; heading.AddChild(emblem);
            emblem.AddChild(new PrivateOrnament { Kind = "archive", MouseFilter = MouseFilterEnum.Ignore });
            var title = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; title.AddThemeConstantOverride("separation", 10); heading.AddChild(title);
            title.AddChild(PrivateText(CareerEngine.DisplayName(data, _privatePerson), 23, _ink));
            title.AddChild(PrivateText("两类摘要都会保留，用于后续聊天。", 16, _muted));
            heading.AddChild(Avatar(data, _privatePerson, 56, false));
            var tabs = new HBoxContainer(); tabs.AddThemeConstantOverride("separation", 20); box.AddChild(tabs);
            var toolbar = new HBoxContainer(); toolbar.AddThemeConstantOverride("separation", 18); box.AddChild(toolbar);
            var explanation = PrivateText("", 16, _muted); explanation.SizeFlagsHorizontal = SizeFlags.ExpandFill; toolbar.AddChild(explanation);
            string selectedKind = "small";
            var action = PrivateButton("整理聊天", () => { _cancelDialog?.Invoke(); PrivateCommand("dm-summary", new() { Part = selectedKind }); }, 155); toolbar.AddChild(action);
            var scroll = new ScrollContainer { CustomMinimumSize = new(800, 180), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);
            var list = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; list.AddThemeConstantOverride("separation", 18); scroll.AddChild(list);
            Button? shortTab = null, longTab = null;
            void Section(string kind)
            {
                selectedKind = kind; CareerVisuals.ClearContent(list);
                var summaries = kind == "big" ? c.BigSummaries : c.SmallSummaries;
                explanation.Text = kind == "big" ? "将多条较早的聊天摘要整理成一条。" : "提取聊天中的经历、约定与重要细节。";
                action.Text = kind == "big" ? "合并旧摘要" : "整理聊天";
                action.Disabled = c.SummaryStatus.Length > 0 || (kind == "big" ? c.SmallSummaries.Count < 2 : PrivateMessages.Completed(c) == 0);
                foreach (var (tab, selected) in new[] { (shortTab!, kind == "small"), (longTab!, kind == "big") })
                {
                    var style = CareerVisuals.Box(selected ? "263d50" : "122330", selected ? "d9bd7e" : "395064", 2, 16);
                    style.BorderWidthBottom = selected ? 3 : 1; tab.AddThemeStyleboxOverride("normal", style);
                }
                scroll.CustomMinimumSize = new(800, summaries.Count == 0 ? 165 : Math.Min(360, 210 * summaries.Count));
                foreach (var s in summaries.AsEnumerable().Reverse())
                {
                    var card = new PanelContainer(); var style = CareerVisuals.Box("101f2d", "3c5469", 3, 20); style.BorderWidthLeft = 3; card.AddThemeStyleboxOverride("panel", style); list.AddChild(card);
                    var inner = new VBoxContainer(); inner.AddThemeConstantOverride("separation", 16); card.AddChild(inner);
                    var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); inner.AddChild(row);
                    var first = c.Turns.ElementAtOrDefault(s.From); var last = c.Turns.ElementAtOrDefault(s.Through - 1);
                    string dates = first == null || last == null ? "已保存" : first.Day == last.Day
                        ? $"第 {first.Season} 赛季 · 第 {SeasonCalendar.Day(data, first.Day)} 天" : first.Season == last.Season
                        ? $"第 {first.Season} 赛季 · 第 {SeasonCalendar.Day(data, first.Day)}—{SeasonCalendar.Day(data, last.Day)} 天"
                        : $"第 {first.Season} 赛季第 {SeasonCalendar.Day(data, first.Day)} 天—第 {last.Season} 赛季第 {SeasonCalendar.Day(data, last.Day)} 天";
                    var label = PrivateLine(dates, 14, _gold); label.SizeFlagsHorizontal = SizeFlags.ExpandFill; row.AddChild(label);
                    row.AddChild(PrivateButton("编辑", () => { _cancelDialog?.Invoke(); EditPrivateSummary(s, kind); }, 72));
                    row.AddChild(PrivateButton("删除", () =>
                    {
                        _cancelDialog?.Invoke(); ShowCareerDialog("删除这条总结", "后续对话不再使用这条总结，原始聊天记录保留。", () => { PrivateCommand("dm-summary-delete", new() { Entry = s.Id, Part = kind }); return true; }, "删除");
                    }, 72));
                    inner.AddChild(PrivateText(s.Text, 18, _ink));
                }
                if (summaries.Count == 0)
                {
                    var center = new CenterContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 155) }; list.AddChild(center);
                    var empty = new HBoxContainer(); empty.AddThemeConstantOverride("separation", 26); center.AddChild(empty);
                    var icon = new Control { CustomMinimumSize = new(56, 62) }; empty.AddChild(icon); icon.AddChild(new PrivateOrnament { Kind = kind == "big" ? "archive" : "summary", MouseFilter = MouseFilterEnum.Ignore });
                    var words = new VBoxContainer { CustomMinimumSize = new(380, 0), SizeFlagsVertical = SizeFlags.ShrinkCenter }; words.AddThemeConstantOverride("separation", 12); empty.AddChild(words);
                    words.AddChild(PrivateLine(kind == "big" ? "尚无合并摘要" : "尚无聊天摘要", 22, _ink));
                    words.AddChild(PrivateLine(kind == "big" ? "积累多条聊天摘要后，可以合并整理。" : "继续聊天后自动整理，也可以手动整理。", 16, _muted));
                }
            }
            Button MemoryTab(string name, int count, string detail, string kind)
            {
                var button = PrivateButton("", () => Section(kind), 390); button.CustomMinimumSize = new(390, 108); tabs.AddChild(button);
                var inset = new MarginContainer(); button.AddChild(inset); inset.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
                foreach (string edge in new[] { "left", "right", "top", "bottom" }) inset.AddThemeConstantOverride("margin_" + edge, 18);
                var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 15); inset.AddChild(row);
                var icon = new Control { CustomMinimumSize = new(42, 50) }; row.AddChild(icon); icon.AddChild(new PrivateOrnament { Kind = kind == "big" ? "archive" : "summary" });
                var text = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; text.AddThemeConstantOverride("separation", 9); row.AddChild(text);
                text.AddChild(PrivateLine(name, 21, _ink)); text.AddChild(PrivateLine(detail, 14, _muted));
                row.AddChild(PrivateLine(count.ToString("00"), 30, _gold)); PrivateIgnoreMouse(inset); return button;
            }
            shortTab = MemoryTab("聊天摘要", c.SmallSummaries.Count, "来自双方的聊天记录", "small");
            longTab = MemoryTab("合并摘要", c.BigSummaries.Count, "来自多条较早的摘要", "big"); Section("small");
            box.AddChild(new HSeparator { Modulate = new Color("526a7c") });
            var clear = PrivateButton("清空聊天记录", () =>
            {
                _cancelDialog?.Invoke(); ShowCareerDialog("清空当前聊天记录", "删除聊天及其未确认交互。总结、好感和已确认事项保留。", () => { PrivateCommand("dm-clear", new()); return true; }, "清空记录");
            }, 180); clear.AddThemeColorOverride("font_color", new Color("ffb6b6")); clear.Disabled = !c.Turns.Any(t => !(t.UserDeleted && t.ReplyDeleted)); box.AddChild(clear);
        }, showCancel: false);
    }
    private void EditPrivateSummary(PrivateSummary summary, string kind)
    {
        TextEdit? input = null;
        ShowCareerDialog(kind == "big" ? "编辑合并摘要" : "编辑聊天摘要", "", () =>
        {
            if (string.IsNullOrWhiteSpace(input!.Text)) return false;
            PrivateCommand("dm-summary-edit", new() { Entry = summary.Id, Part = kind, Text = input.Text }); return true;
        }, "保存", box => { input = PrivateEditor(summary.Text); box.AddChild(input); });
    }
}

// 私信专用纹饰：金属轮廓、铭牌切角与卷宗图形，与头像框共用金青配色。
public partial class PrivateOrnament : Control
{
    public string Kind { get; set; } = "identity";
    public override void _Ready() { SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect); Resized += QueueRedraw; }
    public override void _Draw()
    {
        Color gold = CareerVisuals.Gold, dim = new("53687a"), teal = CareerVisuals.Teal;
        if (Kind == "archiveWindow")
        {
            foreach (bool right in new[] { false, true })
                foreach (bool bottom in new[] { false, true })
                {
                    // PanelContainer将子控件放在内边距内，纹饰绘制到留出的边缘，避开标题与按钮。
                    Vector2 C(float x, float y) => new(right ? Size.X + 24 - x : x - 24, bottom ? Size.Y + 24 - y : y - 24);
                    DrawColoredPolygon([C(2,22),C(2,2),C(62,2),C(53,7),C(9,7),C(9,18)], gold.Darkened(.4f));
                    DrawPolyline([C(3,21),C(3,3),C(58,3)], gold.Lightened(.25f), 1.5f, true);
                    DrawLine(C(14,12),C(41,12),dim,1,true);
                }
            DrawLine(new(68,-23),new(Size.X-68,-23),new Color("526b7b"),1,true);
            return;
        }
        if (Kind == "identity")
        {
            float y = Size.Y - 1;
            DrawLine(new(0, y), new(Size.X, y), dim, 1, true);
            DrawLine(new(0, y), new(92, y), gold, 2, true);
            DrawColoredPolygon([new(Size.X - 6, y - 4), new(Size.X - 2, y), new(Size.X - 6, y + 4), new(Size.X - 10, y)], gold);
            return;
        }
        var center = Size / 2; float scale = Math.Min(Size.X, Size.Y) / 64;
        Vector2 P(float x, float y) => center + new Vector2(x, y) * scale;
        void Line(float x1, float y1, float x2, float y2, Color c, float width = 1.4f) => DrawLine(P(x1, y1), P(x2, y2), c, width, true);
        if (Kind == "favour")
        {
            Vector2[] rim = [P(0,-26), P(26,-13), P(24,15), P(0,27), P(-24,15), P(-26,-13)];
            Vector2[] inner = [P(0,-22), P(22,-11), P(20,12), P(0,23), P(-20,12), P(-22,-11)];
            for (int i = 0; i < 6; i++)
            {
                int next = (i + 1) % 6;
                Color metal = i is 0 or 5 ? gold.Lightened(.35f) : i is 2 or 3 ? gold.Darkened(.45f) : gold;
                DrawColoredPolygon([rim[i], rim[next], inner[next], inner[i]], metal);
            }
            DrawColoredPolygon(inner, new Color("0b1927"));
            DrawPolyline(inner.Append(inner[0]).ToArray(), new Color("536470"), 1, true);
            DrawColoredPolygon([P(-18,-9),P(0,-19),P(18,-9),P(0,-13)],new Color("243c4c"));
            for (int side = -1; side <= 1; side += 2)
                for (int i = 0; i < 4; i++)
                {
                    float x = side * (26 - i * 3), y = 4 + i * 5;
                    DrawColoredPolygon([P(x,y+4),P(x+side*6,y-4),P(x+side*7,y),P(x,y+6)], i % 2 == 0 ? gold : gold.Darkened(.28f));
                }
            DrawColoredPolygon([P(0,20),P(4,24),P(0,29),P(-4,24)],teal);
        }
        else if (Kind == "bond")
        {
            DrawPolyline([P(-19,-7),P(-6,-20),P(9,-5),P(-4,8),P(-19,-7)],gold,1.8f,true);
            DrawPolyline([P(-8,6),P(5,-7),P(20,8),P(7,21),P(-8,6)],teal,1.8f,true);
            DrawCircle(P(0,0),3*scale,gold);
        }
        else
        {
            if (Kind == "archive") { Line(-14,-27,24,-27,dim); Line(24,-27,24,15,dim); Line(-18,-23,20,-23,gold); Line(20,-23,20,19,gold); }
            var paper = new Rect2(P(-23,-18),new Vector2(39,44)*scale);
            DrawRect(paper,new Color("0e1d2b")); DrawRect(paper,gold,false,1.4f);
            Line(-14,-7,7,-7,teal,2); Line(-14,0,7,0,dim); Line(-14,7,2,7,dim);
            DrawColoredPolygon([P(7,17),P(12,22),P(7,29),P(2,22)],gold);
        }
    }
}
