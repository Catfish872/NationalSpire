using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private static readonly string[] PostCategories = ["比赛战报","国际赛事","俱乐部动态","人物日常","我的讨论","其他动态"];
    private HashSet<string> _checkedCategories = [];

    private VBoxContainer BuildCommunityToolbar(CareerData data)
    {
        EnsureChatPreferencesLoaded();
        _checkedCategories = ChatPreferences.GetValue(ChatPreferenceKey,"post-categories",PostCategories).AsStringArray()
            .Intersect(PostCategories).ToHashSet();
        var actions = new HBoxContainer { Name = "CommunityToolbar" };
        actions.AddThemeConstantOverride("separation",12); _content.AddChild(actions);
        var feed = new VBoxContainer { Name = "CommunityFeed" };
        feed.AddThemeConstantOverride("separation",18);
        actions.AddChild(FramedAction("发表新帖", () => Visit(() => _postId = ComposePostId),"plus",width:128));
        var briefs = FramedAction("简讯已读", () => {
            int count = CommunityThreads.MarkProgramRead(data); Render();
            Notice($"已将 {count} 篇简讯标为已读。",false);
        },"mail-check",width:128);
        briefs.TooltipText = "将没有玩家发言或 AI 回复的程序简讯标为已读。"; actions.AddChild(briefs);
        var read = FramedAction("全部已读", () => {
            if (_multiplayer != null)
            {
                _multiplayer.Send("read-all", accepted: () => { _multiplayer.Refresh(); _boundData = ViewData; Render(); });
                return;
            }
            CommunityThreads.MarkAllRead(data);
            Render(); Notice("社区更新已全部标为已读。",false);
        },"mail-check",width:128);
        read.TooltipText = "将当前所有社区帖子和双周刊更新标为已读。";
        actions.AddChild(read);
        actions.AddChild(FramedAction("查看公告", () => OpenLifePage("公开消息"),"notice-board",width:128));
        actions.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore });
        var unread = DashboardSwitch("仅看未读", _communityFilter == "未读更新", on => {
            _communityFilter = on ? "未读更新" : "全部"; _postLimit = 30; PopulateCommunityFeed(data,feed);
        },126,42);
        actions.AddChild(unread);
        var filter = new MenuButton { Name = "CommunityCategories", CustomMinimumSize = new(164,42), Flat = false,
            MouseDefaultCursorShape = CursorShape.PointingHand, TooltipText = "筛选社区内容分类" };
        ButtonSurface(filter,"15232f","354b58","28434c","658c91",6);
        filter.AddThemeFontSizeOverride("font_size",17);
        ButtonIcon(filter,"chevron-down",15,trailing:true);
        actions.AddChild(filter);
        var menu = filter.GetPopup();
        menu.HideOnCheckableItemSelection = false;
        menu.AddCheckItem("全部分类",0);
        for (int i = 0; i < PostCategories.Length; i++) menu.AddCheckItem(PostCategories[i],i+1);
        void ShowSelection()
        {
            bool all = _checkedCategories.Count == PostCategories.Length;
            menu.SetItemChecked(0,all);
            for (int i = 0; i < PostCategories.Length; i++) menu.SetItemChecked(i+1,_checkedCategories.Contains(PostCategories[i]));
            filter.Text = all ? "全部分类" : _checkedCategories.Count == 1 ? _checkedCategories.First() : $"分类 · {_checkedCategories.Count}";
        }
        menu.IdPressed += id => {
            if (id == 0) _checkedCategories = _checkedCategories.Count == PostCategories.Length ? [] : PostCategories.ToHashSet();
            else if (id > 0 && id <= PostCategories.Length)
            {
                var name = PostCategories[(int)id-1];
                if (!_checkedCategories.Remove(name)) _checkedCategories.Add(name);
            }
            ChatPreferences.SetValue(ChatPreferenceKey,"post-categories",PostCategories.Where(_checkedCategories.Contains).ToArray());
            WriteChatPreferences(); ShowSelection(); _postLimit = 30; PopulateCommunityFeed(data,feed);
        };
        ShowSelection();
        return feed;
    }

    private void PopulateCommunityFeed(CareerData data,VBoxContainer feed)
    {
        CareerVisuals.ClearContent(feed);
        bool all = _checkedCategories.Count == PostCategories.Length, unread = _communityFilter == "未读更新";
        string localPlayer = GroupChats.Human(data);
        bool IsMe(string id) => id == "player" || id == localPlayer;
        bool Mine(CommunityPost p) => IsMe(p.AuthorId) || p.Replies.Any(r => IsMe(r.AuthorId));
        bool Matches(CommunityPost post)
        {
            if (unread && post.SeenRevision >= post.Revision) return false;
            if (all) return true;
            bool match = post.EventKey.StartsWith("match",StringComparison.Ordinal);
            bool international = post.Category == "国际赛事" || post.Category.Contains("洲际") || post.Category.Contains("世界杯");
            bool club = post.Category is "转会" or "俱乐部";
            bool person = post.Category is "训练日常" or "人物专访" or "人物日常";
            bool mine = Mine(post);
            return match && _checkedCategories.Contains("比赛战报") || international && _checkedCategories.Contains("国际赛事")
                || club && _checkedCategories.Contains("俱乐部动态") || person && _checkedCategories.Contains("人物日常")
                || mine && _checkedCategories.Contains("我的讨论")
                || !(match || international || club || person || mine) && _checkedCategories.Contains("其他动态");
        }
        IEnumerable<CommunityPost> posts = unread ? CommunityThreads.All(data) :
            _checkedCategories.Contains("我的讨论") ? data.Posts.Concat(data.SavedThreads.Where(Mine)).DistinctBy(p => p.Id) : data.Posts;
        var page = posts.Where(Matches).Take(_postLimit+1).ToList();
        foreach (var post in page.Take(_postLimit)) AddPostCard(data,post,feed);
        if (page.Count == 0) feed.AddChild(Text("所选分类暂无动态。",18,_muted));
        if (page.Count > _postLimit) feed.AddChild(Button("显示更早动态",() => { _postLimit += 30; PopulateCommunityFeed(data,feed); },190));
    }
}
