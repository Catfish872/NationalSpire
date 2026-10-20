# CareerIncome.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`0CD9E9E514854F15D25F3213AB9520A563C8E6756443A6B8C4558B5E1C635E21`。来源：[源码](../../CareerIncome.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerIncome`。

字段、事件及初始值（源码原样）：

```csharp
public const int LeaguePrize = 1500;
```

<a id="symbol-1b63d7ecce75"></a>

## `NationalSpire.CareerIncome.Attention(int, int) — public static int Attention(int fans, int basis)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerIncome.ClubAttention(int)`](CareerIncome.cs.md#symbol-9e4a6d612115)；[`NationalSpire.CareerIncome.PersonalAttention(int)`](CareerIncome.cs.md#symbol-689cee25e770)

**调用：** `System.Math.Max(int, int)`；`System.Math.Pow(double, double)`；`System.Math.Round(double)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, fans)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(0, fans) / 100000.0`
- `System.Math.Pow(double, double)`；输入表达式：`Math.Pow(1 + Math.Max(0, fans) / 100000.0, .4)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Pow(1 + Math.Max(0, fans) / 100000.0, .4) - 1`
- `System.Math.Round(double)`；输入表达式：`Math.Round(basis * (Math.Pow(1 + Math.Max(0, fans) / 100000.0, .4) - 1))`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round(basis * (Math.Pow(1 + Math.Max(0, fans) / 100000.0, .4) - 1))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-689cee25e770"></a>

## `NationalSpire.CareerIncome.PersonalAttention(int) — public static int PersonalAttention(int fans)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.RandomEventPrompts.Materials(NationalSpire.CareerData, NationalSpire.RandomEventRecord)`](RandomEventPrompts.cs.md#symbol-a96ac205ab9d)；[`NationalSpire.SponsorIncome.Retainer(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-0442434a4986)

**调用：** [`NationalSpire.CareerIncome.Attention(int, int)`](CareerIncome.cs.md#symbol-1b63d7ecce75)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerIncome.Attention(int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerIncome.Attention(int, int)`；输入表达式：`Attention(fans, 100000)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Attention(fans, 100000)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9e4a6d612115"></a>

## `NationalSpire.CareerIncome.ClubAttention(int) — public static int ClubAttention(int fans)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OwnedClubs.AudienceIncome(int)`](OwnedClubs.cs.md#symbol-b2b3c8e1de88)

**调用：** [`NationalSpire.CareerIncome.Attention(int, int)`](CareerIncome.cs.md#symbol-1b63d7ecce75)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerIncome.Attention(int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerIncome.Attention(int, int)`；输入表达式：`Attention(fans, 27000)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Attention(fans, 27000)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-550f85c3235c"></a>

## `NationalSpire.CareerIncome.WithDevelopment(NationalSpire.CareerData, int, string) — public static int WithDevelopment(CareerData d, int amount, string country)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OwnedClubs.Advance(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-7fe29c98085a)；[`NationalSpire.SponsorIncome.Retainer(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-0442434a4986)

**调用：** [`NationalSpire.NationalDevelopment.IncomeBonus(NationalSpire.CareerData, string)`](NationalDevelopment.cs.md#symbol-ab03f52da056)；`System.Math.Round(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.NationalDevelopment.IncomeBonus(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.NationalDevelopment.IncomeBonus(NationalSpire.CareerData, string)`；输入表达式：`NationalDevelopment.IncomeBonus(d, country)`；返回值紧邻使用处：`BinaryExpressionSyntax: 1 + NationalDevelopment.IncomeBonus(d, country)`
- `System.Math.Round(double)`；输入表达式：`Math.Round(amount * (1 + NationalDevelopment.IncomeBonus(d, country)))`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round(amount * (1 + NationalDevelopment.IncomeBonus(d, country)))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9e5daaaeb774"></a>

## `NationalSpire.CareerIncome.Upgrade(NationalSpire.ClubOffer) — public static void Upgrade(ClubOffer offer)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerCommerce.Quote(NationalSpire.CareerData, NationalSpire.CareerClub)`](CareerCommerce.cs.md#symbol-81a4731f8949)；[`NationalSpire.CareerIncome.Upgrade(NationalSpire.CareerData)`](CareerIncome.cs.md#symbol-f4fa17ce6d3d)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.ClubOffer.GoalReward`；`NationalSpire.ClubOffer.IncomeVersion`；`NationalSpire.ClubOffer.SeasonPay`；`NationalSpire.ClubOffer.WinBonus`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `offer.GoalReward` *= `3`
- `offer.IncomeVersion` = `1`
- `offer.SeasonPay` *= `2`
- `offer.WinBonus` *= `3`

<a id="symbol-f4fa17ce6d3d"></a>

## `NationalSpire.CareerIncome.Upgrade(NationalSpire.CareerData) — public static void Upgrade(CareerData data)`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerCommerce.RefreshOffers(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-3523341b8f0b)

**调用：** [`NationalSpire.CareerIncome.Upgrade(NationalSpire.ClubOffer)`](CareerIncome.cs.md#symbol-9e5daaaeb774)；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerIncome.LeaguePrize`；`NationalSpire.CareerIncome.Upgrade(NationalSpire.ClubOffer)`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CareerMatch.Prize`；`NationalSpire.CareerMatch.Status`；`NationalSpire.EsportsCareer.IncomeVersion`；`NationalSpire.EsportsCareer.Offers`；`NationalSpire.EsportsCareer.PlayerContract`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerIncome.Upgrade(NationalSpire.ClubOffer)`；输入表达式：`Upgrade(contract)`；返回值紧邻使用处：`ExpressionStatementSyntax: Upgrade(contract);`
- `NationalSpire.CareerIncome.Upgrade(NationalSpire.ClubOffer)`；输入表达式：`Upgrade(offer)`；返回值紧邻使用处：`ExpressionStatementSyntax: Upgrade(offer);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.Where(m => m.Kind == "league" && m.Status == "待赛" && m.Prize == 260)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var match in data.Matches.Where(m => m.Kind == "league" && m.Status == "待赛" && m.Prize == 260)) match.Prize = LeaguePrize;`

**赋值（含属性/字段和局部值）：**

- `data.Esports.IncomeVersion` = `1`
- `match.Prize` = `LeaguePrize`
