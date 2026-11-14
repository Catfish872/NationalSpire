using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Commands;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Events;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Events;
using MegaCrit.Sts2.Core.Models.Encounters;
using MegaCrit.Sts2.Core.Nodes;
using MegaCrit.Sts2.Core.Nodes.Events;
using MegaCrit.Sts2.Core.Nodes.Rooms;
using MegaCrit.Sts2.Core.Multiplayer.Game;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Runs.History;
using MegaCrit.Sts2.Core.Saves;
using MegaCrit.Sts2.Core.Saves.Runs;
using NationalSpire.Coop;
using System.Reflection;
using System.Reflection.Emit;

namespace NationalSpire;

// 房间始终属于建筑师。只有选择页使用独立的共享事件，避免把比赛投票交给其他章节的选项规则。
[HarmonyPatch(typeof(RunManager),nameof(RunManager.EnterRoom))]
internal static class ArchitectFinal {
    internal static EventRoom? Destination;
    internal static bool Returning;
    internal static double Arrival;
    private const string WinKey="FINAL_CHOICE_EVENT.result.win",LossKey="FINAL_CHOICE_EVENT.result.loss";
    internal static bool? Result(IEnumerable<IEnumerable<MapPointHistoryEntry>> history){
        foreach(var choice in history.SelectMany(act=>act).SelectMany(f=>f.PlayerStats).SelectMany(p=>p.EventChoices)){
            if(choice.Title?.LocTable!="events")continue;
            if(choice.Title.LocEntryKey==WinKey)return true;
            if(choice.Title.LocEntryKey==LossKey)return false;
        }
        return null;
    }
    internal static void Record(RunState run,bool won){
        if(run.CurrentMapPointHistoryEntry is {} floor)
            foreach(var p in floor.PlayerStats)p.EventChoices.Add(new(){Title=new LocString("events",won?WinKey:LossKey)});
    }
    internal static CareerMatch? Match(RunState run){
        var session=CoopRuntime.Current?.Session;
        if(run.Players.Count>1)return session?.World is { Run: {} team } world&&CareerRunBinding.SameSeed(team.Seed,run.Rng.StringSeed)?world.World.Matches.FirstOrDefault(m=>m.Id==team.MatchId):null;
        return CareerRunBinding.Find(CareerStore.Data,run.Rng.StringSeed,run.Players[0].Character.Id.ToString(),run.AscensionLevel,1,run.GameMode.ToString());
    }
    static void Prefix(AbstractRoom room){
        if(room is not EventRoom {CanonicalEvent:TheArchitect} architect)return;
        if(ReferenceEquals(architect,Destination)&&Returning){Destination=null;Returning=false;return;}
        if(RunManager.Instance.DebugOnlyGetState() is not {} run||Match(run) is not {DateGame:null} match||Result(run.MapPointHistory).HasValue||PrivateAppointments.IsPrivate(match))return;

        Arrival=RunManager.Instance.RunTime;Destination=architect;Returning=false;
    }
    internal static async Task Continue(){
        if(Destination is not {} room||Returning)return;
        Returning=true;
        var manager=RunManager.Instance;
        if(manager.DebugOnlyGetState()?.CurrentRoom!=room){await manager.EnterRoom(room);return;}
        var sync=manager.EventSynchronizer;
        await sync.AwaitPendingOptionTasks();
        var view=NEventRoom.Instance!;
        var layout=view.Layout!;
        var choice=sync.GetLocalEvent();
        // 更换对话的接收者，保留房间、人物、布景及镜头。
        var refresh=AccessTools.Method(typeof(NEventRoom),"RefreshEventState").CreateDelegate<Action<EventModel>>(view);
        var entering=AccessTools.Method(typeof(NEventRoom),"OnEnteringEventCombat").CreateDelegate<Action>(view);
        choice.StateChanged-=refresh;choice.EnteringEventCombat-=entering;
        foreach(var page in sync.Events.OfType<FinalChoiceEvent>())page.FinishPage();
        Destination=null;Returning=false;
        sync.BeginEvent(room.CanonicalEvent,room.IsPreFinished,StartArchitectPage.OnStart(room));
        var dialogue=sync.GetLocalEvent();
        if(typeof(EventSynchronizer).GetField("_combatSynchronizer",BindingFlags.NonPublic|BindingFlags.Instance)?.GetValue(sync) is {} combat)
            AccessTools.Field(combat.GetType(),"_canonicalEvent").SetValue(combat,room.CanonicalEvent);
        else{
            // 107 由事件自身持有房内人物；移交同一组对象，供建筑师离场时清理。
            foreach(var name in new[]{"_mutableEncounter","_combatStateForCombatLayout"}){
                var field=AccessTools.Field(typeof(EventModel),name);
                field.SetValue(dialogue,field.GetValue(choice));field.SetValue(choice,null);
            }
        }
        AccessTools.Field(typeof(NEventRoom),"_event").SetValue(view,dialogue);
        AccessTools.Field(typeof(NEventLayout),"_event").SetValue(layout,dialogue);
        dialogue.SetNode(layout);
        dialogue.StateChanged+=refresh;dialogue.EnteringEventCombat+=entering;
        layout.SetTitle(dialogue.Title.GetFormattedText());
        dialogue.OnRoomEnter();refresh(dialogue);
        await dialogue.AfterEventStarted();
    }
}

[HarmonyPatch(typeof(EventSynchronizer),nameof(EventSynchronizer.BeginEvent))]
internal static class StartArchitectPage {
    internal static readonly Func<EventRoom,Action<EventModel>?> OnStart=AccessTools.PropertyGetter(typeof(EventRoom),"OnStart").CreateDelegate<Func<EventRoom,Action<EventModel>?>>();
    static void Prefix(ref EventModel canonicalEvent,ref Action<EventModel>? debugOnStart){
        if(canonicalEvent is TheArchitect&&ArchitectFinal.Destination is {} room&&RunManager.Instance.DebugOnlyGetState()?.CurrentRoom==room&&!ArchitectFinal.Returning){
            canonicalEvent=ModelDb.Event<FinalChoiceEvent>();debugOnStart=null;
        }
    }
}

// 团队只为这一个页面投票。每名玩家后续的建筑师对话仍由自己的原版事件负责。
public sealed class FinalChoiceEvent:EventModel {
    internal void FinishPage()=>SetEventFinished(InitialDescription);
    public override bool IsShared=>true;
    public override async Task AfterEventStarted(){
        await base.AfterEventStarted();
        // 房间仍属于建筑师。读档时游戏重新进入建筑师并重新提供选择。
        if(ArchitectFinal.Destination is {} room)await SaveManager.Instance.SaveRun(room,false);
    }
    public override EventLayoutType LayoutType=>EventLayoutType.Combat;
    public override EncounterModel CanonicalEncounter=>ModelDb.Encounter<TheArchitectEventEncounter>();
    protected override IReadOnlyList<EventOption> GenerateInitialOptions(){
        bool ranked=ArchitectFinal.Match(RunManager.Instance.DebugOnlyGetState()!)!.OpponentWon;
        var key=Id.Entry;LocManager.Instance.GetTable(LocTable).MergeWith(new(){
            [key+".title"]="最终决战",[key+".pages.INITIAL.description"]=ranked?"双方都已通关。可以按通关用时判定比赛，也可以在建筑师面前决出胜负。":"对手没有通关。本场比赛按原有规则结算，你仍可与对手进行一场对战。",
            [key+".result.win"]="建筑师对决获胜",[key+".result.loss"]="建筑师对决失利",
            [key+".time.title"]=ranked?"按通关用时判定":"继续建筑师对话",[key+".time.description"]=ranked?"较快的一方获胜，随后继续建筑师对话。":"保留本场成绩，继续建筑师对话。",
            [key+".fight.title"]=!LeagueSolverLink.Supported?"当前游戏版本不支持建筑师对决":ranked?"与对手决战":"与对手进行表演赛",[key+".fight.description"]=!LeagueSolverLink.Supported?"请选择上方选项，继续本局建筑师对话。":ranked?"通关较快的一队先手。此战决定比赛胜负，双方的冒险都已通关。":"对手没有通关。仍然进行对战，但不会影响比赛结果。"});
        EventOption Choice(string id,bool fight)=>new EventOption(this,fight&&!LeagueSolverLink.Supported?null:()=>{
            if(MegaCrit.Sts2.Core.Context.LocalContext.IsMe(Owner))
                Callable.From(()=>{_=MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(fight?LeagueNativeMatch.StartFinal():ArchitectFinal.Continue());}).CallDeferred();
            return Task.CompletedTask;
        },new LocString(LocTable,key+"."+id+".title"),new LocString(LocTable,key+"."+id+".description"),id,[]).ThatWontSaveToChoiceHistory();
        return [Choice("time",false),Choice("fight",true)];
    }
}

public static partial class LeagueNativeMatch {
    private static readonly List<LeagueDuel> Team=[];
    private static readonly HashSet<LeagueDuel> Opened=[];
    internal static IEnumerable<LeagueDuel> Fighters=>Team.Count>0?Team:Current==null?[]:[Current];
    internal static LeagueDuel? For(Creature? c)=>c?.Monster is LeagueOpponent m?(m.Fighter??Current):null;
    internal static LeagueDuel? For(Player? p)=>p!=null&&For(p.Creature) is {} fighter&&fighter.Rival==p?fighter:null;
    internal static MonsterModel? FirstLiving=>Fighters.FirstOrDefault(f=>f.Rival.Creature.IsAlive)?.Rival.Creature.Monster;
    internal static ulong HumanLead=>_run?.Players.FirstOrDefault(p=>p.Creature.IsAlive)?.NetId??0;
    private static string TargetName(Creature c)=>For(c)?.OpponentName??CoopRuntime.Current?.Session?.World?.Members.FirstOrDefault(m=>m.SteamId==c.Player?.NetId)?.Name??c.Name;
    internal static IReadOnlyList<(MonsterModel,string?)> Opponents(){
        if(Team.Count==0)return [(ModelDb.Monster<LeagueOpponent>().ToMutable(),null)];
        return Team.Select(f=>{var m=(LeagueOpponent)ModelDb.Monster<LeagueOpponent>().ToMutable();m.Fighter=f;return ((MonsterModel)m,(string?)null);}).ToList();
    }
    internal static bool PlanHost=>_run!.Players.Count==1||CoopRuntime.Current!.Session!.Host;
    internal static async Task<List<int>> SharePlan(List<int> actions){
        if(_run!.Players.Count==1)return actions;
        var host=_run.Players.Single(p=>p.NetId==CoopRuntime.Current!.Session!.World!.Owner);
        var sync=RunManager.Instance.PlayerChoiceSynchronizer;uint id=sync.ReserveChoiceId(host);
        if(PlanHost){sync.SyncLocalChoice(host,id,MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult.FromIndexes(actions));return actions;}
        return (await sync.WaitForRemoteChoice(host,id)).AsIndexes();
    }
    private sealed class Adventure(RunState run){
        internal bool? Outcome;
        // 章节曲名不会随首领专属曲切换。这里保留建筑师房间实际播放的曲目，空串表示静音。
        private static Node? MusicProxy=>MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController.Instance?.GetNodeOrNull<Node>("Proxy");
        private static string? PlayingTrack(Node? proxy)=>proxy==null?null:
            proxy.Get("_musicEv").AsGodotObject()==null?"":proxy.Get("_currentTrack").AsString();
        private readonly string? entryTrack=PlayingTrack(MusicProxy);
        internal void RestoreMusic(){
            var proxy=MusicProxy;
            if(proxy==null||entryTrack==null||PlayingTrack(proxy)==entryTrack)return;
            if(entryTrack.Length==0)proxy.Call("stop_music");
            else MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController.Instance!.PlayCustomMusic(entryTrack);
        }
        readonly bool replay=RunManager.Instance.CombatReplayWriter.IsEnabled;
        readonly SerializablePlayer[] players=run.Players.Select(p=>p.ToSerializable()).ToArray();
        readonly SerializableRunRngSet rng=run.Rng.ToSerializable();
        readonly MapPointHistoryEntry? floor=run.CurrentMapPointHistoryEntry;
        readonly List<MapPointRoomHistoryEntry>? rooms=run.CurrentMapPointHistoryEntry?.Rooms;
        readonly List<PlayerMapPointHistoryEntry>? stats=run.CurrentMapPointHistoryEntry?.PlayerStats;
        internal void Begin(){
            RunManager.Instance.CombatReplayWriter.IsEnabled=false;
            if(floor!=null){floor.Rooms=[new(){RoomType=RoomType.Monster}];floor.PlayerStats=run.Players.Select(p=>new PlayerMapPointHistoryEntry{PlayerId=p.NetId}).ToList();}
            foreach(var p in run.Players.Where(p=>p.Creature.IsAlive)){int hp=p.Creature.CurrentHp;p.Creature.SetMaxHpInternal(p.Creature.MaxHp+100);p.Creature.SetCurrentHpInternal(hp+100);}
        }
        internal void Restore(){
            RunManager.Instance.CombatReplayWriter.IsEnabled=replay;
            foreach(var p in players)run.Players.Single(x=>x.NetId==p.NetId).SyncWithSerializedPlayer(p);
            run.Rng.LoadFromSerializable(rng);
            if(floor!=null){floor.Rooms=rooms!;floor.PlayerStats=stats!;}
        }
    }
    private static Adventure? _adventure;
    internal static bool InFinal=>_adventure!=null;
    internal static async Task StartFinal(){
        var mgr=RunManager.Instance;var run=mgr.DebugOnlyGetState()!;var match=ArchitectFinal.Match(run)!;
        var world=run.Players.Count>1?CoopRuntime.Current!.Session!.World:null;var data=world?.World??CareerStore.Data;
        var ids=world?.Run?.Opponents??[match.OpponentId];int seed=CareerEngine.StableHash(match.Seed+":final");var pending=new List<LeagueDuel.Hit>();
        Install();_run=run;_returning=false;
        try{
            foreach(var id in ids){
                var npc=CareerEngine.Person(data,id)!;var rng=new Random(CareerEngine.StableHash(match.Seed+":final:"+id));
                var role=LeagueCards.OriginalRoles.Single(r=>NpcCharacters.Index(r.Id.Entry)==NpcCharacters.Index(npc.Character));
                var live=world?.Run?.RivalMembers.GetValueOrDefault(id)??match.Live;
                if(live?.Steps.Count is not >0){
                    var nodes=LiveMaps.Read(run,match,world!=null);
                    var route=RivalSimulation.Route(nodes,world==null?npc:CareerEngine.Person(data,ids[0])!,match.Seed);
                    live=RivalSimulation.Create(match,npc,route,GameCharacterNames.StartingHp(npc.Character));
                }int tier=npc.MaxAscension>=6?1:0;
                var deck=LeagueLadder.BuildFor(role,rng,tier,npc.Style,true).ToArray();var plan=LeagueArchetypes.Resolve(role.Id.Entry,npc.Style);
                ulong netId=ulong.MaxValue-(ulong)Team.Count;while(run.Players.Any(p=>p.NetId==netId)||Team.Any(f=>f.Rival.NetId==netId))netId--;
                var bot=Player.CreateForNewRun(role,run.Players[0].UnlockState,netId);bot.RunState=run;bot.InitializeSeed(seed+":"+id);
                Team.Add(new(bot,deck,rng.Next(),npc.PublicName,tier,LeagueLadder.Upgrades(deck,plan,tier,rng,true),pending){OpeningMax=live.MaxHp+100,OpeningHp=live.Steps[^1].HpAfter+100,SetupCards=plan.Anchors});
            }
            Current=Team[0];var time=MatchRules.Compare(new(true,0,ArchitectFinal.Arrival),new(match.OpponentWon,match.OpponentFloor,match.OpponentSeconds!.Value));_opener=time<0||time==0&&LeagueLadder.RivalOpens(seed);
            var encounter=LeagueEncounter.ForFinal(run);
            _adventure=new(run);_adventure.Begin();
            if(NRun.Instance is {} scene)scene.TreeExiting+=OnAdventureExit;
            if(run.Players.Count>1){
                var opening=await SharePlan([_opener?1:0,..Team.SelectMany(f=>new[]{f.OpeningHp!.Value,f.OpeningMax})]);
                _opener=opening[0]==1;
                for(int i=0;i<Team.Count;i++){Team[i].OpeningHp=opening[1+2*i];Team[i].OpeningMax=opening[2+2*i];}
            }
            CombatManager.Instance.TurnStarted+=PlayerTurn;
            await MegaCrit.Sts2.Core.Assets.PreloadManager.LoadRunAssets(run.Players.Select(p=>p.Character).Concat(Team.Select(f=>f.Rival.Character)).Distinct().ToList());
            await mgr.EnterRoom(new CombatRoom(encounter,run));
        }catch(Exception e){Diagnostics.Error("league-match",e);await FinishFinal(null);}
    }
    private static void OnAdventureExit(){
        if(_adventure==null)return;
        _adventure.Restore();_adventure=null;Release();ArchitectFinal.Destination=null;ArchitectFinal.Returning=false;
    }
    internal static bool OwnsFinal(CombatState state)=>_adventure!=null&&ReferenceEquals(_room?.CombatState,state);
    internal static void AwaitFinalProceed(bool won){
        var adventure=_adventure!;
        if(adventure.Outcome.HasValue)return;
        adventure.Outcome=won;
        Callable.From(()=>{
            if(_adventure!=adventure||_returning)return;
            var view=NCombatRoom.Instance!;
            view.Ui.Deactivate();
            var arrow=view.ProceedButton;
            arrow.Released+=button=>{
                if(!arrow.IsEnabled)return;
                arrow.Disable();
                _=MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(Proceed());
            };
            arrow.Show();arrow.Enable();
        }).CallDeferred();
        async Task Proceed(){
            var run=_run!;
            if(run.Players.Count>1){
                var sync=RunManager.Instance.PlayerChoiceSynchronizer;
                var ready=new List<Task>();
                foreach(var player in run.Players){
                    var id=sync.ReserveChoiceId(player);
                    if(MegaCrit.Sts2.Core.Context.LocalContext.IsMe(player))
                        sync.SyncLocalChoice(player,id,MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult.FromIndexes([]));
                    else ready.Add(sync.WaitForRemoteChoice(player,id));
                }
                await Task.WhenAll(ready);
            }
            if(_adventure==adventure)await FinishFinal(won);
        }
    }
    internal static async Task FinishFinal(bool? won){
        if(_returning)return;_returning=true;var run=_run!;
        // 离开战场先完成原版清理，再恢复药水、遗物计数、路线记录和生命。
        if(run.CurrentRoom==_room&&_room!=null){
            foreach(var player in run.Players)player.AfterCombatEnd();
            AccessTools.DeclaredMethod(typeof(MegaCrit.Sts2.Core.GameActions.Multiplayer.NetCombatCardDb),"OnCombatEnded")?.Invoke(MegaCrit.Sts2.Core.GameActions.Multiplayer.NetCombatCardDb.Instance,[_room]);
            await (Task)AccessTools.Method(typeof(RunManager),"ExitCurrentRoom").Invoke(RunManager.Instance,null)!;
        }
        if(NRun.Instance is {} scene)scene.TreeExiting-=OnAdventureExit;
        var adventure=_adventure;adventure?.Restore();_adventure=null;Release();
        if(won.HasValue)ArchitectFinal.Record(run,won.Value);
        adventure?.RestoreMusic();
        // 重新进入房间时游戏会自行选择音乐段落；原场景续接对话时才需要主动更新。
        if(ArchitectFinal.Destination is {} destination&&ReferenceEquals(run.CurrentRoom,destination))
            MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController.Instance?.UpdateTrack();
        await ArchitectFinal.Continue();
    }
}
internal static class FinalEndHooks {
    private static Action<CombatManager> StopLoop=null!;
    internal static void Install(Harmony harmony){
        // 游戏在判定胜负时同步结束当前回合循环，场景动画结束后才返回建筑师。
        var state=AccessTools.Field(typeof(CombatManager),"_turnState");
        var flag=AccessTools.PropertySetter(state?.FieldType??typeof(CombatManager),"IsInProgress");
        StopLoop=manager=>flag.Invoke(state==null?manager:state.GetValue(manager),[false]);
        harmony.Patch(AccessTools.GetDeclaredMethods(typeof(SaveManager)).Single(m=>m.Name=="SaveRun"&&m.GetParameters()[0].ParameterType==typeof(AbstractRoom)),prefix:new HarmonyMethod(typeof(FinalEndHooks),nameof(KeepCheckpoint)));
        foreach(var m in AccessTools.GetDeclaredMethods(typeof(CombatManager)).Where(m=>m.Name=="CheckWinCondition"))
            harmony.Patch(m,prefix:new HarmonyMethod(typeof(FinalEndHooks),nameof(Check)));
        var kill=AccessTools.GetDeclaredMethods(typeof(CreatureCmd)).Where(m=>m.Name=="Kill"&&m.GetParameters()[0].ParameterType==typeof(IReadOnlyCollection<Creature>)).OrderByDescending(m=>m.GetParameters().Length).First();
        harmony.Patch(AccessTools.AsyncMoveNext(kill),transpiler:new HarmonyMethod(typeof(FinalEndHooks),nameof(KeepAdventure)));
    }
    static bool KeepCheckpoint(ref Task __result){if(!LeagueNativeMatch.InFinal)return true;__result=Task.CompletedTask;return false;}
    static bool Check(CombatManager __instance,ref Task<bool> __result){
        if(!LeagueNativeMatch.IsTeamMatch||!__instance.IsEnding)return true;
        bool won=RunManager.Instance.DebugOnlyGetState()!.Players.Any(p=>p.Creature.IsAlive);
        StopLoop(__instance);
        Callable.From(()=>{_=MegaCrit.Sts2.Core.Helpers.TaskHelper.RunSafely(LeagueNativeMatch.EndTeam(won));}).CallDeferred();
        __result=Task.FromResult(true);return false;
    }
    static IEnumerable<CodeInstruction> KeepAdventure(IEnumerable<CodeInstruction> code){
        bool loss=false;
        foreach(var i in code){
            if(i.Calls(AccessTools.Method(typeof(CombatManager),"LoseCombat")))loss=true;
            yield return i;
            if(loss&&i.operand is MethodInfo {Name:"get_IsOff",DeclaringType.Name:"TestMode"}){
                yield return new CodeInstruction(OpCodes.Call,AccessTools.Method(typeof(FinalEndHooks),nameof(EndAdventure)));loss=false;
            }
        }
    }
    static bool EndAdventure(bool original)=>original&&!LeagueNativeMatch.InFinal&&!LeagueNativeMatch.IsTeamMatch;
}

// 在游戏已经决定胜负时接管正式对决。常驻入口按战斗实例识别房间，读档和前一场的回调互不干扰。
[HarmonyPatch]
internal static class ArchitectCombatOutcome {
    static bool Prepare()=>LeagueSolverLink.Supported;
    internal static readonly Type? Turn=typeof(CombatManager).Assembly.GetType("MegaCrit.Sts2.Core.Combat.CombatTurnState");
    static MethodBase TargetMethod()=>AccessTools.DeclaredMethod(typeof(CombatManager),"EndCombatInternal",[Turn!]);
    internal static bool Handle(object turn,bool won){
        if(!LeagueNativeMatch.InFinal||!LeagueNativeMatch.OwnsFinal((CombatState)AccessTools.Property(Turn,"State").GetValue(turn)!))return true;
        AccessTools.Property(Turn,"IsInProgress").SetValue(turn,false);
        if(!won)AccessTools.Property(Turn,"PendingLoss").SetValue(turn,null);
        LeagueNativeMatch.AwaitFinalProceed(won);return false;
    }
    static bool Prefix(object __0,ref Task __result){
        if(Handle(__0,true))return true;
        __result=Task.CompletedTask;return false;
    }
}
[HarmonyPatch]
internal static class ArchitectCombatLoss {
    static bool Prepare()=>LeagueSolverLink.Supported;
    static MethodBase TargetMethod()=>AccessTools.DeclaredMethod(typeof(CombatManager),"ProcessPendingLoss",[ArchitectCombatOutcome.Turn!]);
    static bool Prefix(object __0)=>ArchitectCombatOutcome.Handle(__0,false);
}
