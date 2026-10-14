# CareerMarket.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`31B899F82E92BD85E7A47A0ED95C4C14053101DA7EE11BA45DF2ED45919DB9AA`。来源：[源码](../../CareerMarket.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerMarket`。

字段、事件及初始值（源码原样）：

```csharp
public const int HistoryDays = 180;
public const decimal DailyInterest = .0003m;
public const decimal FeeRate = .001m;
public static readonly int[] Leverages = [1, 2, 3, 5, 10, 20, 50, 100];
```

<a id="symbol-b3244730c7ae"></a>

## `NationalSpire.CareerMarket.Initialize(NationalSpire.CareerData) — public static bool Initialize(CareerData d)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.CreateNew(bool, int)`](CareerEngine.cs.md#symbol-63d93017946a)；[`NationalSpire.CareerEngine.MoveToNextDay(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-3836a38a7da9)；[`NationalSpire.CareerEngine.NormalizeRoster(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-eb11b96e7400)；[`NationalSpire.CareerMarket.Advance(NationalSpire.CareerData)`](CareerMarket.cs.md#symbol-6039084ecec7)；[`NationalSpire.CareerMarket.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](CareerMarket.cs.md#symbol-089c75a03be9)；[`NationalSpire.Coop.CoopRules.InitializeMarket(NationalSpire.Coop.CoopWorld)`](Coop/CoopMarket.cs.md#symbol-0d9508e5083b)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.CareerMarket.UpgradePricing(NationalSpire.CareerData)`](CareerMarket.cs.md#symbol-ee96e84cf581)；[`NationalSpire.MarketDynamics.Gaussian(System.Random)`](MarketDynamics.cs.md#symbol-d3b47ce56b50)；[`NationalSpire.MarketDynamics.Volatility(string, NationalSpire.MarketAsset)`](MarketDynamics.cs.md#symbol-9fa2a14727ca)；`NationalSpire.MarketPoint.MarketPoint(int, decimal)`；`NationalSpire.MarketQuote.MarketQuote()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.Generic.List<T>.Reverse()`；`System.Math.Exp(double)`；`System.Math.Max(int, int)`；`System.Random.Random(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Market`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerMarket.UpgradePricing(NationalSpire.CareerData)`；`NationalSpire.MarketAsset.Id`；`NationalSpire.MarketAsset.Initial`；`NationalSpire.MarketCatalog.Assets`；`NationalSpire.MarketCatalog.Version`；`NationalSpire.MarketDynamics.Gaussian(System.Random)`；`NationalSpire.MarketDynamics.Volatility(string, NationalSpire.MarketAsset)`；`NationalSpire.MarketPoint.Day`；`NationalSpire.MarketPoint.Price`；`NationalSpire.MarketQuote.History`；`NationalSpire.MarketQuote.Previous`；`NationalSpire.MarketQuote.Price`；`NationalSpire.MarketQuote.SyntheticThrough`；`NationalSpire.MarketState.CatalogVersion`；`NationalSpire.MarketState.CheckedQuoteCount`；`NationalSpire.MarketState.LastDay`；`NationalSpire.MarketState.Quotes`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash($"{d.WorldId}:history:{asset.Id}:{day}")`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.StableHash($"{d.WorldId}:history:{asset.Id}:{day}")`
- `NationalSpire.CareerMarket.UpgradePricing(NationalSpire.CareerData)`；输入表达式：`UpgradePricing(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: UpgradePricing(d) || changed`
- `NationalSpire.CareerMarket.UpgradePricing(NationalSpire.CareerData)`；输入表达式：`UpgradePricing(d)`；返回值紧邻使用处：`ReturnStatementSyntax: return UpgradePricing(d);`
- `NationalSpire.MarketDynamics.Gaussian(System.Random)`；输入表达式：`MarketDynamics.Gaussian(random)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: -MarketDynamics.Gaussian(random)`
- `NationalSpire.MarketDynamics.Volatility(string, NationalSpire.MarketAsset)`；输入表达式：`MarketDynamics.Volatility(d.WorldId, asset)`；返回值紧邻使用处：`BinaryExpressionSyntax: -MarketDynamics.Gaussian(random) * MarketDynamics.Volatility(d.WorldId, asset)`
- `NationalSpire.MarketPoint.MarketPoint(int, decimal)`；输入表达式：`new MarketPoint(d.Day, quote.Price)`；返回值紧邻使用处：`BinaryExpressionSyntax: quote!.History.FirstOrDefault() ?? new MarketPoint(d.Day, quote.Price)`
- `NationalSpire.MarketPoint.MarketPoint(int, decimal)`；输入表达式：`new(d.Day, asset.Initial)`；返回值紧邻使用处：`ExpressionElementSyntax: new(d.Day, asset.Initial)`
- `NationalSpire.MarketPoint.MarketPoint(int, decimal)`；输入表达式：`new(day, price)`；返回值紧邻使用处：`ArgumentSyntax: new(day, price)`
- `NationalSpire.MarketQuote.MarketQuote()`；输入表达式：`new() { Price = asset.Initial, Previous = asset.Initial, History = [new(d.Day, asset.Initial)] }`；返回值紧邻使用处：`AssignmentExpressionSyntax: quote = new() { Price = asset.Initial, Previous = asset.Initial, History = [new(d.Day, asset.Initial)] }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`d.Market.Quotes.TryGetValue(asset.Id, out var quote)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.Market.Quotes.TryGetValue(asset.Id, out var quote)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`quote!.History.FirstOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: quote!.History.FirstOrDefault() ?? new MarketPoint(d.Day, quote.Price)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`history.Add(new(day, price))`；返回值紧邻使用处：`ExpressionStatementSyntax: history.Add(new(day, price));`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`history.AddRange(quote.History)`；返回值紧邻使用处：`ExpressionStatementSyntax: history.AddRange(quote.History);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<MarketPoint>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<MarketPoint>()`
- `System.Collections.Generic.List<T>.Reverse()`；输入表达式：`history.Reverse()`；返回值紧邻使用处：`ExpressionStatementSyntax: history.Reverse();`
- `System.Math.Exp(double)`；输入表达式：`Math.Exp(-MarketDynamics.Gaussian(random) * MarketDynamics.Volatility(d.WorldId, asset))`；返回值紧邻使用处：`CastExpressionSyntax: (decimal)Math.Exp(-MarketDynamics.Gaussian(random) * MarketDynamics.Volatility(d.WorldId, asset))`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, 60 - quote.History.Count)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(0, 60 - quote.History.Count)`
- `System.Random.Random(int)`；输入表达式：`new Random(CareerEngine.StableHash($"{d.WorldId}:history:{asset.Id}:{day}"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Random(CareerEngine.StableHash($"{d.WorldId}:history:{asset.Id}:{day}"))`

**赋值（含属性/字段和局部值）：**

- `changed` = `true`
- `changed` |= `d.Market.CatalogVersion != MarketCatalog.Version`
- `d.Market.CatalogVersion` = `MarketCatalog.Version`
- `d.Market.CheckedQuoteCount` = `d.Market.Quotes.Count`
- `d.Market.LastDay` = `d.Day`
- `d.Market.Quotes[asset.Id]` = `quote`
- `History` = `[new(d.Day, asset.Initial)]`
- `Previous` = `asset.Initial`
- `price` *= `(decimal)Math.Exp(-MarketDynamics.Gaussian(random) * MarketDynamics.Volatility(d.WorldId, asset))`
- `Price` = `asset.Initial`
- `quote.History` = `history`
- `quote.Previous` = `quote.History[^2].Price`
- `quote.SyntheticThrough` = `first.Day - 1`
- `quote` = `new() { Price = asset.Initial, Previous = asset.Initial, History = [new(d.Day, asset.Initial)] }`

<a id="symbol-ee96e84cf581"></a>

## `NationalSpire.CareerMarket.UpgradePricing(NationalSpire.CareerData) — private static bool UpgradePricing(CareerData d)`

来源：源码第 42 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Initialize(NationalSpire.CareerData)`](CareerMarket.cs.md#symbol-b3244730c7ae)

**调用：** [`NationalSpire.CareerMarket.Accounts(NationalSpire.CareerData, int)`](CareerMarket.cs.md#symbol-5182135836a6)；[`NationalSpire.CareerMarket.Price(NationalSpire.MarketQuote, int, decimal)`](CareerMarket.cs.md#symbol-3399009ec118)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Math.Clamp(decimal, decimal, decimal)`；`System.Math.Exp(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Market`；`NationalSpire.CareerMarket.Accounts(NationalSpire.CareerData, int)`；`NationalSpire.CareerMarket.Price(NationalSpire.MarketQuote, int, decimal)`；`NationalSpire.MarketQuote.AppliedSignal`；`NationalSpire.MarketQuote.PendingSignal`；`NationalSpire.MarketQuote.Price`；`NationalSpire.MarketQuote.SignalDay`；`NationalSpire.MarketState.PricingVersion`；`NationalSpire.MarketState.Quotes`；`NationalSpire.MarketState.Revision`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMarket.Accounts(NationalSpire.CareerData, int)`；输入表达式：`Accounts(d, d.Day)`；返回值紧邻使用处：`ExpressionStatementSyntax: Accounts(d, d.Day);`
- `NationalSpire.CareerMarket.Price(NationalSpire.MarketQuote, int, decimal)`；输入表达式：`Price(q, d.Day, q.Price * (decimal)Math.Exp(-(double)q.AppliedSignal * .01))`；返回值紧邻使用处：`ExpressionStatementSyntax: Price(q, d.Day, q.Price * (decimal)Math.Exp(-(double)q.AppliedSignal * .01));`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Market.Quotes.Values.Any(q => q.AppliedSignal != 0)`；返回值紧邻使用处：`IfStatementSyntax: if (d.Market.Quotes.Values.Any(q => q.AppliedSignal != 0)) Accounts(d, d.Day);`
- `System.Math.Clamp(decimal, decimal, decimal)`；输入表达式：`Math.Clamp(q.PendingSignal, -4, 4)`；返回值紧邻使用处：`AssignmentExpressionSyntax: q.AppliedSignal = Math.Clamp(q.PendingSignal, -4, 4)`
- `System.Math.Exp(double)`；输入表达式：`Math.Exp(-(double)q.AppliedSignal * .01)`；返回值紧邻使用处：`CastExpressionSyntax: (decimal)Math.Exp(-(double)q.AppliedSignal * .01)`

**赋值（含属性/字段和局部值）：**

- `d.Market.PricingVersion` = `1`
- `q.AppliedSignal` = `Math.Clamp(q.PendingSignal, -4, 4)`
- `q.SignalDay` = `d.Day`

<a id="symbol-3e50cb7c29a1"></a>

## `NationalSpire.CareerMarket.Equity(NationalSpire.MarketPosition, decimal) — public static decimal Equity(MarketPosition position, decimal price)`

来源：源码第 55 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Forced(NationalSpire.MarketPosition, decimal)`](CareerMarket.cs.md#symbol-4c0e4a44e705)；[`NationalSpire.MarketPositionCard.Preview()`](MarketVisuals.cs.md#symbol-5a8785632454)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.MarketPosition.Direction`；`NationalSpire.MarketPosition.Entry`；`NationalSpire.MarketPosition.Margin`；`NationalSpire.MarketPosition.Units`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-55ca9c614fb1"></a>

## `NationalSpire.CareerMarket.Net(NationalSpire.MarketState, NationalSpire.MarketAccount) — public static decimal Net(MarketState market, MarketAccount account)`

来源：源码第 57 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.RefreshAccount()`](MarketTerminal.cs.md#symbol-4089d15c736a)

**调用：** [`NationalSpire.MarketExecution.LiquidationValue(NationalSpire.MarketState, NationalSpire.MarketAccount)`](MarketExecution.cs.md#symbol-77afecd31787)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketExecution.LiquidationValue(NationalSpire.MarketState, NationalSpire.MarketAccount)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketExecution.LiquidationValue(NationalSpire.MarketState, NationalSpire.MarketAccount)`；输入表达式：`MarketExecution.LiquidationValue(market, account)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => MarketExecution.LiquidationValue(market, account)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a7af74d3e50b"></a>

## `NationalSpire.CareerMarket.Record(NationalSpire.MarketAccount, int, string, decimal) — private static void Record(MarketAccount account, int day, string text, decimal change)`

来源：源码第 60 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Accounts(NationalSpire.MarketState, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, int)`](CareerMarket.cs.md#symbol-81ec5ad63c25)；[`NationalSpire.CareerMarket.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`](CareerMarket.cs.md#symbol-6b9ac5b0686c)

**调用：** `NationalSpire.MarketTrade.MarketTrade(int, string, decimal, decimal)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.RemoveAt(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketAccount.Cash`；`NationalSpire.MarketAccount.Trades`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketTrade.MarketTrade(int, string, decimal, decimal)`；输入表达式：`new(day, text, change, account.Cash)`；返回值紧邻使用处：`ArgumentSyntax: new(day, text, change, account.Cash)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`account.Trades.Add(new(day, text, change, account.Cash))`；返回值紧邻使用处：`ExpressionStatementSyntax: account.Trades.Add(new(day, text, change, account.Cash));`
- `System.Collections.Generic.List<T>.RemoveAt(int)`；输入表达式：`account.Trades.RemoveAt(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: account.Trades.RemoveAt(0);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a92beec78217"></a>

## `NationalSpire.CareerMarket.Account(NationalSpire.MarketState, NationalSpire.MarketAccount, int) — public static void Account(MarketState market, MarketAccount account, int day)`

来源：源码第 65 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Accounts(NationalSpire.CareerData, int)`](CareerMarket.cs.md#symbol-5182135836a6)

**调用：** [`NationalSpire.CareerMarket.Accounts(NationalSpire.MarketState, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, int)`](CareerMarket.cs.md#symbol-81ec5ad63c25)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMarket.Accounts(NationalSpire.MarketState, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMarket.Accounts(NationalSpire.MarketState, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, int)`；输入表达式：`Accounts(market, [account], day)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Accounts(market, [account], day)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4c0e4a44e705"></a>

## `NationalSpire.CareerMarket.Forced(NationalSpire.MarketPosition, decimal) — private static bool Forced(MarketPosition p, decimal price)`

来源：源码第 67 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Accounts(NationalSpire.MarketState, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, int)`](CareerMarket.cs.md#symbol-81ec5ad63c25)

**调用：** [`NationalSpire.CareerMarket.Equity(NationalSpire.MarketPosition, decimal)`](CareerMarket.cs.md#symbol-3e50cb7c29a1)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMarket.Equity(NationalSpire.MarketPosition, decimal)`；`NationalSpire.MarketAsset.Forex`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketPosition.Asset`；`NationalSpire.MarketPosition.Direction`；`NationalSpire.MarketPosition.InitialMargin`；`NationalSpire.MarketPosition.Leverage`；`NationalSpire.MarketPosition.Margin`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMarket.Equity(NationalSpire.MarketPosition, decimal)`；输入表达式：`Equity(p, price)`；返回值紧邻使用处：`BinaryExpressionSyntax: Equity(p, price) <= (p.InitialMargin ?? p.Margin) * .1m`

**赋值（含属性/字段和局部值）：**


<a id="symbol-81ec5ad63c25"></a>

## `NationalSpire.CareerMarket.Accounts(NationalSpire.MarketState, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, int) — public static void Accounts(MarketState market, IReadOnlyList<MarketAccount> accounts, int day)`

来源：源码第 70 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Account(NationalSpire.MarketState, NationalSpire.MarketAccount, int)`](CareerMarket.cs.md#symbol-a92beec78217)；[`NationalSpire.Coop.CoopRules.BindMarket(NationalSpire.Coop.CoopWorld)`](Coop/CoopMarket.cs.md#symbol-b6088377cb72)

**调用：** [`NationalSpire.CareerMarket.Forced(NationalSpire.MarketPosition, decimal)`](CareerMarket.cs.md#symbol-4c0e4a44e705)；[`NationalSpire.CareerMarket.Record(NationalSpire.MarketAccount, int, string, decimal)`](CareerMarket.cs.md#symbol-a7af74d3e50b)；[`NationalSpire.MarketExecution.Apply(NationalSpire.MarketState, string, NationalSpire.MarketExecution.Fill, int)`](MarketExecution.cs.md#symbol-9ad4ae339dd8)；[`NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-2508c79f1fc5)；`decimal.Round(decimal, int)`；`decimal.ToString(string?)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.HashSet()`；`System.Collections.Generic.List<T>.Remove(T)`；`System.Collections.Generic.Queue<T>.Enqueue(T)`；`System.Collections.Generic.Queue<T>.Queue()`；`System.Collections.Generic.Queue<T>.TryDequeue(out T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMarket.Forced(NationalSpire.MarketPosition, decimal)`；`NationalSpire.CareerMarket.Record(NationalSpire.MarketAccount, int, string, decimal)`；`NationalSpire.MarketAccount.Cash`；`NationalSpire.MarketAccount.Debt`；`NationalSpire.MarketAccount.InterestDay`；`NationalSpire.MarketAccount.InterestRate`；`NationalSpire.MarketAccount.Positions`；`NationalSpire.MarketAsset.Name`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketExecution.Apply(NationalSpire.MarketState, string, NationalSpire.MarketExecution.Fill, int)`；`NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`；`NationalSpire.MarketExecution.Exit.Fill`；`NationalSpire.MarketExecution.Exit.Proceeds`；`NationalSpire.MarketExecution.Fill.Average`；`NationalSpire.MarketPosition.Asset`；`NationalSpire.MarketPosition.Direction`；`NationalSpire.MarketPosition.StopPrice`；`NationalSpire.MarketQuote.Price`；`NationalSpire.MarketState.Quotes`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.Round(decimal, int)`；输入表达式：`decimal.Round(account.Debt * account.InterestRate, 4)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = decimal.Round(account.Debt * account.InterestRate, 4)`
- `decimal.ToString(string?)`；输入表达式：`exit.Fill.Average.ToString("0.00000")`；返回值紧邻使用处：`BinaryExpressionSyntax: MarketCatalog.ById[p.Asset].Name + (liquidated ? "强制平仓" : "止损平仓") + " · 成交价" + exit.Fill.Average.ToString("0.00000")`
- `NationalSpire.CareerMarket.Forced(NationalSpire.MarketPosition, decimal)`；输入表达式：`Forced(p, market.Quotes[p.Asset].Price)`；返回值紧邻使用处：`BinaryExpressionSyntax: wasForced || Forced(p, market.Quotes[p.Asset].Price)`
- `NationalSpire.CareerMarket.Forced(NationalSpire.MarketPosition, decimal)`；输入表达式：`Forced(position, price)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Forced(position, price)`
- `NationalSpire.CareerMarket.Record(NationalSpire.MarketAccount, int, string, decimal)`；输入表达式：`Record(account, account.InterestDay, "借款利息", -interest)`；返回值紧邻使用处：`ExpressionStatementSyntax: Record(account, account.InterestDay, "借款利息", -interest);`
- `NationalSpire.CareerMarket.Record(NationalSpire.MarketAccount, int, string, decimal)`；输入表达式：`Record(account, day, MarketCatalog.ById[p.Asset].Name + (liquidated ? "强制平仓" : "止损平仓") + " · 成交价" + exit.Fill.Average.ToString("0.00000"), exit.Proceeds)`；返回值紧邻使用处：`ExpressionStatementSyntax: Record(account, day, MarketCatalog.ById[p.Asset].Name + (liquidated ? "强制平仓" : "止损平仓") + " · 成交价" + exit.Fill.Average.ToString("0.00000"), exit.Proceeds);`
- `NationalSpire.MarketExecution.Apply(NationalSpire.MarketState, string, NationalSpire.MarketExecution.Fill, int)`；输入表达式：`MarketExecution.Apply(market, p.Asset, exit.Fill, day)`；返回值紧邻使用处：`ExpressionStatementSyntax: MarketExecution.Apply(market, p.Asset, exit.Fill, day);`
- `NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`；输入表达式：`MarketExecution.Close(p, market.Quotes[p.Asset])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MarketExecution.Close(p, market.Quotes[p.Asset])`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`triggered.Add(position)`；返回值紧邻使用处：`BinaryExpressionSyntax: (forced || stop) && triggered.Add(position)`
- `System.Collections.Generic.HashSet<T>.HashSet()`；输入表达式：`new HashSet<MarketPosition>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HashSet<MarketPosition>()`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`account.Positions.Remove(p)`；返回值紧邻使用处：`ExpressionStatementSyntax: account.Positions.Remove(p);`
- `System.Collections.Generic.Queue<T>.Enqueue(T)`；输入表达式：`pending.Enqueue((owner, position, forced))`；返回值紧邻使用处：`ExpressionStatementSyntax: pending.Enqueue((owner, position, forced));`
- `System.Collections.Generic.Queue<T>.Queue()`；输入表达式：`new Queue<(MarketAccount Account, MarketPosition Position, bool Forced)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Queue<(MarketAccount Account, MarketPosition Position, bool Forced)>()`
- `System.Collections.Generic.Queue<T>.TryDequeue(out T)`；输入表达式：`pending.TryDequeue(out var item)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !pending.TryDequeue(out var item)`

**赋值（含属性/字段和局部值）：**

- `account.Cash` += `exit.Proceeds`
- `account.Debt` += `interest`
- `account.InterestDay` = `day`
- `var (account, p, wasForced)` = `item`

<a id="symbol-5182135836a6"></a>

## `NationalSpire.CareerMarket.Accounts(NationalSpire.CareerData, int) — private static void Accounts(CareerData d, int day)`

来源：源码第 104 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Advance(NationalSpire.CareerData)`](CareerMarket.cs.md#symbol-6039084ecec7)；[`NationalSpire.CareerMarket.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](CareerMarket.cs.md#symbol-089c75a03be9)；[`NationalSpire.CareerMarket.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`](CareerMarket.cs.md#symbol-6b9ac5b0686c)；[`NationalSpire.CareerMarket.UpgradePricing(NationalSpire.CareerData)`](CareerMarket.cs.md#symbol-ee96e84cf581)

**调用：** [`NationalSpire.CareerMarket.Account(NationalSpire.MarketState, NationalSpire.MarketAccount, int)`](CareerMarket.cs.md#symbol-a92beec78217)；`System.Action<T1, T2>.Invoke(T1, T2)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.CooperativeMembers`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Market`；`NationalSpire.CareerData.MarketAccounts`；`NationalSpire.CareerLifeState.Trading`；`NationalSpire.CareerMarket.Account(NationalSpire.MarketState, NationalSpire.MarketAccount, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMarket.Account(NationalSpire.MarketState, NationalSpire.MarketAccount, int)`；输入表达式：`Account(d.Market, d.Life.Trading, day)`；返回值紧邻使用处：`ExpressionStatementSyntax: Account(d.Market, d.Life.Trading, day);`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`d.MarketAccounts(d, day)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.MarketAccounts(d, day);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3399009ec118"></a>

## `NationalSpire.CareerMarket.Price(NationalSpire.MarketQuote, int, decimal) — private static void Price(MarketQuote quote, int day, decimal price)`

来源：源码第 109 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Advance(NationalSpire.CareerData)`](CareerMarket.cs.md#symbol-6039084ecec7)；[`NationalSpire.CareerMarket.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](CareerMarket.cs.md#symbol-089c75a03be9)；[`NationalSpire.CareerMarket.UpgradePricing(NationalSpire.CareerData)`](CareerMarket.cs.md#symbol-ee96e84cf581)

**调用：** [`NationalSpire.MarketExecution.Reprice(NationalSpire.MarketQuote, decimal)`](MarketExecution.cs.md#symbol-d2f4f8cbac5d)；`decimal.Round(decimal, int)`；`NationalSpire.MarketPoint.MarketPoint(int, decimal)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.RemoveAt(int)`；`System.Math.Max(decimal, decimal)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMarket.HistoryDays`；`NationalSpire.MarketExecution.Reprice(NationalSpire.MarketQuote, decimal)`；`NationalSpire.MarketPoint.Day`；`NationalSpire.MarketQuote.History`；`NationalSpire.MarketQuote.Price`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.Round(decimal, int)`；输入表达式：`decimal.Round(price, 6)`；返回值紧邻使用处：`ArgumentSyntax: decimal.Round(price, 6)`
- `NationalSpire.MarketExecution.Reprice(NationalSpire.MarketQuote, decimal)`；输入表达式：`MarketExecution.Reprice(quote, Math.Max(.000001m, decimal.Round(price, 6)))`；返回值紧邻使用处：`ExpressionStatementSyntax: MarketExecution.Reprice(quote, Math.Max(.000001m, decimal.Round(price, 6)));`
- `NationalSpire.MarketPoint.MarketPoint(int, decimal)`；输入表达式：`new(day, quote.Price)`；返回值紧邻使用处：`ArgumentSyntax: new(day, quote.Price)`
- `NationalSpire.MarketPoint.MarketPoint(int, decimal)`；输入表达式：`new(day, quote.Price)`；返回值紧邻使用处：`AssignmentExpressionSyntax: quote.History[^1] = new(day, quote.Price)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`quote.History.Add(new(day, quote.Price))`；返回值紧邻使用处：`ExpressionStatementSyntax: quote.History.Add(new(day, quote.Price));`
- `System.Collections.Generic.List<T>.RemoveAt(int)`；输入表达式：`quote.History.RemoveAt(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: quote.History.RemoveAt(0);`
- `System.Math.Max(decimal, decimal)`；输入表达式：`Math.Max(.000001m, decimal.Round(price, 6))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(.000001m, decimal.Round(price, 6))`

**赋值（含属性/字段和局部值）：**

- `quote.History[^1]` = `new(day, quote.Price)`

<a id="symbol-6039084ecec7"></a>

## `NationalSpire.CareerMarket.Advance(NationalSpire.CareerData) — public static void Advance(CareerData d)`

来源：源码第 116 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.MoveToNextDay(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-3836a38a7da9)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.CareerMarket.Accounts(NationalSpire.CareerData, int)`](CareerMarket.cs.md#symbol-5182135836a6)；[`NationalSpire.CareerMarket.Initialize(NationalSpire.CareerData)`](CareerMarket.cs.md#symbol-b3244730c7ae)；[`NationalSpire.CareerMarket.Price(NationalSpire.MarketQuote, int, decimal)`](CareerMarket.cs.md#symbol-3399009ec118)；[`NationalSpire.MarketDynamics.AddEvent(NationalSpire.CareerData, NationalSpire.MarketEvent)`](MarketDynamics.cs.md#symbol-4ed121bc162f)；[`NationalSpire.MarketDynamics.Anchors(NationalSpire.CareerData)`](MarketDynamics.cs.md#symbol-9a7ffea26eec)；[`NationalSpire.MarketDynamics.Noise(string, int, NationalSpire.MarketAsset, System.Random)`](MarketDynamics.cs.md#symbol-f66f0f0a5e13)；[`NationalSpire.MarketDynamics.Shock(System.Random, double)`](MarketDynamics.cs.md#symbol-75a00530631a)；[`NationalSpire.MarketDynamics.Volatility(string, NationalSpire.MarketAsset)`](MarketDynamics.cs.md#symbol-9fa2a14727ca)；[`NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-90e04f0c7b2e)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`NationalSpire.MarketEvent.MarketEvent(int, string, string, double, string, string)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, double>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Math.Clamp(double, double, double)`；`System.Math.Exp(double)`；`System.Math.Log(double)`；`System.Random.Next(int)`；`System.Random.NextDouble()`；`System.Random.Random(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Market`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerMarket.Accounts(NationalSpire.CareerData, int)`；`NationalSpire.CareerMarket.Initialize(NationalSpire.CareerData)`；`NationalSpire.CareerMarket.Price(NationalSpire.MarketQuote, int, decimal)`；`NationalSpire.CircuitAward.Country`；`NationalSpire.CircuitAward.Fortune`；`NationalSpire.CircuitAward.Season`；`NationalSpire.EsportsCareer.CircuitAwards`；`NationalSpire.MarketAsset.Country`；`NationalSpire.MarketAsset.Forex`；`NationalSpire.MarketAsset.Id`；`NationalSpire.MarketAsset.Name`；`NationalSpire.MarketCatalog.Assets`；`NationalSpire.MarketDynamics.AddEvent(NationalSpire.CareerData, NationalSpire.MarketEvent)`；`NationalSpire.MarketDynamics.Anchors(NationalSpire.CareerData)`；`NationalSpire.MarketDynamics.Noise(string, int, NationalSpire.MarketAsset, System.Random)`；`NationalSpire.MarketDynamics.Shock(System.Random, double)`；`NationalSpire.MarketDynamics.Volatility(string, NationalSpire.MarketAsset)`；`NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`；`NationalSpire.MarketQuote.AppliedSignal`；`NationalSpire.MarketQuote.PendingSignal`；`NationalSpire.MarketQuote.Previous`；`NationalSpire.MarketQuote.Price`；`NationalSpire.MarketQuote.SignalDay`；`NationalSpire.MarketState.LastDay`；`NationalSpire.MarketState.Quotes`；`NationalSpire.MarketState.Revision`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.MarketAdvance`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash($"{d.WorldId}:business:{day}")`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.StableHash($"{d.WorldId}:business:{day}")`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash($"{d.WorldId}:market:{day}:{asset.Id}")`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.StableHash($"{d.WorldId}:market:{day}:{asset.Id}")`
- `NationalSpire.CareerMarket.Accounts(NationalSpire.CareerData, int)`；输入表达式：`Accounts(d, d.Day)`；返回值紧邻使用处：`ExpressionStatementSyntax: Accounts(d, d.Day);`
- `NationalSpire.CareerMarket.Accounts(NationalSpire.CareerData, int)`；输入表达式：`Accounts(d, day)`；返回值紧邻使用处：`ExpressionStatementSyntax: Accounts(d, day);`
- `NationalSpire.CareerMarket.Initialize(NationalSpire.CareerData)`；输入表达式：`Initialize(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: Initialize(d);`
- `NationalSpire.CareerMarket.Price(NationalSpire.MarketQuote, int, decimal)`；输入表达式：`Price(quote, day, reference * (decimal)Math.Exp(change))`；返回值紧邻使用处：`ExpressionStatementSyntax: Price(quote, day, reference * (decimal)Math.Exp(change));`
- `NationalSpire.MarketDynamics.AddEvent(NationalSpire.CareerData, NationalSpire.MarketEvent)`；输入表达式：`MarketDynamics.AddEvent(d, new(day, asset.Id,                      asset.Name + (businessChange > 0 ? "公布销售增长消息" : "公布供应与成本压力消息"), businessChange))`；返回值紧邻使用处：`ExpressionStatementSyntax: MarketDynamics.AddEvent(d, new(day, asset.Id,                      asset.Name + (businessChange > 0 ? "公布销售增长消息" : "公布供应与成本压力消息"), businessChange));`
- `NationalSpire.MarketDynamics.Anchors(NationalSpire.CareerData)`；输入表达式：`MarketDynamics.Anchors(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MarketDynamics.Anchors(d)`
- `NationalSpire.MarketDynamics.Noise(string, int, NationalSpire.MarketAsset, System.Random)`；输入表达式：`MarketDynamics.Noise(d.WorldId, day, asset, random)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MarketDynamics.Noise(d.WorldId, day, asset, random)`
- `NationalSpire.MarketDynamics.Shock(System.Random, double)`；输入表达式：`MarketDynamics.Shock(random, sigma)`；返回值紧邻使用处：`BinaryExpressionSyntax: -drift + sigma * noise + MarketDynamics.Shock(random, sigma)`
- `NationalSpire.MarketDynamics.Volatility(string, NationalSpire.MarketAsset)`；输入表达式：`MarketDynamics.Volatility(d.WorldId, asset)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MarketDynamics.Volatility(d.WorldId, asset)`
- `NationalSpire.MarketEvent.MarketEvent(int, string, string, double, string, string)`；输入表达式：`new(day, asset.Id,                      asset.Name + (businessChange > 0 ? "公布销售增长消息" : "公布供应与成本压力消息"), businessChange)`；返回值紧邻使用处：`ArgumentSyntax: new(day, asset.Id,                      asset.Name + (businessChange > 0 ? "公布销售增长消息" : "公布供应与成本压力消息"), businessChange)`
- `NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`；输入表达式：`MarketExecution.ReferencePrice(quote)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MarketExecution.ReferencePrice(quote)`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.MarketAdvance)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.MarketAdvance)`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Esports.CircuitAwards.GroupBy(a => a.Country)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.CircuitAwards.GroupBy(a => a.Country).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Esports.CircuitAwards.Where(a => a.Season == d.Season).GroupBy(a => a.Country)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.CircuitAwards.Where(a => a.Season == d.Season).GroupBy(a => a.Country).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, double>)`；输入表达式：`g.Sum(a => (double)a.Fortune)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.Sum(a => (double)a.Fortune)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`MarketCatalog.Assets.Where(a => !a.Forex).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MarketCatalog.Assets.Where(a => !a.Forex).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`d.Esports.CircuitAwards.GroupBy(a => a.Country).ToDictionary(g => g.Key, g => g.Sum(a => (double)a.Fortune))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.CircuitAwards.GroupBy(a => a.Country).ToDictionary(g => g.Key, g => g.Sum(a => (double)a.Fortune))`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`d.Esports.CircuitAwards.Where(a => a.Season == d.Season).GroupBy(a => a.Country).ToDictionary(g => g.Key, g => g.Sum(a => (double)a.Fortune))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.CircuitAwards.Where(a => a.Season == d.Season).GroupBy(a => a.Country).ToDictionary(g => g.Key, g => g.Sum(a => (double)a.Fortune))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.CircuitAwards.Where(a => a.Season == d.Season)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.CircuitAwards.Where(a => a.Season == d.Season).GroupBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`MarketCatalog.Assets.Where(a => !a.Forex)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: MarketCatalog.Assets.Where(a => !a.Forex).ToArray`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`season.GetValueOrDefault("中国")`；返回值紧邻使用处：`BinaryExpressionSyntax: season.GetValueOrDefault(asset.Country) - season.GetValueOrDefault("中国")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`season.GetValueOrDefault(asset.Country)`；返回值紧邻使用处：`BinaryExpressionSyntax: season.GetValueOrDefault(asset.Country) - season.GetValueOrDefault("中国")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`total.GetValueOrDefault("中国")`；返回值紧邻使用处：`BinaryExpressionSyntax: total.GetValueOrDefault(asset.Country) - total.GetValueOrDefault("中国")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`total.GetValueOrDefault(asset.Country)`；返回值紧邻使用处：`BinaryExpressionSyntax: total.GetValueOrDefault(asset.Country) - total.GetValueOrDefault("中国")`
- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp(.0000012 * (total.GetValueOrDefault(asset.Country) - total.GetValueOrDefault("中国"))                      + .000003 * (season.GetValueOrDefault(asset.Country) - season.GetValueOrDefault("中国")), -.0005, .0005)`；返回值紧邻使用处：`ConditionalExpressionSyntax: asset.Forex ? Math.Clamp(.0000012 * (total.GetValueOrDefault(asset.Country) - total.GetValueOrDefault("中国"))                      + .000003 * (season.GetValueOrDefault(asset.Country) - season.GetValueOrDefault("中国")), -.0005, .0005) : 0`
- `System.Math.Exp(double)`；输入表达式：`Math.Exp(change)`；返回值紧邻使用处：`CastExpressionSyntax: (decimal)Math.Exp(change)`
- `System.Math.Log(double)`；输入表达式：`Math.Log((double)(reference / anchors[asset.Id]))`；返回值紧邻使用处：`BinaryExpressionSyntax: .03 * Math.Log((double)(reference / anchors[asset.Id]))`
- `System.Random.Next(int)`；输入表达式：`business.Next(brands.Length)`；返回值紧邻使用处：`ArgumentSyntax: business.Next(brands.Length)`
- `System.Random.NextDouble()`；输入表达式：`business.NextDouble()`；返回值紧邻使用处：`BinaryExpressionSyntax: business.NextDouble() * .02`
- `System.Random.NextDouble()`；输入表达式：`business.NextDouble()`；返回值紧邻使用处：`BinaryExpressionSyntax: business.NextDouble() < .25`
- `System.Random.NextDouble()`；输入表达式：`business.NextDouble()`；返回值紧邻使用处：`BinaryExpressionSyntax: business.NextDouble() < .5`
- `System.Random.Random(int)`；输入表达式：`new Random(CareerEngine.StableHash($"{d.WorldId}:business:{day}"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Random(CareerEngine.StableHash($"{d.WorldId}:business:{day}"))`
- `System.Random.Random(int)`；输入表达式：`new Random(CareerEngine.StableHash($"{d.WorldId}:market:{day}:{asset.Id}"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Random(CareerEngine.StableHash($"{d.WorldId}:market:{day}:{asset.Id}"))`

**赋值（含属性/字段和局部值）：**

- `d.Market.LastDay` = `day`
- `quote.AppliedSignal` = `0`
- `quote.PendingSignal` = `quote.AppliedSignal = 0`
- `quote.Previous` = `quote.Price`
- `quote.SignalDay` = `day`

<a id="symbol-089c75a03be9"></a>

## `NationalSpire.CareerMarket.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture) — public static void Fixture(CareerData d, WorldCompetition c, WorldFixture fixture)`

来源：源码第 151 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EsportsWorld.FinishFixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, string, bool)`](EsportsWorld.cs.md#symbol-f16aef3da82a)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerMarket.Accounts(NationalSpire.CareerData, int)`](CareerMarket.cs.md#symbol-5182135836a6)；[`NationalSpire.CareerMarket.Initialize(NationalSpire.CareerData)`](CareerMarket.cs.md#symbol-b3244730c7ae)；[`NationalSpire.CareerMarket.Price(NationalSpire.MarketQuote, int, decimal)`](CareerMarket.cs.md#symbol-3399009ec118)；[`NationalSpire.CircuitWorld.RoundCount(NationalSpire.WorldCompetition)`](CircuitWorld.cs.md#symbol-95620df3f1f6)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；[`NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-fc31e7fdf9be)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.MarketDynamics.AddEvent(NationalSpire.CareerData, NationalSpire.MarketEvent)`](MarketDynamics.cs.md#symbol-4ed121bc162f)；[`NationalSpire.MarketDynamics.BrandChange(string, NationalSpire.MarketAsset, double)`](MarketDynamics.cs.md#symbol-1ed091caa717)；[`NationalSpire.MarketDynamics.Links(NationalSpire.CareerData)`](MarketDynamics.cs.md#symbol-ed217f617f49)；[`NationalSpire.MarketDynamics.ResultSignal(NationalSpire.WorldCompetition, int, bool)`](MarketDynamics.cs.md#symbol-12776bc2a687)；[`NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-90e04f0c7b2e)；[`NationalSpire.SeasonCeremony.Participants(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, bool)`](SeasonCeremony.cs.md#symbol-c038c48114b1)；`NationalSpire.MarketEvent.MarketEvent(int, string, string, double, string, string)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Average<TSource>(System.Func<TSource, double>)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Math.Clamp(decimal, decimal, decimal)`；`System.Math.Exp(double)`；`System.Math.Pow(double, double)`

**字段、属性、事件及方法组引用：** `(string Id, bool TeamWon, bool Won).Id`；`(string Id, bool TeamWon, bool Won).TeamWon`；`(string Id, bool TeamWon, bool Won).Won`；`(string Id, bool Won).Id`；`(string Id, bool Won).Won`；`(string Id, string Detail, double Signal).Detail`；`(string Id, string Detail, double Signal).Id`；`(string Id, string Detail, double Signal).Signal`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.Market`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerMarket.Accounts(NationalSpire.CareerData, int)`；`NationalSpire.CareerMarket.Initialize(NationalSpire.CareerData)`；`NationalSpire.CareerMarket.Price(NationalSpire.MarketQuote, int, decimal)`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CircuitWorld.RoundCount(NationalSpire.WorldCompetition)`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.MarketAsset.Country`；`NationalSpire.MarketAsset.Forex`；`NationalSpire.MarketAsset.Id`；`NationalSpire.MarketAsset.Name`；`NationalSpire.MarketCatalog.Assets`；`NationalSpire.MarketDynamics.AddEvent(NationalSpire.CareerData, NationalSpire.MarketEvent)`；`NationalSpire.MarketDynamics.BrandChange(string, NationalSpire.MarketAsset, double)`；`NationalSpire.MarketDynamics.Links(NationalSpire.CareerData)`；`NationalSpire.MarketDynamics.ResultSignal(NationalSpire.WorldCompetition, int, bool)`；`NationalSpire.MarketDynamics.SponsorLink.Brand`；`NationalSpire.MarketDynamics.SponsorLink.Club`；`NationalSpire.MarketDynamics.SponsorLink.Target`；`NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`；`NationalSpire.MarketQuote.AppliedSignal`；`NationalSpire.MarketQuote.PendingSignal`；`NationalSpire.MarketQuote.Price`；`NationalSpire.MarketQuote.SignalDay`；`NationalSpire.MarketState.Quotes`；`NationalSpire.MarketState.Revision`；`NationalSpire.SeasonCeremony.Participants(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, bool)`；`NationalSpire.WorldCompetition.EntrantClubs`；`NationalSpire.WorldCompetition.EntrantCountries`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Name`；`NationalSpire.WorldCompetition.TeamEvent`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.AwayTeam`；`NationalSpire.WorldFixture.Draw`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.HomeTeam`；`NationalSpire.WorldFixture.MarketSettled`；`NationalSpire.WorldFixture.Round`；`NationalSpire.WorldFixture.Walkover`；`NationalSpire.WorldFixture.WinnerId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, link.Target)`；返回值紧邻使用处：`ConditionalExpressionSyntax: link.Club ? EsportsWorld.ClubName(d, link.Target) : CareerEngine.DisplayName(d, link.Target)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CareerEngine.Person(d, id)?.Country`
- `NationalSpire.CareerMarket.Accounts(NationalSpire.CareerData, int)`；输入表达式：`Accounts(d, d.Day)`；返回值紧邻使用处：`ExpressionStatementSyntax: Accounts(d, d.Day);`
- `NationalSpire.CareerMarket.Initialize(NationalSpire.CareerData)`；输入表达式：`Initialize(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: Initialize(d);`
- `NationalSpire.CareerMarket.Price(NationalSpire.MarketQuote, int, decimal)`；输入表达式：`Price(quote, d.Day, MarketExecution.ReferencePrice(quote) * (decimal)Math.Exp(-(double)delta * .01))`；返回值紧邻使用处：`ExpressionStatementSyntax: Price(quote, d.Day, MarketExecution.ReferencePrice(quote) * (decimal)Math.Exp(-(double)delta * .01));`
- `NationalSpire.CareerMarket.Price(NationalSpire.MarketQuote, int, decimal)`；输入表达式：`Price(quote, d.Day, MarketExecution.ReferencePrice(quote) * (decimal)Math.Exp(change))`；返回值紧邻使用处：`ExpressionStatementSyntax: Price(quote, d.Day, MarketExecution.ReferencePrice(quote) * (decimal)Math.Exp(change));`
- `NationalSpire.CircuitWorld.RoundCount(NationalSpire.WorldCompetition)`；输入表达式：`CircuitWorld.RoundCount(c)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CircuitWorld.RoundCount(c)`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(d, link.Target)`；返回值紧邻使用处：`ConditionalExpressionSyntax: link.Club ? EsportsWorld.ClubName(d, link.Target) : CareerEngine.DisplayName(d, link.Target)`
- `NationalSpire.EsportsWorld.ClubOf(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubOf(d, p.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.EntrantClubs.GetValueOrDefault(p.Id) ?? EsportsWorld.ClubOf(d, p.Id)`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: link.Target == GroupChats.Human(d)`
- `NationalSpire.MarketDynamics.AddEvent(NationalSpire.CareerData, NationalSpire.MarketEvent)`；输入表达式：`MarketDynamics.AddEvent(d, new(d.Day, asset.Id, asset.Name + " · " + string.Join("；", related.Select(p => p.Detail))                  + $"；{c.Name}第{fixture.Round}轮，品牌报价{actual:+0.00%;-0.00%;0.00%}。", actual, related[0].Id, c.Id))`；返回值紧邻使用处：`ExpressionStatementSyntax: MarketDynamics.AddEvent(d, new(d.Day, asset.Id, asset.Name + " · " + string.Join("；", related.Select(p => p.Detail))                  + $"；{c.Name}第{fixture.Round}轮，品牌报价{actual:+0.00%;-0.00%;0.00%}。", actual, related[0].Id, c.Id));`
- `NationalSpire.MarketDynamics.AddEvent(NationalSpire.CareerData, NationalSpire.MarketEvent)`；输入表达式：`MarketDynamics.AddEvent(d, new(d.Day, asset.Id, c.Name + "赛果已计入当前汇率。", (double)(quote.Price / forexBefore - 1), Competition: c.Id))`；返回值紧邻使用处：`ExpressionStatementSyntax: MarketDynamics.AddEvent(d, new(d.Day, asset.Id, c.Name + "赛果已计入当前汇率。", (double)(quote.Price / forexBefore - 1), Competition: c.Id));`
- `NationalSpire.MarketDynamics.BrandChange(string, NationalSpire.MarketAsset, double)`；输入表达式：`MarketDynamics.BrandChange(d.WorldId, asset, related.Average(p => p.Signal))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MarketDynamics.BrandChange(d.WorldId, asset, related.Average(p => p.Signal))`
- `NationalSpire.MarketDynamics.Links(NationalSpire.CareerData)`；输入表达式：`MarketDynamics.Links(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: MarketDynamics.Links(d).GroupBy`
- `NationalSpire.MarketDynamics.ResultSignal(NationalSpire.WorldCompetition, int, bool)`；输入表达式：`MarketDynamics.ResultSignal(c, fixture.Round, link.Club ? p.TeamWon : p.Won)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => MarketDynamics.ResultSignal(c, fixture.Round, link.Club ? p.TeamWon : p.Won)`
- `NationalSpire.MarketEvent.MarketEvent(int, string, string, double, string, string)`；输入表达式：`new(d.Day, asset.Id, asset.Name + " · " + string.Join("；", related.Select(p => p.Detail))                  + $"；{c.Name}第{fixture.Round}轮，品牌报价{actual:+0.00%;-0.00%;0.00%}。", actual, related[0].Id, c.Id)`；返回值紧邻使用处：`ArgumentSyntax: new(d.Day, asset.Id, asset.Name + " · " + string.Join("；", related.Select(p => p.Detail))                  + $"；{c.Name}第{fixture.Round}轮，品牌报价{actual:+0.00%;-0.00%;0.00%}。", actual, related[0].Id, c.Id)`
- `NationalSpire.MarketEvent.MarketEvent(int, string, string, double, string, string)`；输入表达式：`new(d.Day, asset.Id, c.Name + "赛果已计入当前汇率。", (double)(quote.Price / forexBefore - 1), Competition: c.Id)`；返回值紧邻使用处：`ArgumentSyntax: new(d.Day, asset.Id, c.Name + "赛果已计入当前汇率。", (double)(quote.Price / forexBefore - 1), Competition: c.Id)`
- `NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`；输入表达式：`MarketExecution.ReferencePrice(quote)`；返回值紧邻使用处：`BinaryExpressionSyntax: MarketExecution.ReferencePrice(quote) * (decimal)Math.Exp(-(double)delta * .01)`
- `NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`；输入表达式：`MarketExecution.ReferencePrice(quote)`；返回值紧邻使用处：`BinaryExpressionSyntax: MarketExecution.ReferencePrice(quote) * (decimal)Math.Exp(change)`
- `NationalSpire.SeasonCeremony.Participants(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, bool)`；输入表达式：`SeasonCeremony.Participants(d, c, f, false)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: SeasonCeremony.Participants(d, c, f, false).Select`
- `NationalSpire.SeasonCeremony.Participants(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, bool)`；输入表达式：`SeasonCeremony.Participants(d, c, f, true)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: SeasonCeremony.Participants(d, c, f, true)              .Select`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("；", related.Select(p => p.Detail))`；返回值紧邻使用处：`BinaryExpressionSyntax: asset.Name + " · " + string.Join("；", related.Select(p => p.Detail))`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, double>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, double>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`partners.TryGetValue(asset.Name, out var links)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !partners.TryGetValue(asset.Name, out var links)`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`tie.All(f => f.Walkover)`；返回值紧邻使用处：`IfStatementSyntax: if (tie.All(f => f.Walkover)) return;`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`tie.Any(f => !f.Finished || f.Draw)`；返回值紧邻使用处：`BinaryExpressionSyntax: tie.Any(f => !f.Finished || f.Draw) || tie.Any(f => f.MarketSettled)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`tie.Any(f => f.MarketSettled)`；返回值紧邻使用处：`BinaryExpressionSyntax: tie.Any(f => !f.Finished || f.Draw) || tie.Any(f => f.MarketSettled)`
- `System.Collections.Generic.IEnumerable<TSource>.Average<TSource>(System.Func<TSource, double>)`；输入表达式：`related.Average(p => p.Signal)`；返回值紧邻使用处：`ArgumentSyntax: related.Average(p => p.Signal)`
- `System.Collections.Generic.IEnumerable<TSource>.Average<TSource>(System.Func<TSource, double>)`；输入表达式：`seats.Average(p => MarketDynamics.ResultSignal(c, fixture.Round, link.Club ? p.TeamWon : p.Won))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = seats.Average(p => MarketDynamics.ResultSignal(c, fixture.Round, link.Club ? p.TeamWon : p.Won))`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`SeasonCeremony.Participants(d, c, f, true)              .Select(id => (Id: id, TeamWon: home, Won: f.WinnerId == f.HomeId))              .Concat(SeasonCeremony.Participants(d, c, f, false).Select(id => (Id: id, TeamWon: !home, Won: f.WinnerId == f.AwayId)))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: f => SeasonCeremony.Participants(d, c, f, true)              .Select(id => (Id: id, TeamWon: home, Won: f.WinnerId == f.HomeId))              .Concat(SeasonCeremony.Participants(d, c, f, false).Select(id => (Id: id, TeamWon: !home, Won: f.WinnerId == f.AwayId)))`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`tie.Count(f => f.WinnerId == f.AwayId)`；返回值紧邻使用处：`BinaryExpressionSyntax: tie.Count(f => f.WinnerId == f.HomeId) > tie.Count(f => f.WinnerId == f.AwayId)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`tie.Count(f => f.WinnerId == f.HomeId)`；返回值紧邻使用处：`BinaryExpressionSyntax: tie.Count(f => f.WinnerId == f.HomeId) > tie.Count(f => f.WinnerId == f.AwayId)`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`sponsorOutcomes.Where(p => link.Club ? (c.EntrantClubs.GetValueOrDefault(p.Id) ?? EsportsWorld.ClubOf(d, p.Id)) == link.Target                          : p.Id == link.Target || p.Id == "player" && d.HumanIds.Count == 0 && link.Target == GroupChats.Human(d)).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: sponsorOutcomes.Where(p => link.Club ? (c.EntrantClubs.GetValueOrDefault(p.Id) ?? EsportsWorld.ClubOf(d, p.Id)) == link.Target                          : p.Id == link.Target || p.Id == "player" && d.HumanIds.Count == 0 && link.Target == GroupChats.Human(d)).Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`tie.SelectMany(f => new[] { (Id: f.HomeId, Won: home), (Id: f.AwayId, Won: !home) }).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: tie.SelectMany(f => new[] { (Id: f.HomeId, Won: home), (Id: f.AwayId, Won: !home) }).Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`tie.SelectMany(f => SeasonCeremony.Participants(d, c, f, true)              .Select(id => (Id: id, TeamWon: home, Won: f.WinnerId == f.HomeId))              .Concat(SeasonCeremony.Participants(d, c, f, false).Select(id => (Id: id, TeamWon: !home, Won: f.WinnerId == f.AwayId)))).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: tie.SelectMany(f => SeasonCeremony.Participants(d, c, f, true)              .Select(id => (Id: id, TeamWon: home, Won: f.WinnerId == f.HomeId))              .Concat(SeasonCeremony.Participants(d, c, f, false).Select(id => (Id: id, TeamWon: !home, Won: f.WinnerId == f.AwayId)))).Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`MarketDynamics.Links(d).GroupBy(p => p.Brand)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: MarketDynamics.Links(d).GroupBy(p => p.Brand).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`related.Select(p => p.Detail)`；返回值紧邻使用处：`ArgumentSyntax: related.Select(p => p.Detail)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`SeasonCeremony.Participants(d, c, f, false).Select(id => (Id: id, TeamWon: !home, Won: f.WinnerId == f.AwayId))`；返回值紧邻使用处：`ArgumentSyntax: SeasonCeremony.Participants(d, c, f, false).Select(id => (Id: id, TeamWon: !home, Won: f.WinnerId == f.AwayId))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`SeasonCeremony.Participants(d, c, f, true)              .Select(id => (Id: id, TeamWon: home, Won: f.WinnerId == f.HomeId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: SeasonCeremony.Participants(d, c, f, true)              .Select(id => (Id: id, TeamWon: home, Won: f.WinnerId == f.HomeId))              .Concat`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`tie.SelectMany(f => new[] { (Id: f.HomeId, Won: home), (Id: f.AwayId, Won: !home) })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: tie.SelectMany(f => new[] { (Id: f.HomeId, Won: home), (Id: f.AwayId, Won: !home) }).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`tie.SelectMany(f => SeasonCeremony.Participants(d, c, f, true)              .Select(id => (Id: id, TeamWon: home, Won: f.WinnerId == f.HomeId))              .Concat(SeasonCeremony.Participants(d, c, f, false).Select(id => (Id: id, TeamWon: !home, Won: f.WinnerId == f.AwayId))))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: tie.SelectMany(f => SeasonCeremony.Participants(d, c, f, true)              .Select(id => (Id: id, TeamWon: home, Won: f.WinnerId == f.HomeId))              .Concat(SeasonCeremony.Participants(d, c, f, false).Select(id => (Id: id, TeamWon: !home, Won: f.WinnerId == f.AwayId)))).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`c.Fixtures.Where(f => f.Round == fixture.Round && f.HomeTeam == fixture.HomeTeam && f.AwayTeam == fixture.AwayTeam).ToArray()`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.TeamEvent ? c.Fixtures.Where(f => f.Round == fixture.Round && f.HomeTeam == fixture.HomeTeam && f.AwayTeam == fixture.AwayTeam).ToArray() : [fixture]`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`g.ToArray()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`sponsorOutcomes.Where(p => link.Club ? (c.EntrantClubs.GetValueOrDefault(p.Id) ?? EsportsWorld.ClubOf(d, p.Id)) == link.Target                          : p.Id == link.Target || p.Id == "player" && d.HumanIds.Count == 0 && link.Target == GroupChats.Human(d)).Distinct().ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = sponsorOutcomes.Where(p => link.Club ? (c.EntrantClubs.GetValueOrDefault(p.Id) ?? EsportsWorld.ClubOf(d, p.Id)) == link.Target                          : p.Id == link.Target || p.Id == "player" && d.HumanIds.Count == 0 && link.Target == GroupChats.Human(d)).Distinct().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`tie.SelectMany(f => new[] { (Id: f.HomeId, Won: home), (Id: f.AwayId, Won: !home) }).Distinct().ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = tie.SelectMany(f => new[] { (Id: f.HomeId, Won: home), (Id: f.AwayId, Won: !home) }).Distinct().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`tie.SelectMany(f => SeasonCeremony.Participants(d, c, f, true)              .Select(id => (Id: id, TeamWon: home, Won: f.WinnerId == f.HomeId))              .Concat(SeasonCeremony.Participants(d, c, f, false).Select(id => (Id: id, TeamWon: !home, Won: f.WinnerId == f.AwayId)))).Distinct().ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = tie.SelectMany(f => SeasonCeremony.Participants(d, c, f, true)              .Select(id => (Id: id, TeamWon: home, Won: f.WinnerId == f.HomeId))              .Concat(SeasonCeremony.Participants(d, c, f, false).Select(id => (Id: id, TeamWon: !home, Won: f.WinnerId == f.AwayId)))).Distinct().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`MarketDynamics.Links(d).GroupBy(p => p.Brand).ToDictionary(g => g.Key, g => g.ToArray())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MarketDynamics.Links(d).GroupBy(p => p.Brand).ToDictionary(g => g.Key, g => g.ToArray())`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(f => f.Round == fixture.Round && f.HomeTeam == fixture.HomeTeam && f.AwayTeam == fixture.AwayTeam)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.Round == fixture.Round && f.HomeTeam == fixture.HomeTeam && f.AwayTeam == fixture.AwayTeam).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`sponsorOutcomes.Where(p => link.Club ? (c.EntrantClubs.GetValueOrDefault(p.Id) ?? EsportsWorld.ClubOf(d, p.Id)) == link.Target                          : p.Id == link.Target || p.Id == "player" && d.HumanIds.Count == 0 && link.Target == GroupChats.Human(d))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: sponsorOutcomes.Where(p => link.Club ? (c.EntrantClubs.GetValueOrDefault(p.Id) ?? EsportsWorld.ClubOf(d, p.Id)) == link.Target                          : p.Id == link.Target || p.Id == "player" && d.HumanIds.Count == 0 && link.Target == GroupChats.Human(d)).Distinct`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`c.EntrantClubs.GetValueOrDefault(p.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.EntrantClubs.GetValueOrDefault(p.Id) ?? EsportsWorld.ClubOf(d, p.Id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`c.EntrantCountries.GetValueOrDefault(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.EntrantCountries.GetValueOrDefault(id) ?? CareerEngine.Person(d, id)?.Country ?? d.Esports.Country`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`signals.GetValueOrDefault("中国")`；返回值紧邻使用处：`BinaryExpressionSyntax: signals.GetValueOrDefault(asset.Country) - signals.GetValueOrDefault("中国")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`signals.GetValueOrDefault(asset.Country)`；返回值紧邻使用处：`BinaryExpressionSyntax: signals.GetValueOrDefault(asset.Country) - signals.GetValueOrDefault("中国")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`signals.GetValueOrDefault(nation)`；返回值紧邻使用处：`BinaryExpressionSyntax: signals.GetValueOrDefault(nation) + signal / tie.Length`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`related.Add((seats[0].Id, (link.Club ? "俱乐部赞助：" : "个人代言：") + subject + (signal > 0 ? "获胜" : signal < 0 ? "失利" : "本轮无净利好"), signal))`；返回值紧邻使用处：`ExpressionStatementSyntax: related.Add((seats[0].Id, (link.Club ? "俱乐部赞助：" : "个人代言：") + subject + (signal > 0 ? "获胜" : signal < 0 ? "失利" : "本轮无净利好"), signal));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<(string Id, string Detail, double Signal)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<(string Id, string Detail, double Signal)>()`
- `System.Math.Clamp(decimal, decimal, decimal)`；输入表达式：`Math.Clamp(quote.PendingSignal, -4, 4)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Clamp(quote.PendingSignal, -4, 4)`
- `System.Math.Exp(double)`；输入表达式：`Math.Exp(-(double)delta * .01)`；返回值紧邻使用处：`CastExpressionSyntax: (decimal)Math.Exp(-(double)delta * .01)`
- `System.Math.Exp(double)`；输入表达式：`Math.Exp(change)`；返回值紧邻使用处：`CastExpressionSyntax: (decimal)Math.Exp(change)`
- `System.Math.Pow(double, double)`；输入表达式：`Math.Pow(.5, fixture.Round - 1)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: -Math.Pow(.5, fixture.Round - 1)`

**赋值（含属性/字段和局部值）：**

- `f.MarketSettled` = `true`
- `quote.AppliedSignal` = `0`
- `quote.AppliedSignal` = `applied`
- `quote.PendingSignal` += `(decimal)signal`
- `quote.PendingSignal` = `quote.AppliedSignal = 0`
- `quote.SignalDay` = `d.Day`
- `signals[nation]` = `signals.GetValueOrDefault(nation) + signal / tie.Length`

<a id="symbol-8f53c28594f3"></a>

## `NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int) — public static decimal OpenFee(MarketAsset asset, decimal margin, int leverage)`

来源：源码第 213 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.BudgetMargin(NationalSpire.MarketAsset, decimal, int, int)`](CareerMarket.cs.md#symbol-f2a928a00b17)；[`NationalSpire.CareerMarket.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`](CareerMarket.cs.md#symbol-6b9ac5b0686c)；[`NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-2508c79f1fc5)；[`NationalSpire.MarketTerminal.RefreshFee()`](MarketTerminal.cs.md#symbol-1c08f523080f)

**调用：** `decimal.Round(decimal, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMarket.FeeRate`；`NationalSpire.MarketAsset.Forex`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.Round(decimal, int)`；输入表达式：`decimal.Round(margin * leverage * (asset.Forex ? .00005m + leverage * .000005m : FeeRate), 4)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => decimal.Round(margin * leverage * (asset.Forex ? .00005m + leverage * .000005m : FeeRate), 4)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f2a928a00b17"></a>

## `NationalSpire.CareerMarket.BudgetMargin(NationalSpire.MarketAsset, decimal, int, int) — public static decimal BudgetMargin(MarketAsset asset, decimal cash, int leverage, int percent)`

来源：源码第 214 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.RefreshFee()`](MarketTerminal.cs.md#symbol-1c08f523080f)

**调用：** [`NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`](CareerMarket.cs.md#symbol-8f53c28594f3)；`decimal.Floor(decimal)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.Floor(decimal)`；输入表达式：`decimal.Floor(budget / (1 + OpenFee(asset, 100000, leverage) / 100000) * 1000)`；返回值紧邻使用处：`BinaryExpressionSyntax: decimal.Floor(budget / (1 + OpenFee(asset, 100000, leverage) / 100000) * 1000) / 1000`
- `NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`；输入表达式：`OpenFee(asset, 100000, leverage)`；返回值紧邻使用处：`BinaryExpressionSyntax: OpenFee(asset, 100000, leverage) / 100000`
- `NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`；输入表达式：`OpenFee(asset, margin + .001m, leverage)`；返回值紧邻使用处：`BinaryExpressionSyntax: margin + .001m + OpenFee(asset, margin + .001m, leverage)`
- `NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`；输入表达式：`OpenFee(asset, margin, leverage)`；返回值紧邻使用处：`BinaryExpressionSyntax: margin + OpenFee(asset, margin, leverage)`

**赋值（含属性/字段和局部值）：**

- `margin` -= `.001m`
- `margin` += `.001m`

<a id="symbol-6b9ac5b0686c"></a>

## `NationalSpire.CareerMarket.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder) — public static string? Trade(CareerData d, MarketOrder order)`

来源：源码第 223 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.Trade(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.MarketOrder)`](Coop/CoopMarket.cs.md#symbol-a60daf1be116)；[`NationalSpire.EconomicActions.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`](EconomicActions.cs.md#symbol-f0516c3ecf95)

**调用：** [`NationalSpire.CareerMarket.Accounts(NationalSpire.CareerData, int)`](CareerMarket.cs.md#symbol-5182135836a6)；[`NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`](CareerMarket.cs.md#symbol-8f53c28594f3)；[`NationalSpire.CareerMarket.Record(NationalSpire.MarketAccount, int, string, decimal)`](CareerMarket.cs.md#symbol-a7af74d3e50b)；[`NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`](LifeData.cs.md#symbol-bcb55555a432)；[`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`](LifeData.cs.md#symbol-de5af63fa4e7)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`](LifeData.cs.md#symbol-54a09649188b)；[`NationalSpire.MarketExecution.Apply(NationalSpire.MarketState, string, NationalSpire.MarketExecution.Fill, int)`](MarketExecution.cs.md#symbol-9ad4ae339dd8)；[`NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-2508c79f1fc5)；[`NationalSpire.MarketExecution.Open(NationalSpire.MarketAsset, NationalSpire.MarketQuote, decimal, int)`](MarketExecution.cs.md#symbol-1d104843be66)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`decimal.Round(decimal, int)`；`NationalSpire.MarketPosition.MarketPosition()`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Remove(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Market`；`NationalSpire.CareerLifeState.Trading`；`NationalSpire.CareerMarket.Accounts(NationalSpire.CareerData, int)`；`NationalSpire.CareerMarket.Leverages`；`NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`；`NationalSpire.CareerMarket.Record(NationalSpire.MarketAccount, int, string, decimal)`；`NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`；`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；`NationalSpire.MarketAccount.Cash`；`NationalSpire.MarketAccount.Debt`；`NationalSpire.MarketAccount.InterestDay`；`NationalSpire.MarketAccount.InterestRate`；`NationalSpire.MarketAccount.NextPosition`；`NationalSpire.MarketAccount.Positions`；`NationalSpire.MarketAsset.Id`；`NationalSpire.MarketAsset.Name`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketExecution.Apply(NationalSpire.MarketState, string, NationalSpire.MarketExecution.Fill, int)`；`NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`；`NationalSpire.MarketExecution.Exit.Fill`；`NationalSpire.MarketExecution.Exit.Proceeds`；`NationalSpire.MarketExecution.Fill.Average`；`NationalSpire.MarketExecution.Fill.Units`；`NationalSpire.MarketExecution.Open(NationalSpire.MarketAsset, NationalSpire.MarketQuote, decimal, int)`；`NationalSpire.MarketOrder.Action`；`NationalSpire.MarketOrder.Amount`；`NationalSpire.MarketOrder.Asset`；`NationalSpire.MarketOrder.Direction`；`NationalSpire.MarketOrder.Leverage`；`NationalSpire.MarketOrder.Position`；`NationalSpire.MarketOrder.QuoteRevision`；`NationalSpire.MarketOrder.StopPrice`；`NationalSpire.MarketPosition.Asset`；`NationalSpire.MarketPosition.Direction`；`NationalSpire.MarketPosition.Entry`；`NationalSpire.MarketPosition.Id`；`NationalSpire.MarketPosition.InitialMargin`；`NationalSpire.MarketPosition.Leverage`；`NationalSpire.MarketPosition.Margin`；`NationalSpire.MarketPosition.OpeningFee`；`NationalSpire.MarketPosition.StopPrice`；`NationalSpire.MarketPosition.Units`；`NationalSpire.MarketQuote.Price`；`NationalSpire.MarketState.Quotes`；`NationalSpire.MarketState.Revision`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.MarketTrade`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.Round(decimal, int)`；输入表达式：`decimal.Round(order.Amount, 4)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = decimal.Round(order.Amount, 4)`
- `NationalSpire.CareerMarket.Accounts(NationalSpire.CareerData, int)`；输入表达式：`Accounts(d, d.Day)`；返回值紧邻使用处：`ExpressionStatementSyntax: Accounts(d, d.Day);`
- `NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`；输入表达式：`OpenFee(asset, amount, order.Leverage)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = OpenFee(asset, amount, order.Leverage)`
- `NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`；输入表达式：`OpenFee(MarketCatalog.ById[funded.Asset], funded.Margin, funded.Leverage)`；返回值紧邻使用处：`AssignmentExpressionSyntax: funded.OpeningFee ??= OpenFee(MarketCatalog.ById[funded.Asset], funded.Margin, funded.Leverage)`
- `NationalSpire.CareerMarket.Record(NationalSpire.MarketAccount, int, string, decimal)`；输入表达式：`Record(account, d.Day, order.Action switch { "deposit" => "转入", "withdraw" => "转出", "borrow" => "借款", "repay" or "repay-all" => "还款", "open" => MarketCatalog.ById[order.Asset].Name + "建仓", "margin" => "追加保证金", "stop" => order.StopPrice == null ? "取消止损" : "设置止损", _ => "平仓" }, amount)`；返回值紧邻使用处：`ExpressionStatementSyntax: Record(account, d.Day, order.Action switch { "deposit" => "转入", "withdraw" => "转出", "borrow" => "借款", "repay" or "repay-all" => "还款", "open" => MarketCatalog.ById[order.Asset].Name + "建仓", "margin" => "追加保证金", "stop" => order.StopPrice == null ? "取消止损" : "设置止损", _ => "平仓" }, amount);`
- `NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`；输入表达式：`CareerMoney.Add(d, -amount)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Add(d, -amount);`
- `NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`；输入表达式：`CareerMoney.Add(d, amount)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Add(d, amount);`
- `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；输入表达式：`CareerMoney.Balance(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: amount > CareerMoney.Balance(d)`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(amount - account.Cash)`；返回值紧邻使用处：`BinaryExpressionSyntax: "交易账户余额不足，还差" + CareerMoney.Format(amount - account.Cash)`
- `NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；输入表达式：`CareerMoney.Record(d, "交易账户转出", amount)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Record(d, "交易账户转出", amount);`
- `NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；输入表达式：`CareerMoney.Record(d, "交易账户转入", -amount)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Record(d, "交易账户转入", -amount);`
- `NationalSpire.MarketExecution.Apply(NationalSpire.MarketState, string, NationalSpire.MarketExecution.Fill, int)`；输入表达式：`MarketExecution.Apply(d.Market, asset.Id, fill, d.Day)`；返回值紧邻使用处：`ExpressionStatementSyntax: MarketExecution.Apply(d.Market, asset.Id, fill, d.Day);`
- `NationalSpire.MarketExecution.Apply(NationalSpire.MarketState, string, NationalSpire.MarketExecution.Fill, int)`；输入表达式：`MarketExecution.Apply(d.Market, position.Asset, exit.Fill, d.Day)`；返回值紧邻使用处：`ExpressionStatementSyntax: MarketExecution.Apply(d.Market, position.Asset, exit.Fill, d.Day);`
- `NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`；输入表达式：`MarketExecution.Close(position, d.Market.Quotes[position.Asset])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MarketExecution.Close(position, d.Market.Quotes[position.Asset])`
- `NationalSpire.MarketExecution.Open(NationalSpire.MarketAsset, NationalSpire.MarketQuote, decimal, int)`；输入表达式：`MarketExecution.Open(asset, d.Market.Quotes[asset.Id], amount * order.Leverage, order.Direction)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MarketExecution.Open(asset, d.Market.Quotes[asset.Id], amount * order.Leverage, order.Direction)`
- `NationalSpire.MarketPosition.MarketPosition()`；输入表达式：`new() { Id = ++account.NextPosition, Asset = asset.Id, Entry = fill.Average, Margin = amount, InitialMargin = amount, OpeningFee = fee,                      Units = fill.Units, Direction = order.Direction, Leverage = order.Leverage }`；返回值紧邻使用处：`ArgumentSyntax: new() { Id = ++account.NextPosition, Asset = asset.Id, Entry = fill.Average, Margin = amount, InitialMargin = amount, OpeningFee = fee,                      Units = fill.Units, Direction = order.Direction, Leverage = order.Leverage }`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.MarketTrade)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.MarketTrade)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`Leverages.Contains(order.Leverage)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Leverages.Contains(order.Leverage)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`account.Positions.FirstOrDefault(p => p.Id == order.Position)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = account.Positions.FirstOrDefault(p => p.Id == order.Position)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`MarketCatalog.ById.TryGetValue(order.Asset, out var asset)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !MarketCatalog.ById.TryGetValue(order.Asset, out var asset)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`account.Positions.Add(new() { Id = ++account.NextPosition, Asset = asset.Id, Entry = fill.Average, Margin = amount, InitialMargin = amount, OpeningFee = fee,                      Units = fill.Units, Direction = order.Direction, Leverage = order.Leverage })`；返回值紧邻使用处：`ExpressionStatementSyntax: account.Positions.Add(new() { Id = ++account.NextPosition, Asset = asset.Id, Entry = fill.Average, Margin = amount, InitialMargin = amount, OpeningFee = fee,                      Units = fill.Units, Direction = order.Direction, Leverage = order.Leverage });`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`account.Positions.Remove(position)`；返回值紧邻使用处：`ExpressionStatementSyntax: account.Positions.Remove(position);`

**赋值（含属性/字段和局部值）：**

- `account.Cash` -= `amount + fee`
- `account.Cash` -= `amount`
- `account.Cash` += `amount`
- `account.Debt` -= `amount`
- `account.Debt` += `amount`
- `account.Debt` = `0`
- `account.InterestDay` = `d.Day`
- `account.InterestRate` = `amount <= 500 ? .0002m : amount <= 2000 ? .0004m : .0007m`
- `amount` = `-(amount + fee)`
- `amount` = `-amount`
- `amount` = `0`
- `amount` = `account.Debt`
- `amount` = `exit.Proceeds`
- `Asset` = `asset.Id`
- `Direction` = `order.Direction`
- `Entry` = `fill.Average`
- `funded.InitialMargin` ??= `funded.Margin`
- `funded.Margin` += `amount`
- `funded.OpeningFee` ??= `OpenFee(MarketCatalog.ById[funded.Asset], funded.Margin, funded.Leverage)`
- `Id` = `++account.NextPosition`
- `InitialMargin` = `amount`
- `Leverage` = `order.Leverage`
- `Margin` = `amount`
- `OpeningFee` = `fee`
- `protectedPosition.StopPrice` = `order.StopPrice`
- `Units` = `fill.Units`
