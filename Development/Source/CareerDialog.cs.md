# CareerDialog.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`F186D62D231AA9DF2F0B6BE32AE68AD94A6D05AC5BD71F2DE3D7D9355E2CB7AE`。来源：[源码](../../CareerDialog.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private Control? _dialogOverlay;
private Action? _cancelDialog;
```

<a id="symbol-ecc011933bb1"></a>

## `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool) — private void ShowCareerDialog(string title, string message, Func<bool> confirm, string confirmText = "确认", Action<VBoxContainer>? contents = null, bool showCancel = true, bool compact = false)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Confirm(string, string, System.Action)`](PromptScreen.cs.md#symbol-952ba2834cf8)；[`NationalSpire.CareerScreen.AddPrivateLearning(NationalSpire.PrivateTurn, NationalSpire.PrivateLearning)`](PrivateMemoryScreen.cs.md#symbol-74357ea296a8)；[`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.ArbitrationCard(NationalSpire.CareerData, NationalSpire.ArbitrationRecord)`](ArbitrationScreen.cs.md#symbol-8d41f13d5476)；[`NationalSpire.CareerScreen.ClubMarket(NationalSpire.CareerData, bool)`](OwnedClubScreen.cs.md#symbol-b1e2f4fe72a4)；[`NationalSpire.CareerScreen.ClubProfileActions(NationalSpire.CareerData, NationalSpire.CareerPerson, Godot.VBoxContainer)`](OwnedClubScreen.cs.md#symbol-07281993c5a0)；[`NationalSpire.CareerScreen.ClubReview(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubScreen.cs.md#symbol-ae7b54f0270a)；[`NationalSpire.CareerScreen.ClubWizard(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-8f3c0cb211aa)；[`NationalSpire.CareerScreen.CoachAppointmentDialog(NationalSpire.CareerData, string)`](CoachScreen.cs.md#symbol-e2df497af307)；[`NationalSpire.CareerScreen.CoachManagement(NationalSpire.CareerData)`](CoachScreen.cs.md#symbol-7f703533cff4)；[`NationalSpire.CareerScreen.ConfirmCareerDeletion(string, int, int, System.Action, System.Func<System.Threading.Tasks.Task>?)`](CareerLibraryScreen.cs.md#symbol-fb19ffb68278)；[`NationalSpire.CareerScreen.ConfirmLife(string, string, System.Action)`](LifeScreen.cs.md#symbol-d61ca43b835f)；[`NationalSpire.CareerScreen.ConfirmPromptImport(NationalSpire.CareerData, string, System.Action)`](PromptScreen.cs.md#symbol-b9da8509093b)；[`NationalSpire.CareerScreen.ConsumerInvite(NationalSpire.CareerData, NationalSpire.Good, string, int)`](ConsumerScreen.cs.md#symbol-244128db5d80)；[`NationalSpire.CareerScreen.DeletePrivateMessage(NationalSpire.PrivateTurn, bool)`](PrivateMemoryScreen.cs.md#symbol-fa60614ca4c0)；[`NationalSpire.CareerScreen.EditPrivateMessage(NationalSpire.PrivateTurn, bool)`](PrivateMemoryScreen.cs.md#symbol-fc1c08645b40)；[`NationalSpire.CareerScreen.EditPrivateSummary(NationalSpire.PrivateSummary, string)`](PrivateMemoryScreen.cs.md#symbol-92dafd8c57da)；[`NationalSpire.CareerScreen.GroupActions()`](GroupChatDialogs.cs.md#symbol-38cd67d996b6)；[`NationalSpire.CareerScreen.GroupArbitrationDialog()`](GroupChatDialogs.cs.md#symbol-b436b0c3aa2f)；[`NationalSpire.CareerScreen.GroupMemberPicker(NationalSpire.GroupChat?, System.Action<System.Collections.Generic.List<string>>, bool, string, bool)`](GroupChatScreen.cs.md#symbol-26ccde004356)；[`NationalSpire.CareerScreen.GroupMemory()`](GroupChatDialogs.cs.md#symbol-bf729ae9b3eb)；[`NationalSpire.CareerScreen.GroupSettings()`](GroupChatDialogs.cs.md#symbol-a263539cc71f)；[`NationalSpire.CareerScreen.GroupTrainingPicker()`](GroupChatDialogs.cs.md#symbol-1e2068d8bf79)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerScreen.OpenAvatarSettings(NationalSpire.CareerData, NationalSpire.PlayerAvatar?, System.Action<NationalSpire.PlayerAvatar>?, string, NationalSpire.AvatarArt?)`](AvatarScreen.cs.md#symbol-368e97fdd27f)；[`NationalSpire.CareerScreen.OpenCareerLibrary()`](CareerLibraryScreen.cs.md#symbol-57e1d5f83960)；[`NationalSpire.CareerScreen.OpenCharacterCard(NationalSpire.CareerData, string?, NationalSpire.CareerPerson?)`](CharacterCardScreen.cs.md#symbol-a498f622bb3e)；[`NationalSpire.CareerScreen.OpenFilePicker(string, string[], System.Action<string>)`](CareerFilePicker.cs.md#symbol-e74b66910ad6)；[`NationalSpire.CareerScreen.OpenPromptSettings(NationalSpire.CareerData)`](PromptScreen.cs.md#symbol-fda1b116cf88)；[`NationalSpire.CareerScreen.OpenPromptTest(NationalSpire.CareerData, Godot.Control, System.Collections.Generic.Dictionary<string, string>, string)`](PromptTestScreen.cs.md#symbol-4e150abf093b)；[`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)；[`NationalSpire.CareerScreen.PlayerPositionDialog(NationalSpire.CareerData)`](CoachScreen.cs.md#symbol-5e31a957c01c)；[`NationalSpire.CareerScreen.PreviewGroupPrompt()`](GroupChatDialogs.cs.md#symbol-b6bc7a2d0206)；[`NationalSpire.CareerScreen.PreviewPrivateAttachment(NationalSpire.PrivateOffer, bool)`](PrivateMemoryScreen.cs.md#symbol-5c877df45b85)；[`NationalSpire.CareerScreen.PreviewPrivatePrompt()`](PrivateMessageScreen.cs.md#symbol-aefc38a1fba3)；[`NationalSpire.CareerScreen.PrivateActions()`](PrivateMessageScreen.cs.md#symbol-6e8c11ead905)；[`NationalSpire.CareerScreen.PrivateArbitrationDialog()`](ArbitrationScreen.cs.md#symbol-63e3d9aaa6df)；[`NationalSpire.CareerScreen.PrivateLineupPicker()`](CoachScreen.cs.md#symbol-78315f2693ca)；[`NationalSpire.CareerScreen.PrivateMatchPicker()`](PrivateMessageScreen.cs.md#symbol-aa7339f37b26)；[`NationalSpire.CareerScreen.PrivateMemory()`](PrivateMemoryScreen.cs.md#symbol-942a4a496637)；[`NationalSpire.CareerScreen.PrivateMessageMenu(NationalSpire.PrivateTurn, bool)`](PrivateMemoryScreen.cs.md#symbol-9a1e5f17a52a)；[`NationalSpire.CareerScreen.PrivateSettings()`](PrivateMessageScreen.cs.md#symbol-e86e401f7314)；[`NationalSpire.CareerScreen.PrivateSharePicker(string)`](PrivateMemoryScreen.cs.md#symbol-b8d901a6cb80)；[`NationalSpire.CareerScreen.PrivateTrainingPicker()`](CoachScreen.cs.md#symbol-2609d8a7ba68)；[`NationalSpire.CareerScreen.RenamePlayer(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-b0bc87216d33)；[`NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`](CommunityScreen.cs.md#symbol-6bdab2812eba)；[`Section(string)`](PrivateMemoryScreen.cs.md#symbol-55885a3fae26)

**调用：** [`Controls(Godot.Node)`](CareerDialog.cs.md#symbol-5394dba7c60c)；[`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`](PrivateMemoryScreen.cs.md#symbol-5378f7528eb3)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.CenterContainer.CenterContainer()`；`Godot.Color.Color(float, float, float, float)`；`Godot.Color.Color(string)`；`Godot.ColorRect.ColorRect()`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.GrabFocus()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetViewport()`；`Godot.Node.QueueFree()`；`Godot.PanelContainer.PanelContainer()`；`Godot.Vector2.Vector2(float, float)`；`Godot.Viewport.GuiGetFocusOwner()`；`NationalSpire.PrivateOrnament.PrivateOrnament()`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `(Godot.Control Control, Godot.Control.FocusModeEnum Mode).Control`；`(Godot.Control Control, Godot.Control.FocusModeEnum Mode).Mode`；`Accept()`；`CloseDialog()`；`Controls(Godot.Node)`；`NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._privateOverlay`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.PrivateOrnament.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Controls(Godot.Node)`；输入表达式：`Controls(_stage)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Controls(_stage).Where`
- `Godot.CenterContainer.CenterContainer()`；输入表达式：`new CenterContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CenterContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(0, 0, 0, .68f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Color = new Color(0, 0, 0, .68f)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("172330")`；返回值紧邻使用处：`ArgumentSyntax: new Color("172330")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("fff0ee")`；返回值紧邻使用处：`ArgumentSyntax: new Color("fff0ee")`
- `Godot.ColorRect.ColorRect()`；输入表达式：`new ColorRect { Name = "CareerDialog", Color = new Color(0, 0, 0, .68f), MouseFilter = MouseFilterEnum.Stop, ZIndex = 40 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ColorRect { Name = "CareerDialog", Color = new Color(0, 0, 0, .68f), MouseFilter = MouseFilterEnum.Stop, ZIndex = 40 }`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`accept.AddThemeColorOverride("font_color", new Color("172330"))`；返回值紧邻使用处：`ExpressionStatementSyntax: accept.AddThemeColorOverride("font_color", new Color("172330"));`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`accept.AddThemeColorOverride("font_color", new Color("fff0ee"))`；返回值紧邻使用处：`ExpressionStatementSyntax: accept.AddThemeColorOverride("font_color", new Color("fff0ee"));`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("separation", 14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 22)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 22);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`accept.AddThemeStyleboxOverride("normal", CareerVisuals.Box("2c505c", "63d4c5", 8, 12))`；返回值紧邻使用处：`ExpressionStatementSyntax: accept.AddThemeStyleboxOverride("normal", CareerVisuals.Box("2c505c", "63d4c5", 8, 12));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`accept.AddThemeStyleboxOverride("normal", CareerVisuals.Box("57363e", "bb7981", 8, 12))`；返回值紧邻使用处：`ExpressionStatementSyntax: accept.AddThemeStyleboxOverride("normal", CareerVisuals.Box("57363e", "bb7981", 8, 12));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`accept.AddThemeStyleboxOverride("normal", CareerVisuals.Box("d9bd7e", "f0dca7", 8, 12))`；返回值紧邻使用处：`ExpressionStatementSyntax: accept.AddThemeStyleboxOverride("normal", CareerVisuals.Box("d9bd7e", "f0dca7", 8, 12));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("152635", "657888", 2, 30))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("152635", "657888", 2, 30));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("192c3e", "6b879b", 12, 26))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("192c3e", "6b879b", 12, 26));`
- `Godot.Control.GrabFocus()`；输入表达式：`accept.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: accept.GrabFocus();`
- `Godot.Control.GrabFocus()`；输入表达式：`cancel.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: cancel.GrabFocus();`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`center.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: center.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { Alignment = BoxContainer.AlignmentMode.End }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { Alignment = BoxContainer.AlignmentMode.End }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_stage.AddChild(shade)`；返回值紧邻使用处：`ExpressionStatementSyntax: _stage.AddChild(shade);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(accept)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(accept);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(cancel)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(cancel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(message, 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(message, 18, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(title, compact ? 24 : 27, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(title, compact ? 24 : 27, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`center.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: center.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(new PrivateOrnament { Kind = "archiveWindow", MouseFilter = MouseFilterEnum.Ignore })`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(new PrivateOrnament { Kind = "archiveWindow", MouseFilter = MouseFilterEnum.Ignore });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`shade.AddChild(center)`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.AddChild(center);`
- `Godot.Node.GetViewport()`；输入表达式：`GetViewport()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetViewport().GuiGetFocusOwner`
- `Godot.Node.QueueFree()`；输入表达式：`cancel.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: cancel.QueueFree();`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer()`；返回值紧邻使用处：`ConditionalExpressionSyntax: _privateOverlay != null ? new PanelContainer() : Card()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(110, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: cancel.CustomMinimumSize = new Vector2(110, 48)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(140, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: accept.CustomMinimumSize = new Vector2(140, 48)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(compact ? 440 : 600, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: box.CustomMinimumSize = new Vector2(compact ? 440 : 600, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(compact ? 500 : 660, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: panel.CustomMinimumSize = new Vector2(compact ? 500 : 660, 0)`
- `Godot.Viewport.GuiGetFocusOwner()`；输入表达式：`GetViewport().GuiGetFocusOwner()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetViewport().GuiGetFocusOwner()`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button("取消", CloseDialog, 130)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _privateOverlay != null ? PrivateButton("取消", CloseDialog, 110) : Button("取消", CloseDialog, 130)`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(confirmText, Accept, 170)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _privateOverlay != null ? PrivateButton(confirmText, Accept, 150) : Button(confirmText, Accept, 170)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`ConditionalExpressionSyntax: _privateOverlay != null ? new PanelContainer() : Card()`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(panel)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(panel)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton("取消", CloseDialog, 110)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _privateOverlay != null ? PrivateButton("取消", CloseDialog, 110) : Button("取消", CloseDialog, 130)`
- `NationalSpire.CareerScreen.PrivateButton(string, System.Action, float)`；输入表达式：`PrivateButton(confirmText, Accept, 150)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _privateOverlay != null ? PrivateButton(confirmText, Accept, 150) : Button(confirmText, Accept, 170)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(message, 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(message, 18, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(title, compact ? 24 : 27, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(title, compact ? 24 : 27, _gold)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("152635", "657888", 2, 30)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("152635", "657888", 2, 30)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("192c3e", "6b879b", 12, 26)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("192c3e", "6b879b", 12, 26)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("2c505c", "63d4c5", 8, 12)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("2c505c", "63d4c5", 8, 12)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("57363e", "bb7981", 8, 12)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("57363e", "bb7981", 8, 12)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("d9bd7e", "f0dca7", 8, 12)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("d9bd7e", "f0dca7", 8, 12)`
- `NationalSpire.PrivateOrnament.PrivateOrnament()`；输入表达式：`new PrivateOrnament { Kind = "archiveWindow", MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`ArgumentSyntax: new PrivateOrnament { Kind = "archiveWindow", MouseFilter = MouseFilterEnum.Ignore }`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(box)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: contents?.Invoke(box)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None).Select(c => (Control: c, Mode: c.FocusMode))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None).Select(c => (Control: c, Mode: c.FocusMode)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None).Select(c => (Control: c, Mode: c.FocusMode)).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None).Select(c => (Control: c, Mode: c.FocusMode)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Controls(_stage).Where(c => c.FocusMode != FocusModeEnum.None).Select`

**赋值（含属性/字段和局部值）：**

- `_cancelDialog` = `CloseDialog`
- `_dialogOverlay` = `shade`
- `accept.CustomMinimumSize` = `new Vector2(140, 48)`
- `accept.Name` = `"CareerDialogConfirm"`
- `Alignment` = `BoxContainer.AlignmentMode.End`
- `box.CustomMinimumSize` = `new Vector2(compact ? 440 : 600, 0)`
- `cancel.CustomMinimumSize` = `new Vector2(110, 48)`
- `cancel.Name` = `"CareerDialogCancel"`
- `Color` = `new Color(0, 0, 0, .68f)`
- `entry.Control.FocusMode` = `FocusModeEnum.None`
- `Kind` = `"archiveWindow"`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `MouseFilter` = `MouseFilterEnum.Stop`
- `Name` = `"CareerDialog"`
- `panel.CustomMinimumSize` = `new Vector2(compact ? 500 : 660, 0)`
- `panel.MouseFilter` = `MouseFilterEnum.Stop`
- `panel.Name` = `"CareerDialogPanel"`
- `ZIndex` = `40`

<a id="symbol-5394dba7c60c"></a>

## `Controls(Godot.Node) — IEnumerable<Control> Controls(Node node)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Controls(Godot.Node)`](CareerDialog.cs.md#symbol-5394dba7c60c)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool)`](CareerDialog.cs.md#symbol-ecc011933bb1)

**调用：** [`Controls(Godot.Node)`](CareerDialog.cs.md#symbol-5394dba7c60c)；`Godot.Node.GetChildren(bool)`

**字段、属性、事件及方法组引用：** `Controls(Godot.Node)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Controls(Godot.Node)`；输入表达式：`Controls(child)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var nested in Controls(child)) yield return nested;`
- `Godot.Node.GetChildren(bool)`；输入表达式：`node.GetChildren()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var child in node.GetChildren())              {                  if (child is Control c) yield return c;                  foreach (var nested in Controls(child)) yield return nested;              }`

**赋值（含属性/字段和局部值）：**


<a id="symbol-dd90c3b6c6e5"></a>

## `CloseDialog() — void CloseDialog()`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Accept()`](CareerDialog.cs.md#symbol-e5197a704069)

**调用：** `Godot.CanvasItem.Hide()`；`Godot.CanvasItem.IsVisibleInTree()`；`Godot.Control.GrabFocus()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.Node.IsInsideTree()`；`Godot.Node.QueueFree()`；`Godot.Node.RemoveChild(Godot.Node)`

**字段、属性、事件及方法组引用：** `(Godot.Control Control, Godot.Control.FocusModeEnum Mode).Control`；`(Godot.Control Control, Godot.Control.FocusModeEnum Mode).Mode`；`NationalSpire.CareerScreen._cancelDialog`；`NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.CareerScreen._stage`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`shade.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.Hide();`
- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`previousFocus.IsVisibleInTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(previousFocus) && previousFocus.IsInsideTree() && !previousFocus.IsQueuedForDeletion() && previousFocus.IsVisibleInTree()`
- `Godot.Control.GrabFocus()`；输入表达式：`previousFocus.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: previousFocus.GrabFocus();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(entry.Control)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(entry.Control) && !entry.Control.IsQueuedForDeletion()`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(previousFocus)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(previousFocus) && previousFocus.IsInsideTree()`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`entry.Control.IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !entry.Control.IsQueuedForDeletion()`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`previousFocus.IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !previousFocus.IsQueuedForDeletion()`
- `Godot.Node.IsInsideTree()`；输入表达式：`previousFocus.IsInsideTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(previousFocus) && previousFocus.IsInsideTree()`
- `Godot.Node.QueueFree()`；输入表达式：`shade.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: shade.QueueFree();`
- `Godot.Node.RemoveChild(Godot.Node)`；输入表达式：`_stage.RemoveChild(shade)`；返回值紧邻使用处：`ExpressionStatementSyntax: _stage.RemoveChild(shade);`

**赋值（含属性/字段和局部值）：**

- `_cancelDialog` = `null`
- `_dialogOverlay` = `null`
- `closed` = `true`
- `entry.Control.FocusMode` = `entry.Mode`

<a id="symbol-e5197a704069"></a>

## `Accept() — void Accept()`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`CloseDialog()`](CareerDialog.cs.md#symbol-dd90c3b6c6e5)；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `CloseDialog()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CloseDialog()`；输入表达式：`CloseDialog()`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseDialog();`
- `System.Func<TResult>.Invoke()`；输入表达式：`confirm()`；返回值紧邻使用处：`BinaryExpressionSyntax: !closed && confirm()`

**赋值（含属性/字段和局部值）：**
