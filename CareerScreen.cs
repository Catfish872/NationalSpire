using Godot;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;
using MegaCrit.Sts2.Core.Saves;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;

namespace NationalSpire;

public partial class CareerScreen : Control, IScreenContext
{
    private static CareerScreen? _open;
    public static CareerScreen? Current => _open != null && GodotObject.IsInstanceValid(_open) && !_open.IsQueuedForDeletion() ? _open : null;
    public Control? DefaultFocusedControl => _backButton is { Disabled: false } ? _backButton : _navButtons.GetValueOrDefault(_tab);
    protected readonly Color _gold = CareerVisuals.Gold, _muted = CareerVisuals.Muted, _ink = CareerVisuals.Ink;
    private VBoxContainer _content = null!;
    private Label _status = null!;
    private Label _notice = null!;
    private double _noticeRemaining;
    private Label _pageTitle = null!;
    private Button _seasonDate = null!;
    private Label? _aiStatus;
    private bool _aiSettingsDirty;
    private string _profileFilter = "国内职业";
    private string _profileOrigin = "全部来源";
    private int _profileLimit = 36;
    private string _profileQuery = "";
    private string _communityFilter = "全部";
    private int _postLimit = 30;
    private ScrollContainer _scroll = null!;
    protected Control _stage = null!;
    private readonly Dictionary<string, Button> _navButtons = new();
    private readonly List<(CanvasItem Node, bool Visible)> _hidden = [];
    private string _tab = "首页";
    private int _noticedCeremonySeason;
    private string? _personId, _postId;
    private int _renderVersion;
    private async Task RestoreScrollAsync(int position, int version)
    {
        // 容器需要完成两轮布局，过早设置会被尚未更新的滚动范围归零。
        var tree = GetTree();
        for (int i = 0; i < 2; i++)
        {
            await ToSignal(tree, SceneTree.SignalName.ProcessFrame);
            if (!IsInstanceValid(this) || !IsInsideTree() || IsQueuedForDeletion() || version != _renderVersion) return;
        }
        _scroll.ScrollVertical = position;
    }
    private int _selectedDay;
    private double _refreshClock;
    private readonly record struct DiscussionRevision(int Posts, int Editions, int Count, long ChatOrder);
    private DiscussionRevision _postSignature;
    private readonly HashSet<string> _signaturePostIds = new(StringComparer.Ordinal);
    private CareerData _boundData = null!;
    private bool _starting;
    private bool _confirmReset;
    private string? _latestEvent;

    public override void _Input(InputEvent e)
    {
        if (_stage is { Visible: false })
        {
            GetViewport().SetInputAsHandled();
            if (e is InputEventKey { Pressed: true, Echo: false, Keycode: Key.Escape })
            {
                if (_dialogOverlay != null) _returnDialog?.Invoke();
                else if (Current == this) Close();
            }
            return;
        }
        if (ChatModelPickerOpen) return;
        if (_dialogOverlay != null)
        {
            if (e is InputEventKey { Pressed: true, Echo: false, Keycode: Key.Escape })
            {
                if (GetViewport().GuiGetFocusOwner() is LineEdit { Name: var inputName } && inputName == "CareerSaveNameInput") return;
                GetViewport().SetInputAsHandled(); _returnDialog?.Invoke();
            }
            return;
        }
        if (_closePromptTest != null)
        {
            if (e is InputEventKey { Pressed: true, Echo: false, Keycode: Key.Escape })
            { GetViewport().SetInputAsHandled(); _closePromptTest(); }
            return;
        }
        if (_avatarOverlay != null)
        {
            if (e is InputEventKey { Pressed: true, Echo: false, Keycode: Key.Escape }) { GetViewport().SetInputAsHandled(); _closeAvatar?.Invoke(); }
            return;
        }
        if (_characterCardOverlay != null)
        {
            if (e is InputEventKey { Pressed: true, Echo: false, Keycode: Key.Escape }) { GetViewport().SetInputAsHandled(); _closeCharacterCard?.Invoke(); }
            return;
        }
        if (_eventView?.Visible == true)
        {
            if (e is InputEventKey { Pressed: true, Echo: false, Keycode: Key.Escape }) { GetViewport().SetInputAsHandled(); _eventView.Close?.Invoke(); }
            return;
        }
        if (_promptOverlay != null) return;
        if (_dateMemoryPlayback != null)
        {
            if (e is InputEventKey { Pressed: true, Echo: false, Keycode: Key.Escape }) { GetViewport().SetInputAsHandled(); _dateMemoryPlayback.GoBack(); }
            return;
        }
        if (_dateView != null)
        {
            if (e is InputEventKey { Pressed: true, Echo: false, Keycode: Key.Escape }) { GetViewport().SetInputAsHandled(); DateSceneExitChoices(); }
            return;
        }
        if (_privateOverlay != null)
        {
            if (e is InputEventKey { Pressed: true, Echo: false, Keycode: Key.Escape }) { GetViewport().SetInputAsHandled(); if (_contactMenu != null) CloseContactMenu(); else if (_chatContextMenu != null) CloseChatContextMenu(); else ClosePrivateMessages(); }
            return;
        }
        if (e is InputEventKey { Pressed: true, Echo: false, Keycode: Key.Escape })
        { GetViewport().SetInputAsHandled(); Back(); }
    }
    private long _frameTime;
    public override void _Process(double delta)
    {
        if (_noticeRemaining > 0 && (_noticeRemaining -= delta) <= 0) _notice.Hide();
        UiPerformance.Frame(ref _frameTime, _privateOverlay == null ? _tab : "通讯");
        TickPrivate(delta);
        if (_privateOverlay != null) { if (_multiplayer is { Alive: false }) Close(); return; }
        TickWeekly(delta);
        _refreshClock += delta;
        if (_refreshClock < (_multiplayer != null ? .25 : 1)) return;
        _refreshClock = 0;
        if (_multiplayer != null)
        {
            if (!_multiplayer.Alive) { Close(); return; }
            bool editing = _tab == "模组设置" && _aiSettingsDirty || _characterCardOverlay != null || _dialogOverlay != null || _promptOverlay != null || _avatarOverlay != null || _closePromptTest != null || GetViewport().GuiGetFocusOwner() is LineEdit or TextEdit or SpinBox;
            string? previousResult = _boundData.Results.LastOrDefault()?.MatchId;
            if (!editing && _multiplayer.Refresh())
            {
                var previousDecision = _boundData.Failure?.Result;
                _boundData = ViewData;
                var result = _boundData.Results.LastOrDefault();
                bool settled = result!=null && result.MatchId!=previousResult && _boundData.PendingSettlementId==result.MatchId;
                if (settled) { _tab="结算"; _reviewId=result!.MatchId; }
                else OpenConfirmedTiebreak(_boundData, previousDecision);
                int y = settled ? 0 : _scroll.ScrollVertical;
                Render(); _ = RestoreScrollAsync(y, _renderVersion);
            }
        }
        if (_multiplayer == null && !CareerStore.IsCurrent(_boundData)) { Close(); return; }
        if (_tab == "模组设置" && _aiStatus != null && GodotObject.IsInstanceValid(_aiStatus)) _aiStatus.Text = "当前状态：" + PlayerFacingText.AiStatus(AiService.Status) + $"  ·  今日请求次数 {_boundData.Ai.RequestsToday}";
        UpdateCommunityBadge();
        if (_characterCardOverlay != null || _tab == "模组设置" && _aiSettingsDirty) return;
        if (_tab == "结算") RefreshSettlementDiscussion(_boundData);
        if (_tab == "社区" && _postId == ComposePostId) return;
        if (_tab is "首页" or "社区" or "选手档案" && Signature(_boundData) != _postSignature)
        {
            if (_tab == "社区" && _postId != null && CommunityThreads.All(_boundData).FirstOrDefault(p => p.Id == _postId) is { } thread)
            {
                int position = _scroll.ScrollVertical; RefreshDiscussion(_boundData, thread);
                _ = RestoreScrollAsync(position, _renderVersion); return;
            }
            int y = _scroll.ScrollVertical; Render();
            _ = RestoreScrollAsync(y, _renderVersion);
        }
    }
    public static void Open(NMainMenu menu, string? initialTab = null)
    {
        if (Coop.CoopRuntime.Bound) { Coop.CoopScreen.OpenCareerOrRoom(menu); return; }
        OpenView(menu, null, initialTab);
    }
    public static void OpenView(Control menu, ICareerSession? multiplayer, string? initialTab = null)
        => OpenCareerView(menu, multiplayer, initialTab, "");

    private static void OpenCareerView(Control menu, ICareerSession? multiplayer, string? initialTab, string reviewId)
    {
        if (Current != null) return;
        var screen = DateSceneExtensions.CreateCareerScreen?.Invoke() ?? new CareerScreen();
        screen._tab = initialTab ?? SettlementRecords.InitialTab(multiplayer?.Data ?? CareerStore.Data);
        screen._reviewId = reviewId;
        screen.Name = "NationalSpireCareer"; screen.ZIndex = 100; screen.Theme = DashboardTheme();
        _open = screen; screen._multiplayer = multiplayer; screen._listCache = CareerListCache.For(menu);
        if (multiplayer != null) multiplayer.Message += screen.Notice;
        foreach (var child in menu.GetChildren().OfType<CanvasItem>())
        { screen._hidden.Add((child, child.Visible)); child.Hide(); }
        menu.AddChild(screen);
        screen.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        screen.MouseFilter = MouseFilterEnum.Stop;
        screen._boundData = screen.ViewData;
        screen.Build();
        ActiveScreenContext.Instance.Update();
    }
    private void Close() => Close(false);
    private void Close(bool force)
    {
        if (_starting && !force) return;
        if (IsQueuedForDeletion() || !force && ViewData.Failure != null && _dateRunResume == null) return;
        AcknowledgeReview(ViewData);
        if (_multiplayer != null) { _multiplayer.Message -= Notice; _multiplayer.Dispose(); }
        _open = null;
        foreach (var (node, visible) in _hidden) if (GodotObject.IsInstanceValid(node)) node.Visible = visible;
        _listCache?.Release(); QueueFree(); ActiveScreenContext.Instance.Update();
    }
    public override void _ExitTree()
    {
        CloseDateScene();
        if (_listCache != null && IsInstanceValid(_listCache) && _listCache.IsInsideTree()) _listCache.Release();
        if (_multiplayer != null) { _multiplayer.Message -= Notice; _multiplayer.Dispose(); }
        _pageTween?.Kill(); _weeklyTween?.Kill();
        if (_open == this) _open = null;
    }
    private void Build()
    {
        var background = new BroadcastBackdrop();
        AddChild(background); background.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        _stage = LandscapeViewport.Mount(this);
        BuildDashboardShell();
        Render();
        if (_multiplayer == null && CareerStore.LoadNotice.Length > 0) Notice(CareerStore.LoadNotice, true);
    }

    private void Render()
    {
        using var timing = UiPerformance.Measure(UiPerformance.Work.Render, _tab);
        if (_privateOverlay != null)
        {
            if (ViewData.Failure == null) { UpdateHeaderAccount(ViewData); return; }
            ClosePrivateMessagesCore(false);
        }
        if (ViewData.Failure != null) _tab = "结算";
        if (_tab == "创建角色" && (ViewData.PendingMatchId != null || _multiplayer?.Host == false))
        { _tab = "选手档案"; _personId = null; }
        if (_tab != "结算" && ViewData.PendingCeremonySeason is > 0 and var pending && _noticedCeremonySeason != pending)
        {
            _noticedCeremonySeason = pending;
            _ceremonySeason = pending;
            _tab = "赛事与俱乐部"; _worldSection = "颁奖盛典"; _competitionId = null;
            _ceremonySection = "获奖名单";
            if (_multiplayer == null) { ViewData.PendingCeremonySeason = 0; CareerStore.Save(ViewData); }
            else MultiplayerCommand("ceremony-read", pending.ToString());
        }
        if (_tab != "创建角色" && _characterCardInPage) _closeCharacterCard?.Invoke();
        _scroll.Visible = _tab != "创建角色";
        if (_scroll is BroadcastScroll scrolling) scrolling.StopMotion();
        _renderVersion++;
        _mentionsChecked = false;
        _notice.Hide();
        _listCache?.Release(); CareerVisuals.ClearContent(_content);
        _content.SizeFlagsVertical = SizeFlags.Fill;
        _content.AddThemeConstantOverride("separation", 18);
        _pageTitle.Text = _tab == "首页" ? "生涯大厅" : _tab == "赛事与俱乐部" && _worldSection == "颁奖盛典" ? "颁奖盛典" : _tab;
        // Reserve the gutter while rebuilding. Removing a row must not make a wrapped label
        // alternately gain and lose a line as Godot measures the width around the scrollbar.
        _scroll.VerticalScrollMode = ScrollContainer.ScrollMode.Reserve;
        var main = _scroll.GetParent<Control>();
        main.Size = new(MainWidth + (_tab == "首页" ? _scroll.GetVScrollBar().GetCombinedMinimumSize().X : 0), 840);
        UpdateNavigation(); DashboardHeader(ViewData);
        StyleNavigationRail();
        var data = ViewData;
        if (data.NpcSetupPending && _multiplayer == null && !_npcSetupOpening)
        {
            _npcSetupOpening = true;
            Callable.From(() => { if (IsInstanceValid(this) && !IsQueuedForDeletion()) BeginNpcSetup(true); }).CallDeferred();
        }
        _backButton.Disabled |= data.Failure != null;
        if (data.Failure != null) { Settlement(data); AnimatePage(); return; }

        string? latestEvent = data.Posts.FirstOrDefault()?.Id;
        bool newEvent = _latestEvent != latestEvent;
        _latestEvent = latestEvent;
        _status.AddThemeColorOverride("font_color", _muted);
        _status.Text = $"第 {data.Season} 赛季 · {GameCalendar.Text(data, data.Day)}   评分 {data.Rating}   关注 {data.Fans}   可用资金 {CareerMoney.Compact(CareerMoney.Balance(data))}";
        _status.TooltipText = "可用资金 " + CareerMoney.Format(CareerMoney.Balance(data)); _status.MouseFilter = MouseFilterEnum.Pass;
        if (_multiplayer is { } session) AddSessionStatus(session);
        if (_tab == "结算") _reviewId=ReviewRecord(data)?.MatchId??"";
        switch (_tab)
        {
            case "首页": Home(data); break;
            case "结算": Settlement(data); break;
            case "日程": Calendar(data); break;
            case "赛事": RenderTeam(); Matches(data); break;
            case "赛事与俱乐部": World(data); break;
            case "赛程": FixtureSchedule(data); break;
            case "我的资产": AssetsPage(data); break;
            case "排行榜": RankingPage(data); break;
            case "生涯生活": Life(data); break;
            case "社区": Community(data); break;
            case "选手档案": Profiles(data); break;
            case "创建角色": OpenCharacterCard(data, null); break;
            case "模组设置": AiSettings(data); break;
        }
        AnimatePage();
        UpdateCommunityBadge();
        if (_tab is "首页" or "社区" or "选手档案") _postSignature = Signature(data);
        if (_multiplayer == null && data.Ai.Enabled) ProactiveChats.StartQueued(data);
        if (_multiplayer == null && !data.NpcSetupPending && (newEvent || data.Journey.ResumePublications) && !EventJourney.PublicationsPaused(data) && data.Ai.Enabled && data.Posts.FirstOrDefault()?.AuthorId != "player") _ = AiService.ProcessPendingAsync(data);
        if (_multiplayer == null && !data.NpcSetupPending && !EventJourney.PublicationsPaused(data) && data.Ai.Enabled && data.WeeklyEditions.Any(w => w.ProfilesWork.State == "idle" || w.NewsWork.State == "idle")) _ = AiService.ProcessWeeklyAsync();
        if (!EventJourney.PublicationsPaused(data)) data.Journey.ResumePublications = false;
        if (_tab!="结算")
        {
            ShowJourneyEncounter();
            if (_tab is "首页" or "日程" && !data.NpcSetupPending) ShowDueAppointments();
        }
    }

    private void StyleNavigationRail()
    {
        string activeRail=ActiveRail;
        foreach (var (name, button) in _navButtons)
        {
            button.Disabled = ViewData.Failure != null && name != "结算";
            if (_styledRail==activeRail) continue;
            bool active = name == activeRail;
            string fill = active ? "28434c" : name == "社区" ? "152b38" : "0c1824";
            string edge = active ? "658c91" : name == "社区" ? "365866" : fill;
            ButtonSurface(button,fill,edge,active ? "34545d" : "213945","658c91",0);
            button.AddThemeColorOverride("font_color",active ? _gold : _muted);
            button.AddThemeColorOverride("font_hover_color",active ? _gold : _ink);
            button.AddThemeColorOverride("font_focus_color",_gold);
            button.QueueRedraw();
            button.Size = new(76,name=="社区" ? 88 : name=="模组设置" ? 55 : 78);
        }
        _styledRail=activeRail;
    }

    private DiscussionRevision Signature(CareerData data)
    {
        var posts = new HashCode();
        var editions = new HashCode();
        _signaturePostIds.Clear();
        static void Work(ref HashCode hash, AiWorkState work)
        {
            hash.Add(work.State); hash.Add(work.Error); hash.Add(work.WaitReason);
        }
        void Collect(List<CommunityPost> source)
        {
            foreach (var p in source)
            {
                if (!_signaturePostIds.Add(p.Id)) continue;
                posts.Add(p.Id); posts.Add(p.Revision); posts.Add(p.VoteRevision); posts.Add(p.SeenRevision); posts.Add(p.AiPending);
                Work(ref posts, p.NewsGeneration); Work(ref posts, p.ReactionGeneration);
                foreach (var reply in p.Replies)
                {
                    if (reply.AuthorId != "player") continue;
                    posts.Add(reply.Id); posts.Add(reply.NeedsReaction); Work(ref posts, reply.ReactionGeneration);
                }
            }
        }
        Collect(data.Posts); Collect(data.SavedThreads);
        foreach (var w in data.WeeklyEditions)
        {
            editions.Add(w.Week); editions.Add(w.Revision); editions.Add(w.SeenRevision);
            Work(ref editions, w.ProfilesWork); Work(ref editions, w.NewsWork);
        }
        return new(posts.ToHashCode(), editions.ToHashCode(), _signaturePostIds.Count, _tab == "首页" ? data.Chats.Order : 0);
    }

    private void Home(CareerData data)
    {
        _arenaCharacter=null;
        var agendaItems=Upcoming(data).ToList();
        // 本周日程也列出自动结算的计划。主栏只选有对应玩家操作的事项。
        var next=agendaItems.FirstOrDefault(item => item.Match != null || item.Visit != null || item.Encounter != null);
        string person=string.IsNullOrEmpty(next?.Person) ? "player" : next.Person;
        int day=next?.Day??data.Day;
        var grid = new HBoxContainer(); grid.CustomMinimumSize=new(0,833); grid.AddThemeConstantOverride("separation", HomeColumnGap); _content.AddChild(grid);
        var main=new VBoxContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill}; main.AddThemeConstantOverride("separation",8); grid.AddChild(main);
        var side=new VBoxContainer {CustomMinimumSize=new(HomeSideWidth,0)}; side.AddThemeConstantOverride("separation",24); grid.AddChild(side);
        var hero=FlatPanel(main,"HomeNext",286,"172b3b",24);
        var heroPanel=(PanelContainer)hero.GetParent();
        var heroStyle=CareerVisuals.Box("172b3b","406577",8,24); heroStyle.ContentMarginLeft=31;
        heroPanel.AddThemeStyleboxOverride("panel",heroStyle);
        heroPanel.Draw+=()=>{
            float x=heroPanel.Size.X, y=heroPanel.Size.Y;
            heroPanel.DrawColoredPolygon([new(x-251,1),new(x-2,1),new(x-2,y-2),new(x-350,y-2)],new Color("24495822"));
            heroPanel.DrawRect(new(31,1,72,3),CareerVisuals.Lime);
        };
        var focus = new HBoxContainer(); focus.AddThemeConstantOverride("separation",12); hero.AddChild(focus);
        var words=new VBoxContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill,Alignment=BoxContainer.AlignmentMode.Center}; words.AddThemeConstantOverride("separation",15); focus.AddChild(words);
        words.AddChild(DashboardLabel("下一项安排"+(next==null?"":" · "+(day==data.Day?"今天":GameCalendar.Date(data,day).ToString("M/d"))),15,CareerVisuals.Teal));
        var headline=DashboardLabel(next?.Match is {Event.Length:>0} scheduled ? scheduled.Event : next?.Title??"暂无待处理的安排",38,_ink,true);
        headline.Name="NextTitle"; headline.AddThemeFontOverride("font",CareerVisuals.InterfaceText(tracking:2)); words.AddChild(headline);
        if(next!=null)
        {
            var meta=new HBoxContainer(); meta.AddThemeConstantOverride("separation",13); words.AddChild(meta);
            var tag=new PanelContainer {SizeFlagsVertical=SizeFlags.ShrinkCenter};
            var border=CareerVisuals.Box("172e39","466473",3,0); border.ContentMarginLeft=border.ContentMarginRight=7;
            tag.AddThemeStyleboxOverride("panel",border); meta.AddChild(tag);
            tag.AddChild(DashboardLabel(next.Match!=null?"比赛":next.Visit!=null?"约会":"际遇",14,CareerVisuals.Teal));
            meta.AddChild(DashboardLabel(next.Match is { } m ? $"已报名    进阶 {m.RequiredAscension}" :
                next.Visit!=null ? "已确认" : next.Detail,16,_muted,true));
        }
        var actions=new HBoxContainer();actions.AddThemeConstantOverride("separation",12);words.AddChild(actions);
        if(next!=null)
        {
            string action=next.Match!=null ? day==data.Day?"进入赛场":"前往赛场" : next.Visit!=null?"前往约定":
                next.Encounter!=null && day==data.Day?"查看际遇":"查看安排";
            var enter=FramedAction(action,()=>OpenAgendaItem(data,next),"arrow-right",trailing:true,width:218,height:51,ink:_gold);
            ButtonSurface(enter,"2b4b51","7b9487","385d61","eed39b",6); actions.AddChild(enter);
        }
        actions.AddChild(FramedAction("日程安排",()=>OpenCalendarDay(day),width:112,height:46,quiet:true));
        if (next?.Match is { } nextMatch)
            actions.AddChild(FramedAction("查看赛程", () => OpenMatchFixture(data, nextMatch), width: 112, height: 46, quiet: true));
        var poster=new VBoxContainer {CustomMinimumSize=new(276,0)}; poster.AddThemeConstantOverride("separation",3); focus.AddChild(poster);
        var portrait=CaptionButton("",()=>OpenPerson(person)); portrait.CustomMinimumSize=new(276,192);poster.AddChild(portrait);
        var art=new BroadcastPortrait {Art=AvatarAssets.Load(CareerAvatars.MainCharacter(data,person),person=="player"?CareerAvatars.HomeCardVariation(data):0,true),MouseFilter=MouseFilterEnum.Ignore};
        portrait.AddChild(art); art.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var posterCaption=new HBoxContainer {MouseFilter=MouseFilterEnum.Ignore}; posterCaption.AddThemeConstantOverride("separation",8);
        var displayName=CareerEngine.DisplayName(data,person);
        string role=next?.Match!=null?"对手":next?.Visit!=null?"对象":"选手";
        var roleText=DashboardLabel(role,13,_muted); roleText.SizeFlagsHorizontal=SizeFlags.ShrinkBegin; posterCaption.AddChild(roleText);
        posterCaption.AddChild(DashboardLabel(displayName,18,_ink,true)); var posterArrow=Glyph("arrow-right",16,CareerVisuals.Teal);
        posterArrow.PivotOffset=new(8,8); posterArrow.Rotation=-Mathf.Pi/4; posterCaption.AddChild(posterArrow);
        ActionRow(poster,"HomePosterId",displayName,()=>OpenPerson(person),posterCaption,35,8,1,"00000000","00000000","203744");
        JourneyResumeButton(data,words);
        var links=HomeButtonPair("HomeUtilities");
        foreach (var (label,icon,open) in new (string,string,Action)[]{("排行榜","trophy",()=>GoHub("排行榜")),("选手名录","contact-round",()=>OpenProfileList())})
        {
            var link=FramedAction(label,open,icon,height:50,quiet:true,iconColor:_gold);
            link.SizeFlagsHorizontal=SizeFlags.ExpandFill; link.CustomMinimumSize=new(0,50);links.AddChild(link);
        }
        var week=FlatPanel(side,"HomeWeek",0,"11222e",20); ((Control)week.GetParent()).SizeFlagsVertical=SizeFlags.ExpandFill;
        int start = data.Day - ((int)GameCalendar.Date(data, data.Day).DayOfWeek + 6) % 7;
        var weekHeader = new HBoxContainer();
        week.AddChild(weekHeader);
        var openWeek = TextLink("本周日程", () => GoHub("日程"),20);
        openWeek.AddThemeColorOverride("font_color",_ink);
        openWeek.SizeFlagsHorizontal = SizeFlags.ExpandFill;
        openWeek.Alignment = HorizontalAlignment.Left;
        weekHeader.AddChild(openWeek);
        var weekRange = Text(GameCalendar.Date(data, start).ToString("M/d") + " – " + GameCalendar.Date(data, start + 6).ToString("M/d"), 14, _muted);
        weekRange.AutowrapMode = TextServer.AutowrapMode.Off;
        weekRange.SizeFlagsHorizontal = SizeFlags.ShrinkEnd;
        weekHeader.AddChild(weekRange);
        bool single=_weekDay>=Math.Max(1,start) && _weekDay<start+7;
        var days=new HBoxContainer();days.AddThemeConstantOverride("separation",3);week.AddChild(days);
        for(int i=0;i<7;i++)
        {
            int n=start+i;
            var copy=new VBoxContainer { Alignment=BoxContainer.AlignmentMode.Center }; copy.AddThemeConstantOverride("separation",3);
            var weekday=DashboardLabel("一二三四五六日"[i].ToString(),11,_muted); weekday.HorizontalAlignment=HorizontalAlignment.Center; copy.AddChild(weekday);
            var number=DashboardLabel(GameCalendar.Date(data,n).Day.ToString(),16,n==data.Day?_gold:_ink);
            number.HorizontalAlignment=HorizontalAlignment.Center; copy.AddChild(number);
            bool chosen=single && n==_weekDay;
            var b=ActionRow(days,"Weekday_"+n,number.Text,()=>{_weekDay=n;Render();},copy,56,0,3,
                chosen?"28495a":n==data.Day?"28434c":"00000000","00000000","28434c");
            b.Disabled=n<1;
            if(chosen) b.Draw+=()=>b.DrawLine(new(2,b.Size.Y-2),new(b.Size.X-2,b.Size.Y-2),CareerVisuals.Teal,2);
        }
        var weekScroll=new ScrollContainer {SizeFlagsVertical=SizeFlags.ExpandFill,HorizontalScrollMode=ScrollContainer.ScrollMode.Disabled};week.AddChild(weekScroll);
        var list=new VBoxContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill};weekScroll.AddChild(list);
        var agenda=agendaItems.Where(x=>single?x.Day==_weekDay:x.Day<start+7).ToList();
        list.AddThemeConstantOverride("separation",0);
        foreach(var item in agenda) AgendaEntry(data,list,item);
        if(agenda.Count==0) list.AddChild(Text(single?"当日暂无安排":"本周暂无后续安排",15,_muted));
        side.AddChild(links);
        HomeIdentity(data,side);
        main.AddChild(new Control{CustomMinimumSize=new(0,16)});main.AddChild(Text("最近更新",24,_ink));
        var updates = new HBoxContainer(); updates.SizeFlagsVertical=SizeFlags.ExpandFill;updates.AddThemeConstantOverride("separation",26);main.AddChild(updates);
        VBoxContainer Section(Container parent,string key,string title,string shortcut,Action open,Action<HBoxContainer>? extras=null)
        {
            var body=new VBoxContainer {Name=key,SizeFlagsHorizontal=SizeFlags.ExpandFill};
            body.AddThemeConstantOverride("separation",4);parent.AddChild(body);body.AddChild(Hairline("45616d99"));
            var inset=new MarginContainer(); inset.AddThemeConstantOverride("margin_top",16); body.AddChild(inset);
            var row=new HBoxContainer(); row.AddThemeConstantOverride("separation",12); inset.AddChild(row);
            row.AddChild(Text(title,21,_ink)); extras?.Invoke(row);
            row.AddChild(TextLink(shortcut,open,16,icon:"arrow-up-right")); return body;
        }
        var news=Section(updates,"HomeNews","社区动态","全部",OpenCommunity,
            header=>header.AddChild(TextLink("公开消息",()=>OpenLifePage("公开消息"))));
        news.SizeFlagsStretchRatio=1.08f;
        const int updateRowHeight = 60;
        foreach (var post in data.Posts.Take(3))
        {
            var line=new HBoxContainer {MouseFilter=MouseFilterEnum.Ignore}; line.AddThemeConstantOverride("separation",8);
            var copy=new VBoxContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill,Alignment=BoxContainer.AlignmentMode.Center,MouseFilter=MouseFilterEnum.Ignore};
            copy.AddThemeConstantOverride("separation",2); line.AddChild(copy);
            var postTitle = DashboardLabel(post.Title,16,_ink);
            postTitle.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis;
            copy.AddChild(postTitle);
            copy.AddChild(DashboardLabel(post.Category+" · "+post.Replies.Count+" 条回复",13,_muted));
            line.AddChild(Glyph("chevron-right",14,_muted));
            var open=ActionRow(news,"HomeNewsItem",post.Title,()=>OpenPost(post),line,updateRowHeight,0,5,"00000000","00000000","172c38");
            open.TooltipText=post.Title;
            news.AddChild(Hairline());
        }
        void OpenMarket() => OpenLifePage("交易市场");
        var market=Section(updates,"HomeMarkets","投资与关注","交易市场",OpenMarket);
        var assets=data.Life.Trading.Positions.Select(p=>p.Asset).Concat(MarketTerminal.WatchedAssets(data)).Distinct()
            .Where(id=>MarketCatalog.ById.ContainsKey(id) && data.Market.Quotes.ContainsKey(id)).Take(3).ToArray();
        if (assets.Length==0) HomeInvitation(market,"还没有持仓或关注的资产。","去市场关注或投资",OpenMarket);
        foreach(string id in assets)
        {
            var asset=MarketCatalog.ById[id]; var quote=data.Market.Quotes[id];
            string change=quote.Previous>0?(quote.Price/quote.Previous-1).ToString("+0.00%;-0.00%;0.00%"):"";
            var fields = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore };
            var line = ActionRow(market, "HomeMarket_" + id, asset.Name, () => {
                OpenLifePage("交易市场"); _listCache!.Market.ShowAsset(id);
            }, fields, updateRowHeight, 0, 5, "00000000", "00000000", "172c38");
            line.TooltipText = $"{asset.Name}   {quote.Price:0.####}   {change}";
            var title = DashboardLabel(asset.Name, 16, _ink);
            title.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis;
            title.VerticalAlignment = VerticalAlignment.Center;
            fields.AddChild(title);
            var trend = new Control { CustomMinimumSize = new(90, 26), SizeFlagsVertical = SizeFlags.ShrinkCenter, MouseFilter = MouseFilterEnum.Ignore };
            fields.AddChild(trend);
            decimal[] history = quote.History.TakeLast(24).Select(p => p.Price).ToArray();
            var tint = quote.Price >= quote.Previous ? CareerVisuals.Teal : new Color("ef9295");
            trend.Draw += () =>
            {
                if (history.Length < 2) return;
                decimal low = history.Min(), range = history.Max() - low;
                var points = history.Select((price, i) => new Vector2(i * trend.Size.X / (history.Length - 1),
                    range == 0 ? trend.Size.Y / 2 : trend.Size.Y - 2 - (trend.Size.Y - 4) * (float)((price - low) / range))).ToArray();
                trend.DrawPolyline(points, tint, 1.5f, true);
            };
            var figures = DashboardLabel($"{quote.Price:0.####}\n{change}", 14, tint);
            figures.CustomMinimumSize = new(96, 0); figures.VerticalAlignment = VerticalAlignment.Center;
            figures.SizeFlagsHorizontal = SizeFlags.ShrinkEnd;
            figures.HorizontalAlignment = HorizontalAlignment.Right;
            fields.AddChild(figures);
            market.AddChild(Hairline());
        }
        var recent=Section(main,"HomeContacts","最近联系","私信",()=>OpenPrivateMessages()); recent.CustomMinimumSize=new(0,204);
        var gap = Inset(0,0); gap.AddThemeConstantOverride("margin_top",10);
        gap.SizeFlagsVertical = SizeFlags.ExpandFill; recent.AddChild(gap);
        var strip = new HBoxContainer(); gap.AddChild(strip);
        strip.AddThemeConstantOverride("separation",14);
        EnsureChatPreferencesLoaded(); LoadContactPreferences();
        var mailbox = PrivateMessages.Mailbox(data);
        foreach (var contact in ChatContacts.Recent(data, _contactPreferences.Hidden).Take(3))
        {
            var row = new HBoxContainer(); row.AddThemeConstantOverride("separation",12);
            var copy = new VBoxContainer { Alignment = BoxContainer.AlignmentMode.Center, SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore };
            copy.AddThemeConstantOverride("separation",4);
            var name = DashboardLabel(contact.Name,19,_ink); name.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis;
            copy.AddChild(name);
            if (contact.Group)
            {
                var group = data.Chats.Groups.First(g => g.Id == contact.Id);
                var mosaic = new GroupAvatar { CustomMinimumSize = new(56,56), SizeFlagsVertical = SizeFlags.ShrinkCenter };
                row.AddChild(mosaic); mosaic.Update(data,group);
                copy.AddChild(DashboardLabel($"群聊 · {group.Members.Distinct().Count()} 人",14,_muted));
            }
            else
            {
                var avatar = Avatar(data,contact.Id,56,false); avatar.SizeFlagsVertical = SizeFlags.ShrinkCenter; row.AddChild(avatar);
                var relation = mailbox.Relations.GetValueOrDefault(contact.Id);
                var stats = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }; stats.AddThemeConstantOverride("separation",6); copy.AddChild(stats);
                var status = DashboardLabel((relation?.Relationship ?? "初识") + " · 好感 " + contact.Favour,14,_muted);
                status.SizeFlagsHorizontal = SizeFlags.ShrinkBegin; stats.AddChild(status);
                if (PrivateInteractionHistory.LatestFavourChange(mailbox.Conversations[contact.Id],relation) is int delta && delta != 0)
                {
                    var change = DashboardLabel(delta.ToString("+0;-0;0"),14,delta>0?CareerVisuals.Teal:new Color("ef9295"));
                    change.TooltipText="最近一次好感变动"; stats.AddChild(change);
                }
            }
            row.AddChild(copy);
            ActionRow(strip,(contact.Group ? "GroupContact_" : "Contact_") + contact.Id,contact.Name,
                () => OpenPrivateMessages(contact.Group ? "" : contact.Id,contact.Group ? contact.Id : ""),row,90,14,10,"122432","304a5a","1c3441");
        }
        int contactCount=strip.GetChildCount();
        if(contactCount==0) HomeInvitation(strip,"还没有最近联系人。","找熟悉的人聊聊",ChoosePrivateContact);
        else for(int i=contactCount;i<3;i++) strip.AddChild(new Control {SizeFlagsHorizontal=SizeFlags.ExpandFill,MouseFilter=MouseFilterEnum.Ignore});
        EventCards(data,_content,data.Day);
        if (SeasonCeremony.ShowInvitation(data)) CeremonyInvitation(data);
        ClubInvitation(data);
    }

    private void Metric(HBoxContainer row, string caption, string value, string detail)
    {
        var card = Card(); row.AddChild(card); var box = Inner(card);
        box.AddChild(Text(caption, 15, _muted)); box.AddChild(Text(value, 38, _ink)); box.AddChild(Text(detail, 13, _muted));
    }

    private void ShowArchive()
    {
        if (_multiplayer != null) return;
        var a = PlayerArchive.Read();
        _content.AddChild(Text("游戏总档案 · 含生涯外对局", 24, _gold));
        var metrics = new HBoxContainer(); metrics.AddThemeConstantOverride("separation", 18); _content.AddChild(metrics);
        Metric(metrics, "游戏总通关", a.Wins.ToString(), $"总对局 {a.Wins + a.Losses} · 通关率 {a.WinRate}");
        Metric(metrics, "最佳连胜", a.Streak.ToString(), $"累计攀登 {a.Floors} 层");
        Metric(metrics, "游玩时长", $"{a.Playtime / 3600.0:0.#} h", $"发现 {a.Cards} 张卡牌 · {a.Relics} 件遗物");
        var characters = ProfileSection("角色履历");
        foreach (var c in a.Characters)
        {
            var box = new VBoxContainer(); box.AddThemeConstantOverride("separation", 18); characters.AddChild(box);
            box.AddChild(WithCharacterAvatar(c.CharacterId.Length > 0 ? c.CharacterId : c.Name, Text(c.Name, 23, _gold)));
            ProfileFields(box, ("游戏战绩", $"{c.Wins} 次通关 · {c.Losses} 次失败"), ("解锁进阶", $"进阶 {c.UnlockedAscension}"),
                ("最佳连胜", $"{c.Streak} 场"), ("游玩时长", $"{c.Playtime / 3600.0:0.#} 小时"));
            box.AddChild(new HSeparator());
        }
        var recent = ProfileSection("近期游戏对局");
        if (a.Recent.Count == 0) recent.AddChild(Text("暂无游戏对局", 17, _muted));
        foreach (var r in a.Recent)
        {
            var box = new VBoxContainer(); box.AddThemeConstantOverride("separation", 10); recent.AddChild(box);
            var name = string.Join(" / ", r.Players.Select(p => PlayerArchive.CharacterName(p.Character)));
            ProfileEntry(box, $"{name} · 进阶 {r.Ascension}", r.Win ? "通关" : r.WasAbandoned ? "放弃" : "挑战结束", r.Win ? _gold : _ink);
            box.AddChild(Text($"{DateTimeOffset.FromUnixTimeSeconds(r.StartTime).LocalDateTime:yyyy.MM.dd HH:mm}    ·    {r.MapPointHistory.Sum(x => x.Count)} 层    ·    {MatchRules.Time(r.RunTime)}", 15, _muted));
        }
    }

    private void Calendar(CareerData data)
    {
        int shown = _selectedDay > 0 ? _selectedDay : data.Day;
        var today = GameCalendar.Date(data, data.Day);
        var month = CalendarMonth.Owner(today).AddMonths(_calendarMonth);
        var start=CalendarMonth.GridStart(month);
        int first=GameCalendar.Day(data,start);
        var columns = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };
        columns.AddThemeConstantOverride("separation", 22); _content.AddChild(columns);
        var left = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };
        left.AddThemeConstantOverride("separation",0); columns.AddChild(left);
        var side = new PanelContainer { Name="CalendarSidebar", CustomMinimumSize=new(376,840) };
        side.AddThemeStyleboxOverride("panel", CareerVisuals.Box("101e2b","324c5c",6,1)); columns.AddChild(side);
        var right = Inner(side); right.AddThemeConstantOverride("separation",0);
        var commands = new HBoxContainer(); commands.AddThemeConstantOverride("separation",8); left.AddChild(commands);
        CalendarCommands(data, commands);
        var months = TabStrip(left); months.CustomMinimumSize = new(0,70);
        months.AddThemeConstantOverride("separation",24);
        void Month(int delta)
        {
            _calendarMonth+=delta;
            if (_calendarMode=="当日") _calendarMode="日程";
            Render();
        }
        void MonthArrow(bool visible,int direction)
        {
            if (!visible) { months.AddChild(new Control { CustomMinimumSize=new(36,36) }); return; }
            var arrow=CaptionButton("",()=>Month(direction));
            arrow.AccessibilityName=direction<0?"上个月":"下个月"; arrow.Icon=NavigationIcon(direction<0?"chevron-left":"chevron-right");
            arrow.ExpandIcon=true; arrow.IconAlignment=HorizontalAlignment.Center; arrow.AddThemeConstantOverride("icon_max_width",18);
            arrow.CustomMinimumSize=new(36,36); arrow.SizeFlagsVertical=SizeFlags.ShrinkCenter;
            ButtonSurface(arrow,"00000000","00000000","1c3441","00000000"); months.AddChild(arrow);
        }
        MonthArrow(month>CalendarMonth.Owner(GameCalendar.Date(data,1)),-1);
        string[] monthNames = ["一","二","三","四","五","六","七","八","九","十","十一","十二"];
        var monthName=CaptionButton($"{month.Year}年{monthNames[month.Month - 1]}月",()=>{},true);
        monthName.AddThemeColorOverride("font_color",_gold); monthName.AddThemeFontSizeOverride("font_size",25); monthName.SizeFlagsVertical=SizeFlags.ShrinkCenter;
        monthName.MouseFilter=MouseFilterEnum.Ignore;monthName.FocusMode=FocusModeEnum.None;months.AddChild(monthName);
        MonthArrow(month<CalendarMonth.Owner(GameCalendar.Date(data,Math.Max(SeasonCalendar.End(data),data.Day+84))),1);
        var grid = new GridContainer { Columns = 7, SizeFlagsHorizontal = SizeFlags.ExpandFill };
        grid.AddThemeConstantOverride("h_separation", 6); grid.AddThemeConstantOverride("v_separation", 6); left.AddChild(grid);
        foreach (char label in "一二三四五六日")
        {
            var weekday = Text("周"+label,14,_muted); weekday.HorizontalAlignment = HorizontalAlignment.Center;
            weekday.CustomMinimumSize = new(0,22); grid.AddChild(weekday);
        }
        const int cellHeight=(703-4*6)/5;
        void Blank()
        {
            var blank = new Panel { CustomMinimumSize=new(0,cellHeight), SizeFlagsHorizontal=SizeFlags.ExpandFill, MouseFilter=MouseFilterEnum.Ignore };
            blank.AddThemeStyleboxOverride("panel",CareerVisuals.Box("0b1520","192a37",5,0)); grid.AddChild(blank);
        }
        var plans = _calendarMode == "计划" ? CalendarPlans(data) : [];
        var preview = plans.FirstOrDefault(p => p.Key == _planKey);
        if (preview == null) _planKey = "";
        var offered = data.Life.Activities.Where(a => a.Status == "可安排" && a.ExpiresDay >= data.Day && (data.Esports.ClubId.Length > 0 || !ClubPlan(a))).ToList();
        var appointments = SocialAppointments.All(data).Where(x => x.Offer.State is "已确认" or "已赴约" or "已结束")
            .ToLookup(x => PrivateAppointments.Date(data, x.Offer));
        var matchesByDay = data.Matches.Where(m => m.Registered || m.Day >= data.Day && m.Status == "待赛" && EsportsWorld.EntryReason(data,m) == null).ToLookup(m => m.Day);
        var humans = data.HumanIds.Append("player").Append(data.LocalHumanId).Where(id=>id.Length>0).ToHashSet();
        var fixturesByDay = data.Esports.Competitions.SelectMany(c => c.Fixtures
            .Where(f => humans.Contains(f.HomeId) || humans.Contains(f.AwayId) || f.HomeParticipants.Any(humans.Contains) || f.AwayParticipants.Any(humans.Contains))
            .Select(f => (Competition:c,Fixture:f))).ToLookup(x=>x.Fixture.Day);
        var monthPlans=_showCalendarPlans ? CalendarPeriods(data).Where(a=>a.StartedDay<first+CalendarMonth.Slots && a.FinishDay>=first)
            .OrderByDescending(a=>a.StartedDay).ToList() : [];
        var encounters=data.Life.RandomEvents.Where(e=>e.State!="skipped").ToLookup(e=>e.Day);
        for (int i=0; i<CalendarMonth.Slots; i++)
        {
            int day=first+i;
            var date=start.AddDays(i);
            if(day<1 || CalendarMonth.Owner(date)!=month) { Blank(); continue; }
            var match = matchesByDay[day].OrderByDescending(m => m.Registered).ThenByDescending(m => m.CompetitionId.Length > 0).FirstOrDefault();
            var world = fixturesByDay[day].FirstOrDefault().Competition;
            var appointment = appointments[day].FirstOrDefault();
            var ordinaryDate = appointments[day].FirstOrDefault(a => a.Offer.GoodId != "grand-wedding");
            bool entered = matchesByDay[day].Any(m => m.Registered) || world != null;
            var markers=new List<(string Icon,string Title)>();
            if (match != null || world != null) markers.Add((entered ? "calendar-crossed-swords" : "calendar-sword",match?.Event ?? world!.Name));
            foreach(var a in appointments[day])markers.Add((a.Offer.GoodId=="grand-wedding"?"wedding":"calendar-date",a.Offer.Title));
            foreach(var ev in encounters[day])markers.Add(("question",ev.Title));

            var activePlan=monthPlans.FirstOrDefault(a=>a.StartedDay<=day && day<=a.FinishDay);
            var encounter=encounters[day].FirstOrDefault();
            string title, detail;
            if (match!=null && (match.Registered || appointment.Offer==null && encounter==null && world==null))
                (title,detail)=(MatchTitle(data,match),MatchDetail(data,match));
            else if (appointment.Offer!=null)
                (title,detail)=(appointment.Offer.Title,"对象："+CareerEngine.DisplayName(data,appointment.Conversation.PersonId));
            else if (world!=null)
                (title,detail)=(world.Name,world.Country);
            else if (encounter!=null)
                (title,detail)=(encounter.Title,"随机事件");
            else if (activePlan!=null)
                (title,detail)=(activePlan.Title,$"第 {day-activePlan.StartedDay+1} / {activePlan.FinishDay-activePlan.StartedDay+1} 天");
            else (title,detail)=("训练 / 新闻","");
            if (encounter!=null && encounter.Title!=title)
                detail=string.Join("\n",new[]{detail,encounter.Title}.Where(s=>s.Length>0));
            var b = new CalendarDayButton { Day=day, Markers=markers.DistinctBy(m=>m.Icon).ToList(), CalendarHeight=cellHeight, Name = "CalendarDay_" + day, Number = date.Month==month.Month ? date.Day.ToString() : date.ToString("M/d"), CalendarLayout = true,
                PlanWindow = _calendarMode == "计划" && offered.Any(a => day >= a.OfferedDay && day <= a.ExpiresDay),
                Preview = preview?.Covers(day) == true,
                Description=title, SecondLine=detail,
                Today = day == data.Day, Selected = _calendarMode == "当日" && day == shown, HasMatch = match != null || world != null, Registered = entered,
                Question = encounters.Contains(day),
                Bond = ordinaryDate.Conversation == null ? null : RelationshipPresentation.IconBond(PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(ordinaryDate.Conversation.PersonId) ?? new()),
                Wedding = appointments[day].Any(a => a.Offer.GoodId == "grand-wedding") };
            b.Pressed += () =>
            {
                _selectedDay = day; _calendarMode = "当日"; ClearPlan(); Render();
            };
            b.Modulate = day < data.Day ? new Color("8591a0") : Colors.White;
            grid.AddChild(b);
        }
        var tabs = TabStrip(right,18,true,secondary:true); tabs.CustomMinimumSize=new(0,53);
        foreach (var mode in new[] { "日程", "计划" })
        {
            var tab = UnderlineTab(mode, () => { _calendarMode = mode; ClearPlan(); Render(); }, mode == "计划" ? _calendarMode == mode : _calendarMode != "计划",90);
            tabs.AddChild(tab); if (mode == "计划" && PendingPlans(data)) Dot(tab);
        }
        var innerScroll = new ScrollContainer { Name = "CalendarSideScroll", CustomMinimumSize = new(0, 555),
            SizeFlagsVertical = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled };
        right.AddChild(innerScroll);
        var box = new VBoxContainer { Name = "CalendarSideContent", SizeFlagsHorizontal = SizeFlags.ExpandFill }; box.AddThemeConstantOverride("separation",10);
        var inset = new MarginContainer { SizeFlagsHorizontal=SizeFlags.ExpandFill };
        foreach(string edge in new[]{"left","right","top","bottom"}) inset.AddThemeConstantOverride("margin_"+edge,19);
        innerScroll.AddChild(inset); inset.AddChild(box);
        if (_calendarMode == "计划") { PlanPane(data,box,innerScroll,plans,grid.GetChildren().OfType<CalendarDayButton>().ToArray()); return; }
        if (_calendarMode == "日程") { box.AddChild(DashboardLabel("接下来的安排",20,_ink,true)); UpcomingDays(data, box); return; }
        box.AddChild(DashboardLabel(GameCalendar.Date(data,shown).ToString("M月d日 · ddd",System.Globalization.CultureInfo.GetCultureInfo("zh-CN")),20,_ink));
        int initialCount=box.GetChildCount();
        CalendarEncounters(data,box,shown,encounters[shown]);
        foreach (var (conversation,activity) in SocialAppointments.All(data).Where(x=>PrivateAppointments.Date(data,x.Offer)==shown &&
                     x.Offer.State is "已确认" or "已赴约" or "已结束" or "未赴约"))
        {
            var entry=DayEntry(box,"heart",activity.Title,"对象："+CareerEngine.DisplayName(data,conversation.PersonId)+" · "+SocialAppointments.StatusText(data,activity));
            entry.AddChild(TextLink("查看私信 ↗",()=>{ if(activity.GroupId.Length>0) SelectGroup(activity.GroupId); else OpenPrivateMessages(conversation.PersonId); }));
        }
        foreach (var plan in monthPlans.Where(a=>a.StartedDay<=shown && shown<=a.FinishDay))
            DayEntry(box,"calendar-days",plan.Title,plan.Status+" · "+AgendaRange(data,plan.StartedDay,plan.FinishDay));
        foreach (var match in matchesByDay[shown])
        {
            string status=match.Status=="待赛" && match.Registered ? "已报名" : match.Status;
            var entry=DayEntry(box,"swords",MatchTitle(data,match),string.Join(" · ",new[]{MatchDetail(data,match),status}.Where(s=>s.Length>0)));
            string? reason=EsportsWorld.EntryReason(data,match);
            if(reason!=null && !match.Registered) entry.AddChild(DashboardLabel(reason,14,_muted,true));
            bool pending=match.Status=="待赛" && shown>=data.Day;
            if(pending && match.CompetitionId.Length==0 && (reason==null || match.Registered))
            {
                var registration=TextLink(match.Registered?"取消报名":"报名这场比赛",()=>{
                    if(MultiplayerCommand("propose-register",match.Id,number:match.Registered?0:1)) return;
                    var error=CareerEngine.SetRegistration(data,match,!match.Registered); Render(); if(error!=null) Notice(error,true);
                });
                registration.Disabled=_multiplayer is {Host:false}; entry.AddChild(registration);
            }
            var links = new HBoxContainer(); links.AddThemeConstantOverride("separation",14); entry.AddChild(links);
            if (pending && match.Registered && shown==data.Day)
                links.AddChild(TextLink("进入赛场",()=>Visit(()=>{_tab="赛事";_arenaMatchId=match.Id;}),icon:"arrow-right"));
            links.AddChild(TextLink("查看赛程",()=>OpenMatchFixture(data,match),icon:"arrow-right"));
        }
        foreach (var group in fixturesByDay[shown].Where(x=>!matchesByDay[shown].Any(m=>m.FixtureId==x.Fixture.Id && m.CompetitionId==x.Competition.Id)).GroupBy(x=>x.Competition))
        {
            var entry=DayEntry(box,"swords",group.Key.Name,$"世界赛场 · {group.Count(x=>x.Fixture.Finished)}/{group.Count()} 场已结束");
            entry.AddChild(TextLink("查看赛程",()=>OpenFixtureFor(data,shown,group.Key),icon:"arrow-right"));
        }
        if(box.GetChildCount()==initialCount) box.AddChild(DashboardLabel("当日暂无安排",16,_muted));
        if(shown>data.Day)
        {
            var jump=FramedAction("跳转到此日",()=>{
                if(MultiplayerCommand("propose-advance",number:shown)) return;
                CareerEngine.AdvanceToDay(data,shown); _selectedDay=data.Day; _calendarMonth=0; Render();
            },"arrow-right",trailing:true,height:43,quiet:true);
            jump.Name="CalendarDayJump"; jump.Disabled=_multiplayer is {Host:false}; box.AddChild(jump);
        }
    }

    private VBoxContainer DayEntry(VBoxContainer parent,string icon,string title,string detail)
    {
        parent.AddChild(Hairline());
        var row=new HBoxContainer(); row.AddThemeConstantOverride("separation",10); parent.AddChild(row);
        var mark=Glyph(icon,18,CareerVisuals.Teal); mark.SizeFlagsVertical=SizeFlags.ShrinkBegin; row.AddChild(mark);
        var copy=new VBoxContainer { SizeFlagsHorizontal=SizeFlags.ExpandFill }; copy.AddThemeConstantOverride("separation",5); row.AddChild(copy);
        copy.AddChild(DashboardLabel(title,17,_ink,true)); copy.AddChild(DashboardLabel(detail,13,_muted,true));
        return copy;
    }

    private void Matches(CareerData data)
    {
        using var timing = UiPerformance.Measure(UiPerformance.Work.Matches);

        if (data.PendingMatchId != null)
        {
            var pendingCard = Card(); _content.AddChild(pendingCard); var pb = Inner(pendingCard);
            pb.AddChild(Text(_multiplayer == null ? "比赛进行中" : _multiplayer.CanResume ? "比赛已暂停" : "比赛连接状态", 28, _gold));
            pb.AddChild(Text(_multiplayer?.RunStatus ?? GameBridge.RecoveryMessageFor(false), 18, _ink));
            pb.AddChild(Button("返回主菜单", Close, 200));
            if (_multiplayer != null) { var resume = Button("全队继续比赛", () => MultiplayerCommand("propose-resume"), 240); resume.Disabled = !_multiplayer.CanResume; pb.AddChild(resume); }
            if (_multiplayer == null)
            {
                pb.AddChild(Button("重新检查比赛存档", () => { GameBridge.RecoverPending(); Render(); }, 260));
                if (GameBridge.CanReleaseMissingRun) pb.AddChild(Button("取消失效的比赛", () =>
                    ShowCareerDialog("取消失效比赛", "解除本场比赛绑定并重新参赛？本次不计失败。", () => { GameBridge.ReleaseMissingRun(); Render(); return true; }), 260));
            }
            return;
        }
        var match = data.Matches.FirstOrDefault(m=>m.Id==_arenaMatchId && m.Status=="待赛" && m.Registered && m.Day==data.Day) ?? CareerEngine.NextMatch(data)
            ?? data.Matches.Where(m=>m.Day>=data.Day && m.Status=="待赛").OrderBy(m=>m.Day).FirstOrDefault(m=>EsportsWorld.EntryReason(data,m)==null);
        if (match != null)
        {
            var box=new VBoxContainer(); box.AddThemeConstantOverride("separation",14); _content.AddChild(box);
            bool placementPrize = data.Esports.Competitions.Any(c => c.Id == match.CompetitionId && c.Kind == "worldfinal" && c.PrizeVersion >= 1);
            var chars = GameBridge.Characters();
            var selection = Card(); selection.Name = "MatchCharacterSelection";
            selection.AddThemeStyleboxOverride("panel", CareerVisuals.Box("102b39", "47788a", 10, 20)); box.AddChild(selection);
            var choices = Inner(selection); var heading = new HBoxContainer(); choices.AddChild(heading); heading.AddChild(Text("出战角色", 25, _gold));
            const int columns = 5, slots = 2 * columns;
            bool hasOverflow = chars.Count > slots;
            int directCount = hasOverflow ? slots - 1 : chars.Count;
            int selectedCharacter = data.RandomCharacter ? chars.Count : Math.Max(0, chars.FindIndex(c => c.Id.ToString() == data.SelectedCharacter));
            var characterGrid = new GridContainer { Name = "MatchCharacterGrid", Columns = columns, SizeFlagsHorizontal = SizeFlags.ExpandFill };
            characterGrid.AddThemeConstantOverride("h_separation", 12); characterGrid.AddThemeConstantOverride("v_separation", 12); choices.AddChild(characterGrid);
            var characterButtons = new Dictionary<int, Button>();
            OptionButton? overflow = null;
            var selectedLabel = DashboardLabel("", 18, CareerVisuals.Teal);
            selectedLabel.ClipText = true;
            selectedLabel.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis;
            void SelectCharacter(int index)
            {
                selectedCharacter = index;
                foreach (var (option, button) in characterButtons)
                    button.SetPressedNoSignal(option == index);
                bool random = index == chars.Count;
                if (overflow != null)
                {
                    int item = !random && index >= directCount ? overflow.GetItemIndex(index) : -1;
                    overflow.Select(item);
                    if (item < 0) overflow.Text = "更多角色";
                    overflow.TooltipText = overflow.Text;
                }
                if (chars.Count == 0) { selectedLabel.Text = "没有可用角色。"; return; }
                string chosen = random ? "随机角色" : PlayerArchive.CharacterName(chars[index].Id);
                selectedLabel.Text = random ? "随机角色 · 开赛时确定" : "已选择：" + chosen;
                selectedLabel.TooltipText = selectedLabel.Text;
                if (_arenaCharacter != null && IsInstanceValid(_arenaCharacter) && !_arenaCharacter.IsQueuedForDeletion())
                    _arenaCharacter.Text = $"{data.Esports.Country} · {EsportsWorld.ClubName(data,data.Esports.ClubId)}\n最高进阶 {Math.Max(0,data.AvatarHighestClear)} · {chosen}";
            }
            void ChooseCharacter(int index)
            {
                bool random = index == chars.Count;
                string id = random ? CareerEngine.RandomCharacterChoice : chars[index].Id.ToString();
                if (_multiplayer != null)
                {
                    SelectCharacter(selectedCharacter);
                    MultiplayerCommand("character", id);
                    return;
                }
                SelectCharacter(index);
                data.RandomCharacter = random;
                if (!random) data.SelectedCharacter = id;
                CareerStore.Save(data);
            }
            for (int i = 0; i < directCount; i++)
            {
                int index = i;
                string title = PlayerArchive.CharacterName(chars[i].Id);
                var choice = Button("", () => ChooseCharacter(index), 0);
                choice.Name = "MatchCharacter_" + i;
                choice.AccessibilityName = choice.TooltipText = title;
                choice.ToggleMode = true;
                choice.CustomMinimumSize = new(0, CharacterTileHeight);
                choice.SizeFlagsHorizontal = SizeFlags.ExpandFill;
                var inner = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore };
                choice.AddChild(inner); inner.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
                inner.OffsetLeft = CharacterTileInset; inner.OffsetRight = -CharacterTileInset; inner.OffsetTop = 5; inner.OffsetBottom = -5;
                inner.AddThemeConstantOverride("separation", CharacterCaptionGap);
                inner.AddChild(new CareerAvatar { Art = AvatarAssets.Load(chars[i].Id.ToString(), 0, false),
                    CustomMinimumSize = new(CareerAvatarIcon.Pixels, CareerAvatarIcon.Pixels),
                    SizeFlagsVertical = SizeFlags.ShrinkCenter, MouseFilter = MouseFilterEnum.Ignore });
                var name = DashboardLabel(title, 22, _ink);
                name.SizeFlagsVertical = SizeFlags.ShrinkCenter;
                name.ClipText = true;
                name.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis;
                inner.AddChild(name);
                characterButtons.Add(index, choice); characterGrid.AddChild(choice);
            }
            if (hasOverflow)
            {
                overflow = ArenaCharacterMenu(chars, directCount, selectedCharacter, ChooseCharacter);
                characterGrid.AddChild(overflow);
            }
            var randomCharacter = ArenaIconButton("随机角色","shuffle",() => { if (chars.Count > 0) ChooseCharacter(chars.Count); },choice:true);
            randomCharacter.Name = "MatchRandomCharacter"; randomCharacter.Disabled = chars.Count == 0;
            randomCharacter.TooltipText = "开赛时从当前可用角色中随机确定，包含已启用的模组角色；继续比赛沿用存档角色。";
            characterButtons.Add(chars.Count, randomCharacter); heading.AddChild(randomCharacter);
            choices.AddChild(selectedLabel);
            SelectCharacter(selectedCharacter);
            var ascRow = new HBoxContainer(); ascRow.AddThemeConstantOverride("separation", 12); box.AddChild(ascRow);
            var ascTitle=Text(_multiplayer == null ? "个人挑战进阶" : "全队挑战进阶",17,_muted); ascTitle.AutowrapMode=TextServer.AutowrapMode.Off; ascTitle.SizeFlagsHorizontal=SizeFlags.ShrinkBegin; ascRow.AddChild(ascTitle);
            var asc = new SpinBox { Name = "MatchAscension", MinValue = match.RequiredAscension, MaxValue = 10, Step = 1, Value = MatchRules.PreferredAscension(data, match), CustomMinimumSize = new Vector2(120, 45) };
            var rewardPreview = Text("", 16, CareerVisuals.Teal);
            void UpdateReward() => rewardPreview.Text = placementPrize ? $"赛事进阶 {match.RequiredAscension} · 个人挑战的关注奖励 ×{MatchRules.RewardMultiplier(match.RequiredAscension, (int)asc.Value):0.00}。名次奖金以最终排名为准。" : $"赛事进阶 {match.RequiredAscension} · 单场奖励 ×{MatchRules.RewardMultiplier(match.RequiredAscension, (int)asc.Value):0.00} · 获胜奖金 {CareerMoney.Format(MatchRules.Reward(match.Prize, MatchRules.RewardMultiplier(match.RequiredAscension, (int)asc.Value)))}\n每提高一级，奖金和获胜或平局时的关注奖励增加 15%。战报仍按比赛规定的进阶记录。";
            UpdateReward();
            if (_multiplayer is { Host: false }) asc.Editable = false;
            asc.ValueChanged += value =>
            {
                if (MultiplayerCommand("ascension", match.Id, number: (int)value)) return;
                match.ChosenAscension = data.SelectedAscension = (int)value;
                UpdateReward(); CareerStore.Save(data);
            };
            box.AddChild(rewardPreview);
            ascRow.AddChild(asc); ascRow.AddChild(new Control {SizeFlagsHorizontal=SizeFlags.ExpandFill});
            ascRow.AddChild(MatchReviewButton(data));
            box.AddChild(Text($"比赛种子：{match.Seed}", 15, _muted));
            if (match.Decider.Length > 0) box.AddChild(Text(match.Decider, 18, _gold));
            bool future = match.Day > data.Day;
            bool due = !future && match.Registered;
            async void Launch()
            {
                if (future) { if (MultiplayerCommand("propose-advance", "direct", number: match.Day)) return; CareerEngine.AdvanceToDay(data,match.Day); Render(); return; }
                if (!match.Registered)
                {
                    if (MultiplayerCommand("propose-register",match.Id,number:1)) return;
                    var registration=CareerEngine.SetRegistration(data,match,true); Render();
                    if(registration!=null) Notice(registration,true); return;
                }
                if (chars.Count == 0) { Notice("没有可用角色。", true); return; }
                if (MultiplayerCommand("propose-start", match.Id, number: (int)asc.Value)) return;
                if (_starting) return;
                _starting = true;
                var character = selectedCharacter == chars.Count ? GameBridge.RandomChoice() : chars[Math.Clamp(selectedCharacter, 0, chars.Count - 1)];
                var error = await GameBridge.StartMatch(match, character, (int)asc.Value);
                _starting = false;
                if (IsInstanceValid(this) && !IsQueuedForDeletion() && error != null) Notice(error, true);
            }
            MatchArena(data,match.Event,match.OpponentId,CareerEngine.DisplayName(data,match.OpponentId),future?"前往比赛日":due?"开赛":"报名比赛",
                data.RandomCharacter?"随机角色":chars.Count>0?PlayerArchive.CharacterName(chars[Math.Clamp(selectedCharacter,0,chars.Count-1)].Id):CareerAvatars.MainCharacter(data,"player"),CareerVisuals.Teal,out var controls,match.Day,Launch);
            _content.MoveChild(box,-1);
            if (due && data.PendingMatchId == null && _multiplayer is not {Host:false}) controls.AddChild(ArenaTextAction("模拟本场", "fast-forward", CareerVisuals.Teal, () =>
            {
                if (MultiplayerCommand("propose-simulate", match.Id, number: (int)asc.Value)) return;
                if (chars.Count == 0) return;
                var character = selectedCharacter == chars.Count ? GameBridge.RandomChoice() : chars[Math.Clamp(selectedCharacter, 0, chars.Count - 1)];
                var error = PlayerSimulation.Run(data, match, character.Title.GetFormattedText(), character.Id.ToString(), (int)asc.Value);
                if (error == null && data.PendingSettlementId == match.Id && data.Results.Any(r => r.MatchId == match.Id)) { _tab="结算"; _reviewId=match.Id; }
                Render(); if (error != null) Notice(error, true);
            }));
            if (_multiplayer == null && due && data.PendingMatchId == null) controls.AddChild(ArenaTextAction("放弃本场", "flag", new Color("ef9295"), () =>
            { CareerEngine.Forfeit(data, match); if(data.PendingSettlementId==match.Id) { _tab="结算"; _reviewId=match.Id; } Render(); }));
            if (SaveManager.Instance.HasRunSave) box.AddChild(Text(MatchRecovery.SingleplayerInUse, 16, new Color("e7a6a6")));
            if(_multiplayer!=null) box.AddChild(Matchup(data,match));
        }
        else
        {
            var empty = Card(); _content.AddChild(empty); var eb = Inner(empty);
            bool available = CareerEngine.NextAvailable(data) != null;
            eb.AddChild(Text(available ? "尚未报名比赛" : "暂时没有可参赛比赛", 26, _gold));
            eb.AddChild(Text(available ? "可以从赛程分页报名，也可以继续推进日期。"
                : $"本赛季共 {SeasonCalendar.Length(data)} 天。没有比赛时仍可继续生活、等待后续赛程，或进入下个赛季。", 18, _ink));
            var actions = new HBoxContainer(); actions.AddThemeConstantOverride("separation", 12); eb.AddChild(actions);
            actions.AddChild(TeamButton("推进一天", AdvanceCareerDay, 180));
            actions.AddChild(TeamButton("下个赛季", () =>
            {
                if (MultiplayerCommand("propose-advance", number: SeasonCalendar.End(data) + 1)) return;
                CareerEngine.AdvanceToDay(data, SeasonCalendar.End(data) + 1); Render();
            }, 180));
            eb.AddChild(Text("推进期间会在已报名的比赛日停下。", 15, _muted));
        }
        if (match == null && data.Results.Count>0) _content.AddChild(MatchReviewButton(data));
    }

    private void Community(CareerData data)
    {
        using var timing = UiPerformance.Measure(UiPerformance.Work.Community);
        if (_postId == ComposePostId) { RenderPostComposer(data); return; }
        if (RenderWeeklyDetail(data)) return;
        if (_postId is { } id)
        {
            var post = CommunityThreads.All(data).FirstOrDefault(p => p.Id == id) ?? _readPosts.GetValueOrDefault(id);
            _content.AddChild(Button("查看社区列表", OpenCommunity, 170));
            if (post != null) RenderThread(data, post);
            else _content.AddChild(Text("暂时找不到这篇帖子。", 18, _muted));
            return;
        }
        WeeklyCarousel(data);
        var feed = BuildCommunityToolbar(data);
        int failedNews = CommunityThreads.All(data).Count(p => p.AuthorId != "player" && p.NewsGeneration.State == "failed");
        if (failedNews > 1)
        {
            _content.AddChild(Text($"有 {failedNews} 篇帖子没能生成，可以重试。", 15, _muted));
            _content.AddChild(Button("重试失败的帖子", () => GenerateContent(() => { _ = AiService.RetryFailedNewsAsync(); }, true), 245));
        }
        _content.AddChild(feed);
        PopulateCommunityFeed(data,feed);
    }

    private void AddPostCard(CareerData data, CommunityPost post, Container feed)
    {
        using var timing = UiPerformance.Measure(UiPerformance.Work.PostCard);
        var card = Card();
        var box = Inner(card);
        bool preparing = CommunityThreads.NewsPending(data, post);
        box.AddChild(WithAvatar(data, post.AuthorId, Text($"{post.Category}  ·  {GameCalendar.Text(data, post.Day)}  ·  {CareerEngine.DisplayName(data, post.AuthorId)}  ·  {(preparing ? "正在撰写" : post.Replies.Count + " 条回复")}", 14, _muted), 48, true));
        var titleButton = Button(post.Title, () => OpenPost(post));
        titleButton.AutowrapMode = TextServer.AutowrapMode.WordSmart; titleButton.Alignment = HorizontalAlignment.Left; titleButton.SizeFlagsHorizontal = SizeFlags.ExpandFill; box.AddChild(titleButton);
        if (post.Revision > post.SeenRevision) box.AddChild(Text("● 有新内容", 14, new Color("f07878")));
        if (!preparing) box.AddChild(MentionText(data, post.Body, 17, _ink, post.RelatedPeople.Append(post.AuthorId)));
        RenderWorkStatus(box, post.NewsGeneration, () => GenerateContent(() => { _ = AiService.RetryNewsAsync(post.Id); }, true), "News_" + post.Id);
        if (post.AuthorId == "player" && post.NeedsReaction) RenderWorkStatus(box, post.ReactionGeneration, () => GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([post.Id]); }, true), post.Id);
        feed.AddChild(card);
    }

    private void Profiles(CareerData data)
    {
        using var timing = UiPerformance.Measure(UiPerformance.Work.Profiles);
        _content.AddThemeConstantOverride("separation", 24);
        if (_personId == "player") { PlayerProfile(data); return; }
        if (_personId != null && CareerEngine.Person(data, _personId) is { } selectedPerson) { PersonProfile(data, selectedPerson); return; }
        var categories = ProfileActions(); SecondaryTabInset(_content).AddChild(categories);
        if (_multiplayer != null) categories.AddChild(FilterButton("真人队员", _profileFilter == "真人队员", () => OpenProfileList("真人队员"), 150));
        foreach (var filter in new[] { "国内职业", "国际职业", "青训", "主播与媒体", "退役与教练", "社区", "自建角色" })
            categories.AddChild(FilterButton(filter, _profileFilter == filter, () => OpenProfileList(filter), 150));
        var searchRow = new HBoxContainer(); searchRow.AddThemeConstantOverride("separation", 16); _content.AddChild(searchRow);
        var search = new LineEdit { Text = _profileQuery, PlaceholderText = "搜索 ID、姓名、国家或俱乐部", SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new Vector2(200, 46) }; searchRow.AddChild(search);
        void Search() { _profileQuery = search.Text.Trim(); _profileLimit = 36; Render(); }
        search.TextSubmitted += _ => Search(); searchRow.AddChild(Button("搜索", Search, 100));
        var origin = new OptionButton { Name = "ProfileOriginFilter", CustomMinimumSize = new(150, 46) };
        foreach (var label in new[] { "全部来源", "原生", "自定义" }) origin.AddItem(label);
        origin.Select(Array.IndexOf(new[] { "全部来源", "原生", "自定义" }, _profileOrigin)); searchRow.AddChild(origin);
        origin.ItemSelected += n => { _profileOrigin = origin.GetItemText((int)n); _profileLimit = 36; Render(); };
        var people = data.People.Where(p => _profileQuery.Length > 0 || (_profileFilter switch { "真人队员" => data.HumanIds.Contains(p.Id), "国内职业" => EsportsWorld.IsProfessional(p) && p.Country == data.Esports.Country,
            "国际职业" => EsportsWorld.IsProfessional(p) && p.Country != data.Esports.Country, "青训" => p.Role == "青训选手",
            "主播与媒体" => p.Role is "主播" or "解说员" or "赛事记者", "退役与教练" => p.Role is "退役选手" or "教练" || ClubCoaching.IsCoach(p), "自建角色" => p.CreatedCard, _ => p.Role == "普通玩家" }))
            .Where(p => _profileOrigin == "全部来源" || !GroupChats.IsHuman(data, p.Id) && (p.CreatedCard || p.EditedCard) == (_profileOrigin == "自定义"))
            .Where(p => _profileQuery.Length == 0 || (p.Handle + string.Join(" ", p.HandleAliases) + p.Name + p.Country + EsportsWorld.ClubName(data, p.ClubId)).Contains(_profileQuery, StringComparison.OrdinalIgnoreCase)).OrderByDescending(p => p.Rating).ToList();
        _content.AddChild(Text($"当前：{(_profileQuery.Length > 0 ? "全名录搜索" : _profileFilter)} · 找到 {people.Count} 人 / 世界共 {data.People.Count} 人 · 当前显示 {Math.Min(_profileLimit, people.Count)} 人", 15, _muted));
        var grid = new GridContainer { Columns = 3, SizeFlagsHorizontal = SizeFlags.ExpandFill }; grid.AddThemeConstantOverride("h_separation", 14); grid.AddThemeConstantOverride("v_separation", 14); _content.AddChild(grid);
        AddProfileCards(data, grid, people.Take(_profileLimit));
        if (people.Count > _profileLimit) _content.AddChild(Button("显示更多人物", () => { int scroll = _scroll.ScrollVertical; _profileLimit += 36; Render(); _ = RestoreScrollAsync(scroll, _renderVersion); }, 210));
    }

    private void AiSettings(CareerData data)
    {
        _aiSettingsDirty = false;
        var card = Card(); _content.AddChild(card); var box = Inner(card);
        var (matchBox, management) = AiSettingsPanel.Columns(box);
        CareerManagement(management);
        matchBox.AddChild(Text("局内 AI 水平", 24, _gold));
        int[] levels = [100, 1000, 10000];
        var levelPicker = AiSettingsPanel.RivalLevelPicker(data.RivalLevel, _multiplayer != null);
        int LevelIndex() => Array.IndexOf(levels, data.RivalLevel) is var i && i >= 0 ? i : 1;
        levelPicker.Select(LevelIndex());
        levelPicker.Disabled = data.PendingMatchId != null || _multiplayer is { Host: false } || _multiplayer?.ProposalId.Length > 0;
        levelPicker.ItemSelected += index =>
        {
            int level = levels[(int)index];
            if (_multiplayer != null) { levelPicker.Select(LevelIndex()); MultiplayerCommand("rival-level", number: level); return; }
            try { MatchRules.SetRivalLevel(data, level); CareerStore.Save(data); Notice("局内 AI 水平已保存。", false); }
            catch (Exception e) { levelPicker.Select(LevelIndex()); Notice(e.Message, true); }
        };
        matchBox.AddChild(levelPicker);
        matchBox.AddChild(Text("各类选手用时同比调整，通关率不变。" + (data.PendingMatchId != null ? "本场结束后可修改。" : _multiplayer != null ? "由房主设置，全队同步。" : "对本生涯后续比赛生效。"), 16, _muted));
        box.AddChild(Text("AI 内容设置", 24, _gold));
        if (_multiplayer is { Host: false }) { box.AddChild(Text("AI 由主机统一生成，你无需配置服务或密钥。帖子、解说与周刊会自动同步。", 20, _ink)); return; }
        _aiStatus = AiSettingsPanel.Build(box, data.Ai,
            () => { SaveAiSettings(data); AiService.RefreshConcurrency(data.Ai); },
            () => GenerateContent(() => { _ = AiService.ProcessPendingAsync(data, automatic: false); }), () => OpenPromptSettings(data), Notice, () => _aiSettingsDirty = true,
            confirmSwitch: action => ShowCareerDialog("方案没有保存", "方案没有保存，确认切换吗？", () => { action(); return true; }, "确认切换",
                contents: content =>
                {
                    var mark = new Label { Text = "◇", HorizontalAlignment = HorizontalAlignment.Center }; mark.AddThemeFontSizeOverride("font_size", 44); mark.AddThemeColorOverride("font_color", _gold); content.AddChild(mark);
                }, cancelText: "继续编辑"));
    }

    private void CareerManagement(VBoxContainer db)
    {
        db.AddChild(Text("生涯管理", 24, _gold));
        if (_multiplayer != null)
        {
            if (_multiplayer.Host) db.AddChild(Button("导入与导出生涯", OpenCareerLibrary, 200));
            AddMultiplayerReportButton(db); return;
        }
        var actions = new GridContainer {Columns=2,SizeFlagsHorizontal=SizeFlags.ExpandFill};
        actions.AddThemeConstantOverride("h_separation",10); actions.AddThemeConstantOverride("v_separation",8); db.AddChild(actions);
        actions.AddChild(Button("切换、导入与导出生涯", OpenCareerLibrary, 208));
        actions.AddChild(Button("刷新游戏战绩", () => { PlayerArchive.Invalidate(); Notice("游戏战绩已刷新。", false); }, 156));
        var export = Button("导出问题报告", () => { try { ShowDiagnosticFile(CareerStore.ExportDiagnostics()); } catch (Exception e) { GD.PushWarning(e.ToString()); Notice("问题报告未能保存，请检查文件夹的写入权限。", true); } }, 156);
        export.TooltipText = "打包当前生涯、运行日志和近期 AI 对话，供反馈问题时附上。密钥会自动隐藏。";
        actions.AddChild(export);
        actions.AddChild(Button("重置当前生涯", () => { _confirmReset = true; Render(); }, 156));
        foreach (var action in actions.GetChildren().OfType<Button>()) action.SizeFlagsHorizontal=SizeFlags.ExpandFill;
        if (_confirmReset)
        {
            db.AddChild(Text("重新开始生涯？当前赛程、人物、帖子和生涯奖励都会重置。旧生涯会先备份，原版战绩和 AI 设置保留。正在进行的对局将不再计入这段生涯。", 18, new Color("e9b09a")));
            var confirm = new HBoxContainer(); db.AddChild(confirm);
            confirm.AddChild(Button("确认重置生涯", () =>
            {
                try { BeginNpcSetup(true); }
                catch (Exception e) { GD.PushWarning(e.ToString()); Notice("生涯未能重置，请检查存档文件夹的写入权限。", true); }
            }, 210));
            confirm.AddChild(Button("取消", () => { _confirmReset = false; Render(); }, 120));
        }

    }

    private void AddHeading(string title, string description)
    {
        _content.AddChild(Text(title, 30, _gold));
        _content.AddChild(Text(description, 16, _muted));
    }

    protected void Notice(string message, bool error)
    {
        if (error && _privateOverlay != null) ShowPrivateCommandError(message);
        _notice.Text = error ? PlayerFacingText.LongError(message) : message; _notice.Show(); _noticeRemaining = error ? 0 : 4;
        _notice.AddThemeColorOverride("font_color", error ? new Color("f29b9b") : _gold);
    }

    private static PanelContainer Card()
    {
        var card = new BroadcastPanel { SizeFlagsHorizontal = SizeFlags.ExpandFill };
        card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("142332"));
        return card;
    }

    private static VBoxContainer Inner(PanelContainer card)
    {
        var box = new VBoxContainer(); box.AddThemeConstantOverride("separation", 9); card.AddChild(box); return box;
    }

    protected static Label Text(string text, int size, Color color)
    {
        var label = new Label { MouseFilter = MouseFilterEnum.Ignore, Text = CareerMoney.Display(text), AutowrapMode = TextServer.AutowrapMode.WordSmart, SizeFlagsHorizontal = SizeFlags.ExpandFill };
        label.AddThemeFontSizeOverride("font_size", size);
        label.AddThemeConstantOverride("line_spacing", 3);
        label.AddThemeColorOverride("font_color", color);
        return label;
    }

    protected static Button Button(string text, Action action, float width = 0)
    {
        var button = new BroadcastButton { Text = CareerMoney.Display(text), CustomMinimumSize = new Vector2(width, 48), FocusMode = FocusModeEnum.All, SizeFlagsHorizontal = SizeFlags.ShrinkBegin };
        button.AddThemeColorOverride("font_color", CareerVisuals.Ink);
        button.AddThemeFontSizeOverride("font_size", 17);
        button.Pressed += action;
        return button;
    }
}

public partial class SpireBackdrop : Control
{
    public override void _Ready() => SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
    public override void _Draw()
    {
        DrawRect(new Rect2(Vector2.Zero, Size), new Color("0c1623"));
        float w = Size.X, h = Size.Y;
        for (int i = 0; i < 22; i++)
        {
            float x = i * w / 21f;
            DrawLine(new Vector2(x, 0), new Vector2(x - 180, h), new Color(0.45f, 0.52f, 0.58f, 0.06f), 1);
        }
        var mountain = new[] { new Vector2(w * .62f, h), new Vector2(w * .73f, h * .27f), new Vector2(w * .78f, h * .58f), new Vector2(w * .87f, h * .14f), new Vector2(w, h) };
        DrawColoredPolygon(mountain, new Color("142436"));
        DrawLine(new Vector2(w * .87f, h * .14f), new Vector2(w * .87f, h * .73f), new Color("766646"), 2);
        DrawArc(new Vector2(w * .87f, h * .24f), 150, 0, Mathf.Tau, 80, new Color(0.91f, 0.76f, 0.45f, 0.13f), 2);
        var stars = new Random(71);
        for (int i = 0; i < 46; i++)
        {
            var pos = new Vector2(stars.NextSingle() * w, stars.NextSingle() * h * .75f);
            DrawCircle(pos, i % 9 == 0 ? 2.2f : 1.1f, new Color(0.95f, 0.86f, 0.65f, i % 9 == 0 ? 0.42f : 0.18f));
        }
    }
}

public partial class ResultChart : Control
{
    public List<CareerResult> Results { get; set; } = [];

    public override void _Draw()
    {
        if (Results.Count == 0) return;
        float left = 14, right = Size.X - 14, bottom = Size.Y - 15, top = 12;
        DrawLine(new Vector2(left, bottom), new Vector2(right, bottom), new Color("526174"), 1);
        for (int i = 1; i <= 3; i++)
        {
            float y = bottom - (bottom - top) * i / 3;
            DrawLine(new Vector2(left, y), new Vector2(right, y), new Color(1, 1, 1, 0.07f), 1);
        }
        float slot = (right - left) / Results.Count;
        for (int i = 0; i < Results.Count; i++)
        {
            var result = Results[i];
            float height = (result.Win ? 1f : Math.Clamp(result.Floor / 55f, 0.03f, 1f)) * (bottom - top);
            var color = result.Win ? new Color("efc777") : new Color("5b8098");
            DrawRect(new Rect2(left + i * slot + slot * .18f, bottom - height, slot * .64f, height), color);
        }
    }
}


