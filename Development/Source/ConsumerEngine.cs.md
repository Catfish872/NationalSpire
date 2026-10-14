# ConsumerEngine.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`3C27C59E2BC0D9AF75B7EE2585CB2A3198A1DF00B29935C463E5649A46F24E3A`。来源：[源码](../../ConsumerEngine.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.ConsumerEngine`。

字段、事件及初始值（源码原样）：

```csharp
public const int InviteFavourGate = 5;
```

<a id="symbol-e824ab276330"></a>

## `NationalSpire.ConsumerEngine.Uses(NationalSpire.CareerData, string) — public static int Uses(CareerData d, string id)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)；[`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?)`](ConsumerEngine.cs.md#symbol-6a13be5c34c1)；[`NationalSpire.ConsumerEngine.BuyError(NationalSpire.CareerData, NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-0e32f20201c1)

**调用：** `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.ConsumerState.PromoUsed`；`NationalSpire.ConsumerState.Season`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`d.Life.Consumer.PromoUsed.GetValueOrDefault(id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: d.Life.Consumer.Season == d.Season ? d.Life.Consumer.PromoUsed.GetValueOrDefault(id) : 0`

**赋值（含属性/字段和局部值）：**


<a id="symbol-723a34b6e2cb"></a>

## `NationalSpire.ConsumerEngine.Price(NationalSpire.Good) — public static int Price(Good good)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)；[`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)；[`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?)`](ConsumerEngine.cs.md#symbol-6a13be5c34c1)；[`NationalSpire.ConsumerEngine.BuyError(NationalSpire.CareerData, NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-0e32f20201c1)

**调用：** `System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerCatalog.Mass`；`NationalSpire.Good.Category`；`NationalSpire.Good.Id`；`NationalSpire.Good.Price`；`NationalSpire.Good.Tier`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Max(int, int)`；输入表达式：`Math.Max(10, good.Price / 5)`；返回值紧邻使用处：`ConditionalExpressionSyntax: good.Category == "数码" && good.Tier == ConsumerCatalog.Mass ? Math.Max(10, good.Price / 5)          : good.Id == "ebike" ? 6000 : good.Price`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0e32f20201c1"></a>

## `NationalSpire.ConsumerEngine.BuyError(NationalSpire.CareerData, NationalSpire.Good) — public static string? BuyError(CareerData d, Good good)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)；[`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?)`](ConsumerEngine.cs.md#symbol-6a13be5c34c1)

**调用：** [`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`](LifeData.cs.md#symbol-de5af63fa4e7)；[`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-723a34b6e2cb)；[`NationalSpire.ConsumerEngine.Uses(NationalSpire.CareerData, string)`](ConsumerEngine.cs.md#symbol-e824ab276330)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；`NationalSpire.ConsumerCatalog.PromoPerSeason`；`NationalSpire.ConsumerCatalog.RepeatCooldown`；`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；`NationalSpire.ConsumerEngine.Uses(NationalSpire.CareerData, string)`；`NationalSpire.ConsumerState.BoughtDay`；`NationalSpire.ConsumerState.Goods`；`NationalSpire.Good.Durable`；`NationalSpire.Good.Id`；`NationalSpire.Good.Promo`；`NationalSpire.Good.Repeatable`；`NationalSpire.OwnedGood.Id`；`NationalSpire.OwnedGood.Season`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；输入表达式：`CareerMoney.Balance(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerMoney.Balance(d) < Price(good) / 10m`
- `NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；输入表达式：`Price(good)`；返回值紧邻使用处：`BinaryExpressionSyntax: Price(good) / 10m`
- `NationalSpire.ConsumerEngine.Uses(NationalSpire.CareerData, string)`；输入表达式：`Uses(d, good.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: Uses(d, good.Id) >= ConsumerCatalog.PromoPerSeason`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`state.BoughtDay.TryGetValue(good.Id, out int day)`；返回值紧邻使用处：`BinaryExpressionSyntax: good.Repeatable && state.BoughtDay.TryGetValue(good.Id, out int day)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`state.Goods.Any(g => g.Id == good.Id && g.Season == d.Season)`；返回值紧邻使用处：`BinaryExpressionSyntax: !good.Repeatable && state.Goods.Any(g => g.Id == good.Id && g.Season == d.Season)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`state.Goods.Any(g => g.Id == good.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: good.Durable && state.Goods.Any(g => g.Id == good.Id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2aa34d35c1b8"></a>

## `NationalSpire.ConsumerEngine.CanInvite(NationalSpire.CareerData, string) — public static bool CanInvite(CareerData d, string id)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Fill(string)`](ConsumerScreen.cs.md#symbol-cd2c525731a6)；[`NationalSpire.ConsumerEngine.Guests(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, int)`](ConsumerEngine.cs.md#symbol-1d085530bebc)

**调用：** [`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；[`NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-13f25fec3dea)；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.HumanIds`；`NationalSpire.ConsumerEngine.InviteFavourGate`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(d, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: id != "player" && !d.HumanIds.Contains(id)          && PrivateMessages.CanChat(d, id)`
- `NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Favour(d, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateMessages.Favour(d, id) >= InviteFavourGate`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`d.HumanIds.Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.HumanIds.Contains(id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1d085530bebc"></a>

## `NationalSpire.ConsumerEngine.Guests(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, int) — private static string? Guests(CareerData d, IReadOnlyList<string> ids, int slots)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?)`](ConsumerEngine.cs.md#symbol-6a13be5c34c1)；[`NationalSpire.ConsumerEngine.Use(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>)`](ConsumerEngine.cs.md#symbol-c0beece783ab)

**调用：** [`NationalSpire.ConsumerEngine.CanInvite(NationalSpire.CareerData, string)`](ConsumerEngine.cs.md#symbol-2aa34d35c1b8)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerEngine.CanInvite(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerEngine.CanInvite(NationalSpire.CareerData, string)`；输入表达式：`CanInvite(d, id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CanInvite(d, id)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`ids.Any(id => !CanInvite(d, id))`；返回值紧邻使用处：`ConditionalExpressionSyntax: ids.Any(id => !CanInvite(d, id)) ? "邀请对象需要能够联系，且好感达到5。" : null`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`ids.Distinct().Count()`；返回值紧邻使用处：`BinaryExpressionSyntax: ids.Distinct().Count() != ids.Count`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`ids.Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ids.Distinct().Count`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f873e9cbaf82"></a>

## `NationalSpire.ConsumerEngine.Season(NationalSpire.CareerData) — private static void Season(CareerData d)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?)`](ConsumerEngine.cs.md#symbol-6a13be5c34c1)；[`NationalSpire.ConsumerEngine.Use(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>)`](ConsumerEngine.cs.md#symbol-c0beece783ab)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Collections.Generic.List<T>.Clear()`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.ConsumerState.Goods`；`NationalSpire.ConsumerState.InvitedThisSeason`；`NationalSpire.ConsumerState.PromoUsed`；`NationalSpire.ConsumerState.Season`；`NationalSpire.OwnedGood.Durable`；`NationalSpire.OwnedGood.Season`；`NationalSpire.OwnedGood.UsedSeason`；`NationalSpire.OwnedGood.UsedVerbs`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`s.InvitedThisSeason.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: s.InvitedThisSeason.Clear();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`s.PromoUsed.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: s.PromoUsed.Clear();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`good.UsedVerbs.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: good.UsedVerbs.Clear();`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`s.Goods.RemoveAll(g => !g.Durable && g.Season < d.Season - 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: s.Goods.RemoveAll(g => !g.Durable && g.Season < d.Season - 1);`

**赋值（含属性/字段和局部值）：**

- `good.UsedSeason` = `d.Season`
- `s.Season` = `d.Season`

<a id="symbol-6a13be5c34c1"></a>

## `NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?) — public static string? Buy(CareerData d, string id, IReadOnlyList<string>? invitees = null)`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerSubmit(NationalSpire.CareerData, NationalSpire.Good, string, System.Collections.Generic.List<string>)`](ConsumerScreen.cs.md#symbol-a26966f14e5c)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** [`NationalSpire.CareerAudience.PromotionGain(int, int, int)`](CareerAudience.cs.md#symbol-d4f18e34de92)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`](LifeData.cs.md#symbol-bcb55555a432)；[`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`](LifeData.cs.md#symbol-54a09649188b)；[`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；[`NationalSpire.ConsumerEngine.BuyError(NationalSpire.CareerData, NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-0e32f20201c1)；[`NationalSpire.ConsumerEngine.Guests(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, int)`](ConsumerEngine.cs.md#symbol-1d085530bebc)；[`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-723a34b6e2cb)；[`NationalSpire.ConsumerEngine.Season(NationalSpire.CareerData)`](ConsumerEngine.cs.md#symbol-f873e9cbaf82)；[`NationalSpire.ConsumerEngine.Uses(NationalSpire.CareerData, string)`](ConsumerEngine.cs.md#symbol-e824ab276330)；[`NationalSpire.ConsumerEvents.Purchase(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>)`](ConsumerEvents.cs.md#symbol-046119a7c75d)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`NationalSpire.OwnedGood.OwnedGood()`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAudience.PromotionGain(int, int, int)`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Fans`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`；`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；`NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.ConsumerEngine.BuyError(NationalSpire.CareerData, NationalSpire.Good)`；`NationalSpire.ConsumerEngine.Guests(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, int)`；`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；`NationalSpire.ConsumerEngine.Season(NationalSpire.CareerData)`；`NationalSpire.ConsumerEngine.Uses(NationalSpire.CareerData, string)`；`NationalSpire.ConsumerEvents.Purchase(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>)`；`NationalSpire.ConsumerState.BoughtDay`；`NationalSpire.ConsumerState.Goods`；`NationalSpire.ConsumerState.LifetimeSpent`；`NationalSpire.ConsumerState.PromoUsed`；`NationalSpire.ConsumerState.PurchaseCount`；`NationalSpire.Good.Durable`；`NationalSpire.Good.Name`；`NationalSpire.Good.Promo`；`NationalSpire.Good.Slots`；`NationalSpire.OwnedGood.BoughtDay`；`NationalSpire.OwnedGood.Consumed`；`NationalSpire.OwnedGood.Durable`；`NationalSpire.OwnedGood.Id`；`NationalSpire.OwnedGood.Name`；`NationalSpire.OwnedGood.Price`；`NationalSpire.OwnedGood.Season`；`NationalSpire.OwnedGood.UsedSeason`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.ConsumerOperation`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerAudience.PromotionGain(int, int, int)`；输入表达式：`CareerAudience.PromotionGain(d.Fans, Price(good), Uses(d, id))`；返回值紧邻使用处：`ConditionalExpressionSyntax: good.Promo ? CareerAudience.PromotionGain(d.Fans, Price(good), Uses(d, id)) : 0`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, g)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => CareerEngine.DisplayName(d, g)`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.Name(d)}`
- `NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`；输入表达式：`CareerMoney.Add(d, -cost)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Add(d, -cost);`
- `NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；输入表达式：`CareerMoney.Record(d, good.Name, -cost)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Record(d, good.Name, -cost);`
- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ConsumerCatalog.Get(id)`
- `NationalSpire.ConsumerEngine.BuyError(NationalSpire.CareerData, NationalSpire.Good)`；输入表达式：`BuyError(d, good)`；返回值紧邻使用处：`IsPatternExpressionSyntax: BuyError(d, good) is { } error`
- `NationalSpire.ConsumerEngine.Guests(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, int)`；输入表达式：`Guests(d, guests, good.Slots)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Guests(d, guests, good.Slots) is { } invalid`
- `NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；输入表达式：`Price(good)`；返回值紧邻使用处：`ArgumentSyntax: Price(good)`
- `NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；输入表达式：`Price(good)`；返回值紧邻使用处：`BinaryExpressionSyntax: Price(good) / 10m`
- `NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；输入表达式：`Price(good)`；返回值紧邻使用处：`InterpolationSyntax: {Price(good):N0}`
- `NationalSpire.ConsumerEngine.Season(NationalSpire.CareerData)`；输入表达式：`Season(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: Season(d);`
- `NationalSpire.ConsumerEngine.Uses(NationalSpire.CareerData, string)`；输入表达式：`Uses(d, id)`；返回值紧邻使用处：`ArgumentSyntax: Uses(d, id)`
- `NationalSpire.ConsumerEngine.Uses(NationalSpire.CareerData, string)`；输入表达式：`Uses(d, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: Uses(d, id) + 1`
- `NationalSpire.ConsumerEvents.Purchase(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>)`；输入表达式：`ConsumerEvents.Purchase(d, body, guests)`；返回值紧邻使用处：`ExpressionStatementSyntax: ConsumerEvents.Purchase(d, body, guests);`
- `NationalSpire.OwnedGood.OwnedGood()`；输入表达式：`new() { Id = id, Name = good.Name, BoughtDay = d.Day, Season = d.Season, Price = (int)cost, Durable = good.Durable, Consumed = !good.Durable, UsedSeason = d.Season }`；返回值紧邻使用处：`ArgumentSyntax: new() { Id = id, Name = good.Name, BoughtDay = d.Day, Season = d.Season, Price = (int)cost, Durable = good.Durable, Consumed = !good.Durable, UsedSeason = d.Season }`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.ConsumerOperation)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.ConsumerOperation)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", guests.Select(g => CareerEngine.DisplayName(d, g)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = string.Join("、", guests.Select(g => CareerEngine.DisplayName(d, g)))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`guests.Select(g => CareerEngine.DisplayName(d, g))`；返回值紧邻使用处：`ArgumentSyntax: guests.Select(g => CareerEngine.DisplayName(d, g))`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`s.Goods.Add(new() { Id = id, Name = good.Name, BoughtDay = d.Day, Season = d.Season, Price = (int)cost, Durable = good.Durable, Consumed = !good.Durable, UsedSeason = d.Season })`；返回值紧邻使用处：`ExpressionStatementSyntax: s.Goods.Add(new() { Id = id, Name = good.Name, BoughtDay = d.Day, Season = d.Season, Price = (int)cost, Durable = good.Durable, Consumed = !good.Durable, UsedSeason = d.Season });`

**赋值（含属性/字段和局部值）：**

- `BoughtDay` = `d.Day`
- `Consumed` = `!good.Durable`
- `d.Fans` += `fans`
- `Durable` = `good.Durable`
- `Id` = `id`
- `Name` = `good.Name`
- `Price` = `(int)cost`
- `s.BoughtDay[id]` = `d.Day`
- `s.LifetimeSpent` += `(long)cost`
- `s.PromoUsed[id]` = `Uses(d, id) + 1`
- `Season` = `d.Season`
- `UsedSeason` = `d.Season`

<a id="symbol-a4327d304bf8"></a>

## `NationalSpire.ConsumerEngine.HospitalityFee(NationalSpire.Good) — public static int HospitalityFee(Good good)`

来源：源码第 56 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)；[`NationalSpire.ConsumerEngine.Use(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>)`](ConsumerEngine.cs.md#symbol-c0beece783ab)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerCatalog.Luxury`；`NationalSpire.ConsumerCatalog.Rich`；`NationalSpire.Good.Tier`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c0beece783ab"></a>

## `NationalSpire.ConsumerEngine.Use(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>) — public static string? Use(CareerData d, string goodId, string verbId, IReadOnlyList<string> guests)`

来源：源码第 57 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerSubmit(NationalSpire.CareerData, NationalSpire.Good, string, System.Collections.Generic.List<string>)`](ConsumerScreen.cs.md#symbol-a26966f14e5c)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** [`NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`](LifeData.cs.md#symbol-bcb55555a432)；[`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`](LifeData.cs.md#symbol-de5af63fa4e7)；[`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`](LifeData.cs.md#symbol-54a09649188b)；[`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；[`NationalSpire.ConsumerEngine.Guests(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, int)`](ConsumerEngine.cs.md#symbol-1d085530bebc)；[`NationalSpire.ConsumerEngine.HospitalityFee(NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-a4327d304bf8)；[`NationalSpire.ConsumerEngine.Season(NationalSpire.CareerData)`](ConsumerEngine.cs.md#symbol-f873e9cbaf82)；[`NationalSpire.ConsumerEvents.Activity(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.GoodVerb, System.Collections.Generic.IReadOnlyList<string>)`](ConsumerEvents.cs.md#symbol-49f04620b21e)；[`NationalSpire.PrivateMessages.ChangeFavour(NationalSpire.CareerData, string, int)`](PrivateMessages.cs.md#symbol-c703192e56c0)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`；`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；`NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.ConsumerEngine.Guests(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, int)`；`NationalSpire.ConsumerEngine.HospitalityFee(NationalSpire.Good)`；`NationalSpire.ConsumerEngine.Season(NationalSpire.CareerData)`；`NationalSpire.ConsumerEvents.Activity(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.GoodVerb, System.Collections.Generic.IReadOnlyList<string>)`；`NationalSpire.ConsumerState.Goods`；`NationalSpire.ConsumerState.InvitedThisSeason`；`NationalSpire.ConsumerState.PartyCount`；`NationalSpire.Good.Verbs`；`NationalSpire.GoodVerb.Favor`；`NationalSpire.GoodVerb.Id`；`NationalSpire.GoodVerb.Name`；`NationalSpire.GoodVerb.Slots`；`NationalSpire.OwnedGood.Durable`；`NationalSpire.OwnedGood.Id`；`NationalSpire.OwnedGood.UsedSeason`；`NationalSpire.OwnedGood.UsedVerbs`；`NationalSpire.PrivateMessages.ChangeFavour(NationalSpire.CareerData, string, int)`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.ConsumerOperation`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`；输入表达式：`CareerMoney.Add(d, -cost)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Add(d, -cost);`
- `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；输入表达式：`CareerMoney.Balance(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerMoney.Balance(d) < cost`
- `NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；输入表达式：`CareerMoney.Record(d, verb.Name + "招待费", -cost)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Record(d, verb.Name + "招待费", -cost);`
- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(goodId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ConsumerCatalog.Get(goodId)`
- `NationalSpire.ConsumerEngine.Guests(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, int)`；输入表达式：`Guests(d, guests, verb.Slots)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Guests(d, guests, verb.Slots) is { } error`
- `NationalSpire.ConsumerEngine.HospitalityFee(NationalSpire.Good)`；输入表达式：`HospitalityFee(good)`；返回值紧邻使用处：`BinaryExpressionSyntax: HospitalityFee(good) / 10m`
- `NationalSpire.ConsumerEngine.Season(NationalSpire.CareerData)`；输入表达式：`Season(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: Season(d);`
- `NationalSpire.ConsumerEvents.Activity(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.GoodVerb, System.Collections.Generic.IReadOnlyList<string>)`；输入表达式：`ConsumerEvents.Activity(d, good, verb, guests)`；返回值紧邻使用处：`ExpressionStatementSyntax: ConsumerEvents.Activity(d, good, verb, guests);`
- `NationalSpire.PrivateMessages.ChangeFavour(NationalSpire.CareerData, string, int)`；输入表达式：`PrivateMessages.ChangeFavour(d, id, count == 0 ? verb.Favor : 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateMessages.ChangeFavour(d, id, count == 0 ? verb.Favor : 1);`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.ConsumerOperation)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.ConsumerOperation)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Verbs.FirstOrDefault(v => v.Id == verbId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: good?.Verbs.FirstOrDefault(v => v.Id == verbId)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`s.Goods.FirstOrDefault(g => g.Id == goodId && g.Durable)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = s.Goods.FirstOrDefault(g => g.Id == goodId && g.Durable)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`s.InvitedThisSeason.GetValueOrDefault(id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = s.InvitedThisSeason.GetValueOrDefault(id)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`owned.UsedVerbs.Add(verbId)`；返回值紧邻使用处：`ExpressionStatementSyntax: owned.UsedVerbs.Add(verbId);`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`owned.UsedVerbs.Contains(verbId)`；返回值紧邻使用处：`BinaryExpressionSyntax: owned.UsedSeason == d.Season && owned.UsedVerbs.Contains(verbId)`

**赋值（含属性/字段和局部值）：**

- `owned.UsedSeason` = `d.Season`
- `s.InvitedThisSeason[id]` = `count + 1`
