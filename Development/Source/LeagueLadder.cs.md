# LeagueLadder.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`0A6FA5F51EE423CBE576502642E9FA887B1E6A6C0756FB8FE74BCB7F689BDBF7`。来源：[源码](../../LeagueLadder.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LeagueLadder`。

字段、事件及初始值（源码原样）：

```csharp
internal static readonly string[] Names=["新秀","精英","大师","传奇"];
internal static readonly int[] Thresholds=[0,160,480,960];
```

<a id="symbol-b15a71b48f9a"></a>

## `NationalSpire.LeagueLadder.Tier(int) — internal static int Tier(int points)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Begin()`](LeagueArenaScreen.cs.md#symbol-6efcffde32aa)；[`NationalSpire.CareerScreen.LeagueArena(NationalSpire.CareerData)`](LeagueArenaScreen.cs.md#symbol-59be112523d9)；[`NationalSpire.CareerScreen.LeagueMatch(NationalSpire.CareerData)`](LeagueArenaScreen.cs.md#symbol-c9e06b5e2f9d)；[`NationalSpire.CareerScreen.LeagueScore(NationalSpire.LeagueReceipt)`](LeagueArenaScreen.cs.md#symbol-bd915636fa04)；[`NationalSpire.Coop.CoopRules.FinishLeagueTeam(NationalSpire.Coop.CoopCoordinator, string, bool?)`](Coop/CoopRules.cs.md#symbol-de0ba69e5b42)；[`NationalSpire.LeagueLadder.Match(NationalSpire.CareerData, System.Random, int?)`](LeagueLadder.cs.md#symbol-4009feb05261)；[`NationalSpire.LeagueNativeMatch.StartTeam(NationalSpire.Coop.CoopCoordinator, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>)`](LeagueTeamMatch.cs.md#symbol-81e11d18adc7)

**调用：** `System.Array.FindLastIndex<T>(T[], System.Predicate<T>)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueLadder.Thresholds`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Array.FindLastIndex<T>(T[], System.Predicate<T>)`；输入表达式：`Array.FindLastIndex(Thresholds,n=>points>=n)`；返回值紧邻使用处：`ArgumentSyntax: Array.FindLastIndex(Thresholds,n=>points>=n)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0,Array.FindLastIndex(Thresholds,n=>points>=n))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>Math.Max(0,Array.FindLastIndex(Thresholds,n=>points>=n))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9d40de0014e6"></a>

## `NationalSpire.LeagueLadder.Health(MegaCrit.Sts2.Core.Models.CharacterModel, int) — internal static int Health(CharacterModel role,int tier)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.EquipDeck(MegaCrit.Sts2.Core.Runs.RunState, MegaCrit.Sts2.Core.Entities.Players.Player, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, System.Collections.Generic.IReadOnlyDictionary<string, int>?, int)`](LeagueTeamMatch.cs.md#symbol-40715405ce22)；[`NationalSpire.LeagueNativeMatch.StartTeam(NationalSpire.Coop.CoopCoordinator, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>)`](LeagueTeamMatch.cs.md#symbol-81e11d18adc7)；[`NationalSpire.LeagueOpponent.MinInitialHp`](LeagueNativeMatch.cs.md#symbol-61f955e46c77)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3b4c257e5975"></a>

## `NationalSpire.LeagueLadder.RivalOpens(int) — internal static bool RivalOpens(int seed)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueMatch(NationalSpire.CareerData)`](LeagueArenaScreen.cs.md#symbol-c9e06b5e2f9d)；[`NationalSpire.LeagueNativeMatch.Start(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], int, NationalSpire.ICareerSession?, string, int, System.Collections.Generic.IReadOnlyDictionary<string, int>?, System.Collections.Generic.Dictionary<string, int>?, int, string?)`](LeagueNativeMatch.cs.md#symbol-5db2520de882)；[`NationalSpire.LeagueNativeMatch.StartFinal()`](ArchitectFinal.cs.md#symbol-bdca44c3d251)；[`NationalSpire.LeagueNativeMatch.StartTeam(NationalSpire.Coop.CoopCoordinator, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>)`](LeagueTeamMatch.cs.md#symbol-81e11d18adc7)

**调用：** `System.Random.Next(int)`；`System.Random.Random(int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Random.Next(int)`；输入表达式：`new Random(seed).Next(2)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Random(seed).Next(2)==1`
- `System.Random.Random(int)`；输入表达式：`new Random(seed)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new Random(seed).Next`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4009feb05261"></a>

## `NationalSpire.LeagueLadder.Match(NationalSpire.CareerData, System.Random, int?) — internal static (string Name,CharacterModel Role,int Tier,string Style) Match(CareerData d,Random rng,int? forTier=null)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueMatch(NationalSpire.CareerData)`](LeagueArenaScreen.cs.md#symbol-c9e06b5e2f9d)；[`NationalSpire.LeagueNativeMatch.StartTeam(NationalSpire.Coop.CoopCoordinator, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>)`](LeagueTeamMatch.cs.md#symbol-81e11d18adc7)

**调用：** [`NationalSpire.LeagueLadder.Tier(int)`](LeagueLadder.cs.md#symbol-b15a71b48f9a)；[`NationalSpire.NpcCharacters.Index(string)`](NpcCharacters.cs.md#symbol-8f7f43f17d89)；[`NationalSpire.WorldPeople.PlayingStyle(int, int)`](ExpandedPeople.cs.md#symbol-d239e2d11a5b)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Min<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Math.Abs(int)`；`System.Random.Next()`；`System.Random.Next(int)`

**字段、属性、事件及方法组引用：** `(NationalSpire.CareerPerson Person, MegaCrit.Sts2.Core.Models.CharacterModel Role, int Tier).Person`；`(NationalSpire.CareerPerson Person, MegaCrit.Sts2.Core.Models.CharacterModel Role, int Tier).Role`；`(NationalSpire.CareerPerson Person, MegaCrit.Sts2.Core.Models.CharacterModel Role, int Tier).Tier`；`(NationalSpire.CareerPerson Person, MegaCrit.Sts2.Core.Models.CharacterModel Role).Person`；`(NationalSpire.CareerPerson Person, MegaCrit.Sts2.Core.Models.CharacterModel Role).Role`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.People`；`NationalSpire.CareerLifeState.League`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerPerson.Style`；`NationalSpire.LeagueAlbum.Rating`；`NationalSpire.LeagueCards.OriginalRoles`；`NationalSpire.LeagueLadder.Tier(int)`；`NationalSpire.NpcCharacters.Index(string)`；`NationalSpire.WorldPeople.PlayingStyle(int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueLadder.Tier(int)`；输入表达式：`Tier(d.Life.League.Rating)`；返回值紧邻使用处：`BinaryExpressionSyntax: forTier??Tier(d.Life.League.Rating)`
- `NationalSpire.NpcCharacters.Index(string)`；输入表达式：`NpcCharacters.Index(p.Character)`；返回值紧邻使用处：`BinaryExpressionSyntax: NpcCharacters.Index(r.Id.Entry)==NpcCharacters.Index(p.Character)`
- `NationalSpire.NpcCharacters.Index(string)`；输入表达式：`NpcCharacters.Index(r.Id.Entry)`；返回值紧邻使用处：`BinaryExpressionSyntax: NpcCharacters.Index(r.Id.Entry)==NpcCharacters.Index(p.Character)`
- `NationalSpire.NpcCharacters.Index(string)`；输入表达式：`NpcCharacters.Index(role.Id.Entry)`；返回值紧邻使用处：`ArgumentSyntax: NpcCharacters.Index(role.Id.Entry)`
- `NationalSpire.WorldPeople.PlayingStyle(int, int)`；输入表达式：`WorldPeople.PlayingStyle(NpcCharacters.Index(role.Id.Entry),rng.Next())`；返回值紧邻使用处：`ArgumentSyntax: WorldPeople.PlayingStyle(NpcCharacters.Index(role.Id.Entry),rng.Next())`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`roles.FirstOrDefault(r=>NpcCharacters.Index(r.Id.Entry)==NpcCharacters.Index(p.Character))`；返回值紧邻使用处：`ArgumentSyntax: Role:roles.FirstOrDefault(r=>NpcCharacters.Index(r.Id.Entry)==NpcCharacters.Index(p.Character))`
- `System.Collections.Generic.IEnumerable<TSource>.Min<TSource>(System.Func<TSource, int>)`；输入表达式：`candidates.Min(x=>Math.Abs(x.Tier-tier))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =candidates.Min(x=>Math.Abs(x.Tier-tier))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.People.Select(p=>(Person:p,Role:roles.FirstOrDefault(r=>NpcCharacters.Index(r.Id.Entry)==NpcCharacters.Index(p.Character))))              .Where(x=>x.Role!=null).Select(x=>(x.Person,x.Role,Tier:tier==3&&x.Person.MaxAscension>=10?3:x.Person.MaxAscension>=9?2:x.Person.MaxAscension>=6?1:0))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Select(p=>(Person:p,Role:roles.FirstOrDefault(r=>NpcCharacters.Index(r.Id.Entry)==NpcCharacters.Index(p.Character))))              .Where(x=>x.Role!=null).Select(x=>(x.Person,x.Role,Tier:tier==3&&x.Person.MaxAscension>=10?3:x.Person.MaxAscension>=9?2:x.Person.MaxAscension>=6?1:0)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.People.Select(p=>(Person:p,Role:roles.FirstOrDefault(r=>NpcCharacters.Index(r.Id.Entry)==NpcCharacters.Index(p.Character))))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Select(p=>(Person:p,Role:roles.FirstOrDefault(r=>NpcCharacters.Index(r.Id.Entry)==NpcCharacters.Index(p.Character))))              .Where`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`candidates.Where(x=>Math.Abs(x.Tier-tier)==distance).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =candidates.Where(x=>Math.Abs(x.Tier-tier)==distance).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`d.People.Select(p=>(Person:p,Role:roles.FirstOrDefault(r=>NpcCharacters.Index(r.Id.Entry)==NpcCharacters.Index(p.Character))))              .Where(x=>x.Role!=null).Select(x=>(x.Person,x.Role,Tier:tier==3&&x.Person.MaxAscension>=10?3:x.Person.MaxAscension>=9?2:x.Person.MaxAscension>=6?1:0)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =d.People.Select(p=>(Person:p,Role:roles.FirstOrDefault(r=>NpcCharacters.Index(r.Id.Entry)==NpcCharacters.Index(p.Character))))              .Where(x=>x.Role!=null).Select(x=>(x.Person,x.Role,Tier:tier==3&&x.Person.MaxAscension>=10?3:x.Person.MaxAscension>=9?2:x.Person.MaxAscension>=6?1:0)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`candidates.Where(x=>Math.Abs(x.Tier-tier)==distance)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates.Where(x=>Math.Abs(x.Tier-tier)==distance).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Select(p=>(Person:p,Role:roles.FirstOrDefault(r=>NpcCharacters.Index(r.Id.Entry)==NpcCharacters.Index(p.Character))))              .Where(x=>x.Role!=null)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Select(p=>(Person:p,Role:roles.FirstOrDefault(r=>NpcCharacters.Index(r.Id.Entry)==NpcCharacters.Index(p.Character))))              .Where(x=>x.Role!=null).Select`
- `System.Math.Abs(int)`；输入表达式：`Math.Abs(x.Tier-tier)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Abs(x.Tier-tier)==distance`
- `System.Math.Abs(int)`；输入表达式：`Math.Abs(x.Tier-tier)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: x=>Math.Abs(x.Tier-tier)`
- `System.Random.Next()`；输入表达式：`rng.Next()`；返回值紧邻使用处：`ArgumentSyntax: rng.Next()`
- `System.Random.Next(int)`；输入表达式：`rng.Next(group.Length)`；返回值紧邻使用处：`ArgumentSyntax: rng.Next(group.Length)`
- `System.Random.Next(int)`；输入表达式：`rng.Next(roles.Length)`；返回值紧邻使用处：`ArgumentSyntax: rng.Next(roles.Length)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8988ba35b084"></a>

## `NationalSpire.LeagueLadder.UpgradePlan(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan, int, System.Random) — internal static Dictionary<string,int> UpgradePlan(CardModel[] cards,LeagueArchetypes.Plan plan,int tier,Random rng)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Begin()`](LeagueArenaScreen.cs.md#symbol-6efcffde32aa)；[`NationalSpire.LeagueNativeMatch.StartTeam(NationalSpire.Coop.CoopCoordinator, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>)`](LeagueTeamMatch.cs.md#symbol-81e11d18adc7)

**调用：** [`NationalSpire.LeagueLadder.Upgrades(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan, int, System.Random, bool)`](LeagueLadder.cs.md#symbol-1b55dcf28341)

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueLadder.Upgrades(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan, int, System.Random, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueLadder.Upgrades(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan, int, System.Random, bool)`；输入表达式：`Upgrades(cards,plan,tier,rng,false)`；返回值紧邻使用处：`ReturnStatementSyntax: return Upgrades(cards,plan,tier,rng,false);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1b55dcf28341"></a>

## `NationalSpire.LeagueLadder.Upgrades(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan, int, System.Random, bool) — internal static Dictionary<string,int> Upgrades(CardModel[] cards,LeagueArchetypes.Plan plan,int tier,Random rng,bool final)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueLadder.UpgradePlan(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan, int, System.Random)`](LeagueLadder.cs.md#symbol-8988ba35b084)；[`NationalSpire.LeagueNativeMatch.StartFinal()`](ArchitectFinal.cs.md#symbol-bdca44c3d251)

**调用：** [`NationalSpire.LeagueCards.UpgradeCost(NationalSpire.LeagueCards.Entry)`](LeagueCards.cs.md#symbol-ef07629a8beb)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Random.NextDouble()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueArchetypes.Plan.Anchors`；`NationalSpire.LeagueArchetypes.Plan.Partners`；`NationalSpire.LeagueCards.Catalog`；`NationalSpire.LeagueCards.UpgradeBudget`；`NationalSpire.LeagueCards.UpgradeCost(NationalSpire.LeagueCards.Entry)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueCards.UpgradeCost(NationalSpire.LeagueCards.Entry)`；输入表达式：`LeagueCards.UpgradeCost(LeagueCards.Catalog[id])`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueCards.UpgradeCost(LeagueCards.Catalog[id])`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string,int>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Dictionary<string,int>()`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`plan.Anchors.Contains(c.Id.Entry)`；返回值紧邻使用处：`ConditionalExpressionSyntax: plan.Anchors.Contains(c.Id.Entry)?2:plan.Partners.Contains(c.Id.Entry)?1:0`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`plan.Partners.Contains(c.Id.Entry)`；返回值紧邻使用处：`ConditionalExpressionSyntax: plan.Partners.Contains(c.Id.Entry)?1:0`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`cards.Where(c=>c.MaxUpgradeLevel>0).OrderByDescending(c=>(plan.Anchors.Contains(c.Id.Entry)?2:plan.Partners.Contains(c.Id.Entry)?1:0)+rng.NextDouble()*1.5)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var card in cards.Where(c=>c.MaxUpgradeLevel>0).OrderByDescending(c=>(plan.Anchors.Contains(c.Id.Entry)?2:plan.Partners.Contains(c.Id.Entry)?1:0)+rng.NextDouble()*1.5)){              var id=card.Id.Entry;int cost=LeagueCards.UpgradeCost(LeagueCards.Catalog[id]);if(cost>left)continue;              upgrades[id]=upgrades.GetValueOrDefault(id)+1;left-=cost;if(left==0)break;          }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`cards.Where(c=>c.MaxUpgradeLevel>0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: cards.Where(c=>c.MaxUpgradeLevel>0).OrderByDescending`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`upgrades.GetValueOrDefault(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: upgrades.GetValueOrDefault(id)+1`
- `System.Random.NextDouble()`；输入表达式：`rng.NextDouble()`；返回值紧邻使用处：`BinaryExpressionSyntax: rng.NextDouble()*1.5`

**赋值（含属性/字段和局部值）：**

- `left` -= `cost`
- `upgrades[id]` = `upgrades.GetValueOrDefault(id)+1`

<a id="symbol-a46e08a27495"></a>

## `NationalSpire.LeagueLadder.Build(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string) — internal static List<CardModel> Build(CharacterModel role,Random rng,int tier,string style)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Begin()`](LeagueArenaScreen.cs.md#symbol-6efcffde32aa)；[`NationalSpire.LeagueNativeMatch.StartTeam(NationalSpire.Coop.CoopCoordinator, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>)`](LeagueTeamMatch.cs.md#symbol-81e11d18adc7)

**调用：** [`NationalSpire.LeagueLadder.BuildFor(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string, bool)`](LeagueLadder.cs.md#symbol-005dadfed015)

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueLadder.BuildFor(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueLadder.BuildFor(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string, bool)`；输入表达式：`BuildFor(role,rng,tier,style,false)`；返回值紧邻使用处：`ReturnStatementSyntax: return BuildFor(role,rng,tier,style,false);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-005dadfed015"></a>

## `NationalSpire.LeagueLadder.BuildFor(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string, bool) — internal static List<CardModel> BuildFor(CharacterModel role,Random rng,int tier,string style,bool final)`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueLadder.Build(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string)`](LeagueLadder.cs.md#symbol-a46e08a27495)；[`NationalSpire.LeagueNativeMatch.StartFinal()`](ArchitectFinal.cs.md#symbol-bdca44c3d251)

**调用：** [`Add(NationalSpire.LeagueCards.Entry)`](LeagueLadder.cs.md#symbol-ef65a944f233)；[`Available(NationalSpire.LeagueCards.Entry)`](LeagueLadder.cs.md#symbol-ed055ebba372)；[`NationalSpire.GameCharacterNames.IsOriginal(System.Type)`](GameCharacterNames.cs.md#symbol-67e74be938f6)；[`NationalSpire.LeagueArchetypes.Enabled(string, System.Collections.Generic.Dictionary<string, int>)`](LeagueArchetypes.cs.md#symbol-0609e465e6ba)；[`NationalSpire.LeagueArchetypes.Resolve(string, string)`](LeagueArchetypes.cs.md#symbol-8cffe8f79fa2)；[`NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`](LeagueCards.cs.md#symbol-b5fd3c07325e)；[`Supply(System.Collections.Generic.HashSet<string>, int)`](LeagueLadder.cs.md#symbol-43af4e1a16e8)；`object.GetType()`；`string.Split(char, System.StringSplitOptions)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.List(int)`；`System.Enum.ToString()`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Random.Next()`；`System.Random.Next(int)`

**字段、属性、事件及方法组引用：** `Add(NationalSpire.LeagueCards.Entry)`；`Available(NationalSpire.LeagueCards.Entry)`；`NationalSpire.GameCharacterNames.IsOriginal(System.Type)`；`NationalSpire.LeagueArchetypes.Defense`；`NationalSpire.LeagueArchetypes.Enabled(string, System.Collections.Generic.Dictionary<string, int>)`；`NationalSpire.LeagueArchetypes.Engine.Draw`；`NationalSpire.LeagueArchetypes.Engine.Energy`；`NationalSpire.LeagueArchetypes.Engines`；`NationalSpire.LeagueArchetypes.Plan.Anchors`；`NationalSpire.LeagueArchetypes.Plan.Partners`；`NationalSpire.LeagueArchetypes.Resolve(string, string)`；`NationalSpire.LeagueCards.Catalog`；`NationalSpire.LeagueCards.DeckSize`；`NationalSpire.LeagueCards.Entry.Group`；`NationalSpire.LeagueCards.Entry.Id`；`NationalSpire.LeagueCards.Entry.Model`；`NationalSpire.LeagueCards.Entry.Tier`；`NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`；`Supply(System.Collections.Generic.HashSet<string>, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Add(NationalSpire.LeagueCards.Entry)`；输入表达式：`Add(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(c);`
- `Add(NationalSpire.LeagueCards.Entry)`；输入表达式：`Add(options[rng.Next(options.Length)])`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(options[rng.Next(options.Length)]);`
- `Add(NationalSpire.LeagueCards.Entry)`；输入表达式：`Add(pick)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(pick);`
- `Add(NationalSpire.LeagueCards.Entry)`；输入表达式：`Add(preferred[rng.Next(preferred.Length)])`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(preferred[rng.Next(preferred.Length)]);`
- `Available(NationalSpire.LeagueCards.Entry)`；输入表达式：`Available(c)`；返回值紧邻使用处：`IfStatementSyntax: if(Available(c))Add(c);`
- `NationalSpire.GameCharacterNames.IsOriginal(System.Type)`；输入表达式：`GameCharacterNames.IsOriginal(c.Model.GetType())`；返回值紧邻使用处：`BinaryExpressionSyntax: (c.Group==role.Id.Entry||c.Group=="COLORLESS")&&GameCharacterNames.IsOriginal(c.Model.GetType())`
- `NationalSpire.LeagueArchetypes.Enabled(string, System.Collections.Generic.Dictionary<string, int>)`；输入表达式：`LeagueArchetypes.Enabled(c.Id,deck)`；返回值紧邻使用处：`BinaryExpressionSyntax: tier>0&&(c.Id is "DARK_SHACKLES" or "HAND_OF_GREED" or "ETERNAL_ARMOR" or "GOLD_AXE"||engine.Draw.Contains(c.Id)||engine.Energy.Contains(c.Id))&&LeagueArchetypes.Enabled(c.Id,deck)`
- `NationalSpire.LeagueArchetypes.Resolve(string, string)`；输入表达式：`LeagueArchetypes.Resolve(role.Id.Entry,style)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueArchetypes.Resolve(role.Id.Entry,style)`
- `NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`；输入表达式：`LeagueCards.Fixed(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: i<LeagueCards.Fixed(c)`
- `NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`；输入表达式：`LeagueCards.Fixed(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: LeagueCards.Fixed(c)>0`
- `object.GetType()`；输入表达式：`c.Model.GetType()`；返回值紧邻使用处：`ArgumentSyntax: c.Model.GetType()`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`guards.Split(' ')`；返回值紧邻使用处：`MemberAccessExpressionSyntax: guards.Split(' ').ToHashSet`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`sustain.Split(' ')`；返回值紧邻使用处：`MemberAccessExpressionSyntax: sustain.Split(' ').ToHashSet`
- `Supply(System.Collections.Generic.HashSet<string>, int)`；输入表达式：`Supply(engine.Draw,1+2*tier)`；返回值紧邻使用处：`ExpressionStatementSyntax: Supply(engine.Draw,1+2*tier);`
- `Supply(System.Collections.Generic.HashSet<string>, int)`；输入表达式：`Supply(engine.Energy,tier==1?2:tier==2?3:5)`；返回值紧邻使用处：`ExpressionStatementSyntax: Supply(engine.Energy,tier==1?2:tier==2?3:5);`
- `Supply(System.Collections.Generic.HashSet<string>, int)`；输入表达式：`Supply(guards.Split(' ').ToHashSet(),tier+2)`；返回值紧邻使用处：`ExpressionStatementSyntax: Supply(guards.Split(' ').ToHashSet(),tier+2);`
- `Supply(System.Collections.Generic.HashSet<string>, int)`；输入表达式：`Supply(sustain.Split(' ').ToHashSet(),tier==1?1:2)`；返回值紧邻使用处：`ExpressionStatementSyntax: Supply(sustain.Split(' ').ToHashSet(),tier==1?1:2);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string,int>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Dictionary<string,int>()`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`engine.Draw.Contains(c.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Id is "DARK_SHACKLES" or "HAND_OF_GREED" or "ETERNAL_ARMOR" or "GOLD_AXE"||engine.Draw.Contains(c.Id)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`engine.Energy.Contains(c.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Id is "DARK_SHACKLES" or "HAND_OF_GREED" or "ETERNAL_ARMOR" or "GOLD_AXE"||engine.Draw.Contains(c.Id)||engine.Energy.Contains(c.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`core.Concat(support)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: core.Concat(support).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`core.Contains(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: core.Contains(c)||support.Contains(c)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`plan.Anchors.Contains("PUNCH_OF_JOY")`；返回值紧邻使用处：`BinaryExpressionSyntax: tier==0&&plan.Anchors.Contains("PUNCH_OF_JOY")`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`plan.Anchors.Contains(c.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c=>plan.Anchors.Contains(c.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`plan.Partners.Contains(c.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c=>plan.Partners.Contains(c.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`support.Contains(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: core.Contains(c)||support.Contains(c)`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`core.Concat(support).Where(c=>c.Tier<3).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: core.Concat(support).Where(c=>c.Tier<3).Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`ancient.OrderByDescending(c=>(c.Group=="COLORLESS")==shared).ThenByDescending(c=>core.Contains(c)||support.Contains(c)).ThenBy(_=>rng.Next()).FirstOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ancient.OrderByDescending(c=>(c.Group=="COLORLESS")==shared).ThenByDescending(c=>core.Contains(c)||support.Contains(c)).ThenBy(_=>rng.Next()).FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`ancient.OrderByDescending(c=>(c.Group=="COLORLESS")==shared)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ancient.OrderByDescending(c=>(c.Group=="COLORLESS")==shared).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`theme.Sum(c=>deck.GetValueOrDefault(c.Id))`；返回值紧邻使用处：`BinaryExpressionSyntax: theme.Sum(c=>deck.GetValueOrDefault(c.Id))<target`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`common.Where(c=>c.Group==role.Id.Entry||tier>0&&(c.Id is "DARK_SHACKLES" or "HAND_OF_GREED" or "ETERNAL_ARMOR" or "GOLD_AXE"||engine.Draw.Contains(c.Id)||engine.Energy.Contains(c.Id))&&LeagueArchetypes.Enabled(c.Id,deck)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =common.Where(c=>c.Group==role.Id.Entry||tier>0&&(c.Id is "DARK_SHACKLES" or "HAND_OF_GREED" or "ETERNAL_ARMOR" or "GOLD_AXE"||engine.Draw.Contains(c.Id)||engine.Energy.Contains(c.Id))&&LeagueArchetypes.Enabled(c.Id,deck)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`core.Concat(support).Where(c=>c.Tier<3).Distinct().ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =core.Concat(support).Where(c=>c.Tier<3).Distinct().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`fillers.Where(Available).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =fillers.Where(Available).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`LeagueCards.Catalog.Values.Where(c=>(c.Group==role.Id.Entry||c.Group=="COLORLESS")&&GameCharacterNames.IsOriginal(c.Model.GetType())&&c.Model.MultiplayerConstraint.ToString()!="MultiplayerOnly").ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueCards.Catalog.Values.Where(c=>(c.Group==role.Id.Entry||c.Group=="COLORLESS")&&GameCharacterNames.IsOriginal(c.Model.GetType())&&c.Model.MultiplayerConstraint.ToString()!="MultiplayerOnly").ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`options.Where(c=>c.Tier==grade).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =options.Where(c=>c.Tier==grade).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`pool.Where(c=>c.Tier<3).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =pool.Where(c=>c.Tier<3).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`pool.Where(c=>c.Tier==3).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =pool.Where(c=>c.Tier==3).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`pool.Where(c=>plan.Anchors.Contains(c.Id)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =pool.Where(c=>plan.Anchors.Contains(c.Id)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`pool.Where(c=>plan.Partners.Contains(c.Id)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =pool.Where(c=>plan.Partners.Contains(c.Id)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`theme.Where(Available).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =theme.Where(Available).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`guards.Split(' ').ToHashSet()`；返回值紧邻使用处：`ArgumentSyntax: guards.Split(' ').ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`sustain.Split(' ').ToHashSet()`；返回值紧邻使用处：`ArgumentSyntax: sustain.Split(' ').ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`common.Where(c=>c.Group==role.Id.Entry||tier>0&&(c.Id is "DARK_SHACKLES" or "HAND_OF_GREED" or "ETERNAL_ARMOR" or "GOLD_AXE"||engine.Draw.Contains(c.Id)||engine.Energy.Contains(c.Id))&&LeagueArchetypes.Enabled(c.Id,deck))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: common.Where(c=>c.Group==role.Id.Entry||tier>0&&(c.Id is "DARK_SHACKLES" or "HAND_OF_GREED" or "ETERNAL_ARMOR" or "GOLD_AXE"||engine.Draw.Contains(c.Id)||engine.Energy.Contains(c.Id))&&LeagueArchetypes.Enabled(c.Id,deck)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`core.Concat(support).Where(c=>c.Tier<3)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: core.Concat(support).Where(c=>c.Tier<3).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`core.Where(c=>c.Id is "JEST" or "PUNCH_OF_JOY")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var c in core.Where(c=>c.Id is "JEST" or "PUNCH_OF_JOY"))if(Available(c))Add(c);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`fillers.Where(Available)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: fillers.Where(Available).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`LeagueCards.Catalog.Values.Where(c=>(c.Group==role.Id.Entry||c.Group=="COLORLESS")&&GameCharacterNames.IsOriginal(c.Model.GetType())&&c.Model.MultiplayerConstraint.ToString()!="MultiplayerOnly")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LeagueCards.Catalog.Values.Where(c=>(c.Group==role.Id.Entry||c.Group=="COLORLESS")&&GameCharacterNames.IsOriginal(c.Model.GetType())&&c.Model.MultiplayerConstraint.ToString()!="MultiplayerOnly").ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`options.Where(c=>c.Tier==grade)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: options.Where(c=>c.Tier==grade).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`pool.Where(c=>c.Tier<3)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pool.Where(c=>c.Tier<3).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`pool.Where(c=>c.Tier==3)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pool.Where(c=>c.Tier==3).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`pool.Where(c=>LeagueCards.Fixed(c)>0)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var c in pool.Where(c=>LeagueCards.Fixed(c)>0))for(int i=0;i<LeagueCards.Fixed(c);i++)Add(c);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`pool.Where(c=>plan.Anchors.Contains(c.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pool.Where(c=>plan.Anchors.Contains(c.Id)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`pool.Where(c=>plan.Partners.Contains(c.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pool.Where(c=>plan.Partners.Contains(c.Id)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`theme.Where(Available)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: theme.Where(Available).ToArray`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`deck.GetValueOrDefault(c.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c=>deck.GetValueOrDefault(c.Id)`
- `System.Collections.Generic.List<T>.List(int)`；输入表达式：`new List<CardModel>(LeagueCards.DeckSize)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<CardModel>(LeagueCards.DeckSize)`
- `System.Enum.ToString()`；输入表达式：`c.Model.MultiplayerConstraint.ToString()`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Model.MultiplayerConstraint.ToString()!="MultiplayerOnly"`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`ancient.OrderByDescending(c=>(c.Group=="COLORLESS")==shared).ThenByDescending(c=>core.Contains(c)||support.Contains(c)).ThenBy(_=>rng.Next())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ancient.OrderByDescending(c=>(c.Group=="COLORLESS")==shared).ThenByDescending(c=>core.Contains(c)||support.Contains(c)).ThenBy(_=>rng.Next()).FirstOrDefault`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`ancient.OrderByDescending(c=>(c.Group=="COLORLESS")==shared).ThenByDescending(c=>core.Contains(c)||support.Contains(c))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ancient.OrderByDescending(c=>(c.Group=="COLORLESS")==shared).ThenByDescending(c=>core.Contains(c)||support.Contains(c)).ThenBy`
- `System.Random.Next()`；输入表达式：`rng.Next()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _=>rng.Next()`
- `System.Random.Next(int)`；输入表达式：`rng.Next(100)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =rng.Next(100)`
- `System.Random.Next(int)`；输入表达式：`rng.Next(2)`；返回值紧邻使用处：`BinaryExpressionSyntax: rng.Next(2)==0`
- `System.Random.Next(int)`；输入表达式：`rng.Next(3)`；返回值紧邻使用处：`BinaryExpressionSyntax: 21+rng.Next(3)`
- `System.Random.Next(int)`；输入表达式：`rng.Next(4)`；返回值紧邻使用处：`BinaryExpressionSyntax: (final?18:21)+rng.Next(4)`
- `System.Random.Next(int)`；输入表达式：`rng.Next(4)`；返回值紧邻使用处：`BinaryExpressionSyntax: 15+rng.Next(4)`
- `System.Random.Next(int)`；输入表达式：`rng.Next(4)`；返回值紧邻使用处：`BinaryExpressionSyntax: 5+rng.Next(4)`
- `System.Random.Next(int)`；输入表达式：`rng.Next(4)`；返回值紧邻使用处：`BinaryExpressionSyntax: rng.Next(4)==0`
- `System.Random.Next(int)`；输入表达式：`rng.Next(options.Length)`；返回值紧邻使用处：`ArgumentSyntax: rng.Next(options.Length)`
- `System.Random.Next(int)`；输入表达式：`rng.Next(preferred.Length)`；返回值紧邻使用处：`ArgumentSyntax: rng.Next(preferred.Length)`

**赋值（含属性/字段和局部值）：**

- `preferred` = `options`
- `var (guards,sustain)` = `LeagueArchetypes.Defense[role.Id.Entry]`

<a id="symbol-ef65a944f233"></a>

## `Add(NationalSpire.LeagueCards.Entry) — void Add(LeagueCards.Entry c)`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueLadder.BuildFor(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string, bool)`](LeagueLadder.cs.md#symbol-005dadfed015)；[`Supply(System.Collections.Generic.HashSet<string>, int)`](LeagueLadder.cs.md#symbol-43af4e1a16e8)

**调用：** `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueCards.Entry.Group`；`NationalSpire.LeagueCards.Entry.Id`；`NationalSpire.LeagueCards.Entry.Model`；`NationalSpire.LeagueCards.Entry.Tier`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`deck.GetValueOrDefault(c.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: deck.GetValueOrDefault(c.Id)+1`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.Add(c.Model)`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Add(c.Model);`

**赋值（含属性/字段和局部值）：**

- `deck[c.Id]` = `deck.GetValueOrDefault(c.Id)+1`

<a id="symbol-ed055ebba372"></a>

## `Available(NationalSpire.LeagueCards.Entry) — bool Available(LeagueCards.Entry c)`

来源：源码第 42 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueLadder.BuildFor(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string, bool)`](LeagueLadder.cs.md#symbol-005dadfed015)；[`Supply(System.Collections.Generic.HashSet<string>, int)`](LeagueLadder.cs.md#symbol-43af4e1a16e8)

**调用：** [`NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`](LeagueCards.cs.md#symbol-b5fd3c07325e)；`System.Collections.Generic.IEnumerable<int>.Sum()`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueCards.DeckSize`；`NationalSpire.LeagueCards.Entry.Group`；`NationalSpire.LeagueCards.Entry.Id`；`NationalSpire.LeagueCards.Entry.Tier`；`NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`；`NationalSpire.LeagueCards.NeutralLimit`；`NationalSpire.LeagueCards.RarityLimits`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`；输入表达式：`LeagueCards.Fixed(c)`；返回值紧邻使用处：`ArgumentSyntax: LeagueCards.Fixed(c)`
- `System.Collections.Generic.IEnumerable<int>.Sum()`；输入表达式：`LeagueCards.RarityLimits.Skip(1).Sum()`；返回值紧邻使用处：`BinaryExpressionSyntax: LeagueCards.DeckSize-LeagueCards.RarityLimits.Skip(1).Sum()`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`LeagueCards.RarityLimits.Skip(1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LeagueCards.RarityLimits.Skip(1).Sum`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`deck.GetValueOrDefault(c.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: deck.GetValueOrDefault(c.Id)<Math.Max(2,LeagueCards.Fixed(c))`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(2,LeagueCards.Fixed(c))`；返回值紧邻使用处：`BinaryExpressionSyntax: deck.GetValueOrDefault(c.Id)<Math.Max(2,LeagueCards.Fixed(c))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-43af4e1a16e8"></a>

## `Supply(System.Collections.Generic.HashSet<string>, int) — void Supply(HashSet<string> tools,int target)`

来源：源码第 61 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueLadder.BuildFor(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string, bool)`](LeagueLadder.cs.md#symbol-005dadfed015)

**调用：** [`Add(NationalSpire.LeagueCards.Entry)`](LeagueLadder.cs.md#symbol-ef65a944f233)；[`Available(NationalSpire.LeagueCards.Entry)`](LeagueLadder.cs.md#symbol-ed055ebba372)；[`NationalSpire.LeagueArchetypes.Enabled(string, System.Collections.Generic.Dictionary<string, int>)`](LeagueArchetypes.cs.md#symbol-0609e465e6ba)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.MaxBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Random.NextDouble()`

**字段、属性、事件及方法组引用：** `Add(NationalSpire.LeagueCards.Entry)`；`Available(NationalSpire.LeagueCards.Entry)`；`NationalSpire.LeagueArchetypes.Enabled(string, System.Collections.Generic.Dictionary<string, int>)`；`NationalSpire.LeagueCards.Entry.Group`；`NationalSpire.LeagueCards.Entry.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Add(NationalSpire.LeagueCards.Entry)`；输入表达式：`Add(options.MaxBy(c=>(theme.Contains(c)?1.1:0)+(c.Group==role.Id.Entry?.4:0)+rng.NextDouble()*2)!)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(options.MaxBy(c=>(theme.Contains(c)?1.1:0)+(c.Group==role.Id.Entry?.4:0)+rng.NextDouble()*2)!);`
- `Available(NationalSpire.LeagueCards.Entry)`；输入表达式：`Available(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: tools.Contains(c.Id)&&LeagueArchetypes.Enabled(c.Id,deck)&&Available(c)`
- `NationalSpire.LeagueArchetypes.Enabled(string, System.Collections.Generic.Dictionary<string, int>)`；输入表达式：`LeagueArchetypes.Enabled(c.Id,deck)`；返回值紧邻使用处：`BinaryExpressionSyntax: tools.Contains(c.Id)&&LeagueArchetypes.Enabled(c.Id,deck)`
- `NationalSpire.LeagueArchetypes.Enabled(string, System.Collections.Generic.Dictionary<string, int>)`；输入表达式：`LeagueArchetypes.Enabled(p.Key,deck)`；返回值紧邻使用处：`BinaryExpressionSyntax: tools.Contains(p.Key)&&LeagueArchetypes.Enabled(p.Key,deck)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`tools.Contains(c.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: tools.Contains(c.Id)&&LeagueArchetypes.Enabled(c.Id,deck)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`tools.Contains(p.Key)`；返回值紧邻使用处：`BinaryExpressionSyntax: tools.Contains(p.Key)&&LeagueArchetypes.Enabled(p.Key,deck)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`theme.Contains(c)`；返回值紧邻使用处：`ConditionalExpressionSyntax: theme.Contains(c)?1.1:0`
- `System.Collections.Generic.IEnumerable<TSource>.MaxBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`options.MaxBy(c=>(theme.Contains(c)?1.1:0)+(c.Group==role.Id.Entry?.4:0)+rng.NextDouble()*2)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: options.MaxBy(c=>(theme.Contains(c)?1.1:0)+(c.Group==role.Id.Entry?.4:0)+rng.NextDouble()*2)!`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`deck.Where(p=>tools.Contains(p.Key)&&LeagueArchetypes.Enabled(p.Key,deck)).Sum(p=>p.Value)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =deck.Where(p=>tools.Contains(p.Key)&&LeagueArchetypes.Enabled(p.Key,deck)).Sum(p=>p.Value)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`common.Where(c=>tools.Contains(c.Id)&&LeagueArchetypes.Enabled(c.Id,deck)&&Available(c)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =common.Where(c=>tools.Contains(c.Id)&&LeagueArchetypes.Enabled(c.Id,deck)&&Available(c)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`common.Where(c=>tools.Contains(c.Id)&&LeagueArchetypes.Enabled(c.Id,deck)&&Available(c))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: common.Where(c=>tools.Contains(c.Id)&&LeagueArchetypes.Enabled(c.Id,deck)&&Available(c)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`deck.Where(p=>tools.Contains(p.Key)&&LeagueArchetypes.Enabled(p.Key,deck))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: deck.Where(p=>tools.Contains(p.Key)&&LeagueArchetypes.Enabled(p.Key,deck)).Sum`
- `System.Random.NextDouble()`；输入表达式：`rng.NextDouble()`；返回值紧邻使用处：`BinaryExpressionSyntax: rng.NextDouble()*2`

**赋值（含属性/字段和局部值）：**
