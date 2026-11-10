# BracketInspector.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`206CD3CF8B69DF2ADD06FD0B6B3FAAB2A9CD12F81C86E81AC0F21C9D312C1799`。来源：[源码](../../BracketInspector.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.BracketInspector`。

字段、事件及初始值（源码原样）：

```csharp
private const int CardWidth = 430;
private Button? _target;
private ScrollContainer _viewport = null!;
private readonly ScrollContainer _scroll = new() { HorizontalScrollMode = ScrollContainer.ScrollMode.Disabled };
private Control? _details;
private bool _pinned;
```

<a id="symbol-ddfed770fc0f"></a>

## `NationalSpire.BracketInspector.Attach(Godot.Control, Godot.ScrollContainer) — internal void Attach(Control stage, ScrollContainer viewport)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)

**调用：** [`NationalSpire.BracketInspector.Dismiss()`](BracketInspector.cs.md#symbol-4ae6702e936d)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.GodotObject.GetInstanceId()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetNodeOrNull<T>(Godot.NodePath)`；`Godot.Node.QueueFree()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.BracketInspector._scroll`；`NationalSpire.BracketInspector._viewport`；`NationalSpire.BracketInspector.CardWidth`；`NationalSpire.BracketInspector.Dismiss()`；`NationalSpire.BracketInspector.HideAfterPointerLeaves()`；`NationalSpire.BracketInspector.OnViewportExit()`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`OnVisibilityChanged()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`AddThemeStyleboxOverride("panel", CareerVisuals.Box("11232f", "72948f", 7, 17))`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeStyleboxOverride("panel", CareerVisuals.Box("11232f", "72948f", 7, 17));`
- `Godot.GodotObject.GetInstanceId()`；输入表达式：`previous.GetInstanceId()`；返回值紧邻使用处：`BinaryExpressionSyntax: "RetiredInspector_" + previous.GetInstanceId()`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(viewport)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(viewport)`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(_scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(_scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`stage.AddChild(this)`；返回值紧邻使用处：`ExpressionStatementSyntax: stage.AddChild(this);`
- `Godot.Node.GetNodeOrNull<T>(Godot.NodePath)`；输入表达式：`stage.GetNodeOrNull<BracketInspector>("BracketInspector")`；返回值紧邻使用处：`IsPatternExpressionSyntax: stage.GetNodeOrNull<BracketInspector>("BracketInspector") is { } previous`
- `Godot.Node.QueueFree()`；输入表达式：`previous.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: previous.QueueFree();`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(CardWidth, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(CardWidth, 0)`
- `NationalSpire.BracketInspector.Dismiss()`；输入表达式：`Dismiss()`；返回值紧邻使用处：`ExpressionStatementSyntax: Dismiss();`
- `NationalSpire.BracketInspector.Dismiss()`；输入表达式：`previous.Dismiss()`；返回值紧邻使用处：`ExpressionStatementSyntax: previous.Dismiss();`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("11232f", "72948f", 7, 17)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("11232f", "72948f", 7, 17)`

**赋值（含属性/字段和局部值）：**

- `_viewport` = `viewport`
- `CustomMinimumSize` = `new(CardWidth, 0)`
- `MouseExited` += `HideAfterPointerLeaves`
- `MouseFilter` = `MouseFilterEnum.Stop`
- `Name` = `"BracketInspector"`
- `previous.Name` = `"RetiredInspector_" + previous.GetInstanceId()`
- `TreeExiting` += `() =>          {              if (!IsInstanceValid(viewport)) return;              viewport.VisibilityChanged -= OnVisibilityChanged;              viewport.TreeExiting -= OnViewportExit;          }`
- `viewport.TreeExiting` -= `OnViewportExit`
- `viewport.TreeExiting` += `OnViewportExit`
- `viewport.VisibilityChanged` -= `OnVisibilityChanged`
- `viewport.VisibilityChanged` += `OnVisibilityChanged`
- `ZIndex` = `18`

<a id="symbol-489d06ef69bb"></a>

## `OnVisibilityChanged() — void OnVisibilityChanged()`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.BracketInspector.Dismiss()`](BracketInspector.cs.md#symbol-4ae6702e936d)；`Godot.CanvasItem.IsVisibleInTree()`

**字段、属性、事件及方法组引用：** `NationalSpire.BracketInspector.Dismiss()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`viewport.IsVisibleInTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !viewport.IsVisibleInTree()`
- `NationalSpire.BracketInspector.Dismiss()`；输入表达式：`Dismiss()`；返回值紧邻使用处：`ExpressionStatementSyntax: Dismiss();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-61dc2706269a"></a>

## `NationalSpire.BracketInspector.OnViewportExit() — private void OnViewportExit()`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.BracketInspector.Dismiss()`](BracketInspector.cs.md#symbol-4ae6702e936d)；`Godot.Node.QueueFree()`

**字段、属性、事件及方法组引用：** `NationalSpire.BracketInspector.Dismiss()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.QueueFree()`；输入表达式：`QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueFree();`
- `NationalSpire.BracketInspector.Dismiss()`；输入表达式：`Dismiss()`；返回值紧邻使用处：`ExpressionStatementSyntax: Dismiss();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-955dfacc5bbe"></a>

## `NationalSpire.BracketInspector.Bind(Godot.Button, System.Func<Godot.Control>) — internal void Bind(Button button, Func<Control> content)`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)

**调用：** [`NationalSpire.BracketInspector.Dismiss()`](BracketInspector.cs.md#symbol-4ae6702e936d)；[`NationalSpire.BracketInspector.HideAfterPointerLeaves()`](BracketInspector.cs.md#symbol-cd1dcb62a496)；[`ShowCard()`](BracketInspector.cs.md#symbol-2759aa16f0ae)

**字段、属性、事件及方法组引用：** `NationalSpire.BracketInspector._pinned`；`NationalSpire.BracketInspector._target`；`NationalSpire.BracketInspector.Dismiss()`；`NationalSpire.BracketInspector.HideAfterPointerLeaves()`；`ShowCard()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.BracketInspector.Dismiss()`；输入表达式：`Dismiss()`；返回值紧邻使用处：`ExpressionStatementSyntax: Dismiss();`
- `NationalSpire.BracketInspector.HideAfterPointerLeaves()`；输入表达式：`HideAfterPointerLeaves()`；返回值紧邻使用处：`ExpressionStatementSyntax: HideAfterPointerLeaves();`
- `ShowCard()`；输入表达式：`ShowCard()`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowCard();`

**赋值（含属性/字段和局部值）：**

- `_pinned` = `true`
- `button.FocusEntered` += `() => { if (!_pinned) ShowCard(); }`
- `button.FocusExited` += `() => { if (!_pinned && _target == button) HideAfterPointerLeaves(); }`
- `button.MouseEntered` += `() => { if (!_pinned) ShowCard(); }`
- `button.MouseExited` += `HideAfterPointerLeaves`
- `button.Pressed` += `() =>          {              if (_target == button && _pinned) { Dismiss(); return; }              ShowCard();              _pinned = true;          }`

<a id="symbol-2759aa16f0ae"></a>

## `ShowCard() — void ShowCard()`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.BracketInspector.Bind(Godot.Button, System.Func<Godot.Control>)`](BracketInspector.cs.md#symbol-955dfacc5bbe)

**调用：** [`NationalSpire.BracketInspector.PositionCard()`](BracketInspector.cs.md#symbol-7724845fc7ff)；`Godot.CanvasItem.Show()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.QueueFree()`；`Godot.Node.RemoveChild(Godot.Node)`；`Godot.Node.SetProcess(bool)`；`Godot.Vector2.Vector2(float, float)`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.BracketInspector._details`；`NationalSpire.BracketInspector._scroll`；`NationalSpire.BracketInspector._target`；`NationalSpire.BracketInspector.CardWidth`；`NationalSpire.BracketInspector.PositionCard()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Show()`；输入表达式：`Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: Show();`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_scroll.AddChild(_details)`；返回值紧邻使用处：`ExpressionStatementSyntax: _scroll.AddChild(_details);`
- `Godot.Node.QueueFree()`；输入表达式：`_details.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: _details.QueueFree();`
- `Godot.Node.RemoveChild(Godot.Node)`；输入表达式：`_scroll.RemoveChild(_details)`；返回值紧邻使用处：`ExpressionStatementSyntax: _scroll.RemoveChild(_details);`
- `Godot.Node.SetProcess(bool)`；输入表达式：`SetProcess(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetProcess(true);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(CardWidth, 210)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Size = new(CardWidth, 210)`
- `NationalSpire.BracketInspector.PositionCard()`；输入表达式：`PositionCard()`；返回值紧邻使用处：`ExpressionStatementSyntax: PositionCard();`
- `System.Func<TResult>.Invoke()`；输入表达式：`content()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _details = content()`

**赋值（含属性/字段和局部值）：**

- `_details.SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `_details` = `content()`
- `_scroll.ScrollVertical` = `0`
- `_target` = `button`
- `Size` = `new(CardWidth, 210)`

<a id="symbol-cd1dcb62a496"></a>

## `NationalSpire.BracketInspector.HideAfterPointerLeaves() — private void HideAfterPointerLeaves()`

来源：源码第 84 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.BracketInspector.Bind(Godot.Button, System.Func<Godot.Control>)`](BracketInspector.cs.md#symbol-955dfacc5bbe)

**调用：** [`NationalSpire.BracketInspector.Dismiss()`](BracketInspector.cs.md#symbol-4ae6702e936d)；`Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.CanvasItem.GetGlobalMousePosition()`；`Godot.Control.GetGlobalRect()`；`Godot.Rect2.HasPoint(Godot.Vector2)`

**字段、属性、事件及方法组引用：** `NationalSpire.BracketInspector._pinned`；`NationalSpire.BracketInspector._target`；`NationalSpire.BracketInspector.Dismiss()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(() =>          {              if (!_pinned && _target != null && !_target.GetGlobalRect().HasPoint(GetGlobalMousePosition()) &&                  !GetGlobalRect().HasPoint(GetGlobalMousePosition())) Dismiss();          }).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(() =>          {              if (!_pinned && _target != null && !_target.GetGlobalRect().HasPoint(GetGlobalMousePosition()) &&                  !GetGlobalRect().HasPoint(GetGlobalMousePosition())) Dismiss();          }).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(() =>          {              if (!_pinned && _target != null && !_target.GetGlobalRect().HasPoint(GetGlobalMousePosition()) &&                  !GetGlobalRect().HasPoint(GetGlobalMousePosition())) Dismiss();          })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(() =>          {              if (!_pinned && _target != null && !_target.GetGlobalRect().HasPoint(GetGlobalMousePosition()) &&                  !GetGlobalRect().HasPoint(GetGlobalMousePosition())) Dismiss();          }).CallDeferred`
- `Godot.CanvasItem.GetGlobalMousePosition()`；输入表达式：`GetGlobalMousePosition()`；返回值紧邻使用处：`ArgumentSyntax: GetGlobalMousePosition()`
- `Godot.Control.GetGlobalRect()`；输入表达式：`_target.GetGlobalRect()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _target.GetGlobalRect().HasPoint`
- `Godot.Control.GetGlobalRect()`；输入表达式：`GetGlobalRect()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetGlobalRect().HasPoint`
- `Godot.Rect2.HasPoint(Godot.Vector2)`；输入表达式：`_target.GetGlobalRect().HasPoint(GetGlobalMousePosition())`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_target.GetGlobalRect().HasPoint(GetGlobalMousePosition())`
- `Godot.Rect2.HasPoint(Godot.Vector2)`；输入表达式：`GetGlobalRect().HasPoint(GetGlobalMousePosition())`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GetGlobalRect().HasPoint(GetGlobalMousePosition())`
- `NationalSpire.BracketInspector.Dismiss()`；输入表达式：`Dismiss()`；返回值紧邻使用处：`ExpressionStatementSyntax: Dismiss();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4ae6702e936d"></a>

## `NationalSpire.BracketInspector.Dismiss() — private void Dismiss()`

来源：源码第 93 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.BracketInspector._Input(Godot.InputEvent)`](BracketInspector.cs.md#symbol-a23e4a2436da)；[`NationalSpire.BracketInspector.Attach(Godot.Control, Godot.ScrollContainer)`](BracketInspector.cs.md#symbol-ddfed770fc0f)；[`NationalSpire.BracketInspector.Bind(Godot.Button, System.Func<Godot.Control>)`](BracketInspector.cs.md#symbol-955dfacc5bbe)；[`NationalSpire.BracketInspector.HideAfterPointerLeaves()`](BracketInspector.cs.md#symbol-cd1dcb62a496)；[`NationalSpire.BracketInspector.OnViewportExit()`](BracketInspector.cs.md#symbol-61dc2706269a)；[`NationalSpire.BracketInspector.PositionCard()`](BracketInspector.cs.md#symbol-7724845fc7ff)；[`OnVisibilityChanged()`](BracketInspector.cs.md#symbol-489d06ef69bb)

**调用：** `Godot.CanvasItem.Hide()`；`Godot.Node.SetProcess(bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.BracketInspector._pinned`；`NationalSpire.BracketInspector._target`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: Hide();`
- `Godot.Node.SetProcess(bool)`；输入表达式：`SetProcess(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetProcess(false);`

**赋值（含属性/字段和局部值）：**

- `_pinned` = `false`
- `_target` = `null`

<a id="symbol-7724845fc7ff"></a>

## `NationalSpire.BracketInspector.PositionCard() — private void PositionCard()`

来源：源码第 101 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.BracketInspector._Process(double)`](BracketInspector.cs.md#symbol-e8da83ec37d7)；[`ShowCard()`](BracketInspector.cs.md#symbol-2759aa16f0ae)

**调用：** [`NationalSpire.BracketInspector.Dismiss()`](BracketInspector.cs.md#symbol-4ae6702e936d)；`Godot.CanvasItem.GetGlobalTransform()`；`Godot.CanvasItem.IsVisibleInTree()`；`Godot.Control.GetCombinedMinimumSize()`；`Godot.Control.GetGlobalRect()`；`Godot.Mathf.Clamp(float, float, float)`；`Godot.Node.GetParent()`；`Godot.Rect2.Intersects(Godot.Rect2, bool)`；`Godot.ScrollContainer.GetHScrollBar()`；`Godot.ScrollContainer.GetVScrollBar()`；`Godot.Transform2D.AffineInverse()`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Max(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.BracketInspector._details`；`NationalSpire.BracketInspector._target`；`NationalSpire.BracketInspector._viewport`；`NationalSpire.BracketInspector.CardWidth`；`NationalSpire.BracketInspector.Dismiss()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.GetGlobalTransform()`；输入表达式：`stage.GetGlobalTransform()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: stage.GetGlobalTransform().AffineInverse`
- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`_target.IsVisibleInTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_target.IsVisibleInTree()`
- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`_details!.GetCombinedMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _details!.GetCombinedMinimumSize().Y`
- `Godot.Control.GetGlobalRect()`；输入表达式：`_target.GetGlobalRect()`；返回值紧邻使用处：`ArgumentSyntax: _target.GetGlobalRect()`
- `Godot.Control.GetGlobalRect()`；输入表达式：`_target.GetGlobalRect()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _target.GetGlobalRect()`
- `Godot.Control.GetGlobalRect()`；输入表达式：`_viewport.GetGlobalRect()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _viewport.GetGlobalRect()`
- `Godot.Control.GetGlobalRect()`；输入表达式：`_viewport.GetGlobalRect()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _viewport.GetGlobalRect().Intersects`
- `Godot.Mathf.Clamp(float, float, float)`；输入表达式：`Mathf.Clamp(_details!.GetCombinedMinimumSize().Y+34,94,Math.Max(94,visibleHeight))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Mathf.Clamp(_details!.GetCombinedMinimumSize().Y+34,94,Math.Max(94,visibleHeight))`
- `Godot.Mathf.Clamp(float, float, float)`；输入表达式：`Mathf.Clamp(left.Y,min.Y,Math.Max(min.Y,max.Y-height))`；返回值紧邻使用处：`ArgumentSyntax: Mathf.Clamp(left.Y,min.Y,Math.Max(min.Y,max.Y-height))`
- `Godot.Mathf.Clamp(float, float, float)`；输入表达式：`Mathf.Clamp(x,min.X,Math.Max(min.X,max.X-CardWidth))`；返回值紧邻使用处：`ArgumentSyntax: Mathf.Clamp(x,min.X,Math.Max(min.X,max.X-CardWidth))`
- `Godot.Node.GetParent()`；输入表达式：`GetParent()`；返回值紧邻使用处：`CastExpressionSyntax: (Control)GetParent()`
- `Godot.Rect2.Intersects(Godot.Rect2, bool)`；输入表达式：`_viewport.GetGlobalRect().Intersects(_target.GetGlobalRect())`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_viewport.GetGlobalRect().Intersects(_target.GetGlobalRect())`
- `Godot.ScrollContainer.GetHScrollBar()`；输入表达式：`_viewport.GetHScrollBar()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _viewport.GetHScrollBar().Visible`
- `Godot.ScrollContainer.GetVScrollBar()`；输入表达式：`_viewport.GetVScrollBar()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _viewport.GetVScrollBar().Visible`
- `Godot.Transform2D.AffineInverse()`；输入表达式：`stage.GetGlobalTransform().AffineInverse()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = stage.GetGlobalTransform().AffineInverse()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(_viewport.GetVScrollBar().Visible?18:6,_viewport.GetHScrollBar().Visible?18:6)`；返回值紧邻使用处：`BinaryExpressionSyntax: inverse*region.End-new Vector2(_viewport.GetVScrollBar().Visible?18:6,_viewport.GetHScrollBar().Visible?18:6)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(6,6)`；返回值紧邻使用处：`BinaryExpressionSyntax: inverse*region.Position+new Vector2(6,6)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(CardWidth,height)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Size=new(CardWidth,height)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Mathf.Clamp(x,min.X,Math.Max(min.X,max.X-CardWidth)),              Mathf.Clamp(left.Y,min.Y,Math.Max(min.Y,max.Y-height)))`；返回值紧邻使用处：`AssignmentExpressionSyntax: Position=new(Mathf.Clamp(x,min.X,Math.Max(min.X,max.X-CardWidth)),              Mathf.Clamp(left.Y,min.Y,Math.Max(min.Y,max.Y-height)))`
- `NationalSpire.BracketInspector.Dismiss()`；输入表达式：`Dismiss()`；返回值紧邻使用处：`ExpressionStatementSyntax: Dismiss();`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(94,visibleHeight)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(94,visibleHeight)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(min.X,max.X-CardWidth)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(min.X,max.X-CardWidth)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(min.Y,max.Y-height)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(min.Y,max.Y-height)`

**赋值（含属性/字段和局部值）：**

- `Position` = `new(Mathf.Clamp(x,min.X,Math.Max(min.X,max.X-CardWidth)),              Mathf.Clamp(left.Y,min.Y,Math.Max(min.Y,max.Y-height)))`
- `Size` = `new(CardWidth,height)`

<a id="symbol-e8da83ec37d7"></a>

## `NationalSpire.BracketInspector._Process(double) — public override void _Process(double delta)`

来源：源码第 124 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.BracketInspector.PositionCard()`](BracketInspector.cs.md#symbol-7724845fc7ff)

**字段、属性、事件及方法组引用：** `NationalSpire.BracketInspector.PositionCard()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.BracketInspector.PositionCard()`；输入表达式：`PositionCard()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => PositionCard()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a23e4a2436da"></a>

## `NationalSpire.BracketInspector._Input(Godot.InputEvent) — public override void _Input(InputEvent input)`

来源：源码第 125 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.BracketInspector.Dismiss()`](BracketInspector.cs.md#symbol-4ae6702e936d)；`Godot.Control.GetGlobalRect()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.GetViewport()`；`Godot.Rect2.HasPoint(Godot.Vector2)`；`Godot.Viewport.SetInputAsHandled()`

**字段、属性、事件及方法组引用：** `NationalSpire.BracketInspector._target`；`NationalSpire.BracketInspector.Dismiss()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.GetGlobalRect()`；输入表达式：`_target!.GetGlobalRect()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _target!.GetGlobalRect().HasPoint`
- `Godot.Control.GetGlobalRect()`；输入表达式：`GetGlobalRect()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetGlobalRect().HasPoint`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_target)`；返回值紧邻使用处：`BinaryExpressionSyntax: input is InputEventMouseButton {Pressed:true, ButtonIndex:MouseButton.Left} && IsInstanceValid(_target)`
- `Godot.Node.GetViewport()`；输入表达式：`GetViewport()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetViewport().SetInputAsHandled`
- `Godot.Rect2.HasPoint(Godot.Vector2)`；输入表达式：`_target!.GetGlobalRect().HasPoint(((InputEventMouseButton)input).Position)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_target!.GetGlobalRect().HasPoint(((InputEventMouseButton)input).Position)`
- `Godot.Rect2.HasPoint(Godot.Vector2)`；输入表达式：`GetGlobalRect().HasPoint(((InputEventMouseButton)input).Position)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GetGlobalRect().HasPoint(((InputEventMouseButton)input).Position)`
- `Godot.Viewport.SetInputAsHandled()`；输入表达式：`GetViewport().SetInputAsHandled()`；返回值紧邻使用处：`ExpressionStatementSyntax: GetViewport().SetInputAsHandled();`
- `NationalSpire.BracketInspector.Dismiss()`；输入表达式：`Dismiss()`；返回值紧邻使用处：`ExpressionStatementSyntax: Dismiss();`

**赋值（含属性/字段和局部值）：**
