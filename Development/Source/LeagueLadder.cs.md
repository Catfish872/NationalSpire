# LeagueLadder.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`56F9A328FB1A439CFCFAE05A0399514CA247EDB34A6AF434FEDEFB1942CBE3A3`。来源：[源码](../../LeagueLadder.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LeagueLadder`、`NationalSpire.LeagueLadder.Draw`。

字段、事件及初始值（源码原样）：

```csharp
internal static readonly string[] Names=["新秀","精英","大师","传奇"];
internal static readonly int[] Thresholds=[0,160,480,960];
internal readonly Dictionary<string,CareerPerson> People=world.People.ToDictionary(p=>p.Id);
internal readonly Dictionary<string,CharacterModel> Roles=LeagueCards.OriginalRoles.ToDictionary(r=>r.Id.Entry);
internal readonly HashSet<string> UsedPeople=[];
internal readonly HashSet<(string,string)> UsedPlans=[];
```

<a id="symbol-b15a71b48f9a"></a>

## `NationalSpire.LeagueLadder.Tier(int) — internal static int Tier(int points)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Begin()`](LeagueArenaScreen.cs.md#symbol-8456a000aa0c)；[`NationalSpire.CareerScreen.LeagueArena(NationalSpire.CareerData)`](LeagueArenaScreen.cs.md#symbol-59be112523d9)；[`NationalSpire.CareerScreen.LeagueMatch(NationalSpire.CareerData, NationalSpire.CareerMatch?)`](LeagueArenaScreen.cs.md#symbol-601c9785c32a)；[`NationalSpire.CareerScreen.LeagueScore(NationalSpire.LeagueReceipt)`](LeagueArenaScreen.cs.md#symbol-bd915636fa04)；[`NationalSpire.Coop.CoopRules.FinishLeagueTeam(NationalSpire.Coop.CoopCoordinator, string, bool?, NationalSpire.DuelReport?)`](Coop/CoopRules.cs.md#symbol-32aed8cb856a)；[`NationalSpire.LeagueNativeMatch.StartTeam(NationalSpire.Coop.CoopCoordinator, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>)`](LeagueTeamMatch.cs.md#symbol-81e11d18adc7)

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

**调用者：** [`NationalSpire.CareerScreen.LeagueMatch(NationalSpire.CareerData, NationalSpire.CareerMatch?)`](LeagueArenaScreen.cs.md#symbol-601c9785c32a)；[`NationalSpire.LeagueNativeMatch.StartFinal()`](ArchitectFinal.cs.md#symbol-bdca44c3d251)；[`NationalSpire.LeagueNativeMatch.StartMirror(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], int, NationalSpire.ICareerSession?, string, int, System.Collections.Generic.IReadOnlyDictionary<string, int>?, System.Collections.Generic.Dictionary<string, int>?, int, string?, string?, string?)`](LeagueNativeMatch.cs.md#symbol-a60b957088cc)；[`NationalSpire.LeagueNativeMatch.StartTeam(NationalSpire.Coop.CoopCoordinator, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>)`](LeagueTeamMatch.cs.md#symbol-81e11d18adc7)

**调用：** `System.Random.Next(int)`；`System.Random.Random(int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Random.Next(int)`；输入表达式：`new Random(seed).Next(2)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Random(seed).Next(2)==1`
- `System.Random.Random(int)`；输入表达式：`new Random(seed)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new Random(seed).Next`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fc32b34df886"></a>

## `NationalSpire.LeagueLadder.PrepareRoster(NationalSpire.CareerData) — internal static bool PrepareRoster(CareerData world)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueMatch(NationalSpire.CareerData, NationalSpire.CareerMatch?)`](LeagueArenaScreen.cs.md#symbol-601c9785c32a)；[`NationalSpire.Coop.CoopRules.PrepareMirror(NationalSpire.Coop.CoopWorld, System.Collections.Generic.IReadOnlySet<ulong>, NationalSpire.CareerMatch?)`](Coop/CoopRules.cs.md#symbol-616076122cda)；[`NationalSpire.LeagueNativeMatch.StartTeam(NationalSpire.Coop.CoopCoordinator, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>)`](LeagueTeamMatch.cs.md#symbol-81e11d18adc7)

**调用：** [`NationalSpire.LeagueSeasonRoster.Prepare(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>)`](LeagueSeasonRoster.cs.md#symbol-b1e9bbf26da3)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.LeagueRoster`；`NationalSpire.CareerData.Season`；`NationalSpire.LeagueCards.OriginalRoles`；`NationalSpire.LeagueSeasonRoster.Prepare(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>)`；`NationalSpire.LeagueSeasonRoster.Season`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueSeasonRoster.Prepare(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>)`；输入表达式：`LeagueSeasonRoster.Prepare(world,LeagueCards.OriginalRoles.Select(r=>r.Id.Entry).ToArray())`；返回值紧邻使用处：`BinaryExpressionSyntax: world.LeagueRoster?.Season!=world.Season&&          LeagueSeasonRoster.Prepare(world,LeagueCards.OriginalRoles.Select(r=>r.Id.Entry).ToArray())`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`LeagueCards.OriginalRoles.Select(r=>r.Id.Entry)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LeagueCards.OriginalRoles.Select(r=>r.Id.Entry).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`LeagueCards.OriginalRoles.Select(r=>r.Id.Entry).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: LeagueCards.OriginalRoles.Select(r=>r.Id.Entry).ToArray()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5aa41a3b4644"></a>

## `NationalSpire.LeagueLadder.Match(NationalSpire.LeagueSeasonRoster, NationalSpire.LeagueLadder.Draw, System.Random, int) — internal static (string Name,CharacterModel Role,int Tier,string Style,string? PersonId) Match(LeagueSeasonRoster roster,Draw draw,Random rng,int tier)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueMatch(NationalSpire.CareerData, NationalSpire.CareerMatch?)`](LeagueArenaScreen.cs.md#symbol-601c9785c32a)；[`NationalSpire.LeagueNativeMatch.StartTeam(NationalSpire.Coop.CoopCoordinator, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>)`](LeagueTeamMatch.cs.md#symbol-81e11d18adc7)

**调用：** [`NationalSpire.NpcCharacters.Index(string)`](NpcCharacters.cs.md#symbol-8f7f43f17d89)；[`NationalSpire.WorldPeople.PlayingStyle(int, int)`](ExpandedPeople.cs.md#symbol-d239e2d11a5b)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Random.Next()`；`System.Random.Next(int)`

**字段、属性、事件及方法组引用：** `(string Role, string Plan, string Style, string Id).Id`；`(string Role, string Plan, string Style, string Id).Plan`；`(string Role, string Plan, string Style, string Id).Role`；`(string Role, string Plan, string Style, string Id).Style`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.LeagueBracket.Plan`；`NationalSpire.LeagueBracket.Role`；`NationalSpire.LeagueBracket.Styles`；`NationalSpire.LeagueBracket.Tier`；`NationalSpire.LeagueLadder.Draw.People`；`NationalSpire.LeagueLadder.Draw.Roles`；`NationalSpire.LeagueLadder.Draw.UsedPeople`；`NationalSpire.LeagueLadder.Draw.UsedPlans`；`NationalSpire.LeagueSeasonRoster.Brackets`；`NationalSpire.NpcCharacters.Index(string)`；`NationalSpire.WorldPeople.PlayingStyle(int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.NpcCharacters.Index(string)`；输入表达式：`NpcCharacters.Index(role.Id.Entry)`；返回值紧邻使用处：`ArgumentSyntax: NpcCharacters.Index(role.Id.Entry)`
- `NationalSpire.WorldPeople.PlayingStyle(int, int)`；输入表达式：`WorldPeople.PlayingStyle(NpcCharacters.Index(role.Id.Entry),rng.Next())`；返回值紧邻使用处：`ArgumentSyntax: WorldPeople.PlayingStyle(NpcCharacters.Index(role.Id.Entry),rng.Next())`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`draw.Roles.ContainsKey(b.Role)`；返回值紧邻使用处：`BinaryExpressionSyntax: b.Tier==tier&&draw.Roles.ContainsKey(b.Role)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`draw.UsedPeople.Add(pick.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: draw.UsedPeople.Add(pick.Id);`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`draw.UsedPlans.Add((pick.Role,pick.Plan))`；返回值紧邻使用处：`ExpressionStatementSyntax: draw.UsedPlans.Add((pick.Role,pick.Plan));`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`draw.UsedPeople.Contains(x.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !draw.UsedPeople.Contains(x.Id)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`draw.UsedPlans.Contains((x.Role,x.Plan))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !draw.UsedPlans.Contains((x.Role,x.Plan))`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`(fresh.Length==0?people:fresh).GroupBy(x=>x.Role)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (fresh.Length==0?people:fresh).GroupBy(x=>x.Role).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`rolesInTier[rng.Next(rolesInTier.Length)].GroupBy(x=>x.Plan)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: rolesInTier[rng.Next(rolesInTier.Length)].GroupBy(x=>x.Plan).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`draw.Roles.Values.OrderBy(r=>r.Id.Entry,StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: draw.Roles.Values.OrderBy(r=>r.Id.Entry,StringComparer.Ordinal).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`s.Value.Where(draw.People.ContainsKey).Select(id=>(b.Role,b.Plan,Style:s.Key,Id:id))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: s=>s.Value.Where(draw.People.ContainsKey).Select(id=>(b.Role,b.Plan,Style:s.Key,Id:id))`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`b.Styles.SelectMany(s=>s.Value.Where(draw.People.ContainsKey).Select(id=>(b.Role,b.Plan,Style:s.Key,Id:id)))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: b=>b.Styles.SelectMany(s=>s.Value.Where(draw.People.ContainsKey).Select(id=>(b.Role,b.Plan,Style:s.Key,Id:id)))`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`roster.Brackets.Where(b=>b.Tier==tier&&draw.Roles.ContainsKey(b.Role))              .SelectMany(b=>b.Styles.SelectMany(s=>s.Value.Where(draw.People.ContainsKey).Select(id=>(b.Role,b.Plan,Style:s.Key,Id:id))))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: roster.Brackets.Where(b=>b.Tier==tier&&draw.Roles.ContainsKey(b.Role))              .SelectMany(b=>b.Styles.SelectMany(s=>s.Value.Where(draw.People.ContainsKey).Select(id=>(b.Role,b.Plan,Style:s.Key,Id:id)))).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`(fresh.Length==0?people:fresh).GroupBy(x=>x.Role).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =(fresh.Length==0?people:fresh).GroupBy(x=>x.Role).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`available.Where(x=>!draw.UsedPeople.Contains(x.Id)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =available.Where(x=>!draw.UsedPeople.Contains(x.Id)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`draw.Roles.Values.OrderBy(r=>r.Id.Entry,StringComparer.Ordinal).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =draw.Roles.Values.OrderBy(r=>r.Id.Entry,StringComparer.Ordinal).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`people.Where(x=>!draw.UsedPlans.Contains((x.Role,x.Plan))).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =people.Where(x=>!draw.UsedPlans.Contains((x.Role,x.Plan))).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`plans[rng.Next(plans.Length)].ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =plans[rng.Next(plans.Length)].ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`rolesInTier[rng.Next(rolesInTier.Length)].GroupBy(x=>x.Plan).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =rolesInTier[rng.Next(rolesInTier.Length)].GroupBy(x=>x.Plan).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`roster.Brackets.Where(b=>b.Tier==tier&&draw.Roles.ContainsKey(b.Role))              .SelectMany(b=>b.Styles.SelectMany(s=>s.Value.Where(draw.People.ContainsKey).Select(id=>(b.Role,b.Plan,Style:s.Key,Id:id)))).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =roster.Brackets.Where(b=>b.Tier==tier&&draw.Roles.ContainsKey(b.Role))              .SelectMany(b=>b.Styles.SelectMany(s=>s.Value.Where(draw.People.ContainsKey).Select(id=>(b.Role,b.Plan,Style:s.Key,Id:id)))).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`available.Where(x=>!draw.UsedPeople.Contains(x.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: available.Where(x=>!draw.UsedPeople.Contains(x.Id)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`people.Where(x=>!draw.UsedPlans.Contains((x.Role,x.Plan)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: people.Where(x=>!draw.UsedPlans.Contains((x.Role,x.Plan))).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`roster.Brackets.Where(b=>b.Tier==tier&&draw.Roles.ContainsKey(b.Role))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: roster.Brackets.Where(b=>b.Tier==tier&&draw.Roles.ContainsKey(b.Role))              .SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`s.Value.Where(draw.People.ContainsKey)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: s.Value.Where(draw.People.ContainsKey).Select`
- `System.Random.Next()`；输入表达式：`rng.Next()`；返回值紧邻使用处：`ArgumentSyntax: rng.Next()`
- `System.Random.Next(int)`；输入表达式：`rng.Next(plans.Length)`；返回值紧邻使用处：`ArgumentSyntax: rng.Next(plans.Length)`
- `System.Random.Next(int)`；输入表达式：`rng.Next(players.Length)`；返回值紧邻使用处：`ArgumentSyntax: rng.Next(players.Length)`
- `System.Random.Next(int)`；输入表达式：`rng.Next(roles.Length)`；返回值紧邻使用处：`ArgumentSyntax: rng.Next(roles.Length)`
- `System.Random.Next(int)`；输入表达式：`rng.Next(rolesInTier.Length)`；返回值紧邻使用处：`ArgumentSyntax: rng.Next(rolesInTier.Length)`

**赋值（含属性/字段和局部值）：**

- `people` = `available`

<a id="symbol-9dbd4f842c20"></a>

## `NationalSpire.LeagueLadder.Invited(NationalSpire.LeagueSeasonRoster, NationalSpire.LeagueLadder.Draw, string) — internal static (string Name,CharacterModel Role,int Tier,string Style,string? PersonId)? Invited(LeagueSeasonRoster roster,Draw draw,string personId)`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LeagueMatch(NationalSpire.CareerData, NationalSpire.CareerMatch?)`](LeagueArenaScreen.cs.md#symbol-601c9785c32a)；[`NationalSpire.Coop.CoopRules.PrepareMirror(NationalSpire.Coop.CoopWorld, System.Collections.Generic.IReadOnlySet<ulong>, NationalSpire.CareerMatch?)`](Coop/CoopRules.cs.md#symbol-616076122cda)；[`NationalSpire.LeagueNativeMatch.StartTeam(NationalSpire.Coop.CoopCoordinator, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>)`](LeagueTeamMatch.cs.md#symbol-81e11d18adc7)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.PublicName`；`NationalSpire.LeagueBracket.Plan`；`NationalSpire.LeagueBracket.Role`；`NationalSpire.LeagueBracket.Styles`；`NationalSpire.LeagueBracket.Tier`；`NationalSpire.LeagueLadder.Draw.People`；`NationalSpire.LeagueLadder.Draw.Roles`；`NationalSpire.LeagueLadder.Draw.UsedPeople`；`NationalSpire.LeagueLadder.Draw.UsedPlans`；`NationalSpire.LeagueSeasonRoster.Brackets`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`draw.People.TryGetValue(personId,out var person)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !draw.People.TryGetValue(personId,out var person)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`draw.Roles.TryGetValue(bracket.Role,out var role)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !draw.Roles.TryGetValue(bracket.Role,out var role)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`draw.UsedPeople.Add(personId)`；返回值紧邻使用处：`ExpressionStatementSyntax: draw.UsedPeople.Add(personId);`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`draw.UsedPlans.Add((bracket.Role,bracket.Plan))`；返回值紧邻使用处：`ExpressionStatementSyntax: draw.UsedPlans.Add((bracket.Role,bracket.Plan));`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`s.Value.Contains(personId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: s=>s.Value.Contains(personId)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`bracket.Styles.Where(s=>s.Value.Contains(personId))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var style in bracket.Styles.Where(s=>s.Value.Contains(personId))){                  draw.UsedPeople.Add(personId);draw.UsedPlans.Add((bracket.Role,bracket.Plan));                  return (person.PublicName,role,bracket.Tier,style.Key,personId);              }`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8988ba35b084"></a>

## `NationalSpire.LeagueLadder.UpgradePlan(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan, int, System.Random) — internal static Dictionary<string,int> UpgradePlan(CardModel[] cards,LeagueArchetypes.Plan plan,int tier,Random rng)`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Begin()`](LeagueArenaScreen.cs.md#symbol-8456a000aa0c)；[`NationalSpire.LeagueNativeMatch.StartTeam(NationalSpire.Coop.CoopCoordinator, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>)`](LeagueTeamMatch.cs.md#symbol-81e11d18adc7)

**调用：** [`NationalSpire.LeagueLadder.Upgrades(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan, int, System.Random, bool)`](LeagueLadder.cs.md#symbol-1b55dcf28341)

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueLadder.Upgrades(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan, int, System.Random, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueLadder.Upgrades(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan, int, System.Random, bool)`；输入表达式：`Upgrades(cards,plan,tier,rng,false)`；返回值紧邻使用处：`ReturnStatementSyntax: return Upgrades(cards,plan,tier,rng,false);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-411d383d97fe"></a>

## `NationalSpire.LeagueLadder.ConstructionTier(int, bool) — private static int ConstructionTier(int tier,bool final)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueLadder.BuildFor(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string, bool)`](LeagueLadder.cs.md#symbol-005dadfed015)；[`NationalSpire.LeagueLadder.Upgrades(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan, int, System.Random, bool)`](LeagueLadder.cs.md#symbol-1b55dcf28341)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1b55dcf28341"></a>

## `NationalSpire.LeagueLadder.Upgrades(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan, int, System.Random, bool) — internal static Dictionary<string,int> Upgrades(CardModel[] cards,LeagueArchetypes.Plan plan,int tier,Random rng,bool final)`

来源：源码第 53 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueLadder.UpgradePlan(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan, int, System.Random)`](LeagueLadder.cs.md#symbol-8988ba35b084)；[`NationalSpire.LeagueNativeMatch.StartFinal()`](ArchitectFinal.cs.md#symbol-bdca44c3d251)

**调用：** [`NationalSpire.LeagueCards.UpgradeCost(NationalSpire.LeagueCards.Entry)`](LeagueCards.cs.md#symbol-ef07629a8beb)；[`NationalSpire.LeagueLadder.ConstructionTier(int, bool)`](LeagueLadder.cs.md#symbol-411d383d97fe)；[`NationalSpire.LeagueLegendDraft.ForgeOrder(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan)`](LeagueLegendDraft.cs.md#symbol-33b903b8097f)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Random.NextDouble()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueArchetypes.Plan.Anchors`；`NationalSpire.LeagueArchetypes.Plan.Partners`；`NationalSpire.LeagueCards.Catalog`；`NationalSpire.LeagueCards.UpgradeBudget`；`NationalSpire.LeagueCards.UpgradeCost(NationalSpire.LeagueCards.Entry)`；`NationalSpire.LeagueLadder.ConstructionTier(int, bool)`；`NationalSpire.LeagueLegendDraft.ForgeOrder(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueCards.UpgradeCost(NationalSpire.LeagueCards.Entry)`；输入表达式：`LeagueCards.UpgradeCost(LeagueCards.Catalog[id])`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueCards.UpgradeCost(LeagueCards.Catalog[id])`
- `NationalSpire.LeagueLadder.ConstructionTier(int, bool)`；输入表达式：`ConstructionTier(tier,final)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ConstructionTier(tier,final)`
- `NationalSpire.LeagueLegendDraft.ForgeOrder(MegaCrit.Sts2.Core.Models.CardModel[], NationalSpire.LeagueArchetypes.Plan)`；输入表达式：`LeagueLegendDraft.ForgeOrder(cards,plan)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LeagueLegendDraft.ForgeOrder(cards,plan).Concat`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string,int>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Dictionary<string,int>()`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`LeagueLegendDraft.ForgeOrder(cards,plan).Concat(candidates)`；返回值紧邻使用处：`AssignmentExpressionSyntax: candidates=LeagueLegendDraft.ForgeOrder(cards,plan).Concat(candidates)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`plan.Anchors.Contains(c.Id.Entry)`；返回值紧邻使用处：`ConditionalExpressionSyntax: plan.Anchors.Contains(c.Id.Entry)?2:plan.Partners.Contains(c.Id.Entry)?1:0`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`plan.Partners.Contains(c.Id.Entry)`；返回值紧邻使用处：`ConditionalExpressionSyntax: plan.Partners.Contains(c.Id.Entry)?1:0`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`g.Count()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g=>g.Count()`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`cards.GroupBy(c=>c.Id.Entry)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: cards.GroupBy(c=>c.Id.Entry).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`cards.Where(c=>c.MaxUpgradeLevel>0).OrderByDescending(c=>(plan.Anchors.Contains(c.Id.Entry)?2:plan.Partners.Contains(c.Id.Entry)?1:0)+rng.NextDouble()*1.5)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =cards.Where(c=>c.MaxUpgradeLevel>0).OrderByDescending(c=>(plan.Anchors.Contains(c.Id.Entry)?2:plan.Partners.Contains(c.Id.Entry)?1:0)+rng.NextDouble()*1.5)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`cards.GroupBy(c=>c.Id.Entry).ToDictionary(g=>g.Key,g=>g.Count())`；返回值紧邻使用处：`AssignmentExpressionSyntax: copies=cards.GroupBy(c=>c.Id.Entry).ToDictionary(g=>g.Key,g=>g.Count())`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`cards.Where(c=>c.MaxUpgradeLevel>0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: cards.Where(c=>c.MaxUpgradeLevel>0).OrderByDescending`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`upgrades.GetValueOrDefault(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: upgrades.GetValueOrDefault(id)+1`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`upgrades.GetValueOrDefault(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: upgrades.GetValueOrDefault(id)>=copies[id]`
- `System.Random.NextDouble()`；输入表达式：`rng.NextDouble()`；返回值紧邻使用处：`BinaryExpressionSyntax: rng.NextDouble()*1.5`

**赋值（含属性/字段和局部值）：**

- `candidates` = `LeagueLegendDraft.ForgeOrder(cards,plan).Concat(candidates)`
- `copies` = `cards.GroupBy(c=>c.Id.Entry).ToDictionary(g=>g.Key,g=>g.Count())`
- `left` -= `cost`
- `upgrades[id]` = `upgrades.GetValueOrDefault(id)+1`

<a id="symbol-a46e08a27495"></a>

## `NationalSpire.LeagueLadder.Build(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string) — internal static List<CardModel> Build(CharacterModel role,Random rng,int tier,string style)`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Begin()`](LeagueArenaScreen.cs.md#symbol-8456a000aa0c)；[`NationalSpire.LeagueNativeMatch.StartTeam(NationalSpire.Coop.CoopCoordinator, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>)`](LeagueTeamMatch.cs.md#symbol-81e11d18adc7)

**调用：** [`NationalSpire.LeagueLadder.BuildFor(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string, bool)`](LeagueLadder.cs.md#symbol-005dadfed015)

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueLadder.BuildFor(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueLadder.BuildFor(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string, bool)`；输入表达式：`BuildFor(role,rng,tier,style,false)`；返回值紧邻使用处：`ReturnStatementSyntax: return BuildFor(role,rng,tier,style,false);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-005dadfed015"></a>

## `NationalSpire.LeagueLadder.BuildFor(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string, bool) — internal static List<CardModel> BuildFor(CharacterModel role,Random rng,int tier,string style,bool final)`

来源：源码第 71 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueLadder.Build(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string)`](LeagueLadder.cs.md#symbol-a46e08a27495)；[`NationalSpire.LeagueNativeMatch.StartFinal()`](ArchitectFinal.cs.md#symbol-bdca44c3d251)

**调用：** [`Add(NationalSpire.LeagueCards.Entry)`](LeagueLadder.cs.md#symbol-899debc8b5b3)；[`Available(NationalSpire.LeagueCards.Entry)`](LeagueLadder.cs.md#symbol-dc858d2fe947)；[`NationalSpire.GameCharacterNames.IsOriginal(System.Type)`](GameCharacterNames.cs.md#symbol-67e74be938f6)；[`NationalSpire.LeagueArchetypes.CanSupportAnother(string, System.Collections.Generic.Dictionary<string, int>)`](LeagueArchetypes.cs.md#symbol-4a2f709b2968)；[`NationalSpire.LeagueArchetypes.Enabled(string, System.Collections.Generic.Dictionary<string, int>)`](LeagueArchetypes.cs.md#symbol-0609e465e6ba)；[`NationalSpire.LeagueArchetypes.Resolve(string, string)`](LeagueArchetypes.cs.md#symbol-8cffe8f79fa2)；[`NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`](LeagueCards.cs.md#symbol-b5fd3c07325e)；[`NationalSpire.LeagueLadder.ConstructionTier(int, bool)`](LeagueLadder.cs.md#symbol-411d383d97fe)；[`NationalSpire.LeagueLegendDraft.Build(NationalSpire.LeagueArchetypes.Plan, NationalSpire.LeagueCards.Entry[], System.Random)`](LeagueLegendDraft.cs.md#symbol-c210ac44d176)；[`Supply(System.Collections.Generic.HashSet<string>, int, bool)`](LeagueLadder.cs.md#symbol-62785f74805d)；`object.GetType()`；`string.Split(char, System.StringSplitOptions)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.MaxBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.List(int)`；`System.Enum.ToString()`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Random.Next()`；`System.Random.Next(int)`；`System.Random.NextDouble()`

**字段、属性、事件及方法组引用：** `Add(NationalSpire.LeagueCards.Entry)`；`Available(NationalSpire.LeagueCards.Entry)`；`NationalSpire.GameCharacterNames.IsOriginal(System.Type)`；`NationalSpire.LeagueArchetypes.CanSupportAnother(string, System.Collections.Generic.Dictionary<string, int>)`；`NationalSpire.LeagueArchetypes.Defense`；`NationalSpire.LeagueArchetypes.Enabled(string, System.Collections.Generic.Dictionary<string, int>)`；`NationalSpire.LeagueArchetypes.Engine.Draw`；`NationalSpire.LeagueArchetypes.Engine.Energy`；`NationalSpire.LeagueArchetypes.Engines`；`NationalSpire.LeagueArchetypes.Plan.Anchors`；`NationalSpire.LeagueArchetypes.Plan.Finishers`；`NationalSpire.LeagueArchetypes.Plan.Partners`；`NationalSpire.LeagueArchetypes.Plan.Starters`；`NationalSpire.LeagueArchetypes.Resolve(string, string)`；`NationalSpire.LeagueCards.Catalog`；`NationalSpire.LeagueCards.DeckSize`；`NationalSpire.LeagueCards.Entry.Group`；`NationalSpire.LeagueCards.Entry.Id`；`NationalSpire.LeagueCards.Entry.Model`；`NationalSpire.LeagueCards.Entry.Tier`；`NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`；`NationalSpire.LeagueLadder.ConstructionTier(int, bool)`；`NationalSpire.LeagueLegendDraft.Build(NationalSpire.LeagueArchetypes.Plan, NationalSpire.LeagueCards.Entry[], System.Random)`；`Supply(System.Collections.Generic.HashSet<string>, int, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Add(NationalSpire.LeagueCards.Entry)`；输入表达式：`Add(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(c);`
- `Add(NationalSpire.LeagueCards.Entry)`；输入表达式：`Add(options.MaxBy(c=>rng.NextDouble()*(c.Model.Type==MegaCrit.Sts2.Core.Entities.Cards.CardType.Power&&deck.ContainsKey(c.Id)?.65:1))!)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(options.MaxBy(c=>rng.NextDouble()*(c.Model.Type==MegaCrit.Sts2.Core.Entities.Cards.CardType.Power&&deck.ContainsKey(c.Id)?.65:1))!);`
- `Add(NationalSpire.LeagueCards.Entry)`；输入表达式：`Add(pick)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(pick);`
- `Add(NationalSpire.LeagueCards.Entry)`；输入表达式：`Add(preferred[rng.Next(preferred.Length)])`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(preferred[rng.Next(preferred.Length)]);`
- `Available(NationalSpire.LeagueCards.Entry)`；输入表达式：`Available(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: Available(c)&&LeagueArchetypes.CanSupportAnother(c.Id,deck)`
- `Available(NationalSpire.LeagueCards.Entry)`；输入表达式：`Available(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Tier<3&&!deck.ContainsKey(c.Id)&&Available(c)`
- `Available(NationalSpire.LeagueCards.Entry)`；输入表达式：`Available(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Tier<3&&Available(c)`
- `Available(NationalSpire.LeagueCards.Entry)`；输入表达式：`Available(c)`；返回值紧邻使用处：`IfStatementSyntax: if(Available(c))Add(c);`
- `NationalSpire.GameCharacterNames.IsOriginal(System.Type)`；输入表达式：`GameCharacterNames.IsOriginal(c.Model.GetType())`；返回值紧邻使用处：`BinaryExpressionSyntax: (c.Group==role.Id.Entry||c.Group=="COLORLESS")&&GameCharacterNames.IsOriginal(c.Model.GetType())`
- `NationalSpire.LeagueArchetypes.CanSupportAnother(string, System.Collections.Generic.Dictionary<string, int>)`；输入表达式：`LeagueArchetypes.CanSupportAnother(c.Id,deck)`；返回值紧邻使用处：`BinaryExpressionSyntax: Available(c)&&LeagueArchetypes.CanSupportAnother(c.Id,deck)`
- `NationalSpire.LeagueArchetypes.CanSupportAnother(string, System.Collections.Generic.Dictionary<string, int>)`；输入表达式：`LeagueArchetypes.CanSupportAnother(c.Id,deck)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Tier<3&&!deck.ContainsKey(c.Id)&&Available(c)&&LeagueArchetypes.CanSupportAnother(c.Id,deck)`
- `NationalSpire.LeagueArchetypes.CanSupportAnother(string, System.Collections.Generic.Dictionary<string, int>)`；输入表达式：`LeagueArchetypes.CanSupportAnother(c.Id,deck)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Tier<3&&Available(c)&&LeagueArchetypes.CanSupportAnother(c.Id,deck)`
- `NationalSpire.LeagueArchetypes.Enabled(string, System.Collections.Generic.Dictionary<string, int>)`；输入表达式：`LeagueArchetypes.Enabled(c.Id,deck)`；返回值紧邻使用处：`BinaryExpressionSyntax: tier>0&&(c.Id is "DARK_SHACKLES" or "HAND_OF_GREED" or "ETERNAL_ARMOR" or "GOLD_AXE"||engine.Draw.Contains(c.Id)||engine.Energy.Contains(c.Id))&&LeagueArchetypes.Enabled(c.Id,deck)`
- `NationalSpire.LeagueArchetypes.Resolve(string, string)`；输入表达式：`LeagueArchetypes.Resolve(role.Id.Entry,style)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueArchetypes.Resolve(role.Id.Entry,style)`
- `NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`；输入表达式：`LeagueCards.Fixed(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: i<LeagueCards.Fixed(c)`
- `NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`；输入表达式：`LeagueCards.Fixed(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: LeagueCards.Fixed(c)>0`
- `NationalSpire.LeagueLadder.ConstructionTier(int, bool)`；输入表达式：`ConstructionTier(tier,final)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ConstructionTier(tier,final)`
- `NationalSpire.LeagueLegendDraft.Build(NationalSpire.LeagueArchetypes.Plan, NationalSpire.LeagueCards.Entry[], System.Random)`；输入表达式：`LeagueLegendDraft.Build(plan,pool,rng)`；返回值紧邻使用处：`IsPatternExpressionSyntax: LeagueLegendDraft.Build(plan,pool,rng) is {} legend`
- `object.GetType()`；输入表达式：`c.Model.GetType()`；返回值紧邻使用处：`ArgumentSyntax: c.Model.GetType()`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`guards.Split(' ')`；返回值紧邻使用处：`MemberAccessExpressionSyntax: guards.Split(' ').ToHashSet`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`sustain.Split(' ')`；返回值紧邻使用处：`MemberAccessExpressionSyntax: sustain.Split(' ').ToHashSet`
- `Supply(System.Collections.Generic.HashSet<string>, int, bool)`；输入表达式：`Supply(engine.Draw,1+2*build,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Supply(engine.Draw,1+2*build,true);`
- `Supply(System.Collections.Generic.HashSet<string>, int, bool)`；输入表达式：`Supply(engine.Energy,build==1?2:build==2?3:5,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Supply(engine.Energy,build==1?2:build==2?3:5,true);`
- `Supply(System.Collections.Generic.HashSet<string>, int, bool)`；输入表达式：`Supply(guards.Split(' ').ToHashSet(),tier+2,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Supply(guards.Split(' ').ToHashSet(),tier+2,true);`
- `Supply(System.Collections.Generic.HashSet<string>, int, bool)`；输入表达式：`Supply(plan.Finishers,1+build)`；返回值紧邻使用处：`ExpressionStatementSyntax: Supply(plan.Finishers,1+build);`
- `Supply(System.Collections.Generic.HashSet<string>, int, bool)`；输入表达式：`Supply(plan.Starters,2+build)`；返回值紧邻使用处：`ExpressionStatementSyntax: Supply(plan.Starters,2+build);`
- `Supply(System.Collections.Generic.HashSet<string>, int, bool)`；输入表达式：`Supply(sustain.Split(' ').ToHashSet(),tier==1?1:2,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Supply(sustain.Split(' ').ToHashSet(),tier==1?1:2,true);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`deck.ContainsKey(c.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Model.Type==MegaCrit.Sts2.Core.Entities.Cards.CardType.Power&&deck.ContainsKey(c.Id)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`deck.ContainsKey(c.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !deck.ContainsKey(c.Id)`
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
- `System.Collections.Generic.IEnumerable<TSource>.MaxBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`options.MaxBy(c=>rng.NextDouble()*(c.Model.Type==MegaCrit.Sts2.Core.Entities.Cards.CardType.Power&&deck.ContainsKey(c.Id)?.65:1))`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: options.MaxBy(c=>rng.NextDouble()*(c.Model.Type==MegaCrit.Sts2.Core.Entities.Cards.CardType.Power&&deck.ContainsKey(c.Id)?.65:1))!`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`ancient.OrderByDescending(c=>(c.Group=="COLORLESS")==shared)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ancient.OrderByDescending(c=>(c.Group=="COLORLESS")==shared).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`theme.Sum(c=>deck.GetValueOrDefault(c.Id))`；返回值紧邻使用处：`BinaryExpressionSyntax: theme.Sum(c=>deck.GetValueOrDefault(c.Id))<target`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`common.Where(c=>(c.Group==role.Id.Entry||tier>0&&(c.Id is "DARK_SHACKLES" or "HAND_OF_GREED" or "ETERNAL_ARMOR" or "GOLD_AXE"||engine.Draw.Contains(c.Id)||engine.Energy.Contains(c.Id))&&LeagueArchetypes.Enabled(c.Id,deck))).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =common.Where(c=>(c.Group==role.Id.Entry||tier>0&&(c.Id is "DARK_SHACKLES" or "HAND_OF_GREED" or "ETERNAL_ARMOR" or "GOLD_AXE"||engine.Draw.Contains(c.Id)||engine.Energy.Contains(c.Id))&&LeagueArchetypes.Enabled(c.Id,deck))).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`core.Concat(support).Where(c=>c.Tier<3).Distinct().ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =core.Concat(support).Where(c=>c.Tier<3).Distinct().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`fillers.Where(c=>Available(c)&&LeagueArchetypes.CanSupportAnother(c.Id,deck)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =fillers.Where(c=>Available(c)&&LeagueArchetypes.CanSupportAnother(c.Id,deck)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`LeagueCards.Catalog.Values.Where(c=>(c.Group==role.Id.Entry||c.Group=="COLORLESS")&&GameCharacterNames.IsOriginal(c.Model.GetType())&&c.Model.MultiplayerConstraint.ToString()!="MultiplayerOnly").ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueCards.Catalog.Values.Where(c=>(c.Group==role.Id.Entry||c.Group=="COLORLESS")&&GameCharacterNames.IsOriginal(c.Model.GetType())&&c.Model.MultiplayerConstraint.ToString()!="MultiplayerOnly").ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`options.Where(c=>c.Tier==grade).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =options.Where(c=>c.Tier==grade).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`pool.Where(c=>c.Tier<3).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =pool.Where(c=>c.Tier<3).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`pool.Where(c=>c.Tier==3).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =pool.Where(c=>c.Tier==3).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`pool.Where(c=>plan.Anchors.Contains(c.Id)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =pool.Where(c=>plan.Anchors.Contains(c.Id)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`pool.Where(c=>plan.Partners.Contains(c.Id)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =pool.Where(c=>plan.Partners.Contains(c.Id)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`theme.Where(c=>Available(c)&&LeagueArchetypes.CanSupportAnother(c.Id,deck)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =theme.Where(c=>Available(c)&&LeagueArchetypes.CanSupportAnother(c.Id,deck)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`guards.Split(' ').ToHashSet()`；返回值紧邻使用处：`ArgumentSyntax: guards.Split(' ').ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`sustain.Split(' ').ToHashSet()`；返回值紧邻使用处：`ArgumentSyntax: sustain.Split(' ').ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`common.Where(c=>(c.Group==role.Id.Entry||tier>0&&(c.Id is "DARK_SHACKLES" or "HAND_OF_GREED" or "ETERNAL_ARMOR" or "GOLD_AXE"||engine.Draw.Contains(c.Id)||engine.Energy.Contains(c.Id))&&LeagueArchetypes.Enabled(c.Id,deck)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: common.Where(c=>(c.Group==role.Id.Entry||tier>0&&(c.Id is "DARK_SHACKLES" or "HAND_OF_GREED" or "ETERNAL_ARMOR" or "GOLD_AXE"||engine.Draw.Contains(c.Id)||engine.Energy.Contains(c.Id))&&LeagueArchetypes.Enabled(c.Id,deck))).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`core.Concat(support).Where(c=>c.Tier<3)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: core.Concat(support).Where(c=>c.Tier<3).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`core.Where(c=>c.Id is "JEST" or "PUNCH_OF_JOY")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var c in core.Where(c=>c.Id is "JEST" or "PUNCH_OF_JOY"))if(Available(c))Add(c);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`fillers.Where(c=>Available(c)&&LeagueArchetypes.CanSupportAnother(c.Id,deck))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: fillers.Where(c=>Available(c)&&LeagueArchetypes.CanSupportAnother(c.Id,deck)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`LeagueCards.Catalog.Values.Where(c=>(c.Group==role.Id.Entry||c.Group=="COLORLESS")&&GameCharacterNames.IsOriginal(c.Model.GetType())&&c.Model.MultiplayerConstraint.ToString()!="MultiplayerOnly")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LeagueCards.Catalog.Values.Where(c=>(c.Group==role.Id.Entry||c.Group=="COLORLESS")&&GameCharacterNames.IsOriginal(c.Model.GetType())&&c.Model.MultiplayerConstraint.ToString()!="MultiplayerOnly").ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`options.Where(c=>c.Tier==grade)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: options.Where(c=>c.Tier==grade).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`pool.Where(c=>c.Tier<3)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pool.Where(c=>c.Tier<3).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`pool.Where(c=>c.Tier==3)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pool.Where(c=>c.Tier==3).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`pool.Where(c=>LeagueCards.Fixed(c)>0)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var c in pool.Where(c=>LeagueCards.Fixed(c)>0))for(int i=0;i<LeagueCards.Fixed(c);i++)Add(c);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`pool.Where(c=>plan.Anchors.Contains(c.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pool.Where(c=>plan.Anchors.Contains(c.Id)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`pool.Where(c=>plan.Partners.Contains(c.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pool.Where(c=>plan.Partners.Contains(c.Id)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`theme.Where(c=>Available(c)&&LeagueArchetypes.CanSupportAnother(c.Id,deck))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: theme.Where(c=>Available(c)&&LeagueArchetypes.CanSupportAnother(c.Id,deck)).ToArray`
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
- `System.Random.Next(int)`；输入表达式：`rng.Next(preferred.Length)`；返回值紧邻使用处：`ArgumentSyntax: rng.Next(preferred.Length)`
- `System.Random.NextDouble()`；输入表达式：`rng.NextDouble()`；返回值紧邻使用处：`BinaryExpressionSyntax: rng.NextDouble()*(c.Model.Type==MegaCrit.Sts2.Core.Entities.Cards.CardType.Power&&deck.ContainsKey(c.Id)?.65:1)`

**赋值（含属性/字段和局部值）：**

- `preferred` = `options`
- `var (guards,sustain)` = `LeagueArchetypes.Defense[role.Id.Entry]`

<a id="symbol-899debc8b5b3"></a>

## `Add(NationalSpire.LeagueCards.Entry) — void Add(LeagueCards.Entry c)`

来源：源码第 79 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueLadder.BuildFor(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string, bool)`](LeagueLadder.cs.md#symbol-005dadfed015)；[`Supply(System.Collections.Generic.HashSet<string>, int, bool)`](LeagueLadder.cs.md#symbol-62785f74805d)

**调用：** `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueCards.Entry.Group`；`NationalSpire.LeagueCards.Entry.Id`；`NationalSpire.LeagueCards.Entry.Model`；`NationalSpire.LeagueCards.Entry.Tier`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`deck.GetValueOrDefault(c.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: deck.GetValueOrDefault(c.Id)+1`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.Add(c.Model)`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Add(c.Model);`

**赋值（含属性/字段和局部值）：**

- `deck[c.Id]` = `deck.GetValueOrDefault(c.Id)+1`

<a id="symbol-dc858d2fe947"></a>

## `Available(NationalSpire.LeagueCards.Entry) — bool Available(LeagueCards.Entry c)`

来源：源码第 80 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueLadder.BuildFor(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string, bool)`](LeagueLadder.cs.md#symbol-005dadfed015)；[`Supply(System.Collections.Generic.HashSet<string>, int, bool)`](LeagueLadder.cs.md#symbol-62785f74805d)

**调用：** [`NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`](LeagueCards.cs.md#symbol-b5fd3c07325e)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<int>.Sum()`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueCards.DeckSize`；`NationalSpire.LeagueCards.Entry.Group`；`NationalSpire.LeagueCards.Entry.Id`；`NationalSpire.LeagueCards.Entry.Tier`；`NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`；`NationalSpire.LeagueCards.NeutralLimit`；`NationalSpire.LeagueCards.RarityLimits`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueCards.Fixed(NationalSpire.LeagueCards.Entry, string?)`；输入表达式：`LeagueCards.Fixed(c)`；返回值紧邻使用处：`ArgumentSyntax: LeagueCards.Fixed(c)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`deck.ContainsKey(c.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !deck.ContainsKey(c.Id)`
- `System.Collections.Generic.IEnumerable<int>.Sum()`；输入表达式：`LeagueCards.RarityLimits.Skip(1).Sum()`；返回值紧邻使用处：`BinaryExpressionSyntax: LeagueCards.DeckSize-LeagueCards.RarityLimits.Skip(1).Sum()`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`LeagueCards.RarityLimits.Skip(1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LeagueCards.RarityLimits.Skip(1).Sum`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`deck.GetValueOrDefault(c.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: deck.GetValueOrDefault(c.Id)<Math.Max(2,LeagueCards.Fixed(c))`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(2,LeagueCards.Fixed(c))`；返回值紧邻使用处：`BinaryExpressionSyntax: deck.GetValueOrDefault(c.Id)<Math.Max(2,LeagueCards.Fixed(c))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-62785f74805d"></a>

## `Supply(System.Collections.Generic.HashSet<string>, int, bool) — void Supply(HashSet<string> tools,int target,bool utility=false)`

来源：源码第 100 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueLadder.BuildFor(MegaCrit.Sts2.Core.Models.CharacterModel, System.Random, int, string, bool)`](LeagueLadder.cs.md#symbol-005dadfed015)

**调用：** [`Add(NationalSpire.LeagueCards.Entry)`](LeagueLadder.cs.md#symbol-899debc8b5b3)；[`Available(NationalSpire.LeagueCards.Entry)`](LeagueLadder.cs.md#symbol-dc858d2fe947)；[`Counts(string)`](LeagueLadder.cs.md#symbol-46ae9fc8bdac)；[`NationalSpire.LeagueArchetypes.CanSupportAnother(string, System.Collections.Generic.Dictionary<string, int>)`](LeagueArchetypes.cs.md#symbol-4a2f709b2968)；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.MaxBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Random.NextDouble()`

**字段、属性、事件及方法组引用：** `Add(NationalSpire.LeagueCards.Entry)`；`Available(NationalSpire.LeagueCards.Entry)`；`Counts(string)`；`NationalSpire.LeagueArchetypes.CanSupportAnother(string, System.Collections.Generic.Dictionary<string, int>)`；`NationalSpire.LeagueCards.Entry.Group`；`NationalSpire.LeagueCards.Entry.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Add(NationalSpire.LeagueCards.Entry)`；输入表达式：`Add(options.MaxBy(c=>(theme.Contains(c)?1.1:0)+(c.Group==role.Id.Entry?.4:0)+rng.NextDouble()*2)!)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(options.MaxBy(c=>(theme.Contains(c)?1.1:0)+(c.Group==role.Id.Entry?.4:0)+rng.NextDouble()*2)!);`
- `Available(NationalSpire.LeagueCards.Entry)`；输入表达式：`Available(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: Counts(c.Id)&&Available(c)`
- `Counts(string)`；输入表达式：`Counts(c.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: Counts(c.Id)&&Available(c)`
- `Counts(string)`；输入表达式：`Counts(p.Key)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p=>Counts(p.Key)`
- `NationalSpire.LeagueArchetypes.CanSupportAnother(string, System.Collections.Generic.Dictionary<string, int>)`；输入表达式：`LeagueArchetypes.CanSupportAnother(c.Id,deck)`；返回值紧邻使用处：`BinaryExpressionSyntax: Counts(c.Id)&&Available(c)&&LeagueArchetypes.CanSupportAnother(c.Id,deck)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`theme.Contains(c)`；返回值紧邻使用处：`ConditionalExpressionSyntax: theme.Contains(c)?1.1:0`
- `System.Collections.Generic.IEnumerable<TSource>.MaxBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`options.MaxBy(c=>(theme.Contains(c)?1.1:0)+(c.Group==role.Id.Entry?.4:0)+rng.NextDouble()*2)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: options.MaxBy(c=>(theme.Contains(c)?1.1:0)+(c.Group==role.Id.Entry?.4:0)+rng.NextDouble()*2)!`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`deck.Where(p=>Counts(p.Key)).Sum(p=>p.Value)`；返回值紧邻使用处：`BinaryExpressionSyntax: deck.Where(p=>Counts(p.Key)).Sum(p=>p.Value)<target`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`common.Where(c=>Counts(c.Id)&&Available(c)&&LeagueArchetypes.CanSupportAnother(c.Id,deck)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =common.Where(c=>Counts(c.Id)&&Available(c)&&LeagueArchetypes.CanSupportAnother(c.Id,deck)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`common.Where(c=>Counts(c.Id)&&Available(c)&&LeagueArchetypes.CanSupportAnother(c.Id,deck))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: common.Where(c=>Counts(c.Id)&&Available(c)&&LeagueArchetypes.CanSupportAnother(c.Id,deck)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`deck.Where(p=>Counts(p.Key))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: deck.Where(p=>Counts(p.Key)).Sum`
- `System.Random.NextDouble()`；输入表达式：`rng.NextDouble()`；返回值紧邻使用处：`BinaryExpressionSyntax: rng.NextDouble()*2`

**赋值（含属性/字段和局部值）：**


<a id="symbol-46ae9fc8bdac"></a>

## `Counts(string) — bool Counts(string id)`

来源：源码第 101 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Supply(System.Collections.Generic.HashSet<string>, int, bool)`](LeagueLadder.cs.md#symbol-62785f74805d)

**调用：** [`NationalSpire.LeagueArchetypes.Enabled(string, System.Collections.Generic.Dictionary<string, int>)`](LeagueArchetypes.cs.md#symbol-0609e465e6ba)；`System.Collections.Generic.HashSet<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueArchetypes.Enabled(string, System.Collections.Generic.Dictionary<string, int>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueArchetypes.Enabled(string, System.Collections.Generic.Dictionary<string, int>)`；输入表达式：`LeagueArchetypes.Enabled(id,deck)`；返回值紧邻使用处：`BinaryExpressionSyntax: !utility||LeagueArchetypes.Enabled(id,deck)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`tools.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: tools.Contains(id)&&(!utility||LeagueArchetypes.Enabled(id,deck))`

**赋值（含属性/字段和局部值）：**
