# ConsumerData.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`A081A97B72F064D6D4FB1AC5C5370901E1A457BC0341FD737DF55DCF4E008073`。来源：[源码](../../ConsumerData.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.ConsumerOrder`、`NationalSpire.ConsumerState`、`NationalSpire.OwnedGood`、`NationalSpire.GoodVerb`、`NationalSpire.Good`、`NationalSpire.ConsumerCatalog`。

字段、事件及初始值（源码原样）：

```csharp
public const string Mass = "大众", Middle = "中产", Rich = "富裕", Luxury = "顶奢", Promo = "运营";
public static readonly string[] TierOrder = [Mass, Middle, Rich, Luxury, Promo];
public const int PromoPerSeason = 3;
public const int RepeatCooldown = 28;
public static readonly Good[] All = Build();
```

<a id="symbol-c5682df945c4"></a>

## `NationalSpire.ConsumerState.Goods — public List<OwnedGood> Goods`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-61fa63f5ea6c"></a>

## `NationalSpire.ConsumerState.BoughtDay — public Dictionary<string, int> BoughtDay`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-633b246701e5"></a>

## `NationalSpire.ConsumerState.PromoUsed — public Dictionary<string, int> PromoUsed`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-96e7b577d6e0"></a>

## `NationalSpire.ConsumerState.Season — public int Season`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-128f40a0f841"></a>

## `NationalSpire.ConsumerState.InvitedThisSeason — public Dictionary<string, int> InvitedThisSeason`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b28c94ee022e"></a>

## `NationalSpire.ConsumerState.LifetimeSpent — public long LifetimeSpent`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-285b546a570c"></a>

## `NationalSpire.ConsumerState.PurchaseCount — public int PurchaseCount`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2d602ee77778"></a>

## `NationalSpire.ConsumerState.PartyCount — public int PartyCount`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4f0cfd6b929e"></a>

## `NationalSpire.OwnedGood.Id — public string Id`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e8fd0e08ec2b"></a>

## `NationalSpire.OwnedGood.Name — public string Name`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b04eb2a58474"></a>

## `NationalSpire.OwnedGood.BoughtDay — public int BoughtDay`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-45488ba0bf61"></a>

## `NationalSpire.OwnedGood.Season — public int Season`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ff218ac93856"></a>

## `NationalSpire.OwnedGood.Price — public int Price`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a82091a24118"></a>

## `NationalSpire.OwnedGood.Durable — public bool Durable`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-22507e3db5ae"></a>

## `NationalSpire.OwnedGood.Consumed — public bool Consumed`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9ad620fabe37"></a>

## `NationalSpire.OwnedGood.UsedVerbs — public List<string> UsedVerbs`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-529eecc0a2c6"></a>

## `NationalSpire.OwnedGood.UsedSeason — public int UsedSeason`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4ce3c6ad3894"></a>

## `NationalSpire.Good.Durable — public bool Durable`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Good.Verbs`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2900dbf01d61"></a>

## `NationalSpire.Good.Collectible — public bool Collectible`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Good.Category`；`NationalSpire.Good.Durable`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-46828b8901c1"></a>

## `NationalSpire.ConsumerCatalog.Get(string) — public static Good? Get(string id)`

来源：源码第 57 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)；[`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?)`](ConsumerEngine.cs.md#symbol-6a13be5c34c1)；[`NationalSpire.ConsumerEngine.Use(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>)`](ConsumerEngine.cs.md#symbol-c0beece783ab)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerCatalog.All`；`NationalSpire.Good.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`All.FirstOrDefault(g => g.Id == id)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => All.FirstOrDefault(g => g.Id == id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4d4f5c1ae5a0"></a>

## `NationalSpire.ConsumerCatalog.InTier(string) — public static IEnumerable<Good> InTier(string tier)`

来源：源码第 58 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerCatalog.All`；`NationalSpire.Good.Tier`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`All.Where(g => g.Tier == tier)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => All.Where(g => g.Tier == tier)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9b228776d390"></a>

## `NationalSpire.ConsumerCatalog.Categories(string) — public static IEnumerable<string> Categories(string tier)`

来源：源码第 59 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerCatalog.All`；`NationalSpire.Good.Category`；`NationalSpire.Good.Tier`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`All.Where(g => g.Tier == tier).Select(g => g.Category).Distinct()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => All.Where(g => g.Tier == tier).Select(g => g.Category).Distinct()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`All.Where(g => g.Tier == tier).Select(g => g.Category)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: All.Where(g => g.Tier == tier).Select(g => g.Category).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`All.Where(g => g.Tier == tier)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: All.Where(g => g.Tier == tier).Select`

**赋值（含属性/字段和局部值）：**


<a id="symbol-326fd7a8724c"></a>

## `NationalSpire.ConsumerCatalog.Build() — private static Good[] Build()`

来源：源码第 61 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`Item(string, string, string, string, int, bool, bool, int)`](ConsumerData.cs.md#symbol-54e4d02b758c)；[`Wear(string, string, string, string, int, params NationalSpire.GoodVerb[])`](ConsumerData.cs.md#symbol-2f112b74cf2c)；`NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.Generic.List<T>.ToArray()`

**字段、属性、事件及方法组引用：** `Item(string, string, string, string, int, bool, bool, int)`；`NationalSpire.ConsumerCatalog.Luxury`；`NationalSpire.ConsumerCatalog.Mass`；`NationalSpire.ConsumerCatalog.Middle`；`NationalSpire.ConsumerCatalog.Promo`；`NationalSpire.ConsumerCatalog.Rich`；`Wear(string, string, string, string, int, params NationalSpire.GoodVerb[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "穿戴", "jacket", "户外冲锋衣", 2_200)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "穿戴", "jacket", "户外冲锋衣", 2_200);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "穿戴", "sneakers", "限量球鞋", 2_800)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "穿戴", "sneakers", "限量球鞋", 2_800);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "穿戴", "suit", "定制西服", 9_000)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "穿戴", "suit", "定制西服", 9_000);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "穿戴", "sunglasses", "设计师墨镜", 1_800)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "穿戴", "sunglasses", "设计师墨镜", 1_800);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "家居", "airpurifier", "静音空气净化器", 3_200)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "家居", "airpurifier", "静音空气净化器", 3_200);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "家居", "bedding", "高档床品", 2_600)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "家居", "bedding", "高档床品", 2_600);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "家居", "chair", "可调节工作椅", 2_400)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "家居", "chair", "可调节工作椅", 2_400);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "家居", "coffeemachine", "高级咖啡机", 5_000)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "家居", "coffeemachine", "高级咖啡机", 5_000);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "家居", "lamp", "暖光台灯", 400)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "家居", "lamp", "暖光台灯", 400);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "家居", "plant", "桌边绿植", 200)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "家居", "plant", "桌边绿植", 200);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "零食甜品", "cake", "生日蛋糕", 120)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "零食甜品", "cake", "生日蛋糕", 120);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "零食甜品", "coffee", "手冲咖啡豆", 150)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "零食甜品", "coffee", "手冲咖啡豆", 150);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "零食甜品", "hotpot", "请客火锅", 300, slots: 3)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "零食甜品", "hotpot", "请客火锅", 300, slots: 3);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "零食甜品", "icecream", "街角甜筒", 20)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "零食甜品", "icecream", "街角甜筒", 20);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "零食甜品", "milktea", "限定奶茶", 30)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "零食甜品", "milktea", "限定奶茶", 30);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "收藏", "figure", "纪念手办", 3_600)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "收藏", "figure", "纪念手办", 3_600);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "收藏", "jersey", "亲签球衣", 4_500)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "收藏", "jersey", "亲签球衣", 4_500);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "收藏", "magazine", "创刊号杂志", 700)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "收藏", "magazine", "创刊号杂志", 700);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "收藏", "poster", "限量签名海报", 1_600)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "收藏", "poster", "限量签名海报", 1_600);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "数码", "camera", "专业相机", 8_000)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "数码", "camera", "专业相机", 8_000);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "数码", "console", "家用主机", 3_000)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "数码", "console", "家用主机", 3_000);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "数码", "earbuds", "降噪耳机", 2_500)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "数码", "earbuds", "降噪耳机", 2_500);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "数码", "keyboard", "机械键盘", 2_000)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "数码", "keyboard", "机械键盘", 2_000);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "数码", "laptop", "高性能笔记本", 9_500)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "数码", "laptop", "高性能笔记本", 9_500);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "数码", "monitor", "高刷显示器", 3_500)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "数码", "monitor", "高刷显示器", 3_500);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "数码", "mouse", "电竞鼠标", 900)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "数码", "mouse", "电竞鼠标", 900);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "数码", "phone", "旗舰手机", 6_000)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "数码", "phone", "旗舰手机", 6_000);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "数码", "projector", "家用投影", 7_000)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "数码", "projector", "家用投影", 7_000);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "数码", "watch", "智能手表", 4_000)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "数码", "watch", "智能手表", 4_000);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "娱乐", "concert", "演唱会门票", 1_500, slots: 3)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "娱乐", "concert", "演唱会门票", 1_500, slots: 3);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "娱乐", "gameroom", "游戏厅通宵", 800, slots: 3)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "娱乐", "gameroom", "游戏厅通宵", 800, slots: 3);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "娱乐", "karaoke", "KTV 包厢", 1_000, slots: 3)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "娱乐", "karaoke", "KTV 包厢", 1_000, slots: 3);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "娱乐", "movie", "包场看电影", 600, slots: 3)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "娱乐", "movie", "包场看电影", 600, slots: 3);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Mass, "娱乐", "theatre", "小剧场包场", 1_200, slots: 3)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Mass, "娱乐", "theatre", "小剧场包场", 1_200, slots: 3);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Middle, "出行", "car", "私家车", 45_000)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Middle, "出行", "car", "私家车", 45_000);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Middle, "出行", "ebike", "高端电助力车", 30_000)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Middle, "出行", "ebike", "高端电助力车", 30_000);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Middle, "穿戴", "luxwatch", "高级腕表", 60_000)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Middle, "穿戴", "luxwatch", "高级腕表", 60_000);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Middle, "健康", "coach", "私教课包", 50_000)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Middle, "健康", "coach", "私教课包", 50_000);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Middle, "居住", "apartment", "小公寓首付", 80_000)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Middle, "居住", "apartment", "小公寓首付", 80_000);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Middle, "居住", "studio", "独立工作室", 100_000)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Middle, "居住", "studio", "独立工作室", 100_000);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Middle, "旅行", "beach", "海岛度假", 70_000, repeatable: true, slots: 3)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Middle, "旅行", "beach", "海岛度假", 70_000, repeatable: true, slots: 3);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Middle, "旅行", "foodtour", "美食巡礼", 35_000, repeatable: true, slots: 3)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Middle, "旅行", "foodtour", "美食巡礼", 35_000, repeatable: true, slots: 3);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Middle, "旅行", "ski", "滑雪季卡", 40_000, repeatable: true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Middle, "旅行", "ski", "滑雪季卡", 40_000, repeatable: true);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Middle, "旅行", "spa", "温泉度假", 30_000, repeatable: true, slots: 3)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Middle, "旅行", "spa", "温泉度假", 30_000, repeatable: true, slots: 3);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Middle, "数码", "cinema", "家庭影院", 90_000)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Middle, "数码", "cinema", "家庭影院", 90_000);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Promo, "热搜", "fandom", "粉丝团运营", 30_000, promo: true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Promo, "热搜", "fandom", "粉丝团运营", 30_000, promo: true);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Promo, "热搜", "hotsearch", "买热搜", 50_000, promo: true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Promo, "热搜", "hotsearch", "买热搜", 50_000, promo: true);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Promo, "推广", "interview", "专访投放", 250_000, promo: true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Promo, "推广", "interview", "专访投放", 250_000, promo: true);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Promo, "推广", "promo", "推广投放", 120_000, promo: true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Promo, "推广", "promo", "推广投放", 120_000, promo: true);`
- `Item(string, string, string, string, int, bool, bool, int)`；输入表达式：`Item(Rich, "旅行", "luxtravel", "超级奢侈旅游", 300_000, repeatable: true, slots: 3)`；返回值紧邻使用处：`ExpressionStatementSyntax: Item(Rich, "旅行", "luxtravel", "超级奢侈旅游", 300_000, repeatable: true, slots: 3);`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("auction", "小型拍卖夜", 6, 10)`；返回值紧邻使用处：`ArgumentSyntax: new("auction", "小型拍卖夜", 6, 10)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("brunch", "周末早午餐", 6, 10)`；返回值紧邻使用处：`ArgumentSyntax: new("brunch", "周末早午餐", 6, 10)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("camp", "露营同行", 4, 10)`；返回值紧邻使用处：`ArgumentSyntax: new("camp", "露营同行", 4, 10)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("convoy", "车队巡游", 6, 10)`；返回值紧邻使用处：`ArgumentSyntax: new("convoy", "车队巡游", 6, 10)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("dinner", "海上晚宴", 6, 12)`；返回值紧邻使用处：`ArgumentSyntax: new("dinner", "海上晚宴", 6, 12)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("dinner", "家宴", 6, 10)`；返回值紧邻使用处：`ArgumentSyntax: new("dinner", "家宴", 6, 10)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("drive", "载一人兜风", 1, 10)`；返回值紧邻使用处：`ArgumentSyntax: new("drive", "载一人兜风", 1, 10)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("feast", "岛宴", 6, 15)`；返回值紧邻使用处：`ArgumentSyntax: new("feast", "岛宴", 6, 15)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("festival", "岛上音乐节", 6, 15)`；返回值紧邻使用处：`ArgumentSyntax: new("festival", "岛上音乐节", 6, 15)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("garden", "花园茶会", 6, 12)`；返回值紧邻使用处：`ArgumentSyntax: new("garden", "花园茶会", 6, 12)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("gift", "赠酒", 1, 10)`；返回值紧邻使用处：`ArgumentSyntax: new("gift", "赠酒", 1, 10)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("loan", "出借展出", 1, 12)`；返回值紧邻使用处：`ArgumentSyntax: new("loan", "出借展出", 1, 12)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("marathon", "通宵影展", 4, 10)`；返回值紧邻使用处：`ArgumentSyntax: new("marathon", "通宵影展", 4, 10)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("offroad", "越野体验", 2, 10)`；返回值紧邻使用处：`ArgumentSyntax: new("offroad", "越野体验", 2, 10)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("open", "庄园开放日", 6, 12)`；返回值紧邻使用处：`ArgumentSyntax: new("open", "庄园开放日", 6, 12)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("openhouse", "开放日", 6, 10)`；返回值紧邻使用处：`ArgumentSyntax: new("openhouse", "开放日", 6, 10)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("party", "办一场 party", 6, 10)`；返回值紧邻使用处：`ArgumentSyntax: new("party", "办一场 party", 6, 10)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("party", "楼顶 party", 6, 10)`；返回值紧邻使用处：`ArgumentSyntax: new("party", "楼顶 party", 6, 10)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("party", "庄园宴会", 6, 12)`；返回值紧邻使用处：`ArgumentSyntax: new("party", "庄园宴会", 6, 12)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("premiere", "首映观影会", 6, 10)`；返回值紧邻使用处：`ArgumentSyntax: new("premiere", "首映观影会", 6, 10)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("preview", "私人预展", 6, 12)`；返回值紧邻使用处：`ArgumentSyntax: new("preview", "私人预展", 6, 12)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("regatta", "帆船观摩", 6, 12)`；返回值紧邻使用处：`ArgumentSyntax: new("regatta", "帆船观摩", 6, 12)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("retreat", "闭门集训营", 6, 15)`；返回值紧邻使用处：`ArgumentSyntax: new("retreat", "闭门集训营", 6, 15)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("review", "复盘放映", 6, 10)`；返回值紧邻使用处：`ArgumentSyntax: new("review", "复盘放映", 6, 10)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("roadtrip", "自驾远行", 2, 10)`；返回值紧邻使用处：`ArgumentSyntax: new("roadtrip", "自驾远行", 2, 10)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("sail", "出海", 6, 12)`；返回值紧邻使用处：`ArgumentSyntax: new("sail", "出海", 6, 12)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("salon", "艺术沙龙", 6, 12)`；返回值紧邻使用处：`ArgumentSyntax: new("salon", "艺术沙龙", 6, 12)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("show", "车友聚会", 6, 10)`；返回值紧邻使用处：`ArgumentSyntax: new("show", "车友聚会", 6, 10)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("tasting", "品酒会", 6, 10)`；返回值紧邻使用处：`ArgumentSyntax: new("tasting", "品酒会", 6, 10)`
- `NationalSpire.GoodVerb.GoodVerb(string, string, int, int)`；输入表达式：`new("view", "夜景小聚", 4, 10)`；返回值紧邻使用处：`ArgumentSyntax: new("view", "夜景小聚", 4, 10)`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Good>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<Good>()`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`list.ToArray()`；返回值紧邻使用处：`ReturnStatementSyntax: return list.ToArray();`
- `Wear(string, string, string, string, int, params NationalSpire.GoodVerb[])`；输入表达式：`Wear(Luxury, "出行", "yacht", "大型游艇", 6_000_000,              new("sail", "出海", 6, 12), new("dinner", "海上晚宴", 6, 12), new("regatta", "帆船观摩", 6, 12))`；返回值紧邻使用处：`ExpressionStatementSyntax: Wear(Luxury, "出行", "yacht", "大型游艇", 6_000_000,              new("sail", "出海", 6, 12), new("dinner", "海上晚宴", 6, 12), new("regatta", "帆船观摩", 6, 12));`
- `Wear(string, string, string, string, int, params NationalSpire.GoodVerb[])`；输入表达式：`Wear(Luxury, "居住", "estate", "庄园", 2_500_000,              new("party", "庄园宴会", 6, 12), new("garden", "花园茶会", 6, 12), new("open", "庄园开放日", 6, 12))`；返回值紧邻使用处：`ExpressionStatementSyntax: Wear(Luxury, "居住", "estate", "庄园", 2_500_000,              new("party", "庄园宴会", 6, 12), new("garden", "花园茶会", 6, 12), new("open", "庄园开放日", 6, 12));`
- `Wear(string, string, string, string, int, params NationalSpire.GoodVerb[])`；输入表达式：`Wear(Luxury, "居住", "island", "私人岛屿", 20_000_000,              new("feast", "岛宴", 6, 15), new("retreat", "闭门集训营", 6, 15), new("festival", "岛上音乐节", 6, 15))`；返回值紧邻使用处：`ExpressionStatementSyntax: Wear(Luxury, "居住", "island", "私人岛屿", 20_000_000,              new("feast", "岛宴", 6, 15), new("retreat", "闭门集训营", 6, 15), new("festival", "岛上音乐节", 6, 15));`
- `Wear(string, string, string, string, int, params NationalSpire.GoodVerb[])`；输入表达式：`Wear(Luxury, "收藏", "art", "当代艺术收藏", 3_000_000,              new("preview", "私人预展", 6, 12), new("salon", "艺术沙龙", 6, 12), new("loan", "出借展出", 1, 12))`；返回值紧邻使用处：`ExpressionStatementSyntax: Wear(Luxury, "收藏", "art", "当代艺术收藏", 3_000_000,              new("preview", "私人预展", 6, 12), new("salon", "艺术沙龙", 6, 12), new("loan", "出借展出", 1, 12));`
- `Wear(string, string, string, string, int, params NationalSpire.GoodVerb[])`；输入表达式：`Wear(Rich, "出行", "sportscar", "跑车", 500_000,              new("drive", "载一人兜风", 1, 10), new("show", "车友聚会", 6, 10), new("roadtrip", "自驾远行", 2, 10))`；返回值紧邻使用处：`ExpressionStatementSyntax: Wear(Rich, "出行", "sportscar", "跑车", 500_000,              new("drive", "载一人兜风", 1, 10), new("show", "车友聚会", 6, 10), new("roadtrip", "自驾远行", 2, 10));`
- `Wear(string, string, string, string, int, params NationalSpire.GoodVerb[])`；输入表达式：`Wear(Rich, "出行", "suv", "硬派越野车", 350_000,              new("camp", "露营同行", 4, 10), new("offroad", "越野体验", 2, 10), new("convoy", "车队巡游", 6, 10))`；返回值紧邻使用处：`ExpressionStatementSyntax: Wear(Rich, "出行", "suv", "硬派越野车", 350_000,              new("camp", "露营同行", 4, 10), new("offroad", "越野体验", 2, 10), new("convoy", "车队巡游", 6, 10));`
- `Wear(string, string, string, string, int, params NationalSpire.GoodVerb[])`；输入表达式：`Wear(Rich, "居住", "penthouse", "顶层公寓", 1_000_000,              new("party", "楼顶 party", 6, 10), new("view", "夜景小聚", 4, 10), new("brunch", "周末早午餐", 6, 10))`；返回值紧邻使用处：`ExpressionStatementSyntax: Wear(Rich, "居住", "penthouse", "顶层公寓", 1_000_000,              new("party", "楼顶 party", 6, 10), new("view", "夜景小聚", 4, 10), new("brunch", "周末早午餐", 6, 10));`
- `Wear(string, string, string, string, int, params NationalSpire.GoodVerb[])`；输入表达式：`Wear(Rich, "居住", "villa", "独栋别墅", 800_000,              new("party", "办一场 party", 6, 10), new("dinner", "家宴", 6, 10), new("openhouse", "开放日", 6, 10))`；返回值紧邻使用处：`ExpressionStatementSyntax: Wear(Rich, "居住", "villa", "独栋别墅", 800_000,              new("party", "办一场 party", 6, 10), new("dinner", "家宴", 6, 10), new("openhouse", "开放日", 6, 10));`
- `Wear(string, string, string, string, int, params NationalSpire.GoodVerb[])`；输入表达式：`Wear(Rich, "收藏", "cellar", "私人酒窖", 350_000,              new("tasting", "品酒会", 6, 10), new("auction", "小型拍卖夜", 6, 10), new("gift", "赠酒", 1, 10))`；返回值紧邻使用处：`ExpressionStatementSyntax: Wear(Rich, "收藏", "cellar", "私人酒窖", 350_000,              new("tasting", "品酒会", 6, 10), new("auction", "小型拍卖夜", 6, 10), new("gift", "赠酒", 1, 10));`
- `Wear(string, string, string, string, int, params NationalSpire.GoodVerb[])`；输入表达式：`Wear(Rich, "娱乐", "theater", "私人影音室", 400_000,              new("premiere", "首映观影会", 6, 10), new("marathon", "通宵影展", 4, 10), new("review", "复盘放映", 6, 10))`；返回值紧邻使用处：`ExpressionStatementSyntax: Wear(Rich, "娱乐", "theater", "私人影音室", 400_000,              new("premiere", "首映观影会", 6, 10), new("marathon", "通宵影展", 4, 10), new("review", "复盘放映", 6, 10));`

**赋值（含属性/字段和局部值）：**


<a id="symbol-54e4d02b758c"></a>

## `Item(string, string, string, string, int, bool, bool, int) — void Item(string tier, string category, string id, string name, int price, bool repeatable = false, bool promo = false, int slots = 0)`

来源：源码第 64 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerCatalog.Build()`](ConsumerData.cs.md#symbol-326fd7a8724c)

**调用：** `NationalSpire.Good.Good(string, string, string, string, int, NationalSpire.GoodVerb[], bool, bool, int)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Good.Good(string, string, string, string, int, NationalSpire.GoodVerb[], bool, bool, int)`；输入表达式：`new(id, tier, category, name, price, [], repeatable, promo, slots)`；返回值紧邻使用处：`ArgumentSyntax: new(id, tier, category, name, price, [], repeatable, promo, slots)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`list.Add(new(id, tier, category, name, price, [], repeatable, promo, slots))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => list.Add(new(id, tier, category, name, price, [], repeatable, promo, slots))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2f112b74cf2c"></a>

## `Wear(string, string, string, string, int, params NationalSpire.GoodVerb[]) — void Wear(string tier, string category, string id, string name, int price, params GoodVerb[] verbs)`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerCatalog.Build()`](ConsumerData.cs.md#symbol-326fd7a8724c)

**调用：** `NationalSpire.Good.Good(string, string, string, string, int, NationalSpire.GoodVerb[], bool, bool, int)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Good.Good(string, string, string, string, int, NationalSpire.GoodVerb[], bool, bool, int)`；输入表达式：`new(id, tier, category, name, price, verbs)`；返回值紧邻使用处：`ArgumentSyntax: new(id, tier, category, name, price, verbs)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`list.Add(new(id, tier, category, name, price, verbs))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => list.Add(new(id, tier, category, name, price, verbs))`

**赋值（含属性/字段和局部值）：**
