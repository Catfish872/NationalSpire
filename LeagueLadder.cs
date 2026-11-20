using MegaCrit.Sts2.Core.Models;

namespace NationalSpire;

internal static class LeagueLadder
{
    internal static readonly string[] Names=["新秀","精英","大师","传奇"];
    internal static readonly int[] Thresholds=[0,160,480,960];
    internal static int Tier(int points)=>Math.Max(0,Array.FindLastIndex(Thresholds,n=>points>=n));
    internal static int Health(CharacterModel role,int tier)=>role.StartingHp+30+20*tier;
    internal static bool RivalOpens(int seed)=>new Random(seed).Next(2)==1;
    internal static bool PrepareRoster(CareerData world)=>world.LeagueRoster?.Season!=world.Season&&
        LeagueSeasonRoster.Prepare(world,LeagueCards.OriginalRoles.Select(r=>r.Id.Entry).ToArray());
    internal sealed class Draw(CareerData world){
        internal readonly Dictionary<string,CareerPerson> People=world.People.ToDictionary(p=>p.Id);
        internal readonly Dictionary<string,CharacterModel> Roles=LeagueCards.OriginalRoles.ToDictionary(r=>r.Id.Entry);
        internal readonly HashSet<string> UsedPeople=[];
        internal readonly HashSet<(string,string)> UsedPlans=[];
    }
    internal static (string Name,CharacterModel Role,int Tier,string Style,string? PersonId) Match(LeagueSeasonRoster roster,Draw draw,Random rng,int tier){
        var available=roster.Brackets.Where(b=>b.Tier==tier&&draw.Roles.ContainsKey(b.Role))
            .SelectMany(b=>b.Styles.SelectMany(s=>s.Value.Where(draw.People.ContainsKey).Select(id=>(b.Role,b.Plan,Style:s.Key,Id:id)))).ToArray();
        if(available.Length==0){
            var roles=draw.Roles.Values.OrderBy(r=>r.Id.Entry,StringComparer.Ordinal).ToArray();var role=roles[rng.Next(roles.Length)];
            return ("联赛选手",role,tier,WorldPeople.PlayingStyle(NpcCharacters.Index(role.Id.Entry),rng.Next()),null);
        }
        // 先用尽本段位不同的选手；其中优先尚未在本场出战的职业与构筑组合。
        var people=available.Where(x=>!draw.UsedPeople.Contains(x.Id)).ToArray();
        if(people.Length==0)people=available;
        var fresh=people.Where(x=>!draw.UsedPlans.Contains((x.Role,x.Plan))).ToArray();
        var rolesInTier=(fresh.Length==0?people:fresh).GroupBy(x=>x.Role).ToArray();
        var plans=rolesInTier[rng.Next(rolesInTier.Length)].GroupBy(x=>x.Plan).ToArray();
        var players=plans[rng.Next(plans.Length)].ToArray();var pick=players[rng.Next(players.Length)];
        draw.UsedPeople.Add(pick.Id);draw.UsedPlans.Add((pick.Role,pick.Plan));
        return (draw.People[pick.Id].PublicName,draw.Roles[pick.Role],tier,pick.Style,pick.Id);
    }
    internal static (string Name,CharacterModel Role,int Tier,string Style,string? PersonId)? Invited(LeagueSeasonRoster roster,Draw draw,string personId){
        if(!draw.People.TryGetValue(personId,out var person))return null;
        foreach(var bracket in roster.Brackets){
            if(!draw.Roles.TryGetValue(bracket.Role,out var role))continue;
            foreach(var style in bracket.Styles.Where(s=>s.Value.Contains(personId))){
                draw.UsedPeople.Add(personId);draw.UsedPlans.Add((bracket.Role,bracket.Plan));
                return (person.PublicName,role,bracket.Tier,style.Key,personId);
            }
        }
        return null;
    }
    internal static Dictionary<string,int> UpgradePlan(CardModel[] cards,LeagueArchetypes.Plan plan,int tier,Random rng){
        return Upgrades(cards,plan,tier,rng,false);
    }
    // 建筑师的精英借用大师的运转目标，其余攻防与稀有度仍按出战段位选择。
    private static int ConstructionTier(int tier,bool final)=>final&&tier==1?2:tier;
    internal static Dictionary<string,int> Upgrades(CardModel[] cards,LeagueArchetypes.Plan plan,int tier,Random rng,bool final){
        int build=ConstructionTier(tier,final);
        int left=build>=2?(final?6:LeagueCards.UpgradeBudget):1+2*build;var upgrades=new Dictionary<string,int>();
        IEnumerable<CardModel> candidates=cards.Where(c=>c.MaxUpgradeLevel>0).OrderByDescending(c=>(plan.Anchors.Contains(c.Id.Entry)?2:plan.Partners.Contains(c.Id.Entry)?1:0)+rng.NextDouble()*1.5);
        Dictionary<string,int>? copies=null;
        if(tier==3&&!final){
            candidates=LeagueLegendDraft.ForgeOrder(cards,plan).Concat(candidates);
            copies=cards.GroupBy(c=>c.Id.Entry).ToDictionary(g=>g.Key,g=>g.Count());
        }
        foreach(var card in candidates){
            var id=card.Id.Entry;int cost=LeagueCards.UpgradeCost(LeagueCards.Catalog[id]);if(cost>left||copies!=null&&upgrades.GetValueOrDefault(id)>=copies[id])continue;
            upgrades[id]=upgrades.GetValueOrDefault(id)+1;left-=cost;if(left==0)break;
        }
        return upgrades;
    }
    internal static List<CardModel> Build(CharacterModel role,Random rng,int tier,string style){
        return BuildFor(role,rng,tier,style,false);
    }
    internal static List<CardModel> BuildFor(CharacterModel role,Random rng,int tier,string style,bool final){
        int build=ConstructionTier(tier,final);
        var plan=LeagueArchetypes.Resolve(role.Id.Entry,style);
        var pool=LeagueCards.Catalog.Values.Where(c=>(c.Group==role.Id.Entry||c.Group=="COLORLESS")&&GameCharacterNames.IsOriginal(c.Model.GetType())&&c.Model.MultiplayerConstraint.ToString()!="MultiplayerOnly").ToArray();
        if(tier==3&&!final&&LeagueLegendDraft.Build(plan,pool,rng) is {} legend)return legend;
        var engine=LeagueArchetypes.Engines[role.Id.Entry];
        var deck=new Dictionary<string,int>();var result=new List<CardModel>(LeagueCards.DeckSize);
        var rarity=new int[4];int neutral=0;
        void Add(LeagueCards.Entry c){deck[c.Id]=deck.GetValueOrDefault(c.Id)+1;result.Add(c.Model);rarity[c.Tier]++;if(c.Group=="COLORLESS")neutral++;}
        bool Available(LeagueCards.Entry c)=>result.Count<LeagueCards.DeckSize&&(c.Id!="BARRICADE"||!deck.ContainsKey(c.Id))&&deck.GetValueOrDefault(c.Id)<Math.Max(2,LeagueCards.Fixed(c))&&
            (c.Group!="COLORLESS"||neutral<LeagueCards.NeutralLimit)&&rarity[c.Tier]<(!final&&tier==3&&c.Tier==0?LeagueCards.DeckSize-LeagueCards.RarityLimits.Skip(1).Sum():LeagueCards.RarityLimits[c.Tier]);
        var core=pool.Where(c=>plan.Anchors.Contains(c.Id)).ToArray();
        var support=pool.Where(c=>plan.Partners.Contains(c.Id)).ToArray();
        foreach(var c in pool.Where(c=>LeagueCards.Fixed(c)>0))for(int i=0;i<LeagueCards.Fixed(c);i++)Add(c);
        if(tier==3||tier==2&&rng.Next(4)==0){
            var ancient=pool.Where(c=>c.Tier==3).ToArray();
            bool shared=rng.Next(2)==0;
            var pick=ancient.OrderByDescending(c=>(c.Group=="COLORLESS")==shared).ThenByDescending(c=>core.Contains(c)||support.Contains(c)).ThenBy(_=>rng.Next()).FirstOrDefault();
            if(pick!=null)Add(pick);
        }
        var common=pool.Where(c=>c.Tier<3).ToArray();
        var theme=core.Concat(support).Where(c=>c.Tier<3).Distinct().ToArray();
        if(tier==0&&plan.Anchors.Contains("PUNCH_OF_JOY")){
            foreach(var c in core.Where(c=>c.Id is "JEST" or "PUNCH_OF_JOY"))if(Available(c))Add(c);
        }
        if(tier>0){
            // 先让本打法的准备和兑现手段成对入组，再分配共用的运转名额。
            foreach(var c in core)if(c.Tier<3&&Available(c)&&LeagueArchetypes.CanSupportAnother(c.Id,deck))Add(c);
            var (guards,sustain)=LeagueArchetypes.Defense[role.Id.Entry];
            void Supply(HashSet<string> tools,int target,bool utility=false){
                bool Counts(string id)=>tools.Contains(id)&&(!utility||LeagueArchetypes.Enabled(id,deck));
                while(deck.Where(p=>Counts(p.Key)).Sum(p=>p.Value)<target){
                    var options=common.Where(c=>Counts(c.Id)&&Available(c)&&LeagueArchetypes.CanSupportAnother(c.Id,deck)).ToArray();
                    if(options.Length==0)break;
                    Add(options.MaxBy(c=>(theme.Contains(c)?1.1:0)+(c.Group==role.Id.Entry?.4:0)+rng.NextDouble()*2)!);
                }
            }
            Supply(plan.Starters,2+build);
            foreach(var c in core)if(c.Tier<3&&!deck.ContainsKey(c.Id)&&Available(c)&&LeagueArchetypes.CanSupportAnother(c.Id,deck))Add(c);
            Supply(plan.Finishers,1+build);
            Supply(guards.Split(' ').ToHashSet(),tier+2,true);
            Supply(sustain.Split(' ').ToHashSet(),tier==1?1:2,true);
            Supply(engine.Draw,1+2*build,true);Supply(engine.Energy,build==1?2:build==2?3:5,true);
        }
        int target=build switch{0=>5+rng.Next(4),1=>15+rng.Next(4),2=>(final?18:21)+rng.Next(4),_=>final?21+rng.Next(3):24};
        while(theme.Sum(c=>deck.GetValueOrDefault(c.Id))<target){
            var options=theme.Where(c=>Available(c)&&LeagueArchetypes.CanSupportAnother(c.Id,deck)).ToArray();if(options.Length==0)break;
            // 已有同名能力时，优先给能够立即出牌的配合留位；仍允许选择可叠加的能力。
            Add(options.MaxBy(c=>rng.NextDouble()*(c.Model.Type==MegaCrit.Sts2.Core.Entities.Cards.CardType.Power&&deck.ContainsKey(c.Id)?.65:1))!);
        }
        // 通用数值牌与职业牌共享同一份名额；运转牌已在上一步按实际触发条件挑选。
        var fillers=common.Where(c=>(c.Group==role.Id.Entry||tier>0&&(c.Id is "DARK_SHACKLES" or "HAND_OF_GREED" or "ETERNAL_ARMOR" or "GOLD_AXE"||engine.Draw.Contains(c.Id)||engine.Energy.Contains(c.Id))&&LeagueArchetypes.Enabled(c.Id,deck))).ToArray();
        while(result.Count<LeagueCards.DeckSize){
            int roll=rng.Next(100);int grade=roll<3+5*tier?2:roll<26+10*tier?1:0;
            var options=fillers.Where(c=>Available(c)&&LeagueArchetypes.CanSupportAnother(c.Id,deck)).ToArray();var preferred=options.Where(c=>c.Tier==grade).ToArray();
            if(preferred.Length==0)preferred=options;Add(preferred[rng.Next(preferred.Length)]);
        }
        return result;
    }
}
