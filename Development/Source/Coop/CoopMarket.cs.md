# Coop/CoopMarket.cs

[返回文件依赖索引](../../SOURCE_MAP.md)

源码 SHA-256：`5E36F834986FC04DB7B37FBEBE9DAB533F285CEE30F895A0A125761C74B18720`。来源：[源码](../../../Coop/CoopMarket.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Coop.CoopRules`、`NationalSpire.Coop.CoopCoordinator`、`NationalSpire.Coop.CoopCoordinator.MarketQuery`、`NationalSpire.Coop.CoopCoordinator.MarketAnswer`。

字段、事件及初始值（源码原样）：

```csharp
private readonly Dictionary<string, TaskCompletionSource<MarketAnswer>> marketQueries = [];
```

<a id="symbol-6aa505a8b0a6"></a>

## `NationalSpire.Coop.CoopRules.InspectMarket(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.MarketInspection) — public static MarketInspectionResult InspectMarket(CoopWorld world, ulong memberId, MarketInspection request)`

来源：源码第 5 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.InspectMarket(NationalSpire.MarketInspection)`](CoopMarket.cs.md#symbol-fa87d36508d0)；[`NationalSpire.Coop.CoopCoordinator.ReceiveMarket(ulong, NationalSpire.Coop.CoopWire)`](CoopMarket.cs.md#symbol-1d6c27a5f526)

**调用：** [`NationalSpire.MarketClearing.Inspect(NationalSpire.CareerData, NationalSpire.MarketInspection)`](../MarketClearing.cs.md#symbol-d078c0ca2b29)；`NationalSpire.CareerData.CareerData()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Market`；`NationalSpire.CareerData.TradingAccounts`；`NationalSpire.CareerLifeState.Trading`；`NationalSpire.Coop.CoopMember.Life`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.MarketClearing.Inspect(NationalSpire.CareerData, NationalSpire.MarketInspection)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerData.CareerData()`；输入表达式：`new CareerData { Market = world.World.Market, Life = member.Life,              TradingAccounts = () => world.Members.Select(m => m.Life.Trading).ToArray() }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CareerData { Market = world.World.Market, Life = member.Life,              TradingAccounts = () => world.Members.Select(m => m.Life.Trading).ToArray() }`
- `NationalSpire.MarketClearing.Inspect(NationalSpire.CareerData, NationalSpire.MarketInspection)`；输入表达式：`MarketClearing.Inspect(data, request)`；返回值紧邻使用处：`ReturnStatementSyntax: return MarketClearing.Inspect(data, request);`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`world.Members.Select(m => m.Life.Trading)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: world.Members.Select(m => m.Life.Trading).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`world.Members.Single(m => m.SteamId == memberId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = world.Members.Single(m => m.SteamId == memberId)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`world.Members.Select(m => m.Life.Trading).ToArray()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => world.Members.Select(m => m.Life.Trading).ToArray()`

**赋值（含属性/字段和局部值）：**

- `Life` = `member.Life`
- `Market` = `world.World.Market`
- `TradingAccounts` = `() => world.Members.Select(m => m.Life.Trading).ToArray()`

<a id="symbol-0d9508e5083b"></a>

## `NationalSpire.Coop.CoopRules.InitializeMarket(NationalSpire.Coop.CoopWorld) — public static void InitializeMarket(CoopWorld world)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.CoopCoordinator(NationalSpire.Coop.ICoopTransport, NationalSpire.Coop.CoopStorage, string, string, string, System.Collections.Generic.IReadOnlySet<string>, NationalSpire.Coop.CoopStorage.Checkpoint?)`](CoopCoordinator.cs.md#symbol-778097f34ec3)

**调用：** [`NationalSpire.CareerMarket.Initialize(NationalSpire.CareerData)`](../CareerMarket.cs.md#symbol-b3244730c7ae)；[`NationalSpire.Coop.CoopRules.BindMarket(NationalSpire.Coop.CoopWorld)`](CoopMarket.cs.md#symbol-b6088377cb72)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMarket.Initialize(NationalSpire.CareerData)`；`NationalSpire.Coop.CoopRules.BindMarket(NationalSpire.Coop.CoopWorld)`；`NationalSpire.Coop.CoopWorld.World`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMarket.Initialize(NationalSpire.CareerData)`；输入表达式：`CareerMarket.Initialize(world.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMarket.Initialize(world.World);`
- `NationalSpire.Coop.CoopRules.BindMarket(NationalSpire.Coop.CoopWorld)`；输入表达式：`BindMarket(world)`；返回值紧邻使用处：`ExpressionStatementSyntax: BindMarket(world);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a60daf1be116"></a>

## `NationalSpire.Coop.CoopRules.Trade(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.MarketOrder) — private static string? Trade(CoopWorld transaction, CoopMember member, MarketOrder order)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** [`NationalSpire.CareerMarket.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`](../CareerMarket.cs.md#symbol-6b9ac5b0686c)；`NationalSpire.CareerData.CareerData()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Market`；`NationalSpire.CareerData.MarketAccounts`；`NationalSpire.CareerData.TradingAccounts`；`NationalSpire.CareerMarket.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`；`NationalSpire.Coop.CoopMember.Credits`；`NationalSpire.Coop.CoopMember.Life`；`NationalSpire.Coop.CoopWorld.World`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerData.CareerData()`；输入表达式：`new CareerData { Day = transaction.World.Day, Market = transaction.World.Market, Credits = member.Credits, Life = member.Life,              MarketAccounts = transaction.World.MarketAccounts, TradingAccounts = transaction.World.TradingAccounts }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CareerData { Day = transaction.World.Day, Market = transaction.World.Market, Credits = member.Credits, Life = member.Life,              MarketAccounts = transaction.World.MarketAccounts, TradingAccounts = transaction.World.TradingAccounts }`
- `NationalSpire.CareerMarket.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`；输入表达式：`CareerMarket.Trade(data, order)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerMarket.Trade(data, order)`

**赋值（含属性/字段和局部值）：**

- `Credits` = `member.Credits`
- `Day` = `transaction.World.Day`
- `Life` = `member.Life`
- `Market` = `transaction.World.Market`
- `MarketAccounts` = `transaction.World.MarketAccounts`
- `member.Credits` = `data.Credits`
- `TradingAccounts` = `transaction.World.TradingAccounts`

<a id="symbol-b6088377cb72"></a>

## `NationalSpire.Coop.CoopRules.BindMarket(NationalSpire.Coop.CoopWorld) — private static void BindMarket(CoopWorld world)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](CoopRules.cs.md#symbol-71eae0adc0d0)；[`NationalSpire.Coop.CoopRules.InitializeMarket(NationalSpire.Coop.CoopWorld)`](CoopMarket.cs.md#symbol-0d9508e5083b)；[`NationalSpire.Coop.CoopRules.Settle(NationalSpire.Coop.CoopWorld, string, bool, bool, int, double, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer>, System.Collections.Generic.Dictionary<ulong, NationalSpire.CareerResult>?, bool, bool, bool)`](CoopRules.cs.md#symbol-926ebe8770ca)

**调用：** [`NationalSpire.CareerMarket.Accounts(NationalSpire.MarketState, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, int)`](../CareerMarket.cs.md#symbol-81ec5ad63c25)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Market`；`NationalSpire.CareerData.MarketAccounts`；`NationalSpire.CareerData.MarketSponsors`；`NationalSpire.CareerData.TradingAccounts`；`NationalSpire.CareerLifeState.Trading`；`NationalSpire.CareerMarket.Accounts(NationalSpire.MarketState, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, int)`；`NationalSpire.Coop.CoopMember.Life`；`NationalSpire.Coop.CoopMember.PersonId`；`NationalSpire.Coop.CoopMember.Sponsors`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopRun.Characters`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.SponsorContract.TargetId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMarket.Accounts(NationalSpire.MarketState, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, int)`；输入表达式：`CareerMarket.Accounts(data.Market, world.Members.Select(member => member.Life.Trading).ToArray(), day)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMarket.Accounts(data.Market, world.Members.Select(member => member.Life.Trading).ToArray(), day);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`world.Run.Characters.ContainsKey(m.SteamId)`；返回值紧邻使用处：`BinaryExpressionSyntax: world.Run == null || world.Run.Characters.ContainsKey(m.SteamId)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`world.Members.Select(m => m.Life.Trading)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: world.Members.Select(m => m.Life.Trading).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`world.Members.Select(member => member.Life.Trading)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: world.Members.Select(member => member.Life.Trading).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`world.Members              .Where(m => id == m.PersonId || id == "player" && (world.Run == null || world.Run.Characters.ContainsKey(m.SteamId)))              .SelectMany(m => m.Sponsors.Where(s => s.TargetId == "player"))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => world.Members              .Where(m => id == m.PersonId || id == "player" && (world.Run == null || world.Run.Characters.ContainsKey(m.SteamId)))              .SelectMany(m => m.Sponsors.Where(s => s.TargetId == "player"))`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`world.Members.Select(m => m.Life.Trading).ToArray()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => world.Members.Select(m => m.Life.Trading).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`world.Members.Select(member => member.Life.Trading).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: world.Members.Select(member => member.Life.Trading).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`m.Sponsors.Where(s => s.TargetId == "player")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m => m.Sponsors.Where(s => s.TargetId == "player")`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`world.Members              .Where(m => id == m.PersonId || id == "player" && (world.Run == null || world.Run.Characters.ContainsKey(m.SteamId)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: world.Members              .Where(m => id == m.PersonId || id == "player" && (world.Run == null || world.Run.Characters.ContainsKey(m.SteamId)))              .SelectMany`

**赋值（含属性/字段和局部值）：**

- `world.World.MarketAccounts` = `(data, day) =>          {              CareerMarket.Accounts(data.Market, world.Members.Select(member => member.Life.Trading).ToArray(), day);          }`
- `world.World.MarketSponsors` = `id => world.Members              .Where(m => id == m.PersonId || id == "player" && (world.Run == null || world.Run.Characters.ContainsKey(m.SteamId)))              .SelectMany(m => m.Sponsors.Where(s => s.TargetId == "player"))`
- `world.World.TradingAccounts` = `() => world.Members.Select(m => m.Life.Trading).ToArray()`

<a id="symbol-fa87d36508d0"></a>

## `NationalSpire.Coop.CoopCoordinator.InspectMarket(NationalSpire.MarketInspection) — public async Task<MarketInspectionResult> InspectMarket(MarketInspection request)`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`](CoopCoordinator.cs.md#symbol-0145ddb8062f)；[`NationalSpire.Coop.CoopRules.InspectMarket(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.MarketInspection)`](CoopMarket.cs.md#symbol-6aa505a8b0a6)；`NationalSpire.Coop.CoopCoordinator.MarketQuery.MarketQuery(string, string, string, NationalSpire.MarketInspection)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.InvalidOperationException.InvalidOperationException(string?)`；`System.Threading.Tasks.Task<TResult>.WaitAsync(System.TimeSpan)`；`System.Threading.Tasks.TaskCompletionSource<TResult>.TaskCompletionSource()`；`System.TimeSpan.FromSeconds(long)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator._transport`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.MarketAnswer.Epoch`；`NationalSpire.Coop.CoopCoordinator.MarketAnswer.Error`；`NationalSpire.Coop.CoopCoordinator.MarketAnswer.Result`；`NationalSpire.Coop.CoopCoordinator.MarketAnswer.World`；`NationalSpire.Coop.CoopCoordinator.marketQueries`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRules.InspectMarket(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.MarketInspection)`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.ICoopTransport.Owner`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCoordinator.MarketQuery.MarketQuery(string, string, string, NationalSpire.MarketInspection)`；输入表达式：`new MarketQuery(id, world.Id, world.Epoch, request)`；返回值紧邻使用处：`ArgumentSyntax: new MarketQuery(id, world.Id, world.Epoch, request)`
- `NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；输入表达式：`Send(_transport.Owner, "market-query", new MarketQuery(id, world.Id, world.Epoch, request))`；返回值紧邻使用处：`ExpressionStatementSyntax: Send(_transport.Owner, "market-query", new MarketQuery(id, world.Id, world.Epoch, request));`
- `NationalSpire.Coop.CoopRules.InspectMarket(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.MarketInspection)`；输入表达式：`CoopRules.InspectMarket(world, Self, request)`；返回值紧邻使用处：`ReturnStatementSyntax: return CoopRules.InspectMarket(world, Self, request);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`marketQueries.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: marketQueries.Remove(id);`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Guid.NewGuid().ToString("N")`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("房间已切换，请重新查看市场。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("房间已切换，请重新查看市场。");`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("正在同步市场，请稍后重试。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidOperationException("正在同步市场，请稍后重试。")`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException(answer.Error)`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidOperationException(answer.Error)`
- `System.Threading.Tasks.Task<TResult>.WaitAsync(System.TimeSpan)`；输入表达式：`completion.Task.WaitAsync(TimeSpan.FromSeconds(10))`；返回值紧邻使用处：`AwaitExpressionSyntax: await completion.Task.WaitAsync(TimeSpan.FromSeconds(10))`
- `System.Threading.Tasks.TaskCompletionSource<TResult>.TaskCompletionSource()`；输入表达式：`new TaskCompletionSource<MarketAnswer>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TaskCompletionSource<MarketAnswer>()`
- `System.TimeSpan.FromSeconds(long)`；输入表达式：`TimeSpan.FromSeconds(10)`；返回值紧邻使用处：`ArgumentSyntax: TimeSpan.FromSeconds(10)`

**赋值（含属性/字段和局部值）：**

- `marketQueries[id]` = `completion`

<a id="symbol-1d6c27a5f526"></a>

## `NationalSpire.Coop.CoopCoordinator.ReceiveMarket(ulong, NationalSpire.Coop.CoopWire) — private void ReceiveMarket(ulong sender, CoopWire wire)`

来源：源码第 59 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.ReceiveNow(ulong, NationalSpire.Coop.CoopWire, System.DateTime)`](CoopCoordinator.cs.md#symbol-796041df5e9f)

**调用：** [`NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`](CoopCoordinator.cs.md#symbol-4239da75be84)；[`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`](CoopCoordinator.cs.md#symbol-0145ddb8062f)；[`NationalSpire.Coop.CoopRules.InspectMarket(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.MarketInspection)`](CoopMarket.cs.md#symbol-6aa505a8b0a6)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](../Diagnostics.cs.md#symbol-cb39203375a5)；`NationalSpire.Coop.CoopCoordinator.MarketAnswer.MarketAnswer(string, string, string, NationalSpire.MarketInspectionResult?, string)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Threading.Tasks.TaskCompletionSource<TResult>.TrySetResult(TResult)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.MarketAnswer.Id`；`NationalSpire.Coop.CoopCoordinator.marketQueries`；`NationalSpire.Coop.CoopCoordinator.MarketQuery.Epoch`；`NationalSpire.Coop.CoopCoordinator.MarketQuery.Id`；`NationalSpire.Coop.CoopCoordinator.MarketQuery.Request`；`NationalSpire.Coop.CoopCoordinator.MarketQuery.World`；`NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`；`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRules.InspectMarket(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.MarketInspection)`；`NationalSpire.Coop.CoopWire.Kind`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCoordinator.MarketAnswer.MarketAnswer(string, string, string, NationalSpire.MarketInspectionResult?, string)`；输入表达式：`new(query.Id, World.Id, World.Epoch, CoopRules.InspectMarket(World, sender, query.Request))`；返回值紧邻使用处：`AssignmentExpressionSyntax: answer = new(query.Id, World.Id, World.Epoch, CoopRules.InspectMarket(World, sender, query.Request))`
- `NationalSpire.Coop.CoopCoordinator.MarketAnswer.MarketAnswer(string, string, string, NationalSpire.MarketInspectionResult?, string)`；输入表达式：`new(query.Id, World.Id, World.Epoch, null, "市场预览暂时失败，请重新下单。")`；返回值紧邻使用处：`AssignmentExpressionSyntax: answer = new(query.Id, World.Id, World.Epoch, null, "市场预览暂时失败，请重新下单。")`
- `NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`；输入表达式：`Read<MarketAnswer>(wire)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Read<MarketAnswer>(wire)`
- `NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`；输入表达式：`Read<MarketQuery>(wire)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Read<MarketQuery>(wire)`
- `NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；输入表达式：`Send(sender, "market-answer", answer)`；返回值紧邻使用处：`ExpressionStatementSyntax: Send(sender, "market-answer", answer);`
- `NationalSpire.Coop.CoopRules.InspectMarket(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.MarketInspection)`；输入表达式：`CoopRules.InspectMarket(World, sender, query.Request)`；返回值紧邻使用处：`ArgumentSyntax: CoopRules.InspectMarket(World, sender, query.Request)`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("market.preview", error)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("market.preview", error);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`marketQueries.TryGetValue(answer.Id, out var completion)`；返回值紧邻使用处：`IfStatementSyntax: if (marketQueries.TryGetValue(answer.Id, out var completion)) completion.TrySetResult(answer);`
- `System.Threading.Tasks.TaskCompletionSource<TResult>.TrySetResult(TResult)`；输入表达式：`completion.TrySetResult(answer)`；返回值紧邻使用处：`ExpressionStatementSyntax: completion.TrySetResult(answer);`

**赋值（含属性/字段和局部值）：**

- `answer` = `new(query.Id, World.Id, World.Epoch, CoopRules.InspectMarket(World, sender, query.Request))`
- `answer` = `new(query.Id, World.Id, World.Epoch, null, "市场预览暂时失败，请重新下单。")`
