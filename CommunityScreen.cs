using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private readonly Dictionary<string, string> _replyTargets = new();
    private readonly Dictionary<string, string> _replyDrafts = new();
    private readonly Dictionary<string, Control> _replyControls = new();
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
        if (CareerVisuals.FindContent(_content, "ThreadHeader") is VBoxContainer header)
        {
            CareerVisuals.ClearContent(header);
            RenderPostHeader(data, post, header); UpdateNavigation();
            if (CareerVisuals.FindContent(_content, "SubmitThreadReply") is Button submit) submit.Disabled = CommunityThreads.NewsPending(data, post);
        }
        if (CareerVisuals.FindContent(_content, "ThreadDiscussion") is not VBoxContainer discussion) return;
        CareerVisuals.ClearContent(discussion);
        RenderDiscussion(data, post, discussion); CommunityThreads.MarkRead(data, post);
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
        var composer = Card(); _content.AddChild(composer); var cb = Inner(composer);
        string parentId = _replyTargets.GetValueOrDefault(post.Id, "");
        var target = post.Replies.FirstOrDefault(r => r.Id == parentId);
        if (target == null) parentId = "";
        string draftKey = post.Id + ":" + parentId;
        cb.AddChild(Text(target == null ? "发表回复" : $"回复 {CareerEngine.DisplayName(data, target.AuthorId)} · {CommunityThreads.Position(post, target).Floor}L", 20, _gold));
        var editor = new TextEdit { Name = "CommunityReplyEditor", Text = _replyDrafts.GetValueOrDefault(draftKey, ""),
            PlaceholderText = "说说你的想法，或继续上面的讨论……", CustomMinimumSize = new Vector2(0, 130),
            SizeFlagsHorizontal = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary };
        cb.AddChild(editor); AddMentionPicker(editor, cb); editor.TextChanged += () => _replyDrafts[draftKey] = editor.Text;
        var actions = new HBoxContainer(); cb.AddChild(actions);
        var submit = Button("发布回复", () =>
        {
            try
            {
                if (MultiplayerCommand("reply", post.Id, editor.Text, parent: parentId, accepted: () => { _replyDrafts.Remove(draftKey); _replyTargets.Remove(post.Id); Render(); })) return;
                var sent = CommunityThreads.Submit(data, post, parentId, editor.Text);
                _replyDrafts.Remove(draftKey); _replyTargets.Remove(post.Id); Render();
                _ = FocusComposerAsync(); _ = AiService.ProcessInteractionsAsync([sent.Id]);
                Notice("回复已发布。", false);
            }
            catch (Exception e) { Notice(e.Message, true); }
        }, 150); submit.Name = "SubmitThreadReply"; submit.Disabled = CommunityThreads.NewsPending(data, post); actions.AddChild(submit);
        if (target != null) actions.AddChild(Button("改为回复帖子", () => BeginReply(post, ""), 180));
    }
    private void RenderPostHeader(CareerData data, CommunityPost post, VBoxContainer header)
    {
        header.AddChild(MentionText(data, post.Title, 30, _gold, post.RelatedPeople.Append(post.AuthorId)));
        header.AddChild(Text($"第 {post.Day} 天 · {post.Category}", 16, _muted));
        RenderPostBackground(data, post, header);
        string country = CareerEngine.Person(data, post.AuthorId)?.Country ?? data.Esports.Country;
        header.AddChild(WithAvatar(data, post.AuthorId, Text($"{CareerEngine.DisplayName(data, post.AuthorId)}  ·  {country}赛区", 19, _muted), 56));
        bool preparing = CommunityThreads.NewsPending(data, post);
        var card = Card(); header.AddChild(card); Inner(card).AddChild(MentionText(data, preparing ? "这篇帖子还在撰写中，稍后就能看到。" : post.Body, 19, preparing ? _muted : _ink, post.RelatedPeople.Append(post.AuthorId)));
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
        _replyControls.Clear();
        foreach (var reply in CommunityThreads.ReadingOrder(post))
        {
            var (floor, depth) = CommunityThreads.Position(post, reply);
            var indent = new MarginContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };
            indent.AddThemeConstantOverride("margin_left", Math.Min(depth, 3) * 20); discussion.AddChild(indent);
            var c = Card(); indent.AddChild(c); var box = Inner(c); _replyControls[reply.Id] = c;
            var head = new HBoxContainer(); box.AddChild(head);
            var speaker = CareerEngine.Person(data, reply.AuthorId);
            string caption = $"{CareerEngine.DisplayName(data, reply.AuthorId)}  ·  {speaker?.Country ?? data.Esports.Country}赛区\n{floor}L" + (depth > 0 ? $" · 楼中楼" : "") + $"  ·  第 {reply.Day} 天";
            head.AddChild(WithAvatar(data, reply.AuthorId, Text(caption, 16, reply.AuthorId == "player" ? _gold : _ink), 42));
            var respond = Button("回复", () => BeginReply(post, reply.Id), 80); respond.Name = "ReplyTo_" + reply.Id; head.AddChild(respond);
            if (reply.ParentId.Length > 0 && post.Replies.FirstOrDefault(r => r.Id == reply.ParentId) is { } parent)
            {
                var above = Button("↳ 回复 " + CareerEngine.DisplayName(data, parent.AuthorId) + " · 查看上文", () =>
                { if (_replyControls.TryGetValue(parent.Id, out var control)) _scroll.EnsureControlVisible(control); });
                above.AutowrapMode = TextServer.AutowrapMode.WordSmart; above.SizeFlagsHorizontal = SizeFlags.ExpandFill; box.AddChild(above);
            }
            box.AddChild(MentionText(data, reply.Body, 17, _ink, post.RelatedPeople.Append(post.AuthorId).Append(reply.AuthorId)));
            if (reply.NeedsReaction) RenderWorkStatus(box, reply.ReactionGeneration, () => GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([reply.Id]); }, true), reply.Id);
        }
    }
    private void BeginReply(CommunityPost post, string parent)
    { _replyTargets[post.Id] = parent; Render(); _ = FocusComposerAsync(); }
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
    private async Task FocusComposerAsync()
    {
        int version = _renderVersion;
        for (int i = 0; i < 2; i++) await ToSignal(GetTree(), SceneTree.SignalName.ProcessFrame);
        if (!IsInstanceValid(this) || !IsInsideTree() || version != _renderVersion) return;
        if (CareerVisuals.FindContent(_content, "CommunityReplyEditor") is TextEdit editor)
        { _scroll.EnsureControlVisible(editor); editor.GrabFocus(); editor.SetCaretColumn(editor.Text.Length); }
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
