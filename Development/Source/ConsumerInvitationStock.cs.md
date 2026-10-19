# ConsumerInvitationStock.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`0605B36D64E0FCC3F23C02A1D53608AC1CA061E66019A3A99710A00F09E180DA`。来源：[源码](../../ConsumerInvitationStock.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.InvitationReservation`、`NationalSpire.ConsumerInvitationStock`。

字段、事件及初始值（源码原样）：

```csharp
public const string ActiveMessage = "有正在进行中的约会事件";
```

<a id="symbol-a560327c8bb7"></a>

## `NationalSpire.InvitationReservation.Id — public string Id`

来源：源码第 5 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Guid.NewGuid()`；`System.Guid.ToString(string?)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Guid.NewGuid().ToString("N")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-866009826220"></a>

## `NationalSpire.InvitationReservation.GoodId — public string GoodId`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-563528810669"></a>

## `NationalSpire.InvitationReservation.Verb — public string Verb`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a9d18a73bf79"></a>

## `NationalSpire.InvitationReservation.People — public List<string> People`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1bb8bafd8d75"></a>

## `NationalSpire.InvitationReservation.Consumed — public bool Consumed`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-71fa8e1feaa2"></a>

## `NationalSpire.ConsumerInvitationStock.Active(NationalSpire.CareerData) — public static bool Active(CareerData data)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.GiftRecipientPicker(NationalSpire.CareerData, NationalSpire.Good, int, bool, string?, int, bool)`](ConsumerGiftScreen.cs.md#symbol-55244dcd20ef)；[`NationalSpire.CareerScreen.GuardInvitationButton(Godot.Button, NationalSpire.CareerData)`](DateDiaryScreen.cs.md#symbol-6147e79e0285)；[`NationalSpire.CareerScreen.PrivateDateInvitationPicker()`](DateDiaryScreen.cs.md#symbol-cdf7f00bf71b)；[`NationalSpire.ConsumerInvitations.Create(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool)`](ConsumerInvitations.cs.md#symbol-cc2d01b16094)；[`NationalSpire.ConsumerInvitations.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](ConsumerInvitations.cs.md#symbol-9f0c7f580228)

**调用：** [`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateSceneRequest.Opening`；`NationalSpire.PrivateConversation.DateSceneStates`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateTurn.Scene`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values.Any(c => c.DateSceneStates.Any(p => p.Value is "active" or "paused") || c.Turns.Any(t => t.Scene is { Opening: true } s && c.DateSceneStates.GetValueOrDefault(s.OfferId) != "ended"))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => PrivateMessages.Mailbox(data).Conversations.Values.Any(c => c.DateSceneStates.Any(p => p.Value is "active" or "paused") || c.Turns.Any(t => t.Scene is { Opening: true } s && c.DateSceneStates.GetValueOrDefault(s.OfferId) != "ended"))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.DateSceneStates.Any(p => p.Value is "active" or "paused")`；返回值紧邻使用处：`BinaryExpressionSyntax: c.DateSceneStates.Any(p => p.Value is "active" or "paused") || c.Turns.Any(t => t.Scene is { Opening: true } s && c.DateSceneStates.GetValueOrDefault(s.OfferId) != "ended")`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.Any(t => t.Scene is { Opening: true } s && c.DateSceneStates.GetValueOrDefault(s.OfferId) != "ended")`；返回值紧邻使用处：`BinaryExpressionSyntax: c.DateSceneStates.Any(p => p.Value is "active" or "paused") || c.Turns.Any(t => t.Scene is { Opening: true } s && c.DateSceneStates.GetValueOrDefault(s.OfferId) != "ended")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`c.DateSceneStates.GetValueOrDefault(s.OfferId)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.DateSceneStates.GetValueOrDefault(s.OfferId) != "ended"`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6ac4bb7a00c7"></a>

## `NationalSpire.ConsumerInvitationStock.Ticket(NationalSpire.Good) — public static bool Ticket(Good good)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)；[`NationalSpire.CareerScreen.PrivateDateInvitationPicker()`](DateDiaryScreen.cs.md#symbol-cdf7f00bf71b)；[`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?, int)`](ConsumerEngine.cs.md#symbol-6a13be5c34c1)；[`NationalSpire.ConsumerInvitationStock.Legacy(NationalSpire.CareerData)`](ConsumerInvitationStock.cs.md#symbol-848045ea2264)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Good.Slots`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-848045ea2264"></a>

## `NationalSpire.ConsumerInvitationStock.Legacy(NationalSpire.CareerData) — private static Dictionary<string, int> Legacy(CareerData data)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerInvitationStock.Availability(NationalSpire.CareerData, string)`](ConsumerInvitationStock.cs.md#symbol-18ffa12d670c)；[`NationalSpire.ConsumerInvitationStock.Initialize(NationalSpire.CareerData)`](ConsumerInvitationStock.cs.md#symbol-5ebbf88d2106)

**调用：** [`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；[`NationalSpire.ConsumerInvitationStock.Ticket(NationalSpire.Good)`](ConsumerInvitationStock.cs.md#symbol-6ac4bb7a00c7)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.ConsumerInvitationStock.Ticket(NationalSpire.Good)`；`NationalSpire.ConsumerState.Goods`；`NationalSpire.OwnedGood.Id`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateOffer.GoodId`；`NationalSpire.PrivateOffer.SourceInvitationId`；`NationalSpire.PrivateOffer.State`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(g.Id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ConsumerCatalog.Get(g.Id) is { } good`
- `NationalSpire.ConsumerInvitationStock.Ticket(NationalSpire.Good)`；输入表达式：`Ticket(good)`；返回值紧邻使用处：`BinaryExpressionSyntax: ConsumerCatalog.Get(g.Id) is { } good && Ticket(good)`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`g.Count()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.Count()`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`g.Count()`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Count() - used.GetValueOrDefault(g.Key)`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values.SelectMany(c => c.Offers) .Where(o => o.SourceInvitationId.Length > 0 && o.State != "已拒绝").DistinctBy(o => o.SourceInvitationId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations.Values.SelectMany(c => c.Offers) .Where(o => o.SourceInvitationId.Length > 0 && o.State != "已拒绝").DistinctBy(o => o.SourceInvitationId).GroupBy`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values.SelectMany(c => c.Offers) .Where(o => o.SourceInvitationId.Length > 0 && o.State != "已拒绝").DistinctBy(o => o.SourceInvitationId).GroupBy(o => o.GoodId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations.Values.SelectMany(c => c.Offers) .Where(o => o.SourceInvitationId.Length > 0 && o.State != "已拒绝").DistinctBy(o => o.SourceInvitationId).GroupBy(o => o.GoodId).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.Life.Consumer.Goods.Where(g => ConsumerCatalog.Get(g.Id) is { } good && Ticket(good)) .GroupBy(g => g.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Life.Consumer.Goods.Where(g => ConsumerCatalog.Get(g.Id) is { } good && Ticket(good)) .GroupBy(g => g.Id).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values.SelectMany(c => c.Offers)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations.Values.SelectMany(c => c.Offers) .Where`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values.SelectMany(c => c.Offers) .Where(o => o.SourceInvitationId.Length > 0 && o.State != "已拒绝").DistinctBy(o => o.SourceInvitationId).GroupBy(o => o.GoodId).ToDictionary(g => g.Key, g => g.Count())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Mailbox(data).Conversations.Values.SelectMany(c => c.Offers) .Where(o => o.SourceInvitationId.Length > 0 && o.State != "已拒绝").DistinctBy(o => o.SourceInvitationId).GroupBy(o => o.GoodId).ToDictionary(g => g.Key, g => g.Count())`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`data.Life.Consumer.Goods.Where(g => ConsumerCatalog.Get(g.Id) is { } good && Ticket(good)) .GroupBy(g => g.Id).ToDictionary(g => g.Key, g => Math.Max(0, g.Count() - used.GetValueOrDefault(g.Key)))`；返回值紧邻使用处：`ReturnStatementSyntax: return data.Life.Consumer.Goods.Where(g => ConsumerCatalog.Get(g.Id) is { } good && Ticket(good)) .GroupBy(g => g.Id).ToDictionary(g => g.Key, g => Math.Max(0, g.Count() - used.GetValueOrDefault(g.Key)));`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values.SelectMany(c => c.Offers) .Where(o => o.SourceInvitationId.Length > 0 && o.State != "已拒绝")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations.Values.SelectMany(c => c.Offers) .Where(o => o.SourceInvitationId.Length > 0 && o.State != "已拒绝").DistinctBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Life.Consumer.Goods.Where(g => ConsumerCatalog.Get(g.Id) is { } good && Ticket(good))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Life.Consumer.Goods.Where(g => ConsumerCatalog.Get(g.Id) is { } good && Ticket(good)) .GroupBy`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`used.GetValueOrDefault(g.Key)`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Count() - used.GetValueOrDefault(g.Key)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, g.Count() - used.GetValueOrDefault(g.Key))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => Math.Max(0, g.Count() - used.GetValueOrDefault(g.Key))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5ebbf88d2106"></a>

## `NationalSpire.ConsumerInvitationStock.Initialize(NationalSpire.CareerData) — public static void Initialize(CareerData data)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?, int)`](ConsumerEngine.cs.md#symbol-6a13be5c34c1)；[`NationalSpire.ConsumerInvitationStock.Reserve(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>)`](ConsumerInvitationStock.cs.md#symbol-231e759e9078)；[`NationalSpire.ConsumerInvitationStock.Validate(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](ConsumerInvitationStock.cs.md#symbol-ad51c0c18b5f)

**调用：** [`NationalSpire.ConsumerInvitationStock.Legacy(NationalSpire.CareerData)`](ConsumerInvitationStock.cs.md#symbol-848045ea2264)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.ConsumerInvitationStock.Legacy(NationalSpire.CareerData)`；`NationalSpire.ConsumerState.InvitationStock`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerInvitationStock.Legacy(NationalSpire.CareerData)`；输入表达式：`Legacy(data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: data.Life.Consumer.InvitationStock ??= Legacy(data)`

**赋值（含属性/字段和局部值）：**

- `data.Life.Consumer.InvitationStock` ??= `Legacy(data)`

<a id="symbol-83c43c134057"></a>

## `NationalSpire.ConsumerInvitationStock.Available(NationalSpire.CareerData, string, string, string) — public static int Available(CareerData data, string goodId, string verb = "", string except = "")`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)；[`NationalSpire.ConsumerInvitationStock.Accept(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](ConsumerInvitationStock.cs.md#symbol-7f566dd43cfc)；[`NationalSpire.ConsumerInvitationStock.Validate(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](ConsumerInvitationStock.cs.md#symbol-ad51c0c18b5f)；[`NationalSpire.ConsumerInvitations.Create(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool)`](ConsumerInvitations.cs.md#symbol-cc2d01b16094)

**调用：** [`NationalSpire.ConsumerInvitationStock.Availability(NationalSpire.CareerData, string)`](ConsumerInvitationStock.cs.md#symbol-18ffa12d670c)；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerInvitationStock.Availability(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerInvitationStock.Availability(NationalSpire.CareerData, string)`；输入表达式：`Availability(data, except)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Availability(data, except).GetValueOrDefault`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`Availability(data, except).GetValueOrDefault((goodId, verb))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Availability(data, except).GetValueOrDefault((goodId, verb))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-18ffa12d670c"></a>

## `NationalSpire.ConsumerInvitationStock.Availability(NationalSpire.CareerData, string) — public static Dictionary<(string Good, string Verb), int> Availability(CareerData data, string except = "")`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateDateInvitationPicker()`](DateDiaryScreen.cs.md#symbol-cdf7f00bf71b)；[`NationalSpire.ConsumerInvitationStock.Available(NationalSpire.CareerData, string, string, string)`](ConsumerInvitationStock.cs.md#symbol-83c43c134057)；[`NationalSpire.ConsumerPurchases.ConsumerPurchases(NationalSpire.CareerData)`](ConsumerPurchases.cs.md#symbol-270a101e0b54)

**调用：** [`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；[`NationalSpire.ConsumerInvitationStock.Legacy(NationalSpire.CareerData)`](ConsumerInvitationStock.cs.md#symbol-848045ea2264)；[`NationalSpire.ConsumerInvitations.Pending(NationalSpire.PrivateConversation)`](ConsumerInvitations.cs.md#symbol-ce030fcb265a)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.ConsumerInvitationStock.Legacy(NationalSpire.CareerData)`；`NationalSpire.ConsumerInvitations.Kind`；`NationalSpire.ConsumerInvitations.Pending(NationalSpire.PrivateConversation)`；`NationalSpire.ConsumerState.Goods`；`NationalSpire.ConsumerState.InvitationReservations`；`NationalSpire.ConsumerState.InvitationStock`；`NationalSpire.Good.Verbs`；`NationalSpire.GoodVerb.Id`；`NationalSpire.InvitationReservation.Consumed`；`NationalSpire.InvitationReservation.GoodId`；`NationalSpire.InvitationReservation.Id`；`NationalSpire.InvitationReservation.Verb`；`NationalSpire.OwnedGood.Durable`；`NationalSpire.OwnedGood.Id`；`NationalSpire.OwnedGood.UsedSeason`；`NationalSpire.OwnedGood.UsedVerbs`；`NationalSpire.PrivateConversation.GiftDrafts`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateOffer.InvitationReservation`；`NationalSpire.PrivateOffer.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(owned.Id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: ConsumerCatalog.Get(owned.Id)?.Verbs`
- `NationalSpire.ConsumerInvitationStock.Legacy(NationalSpire.CareerData)`；输入表达式：`Legacy(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: data.Life.Consumer.InvitationStock ?? Legacy(data)`
- `NationalSpire.ConsumerInvitations.Pending(NationalSpire.PrivateConversation)`；输入表达式：`ConsumerInvitations.Pending(c)`；返回值紧邻使用处：`ArgumentSyntax: ConsumerInvitations.Pending(c)`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`live.Contains(r.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: !r.Consumed && r.Id != except && live.Contains(r.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`c.GiftDrafts.Concat(ConsumerInvitations.Pending(c))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => c.GiftDrafts.Concat(ConsumerInvitations.Pending(c))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values.SelectMany(c => c.GiftDrafts.Concat(ConsumerInvitations.Pending(c))) .Where(a => a.Kind == ConsumerInvitations.Kind).Select(a => a.InvitationReservation)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations.Values.SelectMany(c => c.GiftDrafts.Concat(ConsumerInvitations.Pending(c))) .Where(a => a.Kind == ConsumerInvitations.Kind).Select(a => a.InvitationReservation).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values.SelectMany(c => c.GiftDrafts.Concat(ConsumerInvitations.Pending(c)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations.Values.SelectMany(c => c.GiftDrafts.Concat(ConsumerInvitations.Pending(c))) .Where`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`(data.Life.Consumer.InvitationStock ?? Legacy(data)).ToDictionary(p => (p.Key, ""), p => p.Value)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = (data.Life.Consumer.InvitationStock ?? Legacy(data)).ToDictionary(p => (p.Key, ""), p => p.Value)`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values.SelectMany(c => c.GiftDrafts.Concat(ConsumerInvitations.Pending(c))) .Where(a => a.Kind == ConsumerInvitations.Kind).Select(a => a.InvitationReservation).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Mailbox(data).Conversations.Values.SelectMany(c => c.GiftDrafts.Concat(ConsumerInvitations.Pending(c))) .Where(a => a.Kind == ConsumerInvitations.Kind).Select(a => a.InvitationReservation).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values.SelectMany(c => c.GiftDrafts.Concat(ConsumerInvitations.Pending(c))) .Where(a => a.Kind == ConsumerInvitations.Kind)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations.Values.SelectMany(c => c.GiftDrafts.Concat(ConsumerInvitations.Pending(c))) .Where(a => a.Kind == ConsumerInvitations.Kind).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Life.Consumer.Goods.Where(g => g.Durable)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var owned in data.Life.Consumer.Goods.Where(g => g.Durable)) { foreach (var verb in ConsumerCatalog.Get(owned.Id)?.Verbs ?? []) counts[(owned.Id, verb.Id)] = owned.UsedSeason == data.Season && owned.UsedVerbs.Contains(verb.Id) ? 0 : 1; }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Life.Consumer.InvitationReservations.Values.Where(r => !r.Consumed && r.Id != except && live.Contains(r.Id))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var reservation in data.Life.Consumer.InvitationReservations.Values.Where(r => !r.Consumed && r.Id != except && live.Contains(r.Id))) { var key = (reservation.GoodId, reservation.Verb); counts[key] = Math.Max(0, counts.GetValueOrDefault(key) - 1); }`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`counts.GetValueOrDefault(key)`；返回值紧邻使用处：`BinaryExpressionSyntax: counts.GetValueOrDefault(key) - 1`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`owned.UsedVerbs.Contains(verb.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: owned.UsedSeason == data.Season && owned.UsedVerbs.Contains(verb.Id)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, counts.GetValueOrDefault(key) - 1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: counts[key] = Math.Max(0, counts.GetValueOrDefault(key) - 1)`

**赋值（含属性/字段和局部值）：**

- `counts[(owned.Id, verb.Id)]` = `owned.UsedSeason == data.Season && owned.UsedVerbs.Contains(verb.Id) ? 0 : 1`
- `counts[key]` = `Math.Max(0, counts.GetValueOrDefault(key) - 1)`

<a id="symbol-231e759e9078"></a>

## `NationalSpire.ConsumerInvitationStock.Reserve(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>) — public static string Reserve(CareerData data, string goodId, string verb, IReadOnlyList<string> people)`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerInvitationStock.Validate(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](ConsumerInvitationStock.cs.md#symbol-ad51c0c18b5f)；[`NationalSpire.ConsumerInvitations.Create(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool)`](ConsumerInvitations.cs.md#symbol-cc2d01b16094)

**调用：** [`NationalSpire.ConsumerInvitationStock.Initialize(NationalSpire.CareerData)`](ConsumerInvitationStock.cs.md#symbol-5ebbf88d2106)；`NationalSpire.InvitationReservation.InvitationReservation()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.ConsumerInvitationStock.Initialize(NationalSpire.CareerData)`；`NationalSpire.ConsumerState.InvitationReservations`；`NationalSpire.InvitationReservation.GoodId`；`NationalSpire.InvitationReservation.Id`；`NationalSpire.InvitationReservation.People`；`NationalSpire.InvitationReservation.Verb`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerInvitationStock.Initialize(NationalSpire.CareerData)`；输入表达式：`Initialize(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: Initialize(data);`
- `NationalSpire.InvitationReservation.InvitationReservation()`；输入表达式：`new InvitationReservation { GoodId = goodId, Verb = verb, People = people.ToList() }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new InvitationReservation { GoodId = goodId, Verb = verb, People = people.ToList() }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`data.Life.Consumer.InvitationReservations.Add(item.Id, item)`；返回值紧邻使用处：`ExpressionStatementSyntax: data.Life.Consumer.InvitationReservations.Add(item.Id, item);`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`people.ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: People = people.ToList()`

**赋值（含属性/字段和局部值）：**

- `GoodId` = `goodId`
- `People` = `people.ToList()`
- `Verb` = `verb`

<a id="symbol-ad51c0c18b5f"></a>

## `NationalSpire.ConsumerInvitationStock.Validate(NationalSpire.CareerData, string, NationalSpire.PrivateOffer) — public static string? Validate(CareerData data, string person, PrivateOffer invitation)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerInvitationStock.Accept(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](ConsumerInvitationStock.cs.md#symbol-7f566dd43cfc)；[`NationalSpire.ConsumerInvitations.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](ConsumerInvitations.cs.md#symbol-9f0c7f580228)

**调用：** [`NationalSpire.ConsumerInvitationStock.Available(NationalSpire.CareerData, string, string, string)`](ConsumerInvitationStock.cs.md#symbol-83c43c134057)；[`NationalSpire.ConsumerInvitationStock.Initialize(NationalSpire.CareerData)`](ConsumerInvitationStock.cs.md#symbol-5ebbf88d2106)；[`NationalSpire.ConsumerInvitationStock.Reserve(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>)`](ConsumerInvitationStock.cs.md#symbol-231e759e9078)；[`NationalSpire.ConsumerInvitations.IsWedding(NationalSpire.PrivateOffer)`](ConsumerInvitations.cs.md#symbol-79a9e4bf9389)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.ConsumerInvitationStock.Available(NationalSpire.CareerData, string, string, string)`；`NationalSpire.ConsumerInvitationStock.Initialize(NationalSpire.CareerData)`；`NationalSpire.ConsumerInvitationStock.Reserve(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>)`；`NationalSpire.ConsumerInvitations.IsWedding(NationalSpire.PrivateOffer)`；`NationalSpire.ConsumerState.InvitationReservations`；`NationalSpire.InvitationReservation.GoodId`；`NationalSpire.InvitationReservation.People`；`NationalSpire.InvitationReservation.Verb`；`NationalSpire.PrivateMailbox.Relations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateOffer.GoodId`；`NationalSpire.PrivateOffer.GoodVerb`；`NationalSpire.PrivateOffer.InvitationReservation`；`NationalSpire.PrivateRelation.RingReceived`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerInvitationStock.Available(NationalSpire.CareerData, string, string, string)`；输入表达式：`Available(data, invitation.GoodId, invitation.GoodVerb)`；返回值紧邻使用处：`BinaryExpressionSyntax: Available(data, invitation.GoodId, invitation.GoodVerb) == 0`
- `NationalSpire.ConsumerInvitationStock.Initialize(NationalSpire.CareerData)`；输入表达式：`Initialize(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: Initialize(data);`
- `NationalSpire.ConsumerInvitationStock.Reserve(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>)`；输入表达式：`Reserve(data, invitation.GoodId, invitation.GoodVerb, [person])`；返回值紧邻使用处：`AssignmentExpressionSyntax: invitation.InvitationReservation = Reserve(data, invitation.GoodId, invitation.GoodVerb, [person])`
- `NationalSpire.ConsumerInvitations.IsWedding(NationalSpire.PrivateOffer)`；输入表达式：`ConsumerInvitations.IsWedding(invitation)`；返回值紧邻使用处：`BinaryExpressionSyntax: ConsumerInvitations.IsWedding(invitation) && PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(person)?.RingReceived != true`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Relations`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(person)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(person)?.RingReceived`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`data.Life.Consumer.InvitationReservations.GetValueOrDefault(invitation.InvitationReservation)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Life.Consumer.InvitationReservations.GetValueOrDefault(invitation.InvitationReservation)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`saved.People.Contains(person)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !saved.People.Contains(person)`

**赋值（含属性/字段和局部值）：**

- `invitation.InvitationReservation` = `Reserve(data, invitation.GoodId, invitation.GoodVerb, [person])`

<a id="symbol-7f566dd43cfc"></a>

## `NationalSpire.ConsumerInvitationStock.Accept(NationalSpire.CareerData, string, NationalSpire.PrivateOffer) — public static string? Accept(CareerData data, string person, PrivateOffer invitation)`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.SocialAppointments.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`](SocialAppointments.cs.md#symbol-33a4725630bd)

**调用：** [`NationalSpire.ConsumerEngine.Use(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool)`](ConsumerEngine.cs.md#symbol-c0beece783ab)；[`NationalSpire.ConsumerInvitationStock.Available(NationalSpire.CareerData, string, string, string)`](ConsumerInvitationStock.cs.md#symbol-83c43c134057)；[`NationalSpire.ConsumerInvitationStock.Validate(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](ConsumerInvitationStock.cs.md#symbol-ad51c0c18b5f)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.ConsumerEngine.Use(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool)`；`NationalSpire.ConsumerInvitationStock.Available(NationalSpire.CareerData, string, string, string)`；`NationalSpire.ConsumerInvitationStock.Validate(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；`NationalSpire.ConsumerState.Goods`；`NationalSpire.ConsumerState.InvitationReservations`；`NationalSpire.ConsumerState.InvitationStock`；`NationalSpire.InvitationReservation.Consumed`；`NationalSpire.InvitationReservation.GoodId`；`NationalSpire.InvitationReservation.Id`；`NationalSpire.InvitationReservation.Verb`；`NationalSpire.OwnedGood.Consumed`；`NationalSpire.OwnedGood.Id`；`NationalSpire.PrivateOffer.InvitationReservation`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ConsumerEngine.Use(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>, bool)`；输入表达式：`ConsumerEngine.Use(data, item.GoodId, item.Verb, [person], planned: true)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ConsumerEngine.Use(data, item.GoodId, item.Verb, [person], planned: true) is { } useError`
- `NationalSpire.ConsumerInvitationStock.Available(NationalSpire.CareerData, string, string, string)`；输入表达式：`Available(data, item.GoodId, item.Verb, item.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: Available(data, item.GoodId, item.Verb, item.Id) == 0`
- `NationalSpire.ConsumerInvitationStock.Validate(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；输入表达式：`Validate(data, person, invitation)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Validate(data, person, invitation) is { } error`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Life.Consumer.Goods.FirstOrDefault(g => g.Id == item.GoodId && !g.Consumed)`；返回值紧邻使用处：`IsPatternExpressionSyntax: data.Life.Consumer.Goods.FirstOrDefault(g => g.Id == item.GoodId && !g.Consumed) is { } purchased`

**赋值（含属性/字段和局部值）：**

- `item.Consumed` = `true`
- `purchased.Consumed` = `true`
