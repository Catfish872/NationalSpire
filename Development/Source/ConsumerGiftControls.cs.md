# ConsumerGiftControls.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`D2E63A0C340DA67A8A4E48AF58F7B4BE4FD271B37422665D1E9E9F298F597F4B`。来源：[源码](../../ConsumerGiftControls.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.ConsumerQuantity`、`NationalSpire.GiftRingMark`、`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
public event Action? Changed;
private LineEdit _number = null!;
```

<a id="symbol-23d85eaa8e59"></a>

## `NationalSpire.ConsumerQuantity.Value — public int Value`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-573d004b761f"></a>

## `NationalSpire.ConsumerQuantity.Valid — public bool Valid`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f77c5ebcc337"></a>

## `NationalSpire.ConsumerQuantity.Minimum — public int Minimum`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5addd231875f"></a>

## `NationalSpire.ConsumerQuantity.Maximum — public int Maximum`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1c0490e7d411"></a>

## `NationalSpire.ConsumerQuantity.InputText — public string InputText`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerQuantity._number`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0eddfdec0f89"></a>

## `NationalSpire.ConsumerQuantity.ConsumerQuantity() — public ConsumerQuantity()`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)；[`NationalSpire.CareerScreen.PrivateGiftPicker()`](ChatAttachmentScreen.cs.md#symbol-53b0d3e663d2)

**调用：** `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`AddThemeConstantOverride("separation", 0)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeConstantOverride("separation", 0);`

**赋值（含属性/字段和局部值）：**

- `SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`

<a id="symbol-a0db04226b0a"></a>

## `NationalSpire.ConsumerQuantity.Initialize(int) — public void Initialize(int value)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)；[`NationalSpire.CareerScreen.PrivateGiftPicker()`](ChatAttachmentScreen.cs.md#symbol-53b0d3e663d2)

**调用：** [`Action(string, int)`](ConsumerGiftControls.cs.md#symbol-53199fb9fdba)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.ConsumerQuantity.RestoreText(string)`](ConsumerGiftControls.cs.md#symbol-7a371acfafe4)；[`NationalSpire.ConsumerQuantity.SetValue(int)`](ConsumerGiftControls.cs.md#symbol-e2e90c4c8401)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`；`System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `Action(string, int)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.ConsumerQuantity._number`；`NationalSpire.ConsumerQuantity.Changed`；`NationalSpire.ConsumerQuantity.RestoreText(string)`；`NationalSpire.ConsumerQuantity.SetValue(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Action(string, int)`；输入表达式：`Action("-", -1)`；返回值紧邻使用处：`ArgumentSyntax: Action("-", -1)`
- `Action(string, int)`；输入表达式：`Action("+", 1)`；返回值紧邻使用处：`ArgumentSyntax: Action("+", 1)`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_number.AddThemeConstantOverride("minimum_character_width", 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: _number.AddThemeConstantOverride("minimum_character_width", 1);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`_number.AddThemeFontSizeOverride("font_size", 17)`；返回值紧邻使用处：`ExpressionStatementSyntax: _number.AddThemeFontSizeOverride("font_size", 17);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`_number.AddThemeStyleboxOverride("focus", CareerVisuals.Box("193345", "8bd4d8", 0, 4))`；返回值紧邻使用处：`ExpressionStatementSyntax: _number.AddThemeStyleboxOverride("focus", CareerVisuals.Box("193345", "8bd4d8", 0, 4));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`_number.AddThemeStyleboxOverride("normal", CareerVisuals.Box("102331", "55778c", 0, 4))`；返回值紧邻使用处：`ExpressionStatementSyntax: _number.AddThemeStyleboxOverride("normal", CareerVisuals.Box("102331", "55778c", 0, 4));`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Alignment = HorizontalAlignment.Center, CustomMinimumSize = new(40, 48), SelectAllOnFocus = true, MaxLength = 10 }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _number = new LineEdit { Alignment = HorizontalAlignment.Center, CustomMinimumSize = new(40, 48), SelectAllOnFocus = true, MaxLength = 10 }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_number)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_number);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(Action("-", -1))`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(Action("-", -1));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(Action("+", 1))`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(Action("+", 1));`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(40, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(40, 48)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("102331", "55778c", 0, 4)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("102331", "55778c", 0, 4)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("193345", "8bd4d8", 0, 4)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("193345", "8bd4d8", 0, 4)`
- `NationalSpire.ConsumerQuantity.RestoreText(string)`；输入表达式：`RestoreText(text)`；返回值紧邻使用处：`ExpressionStatementSyntax: RestoreText(text);`
- `NationalSpire.ConsumerQuantity.SetValue(int)`；输入表达式：`SetValue(value)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetValue(value);`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Changed?.Invoke()`

**赋值（含属性/字段和局部值）：**

- `_number.TextChanged` += `text =>          {              RestoreText(text); Changed?.Invoke();          }`
- `_number` = `new LineEdit { Alignment = HorizontalAlignment.Center, CustomMinimumSize = new(40, 48), SelectAllOnFocus = true, MaxLength = 10 }`
- `Alignment` = `HorizontalAlignment.Center`
- `CustomMinimumSize` = `new(40, 48)`
- `MaxLength` = `10`
- `SelectAllOnFocus` = `true`

<a id="symbol-53199fb9fdba"></a>

## `Action(string, int) — Button Action(string text, int delta)`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerQuantity.Initialize(int)`](ConsumerGiftControls.cs.md#symbol-a0db04226b0a)

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.ConsumerQuantity.SetValue(int)`](ConsumerGiftControls.cs.md#symbol-e2e90c4c8401)；`Godot.Button.Button()`；`Godot.Color.Color(string)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Vector2.Vector2(float, float)`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Math.Clamp(long, long, long)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.ConsumerQuantity.Changed`；`NationalSpire.ConsumerQuantity.Maximum`；`NationalSpire.ConsumerQuantity.Minimum`；`NationalSpire.ConsumerQuantity.SetValue(int)`；`NationalSpire.ConsumerQuantity.Value`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button { Text = text, CustomMinimumSize = new(32, 48), FocusMode = FocusModeEnum.None }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Text = text, CustomMinimumSize = new(32, 48), FocusMode = FocusModeEnum.None }`
- `Godot.Color.Color(string)`；输入表达式：`new Color("c8ebed")`；返回值紧邻使用处：`ArgumentSyntax: new Color("c8ebed")`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`b.AddThemeColorOverride(state, new Color("c8ebed"))`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AddThemeColorOverride(state, new Color("c8ebed"));`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`b.AddThemeFontSizeOverride("font_size", 17)`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AddThemeFontSizeOverride("font_size", 17);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`b.AddThemeStyleboxOverride(state, style)`；返回值紧邻使用处：`ExpressionStatementSyntax: b.AddThemeStyleboxOverride(state, style);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(32, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(32, 48)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(fill, "55778c", 6, 5)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerVisuals.Box(fill, "55778c", 6, 5)`
- `NationalSpire.ConsumerQuantity.SetValue(int)`；输入表达式：`SetValue((int)Math.Clamp((long)Value + delta, Minimum, Maximum))`；返回值紧邻使用处：`ExpressionStatementSyntax: SetValue((int)Math.Clamp((long)Value + delta, Minimum, Maximum));`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Changed?.Invoke()`
- `System.Math.Clamp(long, long, long)`；输入表达式：`Math.Clamp((long)Value + delta, Minimum, Maximum)`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Clamp((long)Value + delta, Minimum, Maximum)`

**赋值（含属性/字段和局部值）：**

- `b.Pressed` += `() => { SetValue((int)Math.Clamp((long)Value + delta, Minimum, Maximum)); Changed?.Invoke(); }`
- `CustomMinimumSize` = `new(32, 48)`
- `FocusMode` = `FocusModeEnum.None`
- `style.BorderWidthLeft` = `0`
- `style.BorderWidthRight` = `0`
- `style.CornerRadiusBottomLeft` = `style.BorderWidthLeft = 0`
- `style.CornerRadiusBottomRight` = `style.BorderWidthRight = 0`
- `style.CornerRadiusTopLeft` = `style.CornerRadiusBottomLeft = style.BorderWidthLeft = 0`
- `style.CornerRadiusTopRight` = `style.CornerRadiusBottomRight = style.BorderWidthRight = 0`
- `Text` = `text`

<a id="symbol-7a371acfafe4"></a>

## `NationalSpire.ConsumerQuantity.RestoreText(string) — public void RestoreText(string text)`

来源：源码第 49 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerQuantity.Initialize(int)`](ConsumerGiftControls.cs.md#symbol-a0db04226b0a)

**调用：** `Godot.Color.Color(string)`；`int.TryParse(string?, System.Globalization.NumberStyles, System.IFormatProvider?, out int)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerQuantity._number`；`NationalSpire.ConsumerQuantity.Maximum`；`NationalSpire.ConsumerQuantity.Minimum`；`NationalSpire.ConsumerQuantity.Valid`；`NationalSpire.ConsumerQuantity.Value`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("f397a9")`；返回值紧邻使用处：`ConditionalExpressionSyntax: Valid ? Colors.White : new Color("f397a9")`
- `int.TryParse(string?, System.Globalization.NumberStyles, System.IFormatProvider?, out int)`；输入表达式：`int.TryParse(text, NumberStyles.None, CultureInfo.InvariantCulture, out int next)`；返回值紧邻使用处：`BinaryExpressionSyntax: int.TryParse(text, NumberStyles.None, CultureInfo.InvariantCulture, out int next) && next >= Minimum`

**赋值（含属性/字段和局部值）：**

- `_number.Modulate` = `Valid ? Colors.White : new Color("f397a9")`
- `_number.Text` = `text`
- `Valid` = `int.TryParse(text, NumberStyles.None, CultureInfo.InvariantCulture, out int next) && next >= Minimum && next <= Maximum`
- `Value` = `next`

<a id="symbol-e2e90c4c8401"></a>

## `NationalSpire.ConsumerQuantity.SetValue(int) — public void SetValue(int value)`

来源：源码第 56 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Action(string, int)`](ConsumerGiftControls.cs.md#symbol-53199fb9fdba)；[`NationalSpire.CareerScreen.PrivateGiftPicker()`](ChatAttachmentScreen.cs.md#symbol-53b0d3e663d2)；[`NationalSpire.ConsumerQuantity.Initialize(int)`](ConsumerGiftControls.cs.md#symbol-a0db04226b0a)

**调用：** `int.ToString(System.IFormatProvider?)`；`System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerQuantity._number`；`NationalSpire.ConsumerQuantity.Maximum`；`NationalSpire.ConsumerQuantity.Minimum`；`NationalSpire.ConsumerQuantity.Valid`；`NationalSpire.ConsumerQuantity.Value`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.ToString(System.IFormatProvider?)`；输入表达式：`Value.ToString(CultureInfo.InvariantCulture)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _number.Text = Value.ToString(CultureInfo.InvariantCulture)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(value, Minimum, Maximum)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Value = Math.Clamp(value, Minimum, Maximum)`

**赋值（含属性/字段和局部值）：**

- `_number.Modulate` = `Colors.White`
- `_number.Text` = `Value.ToString(CultureInfo.InvariantCulture)`
- `Valid` = `true`
- `Value` = `Math.Clamp(value, Minimum, Maximum)`

<a id="symbol-56e93ed49898"></a>

## `NationalSpire.GiftRingMark.Completed — public bool Completed`

来源：源码第 62 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6a60dc1ee43f"></a>

## `NationalSpire.GiftRingMark.GiftRingMark() — public GiftRingMark()`

来源：源码第 63 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CalendarDayButton._Ready()`](CalendarDayButton.cs.md#symbol-48874665eb45)；[`NationalSpire.CareerScreen.PickerRing(Godot.HBoxContainer, NationalSpire.CareerData, string)`](ConsumerGiftControls.cs.md#symbol-e35b8d3e088f)

**调用：** `Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(20, 20)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(20, 20)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(20, 20)`
- `MouseFilter` = `MouseFilterEnum.Ignore`

<a id="symbol-080293db2a2d"></a>

## `NationalSpire.GiftRingMark._Draw() — public override void _Draw()`

来源：源码第 64 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.GiftRingMark.DrawDiamond(Godot.CanvasItem, Godot.Rect2, bool, Godot.Color)`](ConsumerGiftControls.cs.md#symbol-f09cb809a74c)；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`

**字段、属性、事件及方法组引用：** `NationalSpire.GiftRingMark.Completed`；`NationalSpire.GiftRingMark.DrawDiamond(Godot.CanvasItem, Godot.Rect2, bool, Godot.Color)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero, Size)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(Vector2.Zero, Size)`
- `NationalSpire.GiftRingMark.DrawDiamond(Godot.CanvasItem, Godot.Rect2, bool, Godot.Color)`；输入表达式：`DrawDiamond(this, new Rect2(Vector2.Zero, Size), Completed, Colors.White)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => DrawDiamond(this, new Rect2(Vector2.Zero, Size), Completed, Colors.White)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f09cb809a74c"></a>

## `NationalSpire.GiftRingMark.DrawDiamond(Godot.CanvasItem, Godot.Rect2, bool, Godot.Color) — public static void DrawDiamond(CanvasItem canvas, Rect2 bounds, bool completed, Color color)`

来源：源码第 65 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ContactRowButton._Draw()`](ContactRowButton.cs.md#symbol-4e5488f37cc5)；[`NationalSpire.GiftRingMark._Draw()`](ConsumerGiftControls.cs.md#symbol-080293db2a2d)

**调用：** `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；`Godot.Rect2.GetCenter()`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`canvas.DrawColoredPolygon(gem, color)`；返回值紧邻使用处：`ExpressionStatementSyntax: canvas.DrawColoredPolygon(gem, color);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`canvas.DrawLine(gem[4], gem[2], color, scale, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: canvas.DrawLine(gem[4], gem[2], color, scale, true);`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`canvas.DrawPolyline([.. gem, gem[0]], color, 1.5f * scale, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: canvas.DrawPolyline([.. gem, gem[0]], color, 1.5f * scale, true);`
- `Godot.Rect2.GetCenter()`；输入表达式：`bounds.GetCenter()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = bounds.GetCenter()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-4, -6)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(-4, -6) * scale`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-8, -1)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(-8, -1) * scale`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, 7)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(0, 7) * scale`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(4, -6)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(4, -6) * scale`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(8, -1)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(8, -1) * scale`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(bounds.Size.X, bounds.Size.Y)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(bounds.Size.X, bounds.Size.Y) / 20`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e35b8d3e088f"></a>

## `NationalSpire.CareerScreen.PickerRing(Godot.HBoxContainer, NationalSpire.CareerData, string) — private static void PickerRing(HBoxContainer row, CareerData data, string person)`

来源：源码第 80 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`ShowRows()`](CommunityShareScreen.cs.md#symbol-2e7b710b7d77)；[`ShowRows()`](GroupChatScreen.cs.md#symbol-ccc2d64dcc08)

**调用：** [`NationalSpire.GiftRingMark.GiftRingMark()`](ConsumerGiftControls.cs.md#symbol-6a60dc1ee43f)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.GetThemeStylebox(Godot.StringName, Godot.StringName)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.GodotObject.GetMeta(Godot.StringName, Godot.Variant)`；`Godot.GodotObject.HasMeta(Godot.StringName)`；`Godot.GodotObject.SetMeta(Godot.StringName, Godot.Variant)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildren(bool)`；`Godot.Node.QueueFree()`；`Godot.Node.RemoveChild(Godot.Node)`；`Godot.Resource.Duplicate(bool)`；`Godot.Variant.AsSingle()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.IEnumerable.OfType<TResult>()`

**字段、属性、事件及方法组引用：** `NationalSpire.GiftRingMark.Completed`；`NationalSpire.PrivateMailbox.Relations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateRelation.RingReceived`；`NationalSpire.PrivateRelation.WeddingCompleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride(state, style)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride(state, style);`
- `Godot.Control.GetThemeStylebox(Godot.StringName, Godot.StringName)`；输入表达式：`button.GetThemeStylebox(state)`；返回值紧邻使用处：`IsPatternExpressionSyntax: button.GetThemeStylebox(state) is not StyleBoxFlat original`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`mark.SetAnchorsAndOffsetsPreset(LayoutPreset.CenterRight)`；返回值紧邻使用处：`ExpressionStatementSyntax: mark.SetAnchorsAndOffsetsPreset(LayoutPreset.CenterRight);`
- `Godot.GodotObject.GetMeta(Godot.StringName, Godot.Variant)`；输入表达式：`button.GetMeta(key)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: button.GetMeta(key).AsSingle`
- `Godot.GodotObject.HasMeta(Godot.StringName)`；输入表达式：`button.HasMeta(key)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !button.HasMeta(key)`
- `Godot.GodotObject.SetMeta(Godot.StringName, Godot.Variant)`；输入表达式：`button.SetMeta(key, original.ContentMarginRight)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.SetMeta(key, original.ContentMarginRight);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`button.AddChild(mark)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddChild(mark);`
- `Godot.Node.GetChildren(bool)`；输入表达式：`button.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: button.GetChildren().OfType<GiftRingMark>`
- `Godot.Node.GetChildren(bool)`；输入表达式：`row.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: row.GetChildren().OfType<Button>`
- `Godot.Node.QueueFree()`；输入表达式：`previous.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: previous.QueueFree();`
- `Godot.Node.RemoveChild(Godot.Node)`；输入表达式：`button.RemoveChild(previous)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.RemoveChild(previous);`
- `Godot.Resource.Duplicate(bool)`；输入表达式：`original.Duplicate()`；返回值紧邻使用处：`CastExpressionSyntax: (StyleBoxFlat)original.Duplicate()`
- `Godot.Variant.AsSingle()`；输入表达式：`button.GetMeta(key).AsSingle()`；返回值紧邻使用处：`BinaryExpressionSyntax: button.GetMeta(key).AsSingle() + (relation?.RingReceived == true ? 28 : 0)`
- `NationalSpire.GiftRingMark.GiftRingMark()`；输入表达式：`new GiftRingMark { Name = "PickerOathMark", Completed = relation.WeddingCompleted }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GiftRingMark { Name = "PickerOathMark", Completed = relation.WeddingCompleted }`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Relations`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`row.GetChildren().OfType<Button>().FirstOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = row.GetChildren().OfType<Button>().FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`button.GetChildren().OfType<GiftRingMark>().ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var previous in button.GetChildren().OfType<GiftRingMark>().ToArray()) { button.RemoveChild(previous); previous.QueueFree(); }`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Mailbox(data).Relations.GetValueOrDefault(person)`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`button.GetChildren().OfType<GiftRingMark>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: button.GetChildren().OfType<GiftRingMark>().ToArray`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`row.GetChildren().OfType<Button>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: row.GetChildren().OfType<Button>().FirstOrDefault`

**赋值（含属性/字段和局部值）：**

- `Completed` = `relation.WeddingCompleted`
- `mark.OffsetBottom` = `10`
- `mark.OffsetLeft` = `-32`
- `mark.OffsetRight` = `-12`
- `mark.OffsetTop` = `-10`
- `Name` = `"PickerOathMark"`
- `style.ContentMarginRight` = `button.GetMeta(key).AsSingle() + (relation?.RingReceived == true ? 28 : 0)`
