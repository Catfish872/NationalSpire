# WeddingAppointments.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`4224AE9A3D9DBF1F22B12FB8750BB64AA72083AA443CAD820B70A3CB27F42DD9`。来源：[源码](../../WeddingAppointments.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.WeddingAppointments`。

字段、事件及初始值（源码原样）：

```csharp
public const string GoodId = "grand-wedding";
public static readonly GoodVerb Verb = new("wedding", "举办婚礼", 1, 0);
```

<a id="symbol-35e35b4dd8e0"></a>

## `NationalSpire.WeddingAppointments.Conversations(NationalSpire.CareerData) — private static IEnumerable<PrivateConversation> Conversations(CareerData data)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.WeddingAppointments.Services(NationalSpire.CareerData)`](WeddingAppointments.cs.md#symbol-2dfb2ee379ae)

**调用：** [`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`string.StartsWith(string, System.StringComparison)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.GroupChat.Interactions`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: GroupChats.Human(data) + "/"`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`p.Key.StartsWith(GroupChats.Human(data) + "/", StringComparison.Ordinal)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => p.Key.StartsWith(GroupChats.Human(data) + "/", StringComparison.Ordinal)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values          .Concat(data.Chats.Groups.SelectMany(g => g.Interactions.Where(p => p.Key.StartsWith(GroupChats.Human(data) + "/", StringComparison.Ordinal)).Select(p => p.Value)))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => PrivateMessages.Mailbox(data).Conversations.Values          .Concat(data.Chats.Groups.SelectMany(g => g.Interactions.Where(p => p.Key.StartsWith(GroupChats.Human(data) + "/", StringComparison.Ordinal)).Select(p => p.Value)))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`g.Interactions.Where(p => p.Key.StartsWith(GroupChats.Human(data) + "/", StringComparison.Ordinal)).Select(p => p.Value)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.Interactions.Where(p => p.Key.StartsWith(GroupChats.Human(data) + "/", StringComparison.Ordinal)).Select(p => p.Value)`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`data.Chats.Groups.SelectMany(g => g.Interactions.Where(p => p.Key.StartsWith(GroupChats.Human(data) + "/", StringComparison.Ordinal)).Select(p => p.Value))`；返回值紧邻使用处：`ArgumentSyntax: data.Chats.Groups.SelectMany(g => g.Interactions.Where(p => p.Key.StartsWith(GroupChats.Human(data) + "/", StringComparison.Ordinal)).Select(p => p.Value))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Interactions.Where(p => p.Key.StartsWith(GroupChats.Human(data) + "/", StringComparison.Ordinal))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Interactions.Where(p => p.Key.StartsWith(GroupChats.Human(data) + "/", StringComparison.Ordinal)).Select`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f30a9608f6f8"></a>

## `NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer) — public static bool IsWedding(PrivateOffer offer)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.SocialAppointments.Attend(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool, bool)`](SocialAppointments.cs.md#symbol-59e09ef2b579)；[`NationalSpire.WeddingAppointments.Complete(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-4cb46102c2e0)；[`NationalSpire.WeddingAppointments.Error(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-9b3600926b30)；[`NationalSpire.WeddingAppointments.Services(NationalSpire.CareerData)`](WeddingAppointments.cs.md#symbol-2dfb2ee379ae)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.GoodVerb.Id`；`NationalSpire.PrivateOffer.GoodId`；`NationalSpire.PrivateOffer.GoodVerb`；`NationalSpire.WeddingAppointments.GoodId`；`NationalSpire.WeddingAppointments.Verb`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2dfb2ee379ae"></a>

## `NationalSpire.WeddingAppointments.Services(NationalSpire.CareerData) — public static IEnumerable<(string Id, string Person, long Remaining, string GoodId)> Services(CareerData data)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`](ConsumerPickerScreen.cs.md#symbol-0f5d28176960)；[`NationalSpire.WeddingAppointments.Error(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-9b3600926b30)

**调用：** [`NationalSpire.RelationshipGifts.Special(string)`](RelationshipGifts.cs.md#symbol-d05881b51110)；[`NationalSpire.WeddingAppointments.Conversations(NationalSpire.CareerData)`](WeddingAppointments.cs.md#symbol-35e35b4dd8e0)；[`NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-f30a9608f6f8)；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.LongCount<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `(string Id, string Person, long Remaining, string GoodId).GoodId`；`(string Id, string Person, long Remaining, string GoodId).Id`；`(string Id, string Person, long Remaining, string GoodId).Person`；`(string Id, string Person, long Remaining, string GoodId).Remaining`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateOffer.ActorId`；`NationalSpire.PrivateOffer.GoodId`；`NationalSpire.PrivateOffer.GroupId`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Quantity`；`NationalSpire.PrivateOffer.ServiceId`；`NationalSpire.PrivateOffer.State`；`NationalSpire.RelationshipGifts.Special(string)`；`NationalSpire.WeddingAppointments.Conversations(NationalSpire.CareerData)`；`NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RelationshipGifts.Special(string)`；输入表达式：`RelationshipGifts.Special(o.GoodId)`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Kind == "gift" && RelationshipGifts.Special(o.GoodId)`
- `NationalSpire.WeddingAppointments.Conversations(NationalSpire.CareerData)`；输入表达式：`Conversations(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Conversations(data).SelectMany`
- `NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`；输入表达式：`IsWedding(o)`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Kind == "activity" && IsWedding(o)`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`offers.Where(o => o.Kind == "activity" && IsWedding(o) && o.ServiceId.Length > 0 && o.State is "已赴约" or "已结束")              .GroupBy(o => o.ServiceId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: offers.Where(o => o.Kind == "activity" && IsWedding(o) && o.ServiceId.Length > 0 && o.State is "已赴约" or "已结束")              .GroupBy(o => o.ServiceId).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.LongCount<TSource>()`；输入表达式：`g.LongCount()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.LongCount()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`offers.Where(o => o.Kind == "gift" && RelationshipGifts.Special(o.GoodId) && o.State == "已接受")              .Select(o => (Id: o.GroupId + "/" + o.Id, Person: o.ActorId, Remaining: o.Quantity - used.GetValueOrDefault(o.GroupId + "/" + o.Id), GoodId: o.GoodId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: offers.Where(o => o.Kind == "gift" && RelationshipGifts.Special(o.GoodId) && o.State == "已接受")              .Select(o => (Id: o.GroupId + "/" + o.Id, Person: o.ActorId, Remaining: o.Quantity - used.GetValueOrDefault(o.GroupId + "/" + o.Id), GoodId: o.GoodId))              .Where`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`Conversations(data).SelectMany(c => c.Offers)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Conversations(data).SelectMany(c => c.Offers).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Conversations(data).SelectMany(c => c.Offers).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Conversations(data).SelectMany(c => c.Offers).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`offers.Where(o => o.Kind == "activity" && IsWedding(o) && o.ServiceId.Length > 0 && o.State is "已赴约" or "已结束")              .GroupBy(o => o.ServiceId).ToDictionary(g => g.Key, g => g.LongCount())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = offers.Where(o => o.Kind == "activity" && IsWedding(o) && o.ServiceId.Length > 0 && o.State is "已赴约" or "已结束")              .GroupBy(o => o.ServiceId).ToDictionary(g => g.Key, g => g.LongCount())`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`offers.Where(o => o.Kind == "activity" && IsWedding(o) && o.ServiceId.Length > 0 && o.State is "已赴约" or "已结束")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: offers.Where(o => o.Kind == "activity" && IsWedding(o) && o.ServiceId.Length > 0 && o.State is "已赴约" or "已结束")              .GroupBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`offers.Where(o => o.Kind == "gift" && RelationshipGifts.Special(o.GoodId) && o.State == "已接受")              .Select(o => (Id: o.GroupId + "/" + o.Id, Person: o.ActorId, Remaining: o.Quantity - used.GetValueOrDefault(o.GroupId + "/" + o.Id), GoodId: o.GoodId))              .Where(s => s.Remaining > 0)`；返回值紧邻使用处：`ReturnStatementSyntax: return offers.Where(o => o.Kind == "gift" && RelationshipGifts.Special(o.GoodId) && o.State == "已接受")              .Select(o => (Id: o.GroupId + "/" + o.Id, Person: o.ActorId, Remaining: o.Quantity - used.GetValueOrDefault(o.GroupId + "/" + o.Id), GoodId: o.GoodId))              .Where(s => s.Remaining > 0);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`offers.Where(o => o.Kind == "gift" && RelationshipGifts.Special(o.GoodId) && o.State == "已接受")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: offers.Where(o => o.Kind == "gift" && RelationshipGifts.Special(o.GoodId) && o.State == "已接受")              .Select`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`used.GetValueOrDefault(o.GroupId + "/" + o.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Quantity - used.GetValueOrDefault(o.GroupId + "/" + o.Id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9b3600926b30"></a>

## `NationalSpire.WeddingAppointments.Error(NationalSpire.CareerData, NationalSpire.PrivateOffer) — public static string? Error(CareerData data, PrivateOffer offer)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool)`](ChatAttachments.cs.md#symbol-4e7c361b1f77)

**调用：** [`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-24bc82bdbbd4)；[`NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-f30a9608f6f8)；[`NationalSpire.WeddingAppointments.Services(NationalSpire.CareerData)`](WeddingAppointments.cs.md#symbol-2dfb2ee379ae)；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `(string Id, string Person, long Remaining, string GoodId).GoodId`；`(string Id, string Person, long Remaining, string GoodId).Id`；`(string Id, string Person, long Remaining, string GoodId).Person`；`(string Id, string Person, long Remaining, string GoodId).Remaining`；`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.GoodId`；`NationalSpire.PrivateOffer.Participants`；`NationalSpire.PrivateOffer.ServiceId`；`NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`；`NationalSpire.WeddingAppointments.Services(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.IsHuman(data, id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GroupChats.IsHuman(data, id)`
- `NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`；输入表达式：`IsWedding(offer)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsWedding(offer)`
- `NationalSpire.WeddingAppointments.Services(NationalSpire.CareerData)`；输入表达式：`Services(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Services(data).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`offer.Participants.Where(id => !GroupChats.IsHuman(data, id)).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: offer.Participants.Where(id => !GroupChats.IsHuman(data, id)).Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`Services(data).FirstOrDefault(s => s.Id == offer.ServiceId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Services(data).FirstOrDefault(s => s.Id == offer.ServiceId)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`offer.Participants.Where(id => !GroupChats.IsHuman(data, id)).Distinct().ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = offer.Participants.Where(id => !GroupChats.IsHuman(data, id)).Distinct().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`offer.Participants.Where(id => !GroupChats.IsHuman(data, id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: offer.Participants.Where(id => !GroupChats.IsHuman(data, id)).Distinct`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4cb46102c2e0"></a>

## `NationalSpire.WeddingAppointments.Complete(NationalSpire.CareerData, NationalSpire.PrivateOffer) — public static void Complete(CareerData data, PrivateOffer offer)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.Leave(NationalSpire.CareerData, NationalSpire.PrivateConversation, string, bool)`](DateSceneData.cs.md#symbol-81bdbfbfe1d8)；[`NationalSpire.SocialAppointments.Attend(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool, bool)`](SocialAppointments.cs.md#symbol-59e09ef2b579)

**调用：** [`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-24bc82bdbbd4)；[`NationalSpire.RelationshipPresentation.CompleteWedding(NationalSpire.CareerData, string)`](RelationshipPresentation.cs.md#symbol-49a406ddaa23)；[`NationalSpire.SocialAppointments.PublishAttendance(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](SocialAppointments.cs.md#symbol-47965830082f)；[`NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-f30a9608f6f8)；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Participants`；`NationalSpire.PrivateOffer.PublicAttendance`；`NationalSpire.RelationshipPresentation.CompleteWedding(NationalSpire.CareerData, string)`；`NationalSpire.SocialAppointments.PublishAttendance(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.IsHuman(data, id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GroupChats.IsHuman(data, id)`
- `NationalSpire.RelationshipPresentation.CompleteWedding(NationalSpire.CareerData, string)`；输入表达式：`RelationshipPresentation.CompleteWedding(data, person)`；返回值紧邻使用处：`ExpressionStatementSyntax: RelationshipPresentation.CompleteWedding(data, person);`
- `NationalSpire.SocialAppointments.PublishAttendance(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`SocialAppointments.PublishAttendance(data, offer)`；返回值紧邻使用处：`ExpressionStatementSyntax: SocialAppointments.PublishAttendance(data, offer);`
- `NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`；输入表达式：`IsWedding(offer)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsWedding(offer)`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`offer.Participants.Where(id => !GroupChats.IsHuman(data, id)).Distinct()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string person in offer.Participants.Where(id => !GroupChats.IsHuman(data, id)).Distinct()) RelationshipPresentation.CompleteWedding(data, person);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`offer.Participants.Where(id => !GroupChats.IsHuman(data, id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: offer.Participants.Where(id => !GroupChats.IsHuman(data, id)).Distinct`

**赋值（含属性/字段和局部值）：**
