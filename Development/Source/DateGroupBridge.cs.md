# DateGroupBridge.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`75B6C152F26FB82597132B071E9E5708E7E3F1E3C827703FD498FAC06233A883`。来源：[源码](../../DateGroupBridge.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DateGroupBridge`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-bb04f839731a"></a>

## `NationalSpire.DateGroupBridge.IsOpen(NationalSpire.PrivateOffer) — private static bool IsOpen(PrivateOffer offer)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGroupBridge.Merge(NationalSpire.CareerData, NationalSpire.CareerData)`](DateGroupBridge.cs.md#symbol-53762b6ace7e)；[`NationalSpire.DateGroupBridge.SourceActive(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](DateGroupBridge.cs.md#symbol-f6c6214fb9e2)；[`NationalSpire.DateGroupBridge.Sync(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](DateGroupBridge.cs.md#symbol-26e379588751)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateOffer.State`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-370947347770"></a>

## `NationalSpire.DateGroupBridge.Source(NationalSpire.CareerData, NationalSpire.PrivateOffer) — private static PrivateOffer? Source(CareerData data, PrivateOffer proxy)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGroupBridge.SourceActive(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](DateGroupBridge.cs.md#symbol-f6c6214fb9e2)；[`NationalSpire.DateGroupBridge.Sync(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](DateGroupBridge.cs.md#symbol-26e379588751)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Interactions`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateOffer.DateSourceGroup`；`NationalSpire.PrivateOffer.DateSourceOffer`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Interactions.Values.SelectMany(c => c.Offers) .FirstOrDefault(o => o.Id == proxy.DateSourceOffer && o.Kind == "activity")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: data.Chats.Groups .FirstOrDefault(g => g.Id == proxy.DateSourceGroup)?.Interactions.Values.SelectMany(c => c.Offers) .FirstOrDefault(o => o.Id == proxy.DateSourceOffer && o.Kind == "activity")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Chats.Groups .FirstOrDefault(g => g.Id == proxy.DateSourceGroup)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: data.Chats.Groups .FirstOrDefault(g => g.Id == proxy.DateSourceGroup)?.Interactions.Values.SelectMany(c => c.Offers) .FirstOrDefault(o => o.Id == proxy.DateSourceOffer && o.Kind == "activity")`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`.Interactions.Values.SelectMany(c => c.Offers)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: .Interactions.Values.SelectMany(c => c.Offers) .FirstOrDefault`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f6c6214fb9e2"></a>

## `NationalSpire.DateGroupBridge.SourceActive(NationalSpire.CareerData, NationalSpire.PrivateOffer) — public static bool SourceActive(CareerData data, PrivateOffer proxy)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`CheckSceneSource()`](AiPrivateMessages.cs.md#symbol-2a43c08c877b)；[`NationalSpire.DateSceneInvitations.Invite(NationalSpire.CareerData, string, string, string)`](DateSceneInvitations.cs.md#symbol-fbd645f524af)；[`NationalSpire.DateSceneInvitations.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>)`](DateSceneInvitations.cs.md#symbol-b18700ea221f)；[`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneData.cs.md#symbol-0d3e014bcb63)

**调用：** [`NationalSpire.DateGroupBridge.IsOpen(NationalSpire.PrivateOffer)`](DateGroupBridge.cs.md#symbol-bb04f839731a)；[`NationalSpire.DateGroupBridge.Source(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](DateGroupBridge.cs.md#symbol-370947347770)

**字段、属性、事件及方法组引用：** `NationalSpire.DateGroupBridge.IsOpen(NationalSpire.PrivateOffer)`；`NationalSpire.DateGroupBridge.Source(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateOffer.DateSourceGroup`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGroupBridge.IsOpen(NationalSpire.PrivateOffer)`；输入表达式：`IsOpen(source)`；返回值紧邻使用处：`BinaryExpressionSyntax: Source(data, proxy) is { } source && IsOpen(source)`
- `NationalSpire.DateGroupBridge.Source(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`Source(data, proxy)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Source(data, proxy) is { } source`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6bffe5cc487f"></a>

## `NationalSpire.DateGroupBridge.Find(NationalSpire.CareerData, string, string) — public static (PrivateConversation Conversation, PrivateOffer Offer)? Find(CareerData data, string group, string source)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`](GroupChatScreen.cs.md#symbol-3afa41099b93)；[`NationalSpire.DateGroupBridge.Begin(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.PrivateOffer)`](DateGroupBridge.cs.md#symbol-3f1369ff69ca)

**调用：** [`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateOffer.DateSourceGroup`；`NationalSpire.PrivateOffer.DateSourceOffer`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Offers.FirstOrDefault(o => o.DateSourceGroup == group && o.DateSourceOffer == source)`；返回值紧邻使用处：`IsPatternExpressionSyntax: c.Offers.FirstOrDefault(o => o.DateSourceGroup == group && o.DateSourceOffer == source) is { } offer`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3f1369ff69ca"></a>

## `NationalSpire.DateGroupBridge.Begin(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.PrivateOffer) — public static string? Begin(CareerData data, GroupChat group, PrivateOffer source)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupChats.CommandCore(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`](GroupChats.cs.md#symbol-136432a1ec5d)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](Coop/CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.DateGroupBridge.Find(NationalSpire.CareerData, string, string)`](DateGroupBridge.cs.md#symbol-6bffe5cc487f)；[`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneData.cs.md#symbol-0d3e014bcb63)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-24bc82bdbbd4)；[`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；[`NationalSpire.SocialAppointments.Attend(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool, bool)`](SocialAppointments.cs.md#symbol-59e09ef2b579)；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.DateGroupBridge.Find(NationalSpire.CareerData, string, string)`；`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.ActorId`；`NationalSpire.PrivateOffer.DateSourceGroup`；`NationalSpire.PrivateOffer.DateSourceOffer`；`NationalSpire.PrivateOffer.GroupId`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Participants`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.TurnId`；`NationalSpire.SocialAppointments.Attend(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, p)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Person(data, p) != null`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`Coop.CoopJson.Copy(source)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Coop.CoopJson.Copy(source)`
- `NationalSpire.DateGroupBridge.Find(NationalSpire.CareerData, string, string)`；输入表达式：`Find(data, group.Id, source.Id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Find(data, group.Id, source.Id) is { } existing`
- `NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；输入表达式：`DateScenes.Available(data, existing.Offer, existing.Conversation)`；返回值紧邻使用处：`ConditionalExpressionSyntax: DateScenes.Available(data, existing.Offer, existing.Conversation) ? null : "这场约会已经结束。"`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(data)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Human(data)`
- `NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.IsHuman(data, p)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GroupChats.IsHuman(data, p)`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(data, source)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateAppointments.Date(data, source) != data.Day`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, host)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(data, host).Offers`
- `NationalSpire.SocialAppointments.Attend(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool, bool)`；输入表达式：`SocialAppointments.Attend(data, source, scene: true)`；返回值紧邻使用处：`IsPatternExpressionSyntax: SocialAppointments.Attend(data, source, scene: true) is { } error`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`source.Participants.Where(p => !GroupChats.IsHuman(data, p) && CareerEngine.Person(data, p) != null).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: source.Participants.Where(p => !GroupChats.IsHuman(data, p) && CareerEngine.Person(data, p) != null).Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`source.Participants.Where(p => !GroupChats.IsHuman(data, p) && CareerEngine.Person(data, p) != null).Distinct().ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = source.Participants.Where(p => !GroupChats.IsHuman(data, p) && CareerEngine.Person(data, p) != null).Distinct().ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`source.Participants.Where(p => !GroupChats.IsHuman(data, p) && CareerEngine.Person(data, p) != null)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: source.Participants.Where(p => !GroupChats.IsHuman(data, p) && CareerEngine.Person(data, p) != null).Distinct`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`PrivateMessages.Conversation(data, host).Offers.Add(proxy)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateMessages.Conversation(data, host).Offers.Add(proxy);`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`people.Contains(source.ActorId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: people.Contains(source.ActorId) ? source.ActorId : people[0]`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`source.Participants.Contains(GroupChats.Human(data))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !source.Participants.Contains(GroupChats.Human(data))`

**赋值（含属性/字段和局部值）：**

- `proxy.ActorId` = `host`
- `proxy.DateSourceGroup` = `group.Id`
- `proxy.DateSourceOffer` = `source.Id`
- `proxy.GroupId` = `""`
- `proxy.Id` = `"group-date-" + group.Id + "-" + source.Id`
- `proxy.TurnId` = `""`

<a id="symbol-26e379588751"></a>

## `NationalSpire.DateGroupBridge.Sync(NationalSpire.CareerData, NationalSpire.PrivateOffer) — public static void Sync(CareerData data, PrivateOffer proxy)`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneInvitations.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>)`](DateSceneInvitations.cs.md#symbol-b18700ea221f)；[`NationalSpire.DateScenes.Leave(NationalSpire.CareerData, NationalSpire.PrivateConversation, string, bool)`](DateSceneData.cs.md#symbol-81bdbfbfe1d8)

**调用：** [`NationalSpire.DateGroupBridge.IsOpen(NationalSpire.PrivateOffer)`](DateGroupBridge.cs.md#symbol-bb04f839731a)；[`NationalSpire.DateGroupBridge.Source(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](DateGroupBridge.cs.md#symbol-370947347770)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.DateGroupBridge.IsOpen(NationalSpire.PrivateOffer)`；`NationalSpire.DateGroupBridge.Source(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Revision`；`NationalSpire.PrivateOffer.DateSourceGroup`；`NationalSpire.PrivateOffer.Participants`；`NationalSpire.PrivateOffer.State`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGroupBridge.IsOpen(NationalSpire.PrivateOffer)`；输入表达式：`IsOpen(source)`；返回值紧邻使用处：`BinaryExpressionSyntax: source != null && IsOpen(source)`
- `NationalSpire.DateGroupBridge.Source(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`Source(data, proxy)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Source(data, proxy)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Chats.Groups.FirstOrDefault(g => g.Id == proxy.DateSourceGroup)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Chats.Groups.FirstOrDefault(g => g.Id == proxy.DateSourceGroup)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`proxy.Participants.ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: source.Participants = proxy.Participants.ToList()`

**赋值（含属性/字段和局部值）：**

- `source.Participants` = `proxy.Participants.ToList()`
- `source.State` = `proxy.State`

<a id="symbol-53762b6ace7e"></a>

## `NationalSpire.DateGroupBridge.Merge(NationalSpire.CareerData, NationalSpire.CareerData) — public static void Merge(CareerData world, CareerData view)`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.Capture(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.CareerData)`](Coop/CoopRules.cs.md#symbol-99be42ec0491)；[`Save(NationalSpire.CareerData)`](Coop/CoopPrivateMessages.cs.md#symbol-08dfeba4e37a)

**调用：** [`NationalSpire.DateGroupBridge.IsOpen(NationalSpire.PrivateOffer)`](DateGroupBridge.cs.md#symbol-bb04f839731a)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.SequenceEqual<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.DateGroupBridge.IsOpen(NationalSpire.PrivateOffer)`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Interactions`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupChat.Revision`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateOffer.DateSourceGroup`；`NationalSpire.PrivateOffer.DateSourceOffer`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Participants`；`NationalSpire.PrivateOffer.State`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGroupBridge.IsOpen(NationalSpire.PrivateOffer)`；输入表达式：`IsOpen(to)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsOpen(to)`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(view)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Human(view)`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(view)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(view).Conversations`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`source.Interactions.Values.SelectMany(c => c.Offers).FirstOrDefault(o => o.Id == proxy.DateSourceOffer && o.Kind == "activity")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = source.Interactions.Values.SelectMany(c => c.Offers).FirstOrDefault(o => o.Id == proxy.DateSourceOffer && o.Kind == "activity")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`target.Interactions.Values.SelectMany(c => c.Offers).FirstOrDefault(o => o.Id == proxy.DateSourceOffer && o.Kind == "activity")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = target.Interactions.Values.SelectMany(c => c.Offers).FirstOrDefault(o => o.Id == proxy.DateSourceOffer && o.Kind == "activity")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`view.Chats.Groups.FirstOrDefault(g => g.Id == references.Key)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = view.Chats.Groups.FirstOrDefault(g => g.Id == references.Key)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`world.Chats.Groups.FirstOrDefault(g => g.Id == references.Key)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = world.Chats.Groups.FirstOrDefault(g => g.Id == references.Key)`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`PrivateMessages.Mailbox(view).Conversations.Values.SelectMany(c => c.Offers) .Where(o => o.DateSourceGroup.Length > 0).GroupBy(o => o.DateSourceGroup)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Mailbox(view).Conversations.Values.SelectMany(c => c.Offers) .Where(o => o.DateSourceGroup.Length > 0).GroupBy(o => o.DateSourceGroup)`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`PrivateMessages.Mailbox(view).Conversations.Values.SelectMany(c => c.Offers)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(view).Conversations.Values.SelectMany(c => c.Offers) .Where`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`source.Interactions.Values.SelectMany(c => c.Offers)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: source.Interactions.Values.SelectMany(c => c.Offers).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`target.Interactions.Values.SelectMany(c => c.Offers)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: target.Interactions.Values.SelectMany(c => c.Offers).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.SequenceEqual<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`from.Participants.SequenceEqual(proxy.Participants)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !from.Participants.SequenceEqual(proxy.Participants)`
- `System.Collections.Generic.IEnumerable<TSource>.SequenceEqual<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`to.Participants.SequenceEqual(from.Participants)`；返回值紧邻使用处：`BinaryExpressionSyntax: to.State == from.State && to.Participants.SequenceEqual(from.Participants)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`from.Participants.ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: to.Participants = from.Participants.ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Mailbox(view).Conversations.Values.SelectMany(c => c.Offers) .Where(o => o.DateSourceGroup.Length > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(view).Conversations.Values.SelectMany(c => c.Offers) .Where(o => o.DateSourceGroup.Length > 0).GroupBy`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`target.Members.Contains(GroupChats.Human(view))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !target.Members.Contains(GroupChats.Human(view))`

**赋值（含属性/字段和局部值）：**

- `changed` = `true`
- `to.Participants` = `from.Participants.ToList()`
- `to.State` = `from.State`
