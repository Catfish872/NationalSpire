# RandomEventCustomScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`778C8438FB7B29218D7A13D616296DECF2CB1620883DB0799A40D455487BA020`。来源：[源码](../../RandomEventCustomScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.EventStoryView`。

字段、事件及初始值（源码原样）：

```csharp
public Action<string>? Custom;
public Action? ConfirmCustom;
private VBoxContainer _custom = null!, _customEditor = null!, _customEffects = null!;
private EventStoryButton _customEntry = null!;
private TextEdit _customInput = null!;
private RichTextLabel _customResult = null!;
private Label _customPhase = null!;
private Button _customGenerate = null!, _customConfirm = null!, _customBack = null!;
private bool _customExpanded;
private string _customId = "", _customPreview = "";
private RandomEventOption? _customEffectsOption;
```

<a id="symbol-9227d5a27a22"></a>

## `NationalSpire.EventStoryView.CustomInputText — public string CustomInputText`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.EventStoryView._customInput`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9f8527a6f5e4"></a>

## `NationalSpire.EventStoryView.BuildCustomAction(Godot.VBoxContainer) — private void BuildCustomAction(VBoxContainer parent)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EventStoryView._Ready()`](RandomEventScreen.cs.md#symbol-d31ee33f7cb0)

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.EventStoryView.ActionButton(string, System.Action)`](RandomEventScreen.cs.md#symbol-8068df83bcbc)；[`NationalSpire.EventStoryView.Rich(int)`](RandomEventScreen.cs.md#symbol-b60c5aa36cb9)；[`NationalSpire.EventStoryView.Words(string, int, Godot.Color)`](RandomEventScreen.cs.md#symbol-56ea79fa7863)；`Godot.CanvasItem.Hide()`；`Godot.CanvasItem.Show()`；`Godot.Color.Color(string)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.GrabFocus()`；`Godot.HFlowContainer.HFlowContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.TextEdit.TextEdit()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.EventStoryButton.EventStoryButton()`；`string.Trim()`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.EventStoryButton.Caption`；`NationalSpire.EventStoryButton.Detail`；`NationalSpire.EventStoryButton.Mark`；`NationalSpire.EventStoryView._custom`；`NationalSpire.EventStoryView._customBack`；`NationalSpire.EventStoryView._customConfirm`；`NationalSpire.EventStoryView._customEditor`；`NationalSpire.EventStoryView._customEffects`；`NationalSpire.EventStoryView._customEntry`；`NationalSpire.EventStoryView._customExpanded`；`NationalSpire.EventStoryView._customGenerate`；`NationalSpire.EventStoryView._customInput`；`NationalSpire.EventStoryView._customPhase`；`NationalSpire.EventStoryView._customResult`；`NationalSpire.EventStoryView._options`；`NationalSpire.EventStoryView.ActionButton(string, System.Action)`；`NationalSpire.EventStoryView.ConfirmCustom`；`NationalSpire.EventStoryView.Custom`；`NationalSpire.EventStoryView.Gold`；`NationalSpire.EventStoryView.Rich(int)`；`NationalSpire.EventStoryView.Tick`；`NationalSpire.EventStoryView.Words(string, int, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`_customEntry.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _customEntry.Hide();`
- `Godot.CanvasItem.Hide()`；输入表达式：`_options.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _options.Hide();`
- `Godot.CanvasItem.Hide()`；输入表达式：`panel.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.Hide();`
- `Godot.CanvasItem.Show()`；输入表达式：`_customEntry.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: _customEntry.Show();`
- `Godot.CanvasItem.Show()`；输入表达式：`_options.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: _options.Show();`
- `Godot.CanvasItem.Show()`；输入表达式：`panel.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.Show();`
- `Godot.Color.Color(string)`；输入表达式：`new("152635")`；返回值紧邻使用处：`ArgumentSyntax: new("152635")`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_customConfirm.AddThemeColorOverride("font_color", new("152635"))`；返回值紧邻使用处：`ExpressionStatementSyntax: _customConfirm.AddThemeColorOverride("font_color", new("152635"));`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_custom.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: _custom.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_customEditor.AddThemeConstantOverride("separation", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: _customEditor.AddThemeConstantOverride("separation", 12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_customEffects.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: _customEffects.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("h_separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("h_separation", 10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`actions.AddThemeConstantOverride("v_separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddThemeConstantOverride("v_separation", 8);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`_customInput.AddThemeFontSizeOverride("font_size", 19)`；返回值紧邻使用处：`ExpressionStatementSyntax: _customInput.AddThemeFontSizeOverride("font_size", 19);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`_customConfirm.AddThemeStyleboxOverride("normal", CareerVisuals.Box("ceb782", "f0dca7", 7, 12))`；返回值紧邻使用处：`ExpressionStatementSyntax: _customConfirm.AddThemeStyleboxOverride("normal", CareerVisuals.Box("ceb782", "f0dca7", 7, 12));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`_customInput.AddThemeStyleboxOverride("normal", CareerVisuals.Box("0e202d", "456374", 6, 12))`；返回值紧邻使用处：`ExpressionStatementSyntax: _customInput.AddThemeStyleboxOverride("normal", CareerVisuals.Box("0e202d", "456374", 6, 12));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("1b303edc", "779c9a", 9, 18))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("1b303edc", "779c9a", 9, 18));`
- `Godot.Control.GrabFocus()`；输入表达式：`_customInput.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: _customInput.GrabFocus();`
- `Godot.HFlowContainer.HFlowContainer()`；输入表达式：`new HFlowContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HFlowContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_custom.AddChild(_customEntry)`；返回值紧邻使用处：`ExpressionStatementSyntax: _custom.AddChild(_customEntry);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_custom.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: _custom.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_customEditor.AddChild(_customEffects)`；返回值紧邻使用处：`ExpressionStatementSyntax: _customEditor.AddChild(_customEffects);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_customEditor.AddChild(_customInput)`；返回值紧邻使用处：`ExpressionStatementSyntax: _customEditor.AddChild(_customInput);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_customEditor.AddChild(_customPhase)`；返回值紧邻使用处：`ExpressionStatementSyntax: _customEditor.AddChild(_customPhase);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_customEditor.AddChild(_customResult)`；返回值紧邻使用处：`ExpressionStatementSyntax: _customEditor.AddChild(_customResult);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_customEditor.AddChild(actions)`；返回值紧邻使用处：`ExpressionStatementSyntax: _customEditor.AddChild(actions);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_customEditor.AddChild(Words("你的行动", 16, Gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: _customEditor.AddChild(Words("你的行动", 16, Gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(_customBack)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(_customBack);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(_customConfirm)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(_customConfirm);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`actions.AddChild(_customGenerate)`；返回值紧邻使用处：`ExpressionStatementSyntax: actions.AddChild(_customGenerate);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(_customEditor)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(_customEditor);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(_custom)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(_custom);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer()`
- `Godot.TextEdit.TextEdit()`；输入表达式：`new TextEdit { Name = "CustomEventInput", PlaceholderText = "你准备怎么做？", CustomMinimumSize = new(0, 112), WrapMode = TextEdit.LineWrappingMode.Boundary, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _customInput = new TextEdit { Name = "CustomEventInput", PlaceholderText = "你准备怎么做？", CustomMinimumSize = new(0, 112), WrapMode = TextEdit.LineWrappingMode.Boundary, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { Name = "CustomEventEffects" }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _customEffects = new VBoxContainer { Name = "CustomEventEffects" }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _custom = new VBoxContainer()`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _customEditor = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 112)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 112)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("0e202d", "456374", 6, 12)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("0e202d", "456374", 6, 12)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("1b303edc", "779c9a", 9, 18)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("1b303edc", "779c9a", 9, 18)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("ceb782", "f0dca7", 7, 12)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("ceb782", "f0dca7", 7, 12)`
- `NationalSpire.EventStoryButton.EventStoryButton()`；输入表达式：`new EventStoryButton { Name = "CustomEventAction", Caption = "写下你的行动", Detail = "用自己的选择，为故事写下另一种结局", Mark = "+" }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _customEntry = new EventStoryButton { Name = "CustomEventAction", Caption = "写下你的行动", Detail = "用自己的选择，为故事写下另一种结局", Mark = "+" }`
- `NationalSpire.EventStoryView.ActionButton(string, System.Action)`；输入表达式：`ActionButton("返回原选项", () => { _customExpanded = false; panel.Hide(); _customEntry.Show(); _options.Show(); })`；返回值紧邻使用处：`AssignmentExpressionSyntax: _customBack = ActionButton("返回原选项", () => { _customExpanded = false; panel.Hide(); _customEntry.Show(); _options.Show(); })`
- `NationalSpire.EventStoryView.ActionButton(string, System.Action)`；输入表达式：`ActionButton("确认这个结局", () => ConfirmCustom?.Invoke())`；返回值紧邻使用处：`AssignmentExpressionSyntax: _customConfirm = ActionButton("确认这个结局", () => ConfirmCustom?.Invoke())`
- `NationalSpire.EventStoryView.ActionButton(string, System.Action)`；输入表达式：`ActionButton("生成行动结局", () => Custom?.Invoke(_customInput.Text))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _customGenerate = ActionButton("生成行动结局", () => Custom?.Invoke(_customInput.Text))`
- `NationalSpire.EventStoryView.Rich(int)`；输入表达式：`Rich(20)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _customResult = Rich(20)`
- `NationalSpire.EventStoryView.Words(string, int, Godot.Color)`；输入表达式：`Words("", 14, CareerVisuals.Teal)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _customPhase = Words("", 14, CareerVisuals.Teal)`
- `NationalSpire.EventStoryView.Words(string, int, Godot.Color)`；输入表达式：`Words("你的行动", 16, Gold)`；返回值紧邻使用处：`ArgumentSyntax: Words("你的行动", 16, Gold)`
- `string.Trim()`；输入表达式：`_customInput.Text.Trim()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _customInput.Text.Trim().Length`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: ConfirmCustom?.Invoke()`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Tick?.Invoke()`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(_customInput.Text)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Custom?.Invoke(_customInput.Text)`

**赋值（含属性/字段和局部值）：**

- `_custom` = `new VBoxContainer()`
- `_customBack.Name` = `"CustomEventBack"`
- `_customBack` = `ActionButton("返回原选项", () => { _customExpanded = false; panel.Hide(); _customEntry.Show(); _options.Show(); })`
- `_customConfirm.Name` = `"CustomEventConfirm"`
- `_customConfirm.Visible` = `false`
- `_customConfirm` = `ActionButton("确认这个结局", () => ConfirmCustom?.Invoke())`
- `_customEditor` = `new VBoxContainer()`
- `_customEffects` = `new VBoxContainer { Name = "CustomEventEffects" }`
- `_customEntry.Pressed` += `() => { _customExpanded = true; panel.Show(); _customEntry.Hide(); _options.Hide(); _customInput.GrabFocus(); }`
- `_customEntry` = `new EventStoryButton { Name = "CustomEventAction", Caption = "写下你的行动", Detail = "用自己的选择，为故事写下另一种结局", Mark = "+" }`
- `_customExpanded` = `false`
- `_customExpanded` = `true`
- `_customGenerate.Disabled` = `_customInput.Text.Trim().Length == 0`
- `_customGenerate.Name` = `"CustomEventGenerate"`
- `_customGenerate` = `ActionButton("生成行动结局", () => Custom?.Invoke(_customInput.Text))`
- `_customInput.TextChanged` += `() => { _customConfirm.Visible = false; _customGenerate.Disabled = _customInput.Text.Trim().Length == 0; Tick?.Invoke(); }`
- `_customInput` = `new TextEdit { Name = "CustomEventInput", PlaceholderText = "你准备怎么做？", CustomMinimumSize = new(0, 112), WrapMode = TextEdit.LineWrappingMode.Boundary, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `_customPhase` = `Words("", 14, CareerVisuals.Teal)`
- `_customResult.Name` = `"CustomEventResult"`
- `_customResult` = `Rich(20)`
- `Caption` = `"写下你的行动"`
- `CustomMinimumSize` = `new(0, 112)`
- `Detail` = `"用自己的选择，为故事写下另一种结局"`
- `Mark` = `"+"`
- `Name` = `"CustomEventAction"`
- `Name` = `"CustomEventEffects"`
- `Name` = `"CustomEventInput"`
- `PlaceholderText` = `"你准备怎么做？"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `WrapMode` = `TextEdit.LineWrappingMode.Boundary`

<a id="symbol-e43ecd579917"></a>

## `NationalSpire.EventStoryView.DisplayCustom(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.EventLive?, bool) — private void DisplayCustom(CareerData d, RandomEventRecord e, EventLive? live, bool busy)`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EventStoryView.Display(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.EventLive?, bool)`](RandomEventScreen.cs.md#symbol-f847e9f29b0e)

**调用：** [`NationalSpire.EventStoryView.SetText(Godot.RichTextLabel, string)`](RandomEventScreen.cs.md#symbol-f7138d37ec2b)；[`NationalSpire.EventStoryView.ShowResultEffects(NationalSpire.CareerData, NationalSpire.RandomEventOption, Godot.VBoxContainer)`](RandomEventScreen.cs.md#symbol-5fbf79c036d6)；[`NationalSpire.RandomEventEffects.Check(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-09ecc3f9af33)；`Godot.Node.GetParent()`；`NationalSpire.RandomEventOption.RandomEventOption()`；`object.ReferenceEquals(object?, object?)`；`string.Trim()`

**字段、属性、事件及方法组引用：** `NationalSpire.EventLive.Phase`；`NationalSpire.EventLive.Story`；`NationalSpire.EventStoryView._custom`；`NationalSpire.EventStoryView._customBack`；`NationalSpire.EventStoryView._customConfirm`；`NationalSpire.EventStoryView._customEditor`；`NationalSpire.EventStoryView._customEffects`；`NationalSpire.EventStoryView._customEffectsOption`；`NationalSpire.EventStoryView._customEntry`；`NationalSpire.EventStoryView._customExpanded`；`NationalSpire.EventStoryView._customGenerate`；`NationalSpire.EventStoryView._customId`；`NationalSpire.EventStoryView._customInput`；`NationalSpire.EventStoryView._customPhase`；`NationalSpire.EventStoryView._customPreview`；`NationalSpire.EventStoryView._customResult`；`NationalSpire.EventStoryView._options`；`NationalSpire.EventStoryView.SetText(Godot.RichTextLabel, string)`；`NationalSpire.EventStoryView.ShowResultEffects(NationalSpire.CareerData, NationalSpire.RandomEventOption, Godot.VBoxContainer)`；`NationalSpire.RandomEventEffects.Check(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`；`NationalSpire.RandomEventOption.Result`；`NationalSpire.RandomEventRecord.CustomAction`；`NationalSpire.RandomEventRecord.CustomOption`；`NationalSpire.RandomEventRecord.CustomState`；`NationalSpire.RandomEventRecord.Id`；`NationalSpire.RandomEventRecord.State`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.GetParent()`；输入表达式：`_customEditor.GetParent()`；返回值紧邻使用处：`CastExpressionSyntax: (Control)_customEditor.GetParent()`
- `NationalSpire.EventStoryView.SetText(Godot.RichTextLabel, string)`；输入表达式：`SetText(_customResult, result)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetText(_customResult, result);`
- `NationalSpire.EventStoryView.ShowResultEffects(NationalSpire.CareerData, NationalSpire.RandomEventOption, Godot.VBoxContainer)`；输入表达式：`ShowResultEffects(d, option ?? new(), _customEffects)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowResultEffects(d, option ?? new(), _customEffects);`
- `NationalSpire.RandomEventEffects.Check(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`；输入表达式：`RandomEventEffects.Check(d, e, option)`；返回值紧邻使用处：`ConditionalExpressionSyntax: option == null ? null : RandomEventEffects.Check(d, e, option)`
- `NationalSpire.RandomEventOption.RandomEventOption()`；输入表达式：`new()`；返回值紧邻使用处：`BinaryExpressionSyntax: option ?? new()`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(option, _customEffectsOption)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ReferenceEquals(option, _customEffectsOption)`
- `string.Trim()`；输入表达式：`_customInput.Text.Trim()`；返回值紧邻使用处：`BinaryExpressionSyntax: e.CustomAction == _customInput.Text.Trim()`
- `string.Trim()`；输入表达式：`_customInput.Text.Trim()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _customInput.Text.Trim().Length`

**赋值（含属性/字段和局部值）：**

- `_custom.Visible` = `e.State == "ready"`
- `_customBack.Disabled` = `busy`
- `_customConfirm.Disabled` = `error != null`
- `_customConfirm.Visible` = `option != null && !busy`
- `_customEffectsOption` = `option`
- `_customEntry.Disabled` = `busy`
- `_customEntry.Visible` = `!_customExpanded`
- `_customExpanded` = `e.CustomAction.Length > 0`
- `_customExpanded` |= `generating`
- `_customGenerate.Disabled` = `busy || _customInput.Text.Trim().Length == 0`
- `_customGenerate.Text` = `e.CustomAction.Length > 0 && e.CustomAction == _customInput.Text.Trim() ? "重新生成结局" : "生成行动结局"`
- `_customId` = `e.Id`
- `_customInput.Editable` = `!busy`
- `_customInput.Text` = `e.CustomAction`
- `_customPhase.Text` = `generating ? live?.Phase ?? "正在准备行动结局" : error ?? (option != null ? "结局预览 · 确认后登记本次经历与效果" : "写下行动，看看故事如何结束")`
- `_customPreview` = `""`
- `_customPreview` = `result`
- `_customResult.Visible` = `result.Length > 0`
- `_options.Visible` = `!_customExpanded && e.State != "complete"`
- `((Control)_customEditor.GetParent()).Visible` = `_customExpanded`
