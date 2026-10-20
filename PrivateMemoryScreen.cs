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
        inset.AddThemeConstantOverride("margin_bottom", showProfile ? 12 : 20);
        inset.AddThemeConstantOverride("margin_top", showProfile ? 0 : 8);
        var content = new VBoxContainer(); content.AddThemeConstantOverride("separation", 22); inset.AddChild(content);
        var identityInset = new MarginContainer(); content.AddChild(identityInset);
        var identity = new HBoxContainer(); identity.AddThemeConstantOverride("separation", 20); identityInset.AddChild(identity);
        if (showProfile) identity.CustomMinimumSize = new(0, 89);
        void OpenProfile() => OpenPrivatePerson(id);
        var avatar = Avatar(data, id, 72, showProfile, showProfile ? OpenProfile : null);
        if (showProfile) avatar.SizeFlagsVertical = SizeFlags.ShrinkCenter;
        avatar.Name = "PrivateIdentityAvatar"; identity.AddChild(avatar);
        Container name = showProfile ? new PrivateIdentityLayout() : new VBoxContainer();
        name.Name = "PrivateIdentityNameGroup"; name.SizeFlagsHorizontal = SizeFlags.ExpandFill; name.SizeFlagsVertical = SizeFlags.ShrinkCenter;
        name.AddThemeConstantOverride("separation", 9); identity.AddChild(name);
        if (showProfile)
        {
            var profile = PrivateIdentityButton("PrivateIdentityName", OpenProfile);
            profile.Text = person.PublicName; profile.Alignment = HorizontalAlignment.Left;
            profile.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis;
            profile.TooltipText = person.PublicName + " · 查看选手档案";
            profile.SizeFlagsVertical = SizeFlags.Fill;
            profile.AddThemeFontSizeOverride("font_size", 28); name.AddChild(profile);
        }
        else name.AddChild(PrivateText(person.PublicName, 26, _ink));
        double mood = CareerTraining.MoodLevel(person, data.Day);
        var role = PrivateText(person.Role + (ClubCoaching.IsCoach(person) ? " · 俱乐部教练" : "") + "  /  " + person.Country, 14, _muted);
        role.Name = "PrivateIdentityRole";
        if (showProfile)
        {
            role.AutowrapMode = TextServer.AutowrapMode.Off; role.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis;
            role.TooltipText = role.Text;
        }
        name.AddChild(role);
        if (mood != 0)
        {
            int remaining = CareerTraining.MoodUntil(person, data.Day) - data.Day;
            var status = PrivateLine($"{(mood > 0 ? "状态振奋" : "状态低落")} · 剩余 {remaining} 天", 15, mood > 0 ? CareerVisuals.Teal : new Color("ffb6b6"));
            status.Name = "PrivateIdentityMood";
            if (showProfile)
            {
                var moodButton = new PrivateMoodButton { Name = "PrivateMoodButton", Elevated = mood > 0, TooltipText = $"剩余 {remaining} 天" };
                name.AddChild(moodButton);
                var description = new PanelContainer { Name = "PrivateMoodDescription", Visible = false, ZIndex = 1, MouseFilter = MouseFilterEnum.Ignore };
                description.AddThemeStyleboxOverride("panel", CareerVisuals.Box("182838", "00000000", 5, 6));
                moodButton.AddChild(description); description.AddChild(status); PrivateIgnoreMouse(description);
                void PositionDescription() => description.Position = new(moodButton.Size.X + 12, (moodButton.Size.Y - description.GetCombinedMinimumSize().Y) / 2);
                moodButton.Resized += PositionDescription; description.MinimumSizeChanged += PositionDescription;
                moodButton.Pressed += () => { description.Visible = moodButton.ButtonPressed; PositionDescription(); };
            }
            else { status.AutowrapMode = TextServer.AutowrapMode.WordSmart; name.AddChild(status); }
        }
        Control? disclosure = null; Button? bondButton = null, favourButton = null; Label? favourCaption = null;
        bool expanded = !showProfile || ChatPreferences.GetValue(ChatPreferenceKey, "identity:" + id, true).AsBool();
        void ToggleDetails()
        {
            expanded = !expanded;
            disclosure!.Visible = expanded;
            favourCaption!.Visible = expanded;
            bondButton!.SetPressedNoSignal(expanded); favourButton!.SetPressedNoSignal(expanded);
            ChatPreferences.SetValue(ChatPreferenceKey, "identity:" + id, expanded);
            WriteChatPreferences();
        }
        if (showProfile)
        {
            bondButton = PrivateIdentityButton("PrivateRelationshipToggle", ToggleDetails, true);
            bondButton.ToggleMode = true;
            bondButton.SizeFlagsHorizontal = SizeFlags.ShrinkEnd; bondButton.SizeFlagsVertical = SizeFlags.ShrinkCenter;
            string value = relation.Relationship == "初识" ? PrivateMessages.RelationshipLabel(relation.Favour) : relation.Relationship;
            bondButton.TooltipText = value + " · 展开/收起关系与印象";
            var padding = new MarginContainer(); bondButton.AddChild(padding); padding.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
            padding.AddThemeConstantOverride("margin_left", 4); padding.AddThemeConstantOverride("margin_right", 8);
            var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); padding.AddChild(row);
            var icon = new Control { Name = "PrivateRelationshipIcon", CustomMinimumSize = new(36, 48), SizeFlagsVertical = SizeFlags.ShrinkCenter };
            row.AddChild(icon); icon.AddChild(new RelationshipIcon { Bond = RelationshipPresentation.IconBond(relation) });
            var valueLabel = PrivateLine(PrivateRelationshipText(value), 18, _ink); valueLabel.Name = "PrivateRelationshipValue";
            valueLabel.HorizontalAlignment = HorizontalAlignment.Right; valueLabel.VerticalAlignment = VerticalAlignment.Center; row.AddChild(valueLabel);
            padding.MinimumSizeChanged += () => bondButton.CustomMinimumSize = padding.GetCombinedMinimumSize();
            bondButton.CustomMinimumSize = padding.GetCombinedMinimumSize(); PrivateIgnoreMouse(padding); identity.AddChild(bondButton);
        }
        var favour = new VBoxContainer { Name = "FavourMedal", CustomMinimumSize = new(94, 0), TooltipText = "对你的好感 · -100 至 100" };
        favour.AddThemeConstantOverride("separation", 8);
        if (showProfile)
        {
            favourButton = PrivateIdentityButton("PrivateFavourToggle", ToggleDetails, true);
            favourButton.ToggleMode = true; favourButton.CustomMinimumSize = new(94, 78);
            favourButton.SizeFlagsHorizontal = SizeFlags.ShrinkEnd;
            favourButton.TooltipText = "对你的好感 · -100 至 100；展开/收起关系与印象";
            identity.AddChild(favourButton); favourButton.AddChild(favour); favour.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        }
        else identity.AddChild(favour);
        var medal = new Control { Name = "PrivateFavourIcon", CustomMinimumSize = new(94, 78) }; favour.AddChild(medal);
        medal.AddChild(new AffectionBadge { Relation = relation });
        var caption = PrivateLine("好感", 14, _muted); caption.Name = "PrivateFavourCaption"; caption.HorizontalAlignment = HorizontalAlignment.Center;
        if (showProfile)
        {
            favourCaption = caption; favourButton!.AddChild(caption);
            caption.SetAnchorsAndOffsetsPreset(LayoutPreset.BottomWide); caption.OffsetTop = 8; caption.OffsetBottom = 30;
            caption.MouseFilter = MouseFilterEnum.Ignore; caption.Visible = expanded;
            caption.CustomMinimumSize = new(94, 0);
            PrivateIgnoreMouse(favour);
        }
        else favour.AddChild(caption);
        var details = new HBoxContainer { Name = "PrivateIdentityDetails", SizeFlagsHorizontal = SizeFlags.ExpandFill }; details.AddThemeConstantOverride("separation", 24);
        content.AddChild(details);
        if (showProfile)
        {
            details.Visible = expanded; disclosure = details;
            bondButton!.SetPressedNoSignal(details.Visible); favourButton!.SetPressedNoSignal(details.Visible);
        }
        var relationship = new HBoxContainer { CustomMinimumSize = new(225, 0), SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = 1 };
        relationship.AddThemeConstantOverride("separation", 12); details.AddChild(relationship);
        var emblem = new Control { CustomMinimumSize = new(36, 48) }; relationship.AddChild(emblem);
        emblem.AddChild(new RelationshipIcon { Bond = RelationshipPresentation.IconBond(relation) });
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
    private static string PrivateRelationshipText(string value)
    {
        var text = new System.Text.StringBuilder(); int column = 0;
        var elements = System.Globalization.StringInfo.GetTextElementEnumerator(value.Replace("\r\n", "\n"));
        while (elements.MoveNext())
        {
            string element = elements.GetTextElement();
            if (element == "\n") { text.Append('\n'); column = 0; continue; }
            if (column == 15) { text.Append('\n'); column = 0; }
            text.Append(element); column++;
        }
        return text.ToString();
    }
    private static Button PrivateIdentityButton(string name, Action pressed, bool disclosure = false)
    {
        var button = new Button { Name = name, Flat = true, MouseDefaultCursorShape = CursorShape.PointingHand,
            SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsVertical = SizeFlags.ShrinkCenter };
        button.AddThemeStyleboxOverride("normal", new StyleBoxEmpty());
        button.AddThemeStyleboxOverride("hover", new StyleBoxEmpty());
        button.AddThemeStyleboxOverride("pressed", CareerVisuals.Box("ffffff08", "70d4bc", 6, 0));
        button.AddThemeStyleboxOverride("hover_pressed", CareerVisuals.Box("ffffff10", "70d4bc", 6, 0));
        button.AddThemeStyleboxOverride("focus", disclosure ? new StyleBoxEmpty() : CareerVisuals.Box("00000000", "789aa4", 6, 0));
        button.MouseEntered += () => button.Modulate = new Color(1.25f, 1.25f, 1.25f);
        button.MouseExited += () => button.Modulate = Colors.White;
        button.Pressed += pressed; return button;
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
        => AddChatReasoning(turn.Id, text);
    private Action<string> AddChatReasoning(string turn, string text)
    {
        var section = new VBoxContainer { Name = "PrivateReasoning", SizeFlagsHorizontal = SizeFlags.ExpandFill }; section.AddThemeConstantOverride("separation", 10); _privateBody!.AddChild(section);
        section.SetMeta("reasoning_turn", turn);
        PanelContainer? panel = null; RichTextLabel? label = null; Button? button = null;
        void Update(string value)
        {
            text = value; section.Visible = text.Length > 0;
            bool expanded = _privateExpandedReasoning.Contains(turn);
            button!.Text = expanded ? "思考过程 ▾" : "思考过程 ▸";
            if (expanded && panel == null)
            {
                panel = new PanelContainer(); panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("10202d", "41586a", 6, 18)); section.AddChild(panel);
                var scroll = new ScrollContainer { CustomMinimumSize = new(0, 150), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; panel.AddChild(scroll);
                label = PrivateSelectableText(text, 16, _muted); scroll.AddChild(label);
            }
            if (panel != null) panel.Visible = expanded;
            if (expanded && label != null && label.Text != text) label.Text = text;
        }
        button = PrivateButton("", () =>
        {
            if (!_privateExpandedReasoning.Add(turn)) _privateExpandedReasoning.Remove(turn);
            Update(text); _ = FocusPrivateReasoning(turn);
        }, 145);
        section.AddChild(button); Update(text); return Update;
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
    private string PrivateAttachmentHeading(PrivateOffer a) => a.Kind is CommunitySharing.Kind or CommunityReporting.Kind && a.Quote is { } quote
        ? quote.AuthorName + (a.Kind == CommunityReporting.Kind ? " · 被举报内容" : quote.ReplyId.Length == 0 ? " · 帖子" : " · 评论") : a.Kind is "post" or "result"
        ? a.Detail.Split('\n', 2)[0] is { Length: > 0 } title ? title : PrivateMessages.AttachmentTitle(ViewData, a)
        : a.Kind == "lineup" ? "调整阵容" : a.Kind == "training" ? $"训练计划 · {a.Weeks}周" : PrivateMessages.AttachmentTitle(ViewData, a);
    private PanelContainer PrivateAttachmentCard(PrivateOffer a, bool draft)
    {
        var card = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };
        var style = CareerVisuals.Box("203448", "526e84", 6, 10); style.BorderWidthLeft = 3; style.BorderColor = _gold; card.AddThemeStyleboxOverride("panel", style);
        var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); card.AddChild(row);
        var copy = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; copy.AddThemeConstantOverride("separation", 4); row.AddChild(copy);
        var title = PrivateLine(PrivateAttachmentHeading(a), 17, _ink); title.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; title.TooltipText = PrivateAttachmentHeading(a); copy.AddChild(title);
        if (a.Kind is CommunitySharing.Kind or CommunityReporting.Kind && a.Quote is { } quote)
        {
            card.Name = a.Kind == CommunityReporting.Kind ? "CommunityReportCard" : "CommunityQuoteCard";
            title.Name = "QuoteAuthor"; title.MouseFilter = MouseFilterEnum.Pass;
            var body = PrivateText(quote.Body, 16, _ink);
            body.Name = "QuoteBody"; body.MaxLinesVisible = 2;
            body.TooltipText = quote.Body; body.MouseFilter = MouseFilterEnum.Pass;
            copy.AddChild(body);
            var source = PrivateLine("来源帖子 · " + quote.PostTitle, 14, _muted);
            source.Name = "QuoteSource"; source.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis;
            source.TooltipText = quote.PostTitle; source.MouseFilter = MouseFilterEnum.Pass;
            copy.AddChild(source);
        }
        else
        {
            string kind = a.Kind == "post" ? "帖子" : a.Kind == "result" ? "比赛记录" : a.Kind == "match" ? "比赛邀约" : a.Kind == "lineup" ? "阵容调整" : a.Kind == "training" ? "训练内容" : "合同邀约";
            string excerpt = a.Detail.Contains('\n') ? a.Detail[(a.Detail.IndexOf('\n') + 1)..].Replace('\n', ' ') : a.Detail;
            var description = PrivateLine(kind + (excerpt.Length > 0 ? "  ·  " + excerpt : ""), 15, _muted); description.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; copy.AddChild(description);
        }
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
            body.AddChild(PrivateSelectableText(detail.Length > 0 ? detail : PrivateMessages.AttachmentTitle(ViewData, a), 19, _ink));
        }, showCancel: attach);
    }
    private void AttachPrivate(PrivateOffer attachment)
    {
        if (_privateGroup.Length > 0)
        {
            attachment.GroupId = _privateGroup;
            attachment.Id = ((CurrentGroup?.LastInteractionNumber ?? 0) + PrivateAttachments.Count + 1).ToString();
            if (attachment.Participants.Count == 0) attachment.Participants = _groupSelection.ToList();
            if (attachment.Kind == "lineup") attachment.ActorId = _privatePerson;
            PrivateAttachments.Add(attachment); RefreshPrivateAttachments(); return;
        }
        if (PrivateAttachments.Count >= 8) { _privateStatus!.Text = "每条消息最多附加 8 项。"; return; }
        PrivateAttachments.Add(attachment); RefreshPrivateAttachments();
        Callable.From(() => { if (IsInstanceValid(_privateInput) && _privateInput!.IsVisibleInTree()) _privateInput.GrabFocus(); }).CallDeferred();
    }
    private void RefreshPrivateAttachments()
    {
        if (_privateAttachments == null || _privateAttachmentScroll == null) return;
        bool follow = _privateScroll != null && _privateScroll.ScrollVertical >= _privateScroll.GetVScrollBar().MaxValue - _privateScroll.Size.Y - 90;
        CareerVisuals.ClearContent(_privateAttachments);
        foreach (var a in PrivateAttachments) _privateAttachments.AddChild(PrivateAttachmentCard(a, true));
        _privateAttachmentScroll.Visible = PrivateAttachments.Count > 0;
        float height = PrivateAttachments.Count > 1 ? 146
            : PrivateAttachments.Any(a => a.Kind == CommunitySharing.Kind && a.Quote != null) ? 122 : 72;
        if (_privateComposer != null) _privateComposer.SetAttachmentHeight(height);
        else _privateAttachmentScroll.CustomMinimumSize = new(0, height);
        if (follow) _ = ScrollPrivateToBottom();
    }
    private void PrivateSharePicker(string kind)
    {
        var data = ViewData;
        ShowCareerDialog(kind == "result" ? "选择比赛" : "选择帖子", "", () => true, "关闭", box =>
        {
            var scroll = new ScrollContainer { CustomMinimumSize = new(730, 420), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }; box.AddChild(scroll);
            var list = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; list.AddThemeConstantOverride("separation", 12); scroll.AddChild(list);
            var choices = kind == "result" ? data.Results.AsEnumerable().Reverse().Take(30).Select(r => (Id: r.MatchId, Label: $"{GameCalendar.Text(data, r.Day)} · {r.Event} · {r.Outcome}"))
                : CommunityThreads.All(data).OrderByDescending(p => p.Day).Take(50).Select(p => (Id: p.Id, Label: $"{GameCalendar.Text(data, p.Day)} · {p.Title}"));
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
        if (_privateGroup.Length > 0) { GroupMemory(); return; }
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
                    string dates = first == null || last == null ? "已保存" : GameCalendar.Range(data, first.Day, last.Day);
                    var label = PrivateLine(dates, 14, _gold); label.SizeFlagsHorizontal = SizeFlags.ExpandFill; row.AddChild(label);
                    row.AddChild(PrivateButton("编辑", () => OpenChatDialog(() => EditPrivateSummary(s, kind)), 72));
                    row.AddChild(PrivateButton("删除", () =>
                    {
                        string warning = s.IsLatest(c.SmallSummaries.Concat(c.BigSummaries)) ? "" : "删除这条总结可能导致永久丢失记忆。";
                        OpenChatDialog(() => ShowCareerDialog("删除这条总结", warning, () => { PrivateCommand("dm-summary-delete", new() { Entry = s.Id, Part = kind }); return true; }, "确认删除"));
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
                OpenChatDialog(() => ShowCareerDialog("清空当前聊天记录", "删除聊天及其未确认交互。总结、好感和已确认事项保留。", () => { PrivateCommand("dm-clear", new()); return true; }, "清空记录"));
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

/// <summary>头像高72：ID顶端对齐头像，名片居中于ID底端和头像底端之间；状态按钮独立于文字布局。</summary>
public partial class PrivateIdentityLayout : Container
{
    public override Vector2 _GetMinimumSize() => new(80, 72);
    public override void _Notification(int what)
    {
        if (what != NotificationSortChildren || GetChildCount() < 2) return;
        var id = GetChild<Button>(0); var role = GetChild<Label>(1);
        var mood = GetChildren().OfType<PrivateMoodButton>().FirstOrDefault();
        float height = id.GetCombinedMinimumSize().Y, roleHeight = role.GetCombinedMinimumSize().Y;
        float width = Math.Max(0, Size.X - height - 20);
        float textWidth = Math.Min(width, Math.Max(id.GetThemeFont("font").GetStringSize(id.Text, fontSize: id.GetThemeFontSize("font_size")).X,
            role.GetThemeFont("font").GetStringSize(role.Text, fontSize: role.GetThemeFontSize("font_size")).X));
        FitChildInRect(id, new(0, 0, textWidth, height));
        FitChildInRect(role, new(0, (height + Size.Y - roleHeight) / 2, textWidth, roleHeight));
        if (mood != null) FitChildInRect(mood, new(textWidth + 20, (Size.Y - height) / 2, height, height));
    }
}

/// <summary>短期状态的方形矢量按钮，文字说明由父级绑定并按点击展开。</summary>
public partial class PrivateMoodButton : Button
{
    public bool Elevated { get; init; }
    public override void _Ready()
    {
        ToggleMode = true; MouseDefaultCursorShape = CursorShape.PointingHand;
        string fill = Elevated ? "244f3d" : "8c3039", edge = Elevated ? "4f8065" : "c58181";
        foreach (string state in new[] { "normal", "hover", "pressed", "hover_pressed" })
            AddThemeStyleboxOverride(state, CareerVisuals.Box(fill, edge, 5, 0));
        AddThemeStyleboxOverride("focus", new StyleBoxEmpty());
        MouseEntered += () => SelfModulate = new Color(1.3f, 1.3f, 1.3f); MouseExited += () => SelfModulate = Colors.White;
    }
    public override void _Draw()
    {
        float side = Math.Min(Size.X, Size.Y), direction = Elevated ? -1 : 1;
        var center = Size / 2;
        Vector2 Point(float x, float y) => center + new Vector2(x, direction * y) * side;
        DrawColoredPolygon([Point(0, .28f), Point(.26f, .02f), Point(.10f, .02f), Point(.10f, -.26f),
            Point(-.10f, -.26f), Point(-.10f, .02f), Point(-.26f, .02f)], new Color(Elevated ? "98dea6" : "edb8b8"));
    }
}
