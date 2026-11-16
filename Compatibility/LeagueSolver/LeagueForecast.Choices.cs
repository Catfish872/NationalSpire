using CombatSolver;
using CombatSolver.Engine.Common;
using CombatSolver.Engine.InCombat.Simulation;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace NationalSpire.Solver;

public sealed partial class LeagueForecast {
    // 搜索只需要牌的编号；显示名称不参与评分，也不需要读取场景或本地化资源。
    private static readonly SolverDisplayNames Names=new([],new("DINGY_DAGGER","DINGY_DAGGER","DINGY_DAGGER"),[],[],[],[],[],[],[],false,false);
    private static IEnumerable<(CombatPredictionSimulator,int[])> PlayOptions(CombatPredictionSimulator parent,int slot,Creature? target,Player actor,int width,Func<bool> expired,Action incomplete){
        Stack<(PlanCardChoice[] path,int[] wire)>? pending=null;
        (PlanCardChoice[] path,int[] wire) branch=([],[]);
        do{
            if(branch.path.Length>0&&expired()){incomplete();yield break;}
            var sim=parent.Fork();var mark=Damage.GetOrCreateValue(sim);mark.Copy(Damage.GetOrCreateValue(parent));
            var state=(SimulatedCombatState)sim.State.CombatState;
            var card=sim.State.GetPlayerCombatState(actor).Hand.Cards[slot];
            bool complete;
            try{
                state.BeginActionChoices(branch.path);
                _move=mark;
                try{complete=sim.ManualPlay(card,target,out _);}
                finally{_move=null;state.EndActionChoices();}
            }catch(Exception e) when(e is InvalidPlannedChoiceBranchException or NotSupportedException){incomplete();continue;}
            if(state.PendingTurnStartChoice is {} req){
                var spec=TurnStartChoiceSupport.BuildPendingSpec(sim,state,actor);
                var options=CardChoiceSupport.BuildChoices(spec,Names,width,width);
                for(int n=Math.Min(width,options.Count)-1;n>=0;n--){
                    var choice=options[n] with {SourceId=req.SourceId,ContextId=req.ContextId,Timing=req.Timing};
                    // 空候选不会打开实战选牌框。其余选择按真实调用顺序随牌序发送。
                    int[] wire=branch.wire;
                    if(spec.Options.Count!=0){
                        var selected=choice.Cards.SelectMany(t=>new[]{ModelIdSerializationCache.GetNetIdForEntry(t.CardId),t.UpgradeLevel,t.OptionOccurrence});
                        wire=[..wire,(int)spec.SourcePile,MenuKey(spec.Options.Select(c=>c.Preview)),(int)spec.Effect,choice.Cards.Count,..selected];
                    }
                    (pending??=new()).Push(([..branch.path,choice],wire));
                }
                if(options.Count==0)incomplete();
            }else if(complete&&!sim.HasPendingChoice&&(!sim.HasRisk||sim.History.OfType<CombatPredictionRiskEntry>().All(risk=>
                // 玩家代理身上的第三方能力仍保留层数。某个额外回调无法预测时，只略去该回调的收益。
                risk.Trace?.Source is PowerModel {IsMutable:true} power && power.GetType().Assembly!=typeof(PowerModel).Assembly
                    && power.Owner is {} owner && owner.Side!=actor.Creature.Side
                ||PredictionCoverage.DescribeGap(risk).Compensated)))yield return(sim,branch.wire);
            else incomplete();
        }while(pending!=null&&pending.TryPop(out branch));
    }

    public static int MenuKey(IEnumerable<CardModel> cards){
        unchecked{int hash=17;foreach(var c in cards){hash=hash*31+ModelIdSerializationCache.GetNetIdForEntry(c.Id.Entry);hash=hash*31+c.CurrentUpgradeLevel;}return hash;}
    }
    // 实战出现新候选时，从真实列表重新使用上游当前效果的选牌评分。
    public static int[] SelectActual(CardModel[] cards,int pile,string purpose,int effect,int min,int max){
        if(cards.Length==0)return [];
        var kind=effect>=0?(PlanChoiceEffect)effect:purpose switch{
            "TO_DISCARD"=>PlanChoiceEffect.Discard,"TO_EXHAUST" or "TO_REMOVE"=>PlanChoiceEffect.Exhaust,
            "TO_TRANSFORM"=>PlanChoiceEffect.Transform,"TO_UPGRADE"=>PlanChoiceEffect.Upgrade,
            _=>(PileType)pile==PileType.None?PlanChoiceEffect.GenerateToHand:PlanChoiceEffect.MoveToHand};
        var options=cards.Select(c=>new PredictedCard(c)).ToArray();
        var spec=new CardChoiceSpec(kind,(PileType)pile,Math.Min(min,cards.Length),Math.Min(max,cards.Length),options,options,0);
        var ranked=CardChoiceSupport.BuildChoices(spec,Names,1,1);
        if(ranked.Count==0)return Enumerable.Range(0,Math.Min(cards.Length,min)).ToArray();
        return ranked[0].Cards.Select(t=>Array.IndexOf(options,options.Where(x=>CardChoiceSupport.MatchesToken(x,t)).ElementAt(t.OptionOccurrence))).ToArray();
    }
}
