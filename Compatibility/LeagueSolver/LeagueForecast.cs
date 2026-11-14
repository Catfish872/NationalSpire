using CombatSolver;
using CombatSolver.Engine.Common;
using CombatSolver.Engine.InCombat.Mirrors;
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
public sealed class LeagueForecast : IDisposable
{
    private readonly Player _live;private readonly int _tier;
    private static bool _installed;
    private sealed class Ledger {
        internal readonly Dictionary<Creature,decimal> Hits=[];internal readonly Dictionary<Creature,int> Stacks=[];
        internal void Copy(Ledger src){foreach(var p in src.Hits)Hits[p.Key]=p.Value;foreach(var p in src.Stacks)Stacks[p.Key]=p.Value;}
    }
    private static readonly ConditionalWeakTable<CombatPredictionSimulator,Ledger> Damage=new();
    private readonly record struct Play(CardModel? Live,string Id,int Level,int Aim);
    public (CardModel,int)[] Continuation(){var result=_route.TakeWhile(x=>x.Live!=null).Select(x=>(x.Live!,x.Aim)).ToArray();_route.Clear();return result;}
    public int LastAim {get;private set;}=-1;
    private sealed record Branch(CombatPredictionSimulator Sim,List<Play> Route,decimal Score,decimal Setup=0);
    private readonly Queue<Play> _route=[];
    private readonly Dictionary<CardModel,CardModel> _originals=new(ReferenceEqualityComparer.Instance);
    private Player? _actor;
    private int _captured;
    private readonly HashSet<string> _setup;
    private static Func<int,int> _addedDoom=null!;
    private readonly int _preferredTarget;
    public LeagueForecast(Player rival,int tier,string[] setup,Func<int,int> addedDoom,int preference){
        _preferredTarget=preference;
        _addedDoom=addedDoom;
        _setup=new(setup);
        _live=rival;_tier=Math.Min(tier,2);
        Prepare();
    }
    public static void Prepare(){
        if(_installed)return;
        var harmony=new Harmony("nationalspire.league.forecast");
        harmony.Patch(AccessTools.Method(typeof(PredictionModPatchAudit),"TryDescribeForeignPatch"),prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(MirroredIntent)));
        // 独立加载的上游组件使用调试输出，不启动其普通模组的日志写入和回合订阅。
        harmony.Patch(AccessTools.Method(typeof(CombatSolverLog),"Write"),prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(DebugOutput)));
        AccessTools.PropertySetter(typeof(Entry),"Logger").Invoke(null,[RuntimeHelpers.GetUninitializedObject(typeof(CombatSolverLog))]);
        CombatSolver.Engine.InCombat.Mirrors.Cards.OnPlay.CardOnPlayMirrors.AllowInference=true;
        var method=AccessTools.Method(typeof(CombatPredictionSimulator),"Damage",[typeof(IReadOnlyList<Creature>),typeof(decimal),typeof(ValueProp),typeof(Creature),typeof(PredictedCard),typeof(CardPlay),typeof(ModifyDamageHookType)]);
        harmony.Patch(method,prefix:new HarmonyMethod(typeof(LeagueForecast),nameof(Intent)));
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
    private static void SimDoom(PowerModel power,Creature target,Creature? applier,ref int __result){
        if(power is not DoomPower||__result<=0)return;
        if(target.Side==applier?.Side){__result=_addedDoom(__result);return;}
        if(_move!=null){_move.Stacks[target]=_move.Stacks.GetValueOrDefault(target)+__result;__result=0;}
    }
    // 仅联赛自己的眼部攻击读取方式已在下方的目标意图中建模。其他补丁仍交给上游逐项核对。
    private static bool MirroredIntent(Patch patch,System.Reflection.MethodBase target){
        if(patch.owner!="nationalspire.league.native"||patch.PatchMethod.DeclaringType?.FullName!="NationalSpire.LeagueNativeMatch")return true;
        if(patch.PatchMethod.Name=="IntentReader")return target.DeclaringType?.DeclaringType!=typeof(MegaCrit.Sts2.Core.Models.Cards.GoForTheEyes);
        // 推演里的 AI 本来就在玩家一侧，原有敌方名单正是联赛持有者的对面。
        return patch.PatchMethod.Name!="ResolveEffectSides";
    }
    private static bool Intent(CombatPredictionSimulator __instance,IReadOnlyList<Creature> targets,decimal amount,ValueProp props,Creature? dealer,
        PredictedCard? cardSource,CardPlay? cardPlay,ModifyDamageHookType modifyDamageHookType,ref IReadOnlyList<DamageResult> __result){
        if(!Damage.TryGetValue(__instance,out var log)||modifyDamageHookType==ModifyDamageHookType.None)return true;
        var kind=__instance.ResolveDamageSource(cardSource).Kind;
        if(kind==CombatDamageSourceKind.Poison&&targets.Count>0){props&=~ValueProp.Unblockable;dealer=__instance.State.CombatState.GetOpponentsOf(targets[0]).FirstOrDefault(c=>c.IsAlive);}
        if(dealer==null||targets.Any(t=>t.Side==dealer.Side))return true;
        foreach(var t in targets)log.Hits[t]=log.Hits.GetValueOrDefault(t)+Math.Max(0,HookMirrors.ModifyDamage(__instance,t,dealer,amount,props,cardSource,cardPlay,modifyDamageHookType));
        __result=targets.Select(t=>new DamageResult(t,props)).ToArray();return false;
    }
    public async Task<CardModel?> Choose(decimal[] amounts,int[] properties){
        var live=_live.PlayerCombatState!;var realHand=live.Hand.Cards;if(!realHand.Any(c=>c.CanPlay()))return null;
        CardModel? Take(){
            if(!_route.TryDequeue(out var next))return null;LastAim=next.Aim;
            return realHand.FirstOrDefault(c=>(next.Live==null?c.Id.Entry==next.Id:ReferenceEquals(c,next.Live))&&c.CurrentUpgradeLevel==next.Level&&c.CanPlay());
        }
        if(Take() is {} next)return next;_route.Clear();Dispose();
        string? report=Environment.GetEnvironmentVariable("LEAGUE_PREVIEW_ROOT");long before=report==null?0:GC.GetAllocatedBytesForCurrentThread();
        var watch=Stopwatch.StartNew();var (root,targets)=Capture(amounts.Any(v=>v>0));double capture=watch.Elapsed.TotalMilliseconds;
        long captureBytes=report==null?0:GC.GetAllocatedBytesForCurrentThread()-before,searchBytes=0;double searchMs=0;
        var aimOrder=_preferredTarget<0?targets:targets.OrderByDescending(t=>_aims[t]==_preferredTarget).ToArray();
        var actor=_actor!;int expanded=0;var best=await Task.Run(()=>{
            long allocated=report==null?0:GC.GetAllocatedBytesForCurrentThread();long started=Stopwatch.GetTimestamp();
            try{
            var clock=Stopwatch.StartNew();var me=root.State.GetCreature(actor.Creature);
            decimal EndHealth(CombatPredictionSimulator sim){
                if(amounts.Length==0)return sim.State.GetCreature(actor.Creature).CurrentHp;
                var end=sim.Fork();var defending=end.State.GetCreature(actor.Creature);int held=((SimulatedCombatState)end.State.CombatState).GetAmount<DoomPower>(actor.Creature),added=0;
                for(int k=0;k<amounts.Length&&end.State.GetCreature(actor.Creature).IsAlive;k++)
                    if(properties[k]==-1){added+=(int)(amounts[k]-defending.DamageBlock(amounts[k],ValueProp.Move));}else end.Damage([actor.Creature],amounts[k],(ValueProp)properties[k],targets[0],null,null,ModifyDamageHookType.None);
                return !defending.IsAlive||held+added>=defending.CurrentHp?0:Math.Max(.1m,defending.CurrentHp-added*.85m);
            }
            var initial=(SimulatedCombatState)root.State.CombatState;
            bool fool=actor.Character.Id.Entry=="FOOL";
            int HandValue(IReadOnlyList<PredictedCard> cards,SimulatedCombatState state){
                if(!fool)return cards.Count;
                int sadness=0;foreach(var c in cards)if(c.Preview.Id.Entry=="SADNESS")sadness++;
                // 每层狂喜可在下个回合转化一张悲伤；其余悲伤会继续占用手牌位置。
                return cards.Count-sadness-Math.Max(0,sadness-state.GetAmount<EcstasyPower>(actor.Creature));
            }
            var baseLife=EndHealth(root);int hand=HandValue(root.State.GetPlayerCombatState(actor).Hand.Cards,initial);
            
            var front=new List<Branch>{new(root,[],0)};var chosen=front[0];var visited=new Dictionary<string,decimal>();
            for(int depth=0;depth<24&&front.Count>0;depth++){
                var layer=new List<Branch>();
                foreach(var parent in front){
                    var ps=parent.Sim.State.GetPlayerCombatState(actor);
                    for(int i=0;i<ps.Hand.Cards.Count;i++){
                        if(expanded>0&&clock.Elapsed.TotalMilliseconds>=18+6*_tier)return chosen;
                        var move=ps.Hand.Cards[i];if(!parent.Sim.CanPlay(move))continue;
                        foreach(var aim in move.Preview.TargetType==TargetType.AnyEnemy?aimOrder.Where(t=>parent.Sim.State.GetCreature(t).IsAlive).Cast<Creature?>():new Creature?[]{move.Preview.TargetType is TargetType.AnyAlly or TargetType.Self?actor.Creature:null}){
                        var sim=parent.Sim.Fork();var mark=Damage.GetOrCreateValue(sim);mark.Copy(Damage.GetOrCreateValue(parent.Sim));
                        var handState=sim.State.GetPlayerCombatState(actor);var card=handState.Hand.Cards[i];
                        
                        expanded++;
                        var combat=(SimulatedCombatState)sim.State.CombatState;
                        combat.BeginActionChoices((IReadOnlyList<PlanCardChoice>?)null);
                        _move=mark;try{if(!sim.ManualPlay(card,aim,out _)||sim.HasPendingChoice||sim.HasRisk&&PredictionCoverage.Collect(sim).Any(g=>!g.Compensated))continue;}
                        catch(PredictionUnsupportedException){continue;}
                        finally{_move=null;combat.EndActionChoices();}
                        var own=sim.State.GetCreature(actor.Creature);
                        var life=EndHealth(sim);
                        // 当回合可以安全建立的能力也有价值。计分只影响路线排序，不额外搜索未来回合。
                        decimal setup=parent.Setup;
                        if(_tier>0&&card.Preview.Type==CardType.Power){
                            bool core=_setup.Contains(card.Preview.Id.Entry);
                            setup+=core?5+3*_tier:2+_tier;
                        }
                        decimal pressure=0;bool lethal=true;
                        foreach(var target in targets){
                            var foe=root.State.GetCreature(target);var enemy=sim.State.GetCreature(target);int hp=foe.CurrentHp;
                            decimal attack=mark.Hits.GetValueOrDefault(target),hit=attack+hp-enemy.CurrentHp;
                            int stacked=combat.GetAmount<DoomPower>(target)+mark.Stacks.GetValueOrDefault(target);
                            pressure+=(combat.GetAmount<PoisonPower>(target)-initial.GetAmount<PoisonPower>(target))*1.5m+(stacked-initial.GetAmount<DoomPower>(target))*.85m+Math.Min(hp+foe.Block,hit);
                            if(stacked>0&&stacked>=enemy.CurrentHp-Math.Max(0,attack-foe.Block)&&life>0)pressure+=hp;
                            lethal&=hit>=hp+foe.Block;
                        }
                        decimal score=pressure+setup+(life-baseLife)*1.6m+(life>0&&baseLife<=0?10000:life<=0&&baseLife>0?-10000:0)
                            +(HandValue(handState.Hand.Cards,combat)-hand)*.8m
                            +(handState.Energy-liveEnergy)*1.25m+(handState.Stars-liveStars)*.5m
                            + (parent.Route.Count+1)*.03m;
                        var route=new List<Play>(parent.Route){new(_originals.GetValueOrDefault(card.Original),card.Preview.Id.Entry,move.Preview.CurrentUpgradeLevel,aim==null?-1:_aims.GetValueOrDefault(aim,-1))};var b=new Branch(sim,route,score,setup);
                        if(score>chosen.Score||chosen.Route.Count==0)chosen=b;
                        if(lethal&&life>0)return chosen;
                        string Codes(IEnumerable<PredictedCard> pile)=>string.Join(',',pile.Select(c=>c.Preview.IsUpgraded?c.Preview.Id.Entry+"+":c.Preview.Id.Entry));
                        string key=handState.Energy+"/"+handState.Stars+"/"+own.Block+"/"+Codes(handState.Hand.Cards)+"/"+Codes(handState.DrawPile.Cards)+"/"+Codes(handState.DiscardPile.Cards);
                        if(visited.TryGetValue(key,out var old)&&old>=score)continue;visited[key]=score;layer.Add(b);
                        }
                    }
                }
                front=layer.OrderByDescending(b=>b.Score).Take(3+_tier*2).ToList();
            }
            return chosen;
            }finally{if(report!=null){searchMs=Stopwatch.GetElapsedTime(started).TotalMilliseconds;searchBytes=GC.GetAllocatedBytesForCurrentThread()-allocated;}}
        });
        foreach(var id in best.Route)_route.Enqueue(id);
        if(report!=null)
            File.AppendAllText(Path.Combine(report,"solver-review.txt"),$"{_captured++} capture={capture:F1}ms total={watch.Elapsed.TotalMilliseconds:F1}ms search={searchMs:F1}ms captureBytes={captureBytes} searchBytes={searchBytes} expanded={expanded} route={string.Join(' ',_route.Select(s=>s.Id+(s.Level>0?"+":"")))}\n");
        return Take();
    }
    private int liveEnergy,liveStars;
    private readonly Dictionary<Creature,int> _aims=[];
    private (CombatPredictionSimulator,Creature[]) Capture(bool attacking){
        var actor=Player.CreateForNewRun(_live.Character,_live.UnlockState,1);_actor=actor;
        var run=RunState.CreateForNewRun([actor],_live.RunState.Acts.Select(a=>a.CanonicalInstance.ToMutable()).ToList(),[],GameMode.Standard,false,0,"league-forecast");
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
        ps.GainEnergy(old.Energy-ps.Energy);ps.GainStars(old.Stars-ps.Stars);
        for(int i=1;i<old.TurnNumber;i++)ps.IncrementTurnNumber();
        foreach(var pile in old.AllPiles){
            var dest=ps.AllPiles.First(p=>p.Type==pile.Type);
            foreach(var original in pile.Cards){var card=(CardModel)original.MutableClone();card.Owner=null!;board.AddCard(card,actor);dest.AddInternal(card,-1,true);_originals.Add(card,original);}
        }
        var root=new CombatPredictionSimulator(new SimulatedCombatState(board));Damage.GetOrCreateValue(root);return(root,targets);
    }
    public void Dispose(){_aims.Clear();_originals.Clear();_actor?.PlayerCombatState?.AfterCombatEnd();_actor=null;}
}
