# MarketExecution.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`9A147BEE99EF0BE379F4D77B031ED62D6BF472EE77E55DBA88457B6E3A4CE3BE`。来源：[源码](../../MarketExecution.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.MarketExecution`、`NationalSpire.MarketExecution.Fill`、`NationalSpire.MarketExecution.Exit`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-c74291f4d6c7"></a>

## `NationalSpire.MarketExecution.Depth(NationalSpire.MarketAsset) — public static decimal Depth(MarketAsset asset)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketClearing.Capacity(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`](MarketClearing.cs.md#symbol-64464988b285)；[`NationalSpire.MarketExecution.Book(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-339081fc9712)；[`NationalSpire.MarketTerminal.RefreshSelection()`](MarketTerminal.cs.md#symbol-c8cd06b76400)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.MarketAsset.Country`；`NationalSpire.MarketAsset.Forex`；`NationalSpire.MarketAsset.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(asset.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.StableHash(asset.Id) % 150_000_001`

**赋值（含属性/字段和局部值）：**


<a id="symbol-614fd34b2cf6"></a>

## `NationalSpire.MarketExecution.Root(NationalSpire.MarketNumber, int) — private static MarketNumber Root(MarketNumber x, int degree)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-2508c79f1fc5)；[`NationalSpire.MarketExecution.Open(NationalSpire.MarketAsset, NationalSpire.MarketQuote, decimal, int)`](MarketExecution.cs.md#symbol-1d104843be66)；[`NationalSpire.MarketExecution.Shape(NationalSpire.MarketNumber, decimal, int)`](MarketExecution.cs.md#symbol-b3af89bb9f05)

**调用：** [`NationalSpire.MarketNumber.Parse(string)`](MarketNumber.cs.md#symbol-fd06b4e8340e)；`double.ToString(string?, System.IFormatProvider?)`；`System.Math.Pow(double, double)`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketNumber.Parse(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `double.ToString(string?, System.IFormatProvider?)`；输入表达式：`Math.Pow((double)x, 1.0 / degree).ToString("R", System.Globalization.CultureInfo.InvariantCulture)`；返回值紧邻使用处：`ArgumentSyntax: Math.Pow((double)x, 1.0 / degree).ToString("R", System.Globalization.CultureInfo.InvariantCulture)`
- `NationalSpire.MarketNumber.Parse(string)`；输入表达式：`MarketNumber.Parse(Math.Pow((double)x, 1.0 / degree).ToString("R", System.Globalization.CultureInfo.InvariantCulture))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MarketNumber.Parse(Math.Pow((double)x, 1.0 / degree).ToString("R", System.Globalization.CultureInfo.InvariantCulture))`
- `System.Math.Pow(double, double)`；输入表达式：`Math.Pow((double)x, 1.0 / degree)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Math.Pow((double)x, 1.0 / degree).ToString`

**赋值（含属性/字段和局部值）：**

- `r` = `degree == 2 ? (r + x / r) / 2 : (2 * r + x / r / r) / 3`

<a id="symbol-339081fc9712"></a>

## `NationalSpire.MarketExecution.Book(NationalSpire.MarketAsset, NationalSpire.MarketQuote) — private static (decimal Basis, decimal Depth) Book(MarketAsset asset, MarketQuote q)`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-2508c79f1fc5)；[`NationalSpire.MarketExecution.Consume(NationalSpire.MarketQuote, NationalSpire.MarketAsset, NationalSpire.MarketExecution.Fill)`](MarketExecution.cs.md#symbol-d38348a5d5b3)；[`NationalSpire.MarketExecution.Open(NationalSpire.MarketAsset, NationalSpire.MarketQuote, decimal, int)`](MarketExecution.cs.md#symbol-1d104843be66)

**调用：** [`NationalSpire.MarketExecution.Depth(NationalSpire.MarketAsset)`](MarketExecution.cs.md#symbol-c74291f4d6c7)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketExecution.Depth(NationalSpire.MarketAsset)`；`NationalSpire.MarketQuote.DepthUnits`；`NationalSpire.MarketQuote.ExecutionBase`；`NationalSpire.MarketQuote.Price`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketExecution.Depth(NationalSpire.MarketAsset)`；输入表达式：`Depth(asset)`；返回值紧邻使用处：`BinaryExpressionSyntax: Depth(asset) / q.Price`

**赋值（含属性/字段和局部值）：**


<a id="symbol-722e0831cb22"></a>

## `NationalSpire.MarketExecution.Used(NationalSpire.MarketQuote, int) — private static MarketNumber Used(MarketQuote q, int direction)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-2508c79f1fc5)；[`NationalSpire.MarketExecution.Consume(NationalSpire.MarketQuote, NationalSpire.MarketAsset, NationalSpire.MarketExecution.Fill)`](MarketExecution.cs.md#symbol-d38348a5d5b3)；[`NationalSpire.MarketExecution.Open(NationalSpire.MarketAsset, NationalSpire.MarketQuote, decimal, int)`](MarketExecution.cs.md#symbol-1d104843be66)

**调用：** [`NationalSpire.MarketNumber.Max(NationalSpire.MarketNumber, NationalSpire.MarketNumber)`](MarketNumber.cs.md#symbol-0cf4c87609b0)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketNumber.Max(NationalSpire.MarketNumber, NationalSpire.MarketNumber)`；`NationalSpire.MarketQuote.BuyUnits`；`NationalSpire.MarketQuote.OrderUnits`；`NationalSpire.MarketQuote.SellUnits`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketNumber.Max(NationalSpire.MarketNumber, NationalSpire.MarketNumber)`；输入表达式：`MarketNumber.Max(0, -q.OrderUnits)`；返回值紧邻使用处：`BinaryExpressionSyntax: q.SellUnits ?? MarketNumber.Max(0, -q.OrderUnits)`
- `NationalSpire.MarketNumber.Max(NationalSpire.MarketNumber, NationalSpire.MarketNumber)`；输入表达式：`MarketNumber.Max(0, q.OrderUnits)`；返回值紧邻使用处：`BinaryExpressionSyntax: q.BuyUnits ?? MarketNumber.Max(0, q.OrderUnits)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b3af89bb9f05"></a>

## `NationalSpire.MarketExecution.Shape(NationalSpire.MarketNumber, decimal, int) — private static MarketNumber Shape(MarketNumber units, decimal depth, int direction)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-2508c79f1fc5)；[`NationalSpire.MarketExecution.Open(NationalSpire.MarketAsset, NationalSpire.MarketQuote, decimal, int)`](MarketExecution.cs.md#symbol-1d104843be66)

**调用：** [`NationalSpire.MarketExecution.Root(NationalSpire.MarketNumber, int)`](MarketExecution.cs.md#symbol-614fd34b2cf6)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketExecution.Root(NationalSpire.MarketNumber, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketExecution.Root(NationalSpire.MarketNumber, int)`；输入表达式：`Root(1 + 3 * units / (2 * depth), 3)`；返回值紧邻使用处：`BinaryExpressionSyntax: 1 / Root(1 + 3 * units / (2 * depth), 3)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1d104843be66"></a>

## `NationalSpire.MarketExecution.Open(NationalSpire.MarketAsset, NationalSpire.MarketQuote, decimal, int) — public static Fill Open(MarketAsset asset, MarketQuote q, decimal notional, int direction)`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.MarketExecution.Book(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-339081fc9712)；[`NationalSpire.MarketExecution.Root(NationalSpire.MarketNumber, int)`](MarketExecution.cs.md#symbol-614fd34b2cf6)；[`NationalSpire.MarketExecution.Shape(NationalSpire.MarketNumber, decimal, int)`](MarketExecution.cs.md#symbol-b3af89bb9f05)；[`NationalSpire.MarketExecution.Used(NationalSpire.MarketQuote, int)`](MarketExecution.cs.md#symbol-722e0831cb22)；`NationalSpire.MarketExecution.Fill.Fill(NationalSpire.MarketNumber, decimal, NationalSpire.MarketNumber, decimal, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketExecution.Book(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`；`NationalSpire.MarketExecution.Root(NationalSpire.MarketNumber, int)`；`NationalSpire.MarketExecution.Shape(NationalSpire.MarketNumber, decimal, int)`；`NationalSpire.MarketExecution.Used(NationalSpire.MarketQuote, int)`；`NationalSpire.MarketQuote.Price`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketExecution.Book(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`；输入表达式：`Book(asset, q)`；返回值紧邻使用处：`AssignmentExpressionSyntax: var (b, k) = Book(asset, q)`
- `NationalSpire.MarketExecution.Fill.Fill(NationalSpire.MarketNumber, decimal, NationalSpire.MarketNumber, decimal, int)`；输入表达式：`new(0, (decimal)(b * Shape(start, k, direction)), start, q.Price, direction)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(0, (decimal)(b * Shape(start, k, direction)), start, q.Price, direction);`
- `NationalSpire.MarketExecution.Fill.Fill(NationalSpire.MarketNumber, decimal, NationalSpire.MarketNumber, decimal, int)`；输入表达式：`new(units, (decimal)(notional / units), end, (decimal)(b * Shape(end, k, direction)), direction)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(units, (decimal)(notional / units), end, (decimal)(b * Shape(end, k, direction)), direction);`
- `NationalSpire.MarketExecution.Root(NationalSpire.MarketNumber, int)`；输入表达式：`Root(1 + 3 * start / (2 * k), 3)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Root(1 + 3 * start / (2 * k), 3)`
- `NationalSpire.MarketExecution.Root(NationalSpire.MarketNumber, int)`；输入表达式：`Root(previous * previous + (MarketNumber)notional / b / k, 2)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Root(previous * previous + (MarketNumber)notional / b / k, 2)`
- `NationalSpire.MarketExecution.Root(NationalSpire.MarketNumber, int)`；输入表达式：`Root(slope * slope + (MarketNumber)notional / b / k, 2)`；返回值紧邻使用处：`BinaryExpressionSyntax: Root(slope * slope + (MarketNumber)notional / b / k, 2) + slope`
- `NationalSpire.MarketExecution.Shape(NationalSpire.MarketNumber, decimal, int)`；输入表达式：`Shape(end, k, direction)`；返回值紧邻使用处：`BinaryExpressionSyntax: b * Shape(end, k, direction)`
- `NationalSpire.MarketExecution.Shape(NationalSpire.MarketNumber, decimal, int)`；输入表达式：`Shape(start, k, direction)`；返回值紧邻使用处：`BinaryExpressionSyntax: b * Shape(start, k, direction)`
- `NationalSpire.MarketExecution.Used(NationalSpire.MarketQuote, int)`；输入表达式：`Used(q, direction)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Used(q, direction)`

**赋值（含属性/字段和局部值）：**

- `units` = `2 * (MarketNumber)notional / (3 * b) * (next * next + next * previous + previous * previous) / (next + previous)`
- `units` = `2 * (MarketNumber)notional / b / (Root(slope * slope + (MarketNumber)notional / b / k, 2) + slope)`
- `var (b, k)` = `Book(asset, q)`

<a id="symbol-2508c79f1fc5"></a>

## `NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote) — public static Exit Close(MarketPosition p, MarketQuote q)`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Accounts(NationalSpire.MarketState, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, int)`](CareerMarket.cs.md#symbol-81ec5ad63c25)；[`NationalSpire.CareerMarket.Forced(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`](CareerMarket.cs.md#symbol-1770e33293db)；[`NationalSpire.CareerMarket.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`](CareerMarket.cs.md#symbol-6b9ac5b0686c)；[`NationalSpire.MarketClearing.LiquidationValue(NationalSpire.MarketState, NationalSpire.MarketAccount, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>)`](MarketClearing.cs.md#symbol-883f332c6946)；[`NationalSpire.MarketClearing.PreviewClose(NationalSpire.CareerData, NationalSpire.MarketPosition)`](MarketClearing.cs.md#symbol-554374f533fb)；[`NationalSpire.MarketExecution.LiquidationValue(NationalSpire.MarketState, NationalSpire.MarketAccount, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>?)`](MarketExecution.cs.md#symbol-38a7df5abf7b)；[`NationalSpire.MarketPositionCard.Bind(NationalSpire.MarketPosition?, NationalSpire.MarketQuote?, long, NationalSpire.MarketExecution.Exit?, bool)`](MarketVisuals.cs.md#symbol-fd36a7e27494)

**调用：** [`NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`](CareerMarket.cs.md#symbol-8f53c28594f3)；[`NationalSpire.MarketClearing.Exit(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`](MarketClearing.cs.md#symbol-3d4f1358211c)；[`NationalSpire.MarketExecution.Book(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-339081fc9712)；[`NationalSpire.MarketExecution.Root(NationalSpire.MarketNumber, int)`](MarketExecution.cs.md#symbol-614fd34b2cf6)；[`NationalSpire.MarketExecution.Shape(NationalSpire.MarketNumber, decimal, int)`](MarketExecution.cs.md#symbol-b3af89bb9f05)；[`NationalSpire.MarketExecution.Used(NationalSpire.MarketQuote, int)`](MarketExecution.cs.md#symbol-722e0831cb22)；[`NationalSpire.MarketNumber.Max(NationalSpire.MarketNumber, NationalSpire.MarketNumber)`](MarketNumber.cs.md#symbol-0cf4c87609b0)；[`NationalSpire.MarketNumber.Round(NationalSpire.MarketNumber, int)`](MarketNumber.cs.md#symbol-a3385d50f19f)；`NationalSpire.MarketExecution.Exit.Exit(NationalSpire.MarketExecution.Fill, NationalSpire.MarketNumber, decimal, decimal)`；`NationalSpire.MarketExecution.Fill.Fill(NationalSpire.MarketNumber, decimal, NationalSpire.MarketNumber, decimal, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMarket.FeeRate`；`NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`；`NationalSpire.MarketAsset.Forex`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketClearing.Exit(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`；`NationalSpire.MarketExecution.Book(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`；`NationalSpire.MarketExecution.Root(NationalSpire.MarketNumber, int)`；`NationalSpire.MarketExecution.Shape(NationalSpire.MarketNumber, decimal, int)`；`NationalSpire.MarketExecution.Used(NationalSpire.MarketQuote, int)`；`NationalSpire.MarketNumber.Max(NationalSpire.MarketNumber, NationalSpire.MarketNumber)`；`NationalSpire.MarketNumber.Round(NationalSpire.MarketNumber, int)`；`NationalSpire.MarketPosition.Asset`；`NationalSpire.MarketPosition.Direction`；`NationalSpire.MarketPosition.Entry`；`NationalSpire.MarketPosition.ExecutionVersion`；`NationalSpire.MarketPosition.Leverage`；`NationalSpire.MarketPosition.Margin`；`NationalSpire.MarketPosition.OpeningFee`；`NationalSpire.MarketPosition.Units`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMarket.OpenFee(NationalSpire.MarketAsset, decimal, int)`；输入表达式：`CareerMarket.OpenFee(asset, p.Margin, p.Leverage)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.OpeningFee ?? CareerMarket.OpenFee(asset, p.Margin, p.Leverage)`
- `NationalSpire.MarketClearing.Exit(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`；输入表达式：`MarketClearing.Exit(p, q)`；返回值紧邻使用处：`ReturnStatementSyntax: return MarketClearing.Exit(p, q);`
- `NationalSpire.MarketExecution.Book(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`；输入表达式：`Book(asset, q)`；返回值紧邻使用处：`AssignmentExpressionSyntax: var (b, k) = Book(asset, q)`
- `NationalSpire.MarketExecution.Exit.Exit(NationalSpire.MarketExecution.Fill, NationalSpire.MarketNumber, decimal, decimal)`；输入表达式：`new(new(p.Units, (decimal)average, end, (decimal)(b * Shape(end, k, direction)), direction), fee, proceeds, proceeds - p.Margin - openingFee)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(new(p.Units, (decimal)average, end, (decimal)(b * Shape(end, k, direction)), direction), fee, proceeds, proceeds - p.Margin - openingFee);`
- `NationalSpire.MarketExecution.Fill.Fill(NationalSpire.MarketNumber, decimal, NationalSpire.MarketNumber, decimal, int)`；输入表达式：`new(p.Units, (decimal)average, end, (decimal)(b * Shape(end, k, direction)), direction)`；返回值紧邻使用处：`ArgumentSyntax: new(p.Units, (decimal)average, end, (decimal)(b * Shape(end, k, direction)), direction)`
- `NationalSpire.MarketExecution.Root(NationalSpire.MarketNumber, int)`；输入表达式：`Root(1 + 3 * end / (2 * k), 3)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Root(1 + 3 * end / (2 * k), 3)`
- `NationalSpire.MarketExecution.Root(NationalSpire.MarketNumber, int)`；输入表达式：`Root(1 + 3 * start / (2 * k), 3)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Root(1 + 3 * start / (2 * k), 3)`
- `NationalSpire.MarketExecution.Shape(NationalSpire.MarketNumber, decimal, int)`；输入表达式：`Shape(end, k, direction)`；返回值紧邻使用处：`BinaryExpressionSyntax: b * Shape(end, k, direction)`
- `NationalSpire.MarketExecution.Used(NationalSpire.MarketQuote, int)`；输入表达式：`Used(q, direction)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Used(q, direction)`
- `NationalSpire.MarketNumber.Max(NationalSpire.MarketNumber, NationalSpire.MarketNumber)`；输入表达式：`MarketNumber.Max(0, p.Margin + p.Direction * p.Units * (average - p.Entry) - fee)`；返回值紧邻使用处：`ArgumentSyntax: MarketNumber.Max(0, p.Margin + p.Direction * p.Units * (average - p.Entry) - fee)`
- `NationalSpire.MarketNumber.Round(NationalSpire.MarketNumber, int)`；输入表达式：`MarketNumber.Round(average * p.Units * CareerMarket.FeeRate, 4)`；返回值紧邻使用处：`ConditionalExpressionSyntax: asset.Forex ? (MarketNumber)0 : MarketNumber.Round(average * p.Units * CareerMarket.FeeRate, 4)`
- `NationalSpire.MarketNumber.Round(NationalSpire.MarketNumber, int)`；输入表达式：`MarketNumber.Round(MarketNumber.Max(0, p.Margin + p.Direction * p.Units * (average - p.Entry) - fee), 4)`；返回值紧邻使用处：`CastExpressionSyntax: (decimal)MarketNumber.Round(MarketNumber.Max(0, p.Margin + p.Direction * p.Units * (average - p.Entry) - fee), 4)`

**赋值（含属性/字段和局部值）：**

- `average` = `1.5m * b * (last + first) / (last * last + last * first + first * first)`
- `average` = `b * (1 + (start + end) / (4 * k))`
- `var (b, k)` = `Book(asset, q)`

<a id="symbol-d38348a5d5b3"></a>

## `NationalSpire.MarketExecution.Consume(NationalSpire.MarketQuote, NationalSpire.MarketAsset, NationalSpire.MarketExecution.Fill) — internal static void Consume(MarketQuote q, MarketAsset asset, Fill fill)`

来源：源码第 70 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketClearing.LiquidationValue(NationalSpire.MarketState, NationalSpire.MarketAccount, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>)`](MarketClearing.cs.md#symbol-883f332c6946)；[`NationalSpire.MarketExecution.Apply(NationalSpire.MarketState, string, NationalSpire.MarketExecution.Fill, int)`](MarketExecution.cs.md#symbol-9ad4ae339dd8)；[`NationalSpire.MarketExecution.LiquidationValue(NationalSpire.MarketState, NationalSpire.MarketAccount, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>?)`](MarketExecution.cs.md#symbol-38a7df5abf7b)

**调用：** [`NationalSpire.MarketClearing.Price(NationalSpire.MarketQuote)`](MarketClearing.cs.md#symbol-01242bd01825)；[`NationalSpire.MarketExecution.Book(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-339081fc9712)；[`NationalSpire.MarketExecution.Used(NationalSpire.MarketQuote, int)`](MarketExecution.cs.md#symbol-722e0831cb22)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketClearing.Price(NationalSpire.MarketQuote)`；`NationalSpire.MarketExecution.Book(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`；`NationalSpire.MarketExecution.Fill.Direction`；`NationalSpire.MarketExecution.Fill.EndUnits`；`NationalSpire.MarketExecution.Used(NationalSpire.MarketQuote, int)`；`NationalSpire.MarketQuote.BuyUnits`；`NationalSpire.MarketQuote.DepthUnits`；`NationalSpire.MarketQuote.ExecutionBase`；`NationalSpire.MarketQuote.OrderUnits`；`NationalSpire.MarketQuote.Price`；`NationalSpire.MarketQuote.SellUnits`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketClearing.Price(NationalSpire.MarketQuote)`；输入表达式：`MarketClearing.Price(q)`；返回值紧邻使用处：`AssignmentExpressionSyntax: q.Price = MarketClearing.Price(q)`
- `NationalSpire.MarketExecution.Book(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`；输入表达式：`Book(asset, q)`；返回值紧邻使用处：`AssignmentExpressionSyntax: var (b, k) = Book(asset, q)`
- `NationalSpire.MarketExecution.Used(NationalSpire.MarketQuote, int)`；输入表达式：`Used(q, -1)`；返回值紧邻使用处：`ConditionalExpressionSyntax: fill.Direction < 0 ? fill.EndUnits : Used(q, -1)`
- `NationalSpire.MarketExecution.Used(NationalSpire.MarketQuote, int)`；输入表达式：`Used(q, 1)`；返回值紧邻使用处：`ConditionalExpressionSyntax: fill.Direction > 0 ? fill.EndUnits : Used(q, 1)`

**赋值（含属性/字段和局部值）：**

- `q.BuyUnits` = `fill.Direction > 0 ? fill.EndUnits : Used(q, 1)`
- `q.DepthUnits` = `k`
- `q.ExecutionBase` = `b`
- `q.OrderUnits` = `0`
- `q.Price` = `MarketClearing.Price(q)`
- `q.SellUnits` = `fill.Direction < 0 ? fill.EndUnits : Used(q, -1)`
- `var (b, k)` = `Book(asset, q)`

<a id="symbol-9ad4ae339dd8"></a>

## `NationalSpire.MarketExecution.Apply(NationalSpire.MarketState, string, NationalSpire.MarketExecution.Fill, int) — public static void Apply(MarketState market, string asset, Fill fill, int day)`

来源：源码第 78 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Accounts(NationalSpire.MarketState, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, int)`](CareerMarket.cs.md#symbol-81ec5ad63c25)；[`NationalSpire.CareerMarket.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`](CareerMarket.cs.md#symbol-6b9ac5b0686c)

**调用：** [`NationalSpire.MarketExecution.Consume(NationalSpire.MarketQuote, NationalSpire.MarketAsset, NationalSpire.MarketExecution.Fill)`](MarketExecution.cs.md#symbol-d38348a5d5b3)；`NationalSpire.MarketPoint.MarketPoint(int, decimal)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.RemoveAt(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMarket.HistoryDays`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketExecution.Consume(NationalSpire.MarketQuote, NationalSpire.MarketAsset, NationalSpire.MarketExecution.Fill)`；`NationalSpire.MarketPoint.Day`；`NationalSpire.MarketQuote.History`；`NationalSpire.MarketQuote.Price`；`NationalSpire.MarketState.Quotes`；`NationalSpire.MarketState.Revision`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketExecution.Consume(NationalSpire.MarketQuote, NationalSpire.MarketAsset, NationalSpire.MarketExecution.Fill)`；输入表达式：`Consume(q, MarketCatalog.ById[asset], fill)`；返回值紧邻使用处：`ExpressionStatementSyntax: Consume(q, MarketCatalog.ById[asset], fill);`
- `NationalSpire.MarketPoint.MarketPoint(int, decimal)`；输入表达式：`new(day, q.Price)`；返回值紧邻使用处：`ArgumentSyntax: new(day, q.Price)`
- `NationalSpire.MarketPoint.MarketPoint(int, decimal)`；输入表达式：`new(day, q.Price)`；返回值紧邻使用处：`AssignmentExpressionSyntax: q.History[^1] = new(day, q.Price)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`q.History.Add(new(day, q.Price))`；返回值紧邻使用处：`ExpressionStatementSyntax: q.History.Add(new(day, q.Price));`
- `System.Collections.Generic.List<T>.RemoveAt(int)`；输入表达式：`q.History.RemoveAt(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: q.History.RemoveAt(0);`

**赋值（含属性/字段和局部值）：**

- `q.History[^1]` = `new(day, q.Price)`

<a id="symbol-d2f4f8cbac5d"></a>

## `NationalSpire.MarketExecution.Reprice(NationalSpire.MarketQuote, decimal) — public static void Reprice(MarketQuote q, decimal price)`

来源：源码第 86 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Price(NationalSpire.MarketQuote, int, decimal)`](CareerMarket.cs.md#symbol-3399009ec118)；[`NationalSpire.MarketClearing.Reprice(NationalSpire.MarketState, string, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, int, decimal)`](MarketClearing.cs.md#symbol-fbef13444d2b)

**调用：** [`NationalSpire.MarketClearing.Price(NationalSpire.MarketQuote)`](MarketClearing.cs.md#symbol-01242bd01825)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketClearing.Price(NationalSpire.MarketQuote)`；`NationalSpire.MarketQuote.BuyUnits`；`NationalSpire.MarketQuote.DepthUnits`；`NationalSpire.MarketQuote.ExecutionBase`；`NationalSpire.MarketQuote.OrderUnits`；`NationalSpire.MarketQuote.Price`；`NationalSpire.MarketQuote.SellUnits`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketClearing.Price(NationalSpire.MarketQuote)`；输入表达式：`MarketClearing.Price(q)`；返回值紧邻使用处：`AssignmentExpressionSyntax: q.Price = MarketClearing.Price(q)`

**赋值（含属性/字段和局部值）：**

- `q.BuyUnits` = `q.SellUnits = 0`
- `q.DepthUnits` *= `q.ExecutionBase / price`
- `q.ExecutionBase` = `price`
- `q.OrderUnits` = `0`
- `q.Price` = `MarketClearing.Price(q)`
- `q.SellUnits` = `0`

<a id="symbol-90e04f0c7b2e"></a>

## `NationalSpire.MarketExecution.ReferencePrice(NationalSpire.MarketQuote) — public static decimal ReferencePrice(MarketQuote q)`

来源：源码第 93 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Accounts(NationalSpire.MarketState, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, int)`](CareerMarket.cs.md#symbol-81ec5ad63c25)；[`NationalSpire.CareerMarket.Advance(NationalSpire.CareerData)`](CareerMarket.cs.md#symbol-6039084ecec7)；[`NationalSpire.CareerMarket.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](CareerMarket.cs.md#symbol-089c75a03be9)；[`NationalSpire.CareerMarket.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`](CareerMarket.cs.md#symbol-6b9ac5b0686c)；[`NationalSpire.MarketClearing.Average(NationalSpire.MarketQuote, decimal, int)`](MarketClearing.cs.md#symbol-5f9bf3d5e43b)；[`NationalSpire.MarketClearing.Capacity(NationalSpire.MarketAsset, NationalSpire.MarketQuote)`](MarketClearing.cs.md#symbol-64464988b285)；[`NationalSpire.MarketClearing.Price(NationalSpire.MarketQuote)`](MarketClearing.cs.md#symbol-01242bd01825)；[`NationalSpire.MarketClearing.Quantity(NationalSpire.MarketQuote, decimal, int)`](MarketClearing.cs.md#symbol-aa62127e5a9c)；[`NationalSpire.MarketClearing.Session.Next(decimal, int, bool)`](MarketClearing.cs.md#symbol-c4416168b119)；[`NationalSpire.MarketClearing.Session.Open(decimal, int, int)`](MarketClearing.cs.md#symbol-318331fe9749)；[`NationalSpire.MarketClearing.Session.Reprice(decimal)`](MarketClearing.cs.md#symbol-07ff00e14994)；[`NationalSpire.MarketClearing.Session.Session(NationalSpire.MarketAsset, NationalSpire.MarketQuote, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>)`](MarketClearing.cs.md#symbol-510ea2f6756a)；[`NationalSpire.MarketPositionCard.Bind(NationalSpire.MarketPosition?, NationalSpire.MarketQuote?, long, NationalSpire.MarketExecution.Exit?, bool)`](MarketVisuals.cs.md#symbol-fd36a7e27494)；[`NationalSpire.MarketTerminal.RefreshSelection()`](MarketTerminal.cs.md#symbol-c8cd06b76400)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.MarketQuote.ExecutionBase`；`NationalSpire.MarketQuote.Price`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-38a7df5abf7b"></a>

## `NationalSpire.MarketExecution.LiquidationValue(NationalSpire.MarketState, NationalSpire.MarketAccount, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>?) — public static decimal LiquidationValue(MarketState market, MarketAccount account, IReadOnlyList<MarketAccount>? accounts = null)`

来源：源码第 94 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Net(NationalSpire.MarketState, NationalSpire.MarketAccount)`](CareerMarket.cs.md#symbol-55ca9c614fb1)；[`NationalSpire.MarketClearing.Inspect(NationalSpire.CareerData, NationalSpire.MarketInspection)`](MarketClearing.cs.md#symbol-d078c0ca2b29)；[`NationalSpire.MarketTerminal.RefreshAccount(bool)`](MarketTerminal.cs.md#symbol-9559baf40113)

**调用：** [`NationalSpire.MarketClearing.LiquidationValue(NationalSpire.MarketState, NationalSpire.MarketAccount, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>)`](MarketClearing.cs.md#symbol-883f332c6946)；[`NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-2508c79f1fc5)；[`NationalSpire.MarketExecution.Consume(NationalSpire.MarketQuote, NationalSpire.MarketAsset, NationalSpire.MarketExecution.Fill)`](MarketExecution.cs.md#symbol-d38348a5d5b3)；[`NationalSpire.MarketQuote.ExecutionCopy()`](CareerMarketData.cs.md#symbol-0dd7cd2eabdc)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketAccount.Cash`；`NationalSpire.MarketAccount.Debt`；`NationalSpire.MarketAccount.Positions`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketClearing.LiquidationValue(NationalSpire.MarketState, NationalSpire.MarketAccount, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>)`；`NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`；`NationalSpire.MarketExecution.Consume(NationalSpire.MarketQuote, NationalSpire.MarketAsset, NationalSpire.MarketExecution.Fill)`；`NationalSpire.MarketExecution.Exit.Fill`；`NationalSpire.MarketExecution.Exit.Proceeds`；`NationalSpire.MarketPosition.Asset`；`NationalSpire.MarketPosition.ExecutionVersion`；`NationalSpire.MarketQuote.ExecutionCopy()`；`NationalSpire.MarketState.Quotes`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketClearing.LiquidationValue(NationalSpire.MarketState, NationalSpire.MarketAccount, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>)`；输入表达式：`MarketClearing.LiquidationValue(market, account, accounts ?? [account])`；返回值紧邻使用处：`ReturnStatementSyntax: return MarketClearing.LiquidationValue(market, account, accounts ?? [account]);`
- `NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`；输入表达式：`Close(p, q)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Close(p, q)`
- `NationalSpire.MarketExecution.Consume(NationalSpire.MarketQuote, NationalSpire.MarketAsset, NationalSpire.MarketExecution.Fill)`；输入表达式：`Consume(q, MarketCatalog.ById[p.Asset], exit.Fill)`；返回值紧邻使用处：`ExpressionStatementSyntax: Consume(q, MarketCatalog.ById[p.Asset], exit.Fill);`
- `NationalSpire.MarketQuote.ExecutionCopy()`；输入表达式：`market.Quotes[p.Asset].ExecutionCopy()`；返回值紧邻使用处：`AssignmentExpressionSyntax: q = market.Quotes[p.Asset].ExecutionCopy()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, MarketQuote>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, MarketQuote>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`quotes.TryGetValue(p.Asset, out var q)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !quotes.TryGetValue(p.Asset, out var q)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`account.Positions.Any(p => p.ExecutionVersion == 1)`；返回值紧邻使用处：`IfStatementSyntax: if (account.Positions.Any(p => p.ExecutionVersion == 1)) return MarketClearing.LiquidationValue(market, account, accounts ?? [account]);`

**赋值（含属性/字段和局部值）：**

- `q` = `market.Quotes[p.Asset].ExecutionCopy()`
- `quotes[p.Asset]` = `q = market.Quotes[p.Asset].ExecutionCopy()`
- `result` += `exit.Proceeds`
