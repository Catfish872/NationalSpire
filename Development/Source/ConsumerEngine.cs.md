# ConsumerEngine.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`BEB176F716370ADCD4AA9345F81CF513E28BDFCB1000F6033656F388420C94F1`。来源：[源码](../../ConsumerEngine.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.ConsumerEngine`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-268b12fc6723"></a>

## `NationalSpire.ConsumerEngine.Ensure(NationalSpire.CareerData) — public static void Ensure(CareerData d)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Ensure(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-eb417e39aebf)；[`NationalSpire.ConsumerAttachments.Prepare(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer)`](ConsumerAttachments.cs.md#symbol-bb17fc71b2da)；[`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?, int)`](ConsumerEngine.cs.md#symbol-af8f54536df7)

**调用：** [`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；[`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-723a34b6e2cb)；`NationalSpire.OwnedGood.OwnedGood()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；`NationalSpire.ConsumerState.BoughtDay`；`NationalSpire.ConsumerState.Goods`；`NationalSpire.ConsumerState.InventoryVersion`；`NationalSpire.Good.Collectible`；`NationalSpire.Good.Durable`；`NationalSpire.Good.Id`；`NationalSpire.Good.Name`；`NationalSpire.OwnedGood.BoughtDay`；`NationalSpire.OwnedGood.Consumed`；`NationalSpire.OwnedGood.Durable`；`NationalSpire.OwnedGood.Id`；`NationalSpire.OwnedGood.Name`；`NationalSpire.OwnedGood.Price`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(g.Id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: ConsumerCatalog.Get(g.Id)?.Collectible`
- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(p.Key)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: ConsumerCatalog.Get(p.Key)?.Collectible`
- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(purchase.Key)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: ConsumerCatalog.Get(purchase.Key)!`
- `NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；输入表达式：`Price(good)`；返回值紧邻使用处：`BinaryExpressionSyntax: Price(good) / 10`
- `NationalSpire.OwnedGood.OwnedGood()`；输入表达式：`new() { Id = good.Id, Name = good.Name, BoughtDay = purchase.Value, Durable = good.Durable, Price = Price(good) / 10 }`；返回值紧邻使用处：`ArgumentSyntax: new() { Id = good.Id, Name = good.Name, BoughtDay = purchase.Value, Durable = good.Durable, Price = Price(good) / 10 }`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`s.Goods.Any(g => g.Id == p.Key)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !s.Goods.Any(g => g.Id == p.Key)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`s.BoughtDay.Where(p => ConsumerCatalog.Get(p.Key)?.Collectible == true && !s.Goods.Any(g => g.Id == p.Key))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var purchase in s.BoughtDay.Where(p => ConsumerCatalog.Get(p.Key)?.Collectible == true && !s.Goods.Any(g => g.Id == p.Key)))          {              var good = ConsumerCatalog.Get(purchase.Key)!;              s.Goods.Add(new() { Id = good.Id, Name = good.Name, BoughtDay = purchase.Value, Durable = good.Durable, Price = Price(good) / 10 });          }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`s.Goods.Where(g => ConsumerCatalog.Get(g.Id)?.Collectible == true)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var good in s.Goods.Where(g => ConsumerCatalog.Get(g.Id)?.Collectible == true)) good.Consumed = false;`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`s.Goods.Add(new() { Id = good.Id, Name = good.Name, BoughtDay = purchase.Value, Durable = good.Durable, Price = Price(good) / 10 })`；返回值紧邻使用处：`ExpressionStatementSyntax: s.Goods.Add(new() { Id = good.Id, Name = good.Name, BoughtDay = purchase.Value, Durable = good.Durable, Price = Price(good) / 10 });`

**赋值（含属性/字段和局部值）：**

- `BoughtDay` = `purchase.Value`
- `Durable` = `good.Durable`
- `good.Consumed` = `false`
- `Id` = `good.Id`
- `Name` = `good.Name`
- `Price` = `Price(good) / 10`
- `s.InventoryVersion` = `1`

<a id="symbol-e824ab276330"></a>

## `NationalSpire.ConsumerEngine.Uses(NationalSpire.CareerData, string) — public static long Uses(CareerData d, string id)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)；[`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?, int)`](ConsumerEngine.cs.md#symbol-af8f54536df7)；[`NationalSpire.ConsumerEngine.RemainingPurchases(NationalSpire.CareerData, NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-09b4e1679d14)

**调用：** `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.ConsumerState.PromoUsed`；`NationalSpire.ConsumerState.Season`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`d.Life.Consumer.PromoUsed.GetValueOrDefault(id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: d.Life.Consumer.Season == d.Season ? d.Life.Consumer.PromoUsed.GetValueOrDefault(id) : 0`

**赋值（含属性/字段和局部值）：**


<a id="symbol-09b4e1679d14"></a>

## `NationalSpire.ConsumerEngine.RemainingPurchases(NationalSpire.CareerData, NationalSpire.Good) — public static int RemainingPurchases(CareerData d, Good good)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)；[`NationalSpire.ConsumerEngine.BuyError(NationalSpire.CareerData, NationalSpire.Good, int)`](ConsumerEngine.cs.md#symbol-9a6a5bbc9c38)

**调用：** [`NationalSpire.ConsumerEngine.Uses(NationalSpire.CareerData, string)`](ConsumerEngine.cs.md#symbol-e824ab276330)；`System.Math.Max(long, long)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerCatalog.PromoPerSeason`；`NationalSpire.ConsumerEngine.Uses(NationalSpire.CareerData, string)`；`NationalSpire.Good.Id`；`NationalSpire.Good.Promo`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerEngine.Uses(NationalSpire.CareerData, string)`；输入表达式：`Uses(d, good.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: ConsumerCatalog.PromoPerSeason - Uses(d, good.Id)`
- `System.Math.Max(long, long)`；输入表达式：`Math.Max(0, ConsumerCatalog.PromoPerSeason - Uses(d, good.Id))`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Max(0, ConsumerCatalog.PromoPerSeason - Uses(d, good.Id))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-723a34b6e2cb"></a>

## `NationalSpire.ConsumerEngine.Price(NationalSpire.Good) — public static int Price(Good good)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerAttachmentConfirmation(NationalSpire.ConsumerComposer, NationalSpire.PrivateOffer, System.Action?)`](ConsumerCommerceScreen.cs.md#symbol-f3a03a858f88)；[`NationalSpire.CareerScreen.ConsumerConfirmPurchase(NationalSpire.CareerData, NationalSpire.Good, int)`](ConsumerCommerceScreen.cs.md#symbol-deb0704ef9e4)；[`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)；[`NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`](ConsumerPickerScreen.cs.md#symbol-0f5d28176960)；[`NationalSpire.CareerScreen.ConsumerProducts(Godot.VBoxContainer, NationalSpire.CareerScreen.ConsumerChoice[], NationalSpire.CareerScreen.ConsumerEdit, System.Action)`](ConsumerPickerScreen.cs.md#symbol-e5ebf63e6d3e)；[`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)；[`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?, int)`](ConsumerEngine.cs.md#symbol-af8f54536df7)；[`NationalSpire.ConsumerEngine.BuyError(NationalSpire.CareerData, NationalSpire.Good, int)`](ConsumerEngine.cs.md#symbol-9a6a5bbc9c38)；[`NationalSpire.ConsumerEngine.ChangeInventory(NationalSpire.CareerData, NationalSpire.Good, long)`](ConsumerEngine.cs.md#symbol-57cd1c96aca4)；[`NationalSpire.ConsumerEngine.Ensure(NationalSpire.CareerData)`](ConsumerEngine.cs.md#symbol-268b12fc6723)；[`NationalSpire.RandomEventPrompts.Materials(NationalSpire.CareerData, NationalSpire.RandomEventRecord)`](RandomEventPrompts.cs.md#symbol-a96ac205ab9d)

**调用：** `System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerCatalog.Mass`；`NationalSpire.Good.Category`；`NationalSpire.Good.Id`；`NationalSpire.Good.Price`；`NationalSpire.Good.Tier`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Max(int, int)`；输入表达式：`Math.Max(10, good.Price / 5)`；返回值紧邻使用处：`ConditionalExpressionSyntax: good.Category == "数码" && good.Tier == ConsumerCatalog.Mass ? Math.Max(10, good.Price / 5)          : good.Id == "ebike" ? 6000 : good.Price`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9a6a5bbc9c38"></a>

## `NationalSpire.ConsumerEngine.BuyError(NationalSpire.CareerData, NationalSpire.Good, int) — public static string? BuyError(CareerData d, Good good, int quantity = 1)`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)；[`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?, int)`](ConsumerEngine.cs.md#symbol-af8f54536df7)

**调用：** [`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`](LifeData.cs.md#symbol-de5af63fa4e7)；[`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-723a34b6e2cb)；[`NationalSpire.ConsumerEngine.RemainingPurchases(NationalSpire.CareerData, NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-09b4e1679d14)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；`NationalSpire.ConsumerCatalog.PromoPerSeason`；`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；`NationalSpire.ConsumerEngine.RemainingPurchases(NationalSpire.CareerData, NationalSpire.Good)`；`NationalSpire.Good.Promo`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；输入表达式：`CareerMoney.Balance(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerMoney.Balance(d) < Price(good) / 10m * quantity`
- `NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；输入表达式：`Price(good)`；返回值紧邻使用处：`BinaryExpressionSyntax: Price(good) / 10m`
- `NationalSpire.ConsumerEngine.RemainingPurchases(NationalSpire.CareerData, NationalSpire.Good)`；输入表达式：`RemainingPurchases(d, good)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RemainingPurchases(d, good)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2aa34d35c1b8"></a>

## `NationalSpire.ConsumerEngine.CanInvite(NationalSpire.CareerData, string) — public static bool CanInvite(CareerData d, string id)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerEngine.Guests(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, int)`](ConsumerEngine.cs.md#symbol-1d085530bebc)

**调用：** [`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.HumanIds`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(d, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: id != "player" && !d.HumanIds.Contains(id)          && PrivateMessages.CanChat(d, id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`d.HumanIds.Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.HumanIds.Contains(id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1d085530bebc"></a>

## `NationalSpire.ConsumerEngine.Guests(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, int) — public static string? Guests(CareerData d, IReadOnlyList<string> ids, int slots)`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerAttachments.Attend(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool)`](ConsumerAttachments.cs.md#symbol-c0f0a7c39a70)；[`NationalSpire.ConsumerAttachments.Prepare(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer)`](ConsumerAttachments.cs.md#symbol-bb17fc71b2da)；[`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?, int)`](ConsumerEngine.cs.md#symbol-af8f54536df7)；[`NationalSpire.ConsumerEngine.Use(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool)`](ConsumerEngine.cs.md#symbol-2d5bf22bd5bc)

**调用：** [`NationalSpire.ConsumerEngine.CanInvite(NationalSpire.CareerData, string)`](ConsumerEngine.cs.md#symbol-2aa34d35c1b8)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerEngine.CanInvite(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerEngine.CanInvite(NationalSpire.CareerData, string)`；输入表达式：`CanInvite(d, id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CanInvite(d, id)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`ids.Any(id => !CanInvite(d, id))`；返回值紧邻使用处：`ConditionalExpressionSyntax: ids.Any(id => !CanInvite(d, id)) ? "请选择能够联系的邀请对象。" : null`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`ids.Distinct().Count()`；返回值紧邻使用处：`BinaryExpressionSyntax: ids.Distinct().Count() != ids.Count`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`ids.Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ids.Distinct().Count`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f873e9cbaf82"></a>

## `NationalSpire.ConsumerEngine.Season(NationalSpire.CareerData) — internal static void Season(CareerData d)`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerAttachments.Attend(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool)`](ConsumerAttachments.cs.md#symbol-c0f0a7c39a70)；[`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?, int)`](ConsumerEngine.cs.md#symbol-af8f54536df7)；[`NationalSpire.ConsumerEngine.Use(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool)`](ConsumerEngine.cs.md#symbol-2d5bf22bd5bc)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Collections.Generic.List<T>.Clear()`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.ConsumerState.Goods`；`NationalSpire.ConsumerState.InvitedThisSeason`；`NationalSpire.ConsumerState.PromoUsed`；`NationalSpire.ConsumerState.Season`；`NationalSpire.OwnedGood.Consumed`；`NationalSpire.OwnedGood.Season`；`NationalSpire.OwnedGood.UsedSeason`；`NationalSpire.OwnedGood.UsedVerbs`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`s.InvitedThisSeason.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: s.InvitedThisSeason.Clear();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`s.PromoUsed.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: s.PromoUsed.Clear();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`good.UsedVerbs.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: good.UsedVerbs.Clear();`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`s.Goods.RemoveAll(g => g.Consumed && g.Season < d.Season - 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: s.Goods.RemoveAll(g => g.Consumed && g.Season < d.Season - 1);`

**赋值（含属性/字段和局部值）：**

- `good.UsedSeason` = `d.Season`
- `s.Season` = `d.Season`

<a id="symbol-af8f54536df7"></a>

## `NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?, int) — public static string? Buy(CareerData d, string id, IReadOnlyList<string>? invitees = null, int quantity = 1)`

来源：源码第 47 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerSubmit(NationalSpire.CareerData, NationalSpire.Good, string, System.Collections.Generic.List<string>, int)`](ConsumerScreen.cs.md#symbol-f212593005f6)；[`NationalSpire.ConsumerAttachments.Prepare(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer)`](ConsumerAttachments.cs.md#symbol-bb17fc71b2da)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`](LifeData.cs.md#symbol-bcb55555a432)；[`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`](LifeData.cs.md#symbol-54a09649188b)；[`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；[`NationalSpire.ConsumerEngine.BuyError(NationalSpire.CareerData, NationalSpire.Good, int)`](ConsumerEngine.cs.md#symbol-9a6a5bbc9c38)；[`NationalSpire.ConsumerEngine.ChangeInventory(NationalSpire.CareerData, NationalSpire.Good, long)`](ConsumerEngine.cs.md#symbol-57cd1c96aca4)；[`NationalSpire.ConsumerEngine.Ensure(NationalSpire.CareerData)`](ConsumerEngine.cs.md#symbol-268b12fc6723)；[`NationalSpire.ConsumerEngine.Guests(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, int)`](ConsumerEngine.cs.md#symbol-1d085530bebc)；[`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-723a34b6e2cb)；[`NationalSpire.ConsumerEngine.PromotionGain(int, long, int)`](ConsumerEngine.cs.md#symbol-57e00990f59c)；[`NationalSpire.ConsumerEngine.Season(NationalSpire.CareerData)`](ConsumerEngine.cs.md#symbol-f873e9cbaf82)；[`NationalSpire.ConsumerEngine.Uses(NationalSpire.CareerData, string)`](ConsumerEngine.cs.md#symbol-e824ab276330)；[`NationalSpire.ConsumerEvents.Purchase(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>)`](ConsumerEvents.cs.md#symbol-046119a7c75d)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Fans`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`；`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；`NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.ConsumerEngine.BuyError(NationalSpire.CareerData, NationalSpire.Good, int)`；`NationalSpire.ConsumerEngine.ChangeInventory(NationalSpire.CareerData, NationalSpire.Good, long)`；`NationalSpire.ConsumerEngine.Ensure(NationalSpire.CareerData)`；`NationalSpire.ConsumerEngine.Guests(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, int)`；`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；`NationalSpire.ConsumerEngine.PromotionGain(int, long, int)`；`NationalSpire.ConsumerEngine.Season(NationalSpire.CareerData)`；`NationalSpire.ConsumerEngine.Uses(NationalSpire.CareerData, string)`；`NationalSpire.ConsumerEvents.Purchase(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>)`；`NationalSpire.ConsumerState.BoughtDay`；`NationalSpire.ConsumerState.LifetimeSpent`；`NationalSpire.ConsumerState.PromoUsed`；`NationalSpire.ConsumerState.PurchaseCount`；`NationalSpire.Good.Collectible`；`NationalSpire.Good.Name`；`NationalSpire.Good.Promo`；`NationalSpire.Good.Slots`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.ConsumerOperation`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, g)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => CareerEngine.DisplayName(d, g)`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.Name(d)}`
- `NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`；输入表达式：`CareerMoney.Add(d, -cost)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Add(d, -cost);`
- `NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；输入表达式：`CareerMoney.Record(d, good.Name, -cost)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Record(d, good.Name, -cost);`
- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ConsumerCatalog.Get(id)`
- `NationalSpire.ConsumerEngine.BuyError(NationalSpire.CareerData, NationalSpire.Good, int)`；输入表达式：`BuyError(d, good, quantity)`；返回值紧邻使用处：`IsPatternExpressionSyntax: BuyError(d, good, quantity) is { } error`
- `NationalSpire.ConsumerEngine.ChangeInventory(NationalSpire.CareerData, NationalSpire.Good, long)`；输入表达式：`ChangeInventory(d, good, quantity)`；返回值紧邻使用处：`ExpressionStatementSyntax: ChangeInventory(d, good, quantity);`
- `NationalSpire.ConsumerEngine.Ensure(NationalSpire.CareerData)`；输入表达式：`Ensure(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: Ensure(d);`
- `NationalSpire.ConsumerEngine.Guests(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, int)`；输入表达式：`Guests(d, guests, good.Slots)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Guests(d, guests, good.Slots) is { } invalid`
- `NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；输入表达式：`Price(good)`；返回值紧邻使用处：`ArgumentSyntax: Price(good)`
- `NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；输入表达式：`Price(good)`；返回值紧邻使用处：`BinaryExpressionSyntax: Price(good) / 10m`
- `NationalSpire.ConsumerEngine.PromotionGain(int, long, int)`；输入表达式：`PromotionGain(Price(good), Uses(d, id), quantity)`；返回值紧邻使用处：`AssignmentExpressionSyntax: fans = PromotionGain(Price(good), Uses(d, id), quantity)`
- `NationalSpire.ConsumerEngine.Season(NationalSpire.CareerData)`；输入表达式：`Season(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: Season(d);`
- `NationalSpire.ConsumerEngine.Uses(NationalSpire.CareerData, string)`；输入表达式：`Uses(d, id)`；返回值紧邻使用处：`ArgumentSyntax: Uses(d, id)`
- `NationalSpire.ConsumerEngine.Uses(NationalSpire.CareerData, string)`；输入表达式：`Uses(d, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: Uses(d, id) + quantity`
- `NationalSpire.ConsumerEvents.Purchase(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>)`；输入表达式：`ConsumerEvents.Purchase(d, body, guests)`；返回值紧邻使用处：`ExpressionStatementSyntax: ConsumerEvents.Purchase(d, body, guests);`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.ConsumerOperation)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.ConsumerOperation)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", guests.Select(g => CareerEngine.DisplayName(d, g)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = string.Join("、", guests.Select(g => CareerEngine.DisplayName(d, g)))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`guests.Select(g => CareerEngine.DisplayName(d, g))`；返回值紧邻使用处：`ArgumentSyntax: guests.Select(g => CareerEngine.DisplayName(d, g))`

**赋值（含属性/字段和局部值）：**

- `d.Fans` += `fans`
- `fans` = `PromotionGain(Price(good), Uses(d, id), quantity)`
- `s.BoughtDay[id]` = `d.Day`
- `s.LifetimeSpent` += `cost`
- `s.PromoUsed[id]` = `Uses(d, id) + quantity`
- `s.PurchaseCount` += `quantity`

<a id="symbol-a4327d304bf8"></a>

## `NationalSpire.ConsumerEngine.HospitalityFee(NationalSpire.Good) — public static int HospitalityFee(Good good)`

来源：源码第 74 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerAttachmentConfirmation(NationalSpire.ConsumerComposer, NationalSpire.PrivateOffer, System.Action?)`](ConsumerCommerceScreen.cs.md#symbol-f3a03a858f88)；[`NationalSpire.ConsumerEngine.Use(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool)`](ConsumerEngine.cs.md#symbol-2d5bf22bd5bc)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerCatalog.Luxury`；`NationalSpire.ConsumerCatalog.Rich`；`NationalSpire.Good.Tier`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-57cd1c96aca4"></a>

## `NationalSpire.ConsumerEngine.ChangeInventory(NationalSpire.CareerData, NationalSpire.Good, long) — public static void ChangeInventory(CareerData d, Good good, long quantity)`

来源：源码第 75 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?, int)`](ConsumerEngine.cs.md#symbol-af8f54536df7)；[`NationalSpire.RandomEventEffects.Apply(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-886f350e91dc)

**调用：** [`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-723a34b6e2cb)；`NationalSpire.OwnedGood.OwnedGood()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Remove(T)`；`System.Math.Min(long, long)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；`NationalSpire.ConsumerState.Goods`；`NationalSpire.Good.Durable`；`NationalSpire.Good.Id`；`NationalSpire.Good.Name`；`NationalSpire.OwnedGood.BoughtDay`；`NationalSpire.OwnedGood.Consumed`；`NationalSpire.OwnedGood.Durable`；`NationalSpire.OwnedGood.Id`；`NationalSpire.OwnedGood.Name`；`NationalSpire.OwnedGood.Price`；`NationalSpire.OwnedGood.Quantity`；`NationalSpire.OwnedGood.Season`；`NationalSpire.OwnedGood.UsedSeason`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；输入表达式：`Price(good)`；返回值紧邻使用处：`BinaryExpressionSyntax: Price(good) / 10`
- `NationalSpire.OwnedGood.OwnedGood()`；输入表达式：`new() { Id = good.Id, Name = good.Name, Quantity = quantity, BoughtDay = d.Day, Season = d.Season, Price = Price(good) / 10, Durable = good.Durable, UsedSeason = d.Season }`；返回值紧邻使用处：`ArgumentSyntax: new() { Id = good.Id, Name = good.Name, Quantity = quantity, BoughtDay = d.Day, Season = d.Season, Price = Price(good) / 10, Durable = good.Durable, UsedSeason = d.Season }`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Consumer.Goods.FirstOrDefault(g => g.Id == good.Id && !g.Consumed)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Life.Consumer.Goods.FirstOrDefault(g => g.Id == good.Id && !g.Consumed)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`d.Life.Consumer.Goods.Where(g => g.Id == good.Id && !g.Consumed).ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var stack in d.Life.Consumer.Goods.Where(g => g.Id == good.Id && !g.Consumed).ToArray())              {                  long used = Math.Min(stack.Quantity, -quantity); stack.Quantity -= used; quantity += used;                  if (stack.Quantity == 0) d.Life.Consumer.Goods.Remove(stack);                  if (quantity == 0) break;              }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Consumer.Goods.Where(g => g.Id == good.Id && !g.Consumed)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Consumer.Goods.Where(g => g.Id == good.Id && !g.Consumed).ToArray`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Life.Consumer.Goods.Add(new() { Id = good.Id, Name = good.Name, Quantity = quantity, BoughtDay = d.Day, Season = d.Season, Price = Price(good) / 10, Durable = good.Durable, UsedSeason = d.Season })`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Life.Consumer.Goods.Add(new() { Id = good.Id, Name = good.Name, Quantity = quantity, BoughtDay = d.Day, Season = d.Season, Price = Price(good) / 10, Durable = good.Durable, UsedSeason = d.Season });`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`d.Life.Consumer.Goods.Remove(owned)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Life.Consumer.Goods.Remove(owned);`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`d.Life.Consumer.Goods.Remove(stack)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Life.Consumer.Goods.Remove(stack);`
- `System.Math.Min(long, long)`；输入表达式：`Math.Min(stack.Quantity, -quantity)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(stack.Quantity, -quantity)`

**赋值（含属性/字段和局部值）：**

- `BoughtDay` = `d.Day`
- `Durable` = `good.Durable`
- `Id` = `good.Id`
- `Name` = `good.Name`
- `owned.Quantity` += `quantity`
- `Price` = `Price(good) / 10`
- `quantity` += `used`
- `Quantity` = `quantity`
- `Season` = `d.Season`
- `stack.Quantity` -= `used`
- `UsedSeason` = `d.Season`

<a id="symbol-57e00990f59c"></a>

## `NationalSpire.ConsumerEngine.PromotionGain(int, long, int) — public static int PromotionGain(int price, long used, int quantity)`

来源：源码第 91 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?, int)`](ConsumerEngine.cs.md#symbol-af8f54536df7)

**调用：** `System.Math.Min(long, long)`；`System.Math.Round(double)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Min(long, long)`；输入表达式：`Math.Min(end, boundary)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(end, boundary)`
- `System.Math.Round(double)`；输入表达式：`Math.Round(price / (double)denominator)`；返回值紧邻使用处：`CastExpressionSyntax: (long)Math.Round(price / (double)denominator)`

**赋值（含属性/字段和局部值）：**

- `denominator` = `last + 1`
- `result` += `gain * (last - denominator + 1)`

<a id="symbol-2d5bf22bd5bc"></a>

## `NationalSpire.ConsumerEngine.Use(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool) — public static string? Use(CareerData d, string goodId, string verbId, IReadOnlyList<string> guests, bool publicly = true)`

来源：源码第 105 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerSubmit(NationalSpire.CareerData, NationalSpire.Good, string, System.Collections.Generic.List<string>, int)`](ConsumerScreen.cs.md#symbol-f212593005f6)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)；[`NationalSpire.SocialAppointments.Attend(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool, bool)`](SocialAppointments.cs.md#symbol-59e09ef2b579)

**调用：** [`NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`](LifeData.cs.md#symbol-bcb55555a432)；[`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`](LifeData.cs.md#symbol-de5af63fa4e7)；[`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`](LifeData.cs.md#symbol-54a09649188b)；[`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；[`NationalSpire.ConsumerEngine.Guests(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, int)`](ConsumerEngine.cs.md#symbol-1d085530bebc)；[`NationalSpire.ConsumerEngine.HospitalityFee(NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-a4327d304bf8)；[`NationalSpire.ConsumerEngine.Season(NationalSpire.CareerData)`](ConsumerEngine.cs.md#symbol-f873e9cbaf82)；[`NationalSpire.ConsumerEvents.Activity(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.GoodVerb, System.Collections.Generic.IReadOnlyList<string>)`](ConsumerEvents.cs.md#symbol-49f04620b21e)；[`NationalSpire.PrivateMessages.ChangeFavour(NationalSpire.CareerData, string, int)`](PrivateMessages.cs.md#symbol-c703192e56c0)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`；`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；`NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.ConsumerEngine.Guests(NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<string>, int)`；`NationalSpire.ConsumerEngine.HospitalityFee(NationalSpire.Good)`；`NationalSpire.ConsumerEngine.Season(NationalSpire.CareerData)`；`NationalSpire.ConsumerEvents.Activity(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.GoodVerb, System.Collections.Generic.IReadOnlyList<string>)`；`NationalSpire.ConsumerState.Goods`；`NationalSpire.ConsumerState.InvitedThisSeason`；`NationalSpire.ConsumerState.PartyCount`；`NationalSpire.Good.Verbs`；`NationalSpire.GoodVerb.Favor`；`NationalSpire.GoodVerb.Id`；`NationalSpire.GoodVerb.Name`；`NationalSpire.GoodVerb.Slots`；`NationalSpire.OwnedGood.Durable`；`NationalSpire.OwnedGood.Id`；`NationalSpire.OwnedGood.Quantity`；`NationalSpire.OwnedGood.UsedSeason`；`NationalSpire.OwnedGood.UsedVerbs`；`NationalSpire.PrivateMessages.ChangeFavour(NationalSpire.CareerData, string, int)`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.ConsumerOperation`

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
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`s.Goods.FirstOrDefault(g => g.Id == goodId && g.Durable && g.Quantity > 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = s.Goods.FirstOrDefault(g => g.Id == goodId && g.Durable && g.Quantity > 0)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`s.InvitedThisSeason.GetValueOrDefault(id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = s.InvitedThisSeason.GetValueOrDefault(id)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`owned.UsedVerbs.Add(verbId)`；返回值紧邻使用处：`ExpressionStatementSyntax: owned.UsedVerbs.Add(verbId);`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`owned.UsedVerbs.Contains(verbId)`；返回值紧邻使用处：`BinaryExpressionSyntax: owned.UsedSeason == d.Season && owned.UsedVerbs.Contains(verbId)`

**赋值（含属性/字段和局部值）：**

- `owned.UsedSeason` = `d.Season`
- `s.InvitedThisSeason[id]` = `count + 1`
