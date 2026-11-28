using CombatSolver;
using CombatSolver.HotKernel;
using CombatSolver.HotSearch;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.ValueProps;
using System.Diagnostics;

namespace NationalSpire.Solver;

public sealed partial class LeagueForecast
{
    private sealed record Move(CardModel? Card, int Target, int[] Choices, string Entry);
    private sealed class Branch(CombatHotState state, HotColdSidecar? cold, IntentLedger intents, List<Move> route)
    {
        public CombatHotState State = state;
        public readonly HotColdSidecar? Cold = cold;
        public readonly IntentLedger Intents = intents;
        public readonly List<Move> Route = route;
        public decimal Score;
    }

    private readonly HashSet<string> _setup = new(setup);
    private List<Move> _route = [];
    public int[] LastChoices { get; private set; } = [];
    public int LastAim { get; private set; } = -1;
    public bool EndTurn { get; private set; }
    public (CardModel,int,int[])[] Continuation()
    {
        var next = _route.TakeWhile(m => m.Card != null).Select(m => (m.Card!,m.Target,m.Choices)).ToArray();
        _route.Clear();
        return next;
    }
    public static (int,int,int)[] ReportRuns(int[] actions) =>
        SolverActionRuns.Capture(actions,(a,b)=>a==b).Select(r=>(r.Start,r.Period,r.Repetitions)).ToArray();

    public async Task<CardModel?> Choose(decimal[] incoming, int[] props, bool[] caps, int[] dealers)
    {
        EndTurn=false;
        var hand=_live.PlayerCombatState!.Hand.Cards;
        if(!hand.Any(c=>c.CanPlay())){_route.Clear();EndTurn=true;return null;}
        if(_route.Count>0){
            var next=_route[0];_route.RemoveAt(0);
            if(next.Card is {} card && hand.Contains(card) && card.CanPlay()){
                LastAim=next.Target;LastChoices=next.Choices;return card;
            }
            _route.Clear();
        }
        Dispose();
        var timer = Stopwatch.StartNew();
        var review=Environment.GetEnvironmentVariable("LEAGUE_PREVIEW_ROOT");
        long captureBytes=review==null?0:GC.GetAllocatedBytesForCurrentThread(),searchBytes=0;
        var snapshot = Capture(incoming.Any(x=>x>0));
        var root = snapshot.HotRoot;
        var state = root.RootState;
        var rules = root.Rules;
        var policySnapshot = new SearchPolicySnapshot(SolverSearchProfile.Default,SolverPotionPolicy.Disabled,
            new(SolverPotionPolicy.Disabled,[]),false,false,false,false,1,null,false,null,
            BossHpStrategy.ProgressionFirst,BossHpStrategy.ProgressionFirst,0,new(_=>{},_=>{}));
        var policy = new HotSearchPolicy(snapshot,new(0,0,0,[]),policySnapshot,rules,in state,[]);
        var lookup = new HotEvalLookup(rules);
        var realCards = OriginalCards(in state);
        var targets = new int[state.EnemyCount];
        for(int i=0;i<targets.Length;i++){
            var combatId=state.Enemies[i].Vital.CombatId;
            targets[i]=_aims.First(pair=>pair.Key.CombatId==combatId).Value;
        }
        var damageDecrease = MegaCrit.Sts2.Core.Models.ModelDb.Power<MegaCrit.Sts2.Core.Models.Powers.ColossusPower>().DynamicVars["DamageDecrease"].BaseValue;
        var incomingActors = dealers.Select(id=>Array.IndexOf(targets,id)).ToArray();
        var pass = new Branch(state,root.RootCold,new(added),[]);
        bool bladePlan=tier==3 && realCards.Values.Any(c=>c is MegaCrit.Sts2.Core.Models.Cards.Conqueror or MegaCrit.Sts2.Core.Models.Cards.SwordSage or MegaCrit.Sts2.Core.Models.Cards.SummonForth);
        bool fool=_live.Character.Id.Entry=="FOOL";
        decimal incomingSum=incoming.Sum();
        if(review!=null)captureBytes=GC.GetAllocatedBytesForCurrentThread()-captureBytes;
        int level = Math.Min(2,tier), width=3+2*level, expanded=0;
        bool incomplete=false;
        var captureMs=timer.Elapsed.TotalMilliseconds;
        double searchMs=0;
        var best = await Task.Run(()=>{
            var clock=Stopwatch.StartNew();
            long workerStart=review==null?0:GC.GetAllocatedBytesForCurrentThread();
            var scratch=new HotExecScratch();
            var actions=new HotAction[HotLimits.MaxCards*(1+HotLimits.MaxEnemies)];
            var packed=new byte[HotLimits.MaxPackedStateBytes];
            decimal Evaluate(Branch branch, out bool lethal){
                var end=branch.State;
                var cold=branch.Cold;
                var marks=branch.Intents;
                if(end.OrbCount>0){
                    var previous=_outgoing;
                    _outgoing=marks=marks.Fork();
                    try{HotCombatEngine.TriggerOrbsBeforeTurnEnd(ref end,ref cold,rules,scratch);}
                    finally{_outgoing=previous;}
                }
                var summary=HotEvaluator.ExtractStage1(in branch.State,in policy);
                HotEvaluator.EvaluateState(in branch.State,branch.Cold,rules,in policy,in lookup,in summary,0,branch.Route.Count,HotEvalMode.Balanced,out var evaluation);
                int deferred=0;
                for(int i=0;i<incoming.Length && end.Player.CurrentHp>0;i++){
                    if(props[i]==-1){
                        int block=Math.Min(end.Player.Block,(int)incoming[i]);
                        end.Player.Block-=block;deferred+=(int)incoming[i]-block;
                        continue;
                    }
                    int actorIndex=incomingActors[i];
                    byte dealer=actorIndex<0?byte.MaxValue:(byte)(3+actorIndex);
                    var amount=incoming[i];
                    bool attack=((ValueProp)props[i]).IsPoweredAttack();
                    if(attack && actorIndex>=0 && HotCombatEngine.GetPowerAmountById(in end,rules,dealer,HotPowerId.VulnerablePower)>0
                       && HotCombatEngine.GetPowerAmountById(in end,rules,0,HotPowerId.ColossusPower)>0) amount*=damageDecrease;
                    Deliver(ref end,ref cold,rules,scratch,dealer,amount,attack,((ValueProp)props[i]).HasFlag(ValueProp.Unblockable),caps[i]);
                }
                int hp=end.Player.CurrentHp;
                bool dead=hp<=0 || HotCombatEngine.GetPowerAmountById(in end,rules,0,HotPowerId.DoomPower)>=hp;
                decimal value=LeagueDuelScore.Defender(hp,deferred,dead,level>0?evaluation.SetupScore:0,end.Stars);
                // 铸造直接改变这一张剑的伤害；SetupScore 仅给能力与状态评分。
                if(bladePlan){
                    int blade=0;
                    for(int i=0;i<end.ExhaustStart;i++){
                        var card=end.Cards[i];var def=rules.Cards[card.CardDefId];
                        if(def.CardId==HotCustomCardId.SovereignBlade)
                            blade=Math.Max(blade,def.GetDamage(card.UpgradeLevel,card.Var0Delta)*def.GetHits(card.UpgradeLevel));
                    }
                    value+=LeagueDuelScore.ForgedBlade(blade,summary.EnemyHpSum);
                }
                lethal=true;
                for(byte i=0;i<end.EnemyCount;i++){
                    byte target=(byte)(i+3);
                    var foe=end.Enemies[i].Vital;var original=state.Enemies[i].Vital;
                    int block=foe.Block,through=0,doom=0,attack=0;
                    foreach(var hit in marks.Moves){
                        if(hit.Target!=target)continue;
                        int amount=(int)hit.Amount;
                        int held=hit.Unblockable?0:Math.Min(block,amount);
                        block-=held;
                        if(hit.Doom)doom+=amount-held;
                        else {attack+=amount;through+=amount-held;}
                    }
                    int activeDoom=HotCombatEngine.GetPowerAmountById(in end,rules,target,HotPowerId.DoomPower);
                    int poison=HotCombatEngine.GetPowerAmountById(in end,rules,target,HotPowerId.PoisonPower);
                    value+=LeagueDuelScore.Opponent(original.CurrentHp,original.Block,foe.CurrentHp,attack,through,
                        poison,activeDoom,doom,dead);
                    lethal &= through>=foe.CurrentHp;
                }
                lethal &= !dead;
                return value;
            }
            int Order(Branch branch, HotAction a){
                var card=branch.State.Cards[a.SlotOrHandIdx];
                var def=rules.Cards[card.CardDefId];
                if(tier==3 && card.BaseEnergyCost==0 && (def.OrderedVarNames.Contains("Energy")||def.OrderedVarNames.Contains("Cards")))return -2;
                if(tier==3 && def.CardId==HotCustomCardId.Conqueror){
                    for(int i=0;i<branch.State.HandCount;i++)
                        if(rules.Cards[branch.State.Cards[i].CardDefId].CardId==HotCustomCardId.SovereignBlade)return -1;
                }
                var needed=def.CalcVar switch{
                    HotCalcVarKind.Radiate=>HotCounterSlot.StarsGainedThisTurn,
                    HotCalcVarKind.HelixDrill=>HotCounterSlot.EnergySpentThisTurn,
                    HotCalcVarKind.LunarBlast=>HotCounterSlot.SkillsPlayedThisTurn,
                    _=>(HotCounterSlot?)null};
                if(needed is {} counter && branch.State.Counters[(int)counter]==0)return 2;
                return def.Type==CardType.Power || _setup.Contains(def.Entry) || def.OrderedVarNames.Any(v=>v is "Cards" or "Energy" or "WeakPower" or "VulnerablePower" or "StrengthPower")?0:1;
            }
            bool ImprovesStatus(in CombatHotState child){
                for(int i=0;i<child.PowerCount;i++){
                    var power=child.Powers[i];
                    var def=rules.Powers[power.PowerDefId];
                    if(power.Amount<=0 || (power.OwnerSlot==0 && def.Type!=MegaCrit.Sts2.Core.Entities.Powers.PowerType.Buff)
                        || (power.OwnerSlot>0 && (power.OwnerSlot<3 || def.Type!=MegaCrit.Sts2.Core.Entities.Powers.PowerType.Debuff)))continue;
                    if(power.Amount>HotCombatEngine.GetPowerAmount(in state,power.OwnerSlot,power.PowerDefId))return true;
                }
                return false;
            }
            IEnumerable<LeagueTurnSearch.Candidate<Branch,(HotHash128,int)>> Expand(Branch parent,Func<bool> expired){
                int n=HotCombatEngine.EnumerateLegalActions(in parent.State,parent.Cold,rules,actions);
                var order=actions.Take(n).Where(a=>a.Kind==HotActionKind.PlayCard).OrderBy(a=>Order(parent,a))
                    .ThenByDescending(a=>a.TargetEnemySlot>=0 && targets[a.TargetEnemySlot]==preference).ToArray();
                foreach(var action in order){
                    if(expired())yield break;
                    var card=parent.State.Cards[action.SlotOrHandIdx];
                    var pending=new Stack<SelectionPath>();pending.Push(new([],[]));
                    while(pending.TryPop(out var path)){
                        if(path.Selections.Length>0 && expired())yield break;
                        var child=parent.State;var cold=parent.Cold;
                        var step=TryStep(ref child,ref cold,rules,scratch,action,path.Selections,parent.Intents,out var intents);
                        if(step.NeedsChoice){
                            ExtendChoices(in parent.State,action,in child,cold,rules,lookup,scratch,path,pending,width,(int)incomingSum);continue;
                        }
                        if(!step.Executed){incomplete=true;continue;}
                        int aim=action.TargetEnemySlot>=0?targets[action.TargetEnemySlot]:-1;
                        var move=new Move(realCards.GetValueOrDefault(card.CardUid),aim,Wire(path),rules.Cards[card.CardDefId].Entry);
                        var b=new Branch(child,cold,intents,[..parent.Route,move]);
                        var end=Evaluate(b,out var lethal);
                        int usable=child.HandCount;
                        if(fool){
                            int sadness=0;
                            for(int i=0;i<child.HandCount;i++)
                                if(rules.Cards[child.Cards[i].CardDefId].CardId==HotCustomCardId.Sadness)sadness++;
                            usable-=sadness+Math.Max(0,sadness-HotCombatEngine.GetPowerAmountById(in child,rules,0,HotPowerId.EcstasyPower));
                        }
                        b.Score=LeagueDuelScore.Continue(end,usable,child.Energy);
                        var image=child;var coldKey=cold;
                        int length=HotStatePacker.Pack(ref image,ref coldKey,packed,false);
                        var hash=new HashCode();foreach(var hit in intents.Moves)hash.Add(hit);
                        var key=(HotHash.ComputeHash(packed.AsSpan(0,length),coldKey),hash.ToHashCode());
                        yield return new(b,key,end,b.Score,lethal,ImprovesStatus(in child));
                    }
                }
            }
            try{
                var result=LeagueTurnSearch.Choose<Branch,(HotHash128,int)>(pass,Evaluate(pass,out _),level,exit,Expand);
                expanded=result.Compared;
                return result.State;
            }finally{searchMs=clock.Elapsed.TotalMilliseconds;if(review!=null)searchBytes=GC.GetAllocatedBytesForCurrentThread()-workerStart;}
        },exit);
        exit.ThrowIfCancellationRequested();
        _route=best.Route;
        EndTurn=_route.Count==0&&!incomplete&&expanded>0;
        if(review!=null)
            File.AppendAllText(Path.Combine(review,"solver-review.txt"),$"role={_live.Character.Id.Entry} capture={captureMs:F1}ms search={searchMs:F1}ms total={timer.Elapsed.TotalMilliseconds:F1}ms captureBytes={captureBytes} searchBytes={searchBytes} expanded={expanded} end={EndTurn} route={string.Join(' ',_route.Select(m=>m.Entry))}\n");
        if(_route.Count==0)return null;
        var first=_route[0];_route.RemoveAt(0);LastAim=first.Target;LastChoices=first.Choices;return first.Card;
    }
}
