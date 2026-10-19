# PromptInsertionScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`48F07123EC93F2A8448F8DD6C3875D8B5006EB132C739E5F55005F6F304F83CF`。来源：[源码](../../PromptInsertionScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-8c121d4185f5"></a>

## `NationalSpire.CareerScreen.OpenPromptInsertions(string) — private void OpenPromptInsertions(string scene)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BuildPrivateComposerActions(Godot.VBoxContainer)`](PrivateMessageScreen.cs.md#symbol-a7be0d6513a6)；[`NationalSpire.CareerScreen.CreateReplyComposer(NationalSpire.CareerData, NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-592b8f5f225f)；[`NationalSpire.CareerScreen.OpenDateScene(string)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.RenderPostComposer(NationalSpire.CareerData)`](CommunityScreen.cs.md#symbol-02ed3035beb3)

**调用：** [`Changed()`](PromptInsertionScreen.cs.md#symbol-e6b0554529c5)；`Godot.CheckBox.CheckBox()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.OptionButton.Select(int)`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.TextEdit.TextEdit()`；`Godot.Timer.Timer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`](CareerDialog.cs.md#symbol-d832b736b02b)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；`System.Math.Clamp(float, float, float)`

**字段、属性、事件及方法组引用：** `Changed()`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._stage`；`NationalSpire.PromptInsertion.Position`；`NationalSpire.PromptInsertion.Text`；`NationalSpire.PromptInsertionSettings.Enabled`；`NationalSpire.PromptInsertionSettings.Slots`；`NationalSpire.PromptInsertions.Positions`；`NationalSpire.PromptInsertions.Settings`；`Save()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Changed()`；输入表达式：`Changed()`；返回值紧邻使用处：`ExpressionStatementSyntax: Changed();`
- `Godot.CheckBox.CheckBox()`；输入表达式：`new CheckBox { Name = "PromptInsertionEnabled" + i, ButtonPressed = settings.Enabled[scene][i], TooltipText = "应用于" + title, CustomMinimumSize = new(26, 26), SizeFlagsVertical = SizeFlags.ShrinkCenter }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CheckBox { Name = "PromptInsertionEnabled" + i, ButtonPressed = settings.Enabled[scene][i], TooltipText = "应用于" + title, CustomMinimumSize = new(26, 26), SizeFlagsVertical = SizeFlags.ShrinkCenter }`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`column.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`options.AddThemeConstantOverride("separation", 4)`；返回值紧邻使用处：`ExpressionStatementSyntax: options.AddThemeConstantOverride("separation", 4);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 14);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`editor.AddThemeFontSizeOverride("font_size", 17)`；返回值紧邻使用处：`ExpressionStatementSyntax: editor.AddThemeFontSizeOverride("font_size", 17);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`position.AddThemeFontSizeOverride("font_size", 15)`；返回值紧邻使用处：`ExpressionStatementSyntax: position.AddThemeFontSizeOverride("font_size", 15);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`enabled.AddThemeStyleboxOverride(state, new StyleBoxEmpty { ContentMarginLeft = 3, ContentMarginRight = 3, ContentMarginTop = 3, ContentMarginBottom = 3 })`；返回值紧邻使用处：`ExpressionStatementSyntax: enabled.AddThemeStyleboxOverride(state, new StyleBoxEmpty { ContentMarginLeft = 3, ContentMarginRight = 3, ContentMarginTop = 3, ContentMarginBottom = 3 });`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(status)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(status);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(timer)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(timer);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(Text("提示词 " + (i + 1), 18, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(Text("提示词 " + (i + 1), 18, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(editor)`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(editor);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(options)`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(options);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`options.AddChild(enabled)`；返回值紧邻使用处：`ExpressionStatementSyntax: options.AddChild(enabled);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`options.AddChild(position)`；返回值紧邻使用处：`ExpressionStatementSyntax: options.AddChild(position);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(column)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(column);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`position.AddItem(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: position.AddItem(label);`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "PromptInsertionPosition" + i, SizeFlagsHorizontal = SizeFlags.ExpandFill, FitToLongestItem = false }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OptionButton { Name = "PromptInsertionPosition" + i, SizeFlagsHorizontal = SizeFlags.ExpandFill, FitToLongestItem = false }`
- `Godot.OptionButton.Select(int)`；输入表达式：`position.Select(settings.Slots[i].Position)`；返回值紧邻使用处：`ExpressionStatementSyntax: position.Select(settings.Slots[i].Position);`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty { ContentMarginLeft = 3, ContentMarginRight = 3, ContentMarginTop = 3, ContentMarginBottom = 3 }`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty { ContentMarginLeft = 3, ContentMarginRight = 3, ContentMarginTop = 3, ContentMarginBottom = 3 }`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Name = "PromptInsertionText" + i, Text = settings.Slots[i].Text, PlaceholderText = "输入或粘贴提示词…", CustomMinimumSize = new(0, Math.Clamp(_stage.Size.Y * .38f, 200, 420)), SizeFlagsHorizontal = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TextEdit { Name = "PromptInsertionText" + i, Text = settings.Slots[i].Text, PlaceholderText = "输入或粘贴提示词…", CustomMinimumSize = new(0, Math.Clamp(_stage.Size.Y * .38f, 200, 420)), SizeFlagsHorizontal = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary }`
- `Godot.Timer.Timer()`；输入表达式：`new Godot.Timer { OneShot = true, WaitTime = .4 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Godot.Timer { OneShot = true, WaitTime = .4 }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = 1 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = 1 }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, Math.Clamp(_stage.Size.Y * .38f, 200, 420))`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, Math.Clamp(_stage.Size.Y * .38f, 200, 420))`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(26, 26)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(26, 26)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Math.Clamp(_stage.Size.X - 150, 900, 1260), 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: box.CustomMinimumSize = new(Math.Clamp(_stage.Size.X - 150, 900, 1260), 0)`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string)`；输入表达式：`ShowCareerDialog("提示词插入 · " + title, "四段文字和位置共用；勾选仅对当前输入场景生效。编辑内容自动保存。", () => true, "关闭", box => { box.Name = "PromptInsertionDialog"; box.CustomMinimumSize = new(Math.Clamp(_stage.Size.X - 150, 900, 1260), 0); var row = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; row.AddThemeConstantOverride("separation", 14); box.AddChild(row); var status = Text("", 15, _muted); box.AddChild(status); var timer = new Godot.Timer { OneShot = true, WaitTime = .4 }; box.AddChild(timer); bool dirty = false; void Save() { if (!dirty) return; try { PromptInsertions.Save(); dirty = false; status.Text = "已保存"; } catch (Exception e) { status.Text = "保存失败：" + e.Message; Notice(status.Text, true); } } void Changed() { dirty = true; status.Text = "保存中…"; timer.Start(); } timer.Timeout += Save; box.TreeExiting += Save; for (int i = 0; i < 4; i++) { int slot = i; var column = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = 1 }; column.AddThemeConstantOverride("separation", 10); row.AddChild(column); column.AddChild(Text("提示词 " + (i + 1), 18, _ink)); var editor = new TextEdit { Name = "PromptInsertionText" + i, Text = settings.Slots[i].Text, PlaceholderText = "输入或粘贴提示词…", CustomMinimumSize = new(0, Math.Clamp(_stage.Size.Y * .38f, 200, 420)), SizeFlagsHorizontal = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary }; editor.AddThemeFontSizeOverride("font_size", 17); column.AddChild(editor); var options = new HBoxContainer(); options.AddThemeConstantOverride("separation", 4); column.AddChild(options); var enabled = new CheckBox { Name = "PromptInsertionEnabled" + i, ButtonPressed = settings.Enabled[scene][i], TooltipText = "应用于" + title, CustomMinimumSize = new(26, 26), SizeFlagsVertical = SizeFlags.ShrinkCenter }; foreach (string state in new[] { "normal", "hover", "pressed", "hover_pressed", "disabled" }) enabled.AddThemeStyleboxOverride(state, new StyleBoxEmpty { ContentMarginLeft = 3, ContentMarginRight = 3, ContentMarginTop = 3, ContentMarginBottom = 3 }); options.AddChild(enabled); var position = new OptionButton { Name = "PromptInsertionPosition" + i, SizeFlagsHorizontal = SizeFlags.ExpandFill, FitToLongestItem = false }; position.AddThemeFontSizeOverride("font_size", 15); foreach (string label in PromptInsertions.Positions) position.AddItem(label); position.Select(settings.Slots[i].Position); options.AddChild(position); editor.TextChanged += () => { settings.Slots[slot].Text = editor.Text; Changed(); }; enabled.Toggled += value => { settings.Enabled[scene][slot] = value; Changed(); }; position.ItemSelected += value => { settings.Slots[slot].Position = (int)value; Changed(); }; } }, showCancel: false)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCareerDialog("提示词插入 · " + title, "四段文字和位置共用；勾选仅对当前输入场景生效。编辑内容自动保存。", () => true, "关闭", box => { box.Name = "PromptInsertionDialog"; box.CustomMinimumSize = new(Math.Clamp(_stage.Size.X - 150, 900, 1260), 0); var row = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }; row.AddThemeConstantOverride("separation", 14); box.AddChild(row); var status = Text("", 15, _muted); box.AddChild(status); var timer = new Godot.Timer { OneShot = true, WaitTime = .4 }; box.AddChild(timer); bool dirty = false; void Save() { if (!dirty) return; try { PromptInsertions.Save(); dirty = false; status.Text = "已保存"; } catch (Exception e) { status.Text = "保存失败：" + e.Message; Notice(status.Text, true); } } void Changed() { dirty = true; status.Text = "保存中…"; timer.Start(); } timer.Timeout += Save; box.TreeExiting += Save; for (int i = 0; i < 4; i++) { int slot = i; var column = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill, SizeFlagsStretchRatio = 1 }; column.AddThemeConstantOverride("separation", 10); row.AddChild(column); column.AddChild(Text("提示词 " + (i + 1), 18, _ink)); var editor = new TextEdit { Name = "PromptInsertionText" + i, Text = settings.Slots[i].Text, PlaceholderText = "输入或粘贴提示词…", CustomMinimumSize = new(0, Math.Clamp(_stage.Size.Y * .38f, 200, 420)), SizeFlagsHorizontal = SizeFlags.ExpandFill, WrapMode = TextEdit.LineWrappingMode.Boundary }; editor.AddThemeFontSizeOverride("font_size", 17); column.AddChild(editor); var options = new HBoxContainer(); options.AddThemeConstantOverride("separation", 4); column.AddChild(options); var enabled = new CheckBox { Name = "PromptInsertionEnabled" + i, ButtonPressed = settings.Enabled[scene][i], TooltipText = "应用于" + title, CustomMinimumSize = new(26, 26), SizeFlagsVertical = SizeFlags.ShrinkCenter }; foreach (string state in new[] { "normal", "hover", "pressed", "hover_pressed", "disabled" }) enabled.AddThemeStyleboxOverride(state, new StyleBoxEmpty { ContentMarginLeft = 3, ContentMarginRight = 3, ContentMarginTop = 3, ContentMarginBottom = 3 }); options.AddChild(enabled); var position = new OptionButton { Name = "PromptInsertionPosition" + i, SizeFlagsHorizontal = SizeFlags.ExpandFill, FitToLongestItem = false }; position.AddThemeFontSizeOverride("font_size", 15); foreach (string label in PromptInsertions.Positions) position.AddItem(label); position.Select(settings.Slots[i].Position); options.AddChild(position); editor.TextChanged += () => { settings.Slots[slot].Text = editor.Text; Changed(); }; enabled.Toggled += value => { settings.Enabled[scene][slot] = value; Changed(); }; position.ItemSelected += value => { settings.Slots[slot].Position = (int)value; Changed(); }; } }, showCancel: false);`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("", 15, _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("提示词 " + (i + 1), 18, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("提示词 " + (i + 1), 18, _ink)`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp(_stage.Size.X - 150, 900, 1260)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(_stage.Size.X - 150, 900, 1260)`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp(_stage.Size.Y * .38f, 200, 420)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(_stage.Size.Y * .38f, 200, 420)`

**赋值（含属性/字段和局部值）：**

- `ButtonPressed` = `settings.Enabled[scene][i]`
- `ContentMarginBottom` = `3`
- `ContentMarginLeft` = `3`
- `ContentMarginRight` = `3`
- `ContentMarginTop` = `3`
- `CustomMinimumSize` = `new(0, Math.Clamp(_stage.Size.Y * .38f, 200, 420))`
- `CustomMinimumSize` = `new(26, 26)`
- `FitToLongestItem` = `false`
- `Name` = `"PromptInsertionEnabled" + i`
- `Name` = `"PromptInsertionPosition" + i`
- `Name` = `"PromptInsertionText" + i`
- `OneShot` = `true`
- `PlaceholderText` = `"输入或粘贴提示词…"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsStretchRatio` = `1`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `Text` = `settings.Slots[i].Text`
- `TooltipText` = `"应用于" + title`
- `WaitTime` = `.4`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`
- `box.CustomMinimumSize` = `new(Math.Clamp(_stage.Size.X - 150, 900, 1260), 0)`
- `box.Name` = `"PromptInsertionDialog"`
- `box.TreeExiting` += `Save`
- `editor.TextChanged` += `() => { settings.Slots[slot].Text = editor.Text; Changed(); }`
- `enabled.Toggled` += `value => { settings.Enabled[scene][slot] = value; Changed(); }`
- `position.ItemSelected` += `value => { settings.Slots[slot].Position = (int)value; Changed(); }`
- `settings.Enabled[scene][slot]` = `value`
- `settings.Slots[slot].Position` = `(int)value`
- `settings.Slots[slot].Text` = `editor.Text`
- `timer.Timeout` += `Save`

<a id="symbol-c2cd5419d101"></a>

## `Save() — void Save()`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.PromptInsertions.Save()`](PromptInsertions.cs.md#symbol-ab02e6f288c3)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.PromptInsertions.Save()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(status.Text, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(status.Text, true);`
- `NationalSpire.PromptInsertions.Save()`；输入表达式：`PromptInsertions.Save()`；返回值紧邻使用处：`ExpressionStatementSyntax: PromptInsertions.Save();`

**赋值（含属性/字段和局部值）：**

- `dirty` = `false`
- `status.Text` = `"保存失败：" + e.Message`
- `status.Text` = `"已保存"`

<a id="symbol-e6b0554529c5"></a>

## `Changed() — void Changed()`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPromptInsertions(string)`](PromptInsertionScreen.cs.md#symbol-8c121d4185f5)

**调用：** `Godot.Timer.Start(double)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Timer.Start(double)`；输入表达式：`timer.Start()`；返回值紧邻使用处：`ExpressionStatementSyntax: timer.Start();`

**赋值（含属性/字段和局部值）：**

- `dirty` = `true`
- `status.Text` = `"保存中…"`
