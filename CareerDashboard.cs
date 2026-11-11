using Godot;

namespace NationalSpire;

public partial class CareerScreen
{
    private HBoxContainer _sectionBar = null!;
    private Button _walletButton = null!;
    private Label _planDot = null!;
    private int _calendarMonth, _weekDay;
    private string _eventHeaderSelection = "", _styledRail = "";
    private string _calendarMode = "日程", _planKey = "", _planTarget = "", _board = "人气榜", _rankRegion = "";
    private string _fixtureScope = "国内赛事", _fixtureKind = "", _fixtureRegion = "", _fixtureInternational = "", _reviewId = "", _arenaMatchId = "";
    private bool _domesticMine = true, _otherRegionsMine, _showCalendarPlans;
    private bool MyFixtures
    {
        get => _fixtureScope == "其他地区" ? _otherRegionsMine : _domesticMine;
        set { if (_fixtureScope == "其他地区") _otherRegionsMine = value; else _domesticMine = value; }
    }
    private int _planScroll;
    private static readonly Dictionary<string, Texture2D> NavigationIcons = new();
    private static Texture2D? NavigationIcon(string key)
    {
        if (NavigationIcons.TryGetValue(key, out var icon)) return icon;
        using var stream = typeof(CareerScreen).Assembly.GetManifestResourceStream("NationalSpire.Navigation." + key + ".svg");
        if (stream == null) return null;
        using var reader = new System.IO.StreamReader(stream);
        using var image = new Image();
        if (image.LoadSvgFromString(reader.ReadToEnd(), 4) != Error.Ok) return null;
        return NavigationIcons[key] = ImageTexture.CreateFromImage(image);
    }
    private static Button CaptionButton(string label, Action action, bool selected = false)
    {
        var b = new Button { Text = label, MouseDefaultCursorShape = CursorShape.PointingHand, CustomMinimumSize = new(0,42) };
        b.Pressed += action; b.AddThemeStyleboxOverride("focus",new StyleBoxFlat { BgColor=Colors.Transparent,BorderWidthBottom=2,BorderColor=CareerVisuals.Teal });
        foreach (string style in ButtonStates)
        {
            var box = new StyleBoxFlat { BgColor = Colors.Transparent, BorderColor = CareerVisuals.Teal,
                BorderWidthBottom = selected || style == "hover" ? 2 : 0, ContentMarginLeft = 10, ContentMarginRight = 10,
                ContentMarginTop = 3, ContentMarginBottom = 5 };
            b.AddThemeStyleboxOverride(style, box);
        }
        if (selected) b.AddThemeColorOverride("font_color", CareerVisuals.Teal);
        return b;
    }
    private static Button UnderlineTab(string label, Action action, bool selected, int width=120, int size=20, bool gold=false, bool ranking=false)
    {
        var accent = gold ? CareerVisuals.Gold : CareerVisuals.Teal;
        var button = new Button { Text=label, MouseDefaultCursorShape=CursorShape.PointingHand,
            CustomMinimumSize=new(width,gold ? 54 : 44), SizeFlagsVertical=SizeFlags.ShrinkCenter };
        button.AddThemeFontOverride("font",DashboardTheme().DefaultFont); button.AddThemeFontSizeOverride("font_size",size);
        foreach (var state in ButtonStates)
            button.AddThemeStyleboxOverride(state,new StyleBoxEmpty { ContentMarginBottom=5 });
        button.AddThemeStyleboxOverride("focus", new StyleBoxEmpty());
        var normal = selected ? ranking ? CareerVisuals.Ink : accent : CareerVisuals.Muted;
        foreach (var state in new[]{"font_color","font_hover_color","font_pressed_color","font_hover_pressed_color","font_focus_color"})
            button.AddThemeColorOverride(state,normal);
        void ColorText(bool entered)
        {
            var color = entered && !selected ? CareerVisuals.Ink : normal;
            button.AddThemeColorOverride("font_hover_color",color);
            button.AddThemeColorOverride("font_focus_color",color);
            button.QueueRedraw();
        }
        button.MouseEntered += () => ColorText(true); button.MouseExited += () => ColorText(button.HasFocus());
        button.FocusEntered += () => ColorText(true); button.FocusExited += () => ColorText(button.IsHovered());
        button.Draw += () =>
        {
            float x = button.Size.X/2, half = ranking ? button.Size.X/2-10 : size;
            if (selected) button.DrawRect(new(x-half,button.Size.Y-4,2*half,3),accent);
            else if (button.HasFocus()) button.DrawLine(new(x-half,button.Size.Y-3),new(x+half,button.Size.Y-3),CareerVisuals.Muted);
        };
        button.Pressed += action;
        return button;
    }
    private const int MainWidth = 1423, HomeSideWidth = 328, HomeColumnGap = 27;
    private static HBoxContainer HomeButtonPair(string name)
    {
        var pair = new HBoxContainer { Name = name, CustomMinimumSize = new(HomeSideWidth, 0) };
        pair.AddThemeConstantOverride("separation", 10);
        return pair;
    }
    private static MarginContainer SecondaryTabInset(Container parent)
    {
        var inset = Inset(0, 5);
        parent.AddChild(inset);
        return inset;
    }
    private static HBoxContainer TabStrip(Container parent, int gap=20, bool baseline=false, bool secondary=false)
    {
        if (secondary) parent = SecondaryTabInset(parent);
        var strip = new HBoxContainer { SizeFlagsHorizontal=SizeFlags.ExpandFill, Alignment=BoxContainer.AlignmentMode.Center };
        strip.AddThemeConstantOverride("separation",gap);
        if (baseline) Baseline(strip);
        parent.AddChild(strip);
        return strip;
    }
    private Label _railMailCount = null!, _railPostCount = null!, _communityCaption = null!;
    private static Label RailCount(Button host)
    {
        var count=Text("",12,new Color("102030")); count.HorizontalAlignment=HorizontalAlignment.Center;
        count.VerticalAlignment=VerticalAlignment.Center; count.AutowrapMode=TextServer.AutowrapMode.Off;
        count.AddThemeStyleboxOverride("normal",CareerVisuals.Box("ef9295","0c1824",12,0));
        Put(host,count,53,4,21,21); count.Hide(); return count;
    }
    private static void SetRailCount(Label count,int value)
    {
        count.Visible=value>0; count.Text=value>99?"99+":value.ToString();
    }
    private static Label Dot(Control host)
    {
        var dot = Text("●", 15, new Color("f18589")); dot.MouseFilter = MouseFilterEnum.Ignore;
        host.AddChild(dot); dot.SetAnchorsAndOffsetsPreset(LayoutPreset.TopRight);
        dot.OffsetLeft = -20; dot.OffsetRight = -3; dot.OffsetTop = 0; return dot;
    }
    private static bool PendingPlans(CareerData d) => d.Life.Activities.Any(a => PendingInvitation(d, a));
    private static VBoxContainer FlatPanel(Container parent,string name,int height,string fill,int padding)
    {
        var panel=new PanelContainer { Name=name, CustomMinimumSize=new(0,height),SizeFlagsHorizontal=SizeFlags.ExpandFill };
        panel.AddThemeStyleboxOverride("panel",CareerVisuals.Box(fill,"344e5e",7,padding));
        parent.AddChild(panel);return Inner(panel);
    }
    private static void Put(Control parent, Control child, float x, float y, float width, float height)
    {
        parent.AddChild(child);
        child.Position = new(x,y); child.Size = new(width,height);
    }

    private static Texture2D? _brandTexture;
    private Button _railPortrait = null!;
    private CareerAvatar _railPortraitImage = null!;

    private static Texture2D? BrandTexture()
    {
        if (IsInstanceValid(_brandTexture)) return _brandTexture;
        using var stream = typeof(CareerScreen).Assembly.GetManifestResourceStream("NationalSpire.Navigation.brand-lockup.png");
        if (stream == null) return null;
        using var bytes = new System.IO.MemoryStream();
        using var image = new Image();
        stream.CopyTo(bytes);
        return image.LoadPngFromBuffer(bytes.ToArray()) == Error.Ok ? _brandTexture = ImageTexture.CreateFromImage(image) : null;
    }
    private void BuildDashboardShell()
    {
        // The stage scales as a unit. Coordinates here are its 1600 × 1000 design units.
        var brand = new VBoxContainer { Name = "CareerBrand", Alignment = BoxContainer.AlignmentMode.Center };
        brand.AddThemeConstantOverride("separation", 1);
        Put(_stage, brand, 28, 13, 94, 104);
        if (BrandTexture() is { } mark)
            brand.AddChild(new TextureRect { Texture = mark, CustomMinimumSize = new(76,80),
                ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered,
                MouseFilter = MouseFilterEnum.Ignore });
        var version = Text("v" + Diagnostics.ModVersion.TrimStart('v'), 12, _gold); version.HorizontalAlignment = HorizontalAlignment.Center; brand.AddChild(version);
        var frame = new Panel { Name = "CareerNavigationColumn", Theme=DashboardTheme() };
        frame.AddThemeStyleboxOverride("panel", CareerVisuals.Box("0c1824","2d4250",8,0));
        Put(_stage, frame, 28, 133, 94, 839);
        Button Rail(string key,string label,string icon,Action action,int y,int height=78)
        {
            var b = new BroadcastButton { Name="Rail"+icon, AccessibilityName=label, MouseDefaultCursorShape=CursorShape.PointingHand };
            b.Pressed+=action;
            bool settings=key=="模组设置";
            int size=settings ? 18 : 24;
            var mark=Glyph(icon,size,_muted);
            Put(b,mark,settings ? 12 : (76-size)/2,settings ? 18 : key=="社区" ? 12 : 14,size,size);
            var caption=DashboardLabel(label,13,Colors.White);
            caption.Name="RailCaption"; caption.HorizontalAlignment=HorizontalAlignment.Center;
            caption.VerticalAlignment=VerticalAlignment.Center;
            Put(b,caption,settings ? 32 : 0,settings ? 15 : key=="社区" ? 38 : 43,settings ? 36 : 76,21);
            b.Draw+=()=>{
                string state=b.IsHovered() ? "font_hover_color" : b.HasFocus() ? "font_focus_color" : "font_color";
                var color=b.GetThemeColor(state);
                mark.SelfModulate=color; caption.SelfModulate=color;
            };
            Put(frame,b,9,y,76,height); _navButtons[key]=b; return b;
        }
        Rail("首页","首页","house",()=>GoHub("首页"),21);
        Rail("赛事","赛事赛程","swords",()=>GoHub("赛事"),109);
        _planDot=Dot(Rail("日程","日程安排","calendar-days",()=>GoHub("日程"),197));
        Rail("生涯生活","消费投资","money-bag",()=>GoHub("生涯生活"),285);
        _railPortrait = (Button)Avatar(_boundData, "player", 48);
        _railPortrait.Name = "RailPortrait";
        _railPortraitImage = _railPortrait.GetChild<CareerAvatar>(0);
        Put(frame, _railPortrait, 23, 525, 48, 48);
        _privateBadge=Rail("通讯","私信","mail",()=>OpenPrivateMessages(),591);
        _updatesButton=Rail("社区","社区","messages-square",OpenCommunity,681,88);
        _railMailCount=RailCount(_privateBadge); _railPostCount=RailCount(_updatesButton);
        _communityCaption=DashboardLabel("",11,_gold); _communityCaption.Name="UpdateCount";
        _communityCaption.HorizontalAlignment=HorizontalAlignment.Center; _communityCaption.VerticalAlignment=VerticalAlignment.Center;
        Put(_updatesButton,_communityCaption,2,64,72,18);
        Put(frame,Hairline("748d9d59"),16,777,62,1);
        Rail("模组设置","设置","settings-2",()=>GoHub("模组设置"),782,55);
        var header = new HBoxContainer { Name = "CareerHeader", Theme = DashboardTheme() };
        const int headerGap = 16;
        header.AddThemeConstantOverride("separation", headerGap);
        Put(_stage, header, 148, 25, MainWidth, 72);
        _backButton = FramedAction("", Back, width: 41, height: 41, quiet: true);
        _backButton.Name = "CareerBack";
        _backButton.AccessibilityName = _backButton.TooltipText = "返回上一页";
        ButtonIcon(_backButton, "arrow-left", 27);
        _backButton.IconAlignment = HorizontalAlignment.Center;
        _backButton.SizeFlagsVertical = SizeFlags.ShrinkCenter;
        header.AddChild(_backButton);
        _pageTitle = DashboardLabel("", 26, _ink);
        _pageTitle.AddThemeFontOverride("font", CareerVisuals.InterfaceText(tracking: 2));
        header.AddChild(_pageTitle);
        _breadcrumb = Text("", 15, _muted); _breadcrumb.Hide(); header.AddChild(_breadcrumb);
        if (_multiplayer != null) header.AddChild(CaptionButton("队伍", () => { var team = _multiplayer; Close(); team.OpenRoom(); }));
        var dateSlot = new MarginContainer { SizeFlagsVertical = SizeFlags.ShrinkCenter };
        dateSlot.AddThemeConstantOverride("margin_bottom", 12);
        dateSlot.AddThemeConstantOverride("margin_right", HomeColumnGap - headerGap);
        header.AddChild(dateSlot);
        _seasonDate = TextLink("", () =>
        {
            if (_privateOverlay != null || _tab != "日程" || _calendarMode != "当日" || _selectedDay != ViewData.Day) OpenCalendarDay(ViewData.Day);
        },16);
        _seasonDate.Name = "SeasonDate"; _seasonDate.TooltipText = "查看今天的日程";
        _seasonDate.Alignment = HorizontalAlignment.Right;
        _seasonDate.SizeFlagsHorizontal = SizeFlags.ShrinkEnd;
        _seasonDate.CustomMinimumSize = new(0, 30);
        _seasonDate.AddThemeColorOverride("font_color",_muted); dateSlot.AddChild(_seasonDate);
        var utilities = HomeButtonPair("HeaderUtilities");
        utilities.SizeFlagsVertical = SizeFlags.ShrinkCenter;
        header.AddChild(utilities);
        _walletButton = FramedAction("", () => GoHub("我的资产"), height: 46, quiet: true);
        _walletButton.Name = "HeaderWallet";
        _walletButton.SizeFlagsHorizontal = SizeFlags.ExpandFill;
        _walletButton.ClipText = true;
        _walletButton.AddThemeColorOverride("font_color", _gold);
        _walletButton.AddThemeColorOverride("icon_normal_color", _gold);
        _walletButton.AddThemeFontSizeOverride("font_size", 18);
        ButtonIcon(_walletButton, "wallet", 20);
        utilities.AddChild(_walletButton);
        var menu = FramedAction("返回主菜单", Close, "arrow-up-right", trailing: true, height: 46, quiet: true, iconColor: _gold);
        menu.Name = "HeaderMainMenu";
        menu.SizeFlagsHorizontal = SizeFlags.ExpandFill;
        utilities.AddChild(menu);
        var exit = new Button { Flat=true, TooltipText="返回主菜单", MouseDefaultCursorShape=CursorShape.PointingHand };
        ButtonSurface(exit,"00000000","00000000","00000000","00000000"); exit.Pressed += Close; Put(_stage, exit, brand.Position.X, brand.Position.Y, brand.Size.X, brand.Size.Y);
        _status = Text("",16,_muted); _status.Hide(); _stage.AddChild(_status);
        var main = new VBoxContainer(); main.AddThemeConstantOverride("separation", 0);
        Put(_stage, main, 148, 133, MainWidth, 840);
        _notice = Text("",16,_gold); _notice.Hide(); main.AddChild(_notice);
        _sectionBar = new HBoxContainer { Alignment = BoxContainer.AlignmentMode.Center, MouseFilter=MouseFilterEnum.Ignore }; _sectionBar.AddThemeConstantOverride("separation",32);
        Baseline(_sectionBar);
        Put(_stage, _sectionBar, 148, 77, 1423, 52);
        _scroll = new BroadcastScroll { Name = "CareerContentScroll", SizeFlagsVertical = SizeFlags.ExpandFill, SizeFlagsHorizontal = SizeFlags.ExpandFill, HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled };
        main.AddChild(_scroll);
        _content = new VBoxContainer { Name = "CareerContent", SizeFlagsHorizontal = SizeFlags.ExpandFill }; _content.AddThemeConstantOverride("separation", 14);
        _scroll.AddChild(_content);
        // Reused panels can keep their minimum size when reattached. Refresh the scroll range as page children arrive and retire.
        _content.ChildOrderChanged += _scroll.QueueSort;
    }
    private void HomeIdentity(CareerData data,VBoxContainer side)
    {
        var body=new VBoxContainer {Alignment=BoxContainer.AlignmentMode.Center};
        body.AddThemeConstantOverride("separation",13);
        ActionRow(side,"HomeIdentity","个人档案",()=>OpenPerson("player"),body,284,21,18,"142632","3a5360","203744");
        var title=new HBoxContainer {MouseFilter=MouseFilterEnum.Ignore};
        title.AddThemeConstantOverride("separation",12); body.AddChild(title); title.AddChild(Avatar(data,"player",68,false));
        var copy=new VBoxContainer {Alignment=BoxContainer.AlignmentMode.Center,SizeFlagsHorizontal=SizeFlags.ExpandFill,MouseFilter=MouseFilterEnum.Ignore};
        copy.AddThemeConstantOverride("separation",5); title.AddChild(copy);
        copy.AddChild(DashboardLabel(CareerEngine.Name(data),24,_ink,true));
        copy.AddChild(DashboardLabel(data.Esports.Country+" · "+EsportsWorld.ClubName(data,data.Esports.ClubId),14,_muted,true));
        body.AddChild(Hairline("3a5360"));
        var stats=new HBoxContainer {MouseFilter=MouseFilterEnum.Ignore}; body.AddChild(stats);
        foreach (var (label,value) in new[]{("世界积分",CircuitLedger.Points(data,"player").ToString("N0")),("关注",data.Fans.ToString("N0"))})
        {
            var metric=new VBoxContainer {MouseFilter=MouseFilterEnum.Ignore, SizeFlagsHorizontal=SizeFlags.ExpandFill};
            metric.AddThemeConstantOverride("separation",3); stats.AddChild(metric);
            metric.AddChild(DashboardLabel(label,14,_muted)); metric.AddChild(DashboardLabel(value,24,_gold));
        }
        body.AddChild(Hairline("3a5360"));
        var honors = data.Esports.Honors.TakeLast(2).ToArray();
        for (int i = 0; i < 2; i++)
        {
            var row = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore, CustomMinimumSize = new(0, 21) };
            row.AddThemeConstantOverride("separation", 7); body.AddChild(row);
            if (i < honors.Length)
            {
                row.AddChild(Glyph("trophy", 15, _gold));
                var honor = DashboardLabel(honors[i].Title, 14, _gold);
                honor.SizeFlagsHorizontal = SizeFlags.ExpandFill;
                honor.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis;
                honor.TooltipText = honors[i].Title;
                row.AddChild(honor);
            }
            if (i == 1)
            {
                if (i >= honors.Length) row.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill, MouseFilter = MouseFilterEnum.Ignore });
                var link = ClubAffiliationLink(data, EsportsWorld.Club(data, data.Esports.ClubId), true);
                link.Name = "HomeClubLink"; row.AddChild(link);
            }
        }
    }

    private static void HomeInvitation(Container parent,string message,string action,Action open)
    {
        var box=new VBoxContainer {Alignment=BoxContainer.AlignmentMode.Center,SizeFlagsHorizontal=SizeFlags.ExpandFill,SizeFlagsVertical=SizeFlags.ExpandFill};
        box.AddThemeConstantOverride("separation",6); parent.AddChild(box);
        box.AddChild(DashboardLabel(message,16,CareerVisuals.Muted));
        box.AddChild(TextLink(action,open,16,icon:"arrow-up-right"));
    }

    private void GoHub(string tab)
    {
        if (_privateOverlay == null && _tab == tab && (tab != "日程" || _calendarMode == "日程") && (tab != "生涯生活" || _lifeSection == "消费商城") && (tab != "赛事" || _arenaMatchId.Length == 0)) return;
        Visit(() => { _tab = tab; _competitionId = null; _reviewId = ""; _arenaMatchId = ""; _personId = null; _postId = null;
            if (tab == "生涯生活") _lifeSection = "消费商城";
            if (tab == "日程") { _calendarMode = "日程"; _calendarMonth = 0; _selectedDay = ViewData.Day; ClearPlan(); }
        });
    }
    private bool EventHub => _tab is "赛事" or "赛程" || _tab == "赛事与俱乐部" && (_competitionId != null || _worldSection is "赛事总览" or "俱乐部" or "所属俱乐部" or "晋级规则");
    private string ActiveRail => _privateOverlay != null ? "通讯" : EventHub || _tab == "结算" ? "赛事" : _tab == "赛事与俱乐部" && _worldSection is "国运榜" or "国家发展" or "世界荣誉" ? "生涯生活" : _tab;
    private void UpdateHeaderAccount(CareerData d)
    {
        BindPortrait(d, "player", _railPortraitImage, _railPortrait);
        _seasonDate.Text = $"赛季 {d.Season:00}  ·  {GameCalendar.Date(d,d.Day):yyyy.MM.dd}";
        _walletButton.Text = _walletButton.TooltipText = CareerMoney.Format(CareerMoney.Balance(d));
        _seasonDate.Disabled = _walletButton.Disabled = d.Failure != null;
    }
    private void DashboardHeader(CareerData d)
    {
        _backButton.Visible = CanGoBack && (_tab != "结算" || !IsLatestReview(d));
        UpdateHeaderAccount(d);
        _planDot.Visible = AvailablePlans(d);
        _pageTitle.Text = _tab switch { "首页"=>"生涯大厅","日程"=>"日程安排","赛事"=>"赛事赛程","赛程"=>"赛程","生涯生活" => _lifeSection == "公开消息" ? "公开消息" : "消费投资",
            "赛事与俱乐部" when _competitionId==null && _worldSection is "赛事总览" or "晋级规则" => "赛事信息",
            "赛事与俱乐部" => _worldSection, "选手档案" or "创建角色" => "档案馆", "社区" => "尖塔社区", _=>_tab };
        bool life = _tab == "生涯生活" && _lifeSection is "消费商城" or "我的空间" or "交易市场" or "国运榜" or "国家发展" or "世界荣誉";
        bool profiles = _tab is "选手档案" or "创建角色";
        _sectionBar.Visible = EventHub || life || profiles;
        if (!_sectionBar.Visible) return;
        string[] names = profiles ? ["我的档案","选手名录","创建角色"]
            : life ? ["商城","投资","国运"] : ["开赛","赛程","俱乐部","赛事信息"];
        string active = life ? _lifeSection switch { "消费商城" or "我的空间" => "商城", "交易市场" => "投资", _ => "国运" }
            : profiles ? (_tab == "创建角色" ? "创建角色" : _personId == "player" ? "我的档案" : "选手名录")
            : _tab=="赛事"?"开赛":_tab=="赛程"?"赛程":_worldSection is "俱乐部" or "所属俱乐部"?"俱乐部":"赛事信息";
        bool guest = profiles && _multiplayer?.Host == false;
        string selection = guest ? active + "/guest" : active;
        if (_eventHeaderSelection==selection) return;
        _eventHeaderSelection=selection;
        CareerVisuals.ClearContent(_sectionBar);
        void Select(string name)
        {
            switch (name)
            {
                case "我的档案": OpenPerson("player"); break;
                case "选手名录": OpenProfileList(); break;
                case "创建角色": OpenProfileCreator(); break;
                case "商城": OpenLifePage("消费商城"); break;
                case "投资": OpenLifePage("交易市场"); break;
                case "国运": OpenLifePage("国运榜"); break;
                case "开赛": GoHub("赛事"); break;
                case "赛程": GoHub("赛程"); break;
                case "俱乐部": OpenWorldSection("俱乐部"); break;
                case "赛事信息": OpenWorldSection("赛事总览"); break;
            }
        }
        foreach (var name in names)
        {
            var tab = UnderlineTab(name, () => Select(name), active==name,120,23,true);
            if (name == "创建角色" && guest)
            {
                tab.Disabled = true; tab.TooltipText = "由房主创建角色";
                tab.MouseDefaultCursorShape = CursorShape.Arrow;
            }
            _sectionBar.AddChild(tab);
        }
    }
    private void OpenLifePage(string name)
    {
        if(_tab!="生涯生活" || _lifeSection!=name) Visit(()=>{ _tab="生涯生活"; _lifeSection=name; });
    }
    private void ClearPlan() { _planKey=""; _planTarget=""; _planScroll=0; }
}
