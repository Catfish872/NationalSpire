# AiTaskRoutePicker.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`EC6EB51481C7673D05B39D7D41551BCBA601686F8E2CE2E3AB38F3F8A106F4CD`。来源：[源码](../../AiTaskRoutePicker.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.AiTaskRoutePicker`。

字段、事件及初始值（源码原样）：

```csharp
private AiOptions _options = null!;
private string _task = "";
private OptionButton _choice = null!;
private Label _model = null!;
private bool _refreshing;
```

<a id="symbol-7a35c2ddf3d1"></a>

## `NationalSpire.AiTaskRoutePicker.Configure(NationalSpire.AiOptions, string, System.Action, System.Action<string, bool>) — public void Configure(AiOptions options, string task, Action save, Action<string, bool> notice)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?)`](AiSettingsPanel.cs.md#symbol-8fb9cbc85381)

**调用：** `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Label.Label()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.GetItemMetadata(int)`；`Godot.OptionButton.OptionButton()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Variant.AsString()`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.AiRouting.Assign(NationalSpire.AiOptions, string, string, System.Action)`](AiRouting.cs.md#symbol-dcdbadb40401)；[`NationalSpire.AiRouting.Category(string)`](AiRouting.cs.md#symbol-a9d92e7d36e8)；[`NationalSpire.AiTaskRoutePicker.Refresh()`](AiTaskRoutePicker.cs.md#symbol-8a208d29fd78)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`System.Action<T1, T2>.Invoke(T1, T2)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiRouting.Assign(NationalSpire.AiOptions, string, string, System.Action)`；`NationalSpire.AiRouting.Category(string)`；`NationalSpire.AiRouting.Tasks`；`NationalSpire.AiTaskRoutePicker.Refresh()`；`NationalSpire.AiTaskRoutePicker._choice`；`NationalSpire.AiTaskRoutePicker._model`；`NationalSpire.AiTaskRoutePicker._options`；`NationalSpire.AiTaskRoutePicker._refreshing`；`NationalSpire.AiTaskRoutePicker._task`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Muted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_model.AddThemeColorOverride("font_color", CareerVisuals.Muted)`；返回值紧邻使用处：`ExpressionStatementSyntax: _model.AddThemeColorOverride("font_color", CareerVisuals.Muted);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 5)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 5);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`_model.AddThemeFontSizeOverride("font_size", 14)`；返回值紧邻使用处：`ExpressionStatementSyntax: _model.AddThemeFontSizeOverride("font_size", 14);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`title.AddThemeFontSizeOverride("font_size", 18)`；返回值紧邻使用处：`ExpressionStatementSyntax: title.AddThemeFontSizeOverride("font_size", 18);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`AddThemeStyleboxOverride("panel", CareerVisuals.Box("172f3c", "345363", 7, 12))`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeStyleboxOverride("panel", CareerVisuals.Box("172f3c", "345363", 7, 12));`
- `Godot.Label.Label()`；输入表达式：`new Label { Name = "AiRouteModel", AutowrapMode = TextServer.AutowrapMode.WordSmart }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _model = new Label { Name = "AiRouteModel", AutowrapMode = TextServer.AutowrapMode.WordSmart }`
- `Godot.Label.Label()`；输入表达式：`new Label { Text = AiRouting.Tasks.First(t => t.Id == _task).Name }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { Text = AiRouting.Tasks.First(t => t.Id == _task).Name }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(_choice)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(_choice);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(_model)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(_model);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(title);`
- `Godot.OptionButton.GetItemMetadata(int)`；输入表达式：`_choice.GetItemMetadata((int)index)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _choice.GetItemMetadata((int)index).AsString`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton { Name = "AiRoute_" + _task, FitToLongestItem = false, ClipText = true, TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis, CustomMinimumSize = new(0, 40), SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _choice = new OptionButton { Name = "AiRoute_" + _task, FitToLongestItem = false, ClipText = true, TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis, CustomMinimumSize = new(0, 40), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Variant.AsString()`；输入表达式：`_choice.GetItemMetadata((int)index).AsString()`；返回值紧邻使用处：`ArgumentSyntax: _choice.GetItemMetadata((int)index).AsString()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 40)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 40)`
- `NationalSpire.AiRouting.Assign(NationalSpire.AiOptions, string, string, System.Action)`；输入表达式：`AiRouting.Assign(_options, _task, _choice.GetItemMetadata((int)index).AsString(), save)`；返回值紧邻使用处：`ExpressionStatementSyntax: AiRouting.Assign(_options, _task, _choice.GetItemMetadata((int)index).AsString(), save);`
- `NationalSpire.AiRouting.Category(string)`；输入表达式：`AiRouting.Category(task)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _task = AiRouting.Category(task)`
- `NationalSpire.AiTaskRoutePicker.Refresh()`；输入表达式：`Refresh()`；返回值紧邻使用处：`ExpressionStatementSyntax: Refresh();`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("172f3c", "345363", 7, 12)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("172f3c", "345363", 7, 12)`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`notice("已保存，下次请求使用所选方案。", false)`；返回值紧邻使用处：`ExpressionStatementSyntax: notice("已保存，下次请求使用所选方案。", false);`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`notice("设置未能保存：" + e.Message, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: notice("设置未能保存：" + e.Message, true);`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`AiRouting.Tasks.First(t => t.Id == _task)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AiRouting.Tasks.First(t => t.Id == _task).Name`

**赋值（含属性/字段和局部值）：**

- `AutowrapMode` = `TextServer.AutowrapMode.WordSmart`
- `ClipText` = `true`
- `CustomMinimumSize` = `new(0, 40)`
- `FitToLongestItem` = `false`
- `Name` = `"AiRouteModel"`
- `Name` = `"AiRoute_" + _task`
- `Name` = `"AiTaskRoute_" + _task`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `Text` = `AiRouting.Tasks.First(t => t.Id == _task).Name`
- `_choice.ItemSelected` += `index => { if (_refreshing) return; try { AiRouting.Assign(_options, _task, _choice.GetItemMetadata((int)index).AsString(), save); notice("已保存，下次请求使用所选方案。", false); } catch (Exception e) { notice("设置未能保存：" + e.Message, true); } Refresh(); }`
- `_choice` = `new OptionButton { Name = "AiRoute_" + _task, FitToLongestItem = false, ClipText = true, TextOverrunBehavior = TextServer.OverrunBehavior.TrimEllipsis, CustomMinimumSize = new(0, 40), SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `_model` = `new Label { Name = "AiRouteModel", AutowrapMode = TextServer.AutowrapMode.WordSmart }`
- `_options` = `options`
- `_task` = `AiRouting.Category(task)`

<a id="symbol-8a208d29fd78"></a>

## `NationalSpire.AiTaskRoutePicker.Refresh() — public void Refresh()`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiTaskRoutePicker.Configure(NationalSpire.AiOptions, string, System.Action, System.Action<string, bool>)`](AiTaskRoutePicker.cs.md#symbol-7a35c2ddf3d1)；[`RefreshRoutes()`](AiSettingsPanel.cs.md#symbol-7d731dbc5403)

**调用：** `Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.Clear()`；`Godot.OptionButton.Select(int)`；`Godot.OptionButton.SetItemMetadata(int, Godot.Variant)`；[`NationalSpire.AiRouting.ProfileId(NationalSpire.AiOptions, string)`](AiRouting.cs.md#symbol-ccbfd0b083bc)

**字段、属性、事件及方法组引用：** `NationalSpire.AiConnectionProfile.Model`；`NationalSpire.AiConnectionProfile.Name`；`NationalSpire.AiOptions.ConnectionProfiles`；`NationalSpire.AiRouting.ProfileId(NationalSpire.AiOptions, string)`；`NationalSpire.AiTaskRoutePicker._choice`；`NationalSpire.AiTaskRoutePicker._model`；`NationalSpire.AiTaskRoutePicker._options`；`NationalSpire.AiTaskRoutePicker._refreshing`；`NationalSpire.AiTaskRoutePicker._task`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`_choice.AddItem(entry.Value.Name)`；返回值紧邻使用处：`ExpressionStatementSyntax: _choice.AddItem(entry.Value.Name);`
- `Godot.OptionButton.Clear()`；输入表达式：`_choice.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _choice.Clear();`
- `Godot.OptionButton.Select(int)`；输入表达式：`_choice.Select(i)`；返回值紧邻使用处：`ExpressionStatementSyntax: _choice.Select(i);`
- `Godot.OptionButton.SetItemMetadata(int, Godot.Variant)`；输入表达式：`_choice.SetItemMetadata(i, entry.Key)`；返回值紧邻使用处：`ExpressionStatementSyntax: _choice.SetItemMetadata(i, entry.Key);`
- `NationalSpire.AiRouting.ProfileId(NationalSpire.AiOptions, string)`；输入表达式：`AiRouting.ProfileId(_options, _task)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AiRouting.ProfileId(_options, _task)`

**赋值（含属性/字段和局部值）：**

- `_choice.TooltipText` = `_options.ConnectionProfiles[assigned].Name`
- `_model.Text` = `_options.ConnectionProfiles[assigned].Model`
- `_refreshing` = `false`
- `_refreshing` = `true`
