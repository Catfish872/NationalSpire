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

        // 投票：随帖一起发起。勾上后表单就在下面展开，发布后**挂在主帖上**（不额外生成回复）。
        box.AddChild(Button(_pollOpen ? "取消投票" : "添加投票", () =>
        {
            _pollOpen = !_pollOpen;
            if (!_pollOpen) ResetComposedPoll();
            Render();
        }, 140));
        if (_pollOpen) RenderPollForm(box, "随帖发起投票 · 发布后显示在帖子顶部", null);

        var actions = new HBoxContainer(); box.AddChild(actions);
        actions.AddChild(Button("发布帖子", () =>
        {
            try
            {
                // 投票内容随帖一起提交；空串表示不带投票。
                var payload = PollPayload();
                if (MultiplayerCommand("post", title.Text, body.Text, parent: payload,
                    accepted: () => { ResetComposedPoll(); _newPostTitle = _newPostBody = ""; _postId = null; Render(); })) return;
                var post = CommunityThreads.Publish(data, title.Text, body.Text);
                if (payload.Length > 0) { AttachPollToPost(data, post, payload); ResetComposedPoll(); }
                _newPostTitle = ""; _newPostBody = "";
                _postId = post.Id; Render();
                _ = AiService.ProcessInteractionsAsync([post.Id]);
            }
            catch (Exception e) { Notice(e.Message, true); }
        }, 160));
        actions.AddChild(Button("返回社区", Back, 160));
    }

    // ---------- 玩家发起投票（挂在回复上）----------
    //
    // 玩家给出问题与选项，让社区去表态。投票者仍是模拟人物，玩家只出题。
    //
    // 投票挂在**一条回复**上：点「创建」时发出一条正文明的回复，投票随该回复走。
    // 想在一帖里发多个投票就多操作几次 —— 回复流里自然排开，不再有「一帖一投」的限制。

    private bool _pollOpen;
    private string _pollQuestion = "";
    private readonly List<string> _pollOptions = ["", ""];

    /// <summary>
    /// 投票编辑器表单。**两种入口共用**：
    ///   · 发帖时随帖发起（发布后追加一条带投票的回复）
    ///   · 在已有帖子里单独发起（回复栏下方）
    /// 两者的数据形状一样 —— 都是回复级投票，所以不必维护两套。
    /// </summary>
    private void RenderPollForm(VBoxContainer parent, string title, Action? onConfirm)
    {
        var card = Card(); parent.AddChild(card); var inner = Inner(card);
        inner.AddChild(Text(title, 19, CareerVisuals.Teal));

        var question = new LineEdit { Name = "PollQuestion", Text = _pollQuestion,
            PlaceholderText = "例如：这届世界总决赛谁最有机会夺冠", SizeFlagsHorizontal = SizeFlags.ExpandFill };
        question.TextChanged += v => _pollQuestion = v;
        inner.AddChild(question);

        for (int i = 0; i < _pollOptions.Count; i++)
        {
            int index = i;
            var row = new HBoxContainer();
            row.AddThemeConstantOverride("separation", 6);
            var edit = new LineEdit { Text = _pollOptions[i], PlaceholderText = $"选项 {i + 1}",
                SizeFlagsHorizontal = SizeFlags.ExpandFill };
            edit.TextChanged += v => _pollOptions[index] = v;
            row.AddChild(edit);
            if (_pollOptions.Count > 2)
                row.AddChild(Button("删", () => { _pollOptions.RemoveAt(index); Render(); }, 50));
            inner.AddChild(row);
        }

        var row2 = new HBoxContainer(); row2.AddThemeConstantOverride("separation", 6);
        row2.AddChild(Button("加一项", () => { if (_pollOptions.Count < 8) { _pollOptions.Add(""); Render(); } }, 90));
        if (onConfirm != null) row2.AddChild(Button("创建", onConfirm, 90));
        inner.AddChild(row2);
    }

    /// <summary>回复栏下方的投票入口。创建时立刻发一条带投票的回复。</summary>
    private void RenderPollComposer(CareerData data, CommunityPost post, VBoxContainer parent)
    {
        var root = new VBoxContainer { Name = "PollComposer" };
        root.AddChild(Button(_pollOpen ? "取消投票" : "发起投票", () =>
        {
            _pollOpen = !_pollOpen;
            if (!_pollOpen) ResetComposedPoll();
            Render();
        }, 140));

        if (_pollOpen)
            RenderPollForm(root, "发起投票 · 会作为一条回复发出", () => CreateReplyPoll(data, post));

        parent.AddChild(root);
    }

    /// <summary>
    /// 把当前编辑内容打成一个投票 JSON；没填或不合规返回空串。
    /// 联机时交给主机执行，单人时本地直接用。
    /// </summary>
    private string PollPayload()
    {
        if (!_pollOpen) return "";
        var question = _pollQuestion.Trim();
        var options = _pollOptions.Select(o => o.Trim()).Where(o => o.Length > 0).Distinct().ToList();
        if (question.Length == 0 || options.Count < 2) return "";
        return System.Text.Json.JsonSerializer.Serialize(new { question, options });
    }

    /// <summary>
    /// 发出一张投票帖：先发一条回复，再把投票挂到它上面。
    /// 不合规就不发，不产生任何痕迹。
    /// </summary>
    /// <summary>
    /// 发出一张投票帖：先发一条回复，再把投票挂到它上面。
    /// 不合规就不发，不产生任何痕迹。
    ///
    /// 联机时走 `poll-ask` 命令交给主机执行 —— 成员界面拿到的是深拷贝，
    /// 直接改只会写进副本、刷新即丢。
    /// </summary>
    private void CreateReplyPoll(CareerData data, CommunityPost post)
    {
        var payload = PollPayload();
        if (payload.Length == 0) { Notice("请填写问题与至少两个选项。", true); return; }

        if (_multiplayer != null)
        {
            // 联机走命令交给主机执行 —— 成员界面拿到的是深拷贝，直接改只会写进副本
            MultiplayerCommand("poll-ask", post.Id, payload,
                accepted: () => { ResetComposedPoll(); Render(); });
            return;
        }

        try
        {
            AttachPollReply(data, post, payload);
            ResetComposedPoll();
            Render();
        }
        catch (Exception e) { Notice(e.Message, true); }
    }

    /// <summary>
    /// 把投票打成一条带投票的回复（单人路径）。
    ///
    /// **正文就是问题本身** —— 它会进讨论提示词，AI 因此看得到要投什么。
    /// 用于「在已有帖子里单独发起」。
    /// </summary>
    private static void AttachPollReply(CareerData data, CommunityPost post, string payloadJson)
    {
        if (!ParsePollPayload(payloadJson, out var question, out var options)) return;
        var reply = CommunityThreads.Submit(data, post, "", question);
        AddPoll(data, post, reply.Id, question, options);
        // 必须显式保存：Submit 在**之前**就存过一次盘，此刻追加的投票还没落盘，
        // 不补这一句，重进游戏投票就没了。
        CareerStore.Save(data);
        _ = AiService.ProcessInteractionsAsync([reply.Id]);
    }

    /// <summary>
    /// 把投票**挂在主楼**上（随帖发起）。
    ///
    /// 与回复级不同：不额外发回复，票数直接显示在帖子顶部 ——
    /// 玩家发帖时附带的投票，本来就该长在帖子上，而不是多出一条回复。
    /// 注入走 news 路径（`posts[].poll`），与程序自动发起的投票同一条链路。
    /// </summary>
    private static void AttachPollToPost(CareerData data, CommunityPost post, string payloadJson)
    {
        if (!ParsePollPayload(payloadJson, out var question, out var options)) return;
        AddPoll(data, post, "", question, options);
        CareerStore.Save(data);
    }

    /// <summary>解析投票 JSON；不合规返回 false（不产生任何痕迹）。</summary>
    private static bool ParsePollPayload(string payloadJson, out string question, out List<string> options)
    {
        question = ""; options = [];
        if (string.IsNullOrWhiteSpace(payloadJson)) return false;
        try
        {
            using var doc = System.Text.Json.JsonDocument.Parse(payloadJson);
            var root = doc.RootElement;
            question = (root.TryGetProperty("question", out var q) ? q.GetString() : null)?.Trim() ?? "";
            if (root.TryGetProperty("options", out var ops) && ops.ValueKind == System.Text.Json.JsonValueKind.Array)
                foreach (var o in ops.EnumerateArray())
                {
                    var s = (o.GetString() ?? "").Trim();
                    if (s.Length > 0 && !options.Contains(s)) options.Add(s);
                }
        }
        catch { return false; }
        return question.Length > 0 && options.Count >= 2;
    }

    /// <summary>登记一条投票。replyId 为空表示挂在主楼上。</summary>
    private static void AddPoll(CareerData data, CommunityPost post, string replyId,
                                string question, List<string> options)
    {
        data.Polls.Add(new CommunityPoll
        {
            PostId = post.Id,
            ReplyId = replyId,
            Kind = "PlayerAsked",
            Question = question,
            Options = options,
            Votes = options.Select(_ => 0).ToList(),
            // 规模随帖子所属赛事 —— 问题出现在哪个帖子，就触达那批读者
            Scale = PollSchedule.ScaleFor(data, post),
        });
    }

    private void ResetComposedPoll()
    {
        _pollOpen = false; _pollQuestion = ""; _pollOptions.Clear(); _pollOptions.Add(""); _pollOptions.Add("");
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
        RenderPollComposer(data, post, cb);
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
        RenderPoll(data, post, header, preparing);
        RenderWorkStatus(header, post.NewsGeneration, () => GenerateContent(() => { _ = AiService.RetryNewsAsync(post.Id); }, true), "News_" + post.Id);
        if ((CommunityThreads.IsHuman(data, post.AuthorId) || post.PersonalPost) && post.NeedsReaction) RenderWorkStatus(header, post.ReactionGeneration, () => GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([post.Id]); }, true), post.Id);
    }
    /// <summary>帖级投票（程序自动发起）。渲染成帖顶的一张卡片。</summary>
    private void RenderPoll(CareerData data, CommunityPost post, VBoxContainer header, bool preparing)
    {
        var poll = PollSchedule.Of(data, post);
        if (poll == null || !poll.IsValid) return;
        // 帖子还没写完时票数也还没出，等写完了再显示
        if (preparing) return;
        // 已作废的帖在 Of() 里就被视同没有投票，不可达这里（见 PollSchedule.Of 的说明）
        RenderPollCard(poll, header, "PostPoll");
    }

    /// <summary>
    /// 投票卡片的通用渲染。投票者与读者都是 AI，玩家看的是结果，
    /// 所以这里只**展示**：问题、票数占比、社区总结。玩家不参与投票。
    ///
    /// 帖级与回复级共用这一份 —— 只是挂进的容器不同。
    /// </summary>
    private void RenderPollCard(CommunityPoll poll, VBoxContainer parent, string name,
                                bool showQuestion = true)
    {
        var card = Card(); card.Name = name; parent.AddChild(card);
        var box = Inner(card);

        box.AddChild(Text("社区投票", 19, CareerVisuals.Teal));
        // 回复级投票的正文就是问题本身，卡片里再写一遍是重复，故可略去
        if (showQuestion) box.AddChild(Text(poll.Question, 20, _ink));

        int total = poll.Total;

        // 还没出票：AI 尚未生成。不画成「0 票」—— 那会被读成「没人参与」。
        if (total == 0)
        {
            box.AddChild(Text("等待社区表态……", 17, _muted));
            return;
        }

        int max = poll.Votes.Count > 0 ? Math.Max(1, poll.Votes.Max()) : 1;
        for (int i = 0; i < poll.Options.Count; i++)
        {
            var row = new HBoxContainer();
            row.AddThemeConstantOverride("separation", 10);

            var name2 = Text(poll.Options[i], 18, _ink);
            name2.CustomMinimumSize = new Vector2(160, 0);
            row.AddChild(name2);

            var bar = new ProgressBar
            {
                MinValue = 0,
                MaxValue = max,
                Value = poll.Votes[i],
                ShowPercentage = false,
                CustomMinimumSize = new Vector2(240, 18),
                SizeFlagsVertical = Control.SizeFlags.ShrinkCenter,
            };
            row.AddChild(bar);

            int pct = total > 0 ? (int)Math.Round(poll.Votes[i] * 100.0 / total) : 0;
            row.AddChild(Text($"{poll.Votes[i]} 票 · {pct}%", 16, _muted));
            box.AddChild(row);
        }

        box.AddChild(Text($"共 {total} 票", 16, _muted));
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
            // 玩家发起的投票挂在这条回复上，就地展示结果
            var replied = PollSchedule.OfReply(data, reply);
            if (replied is { IsValid: true }) RenderPollCard(replied, box, "ReplyPoll_" + reply.Id, showQuestion: false);
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
