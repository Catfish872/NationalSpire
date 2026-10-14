# CareerMarketData.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`C89DE53FFF891A3810F76E9F87085D2644C4D272A9C228D1AED98561FCF0F2C7`。来源：[源码](../../CareerMarketData.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.MarketAsset`、`NationalSpire.MarketState`、`NationalSpire.MarketQuote`、`NationalSpire.MarketPoint`、`NationalSpire.MarketEvent`、`NationalSpire.MarketAccount`、`NationalSpire.MarketPosition`、`NationalSpire.MarketTrade`、`NationalSpire.MarketOrder`、`NationalSpire.MarketCatalog`。

字段、事件及初始值（源码原样）：

```csharp
public static readonly IReadOnlyList<MarketAsset> Assets = Build();
public static readonly IReadOnlyDictionary<string, MarketAsset> ById = Assets.ToDictionary(a => a.Id);
```

<a id="symbol-4578e155d099"></a>

## `NationalSpire.MarketState.CatalogVersion — public int CatalogVersion`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c75d1deedfc8"></a>

## `NationalSpire.MarketState.LastDay — public int LastDay`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d5abf634e35b"></a>

## `NationalSpire.MarketState.Revision — public long Revision`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2635c3305a93"></a>

## `NationalSpire.MarketState.NewsDay — public int NewsDay`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e10a4c65da83"></a>

## `NationalSpire.MarketState.Events — public List<MarketEvent> Events`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1f13dd369b9b"></a>

## `NationalSpire.MarketState.Quotes — public Dictionary<string, MarketQuote> Quotes`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-caf04d1ab85e"></a>

## `NationalSpire.MarketQuote.Price — public decimal Price`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-953d2fe1d6f5"></a>

## `NationalSpire.MarketQuote.Previous — public decimal Previous`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6bc06b3737b3"></a>

## `NationalSpire.MarketQuote.SyntheticThrough — public int SyntheticThrough`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-cadbc0d2b5f3"></a>

## `NationalSpire.MarketQuote.PendingSignal — public decimal PendingSignal`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-98cec6b0bcf7"></a>

## `NationalSpire.MarketQuote.History — public List<MarketPoint> History`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-613091468123"></a>

## `NationalSpire.MarketAccount.Cash — public decimal Cash`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c04c8a693a46"></a>

## `NationalSpire.MarketAccount.Debt — public decimal Debt`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7babd8a99db7"></a>

## `NationalSpire.MarketAccount.InterestDay — public int InterestDay`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b04857964d6b"></a>

## `NationalSpire.MarketAccount.InterestRate — public decimal InterestRate`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMarket.DailyInterest`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-362cdceab946"></a>

## `NationalSpire.MarketAccount.NextPosition — public int NextPosition`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-958b1bd4938b"></a>

## `NationalSpire.MarketAccount.Positions — public List<MarketPosition> Positions`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ed5d14c786a9"></a>

## `NationalSpire.MarketAccount.Trades — public List<MarketTrade> Trades`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-82459713d990"></a>

## `NationalSpire.MarketPosition.Id — public int Id`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-21ac8780fa4e"></a>

## `NationalSpire.MarketPosition.Asset — public string Asset`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2a4f6c1aba44"></a>

## `NationalSpire.MarketPosition.Entry — public decimal Entry`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f1f0e09a1f6b"></a>

## `NationalSpire.MarketPosition.Margin — public decimal Margin`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a85874885003"></a>

## `NationalSpire.MarketPosition.Units — public decimal Units`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7564c375ebce"></a>

## `NationalSpire.MarketPosition.Leverage — public int Leverage`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6cdfca7ff12f"></a>

## `NationalSpire.MarketPosition.Direction — public int Direction`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0ea0537e57b7"></a>

## `NationalSpire.MarketCatalog.Build() — private static List<MarketAsset> Build()`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.RegionalOrganizations.Sponsors(string, int)`](RegionalOrganizations.cs.md#symbol-f76b5db64641)；`NationalSpire.MarketAsset.MarketAsset(string, string, string, string, bool, decimal)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.EsportsWorld.Countries`；`NationalSpire.RegionalOrganizations.Sponsors(string, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(country + brand)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.StableHash(country + brand) % 90`
- `NationalSpire.MarketAsset.MarketAsset(string, string, string, string, bool, decimal)`；输入表达式：`new("brand:" + country + ":" + brand, brand, country, new[] { "训练装备", "电竞设备", "日常消费" }[sector], false,                 10 + CareerEngine.StableHash(country + brand) % 90)`；返回值紧邻使用处：`ArgumentSyntax: new("brand:" + country + ":" + brand, brand, country, new[] { "训练装备", "电竞设备", "日常消费" }[sector], false,                 10 + CareerEngine.StableHash(country + brand) % 90)`
- `NationalSpire.MarketAsset.MarketAsset(string, string, string, string, bool, decimal)`；输入表达式：`new("forex:" + country, "人民币 / " + name, country, "外汇", true, initial)`；返回值紧邻使用处：`ArgumentSyntax: new("forex:" + country, "人民币 / " + name, country, "外汇", true, initial)`
- `NationalSpire.RegionalOrganizations.Sponsors(string, int)`；输入表达式：`RegionalOrganizations.Sponsors(country, sector)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string brand in RegionalOrganizations.Sponsors(country, sector))             all.Add(new("brand:" + country + ":" + brand, brand, country, new[] { "训练装备", "电竞设备", "日常消费" }[sector], false,                 10 + CareerEngine.StableHash(country + brand) % 90));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`all.Add(new("brand:" + country + ":" + brand, brand, country, new[] { "训练装备", "电竞设备", "日常消费" }[sector], false,                 10 + CareerEngine.StableHash(country + brand) % 90))`；返回值紧邻使用处：`ExpressionStatementSyntax: all.Add(new("brand:" + country + ":" + brand, brand, country, new[] { "训练装备", "电竞设备", "日常消费" }[sector], false,                 10 + CareerEngine.StableHash(country + brand) % 90));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`all.Add(new("forex:" + country, "人民币 / " + name, country, "外汇", true, initial))`；返回值紧邻使用处：`ExpressionStatementSyntax: all.Add(new("forex:" + country, "人民币 / " + name, country, "外汇", true, initial));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<MarketAsset>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<MarketAsset>()`

**赋值（含属性/字段和局部值）：**
