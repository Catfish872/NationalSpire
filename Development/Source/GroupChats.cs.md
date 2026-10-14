# GroupChats.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`CC1B3A089F426FBC6C31A3D175F5764EEB04AF3D595C03A36FEB6F8E9B895440`。来源：[源码](../../GroupChats.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.GroupChats`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-d2f9293a6561"></a>

## `NationalSpire.GroupChats.Human(NationalSpire.CareerData) — public static string Human(CareerData d)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMarket.Fixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](CareerMarket.cs.md#symbol-089c75a03be9)；[`NationalSpire.CareerScreen.ClubDirectory(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-27a995f7ce9f)；[`NationalSpire.CareerScreen.FanChart(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-509582b2b893)；[`NationalSpire.CareerScreen.GroupBubble(string, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>?)`](GroupChatScreen.cs.md#symbol-870e7cca58c0)；[`NationalSpire.CareerScreen.GroupMemberPicker(NationalSpire.GroupChat?, System.Action<System.Collections.Generic.List<string>>, bool, string, bool)`](GroupChatScreen.cs.md#symbol-26ccde004356)；[`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`](GroupChatScreen.cs.md#symbol-3afa41099b93)；[`NationalSpire.CareerScreen.PreviewGroupPrompt()`](GroupChatDialogs.cs.md#symbol-b6bc7a2d0206)；[`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.CareerScreen.ShowPrivateListRows()`](PrivateListRows.cs.md#symbol-a42f68b15faf)；[`NationalSpire.CareerScreen.TickPrivate(double)`](PrivateMessageScreen.cs.md#symbol-3877a8ac5969)；[`NationalSpire.CharacterCards.Apply(NationalSpire.CareerData, NationalSpire.CharacterCardEdit, NationalSpire.CareerLifeState?, string?)`](CharacterCards.cs.md#symbol-a50771d297a5)；[`NationalSpire.ChatTimeline.External(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string, string)`](ChatTimeline.cs.md#symbol-9e2563e0bf97)；[`NationalSpire.ChatTimeline.Mailboxes(NationalSpire.CareerData)`](ChatTimeline.cs.md#symbol-4c52c52dffbc)；[`NationalSpire.ChatTimeline.Summaries(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string, string)`](ChatTimeline.cs.md#symbol-2b6ae7313c3c)；[`NationalSpire.ClubAudience.Total(NationalSpire.CareerData, string)`](ClubAudience.cs.md#symbol-6a78e48d0de3)；[`NationalSpire.ConsumerEngine.Buy(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>?)`](ConsumerEngine.cs.md#symbol-6a13be5c34c1)；[`NationalSpire.ConsumerEngine.Use(NationalSpire.CareerData, string, string, System.Collections.Generic.IReadOnlyList<string>)`](ConsumerEngine.cs.md#symbol-c0beece783ab)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`](GroupChats.cs.md#symbol-e0439deb45ac)；[`NationalSpire.GroupChats.Create(NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>)`](GroupChats.cs.md#symbol-4ad9f7892734)；[`NationalSpire.GroupChats.InLane<T>(NationalSpire.CareerData, NationalSpire.GroupChat, string, string, string, System.Func<NationalSpire.PrivateConversation, T>)`](GroupChats.cs.md#symbol-167e5090d91a)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；[`NationalSpire.GroupChats.PreviewCopy(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-76ad48e0a3a3)；[`NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-81f7f177c347)；[`NationalSpire.MarketDynamics.Anchors(NationalSpire.CareerData)`](MarketDynamics.cs.md#symbol-9a7ffea26eec)；[`NationalSpire.MarketTerminal.Bind(NationalSpire.CareerData, System.Action<NationalSpire.MarketOrder>, System.Action<string>)`](MarketTerminal.cs.md#symbol-09b1a1ea6de7)；[`NationalSpire.SocialAppointments.All(NationalSpire.CareerData)`](SocialAppointments.cs.md#symbol-0596ed8dd544)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.LocalHumanId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c362351c7a43"></a>

## `NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData) — public static long NextOrder(CareerData d)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Execute(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`](GroupArbitration.cs.md#symbol-b38ef0bc526d)；[`NationalSpire.AiService.ProcessGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string>?)`](AiGroupChats.cs.md#symbol-caddadc35a6b)；[`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)；[`NationalSpire.GroupChats.AddMembers(NationalSpire.CareerData, NationalSpire.GroupChat, System.Collections.Generic.IEnumerable<string>)`](GroupChats.cs.md#symbol-7126c219277b)；[`NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`](GroupChats.cs.md#symbol-e0439deb45ac)；[`NationalSpire.PrivateMessages.Enqueue(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer?, System.Collections.Generic.List<NationalSpire.PrivateOffer>?)`](PrivateMessages.cs.md#symbol-7823819594c6)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.ChatWorld.Order`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-24bc82bdbbd4"></a>

## `NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string) — public static bool IsHuman(CareerData d, string id)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatTimeline.RelatedGroups(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string)`](ChatTimeline.cs.md#symbol-8b6515c12ceb)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.GroupChats.AddMembers(NationalSpire.CareerData, NationalSpire.GroupChat, System.Collections.Generic.IEnumerable<string>)`](GroupChats.cs.md#symbol-7126c219277b)；[`NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`](GroupChats.cs.md#symbol-e0439deb45ac)；[`NationalSpire.GroupChats.InLane<T>(NationalSpire.CareerData, NationalSpire.GroupChat, string, string, string, System.Func<NationalSpire.PrivateConversation, T>)`](GroupChats.cs.md#symbol-167e5090d91a)；[`NationalSpire.GroupChats.Rewind(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`](GroupChats.cs.md#symbol-d45d31e160a9)；[`NationalSpire.GroupChats.SpeechUnavailable(NationalSpire.CareerData, NationalSpire.GroupChat, string)`](GroupChats.cs.md#symbol-77b18ea82814)；[`NationalSpire.GroupInteractions.Apply(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn, System.Collections.Generic.IEnumerable<System.Collections.Generic.Dictionary<string, string>>)`](GroupInteractions.cs.md#symbol-2b413a511485)；[`NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool)`](PrivateInteractionUndo.cs.md#symbol-de9e985d044d)；[`NationalSpire.PrivateInteractionHistory.Restore(NationalSpire.CareerData, string, System.Text.Json.Nodes.JsonObject, bool)`](PrivateInteractionUndo.cs.md#symbol-dd91210e87c0)

**调用：** `System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.HumanIds`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`d.HumanIds.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: id == "player" || d.HumanIds.Contains(id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-bc138d545f34"></a>

## `NationalSpire.GroupChats.CanSpeak(NationalSpire.CareerData, string) — public static bool CanSpeak(CareerData d, string id)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`](GroupChats.cs.md#symbol-e0439deb45ac)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；[`NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`](SpireArbitration.cs.md#symbol-909e0981d663)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；`NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(d, id)!`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(d, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateMessages.CanChat(d, id) && !SpireArbitration.Muted(CareerEngine.Person(d, id)!)`
- `NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`；输入表达式：`SpireArbitration.Muted(CareerEngine.Person(d, id)!)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !SpireArbitration.Muted(CareerEngine.Person(d, id)!)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-77b18ea82814"></a>

## `NationalSpire.GroupChats.SpeechUnavailable(NationalSpire.CareerData, NationalSpire.GroupChat, string) — public static string SpeechUnavailable(CareerData d, GroupChat g, string id)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string>?)`](AiGroupChats.cs.md#symbol-caddadc35a6b)；[`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.CareerScreen.UpdateGroupStream(NationalSpire.GroupChat, string, string)`](GroupChatScreen.cs.md#symbol-c33de3d8ae73)；[`NationalSpire.GroupInteractions.Apply(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn, System.Collections.Generic.IEnumerable<System.Collections.Generic.Dictionary<string, string>>)`](GroupInteractions.cs.md#symbol-2b413a511485)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-24bc82bdbbd4)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；[`NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`](SpireArbitration.cs.md#symbol-909e0981d663)；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Person(d, id) == null`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(d, id)!`
- `NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`IsHuman(d, id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: IsHuman(d, id) ? "模型不能代替玩家发言或决定。"          : CareerEngine.Person(d, id) == null ? "人物已不存在。"          : SpireArbitration.Muted(CareerEngine.Person(d, id)!) ? Name(d, id) + "的账号已封禁。" : ""`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`Name(d, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: Name(d, id) + "的账号已封禁。"`
- `NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`；输入表达式：`SpireArbitration.Muted(CareerEngine.Person(d, id)!)`；返回值紧邻使用处：`ConditionalExpressionSyntax: SpireArbitration.Muted(CareerEngine.Person(d, id)!) ? Name(d, id) + "的账号已封禁。" : ""`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`g.Members.Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !g.Members.Contains(id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-26060b09ab4b"></a>

## `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string) — public static string Name(CareerData d, string id)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Execute(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`](GroupArbitration.cs.md#symbol-b38ef0bc526d)；[`NationalSpire.AiService.SummarizeGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, string)`](AiGroupChats.cs.md#symbol-1e6e737dbe88)；[`NationalSpire.CareerScreen.GroupArbitrationDialog()`](GroupChatDialogs.cs.md#symbol-b436b0c3aa2f)；[`NationalSpire.CareerScreen.GroupBubble(string, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>?)`](GroupChatScreen.cs.md#symbol-870e7cca58c0)；[`NationalSpire.CareerScreen.GroupMemberPicker(NationalSpire.GroupChat?, System.Action<System.Collections.Generic.List<string>>, bool, string, bool)`](GroupChatScreen.cs.md#symbol-26ccde004356)；[`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`](GroupChatScreen.cs.md#symbol-3afa41099b93)；[`NationalSpire.CareerScreen.GroupTrainingPicker()`](GroupChatDialogs.cs.md#symbol-1e2068d8bf79)；[`NationalSpire.CareerScreen.PrivateTrainingCard(NationalSpire.CareerData, NationalSpire.CoachTrainingPlan, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`](CoachScreen.cs.md#symbol-c2e37e4a0f14)；[`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.CareerScreen.RefreshPrivateList()`](PrivateMessageScreen.cs.md#symbol-fca825e025fa)；[`NationalSpire.ChatTimeline.External(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string, string)`](ChatTimeline.cs.md#symbol-9e2563e0bf97)；[`NationalSpire.ChatTimeline.PrivateHistory(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?)`](ChatTimeline.cs.md#symbol-4c7ee0ce6871)；[`NationalSpire.ChatTimeline.PublicMemories(NationalSpire.CareerData, string, int)`](ChatTimeline.cs.md#symbol-26f194fa1e79)；[`NationalSpire.ChatTimeline.Summaries(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string, string)`](ChatTimeline.cs.md#symbol-2b6ae7313c3c)；[`NationalSpire.GroupArbitration.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`](GroupArbitration.cs.md#symbol-af12ffcc2740)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.GroupChatPrompts.InteractionContext(NationalSpire.CareerData, NationalSpire.GroupChat, int, string, string)`](GroupChatPrompts.cs.md#symbol-ccc55b5e837d)；[`NationalSpire.GroupChatPrompts.UserText(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`](GroupChatPrompts.cs.md#symbol-28b2a2534bee)；[`NationalSpire.GroupChats.AddMembers(NationalSpire.CareerData, NationalSpire.GroupChat, System.Collections.Generic.IEnumerable<string>)`](GroupChats.cs.md#symbol-7126c219277b)；[`NationalSpire.GroupChats.Rewind(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`](GroupChats.cs.md#symbol-d45d31e160a9)；[`NationalSpire.GroupChats.SpeechUnavailable(NationalSpire.CareerData, NationalSpire.GroupChat, string)`](GroupChats.cs.md#symbol-77b18ea82814)；[`NationalSpire.GroupInteractions.Apply(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn, System.Collections.Generic.IEnumerable<System.Collections.Generic.Dictionary<string, string>>)`](GroupInteractions.cs.md#symbol-2b413a511485)；[`NationalSpire.PrivateAppointments.Schedule(NationalSpire.CareerData, string, int)`](PrivateAppointments.cs.md#symbol-8d91a4d33a55)；[`NationalSpire.PrivateMessagePrompts.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-4b9d12b26f65)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: id == Human(d) ? CareerEngine.Name(d) : CareerEngine.DisplayName(d, id)`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`ConditionalExpressionSyntax: id == Human(d) ? CareerEngine.Name(d) : CareerEngine.DisplayName(d, id)`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`Human(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: id == Human(d)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-85bf6e1105fe"></a>

## `NationalSpire.GroupChats.Busy(NationalSpire.GroupChat) — public static bool Busy(GroupChat g)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.CareerScreen.SendGroup()`](GroupChatScreen.cs.md#symbol-17b4992ac7c2)；[`NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`](GroupChats.cs.md#symbol-e0439deb45ac)；[`Step()`](Coop/CoopReception.cs.md#symbol-41b14a0db411)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.GroupChat.Turns`；`NationalSpire.GroupTurn.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Turns.Any(t => t.Status is "queued" or "sending")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => g.Turns.Any(t => t.Status is "queued" or "sending")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-81f7f177c347"></a>

## `NationalSpire.GroupChats.Visible(NationalSpire.CareerData) — public static IEnumerable<GroupChat> Visible(CareerData d)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.CareerScreen.GroupMemberPicker(NationalSpire.GroupChat?, System.Action<System.Collections.Generic.List<string>>, bool, string, bool)`](GroupChatScreen.cs.md#symbol-26ccde004356)；[`NationalSpire.CareerScreen.RefreshPrivateList()`](PrivateMessageScreen.cs.md#symbol-fca825e025fa)；[`NationalSpire.CareerScreen.TickPrivate(double)`](PrivateMessageScreen.cs.md#symbol-3877a8ac5969)；[`NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`](GroupChats.cs.md#symbol-e0439deb45ac)；[`NationalSpire.SocialAppointments.All(NationalSpire.CareerData)`](SocialAppointments.cs.md#symbol-0596ed8dd544)

**调用：** [`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`Human(d)`；返回值紧邻使用处：`ArgumentSyntax: Human(d)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Chats.Groups.Where(g => g.Members.Contains(Human(d)))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => d.Chats.Groups.Where(g => g.Members.Contains(Human(d)))`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`g.Members.Contains(Human(d))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.Members.Contains(Human(d))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4ad9f7892734"></a>

## `NationalSpire.GroupChats.Create(NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>) — public static GroupChat Create(CareerData d, string name, IEnumerable<string> members)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`](GroupChats.cs.md#symbol-e0439deb45ac)

**调用：** [`NationalSpire.GroupChats.AddMembers(NationalSpire.CareerData, NationalSpire.GroupChat, System.Collections.Generic.IEnumerable<string>)`](GroupChats.cs.md#symbol-7126c219277b)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；`NationalSpire.GroupChat.GroupChat()`；`string.Trim()`；`System.Collections.Generic.IEnumerable<TSource>.Prepend<TSource>(TSource)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.GroupChat.Creator`；`NationalSpire.GroupChat.Name`；`NationalSpire.GroupChats.AddMembers(NationalSpire.CareerData, NationalSpire.GroupChat, System.Collections.Generic.IEnumerable<string>)`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChat.GroupChat()`；输入表达式：`new GroupChat { Name = name.Trim(), Creator = Human(d) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GroupChat { Name = name.Trim(), Creator = Human(d) }`
- `NationalSpire.GroupChats.AddMembers(NationalSpire.CareerData, NationalSpire.GroupChat, System.Collections.Generic.IEnumerable<string>)`；输入表达式：`AddMembers(d, g, members.Prepend(g.Creator))`；返回值紧邻使用处：`ExpressionStatementSyntax: AddMembers(d, g, members.Prepend(g.Creator));`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`Human(d)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Creator = Human(d)`
- `string.Trim()`；输入表达式：`name.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Name = name.Trim()`
- `System.Collections.Generic.IEnumerable<TSource>.Prepend<TSource>(TSource)`；输入表达式：`members.Prepend(g.Creator)`；返回值紧邻使用处：`ArgumentSyntax: members.Prepend(g.Creator)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Chats.Groups.Add(g)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Chats.Groups.Add(g);`

**赋值（含属性/字段和局部值）：**

- `Creator` = `Human(d)`
- `g.Name` = `"新群聊"`
- `Name` = `name.Trim()`

<a id="symbol-7126c219277b"></a>

## `NationalSpire.GroupChats.AddMembers(NationalSpire.CareerData, NationalSpire.GroupChat, System.Collections.Generic.IEnumerable<string>) — public static void AddMembers(CareerData d, GroupChat g, IEnumerable<string> people)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`](GroupChats.cs.md#symbol-e0439deb45ac)；[`NationalSpire.GroupChats.Create(NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>)`](GroupChats.cs.md#symbol-4ad9f7892734)

**调用：** [`NationalSpire.GroupChat.Alias(string)`](GroupChatData.cs.md#symbol-917ad43aeded)；[`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-24bc82bdbbd4)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；[`NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-c362351c7a43)；`NationalSpire.GroupEntry.GroupEntry()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.People`；`NationalSpire.CareerPerson.Id`；`NationalSpire.GroupChat.Alias(string)`；`NationalSpire.GroupChat.Entries`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupChat.Revision`；`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`；`NationalSpire.GroupEntry.Author`；`NationalSpire.GroupEntry.Day`；`NationalSpire.GroupEntry.Notice`；`NationalSpire.GroupEntry.Order`；`NationalSpire.GroupEntry.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChat.Alias(string)`；输入表达式：`g.Alias(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: g.Alias(id);`
- `NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`IsHuman(d, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsHuman(d, id) || d.People.Any(p => p.Id == id)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`Name(d, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: Name(d, id) + "加入了群聊"`
- `NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`；输入表达式：`NextOrder(d)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Order = NextOrder(d)`
- `NationalSpire.GroupEntry.GroupEntry()`；输入表达式：`new() { Order = NextOrder(d), Day = d.Day, Author = id, Text = Name(d, id) + "加入了群聊", Notice = true }`；返回值紧邻使用处：`ArgumentSyntax: new() { Order = NextOrder(d), Day = d.Day, Author = id, Text = Name(d, id) + "加入了群聊", Notice = true }`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Any(p => p.Id == id)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsHuman(d, id) || d.People.Any(p => p.Id == id)`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`people.Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: people.Distinct().Where`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`people.Distinct().Where(id => IsHuman(d, id) || d.People.Any(p => p.Id == id))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string id in people.Distinct().Where(id => IsHuman(d, id) || d.People.Any(p => p.Id == id)))          {              if (g.Members.Contains(id)) continue;              g.Members.Add(id); g.Alias(id);              g.Entries.Add(new() { Order = NextOrder(d), Day = d.Day, Author = id, Text = Name(d, id) + "加入了群聊", Notice = true });          }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`g.Entries.Add(new() { Order = NextOrder(d), Day = d.Day, Author = id, Text = Name(d, id) + "加入了群聊", Notice = true })`；返回值紧邻使用处：`ExpressionStatementSyntax: g.Entries.Add(new() { Order = NextOrder(d), Day = d.Day, Author = id, Text = Name(d, id) + "加入了群聊", Notice = true });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`g.Members.Add(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: g.Members.Add(id);`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`g.Members.Contains(id)`；返回值紧邻使用处：`IfStatementSyntax: if (g.Members.Contains(id)) continue;`

**赋值（含属性/字段和局部值）：**

- `Author` = `id`
- `Day` = `d.Day`
- `Notice` = `true`
- `Order` = `NextOrder(d)`
- `Text` = `Name(d, id) + "加入了群聊"`

<a id="symbol-44e7016bffca"></a>

## `NationalSpire.GroupChats.Lane(NationalSpire.GroupChat, string, string, string) — public static PrivateConversation Lane(GroupChat g, string human, string person, string target = "")`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupChats.InLane<T>(NationalSpire.CareerData, NationalSpire.GroupChat, string, string, string, System.Func<NationalSpire.PrivateConversation, T>)`](GroupChats.cs.md#symbol-167e5090d91a)

**调用：** `NationalSpire.PrivateConversation.PrivateConversation()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.GroupChat.Interactions`；`NationalSpire.PrivateConversation.PersonId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateConversation.PrivateConversation()`；输入表达式：`new() { PersonId = person }`；返回值紧邻使用处：`AssignmentExpressionSyntax: lane = new() { PersonId = person }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`g.Interactions.TryGetValue(key, out var lane)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !g.Interactions.TryGetValue(key, out var lane)`

**赋值（含属性/字段和局部值）：**

- `g.Interactions[key]` = `lane = new() { PersonId = person }`
- `lane` = `new() { PersonId = person }`
- `PersonId` = `person`

<a id="symbol-167e5090d91a"></a>

## `NationalSpire.GroupChats.InLane<T>(NationalSpire.CareerData, NationalSpire.GroupChat, string, string, string, System.Func<NationalSpire.PrivateConversation, T>) — public static T InLane<T>(CareerData d, GroupChat g, string human, string person, string target, Func<PrivateConversation, T> action)`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Execute(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`](GroupArbitration.cs.md#symbol-b38ef0bc526d)；[`NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`](GroupChats.cs.md#symbol-e0439deb45ac)；[`NationalSpire.GroupChats.Rewind(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`](GroupChats.cs.md#symbol-d45d31e160a9)；[`NationalSpire.GroupInteractions.Apply(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn, System.Collections.Generic.IEnumerable<System.Collections.Generic.Dictionary<string, string>>)`](GroupInteractions.cs.md#symbol-2b413a511485)

**调用：** [`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-24bc82bdbbd4)；[`NationalSpire.GroupChats.Lane(NationalSpire.GroupChat, string, string, string)`](GroupChats.cs.md#symbol-44e7016bffca)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`NationalSpire.PrivateRelation.PrivateRelation()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Func<T, TResult>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.PrivateMemorySources`；`NationalSpire.CareerLifeState.Mailbox`；`NationalSpire.CareerLifeState.Relationships`；`NationalSpire.ChatWorld.Relations`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.GroupChats.Lane(NationalSpire.GroupChat, string, string, string)`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMailbox.Relations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`Human(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: human != Human(d)`
- `NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`IsHuman(d, target)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsHuman(d, target)`
- `NationalSpire.GroupChats.Lane(NationalSpire.GroupChat, string, string, string)`；输入表达式：`Lane(g, human, person, target)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Lane(g, human, person, target)`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Mailbox(d)`
- `NationalSpire.PrivateRelation.PrivateRelation()`；输入表达式：`new()`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Chats.Relations.GetValueOrDefault(relationKey) ?? new()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`box.Conversations.Remove(person)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.Conversations.Remove(person);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`box.Relations.Remove(person)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.Relations.Remove(person);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`d.Life.Relationships.Remove(person)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Life.Relationships.Remove(person);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`d.Life.Relationships.TryGetValue(person, out int legacy)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Life.Relationships.TryGetValue(person, out int legacy)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`box.Conversations.GetValueOrDefault(person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = box.Conversations.GetValueOrDefault(person)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`box.Relations.GetValueOrDefault(person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = box.Relations.GetValueOrDefault(person)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`d.Chats.Relations.GetValueOrDefault(relationKey)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Chats.Relations.GetValueOrDefault(relationKey) ?? new()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`d.PrivateMemorySources.GetValueOrDefault(human)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.PrivateMemorySources.GetValueOrDefault(human) ?? lifeBox`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`action(lane)`；返回值紧邻使用处：`ReturnStatementSyntax: return action(lane);`

**赋值（含属性/字段和局部值）：**

- `box.Conversations[person]` = `lane`
- `box.Conversations[person]` = `oldConversation`
- `box.Relations[person]` = `d.Chats.Relations.GetValueOrDefault(relationKey) ?? new()`
- `box.Relations[person]` = `oldRelation`
- `d.Chats.Relations[relationKey]` = `box.Relations[person]`
- `d.Life.Mailbox` = `box`
- `d.Life.Mailbox` = `lifeBox`
- `d.Life.Relationships[person]` = `legacy`

<a id="symbol-e0439deb45ac"></a>

## `NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand) — public static string? Command(CareerData d, string kind, string id, GroupCommand command)`

来源：源码第 67 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.Coop.CoopRules.GroupCommand(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.Coop.CoopCommand)`](Coop/CoopGroupChats.cs.md#symbol-65a87ad49e08)

**调用：** [`NationalSpire.AiService.CancelGroup(NationalSpire.CareerData, string)`](AiGroupChats.cs.md#symbol-8ecf66adf72d)；[`NationalSpire.GroupArbitration.LinkPublication(NationalSpire.CareerData, NationalSpire.GroupChat, string)`](GroupArbitration.cs.md#symbol-9a6b33178ad4)；[`NationalSpire.GroupChats.AddMembers(NationalSpire.CareerData, NationalSpire.GroupChat, System.Collections.Generic.IEnumerable<string>)`](GroupChats.cs.md#symbol-7126c219277b)；[`NationalSpire.GroupChats.Busy(NationalSpire.GroupChat)`](GroupChats.cs.md#symbol-85bf6e1105fe)；[`NationalSpire.GroupChats.CanSpeak(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-bc138d545f34)；[`NationalSpire.GroupChats.Create(NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>)`](GroupChats.cs.md#symbol-4ad9f7892734)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.GroupChats.InLane<T>(NationalSpire.CareerData, NationalSpire.GroupChat, string, string, string, System.Func<NationalSpire.PrivateConversation, T>)`](GroupChats.cs.md#symbol-167e5090d91a)；[`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-24bc82bdbbd4)；[`NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-c362351c7a43)；[`NationalSpire.GroupChats.PreviewCopy(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-76ad48e0a3a3)；[`NationalSpire.GroupChats.Rewind(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`](GroupChats.cs.md#symbol-d45d31e160a9)；[`NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-81f7f177c347)；[`NationalSpire.MatchFailure.Locked(NationalSpire.CareerData)`](FailureDecision.cs.md#symbol-7f4fa41ad4c0)；[`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)；[`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；[`NationalSpire.PrivateSummary.IsLatest(System.Collections.Generic.IEnumerable<NationalSpire.PrivateSummary>)`](PrivateMessageData.cs.md#symbol-db2a1a2d7b09)；[`NationalSpire.SocialAppointments.Attend(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](SocialAppointments.cs.md#symbol-4dbc4f79108f)；[`NationalSpire.SocialAppointments.Confirm(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer)`](SocialAppointments.cs.md#symbol-2f0b4ecea199)；`long.ToString()`；`NationalSpire.GroupTurn.GroupTurn()`；`string.EndsWith(string)`；`string.IsNullOrWhiteSpace(string?)`；`string.StartsWith(string)`；`System.Collections.Generic.IEnumerable<int>.Max()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Clear()`；`System.Collections.Generic.List<T>.Remove(T)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.CancelGroup(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.Chats`；`NationalSpire.CareerData.Day`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.GroupArbitration.LinkPublication(NationalSpire.CareerData, NationalSpire.GroupChat, string)`；`NationalSpire.GroupChat.BigSummaries`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Interactions`；`NationalSpire.GroupChat.LastInteractionNumber`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupChat.Revision`；`NationalSpire.GroupChat.Seen`；`NationalSpire.GroupChat.Settings`；`NationalSpire.GroupChat.SmallSummaries`；`NationalSpire.GroupChat.SummarizedThrough`；`NationalSpire.GroupChat.Turns`；`NationalSpire.GroupChats.AddMembers(NationalSpire.CareerData, NationalSpire.GroupChat, System.Collections.Generic.IEnumerable<string>)`；`NationalSpire.GroupChats.Busy(NationalSpire.GroupChat)`；`NationalSpire.GroupChats.CanSpeak(NationalSpire.CareerData, string)`；`NationalSpire.GroupChats.Create(NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>)`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.GroupChats.InLane<T>(NationalSpire.CareerData, NationalSpire.GroupChat, string, string, string, System.Func<NationalSpire.PrivateConversation, T>)`；`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`；`NationalSpire.GroupChats.PreviewCopy(NationalSpire.CareerData)`；`NationalSpire.GroupChats.Rewind(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`；`NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`；`NationalSpire.GroupCommand.Attachments`；`NationalSpire.GroupCommand.Interaction`；`NationalSpire.GroupCommand.Lane`；`NationalSpire.GroupCommand.People`；`NationalSpire.GroupCommand.Settings`；`NationalSpire.GroupCommand.Text`；`NationalSpire.GroupEffect.Human`；`NationalSpire.GroupEffect.Lane`；`NationalSpire.GroupEffect.Person`；`NationalSpire.GroupEffect.Target`；`NationalSpire.GroupEffect.Turn`；`NationalSpire.GroupHistorySettings.MergeOldest`；`NationalSpire.GroupHistorySettings.RecentRounds`；`NationalSpire.GroupHistorySettings.SmallSummaryLimit`；`NationalSpire.GroupHistorySettings.SummaryEvery`；`NationalSpire.GroupTurn.ArbitrationTargets`；`NationalSpire.GroupTurn.Attachments`；`NationalSpire.GroupTurn.Day`；`NationalSpire.GroupTurn.Effects`；`NationalSpire.GroupTurn.Error`；`NationalSpire.GroupTurn.Order`；`NationalSpire.GroupTurn.Raw`；`NationalSpire.GroupTurn.Reasoning`；`NationalSpire.GroupTurn.Replies`；`NationalSpire.GroupTurn.Sender`；`NationalSpire.GroupTurn.SpeechOrders`；`NationalSpire.GroupTurn.Status`；`NationalSpire.GroupTurn.Text`；`NationalSpire.MatchFailure.Locked(NationalSpire.CareerData)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateMessageCommand.Entry`；`NationalSpire.PrivateMessageCommand.Offer`；`NationalSpire.PrivateMessageCommand.Part`；`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.CoachAccepted`；`NationalSpire.PrivateOffer.GroupId`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.TurnId`；`NationalSpire.PrivateSummary.From`；`NationalSpire.PrivateSummary.Id`；`NationalSpire.PrivateSummary.IsLatest(System.Collections.Generic.IEnumerable<NationalSpire.PrivateSummary>)`；`NationalSpire.PrivateSummary.Text`；`NationalSpire.PrivateSummary.Through`；`NationalSpire.SocialAppointments.Attend(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.SocialAppointments.Confirm(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `long.ToString()`；输入表达式：`(++g.LastInteractionNumber).ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: a.Id = (++g.LastInteractionNumber).ToString()`
- `NationalSpire.AiService.CancelGroup(NationalSpire.CareerData, string)`；输入表达式：`AiService.CancelGroup(d, g.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: AiService.CancelGroup(d, g.Id);`
- `NationalSpire.GroupArbitration.LinkPublication(NationalSpire.CareerData, NationalSpire.GroupChat, string)`；输入表达式：`GroupArbitration.LinkPublication(d, g, effect.Turn)`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupArbitration.LinkPublication(d, g, effect.Turn);`
- `NationalSpire.GroupChats.AddMembers(NationalSpire.CareerData, NationalSpire.GroupChat, System.Collections.Generic.IEnumerable<string>)`；输入表达式：`AddMembers(d, g, command.People)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddMembers(d, g, command.People);`
- `NationalSpire.GroupChats.Busy(NationalSpire.GroupChat)`；输入表达式：`Busy(g)`；返回值紧邻使用处：`IfStatementSyntax: if (Busy(g)) return "正在回复，请等待本轮结束。";`
- `NationalSpire.GroupChats.CanSpeak(NationalSpire.CareerData, string)`；输入表达式：`CanSpeak(d, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => CanSpeak(d, id)`
- `NationalSpire.GroupChats.Create(NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>)`；输入表达式：`Create(d, command.Text, command.People)`；返回值紧邻使用处：`ExpressionStatementSyntax: Create(d, command.Text, command.People);`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`Human(d)`；返回值紧邻使用处：`ArgumentSyntax: Human(d)`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`Human(d)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Sender = Human(d)`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`Human(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: effect.Human != Human(d)`
- `NationalSpire.GroupChats.InLane<T>(NationalSpire.CareerData, NationalSpire.GroupChat, string, string, string, System.Func<NationalSpire.PrivateConversation, T>)`；输入表达式：`InLane(d, g, effect.Human, effect.Person, effect.Target, c =>              {                  if (!humanActivity) return PrivateMessageCommands.Apply(d, "dm-" + kind[12..], effect.Person, command.Interaction);                  var offer = c.Offers.FirstOrDefault(o => o.Id == command.Interaction.Offer && o.Kind == "activity");                  if (offer == null) return "活动已不存在。";                  if (kind == "group-offer-confirm") return SocialAppointments.Confirm(d, c, offer);                  if (kind == "group-offer-attend") return SocialAppointments.Attend(d, offer);                  if (kind == "group-offer-decline")                  {                      if (offer.State is not ("待确认" or "已确认")) return "这项活动已处理。";                      offer.State = "已取消"; return null;                  }                  return "活动操作无效。";              })`；返回值紧邻使用处：`EqualsValueClauseSyntax: = InLane(d, g, effect.Human, effect.Person, effect.Target, c =>              {                  if (!humanActivity) return PrivateMessageCommands.Apply(d, "dm-" + kind[12..], effect.Person, command.Interaction);                  var offer = c.Offers.FirstOrDefault(o => o.Id == command.Interaction.Offer && o.Kind == "activity");                  if (offer == null) return "活动已不存在。";                  if (kind == "group-offer-confirm") return SocialAppointments.Confirm(d, c, offer);                  if (kind == "group-offer-attend") return SocialAppointments.Attend(d, offer);                  if (kind == "group-offer-decline")                  {                      if (offer.State is not ("待确认" or "已确认")) return "这项活动已处理。";                      offer.State = "已取消"; return null;                  }                  return "活动操作无效。";              })`
- `NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`IsHuman(d, effect.Person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = IsHuman(d, effect.Person)`
- `NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`；输入表达式：`NextOrder(d)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Order = NextOrder(d)`
- `NationalSpire.GroupChats.PreviewCopy(NationalSpire.CareerData)`；输入表达式：`PreviewCopy(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PreviewCopy(d)`
- `NationalSpire.GroupChats.Rewind(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`；输入表达式：`Rewind(d, g, last)`；返回值紧邻使用处：`ExpressionStatementSyntax: Rewind(d, g, last);`
- `NationalSpire.GroupChats.Rewind(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`；输入表达式：`Rewind(probe, probeGroup, probeGroup.Turns[^1])`；返回值紧邻使用处：`IsPatternExpressionSyntax: Rewind(probe, probeGroup, probeGroup.Turns[^1]) is { } error`
- `NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`；输入表达式：`Visible(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Visible(d).FirstOrDefault`
- `NationalSpire.GroupTurn.GroupTurn()`；输入表达式：`new GroupTurn { Sender = Human(d), Day = d.Day, Order = NextOrder(d), Text = command.Text, Attachments = command.Attachments,                  ArbitrationTargets = kind == "group-arbitrate" ? command.People.Where(g.Members.Contains).Where(id => PrivateMessages.CanChat(d, id)).Distinct().ToList() : [] }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GroupTurn { Sender = Human(d), Day = d.Day, Order = NextOrder(d), Text = command.Text, Attachments = command.Attachments,                  ArbitrationTargets = kind == "group-arbitrate" ? command.People.Where(g.Members.Contains).Where(id => PrivateMessages.CanChat(d, id)).Distinct().ToList() : [] }`
- `NationalSpire.MatchFailure.Locked(NationalSpire.CareerData)`；输入表达式：`MatchFailure.Locked(d)`；返回值紧邻使用处：`IsPatternExpressionSyntax: MatchFailure.Locked(d) is { } locked`
- `NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`；输入表达式：`PrivateMessageCommands.Apply(d, "dm-" + kind[12..], effect.Person, command.Interaction)`；返回值紧邻使用处：`ReturnStatementSyntax: return PrivateMessageCommands.Apply(d, "dm-" + kind[12..], effect.Person, command.Interaction);`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(d, effect.Person)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateMessages.CanChat(d, effect.Person)`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(d, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => PrivateMessages.CanChat(d, id)`
- `NationalSpire.PrivateSummary.IsLatest(System.Collections.Generic.IEnumerable<NationalSpire.PrivateSummary>)`；输入表达式：`summary.IsLatest(g.SmallSummaries.Concat(g.BigSummaries))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = summary.IsLatest(g.SmallSummaries.Concat(g.BigSummaries))`
- `NationalSpire.SocialAppointments.Attend(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`SocialAppointments.Attend(d, offer)`；返回值紧邻使用处：`ReturnStatementSyntax: return SocialAppointments.Attend(d, offer);`
- `NationalSpire.SocialAppointments.Confirm(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer)`；输入表达式：`SocialAppointments.Confirm(d, c, offer)`；返回值紧邻使用处：`ReturnStatementSyntax: return SocialAppointments.Confirm(d, c, offer);`
- `string.EndsWith(string)`；输入表达式：`kind.EndsWith("delete")`；返回值紧邻使用处：`IfStatementSyntax: if (kind.EndsWith("delete"))                  {                      bool latest = summary.IsLatest(g.SmallSummaries.Concat(g.BigSummaries));                      list.Remove(summary);                      // 最新总结失去覆盖时，聊天和下次总结共同恢复读取对应原文。                      if (latest && !g.SmallSummaries.Concat(g.BigSummaries).Any(s => s.From <= summary.From && s.Through >= summary.Through))                          g.SummarizedThrough = Math.Min(g.SummarizedThrough, summary.From);                  }                  else summary.Text = command.Text;`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(command.Text)`；返回值紧邻使用处：`BinaryExpressionSyntax: kind == "group-arbitrate" && string.IsNullOrWhiteSpace(command.Text)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(command.Text)`；返回值紧邻使用处：`BinaryExpressionSyntax: string.IsNullOrWhiteSpace(command.Text) && command.Attachments.Count == 0`
- `string.StartsWith(string)`；输入表达式：`kind.StartsWith("group-offer-")`；返回值紧邻使用处：`IfStatementSyntax: if (kind.StartsWith("group-offer-"))          {              var effect = g.Turns.SelectMany(t => t.Effects).LastOrDefault(e => e.Lane == command.Lane && (command.Interaction.Offer.Length == 0 || g.Interactions[e.Lane].Offers.Any(o => o.Id == command.Interaction.Offer && o.TurnId == e.Turn)));              if (effect == null) return "这项交互已不存在。";              if (effect.Human != Human(d)) return "这项交互由发起人处理。";              bool humanActivity = IsHuman(d, effect.Person);              if (!humanActivity && !PrivateMessages.CanChat(d, effect.Person)) return "该人物已经删除，这项交互不再执行。";              string? result = InLane(d, g, effect.Human, effect.Person, effect.Target, c =>              {                  if (!humanActivity) return PrivateMessageCommands.Apply(d, "dm-" + kind[12..], effect.Person, command.Interaction);                  var offer = c.Offers.FirstOrDefault(o => o.Id == command.Interaction.Offer && o.Kind == "activity");                  if (offer == null) return "活动已不存在。";                  if (kind == "group-offer-confirm") return SocialAppointments.Confirm(d, c, offer);                  if (kind == "group-offer-attend") return SocialAppointments.Attend(d, offer);                  if (kind == "group-offer-decline")                  {                      if (offer.State is not ("待确认" or "已确认")) return "这项活动已处理。";                      offer.State = "已取消"; return null;                  }                  return "活动操作无效。";              });              if (result == null && kind == "group-offer-confirm") GroupArbitration.LinkPublication(d, g, effect.Turn);              g.Revision++; return result;          }`
- `System.Collections.Generic.IEnumerable<int>.Max()`；输入表达式：`g.SmallSummaries.Concat(g.BigSummaries).Select(s => s.Through).DefaultIfEmpty(0).Max()`；返回值紧邻使用处：`AssignmentExpressionSyntax: g.SummarizedThrough = g.SmallSummaries.Concat(g.BigSummaries).Select(s => s.Through).DefaultIfEmpty(0).Max()`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Interactions[e.Lane].Offers.Any(o => o.Id == command.Interaction.Offer && o.TurnId == e.Turn)`；返回值紧邻使用处：`BinaryExpressionSyntax: command.Interaction.Offer.Length == 0 || g.Interactions[e.Lane].Offers.Any(o => o.Id == command.Interaction.Offer && o.TurnId == e.Turn)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Members.Any(id => CanSpeak(d, id))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !g.Members.Any(id => CanSpeak(d, id))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.SmallSummaries.Concat(g.BigSummaries).Any(s => s.From <= summary.From && s.Through >= summary.Through)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !g.SmallSummaries.Concat(g.BigSummaries).Any(s => s.From <= summary.From && s.Through >= summary.Through)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`g.SmallSummaries.Concat(g.BigSummaries)`；返回值紧邻使用处：`ArgumentSyntax: g.SmallSummaries.Concat(g.BigSummaries)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`g.SmallSummaries.Concat(g.BigSummaries)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.SmallSummaries.Concat(g.BigSummaries).Any`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`g.SmallSummaries.Concat(g.BigSummaries)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.SmallSummaries.Concat(g.BigSummaries).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Turns.Count(t => t.Status == "complete")`；返回值紧邻使用处：`AssignmentExpressionSyntax: g.Seen[Human(d)] = g.Turns.Count(t => t.Status == "complete")`
- `System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；输入表达式：`g.SmallSummaries.Concat(g.BigSummaries).Select(s => s.Through).DefaultIfEmpty(0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.SmallSummaries.Concat(g.BigSummaries).Select(s => s.Through).DefaultIfEmpty(0).Max`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`command.People.Where(g.Members.Contains).Where(id => PrivateMessages.CanChat(d, id)).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: command.People.Where(g.Members.Contains).Where(id => PrivateMessages.CanChat(d, id)).Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Offers.FirstOrDefault(o => o.Id == command.Interaction.Offer && o.Kind == "activity")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Offers.FirstOrDefault(o => o.Id == command.Interaction.Offer && o.Kind == "activity")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`list.FirstOrDefault(s => s.Id == command.Interaction.Entry)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = list.FirstOrDefault(s => s.Id == command.Interaction.Entry)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`Visible(d).FirstOrDefault(g => g.Id == id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Visible(d).FirstOrDefault(g => g.Id == id)`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`g.Turns.LastOrDefault()`；返回值紧邻使用处：`IsPatternExpressionSyntax: g.Turns.LastOrDefault() is not { Status: "complete" } last`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`g.Turns.LastOrDefault()`；返回值紧邻使用处：`IsPatternExpressionSyntax: g.Turns.LastOrDefault() is not { Status: "failed" } failed`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Turns.SelectMany(t => t.Effects).LastOrDefault(e => e.Lane == command.Lane && (command.Interaction.Offer.Length == 0 || g.Interactions[e.Lane].Offers.Any(o => o.Id == command.Interaction.Offer && o.TurnId == e.Turn)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = g.Turns.SelectMany(t => t.Effects).LastOrDefault(e => e.Lane == command.Lane && (command.Interaction.Offer.Length == 0 || g.Interactions[e.Lane].Offers.Any(o => o.Id == command.Interaction.Offer && o.TurnId == e.Turn)))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`g.SmallSummaries.Concat(g.BigSummaries).Select(s => s.Through)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.SmallSummaries.Concat(g.BigSummaries).Select(s => s.Through).DefaultIfEmpty`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`g.Turns.SelectMany(t => t.Effects)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Turns.SelectMany(t => t.Effects).LastOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`probe.Chats.Groups.Single(x => x.Id == g.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = probe.Chats.Groups.Single(x => x.Id == g.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`command.People.Where(g.Members.Contains).Where(id => PrivateMessages.CanChat(d, id)).Distinct().ToList()`；返回值紧邻使用处：`ConditionalExpressionSyntax: kind == "group-arbitrate" ? command.People.Where(g.Members.Contains).Where(id => PrivateMessages.CanChat(d, id)).Distinct().ToList() : []`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`command.People.Where(g.Members.Contains).Where(id => PrivateMessages.CanChat(d, id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: command.People.Where(g.Members.Contains).Where(id => PrivateMessages.CanChat(d, id)).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`command.People.Where(g.Members.Contains)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: command.People.Where(g.Members.Contains).Where`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`g.Turns.Add(t)`；返回值紧邻使用处：`ExpressionStatementSyntax: g.Turns.Add(t);`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`failed.Replies.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: failed.Replies.Clear();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`failed.SpeechOrders.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: failed.SpeechOrders.Clear();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`last.Replies.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: last.Replies.Clear();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`last.SpeechOrders.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: last.SpeechOrders.Clear();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`t.Attachments.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: t.Attachments.Clear();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`t.Replies.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: t.Replies.Clear();`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`list.Remove(summary)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.Remove(summary);`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`g.BigSummaries.RemoveAll(s => s.Through > at)`；返回值紧邻使用处：`ExpressionStatementSyntax: g.BigSummaries.RemoveAll(s => s.Through > at);`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`g.SmallSummaries.RemoveAll(s => s.Through > at)`；返回值紧邻使用处：`ExpressionStatementSyntax: g.SmallSummaries.RemoveAll(s => s.Through > at);`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(g.SummarizedThrough, summary.From)`；返回值紧邻使用处：`AssignmentExpressionSyntax: g.SummarizedThrough = Math.Min(g.SummarizedThrough, summary.From)`

**赋值（含属性/字段和局部值）：**

- `a.CoachAccepted` = `false`
- `a.GroupId` = `g.Id`
- `a.Id` = `(++g.LastInteractionNumber).ToString()`
- `ArbitrationTargets` = `kind == "group-arbitrate" ? command.People.Where(g.Members.Contains).Where(id => PrivateMessages.CanChat(d, id)).Distinct().ToList() : []`
- `attachment.CoachAccepted` = `false`
- `Attachments` = `command.Attachments`
- `command.Text` = `"申请尖塔仲裁，请审理本群往来及此前裁决的履行情况。"`
- `Day` = `d.Day`
- `failed.Error` = `failed.Reasoning = ""`
- `failed.Raw` = `failed.Error = failed.Reasoning = ""`
- `failed.Reasoning` = `""`
- `failed.Status` = `"queued"`
- `g.Seen[Human(d)]` = `g.Turns.Count(t => t.Status == "complete")`
- `g.Settings` = `settings`
- `g.SummarizedThrough` = `g.SmallSummaries.Concat(g.BigSummaries).Select(s => s.Through).DefaultIfEmpty(0).Max()`
- `g.SummarizedThrough` = `Math.Min(g.SummarizedThrough, summary.From)`
- `last.Error` = `last.Reasoning = ""`
- `last.Raw` = `last.Error = last.Reasoning = ""`
- `last.Reasoning` = `""`
- `last.Status` = `"queued"`
- `offer.State` = `"已取消"`
- `Order` = `NextOrder(d)`
- `Sender` = `Human(d)`
- `summary.Text` = `command.Text`
- `t.Raw` = `t.Reasoning = ""`
- `t.Reasoning` = `""`
- `t.Status` = `"complete"`
- `t.Text` = `""`
- `Text` = `command.Text`

<a id="symbol-d45d31e160a9"></a>

## `NationalSpire.GroupChats.Rewind(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn) — private static string? Rewind(CareerData d, GroupChat g, GroupTurn t)`

来源：源码第 159 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`](GroupChats.cs.md#symbol-e0439deb45ac)

**调用：** [`NationalSpire.GroupChats.InLane<T>(NationalSpire.CareerData, NationalSpire.GroupChat, string, string, string, System.Func<NationalSpire.PrivateConversation, T>)`](GroupChats.cs.md#symbol-167e5090d91a)；[`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-24bc82bdbbd4)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；[`NationalSpire.PrivateInteractionHistory.Rewind(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn)`](PrivateInteractionUndo.cs.md#symbol-f2cc1906a6b6)；[`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；`System.Collections.Generic.List<T>.Clear()`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.GroupChat.Interactions`；`NationalSpire.GroupChats.InLane<T>(NationalSpire.CareerData, NationalSpire.GroupChat, string, string, string, System.Func<NationalSpire.PrivateConversation, T>)`；`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.GroupEffect.Human`；`NationalSpire.GroupEffect.Person`；`NationalSpire.GroupEffect.Target`；`NationalSpire.GroupEffect.Turn`；`NationalSpire.GroupTurn.Effects`；`NationalSpire.GroupTurn.Notices`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateInteractionHistory.Rewind(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn)`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；`NationalSpire.PrivateTurn.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChats.InLane<T>(NationalSpire.CareerData, NationalSpire.GroupChat, string, string, string, System.Func<NationalSpire.PrivateConversation, T>)`；输入表达式：`InLane(d, g, effect.Human, effect.Person, effect.Target, c =>              {                  var turn = c.Turns.FirstOrDefault(x => x.Id == effect.Turn);                  return turn == null ? null : PrivateInteractionHistory.Rewind(d, c, turn);              })`；返回值紧邻使用处：`EqualsValueClauseSyntax: = InLane(d, g, effect.Human, effect.Person, effect.Target, c =>              {                  var turn = c.Turns.FirstOrDefault(x => x.Id == effect.Turn);                  return turn == null ? null : PrivateInteractionHistory.Rewind(d, c, turn);              })`
- `NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`IsHuman(d, effect.Person)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsHuman(d, effect.Person)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`Name(d, effect.Person)`；返回值紧邻使用处：`BinaryExpressionSyntax: Name(d, effect.Person) + "："`
- `NationalSpire.PrivateInteractionHistory.Rewind(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn)`；输入表达式：`PrivateInteractionHistory.Rewind(d, c, turn)`；返回值紧邻使用处：`ConditionalExpressionSyntax: turn == null ? null : PrivateInteractionHistory.Rewind(d, c, turn)`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(d, effect.Person)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateMessages.CanChat(d, effect.Person)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`t.Effects.Any(e => e.Turn == x.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: x => t.Effects.Any(e => e.Turn == x.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；输入表达式：`t.Effects.AsEnumerable()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: t.Effects.AsEnumerable().Reverse`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.FirstOrDefault(x => x.Id == effect.Turn)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Turns.FirstOrDefault(x => x.Id == effect.Turn)`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`t.Effects.AsEnumerable().Reverse()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var effect in t.Effects.AsEnumerable().Reverse())          {              if (!IsHuman(d, effect.Person) && !PrivateMessages.CanChat(d, effect.Person)) continue;              string? error = InLane(d, g, effect.Human, effect.Person, effect.Target, c =>              {                  var turn = c.Turns.FirstOrDefault(x => x.Id == effect.Turn);                  return turn == null ? null : PrivateInteractionHistory.Rewind(d, c, turn);              });              if (error != null) return Name(d, effect.Person) + "：" + error;          }`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`t.Effects.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: t.Effects.Clear();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`t.Notices.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: t.Notices.Clear();`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`c.Turns.RemoveAll(x => t.Effects.Any(e => e.Turn == x.Id))`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Turns.RemoveAll(x => t.Effects.Any(e => e.Turn == x.Id));`

**赋值（含属性/字段和局部值）：**


<a id="symbol-76ad48e0a3a3"></a>

## `NationalSpire.GroupChats.PreviewCopy(NationalSpire.CareerData) — internal static CareerData PreviewCopy(CareerData d)`

来源：源码第 174 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupArbitration.Apply(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn, string)`](GroupArbitration.cs.md#symbol-112723169c3a)；[`NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`](GroupChats.cs.md#symbol-e0439deb45ac)

**调用：** [`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.AvatarWorldId`；`NationalSpire.CareerData.ExternalCurrent`；`NationalSpire.CareerData.ExternalSave`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerData.PrivateMemorySources`；`NationalSpire.CareerLifeState.Mailbox`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`Human(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: x.Key == Human(d)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`d.PrivateMemorySources.ToDictionary(x => x.Key, x => x.Key == Human(d) ? copy.Life.Mailbox : JsonSerializer.Deserialize<PrivateMailbox>(JsonSerializer.Serialize(x.Value))!)`；返回值紧邻使用处：`AssignmentExpressionSyntax: copy.PrivateMemorySources = d.PrivateMemorySources.ToDictionary(x => x.Key, x => x.Key == Human(d) ? copy.Life.Mailbox : JsonSerializer.Deserialize<PrivateMailbox>(JsonSerializer.Serialize(x.Value))!)`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<CareerData>(JsonSerializer.Serialize(d))`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: JsonSerializer.Deserialize<CareerData>(JsonSerializer.Serialize(d))!`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<PrivateMailbox>(JsonSerializer.Serialize(x.Value))`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: JsonSerializer.Deserialize<PrivateMailbox>(JsonSerializer.Serialize(x.Value))!`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(d)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(d)`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(x.Value)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(x.Value)`

**赋值（含属性/字段和局部值）：**

- `copy.AvatarWorldId` = `d.AvatarWorldId`
- `copy.ExternalCurrent` = `() => false`
- `copy.ExternalSave` = `_ => { }`
- `copy.LocalHumanId` = `d.LocalHumanId`
- `copy.PrivateMemorySources` = `d.PrivateMemorySources.ToDictionary(x => x.Key, x => x.Key == Human(d) ? copy.Life.Mailbox : JsonSerializer.Deserialize<PrivateMailbox>(JsonSerializer.Serialize(x.Value))!)`

<a id="symbol-01d7b7cae92b"></a>

## `NationalSpire.GroupChats.Recover(NationalSpire.CareerData) — public static void Recover(CareerData d)`

来源：源码第 182 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerStore.Data`](CareerStore.cs.md#symbol-9724f0dac935)；[`NationalSpire.Coop.CoopCoordinator.CoopCoordinator(NationalSpire.Coop.ICoopTransport, NationalSpire.Coop.CoopStorage, string, string, string, System.Collections.Generic.IReadOnlySet<string>, NationalSpire.Coop.CoopStorage.Checkpoint?)`](Coop/CoopCoordinator.cs.md#symbol-778097f34ec3)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.GroupChat.SummaryStatus`；`NationalSpire.GroupChat.Turns`；`NationalSpire.GroupTurn.Error`；`NationalSpire.GroupTurn.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Turns.Where(t => t.Status is "queued" or "sending")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var t in g.Turns.Where(t => t.Status is "queued" or "sending")) { t.Status = "failed"; t.Error = "上次回复中断，可以重试。"; }`

**赋值（含属性/字段和局部值）：**

- `g.SummaryStatus` = `""`
- `t.Error` = `"上次回复中断，可以重试。"`
- `t.Status` = `"failed"`

<a id="symbol-7bed226ca03c"></a>

## `NationalSpire.GroupChats.Deleted(NationalSpire.CareerData, string) — public static void Deleted(CareerData d, string person)`

来源：源码第 190 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterDeletion.Delete(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-2eb70f838afa)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.Remove(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.GroupChat.Interactions`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupChat.Revision`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateOffer.ActorId`；`NationalSpire.PrivateOffer.Participants`；`NationalSpire.PrivateOffer.State`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`g.Interactions.Values.SelectMany(c => c.Offers)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Interactions.Values.SelectMany(c => c.Offers).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Chats.Groups.Where(g => g.Members.Contains(person))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var g in d.Chats.Groups.Where(g => g.Members.Contains(person)))          {              g.Members.Remove(person); g.Revision++;              foreach (var offer in g.Interactions.Values.SelectMany(c => c.Offers).Where(o => o.State == "待确认" && (o.ActorId == person || o.Participants.Contains(person)))) offer.State = "已取消";          }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Interactions.Values.SelectMany(c => c.Offers).Where(o => o.State == "待确认" && (o.ActorId == person || o.Participants.Contains(person)))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var offer in g.Interactions.Values.SelectMany(c => c.Offers).Where(o => o.State == "待确认" && (o.ActorId == person || o.Participants.Contains(person)))) offer.State = "已取消";`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`g.Members.Contains(person)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.Members.Contains(person)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`o.Participants.Contains(person)`；返回值紧邻使用处：`BinaryExpressionSyntax: o.ActorId == person || o.Participants.Contains(person)`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`g.Members.Remove(person)`；返回值紧邻使用处：`ExpressionStatementSyntax: g.Members.Remove(person);`

**赋值（含属性/字段和局部值）：**

- `offer.State` = `"已取消"`
