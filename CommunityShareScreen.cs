using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private HBoxContainer DiscussionActions(CareerData data, CommunityPost post, CommunityReply? reply = null)
    {
        string parent = reply?.Id ?? "";
        bool mainPost = reply == null;
        var row = new HBoxContainer
        {
            Name = "DiscussionActions_" + (mainPost ? "Post" : parent),
            SizeFlagsHorizontal = SizeFlags.ExpandFill
        };
        row.AddThemeConstantOverride("separation", 6);
        row.AddChild(DiscussionReplyButton(post, parent, mainPost));
        row.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore });
        var share = new CommunityShareButton
        {
            Name = mainPost ? "SharePost" : "Share_" + parent, MainPost = mainPost,
            TooltipText = mainPost ? "分享帖子至私聊" : "分享这条评论至私聊"
        };
        share.Pressed += () => ShareDiscussion(post.Id, parent);
        row.AddChild(share);
        var report = new CommunityReportButton
        {
            Name = mainPost ? "ReportPost" : "Report_" + parent, MainPost = mainPost,
            Disabled = CommunityThreads.IsHuman(data, reply?.AuthorId ?? post.AuthorId),
            TooltipText = "举报此内容及作者，申请官方仲裁"
        };
        if (report.Disabled) report.TooltipText = "社区举报适用于 NPC 作者的内容";
        report.Pressed += () => ReportDiscussion(post.Id, parent);
        row.AddChild(report);
        return row;
    }

    private void ShareDiscussion(string postId, string replyId)
    {
        if (_dialogOverlay != null) return;
        var data = ViewData;
        PrivateOffer preview;
        try { preview = CommunitySharing.Create(data, postId, replyId); }
        catch (Exception e) { Notice(e.Message, true); return; }
        var quote = preview.Quote!;
        var people = CommunitySharing.Recipients(data, quote.AuthorId);
        string selected = "";
        Button? confirm = null;
        Label? status = null;
        ShowCareerDialog("分享至私聊", "", () =>
        {
            try
            {
                var current = ViewData;
                if (selected.Length == 0) return false;
                if (current.Failure != null) throw new InvalidOperationException("请先处理当前比赛结果。");
                if (!PrivateMessages.CanChat(current, selected)) throw new InvalidOperationException("这位人物已无法接收私信，请重新选择。");
                if (_privateAttachmentDrafts.TryGetValue(selected, out var drafts) && drafts.Count >= 8)
                    throw new InvalidOperationException("这段私聊已有 8 项待发附件，请先发送或移除附件。");
                var attachment = CommunitySharing.Create(current, postId, replyId);
                _cancelDialog?.Invoke();
                OpenPrivateMessages(selected);
                AttachPrivate(attachment);
                return true;
            }
            catch (Exception e)
            {
                if (_dialogOverlay != null && IsInstanceValid(status)) { status!.Text = e.Message; status.TooltipText = e.Message; status.Show(); }
                else Notice(e.Message, true);
                return false;
            }
        }, "进入私聊", contents =>
        {
            var source = Text("来源帖子 · " + quote.PostTitle, 16, _muted);
            source.AutowrapMode = TextServer.AutowrapMode.Off;
            source.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis;
            source.TooltipText = quote.PostTitle; source.MouseFilter = MouseFilterEnum.Pass;
            contents.AddChild(source);
            var search = new LineEdit
            {
                Name = "SharePersonSearch", PlaceholderText = "搜索名称", CustomMinimumSize = new(0, 42),
                SizeFlagsHorizontal = SizeFlags.ExpandFill
            };
            contents.AddChild(search);
            var filter = new OptionButton
            {
                Name = "SharePersonFilter", CustomMinimumSize = new(0, 42),
                SizeFlagsHorizontal = SizeFlags.ExpandFill
            };
            foreach (string label in new[] { "全部", "内容作者", "近期私聊", "同俱乐部" }) filter.AddItem(label);
            contents.AddChild(filter);
            var recent = CommunitySharing.RecentRecipients(data);
            var scroll = new ScrollContainer
            {
                Name = "SharePersonScroll", CustomMinimumSize = new(0, 216),
                SizeFlagsHorizontal = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled
            };
            contents.AddChild(scroll);
            var list = new Control { Name = "SharePersonList", SizeFlagsHorizontal = SizeFlags.ExpandFill };
            scroll.AddChild(list);
            status = Text("", 16, CareerVisuals.Teal); status.Hide();
            status.Name = "SharePersonStatus";
            status.AutowrapMode = TextServer.AutowrapMode.Off;
            status.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis;
            status.MouseFilter = MouseFilterEnum.Pass;
            contents.AddChild(status);
            CareerPerson[] visible = [];
            var rows = new List<(HBoxContainer Row, Button Choice)>();
            const int rowHeight = 64;
            void ShowRows()
            {
                int first = Math.Clamp(scroll.ScrollVertical / rowHeight, 0, Math.Max(0, visible.Length - 1));
                int count = Math.Min(visible.Length - first, (int)Math.Ceiling(Math.Max(216, scroll.Size.Y) / rowHeight) + 1);
                while (rows.Count < count)
                {
                    var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); list.AddChild(row);
                    var choice = PrivateButton("", () => { });
                    choice.ToggleMode = true; choice.Alignment = HorizontalAlignment.Left;
                    choice.SizeFlagsHorizontal = SizeFlags.ExpandFill;
                    choice.CustomMinimumSize = new(0, rowHeight - 8);
                    choice.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis;
                    choice.AddThemeFontSizeOverride("font_size", 20);
                    choice.AddThemeStyleboxOverride("normal", CareerVisuals.Box("1d303f", "385566", 8, 12));
                    choice.AddThemeStyleboxOverride("pressed", CareerVisuals.Box("273d50", "70d4bc", 8, 12));
                    choice.AddThemeStyleboxOverride("hover_pressed", CareerVisuals.Box("304d5c", "70d4bc", 8, 12));
                    row.AddChild(choice); rows.Add((row, choice));
                    choice.Pressed += () =>
                    {
                        selected = choice.GetMeta("person").AsString();
                        status.Text = ""; status.TooltipText = ""; status.Hide();
                        if (confirm != null) confirm.Disabled = false;
                        foreach (var entry in rows) entry.Choice.SetPressedNoSignal(entry.Choice.GetMeta("person", "").AsString() == selected);
                    };
                }
                for (int i = 0; i < rows.Count; i++)
                {
                    var (row, choice) = rows[i]; row.Visible = i < count; if (i >= count) continue;
                    var person = visible[first + i];
                    if (choice.GetMeta("person", "").AsString() != person.Id)
                    {
                        foreach (var old in row.GetChildren().OfType<Control>().Where(c => c != choice).ToArray())
                        { row.RemoveChild(old); old.QueueFree(); }
                        var avatar = Avatar(data, person.Id, 36, false); avatar.Name = "ShareAvatar_" + person.Id;
                        row.AddChild(avatar); row.MoveChild(avatar, 0);
                        choice.Name = "SharePerson_" + person.Id;
                        choice.SetMeta("person", person.Id);
                        choice.Text = person.PublicName + " · " + person.Role + (person.Id == quote.AuthorId ? " · 作者" : "");
                        choice.TooltipText = choice.Text;
                    }
                    choice.SetPressedNoSignal(person.Id == selected);
                    row.Position = new(0, (first + i) * rowHeight); row.Size = new(list.Size.X, rowHeight - 8);
                }
            }
            void ShowPeople()
            {
                string query = search.Text.Trim();
                visible = people.Where(p => query.Length == 0 || p.PublicName.Contains(query, StringComparison.OrdinalIgnoreCase)
                    || p.Name.Contains(query, StringComparison.OrdinalIgnoreCase)).Where(p => filter.Selected switch
                    {
                        1 => p.Id == quote.AuthorId, 2 => recent.Contains(p.Id),
                        3 => data.Esports.ClubId.Length > 0 && p.ClubId == data.Esports.ClubId, _ => true
                    }).ToArray();
                list.CustomMinimumSize = new(0, visible.Length * rowHeight); scroll.ScrollVertical = 0; ShowRows();
                status.Text = visible.Length == 0 ? "暂无匹配人物，请调整搜索或筛选。" : "";
                status.TooltipText = status.Text; status.Visible = status.Text.Length > 0;
            }
            search.TextChanged += _ => ShowPeople(); filter.ItemSelected += _ => ShowPeople();
            scroll.GetVScrollBar().ValueChanged += _ => ShowRows(); list.Resized += ShowRows; scroll.Resized += ShowRows;
            ShowPeople();
        });
        if (_dialogOverlay != null && CareerVisuals.FindContent(_dialogOverlay, "CareerDialogConfirm") is Button button)
        {
            confirm = button; confirm.Disabled = true;
            confirm.AddThemeStyleboxOverride("normal", CareerVisuals.Box("d9bd7e", "f0dca7", 8, 12));
            confirm.AddThemeColorOverride("font_color", new Color("172330"));
        }
        if (_dialogOverlay != null && CareerVisuals.FindContent(_dialogOverlay, "CareerDialogPanel") is PanelContainer panel)
            panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("192c3e", "506c81", 12, 18));
    }
}
