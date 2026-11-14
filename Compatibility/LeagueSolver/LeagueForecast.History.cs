using CombatSolver;
using HarmonyLib;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Combat.History;
using MegaCrit.Sts2.Core.Combat.History.Entries;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;

namespace NationalSpire.Solver;

public sealed partial class LeagueForecast
{
    // 初始化推演角色的余额不是获得星星。原版的公共写入入口会向实战记录追加一次获星。
    private static readonly AccessTools.FieldRef<PlayerCombatState,int> StarBalance=AccessTools.FieldRefAccess<PlayerCombatState,int>("_stars");
    [ThreadStatic] private static RootCombatHistorySnapshot? _mappedHistory;
    private static bool UseMappedHistory(ref RootCombatHistorySnapshot __result){
        if(_mappedHistory==null)return true;
        __result=_mappedHistory;return false;
    }

    // 实战中的敌方选手在推演中位于玩家一侧。沿用上游记录格式，候选路线共用同一份只读记录。
    private RootCombatHistorySnapshot MapHistory(CombatState board,Player actor,Dictionary<Creature,Creature> creatures){
        var live=_live.Creature.CombatState!;var history=CombatManager.Instance.History;
        var originals=_originals.ToDictionary(p=>p.Value,p=>p.Key);
        var plays=new Dictionary<CardPlay,CardPlay>();
        Creature? Target(Creature? c)=>c==null?null:creatures.GetValueOrDefault(c,c);
        CardModel Card(CardModel c){
            if(c.Owner!=_live)return c;
            if(originals.TryGetValue(c,out var copy))return copy;
            copy=(CardModel)c.MutableClone();copy.Owner=null!;copy.Owner=actor;return originals[c]=copy;
        }
        CardPlay Play(CardPlay p){
            if(plays.TryGetValue(p,out var copy))return copy;
            return plays[p]=new(){Card=Card(p.Card),Player=p.Player==_live?actor:p.Player,Target=Target(p.Target),
                Resources=p.Resources,IsAutoPlay=p.IsAutoPlay,ResultPile=p.ResultPile,PlayCount=p.PlayCount,PlayIndex=p.PlayIndex};
        }
        DamageResult Result(DamageResult d)=>new(Target(d.Receiver)!,d.Props){OriginalTarget=Target(d.OriginalTarget)!,
            BlockedDamage=d.BlockedDamage,UnblockedDamage=d.UnblockedDamage,OverkillDamage=d.OverkillDamage,IntendedHpLoss=d.IntendedHpLoss,
            WasTargetKilled=d.WasTargetKilled,WasFullyBlocked=d.WasFullyBlocked,WasBlockBroken=d.WasBlockBroken};
        var started=new List<CardPlayStartedEntry>();var finished=new List<CardPlayFinishedEntry>();var damage=new List<DamageReceivedEntry>();
        var powers=new List<PowerReceivedEntry>();var discard=new List<CardDiscardedEntry>();var attacks=new List<CreatureAttackedEntry>();
        var energy=new List<EnergySpentEntry>();var stars=new List<StarsModifiedEntry>();var draws=new List<CardDrawnEntry>();
        var exhaust=new List<CardExhaustedEntry>();var blocks=new List<BlockGainedEntry>();var generated=new List<CardGeneratedEntry>();var orbs=new List<OrbChanneledEntry>();
        foreach(var e in history.Entries){
            // 上游单回合搜索分别读取整场累计和本回合记录。历史记录保留在数组中，只有当回合记录取得当前回合号。
            int turn=e.HappenedThisTurn(live)?board.RoundNumber:0;
            var side=CombatSide.Player;var roster=board.Players;
            switch(e){
                case CardPlayStartedEntry a: started.Add(new(Play(a.CardPlay),turn,side,history,roster));break;
                case CardPlayFinishedEntry a:
                    var end=new CardPlayFinishedEntry(Play(a.CardPlay),turn,side,history,roster);
                    if(end.WasEthereal!=a.WasEthereal)Ethereal(end)=a.WasEthereal;
                    finished.Add(end);break;
                case DamageReceivedEntry a:damage.Add(new(Result(a.Result),Target(a.Receiver)!,Target(a.Dealer),a.CardSource==null?null:Card(a.CardSource),turn,side,history,roster));break;
                case PowerReceivedEntry a:powers.Add(new(a.Power,a.Amount,Target(a.Applier),turn,side,history,roster));break;
                case CardDiscardedEntry a:discard.Add(new(Card(a.Card),turn,side,history,roster));break;
                case CreatureAttackedEntry a:attacks.Add(new(Target(a.Actor)!,a.DamageResults.Select(Result).ToArray(),turn,side,history,roster));break;
                case EnergySpentEntry a when a.Actor==_live.Creature:energy.Add(new(a.Amount,actor,turn,side,history,roster));break;
                case StarsModifiedEntry a when a.Actor==_live.Creature:stars.Add(new(a.Amount,actor,turn,side,history,roster));break;
                case CardDrawnEntry a:draws.Add(new(Card(a.Card),turn,side,a.FromHandDraw,history,roster));break;
                case CardExhaustedEntry a:exhaust.Add(new(Card(a.Card),turn,side,history,roster));break;
                case BlockGainedEntry a:blocks.Add(new(a.Amount,a.Props,a.CardPlay==null?null:Play(a.CardPlay),Target(a.Receiver)!,turn,side,history,roster));break;
                case CardGeneratedEntry a:generated.Add(new(Card(a.Card),a.Creator==_live?actor:a.Creator,turn,side,history,roster));break;
                case OrbChanneledEntry a when a.Actor==_live.Creature:
                    var orb=(OrbModel)a.Orb.MutableClone();orb.Owner=null!;orb.Owner=actor;orbs.Add(new(orb,turn,side,history,roster));break;
            }
        }
        return new([..started],[..finished],[..damage],[..powers],[..discard],[..attacks],[..energy],[..stars],[..draws],[..exhaust],[..blocks],[..generated],[..orbs]);
    }
    private static readonly AccessTools.FieldRef<CardPlayFinishedEntry,bool> Ethereal=AccessTools.FieldRefAccess<CardPlayFinishedEntry,bool>("<WasEthereal>k__BackingField");
}
