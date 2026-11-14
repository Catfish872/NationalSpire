# CareerFocusOutline.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`4856497844452091E3D64B5EC25BE8288C71FC6017D784C9E4A1985AC8CA4878`。来源：[源码](../../CareerFocusOutline.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerFocusOutline`。

字段、事件及初始值（源码原样）：

```csharp
internal const string ThemeMarker = "national_spire_focus_outline";
private static readonly StringName FocusStyle = "focus";
private readonly StyleBoxEmpty _hidden = new();
private Control? _masked;
private StyleBox? _previousOverride;
private bool _pointer = true;
```

<a id="symbol-b637dc7a6f12"></a>

## `NationalSpire.CareerFocusOutline._Ready() — public override void _Ready()`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerFocusOutline.FocusChanged(Godot.Control?)`](CareerFocusOutline.cs.md#symbol-b606f0e0abab)；`Godot.Node.GetViewport()`；`Godot.Viewport.GuiGetFocusOwner()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerFocusOutline.FocusChanged(Godot.Control?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.GetViewport()`；输入表达式：`GetViewport()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetViewport().GuiFocusChanged`
- `Godot.Node.GetViewport()`；输入表达式：`GetViewport()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetViewport().GuiGetFocusOwner`
- `Godot.Viewport.GuiGetFocusOwner()`；输入表达式：`GetViewport().GuiGetFocusOwner()`；返回值紧邻使用处：`ArgumentSyntax: GetViewport().GuiGetFocusOwner()`
- `NationalSpire.CareerFocusOutline.FocusChanged(Godot.Control?)`；输入表达式：`FocusChanged(GetViewport().GuiGetFocusOwner())`；返回值紧邻使用处：`ExpressionStatementSyntax: FocusChanged(GetViewport().GuiGetFocusOwner());`

**赋值（含属性/字段和局部值）：**

- `GetViewport().GuiFocusChanged` += `FocusChanged`
- `ProcessMode` = `ProcessModeEnum.Always`

<a id="symbol-453a1cfdc89a"></a>

## `NationalSpire.CareerFocusOutline._ExitTree() — public override void _ExitTree()`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerFocusOutline.Restore()`](CareerFocusOutline.cs.md#symbol-6f7c44cf5e47)；`Godot.Node.GetViewport()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerFocusOutline.FocusChanged(Godot.Control?)`；`NationalSpire.CareerFocusOutline.Restore()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.GetViewport()`；输入表达式：`GetViewport()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetViewport().GuiFocusChanged`
- `NationalSpire.CareerFocusOutline.Restore()`；输入表达式：`Restore()`；返回值紧邻使用处：`ExpressionStatementSyntax: Restore();`

**赋值（含属性/字段和局部值）：**

- `GetViewport().GuiFocusChanged` -= `FocusChanged`

<a id="symbol-389e0a787d50"></a>

## `NationalSpire.CareerFocusOutline._Input(Godot.InputEvent) — public override void _Input(InputEvent input)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerFocusOutline.FocusChanged(Godot.Control?)`](CareerFocusOutline.cs.md#symbol-b606f0e0abab)；`Godot.Mathf.Abs(float)`；`Godot.Node.GetViewport()`；`Godot.Viewport.GuiGetFocusOwner()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerFocusOutline._pointer`；`NationalSpire.CareerFocusOutline.FocusChanged(Godot.Control?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Mathf.Abs(float)`；输入表达式：`Mathf.Abs(axis.AxisValue)`；返回值紧邻使用处：`BinaryExpressionSyntax: Mathf.Abs(axis.AxisValue) > .5f`
- `Godot.Node.GetViewport()`；输入表达式：`GetViewport()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetViewport().GuiGetFocusOwner`
- `Godot.Viewport.GuiGetFocusOwner()`；输入表达式：`GetViewport().GuiGetFocusOwner()`；返回值紧邻使用处：`ArgumentSyntax: GetViewport().GuiGetFocusOwner()`
- `NationalSpire.CareerFocusOutline.FocusChanged(Godot.Control?)`；输入表达式：`FocusChanged(GetViewport().GuiGetFocusOwner())`；返回值紧邻使用处：`ExpressionStatementSyntax: FocusChanged(GetViewport().GuiGetFocusOwner());`

**赋值（含属性/字段和局部值）：**

- `_pointer` = `pointer`
- `pointer` = `false`
- `pointer` = `true`

<a id="symbol-b606f0e0abab"></a>

## `NationalSpire.CareerFocusOutline.FocusChanged(Godot.Control?) — private void FocusChanged(Control? control)`

来源：源码第 42 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerFocusOutline._Input(Godot.InputEvent)`](CareerFocusOutline.cs.md#symbol-389e0a787d50)；[`NationalSpire.CareerFocusOutline._Ready()`](CareerFocusOutline.cs.md#symbol-b637dc7a6f12)

**调用：** [`NationalSpire.CareerFocusOutline.Restore()`](CareerFocusOutline.cs.md#symbol-6f7c44cf5e47)；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.GetThemeStylebox(Godot.StringName, Godot.StringName)`；`Godot.Control.HasThemeConstant(Godot.StringName, Godot.StringName)`；`Godot.Control.HasThemeStylebox(Godot.StringName, Godot.StringName)`；`Godot.Control.HasThemeStyleboxOverride(Godot.StringName)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerFocusOutline._hidden`；`NationalSpire.CareerFocusOutline._masked`；`NationalSpire.CareerFocusOutline._pointer`；`NationalSpire.CareerFocusOutline._previousOverride`；`NationalSpire.CareerFocusOutline.FocusStyle`；`NationalSpire.CareerFocusOutline.Restore()`；`NationalSpire.CareerFocusOutline.ThemeMarker`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`control.AddThemeStyleboxOverride(FocusStyle, _hidden)`；返回值紧邻使用处：`ExpressionStatementSyntax: control.AddThemeStyleboxOverride(FocusStyle, _hidden);`
- `Godot.Control.GetThemeStylebox(Godot.StringName, Godot.StringName)`；输入表达式：`control.GetThemeStylebox(FocusStyle)`；返回值紧邻使用处：`ConditionalExpressionSyntax: control.HasThemeStyleboxOverride(FocusStyle) ? control.GetThemeStylebox(FocusStyle) : null`
- `Godot.Control.HasThemeConstant(Godot.StringName, Godot.StringName)`；输入表达式：`control.HasThemeConstant(ThemeMarker)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !control.HasThemeConstant(ThemeMarker)`
- `Godot.Control.HasThemeStylebox(Godot.StringName, Godot.StringName)`；输入表达式：`control.HasThemeStylebox(FocusStyle)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !control.HasThemeStylebox(FocusStyle)`
- `Godot.Control.HasThemeStyleboxOverride(Godot.StringName)`；输入表达式：`control.HasThemeStyleboxOverride(FocusStyle)`；返回值紧邻使用处：`ConditionalExpressionSyntax: control.HasThemeStyleboxOverride(FocusStyle) ? control.GetThemeStylebox(FocusStyle) : null`
- `NationalSpire.CareerFocusOutline.Restore()`；输入表达式：`Restore()`；返回值紧邻使用处：`ExpressionStatementSyntax: Restore();`

**赋值（含属性/字段和局部值）：**

- `_masked` = `control`
- `_previousOverride` = `control.HasThemeStyleboxOverride(FocusStyle) ? control.GetThemeStylebox(FocusStyle) : null`
- `control.FocusExited` += `Restore`

<a id="symbol-6f7c44cf5e47"></a>

## `NationalSpire.CareerFocusOutline.Restore() — private void Restore()`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerFocusOutline._ExitTree()`](CareerFocusOutline.cs.md#symbol-453a1cfdc89a)；[`NationalSpire.CareerFocusOutline.FocusChanged(Godot.Control?)`](CareerFocusOutline.cs.md#symbol-b606f0e0abab)

**调用：** `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.RemoveThemeStyleboxOverride(Godot.StringName)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerFocusOutline._masked`；`NationalSpire.CareerFocusOutline._previousOverride`；`NationalSpire.CareerFocusOutline.FocusStyle`；`NationalSpire.CareerFocusOutline.Restore()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`control.AddThemeStyleboxOverride(FocusStyle, _previousOverride)`；返回值紧邻使用处：`ExpressionStatementSyntax: control.AddThemeStyleboxOverride(FocusStyle, _previousOverride);`
- `Godot.Control.RemoveThemeStyleboxOverride(Godot.StringName)`；输入表达式：`control.RemoveThemeStyleboxOverride(FocusStyle)`；返回值紧邻使用处：`ExpressionStatementSyntax: control.RemoveThemeStyleboxOverride(FocusStyle);`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(control)`；返回值紧邻使用处：`BinaryExpressionSyntax: _masked is {} control && IsInstanceValid(control)`

**赋值（含属性/字段和局部值）：**

- `_masked` = `null`
- `_previousOverride` = `null`
- `control.FocusExited` -= `Restore`
