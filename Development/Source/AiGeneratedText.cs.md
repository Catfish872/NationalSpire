# AiGeneratedText.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`860A73C8ABA0E4BA25D528246CAEEE8F3CA2814F3E7866088F7289B93F02E318`。来源：[源码](../../AiGeneratedText.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.AiGeneratedText`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-ac6ac5681f0e"></a>

## `NationalSpire.AiGeneratedText.Source(NationalSpire.CommunityPost) — public static string Source(CommunityPost post)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.BuildDiscussionPrompt(NationalSpire.CareerData, System.Collections.Generic.ISet<string>, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiDiscussion.cs.md#symbol-142a77613e08)；[`NationalSpire.AiService.BuildNewsContext(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiContext.cs.md#symbol-7b21630a9e2c)；[`NationalSpire.AiService.MatchContext(NationalSpire.CareerData, NationalSpire.CommunityPost)`](AiContext.cs.md#symbol-eaa3e44ce66a)；[`NationalSpire.Coop.CoopRules.Settle(NationalSpire.Coop.CoopWorld, string, bool, bool, int, double, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer>, System.Collections.Generic.Dictionary<ulong, NationalSpire.CareerResult>?, bool, bool)`](Coop/CoopRules.cs.md#symbol-ad906fb9e519)；[`NationalSpire.PrivatePublicContext.PostTexts(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CareerPerson, string, System.Collections.Generic.IEnumerable<NationalSpire.CommunityMemory>?, NationalSpire.CommunityMemorySearch.Request?)`](PrivatePublicContext.cs.md#symbol-0f3333edf327)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityPost.AiSourceBody`；`NationalSpire.CommunityPost.SourceBody`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ff263d7615f1"></a>

## `NationalSpire.AiGeneratedText.Memory(NationalSpire.CommunityMemory) — public static string Memory(CommunityMemory memory)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityMemorySearch.PrivateAcquaintance(NationalSpire.CareerData, NationalSpire.CareerPerson)`](CommunityMemorySearch.cs.md#symbol-ab53931edb52)；[`NationalSpire.CommunityMemorySearch.Retrieve(NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>, int, System.Collections.Generic.ISet<string>, int, System.Collections.Generic.ISet<string>?, bool, NationalSpire.CommunityMemorySearch.Request?)`](CommunityMemorySearch.cs.md#symbol-f933ce4e4ad8)；[`NationalSpire.PrivatePublicContext.Community(NationalSpire.CareerData, NationalSpire.CareerPerson, string, System.Collections.Generic.ISet<string>?, System.Collections.Generic.List<(string Id, string Text)>?, NationalSpire.CommunityMemorySearch.Request?)`](PrivatePublicContext.cs.md#symbol-58aebbb834b8)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityMemory.AiText`；`NationalSpire.CommunityMemory.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-be963fa419c7"></a>

## `NationalSpire.AiGeneratedText.Attachment(NationalSpire.PrivateOffer) — public static string Attachment(PrivateOffer offer)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupChatPrompts.UserText(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`](GroupChatPrompts.cs.md#symbol-28b2a2534bee)；[`NationalSpire.PrivateMessagePrompts.UserText(NationalSpire.PrivateTurn, NationalSpire.PrivateConversation, bool)`](PrivateMessagePrompts.cs.md#symbol-a6aa8a8392b1)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateOffer.AiDetail`；`NationalSpire.PrivateOffer.Detail`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8a7bdafb8195"></a>

## `NationalSpire.AiGeneratedText.Different(string, string) — public static string? Different(string original, string ai)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityThreads.RememberMatch(NationalSpire.CareerData, NationalSpire.CareerResult)`](CommunityThreads.cs.md#symbol-fe6de6f8dd52)；[`NationalSpire.Coop.CoopRules.Settle(NationalSpire.Coop.CoopWorld, string, bool, bool, int, double, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer>, System.Collections.Generic.Dictionary<ulong, NationalSpire.CareerResult>?, bool, bool)`](Coop/CoopRules.cs.md#symbol-ad906fb9e519)；[`NationalSpire.PrivateMessages.PrepareAttachments(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>)`](PrivateMessages.cs.md#symbol-f2d6d9cf9c86)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**
