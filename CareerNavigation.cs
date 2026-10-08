using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private sealed record Location(string Tab, string? Person, string? Post, string WorldSection, string? Competition,
        string ProfileFilter, string CommunityFilter, int PostLimit, int SelectedDay, int Scroll, int ProfileLimit, string ProfileQuery, string LifeSection, int LifeLimit);
    private sealed record TabVisit(Location Location, Location[] History);
    private readonly Stack<Location> _backHistory = new();
    private readonly Dictionary<string, TabVisit> _tabVisits = new();
    private readonly Dictionary<string, CommunityPost> _readPosts = new();
    private Button _backButton = null!;
    private Label _breadcrumb = null!;
    private Location CaptureLocation() => new(_tab, _personId, _postId, _worldSection, _competitionId,
        _profileFilter, _communityFilter, _postLimit, _selectedDay, _scroll.ScrollVertical, _profileLimit, _profileQuery, _lifeSection, _lifeHistoryLimit);
    private void ApplyLocation(Location location)
    {
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
        if (_backHistory.Count > 64)
        {
            var recent = _backHistory.Take(64).Reverse().ToArray(); _backHistory.Clear();
            foreach (var location in recent) _backHistory.Push(location);
        }
        destination(); _scroll.ScrollVertical = 0; Render();
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
        if (_tab == "选手档案" && _personId == id) return;
        Visit(() => { _personId = id; _tab = "选手档案"; });
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
        if (_tab == "赛事与俱乐部" && _worldSection == section && _competitionId == null) return;
        Visit(() => { _tab = "赛事与俱乐部"; _worldSection = section; _competitionId = null; });
    }
    private void OpenCompetition(string id) => Visit(() => { _tab = "赛事与俱乐部"; _worldSection = "赛事总览"; _competitionId = id; });
    private bool CanGoBack => _backHistory.Count > 0 || _tab == "社区" && _postId != null
        || _tab == "选手档案" && _personId != null || _tab == "赛事与俱乐部" && (_competitionId != null || _worldSection == "颁奖盛典");
    private void Back()
    {
        if (ViewData.Failure != null) return;
        if (_confirmReset) { _confirmReset = false; Render(); return; }
        RememberTab();
        if (_backHistory.TryPop(out var previous))
        {
            ApplyLocation(previous); Render(); _ = RestoreScrollAsync(previous.Scroll, _renderVersion);
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
        _backButton.Text = "← 返回" + destination; _backButton.Disabled = !CanGoBack;
        _backButton.TooltipText = CanGoBack ? "返回上一处内容，恢复筛选和阅读位置。快捷键：Esc" : "当前已是栏目入口。";
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
        _backHistory.Clear(); _tabVisits.Clear(); _readPosts.Clear(); _replyDrafts.Clear(); _replyTargets.Clear();
        _newPostTitle = ""; _newPostBody = "";
        _profileLimit = 36; _profileQuery = ""; _lifeSection = "活动与计划"; _lifeHistoryLimit = 8;
        _personId = null; _postId = null; _competitionId = null; _worldSection = "国运榜";
        _ceremonySeason = 0; _ceremonySection = "获奖名单"; _ceremonyRules = false;
        _communityFilter = "全部"; _profileFilter = "国内职业"; _postLimit = 30; _selectedDay = 0; _tab = "首页";
    }
}
