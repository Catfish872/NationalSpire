using Godot;
using NationalSpire.Coop;
using MegaCrit.Sts2.Core.Assets;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer.Game.Lobby;
using MegaCrit.Sts2.Core.Nodes;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Unlocks;

namespace NationalSpire;
public static partial class LeagueNativeMatch {
    private static string? _teamAttempt;
    internal static bool IsTeamMatch=>_teamAttempt!=null;
    private static void EquipDeck(RunState run,Player player,IEnumerable<CardModel> cards,IReadOnlyDictionary<string,int>? upgrades,int tier){
        player.Deck.Clear(true);var allocation=upgrades?.ToDictionary();
        foreach(var c in cards)player.Deck.AddInternal(LeagueCards.ApplyAllocation(run.CreateCard(c,player),allocation),-1,true);
        player.Creature.SetMaxHpInternal(LeagueLadder.Health(player.Character,tier));player.Creature.SetCurrentHpInternal(player.Creature.MaxHp);
    }
    public static async Task StartTeam(CoopCoordinator session,StartRunLobby lobby,IReadOnlyList<ActModel> acts){
        var world=session.World!;var record=world.Run!;int seed=CareerEngine.StableHash(record.Seed);
        var roster=NativeLobbyApi.Players(lobby).Select(m=>Player.CreateForNewRun(m.Character!,UnlockState.FromSerializable(m.Unlocks!),m.Id)).ToArray();
        var run=LeagueBattleApi.Create(roster,acts.Select(a=>a.ToMutable()).ToList(),record.Seed);
        var game=NGame.Instance!;var mgr=RunManager.Instance;Install();LeagueSolverLink.Prepare();
        _teamAttempt=record.Attempt;_run=run;_returning=false;_opener=LeagueLadder.RivalOpens(seed);
        _mirrorExit=new();
        var pending=new List<LeagueDuel.Hit>();
        var draw=new LeagueLadder.Draw(world.World);
        // 更新前已建立的对局没有随开局记录保存名单，使用同一份共同世界补建。
        LeagueLadder.PrepareRoster(world.World);
        var appointment=world.World.Matches.FirstOrDefault(m=>m.Id==record.MatchId&&m.MirrorAppointment);
        _appointmentId=appointment?.Id;
        foreach(var p in roster.OrderBy(p=>p.NetId)){
            var member=world.Members.Single(m=>m.SteamId==p.NetId);var a=member.Life.League;
            EquipDeck(run,p,LeagueCards.Deck(a)!.SelectMany(k=>Enumerable.Repeat(LeagueCards.Catalog[k.Key].Model,k.Value)),a.Upgrades.GetValueOrDefault(a.Captain),LeagueLadder.Tier(a.Rating));
            var rng=new Random(CareerEngine.StableHash(record.Seed+":"+p.NetId));
            var rival=Team.Count==0 && appointment!=null ? LeagueLadder.Invited(world.World.LeagueRoster!,draw,appointment.OpponentId)!.Value
                : LeagueLadder.Match(world.World.LeagueRoster!,draw,rng,LeagueLadder.Tier(a.Rating));var cards=LeagueLadder.Build(rival.Role,rng,rival.Tier,rival.Style).ToArray();
            var plan=LeagueArchetypes.Resolve(rival.Role.Id.Entry,rival.Style);
            ulong botId=ulong.MaxValue-(ulong)Team.Count;while(roster.Any(h=>h.NetId==botId)||Team.Any(f=>f.Rival.NetId==botId))botId--;
            var bot=Player.CreateForNewRun(rival.Role,p.UnlockState,botId);bot.RunState=run;bot.InitializeSeed(record.Seed+":"+botId);
            int hp=LeagueLadder.Health(rival.Role,rival.Tier);
            Team.Add(new(bot,cards,rng.Next(),rival.Name,rival.Tier,LeagueLadder.UpgradePlan(cards,plan,rival.Tier,rng),pending){PersonId=rival.PersonId,Exit=_mirrorExit.Token,OpeningMax=hp,OpeningHp=hp,SetupCards=plan.Anchors});
        }
        Current=Team[0];var lead=world.Members.Single(m=>m.SteamId==session.Self);var first=Team[0];
        if(CareerScreen.Current is {} screen)await screen.OpeningGate(appointment?.Event ?? "镜面对决   /   团体匹配",CareerAvatars.ForPerson(world.World,lead.PersonId),LeagueLadder.Tier(lead.Life.League.Rating),
            world.Name,string.Join(" · ",world.Members.Where(m=>record.Characters.ContainsKey(m.SteamId)).Select(m=>m.Name)),new(first.Rival.Character.IconTexture,CareerVisuals.Teal,first.OpponentName),first.Tier,"联赛对手",string.Join(" · ",Team.Select(f=>f.OpponentName)),_opener?"对手先手":"你方先手",Begin);
        else await Begin();
        async Task Begin(){
            game.RemoteCursorContainer.Initialize(lobby.InputSynchronizer,roster.Select(p=>p.NetId));
            game.ReactionContainer.InitializeNetworking(lobby.NetService);
            CareerScreen.CloseCurrent();CoopScreen.CloseCurrent();
            bool opening=CareerScreen.UseOpening();
            if(!opening)await game.Transition.FadeOut(.24f);
            mgr.SetUpNewMultiplayer(run,lobby,false);lobby.CleanUp(false);
            await PreloadManager.LoadRunAssets(roster.Select(p=>p.Character).Concat(Team.Select(f=>f.Rival.Character)).Distinct().ToList());
            var encounter=_matchVenue=LeagueEncounter.ForMatch(run,seed);
            await PreloadManager.LoadActAssets(run.Act);mgr.Launch();var scene=EnterMatchScene(game,run);
            scene.TreeExiting+=()=>{if(_run==run&&!_returning){_teamAttempt=null;Release();}};
            await mgr.SetActInternal(run.CurrentActIndex);CombatManager.Instance.TurnStarted+=PlayerTurn;InstallExit(scene);
            var room=(CombatRoom)await mgr.EnterRoomDebug(RoomType.Monster,model:encounter,showTransition:false);
            if(_run!=run||first.Exit.IsCancellationRequested||_returning)return;_room=room;
            if(!opening)await game.Transition.FadeIn(.24f);
        }
    }
    internal static async Task EndTeam(bool won){
        if(_returning||_teamAttempt==null)return;_returning=true;
        var id=_teamAttempt;var session=CoopRuntime.Current!.Session!;
        bool appointment=_appointmentId!=null;
        CoopRules.FinishLeagueTeam(session,id,won,session.Host?_report?.Finish(won):null);
        var game=NGame.Instance!;await game.ReturnToMainMenu();Release();_teamAttempt=null;
        if(game.MainMenu is {} menu){var view=new CoopCareerSession(session,menu);if(appointment)CareerScreen.OpenView(menu,view,"结算");else CareerScreen.OpenTeamReceipt(menu,view,id);}
    }
}
public partial class CareerScreen {
    internal static void OpenTeamReceipt(Control menu,ICareerSession view,string id){
        OpenView(menu,view,"生涯生活");if(Current is not {} screen)return;screen.LeagueGo("对战");screen._teamReceipt=id;screen.PresentTeamReceipt();
    }
    private string? _teamReceipt;
    private void PresentTeamReceipt(){
        if(_teamReceipt!=null&&ViewData.Life.League.LastDuel is {} receipt&&receipt.Fight.Match==_teamReceipt){
            _teamReceipt=null;LeagueAward(receipt);
        }
    }
}
