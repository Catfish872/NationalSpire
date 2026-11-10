# ManualMemoryScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`0E78DDAB61488947D61D0672F7DC7C79EC4E413576E88695E2244B1870589186`。来源：[源码](../../ManualMemoryScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-aad226291778"></a>

## `NationalSpire.CareerScreen.ManualMemoryCard(Godot.VBoxContainer, NationalSpire.ManualChatMemory) — private void ManualMemoryCard(VBoxContainer list, ManualChatMemory memory)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.GroupMemory()`](GroupChatDialogs.cs.md#symbol-bf729ae9b3eb)；[`Section(string)`](PrivateMemoryScreen.cs.md#symbol-3776534c6c5a)

**调用：** `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`；[`NationalSpire.CareerScreen.EditManualMemory(NationalSpire.ManualChatMemory?)`](ManualMemoryScreen.cs.md#symbol-026ac4d345bc)；[`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?, string?, System.Action<string>?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`](ChatManagementScreen.cs.md#symbol-b95040f17d55)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-84294149ff91)；[`NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-5789f5c9047d)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`](CareerDialog.cs.md#symbol-df0355cc8433)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`NationalSpire.GroupCommand.GroupCommand()`；[`NationalSpire.ManualChatMemories.Heading(NationalSpire.CareerData, NationalSpire.ManualChatMemory)`](ManualChatMemory.cs.md#symbol-7188d3f17ab1)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`

**字段、属性、事件及方法组引用：** `Accepted()`；`NationalSpire.CareerScreen.EditManualMemory(NationalSpire.ManualChatMemory?)`；`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?, string?, System.Action<string>?)`；`NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；`NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.GroupCommand.Interaction`；`NationalSpire.ManualChatMemories.Heading(NationalSpire.CareerData, NationalSpire.ManualChatMemory)`；`NationalSpire.ManualChatMemory.Id`；`NationalSpire.ManualChatMemory.Text`；`NationalSpire.PrivateMessageCommand.Entry`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("101f2d", "3c5469", 3, 20))`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddThemeStyleboxOverride("panel", CareerVisuals.Box("101f2d", "3c5469", 3, 20));`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateSelectableText(memory.Text, 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(PrivateSelectableText(memory.Text, 18, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`card.AddChild(box)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddChild(box);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`list.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateButton("删除", () => OpenChatDialog(() => ShowCareerDialog("删除这条手动记忆", "确认删除这条记忆总结？", () => { var dialog = _dialogOverlay; void Accepted() { if (_dialogOverlay == dialog) OpenChatDialog(PrivateMemory); } if (_privateGroup.Length > 0) GroupCommand("group-memory-delete", new() { Interaction = new() { Entry = memory.Id } }, Accepted); else PrivateCommand("dm-memory-delete", new() { Entry = memory.Id }, Accepted); return false; }, "删除")), 72))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateButton("删除", () => OpenChatDialog(() => ShowCareerDialog("删除这条手动记忆", "确认删除这条记忆总结？", () => { var dialog = _dialogOverlay; void Accepted() { if (_dialogOverlay == dialog) OpenChatDialog(PrivateMemory); } if (_privateGroup.Length > 0) GroupCommand("group-memory-delete", new() { Interaction = new() { Entry = memory.Id } }, Accepted); else PrivateCommand("dm-memory-delete", new() { Entry = memory.Id }, Accepted); return false; }, "删除")), 72));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(PrivateButton("编辑", () => OpenChatDialog(() => EditManualMemory(memory)), 72))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(PrivateButton("编辑", () => OpenChatDialog(() => EditManualMemory(memory)), 72));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(title);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer()`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `NationalSpire.CareerScreen.EditManualMemory(NationalSpire.ManualChatMemory?)`；输入表达式：`EditManualMemory(memory)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => EditManualMemory(memory)`
- `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`GroupCommand("group-memory-delete", new() { Interaction = new() { Entry = memory.Id } }, Accepted)`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupCommand("group-memory-delete", new() { Interaction = new() { Entry = memory.Id } }, Accepted);`
- `NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`；输入表达式：`OpenChatDialog(() => EditManualMemory(memory))`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenChatDialog(() => EditManualMemory(memory))`
- `NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`；输入表达式：`OpenChatDialog(() => ShowCareerDialog("删除这条手动记忆", "确认删除这条记忆总结？", () => { var dialog = _dialogOverlay; void Accepted() { if (_dialogOverlay == dialog) OpenChatDialog(PrivateMemory); } if (_privateGroup.Length > 0) GroupCommand("group-memory-delete", new() { Interaction = new() { Entry = memory.Id } }, Accepted); else PrivateCommand("dm-memory-delete", new() { Entry = memory.Id }, Accepted); return false; }, "删除"))`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenChatDialog(() => ShowCareerDialog("删除这条手动记忆", "确认删除这条记忆总结？", () => { var dialog = _dialogOverlay; void Accepted() { if (_dialogOverlay == dialog) OpenChatDialog(PrivateMemory); } if (_privateGroup.Length > 0) GroupCommand("group-memory-delete", new() { Interaction = new() { Entry = memory.Id } }, Accepted); else PrivateCommand("dm-memory-delete", new() { Entry = memory.Id }, Accepted); return false; }, "删除"))`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("删除", () => OpenChatDialog(() => ShowCareerDialog("删除这条手动记忆", "确认删除这条记忆总结？", () => { var dialog = _dialogOverlay; void Accepted() { if (_dialogOverlay == dialog) OpenChatDialog(PrivateMemory); } if (_privateGroup.Length > 0) GroupCommand("group-memory-delete", new() { Interaction = new() { Entry = memory.Id } }, Accepted); else PrivateCommand("dm-memory-delete", new() { Entry = memory.Id }, Accepted); return false; }, "删除")), 72)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("删除", () => OpenChatDialog(() => ShowCareerDialog("删除这条手动记忆", "确认删除这条记忆总结？", () => { var dialog = _dialogOverlay; void Accepted() { if (_dialogOverlay == dialog) OpenChatDialog(PrivateMemory); } if (_privateGroup.Length > 0) GroupCommand("group-memory-delete", new() { Interaction = new() { Entry = memory.Id } }, Accepted); else PrivateCommand("dm-memory-delete", new() { Entry = memory.Id }, Accepted); return false; }, "删除")), 72)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("编辑", () => OpenChatDialog(() => EditManualMemory(memory)), 72)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("编辑", () => OpenChatDialog(() => EditManualMemory(memory)), 72)`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-memory-delete", new() { Entry = memory.Id }, Accepted)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-memory-delete", new() { Entry = memory.Id }, Accepted);`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine(ManualChatMemories.Heading(ViewData, memory), 16, _gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine(ManualChatMemories.Heading(ViewData, memory), 16, _gold)`
- `NationalSpire.CareerScreen.PrivateSelectableText(string, int, Godot.Color)`；输入表达式：`PrivateSelectableText(memory.Text, 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: PrivateSelectableText(memory.Text, 18, _ink)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；输入表达式：`ShowCareerDialog("删除这条手动记忆", "确认删除这条记忆总结？", () => { var dialog = _dialogOverlay; void Accepted() { if (_dialogOverlay == dialog) OpenChatDialog(PrivateMemory); } if (_privateGroup.Length > 0) GroupCommand("group-memory-delete", new() { Interaction = new() { Entry = memory.Id } }, Accepted); else PrivateCommand("dm-memory-delete", new() { Entry = memory.Id }, Accepted); return false; }, "删除")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ShowCareerDialog("删除这条手动记忆", "确认删除这条记忆总结？", () => { var dialog = _dialogOverlay; void Accepted() { if (_dialogOverlay == dialog) OpenChatDialog(PrivateMemory); } if (_privateGroup.Length > 0) GroupCommand("group-memory-delete", new() { Interaction = new() { Entry = memory.Id } }, Accepted); else PrivateCommand("dm-memory-delete", new() { Entry = memory.Id }, Accepted); return false; }, "删除")`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("101f2d", "3c5469", 3, 20)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("101f2d", "3c5469", 3, 20)`
- `NationalSpire.GroupCommand.GroupCommand()`；输入表达式：`new() { Interaction = new() { Entry = memory.Id } }`；返回值紧邻使用处：`ArgumentSyntax: new() { Interaction = new() { Entry = memory.Id } }`
- `NationalSpire.ManualChatMemories.Heading(NationalSpire.CareerData, NationalSpire.ManualChatMemory)`；输入表达式：`ManualChatMemories.Heading(ViewData, memory)`；返回值紧邻使用处：`ArgumentSyntax: ManualChatMemories.Heading(ViewData, memory)`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Entry = memory.Id }`；返回值紧邻使用处：`AssignmentExpressionSyntax: Interaction = new() { Entry = memory.Id }`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Entry = memory.Id }`；返回值紧邻使用处：`ArgumentSyntax: new() { Entry = memory.Id }`

**赋值（含属性/字段和局部值）：**

- `Entry` = `memory.Id`
- `Interaction` = `new() { Entry = memory.Id }`
- `title.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-763c66f317ee"></a>

## `Accepted() — void Accepted()`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`](ChatManagementScreen.cs.md#symbol-b95040f17d55)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`；`NationalSpire.CareerScreen.PrivateMemory()`；`NationalSpire.CareerScreen._dialogOverlay`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`；输入表达式：`OpenChatDialog(PrivateMemory)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenChatDialog(PrivateMemory);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-026ac4d345bc"></a>

## `NationalSpire.CareerScreen.EditManualMemory(NationalSpire.ManualChatMemory?) — private void EditManualMemory(ManualChatMemory? memory = null)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.GroupMemory()`](GroupChatDialogs.cs.md#symbol-bf729ae9b3eb)；[`NationalSpire.CareerScreen.ManualMemoryCard(Godot.VBoxContainer, NationalSpire.ManualChatMemory)`](ManualMemoryScreen.cs.md#symbol-aad226291778)；[`NationalSpire.CareerScreen.PrivateMemory()`](PrivateMemoryScreen.cs.md#symbol-942a4a496637)

**调用：** [`Changed()`](ManualMemoryScreen.cs.md#symbol-5de148964de0)；[`Fail(string)`](ManualMemoryScreen.cs.md#symbol-7f68b9aa26bc)；`Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.CanvasItem.Hide()`；`Godot.CanvasItem.IsVisibleInTree()`；`Godot.Color.Color(string)`；`Godot.Control.GrabFocus()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；[`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?, string?, System.Action<string>?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-7d2faf7b7d58)；[`NationalSpire.CareerScreen.PrivateEditor(string, int, int)`](PrivateMemoryScreen.cs.md#symbol-1c1072fdb98b)；[`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`](PrivateMemoryScreen.cs.md#symbol-84294149ff91)；[`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`](PrivateMessageScreen.cs.md#symbol-fb5e88f4639a)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`](CareerDialog.cs.md#symbol-df0355cc8433)；`NationalSpire.GroupCommand.GroupCommand()`；[`NationalSpire.ManualChatMemories.Validate(string)`](ManualChatMemory.cs.md#symbol-3d0261d63d16)；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`

**字段、属性、事件及方法组引用：** `Accepted()`；`Changed()`；`Fail(string)`；`Message(string, bool)`；`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?, string?, System.Action<string>?)`；`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；`NationalSpire.CareerScreen.PrivateEditor(string, int, int)`；`NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；`NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen._privatePerson`；`NationalSpire.GroupCommand.Interaction`；`NationalSpire.GroupCommand.Text`；`NationalSpire.ICareerSession.Message`；`NationalSpire.ManualChatMemories.Validate(string)`；`NationalSpire.ManualChatMemory.Id`；`NationalSpire.ManualChatMemory.Text`；`NationalSpire.PrivateMessageCommand.Entry`；`NationalSpire.PrivateMessageCommand.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Changed()`；输入表达式：`Changed()`；返回值紧邻使用处：`ExpressionStatementSyntax: Changed();`
- `Fail(string)`；输入表达式：`Fail(error)`；返回值紧邻使用处：`ExpressionStatementSyntax: Fail(error);`
- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(() => { if (IsInstanceValid(input) && input!.IsVisibleInTree()) input.GrabFocus(); }).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(() => { if (IsInstanceValid(input) && input!.IsVisibleInTree()) input.GrabFocus(); }).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(() => { if (IsInstanceValid(input) && input!.IsVisibleInTree()) input.GrabFocus(); })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(() => { if (IsInstanceValid(input) && input!.IsVisibleInTree()) input.GrabFocus(); }).CallDeferred`
- `Godot.CanvasItem.Hide()`；输入表达式：`status.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: status.Hide();`
- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`input!.IsVisibleInTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(input) && input!.IsVisibleInTree()`
- `Godot.Color.Color(string)`；输入表达式：`new Color("ee929d")`；返回值紧邻使用处：`ArgumentSyntax: new Color("ee929d")`
- `Godot.Control.GrabFocus()`；输入表达式：`input.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: input.GrabFocus();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(input)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(input) && input!.IsVisibleInTree()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(count)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(count);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(input)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(input);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(status)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(status);`
- `NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`GroupCommand("group-memory-" + action, new() { Text = input.Text, Interaction = new() { Entry = id } }, Accepted, group, Fail)`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupCommand("group-memory-" + action, new() { Text = input.Text, Interaction = new() { Entry = id } }, Accepted, group, Fail);`
- `NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`；输入表达式：`PrivateCommand("dm-memory-" + action, new() { Text = input.Text, Entry = id }, Accepted, person, Fail)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateCommand("dm-memory-" + action, new() { Text = input.Text, Entry = id }, Accepted, person, Fail);`
- `NationalSpire.CareerScreen.PrivateEditor(string, int, int)`；输入表达式：`PrivateEditor(memory?.Text ?? "")`；返回值紧邻使用处：`AssignmentExpressionSyntax: input = PrivateEditor(memory?.Text ?? "")`
- `NationalSpire.CareerScreen.PrivateLine(string, int, Godot.Color)`；输入表达式：`PrivateLine("", 14, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateLine("", 14, _muted)`
- `NationalSpire.CareerScreen.PrivateText(string, int, Godot.Color)`；输入表达式：`PrivateText("", 15, new Color("ee929d"))`；返回值紧邻使用处：`AssignmentExpressionSyntax: status = PrivateText("", 15, new Color("ee929d"))`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；输入表达式：`ShowCareerDialog(memory == null ? "新建记忆总结" : "编辑手动记忆", "记录需要保留的经历、约定与细节，保存后用于后续聊天。", () => { if (ManualChatMemories.Validate(input!.Text) is { } error) { Fail(error); input.GrabFocus(); return false; } void Accepted() { if (_dialogOverlay == dialog) OpenChatDialog(PrivateMemory); } if (group.Length > 0) GroupCommand("group-memory-" + action, new() { Text = input.Text, Interaction = new() { Entry = id } }, Accepted, group, Fail); else PrivateCommand("dm-memory-" + action, new() { Text = input.Text, Entry = id }, Accepted, person, Fail); return false; }, "保存", box => { input = PrivateEditor(memory?.Text ?? ""); input.Name = "ManualMemoryEditor"; input.PlaceholderText = "在此编写，或使用 Ctrl+V 粘贴记忆总结……"; box.AddChild(input); var count = PrivateLine("", 14, _muted); count.Name = "ManualMemoryCount"; box.AddChild(count); status = PrivateText("", 15, new Color("ee929d")); status.Name = "ManualMemoryError"; status.Hide(); box.AddChild(status); void Changed() { count.Text = $"{input.Text.Length} / {ManualChatMemories.MaxLength} 字"; status.Hide(); } input.TextChanged += Changed; Changed(); if (_multiplayer is { } session) { void Message(string text, bool error) { if (error) Fail(text); } session.Message += Message; input.TreeExiting += () => session.Message -= Message; } })`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog(memory == null ? "新建记忆总结" : "编辑手动记忆", "记录需要保留的经历、约定与细节，保存后用于后续聊天。", () => { if (ManualChatMemories.Validate(input!.Text) is { } error) { Fail(error); input.GrabFocus(); return false; } void Accepted() { if (_dialogOverlay == dialog) OpenChatDialog(PrivateMemory); } if (group.Length > 0) GroupCommand("group-memory-" + action, new() { Text = input.Text, Interaction = new() { Entry = id } }, Accepted, group, Fail); else PrivateCommand("dm-memory-" + action, new() { Text = input.Text, Entry = id }, Accepted, person, Fail); return false; }, "保存", box => { input = PrivateEditor(memory?.Text ?? ""); input.Name = "ManualMemoryEditor"; input.PlaceholderText = "在此编写，或使用 Ctrl+V 粘贴记忆总结……"; box.AddChild(input); var count = PrivateLine("", 14, _muted); count.Name = "ManualMemoryCount"; box.AddChild(count); status = PrivateText("", 15, new Color("ee929d")); status.Name = "ManualMemoryError"; status.Hide(); box.AddChild(status); void Changed() { count.Text = $"{input.Text.Length} / {ManualChatMemories.MaxLength} 字"; status.Hide(); } input.TextChanged += Changed; Changed(); if (_multiplayer is { } session) { void Message(string text, bool error) { if (error) Fail(text); } session.Message += Message; input.TreeExiting += () => session.Message -= Message; } });`
- `NationalSpire.GroupCommand.GroupCommand()`；输入表达式：`new() { Text = input.Text, Interaction = new() { Entry = id } }`；返回值紧邻使用处：`ArgumentSyntax: new() { Text = input.Text, Interaction = new() { Entry = id } }`
- `NationalSpire.ManualChatMemories.Validate(string)`；输入表达式：`ManualChatMemories.Validate(input!.Text)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ManualChatMemories.Validate(input!.Text) is { } error`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Entry = id }`；返回值紧邻使用处：`AssignmentExpressionSyntax: Interaction = new() { Entry = id }`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new() { Text = input.Text, Entry = id }`；返回值紧邻使用处：`ArgumentSyntax: new() { Text = input.Text, Entry = id }`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`BinaryExpressionSyntax: memory?.Id ?? Guid.NewGuid().ToString("N")`

**赋值（含属性/字段和局部值）：**

- `Entry` = `id`
- `Interaction` = `new() { Entry = id }`
- `Text` = `input.Text`
- `count.Name` = `"ManualMemoryCount"`
- `dialog` = `_dialogOverlay`
- `input.Name` = `"ManualMemoryEditor"`
- `input.PlaceholderText` = `"在此编写，或使用 Ctrl+V 粘贴记忆总结……"`
- `input.TextChanged` += `Changed`
- `input.TreeExiting` += `() => session.Message -= Message`
- `input` = `PrivateEditor(memory?.Text ?? "")`
- `session.Message` += `Message`
- `session.Message` -= `Message`
- `status.Name` = `"ManualMemoryError"`
- `status` = `PrivateText("", 15, new Color("ee929d"))`

<a id="symbol-7f68b9aa26bc"></a>

## `Fail(string) — void Fail(string message)`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Message(string, bool)`](ManualMemoryScreen.cs.md#symbol-2dfca4a10f7f)；[`NationalSpire.CareerScreen.EditManualMemory(NationalSpire.ManualChatMemory?)`](ManualMemoryScreen.cs.md#symbol-026ac4d345bc)

**调用：** `Godot.CanvasItem.Show()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；[`NationalSpire.PlayerFacingText.LongError(string)`](PlayerFacingText.cs.md#symbol-f9422d3b8971)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.PlayerFacingText.LongError(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Show()`；输入表达式：`status.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: status.Show();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(status)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(status)`
- `NationalSpire.PlayerFacingText.LongError(string)`；输入表达式：`PlayerFacingText.LongError(message)`；返回值紧邻使用处：`AssignmentExpressionSyntax: status!.Text = PlayerFacingText.LongError(message)`

**赋值（含属性/字段和局部值）：**

- `status!.Text` = `PlayerFacingText.LongError(message)`

<a id="symbol-7a0bbb239ac0"></a>

## `Accepted() — void Accepted()`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`](ChatManagementScreen.cs.md#symbol-b95040f17d55)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`；`NationalSpire.CareerScreen.PrivateMemory()`；`NationalSpire.CareerScreen._dialogOverlay`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.OpenChatDialog(System.Action, bool)`；输入表达式：`OpenChatDialog(PrivateMemory)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenChatDialog(PrivateMemory);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5de148964de0"></a>

## `Changed() — void Changed()`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EditManualMemory(NationalSpire.ManualChatMemory?)`](ManualMemoryScreen.cs.md#symbol-026ac4d345bc)

**调用：** `Godot.CanvasItem.Hide()`

**字段、属性、事件及方法组引用：** `NationalSpire.ManualChatMemories.MaxLength`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`status.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: status.Hide();`

**赋值（含属性/字段和局部值）：**

- `count.Text` = `$"{input.Text.Length} / {ManualChatMemories.MaxLength} 字"`

<a id="symbol-2dfca4a10f7f"></a>

## `Message(string, bool) — void Message(string text, bool error)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`Fail(string)`](ManualMemoryScreen.cs.md#symbol-7f68b9aa26bc)

**字段、属性、事件及方法组引用：** `Fail(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Fail(string)`；输入表达式：`Fail(text)`；返回值紧邻使用处：`ExpressionStatementSyntax: Fail(text);`

**赋值（含属性/字段和局部值）：**
