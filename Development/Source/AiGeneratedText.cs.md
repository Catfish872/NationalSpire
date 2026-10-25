# AiGeneratedText.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`59FD8E518D5836B642B99C259E23EAEF1590011957D60454D6346011F8569E99`。来源：[源码](../../AiGeneratedText.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.AiGeneratedText`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-ac6ac5681f0e"></a>

## `NationalSpire.AiGeneratedText.Source(NationalSpire.CommunityPost) — public static string Source(CommunityPost post)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.BuildDiscussionPrompt(NationalSpire.CareerData, System.Collections.Generic.ISet<string>, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiDiscussion.cs.md#symbol-142a77613e08)；[`NationalSpire.AiService.BuildNewsContext(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiContext.cs.md#symbol-7b21630a9e2c)；[`NationalSpire.AiService.MatchContext(NationalSpire.CareerData, NationalSpire.CommunityPost)`](AiContext.cs.md#symbol-eaa3e44ce66a)；[`NationalSpire.AiWireProtocol.AddMemorySources(System.Text.Json.Nodes.JsonNode)`](AiWireProtocol.cs.md#symbol-724c4b9d095b)；[`NationalSpire.CommunitySharing.Prepare(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](CommunitySharing.cs.md#symbol-b6e3b5a6b60e)；[`NationalSpire.Coop.CoopRules.Settle(NationalSpire.Coop.CoopWorld, string, bool, bool, int, double, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer>, System.Collections.Generic.Dictionary<ulong, NationalSpire.CareerResult>?, bool, bool, bool)`](Coop/CoopRules.cs.md#symbol-926ebe8770ca)；[`NationalSpire.PrivatePublicContext.PostTexts(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CareerPerson?, string, System.Collections.Generic.IEnumerable<NationalSpire.CommunityMemory>?, NationalSpire.CommunityMemorySearch.Request?, bool)`](PrivatePublicContext.cs.md#symbol-b4d8110deb5b)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityPost.AiSourceBody`；`NationalSpire.CommunityPost.SourceBody`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ff263d7615f1"></a>

## `NationalSpire.AiGeneratedText.Memory(NationalSpire.CommunityMemory) — public static string Memory(CommunityMemory memory)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityMemorySearch.PrivateAcquaintance(NationalSpire.CareerData, NationalSpire.CareerPerson, NationalSpire.CommunityMemorySearch.Request?)`](CommunityMemorySearch.cs.md#symbol-5c9e3196ce58)；[`NationalSpire.CommunityMemorySearch.Retrieve(NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>, int, System.Collections.Generic.ISet<string>, int, System.Collections.Generic.ISet<string>?, bool, NationalSpire.CommunityMemorySearch.Request?, System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>?)`](CommunityMemorySearch.cs.md#symbol-43d223752125)；[`NationalSpire.PrivatePublicContext.CommunityText(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>, System.Collections.Generic.List<NationalSpire.CommunityMemory>, System.Collections.Generic.Dictionary<string, NationalSpire.CommunityPost>, System.Collections.Generic.IEnumerable<string>, string, NationalSpire.CommunityMemorySearch.Request, NationalSpire.CareerPerson?, System.Collections.Generic.ISet<string>?, System.Collections.Generic.List<(string Id, string Text)>?, System.Collections.Generic.IEnumerable<NationalSpire.CommunityMemory>?, System.Collections.Generic.ISet<string>?)`](PrivatePublicContext.cs.md#symbol-a1c62d9fc8b9)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityMemory.AiText`；`NationalSpire.CommunityMemory.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ac6a46b66492"></a>

## `NationalSpire.AiGeneratedText.Attachment(NationalSpire.CareerData, NationalSpire.PrivateOffer) — public static string Attachment(CareerData data, PrivateOffer offer)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatAttachments.Material(NationalSpire.CareerData, NationalSpire.PrivateOffer, string)`](ChatAttachments.cs.md#symbol-90d268266519)；[`NationalSpire.GroupChatPrompts.UserText(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`](GroupChatPrompts.cs.md#symbol-28b2a2534bee)；[`NationalSpire.PrivateMessagePrompts.UserText(NationalSpire.CareerData, NationalSpire.PrivateTurn, NationalSpire.PrivateConversation, bool)`](PrivateMessagePrompts.cs.md#symbol-2e632c46656c)；[`NationalSpire.SpireArbitration.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn)`](SpireArbitration.cs.md#symbol-b1beb5c71e60)

**调用：** [`NationalSpire.CommunitySharing.Text(NationalSpire.CareerData, NationalSpire.CommunityQuote)`](CommunitySharing.cs.md#symbol-276822babdcb)；[`NationalSpire.GameCalendar.ConvertJsonDates(NationalSpire.CareerData, System.Text.Json.Nodes.JsonNode)`](GameCalendar.cs.md#symbol-c34ff65ec393)；[`NationalSpire.RelationshipGifts.Description(NationalSpire.PrivateOffer)`](RelationshipGifts.cs.md#symbol-315d5a4ef0fd)；[`NationalSpire.RelationshipGifts.Special(string)`](RelationshipGifts.cs.md#symbol-d05881b51110)；`string.Replace(string, string?, System.StringComparison)`；`string.StartsWith(string, System.StringComparison)`；`System.Text.Json.JsonSerializerOptions.JsonSerializerOptions()`；`System.Text.Json.Nodes.JsonNode.Parse(string, System.Text.Json.Nodes.JsonNodeOptions?, System.Text.Json.JsonDocumentOptions)`；`System.Text.Json.Nodes.JsonNode.ToJsonString(System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityReporting.Kind`；`NationalSpire.CommunitySharing.Kind`；`NationalSpire.CommunitySharing.Text(NationalSpire.CareerData, NationalSpire.CommunityQuote)`；`NationalSpire.GameCalendar.ConvertJsonDates(NationalSpire.CareerData, System.Text.Json.Nodes.JsonNode)`；`NationalSpire.PrivateOffer.AiDetail`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.GoodId`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Quote`；`NationalSpire.RelationshipGifts.Description(NationalSpire.PrivateOffer)`；`NationalSpire.RelationshipGifts.Special(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunitySharing.Text(NationalSpire.CareerData, NationalSpire.CommunityQuote)`；输入表达式：`CommunitySharing.Text(data, quote)`；返回值紧邻使用处：`ReturnStatementSyntax: return CommunitySharing.Text(data, quote);`
- `NationalSpire.GameCalendar.ConvertJsonDates(NationalSpire.CareerData, System.Text.Json.Nodes.JsonNode)`；输入表达式：`GameCalendar.ConvertJsonDates(data, node)`；返回值紧邻使用处：`ExpressionStatementSyntax: GameCalendar.ConvertJsonDates(data, node);`
- `NationalSpire.RelationshipGifts.Description(NationalSpire.PrivateOffer)`；输入表达式：`RelationshipGifts.Description(offer)`；返回值紧邻使用处：`ArgumentSyntax: RelationshipGifts.Description(offer)`
- `NationalSpire.RelationshipGifts.Special(string)`；输入表达式：`RelationshipGifts.Special(offer.GoodId)`；返回值紧邻使用处：`BinaryExpressionSyntax: offer.Kind == "gift" && RelationshipGifts.Special(offer.GoodId)`
- `string.Replace(string, string?, System.StringComparison)`；输入表达式：`text.Replace("附加请求：缔结誓约；接受礼物后确定誓约关系。", RelationshipGifts.Description(offer), StringComparison.Ordinal)                  .Replace("附加请求：接受礼物后可以择期举办婚礼；完成婚礼活动后正式缔结誓约。", RelationshipGifts.Description(offer), StringComparison.Ordinal)`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = text.Replace("附加请求：缔结誓约；接受礼物后确定誓约关系。", RelationshipGifts.Description(offer), StringComparison.Ordinal)                  .Replace("附加请求：接受礼物后可以择期举办婚礼；完成婚礼活动后正式缔结誓约。", RelationshipGifts.Description(offer), StringComparison.Ordinal)`
- `string.Replace(string, string?, System.StringComparison)`；输入表达式：`text.Replace("附加请求：缔结誓约；接受礼物后确定誓约关系。", RelationshipGifts.Description(offer), StringComparison.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.Replace("附加请求：缔结誓约；接受礼物后确定誓约关系。", RelationshipGifts.Description(offer), StringComparison.Ordinal)                  .Replace`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`text.StartsWith(report, StringComparison.Ordinal)`；返回值紧邻使用处：`BinaryExpressionSyntax: offer.Kind == CommunityReporting.Kind && offer.AiDetail != null && text.StartsWith(report, StringComparison.Ordinal)`
- `System.Text.Json.JsonSerializerOptions.JsonSerializerOptions()`；输入表达式：`new() { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }`；返回值紧邻使用处：`ArgumentSyntax: new() { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }`
- `System.Text.Json.Nodes.JsonNode.Parse(string, System.Text.Json.Nodes.JsonNodeOptions?, System.Text.Json.JsonDocumentOptions)`；输入表达式：`System.Text.Json.Nodes.JsonNode.Parse(text[report.Length..])`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: System.Text.Json.Nodes.JsonNode.Parse(text[report.Length..])!`
- `System.Text.Json.Nodes.JsonNode.ToJsonString(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`node.ToJsonString(new() { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping })`；返回值紧邻使用处：`BinaryExpressionSyntax: report + node.ToJsonString(new() { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping })`

**赋值（含属性/字段和局部值）：**

- `Encoder` = `System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping`
- `text` = `text.Replace("附加请求：缔结誓约；接受礼物后确定誓约关系。", RelationshipGifts.Description(offer), StringComparison.Ordinal)                  .Replace("附加请求：接受礼物后可以择期举办婚礼；完成婚礼活动后正式缔结誓约。", RelationshipGifts.Description(offer), StringComparison.Ordinal)`

<a id="symbol-8a7bdafb8195"></a>

## `NationalSpire.AiGeneratedText.Different(string, string) — public static string? Different(string original, string ai)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunitySharing.Prepare(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](CommunitySharing.cs.md#symbol-b6e3b5a6b60e)；[`NationalSpire.CommunityThreads.RememberMatch(NationalSpire.CareerData, NationalSpire.CareerResult)`](CommunityThreads.cs.md#symbol-fe6de6f8dd52)；[`NationalSpire.Coop.CoopRules.Settle(NationalSpire.Coop.CoopWorld, string, bool, bool, int, double, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer>, System.Collections.Generic.Dictionary<ulong, NationalSpire.CareerResult>?, bool, bool, bool)`](Coop/CoopRules.cs.md#symbol-926ebe8770ca)；[`NationalSpire.PrivateMessages.PrepareAttachments(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>)`](PrivateMessages.cs.md#symbol-f2d6d9cf9c86)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**
