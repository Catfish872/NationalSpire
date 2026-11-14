using HarmonyLib;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Commands;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Hooks;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.ValueProps;

namespace NationalSpire;

// 玩家由原生战斗系统操作。仅给敌方职业准备单独的手牌，并代选本回合出牌顺序。
public sealed partial class LeagueDuel
{
    internal readonly Random _rng;
    internal readonly Player Rival;
    internal readonly CardModel[] Deck;
    internal readonly string OpponentName;
    internal readonly int Tier;
    internal string[] SetupCards=[];
    internal readonly HashSet<Creature> Stunned=[];
    internal int? OpeningHp;internal int OpeningMax;
    public readonly List<Hit> Pending;
    // 同一场对决由 Current 收下全队已抵消格挡、尚待生效的灾厄。
    internal Queue<Hit>? DeferredDoom;
    public sealed record Hit(Creature Dealer,Creature Target,decimal Amount,ValueProp Props,string? Vfx,bool Center) {
        public ModifyDamageHookType Cap {get;init;}=ModifyDamageHookType.Cap;
        public bool AllowColossus {get;init;}=true;
        public CardModel? DoomSource {get;init;}public bool Doom {get;init;}
        internal decimal BeforeCap=>!Doom&&AllowColossus&&Target.GetPower<MegaCrit.Sts2.Core.Models.Powers.ColossusPower>() is {} p
            ?Amount*p.ModifyDamageMultiplicative(Target,Amount,Props,Dealer,null,null):Amount;
        internal int Shown=>(int)(!Doom&&Cap!=ModifyDamageHookType.None&&Target.GetPower<MegaCrit.Sts2.Core.Models.Powers.IntangiblePower>() is {} p
            ?Math.Min(BeforeCap,p.ModifyDamageCap(Target,Props,Dealer,null,null)):BeforeCap);
    }
    private readonly Dictionary<string,int>? _upgrades;
    internal LeagueDuel(Player rival,CardModel[] deck,int seed,string opponentName,int tier,Dictionary<string,int>? upgrades,List<Hit>? pending=null){Pending=pending??[];_upgrades=upgrades;Tier=tier;Rival=rival;Deck=deck;_rng=new(seed);OpponentName=opponentName;}
    internal void Attach(Creature actor){
        AccessTools.Field(typeof(Player),"<Creature>k__BackingField").SetValue(Rival,actor);
        Rival.ResetCombatState();
        var remaining=_upgrades?.ToDictionary();foreach(var c in Deck.OrderBy(_=>_rng.Next()))Rival.PlayerCombatState!.DrawPile.AddInternal(LeagueCards.ApplyAllocation(((CombatState)actor.CombatState!).CreateCard(c,Rival),remaining),-1,true);
    }
    internal async Task Act(){
        var s=Rival.PlayerCombatState!;
        var state=Rival.Creature.CombatState!;
        await LeagueSolverLink.PrepareChoices();
        var context=new BlockingPlayerChoiceContext();
        if(Hook.ShouldPlayerResetEnergy(state,Rival))s.ResetEnergy();else s.AddMaxEnergyToCurrent();
        await Hook.AfterEnergyReset(state,Rival);
        await Hook.BeforeHandDraw(state,Rival,context);
        decimal draw=Hook.ModifyHandDraw(state,Rival,5,out var modifiers);await Hook.AfterModifyingHandDraw(state,modifiers);
        if(s.TurnNumber==1){
            var bottom=s.DrawPile.Cards.Where(c=>c.Enchantment?.ShouldStartAtBottomOfDrawPile==true).ToArray();
            foreach(var c in bottom)s.DrawPile.MoveToBottomInternal(c);
            var innate=s.DrawPile.Cards.Where(c=>c.Keywords.Contains(CardKeyword.Innate)).Except(bottom).ToArray();
            foreach(var c in innate)s.DrawPile.MoveToTopInternal(c);
            draw=Math.Min(CardPile.MaxCardsInHand,Math.Max(draw,innate.Length));
        }
        await MegaCrit.Sts2.Core.Commands.CardPileCmd.Draw(context,draw,Rival,true);
        await Hook.AfterPlayerTurnStart(state,context,Rival);
        await s.OrbQueue.AfterTurnStart(context);
        var incoming=Pending.Where(h=>h.Target==Rival.Creature).ToArray();var amounts=incoming.Select(h=>h.Amount).ToArray();var props=incoming.Select(h=>(int)h.Props).ToArray();var capped=incoming.Select(h=>h.Cap!=ModifyDamageHookType.None).ToArray();
        var dealers=incoming.Select(h=>h.AllowColossus&&!h.Doom?(int?)h.Dealer.CombatId??-1:-1).ToArray();
        var seen=new Dictionary<string,decimal>();var host=LeagueNativeMatch.PlanHost;
        // 真人队员按稳定编号排列。每名 AI 从不同位置开始比较，下一回合顺延一位。
        var players=state.GetOpponentsOf(Rival.Creature).Where(c=>c.IsHittable&&c.Player!=null).OrderBy(c=>c.Player!.NetId).ToArray();
        int preference=-1;
        if(players.Length>1){
            int seat=LeagueNativeMatch.Fighters.TakeWhile(f=>f!=this).Count();
            preference=(int)players[(seat+Math.Max(0,s.TurnNumber-1))%players.Length].CombatId!.Value;
        }
        using var advisor=host?await LeagueSolverLink.Open(Rival,Tier,SetupCards,preference):null;
        var sequence=new Queue<(int Id,int Aim,int[] Choices)>();
        var identities=new Dictionary<CardModel,int>(ReferenceEqualityComparer.Instance);
        void Identify(){foreach(var pile in s.AllPiles)foreach(var instance in pile.Cards)identities.TryAdd(instance,identities.Count);}
        Identify();
        (CardModel?,Creature?) ReadNext(){
            if(!sequence.TryDequeue(out var move))return (null,null);
            var c=s.Hand.Cards.FirstOrDefault(x=>identities.TryGetValue(x,out var instance)&&instance==move.Id&&x.CanPlay());
            if(c==null)return (null,null);
            Creature? target=c.TargetType==TargetType.Self?Rival.Creature:move.Aim<0?null:state.Creatures.FirstOrDefault(t=>t.CombatId==move.Aim&&t.IsAlive);
            if(c.TargetType is TargetType.AnyEnemy or TargetType.AnyAlly&&target==null)return (null,null);
            _choicePlan=move.Choices;_choiceIndex=0;return(c,target);
        }
        bool skip=LeagueNativeMatch.ConsumeStun(Rival.Creature);
        while(!skip&&Rival.Creature.IsAlive&&state.Allies.Any(c=>c.IsAlive)){
            string key=s.Energy+":"+s.Stars+":"+string.Join(',',s.Hand.Cards.Select(c=>c.Id.Entry))+":"+s.DrawPile.Cards.Count;
            decimal queued=Pending.Where(h=>h.Dealer==Rival.Creature).Sum(h=>h.Amount);
            if(seen.TryGetValue(key,out var previous)&&(queued<=previous||queued>=state.Allies.Where(c=>c.IsAlive).Sum(c=>c.CurrentHp+c.Block)))break;seen[key]=queued;
            if(!s.Hand.Cards.Any(c=>c.CanPlay()))break;
            var (card,target)=ReadNext();
            if(card==null){
                sequence.Clear();Identify();var wire=new List<int>();
                if(host){
                    var best=await advisor!.Choose(amounts,props,capped,dealers);int aim=best==null?-1:advisor.Aim;
                    var chosen=best??(advisor.EndTurn?null:LeagueTurnPlan.Choose(Rival,Pending,Math.Min(Tier,2)));
                    if(chosen!=null){
                        if(aim<0&&chosen.TargetType==TargetType.AnyEnemy)aim=state.GetOpponentsOf(Rival.Creature).Any(t=>t.IsHittable&&(int?)t.CombatId==preference)?preference:(int)state.GetOpponentsOf(Rival.Creature).First(t=>t.IsHittable).CombatId!.Value;
                        if(chosen.TargetType is TargetType.AnyAlly or TargetType.Self)aim=(int)Rival.Creature.CombatId!.Value;
                        void Add(int id,int targetId,int[] choices){wire.AddRange([id,targetId,choices.Length]);wire.AddRange(choices);}
                        Add(identities[chosen],aim,best==null?[]:advisor.Choices);
                        if(best!=null)foreach(var (instance,t,choices) in advisor.Rest()){if(!identities.TryGetValue(instance,out var next))break;Add(next,t,choices);}
                    }
                }
                wire=await LeagueNativeMatch.SharePlan(wire);
                for(int j=0;j<wire.Count;){int id=wire[j++],aim=wire[j++],count=wire[j++];sequence.Enqueue((id,aim,count==0?[]:wire.GetRange(j,count).ToArray()));j+=count;}
                (card,target)=ReadNext();if(card==null)break;
            }
            try{var (cost,stars)=await card.SpendResources();
            await card.OnPlayWrapper(new BlockingPlayerChoiceContext(),target,true,new(){EnergySpent=cost,EnergyValue=cost,StarsSpent=stars,StarValue=stars},true);
            }finally{if(_choiceIndex!=_choicePlan.Length||_choicesChanged)sequence.Clear();_choicePlan=[];_choiceIndex=0;_choicesChanged=false;}
        }
        await s.OrbQueue.BeforeTurnEnd(context);
        var endings=s.Hand.Cards.Where(c=>c.HasTurnEndInHandEffect).ToArray();
        foreach(var c in s.Hand.Cards.Where(c=>!c.HasTurnEndInHandEffect&&c.Keywords.Contains(CardKeyword.Ethereal)&&Hook.ShouldEtherealTrigger(state,c)).ToArray())
            await MegaCrit.Sts2.Core.Commands.CardCmd.Exhaust(context,c,true);
        foreach(var c in endings)if(s.Hand.Cards.Contains(c)){
            await CardPileCmd.Add(c,PileType.Play,skipVisuals:true);await c.OnTurnEndInHandWrapper(context);
            if(c.Keywords.Contains(CardKeyword.Ethereal))await CardCmd.Exhaust(context,c,true,true);
            else await CardPileCmd.Add(c,PileType.Discard,skipVisuals:true);
        }
        await Hook.BeforeFlush(state,Rival);
        var discard=new List<CardModel>();var retain=new List<CardModel>();bool flush=Hook.ShouldFlush(state,Rival);
        foreach(var c in s.Hand.Cards)(flush&&!c.ShouldRetainThisTurn?discard:retain).Add(c);
        if(discard.Count>0)await MegaCrit.Sts2.Core.Commands.CardPileCmd.Add(discard,PileType.Discard,skipVisuals:true);
        await Hook.AfterFlush(state,Rival,context,discard,retain);
        s.EndOfTurnCleanup();s.IncrementTurnNumber();
    }
}
