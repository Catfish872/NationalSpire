# ConsumerPurchases.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`5CD470C7FDADA8135782043C33D8A141FCCE2916B74828DA4DC0F95B068A038D`。来源：[源码](../../ConsumerPurchases.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.ConsumerPurchases`。

字段、事件及初始值（源码原样）：

```csharp
private readonly Dictionary<string, int> _days;
private readonly HashSet<string> _current = [];
private readonly Dictionary<string, long> _promotions;
private readonly Dictionary<string, long> _quantities;
```

<a id="symbol-270a101e0b54"></a>

## `NationalSpire.ConsumerPurchases.ConsumerPurchases(NationalSpire.CareerData) — public ConsumerPurchases(CareerData data)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IDictionary<TKey, TValue>)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.ConsumerPurchases._current`；`NationalSpire.ConsumerPurchases._days`；`NationalSpire.ConsumerPurchases._promotions`；`NationalSpire.ConsumerPurchases._quantities`；`NationalSpire.ConsumerState.BoughtDay`；`NationalSpire.ConsumerState.Goods`；`NationalSpire.ConsumerState.PromoUsed`；`NationalSpire.ConsumerState.Season`；`NationalSpire.OwnedGood.BoughtDay`；`NationalSpire.OwnedGood.Consumed`；`NationalSpire.OwnedGood.Id`；`NationalSpire.OwnedGood.Quantity`；`NationalSpire.OwnedGood.Season`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IDictionary<TKey, TValue>)`；输入表达式：`new(state.BoughtDay)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _days = new(state.BoughtDay)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IDictionary<TKey, TValue>)`；输入表达式：`new(state.PromoUsed)`；返回值紧邻使用处：`ConditionalExpressionSyntax: state.Season == data.Season ? new(state.PromoUsed) : []`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_days.TryGetValue(item.Id, out int day)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_days.TryGetValue(item.Id, out int day)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`_current.Add(item.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: _current.Add(item.Id);`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`state.Goods.Where(g => !g.Consumed).GroupBy(g => g.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: state.Goods.Where(g => !g.Consumed).GroupBy(g => g.Id).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；输入表达式：`g.Sum(x => x.Quantity)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.Sum(x => x.Quantity)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`state.Goods.Where(g => !g.Consumed).GroupBy(g => g.Id).ToDictionary(g => g.Key, g => g.Sum(x => x.Quantity))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _quantities = state.Goods.Where(g => !g.Consumed).GroupBy(g => g.Id).ToDictionary(g => g.Key, g => g.Sum(x => x.Quantity))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`state.Goods.Where(g => !g.Consumed)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: state.Goods.Where(g => !g.Consumed).GroupBy`

**赋值（含属性/字段和局部值）：**

- `_days[item.Id]` = `item.BoughtDay`
- `_days` = `new(state.BoughtDay)`
- `_promotions` = `state.Season == data.Season ? new(state.PromoUsed) : []`
- `_quantities` = `state.Goods.Where(g => !g.Consumed).GroupBy(g => g.Id).ToDictionary(g => g.Key, g => g.Sum(x => x.Quantity))`

<a id="symbol-ec47685a5ee4"></a>

## `NationalSpire.ConsumerPurchases.Quantity(NationalSpire.Good) — public long Quantity(Good good)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerPurchases.Label(NationalSpire.Good)`](ConsumerPurchases.cs.md#symbol-09446309617d)；[`NationalSpire.ConsumerPurchases.Owned(NationalSpire.Good)`](ConsumerPurchases.cs.md#symbol-494acd691ab1)

**调用：** `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerPurchases._quantities`；`NationalSpire.Good.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`_quantities.GetValueOrDefault(good.Id)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => _quantities.GetValueOrDefault(good.Id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-494acd691ab1"></a>

## `NationalSpire.ConsumerPurchases.Owned(NationalSpire.Good) — public bool Owned(Good good)`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerPurchases.Label(NationalSpire.Good)`](ConsumerPurchases.cs.md#symbol-09446309617d)

**调用：** [`NationalSpire.ConsumerPurchases.Quantity(NationalSpire.Good)`](ConsumerPurchases.cs.md#symbol-ec47685a5ee4)

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerPurchases.Quantity(NationalSpire.Good)`；`NationalSpire.Good.Collectible`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerPurchases.Quantity(NationalSpire.Good)`；输入表达式：`Quantity(good)`；返回值紧邻使用处：`BinaryExpressionSyntax: Quantity(good) > 0`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0d5481a79067"></a>

## `NationalSpire.ConsumerPurchases.Day(NationalSpire.Good) — public int Day(Good good)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)

**调用：** `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerPurchases._days`；`NationalSpire.Good.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`_days.GetValueOrDefault(good.Id)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => _days.GetValueOrDefault(good.Id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8b20d9717189"></a>

## `NationalSpire.ConsumerPurchases.ThisSeason(NationalSpire.Good) — public bool ThisSeason(Good good)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)；[`Select(NationalSpire.Good)`](ConsumerScreen.cs.md#symbol-5012d526c517)

**调用：** `System.Collections.Generic.HashSet<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerPurchases._current`；`NationalSpire.Good.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_current.Contains(good.Id)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => _current.Contains(good.Id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-81c188784d64"></a>

## `NationalSpire.ConsumerPurchases.Promotions(NationalSpire.Good) — public long Promotions(Good good)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)；[`NationalSpire.ConsumerPurchases.Label(NationalSpire.Good)`](ConsumerPurchases.cs.md#symbol-09446309617d)

**调用：** `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerPurchases._promotions`；`NationalSpire.Good.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`_promotions.GetValueOrDefault(good.Id)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => _promotions.GetValueOrDefault(good.Id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-165f5a504331"></a>

## `NationalSpire.ConsumerPurchases.Collection — public IEnumerable<Good> Collection`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerCatalog.All`；`NationalSpire.ConsumerPurchases.Owned(NationalSpire.Good)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`ConsumerCatalog.All.Where(Owned)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ConsumerCatalog.All.Where(Owned)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-09446309617d"></a>

## `NationalSpire.ConsumerPurchases.Label(NationalSpire.Good) — public string Label(Good good)`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)

**调用：** [`NationalSpire.ConsumerPurchases.Owned(NationalSpire.Good)`](ConsumerPurchases.cs.md#symbol-494acd691ab1)；[`NationalSpire.ConsumerPurchases.Promotions(NationalSpire.Good)`](ConsumerPurchases.cs.md#symbol-81c188784d64)；[`NationalSpire.ConsumerPurchases.Quantity(NationalSpire.Good)`](ConsumerPurchases.cs.md#symbol-ec47685a5ee4)

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerCatalog.PromoPerSeason`；`NationalSpire.ConsumerPurchases.Owned(NationalSpire.Good)`；`NationalSpire.ConsumerPurchases.Promotions(NationalSpire.Good)`；`NationalSpire.ConsumerPurchases.Quantity(NationalSpire.Good)`；`NationalSpire.Good.Collectible`；`NationalSpire.Good.Promo`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerPurchases.Owned(NationalSpire.Good)`；输入表达式：`Owned(good)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Owned(good) ? $"持有 ×{Quantity(good)}" : good.Collectible ? "" : "即时消费"`
- `NationalSpire.ConsumerPurchases.Promotions(NationalSpire.Good)`；输入表达式：`Promotions(good)`；返回值紧邻使用处：`InterpolationSyntax: {Promotions(good)}`
- `NationalSpire.ConsumerPurchases.Quantity(NationalSpire.Good)`；输入表达式：`Quantity(good)`；返回值紧邻使用处：`InterpolationSyntax: {Quantity(good)}`

**赋值（含属性/字段和局部值）：**
