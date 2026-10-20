# OathAttachments.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`9BC97DB6E62C052012D3F2F0447DE8E7CAFEC19126669AE5EC8C35D14FE18EB4`。来源：[源码](../../OathAttachments.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.OathAttachments`。

字段、事件及初始值（源码原样）：

```csharp
public const string Kind = "oath-release";
public const string Protocol = """
玩家可以通过解除誓约附件提出解除当前誓约。人物同意解除或决定拒绝时，必须在本轮回复中输出对应的Oath标记，程序据此登记处理结果。
每条标记完整填写Oath、Id。Oath填接受或拒绝；Id填解除誓约附件的编号。
接受解除：
[Oath: 接受, Id: 14]
拒绝解除：
[Oath: 拒绝, Id: 14]
接受后解除当前誓约；拒绝后保持当前誓约。已有聊天记录和婚礼经历继续保留。只有标记才登记交互，口头答应无法触发实际效果。
""";
```

<a id="symbol-d9e75c315797"></a>

## `NationalSpire.OathAttachments.GroupProtocol — public static string GroupProtocol`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `string.Replace(string, string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.OathAttachments.Protocol`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Replace(string, string?)`；输入表达式：`Protocol.Replace("每条标记完整填写Oath、Id。", "每条标记完整填写Oath、Id、Actor。Actor填收到附件的人物编号。")          .Replace("Id: 14]", "Id: 14, Actor: p2]")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Protocol.Replace("每条标记完整填写Oath、Id。", "每条标记完整填写Oath、Id、Actor。Actor填收到附件的人物编号。")          .Replace("Id: 14]", "Id: 14, Actor: p2]")`
- `string.Replace(string, string?)`；输入表达式：`Protocol.Replace("每条标记完整填写Oath、Id。", "每条标记完整填写Oath、Id、Actor。Actor填收到附件的人物编号。")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Protocol.Replace("每条标记完整填写Oath、Id。", "每条标记完整填写Oath、Id、Actor。Actor填收到附件的人物编号。")          .Replace`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9abb4f75eb8f"></a>

## `NationalSpire.OathAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer) — public static string? Prepare(CareerData data, string person, PrivateOffer offer)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateOathAttachment()`](ChatAttachmentScreen.cs.md#symbol-cefd5039c4e6)；[`NationalSpire.ChatAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](ChatAttachments.cs.md#symbol-114368537271)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-8a6bb6e78fa5)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.ActorId`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Title`；`NationalSpire.PrivateRelation.OathConfirmed`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Name(data) + "向" + CareerEngine.DisplayName(data, person)`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Name(data) + "向"`
- `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Relation(data, person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Relation(data, person).OathConfirmed`

**赋值（含属性/字段和局部值）：**

- `offer.ActorId` = `person`
- `offer.Detail` = `CareerEngine.Name(data) + "向" + CareerEngine.DisplayName(data, person) + "提出解除当前誓约，等待对方接受或拒绝。"`
- `offer.Title` = `"解除誓约"`

<a id="symbol-80bb2ac38dee"></a>

## `NationalSpire.OathAttachments.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>) — public static void Respond(CareerData data, PrivateConversation conversation, PrivateTurn turn, Dictionary<string, string> fields)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`](PrivateMessages.cs.md#symbol-7bf623828ccc)

**调用：** [`NationalSpire.ChatAttachments.Find(NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, string, System.Collections.Generic.Dictionary<string, string>)`](ChatAttachments.cs.md#symbol-10ee34a4e855)；[`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-8a6bb6e78fa5)；[`NationalSpire.PrivateRelation.RefreshAppearance()`](PrivateMessageData.cs.md#symbol-fbf6e9bf540b)；`NationalSpire.PrivateOffer.PrivateOffer()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatAttachments.Find(NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, string, System.Collections.Generic.Dictionary<string, string>)`；`NationalSpire.OathAttachments.Kind`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.ActorId`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.Title`；`NationalSpire.PrivateOffer.TurnId`；`NationalSpire.PrivateRelation.OathConfirmed`；`NationalSpire.PrivateRelation.RefreshAppearance()`；`NationalSpire.PrivateRelation.Revision`；`NationalSpire.PrivateRelation.SelectedBond`；`NationalSpire.PrivateTurn.Error`；`NationalSpire.PrivateTurn.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatAttachments.Find(NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, string, System.Collections.Generic.Dictionary<string, string>)`；输入表达式：`ChatAttachments.Find(conversation, turn, Kind, fields)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ChatAttachments.Find(conversation, turn, Kind, fields)`
- `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Relation(data, conversation.PersonId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Relation(data, conversation.PersonId)`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new() { Id = attachment.Id, Kind = Kind, TurnId = turn.Id, ActorId = attachment.ActorId,              Title = attachment.Title, Detail = attachment.Detail, State = action == "接受" ? "已解除" : "已拒绝" }`；返回值紧邻使用处：`ArgumentSyntax: new() { Id = attachment.Id, Kind = Kind, TurnId = turn.Id, ActorId = attachment.ActorId,              Title = attachment.Title, Detail = attachment.Detail, State = action == "接受" ? "已解除" : "已拒绝" }`
- `NationalSpire.PrivateRelation.RefreshAppearance()`；输入表达式：`relation.RefreshAppearance()`；返回值紧邻使用处：`ExpressionStatementSyntax: relation.RefreshAppearance();`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Offers.Any(o => o.Kind == Kind && o.Id == attachment.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: attachment.ActorId != conversation.PersonId || conversation.Offers.Any(o => o.Kind == Kind && o.Id == attachment.Id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`fields.GetValueOrDefault("Oath", "")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = fields.GetValueOrDefault("Oath", "")`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`conversation.Offers.Add(new() { Id = attachment.Id, Kind = Kind, TurnId = turn.Id, ActorId = attachment.ActorId,              Title = attachment.Title, Detail = attachment.Detail, State = action == "接受" ? "已解除" : "已拒绝" })`；返回值紧邻使用处：`ExpressionStatementSyntax: conversation.Offers.Add(new() { Id = attachment.Id, Kind = Kind, TurnId = turn.Id, ActorId = attachment.ActorId,              Title = attachment.Title, Detail = attachment.Detail, State = action == "接受" ? "已解除" : "已拒绝" });`

**赋值（含属性/字段和局部值）：**

- `ActorId` = `attachment.ActorId`
- `Detail` = `attachment.Detail`
- `Id` = `attachment.Id`
- `Kind` = `Kind`
- `relation.OathConfirmed` = `false`
- `relation.SelectedBond` = `1`
- `State` = `action == "接受" ? "已解除" : "已拒绝"`
- `Title` = `attachment.Title`
- `turn.Error` += `"\n请在解除誓约附件中明确本次处理的编号。"`
- `TurnId` = `turn.Id`
