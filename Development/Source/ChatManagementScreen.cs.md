# ChatManagementScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`555A1A5CEB4CAAC2160DD618B2C301ECE06319013CE97770FB21836F70BCF5E2`。来源：[源码](../../ChatManagementScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-99485204d7d6"></a>

## `NationalSpire.CareerScreen.ChatMenuItems(string, bool) — private IEnumerable<(string Title, Action Run)> ChatMenuItems(string id, bool group)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ChatSettingsMenu()`](ChatManagementScreen.cs.md#symbol-282c1fec9c65)；[`NationalSpire.CareerScreen.ShowChatContextMenu(string, bool, Godot.Vector2)`](ChatContextMenuScreen.cs.md#symbol-0f3f090eb3e9)

**调用：** [`NationalSpire.CareerScreen.ChatPinned(string)`](ChatContextMenuScreen.cs.md#symbol-7291798431e8)；[`NationalSpire.CareerScreen.CloseChatContextMenu()`](ChatContextMenuScreen.cs.md#symbol-02269de4e133)；[`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.CareerScreen.GroupMemberPicker(NationalSpire.GroupChat?, System.Action<System.Collections.Generic.List<string>>, bool, string, bool, bool)`](GroupChatScreen.cs.md#symbol-26ccde004356)；[`NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`](ChatManagementScreen.cs.md#symbol-b95040f17d55)；[`NationalSpire.CareerScreen.SelectGroup(string, int)`](GroupChatScreen.cs.md#symbol-72d02215d0db)；[`NationalSpire.CareerScreen.SelectPrivate(string, int)`](PrivateMessageScreen.cs.md#symbol-be8cf79217b4)；[`NationalSpire.CareerScreen.SetChatPinned(string, bool)`](ChatContextMenuScreen.cs.md#symbol-8689933c2c76)；`NationalSpire.GroupCommand.GroupCommand()`；[`Open(System.Action)`](ChatManagementScreen.cs.md#symbol-f889b0a7e3d1)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ChatDraftKey`；`NationalSpire.CareerScreen.ChatManageDialog()`；`NationalSpire.CareerScreen.ChatPinned(string)`；`NationalSpire.CareerScreen.ChatSettingsMenu()`；`NationalSpire.CareerScreen.CloseChatContextMenu()`；`NationalSpire.CareerScreen.CurrentGroup`；`NationalSpire.CareerScreen.ExportChatTranscript()`；`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；`NationalSpire.CareerScreen.GroupMemberPicker(NationalSpire.GroupChat?, System.Action<System.Collections.Generic.List<string>>, bool, string, bool, bool)`；`NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`；`NationalSpire.CareerScreen.PreviewPrivatePrompt()`；`NationalSpire.CareerScreen.PrivateMemory()`；`NationalSpire.CareerScreen.PrivateSettings()`；`NationalSpire.CareerScreen.ProactiveChatDialog()`；`NationalSpire.CareerScreen.RestoreChatDialog()`；`NationalSpire.CareerScreen.SelectGroup(string, int)`；`NationalSpire.CareerScreen.SelectPrivate(string, int)`；`NationalSpire.CareerScreen.SetChatPinned(string, bool)`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.GroupCommand.People`；`Open(System.Action)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.ChatPinned(string)`；输入表达式：`ChatPinned(key)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ChatPinned(key) ? "取消置顶" : "置顶会话"`
- `NationalSpire.CareerScreen.ChatPinned(string)`；输入表达式：`ChatPinned(key)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ChatPinned(key)`
- `NationalSpire.CareerScreen.CloseChatContextMenu()`；输入表达式：`CloseChatContextMenu()`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseChatContextMenu();`
- `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；输入表达式：`GroupCommand("group-add", new() { People = people })`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: people => GroupCommand("group-add", new() { People = people })`
- `NationalSpire.CareerScreen.GroupMemberPicker(NationalSpire.GroupChat?, System.Action<System.Collections.Generic.List<string>>, bool, string, bool, bool)`；输入表达式：`GroupMemberPicker(CurrentGroup!, people => GroupCommand("group-add", new() { People = people }))`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GroupMemberPicker(CurrentGroup!, people => GroupCommand("group-add", new() { People = people }))`
- `NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`；输入表达式：`OpenChatDialog(ChatSettingsMenu, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenChatDialog(ChatSettingsMenu, false);`
- `NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`；输入表达式：`OpenChatDialog(RestoreChatDialog)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenChatDialog(RestoreChatDialog);`
- `NationalSpire.CareerScreen.SelectGroup(string, int)`；输入表达式：`SelectGroup(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectGroup(id);`
- `NationalSpire.CareerScreen.SelectPrivate(string, int)`；输入表达式：`SelectPrivate(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectPrivate(id);`
- `NationalSpire.CareerScreen.SetChatPinned(string, bool)`；输入表达式：`SetChatPinned(key, !ChatPinned(key))`；返回值紧邻使用处：`ExpressionStatementSyntax: SetChatPinned(key, !ChatPinned(key));`
- `NationalSpire.GroupCommand.GroupCommand()`；输入表达式：`new() { People = people }`；返回值紧邻使用处：`ArgumentSyntax: new() { People = people }`
- `Open(System.Action)`；输入表达式：`Open(() => GroupMemberPicker(CurrentGroup!, people => GroupCommand("group-add", new() { People = people })))`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Open(() => GroupMemberPicker(CurrentGroup!, people => GroupCommand("group-add", new() { People = people })))`
- `Open(System.Action)`；输入表达式：`Open(ChatManageDialog)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Open(ChatManageDialog)`
- `Open(System.Action)`；输入表达式：`Open(ExportChatTranscript)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Open(ExportChatTranscript)`
- `Open(System.Action)`；输入表达式：`Open(PreviewPrivatePrompt)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Open(PreviewPrivatePrompt)`
- `Open(System.Action)`；输入表达式：`Open(PrivateMemory)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Open(PrivateMemory)`
- `Open(System.Action)`；输入表达式：`Open(PrivateSettings)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Open(PrivateSettings)`
- `Open(System.Action)`；输入表达式：`Open(ProactiveChatDialog)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Open(ProactiveChatDialog)`

**赋值（含属性/字段和局部值）：**

- `People` = `people`

<a id="symbol-f889b0a7e3d1"></a>

## `Open(System.Action) — void Open(Action action)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ChatMenuItems(string, bool)`](ChatManagementScreen.cs.md#symbol-99485204d7d6)

**调用：** [`NationalSpire.CareerScreen.CloseChatContextMenu()`](ChatContextMenuScreen.cs.md#symbol-02269de4e133)；[`NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`](ChatManagementScreen.cs.md#symbol-b95040f17d55)；[`NationalSpire.CareerScreen.SelectGroup(string, int)`](GroupChatScreen.cs.md#symbol-72d02215d0db)；[`NationalSpire.CareerScreen.SelectPrivate(string, int)`](PrivateMessageScreen.cs.md#symbol-be8cf79217b4)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ChatDraftKey`；`NationalSpire.CareerScreen.CloseChatContextMenu()`；`NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`；`NationalSpire.CareerScreen.SelectGroup(string, int)`；`NationalSpire.CareerScreen.SelectPrivate(string, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.CloseChatContextMenu()`；输入表达式：`CloseChatContextMenu()`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseChatContextMenu();`
- `NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`；输入表达式：`OpenChatDialog(action)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenChatDialog(action);`
- `NationalSpire.CareerScreen.SelectGroup(string, int)`；输入表达式：`SelectGroup(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectGroup(id);`
- `NationalSpire.CareerScreen.SelectPrivate(string, int)`；输入表达式：`SelectPrivate(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectPrivate(id);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-282c1fec9c65"></a>

## `NationalSpire.CareerScreen.ChatSettingsMenu() — private void ChatSettingsMenu()`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.ChatMenuItems(string, bool)`](ChatManagementScreen.cs.md#symbol-99485204d7d6)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.GridContainer.GridContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `(string Title, System.Action Run).Run`；`(string Title, System.Action Run).Title`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen.ChatDraftKey`；`NationalSpire.CareerScreen.ChatMenuItems(string, bool)`；`NationalSpire.CareerScreen.CurrentGroup`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Name`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("h_separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("h_separation", 14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`grid.AddThemeConstantOverride("v_separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddThemeConstantOverride("v_separation", 14);`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new GridContainer { Columns = 2 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GridContainer { Columns = 2 }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(grid)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(grid);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(g == null ? "当前私聊 · " + GroupChats.Name(ViewData, _privatePerson) : "当前群聊 · " + g.Name, 18, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(g == null ? "当前私聊 · " + GroupChats.Name(ViewData, _privatePerson) : "当前群聊 · " + g.Name, 18, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`grid.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: grid.AddChild(button);`
- `NationalSpire.CareerScreen.ChatMenuItems(string, bool)`；输入表达式：`ChatMenuItems(g?.Id ?? _privatePerson, g != null)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var item in ChatMenuItems(g?.Id ?? _privatePerson, g != null))             {                 var button = PrivateButton(item.Title, item.Run, 260); button.SizeFlagsHorizontal = SizeFlags.ExpandFill; grid.AddChild(button);             }`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton(item.Title, item.Run, 260)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton(item.Title, item.Run, 260)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("通讯设置", "", () => true, "关闭", box =>         {             if (ChatDraftKey.Length > 0)                 box.AddChild(Text(g == null ? "当前私聊 · " + GroupChats.Name(ViewData, _privatePerson) : "当前群聊 · " + g.Name, 18, _muted));             var grid = new GridContainer { Columns = 2 }; grid.AddThemeConstantOverride("h_separation", 14); grid.AddThemeConstantOverride("v_separation", 14); box.AddChild(grid);             foreach (var item in ChatMenuItems(g?.Id ?? _privatePerson, g != null))             {                 var button = PrivateButton(item.Title, item.Run, 260); button.SizeFlagsHorizontal = SizeFlags.ExpandFill; grid.AddChild(button);             }         }, showCancel: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("通讯设置", "", () => true, "关闭", box =>         {             if (ChatDraftKey.Length > 0)                 box.AddChild(Text(g == null ? "当前私聊 · " + GroupChats.Name(ViewData, _privatePerson) : "当前群聊 · " + g.Name, 18, _muted));             var grid = new GridContainer { Columns = 2 }; grid.AddThemeConstantOverride("h_separation", 14); grid.AddThemeConstantOverride("v_separation", 14); box.AddChild(grid);             foreach (var item in ChatMenuItems(g?.Id ?? _privatePerson, g != null))             {                 var button = PrivateButton(item.Title, item.Run, 260); button.SizeFlagsHorizontal = SizeFlags.ExpandFill; grid.AddChild(button);             }         }, showCancel: false);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(g == null ? "当前私聊 · " + GroupChats.Name(ViewData, _privatePerson) : "当前群聊 · " + g.Name, 18, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(g == null ? "当前私聊 · " + GroupChats.Name(ViewData, _privatePerson) : "当前群聊 · " + g.Name, 18, _muted)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(ViewData, _privatePerson)`；返回值紧邻使用处：`BinaryExpressionSyntax: "当前私聊 · " + GroupChats.Name(ViewData, _privatePerson)`

**赋值（含属性/字段和局部值）：**

- `button.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Columns` = `2`

<a id="symbol-785feea0fa06"></a>

## `NationalSpire.CareerScreen.ChatManageDialog() — private void ChatManageDialog()`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`Choice(string, string, System.Action)`](ChatManagementScreen.cs.md#symbol-a4a2fa95a8a3)；[`NationalSpire.CareerScreen.ConfirmChatRemoval(bool)`](ChatManagementScreen.cs.md#symbol-0e0563dae4b1)；[`NationalSpire.CareerScreen.ConfirmKick(string, bool)`](ChatManagementScreen.cs.md#symbol-93a2414720c3)；[`NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`](ChatManagementScreen.cs.md#symbol-b95040f17d55)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；[`Rename()`](ChatManagementScreen.cs.md#symbol-f30827c9dfc2)；`Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.ScrollContainer.ScrollContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `Choice(string, string, System.Action)`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.ConfirmChatRemoval(bool)`；`NationalSpire.CareerScreen.ConfirmKick(string, bool)`；`NationalSpire.CareerScreen.CurrentGroup`；`NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupChat.Name`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`Rename()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Choice(string, string, System.Action)`；输入表达式：`Choice(g == null ? "删除私聊及其全部记忆" : "删除群聊及其全部记忆", "清除这段会话的记录、总结和上下文来源；已发生的游戏结果继续保留。", () => ConfirmChatRemoval(true))`；返回值紧邻使用处：`ExpressionStatementSyntax: Choice(g == null ? "删除私聊及其全部记忆" : "删除群聊及其全部记忆", "清除这段会话的记录、总结和上下文来源；已发生的游戏结果继续保留。", () => ConfirmChatRemoval(true));`
- `Choice(string, string, System.Action)`；输入表达式：`Choice(g == null ? "隐藏私聊" : "解散群聊", "保留聊天记录，可在恢复会话中重新打开。", () => ConfirmChatRemoval(false))`；返回值紧邻使用处：`ExpressionStatementSyntax: Choice(g == null ? "隐藏私聊" : "解散群聊", "保留聊天记录，可在恢复会话中重新打开。", () => ConfirmChatRemoval(false));`
- `Godot.Color.Color(string)`；输入表达式：`new Color("ee929d")`；返回值紧邻使用处：`ArgumentSyntax: new Color("ee929d")`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 12);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = "GroupRenameInput", Text = g.Name, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 44) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LineEdit { Name = "GroupRenameInput", Text = g.Name, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 44) }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(error)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(error);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("群聊名称", 16, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("群聊名称", 16, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`members.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: members.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(input)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(input);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(name)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(name);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateButton("移出并删除其群聊记忆", () => OpenChatDialog(() => ConfirmKick(person, true)), 230))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateButton("移出并删除其群聊记忆", () => OpenChatDialog(() => ConfirmKick(person, true)), 230));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateButton("移出群聊", () => OpenChatDialog(() => ConfirmKick(person, false)), 110))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateButton("移出群聊", () => OpenChatDialog(() => ConfirmKick(person, false)), 110));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(saveName)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(saveName);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(members)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(members);`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer { CustomMinimumSize = new(0, Math.Min(320, (g.Members.Count - 1) * 54)), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ScrollContainer { CustomMinimumSize = new(0, Math.Min(320, (g.Members.Count - 1) * 54)), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 44)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 44)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, Math.Min(320, (g.Members.Count - 1) * 54))`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, Math.Min(320, (g.Members.Count - 1) * 54))`
- `NationalSpire.CareerScreen.ConfirmChatRemoval(bool)`；输入表达式：`ConfirmChatRemoval(false)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ConfirmChatRemoval(false)`
- `NationalSpire.CareerScreen.ConfirmChatRemoval(bool)`；输入表达式：`ConfirmChatRemoval(true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ConfirmChatRemoval(true)`
- `NationalSpire.CareerScreen.ConfirmKick(string, bool)`；输入表达式：`ConfirmKick(person, false)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ConfirmKick(person, false)`
- `NationalSpire.CareerScreen.ConfirmKick(string, bool)`；输入表达式：`ConfirmKick(person, true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ConfirmKick(person, true)`
- `NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`；输入表达式：`OpenChatDialog(() => ConfirmKick(person, false))`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenChatDialog(() => ConfirmKick(person, false))`
- `NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`；输入表达式：`OpenChatDialog(() => ConfirmKick(person, true))`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenChatDialog(() => ConfirmKick(person, true))`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("保存名称", Rename, 110)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton("保存名称", Rename, 110)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("移出并删除其群聊记忆", () => OpenChatDialog(() => ConfirmKick(person, true)), 230)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("移出并删除其群聊记忆", () => OpenChatDialog(() => ConfirmKick(person, true)), 230)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("移出群聊", () => OpenChatDialog(() => ConfirmKick(person, false)), 110)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("移出群聊", () => OpenChatDialog(() => ConfirmKick(person, false)), 110)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog(g == null ? "管理私聊" : "管理群聊", "", () => true, "完成", box =>         {             if (g != null)             {                 box.AddChild(Text("群聊名称", 16, _muted));                 var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); box.AddChild(row);                 var input = new LineEdit { Name = "GroupRenameInput", Text = g.Name, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 44) };                 row.AddChild(input);                 var error = Text("", 15, new Color("ee929d")); error.Visible = false;                 void Rename()                 {                     error.Visible = string.IsNullOrWhiteSpace(input.Text);                     if (error.Visible) { error.Text = "请填写群聊名称。"; input.GrabFocus(); return; }                     GroupCommand("group-rename", new() { Text = input.Text }, () => OpenChatDialog(ChatManageDialog));                 }                 var saveName = PrivateButton("保存名称", Rename, 110); saveName.SizeFlagsVertical = SizeFlags.Fill; row.AddChild(saveName);                 input.TextChanged += _ => error.Visible = false;                 input.TextSubmitted += _ => Rename(); box.AddChild(error);             }             void Choice(string title, string detail, Action action)             {                 var button = PrivateButton(title, () => OpenChatDialog(action), 0); box.AddChild(button);                 box.AddChild(Text(detail, 15, _muted));             }             Choice(g == null ? "隐藏私聊" : "解散群聊", "保留聊天记录，可在恢复会话中重新打开。", () => ConfirmChatRemoval(false));             Choice(g == null ? "删除私聊及其全部记忆" : "删除群聊及其全部记忆", "清除这段会话的记录、总结和上下文来源；已发生的游戏结果继续保留。", () => ConfirmChatRemoval(true));             if (g != null)             {                 var scroll = new ScrollContainer { CustomMinimumSize = new(0, Math.Min(320, (g.Members.Count - 1) * 54)), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled };                 var members = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };                 scroll.AddChild(members); box.AddChild(scroll);                 foreach (string id in g.Members.Where(id => id != GroupChats.Human(ViewData)))                 {                     string person = id;                     var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); members.AddChild(row);                     var name = Text(GroupChats.Name(ViewData, person), 18, _ink); name.SizeFlagsHorizontal = SizeFlags.ExpandFill; row.AddChild(name);                     row.AddChild(PrivateButton("移出群聊", () => OpenChatDialog(() => ConfirmKick(person, false)), 110));                     row.AddChild(PrivateButton("移出并删除其群聊记忆", () => OpenChatDialog(() => ConfirmKick(person, true)), 230));                 }             }         })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog(g == null ? "管理私聊" : "管理群聊", "", () => true, "完成", box =>         {             if (g != null)             {                 box.AddChild(Text("群聊名称", 16, _muted));                 var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); box.AddChild(row);                 var input = new LineEdit { Name = "GroupRenameInput", Text = g.Name, SizeFlagsHorizontal = SizeFlags.ExpandFill, CustomMinimumSize = new(0, 44) };                 row.AddChild(input);                 var error = Text("", 15, new Color("ee929d")); error.Visible = false;                 void Rename()                 {                     error.Visible = string.IsNullOrWhiteSpace(input.Text);                     if (error.Visible) { error.Text = "请填写群聊名称。"; input.GrabFocus(); return; }                     GroupCommand("group-rename", new() { Text = input.Text }, () => OpenChatDialog(ChatManageDialog));                 }                 var saveName = PrivateButton("保存名称", Rename, 110); saveName.SizeFlagsVertical = SizeFlags.Fill; row.AddChild(saveName);                 input.TextChanged += _ => error.Visible = false;                 input.TextSubmitted += _ => Rename(); box.AddChild(error);             }             void Choice(string title, string detail, Action action)             {                 var button = PrivateButton(title, () => OpenChatDialog(action), 0); box.AddChild(button);                 box.AddChild(Text(detail, 15, _muted));             }             Choice(g == null ? "隐藏私聊" : "解散群聊", "保留聊天记录，可在恢复会话中重新打开。", () => ConfirmChatRemoval(false));             Choice(g == null ? "删除私聊及其全部记忆" : "删除群聊及其全部记忆", "清除这段会话的记录、总结和上下文来源；已发生的游戏结果继续保留。", () => ConfirmChatRemoval(true));             if (g != null)             {                 var scroll = new ScrollContainer { CustomMinimumSize = new(0, Math.Min(320, (g.Members.Count - 1) * 54)), HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled };                 var members = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill };                 scroll.AddChild(members); box.AddChild(scroll);                 foreach (string id in g.Members.Where(id => id != GroupChats.Human(ViewData)))                 {                     string person = id;                     var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); members.AddChild(row);                     var name = Text(GroupChats.Name(ViewData, person), 18, _ink); name.SizeFlagsHorizontal = SizeFlags.ExpandFill; row.AddChild(name);                     row.AddChild(PrivateButton("移出群聊", () => OpenChatDialog(() => ConfirmKick(person, false)), 110));                     row.AddChild(PrivateButton("移出并删除其群聊记忆", () => OpenChatDialog(() => ConfirmKick(person, true)), 230));                 }             }         });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 15, new Color("ee929d"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("", 15, new Color("ee929d"))`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("群聊名称", 16, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("群聊名称", 16, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(GroupChats.Name(ViewData, person), 18, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(GroupChats.Name(ViewData, person), 18, _ink)`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(ViewData)`；返回值紧邻使用处：`BinaryExpressionSyntax: id != GroupChats.Human(ViewData)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(ViewData, person)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Name(ViewData, person)`
- `Rename()`；输入表达式：`Rename()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => Rename()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Members.Where(id => id != GroupChats.Human(ViewData))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string id in g.Members.Where(id => id != GroupChats.Human(ViewData)))                 {                     string person = id;                     var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 12); members.AddChild(row);                     var name = Text(GroupChats.Name(ViewData, person), 18, _ink); name.SizeFlagsHorizontal = SizeFlags.ExpandFill; row.AddChild(name);                     row.AddChild(PrivateButton("移出群聊", () => OpenChatDialog(() => ConfirmKick(person, false)), 110));                     row.AddChild(PrivateButton("移出并删除其群聊记忆", () => OpenChatDialog(() => ConfirmKick(person, true)), 230));                 }`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(320, (g.Members.Count - 1) * 54)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(320, (g.Members.Count - 1) * 54)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(0, 44)`
- `CustomMinimumSize` = `new(0, Math.Min(320, (g.Members.Count - 1) * 54))`
- `error.Visible` = `false`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `input.TextChanged` += `_ => error.Visible = false`
- `input.TextSubmitted` += `_ => Rename()`
- `name.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Name` = `"GroupRenameInput"`
- `saveName.SizeFlagsVertical` = `SizeFlags.Fill`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Text` = `g.Name`

<a id="symbol-f30827c9dfc2"></a>

## `Rename() — void Rename()`

来源：源码第 64 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ChatManageDialog()`](ChatManagementScreen.cs.md#symbol-785feea0fa06)

**调用：** [`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`](ChatManagementScreen.cs.md#symbol-b95040f17d55)；`Godot.Control.GrabFocus()`；`NationalSpire.GroupCommand.GroupCommand()`；`string.IsNullOrWhiteSpace(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ChatManageDialog()`；`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；`NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`；`NationalSpire.GroupCommand.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.GrabFocus()`；输入表达式：`input.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: input.GrabFocus();`
- `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；输入表达式：`GroupCommand("group-rename", new() { Text = input.Text }, () => OpenChatDialog(ChatManageDialog))`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupCommand("group-rename", new() { Text = input.Text }, () => OpenChatDialog(ChatManageDialog));`
- `NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`；输入表达式：`OpenChatDialog(ChatManageDialog)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenChatDialog(ChatManageDialog)`
- `NationalSpire.GroupCommand.GroupCommand()`；输入表达式：`new() { Text = input.Text }`；返回值紧邻使用处：`ArgumentSyntax: new() { Text = input.Text }`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(input.Text)`；返回值紧邻使用处：`AssignmentExpressionSyntax: error.Visible = string.IsNullOrWhiteSpace(input.Text)`

**赋值（含属性/字段和局部值）：**

- `error.Text` = `"请填写群聊名称。"`
- `error.Visible` = `string.IsNullOrWhiteSpace(input.Text)`
- `Text` = `input.Text`

<a id="symbol-a4a2fa95a8a3"></a>

## `Choice(string, string, System.Action) — void Choice(string title, string detail, Action action)`

来源：源码第 74 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ChatManageDialog()`](ChatManagementScreen.cs.md#symbol-785feea0fa06)

**调用：** [`NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`](ChatManagementScreen.cs.md#symbol-b95040f17d55)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(button);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(detail, 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(detail, 15, _muted));`
- `NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`；输入表达式：`OpenChatDialog(action)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenChatDialog(action)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton(title, () => OpenChatDialog(action), 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton(title, () => OpenChatDialog(action), 0)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(detail, 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(detail, 15, _muted)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b95040f17d55"></a>

## `NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool) — private void OpenChatDialog(Action action, bool returnToSettings = true)`

来源：源码第 97 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Choice(string, string, System.Action)`](ChatManagementScreen.cs.md#symbol-a4a2fa95a8a3)；[`NationalSpire.CareerScreen.ChatManageDialog()`](ChatManagementScreen.cs.md#symbol-785feea0fa06)；[`NationalSpire.CareerScreen.ChatMenuItems(string, bool)`](ChatManagementScreen.cs.md#symbol-99485204d7d6)；[`NationalSpire.CareerScreen.ConfirmKick(string, bool)`](ChatManagementScreen.cs.md#symbol-93a2414720c3)；[`NationalSpire.CareerScreen.GroupMemory()`](GroupChatDialogs.cs.md#symbol-bf729ae9b3eb)；[`NationalSpire.CareerScreen.PrivateMemory()`](PrivateMemoryScreen.cs.md#symbol-942a4a496637)；[`Open(System.Action)`](ChatManagementScreen.cs.md#symbol-f889b0a7e3d1)；[`Rename()`](ChatManagementScreen.cs.md#symbol-f30827c9dfc2)；[`Section(string)`](PrivateMemoryScreen.cs.md#symbol-3776534c6c5a)

**调用：** `Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._openingDialogReturn`；`NationalSpire.CareerScreen._privateOverlay`；`NationalSpire.CareerScreen.ChatSettingsMenu()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(() =>         {             if (_privateOverlay == null) return;             _openingDialogReturn = returnToSettings ? ChatSettingsMenu : null;             try { action(); }             finally { _openingDialogReturn = null; }         }).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(() =>         {             if (_privateOverlay == null) return;             _openingDialogReturn = returnToSettings ? ChatSettingsMenu : null;             try { action(); }             finally { _openingDialogReturn = null; }         }).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(() =>         {             if (_privateOverlay == null) return;             _openingDialogReturn = returnToSettings ? ChatSettingsMenu : null;             try { action(); }             finally { _openingDialogReturn = null; }         })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(() =>         {             if (_privateOverlay == null) return;             _openingDialogReturn = returnToSettings ? ChatSettingsMenu : null;             try { action(); }             finally { _openingDialogReturn = null; }         }).CallDeferred`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`
- `System.Action.Invoke()`；输入表达式：`action()`；返回值紧邻使用处：`ExpressionStatementSyntax: action();`

**赋值（含属性/字段和局部值）：**

- `_openingDialogReturn` = `null`
- `_openingDialogReturn` = `returnToSettings ? ChatSettingsMenu : null`

<a id="symbol-93a2414720c3"></a>

## `NationalSpire.CareerScreen.ConfirmKick(string, bool) — private void ConfirmKick(string person, bool forget)`

来源：源码第 108 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ChatManageDialog()`](ChatManagementScreen.cs.md#symbol-785feea0fa06)

**调用：** [`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`](ChatManagementScreen.cs.md#symbol-b95040f17d55)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；`NationalSpire.GroupCommand.GroupCommand()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._privateOverlay`；`NationalSpire.CareerScreen.ChatManageDialog()`；`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；`NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.GroupCommand.People`；`NationalSpire.GroupCommand.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；输入表达式：`GroupCommand("group-manage", new() { Text = forget ? "kick-forget" : "kick", People = [person] },                     () => { if (_dialogOverlay == dialog && _privateOverlay != null) OpenChatDialog(ChatManageDialog); })`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupCommand("group-manage", new() { Text = forget ? "kick-forget" : "kick", People = [person] },                     () => { if (_dialogOverlay == dialog && _privateOverlay != null) OpenChatDialog(ChatManageDialog); });`
- `NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`；输入表达式：`OpenChatDialog(ChatManageDialog)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenChatDialog(ChatManageDialog);`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("移出 " + GroupChats.Name(ViewData, person), forget ? "将这位成员移出群聊，并清除其从本群读取的聊天记录、总结及上下文来源。" : "这位成员保留离开前的群聊记忆。",             () =>             {                 var dialog = _dialogOverlay;                 GroupCommand("group-manage", new() { Text = forget ? "kick-forget" : "kick", People = [person] },                     () => { if (_dialogOverlay == dialog && _privateOverlay != null) OpenChatDialog(ChatManageDialog); });                 return false;             }, "确定")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ShowCareerDialog("移出 " + GroupChats.Name(ViewData, person), forget ? "将这位成员移出群聊，并清除其从本群读取的聊天记录、总结及上下文来源。" : "这位成员保留离开前的群聊记忆。",             () =>             {                 var dialog = _dialogOverlay;                 GroupCommand("group-manage", new() { Text = forget ? "kick-forget" : "kick", People = [person] },                     () => { if (_dialogOverlay == dialog && _privateOverlay != null) OpenChatDialog(ChatManageDialog); });                 return false;             }, "确定")`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(ViewData, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: "移出 " + GroupChats.Name(ViewData, person)`
- `NationalSpire.GroupCommand.GroupCommand()`；输入表达式：`new() { Text = forget ? "kick-forget" : "kick", People = [person] }`；返回值紧邻使用处：`ArgumentSyntax: new() { Text = forget ? "kick-forget" : "kick", People = [person] }`

**赋值（含属性/字段和局部值）：**

- `People` = `[person]`
- `Text` = `forget ? "kick-forget" : "kick"`

<a id="symbol-0e0563dae4b1"></a>

## `NationalSpire.CareerScreen.ConfirmChatRemoval(bool) — private void ConfirmChatRemoval(bool forget)`

来源：源码第 117 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ChatManageDialog()`](ChatManagementScreen.cs.md#symbol-785feea0fa06)

**调用：** [`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；`NationalSpire.GroupCommand.GroupCommand()`；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.CurrentGroup`；`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.GroupChat.Name`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.GroupCommand.Text`；`NationalSpire.PrivateMessageCommand.Part`；`Removed()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；输入表达式：`GroupCommand("group-manage", new() { Text = forget ? "forget" : "hide" }, Removed)`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupCommand("group-manage", new() { Text = forget ? "forget" : "hide" }, Removed);`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-manage", new() { Part = forget ? "forget" : "hide" }, Removed)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-manage", new() { Part = forget ? "forget" : "hide" }, Removed);`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog(forget ? CurrentGroup == null ? "删除私聊及其全部记忆" : "删除群聊及其全部记忆" : CurrentGroup == null ? "隐藏私聊" : "解散群聊", forget ? (CurrentGroup == null ? "删除与" + GroupChats.Name(ViewData, _privatePerson) + "的私聊" : "删除群聊《" + CurrentGroup.Name + "》及现任、已离群成员对本群的记忆") + "，清除聊天记录、总结及上下文来源。已经生效的合同、活动、训练及关系继续保留。" : "记录和总结保留在恢复会话中。", () => { void Removed() { if (forget && ChatPinned(ChatDraftKey)) SetChatPinned(ChatDraftKey, false); _privateGroup = _privatePerson = ""; _privateListSignature = ""; CareerVisuals.ClearContent(_privateHeading!); CareerVisuals.ClearContent(_privateBody!); RefreshPrivateList(); } if (CurrentGroup != null) GroupCommand("group-manage", new() { Text = forget ? "forget" : "hide" }, Removed); else PrivateCommand("dm-manage", new() { Part = forget ? "forget" : "hide" }, Removed); return true; }, forget ? "清除并删除" : "确定")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ShowCareerDialog(forget ? CurrentGroup == null ? "删除私聊及其全部记忆" : "删除群聊及其全部记忆" : CurrentGroup == null ? "隐藏私聊" : "解散群聊", forget ? (CurrentGroup == null ? "删除与" + GroupChats.Name(ViewData, _privatePerson) + "的私聊" : "删除群聊《" + CurrentGroup.Name + "》及现任、已离群成员对本群的记忆") + "，清除聊天记录、总结及上下文来源。已经生效的合同、活动、训练及关系继续保留。" : "记录和总结保留在恢复会话中。", () => { void Removed() { if (forget && ChatPinned(ChatDraftKey)) SetChatPinned(ChatDraftKey, false); _privateGroup = _privatePerson = ""; _privateListSignature = ""; CareerVisuals.ClearContent(_privateHeading!); CareerVisuals.ClearContent(_privateBody!); RefreshPrivateList(); } if (CurrentGroup != null) GroupCommand("group-manage", new() { Text = forget ? "forget" : "hide" }, Removed); else PrivateCommand("dm-manage", new() { Part = forget ? "forget" : "hide" }, Removed); return true; }, forget ? "清除并删除" : "确定")`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(ViewData, _privatePerson)`；返回值紧邻使用处：`BinaryExpressionSyntax: "删除与" + GroupChats.Name(ViewData, _privatePerson)`
- `NationalSpire.GroupCommand.GroupCommand()`；输入表达式：`new() { Text = forget ? "forget" : "hide" }`；返回值紧邻使用处：`ArgumentSyntax: new() { Text = forget ? "forget" : "hide" }`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Part = forget ? "forget" : "hide" }`；返回值紧邻使用处：`ArgumentSyntax: new() { Part = forget ? "forget" : "hide" }`

**赋值（含属性/字段和局部值）：**

- `Part` = `forget ? "forget" : "hide"`
- `Text` = `forget ? "forget" : "hide"`

<a id="symbol-0702711e2eee"></a>

## `Removed() — void Removed()`

来源：源码第 121 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.ChatPinned(string)`](ChatContextMenuScreen.cs.md#symbol-7291798431e8)；[`NationalSpire.CareerScreen.RefreshPrivateList()`](PrivateMessageScreen.cs.md#symbol-fca825e025fa)；[`NationalSpire.CareerScreen.SetChatPinned(string, bool)`](ChatContextMenuScreen.cs.md#symbol-8689933c2c76)；[`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`](CareerVisuals.cs.md#symbol-561d8fe38106)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._privateBody`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privateHeading`；`NationalSpire.CareerScreen._privateListSignature`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen.ChatDraftKey`；`NationalSpire.CareerScreen.ChatPinned(string)`；`NationalSpire.CareerScreen.RefreshPrivateList()`；`NationalSpire.CareerScreen.SetChatPinned(string, bool)`；`NationalSpire.CareerVisuals.ClearContent(Godot.Node)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.ChatPinned(string)`；输入表达式：`ChatPinned(ChatDraftKey)`；返回值紧邻使用处：`BinaryExpressionSyntax: forget && ChatPinned(ChatDraftKey)`
- `NationalSpire.CareerScreen.RefreshPrivateList()`；输入表达式：`RefreshPrivateList()`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPrivateList();`
- `NationalSpire.CareerScreen.SetChatPinned(string, bool)`；输入表达式：`SetChatPinned(ChatDraftKey, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetChatPinned(ChatDraftKey, false);`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(_privateBody!)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(_privateBody!);`
- `NationalSpire.CareerVisuals.ClearContent(Godot.Node)`；输入表达式：`CareerVisuals.ClearContent(_privateHeading!)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerVisuals.ClearContent(_privateHeading!);`

**赋值（含属性/字段和局部值）：**

- `_privateGroup` = `_privatePerson = ""`
- `_privateListSignature` = `""`
- `_privatePerson` = `""`

<a id="symbol-812702bacb1e"></a>

## `NationalSpire.CareerScreen.RestoreChatDialog() — private void RestoreChatDialog()`

来源：源码第 131 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；[`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.SelectGroup(string, int)`](GroupChatScreen.cs.md#symbol-72d02215d0db)；[`NationalSpire.CareerScreen.SelectPrivate(string, int)`](PrivateMessageScreen.cs.md#symbol-be8cf79217b4)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；`NationalSpire.GroupCommand.GroupCommand()`；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`System.Action.Invoke()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；`NationalSpire.CareerScreen.SelectGroup(string, int)`；`NationalSpire.CareerScreen.SelectPrivate(string, int)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.GroupChat.Dissolved`；`NationalSpire.GroupChat.Forgotten`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupChat.Name`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.GroupCommand.Text`；`NationalSpire.PrivateConversation.Forgotten`；`NationalSpire.PrivateConversation.Hidden`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessageCommand.Part`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateButton(GroupChats.Name(d, id), () => { _privatePerson = id; PrivateCommand("dm-manage", new() { Part = "restore" }, () => { _cancelDialog?.Invoke(); SelectPrivate(id); }); }, 0))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateButton(GroupChats.Name(d, id), () => { _privatePerson = id; PrivateCommand("dm-manage", new() { Part = "restore" }, () => { _cancelDialog?.Invoke(); SelectPrivate(id); }); }, 0));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateButton(g.Name, () => { _privateGroup = id; GroupCommand("group-manage", new() { Text = "restore" }, () => { _cancelDialog?.Invoke(); SelectGroup(id); }); }, 0))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateButton(g.Name, () => { _privateGroup = id; GroupCommand("group-manage", new() { Text = "restore" }, () => { _cancelDialog?.Invoke(); SelectGroup(id); }); }, 0));`
- `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；输入表达式：`GroupCommand("group-manage", new() { Text = "restore" }, () => { _cancelDialog?.Invoke(); SelectGroup(id); })`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupCommand("group-manage", new() { Text = "restore" }, () => { _cancelDialog?.Invoke(); SelectGroup(id); });`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton(GroupChats.Name(d, id), () => { _privatePerson = id; PrivateCommand("dm-manage", new() { Part = "restore" }, () => { _cancelDialog?.Invoke(); SelectPrivate(id); }); }, 0)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton(GroupChats.Name(d, id), () => { _privatePerson = id; PrivateCommand("dm-manage", new() { Part = "restore" }, () => { _cancelDialog?.Invoke(); SelectPrivate(id); }); }, 0)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton(g.Name, () => { _privateGroup = id; GroupCommand("group-manage", new() { Text = "restore" }, () => { _cancelDialog?.Invoke(); SelectGroup(id); }); }, 0)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton(g.Name, () => { _privateGroup = id; GroupCommand("group-manage", new() { Text = "restore" }, () => { _cancelDialog?.Invoke(); SelectGroup(id); }); }, 0)`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-manage", new() { Part = "restore" }, () => { _cancelDialog?.Invoke(); SelectPrivate(id); })`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-manage", new() { Part = "restore" }, () => { _cancelDialog?.Invoke(); SelectPrivate(id); });`
- `NationalSpire.CareerScreen.SelectGroup(string, int)`；输入表达式：`SelectGroup(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectGroup(id);`
- `NationalSpire.CareerScreen.SelectPrivate(string, int)`；输入表达式：`SelectPrivate(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectPrivate(id);`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("恢复会话", "选择一段保留的会话。", () => true, "完成", box => { foreach (var c in PrivateMessages.Mailbox(d).Conversations.Values.Where(c => c.Hidden && !c.Forgotten)) { string id = c.PersonId; box.AddChild(PrivateButton(GroupChats.Name(d, id), () => { _privatePerson = id; PrivateCommand("dm-manage", new() { Part = "restore" }, () => { _cancelDialog?.Invoke(); SelectPrivate(id); }); }, 0)); } foreach (var g in d.Chats.Groups.Where(g => g.Dissolved && !g.Forgotten && g.Members.Contains(GroupChats.Human(d)))) { string id = g.Id; box.AddChild(PrivateButton(g.Name, () => { _privateGroup = id; GroupCommand("group-manage", new() { Text = "restore" }, () => { _cancelDialog?.Invoke(); SelectGroup(id); }); }, 0)); } })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("恢复会话", "选择一段保留的会话。", () => true, "完成", box => { foreach (var c in PrivateMessages.Mailbox(d).Conversations.Values.Where(c => c.Hidden && !c.Forgotten)) { string id = c.PersonId; box.AddChild(PrivateButton(GroupChats.Name(d, id), () => { _privatePerson = id; PrivateCommand("dm-manage", new() { Part = "restore" }, () => { _cancelDialog?.Invoke(); SelectPrivate(id); }); }, 0)); } foreach (var g in d.Chats.Groups.Where(g => g.Dissolved && !g.Forgotten && g.Members.Contains(GroupChats.Human(d)))) { string id = g.Id; box.AddChild(PrivateButton(g.Name, () => { _privateGroup = id; GroupCommand("group-manage", new() { Text = "restore" }, () => { _cancelDialog?.Invoke(); SelectGroup(id); }); }, 0)); } });`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(d)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Human(d)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, id)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Name(d, id)`
- `NationalSpire.GroupCommand.GroupCommand()`；输入表达式：`new() { Text = "restore" }`；返回值紧邻使用处：`ArgumentSyntax: new() { Text = "restore" }`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Part = "restore" }`；返回值紧邻使用处：`ArgumentSyntax: new() { Part = "restore" }`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(d).Conversations`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _cancelDialog?.Invoke()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Mailbox(d).Conversations.Values.Where(c => c.Hidden && !c.Forgotten)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var c in PrivateMessages.Mailbox(d).Conversations.Values.Where(c => c.Hidden && !c.Forgotten)) { string id = c.PersonId; box.AddChild(PrivateButton(GroupChats.Name(d, id), () => { _privatePerson = id; PrivateCommand("dm-manage", new() { Part = "restore" }, () => { _cancelDialog?.Invoke(); SelectPrivate(id); }); }, 0)); }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Chats.Groups.Where(g => g.Dissolved && !g.Forgotten && g.Members.Contains(GroupChats.Human(d)))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var g in d.Chats.Groups.Where(g => g.Dissolved && !g.Forgotten && g.Members.Contains(GroupChats.Human(d)))) { string id = g.Id; box.AddChild(PrivateButton(g.Name, () => { _privateGroup = id; GroupCommand("group-manage", new() { Text = "restore" }, () => { _cancelDialog?.Invoke(); SelectGroup(id); }); }, 0)); }`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`g.Members.Contains(GroupChats.Human(d))`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Dissolved && !g.Forgotten && g.Members.Contains(GroupChats.Human(d))`

**赋值（含属性/字段和局部值）：**

- `Part` = `"restore"`
- `Text` = `"restore"`
- `_privateGroup` = `id`
- `_privatePerson` = `id`

<a id="symbol-f9397f5fb6b7"></a>

## `NationalSpire.CareerScreen.ProactiveChatDialog() — private void ProactiveChatDialog()`

来源：源码第 148 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`Field(string, int, int, int, string)`](ChatManagementScreen.cs.md#symbol-0d6f466af00f)；`Godot.CheckBox.CheckBox()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；[`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`](CareerDialog.cs.md#symbol-a5c0e10d12c8)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；`NationalSpire.GroupCommand.GroupCommand()`；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`NationalSpire.ProactiveChatSettings.ProactiveChatSettings()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `Field(string, int, int, int, string)`；`NationalSpire.CareerScreen.CurrentGroup`；`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.GroupChat.Proactive`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.GroupCommand.Proactive`；`NationalSpire.PrivateConversation.Proactive`；`NationalSpire.PrivateMessageCommand.Proactive`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.ProactiveChatSettings.DayChance`；`NationalSpire.ProactiveChatSettings.Enabled`；`NationalSpire.ProactiveChatSettings.EventChance`；`NationalSpire.ProactiveChatSettings.FinalAlwaysReply`；`NationalSpire.ProactiveChatSettings.MatchChance`；`NationalSpire.ProactiveChatSettings.Unanswered`；`NationalSpire.ProactiveChatSettings.UnansweredLimit`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Field(string, int, int, int, string)`；输入表达式：`Field("平常过日联系概率", current.DayChance, 0, 100, "%")`；返回值紧邻使用处：`AssignmentExpressionSyntax: days = Field("平常过日联系概率", current.DayChance, 0, 100, "%")`
- `Field(string, int, int, int, string)`；输入表达式：`Field("相关事件联系概率", current.EventChance, 0, 100, "%")`；返回值紧邻使用处：`AssignmentExpressionSyntax: events = Field("相关事件联系概率", current.EventChance, 0, 100, "%")`
- `Field(string, int, int, int, string)`；输入表达式：`Field("赛后联系概率", current.MatchChance, 0, 100, "%")`；返回值紧邻使用处：`AssignmentExpressionSyntax: match = Field("赛后联系概率", current.MatchChance, 0, 100, "%")`
- `Field(string, int, int, int, string)`；输入表达式：`Field("连续几轮后等待回应", current.UnansweredLimit, 1, int.MaxValue, "轮")`；返回值紧邻使用处：`AssignmentExpressionSyntax: unanswered = Field("连续几轮后等待回应", current.UnansweredLimit, 1, int.MaxValue, "轮")`
- `Godot.CheckBox.CheckBox()`；输入表达式：`new CheckBox { Text = "允许主动联系", ButtonPressed = current.Enabled }`；返回值紧邻使用处：`AssignmentExpressionSyntax: enabled = new CheckBox { Text = "允许主动联系", ButtonPressed = current.Enabled }`
- `Godot.CheckBox.CheckBox()`；输入表达式：`new CheckBox { Text = "夺冠赛必定回复", ButtonPressed = current.FinalAlwaysReply }`；返回值紧邻使用处：`AssignmentExpressionSyntax: final = new CheckBox { Text = "夺冠赛必定回复", ButtonPressed = current.FinalAlwaysReply }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("参加决赛后，胜负均按100%触发；沿用连续联系次数上限。", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("参加决赛后，胜负均按100%触发；沿用连续联系次数上限。", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text($"已连续主动联系 {current.Unanswered} 轮", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text($"已连续主动联系 {current.Unanswered} 轮", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(enabled)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(enabled);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(final)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(final);`
- `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`；输入表达式：`GroupCommand("group-proactive", new() { Proactive = value })`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupCommand("group-proactive", new() { Proactive = value });`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-proactive", new() { Proactive = value })`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-proactive", new() { Proactive = value });`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool)`；输入表达式：`ShowCareerDialog("主动联系", "为当前会话设置。你回复后，连续联系次数重新计算。", () => { var value = new ProactiveChatSettings { Enabled = enabled!.ButtonPressed, FinalAlwaysReply = final!.ButtonPressed, MatchChance = (int)match!.Value, EventChance = (int)events!.Value, DayChance = (int)days!.Value, UnansweredLimit = (int)unanswered!.Value }; if (CurrentGroup != null) GroupCommand("group-proactive", new() { Proactive = value }); else PrivateCommand("dm-proactive", new() { Proactive = value }); return true; }, "保存", box => { enabled = new CheckBox { Text = "允许主动联系", ButtonPressed = current.Enabled }; box.AddChild(enabled); SpinBox Field(string label, int value, int min, int max, string suffix) { var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 24); box.AddChild(row); var caption = Text(label, 18, _ink); caption.SizeFlagsHorizontal = SizeFlags.ExpandFill; row.AddChild(caption); var number = new SpinBox { MinValue = min, MaxValue = max, Value = value, Suffix = suffix, UpdateOnTextChanged = true, CustomMinimumSize = new(160, 46) }; row.AddChild(number); return number; } match = Field("赛后联系概率", current.MatchChance, 0, 100, "%"); final = new CheckBox { Text = "夺冠赛必定回复", ButtonPressed = current.FinalAlwaysReply }; box.AddChild(final); box.AddChild(Text("参加决赛后，胜负均按100%触发；沿用连续联系次数上限。", 15, _muted)); events = Field("相关事件联系概率", current.EventChance, 0, 100, "%"); days = Field("平常过日联系概率", current.DayChance, 0, 100, "%"); unanswered = Field("连续几轮后等待回应", current.UnansweredLimit, 1, int.MaxValue, "轮"); box.AddChild(Text($"已连续主动联系 {current.Unanswered} 轮", 15, _muted)); })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("主动联系", "为当前会话设置。你回复后，连续联系次数重新计算。", () => { var value = new ProactiveChatSettings { Enabled = enabled!.ButtonPressed, FinalAlwaysReply = final!.ButtonPressed, MatchChance = (int)match!.Value, EventChance = (int)events!.Value, DayChance = (int)days!.Value, UnansweredLimit = (int)unanswered!.Value }; if (CurrentGroup != null) GroupCommand("group-proactive", new() { Proactive = value }); else PrivateCommand("dm-proactive", new() { Proactive = value }); return true; }, "保存", box => { enabled = new CheckBox { Text = "允许主动联系", ButtonPressed = current.Enabled }; box.AddChild(enabled); SpinBox Field(string label, int value, int min, int max, string suffix) { var row = new HBoxContainer(); row.AddThemeConstantOverride("separation", 24); box.AddChild(row); var caption = Text(label, 18, _ink); caption.SizeFlagsHorizontal = SizeFlags.ExpandFill; row.AddChild(caption); var number = new SpinBox { MinValue = min, MaxValue = max, Value = value, Suffix = suffix, UpdateOnTextChanged = true, CustomMinimumSize = new(160, 46) }; row.AddChild(number); return number; } match = Field("赛后联系概率", current.MatchChance, 0, 100, "%"); final = new CheckBox { Text = "夺冠赛必定回复", ButtonPressed = current.FinalAlwaysReply }; box.AddChild(final); box.AddChild(Text("参加决赛后，胜负均按100%触发；沿用连续联系次数上限。", 15, _muted)); events = Field("相关事件联系概率", current.EventChance, 0, 100, "%"); days = Field("平常过日联系概率", current.DayChance, 0, 100, "%"); unanswered = Field("连续几轮后等待回应", current.UnansweredLimit, 1, int.MaxValue, "轮"); box.AddChild(Text($"已连续主动联系 {current.Unanswered} 轮", 15, _muted)); });`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("参加决赛后，胜负均按100%触发；沿用连续联系次数上限。", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("参加决赛后，胜负均按100%触发；沿用连续联系次数上限。", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"已连续主动联系 {current.Unanswered} 轮", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"已连续主动联系 {current.Unanswered} 轮", 15, _muted)`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(ViewData)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Human(ViewData)`
- `NationalSpire.GroupCommand.GroupCommand()`；输入表达式：`new() { Proactive = value }`；返回值紧邻使用处：`ArgumentSyntax: new() { Proactive = value }`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Proactive = value }`；返回值紧邻使用处：`ArgumentSyntax: new() { Proactive = value }`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(ViewData, _privatePerson)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(ViewData, _privatePerson).Proactive`
- `NationalSpire.ProactiveChatSettings.ProactiveChatSettings()`；输入表达式：`new ProactiveChatSettings { Enabled = enabled!.ButtonPressed, FinalAlwaysReply = final!.ButtonPressed, MatchChance = (int)match!.Value, EventChance = (int)events!.Value, DayChance = (int)days!.Value, UnansweredLimit = (int)unanswered!.Value }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ProactiveChatSettings { Enabled = enabled!.ButtonPressed, FinalAlwaysReply = final!.ButtonPressed, MatchChance = (int)match!.Value, EventChance = (int)events!.Value, DayChance = (int)days!.Value, UnansweredLimit = (int)unanswered!.Value }`
- `NationalSpire.ProactiveChatSettings.ProactiveChatSettings()`；输入表达式：`new()`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Proactive.GetValueOrDefault(GroupChats.Human(ViewData)) ?? new()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`g.Proactive.GetValueOrDefault(GroupChats.Human(ViewData))`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Proactive.GetValueOrDefault(GroupChats.Human(ViewData)) ?? new()`

**赋值（含属性/字段和局部值）：**

- `ButtonPressed` = `current.Enabled`
- `ButtonPressed` = `current.FinalAlwaysReply`
- `DayChance` = `(int)days!.Value`
- `Enabled` = `enabled!.ButtonPressed`
- `EventChance` = `(int)events!.Value`
- `FinalAlwaysReply` = `final!.ButtonPressed`
- `MatchChance` = `(int)match!.Value`
- `Proactive` = `value`
- `Text` = `"允许主动联系"`
- `Text` = `"夺冠赛必定回复"`
- `UnansweredLimit` = `(int)unanswered!.Value`
- `days` = `Field("平常过日联系概率", current.DayChance, 0, 100, "%")`
- `enabled` = `new CheckBox { Text = "允许主动联系", ButtonPressed = current.Enabled }`
- `events` = `Field("相关事件联系概率", current.EventChance, 0, 100, "%")`
- `final` = `new CheckBox { Text = "夺冠赛必定回复", ButtonPressed = current.FinalAlwaysReply }`
- `match` = `Field("赛后联系概率", current.MatchChance, 0, 100, "%")`
- `unanswered` = `Field("连续几轮后等待回应", current.UnansweredLimit, 1, int.MaxValue, "轮")`

<a id="symbol-0d6f466af00f"></a>

## `Field(string, int, int, int, string) — SpinBox Field(string label, int value, int min, int max, string suffix)`

来源：源码第 163 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ProactiveChatDialog()`](ChatManagementScreen.cs.md#symbol-f9397f5fb6b7)

**调用：** [`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.SpinBox.SpinBox()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 24)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 24);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(caption)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(caption);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(number)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(number);`
- `Godot.SpinBox.SpinBox()`；输入表达式：`new SpinBox { MinValue = min, MaxValue = max, Value = value, Suffix = suffix,                     UpdateOnTextChanged = true, CustomMinimumSize = new(160, 46) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new SpinBox { MinValue = min, MaxValue = max, Value = value, Suffix = suffix,                     UpdateOnTextChanged = true, CustomMinimumSize = new(160, 46) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(160, 46)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(160, 46)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(label, 18, _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(label, 18, _ink)`

**赋值（含属性/字段和局部值）：**

- `caption.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `CustomMinimumSize` = `new(160, 46)`
- `MaxValue` = `max`
- `MinValue` = `min`
- `Suffix` = `suffix`
- `UpdateOnTextChanged` = `true`
- `Value` = `value`
