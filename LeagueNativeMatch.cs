using Godot;
using MegaCrit.Sts2.Core.Nodes.Combat;
using HarmonyLib;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Assets;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Commands;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Hooks;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.MonsterMoves.Intents;
using MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine;
using MegaCrit.Sts2.Core.Nodes;
using MegaCrit.Sts2.Core.Nodes.CommonUi;
using MegaCrit.Sts2.Core.Nodes.Multiplayer;
using MegaCrit.Sts2.Core.Nodes.Rooms;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves;
using MegaCrit.Sts2.Core.ValueProps;

namespace NationalSpire;

public static partial class LeagueNativeMatch
{
    internal static LeagueDuel? Current;
    private static DuelRecorder? _report;
    internal static void RecordSelection(Player player)=>_report?.Choice(player);
    private static CombatRoom? _room;
    private static bool _installed,_opener,_returning;
    private static CancellationTokenSource? _mirrorExit;
    internal static void StopMirrorTurns()=>_mirrorExit?.Cancel();
    private static ICareerSession? _session;
    private static RunState? _run;
    private static LeagueEncounter? _matchVenue;
    internal static ActModel MusicAct(IRunState run)=>ReferenceEquals(run,_run)&&_matchVenue!=null?_matchVenue.Chapter:run.Act;
    private static string? _appointmentId;
    public static Task Start(CharacterModel first,CardModel[] cards,CharacterModel other,CardModel[] rival,int seed,ICareerSession? session,string opponentName,int tier,IReadOnlyDictionary<string,int>? upgrades=null,Dictionary<string,int>? rivalUpgrades=null,int playerTier=0,string? style=null)
        => StartMirror(first,cards,other,rival,seed,session,opponentName,tier,upgrades,rivalUpgrades,playerTier,style,null,null);
    internal static async Task StartMirror(CharacterModel first,CardModel[] cards,CharacterModel other,CardModel[] rival,int seed,ICareerSession? session,string opponentName,int tier,IReadOnlyDictionary<string,int>? upgrades,Dictionary<string,int>? rivalUpgrades,int playerTier,string? style,string? personId,string? appointmentId)
    {
        if(RunManager.Instance.IsInProgress)throw new InvalidOperationException("请先结束当前对局。");
        Install();var unlock=SaveManager.Instance.GenerateUnlockStateFromProgress();
        var hero=Player.CreateForNewRun(first,unlock,1);var bot=Player.CreateForNewRun(other,unlock,2);
        var acts=ActModel.GetRandomList(GameBridge.CreateActSelectionRng(seed.ToString()),unlock,false).Select(a=>a.ToMutable()).ToList();
        var run=LeagueBattleApi.Create([hero],acts,seed.ToString());
        bot.RunState=run;bot.InitializeSeed(seed.ToString());
        EquipDeck(run,hero,cards,upgrades,playerTier);
        _appointmentId=appointmentId;_mirrorExit=new();
        Current=new(bot,rival,seed,opponentName,tier,rivalUpgrades){PersonId=personId,Exit=_mirrorExit.Token};Current.SetupCards=style==null?[]:LeagueArchetypes.Resolve(other.Id.Entry,style).Anchors;_run=run;_session=session;_opener=LeagueLadder.RivalOpens(seed);
        _returning=false;
        try{
            var game=NGame.Instance!;bool opening=CareerScreen.UseOpening();
            if(!opening)await game.Transition.FadeOut(.24f);
            RunManager.Instance.SetUpNewSingleplayer(run,false);await PreloadManager.LoadRunAssets([first,other]);
            var encounter=_matchVenue=LeagueEncounter.ForMatch(run,seed);
            await PreloadManager.LoadActAssets(run.Act);RunManager.Instance.Launch();
            var scene=EnterMatchScene(game,run);
            scene.TreeExiting+=()=>{if(_run==run&&!_returning){Release();_session?.Dispose();_session=null;}};
            await RunManager.Instance.SetActInternal(run.CurrentActIndex);
            CombatManager.Instance.CombatEnded+=Ended;
            CombatManager.Instance.TurnStarted+=PlayerTurn;
            InstallExit(scene);
            var room=(CombatRoom)await RunManager.Instance.EnterRoomDebug(RoomType.Monster,model:encounter,showTransition:false);
            if(_run!=run||_returning)return;_room=room;if(!opening)await game.Transition.FadeIn(.24f);
        }catch(Exception ex){if(_run!=run||_returning)return;Diagnostics.Error("league-match",ex);await Return("对决未能开始 · "+ex.GetBaseException().Message);}
    }
    private static NRun EnterMatchScene(NGame game,RunState run){
        var scene=NRun.Create(run);
        MegaCrit.Sts2.Core.Nodes.Audio.NAudioManager.Instance?.StopMusic();
        game.RootSceneContainer.SetCurrentScene(scene);
        return scene;
    }
    internal static async Task Bind(LeagueOpponent opponent){
        if(Current==null)return;_room=_run?.CurrentRoom as CombatRoom;var fighter=opponent.Fighter??Current;fighter.Attach(opponent.Creature);if(fighter.OpeningHp is {} hp){opponent.Creature.SetMaxHpInternal(fighter.OpeningMax);opponent.Creature.SetCurrentHpInternal(hp);}
        if (_run != null) {
            _report ??= new DuelRecorder(_run, _opener);
            _report.Register(fighter.Rival, fighter.OpponentName, fighter.Rival.PlayerCombatState!.DrawPile.Cards, true, fighter.PersonId);
        }
        if(NCombatRoom.Instance?.GetCreatureNode(opponent.Creature) is {} view)OrbDisplay(view);
        // 原版入房通知只遍历实际玩家。对手绑定自己的战斗状态后，交还其遗物原有的入房效果。
        if(fighter.Rival.RunState.CurrentRoom is CombatRoom room&&!fighter.Rival.RunState.Players.Contains(fighter.Rival))
            foreach(var relic in fighter.Rival.Relics.Where(r=>!r.IsMelted).ToArray()){await relic.AfterRoomEntered(room);relic.InvokeExecutionFinished();}
    }
    internal static async Task First(LeagueOpponent opponent){
        var fighter=opponent.Fighter??Current!;if(_run?.CurrentMapPointHistoryEntry is {} floor&&fighter.Rival is {} rival&&!floor.PlayerStats.Any(p=>p.PlayerId==rival.NetId))
            floor.PlayerStats.Add(new(){PlayerId=rival.NetId});
        if(NCombatRoom.Instance?.GetCreatureNode(opponent.Creature) is {} view)OrbDisplay(view);
        if(!_opener||!fighter.Rival.Creature.IsAlive||!Opened.Add(fighter))return;await fighter.Act();
        if(fighter.Exit.IsCancellationRequested)return;
        // 抢先行动不经过原版敌方回合结束事件，按施加者清理这一轮的出牌标记。
        var actor=fighter.Rival.Creature;
        foreach(var mark in actor.CombatState!.GetOpponentsOf(actor).SelectMany(c=>c.Powers).Where(p=>p.Applier==actor&&p is MegaCrit.Sts2.Core.Models.Powers.StranglePower or MegaCrit.Sts2.Core.Models.Powers.OblivionPower).ToArray())await PowerCmd.Remove(mark);
        Refresh(opponent);
    }
    internal static async Task Enemy(LeagueOpponent opponent){
        _opener=false;var fighter=opponent.Fighter??Current!;await fighter.Act();if(!fighter.Exit.IsCancellationRequested)Refresh(opponent);
    }
    internal static async Task Resolve(CombatSide side){
        var duel=Current;if(duel==null)return;
        foreach(var hit in duel.Pending.Where(h=>h.Target.Side==side).ToArray()){
            var receiver=hit.Target;duel.Pending.Remove(hit);if(!receiver.IsAlive)continue;
            if(NCombatRoom.Instance?.GetCreatureNode(hit.Dealer)?.GetNodeOrNull<GridContainer>("LeagueAttackOrder") is {} icons && icons.GetChildCount()>1 && icons.GetChild(0) is NIntent icon)icon.PlayPerform();
            if(hit.Doom){
                var ctx=new BlockingPlayerChoiceContext();int blocked=Math.Min(receiver.Block,(int)hit.Amount);int extra=(int)hit.Amount-blocked;
                if(blocked>0){await LeagueBattleApi.SpendGuard(ctx,receiver,blocked,hit.Dealer);_report?.Block(receiver,blocked);}
                if(extra>0)(duel.DeferredDoom??=new()).Enqueue(hit with {Amount=extra});
            }else await LeagueBattleApi.Deliver(hit);
            if(duel.Rival.Creature.Monster is LeagueOpponent active)Refresh(active);
        }
        if(duel.Rival.Creature.Monster is LeagueOpponent foe)Refresh(foe);
    }
    internal static async Task ApplyDeferredDoom(PlayerChoiceContext ctx){
        if(Current?.DeferredDoom is not {} queue)return;
        while(queue.TryDequeue(out var hit)){
            if(!hit.Target.IsAlive)continue;
            Task applied;_passApplication=true;
            try{applied=MegaCrit.Sts2.Core.Commands.PowerCmd.Apply<MegaCrit.Sts2.Core.Models.Powers.DoomPower>(ctx,hit.Target,hit.Amount,hit.Dealer,hit.DoomSource);}
            finally{_passApplication=false;}
            await applied;
        }
    }
    private static void Install(){
        if(_installed)return;var h=new Harmony("nationalspire.league.native");
        try{
            LeagueBattleApi.Install(h);FinalEndHooks.Install(h);
            h.Patch(AccessTools.DeclaredMethod(typeof(MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController),"GetTrack"),prefix:new HarmonyMethod(typeof(LeagueEncounter),nameof(LeagueEncounter.MusicRoom)));
            foreach(var method in new[]{"UpdateMusic","UpdateAmbience"})
                h.Patch(AccessTools.DeclaredMethod(typeof(MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController),method),transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(SelectMusicAct)));
            h.Patch(AccessTools.DeclaredMethod(typeof(MegaCrit.Sts2.Core.Models.Powers.ColossusPower),"ModifyDamageMultiplicative"),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(DeferColossus)));
            foreach(var method in new[]{"ApplyInternal","RemoveInternal"})
                h.Patch(AccessTools.DeclaredMethod(typeof(PowerModel),method),postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(DefenseChanged)));
            if(AccessTools.DeclaredMethod(typeof(CombatManager),"RunTurnLoopAfter") is {} loop)
                h.Patch(loop,postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ObserveCombat)));
            h.Patch(AccessTools.Method(typeof(SaveManager),nameof(SaveManager.UpdateProgressAfterCombatWon)),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(KeepAdventureStats)));
            var impaled=typeof(PowerModel).Assembly.GetType("MegaCrit.Sts2.Core.Models.Powers.ImpaledPower");
            if(impaled!=null)h.Patch(AccessTools.DeclaredMethod(impaled,"AfterApplied"),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ArrowOwner)));
            void OwnerPatch(string type,string method,bool async=true){
                var t=typeof(PowerModel).Assembly.GetType("MegaCrit.Sts2.Core."+type);
                if(t==null||AccessTools.DeclaredMethod(t,method) is not {} m)return;
                h.Patch(async?AccessTools.AsyncMoveNext(m):m,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(LeagueOwner)));
            }
            OwnerPatch("Commands.Builders.AttackCommand","Execute");
            OwnerPatch("Models.Powers.HellraiserPower","BeforeAttack",false);
            // 这些卡从战斗记录的执行者读取玩家身份。只适配实际使用这种读取方式的计数条件。
            foreach(var card in new[]{typeof(MegaCrit.Sts2.Core.Models.Cards.HelixDrill),typeof(MegaCrit.Sts2.Core.Models.Cards.Voltaic)})
                foreach(var method in Nested(card).SelectMany(AccessTools.GetDeclaredMethods))
                    if(method.GetMethodBody()!=null && method.GetParameters().Any(p=>typeof(MegaCrit.Sts2.Core.Combat.History.CombatHistoryEntry).IsAssignableFrom(p.ParameterType))
                        && PatchProcessor.ReadMethodBody(method).Any(op=>Equals(op.Value,AccessTools.PropertyGetter(typeof(Creature),nameof(Creature.Player)))))
                        h.Patch(method,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(LeagueOwner)));
            var tune=typeof(PowerModel).Assembly.GetType("MegaCrit.Sts2.Core.Models.Powers.TunePower");
            if(tune!=null){var m=AccessTools.DeclaredMethod(tune,"AfterSideTurnEnd");h.Patch(m,prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(MelodySide)));}
            var eyes=typeof(CardModel).Assembly.GetType("MegaCrit.Sts2.Core.Models.Cards.GoForTheEyes");
            if(eyes!=null)h.Patch(AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(eyes,"OnPlay")),transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(IntentReader)));
            InstallEffectTargets(h);InstallVisuals(h);LeagueDuel.InstallSelections(h);_installed=true;
            h.Patch(AccessTools.DeclaredMethod(typeof(CreatureCmd),"Stun",[typeof(Creature),typeof(string)]),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(StunFighter)));
        }catch{RemoveBattlePatches(h);throw;}
    }
    private static void RemoveBattlePatches(Harmony h){
        h.UnpatchAll(h.Id);EffectPatches.Clear();SeenPowers.Clear();_installed=false;
    }
    private static IEnumerable<CodeInstruction> SelectMusicAct(IEnumerable<CodeInstruction> instructions)=>instructions.MethodReplacer(
        AccessTools.PropertyGetter(typeof(IRunState),nameof(IRunState.Act)),AccessTools.Method(typeof(LeagueNativeMatch),nameof(MusicAct)));
    private static bool StunFighter(Creature creature,ref Task __result){
        if(Current is not {} duel||For(creature)==null&&_run?.Players.Any(p=>p.Creature==creature)!=true)return true;
        if(creature.IsAlive)duel.Stunned.Add(creature);
        __result=Task.CompletedTask;return false;
    }
    internal static bool ConsumeStun(Creature creature){
        if(Current?.Stunned.Remove(creature)!=true)return false;
        if(MegaCrit.Sts2.Core.Nodes.Vfx.NStunnedVfx.Create(creature) is {} fx)NCombatRoom.Instance?.AddChild(fx);
        return true;
    }
    private static void PlayerTurn(CombatState state){
        if(state.CurrentSide!=CombatSide.Player||_run==null)return;
        foreach(var player in _run.Players.Where(p=>state==p.Creature.CombatState&&ConsumeStun(p.Creature)))
            CombatManager.Instance.SetReadyToEndTurn(player,false);
    }
    // 保留原版的射手检查、每回合次数与能量结算。只有联赛敌方角色需要从对战资料取得玩家实例。
    private static IEnumerable<CodeInstruction> LeagueOwner(IEnumerable<CodeInstruction> instructions){
        var getter=AccessTools.PropertyGetter(typeof(Creature),nameof(Creature.Player));
        foreach(var instruction in instructions){
            if(instruction.Calls(getter)){instruction.opcode=System.Reflection.Emit.OpCodes.Call;instruction.operand=AccessTools.Method(typeof(LeagueNativeMatch),nameof(LeaguePlayer));}
            yield return instruction;
        }
    }
    private static Player? LeaguePlayer(Creature owner)=>For(owner)?.Rival??owner.Player;
    private static void MelodySide(PowerModel __instance,ref CombatSide side){if(For(__instance.Owner)!=null)side=side==CombatSide.Enemy?CombatSide.Player:CombatSide.Enemy;}
    private static IEnumerable<CodeInstruction> IntentReader(IEnumerable<CodeInstruction> instructions){
        var code=instructions.ToList();for(int i=0;i<code.Count-1;i++)if(code[i].Calls(AccessTools.PropertyGetter(typeof(Creature),"Monster"))&&code[i+1].Calls(AccessTools.PropertyGetter(typeof(MonsterModel),"IntendsToAttack"))){
            code[i].opcode=System.Reflection.Emit.OpCodes.Call;code[i].operand=AccessTools.Method(typeof(LeagueNativeMatch),nameof(HasAttack));code[i+1].opcode=System.Reflection.Emit.OpCodes.Nop;code[i+1].operand=null;
        }return code;
    }
    private static bool HasAttack(Creature c)=>Current is {} duel&&c.CombatState==duel.Rival.Creature.CombatState?duel.Pending.Any(h=>h.Dealer==c&&h.Amount>0):c.Monster?.IntendsToAttack==true;
    private static Button? _exit;
    private static NGenericPopup? _exitDialog;
    private static bool _interrupted;
    private static void ObserveCombat(Task __result){if(Current is {} duel)_=NoticeFailure(__result,duel);}
    private static async Task NoticeFailure(Task running,LeagueDuel duel){
        try{await running;}
        catch(Exception error) when(error is not OperationCanceledException){
            if(Current!=duel||_returning)return;
            if(InFinal){Diagnostics.Error("league-match",error);await FinishFinal(null);return;}
            if(!GodotObject.IsInstanceValid(_exit))return;
            Diagnostics.Error("league-match",error);
            _interrupted=true;_exit!.Text="返回赛场";ShowExit();
        }catch(OperationCanceledException){}
    }
    private static void InstallExit(NRun scene){
        var button=CareerScreen.LeagueExitButton(ShowExit);_exit=button;scene.AddChild(button);
        button.TooltipText="退出本场对战";button.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.TopRight);
        button.OffsetLeft=-186;button.OffsetRight=-40;button.OffsetTop=90;button.OffsetBottom=134;
    }
    private static void ShowExit(){
        var modals=NModalContainer.Instance;
        if(Current==null||_returning||modals==null)return;
        if(modals.OpenModal!=null&&modals.OpenModal!=_exitDialog)return;
        bool create=!GodotObject.IsInstanceValid(_exitDialog)||_exitDialog!.IsQueuedForDeletion();
        if(create){_exitDialog=NGenericPopup.Create()!;modals.Add(_exitDialog);}
        var panel=_exitDialog!.GetNode<NVerticalPopup>("VerticalPopup");
        panel.SetText(_interrupted?"本场对战中断":"退出本场对战？",(_interrupted?"本回合无法继续。":"")+(IsTeamMatch?"退出后，全队结束本场对战。":"退出后将返回集卡赛场。")+"本场不记录胜负或积分。");
        if(!create)return;
        LocManager.Instance.GetTable("main_menu_ui").MergeWith(new(){["NATIONAL_SPIRE.LEAGUE_STAY"]="留在战场",["NATIONAL_SPIRE.LEAGUE_EXIT"]="退出对战"});
        panel.InitNoButton(new("main_menu_ui","NATIONAL_SPIRE.LEAGUE_STAY"),_=>{});
        panel.InitYesButton(new("main_menu_ui","NATIONAL_SPIRE.LEAGUE_EXIT"),b=>{
            if(Current==null||_returning)return;
            if(IsTeamMatch)_=Coop.CoopRuntime.Current!.Pause();else{_returning=true;_=Return("本场已中止。");}
        });
    }
    private static bool KeepAdventureStats(CombatRoom combatRoom)=>Current==null||combatRoom!=_room;
    private static bool ArrowOwner(PowerModel __instance,Creature? applier,ref Task __result){
        if(For(applier) is not {} shooter)return true;
        ((MegaCrit.Sts2.Core.Localization.DynamicVars.StringVar)__instance.DynamicVars["Applier"]).StringValue=shooter.OpponentName;
        __result=Task.CompletedTask;return false;
    }
    [ThreadStatic] private static bool _recordingIntent;
    private static bool DeferColossus(ref decimal __result){if(!_recordingIntent)return true;__result=1;return false;}
    private static void DefenseChanged(PowerModel __instance){
        if(__instance is not (MegaCrit.Sts2.Core.Models.Powers.IntangiblePower or MegaCrit.Sts2.Core.Models.Powers.ColossusPower or MegaCrit.Sts2.Core.Models.Powers.VulnerablePower))return;
        if(Current is {Pending.Count:>0} duel && __instance.Owner?.CombatState==_room?.CombatState && duel.Rival.Creature.Monster is LeagueOpponent opponent)Refresh(opponent);
    }
    internal static bool QueueHits(IEnumerable<(Creature Target,string? Vfx,bool Center)> targets,decimal amount,ValueProp props,Creature? dealer,CardModel? source,CardPlay? play,ModifyDamageHookType modifiers,ref Task<IEnumerable<DamageResult>> result){
        if(Current==null||_room==null||dealer==null||dealer.CombatState!=_room.CombatState)return true;
        if(dealer.Monster is MegaCrit.Sts2.Core.Models.Monsters.Osty && dealer.IsDead)return true;
        var items=targets.ToArray();if(items.Length==0||items.Any(t=>t.Target.Side==dealer.Side))return true;
        foreach(var item in items){
            // 力量和易伤按出牌时计算；每击上限留到防守方结束行动时判断。
            decimal val;bool previous=_recordingIntent;_recordingIntent=true;
            try{val=Hook.ModifyDamage(_run!,_room.CombatState,item.Target,dealer,amount,props,source,play,modifiers&~ModifyDamageHookType.Cap,CardPreviewMode.None,out _);}
            finally{_recordingIntent=previous;}
            _report?.Declare(dealer,(int)Math.Max(0,val),false);
            Current.Pending.Add(new(dealer,item.Target,Math.Max(0,val),props,item.Vfx,item.Center){Cap=modifiers&ModifyDamageHookType.Cap,AllowColossus=modifiers.HasFlag(ModifyDamageHookType.Multiplicative)});
        }
        if(Current.Rival.Creature.Monster is LeagueOpponent foe)Refresh(foe);
        result=Task.FromResult<IEnumerable<DamageResult>>(items.Select(t=>new DamageResult(t.Target,props)).ToList());return false;
    }
    private static void Refresh(LeagueOpponent foe){
        if(Current==null||foe.Creature.CombatState==null||NCombatRoom.Instance==null)return;
        foreach(var creature in Fighters.Select(f=>f.Rival.Creature).Concat(_run!.Players.Select(p=>p.Creature))){
            var node=NCombatRoom.Instance.GetCreatureNode(creature);if(node==null)continue;
            bool team=_run.Players.Count>1;if(team)ShowTeamIntent(creature,node);
            var line=node.GetNodeOrNull<GridContainer>("LeagueAttackOrder");
            if(line==null){line=new(){Name="LeagueAttackOrder",Columns=team?3:6,MouseFilter=Control.MouseFilterEnum.Ignore};
                line.AddThemeConstantOverride("h_separation",3);line.AddThemeConstantOverride("v_separation",2);node.AddChild(line);}
            var hits=Current.Pending.Where(h=>h.Dealer==creature||h.Dealer.PetOwner?.Creature==creature).ToArray();
            var sum=line.GetNodeOrNull<Label>("Total");
            if(sum==null){sum=new Label{Name="Total",VerticalAlignment=VerticalAlignment.Center,MouseFilter=Control.MouseFilterEnum.Ignore};
                sum.AddThemeFontSizeOverride("font_size",26);sum.AddThemeConstantOverride("outline_size",6);line.AddChild(sum);}
            int shown=line.GetChildCount()-1;
            while(shown>hits.Length){var old=line.GetChild(--shown);line.RemoveChild(old);old.QueueFree();}
            for(int i=0;i<hits.Length;i++){
                NIntent icon;
                if(i<shown)icon=line.GetChild<NIntent>(i);
                else{icon=NIntent.Create(i*.3f);line.AddChild(icon);line.MoveChild(icon,i);}
                var hit=hits[i];icon.UpdateIntent(hit.Doom?new DoomIntent(hit.Shown):new RecordedIntent(hit.Shown),[hit.Target],hit.Dealer);
            }
            sum.Text=hits.Any(h=>h.Doom)?$"（伤害 {hits.Where(h=>!h.Doom).Sum(h=>h.Shown)} · 灾厄 {hits.Where(h=>h.Doom).Sum(h=>h.Shown)}）":$"（{hits.Sum(h=>h.Shown)}）";sum.Visible=!team;line.Visible=hits.Length>0;
            line.ResetSize();var anchor=node.IntentContainer;
            float orbit=LeaguePlayer(creature)?.PlayerCombatState?.OrbQueue.Capacity>0?106:0;
            line.Position=anchor.Position+anchor.Size*.5f-new Vector2(line.Size.X/2,line.Size.Y-32+orbit);
            if(team){var viewport=node.GetViewportRect();var rect=line.GetGlobalRect();line.GlobalPosition+=new Vector2(Math.Clamp(rect.Position.X,viewport.Position.X+8,Math.Max(viewport.Position.X+8,viewport.End.X-rect.Size.X-8))-rect.Position.X,0);}

        }
    }
    // 多人按受击者归集全体对手的攻击。头像和姓名只在首次创建时读取。
    private static void ShowTeamIntent(Creature target,NCreature node){
        var hits=Current!.Pending.Where(h=>h.Target==target||h.Target.PetOwner?.Creature==target).ToArray();
        var badge=node.GetNodeOrNull<PanelContainer>("LeagueIncoming");
        if(hits.Length==0&&target.Player==null){badge?.Hide();return;}
        if(badge==null){
            var session=Coop.CoopRuntime.Current!.Session!;var world=session.World!;
            var member=world.Members.FirstOrDefault(m=>m.SteamId==target.Player?.NetId);
            var fighter=For(target);int index=fighter==null?-1:Team.IndexOf(fighter);
            bool local=member!=null&&member.SteamId==session.Self;
            var art=member!=null?(AvatarImages.Read(member.Avatar)??new AvatarArt(target.Player!.Character.IconTexture,CareerVisuals.Teal,member.Name)):
                index>=0&&world.Run!=null&&index<world.Run.Opponents.Count?CareerAvatars.ForPerson(world.World,world.Run.Opponents[index]):
                new AvatarArt(fighter?.Rival.Character.IconTexture,CareerVisuals.Teal,TargetName(target));
            badge=new PanelContainer{Name="LeagueIncoming",MouseFilter=Control.MouseFilterEnum.Stop};
            badge.AddThemeStyleboxOverride("panel",CareerVisuals.Box("14232df0",local?"78d9cd":"967e60",8,1));node.AddChild(badge);
            var row=new HBoxContainer();row.AddThemeConstantOverride("separation",5);badge.AddChild(row);
            row.AddChild(new CareerAvatar{Art=art,CustomMinimumSize=new(38,38),MouseFilter=Control.MouseFilterEnum.Ignore});
            var col=new VBoxContainer();col.AddThemeConstantOverride("separation",0);row.AddChild(col);
            var who=new Label{Text=(local?"你 · ":"")+(member?.Name??TargetName(target)),CustomMinimumSize=new(104,0),TextOverrunBehavior=TextServer.OverrunBehavior.TrimEllipsis};
            who.AddThemeFontSizeOverride("font_size",15);col.AddChild(who);
            var total=new Label{Name="IncomingTotal"};total.AddThemeColorOverride("font_color",new Color("ffc082"));total.AddThemeFontSizeOverride("font_size",21);col.AddChild(total);
        }
        int damage=hits.Where(h=>!h.Doom&&h.Target==target).Sum(h=>h.Shown),doom=hits.Where(h=>h.Doom&&h.Target==target).Sum(h=>h.Shown);
        var pet=hits.Where(h=>h.Target!=target).Sum(h=>h.Shown);
        var value=badge.GetChild(0).GetChild(1).GetChild<Label>(1);
        value.Text="来袭 "+damage+(doom>0?"  灾厄 "+doom:"")+(pet>0?"  随从 "+pet:"");
        badge.TooltipText=string.Join("\n",hits.GroupBy(h=>(h.Dealer,h.Target)).Select(g=>TargetName(g.Key.Dealer)+" → "+TargetName(g.Key.Target)+"  "+string.Join(" + ",g.Select(h=>(h.Doom?"灾厄 ":"")+h.Shown))));
        badge.Show();badge.ResetSize();badge.Position=new(-badge.Size.X/2,42);
    }
    // 伤害已在出牌时计算；原生意图只需根据这个结果选择图标。
    private sealed class DoomIntent(int value):StatusIntent(value){
        public override Texture2D GetTexture(IEnumerable<Creature> targets,Creature owner)=>ModelDb.Power<MegaCrit.Sts2.Core.Models.Powers.DoomPower>().Icon;
    }
    private sealed class RecordedIntent(int value):SingleAttackIntent(value){
        public override int GetTotalDamage(IEnumerable<Creature> targets,Creature owner)=>(int)DamageCalc!();
    }
    private static void Ended(CombatRoom room){if(room==_room&&!_returning){_returning=true;bool won=_run!.Players[0].Creature.IsAlive;Callable.From(()=>{_=Return(won?"对决胜利":"对决结束 · 惜败",won);}).CallDeferred();}}
    private static void Release(){
        _report?.Dispose();_report=null;_appointmentId=null;
        StopMirrorTurns();_mirrorExit?.Dispose();_mirrorExit=null;
        _matchVenue=null;
        if(_exitDialog!=null&&NModalContainer.Instance?.OpenModal==_exitDialog)NModalContainer.Instance.Clear();
        CombatManager.Instance.CombatEnded-=Ended;CombatManager.Instance.TurnStarted-=PlayerTurn;foreach(var f in Fighters)f.Rival.PlayerCombatState?.AfterCombatEnd();Team.Clear();Opened.Clear();Current=null;_room=null;_run=null;_exit=null;_exitDialog=null;_interrupted=false;
        if(_installed)RemoveBattlePatches(_leagueHarmony);
    }
    private static async Task Return(string? result,bool? won=null){
        _returning=true;var session=_session;_session=null;var appointment=_appointmentId;
        if(!won.HasValue)StopMirrorTurns();
        var finish=won.HasValue&&Current is {} d?new LeagueFinish(Guid.NewGuid().ToString("N"),d.OpponentName,d.Tier){Report=_report?.Finish(won.Value)}:null;
        var game=NGame.Instance!;if(_run!=null&&RunManager.Instance.DebugOnlyGetState()==_run)await game.ReturnToMainMenu();
        Release();
        if(game.MainMenu is {} menu&&result!=null){
            if(appointment==null)CareerScreen.OpenLeagueResult(menu,session,result,won,finish);
            else {
                var data=CareerStore.Data;
                if(finish?.Report is {} report && data.Matches.FirstOrDefault(m=>m.Id==appointment) is {} match){
                    PrivateAppointments.SettleMirror(data,match,report);CareerStore.Save(data);
                }
                CareerScreen.OpenView(menu,session,finish==null?"赛事":"结算");
            }
        }
    }
}
public sealed class LeagueEncounter : EncounterModel
{
    private RoomType _musicRoom;
    internal ActModel Chapter {get;private set;}=null!;
    private string _bossMusic="";
    public override string CustomBgm=>_bossMusic;
    // 房间本身始终是联赛战斗；只有音乐控制器读取场地对应的战斗段落。
    internal static void MusicRoom(ref RoomType roomType){
        if(roomType==RoomType.Monster&&RunManager.Instance.DebugOnlyGetState()?.CurrentRoom is CombatRoom {Encounter:LeagueEncounter duel})roomType=duel._musicRoom;
    }
    internal static LeagueEncounter ForMatch(RunState run,int seed){
        var rng=new Random(CareerEngine.StableHash(seed.ToString(System.Globalization.CultureInfo.InvariantCulture)+":venue"));
        var chapter=run.Acts[rng.Next(Math.Min(3,run.Acts.Count))];
        int roll=rng.Next(5);
        if(roll!=4)return Venue(run,chapter,roll==3?RoomType.Elite:RoomType.Monster,null);
        var bosses=chapter.AllBossEncounters.OrderBy(b=>b.Id.Entry,StringComparer.Ordinal).ToArray();
        return bosses.Length==0?Venue(run,chapter,RoomType.Monster,null):Venue(run,chapter,RoomType.Boss,bosses[rng.Next(bosses.Length)]);
    }
    internal static LeagueEncounter ForFinal(RunState run){
        var last=run.MapPointHistory.ElementAtOrDefault(run.CurrentActIndex)?.SelectMany(f=>f.Rooms).LastOrDefault(r=>r.RoomType==RoomType.Boss);
        var boss=last?.ModelId is {} id?ModelDb.GetByIdOrNull<AbstractModel>(id) as EncounterModel:null;
        return boss?.RoomType==RoomType.Boss?Venue(run,run.Act,RoomType.Boss,boss):Venue(run,run.Act,RoomType.Monster,null);
    }
    private static LeagueEncounter Venue(RunState run,ActModel chapter,RoomType music,EncounterModel? boss){
        var duel=(LeagueEncounter)ModelDb.Encounter<LeagueEncounter>().ToMutable();
        duel._musicRoom=music;duel.Chapter=chapter;
        if(boss!=null){
            duel._bossMusic=boss.CustomBgm;
            // 预加载和绘制都从同一遭遇实例读取这份背景，首领及其战斗脚本不进入联赛。
            Background.Cache(duel)=Background.Read(boss.ToMutable(),chapter,NCombatRoom.GenerateBackgroundRngForCurrentPoint(run));
        }else if(chapter!=run.Act)Background.Cache(duel)=chapter.GenerateBackgroundAssets(NCombatRoom.GenerateBackgroundRngForCurrentPoint(run));
        return duel;
    }
    private static class Background {
        internal static readonly AccessTools.FieldRef<EncounterModel,BackgroundAssets> Cache=AccessTools.FieldRefAccess<EncounterModel,BackgroundAssets>("_backgroundAssets");
        internal static readonly Func<EncounterModel,ActModel,MegaCrit.Sts2.Core.Random.Rng,BackgroundAssets> Read=AccessTools.DeclaredMethod(typeof(EncounterModel),"GetBackgroundAssets").CreateDelegate<Func<EncounterModel,ActModel,MegaCrit.Sts2.Core.Random.Rng,BackgroundAssets>>();
    }
    public override RoomType RoomType=>RoomType.Monster;
    public override bool ShouldGiveRewards=>false;
    public override IEnumerable<MonsterModel> AllPossibleMonsters=>[ModelDb.Monster<LeagueOpponent>()];
    protected override IReadOnlyList<(MonsterModel,string?)> GenerateMonsters()=>LeagueNativeMatch.Opponents();
}
public sealed class LeagueOpponent : MonsterModel
{
    internal LeagueDuel? Fighter {get;set;}
    private CharacterModel Role=>(Fighter??LeagueNativeMatch.Current)?.Rival.Character??ModelDb.Character<MegaCrit.Sts2.Core.Models.Characters.Ironclad>();
    public override int MinInitialHp=>Fighter?.OpeningMax??LeagueLadder.Health(Role,LeagueNativeMatch.Current?.Tier??0);
    public override int MaxInitialHp=>MinInitialHp;
    public override bool ShouldShowInCompendium=>false;
    public override LocString Title=>Role.Title;
    public override string DeathSfx=>Role.DeathSfx;
    protected override string VisualsPath=>LeagueBattleApi.VisualsPath(Role);
    public override CreatureAnimator GenerateAnimator(MegaSprite sprite)=>LeagueBattleApi.Animator(Role,sprite,Creature);
    protected override MonsterMoveStateMachine GenerateMoveStateMachine(){var move=new MoveState("LEAGUE_PLAY",_=>LeagueNativeMatch.Enemy(this));move.FollowUpState=move;return new([move],move);}
    public override Task AfterAddedToRoom()=>LeagueNativeMatch.Bind(this);
    public override Task AfterPlayerTurnStartEarly(PlayerChoiceContext context,Player player)=>player.NetId!=LeagueNativeMatch.HumanLead||LeagueNativeMatch.For(player)!=null?Task.CompletedTask:LeagueNativeMatch.First(this);
    public override Task BeforeSideTurnEndVeryEarly(PlayerChoiceContext context,CombatSide side,IEnumerable<Creature> participants)=>ReferenceEquals(this,LeagueNativeMatch.FirstLiving)?LeagueNativeMatch.Resolve(side):Task.CompletedTask;
    public override Task AfterSideTurnEndLate(PlayerChoiceContext context,CombatSide side,IEnumerable<Creature> participants)=>ReferenceEquals(this,LeagueNativeMatch.FirstLiving)?LeagueNativeMatch.ApplyDeferredDoom(context):Task.CompletedTask;
}
public partial class CareerScreen
{
    internal static void OpenLeagueResult(Control menu,ICareerSession? session,string result,bool? won,LeagueFinish? finish){OpenView(menu,session,"生涯生活");if(Current is {} screen){screen.LeagueGo("对战");if(won.HasValue&&finish!=null)screen.LeagueAction("result",System.Text.Json.JsonSerializer.Serialize(finish),won.Value?1:0);else screen.Notice(result,false);}}
}
