using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.CardPools;

namespace NationalSpire;

public sealed class LeagueAlbum
{
    public Dictionary<string,int> Owned { get; set; } = [];
    public List<string>? PackRoles { get; set; }
    public Dictionary<string,Dictionary<string,int>> Decks { get; set; } = [];
    public Dictionary<string,Dictionary<string,int>> Upgrades { get; set; } = [];
    public HashSet<string> StandardDecks {get;set;}=[];
    public string Captain { get; set; } = "";
    public int Rating {get;set;}
    public int DuelWins {get;set;}
    public int DuelLosses {get;set;}
    public LeagueReceipt? LastDuel {get;set;}
    public int Packs { get; set; }
    public int BlueWait { get; set; }
    public int GoldWait { get; set; }
    public int AncientPending { get; set; }
    public List<string> Latest { get; set; } = [];
    public int MarketDay {get;set;}
    public HashSet<string> Purchased {get;set;} = [];
}
public sealed record LeagueFinish(string Match,string Opponent,int Tier) { public DuelReport? Report { get; init; } }
public sealed record LeagueReceipt(LeagueFinish Fight,bool Won,int Before,int After,int Prize);

public static class LeagueCards
{
    public sealed record Entry(CardModel Model,string Group,int Tier)
    {
        public string Id => Model.Id.Entry;
        public string Title => GameText.Plain(Model.Title);
        public string PartyHint=>Model.MultiplayerConstraint.ToString()!="MultiplayerOnly"?"":Model.TargetType.ToString()=="AnyAlly"?"需要队友 · 单挑中无法打出":"多人卡牌 · 单挑中按实际目标生效";
    }
    public const int PackCost=5000;
    public static readonly string[] Grades=["白卡","蓝卡","金卡","先古"];
    public static readonly int[] Bids=[60,700,8000,40000];
    // 白卡按一个卡位，蓝、金按保底包数；先古挂牌基准沿用金卡的五倍。
    public static int Ask(CareerData d, Entry card){
        int basis=card.Tier switch{0=>PackCost,1=>PackCost*10*5,2=>PackCost*80*5,_=>PackCost*80*25};
        uint hash=(uint)CareerEngine.StableHash($"{(d.AvatarWorldId.Length>0?d.AvatarWorldId:d.WorldId)}:卡价:{d.Day}:{card.Id}");
        return basis*(85+(int)(hash%31))/100;
    }
    public static readonly int[] Supply=[4,16,100,2500];
    private static CharacterModel[]? _roles;
    public static CharacterModel[] Roles => _roles ??= GameBridge.Characters().ToArray();
    internal static CharacterModel[] OriginalRoles=>Roles.Where(c=>GameCharacterNames.IsOriginal(c.GetType())&&NpcCharacters.Index(c.Id.Entry)>=0).ToArray();
    internal static string[] Pool(LeagueAlbum a){
        var originals=OriginalRoles.Select(r=>r.Id.Entry).ToArray();
        var active=(a.PackRoles??[..originals]).Where(g=>Roles.Any(r=>r.Id.Entry==g)).Distinct().ToList();
        foreach(var id in originals){if(active.Count>=6)break;if(!active.Contains(id))active.Add(id);}
        return active.ToArray();
    }
    private static Dictionary<string,Entry>? _catalog;
    private static readonly Dictionary<string,HashSet<string>> Membership=[];
    public static IReadOnlyDictionary<string,Entry> Catalog => _catalog ??= Build();
    private static Dictionary<string,Entry> Build()
    {
        Dictionary<string,Entry> cards=[];
        void Add(CardModel model,string group)
        {
            int tier=CollectionTier(model);
            if(tier<0)return;
            if(!Membership.TryGetValue(group,out var ids))Membership[group]=ids=[];
            ids.Add(model.Id.Entry);cards.TryAdd(model.Id.Entry,new(model,group,tier));
        }
        foreach(var role in Roles.OrderByDescending(r=>GameCharacterNames.IsOriginal(r.GetType()))) foreach(var c in role.CardPool.AllCards.Concat(role.StartingDeck)) Add(c,c.Pool.IsColorless?"COLORLESS":role.Id.Entry);
        foreach(var c in ModelDb.CardPool<ColorlessCardPool>().AllCards) Add(c,"COLORLESS");
        // 原版将部分无色先古牌归在事件牌池。
        foreach(var c in ModelDb.AllCards.Where(c=>c.Rarity.ToString()=="Ancient"&&c.Pool.IsColorless)) Add(c,"COLORLESS");
        return cards;
    }
    internal static int CollectionTier(CardModel model)=>model.Rarity.ToString() switch {"Common" or "Basic"=>0,"Uncommon"=>1,"Rare"=>2,"Ancient"=>3,_=>-1};
    internal static bool InRole(Entry c,string role)=>Membership.GetValueOrDefault(role)?.Contains(c.Id)==true;
    internal static bool Usable(Entry c,string role)=>InRole(c,role)||c.Group=="COLORLESS";
    private static IGrouping<string,Entry>[][]? _groups;
    private static IGrouping<string,Entry>[][] Groups {get{_=Catalog;return _groups??=Enumerable.Range(0,4).Select(t=>Membership.SelectMany(p=>p.Value.Select(id=>(p.Key,c:Catalog[id])).Where(x=>x.c.Tier==t)).GroupBy(x=>x.Key,x=>x.c).ToArray()).ToArray();}}
    public static string GroupName(string id)=>id=="COLORLESS"?"无色":Roles.FirstOrDefault(r=>r.Id.Entry==id) is {} r?GameText.Plain(r.Title.GetFormattedText()):id;
    public static IEnumerable<Entry> Offers(CareerData d)=>Catalog.Values.Where(c=>CareerEngine.StableHash($"{d.WorldId}:挂牌:{d.Day}:{c.Id}")%Supply[c.Tier]==0 && !(d.Life.League.MarketDay==d.Day && d.Life.League.Purchased.Contains(c.Id)));
    public static Dictionary<string,int>? Deck(LeagueAlbum a)=>Roles.Any(r=>r.Id.Entry==a.Captain)?a.Decks.GetValueOrDefault(a.Captain):null;
    public const int DeckSize=35,UpgradeBudget=8,NeutralLimit=5;
    internal static readonly int[] RarityLimits=[DeckSize,10,5,1];
    private static readonly Lazy<Dictionary<string,Dictionary<string,int>>> Basics=new(()=>Roles.ToDictionary(r=>r.Id.Entry,r=>{
        var counts=new Dictionary<string,int>();var start=r.StartingDeck.Where(c=>c.Rarity.ToString()=="Basic").GroupBy(c=>c.Id.Entry).OrderByDescending(g=>g.Count()).Select(g=>g.First()).ToArray();
        foreach(var (tag,n) in new[]{(MegaCrit.Sts2.Core.Entities.Cards.CardTag.Strike,2),(MegaCrit.Sts2.Core.Entities.Cards.CardTag.Defend,3)}){
            bool attack=n==2;var card=start.FirstOrDefault(c=>c.Tags.Contains(tag))??start.FirstOrDefault(c=>!counts.ContainsKey(c.Id.Entry)&&(attack?c.Type.ToString()=="Attack":c.GainsBlock));
            if(card!=null&&!counts.ContainsKey(card.Id.Entry))counts[card.Id.Entry]=n;
        }return counts;}));
    public static int Fixed(Entry c,string? role=null)=>Basics.Value.GetValueOrDefault(role??c.Group)?.GetValueOrDefault(c.Id)??0;
    private static void PrepareDeck(LeagueAlbum a,string role){
        if(a.StandardDecks.Contains(role))return;
        var old=a.Decks.GetValueOrDefault(role)??[];var deck=new Dictionary<string,int>();var upgrades=a.Upgrades.GetValueOrDefault(role);
        if(old.Keys.Any(id=>!Catalog.ContainsKey(id)))return;
        void Add(Entry c){int n=deck.GetValueOrDefault(c.Id)+1;deck[c.Id]=n;if(a.Owned.GetValueOrDefault(c.Id)<n)a.Owned[c.Id]=n;}
        var pool=Catalog.Values.Where(c=>InRole(c,role)).ToArray();
        foreach(var c in pool.Where(c=>Fixed(c,role)>0))for(int i=0;i<Fixed(c,role);i++)Add(c);
        foreach(var (id,n) in old.OrderByDescending(p=>upgrades?.GetValueOrDefault(p.Key)>0)){
            if(!Catalog.TryGetValue(id,out var c)||Fixed(c,role)>0)continue;
            for(int i=0;i<n&&Limit(deck,c,role:role)==null;i++)Add(c);
        }
        var filler=pool.Where(c=>Fixed(c,role)==0&&c.Tier==0&&c.Model.MultiplayerConstraint.ToString()!="MultiplayerOnly").OrderByDescending(c=>a.Owned.GetValueOrDefault(c.Id)>0).ThenBy(c=>CareerEngine.StableHash(c.Id)).ToArray();
        for(int pass=0;pass<2;pass++)foreach(var c in filler)if(deck.Values.Sum()<DeckSize&&deck.GetValueOrDefault(c.Id)<=pass)Add(c);
        if(upgrades!=null)foreach(var id in upgrades.Keys.ToArray()){int n=Math.Min(upgrades[id],deck.GetValueOrDefault(id));if(n==0)upgrades.Remove(id);else upgrades[id]=n;}
        a.Decks[role]=deck;a.StandardDecks.Add(role);
    }
    public static bool Ready(LeagueAlbum a)=>a.StandardDecks.Contains(a.Captain)&&Deck(a) is {} d&&d.Values.Sum()==DeckSize&&Basics.Value.TryGetValue(a.Captain,out var fixedCards)&&fixedCards.All(p=>d.GetValueOrDefault(p.Key)==p.Value)&&d.All(p=>Catalog.TryGetValue(p.Key,out var c)&&Usable(c,a.Captain)&&p.Value>0&&p.Value<=Math.Max(2,Fixed(c,a.Captain)));
    public static int UpgradeCost(Entry entry)=>entry.Tier>=2?2:1;
    public static int Upgraded(LeagueAlbum a,string id)=>a.Upgrades.GetValueOrDefault(a.Captain)?.GetValueOrDefault(id)??0;
    public static int Points(LeagueAlbum a)=>a.Upgrades.GetValueOrDefault(a.Captain)?.Sum(p=>Catalog.TryGetValue(p.Key,out var e)?UpgradeCost(e)*p.Value:0)??0;
    public static CardModel Improve(CardModel instance){instance.UpgradeInternal();instance.FinalizeUpgradeInternal();return instance;}
    internal static CardModel ApplyAllocation(CardModel live,Dictionary<string,int>? remaining){
        string id=live.Id.Entry;if(remaining?.GetValueOrDefault(id)>0){Improve(live);remaining[id]--;}return live;
    }
    // 只保存每种牌升级的张数。原版实际创建每张冒险牌后再升级，绝不修改公共牌库。
    public static bool AdjustUpgrade(LeagueAlbum a,Entry e,int change){
        var qty=Deck(a)?.GetValueOrDefault(e.Id)??0;var previous=Upgraded(a,e.Id);var next=previous+change;
        if(next<0||next>qty||change>0&&(e.Model.MaxUpgradeLevel<1||Points(a)+UpgradeCost(e)>UpgradeBudget))return false;
        if(!a.Upgrades.TryGetValue(a.Captain,out var counts))a.Upgrades[a.Captain]=counts=[];
        if(next==0)counts.Remove(e.Id);else counts[e.Id]=next;
        if(counts.Count==0)a.Upgrades.Remove(a.Captain);return true;
    }
    public static int Reserved(LeagueAlbum a,string id)=>a.Decks.Values.Select(x=>x.GetValueOrDefault(id)).DefaultIfEmpty().Max();
    public static string? Limit(Dictionary<string,int> deck,Entry e,string? outgoing=null,string? role=null)
    {
        if(deck.Values.Sum()-(outgoing==null?0:1)>=DeckSize)return "牌组已满，请选择要替换的牌。";
        if(deck.GetValueOrDefault(e.Id)>=Math.Max(2,Fixed(e,role)))return "这种牌已达到张数上限。";
        int Count(Func<Entry,bool> match)=>deck.Sum(x=>Catalog.TryGetValue(x.Key,out var c)&&match(c)?x.Value-(x.Key==outgoing?1:0):0);
        if(e.Tier>0 && Count(c=>c.Tier==e.Tier)>=RarityLimits[e.Tier]) return Grades[e.Tier]+"已达到上限。";
        return e.Group=="COLORLESS" && Count(c=>c.Group=="COLORLESS")>=NeutralLimit?"无色卡已达到上限。":null;
    }
    public static bool CanReplace(LeagueAlbum a,string old,Entry next){
        var deck=Deck(a);return deck!=null&&deck.TryGetValue(old,out int have)&&have>0&&old!=next.Id
            &&(!Catalog.TryGetValue(old,out var previous)||Fixed(previous,a.Captain)==0)
            &&Usable(next,a.Captain)&&deck.GetValueOrDefault(next.Id)<a.Owned.GetValueOrDefault(next.Id)
            &&Limit(deck,next,old,a.Captain)==null;
    }
    private static void RemoveOne(LeagueAlbum a,Dictionary<string,int> deck,string id){
        int count=deck[id];if(a.Upgrades.GetValueOrDefault(a.Captain) is {} ups&&ups.GetValueOrDefault(id)>=count){
            if(count==1)ups.Remove(id);else ups[id]=count-1;if(ups.Count==0)a.Upgrades.Remove(a.Captain);
        }
        if(count==1)deck.Remove(id);else deck[id]=count-1;
    }
    public static string? Apply(CareerData d,string action,string id,int n)
    {
        var a=d.Life.League;
        void Pay(decimal units,string title){CareerMoney.Add(d,units);CareerMoney.Record(d,title,units);}
        switch(action)
        {
            case "result":
                if(n is not (0 or 1))return "无法识别对战结果。";
                var finish=id.Length==0?null:System.Text.Json.JsonSerializer.Deserialize<LeagueFinish>(id);
                if(finish!=null&&(finish.Tier<0 || finish.Tier>=LeagueLadder.Names.Length || string.IsNullOrEmpty(finish.Match)))return "无法识别对手段位或场次。";
                if(finish!=null&&a.LastDuel?.Fight.Match==finish.Match)break;
                int before=a.Rating,prize=finish!=null&&n==1?1000*(finish.Tier+1):0;
                int change=Random.Shared.Next(16,21);
                if(n==1){a.DuelWins++;a.Rating+=change;}else{a.DuelLosses++;a.Rating=Math.Max(0,a.Rating-change);}
                if(prize>0)Pay(prize,"集卡联赛胜场奖金");
                if(finish!=null)a.LastDuel=new(finish,n==1,before,a.Rating,prize);
                break;
            case "pool":{
                var chosen=System.Text.Json.JsonSerializer.Deserialize<string[]>(id)??[];
                var selected=chosen.Distinct().Where(g=>Roles.Any(r=>r.Id.Entry==g)).ToList();
                if(selected.Count<Math.Min(6,Roles.Length))return $"请选择至少 {Math.Min(6,Roles.Length)} 个职业。";
                a.PackRoles=[..selected,..(a.PackRoles??[]).Where(g=>!Roles.Any(r=>r.Id.Entry==g))];break;
            }
            case "pack":
                if(n is not (1 or 10)) return "请选择一包或十包。";
                if(CareerMoney.Balance(d)<PackCost*n) return "当前资金不足。";
                var pool=Pool(a).Append("COLORLESS").ToHashSet();
                var eligible=Groups.Select(groups=>groups.Where(g=>pool.Contains(g.Key)).ToArray()).ToArray();
                // 无色始终提供蓝卡和金卡。若整套自选卡池都没有白卡，只在可抽到的稀有度间按原权重分配。
                int totalWeight=eligible[0].Length==0?43:1000;
                a.Latest=[];
                for(int p=0;p<n;p++)
                {
                    var rng=new Random(CareerEngine.StableHash($"{d.WorldId}:{d.LocalHumanId}:卡包:{a.Packs++}"));
                    int[] tiers=new int[5];
                    for(int i=0;i<tiers.Length;i++){int roll=rng.Next(totalWeight);tiers[i]=roll<3?2:roll<43?1:0;}
                    void Ensure(int tier, int threshold,int wait){if(wait+1>=threshold&&!tiers.Contains(tier)){int i=Array.IndexOf(tiers,0); if(i<0)i=Array.FindIndex(tiers,t=>tiers.Count(v=>v==t)>1);tiers[i]=tier;}}
                    Ensure(1,10,a.BlueWait);Ensure(2,80,a.GoldWait);
                    a.BlueWait=tiers.Contains(1)?0:a.BlueWait+1;a.GoldWait=tiers.Contains(2)?0:a.GoldWait+1;
                    foreach(int t in tiers) if(t==2 && rng.Next(10)==0) a.AncientPending++;
                    for(int i=0;i<5;i++)
                    {
                        int tier=tiers[i];if((tier==0||tier==1&&tiers.Count(x=>x==1)>1)&&a.AncientPending>0){tiers[i]=tier=3;a.AncientPending--;}
                        var choices=eligible[tier];var group=choices[rng.Next(choices.Length)];
                        var pick=group.ElementAt(rng.Next(group.Count()));
                        a.Latest.Add(pick.Id);a.Owned[pick.Id]=a.Owned.GetValueOrDefault(pick.Id)+1;
                    }
                }
                Pay(-PackCost*n,"联赛卡包 × "+n);break;
            case "captain":
                var role=Roles.FirstOrDefault(r=>r.Id.Entry==id);if(role==null)return "当前游戏没有这个职业。";
                a.Captain=id;
                PrepareDeck(a,id);break;
            case "upgrade":case "downgrade":
                if(!Catalog.TryGetValue(id,out var target)||!AdjustUpgrade(a,target,action=="upgrade"?1:-1))return "这张牌的升级名额或剩余点数已改变。";
                break;
            case "remove" when !Catalog.ContainsKey(id):
                var legacy=Deck(a);if(legacy==null||!legacy.TryGetValue(id,out var copies)||copies<=0)return "牌组中没有这张牌。";
                RemoveOne(a,legacy,id);
                break;
            case "swap":
                var pair=id.Split('|',2);if(pair.Length!=2||!Catalog.TryGetValue(pair[1],out var next)||!CanReplace(a,pair[0],next))return "当前牌组无法进行这次替换。";
                var full=Deck(a)!;RemoveOne(a,full,pair[0]);full[next.Id]=full.GetValueOrDefault(next.Id)+1;
                break;
            case "buy":case "sell":case "add":case "remove":
                if(!Catalog.TryGetValue(id,out var entry))return "当前游戏没有这张牌。";
                int owned=a.Owned.GetValueOrDefault(id);
                if(action=="buy"){
                    if(!Offers(d).Any(c=>c.Id==id))return "这张牌已经售出。";
                    int price=Ask(d,entry);if(CareerMoney.Balance(d)<price)return "当前资金不足。";
                    if(a.MarketDay!=d.Day){a.MarketDay=d.Day;a.Purchased.Clear();}a.Purchased.Add(id);
                    Pay(-price,"购入 · "+entry.Title);a.Owned[id]=owned+1;
                }else if(action=="sell"){
                    if(n<1||n>owned-Reserved(a,id))return "请先把要出售的卡牌移出牌组。";
                    a.Owned[id]-=n;Pay((decimal)Bids[entry.Tier]*n,"出售 · "+entry.Title+" × "+n);
                }else{
                    var deck=Deck(a);if(deck==null)return "请先选择出战职业。";int have=deck.GetValueOrDefault(id);
                    if(action=="remove"){if(have<=0)return "牌组中没有这张牌。";if(Fixed(entry,a.Captain)>0&&have<=Fixed(entry,a.Captain))return "基础打击和防御固定占位。";RemoveOne(a,deck,id);}
                    else{if(!Usable(entry,a.Captain))return "请选择本职业或无色牌。";if(have>=owned)return "收藏数量不足。";if(Limit(deck,entry,role:a.Captain) is {} err)return err;deck[id]=have+1;}
                }break;
            default:return "未识别的集卡操作。";
        }
        return null;
    }
}
