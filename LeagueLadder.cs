using MegaCrit.Sts2.Core.Models;

namespace NationalSpire;

internal static class LeagueLadder
{
    internal static readonly string[] Names=["新秀","精英","大师","传奇"];
    internal static readonly int[] Thresholds=[0,160,480,960];
    internal static int Tier(int points)=>Math.Max(0,Array.FindLastIndex(Thresholds,n=>points>=n));
    internal static int Health(CharacterModel role,int tier)=>role.StartingHp+30+20*tier;
    internal static bool RivalOpens(int seed)=>new Random(seed).Next(2)==1;
    // 角色名称来自选手档案；没有该职业的选手时，由联赛提供匿名对手。
    internal static (string Name,CharacterModel Role,int Tier,string Style) Match(CareerData d,Random rng,int? forTier=null){
        var roles=LeagueCards.OriginalRoles;int tier=forTier??Tier(d.Life.League.Rating);
        var candidates=d.People.Select(p=>(Person:p,Role:roles.FirstOrDefault(r=>NpcCharacters.Index(r.Id.Entry)==NpcCharacters.Index(p.Character))))
            .Where(x=>x.Role!=null).Select(x=>(x.Person,x.Role,Tier:tier==3&&x.Person.MaxAscension>=10?3:x.Person.MaxAscension>=9?2:x.Person.MaxAscension>=6?1:0)).ToArray();
        if(candidates.Length==0){var role=roles[rng.Next(roles.Length)];return ("联赛选手",role,tier,WorldPeople.PlayingStyle(NpcCharacters.Index(role.Id.Entry),rng.Next()));}
        int distance=candidates.Min(x=>Math.Abs(x.Tier-tier));var group=candidates.Where(x=>Math.Abs(x.Tier-tier)==distance).ToArray();var pick=group[rng.Next(group.Length)];
        return (pick.Person.PublicName,pick.Role!,tier==3?tier:pick.Tier,pick.Person.Style);
    }
    internal static Dictionary<string,int> UpgradePlan(CardModel[] cards,LeagueArchetypes.Plan plan,int tier,Random rng){
        return Upgrades(cards,plan,tier,rng,false);
    }
    internal static Dictionary<string,int> Upgrades(CardModel[] cards,LeagueArchetypes.Plan plan,int tier,Random rng,bool final){
        int left=final&&tier>=2?6:tier>=2?LeagueCards.UpgradeBudget:1+2*tier;var upgrades=new Dictionary<string,int>();
        foreach(var card in cards.Where(c=>c.MaxUpgradeLevel>0).OrderByDescending(c=>(plan.Anchors.Contains(c.Id.Entry)?2:plan.Partners.Contains(c.Id.Entry)?1:0)+rng.NextDouble()*1.5)){
            var id=card.Id.Entry;int cost=LeagueCards.UpgradeCost(LeagueCards.Catalog[id]);if(cost>left)continue;
            upgrades[id]=upgrades.GetValueOrDefault(id)+1;left-=cost;if(left==0)break;
        }
        return upgrades;
    }
    internal static List<CardModel> Build(CharacterModel role,Random rng,int tier,string style){
        return BuildFor(role,rng,tier,style,false);
    }
    internal static List<CardModel> BuildFor(CharacterModel role,Random rng,int tier,string style,bool final){
        var plan=LeagueArchetypes.Resolve(role.Id.Entry,style);
        var pool=LeagueCards.Catalog.Values.Where(c=>(c.Group==role.Id.Entry||c.Group=="COLORLESS")&&GameCharacterNames.IsOriginal(c.Model.GetType())&&c.Model.MultiplayerConstraint.ToString()!="MultiplayerOnly").ToArray();
        var engine=LeagueArchetypes.Engines[role.Id.Entry];
        var deck=new Dictionary<string,int>();var result=new List<CardModel>(LeagueCards.DeckSize);
        var rarity=new int[4];int neutral=0;
        void Add(LeagueCards.Entry c){deck[c.Id]=deck.GetValueOrDefault(c.Id)+1;result.Add(c.Model);rarity[c.Tier]++;if(c.Group=="COLORLESS")neutral++;}
        bool Available(LeagueCards.Entry c)=>result.Count<LeagueCards.DeckSize&&deck.GetValueOrDefault(c.Id)<Math.Max(2,LeagueCards.Fixed(c))&&
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
            foreach(var c in theme)if(Available(c))Add(c);
            var (guards,sustain)=LeagueArchetypes.Defense[role.Id.Entry];
            void Supply(HashSet<string> tools,int target){
                int count=deck.Where(p=>tools.Contains(p.Key)&&LeagueArchetypes.Enabled(p.Key,deck)).Sum(p=>p.Value);
                while(count<target){
                    var options=common.Where(c=>tools.Contains(c.Id)&&LeagueArchetypes.Enabled(c.Id,deck)&&Available(c)).ToArray();
                    if(options.Length==0)break;
                    // 优先选能配合当前打法的牌，保留不同选手之间的变化。
                    Add(options.MaxBy(c=>(theme.Contains(c)?1.1:0)+(c.Group==role.Id.Entry?.4:0)+rng.NextDouble()*2)!);count++;
                }
            }
            Supply(guards.Split(' ').ToHashSet(),tier+2);
            Supply(sustain.Split(' ').ToHashSet(),tier==1?1:2);
            Supply(engine.Draw,1+2*tier);Supply(engine.Energy,tier==1?2:tier==2?3:5);
        }
        int target=tier switch{0=>5+rng.Next(4),1=>15+rng.Next(4),2=>(final?18:21)+rng.Next(4),_=>final?21+rng.Next(3):24};
        while(theme.Sum(c=>deck.GetValueOrDefault(c.Id))<target){
            var options=theme.Where(Available).ToArray();if(options.Length==0)break;Add(options[rng.Next(options.Length)]);
        }
        // 通用数值牌与职业牌共享同一份名额；运转牌已在上一步按实际触发条件挑选。
        var fillers=common.Where(c=>c.Group==role.Id.Entry||tier>0&&(c.Id is "DARK_SHACKLES" or "HAND_OF_GREED" or "ETERNAL_ARMOR" or "GOLD_AXE"||engine.Draw.Contains(c.Id)||engine.Energy.Contains(c.Id))&&LeagueArchetypes.Enabled(c.Id,deck)).ToArray();
        while(result.Count<LeagueCards.DeckSize){
            int roll=rng.Next(100);int grade=roll<3+5*tier?2:roll<26+10*tier?1:0;
            var options=fillers.Where(Available).ToArray();var preferred=options.Where(c=>c.Tier==grade).ToArray();
            if(preferred.Length==0)preferred=options;Add(preferred[rng.Next(preferred.Length)]);
        }
        return result;
    }
}
