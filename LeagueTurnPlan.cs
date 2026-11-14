using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;

namespace NationalSpire;

// 只推算自己手里的牌，保留得分较高的几种顺序。执行第一张后重新读取真实手牌与费用。
internal static class LeagueTurnPlan
{
    private sealed record Move(CardModel Card,int Cost,int Stars,decimal Damage,decimal Guard,int Draw,int Energy,int Strength,int Weak,bool Slam);
    private readonly record struct Path(ulong Used,int First,int Energy,int Stars,decimal Guard,decimal Attack,decimal Value,int Strength,int Weak);
    internal static CardModel? Choose(Player rival,List<LeagueDuel.Hit> incoming,int tier){
        var target=rival.Creature;int block=target.Block,injury=0,doom=0;
        foreach(var hit in incoming){
            if(hit.Target!=target)continue;
            int amount=hit.Shown,held=Math.Min(block,amount);block-=held;
            if(hit.Doom)doom+=amount-held;else injury+=amount-held;
        }
        int threat=injury+doom;
        bool lethal=injury+target.GetPowerAmount<MegaCrit.Sts2.Core.Models.Powers.DoomPower>()>=target.CurrentHp;
        var state=rival.PlayerCombatState!;
        Move Inspect(CardModel c){
            decimal V(string name)=>c.DynamicVars.TryGetValue(name,out var v)?v.BaseValue:0;
            string id=c.Id.Entry;
            decimal damage=V("Damage");if(damage==0&&c.Type==CardType.Attack)damage=4;
            if(c.DynamicVars.TryGetValue("CalculatedHits",out var hitCount)&&hitCount is MegaCrit.Sts2.Core.Localization.DynamicVars.CalculatedVar count)
                damage*=Math.Max(0,count.Calculate(rival.Creature.CombatState?.GetOpponentsOf(rival.Creature).FirstOrDefault(t=>t.IsHittable)));
            else damage*=Math.Max(1,V("Repeat"));
            int strength=(int)V("StrengthPower"),vulnerable=(int)V("VulnerablePower");
            return new(c,c.EnergyCost.GetAmountToSpend(),Math.Max(0,c.GetStarCostWithModifiers()),damage,V("Block"),(int)V("Cards"),(int)V("Energy"),strength,vulnerable,id=="BODY_SLAM");
        }
        var moves=state.Hand.Cards.Take(64).Select(Inspect).ToArray();if(moves.Length==0)return null;
        var legal=moves.Select(m=>m.Card.CanPlay()).ToArray();int width=3+3*tier,depth=2+tier;
        decimal Score(Path p)=>p.Attack+p.Value+Math.Min(threat,p.Guard)*(lethal?4:1.65m)+Math.Min(3,p.Energy)*.12m+p.Stars*.5m;
        var initial=new Path(0,-1,state.Energy,state.Stars,0,0,0,0,0);var front=new List<Path>{initial};Path best=initial;
        for(int d=0;d<depth;d++){
            var next=new List<Path>();
            foreach(var p in front)for(int i=0;i<moves.Length;i++){
                ulong bit=1UL<<i;var m=moves[i];if((p.Used&bit)!=0||!legal[i]||m.Cost>p.Energy||m.Stars>p.Stars)continue;
                var damage=m.Slam?p.Guard+rival.Creature.Block:m.Damage;
                if(m.Card.Type==CardType.Attack)damage=(damage+p.Strength)*(p.Weak>0?1.5m:1m);
                var q=new Path(p.Used|bit,p.First<0?i:p.First,p.Energy-m.Cost+m.Energy,p.Stars-m.Stars,p.Guard+m.Guard,p.Attack+damage,
                    p.Value+m.Draw*2.4m+m.Energy*1.5m+(m.Card.Type==CardType.Power?2.5m:0)+m.Strength+m.Weak,p.Strength+m.Strength,p.Weak+m.Weak);
                next.Add(q);if(Score(q)>Score(best))best=q;
            }
            if(next.Count==0)break;
            front=next.OrderByDescending(Score).ThenByDescending(q=>q.Energy).DistinctBy(q=>(q.Used,q.Energy,q.Stars,q.Guard,q.Attack,q.Strength,q.Weak)).Take(width).ToList();
        }
        return best.First<0?null:moves[best.First].Card;
    }
}
