# ConsumerGifts.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`D0B99DA57110E10531541AF471CA8A195A69637FE7C04CACB080B1E93AEFE156`。来源：[源码](../../ConsumerGifts.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.GiftItem`、`NationalSpire.GiftDelivery`、`NationalSpire.GiftAllocation`、`NationalSpire.GiftPurchase`、`NationalSpire.ConsumerGifts`。

字段、事件及初始值（源码原样）：

```csharp
public const string Kind = "gift", WeddingKind = "wedding-invitation";
public const string Protocol = """
赠礼附件由程序核验库存并送达。仅针对本轮附件中的已送达礼物，结合人物资料、性格、记忆和互动历史逐种给出偏好标记：[Gift: 商品Id, Preference: 1.0, Reason: 具体偏好依据]。
Preference 为0.25至1.75的喜爱倍率；中性1.0，不感兴趣可用0.6，明显喜爱可用1.5。偏好先乘商品单价，得到用于好感计算的等效价值。价格曲线、数量、重复赠送衰减、心情和当前好感由程序统一计算。正文自然回应礼物与留言，标记单独附在正文之后。
本轮含已送达礼物时，好感与状态收益由程序结算，省略Favour和Mood标记，Relationship与Attitude仍可描述实际交往。既往赠礼只作为历史参考。本轮标为已结算的礼物保持原收益。
盛大婚礼邀约沿用活动接受与排期标记；婚礼完成读取程序记录。
""";
```

<a id="symbol-79a8f96e13a6"></a>

## `NationalSpire.GiftItem.GoodId — public string GoodId`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a3b3e305c31a"></a>

## `NationalSpire.GiftItem.Quantity — public int Quantity`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3860fd694400"></a>

## `NationalSpire.GiftItem.UnitPrice — public int UnitPrice`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6a5c78ff4300"></a>

## `NationalSpire.GiftItem.ReceivedBefore — public long ReceivedBefore`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3e92043b257a"></a>

## `NationalSpire.GiftItem.Preference — public double Preference`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-81048bb09be7"></a>

## `NationalSpire.GiftItem.Reason — public string Reason`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6a62d9d5c67a"></a>

## `NationalSpire.GiftDelivery.Items — public List<GiftItem> Items`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e42bafae5b45"></a>

## `NationalSpire.GiftDelivery.Sent — public bool Sent`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6355eea28376"></a>

## `NationalSpire.GiftDelivery.Settled — public bool Settled`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7b92c31fca53"></a>

## `NationalSpire.GiftDelivery.FavourBefore — public int FavourBefore`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-54d98e896bb2"></a>

## `NationalSpire.GiftDelivery.Mood — public double Mood`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-590df2f23f6d"></a>

## `NationalSpire.GiftDelivery.MoodDay — public int MoodDay`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6ac00b1d6375"></a>

## `NationalSpire.GiftDelivery.FavourGain — public int FavourGain`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7de1f91b59e5"></a>

## `NationalSpire.GiftDelivery.RawGain — public double RawGain`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-bc910f0bccb9"></a>

## `NationalSpire.GiftDelivery.MoodDays — public int MoodDays`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1a4bbed37db2"></a>

## `NationalSpire.ConsumerGifts.ReservedByGood(NationalSpire.CareerData) — public static Dictionary<string, long> ReservedByGood(CareerData data)`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerPurchases.ConsumerPurchases(NationalSpire.CareerData)`](ConsumerPurchases.cs.md#symbol-270a101e0b54)

**调用：** [`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`

**字段、属性、事件及方法组引用：** `NationalSpire.GiftDelivery.Items`；`NationalSpire.GiftItem.GoodId`；`NationalSpire.GiftItem.Quantity`；`NationalSpire.PrivateConversation.GiftDrafts`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateOffer.Gift`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values .SelectMany(c => c.GiftDrafts).SelectMany(a => a.Gift?.Items ?? []).GroupBy(i => i.GoodId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations.Values .SelectMany(c => c.GiftDrafts).SelectMany(a => a.Gift?.Items ?? []).GroupBy(i => i.GoodId).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values .SelectMany(c => c.GiftDrafts)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations.Values .SelectMany(c => c.GiftDrafts).SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values .SelectMany(c => c.GiftDrafts).SelectMany(a => a.Gift?.Items ?? [])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations.Values .SelectMany(c => c.GiftDrafts).SelectMany(a => a.Gift?.Items ?? []).GroupBy`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；输入表达式：`g.Sum(i => (long)i.Quantity)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.Sum(i => (long)i.Quantity)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values .SelectMany(c => c.GiftDrafts).SelectMany(a => a.Gift?.Items ?? []).GroupBy(i => i.GoodId).ToDictionary(g => g.Key, g => g.Sum(i => (long)i.Quantity))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => PrivateMessages.Mailbox(data).Conversations.Values .SelectMany(c => c.GiftDrafts).SelectMany(a => a.Gift?.Items ?? []).GroupBy(i => i.GoodId).ToDictionary(g => g.Key, g => g.Sum(i => (long)i.Quantity))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2fbb2fd87ea5"></a>

## `NationalSpire.ConsumerGifts.Reserved(NationalSpire.CareerData, string, string) — public static long Reserved(CareerData data, string good, string except = "")`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerGifts.Available(NationalSpire.CareerData, string, string)`](ConsumerGifts.cs.md#symbol-da833f356cc6)

**调用：** [`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.GiftDelivery.Items`；`NationalSpire.GiftItem.GoodId`；`NationalSpire.GiftItem.Quantity`；`NationalSpire.PrivateConversation.GiftDrafts`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateOffer.Gift`；`NationalSpire.PrivateOffer.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values .SelectMany(c => c.GiftDrafts)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations.Values .SelectMany(c => c.GiftDrafts).Where`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values .SelectMany(c => c.GiftDrafts).Where(a => a.Id != except).SelectMany(a => a.Gift?.Items ?? [])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations.Values .SelectMany(c => c.GiftDrafts).Where(a => a.Id != except).SelectMany(a => a.Gift?.Items ?? []).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values .SelectMany(c => c.GiftDrafts).Where(a => a.Id != except).SelectMany(a => a.Gift?.Items ?? []).Where(i => i.GoodId == good).Sum(i => (long)i.Quantity)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => PrivateMessages.Mailbox(data).Conversations.Values .SelectMany(c => c.GiftDrafts).Where(a => a.Id != except).SelectMany(a => a.Gift?.Items ?? []).Where(i => i.GoodId == good).Sum(i => (long)i.Quantity)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values .SelectMany(c => c.GiftDrafts).Where(a => a.Id != except)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations.Values .SelectMany(c => c.GiftDrafts).Where(a => a.Id != except).SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values .SelectMany(c => c.GiftDrafts).Where(a => a.Id != except).SelectMany(a => a.Gift?.Items ?? []).Where(i => i.GoodId == good)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations.Values .SelectMany(c => c.GiftDrafts).Where(a => a.Id != except).SelectMany(a => a.Gift?.Items ?? []).Where(i => i.GoodId == good).Sum`

**赋值（含属性/字段和局部值）：**


<a id="symbol-da833f356cc6"></a>

## `NationalSpire.ConsumerGifts.Available(NationalSpire.CareerData, string, string) — public static int Available(CareerData data, string good, string except = "")`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)；[`NationalSpire.CareerScreen.GiftRecipientPicker(NationalSpire.CareerData, NationalSpire.Good, int, bool, string?, int, bool)`](ConsumerGiftScreen.cs.md#symbol-55244dcd20ef)；[`NationalSpire.CareerScreen.PrivateGiftPicker()`](ConsumerGiftScreen.cs.md#symbol-53b0d3e663d2)；[`NationalSpire.ConsumerGifts.Purchase(NationalSpire.CareerData, NationalSpire.GiftPurchase)`](ConsumerGifts.cs.md#symbol-a6de00bbf8fa)；[`NationalSpire.ConsumerGifts.Validate(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool)`](ConsumerGifts.cs.md#symbol-cfd7b7ca0a55)

**调用：** [`NationalSpire.ConsumerGifts.Reserved(NationalSpire.CareerData, string, string)`](ConsumerGifts.cs.md#symbol-2fbb2fd87ea5)；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Math.Max(long, long)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.ConsumerGifts.Reserved(NationalSpire.CareerData, string, string)`；`NationalSpire.ConsumerState.GiftStock`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerGifts.Reserved(NationalSpire.CareerData, string, string)`；输入表达式：`Reserved(data, good, except)`；返回值紧邻使用处：`BinaryExpressionSyntax: data.Life.Consumer.GiftStock.GetValueOrDefault(good) - Reserved(data, good, except)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`data.Life.Consumer.GiftStock.GetValueOrDefault(good)`；返回值紧邻使用处：`BinaryExpressionSyntax: data.Life.Consumer.GiftStock.GetValueOrDefault(good) - Reserved(data, good, except)`
- `System.Math.Max(long, long)`；输入表达式：`Math.Max(0, data.Life.Consumer.GiftStock.GetValueOrDefault(good) - Reserved(data, good, except))`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Max(0, data.Life.Consumer.GiftStock.GetValueOrDefault(good) - Reserved(data, good, except))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0819c021af70"></a>

## `NationalSpire.ConsumerGifts.RecipientError(NationalSpire.CareerData, string, string) — public static string? RecipientError(CareerData data, string person, string good)`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateGiftPicker()`](ConsumerGiftScreen.cs.md#symbol-53b0d3e663d2)；[`NationalSpire.ConsumerGifts.Validate(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool)`](ConsumerGifts.cs.md#symbol-cfd7b7ca0a55)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.ConsumerGifts.Eligibility(NationalSpire.CareerData, NationalSpire.CareerPerson, string)`](ConsumerGifts.cs.md#symbol-ec5881944d5f)；[`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.ConsumerGifts.Eligibility(NationalSpire.CareerData, NationalSpire.CareerPerson, string)`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, person)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(data, person)!`
- `NationalSpire.ConsumerGifts.Eligibility(NationalSpire.CareerData, NationalSpire.CareerPerson, string)`；输入表达式：`Eligibility(data, CareerEngine.Person(data, person)!, good)`；返回值紧邻使用处：`ReturnStatementSyntax: return Eligibility(data, CareerEngine.Person(data, person)!, good);`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(data, person)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateMessages.CanChat(data, person)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-83e1975639f6"></a>

## `NationalSpire.ConsumerGifts.Recipients(NationalSpire.CareerData, string) — public static IEnumerable<CareerPerson> Recipients(CareerData data, string good)`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.GiftRecipientPicker(NationalSpire.CareerData, NationalSpire.Good, int, bool, string?, int, bool)`](ConsumerGiftScreen.cs.md#symbol-55244dcd20ef)

**调用：** [`NationalSpire.ConsumerGifts.Eligibility(NationalSpire.CareerData, NationalSpire.CareerPerson, string)`](ConsumerGifts.cs.md#symbol-ec5881944d5f)；[`NationalSpire.PrivateMessages.ChatCandidates(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-a6a32e618e4c)；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerGifts.Eligibility(NationalSpire.CareerData, NationalSpire.CareerPerson, string)`；`NationalSpire.PrivateMessages.ChatCandidates(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerGifts.Eligibility(NationalSpire.CareerData, NationalSpire.CareerPerson, string)`；输入表达式：`Eligibility(data, p, good)`；返回值紧邻使用处：`BinaryExpressionSyntax: Eligibility(data, p, good) == null`
- `NationalSpire.PrivateMessages.ChatCandidates(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.ChatCandidates(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.ChatCandidates(data).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.ChatCandidates(data).Where(p => Eligibility(data, p, good) == null)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => PrivateMessages.ChatCandidates(data).Where(p => Eligibility(data, p, good) == null)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ec5881944d5f"></a>

## `NationalSpire.ConsumerGifts.Eligibility(NationalSpire.CareerData, NationalSpire.CareerPerson, string) — private static string? Eligibility(CareerData data, CareerPerson person, string good)`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerGifts.RecipientError(NationalSpire.CareerData, string, string)`](ConsumerGifts.cs.md#symbol-0819c021af70)；[`NationalSpire.ConsumerGifts.Recipients(NationalSpire.CareerData, string)`](ConsumerGifts.cs.md#symbol-83e1975639f6)

**调用：** [`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`NationalSpire.PrivateRelation.PrivateRelation()`；[`NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`](SpireArbitration.cs.md#symbol-909e0981d663)；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.Id`；`NationalSpire.PrivateMailbox.Relations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateRelation.Appearance`；`NationalSpire.PrivateRelation.Favour`；`NationalSpire.RelationshipAppearance.Lover`；`NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Relations`
- `NationalSpire.PrivateRelation.PrivateRelation()`；输入表达式：`new()`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(person.Id) ?? new()`
- `NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`；输入表达式：`SpireArbitration.Muted(person)`；返回值紧邻使用处：`IfStatementSyntax: if (SpireArbitration.Muted(person)) return "该角色账号已封禁。";`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(person.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(person.Id) ?? new()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-719a54192f66"></a>

## `NationalSpire.ConsumerGifts.Draft(System.Collections.Generic.IEnumerable<NationalSpire.GiftItem>) — public static PrivateOffer Draft(IEnumerable<GiftItem> items)`

来源：源码第 54 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateGiftPicker()`](ConsumerGiftScreen.cs.md#symbol-53b0d3e663d2)；[`NationalSpire.ConsumerGifts.AddDraft(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](ConsumerGifts.cs.md#symbol-d1718ad8f95a)；[`NationalSpire.ConsumerGifts.Purchase(NationalSpire.CareerData, NationalSpire.GiftPurchase)`](ConsumerGifts.cs.md#symbol-a6de00bbf8fa)

**调用：** `NationalSpire.GiftDelivery.GiftDelivery()`；`NationalSpire.GiftItem.GiftItem()`；`NationalSpire.PrivateOffer.PrivateOffer()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerGifts.Kind`；`NationalSpire.GiftDelivery.Items`；`NationalSpire.GiftItem.GoodId`；`NationalSpire.GiftItem.Quantity`；`NationalSpire.PrivateOffer.Gift`；`NationalSpire.PrivateOffer.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GiftDelivery.GiftDelivery()`；输入表达式：`new() { Items = items.Select(i => new GiftItem { GoodId = i.GoodId, Quantity = i.Quantity }).ToList() }`；返回值紧邻使用处：`AssignmentExpressionSyntax: Gift = new() { Items = items.Select(i => new GiftItem { GoodId = i.GoodId, Quantity = i.Quantity }).ToList() }`
- `NationalSpire.GiftItem.GiftItem()`；输入表达式：`new GiftItem { GoodId = i.GoodId, Quantity = i.Quantity }`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: i => new GiftItem { GoodId = i.GoodId, Quantity = i.Quantity }`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new() { Kind = Kind, Gift = new() { Items = items.Select(i => new GiftItem { GoodId = i.GoodId, Quantity = i.Quantity }).ToList() } }`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new() { Kind = Kind, Gift = new() { Items = items.Select(i => new GiftItem { GoodId = i.GoodId, Quantity = i.Quantity }).ToList() } }`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`items.Select(i => new GiftItem { GoodId = i.GoodId, Quantity = i.Quantity })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: items.Select(i => new GiftItem { GoodId = i.GoodId, Quantity = i.Quantity }).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`items.Select(i => new GiftItem { GoodId = i.GoodId, Quantity = i.Quantity }).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Items = items.Select(i => new GiftItem { GoodId = i.GoodId, Quantity = i.Quantity }).ToList()`

**赋值（含属性/字段和局部值）：**

- `Gift` = `new() { Items = items.Select(i => new GiftItem { GoodId = i.GoodId, Quantity = i.Quantity }).ToList() }`
- `GoodId` = `i.GoodId`
- `Items` = `items.Select(i => new GiftItem { GoodId = i.GoodId, Quantity = i.Quantity }).ToList()`
- `Kind` = `Kind`
- `Quantity` = `i.Quantity`

<a id="symbol-bc3ad22e88d3"></a>

## `NationalSpire.ConsumerGifts.Summary(NationalSpire.GiftDelivery) — public static string Summary(GiftDelivery gift)`

来源：源码第 55 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`](PrivateMemoryScreen.cs.md#symbol-eb2b2a37c5d1)；[`NationalSpire.CareerScreen.PrivateAttachmentHeading(NationalSpire.PrivateOffer)`](PrivateMemoryScreen.cs.md#symbol-a28ca2e86dec)；[`NationalSpire.ConsumerGifts.AddDraft(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](ConsumerGifts.cs.md#symbol-d1718ad8f95a)；[`NationalSpire.ConsumerGifts.Context(NationalSpire.PrivateOffer)`](ConsumerGifts.cs.md#symbol-83cb4fa73c82)；[`NationalSpire.ConsumerGifts.Deliver(NationalSpire.CareerData, string, NationalSpire.PrivateTurn)`](ConsumerGifts.cs.md#symbol-f73281d28d02)；[`NationalSpire.ConsumerGifts.Purchase(NationalSpire.CareerData, NationalSpire.GiftPurchase)`](ConsumerGifts.cs.md#symbol-a6de00bbf8fa)；[`NationalSpire.PrivateMessages.PrepareAttachments(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>)`](PrivateMessages.cs.md#symbol-f2d6d9cf9c86)

**调用：** [`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；[`NationalSpire.ConsumerGifts.Unit(string)`](ConsumerGifts.cs.md#symbol-09a48f16c02e)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.ConsumerGifts.Unit(string)`；`NationalSpire.GiftDelivery.Items`；`NationalSpire.GiftItem.GoodId`；`NationalSpire.GiftItem.Quantity`；`NationalSpire.Good.Name`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(i.GoodId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: ConsumerCatalog.Get(i.GoodId)?.Name`
- `NationalSpire.ConsumerGifts.Unit(string)`；输入表达式：`Unit(i.GoodId)`；返回值紧邻使用处：`BinaryExpressionSyntax: (ConsumerCatalog.Get(i.GoodId)?.Name ?? i.GoodId) + " · " + i.Quantity + " " + Unit(i.GoodId)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`gift.Items.Select(i => (ConsumerCatalog.Get(i.GoodId)?.Name ?? i.GoodId) + " · " + i.Quantity + " " + Unit(i.GoodId))`；返回值紧邻使用处：`ArgumentSyntax: gift.Items.Select(i => (ConsumerCatalog.Get(i.GoodId)?.Name ?? i.GoodId) + " · " + i.Quantity + " " + Unit(i.GoodId))`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", gift.Items.Select(i => (ConsumerCatalog.Get(i.GoodId)?.Name ?? i.GoodId) + " · " + i.Quantity + " " + Unit(i.GoodId)))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => string.Join("\n", gift.Items.Select(i => (ConsumerCatalog.Get(i.GoodId)?.Name ?? i.GoodId) + " · " + i.Quantity + " " + Unit(i.GoodId)))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-09a48f16c02e"></a>

## `NationalSpire.ConsumerGifts.Unit(string) — public static string Unit(string id)`

来源：源码第 56 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerGifts.DefaultMessage(NationalSpire.CareerData, string, NationalSpire.GiftDelivery)`](ConsumerGifts.cs.md#symbol-0269f72cb055)；[`NationalSpire.ConsumerGifts.Summary(NationalSpire.GiftDelivery)`](ConsumerGifts.cs.md#symbol-bc3ad22e88d3)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8b61ffe6301a"></a>

## `NationalSpire.ConsumerGifts.Number(int) — public static string Number(int n)`

来源：源码第 64 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerGifts.DefaultMessage(NationalSpire.CareerData, string, NationalSpire.GiftDelivery)`](ConsumerGifts.cs.md#symbol-0269f72cb055)

**调用：** `int.ToString(System.IFormatProvider?)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.ToString(System.IFormatProvider?)`；输入表达式：`n.ToString(CultureInfo.InvariantCulture)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: _ => n.ToString(CultureInfo.InvariantCulture)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0269f72cb055"></a>

## `NationalSpire.ConsumerGifts.DefaultMessage(NationalSpire.CareerData, string, NationalSpire.GiftDelivery) — public static string DefaultMessage(CareerData d, string person, GiftDelivery gift)`

来源：源码第 65 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerGifts.Purchase(NationalSpire.CareerData, NationalSpire.GiftPurchase)`](ConsumerGifts.cs.md#symbol-a6de00bbf8fa)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；[`NationalSpire.ConsumerGifts.Number(int)`](ConsumerGifts.cs.md#symbol-8b61ffe6301a)；[`NationalSpire.ConsumerGifts.Unit(string)`](ConsumerGifts.cs.md#symbol-09a48f16c02e)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.ConsumerGifts.Number(int)`；`NationalSpire.ConsumerGifts.Unit(string)`；`NationalSpire.GiftDelivery.Items`；`NationalSpire.GiftItem.GoodId`；`NationalSpire.GiftItem.Quantity`；`NationalSpire.Good.Name`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, person)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.DisplayName(d, person)}`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.Name(d)}`
- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(i.GoodId)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: ConsumerCatalog.Get(i.GoodId)!`
- `NationalSpire.ConsumerGifts.Number(int)`；输入表达式：`Number(i.Quantity)`；返回值紧邻使用处：`BinaryExpressionSyntax: Number(i.Quantity) + Unit(i.GoodId)`
- `NationalSpire.ConsumerGifts.Unit(string)`；输入表达式：`Unit(i.GoodId)`；返回值紧邻使用处：`BinaryExpressionSyntax: Number(i.Quantity) + Unit(i.GoodId)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`gift.Items.Any(i => i.GoodId == "oath-ring" && i.Quantity > 1)`；返回值紧邻使用处：`ConditionalExpressionSyntax: gift.Items.Any(i => i.GoodId == "oath-ring" && i.Quantity > 1) ? $"（{CareerEngine.DisplayName(d, person)}被赠送了多枚戒指。）" : ""`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`gift.Items.Select(i => Number(i.Quantity) + Unit(i.GoodId) + ConsumerCatalog.Get(i.GoodId)!.Name)`；返回值紧邻使用处：`ArgumentSyntax: gift.Items.Select(i => Number(i.Quantity) + Unit(i.GoodId) + ConsumerCatalog.Get(i.GoodId)!.Name)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", gift.Items.Select(i => Number(i.Quantity) + Unit(i.GoodId) + ConsumerCatalog.Get(i.GoodId)!.Name))`；返回值紧邻使用处：`BinaryExpressionSyntax: $"（{CareerEngine.Name(d)}向{CareerEngine.DisplayName(d, person)}赠送了" + string.Join("、", gift.Items.Select(i => Number(i.Quantity) + Unit(i.GoodId) + ConsumerCatalog.Get(i.GoodId)!.Name))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-cfd7b7ca0a55"></a>

## `NationalSpire.ConsumerGifts.Validate(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool) — public static string? Validate(CareerData d, string person, PrivateOffer attachment, bool inventory = true)`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateGiftPicker()`](ConsumerGiftScreen.cs.md#symbol-53b0d3e663d2)；[`NationalSpire.ConsumerGifts.AddDraft(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](ConsumerGifts.cs.md#symbol-d1718ad8f95a)；[`NationalSpire.ConsumerGifts.PrepareSend(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>)`](ConsumerGifts.cs.md#symbol-cd4a57ed25ab)；[`NationalSpire.ConsumerGifts.Purchase(NationalSpire.CareerData, NationalSpire.GiftPurchase)`](ConsumerGifts.cs.md#symbol-a6de00bbf8fa)

**调用：** [`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；[`NationalSpire.ConsumerGifts.Available(NationalSpire.CareerData, string, string)`](ConsumerGifts.cs.md#symbol-da833f356cc6)；[`NationalSpire.ConsumerGifts.RecipientError(NationalSpire.CareerData, string, string)`](ConsumerGifts.cs.md#symbol-0819c021af70)；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerCatalog.All`；`NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.ConsumerGifts.Available(NationalSpire.CareerData, string, string)`；`NationalSpire.ConsumerGifts.Kind`；`NationalSpire.ConsumerGifts.RecipientError(NationalSpire.CareerData, string, string)`；`NationalSpire.GiftDelivery.Items`；`NationalSpire.GiftDelivery.Sent`；`NationalSpire.GiftItem.GoodId`；`NationalSpire.GiftItem.Quantity`；`NationalSpire.Good.Giftable`；`NationalSpire.PrivateOffer.Gift`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(item.GoodId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ConsumerCatalog.Get(item.GoodId) is not { Giftable: true }`
- `NationalSpire.ConsumerGifts.Available(NationalSpire.CareerData, string, string)`；输入表达式：`Available(d, item.GoodId, attachment.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: item.Quantity > Available(d, item.GoodId, attachment.Id)`
- `NationalSpire.ConsumerGifts.RecipientError(NationalSpire.CareerData, string, string)`；输入表达式：`RecipientError(d, person, item.GoodId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: RecipientError(d, person, item.GoodId) is { } error`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`gift.Items.Select(i => i.GoodId).Distinct().Count()`；返回值紧邻使用处：`BinaryExpressionSyntax: gift.Items.Select(i => i.GoodId).Distinct().Count() != gift.Items.Count`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`gift.Items.Select(i => i.GoodId).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: gift.Items.Select(i => i.GoodId).Distinct().Count`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`gift.Items.Select(i => i.GoodId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: gift.Items.Select(i => i.GoodId).Distinct`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d1718ad8f95a"></a>

## `NationalSpire.ConsumerGifts.AddDraft(NationalSpire.CareerData, string, NationalSpire.PrivateOffer) — public static string? AddDraft(CareerData d, string person, PrivateOffer input)`

来源：源码第 80 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)

**调用：** [`NationalSpire.ConsumerGifts.Draft(System.Collections.Generic.IEnumerable<NationalSpire.GiftItem>)`](ConsumerGifts.cs.md#symbol-719a54192f66)；[`NationalSpire.ConsumerGifts.Summary(NationalSpire.GiftDelivery)`](ConsumerGifts.cs.md#symbol-bc3ad22e88d3)；[`NationalSpire.ConsumerGifts.Validate(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool)`](ConsumerGifts.cs.md#symbol-cfd7b7ca0a55)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerGifts.Draft(System.Collections.Generic.IEnumerable<NationalSpire.GiftItem>)`；`NationalSpire.ConsumerGifts.Summary(NationalSpire.GiftDelivery)`；`NationalSpire.ConsumerGifts.Validate(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool)`；`NationalSpire.GiftDelivery.Items`；`NationalSpire.PrivateConversation.GiftDrafts`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Gift`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerGifts.Draft(System.Collections.Generic.IEnumerable<NationalSpire.GiftItem>)`；输入表达式：`Draft(input.Gift?.Items ?? [])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Draft(input.Gift?.Items ?? [])`
- `NationalSpire.ConsumerGifts.Summary(NationalSpire.GiftDelivery)`；输入表达式：`Summary(draft.Gift!)`；返回值紧邻使用处：`AssignmentExpressionSyntax: draft.Detail = Summary(draft.Gift!)`
- `NationalSpire.ConsumerGifts.Validate(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool)`；输入表达式：`Validate(d, person, draft)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Validate(d, person, draft) is { } error`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(d, person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(d, person).GiftDrafts`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`PrivateMessages.Conversation(d, person).GiftDrafts.Add(draft)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateMessages.Conversation(d, person).GiftDrafts.Add(draft);`

**赋值（含属性/字段和局部值）：**

- `draft.Detail` = `Summary(draft.Gift!)`

<a id="symbol-a6de00bbf8fa"></a>

## `NationalSpire.ConsumerGifts.Purchase(NationalSpire.CareerData, NationalSpire.GiftPurchase) — public static string? Purchase(CareerData d, GiftPurchase order)`

来源：源码第 87 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.GiftRecipientPicker(NationalSpire.CareerData, NationalSpire.Good, int, bool, string?, int, bool)`](ConsumerGiftScreen.cs.md#symbol-55244dcd20ef)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** [`NationalSpire.AiService.PrivateBusy(NationalSpire.CareerData, string)`](AiPrivateMessages.cs.md#symbol-57be9d2323cb)；[`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；[`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?, int)`](ConsumerEngine.cs.md#symbol-6a13be5c34c1)；[`NationalSpire.ConsumerEngine.BuyError(NationalSpire.CareerData, NationalSpire.Good, int)`](ConsumerEngine.cs.md#symbol-0e32f20201c1)；[`NationalSpire.ConsumerGifts.Available(NationalSpire.CareerData, string, string)`](ConsumerGifts.cs.md#symbol-da833f356cc6)；[`NationalSpire.ConsumerGifts.DefaultMessage(NationalSpire.CareerData, string, NationalSpire.GiftDelivery)`](ConsumerGifts.cs.md#symbol-0269f72cb055)；[`NationalSpire.ConsumerGifts.Deliver(NationalSpire.CareerData, string, NationalSpire.PrivateTurn)`](ConsumerGifts.cs.md#symbol-f73281d28d02)；[`NationalSpire.ConsumerGifts.Draft(System.Collections.Generic.IEnumerable<NationalSpire.GiftItem>)`](ConsumerGifts.cs.md#symbol-719a54192f66)；[`NationalSpire.ConsumerGifts.Summary(NationalSpire.GiftDelivery)`](ConsumerGifts.cs.md#symbol-bc3ad22e88d3)；[`NationalSpire.ConsumerGifts.Validate(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool)`](ConsumerGifts.cs.md#symbol-cfd7b7ca0a55)；`NationalSpire.GiftItem.GiftItem()`；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；[`NationalSpire.PrivateMessages.Enqueue(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer?, System.Collections.Generic.List<NationalSpire.PrivateOffer>?, bool)`](PrivateMessages.cs.md#symbol-7823819594c6)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.PrivateBusy(NationalSpire.CareerData, string)`；`NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?, int)`；`NationalSpire.ConsumerEngine.BuyError(NationalSpire.CareerData, NationalSpire.Good, int)`；`NationalSpire.ConsumerGifts.Available(NationalSpire.CareerData, string, string)`；`NationalSpire.ConsumerGifts.DefaultMessage(NationalSpire.CareerData, string, NationalSpire.GiftDelivery)`；`NationalSpire.ConsumerGifts.Deliver(NationalSpire.CareerData, string, NationalSpire.PrivateTurn)`；`NationalSpire.ConsumerGifts.Draft(System.Collections.Generic.IEnumerable<NationalSpire.GiftItem>)`；`NationalSpire.ConsumerGifts.Summary(NationalSpire.GiftDelivery)`；`NationalSpire.ConsumerGifts.Validate(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool)`；`NationalSpire.GiftAllocation.Person`；`NationalSpire.GiftAllocation.Quantity`；`NationalSpire.GiftItem.GoodId`；`NationalSpire.GiftItem.Quantity`；`NationalSpire.GiftPurchase.Direct`；`NationalSpire.GiftPurchase.GoodId`；`NationalSpire.GiftPurchase.Quantity`；`NationalSpire.GiftPurchase.Recipients`；`NationalSpire.Good.Giftable`；`NationalSpire.Good.Id`；`NationalSpire.PrivateConversation.GiftDrafts`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.Enqueue(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer?, System.Collections.Generic.List<NationalSpire.PrivateOffer>?, bool)`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Gift`；`NationalSpire.PrivateTurn.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.PrivateBusy(NationalSpire.CareerData, string)`；输入表达式：`AiService.PrivateBusy(d, target.Person)`；返回值紧邻使用处：`BinaryExpressionSyntax: AiService.PrivateBusy(d, target.Person) || PrivateMessages.Conversation(d, target.Person).Turns.Any(t => t.Status is "queued" or "sending")`
- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(order.GoodId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ConsumerCatalog.Get(order.GoodId) is not { Giftable: true } good`
- `NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?, int)`；输入表达式：`ConsumerEngine.Buy(d, good.Id, quantity: order.Quantity)`；返回值紧邻使用处：`ExpressionStatementSyntax: ConsumerEngine.Buy(d, good.Id, quantity: order.Quantity);`
- `NationalSpire.ConsumerEngine.BuyError(NationalSpire.CareerData, NationalSpire.Good, int)`；输入表达式：`ConsumerEngine.BuyError(d, good, order.Quantity)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ConsumerEngine.BuyError(d, good, order.Quantity) is { } error`
- `NationalSpire.ConsumerGifts.Available(NationalSpire.CareerData, string, string)`；输入表达式：`Available(d, good.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: (long)order.Quantity + Available(d, good.Id)`
- `NationalSpire.ConsumerGifts.DefaultMessage(NationalSpire.CareerData, string, NationalSpire.GiftDelivery)`；输入表达式：`DefaultMessage(d, target.Person, draft.Gift!)`；返回值紧邻使用处：`ArgumentSyntax: DefaultMessage(d, target.Person, draft.Gift!)`
- `NationalSpire.ConsumerGifts.Deliver(NationalSpire.CareerData, string, NationalSpire.PrivateTurn)`；输入表达式：`Deliver(d, target.Person, turn)`；返回值紧邻使用处：`ExpressionStatementSyntax: Deliver(d, target.Person, turn);`
- `NationalSpire.ConsumerGifts.Draft(System.Collections.Generic.IEnumerable<NationalSpire.GiftItem>)`；输入表达式：`Draft([new() { GoodId = good.Id, Quantity = target.Quantity }])`；返回值紧邻使用处：`ArgumentSyntax: Draft([new() { GoodId = good.Id, Quantity = target.Quantity }])`
- `NationalSpire.ConsumerGifts.Draft(System.Collections.Generic.IEnumerable<NationalSpire.GiftItem>)`；输入表达式：`Draft([new() { GoodId = good.Id, Quantity = target.Quantity }])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Draft([new() { GoodId = good.Id, Quantity = target.Quantity }])`
- `NationalSpire.ConsumerGifts.Summary(NationalSpire.GiftDelivery)`；输入表达式：`Summary(draft.Gift!)`；返回值紧邻使用处：`AssignmentExpressionSyntax: draft.Detail = Summary(draft.Gift!)`
- `NationalSpire.ConsumerGifts.Validate(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool)`；输入表达式：`Validate(d, target.Person, Draft([new() { GoodId = good.Id, Quantity = target.Quantity }]), false)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Validate(d, target.Person, Draft([new() { GoodId = good.Id, Quantity = target.Quantity }]), false) is { } invalid`
- `NationalSpire.GiftItem.GiftItem()`；输入表达式：`new() { GoodId = good.Id, Quantity = target.Quantity }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { GoodId = good.Id, Quantity = target.Quantity }`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(d, target.Person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(d, target.Person).Turns`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(d, target.Person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(d, target.Person).GiftDrafts`
- `NationalSpire.PrivateMessages.Enqueue(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer?, System.Collections.Generic.List<NationalSpire.PrivateOffer>?, bool)`；输入表达式：`PrivateMessages.Enqueue(d, target.Person, DefaultMessage(d, target.Person, draft.Gift!), attachments: [draft])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Enqueue(d, target.Person, DefaultMessage(d, target.Person, draft.Gift!), attachments: [draft])`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Conversation(d, target.Person).Turns.Any(t => t.Status is "queued" or "sending")`；返回值紧邻使用处：`BinaryExpressionSyntax: AiService.PrivateBusy(d, target.Person) || PrivateMessages.Conversation(d, target.Person).Turns.Any(t => t.Status is "queued" or "sending")`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`order.Recipients.Any(r => r.Quantity <= 0)`；返回值紧邻使用处：`BinaryExpressionSyntax: order.Recipients.Count == 0 || order.Recipients.Any(r => r.Quantity <= 0)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`order.Recipients.Select(r => r.Person).Distinct().Count()`；返回值紧邻使用处：`BinaryExpressionSyntax: order.Recipients.Select(r => r.Person).Distinct().Count() != order.Recipients.Count`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`order.Recipients.Select(r => r.Person).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: order.Recipients.Select(r => r.Person).Distinct().Count`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`order.Recipients.Select(r => r.Person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: order.Recipients.Select(r => r.Person).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；输入表达式：`order.Recipients.Sum(r => (long)r.Quantity)`；返回值紧邻使用处：`BinaryExpressionSyntax: order.Recipients.Sum(r => (long)r.Quantity) > (long)order.Quantity + Available(d, good.Id)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`PrivateMessages.Conversation(d, target.Person).GiftDrafts.Add(draft)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateMessages.Conversation(d, target.Person).GiftDrafts.Add(draft);`

**赋值（含属性/字段和局部值）：**

- `GoodId` = `good.Id`
- `Quantity` = `target.Quantity`
- `draft.Detail` = `Summary(draft.Gift!)`

<a id="symbol-cd4a57ed25ab"></a>

## `NationalSpire.ConsumerGifts.PrepareSend(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>) — public static string? PrepareSend(CareerData d, string person, List<PrivateOffer> attachments)`

来源：源码第 112 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessages.PrepareAttachments(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>)`](PrivateMessages.cs.md#symbol-f2d6d9cf9c86)

**调用：** [`NationalSpire.ConsumerGifts.Validate(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool)`](ConsumerGifts.cs.md#symbol-cfd7b7ca0a55)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Guid.TryParseExact(string?, string?, out System.Guid)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.ConsumerGifts.Kind`；`NationalSpire.ConsumerGifts.Validate(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool)`；`NationalSpire.ConsumerState.GiftDeliveryIds`；`NationalSpire.ConsumerState.GiftStock`；`NationalSpire.GiftDelivery.Items`；`NationalSpire.GiftItem.GoodId`；`NationalSpire.GiftItem.Quantity`；`NationalSpire.PrivateConversation.GiftDrafts`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateOffer.Gift`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerGifts.Validate(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool)`；输入表达式：`Validate(d, person, gift, false)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Validate(d, person, gift, false) is { } error`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(d).Conversations`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`d.Life.Consumer.GiftDeliveryIds.Contains(gift.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: !Guid.TryParseExact(gift.Id, "N", out _) || d.Life.Consumer.GiftDeliveryIds.Contains(gift.Id)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`ids.Contains(a.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ids.Contains(a.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Mailbox(d).Conversations.Any(c => c.Key != person && c.Value.GiftDrafts.Any(a => a.Id == gift.Id))`；返回值紧邻使用处：`IfStatementSyntax: if (PrivateMessages.Mailbox(d).Conversations.Any(c => c.Key != person && c.Value.GiftDrafts.Any(a => a.Id == gift.Id))) return "这份礼物已预留给其他人。";`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Value.GiftDrafts.Any(a => a.Id == gift.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Key != person && c.Value.GiftDrafts.Any(a => a.Id == gift.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`gifts.Select(a => a.Id).Distinct().Count()`；返回值紧邻使用处：`BinaryExpressionSyntax: gifts.Select(a => a.Id).Distinct().Count() != gifts.Length`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`gifts.Select(a => a.Id).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: gifts.Select(a => a.Id).Distinct().Count`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`PrivateMessages.Mailbox(d).Conversations.Values.SelectMany(c => c.GiftDrafts).Where(a => !ids.Contains(a.Id)).SelectMany(a => a.Gift?.Items ?? []) .GroupBy(i => i.GoodId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(d).Conversations.Values.SelectMany(c => c.GiftDrafts).Where(a => !ids.Contains(a.Id)).SelectMany(a => a.Gift?.Items ?? []) .GroupBy(i => i.GoodId).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`gifts.SelectMany(a => a.Gift!.Items).GroupBy(i => i.GoodId)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var group in gifts.SelectMany(a => a.Gift!.Items).GroupBy(i => i.GoodId)) if (group.Sum(i => (long)i.Quantity) > d.Life.Consumer.GiftStock.GetValueOrDefault(group.Key) - reserved.GetValueOrDefault(group.Key)) return "礼物库存不足，或已预留给其他人。";`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`gifts.Select(a => a.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: gifts.Select(a => a.Id).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`gifts.Select(a => a.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: gifts.Select(a => a.Id).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`PrivateMessages.Mailbox(d).Conversations.Values.SelectMany(c => c.GiftDrafts)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(d).Conversations.Values.SelectMany(c => c.GiftDrafts).Where`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`PrivateMessages.Mailbox(d).Conversations.Values.SelectMany(c => c.GiftDrafts).Where(a => !ids.Contains(a.Id)).SelectMany(a => a.Gift?.Items ?? [])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(d).Conversations.Values.SelectMany(c => c.GiftDrafts).Where(a => !ids.Contains(a.Id)).SelectMany(a => a.Gift?.Items ?? []) .GroupBy`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`gifts.SelectMany(a => a.Gift!.Items)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: gifts.SelectMany(a => a.Gift!.Items).GroupBy`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；输入表达式：`g.Sum(i => (long)i.Quantity)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.Sum(i => (long)i.Quantity)`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；输入表达式：`group.Sum(i => (long)i.Quantity)`；返回值紧邻使用处：`BinaryExpressionSyntax: group.Sum(i => (long)i.Quantity) > d.Life.Consumer.GiftStock.GetValueOrDefault(group.Key) - reserved.GetValueOrDefault(group.Key)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`attachments.Where(a => a.Kind == Kind).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = attachments.Where(a => a.Kind == Kind).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`PrivateMessages.Mailbox(d).Conversations.Values.SelectMany(c => c.GiftDrafts).Where(a => !ids.Contains(a.Id)).SelectMany(a => a.Gift?.Items ?? []) .GroupBy(i => i.GoodId).ToDictionary(g => g.Key, g => g.Sum(i => (long)i.Quantity))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Mailbox(d).Conversations.Values.SelectMany(c => c.GiftDrafts).Where(a => !ids.Contains(a.Id)).SelectMany(a => a.Gift?.Items ?? []) .GroupBy(i => i.GoodId).ToDictionary(g => g.Key, g => g.Sum(i => (long)i.Quantity))`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`gifts.Select(a => a.Id).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = gifts.Select(a => a.Id).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Mailbox(d).Conversations.Values.SelectMany(c => c.GiftDrafts).Where(a => !ids.Contains(a.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(d).Conversations.Values.SelectMany(c => c.GiftDrafts).Where(a => !ids.Contains(a.Id)).SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`attachments.Where(a => a.Kind == Kind)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: attachments.Where(a => a.Kind == Kind).ToArray`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`d.Life.Consumer.GiftStock.GetValueOrDefault(group.Key)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Life.Consumer.GiftStock.GetValueOrDefault(group.Key) - reserved.GetValueOrDefault(group.Key)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`reserved.GetValueOrDefault(group.Key)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Life.Consumer.GiftStock.GetValueOrDefault(group.Key) - reserved.GetValueOrDefault(group.Key)`
- `System.Guid.TryParseExact(string?, string?, out System.Guid)`；输入表达式：`Guid.TryParseExact(gift.Id, "N", out _)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Guid.TryParseExact(gift.Id, "N", out _)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f73281d28d02"></a>

## `NationalSpire.ConsumerGifts.Deliver(NationalSpire.CareerData, string, NationalSpire.PrivateTurn) — public static void Deliver(CareerData d, string person, PrivateTurn turn)`

来源：源码第 130 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerGifts.Purchase(NationalSpire.CareerData, NationalSpire.GiftPurchase)`](ConsumerGifts.cs.md#symbol-a6de00bbf8fa)；[`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerTraining.MoodLevel(NationalSpire.CareerPerson, int)`](CareerTraining.cs.md#symbol-cd61283f2c46)；[`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；[`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-723a34b6e2cb)；[`NationalSpire.ConsumerGifts.Preserve(NationalSpire.CareerData, string)`](ConsumerGifts.cs.md#symbol-073adfe8581d)；[`NationalSpire.ConsumerGifts.Summary(NationalSpire.GiftDelivery)`](ConsumerGifts.cs.md#symbol-bc3ad22e88d3)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；[`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-8a6bb6e78fa5)；[`NationalSpire.PrivateRelation.RefreshAppearance()`](PrivateMessageData.cs.md#symbol-fbf6e9bf540b)；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.CareerPerson.Learning`；`NationalSpire.CareerTraining.MoodLevel(NationalSpire.CareerPerson, int)`；`NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；`NationalSpire.ConsumerGifts.Kind`；`NationalSpire.ConsumerGifts.Preserve(NationalSpire.CareerData, string)`；`NationalSpire.ConsumerGifts.Summary(NationalSpire.GiftDelivery)`；`NationalSpire.ConsumerState.GiftDeliveryIds`；`NationalSpire.ConsumerState.GiftStock`；`NationalSpire.GiftDelivery.FavourBefore`；`NationalSpire.GiftDelivery.FavourGain`；`NationalSpire.GiftDelivery.Items`；`NationalSpire.GiftDelivery.Mood`；`NationalSpire.GiftDelivery.MoodDay`；`NationalSpire.GiftDelivery.MoodDays`；`NationalSpire.GiftDelivery.RawGain`；`NationalSpire.GiftDelivery.Sent`；`NationalSpire.GiftDelivery.Settled`；`NationalSpire.GiftItem.GoodId`；`NationalSpire.GiftItem.Preference`；`NationalSpire.GiftItem.Quantity`；`NationalSpire.GiftItem.Reason`；`NationalSpire.GiftItem.ReceivedBefore`；`NationalSpire.GiftItem.UnitPrice`；`NationalSpire.Good.Id`；`NationalSpire.NpcLearning.MoodDay`；`NationalSpire.PrivateConversation.GiftDrafts`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.AiDetail`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Gift`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateRelation.Favour`；`NationalSpire.PrivateRelation.ReceivedGifts`；`NationalSpire.PrivateRelation.RefreshAppearance()`；`NationalSpire.PrivateRelation.Revision`；`NationalSpire.PrivateRelation.RingReceived`；`NationalSpire.PrivateRelation.RingReplyPending`；`NationalSpire.PrivateTurn.Attachments`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, person)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(d, person)!`
- `NationalSpire.CareerTraining.MoodLevel(NationalSpire.CareerPerson, int)`；输入表达式：`CareerTraining.MoodLevel(npc, d.Day)`；返回值紧邻使用处：`AssignmentExpressionSyntax: gift.Mood = CareerTraining.MoodLevel(npc, d.Day)`
- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(item.GoodId)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: ConsumerCatalog.Get(item.GoodId)!`
- `NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；输入表达式：`ConsumerEngine.Price(good)`；返回值紧邻使用处：`AssignmentExpressionSyntax: item.UnitPrice = ConsumerEngine.Price(good)`
- `NationalSpire.ConsumerGifts.Preserve(NationalSpire.CareerData, string)`；输入表达式：`Preserve(d, person)`；返回值紧邻使用处：`ExpressionStatementSyntax: Preserve(d, person);`
- `NationalSpire.ConsumerGifts.Summary(NationalSpire.GiftDelivery)`；输入表达式：`Summary(gift)`；返回值紧邻使用处：`AssignmentExpressionSyntax: attachment.Detail = Summary(gift)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(d, person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(d, person).GiftDrafts`
- `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Relation(d, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Relation(d, person)`
- `NationalSpire.PrivateRelation.RefreshAppearance()`；输入表达式：`relation.RefreshAppearance()`；返回值紧邻使用处：`ExpressionStatementSyntax: relation.RefreshAppearance();`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`d.Life.Consumer.GiftDeliveryIds.Add(attachment.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Life.Consumer.GiftDeliveryIds.Add(attachment.Id);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`turn.Attachments.Any(a => a.Kind == Kind && a.Gift is { Sent: false })`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !turn.Attachments.Any(a => a.Kind == Kind && a.Gift is { Sent: false })`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`turn.Attachments.Where(a => a.Kind == Kind && a.Gift is { Sent: false })`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var attachment in turn.Attachments.Where(a => a.Kind == Kind && a.Gift is { Sent: false })) { var gift = attachment.Gift!; gift.Sent = true; gift.Settled = false; gift.FavourBefore = relation.Favour; d.Life.Consumer.GiftDeliveryIds.Add(attachment.Id); gift.RawGain = 0; gift.FavourGain = gift.MoodDays = 0; gift.Mood = CareerTraining.MoodLevel(npc, d.Day); gift.MoodDay = npc.Learning.MoodDay; foreach (var item in gift.Items) { var good = ConsumerCatalog.Get(item.GoodId)!; d.Life.Consumer.GiftStock[item.GoodId] -= item.Quantity; item.UnitPrice = ConsumerEngine.Price(good); item.ReceivedBefore = relation.ReceivedGifts.GetValueOrDefault(good.Id); relation.ReceivedGifts[good.Id] = item.ReceivedBefore + item.Quantity; item.Preference = 1; item.Reason = ""; if (good.Id == "oath-ring") { relation.RingReceived = true; relation.RingReplyPending = true; relation.RefreshAppearance(); } } attachment.Detail = Summary(gift); attachment.AiDetail = null; PrivateMessages.Conversation(d, person).GiftDrafts.RemoveAll(a => a.Id == attachment.Id); }`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`relation.ReceivedGifts.GetValueOrDefault(good.Id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: item.ReceivedBefore = relation.ReceivedGifts.GetValueOrDefault(good.Id)`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`PrivateMessages.Conversation(d, person).GiftDrafts.RemoveAll(a => a.Id == attachment.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateMessages.Conversation(d, person).GiftDrafts.RemoveAll(a => a.Id == attachment.Id);`

**赋值（含属性/字段和局部值）：**

- `attachment.AiDetail` = `null`
- `attachment.Detail` = `Summary(gift)`
- `d.Life.Consumer.GiftStock[item.GoodId]` -= `item.Quantity`
- `gift.FavourBefore` = `relation.Favour`
- `gift.FavourGain` = `gift.MoodDays = 0`
- `gift.MoodDay` = `npc.Learning.MoodDay`
- `gift.MoodDays` = `0`
- `gift.Mood` = `CareerTraining.MoodLevel(npc, d.Day)`
- `gift.RawGain` = `0`
- `gift.Sent` = `true`
- `gift.Settled` = `false`
- `item.Preference` = `1`
- `item.Reason` = `""`
- `item.ReceivedBefore` = `relation.ReceivedGifts.GetValueOrDefault(good.Id)`
- `item.UnitPrice` = `ConsumerEngine.Price(good)`
- `relation.ReceivedGifts[good.Id]` = `item.ReceivedBefore + item.Quantity`
- `relation.RingReceived` = `true`
- `relation.RingReplyPending` = `true`

<a id="symbol-c88c446ec911"></a>

## `NationalSpire.ConsumerGifts.PriceGain(double) — public static double PriceGain(double price)`

来源：源码第 155 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AffectionRules.GiftValue(NationalSpire.RomanceDifficulty, NationalSpire.GiftItem, int, int, double)`](AffectionRules.cs.md#symbol-476b2d98ce24)

**调用：** `System.Math.Log(double)`；`System.Math.Max(double, double)`；`System.Math.Pow(double, double)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Log(double)`；输入表达式：`Math.Log(30)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Log(30) / Math.Log(5000)`
- `System.Math.Log(double)`；输入表达式：`Math.Log(5000)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Log(30) / Math.Log(5000)`
- `System.Math.Max(double, double)`；输入表达式：`Math.Max(0, price)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(0, price) / 20`
- `System.Math.Pow(double, double)`；输入表达式：`Math.Pow(Math.Max(0, price) / 20, Math.Log(30) / Math.Log(5000))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Math.Pow(Math.Max(0, price) / 20, Math.Log(30) / Math.Log(5000))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-47e7114c75eb"></a>

## `NationalSpire.ConsumerGifts.FavourFactor(int) — public static double FavourFactor(int favour)`

来源：源码第 156 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`at(long)`](AffectionRules.cs.md#symbol-e7d2c260590f)

**调用：** `System.Math.Clamp(double, double, double)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp((favour + 50) / 149d, 0, 1)`；返回值紧邻使用处：`BinaryExpressionSyntax: 1.5 * Math.Clamp((favour + 50) / 149d, 0, 1)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6a2d01a43a87"></a>

## `NationalSpire.ConsumerGifts.RepeatFactor(long) — public static double RepeatFactor(long previous)`

来源：源码第 157 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerGifts.RepeatSum(long, int)`](ConsumerGifts.cs.md#symbol-b0e6871f89cf)；[`at(long)`](AffectionRules.cs.md#symbol-e7d2c260590f)

**调用：** `System.Math.Clamp(double, double, double)`；`System.Math.Pow(double, double)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp(previous / 9d, 0, 1)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(previous / 9d, 0, 1)`
- `System.Math.Pow(double, double)`；输入表达式：`Math.Pow(Math.Clamp(previous / 9d, 0, 1), 2)`；返回值紧邻使用处：`BinaryExpressionSyntax: .9 * Math.Pow(Math.Clamp(previous / 9d, 0, 1), 2)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b0e6871f89cf"></a>

## `NationalSpire.ConsumerGifts.RepeatSum(long, int) — public static double RepeatSum(long previous, int count)`

来源：源码第 158 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.ConsumerGifts.RepeatFactor(long)`](ConsumerGifts.cs.md#symbol-6a2d01a43a87)；`System.Math.Max(long, long)`；`System.Math.Min(long, long)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerGifts.RepeatFactor(long)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerGifts.RepeatFactor(long)`；输入表达式：`RepeatFactor(previous + i)`；返回值紧邻使用处：`AssignmentExpressionSyntax: total += RepeatFactor(previous + i)`
- `System.Math.Max(long, long)`；输入表达式：`Math.Max(0, 9 - previous)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, 9 - previous)`
- `System.Math.Min(long, long)`；输入表达式：`Math.Min(count, Math.Max(0, 9 - previous))`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Min(count, Math.Max(0, 9 - previous))`

**赋值（含属性/字段和局部值）：**

- `total` += `RepeatFactor(previous + i)`

<a id="symbol-a0809650e9f4"></a>

## `NationalSpire.ConsumerGifts.HasDelivered(NationalSpire.PrivateTurn) — public static bool HasDelivered(PrivateTurn turn)`

来源：源码第 164 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`](PrivateMessages.cs.md#symbol-7bf623828ccc)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerGifts.Kind`；`NationalSpire.GiftDelivery.Sent`；`NationalSpire.PrivateOffer.Gift`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateTurn.Attachments`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`turn.Attachments.Any(a => a.Kind == Kind && a.Gift is { Sent: true })`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => turn.Attachments.Any(a => a.Kind == Kind && a.Gift is { Sent: true })`

**赋值（含属性/字段和局部值）：**


<a id="symbol-08a7dc849ce0"></a>

## `NationalSpire.ConsumerGifts.Settle(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>) — public static void Settle(CareerData d, PrivateConversation c, PrivateTurn turn, IReadOnlyList<Dictionary<string, string>> directives)`

来源：源码第 165 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`](PrivateMessages.cs.md#symbol-7bf623828ccc)

**调用：** [`NationalSpire.AffectionRules.Apply(NationalSpire.CareerData, string, double, bool)`](AffectionRules.cs.md#symbol-85ae2ed8ebb4)；[`NationalSpire.AffectionRules.DateRate(NationalSpire.RomanceDifficulty, bool, double)`](AffectionRules.cs.md#symbol-d47b24120861)；[`NationalSpire.AffectionRules.GainRate(NationalSpire.RomanceDifficulty)`](AffectionRules.cs.md#symbol-e859cd7c259e)；[`NationalSpire.AffectionRules.GiftValue(NationalSpire.RomanceDifficulty, NationalSpire.GiftItem, int, int, double)`](AffectionRules.cs.md#symbol-476b2d98ce24)；[`NationalSpire.AffectionRules.Mode(NationalSpire.CareerData, NationalSpire.PrivateTurn?)`](AffectionRules.cs.md#symbol-8616d6a806d2)；[`NationalSpire.ConsumerGifts.ApplyMood(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](ConsumerGifts.cs.md#symbol-5b7378308e50)；[`NationalSpire.ConsumerGifts.Preserve(NationalSpire.CareerData, string)`](ConsumerGifts.cs.md#symbol-073adfe8581d)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.PrivateInteractionHistory.PreserveRelation(NationalSpire.PrivateMailbox, NationalSpire.ChatWorld, string, string, System.Collections.Generic.IReadOnlyList<string>)`](PrivateInteractionUndo.cs.md#symbol-9f5887b5e53e)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；[`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-8a6bb6e78fa5)；[`NationalSpire.PrivateRelation.RefreshAppearance()`](PrivateMessageData.cs.md#symbol-fbf6e9bf540b)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, double>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Math.Ceiling(double)`；`System.Math.Clamp(double, double, double)`；`System.Math.Floor(double)`；`System.Math.Max(double, double)`；`System.Math.Min(double, double)`；`double.IsFinite(double)`；`double.TryParse(string?, System.Globalization.NumberStyles, System.IFormatProvider?, out double)`；`string.IsNullOrWhiteSpace(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AffectionRules.Apply(NationalSpire.CareerData, string, double, bool)`；`NationalSpire.AffectionRules.DateRate(NationalSpire.RomanceDifficulty, bool, double)`；`NationalSpire.AffectionRules.GainRate(NationalSpire.RomanceDifficulty)`；`NationalSpire.AffectionRules.GiftValue(NationalSpire.RomanceDifficulty, NationalSpire.GiftItem, int, int, double)`；`NationalSpire.AffectionRules.Mode(NationalSpire.CareerData, NationalSpire.PrivateTurn?)`；`NationalSpire.CareerData.Chats`；`NationalSpire.ConsumerGifts.ApplyMood(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；`NationalSpire.ConsumerGifts.Kind`；`NationalSpire.ConsumerGifts.Preserve(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneRequest.Ending`；`NationalSpire.GiftDelivery.FavourBefore`；`NationalSpire.GiftDelivery.FavourGain`；`NationalSpire.GiftDelivery.Items`；`NationalSpire.GiftDelivery.Mood`；`NationalSpire.GiftDelivery.MoodDays`；`NationalSpire.GiftDelivery.RawGain`；`NationalSpire.GiftDelivery.Sent`；`NationalSpire.GiftDelivery.Settled`；`NationalSpire.GiftItem.GoodId`；`NationalSpire.GiftItem.Preference`；`NationalSpire.GiftItem.Quantity`；`NationalSpire.GiftItem.Reason`；`NationalSpire.GiftItem.UnitPrice`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateInteractionHistory.PreserveRelation(NationalSpire.PrivateMailbox, NationalSpire.ChatWorld, string, string, System.Collections.Generic.IReadOnlyList<string>)`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Gift`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateRelation.OathDeferred`；`NationalSpire.PrivateRelation.OathPromptHidden`；`NationalSpire.PrivateRelation.RefreshAppearance()`；`NationalSpire.PrivateRelation.RingReplyPending`；`NationalSpire.PrivateTurn.Attachments`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AffectionRules.Apply(NationalSpire.CareerData, string, double, bool)`；输入表达式：`AffectionRules.Apply(d, c.PersonId, gift.RawGain, gift: true)`；返回值紧邻使用处：`AssignmentExpressionSyntax: gift.FavourGain = AffectionRules.Apply(d, c.PersonId, gift.RawGain, gift: true)`
- `NationalSpire.AffectionRules.DateRate(NationalSpire.RomanceDifficulty, bool, double)`；输入表达式：`AffectionRules.DateRate(difficulty, turn.Scene is { Ending: false }, gift.RawGain)`；返回值紧邻使用处：`AssignmentExpressionSyntax: gift.RawGain *= AffectionRules.DateRate(difficulty, turn.Scene is { Ending: false }, gift.RawGain)`
- `NationalSpire.AffectionRules.GainRate(NationalSpire.RomanceDifficulty)`；输入表达式：`AffectionRules.GainRate(difficulty)`；返回值紧邻使用处：`ConditionalExpressionSyntax: gift.RawGain > 0 ? AffectionRules.GainRate(difficulty) : 1`
- `NationalSpire.AffectionRules.GiftValue(NationalSpire.RomanceDifficulty, NationalSpire.GiftItem, int, int, double)`；输入表达式：`AffectionRules.GiftValue(difficulty, item, effectiveCount, gift.FavourBefore, gift.Mood)`；返回值紧邻使用处：`AssignmentExpressionSyntax: gift.RawGain += AffectionRules.GiftValue(difficulty, item, effectiveCount, gift.FavourBefore, gift.Mood)`
- `NationalSpire.AffectionRules.Mode(NationalSpire.CareerData, NationalSpire.PrivateTurn?)`；输入表达式：`AffectionRules.Mode(d, turn)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AffectionRules.Mode(d, turn)`
- `NationalSpire.ConsumerGifts.ApplyMood(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；输入表达式：`ApplyMood(d, c.PersonId, attachment)`；返回值紧邻使用处：`ExpressionStatementSyntax: ApplyMood(d, c.PersonId, attachment);`
- `NationalSpire.ConsumerGifts.Preserve(NationalSpire.CareerData, string)`；输入表达式：`Preserve(d, c.PersonId)`；返回值紧邻使用处：`ExpressionStatementSyntax: Preserve(d, c.PersonId);`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(d)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Human(d)`
- `NationalSpire.PrivateInteractionHistory.PreserveRelation(NationalSpire.PrivateMailbox, NationalSpire.ChatWorld, string, string, System.Collections.Generic.IReadOnlyList<string>)`；输入表达式：`PrivateInteractionHistory.PreserveRelation(PrivateMessages.Mailbox(d), d.Chats, GroupChats.Human(d), c.PersonId, [nameof(PrivateRelation.Favour)])`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateInteractionHistory.PreserveRelation(PrivateMessages.Mailbox(d), d.Chats, GroupChats.Human(d), c.PersonId, [nameof(PrivateRelation.Favour)]);`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(d)`；返回值紧邻使用处：`ArgumentSyntax: PrivateMessages.Mailbox(d)`
- `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Relation(d, c.PersonId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Relation(d, c.PersonId)`
- `NationalSpire.PrivateRelation.RefreshAppearance()`；输入表达式：`relation.RefreshAppearance()`；返回值紧邻使用处：`ExpressionStatementSyntax: relation.RefreshAppearance();`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`prior.Items.Any(i => i.GoodId == "oath-ring")`；返回值紧邻使用处：`BinaryExpressionSyntax: a.Gift is { Settled: true } prior && prior.Items.Any(i => i.GoodId == "oath-ring")`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`turn.Attachments.Any(a => a.Gift is { Settled: true } prior && prior.Items.Any(i => i.GoodId == "oath-ring"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = turn.Attachments.Any(a => a.Gift is { Settled: true } prior && prior.Items.Any(i => i.GoodId == "oath-ring"))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`turn.Attachments.Any(a => a.Kind == Kind && a.Gift is { Sent: true, Settled: false })`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !turn.Attachments.Any(a => a.Kind == Kind && a.Gift is { Sent: true, Settled: false })`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`directives.LastOrDefault(f => f.GetValueOrDefault("Gift") == item.GoodId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = directives.LastOrDefault(f => f.GetValueOrDefault("Gift") == item.GoodId)`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, double>)`；输入表达式：`turn.Attachments.Where(a => a.Gift is { Settled: true }).Sum(a => Math.Max(0, -a.Gift!.RawGain))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = turn.Attachments.Where(a => a.Gift is { Settled: true }).Sum(a => Math.Max(0, -a.Gift!.RawGain))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`turn.Attachments.Where(a => a.Gift is { Settled: true })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: turn.Attachments.Where(a => a.Gift is { Settled: true }).Sum`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`turn.Attachments.Where(a => a.Kind == Kind && a.Gift is { Sent: true, Settled: false })`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var attachment in turn.Attachments.Where(a => a.Kind == Kind && a.Gift is { Sent: true, Settled: false })) { var gift = attachment.Gift!; double value = 0; foreach (var item in gift.Items) { var preference = directives.LastOrDefault(f => f.GetValueOrDefault("Gift") == item.GoodId); item.Preference = preference != null && double.TryParse(preference.GetValueOrDefault("Preference"), NumberStyles.Float, CultureInfo.InvariantCulture, out double factor) && double.IsFinite(factor) ? Math.Clamp(factor, .25, 1.75) : 1; item.Reason = preference?.GetValueOrDefault("Reason", "") ?? "按中性偏好结算"; int effectiveCount = item.GoodId == "oath-ring" ? ringEffectApplied ? 0 : 1 : item.Quantity; if (item.GoodId == "oath-ring") ringEffectApplied = true; gift.RawGain += AffectionRules.GiftValue(difficulty, item, effectiveCount, gift.FavourBefore, gift.Mood); value += item.UnitPrice * (double)effectiveCount * item.Preference; } gift.RawGain *= gift.RawGain > 0 ? AffectionRules.GainRate(difficulty) : 1; gift.RawGain *= AffectionRules.DateRate(difficulty, turn.Scene is { Ending: false }, gift.RawGain); if (gift.RawGain < 0) { gift.RawGain = Math.Max(gift.RawGain, -Math.Max(0, 3 - lost)); lost += -gift.RawGain; } gift.FavourGain = AffectionRules.Apply(d, c.PersonId, gift.RawGain, gift: true); double beneficial = Math.Max(0, gift.RawGain); gift.MoodDays = gift.Mood < 0 ? -(int)Math.Min(365, Math.Ceiling(beneficial)) : gift.Mood > 0 && value >= 3000 && beneficial > 0 ? (int)Math.Min(14, Math.Max(1, Math.Floor(beneficial / 3))) : 0; gift.Settled = true; ApplyMood(d, c.PersonId, attachment); PrivateInteractionHistory.PreserveRelation(PrivateMessages.Mailbox(d), d.Chats, GroupChats.Human(d), c.PersonId, [nameof(PrivateRelation.Favour)]); }`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`f.GetValueOrDefault("Gift")`；返回值紧邻使用处：`BinaryExpressionSyntax: f.GetValueOrDefault("Gift") == item.GoodId`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`preference.GetValueOrDefault("Preference")`；返回值紧邻使用处：`ArgumentSyntax: preference.GetValueOrDefault("Preference")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`.GetValueOrDefault("Reason", "")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: preference?.GetValueOrDefault("Reason", "")`
- `System.Math.Ceiling(double)`；输入表达式：`Math.Ceiling(beneficial)`；返回值紧邻使用处：`ArgumentSyntax: Math.Ceiling(beneficial)`
- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp(factor, .25, 1.75)`；返回值紧邻使用处：`ConditionalExpressionSyntax: preference != null && double.TryParse(preference.GetValueOrDefault("Preference"), NumberStyles.Float, CultureInfo.InvariantCulture, out double factor) && double.IsFinite(factor) ? Math.Clamp(factor, .25, 1.75) : 1`
- `System.Math.Floor(double)`；输入表达式：`Math.Floor(beneficial / 3)`；返回值紧邻使用处：`ArgumentSyntax: Math.Floor(beneficial / 3)`
- `System.Math.Max(double, double)`；输入表达式：`Math.Max(0, -a.Gift!.RawGain)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: a => Math.Max(0, -a.Gift!.RawGain)`
- `System.Math.Max(double, double)`；输入表达式：`Math.Max(0, 3 - lost)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: -Math.Max(0, 3 - lost)`
- `System.Math.Max(double, double)`；输入表达式：`Math.Max(0, gift.RawGain)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(0, gift.RawGain)`
- `System.Math.Max(double, double)`；输入表达式：`Math.Max(1, Math.Floor(beneficial / 3))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(1, Math.Floor(beneficial / 3))`
- `System.Math.Max(double, double)`；输入表达式：`Math.Max(gift.RawGain, -Math.Max(0, 3 - lost))`；返回值紧邻使用处：`AssignmentExpressionSyntax: gift.RawGain = Math.Max(gift.RawGain, -Math.Max(0, 3 - lost))`
- `System.Math.Min(double, double)`；输入表达式：`Math.Min(14, Math.Max(1, Math.Floor(beneficial / 3)))`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Min(14, Math.Max(1, Math.Floor(beneficial / 3)))`
- `System.Math.Min(double, double)`；输入表达式：`Math.Min(365, Math.Ceiling(beneficial))`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Min(365, Math.Ceiling(beneficial))`
- `double.IsFinite(double)`；输入表达式：`double.IsFinite(factor)`；返回值紧邻使用处：`BinaryExpressionSyntax: preference != null && double.TryParse(preference.GetValueOrDefault("Preference"), NumberStyles.Float, CultureInfo.InvariantCulture, out double factor) && double.IsFinite(factor)`
- `double.TryParse(string?, System.Globalization.NumberStyles, System.IFormatProvider?, out double)`；输入表达式：`double.TryParse(preference.GetValueOrDefault("Preference"), NumberStyles.Float, CultureInfo.InvariantCulture, out double factor)`；返回值紧邻使用处：`BinaryExpressionSyntax: preference != null && double.TryParse(preference.GetValueOrDefault("Preference"), NumberStyles.Float, CultureInfo.InvariantCulture, out double factor)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(turn.Reply)`；返回值紧邻使用处：`BinaryExpressionSyntax: turn.Status != "complete" || turn.ReplyDeleted || string.IsNullOrWhiteSpace(turn.Reply)`

**赋值（含属性/字段和局部值）：**

- `gift.FavourGain` = `AffectionRules.Apply(d, c.PersonId, gift.RawGain, gift: true)`
- `gift.MoodDays` = `gift.Mood < 0 ? -(int)Math.Min(365, Math.Ceiling(beneficial)) : gift.Mood > 0 && value >= 3000 && beneficial > 0 ? (int)Math.Min(14, Math.Max(1, Math.Floor(beneficial / 3))) : 0`
- `gift.RawGain` *= `AffectionRules.DateRate(difficulty, turn.Scene is { Ending: false }, gift.RawGain)`
- `gift.RawGain` *= `gift.RawGain > 0 ? AffectionRules.GainRate(difficulty) : 1`
- `gift.RawGain` += `AffectionRules.GiftValue(difficulty, item, effectiveCount, gift.FavourBefore, gift.Mood)`
- `gift.RawGain` = `Math.Max(gift.RawGain, -Math.Max(0, 3 - lost))`
- `gift.Settled` = `true`
- `item.Preference` = `preference != null && double.TryParse(preference.GetValueOrDefault("Preference"), NumberStyles.Float, CultureInfo.InvariantCulture, out double factor) && double.IsFinite(factor) ? Math.Clamp(factor, .25, 1.75) : 1`
- `item.Reason` = `preference?.GetValueOrDefault("Reason", "") ?? "按中性偏好结算"`
- `lost` += `-gift.RawGain`
- `relation.OathDeferred` = `false`
- `relation.OathPromptHidden` = `false`
- `relation.RingReplyPending` = `false`
- `ringEffectApplied` = `true`
- `value` += `item.UnitPrice * (double)effectiveCount * item.Preference`

<a id="symbol-073adfe8581d"></a>

## `NationalSpire.ConsumerGifts.Preserve(NationalSpire.CareerData, string) — private static void Preserve(CareerData d, string person)`

来源：源码第 200 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerGifts.Deliver(NationalSpire.CareerData, string, NationalSpire.PrivateTurn)`](ConsumerGifts.cs.md#symbol-f73281d28d02)；[`NationalSpire.ConsumerGifts.Settle(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>)`](ConsumerGifts.cs.md#symbol-08a7dc849ce0)

**调用：** [`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.PrivateInteractionHistory.PreserveRelation(NationalSpire.PrivateMailbox, NationalSpire.ChatWorld, string, string, System.Collections.Generic.IReadOnlyList<string>)`](PrivateInteractionUndo.cs.md#symbol-9f5887b5e53e)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.PrivateInteractionHistory.PreserveRelation(NationalSpire.PrivateMailbox, NationalSpire.ChatWorld, string, string, System.Collections.Generic.IReadOnlyList<string>)`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(d)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Human(d)`
- `NationalSpire.PrivateInteractionHistory.PreserveRelation(NationalSpire.PrivateMailbox, NationalSpire.ChatWorld, string, string, System.Collections.Generic.IReadOnlyList<string>)`；输入表达式：`PrivateInteractionHistory.PreserveRelation(PrivateMessages.Mailbox(d), d.Chats, GroupChats.Human(d), person, [nameof(PrivateRelation.ReceivedGifts), nameof(PrivateRelation.GiftRemainder), nameof(PrivateRelation.GiftLossRemainder), nameof(PrivateRelation.RingReceived), nameof(PrivateRelation.RingReplyPending), nameof(PrivateRelation.OathDeferred), nameof(PrivateRelation.OathPromptHidden), nameof(PrivateRelation.WeddingCompleted), nameof(PrivateRelation.HighestBond)])`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => PrivateInteractionHistory.PreserveRelation(PrivateMessages.Mailbox(d), d.Chats, GroupChats.Human(d), person, [nameof(PrivateRelation.ReceivedGifts), nameof(PrivateRelation.GiftRemainder), nameof(PrivateRelation.GiftLossRemainder), nameof(PrivateRelation.RingReceived), nameof(PrivateRelation.RingReplyPending), nameof(PrivateRelation.OathDeferred), nameof(PrivateRelation.OathPromptHidden), nameof(PrivateRelation.WeddingCompleted), nameof(PrivateRelation.HighestBond)])`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(d)`；返回值紧邻使用处：`ArgumentSyntax: PrivateMessages.Mailbox(d)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fcae07374e60"></a>

## `NationalSpire.ConsumerGifts.MergeMood(NationalSpire.CareerData, NationalSpire.PrivateMailbox) — public static void MergeMood(CareerData d, PrivateMailbox mailbox)`

来源：源码第 202 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Save(NationalSpire.CareerData)`](Coop/CoopPrivateMessages.cs.md#symbol-b25b18b4284d)

**调用：** [`NationalSpire.ConsumerGifts.ApplyMood(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](ConsumerGifts.cs.md#symbol-5b7378308e50)；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerGifts.ApplyMood(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；`NationalSpire.GiftDelivery.Settled`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateOffer.Gift`；`NationalSpire.PrivateTurn.Attachments`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerGifts.ApplyMood(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；输入表达式：`ApplyMood(d, c.PersonId, a)`；返回值紧邻使用处：`ExpressionStatementSyntax: ApplyMood(d, c.PersonId, a);`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`c.Turns.SelectMany(t => t.Attachments)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Turns.SelectMany(t => t.Attachments).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.SelectMany(t => t.Attachments).Where(a => a.Gift is { Settled: true })`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var a in c.Turns.SelectMany(t => t.Attachments).Where(a => a.Gift is { Settled: true })) ApplyMood(d, c.PersonId, a);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5b7378308e50"></a>

## `NationalSpire.ConsumerGifts.ApplyMood(NationalSpire.CareerData, string, NationalSpire.PrivateOffer) — private static void ApplyMood(CareerData d, string person, PrivateOffer attachment)`

来源：源码第 207 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerGifts.MergeMood(NationalSpire.CareerData, NationalSpire.PrivateMailbox)`](ConsumerGifts.cs.md#symbol-fcae07374e60)；[`NationalSpire.ConsumerGifts.Settle(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>)`](ConsumerGifts.cs.md#symbol-08a7dc849ce0)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerTraining.InvalidateForecast(NationalSpire.CareerData)`](CareerTraining.cs.md#symbol-5df788f3061f)；[`NationalSpire.SpireArbitration.ShockDay(NationalSpire.CareerPerson, int)`](SpireArbitration.cs.md#symbol-fe9f0ad5c9c7)；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Math.Max(int, int)`；`System.Math.Min(int, int)`；`System.Math.Sign(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Learning`；`NationalSpire.CareerTraining.InvalidateForecast(NationalSpire.CareerData)`；`NationalSpire.GiftDelivery.Mood`；`NationalSpire.GiftDelivery.MoodDay`；`NationalSpire.GiftDelivery.MoodDays`；`NationalSpire.NpcLearning.GiftMoodExtension`；`NationalSpire.NpcLearning.MoodDay`；`NationalSpire.NpcLearning.MoodStrength`；`NationalSpire.NpcLearning.MoodUntil`；`NationalSpire.NpcLearning.Receipts`；`NationalSpire.PrivateOffer.Gift`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.SpireArbitration.ShockDay(NationalSpire.CareerPerson, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Person(d, person)`
- `NationalSpire.CareerTraining.InvalidateForecast(NationalSpire.CareerData)`；输入表达式：`CareerTraining.InvalidateForecast(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerTraining.InvalidateForecast(d);`
- `NationalSpire.SpireArbitration.ShockDay(NationalSpire.CareerPerson, int)`；输入表达式：`SpireArbitration.ShockDay(npc, d.Day)`；返回值紧邻使用处：`BinaryExpressionSyntax: SpireArbitration.ShockDay(npc, d.Day) >= 0`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`state.Receipts.Add(key)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !state.Receipts.Add(key)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, 14 - state.GiftMoodExtension)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, 14 - state.GiftMoodExtension)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(d.Day, state.MoodUntil + change)`；返回值紧邻使用处：`AssignmentExpressionSyntax: state.MoodUntil = Math.Max(d.Day, state.MoodUntil + change)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(gift.MoodDays, Math.Max(0, 14 - state.GiftMoodExtension))`；返回值紧邻使用处：`ConditionalExpressionSyntax: gift.MoodDays > 0 ? Math.Min(gift.MoodDays, Math.Max(0, 14 - state.GiftMoodExtension)) : gift.MoodDays`
- `System.Math.Sign(double)`；输入表达式：`Math.Sign(gift.Mood)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Sign(state.MoodStrength) != Math.Sign(gift.Mood)`
- `System.Math.Sign(double)`；输入表达式：`Math.Sign(state.MoodStrength)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Sign(state.MoodStrength) != Math.Sign(gift.Mood)`

**赋值（含属性/字段和局部值）：**

- `state.GiftMoodExtension` += `change`
- `state.MoodUntil` = `Math.Max(d.Day, state.MoodUntil + change)`

<a id="symbol-905fa376a7e7"></a>

## `NationalSpire.ConsumerGifts.Wedding(NationalSpire.CareerData, string) — public static string? Wedding(CareerData d, string person)`

来源：源码第 219 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.GiftRecipientPicker(NationalSpire.CareerData, NationalSpire.Good, int, bool, string?, int, bool)`](ConsumerGiftScreen.cs.md#symbol-55244dcd20ef)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** [`NationalSpire.ConsumerInvitations.Create(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool)`](ConsumerInvitations.cs.md#symbol-cc2d01b16094)

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerInvitations.Create(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerInvitations.Create(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool)`；输入表达式：`ConsumerInvitations.Create(d, "grand-wedding", "", [person], buy: true)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ConsumerInvitations.Create(d, "grand-wedding", "", [person], buy: true)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-83cb4fa73c82"></a>

## `NationalSpire.ConsumerGifts.Context(NationalSpire.PrivateOffer) — public static string Context(PrivateOffer a)`

来源：源码第 227 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PreviewPrivateAttachment(NationalSpire.PrivateOffer, bool)`](PrivateMemoryScreen.cs.md#symbol-5c877df45b85)；[`NationalSpire.PrivateMessagePrompts.UserText(NationalSpire.PrivateTurn, NationalSpire.PrivateConversation, bool, System.Collections.Generic.List<NationalSpire.PromptInsertion>?)`](PrivateMessagePrompts.cs.md#symbol-a6aa8a8392b1)

**调用：** [`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；[`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`](ConsumerEngine.cs.md#symbol-723a34b6e2cb)；[`NationalSpire.ConsumerGifts.Summary(NationalSpire.GiftDelivery)`](ConsumerGifts.cs.md#symbol-bc3ad22e88d3)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；`NationalSpire.ConsumerGifts.Summary(NationalSpire.GiftDelivery)`；`NationalSpire.GiftDelivery.Items`；`NationalSpire.GiftDelivery.Sent`；`NationalSpire.GiftDelivery.Settled`；`NationalSpire.GiftItem.GoodId`；`NationalSpire.GiftItem.Quantity`；`NationalSpire.GiftItem.ReceivedBefore`；`NationalSpire.GiftItem.UnitPrice`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Gift`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(i.GoodId)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: ConsumerCatalog.Get(i.GoodId)!`
- `NationalSpire.ConsumerEngine.Price(NationalSpire.Good)`；输入表达式：`ConsumerEngine.Price(ConsumerCatalog.Get(i.GoodId)!)`；返回值紧邻使用处：`ConditionalExpressionSyntax: i.UnitPrice > 0 ? i.UnitPrice : ConsumerEngine.Price(ConsumerCatalog.Get(i.GoodId)!)`
- `NationalSpire.ConsumerGifts.Summary(NationalSpire.GiftDelivery)`；输入表达式：`Summary(gift)`；返回值紧邻使用处：`BinaryExpressionSyntax: Summary(gift) + "\n"`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`gift.Items.Any(i => i.GoodId == "oath-ring" && i.Quantity > 1)`；返回值紧邻使用处：`ConditionalExpressionSyntax: gift.Items.Any(i => i.GoodId == "oath-ring" && i.Quantity > 1) ? "\n该角色被赠送了多枚戒指。礼物收益与求婚效果按一枚计算。" : ""`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`gift.Items.Select(i => $"商品Id={i.GoodId}，单价=${(i.UnitPrice > 0 ? i.UnitPrice : ConsumerEngine.Price(ConsumerCatalog.Get(i.GoodId)!))}，数量={i.Quantity}，此前已收={i.ReceivedBefore}")`；返回值紧邻使用处：`ArgumentSyntax: gift.Items.Select(i => $"商品Id={i.GoodId}，单价=${(i.UnitPrice > 0 ? i.UnitPrice : ConsumerEngine.Price(ConsumerCatalog.Get(i.GoodId)!))}，数量={i.Quantity}，此前已收={i.ReceivedBefore}")`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", gift.Items.Select(i => $"商品Id={i.GoodId}，单价=${(i.UnitPrice > 0 ? i.UnitPrice : ConsumerEngine.Price(ConsumerCatalog.Get(i.GoodId)!))}，数量={i.Quantity}，此前已收={i.ReceivedBefore}"))`；返回值紧邻使用处：`BinaryExpressionSyntax: Summary(gift) + "\n" + (gift.Sent ? gift.Settled ? "已送达并结算" : "已送达，待本轮偏好评估" : "待发送") + (gift.Items.Any(i => i.GoodId == "oath-ring" && i.Quantity > 1) ? "\n该角色被赠送了多枚戒指。礼物收益与求婚效果按一枚计算。" : "") + "\n" + string.Join("\n", gift.Items.Select(i => $"商品Id={i.GoodId}，单价=${(i.UnitPrice > 0 ? i.UnitPrice : ConsumerEngine.Price(ConsumerCatalog.Get(i.GoodId)!))}，数量={i.Quantity}，此前已收={i.ReceivedBefore}"))`

**赋值（含属性/字段和局部值）：**
