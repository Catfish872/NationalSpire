# MarketCurrency.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`439D5FB0B853656883DD1E78E24120FE3754AB05613FDA5B3C9341D5BBD0481E`。来源：[源码](../../MarketCurrency.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.MarketCurrency`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-deabbd84ec0d"></a>

## `NationalSpire.MarketCurrency.MarketCurrency(NationalSpire.CareerData, NationalSpire.MarketAsset) — internal MarketCurrency(CareerData data, MarketAsset asset) : this(data.Market, asset)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`](CareerMarket.cs.md#symbol-6b9ac5b0686c)；[`NationalSpire.MarketDynamics.TryPublish(NationalSpire.CareerData)`](MarketDynamics.cs.md#symbol-9d095f6ad885)；[`NationalSpire.MarketPositionCard.Bind(NationalSpire.MarketPosition?, NationalSpire.MarketQuote?, long, NationalSpire.MarketExecution.Exit?, bool, NationalSpire.CareerData?)`](MarketVisuals.cs.md#symbol-d96b884027a0)；[`NationalSpire.MarketTerminal.Bind(NationalSpire.CareerData, System.Action<NationalSpire.MarketOrder>, System.Action<string>)`](MarketTerminal.cs.md#symbol-09b1a1ea6de7)；[`NationalSpire.MarketTerminal.Open(int)`](MarketTerminal.cs.md#symbol-9665309ab157)；[`NationalSpire.MarketTerminal.RefreshChart()`](MarketTerminal.cs.md#symbol-e1b73bf4bb8f)；[`NationalSpire.MarketTerminal.RefreshFee()`](MarketTerminal.cs.md#symbol-1c08f523080f)；[`NationalSpire.MarketTerminal.RefreshList()`](MarketTerminal.cs.md#symbol-38f64566d7c6)；[`NationalSpire.MarketTerminal.RefreshSelection()`](MarketTerminal.cs.md#symbol-c8cd06b76400)；[`NationalSpire.MarketTerminal.RequestInspection()`](MarketTerminal.cs.md#symbol-332ba74db6e5)；[`NationalSpire.MarketTerminal.SortValue(NationalSpire.MarketAsset)`](MarketTerminal.cs.md#symbol-045b28b90c31)；[`Quote(decimal)`](MarketTerminal.cs.md#symbol-095ef7da98c0)；[`Quote(decimal)`](MarketTerminal.cs.md#symbol-945338433120)

**调用：** `NationalSpire.MarketCurrency.MarketCurrency(NationalSpire.MarketState, NationalSpire.MarketAsset)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Market`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketCurrency.MarketCurrency(NationalSpire.MarketState, NationalSpire.MarketAsset)`；输入表达式：`: this(data.Market, asset)`；返回值紧邻使用处：`ConstructorDeclarationSyntax: internal MarketCurrency(CareerData data, MarketAsset asset) : this(data.Market, asset) { }`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4637416f9d61"></a>

## `NationalSpire.MarketCurrency.Base — private MarketAsset? Base`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketAsset.Forex`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketState.QuoteCountry`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`MarketCatalog.ById.GetValueOrDefault("forex:" + market.QuoteCountry)`；返回值紧邻使用处：`ConditionalExpressionSyntax: asset.Forex ? MarketCatalog.ById.GetValueOrDefault("forex:" + market.QuoteCountry) : null`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e75adb3f2dbf"></a>

## `NationalSpire.MarketCurrency.BaseName(NationalSpire.CareerData) — internal static string BaseName(CareerData d)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketDynamics.TryPublish(NationalSpire.CareerData)`](MarketDynamics.cs.md#symbol-9d095f6ad885)

**调用：** [`NationalSpire.MarketCurrency.Unit(NationalSpire.MarketAsset)`](MarketCurrency.cs.md#symbol-e30543260a1c)；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Market`；`NationalSpire.MarketCatalog.ById`；`NationalSpire.MarketCurrency.Unit(NationalSpire.MarketAsset)`；`NationalSpire.MarketState.QuoteCountry`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketCurrency.Unit(NationalSpire.MarketAsset)`；输入表达式：`Unit(b)`；返回值紧邻使用处：`ConditionalExpressionSyntax: MarketCatalog.ById.TryGetValue("forex:" + d.Market.QuoteCountry, out var b) ? Unit(b) : "人民币"`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`MarketCatalog.ById.TryGetValue("forex:" + d.Market.QuoteCountry, out var b)`；返回值紧邻使用处：`ConditionalExpressionSyntax: MarketCatalog.ById.TryGetValue("forex:" + d.Market.QuoteCountry, out var b) ? Unit(b) : "人民币"`

**赋值（含属性/字段和局部值）：**


<a id="symbol-47dda3008c9c"></a>

## `NationalSpire.MarketCurrency.Inverse — internal bool Inverse`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.MarketAsset.Id`；`NationalSpire.MarketCurrency.Base`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e30543260a1c"></a>

## `NationalSpire.MarketCurrency.Unit(NationalSpire.MarketAsset) — private static string Unit(MarketAsset item)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketCurrency.BaseName(NationalSpire.CareerData)`](MarketCurrency.cs.md#symbol-e75adb3f2dbf)；[`NationalSpire.MarketCurrency.Display`](MarketCurrency.cs.md#symbol-e7a12c212ee3)

**调用：** `string.IndexOf(char)`；`string.Trim()`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketAsset.Name`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.IndexOf(char)`；输入表达式：`item.Name.IndexOf('/')`；返回值紧邻使用处：`BinaryExpressionSyntax: item.Name.IndexOf('/') + 1`
- `string.Trim()`；输入表达式：`item.Name[(item.Name.IndexOf('/') + 1)..].Trim()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => item.Name[(item.Name.IndexOf('/') + 1)..].Trim()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e7a12c212ee3"></a>

## `NationalSpire.MarketCurrency.Display — internal MarketAsset Display`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.MarketCurrency.Unit(NationalSpire.MarketAsset)`](MarketCurrency.cs.md#symbol-e30543260a1c)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketAsset.Country`；`NationalSpire.MarketAsset.Name`；`NationalSpire.MarketCurrency.Base`；`NationalSpire.MarketCurrency.Inverse`；`NationalSpire.MarketCurrency.Unit(NationalSpire.MarketAsset)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketCurrency.Unit(NationalSpire.MarketAsset)`；输入表达式：`Unit(asset)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Inverse ? "人民币" : Unit(asset)`
- `NationalSpire.MarketCurrency.Unit(NationalSpire.MarketAsset)`；输入表达式：`Unit(b)`；返回值紧邻使用处：`BinaryExpressionSyntax: Unit(b) + " / "`

**赋值（含属性/字段和局部值）：**

- `Country` = `Inverse ? "中国" : asset.Country`
- `Name` = `Unit(b) + " / " + (Inverse ? "人民币" : Unit(asset))`

<a id="symbol-5e2160264168"></a>

## `NationalSpire.MarketCurrency.Price(decimal, decimal) — internal decimal Price(decimal price, decimal basePrice)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketCurrency.Price(decimal)`](MarketCurrency.cs.md#symbol-d1da0ff57011)；[`NationalSpire.MarketCurrency.Quote(bool)`](MarketCurrency.cs.md#symbol-c01e1a8f1bee)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.MarketCurrency.Inverse`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d1da0ff57011"></a>

## `NationalSpire.MarketCurrency.Price(decimal) — internal decimal Price(decimal price)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketCurrency.FillText(string, decimal)`](MarketCurrency.cs.md#symbol-4cf3d1b2cfed)；[`NationalSpire.MarketDynamics.TryPublish(NationalSpire.CareerData)`](MarketDynamics.cs.md#symbol-9d095f6ad885)；[`NationalSpire.MarketPositionCard.Edit(bool)`](MarketVisuals.cs.md#symbol-cbcb21a0a9e2)；[`NationalSpire.MarketPositionCard.Price(decimal)`](MarketVisuals.cs.md#symbol-acc535d1e8c4)；[`Quote(decimal)`](MarketTerminal.cs.md#symbol-095ef7da98c0)；[`Quote(decimal)`](MarketTerminal.cs.md#symbol-945338433120)

**调用：** [`NationalSpire.MarketCurrency.Price(decimal, decimal)`](MarketCurrency.cs.md#symbol-5e2160264168)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketAsset.Id`；`NationalSpire.MarketCurrency.Base`；`NationalSpire.MarketCurrency.Price(decimal, decimal)`；`NationalSpire.MarketQuote.Price`；`NationalSpire.MarketState.Quotes`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketCurrency.Price(decimal, decimal)`；输入表达式：`Price(price, market.Quotes[b.Id].Price)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Base is { } b ? Price(price, market.Quotes[b.Id].Price) : price`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4cf3d1b2cfed"></a>

## `NationalSpire.MarketCurrency.FillText(string, decimal) — internal string FillText(string action, decimal price)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Accounts(NationalSpire.MarketState, System.Collections.Generic.IReadOnlyList<NationalSpire.MarketAccount>, int)`](CareerMarket.cs.md#symbol-81ec5ad63c25)；[`NationalSpire.MarketClearing.Commit(NationalSpire.MarketState, string, NationalSpire.MarketClearing.Result, int)`](MarketClearing.cs.md#symbol-fd783a2c49ef)

**调用：** [`NationalSpire.MarketCurrency.Price(decimal)`](MarketCurrency.cs.md#symbol-d1da0ff57011)；`decimal.ToString(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketAsset.Name`；`NationalSpire.MarketCurrency.Display`；`NationalSpire.MarketCurrency.Price(decimal)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.ToString(string?)`；输入表达式：`Price(price).ToString("0.00000")`；返回值紧邻使用处：`BinaryExpressionSyntax: Display.Name + action + " · 成交价" + Price(price).ToString("0.00000")`
- `NationalSpire.MarketCurrency.Price(decimal)`；输入表达式：`Price(price)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Price(price).ToString`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2f98c312b746"></a>

## `NationalSpire.MarketCurrency.Settlement(decimal) — internal decimal Settlement(decimal price)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketPositionCard.Apply()`](MarketVisuals.cs.md#symbol-dd2c5ccf395d)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.MarketAsset.Id`；`NationalSpire.MarketCurrency.Base`；`NationalSpire.MarketCurrency.Inverse`；`NationalSpire.MarketQuote.Price`；`NationalSpire.MarketState.Quotes`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c01e1a8f1bee"></a>

## `NationalSpire.MarketCurrency.Quote(bool) — internal MarketQuote Quote(bool history = false)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.RefreshChart()`](MarketTerminal.cs.md#symbol-e1b73bf4bb8f)；[`NationalSpire.MarketTerminal.RefreshList()`](MarketTerminal.cs.md#symbol-38f64566d7c6)；[`NationalSpire.MarketTerminal.RefreshSelection()`](MarketTerminal.cs.md#symbol-c8cd06b76400)；[`NationalSpire.MarketTerminal.SortValue(NationalSpire.MarketAsset)`](MarketTerminal.cs.md#symbol-045b28b90c31)

**调用：** [`NationalSpire.MarketCurrency.Price(decimal, decimal)`](MarketCurrency.cs.md#symbol-5e2160264168)；[`NationalSpire.MarketQuote.ExecutionCopy()`](CareerMarketData.cs.md#symbol-0dd7cd2eabdc)；`NationalSpire.MarketPoint.MarketPoint(int, decimal)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketAsset.Id`；`NationalSpire.MarketCurrency.Base`；`NationalSpire.MarketCurrency.Price(decimal, decimal)`；`NationalSpire.MarketPoint.Day`；`NationalSpire.MarketPoint.Price`；`NationalSpire.MarketQuote.ExecutionCopy()`；`NationalSpire.MarketQuote.History`；`NationalSpire.MarketQuote.Previous`；`NationalSpire.MarketQuote.Price`；`NationalSpire.MarketState.Quotes`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketCurrency.Price(decimal, decimal)`；输入表达式：`Price(q.Previous, reference.Previous)`；返回值紧邻使用处：`AssignmentExpressionSyntax: view.Previous = Price(q.Previous, reference.Previous)`
- `NationalSpire.MarketCurrency.Price(decimal, decimal)`；输入表达式：`Price(q.Price, reference.Price)`；返回值紧邻使用处：`AssignmentExpressionSyntax: view.Price = Price(q.Price, reference.Price)`
- `NationalSpire.MarketCurrency.Price(decimal, decimal)`；输入表达式：`unit.Price(p.Price, points.Count > 0 ? points[i].Price : reference.Price)`；返回值紧邻使用处：`ArgumentSyntax: unit.Price(p.Price, points.Count > 0 ? points[i].Price : reference.Price)`
- `NationalSpire.MarketPoint.MarketPoint(int, decimal)`；输入表达式：`new MarketPoint(p.Day, unit.Price(p.Price, points.Count > 0 ? points[i].Price : reference.Price))`；返回值紧邻使用处：`ReturnStatementSyntax: return new MarketPoint(p.Day, unit.Price(p.Price, points.Count > 0 ? points[i].Price : reference.Price));`
- `NationalSpire.MarketQuote.ExecutionCopy()`；输入表达式：`q.ExecutionCopy()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = q.ExecutionCopy()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`q.History.Select(p =>              {                  while (i + 1 < points.Count && points[i + 1].Day <= p.Day) i++;                  return new MarketPoint(p.Day, unit.Price(p.Price, points.Count > 0 ? points[i].Price : reference.Price));              })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: q.History.Select(p =>              {                  while (i + 1 < points.Count && points[i + 1].Day <= p.Day) i++;                  return new MarketPoint(p.Day, unit.Price(p.Price, points.Count > 0 ? points[i].Price : reference.Price));              }).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`q.History.Select(p =>              {                  while (i + 1 < points.Count && points[i + 1].Day <= p.Day) i++;                  return new MarketPoint(p.Day, unit.Price(p.Price, points.Count > 0 ? points[i].Price : reference.Price));              }).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: view.History = q.History.Select(p =>              {                  while (i + 1 < points.Count && points[i + 1].Day <= p.Day) i++;                  return new MarketPoint(p.Day, unit.Price(p.Price, points.Count > 0 ? points[i].Price : reference.Price));              }).ToList()`

**赋值（含属性/字段和局部值）：**

- `view.History` = `q.History.Select(p =>              {                  while (i + 1 < points.Count && points[i + 1].Day <= p.Day) i++;                  return new MarketPoint(p.Day, unit.Price(p.Price, points.Count > 0 ? points[i].Price : reference.Price));              }).ToList()`
- `view.Previous` = `Price(q.Previous, reference.Previous)`
- `view.Price` = `Price(q.Price, reference.Price)`
