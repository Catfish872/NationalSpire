# MarketDynamics.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`8491F0F6A847F304BA5F5D416482A1931D161610ECB3FED7861A9026F3C2B4D7`。来源：[源码](../../MarketDynamics.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.MarketDynamics`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-d3b47ce56b50"></a>

## `NationalSpire.MarketDynamics.Gaussian(System.Random) — public static double Gaussian(Random random)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Initialize(NationalSpire.CareerData)`](CareerMarket.cs.md#symbol-b3244730c7ae)；[`NationalSpire.MarketDynamics.Noise(string, int, NationalSpire.MarketAsset, System.Random)`](MarketDynamics.cs.md#symbol-f66f0f0a5e13)

**调用：** `System.Math.Cos(double)`；`System.Math.Log(double)`；`System.Math.Sqrt(double)`；`System.Random.NextDouble()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Cos(double)`；输入表达式：`Math.Cos(2 * Math.PI * random.NextDouble())`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Sqrt(-2 * Math.Log(1 - random.NextDouble())) * Math.Cos(2 * Math.PI * random.NextDouble())`
- `System.Math.Log(double)`；输入表达式：`Math.Log(1 - random.NextDouble())`；返回值紧邻使用处：`BinaryExpressionSyntax: -2 * Math.Log(1 - random.NextDouble())`
- `System.Math.Sqrt(double)`；输入表达式：`Math.Sqrt(-2 * Math.Log(1 - random.NextDouble()))`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Sqrt(-2 * Math.Log(1 - random.NextDouble())) * Math.Cos(2 * Math.PI * random.NextDouble())`
- `System.Random.NextDouble()`；输入表达式：`random.NextDouble()`；返回值紧邻使用处：`BinaryExpressionSyntax: 1 - random.NextDouble()`
- `System.Random.NextDouble()`；输入表达式：`random.NextDouble()`；返回值紧邻使用处：`BinaryExpressionSyntax: 2 * Math.PI * random.NextDouble()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9fa2a14727ca"></a>

## `NationalSpire.MarketDynamics.Volatility(string, NationalSpire.MarketAsset) — public static double Volatility(string world, MarketAsset asset)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Advance(NationalSpire.CareerData)`](CareerMarket.cs.md#symbol-6039084ecec7)；[`NationalSpire.CareerMarket.Initialize(NationalSpire.CareerData)`](CareerMarket.cs.md#symbol-b3244730c7ae)；[`NationalSpire.MarketTerminal.SortValue(NationalSpire.MarketAsset)`](MarketTerminal.cs.md#symbol-045b28b90c31)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.MarketAsset.Forex`；`NationalSpire.MarketAsset.Id`；`NationalSpire.MarketAsset.Sector`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(world + ":volatility:" + asset.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.StableHash(world + ":volatility:" + asset.Id) % 10001`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a56a94e198eb"></a>

## `NationalSpire.MarketDynamics.Sensitivity(string, string) — public static double Sensitivity(string world, string id)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](CareerMarket.cs.md#symbol-089c75a03be9)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.StableHash(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(world + ":sensitivity:" + id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.StableHash(world + ":sensitivity:" + id) % 10001`

**赋值（含属性/字段和局部值）：**


<a id="symbol-75a00530631a"></a>

## `NationalSpire.MarketDynamics.Shock(System.Random, double) — public static double Shock(Random random, double sigma)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Advance(NationalSpire.CareerData)`](CareerMarket.cs.md#symbol-6039084ecec7)

**调用：** `System.Math.Clamp(double, double, double)`；`System.Random.NextDouble()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp((sign < .5 ? -1 : 1) * (1.5 + 2 * magnitude) * sigma, -.028, .028)`；返回值紧邻使用处：`ConditionalExpressionSyntax: trigger < .02 ? Math.Clamp((sign < .5 ? -1 : 1) * (1.5 + 2 * magnitude) * sigma, -.028, .028) : 0`
- `System.Random.NextDouble()`；输入表达式：`random.NextDouble()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = random.NextDouble()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f66f0f0a5e13"></a>

## `NationalSpire.MarketDynamics.Noise(string, int, NationalSpire.MarketAsset, System.Random) — public static double Noise(string world, int day, MarketAsset asset, Random random)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Advance(NationalSpire.CareerData)`](CareerMarket.cs.md#symbol-6039084ecec7)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.MarketDynamics.Gaussian(System.Random)`](MarketDynamics.cs.md#symbol-d3b47ce56b50)；`System.Math.Sqrt(double)`；`System.Random.Random(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.MarketAsset.Country`；`NationalSpire.MarketAsset.Forex`；`NationalSpire.MarketAsset.Sector`；`NationalSpire.MarketDynamics.Gaussian(System.Random)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash($"{world}:country:{day}:{asset.Country}")`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.StableHash($"{world}:country:{day}:{asset.Country}")`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash($"{world}:sector:{day}:{asset.Sector}")`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.StableHash($"{world}:sector:{day}:{asset.Sector}")`
- `NationalSpire.MarketDynamics.Gaussian(System.Random)`；输入表达式：`Gaussian(new Random(CareerEngine.StableHash($"{world}:country:{day}:{asset.Country}")))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Gaussian(new Random(CareerEngine.StableHash($"{world}:country:{day}:{asset.Country}")))`
- `NationalSpire.MarketDynamics.Gaussian(System.Random)`；输入表达式：`Gaussian(new Random(CareerEngine.StableHash($"{world}:sector:{day}:{asset.Sector}")))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Gaussian(new Random(CareerEngine.StableHash($"{world}:sector:{day}:{asset.Sector}")))`
- `NationalSpire.MarketDynamics.Gaussian(System.Random)`；输入表达式：`Gaussian(random)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Sqrt(.75) * Gaussian(random)`
- `NationalSpire.MarketDynamics.Gaussian(System.Random)`；输入表达式：`Gaussian(random)`；返回值紧邻使用处：`ReturnStatementSyntax: return Gaussian(random);`
- `System.Math.Sqrt(double)`；输入表达式：`Math.Sqrt(.75)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Sqrt(.75) * Gaussian(random)`
- `System.Random.Random(int)`；输入表达式：`new Random(CareerEngine.StableHash($"{world}:country:{day}:{asset.Country}"))`；返回值紧邻使用处：`ArgumentSyntax: new Random(CareerEngine.StableHash($"{world}:country:{day}:{asset.Country}"))`
- `System.Random.Random(int)`；输入表达式：`new Random(CareerEngine.StableHash($"{world}:sector:{day}:{asset.Sector}"))`；返回值紧邻使用处：`ArgumentSyntax: new Random(CareerEngine.StableHash($"{world}:sector:{day}:{asset.Sector}"))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-80d7f294a5d5"></a>

## `NationalSpire.MarketDynamics.Sponsors(NationalSpire.CareerData) — public static IEnumerable<SponsorContract> Sponsors(CareerData d)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketDynamics.Partners(NationalSpire.CareerData)`](MarketDynamics.cs.md#symbol-6b3b3aa62750)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.EsportsCareer.Sponsors`；`NationalSpire.SponsorContract.Accepted`；`NationalSpire.SponsorContract.EndedDay`；`NationalSpire.SponsorContract.EndSeason`；`NationalSpire.SponsorContract.SignedDay`；`NationalSpire.SponsorContract.StartSeason`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Sponsors          .Where(s => s.Accepted && s.SignedDay <= d.Day && s.StartSeason <= d.Season && s.EndSeason >= d.Season && s.EndedDay == 0)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => d.Esports.Sponsors          .Where(s => s.Accepted && s.SignedDay <= d.Day && s.StartSeason <= d.Season && s.EndSeason >= d.Season && s.EndedDay == 0)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6b3b3aa62750"></a>

## `NationalSpire.MarketDynamics.Partners(NationalSpire.CareerData) — public static Dictionary<string, HashSet<string>> Partners(CareerData d)`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](CareerMarket.cs.md#symbol-089c75a03be9)；[`NationalSpire.MarketDynamics.Anchors(NationalSpire.CareerData)`](MarketDynamics.cs.md#symbol-9a7ffea26eec)；[`NationalSpire.MarketTerminal.Bind(NationalSpire.CareerData, System.Action<NationalSpire.MarketOrder>, System.Action<string>)`](MarketTerminal.cs.md#symbol-09b1a1ea6de7)

**调用：** [`Add(string, string)`](MarketDynamics.cs.md#symbol-0c87a73b59a2)；[`NationalSpire.CoachLineups.Coach(NationalSpire.CareerPerson)`](CoachLineups.cs.md#symbol-86e0b50ffb0e)；[`NationalSpire.MarketDynamics.Sponsors(NationalSpire.CareerData)`](MarketDynamics.cs.md#symbol-80d7f294a5d5)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Func<T, TResult>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `Add(string, string)`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.MarketSponsors`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CoachLineups.Coach(NationalSpire.CareerPerson)`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.MarketDynamics.Sponsors(NationalSpire.CareerData)`；`NationalSpire.OwnedClubState.Reserves`；`NationalSpire.OwnedClubState.Sponsor`；`NationalSpire.OwnedClubState.Starters`；`NationalSpire.OwnedClubState.Youth`；`NationalSpire.OwnedSponsor.Brand`；`NationalSpire.OwnedSponsor.EndDay`；`NationalSpire.SponsorContract.Accepted`；`NationalSpire.SponsorContract.Brand`；`NationalSpire.SponsorContract.EndedDay`；`NationalSpire.SponsorContract.EndSeason`；`NationalSpire.SponsorContract.SignedDay`；`NationalSpire.SponsorContract.StartSeason`；`NationalSpire.SponsorContract.TargetId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Add(string, string)`；输入表达式：`Add(owned.Brand, id)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(owned.Brand, id);`
- `Add(string, string)`；输入表达式：`Add(sponsor.Brand, "player")`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(sponsor.Brand, "player");`
- `Add(string, string)`；输入表达式：`Add(sponsor.Brand, human)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(sponsor.Brand, human);`
- `Add(string, string)`；输入表达式：`Add(sponsor.Brand, sponsor.TargetId)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(sponsor.Brand, sponsor.TargetId);`
- `NationalSpire.CoachLineups.Coach(NationalSpire.CareerPerson)`；输入表达式：`CoachLineups.Coach(p)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CoachLineups.Coach(p)`
- `NationalSpire.MarketDynamics.Sponsors(NationalSpire.CareerData)`；输入表达式：`Sponsors(d)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var sponsor in Sponsors(d)) Add(sponsor.Brand, sponsor.TargetId);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, HashSet<string>>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, HashSet<string>>()`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`club.Starters.Concat(club.Reserves).Concat(club.Youth)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: club.Starters.Concat(club.Reserves).Concat(club.Youth).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`club.Starters.Concat(club.Reserves)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: club.Starters.Concat(club.Reserves).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`club.Starters.Concat(club.Reserves).Concat(club.Youth).Distinct()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string id in club.Starters.Concat(club.Reserves).Concat(club.Youth).Distinct()) Add(owned.Brand, id);`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.People.Where(p => p.ClubId.Length > 0 && !CoachLineups.Coach(p))              .GroupBy(p => p.ClubId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.ClubId.Length > 0 && !CoachLineups.Coach(p))              .GroupBy(p => p.ClubId).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`g.Select(p => p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Select(p => p.Id).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`g.Select(p => p.Id).ToArray()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.Select(p => p.Id).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`d.People.Where(p => p.ClubId.Length > 0 && !CoachLineups.Coach(p))              .GroupBy(p => p.ClubId).ToDictionary(g => g.Key, g => g.Select(p => p.Id).ToArray())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.People.Where(p => p.ClubId.Length > 0 && !CoachLineups.Coach(p))              .GroupBy(p => p.ClubId).ToDictionary(g => g.Key, g => g.Select(p => p.Id).ToArray())`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`(d.MarketSponsors?.Invoke("player") ?? []).Where(s => s.Accepted && s.SignedDay <= d.Day && s.StartSeason <= d.Season && s.EndSeason >= d.Season && s.EndedDay == 0)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var sponsor in (d.MarketSponsors?.Invoke("player") ?? []).Where(s => s.Accepted && s.SignedDay <= d.Day && s.StartSeason <= d.Season && s.EndSeason >= d.Season && s.EndedDay == 0)) Add(sponsor.Brand, "player");`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`(d.MarketSponsors?.Invoke(human) ?? []).Where(s => s.Accepted && s.SignedDay <= d.Day && s.StartSeason <= d.Season && s.EndSeason >= d.Season && s.EndedDay == 0)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var sponsor in (d.MarketSponsors?.Invoke(human) ?? []).Where(s => s.Accepted && s.SignedDay <= d.Day && s.StartSeason <= d.Season && s.EndSeason >= d.Season && s.EndedDay == 0)) Add(sponsor.Brand, human);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p => p.ClubId.Length > 0 && !CoachLineups.Coach(p))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.ClubId.Length > 0 && !CoachLineups.Coach(p))              .GroupBy`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`.Invoke("player")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: d.MarketSponsors?.Invoke("player")`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`.Invoke(human)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: d.MarketSponsors?.Invoke(human)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0c87a73b59a2"></a>

## `Add(string, string) — void Add(string brand, string id)`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketDynamics.Partners(NationalSpire.CareerData)`](MarketDynamics.cs.md#symbol-6b3b3aa62750)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.UnionWith(System.Collections.Generic.IEnumerable<T>)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`partners.TryGetValue(brand, out var people)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !partners.TryGetValue(brand, out var people)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`roster.TryGetValue(id, out var players)`；返回值紧邻使用处：`IfStatementSyntax: if (roster.TryGetValue(id, out var players)) people.UnionWith(players);              else people.Add(id);`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`people.Add(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: people.Add(id);`
- `System.Collections.Generic.HashSet<T>.UnionWith(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`people.UnionWith(players)`；返回值紧邻使用处：`ExpressionStatementSyntax: people.UnionWith(players);`

**赋值（含属性/字段和局部值）：**

- `partners[brand]` = `people = []`
- `people` = `[]`

<a id="symbol-9a7ffea26eec"></a>

## `NationalSpire.MarketDynamics.Anchors(NationalSpire.CareerData) — public static Dictionary<string, decimal> Anchors(CareerData d)`

来源：源码第 49 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Advance(NationalSpire.CareerData)`](CareerMarket.cs.md#symbol-6039084ecec7)

**调用：** [`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.MarketDynamics.Partners(NationalSpire.CareerData)`](MarketDynamics.cs.md#symbol-6b3b3aa62750)；[`NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`](NationalDevelopment.cs.md#symbol-b758e69d4a1d)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, double>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Math.Pow(double, double)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAudience.Followers(NationalSpire.CareerPerson)`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Fans`；`NationalSpire.CareerData.People`；`NationalSpire.CareerPerson.Id`；`NationalSpire.EsportsCareer.Nations`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.MarketAsset.Country`；`NationalSpire.MarketAsset.Forex`；`NationalSpire.MarketAsset.Id`；`NationalSpire.MarketAsset.Initial`；`NationalSpire.MarketAsset.Name`；`NationalSpire.MarketAsset.Sector`；`NationalSpire.MarketCatalog.Assets`；`NationalSpire.MarketDynamics.Partners(NationalSpire.CareerData)`；`NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`；`NationalSpire.NationalLegacy.Country`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(d)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Human(d)`
- `NationalSpire.MarketDynamics.Partners(NationalSpire.CareerData)`；输入表达式：`Partners(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Partners(d)`
- `NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`；输入表达式：`NationalDevelopment.Level(country, "income")`；返回值紧邻使用处：`BinaryExpressionSyntax: NationalDevelopment.Level(country, "income") + NationalDevelopment.Level(country, "services")`
- `NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`；输入表达式：`NationalDevelopment.Level(country, "industry")`；返回值紧邻使用处：`BinaryExpressionSyntax: NationalDevelopment.Level(country, "industry") + NationalDevelopment.Level(country, "infrastructure")`
- `NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`；输入表达式：`NationalDevelopment.Level(country, "infrastructure")`；返回值紧邻使用处：`BinaryExpressionSyntax: NationalDevelopment.Level(country, "industry") + NationalDevelopment.Level(country, "infrastructure")`
- `NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`；输入表达式：`NationalDevelopment.Level(country, "services")`；返回值紧邻使用处：`BinaryExpressionSyntax: NationalDevelopment.Level(country, "income") + NationalDevelopment.Level(country, "services")`
- `NationalSpire.NationalDevelopment.Level(NationalSpire.NationalLegacy, string)`；输入表达式：`NationalDevelopment.Level(country, "services")`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "电竞设备" => NationalDevelopment.Level(country, "services")`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`countries.TryGetValue(a.Country, out var country)`；返回值紧邻使用处：`IfStatementSyntax: if (countries.TryGetValue(a.Country, out var country))                  levels = a.Sector switch {                      "训练装备" => (NationalDevelopment.Level(country, "industry") + NationalDevelopment.Level(country, "infrastructure")) / 2.0,                      "电竞设备" => NationalDevelopment.Level(country, "services"),                      _ => (NationalDevelopment.Level(country, "income") + NationalDevelopment.Level(country, "services")) / 2.0 };`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, double>)`；输入表达式：`.Sum(id => (double)fans.GetValueOrDefault(id))`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: partners.GetValueOrDefault(a.Name)?.Sum(id => (double)fans.GetValueOrDefault(id))`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`d.People.ToDictionary(p => p.Id, CareerAudience.Followers)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.People.ToDictionary(p => p.Id, CareerAudience.Followers)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`MarketCatalog.Assets.ToDictionary(a => a.Id, a =>          {              if (a.Forex) return a.Initial;              double levels = 5;              if (countries.TryGetValue(a.Country, out var country))                  levels = a.Sector switch {                      "训练装备" => (NationalDevelopment.Level(country, "industry") + NationalDevelopment.Level(country, "infrastructure")) / 2.0,                      "电竞设备" => NationalDevelopment.Level(country, "services"),                      _ => (NationalDevelopment.Level(country, "income") + NationalDevelopment.Level(country, "services")) / 2.0 };              double followers = partners.GetValueOrDefault(a.Name)?.Sum(id => (double)fans.GetValueOrDefault(id)) ?? 0;              return a.Initial * (decimal)(Math.Pow(1.02, levels - 5) * Math.Pow(1 + followers / 100000, .1));          })`；返回值紧邻使用处：`ReturnStatementSyntax: return MarketCatalog.Assets.ToDictionary(a => a.Id, a =>          {              if (a.Forex) return a.Initial;              double levels = 5;              if (countries.TryGetValue(a.Country, out var country))                  levels = a.Sector switch {                      "训练装备" => (NationalDevelopment.Level(country, "industry") + NationalDevelopment.Level(country, "infrastructure")) / 2.0,                      "电竞设备" => NationalDevelopment.Level(country, "services"),                      _ => (NationalDevelopment.Level(country, "income") + NationalDevelopment.Level(country, "services")) / 2.0 };              double followers = partners.GetValueOrDefault(a.Name)?.Sum(id => (double)fans.GetValueOrDefault(id)) ?? 0;              return a.Initial * (decimal)(Math.Pow(1.02, levels - 5) * Math.Pow(1 + followers / 100000, .1));          });`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Esports.Nations.ToDictionary(n => n.Country)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.Nations.ToDictionary(n => n.Country)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`fans.GetValueOrDefault(id)`；返回值紧邻使用处：`CastExpressionSyntax: (double)fans.GetValueOrDefault(id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`partners.GetValueOrDefault(a.Name)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: partners.GetValueOrDefault(a.Name)?.Sum(id => (double)fans.GetValueOrDefault(id))`
- `System.Math.Pow(double, double)`；输入表达式：`Math.Pow(1 + followers / 100000, .1)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Pow(1.02, levels - 5) * Math.Pow(1 + followers / 100000, .1)`
- `System.Math.Pow(double, double)`；输入表达式：`Math.Pow(1.02, levels - 5)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Pow(1.02, levels - 5) * Math.Pow(1 + followers / 100000, .1)`

**赋值（含属性/字段和局部值）：**

- `fans[GroupChats.Human(d)]` = `d.Fans`
- `levels` = `a.Sector switch {                      "训练装备" => (NationalDevelopment.Level(country, "industry") + NationalDevelopment.Level(country, "infrastructure")) / 2.0,                      "电竞设备" => NationalDevelopment.Level(country, "services"),                      _ => (NationalDevelopment.Level(country, "income") + NationalDevelopment.Level(country, "services")) / 2.0 }`

<a id="symbol-4ed121bc162f"></a>

## `NationalSpire.MarketDynamics.AddEvent(NationalSpire.CareerData, NationalSpire.MarketEvent) — public static void AddEvent(CareerData d, MarketEvent value)`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Advance(NationalSpire.CareerData)`](CareerMarket.cs.md#symbol-6039084ecec7)；[`NationalSpire.CareerMarket.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](CareerMarket.cs.md#symbol-089c75a03be9)

**调用：** `System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.RemoveRange(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Market`；`NationalSpire.MarketState.Events`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Market.Events.Add(value)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Market.Events.Add(value);`
- `System.Collections.Generic.List<T>.RemoveRange(int, int)`；输入表达式：`d.Market.Events.RemoveRange(0, d.Market.Events.Count - 240)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Market.Events.RemoveRange(0, d.Market.Events.Count - 240);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9d095f6ad885"></a>

## `NationalSpire.MarketDynamics.TryPublish(NationalSpire.CareerData) — public static bool TryPublish(CareerData d)`

来源：源码第 73 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.WorldEvents.Advance(NationalSpire.CareerData)`](WorldEvents.cs.md#symbol-6471e41e5007)

**调用：** [`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`](CareerEngine.cs.md#symbol-cd8fd2c800e7)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；`decimal.ToString(string?)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Market`；`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.MarketAsset.Forex`；`NationalSpire.MarketAsset.Id`；`NationalSpire.MarketAsset.Name`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketEvent.Asset`；`NationalSpire.MarketEvent.Day`；`NationalSpire.MarketEvent.Person`；`NationalSpire.MarketEvent.Text`；`NationalSpire.MarketQuote.Price`；`NationalSpire.MarketState.Events`；`NationalSpire.MarketState.NewsDay`；`NationalSpire.MarketState.Quotes`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.ToString(string?)`；输入表达式：`d.Market.Quotes[a.Id].Price.ToString("0.0000")`；返回值紧邻使用处：`ConditionalExpressionSyntax: a.Forex ? d.Market.Quotes[a.Id].Price.ToString("0.0000") : CareerMoney.Format(d.Market.Quotes[a.Id].Price)`
- `NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；输入表达式：`CareerEngine.Publish(d, "market-news-" + d.Day, "赛场之外 · 品牌与汇市动态", facts, "市场动态", true, recent.Select(e => e.Person).Where(id => id.Length > 0).Distinct().ToList())`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.Publish(d, "market-news-" + d.Day, "赛场之外 · 品牌与汇市动态", facts, "市场动态", true, recent.Select(e => e.Person).Where(id => id.Length > 0).Distinct().ToList());`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(d.Market.Quotes[a.Id].Price)`；返回值紧邻使用处：`ConditionalExpressionSyntax: a.Forex ? d.Market.Quotes[a.Id].Price.ToString("0.0000") : CareerMoney.Format(d.Market.Quotes[a.Id].Price)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("；", assets.Select(a => a.Name + " " + (a.Forex ? d.Market.Quotes[a.Id].Price.ToString("0.0000") : CareerMoney.Format(d.Market.Quotes[a.Id].Price))))`；返回值紧邻使用处：`BinaryExpressionSyntax: string.Join("\n", recent.Select(e => $"第{e.Day}天：{e.Text}")) + "\n最新行情：" + string.Join("；", assets.Select(a => a.Name + " " + (a.Forex ? d.Market.Quotes[a.Id].Price.ToString("0.0000") : CareerMoney.Format(d.Market.Quotes[a.Id].Price))))`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", recent.Select(e => $"第{e.Day}天：{e.Text}"))`；返回值紧邻使用处：`BinaryExpressionSyntax: string.Join("\n", recent.Select(e => $"第{e.Day}天：{e.Text}")) + "\n最新行情："`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`assets.Any(a => a.Forex)`；返回值紧邻使用处：`IfStatementSyntax: if (assets.Any(a => a.Forex)) facts += "\n外汇报价表示1人民币兑换的外币数量；上涨表示人民币升值，下降表示人民币贬值。";`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`recent.Select(e => e.Asset).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: recent.Select(e => e.Asset).Distinct().Where`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`recent.Select(e => e.Person).Where(id => id.Length > 0).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: recent.Select(e => e.Person).Where(id => id.Length > 0).Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`assets.Select(a => a.Name + " " + (a.Forex ? d.Market.Quotes[a.Id].Price.ToString("0.0000") : CareerMoney.Format(d.Market.Quotes[a.Id].Price)))`；返回值紧邻使用处：`ArgumentSyntax: assets.Select(a => a.Name + " " + (a.Forex ? d.Market.Quotes[a.Id].Price.ToString("0.0000") : CareerMoney.Format(d.Market.Quotes[a.Id].Price)))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`recent.Select(e => $"第{e.Day}天：{e.Text}")`；返回值紧邻使用处：`ArgumentSyntax: recent.Select(e => $"第{e.Day}天：{e.Text}")`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`recent.Select(e => e.Asset).Distinct().Where(MarketCatalog.ById.ContainsKey).Select(id => MarketCatalog.ById[id])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = recent.Select(e => e.Asset).Distinct().Where(MarketCatalog.ById.ContainsKey).Select(id => MarketCatalog.ById[id])`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`recent.Select(e => e.Asset)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: recent.Select(e => e.Asset).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`recent.Select(e => e.Person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: recent.Select(e => e.Person).Where`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`d.Market.Events.Where(e => e.Day > d.Market.NewsDay && e.Day <= d.Day).TakeLast(8)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Market.Events.Where(e => e.Day > d.Market.NewsDay && e.Day <= d.Day).TakeLast(8).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`d.Market.Events.Where(e => e.Day > d.Market.NewsDay && e.Day <= d.Day).TakeLast(8).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Market.Events.Where(e => e.Day > d.Market.NewsDay && e.Day <= d.Day).TakeLast(8).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`recent.Select(e => e.Person).Where(id => id.Length > 0).Distinct().ToList()`；返回值紧邻使用处：`ArgumentSyntax: recent.Select(e => e.Person).Where(id => id.Length > 0).Distinct().ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Market.Events.Where(e => e.Day > d.Market.NewsDay && e.Day <= d.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Market.Events.Where(e => e.Day > d.Market.NewsDay && e.Day <= d.Day).TakeLast`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`recent.Select(e => e.Asset).Distinct().Where(MarketCatalog.ById.ContainsKey)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: recent.Select(e => e.Asset).Distinct().Where(MarketCatalog.ById.ContainsKey).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`recent.Select(e => e.Person).Where(id => id.Length > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: recent.Select(e => e.Person).Where(id => id.Length > 0).Distinct`

**赋值（含属性/字段和局部值）：**

- `d.Market.NewsDay` = `d.Day`
- `facts` += `"\n外汇报价表示1人民币兑换的外币数量；上涨表示人民币升值，下降表示人民币贬值。"`
