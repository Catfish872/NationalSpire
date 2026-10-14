# SponsorIncome.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`1F629F1420B5F9EBF4E7C371CF0473ACD0F0C1655758A5466571EA9D80E30898`。来源：[源码](../../SponsorIncome.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.SponsorIncome`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-9f0fa3e89b54"></a>

## `NationalSpire.SponsorIncome.PersonalTier(NationalSpire.CareerData) — public static int PersonalTier(CareerData d)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerCommerce.RefreshOffers(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-3523341b8f0b)；[`NationalSpire.SponsorIncome.Basis(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-3f281401ee8b)

**调用：** [`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CircuitAward.Kind`；`NationalSpire.CircuitAward.PersonId`；`NationalSpire.CircuitAward.Place`；`NationalSpire.EsportsCareer.CircuitAwards`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: a.PersonId == GroupChats.Human(d)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.CircuitAwards.Count(a =>         (a.PersonId == "player" || a.PersonId == GroupChats.Human(d)) && a.Place == "冠军" && a.Kind != "league")`；返回值紧邻使用处：`ArgumentSyntax: d.Esports.CircuitAwards.Count(a =>         (a.PersonId == "player" || a.PersonId == GroupChats.Human(d)) && a.Place == "冠军" && a.Kind != "league")`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(7, d.Esports.CircuitAwards.Count(a =>         (a.PersonId == "player" || a.PersonId == GroupChats.Human(d)) && a.Place == "冠军" && a.Kind != "league"))`；返回值紧邻使用处：`BinaryExpressionSyntax: 1 + Math.Min(7, d.Esports.CircuitAwards.Count(a =>         (a.PersonId == "player" || a.PersonId == GroupChats.Human(d)) && a.Place == "冠军" && a.Kind != "league"))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1eb1e1e5420e"></a>

## `NationalSpire.SponsorIncome.PersonalBase(string, int) — public static (int Retainer, int Win) PersonalBase(string plan, int tier)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerCommerce.RefreshOffers(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-3523341b8f0b)；[`NationalSpire.SponsorIncome.Basis(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-3f281401ee8b)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3f281401ee8b"></a>

## `NationalSpire.SponsorIncome.Basis(NationalSpire.CareerData, NationalSpire.SponsorContract) — private static (int Retainer, int Win) Basis(CareerData d, SponsorContract contract)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.SponsorIncome.Initialize(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-d66156cc1ea9)；[`NationalSpire.SponsorIncome.Retainer(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-0442434a4986)；[`NationalSpire.SponsorIncome.WinBonus(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-d4ed607773ea)

**调用：** [`NationalSpire.CareerAudience.QuoteMultiplier(int)`](CareerAudience.cs.md#symbol-f8e484fe597e)；[`NationalSpire.CareerCommerce.IdentityIndex(NationalSpire.CareerData, string)`](CareerCommerce.cs.md#symbol-e72ebe7c108f)；[`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3ba0e806ba5c)；[`NationalSpire.SponsorIncome.PersonalBase(string, int)`](SponsorIncome.cs.md#symbol-1eb1e1e5420e)；[`NationalSpire.SponsorIncome.PersonalTier(NationalSpire.CareerData)`](SponsorIncome.cs.md#symbol-9f0fa3e89b54)；`System.Math.Round(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAudience.QuoteMultiplier(int)`；`NationalSpire.CareerClub.Titles`；`NationalSpire.CareerCommerce.IdentityIndex(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.Fans`；`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；`NationalSpire.SponsorContract.BaseRetainer`；`NationalSpire.SponsorContract.BaseWinBonus`；`NationalSpire.SponsorContract.Plan`；`NationalSpire.SponsorContract.Retainer`；`NationalSpire.SponsorContract.TargetId`；`NationalSpire.SponsorContract.WinBonus`；`NationalSpire.SponsorIncome.PersonalBase(string, int)`；`NationalSpire.SponsorIncome.PersonalTier(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerAudience.QuoteMultiplier(int)`；输入表达式：`CareerAudience.QuoteMultiplier(d.Fans)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerAudience.QuoteMultiplier(d.Fans)`
- `NationalSpire.CareerCommerce.IdentityIndex(NationalSpire.CareerData, string)`；输入表达式：`CareerCommerce.IdentityIndex(d, contract.TargetId)`；返回值紧邻使用处：`SwitchExpressionSyntax: CareerCommerce.IdentityIndex(d, contract.TargetId) switch { 0 => 3200, 1 => 2000, 2 => 4200, _ => 1600 }`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(d, contract.TargetId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: EsportsWorld.Club(d, contract.TargetId)?.Titles`
- `NationalSpire.SponsorIncome.PersonalBase(string, int)`；输入表达式：`PersonalBase(contract.Plan, PersonalTier(d))`；返回值紧邻使用处：`ReturnStatementSyntax: return PersonalBase(contract.Plan, PersonalTier(d));`
- `NationalSpire.SponsorIncome.PersonalTier(NationalSpire.CareerData)`；输入表达式：`PersonalTier(d)`；返回值紧邻使用处：`ArgumentSyntax: PersonalTier(d)`
- `System.Math.Round(double)`；输入表达式：`Math.Round(contract.Retainer / multiplier)`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round(contract.Retainer / multiplier)`
- `System.Math.Round(double)`；输入表达式：`Math.Round(contract.WinBonus / multiplier)`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round(contract.WinBonus / multiplier)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d66156cc1ea9"></a>

## `NationalSpire.SponsorIncome.Initialize(NationalSpire.CareerData, NationalSpire.SponsorContract) — public static void Initialize(CareerData d, SponsorContract contract)`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerCommerce.AcceptSponsor(NationalSpire.CareerData, NationalSpire.SponsorContract)`](CareerCommerce.cs.md#symbol-dde63e77bf01)；[`NationalSpire.CircuitLedger.SeasonStart(NationalSpire.CareerData)`](CircuitLedger.cs.md#symbol-b971fd6392cb)；[`NationalSpire.SponsorIncome.Initialize(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-d66156cc1ea9)；[`NationalSpire.SponsorIncome.Upgrade(NationalSpire.CareerData)`](SponsorIncome.cs.md#symbol-efb9102304ba)

**调用：** [`NationalSpire.SponsorIncome.Basis(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-3f281401ee8b)；[`NationalSpire.SponsorIncome.Initialize(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-d66156cc1ea9)

**字段、属性、事件及方法组引用：** `(int Retainer, int Win).Retainer`；`(int Retainer, int Win).Win`；`NationalSpire.SponsorContract.BaseRetainer`；`NationalSpire.SponsorContract.BaseWinBonus`；`NationalSpire.SponsorContract.NextOffer`；`NationalSpire.SponsorIncome.Basis(NationalSpire.CareerData, NationalSpire.SponsorContract)`；`NationalSpire.SponsorIncome.Initialize(NationalSpire.CareerData, NationalSpire.SponsorContract)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.SponsorIncome.Basis(NationalSpire.CareerData, NationalSpire.SponsorContract)`；输入表达式：`Basis(d, contract)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Basis(d, contract)`
- `NationalSpire.SponsorIncome.Initialize(NationalSpire.CareerData, NationalSpire.SponsorContract)`；输入表达式：`Initialize(d, next)`；返回值紧邻使用处：`ExpressionStatementSyntax: Initialize(d, next);`

**赋值（含属性/字段和局部值）：**

- `contract.BaseRetainer` ??= `basis.Retainer`
- `contract.BaseWinBonus` ??= `basis.Win`

<a id="symbol-efb9102304ba"></a>

## `NationalSpire.SponsorIncome.Upgrade(NationalSpire.CareerData) — public static void Upgrade(CareerData d)`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerCommerce.RefreshOffers(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-3523341b8f0b)；[`NationalSpire.CareerCommerce.Upgrade(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-d734109c7eea)

**调用：** [`NationalSpire.SponsorIncome.Initialize(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-d66156cc1ea9)；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.EsportsCareer.SponsorOffers`；`NationalSpire.EsportsCareer.Sponsors`；`NationalSpire.SponsorContract.EndedDay`；`NationalSpire.SponsorIncome.Initialize(NationalSpire.CareerData, NationalSpire.SponsorContract)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.SponsorIncome.Initialize(NationalSpire.CareerData, NationalSpire.SponsorContract)`；输入表达式：`Initialize(d, contract)`；返回值紧邻使用处：`ExpressionStatementSyntax: Initialize(d, contract);`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`d.Esports.Sponsors.Where(c => c.EndedDay == 0).Concat(d.Esports.SponsorOffers)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var contract in d.Esports.Sponsors.Where(c => c.EndedDay == 0).Concat(d.Esports.SponsorOffers)) Initialize(d, contract);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Sponsors.Where(c => c.EndedDay == 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Sponsors.Where(c => c.EndedDay == 0).Concat`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0442434a4986"></a>

## `NationalSpire.SponsorIncome.Retainer(NationalSpire.CareerData, NationalSpire.SponsorContract) — public static int Retainer(CareerData d, SponsorContract contract)`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerCommerce.AcceptSponsor(NationalSpire.CareerData, NationalSpire.SponsorContract)`](CareerCommerce.cs.md#symbol-dde63e77bf01)；[`NationalSpire.CareerCommerce.Capture(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-02ba08b48a24)；[`NationalSpire.CareerCommerce.SeasonStart(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-f162ea564744)；[`NationalSpire.CareerCommerce.SponsorTerms(NationalSpire.CareerData, NationalSpire.SponsorContract)`](CareerCommerce.cs.md#symbol-3ed7cf5a8f49)；[`NationalSpire.CareerScreen.ShowSponsors(NationalSpire.CareerData)`](CircuitScreen.cs.md#symbol-c9965ddff0d7)；[`NationalSpire.CircuitLedger.SeasonStart(NationalSpire.CareerData)`](CircuitLedger.cs.md#symbol-b971fd6392cb)

**调用：** [`NationalSpire.SponsorIncome.Basis(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-3f281401ee8b)；[`NationalSpire.SponsorIncome.Multiplier(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-89b9ce8a4b62)；`System.Math.Round(double)`

**字段、属性、事件及方法组引用：** `(int Retainer, int Win).Retainer`；`NationalSpire.SponsorIncome.Basis(NationalSpire.CareerData, NationalSpire.SponsorContract)`；`NationalSpire.SponsorIncome.Multiplier(NationalSpire.CareerData, NationalSpire.SponsorContract)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.SponsorIncome.Basis(NationalSpire.CareerData, NationalSpire.SponsorContract)`；输入表达式：`Basis(d, contract)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Basis(d, contract).Retainer`
- `NationalSpire.SponsorIncome.Multiplier(NationalSpire.CareerData, NationalSpire.SponsorContract)`；输入表达式：`Multiplier(d, contract)`；返回值紧邻使用处：`BinaryExpressionSyntax: Basis(d, contract).Retainer * Multiplier(d, contract)`
- `System.Math.Round(double)`；输入表达式：`Math.Round(Basis(d, contract).Retainer * Multiplier(d, contract))`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round(Basis(d, contract).Retainer * Multiplier(d, contract))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d4ed607773ea"></a>

## `NationalSpire.SponsorIncome.WinBonus(NationalSpire.CareerData, NationalSpire.SponsorContract) — public static int WinBonus(CareerData d, SponsorContract contract)`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerCommerce.Capture(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-02ba08b48a24)；[`NationalSpire.CareerCommerce.PlayerMatch(NationalSpire.CareerData, NationalSpire.CareerMatch)`](CareerCommerce.cs.md#symbol-61ee1540f58f)；[`NationalSpire.CareerCommerce.SponsorTerms(NationalSpire.CareerData, NationalSpire.SponsorContract)`](CareerCommerce.cs.md#symbol-3ed7cf5a8f49)

**调用：** [`NationalSpire.SponsorIncome.Basis(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-3f281401ee8b)；[`NationalSpire.SponsorIncome.Multiplier(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-89b9ce8a4b62)；`System.Math.Round(double)`

**字段、属性、事件及方法组引用：** `(int Retainer, int Win).Win`；`NationalSpire.SponsorIncome.Basis(NationalSpire.CareerData, NationalSpire.SponsorContract)`；`NationalSpire.SponsorIncome.Multiplier(NationalSpire.CareerData, NationalSpire.SponsorContract)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.SponsorIncome.Basis(NationalSpire.CareerData, NationalSpire.SponsorContract)`；输入表达式：`Basis(d, contract)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Basis(d, contract).Win`
- `NationalSpire.SponsorIncome.Multiplier(NationalSpire.CareerData, NationalSpire.SponsorContract)`；输入表达式：`Multiplier(d, contract)`；返回值紧邻使用处：`BinaryExpressionSyntax: Basis(d, contract).Win * Multiplier(d, contract)`
- `System.Math.Round(double)`；输入表达式：`Math.Round(Basis(d, contract).Win * Multiplier(d, contract))`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round(Basis(d, contract).Win * Multiplier(d, contract))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-89b9ce8a4b62"></a>

## `NationalSpire.SponsorIncome.Multiplier(NationalSpire.CareerData, NationalSpire.SponsorContract) — private static double Multiplier(CareerData d, SponsorContract contract)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.SponsorIncome.Retainer(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-0442434a4986)；[`NationalSpire.SponsorIncome.WinBonus(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-d4ed607773ea)

**调用：** [`NationalSpire.CareerAudience.ClubMultiplier(int)`](CareerAudience.cs.md#symbol-6230afa93ab3)；[`NationalSpire.CareerAudience.QuoteMultiplier(int)`](CareerAudience.cs.md#symbol-f8e484fe597e)；[`NationalSpire.ClubAudience.Total(NationalSpire.CareerData, string)`](ClubAudience.cs.md#symbol-6a78e48d0de3)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAudience.ClubMultiplier(int)`；`NationalSpire.CareerAudience.QuoteMultiplier(int)`；`NationalSpire.CareerData.Fans`；`NationalSpire.ClubAudience.Total(NationalSpire.CareerData, string)`；`NationalSpire.SponsorContract.TargetId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerAudience.ClubMultiplier(int)`；输入表达式：`CareerAudience.ClubMultiplier(ClubAudience.Total(d, contract.TargetId))`；返回值紧邻使用处：`ConditionalExpressionSyntax: contract.TargetId == "player"         ? CareerAudience.QuoteMultiplier(d.Fans) : CareerAudience.ClubMultiplier(ClubAudience.Total(d, contract.TargetId))`
- `NationalSpire.CareerAudience.QuoteMultiplier(int)`；输入表达式：`CareerAudience.QuoteMultiplier(d.Fans)`；返回值紧邻使用处：`ConditionalExpressionSyntax: contract.TargetId == "player"         ? CareerAudience.QuoteMultiplier(d.Fans) : CareerAudience.ClubMultiplier(ClubAudience.Total(d, contract.TargetId))`
- `NationalSpire.ClubAudience.Total(NationalSpire.CareerData, string)`；输入表达式：`ClubAudience.Total(d, contract.TargetId)`；返回值紧邻使用处：`ArgumentSyntax: ClubAudience.Total(d, contract.TargetId)`

**赋值（含属性/字段和局部值）：**
