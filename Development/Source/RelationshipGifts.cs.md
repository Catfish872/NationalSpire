# RelationshipGifts.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`5186008169FE085D35F55EDBF22FB0784BD3B11E353F6BDDD2293F20783E53DB`。来源：[源码](../../RelationshipGifts.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.RelationshipGifts`。

字段、事件及初始值（源码原样）：

```csharp
public const string WeddingSteps = "需要由玩家后续再在附加请求中发起婚礼活动；完成玩家后续发起的婚礼活动后正式缔结誓约，不需要你自行发起婚礼活动。";
```

<a id="symbol-d05881b51110"></a>

## `NationalSpire.RelationshipGifts.Special(string) — public static bool Special(string good)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Changed(bool)`](ConsumerPickerScreen.cs.md#symbol-4cac190b7ec0)；[`NationalSpire.AiGeneratedText.Attachment(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](AiGeneratedText.cs.md#symbol-ac6a46b66492)；[`NationalSpire.RelationshipGifts.Intent(NationalSpire.PrivateOffer)`](RelationshipGifts.cs.md#symbol-4e26695a8286)；[`NationalSpire.WeddingAppointments.Accepted(NationalSpire.CareerData)`](WeddingAppointments.cs.md#symbol-9185c503bf33)；[`NationalSpire.WeddingAppointments.Services(NationalSpire.CareerData)`](WeddingAppointments.cs.md#symbol-2dfb2ee379ae)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4e26695a8286"></a>

## `NationalSpire.RelationshipGifts.Intent(NationalSpire.PrivateOffer) — public static int Intent(PrivateOffer offer)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool)`](ChatAttachments.cs.md#symbol-4e7c361b1f77)；[`NationalSpire.RelationshipGifts.Accept(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](RelationshipGifts.cs.md#symbol-821bf6a43163)；[`NationalSpire.RelationshipGifts.Description(NationalSpire.PrivateOffer)`](RelationshipGifts.cs.md#symbol-315d5a4ef0fd)；[`NationalSpire.RelationshipGifts.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](RelationshipGifts.cs.md#symbol-a99c2d3aea53)

**调用：** [`NationalSpire.RelationshipGifts.Special(string)`](RelationshipGifts.cs.md#symbol-d05881b51110)

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateOffer.GoodId`；`NationalSpire.PrivateOffer.RelationshipIntent`；`NationalSpire.RelationshipGifts.Special(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RelationshipGifts.Special(string)`；输入表达式：`Special(offer.GoodId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Special(offer.GoodId) ? 2 : offer.RelationshipIntent == 1 ? 1 : 0`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a99c2d3aea53"></a>

## `NationalSpire.RelationshipGifts.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer) — public static string? Error(CareerData data, string person, PrivateOffer offer)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatAttachments.Gift(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`](ChatAttachments.cs.md#symbol-cc6db06cee88)；[`NationalSpire.ChatAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool)`](ChatAttachments.cs.md#symbol-4e7c361b1f77)

**调用：** [`NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-13f25fec3dea)；[`NationalSpire.RelationshipGifts.Intent(NationalSpire.PrivateOffer)`](RelationshipGifts.cs.md#symbol-4e26695a8286)

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`；`NationalSpire.RelationshipGifts.Intent(NationalSpire.PrivateOffer)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Favour(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Favour(data, person)`
- `NationalSpire.RelationshipGifts.Intent(NationalSpire.PrivateOffer)`；输入表达式：`Intent(offer)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Intent(offer)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-315d5a4ef0fd"></a>

## `NationalSpire.RelationshipGifts.Description(NationalSpire.PrivateOffer) — public static string Description(PrivateOffer offer)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiGeneratedText.Attachment(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](AiGeneratedText.cs.md#symbol-ac6a46b66492)；[`NationalSpire.ChatAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool)`](ChatAttachments.cs.md#symbol-4e7c361b1f77)；[`NationalSpire.ChatAttachments.ResponseInstructions(NationalSpire.CareerData, NationalSpire.PrivateOffer, string, NationalSpire.GroupChat?, string)`](ChatAttachments.cs.md#symbol-f98de794e2ca)

**调用：** [`NationalSpire.RelationshipGifts.Intent(NationalSpire.PrivateOffer)`](RelationshipGifts.cs.md#symbol-4e26695a8286)

**字段、属性、事件及方法组引用：** `NationalSpire.RelationshipGifts.Intent(NationalSpire.PrivateOffer)`；`NationalSpire.RelationshipGifts.WeddingSteps`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RelationshipGifts.Intent(NationalSpire.PrivateOffer)`；输入表达式：`Intent(offer)`；返回值紧邻使用处：`SwitchExpressionSyntax: Intent(offer) switch      {          1 => "附加请求：确定恋人关系；接受礼物后成为恋人。",          2 => "附加请求：接受礼物后，" + WeddingSteps,          _ => ""      }`

**赋值（含属性/字段和局部值）：**


<a id="symbol-821bf6a43163"></a>

## `NationalSpire.RelationshipGifts.Accept(NationalSpire.CareerData, string, NationalSpire.PrivateOffer) — public static void Accept(CareerData data, string person, PrivateOffer offer)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatAttachments.Gift(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`](ChatAttachments.cs.md#symbol-cc6db06cee88)

**调用：** [`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-8a6bb6e78fa5)；[`NationalSpire.PrivateRelation.RefreshAppearance()`](PrivateMessageData.cs.md#symbol-fbf6e9bf540b)；[`NationalSpire.RelationshipGifts.Intent(NationalSpire.PrivateOffer)`](RelationshipGifts.cs.md#symbol-4e26695a8286)；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.GoodId`；`NationalSpire.PrivateRelation.RefreshAppearance()`；`NationalSpire.PrivateRelation.Revision`；`NationalSpire.PrivateRelation.RingReceived`；`NationalSpire.PrivateRelation.SelectedBond`；`NationalSpire.RelationshipGifts.Intent(NationalSpire.PrivateOffer)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Relation(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Relation(data, person)`
- `NationalSpire.PrivateRelation.RefreshAppearance()`；输入表达式：`relation.RefreshAppearance()`；返回值紧邻使用处：`ExpressionStatementSyntax: relation.RefreshAppearance();`
- `NationalSpire.RelationshipGifts.Intent(NationalSpire.PrivateOffer)`；输入表达式：`Intent(offer)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Intent(offer)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(relation.SelectedBond ?? 0, 1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: relation.SelectedBond = Math.Max(relation.SelectedBond ?? 0, 1)`

**赋值（含属性/字段和局部值）：**

- `relation.RingReceived` = `true`
- `relation.SelectedBond` = `Math.Max(relation.SelectedBond ?? 0, 1)`
