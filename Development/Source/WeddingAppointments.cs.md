# WeddingAppointments.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`DD6420ED30F098666EAC090481E797CF5BFD073FFC9CF66E223F78EFDFE2359B`。来源：[源码](../../WeddingAppointments.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

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

**调用者：** [`NationalSpire.WeddingAppointments.Accepted(NationalSpire.CareerData)`](WeddingAppointments.cs.md#symbol-9185c503bf33)；[`NationalSpire.WeddingAppointments.Services(NationalSpire.CareerData)`](WeddingAppointments.cs.md#symbol-2dfb2ee379ae)

**调用：** [`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`string.StartsWith(string, System.StringComparison)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.GroupChat.Interactions`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: GroupChats.Human(data) + "/"`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values .Concat(data.Chats.Groups.SelectMany(g => g.Interactions.Where(p => p.Key.StartsWith(GroupChats.Human(data) + "/", StringComparison.Ordinal)).Select(p => p.Value)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations.Values .Concat(data.Chats.Groups.SelectMany(g => g.Interactions.Where(p => p.Key.StartsWith(GroupChats.Human(data) + "/", StringComparison.Ordinal)).Select(p => p.Value))).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values .Concat(data.Chats.Groups.SelectMany(g => g.Interactions.Where(p => p.Key.StartsWith(GroupChats.Human(data) + "/", StringComparison.Ordinal)).Select(p => p.Value))).Distinct()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => PrivateMessages.Mailbox(data).Conversations.Values .Concat(data.Chats.Groups.SelectMany(g => g.Interactions.Where(p => p.Key.StartsWith(GroupChats.Human(data) + "/", StringComparison.Ordinal)).Select(p => p.Value))).Distinct()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`g.Interactions.Where(p => p.Key.StartsWith(GroupChats.Human(data) + "/", StringComparison.Ordinal)).Select(p => p.Value)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.Interactions.Where(p => p.Key.StartsWith(GroupChats.Human(data) + "/", StringComparison.Ordinal)).Select(p => p.Value)`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`data.Chats.Groups.SelectMany(g => g.Interactions.Where(p => p.Key.StartsWith(GroupChats.Human(data) + "/", StringComparison.Ordinal)).Select(p => p.Value))`；返回值紧邻使用处：`ArgumentSyntax: data.Chats.Groups.SelectMany(g => g.Interactions.Where(p => p.Key.StartsWith(GroupChats.Human(data) + "/", StringComparison.Ordinal)).Select(p => p.Value))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Interactions.Where(p => p.Key.StartsWith(GroupChats.Human(data) + "/", StringComparison.Ordinal))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Interactions.Where(p => p.Key.StartsWith(GroupChats.Human(data) + "/", StringComparison.Ordinal)).Select`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`p.Key.StartsWith(GroupChats.Human(data) + "/", StringComparison.Ordinal)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => p.Key.StartsWith(GroupChats.Human(data) + "/", StringComparison.Ordinal)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f30a9608f6f8"></a>

## `NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer) — public static bool IsWedding(PrivateOffer offer)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`](GroupChatScreen.cs.md#symbol-3afa41099b93)；[`NationalSpire.ChatAttachments.ResponseInstructions(NationalSpire.CareerData, NationalSpire.PrivateOffer, string, NationalSpire.GroupChat?, string)`](ChatAttachments.cs.md#symbol-f98de794e2ca)；[`NationalSpire.DateScenes.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest, bool)`](DateSceneData.cs.md#symbol-190a72e967ad)；[`NationalSpire.SocialAppointments.Attend(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool, bool)`](SocialAppointments.cs.md#symbol-59e09ef2b579)；[`NationalSpire.WeddingAppointments.Complete(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-4cb46102c2e0)；[`NationalSpire.WeddingAppointments.Description(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-b0c3ba2ccdb6)；[`NationalSpire.WeddingAppointments.Error(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-9b3600926b30)；[`NationalSpire.WeddingAppointments.Partners(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-854bd494f2d0)；[`NationalSpire.WeddingAppointments.Services(NationalSpire.CareerData)`](WeddingAppointments.cs.md#symbol-2dfb2ee379ae)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.GoodVerb.Id`；`NationalSpire.PrivateOffer.GoodId`；`NationalSpire.PrivateOffer.GoodVerb`；`NationalSpire.WeddingAppointments.GoodId`；`NationalSpire.WeddingAppointments.Verb`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-920147fd431a"></a>

## `NationalSpire.WeddingAppointments.ServiceIds(NationalSpire.PrivateOffer) — public static string[] ServiceIds(PrivateOffer offer)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`](ConsumerPickerScreen.cs.md#symbol-0f5d28176960)；[`NationalSpire.WeddingAppointments.Error(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-9b3600926b30)；[`NationalSpire.WeddingAppointments.Partners(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-854bd494f2d0)；[`NationalSpire.WeddingAppointments.Services(NationalSpire.CareerData)`](WeddingAppointments.cs.md#symbol-2dfb2ee379ae)

**调用：** `System.Collections.Generic.List<T>.ToArray()`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateOffer.ServiceId`；`NationalSpire.PrivateOffer.WeddingServiceIds`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`offer.WeddingServiceIds.ToArray()`；返回值紧邻使用处：`ConditionalExpressionSyntax: offer.WeddingServiceIds.Count > 0 ? offer.WeddingServiceIds.ToArray() : offer.ServiceId.Length > 0 ? [offer.ServiceId] : []`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9185c503bf33"></a>

## `NationalSpire.WeddingAppointments.Accepted(NationalSpire.CareerData) — private static IEnumerable<PrivateOffer> Accepted(CareerData data)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.WeddingAppointments.Partners(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-854bd494f2d0)

**调用：** [`NationalSpire.RelationshipGifts.Special(string)`](RelationshipGifts.cs.md#symbol-d05881b51110)；[`NationalSpire.WeddingAppointments.Conversations(NationalSpire.CareerData)`](WeddingAppointments.cs.md#symbol-35e35b4dd8e0)；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateOffer.GoodId`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.State`；`NationalSpire.RelationshipGifts.Special(string)`；`NationalSpire.WeddingAppointments.Conversations(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RelationshipGifts.Special(string)`；输入表达式：`RelationshipGifts.Special(o.GoodId)`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Kind == "gift" && RelationshipGifts.Special(o.GoodId)`
- `NationalSpire.WeddingAppointments.Conversations(NationalSpire.CareerData)`；输入表达式：`Conversations(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Conversations(data).SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`Conversations(data).SelectMany(c => c.Offers)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Conversations(data).SelectMany(c => c.Offers) .Where`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Conversations(data).SelectMany(c => c.Offers) .Where(o => o.Kind == "gift" && RelationshipGifts.Special(o.GoodId) && o.State == "已接受")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Conversations(data).SelectMany(c => c.Offers) .Where(o => o.Kind == "gift" && RelationshipGifts.Special(o.GoodId) && o.State == "已接受")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-854bd494f2d0"></a>

## `NationalSpire.WeddingAppointments.Partners(NationalSpire.CareerData, NationalSpire.PrivateOffer) — public static string[] Partners(CareerData data, PrivateOffer offer)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.WeddingAppointments.Complete(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-4cb46102c2e0)；[`NationalSpire.WeddingAppointments.Description(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-b0c3ba2ccdb6)

**调用：** [`NationalSpire.WeddingAppointments.Accepted(NationalSpire.CareerData)`](WeddingAppointments.cs.md#symbol-9185c503bf33)；[`NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-f30a9608f6f8)；[`NationalSpire.WeddingAppointments.ServiceIds(NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-920147fd431a)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateOffer.ActorId`；`NationalSpire.PrivateOffer.GroupId`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.WeddingAppointments.Accepted(NationalSpire.CareerData)`；`NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`；`NationalSpire.WeddingAppointments.ServiceIds(NationalSpire.PrivateOffer)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.WeddingAppointments.Accepted(NationalSpire.CareerData)`；输入表达式：`Accepted(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Accepted(data).Where`
- `NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`；输入表达式：`IsWedding(offer)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsWedding(offer)`
- `NationalSpire.WeddingAppointments.ServiceIds(NationalSpire.PrivateOffer)`；输入表达式：`ServiceIds(offer)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ServiceIds(offer).ToHashSet`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`ids.Contains(o.GroupId + "/" + o.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: o => ids.Contains(o.GroupId + "/" + o.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`Accepted(data).Where(o => ids.Contains(o.GroupId + "/" + o.Id)).Select(o => o.ActorId).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Accepted(data).Where(o => ids.Contains(o.GroupId + "/" + o.Id)).Select(o => o.ActorId).Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Accepted(data).Where(o => ids.Contains(o.GroupId + "/" + o.Id)).Select(o => o.ActorId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Accepted(data).Where(o => ids.Contains(o.GroupId + "/" + o.Id)).Select(o => o.ActorId).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Accepted(data).Where(o => ids.Contains(o.GroupId + "/" + o.Id)).Select(o => o.ActorId).Distinct().ToArray()`；返回值紧邻使用处：`ReturnStatementSyntax: return Accepted(data).Where(o => ids.Contains(o.GroupId + "/" + o.Id)).Select(o => o.ActorId).Distinct().ToArray();`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`ServiceIds(offer).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ServiceIds(offer).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Accepted(data).Where(o => ids.Contains(o.GroupId + "/" + o.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Accepted(data).Where(o => ids.Contains(o.GroupId + "/" + o.Id)).Select`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b0c3ba2ccdb6"></a>

## `NationalSpire.WeddingAppointments.Description(NationalSpire.CareerData, NationalSpire.PrivateOffer) — public static string Description(CareerData data, PrivateOffer offer)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`](GroupChatScreen.cs.md#symbol-3afa41099b93)；[`NationalSpire.ChatAttachments.ResponseInstructions(NationalSpire.CareerData, NationalSpire.PrivateOffer, string, NationalSpire.GroupChat?, string)`](ChatAttachments.cs.md#symbol-f98de794e2ca)；[`NationalSpire.DateScenes.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest, bool)`](DateSceneData.cs.md#symbol-190a72e967ad)；[`NationalSpire.GroupChatPrompts.InteractionContext(NationalSpire.CareerData, NationalSpire.GroupChat, int, string, string)`](GroupChatPrompts.cs.md#symbol-ccc55b5e837d)；[`NationalSpire.PrivateMessagePrompts.OfferContext(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer, bool)`](PrivateMessagePrompts.cs.md#symbol-67bd27e9ea35)；[`NationalSpire.SocialAppointments.PublishAttendance(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](SocialAppointments.cs.md#symbol-47965830082f)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；[`NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-f30a9608f6f8)；[`NationalSpire.WeddingAppointments.Partners(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-854bd494f2d0)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`；`NationalSpire.WeddingAppointments.Partners(NationalSpire.CareerData, NationalSpire.PrivateOffer)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: "结婚对象：" + CareerEngine.Name(data)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(data, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => GroupChats.Name(data, id)`
- `NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`；输入表达式：`IsWedding(offer)`；返回值紧邻使用处：`ConditionalExpressionSyntax: IsWedding(offer) ? "结婚对象：" + CareerEngine.Name(data) + "与" + string.Join("、", Partners(data, offer).Select(id => GroupChats.Name(data, id))) + "；其余同行者作为宾客参加。" : ""`
- `NationalSpire.WeddingAppointments.Partners(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`Partners(data, offer)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Partners(data, offer).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Partners(data, offer).Select(id => GroupChats.Name(data, id))`；返回值紧邻使用处：`ArgumentSyntax: Partners(data, offer).Select(id => GroupChats.Name(data, id))`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", Partners(data, offer).Select(id => GroupChats.Name(data, id)))`；返回值紧邻使用处：`BinaryExpressionSyntax: "结婚对象：" + CareerEngine.Name(data) + "与" + string.Join("、", Partners(data, offer).Select(id => GroupChats.Name(data, id)))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2dfb2ee379ae"></a>

## `NationalSpire.WeddingAppointments.Services(NationalSpire.CareerData) — public static IEnumerable<(string Id, string Person, long Remaining, string GoodId)> Services(CareerData data)`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`](ConsumerPickerScreen.cs.md#symbol-0f5d28176960)；[`NationalSpire.WeddingAppointments.Error(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-9b3600926b30)；[`NationalSpire.WeddingAppointments.ForParticipants(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>)`](WeddingAppointments.cs.md#symbol-e0e8b388fcb4)

**调用：** [`NationalSpire.RelationshipGifts.Special(string)`](RelationshipGifts.cs.md#symbol-d05881b51110)；[`NationalSpire.WeddingAppointments.Conversations(NationalSpire.CareerData)`](WeddingAppointments.cs.md#symbol-35e35b4dd8e0)；[`NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-f30a9608f6f8)；[`NationalSpire.WeddingAppointments.ServiceIds(NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-920147fd431a)；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.LongCount<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateOffer.ActorId`；`NationalSpire.PrivateOffer.DateSourceGroup`；`NationalSpire.PrivateOffer.GoodId`；`NationalSpire.PrivateOffer.GroupId`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Quantity`；`NationalSpire.PrivateOffer.State`；`NationalSpire.RelationshipGifts.Special(string)`；`NationalSpire.WeddingAppointments.Conversations(NationalSpire.CareerData)`；`NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`；`NationalSpire.WeddingAppointments.ServiceIds(NationalSpire.PrivateOffer)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RelationshipGifts.Special(string)`；输入表达式：`RelationshipGifts.Special(o.GoodId)`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Kind == "gift" && RelationshipGifts.Special(o.GoodId)`
- `NationalSpire.WeddingAppointments.Conversations(NationalSpire.CareerData)`；输入表达式：`Conversations(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Conversations(data).SelectMany`
- `NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`；输入表达式：`IsWedding(o)`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Kind == "activity" && o.DateSourceGroup.Length == 0 && IsWedding(o)`
- `NationalSpire.WeddingAppointments.ServiceIds(NationalSpire.PrivateOffer)`；输入表达式：`ServiceIds(o)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ServiceIds(o).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`ServiceIds(o).Distinct()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: o => ServiceIds(o).Distinct()`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`offers.Where(o => o.Kind == "activity" && o.DateSourceGroup.Length == 0 && IsWedding(o) && o.State is "已赴约" or "已结束") .SelectMany(o => ServiceIds(o).Distinct()).GroupBy(id => id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: offers.Where(o => o.Kind == "activity" && o.DateSourceGroup.Length == 0 && IsWedding(o) && o.State is "已赴约" or "已结束") .SelectMany(o => ServiceIds(o).Distinct()).GroupBy(id => id).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.LongCount<TSource>()`；输入表达式：`g.LongCount()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.LongCount()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`offers.Where(o => o.Kind == "gift" && RelationshipGifts.Special(o.GoodId) && o.State == "已接受") .Select(o => (Id: o.GroupId + "/" + o.Id, Person: o.ActorId, Remaining: o.Quantity - used.GetValueOrDefault(o.GroupId + "/" + o.Id), GoodId: o.GoodId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: offers.Where(o => o.Kind == "gift" && RelationshipGifts.Special(o.GoodId) && o.State == "已接受") .Select(o => (Id: o.GroupId + "/" + o.Id, Person: o.ActorId, Remaining: o.Quantity - used.GetValueOrDefault(o.GroupId + "/" + o.Id), GoodId: o.GoodId)) .Where`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`Conversations(data).SelectMany(c => c.Offers)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Conversations(data).SelectMany(c => c.Offers).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`offers.Where(o => o.Kind == "activity" && o.DateSourceGroup.Length == 0 && IsWedding(o) && o.State is "已赴约" or "已结束") .SelectMany(o => ServiceIds(o).Distinct())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: offers.Where(o => o.Kind == "activity" && o.DateSourceGroup.Length == 0 && IsWedding(o) && o.State is "已赴约" or "已结束") .SelectMany(o => ServiceIds(o).Distinct()).GroupBy`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Conversations(data).SelectMany(c => c.Offers).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Conversations(data).SelectMany(c => c.Offers).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`offers.Where(o => o.Kind == "activity" && o.DateSourceGroup.Length == 0 && IsWedding(o) && o.State is "已赴约" or "已结束") .SelectMany(o => ServiceIds(o).Distinct()).GroupBy(id => id).ToDictionary(g => g.Key, g => g.LongCount())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = offers.Where(o => o.Kind == "activity" && o.DateSourceGroup.Length == 0 && IsWedding(o) && o.State is "已赴约" or "已结束") .SelectMany(o => ServiceIds(o).Distinct()).GroupBy(id => id).ToDictionary(g => g.Key, g => g.LongCount())`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`offers.Where(o => o.Kind == "activity" && o.DateSourceGroup.Length == 0 && IsWedding(o) && o.State is "已赴约" or "已结束")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: offers.Where(o => o.Kind == "activity" && o.DateSourceGroup.Length == 0 && IsWedding(o) && o.State is "已赴约" or "已结束") .SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`offers.Where(o => o.Kind == "gift" && RelationshipGifts.Special(o.GoodId) && o.State == "已接受")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: offers.Where(o => o.Kind == "gift" && RelationshipGifts.Special(o.GoodId) && o.State == "已接受") .Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`offers.Where(o => o.Kind == "gift" && RelationshipGifts.Special(o.GoodId) && o.State == "已接受") .Select(o => (Id: o.GroupId + "/" + o.Id, Person: o.ActorId, Remaining: o.Quantity - used.GetValueOrDefault(o.GroupId + "/" + o.Id), GoodId: o.GoodId)) .Where(s => s.Remaining > 0)`；返回值紧邻使用处：`ReturnStatementSyntax: return offers.Where(o => o.Kind == "gift" && RelationshipGifts.Special(o.GoodId) && o.State == "已接受") .Select(o => (Id: o.GroupId + "/" + o.Id, Person: o.ActorId, Remaining: o.Quantity - used.GetValueOrDefault(o.GroupId + "/" + o.Id), GoodId: o.GoodId)) .Where(s => s.Remaining > 0);`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`used.GetValueOrDefault(o.GroupId + "/" + o.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Quantity - used.GetValueOrDefault(o.GroupId + "/" + o.Id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e0e8b388fcb4"></a>

## `NationalSpire.WeddingAppointments.ForParticipants(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>) — public static IEnumerable<(string Id, string Person, long Remaining, string GoodId)> ForParticipants(CareerData data, IEnumerable<string> participants)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Changed(bool)`](ConsumerPickerScreen.cs.md#symbol-4cac190b7ec0)；[`NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`](ConsumerPickerScreen.cs.md#symbol-0f5d28176960)；[`WeddingChoices()`](ConsumerPickerScreen.cs.md#symbol-667c9af3e555)；[`WeddingCost()`](ConsumerPickerScreen.cs.md#symbol-58bbb914e92d)

**调用：** [`NationalSpire.WeddingAppointments.Services(NationalSpire.CareerData)`](WeddingAppointments.cs.md#symbol-2dfb2ee379ae)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.WeddingAppointments.Services(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.WeddingAppointments.Services(NationalSpire.CareerData)`；输入表达式：`Services(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Services(data).Where`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`people.Contains(service.Person)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: service => people.Contains(service.Person)`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`；输入表达式：`participants.ToHashSet(StringComparer.Ordinal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = participants.ToHashSet(StringComparer.Ordinal)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Services(data).Where(service => people.Contains(service.Person))`；返回值紧邻使用处：`ReturnStatementSyntax: return Services(data).Where(service => people.Contains(service.Person));`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9b3600926b30"></a>

## `NationalSpire.WeddingAppointments.Error(NationalSpire.CareerData, NationalSpire.PrivateOffer) — public static string? Error(CareerData data, PrivateOffer offer)`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool)`](ChatAttachments.cs.md#symbol-4e7c361b1f77)；[`NationalSpire.SocialAppointments.Attend(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool, bool)`](SocialAppointments.cs.md#symbol-59e09ef2b579)；[`NationalSpire.SocialAppointments.Confirm(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer)`](SocialAppointments.cs.md#symbol-2f0b4ecea199)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-f30a9608f6f8)；[`NationalSpire.WeddingAppointments.ServiceIds(NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-920147fd431a)；[`NationalSpire.WeddingAppointments.Services(NationalSpire.CareerData)`](WeddingAppointments.cs.md#symbol-2dfb2ee379ae)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.HashSet()`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.GoodId`；`NationalSpire.PrivateOffer.Participants`；`NationalSpire.PrivateOffer.ServiceId`；`NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`；`NationalSpire.WeddingAppointments.ServiceIds(NationalSpire.PrivateOffer)`；`NationalSpire.WeddingAppointments.Services(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, service.Person)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Person(data, service.Person) == null`
- `NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`；输入表达式：`IsWedding(offer)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsWedding(offer)`
- `NationalSpire.WeddingAppointments.ServiceIds(NationalSpire.PrivateOffer)`；输入表达式：`ServiceIds(offer)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ServiceIds(offer)`
- `NationalSpire.WeddingAppointments.Services(NationalSpire.CareerData)`；输入表达式：`Services(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Services(data).ToDictionary`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`services.TryGetValue(id, out var service)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !services.TryGetValue(id, out var service)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`partners.Add(service.Person)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !partners.Add(service.Person)`
- `System.Collections.Generic.HashSet<T>.HashSet()`；输入表达式：`new HashSet<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HashSet<string>()`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`ids.Distinct().Count()`；返回值紧邻使用处：`BinaryExpressionSyntax: ids.Distinct().Count() != ids.Length`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`ids.Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ids.Distinct().Count`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`Services(data).ToDictionary(s => s.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Services(data).ToDictionary(s => s.Id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`offer.Participants.Contains(service.Person)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !offer.Participants.Contains(service.Person)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4cb46102c2e0"></a>

## `NationalSpire.WeddingAppointments.Complete(NationalSpire.CareerData, NationalSpire.PrivateOffer) — public static void Complete(CareerData data, PrivateOffer offer)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.Leave(NationalSpire.CareerData, NationalSpire.PrivateConversation, string, bool)`](DateSceneData.cs.md#symbol-81bdbfbfe1d8)；[`NationalSpire.SocialAppointments.Attend(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool, bool)`](SocialAppointments.cs.md#symbol-59e09ef2b579)

**调用：** [`NationalSpire.RelationshipPresentation.CompleteWedding(NationalSpire.CareerData, string)`](RelationshipPresentation.cs.md#symbol-49a406ddaa23)；[`NationalSpire.SocialAppointments.PublishAttendance(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](SocialAppointments.cs.md#symbol-47965830082f)；[`NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-f30a9608f6f8)；[`NationalSpire.WeddingAppointments.Partners(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-854bd494f2d0)；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateOffer.Participants`；`NationalSpire.PrivateOffer.PublicAttendance`；`NationalSpire.RelationshipPresentation.CompleteWedding(NationalSpire.CareerData, string)`；`NationalSpire.SocialAppointments.PublishAttendance(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`；`NationalSpire.WeddingAppointments.Partners(NationalSpire.CareerData, NationalSpire.PrivateOffer)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RelationshipPresentation.CompleteWedding(NationalSpire.CareerData, string)`；输入表达式：`RelationshipPresentation.CompleteWedding(data, person)`；返回值紧邻使用处：`ExpressionStatementSyntax: RelationshipPresentation.CompleteWedding(data, person);`
- `NationalSpire.SocialAppointments.PublishAttendance(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`SocialAppointments.PublishAttendance(data, offer)`；返回值紧邻使用处：`ExpressionStatementSyntax: SocialAppointments.PublishAttendance(data, offer);`
- `NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`；输入表达式：`IsWedding(offer)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsWedding(offer)`
- `NationalSpire.WeddingAppointments.Partners(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`Partners(data, offer)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Partners(data, offer).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Partners(data, offer).Where(offer.Participants.Contains)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string person in Partners(data, offer).Where(offer.Participants.Contains)) RelationshipPresentation.CompleteWedding(data, person);`

**赋值（含属性/字段和局部值）：**
