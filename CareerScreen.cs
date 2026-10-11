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
    private readonly Color _gold = CareerVisuals.Gold, _muted = CareerVisuals.Muted, _ink = CareerVisuals.Ink;
    private VBoxContainer _content = null!;
    private Label _status = null!;
    private Label _pageTitle = null!;
    private Label _seasonLabel = null!;
    private Label? _aiStatus;
    private bool _aiSettingsDirty;
    private string _profileFilter = "国内职业";
    private int _profileLimit = 36;
    private string _profileQuery = "";
    private string _communityFilter = "全部";
    private int _postLimit = 30;
    private ScrollContainer _scroll = null!;
    private Control _stage = null!;
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
    private string _postSignature = "";
    private CareerData _boundData = null!;
    private bool _starting;
    private bool _confirmReset;
    private string? _latestEvent;

    public override void _Input(InputEvent e)
    {
        if (_dialogOverlay != null)
        {
            if (e is InputEventKey { Pressed: true, Echo: false, Keycode: Key.Escape })
            { GetViewport().SetInputAsHandled(); _cancelDialog?.Invoke(); }
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
        if (_promptOverlay != null) return;
        if (_privateOverlay != null)
        {
            if (e is InputEventKey { Pressed: true, Echo: false, Keycode: Key.Escape }) { GetViewport().SetInputAsHandled(); ClosePrivateMessages(); }
            return;
        }
        if (e is InputEventKey { Pressed: true, Echo: false, Keycode: Key.Escape })
        { GetViewport().SetInputAsHandled(); Back(); }
    }
    private long _frameTime;
    public override void _Process(double delta)
    {
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
            if (!editing && _multiplayer.Refresh()) { _boundData = ViewData; int y = _scroll.ScrollVertical; Render(); _ = RestoreScrollAsync(y, _renderVersion); }
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
    {
        if (Current != null) return;
        var screen = new CareerScreen { _tab = initialTab ?? SettlementRecords.InitialTab(multiplayer?.Data ?? CareerStore.Data), Name = "NationalSpireCareer", ZIndex = 100, Theme = CareerVisuals.CreateTheme() };
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
    private void Close()
    {
        if (_starting) return;
        if (ViewData.Failure != null) return;
        if (_multiplayer != null) { _multiplayer.Message -= Notice; _multiplayer.Dispose(); }
        _open = null;
        foreach (var (node, visible) in _hidden) if (GodotObject.IsInstanceValid(node)) node.Visible = visible;
        _listCache?.Release(); QueueFree(); ActiveScreenContext.Instance.Update();
    }
    public override void _ExitTree() { if (_listCache != null && IsInstanceValid(_listCache) && _listCache.IsInsideTree()) { _listCache.Release(); } if (_multiplayer != null) { _multiplayer.Message -= Notice; _multiplayer.Dispose(); } _pageTween?.Kill(); _weeklyTween?.Kill(); if (_open == this) _open = null; }
    private void FitStage()
    {
        float scale = Math.Min(Size.X / 1600f, Size.Y / 1000f);
        _stage.Size = new Vector2(1600, 1000);
        _stage.Scale = Vector2.One * scale;
        _stage.Position = (Size - _stage.Size * scale) / 2;
    }
    private void Build()
    {
        var background = new BroadcastBackdrop();
        AddChild(background); background.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        _stage = new Control(); AddChild(_stage); Resized += FitStage; FitStage();
        var shell = new MarginContainer(); _stage.AddChild(shell); shell.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        foreach (string side in new[] { "left", "right", "top", "bottom" }) shell.AddThemeConstantOverride("margin_" + side, 28);
        var page = new VBoxContainer(); page.AddThemeConstantOverride("separation", 22); shell.AddChild(page);
        var top = new HBoxContainer { CustomMinimumSize = new Vector2(0, 58) }; page.AddChild(top);
        var brand = new VBoxContainer { CustomMinimumSize = new Vector2(250, 0) }; top.AddChild(brand);
        brand.AddChild(Text("国 运 尖 塔", 28, _ink)); brand.AddChild(Text("NATIONAL SPIRE  /  " + Diagnostics.ModVersion, 12, _gold));
        _pageTitle = Text("生涯大厅", 24, _ink); top.AddChild(_pageTitle);
        if (_multiplayer != null) top.AddChild(Button("队伍与邀请   ↗", () => { var context = _multiplayer; Close(); context.OpenRoom(); }, 190));
        top.AddChild(Button("返回主菜单   ↗", Close, 175));
        var body = new HBoxContainer { SizeFlagsVertical = SizeFlags.ExpandFill }; body.AddThemeConstantOverride("separation", 28); page.AddChild(body);
        var navPanel = new PanelContainer { CustomMinimumSize = new Vector2(226, 0) }; navPanel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("0d1825e8", "2d4250", 8, 18)); body.AddChild(navPanel);
        var nav = new VBoxContainer { Name = "CareerNavigationColumn" }; navPanel.AddChild(nav);
        _seasonLabel = Text("赛季  " + _boundData.Season.ToString("00"), 27, _gold); nav.AddChild(_seasonLabel);
        nav.AddThemeConstantOverride("separation", 6);
        nav.AddChild(Text("每一次攀登，都有人见证。", 14, _muted));
        nav.AddChild(new Control { CustomMinimumSize = new Vector2(0, 18) });
        int index = 0;
        foreach (var tab in new[] { "首页", "日程", "赛事", "赛事与俱乐部", "结算", "社区", "选手档案", "模组设置", "生涯生活" })
        {
            var button = Button($"{++index:00}    {(tab == "赛事" ? "开赛" : tab)}", () => SwitchTab(tab));
            button.Alignment = HorizontalAlignment.Left; button.SizeFlagsHorizontal = SizeFlags.ExpandFill;
            button.CustomMinimumSize = new Vector2(0, 44); nav.AddChild(button); _navButtons[tab] = button;
            // 原版中文字形的行高较大，导航压缩留白而不缩小字号，避免挤出底部内容。
            foreach (string state in new[] { "normal", "hover", "pressed", "disabled" })
            {
                var style = (StyleBox)button.GetThemeStylebox(state).Duplicate();
                style.ContentMarginTop = style.ContentMarginBottom = 8;
                button.AddThemeStyleboxOverride(state, style);
            }
        }
        nav.AddChild(new Control { SizeFlagsVertical = SizeFlags.ExpandFill });
        _updatesButton = Button("", OpenUpdates); _updatesButton.SizeFlagsHorizontal = SizeFlags.ExpandFill;
        _updatesButton.AutowrapMode = TextServer.AutowrapMode.WordSmart;
        var inboxRow = new HBoxContainer(); inboxRow.AddThemeConstantOverride("separation", 8); nav.AddChild(inboxRow);
        _privateBadge = Button("", () => OpenPrivateMessages(), 46); _privateBadge.TooltipText = "私信";
        _privateBadge.AddChild(new PrivateIcon { MouseFilter = MouseFilterEnum.Ignore }); inboxRow.AddChild(_privateBadge); inboxRow.AddChild(_updatesButton);
        nav.AddChild(new CareerArt { CustomMinimumSize = new Vector2(175, 90) });
        nav.AddChild(Text("THE WORLD IS WATCHING", 11, _gold));
        nav.AddChild(Text("A8 职业赛场 · A9 巅峰挑战\nA10 世界极限", 13, _muted));
        var right = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; body.AddChild(right);
        var navigation = new HBoxContainer(); navigation.AddThemeConstantOverride("separation", 16); right.AddChild(navigation);
        _backButton = Button("← 返回上一级", Back, 210); navigation.AddChild(_backButton);
        _breadcrumb = Text("", 16, _muted); _breadcrumb.AutowrapMode = TextServer.AutowrapMode.Off;
        _breadcrumb.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; navigation.AddChild(_breadcrumb);
        _status = Text("", 16, _muted); _status.CustomMinimumSize = new Vector2(0, 32); right.AddChild(_status);
        _scroll = new BroadcastScroll { SizeFlagsVertical = SizeFlags.ExpandFill, SizeFlagsHorizontal = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled };
        right.AddChild(_scroll);
        _content = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; _content.AddThemeConstantOverride("separation", 18);
        var scrollPadding = new MarginContainer { Name = "CareerContentPadding", SizeFlagsHorizontal = SizeFlags.ExpandFill };
        scrollPadding.AddThemeConstantOverride("margin_bottom", 32); _scroll.AddChild(scrollPadding); scrollPadding.AddChild(_content);
        Render();
        if (_multiplayer == null && CareerStore.LoadNotice.Length > 0) Notice(CareerStore.LoadNotice, true);
    }

    private void Render()
    {
        using var timing = UiPerformance.Measure(UiPerformance.Work.Render, _tab);
        if (ViewData.Failure != null) _tab = "结算";
        if (ViewData.PendingCeremonySeason is > 0 and var pending && _noticedCeremonySeason != pending)
        {
            _noticedCeremonySeason = pending;
            _ceremonySeason = pending;
            _tab = "赛事与俱乐部"; _worldSection = "颁奖盛典"; _competitionId = null;
            _ceremonySection = "获奖名单";
            if (_multiplayer == null) { ViewData.PendingCeremonySeason = 0; CareerStore.Save(ViewData); }
            else MultiplayerCommand("ceremony-read", pending.ToString());
        }
        if (_scroll is BroadcastScroll scrolling) scrolling.StopMotion();
        _renderVersion++;
        _mentionsChecked = false;
        _listCache?.Release(); CareerVisuals.ClearContent(_content);
        _content.AddThemeConstantOverride("separation", 18);
        _pageTitle.Text = _tab == "首页" ? "生涯大厅" : _tab == "赛事与俱乐部" && _worldSection == "颁奖盛典" ? "颁奖盛典" : _tab;
        UpdateNavigation();
        foreach (var (name, button) in _navButtons)
        {
            button.Disabled = ViewData.Failure != null && name != "结算";
            var style = CareerVisuals.Box(name == _tab ? "28434c" : "0d1825", name == _tab ? "658c91" : "0d1825", 5, 14);
            style.ContentMarginTop = style.ContentMarginBottom = 8;
            button.AddThemeStyleboxOverride("normal", style);
            button.AddThemeColorOverride("font_color", name == _tab ? _ink : _muted);
        }
        var data = ViewData;
        _backButton.Disabled |= data.Failure != null;
        if (data.Failure != null) { Settlement(data); AnimatePage(); return; }
        _seasonLabel.Text = "赛季  " + data.Season.ToString("00");
        string? latestEvent = data.Posts.FirstOrDefault()?.Id;
        bool newEvent = _latestEvent != null && _latestEvent != latestEvent;
        _latestEvent = latestEvent;
        _postSignature = Signature(data);
        _status.AddThemeColorOverride("font_color", _muted);
        _status.Text = $"第 {data.Season} 赛季  ·  第 {SeasonCalendar.Day(data, data.Day)} 天     评分 {data.Rating}     关注 {data.Fans}     可用资金 {CareerMoney.Format(CareerMoney.Balance(data))}";
        if (_multiplayer != null)
        {
            _content.AddChild(Text(_multiplayer.Status, 16, CareerVisuals.Teal));
            if (_multiplayer.ProposalId.Length > 0)
            {
                var proposal = Card(); _content.AddChild(proposal); var pb = Inner(proposal);
                pb.AddChild(Text("等待全员确认", 22, _gold)); pb.AddChild(Text(_multiplayer.ProposalText, 17, _ink));
                var approve = Button(_multiplayer.HasVoted ? "你已同意，等待队友" : "同意本次安排", () => MultiplayerCommand("confirm", _multiplayer.ProposalId), 250); approve.Disabled = _multiplayer.HasVoted; pb.AddChild(approve);
                pb.AddChild(Button("取消这项安排", () => MultiplayerCommand("cancel"), 180));
            }
        }
        if (_tab != "首页" && !(_tab == "赛事与俱乐部" && _worldSection == "俱乐部") && CanManageClub
            && !OwnedClubs.IsOwner(data) && OwnedClubs.CanJoinThisSeason(data)
            && data.Credits >= OwnedClubs.FoundingCost)
        {
            var clubEntry = Button("可以组建自己的俱乐部 · 联赛开赛前开放  →", BeginClubDraft, 0);
            clubEntry.SizeFlagsHorizontal = SizeFlags.ExpandFill;
            clubEntry.AddThemeStyleboxOverride("normal", CareerVisuals.Box("234148", "8da98f", 8, 16));
            _content.AddChild(clubEntry);
        }
        switch (_tab)
        {
            case "首页": Home(data); break;
            case "结算": Settlement(data); break;
            case "日程": Calendar(data); break;
            case "赛事": RenderTeam(); Matches(data); break;
            case "赛事与俱乐部": World(data); break;
            case "生涯生活": Life(data); break;
            case "社区": Community(data); break;
            case "选手档案": Profiles(data); break;
            case "模组设置": AiSettings(data); break;
        }
        AnimatePage();
        UpdateCommunityBadge(); _postSignature = Signature(data);
        if (_multiplayer == null && newEvent && data.Ai.Enabled && data.Posts.FirstOrDefault()?.AuthorId != "player") _ = AiService.ProcessPendingAsync();
        if (_multiplayer == null && data.Ai.Enabled && data.WeeklyEditions.Any(w => w.ProfilesWork.State == "idle" || w.NewsWork.State == "idle")) _ = AiService.ProcessWeeklyAsync();
    }

    private string Signature(CareerData data) => string.Join('|', CommunityThreads.All(data).Select(p => $"{p.Id}:{p.Revision}:{p.SeenRevision}:{p.AiPending}:{p.NewsGeneration.State}:{p.NewsGeneration.Error}:{p.NewsGeneration.WaitReason}:{p.ReactionGeneration.State}:{p.ReactionGeneration.Error}:{p.ReactionGeneration.WaitReason}:" + string.Join(',', p.Replies.Where(r => r.AuthorId == "player").Select(r => $"{r.Id}:{r.NeedsReaction}:{r.ReactionGeneration.State}:{r.ReactionGeneration.Error}:{r.ReactionGeneration.WaitReason}"))))
        + string.Join('|', data.WeeklyEditions.Select(w => $"weekly:{w.Week}:{w.Revision}:{w.SeenRevision}:{w.ProfilesWork.State}:{w.ProfilesWork.Error}:{w.ProfilesWork.WaitReason}:{w.NewsWork.State}:{w.NewsWork.Error}:{w.NewsWork.WaitReason}"));

    private void Home(CareerData data)
    {
        foreach (var (conversation, activity) in SocialAppointments.Due(data))
        {
            var reminder = Card(); _content.AddChild(reminder); var body = Inner(reminder);
            var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 18); body.AddChild(row);
            var words = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; row.AddChild(words);
            words.AddChild(Text(activity.Title, 23, _gold)); words.AddChild(Text("今天 · " + CareerEngine.DisplayName(data, conversation.PersonId), 16, _muted));
            row.AddChild(Button(activity.GroupId.Length > 0 ? "前往群聊  →" : "前往私信  →", () => { if (activity.GroupId.Length > 0) SelectGroup(activity.GroupId); else OpenPrivateMessages(conversation.PersonId); }, 175));
        }
        ClubInvitation(data);
        if (data.Ceremonies.Count > 0) CeremonyInvitation(data);
        var archive = PlayerArchive.Read(false);
        var hero = Card(); hero.AddThemeStyleboxOverride("panel", CareerVisuals.Box("172b3c", "406577", 8, 28));
        if (hero is BroadcastPanel banner) banner.Accent = CareerVisuals.Lime;
        _content.AddChild(hero);
        var heroRow = new HBoxContainer(); hero.AddChild(heroRow);
        var intro = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; heroRow.AddChild(intro);
        intro.AddChild(Text("MATCHDAY    /    下一场焦点", 13, CareerVisuals.Teal));
        intro.AddChild(Text(EsportsWorld.LicenseName(data) + "    /    " + EsportsWorld.ClubName(data, data.Esports.ClubId), 15, _gold));
        var next = CareerEngine.NextMatch(data);
        bool noAvailableMatch = next == null && CareerEngine.NextAvailable(data) == null;
        intro.AddChild(Text(data.PendingMatchId != null ? "未完的攀登" : next?.Event ?? "从这里，走向世界赛场。", 36, _ink));
        intro.AddChild(Text(data.PendingMatchId != null ? "比赛已经开始，完成对局后将自动生成战报。" : noAvailableMatch ? "当前没有可报名的比赛。可以在日程中推进日期，等待后续赛程或进入下个赛季。" : next == null ? "挑选一场比赛，开始新的攀登。" : $"对阵 {CareerEngine.DisplayName(data, next.OpponentId)}    ·    第 {SeasonCalendar.Day(data, next.Day)} 天    ·    最低进阶 {next.RequiredAscension}", 18, _muted));
        intro.AddChild(Text(EsportsWorld.NextGoal(data), 15, CareerVisuals.Teal));
        intro.AddChild(new Control { CustomMinimumSize = new Vector2(0, 12) });
        var play = Button(data.PendingMatchId != null ? "查看进行中的比赛   →" : noAvailableMatch ? "查看日程并推进   →" : next == null ? "选择参赛赛事   →" : next.Day > data.Day ? "前往比赛日   →" : "准备出场   →", () =>
        {
            if (next != null && next.Day > data.Day && data.PendingMatchId == null && !MultiplayerCommand("propose-advance", number: next.Day)) CareerEngine.AdvanceToMatch(data);
            Visit(() => _tab = noAvailableMatch && data.PendingMatchId == null ? "日程" : "赛事");
        }, 260); Emphasize(play); intro.AddChild(play);
        var poster = new VBoxContainer { CustomMinimumSize = new Vector2(276, 0) }; heroRow.AddChild(poster);
        poster.AddChild(new BroadcastPortrait { Art = AvatarAssets.Load(CareerAvatars.MainCharacter(data, "player"), CareerAvatars.HomeCardVariation(data), true), CustomMinimumSize = new Vector2(276, 192), SizeFlagsVertical = SizeFlags.ExpandFill });
        var playerTag = Button(CareerEngine.Name(data) + "   ↗", () => OpenPerson("player")); playerTag.SizeFlagsHorizontal = SizeFlags.ExpandFill;
        playerTag.ClipText = true; playerTag.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis; poster.AddChild(playerTag);
        RenderTeamPreparations(data);
        var metrics = new HBoxContainer(); _content.AddChild(metrics);
        Metric(metrics, "世界积分", CircuitLedger.Points(data, "player").ToString(), $"{data.Wins} 胜 · {data.Draws} 平 · {data.Losses} 负");
        Metric(metrics, "世界关注", data.Fans.ToString("N0"), "你的表现正在被看见");
        Metric(metrics, "可用资金", CareerMoney.Format(CareerMoney.Balance(data)), "比赛、合同与生活收支");
        int lifeOffers = data.Life.Activities.Count(a => a.Status == "可安排" && a.ExpiresDay >= data.Day);
        if (lifeOffers > 0) _content.AddChild(Button($"有 {lifeOffers} 项新的生涯活动  →", () => Visit(() => _tab = "生涯生活"), 320));
        if (_multiplayer == null) Metric(metrics, "存档通关率", archive.WinRate, $"{archive.Wins} 次通关 / {archive.Wins + archive.Losses} 次对局");
        else Metric(metrics, "本生涯通关", data.Results.Count(r => r.Win).ToString(), $"已完成 {data.Results.Count} 场团队比赛");
        var columns = new HBoxContainer(); _content.AddChild(columns);
        var ranking = Card(); ranking.SizeFlagsStretchRatio = .9f; columns.AddChild(ranking); var rb = Inner(ranking);
        rb.AddChild(Text("国内职业联赛", 22, _ink)); rb.AddChild(Text("本赛季联赛积分", 14, _muted));
        int rank = 0;
        if (data.Standings.Count == 0) rb.AddChild(Text("通过青训选拔、签约俱乐部后，就能登上职业赛场。", 17, _muted));
        foreach (var entry in (EsportsWorld.PlayerLeague(data) is { PlayerEntered: true } league ? EsportsWorld.Ranked(league) : Enumerable.Empty<CareerStanding>()).Take(5))
        {
            var row = new HBoxContainer(); rb.AddChild(row);
            var number = Text($"{++rank:00}", 19, rank <= 3 ? _gold : _muted); number.SizeFlagsHorizontal = SizeFlags.ShrinkBegin; number.CustomMinimumSize = new Vector2(38, 0); row.AddChild(number);
            row.AddChild(WithAvatar(data, entry.PersonId, Text(CareerEngine.DisplayName(data, entry.PersonId), 19, entry.PersonId == "player" ? _gold : _ink), 36, true));
            var points = Text($"{entry.Points} 分", 18, _muted); points.AutowrapMode = TextServer.AutowrapMode.Off; points.CustomMinimumSize = new Vector2(65, 0); points.HorizontalAlignment = HorizontalAlignment.Right; points.SizeFlagsHorizontal = SizeFlags.ShrinkEnd; row.AddChild(points);
        }
        rb.AddChild(Button("查看赛事与俱乐部   ↗", () => OpenWorldSection("赛事总览"), 205));
        var news = Card(); columns.AddChild(news); var nb = Inner(news);
        nb.AddChild(Text("世界频道", 22, _ink)); nb.AddChild(Text("比赛战报 / 赛区动态 / 社区讨论", 14, _muted));
        foreach (var post in data.Posts.Take(2))
        {
            nb.AddChild(WithAvatar(data, post.AuthorId, Text($"第 {SeasonCalendar.Day(data, post.Day)} 天  ·  {(CommunityThreads.NewsPending(data, post) ? "正在撰写" : post.Replies.Count + " 条讨论")}", 13, _gold), 36, true));
            var link = Button(post.Title, () => OpenPost(post));
            link.SizeFlagsHorizontal = SizeFlags.ExpandFill; link.AutowrapMode = TextServer.AutowrapMode.WordSmart; link.Alignment = HorizontalAlignment.Left; nb.AddChild(link);
        }
        nb.AddChild(Button("进入社区   ↗", OpenCommunity, 180));
        var history = Card(); _content.AddChild(history); var hb = Inner(history);
        var line = new HBoxContainer(); hb.AddChild(line);
        line.AddChild(WithAvatar(data, "player", Text(_multiplayer == null ? $"我的尖塔档案    {archive.Playtime / 3600.0:0.#} 小时    /    最佳连胜 {archive.Streak}    /    累计攀登 {archive.Floors} 层" : $"我的多人生涯    {data.Wins} 胜 {data.Draws} 平 {data.Losses} 负    /    最高通关进阶 {Math.Max(0, data.AvatarHighestClear)}", 17, _muted), 40, true));
        line.AddChild(Button("查看档案   ↗", () => OpenPerson("player"), 165));
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
        AddHeading("赛季日程", $"本赛季共 {SeasonCalendar.Length(data) / 7} 周。挑选想参加的比赛；跳过日期时，会在你已报名的比赛日停下。");
        var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 10); _content.AddChild(row);
        row.AddChild(TeamButton("推进一天", () => { if (MultiplayerCommand("propose-advance", number: data.Day + 1)) return; bool advanced = CareerEngine.AdvanceOneDay(data); Render(); if (!advanced) Notice("比赛日需先完成或放弃比赛。", true); }, 180));
        var nextMatchButton = TeamButton("跳转到下一场比赛", () => { if (MultiplayerCommand("propose-advance", number: CareerEngine.NextMatch(data)?.Day ?? data.Day + 1)) return; CareerEngine.AdvanceToMatch(data); Render(); }, 260);
        if (CareerEngine.NextMatch(data) == null)
        { nextMatchButton.Text = "暂无已报名比赛"; nextMatchButton.Disabled = true; nextMatchButton.TooltipText = "可以推进一天、前往下个赛季，或选择尚可报名的比赛。"; }
        row.AddChild(nextMatchButton);
        row.AddChild(TeamButton("跳过四周", () => { if (MultiplayerCommand("propose-advance", number: data.Day + 28)) return; CareerEngine.AdvanceToDay(data, data.Day + 28); _selectedDay = data.Day; Render(); }, 155));
        row.AddChild(TeamButton("下个赛季", () => { if (MultiplayerCommand("propose-advance", number: SeasonCalendar.End(data) + 1)) return; CareerEngine.AdvanceToDay(data, SeasonCalendar.End(data) + 1); _selectedDay = data.Day; Render(); }, 155));
        _content.AddChild(TeamButton(data.AutoQualifiers ? "选拔赛自动报名：开启" : "选拔赛自动报名：暂停", () =>
        {
            if (MultiplayerCommand("propose-auto", number: data.AutoQualifiers ? 0 : 1)) return;
            data.AutoQualifiers = !data.AutoQualifiers;
            if (!data.AutoQualifiers)
                foreach (var game in data.Matches.Where(m => m.Kind is "local" or "city" or "academy" && m.Status == "待赛" && m.Id != data.PendingMatchId)) game.Registered = false;
            else CircuitWorld.AutoEntry(data);
            CareerStore.Save(data); Render();
        }, 290));
        int start = SeasonCalendar.Start(data) + 1;
        int shown = _selectedDay >= start && _selectedDay < start + SeasonCalendar.Length(data) ? _selectedDay : data.Day;
        int block = (shown - start) / 28, blockStart = start + block * 28;
        var periods = new HBoxContainer(); _content.AddChild(periods);
        for (int page = 0; page < SeasonCalendar.Length(data) / 28; page++)
        {
            int target = start + page * 28;
            var period = Button($"第 {page * 4 + 1}—{page * 4 + 4} 周", () => { _selectedDay = target; Render(); }, 170);
            if (page == block) Emphasize(period);
            periods.AddChild(period);
        }
        var grid = new GridContainer { Columns = 7, SizeFlagsHorizontal = SizeFlags.ExpandFill };
        grid.AddThemeConstantOverride("h_separation", 8); grid.AddThemeConstantOverride("v_separation", 8);
        _content.AddChild(grid);
        for (int i = 0; i < 28; i++)
        {
            int day = blockStart + i;
            var match = data.Matches.Where(m => m.Day == day).OrderByDescending(m => m.Registered).ThenByDescending(m => m.CompetitionId.Length > 0).FirstOrDefault();
            var world = data.Esports.Competitions.FirstOrDefault(c => c.Fixtures.Any(f => f.Day == day));
            var appointment = SocialAppointments.All(data).FirstOrDefault(x => x.Offer.State is "已确认" or "已赴约" && PrivateAppointments.Date(data, x.Offer) == day);
            string badge = match == null ? world == null ? "·" : "◇" : "◆";
            var b = Button($"{day - start + 1:00}  {badge}\n{(match?.Event ?? appointment.Offer?.Title ?? world?.Name ?? "训练 / 新闻")}", () => { _selectedDay = day; Render(); }, 0);
            b.CustomMinimumSize = new Vector2(0, 88);
            b.SizeFlagsHorizontal = SizeFlags.ExpandFill; b.AutowrapMode = TextServer.AutowrapMode.WordSmart; b.AddThemeFontSizeOverride("font_size", 16);
            b.Modulate = day < data.Day ? new Color("8591a0") : day == data.Day ? _gold : Colors.White;
            grid.AddChild(b);
        }
        var detail = Card(); _content.AddChild(detail);
        var box = Inner(detail); box.AddChild(Text($"第 {shown - start + 1} 天", 24, _gold));
        foreach (var (conversation, activity) in SocialAppointments.All(data).Where(x => PrivateAppointments.Date(data, x.Offer) == shown && x.Offer.State is "已确认" or "已赴约" or "未赴约"))
        {
            var activityRow = new HBoxContainer(); box.AddChild(activityRow);
            activityRow.AddChild(Text(activity.Title + " · " + CareerEngine.DisplayName(data, conversation.PersonId) + " · " + activity.State, 18, CareerVisuals.Teal));
            activityRow.AddChild(Button("查看私信 →", () => OpenPrivateMessages(conversation.PersonId), 160));
        }
        foreach (var selected in data.Matches.Where(m => m.Day == shown))
        {
            box.AddChild(Text($"{selected.Event}  ·  {selected.Status}  ·  对手 {CareerEngine.DisplayName(data, selected.OpponentId)}  ·  最低进阶 {selected.RequiredAscension}", 18, _ink));
            var reason = EsportsWorld.EntryReason(data, selected);
            if (reason != null && !selected.Registered) box.AddChild(Text(reason, 14, _muted));
            if (selected.Status == "待赛" && shown >= data.Day && selected.CompetitionId.Length == 0 && (reason == null || selected.Registered))
                box.AddChild(TeamButton(selected.Registered ? "取消报名" : "报名这场比赛", () => { if (MultiplayerCommand("propose-register", selected.Id, number: selected.Registered ? 0 : 1)) return; var error = CareerEngine.SetRegistration(data, selected, !selected.Registered); Render(); if (error != null) Notice(error, true); }, 180));
        }
        foreach (var competition in data.Esports.Competitions.Where(c => c.Fixtures.Any(f => f.Day == shown)))
        {
            var fixtures = competition.Fixtures.Where(f => f.Day == shown).ToList();
            box.AddChild(Text($"世界赛场 · {competition.Name} · {fixtures.Count(f => f.Finished)}/{fixtures.Count} 场已结束", 16, _muted));
        }
        if (shown > data.Day) box.AddChild(TeamButton("跳转到此日", () => { if (MultiplayerCommand("propose-advance", number: shown)) return; CareerEngine.AdvanceToDay(data, shown); Render(); }, 180));
    }

    private void Matches(CareerData data)
    {
        using var timing = UiPerformance.Measure(UiPerformance.Work.Matches);
        AddHeading("选择你的赛场", "通关胜过未通关。都通关时，速度更快的一方获胜；都未通关时，到达更高楼层的一方获胜。");
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
        var match = CareerEngine.NextMatch(data);
        if (match != null)
        {
            var opponent = CareerEngine.Person(data, match.OpponentId)!;
            var card = Card(); _content.AddChild(card);
            var box = Inner(card);
            box.AddChild(Text(match.Event, 27, _gold));
            bool placementPrize = data.Esports.Competitions.Any(c => c.Id == match.CompetitionId && c.Kind == "worldfinal" && c.PrizeVersion >= 1);
            if (placementPrize) box.AddChild(Text("本届名次奖金：冠军 $500,000，亚军 $250,000，四强 $100,000，八强 $50,000，十六强 $20,000，其余参赛者 $10,000。赛事结束时按最终名次领取。", 17, _gold));
            box.AddChild(Text($"第 {SeasonCalendar.Day(data, match.Day)} 天  ·  对手 {opponent.PublicName}  ·  {(placementPrize ? "按最终名次领取奖金" : "奖金 " + CareerMoney.Format(match.Prize))}", 18, _ink));
            box.AddChild(Text($"对手擅长 {opponent.Character}，最高进阶 {opponent.MaxAscension}。比赛最低进阶 {match.RequiredAscension}。", 16, _muted));
            var chars = GameBridge.Characters();
            var selection = Card(); selection.Name = "MatchCharacterSelection";
            selection.AddThemeStyleboxOverride("panel", CareerVisuals.Box("102b39", "47788a", 10, 20)); box.AddChild(selection);
            var choices = Inner(selection); choices.AddChild(Text("出战角色", 25, _gold));
            choices.AddChild(Text("点击角色进行选择，亮起的卡片就是本场使用的角色。", 16, _muted));
            int selectedCharacter = data.RandomCharacter ? chars.Count : Math.Max(0, chars.FindIndex(c => c.Id.ToString() == data.SelectedCharacter));
            var characterGrid = new GridContainer { Columns = 3, SizeFlagsHorizontal = SizeFlags.ExpandFill };
            characterGrid.AddThemeConstantOverride("h_separation", 12); characterGrid.AddThemeConstantOverride("v_separation", 12); choices.AddChild(characterGrid);
            var characterButtons = new List<Button>();
            var selectedLabel = Text("", 18, CareerVisuals.Teal);
            void SelectCharacter(int index)
            {
                selectedCharacter = index;
                for (int j = 0; j < characterButtons.Count; j++) characterButtons[j].SetPressedNoSignal(j == index);
                if (chars.Count > 0) selectedLabel.Text = index == chars.Count ? "随机角色 · 开赛时确定" : "已选择：" + chars[index].Title.GetFormattedText();
            }
            void ChooseCharacter(int index)
            {
                bool random = index == chars.Count;
                if (MultiplayerCommand("character", random ? CareerEngine.RandomCharacterChoice : chars[index].Id.ToString())) return;
                SelectCharacter(index); data.RandomCharacter = random;
                if (!random) data.SelectedCharacter = chars[index].Id.ToString();
                CareerStore.Save(data);
            }
            for (int i = 0; i < chars.Count; i++)
            {
                int index = i; string title = chars[i].Title.GetFormattedText();
                var choice = Button("", () => ChooseCharacter(index), 0);
                choice.Name = "MatchCharacter_" + i; choice.ToggleMode = true; choice.CustomMinimumSize = new Vector2(0, 80); choice.SizeFlagsHorizontal = SizeFlags.ExpandFill;
                var inner = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore };
                choice.AddChild(inner); inner.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect); inner.OffsetLeft = 18; inner.OffsetRight = -18; inner.OffsetTop = 10; inner.OffsetBottom = -10;
                inner.AddThemeConstantOverride("separation", 16);
                inner.AddChild(new CareerAvatar { Art = AvatarAssets.Load(title, 0, false), CustomMinimumSize = new Vector2(48, 48), SizeFlagsVertical = SizeFlags.ShrinkCenter, MouseFilter = MouseFilterEnum.Ignore });
                var name = Text(title, 22, _ink); name.SizeFlagsHorizontal = SizeFlags.ExpandFill; name.SizeFlagsVertical = SizeFlags.ShrinkCenter; name.MouseFilter = MouseFilterEnum.Ignore; inner.AddChild(name);
                characterButtons.Add(choice); characterGrid.AddChild(choice);
            }
            var randomCharacter = Button("随机角色", () => { if (chars.Count > 0) ChooseCharacter(chars.Count); }, 240);
            randomCharacter.Name = "MatchRandomCharacter"; randomCharacter.Disabled = chars.Count == 0;
            randomCharacter.ToggleMode = true;
            randomCharacter.TooltipText = "开赛时从当前可用角色中随机确定，包含已启用的模组角色；继续比赛沿用存档角色。";
            characterButtons.Add(randomCharacter); characterGrid.AddChild(randomCharacter);
            choices.AddChild(selectedLabel); SelectCharacter(selectedCharacter);
            if (chars.Count == 0) selectedLabel.Text = "没有可用角色。";
            var ascRow = new HBoxContainer(); ascRow.AddThemeConstantOverride("separation", 12); box.AddChild(ascRow);
            ascRow.AddChild(Text(_multiplayer == null ? "个人挑战进阶" : "全队挑战进阶", 17, _muted));
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
            ascRow.AddChild(asc);
            box.AddChild(Text($"比赛种子：{match.Seed}", 15, _muted));
            if (match.Decider.Length > 0) box.AddChild(Text(match.Decider, 18, _gold));
            bool due = match.Day <= data.Day;
            var controls = new HBoxContainer(); controls.AddThemeConstantOverride("separation", 12); box.AddChild(controls);
            var enter = TeamButton(due ? "开始比赛" : "跳转到比赛日", async () =>
            {
                if (!due) { if (MultiplayerCommand("propose-advance", number: CareerEngine.NextMatch(data)?.Day ?? data.Day + 1)) return; CareerEngine.AdvanceToMatch(data); Render(); return; }
                if (chars.Count == 0) { Notice("没有可用角色。", true); return; }
                if (MultiplayerCommand("propose-start", match.Id, number: (int)asc.Value)) return;
                if (_starting) return;
                _starting = true;
                var character = selectedCharacter == chars.Count ? GameBridge.RandomChoice() : chars[Math.Clamp(selectedCharacter, 0, chars.Count - 1)];
                var error = await GameBridge.StartMatch(match, character, (int)asc.Value);
                _starting = false;
                if (IsInstanceValid(this) && !IsQueuedForDeletion() && error != null) Notice(error, true);
            }, 220); Emphasize(enter); controls.AddChild(enter);
            if (_multiplayer == null && due && data.PendingMatchId == null)
            {
                controls.AddChild(Button("放弃本场", () => { CareerEngine.Forfeit(data, match); Render(); }, 160));
                // 真国运魔改尖塔：「模拟本场」用世界赛签表同一套 EsportsWorld.SimulatePlayerRun 替玩家打完这一场，
                // 再走 CareerEngine.FinishMatch 正常结算 —— 战报、社区帖、评分、粉丝、奖金、战绩、AI 统计都按真打一样记。
                // 只在单人、比赛日、没有进行中的对局时出现（与「放弃本场」同一条件）。
                var simulate = Button("模拟本场", () => SimulatePlayerMatch(data, match, (int)asc.Value, chars, selectedCharacter), 160);
                simulate.Name = "SimulateMatchButton";
                simulate.TooltipText = "不想亲自打？按你角色卡的属性、模拟通关率、未通关层数上限和模拟通关用时算一局，结果照常记为正式战绩（战报、评分、奖金、AI 统计都按真打一样记）。";
                controls.AddChild(simulate);
            }
            if (SaveManager.Instance.HasRunSave) box.AddChild(Text(MatchRecovery.SingleplayerInUse, 16, new Color("e7a6a6")));
            box.AddChild(Matchup(data, match));
        }
        else
        {
            var empty = Card(); _content.AddChild(empty); var eb = Inner(empty);
            bool available = CareerEngine.NextAvailable(data) != null;
            eb.AddChild(Text(available ? "尚未报名比赛" : "暂时没有可参赛比赛", 26, _gold));
            eb.AddChild(Text(available ? "可以从下方赛程报名，也可以继续推进日期。"
                : $"本赛季共 {SeasonCalendar.Length(data)} 天。没有比赛时仍可继续生活、等待后续赛程，或进入下个赛季。", 18, _ink));
            var actions = new HBoxContainer(); actions.AddThemeConstantOverride("separation", 12); eb.AddChild(actions);
            actions.AddChild(TeamButton("推进一天", () =>
            {
                if (MultiplayerCommand("propose-advance", number: data.Day + 1)) return;
                if (!CareerEngine.AdvanceOneDay(data)) Notice("请先完成或放弃当前比赛。", true);
                Render();
            }, 180));
            actions.AddChild(TeamButton("下个赛季", () =>
            {
                if (MultiplayerCommand("propose-advance", number: SeasonCalendar.End(data) + 1)) return;
                CareerEngine.AdvanceToDay(data, SeasonCalendar.End(data) + 1); Render();
            }, 180));
            eb.AddChild(Text("推进期间会在已报名的比赛日停下。", 15, _muted));
        }
        _content.AddChild(Button("查看赛事与俱乐部   ↗", () => OpenWorldSection("赛事总览"), 340));
        _content.AddChild(Text("本赛季赛程", 22, _gold));
        foreach (var m in data.Matches.Where(m => m.Day > SeasonCalendar.Start(data) && m.Day <= SeasonCalendar.End(data)))
        {
            var card = Card();
            var box = Inner(card);
            var entryReason = EsportsWorld.EntryReason(data, m);
            var status = m.Status == "待赛" ? (m.Registered ? "已报名" : entryReason == null ? "可报名" : "资格未满足") : m.Status;
            box.AddChild(WithAvatar(data, m.OpponentId, Text($"第 {SeasonCalendar.Day(data, m.Day)} 天  ·  {m.Event}  ·  对手 {CareerEngine.DisplayName(data, m.OpponentId)}  ·  {status}", 17, m.Status == "待赛" ? _ink : _muted), 40, true));
            box.AddChild(Text($"{EsportsWorld.StageName(m.Kind)}    ·    最低进阶 {m.RequiredAscension}    ·    {(data.Esports.Competitions.Any(c => c.Id == m.CompetitionId && c.Kind == "worldfinal" && c.PrizeVersion >= 1) ? "按最终名次领取奖金" : "单场奖金 " + CareerMoney.Format(m.Prize))}", 14, _muted));
            if (m.Status == "待赛" && m.Day >= data.Day)
            {
                if (entryReason != null && !m.Registered) box.AddChild(Text(entryReason, 16, _muted));
                else if (!(m.Registered && m.Kind is "league" or "continental" or "worldcup" or "worldfinal"))
                    box.AddChild(TeamButton(m.Registered ? "取消报名" : m.Kind == "league" ? "报名联赛" : "确认报名", () => { if (MultiplayerCommand("propose-register", m.Id, number: m.Registered ? 0 : 1)) return; var error = CareerEngine.SetRegistration(data, m, !m.Registered); Render(); if (error != null) Notice(error, true); }, 250));
            }
            _content.AddChild(card);
        }
        _content.AddChild(Text("完整积分榜", 22, _gold));
        int rank = 0;
        foreach (var standing in EsportsWorld.PlayerLeague(data) is { PlayerEntered: true } currentLeague ? EsportsWorld.Ranked(currentLeague) : Enumerable.Empty<CareerStanding>())
        {
            rank++;
            var card = Card();
            Inner(card).AddChild(WithAvatar(data, standing.PersonId, Text($"{rank:00}   {CareerEngine.DisplayName(data, standing.PersonId)}   ·   {standing.Points} 分   ·   {standing.Wins} 胜 {standing.Losses} 负", 17, standing.PersonId == "player" ? _gold : _ink), 40, true));
            _content.AddChild(card);
        }
        if (data.SeasonHistory.Count > 0)
        {
            _content.AddChild(Text("赛季荣誉", 22, _gold));
            foreach (var recap in data.SeasonHistory.TakeLast(3).Reverse())
                _content.AddChild(Text($"第 {recap.Season} 赛季  ·  {(recap.Rank == 0 ? "未参加职业联赛" : $"第 {recap.Rank} 名")}  ·  {recap.Points} 分  ·  奖金 {CareerMoney.Format(recap.Prize)}", 17, _ink));
        }
    }

    // 「模拟本场」：用世界赛签表同一套 EsportsWorld.SimulatePlayerRun 替玩家打完这一场，
    // 再走 CareerEngine.FinishMatch 正常结算 —— 战报、社区帖、评分、粉丝、奖金、战绩、AI 统计都按真打一样记。
    private void SimulatePlayerMatch(CareerData data, CareerMatch match, int ascension, List<CharacterModel> characters, int selected)
    {
        if (match.Status != "待赛" || match.Day != data.Day || data.PendingMatchId != null)
        {
            Notice("这场比赛现在不能模拟。", error: true);
            return;
        }
        CharacterModel? characterModel = null;
        if (characters.Count > 0)
            characterModel = selected >= 0 && selected < characters.Count ? characters[selected] : characters[CareerEngine.StableHash(match.Seed + ":sim-character") % characters.Count];
        string text = characterModel != null ? characterModel.Id.ToString() : data.PlayerCard?.Character ?? CareerAvatars.MainCharacter(data, "player");
        string character = GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == text)?.Title.GetFormattedText() ?? text;
        var runPerformance = EsportsWorld.SimulatePlayerRun(data, match.Day, ascension, match.Seed + ":player-sim");
        CareerEngine.FinishMatch(data, match, runPerformance.Cleared, abandoned: false, runPerformance.Floor, character, ascension, new List<string>(), runPerformance.Seconds, null, null, text);
        if (data.PendingSettlementId != match.Id)
        {
            Notice("模拟没有结算成功（比赛状态可能已变化）。", error: true);
            Render();
            return;
        }
        Notice($"本场已由程序模拟 —— {MatchRules.Performance(runPerformance.Cleared, runPerformance.Floor, runPerformance.Seconds)}。", false);
        if (_tab == "结算") Render(); else SwitchTab("结算");
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
        AddHeading("尖塔社区", "聊比赛，聊选手，也聊聊今天的新鲜事。");
        int failedNews = CommunityThreads.All(data).Count(p => p.AuthorId != "player" && p.NewsGeneration.State == "failed");
        if (failedNews > 1)
        {
            _content.AddChild(Text($"有 {failedNews} 篇帖子没能生成，可以重试。", 15, _muted));
            _content.AddChild(Button("重试失败的帖子", () => GenerateContent(() => { _ = AiService.RetryFailedNewsAsync(); }, true), 245));
        }
        WeeklyCarousel(data);
        var communityActions = new HBoxContainer();
        communityActions.AddThemeConstantOverride("separation", 12);
        _content.AddChild(communityActions);
        communityActions.AddChild(Button("查看活动公告与公开进展", () => Visit(() => { _tab = "生涯生活"; _lifeSection = "公开消息"; }), 300));
        communityActions.AddChild(Button("发表新帖", () => Visit(() => _postId = ComposePostId), 160));
        var readBriefs = Button("将简讯标为已读", () => { int count = CommunityThreads.MarkProgramRead(data); Render(); Notice($"已将 {count} 篇简讯标为已读。", false); }, 250);
        readBriefs.TooltipText = "将未由 AI 撰写、也没有玩家参与的内容标为已读。";
        communityActions.AddChild(readBriefs);
        var filters = new HBoxContainer(); _content.AddChild(filters);
        foreach (string filter in new[] { "全部", "比赛战报", "国际赛事", "俱乐部动态", "人物日常", "我的讨论", "未读更新" })
            filters.AddChild(FilterButton(filter, _communityFilter == filter, () => { _communityFilter = filter; _postLimit = 30; _scroll.ScrollVertical = 0; Render(); }, 110));
        var posts = (_communityFilter is "我的讨论" or "未读更新" ? CommunityThreads.All(data) : data.Posts).Where(p => _communityFilter switch { "我的讨论" => p.AuthorId == "player" || p.Replies.Any(r => r.AuthorId == "player"), "未读更新" => p.Revision > p.SeenRevision, "比赛战报" => p.EventKey.StartsWith("match"), "国际赛事" => p.Category == "国际赛事" || p.Category.Contains("洲际") || p.Category.Contains("世界杯"), "俱乐部动态" => p.Category is "转会" or "俱乐部", "人物日常" => p.Category is "训练日常" or "人物专访" or "人物日常", _ => true }).ToList();
        foreach (var post in posts.Take(_postLimit)) AddPostCard(data, post, true);
        if (posts.Count == 0) _content.AddChild(Text("这个频道暂时没有新动态。", 18, _muted));
        if (posts.Count > _postLimit) _content.AddChild(Button("显示更早动态", () => { _postLimit += 30; Render(); }, 190));
    }

    private void AddPostCard(CareerData data, CommunityPost post, bool full)
    {
        using var timing = UiPerformance.Measure(UiPerformance.Work.PostCard);
        var card = Card();
        var box = Inner(card);
        bool preparing = CommunityThreads.NewsPending(data, post);
        box.AddChild(WithAvatar(data, post.AuthorId, Text($"{post.Category}  ·  第 {post.Day} 天  ·  {CareerEngine.DisplayName(data, post.AuthorId)}  ·  {(preparing ? "正在撰写" : post.Replies.Count + " 条回复")}", 14, _muted), 48, true));
        var titleButton = Button(post.Title, () => OpenPost(post));
        titleButton.AutowrapMode = TextServer.AutowrapMode.WordSmart; titleButton.Alignment = HorizontalAlignment.Left; titleButton.SizeFlagsHorizontal = SizeFlags.ExpandFill; box.AddChild(titleButton);
        if (post.Revision > post.SeenRevision) box.AddChild(Text("● 有新内容", 14, new Color("f07878")));
        if (full && !preparing) box.AddChild(MentionText(data, post.Body, 17, _ink, post.RelatedPeople.Append(post.AuthorId)));
        RenderWorkStatus(box, post.NewsGeneration, () => GenerateContent(() => { _ = AiService.RetryNewsAsync(post.Id); }, true), "News_" + post.Id);
        if (post.AuthorId == "player" && post.NeedsReaction) RenderWorkStatus(box, post.ReactionGeneration, () => GenerateContent(() => { _ = AiService.ProcessInteractionsAsync([post.Id]); }, true), post.Id);
        _content.AddChild(card);
    }

    private void Profiles(CareerData data)
    {
        using var timing = UiPerformance.Measure(UiPerformance.Work.Profiles);
        _content.AddThemeConstantOverride("separation", 24);
        _content.AddChild(Text(_personId == null ? "选手名录" : "人物档案", 30, _gold));
        var selector = ProfileActions(); _content.AddChild(selector);
        selector.AddChild(Button("我的档案", () => OpenPerson("player"), 165));
        selector.AddChild(Button("选手名录", () => OpenProfileList(), 165));
        if (_multiplayer?.Host != false) selector.AddChild(Button("创建角色", () => OpenCharacterCard(data, null), 165));
        if (_personId == "player") { PlayerProfile(data); return; }
        if (_personId != null && CareerEngine.Person(data, _personId) is { } selectedPerson) { PersonProfile(data, selectedPerson); return; }
        var categories = ProfileActions(); _content.AddChild(categories);
        if (_multiplayer != null) categories.AddChild(FilterButton("真人队员", _profileFilter == "真人队员", () => OpenProfileList("真人队员"), 150));
        foreach (var filter in new[] { "国内职业", "国际职业", "青训", "主播与媒体", "退役与教练", "社区", "自建角色" })
            categories.AddChild(FilterButton(filter, _profileFilter == filter, () => OpenProfileList(filter), 150));
        var searchRow = new HBoxContainer(); searchRow.AddThemeConstantOverride("separation", 16); _content.AddChild(searchRow);
        var search = new LineEdit { Text = _profileQuery, PlaceholderText = "搜索 ID、姓名、国家或俱乐部", SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new Vector2(200, 46) }; searchRow.AddChild(search);
        void Search() { _profileQuery = search.Text.Trim(); _profileLimit = 36; Render(); }
        search.TextSubmitted += _ => Search(); searchRow.AddChild(Button("搜索", Search, 100));
        var people = data.People.Where(p => _profileQuery.Length > 0 || (_profileFilter switch { "真人队员" => data.HumanIds.Contains(p.Id), "国内职业" => EsportsWorld.IsProfessional(p) && p.Country == data.Esports.Country,
            "国际职业" => EsportsWorld.IsProfessional(p) && p.Country != data.Esports.Country, "青训" => p.Role == "青训选手",
            "主播与媒体" => p.Role is "主播" or "解说员" or "赛事记者", "退役与教练" => p.Role is "退役选手" or "教练" || ClubCoaching.IsCoach(p), "自建角色" => p.CreatedCard, _ => p.Role == "普通玩家" }))
            .Where(p => _profileQuery.Length == 0 || (p.Handle + string.Join(" ", p.HandleAliases) + p.Name + p.Country + EsportsWorld.ClubName(data, p.ClubId)).Contains(_profileQuery, StringComparison.OrdinalIgnoreCase)).OrderByDescending(p => p.Rating).ToList();
        _content.AddChild(Text($"当前：{(_profileQuery.Length > 0 ? "全名录搜索" : _profileFilter)} · 找到 {people.Count} 人 / 世界共 {data.People.Count} 人 · 当前显示 {Math.Min(_profileLimit, people.Count)} 人", 15, _muted));
        var grid = new GridContainer { Columns = 3, SizeFlagsHorizontal = SizeFlags.ExpandFill }; grid.AddThemeConstantOverride("h_separation", 14); grid.AddThemeConstantOverride("v_separation", 14); _content.AddChild(grid);
        AddProfileCards(data, grid, people.Take(_profileLimit));
        if (people.Count > _profileLimit) _content.AddChild(Button("显示更多人物", () => { int scroll = _scroll.ScrollVertical; _profileLimit += 36; Render(); _ = RestoreScrollAsync(scroll, _renderVersion); }, 210));
    }

    private void AiSettings(CareerData data)
    {
        _aiSettingsDirty = false;
        AddHeading("模组设置", "调整比赛与社区生成设置。");
        var matchCard = Card(); _content.AddChild(matchCard); var matchBox = Inner(matchCard);
        matchBox.AddChild(Text("局内 AI 水平", 24, _gold));
        int[] levels = [100, 1000, 10000];
        var levelPicker = new OptionButton { Name = "RivalLevel", CustomMinimumSize = new Vector2(0, 52), SizeFlagsHorizontal = SizeFlags.ExpandFill };
        foreach (string label in _multiplayer != null
            ? new[] { "下降一百倍 · 职业队伍约 1 小时 7 分 30 秒", "下降一千倍 · 职业队伍约 1 小时 30 分钟", "下降一万倍 · 职业队伍约 2 小时 15 分钟" }
            : new[] { "下降一百倍 · 职业选手约 45 分钟", "下降一千倍 · 职业选手约 1 小时", "下降一万倍 · 职业选手约 1 小时 30 分钟" }) levelPicker.AddItem(label);
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
        var card = Card(); _content.AddChild(card); var box = Inner(card);
        box.AddChild(Text("AI 内容设置", 24, _gold));
        if (_multiplayer is { Host: false }) { box.AddChild(Text("AI 由主机统一生成，你无需配置服务或密钥。帖子、解说与周刊会自动同步。", 20, _ink)); AddMultiplayerReportButton(box); return; }
        _aiStatus = AiSettingsPanel.Build(box, data.Ai,
            () => { SaveAiSettings(data); AiService.RefreshConcurrency(data.Ai); },
            () => GenerateContent(() => { _ = AiService.ProcessPendingAsync(data); }), () => OpenPromptSettings(data), Notice, () => _aiSettingsDirty = true);
        if (_multiplayer != null) { box.AddChild(Button("导入与导出生涯", OpenCareerLibrary, 280)); AddMultiplayerReportButton(box); return; }
        var debug = Card(); _content.AddChild(debug); var db = Inner(debug);
        db.AddChild(Text("生涯管理", 24, _gold));
        db.AddChild(Button("切换、导入与导出生涯", OpenCareerLibrary, 310));
        db.AddChild(Text("重新开始生涯会保留原版战绩、角色解锁和 AI 设置。", 16, _muted));
        var actions = new HBoxContainer(); db.AddChild(actions);
        actions.AddChild(Button("刷新游戏战绩", () => { PlayerArchive.Invalidate(); Notice("游戏战绩已刷新。", false); }, 190));
        var export = Button("导出问题报告", () => { try { ShowDiagnosticFile(CareerStore.ExportDiagnostics()); } catch (Exception e) { GD.PushWarning(e.ToString()); Notice("问题报告未能保存，请检查文件夹的写入权限。", true); } }, 190);
        export.TooltipText = "打包当前生涯、运行日志和近期 AI 对话，供反馈问题时附上。密钥会自动隐藏。";
        actions.AddChild(export);
        actions.AddChild(Button("重置当前生涯", () => { _confirmReset = true; Render(); }, 190));
        if (_confirmReset)
        {
            db.AddChild(Text("重新开始生涯？当前赛程、人物、帖子和生涯奖励都会重置。旧生涯会先备份，原版战绩和 AI 设置保留。正在进行的对局将不再计入这段生涯。", 18, new Color("e9b09a")));
            var confirm = new HBoxContainer(); db.AddChild(confirm);
            confirm.AddChild(Button("确认重置生涯", () =>
            {
                try { _boundData = CareerStore.ResetCareer(); ResetNavigation(); _confirmReset = false; _latestEvent = null; _scroll.ScrollVertical = 0; Render(); Notice("生涯已重新开始，旧生涯已备份。", false); }
                catch (Exception e) { GD.PushWarning(e.ToString()); Notice("生涯未能重置，请检查存档文件夹的写入权限。", true); }
            }, 210));
            confirm.AddChild(Button("取消", () => { _confirmReset = false; Render(); }, 120));
        }

    }

    // ───────────────────────── 生涯战绩记录编辑器 ─────────────────────────
    private sealed class CareerResultEditControls
    {
        public Label Index = null!;
        public Label Impact = null!;
        public SpinBox Day = null!;
        public LineEdit Event = null!;
        public LineEdit Opponent = null!;
        public LineEdit Character = null!;
        public SpinBox Ascension = null!;
        public SpinBox PlayedAscension = null!;
        public SpinBox Floor = null!;
        public SpinBox Seconds = null!;
        public SpinBox RatingDelta = null!;
        public SpinBox FansDelta = null!;
        public SpinBox Prize = null!;
        public LineEdit Seed = null!;
        public OptionButton Outcome = null!;
        public OptionButton Kind = null!;
        public OptionButton Win = null!;
        public OptionButton Verified = null!;
        public Button Remove = null!;
    }

    private static readonly string[] CareerResultOutcomeLabels = ["获胜", "平局", "失利", "退赛"];
    private static readonly string[] CareerResultKindLabels = ["league", "continental", "worldcup", "worldfinal", "masters", "legacy", "private-friendly", "private-challenge"];
    private static readonly string[] CareerResultYesNo = ["是", "否"];

    private static bool PrivateResultKind(string kind) => kind is "private-friendly" or "private-challenge";

    // 生涯总计里的胜/平/负是独立计数器（不是从记录重算的 —— 记录只保留最近 200 条），
    // 所以这里按"改一条记录就挪一格"的方式做增量同步，改结果/删记录/新增记录时总计跟着走。
    private static void AdjustResultCounters(CareerData data, string outcome, int delta)
    {
        if (delta == 0) return;
        if (outcome == "获胜") data.Wins = Math.Max(0, data.Wins + delta);
        else if (outcome == "平局") data.Draws = Math.Max(0, data.Draws + delta);
        else data.Losses = Math.Max(0, data.Losses + delta);
    }

    // 生涯战报的原始记录编辑器：改的就是 CareerData.Results，所以战报、战绩图、选手档案、
    // AI 上下文里的「已记录公开比赛」统计、以及从记录重算的最高通关进阶都会跟着变。
    private void OpenCareerResultsEditor(CareerData data)
    {
        if (_dialogOverlay != null) return;
        var viewData = data;
        var controls = new CareerResultEditControls();
        int index = viewData.Results.Count - 1;
        bool removing = false;
        ShowCareerDialog("编辑战绩记录", "改的是生涯战报的原始记录：战报、战绩图、选手档案、AI 上下文里的「已记录公开比赛」都读它；改结果或删/加记录时，生涯总计的胜/平/负会跟着挪一格，保存后还会按记录重算最高通关进阶。", () =>
        {
            Render();
            return true;
        }, "关闭", box =>
        {
            controls.Index = Text("", 15, CareerVisuals.Teal);
            box.AddChild(controls.Index);
            var hBoxContainer = new HBoxContainer();
            hBoxContainer.AddThemeConstantOverride("separation", 12);
            box.AddChild(hBoxContainer);
            hBoxContainer.AddChild(Button("← 更早一条", () => { if (index > 0) { index--; Load(); } }, 150));
            hBoxContainer.AddChild(Button("更新一条 →", () => { if (index < viewData.Results.Count - 1) { index++; Load(); } }, 150));
            hBoxContainer.AddChild(Button("最早", () => { index = 0; Load(); }, 100));
            hBoxContainer.AddChild(Button("最新", () => { index = viewData.Results.Count - 1; Load(); }, 100));
            var scrollContainer = new ScrollContainer
            {
                Name = "CareerResultFormScroll",
                CustomMinimumSize = new Vector2(0, Math.Clamp(GetViewportRect().Size.Y * 0.4f, 240f, 470f)),
                HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled,
                SizeFlagsHorizontal = SizeFlags.ExpandFill
            };
            box.AddChild(scrollContainer);
            var gridContainer = new GridContainer { Name = "CareerResultForm", Columns = 4, SizeFlagsHorizontal = SizeFlags.ExpandFill };
            gridContainer.AddThemeConstantOverride("h_separation", 18);
            gridContainer.AddThemeConstantOverride("v_separation", 12);
            scrollContainer.AddChild(gridContainer);
            controls.Day = FieldSpin(gridContainer, "日期（第几天）", 1, 9999, 1);
            controls.Event = FieldLine(gridContainer, "赛事 / 事件");
            controls.Opponent = FieldLine(gridContainer, "对手");
            controls.Character = FieldLine(gridContainer, "使用角色");
            controls.Ascension = FieldSpin(gridContainer, "赛事进阶（0-10）", 0, 10, 1);
            controls.PlayedAscension = FieldSpin(gridContainer, "实际挑战进阶（-1 未记录）", -1, 10, 1);
            controls.Floor = FieldSpin(gridContainer, "层数", 0, 9999, 1);
            controls.Seconds = FieldSpin(gridContainer, "用时（秒，-1 未记录）", -1, 7200, 1);
            controls.RatingDelta = FieldSpin(gridContainer, "评分变化", -500, 500, 1);
            controls.FansDelta = FieldSpin(gridContainer, "关注变化", -1000000, 1000000, 1);
            controls.Prize = FieldSpin(gridContainer, "奖金（美元）", 0, 100000000, 1);
            controls.Seed = FieldLine(gridContainer, "种子");
            controls.Outcome = FieldChoice(gridContainer, "结果", CareerResultOutcomeLabels);
            controls.Kind = FieldChoice(gridContainer, "赛事类型", CareerResultKindLabels);
            controls.Win = FieldChoice(gridContainer, "通关（本局是否打通）", CareerResultYesNo);
            controls.Verified = FieldChoice(gridContainer, "官方验证", CareerResultYesNo);
            controls.Impact = Text("", 14, _muted);
            box.AddChild(controls.Impact);
            var hBoxContainer2 = new HBoxContainer();
            hBoxContainer2.AddThemeConstantOverride("separation", 14);
            box.AddChild(hBoxContainer2);
            hBoxContainer2.AddChild(Button("保存本场", Save, 130));
            controls.Remove = Button("删除本场", RemoveEntry, 150);
            hBoxContainer2.AddChild(controls.Remove);
            hBoxContainer2.AddChild(Button("新增一场（以当前为模板）", AddEntry, 240));
            Load();
            void Field(string label, GridContainer target)
            {
                var label2 = Text(label, 15, _muted);
                target.AddChild(label2);
            }
            SpinBox FieldSpin(GridContainer target, string label, double min, double max, double step)
            {
                Field(label, target);
                var spinBox = new SpinBox { MinValue = min, MaxValue = max, Step = step, CustomMinimumSize = new Vector2(175, 42), SizeFlagsHorizontal = SizeFlags.ExpandFill };
                target.AddChild(spinBox);
                spinBox.ValueChanged += _ => RefreshImpact();
                return spinBox;
            }
            LineEdit FieldLine(GridContainer target, string label)
            {
                Field(label, target);
                var lineEdit = new LineEdit { CustomMinimumSize = new Vector2(175, 42), SizeFlagsHorizontal = SizeFlags.ExpandFill };
                lineEdit.AddThemeFontSizeOverride("font_size", 15);
                lineEdit.AddThemeColorOverride("font_color", _ink);
                lineEdit.AddThemeStyleboxOverride("normal", CareerVisuals.Box("0c1b27", "304e5d", 8, 10));
                lineEdit.AddThemeStyleboxOverride("focus", CareerVisuals.Box("10232e", "69bcb3", 8, 10));
                target.AddChild(lineEdit);
                lineEdit.TextChanged += _ => RefreshImpact();
                return lineEdit;
            }
            OptionButton FieldChoice(GridContainer target, string label, string[] options)
            {
                Field(label, target);
                var optionButton = new OptionButton { CustomMinimumSize = new Vector2(175, 42), SizeFlagsHorizontal = SizeFlags.ExpandFill };
                optionButton.AddThemeFontSizeOverride("font_size", 15);
                foreach (string option in options) optionButton.AddItem(option);
                target.AddChild(optionButton);
                optionButton.ItemSelected += _ => RefreshImpact();
                return optionButton;
            }
            void SelectChoice(OptionButton button, string[] options, string current)
            {
                button.Clear();
                int num = 0;
                bool flag = false;
                for (int j = 0; j < options.Length; j++)
                {
                    button.AddItem(options[j]);
                    if (options[j] == current) { num = j; flag = true; }
                }
                if (!flag && current.Length > 0) { button.AddItem(current); num = options.Length; }
                button.Selected = num;
            }
            string ChoiceText(OptionButton button) => button.Selected >= 0 && button.Selected < button.ItemCount ? button.GetItemText(button.Selected) : "";
            void RefreshImpact()
            {
                if (index < 0 || index >= viewData.Results.Count) return;
                int num = -1;
                for (int j = 0; j < viewData.Results.Count; j++)
                {
                    if (j == index) continue;
                    var other = viewData.Results[j];
                    if (other.Win && other.OfficialAscensionVerified && !PrivateAppointments.IsPrivate(other)) num = Math.Max(num, other.Ascension);
                }
                bool flag = controls.Win.Selected == 0;
                bool flag2 = controls.Verified.Selected == 0;
                int num2 = (int)controls.Ascension.Value;
                if (flag && flag2 && !PrivateResultKind(ChoiceText(controls.Kind))) num = Math.Max(num, num2);
                int num3 = (int)controls.PlayedAscension.Value;
                string text = num3 >= 0 ? num3.ToString() : flag2 ? num2.ToString() : "未记录";
                controls.Impact.Text = $"按当前编辑：最高通关进阶 → {num}（取「通关=是 且 官方验证=是 且 非私约」记录的赛事进阶最大值）；AI 统计里的实际挑战进阶 → {text}。";
            }
            void Load()
            {
                bool flag = index >= 0 && index < viewData.Results.Count;
                removing = false;
                controls.Remove.Text = "删除本场";
                if (!flag)
                {
                    controls.Index.Text = "还没有任何战绩记录 —— 点「新增一场」建一条空白记录。";
                    controls.Impact.Text = "";
                    return;
                }
                var current = viewData.Results[index];
                controls.Index.Text = $"第 {index + 1} / {viewData.Results.Count} 条记录 · 对局 {(current.MatchId.Length > 0 ? current.MatchId : "（无）")} · 赛事 {(current.CompetitionId.Length > 0 ? current.CompetitionId : "（无）")}";
                controls.Day.Value = Math.Clamp(current.Day, 1, 9999);
                controls.Event.Text = current.Event;
                controls.Opponent.Text = current.Opponent;
                controls.Character.Text = current.Character;
                controls.Ascension.Value = Math.Clamp(current.Ascension, 0, 10);
                controls.PlayedAscension.Value = Math.Clamp(current.PlayedAscension ?? -1, -1, 10);
                controls.Floor.Value = Math.Clamp(current.Floor, 0, 9999);
                controls.Seconds.Value = Math.Clamp(current.RunSeconds ?? -1.0, -1.0, 7200.0);
                controls.RatingDelta.Value = Math.Clamp(current.RatingDelta, -500, 500);
                controls.FansDelta.Value = Math.Clamp(current.FansDelta, -1000000, 1000000);
                controls.Prize.Value = Math.Clamp(current.Prize, 0, 100000000);
                controls.Seed.Text = current.Seed;
                SelectChoice(controls.Outcome, CareerResultOutcomeLabels, current.Outcome);
                SelectChoice(controls.Kind, CareerResultKindLabels, current.Kind);
                controls.Win.Selected = current.Win ? 0 : 1;
                controls.Verified.Selected = current.OfficialAscensionVerified ? 0 : 1;
                RefreshImpact();
            }
            void Save()
            {
                if (index < 0 || index >= viewData.Results.Count) return;
                var current = viewData.Results[index];
                string text = current.Outcome;
                current.Day = (int)controls.Day.Value;
                current.Event = controls.Event.Text.Trim();
                current.Opponent = controls.Opponent.Text.Trim();
                current.Character = controls.Character.Text.Trim();
                current.Ascension = (int)controls.Ascension.Value;
                int num = (int)controls.PlayedAscension.Value;
                current.PlayedAscension = num >= 0 ? num : null;
                current.Floor = (int)controls.Floor.Value;
                double num2 = controls.Seconds.Value;
                current.RunSeconds = num2 >= 0 ? num2 : null;
                current.RatingDelta = (int)controls.RatingDelta.Value;
                current.FansDelta = (int)controls.FansDelta.Value;
                current.Prize = (int)controls.Prize.Value;
                current.Seed = controls.Seed.Text.Trim();
                current.Outcome = ChoiceText(controls.Outcome);
                if (text != current.Outcome)
                {
                    AdjustResultCounters(viewData, text, -1);
                    AdjustResultCounters(viewData, current.Outcome, 1);
                }
                current.Kind = ChoiceText(controls.Kind);
                current.Win = controls.Win.Selected == 0;
                current.OfficialAscensionVerified = controls.Verified.Selected == 0;
                CareerResultsChanged(viewData);
                Load();
            }
            void AddEntry()
            {
                var entry = new CareerResult { Day = viewData.Day, Kind = "legacy", Outcome = "失利", OfficialAscensionVerified = true };
                if (index >= 0 && index < viewData.Results.Count)
                {
                    var template = viewData.Results[index];
                    entry.Kind = template.Kind;
                    entry.Outcome = template.Outcome;
                    entry.Win = template.Win;
                    entry.OfficialAscensionVerified = template.OfficialAscensionVerified;
                    entry.Opponent = template.Opponent;
                    entry.OpponentId = template.OpponentId;
                    entry.Character = template.Character;
                    entry.CharacterId = template.CharacterId;
                    entry.Ascension = template.Ascension;
                    entry.PlayedAscension = template.PlayedAscension;
                    entry.Floor = template.Floor;
                    entry.RunSeconds = template.RunSeconds;
                    entry.RatingDelta = template.RatingDelta;
                    entry.FansDelta = template.FansDelta;
                    entry.Prize = template.Prize;
                    entry.RewardMultiplier = template.RewardMultiplier;
                    entry.Seed = template.Seed;
                    entry.Event = template.Event;
                    entry.Cards = new List<string>(template.Cards);
                    entry.DeckSummary = new List<string>(template.DeckSummary);
                }
                viewData.Results.Add(entry);
                AdjustResultCounters(viewData, entry.Outcome, 1);
                index = viewData.Results.Count - 1;
                CareerResultsChanged(viewData);
                Load();
            }
            void RemoveEntry()
            {
                if (index < 0 || index >= viewData.Results.Count) return;
                if (!removing) { removing = true; controls.Remove.Text = "再点一次确认删除"; return; }
                removing = false;
                AdjustResultCounters(viewData, viewData.Results[index].Outcome, -1);
                viewData.Results.RemoveAt(index);
                if (index >= viewData.Results.Count) index = viewData.Results.Count - 1;
                CareerResultsChanged(viewData);
                Load();
            }
        }, showCancel: false);
    }

    private void CareerResultsChanged(CareerData data)
    {
        data.Esports.BestClear = data.Results.Where(r => r.Win && r.OfficialAscensionVerified && !PrivateAppointments.IsPrivate(r)).Select(r => r.Ascension).DefaultIfEmpty(-1).Max();
        if (data.PlayerCard != null)
        {
            // 记录里实际打通的最高进阶写回角色卡：卡片值决定模拟通关率（MatchRules.Evaluate 读 MaxAscension），
            // 不然会出现"改了记录 → 最高通关进阶变了，但模拟通关率还是旧的"。
            int best = data.Results.Where(r => r.Win).Select(r => r.PlayedAscension ?? (r.OfficialAscensionVerified ? r.Ascension : -1)).DefaultIfEmpty(-1).Max();
            if (best >= 0) data.PlayerCard.MaxAscension = Math.Clamp(best, 0, 10);
            data.PlayerCard.ClearBaselineDay = -1;
        }
        AvatarHonors.Capture(data);
        PersistCareerResults(data);
    }

    private void PersistCareerResults(CareerData data)
    {
        if (_multiplayer != null) return;
        try { CareerStore.Save(data); }
        catch (Exception error)
        {
            Diagnostics.Error("career-results.save", error);
            Notice("战绩记录未能写入存档，请重试。", error: true);
        }
    }

    // ───────────────────────── 私信「编辑关系」入口 ─────────────────────────
    private Control PrivateIdentityWithRelationEdit(CareerData data, string id)
    {
        var control = PrivateIdentity(data, id, showProfile: true);
        try
        {
            var button = FindProfileTextButton(control, "选手档案");
            if (button == null || button.GetParent() == null)
            {
                GD.PrintErr("[nationalspire] 找不到「选手档案」按钮，无法放置「编辑关系」入口");
                return control;
            }
            var parent = button.GetParent();
            var node = PrivateButton("编辑关系", OpenPrivateRelationDialog, 115);
            parent.AddChild(node);
            parent.MoveChild(node, button.GetIndex() + 1);
        }
        catch (Exception error)
        {
            GD.PrintErr("[nationalspire] 放置「编辑关系」入口失败：" + error);
        }
        return control;
    }

    private static Button? FindProfileTextButton(Node node, string text)
    {
        if (node is Button button && button.Text != null && button.Text.Contains(text)) return button;
        foreach (var child in node.GetChildren())
        {
            var found = FindProfileTextButton(child, text);
            if (found != null) return found;
        }
        return null;
    }

    private sealed class PrivateRelationEditControls
    {
        public SpinBox Spin = null!;
        public LineEdit Line = null!;
        public TextEdit Text = null!;
    }

    private void OpenPrivateRelationDialog()
    {
        if (_privateOverlay == null || _privatePerson.Length == 0) return;
        var data = ViewData;
        string id = _privatePerson;
        if (!PrivateMessages.CanChat(data, id)) return;
        var relation = PrivateMessages.Relation(data, id);
        var controls = new PrivateRelationEditControls();
        ShowCareerDialog("编辑关系", "好感 / 交往关系 / 对你的印象。保存后写入存档，并让 AI 重新整理这段记忆。", () =>
        {
            if (!PrivateMessages.CanChat(data, id)) return false;
            SavePrivateRelation(data, id, (int)controls.Spin.Value, controls.Line.Text, controls.Text.Text);
            return true;
        }, "保存", box =>
        {
            var hBoxContainer = new HBoxContainer();
            hBoxContainer.AddThemeConstantOverride("separation", 18);
            box.AddChild(hBoxContainer);
            var favourColumn = new VBoxContainer { CustomMinimumSize = new Vector2(150, 0), SizeFlagsHorizontal = SizeFlags.ShrinkBegin };
            favourColumn.AddThemeConstantOverride("separation", 6);
            hBoxContainer.AddChild(favourColumn);
            favourColumn.AddChild(PrivateLine("好感", 13, _muted));
            controls.Spin = new SpinBox
            {
                Name = "PrivateFavourEdit",
                MinValue = -100,
                MaxValue = 100,
                Step = 1,
                Value = relation.Favour,
                CustomMinimumSize = new Vector2(150, 42),
                TooltipText = "对你的好感 · -100 至 100"
            };
            favourColumn.AddChild(controls.Spin);
            var relationColumn = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };
            relationColumn.AddThemeConstantOverride("separation", 6);
            hBoxContainer.AddChild(relationColumn);
            relationColumn.AddChild(PrivateLine("交往关系", 13, _muted));
            controls.Line = new LineEdit
            {
                Name = "PrivateRelationshipEdit",
                Text = relation.Relationship,
                MaxLength = 40,
                CustomMinimumSize = new Vector2(0, 42),
                SizeFlagsHorizontal = SizeFlags.ExpandFill
            };
            controls.Line.AddThemeFontSizeOverride("font_size", 16);
            controls.Line.AddThemeColorOverride("font_color", _ink);
            controls.Line.AddThemeStyleboxOverride("normal", CareerVisuals.Box("0c1b27", "304e5d", 8, 12));
            controls.Line.AddThemeStyleboxOverride("focus", CareerVisuals.Box("10232e", "69bcb3", 8, 12));
            relationColumn.AddChild(controls.Line);
            var impressionColumn = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };
            impressionColumn.AddThemeConstantOverride("separation", 6);
            box.AddChild(impressionColumn);
            impressionColumn.AddChild(PrivateLine("对你的印象", 13, CareerVisuals.Teal));
            controls.Text = new TextEdit
            {
                Name = "PrivateImpressionEdit",
                Text = relation.Impression,
                CustomMinimumSize = new Vector2(0, 140),
                WrapMode = TextEdit.LineWrappingMode.Boundary,
                SizeFlagsHorizontal = SizeFlags.ExpandFill
            };
            controls.Text.AddThemeFontSizeOverride("font_size", 16);
            controls.Text.AddThemeColorOverride("font_color", _ink);
            controls.Text.AddThemeStyleboxOverride("normal", CareerVisuals.Box("0c1b27", "304e5d", 8, 12));
            controls.Text.AddThemeStyleboxOverride("focus", CareerVisuals.Box("10232e", "69bcb3", 8, 12));
            impressionColumn.AddChild(controls.Text);
            box.AddChild(PrivateLine("保存后写入存档，并让 AI 重新整理这段记忆；取消不改动任何内容。", 13, _muted));
        });
    }

    private void SavePrivateRelation(CareerData data, string id, int favour, string relationship, string impression)
    {
        if (!PrivateMessages.CanChat(data, id)) return;
        var relation = PrivateMessages.Relation(data, id);
        int value = Math.Clamp(favour, -100, 100);
        string text = relationship.Trim();
        string text2 = impression.Trim();
        if (relation.Favour == value && relation.Relationship == text && relation.Impression == text2) return;
        if (relation.Favour != value) PrivateMessages.ChangeFavour(data, id, value - relation.Favour);
        relation.Relationship = text;
        relation.Impression = text2;
        relation.Revision++;
        var conversation = PrivateMessages.Conversation(data, id);
        conversation.MemoryRevision++;
        conversation.SummaryError = "";
        _privateSignature = "";
        PersistPrivateRelation(data);
    }

    private void PersistPrivateRelation(CareerData data)
    {
        if (_multiplayer != null) return;
        try { CareerStore.Save(data); }
        catch (Exception error)
        {
            Diagnostics.Error("private-relation.save", error);
            if (_privateStatus != null && GodotObject.IsInstanceValid(_privateStatus)) { _privateStatus.Text = "关系档案未能写入存档，请重试。"; return; }
            Notice("关系档案未能写入存档，请重试。", error: true);
        }
    }

    private void AddHeading(string title, string description)
    {
        _content.AddChild(Text(title, 30, _gold));
        _content.AddChild(Text(description, 16, _muted));
    }

    private void Notice(string message, bool error)
    {
        _status.Text = message;
        _status.AddThemeColorOverride("font_color", error ? new Color("f29b9b") : _gold);
    }

    private static PanelContainer Card()
    {
        var card = new BroadcastPanel { SizeFlagsHorizontal = SizeFlags.ExpandFill, Theme = CareerVisuals.CreateTheme() };
        card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("142332"));
        return card;
    }

    private static VBoxContainer Inner(PanelContainer card)
    {
        var box = new VBoxContainer(); box.AddThemeConstantOverride("separation", 9); card.AddChild(box); return box;
    }

    private static Label Text(string text, int size, Color color)
    {
        var label = new Label { MouseFilter = MouseFilterEnum.Ignore, Text = CareerMoney.Display(text), AutowrapMode = TextServer.AutowrapMode.WordSmart, SizeFlagsHorizontal = SizeFlags.ExpandFill };
        label.AddThemeFontSizeOverride("font_size", size);
        label.AddThemeConstantOverride("line_spacing", 8);
        label.AddThemeColorOverride("font_color", color);
        return label;
    }

    private static Button Button(string text, Action action, float width = 0)
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
            float height = Math.Clamp(result.Floor / 55f, 0.03f, 1f) * (bottom - top);
            var color = result.Win ? new Color("efc777") : new Color("5b8098");
            DrawRect(new Rect2(left + i * slot + slot * .18f, bottom - height, slot * .64f, height), color);
        }
    }
}


