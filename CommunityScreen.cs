using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private readonly Dictionary<string, string> _replyTargets = new();
    private readonly Dictionary<string, string> _replyDrafts = new();
    private readonly Dictionary<string, HashSet<string>> _collapsedDiscussions = new();
    private readonly HashSet<string> _expandedPostBackgrounds = [];
    private Button? _updatesButton;
    private string _newPostTitle = "", _newPostBody = "";
    private const string ComposePostId = "compose-new-post";
    private void RenderPostComposer(CareerData data)
    {
        AddHeading("发布帖子", $"{CareerEngine.Name(data)} · {data.Esports.Country}社区");
        var card = Card(); _content.AddChild(card); var box = Inner(card);
        var title = new LineEdit { Name = "CommunityPostTitle", Text = _newPostTitle, PlaceholderText = "帖子标题", SizeFlagsHorizontal = SizeFlags.ExpandFill };
        var body = new TextEdit { Name = "CommunityPostBody", Text = _newPostBody, PlaceholderText = "分享想法，或向社区发起讨论……",
            CustomMinimumSize = new Vector2(0, 250), SizeFlagsHorizontal = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary };
        box.AddChild(title); box.AddChild(body); AddMentionPicker(body, box);
        title.TextChanged += value => _newPostTitle = value; body.TextChanged += () => _newPostBody = body.Text;
        var actions = new HBoxContainer(); box.AddChild(actions);
        actions.AddChild(Button("发布帖子", () =>
        {
            try
            {
                if (MultiplayerCommand("post", title.Text, body.Text, accepted: () => { _newPostTitle = _newPostBody = ""; _postId = null; Render(); })) return;
                var post = CommunityThreads.Publish(data, title.Text, body.Text);
                _newPostTitle = ""; _newPostBody = "";
                _postId = post.Id; Render(); _ = AiService.ProcessInteractionsAsync([post.Id]);
            }
            catch (Exception e) { Notice(e.Message, true); }
        }, 160));
        actions.AddChild(Button("返回社区", Back, 160));
    }
    private void RefreshDiscussion(CareerData data, CommunityPost post)
    {
        RebuildThreadReplies(data, post, () =>
        {
            if (CareerVisuals.FindContent(_content, "ThreadHeader") is VBoxContainer header)
            {
                CareerVisuals.ClearContent(header);
                RenderPostHeader(data, post, header); UpdateNavigation();
            }
            if (CareerVisuals.FindContent(_content, "ThreadDiscussion") is VBoxContainer discussion)
            {
                CareerVisuals.ClearContent(discussion); RenderDiscussion(data, post, discussion);
            }
        });
        CommunityThreads.MarkRead(data, post);
        UpdateCommunityBadge(); _postSignature = Signature(data);
    }
    private void UpdateCommunityBadge()
    {
        if (_updatesButton == null) return;
        int count = CommunityThreads.Unread(_boundData);
        _updatesButton.Text = count > 0 ? $"●  {count} 个帖子有更新" : "社区暂无未读更新";
        _updatesButton.AddThemeColorOverride("font_color", count > 0 ? new Color("f07878") : _muted);
    }
    private void OpenUpdates() => Visit(() => { _tab = "社区"; _postId = null; _communityFilter = "未读更新"; });
    private void RenderThread(CareerData data, CommunityPost post)
    {
        if (!CommunityThreads.All(data).Any(p => p.Id == post.Id)) data.SavedThreads.Add(post);
        CommunityThreads.MarkRead(data, post); UpdateCommunityBadge();
        var header = new VBoxContainer { Name = "ThreadHeader", SizeFlagsHorizontal = SizeFlags.ExpandFill };
        _content.AddChild(header); RenderPostHeader(data, post, header);
        var discussion = new VBoxContainer { Name = "ThreadDiscussion", SizeFlagsHorizontal = SizeFlags.ExpandFill };
        _content.AddChild(discussion); RenderDiscussion(data, post, discussion);
        RenderRootReplyComposer(data, post);
        RenderReplyComposer(data, post);
    }
    private void RenderRootReplyComposer(CareerData data, CommunityPost post)
    {
        bool pending = CommunityThreads.NewsPending(data, post);
        if (CareerVisuals.FindContent(_content, "RootReplyComposer") is Control composer)
        { composer.Visible = !pending; return; }
        if (pending) return;
        _content.AddChild(CreateReplyComposer(data, post, ""));
    }
    private void RenderReplyComposer(CareerData data, CommunityPost post, PanelContainer? retained = null)
    {
        if (CommunityThreads.NewsPending(data, post) || !_replyTargets.TryGetValue(post.Id, out string? parentId)
            || CareerVisuals.FindContent(_content, "ReplyHost_" + parentId) is not VBoxContainer host)
        { retained?.QueueFree(); return; }
        if (retained != null) { host.AddChild(retained); return; }
        host.AddChild(CreateReplyComposer(data, post, parentId));
    }
    private PanelContainer CreateReplyComposer(CareerData data, CommunityPost post, string parentId)
    {
        bool root = parentId.Length == 0;
        var composer = Card(); composer.Name = root ? "RootReplyComposer" : "ThreadReplyComposer"; var cb = Inner(composer);
        var target = post.Replies.FirstOrDefault(r => r.Id == parentId);
        string draftKey = post.Id + ":" + parentId;
        cb.AddChild(Text(target == null ? "回复帖子" : $"回复 {CareerEngine.DisplayName(data, target.AuthorId)}", 18, _gold));
        var editor = new TextEdit { Name = root ? "RootReplyEditor" : "CommunityReplyEditor", Text = _replyDrafts.GetValueOrDefault(draftKey, ""),
            PlaceholderText = "说说你的想法，或继续上面的讨论……", CustomMinimumSize = new Vector2(0, 130),
            SizeFlagsHorizontal = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary };
        cb.AddChild(editor); AddMentionPicker(editor, cb); editor.TextChanged += () => _replyDrafts[draftKey] = editor.Text;
        editor.SetCaretLine(editor.GetLineCount() - 1); editor.SetCaretColumn(editor.GetLine(editor.GetCaretLine()).Length);
        var actions = new HBoxContainer(); cb.AddChild(actions);
        CommunityReplyExpressions.Attach(editor, cb, actions);
        actions.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill });
        var submit = Button("发布回复", () =>
        {
            try
            {
                string submitted = editor.Text;
                _replyDrafts[draftKey] = submitted;
                if (MultiplayerCommand("reply", post.Id, submitted, parent: parentId,
                    accepted: () => CompleteThreadReply(post.Id, parentId, submitted))) return;
                var current = ViewData;
                var thread = CommunityThreads.All(current).FirstOrDefault(p => p.Id == post.Id)
                    ?? throw new InvalidOperationException("帖子已不存在。");
                var sent = CommunityThreads.Submit(current, thread, parentId, submitted);
                CompleteThreadReply(post.Id, parentId, submitted);
                _ = AiService.ProcessInteractionsAsync([sent.Id]);
                Notice("回复已发布。", false);
            }
            catch (Exception e) { Notice(e.Message, true); }
        }, 150); submit.Name = root ? "SubmitRootReply" : "SubmitThreadReply"; submit.Disabled = CommunityThreads.NewsPending(data, post); actions.AddChild(submit);
        if (!root)
        {
            var close = Button("收起", () => CloseThreadReply(post.Id, parentId), 100);
            close.Name = "CloseThreadReply"; close.TooltipText = "收起回复栏，保留草稿"; actions.AddChild(close);
        }
        return composer;
    }
    private void RebuildThreadReplies(CareerData data, CommunityPost post, Action rebuild)
    {
        var composer = CareerVisuals.FindContent(_content, "ThreadReplyComposer") as PanelContainer;
        var editor = composer == null ? null : CareerVisuals.FindContent(composer, "CommunityReplyEditor") as TextEdit;
        var selection = editor?.HasSelection() == true
            ? (Line: editor.GetSelectionOriginLine(), Column: editor.GetSelectionOriginColumn(), CaretLine: editor.GetCaretLine(), CaretColumn: editor.GetCaretColumn())
            : ((int Line, int Column, int CaretLine, int CaretColumn)?)null;
        var focused = GetViewport().GuiGetFocusOwner();
        bool restoreFocus = composer != null && focused != null && composer.IsAncestorOf(focused);
        // 暂时移出将重建的卡片，保留 TextEdit 的光标、选区和撤销历史。
        if (composer != null) composer.GetParent().RemoveChild(composer);
        rebuild(); RenderRootReplyComposer(data, post); RenderReplyComposer(data, post, composer);
        if (restoreFocus && focused != null && IsInstanceValid(focused) && focused.IsInsideTree() && !focused.IsQueuedForDeletion()) focused.GrabFocus();
        if (selection is { } selected && editor != null && IsInstanceValid(editor) && editor.IsInsideTree() && !editor.IsQueuedForDeletion())
            editor.Select(selected.Line, selected.Column, selected.CaretLine, selected.CaretColumn);
    }
    private void CompleteThreadReply(string postId, string parentId, string submitted)
    {
        string key = postId + ":" + parentId;
        if (_replyDrafts.GetValueOrDefault(key, "") == submitted)
        {
            _replyDrafts.Remove(key);
            if (_replyTargets.TryGetValue(postId, out string? active) && active == parentId) _replyTargets.Remove(postId);
            if (parentId.Length == 0 && _postId == postId
                && CareerVisuals.FindContent(_content, "RootReplyEditor") is TextEdit editor) editor.Text = "";
        }
        if (_postId == postId && _tab == "社区" && CommunityThreads.All(ViewData).FirstOrDefault(p => p.Id == postId) is { } post)
        {
            int position = _scroll.ScrollVertical;
            RefreshDiscussion(ViewData, post); _ = RestoreScrollAsync(position, _renderVersion);
        }
    }
    private void CloseThreadReply(string postId, string parentId)
    {
        if (!_replyTargets.TryGetValue(postId, out string? active) || active != parentId) return;
        _replyTargets.Remove(postId); _renderVersion++;
        if (_scroll is BroadcastScroll scrolling) scrolling.StopMotion();
        RetireReplyComposer();
        string buttonName = parentId.Length == 0 ? "ReplyToPost" : "ReplyTo_" + parentId;
        if (CareerVisuals.FindContent(_content, buttonName) is Button button) button.GrabFocus();
    }
    private void RetireReplyComposer()
    {
        if (CareerVisuals.FindContent(_content, "ThreadReplyComposer") is not Control composer) return;
        composer.Hide(); composer.ProcessMode = ProcessModeEnum.Disabled;
        composer.Name = "Retired_" + composer.GetInstanceId(); composer.QueueFree();
    }
    private void RenderPostHeader(CareerData data, CommunityPost post, VBoxContainer header)
    {
        header.AddChild(MentionText(data, post.Title, 30, _gold, post.RelatedPeople.Append(post.AuthorId)));
        header.AddChild(Text($"第 {post.Day} 天 · {post.Category}", 16, _muted));
        RenderPostBackground(data, post, header);
        string country = CareerEngine.Person(data, post.AuthorId)?.Country ?? data.Esports.Country;
        bool preparing = CommunityThreads.NewsPending(data, post);
        var card = Card();
        var authorMargin = new MarginContainer();
        authorMargin.AddThemeConstantOverride("margin_right", (int)card.GetThemeStylebox("panel").ContentMarginRight);
        header.AddChild(authorMargin);
        var author = new HBoxContainer(); authorMargin.AddChild(author);
        author.AddChild(WithAvatar(data, post.AuthorId, Text($"{CareerEngine.DisplayName(data, post.AuthorId)}  ·  {country}赛区", 19, _muted), 56));
        if (!preparing) author.AddChild(DiscussionVotes(data, post));
        header.AddChild(card); var body = Inner(card); body.Name = "ReplyHost_";
        body.AddChild(MentionText(data, preparing ? "这篇帖子还在撰写中，稍后就能看到。" : post.Body, 19, preparing ? _muted : _ink, post.RelatedPeople.Append(post.AuthorId)));
        if (!preparing) body.AddChild(DiscussionActions(data, post));
        if (post.Analysis.Length > 0) header.AddChild(MentionText(data, post.Analysis, 18, _muted, post.RelatedPeople));
        RenderWorkStatus(header, post.NewsGeneration, () => GenerateContent(() => { _ = AiService.RetryNewsAsync(post.Id); }, true), "News_" + post.Id);
        if ((CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost) && post.NeedsReaction) RenderWorkStatus(header, post.ReactionGeneration, () => GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([post.Id]); }, true), post.Id);
    }
    private void RenderPostBackground(CareerData data, CommunityPost post, VBoxContainer header)
    {
        // 只显示事件发生时保存的公开记录，不用当前状态补写旧事件，也不把玩家正文当作官方事实。
        if (post.AuthorId == "player" || string.IsNullOrWhiteSpace(post.SourceBody)) return;
        string facts = GameText.Plain(post.SourceBody).Trim();
        if (facts.Length == 0) return;
        var card = Card(); card.Name = "PostBackground"; header.AddChild(card);
        var box = Inner(card);
        box.AddChild(Text("事件背景", 19, CareerVisuals.Teal));
        string title = GameText.Plain(post.SourceTitle).Trim();
        if (title.Length > 0 && title != post.Title && title != facts) box.AddChild(Text(title, 18, _ink));
        var elements = new System.Globalization.StringInfo(facts);
        bool lengthy = elements.LengthInTextElements > 240;
        string preview = lengthy ? elements.SubstringByTextElements(0, 240).TrimEnd() + "……" : facts;
        bool expanded = _expandedPostBackgrounds.Contains(post.Id);
        var record = MentionText(data, expanded ? facts : preview, 17, _ink, post.RelatedPeople.Append(post.AuthorId));
        record.Name = "PostBackgroundFacts"; box.AddChild(record);
        if (!lengthy) return;
        var toggle = Button(expanded ? "收起详情" : "展开详情", () => { });
        toggle.Name = "TogglePostBackground";
        toggle.Pressed += () =>
        {
            expanded = !expanded;
            if (expanded) _expandedPostBackgrounds.Add(post.Id); else _expandedPostBackgrounds.Remove(post.Id);
            box.RemoveChild(record); record.QueueFree();
            record = MentionText(data, expanded ? facts : preview, 17, _ink, post.RelatedPeople.Append(post.AuthorId));
            record.Name = "PostBackgroundFacts"; box.AddChild(record); box.MoveChild(record, toggle.GetIndex());
            toggle.Text = expanded ? "收起详情" : "展开详情";
        };
        box.AddChild(toggle);
    }
    private void RenderDiscussion(CareerData data, CommunityPost post, VBoxContainer discussion)
    {
        if (CommunityThreads.NewsPending(data, post)) { discussion.AddChild(Text("大家还在赶来……", 17, _muted)); return; }
        discussion.AddChild(Text($"讨论 · {post.Replies.Count} 条回复", 21, _gold));
        if (!_collapsedDiscussions.TryGetValue(post.Id, out var collapsed))
            _collapsedDiscussions[post.Id] = collapsed = [];
        var items = CommunityDiscussionLayout.Build(post, collapsed);
        var cards = new Dictionary<string, Control>();
        var tree = new CommunityDiscussionLines { Name = "DiscussionTree", SizeFlagsHorizontal = SizeFlags.ExpandFill };
        discussion.AddChild(tree);
        foreach (var item in items.Where(item => item.Visible))
        {
            var reply = item.Reply;
            int inset = CommunityDiscussionLines.Gutter + Math.Min(item.Depth, CommunityDiscussionLines.MaximumIndentDepth) * CommunityDiscussionLines.Indent;
            var row = new HBoxContainer { Name = "Comment_" + reply.Id, SizeFlagsHorizontal = SizeFlags.ExpandFill };
            row.AddThemeConstantOverride("separation", 0); tree.AddChild(row);
            var gutter = new Control { CustomMinimumSize = new Vector2(inset, 0), MouseFilter = MouseFilterEnum.Ignore };
            row.AddChild(gutter);
            var c = Card(); row.AddChild(c); var box = Inner(c); box.Name = "ReplyHost_" + reply.Id; cards[reply.Id] = c;
            if (item.Parent is { } parent && cards.TryGetValue(parent.Reply.Id, out var parentCard)) tree.ConnectReply(parentCard, c);
            bool isCollapsed = collapsed.Contains(reply.Id);
            if (item.Descendants > 0)
            {
                tree.RegisterToggle(c);
                var toggle = new CommunityBranchToggle
                {
                    Name = "ToggleReplies_" + reply.Id, Collapsed = isCollapsed,
                    Position = new Vector2(inset - CommunityDiscussionLines.Gutter / 2f - 14, CommunityDiscussionLines.AnchorY - 14),
                    TooltipText = $"{(isCollapsed ? "展开" : "收起")}这条评论下的 {item.Descendants} 条回复"
                };
                toggle.Pressed += () => ToggleDiscussion(post, reply.Id);
                gutter.AddChild(toggle);
            }
            var head = new HBoxContainer(); box.AddChild(head);
            var speaker = CareerEngine.Person(data, reply.AuthorId);
            string caption = $"{CareerEngine.DisplayName(data, reply.AuthorId)}  ·  {speaker?.Country ?? data.Esports.Country}赛区\n{item.Floor}L" + (item.Depth > 0 ? $" · 楼中楼" : "") + $"  ·  第 {reply.Day} 天";
            head.AddChild(WithAvatar(data, reply.AuthorId, Text(caption, 16, reply.AuthorId == "player" ? _gold : _ink), 42));
            head.AddChild(DiscussionVotes(data, post, reply));
            box.AddChild(MentionText(data, reply.Body, 17, _ink, post.RelatedPeople.Append(post.AuthorId).Append(reply.AuthorId)));
            box.AddChild(DiscussionActions(data, post, reply));
            if (isCollapsed && item.Descendants > 0) box.AddChild(Text($"已收起 {item.Descendants} 条回复", 14, _muted));
            if (reply.NeedsReaction) RenderWorkStatus(box, reply.ReactionGeneration, () => GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([reply.Id]); }, true), reply.Id);
        }
    }
    private HBoxContainer DiscussionVotes(CareerData data, CommunityPost post, CommunityReply? reply = null)
    {
        string replyId = reply?.Id ?? "", suffix = reply?.Id ?? "Post";
        var row = new HBoxContainer { SizeFlagsVertical = SizeFlags.ShrinkCenter };
        row.AddThemeConstantOverride("separation", 4);
        var up = new CommunityVoteButton { Name = "VoteUp_" + suffix, Direction = 1, MainPost = reply == null, ToggleMode = true };
        var down = new CommunityVoteButton { Name = "VoteDown_" + suffix, Direction = -1, MainPost = reply == null, ToggleMode = true };
        var score = Text("", reply == null ? 18 : 16, _ink);
        score.Name = "VoteScore_" + suffix;
        score.AutowrapMode = TextServer.AutowrapMode.Off;
        score.SizeFlagsHorizontal = SizeFlags.ShrinkCenter;
        score.CustomMinimumSize = new Vector2(32, 0);
        score.HorizontalAlignment = HorizontalAlignment.Center;
        score.MouseFilter = MouseFilterEnum.Pass;
        row.AddChild(up); row.AddChild(score); row.AddChild(down);
        void Update(CareerData current, CommunityPost currentPost, CommunityReply? currentReply)
        {
            int choice = currentReply == null ? CommunityVotes.Choice(current, currentPost) : CommunityVotes.Choice(current, currentReply);
            long total = currentReply == null ? CommunityVotes.Score(currentPost) : CommunityVotes.Score(current, currentReply);
            int? basis = currentReply == null ? currentPost.AudienceScore : currentReply.AudienceScore;
            long audience = currentReply == null ? CommunityVotes.AudienceScore(basis) : CommunityVotes.AudienceScore(current, currentReply);
            score.Text = total.ToString();
            score.TooltipText = $"受众净赞数：{audience}"
                + (choice == 1 ? "\n你已点赞（+1）" : choice == -1 ? "\n你已点踩（-1）" : "\n点击赞踩表达态度");
            up.TooltipText = choice == 1 ? "取消点赞" : "点赞";
            down.TooltipText = choice == -1 ? "取消点踩" : "点踩";
            up.SetPressedNoSignal(choice == 1); down.SetPressedNoSignal(choice == -1);
            up.QueueRedraw(); down.QueueRedraw();
        }
        void Vote(int direction)
        {
            try
            {
                var current = ViewData;
                var currentPost = CommunityThreads.All(current).FirstOrDefault(p => p.Id == post.Id)
                    ?? throw new InvalidOperationException("帖子已不存在。");
                var currentReply = replyId.Length == 0 ? null : currentPost.Replies.FirstOrDefault(r => r.Id == replyId)
                    ?? throw new InvalidOperationException("回复的楼层已不存在。");
                int choice = currentReply == null ? CommunityVotes.Choice(current, currentPost) : CommunityVotes.Choice(current, currentReply);
                int next = choice == direction ? 0 : direction;
                if (MultiplayerCommand("community-vote", post.Id, number: next, parent: replyId))
                { Update(current, currentPost, currentReply); return; }
                string before = Signature(current);
                long voteRevision = currentPost.VoteRevision;
                string voter = CommunityVotes.VoterId(current);
                if (CommunityVotes.SetVote(current, post.Id, replyId, next, voter))
                {
                    try { CareerStore.Save(current); }
                    catch
                    {
                        CommunityVotes.SetVote(current, post.Id, replyId, choice, voter);
                        currentPost.VoteRevision = voteRevision;
                        throw;
                    }
                }
                Update(current, currentPost, currentReply);
                // 本地改票只更新当前按钮；已有内容更新仍交由原刷新流程处理。
                if (_postSignature == before) _postSignature = Signature(current);
            }
            catch (Exception e) { Update(data, post, reply); Notice(e.Message, true); }
        }
        up.Pressed += () => Vote(1); down.Pressed += () => Vote(-1);
        Update(data, post, reply);
        return row;
    }
    private Button DiscussionReplyButton(CommunityPost post, string parent, bool mainPost = false)
    {
        var button = new CommunityReplyButton
        {
            Name = parent.Length == 0 ? "ReplyToPost" : "ReplyTo_" + parent,
            MainPost = mainPost, TooltipText = parent.Length == 0 ? "回复帖子" : "回复这条评论"
        };
        button.Pressed += () => BeginReply(post, parent);
        return button;
    }
    private void ToggleDiscussion(CommunityPost post, string replyId)
    {
        if (!_collapsedDiscussions.TryGetValue(post.Id, out var collapsed)) return;
        if (!collapsed.Add(replyId)) collapsed.Remove(replyId);
        if (CareerVisuals.FindContent(_content, "ThreadDiscussion") is not VBoxContainer discussion) return;
        _renderVersion++;
        if (_scroll is BroadcastScroll scrolling) scrolling.StopMotion();
        int position = _scroll.ScrollVertical;
        string toggleName = "ToggleReplies_" + replyId;
        bool restoreFocus = GetViewport().GuiGetFocusOwner()?.Name == toggleName;
        RebuildThreadReplies(ViewData, post, () => { CareerVisuals.ClearContent(discussion); RenderDiscussion(ViewData, post, discussion); });
        if (restoreFocus && CareerVisuals.FindContent(discussion, toggleName) is Button toggle) toggle.GrabFocus();
        _ = RestoreScrollAsync(position, _renderVersion);
    }
    private void BeginReply(CommunityPost post, string parent)
    {
        if (parent.Length == 0)
        {
            if (_scroll is BroadcastScroll rootScroll) rootScroll.StopMotion();
            _renderVersion++;
            _ = FocusComposerAsync("RootReplyEditor");
            return;
        }
        if (_replyTargets.TryGetValue(post.Id, out string? current) && current == parent
            && CareerVisuals.FindContent(_content, "CommunityReplyEditor") != null)
        { CloseThreadReply(post.Id, parent); return; }
        if (_scroll is BroadcastScroll scrolling) scrolling.StopMotion();
        _renderVersion++;
        if (!_replyTargets.TryGetValue(post.Id, out string? active) || active != parent
            || CareerVisuals.FindContent(_content, "CommunityReplyEditor") == null)
        {
            RetireReplyComposer(); _replyTargets[post.Id] = parent; RenderReplyComposer(ViewData, post);
        }
        _ = FocusComposerAsync();
    }
    private void RenderWorkStatus(VBoxContainer box, AiWorkState work, Action retry, string id)
    {
        if (work.State is "idle" or "completed" or "disabled" or "superseded") return;
        string caption = work.State switch { "failed" => "生成失败：" + PlayerFacingText.AiErrorPreview(work.Error), "queued" => work.WaitReason.Length > 0 ? work.WaitReason : "正在准备生成……", "sending" => "正在生成……", _ => "" };
        if (caption.Length == 0) return;
        var row = new HBoxContainer(); box.AddChild(row);
        var label = Text(caption, 14, work.State == "failed" ? new Color("f07878") : _muted); label.SizeFlagsHorizontal = SizeFlags.ExpandFill; row.AddChild(label);
        if (work.State == "failed")
        {
            row.AddChild(Button("错误详情", () =>
            {
                string detail = PlayerFacingText.AiError(work.Error);
                ShowCareerDialog("生成错误详情", "服务商响应或本地异常，凭据已隐藏。", () => true, "关闭", contents =>
                {
                    var editor = new TextEdit { Text = detail, Editable = false, CustomMinimumSize = new Vector2(600, 280), WrapMode = TextEdit.LineWrappingMode.Boundary };
                    editor.AddThemeFontSizeOverride("font_size", 17); contents.AddChild(editor);
                    contents.AddChild(Button("复制错误", () => DisplayServer.ClipboardSet(detail), 150));
                });
            }, 120));
            string scope = id.StartsWith("WeeklyProfiles_") ? "档案" : id.StartsWith("WeeklyNews_") ? "周刊" : id.StartsWith("News_") ? "此帖" : "回应";
            var button = Button("重试" + scope, retry, 120); button.Name = "Retry_" + id; row.AddChild(button);
        }
    }
    private async Task FocusComposerAsync(string editorName = "CommunityReplyEditor")
    {
        if (CareerVisuals.FindContent(_content, editorName) is not TextEdit editor) return;
        int version = _renderVersion;
        var tree = GetTree();
        for (int i = 0; i < 2; i++)
        {
            await ToSignal(tree, SceneTree.SignalName.ProcessFrame);
            if (!IsInstanceValid(this) || !IsInsideTree() || IsQueuedForDeletion() || version != _renderVersion
                || !IsInstanceValid(editor) || editor.IsQueuedForDeletion() || !editor.IsVisibleInTree()) return;
        }
        if (editorName == "RootReplyEditor") _scroll.ScrollVertical = int.MaxValue;
        else _scroll.EnsureControlVisible(editor);
        editor.GrabFocus();
    }
}

public partial class CommunityUpdateButton : Button
{
    private double _elapsed;
    public override void _Process(double delta)
    {
        _elapsed += delta; if (_elapsed < .5) return; _elapsed = 0;
        int count = CommunityThreads.Unread(CareerStore.Data);
        Text = count > 0 ? $"●  社区更新 {count}" : "社区";
        AddThemeColorOverride("font_color", count > 0 ? new Color("f07878") : CareerVisuals.Muted);
    }
}
