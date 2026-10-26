# PercentageSlider.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`733CA40425C3B926BF2D8B5DEEC03582A3FB8C1657109379FEA54609629CE0FB`。来源：[源码](../../PercentageSlider.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.PercentageSlider`、`NationalSpire.PercentageLockButton`。

字段、事件及初始值（源码原样）：

```csharp
private const float ThumbWidth = 84, ThumbHeight = 34;
private PanelContainer _thumb = null!;
private Label _caption = null!;
private LineEdit _editor = null!;
private Vector2 _pressed;
private bool _thumbPressed, _dragged, _committing;
private readonly StyleBoxFlat _body = new() { BgColor = Colors.Transparent,
        BorderWidthLeft = 2, BorderWidthRight = 2, BorderWidthTop = 2, BorderWidthBottom = 2,
        CornerRadiusTopLeft = 3, CornerRadiusTopRight = 3, CornerRadiusBottomLeft = 3, CornerRadiusBottomRight = 3 };
```

<a id="symbol-5afc59be40b9"></a>

## `NationalSpire.PercentageSlider._Ready() — public override void _Ready()`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Color.Color(string)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeIconOverride(Godot.StringName, Godot.Texture2D)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Gradient.Gradient()`；`Godot.GradientTexture2D.GradientTexture2D()`；`Godot.Label.Label()`；`Godot.LineEdit.LineEdit()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.StyleBoxFlat.StyleBoxFlat()`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.PercentageSlider.Commit()`](PercentageSlider.cs.md#symbol-013abce752a0)；[`NationalSpire.PercentageSlider.LayoutThumb()`](PercentageSlider.cs.md#symbol-e9bc0f02baad)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Ink`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.PercentageSlider.Commit()`；`NationalSpire.PercentageSlider.HandleInput(Godot.InputEvent)`；`NationalSpire.PercentageSlider.LayoutThumb()`；`NationalSpire.PercentageSlider.ThumbHeight`；`NationalSpire.PercentageSlider.ThumbWidth`；`NationalSpire.PercentageSlider._caption`；`NationalSpire.PercentageSlider._editor`；`NationalSpire.PercentageSlider._thumb`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new("304959")`；返回值紧邻使用处：`AssignmentExpressionSyntax: BgColor = new("304959")`
- `Godot.Color.Color(string)`；输入表达式：`new("70b7bb")`；返回值紧邻使用处：`AssignmentExpressionSyntax: BgColor = new("70b7bb")`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`_caption.AddThemeColorOverride("font_color", CareerVisuals.Ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: _caption.AddThemeColorOverride("font_color", CareerVisuals.Ink);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`_caption.AddThemeFontSizeOverride("font_size", 17)`；返回值紧邻使用处：`ExpressionStatementSyntax: _caption.AddThemeFontSizeOverride("font_size", 17);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`_editor.AddThemeFontSizeOverride("font_size", 17)`；返回值紧邻使用处：`ExpressionStatementSyntax: _editor.AddThemeFontSizeOverride("font_size", 17);`
- `Godot.Control.AddThemeIconOverride(Godot.StringName, Godot.Texture2D)`；输入表达式：`AddThemeIconOverride(state, transparent)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeIconOverride(state, transparent);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`AddThemeStyleboxOverride("grabber_area", new StyleBoxFlat { BgColor = new("70b7bb"), ContentMarginTop = 3, ContentMarginBottom = 3 })`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeStyleboxOverride("grabber_area", new StyleBoxFlat { BgColor = new("70b7bb"), ContentMarginTop = 3, ContentMarginBottom = 3 });`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`AddThemeStyleboxOverride("grabber_area_highlight", new StyleBoxFlat { BgColor = CareerVisuals.Teal, ContentMarginTop = 3, ContentMarginBottom = 3 })`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeStyleboxOverride("grabber_area_highlight", new StyleBoxFlat { BgColor = CareerVisuals.Teal, ContentMarginTop = 3, ContentMarginBottom = 3 });`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`AddThemeStyleboxOverride("slider", new StyleBoxFlat { BgColor = new("304959"), CornerRadiusTopLeft = 3, CornerRadiusBottomLeft = 3, CornerRadiusTopRight = 3, CornerRadiusBottomRight = 3, ContentMarginTop = 3, ContentMarginBottom = 3 })`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeStyleboxOverride("slider", new StyleBoxFlat { BgColor = new("304959"), CornerRadiusTopLeft = 3, CornerRadiusBottomLeft = 3, CornerRadiusTopRight = 3, CornerRadiusBottomRight = 3, ContentMarginTop = 3, ContentMarginBottom = 3 });`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`_editor.AddThemeStyleboxOverride("normal", CareerVisuals.Box("152d3c", "80e7db", 8, 0))`；返回值紧邻使用处：`ExpressionStatementSyntax: _editor.AddThemeStyleboxOverride("normal", CareerVisuals.Box("152d3c", "80e7db", 8, 0));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`_thumb.AddThemeStyleboxOverride("panel", CareerVisuals.Box("294b5a", "80bfc5", 8, 0))`；返回值紧邻使用处：`ExpressionStatementSyntax: _thumb.AddThemeStyleboxOverride("panel", CareerVisuals.Box("294b5a", "80bfc5", 8, 0));`
- `Godot.Gradient.Gradient()`；输入表达式：`new Gradient { Colors = [Colors.Transparent, Colors.Transparent] }`；返回值紧邻使用处：`AssignmentExpressionSyntax: Gradient = new Gradient { Colors = [Colors.Transparent, Colors.Transparent] }`
- `Godot.GradientTexture2D.GradientTexture2D()`；输入表达式：`new GradientTexture2D { Width = (int)ThumbWidth, Height = (int)ThumbHeight, Gradient = new Gradient { Colors = [Colors.Transparent, Colors.Transparent] } }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GradientTexture2D { Width = (int)ThumbWidth, Height = (int)ThumbHeight, Gradient = new Gradient { Colors = [Colors.Transparent, Colors.Transparent] } }`
- `Godot.Label.Label()`；输入表达式：`new Label { HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center, MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _caption = new Label { HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center, MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.LineEdit.LineEdit()`；输入表达式：`new LineEdit { Name = "PercentageInput", Visible = false, Alignment = HorizontalAlignment.Center, SelectAllOnFocus = true }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _editor = new LineEdit { Name = "PercentageInput", Visible = false, Alignment = HorizontalAlignment.Center, SelectAllOnFocus = true }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_editor)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_editor);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_thumb)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_thumb);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_thumb.AddChild(_caption)`；返回值紧邻使用处：`ExpressionStatementSyntax: _thumb.AddChild(_caption);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _thumb = new PanelContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.StyleBoxFlat.StyleBoxFlat()`；输入表达式：`new StyleBoxFlat { BgColor = CareerVisuals.Teal, ContentMarginTop = 3, ContentMarginBottom = 3 }`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxFlat { BgColor = CareerVisuals.Teal, ContentMarginTop = 3, ContentMarginBottom = 3 }`
- `Godot.StyleBoxFlat.StyleBoxFlat()`；输入表达式：`new StyleBoxFlat { BgColor = new("304959"), CornerRadiusTopLeft = 3, CornerRadiusBottomLeft = 3, CornerRadiusTopRight = 3, CornerRadiusBottomRight = 3, ContentMarginTop = 3, ContentMarginBottom = 3 }`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxFlat { BgColor = new("304959"), CornerRadiusTopLeft = 3, CornerRadiusBottomLeft = 3, CornerRadiusTopRight = 3, CornerRadiusBottomRight = 3, ContentMarginTop = 3, ContentMarginBottom = 3 }`
- `Godot.StyleBoxFlat.StyleBoxFlat()`；输入表达式：`new StyleBoxFlat { BgColor = new("70b7bb"), ContentMarginTop = 3, ContentMarginBottom = 3 }`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxFlat { BgColor = new("70b7bb"), ContentMarginTop = 3, ContentMarginBottom = 3 }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(230, 40)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(230, 40)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("152d3c", "80e7db", 8, 0)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("152d3c", "80e7db", 8, 0)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("294b5a", "80bfc5", 8, 0)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("294b5a", "80bfc5", 8, 0)`
- `NationalSpire.PercentageSlider.Commit()`；输入表达式：`Commit()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => Commit()`
- `NationalSpire.PercentageSlider.LayoutThumb()`；输入表达式：`LayoutThumb()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => LayoutThumb()`
- `NationalSpire.PercentageSlider.LayoutThumb()`；输入表达式：`LayoutThumb()`；返回值紧邻使用处：`ExpressionStatementSyntax: LayoutThumb();`

**赋值（含属性/字段和局部值）：**

- `Alignment` = `HorizontalAlignment.Center`
- `BgColor` = `CareerVisuals.Teal`
- `BgColor` = `new("304959")`
- `BgColor` = `new("70b7bb")`
- `Colors` = `[Colors.Transparent, Colors.Transparent]`
- `ContentMarginBottom` = `3`
- `ContentMarginTop` = `3`
- `CornerRadiusBottomLeft` = `3`
- `CornerRadiusBottomRight` = `3`
- `CornerRadiusTopLeft` = `3`
- `CornerRadiusTopRight` = `3`
- `CustomMinimumSize` = `new(230, 40)`
- `Gradient` = `new Gradient { Colors = [Colors.Transparent, Colors.Transparent] }`
- `GuiInput` += `HandleInput`
- `Height` = `(int)ThumbHeight`
- `HorizontalAlignment` = `HorizontalAlignment.Center`
- `MaxValue` = `100`
- `MinValue` = `0`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"PercentageInput"`
- `Resized` += `LayoutThumb`
- `Scrollable` = `false`
- `SelectAllOnFocus` = `true`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `Step` = `.1`
- `TooltipText` = `"拖动滑块；单击百分比可输入。"`
- `ValueChanged` += `_ => LayoutThumb()`
- `VerticalAlignment` = `VerticalAlignment.Center`
- `Visible` = `false`
- `Width` = `(int)ThumbWidth`
- `_caption` = `new Label { HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center, MouseFilter = MouseFilterEnum.Ignore }`
- `_editor.FocusExited` += `Commit`
- `_editor.TextSubmitted` += `_ => Commit()`
- `_editor` = `new LineEdit { Name = "PercentageInput", Visible = false, Alignment = HorizontalAlignment.Center, SelectAllOnFocus = true }`
- `_thumb` = `new PanelContainer { MouseFilter = MouseFilterEnum.Ignore }`

<a id="symbol-e9bc0f02baad"></a>

## `NationalSpire.PercentageSlider.LayoutThumb() — private void LayoutThumb()`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PercentageSlider.Commit()`](PercentageSlider.cs.md#symbol-013abce752a0)；[`NationalSpire.PercentageSlider.Refresh()`](PercentageSlider.cs.md#symbol-087a30b22085)；[`NationalSpire.PercentageSlider._Ready()`](PercentageSlider.cs.md#symbol-5afc59be40b9)

**调用：** `Godot.Vector2.Vector2(float, float)`；`System.Math.Max(float, float)`；`double.ToString(string?, System.IFormatProvider?)`

**字段、属性、事件及方法组引用：** `NationalSpire.PercentageSlider.ThumbHeight`；`NationalSpire.PercentageSlider.ThumbWidth`；`NationalSpire.PercentageSlider._caption`；`NationalSpire.PercentageSlider._editor`；`NationalSpire.PercentageSlider._thumb`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2((float)(Value / 100) * Math.Max(0, Size.X - ThumbWidth), (Size.Y - ThumbHeight) / 2)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Vector2((float)(Value / 100) * Math.Max(0, Size.X - ThumbWidth), (Size.Y - ThumbHeight) / 2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(ThumbWidth, ThumbHeight)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _editor.Size = new(ThumbWidth, ThumbHeight)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(0, Size.X - ThumbWidth)`；返回值紧邻使用处：`BinaryExpressionSyntax: (float)(Value / 100) * Math.Max(0, Size.X - ThumbWidth)`
- `double.ToString(string?, System.IFormatProvider?)`；输入表达式：`Value.ToString("0.#", CultureInfo.InvariantCulture)`；返回值紧邻使用处：`BinaryExpressionSyntax: Value.ToString("0.#", CultureInfo.InvariantCulture) + "%"`

**赋值（含属性/字段和局部值）：**

- `_caption.Text` = `Value.ToString("0.#", CultureInfo.InvariantCulture) + "%"`
- `_editor.Position` = `position`
- `_editor.Size` = `new(ThumbWidth, ThumbHeight)`
- `_thumb.Position` = `_editor.Position = position`
- `_thumb.Size` = `_editor.Size = new(ThumbWidth, ThumbHeight)`

<a id="symbol-8ad865e14f1f"></a>

## `NationalSpire.PercentageSlider.HandleInput(Godot.InputEvent) — private void HandleInput(InputEvent input)`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.Show()`；`Godot.Control.AcceptEvent()`；`Godot.Control.GetRect()`；`Godot.Control.GrabFocus()`；`Godot.LineEdit.SelectAll()`；`Godot.Rect2.HasPoint(Godot.Vector2)`；`Godot.Vector2.DistanceTo(Godot.Vector2)`；`System.Enum.HasFlag(System.Enum)`；`double.ToString(string?, System.IFormatProvider?)`

**字段、属性、事件及方法组引用：** `NationalSpire.PercentageSlider._dragged`；`NationalSpire.PercentageSlider._editor`；`NationalSpire.PercentageSlider._pressed`；`NationalSpire.PercentageSlider._thumb`；`NationalSpire.PercentageSlider._thumbPressed`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Show()`；输入表达式：`_editor.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: _editor.Show();`
- `Godot.Control.AcceptEvent()`；输入表达式：`AcceptEvent()`；返回值紧邻使用处：`ExpressionStatementSyntax: AcceptEvent();`
- `Godot.Control.GetRect()`；输入表达式：`_thumb.GetRect()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _thumb.GetRect().HasPoint`
- `Godot.Control.GrabFocus()`；输入表达式：`_editor.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: _editor.GrabFocus();`
- `Godot.LineEdit.SelectAll()`；输入表达式：`_editor.SelectAll()`；返回值紧邻使用处：`ExpressionStatementSyntax: _editor.SelectAll();`
- `Godot.Rect2.HasPoint(Godot.Vector2)`；输入表达式：`_thumb.GetRect().HasPoint(mouse.Position)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _thumbPressed = _thumb.GetRect().HasPoint(mouse.Position)`
- `Godot.Vector2.DistanceTo(Godot.Vector2)`；输入表达式：`motion.Position.DistanceTo(_pressed)`；返回值紧邻使用处：`BinaryExpressionSyntax: motion.Position.DistanceTo(_pressed) > 3`
- `System.Enum.HasFlag(System.Enum)`；输入表达式：`motion.ButtonMask.HasFlag(MouseButtonMask.Left)`；返回值紧邻使用处：`BinaryExpressionSyntax: input is InputEventMouseMotion motion && motion.ButtonMask.HasFlag(MouseButtonMask.Left)`
- `double.ToString(string?, System.IFormatProvider?)`；输入表达式：`Value.ToString("0.#", CultureInfo.InvariantCulture)`；返回值紧邻使用处：`BinaryExpressionSyntax: Value.ToString("0.#", CultureInfo.InvariantCulture) + "%"`

**赋值（含属性/字段和局部值）：**

- `_dragged` = `false`
- `_dragged` = `true`
- `_editor.Text` = `Value.ToString("0.#", CultureInfo.InvariantCulture) + "%"`
- `_pressed` = `mouse.Position`
- `_thumbPressed` = `_thumb.GetRect().HasPoint(mouse.Position)`

<a id="symbol-087a30b22085"></a>

## `NationalSpire.PercentageSlider.Refresh() — public void Refresh()`

来源：源码第 63 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Weights()`](NpcGenerationScreen.cs.md#symbol-3c35095e983c)

**调用：** [`NationalSpire.PercentageSlider.LayoutThumb()`](PercentageSlider.cs.md#symbol-e9bc0f02baad)

**字段、属性、事件及方法组引用：** `NationalSpire.PercentageSlider.LayoutThumb()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PercentageSlider.LayoutThumb()`；输入表达式：`LayoutThumb()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => LayoutThumb()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-013abce752a0"></a>

## `NationalSpire.PercentageSlider.Commit() — public void Commit()`

来源：源码第 65 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`AddSlider(Godot.HBoxContainer, NationalSpire.PercentageSlider, bool[], int)`](NpcGenerationScreen.cs.md#symbol-31c6a4d85278)；[`NationalSpire.CareerScreen.OpenNpcGeneration(NationalSpire.AiOptions, System.Action<NationalSpire.NpcGenerationSetup>, bool, System.Func<NationalSpire.NpcGenerationSetup, System.Threading.Tasks.Task>?, int, bool)`](NpcGenerationScreen.cs.md#symbol-fa734ac20da4)；[`NationalSpire.PercentageSlider._Ready()`](PercentageSlider.cs.md#symbol-5afc59be40b9)

**调用：** `Godot.CanvasItem.Hide()`；[`NationalSpire.PercentageSlider.LayoutThumb()`](PercentageSlider.cs.md#symbol-e9bc0f02baad)；`System.Math.Clamp(double, double, double)`；`double.IsFinite(double)`；`double.TryParse(string?, System.Globalization.NumberStyles, System.IFormatProvider?, out double)`；`string.Trim()`；`string.TrimEnd(params char[]?)`

**字段、属性、事件及方法组引用：** `NationalSpire.PercentageSlider.LayoutThumb()`；`NationalSpire.PercentageSlider._committing`；`NationalSpire.PercentageSlider._editor`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`_editor.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _editor.Hide();`
- `NationalSpire.PercentageSlider.LayoutThumb()`；输入表达式：`LayoutThumb()`；返回值紧邻使用处：`ExpressionStatementSyntax: LayoutThumb();`
- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp(value, 0, 100)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Value = Math.Clamp(value, 0, 100)`
- `double.IsFinite(double)`；输入表达式：`double.IsFinite(value)`；返回值紧邻使用处：`BinaryExpressionSyntax: double.TryParse(text, NumberStyles.Number, CultureInfo.InvariantCulture, out double value) && double.IsFinite(value)`
- `double.TryParse(string?, System.Globalization.NumberStyles, System.IFormatProvider?, out double)`；输入表达式：`double.TryParse(text, NumberStyles.Number, CultureInfo.InvariantCulture, out double value)`；返回值紧邻使用处：`BinaryExpressionSyntax: double.TryParse(text, NumberStyles.Number, CultureInfo.InvariantCulture, out double value) && double.IsFinite(value)`
- `string.Trim()`；输入表达式：`_editor.Text.Trim()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _editor.Text.Trim().TrimEnd`
- `string.TrimEnd(params char[]?)`；输入表达式：`_editor.Text.Trim().TrimEnd('%', '％')`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _editor.Text.Trim().TrimEnd('%', '％')`

**赋值（含属性/字段和局部值）：**

- `Value` = `Math.Clamp(value, 0, 100)`
- `_committing` = `false`
- `_committing` = `true`

<a id="symbol-515764b92816"></a>

## `NationalSpire.PercentageLockButton._Ready() — public override void _Ready()`

来源：源码第 81 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Vector2.Vector2(float, float)`；[`NationalSpire.PercentageLockButton.UpdateState()`](PercentageSlider.cs.md#symbol-070003bbccda)

**字段、属性、事件及方法组引用：** `NationalSpire.PercentageLockButton.UpdateState()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(28, 40)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(28, 40)`
- `NationalSpire.PercentageLockButton.UpdateState()`；输入表达式：`UpdateState()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => UpdateState()`
- `NationalSpire.PercentageLockButton.UpdateState()`；输入表达式：`UpdateState()`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateState();`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(28, 40)`
- `Flat` = `true`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `MouseEntered` += `QueueRedraw`
- `MouseExited` += `QueueRedraw`
- `ToggleMode` = `true`
- `Toggled` += `_ => UpdateState()`

<a id="symbol-070003bbccda"></a>

## `NationalSpire.PercentageLockButton.UpdateState() — private void UpdateState()`

来源：源码第 89 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PercentageLockButton._Ready()`](PercentageSlider.cs.md#symbol-515764b92816)

**调用：** `Godot.CanvasItem.QueueRedraw()`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`

**赋值（含属性/字段和局部值）：**

- `TooltipText` = `ButtonPressed ? "比例已锁定 · 点击解锁" : "点击锁定当前比例"`

<a id="symbol-da614995a8f8"></a>

## `NationalSpire.PercentageLockButton._Draw() — public override void _Draw()`

来源：源码第 95 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.BaseButton.IsHovered()`；`Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawStyleBox(Godot.StyleBox, Godot.Rect2)`；`Godot.Color.Color(string)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.PercentageLockButton._body`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.IsHovered()`；输入表达式：`IsHovered()`；返回值紧邻使用处：`ConditionalExpressionSyntax: IsHovered() ? "c9d0d5" : "9ba8b2"`
- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(shackle, 5, Mathf.Pi, Mathf.Tau, 20, color, 2, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(shackle, 5, Mathf.Pi, Mathf.Tau, 20, color, 2, true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(center + new Vector2(0, 3), center + new Vector2(0, 6), color, 2, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(center + new Vector2(0, 3), center + new Vector2(0, 6), color, 2, true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(shackle + new Vector2(-5, 0), new Vector2(shackle.X - 5, center.Y - 2), color, 2, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(shackle + new Vector2(-5, 0), new Vector2(shackle.X - 5, center.Y - 2), color, 2, true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(shackle + new Vector2(5, 0), new Vector2(shackle.X + 5, center.Y + (ButtonPressed ? -2 : -5)), color, 2, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(shackle + new Vector2(5, 0), new Vector2(shackle.X + 5, center.Y + (ButtonPressed ? -2 : -5)), color, 2, true);`
- `Godot.CanvasItem.DrawStyleBox(Godot.StyleBox, Godot.Rect2)`；输入表达式：`DrawStyleBox(_body, new Rect2(center + new Vector2(-8, -2), new Vector2(16, 13)))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawStyleBox(_body, new Rect2(center + new Vector2(-8, -2), new Vector2(16, 13)));`
- `Godot.Color.Color(string)`；输入表达式：`new Color(IsHovered() ? "c9d0d5" : "9ba8b2")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Color(IsHovered() ? "c9d0d5" : "9ba8b2")`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(center + new Vector2(-8, -2), new Vector2(16, 13))`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(center + new Vector2(-8, -2), new Vector2(16, 13))`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-5, 0)`；返回值紧邻使用处：`BinaryExpressionSyntax: shackle + new Vector2(-5, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-8, -2)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(-8, -2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, -6)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ButtonPressed ? new Vector2(0, -6) : new Vector2(4, -8)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, 3)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(0, 3)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, 6)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(0, 6)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(16, 13)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(16, 13)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(4, -8)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ButtonPressed ? new Vector2(0, -6) : new Vector2(4, -8)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(5, 0)`；返回值紧邻使用处：`BinaryExpressionSyntax: shackle + new Vector2(5, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(shackle.X + 5, center.Y + (ButtonPressed ? -2 : -5))`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(shackle.X + 5, center.Y + (ButtonPressed ? -2 : -5))`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(shackle.X - 5, center.Y - 2)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(shackle.X - 5, center.Y - 2)`

**赋值（含属性/字段和局部值）：**

- `_body.BorderColor` = `color`
