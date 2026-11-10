# CareerOpeningWorld.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`BF1DC6099D4CAF734FEA30D19B428C5C039811B866311A4BA43F4E48FBCC7061`。来源：[源码](../../CareerOpeningWorld.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerOpeningWorld`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-42ae29deaff7"></a>

## `NationalSpire.CareerOpeningWorld.Season — public int Season`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e0ce4b0e0311"></a>

## `NationalSpire.CareerOpeningWorld.Levels — public Dictionary<string, Dictionary<string,int>> Levels`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-483bf98835f7"></a>

## `NationalSpire.CareerOpeningWorld.ClubMode — public string ClubMode`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b27bdb5e6e94"></a>

## `NationalSpire.CareerOpeningWorld.ClubName — public string ClubName`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3bb98dae69db"></a>

## `NationalSpire.CareerOpeningWorld.ClubCountry — public string ClubCountry`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6b2539b06c99"></a>

## `NationalSpire.CareerOpeningWorld.ClubSponsor — public string ClubSponsor`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-72c0a4eae577"></a>

## `NationalSpire.CareerOpeningWorld.Prepare(NationalSpire.CareerData, System.Func<System.Threading.Tasks.Task>) — internal async Task Prepare(CareerData d, Func<Task> yieldFrame)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BeginNpcSetup(bool)`](NpcGenerationScreen.cs.md#symbol-b4785dd51d2b)；[`NationalSpire.Coop.CoopRuntime.Connect(bool, string, string, int, string, string, string, NationalSpire.NpcGenerationSetup?, System.Func<NationalSpire.CareerData, NationalSpire.CareerOpeningWorld, System.Threading.Tasks.Task>?)`](Coop/CoopRuntime.cs.md#symbol-c279dbe53a7e)

**调用：** [`NationalSpire.CareerEngine.SimulateNpcTraining(NationalSpire.CareerData, System.Random)`](CareerEngine.cs.md#symbol-81aa8470b51a)；[`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.CareerMarket.Advance(NationalSpire.CareerData)`](CareerMarket.cs.md#symbol-6039084ecec7)；[`NationalSpire.CareerMarket.Initialize(NationalSpire.CareerData)`](CareerMarket.cs.md#symbol-b3244730c7ae)；[`NationalSpire.CircuitWorld.StartSeason(NationalSpire.CareerData, bool)`](CircuitWorld.cs.md#symbol-845fab333acd)；[`NationalSpire.ClubOperations.Advance(NationalSpire.CareerData)`](ClubOperations.cs.md#symbol-213a7e731998)；[`NationalSpire.EsportsWorld.EndDay(NationalSpire.CareerData, int, bool)`](EsportsWorld.cs.md#symbol-ae784907b7fa)；[`NationalSpire.NationalDevelopment.Ensure(NationalSpire.CareerData)`](NationalDevelopment.cs.md#symbol-7b51466d6927)；[`NationalSpire.RandomEvents.Schedule(NationalSpire.CareerLifeState, int, string, int?)`](RandomEvents.cs.md#symbol-f546dd3643ba)；[`NationalSpire.SeasonCalendar.End(NationalSpire.CareerData)`](SeasonCalendar.cs.md#symbol-6b4c49a62324)；[`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-ee7b01d76b23)；[`NationalSpire.SeasonCeremony.Close(NationalSpire.CareerData)`](SeasonCeremony.cs.md#symbol-245a6f827582)；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Clear()`；`System.Diagnostics.Stopwatch.Restart()`；`System.Diagnostics.Stopwatch.StartNew()`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）；`System.Math.Clamp(int, int, int)`；`System.Random.Random(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PendingCeremonySeason`；`NationalSpire.CareerData.Posts`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.SimulateNpcTraining(NationalSpire.CareerData, System.Random)`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerLifeState.NextOfferDay`；`NationalSpire.CareerLifeState.NextProjectDay`；`NationalSpire.CareerLifeState.RandomEvents`；`NationalSpire.CareerMarket.Advance(NationalSpire.CareerData)`；`NationalSpire.CareerMarket.Initialize(NationalSpire.CareerData)`；`NationalSpire.CareerOpeningWorld.Levels`；`NationalSpire.CareerOpeningWorld.Season`；`NationalSpire.CircuitWorld.StartSeason(NationalSpire.CareerData, bool)`；`NationalSpire.ClubOperations.Advance(NationalSpire.CareerData)`；`NationalSpire.CommunityPost.AiPending`；`NationalSpire.CommunityPost.Day`；`NationalSpire.EsportsCareer.Nations`；`NationalSpire.EsportsWorld.EndDay(NationalSpire.CareerData, int, bool)`；`NationalSpire.NationalDevelopment.All`；`NationalSpire.NationalDevelopment.Ensure(NationalSpire.CareerData)`；`NationalSpire.NationalDevelopment.Indicator.Id`；`NationalSpire.NationalLegacy.Country`；`NationalSpire.NationalLegacy.ExtraProgress`；`NationalSpire.NationalLegacy.Indicators`；`NationalSpire.NationalLegacy.Progress`；`NationalSpire.RandomEvents.Schedule(NationalSpire.CareerLifeState, int, string, int?)`；`NationalSpire.SeasonCalendar.End(NationalSpire.CareerData)`；`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；`NationalSpire.SeasonCeremony.Close(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.SimulateNpcTraining(NationalSpire.CareerData, System.Random)`；输入表达式：`CareerEngine.SimulateNpcTraining(d, new Random(CareerEngine.StableHash($"{d.WorldId}:world:{d.Day}")))`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.SimulateNpcTraining(d, new Random(CareerEngine.StableHash($"{d.WorldId}:world:{d.Day}")));`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash($"{d.WorldId}:world:{d.Day}")`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.StableHash($"{d.WorldId}:world:{d.Day}")`
- `NationalSpire.CareerMarket.Advance(NationalSpire.CareerData)`；输入表达式：`CareerMarket.Advance(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMarket.Advance(d);`
- `NationalSpire.CareerMarket.Initialize(NationalSpire.CareerData)`；输入表达式：`CareerMarket.Initialize(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMarket.Initialize(d);`
- `NationalSpire.CircuitWorld.StartSeason(NationalSpire.CareerData, bool)`；输入表达式：`CircuitWorld.StartSeason(d, beforePlayerJoins: d.Season < Season)`；返回值紧邻使用处：`ExpressionStatementSyntax: CircuitWorld.StartSeason(d, beforePlayerJoins: d.Season < Season);`
- `NationalSpire.ClubOperations.Advance(NationalSpire.CareerData)`；输入表达式：`ClubOperations.Advance(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubOperations.Advance(d);`
- `NationalSpire.EsportsWorld.EndDay(NationalSpire.CareerData, int, bool)`；输入表达式：`EsportsWorld.EndDay(d, d.Day, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: EsportsWorld.EndDay(d, d.Day, false);`
- `NationalSpire.NationalDevelopment.Ensure(NationalSpire.CareerData)`；输入表达式：`NationalDevelopment.Ensure(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: NationalDevelopment.Ensure(d);`
- `NationalSpire.RandomEvents.Schedule(NationalSpire.CareerLifeState, int, string, int?)`；输入表达式：`RandomEvents.Schedule(d.Life, d.Day, d.WorldId)`；返回值紧邻使用处：`ExpressionStatementSyntax: RandomEvents.Schedule(d.Life, d.Day, d.WorldId);`
- `NationalSpire.SeasonCalendar.End(NationalSpire.CareerData)`；输入表达式：`SeasonCalendar.End(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Day == SeasonCalendar.End(d)`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.Start(d) + 1`
- `NationalSpire.SeasonCeremony.Close(NationalSpire.CareerData)`；输入表达式：`SeasonCeremony.Close(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: SeasonCeremony.Close(d);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`nation.ExtraProgress.Remove(i.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: nation.ExtraProgress.Remove(i.Id);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`nation.Progress.Remove(i.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: nation.Progress.Remove(i.Id);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`levels.TryGetValue(i.Id, out int level)`；返回值紧邻使用处：`IfStatementSyntax: if (levels.TryGetValue(i.Id, out int level)) { nation.Indicators[i.Id] = Math.Clamp(level,0,9); nation.Progress.Remove(i.Id); nation.ExtraProgress.Remove(i.Id); }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Levels.TryGetValue(nation.Country, out var levels)`；返回值紧邻使用处：`IfStatementSyntax: if (Levels.TryGetValue(nation.Country, out var levels))                 foreach (var i in NationalDevelopment.All)                     if (levels.TryGetValue(i.Id, out int level)) { nation.Indicators[i.Id] = Math.Clamp(level,0,9); nation.Progress.Remove(i.Id); nation.ExtraProgress.Remove(i.Id); }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Posts.Where(p => p.Day < d.Day)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var post in d.Posts.Where(p => p.Day < d.Day)) post.AiPending = false;`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`d.Life.RandomEvents.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Life.RandomEvents.Clear();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`d.Matches.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Matches.Clear();`
- `System.Diagnostics.Stopwatch.Restart()`；输入表达式：`frame.Restart()`；返回值紧邻使用处：`ExpressionStatementSyntax: frame.Restart();`
- `System.Diagnostics.Stopwatch.StartNew()`；输入表达式：`System.Diagnostics.Stopwatch.StartNew()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = System.Diagnostics.Stopwatch.StartNew()`
- `System.Func<TResult>.Invoke()`；输入表达式：`yieldFrame()`；返回值紧邻使用处：`AwaitExpressionSyntax: await yieldFrame()`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(level,0,9)`；返回值紧邻使用处：`AssignmentExpressionSyntax: nation.Indicators[i.Id] = Math.Clamp(level,0,9)`
- `System.Random.Random(int)`；输入表达式：`new Random(CareerEngine.StableHash($"{d.WorldId}:world:{d.Day}"))`；返回值紧邻使用处：`ArgumentSyntax: new Random(CareerEngine.StableHash($"{d.WorldId}:world:{d.Day}"))`

**赋值（含属性/字段和局部值）：**

- `d.Life.NextOfferDay` = `d.Day + 2`
- `d.Life.NextProjectDay` = `d.Day + 21`
- `d.PendingCeremonySeason` = `0`
- `nation.Indicators[i.Id]` = `Math.Clamp(level,0,9)`
- `post.AiPending` = `false`
