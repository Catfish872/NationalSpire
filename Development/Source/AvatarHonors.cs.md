# AvatarHonors.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`4F6961AC7E25897F4607E35196EB95F21C6E3F3D6F2B2DDE086722F98B9196B1`。来源：[源码](../../AvatarHonors.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.AvatarFrame`、`NationalSpire.AvatarIdentity`、`NationalSpire.AvatarHonors`、`NationalSpire.AvatarHonors.Ranking`。

字段、事件及初始值（源码原样）：

```csharp
public static readonly AvatarFrame[] Frames =
    [
        new("plain", "素色", "526b78", 0, "初始可用"),
        new("academy", "青训新秀", "66bcae", 1, "取得青训资格"),
        new("pro", "职业选手", "b5c7d8", 2, "取得职业资格"),
        new("international", "国际舞台", "75aee6", 3, "完成一场国际赛事对局"),
        new("ranked", "世界名将", "a8a5ed", 4, "进入世界积分榜前 32 名"),
        new("elite", "世界顶尖", "e7ba70", 5, "进入世界积分榜前 8 名"),
        new("quarter", "世界八强", "c194e9", 6, "获得世界总决赛八强或更高名次"),
        new("semi", "世界四强", "edc98b", 7, "获得世界总决赛四强或更高名次"),
        new("champion", "世界之冠", "ffe1a0", 8, "获得世界总决赛冠军")
    ];
public int Day, Season, Awards = -1;
public Dictionary<string, int> Places = [];
private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<CareerData, Ranking> Rankings = new();
```

<a id="symbol-234c7000b369"></a>

## `NationalSpire.AvatarIdentity.Oath — public bool Oath`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2b327dd7bff0"></a>

## `NationalSpire.AvatarIdentity.SelectedFrame — public string SelectedFrame`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e379de45a23f"></a>

## `NationalSpire.AvatarIdentity.DisplayFrame — public AvatarFrame DisplayFrame`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.NpcAvatarFrames.Find(string)`](NpcAvatarFrames.cs.md#symbol-f789cabb01cd)

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarIdentity.Frame`；`NationalSpire.AvatarIdentity.SelectedFrame`；`NationalSpire.NpcAvatarFrames.Find(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.NpcAvatarFrames.Find(string)`；输入表达式：`NpcAvatarFrames.Find(SelectedFrame)`；返回值紧邻使用处：`BinaryExpressionSyntax: NpcAvatarFrames.Find(SelectedFrame) ?? Frame`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e08b9d67d46f"></a>

## `NationalSpire.AvatarIdentity.UseOathFrame — public bool UseOathFrame`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarIdentity.Oath`；`NationalSpire.AvatarIdentity.SelectedFrame`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-464394b98e25"></a>

## `NationalSpire.AvatarIdentity.Description — public string Description`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarFrame.Name`；`NationalSpire.AvatarIdentity.Ascension`；`NationalSpire.AvatarIdentity.DisplayFrame`；`NationalSpire.AvatarIdentity.Proof`；`NationalSpire.AvatarIdentity.Role`；`NationalSpire.AvatarIdentity.UseOathFrame`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a504c5d98870"></a>

## `NationalSpire.AvatarHonors.International(string) — private static bool International(string kind)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AvatarHonors.Earned(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-c5235b150918)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9fa8fce765cc"></a>

## `NationalSpire.AvatarHonors.InvalidateRankings(NationalSpire.CareerData) — internal static void InvalidateRankings(CareerData data)`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitLedger.Settle(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`](CircuitLedger.cs.md#symbol-8ff7b69864e0)

**调用：** `System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.Remove(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarHonors.Rankings`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.Remove(TKey)`；输入表达式：`Rankings.Remove(data)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Rankings.Remove(data)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-72230b2d2147"></a>

## `NationalSpire.AvatarHonors.Rank(NationalSpire.CareerData, string) — private static int Rank(CareerData d, string id)`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AvatarHonors.Earned(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-c5235b150918)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.GetOrCreateValue(TKey)`

**字段、属性、事件及方法组引用：** `(string Id, int Points).Id`；`(string Id, int Points).Points`；`(string Id, int Rank).Id`；`(string Id, int Rank).Rank`；`NationalSpire.AvatarHonors.Ranking.Awards`；`NationalSpire.AvatarHonors.Ranking.Day`；`NationalSpire.AvatarHonors.Ranking.Places`；`NationalSpire.AvatarHonors.Ranking.Season`；`NationalSpire.AvatarHonors.Rankings`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.CircuitAward.PersonId`；`NationalSpire.CircuitAward.Points`；`NationalSpire.CircuitAward.Season`；`NationalSpire.EsportsCareer.CircuitAwards`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Esports.CircuitAwards.Where(a => a.Points > 0 && a.Season > d.Season - 4 && a.Season <= d.Season)                  .GroupBy(a => a.PersonId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.CircuitAwards.Where(a => a.Points > 0 && a.Season > d.Season - 4 && a.Season <= d.Season)                  .GroupBy(a => a.PersonId).Select`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Esports.CircuitAwards.Where(a => a.Points > 0 && a.Season > d.Season - 4 && a.Season <= d.Season)                  .GroupBy(a => a.PersonId).Select(g => (Id: g.Key, Points: g.OrderByDescending(a => a.Points).Take(6).Sum(a => a.Points)))                  .OrderByDescending(p => p.Points)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.CircuitAwards.Where(a => a.Points > 0 && a.Season > d.Season - 4 && a.Season <= d.Season)                  .GroupBy(a => a.PersonId).Select(g => (Id: g.Key, Points: g.OrderByDescending(a => a.Points).Take(6).Sum(a => a.Points)))                  .OrderByDescending(p => p.Points).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`g.OrderByDescending(a => a.Points)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.OrderByDescending(a => a.Points).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`scores.Select((p, i) => (p.Id, Rank: i + 1))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: scores.Select((p, i) => (p.Id, Rank: i + 1)).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.Esports.CircuitAwards.Where(a => a.Points > 0 && a.Season > d.Season - 4 && a.Season <= d.Season)                  .GroupBy(a => a.PersonId).Select(g => (Id: g.Key, Points: g.OrderByDescending(a => a.Points).Take(6).Sum(a => a.Points)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.CircuitAwards.Where(a => a.Points > 0 && a.Season > d.Season - 4 && a.Season <= d.Season)                  .GroupBy(a => a.PersonId).Select(g => (Id: g.Key, Points: g.OrderByDescending(a => a.Points).Take(6).Sum(a => a.Points)))                  .OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`g.OrderByDescending(a => a.Points).Take(6).Sum(a => a.Points)`；返回值紧邻使用处：`ArgumentSyntax: Points: g.OrderByDescending(a => a.Points).Take(6).Sum(a => a.Points)`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`g.OrderByDescending(a => a.Points).Take(6)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.OrderByDescending(a => a.Points).Take(6).Sum`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`scores.Select((p, i) => (p.Id, Rank: i + 1)).ToDictionary(p => p.Id, p => p.Rank)`；返回值紧邻使用处：`AssignmentExpressionSyntax: cache.Places = scores.Select((p, i) => (p.Id, Rank: i + 1)).ToDictionary(p => p.Id, p => p.Rank)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Esports.CircuitAwards.Where(a => a.Points > 0 && a.Season > d.Season - 4 && a.Season <= d.Season)                  .GroupBy(a => a.PersonId).Select(g => (Id: g.Key, Points: g.OrderByDescending(a => a.Points).Take(6).Sum(a => a.Points)))                  .OrderByDescending(p => p.Points).ThenBy(p => p.Id, StringComparer.Ordinal).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.CircuitAwards.Where(a => a.Points > 0 && a.Season > d.Season - 4 && a.Season <= d.Season)                  .GroupBy(a => a.PersonId).Select(g => (Id: g.Key, Points: g.OrderByDescending(a => a.Points).Take(6).Sum(a => a.Points)))                  .OrderByDescending(p => p.Points).ThenBy(p => p.Id, StringComparer.Ordinal).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.CircuitAwards.Where(a => a.Points > 0 && a.Season > d.Season - 4 && a.Season <= d.Season)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.CircuitAwards.Where(a => a.Points > 0 && a.Season > d.Season - 4 && a.Season <= d.Season)                  .GroupBy`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`cache.Places.GetValueOrDefault(id, int.MaxValue)`；返回值紧邻使用处：`ReturnStatementSyntax: return cache.Places.GetValueOrDefault(id, int.MaxValue);`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`d.Esports.CircuitAwards.Where(a => a.Points > 0 && a.Season > d.Season - 4 && a.Season <= d.Season)                  .GroupBy(a => a.PersonId).Select(g => (Id: g.Key, Points: g.OrderByDescending(a => a.Points).Take(6).Sum(a => a.Points)))                  .OrderByDescending(p => p.Points).ThenBy(p => p.Id, StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.CircuitAwards.Where(a => a.Points > 0 && a.Season > d.Season - 4 && a.Season <= d.Season)                  .GroupBy(a => a.PersonId).Select(g => (Id: g.Key, Points: g.OrderByDescending(a => a.Points).Take(6).Sum(a => a.Points)))                  .OrderByDescending(p => p.Points).ThenBy(p => p.Id, StringComparer.Ordinal).ToList`
- `System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.GetOrCreateValue(TKey)`；输入表达式：`Rankings.GetOrCreateValue(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Rankings.GetOrCreateValue(d)`

**赋值（含属性/字段和局部值）：**

- `cache.Awards` = `d.Esports.CircuitAwards.Count`
- `cache.Day` = `d.Day`
- `cache.Places` = `scores.Select((p, i) => (p.Id, Rank: i + 1)).ToDictionary(p => p.Id, p => p.Rank)`
- `cache.Season` = `d.Season`

<a id="symbol-c5235b150918"></a>

## `NationalSpire.AvatarHonors.Earned(NationalSpire.CareerData, string) — public static Dictionary<string, string> Earned(CareerData d, string id)`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AvatarHonors.Capture(NationalSpire.CareerData)`](AvatarHonors.cs.md#symbol-d015fb4d8249)；[`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-5207a1627331)；[`NationalSpire.NpcAvatarFrames.Locked(NationalSpire.CareerData, string, string)`](NpcAvatarFrames.cs.md#symbol-312d47fec9fa)

**调用：** [`NationalSpire.AvatarHonors.International(string)`](AvatarHonors.cs.md#symbol-a504c5d98870)；[`NationalSpire.AvatarHonors.Rank(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-72230b2d2147)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarHonors.International(string)`；`NationalSpire.AvatarHonors.Rank(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerResult.Kind`；`NationalSpire.CareerResult.Outcome`；`NationalSpire.CircuitAward.Event`；`NationalSpire.CircuitAward.Kind`；`NationalSpire.CircuitAward.PersonId`；`NationalSpire.CircuitAward.Place`；`NationalSpire.CircuitAward.Season`；`NationalSpire.CircuitAward.Stage`；`NationalSpire.EsportsCareer.CircuitAwards`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsCareer.License`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.Honors`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.Walkover`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AvatarHonors.International(string)`；输入表达式：`International(c.Kind)`；返回值紧邻使用处：`BinaryExpressionSyntax: International(c.Kind) && c.Fixtures.Any(f => f.Finished && !f.Walkover && (f.HomeId == id || f.AwayId == id))`
- `NationalSpire.AvatarHonors.International(string)`；输入表达式：`International(r.Kind)`；返回值紧邻使用处：`BinaryExpressionSyntax: id == "player" && International(r.Kind)`
- `NationalSpire.AvatarHonors.Rank(NationalSpire.CareerData, string)`；输入表达式：`Rank(d, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Rank(d, id)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Person(d, id)`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.Honors)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.Honors)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, string> { ["plain"] = "" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, string> { ["plain"] = "" }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`；输入表达式：`result.TryAdd("champion", proof)`；返回值紧邻使用处：`ExpressionStatementSyntax: result.TryAdd("champion", proof);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`；输入表达式：`result.TryAdd("quarter", proof)`；返回值紧邻使用处：`ExpressionStatementSyntax: result.TryAdd("quarter", proof);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`；输入表达式：`result.TryAdd("semi", proof)`；返回值紧邻使用处：`ExpressionStatementSyntax: result.TryAdd("semi", proof);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Any(f => f.Finished && !f.Walkover && (f.HomeId == id || f.AwayId == id))`；返回值紧邻使用处：`BinaryExpressionSyntax: International(c.Kind) && c.Fixtures.Any(f => f.Finished && !f.Walkover && (f.HomeId == id || f.AwayId == id))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Any(c => International(c.Kind) && c.Fixtures.Any(f => f.Finished && !f.Walkover && (f.HomeId == id || f.AwayId == id)))`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Esports.Competitions.Any(c => International(c.Kind) && c.Fixtures.Any(f => f.Finished && !f.Walkover && (f.HomeId == id || f.AwayId == id))) || d.Results.Any(r => id == "player" && International(r.Kind) && r.Outcome != "退赛")`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Results.Any(r => id == "player" && International(r.Kind) && r.Outcome != "退赛")`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Esports.Competitions.Any(c => International(c.Kind) && c.Fixtures.Any(f => f.Finished && !f.Walkover && (f.HomeId == id || f.AwayId == id))) || d.Results.Any(r => id == "player" && International(r.Kind) && r.Outcome != "退赛")`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Esports.CircuitAwards.Where(a => a.PersonId == id && a.Kind == "worldfinal" && a.Stage > 0 && a.Stage <= 8).OrderBy(a => a.Season)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var award in d.Esports.CircuitAwards.Where(a => a.PersonId == id && a.Kind == "worldfinal" && a.Stage > 0 && a.Stage <= 8).OrderBy(a => a.Season)) { string proof = $"第 {award.Season} 赛季 · {award.Event} · {award.Place}"; result.TryAdd("quarter", proof); if (award.Stage <= 4) result.TryAdd("semi", proof); if (award.Place == "冠军") result.TryAdd("champion", proof); }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.CircuitAwards.Where(a => a.PersonId == id && a.Kind == "worldfinal" && a.Stage > 0 && a.Stage <= 8)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.CircuitAwards.Where(a => a.PersonId == id && a.Kind == "worldfinal" && a.Stage > 0 && a.Stage <= 8).OrderBy`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`d.HumanIds.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: id == "player" || d.HumanIds.Contains(id)`

**赋值（含属性/字段和局部值）：**

- `["plain"]` = `""`
- `result["academy"]` = `"已取得青训资格"`
- `result["elite"]` = `rank <= 8 ? $"第 {d.Season} 赛季 · 世界积分榜第 {rank} 名" : "世界顶尖选手"`
- `result["international"]` = `season`
- `result["pro"]` = `"已取得职业资格"`
- `result["ranked"]` = `$"第 {d.Season} 赛季 · 世界积分榜第 {rank} 名"`

<a id="symbol-d015fb4d8249"></a>

## `NationalSpire.AvatarHonors.Capture(NationalSpire.CareerData) — public static void Capture(CareerData d)`

来源：源码第 74 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.CreateNew(bool, int)`](CareerEngine.cs.md#symbol-63d93017946a)；[`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`](CareerEngine.cs.md#symbol-bdca24d9114c)；[`NationalSpire.CareerEngine.MoveToNextDay(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-3836a38a7da9)；[`NationalSpire.CareerEngine.NormalizeRoster(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-eb11b96e7400)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)；[`NationalSpire.Coop.CoopRules.RefreshPeople(NationalSpire.Coop.CoopWorld)`](Coop/CoopRules.cs.md#symbol-8025e01818d7)

**调用：** [`NationalSpire.AvatarHonors.Earned(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-c5235b150918)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarHonors.Earned(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.AvatarFrames`；`NationalSpire.CareerData.AvatarHighestClear`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerResult.Ascension`；`NationalSpire.CareerResult.OfficialAscensionVerified`；`NationalSpire.CareerResult.PlayedAscension`；`NationalSpire.CareerResult.Win`；`NationalSpire.EsportsCareer.BestClear`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AvatarHonors.Earned(NationalSpire.CareerData, string)`；输入表达式：`Earned(d, "player")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var pair in Earned(d, "player")) d.AvatarFrames.TryAdd(pair.Key, pair.Value);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryAdd(TKey, TValue)`；输入表达式：`d.AvatarFrames.TryAdd(pair.Key, pair.Value)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.AvatarFrames.TryAdd(pair.Key, pair.Value);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Results.Where(r => r.Win)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var r in d.Results.Where(r => r.Win))          {              int ascension = r.PlayedAscension ?? (r.OfficialAscensionVerified ? r.Ascension : -1);              if (ascension is >= 0 and <= 10) d.AvatarHighestClear = Math.Max(d.AvatarHighestClear, ascension);          }`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(d.AvatarHighestClear, ascension)`；返回值紧邻使用处：`AssignmentExpressionSyntax: d.AvatarHighestClear = Math.Max(d.AvatarHighestClear, ascension)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(d.AvatarHighestClear, d.Esports.BestClear)`；返回值紧邻使用处：`AssignmentExpressionSyntax: d.AvatarHighestClear = Math.Max(d.AvatarHighestClear, d.Esports.BestClear)`

**赋值（含属性/字段和局部值）：**

- `d.AvatarHighestClear` = `Math.Max(d.AvatarHighestClear, ascension)`
- `d.AvatarHighestClear` = `Math.Max(d.AvatarHighestClear, d.Esports.BestClear)`

<a id="symbol-ebc9b671821b"></a>

## `NationalSpire.AvatarHonors.Role(NationalSpire.CareerData, string) — public static string Role(CareerData d, string id)`

来源：源码第 85 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-5207a1627331)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Identities`；`NationalSpire.CareerPerson.Role`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Person(d, id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`p.Identities.Contains(role)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Role == role || p.Identities.Contains(role)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5207a1627331"></a>

## `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string) — public static AvatarIdentity ForPerson(CareerData d, string id)`

来源：源码第 93 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AvatarHonors.Byline(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-3d000083d4aa)；[`NationalSpire.CareerScreen.AddProfileCards(NationalSpire.CareerData, Godot.GridContainer, System.Collections.Generic.IEnumerable<NationalSpire.CareerPerson>)`](CareerListCache.cs.md#symbol-13c7d56a75c4)；[`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`](CareerAvatars.cs.md#symbol-9f2c4623a902)；[`NationalSpire.CareerScreen.AvatarWardrobe(NationalSpire.CareerData, Godot.VBoxContainer)`](CareerAvatars.cs.md#symbol-a00951e0b13d)；[`NationalSpire.CareerScreen.NpcAvatarFramePicker(NationalSpire.CareerData, string)`](NpcAvatarFrameScreen.cs.md#symbol-ca2807c0402f)；[`NationalSpire.CareerScreen.OpenAvatarSettings(NationalSpire.CareerData, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>?, string, NationalSpire.AvatarArt?)`](AvatarScreen.cs.md#symbol-368e97fdd27f)；[`NationalSpire.CareerScreen.OpenCharacterCardCore(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?, NationalSpire.CharacterDesignPackage.Imported?)`](CharacterCardScreen.cs.md#symbol-c2fe452ad056)；[`NationalSpire.CareerScreen.PlayerBanner(NationalSpire.CareerData, string)`](BroadcastVisuals.cs.md#symbol-936e32073293)；[`NationalSpire.CareerScreen.ShowPrivateListRows()`](PrivateListRows.cs.md#symbol-a42f68b15faf)；[`NationalSpire.Coop.CoopLive.Update()`](Coop/CoopLive.cs.md#symbol-fe745d15ee63)；[`NationalSpire.Coop.CoopLive.UpdateMap(NationalSpire.Coop.CoopRun, MegaCrit.Sts2.Core.Map.ActMap, int)`](Coop/CoopLive.cs.md#symbol-3ddf0280ec69)；[`NationalSpire.Coop.CoopScreen.WaitingRoom(NationalSpire.Coop.CoopWorld)`](Coop/CoopScreen.cs.md#symbol-b46abec89d85)；[`NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`](LiveRunBridge.cs.md#symbol-c7a514513ce3)；[`NationalSpire.LiveRunBridge.UpdateMap(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, double)`](LiveRunBridge.cs.md#symbol-cedfec15a9e5)；[`RefreshPictures(Godot.Node)`](NpcAvatarFrameScreen.cs.md#symbol-acaa451c0109)

**调用：** [`NationalSpire.AvatarHonors.Earned(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-c5235b150918)；[`NationalSpire.AvatarHonors.Role(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-ebc9b671821b)；`NationalSpire.AvatarIdentity.AvatarIdentity(NationalSpire.AvatarFrame, int, string, string)`；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.NpcAvatarFrames.Find(string)`](NpcAvatarFrames.cs.md#symbol-f789cabb01cd)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；[`NationalSpire.RelationshipPresentation.OathAppearance(NationalSpire.PrivateRelation?)`](RelationshipPresentation.cs.md#symbol-bac5ded19066)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarFrame.Grade`；`NationalSpire.AvatarFrame.Id`；`NationalSpire.AvatarHonors.Earned(NationalSpire.CareerData, string)`；`NationalSpire.AvatarHonors.Frames`；`NationalSpire.AvatarHonors.Role(NationalSpire.CareerData, string)`；`NationalSpire.AvatarIdentity.Oath`；`NationalSpire.AvatarIdentity.SelectedFrame`；`NationalSpire.CareerData.AvatarFrames`；`NationalSpire.CareerData.AvatarHighestClear`；`NationalSpire.CareerData.HumanClears`；`NationalSpire.CareerData.HumanFrames`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.SelectedAvatarFrame`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.PrivateHighestClear`；`NationalSpire.CareerPerson.Wins`；`NationalSpire.NpcAvatarFrames.Find(string)`；`NationalSpire.PrivateMailbox.NpcAvatarFrames`；`NationalSpire.PrivateMailbox.Relations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.RelationshipPresentation.OathAppearance(NationalSpire.PrivateRelation?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AvatarHonors.Earned(NationalSpire.CareerData, string)`；输入表达式：`Earned(d, id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: id == "player" || d.HumanIds.Contains(id) ? d.AvatarFrames : Earned(d, id)`
- `NationalSpire.AvatarHonors.Role(NationalSpire.CareerData, string)`；输入表达式：`Role(d, id)`；返回值紧邻使用处：`ArgumentSyntax: Role(d, id)`
- `NationalSpire.AvatarIdentity.AvatarIdentity(NationalSpire.AvatarFrame, int, string, string)`；输入表达式：`new(frame, highest, Role(d, id), earned.GetValueOrDefault(frame.Id, "")) { Oath = id != "player" && !d.HumanIds.Contains(id) && RelationshipPresentation.OathAppearance(PrivateMessages.Mailbox(d).Relations.GetValueOrDefault(id)), SelectedFrame = id != "player" && !d.HumanIds.Contains(id) && PrivateMessages.Mailbox(d).NpcAvatarFrames.TryGetValue(id, out string? choice) && NpcAvatarFrames.Find(choice) is { } chosen && (chosen.Grade == 0 || earned.ContainsKey(choice)) && (choice != "oath" || RelationshipPresentation.OathAppearance(PrivateMessages.Mailbox(d).Relations.GetValueOrDefault(id))) ? choice : "" }`；返回值紧邻使用处：`ReturnStatementSyntax: return new(frame, highest, Role(d, id), earned.GetValueOrDefault(frame.Id, "")) { Oath = id != "player" && !d.HumanIds.Contains(id) && RelationshipPresentation.OathAppearance(PrivateMessages.Mailbox(d).Relations.GetValueOrDefault(id)), SelectedFrame = id != "player" && !d.HumanIds.Contains(id) && PrivateMessages.Mailbox(d).NpcAvatarFrames.TryGetValue(id, out string? choice) && NpcAvatarFrames.Find(choice) is { } chosen && (chosen.Grade == 0 || earned.ContainsKey(choice)) && (choice != "oath" || RelationshipPresentation.OathAppearance(PrivateMessages.Mailbox(d).Relations.GetValueOrDefault(id))) ? choice : "" };`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Person(d, id)`
- `NationalSpire.NpcAvatarFrames.Find(string)`；输入表达式：`NpcAvatarFrames.Find(choice)`；返回值紧邻使用处：`IsPatternExpressionSyntax: NpcAvatarFrames.Find(choice) is { } chosen`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(d).Relations`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(d).NpcAvatarFrames`
- `NationalSpire.RelationshipPresentation.OathAppearance(NationalSpire.PrivateRelation?)`；输入表达式：`RelationshipPresentation.OathAppearance(PrivateMessages.Mailbox(d).Relations.GetValueOrDefault(id))`；返回值紧邻使用处：`BinaryExpressionSyntax: id != "player" && !d.HumanIds.Contains(id) && RelationshipPresentation.OathAppearance(PrivateMessages.Mailbox(d).Relations.GetValueOrDefault(id))`
- `NationalSpire.RelationshipPresentation.OathAppearance(NationalSpire.PrivateRelation?)`；输入表达式：`RelationshipPresentation.OathAppearance(PrivateMessages.Mailbox(d).Relations.GetValueOrDefault(id))`；返回值紧邻使用处：`BinaryExpressionSyntax: choice != "oath" || RelationshipPresentation.OathAppearance(PrivateMessages.Mailbox(d).Relations.GetValueOrDefault(id))`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`earned.ContainsKey(choice)`；返回值紧邻使用处：`BinaryExpressionSyntax: chosen.Grade == 0 || earned.ContainsKey(choice)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`earned.ContainsKey(f.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: f => earned.ContainsKey(f.Id)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`earned.ContainsKey(selection)`；返回值紧邻使用处：`BinaryExpressionSyntax: selection != "auto" && earned.ContainsKey(selection)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`PrivateMessages.Mailbox(d).NpcAvatarFrames.TryGetValue(id, out string? choice)`；返回值紧邻使用处：`BinaryExpressionSyntax: id != "player" && !d.HumanIds.Contains(id) && PrivateMessages.Mailbox(d).NpcAvatarFrames.TryGetValue(id, out string? choice)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`d.HumanClears.TryGetValue(id, out int cleared)`；返回值紧邻使用处：`ConditionalExpressionSyntax: d.HumanClears.TryGetValue(id, out int cleared) ? cleared : person is { Wins: > 0 } ? person.MaxAscension : -1`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`Frames.FirstOrDefault(f => f.Id == selection)`；返回值紧邻使用处：`BinaryExpressionSyntax: Frames.FirstOrDefault(f => f.Id == selection) ?? best`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`Frames.LastOrDefault(f => earned.ContainsKey(f.Id))`；返回值紧邻使用处：`BinaryExpressionSyntax: Frames.LastOrDefault(f => earned.ContainsKey(f.Id)) ?? Frames[0]`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`PrivateMessages.Mailbox(d).Relations.GetValueOrDefault(id)`；返回值紧邻使用处：`ArgumentSyntax: PrivateMessages.Mailbox(d).Relations.GetValueOrDefault(id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`d.HumanFrames.GetValueOrDefault(id, "auto")`；返回值紧邻使用处：`ConditionalExpressionSyntax: id == "player" ? d.SelectedAvatarFrame : d.HumanFrames.GetValueOrDefault(id, "auto")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`earned.GetValueOrDefault(frame.Id, "")`；返回值紧邻使用处：`ArgumentSyntax: earned.GetValueOrDefault(frame.Id, "")`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`d.HumanIds.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: id == "player" || d.HumanIds.Contains(id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`d.HumanIds.Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.HumanIds.Contains(id)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(highest, person.PrivateHighestClear)`；返回值紧邻使用处：`AssignmentExpressionSyntax: highest = Math.Max(highest, person.PrivateHighestClear)`

**赋值（含属性/字段和局部值）：**

- `Oath` = `id != "player" && !d.HumanIds.Contains(id) && RelationshipPresentation.OathAppearance(PrivateMessages.Mailbox(d).Relations.GetValueOrDefault(id))`
- `SelectedFrame` = `id != "player" && !d.HumanIds.Contains(id) && PrivateMessages.Mailbox(d).NpcAvatarFrames.TryGetValue(id, out string? choice) && NpcAvatarFrames.Find(choice) is { } chosen && (chosen.Grade == 0 || earned.ContainsKey(choice)) && (choice != "oath" || RelationshipPresentation.OathAppearance(PrivateMessages.Mailbox(d).Relations.GetValueOrDefault(id))) ? choice : ""`
- `highest` = `Math.Max(highest, person.PrivateHighestClear)`

<a id="symbol-0a58a1c49eb1"></a>

## `NationalSpire.AvatarHonors.Select(NationalSpire.CareerData, string) — public static bool Select(CareerData d, string frame)`

来源：源码第 110 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ChooseFrame(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-5700a0d050b5)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarFrame.Id`；`NationalSpire.AvatarHonors.Frames`；`NationalSpire.CareerData.AvatarFrames`；`NationalSpire.CareerData.SelectedAvatarFrame`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`d.AvatarFrames.ContainsKey(frame)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.AvatarFrames.ContainsKey(frame)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`Frames.Any(f => f.Id == frame)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Frames.Any(f => f.Id == frame)`

**赋值（含属性/字段和局部值）：**

- `d.SelectedAvatarFrame` = `frame`

<a id="symbol-3d000083d4aa"></a>

## `NationalSpire.AvatarHonors.Byline(NationalSpire.CareerData, string) — public static string Byline(CareerData d, string id)`

来源：源码第 115 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-5207a1627331)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarFrame.Grade`；`NationalSpire.AvatarFrame.Id`；`NationalSpire.AvatarFrame.Name`；`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.AvatarIdentity.Frame`；`NationalSpire.AvatarIdentity.Role`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Role`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`ForPerson(d, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ForPerson(d, id)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.DisplayName(d, id) + "  |  "`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CareerEngine.Person(d, id)?.Role`

**赋值（含属性/字段和局部值）：**

- `title` += `" · " + (identity.Frame.Id == "pro" && CareerEngine.Person(d, id)?.Role == "退役选手" ? "退役选手" : identity.Frame.Name)`
