# MarketExecution.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`24F42B86D44C6CB27D31E62D741CCE1C546F38CDC3857C29E692310ADB83851E`。来源：[源码](../../MarketExecution.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.MarketExecution`、`NationalSpire.MarketExecution.Fill`、`NationalSpire.MarketExecution.Exit`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-c74291f4d6c7"></a>

## `NationalSpire.MarketExecution.Depth(NationalSpire.MarketAsset) — public static decimal Depth(MarketAsset asset)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketExecution.Book(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-339081fc9712)；[`NationalSpire.MarketTerminal.RefreshSelection()`](MarketTerminal.cs.md#symbol-c8cd06b76400)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.MarketAsset.Country`；`NationalSpire.MarketAsset.Forex`；`NationalSpire.MarketAsset.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(asset.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.StableHash(asset.Id) % 150_000_001`

**赋值（含属性/字段和局部值）：**


<a id="symbol-55dfa52c54f5"></a>

## `NationalSpire.MarketExecution.Root(decimal, int) — private static decimal Root(decimal x, int degree)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketExecution.Cash(decimal, decimal, decimal)`](MarketExecution.cs.md#symbol-3f6c894a5ba2)；[`NationalSpire.MarketExecution.Quantity(decimal, decimal, decimal)`](MarketExecution.cs.md#symbol-fd8e61ca27fa)；[`NationalSpire.MarketExecution.Shape(decimal, decimal)`](MarketExecution.cs.md#symbol-66313cdbbc7b)

**调用：** `System.Math.Pow(double, double)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Pow(double, double)`；输入表达式：`Math.Pow((double)x, 1.0 / degree)`；返回值紧邻使用处：`CastExpressionSyntax: (decimal)Math.Pow((double)x, 1.0 / degree)`

**赋值（含属性/字段和局部值）：**

- `r` = `degree == 2 ? (r + x / r) / 2 : (2 * r + x / r / r) / 3`

<a id="symbol-339081fc9712"></a>

## `NationalSpire.MarketExecution.Book(NationalSpire.MarketAsset, NationalSpire.MarketQuote) — private static (decimal Basis, decimal Depth) Book(MarketAsset asset, MarketQuote q)`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketExecution.Apply(NationalSpire.MarketState, string, NationalSpire.MarketExecution.Fill, int)`](MarketExecution.cs.md#symbol-9ad4ae339dd8)；[`NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-2508c79f1fc5)；[`NationalSpire.MarketExecution.LiquidationValue(NationalSpire.MarketState, NationalSpire.MarketAccount)`](MarketExecution.cs.md#symbol-77afecd31787)；[`NationalSpire.MarketExecution.Open(NationalSpire.MarketAsset, NationalSpire.MarketQuote, decimal, int)`](MarketExecution.cs.md#symbol-1d104843be66)

**调用：** [`NationalSpire.MarketExecution.Depth(NationalSpire.MarketAsset)`](MarketExecution.cs.md#symbol-c74291f4d6c7)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketExecution.Depth(NationalSpire.MarketAsset)`；`NationalSpire.MarketQuote.DepthUnits`；`NationalSpire.MarketQuote.ExecutionBase`；`NationalSpire.MarketQuote.Price`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketExecution.Depth(NationalSpire.MarketAsset)`；输入表达式：`Depth(asset)`；返回值紧邻使用处：`BinaryExpressionSyntax: Depth(asset) / q.Price`

**赋值（含属性/字段和局部值）：**


<a id="symbol-66313cdbbc7b"></a>

## `NationalSpire.MarketExecution.Shape(decimal, decimal) — private static decimal Shape(decimal u, decimal k)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-2508c79f1fc5)；[`NationalSpire.MarketExecution.Open(NationalSpire.MarketAsset, NationalSpire.MarketQuote, decimal, int)`](MarketExecution.cs.md#symbol-1d104843be66)

**调用：** [`NationalSpire.MarketExecution.Root(decimal, int)`](MarketExecution.cs.md#symbol-55dfa52c54f5)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketExecution.Root(decimal, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketExecution.Root(decimal, int)`；输入表达式：`Root(1 - 3 * u / (2 * k), 3)`；返回值紧邻使用处：`BinaryExpressionSyntax: 1 / Root(1 - 3 * u / (2 * k), 3)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3f6c894a5ba2"></a>

## `NationalSpire.MarketExecution.Cash(decimal, decimal, decimal) — private static decimal Cash(decimal u, decimal b, decimal k)`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-2508c79f1fc5)；[`NationalSpire.MarketExecution.Open(NationalSpire.MarketAsset, NationalSpire.MarketQuote, decimal, int)`](MarketExecution.cs.md#symbol-1d104843be66)

**调用：** [`NationalSpire.MarketExecution.Root(decimal, int)`](MarketExecution.cs.md#symbol-55dfa52c54f5)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketExecution.Root(decimal, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketExecution.Root(decimal, int)`；输入表达式：`Root(1 - 3 * u / (2 * k), 3)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Root(1 - 3 * u / (2 * k), 3)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fd8e61ca27fa"></a>

## `NationalSpire.MarketExecution.Quantity(decimal, decimal, decimal) — private static decimal Quantity(decimal cash, decimal b, decimal k)`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketExecution.Open(NationalSpire.MarketAsset, NationalSpire.MarketQuote, decimal, int)`](MarketExecution.cs.md#symbol-1d104843be66)

**调用：** [`NationalSpire.MarketExecution.Root(decimal, int)`](MarketExecution.cs.md#symbol-55dfa52c54f5)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketExecution.Root(decimal, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketExecution.Root(decimal, int)`；输入表达式：`Root(1 + cash / b / k, 2)`；返回值紧邻使用处：`BinaryExpressionSyntax: Root(1 + cash / b / k, 2) + 1`
- `NationalSpire.MarketExecution.Root(decimal, int)`；输入表达式：`Root(x, 2)`；返回值紧邻使用处：`BinaryExpressionSyntax: x * Root(x, 2)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1d104843be66"></a>

## `NationalSpire.MarketExecution.Open(NationalSpire.MarketAsset, NationalSpire.MarketQuote, decimal, int) — public static Fill Open(MarketAsset asset, MarketQuote q, decimal notional, int direction)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`](CareerMarket.cs.md#symbol-6b9ac5b0686c)；[`NationalSpire.MarketTerminal.RefreshFee()`](MarketTerminal.cs.md#symbol-1c08f523080f)

**调用：** [`NationalSpire.MarketExecution.Book(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-339081fc9712)；[`NationalSpire.MarketExecution.Cash(decimal, decimal, decimal)`](MarketExecution.cs.md#symbol-3f6c894a5ba2)；[`NationalSpire.MarketExecution.Quantity(decimal, decimal, decimal)`](MarketExecution.cs.md#symbol-fd8e61ca27fa)；[`NationalSpire.MarketExecution.Shape(decimal, decimal)`](MarketExecution.cs.md#symbol-66313cdbbc7b)；`NationalSpire.MarketExecution.Fill.Fill(decimal, decimal, decimal, decimal)`；`System.Math.Abs(decimal)`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketExecution.Book(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`；`NationalSpire.MarketExecution.Cash(decimal, decimal, decimal)`；`NationalSpire.MarketExecution.Quantity(decimal, decimal, decimal)`；`NationalSpire.MarketExecution.Shape(decimal, decimal)`；`NationalSpire.MarketQuote.OrderUnits`；`NationalSpire.MarketQuote.Price`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketExecution.Book(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`；输入表达式：`Book(asset, q)`；返回值紧邻使用处：`AssignmentExpressionSyntax: var (b, k) = Book(asset, q)`
- `NationalSpire.MarketExecution.Cash(decimal, decimal, decimal)`；输入表达式：`Cash(q.OrderUnits, b, k)`；返回值紧邻使用处：`BinaryExpressionSyntax: Cash(q.OrderUnits, b, k) + direction * notional`
- `NationalSpire.MarketExecution.Fill.Fill(decimal, decimal, decimal, decimal)`；输入表达式：`new(0, q.Price, q.OrderUnits, q.Price)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(0, q.Price, q.OrderUnits, q.Price);`
- `NationalSpire.MarketExecution.Fill.Fill(decimal, decimal, decimal, decimal)`；输入表达式：`new(units, notional / units, end, b * Shape(end, k))`；返回值紧邻使用处：`ReturnStatementSyntax: return new(units, notional / units, end, b * Shape(end, k));`
- `NationalSpire.MarketExecution.Quantity(decimal, decimal, decimal)`；输入表达式：`Quantity(Cash(q.OrderUnits, b, k) + direction * notional, b, k)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Quantity(Cash(q.OrderUnits, b, k) + direction * notional, b, k)`
- `NationalSpire.MarketExecution.Shape(decimal, decimal)`；输入表达式：`Shape(end, k)`；返回值紧邻使用处：`BinaryExpressionSyntax: b * Shape(end, k)`
- `System.Math.Abs(decimal)`；输入表达式：`Math.Abs(end - q.OrderUnits)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Abs(end - q.OrderUnits)`

**赋值（含属性/字段和局部值）：**

- `var (b, k)` = `Book(asset, q)`

<a id="symbol-2508c79f1fc5"></a>

## `NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote) — public static Exit Close(MarketPosition p, MarketQuote q)`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Accounts(NationalSpire.MarketState, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, int)`](CareerMarket.cs.md#symbol-81ec5ad63c25)；[`NationalSpire.CareerMarket.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`](CareerMarket.cs.md#symbol-6b9ac5b0686c)；[`NationalSpire.MarketExecution.LiquidationValue(NationalSpire.MarketState, NationalSpire.MarketAccount)`](MarketExecution.cs.md#symbol-77afecd31787)；[`NationalSpire.MarketPositionCard.Bind(NationalSpire.MarketPosition?, NationalSpire.MarketQuote?, long)`](MarketVisuals.cs.md#symbol-7522a8a9e836)

**调用：** [`NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`](CareerMarket.cs.md#symbol-8f53c28594f3)；[`NationalSpire.MarketExecution.Book(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-339081fc9712)；[`NationalSpire.MarketExecution.Cash(decimal, decimal, decimal)`](MarketExecution.cs.md#symbol-3f6c894a5ba2)；[`NationalSpire.MarketExecution.Shape(decimal, decimal)`](MarketExecution.cs.md#symbol-66313cdbbc7b)；`decimal.Round(decimal, int)`；`NationalSpire.MarketExecution.Exit.Exit(NationalSpire.MarketExecution.Fill, decimal, decimal, decimal)`；`NationalSpire.MarketExecution.Fill.Fill(decimal, decimal, decimal, decimal)`；`System.Math.Abs(decimal)`；`System.Math.Max(decimal, decimal)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMarket.FeeRate`；`NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`；`NationalSpire.MarketAsset.Forex`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketExecution.Book(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`；`NationalSpire.MarketExecution.Cash(decimal, decimal, decimal)`；`NationalSpire.MarketExecution.Shape(decimal, decimal)`；`NationalSpire.MarketPosition.Asset`；`NationalSpire.MarketPosition.Direction`；`NationalSpire.MarketPosition.Entry`；`NationalSpire.MarketPosition.Leverage`；`NationalSpire.MarketPosition.Margin`；`NationalSpire.MarketPosition.OpeningFee`；`NationalSpire.MarketPosition.Units`；`NationalSpire.MarketQuote.OrderUnits`；`NationalSpire.MarketQuote.Price`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.Round(decimal, int)`；输入表达式：`decimal.Round(Math.Max(0, p.Margin + p.Direction * p.Units * (average - p.Entry) - fee), 4)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = decimal.Round(Math.Max(0, p.Margin + p.Direction * p.Units * (average - p.Entry) - fee), 4)`
- `decimal.Round(decimal, int)`；输入表达式：`decimal.Round(notional * CareerMarket.FeeRate, 4)`；返回值紧邻使用处：`ConditionalExpressionSyntax: asset.Forex ? 0 : decimal.Round(notional * CareerMarket.FeeRate, 4)`
- `NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`；输入表达式：`CareerMarket.OpenFee(asset, p.Margin, p.Leverage)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.OpeningFee ?? CareerMarket.OpenFee(asset, p.Margin, p.Leverage)`
- `NationalSpire.MarketExecution.Book(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`；输入表达式：`Book(asset, q)`；返回值紧邻使用处：`AssignmentExpressionSyntax: var (b, k) = Book(asset, q)`
- `NationalSpire.MarketExecution.Cash(decimal, decimal, decimal)`；输入表达式：`Cash(end, b, k)`；返回值紧邻使用处：`BinaryExpressionSyntax: Cash(end, b, k) - Cash(q.OrderUnits, b, k)`
- `NationalSpire.MarketExecution.Cash(decimal, decimal, decimal)`；输入表达式：`Cash(q.OrderUnits, b, k)`；返回值紧邻使用处：`BinaryExpressionSyntax: Cash(end, b, k) - Cash(q.OrderUnits, b, k)`
- `NationalSpire.MarketExecution.Exit.Exit(NationalSpire.MarketExecution.Fill, decimal, decimal, decimal)`；输入表达式：`new(new(p.Units, average, end, b * Shape(end, k)), fee, proceeds, proceeds - p.Margin - openingFee)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(new(p.Units, average, end, b * Shape(end, k)), fee, proceeds, proceeds - p.Margin - openingFee);`
- `NationalSpire.MarketExecution.Fill.Fill(decimal, decimal, decimal, decimal)`；输入表达式：`new(p.Units, average, end, b * Shape(end, k))`；返回值紧邻使用处：`ArgumentSyntax: new(p.Units, average, end, b * Shape(end, k))`
- `NationalSpire.MarketExecution.Shape(decimal, decimal)`；输入表达式：`Shape(end, k)`；返回值紧邻使用处：`BinaryExpressionSyntax: b * Shape(end, k)`
- `System.Math.Abs(decimal)`；输入表达式：`Math.Abs(Cash(end, b, k) - Cash(q.OrderUnits, b, k))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Abs(Cash(end, b, k) - Cash(q.OrderUnits, b, k))`
- `System.Math.Max(decimal, decimal)`；输入表达式：`Math.Max(0, p.Margin + p.Direction * p.Units * (average - p.Entry) - fee)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, p.Margin + p.Direction * p.Units * (average - p.Entry) - fee)`

**赋值（含属性/字段和局部值）：**

- `var (b, k)` = `Book(asset, q)`

<a id="symbol-9ad4ae339dd8"></a>

## `NationalSpire.MarketExecution.Apply(NationalSpire.MarketState, string, NationalSpire.MarketExecution.Fill, int) — public static void Apply(MarketState market, string asset, Fill fill, int day)`

来源：源码第 59 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Accounts(NationalSpire.MarketState, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, int)`](CareerMarket.cs.md#symbol-81ec5ad63c25)；[`NationalSpire.CareerMarket.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`](CareerMarket.cs.md#symbol-6b9ac5b0686c)

**调用：** [`NationalSpire.MarketExecution.Book(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-339081fc9712)；`NationalSpire.MarketPoint.MarketPoint(int, decimal)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.RemoveAt(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMarket.HistoryDays`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketExecution.Book(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`；`NationalSpire.MarketExecution.Fill.EndPrice`；`NationalSpire.MarketExecution.Fill.EndUnits`；`NationalSpire.MarketPoint.Day`；`NationalSpire.MarketQuote.DepthUnits`；`NationalSpire.MarketQuote.ExecutionBase`；`NationalSpire.MarketQuote.History`；`NationalSpire.MarketQuote.OrderUnits`；`NationalSpire.MarketQuote.Price`；`NationalSpire.MarketState.Quotes`；`NationalSpire.MarketState.Revision`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketExecution.Book(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`；输入表达式：`Book(MarketCatalog.ById[asset], q)`；返回值紧邻使用处：`AssignmentExpressionSyntax: var (b, k) = Book(MarketCatalog.ById[asset], q)`
- `NationalSpire.MarketPoint.MarketPoint(int, decimal)`；输入表达式：`new(day, q.Price)`；返回值紧邻使用处：`ArgumentSyntax: new(day, q.Price)`
- `NationalSpire.MarketPoint.MarketPoint(int, decimal)`；输入表达式：`new(day, q.Price)`；返回值紧邻使用处：`AssignmentExpressionSyntax: q.History[^1] = new(day, q.Price)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`q.History.Add(new(day, q.Price))`；返回值紧邻使用处：`ExpressionStatementSyntax: q.History.Add(new(day, q.Price));`
- `System.Collections.Generic.List<T>.RemoveAt(int)`；输入表达式：`q.History.RemoveAt(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: q.History.RemoveAt(0);`

**赋值（含属性/字段和局部值）：**

- `q.DepthUnits` = `k`
- `q.ExecutionBase` = `b`
- `q.History[^1]` = `new(day, q.Price)`
- `q.OrderUnits` = `fill.EndUnits`
- `q.Price` = `fill.EndPrice`
- `var (b, k)` = `Book(MarketCatalog.ById[asset], q)`

<a id="symbol-d2f4f8cbac5d"></a>

## `NationalSpire.MarketExecution.Reprice(NationalSpire.MarketQuote, decimal) — public static void Reprice(MarketQuote q, decimal price)`

来源：源码第 69 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Price(NationalSpire.MarketQuote, int, decimal)`](CareerMarket.cs.md#symbol-3399009ec118)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.MarketQuote.DepthUnits`；`NationalSpire.MarketQuote.ExecutionBase`；`NationalSpire.MarketQuote.OrderUnits`；`NationalSpire.MarketQuote.Price`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `q.DepthUnits` *= `q.ExecutionBase / price`
- `q.ExecutionBase` = `price`
- `q.OrderUnits` = `0`
- `q.Price` = `price`

<a id="symbol-90e04f0c7b2e"></a>

## `NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote) — public static decimal ReferencePrice(MarketQuote q)`

来源：源码第 76 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Advance(NationalSpire.CareerData)`](CareerMarket.cs.md#symbol-6039084ecec7)；[`NationalSpire.CareerMarket.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](CareerMarket.cs.md#symbol-089c75a03be9)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.MarketQuote.ExecutionBase`；`NationalSpire.MarketQuote.Price`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-77afecd31787"></a>

## `NationalSpire.MarketExecution.LiquidationValue(NationalSpire.MarketState, NationalSpire.MarketAccount) — public static decimal LiquidationValue(MarketState market, MarketAccount account)`

来源：源码第 77 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Net(NationalSpire.MarketState, NationalSpire.MarketAccount)`](CareerMarket.cs.md#symbol-55ca9c614fb1)

**调用：** [`NationalSpire.MarketExecution.Book(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-339081fc9712)；[`NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-2508c79f1fc5)；[`NationalSpire.MarketQuote.ExecutionCopy()`](CareerMarketData.cs.md#symbol-0dd7cd2eabdc)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketAccount.Cash`；`NationalSpire.MarketAccount.Debt`；`NationalSpire.MarketAccount.Positions`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketExecution.Book(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`；`NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`；`NationalSpire.MarketExecution.Exit.Fill`；`NationalSpire.MarketExecution.Exit.Proceeds`；`NationalSpire.MarketExecution.Fill.EndPrice`；`NationalSpire.MarketExecution.Fill.EndUnits`；`NationalSpire.MarketPosition.Asset`；`NationalSpire.MarketQuote.DepthUnits`；`NationalSpire.MarketQuote.ExecutionBase`；`NationalSpire.MarketQuote.ExecutionCopy()`；`NationalSpire.MarketQuote.OrderUnits`；`NationalSpire.MarketQuote.Price`；`NationalSpire.MarketState.Quotes`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketExecution.Book(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`；输入表达式：`Book(MarketCatalog.ById[p.Asset], q)`；返回值紧邻使用处：`AssignmentExpressionSyntax: var (b, k) = Book(MarketCatalog.ById[p.Asset], q)`
- `NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`；输入表达式：`Close(p, q)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Close(p, q)`
- `NationalSpire.MarketQuote.ExecutionCopy()`；输入表达式：`market.Quotes[p.Asset].ExecutionCopy()`；返回值紧邻使用处：`AssignmentExpressionSyntax: q = market.Quotes[p.Asset].ExecutionCopy()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, MarketQuote>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, MarketQuote>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`quotes.TryGetValue(p.Asset, out var q)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !quotes.TryGetValue(p.Asset, out var q)`

**赋值（含属性/字段和局部值）：**

- `q.DepthUnits` = `k`
- `q.ExecutionBase` = `b`
- `q.OrderUnits` = `exit.Fill.EndUnits`
- `q.Price` = `exit.Fill.EndPrice`
- `q` = `market.Quotes[p.Asset].ExecutionCopy()`
- `quotes[p.Asset]` = `q = market.Quotes[p.Asset].ExecutionCopy()`
- `result` += `exit.Proceeds`
- `var (b, k)` = `Book(MarketCatalog.ById[p.Asset], q)`
