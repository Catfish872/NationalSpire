# CareerDisclosureButton.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`16B2E22D867C8706BC26F8FEAD7D22D54AD0D6E8A6AABEF25A2C6BDB2349E199`。来源：[源码](../../CareerDisclosureButton.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerDisclosureButton`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-ae0278775b85"></a>

## `NationalSpire.CareerDisclosureButton.ArrowOnLeft — public bool ArrowOnLeft`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-203fcd306ec9"></a>

## `NationalSpire.CareerDisclosureButton._Draw() — public override void _Draw()`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；`Godot.Control.GetThemeColor(Godot.StringName, Godot.StringName)`；`Godot.Control.GetThemeFontSize(Godot.StringName, Godot.StringName)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerDisclosureButton.ArrowOnLeft`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([center + new Vector2(-side * .4f, -direction * side * .2f), center + new Vector2(0, direction * side * .2f), center + new Vector2(side * .4f, -direction * side * .2f)], GetThemeColor("font_color"), 1.5f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([center + new Vector2(-side * .4f, -direction * side * .2f), center + new Vector2(0, direction * side * .2f), center + new Vector2(side * .4f, -direction * side * .2f)], GetThemeColor("font_color"), 1.5f, true);`
- `Godot.Control.GetThemeColor(Godot.StringName, Godot.StringName)`；输入表达式：`GetThemeColor("font_color")`；返回值紧邻使用处：`ArgumentSyntax: GetThemeColor("font_color")`
- `Godot.Control.GetThemeFontSize(Godot.StringName, Godot.StringName)`；输入表达式：`GetThemeFontSize("font_size")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetThemeFontSize("font_size")`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-side * .4f, -direction * side * .2f)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(-side * .4f, -direction * side * .2f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, direction * side * .2f)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(0, direction * side * .2f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(ArrowOnLeft ? side / 2 : Size.X - side / 2, Size.Y / 2)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Vector2(ArrowOnLeft ? side / 2 : Size.X - side / 2, Size.Y / 2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(side * .4f, -direction * side * .2f)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(side * .4f, -direction * side * .2f)`

**赋值（含属性/字段和局部值）：**
