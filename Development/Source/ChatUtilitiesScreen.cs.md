# ChatUtilitiesScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`1928AD434A4B03BB7CA38FC57A4E2D1B4D35EE8EDD45D1FA4F72F7A545033DD6`。来源：[源码](../../ChatUtilitiesScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private PopupMenu? _chatModelPopup;
```

<a id="symbol-381ceff6cf39"></a>

## `NationalSpire.CareerScreen.ChatModelPickerOpen — private bool ChatModelPickerOpen`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerDropdownLayer.At(Godot.Control)`](CareerDropdownLayer.cs.md#symbol-4de44cb328a0)；[`NationalSpire.CareerDropdownLayer.Showing(Godot.Button)`](CareerDropdownLayer.cs.md#symbol-9296f1acb0ef)；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.GetParent()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerDropdownLayer.At(Godot.Control)`；`NationalSpire.CareerDropdownLayer.Showing(Godot.Button)`；`NationalSpire.CareerScreen._chatModelPopup`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_chatModelPopup)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(_chatModelPopup) && _chatModelPopup!.GetParent() is Button anchor`
- `Godot.Node.GetParent()`；输入表达式：`_chatModelPopup!.GetParent()`；返回值紧邻使用处：`IsPatternExpressionSyntax: _chatModelPopup!.GetParent() is Button anchor`
- `NationalSpire.CareerDropdownLayer.At(Godot.Control)`；输入表达式：`CareerDropdownLayer.At(anchor)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CareerDropdownLayer.At(anchor).Showing`
- `NationalSpire.CareerDropdownLayer.Showing(Godot.Button)`；输入表达式：`CareerDropdownLayer.At(anchor).Showing(anchor)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(_chatModelPopup) && _chatModelPopup!.GetParent() is Button anchor && CareerDropdownLayer.At(anchor).Showing(anchor)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1bb784a2ab9d"></a>

## `NationalSpire.CareerScreen.ExportChatTranscript() — private void ExportChatTranscript()`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`](CareerDialog.cs.md#symbol-df0355cc8433)；[`NationalSpire.ChatTranscript.Group(NationalSpire.CareerData, NationalSpire.GroupChat)`](ChatTranscript.cs.md#symbol-f3a90964e01d)；[`NationalSpire.ChatTranscript.Private(NationalSpire.CareerData, NationalSpire.PrivateConversation)`](ChatTranscript.cs.md#symbol-03037cb1cba8)；[`NationalSpire.ChatTranscript.Write(NationalSpire.CareerData, NationalSpire.ChatTranscript.Document, string)`](ChatTranscript.cs.md#symbol-a117ad117085)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OS.ShellShowInFileManager(string, bool)`；`Godot.ProjectSettings.GlobalizePath(string)`；`string.IsNullOrWhiteSpace(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._privatePerson`；`NationalSpire.CareerScreen.CurrentGroup`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.ChatTranscript.Document.Messages`；`NationalSpire.ChatTranscript.Group(NationalSpire.CareerData, NationalSpire.GroupChat)`；`NationalSpire.ChatTranscript.Private(NationalSpire.CareerData, NationalSpire.PrivateConversation)`；`NationalSpire.ChatTranscript.Write(NationalSpire.CareerData, NationalSpire.ChatTranscript.Document, string)`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PromptTransfer.Desktop`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(PrivateButton("打开所在文件夹", () => OS.ShellShowInFileManager(path), 200))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: box => box.AddChild(PrivateButton("打开所在文件夹", () => OS.ShellShowInFileManager(path), 200))`
- `Godot.OS.ShellShowInFileManager(string, bool)`；输入表达式：`OS.ShellShowInFileManager(path)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OS.ShellShowInFileManager(path)`
- `Godot.ProjectSettings.GlobalizePath(string)`；输入表达式：`ProjectSettings.GlobalizePath("user://chat_exports")`；返回值紧邻使用处：`AssignmentExpressionSyntax: directory = ProjectSettings.GlobalizePath("user://chat_exports")`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("打开所在文件夹", () => OS.ShellShowInFileManager(path), 200)`；返回值紧邻使用处：`ArgumentSyntax: PrivateButton("打开所在文件夹", () => OS.ShellShowInFileManager(path), 200)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；输入表达式：`ShowCareerDialog("导出失败", e.Message, () => true, "关闭", showCancel: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("导出失败", e.Message, () => true, "关闭", showCancel: false);`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；输入表达式：`ShowCareerDialog("聊天记录已导出", $"已导出 {document.Messages.Count} 条消息。\n保存位置：{path}", () => true, "完成",                  box => box.AddChild(PrivateButton("打开所在文件夹", () => OS.ShellShowInFileManager(path), 200)), showCancel: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("聊天记录已导出", $"已导出 {document.Messages.Count} 条消息。\n保存位置：{path}", () => true, "完成",                  box => box.AddChild(PrivateButton("打开所在文件夹", () => OS.ShellShowInFileManager(path), 200)), showCancel: false);`
- `NationalSpire.ChatTranscript.Group(NationalSpire.CareerData, NationalSpire.GroupChat)`；输入表达式：`ChatTranscript.Group(data, group)`；返回值紧邻使用处：`ConditionalExpressionSyntax: CurrentGroup is { } group ? ChatTranscript.Group(data, group)                  : ChatTranscript.Private(data, PrivateMessages.Conversation(data, _privatePerson))`
- `NationalSpire.ChatTranscript.Private(NationalSpire.CareerData, NationalSpire.PrivateConversation)`；输入表达式：`ChatTranscript.Private(data, PrivateMessages.Conversation(data, _privatePerson))`；返回值紧邻使用处：`ConditionalExpressionSyntax: CurrentGroup is { } group ? ChatTranscript.Group(data, group)                  : ChatTranscript.Private(data, PrivateMessages.Conversation(data, _privatePerson))`
- `NationalSpire.ChatTranscript.Write(NationalSpire.CareerData, NationalSpire.ChatTranscript.Document, string)`；输入表达式：`ChatTranscript.Write(data, document, directory)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ChatTranscript.Write(data, document, directory)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, _privatePerson)`；返回值紧邻使用处：`ArgumentSyntax: PrivateMessages.Conversation(data, _privatePerson)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(directory)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(directory)) directory = ProjectSettings.GlobalizePath("user://chat_exports");`

**赋值（含属性/字段和局部值）：**

- `directory` = `ProjectSettings.GlobalizePath("user://chat_exports")`

<a id="symbol-f49b1a0725a3"></a>

## `NationalSpire.CareerScreen.BuildChatModelButton(Godot.HBoxContainer) — private void BuildChatModelButton(HBoxContainer tools)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildPrivateComposerActions(Godot.VBoxContainer)`](PrivateMessageScreen.cs.md#symbol-a7be0d6513a6)

**调用：** [`NationalSpire.AffectionArt.Texture(string)`](AffectionVisuals.cs.md#symbol-966474984d6a)；[`NationalSpire.CareerScreen.ConfigureModelPermission(Godot.Button)`](ChatUtilitiesScreen.cs.md#symbol-c65a765f7f74)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.ShowChatModelPicker(Godot.Button, string)`](ChatUtilitiesScreen.cs.md#symbol-cc67f52fc948)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.AffectionArt.Texture(string)`；`NationalSpire.CareerScreen._privateGroup`；`NationalSpire.CareerScreen.ConfigureModelPermission(Godot.Button)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.ShowChatModelPicker(Godot.Button, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeConstantOverride("icon_max_width", 24)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeConstantOverride("icon_max_width", 24);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tools.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: tools.AddChild(button);`
- `NationalSpire.AffectionArt.Texture(string)`；输入表达式：`AffectionArt.Texture("chat-model")`；返回值紧邻使用处：`AssignmentExpressionSyntax: button.Icon = AffectionArt.Texture("chat-model")`
- `NationalSpire.CareerScreen.ConfigureModelPermission(Godot.Button)`；输入表达式：`ConfigureModelPermission(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: ConfigureModelPermission(button);`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("", () => { }, 48)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateButton("", () => { }, 48)`
- `NationalSpire.CareerScreen.ShowChatModelPicker(Godot.Button, string)`；输入表达式：`ShowChatModelPicker(button, _privateGroup.Length > 0 ? "group" : "private")`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ShowChatModelPicker(button, _privateGroup.Length > 0 ? "group" : "private")`

**赋值（含属性/字段和局部值）：**

- `button.ExpandIcon` = `true`
- `button.Icon` = `AffectionArt.Texture("chat-model")`
- `button.Name` = `"ChatModelButton"`
- `button.Pressed` += `() => ShowChatModelPicker(button, _privateGroup.Length > 0 ? "group" : "private")`
- `button.SizeFlagsVertical` = `SizeFlags.Fill`
- `button.TooltipText` = `"切换当前聊天类型的模型方案"`

<a id="symbol-c65a765f7f74"></a>

## `NationalSpire.CareerScreen.ConfigureModelPermission(Godot.Button) — private void ConfigureModelPermission(Button button)`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildChatModelButton(Godot.HBoxContainer)`](ChatUtilitiesScreen.cs.md#symbol-f49b1a0725a3)；[`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._multiplayer`；`NationalSpire.ICareerSession.Host`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `button.Disabled` = `_multiplayer is { Host: false }`
- `button.TooltipText` = `"模型方案由房主设置。"`

<a id="symbol-cc67f52fc948"></a>

## `NationalSpire.CareerScreen.ShowChatModelPicker(Godot.Button, string) — private void ShowChatModelPicker(Button anchor, string task)`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildChatModelButton(Godot.HBoxContainer)`](ChatUtilitiesScreen.cs.md#symbol-f49b1a0725a3)；[`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)

**调用：** [`NationalSpire.AiRouting.Assign(NationalSpire.AiOptions, string, string, System.Action)`](AiRouting.cs.md#symbol-dcdbadb40401)；[`NationalSpire.AiRouting.Ensure(NationalSpire.AiOptions)`](AiRouting.cs.md#symbol-7a203ffde56e)；[`NationalSpire.AiRouting.ProfileId(NationalSpire.AiOptions, string)`](AiRouting.cs.md#symbol-ccbfd0b083bc)；[`NationalSpire.CareerDropdownLayer.At(Godot.Control)`](CareerDropdownLayer.cs.md#symbol-4de44cb328a0)；[`NationalSpire.CareerDropdownLayer.Close()`](CareerDropdownLayer.cs.md#symbol-52d15bb810b8)；[`NationalSpire.CareerDropdownLayer.Open(Godot.Button, Godot.PopupMenu, System.Action?)`](CareerDropdownLayer.cs.md#symbol-bf23af955811)；[`NationalSpire.CareerDropdownLayer.Showing(Godot.Button)`](CareerDropdownLayer.cs.md#symbol-9296f1acb0ef)；[`NationalSpire.CareerScreen.SaveAiSettings(NationalSpire.CareerData)`](CareerSession.cs.md#symbol-485b9c9c8acb)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`](CareerDialog.cs.md#symbol-df0355cc8433)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.QueueFree()`；`Godot.PopupMenu.AddRadioCheckItem(string, int, Godot.Key)`；`Godot.PopupMenu.GetItemIndex(int)`；`Godot.PopupMenu.GetItemMetadata(int)`；`Godot.PopupMenu.PopupMenu()`；`Godot.PopupMenu.SetItemChecked(int, bool)`；`Godot.PopupMenu.SetItemMetadata(int, Godot.Variant)`；`Godot.PopupMenu.SetItemTooltip(int, string)`；`Godot.Variant.AsString()`；`object.ReferenceEquals(object?, object?)`；`System.Globalization.StringInfo.StringInfo(string)`；`System.Globalization.StringInfo.SubstringByTextElements(int, int)`；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiConnectionProfile.Model`；`NationalSpire.AiConnectionProfile.Name`；`NationalSpire.AiOptions.ConnectionProfiles`；`NationalSpire.AiRouting.Assign(NationalSpire.AiOptions, string, string, System.Action)`；`NationalSpire.AiRouting.Ensure(NationalSpire.AiOptions)`；`NationalSpire.AiRouting.ProfileId(NationalSpire.AiOptions, string)`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerDropdownLayer.At(Godot.Control)`；`NationalSpire.CareerDropdownLayer.Close()`；`NationalSpire.CareerDropdownLayer.Open(Godot.Button, Godot.PopupMenu, System.Action?)`；`NationalSpire.CareerDropdownLayer.Showing(Godot.Button)`；`NationalSpire.CareerScreen._chatModelPopup`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen.SaveAiSettings(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.ICareerSession.Host`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`anchor.AddChild(popup)`；返回值紧邻使用处：`ExpressionStatementSyntax: anchor.AddChild(popup);`
- `Godot.Node.QueueFree()`；输入表达式：`popup.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: popup.QueueFree();`
- `Godot.PopupMenu.AddRadioCheckItem(string, int, Godot.Key)`；输入表达式：`popup.AddRadioCheckItem(name.LengthInTextElements > 24 ? name.SubstringByTextElements(0, 24) + "…" : profile.Name)`；返回值紧邻使用处：`ExpressionStatementSyntax: popup.AddRadioCheckItem(name.LengthInTextElements > 24 ? name.SubstringByTextElements(0, 24) + "…" : profile.Name);`
- `Godot.PopupMenu.GetItemIndex(int)`；输入表达式：`popup.GetItemIndex((int)id)`；返回值紧邻使用处：`ArgumentSyntax: popup.GetItemIndex((int)id)`
- `Godot.PopupMenu.GetItemMetadata(int)`；输入表达式：`popup.GetItemMetadata(popup.GetItemIndex((int)id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: popup.GetItemMetadata(popup.GetItemIndex((int)id)).AsString`
- `Godot.PopupMenu.PopupMenu()`；输入表达式：`new PopupMenu { Name = "ChatModelPicker", HideOnCheckableItemSelection = true }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PopupMenu { Name = "ChatModelPicker", HideOnCheckableItemSelection = true }`
- `Godot.PopupMenu.SetItemChecked(int, bool)`；输入表达式：`popup.SetItemChecked(index, id == selected)`；返回值紧邻使用处：`ExpressionStatementSyntax: popup.SetItemChecked(index, id == selected);`
- `Godot.PopupMenu.SetItemMetadata(int, Godot.Variant)`；输入表达式：`popup.SetItemMetadata(index, id)`；返回值紧邻使用处：`ExpressionStatementSyntax: popup.SetItemMetadata(index, id);`
- `Godot.PopupMenu.SetItemTooltip(int, string)`；输入表达式：`popup.SetItemTooltip(index, profile.Name + "\n" + profile.Model)`；返回值紧邻使用处：`ExpressionStatementSyntax: popup.SetItemTooltip(index, profile.Name + "\n" + profile.Model);`
- `Godot.Variant.AsString()`；输入表达式：`popup.GetItemMetadata(popup.GetItemIndex((int)id)).AsString()`；返回值紧邻使用处：`ArgumentSyntax: popup.GetItemMetadata(popup.GetItemIndex((int)id)).AsString()`
- `NationalSpire.AiRouting.Assign(NationalSpire.AiOptions, string, string, System.Action)`；输入表达式：`AiRouting.Assign(data.Ai, task, popup.GetItemMetadata(popup.GetItemIndex((int)id)).AsString(), () => SaveAiSettings(ViewData))`；返回值紧邻使用处：`ExpressionStatementSyntax: AiRouting.Assign(data.Ai, task, popup.GetItemMetadata(popup.GetItemIndex((int)id)).AsString(), () => SaveAiSettings(ViewData));`
- `NationalSpire.AiRouting.Ensure(NationalSpire.AiOptions)`；输入表达式：`AiRouting.Ensure(data.Ai)`；返回值紧邻使用处：`ExpressionStatementSyntax: AiRouting.Ensure(data.Ai);`
- `NationalSpire.AiRouting.ProfileId(NationalSpire.AiOptions, string)`；输入表达式：`AiRouting.ProfileId(data.Ai, task)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AiRouting.ProfileId(data.Ai, task)`
- `NationalSpire.CareerDropdownLayer.At(Godot.Control)`；输入表达式：`CareerDropdownLayer.At(anchor)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerDropdownLayer.At(anchor)`
- `NationalSpire.CareerDropdownLayer.Close()`；输入表达式：`dropdown.Close()`；返回值紧邻使用处：`ExpressionStatementSyntax: dropdown.Close();`
- `NationalSpire.CareerDropdownLayer.Open(Godot.Button, Godot.PopupMenu, System.Action?)`；输入表达式：`dropdown.Open(anchor,popup,() => {             if (_chatModelPopup == popup) _chatModelPopup = null;             popup.QueueFree();         })`；返回值紧邻使用处：`ExpressionStatementSyntax: dropdown.Open(anchor,popup,() => {             if (_chatModelPopup == popup) _chatModelPopup = null;             popup.QueueFree();         });`
- `NationalSpire.CareerDropdownLayer.Showing(Godot.Button)`；输入表达式：`dropdown.Showing(anchor)`；返回值紧邻使用处：`IfStatementSyntax: if (dropdown.Showing(anchor)) { dropdown.Close(); return; }`
- `NationalSpire.CareerScreen.SaveAiSettings(NationalSpire.CareerData)`；输入表达式：`SaveAiSettings(ViewData)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => SaveAiSettings(ViewData)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；输入表达式：`ShowCareerDialog("方案未保存", e.Message, () => true, "关闭", showCancel: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("方案未保存", e.Message, () => true, "关闭", showCancel: false);`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(ViewData.Ai, data.Ai)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ReferenceEquals(ViewData.Ai, data.Ai)`
- `System.Globalization.StringInfo.StringInfo(string)`；输入表达式：`new System.Globalization.StringInfo(profile.Name)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new System.Globalization.StringInfo(profile.Name)`
- `System.Globalization.StringInfo.SubstringByTextElements(int, int)`；输入表达式：`name.SubstringByTextElements(0, 24)`；返回值紧邻使用处：`BinaryExpressionSyntax: name.SubstringByTextElements(0, 24) + "…"`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("生涯已切换，请重新选择方案。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("生涯已切换，请重新选择方案。");`

**赋值（含属性/字段和局部值）：**

- `_chatModelPopup` = `null`
- `_chatModelPopup` = `popup`
- `HideOnCheckableItemSelection` = `true`
- `Name` = `"ChatModelPicker"`
- `popup.IdPressed` += `id =>          {              try              {                  if (!ReferenceEquals(ViewData.Ai, data.Ai)) throw new InvalidOperationException("生涯已切换，请重新选择方案。");                  AiRouting.Assign(data.Ai, task, popup.GetItemMetadata(popup.GetItemIndex((int)id)).AsString(), () => SaveAiSettings(ViewData));              }              catch (Exception e)              {                  ShowCareerDialog("方案未保存", e.Message, () => true, "关闭", showCancel: false);              }          }`
