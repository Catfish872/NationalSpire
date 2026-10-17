# ChatHistoryScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`6435775A80D139E97FCC6ABBA81476A9BD6819B2A07C2C5CAF35C2DD8E1B8F7C`。来源：[源码](../../ChatHistoryScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private readonly ChatHistoryPage<PrivateTurn> _privatePages = new(t => t.Id);
private readonly ChatHistoryPage<GroupTurn> _groupPages = new(t => t.Id);
private static readonly ConfigFile ChatPreferences = new();
private static bool _chatPreferencesLoaded;
private int _chatPageSize = 10, _chatPageScroll = -1;
private bool _chatNewMessages;
private Button? _chatEarlier, _chatNewer, _chatLatest;
private Label? _chatPageLabel;
private OptionButton? _chatSizePicker;
private HBoxContainer? _chatPagination, _chatPageOptions;
```

<a id="symbol-60c240186eab"></a>

## `NationalSpire.CareerScreen.ChatPreferenceKey — private string ChatPreferenceKey`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.WorldId`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(ViewData)`；返回值紧邻使用处：`BinaryExpressionSyntax: ViewData.WorldId + ":" + GroupChats.Human(ViewData)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a15faf795baa"></a>

## `NationalSpire.CareerScreen.ChatPage — private int ChatPage`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._groupPages`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privatePages`；`NationalSpire.ChatHistoryPage<T>.Page`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8e961f491a1e"></a>

## `NationalSpire.CareerScreen.ChatPageCount — private int ChatPageCount`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._groupPages`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privatePages`；`NationalSpire.ChatHistoryPage<T>.Pages`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ff04fa8ede92"></a>

## `NationalSpire.CareerScreen.ChatAtLatest — private bool ChatAtLatest`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ChatPage`；`NationalSpire.CareerScreen.ChatPageCount`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1053cb7c6473"></a>

## `NationalSpire.CareerScreen.ChatAtBottom — private bool ChatAtBottom`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.ScrollContainer.GetVScrollBar()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._privateScroll`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ScrollContainer.GetVScrollBar()`；输入表达式：`_privateScroll.GetVScrollBar()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _privateScroll.GetVScrollBar().MaxValue`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d1d5bc5023c7"></a>

## `NationalSpire.CareerScreen.LoadChatPreferences() — private void LoadChatPreferences()`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)

**调用：** `Godot.ConfigFile.GetValue(string, string, Godot.Variant)`；`Godot.ConfigFile.Load(string)`；`Godot.Variant.AsInt32()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._chatPageSize`；`NationalSpire.CareerScreen._chatPreferencesLoaded`；`NationalSpire.CareerScreen.ChatPreferenceKey`；`NationalSpire.CareerScreen.ChatPreferences`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ConfigFile.GetValue(string, string, Godot.Variant)`；输入表达式：`ChatPreferences.GetValue(ChatPreferenceKey, "size", 10)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ChatPreferences.GetValue(ChatPreferenceKey, "size", 10).AsInt32`
- `Godot.ConfigFile.Load(string)`；输入表达式：`ChatPreferences.Load("user://NationalSpire_chat.cfg")`；返回值紧邻使用处：`ExpressionStatementSyntax: ChatPreferences.Load("user://NationalSpire_chat.cfg");`
- `Godot.Variant.AsInt32()`；输入表达式：`ChatPreferences.GetValue(ChatPreferenceKey, "size", 10).AsInt32()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _chatPageSize = ChatPreferences.GetValue(ChatPreferenceKey, "size", 10).AsInt32()`

**赋值（含属性/字段和局部值）：**

- `_chatPageSize` = `ChatPreferences.GetValue(ChatPreferenceKey, "size", 10).AsInt32()`
- `_chatPreferencesLoaded` = `true`

<a id="symbol-614208ed0b0d"></a>

## `NationalSpire.CareerScreen.SaveChatPreferences() — private void SaveChatPreferences()`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildChatPagination(NationalSpire.ChatComposerLayout)`](ChatHistoryScreen.cs.md#symbol-28d387d79595)；[`NationalSpire.CareerScreen.SelectGroup(string, int)`](GroupChatScreen.cs.md#symbol-72d02215d0db)；[`NationalSpire.CareerScreen.SelectPrivate(string, int)`](PrivateMessageScreen.cs.md#symbol-ddace6dd7c79)

**调用：** `Godot.ConfigFile.GetValue(string, string, Godot.Variant)`；`Godot.ConfigFile.Save(string)`；`Godot.ConfigFile.SetValue(string, string, Godot.Variant)`；`Godot.GD.PushWarning(string)`；`Godot.Variant.AsInt32()`；`Godot.Variant.AsString()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._chatPageSize`；`NationalSpire.CareerScreen.ChatDraftKey`；`NationalSpire.CareerScreen.ChatPreferenceKey`；`NationalSpire.CareerScreen.ChatPreferences`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ConfigFile.GetValue(string, string, Godot.Variant)`；输入表达式：`ChatPreferences.GetValue(key, "last", "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ChatPreferences.GetValue(key, "last", "").AsString`
- `Godot.ConfigFile.GetValue(string, string, Godot.Variant)`；输入表达式：`ChatPreferences.GetValue(key, "size", 10)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ChatPreferences.GetValue(key, "size", 10).AsInt32`
- `Godot.ConfigFile.Save(string)`；输入表达式：`ChatPreferences.Save("user://NationalSpire_chat.cfg")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ChatPreferences.Save("user://NationalSpire_chat.cfg")`
- `Godot.ConfigFile.SetValue(string, string, Godot.Variant)`；输入表达式：`ChatPreferences.SetValue(key, "last", ChatDraftKey)`；返回值紧邻使用处：`ExpressionStatementSyntax: ChatPreferences.SetValue(key, "last", ChatDraftKey);`
- `Godot.ConfigFile.SetValue(string, string, Godot.Variant)`；输入表达式：`ChatPreferences.SetValue(key, "size", _chatPageSize)`；返回值紧邻使用处：`ExpressionStatementSyntax: ChatPreferences.SetValue(key, "size", _chatPageSize);`
- `Godot.GD.PushWarning(string)`；输入表达式：`GD.PushWarning("聊天显示设置保存失败：" + error)`；返回值紧邻使用处：`ExpressionStatementSyntax: GD.PushWarning("聊天显示设置保存失败：" + error);`
- `Godot.Variant.AsInt32()`；输入表达式：`ChatPreferences.GetValue(key, "size", 10).AsInt32()`；返回值紧邻使用处：`BinaryExpressionSyntax: ChatPreferences.GetValue(key, "size", 10).AsInt32() == _chatPageSize`
- `Godot.Variant.AsString()`；输入表达式：`ChatPreferences.GetValue(key, "last", "").AsString()`；返回值紧邻使用处：`BinaryExpressionSyntax: ChatPreferences.GetValue(key, "last", "").AsString() == ChatDraftKey`

**赋值（含属性/字段和局部值）：**


<a id="symbol-28d387d79595"></a>

## `NationalSpire.CareerScreen.BuildChatPagination(NationalSpire.ChatComposerLayout) — private void BuildChatPagination(ChatComposerLayout actions)`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildPrivateComposerActions(Godot.VBoxContainer)`](PrivateMessageScreen.cs.md#symbol-a7be0d6513a6)

**调用：** [`Action(string, string, System.Action, int)`](ChatHistoryScreen.cs.md#symbol-ed35dcf54e40)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.GetThemeStylebox(Godot.StringName, Godot.StringName)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.RemoveChild(Godot.Node)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.OptionButton.Select(int)`；`Godot.Resource.Duplicate(bool)`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerScreen.ChangeChatPage(int)`](ChatHistoryScreen.cs.md#symbol-0e399328f32b)；[`NationalSpire.CareerScreen.InvalidateChatPage(int)`](ChatHistoryScreen.cs.md#symbol-110069df9a95)；[`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-84294149ff91)；[`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)；[`NationalSpire.CareerScreen.SaveChatPreferences()`](ChatHistoryScreen.cs.md#symbol-614208ed0b0d)；[`NationalSpire.ChatHistoryPage<T>.Resize(int)`](ChatHistoryPage.cs.md#symbol-03212ab16f78)

**字段、属性、事件及方法组引用：** `Action(string, string, System.Action, int)`；`NationalSpire.CareerScreen.ChangeChatPage(int)`；`NationalSpire.CareerScreen.ChatPage`；`NationalSpire.CareerScreen.InvalidateChatPage(int)`；`NationalSpire.CareerScreen.LatestChatPage()`；`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`；`NationalSpire.CareerScreen.SaveChatPreferences()`；`NationalSpire.CareerScreen._chatEarlier`；`NationalSpire.CareerScreen._chatLatest`；`NationalSpire.CareerScreen._chatNewer`；`NationalSpire.CareerScreen._chatPageLabel`；`NationalSpire.CareerScreen._chatPageOptions`；`NationalSpire.CareerScreen._chatPageSize`；`NationalSpire.CareerScreen._chatPagination`；`NationalSpire.CareerScreen._chatSizePicker`；`NationalSpire.CareerScreen._groupPages`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privatePages`；`NationalSpire.ChatHistoryPage<T>.Resize(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Action(string, string, System.Action, int)`；输入表达式：`Action("ChatEarlier", "‹", () => ChangeChatPage(ChatPage - 1), 32)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _chatEarlier = Action("ChatEarlier", "‹", () => ChangeChatPage(ChatPage - 1), 32)`
- `Action(string, string, System.Action, int)`；输入表达式：`Action("ChatLatest", "回到最新", LatestChatPage, 96)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _chatLatest = Action("ChatLatest", "回到最新", LatestChatPage, 96)`
- `Action(string, string, System.Action, int)`；输入表达式：`Action("ChatNewer", "›", () => ChangeChatPage(ChatPage + 1), 32)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _chatNewer = Action("ChatNewer", "›", () => ChangeChatPage(ChatPage + 1), 32)`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`options.AddThemeConstantOverride("separation", 6)`；返回值紧邻使用处：`ExpressionStatementSyntax: options.AddThemeConstantOverride("separation", 6);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 6)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 6);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`_chatEarlier.AddThemeFontSizeOverride("font_size", 20)`；返回值紧邻使用处：`ExpressionStatementSyntax: _chatEarlier.AddThemeFontSizeOverride("font_size", 20);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`_chatNewer.AddThemeFontSizeOverride("font_size", 20)`；返回值紧邻使用处：`ExpressionStatementSyntax: _chatNewer.AddThemeFontSizeOverride("font_size", 20);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`_chatSizePicker.AddThemeFontSizeOverride("font_size", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: _chatSizePicker.AddThemeFontSizeOverride("font_size", 14);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`_chatSizePicker.AddThemeStyleboxOverride(state, style)`；返回值紧邻使用处：`ExpressionStatementSyntax: _chatSizePicker.AddThemeStyleboxOverride(state, style);`
- `Godot.Control.GetThemeStylebox(Godot.StringName, Godot.StringName)`；输入表达式：`_chatSizePicker.GetThemeStylebox(state)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _chatSizePicker.GetThemeStylebox(state).Duplicate`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Name = "ChatPageOptions", Visible = false }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { Name = "ChatPageOptions", Visible = false }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Name = "ChatPagination", Visible = false }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { Name = "ChatPagination", Visible = false }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(options)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(options);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`options.AddChild(_chatLatest)`；返回值紧邻使用处：`ExpressionStatementSyntax: options.AddChild(_chatLatest);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`options.AddChild(_chatSizePicker)`；返回值紧邻使用处：`ExpressionStatementSyntax: options.AddChild(_chatSizePicker);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(_chatPageLabel)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(_chatPageLabel);`
- `Godot.Node.RemoveChild(Godot.Node)`；输入表达式：`row.RemoveChild(_chatLatest)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.RemoveChild(_chatLatest);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`_chatSizePicker.AddItem("每页 10轮")`；返回值紧邻使用处：`ExpressionStatementSyntax: _chatSizePicker.AddItem("每页 10轮");`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`_chatSizePicker.AddItem("每页 5轮")`；返回值紧邻使用处：`ExpressionStatementSyntax: _chatSizePicker.AddItem("每页 5轮");`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "ChatPageSize", CustomMinimumSize = new(108, 42), SizeFlagsVertical = SizeFlags.Fill }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _chatSizePicker = new OptionButton { Name = "ChatPageSize", CustomMinimumSize = new(108, 42), SizeFlagsVertical = SizeFlags.Fill }`
- `Godot.OptionButton.Select(int)`；输入表达式：`_chatSizePicker.Select(_chatPageSize == 5 ? 0 : 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: _chatSizePicker.Select(_chatPageSize == 5 ? 0 : 1);`
- `Godot.Resource.Duplicate(bool)`；输入表达式：`_chatSizePicker.GetThemeStylebox(state).Duplicate()`；返回值紧邻使用处：`CastExpressionSyntax: (StyleBox)_chatSizePicker.GetThemeStylebox(state).Duplicate()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(108, 42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(108, 42)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(90, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _chatPageLabel.CustomMinimumSize = new(90, 0)`
- `NationalSpire.CareerScreen.ChangeChatPage(int)`；输入表达式：`ChangeChatPage(ChatPage + 1)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ChangeChatPage(ChatPage + 1)`
- `NationalSpire.CareerScreen.ChangeChatPage(int)`；输入表达式：`ChangeChatPage(ChatPage - 1)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ChangeChatPage(ChatPage - 1)`
- `NationalSpire.CareerScreen.InvalidateChatPage(int)`；输入表达式：`InvalidateChatPage(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: InvalidateChatPage(0);`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine("", 14, _muted)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _chatPageLabel = PrivateLine("", 14, _muted)`
- `NationalSpire.CareerScreen.RefreshPrivateChat(bool)`；输入表达式：`RefreshPrivateChat()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPrivateChat();`
- `NationalSpire.CareerScreen.SaveChatPreferences()`；输入表达式：`SaveChatPreferences()`；返回值紧邻使用处：`ExpressionStatementSyntax: SaveChatPreferences();`
- `NationalSpire.ChatHistoryPage<T>.Resize(int)`；输入表达式：`_groupPages.Resize(_chatPageSize)`；返回值紧邻使用处：`ExpressionStatementSyntax: _groupPages.Resize(_chatPageSize);`
- `NationalSpire.ChatHistoryPage<T>.Resize(int)`；输入表达式：`_privatePages.Resize(_chatPageSize)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privatePages.Resize(_chatPageSize);`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(108, 42)`
- `Name` = `"ChatPageOptions"`
- `Name` = `"ChatPageSize"`
- `Name` = `"ChatPagination"`
- `SizeFlagsVertical` = `SizeFlags.Fill`
- `Visible` = `false`
- `_chatEarlier.TooltipText` = `"较早记录"`
- `_chatEarlier` = `Action("ChatEarlier", "‹", () => ChangeChatPage(ChatPage - 1), 32)`
- `_chatLatest` = `Action("ChatLatest", "回到最新", LatestChatPage, 96)`
- `_chatNewer.TooltipText` = `"较新记录"`
- `_chatNewer` = `Action("ChatNewer", "›", () => ChangeChatPage(ChatPage + 1), 32)`
- `_chatPageLabel.CustomMinimumSize` = `new(90, 0)`
- `_chatPageLabel.HorizontalAlignment` = `HorizontalAlignment.Center`
- `_chatPageLabel.Name` = `"ChatPageLabel"`
- `_chatPageLabel.SizeFlagsHorizontal` = `SizeFlags.ShrinkCenter`
- `_chatPageLabel.VerticalAlignment` = `VerticalAlignment.Center`
- `_chatPageLabel` = `PrivateLine("", 14, _muted)`
- `_chatPageOptions` = `options`
- `_chatPageSize` = `index == 0 ? 5 : 10`
- `_chatPagination` = `row`
- `_chatSizePicker.ItemSelected` += `index => { _chatPageSize = index == 0 ? 5 : 10; _privatePages.Resize(_chatPageSize); _groupPages.Resize(_chatPageSize); SaveChatPreferences(); InvalidateChatPage(0); RefreshPrivateChat(); }`
- `_chatSizePicker` = `new OptionButton { Name = "ChatPageSize", CustomMinimumSize = new(108, 42), SizeFlagsVertical = SizeFlags.Fill }`
- `style.ContentMarginBottom` = `6`
- `style.ContentMarginTop` = `style.ContentMarginBottom = 6`

<a id="symbol-ed35dcf54e40"></a>

## `Action(string, string, System.Action, int) — Button Action(string name, string text, Action click, int width)`

来源：源码第 42 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildChatPagination(NationalSpire.ChatComposerLayout)`](ChatHistoryScreen.cs.md#symbol-28d387d79595)

**调用：** `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.GetThemeStylebox(Godot.StringName, Godot.StringName)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Resource.Duplicate(bool)`；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeFontSizeOverride("font_size", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeFontSizeOverride("font_size", 14);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride(state, style)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride(state, style);`
- `Godot.Control.GetThemeStylebox(Godot.StringName, Godot.StringName)`；输入表达式：`button.GetThemeStylebox(state)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: button.GetThemeStylebox(state).Duplicate`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(button);`
- `Godot.Resource.Duplicate(bool)`；输入表达式：`button.GetThemeStylebox(state).Duplicate()`；返回值紧邻使用处：`CastExpressionSyntax: (StyleBox)button.GetThemeStylebox(state).Duplicate()`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton(text, click, width)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton(text, click, width)`

**赋值（含属性/字段和局部值）：**

- `button.Name` = `name`
- `button.SizeFlagsVertical` = `SizeFlags.Fill`
- `style.ContentMarginBottom` = `6`
- `style.ContentMarginTop` = `style.ContentMarginBottom = 6`

<a id="symbol-0a8a3b0ae98b"></a>

## `NationalSpire.CareerScreen.ResetChatPage() — private void ResetChatPage()`

来源：源码第 79 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.SelectGroup(string, int)`](GroupChatScreen.cs.md#symbol-72d02215d0db)；[`NationalSpire.CareerScreen.SelectPrivate(string, int)`](PrivateMessageScreen.cs.md#symbol-ddace6dd7c79)

**调用：** `Godot.CanvasItem.Show()`；[`NationalSpire.CareerScreen.InvalidateChatPage(int)`](ChatHistoryScreen.cs.md#symbol-110069df9a95)；[`NationalSpire.ChatHistoryPage<T>.Reset(int)`](ChatHistoryPage.cs.md#symbol-e836f7b91e73)；`System.Action<T>.Invoke(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.InvalidateChatPage(int)`；`NationalSpire.CareerScreen._chatNewMessages`；`NationalSpire.CareerScreen._chatPageOptions`；`NationalSpire.CareerScreen._chatPageSize`；`NationalSpire.CareerScreen._chatPagination`；`NationalSpire.CareerScreen._groupPages`；`NationalSpire.CareerScreen._privateActions`；`NationalSpire.CareerScreen._privateExpressions`；`NationalSpire.CareerScreen._privatePages`；`NationalSpire.ChatComposerLayout.CenterPages`；`NationalSpire.ChatHistoryPage<T>.Reset(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Show()`；输入表达式：`_chatPageOptions!.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: _chatPageOptions!.Show();`
- `Godot.CanvasItem.Show()`；输入表达式：`_chatPagination!.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: _chatPagination!.Show();`
- `NationalSpire.CareerScreen.InvalidateChatPage(int)`；输入表达式：`InvalidateChatPage(int.MaxValue)`；返回值紧邻使用处：`ExpressionStatementSyntax: InvalidateChatPage(int.MaxValue);`
- `NationalSpire.ChatHistoryPage<T>.Reset(int)`；输入表达式：`_groupPages.Reset(_chatPageSize)`；返回值紧邻使用处：`ExpressionStatementSyntax: _groupPages.Reset(_chatPageSize);`
- `NationalSpire.ChatHistoryPage<T>.Reset(int)`；输入表达式：`_privatePages.Reset(_chatPageSize)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privatePages.Reset(_chatPageSize);`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(true)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _privateExpressions?.Invoke(true)`

**赋值（含属性/字段和局部值）：**

- `_chatNewMessages` = `false`
- `_privateActions!.CenterPages` = `true`

<a id="symbol-110069df9a95"></a>

## `NationalSpire.CareerScreen.InvalidateChatPage(int) — private void InvalidateChatPage(int position)`

来源：源码第 88 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildChatPagination(NationalSpire.ChatComposerLayout)`](ChatHistoryScreen.cs.md#symbol-28d387d79595)；[`NationalSpire.CareerScreen.ChangeChatPage(int)`](ChatHistoryScreen.cs.md#symbol-0e399328f32b)；[`NationalSpire.CareerScreen.LatestChatPage()`](ChatHistoryScreen.cs.md#symbol-566a2e34c9dd)；[`NationalSpire.CareerScreen.ResetChatPage()`](ChatHistoryScreen.cs.md#symbol-0a8a3b0ae98b)；[`NationalSpire.CareerScreen.SelectGroup(string, int)`](GroupChatScreen.cs.md#symbol-72d02215d0db)；[`NationalSpire.CareerScreen.SelectPrivate(string, int)`](PrivateMessageScreen.cs.md#symbol-ddace6dd7c79)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._chatPageScroll`；`NationalSpire.CareerScreen._groupSignature`；`NationalSpire.CareerScreen._privateScrollRevision`；`NationalSpire.CareerScreen._privateSignature`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_chatPageScroll` = `position`
- `_groupSignature` = `""`
- `_privateSignature` = `_groupSignature = ""`

<a id="symbol-0e399328f32b"></a>

## `NationalSpire.CareerScreen.ChangeChatPage(int) — private void ChangeChatPage(int page)`

来源：源码第 93 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildChatPagination(NationalSpire.ChatComposerLayout)`](ChatHistoryScreen.cs.md#symbol-28d387d79595)

**调用：** [`NationalSpire.CareerScreen.InvalidateChatPage(int)`](ChatHistoryScreen.cs.md#symbol-110069df9a95)；[`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)；[`NationalSpire.ChatHistoryPage<T>.Move(int)`](ChatHistoryPage.cs.md#symbol-27c362fe5d02)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._groupPages`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privatePages`；`NationalSpire.CareerScreen.InvalidateChatPage(int)`；`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`；`NationalSpire.ChatHistoryPage<T>.Move(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.InvalidateChatPage(int)`；输入表达式：`InvalidateChatPage(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: InvalidateChatPage(0);`
- `NationalSpire.CareerScreen.RefreshPrivateChat(bool)`；输入表达式：`RefreshPrivateChat()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPrivateChat();`
- `NationalSpire.ChatHistoryPage<T>.Move(int)`；输入表达式：`_groupPages.Move(page)`；返回值紧邻使用处：`ExpressionStatementSyntax: _groupPages.Move(page);`
- `NationalSpire.ChatHistoryPage<T>.Move(int)`；输入表达式：`_privatePages.Move(page)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privatePages.Move(page);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-566a2e34c9dd"></a>

## `NationalSpire.CareerScreen.LatestChatPage() — private void LatestChatPage()`

来源：源码第 98 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.SendGroup()`](GroupChatScreen.cs.md#symbol-17b4992ac7c2)；[`NationalSpire.CareerScreen.SendPrivate()`](PrivateMessageScreen.cs.md#symbol-748ab66a7351)

**调用：** [`NationalSpire.CareerScreen.BindChatPage(bool)`](ChatHistoryScreen.cs.md#symbol-e22063fef4cb)；[`NationalSpire.CareerScreen.InvalidateChatPage(int)`](ChatHistoryScreen.cs.md#symbol-110069df9a95)；[`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)；[`NationalSpire.ChatHistoryPage<T>.Latest()`](ChatHistoryPage.cs.md#symbol-d95554cbf6e7)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._chatNewMessages`；`NationalSpire.CareerScreen._groupPages`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privatePages`；`NationalSpire.CareerScreen.BindChatPage(bool)`；`NationalSpire.CareerScreen.InvalidateChatPage(int)`；`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`；`NationalSpire.ChatHistoryPage<T>.Latest()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.BindChatPage(bool)`；输入表达式：`BindChatPage(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: BindChatPage(true);`
- `NationalSpire.CareerScreen.InvalidateChatPage(int)`；输入表达式：`InvalidateChatPage(int.MaxValue)`；返回值紧邻使用处：`ExpressionStatementSyntax: InvalidateChatPage(int.MaxValue);`
- `NationalSpire.CareerScreen.RefreshPrivateChat(bool)`；输入表达式：`RefreshPrivateChat()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPrivateChat();`
- `NationalSpire.ChatHistoryPage<T>.Latest()`；输入表达式：`_groupPages.Latest()`；返回值紧邻使用处：`ExpressionStatementSyntax: _groupPages.Latest();`
- `NationalSpire.ChatHistoryPage<T>.Latest()`；输入表达式：`_privatePages.Latest()`；返回值紧邻使用处：`ExpressionStatementSyntax: _privatePages.Latest();`

**赋值（含属性/字段和局部值）：**

- `_chatNewMessages` = `false`

<a id="symbol-e22063fef4cb"></a>

## `NationalSpire.CareerScreen.BindChatPage(bool) — private void BindChatPage(bool follow)`

来源：源码第 105 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.LatestChatPage()`](ChatHistoryScreen.cs.md#symbol-566a2e34c9dd)；[`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)；[`NationalSpire.CareerScreen.SelectGroup(string, int)`](GroupChatScreen.cs.md#symbol-72d02215d0db)；[`NationalSpire.CareerScreen.SelectPrivate(string, int)`](PrivateMessageScreen.cs.md#symbol-ddace6dd7c79)

**调用：** [`NationalSpire.ChatHistoryPage<T>.Bind(System.Collections.Generic.IReadOnlyList<T>, long, System.Func<T, bool>, bool)`](ChatHistoryPage.cs.md#symbol-b8e49a1a30f0)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._chatNewMessages`；`NationalSpire.CareerScreen._groupPages`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privatePages`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen.CurrentGroup`；`NationalSpire.CareerScreen.GroupTurnVisible(NationalSpire.GroupTurn)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.ChatHistoryPage<T>.Bind(System.Collections.Generic.IReadOnlyList<T>, long, System.Func<T, bool>, bool)`；`NationalSpire.ChatHistoryPage<T>.Count`；`NationalSpire.GroupChat.Revision`；`NationalSpire.GroupChat.Turns`；`NationalSpire.PrivateConversation.MemoryRevision`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.UserDeleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatHistoryPage<T>.Bind(System.Collections.Generic.IReadOnlyList<T>, long, System.Func<T, bool>, bool)`；输入表达式：`_groupPages.Bind(group.Turns, group.Revision, GroupTurnVisible, follow)`；返回值紧邻使用处：`ExpressionStatementSyntax: _groupPages.Bind(group.Turns, group.Revision, GroupTurnVisible, follow);`
- `NationalSpire.ChatHistoryPage<T>.Bind(System.Collections.Generic.IReadOnlyList<T>, long, System.Func<T, bool>, bool)`；输入表达式：`_privatePages.Bind(conversation.Turns, conversation.MemoryRevision, t => !(t.UserDeleted && t.ReplyDeleted), follow)`；返回值紧邻使用处：`ExpressionStatementSyntax: _privatePages.Bind(conversation.Turns, conversation.MemoryRevision, t => !(t.UserDeleted && t.ReplyDeleted), follow);`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(ViewData, _privatePerson)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(ViewData, _privatePerson)`

**赋值（含属性/字段和局部值）：**

- `_chatNewMessages` = `true`
- `previous` = `_groupPages.Count`
- `previous` = `_privatePages.Count`

<a id="symbol-b996e3c9a124"></a>

## `NationalSpire.CareerScreen.GroupTurnVisible(NationalSpire.GroupTurn) — private static bool GroupTurnVisible(GroupTurn turn)`

来源：源码第 122 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.GroupTurn.Attachments`；`NationalSpire.GroupTurn.Effects`；`NationalSpire.GroupTurn.Error`；`NationalSpire.GroupTurn.Notices`；`NationalSpire.GroupTurn.Raw`；`NationalSpire.GroupTurn.Reasoning`；`NationalSpire.GroupTurn.Replies`；`NationalSpire.GroupTurn.Status`；`NationalSpire.GroupTurn.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-62ba7ff64f46"></a>

## `NationalSpire.CareerScreen.RefreshChatPagination() — private void RefreshChatPagination()`

来源：源码第 125 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.FinishChatPage(bool)`](ChatHistoryScreen.cs.md#symbol-7519bc2ca961)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._chatEarlier`；`NationalSpire.CareerScreen._chatLatest`；`NationalSpire.CareerScreen._chatNewer`；`NationalSpire.CareerScreen._chatNewMessages`；`NationalSpire.CareerScreen._chatPageLabel`；`NationalSpire.CareerScreen.ChatAtLatest`；`NationalSpire.CareerScreen.ChatPage`；`NationalSpire.CareerScreen.ChatPageCount`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_chatEarlier!.Disabled` = `ChatPage == 0`
- `_chatLatest!.Text` = `_chatNewMessages ? "最新消息 ●" : "回到最新"`
- `_chatNewer!.Disabled` = `ChatAtLatest`
- `_chatPageLabel!.Text` = `$"{ChatPage + 1} / {ChatPageCount} 页"`

<a id="symbol-7519bc2ca961"></a>

## `NationalSpire.CareerScreen.FinishChatPage(bool) — private void FinishChatPage(bool follow)`

来源：源码第 131 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)

**调用：** [`NationalSpire.CareerScreen.RefreshChatPagination()`](ChatHistoryScreen.cs.md#symbol-62ba7ff64f46)；[`NationalSpire.CareerScreen.ScrollChatTo(int)`](ChatHistoryScreen.cs.md#symbol-b728511cec65)；[`NationalSpire.CareerScreen.ScrollPrivateToBottom()`](PrivateMessageScreen.cs.md#symbol-b2deefc4ba01)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._chatPageScroll`；`NationalSpire.CareerScreen.ChatAtLatest`；`NationalSpire.CareerScreen.RefreshChatPagination()`；`NationalSpire.CareerScreen.ScrollChatTo(int)`；`NationalSpire.CareerScreen.ScrollPrivateToBottom()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.RefreshChatPagination()`；输入表达式：`RefreshChatPagination()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshChatPagination();`
- `NationalSpire.CareerScreen.ScrollChatTo(int)`；输入表达式：`ScrollChatTo(position)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = ScrollChatTo(position)`
- `NationalSpire.CareerScreen.ScrollPrivateToBottom()`；输入表达式：`ScrollPrivateToBottom()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = ScrollPrivateToBottom()`

**赋值（含属性/字段和局部值）：**

- `_` = `ScrollChatTo(position)`
- `_` = `ScrollPrivateToBottom()`
- `_chatPageScroll` = `-1`

<a id="symbol-b728511cec65"></a>

## `NationalSpire.CareerScreen.ScrollChatTo(int) — private async Task ScrollChatTo(int position)`

来源：源码第 138 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Back()`](CareerNavigation.cs.md#symbol-08af62207fef)；[`NationalSpire.CareerScreen.FinishChatPage(bool)`](ChatHistoryScreen.cs.md#symbol-7519bc2ca961)；[`NationalSpire.CareerScreen.RestoreGroupScroll(string, int)`](GroupChatScreen.cs.md#symbol-b8810762e549)；[`NationalSpire.CareerScreen.ScrollPrivateToBottom()`](PrivateMessageScreen.cs.md#symbol-b2deefc4ba01)

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；`Godot.Node.GetTree()`；`Godot.ScrollContainer.GetVScrollBar()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._privateOverlay`；`NationalSpire.CareerScreen._privateScroll`；`NationalSpire.CareerScreen._privateScrollRevision`；`NationalSpire.CareerScreen.ChatDraftKey`；`NationalSpire.CareerScreen.ChatPage`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_privateScroll)`；返回值紧邻使用处：`BinaryExpressionSyntax: revision == _privateScrollRevision && _privateOverlay != null && IsInstanceValid(_privateScroll)`
- `Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；输入表达式：`ToSignal(tree, SceneTree.SignalName.ProcessFrame)`；返回值紧邻使用处：`AwaitExpressionSyntax: await ToSignal(tree, SceneTree.SignalName.ProcessFrame)`
- `Godot.Node.GetTree()`；输入表达式：`GetTree()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetTree()`
- `Godot.ScrollContainer.GetVScrollBar()`；输入表达式：`_privateScroll.GetVScrollBar()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _privateScroll.GetVScrollBar().MaxValue`

**赋值（含属性/字段和局部值）：**

- `_privateScroll!.ScrollVertical` = `position == int.MaxValue ? (int)_privateScroll.GetVScrollBar().MaxValue : position`
