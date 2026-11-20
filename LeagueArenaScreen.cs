using Godot;
using MegaCrit.Sts2.Core.Models;

namespace NationalSpire;

public partial class CareerScreen
{
    private static CareerAvatar LeaguePortrait(AvatarArt art,int tier,int size){
        var frame=AvatarHonors.Frames[tier switch{0=>1,1=>3,2=>5,_=>8}];
        return new(){Art=art,Identity=new(frame,-1,"",""),CustomMinimumSize=new(size,size),MouseFilter=MouseFilterEnum.Ignore};
    }
    private static string LeagueScore(LeagueReceipt r)=>$"{r.Before} → {r.After} 分   ·   {LeagueLadder.Names[LeagueLadder.Tier(r.After)]}";
    private static string LeaguePrize(LeagueReceipt r)=>r.Prize==0?"本场无奖金":"胜场奖金   +"+CareerMoney.Format(r.Prize);
    private void LeagueAward(LeagueReceipt receipt)=>RankedReport(receipt,true);
    private void RankedReport(LeagueReceipt receipt,bool justFinished){
        ShowCareerDialog(receipt.Won?"对决胜利":"对决惜败","",()=>true,"返回对战",box=>{
            var panel=ReportPanel("1c2c36","49606a",12);panel.Name="LeagueRankSummary";box.AddChild(panel);
            var row=new HBoxContainer();row.AddThemeConstantOverride("separation",12);panel.AddChild(row);
            row.AddChild(Glyph("trophy",28,_gold));
            var points=Text(LeagueScore(receipt),24,_gold);points.AutowrapMode=TextServer.AutowrapMode.Off;row.AddChild(points);
            var prize=Text(LeaguePrize(receipt),17,_muted);prize.HorizontalAlignment=HorizontalAlignment.Right;row.AddChild(prize);
            if(receipt.Fight.Report is {} report)DuelReportView(box,report,true);
            if(justFinished){
                panel.Modulate=new(1,1,1,0);panel.CreateTween().TweenProperty(panel,"modulate:a",1,.34);
                if(receipt.Won){
                    LeagueSound("event:/sfx/ui/timeline/ui_timeline_unlock");
                    var seal=new LeagueSeal{Burst=true,Ink=_gold,MouseFilter=MouseFilterEnum.Ignore};
                    panel.AddChild(seal);seal.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
                }
            }
        },showCancel:false);
    }
    private void ShowDuelReport(DuelReport report){
        ShowCareerDialog("对决战报","",()=>true,"返回",box=>DuelReportView(box,report,true),showCancel:false);
    }
    private void LeagueArena(CareerData d)
    {
        var a=d.Life.League;var deck=LeagueCards.Deck(a);PresentTeamReceipt();
        {
            var banner=new PanelContainer();var pad=new StyleBoxEmpty{ContentMarginLeft=42,ContentMarginRight=42,ContentMarginTop=28,ContentMarginBottom=28};
            banner.AddThemeStyleboxOverride("panel",pad);_content.AddChild(banner);
            var head=new LeagueFoil{Wide=true,MouseFilter=MouseFilterEnum.Ignore};var backdrop=new Control{MouseFilter=MouseFilterEnum.Ignore};banner.AddChild(backdrop);backdrop.AddChild(head);head.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);head.OffsetLeft=-42;head.OffsetRight=42;head.OffsetTop=-28;head.OffsetBottom=28;
            var body=new VBoxContainer();body.AddThemeConstantOverride("separation",10);banner.AddChild(body);
            int tier=LeagueLadder.Tier(a.Rating);var heading=LeagueRow(body);heading.SizeFlagsHorizontal=SizeFlags.ShrinkBegin;heading.AddChild(LeaguePortrait(CareerAvatars.ForPerson(d,"player"),tier,62));
            heading.AddChild(LeagueNumber($"联赛邀请赛   /   {LeagueLadder.Names[tier]}   ·   {a.Rating} 分   ·   {a.DuelWins} 胜 {a.DuelLosses} 负",360,_gold));body.AddChild(Text("镜面对决",48,_ink));
            body.AddChild(Text(deck==null?"先选择出战职业与牌组。":$"{LeagueCards.GroupName(a.Captain)}   ·   {deck.Values.Sum()} 张出战卡牌",20,_muted));
            int floor=LeagueLadder.Thresholds[tier],next=LeagueLadder.Thresholds[Math.Min(LeagueLadder.Thresholds.Length-1,tier+1)];
            var progress=LeagueRow(body,14);var meter=new ProgressBar{CustomMinimumSize=new(235,12),ShowPercentage=false,SizeFlagsVertical=SizeFlags.ShrinkCenter,MaxValue=tier==LeagueLadder.Names.Length-1?1:next-floor,Value=tier==LeagueLadder.Names.Length-1?1:a.Rating-floor};
            meter.AddThemeStyleboxOverride("background",CareerVisuals.Box("172530","34424b",5,0));meter.AddThemeStyleboxOverride("fill",CareerVisuals.Box("c9a15e","f0d695",5,0));progress.AddChild(meter);
            progress.AddChild(Text(tier==LeagueLadder.Names.Length-1?"已达最高段位":$"距{LeagueLadder.Names[tier+1]}还差 {next-a.Rating} 分",18,_gold));
            var line=LeagueRow(body);line.AddChild(LeagueButton("调整牌组",()=>LeagueGo("组卡"),145));
            var start=LeagueButton(!LeagueSolverLink.Supported?LeagueSolverLink.Unavailable:_multiplayer==null?"匹配对手":"团体匹配",()=>{if(MultiplayerCommand("propose-league-team"))return;if(!_leagueBusy)_=LeagueMatch(d);},LeagueSolverLink.Supported?195:300,kind:LeagueControl.Primary);
            start.Disabled=!LeagueSolverLink.Supported||_multiplayer is {Host:false}||_leagueBusy||!LeagueCards.Ready(a)||!LeagueCards.Roles.Any(r=>r.Id.Entry==a.Captain);line.AddChild(start);
        }
        if(a.LastDuel is {} last)
        {
            var panel=Card();
            _content.AddChild(panel);
            var box=Inner(panel);
            var heading=LeagueRow(box);
            heading.AddChild(Text("上场对决   /   "+(last.Won?"胜利":"惜败"),26,last.Won?_gold:_muted));
            heading.AddChild(TextLink("查看战报",()=>RankedReport(last,false),16,icon:"arrow-up-right"));
            box.AddChild(Text($"{last.Fight.Opponent}   ·   {LeagueLadder.Names[last.Fight.Tier]}对手     /     {LeagueScore(last)}     /     {LeaguePrize(last)}",20,_ink));
        }
    }
    private void MirrorAppointmentArena(CareerData data,CareerMatch match){
        bool future=match.Day>data.Day;
        var album=data.Life.League;
        async void Launch(){
            if(future){
                if(!MultiplayerCommand("propose-advance","direct",number:match.Day)){CareerEngine.AdvanceToDay(data,match.Day);Render();}
                return;
            }
            if(!LeagueSolverLink.Supported || !LeagueCards.Ready(album)){Notice(!LeagueSolverLink.Supported?LeagueSolverLink.Unavailable:"请先准备 35 张出战牌。",true);return;}
            if(!MultiplayerCommand("propose-start",match.Id) && !_leagueBusy)await LeagueMatch(data,match);
        }
        string role=LeagueCards.GroupName(album.Captain);
        MatchArena(data,match.Event,match.OpponentId,CareerEngine.DisplayName(data,match.OpponentId),
            future?"前往比赛日":"开始镜面对决",role,CareerVisuals.Teal,out var controls,match.Day,Launch,seed:match.Seed);
        controls.AddChild(LeagueButton("调整牌组",()=>LeagueGo("组卡"),145));
        if(!future && (!LeagueSolverLink.Supported || !LeagueCards.Ready(album))){
            foreach(var name in new[]{"ArenaStart","ArenaStateAction"})
                if(_content.FindChild(name,true,false) is Button b)b.Disabled=true;
            controls.AddChild(Text(!LeagueSolverLink.Supported?LeagueSolverLink.Unavailable:"请先准备 35 张出战牌。",18,_muted));
        }
    }
    private async Task LeagueMatch(CareerData d,CareerMatch? appointment=null){
        _leagueBusy=true;LeagueSolverLink.Prepare();
        try{
            var a=d.Life.League;var rng=new Random();var roles=LeagueCards.Roles;var role=roles.Single(r=>r.Id.Entry==a.Captain);
            if(LeagueLadder.PrepareRoster(d))CareerStore.Save(d);
            var draw=new LeagueLadder.Draw(d);
            var match=appointment==null ? LeagueLadder.Match(d.LeagueRoster!,draw,rng,LeagueLadder.Tier(a.Rating))
                : LeagueLadder.Invited(d.LeagueRoster!,draw,appointment.OpponentId) ?? throw new InvalidOperationException("这位选手的职业暂时无法参加镜面对决。");var rival=match.Role;_leagueRival=match.Name;
            var upgrades=a.Upgrades.GetValueOrDefault(a.Captain)?.ToDictionary();
            var selected=LeagueCards.Deck(a)!.SelectMany(x=>Enumerable.Repeat(LeagueCards.Catalog[x.Key].Model,x.Value)).ToArray();
            int seed=rng.Next();
            await OpeningGate(appointment?.Event ?? "国运尖塔   /   联赛邀请赛",CareerAvatars.ForPerson(d,"player"),LeagueLadder.Tier(a.Rating),LeagueCards.GroupName(role.Id.Entry),"我的牌组",
                match.PersonId==null?new(rival.IconTexture,_gold,match.Name):CareerAvatars.ForPerson(d,match.PersonId),match.Tier,LeagueCards.GroupName(rival.Id.Entry),match.Name+" · "+LeagueArchetypes.Name(rival.Id.Entry,match.Style),LeagueLadder.RivalOpens(seed)?"对手先手":"你方先手", Begin);
            async Task Begin(){
                var rivalCards=LeagueLadder.Build(rival,rng,match.Tier,match.Style).ToArray();var session=_multiplayer;
                if(session!=null){session.Message-=Notice;_multiplayer=null;}
                try{await LeagueNativeMatch.StartMirror(role,selected,rival,rivalCards,seed,session,_leagueRival,match.Tier,upgrades,LeagueLadder.UpgradePlan(rivalCards,LeagueArchetypes.Resolve(rival.Id.Entry,match.Style),match.Tier,rng),LeagueLadder.Tier(a.Rating),match.Style,match.PersonId,appointment?.Id);}
                catch{if(session!=null&&IsInsideTree()){_multiplayer=session;session.Message+=Notice;}throw;}
            }
        }catch(Exception e){Diagnostics.Error("league-match",e);Notice(e.GetBaseException().Message,true);}
        finally{_leagueBusy=false;if(GodotObject.IsInstanceValid(this)&&IsInsideTree())Render();}
    }
    private sealed class Opening(LeagueGate gate,Func<Task> countdown){
        private Task? _animation;
        internal string? CharacterSound;
        internal bool Visible=>gate.Visible;
        internal async Task LoadChapter(Task assets){
            _animation??=countdown();
            await Task.WhenAll(assets,_animation);
        }
        internal void Reveal(){
            if(!Visible)return;
            gate.Hide();
            if(CharacterSound!=null)LeagueSound(CharacterSound);
            MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController.Instance?.UpdateMusic();
        }
    }
    private static Opening? _opening;
    internal static bool OpeningVisible=>_opening?.Visible==true;
    internal static bool UseOpening(string? sound=null){
        if(_opening is not {} opening)return false;
        opening.CharacterSound=sound;return true;
    }
    internal static Task OpeningChapter(Task assets)=>_opening?.LoadChapter(assets)??assets;
    internal static void RevealOpening()=>_opening?.Reveal();
    internal async Task OpeningGate(string title,AvatarArt home,int homeTier,string homeName,string homeDetail,AvatarArt away,int awayTier,string awayName,string awayDetail,string note,Func<Task> begin){
        var game=MegaCrit.Sts2.Core.Nodes.NGame.Instance!;
        var tree=game.GetTree();
        var layer=new CanvasLayer{Layer=1000,Name="LeagueOpeningLayer"};game.AddChild(layer);
        var overlay=new LeagueGate{Name="LeagueMatchGate",Theme=Theme,MouseFilter=MouseFilterEnum.Stop};layer.AddChild(overlay);overlay.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        var labels=new Control{MouseFilter=MouseFilterEnum.Ignore};overlay.AddChild(labels);labels.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);
        Label Caption(string copy,int size,Color color,float x,float y,float width,float height){
            var label=Text(copy,size,color);labels.AddChild(label);label.AnchorLeft=label.AnchorRight=x;label.AnchorTop=label.AnchorBottom=y;
            label.OffsetLeft=-width/2;label.OffsetRight=width/2;label.OffsetTop=-height/2;label.OffsetBottom=height/2;
            label.HorizontalAlignment=HorizontalAlignment.Center;label.VerticalAlignment=VerticalAlignment.Center;label.AutowrapMode=TextServer.AutowrapMode.Off;
            label.TextOverrunBehavior=TextServer.OverrunBehavior.TrimEllipsis;return label;
        }
        async Task Pause(float time)=>await tree.ToSignal(tree.CreateTimer(time),SceneTreeTimer.SignalName.Timeout);
        var watch=MatchStartWatch.IsActive?null:MatchStartWatch.Begin(game,title,()=>MegaCrit.Sts2.Core.Saves.SaveManager.Instance.HasRunSave,game.Quit);
        try{
            Caption(title,23,_gold,.5f,.19f,720,65);
            void Side(bool left,AvatarArt art,int tier,string name,string detail){
                float x=left?.25f:.75f;var portrait=LeaguePortrait(art,tier,78);labels.AddChild(portrait);
                portrait.AnchorLeft=portrait.AnchorRight=x;portrait.AnchorTop=portrait.AnchorBottom=.33f;
                portrait.OffsetLeft=portrait.OffsetTop=-39;portrait.OffsetRight=portrait.OffsetBottom=39;
                Caption(name,34,_ink,x,.50f,430,64);Caption(detail,19,_gold,x,.58f,430,50);
            }
            Side(true,home,homeTier,homeName,homeDetail);Side(false,away,awayTier,awayName,awayDetail);
            Caption(note,18,_muted,.5f,.70f,500,48);
            _opening=new(overlay,Animate);
            await tree.ToSignal(RenderingServer.Singleton,RenderingServer.SignalName.FramePostDraw);
            await begin();
        }finally{_opening=null;layer.QueueFree();watch?.Finish();}
        async Task Animate(){
            var number=Caption("",82,_ink,.5f,.5f,230,140);
            number.Name="Countdown";
            foreach(var value in new[]{"3","2","1"}){
                number.Text=value;LeagueSound(value=="1"?"event:/sfx/ui/clicks/ui_click":"event:/sfx/ui/clicks/ui_hover");number.Modulate=new Color(1,1,1,.25f);number.CreateTween().TweenProperty(number,"modulate:a",1,.16);
                await Pause(1f);
            }
            var gate=overlay.CreateTween().SetParallel();
            gate.TweenProperty(labels,"modulate:a",0,.20);
            gate.TweenMethod(Callable.From<float>(v=>overlay.Door=v),0f,1f,.36).SetTrans(Tween.TransitionType.Cubic).SetEase(Tween.EaseType.In);
            await tree.ToSignal(gate,Tween.SignalName.Finished);LeagueSound("event:/sfx/ui/pause_close");
            overlay.Impact=1;var flash=overlay.CreateTween();flash.TweenMethod(Callable.From<float>(v=>overlay.Impact=v),1f,0f,.40);await tree.ToSignal(flash,Tween.SignalName.Finished);
        }
    }
    internal Task FormalGate(CareerData d,CareerMatch match,string character,Func<Task> begin)=>OpeningGate(match.Event,CareerAvatars.ForPerson(d,"player"),0,CareerEngine.Name(d),character,CareerAvatars.ForPerson(d,match.OpponentId),0,CareerEngine.DisplayName(d,match.OpponentId),ArenaCharacterName(CareerEngine.Person(d,match.OpponentId)?.Character??""),"正式比赛",begin);
}
