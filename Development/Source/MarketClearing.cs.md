# MarketClearing.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`42BEF84BFA7ECCBC89EF982109EB3D105CF0900DE79F78483635DF3A0977856D`。来源：[源码](../../MarketClearing.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.MarketClearing`、`NationalSpire.MarketClearing.Closed`、`NationalSpire.MarketClearing.Result`、`NationalSpire.MarketClearing.Slot`、`NationalSpire.MarketClearing.Work`、`NationalSpire.MarketClearing.Session`。

字段、事件及初始值（源码原样）：

```csharp
public readonly MarketAccount Owner;
public readonly MarketPosition Position;
public readonly decimal Units, Fraction, CashBasis, PriceCoefficient, AdverseCoefficient;
public readonly bool MarginApplies;
public bool Active = true;
public readonly Slot Slot = slot;
public readonly string Reason = reason;
public decimal Remaining = slot.Units;
public decimal Notional;
public readonly Result Result;
private readonly List<Slot> slots;
private readonly MarketAsset asset;
private readonly MarketAccount previewOwner;
```

<a id="symbol-ddbe88ed5339"></a>

## `NationalSpire.MarketClearing.Result.Quote — public required MarketQuote Quote`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3a292728de0d"></a>

## `NationalSpire.MarketClearing.Result.Closed — public List<Closed> Closed`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2f7c12fe1b47"></a>

## `NationalSpire.MarketClearing.Result.Margin — public decimal Margin`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ca22e98eb222"></a>

## `NationalSpire.MarketClearing.Result.Units — public decimal Units`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d0bc7640da6d"></a>

## `NationalSpire.MarketClearing.Result.Average — public decimal Average`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5b8d93184f30"></a>

## `NationalSpire.MarketClearing.Result.Fee — public decimal Fee`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5103fd391bb3"></a>

## `NationalSpire.MarketClearing.Result.Accepted — public bool Accepted`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-38e5a9352f64"></a>

## `NationalSpire.MarketClearing.Result.Reason — public string Reason`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2192e2bdcb1e"></a>

## `NationalSpire.MarketClearing.Accounts(NationalSpire.CareerData) — public static IReadOnlyList<MarketAccount> Accounts(CareerData d)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Price(NationalSpire.CareerData, string, int, decimal)`](CareerMarket.cs.md#symbol-510ed75879b6)；[`NationalSpire.CareerMarket.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`](CareerMarket.cs.md#symbol-6b9ac5b0686c)；[`NationalSpire.MarketClearing.Inspect(NationalSpire.CareerData, NationalSpire.MarketInspection)`](MarketClearing.cs.md#symbol-d078c0ca2b29)；[`NationalSpire.MarketClearing.Preview(NationalSpire.CareerData, NationalSpire.MarketOrder, bool)`](MarketClearing.cs.md#symbol-e90e0ab892c9)；[`NationalSpire.MarketClearing.PreviewClose(NationalSpire.CareerData, NationalSpire.MarketPosition)`](MarketClearing.cs.md#symbol-554374f533fb)；[`NationalSpire.MarketTerminal.RefreshAccount(bool)`](MarketTerminal.cs.md#symbol-9559baf40113)

**调用：** `System.Func<TResult>.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerData.TradingAccounts`；`NationalSpire.CareerLifeState.Trading`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Func<TResult>.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: d.TradingAccounts?.Invoke()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8655b084ac17"></a>

## `NationalSpire.MarketClearing.Summary(NationalSpire.MarketClearing.Result) — public static MarketOrderPreview Summary(Result r)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.MarketSubmit(NationalSpire.CareerData, NationalSpire.MarketOrder)`](MarketScreen.cs.md#symbol-fbc36ef790b1)；[`NationalSpire.MarketClearing.Inspect(NationalSpire.CareerData, NationalSpire.MarketInspection)`](MarketClearing.cs.md#symbol-d078c0ca2b29)

**调用：** `NationalSpire.MarketOrderPreview.MarketOrderPreview(bool, string, decimal, decimal, decimal)`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketClearing.Result.Accepted`；`NationalSpire.MarketClearing.Result.Average`；`NationalSpire.MarketClearing.Result.Fee`；`NationalSpire.MarketClearing.Result.Margin`；`NationalSpire.MarketClearing.Result.Reason`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketOrderPreview.MarketOrderPreview(bool, string, decimal, decimal, decimal)`；输入表达式：`new(r.Accepted, r.Reason, r.Margin, r.Average, r.Fee)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new(r.Accepted, r.Reason, r.Margin, r.Average, r.Fee)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d078c0ca2b29"></a>

## `NationalSpire.MarketClearing.Inspect(NationalSpire.CareerData, NationalSpire.MarketInspection) — public static MarketInspectionResult Inspect(CareerData d, MarketInspection request)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.InspectMarket(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.MarketInspection)`](Coop/CoopMarket.cs.md#symbol-6aa505a8b0a6)

**调用：** [`NationalSpire.MarketClearing.Accounts(NationalSpire.CareerData)`](MarketClearing.cs.md#symbol-2192e2bdcb1e)；[`NationalSpire.MarketClearing.Preview(NationalSpire.CareerData, NationalSpire.MarketOrder, bool)`](MarketClearing.cs.md#symbol-e90e0ab892c9)；[`NationalSpire.MarketClearing.PreviewClose(NationalSpire.CareerData, NationalSpire.MarketPosition)`](MarketClearing.cs.md#symbol-554374f533fb)；[`NationalSpire.MarketClearing.Summary(NationalSpire.MarketClearing.Result)`](MarketClearing.cs.md#symbol-8655b084ac17)；[`NationalSpire.MarketExecution.LiquidationValue(NationalSpire.MarketState, NationalSpire.MarketAccount, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>?)`](MarketExecution.cs.md#symbol-38a7df5abf7b)；`NationalSpire.MarketInspectionResult.MarketInspectionResult(long, decimal, NationalSpire.MarketOrderPreview, NationalSpire.MarketOrderPreview, System.Collections.Generic.Dictionary<int, NationalSpire.MarketExecution.Exit>)`；`NationalSpire.MarketOrder.MarketOrder(string, string, decimal, int, int, int, long, decimal?)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Market`；`NationalSpire.CareerLifeState.Trading`；`NationalSpire.MarketAccount.Positions`；`NationalSpire.MarketClearing.Accounts(NationalSpire.CareerData)`；`NationalSpire.MarketClearing.Preview(NationalSpire.CareerData, NationalSpire.MarketOrder, bool)`；`NationalSpire.MarketClearing.PreviewClose(NationalSpire.CareerData, NationalSpire.MarketPosition)`；`NationalSpire.MarketClearing.Summary(NationalSpire.MarketClearing.Result)`；`NationalSpire.MarketExecution.LiquidationValue(NationalSpire.MarketState, NationalSpire.MarketAccount, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>?)`；`NationalSpire.MarketInspection.Amount`；`NationalSpire.MarketInspection.Asset`；`NationalSpire.MarketInspection.Leverage`；`NationalSpire.MarketInspection.Positions`；`NationalSpire.MarketInspection.Suggest`；`NationalSpire.MarketPosition.Id`；`NationalSpire.MarketState.Revision`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketClearing.Accounts(NationalSpire.CareerData)`；输入表达式：`Accounts(d)`；返回值紧邻使用处：`ArgumentSyntax: Accounts(d)`
- `NationalSpire.MarketClearing.Preview(NationalSpire.CareerData, NationalSpire.MarketOrder, bool)`；输入表达式：`Preview(d, new("open", request.Asset, request.Amount, -1, request.Leverage), request.Suggest)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Preview(d, new("open", request.Asset, request.Amount, -1, request.Leverage), request.Suggest)`
- `NationalSpire.MarketClearing.Preview(NationalSpire.CareerData, NationalSpire.MarketOrder, bool)`；输入表达式：`Preview(d, new("open", request.Asset, request.Amount, 1, request.Leverage), request.Suggest)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Preview(d, new("open", request.Asset, request.Amount, 1, request.Leverage), request.Suggest)`
- `NationalSpire.MarketClearing.PreviewClose(NationalSpire.CareerData, NationalSpire.MarketPosition)`；输入表达式：`PreviewClose(d, p)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => PreviewClose(d, p)`
- `NationalSpire.MarketClearing.Summary(NationalSpire.MarketClearing.Result)`；输入表达式：`Summary(buy)`；返回值紧邻使用处：`ArgumentSyntax: Summary(buy)`
- `NationalSpire.MarketClearing.Summary(NationalSpire.MarketClearing.Result)`；输入表达式：`Summary(sell)`；返回值紧邻使用处：`ArgumentSyntax: Summary(sell)`
- `NationalSpire.MarketExecution.LiquidationValue(NationalSpire.MarketState, NationalSpire.MarketAccount, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>?)`；输入表达式：`MarketExecution.LiquidationValue(d.Market, d.Life.Trading, Accounts(d))`；返回值紧邻使用处：`ArgumentSyntax: MarketExecution.LiquidationValue(d.Market, d.Life.Trading, Accounts(d))`
- `NationalSpire.MarketInspectionResult.MarketInspectionResult(long, decimal, NationalSpire.MarketOrderPreview, NationalSpire.MarketOrderPreview, System.Collections.Generic.Dictionary<int, NationalSpire.MarketExecution.Exit>)`；输入表达式：`new(d.Market.Revision, MarketExecution.LiquidationValue(d.Market, d.Life.Trading, Accounts(d)), Summary(buy), Summary(sell), exits)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(d.Market.Revision, MarketExecution.LiquidationValue(d.Market, d.Life.Trading, Accounts(d)), Summary(buy), Summary(sell), exits);`
- `NationalSpire.MarketOrder.MarketOrder(string, string, decimal, int, int, int, long, decimal?)`；输入表达式：`new("open", request.Asset, request.Amount, -1, request.Leverage)`；返回值紧邻使用处：`ArgumentSyntax: new("open", request.Asset, request.Amount, -1, request.Leverage)`
- `NationalSpire.MarketOrder.MarketOrder(string, string, decimal, int, int, int, long, decimal?)`；输入表达式：`new("open", request.Asset, request.Amount, 1, request.Leverage)`；返回值紧邻使用处：`ArgumentSyntax: new("open", request.Asset, request.Amount, 1, request.Leverage)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`request.Positions.Contains(p.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => request.Positions.Contains(p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`d.Life.Trading.Positions.Where(p => request.Positions.Contains(p.Id)).ToDictionary(p => p.Id, p => PreviewClose(d, p))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Life.Trading.Positions.Where(p => request.Positions.Contains(p.Id)).ToDictionary(p => p.Id, p => PreviewClose(d, p))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Trading.Positions.Where(p => request.Positions.Contains(p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Trading.Positions.Where(p => request.Positions.Contains(p.Id)).ToDictionary`

**赋值（含属性/字段和局部值）：**


<a id="symbol-01242bd01825"></a>

## `NationalSpire.MarketClearing.Price(NationalSpire.MarketQuote) — public static decimal Price(MarketQuote q)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketClearing.Commit(NationalSpire.MarketState, string, NationalSpire.MarketClearing.Result, int)`](MarketClearing.cs.md#symbol-fd783a2c49ef)；[`NationalSpire.MarketClearing.Session.Move(decimal, int, bool)`](MarketClearing.cs.md#symbol-010c7c45a36f)；[`NationalSpire.MarketClearing.Session.Next(decimal, int, bool)`](MarketClearing.cs.md#symbol-c4416168b119)；[`NationalSpire.MarketClearing.Session.Open(decimal, int, int)`](MarketClearing.cs.md#symbol-318331fe9749)；[`NationalSpire.MarketClearing.Session.Reprice(decimal)`](MarketClearing.cs.md#symbol-07ff00e14994)；[`NationalSpire.MarketExecution.Consume(NationalSpire.MarketQuote, NationalSpire.MarketAsset, NationalSpire.MarketExecution.Fill)`](MarketExecution.cs.md#symbol-d38348a5d5b3)；[`NationalSpire.MarketExecution.Reprice(NationalSpire.MarketQuote, decimal)`](MarketExecution.cs.md#symbol-d2f4f8cbac5d)

**调用：** [`NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-90e04f0c7b2e)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`；`NationalSpire.MarketQuote.ClearingDepthUnits`；`NationalSpire.MarketQuote.LongUnits`；`NationalSpire.MarketQuote.ShortUnits`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`；输入表达式：`MarketExecution.ReferencePrice(q)`；返回值紧邻使用处：`BinaryExpressionSyntax: MarketExecution.ReferencePrice(q) * (q.ClearingDepthUnits > 0 ? 1 + (q.LongUnits - q.ShortUnits) / (2 * q.ClearingDepthUnits) : 1)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-64464988b285"></a>

## `NationalSpire.MarketClearing.Capacity(NationalSpire.MarketAsset, NationalSpire.MarketQuote) — private static decimal Capacity(MarketAsset a, MarketQuote q)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketClearing.Session.Session(NationalSpire.MarketAsset, NationalSpire.MarketQuote, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>)`](MarketClearing.cs.md#symbol-510ea2f6756a)

**调用：** [`NationalSpire.MarketExecution.Depth(NationalSpire.MarketAsset)`](MarketExecution.cs.md#symbol-c74291f4d6c7)；[`NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-90e04f0c7b2e)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketExecution.Depth(NationalSpire.MarketAsset)`；`NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`；`NationalSpire.MarketQuote.ClearingDepthUnits`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketExecution.Depth(NationalSpire.MarketAsset)`；输入表达式：`MarketExecution.Depth(a)`；返回值紧邻使用处：`BinaryExpressionSyntax: MarketExecution.Depth(a) / MarketExecution.ReferencePrice(q)`
- `NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`；输入表达式：`MarketExecution.ReferencePrice(q)`；返回值紧邻使用处：`BinaryExpressionSyntax: MarketExecution.Depth(a) / MarketExecution.ReferencePrice(q)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5f9bf3d5e43b"></a>

## `NationalSpire.MarketClearing.Average(NationalSpire.MarketQuote, decimal, int) — private static decimal Average(MarketQuote q, decimal units, int direction)`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketClearing.Exit(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`](MarketClearing.cs.md#symbol-3d4f1358211c)；[`NationalSpire.MarketClearing.Session.Move(decimal, int, bool)`](MarketClearing.cs.md#symbol-010c7c45a36f)；[`NationalSpire.MarketClearing.Session.Open(decimal, int, int)`](MarketClearing.cs.md#symbol-318331fe9749)

**调用：** [`NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-90e04f0c7b2e)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`；`NationalSpire.MarketQuote.ClearingDepthUnits`；`NationalSpire.MarketQuote.LongUnits`；`NationalSpire.MarketQuote.ShortUnits`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`；输入表达式：`MarketExecution.ReferencePrice(q)`；返回值紧邻使用处：`BinaryExpressionSyntax: MarketExecution.ReferencePrice(q) * (1 + (q.LongUnits - q.ShortUnits) / (2 * q.ClearingDepthUnits) + direction * units / (4 * q.ClearingDepthUnits))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-aa62127e5a9c"></a>

## `NationalSpire.MarketClearing.Quantity(NationalSpire.MarketQuote, decimal, int) — private static decimal Quantity(MarketQuote q, decimal notional, int direction)`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketClearing.Session.Open(decimal, int, int)`](MarketClearing.cs.md#symbol-318331fe9749)

**调用：** [`NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-90e04f0c7b2e)；`System.Math.Sqrt(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`；`NationalSpire.MarketQuote.ClearingDepthUnits`；`NationalSpire.MarketQuote.LongUnits`；`NationalSpire.MarketQuote.ShortUnits`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`；输入表达式：`MarketExecution.ReferencePrice(q)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MarketExecution.ReferencePrice(q)`
- `System.Math.Sqrt(double)`；输入表达式：`Math.Sqrt((double)square)`；返回值紧邻使用处：`CastExpressionSyntax: (decimal)Math.Sqrt((double)square)`

**赋值（含属性/字段和局部值）：**

- `root` = `(root + square / root) / 2`

<a id="symbol-baa56ed8a802"></a>

## `NationalSpire.MarketClearing.ExitRate(NationalSpire.MarketAsset) — private static decimal ExitRate(MarketAsset a)`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketClearing.Exit(NationalSpire.MarketPosition, decimal)`](MarketClearing.cs.md#symbol-de97bac9e6b1)；[`NationalSpire.MarketClearing.Slot.Slot(NationalSpire.MarketAccount, NationalSpire.MarketPosition, decimal)`](MarketClearing.cs.md#symbol-ce8c2e166c19)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMarket.FeeRate`；`NationalSpire.MarketAsset.Forex`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3d4f1358211c"></a>

## `NationalSpire.MarketClearing.Exit(NationalSpire.MarketPosition, NationalSpire.MarketQuote) — public static MarketExecution.Exit Exit(MarketPosition p, MarketQuote q)`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-2508c79f1fc5)

**调用：** [`NationalSpire.MarketClearing.Average(NationalSpire.MarketQuote, decimal, int)`](MarketClearing.cs.md#symbol-5f9bf3d5e43b)；[`NationalSpire.MarketClearing.Exit(NationalSpire.MarketPosition, decimal)`](MarketClearing.cs.md#symbol-de97bac9e6b1)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketClearing.Average(NationalSpire.MarketQuote, decimal, int)`；`NationalSpire.MarketClearing.Exit(NationalSpire.MarketPosition, decimal)`；`NationalSpire.MarketPosition.Direction`；`NationalSpire.MarketPosition.Units`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketClearing.Average(NationalSpire.MarketQuote, decimal, int)`；输入表达式：`Average(q, (decimal)p.Units, -p.Direction)`；返回值紧邻使用处：`ArgumentSyntax: Average(q, (decimal)p.Units, -p.Direction)`
- `NationalSpire.MarketClearing.Exit(NationalSpire.MarketPosition, decimal)`；输入表达式：`Exit(p, Average(q, (decimal)p.Units, -p.Direction))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Exit(p, Average(q, (decimal)p.Units, -p.Direction))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-de97bac9e6b1"></a>

## `NationalSpire.MarketClearing.Exit(NationalSpire.MarketPosition, decimal) — private static MarketExecution.Exit Exit(MarketPosition p, decimal average)`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketClearing.Exit(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`](MarketClearing.cs.md#symbol-3d4f1358211c)；[`NationalSpire.MarketClearing.Session.Close(NationalSpire.MarketClearing.Slot, string)`](MarketClearing.cs.md#symbol-7702fb075cde)

**调用：** [`NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`](CareerMarket.cs.md#symbol-8f53c28594f3)；[`NationalSpire.MarketClearing.ExitRate(NationalSpire.MarketAsset)`](MarketClearing.cs.md#symbol-baa56ed8a802)；`decimal.Round(decimal, int)`；`NationalSpire.MarketExecution.Exit.Exit(NationalSpire.MarketExecution.Fill, NationalSpire.MarketNumber, decimal, decimal)`；`NationalSpire.MarketExecution.Fill.Fill(NationalSpire.MarketNumber, decimal, NationalSpire.MarketNumber, decimal, int)`；`System.Math.Max(decimal, decimal)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketClearing.ExitRate(NationalSpire.MarketAsset)`；`NationalSpire.MarketPosition.Asset`；`NationalSpire.MarketPosition.Direction`；`NationalSpire.MarketPosition.Entry`；`NationalSpire.MarketPosition.Leverage`；`NationalSpire.MarketPosition.Margin`；`NationalSpire.MarketPosition.OpeningFee`；`NationalSpire.MarketPosition.Units`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.Round(decimal, int)`；输入表达式：`decimal.Round((decimal)p.Units * average * ExitRate(MarketCatalog.ById[p.Asset]), 4)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = decimal.Round((decimal)p.Units * average * ExitRate(MarketCatalog.ById[p.Asset]), 4)`
- `decimal.Round(decimal, int)`；输入表达式：`decimal.Round(p.Margin + (decimal)p.Units * p.Direction * (average - p.Entry) - fee, 4)`；返回值紧邻使用处：`ArgumentSyntax: decimal.Round(p.Margin + (decimal)p.Units * p.Direction * (average - p.Entry) - fee, 4)`
- `NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`；输入表达式：`CareerMarket.OpenFee(MarketCatalog.ById[p.Asset], p.Margin, p.Leverage)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.OpeningFee ?? CareerMarket.OpenFee(MarketCatalog.ById[p.Asset], p.Margin, p.Leverage)`
- `NationalSpire.MarketClearing.ExitRate(NationalSpire.MarketAsset)`；输入表达式：`ExitRate(MarketCatalog.ById[p.Asset])`；返回值紧邻使用处：`BinaryExpressionSyntax: (decimal)p.Units * average * ExitRate(MarketCatalog.ById[p.Asset])`
- `NationalSpire.MarketExecution.Exit.Exit(NationalSpire.MarketExecution.Fill, NationalSpire.MarketNumber, decimal, decimal)`；输入表达式：`new(new(p.Units, average, 0, 0, -p.Direction), fee, proceeds,             proceeds - p.Margin - (p.OpeningFee ?? CareerMarket.OpenFee(MarketCatalog.ById[p.Asset], p.Margin, p.Leverage)))`；返回值紧邻使用处：`ReturnStatementSyntax: return new(new(p.Units, average, 0, 0, -p.Direction), fee, proceeds,             proceeds - p.Margin - (p.OpeningFee ?? CareerMarket.OpenFee(MarketCatalog.ById[p.Asset], p.Margin, p.Leverage)));`
- `NationalSpire.MarketExecution.Fill.Fill(NationalSpire.MarketNumber, decimal, NationalSpire.MarketNumber, decimal, int)`；输入表达式：`new(p.Units, average, 0, 0, -p.Direction)`；返回值紧邻使用处：`ArgumentSyntax: new(p.Units, average, 0, 0, -p.Direction)`
- `System.Math.Max(decimal, decimal)`；输入表达式：`Math.Max(0, decimal.Round(p.Margin + (decimal)p.Units * p.Direction * (average - p.Entry) - fee, 4))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(0, decimal.Round(p.Margin + (decimal)p.Units * p.Direction * (average - p.Entry) - fee, 4))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ce8c2e166c19"></a>

## `NationalSpire.MarketClearing.Slot.Slot(NationalSpire.MarketAccount, NationalSpire.MarketPosition, decimal) — public Slot(MarketAccount owner, MarketPosition p, decimal capacity)`

来源：源码第 60 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketClearing.Session.Open(decimal, int, int)`](MarketClearing.cs.md#symbol-318331fe9749)；[`NationalSpire.MarketClearing.Session.Session(NationalSpire.MarketAsset, NationalSpire.MarketQuote, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>)`](MarketClearing.cs.md#symbol-510ea2f6756a)

**调用：** [`NationalSpire.MarketClearing.ExitRate(NationalSpire.MarketAsset)`](MarketClearing.cs.md#symbol-baa56ed8a802)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketAsset.Forex`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketClearing.ExitRate(NationalSpire.MarketAsset)`；`NationalSpire.MarketClearing.Slot.AdverseCoefficient`；`NationalSpire.MarketClearing.Slot.CashBasis`；`NationalSpire.MarketClearing.Slot.Fraction`；`NationalSpire.MarketClearing.Slot.MarginApplies`；`NationalSpire.MarketClearing.Slot.Owner`；`NationalSpire.MarketClearing.Slot.Position`；`NationalSpire.MarketClearing.Slot.PriceCoefficient`；`NationalSpire.MarketClearing.Slot.Units`；`NationalSpire.MarketPosition.Asset`；`NationalSpire.MarketPosition.Direction`；`NationalSpire.MarketPosition.Entry`；`NationalSpire.MarketPosition.Leverage`；`NationalSpire.MarketPosition.Margin`；`NationalSpire.MarketPosition.Units`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketClearing.ExitRate(NationalSpire.MarketAsset)`；输入表达式：`ExitRate(MarketCatalog.ById[p.Asset])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ExitRate(MarketCatalog.ById[p.Asset])`

**赋值（含属性/字段和局部值）：**

- `AdverseCoefficient` = `Units * (1 - p.Direction * rate)`
- `CashBasis` = `p.Margin - p.Direction * Units * p.Entry`
- `Fraction` = `Units / (4 * capacity)`
- `MarginApplies` = `MarketCatalog.ById[p.Asset].Forex || p.Direction < 0 || p.Leverage > 1`
- `Owner` = `owner`
- `Position` = `p`
- `PriceCoefficient` = `Units * (p.Direction - rate)`
- `Units` = `(decimal)p.Units`

<a id="symbol-aecae3901965"></a>

## `NationalSpire.MarketClearing.Slot.Remaining(decimal, decimal, decimal) — public decimal Remaining(decimal basis, decimal longFactor, decimal shortFactor)`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketClearing.Session.Next(decimal, int, bool)`](MarketClearing.cs.md#symbol-c4416168b119)；[`NationalSpire.MarketClearing.Session.Open(decimal, int, int)`](MarketClearing.cs.md#symbol-318331fe9749)；[`NationalSpire.MarketClearing.Session.Reprice(decimal)`](MarketClearing.cs.md#symbol-07ff00e14994)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.MarketClearing.Slot.CashBasis`；`NationalSpire.MarketClearing.Slot.Fraction`；`NationalSpire.MarketClearing.Slot.Position`；`NationalSpire.MarketClearing.Slot.PriceCoefficient`；`NationalSpire.MarketPosition.Direction`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-438c776b7f34"></a>

## `NationalSpire.MarketClearing.Session.Q — private MarketQuote Q`

来源：源码第 84 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.MarketClearing.Result.Quote`；`NationalSpire.MarketClearing.Session.Result`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-510ea2f6756a"></a>

## `NationalSpire.MarketClearing.Session.Session(NationalSpire.MarketAsset, NationalSpire.MarketQuote, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>) — public Session(MarketAsset asset, MarketQuote quote, IReadOnlyList<MarketAccount> accounts)`

来源：源码第 85 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketClearing.Close(NationalSpire.MarketState, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, NationalSpire.MarketPosition)`](MarketClearing.cs.md#symbol-d7527455bb75)；[`NationalSpire.MarketClearing.LiquidationValue(NationalSpire.MarketState, NationalSpire.MarketAccount, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>)`](MarketClearing.cs.md#symbol-883f332c6946)；[`NationalSpire.MarketClearing.Reprice(NationalSpire.MarketState, string, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, int, decimal)`](MarketClearing.cs.md#symbol-fbef13444d2b)；[`NationalSpire.MarketClearing.Settle(NationalSpire.MarketState, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, int)`](MarketClearing.cs.md#symbol-25fcc46bf36d)；[`Run(decimal)`](MarketClearing.cs.md#symbol-0c1a50114fda)

**调用：** [`NationalSpire.MarketClearing.Capacity(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`](MarketClearing.cs.md#symbol-64464988b285)；[`NationalSpire.MarketClearing.Slot.Slot(NationalSpire.MarketAccount, NationalSpire.MarketPosition, decimal)`](MarketClearing.cs.md#symbol-ce8c2e166c19)；[`NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-90e04f0c7b2e)；[`NationalSpire.MarketQuote.ExecutionCopy()`](CareerMarketData.cs.md#symbol-0dd7cd2eabdc)；`NationalSpire.MarketClearing.Result.Result()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketAccount.Positions`；`NationalSpire.MarketAsset.Id`；`NationalSpire.MarketClearing.Capacity(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`；`NationalSpire.MarketClearing.Result.Quote`；`NationalSpire.MarketClearing.Session.asset`；`NationalSpire.MarketClearing.Session.previewOwner`；`NationalSpire.MarketClearing.Session.Q`；`NationalSpire.MarketClearing.Session.Result`；`NationalSpire.MarketClearing.Session.slots`；`NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`；`NationalSpire.MarketPosition.Asset`；`NationalSpire.MarketPosition.ExecutionVersion`；`NationalSpire.MarketQuote.ClearingDepthUnits`；`NationalSpire.MarketQuote.ExecutionBase`；`NationalSpire.MarketQuote.ExecutionCopy()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketClearing.Capacity(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`；输入表达式：`Capacity(asset, quote)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Q.ClearingDepthUnits = Capacity(asset, quote)`
- `NationalSpire.MarketClearing.Result.Result()`；输入表达式：`new() { Quote = quote.ExecutionCopy() }`；返回值紧邻使用处：`AssignmentExpressionSyntax: Result = new() { Quote = quote.ExecutionCopy() }`
- `NationalSpire.MarketClearing.Slot.Slot(NationalSpire.MarketAccount, NationalSpire.MarketPosition, decimal)`；输入表达式：`new Slot(a, p, Q.ClearingDepthUnits)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => new Slot(a, p, Q.ClearingDepthUnits)`
- `NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`；输入表达式：`MarketExecution.ReferencePrice(quote)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Q.ExecutionBase = MarketExecution.ReferencePrice(quote)`
- `NationalSpire.MarketQuote.ExecutionCopy()`；输入表达式：`quote.ExecutionCopy()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Quote = quote.ExecutionCopy()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`a.Positions.Where(p => p.Asset == asset.Id && p.ExecutionVersion == 1).Select(p => new Slot(a, p, Q.ClearingDepthUnits))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: a => a.Positions.Where(p => p.Asset == asset.Id && p.ExecutionVersion == 1).Select(p => new Slot(a, p, Q.ClearingDepthUnits))`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`accounts.SelectMany(a => a.Positions.Where(p => p.Asset == asset.Id && p.ExecutionVersion == 1).Select(p => new Slot(a, p, Q.ClearingDepthUnits)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: accounts.SelectMany(a => a.Positions.Where(p => p.Asset == asset.Id && p.ExecutionVersion == 1).Select(p => new Slot(a, p, Q.ClearingDepthUnits))).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`accounts.SelectMany(a => a.Positions.Where(p => p.Asset == asset.Id && p.ExecutionVersion == 1).Select(p => new Slot(a, p, Q.ClearingDepthUnits))).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: slots = accounts.SelectMany(a => a.Positions.Where(p => p.Asset == asset.Id && p.ExecutionVersion == 1).Select(p => new Slot(a, p, Q.ClearingDepthUnits))).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`a.Positions.Where(p => p.Asset == asset.Id && p.ExecutionVersion == 1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: a.Positions.Where(p => p.Asset == asset.Id && p.ExecutionVersion == 1).Select`

**赋值（含属性/字段和局部值）：**

- `previewOwner` = `accounts[0]`
- `Q.ClearingDepthUnits` = `Capacity(asset, quote)`
- `Q.ExecutionBase` = `MarketExecution.ReferencePrice(quote)`
- `Quote` = `quote.ExecutionCopy()`
- `Result` = `new() { Quote = quote.ExecutionCopy() }`
- `slots` = `accounts.SelectMany(a => a.Positions.Where(p => p.Asset == asset.Id && p.ExecutionVersion == 1).Select(p => new Slot(a, p, Q.ClearingDepthUnits))).ToList()`
- `this.asset` = `asset`

<a id="symbol-c4416168b119"></a>

## `NationalSpire.MarketClearing.Session.Next(decimal, int, bool) — private (Slot? Slot, decimal Units, string Reason) Next(decimal units, int direction, bool opening)`

来源：源码第 94 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketClearing.Session.Close(NationalSpire.MarketClearing.Slot, string)`](MarketClearing.cs.md#symbol-7702fb075cde)；[`NationalSpire.MarketClearing.Session.Open(decimal, int, int)`](MarketClearing.cs.md#symbol-318331fe9749)；[`NationalSpire.MarketClearing.Session.Settle()`](MarketClearing.cs.md#symbol-cfca069d6308)

**调用：** [`NationalSpire.MarketClearing.Price(NationalSpire.MarketQuote)`](MarketClearing.cs.md#symbol-01242bd01825)；[`NationalSpire.MarketClearing.Slot.Remaining(decimal, decimal, decimal)`](MarketClearing.cs.md#symbol-aecae3901965)；[`NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-90e04f0c7b2e)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketClearing.Price(NationalSpire.MarketQuote)`；`NationalSpire.MarketClearing.Session.Q`；`NationalSpire.MarketClearing.Session.slots`；`NationalSpire.MarketClearing.Slot.Active`；`NationalSpire.MarketClearing.Slot.AdverseCoefficient`；`NationalSpire.MarketClearing.Slot.MarginApplies`；`NationalSpire.MarketClearing.Slot.Position`；`NationalSpire.MarketClearing.Slot.Remaining(decimal, decimal, decimal)`；`NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`；`NationalSpire.MarketPosition.Direction`；`NationalSpire.MarketPosition.StopPrice`；`NationalSpire.MarketQuote.ClearingDepthUnits`；`NationalSpire.MarketQuote.LongUnits`；`NationalSpire.MarketQuote.ShortUnits`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketClearing.Price(NationalSpire.MarketQuote)`；输入表达式：`Price(Q)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Price(Q)`
- `NationalSpire.MarketClearing.Slot.Remaining(decimal, decimal, decimal)`；输入表达式：`slot.Remaining(basis, longFactor, shortFactor)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = slot.Remaining(basis, longFactor, shortFactor)`
- `NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`；输入表达式：`MarketExecution.ReferencePrice(Q)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MarketExecution.ReferencePrice(Q)`

**赋值（含属性/字段和局部值）：**

- `earliest` = `at`
- `first` = `slot`
- `reason` = `"强制平仓"`
- `reason` = `"止损平仓"`

<a id="symbol-010c7c45a36f"></a>

## `NationalSpire.MarketClearing.Session.Move(decimal, int, bool) — private decimal Move(decimal units, int direction, bool opening)`

来源：源码第 123 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketClearing.Session.Close(NationalSpire.MarketClearing.Slot, string)`](MarketClearing.cs.md#symbol-7702fb075cde)；[`NationalSpire.MarketClearing.Session.Open(decimal, int, int)`](MarketClearing.cs.md#symbol-318331fe9749)

**调用：** [`NationalSpire.MarketClearing.Average(NationalSpire.MarketQuote, decimal, int)`](MarketClearing.cs.md#symbol-5f9bf3d5e43b)；[`NationalSpire.MarketClearing.Price(NationalSpire.MarketQuote)`](MarketClearing.cs.md#symbol-01242bd01825)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketClearing.Average(NationalSpire.MarketQuote, decimal, int)`；`NationalSpire.MarketClearing.Price(NationalSpire.MarketQuote)`；`NationalSpire.MarketClearing.Session.Q`；`NationalSpire.MarketQuote.LongUnits`；`NationalSpire.MarketQuote.Price`；`NationalSpire.MarketQuote.ShortUnits`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketClearing.Average(NationalSpire.MarketQuote, decimal, int)`；输入表达式：`Average(Q, units, direction)`；返回值紧邻使用处：`BinaryExpressionSyntax: units * Average(Q, units, direction)`
- `NationalSpire.MarketClearing.Price(NationalSpire.MarketQuote)`；输入表达式：`Price(Q)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Q.Price = Price(Q)`

**赋值（含属性/字段和局部值）：**

- `Q.LongUnits` += `opening ? units : -units`
- `Q.Price` = `Price(Q)`
- `Q.ShortUnits` += `opening ? units : -units`

<a id="symbol-8f6a3a58ab6d"></a>

## `NationalSpire.MarketClearing.Session.Close(NationalSpire.MarketPosition, string) — public void Close(MarketPosition position, string reason = "平仓")`

来源：源码第 131 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketClearing.Close(NationalSpire.MarketState, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, NationalSpire.MarketPosition)`](MarketClearing.cs.md#symbol-d7527455bb75)；[`NationalSpire.MarketClearing.LiquidationValue(NationalSpire.MarketState, NationalSpire.MarketAccount, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>)`](MarketClearing.cs.md#symbol-883f332c6946)

**调用：** [`NationalSpire.MarketClearing.Session.Close(NationalSpire.MarketClearing.Slot, string)`](MarketClearing.cs.md#symbol-7702fb075cde)；`object.ReferenceEquals(object?, object?)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketClearing.Session.Close(NationalSpire.MarketClearing.Slot, string)`；`NationalSpire.MarketClearing.Session.slots`；`NationalSpire.MarketClearing.Slot.Active`；`NationalSpire.MarketClearing.Slot.Position`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketClearing.Session.Close(NationalSpire.MarketClearing.Slot, string)`；输入表达式：`Close(first, reason)`；返回值紧邻使用处：`ExpressionStatementSyntax: Close(first, reason);`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(s.Position, position)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: s => ReferenceEquals(s.Position, position)`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`slots.First(s => ReferenceEquals(s.Position, position))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = slots.First(s => ReferenceEquals(s.Position, position))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7702fb075cde"></a>

## `NationalSpire.MarketClearing.Session.Close(NationalSpire.MarketClearing.Slot, string) — private void Close(Slot first, string reason)`

来源：源码第 137 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketClearing.Session.Close(NationalSpire.MarketPosition, string)`](MarketClearing.cs.md#symbol-8f6a3a58ab6d)；[`NationalSpire.MarketClearing.Session.Open(decimal, int, int)`](MarketClearing.cs.md#symbol-318331fe9749)；[`NationalSpire.MarketClearing.Session.Reprice(decimal)`](MarketClearing.cs.md#symbol-07ff00e14994)；[`NationalSpire.MarketClearing.Session.Settle()`](MarketClearing.cs.md#symbol-cfca069d6308)

**调用：** [`NationalSpire.MarketClearing.Exit(NationalSpire.MarketPosition, decimal)`](MarketClearing.cs.md#symbol-de97bac9e6b1)；[`NationalSpire.MarketClearing.Session.Move(decimal, int, bool)`](MarketClearing.cs.md#symbol-010c7c45a36f)；[`NationalSpire.MarketClearing.Session.Next(decimal, int, bool)`](MarketClearing.cs.md#symbol-c4416168b119)；`NationalSpire.MarketClearing.Closed.Closed(NationalSpire.MarketAccount, NationalSpire.MarketPosition, NationalSpire.MarketExecution.Exit, string)`；`NationalSpire.MarketClearing.Work.Work(NationalSpire.MarketClearing.Slot, string)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.Stack<T>.Pop()`；`System.Collections.Generic.Stack<T>.Push(T)`；`System.Collections.Generic.Stack<T>.Stack()`；`System.Collections.Generic.Stack<T>.TryPeek(out T)`

**字段、属性、事件及方法组引用：** `(NationalSpire.MarketClearing.Slot? Slot, decimal Units, string Reason).Reason`；`(NationalSpire.MarketClearing.Slot? Slot, decimal Units, string Reason).Slot`；`(NationalSpire.MarketClearing.Slot? Slot, decimal Units, string Reason).Units`；`NationalSpire.MarketClearing.Exit(NationalSpire.MarketPosition, decimal)`；`NationalSpire.MarketClearing.Result.Closed`；`NationalSpire.MarketClearing.Session.Move(decimal, int, bool)`；`NationalSpire.MarketClearing.Session.Next(decimal, int, bool)`；`NationalSpire.MarketClearing.Session.Result`；`NationalSpire.MarketClearing.Slot.Active`；`NationalSpire.MarketClearing.Slot.Owner`；`NationalSpire.MarketClearing.Slot.Position`；`NationalSpire.MarketClearing.Work.Notional`；`NationalSpire.MarketClearing.Work.Reason`；`NationalSpire.MarketClearing.Work.Remaining`；`NationalSpire.MarketClearing.Work.Slot`；`NationalSpire.MarketPosition.Direction`；`NationalSpire.MarketPosition.Units`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketClearing.Closed.Closed(NationalSpire.MarketAccount, NationalSpire.MarketPosition, NationalSpire.MarketExecution.Exit, string)`；输入表达式：`new(work.Slot.Owner, p, Exit(p, work.Notional / (decimal)p.Units), work.Reason)`；返回值紧邻使用处：`ArgumentSyntax: new(work.Slot.Owner, p, Exit(p, work.Notional / (decimal)p.Units), work.Reason)`
- `NationalSpire.MarketClearing.Exit(NationalSpire.MarketPosition, decimal)`；输入表达式：`Exit(p, work.Notional / (decimal)p.Units)`；返回值紧邻使用处：`ArgumentSyntax: Exit(p, work.Notional / (decimal)p.Units)`
- `NationalSpire.MarketClearing.Session.Move(decimal, int, bool)`；输入表达式：`Move(next.Units, direction, false)`；返回值紧邻使用处：`AssignmentExpressionSyntax: work.Notional += Move(next.Units, direction, false)`
- `NationalSpire.MarketClearing.Session.Next(decimal, int, bool)`；输入表达式：`Next(work.Remaining, direction, false)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Next(work.Remaining, direction, false)`
- `NationalSpire.MarketClearing.Work.Work(NationalSpire.MarketClearing.Slot, string)`；输入表达式：`new(first, reason)`；返回值紧邻使用处：`ArgumentSyntax: new(first, reason)`
- `NationalSpire.MarketClearing.Work.Work(NationalSpire.MarketClearing.Slot, string)`；输入表达式：`new(next.Slot, next.Reason)`；返回值紧邻使用处：`ArgumentSyntax: new(next.Slot, next.Reason)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`Result.Closed.Add(new(work.Slot.Owner, p, Exit(p, work.Notional / (decimal)p.Units), work.Reason))`；返回值紧邻使用处：`ExpressionStatementSyntax: Result.Closed.Add(new(work.Slot.Owner, p, Exit(p, work.Notional / (decimal)p.Units), work.Reason));`
- `System.Collections.Generic.Stack<T>.Pop()`；输入表达式：`stack.Pop()`；返回值紧邻使用处：`ExpressionStatementSyntax: stack.Pop();`
- `System.Collections.Generic.Stack<T>.Push(T)`；输入表达式：`stack.Push(new(first, reason))`；返回值紧邻使用处：`ExpressionStatementSyntax: stack.Push(new(first, reason));`
- `System.Collections.Generic.Stack<T>.Push(T)`；输入表达式：`stack.Push(new(next.Slot, next.Reason))`；返回值紧邻使用处：`ExpressionStatementSyntax: stack.Push(new(next.Slot, next.Reason));`
- `System.Collections.Generic.Stack<T>.Stack()`；输入表达式：`new Stack<Work>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Stack<Work>()`
- `System.Collections.Generic.Stack<T>.TryPeek(out T)`；输入表达式：`stack.TryPeek(out var work)`；返回值紧邻使用处：`WhileStatementSyntax: while (stack.TryPeek(out var work))             {                 int direction = -work.Slot.Position.Direction;                 var next = Next(work.Remaining, direction, false);                 work.Notional += Move(next.Units, direction, false); work.Remaining -= next.Units;                 if (next.Slot != null)                 {                     next.Slot.Active = false; stack.Push(new(next.Slot, next.Reason)); continue;                 }                 stack.Pop();                 var p = work.Slot.Position;                 Result.Closed.Add(new(work.Slot.Owner, p, Exit(p, work.Notional / (decimal)p.Units), work.Reason));             }`

**赋值（含属性/字段和局部值）：**

- `first.Active` = `false`
- `next.Slot.Active` = `false`
- `work.Notional` += `Move(next.Units, direction, false)`
- `work.Remaining` -= `next.Units`

<a id="symbol-cfca069d6308"></a>

## `NationalSpire.MarketClearing.Session.Settle() — public void Settle()`

来源：源码第 154 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketClearing.Session.Reprice(decimal)`](MarketClearing.cs.md#symbol-07ff00e14994)；[`NationalSpire.MarketClearing.Settle(NationalSpire.MarketState, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, int)`](MarketClearing.cs.md#symbol-25fcc46bf36d)

**调用：** [`NationalSpire.MarketClearing.Session.Close(NationalSpire.MarketClearing.Slot, string)`](MarketClearing.cs.md#symbol-7702fb075cde)；[`NationalSpire.MarketClearing.Session.Next(decimal, int, bool)`](MarketClearing.cs.md#symbol-c4416168b119)

**字段、属性、事件及方法组引用：** `(NationalSpire.MarketClearing.Slot? Slot, decimal Units, string Reason).Reason`；`(NationalSpire.MarketClearing.Slot? Slot, decimal Units, string Reason).Slot`；`NationalSpire.MarketClearing.Session.Close(NationalSpire.MarketClearing.Slot, string)`；`NationalSpire.MarketClearing.Session.Next(decimal, int, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketClearing.Session.Close(NationalSpire.MarketClearing.Slot, string)`；输入表达式：`Close(next.Slot, next.Reason)`；返回值紧邻使用处：`ExpressionStatementSyntax: Close(next.Slot, next.Reason);`
- `NationalSpire.MarketClearing.Session.Next(decimal, int, bool)`；输入表达式：`Next(0, 1, false)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Next(0, 1, false)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-07ff00e14994"></a>

## `NationalSpire.MarketClearing.Session.Reprice(decimal) — public void Reprice(decimal target)`

来源：源码第 163 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketClearing.Reprice(NationalSpire.MarketState, string, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, int, decimal)`](MarketClearing.cs.md#symbol-fbef13444d2b)

**调用：** [`NationalSpire.MarketClearing.Price(NationalSpire.MarketQuote)`](MarketClearing.cs.md#symbol-01242bd01825)；[`NationalSpire.MarketClearing.Session.Close(NationalSpire.MarketClearing.Slot, string)`](MarketClearing.cs.md#symbol-7702fb075cde)；[`NationalSpire.MarketClearing.Session.Settle()`](MarketClearing.cs.md#symbol-cfca069d6308)；[`NationalSpire.MarketClearing.Slot.Remaining(decimal, decimal, decimal)`](MarketClearing.cs.md#symbol-aecae3901965)；[`NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-90e04f0c7b2e)；`System.Math.Max(decimal, decimal)`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketClearing.Price(NationalSpire.MarketQuote)`；`NationalSpire.MarketClearing.Session.Close(NationalSpire.MarketClearing.Slot, string)`；`NationalSpire.MarketClearing.Session.Q`；`NationalSpire.MarketClearing.Session.Settle()`；`NationalSpire.MarketClearing.Session.slots`；`NationalSpire.MarketClearing.Slot.Active`；`NationalSpire.MarketClearing.Slot.MarginApplies`；`NationalSpire.MarketClearing.Slot.Position`；`NationalSpire.MarketClearing.Slot.Remaining(decimal, decimal, decimal)`；`NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`；`NationalSpire.MarketPosition.Direction`；`NationalSpire.MarketPosition.StopPrice`；`NationalSpire.MarketQuote.ClearingDepthUnits`；`NationalSpire.MarketQuote.ExecutionBase`；`NationalSpire.MarketQuote.LongUnits`；`NationalSpire.MarketQuote.Price`；`NationalSpire.MarketQuote.ShortUnits`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketClearing.Price(NationalSpire.MarketQuote)`；输入表达式：`Price(Q)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Q.Price = Price(Q)`
- `NationalSpire.MarketClearing.Price(NationalSpire.MarketQuote)`；输入表达式：`Price(Q)`；返回值紧邻使用处：`BinaryExpressionSyntax: Price(Q) - stop`
- `NationalSpire.MarketClearing.Price(NationalSpire.MarketQuote)`；输入表达式：`Price(Q)`；返回值紧邻使用处：`BinaryExpressionSyntax: Price(Q) * end`
- `NationalSpire.MarketClearing.Session.Close(NationalSpire.MarketClearing.Slot, string)`；输入表达式：`Close(first, reason)`；返回值紧邻使用处：`ExpressionStatementSyntax: Close(first, reason);`
- `NationalSpire.MarketClearing.Session.Settle()`；输入表达式：`Settle()`；返回值紧邻使用处：`ExpressionStatementSyntax: Settle();`
- `NationalSpire.MarketClearing.Slot.Remaining(decimal, decimal, decimal)`；输入表达式：`slot.Remaining(end, longFactor, shortFactor)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = slot.Remaining(end, longFactor, shortFactor)`
- `NationalSpire.MarketClearing.Slot.Remaining(decimal, decimal, decimal)`；输入表达式：`slot.Remaining(start, longFactor, shortFactor)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = slot.Remaining(start, longFactor, shortFactor)`
- `NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`；输入表达式：`MarketExecution.ReferencePrice(Q)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MarketExecution.ReferencePrice(Q)`
- `System.Math.Max(decimal, decimal)`；输入表达式：`Math.Max(0, from / (from - to))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(0, from / (from - to))`

**赋值（含属性/字段和局部值）：**

- `first` = `slot`
- `fraction` = `t`
- `Q.ExecutionBase` = `start + (end - start) * fraction`
- `Q.Price` = `Price(Q)`
- `reason` = `"强制平仓"`
- `reason` = `"止损平仓"`

<a id="symbol-318331fe9749"></a>

## `NationalSpire.MarketClearing.Session.Open(decimal, int, int) — public void Open(decimal margin, int leverage, int direction)`

来源：源码第 200 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Run(decimal)`](MarketClearing.cs.md#symbol-0c1a50114fda)

**调用：** [`NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`](CareerMarket.cs.md#symbol-8f53c28594f3)；[`NationalSpire.MarketClearing.Average(NationalSpire.MarketQuote, decimal, int)`](MarketClearing.cs.md#symbol-5f9bf3d5e43b)；[`NationalSpire.MarketClearing.Price(NationalSpire.MarketQuote)`](MarketClearing.cs.md#symbol-01242bd01825)；[`NationalSpire.MarketClearing.Quantity(NationalSpire.MarketQuote, decimal, int)`](MarketClearing.cs.md#symbol-aa62127e5a9c)；[`NationalSpire.MarketClearing.Session.Close(NationalSpire.MarketClearing.Slot, string)`](MarketClearing.cs.md#symbol-7702fb075cde)；[`NationalSpire.MarketClearing.Session.Move(decimal, int, bool)`](MarketClearing.cs.md#symbol-010c7c45a36f)；[`NationalSpire.MarketClearing.Session.Next(decimal, int, bool)`](MarketClearing.cs.md#symbol-c4416168b119)；[`NationalSpire.MarketClearing.Slot.Remaining(decimal, decimal, decimal)`](MarketClearing.cs.md#symbol-aecae3901965)；[`NationalSpire.MarketClearing.Slot.Slot(NationalSpire.MarketAccount, NationalSpire.MarketPosition, decimal)`](MarketClearing.cs.md#symbol-ce8c2e166c19)；[`NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-90e04f0c7b2e)；[`NationalSpire.MarketNumber.Max(NationalSpire.MarketNumber, NationalSpire.MarketNumber)`](MarketNumber.cs.md#symbol-0cf4c87609b0)；`NationalSpire.MarketPosition.MarketPosition()`；`System.Math.Min(decimal, decimal)`

**字段、属性、事件及方法组引用：** `(NationalSpire.MarketClearing.Slot? Slot, decimal Units, string Reason).Reason`；`(NationalSpire.MarketClearing.Slot? Slot, decimal Units, string Reason).Slot`；`(NationalSpire.MarketClearing.Slot? Slot, decimal Units, string Reason).Units`；`NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`；`NationalSpire.MarketAsset.Id`；`NationalSpire.MarketClearing.Average(NationalSpire.MarketQuote, decimal, int)`；`NationalSpire.MarketClearing.Price(NationalSpire.MarketQuote)`；`NationalSpire.MarketClearing.Quantity(NationalSpire.MarketQuote, decimal, int)`；`NationalSpire.MarketClearing.Result.Accepted`；`NationalSpire.MarketClearing.Result.Average`；`NationalSpire.MarketClearing.Result.Fee`；`NationalSpire.MarketClearing.Result.Margin`；`NationalSpire.MarketClearing.Result.Reason`；`NationalSpire.MarketClearing.Result.Units`；`NationalSpire.MarketClearing.Session.asset`；`NationalSpire.MarketClearing.Session.Close(NationalSpire.MarketClearing.Slot, string)`；`NationalSpire.MarketClearing.Session.Move(decimal, int, bool)`；`NationalSpire.MarketClearing.Session.Next(decimal, int, bool)`；`NationalSpire.MarketClearing.Session.previewOwner`；`NationalSpire.MarketClearing.Session.Q`；`NationalSpire.MarketClearing.Session.Result`；`NationalSpire.MarketClearing.Slot.MarginApplies`；`NationalSpire.MarketClearing.Slot.Remaining(decimal, decimal, decimal)`；`NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`；`NationalSpire.MarketNumber.Max(NationalSpire.MarketNumber, NationalSpire.MarketNumber)`；`NationalSpire.MarketPosition.Asset`；`NationalSpire.MarketPosition.Direction`；`NationalSpire.MarketPosition.Entry`；`NationalSpire.MarketPosition.ExecutionVersion`；`NationalSpire.MarketPosition.Leverage`；`NationalSpire.MarketPosition.Margin`；`NationalSpire.MarketPosition.Units`；`NationalSpire.MarketQuote.ClearingDepthUnits`；`NationalSpire.MarketQuote.LongUnits`；`NationalSpire.MarketQuote.ShortUnits`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`；输入表达式：`CareerMarket.OpenFee(asset, Result.Margin, leverage)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Result.Fee = CareerMarket.OpenFee(asset, Result.Margin, leverage)`
- `NationalSpire.MarketClearing.Average(NationalSpire.MarketQuote, decimal, int)`；输入表达式：`Average(Q, available, direction)`；返回值紧邻使用处：`BinaryExpressionSyntax: available * Average(Q, available, direction)`
- `NationalSpire.MarketClearing.Price(NationalSpire.MarketQuote)`；输入表达式：`Price(Q)`；返回值紧邻使用处：`ConditionalExpressionSyntax: units > 0 ? spent / units : Price(Q)`
- `NationalSpire.MarketClearing.Quantity(NationalSpire.MarketQuote, decimal, int)`；输入表达式：`Quantity(Q, budget, direction)`；返回值紧邻使用处：`ArgumentSyntax: Quantity(Q, budget, direction)`
- `NationalSpire.MarketClearing.Session.Close(NationalSpire.MarketClearing.Slot, string)`；输入表达式：`Close(next.Slot, next.Reason)`；返回值紧邻使用处：`ExpressionStatementSyntax: Close(next.Slot, next.Reason);`
- `NationalSpire.MarketClearing.Session.Move(decimal, int, bool)`；输入表达式：`Move(next.Units, direction, true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Move(next.Units, direction, true)`
- `NationalSpire.MarketClearing.Session.Next(decimal, int, bool)`；输入表达式：`Next(quantity, direction, true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Next(quantity, direction, true)`
- `NationalSpire.MarketClearing.Slot.Remaining(decimal, decimal, decimal)`；输入表达式：`risk.Remaining(MarketExecution.ReferencePrice(Q),                 1 - Q.ShortUnits / (2 * Q.ClearingDepthUnits), 1 + Q.LongUnits / (2 * Q.ClearingDepthUnits))`；返回值紧邻使用处：`BinaryExpressionSyntax: risk.Remaining(MarketExecution.ReferencePrice(Q),                 1 - Q.ShortUnits / (2 * Q.ClearingDepthUnits), 1 + Q.LongUnits / (2 * Q.ClearingDepthUnits)) > .000000001m`
- `NationalSpire.MarketClearing.Slot.Slot(NationalSpire.MarketAccount, NationalSpire.MarketPosition, decimal)`；输入表达式：`new Slot(previewOwner, p, Q.ClearingDepthUnits)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Slot(previewOwner, p, Q.ClearingDepthUnits)`
- `NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote)`；输入表达式：`MarketExecution.ReferencePrice(Q)`；返回值紧邻使用处：`ArgumentSyntax: MarketExecution.ReferencePrice(Q)`
- `NationalSpire.MarketNumber.Max(NationalSpire.MarketNumber, NationalSpire.MarketNumber)`；输入表达式：`MarketNumber.Max(wanted - spent, spent - wanted)`；返回值紧邻使用处：`BinaryExpressionSyntax: MarketNumber.Max(wanted - spent, spent - wanted) <= .00000001m`
- `NationalSpire.MarketPosition.MarketPosition()`；输入表达式：`new MarketPosition { Asset = asset.Id, Margin = Result.Margin, Entry = Result.Average, Units = units, Leverage = leverage, Direction = direction, ExecutionVersion = 1 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MarketPosition { Asset = asset.Id, Margin = Result.Margin, Entry = Result.Average, Units = units, Leverage = leverage, Direction = direction, ExecutionVersion = 1 }`
- `System.Math.Min(decimal, decimal)`；输入表达式：`Math.Min(available, Quantity(Q, budget, direction))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(available, Quantity(Q, budget, direction))`

**赋值（含属性/字段和局部值）：**

- `Asset` = `asset.Id`
- `Direction` = `direction`
- `Entry` = `Result.Average`
- `ExecutionVersion` = `1`
- `Leverage` = `leverage`
- `Margin` = `Result.Margin`
- `Result.Accepted` = `viable && MarketNumber.Max(wanted - spent, spent - wanted) <= .00000001m`
- `Result.Average` = `units > 0 ? spent / units : Price(Q)`
- `Result.Fee` = `CareerMarket.OpenFee(asset, Result.Margin, leverage)`
- `Result.Margin` = `spent / leverage`
- `Result.Reason` = `"当前可成交数量已用完"`
- `Result.Reason` = `"订单超过当前可成交数量"`
- `Result.Reason` = `"这笔订单的保证金不足以覆盖当前成交和平仓成本"`
- `Result.Units` = `units`
- `spent` += `value`
- `units` += `next.Units`
- `Units` = `units`

<a id="symbol-e90e0ab892c9"></a>

## `NationalSpire.MarketClearing.Preview(NationalSpire.CareerData, NationalSpire.MarketOrder, bool) — public static Result Preview(CareerData d, MarketOrder order, bool suggest = true)`

来源：源码第 229 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`](CareerMarket.cs.md#symbol-6b9ac5b0686c)；[`NationalSpire.CareerScreen.MarketSubmit(NationalSpire.CareerData, NationalSpire.MarketOrder)`](MarketScreen.cs.md#symbol-fbc36ef790b1)；[`NationalSpire.MarketClearing.Inspect(NationalSpire.CareerData, NationalSpire.MarketInspection)`](MarketClearing.cs.md#symbol-d078c0ca2b29)；[`NationalSpire.MarketTerminal.RefreshFee()`](MarketTerminal.cs.md#symbol-1c08f523080f)

**调用：** [`NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`](CareerMarket.cs.md#symbol-8f53c28594f3)；[`NationalSpire.MarketClearing.Accounts(NationalSpire.CareerData)`](MarketClearing.cs.md#symbol-2192e2bdcb1e)；[`Run(decimal)`](MarketClearing.cs.md#symbol-0c1a50114fda)；`decimal.Floor(decimal)`；`System.Math.Min(decimal, decimal)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketClearing.Accounts(NationalSpire.CareerData)`；`NationalSpire.MarketClearing.Result.Accepted`；`NationalSpire.MarketClearing.Result.Fee`；`NationalSpire.MarketClearing.Result.Margin`；`NationalSpire.MarketClearing.Result.Reason`；`NationalSpire.MarketOrder.Amount`；`NationalSpire.MarketOrder.Asset`；`NationalSpire.MarketOrder.Leverage`；`Run(decimal)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.Floor(decimal)`；输入表达式：`decimal.Floor(high * 1000)`；返回值紧邻使用处：`BinaryExpressionSyntax: decimal.Floor(high * 1000) / 1000`
- `decimal.Floor(decimal)`；输入表达式：`decimal.Floor(low * 1000)`；返回值紧邻使用处：`BinaryExpressionSyntax: decimal.Floor(low * 1000) / 1000`
- `NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`；输入表达式：`CareerMarket.OpenFee(a, capacityMargin, order.Leverage)`；返回值紧邻使用处：`AssignmentExpressionSyntax: capacity.Fee = CareerMarket.OpenFee(a, capacityMargin, order.Leverage)`
- `NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`；输入表达式：`CareerMarket.OpenFee(a, suggested, order.Leverage)`；返回值紧邻使用处：`AssignmentExpressionSyntax: result.Fee = CareerMarket.OpenFee(a, suggested, order.Leverage)`
- `NationalSpire.MarketClearing.Accounts(NationalSpire.CareerData)`；输入表达式：`Accounts(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Accounts(d)`
- `Run(decimal)`；输入表达式：`Run(capacityMargin)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Run(capacityMargin)`
- `Run(decimal)`；输入表达式：`Run(middle)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Run(middle).Accepted`
- `Run(decimal)`；输入表达式：`Run(order.Amount)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Run(order.Amount)`
- `Run(decimal)`；输入表达式：`Run(suggested)`；返回值紧邻使用处：`AssignmentExpressionSyntax: result = Run(suggested)`
- `System.Math.Min(decimal, decimal)`；输入表达式：`Math.Min(order.Amount, result.Margin)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(order.Amount, result.Margin)`

**赋值（含属性/字段和局部值）：**

- `capacity.Accepted` = `false`
- `capacity.Fee` = `CareerMarket.OpenFee(a, capacityMargin, order.Leverage)`
- `capacity.Margin` = `capacityMargin`
- `capacity.Reason` = `reason`
- `high` = `middle`
- `low` = `middle`
- `result.Accepted` = `false`
- `result.Fee` = `CareerMarket.OpenFee(a, suggested, order.Leverage)`
- `result.Margin` = `suggested`
- `result.Reason` = `reason`
- `result` = `Run(suggested)`

<a id="symbol-0c1a50114fda"></a>

## `Run(decimal) — Result Run(decimal margin)`

来源：源码第 232 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketClearing.Preview(NationalSpire.CareerData, NationalSpire.MarketOrder, bool)`](MarketClearing.cs.md#symbol-e90e0ab892c9)

**调用：** [`NationalSpire.MarketClearing.Session.Open(decimal, int, int)`](MarketClearing.cs.md#symbol-318331fe9749)；[`NationalSpire.MarketClearing.Session.Session(NationalSpire.MarketAsset, NationalSpire.MarketQuote, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>)`](MarketClearing.cs.md#symbol-510ea2f6756a)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Market`；`NationalSpire.MarketAsset.Id`；`NationalSpire.MarketClearing.Session.Open(decimal, int, int)`；`NationalSpire.MarketClearing.Session.Result`；`NationalSpire.MarketOrder.Direction`；`NationalSpire.MarketOrder.Leverage`；`NationalSpire.MarketState.Quotes`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketClearing.Session.Open(decimal, int, int)`；输入表达式：`s.Open(margin, order.Leverage, order.Direction)`；返回值紧邻使用处：`ExpressionStatementSyntax: s.Open(margin, order.Leverage, order.Direction);`
- `NationalSpire.MarketClearing.Session.Session(NationalSpire.MarketAsset, NationalSpire.MarketQuote, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>)`；输入表达式：`new Session(a, d.Market.Quotes[a.Id], accounts)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Session(a, d.Market.Quotes[a.Id], accounts)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d7527455bb75"></a>

## `NationalSpire.MarketClearing.Close(NationalSpire.MarketState, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, NationalSpire.MarketPosition) — public static Result Close(MarketState market, IReadOnlyList<MarketAccount> accounts, MarketPosition p)`

来源：源码第 255 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`](CareerMarket.cs.md#symbol-6b9ac5b0686c)；[`NationalSpire.MarketClearing.PreviewClose(NationalSpire.CareerData, NationalSpire.MarketPosition)`](MarketClearing.cs.md#symbol-554374f533fb)

**调用：** [`NationalSpire.MarketClearing.Session.Close(NationalSpire.MarketPosition, string)`](MarketClearing.cs.md#symbol-8f6a3a58ab6d)；[`NationalSpire.MarketClearing.Session.Session(NationalSpire.MarketAsset, NationalSpire.MarketQuote, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>)`](MarketClearing.cs.md#symbol-510ea2f6756a)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketClearing.Result.Accepted`；`NationalSpire.MarketClearing.Session.Close(NationalSpire.MarketPosition, string)`；`NationalSpire.MarketClearing.Session.Result`；`NationalSpire.MarketPosition.Asset`；`NationalSpire.MarketState.Quotes`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketClearing.Session.Close(NationalSpire.MarketPosition, string)`；输入表达式：`s.Close(p)`；返回值紧邻使用处：`ExpressionStatementSyntax: s.Close(p);`
- `NationalSpire.MarketClearing.Session.Session(NationalSpire.MarketAsset, NationalSpire.MarketQuote, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>)`；输入表达式：`new Session(MarketCatalog.ById[p.Asset], market.Quotes[p.Asset], accounts)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Session(MarketCatalog.ById[p.Asset], market.Quotes[p.Asset], accounts)`

**赋值（含属性/字段和局部值）：**

- `s.Result.Accepted` = `true`

<a id="symbol-554374f533fb"></a>

## `NationalSpire.MarketClearing.PreviewClose(NationalSpire.CareerData, NationalSpire.MarketPosition) — public static MarketExecution.Exit PreviewClose(CareerData d, MarketPosition p)`

来源：源码第 259 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketClearing.Inspect(NationalSpire.CareerData, NationalSpire.MarketInspection)`](MarketClearing.cs.md#symbol-d078c0ca2b29)；[`NationalSpire.MarketTerminal.RefreshAccount(bool)`](MarketTerminal.cs.md#symbol-9559baf40113)

**调用：** [`NationalSpire.MarketClearing.Accounts(NationalSpire.CareerData)`](MarketClearing.cs.md#symbol-2192e2bdcb1e)；[`NationalSpire.MarketClearing.Close(NationalSpire.MarketState, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, NationalSpire.MarketPosition)`](MarketClearing.cs.md#symbol-d7527455bb75)；[`NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-2508c79f1fc5)；`object.ReferenceEquals(object?, object?)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Market`；`NationalSpire.MarketClearing.Accounts(NationalSpire.CareerData)`；`NationalSpire.MarketClearing.Close(NationalSpire.MarketState, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, NationalSpire.MarketPosition)`；`NationalSpire.MarketClearing.Closed.Exit`；`NationalSpire.MarketClearing.Closed.Position`；`NationalSpire.MarketClearing.Result.Closed`；`NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`；`NationalSpire.MarketPosition.Asset`；`NationalSpire.MarketPosition.ExecutionVersion`；`NationalSpire.MarketState.Quotes`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketClearing.Accounts(NationalSpire.CareerData)`；输入表达式：`Accounts(d)`；返回值紧邻使用处：`ArgumentSyntax: Accounts(d)`
- `NationalSpire.MarketClearing.Close(NationalSpire.MarketState, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, NationalSpire.MarketPosition)`；输入表达式：`Close(d.Market, Accounts(d), p)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Close(d.Market, Accounts(d), p).Closed`
- `NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`；输入表达式：`MarketExecution.Close(p, d.Market.Quotes[p.Asset])`；返回值紧邻使用处：`ConditionalExpressionSyntax: p.ExecutionVersion == 0 ? MarketExecution.Close(p, d.Market.Quotes[p.Asset])             : Close(d.Market, Accounts(d), p).Closed.Single(c => ReferenceEquals(c.Position, p)).Exit`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(c.Position, p)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => ReferenceEquals(c.Position, p)`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`Close(d.Market, Accounts(d), p).Closed.Single(c => ReferenceEquals(c.Position, p))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Close(d.Market, Accounts(d), p).Closed.Single(c => ReferenceEquals(c.Position, p)).Exit`

**赋值（含属性/字段和局部值）：**


<a id="symbol-883f332c6946"></a>

## `NationalSpire.MarketClearing.LiquidationValue(NationalSpire.MarketState, NationalSpire.MarketAccount, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>) — public static decimal LiquidationValue(MarketState market, MarketAccount account, IReadOnlyList<MarketAccount> accounts)`

来源：源码第 262 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketExecution.LiquidationValue(NationalSpire.MarketState, NationalSpire.MarketAccount, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>?)`](MarketExecution.cs.md#symbol-38a7df5abf7b)

**调用：** [`NationalSpire.MarketClearing.Session.Close(NationalSpire.MarketPosition, string)`](MarketClearing.cs.md#symbol-8f6a3a58ab6d)；[`NationalSpire.MarketClearing.Session.Session(NationalSpire.MarketAsset, NationalSpire.MarketQuote, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>)`](MarketClearing.cs.md#symbol-510ea2f6756a)；[`NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-2508c79f1fc5)；[`NationalSpire.MarketExecution.Consume(NationalSpire.MarketQuote, NationalSpire.MarketAsset, NationalSpire.MarketExecution.Fill)`](MarketExecution.cs.md#symbol-d38348a5d5b3)；`object.ReferenceEquals(object?, object?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, decimal>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketAccount.Cash`；`NationalSpire.MarketAccount.Debt`；`NationalSpire.MarketAccount.Positions`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketClearing.Closed.Exit`；`NationalSpire.MarketClearing.Closed.Owner`；`NationalSpire.MarketClearing.Result.Closed`；`NationalSpire.MarketClearing.Result.Quote`；`NationalSpire.MarketClearing.Session.Close(NationalSpire.MarketPosition, string)`；`NationalSpire.MarketClearing.Session.Result`；`NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`；`NationalSpire.MarketExecution.Consume(NationalSpire.MarketQuote, NationalSpire.MarketAsset, NationalSpire.MarketExecution.Fill)`；`NationalSpire.MarketExecution.Exit.Fill`；`NationalSpire.MarketExecution.Exit.Proceeds`；`NationalSpire.MarketPosition.Asset`；`NationalSpire.MarketPosition.ExecutionVersion`；`NationalSpire.MarketState.Quotes`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketClearing.Session.Close(NationalSpire.MarketPosition, string)`；输入表达式：`session.Close(p)`；返回值紧邻使用处：`ExpressionStatementSyntax: session.Close(p);`
- `NationalSpire.MarketClearing.Session.Session(NationalSpire.MarketAsset, NationalSpire.MarketQuote, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>)`；输入表达式：`new(MarketCatalog.ById[p.Asset], market.Quotes[p.Asset], accounts)`；返回值紧邻使用处：`AssignmentExpressionSyntax: session = new(MarketCatalog.ById[p.Asset], market.Quotes[p.Asset], accounts)`
- `NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`；输入表达式：`MarketExecution.Close(p, q)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MarketExecution.Close(p, q)`
- `NationalSpire.MarketExecution.Consume(NationalSpire.MarketQuote, NationalSpire.MarketAsset, NationalSpire.MarketExecution.Fill)`；输入表达式：`MarketExecution.Consume(q, MarketCatalog.ById[p.Asset], exit.Fill)`；返回值紧邻使用处：`ExpressionStatementSyntax: MarketExecution.Consume(q, MarketCatalog.ById[p.Asset], exit.Fill);`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(c.Owner, account)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => ReferenceEquals(c.Owner, account)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, Session>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, Session>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`sessions.TryGetValue(p.Asset, out var session)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !sessions.TryGetValue(p.Asset, out var session)`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, decimal>)`；输入表达式：`s.Result.Closed.Where(c => ReferenceEquals(c.Owner, account)).Sum(c => c.Exit.Proceeds)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: s => s.Result.Closed.Where(c => ReferenceEquals(c.Owner, account)).Sum(c => c.Exit.Proceeds)`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, decimal>)`；输入表达式：`sessions.Values.Sum(s => s.Result.Closed.Where(c => ReferenceEquals(c.Owner, account)).Sum(c => c.Exit.Proceeds))`；返回值紧邻使用处：`BinaryExpressionSyntax: result + sessions.Values.Sum(s => s.Result.Closed.Where(c => ReferenceEquals(c.Owner, account)).Sum(c => c.Exit.Proceeds))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`s.Result.Closed.Where(c => ReferenceEquals(c.Owner, account))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: s.Result.Closed.Where(c => ReferenceEquals(c.Owner, account)).Sum`

**赋值（含属性/字段和局部值）：**

- `result` += `exit.Proceeds`
- `session` = `new(MarketCatalog.ById[p.Asset], market.Quotes[p.Asset], accounts)`
- `sessions[p.Asset]` = `session = new(MarketCatalog.ById[p.Asset], market.Quotes[p.Asset], accounts)`

<a id="symbol-fd783a2c49ef"></a>

## `NationalSpire.MarketClearing.Commit(NationalSpire.MarketState, string, NationalSpire.MarketClearing.Result, int) — public static void Commit(MarketState market, string asset, Result result, int day)`

来源：源码第 277 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`](CareerMarket.cs.md#symbol-6b9ac5b0686c)；[`NationalSpire.MarketClearing.Reprice(NationalSpire.MarketState, string, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, int, decimal)`](MarketClearing.cs.md#symbol-fbef13444d2b)；[`NationalSpire.MarketClearing.Settle(NationalSpire.MarketState, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, int)`](MarketClearing.cs.md#symbol-25fcc46bf36d)

**调用：** [`NationalSpire.CareerMarket.Record(NationalSpire.MarketAccount, int, string, decimal)`](CareerMarket.cs.md#symbol-a7af74d3e50b)；[`NationalSpire.MarketClearing.History(NationalSpire.MarketState, string, int)`](MarketClearing.cs.md#symbol-b311dd0df093)；[`NationalSpire.MarketClearing.Price(NationalSpire.MarketQuote)`](MarketClearing.cs.md#symbol-01242bd01825)；`decimal.ToString(string?)`；`System.Collections.Generic.List<T>.Remove(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMarket.Record(NationalSpire.MarketAccount, int, string, decimal)`；`NationalSpire.MarketAccount.Cash`；`NationalSpire.MarketAccount.Positions`；`NationalSpire.MarketAsset.Name`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketClearing.Closed.Exit`；`NationalSpire.MarketClearing.Closed.Owner`；`NationalSpire.MarketClearing.Closed.Position`；`NationalSpire.MarketClearing.Closed.Reason`；`NationalSpire.MarketClearing.History(NationalSpire.MarketState, string, int)`；`NationalSpire.MarketClearing.Price(NationalSpire.MarketQuote)`；`NationalSpire.MarketClearing.Result.Closed`；`NationalSpire.MarketClearing.Result.Quote`；`NationalSpire.MarketExecution.Exit.Fill`；`NationalSpire.MarketExecution.Exit.Proceeds`；`NationalSpire.MarketExecution.Fill.Average`；`NationalSpire.MarketQuote.ClearingDepthUnits`；`NationalSpire.MarketQuote.ExecutionBase`；`NationalSpire.MarketQuote.LongUnits`；`NationalSpire.MarketQuote.Price`；`NationalSpire.MarketQuote.ShortUnits`；`NationalSpire.MarketState.Quotes`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.ToString(string?)`；输入表达式：`closed.Exit.Fill.Average.ToString("0.00000")`；返回值紧邻使用处：`BinaryExpressionSyntax: MarketCatalog.ById[asset].Name + closed.Reason + " · 成交价" + closed.Exit.Fill.Average.ToString("0.00000")`
- `NationalSpire.CareerMarket.Record(NationalSpire.MarketAccount, int, string, decimal)`；输入表达式：`CareerMarket.Record(closed.Owner, day, MarketCatalog.ById[asset].Name + closed.Reason + " · 成交价" + closed.Exit.Fill.Average.ToString("0.00000"), closed.Exit.Proceeds)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMarket.Record(closed.Owner, day, MarketCatalog.ById[asset].Name + closed.Reason + " · 成交价" + closed.Exit.Fill.Average.ToString("0.00000"), closed.Exit.Proceeds);`
- `NationalSpire.MarketClearing.History(NationalSpire.MarketState, string, int)`；输入表达式：`History(market, asset, day)`；返回值紧邻使用处：`ExpressionStatementSyntax: History(market, asset, day);`
- `NationalSpire.MarketClearing.Price(NationalSpire.MarketQuote)`；输入表达式：`Price(q)`；返回值紧邻使用处：`AssignmentExpressionSyntax: q.Price = Price(q)`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`closed.Owner.Positions.Remove(closed.Position)`；返回值紧邻使用处：`ExpressionStatementSyntax: closed.Owner.Positions.Remove(closed.Position);`

**赋值（含属性/字段和局部值）：**

- `closed.Owner.Cash` += `closed.Exit.Proceeds`
- `q.ClearingDepthUnits` = `result.Quote.ClearingDepthUnits`
- `q.ExecutionBase` = `result.Quote.ExecutionBase`
- `q.LongUnits` = `result.Quote.LongUnits`
- `q.Price` = `Price(q)`
- `q.ShortUnits` = `result.Quote.ShortUnits`

<a id="symbol-b311dd0df093"></a>

## `NationalSpire.MarketClearing.History(NationalSpire.MarketState, string, int) — private static void History(MarketState market, string asset, int day)`

来源：源码第 289 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketClearing.Commit(NationalSpire.MarketState, string, NationalSpire.MarketClearing.Result, int)`](MarketClearing.cs.md#symbol-fd783a2c49ef)

**调用：** `NationalSpire.MarketPoint.MarketPoint(int, decimal)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.RemoveAt(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMarket.HistoryDays`；`NationalSpire.MarketPoint.Day`；`NationalSpire.MarketQuote.History`；`NationalSpire.MarketQuote.Price`；`NationalSpire.MarketState.Quotes`；`NationalSpire.MarketState.Revision`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketPoint.MarketPoint(int, decimal)`；输入表达式：`new(day, q.Price)`；返回值紧邻使用处：`ArgumentSyntax: new(day, q.Price)`
- `NationalSpire.MarketPoint.MarketPoint(int, decimal)`；输入表达式：`new(day, q.Price)`；返回值紧邻使用处：`AssignmentExpressionSyntax: q.History[^1] = new(day, q.Price)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`q.History.Add(new(day, q.Price))`；返回值紧邻使用处：`ExpressionStatementSyntax: q.History.Add(new(day, q.Price));`
- `System.Collections.Generic.List<T>.RemoveAt(int)`；输入表达式：`q.History.RemoveAt(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: q.History.RemoveAt(0);`

**赋值（含属性/字段和局部值）：**

- `q.History[^1]` = `new(day, q.Price)`

<a id="symbol-fbef13444d2b"></a>

## `NationalSpire.MarketClearing.Reprice(NationalSpire.MarketState, string, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, int, decimal) — public static void Reprice(MarketState market, string asset, IReadOnlyList<MarketAccount> accounts, int day, decimal price)`

来源：源码第 296 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Price(NationalSpire.CareerData, string, int, decimal)`](CareerMarket.cs.md#symbol-510ed75879b6)

**调用：** [`NationalSpire.MarketClearing.Commit(NationalSpire.MarketState, string, NationalSpire.MarketClearing.Result, int)`](MarketClearing.cs.md#symbol-fd783a2c49ef)；[`NationalSpire.MarketClearing.Session.Reprice(decimal)`](MarketClearing.cs.md#symbol-07ff00e14994)；[`NationalSpire.MarketClearing.Session.Session(NationalSpire.MarketAsset, NationalSpire.MarketQuote, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>)`](MarketClearing.cs.md#symbol-510ea2f6756a)；[`NationalSpire.MarketExecution.Reprice(NationalSpire.MarketQuote, decimal)`](MarketExecution.cs.md#symbol-d2f4f8cbac5d)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketClearing.Commit(NationalSpire.MarketState, string, NationalSpire.MarketClearing.Result, int)`；`NationalSpire.MarketClearing.Session.Reprice(decimal)`；`NationalSpire.MarketClearing.Session.Result`；`NationalSpire.MarketExecution.Reprice(NationalSpire.MarketQuote, decimal)`；`NationalSpire.MarketState.Quotes`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketClearing.Commit(NationalSpire.MarketState, string, NationalSpire.MarketClearing.Result, int)`；输入表达式：`Commit(market, asset, s.Result, day)`；返回值紧邻使用处：`ExpressionStatementSyntax: Commit(market, asset, s.Result, day);`
- `NationalSpire.MarketClearing.Session.Reprice(decimal)`；输入表达式：`s.Reprice(price)`；返回值紧邻使用处：`ExpressionStatementSyntax: s.Reprice(price);`
- `NationalSpire.MarketClearing.Session.Session(NationalSpire.MarketAsset, NationalSpire.MarketQuote, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>)`；输入表达式：`new Session(MarketCatalog.ById[asset], market.Quotes[asset], accounts)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Session(MarketCatalog.ById[asset], market.Quotes[asset], accounts)`
- `NationalSpire.MarketExecution.Reprice(NationalSpire.MarketQuote, decimal)`；输入表达式：`MarketExecution.Reprice(market.Quotes[asset], price)`；返回值紧邻使用处：`ExpressionStatementSyntax: MarketExecution.Reprice(market.Quotes[asset], price);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-25fcc46bf36d"></a>

## `NationalSpire.MarketClearing.Settle(NationalSpire.MarketState, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, int) — public static void Settle(MarketState market, IReadOnlyList<MarketAccount> accounts, int day)`

来源：源码第 303 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Accounts(NationalSpire.MarketState, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, int)`](CareerMarket.cs.md#symbol-81ec5ad63c25)

**调用：** [`NationalSpire.MarketClearing.Commit(NationalSpire.MarketState, string, NationalSpire.MarketClearing.Result, int)`](MarketClearing.cs.md#symbol-fd783a2c49ef)；[`NationalSpire.MarketClearing.Session.Session(NationalSpire.MarketAsset, NationalSpire.MarketQuote, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>)`](MarketClearing.cs.md#symbol-510ea2f6756a)；[`NationalSpire.MarketClearing.Session.Settle()`](MarketClearing.cs.md#symbol-cfca069d6308)；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketAccount.Positions`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketClearing.Commit(NationalSpire.MarketState, string, NationalSpire.MarketClearing.Result, int)`；`NationalSpire.MarketClearing.Result.Closed`；`NationalSpire.MarketClearing.Session.Result`；`NationalSpire.MarketClearing.Session.Settle()`；`NationalSpire.MarketPosition.Asset`；`NationalSpire.MarketPosition.ExecutionVersion`；`NationalSpire.MarketState.Quotes`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketClearing.Commit(NationalSpire.MarketState, string, NationalSpire.MarketClearing.Result, int)`；输入表达式：`Commit(market, asset, s.Result, day)`；返回值紧邻使用处：`ExpressionStatementSyntax: Commit(market, asset, s.Result, day);`
- `NationalSpire.MarketClearing.Session.Session(NationalSpire.MarketAsset, NationalSpire.MarketQuote, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>)`；输入表达式：`new Session(MarketCatalog.ById[asset], market.Quotes[asset], accounts)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Session(MarketCatalog.ById[asset], market.Quotes[asset], accounts)`
- `NationalSpire.MarketClearing.Session.Settle()`；输入表达式：`s.Settle()`；返回值紧邻使用处：`ExpressionStatementSyntax: s.Settle();`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`accounts.SelectMany(a => a.Positions).Where(p => p.ExecutionVersion == 1).Select(p => p.Asset).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: accounts.SelectMany(a => a.Positions).Where(p => p.ExecutionVersion == 1).Select(p => p.Asset).Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`accounts.SelectMany(a => a.Positions).Where(p => p.ExecutionVersion == 1).Select(p => p.Asset)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: accounts.SelectMany(a => a.Positions).Where(p => p.ExecutionVersion == 1).Select(p => p.Asset).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`accounts.SelectMany(a => a.Positions)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: accounts.SelectMany(a => a.Positions).Where`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`accounts.SelectMany(a => a.Positions).Where(p => p.ExecutionVersion == 1).Select(p => p.Asset).Distinct().ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var asset in accounts.SelectMany(a => a.Positions).Where(p => p.ExecutionVersion == 1).Select(p => p.Asset).Distinct().ToArray())         {             var s = new Session(MarketCatalog.ById[asset], market.Quotes[asset], accounts); s.Settle();             if (s.Result.Closed.Count > 0) Commit(market, asset, s.Result, day);         }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`accounts.SelectMany(a => a.Positions).Where(p => p.ExecutionVersion == 1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: accounts.SelectMany(a => a.Positions).Where(p => p.ExecutionVersion == 1).Select`

**赋值（含属性/字段和局部值）：**
