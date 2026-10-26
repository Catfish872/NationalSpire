# GroupChatScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`5CD3EF44AD92BE51267B589ABCF87F23262575539FB5960C5CA4AEC2FAB85FA3`。来源：[源码](../../GroupChatScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private string _privateGroup = "", _chatFilter = "全部", _groupSignature = "", _groupError = "";
private string _groupCreateName = "新群聊";
private GroupStreamParser? _groupStreamParser;
private string _groupStreamRaw = "", _groupStreamThought = "";
private Action<string>? _groupReasoningUpdate;
private readonly List<RichTextLabel?> _groupStreamLabels = [];
```

<a id="symbol-e46034c2081a"></a>

## `NationalSpire.CareerScreen.ChatDraftKey — private string ChatDraftKey`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privatePerson`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-faa5c0bdf649"></a>

## `NationalSpire.CareerScreen.CurrentGroup — private GroupChat? CurrentGroup`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.GroupChat.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`ViewData.Chats.Groups.FirstOrDefault(g => g.Id == _privateGroup)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ViewData.Chats.Groups.FirstOrDefault(g => g.Id == _privateGroup)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-88d7619ce50a"></a>

## `NationalSpire.CareerScreen.GroupSidebar(Godot.VBoxContainer) — private void GroupSidebar(VBoxContainer sidebar)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)

**调用：** `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；[`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.CareerScreen.GroupMemberPicker(NationalSpire.GroupChat?, System.Action<System.Collections.Generic.List<string>>, bool, string, bool, bool)`](GroupChatScreen.cs.md#symbol-26ccde004356)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.RefreshPrivateList()`](PrivateMessageScreen.cs.md#symbol-fca825e025fa)；`NationalSpire.GroupCommand.GroupCommand()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；`NationalSpire.CareerScreen.GroupMemberPicker(NationalSpire.GroupChat?, System.Action<System.Collections.Generic.List<string>>, bool, string, bool, bool)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.RefreshPrivateList()`；`NationalSpire.CareerScreen._chatFilter`；`NationalSpire.CareerScreen._groupCreateName`；`NationalSpire.CareerScreen._privateListSignature`；`NationalSpire.GroupCommand.People`；`NationalSpire.GroupCommand.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 6)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 6);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateButton("＋", () => GroupMemberPicker(null, people => GroupCommand("group-create", new() { People = people, Text = _groupCreateName })), 42))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateButton("＋", () => GroupMemberPicker(null, people => GroupCommand("group-create", new() { People = people, Text = _groupCreateName })), 42));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(b)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(b);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`sidebar.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: sidebar.AddChild(row);`
- `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；输入表达式：`GroupCommand("group-create", new() { People = people, Text = _groupCreateName })`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: people => GroupCommand("group-create", new() { People = people, Text = _groupCreateName })`
- `NationalSpire.CareerScreen.GroupMemberPicker(NationalSpire.GroupChat?, System.Action<System.Collections.Generic.List<string>>, bool, string, bool, bool)`；输入表达式：`GroupMemberPicker(null, people => GroupCommand("group-create", new() { People = people, Text = _groupCreateName }))`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GroupMemberPicker(null, people => GroupCommand("group-create", new() { People = people, Text = _groupCreateName }))`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("＋", () => GroupMemberPicker(null, people => GroupCommand("group-create", new() { People = people, Text = _groupCreateName })), 42)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("＋", () => GroupMemberPicker(null, people => GroupCommand("group-create", new() { People = people, Text = _groupCreateName })), 42)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton(filter, () => { _chatFilter = filter; _privateListSignature = ""; RefreshPrivateList(); }, 68)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton(filter, () => { _chatFilter = filter; _privateListSignature = ""; RefreshPrivateList(); }, 68)`
- `NationalSpire.CareerScreen.RefreshPrivateList()`；输入表达式：`RefreshPrivateList()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPrivateList();`
- `NationalSpire.GroupCommand.GroupCommand()`；输入表达式：`new() { People = people, Text = _groupCreateName }`；返回值紧邻使用处：`ArgumentSyntax: new() { People = people, Text = _groupCreateName }`

**赋值（含属性/字段和局部值）：**

- `People` = `people`
- `Text` = `_groupCreateName`
- `_chatFilter` = `filter`
- `_privateListSignature` = `""`
- `b.Name` = `"ChatFilter" + filter`

<a id="symbol-1eb7b9a65ede"></a>

## `NationalSpire.CareerScreen.OpenGroupPerson(string) — private void OpenGroupPerson(string person)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.GroupBubble(string, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>?)`](GroupChatScreen.cs.md#symbol-870e7cca58c0)

**调用：** [`NationalSpire.CareerScreen.CaptureLocation()`](CareerNavigation.cs.md#symbol-67f7f7696f8a)；[`NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool)`](PrivateMessageScreen.cs.md#symbol-db8b0a9ff8de)；[`NationalSpire.CareerScreen.UpdateNavigation()`](CareerNavigation.cs.md#symbol-a6094a69b6d7)；[`NationalSpire.CareerScreen.Visit(System.Action)`](CareerNavigation.cs.md#symbol-d49752019228)；`System.Collections.Generic.Stack<T>.Pop()`；`System.Collections.Generic.Stack<T>.Push(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._backHistory`；`NationalSpire.CareerScreen._personId`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privateScroll`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen.CaptureLocation()`；`NationalSpire.CareerScreen.ChatPage`；`NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool)`；`NationalSpire.CareerScreen.Location.ChatPage`；`NationalSpire.CareerScreen.Location.ChatScroll`；`NationalSpire.CareerScreen.Location.Group`；`NationalSpire.CareerScreen.UpdateNavigation()`；`NationalSpire.CareerScreen.Visit(System.Action)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.CaptureLocation()`；输入表达式：`CaptureLocation()`；返回值紧邻使用处：`WithExpressionSyntax: CaptureLocation() with { Group = _privateGroup, ChatScroll = _privateScroll!.ScrollVertical, ChatPage = ChatPage }`
- `NationalSpire.CareerScreen.ClosePrivateMessagesCore(bool)`；输入表达式：`ClosePrivateMessagesCore(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClosePrivateMessagesCore(false);`
- `NationalSpire.CareerScreen.UpdateNavigation()`；输入表达式：`UpdateNavigation()`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateNavigation();`
- `NationalSpire.CareerScreen.Visit(System.Action)`；输入表达式：`Visit(() => { _tab = "选手档案"; _personId = person; })`；返回值紧邻使用处：`ExpressionStatementSyntax: Visit(() => { _tab = "选手档案"; _personId = person; });`
- `System.Collections.Generic.Stack<T>.Pop()`；输入表达式：`_backHistory.Pop()`；返回值紧邻使用处：`ExpressionStatementSyntax: _backHistory.Pop();`
- `System.Collections.Generic.Stack<T>.Push(T)`；输入表达式：`_backHistory.Push(previous)`；返回值紧邻使用处：`ExpressionStatementSyntax: _backHistory.Push(previous);`

**赋值（含属性/字段和局部值）：**

- `_personId` = `person`
- `_tab` = `"选手档案"`
- `ChatPage` = `ChatPage`
- `ChatScroll` = `_privateScroll!.ScrollVertical`
- `Group` = `_privateGroup`

<a id="symbol-b8810762e549"></a>

## `NationalSpire.CareerScreen.RestoreGroupScroll(string, int) — private Task RestoreGroupScroll(string group, int position)`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Back()`](CareerNavigation.cs.md#symbol-08af62207fef)

**调用：** [`NationalSpire.CareerScreen.ScrollChatTo(int)`](ChatHistoryScreen.cs.md#symbol-b728511cec65)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen.ScrollChatTo(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.ScrollChatTo(int)`；输入表达式：`ScrollChatTo(position)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _privateGroup == group ? ScrollChatTo(position) : Task.CompletedTask`

**赋值（含属性/字段和局部值）：**


<a id="symbol-72d02215d0db"></a>

## `NationalSpire.CareerScreen.SelectGroup(string, int) — private void SelectGroup(string id, int page = -1)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Back()`](CareerNavigation.cs.md#symbol-08af62207fef)；[`NationalSpire.CareerScreen.ChatMenuItems(string, bool)`](ChatManagementScreen.cs.md#symbol-99485204d7d6)；[`NationalSpire.CareerScreen.CreatePrivateListRow()`](PrivateListRows.cs.md#symbol-ae3a09702cbd)；[`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.RestoreChatDialog()`](ChatManagementScreen.cs.md#symbol-812702bacb1e)；[`Open(System.Action)`](ChatManagementScreen.cs.md#symbol-f889b0a7e3d1)

**调用：** [`NationalSpire.CareerScreen.BindChatPage(bool)`](ChatHistoryScreen.cs.md#symbol-e22063fef4cb)；[`NationalSpire.CareerScreen.InvalidateChatPage(int)`](ChatHistoryScreen.cs.md#symbol-110069df9a95)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.CareerScreen.RefreshPrivateAttachments()`](PrivateMemoryScreen.cs.md#symbol-b9d6c2084031)；[`NationalSpire.CareerScreen.RefreshPrivateList()`](PrivateMessageScreen.cs.md#symbol-fca825e025fa)；[`NationalSpire.CareerScreen.ResetChatPage()`](ChatHistoryScreen.cs.md#symbol-0a8a3b0ae98b)；[`NationalSpire.CareerScreen.SaveChatPreferences()`](ChatHistoryScreen.cs.md#symbol-614208ed0b0d)；[`NationalSpire.ChatHistoryPage<T>.Move(int)`](ChatHistoryPage.cs.md#symbol-27c362fe5d02)；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._groupError`；`NationalSpire.CareerScreen._groupPages`；`NationalSpire.CareerScreen._groupSignature`；`NationalSpire.CareerScreen._privateDrafts`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privateInput`；`NationalSpire.CareerScreen._privateListSignature`；`NationalSpire.CareerScreen._privateOverlay`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen.BindChatPage(bool)`；`NationalSpire.CareerScreen.ChatDraftKey`；`NationalSpire.CareerScreen.InvalidateChatPage(int)`；`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；`NationalSpire.CareerScreen.RefreshGroupChat()`；`NationalSpire.CareerScreen.RefreshPrivateAttachments()`；`NationalSpire.CareerScreen.RefreshPrivateList()`；`NationalSpire.CareerScreen.ResetChatPage()`；`NationalSpire.CareerScreen.SaveChatPreferences()`；`NationalSpire.ChatHistoryPage<T>.Move(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.BindChatPage(bool)`；输入表达式：`BindChatPage(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: BindChatPage(true);`
- `NationalSpire.CareerScreen.InvalidateChatPage(int)`；输入表达式：`InvalidateChatPage(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: InvalidateChatPage(0);`
- `NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；输入表达式：`OpenPrivateMessages(group: id, page: page)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenPrivateMessages(group: id, page: page);`
- `NationalSpire.CareerScreen.RefreshGroupChat()`；输入表达式：`RefreshGroupChat()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshGroupChat();`
- `NationalSpire.CareerScreen.RefreshPrivateAttachments()`；输入表达式：`RefreshPrivateAttachments()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPrivateAttachments();`
- `NationalSpire.CareerScreen.RefreshPrivateList()`；输入表达式：`RefreshPrivateList()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPrivateList();`
- `NationalSpire.CareerScreen.ResetChatPage()`；输入表达式：`ResetChatPage()`；返回值紧邻使用处：`ExpressionStatementSyntax: ResetChatPage();`
- `NationalSpire.CareerScreen.SaveChatPreferences()`；输入表达式：`SaveChatPreferences()`；返回值紧邻使用处：`ExpressionStatementSyntax: SaveChatPreferences();`
- `NationalSpire.ChatHistoryPage<T>.Move(int)`；输入表达式：`_groupPages.Move(page)`；返回值紧邻使用处：`ExpressionStatementSyntax: _groupPages.Move(page);`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`_privateDrafts.GetValueOrDefault(ChatDraftKey, "")`；返回值紧邻使用处：`AssignmentExpressionSyntax: _privateInput!.Text = _privateDrafts.GetValueOrDefault(ChatDraftKey, "")`

**赋值（含属性/字段和局部值）：**

- `_groupError` = `""`
- `_groupSignature` = `_privateListSignature = _groupError = ""`
- `_privateDrafts[ChatDraftKey]` = `_privateInput.Text`
- `_privateGroup` = `id`
- `_privateInput!.Text` = `_privateDrafts.GetValueOrDefault(ChatDraftKey, "")`
- `_privateListSignature` = `_groupError = ""`
- `_privatePerson` = `""`

<a id="symbol-c33de3d8ae73"></a>

## `NationalSpire.CareerScreen.UpdateGroupStream(NationalSpire.GroupChat, string, string) — private void UpdateGroupStream(GroupChat g, string live, string thought)`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)

**调用：** [`NationalSpire.CareerScreen.GroupBubble(string, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>?)`](GroupChatScreen.cs.md#symbol-870e7cca58c0)；[`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.CareerScreen.ScrollPrivateToBottom()`](PrivateMessageScreen.cs.md#symbol-b2deefc4ba01)；[`NationalSpire.GroupChat.Resolve(string)`](GroupChatData.cs.md#symbol-970525ff4872)；[`NationalSpire.GroupChats.SpeechUnavailable(NationalSpire.CareerData, NationalSpire.GroupChat, string)`](GroupChats.cs.md#symbol-77b18ea82814)；[`NationalSpire.GroupStreamParser.Feed(string)`](GroupStreamParser.cs.md#symbol-9d7375d651fe)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；`Godot.ScrollContainer.GetVScrollBar()`；`string.StartsWith(string, System.StringComparison)`；`string.Trim()`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Collections.Generic.List<T>.Add(T)`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._groupReasoningUpdate`；`NationalSpire.CareerScreen._groupSignature`；`NationalSpire.CareerScreen._groupStreamLabels`；`NationalSpire.CareerScreen._groupStreamParser`；`NationalSpire.CareerScreen._groupStreamRaw`；`NationalSpire.CareerScreen._groupStreamThought`；`NationalSpire.CareerScreen._privateScroll`；`NationalSpire.CareerScreen.ChatAtLatest`；`NationalSpire.CareerScreen.GroupBubble(string, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>?)`；`NationalSpire.CareerScreen.RefreshGroupChat()`；`NationalSpire.CareerScreen.ScrollPrivateToBottom()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.GroupChat.Resolve(string)`；`NationalSpire.GroupChats.SpeechUnavailable(NationalSpire.CareerData, NationalSpire.GroupChat, string)`；`NationalSpire.GroupStreamParser.Feed(string)`；`NationalSpire.GroupStreamParser.Messages`；`NationalSpire.GroupStreamParser.Speech.Author`；`NationalSpire.GroupStreamParser.Speech.Body`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.GroupRender`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ScrollContainer.GetVScrollBar()`；输入表达式：`_privateScroll.GetVScrollBar()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _privateScroll.GetVScrollBar().MaxValue`
- `NationalSpire.CareerScreen.GroupBubble(string, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>?)`；输入表达式：`GroupBubble(person, text)`；返回值紧邻使用处：`ConditionalExpressionSyntax: GroupChats.SpeechUnavailable(ViewData, g, person).Length == 0 ? GroupBubble(person, text) : null`
- `NationalSpire.CareerScreen.RefreshGroupChat()`；输入表达式：`RefreshGroupChat()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshGroupChat();`
- `NationalSpire.CareerScreen.ScrollPrivateToBottom()`；输入表达式：`ScrollPrivateToBottom()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = ScrollPrivateToBottom()`
- `NationalSpire.GroupChat.Resolve(string)`；输入表达式：`g.Resolve(speech.Author)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = g.Resolve(speech.Author)`
- `NationalSpire.GroupChats.SpeechUnavailable(NationalSpire.CareerData, NationalSpire.GroupChat, string)`；输入表达式：`GroupChats.SpeechUnavailable(ViewData, g, person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GroupChats.SpeechUnavailable(ViewData, g, person).Length`
- `NationalSpire.GroupStreamParser.Feed(string)`；输入表达式：`_groupStreamParser.Feed(live[_groupStreamRaw.Length..])`；返回值紧邻使用处：`ExpressionStatementSyntax: _groupStreamParser.Feed(live[_groupStreamRaw.Length..]);`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.GroupRender, "通讯")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.GroupRender, "通讯")`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`live.StartsWith(_groupStreamRaw, StringComparison.Ordinal)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !live.StartsWith(_groupStreamRaw, StringComparison.Ordinal)`
- `string.Trim()`；输入表达式：`speech.Body.ToString().Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = speech.Body.ToString().Trim()`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(thought)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _groupReasoningUpdate?.Invoke(thought)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`_groupStreamLabels.Add(GroupChats.SpeechUnavailable(ViewData, g, person).Length == 0 ? GroupBubble(person, text) : null)`；返回值紧邻使用处：`ExpressionStatementSyntax: _groupStreamLabels.Add(GroupChats.SpeechUnavailable(ViewData, g, person).Length == 0 ? GroupBubble(person, text) : null);`
- `System.Text.StringBuilder.ToString()`；输入表达式：`speech.Body.ToString()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: speech.Body.ToString().Trim`

**赋值（含属性/字段和局部值）：**

- `_` = `ScrollPrivateToBottom()`
- `_groupSignature` = `""`
- `_groupStreamRaw` = `live`
- `_groupStreamThought` = `thought`
- `label.Text` = `text`

<a id="symbol-b56fe79b2db7"></a>

## `NationalSpire.CareerScreen.RefreshGroupChat() — private void RefreshGroupChat()`

来源：源码第 64 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)；[`NationalSpire.CareerScreen.SelectGroup(string, int)`](GroupChatScreen.cs.md#symbol-72d02215d0db)；[`NationalSpire.CareerScreen.UpdateGroupStream(NationalSpire.GroupChat, string, string)`](GroupChatScreen.cs.md#symbol-c33de3d8ae73)

**调用：** [`NationalSpire.AiService.GroupKey(NationalSpire.CareerData, string)`](AiGroupChats.cs.md#symbol-ed8efb8958b5)；[`NationalSpire.CareerScreen.AddChatReasoning(string, string)`](PrivateMemoryScreen.cs.md#symbol-fdbe84837533)；[`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`](CareerAvatars.cs.md#symbol-9f2c4623a902)；[`NationalSpire.CareerScreen.BindChatPage(bool)`](ChatHistoryScreen.cs.md#symbol-e22063fef4cb)；[`NationalSpire.CareerScreen.FinishChatPage(bool)`](ChatHistoryScreen.cs.md#symbol-7519bc2ca961)；[`NationalSpire.CareerScreen.GroupBubble(string, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>?)`](GroupChatScreen.cs.md#symbol-870e7cca58c0)；[`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`](GroupChatScreen.cs.md#symbol-3afa41099b93)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-84294149ff91)；[`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`](PrivateMessageScreen.cs.md#symbol-fb5e88f4639a)；[`NationalSpire.CareerScreen.TrainingCompletions(System.Collections.Generic.IEnumerable<NationalSpire.PrivateOffer>, long, long)`](CoachScreen.cs.md#symbol-c316f7a67f3e)；[`NationalSpire.CareerScreen.TrainingCompletionsThrough(System.Collections.Generic.Queue<NationalSpire.CoachTrainingPlan>, long)`](CoachScreen.cs.md#symbol-9deab8f6abda)；[`NationalSpire.CareerScreen.UpdateGroupStream(NationalSpire.GroupChat, string, string)`](GroupChatScreen.cs.md#symbol-c33de3d8ae73)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)；[`NationalSpire.GroupChat.Resolve(string)`](GroupChatData.cs.md#symbol-970525ff4872)；[`NationalSpire.GroupChats.Busy(NationalSpire.GroupChat)`](GroupChats.cs.md#symbol-85bf6e1105fe)；[`NationalSpire.GroupChats.CanSpeak(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-bc138d545f34)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；[`NationalSpire.GroupChats.SpeechUnavailable(NationalSpire.CareerData, NationalSpire.GroupChat, string)`](GroupChats.cs.md#symbol-77b18ea82814)；[`NationalSpire.GroupStreamParser.Feed(string)`](GroupStreamParser.cs.md#symbol-9d7375d651fe)；[`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`](PrivateAppointments.cs.md#symbol-1c549626b284)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](UiPerformance.cs.md#symbol-fb8ca8555fbe)；[`NoticesThrough(long)`](GroupChatScreen.cs.md#symbol-cfcadd7edb2e)；`Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.ScrollContainer.GetVScrollBar()`；`Godot.VBoxContainer.VBoxContainer()`；`NationalSpire.GroupCommand.GroupCommand()`；`NationalSpire.GroupStreamParser.GroupStreamParser()`；`string.Contains(string)`；`string.Join<T>(string?, System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Clear()`；`System.Collections.Generic.Queue<T>.Queue(System.Collections.Generic.IEnumerable<T>)`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `(long Order, NationalSpire.GroupEntry Notice, NationalSpire.GroupTurn Turn).Notice`；`(long Order, NationalSpire.GroupEntry Notice, NationalSpire.GroupTurn Turn).Order`；`(long Order, NationalSpire.GroupEntry Notice, NationalSpire.GroupTurn Turn).Turn`；`(string Turn, string Text).Text`；`(string Turn, string Text).Turn`；`NationalSpire.AiService.GroupKey(NationalSpire.CareerData, string)`；`NationalSpire.AiService.GroupLive`；`NationalSpire.AiService.GroupReasoningLive`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._groupError`；`NationalSpire.CareerScreen._groupPages`；`NationalSpire.CareerScreen._groupReasoningUpdate`；`NationalSpire.CareerScreen._groupSignature`；`NationalSpire.CareerScreen._groupStreamLabels`；`NationalSpire.CareerScreen._groupStreamParser`；`NationalSpire.CareerScreen._groupStreamRaw`；`NationalSpire.CareerScreen._groupStreamThought`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privateBody`；`NationalSpire.CareerScreen._privateHeading`；`NationalSpire.CareerScreen._privateScroll`；`NationalSpire.CareerScreen._privateSend`；`NationalSpire.CareerScreen._privateStatus`；`NationalSpire.CareerScreen.AddChatReasoning(string, string)`；`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；`NationalSpire.CareerScreen.BindChatPage(bool)`；`NationalSpire.CareerScreen.ChatAtBottom`；`NationalSpire.CareerScreen.ChatAtLatest`；`NationalSpire.CareerScreen.CurrentGroup`；`NationalSpire.CareerScreen.FinishChatPage(bool)`；`NationalSpire.CareerScreen.GroupBubble(string, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>?)`；`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；`NationalSpire.CareerScreen.TrainingCompletions(System.Collections.Generic.IEnumerable<NationalSpire.PrivateOffer>, long, long)`；`NationalSpire.CareerScreen.TrainingCompletionsThrough(System.Collections.Generic.Queue<NationalSpire.CoachTrainingPlan>, long)`；`NationalSpire.CareerScreen.UpdateGroupStream(NationalSpire.GroupChat, string, string)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.ChatHistoryPage<T>.Count`；`NationalSpire.ChatHistoryPage<T>.Next`；`NationalSpire.ChatHistoryPage<T>.Page`；`NationalSpire.ChatHistoryPage<T>.Size`；`NationalSpire.ChatHistoryPage<T>.Visible`；`NationalSpire.GroupChat.Entries`；`NationalSpire.GroupChat.Forgotten`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Interactions`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupChat.Name`；`NationalSpire.GroupChat.Resolve(string)`；`NationalSpire.GroupChat.Revision`；`NationalSpire.GroupChat.Seen`；`NationalSpire.GroupChat.SummaryError`；`NationalSpire.GroupChat.SummaryStatus`；`NationalSpire.GroupChat.Turns`；`NationalSpire.GroupChats.Busy(NationalSpire.GroupChat)`；`NationalSpire.GroupChats.CanSpeak(NationalSpire.CareerData, string)`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.GroupChats.SpeechUnavailable(NationalSpire.CareerData, NationalSpire.GroupChat, string)`；`NationalSpire.GroupEffect.Lane`；`NationalSpire.GroupEffect.Person`；`NationalSpire.GroupEffect.Text`；`NationalSpire.GroupEffect.Turn`；`NationalSpire.GroupEntry.Author`；`NationalSpire.GroupEntry.Order`；`NationalSpire.GroupEntry.Text`；`NationalSpire.GroupStreamParser.Feed(string)`；`NationalSpire.GroupStreamParser.Messages`；`NationalSpire.GroupStreamParser.Speech.Author`；`NationalSpire.GroupStreamParser.Speech.Body`；`NationalSpire.GroupTurn.ArbitrationTargets`；`NationalSpire.GroupTurn.Attachments`；`NationalSpire.GroupTurn.Day`；`NationalSpire.GroupTurn.Effects`；`NationalSpire.GroupTurn.Error`；`NationalSpire.GroupTurn.Id`；`NationalSpire.GroupTurn.Notices`；`NationalSpire.GroupTurn.Order`；`NationalSpire.GroupTurn.Raw`；`NationalSpire.GroupTurn.Reasoning`；`NationalSpire.GroupTurn.Replies`；`NationalSpire.GroupTurn.Sender`；`NationalSpire.GroupTurn.SpeechOrders`；`NationalSpire.GroupTurn.Status`；`NationalSpire.GroupTurn.Text`；`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateOffer.TurnId`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.GroupRender`；`NoticesThrough(long)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("ee929d")`；返回值紧邻使用处：`ArgumentSyntax: new Color("ee929d")`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 8);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203448", "668d9b", 10, 16))`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203448", "668d9b", 10, 16));`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody.AddChild(PrivateButton("重试这轮回复", () => GroupCommand("group-retry", new()), 180))`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody.AddChild(PrivateButton("重试这轮回复", () => GroupCommand("group-retry", new()), 180));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody.AddChild(PrivateButton("重新生成本轮", () => GroupCommand("group-regenerate", new()), 180))`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody.AddChild(PrivateButton("重新生成本轮", () => GroupCommand("group-regenerate", new()), 180));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody.AddChild(PrivateLine(PrivateAppointments.DateText(ViewData, t.Day), 13, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody.AddChild(PrivateLine(PrivateAppointments.DateText(ViewData, t.Day), 13, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody.AddChild(PrivateText("开始群聊", 20, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody.AddChild(PrivateText("开始群聊", 20, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody.AddChild(PrivateText(notice, 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody.AddChild(PrivateText(notice, 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody.AddChild(PrivateText(t.Error, 14, new Color("ee929d")))`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody.AddChild(PrivateText(t.Error, 14, new Color("ee929d")));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateHeading!.AddChild(heading)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateHeading!.AddChild(heading);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateHeading.AddChild(PrivateButton("停止生成", () => GroupCommand("group-stop", new()), 110))`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateHeading.AddChild(PrivateButton("停止生成", () => GroupCommand("group-stop", new()), 110));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(PrivateLine(g.Members.Count + " 位成员", 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(PrivateLine(g.Members.Count + " 位成员", 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(PrivateLine(g.Name, 26, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(PrivateLine(g.Name, 26, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`Inner(card).AddChild(PrivateText(notice, 16, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: Inner(card).AddChild(PrivateText(notice, 16, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(Avatar(ViewData, e.Person, 24, false))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(Avatar(ViewData, e.Person, 24, false));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateText(GroupChats.Name(ViewData, e.Person) + " · " + e.Text, 14, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateText(GroupChats.Name(ViewData, e.Person) + " · " + e.Text, 14, CareerVisuals.Teal));`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer()`
- `Godot.ScrollContainer.GetVScrollBar()`；输入表达式：`_privateScroll.GetVScrollBar()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _privateScroll.GetVScrollBar().MaxValue`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `NationalSpire.AiService.GroupKey(NationalSpire.CareerData, string)`；输入表达式：`AiService.GroupKey(ViewData, g.Id)`；返回值紧邻使用处：`ArgumentSyntax: AiService.GroupKey(ViewData, g.Id)`
- `NationalSpire.CareerScreen.AddChatReasoning(string, string)`；输入表达式：`AddChatReasoning(t.Id, reasoning)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AddChatReasoning(t.Id, reasoning)`
- `NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；输入表达式：`Avatar(ViewData, e.Person, 24, false)`；返回值紧邻使用处：`ArgumentSyntax: Avatar(ViewData, e.Person, 24, false)`
- `NationalSpire.CareerScreen.BindChatPage(bool)`；输入表达式：`BindChatPage(ChatAtBottom)`；返回值紧邻使用处：`ExpressionStatementSyntax: BindChatPage(ChatAtBottom);`
- `NationalSpire.CareerScreen.FinishChatPage(bool)`；输入表达式：`FinishChatPage(bottom)`；返回值紧邻使用处：`ExpressionStatementSyntax: FinishChatPage(bottom);`
- `NationalSpire.CareerScreen.GroupBubble(string, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>?)`；输入表达式：`GroupBubble(person, r.Body.ToString())`；返回值紧邻使用处：`AssignmentExpressionSyntax: label = GroupBubble(person, r.Body.ToString())`
- `NationalSpire.CareerScreen.GroupBubble(string, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>?)`；输入表达式：`GroupBubble(r.Author, r.Text)`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupBubble(r.Author, r.Text);`
- `NationalSpire.CareerScreen.GroupBubble(string, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>?)`；输入表达式：`GroupBubble(t.Sender, t.Text, t.Attachments)`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupBubble(t.Sender, t.Text, t.Attachments);`
- `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；输入表达式：`GroupCommand("group-read", new())`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupCommand("group-read", new());`
- `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；输入表达式：`GroupCommand("group-regenerate", new())`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GroupCommand("group-regenerate", new())`
- `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；输入表达式：`GroupCommand("group-retry", new())`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GroupCommand("group-retry", new())`
- `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；输入表达式：`GroupCommand("group-stop", new())`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GroupCommand("group-stop", new())`
- `NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`；输入表达式：`GroupOffer(g, e, offer)`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupOffer(g, e, offer);`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Inner(card).AddChild`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("停止生成", () => GroupCommand("group-stop", new()), 110)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("停止生成", () => GroupCommand("group-stop", new()), 110)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("重试这轮回复", () => GroupCommand("group-retry", new()), 180)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("重试这轮回复", () => GroupCommand("group-retry", new()), 180)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("重新生成本轮", () => GroupCommand("group-regenerate", new()), 180)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("重新生成本轮", () => GroupCommand("group-regenerate", new()), 180)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine(g.Members.Count + " 位成员", 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: PrivateLine(g.Members.Count + " 位成员", 14, _muted)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine(g.Name, 26, _gold)`；返回值紧邻使用处：`ArgumentSyntax: PrivateLine(g.Name, 26, _gold)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine(PrivateAppointments.DateText(ViewData, t.Day), 13, _muted)`；返回值紧邻使用处：`ArgumentSyntax: PrivateLine(PrivateAppointments.DateText(ViewData, t.Day), 13, _muted)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText("开始群聊", 20, _muted)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText("开始群聊", 20, _muted)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText(GroupChats.Name(ViewData, e.Person) + " · " + e.Text, 14, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText(GroupChats.Name(ViewData, e.Person) + " · " + e.Text, 14, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText(notice, 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText(notice, 14, _muted)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText(notice, 16, _ink)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText(notice, 16, _ink)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText(t.Error, 14, new Color("ee929d"))`；返回值紧邻使用处：`ArgumentSyntax: PrivateText(t.Error, 14, new Color("ee929d"))`
- `NationalSpire.CareerScreen.TrainingCompletions(System.Collections.Generic.IEnumerable<NationalSpire.PrivateOffer>, long, long)`；输入表达式：`TrainingCompletions(g.Forgotten ? [] : g.Interactions.Values.SelectMany(c => c.Offers), first, end)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = TrainingCompletions(g.Forgotten ? [] : g.Interactions.Values.SelectMany(c => c.Offers), first, end)`
- `NationalSpire.CareerScreen.TrainingCompletionsThrough(System.Collections.Generic.Queue<NationalSpire.CoachTrainingPlan>, long)`；输入表达式：`TrainingCompletionsThrough(completions, item.Order)`；返回值紧邻使用处：`ExpressionStatementSyntax: TrainingCompletionsThrough(completions, item.Order);`
- `NationalSpire.CareerScreen.TrainingCompletionsThrough(System.Collections.Generic.Queue<NationalSpire.CoachTrainingPlan>, long)`；输入表达式：`TrainingCompletionsThrough(completions, long.MaxValue)`；返回值紧邻使用处：`ExpressionStatementSyntax: TrainingCompletionsThrough(completions, long.MaxValue);`
- `NationalSpire.CareerScreen.UpdateGroupStream(NationalSpire.GroupChat, string, string)`；输入表达式：`UpdateGroupStream(g, live, thought.Text ?? "")`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateGroupStream(g, live, thought.Text ?? "");`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("203448", "668d9b", 10, 16)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("203448", "668d9b", 10, 16)`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(_privateBody)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(_privateBody);`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(_privateHeading!)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(_privateHeading!);`
- `NationalSpire.GroupChat.Resolve(string)`；输入表达式：`g.Resolve(r.Author)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = g.Resolve(r.Author)`
- `NationalSpire.GroupChats.Busy(NationalSpire.GroupChat)`；输入表达式：`GroupChats.Busy(g)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GroupChats.Busy(g)`
- `NationalSpire.GroupChats.CanSpeak(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.CanSpeak(ViewData, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => GroupChats.CanSpeak(ViewData, id)`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(ViewData)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Human(ViewData)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(ViewData, e.Person)`；返回值紧邻使用处：`BinaryExpressionSyntax: GroupChats.Name(ViewData, e.Person) + " · "`
- `NationalSpire.GroupChats.SpeechUnavailable(NationalSpire.CareerData, NationalSpire.GroupChat, string)`；输入表达式：`GroupChats.SpeechUnavailable(ViewData, g, person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GroupChats.SpeechUnavailable(ViewData, g, person).Length`
- `NationalSpire.GroupCommand.GroupCommand()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `NationalSpire.GroupStreamParser.Feed(string)`；输入表达式：`parser.Feed(t.Status == "sending" && live.Length > 0 ? live : t.Raw)`；返回值紧邻使用处：`ExpressionStatementSyntax: parser.Feed(t.Status == "sending" && live.Length > 0 ? live : t.Raw);`
- `NationalSpire.GroupStreamParser.GroupStreamParser()`；输入表达式：`new GroupStreamParser()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GroupStreamParser()`
- `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；输入表达式：`PrivateAppointments.DateText(ViewData, t.Day)`；返回值紧邻使用处：`ArgumentSyntax: PrivateAppointments.DateText(ViewData, t.Day)`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.GroupRender, "通讯")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.GroupRender, "通讯")`
- `NoticesThrough(long)`；输入表达式：`NoticesThrough(i < t.SpeechOrders.Count ? t.SpeechOrders[i] : t.Order)`；返回值紧邻使用处：`ExpressionStatementSyntax: NoticesThrough(i < t.SpeechOrders.Count ? t.SpeechOrders[i] : t.Order);`
- `NoticesThrough(long)`；输入表达式：`NoticesThrough(item.Notice.Order)`；返回值紧邻使用处：`ExpressionStatementSyntax: NoticesThrough(item.Notice.Order);`
- `NoticesThrough(long)`；输入表达式：`NoticesThrough(r.Order)`；返回值紧邻使用处：`ExpressionStatementSyntax: NoticesThrough(r.Order);`
- `string.Contains(string)`；输入表达式：`notice.Contains("当前版本暂不支持 NPC 间约战")`；返回值紧邻使用处：`IfStatementSyntax: if (notice.Contains("当前版本暂不支持 NPC 间约战"))                  {                      var card = new PanelContainer(); card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203448", "668d9b", 10, 16));                      _privateBody.AddChild(card); Inner(card).AddChild(PrivateText(notice, 16, _ink));                  }                  else _privateBody.AddChild(PrivateText(notice, 14, _muted));`
- `string.Join<T>(string?, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`string.Join(",", g.Members.Select(id => GroupChats.CanSpeak(ViewData, id)))`；返回值紧邻使用处：`BinaryExpressionSyntax: ":" + string.Join(",", g.Members.Select(id => GroupChats.CanSpeak(ViewData, id)))`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`g.Interactions.TryGetValue(e.Lane, out var lane)`；返回值紧邻使用处：`IfStatementSyntax: if (g.Interactions.TryGetValue(e.Lane, out var lane)) foreach (var offer in lane.Offers.Where(o => o.TurnId == e.Turn)) GroupOffer(g, e, offer);`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`entries.Select(e => (e.Order, Notice: (GroupEntry?)e, Turn: (GroupTurn?)null))              .Concat(visibleTurns.Select(t => (t.Order, Notice: (GroupEntry?)null, Turn: (GroupTurn?)t)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: entries.Select(e => (e.Order, Notice: (GroupEntry?)e, Turn: (GroupTurn?)null))              .Concat(visibleTurns.Select(t => (t.Order, Notice: (GroupEntry?)null, Turn: (GroupTurn?)t))).OrderBy`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Turns.Count(t => t.Status == "complete")`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Seen.GetValueOrDefault(GroupChats.Human(ViewData)) < g.Turns.Count(t => t.Status == "complete")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`visibleTurns.FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: visibleTurns.FirstOrDefault()?.Order`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`g.Turns.LastOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: t == g.Turns.LastOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`g.Turns.LastOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: g.Turns.LastOrDefault()?.Status`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`entries.Select(e => (e.Order, Notice: (GroupEntry?)e, Turn: (GroupTurn?)null))              .Concat(visibleTurns.Select(t => (t.Order, Notice: (GroupEntry?)null, Turn: (GroupTurn?)t))).OrderBy(x => x.Order)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = entries.Select(e => (e.Order, Notice: (GroupEntry?)e, Turn: (GroupTurn?)null))              .Concat(visibleTurns.Select(t => (t.Order, Notice: (GroupEntry?)null, Turn: (GroupTurn?)t))).OrderBy(x => x.Order)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`g.Entries.Where(e => e.Order >= first && e.Order < end).OrderBy(e => e.Order)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Entries.Where(e => e.Order >= first && e.Order < end).OrderBy(e => e.Order).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`parser.Messages.Select((r, i) => (r, i))`；返回值紧邻使用处：`ForEachVariableStatementSyntax: foreach (var (r, i) in parser.Messages.Select((r, i) => (r, i)))                  {                      RichTextLabel? label = null; string person = g.Resolve(r.Author);                      if (GroupChats.SpeechUnavailable(ViewData, g, person).Length == 0)                      { NoticesThrough(i < t.SpeechOrders.Count ? t.SpeechOrders[i] : t.Order); label = GroupBubble(person, r.Body.ToString()); }                      if (t.Status == "sending") _groupStreamLabels.Add(label);                  }`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`entries.Select(e => (e.Order, Notice: (GroupEntry?)e, Turn: (GroupTurn?)null))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: entries.Select(e => (e.Order, Notice: (GroupEntry?)e, Turn: (GroupTurn?)null))              .Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`g.Members.Select(id => GroupChats.CanSpeak(ViewData, id))`；返回值紧邻使用处：`ArgumentSyntax: g.Members.Select(id => GroupChats.CanSpeak(ViewData, id))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`visibleTurns.Select(t => (t.Order, Notice: (GroupEntry?)null, Turn: (GroupTurn?)t))`；返回值紧邻使用处：`ArgumentSyntax: visibleTurns.Select(t => (t.Order, Notice: (GroupEntry?)null, Turn: (GroupTurn?)t))`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`g.Interactions.Values.SelectMany(c => c.Offers)`；返回值紧邻使用处：`ConditionalExpressionSyntax: g.Forgotten ? [] : g.Interactions.Values.SelectMany(c => c.Offers)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_groupPages.Visible.ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _groupPages.Visible.ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`g.Entries.Where(e => e.Order >= first && e.Order < end).OrderBy(e => e.Order).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = g.Entries.Where(e => e.Order >= first && e.Order < end).OrderBy(e => e.Order).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Entries.Where(e => e.Order >= first && e.Order < end)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Entries.Where(e => e.Order >= first && e.Order < end).OrderBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`lane.Offers.Where(o => o.TurnId == e.Turn)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var offer in lane.Offers.Where(o => o.TurnId == e.Turn)) GroupOffer(g, e, offer);`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`AiService.GroupLive.GetValueOrDefault(AiService.GroupKey(ViewData, g.Id), "")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AiService.GroupLive.GetValueOrDefault(AiService.GroupKey(ViewData, g.Id), "")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`AiService.GroupReasoningLive.GetValueOrDefault(AiService.GroupKey(ViewData, g.Id))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AiService.GroupReasoningLive.GetValueOrDefault(AiService.GroupKey(ViewData, g.Id))`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`g.Seen.GetValueOrDefault(GroupChats.Human(ViewData))`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Seen.GetValueOrDefault(GroupChats.Human(ViewData)) < g.Turns.Count(t => t.Status == "complete")`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`_groupStreamLabels.Add(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: _groupStreamLabels.Add(label);`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`_groupStreamLabels.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _groupStreamLabels.Clear();`
- `System.Collections.Generic.Queue<T>.Queue(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`new Queue<GroupEntry>(entries)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Queue<GroupEntry>(entries)`
- `System.Text.StringBuilder.ToString()`；输入表达式：`r.Body.ToString()`；返回值紧邻使用处：`ArgumentSyntax: r.Body.ToString()`

**赋值（含属性/字段和局部值）：**

- `_groupReasoningUpdate` = `null`
- `_groupReasoningUpdate` = `updateReasoning`
- `_groupSignature` = `signature`
- `_groupStreamParser` = `null`
- `_groupStreamParser` = `parser`
- `_groupStreamRaw` = `""`
- `_groupStreamRaw` = `live.Length > 0 ? live : t.Raw`
- `_groupStreamThought` = `thought.Text ?? ""`
- `_privateSend!.Text` = `busy ? "正在回复…" : "发送"`
- `_privateSend.Disabled` = `busy`
- `_privateStatus!.Text` = `_groupError.Length > 0 ? _groupError : g.SummaryError.Length > 0 ? g.SummaryError : g.SummaryStatus`
- `_privateStatus.Visible` = `_privateStatus.Text.Length > 0`
- `label` = `GroupBubble(person, r.Body.ToString())`
- `lastDay` = `t.Day`
- `signature` += `":" + string.Join(",", g.Members.Select(id => GroupChats.CanSpeak(ViewData, id)))`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-cfcadd7edb2e"></a>

## `NoticesThrough(long) — void NoticesThrough(long order)`

来源：源码第 92 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)

**调用：** [`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-84294149ff91)；[`NationalSpire.CareerScreen.TrainingCompletionsThrough(System.Collections.Generic.Queue<NationalSpire.CoachTrainingPlan>, long)`](CoachScreen.cs.md#symbol-9deab8f6abda)；[`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`](PrivateAppointments.cs.md#symbol-1c549626b284)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`System.Collections.Generic.Queue<T>.Dequeue()`；`System.Collections.Generic.Queue<T>.TryPeek(out T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privateBody`；`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；`NationalSpire.CareerScreen.TrainingCompletionsThrough(System.Collections.Generic.Queue<NationalSpire.CoachTrainingPlan>, long)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.GroupEntry.Day`；`NationalSpire.GroupEntry.Order`；`NationalSpire.GroupEntry.Text`；`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody.AddChild(PrivateLine(PrivateAppointments.DateText(ViewData, entry.Day) + " · " + entry.Text, 13, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody.AddChild(PrivateLine(PrivateAppointments.DateText(ViewData, entry.Day) + " · " + entry.Text, 13, _muted));`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine(PrivateAppointments.DateText(ViewData, entry.Day) + " · " + entry.Text, 13, _muted)`；返回值紧邻使用处：`ArgumentSyntax: PrivateLine(PrivateAppointments.DateText(ViewData, entry.Day) + " · " + entry.Text, 13, _muted)`
- `NationalSpire.CareerScreen.TrainingCompletionsThrough(System.Collections.Generic.Queue<NationalSpire.CoachTrainingPlan>, long)`；输入表达式：`TrainingCompletionsThrough(completions, entry.Order)`；返回值紧邻使用处：`ExpressionStatementSyntax: TrainingCompletionsThrough(completions, entry.Order);`
- `NationalSpire.CareerScreen.TrainingCompletionsThrough(System.Collections.Generic.Queue<NationalSpire.CoachTrainingPlan>, long)`；输入表达式：`TrainingCompletionsThrough(completions, order)`；返回值紧邻使用处：`ExpressionStatementSyntax: TrainingCompletionsThrough(completions, order);`
- `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；输入表达式：`PrivateAppointments.DateText(ViewData, entry.Day)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateAppointments.DateText(ViewData, entry.Day) + " · "`
- `System.Collections.Generic.Queue<T>.Dequeue()`；输入表达式：`notices.Dequeue()`；返回值紧邻使用处：`ExpressionStatementSyntax: notices.Dequeue();`
- `System.Collections.Generic.Queue<T>.TryPeek(out T)`；输入表达式：`notices.TryPeek(out var entry)`；返回值紧邻使用处：`BinaryExpressionSyntax: notices.TryPeek(out var entry) && entry.Order <= order`

**赋值（含属性/字段和局部值）：**

- `lastDay` = `entry.Day`

<a id="symbol-870e7cca58c0"></a>

## `NationalSpire.CareerScreen.GroupBubble(string, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>?) — private RichTextLabel GroupBubble(string person, string text, List<PrivateOffer>? attachments = null)`

来源：源码第 160 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.CareerScreen.UpdateGroupStream(NationalSpire.GroupChat, string, string)`](GroupChatScreen.cs.md#symbol-c33de3d8ae73)

**调用：** [`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`](CareerAvatars.cs.md#symbol-9f2c4623a902)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.OpenGroupPerson(string)`](GroupChatScreen.cs.md#symbol-1eb7b9a65ede)；[`NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`](PrivateMemoryScreen.cs.md#symbol-eb2b2a37c5d1)；[`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-84294149ff91)；[`NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-5789f5c9047d)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-24bc82bdbbd4)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；[`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-8a6bb6e78fa5)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.Control()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.AffectionBadge.AffectionBadge()`；`string.Trim()`

**字段、属性、事件及方法组引用：** `NationalSpire.AffectionBadge.Compact`；`NationalSpire.AffectionBadge.Relation`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._privateBody`；`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.OpenGroupPerson(string)`；`NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`；`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；`NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateRelation.Favour`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`contents.AddThemeConstantOverride("separation", 5)`；返回值紧邻使用处：`ExpressionStatementSyntax: contents.AddThemeConstantOverride("separation", 5);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`portrait.AddThemeConstantOverride("separation", 3)`；返回值紧邻使用处：`ExpressionStatementSyntax: portrait.AddThemeConstantOverride("separation", 3);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`bubble.AddThemeStyleboxOverride("panel", CareerVisuals.Box(self ? "304b60" : "223649", self ? "597f98" : "405c72", 10, 14))`；返回值紧邻使用处：`ExpressionStatementSyntax: bubble.AddThemeStyleboxOverride("panel", CareerVisuals.Box(self ? "304b60" : "223649", self ? "597f98" : "405c72", 10, 14));`
- `Godot.Control.Control()`；输入表达式：`new Control { Name = "GroupFavour_" + person, CustomMinimumSize = new(38, 42), TooltipText = "对你的好感：" + PrivateMessages.Relation(ViewData, person).Favour }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Control { Name = "GroupFavour_" + person, CustomMinimumSize = new(38, 42), TooltipText = "对你的好感：" + PrivateMessages.Relation(ViewData, person).Favour }`
- `Godot.Control.Control()`；输入表达式：`new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(40, 0) }`；返回值紧邻使用处：`ArgumentSyntax: new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(40, 0) }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody!.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody!.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`badge.AddChild(new AffectionBadge { Relation = PrivateMessages.Relation(ViewData, person), Compact = true })`；返回值紧邻使用处：`ExpressionStatementSyntax: badge.AddChild(new AffectionBadge { Relation = PrivateMessages.Relation(ViewData, person), Compact = true });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`contents.AddChild(bubble)`；返回值紧邻使用处：`ExpressionStatementSyntax: contents.AddChild(bubble);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`contents.AddChild(PrivateLine(GroupChats.Name(ViewData, person), 14, self ? _gold : CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: contents.AddChild(PrivateLine(GroupChats.Name(ViewData, person), 14, self ? _gold : CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inner.AddChild(message)`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddChild(message);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inner.AddChild(PrivateAttachmentCard(a, false))`；返回值紧邻使用处：`ExpressionStatementSyntax: inner.AddChild(PrivateAttachmentCard(a, false));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`portrait.AddChild(Avatar(ViewData, person, 38, open: () => OpenGroupPerson(person)))`；返回值紧邻使用处：`ExpressionStatementSyntax: portrait.AddChild(Avatar(ViewData, person, 38, open: () => OpenGroupPerson(person)));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`portrait.AddChild(badge)`；返回值紧邻使用处：`ExpressionStatementSyntax: portrait.AddChild(badge);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(contents)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(contents);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(40, 0) })`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(new Control { SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(40, 0) });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(portrait)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(portrait);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer()`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Name = "GroupSpeaker_" + person, SizeFlagsVertical = SizeFlags.ShrinkBegin }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { Name = "GroupSpeaker_" + person, SizeFlagsVertical = SizeFlags.ShrinkBegin }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = 4 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = 4 }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(38, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(38, 42)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(40, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(40, 0)`
- `NationalSpire.AffectionBadge.AffectionBadge()`；输入表达式：`new AffectionBadge { Relation = PrivateMessages.Relation(ViewData, person), Compact = true }`；返回值紧邻使用处：`ArgumentSyntax: new AffectionBadge { Relation = PrivateMessages.Relation(ViewData, person), Compact = true }`
- `NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；输入表达式：`Avatar(ViewData, person, 38, open: () => OpenGroupPerson(person))`；返回值紧邻使用处：`ArgumentSyntax: Avatar(ViewData, person, 38, open: () => OpenGroupPerson(person))`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(bubble)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(bubble)`
- `NationalSpire.CareerScreen.OpenGroupPerson(string)`；输入表达式：`OpenGroupPerson(person)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenGroupPerson(person)`
- `NationalSpire.CareerScreen.PrivateAttachmentCard(NationalSpire.PrivateOffer, bool)`；输入表达式：`PrivateAttachmentCard(a, false)`；返回值紧邻使用处：`ArgumentSyntax: PrivateAttachmentCard(a, false)`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine(GroupChats.Name(ViewData, person), 14, self ? _gold : CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: PrivateLine(GroupChats.Name(ViewData, person), 14, self ? _gold : CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`；输入表达式：`PrivateSelectableText(text.Trim(), 18, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateSelectableText(text.Trim(), 18, _ink)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(self ? "304b60" : "223649", self ? "597f98" : "405c72", 10, 14)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box(self ? "304b60" : "223649", self ? "597f98" : "405c72", 10, 14)`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(ViewData)`；返回值紧邻使用处：`BinaryExpressionSyntax: person == GroupChats.Human(ViewData)`
- `NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.IsHuman(ViewData, person)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GroupChats.IsHuman(ViewData, person)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(ViewData, person)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Name(ViewData, person)`
- `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Relation(ViewData, person)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Relation = PrivateMessages.Relation(ViewData, person)`
- `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Relation(ViewData, person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Relation(ViewData, person).Favour`
- `string.Trim()`；输入表达式：`text.Trim()`；返回值紧邻使用处：`ArgumentSyntax: text.Trim()`

**赋值（含属性/字段和局部值）：**

- `Compact` = `true`
- `CustomMinimumSize` = `new(38, 42)`
- `CustomMinimumSize` = `new(40, 0)`
- `Name` = `"GroupFavour_" + person`
- `Name` = `"GroupSpeaker_" + person`
- `Relation` = `PrivateMessages.Relation(ViewData, person)`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsStretchRatio` = `4`
- `SizeFlagsVertical` = `SizeFlags.ShrinkBegin`
- `TooltipText` = `"对你的好感：" + PrivateMessages.Relation(ViewData, person).Favour`

<a id="symbol-3afa41099b93"></a>

## `NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer) — private void GroupOffer(GroupChat g, GroupEffect e, PrivateOffer o)`

来源：源码第 184 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)

**调用：** [`Action(string, string)`](GroupChatScreen.cs.md#symbol-6ba145316ba5)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.PanelContainer.PanelContainer()`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerScreen.ClosePrivateMessages()`](PrivateMessageScreen.cs.md#symbol-eb21fd76632c)；[`NationalSpire.CareerScreen.GiftReceipt(NationalSpire.PrivateOffer)`](ChatAttachmentScreen.cs.md#symbol-bb34e71c1240)；[`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.OpenDateScene(string, bool, bool)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.OpenPost(NationalSpire.CommunityPost)`](CareerNavigation.cs.md#symbol-3888620952df)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateLineupCard(NationalSpire.CareerData, NationalSpire.CoachLineupRequest, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`](CoachScreen.cs.md#symbol-c01675f974f7)；[`NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-5789f5c9047d)；[`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`](PrivateMessageScreen.cs.md#symbol-fb5e88f4639a)；[`NationalSpire.CareerScreen.PrivateTrainingCard(NationalSpire.CareerData, NationalSpire.CoachTrainingPlan, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`](CoachScreen.cs.md#symbol-c2e37e4a0f14)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-1ed5bef75319)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；`NationalSpire.DateChoiceButton.DateChoiceButton()`；[`NationalSpire.DateGroupBridge.Find(NationalSpire.CareerData, string, string)`](DateGroupBridge.cs.md#symbol-6bffe5cc487f)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；`NationalSpire.GroupCommand.GroupCommand()`；[`NationalSpire.OwnedClubs.ReplaceableStarters(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-e1cbaaf9f832)；[`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；[`NationalSpire.WeddingAppointments.Description(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-b0c3ba2ccdb6)；[`NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-f30a9608f6f8)；[`Send(string, NationalSpire.PrivateMessageCommand)`](GroupChatScreen.cs.md#symbol-0386fdb3b2eb)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.List<T>.Contains(T)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`

**字段、属性、事件及方法组引用：** `Action(string, string)`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerScreen.ClosePrivateMessages()`；`NationalSpire.CareerScreen.GiftReceipt(NationalSpire.PrivateOffer)`；`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.OpenDateScene(string, bool, bool)`；`NationalSpire.CareerScreen.OpenPost(NationalSpire.CommunityPost)`；`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateLineupCard(NationalSpire.CareerData, NationalSpire.CoachLineupRequest, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`；`NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`；`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；`NationalSpire.CareerScreen.PrivateTrainingCard(NationalSpire.CareerData, NationalSpire.CoachTrainingPlan, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privateBody`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`；`NationalSpire.CoachLineupRequest.Id`；`NationalSpire.CoachTrainingPlan.Id`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.DateChoiceButton.Caption`；`NationalSpire.DateGroupBridge.Find(NationalSpire.CareerData, string, string)`；`NationalSpire.EsportsCareer.LineupRequests`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.GroupCommand.Interaction`；`NationalSpire.GroupCommand.Lane`；`NationalSpire.GroupEffect.Human`；`NationalSpire.GroupEffect.Lane`；`NationalSpire.GroupEffect.Person`；`NationalSpire.GroupEffect.Target`；`NationalSpire.OathAttachments.Kind`；`NationalSpire.OwnedClubs.ReplaceableStarters(NationalSpire.CareerData)`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateMessageCommand.Offer`；`NationalSpire.PrivateMessageCommand.Part`；`NationalSpire.PrivateOffer.Ascension`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.FavourBefore`；`NationalSpire.PrivateOffer.FavourTargets`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.MatchId`；`NationalSpire.PrivateOffer.Mode`；`NationalSpire.PrivateOffer.Participants`；`NationalSpire.PrivateOffer.Role`；`NationalSpire.PrivateOffer.Signing`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.Title`；`NationalSpire.PrivateOffer.Wage`；`NationalSpire.PrivateOffer.Weeks`；`NationalSpire.PrivateOffer.WinBonus`；`NationalSpire.WeddingAppointments.Description(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`；`Send(string, NationalSpire.PrivateMessageCommand)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Action(string, string)`；输入表达式：`Action("取消", "decline")`；返回值紧邻使用处：`ExpressionStatementSyntax: Action("取消", "decline");`
- `Action(string, string)`；输入表达式：`Action("私密赴约", "attend")`；返回值紧邻使用处：`ExpressionStatementSyntax: Action("私密赴约", "attend");`
- `Action(string, string)`；输入表达式：`Action(o.Kind == "favour" ? "保留原值" : "拒绝", "decline")`；返回值紧邻使用处：`ExpressionStatementSyntax: Action(o.Kind == "favour" ? "保留原值" : "拒绝", "decline");`
- `Action(string, string)`；输入表达式：`Action(o.Kind == "favour" ? "应用" : o.Kind == "publish" ? "确认发布" : "确认", "confirm")`；返回值紧邻使用处：`ExpressionStatementSyntax: Action(o.Kind == "favour" ? "应用" : o.Kind == "publish" ? "确认发布" : "确认", "confirm");`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203448", "668d9b", 10, 16))`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("203448", "668d9b", 10, 16));`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_privateBody!.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateBody!.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(PrivateButton("公开赴约", () => Send("attend", new() { Offer = o.Id, Part = "public" }), 120))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(PrivateButton("公开赴约", () => Send("attend", new() { Offer = o.Id, Part = "public" }), 120));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(PrivateButton("查看帖子 ↗", () => { ClosePrivateMessages(); OpenPost(post); }, 140))`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(PrivateButton("查看帖子 ↗", () => { ClosePrivateMessages(); OpenPost(post); }, 140));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(date)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(date);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateSelectableText(WeddingAppointments.Description(ViewData, o), 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateSelectableText(WeddingAppointments.Description(ViewData, o), 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateSelectableText(o.Detail, 16, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateSelectableText(o.Detail, 16, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateText($"{GameCalendar.Text(ViewData, PrivateAppointments.Date(ViewData, o))}" + (o.Kind == "match" ? $" · A{o.Ascension} · {o.Mode}" : " · " + string.Join("、", o.Participants.Select(id => GroupChats.Name(ViewData, id)))), 16, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateText($"{GameCalendar.Text(ViewData, PrivateAppointments.Date(ViewData, o))}" + (o.Kind == "match" ? $" · A{o.Ascension} · {o.Mode}" : " · " + string.Join("、", o.Participants.Select(id => GroupChats.Name(ViewData, id)))), 16, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateText($"对{GroupChats.Name(ViewData, e.Target.Length > 0 ? e.Target : e.Human)}的好感 {o.FavourBefore} → {o.FavourTargets.LastOrDefault()}", 17, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateText($"对{GroupChats.Name(ViewData, e.Target.Length > 0 ? e.Target : e.Human)}的好感 {o.FavourBefore} → {o.FavourTargets.LastOrDefault()}", 17, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateText($"签字费 ${o.Signing:#,0.##} · 周薪 ${o.Wage:#,0.##}\n胜场奖金 ${o.WinBonus:#,0.##} · {o.Weeks}周 · {o.Role}", 16, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateText($"签字费 ${o.Signing:#,0.##} · 周薪 ${o.Wage:#,0.##}\n胜场奖金 ${o.WinBonus:#,0.##} · {o.Weeks}周 · {o.Role}", 16, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateText(GroupChats.Name(ViewData, e.Person) + " · " + title + " · " + o.State, 18, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateText(GroupChats.Name(ViewData, e.Person) + " · " + title + " · " + o.State, 18, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateText(o.Title, 19, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateText(o.Title, 19, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(choices)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(choices);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`choices.AddItem("选择接替的首发")`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.AddItem("选择接替的首发");`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`choices.AddItem(GroupChats.Name(ViewData, id))`；返回值紧邻使用处：`ExpressionStatementSyntax: choices.AddItem(GroupChats.Name(ViewData, id));`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton()`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(180, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(180, 48)`
- `NationalSpire.CareerScreen.ClosePrivateMessages()`；输入表达式：`ClosePrivateMessages()`；返回值紧邻使用处：`ExpressionStatementSyntax: ClosePrivateMessages();`
- `NationalSpire.CareerScreen.GiftReceipt(NationalSpire.PrivateOffer)`；输入表达式：`GiftReceipt(o)`；返回值紧邻使用处：`ExpressionStatementSyntax: GiftReceipt(o);`
- `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；输入表达式：`GroupCommand("group-offer-date", new() { Lane = e.Lane, Interaction = new() { Offer = o.Id } }, () => { if (DateGroupBridge.Find(ViewData, group, o.Id) is { } scene) { OpenPrivateMessages(scene.Conversation.PersonId); OpenDateScene(scene.Offer.Id); } })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GroupCommand("group-offer-date", new() { Lane = e.Lane, Interaction = new() { Offer = o.Id } }, () => { if (DateGroupBridge.Find(ViewData, group, o.Id) is { } scene) { OpenPrivateMessages(scene.Conversation.PersonId); OpenDateScene(scene.Offer.Id); } })`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(card)`
- `NationalSpire.CareerScreen.OpenDateScene(string, bool, bool)`；输入表达式：`OpenDateScene(scene.Offer.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenDateScene(scene.Offer.Id);`
- `NationalSpire.CareerScreen.OpenPost(NationalSpire.CommunityPost)`；输入表达式：`OpenPost(post)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenPost(post);`
- `NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；输入表达式：`OpenPrivateMessages(scene.Conversation.PersonId)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenPrivateMessages(scene.Conversation.PersonId);`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("公开赴约", () => Send("attend", new() { Offer = o.Id, Part = "public" }), 120)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("公开赴约", () => Send("attend", new() { Offer = o.Id, Part = "public" }), 120)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("查看帖子 ↗", () => { ClosePrivateMessages(); OpenPost(post); }, 140)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("查看帖子 ↗", () => { ClosePrivateMessages(); OpenPost(post); }, 140)`
- `NationalSpire.CareerScreen.PrivateLineupCard(NationalSpire.CareerData, NationalSpire.CoachLineupRequest, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`；输入表达式：`PrivateLineupCard(ViewData, request, _privateBody!, Send)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateLineupCard(ViewData, request, _privateBody!, Send);`
- `NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`；输入表达式：`PrivateSelectableText(WeddingAppointments.Description(ViewData, o), 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: PrivateSelectableText(WeddingAppointments.Description(ViewData, o), 15, _muted)`
- `NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`；输入表达式：`PrivateSelectableText(o.Detail, 16, _ink)`；返回值紧邻使用处：`ArgumentSyntax: PrivateSelectableText(o.Detail, 16, _ink)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText($"{GameCalendar.Text(ViewData, PrivateAppointments.Date(ViewData, o))}" + (o.Kind == "match" ? $" · A{o.Ascension} · {o.Mode}" : " · " + string.Join("、", o.Participants.Select(id => GroupChats.Name(ViewData, id)))), 16, _ink)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText($"{GameCalendar.Text(ViewData, PrivateAppointments.Date(ViewData, o))}" + (o.Kind == "match" ? $" · A{o.Ascension} · {o.Mode}" : " · " + string.Join("、", o.Participants.Select(id => GroupChats.Name(ViewData, id)))), 16, _ink)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText($"对{GroupChats.Name(ViewData, e.Target.Length > 0 ? e.Target : e.Human)}的好感 {o.FavourBefore} → {o.FavourTargets.LastOrDefault()}", 17, _ink)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText($"对{GroupChats.Name(ViewData, e.Target.Length > 0 ? e.Target : e.Human)}的好感 {o.FavourBefore} → {o.FavourTargets.LastOrDefault()}", 17, _ink)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText($"签字费 ${o.Signing:#,0.##} · 周薪 ${o.Wage:#,0.##}\n胜场奖金 ${o.WinBonus:#,0.##} · {o.Weeks}周 · {o.Role}", 16, _ink)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText($"签字费 ${o.Signing:#,0.##} · 周薪 ${o.Wage:#,0.##}\n胜场奖金 ${o.WinBonus:#,0.##} · {o.Weeks}周 · {o.Role}", 16, _ink)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText(GroupChats.Name(ViewData, e.Person) + " · " + title + " · " + o.State, 18, _gold)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText(GroupChats.Name(ViewData, e.Person) + " · " + title + " · " + o.State, 18, _gold)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText(o.Title, 19, _ink)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText(o.Title, 19, _ink)`
- `NationalSpire.CareerScreen.PrivateTrainingCard(NationalSpire.CareerData, NationalSpire.CoachTrainingPlan, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`；输入表达式：`PrivateTrainingCard(ViewData, plan, _privateBody!, Send)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateTrainingCard(ViewData, plan, _privateBody!, Send);`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("203448", "668d9b", 10, 16)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("203448", "668d9b", 10, 16)`
- `NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.TrainingPlans(ViewData)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ClubCoaching.TrainingPlans(ViewData).FirstOrDefault`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(ViewData)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(ViewData).FirstOrDefault`
- `NationalSpire.DateChoiceButton.DateChoiceButton()`；输入表达式：`new DateChoiceButton { Name = "GroupDate", Caption = "进入多人约会", CustomMinimumSize = new(180, 48), SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new DateChoiceButton { Name = "GroupDate", Caption = "进入多人约会", CustomMinimumSize = new(180, 48), SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `NationalSpire.DateGroupBridge.Find(NationalSpire.CareerData, string, string)`；输入表达式：`DateGroupBridge.Find(ViewData, group, o.Id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: DateGroupBridge.Find(ViewData, group, o.Id) is { } scene`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(ViewData, PrivateAppointments.Date(ViewData, o))`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Text(ViewData, PrivateAppointments.Date(ViewData, o))}`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(ViewData)`；返回值紧邻使用处：`BinaryExpressionSyntax: e.Human == GroupChats.Human(ViewData)`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(ViewData)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Human(ViewData)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(ViewData, e.Person)`；返回值紧邻使用处：`BinaryExpressionSyntax: GroupChats.Name(ViewData, e.Person) + " · "`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(ViewData, e.Target.Length > 0 ? e.Target : e.Human)`；返回值紧邻使用处：`InterpolationSyntax: {GroupChats.Name(ViewData, e.Target.Length > 0 ? e.Target : e.Human)}`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(ViewData, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => GroupChats.Name(ViewData, id)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(ViewData, id)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Name(ViewData, id)`
- `NationalSpire.GroupCommand.GroupCommand()`；输入表达式：`new() { Lane = e.Lane, Interaction = new() { Offer = o.Id } }`；返回值紧邻使用处：`ArgumentSyntax: new() { Lane = e.Lane, Interaction = new() { Offer = o.Id } }`
- `NationalSpire.OwnedClubs.ReplaceableStarters(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.ReplaceableStarters(ViewData)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = OwnedClubs.ReplaceableStarters(ViewData)`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(ViewData, o)`；返回值紧邻使用处：`ArgumentSyntax: PrivateAppointments.Date(ViewData, o)`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(ViewData, o)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateAppointments.Date(ViewData, o) == ViewData.Day`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Offer = o.Id }`；返回值紧邻使用处：`AssignmentExpressionSyntax: Interaction = new() { Offer = o.Id }`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Offer = o.Id, Part = "public" }`；返回值紧邻使用处：`ArgumentSyntax: new() { Offer = o.Id, Part = "public" }`
- `NationalSpire.WeddingAppointments.Description(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`WeddingAppointments.Description(ViewData, o)`；返回值紧邻使用处：`ArgumentSyntax: WeddingAppointments.Description(ViewData, o)`
- `NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`；输入表达式：`WeddingAppointments.IsWedding(o)`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Kind == "activity" && WeddingAppointments.IsWedding(o)`
- `Send(string, NationalSpire.PrivateMessageCommand)`；输入表达式：`Send("attend", new() { Offer = o.Id, Part = "public" })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Send("attend", new() { Offer = o.Id, Part = "public" })`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`ClubCoaching.TrainingPlans(ViewData).FirstOrDefault(p => p.Id == o.Id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ClubCoaching.TrainingPlans(ViewData).FirstOrDefault(p => p.Id == o.Id) is { } plan`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(ViewData).FirstOrDefault(p => p.Id == o.MatchId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CommunityThreads.All(ViewData).FirstOrDefault(p => p.Id == o.MatchId) is { } post`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`ViewData.Esports.LineupRequests.FirstOrDefault(r => r.Id == o.Id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ViewData.Esports.LineupRequests.FirstOrDefault(r => r.Id == o.Id) is { } request`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`o.FavourTargets.LastOrDefault()`；返回值紧邻使用处：`InterpolationSyntax: {o.FavourTargets.LastOrDefault()}`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`o.Participants.Select(id => GroupChats.Name(ViewData, id))`；返回值紧邻使用处：`ArgumentSyntax: o.Participants.Select(id => GroupChats.Name(ViewData, id))`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`o.Participants.Contains(GroupChats.Human(ViewData))`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Kind == "activity" && o.Participants.Contains(GroupChats.Human(ViewData))`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", o.Participants.Select(id => GroupChats.Name(ViewData, id)))`；返回值紧邻使用处：`BinaryExpressionSyntax: " · " + string.Join("、", o.Participants.Select(id => GroupChats.Name(ViewData, id)))`

**赋值（含属性/字段和局部值）：**

- `Caption` = `"进入多人约会"`
- `CustomMinimumSize` = `new(180, 48)`
- `Interaction` = `new() { Offer = o.Id }`
- `Lane` = `e.Lane`
- `Name` = `"GroupDate"`
- `Offer` = `o.Id`
- `Part` = `"public"`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `choices.ItemSelected` += `n => replacement = n > 0 ? ids[(int)n - 1] : ""`
- `date.Pressed` += `() => GroupCommand("group-offer-date", new() { Lane = e.Lane, Interaction = new() { Offer = o.Id } }, () => { if (DateGroupBridge.Find(ViewData, group, o.Id) is { } scene) { OpenPrivateMessages(scene.Conversation.PersonId); OpenDateScene(scene.Offer.Id); } })`
- `replacement` = `n > 0 ? ids[(int)n - 1] : ""`

<a id="symbol-0386fdb3b2eb"></a>

## `Send(string, NationalSpire.PrivateMessageCommand) — void Send(string kind, PrivateMessageCommand command)`

来源：源码第 187 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`](GroupChatScreen.cs.md#symbol-3afa41099b93)

**调用：** [`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；`NationalSpire.GroupCommand.GroupCommand()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；`NationalSpire.GroupCommand.Interaction`；`NationalSpire.GroupCommand.Lane`；`NationalSpire.GroupEffect.Lane`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；输入表达式：`GroupCommand("group-offer-" + kind, new() { Lane = e.Lane, Interaction = command })`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => GroupCommand("group-offer-" + kind, new() { Lane = e.Lane, Interaction = command })`
- `NationalSpire.GroupCommand.GroupCommand()`；输入表达式：`new() { Lane = e.Lane, Interaction = command }`；返回值紧邻使用处：`ArgumentSyntax: new() { Lane = e.Lane, Interaction = command }`

**赋值（含属性/字段和局部值）：**

- `Interaction` = `command`
- `Lane` = `e.Lane`

<a id="symbol-6ba145316ba5"></a>

## `Action(string, string) — void Action(string label, string kind)`

来源：源码第 207 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`](GroupChatScreen.cs.md#symbol-3afa41099b93)

**调用：** [`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`NationalSpire.GroupCommand.GroupCommand()`；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.GroupCommand.Interaction`；`NationalSpire.GroupCommand.Lane`；`NationalSpire.GroupEffect.Lane`；`NationalSpire.PrivateMessageCommand.Offer`；`NationalSpire.PrivateMessageCommand.Replacement`；`NationalSpire.PrivateOffer.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(PrivateButton(label, () => GroupCommand("group-offer-" + kind, new() { Lane = e.Lane, Interaction = new() { Offer = o.Id, Replacement = replacement } }), 110))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => actions.AddChild(PrivateButton(label, () => GroupCommand("group-offer-" + kind, new() { Lane = e.Lane, Interaction = new() { Offer = o.Id, Replacement = replacement } }), 110))`
- `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；输入表达式：`GroupCommand("group-offer-" + kind, new() { Lane = e.Lane, Interaction = new() { Offer = o.Id, Replacement = replacement } })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GroupCommand("group-offer-" + kind, new() { Lane = e.Lane, Interaction = new() { Offer = o.Id, Replacement = replacement } })`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton(label, () => GroupCommand("group-offer-" + kind, new() { Lane = e.Lane, Interaction = new() { Offer = o.Id, Replacement = replacement } }), 110)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton(label, () => GroupCommand("group-offer-" + kind, new() { Lane = e.Lane, Interaction = new() { Offer = o.Id, Replacement = replacement } }), 110)`
- `NationalSpire.GroupCommand.GroupCommand()`；输入表达式：`new() { Lane = e.Lane, Interaction = new() { Offer = o.Id, Replacement = replacement } }`；返回值紧邻使用处：`ArgumentSyntax: new() { Lane = e.Lane, Interaction = new() { Offer = o.Id, Replacement = replacement } }`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Offer = o.Id, Replacement = replacement }`；返回值紧邻使用处：`AssignmentExpressionSyntax: Interaction = new() { Offer = o.Id, Replacement = replacement }`

**赋值（含属性/字段和局部值）：**

- `Interaction` = `new() { Offer = o.Id, Replacement = replacement }`
- `Lane` = `e.Lane`
- `Offer` = `o.Id`
- `Replacement` = `replacement`

<a id="symbol-17b4992ac7c2"></a>

## `NationalSpire.CareerScreen.SendGroup() — private void SendGroup()`

来源：源码第 232 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.SendPrivate()`](PrivateMessageScreen.cs.md#symbol-748ab66a7351)

**调用：** [`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.CareerScreen.LatestChatPage()`](ChatHistoryScreen.cs.md#symbol-566a2e34c9dd)；[`NationalSpire.CareerScreen.RefreshPrivateAttachments()`](PrivateMemoryScreen.cs.md#symbol-b9d6c2084031)；[`NationalSpire.GroupChats.Busy(NationalSpire.GroupChat)`](GroupChats.cs.md#symbol-85bf6e1105fe)；`NationalSpire.GroupCommand.GroupCommand()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._privateInput`；`NationalSpire.CareerScreen.ChatDraftKey`；`NationalSpire.CareerScreen.CurrentGroup`；`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；`NationalSpire.CareerScreen.LatestChatPage()`；`NationalSpire.CareerScreen.PrivateAttachments`；`NationalSpire.CareerScreen.RefreshPrivateAttachments()`；`NationalSpire.GroupChats.Busy(NationalSpire.GroupChat)`；`NationalSpire.GroupCommand.Attachments`；`NationalSpire.GroupCommand.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；输入表达式：`GroupCommand("group-send", new() { Text = text, Attachments = attachments }, () =>          { if (ChatDraftKey == key) { _privateInput.Text = ""; PrivateAttachments.Clear(); RefreshPrivateAttachments(); LatestChatPage(); } })`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupCommand("group-send", new() { Text = text, Attachments = attachments }, () =>          { if (ChatDraftKey == key) { _privateInput.Text = ""; PrivateAttachments.Clear(); RefreshPrivateAttachments(); LatestChatPage(); } });`
- `NationalSpire.CareerScreen.LatestChatPage()`；输入表达式：`LatestChatPage()`；返回值紧邻使用处：`ExpressionStatementSyntax: LatestChatPage();`
- `NationalSpire.CareerScreen.RefreshPrivateAttachments()`；输入表达式：`RefreshPrivateAttachments()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPrivateAttachments();`
- `NationalSpire.GroupChats.Busy(NationalSpire.GroupChat)`；输入表达式：`GroupChats.Busy(g)`；返回值紧邻使用处：`BinaryExpressionSyntax: CurrentGroup is not { } g || GroupChats.Busy(g)`
- `NationalSpire.GroupCommand.GroupCommand()`；输入表达式：`new() { Text = text, Attachments = attachments }`；返回值紧邻使用处：`ArgumentSyntax: new() { Text = text, Attachments = attachments }`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`PrivateAttachments.ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateAttachments.ToList()`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`PrivateAttachments.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateAttachments.Clear();`

**赋值（含属性/字段和局部值）：**

- `_privateInput.Text` = `""`
- `Attachments` = `attachments`
- `Text` = `text`

<a id="symbol-9f2d53ad7587"></a>

## `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?) — private void GroupCommand(string kind, GroupCommand command, Action? accepted = null)`

来源：源码第 239 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Action(string, string)`](GroupChatScreen.cs.md#symbol-6ba145316ba5)；[`NationalSpire.CareerScreen.ChatMenuItems(string, bool)`](ChatManagementScreen.cs.md#symbol-99485204d7d6)；[`NationalSpire.CareerScreen.ConfirmChatRemoval(bool)`](ChatManagementScreen.cs.md#symbol-0e0563dae4b1)；[`NationalSpire.CareerScreen.ConfirmKick(string, bool)`](ChatManagementScreen.cs.md#symbol-93a2414720c3)；[`NationalSpire.CareerScreen.GroupArbitrationDialog()`](GroupChatDialogs.cs.md#symbol-b436b0c3aa2f)；[`NationalSpire.CareerScreen.GroupMemory()`](GroupChatDialogs.cs.md#symbol-bf729ae9b3eb)；[`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`](GroupChatScreen.cs.md#symbol-3afa41099b93)；[`NationalSpire.CareerScreen.GroupSettings()`](GroupChatDialogs.cs.md#symbol-a263539cc71f)；[`NationalSpire.CareerScreen.GroupSidebar(Godot.VBoxContainer)`](GroupChatScreen.cs.md#symbol-88d7619ce50a)；[`NationalSpire.CareerScreen.ProactiveChatDialog()`](ChatManagementScreen.cs.md#symbol-f9397f5fb6b7)；[`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.CareerScreen.RestoreChatDialog()`](ChatManagementScreen.cs.md#symbol-812702bacb1e)；[`NationalSpire.CareerScreen.SendGroup()`](GroupChatScreen.cs.md#symbol-17b4992ac7c2)；[`Rename()`](ChatManagementScreen.cs.md#symbol-f30827c9dfc2)；[`Send(string, NationalSpire.PrivateMessageCommand)`](GroupChatScreen.cs.md#symbol-0386fdb3b2eb)

**调用：** [`NationalSpire.AiService.FailureReason(System.Exception)`](AiService.cs.md#symbol-a50bcbf6dda5)；[`NationalSpire.AiService.ProcessGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string>?)`](AiGroupChats.cs.md#symbol-caddadc35a6b)；[`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`](AiDiscussion.cs.md#symbol-63a666dde156)；[`NationalSpire.AiService.SummarizeGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, string)`](AiGroupChats.cs.md#symbol-1e6e737dbe88)；[`NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`](AiSettingsStore.cs.md#symbol-b37e55b3af97)；[`NationalSpire.CareerScreen.SelectGroup(string, int)`](GroupChatScreen.cs.md#symbol-72d02215d0db)；[`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`](CareerStore.cs.md#symbol-ead7461ee7cb)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.CommunityThreads.PendingIds(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-1196d0b01b89)；[`NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`](GroupChats.cs.md#symbol-e0439deb45ac)；[`NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-81f7f177c347)；[`NationalSpire.ICareerSession.Refresh()`](CareerSession.cs.md#symbol-bae3aaaf496d)；[`NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-e21b0ff1d18b)；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Collections.Generic.IEnumerable<TSource>.Last<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.ChatTools`；`NationalSpire.AiService.FailureReason(System.Exception)`；`NationalSpire.AiService.ProcessGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string>?)`；`NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`；`NationalSpire.AiService.SummarizeGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, string)`；`NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerScreen._groupError`；`NationalSpire.CareerScreen._groupSignature`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privateListSignature`；`NationalSpire.CareerScreen._privateStatus`；`NationalSpire.CareerScreen.SelectGroup(string, int)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.CommunityThreads.PendingIds(NationalSpire.CareerData)`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`；`NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`；`NationalSpire.GroupCommand.Text`；`NationalSpire.GroupCommand.ToolMode`；`NationalSpire.ICareerSession.Refresh()`；`NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.FailureReason(System.Exception)`；输入表达式：`AiService.FailureReason(ex)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _groupError = AiService.FailureReason(ex)`
- `NationalSpire.AiService.ProcessGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string>?)`；输入表达式：`AiService.ProcessGroupAsync(() => CareerStore.IsCurrent(d) ? d : null, CareerStore.Save, id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.ProcessGroupAsync(() => CareerStore.IsCurrent(d) ? d : null, CareerStore.Save, id)`
- `NationalSpire.AiService.ProcessInteractionsAsync(System.Collections.Generic.IEnumerable<string>, NationalSpire.CareerData?)`；输入表达式：`AiService.ProcessInteractionsAsync(CommunityThreads.PendingIds(d).ToArray(), d)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.ProcessInteractionsAsync(CommunityThreads.PendingIds(d).ToArray(), d)`
- `NationalSpire.AiService.SummarizeGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, string)`；输入表达式：`AiService.SummarizeGroupAsync(() => CareerStore.IsCurrent(d) ? d : null, CareerStore.Save, id, command.Text)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.SummarizeGroupAsync(() => CareerStore.IsCurrent(d) ? d : null, CareerStore.Save, id, command.Text)`
- `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；输入表达式：`AiSettingsStore.Load(ViewData.Ai)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AiSettingsStore.Load(ViewData.Ai).ChatTools`
- `NationalSpire.CareerScreen.SelectGroup(string, int)`；输入表达式：`SelectGroup(GroupChats.Visible(d).Last().Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectGroup(GroupChats.Visible(d).Last().Id);`
- `NationalSpire.CareerScreen.SelectGroup(string, int)`；输入表达式：`SelectGroup(GroupChats.Visible(ViewData).Last().Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectGroup(GroupChats.Visible(ViewData).Last().Id);`
- `NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；输入表达式：`CareerStore.IsCurrent(d)`；返回值紧邻使用处：`ConditionalExpressionSyntax: CareerStore.IsCurrent(d) ? d : null`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(d);`
- `NationalSpire.CommunityThreads.PendingIds(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.PendingIds(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.PendingIds(d).ToArray`
- `NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`；输入表达式：`GroupChats.Command(d, kind, id, command)`；返回值紧邻使用处：`IsPatternExpressionSyntax: GroupChats.Command(d, kind, id, command) is { } error`
- `NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`；输入表达式：`GroupChats.Visible(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GroupChats.Visible(d).Last`
- `NationalSpire.GroupChats.Visible(NationalSpire.CareerData)`；输入表达式：`GroupChats.Visible(ViewData)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GroupChats.Visible(ViewData).Last`
- `NationalSpire.ICareerSession.Refresh()`；输入表达式：`_multiplayer.Refresh()`；返回值紧邻使用处：`ExpressionStatementSyntax: _multiplayer.Refresh();`
- `NationalSpire.ICareerSession.Send(string, string, string, int, string, System.Action?)`；输入表达式：`_multiplayer.Send(kind, id, JsonSerializer.Serialize(command), accepted: () => { accepted?.Invoke(); _multiplayer.Refresh(); _groupSignature = _privateListSignature = ""; if (kind == "group-create") SelectGroup(GroupChats.Visible(ViewData).Last().Id); })`；返回值紧邻使用处：`ExpressionStatementSyntax: _multiplayer.Send(kind, id, JsonSerializer.Serialize(command), accepted: () => { accepted?.Invoke(); _multiplayer.Refresh(); _groupSignature = _privateListSignature = ""; if (kind == "group-create") SelectGroup(GroupChats.Visible(ViewData).Last().Id); });`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: accepted?.Invoke()`
- `System.Collections.Generic.IEnumerable<TSource>.Last<TSource>()`；输入表达式：`GroupChats.Visible(d).Last()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GroupChats.Visible(d).Last().Id`
- `System.Collections.Generic.IEnumerable<TSource>.Last<TSource>()`；输入表达式：`GroupChats.Visible(ViewData).Last()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GroupChats.Visible(ViewData).Last().Id`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`CommunityThreads.PendingIds(d).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: CommunityThreads.PendingIds(d).ToArray()`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(command)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(command)`

**赋值（含属性/字段和局部值）：**

- `_` = `AiService.ProcessGroupAsync(() => CareerStore.IsCurrent(d) ? d : null, CareerStore.Save, id)`
- `_` = `AiService.ProcessInteractionsAsync(CommunityThreads.PendingIds(d).ToArray(), d)`
- `_` = `AiService.SummarizeGroupAsync(() => CareerStore.IsCurrent(d) ? d : null, CareerStore.Save, id, command.Text)`
- `_groupError` = `""`
- `_groupError` = `AiService.FailureReason(ex)`
- `_groupError` = `error`
- `_groupSignature` = `_privateListSignature = ""`
- `_groupSignature` = `""`
- `_privateListSignature` = `""`
- `_privateStatus!.Text` = `_groupError = AiService.FailureReason(ex)`
- `_privateStatus!.Text` = `_groupError = error`
- `_privateStatus.Visible` = `true`
- `command.ToolMode` = `AiSettingsStore.Load(ViewData.Ai).ChatTools`

<a id="symbol-26ccde004356"></a>

## `NationalSpire.CareerScreen.GroupMemberPicker(NationalSpire.GroupChat?, System.Action<System.Collections.Generic.List<string>>, bool, string, bool, bool) — private void GroupMemberPicker(GroupChat? group, Action<List<string>> accept, bool existing = false, string title = "", bool single = false, bool showPortraits = false)`

来源：源码第 256 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ChatMenuItems(string, bool)`](ChatManagementScreen.cs.md#symbol-99485204d7d6)；[`NationalSpire.CareerScreen.GroupSidebar(Godot.VBoxContainer)`](GroupChatScreen.cs.md#symbol-88d7619ce50a)；[`NationalSpire.CareerScreen.InviteDateParticipant(string)`](DateScenePartyScreen.cs.md#symbol-71141f3538db)；[`NationalSpire.CareerScreen.TestDateScenePicker()`](DateSceneTesting.cs.md#symbol-c1c7664de97e)；[`Pick(string, System.Action, bool, bool)`](GroupChatDialogs.cs.md#symbol-859a67dfed9d)

**调用：** `Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；[`NationalSpire.CareerScreen.PeoplePicker(Godot.VBoxContainer, System.Collections.Generic.IReadOnlyList<NationalSpire.CareerPerson>, System.Collections.Generic.HashSet<string>, bool, System.Action, int, bool)`](PeoplePickerScreen.cs.md#symbol-80a307ead785)；[`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`](PrivateMessageScreen.cs.md#symbol-fb5e88f4639a)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；`System.Action<T>.Invoke(T)`；`System.Collections.Generic.HashSet<T>.HashSet()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.People`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerScreen.PeoplePicker(Godot.VBoxContainer, System.Collections.Generic.IReadOnlyList<NationalSpire.CareerPerson>, System.Collections.Generic.HashSet<string>, bool, System.Action, int, bool)`；`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._groupCreateName`；`NationalSpire.CareerScreen._muted`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(() => accept(chosen)).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(() => accept(chosen)).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(() => accept(chosen))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(() => accept(chosen)).CallDeferred`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Text = _groupCreateName, PlaceholderText = "群聊名称" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Text = _groupCreateName, PlaceholderText = "群聊名称" }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateText("当前成员：" + string.Join("、", group.Members.Select(id => GroupChats.Name(d, id))), 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateText("当前成员：" + string.Join("、", group.Members.Select(id => GroupChats.Name(d, id))), 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(name)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(name);`
- `NationalSpire.CareerScreen.PeoplePicker(Godot.VBoxContainer, System.Collections.Generic.IReadOnlyList<NationalSpire.CareerPerson>, System.Collections.Generic.HashSet<string>, bool, System.Action, int, bool)`；输入表达式：`PeoplePicker(box, candidates, selected, single, () => { }, 300, showPortraits)`；返回值紧邻使用处：`ExpressionStatementSyntax: PeoplePicker(box, candidates, selected, single, () => { }, 300, showPortraits);`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText("当前成员：" + string.Join("、", group.Members.Select(id => GroupChats.Name(d, id))), 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: PrivateText("当前成员：" + string.Join("、", group.Members.Select(id => GroupChats.Name(d, id))), 15, _muted)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog(title.Length > 0 ? title : group == null ? "新建群聊" : "添加群成员", "", () => { var chosen = selected.ToList(); Callable.From(() => accept(chosen)).CallDeferred(); return true; }, group == null ? "创建" : "确定", box => { if (group == null) { var name = new LineEdit { Text = _groupCreateName, PlaceholderText = "群聊名称" }; name.TextChanged += value => _groupCreateName = value; box.AddChild(name); } if (group != null && !existing) box.AddChild(PrivateText("当前成员：" + string.Join("、", group.Members.Select(id => GroupChats.Name(d, id))), 15, _muted)); PeoplePicker(box, candidates, selected, single, () => { }, 300, showPortraits); })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog(title.Length > 0 ? title : group == null ? "新建群聊" : "添加群成员", "", () => { var chosen = selected.ToList(); Callable.From(() => accept(chosen)).CallDeferred(); return true; }, group == null ? "创建" : "确定", box => { if (group == null) { var name = new LineEdit { Text = _groupCreateName, PlaceholderText = "群聊名称" }; name.TextChanged += value => _groupCreateName = value; box.AddChild(name); } if (group != null && !existing) box.AddChild(PrivateText("当前成员：" + string.Join("、", group.Members.Select(id => GroupChats.Name(d, id))), 15, _muted)); PeoplePicker(box, candidates, selected, single, () => { }, 300, showPortraits); });`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Id != GroupChats.Human(d)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => GroupChats.Name(d, id)`
- `System.Action<T>.Invoke(T)`；输入表达式：`accept(chosen)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => accept(chosen)`
- `System.Collections.Generic.HashSet<T>.HashSet()`；输入表达式：`new HashSet<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HashSet<string>()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`group.Members.Select(id => GroupChats.Name(d, id))`；返回值紧邻使用处：`ArgumentSyntax: group.Members.Select(id => GroupChats.Name(d, id))`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`d.People.Where(p => p.Id != GroupChats.Human(d) && (group == null || existing == group.Members.Contains(p.Id))).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.People.Where(p => p.Id != GroupChats.Human(d) && (group == null || existing == group.Members.Contains(p.Id))).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`selected.ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = selected.ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p => p.Id != GroupChats.Human(d) && (group == null || existing == group.Members.Contains(p.Id)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.Id != GroupChats.Human(d) && (group == null || existing == group.Members.Contains(p.Id))).ToArray`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`group.Members.Contains(p.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: existing == group.Members.Contains(p.Id)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", group.Members.Select(id => GroupChats.Name(d, id)))`；返回值紧邻使用处：`BinaryExpressionSyntax: "当前成员：" + string.Join("、", group.Members.Select(id => GroupChats.Name(d, id)))`

**赋值（含属性/字段和局部值）：**

- `PlaceholderText` = `"群聊名称"`
- `Text` = `_groupCreateName`
- `_groupCreateName` = `value`
- `name.TextChanged` += `value => _groupCreateName = value`
