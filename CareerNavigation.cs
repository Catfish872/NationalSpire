using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private sealed record Location(string Tab, string? Person, string? Post, string WorldSection, string? Competition,
        string ProfileFilter, string CommunityFilter, int PostLimit, int SelectedDay, int Scroll, int ProfileLimit, string ProfileQuery, string LifeSection, int LifeLimit,
        string Group = "", int ChatScroll = 0, int ChatPage = 0, string PrivatePerson = "", string Event = "", DashboardLocation? Dashboard = null, ShopLocation? Shop = null, bool ChatOpen = false);
    private sealed record ShopLocation(bool Owned, string Tier, string Category, string Selected, int Page);
    private sealed record DashboardLocation(string Review, string Match, int Month, string Pane, string Plan, string Target, int PlanScroll,
        string Board, string Region, string Scope, string Kind, string International, string OwnerSection, int WeekDay, string FixtureRegion, string ProfileClub, int FixtureSeason);
    private sealed record TabVisit(Location Location, Location[] History);
    private readonly Stack<Location> _backHistory = new();
    private readonly Dictionary<string, TabVisit> _tabVisits = new();
    private readonly Dictionary<string, CommunityPost> _readPosts = new();
    private Button _backButton = null!;
    private Label _breadcrumb = null!;
    private Location CaptureLocation() => new(_tab, _personId, _postId, _worldSection, _competitionId,
        _profileFilter, _communityFilter, _postLimit, _selectedDay, _scroll.ScrollVertical, _profileLimit, _profileQuery, _lifeSection, _lifeHistoryLimit,
        ChatOpen: _privateOverlay != null, Group: _privateGroup, PrivatePerson: _privatePerson,
        ChatScroll: _privateOverlay == null ? 0 : _privateScroll?.ScrollVertical ?? 0, ChatPage: _privateOverlay == null ? 0 : ChatPage,
        Event: _eventView?.Visible == true ? _eventId : "", Dashboard: new(_reviewId,_arenaMatchId,_calendarMonth,_calendarMode,_planKey,
            _planTarget,CurrentPlanScroll(),_board,_rankRegion,_fixtureScope,_fixtureKind,_fixtureInternational,_ownerSection,_weekDay,_fixtureRegion,_profileClubId,_fixtureSeason),
        Shop: _tab == "生涯生活" && _lifeSection == "消费商城" ? new(_shopOwned,_shopTier,_shopCategory,_shopSelected,_shopPage) : null);
    private void ApplyLocation(Location location)
    {
        if (location.Shop is { } shop) (_shopOwned,_shopTier,_shopCategory,_shopSelected,_shopPage) = (shop.Owned,shop.Tier,shop.Category,shop.Selected,shop.Page);
        if (location.Dashboard is { } v)
        {
            (_reviewId,_arenaMatchId,_calendarMonth,_calendarMode,_planKey,_planTarget,_planScroll) = (v.Review,v.Match,v.Month,v.Pane,v.Plan,v.Target,v.PlanScroll);
            _fixtureRegion=v.FixtureRegion; _profileClubId=v.ProfileClub; _fixtureSeason=v.FixtureSeason;
            (_board,_rankRegion,_fixtureScope,_fixtureKind,_fixtureInternational,_ownerSection,_weekDay) = (v.Board,v.Region,v.Scope,v.Kind,v.International,v.OwnerSection,v.WeekDay);
        }
        _tab = location.Tab; _personId = location.Person; _postId = location.Post;
        _worldSection = location.WorldSection; _competitionId = location.Competition;
        _profileFilter = location.ProfileFilter; _communityFilter = location.CommunityFilter;
        _postLimit = location.PostLimit; _selectedDay = location.SelectedDay;
        _profileLimit = location.ProfileLimit; _profileQuery = location.ProfileQuery;
        _lifeSection = location.LifeSection; _lifeHistoryLimit = location.LifeLimit;
    }
    private void RememberTab() => _tabVisits[_tab] = new(CaptureLocation(), _backHistory.ToArray());
    private void Visit(Action destination)
    {
        if (ViewData.Failure != null) return;
        _confirmReset = false;
        RememberTab();
        _backHistory.Push(CaptureLocation());
        if (_privateOverlay != null) ClosePrivateMessagesCore(false);
        if (_backHistory.Count > 64)
        {
            var recent = _backHistory.Take(64).Reverse().ToArray(); _backHistory.Clear();
            foreach (var location in recent) _backHistory.Push(location);
        }
        AcknowledgeReview(ViewData); destination(); _scroll.ScrollVertical = 0; Render();
    }
    private void SwitchTab(string tab)
    {
        if (ViewData.Failure != null) { _tab = "结算"; Render(); return; }
        _confirmReset = false;
        if (tab == _tab) { int position = _scroll.ScrollVertical; Render(); _ = RestoreScrollAsync(position, _renderVersion); return; }
        RememberTab(); _backHistory.Clear();
        int scroll = 0;
        if (_tabVisits.TryGetValue(tab, out var visit))
        {
            ApplyLocation(visit.Location); scroll = visit.Location.Scroll;
            foreach (var previous in visit.History.Reverse()) _backHistory.Push(previous);
        }
        else { _tab = tab; _personId = null; _postId = null; _competitionId = null; _worldSection = "国运榜"; }
        _scroll.ScrollVertical = 0; Render(); _ = RestoreScrollAsync(scroll, _renderVersion);
    }
    private void OpenPerson(string id)
    {
        if (_privateOverlay == null && _tab == "选手档案" && _personId == id) return;
        Visit(() => { _eventView?.Hide(); _personId = id; _tab = "选手档案"; });
    }
    private void OpenPost(CommunityPost post)
    {
        _readPosts[post.Id] = post;
        if (_tab == "社区" && _postId == post.Id) return;
        Visit(() => { _tab = "社区"; _postId = post.Id; });
    }
    private void OpenCommunity() => Visit(() => { _tab = "社区"; _postId = null; });
    private void OpenProfileList(string? filter = null)
    {
        void SelectFilter()
        {
            if (filter != null && filter != _profileFilter) { _profileLimit = 36; _profileQuery = ""; _profileFilter = filter; }
        }
        if (_tab == "选手档案" && _personId == null)
        { SelectFilter(); _scroll.ScrollVertical = 0; Render(); return; }
        Visit(() => { _tab = "选手档案"; _personId = null; SelectFilter(); });
    }
    private void OpenWorldSection(string section)
    {
        if (section is "国运榜" or "国家发展" or "世界荣誉") { OpenLifePage(section); return; }
        if (section == "世界积分") { Visit(() => { _tab = "排行榜"; _board = "世界排名"; }); return; }
        if (_tab == "赛事与俱乐部" && _worldSection == section && _competitionId == null) return;
        Visit(() => { _tab = "赛事与俱乐部"; _worldSection = section; _competitionId = null; });
    }
    private void OpenCompetition(string id) => Visit(() => { _tab = "赛事与俱乐部"; _worldSection = "赛事总览"; _competitionId = id; });
    private bool CanGoBack => _backHistory.Count > 0 || _tab == "社区" && _postId != null
        || _tab == "选手档案" && _personId != null || _tab == "赛事与俱乐部" && (_competitionId != null || _worldSection == "颁奖盛典");
    private void Back()
    {
        if (ViewData.Failure != null) return;
        if (_privateOverlay != null) { ClosePrivateMessages(); return; }
        if (_confirmReset) { _confirmReset = false; Render(); return; }
        RememberTab();
        if (_backHistory.TryPop(out var previous))
        {
            ApplyLocation(previous); Render(); _ = RestoreScrollAsync(previous.Scroll, _renderVersion);
            if (previous.Group.Length > 0) { SelectGroup(previous.Group, previous.ChatPage); _ = RestoreGroupScroll(previous.Group, previous.ChatScroll); }
            else if (previous.PrivatePerson.Length > 0) { OpenPrivateMessages(previous.PrivatePerson, page: previous.ChatPage); _ = ScrollChatTo(previous.ChatScroll); }
            else if (previous.ChatOpen) OpenPrivateMessages();
            else if (previous.Event.Length > 0) OpenRandomEvent(previous.Event);
        }
        else if (_tab == "社区" && _postId != null) { _postId = null; _scroll.ScrollVertical = 0; Render(); }
        else if (_tab == "选手档案" && _personId != null) { _personId = null; _scroll.ScrollVertical = 0; Render(); }
        else if (_tab == "赛事与俱乐部" && _competitionId != null) { _competitionId = null; _scroll.ScrollVertical = 0; Render(); }
        else if (_tab == "赛事与俱乐部" && _worldSection == "颁奖盛典") { _worldSection = "荣誉室"; _scroll.ScrollVertical = 0; Render(); }
        else Close();
    }
    private void UpdateNavigation()
    {
        string destination = "上一级";
        if (_backHistory.TryPeek(out var previous)) destination = previous.Tab switch
        {
            "社区" => previous.Post?.StartsWith("weekly:") == true ? "周刊" : previous.Post != null ? "帖子" : "社区",
            "选手档案" => previous.Person != null ? "人物档案" : "选手名录",
            "赛事与俱乐部" => previous.Competition != null ? "赛事详情" : previous.WorldSection,
            _ => previous.Tab
        };
        else if (_tab == "社区" && _postId != null) destination = "社区";
        else if (_tab == "选手档案" && _personId != null) destination = "选手名录";
        else if (_tab == "赛事与俱乐部" && _competitionId != null) destination = "赛事总览";
        else if (_tab == "赛事与俱乐部" && _worldSection == "颁奖盛典") destination = "荣誉室";
        if (_backHistory.TryPeek(out var chat) && chat.Group.Length > 0) destination = "群聊";
        else if (chat?.PrivatePerson.Length > 0) destination = "私聊";
        else if (chat?.Event.Length > 0) destination = "随机事件";
        _backButton.Disabled = !CanGoBack;
        _backButton.TooltipText = CanGoBack ? "返回" + destination + "（Esc）" : "当前已是栏目入口。";
        string detail = _tab switch
        {
            "社区" when _postId == ComposePostId => "发表新帖",
            "社区" when _postId?.StartsWith("weekly:") == true => "周刊精选",
            "社区" when _postId != null => CommunityThreads.All(ViewData).FirstOrDefault(p => p.Id == _postId)?.Title ?? _readPosts.GetValueOrDefault(_postId)?.Title ?? "帖子已归档",
            "选手档案" when _personId != null => CareerEngine.DisplayName(ViewData, _personId),
            "赛事与俱乐部" => _worldSection == "颁奖盛典" ? "荣誉室  /  颁奖盛典" : _competitionId == null ? _worldSection : ViewData.Esports.Competitions.FirstOrDefault(c => c.Id == _competitionId)?.Name ?? "历史赛事",
            _ => ""
        };
        _breadcrumb.Text = _tab + (detail.Length > 0 ? "  /  " + detail : "");
        _breadcrumb.TooltipText = _breadcrumb.Text;
    }
    private void ResetNavigation()
    {
        _backHistory.Clear(); _tabVisits.Clear(); _readPosts.Clear(); _replyDrafts.Clear(); _replyTargets.Clear(); _collapsedDiscussions.Clear();
        _newPostTitle = ""; _newPostBody = "";
        _profileLimit = 36; _profileQuery = ""; _lifeSection = "活动与计划"; _lifeHistoryLimit = 8;
        _personId = null; _postId = null; _competitionId = null; _worldSection = "国运榜";
        _ceremonySeason = 0; _ceremonySection = "获奖名单"; _ceremonyRules = false;
        _communityFilter = "全部"; _profileFilter = "国内职业"; _postLimit = 30; _selectedDay = 0; _tab = "首页";
    }
}
