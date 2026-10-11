# CareerRelics.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`BA48626B133D430F9FA064D50FC8F155B465F0BB37E513CAE6AA2BEA32FDF67C`。来源：[源码](../../CareerRelics.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.FigurineState`、`NationalSpire.CareerRelics`、`NationalSpire.CareerRelics.Item`。

字段、事件及初始值（源码原样）：

```csharp
public static readonly Item[] Catalog = [
        new("MEMBERSHIP_CARD", "会员卡", 360, "生活和社交活动费用减少约 5%，每次最多省 $100。"),
        new("TOOLBOX", "工具箱", 600, "每轮活动多提供一个候选，仍然只能选择一项。"),
        new("BURNING_BLOOD", "燃烧之血", 420, "正常参赛失利后，少扣 1—2 点生涯评分。"),
        new("MAW_BANK", "巨口储蓄罐", 32, "接下来 14 天，每天存入 $10—20；下一次活动或手办消费时取出并停止储蓄。到期自动取出。"),
        new("VENERABLE_TEA_SET", "古茶具套装", 280, "完成生活活动后，下一次内容制作缩短 1 天；最多保留一次。"),
        new("TUNGSTEN_ROD", "钨合金棍", 180, "商业项目亏损时补回亏损的 20%，每次最多 $150，共 3 次。盈利时不消耗次数。", 3),
        new("MEAL_TICKET", "餐券", 60, "料理课、赛后请客或新人接风每次减免 $50，共 5 次。", 5),
        new("THE_COURIER", "送货员", 400, "后续购买手办享受 85 折，重新购买限次手办也适用。"),
        new("ANCHOR", "锚", 220, "每赛季第一次内容或社区活动减免 $100。"),
        new("ORICHALCUM", "奥利哈钢", 240, "没有任何活动正在进行时，正常参赛失利少扣 1 点生涯评分。"),
        new("DREAM_CATCHER", "捕梦网", 350, "完成生活活动后，下一轮额外提供一项内容制作候选，仍然只选一项。"),
        new("POTION_BELT", "药水腰带", 120, "正常完成比赛且有剩余药水时，获得 $20—40 纪念展示支持，共 6 次。", 6),
        new("JUZU_BRACELET", "佛珠手链", 300, "每轮至少提供一项生活或社交活动。"),
        new("REGAL_PILLOW", "皇家枕头", 240, "完成生活活动后，为接下来两场正常参赛各提供 1 点失利评分保护；次数不叠加。"),
        new("HAPPY_FLOWER", "开心小花", 200, "每完成三项活动，获得 $30—60 的小额创作回馈。"),
        new("LETTER_OPENER", "开信刀", 300, "每完成三项内容制作，额外增加 20—35 位关注者。"),
        new("PEN_NIB", "钢笔尖", 360, "每完成两项内容制作，额外增加 12—20 位关注者。"),
        new("KUNAI", "苦无", 380, "每完成三次青训支持，为该次培养增加 $200 的训练资源，仍受培养上限约束。"),
        new("SHURIKEN", "手里剑", 360, "每完成三次社区活动，额外增加 20—35 位关注者。"),
        new("CENTENNIAL_PUZZLE", "百年积木", 200, "每赛季首次正常参赛失利后，下次内容制作减免 $100。"),
        new("WINGED_BOOTS", "羽翼之靴", 240, "下一项至少 3 天的活动缩短 1 天，共 3 次；不会缩短至不足 1 天。", 3),
        new("BAG_OF_PREPARATION", "准备背包", 100, "接下来三次内容或社区活动，每次减免 $60。", 3),
        new("SLING_OF_COURAGE", "勇气投石索", 480, "正常赢下进阶 8 及以上的比赛时，额外增加 5—10 位关注者。"),
        new("WHITE_STAR", "白星", 550, "每赛季首次赢下国际赛事，获得 $80—120 的纪念展示支持。"),
        new("JEWELED_MASK", "宝石面具", 260, "首次与某位人物完成社交活动时，好感额外增加 3。"),
        new("GOLDEN_PEARL", "金色珍珠", 500, "商业项目盈利时，额外获得利润的 5%，每次最多 $100。")
    ];
```

<a id="symbol-5ee88a6f4748"></a>

## `NationalSpire.FigurineState.BoughtDay — public int BoughtDay`

来源：源码第 5 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f18c25985833"></a>

## `NationalSpire.FigurineState.Uses — public int Uses`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2565b9773d10"></a>

## `NationalSpire.FigurineState.Count — public int Count`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f29307229936"></a>

## `NationalSpire.FigurineState.Charge — public int Charge`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-298a8d4e4821"></a>

## `NationalSpire.FigurineState.Season — public int Season`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-df4d6b7f9a83"></a>

## `NationalSpire.FigurineState.Accrued — public int Accrued`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e5d62127a9d4"></a>

## `NationalSpire.FigurineState.AccrualDay — public int AccrualDay`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6e51b3cd88db"></a>

## `NationalSpire.FigurineState.Ended — public bool Ended`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-14c82b1b0f0c"></a>

## `NationalSpire.FigurineState.SocialRewards — public HashSet<string>? SocialRewards`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c1cf7133742f"></a>

## `NationalSpire.CareerRelics.Roll(NationalSpire.CareerData, string, int, int) — private static int Roll(CareerData d, string key, int min, int max)`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Cash(string, int, int)`](CareerRelics.cs.md#symbol-5396043b0c0f)；[`Fans(string, int, int, int)`](CareerRelics.cs.md#symbol-df4fb4332deb)；[`NationalSpire.CareerRelics.Advance(NationalSpire.CareerData)`](CareerRelics.cs.md#symbol-2d82195832e2)；[`NationalSpire.CareerRelics.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-f756311e9342)；[`NationalSpire.CareerRelics.Match(NationalSpire.CareerData, NationalSpire.CareerMatch, NationalSpire.CareerResult, bool, int)`](CareerRelics.cs.md#symbol-6e6e3fa2b1d4)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(d.WorldId + ":figurine:" + key)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.StableHash(d.WorldId + ":figurine:" + key) % (max - min + 1)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7b703fddee2f"></a>

## `NationalSpire.CareerRelics.Has(NationalSpire.CareerData, string) — public static bool Has(CareerData d, string id)`

来源：源码第 49 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Offer(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-06bdec919490)；[`NationalSpire.CareerRelics.Business(NationalSpire.CareerData, NationalSpire.LifeActivity, int)`](CareerRelics.cs.md#symbol-2a0ab3c0872b)；[`NationalSpire.CareerRelics.Discounts(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-c0eb9f3fff83)；[`NationalSpire.CareerRelics.Match(NationalSpire.CareerData, NationalSpire.CareerMatch, NationalSpire.CareerResult, bool, int)`](CareerRelics.cs.md#symbol-6e6e3fa2b1d4)；[`NationalSpire.CareerRelics.PurchasePrice(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`](CareerRelics.cs.md#symbol-27dcdb7c3aa9)；[`NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-6618444af155)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Figurines`；`NationalSpire.FigurineState.Ended`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`d.Life.Figurines.TryGetValue(id, out var s)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Life.Figurines.TryGetValue(id, out var s) && !s.Ended`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6618444af155"></a>

## `NationalSpire.CareerRelics.State(NationalSpire.CareerData, string) — private static FigurineState? State(CareerData d, string id)`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Fans(string, int, int, int)`](CareerRelics.cs.md#symbol-df4fb4332deb)；[`NationalSpire.CareerRelics.Accept(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-c4d68b813d74)；[`NationalSpire.CareerRelics.Advance(NationalSpire.CareerData)`](CareerRelics.cs.md#symbol-2d82195832e2)；[`NationalSpire.CareerRelics.Business(NationalSpire.CareerData, NationalSpire.LifeActivity, int)`](CareerRelics.cs.md#symbol-2a0ab3c0872b)；[`NationalSpire.CareerRelics.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-f756311e9342)；[`NationalSpire.CareerRelics.Discounts(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-c0eb9f3fff83)；[`NationalSpire.CareerRelics.Duration(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-5a1db0b8215e)；[`NationalSpire.CareerRelics.Match(NationalSpire.CareerData, NationalSpire.CareerMatch, NationalSpire.CareerResult, bool, int)`](CareerRelics.cs.md#symbol-6e6e3fa2b1d4)；[`NationalSpire.CareerRelics.Spend(NationalSpire.CareerData)`](CareerRelics.cs.md#symbol-9133387726a4)；[`NationalSpire.CareerRelics.Training(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-4da6df64d860)

**调用：** [`NationalSpire.CareerRelics.Has(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-7b703fddee2f)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Figurines`；`NationalSpire.CareerRelics.Has(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerRelics.Has(NationalSpire.CareerData, string)`；输入表达式：`Has(d, id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Has(d, id) ? d.Life.Figurines[id] : null`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0475739162e2"></a>

## `NationalSpire.CareerRelics.CanBuy(NationalSpire.CareerData, NationalSpire.CareerRelics.Item) — public static bool CanBuy(CareerData d, Item r)`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerRelics.Buy(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-7b350b30a8d9)；[`NationalSpire.CareerRelics.Shop(NationalSpire.CareerData)`](CareerRelics.cs.md#symbol-b30378b84f42)；[`NationalSpire.CareerScreen.FigurineCard(NationalSpire.CareerData, Godot.GridContainer, NationalSpire.CareerRelics.Item, bool)`](LifeScreen.cs.md#symbol-8732620351f6)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Figurines`；`NationalSpire.CareerRelics.Item.Id`；`NationalSpire.CareerRelics.Item.Uses`；`NationalSpire.FigurineState.Uses`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`d.Life.Figurines.TryGetValue(r.Id, out var s)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.Life.Figurines.TryGetValue(r.Id, out var s)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b30378b84f42"></a>

## `NationalSpire.CareerRelics.Shop(NationalSpire.CareerData) — public static void Shop(CareerData d)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Ensure(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-eb417e39aebf)；[`NationalSpire.CareerRelics.Advance(NationalSpire.CareerData)`](CareerRelics.cs.md#symbol-2d82195832e2)；[`NationalSpire.CareerRelics.Buy(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-7b350b30a8d9)；[`NationalSpire.CareerScreen.LifeCollection(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-7fd7cd27279c)；[`NationalSpire.Coop.CoopRules.AddMember(NationalSpire.Coop.CoopWorld, ulong, string)`](Coop/CoopRules.cs.md#symbol-fedd425e9ea0)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.CareerRelics.CanBuy(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`](CareerRelics.cs.md#symbol-0475739162e2)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerLifeState.RestockDay`；`NationalSpire.CareerLifeState.Shop`；`NationalSpire.CareerRelics.CanBuy(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`；`NationalSpire.CareerRelics.Catalog`；`NationalSpire.CareerRelics.Item.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(d.WorldId + ":shop:" + d.Day + r.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r => CareerEngine.StableHash(d.WorldId + ":shop:" + d.Day + r.Id)`
- `NationalSpire.CareerRelics.CanBuy(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`；输入表达式：`CanBuy(d, r)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r => CanBuy(d, r)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`previous.Contains(r.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r => previous.Contains(r.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`Catalog.Where(r => CanBuy(d, r)).OrderBy(r => previous.Contains(r.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Catalog.Where(r => CanBuy(d, r)).OrderBy(r => previous.Contains(r.Id))              .ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Catalog.Where(r => CanBuy(d, r)).OrderBy(r => previous.Contains(r.Id))              .ThenBy(r => CareerEngine.StableHash(d.WorldId + ":shop:" + d.Day + r.Id)).Take(4).Select(r => r.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Catalog.Where(r => CanBuy(d, r)).OrderBy(r => previous.Contains(r.Id))              .ThenBy(r => CareerEngine.StableHash(d.WorldId + ":shop:" + d.Day + r.Id)).Take(4).Select(r => r.Id).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`Catalog.Where(r => CanBuy(d, r)).OrderBy(r => previous.Contains(r.Id))              .ThenBy(r => CareerEngine.StableHash(d.WorldId + ":shop:" + d.Day + r.Id)).Take(4)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Catalog.Where(r => CanBuy(d, r)).OrderBy(r => previous.Contains(r.Id))              .ThenBy(r => CareerEngine.StableHash(d.WorldId + ":shop:" + d.Day + r.Id)).Take(4).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`d.Life.Shop.Take(4)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Shop.Take(4).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`d.Life.Shop.ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Life.Shop.ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`Catalog.Where(r => CanBuy(d, r)).OrderBy(r => previous.Contains(r.Id))              .ThenBy(r => CareerEngine.StableHash(d.WorldId + ":shop:" + d.Day + r.Id)).Take(4).Select(r => r.Id).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: d.Life.Shop = Catalog.Where(r => CanBuy(d, r)).OrderBy(r => previous.Contains(r.Id))              .ThenBy(r => CareerEngine.StableHash(d.WorldId + ":shop:" + d.Day + r.Id)).Take(4).Select(r => r.Id).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Life.Shop.Take(4).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: d.Life.Shop = d.Life.Shop.Take(4).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Catalog.Where(r => CanBuy(d, r))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Catalog.Where(r => CanBuy(d, r)).OrderBy`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`Catalog.Where(r => CanBuy(d, r)).OrderBy(r => previous.Contains(r.Id))              .ThenBy(r => CareerEngine.StableHash(d.WorldId + ":shop:" + d.Day + r.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Catalog.Where(r => CanBuy(d, r)).OrderBy(r => previous.Contains(r.Id))              .ThenBy(r => CareerEngine.StableHash(d.WorldId + ":shop:" + d.Day + r.Id)).Take`

**赋值（含属性/字段和局部值）：**

- `d.Life.RestockDay` = `d.Day + 14`
- `d.Life.Shop` = `Catalog.Where(r => CanBuy(d, r)).OrderBy(r => previous.Contains(r.Id))              .ThenBy(r => CareerEngine.StableHash(d.WorldId + ":shop:" + d.Day + r.Id)).Take(4).Select(r => r.Id).ToList()`
- `d.Life.Shop` = `d.Life.Shop.Take(4).ToList()`

<a id="symbol-5393973f2695"></a>

## `NationalSpire.CareerRelics.Offers(NationalSpire.CareerData) — public static IEnumerable<Item> Offers(CareerData d)`

来源：源码第 62 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerRelics.Buy(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-7b350b30a8d9)；[`NationalSpire.CareerScreen.LifeCollection(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-7fd7cd27279c)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.IEnumerable.OfType<TResult>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Shop`；`NationalSpire.CareerRelics.Catalog`；`NationalSpire.CareerRelics.Item.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`Catalog.FirstOrDefault(r => r.Id == id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => Catalog.FirstOrDefault(r => r.Id == id)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.Life.Shop.Take(4)          .Select(id => Catalog.FirstOrDefault(r => r.Id == id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Shop.Take(4)          .Select(id => Catalog.FirstOrDefault(r => r.Id == id)).OfType<Item>`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`d.Life.Shop.Take(4)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Shop.Take(4)          .Select`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`d.Life.Shop.Take(4)          .Select(id => Catalog.FirstOrDefault(r => r.Id == id)).OfType<Item>()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => d.Life.Shop.Take(4)          .Select(id => Catalog.FirstOrDefault(r => r.Id == id)).OfType<Item>()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-27dcdb7c3aa9"></a>

## `NationalSpire.CareerRelics.PurchasePrice(NationalSpire.CareerData, NationalSpire.CareerRelics.Item) — public static int PurchasePrice(CareerData d, Item item)`

来源：源码第 64 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerRelics.Buy(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-7b350b30a8d9)；[`NationalSpire.CareerScreen.FigurineCard(NationalSpire.CareerData, Godot.GridContainer, NationalSpire.CareerRelics.Item, bool)`](LifeScreen.cs.md#symbol-8732620351f6)

**调用：** [`NationalSpire.CareerRelics.Has(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-7b703fddee2f)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerRelics.Has(NationalSpire.CareerData, string)`；`NationalSpire.CareerRelics.Item.Price`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerRelics.Has(NationalSpire.CareerData, string)`；输入表达式：`Has(d, "THE_COURIER")`；返回值紧邻使用处：`ConditionalExpressionSyntax: Has(d, "THE_COURIER") ? (item.Price * 85 + 99) / 100 : item.Price`

**赋值（含属性/字段和局部值）：**


<a id="symbol-cdd79095d49f"></a>

## `NationalSpire.CareerRelics.Status(NationalSpire.CareerData, NationalSpire.CareerRelics.Item) — public static string Status(CareerData d, Item r)`

来源：源码第 65 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.FigurineCard(NationalSpire.CareerData, Godot.GridContainer, NationalSpire.CareerRelics.Item, bool)`](LifeScreen.cs.md#symbol-8732620351f6)

**调用：** [`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Figurines`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerRelics.Item.Id`；`NationalSpire.CareerRelics.Item.Uses`；`NationalSpire.FigurineState.Accrued`；`NationalSpire.FigurineState.BoughtDay`；`NationalSpire.FigurineState.Charge`；`NationalSpire.FigurineState.Ended`；`NationalSpire.FigurineState.Uses`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(s.Accrued)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(s.Accrued)}`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7b350b30a8d9"></a>

## `NationalSpire.CareerRelics.Buy(NationalSpire.CareerData, string) — public static string? Buy(CareerData d, string id)`

来源：源码第 75 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.FigurineCard(NationalSpire.CareerData, Godot.GridContainer, NationalSpire.CareerRelics.Item, bool)`](LifeScreen.cs.md#symbol-8732620351f6)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** [`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`](LifeData.cs.md#symbol-54a09649188b)；[`NationalSpire.CareerRelics.CanBuy(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`](CareerRelics.cs.md#symbol-0475739162e2)；[`NationalSpire.CareerRelics.Offers(NationalSpire.CareerData)`](CareerRelics.cs.md#symbol-5393973f2695)；[`NationalSpire.CareerRelics.PurchasePrice(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`](CareerRelics.cs.md#symbol-27dcdb7c3aa9)；[`NationalSpire.CareerRelics.Shop(NationalSpire.CareerData)`](CareerRelics.cs.md#symbol-b30378b84f42)；[`NationalSpire.CareerRelics.Spend(NationalSpire.CareerData)`](CareerRelics.cs.md#symbol-9133387726a4)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；`NationalSpire.FigurineState.FigurineState()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Figurines`；`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；`NationalSpire.CareerRelics.CanBuy(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`；`NationalSpire.CareerRelics.Item.Id`；`NationalSpire.CareerRelics.Item.Name`；`NationalSpire.CareerRelics.Item.Uses`；`NationalSpire.CareerRelics.Offers(NationalSpire.CareerData)`；`NationalSpire.CareerRelics.PurchasePrice(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`；`NationalSpire.CareerRelics.Shop(NationalSpire.CareerData)`；`NationalSpire.CareerRelics.Spend(NationalSpire.CareerData)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.FigurineState.AccrualDay`；`NationalSpire.FigurineState.BoughtDay`；`NationalSpire.FigurineState.Ended`；`NationalSpire.FigurineState.Uses`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；输入表达式：`CareerMoney.Record(d, r.Name + (refill ? "手办恢复次数" : "手办"), -price)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Record(d, r.Name + (refill ? "手办恢复次数" : "手办"), -price);`
- `NationalSpire.CareerRelics.CanBuy(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`；输入表达式：`CanBuy(d, r)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CanBuy(d, r)`
- `NationalSpire.CareerRelics.Offers(NationalSpire.CareerData)`；输入表达式：`Offers(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Offers(d).FirstOrDefault`
- `NationalSpire.CareerRelics.PurchasePrice(NationalSpire.CareerData, NationalSpire.CareerRelics.Item)`；输入表达式：`PurchasePrice(d, r)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PurchasePrice(d, r)`
- `NationalSpire.CareerRelics.Shop(NationalSpire.CareerData)`；输入表达式：`Shop(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: Shop(d);`
- `NationalSpire.CareerRelics.Spend(NationalSpire.CareerData)`；输入表达式：`Spend(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: Spend(d);`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(d);`
- `NationalSpire.FigurineState.FigurineState()`；输入表达式：`new() { BoughtDay = d.Day, AccrualDay = d.Day, Uses = r.Uses }`；返回值紧邻使用处：`AssignmentExpressionSyntax: d.Life.Figurines[id] = new() { BoughtDay = d.Day, AccrualDay = d.Day, Uses = r.Uses }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`d.Life.Figurines.ContainsKey(id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Life.Figurines.ContainsKey(id)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`Offers(d).FirstOrDefault(r => r.Id == id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Offers(d).FirstOrDefault(r => r.Id == id)`

**赋值（含属性/字段和局部值）：**

- `AccrualDay` = `d.Day`
- `BoughtDay` = `d.Day`
- `d.Credits` -= `price`
- `d.Life.Figurines[id]` = `new() { BoughtDay = d.Day, AccrualDay = d.Day, Uses = r.Uses }`
- `owned.Ended` = `false`
- `owned.Uses` = `r.Uses`
- `Uses` = `r.Uses`

<a id="symbol-2d82195832e2"></a>

## `NationalSpire.CareerRelics.Advance(NationalSpire.CareerData) — public static void Advance(CareerData d)`

来源：源码第 89 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Advance(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-62ec6434f115)；[`NationalSpire.CareerRelics.Spend(NationalSpire.CareerData)`](CareerRelics.cs.md#symbol-9133387726a4)

**调用：** [`NationalSpire.CareerRelics.CashBank(NationalSpire.CareerData, NationalSpire.FigurineState)`](CareerRelics.cs.md#symbol-217479119f92)；[`NationalSpire.CareerRelics.Roll(NationalSpire.CareerData, string, int, int)`](CareerRelics.cs.md#symbol-c1cf7133742f)；[`NationalSpire.CareerRelics.Shop(NationalSpire.CareerData)`](CareerRelics.cs.md#symbol-b30378b84f42)；[`NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-6618444af155)；`System.Math.Max(int, int)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerRelics.CashBank(NationalSpire.CareerData, NationalSpire.FigurineState)`；`NationalSpire.CareerRelics.Roll(NationalSpire.CareerData, string, int, int)`；`NationalSpire.CareerRelics.Shop(NationalSpire.CareerData)`；`NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；`NationalSpire.FigurineState.AccrualDay`；`NationalSpire.FigurineState.Accrued`；`NationalSpire.FigurineState.BoughtDay`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerRelics.CashBank(NationalSpire.CareerData, NationalSpire.FigurineState)`；输入表达式：`CashBank(d, s)`；返回值紧邻使用处：`ExpressionStatementSyntax: CashBank(d, s);`
- `NationalSpire.CareerRelics.Roll(NationalSpire.CareerData, string, int, int)`；输入表达式：`Roll(d, "bank:" + day, 1, 2)`；返回值紧邻使用处：`AssignmentExpressionSyntax: s.Accrued += Roll(d, "bank:" + day, 1, 2)`
- `NationalSpire.CareerRelics.Shop(NationalSpire.CareerData)`；输入表达式：`Shop(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: Shop(d);`
- `NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；输入表达式：`State(d, "MAW_BANK")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = State(d, "MAW_BANK")`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(s.AccrualDay, s.BoughtDay)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(s.AccrualDay, s.BoughtDay) + 1`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(d.Day, s.BoughtDay + 14)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(d.Day, s.BoughtDay + 14)`

**赋值（含属性/字段和局部值）：**

- `s.AccrualDay` = `end`
- `s.Accrued` += `Roll(d, "bank:" + day, 1, 2)`

<a id="symbol-217479119f92"></a>

## `NationalSpire.CareerRelics.CashBank(NationalSpire.CareerData, NationalSpire.FigurineState) — private static void CashBank(CareerData d, FigurineState s)`

来源：源码第 99 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerRelics.Advance(NationalSpire.CareerData)`](CareerRelics.cs.md#symbol-2d82195832e2)；[`NationalSpire.CareerRelics.Spend(NationalSpire.CareerData)`](CareerRelics.cs.md#symbol-9133387726a4)

**调用：** [`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`](LifeData.cs.md#symbol-54a09649188b)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Credits`；`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；`NationalSpire.FigurineState.Accrued`；`NationalSpire.FigurineState.Ended`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；输入表达式：`CareerMoney.Record(d, "巨口储蓄罐手办取款", s.Accrued)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Record(d, "巨口储蓄罐手办取款", s.Accrued);`

**赋值（含属性/字段和局部值）：**

- `d.Credits` += `s.Accrued`
- `s.Ended` = `true`

<a id="symbol-9133387726a4"></a>

## `NationalSpire.CareerRelics.Spend(NationalSpire.CareerData) — public static void Spend(CareerData d)`

来源：源码第 103 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Accept(NationalSpire.CareerData, string, string)`](CareerLife.cs.md#symbol-cce5ea9d3250)；[`NationalSpire.CareerRelics.Buy(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-7b350b30a8d9)

**调用：** [`NationalSpire.CareerRelics.Advance(NationalSpire.CareerData)`](CareerRelics.cs.md#symbol-2d82195832e2)；[`NationalSpire.CareerRelics.CashBank(NationalSpire.CareerData, NationalSpire.FigurineState)`](CareerRelics.cs.md#symbol-217479119f92)；[`NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-6618444af155)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerRelics.Advance(NationalSpire.CareerData)`；`NationalSpire.CareerRelics.CashBank(NationalSpire.CareerData, NationalSpire.FigurineState)`；`NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerRelics.Advance(NationalSpire.CareerData)`；输入表达式：`Advance(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: Advance(d);`
- `NationalSpire.CareerRelics.CashBank(NationalSpire.CareerData, NationalSpire.FigurineState)`；输入表达式：`CashBank(d, s)`；返回值紧邻使用处：`ExpressionStatementSyntax: CashBank(d, s);`
- `NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；输入表达式：`State(d, "MAW_BANK")`；返回值紧邻使用处：`IsPatternExpressionSyntax: State(d, "MAW_BANK") is { } s`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fc2cfb5d7227"></a>

## `NationalSpire.CareerRelics.Food(NationalSpire.LifeActivity) — private static bool Food(LifeActivity a)`

来源：源码第 108 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerRelics.Discounts(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-c0eb9f3fff83)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.LifeActivity.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9d3d212bb912"></a>

## `NationalSpire.CareerRelics.Media(NationalSpire.LifeActivity) — private static bool Media(LifeActivity a)`

来源：源码第 109 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerRelics.Discounts(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-c0eb9f3fff83)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.LifeActivity.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c0eb9f3fff83"></a>

## `NationalSpire.CareerRelics.Discounts(NationalSpire.CareerData, NationalSpire.LifeActivity) — private static IEnumerable<(string Id, int Amount)> Discounts(CareerData d, LifeActivity a)`

来源：源码第 111 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerRelics.Accept(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-c4d68b813d74)；[`NationalSpire.CareerRelics.Cost(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-648cf5a95449)

**调用：** [`NationalSpire.CareerRelics.Food(NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-fc2cfb5d7227)；[`NationalSpire.CareerRelics.Has(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-7b703fddee2f)；[`NationalSpire.CareerRelics.Media(NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-9d3d212bb912)；[`NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-6618444af155)；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerLifeState.Facilities`；`NationalSpire.CareerLifeState.Preparation`；`NationalSpire.CareerRelics.Food(NationalSpire.LifeActivity)`；`NationalSpire.CareerRelics.Has(NationalSpire.CareerData, string)`；`NationalSpire.CareerRelics.Media(NationalSpire.LifeActivity)`；`NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；`NationalSpire.FigurineState.Charge`；`NationalSpire.FigurineState.Season`；`NationalSpire.FigurineState.Uses`；`NationalSpire.LifeActivity.Cost`；`NationalSpire.LifeActivity.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerRelics.Food(NationalSpire.LifeActivity)`；输入表达式：`Food(a)`；返回值紧邻使用处：`BinaryExpressionSyntax: Food(a) && State(d, "MEAL_TICKET") is { Uses: > 0 }`
- `NationalSpire.CareerRelics.Has(NationalSpire.CareerData, string)`；输入表达式：`Has(d, "MEMBERSHIP_CARD")`；返回值紧邻使用处：`BinaryExpressionSyntax: Has(d, "MEMBERSHIP_CARD") && a.Kind is "生活" or "社交"`
- `NationalSpire.CareerRelics.Media(NationalSpire.LifeActivity)`；输入表达式：`Media(a)`；返回值紧邻使用处：`BinaryExpressionSyntax: Media(a) && d.Life.Facilities > 0`
- `NationalSpire.CareerRelics.Media(NationalSpire.LifeActivity)`；输入表达式：`Media(a)`；返回值紧邻使用处：`BinaryExpressionSyntax: Media(a) && State(d, "ANCHOR") is { } anchor`
- `NationalSpire.CareerRelics.Media(NationalSpire.LifeActivity)`；输入表达式：`Media(a)`；返回值紧邻使用处：`BinaryExpressionSyntax: Media(a) && State(d, "BAG_OF_PREPARATION") is { Uses: > 0 }`
- `NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；输入表达式：`State(d, "ANCHOR")`；返回值紧邻使用处：`IsPatternExpressionSyntax: State(d, "ANCHOR") is { } anchor`
- `NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；输入表达式：`State(d, "BAG_OF_PREPARATION")`；返回值紧邻使用处：`IsPatternExpressionSyntax: State(d, "BAG_OF_PREPARATION") is { Uses: > 0 }`
- `NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；输入表达式：`State(d, "CENTENNIAL_PUZZLE")`；返回值紧邻使用处：`IsPatternExpressionSyntax: State(d, "CENTENNIAL_PUZZLE") is { Charge: > 0 }`
- `NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；输入表达式：`State(d, "MEAL_TICKET")`；返回值紧邻使用处：`IsPatternExpressionSyntax: State(d, "MEAL_TICKET") is { Uses: > 0 }`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(10, a.Cost * 5 / 100)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(10, a.Cost * 5 / 100)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(24, a.Cost * 12 / 100)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(24, a.Cost * 12 / 100)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(24, a.Cost * Math.Min(72, d.Life.Facilities * 24) / 1000)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(24, a.Cost * Math.Min(72, d.Life.Facilities * 24) / 1000)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(72, d.Life.Facilities * 24)`；返回值紧邻使用处：`BinaryExpressionSyntax: a.Cost * Math.Min(72, d.Life.Facilities * 24)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-648cf5a95449"></a>

## `NationalSpire.CareerRelics.Cost(NationalSpire.CareerData, NationalSpire.LifeActivity) — public static int Cost(CareerData d, LifeActivity a)`

来源：源码第 122 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Accept(NationalSpire.CareerData, string, string)`](CareerLife.cs.md#symbol-cce5ea9d3250)；[`NationalSpire.CareerScreen.ActivityCard(NationalSpire.CareerData, NationalSpire.LifeActivity)`](LifeScreen.cs.md#symbol-5b3e0aaad277)

**调用：** [`NationalSpire.CareerRelics.Discounts(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-c0eb9f3fff83)；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `(string Id, int Amount).Amount`；`NationalSpire.CareerRelics.Discounts(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.LifeActivity.Cost`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerRelics.Discounts(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`Discounts(d, a)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Discounts(d, a).Sum`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`Discounts(d, a).Sum(x => x.Amount)`；返回值紧邻使用处：`ArgumentSyntax: Discounts(d, a).Sum(x => x.Amount)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(a.Cost / 5, Discounts(d, a).Sum(x => x.Amount))`；返回值紧邻使用处：`BinaryExpressionSyntax: a.Cost - Math.Min(a.Cost / 5, Discounts(d, a).Sum(x => x.Amount))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5a1db0b8215e"></a>

## `NationalSpire.CareerRelics.Duration(NationalSpire.CareerData, NationalSpire.LifeActivity) — public static int Duration(CareerData d, LifeActivity a)`

来源：源码第 123 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Accept(NationalSpire.CareerData, string, string)`](CareerLife.cs.md#symbol-cce5ea9d3250)；[`NationalSpire.CareerScreen.ActivityCard(NationalSpire.CareerData, NationalSpire.LifeActivity)`](LifeScreen.cs.md#symbol-5b3e0aaad277)

**调用：** [`NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-6618444af155)；[`NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`](CareerTraining.cs.md#symbol-98adbc7a75dc)；[`NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-f251644672be)；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；`NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`；`NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`；`NationalSpire.FigurineState.Charge`；`NationalSpire.FigurineState.Uses`；`NationalSpire.LifeActivity.Duration`；`NationalSpire.LifeActivity.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；输入表达式：`State(d, "VENERABLE_TEA_SET")`；返回值紧邻使用处：`IsPatternExpressionSyntax: State(d, "VENERABLE_TEA_SET") is { Charge: > 0 }`
- `NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；输入表达式：`State(d, "WINGED_BOOTS")`；返回值紧邻使用处：`IsPatternExpressionSyntax: State(d, "WINGED_BOOTS") is { Uses: > 0 }`
- `NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`CareerTraining.IsTraining(a)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerTraining.IsTraining(a) || ClubPrograms.IsTraining(a)`
- `NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`ClubPrograms.IsTraining(a)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerTraining.IsTraining(a) || ClubPrograms.IsTraining(a)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1, a.Duration          - (a.Kind == "内容" && State(d, "VENERABLE_TEA_SET") is { Charge: > 0 } ? 1 : 0)          - (a.Duration >= 3 && State(d, "WINGED_BOOTS") is { Uses: > 0 } ? 1 : 0))`；返回值紧邻使用处：`ConditionalExpressionSyntax: (CareerTraining.IsTraining(a) || ClubPrograms.IsTraining(a)) ? 28 : Math.Max(1, a.Duration          - (a.Kind == "内容" && State(d, "VENERABLE_TEA_SET") is { Charge: > 0 } ? 1 : 0)          - (a.Duration >= 3 && State(d, "WINGED_BOOTS") is { Uses: > 0 } ? 1 : 0))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-cb2cae9459ee"></a>

## `NationalSpire.CareerRelics.Use(NationalSpire.CareerData, string) — private static void Use(CareerData d, string id)`

来源：源码第 126 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerRelics.Accept(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-c4d68b813d74)；[`NationalSpire.CareerRelics.Business(NationalSpire.CareerData, NationalSpire.LifeActivity, int)`](CareerRelics.cs.md#symbol-2a0ab3c0872b)；[`NationalSpire.CareerRelics.Match(NationalSpire.CareerData, NationalSpire.CareerMatch, NationalSpire.CareerResult, bool, int)`](CareerRelics.cs.md#symbol-6e6e3fa2b1d4)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Figurines`；`NationalSpire.CareerRelics.Catalog`；`NationalSpire.CareerRelics.Item.Id`；`NationalSpire.CareerRelics.Item.Uses`；`NationalSpire.FigurineState.Ended`；`NationalSpire.FigurineState.Uses`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`Catalog.First(r => r.Id == id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Catalog.First(r => r.Id == id).Uses`

**赋值（含属性/字段和局部值）：**

- `s.Ended` = `true`

<a id="symbol-c4d68b813d74"></a>

## `NationalSpire.CareerRelics.Accept(NationalSpire.CareerData, NationalSpire.LifeActivity) — public static void Accept(CareerData d, LifeActivity a)`

来源：源码第 131 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Accept(NationalSpire.CareerData, string, string)`](CareerLife.cs.md#symbol-cce5ea9d3250)

**调用：** [`NationalSpire.CareerRelics.Discounts(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-c0eb9f3fff83)；[`NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-6618444af155)；[`NationalSpire.CareerRelics.Use(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-cb2cae9459ee)；[`NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`](CareerTraining.cs.md#symbol-98adbc7a75dc)；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerLifeState.Figurines`；`NationalSpire.CareerLifeState.Preparation`；`NationalSpire.CareerRelics.Discounts(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；`NationalSpire.CareerRelics.Use(NationalSpire.CareerData, string)`；`NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`；`NationalSpire.FigurineState.Charge`；`NationalSpire.FigurineState.Season`；`NationalSpire.FigurineState.Uses`；`NationalSpire.LifeActivity.Cost`；`NationalSpire.LifeActivity.Duration`；`NationalSpire.LifeActivity.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerRelics.Discounts(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`Discounts(d, a)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Discounts(d, a).ToList`
- `NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；输入表达式：`State(d, "VENERABLE_TEA_SET")`；返回值紧邻使用处：`IsPatternExpressionSyntax: State(d, "VENERABLE_TEA_SET") is { Charge: > 0 } tea`
- `NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；输入表达式：`State(d, "WINGED_BOOTS")`；返回值紧邻使用处：`IsPatternExpressionSyntax: State(d, "WINGED_BOOTS") is { Uses: > 0 }`
- `NationalSpire.CareerRelics.Use(NationalSpire.CareerData, string)`；输入表达式：`Use(d, "WINGED_BOOTS")`；返回值紧邻使用处：`ExpressionStatementSyntax: Use(d, "WINGED_BOOTS");`
- `NationalSpire.CareerRelics.Use(NationalSpire.CareerData, string)`；输入表达式：`Use(d, id)`；返回值紧邻使用处：`ExpressionStatementSyntax: Use(d, id);`
- `NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`CareerTraining.IsTraining(a)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CareerTraining.IsTraining(a)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`Discounts(d, a).ToList()`；返回值紧邻使用处：`ForEachVariableStatementSyntax: foreach (var (id, amount) in Discounts(d, a).ToList())          {              int used = Math.Min(budget, amount); if (used <= 0) continue; budget -= used;              if (id == "rest") { d.Life.Preparation = 0; continue; }              if (id == "facilities") continue;              if (id == "ANCHOR") d.Life.Figurines[id].Season = d.Season;              if (id == "CENTENNIAL_PUZZLE") d.Life.Figurines[id].Charge = 0;              Use(d, id);          }`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(budget, amount)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(budget, amount)`

**赋值（含属性/字段和局部值）：**

- `budget` -= `used`
- `d.Life.Figurines[id].Charge` = `0`
- `d.Life.Figurines[id].Season` = `d.Season`
- `d.Life.Preparation` = `0`
- `tea.Charge` = `0`

<a id="symbol-4da6df64d860"></a>

## `NationalSpire.CareerRelics.Training(NationalSpire.CareerData, NationalSpire.LifeActivity) — public static int Training(CareerData d, LifeActivity a)`

来源：源码第 146 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerLife.cs.md#symbol-e559cea1bbf6)

**调用：** [`NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-6618444af155)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；`NationalSpire.FigurineState.Count`；`NationalSpire.LifeActivity.Result`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；输入表达式：`State(d, "KUNAI")`；返回值紧邻使用处：`IsPatternExpressionSyntax: State(d, "KUNAI") is not { } s`

**赋值（含属性/字段和局部值）：**

- `a.Result` += `"苦无手办带来的训练资源增加 $200。"`

<a id="symbol-2a0ab3c0872b"></a>

## `NationalSpire.CareerRelics.Business(NationalSpire.CareerData, NationalSpire.LifeActivity, int) — public static int Business(CareerData d, LifeActivity a, int revenue)`

来源：源码第 151 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerLife.cs.md#symbol-e559cea1bbf6)

**调用：** [`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerRelics.Has(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-7b703fddee2f)；[`NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-6618444af155)；[`NationalSpire.CareerRelics.Use(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-cb2cae9459ee)；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerRelics.Has(NationalSpire.CareerData, string)`；`NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；`NationalSpire.CareerRelics.Use(NationalSpire.CareerData, string)`；`NationalSpire.FigurineState.Uses`；`NationalSpire.LifeActivity.Cost`；`NationalSpire.LifeActivity.Result`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(benefit)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(benefit)}`
- `NationalSpire.CareerRelics.Has(NationalSpire.CareerData, string)`；输入表达式：`Has(d, "GOLDEN_PEARL")`；返回值紧邻使用处：`BinaryExpressionSyntax: delta > 0 && Has(d, "GOLDEN_PEARL")`
- `NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；输入表达式：`State(d, "TUNGSTEN_ROD")`；返回值紧邻使用处：`IsPatternExpressionSyntax: State(d, "TUNGSTEN_ROD") is { Uses: > 0 }`
- `NationalSpire.CareerRelics.Use(NationalSpire.CareerData, string)`；输入表达式：`Use(d, "TUNGSTEN_ROD")`；返回值紧邻使用处：`ExpressionStatementSyntax: Use(d, "TUNGSTEN_ROD");`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(10, delta / 20)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(10, delta / 20)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(15, -delta / 5)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(15, -delta / 5)`

**赋值（含属性/字段和局部值）：**

- `a.Result` += `$"金色珍珠手办额外带来 {CareerMoney.Format(benefit)}。"`
- `a.Result` += `$"钨合金棍手办补回 {CareerMoney.Format(benefit)}。"`

<a id="symbol-f756311e9342"></a>

## `NationalSpire.CareerRelics.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity) — public static void Complete(CareerData d, LifeActivity a)`

来源：源码第 163 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerLife.cs.md#symbol-e559cea1bbf6)

**调用：** [`Fans(string, int, int, int)`](CareerRelics.cs.md#symbol-df4fb4332deb)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`](LifeData.cs.md#symbol-54a09649188b)；[`NationalSpire.CareerRelics.Roll(NationalSpire.CareerData, string, int, int)`](CareerRelics.cs.md#symbol-c1cf7133742f)；[`NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-6618444af155)；[`NationalSpire.PrivateMessages.ChangeFavour(NationalSpire.CareerData, string, int)`](PrivateMessages.cs.md#symbol-c703192e56c0)；`string.Contains(string)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `Fans(string, int, int, int)`；`NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Activities`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；`NationalSpire.CareerRelics.Catalog`；`NationalSpire.CareerRelics.Item.Id`；`NationalSpire.CareerRelics.Item.Name`；`NationalSpire.CareerRelics.Roll(NationalSpire.CareerData, string, int, int)`；`NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；`NationalSpire.FigurineState.Charge`；`NationalSpire.FigurineState.Count`；`NationalSpire.FigurineState.SocialRewards`；`NationalSpire.LifeActivity.Id`；`NationalSpire.LifeActivity.Kind`；`NationalSpire.LifeActivity.PersonId`；`NationalSpire.LifeActivity.Result`；`NationalSpire.PrivateMessages.ChangeFavour(NationalSpire.CareerData, string, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Fans(string, int, int, int)`；输入表达式：`Fans("LETTER_OPENER", 3, 20, 35)`；返回值紧邻使用处：`ExpressionStatementSyntax: Fans("LETTER_OPENER", 3, 20, 35);`
- `Fans(string, int, int, int)`；输入表达式：`Fans("PEN_NIB", 2, 12, 20)`；返回值紧邻使用处：`ExpressionStatementSyntax: Fans("PEN_NIB", 2, 12, 20);`
- `Fans(string, int, int, int)`；输入表达式：`Fans("SHURIKEN", 3, 20, 35)`；返回值紧邻使用处：`ExpressionStatementSyntax: Fans("SHURIKEN", 3, 20, 35);`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(amount)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(amount)}`
- `NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；输入表达式：`CareerMoney.Record(d, "开心小花手办回馈", amount)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Record(d, "开心小花手办回馈", amount);`
- `NationalSpire.CareerRelics.Roll(NationalSpire.CareerData, string, int, int)`；输入表达式：`Roll(d, a.Id + "flower", 3, 6)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Roll(d, a.Id + "flower", 3, 6)`
- `NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；输入表达式：`State(d, "HAPPY_FLOWER")`；返回值紧邻使用处：`IsPatternExpressionSyntax: State(d, "HAPPY_FLOWER") is { } flower`
- `NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；输入表达式：`State(d, "JEWELED_MASK")`；返回值紧邻使用处：`IsPatternExpressionSyntax: State(d, "JEWELED_MASK") is { } mask`
- `NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；输入表达式：`State(d, id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: State(d, id) is { } s`
- `NationalSpire.PrivateMessages.ChangeFavour(NationalSpire.CareerData, string, int)`；输入表达式：`PrivateMessages.ChangeFavour(d, a.PersonId, 3)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateMessages.ChangeFavour(d, a.PersonId, 3);`
- `string.Contains(string)`；输入表达式：`x.Result.Contains("宝石面具手办")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: x => x.Result.Contains("宝石面具手办")`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`mask.SocialRewards.Add(a.PersonId)`；返回值紧邻使用处：`IfStatementSyntax: if (mask.SocialRewards.Add(a.PersonId))              { PrivateMessages.ChangeFavour(d, a.PersonId, 3); a.Result += "宝石面具手办：好感额外增加 3。"; }`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`Catalog.First(r => r.Id == id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Catalog.First(r => r.Id == id).Name`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.Life.Activities.Where(x => x.Result.Contains("宝石面具手办"))                  .Select(x => x.PersonId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Activities.Where(x => x.Result.Contains("宝石面具手办"))                  .Select(x => x.PersonId).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`d.Life.Activities.Where(x => x.Result.Contains("宝石面具手办"))                  .Select(x => x.PersonId).ToHashSet()`；返回值紧邻使用处：`AssignmentExpressionSyntax: mask.SocialRewards ??= d.Life.Activities.Where(x => x.Result.Contains("宝石面具手办"))                  .Select(x => x.PersonId).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Activities.Where(x => x.Result.Contains("宝石面具手办"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Activities.Where(x => x.Result.Contains("宝石面具手办"))                  .Select`

**赋值（含属性/字段和局部值）：**

- `a.Result` += `"宝石面具手办：好感额外增加 3。"`
- `a.Result` += `$"开心小花手办带来 {CareerMoney.Format(amount)}。"`
- `a.Result` += `Catalog.First(r => r.Id == id).Name + "手办的效果已准备。"`
- `d.Credits` += `amount`
- `mask.SocialRewards` ??= `d.Life.Activities.Where(x => x.Result.Contains("宝石面具手办"))                  .Select(x => x.PersonId).ToHashSet()`
- `s.Charge` = `id == "REGAL_PILLOW" ? 2 : 1`

<a id="symbol-df4fb4332deb"></a>

## `Fans(string, int, int, int) — void Fans(string id, int interval, int min, int max)`

来源：源码第 165 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerRelics.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-f756311e9342)

**调用：** [`NationalSpire.CareerRelics.Roll(NationalSpire.CareerData, string, int, int)`](CareerRelics.cs.md#symbol-c1cf7133742f)；[`NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-6618444af155)；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Fans`；`NationalSpire.CareerRelics.Catalog`；`NationalSpire.CareerRelics.Item.Id`；`NationalSpire.CareerRelics.Item.Name`；`NationalSpire.CareerRelics.Roll(NationalSpire.CareerData, string, int, int)`；`NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；`NationalSpire.FigurineState.Count`；`NationalSpire.LifeActivity.Id`；`NationalSpire.LifeActivity.Result`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerRelics.Roll(NationalSpire.CareerData, string, int, int)`；输入表达式：`Roll(d, a.Id + id, min, max)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Roll(d, a.Id + id, min, max)`
- `NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；输入表达式：`State(d, id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: State(d, id) is not { } s`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`Catalog.First(r => r.Id == id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Catalog.First(r => r.Id == id).Name`

**赋值（含属性/字段和局部值）：**

- `a.Result` += `$"{Catalog.First(r => r.Id == id).Name}手办：额外增加 {n} 位关注者。"`
- `d.Fans` += `n`

<a id="symbol-6e6e3fa2b1d4"></a>

## `NationalSpire.CareerRelics.Match(NationalSpire.CareerData, NationalSpire.CareerMatch, NationalSpire.CareerResult, bool, int) — public static void Match(CareerData d, CareerMatch m, CareerResult result, bool abandoned, int oldRating)`

来源：源码第 191 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool)`](CareerEngine.cs.md#symbol-2cb7c2afebf9)；[`NationalSpire.Coop.CoopRules.Settle(NationalSpire.Coop.CoopWorld, string, bool, bool, int, double, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer>, System.Collections.Generic.Dictionary<ulong, NationalSpire.CareerResult>?, bool, bool)`](Coop/CoopRules.cs.md#symbol-ad906fb9e519)

**调用：** [`Cash(string, int, int)`](CareerRelics.cs.md#symbol-5396043b0c0f)；[`NationalSpire.CareerRelics.Has(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-7b703fddee2f)；[`NationalSpire.CareerRelics.Roll(NationalSpire.CareerData, string, int, int)`](CareerRelics.cs.md#symbol-c1cf7133742f)；[`NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-6618444af155)；[`NationalSpire.CareerRelics.Use(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-cb2cae9459ee)；[`Protect(string, int)`](CareerRelics.cs.md#symbol-a66041c527e0)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `Cash(string, int, int)`；`NationalSpire.CareerData.Fans`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerLifeState.Activities`；`NationalSpire.CareerMatch.Draw`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CareerMatch.PlayerWon`；`NationalSpire.CareerMatch.RequiredAscension`；`NationalSpire.CareerRelics.Has(NationalSpire.CareerData, string)`；`NationalSpire.CareerRelics.Roll(NationalSpire.CareerData, string, int, int)`；`NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；`NationalSpire.CareerRelics.Use(NationalSpire.CareerData, string)`；`NationalSpire.CareerResult.Evidence`；`NationalSpire.CareerResult.LifeEffects`；`NationalSpire.FigurineState.Charge`；`NationalSpire.FigurineState.Season`；`NationalSpire.FigurineState.Uses`；`NationalSpire.LifeActivity.Status`；`NationalSpire.RunEvidence.PotionsRecorded`；`NationalSpire.RunEvidence.RemainingPotions`；`Protect(string, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Cash(string, int, int)`；输入表达式：`Cash("POTION_BELT", 2, 4)`；返回值紧邻使用处：`ExpressionStatementSyntax: Cash("POTION_BELT", 2, 4);`
- `Cash(string, int, int)`；输入表达式：`Cash("WHITE_STAR", 8, 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: Cash("WHITE_STAR", 8, 12);`
- `NationalSpire.CareerRelics.Has(NationalSpire.CareerData, string)`；输入表达式：`Has(d, "BURNING_BLOOD")`；返回值紧邻使用处：`IfStatementSyntax: if (Has(d, "BURNING_BLOOD")) Protect("BURNING_BLOOD", Roll(d, m.Id + "blood", 1, 2));`
- `NationalSpire.CareerRelics.Has(NationalSpire.CareerData, string)`；输入表达式：`Has(d, "ORICHALCUM")`；返回值紧邻使用处：`BinaryExpressionSyntax: Has(d, "ORICHALCUM") && !d.Life.Activities.Any(a => a.Status == "进行中")`
- `NationalSpire.CareerRelics.Has(NationalSpire.CareerData, string)`；输入表达式：`Has(d, "SLING_OF_COURAGE")`；返回值紧邻使用处：`BinaryExpressionSyntax: m.PlayerWon && m.RequiredAscension >= 8 && Has(d, "SLING_OF_COURAGE")`
- `NationalSpire.CareerRelics.Roll(NationalSpire.CareerData, string, int, int)`；输入表达式：`Roll(d, m.Id + "blood", 1, 2)`；返回值紧邻使用处：`ArgumentSyntax: Roll(d, m.Id + "blood", 1, 2)`
- `NationalSpire.CareerRelics.Roll(NationalSpire.CareerData, string, int, int)`；输入表达式：`Roll(d, m.Id + "sling", 5, 10)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Roll(d, m.Id + "sling", 5, 10)`
- `NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；输入表达式：`State(d, "CENTENNIAL_PUZZLE")`；返回值紧邻使用处：`IsPatternExpressionSyntax: State(d, "CENTENNIAL_PUZZLE") is { } puzzle`
- `NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；输入表达式：`State(d, "POTION_BELT")`；返回值紧邻使用处：`IsPatternExpressionSyntax: State(d, "POTION_BELT") is { Uses: > 0 }`
- `NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；输入表达式：`State(d, "REGAL_PILLOW")`；返回值紧邻使用处：`IsPatternExpressionSyntax: State(d, "REGAL_PILLOW") is { Charge: > 0 } pillow`
- `NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；输入表达式：`State(d, "REGAL_PILLOW")`；返回值紧邻使用处：`IsPatternExpressionSyntax: State(d, "REGAL_PILLOW") is { Charge: > 0 }`
- `NationalSpire.CareerRelics.State(NationalSpire.CareerData, string)`；输入表达式：`State(d, "WHITE_STAR")`；返回值紧邻使用处：`IsPatternExpressionSyntax: State(d, "WHITE_STAR") is { } star`
- `NationalSpire.CareerRelics.Use(NationalSpire.CareerData, string)`；输入表达式：`Use(d, "POTION_BELT")`；返回值紧邻使用处：`ExpressionStatementSyntax: Use(d, "POTION_BELT");`
- `Protect(string, int)`；输入表达式：`Protect("BURNING_BLOOD", Roll(d, m.Id + "blood", 1, 2))`；返回值紧邻使用处：`ExpressionStatementSyntax: Protect("BURNING_BLOOD", Roll(d, m.Id + "blood", 1, 2));`
- `Protect(string, int)`；输入表达式：`Protect("ORICHALCUM", 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: Protect("ORICHALCUM", 1);`
- `Protect(string, int)`；输入表达式：`Protect("REGAL_PILLOW", 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: Protect("REGAL_PILLOW", 1);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Activities.Any(a => a.Status == "进行中")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.Life.Activities.Any(a => a.Status == "进行中")`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.LifeEffects.Add("百年积木手办：下次内容制作可减免 $100。")`；返回值紧邻使用处：`ExpressionStatementSyntax: result.LifeEffects.Add("百年积木手办：下次内容制作可减免 $100。");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.LifeEffects.Add($"勇气投石索手办：额外增加 {n} 位关注者。")`；返回值紧邻使用处：`ExpressionStatementSyntax: result.LifeEffects.Add($"勇气投石索手办：额外增加 {n} 位关注者。");`

**赋值（含属性/字段和局部值）：**

- `d.Fans` += `n`
- `puzzle.Charge` = `1`
- `puzzle.Season` = `d.Season`
- `star.Season` = `d.Season`

<a id="symbol-a66041c527e0"></a>

## `Protect(string, int) — void Protect(string id, int amount)`

来源：源码第 195 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerRelics.Match(NationalSpire.CareerData, NationalSpire.CareerMatch, NationalSpire.CareerResult, bool, int)`](CareerRelics.cs.md#symbol-6e6e3fa2b1d4)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Math.Max(int, int)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Rating`；`NationalSpire.CareerRelics.Catalog`；`NationalSpire.CareerRelics.Item.Id`；`NationalSpire.CareerRelics.Item.Name`；`NationalSpire.CareerResult.LifeEffects`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`Catalog.First(r => r.Id == id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Catalog.First(r => r.Id == id).Name`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.LifeEffects.Add(Catalog.First(r => r.Id == id).Name + $"手办：本场少扣 {n} 点生涯评分。")`；返回值紧邻使用处：`ExpressionStatementSyntax: result.LifeEffects.Add(Catalog.First(r => r.Id == id).Name + $"手办：本场少扣 {n} 点生涯评分。");`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, Math.Min(3 - protection, oldRating - d.Rating))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, Math.Min(3 - protection, oldRating - d.Rating))`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(3 - protection, oldRating - d.Rating)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(3 - protection, oldRating - d.Rating)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(amount, Math.Max(0, Math.Min(3 - protection, oldRating - d.Rating)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(amount, Math.Max(0, Math.Min(3 - protection, oldRating - d.Rating)))`

**赋值（含属性/字段和局部值）：**

- `d.Rating` += `n`
- `protection` += `n`

<a id="symbol-5396043b0c0f"></a>

## `Cash(string, int, int) — void Cash(string id, int min, int max)`

来源：源码第 207 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerRelics.Match(NationalSpire.CareerData, NationalSpire.CareerMatch, NationalSpire.CareerResult, bool, int)`](CareerRelics.cs.md#symbol-6e6e3fa2b1d4)

**调用：** [`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerRelics.Roll(NationalSpire.CareerData, string, int, int)`](CareerRelics.cs.md#symbol-c1cf7133742f)；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Credits`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerRelics.Catalog`；`NationalSpire.CareerRelics.Item.Id`；`NationalSpire.CareerRelics.Item.Name`；`NationalSpire.CareerRelics.Roll(NationalSpire.CareerData, string, int, int)`；`NationalSpire.CareerResult.LifeEffects`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(amount)`；返回值紧邻使用处：`BinaryExpressionSyntax: Catalog.First(r => r.Id == id).Name + "手办：纪念展示支持 " + CareerMoney.Format(amount)`
- `NationalSpire.CareerRelics.Roll(NationalSpire.CareerData, string, int, int)`；输入表达式：`Roll(d, m.Id + id, min, max)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Roll(d, m.Id + id, min, max)`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`Catalog.First(r => r.Id == id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Catalog.First(r => r.Id == id).Name`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.LifeEffects.Add(Catalog.First(r => r.Id == id).Name + "手办：纪念展示支持 " + CareerMoney.Format(amount) + "。")`；返回值紧邻使用处：`ExpressionStatementSyntax: result.LifeEffects.Add(Catalog.First(r => r.Id == id).Name + "手办：纪念展示支持 " + CareerMoney.Format(amount) + "。");`

**赋值（含属性/字段和局部值）：**

- `d.Credits` += `amount`
