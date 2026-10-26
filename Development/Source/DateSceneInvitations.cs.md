# DateSceneInvitations.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`0FEB544A6D1DBAD401ECD3B61983664F4F25FB1280EC2D6DF69E3670087F844B`。来源：[源码](../../DateSceneInvitations.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DateSceneInvitation`、`NationalSpire.DateSceneInvitations`。

字段、事件及初始值（源码原样）：

```csharp
public const string Protocol = "这是加入已有约会的邀请。依据你的意愿回复，并在正文后输出 [DateJoin: 接受] 或 [DateJoin: 拒绝]；接受会加入该日程。";
```

<a id="symbol-f91c829d4b3b"></a>

## `NationalSpire.DateSceneInvitation.Host — public string Host`

来源：源码第 5 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-02af25da3d17"></a>

## `NationalSpire.DateSceneInvitation.OfferId — public string OfferId`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4209c72c0fb1"></a>

## `NationalSpire.DateSceneInvitation.State — public string State`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-fbd645f524af"></a>

## `NationalSpire.DateSceneInvitations.Invite(NationalSpire.CareerData, string, string, string) — public static string? Invite(CareerData data, string host, string offerId, string target)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessageCommands.ApplyCore(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-1472969f513b)

**调用：** [`NationalSpire.AiService.PrivateBusy(NationalSpire.CareerData, string)`](AiPrivateMessages.cs.md#symbol-57be9d2323cb)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.DateGroupBridge.SourceActive(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](DateGroupBridge.cs.md#symbol-f6c6214fb9e2)；`NationalSpire.DateSceneInvitation.DateSceneInvitation()`；[`NationalSpire.DateSceneParty.Eligible(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneParty.cs.md#symbol-0b65821baf62)；[`NationalSpire.DateSceneParty.People(NationalSpire.CareerData, NationalSpire.PrivateOffer, string)`](DateSceneParty.cs.md#symbol-f9cb6b2133b0)；[`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；[`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`](PrivateAppointments.cs.md#symbol-1c549626b284)；[`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；[`NationalSpire.PrivateMessages.Enqueue(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer?, System.Collections.Generic.List<NationalSpire.PrivateOffer>?, string, bool)`](PrivateMessages.cs.md#symbol-0e61d4a7bbb5)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Contains(T)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.PrivateBusy(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.DateGroupBridge.SourceActive(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.DateSceneInvitation.Host`；`NationalSpire.DateSceneInvitation.OfferId`；`NationalSpire.DateSceneInvitation.State`；`NationalSpire.DateSceneParty.Eligible(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；`NationalSpire.DateSceneParty.People(NationalSpire.CareerData, NationalSpire.PrivateOffer, string)`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；`NationalSpire.PrivateConversation.DateSceneStates`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.Enqueue(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer?, System.Collections.Generic.List<NationalSpire.PrivateOffer>?, string, bool)`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.Title`；`NationalSpire.PrivateTurn.DateInvitation`；`NationalSpire.PrivateTurn.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.PrivateBusy(NationalSpire.CareerData, string)`；输入表达式：`AiService.PrivateBusy(data, target)`；返回值紧邻使用处：`BinaryExpressionSyntax: AiService.PrivateBusy(data, target) || receiver.Turns.Any(t => t.Status is "queued" or "sending")`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => CareerEngine.DisplayName(data, id)`
- `NationalSpire.DateGroupBridge.SourceActive(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`DateGroupBridge.SourceActive(data, offer)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !DateGroupBridge.SourceActive(data, offer)`
- `NationalSpire.DateSceneInvitation.DateSceneInvitation()`；输入表达式：`new() { Host = host, OfferId = offerId }`；返回值紧邻使用处：`AssignmentExpressionSyntax: turn.DateInvitation = new() { Host = host, OfferId = offerId }`
- `NationalSpire.DateSceneParty.Eligible(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；输入表达式：`DateSceneParty.Eligible(data, offer, conversation)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !DateSceneParty.Eligible(data, offer, conversation)`
- `NationalSpire.DateSceneParty.People(NationalSpire.CareerData, NationalSpire.PrivateOffer, string)`；输入表达式：`DateSceneParty.People(data, offer, host)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneParty.People(data, offer, host)`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(data, offer)`；返回值紧邻使用处：`ArgumentSyntax: PrivateAppointments.Date(data, offer)`
- `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；输入表达式：`PrivateAppointments.DateText(data, PrivateAppointments.Date(data, offer))`；返回值紧邻使用处：`InterpolationSyntax: {PrivateAppointments.DateText(data, PrivateAppointments.Date(data, offer))}`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(data, target)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateMessages.CanChat(data, target)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, host)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(data, host)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, target)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(data, target)`
- `NationalSpire.PrivateMessages.Enqueue(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer?, System.Collections.Generic.List<NationalSpire.PrivateOffer>?, string, bool)`；输入表达式：`PrivateMessages.Enqueue(data, target, $"邀请你一起参加{PrivateAppointments.DateText(data, PrivateAppointments.Date(data, offer))}的《{offer.Title}》。已有参与者：{string.Join("、", people.Select(id => CareerEngine.DisplayName(data, id)))}。活动内容：{offer.Detail}。你愿意加入吗？")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Enqueue(data, target, $"邀请你一起参加{PrivateAppointments.DateText(data, PrivateAppointments.Date(data, offer))}的《{offer.Title}》。已有参与者：{string.Join("、", people.Select(id => CareerEngine.DisplayName(data, id)))}。活动内容：{offer.Detail}。你愿意加入吗？")`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`receiver.Turns.Any(t => t.DateInvitation is { State: "pending" } i && i.Host == host && i.OfferId == offerId)`；返回值紧邻使用处：`IfStatementSyntax: if (receiver.Turns.Any(t => t.DateInvitation is { State: "pending" } i && i.Host == host && i.OfferId == offerId)) return "该人物正在考虑这项邀请。";`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`receiver.Turns.Any(t => t.Status is "queued" or "sending")`；返回值紧邻使用处：`BinaryExpressionSyntax: AiService.PrivateBusy(data, target) || receiver.Turns.Any(t => t.Status is "queued" or "sending")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Offers.FirstOrDefault(o => o.Id == offerId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = conversation.Offers.FirstOrDefault(o => o.Id == offerId)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`people.Select(id => CareerEngine.DisplayName(data, id))`；返回值紧邻使用处：`ArgumentSyntax: people.Select(id => CareerEngine.DisplayName(data, id))`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`conversation.DateSceneStates.GetValueOrDefault(offerId)`；返回值紧邻使用处：`BinaryExpressionSyntax: conversation.DateSceneStates.GetValueOrDefault(offerId) == "ended"`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`people.Contains(target)`；返回值紧邻使用处：`IfStatementSyntax: if (people.Contains(target)) return "约会已有该成员。";`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", people.Select(id => CareerEngine.DisplayName(data, id)))`；返回值紧邻使用处：`InterpolationSyntax: {string.Join("、", people.Select(id => CareerEngine.DisplayName(data, id)))}`

**赋值（含属性/字段和局部值）：**

- `Host` = `host`
- `OfferId` = `offerId`
- `turn.DateInvitation` = `new() { Host = host, OfferId = offerId }`

<a id="symbol-b18700ea221f"></a>

## `NationalSpire.DateSceneInvitations.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>) — public static void Respond(CareerData data, PrivateConversation receiver, PrivateTurn turn, IReadOnlyList<Dictionary<string, string>> directives)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneEffects.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int)`](DateSceneEffects.cs.md#symbol-02f9d7b85cad)

**调用：** [`NationalSpire.DateGroupBridge.SourceActive(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](DateGroupBridge.cs.md#symbol-f6c6214fb9e2)；[`NationalSpire.DateGroupBridge.Sync(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](DateGroupBridge.cs.md#symbol-26e379588751)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateGroupBridge.SourceActive(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.DateGroupBridge.Sync(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.DateSceneInvitation.Host`；`NationalSpire.DateSceneInvitation.OfferId`；`NationalSpire.DateSceneInvitation.State`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.PrivateConversation.DateSceneStates`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Participants`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateTurn.DateInvitation`；`NationalSpire.PrivateTurn.Error`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGroupBridge.SourceActive(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`DateGroupBridge.SourceActive(data, offer)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !DateGroupBridge.SourceActive(data, offer)`
- `NationalSpire.DateGroupBridge.Sync(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`DateGroupBridge.Sync(data, offer)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateGroupBridge.Sync(data, offer);`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(data)`；返回值紧邻使用处：`InitializerExpressionSyntax: { GroupChats.Human(data), host.PersonId }`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, invitation.Host)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(data, invitation.Host)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`f.ContainsKey("DateJoin")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: f => f.ContainsKey("DateJoin")`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`new[] { GroupChats.Human(data), host.PersonId }.Concat(offer.Participants).Append(receiver.PersonId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { GroupChats.Human(data), host.PersonId }.Concat(offer.Participants).Append(receiver.PersonId).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`new[] { GroupChats.Human(data), host.PersonId }.Concat(offer.Participants)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { GroupChats.Human(data), host.PersonId }.Concat(offer.Participants).Append`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`new[] { GroupChats.Human(data), host.PersonId }.Concat(offer.Participants).Append(receiver.PersonId).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { GroupChats.Human(data), host.PersonId }.Concat(offer.Participants).Append(receiver.PersonId).Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`host.Offers.FirstOrDefault(o => o.Id == invitation.OfferId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = host.Offers.FirstOrDefault(o => o.Id == invitation.OfferId)`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`directives.LastOrDefault(f => f.ContainsKey("DateJoin"))`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: directives.LastOrDefault(f => f.ContainsKey("DateJoin"))?.GetValueOrDefault("DateJoin")`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`new[] { GroupChats.Human(data), host.PersonId }.Concat(offer.Participants).Append(receiver.PersonId).Distinct().ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: offer.Participants = new[] { GroupChats.Human(data), host.PersonId }.Concat(offer.Participants).Append(receiver.PersonId).Distinct().ToList()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.GetValueOrDefault("DateJoin")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: directives.LastOrDefault(f => f.ContainsKey("DateJoin"))?.GetValueOrDefault("DateJoin")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`host.DateSceneStates.GetValueOrDefault(offer.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: host.DateSceneStates.GetValueOrDefault(offer.Id) == "ended"`

**赋值（含属性/字段和局部值）：**

- `invitation.State` = `"accepted"`
- `invitation.State` = `"declined"`
- `invitation.State` = `"expired"`
- `invitation.State` = `"unresolved"`
- `offer.Participants` = `new[] { GroupChats.Human(data), host.PersonId }.Concat(offer.Participants).Append(receiver.PersonId).Distinct().ToList()`
- `turn.Error` += `"\n加入约会的决定尚未确认，可再次邀请。"`
- `turn.Error` += `"\n原约会已经结束，本次加入失效。"`
