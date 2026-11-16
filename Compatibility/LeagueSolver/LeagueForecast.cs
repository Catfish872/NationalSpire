using CombatSolver;
using CombatSolver.Engine.Common;
using CombatSolver.Engine.InCombat.Mirrors.Orbs;
using CombatSolver.Engine.InCombat.Mirrors;
using CombatSolver.Engine.InCombat.Mirrors.Hooks.Damage;
using CombatSolver.Engine.InCombat.Mirrors.Hooks.Card;
using CombatSolver.Engine.InCombat.Simulation;
using HarmonyLib;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.FoolArrows;
using MegaCrit.Sts2.Core.Models.Powers;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Hooks;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Monsters.Mocks;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.ValueProps;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace NationalSpire.Solver;

// 该程序集由主模组按需加载。每一条候选路线使用 CombatSolver 的独立模拟分支。
public sealed partial class LeagueForecast : IDisposable
{
    private readonly Player _live;private readonly int _tier;private readonly bool _legend;
    private static bool _installed;
    private sealed class Ledger {
        internal readonly Dictionary<Creature,decimal> Hits=[];internal readonly Dictionary<Creature,int> Stacks=[];
        internal void Copy(Ledger src){foreach(var p in src.Hits)Hits[p.Key]=p.Value;foreach(var p in src.Stacks)Stacks[p.Key]=p.Value;}
    }
    private static readonly ConditionalWeakTable<CombatPredictionSimulator,Ledger> Damage=new();
    private readonly record struct Play(CardModel? Live,string Id,int Level,int Aim,int[] Choices);
    public int[] LastChoices {get;private set;}=[];
    public (CardModel,int,int[])[] Continuation(){var result=_route.TakeWhile(x=>x.Live!=null).Select(x=>(x.Live!,x.Aim,x.Choices)).ToArray();_route.Clear();return result;}
    public int LastAim {get;private set;}=-1;
    public bool EndTurn {get;private set;}
    private sealed record Branch(CombatPredictionSimulator Sim,List<Play> Route,decimal Score);
    private readonly Queue<Play> _route=[];
    private readonly Dictionary<CardModel,CardModel> _originals=new(ReferenceEqualityComparer.Instance);
    private Player? _actor;
    private int _captured;
    private readonly HashSet<string> _setup;
    private static Func<int,int> _addedDoom=null!;
    private readonly int _preferredTarget;
    private readonly CancellationToken _exit;
    public LeagueForecast(Player rival,int tier,string[] setup,Func<int,int> addedDoom,int preference,CancellationToken exit=default){
        _exit=exit;
        _preferredTarget=preference;
        _addedDoom=addedDoom;
        _setup=new(setup);
        _live=rival;_tier=Math.Min(tier,2);_legend=tier==3;
        Prepare();
    }
    public static void Prepare(){
        if(_installed)return;
        var harmony=new Harmony("nationalspire.league.forecast");
        InstallProjection(harmony);
        harmony.Patch(AccessTools.Method(typeof(RootCombatHistorySnapshot),"Capture"),prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(UseMappedHistory)));
        harmony.Patch(AccessTools.Method(typeof(PredictionModPatchAudit),"TryDescribeForeignPatch"),prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(MirroredIntent)));
        // 独立加载的上游组件使用调试输出，不启动其普通模组的日志写入和回合订阅。
        harmony.Patch(AccessTools.Method(typeof(CombatSolverLog),"Write"),prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(DebugOutput)));
        AccessTools.PropertySetter(typeof(Entry),"Logger").Invoke(null,[RuntimeHelpers.GetUninitializedObject(typeof(CombatSolverLog))]);
        CombatSolver.Engine.InCombat.Mirrors.Cards.OnPlay.CardOnPlayMirrors.AllowInference=true;
        var method=AccessTools.Method(typeof(CombatPredictionSimulator),"Damage",[typeof(IReadOnlyList<Creature>),typeof(decimal),typeof(ValueProp),typeof(Creature),typeof(PredictedCard),typeof(CardPlay),typeof(ModifyDamageHookType)]);
        harmony.Patch(method,prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(Intent)));
        harmony.Patch(AccessTools.DeclaredMethod(typeof(AfterCardPlayedMirrors),"HandleStranglePower"),transpiler:new HarmonyMethod(typeof(LeagueForecast),nameof(StrangleSource)));
        harmony.Patch(AccessTools.DeclaredMethod(typeof(PowerLifecycleSupport),"ResolvePowerAmountChanges"),transpiler:new HarmonyMethod(typeof(LeagueForecast),nameof(FleshSource)));
        foreach(var effect in LeagueOwnTurnLoss.Effects)
            harmony.Patch(AccessTools.DeclaredMethod(typeof(AfterDamageReceivedMirrors),"Handle"+effect.Name),prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(OwnTurnLoss)));
        harmony.Patch(AccessTools.Method(typeof(SimulatedCombatState),"ModifyPowerAmountForRelics"),postfix:new HarmonyMethod(typeof(LeagueForecast),nameof(SimDoom)));
        // 首次匹配的倒计时在前台播放，常用的卡牌模拟方法可在后台提前编译。
        foreach(var type in new[]{typeof(LeagueForecast),typeof(SimulatedCombatState),typeof(CombatPredictionSimulator),typeof(PredictionModPatchAudit)})
            foreach(var m in type.GetMethods(System.Reflection.BindingFlags.Instance|System.Reflection.BindingFlags.Static|System.Reflection.BindingFlags.Public|System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.DeclaredOnly).Cast<System.Reflection.MethodBase>().Concat(type.GetConstructors()))
                if(!m.ContainsGenericParameters && !m.IsAbstract && (m.IsConstructor||m.Name is "Capture" or "ManualPlay" or "Fork" or "CanPlay" or "Damage"))
                    RuntimeHelpers.PrepareMethod(m.MethodHandle);
        _installed=true;
    }
    private static bool DebugOutput(string message){Debug.WriteLine(message);return false;}
    [ThreadStatic] private static Ledger? _move;
    [ThreadStatic] private static (Creature? Dealer,Creature? Target) _incoming;
    private static bool OwnTurnLoss(AfterDamageReceivedMirrorContext context) =>
        context.Target!=_incoming.Target||context.Dealer!=_incoming.Dealer||context.Source!=null;
    private static void SimDoom(PowerModel power,Creature target,Creature? applier,ref int __result){
        if(power is not DoomPower||__result<=0)return;
        if(target.Side==applier?.Side){__result=_addedDoom(__result);return;}
        if(_move!=null){_move.Stacks[target]=_move.Stacks.GetValueOrDefault(target)+__result;__result=0;}
    }
    // 仅联赛自己的眼部攻击读取方式已在下方的目标意图中建模。其他补丁仍交给上游逐项核对。
    private static bool MirroredIntent(Patch patch,System.Reflection.MethodBase target){
        if(patch.owner=="nationalspire.league.native"&&patch.PatchMethod.DeclaringType?.FullName=="NationalSpire.LeagueBattleApi"&&patch.PatchMethod.Name==nameof(OwnTurnLoss))return false;
        if(patch.owner!="nationalspire.league.native"||patch.PatchMethod.DeclaringType?.FullName!="NationalSpire.LeagueNativeMatch")return true;
        if(patch.PatchMethod.Name=="IntentReader")return target.DeclaringType?.DeclaringType!=typeof(MegaCrit.Sts2.Core.Models.Cards.GoForTheEyes);
        // 推演里的 AI 本来就在玩家一侧，原有敌方名单正是联赛持有者的对面。
        if(target.DeclaringType==typeof(StranglePower)||target.DeclaringType==typeof(OblivionPower)||target.DeclaringType?.DeclaringType==typeof(StranglePower))
            if(patch.PatchMethod.Name is "LeagueOwner" or "EndCardMark" or "StrangleDamage")return false;
        if(patch.PatchMethod.Name=="FleshOpponent"&&target.DeclaringType?.DeclaringType==typeof(SleightOfFleshPower))return false;
        return patch.PatchMethod.Name!="ResolveEffectSides";
    }
    // 上游仍负责逐张配对与叠层；只有紧勒原本匿名的失血交给联赛的意图记录。
    private static IEnumerable<CodeInstruction> StrangleSource(IEnumerable<CodeInstruction> code){
        foreach(var i in code){
            if(i.operand is System.Reflection.MethodInfo m&&m.DeclaringType==typeof(CombatPredictionSimulator)&&m.Name=="Damage"&&m.GetParameters() is [var first,_,_,_]&&first.ParameterType==typeof(Creature)){
                yield return new CodeInstruction(System.Reflection.Emit.OpCodes.Ldarg_0).MoveLabelsFrom(i).MoveBlocksFrom(i);
                yield return new CodeInstruction(System.Reflection.Emit.OpCodes.Call,AccessTools.Method(typeof(LeagueForecast),nameof(StrangleIntent)));
            }else yield return i;
        }
    }
    private static IReadOnlyList<DamageResult> StrangleIntent(CombatPredictionSimulator sim,Creature target,decimal amount,ValueProp props,Creature? dealer,StranglePower power)=>
        PowerIntent(sim,target,amount,props&~ValueProp.Unblockable,power.Applier??dealer);
    private static IEnumerable<CodeInstruction> FleshSource(IEnumerable<CodeInstruction> code){
        bool flesh=false;
        foreach(var i in code){
            if(i.opcode==System.Reflection.Emit.OpCodes.Ldstr&&Equals(i.operand,nameof(SleightOfFleshPower)))flesh=true;
            if(flesh&&i.operand is System.Reflection.MethodInfo m&&m.DeclaringType==typeof(CombatPredictionSimulator)&&m.Name=="Damage"&&m.GetParameters() is [var t,_,_,_]&&t.ParameterType==typeof(Creature)){
                i.opcode=System.Reflection.Emit.OpCodes.Call;i.operand=AccessTools.Method(typeof(LeagueForecast),nameof(PowerIntent));flesh=false;
            }
            yield return i;
        }
    }
    private static IReadOnlyList<DamageResult> PowerIntent(CombatPredictionSimulator sim,Creature target,decimal amount,ValueProp props,Creature? dealer)=>
        sim.Damage([target],amount,props,dealer,null,null);
    private static bool Intent(CombatPredictionSimulator __instance,IReadOnlyList<Creature> targets,decimal amount,ValueProp props,Creature? dealer,
        PredictedCard? cardSource,CardPlay? cardPlay,ModifyDamageHookType modifyDamageHookType,ref IReadOnlyList<DamageResult> __result){
        if(!Damage.TryGetValue(__instance,out var log)||modifyDamageHookType==ModifyDamageHookType.None)return true;
        var kind=__instance.ResolveDamageSource(cardSource).Kind;
        if(kind==CombatDamageSourceKind.Poison&&targets.Count>0){props&=~ValueProp.Unblockable;dealer=__instance.State.CombatState.GetOpponentsOf(targets[0]).FirstOrDefault(c=>c.IsAlive);}
        if(dealer==null||targets.Any(t=>t.Side==dealer.Side))return true;
        foreach(var t in targets){
            var value=Math.Max(0,HookMirrors.ModifyDamage(__instance,t,dealer,amount,props,cardSource,cardPlay,modifyDamageHookType&~ModifyDamageHookType.Cap));
            log.Hits[t]=log.Hits.GetValueOrDefault(t)+value;
        }
        __result=targets.Select(t=>new DamageResult(t,props)).ToArray();return false;
    }
    public async Task<CardModel?> Choose(decimal[] amounts,int[] properties,bool[] capped,int[] dealers){
        EndTurn=false;
        var live=_live.PlayerCombatState!;var realHand=live.Hand.Cards;if(!realHand.Any(c=>c.CanPlay()))return null;
        CardModel? Take(){
            if(!_route.TryDequeue(out var next))return null;LastAim=next.Aim;LastChoices=next.Choices;
            return realHand.FirstOrDefault(c=>(next.Live==null?c.Id.Entry==next.Id:ReferenceEquals(c,next.Live))&&c.CurrentUpgradeLevel==next.Level&&c.CanPlay());
        }
        if(Take() is {} next)return next;_route.Clear();Dispose();
        string? report=Environment.GetEnvironmentVariable("LEAGUE_PREVIEW_ROOT");long before=report==null?0:GC.GetAllocatedBytesForCurrentThread();
        var watch=Stopwatch.StartNew();var (root,targets)=Capture(amounts.Any(v=>v>0));double capture=watch.Elapsed.TotalMilliseconds;
        long captureBytes=report==null?0:GC.GetAllocatedBytesForCurrentThread()-before,searchBytes=0;double searchMs=0;
        var aimOrder=_preferredTarget<0?targets:targets.OrderByDescending(t=>_aims[t]==_preferredTarget).ToArray();
        var attackers=dealers.Select(id=>targets.FirstOrDefault(t=>_aims[t]==id)).ToArray();
        var actor=_actor!;int expanded=0;bool attempted=false,incomplete=false;var best=await Task.Run(()=>{
            long allocated=report==null?0:GC.GetAllocatedBytesForCurrentThread();long started=Stopwatch.GetTimestamp();
            try{
            var clock=Stopwatch.StartNew();var me=root.State.GetCreature(actor.Creature);
            bool OutOfTime(){_exit.ThrowIfCancellationRequested();return clock.Elapsed.TotalMilliseconds>=18+6*_tier;}
            bool summon=_legend&&actor.Character.Id.Entry=="NECROBINDER";
            int LivingPet(CombatPredictionSimulator sim)=>summon&&sim.State.GetOsty(actor) is {} pet?sim.State.GetCreature(pet).CurrentHp:0;
            decimal EndHealth(CombatPredictionSimulator sim,out Ledger mark,out int petAfterHits){
                mark=Damage.GetOrCreateValue(sim);
                bool orbs=sim.State.GetPlayerCombatState(actor).OrbQueue.Orbs.Count!=0;
                var end=orbs||amounts.Length!=0?sim.Fork():sim;
                if(orbs){
                    var projected=Damage.GetOrCreateValue(end);projected.Copy(mark);
                    if(OrbLifecycleSupport.TriggerBeforeTurnEnd(end,(SimulatedCombatState)end.State.CombatState,actor))mark=projected;
                    else end=sim.Fork();
                    // 来袭意图在这个副本上真实扣血，不能再次记为下一轮的攻击。
                    Damage.Remove(end);
                }
                if(amounts.Length==0){petAfterHits=LivingPet(end);var hp=end.State.GetCreature(actor.Creature).CurrentHp;return ((SimulatedCombatState)end.State.CombatState).GetAmount<DoomPower>(actor.Creature)>=hp?0:hp;}
                var defending=end.State.GetCreature(actor.Creature);int added=0;
                for(int k=0;k<amounts.Length&&end.State.GetCreature(actor.Creature).IsAlive;k++)
                    if(properties[k]==-1){added+=(int)(amounts[k]-defending.DamageBlock(amounts[k],ValueProp.Move));}else{
                        var state=(SimulatedCombatState)end.State.CombatState;var props=(ValueProp)properties[k];decimal amount=amounts[k];
                        if(attackers[k] is {} attacker && props.IsPoweredAttack() && state.GetAmount<VulnerablePower>(attacker)>0 && state.GetPower<ColossusPower>(actor.Creature) is {} defense)
                            amount*=defense.DynamicVars["DamageDecrease"].BaseValue;
                        var attackerForHit=attackers[k]??targets[0];
                        _incoming=(attackerForHit,actor.Creature);
                        try{end.Damage([actor.Creature],amount,props,attackerForHit,null,null,capped[k]?ModifyDamageHookType.Cap:ModifyDamageHookType.None);}
                        finally{_incoming=default;}
                    }
                petAfterHits=LivingPet(end);
                return !defending.IsAlive||((SimulatedCombatState)end.State.CombatState).GetAmount<DoomPower>(actor.Creature)>=defending.CurrentHp?0:Math.Max(.1m,defending.CurrentHp-added*.85m);
            }
            var initial=(SimulatedCombatState)root.State.CombatState;
            bool fool=actor.Character.Id.Entry=="FOOL";
            int HandValue(IReadOnlyList<PredictedCard> cards,SimulatedCombatState state){
                if(!fool)return cards.Count;
                int sadness=0;foreach(var c in cards)if(c.Preview.Id.Entry=="SADNESS")sadness++;
                // 每层狂喜可在下个回合转化一张悲伤；其余悲伤会继续占用手牌位置。
                return cards.Count-sadness-Math.Max(0,sadness-state.GetAmount<EcstasyPower>(actor.Creature));
            }
            var baseLife=EndHealth(root,out var pass,out int basePet);
            var rootPlayer=root.State.GetPlayerCombatState(actor);
            var cards=rootPlayer.Hand.Cards.Concat(rootPlayer.DrawPile.Cards).Concat(rootPlayer.DiscardPile.Cards).ToArray();
            var future=StrategicEffectContext.Build(cards,targets.Sum(t=>root.State.GetCreature(t).CurrentHp),
                (int)amounts.Where((_,i)=>properties[i]!=-1).Sum(),properties.Count(p=>p!=-1),
                (StrategicEffectRequirements)(-1),initial.GetAmount<CorruptionPower>(actor.Creature)>0);
            decimal petWeight=summon&&future.RemainingTurns>1?.5m+Math.Min(4,cards.Count(c=>c.Preview.Tags.Contains(CardTag.OstyAttack)))*.125m:0;
            decimal reserve=Math.Max(me.MaxHp/3m,amounts.Sum());
            bool forge=_legend&&actor.Character.Id.Entry=="REGENT";
            bool bladePlan=forge&&cards.Any(c=>c.Preview is MegaCrit.Sts2.Core.Models.Cards.SummonForth or MegaCrit.Sts2.Core.Models.Cards.Conqueror or MegaCrit.Sts2.Core.Models.Cards.SwordSage);
            // 按牌组里实际还会抽到的耗星牌估计需求。黑洞按产星或耗星的次数触发，星之子按花掉的星数触发。
            decimal opportunities=Math.Min(Math.Max(0,future.RemainingTurns-1)*3,future.ReachableCards);
            decimal Reach(int n)=>opportunities*n/Math.Max(1,cards.Length);
            decimal spendEvents=forge?Reach(cards.Count(c=>c.Preview.CanonicalStarCost>0||c.Preview.HasStarCostX)):0;
            decimal starDemand=forge?Reach(cards.Sum(c=>c.Preview.HasStarCostX?4:Math.Max(0,c.Preview.CanonicalStarCost))):0;
            decimal printedGain=forge?Reach(cards.Count(c=>c.Preview.DynamicVars.ContainsKey("Stars"))):0;
            // 每回合每种旋律最多触发一次。按剩余牌组中该旋律的张数，估算三张可出牌中出现该旋律的机会。
            decimal MelodyChance(CardTag tag){
                int count=cards.Count(c=>c.Preview.Tags.Contains(tag));decimal miss=1;
                for(int i=0;i<Math.Min(3,cards.Length);i++)miss*=Math.Max(0,cards.Length-count-i)/(decimal)(cards.Length-i);
                return 1-miss;
            }
            decimal melodies=_legend&&fool?(MelodyChance(CardTag.Wah)+MelodyChance(CardTag.Cho)+MelodyChance(CardTag.Ki))*Math.Max(0,future.RemainingTurns-1):0;
            var upgradeValues=new Dictionary<(CardModel,int),decimal>();
            decimal access=Math.Min(1m,Math.Max(0,future.RemainingTurns-1)*5m/Math.Max(1,cards.Length));
            // 牌堆中真实发生的升级仍能在以后的抽牌中生效；已消耗的牌不再计入。
            decimal KeptCards(SimPlayerCombatState ps){
                if(!_legend||access<=0)return 0;
                decimal bladeValue=0,upgrades=0;
                void Visit(IReadOnlyList<PredictedCard> pile){
                    for(int i=0;i<pile.Count;i++){var card=pile[i];var liveCard=card.Original;var next=card.Preview;
                        if(bladePlan&&next is MegaCrit.Sts2.Core.Models.Cards.SovereignBlade blade&&!blade.IsDupe)
                            bladeValue=Math.Max(bladeValue,blade.DynamicVars.Damage.BaseValue*blade.DynamicVars.HitCount.IntValue);
                        if(ReferenceEquals(liveCard,next)||next.CurrentUpgradeLevel<=liveCard.CurrentUpgradeLevel)continue;
                        var key=(liveCard,next.CurrentUpgradeLevel);
                        if(!upgradeValues.TryGetValue(key,out var gain)){
                            // 仅比较升级本身，避免把同一条路线里额外铸造的剑伤算成升级收益。
                            var upgraded=new PredictedCard(liveCard);
                            for(int j=liveCard.CurrentUpgradeLevel;j<next.CurrentUpgradeLevel;j++)upgraded.Upgrade();
                            var after=upgraded.Preview;
                            gain=(decimal)(CardChoiceSupport.CardValue(after)-CardChoiceSupport.CardValue(liveCard))
                                +4*(liveCard.EnergyCost.GetWithModifiers(CostModifiers.None)-after.EnergyCost.GetWithModifiers(CostModifiers.None));
                            upgradeValues[key]=gain;
                        }
                        upgrades+=gain;
                    }
                }
                Visit(ps.Hand.Cards);Visit(ps.DrawPile.Cards);Visit(ps.DiscardPile.Cards);
                return Math.Min(bladeValue,future.EnemyHp)*.65m+access*upgrades;
            }
            decimal Setup(CombatPredictionSimulator sim){
                if(_tier==0)return 0;
                var combat=(SimulatedCombatState)sim.State.CombatState;
                var ps=sim.State.GetPlayerCombatState(actor);var powers=combat.EffectivePowers();
                decimal value=0;
                foreach(var power in powers){
                    if(!StrategicEffectMirrors.Contributes(power,actor.Creature))continue;
                    var ctx=power is DarkEmbracePower?future.WithExhaustDrawTiming(powers,ps.Hand.Cards,actor.Creature):future;
                    decimal v=StrategicEffectModel.Evaluate(power,ctx).RetentionValue;
                    // 空球栏保留集中以后启动的价值。已经成型的能力继续叠层时，边际收益渐减。
                    if(power is FocusPower&&!ps.OrbQueue.Orbs.Any(o=>o is not MegaCrit.Sts2.Core.Models.Orbs.PlasmaOrb))v*=.35m;
                    value+=16*v/(12+v);
                    // 上游已估算剩余回合、可触发次数和敌方生命。只有后续回合确有收益才增加启动价值。
                    if(_legend&&future.RemainingTurns>1&&v>12)value+=24*(v-12)/(36+v);
                }
                if(forge&&starDemand>0){
                    int throne=combat.GetAmount<TheSealedThronePower>(actor.Creature),genesis=combat.GetAmount<GenesisPower>(actor.Creature);
                    decimal events=(throne>0?opportunities:0)+(genesis>0?Math.Max(0,future.RemainingTurns-1):0);
                    decimal supply=opportunities*throne+Math.Max(0,future.RemainingTurns-1)*genesis;
                    // 有相应的耗星牌才能兑现资源。黑洞每个产星事件只触发一次，囤积星数不能重复计为伤害。
                    decimal usable=Math.Min(starDemand,Math.Max(0,supply+printedGain+ps.Stars));
                    value+=Math.Min(starDemand,supply)*1.5m
                        +Math.Min(future.EnemyHp,combat.GetAmount<BlackHolePower>(actor.Creature)*(events+printedGain+Math.Min(usable,spendEvents)))*.65m
                        +Math.Min(future.IncomingDamage,combat.GetAmount<ChildOfTheStarsPower>(actor.Creature)*usable)*.6m;
                }
                if(melodies>0){
                    // 失落鲁特琴直接打出牌顶，曲中意只抽牌，不能把两种回报按同一价值计算。
                    value+=Math.Min(future.EnemyHp,melodies*(combat.GetAmount<LostLutePower>(actor.Creature)*Math.Clamp(future.AverageCardValue,3,9)
                        +combat.GetAmount<MotifPower>(actor.Creature)*2))*.8m;
                }
                return value+KeptCards(ps)+.5m*CombatBeamSolver.OrbRetentionValue(sim,ps.OrbQueue.Orbs,targets.Length);
            }
            decimal baseSetup=Setup(root);
            decimal passPressure=targets.Sum(t=>Math.Min(root.State.GetCreature(t).CurrentHp+root.State.GetCreature(t).Block,pass.Hits.GetValueOrDefault(t)));
            int hand=HandValue(root.State.GetPlayerCombatState(actor).Hand.Cards,initial);
            
            var front=new List<Branch>{new(root,[],0)};var chosen=front[0];var visited=new Dictionary<StateFingerprint,decimal>();
            // 能量和手牌在推演途中可以支持后续动作；回合结束后的普通手牌与未用能量不能当作已获得的收益。
            decimal bestEnd=0;
            for(int depth=0;depth<24&&front.Count>0;depth++){
                var layer=new List<Branch>();
                foreach(var parent in front){
                    var ps=parent.Sim.State.GetPlayerCombatState(actor);
                    // 优先推演已经能发挥作用的牌；获得星星或消耗能量后，下一层按新次数重新排序。
                    var beforePlay=(SimulatedCombatState)parent.Sim.State.CombatState;
                    int Order(int i){
                        var c=ps.Hand.Cards[i].Preview;
                        // 先展开免费补充手牌或能量的分支，给同回合的准备牌和终结牌留出推演时间。
                        if(_legend&&c.EnergyCost.GetAmountToSpend()==0&&(c.DynamicVars.ContainsKey("Energy")||c.DynamicVars.ContainsKey("Cards")))return -2;
                        if(forge&&c is MegaCrit.Sts2.Core.Models.Cards.Conqueror&&ps.Hand.Cards.Any(p=>p.Preview is MegaCrit.Sts2.Core.Models.Cards.SovereignBlade))return -1;
                        if(c switch{
                        MegaCrit.Sts2.Core.Models.Cards.Radiate=>beforePlay.GetStarsGainedThisTurn(actor)==0,
                        MegaCrit.Sts2.Core.Models.Cards.HelixDrill=>beforePlay.GetEnergySpentThisTurn(actor)==0,
                        MegaCrit.Sts2.Core.Models.Cards.LunarBlast=>beforePlay.GetSkillCardsPlayedThisTurn(actor.Creature)==0,
                        _=>false})return 2;
                        return c.Type==CardType.Power||_setup.Contains(c.Id.Entry)||CardEffectSpecRegistry.Contains(c)||
                            c.DynamicVars.ContainsKey("Cards")||c.DynamicVars.ContainsKey("Energy")||c.DynamicVars.ContainsKey("WeakPower")||
                            c.DynamicVars.ContainsKey("VulnerablePower")||c.DynamicVars.ContainsKey("StrengthPower")?0:1;
                    }
                    foreach(int i in Enumerable.Range(0,ps.Hand.Cards.Count).OrderBy(Order)){
                        var move=ps.Hand.Cards[i];if(_unmodelledPlays.Contains(move.Preview.GetType())){incomplete=true;continue;}
                        try{if(!parent.Sim.CanPlay(move))continue;}catch(NotSupportedException){incomplete=true;continue;}
                        foreach(var aim in move.Preview.TargetType==TargetType.AnyEnemy?aimOrder.Where(t=>parent.Sim.State.GetCreature(t).IsAlive).Cast<Creature?>():new Creature?[]{move.Preview.TargetType is TargetType.AnyAlly or TargetType.Self?actor.Creature:null}){
                        if(attempted&&OutOfTime()){incomplete=true;return chosen;}
                        attempted=true;
                        // 直接出牌与每一种中途选择使用同一套攻防评分，复用上游的候选与动作回放。
                        foreach(var result in PlayOptions(parent.Sim,i,aim,actor,3+2*_tier,OutOfTime,()=>incomplete=true)){
                        var (sim,choices)=result;
                        var handState=sim.State.GetPlayerCombatState(actor);var card=move;
                        expanded++;
                        var combat=(SimulatedCombatState)sim.State.CombatState;
                        var own=sim.State.GetCreature(actor.Creature);
                        var life=EndHealth(sim,out var mark,out int petAfterHits);
                        // 已替主人承伤的生命不能重复计分。保留下来的奥斯提还能承伤，并能为后续出击提供伤害。
                        decimal setup=Setup(sim)-baseSetup+(petAfterHits-basePet)*petWeight;
                        decimal pressure=0;bool lethal=true;
                        foreach(var target in targets){
                            var foe=root.State.GetCreature(target);var enemy=sim.State.GetCreature(target);int hp=foe.CurrentHp;
                            decimal attack=mark.Hits.GetValueOrDefault(target),hit=attack+hp-enemy.CurrentHp;
                            int stacked=combat.GetAmount<DoomPower>(target)+mark.Stacks.GetValueOrDefault(target);
                            pressure+=(combat.GetAmount<PoisonPower>(target)-initial.GetAmount<PoisonPower>(target))*1.5m+(stacked-initial.GetAmount<DoomPower>(target))*.85m+Math.Min(hp+foe.Block,hit);
                            int activeDoom=combat.GetAmount<DoomPower>(target);
                            decimal through=Math.Max(0,attack-foe.Block);
                            if(activeDoom>0&&activeDoom>=enemy.CurrentHp-through&&life>0)pressure+=hp;
                            lethal&=through>=enemy.CurrentHp;
                        }
                        // 生命宽裕时，只有确实换到持续收益，才可接受一部分本能挡下的失血。
                        decimal investment=_legend&&setup>0&&life>reserve?Math.Max(0,Math.Min(setup,Math.Min(life-reserve,me.CurrentHp-life)))*.6m:0;
                        decimal end=pressure-passPressure+setup+investment+(life-baseLife)*1.6m+(life>0&&baseLife<=0?10000:life<=0&&baseLife>0?-10000:0)
                            +(handState.Stars-liveStars)*.5m;
                        // 真实新增的有利状态可打破停手平局；不把玩家身上的虚弱倒算成已经登记的攻击减伤。
                        bool ImprovesStatus()=>combat.EffectivePowers().Any(p=>p.Amount>0&&
                            (p.Owner==actor.Creature?p.TypeForCurrentAmount==MegaCrit.Sts2.Core.Entities.Powers.PowerType.Buff:
                            p.Owner.Side!=actor.Creature.Side&&p.TypeForCurrentAmount==MegaCrit.Sts2.Core.Entities.Powers.PowerType.Debuff)
                            && !initial.EffectivePowers().Any(q=>q.Owner==p.Owner&&q.Id==p.Id&&q.Amount>=p.Amount));
                        decimal score=end+(HandValue(handState.Hand.Cards,combat)-hand)*.8m+(handState.Energy-liveEnergy)*1.25m;
                        var route=new List<Play>(parent.Route){new(_originals.GetValueOrDefault(card.Original),card.Preview.Id.Entry,move.Preview.CurrentUpgradeLevel,aim==null?-1:_aims.GetValueOrDefault(aim,-1),choices)};var b=new Branch(sim,route,score);
                        if(end>bestEnd||end==bestEnd&&(chosen.Route.Count==0?ImprovesStatus():score>chosen.Score)){chosen=b;bestEnd=end;}
                        if(lethal&&life>0)return b;
                        var fingerprint=new StateFingerprintBuilder();
                        fingerprint.Add(handState.Energy);fingerprint.Add(handState.Stars);fingerprint.Add(own.Block);fingerprint.Add(own.CurrentHp);
                        if(summon){fingerprint.Add(LivingPet(sim));fingerprint.Add(combat.GetOstyMaxHp(sim,actor));}
                        void Pile(IReadOnlyList<PredictedCard> cards){fingerprint.Add(cards.Count);foreach(var c in cards){var preview=c.Preview;fingerprint.Add(preview.Id.Entry);fingerprint.Add(preview.CurrentUpgradeLevel);
                            if(forge&&preview is MegaCrit.Sts2.Core.Models.Cards.SovereignBlade){fingerprint.Add(preview.DynamicVars.Damage.BaseValue);fingerprint.Add(preview.DynamicVars.HitCount.IntValue);}}}
                        Pile(handState.Hand.Cards);Pile(handState.DrawPile.Cards);Pile(handState.DiscardPile.Cards);Pile(handState.ExhaustPile.Cards);
                        fingerprint.Add(handState.OrbQueue.Capacity);
                        foreach(var orb in handState.OrbQueue.Orbs){fingerprint.Add(orb.Id.Entry);fingerprint.Add(OrbMirrors.GetPassiveValue(sim,orb));fingerprint.Add(OrbMirrors.GetEvokeValue(sim,orb));}
                        foreach(var power in combat.EffectivePowers()){fingerprint.Add(power.Owner.CombatId??uint.MaxValue);fingerprint.Add(power.Id.Entry);fingerprint.Add(power.Amount);}
                        foreach(var target in targets){fingerprint.Add(mark.Hits.GetValueOrDefault(target));fingerprint.Add(mark.Stacks.GetValueOrDefault(target));}
                        var key=fingerprint.Finish();
                        if(visited.TryGetValue(key,out var old)&&old>=score)continue;visited[key]=score;layer.Add(b);
                        }
                        }
                    }
                }
                front=layer.OrderByDescending(b=>b.Score).Take(3+_tier*2).ToList();
            }
            return chosen;
            }finally{if(report!=null){searchMs=Stopwatch.GetElapsedTime(started).TotalMilliseconds;searchBytes=GC.GetAllocatedBytesForCurrentThread()-allocated;}}
        });
        _exit.ThrowIfCancellationRequested();
        foreach(var id in best.Route)_route.Enqueue(id);
        EndTurn=best.Route.Count==0&&!incomplete&&expanded>0;
        if(report!=null)
            File.AppendAllText(Path.Combine(report,"solver-review.txt"),$"{_captured++} capture={capture:F1}ms total={watch.Elapsed.TotalMilliseconds:F1}ms search={searchMs:F1}ms captureBytes={captureBytes} searchBytes={searchBytes} expanded={expanded} orbs={string.Join(',',root.State.GetPlayerCombatState(actor).OrbQueue.Orbs.Select(o=>o.Id.Entry+"="+OrbMirrors.GetEvokeValue(root,o)))} route={string.Join(' ',_route.Select(s=>s.Id+(s.Level>0?"+":"")))}\n");
        return Take();
    }
    private int liveEnergy,liveStars;
    private readonly Dictionary<Creature,int> _aims=[];
    private (CombatPredictionSimulator,Creature[]) Capture(bool attacking){
        var actor=Player.CreateForNewRun(_live.Character,_live.UnlockState,1);_actor=actor;
        var run=RunState.CreateForNewRun([actor],_live.RunState.Acts.Select(a=>a.CanonicalInstance.ToMutable()).ToList(),[],GameMode.Standard,false,0,_live.RunState.Rng.StringSeed);
        ProjectRunRules(run);
        var board=new CombatState(runState:run,badgeModels:run.BadgeModels,runModels:run.RunModels);board.AddPlayer(actor);actor.ResetCombatState();
        foreach(var r in actor.Relics.ToArray())actor.RemoveRelicInternal(r,true);
        foreach(var r in _live.Relics)actor.AddRelicInternal(RelicModel.FromSerializable(r.ToSerializable()),-1,true);
        var realTargets=_live.Creature.CombatState!.GetOpponentsOf(_live.Creature).Where(c=>c.IsHittable).ToArray();
        var targets=realTargets.Select(other=>{
            MonsterModel enemy=attacking?ModelDb.Monster<MockAttackMonster>():ModelDb.Monster<MockPlatingMonster>();var target=board.CreateCreature(enemy.ToMutable(),CombatSide.Enemy,null);
            board.AddCreature(target);target.Monster!.SetUpForCombat();target.Monster.RollMove([actor.Creature]);_aims[target]=checked((int)other.CombatId!.Value);return target;
        }).ToArray();
        var old=_live.PlayerCombatState!;var ps=actor.PlayerCombatState!;
        var arrows=new Dictionary<ArrowSlot,ArrowSlot>();var slots=(List<ArrowSlot>)AccessTools.Field(typeof(PlayerCombatState),"_arrows").GetValue(ps)!;
        slots.Clear();foreach(var slot in old.Arrows){var next=new ArrowSlot(actor){Status=slot.Status,DestroyAfterImpaled=slot.DestroyAfterImpaled};slots.Add(next);arrows.Add(slot,next);}
        ps.OrbQueue.Clear();ps.OrbQueue.AddCapacity(old.OrbQueue.Capacity-ps.OrbQueue.Capacity);
        foreach(var orb in old.OrbQueue.Orbs){var clone=(OrbModel)orb.MutableClone();clone.Owner=null!;clone.Owner=actor;ps.OrbQueue.Insert(ps.OrbQueue.Orbs.Count,clone);}
        void Copy(Creature src,Creature dst){
            dst.SetMaxHpInternal(src.MaxHp);dst.SetCurrentHpInternal(src.CurrentHp);dst.GainBlockInternal(src.Block);
            foreach(var power in src.Powers){if(power is ImpaledPower foreign&&!foreign.Arrows.Any(arrows.ContainsKey))continue;
                var copy=(PowerModel)power.MutableClone();
                if(copy is ImpaledPower impaled && power is ImpaledPower original)foreach(var a in original.Arrows)if(arrows.TryGetValue(a,out var arrow))impaled.AddArrow(arrow);
                copy.Applier=power.Applier==_live.Creature?actor.Creature:Array.IndexOf(realTargets,power.Applier) is int i&&i>=0?targets[i]:null;copy.ApplyInternal(dst,power.Amount,true);}
        }
        Copy(_live.Creature,actor.Creature);for(int i=0;i<targets.Length;i++)Copy(realTargets[i],targets[i]);
        if(_live.Osty is {} realPet){
            var pet=board.CreateCreature(ModelDb.Monster<MegaCrit.Sts2.Core.Models.Monsters.Osty>().ToMutable(),CombatSide.Player,null);
            ps.AddPetInternal(pet);board.AddCreature(pet);Copy(realPet,pet);
        }
        liveEnergy=old.Energy;liveStars=old.Stars;
        ps.GainEnergy(old.Energy-ps.Energy);StarBalance(ps)=old.Stars;
        for(int i=1;i<old.TurnNumber;i++)ps.IncrementTurnNumber();
        foreach(var pile in old.AllPiles){
            var dest=ps.AllPiles.First(p=>p.Type==pile.Type);
            foreach(var original in pile.Cards){var card=(CardModel)original.MutableClone();card.Owner=null!;board.AddCard(card,actor);dest.AddInternal(card,-1,true);_originals.Add(card,original);}
        }
        var creatures=new Dictionary<Creature,Creature>{{_live.Creature,actor.Creature}};
        for(int i=0;i<targets.Length;i++)creatures.Add(realTargets[i],targets[i]);
        if(_live.Osty is {} sourcePet && actor.Osty is {} copyPet)creatures[sourcePet]=copyPet;
        board.RoundNumber=_live.Creature.CombatState!.RoundNumber;
        run.Rng.LoadFromSerializable(_live.RunState.Rng.ToSerializable());
        _mappedHistory=MapHistory(board,actor,creatures);
        try{using var projection=new CaptureProjection(run,board,_unmodelledPlays);var root=new CombatPredictionSimulator(new SimulatedCombatState(board));Damage.GetOrCreateValue(root);return(root,targets);}
        finally{_mappedHistory=null;}
    }
    public void Dispose(){_aims.Clear();_originals.Clear();_actor?.PlayerCombatState?.AfterCombatEnd();_actor=null;}
}
