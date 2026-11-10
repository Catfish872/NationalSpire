using Godot;

namespace NationalSpire;

public partial class BracketColumns : HBoxContainer
{
    private readonly List<List<Control>> _slots=[];
    private readonly HashSet<Control> _advanced = [];
    private Control? _invitation;
    public void ConnectInvitation(Control invitation) => _invitation=invitation;
    public void MarkAdvanced(Control slot) => _advanced.Add(slot);
    public void AddSlot(int round,Control slot)
    {
        while(_slots.Count<round)_slots.Add([]);
        _slots[round-1].Add(slot);
    }
    public override void _Notification(int what)
    {
        if(what==NotificationSortChildren)CallDeferred(CanvasItem.MethodName.QueueRedraw);
    }
    public override void _Draw()
    {
        var inverse=GetGlobalTransform().AffineInverse();
        for(int round=1;round<_slots.Count;round++)
        for(int i=0;i<_slots[round-1].Count;i++)
        {
            if(i/2>=_slots[round].Count)continue;
            var src=_slots[round-1][i].GetGlobalRect();var dest=_slots[round][i/2].GetGlobalRect();
            var a=inverse*new Vector2(src.End.X,src.GetCenter().Y);var b=inverse*new Vector2(dest.Position.X,dest.GetCenter().Y);
            float mid=(a.X+b.X)/2;
            DrawPolyline([a,new(mid,a.Y),new(mid,b.Y),b],_advanced.Contains(_slots[round-1][i]) ? new Color("80bdb599") : new Color("71899688"),1.5f,true);
        }
        if (_invitation!=null && _slots.LastOrDefault()?.FirstOrDefault() is { } final)
        {
            var from=final.GetGlobalRect(); var to=_invitation.GetGlobalRect();
            var a=inverse*new Vector2(from.End.X,from.GetCenter().Y);
            var b=inverse*new Vector2(to.Position.X,to.GetCenter().Y);
            DrawDashedLine(a,new(b.X,a.Y),CareerVisuals.Gold,1.5f,5);
        }
    }
}

public partial class FixtureTimelineRow : HBoxContainer
{
    public bool FirstOfDay {get;init;}
    private Tween? _fade;
    private float _light;
    public void Highlight(bool active)
    {
        _fade?.Kill(); _fade = CreateTween().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Cubic);
        _fade.TweenMethod(Callable.From<float>(value => { _light = value; QueueRedraw(); }), _light, active ? 1f : 0f, .16);
    }
    public override void _Draw()
    {
        if (_light>.001f) DrawRect(new Rect2(0,1,Size.X,Size.Y-2),new Color(new Color("28495a"),.86f*_light));
        DrawLine(new(156,Size.Y-1),new(Size.X-10,Size.Y-1),new Color("45627188"),1);
        DrawLine(new(13,0),new(13,Size.Y),new Color("68909b80"),1,true);
        if(FirstOfDay) DrawCircle(new(13,Size.Y/2),4,new Color("96c9d4"));
        if (_light <= .001f) return;
        DrawLine(new(0,Size.Y-2),new(Size.X*_light,Size.Y-2),new Color(CareerVisuals.Teal,_light),2,true);
    }
    public override void _ExitTree() => _fade?.Kill();
}

public partial class CareerScreen
{
    private const int FixtureActionWidth = 120, FixtureRowGap = 16, FixtureEndInset = 5;
    private int _fixtureLimit = 75;
    private static bool IsInternationalCup(WorldCompetition cup) =>
        cup.Country == "国际" || cup.Kind is "continental" or "worldcup" or "worldfinal" or "masters";
    private sealed record FixtureEntry(int Day, string Title, string Kind, string Country, CareerMatch? Match, WorldCompetition? Cup, WorldFixture? Fixture);
    private int _fixtureSeason;
    private Predicate<FixtureEntry>? _fixtureFocus;
    private void OpenMatchFixture(CareerData data, CareerMatch match)
    {
        var cup = data.Esports.Competitions.FirstOrDefault(c => c.Id == match.CompetitionId);
        OpenFixtureFor(data, match.Day, cup, match);
    }

    private void OpenFixtureFor(CareerData d, int day, WorldCompetition? cup, CareerMatch? match = null)
    {
        Visit(() =>
        {
            _tab="赛程"; _fixtureLimit=75;
            int season=cup?.Season ?? GameCalendar.Season(d,day);
            _fixtureSeason=season==d.Season ? 0 : season;
            if (cup!=null && IsInternationalCup(cup))
            {
                _fixtureScope="国际赛事"; _fixtureInternational=cup.Id; return;
            }
            bool abroad=cup!=null && cup.Country!=d.Esports.Country;
            _fixtureScope=abroad ? "其他地区" : "国内赛事"; _fixtureRegion=abroad ? cup!.Country : "";
            _fixtureKind=match==null || cup!=null && cup.Fixtures.Any(f=>f.Id==match.FixtureId) ? cup!.Kind : match.Kind;
            if (match==null || !match.Registered && EsportsWorld.EntryReason(d,match)!=null) MyFixtures=false;
            _fixtureFocus=match!=null ? e=>e.Match?.Id==match.Id : e=>e.Cup?.Id==cup!.Id && e.Day==day;
        });
    }

    private void FixtureSchedule(CareerData d)
    {
        _content.AddThemeConstantOverride("separation",13);
        var tabs=TabStrip(_content,30,secondary:true);
        foreach (var scope in new[]{"国内赛事","国际赛事","其他地区"})
            tabs.AddChild(UnderlineTab(scope,()=>{ _fixtureScope=scope; _fixtureKind=""; _fixtureSeason=0; _fixtureLimit=75; Render(); }, _fixtureScope==scope));
        int fixtureSeason=_fixtureScope=="国际赛事" || _fixtureSeason==0 ? d.Season : _fixtureSeason;
        var cups = d.Esports.Competitions.Where(c=>c.Season==fixtureSeason).ToList();
        if (_fixtureScope=="国际赛事")
        {
            var selected = d.Esports.Competitions.FirstOrDefault(c => c.Id == _fixtureInternational && IsInternationalCup(c));
            int season = selected?.Season ?? d.Season;
            var international = d.Esports.Competitions.Where(c => c.Season == season && IsInternationalCup(c)).ToList();
            if (season == d.Season && cups.Any(c => c.Modern && c.Kind == "league"))
            {
                void AddScheduled(string kind)
                {
                    if (international.Any(c => c.Kind == kind)) return;
                    // Pairings are published after domestic qualification. This view never enters the save.
                    international.Add(new WorldCompetition {
                        Id = $"{kind}-{d.Season}", Kind = kind, Name = EsportsWorld.StageName(kind), Country = "国际",
                        Season = d.Season, CalendarStart = SeasonCalendar.Start(d), CalendarDays = SeasonCalendar.Length(d),
                        TeamEvent = kind != "worldfinal", Modern = true
                    });
                }
                if (CircuitWorld.HasWorldFinal(d.Season)) AddScheduled("worldfinal");
                AddScheduled(CircuitWorld.InternationalTeamCup(d.Season));
            }
            var cup = international.FirstOrDefault(c=>c.Id==_fixtureInternational) ?? international.FirstOrDefault();
            var picks = new HBoxContainer { CustomMinimumSize = new(0, 52) };
            picks.AddThemeConstantOverride("separation", 10);
            _content.AddChild(picks);
            if (season < d.Season)
            {
                picks.AddChild(TextLink("返回当前赛季", () => { _fixtureInternational = ""; Render(); }, 16, underline: true));
                var edition = DashboardLabel($"第 {season} 赛季", 16, _gold);
                edition.SizeFlagsHorizontal = SizeFlags.ShrinkBegin;
                picks.AddChild(edition);
            }
            foreach (var entry in international)
            {
                bool selectedCup = cup == entry;
                var pick = FramedAction(entry.Name, () => {
                    if (!selectedCup) { _fixtureInternational = entry.Id; Render(); }
                }, height: 42);
                pick.SizeFlagsVertical = SizeFlags.ShrinkCenter;
                ButtonSurface(pick, selectedCup ? "24464b" : "15232f", selectedCup ? "698e90" : "354b58", "294553", "80c7c5", 7);
                if (selectedCup) pick.AddThemeColorOverride("font_color", CareerVisuals.Teal);
                picks.AddChild(pick);
            }
            if(cup!=null) InternationalBracket(d,cup,picks); else _content.AddChild(Text("本赛季的国际赛事签表尚未公布。",18,_muted));
            return;
        }
        int start=SeasonCalendar.Start(d,fixtureSeason)+1,end=start+SeasonCalendar.Length(d,fixtureSeason)-1;
        var matches=d.Matches.Where(m=>m.Day>=start && m.Day<=end).ToList();
        var bindings=matches.Where(m=>m.FixtureId.Length>0).ToLookup(m=>(m.CompetitionId,m.FixtureId));
        bool domestic = _fixtureScope == "国内赛事";
        bool InScope(string country, CareerMatch? match) => domestic
            ? country == d.Esports.Country || country == "国际" && match != null
            : country != d.Esports.Country && country != "国际";
        var scheduled = new List<FixtureEntry>();
        var matched = new HashSet<string>();
        foreach (var c in cups)
        foreach (var f in c.Fixtures)
        {
            var m = bindings[(c.Id, f.Id)].FirstOrDefault();
            if (m != null) matched.Add(m.Id);
            if (InScope(c.Country, m)) scheduled.Add(new(f.Day, c.Name, c.Kind, c.Country, m, c, f));
        }
        foreach (var m in matches)
        {
            if (matched.Contains(m.Id)) continue;
            var c = cups.FirstOrDefault(c => c.Id == m.CompetitionId);
            string country = c?.Country ?? d.Esports.Country;
            if (InScope(country, m)) scheduled.Add(new(m.Day, m.Event, m.Kind, country, m, c, null));
        }
        var rows = scheduled.OrderBy(e => e.Day).ThenBy(e => e.Title).ToList();
        var filterBand=Inset(4,10); filterBand.Name="FixtureFilters"; _content.AddChild(filterBand); Baseline(filterBand);
        var filters=new HBoxContainer(); filters.AddThemeConstantOverride("separation",12); filterBand.AddChild(filters);
        if (fixtureSeason!=d.Season)
        {
            filters.AddChild(TextLink("返回当前赛季",()=>{_fixtureSeason=0;_fixtureLimit=75;Render();},15,underline:true));
            var edition=DashboardLabel($"第 {fixtureSeason} 赛季",15,_gold);
            edition.SizeFlagsHorizontal=SizeFlags.ShrinkBegin; filters.AddChild(edition);
        }
        OptionButton Picker(string name,int width)
        {
            var picker=new OptionButton {Name=name,CustomMinimumSize=new(width,36),FitToLongestItem=false,
                SizeFlagsVertical=SizeFlags.ShrinkCenter,MouseDefaultCursorShape=CursorShape.PointingHand};
            picker.AddThemeFontSizeOverride("font_size",15);
            ButtonSurface(picker,"172a37","395365","28434c","658c91",5,5);
            picker.AddThemeConstantOverride("arrow_margin",8); filters.AddChild(picker); return picker;
        }
        filters.AddChild(Glyph("list-filter",19,CareerVisuals.Teal));
        var filterTitle=DashboardLabel("赛事种类",15,_muted);filterTitle.AutowrapMode=TextServer.AutowrapMode.Off;filterTitle.SizeFlagsHorizontal=SizeFlags.ShrinkBegin;filters.AddChild(filterTitle);
        var kinds=rows.Select(e=>e.Kind).Distinct().Prepend("").ToList();
        var select=Picker("FixtureKind",174);
        foreach(var kind in kinds) select.AddItem(kind.Length==0?"全部赛事":EsportsWorld.StageName(kind));
        select.Select(Math.Max(0,kinds.IndexOf(_fixtureKind))); select.ItemSelected+=i=>{_fixtureKind=kinds[(int)i];_fixtureLimit=75; Render();};
        if(!domestic)
        {
            var regionTitle=DashboardLabel("赛区",15,_muted); regionTitle.SizeFlagsHorizontal=SizeFlags.ShrinkBegin; filters.AddChild(regionTitle);
            var regions=rows.Select(e=>e.Country).Distinct().Order().Prepend("").ToList();
            if(!regions.Contains(_fixtureRegion)) _fixtureRegion="";
            var region=Picker("FixtureRegion",138);
            foreach(var country in regions) region.AddItem(country.Length==0 ? "全部地区" : country);
            region.Select(regions.IndexOf(_fixtureRegion));
            region.ItemSelected+=i=>{_fixtureRegion=regions[(int)i];_fixtureLimit=75;Render();};
            if(_fixtureRegion.Length>0) rows=rows.Where(e=>e.Country==_fixtureRegion).ToList();
        }
        filters.AddChild(new Control {SizeFlagsHorizontal=SizeFlags.ExpandFill});
        var mine=DashboardSwitch("我的比赛",MyFixtures,value=>{ MyFixtures=value; _fixtureLimit=75; Render(); },FixtureActionWidth,37);
        filters.AddChild(mine);
        var completed = MyFixtures ? d.Results.Select(r => r.MatchId).ToHashSet() : null;
        rows=rows.Where(e=>(_fixtureKind.Length==0 || _fixtureKind==e.Kind) && (!MyFixtures || e.Match is { } m &&
            (m.Registered || completed!.Contains(m.Id) || m.Status=="待赛" && m.Day>=d.Day && EsportsWorld.EntryReason(d,m)==null))).ToList();
        if(rows.Count==0) _content.AddChild(Text("当前筛选下暂无赛事。",18,_muted));
        var scroll=new ScrollContainer {CustomMinimumSize=new(0,710),HorizontalScrollMode=ScrollContainer.ScrollMode.Disabled,
            VerticalScrollMode=ScrollContainer.ScrollMode.Reserve}; _content.AddChild(scroll);
        filterBand.AddThemeConstantOverride("margin_right", FixtureRowGap + FixtureEndInset + Mathf.RoundToInt(scroll.GetVScrollBar().GetCombinedMinimumSize().X));
        var timeline=new VBoxContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill};timeline.AddThemeConstantOverride("separation",0);scroll.AddChild(timeline);
        var focus=_fixtureFocus; _fixtureFocus=null;
        if (focus!=null) _fixtureLimit=Math.Max(_fixtureLimit,rows.FindIndex(focus)+1);
        foreach(var day in rows.Take(_fixtureLimit).GroupBy(e=>e.Day))
            foreach(var e in day)
            {
                AddFixtureRow(d,e,timeline,e==day.First());
                if (focus?.Invoke(e)==true)
                {
                    focus=null;
                    var target=timeline.GetChild<Control>(-1);
                    Callable.From(()=>{ if (IsInstanceValid(target) && target.IsInsideTree()) scroll.EnsureControlVisible(target); }).CallDeferred();
                }
            }
        if(rows.Count>_fixtureLimit) timeline.AddChild(CaptionButton("显示更多比赛",()=>{int y=scroll.ScrollVertical;_fixtureLimit+=75; Render();var next=_content.GetChildren().OfType<ScrollContainer>().Last();next.SetDeferred(ScrollContainer.PropertyName.ScrollVertical,y);}));
    }
    private void AddFixtureRow(CareerData d, FixtureEntry e,VBoxContainer timeline,bool first)
    {
        var row=new FixtureTimelineRow {Name="FixtureRow",FirstOfDay=first,CustomMinimumSize=new(0,80)};row.AddThemeConstantOverride("separation",FixtureRowGap);timeline.AddChild(row);
        row.AddChild(new Control {CustomMinimumSize=new(20,0)});
        var stamp=new VBoxContainer {CustomMinimumSize=new(104,0),Alignment=BoxContainer.AlignmentMode.Center};
        stamp.AddThemeConstantOverride("separation",2); row.AddChild(stamp);
        if(first)
        {
            var date=GameCalendar.Date(d,e.Day);
            stamp.AddChild(DashboardLabel(date.ToString("M月d日"),18,e.Day==d.Day?CareerVisuals.Teal:_ink));
            stamp.AddChild(DashboardLabel("周"+"日一二三四五六"[(int)date.DayOfWeek]+(e.Day==d.Day?" · 今天":""),14,_muted));
        }
        var m=e.Match; var f=e.Fixture;
        string pair=m!=null ? "对手："+CareerEngine.DisplayName(d,m.OpponentId) : f!=null ? CareerEngine.DisplayName(d,f.HomeId)+" / "+CareerEngine.DisplayName(d,f.AwayId) : "";
        var inset=Inset(0,9); row.AddChild(inset);
        var body=new VBoxContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill,Alignment=BoxContainer.AlignmentMode.Center};
        body.AddThemeConstantOverride("separation",3); inset.AddChild(body);
        body.AddChild(DashboardLabel(m==null?e.Title:MatchTitle(d,m),18,_ink,true));
        var subline=new HBoxContainer(); subline.AddThemeConstantOverride("separation",10); body.AddChild(subline);
        string state=m!=null ? m.Status=="待赛" && m.Registered?"已报名":m.Status : f?.Finished==true?"已结束":"待赛";
        subline.AddChild(DashboardLabel(pair,14,_muted,true));
        if(m is {Registered:false,Status:"待赛"} && m.Day>=d.Day && EsportsWorld.EntryReason(d,m)==null) state="可报名";
        int round=f?.Round??m?.Round??0;
        var roundText=round>0 ? e.Cup is {Modern:true} cup ? CircuitWorld.RoundName(cup,round) : $"第 {round} 轮" : "";
        int? level=f?.Ascension??m?.RequiredAscension;
        var meta=DashboardLabel(string.Join(" · ",new[]{e.Country,roundText,level.HasValue?"进阶 "+level:""}.Where(v=>v.Length>0)),14,_muted);meta.AutowrapMode=TextServer.AutowrapMode.Off;meta.SizeFlagsHorizontal=SizeFlags.ShrinkEnd;row.AddChild(meta);
        var status=DashboardLabel(state,15,state=="已报名"?_gold:state=="可报名"?CareerVisuals.Teal:_muted);
        status.CustomMinimumSize=new(65,0); status.SizeFlagsHorizontal=SizeFlags.ShrinkEnd; status.HorizontalAlignment=HorizontalAlignment.Right; row.AddChild(status);
        if(f!=null && e.Cup!=null)
        {
            var disclosure=TextLink("对局详情",()=>{},13); disclosure.CustomMinimumSize=new(84,26);
            disclosure.SizeFlagsHorizontal=SizeFlags.ShrinkBegin; disclosure.AddThemeFontSizeOverride("font_size",14);
            disclosure.Icon=NavigationIcon("chevron-down"); disclosure.ExpandIcon=true; disclosure.IconAlignment=HorizontalAlignment.Right;
            disclosure.AddThemeConstantOverride("icon_max_width",14); subline.AddChild(disclosure);
            MarginContainer? detail=null;
            disclosure.Pressed+=()=>{
                if(detail==null)
                {
                    detail=Inset(0,9); detail.Name="FixtureExpandedDetail";
                    detail.AddThemeConstantOverride("margin_left",156); detail.AddThemeConstantOverride("margin_right",FixtureRowGap+FixtureEndInset);
                    timeline.AddChild(detail); timeline.MoveChild(detail,row.GetIndex()+1); detail.AddChild(BracketDetails(d,e.Cup,roundText,[f],round));
                    detail.Draw+=()=>detail.DrawLine(new(13,0),new(13,detail.Size.Y),new Color("68909b80"));
                }
                else detail.Visible=!detail.Visible;
                disclosure.Icon=NavigationIcon(detail.Visible?"chevron-up":"chevron-down");
            };
        }
        Button? action=null;
        if(m!=null)
        {
            if(d.Results.Any(r=>r.MatchId==m.Id)) action=CaptionButton("查看战报",()=>OpenReview(m.Id));
            else if(m.Status=="待赛" && m.Day>=d.Day && m.Registered)
                action=m.Day==d.Day ? CaptionButton("前往赛场",()=>Visit(()=>{_tab="赛事";_arenaMatchId=m.Id;}))
                    : CaptionButton("跳到此日",()=>ShowCareerDialog("跳到比赛日",$"{m.Event}\n推进至{GameCalendar.Text(d,m.Day)}？途中会在需处理的事件处停下。",()=>
                    { if(!MultiplayerCommand("propose-advance",number:m.Day)) {CareerEngine.AdvanceToDay(d,m.Day);Render();} return true;}));
            else if(m.Status=="待赛" && m.Day>=d.Day && EsportsWorld.EntryReason(d,m)==null)
                action=CaptionButton("报名比赛",()=>{if(MultiplayerCommand("propose-register",m.Id,number:1)) return; var error=CareerEngine.SetRegistration(d,m,true); Render(); if(error!=null) Notice(error,true);});
            if(action!=null && _multiplayer is {Host:false} && action.Text is "跳到此日" or "报名比赛") action.Disabled=true;
        }
        if(action==null && e.Cup!=null) action=CaptionButton("赛事详情",()=>OpenCompetition(e.Cup.Id));
        if(action==null) {row.AddChild(new Control{CustomMinimumSize=new(146,0)});return;}
        action.CustomMinimumSize=new(FixtureActionWidth,37); action.SizeFlagsVertical=SizeFlags.ShrinkCenter;
        action.AddThemeFontSizeOverride("font_size",15); ButtonSurface(action,"1d3040","395365","28434c","658c91",6);
        row.AddChild(action); row.AddChild(new Control {CustomMinimumSize=new(FixtureEndInset,0),MouseFilter=MouseFilterEnum.Ignore}); action.MouseEntered+=()=>row.Highlight(true); action.MouseExited+=()=>row.Highlight(false);
        action.FocusEntered+=()=>row.Highlight(true); action.FocusExited+=()=>row.Highlight(false);
    }
    private static string FlagCode(string country) => country switch {"中国"=>"cn","日本"=>"jp","韩国"=>"kr","德国"=>"de","法国"=>"fr","巴西"=>"br","英国"=>"gb","美国"=>"us",_=>""};
    private static string TieKey(WorldCompetition c,WorldFixture f) => c.TeamEvent?f.HomeTeam+"|"+f.AwayTeam:SettlementRecords.FixtureKey(f);
    private static bool LocalEntrant(CareerData d,string id) => id == "player" || id.Length > 0 && id == d.LocalHumanId;
    private static IReadOnlyList<string> BracketEntrants(CareerData d, WorldCompetition cup, WorldFixture game, bool home)
    {
        var recorded = home ? game.HomeParticipants : game.AwayParticipants;
        if (recorded.Count > 0) return recorded;
        string team = home ? game.HomeTeam : game.AwayTeam, leader = home ? game.HomeId : game.AwayId;
        if (cup.TeamEvent && (leader.Length == 0 || leader == team) && cup.Rosters.TryGetValue(team,out var roster)) return roster;
        if (cup.Cooperative && cup.Season == d.Season && !game.Finished) return SeasonCeremony.Participants(d,cup,game,home);
        return leader.Length > 0 ? [leader] : [];
    }
    private Control BracketDetails(CareerData data, WorldCompetition cup, string round, List<WorldFixture> tie, int roundNumber)
    {
        var box = new VBoxContainer();
        box.AddThemeConstantOverride("separation", 8);
        box.AddChild(Text(cup.Name + " · " + round, 19, _gold));
        var pending = tie.Count == 0;
        var scheduled = pending
            ? new List<WorldFixture> { new() { Day = CircuitWorld.DayOf(cup, roundNumber), Ascension = CircuitWorld.KnockoutAscension(cup, roundNumber) } }
            : tie;
        foreach (var fixture in scheduled)
        {
            var duel = pending ? new CompetitionDuel { Status = roundNumber == 1 ? "待抽签" : "待晋级" } : SettlementRecords.CaptureDuel(data, fixture);
            if (!pending && !fixture.Finished && fixture.Day == data.Day) duel.Status = "比赛日";
            string date = pending && !cup.Modern ? "日期待定" : GameCalendar.Text(data, fixture.Day);
            string level = pending && !cup.Modern ? "" : $" · 进阶 {fixture.Ascension}";
            box.AddChild(Text(date + level + " · " + duel.Status, 14, _muted));
            var row = new HBoxContainer();
            row.AddThemeConstantOverride("separation", 4);
            box.AddChild(row);

            void Side(bool home, string performance, bool won)
            {
                var players = BracketEntrants(data,cup,fixture,home);
                bool playerMatch = players.Any(id => LocalEntrant(data,id));
                var panel = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };
                panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box(playerMatch ? "493d28" : won ? "15362f" : "172c38", playerMatch ? "e6bd65" : won ? "4c7066" : "324a57", 4, 8));
                row.AddChild(panel);
                var side = new VBoxContainer();
                side.AddThemeConstantOverride("separation", 3);
                panel.AddChild(side);
                if (pending)
                {
                    side.AddChild(Text(duel.Status, 16, _ink));
                    side.AddChild(Text("角色待定", 13, _muted));
                }
                foreach (var player in players)
                {
                    var line = new HBoxContainer();
                    line.AddThemeConstantOverride("separation", 6);
                    side.AddChild(line);
                    string country = EsportsWorld.HistoricCountry(data, cup, player);
                    var flag = NavigationIcon("flag-" + FlagCode(country));
                    if (flag != null)
                        line.AddChild(new TextureRect { Texture = flag, CustomMinimumSize = new(20, 15),
                            ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered });
                    line.AddChild(Text(CareerEngine.DisplayName(data, player), 16, LocalEntrant(data,player) ? _gold : won ? CareerVisuals.Teal : _ink));
                    var character = CareerEngine.Person(data, player)?.Character;
                    side.AddChild(Text(ArenaCharacterName(string.IsNullOrEmpty(character) ? CareerAvatars.MainCharacter(data, player) : character), 13, _muted));
                }
                side.AddChild(Text(performance.Length > 0 ? performance : pending ? "待赛" : duel.Status, 14, _ink));
            }

            Side(true, duel.HomePerformance, duel.WinnerId.Length > 0 && duel.WinnerId == fixture.HomeId);
            var vs = new Label { Text = "VS", VerticalAlignment = VerticalAlignment.Center };
            vs.AddThemeFontSizeOverride("font_size", 12);
            row.AddChild(vs);
            Side(false, duel.AwayPerformance, duel.WinnerId.Length > 0 && duel.WinnerId == fixture.AwayId);
        }
        return box;
    }
    private static string BracketRoundName(int remaining) => remaining switch
    {
        1=>"总决赛", 2=>"半决赛", _=>$"{1 << remaining} 强"
    };

    private void InternationalBracket(CareerData d, WorldCompetition c,HBoxContainer toolbar)
    {
        var frame=new PanelContainer {Name="BracketFrame",CustomMinimumSize=new(0,712)};
        frame.SetMeta("competition_id",c.Id);
        frame.AddThemeStyleboxOverride("panel",CareerVisuals.Box("0e1c28","334d58",6,1)); _content.AddChild(frame);
        var layout=Inner(frame); layout.AddThemeConstantOverride("separation",0);
        var head=new Control {Name="BracketHeadings",ClipContents=true,CustomMinimumSize=new(0,56),MouseFilter=MouseFilterEnum.Ignore};
        layout.AddChild(head);
        head.Draw+=()=>{
            head.DrawRect(new Rect2(Vector2.Zero,head.Size),new Color("162a36"));
            head.DrawLine(new(0,head.Size.Y-1),new(head.Size.X,head.Size.Y-1),new Color("344954"));
        };
        var scroll=new ScrollContainer {Name="InternationalBracket",SizeFlagsVertical=SizeFlags.ExpandFill,SizeFlagsHorizontal=SizeFlags.ExpandFill};
        layout.AddChild(scroll);
        var headers=new List<(Control Column,Control Heading)>();
        void AlignHeadings()
        {
            foreach(var (column,heading) in headers)
            {
                heading.Position=new(column.Position.X+18-scroll.ScrollHorizontal,0);
                heading.Size=new(column.Size.X-18,56);
            }
        }
        void AddHeading(Control column,string title,string date,bool current,bool invitation=false)
        {
            var heading=new PanelContainer {Name="RoundHeading_"+headers.Count,MouseFilter=MouseFilterEnum.Ignore};
            var style=CareerVisuals.Box("00000000","80e7db",0,0); style.SetBorderWidthAll(0);
            style.ContentMarginLeft=style.ContentMarginRight=11; style.BorderWidthBottom=current?2:0;
            heading.AddThemeStyleboxOverride("panel",style); head.AddChild(heading);
            var fields=new HBoxContainer {MouseFilter=MouseFilterEnum.Ignore}; heading.AddChild(fields);
            fields.AddChild(DashboardLabel(title,19,current ? CareerVisuals.Teal : invitation ? _gold : _muted));
            var stamp=DashboardLabel(date,13,_muted); stamp.SizeFlagsHorizontal=SizeFlags.ShrinkEnd; fields.AddChild(stamp);
            headers.Add((column,heading));
        }
        scroll.GetHScrollBar().ValueChanged+=_=>AlignHeadings();
        var inspector = new BracketInspector(); inspector.Attach(_stage,scroll);
        var inset=Inset(9,0); scroll.AddChild(inset);
        var columns=new BracketColumns(); columns.AddThemeConstantOverride("separation",38); inset.AddChild(columns);
        columns.SortChildren+=AlignHeadings; head.Resized+=head.QueueRedraw;
        int active=c.Fixtures.Where(f=>!f.Finished).Select(f=>f.Round).DefaultIfEmpty(c.Fixtures.Select(f=>f.Round).DefaultIfEmpty(1).Max()).Min();
        int count=c.Modern?CircuitWorld.RoundCount(c):Math.Max(active,c.Fixtures.Select(f=>f.Round).DefaultIfEmpty(1).Max());
        var firstTies=c.Fixtures.Where(f=>f.Round==1).GroupBy(f=>TieKey(c,f)).Count();
        if (firstTies == 0 && c.Modern) firstTies = 1 << (count - 1);
        int pitch = c.TeamEvent ? 142 : 96, cardHeight = c.TeamEvent ? 119 : 77;
        Control? current = null, nextMatch = null;
        for(int round=1;round<=count;round++)
        {
            var panel=new PanelContainer {CustomMinimumSize=new(274,0)};
            bool currentRound = round == active && !c.Finished && c.Fixtures.Count > 0;
            var style=new StyleBoxFlat {BgColor=new Color(currentRound ? "80e7db0a" : "00000000"),BorderColor=new Color("80e7db70"),ContentMarginLeft=9,ContentMarginRight=9,ContentMarginTop=9,ContentMarginBottom=9};
            style.SetBorderWidthAll(currentRound ? 1 : 0);panel.AddThemeStyleboxOverride("panel",style);columns.AddChild(panel);
            if(round==active) current=panel;
            var col = new VBoxContainer();
            col.AddThemeConstantOverride("separation", 0);
            panel.AddChild(col);
            var ties = c.Fixtures.Where(f => f.Round == round).GroupBy(f => TieKey(c, f)).ToList();
            string roundName = BracketRoundName(count-round+1);
            int roundNumber = round;
            int day = ties.Count > 0 ? ties[0].First().Day : c.Modern ? CircuitWorld.DayOf(c, round) : 0;
            AddHeading(panel, roundName, day > 0 ? GameCalendar.Date(d, day).ToString("M月d日") : "", currentRound);
            int slots=Math.Max(ties.Count,Math.Max(1,firstTies >> (round-1)));
            for(int i=0;i<slots;i++)
            {
                var slot=new VBoxContainer {CustomMinimumSize=new(0,Math.Max(60,firstTies*pitch/slots)),Alignment=BoxContainer.AlignmentMode.Center};col.AddChild(slot);
                var matchCard = new Button { Name = $"BracketMatch_{round}_{i}", Flat = true,
                    CustomMinimumSize = new(0, cardHeight), MouseDefaultCursorShape = CursorShape.PointingHand };
                ButtonSurface(matchCard,"182c39","405967","1b323e","80e7db",0);
                slot.AddChild(matchCard); columns.AddSlot(round,matchCard);
                var pair = new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore };
                matchCard.AddChild(pair);
                pair.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect); pair.OffsetLeft=pair.OffsetTop=2; pair.OffsetRight=pair.OffsetBottom=-2;
                pair.AddThemeConstantOverride("separation", 1);

                if (i >= ties.Count)
                {
                    for (int side = 0; side < 2; side++)
                    {
                        var band = new PanelContainer { MouseFilter = MouseFilterEnum.Ignore, SizeFlagsVertical = SizeFlags.ExpandFill };
                        band.AddThemeStyleboxOverride("panel", CareerVisuals.Box("172b37", "344954", 4, 4));
                        band.AddChild(Text(round == 1 ? "▫   待抽签" : "▫   待晋级", 15, _muted));
                        pair.AddChild(band);
                    }
                    inspector.Bind(matchCard, () => BracketDetails(d, c, roundName, [], roundNumber));
                    continue;
                }
                var tie=ties[i].ToList(); var f=tie[0]; bool done=tie.All(x=>x.Finished);
                var homeRoster = tie.SelectMany(game => BracketEntrants(d,c,game,true)).Distinct().ToArray();
                var awayRoster = tie.SelectMany(game => BracketEntrants(d,c,game,false)).Distinct().ToArray();
                bool playerHome = homeRoster.Any(id => LocalEntrant(d,id)), playerAway = awayRoster.Any(id => LocalEntrant(d,id));
                if (playerHome || playerAway)
                {
                    matchCard.Flat = false;
                    ButtonSurface(matchCard,"383026","e6bd65","51422b","ffe09a",0);
                }
                if (done) columns.MarkAdvanced(matchCard);
                else if (round == active && nextMatch == null) nextMatch = matchCard;
                int home=tie.Count(x=>x.WinnerId.Length>0&&x.WinnerId==x.HomeId),away=tie.Count(x=>x.WinnerId.Length>0&&x.WinnerId==x.AwayId);
                inspector.Bind(matchCard, () => BracketDetails(d, c, roundName, tie, roundNumber));
                foreach(bool left in new[]{true,false})
                {
                    string id=left?f.HomeId:f.AwayId, team=left?f.HomeTeam:f.AwayTeam;
                    var band=new PanelContainer {MouseFilter=MouseFilterEnum.Ignore};
                    int score = left ? home - away : away - home;
                    bool won = done && score > 0, lost = done && score < 0;
                    bool player = left ? playerHome : playerAway;
                    var bg = CareerVisuals.Box(player ? (lost ? "352e25" : "493d28") : won ? "1b3d3b" : lost ? "13222e" : "182c39",
                        player ? "e6bd65" : won ? "80c7b9" : "405967", 3, 3);
                    bg.ContentMarginLeft = 8;
                    bg.ContentMarginRight = 8;
                    if (player || won) bg.BorderWidthLeft = 3;
                    band.AddThemeStyleboxOverride("panel",bg);pair.AddChild(band);
                    band.SizeFlagsVertical = SizeFlags.ExpandFill;
                    var content = new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore, Alignment = BoxContainer.AlignmentMode.Center };
                    content.AddThemeConstantOverride("separation", 1); band.AddChild(content);
                    var entrant = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore };
                    entrant.AddThemeConstantOverride("separation", 8); content.AddChild(entrant);
                    string flag=FlagCode(c.TeamEvent && c.Kind=="worldcup" ? team : EsportsWorld.HistoricCountry(d,c,id));
                    if(flag.Length>0)entrant.AddChild(new TextureRect{Texture=NavigationIcon("flag-"+flag),CustomMinimumSize=new(20,15),
                        ExpandMode=TextureRect.ExpandModeEnum.IgnoreSize,StretchMode=TextureRect.StretchModeEnum.KeepAspectCentered,MouseFilter=MouseFilterEnum.Ignore});
                    var label=Text(c.TeamEvent?CircuitWorld.TeamName(d,c,team):CareerEngine.DisplayName(d,id),16,player ? _gold : lost ? _muted : _ink);
                    label.MouseFilter=MouseFilterEnum.Ignore;
                    label.AutowrapMode=TextServer.AutowrapMode.Off; label.TextOverrunBehavior=TextServer.OverrunBehavior.TrimEllipsis;
                    entrant.AddChild(label);
                    if (won || c.TeamEvent && done)
                    {
                        var winner = new Label { Text = c.TeamEvent ? (left ? home : away).ToString() : "胜", MouseFilter = MouseFilterEnum.Ignore };
                        winner.AddThemeFontSizeOverride("font_size", 13);
                        winner.AddThemeColorOverride("font_color", player ? _gold : CareerVisuals.Teal);
                        entrant.AddChild(winner);
                    }
                    if (c.TeamEvent)
                    {
                        var roster = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore };
                        roster.AddThemeConstantOverride("separation", 4);
                        content.AddChild(roster);
                        foreach (string member in left ? homeRoster : awayRoster)
                        {
                            var name = Text(CareerEngine.DisplayName(d, member), 12, LocalEntrant(d,member) ? _gold : _muted);
                            name.AutowrapMode = TextServer.AutowrapMode.Off;
                            name.TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis;
                            roster.AddChild(name);
                        }
                    }
                }
            }
        }
        int seasonStart = SeasonCalendar.Start(d,c.Season), seasonEnd = seasonStart + SeasonCalendar.Length(d,c.Season);
        var invite = d.Matches.FirstOrDefault(m => m.Kind=="masters" && m.Day>seasonStart && m.Day<=seasonEnd);
        // Settlements outlive the rolling four-season match calendar.
        var result = d.Results.LastOrDefault(r => r.Kind=="masters" && (invite != null ? r.MatchId==invite.Id :
            r.Settlement?.Season == c.Season || r.Day>seasonStart && r.Day<=seasonEnd));
        if((invite?.Day ?? result?.Day) is int invitationDay)
        {
            int ascension = invite?.RequiredAscension ?? result!.Ascension;
            string opponent = invite != null ? CareerEngine.DisplayName(d,invite.OpponentId) : result!.Opponent;
            var invitationColumn=Inset(9,9); invitationColumn.CustomMinimumSize=new(274,0);
            invitationColumn.SizeFlagsHorizontal=SizeFlags.Fill; columns.AddChild(invitationColumn);
            var stack=new VBoxContainer(); stack.AddThemeConstantOverride("separation",0); invitationColumn.AddChild(stack);
            AddHeading(invitationColumn,"世界纪录邀请赛",GameCalendar.Date(d,invitationDay).ToString("M月d日"),false,true);
            var invitationSlot=new VBoxContainer { CustomMinimumSize=new(0,Math.Max(60,firstTies*pitch)),Alignment=BoxContainer.AlignmentMode.Center };
            stack.AddChild(invitationSlot);
            var info=new VBoxContainer {Alignment=BoxContainer.AlignmentMode.Center}; info.AddThemeConstantOverride("separation",2);
            var trophy=Glyph("trophy",24,_gold); trophy.SizeFlagsHorizontal=SizeFlags.ShrinkCenter; info.AddChild(trophy);
            var title=DashboardLabel("世界纪录邀请赛",18,_gold); title.HorizontalAlignment=HorizontalAlignment.Center; info.AddChild(title);
            var criteria=DashboardLabel("国际赛事冠军 · 生涯进阶 9 通关",14,_muted); criteria.HorizontalAlignment=HorizontalAlignment.Center; info.AddChild(criteria);
            var invitation=ActionRow(invitationSlot,"InvitationCard","世界纪录邀请赛",()=>{},info,104,6,4,"282d29","958264","383d34");
            if (invite?.Registered == true || result != null)
                ButtonSurface(invitation,"493d28","e6bd65","51422b","ffe09a",0);
            columns.ConnectInvitation(invitation);
            inspector.Bind(invitation,()=>{
                var body=new VBoxContainer();
                body.AddChild(Text("世界纪录邀请赛",22,_gold));
                body.AddChild(Text(GameCalendar.Text(d,invitationDay)+" · 进阶 "+ascension,16,_muted));
                body.AddChild(Text("受邀资格：国际赛事冠军、生涯赛事进阶 9 通关。",17,_ink));
                body.AddChild(Text("对手："+opponent,18,_ink)); return body;
            });
        }
        if (current != null)
        {
            // Preserve the previous round on the left so the incoming paths are visible.
            void Locate()
            {
                if (!IsInstanceValid(scroll) || !IsInstanceValid(current) || !scroll.IsInsideTree()) return;
                int precedingColumn = (int)current.Position.X - 312;
                scroll.ScrollHorizontal = c.Finished ? (int)scroll.GetHScrollBar().MaxValue : Math.Max(0, precedingColumn);
                if (nextMatch != null)
                {
                    float localY = (columns.GetGlobalTransform().AffineInverse() * nextMatch.GlobalPosition).Y;
                    scroll.ScrollVertical = Math.Max(0, (int)(localY - scroll.Size.Y * .30f));
                }
            }
            toolbar.AddChild(new Control {SizeFlagsHorizontal=SizeFlags.ExpandFill});
            var progress=Text(c.Finished?"已结束":c.Fixtures.Count==0?"待抽签":BracketRoundName(count-active+1),16,CareerVisuals.Teal);
            progress.AutowrapMode = TextServer.AutowrapMode.Off;
            progress.SizeFlagsHorizontal=SizeFlags.ShrinkBegin;toolbar.AddChild(progress);
            toolbar.AddChild(FramedAction("定位轮次",()=>{scroll.ScrollVertical=0;Locate();},"locate-fixed",width:118,height:38,quiet:true));
            // Wait for both the columns and the nested round slots to receive their actual rectangles.
            async void LocateAfterLayout()
            {
                var tree = scroll.GetTree();
                await ToSignal(tree, SceneTree.SignalName.ProcessFrame);
                await ToSignal(tree, SceneTree.SignalName.ProcessFrame);
                Locate();
            }
            LocateAfterLayout();
        }
        if (d.Esports.Competitions.Contains(c)) toolbar.AddChild(CaptionButton("赛事详情", () => OpenCompetition(c.Id)));
    }
}
