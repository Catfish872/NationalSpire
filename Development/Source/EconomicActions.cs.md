# EconomicActions.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`BD089AF5A6A358B506179D4A261AC31870558B1AD103B661B21BB429D4A640C0`。来源：[源码](../../EconomicActions.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.EconomicActions`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-6ec38e492fe6"></a>

## `NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>) — public static string? Save(CareerData data, Func<CareerData, string?> apply)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerSubmit(NationalSpire.CareerData, NationalSpire.Good, string, System.Collections.Generic.List<string>)`](ConsumerScreen.cs.md#symbol-a26966f14e5c)

**调用：** [`NationalSpire.CareerData.EncodingHeader()`](CareerData.cs.md#symbol-09cee4b6558d)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](Coop/CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`](Coop/CoopData.cs.md#symbol-85d2410ea3ba)；[`NationalSpire.EconomicActions.Copy(NationalSpire.CareerData, NationalSpire.CareerData)`](EconomicActions.cs.md#symbol-d4ca2504b704)；[`NationalSpire.EconomicActions.Persist(NationalSpire.CareerData, System.Action)`](EconomicActions.cs.md#symbol-d99b9fe32a07)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`System.Func<T, TResult>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.EncodingHeader()`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`；`NationalSpire.EconomicActions.Copy(NationalSpire.CareerData, NationalSpire.CareerData)`；`NationalSpire.EconomicActions.Persist(NationalSpire.CareerData, System.Action)`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.EconomicSave`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerData.EncodingHeader()`；输入表达式：`data.EncodingHeader()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.EncodingHeader()`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Copy(data)`
- `NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`；输入表达式：`CoopJson.Detached(candidate)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopJson.Detached(candidate);`
- `NationalSpire.EconomicActions.Copy(NationalSpire.CareerData, NationalSpire.CareerData)`；输入表达式：`Copy(before, data)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Copy(before, data)`
- `NationalSpire.EconomicActions.Copy(NationalSpire.CareerData, NationalSpire.CareerData)`；输入表达式：`Copy(candidate, data)`；返回值紧邻使用处：`ExpressionStatementSyntax: Copy(candidate, data);`
- `NationalSpire.EconomicActions.Persist(NationalSpire.CareerData, System.Action)`；输入表达式：`Persist(data, () => Copy(before, data))`；返回值紧邻使用处：`ReturnStatementSyntax: return Persist(data, () => Copy(before, data));`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.EconomicSave)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.EconomicSave)`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`apply(candidate)`；返回值紧邻使用处：`IsPatternExpressionSyntax: apply(candidate) is { } error`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f0516c3ecf95"></a>

## `NationalSpire.EconomicActions.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder) — public static string? Trade(CareerData data, MarketOrder order)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.MarketSubmit(NationalSpire.CareerData, NationalSpire.MarketOrder)`](MarketScreen.cs.md#symbol-fbc36ef790b1)

**调用：** [`NationalSpire.CareerMarket.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`](CareerMarket.cs.md#symbol-6b9ac5b0686c)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](Coop/CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.EconomicActions.Persist(NationalSpire.CareerData, System.Action)`](EconomicActions.cs.md#symbol-d99b9fe32a07)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`NationalSpire.CareerData.CareerData()`；`NationalSpire.CareerLifeState.CareerLifeState()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Market`；`NationalSpire.CareerLifeState.CreditFraction`；`NationalSpire.CareerLifeState.Ledger`；`NationalSpire.CareerLifeState.Trading`；`NationalSpire.CareerMarket.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.EconomicActions.Persist(NationalSpire.CareerData, System.Action)`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.EconomicSave`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerData.CareerData()`；输入表达式：`new CareerData { Day = data.Day, Market = data.Market, Credits = data.Credits,              Life = CoopJson.Copy(new CareerLifeState { Trading = data.Life.Trading, CreditFraction = data.Life.CreditFraction, Ledger = data.Life.Ledger }) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CareerData { Day = data.Day, Market = data.Market, Credits = data.Credits,              Life = CoopJson.Copy(new CareerLifeState { Trading = data.Life.Trading, CreditFraction = data.Life.CreditFraction, Ledger = data.Life.Ledger }) }`
- `NationalSpire.CareerLifeState.CareerLifeState()`；输入表达式：`new CareerLifeState { Trading = data.Life.Trading, CreditFraction = data.Life.CreditFraction, Ledger = data.Life.Ledger }`；返回值紧邻使用处：`ArgumentSyntax: new CareerLifeState { Trading = data.Life.Trading, CreditFraction = data.Life.CreditFraction, Ledger = data.Life.Ledger }`
- `NationalSpire.CareerMarket.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`；输入表达式：`CareerMarket.Trade(candidate, order)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerMarket.Trade(candidate, order) is { } error`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(new CareerLifeState { Trading = data.Life.Trading, CreditFraction = data.Life.CreditFraction, Ledger = data.Life.Ledger })`；返回值紧邻使用处：`AssignmentExpressionSyntax: Life = CoopJson.Copy(new CareerLifeState { Trading = data.Life.Trading, CreditFraction = data.Life.CreditFraction, Ledger = data.Life.Ledger })`
- `NationalSpire.EconomicActions.Persist(NationalSpire.CareerData, System.Action)`；输入表达式：`Persist(data, () => (data.Credits, data.Life.Trading, data.Life.CreditFraction, data.Life.Ledger) = before)`；返回值紧邻使用处：`ReturnStatementSyntax: return Persist(data, () => (data.Credits, data.Life.Trading, data.Life.CreditFraction, data.Life.Ledger) = before);`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.EconomicSave)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.EconomicSave)`

**赋值（含属性/字段和局部值）：**

- `(data.Credits, data.Life.Trading, data.Life.CreditFraction, data.Life.Ledger)` = `before`
- `CreditFraction` = `data.Life.CreditFraction`
- `Credits` = `data.Credits`
- `data.Credits` = `candidate.Credits`
- `data.Life.CreditFraction` = `candidate.Life.CreditFraction`
- `data.Life.Ledger` = `candidate.Life.Ledger`
- `data.Life.Trading` = `candidate.Life.Trading`
- `Day` = `data.Day`
- `Ledger` = `data.Life.Ledger`
- `Life` = `CoopJson.Copy(new CareerLifeState { Trading = data.Life.Trading, CreditFraction = data.Life.CreditFraction, Ledger = data.Life.Ledger })`
- `Market` = `data.Market`
- `Trading` = `data.Life.Trading`

<a id="symbol-d99b9fe32a07"></a>

## `NationalSpire.EconomicActions.Persist(NationalSpire.CareerData, System.Action) — private static string? Persist(CareerData data, Action revert)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>)`](EconomicActions.cs.md#symbol-6ec38e492fe6)；[`NationalSpire.EconomicActions.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`](EconomicActions.cs.md#symbol-f0516c3ecf95)

**调用：** [`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；`System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("economy.save", exception)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("economy.save", exception);`
- `System.Action.Invoke()`；输入表达式：`revert()`；返回值紧邻使用处：`ExpressionStatementSyntax: revert();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d4ca2504b704"></a>

## `NationalSpire.EconomicActions.Copy(NationalSpire.CareerData, NationalSpire.CareerData) — private static void Copy(CareerData from, CareerData to)`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>)`](EconomicActions.cs.md#symbol-6ec38e492fe6)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.CommunityMemories`；`NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Fans`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Posts`；`NationalSpire.CareerData.SavedThreads`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `to.CommunityMemories` = `from.CommunityMemories`
- `to.Credits` = `from.Credits`
- `to.Fans` = `from.Fans`
- `to.Life` = `from.Life`
- `to.Posts` = `from.Posts`
- `to.SavedThreads` = `from.SavedThreads`
