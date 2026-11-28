using CombatSolver;
using CombatSolver.HotKernel;
using CombatSolver.HotSearch;
using HarmonyLib;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.FoolArrows;
using MegaCrit.Sts2.Core.Models.Powers;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Monsters.Mocks;
using MegaCrit.Sts2.Core.Runs;
using System.Runtime.CompilerServices;

namespace NationalSpire.Solver;
public sealed partial class LeagueForecast(Player rival,int tier,string[] setup,Func<int,int> added,int preference,CancellationToken exit) : IDisposable {
    private readonly Player _live=rival;
    private Player? _actor;
    private readonly Dictionary<CardModel,CardModel> _originals=new(ReferenceEqualityComparer.Instance);
    private static readonly AccessTools.FieldRef<PlayerCombatState,int> StarBalance=AccessTools.FieldRefAccess<PlayerCombatState,int>("_stars");
    public static void Prepare(){
        InstallDuelHooks();
        SolverWarmup.StartBackgroundWarmup();
        // 后台预加载提前编译常用入口，第一回合的时间预算用于比较牌序。
        foreach(var type in new[]{typeof(HotCombatEngine),typeof(HotEvaluator)})
            foreach(var method in AccessTools.GetDeclaredMethods(type))
                if(method.Name is nameof(HotCombatEngine.Step) or nameof(HotCombatEngine.EnumerateLegalActions)
                    or nameof(HotEvaluator.EvaluateState) or nameof(HotEvaluator.ExtractStage1))
                    RuntimeHelpers.PrepareMethod(method.MethodHandle);
    }
    private readonly Dictionary<Creature,int> _aims=[];
    private CombatRootSnapshot Capture(bool attacking){
        var actor=Player.CreateForNewRun(_live.Character,_live.UnlockState,MegaCrit.Sts2.Core.Context.LocalContext.NetId ?? 1);_actor=actor;
        var run=RunState.CreateForNewRun([actor],_live.RunState.Acts.Select(a=>a.CanonicalInstance.ToMutable()).ToList(),[],GameMode.Standard,false,0,_live.RunState.Rng.StringSeed);

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
        slots.Clear();
        foreach(var slot in old.Arrows){
            var next=new ArrowSlot(actor){Status=slot.Status};
            slots.Add(next);arrows.Add(slot,next);
        }
        ps.OrbQueue.Clear();ps.OrbQueue.AddCapacity(old.OrbQueue.Capacity-ps.OrbQueue.Capacity);
        foreach(var orb in old.OrbQueue.Orbs){var clone=(OrbModel)orb.MutableClone();clone.Owner=null!;clone.Owner=actor;ps.OrbQueue.Insert(ps.OrbQueue.Orbs.Count,clone);}
        void Copy(Creature src,Creature dst){
            dst.SetMaxHpInternal(src.MaxHp);dst.SetCurrentHpInternal(src.CurrentHp);dst.GainBlockInternal(src.Block);
            foreach(var power in src.Powers){if(src!=_live.Creature && power.GetType().Assembly!=typeof(PowerModel).Assembly)continue; if(power is ImpaledPower foreign&&!foreign.Arrows.Any(arrows.ContainsKey))continue;
                var copy=(PowerModel)power.MutableClone();
                if(copy is ImpaledPower impaled && power is ImpaledPower original)foreach(var a in original.Arrows)if(arrows.TryGetValue(a,out var arrow))impaled.AddArrow(arrow);
                copy.Applier=power.Applier==_live.Creature?actor.Creature:Array.IndexOf(realTargets,power.Applier) is int i&&i>=0?targets[i]:null;copy.ApplyInternal(dst,power.Amount,true);}
        }
        Copy(_live.Creature,actor.Creature);for(int i=0;i<targets.Length;i++)Copy(realTargets[i],targets[i]);
        if(_live.Osty is {} realPet){
            var pet=board.CreateCreature(ModelDb.Monster<MegaCrit.Sts2.Core.Models.Monsters.Osty>().ToMutable(),CombatSide.Player,null);
            ps.AddPetInternal(pet);board.AddCreature(pet);Copy(realPet,pet);
        }
        ps.GainEnergy(old.Energy-ps.Energy);StarBalance(ps)=old.Stars;
        for(int i=1;i<old.TurnNumber;i++)ps.IncrementTurnNumber();
        foreach(var pile in old.AllPiles){
            var dest=ps.AllPiles.First(p=>p.Type==pile.Type);
            foreach(var original in pile.Cards){var card=(CardModel)original.MutableClone();card.Owner=null!;board.AddCard(card,actor);dest.AddInternal(card,-1,true);_originals.Add(card,original);}
        }

        board.RoundNumber=_live.Creature.CombatState!.RoundNumber;run.Rng.LoadFromSerializable(_live.RunState.Rng.ToSerializable());_historyPlayer=_live;try{return CombatRootSnapshot.Capture(board,potionThresholds:PotionHpThresholds.Default);}finally{_historyPlayer=null;}
    }
    private Dictionary<ushort,CardModel> OriginalCards(in CombatHotState state){
        var result=new Dictionary<ushort,CardModel>();int index=0;
        var ps=_actor!.PlayerCombatState!;
        foreach(var pile in new[]{ps.Hand,ps.DrawPile,ps.DiscardPile,ps.ExhaustPile,ps.PlayPile})
            foreach(var card in pile.Cards)result.Add(state.Cards[index++].CardUid,_originals[card]);
        return result;
    }
    public void Dispose(){_aims.Clear();_originals.Clear();_actor?.PlayerCombatState?.AfterCombatEnd();_actor=null;}
}
