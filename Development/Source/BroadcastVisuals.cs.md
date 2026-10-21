# BroadcastVisuals.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`76721612842400EDC752179C8E9B99BF97D871AD379666452A4527DEE5ADA0FB`。来源：[源码](../../BroadcastVisuals.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.BroadcastButton`、`NationalSpire.BroadcastBackdrop`、`NationalSpire.BroadcastScroll`、`NationalSpire.BroadcastTransition`、`NationalSpire.BroadcastPanel`、`NationalSpire.BroadcastPortrait`、`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
private Tween? _hoverTween, _pressTween;
private float _highlight, _press;
private bool _hovered;
private Tween? _wheelTween;
private int _target, _direction;
private float _progress;
private Tween? _pageTween;
private string _visualLocation = "";
private BroadcastTransition? _pageEffect;
```

<a id="symbol-287d0e52f64e"></a>

## `NationalSpire.BroadcastButton.Primary — public bool Primary`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0d6eb1d78b31"></a>

## `NationalSpire.BroadcastButton._Ready() — public override void _Ready()`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.BroadcastButton.Highlight()`](BroadcastVisuals.cs.md#symbol-912cb0037577)；`Godot.Callable.From<T0>(System.Action<T0>)`；`Godot.CanvasItem.QueueRedraw()`；`Godot.Node.CreateTween()`；`Godot.Tween.Kill()`；`Godot.Tween.TweenMethod(Godot.Callable, Godot.Variant, Godot.Variant, double)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastButton._hovered`；`NationalSpire.BroadcastButton._press`；`NationalSpire.BroadcastButton._pressTween`；`NationalSpire.BroadcastButton.Highlight()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.From<T0>(System.Action<T0>)`；输入表达式：`Callable.From<float>(v => { _press = v; QueueRedraw(); })`；返回值紧邻使用处：`ArgumentSyntax: Callable.From<float>(v => { _press = v; QueueRedraw(); })`
- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`
- `Godot.Node.CreateTween()`；输入表达式：`CreateTween()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _pressTween = CreateTween()`
- `Godot.Tween.Kill()`；输入表达式：`.Kill()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _pressTween?.Kill()`
- `Godot.Tween.TweenMethod(Godot.Callable, Godot.Variant, Godot.Variant, double)`；输入表达式：`_pressTween.TweenMethod(Callable.From<float>(v => { _press = v; QueueRedraw(); }), 1f, 0f, .24)`；返回值紧邻使用处：`ExpressionStatementSyntax: _pressTween.TweenMethod(Callable.From<float>(v => { _press = v; QueueRedraw(); }), 1f, 0f, .24);`
- `NationalSpire.BroadcastButton.Highlight()`；输入表达式：`Highlight()`；返回值紧邻使用处：`ExpressionStatementSyntax: Highlight();`

**赋值（含属性/字段和局部值）：**

- `_hovered` = `false`
- `_hovered` = `true`
- `_press` = `1`
- `_press` = `v`
- `_pressTween` = `CreateTween()`
- `ButtonDown` += `() =>          {              if (Disabled) return;              _pressTween?.Kill(); _press = 1; QueueRedraw();              _pressTween = CreateTween();              _pressTween.TweenMethod(Callable.From<float>(v => { _press = v; QueueRedraw(); }), 1f, 0f, .24);          }`
- `FocusEntered` += `Highlight`
- `FocusExited` += `Highlight`
- `MouseEntered` += `() => { _hovered = true; Highlight(); }`
- `MouseExited` += `() => { _hovered = false; Highlight(); }`
- `Resized` += `QueueRedraw`

<a id="symbol-912cb0037577"></a>

## `NationalSpire.BroadcastButton.Highlight() — private void Highlight()`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.BroadcastButton._Ready()`](BroadcastVisuals.cs.md#symbol-0d6eb1d78b31)

**调用：** `Godot.Callable.From<T0>(System.Action<T0>)`；`Godot.CanvasItem.QueueRedraw()`；`Godot.Control.HasFocus()`；`Godot.Node.CreateTween()`；`Godot.Tween.Kill()`；`Godot.Tween.SetEase(Godot.Tween.EaseType)`；`Godot.Tween.SetTrans(Godot.Tween.TransitionType)`；`Godot.Tween.TweenMethod(Godot.Callable, Godot.Variant, Godot.Variant, double)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastButton._highlight`；`NationalSpire.BroadcastButton._hovered`；`NationalSpire.BroadcastButton._hoverTween`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.From<T0>(System.Action<T0>)`；输入表达式：`Callable.From<float>(v => { _highlight = v; QueueRedraw(); })`；返回值紧邻使用处：`ArgumentSyntax: Callable.From<float>(v => { _highlight = v; QueueRedraw(); })`
- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`
- `Godot.Control.HasFocus()`；输入表达式：`HasFocus()`；返回值紧邻使用处：`BinaryExpressionSyntax: _hovered || HasFocus()`
- `Godot.Node.CreateTween()`；输入表达式：`CreateTween()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CreateTween().SetEase`
- `Godot.Tween.Kill()`；输入表达式：`.Kill()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _hoverTween?.Kill()`
- `Godot.Tween.SetEase(Godot.Tween.EaseType)`；输入表达式：`CreateTween().SetEase(Tween.EaseType.Out)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CreateTween().SetEase(Tween.EaseType.Out).SetTrans`
- `Godot.Tween.SetTrans(Godot.Tween.TransitionType)`；输入表达式：`CreateTween().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Cubic)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _hoverTween = CreateTween().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Cubic)`
- `Godot.Tween.TweenMethod(Godot.Callable, Godot.Variant, Godot.Variant, double)`；输入表达式：`_hoverTween.TweenMethod(Callable.From<float>(v => { _highlight = v; QueueRedraw(); }), _highlight, target, .16)`；返回值紧邻使用处：`ExpressionStatementSyntax: _hoverTween.TweenMethod(Callable.From<float>(v => { _highlight = v; QueueRedraw(); }), _highlight, target, .16);`

**赋值（含属性/字段和局部值）：**

- `_highlight` = `v`
- `_hoverTween` = `CreateTween().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Cubic)`

<a id="symbol-af460c9f3bf3"></a>

## `NationalSpire.BroadcastButton._Draw() — public override void _Draw()`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；`Godot.Color.Color(Godot.Color, float)`；`Godot.Rect2.Rect2(float, float, float, float)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Max(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastButton._highlight`；`NationalSpire.BroadcastButton._press`；`NationalSpire.CareerVisuals.Teal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new Vector2(14, Size.Y - 5), new Vector2(14 + Math.Max(0, Size.X - 28) * _highlight, Size.Y - 5), new Color(accent, _highlight), 2, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new Vector2(14, Size.Y - 5), new Vector2(14 + Math.Max(0, Size.X - 28) * _highlight, Size.Y - 5), new Color(accent, _highlight), 2, true);`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；输入表达式：`DrawRect(new Rect2(4, 4, Size.X - 8, Size.Y - 8), new Color(accent, _highlight * .045f))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(new Rect2(4, 4, Size.X - 8, Size.Y - 8), new Color(accent, _highlight * .045f));`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；输入表达式：`DrawRect(new Rect2(Vector2.Zero, Size), new Color(accent, _press * .15f))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(new Rect2(Vector2.Zero, Size), new Color(accent, _press * .15f));`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(accent, _highlight * .045f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(accent, _highlight * .045f)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(accent, _highlight)`；返回值紧邻使用处：`ArgumentSyntax: new Color(accent, _highlight)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(accent, _press * .15f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(accent, _press * .15f)`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new Rect2(4, 4, Size.X - 8, Size.Y - 8)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(4, 4, Size.X - 8, Size.Y - 8)`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero, Size)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(Vector2.Zero, Size)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(14 + Math.Max(0, Size.X - 28) * _highlight, Size.Y - 5)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(14 + Math.Max(0, Size.X - 28) * _highlight, Size.Y - 5)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(14, Size.Y - 5)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(14, Size.Y - 5)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(0, Size.X - 28)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(0, Size.X - 28) * _highlight`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a6a6fdac3734"></a>

## `NationalSpire.BroadcastButton._ExitTree() — public override void _ExitTree()`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Tween.Kill()`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastButton._hoverTween`；`NationalSpire.BroadcastButton._pressTween`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Tween.Kill()`；输入表达式：`.Kill()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _hoverTween?.Kill()`
- `Godot.Tween.Kill()`；输入表达式：`.Kill()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _pressTween?.Kill()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2da65fe772c2"></a>

## `NationalSpire.BroadcastBackdrop._Ready() — public override void _Ready()`

来源：源码第 49 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Resized` += `QueueRedraw`

<a id="symbol-bbc66a75bc09"></a>

## `NationalSpire.BroadcastBackdrop._Draw() — public override void _Draw()`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；`Godot.Color.Color(string)`；`Godot.Rect2.Rect2(float, float, float, float)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Lime`；`NationalSpire.CareerVisuals.Teal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([new(w * .42f, 0), new(w, 0), new(w, h * .65f), new(w * .12f, h)], new Color("0e1b29"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([new(w * .42f, 0), new(w, 0), new(w, h * .65f), new(w * .12f, h)], new Color("0e1b29"));`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([new(w * .72f, 0), new(w * .88f, 0), new(w * .47f, h), new(w * .31f, h)], new Color("112531"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([new(w * .72f, 0), new(w * .88f, 0), new(w * .47f, h), new(w * .31f, h)], new Color("112531"));`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new Vector2(w * .55f + i * 46, 0), new Vector2(w * .15f + i * 46, h), new Color("69dcd008"), 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new Vector2(w * .55f + i * 46, 0), new Vector2(w * .15f + i * 46, h), new Color("69dcd008"), 1);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new Vector2(w * .88f, 0), new Vector2(w * .47f, h), new Color("86bca521"), 1, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new Vector2(w * .88f, 0), new Vector2(w * .47f, h), new Color("86bca521"), 1, true);`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；输入表达式：`DrawRect(new Rect2(0, 0, w * .28f, 3), CareerVisuals.Lime)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(new Rect2(0, 0, w * .28f, 3), CareerVisuals.Lime);`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；输入表达式：`DrawRect(new Rect2(Vector2.Zero, Size), new Color("090e18"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(new Rect2(Vector2.Zero, Size), new Color("090e18"));`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；输入表达式：`DrawRect(new Rect2(w * .28f + 6, 0, w * .11f, 3), CareerVisuals.Teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(new Rect2(w * .28f + 6, 0, w * .11f, 3), CareerVisuals.Teal);`
- `Godot.Color.Color(string)`；输入表达式：`new Color("090e18")`；返回值紧邻使用处：`ArgumentSyntax: new Color("090e18")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("0e1b29")`；返回值紧邻使用处：`ArgumentSyntax: new Color("0e1b29")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("112531")`；返回值紧邻使用处：`ArgumentSyntax: new Color("112531")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("69dcd008")`；返回值紧邻使用处：`ArgumentSyntax: new Color("69dcd008")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("86bca521")`；返回值紧邻使用处：`ArgumentSyntax: new Color("86bca521")`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new Rect2(0, 0, w * .28f, 3)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(0, 0, w * .28f, 3)`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new Rect2(w * .28f + 6, 0, w * .11f, 3)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(w * .28f + 6, 0, w * .11f, 3)`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero, Size)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(Vector2.Zero, Size)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(w * .15f + i * 46, h)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(w * .15f + i * 46, h)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(w * .47f, h)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(w * .47f, h)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(w * .55f + i * 46, 0)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(w * .55f + i * 46, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(w * .88f, 0)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(w * .88f, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(w * .12f, h)`；返回值紧邻使用处：`ExpressionElementSyntax: new(w * .12f, h)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(w * .31f, h)`；返回值紧邻使用处：`ExpressionElementSyntax: new(w * .31f, h)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(w * .42f, 0)`；返回值紧邻使用处：`ExpressionElementSyntax: new(w * .42f, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(w * .47f, h)`；返回值紧邻使用处：`ExpressionElementSyntax: new(w * .47f, h)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(w * .72f, 0)`；返回值紧邻使用处：`ExpressionElementSyntax: new(w * .72f, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(w * .88f, 0)`；返回值紧邻使用处：`ExpressionElementSyntax: new(w * .88f, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(w, 0)`；返回值紧邻使用处：`ExpressionElementSyntax: new(w, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(w, h * .65f)`；返回值紧邻使用处：`ExpressionElementSyntax: new(w, h * .65f)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b858c7de4b8d"></a>

## `NationalSpire.BroadcastScroll.StopMotion() — public void StopMotion()`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.BroadcastScroll._ExitTree()`](BroadcastVisuals.cs.md#symbol-311cb40e4c47)；[`NationalSpire.BroadcastScroll._GuiInput(Godot.InputEvent)`](BroadcastVisuals.cs.md#symbol-1a48859941e6)；[`NationalSpire.BroadcastScroll._Ready()`](BroadcastVisuals.cs.md#symbol-94caf301d158)；[`NationalSpire.BroadcastScroll.ScrollWheel(int, double)`](BroadcastVisuals.cs.md#symbol-482eddf2d675)；[`NationalSpire.CareerScreen.BeginReply(NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-6bc7befbb991)；[`NationalSpire.CareerScreen.CloseThreadReply(string, string)`](CommunityScreen.cs.md#symbol-65baf7e888c9)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.ToggleDiscussion(NationalSpire.CommunityPost, string)`](CommunityScreen.cs.md#symbol-10637dfc37f0)

**调用：** `Godot.Tween.Kill()`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastScroll._direction`；`NationalSpire.BroadcastScroll._wheelTween`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Tween.Kill()`；输入表达式：`.Kill()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _wheelTween?.Kill()`

**赋值（含属性/字段和局部值）：**

- `_direction` = `0`
- `_wheelTween` = `null`

<a id="symbol-94caf301d158"></a>

## `NationalSpire.BroadcastScroll._Ready() — public override void _Ready()`

来源：源码第 69 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.BroadcastScroll.StopMotion()`](BroadcastVisuals.cs.md#symbol-b858c7de4b8d)；`Godot.ScrollContainer.GetVScrollBar()`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastScroll.StopMotion()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ScrollContainer.GetVScrollBar()`；输入表达式：`GetVScrollBar()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetVScrollBar().GuiInput`
- `NationalSpire.BroadcastScroll.StopMotion()`；输入表达式：`StopMotion()`；返回值紧邻使用处：`ExpressionStatementSyntax: StopMotion();`

**赋值（含属性/字段和局部值）：**

- `GetVScrollBar().GuiInput` += `input => { if (input is InputEventMouseButton { Pressed: true, ButtonIndex: MouseButton.Left }) StopMotion(); }`

<a id="symbol-e5e90f272190"></a>

## `NationalSpire.BroadcastScroll._Input(Godot.InputEvent) — public override void _Input(InputEvent input)`

来源：源码第 73 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.BroadcastScroll.ScrollWheel(int, double)`](BroadcastVisuals.cs.md#symbol-482eddf2d675)；`Godot.CanvasItem.IsVisibleInTree()`；`Godot.Control.GetGlobalRect()`；`Godot.Node.GetParent()`；`Godot.Node.GetViewport()`；`Godot.Rect2.HasPoint(Godot.Vector2)`；`Godot.Viewport.GuiGetHoveredControl()`；`Godot.Viewport.SetInputAsHandled()`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastScroll.ScrollWheel(int, double)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`IsVisibleInTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsVisibleInTree()`
- `Godot.Control.GetGlobalRect()`；输入表达式：`GetGlobalRect()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetGlobalRect().HasPoint`
- `Godot.Node.GetParent()`；输入表达式：`current.GetParent()`；返回值紧邻使用处：`AssignmentExpressionSyntax: current = current.GetParent()`
- `Godot.Node.GetViewport()`；输入表达式：`GetViewport()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetViewport().GuiGetHoveredControl`
- `Godot.Node.GetViewport()`；输入表达式：`GetViewport()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetViewport().SetInputAsHandled`
- `Godot.Rect2.HasPoint(Godot.Vector2)`；输入表达式：`GetGlobalRect().HasPoint(wheel.Position)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GetGlobalRect().HasPoint(wheel.Position)`
- `Godot.Viewport.GuiGetHoveredControl()`；输入表达式：`GetViewport().GuiGetHoveredControl()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetViewport().GuiGetHoveredControl()`
- `Godot.Viewport.SetInputAsHandled()`；输入表达式：`GetViewport().SetInputAsHandled()`；返回值紧邻使用处：`ExpressionStatementSyntax: GetViewport().SetInputAsHandled();`
- `NationalSpire.BroadcastScroll.ScrollWheel(int, double)`；输入表达式：`ScrollWheel(wheel.ButtonIndex == MouseButton.WheelDown ? 1 : -1, wheel.Factor)`；返回值紧邻使用处：`ExpressionStatementSyntax: ScrollWheel(wheel.ButtonIndex == MouseButton.WheelDown ? 1 : -1, wheel.Factor);`

**赋值（含属性/字段和局部值）：**

- `current` = `current.GetParent()`

<a id="symbol-482eddf2d675"></a>

## `NationalSpire.BroadcastScroll.ScrollWheel(int, double) — internal void ScrollWheel(int direction, double factor)`

来源：源码第 90 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.BroadcastScroll._Input(Godot.InputEvent)`](BroadcastVisuals.cs.md#symbol-e5e90f272190)

**调用：** [`NationalSpire.BroadcastScroll.StopMotion()`](BroadcastVisuals.cs.md#symbol-b858c7de4b8d)；`Godot.Callable.From<T0>(System.Action<T0>)`；`Godot.Node.CreateTween()`；`Godot.ScrollContainer.GetVScrollBar()`；`Godot.Tween.IsRunning()`；`Godot.Tween.SetEase(Godot.Tween.EaseType)`；`Godot.Tween.SetTrans(Godot.Tween.TransitionType)`；`Godot.Tween.TweenMethod(Godot.Callable, Godot.Variant, Godot.Variant, double)`；`System.Math.Clamp(double, double, double)`；`System.Math.Clamp(int, int, int)`；`System.Math.Max(int, int)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastScroll._direction`；`NationalSpire.BroadcastScroll._target`；`NationalSpire.BroadcastScroll._wheelTween`；`NationalSpire.BroadcastScroll.StopMotion()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.From<T0>(System.Action<T0>)`；输入表达式：`Callable.From<float>(v => ScrollVertical = Math.Clamp((int)v, 0, Math.Max(0, (int)(bar.MaxValue - bar.Page))))`；返回值紧邻使用处：`ArgumentSyntax: Callable.From<float>(v => ScrollVertical = Math.Clamp((int)v, 0, Math.Max(0, (int)(bar.MaxValue - bar.Page))))`
- `Godot.Node.CreateTween()`；输入表达式：`CreateTween()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CreateTween().SetEase`
- `Godot.ScrollContainer.GetVScrollBar()`；输入表达式：`GetVScrollBar()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetVScrollBar()`
- `Godot.Tween.IsRunning()`；输入表达式：`.IsRunning()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _wheelTween?.IsRunning()`
- `Godot.Tween.SetEase(Godot.Tween.EaseType)`；输入表达式：`CreateTween().SetEase(Tween.EaseType.Out)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CreateTween().SetEase(Tween.EaseType.Out).SetTrans`
- `Godot.Tween.SetTrans(Godot.Tween.TransitionType)`；输入表达式：`CreateTween().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Cubic)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _wheelTween = CreateTween().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Cubic)`
- `Godot.Tween.TweenMethod(Godot.Callable, Godot.Variant, Godot.Variant, double)`；输入表达式：`_wheelTween.TweenMethod(Callable.From<float>(v => ScrollVertical = Math.Clamp((int)v, 0, Math.Max(0, (int)(bar.MaxValue - bar.Page)))), (float)ScrollVertical, (float)target, .13)`；返回值紧邻使用处：`ExpressionStatementSyntax: _wheelTween.TweenMethod(Callable.From<float>(v => ScrollVertical = Math.Clamp((int)v, 0, Math.Max(0, (int)(bar.MaxValue - bar.Page)))), (float)ScrollVertical, (float)target, .13);`
- `NationalSpire.BroadcastScroll.StopMotion()`；输入表达式：`StopMotion()`；返回值紧邻使用处：`ExpressionStatementSyntax: StopMotion();`
- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp(factor, .1, 4)`；返回值紧邻使用处：`BinaryExpressionSyntax: 86 * Math.Clamp(factor, .1, 4)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp((int)v, 0, Math.Max(0, (int)(bar.MaxValue - bar.Page)))`；返回值紧邻使用处：`AssignmentExpressionSyntax: ScrollVertical = Math.Clamp((int)v, 0, Math.Max(0, (int)(bar.MaxValue - bar.Page)))`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(origin + (int)(86 * Math.Clamp(factor, .1, 4) * direction), 0, maximum)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Clamp(origin + (int)(86 * Math.Clamp(factor, .1, 4) * direction), 0, maximum)`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(target, Math.Max(0, ScrollVertical - 258), Math.Min(maximum, ScrollVertical + 258))`；返回值紧邻使用处：`AssignmentExpressionSyntax: target = Math.Clamp(target, Math.Max(0, ScrollVertical - 258), Math.Min(maximum, ScrollVertical + 258))`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, (int)(bar.MaxValue - bar.Page))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, (int)(bar.MaxValue - bar.Page))`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, (int)(bar.MaxValue - bar.Page))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(0, (int)(bar.MaxValue - bar.Page))`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, ScrollVertical - 258)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, ScrollVertical - 258)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(maximum, ScrollVertical + 258)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(maximum, ScrollVertical + 258)`

**赋值（含属性/字段和局部值）：**

- `_direction` = `direction`
- `_target` = `target`
- `_wheelTween` = `CreateTween().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Cubic)`
- `ScrollVertical` = `Math.Clamp((int)v, 0, Math.Max(0, (int)(bar.MaxValue - bar.Page)))`
- `target` = `Math.Clamp(target, Math.Max(0, ScrollVertical - 258), Math.Min(maximum, ScrollVertical + 258))`

<a id="symbol-1a48859941e6"></a>

## `NationalSpire.BroadcastScroll._GuiInput(Godot.InputEvent) — public override void _GuiInput(InputEvent input)`

来源：源码第 107 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.BroadcastScroll.StopMotion()`](BroadcastVisuals.cs.md#symbol-b858c7de4b8d)

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastScroll.StopMotion()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.BroadcastScroll.StopMotion()`；输入表达式：`StopMotion()`；返回值紧邻使用处：`ExpressionStatementSyntax: StopMotion();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-311cb40e4c47"></a>

## `NationalSpire.BroadcastScroll._ExitTree() — public override void _ExitTree()`

来源：源码第 111 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.BroadcastScroll.StopMotion()`](BroadcastVisuals.cs.md#symbol-b858c7de4b8d)

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastScroll.StopMotion()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.BroadcastScroll.StopMotion()`；输入表达式：`StopMotion()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => StopMotion()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-30b6284738c0"></a>

## `NationalSpire.BroadcastTransition.Progress — public float Progress`

来源：源码第 118 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.QueueRedraw()`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastTransition._progress`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`

**赋值（含属性/字段和局部值）：**

- `_progress` = `value`

<a id="symbol-01a360f85883"></a>

## `NationalSpire.BroadcastTransition._Draw() — public override void _Draw()`

来源：源码第 119 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.Color.Color(Godot.Color, float)`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Min(float, float)`；`System.MathF.Sin(float)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastTransition._progress`；`NationalSpire.CareerVisuals.Teal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([new(x, 0), new(x + 90, 0), new(x - 30, Size.Y), new(x - 120, Size.Y)], new Color(CareerVisuals.Teal, alpha))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([new(x, 0), new(x + 90, 0), new(x - 30, Size.Y), new(x - 120, Size.Y)], new Color(CareerVisuals.Teal, alpha));`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new Vector2(0, 1), new Vector2(Math.Min(Size.X, 180) * _progress, 1), new Color(CareerVisuals.Teal, alpha * 5), 2)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new Vector2(0, 1), new Vector2(Math.Min(Size.X, 180) * _progress, 1), new Color(CareerVisuals.Teal, alpha * 5), 2);`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(CareerVisuals.Teal, alpha * 5)`；返回值紧邻使用处：`ArgumentSyntax: new Color(CareerVisuals.Teal, alpha * 5)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(CareerVisuals.Teal, alpha)`；返回值紧邻使用处：`ArgumentSyntax: new Color(CareerVisuals.Teal, alpha)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, 1)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(0, 1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(Math.Min(Size.X, 180) * _progress, 1)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(Math.Min(Size.X, 180) * _progress, 1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(x - 120, Size.Y)`；返回值紧邻使用处：`ExpressionElementSyntax: new(x - 120, Size.Y)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(x - 30, Size.Y)`；返回值紧邻使用处：`ExpressionElementSyntax: new(x - 30, Size.Y)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(x + 90, 0)`；返回值紧邻使用处：`ExpressionElementSyntax: new(x + 90, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(x, 0)`；返回值紧邻使用处：`ExpressionElementSyntax: new(x, 0)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(Size.X, 180)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(Size.X, 180) * _progress`
- `System.MathF.Sin(float)`；输入表达式：`MathF.Sin(MathF.PI * _progress)`；返回值紧邻使用处：`BinaryExpressionSyntax: MathF.Sin(MathF.PI * _progress) * .055f`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4ead0137ed89"></a>

## `NationalSpire.BroadcastPanel.Accent — public Color Accent`

来源：源码第 130 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Color.Color(string)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new("527783")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new("527783")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-23d5cd696c6b"></a>

## `NationalSpire.BroadcastPanel._Ready() — public override void _Ready()`

来源：源码第 131 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `Resized` += `QueueRedraw`

<a id="symbol-4d20a373cdd0"></a>

## `NationalSpire.BroadcastPanel._Draw() — public override void _Draw()`

来源：源码第 132 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.Color.Color(Godot.Color, float)`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastPanel.Accent`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new Vector2(18, 1), new Vector2(Math.Min(Size.X - 18, 76), 1), Accent, 2, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new Vector2(18, 1), new Vector2(Math.Min(Size.X - 18, 76), 1), Accent, 2, true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new Vector2(Size.X - 34, 12), new Vector2(Size.X - 20, 12), new Color(Accent, .45f), 1, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new Vector2(Size.X - 34, 12), new Vector2(Size.X - 20, 12), new Color(Accent, .45f), 1, true);`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(Accent, .45f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(Accent, .45f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(18, 1)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(18, 1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(Math.Min(Size.X - 18, 76), 1)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(Math.Min(Size.X - 18, 76), 1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(Size.X - 20, 12)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(Size.X - 20, 12)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(Size.X - 34, 12)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(Size.X - 34, 12)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(Size.X - 18, 76)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(Size.X - 18, 76)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-12f3d2d35645"></a>

## `NationalSpire.BroadcastPortrait.Art — public AvatarArt Art`

来源：源码第 142 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Teal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；输入表达式：`new(null, CareerVisuals.Teal, "")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new(null, CareerVisuals.Teal, "")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-72995fdbf015"></a>

## `NationalSpire.BroadcastPortrait._Ready() — public override void _Ready()`

来源：源码第 143 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Resized` += `QueueRedraw`

<a id="symbol-672a82e63b57"></a>

## `NationalSpire.BroadcastPortrait._Draw() — public override void _Draw()`

来源：源码第 144 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；`Godot.CanvasItem.DrawTextureRect(Godot.Texture2D, Godot.Rect2, bool, Godot.Color?, bool)`；`Godot.Color.Color(Godot.Color, float)`；`Godot.Color.Color(string)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Texture2D.GetSize()`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarArt.Accent`；`NationalSpire.AvatarArt.Texture`；`NationalSpire.BroadcastPortrait.Art`；`NationalSpire.CareerVisuals.Lime`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(new Vector2(w * .55f, h * .46f), Math.Min(w, h) * .42f, -.5f, 4.6f, 48, new Color(Art.Accent, .5f), 2, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(new Vector2(w * .55f, h * .46f), Math.Min(w, h) * .42f, -.5f, 4.6f, 48, new Color(Art.Accent, .5f), 2, true);`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([new(w - 48, h), new(w, h - 48), new(w, h)], CareerVisuals.Lime)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([new(w - 48, h), new(w, h - 48), new(w, h)], CareerVisuals.Lime);`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([new(w * .35f, 0), new(w, 0), new(w, h), new(0, h)], new Color(Art.Accent, .19f))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([new(w * .35f, 0), new(w, 0), new(w, h), new(0, h)], new Color(Art.Accent, .19f));`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new Vector2(12, h - 13), new Vector2(w * .48f, h - 13), CareerVisuals.Lime, 3, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new Vector2(12, h - 13), new Vector2(w * .48f, h - 13), CareerVisuals.Lime, 3, true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new Vector2(w * .5f + i * 20, 0), new Vector2(i * 20, h), new Color(Art.Accent, .13f), 2, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new Vector2(w * .5f + i * 20, 0), new Vector2(i * 20, h), new Color(Art.Accent, .13f), 2, true);`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；输入表达式：`DrawRect(new Rect2(Vector2.Zero, Size), new Color("101d30"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(new Rect2(Vector2.Zero, Size), new Color("101d30"));`
- `Godot.CanvasItem.DrawTextureRect(Godot.Texture2D, Godot.Rect2, bool, Godot.Color?, bool)`；输入表达式：`DrawTextureRect(texture, new Rect2((Size - size) / 2, size), false)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawTextureRect(texture, new Rect2((Size - size) / 2, size), false);`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(Art.Accent, .13f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(Art.Accent, .13f)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(Art.Accent, .19f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(Art.Accent, .19f)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(Art.Accent, .5f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(Art.Accent, .5f)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("101d30")`；返回值紧邻使用处：`ArgumentSyntax: new Color("101d30")`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(texture)`；返回值紧邻使用处：`BinaryExpressionSyntax: Art.Texture is { } texture && GodotObject.IsInstanceValid(texture)`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2((Size - size) / 2, size)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2((Size - size) / 2, size)`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero, Size)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(Vector2.Zero, Size)`
- `Godot.Texture2D.GetSize()`；输入表达式：`texture.GetSize()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = texture.GetSize()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(12, h - 13)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(12, h - 13)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(i * 20, h)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(i * 20, h)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(w * .48f, h - 13)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(w * .48f, h - 13)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(w * .55f, h * .46f)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(w * .55f, h * .46f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(w * .5f + i * 20, 0)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(w * .5f + i * 20, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, h)`；返回值紧邻使用处：`ExpressionElementSyntax: new(0, h)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(w - 48, h)`；返回值紧邻使用处：`ExpressionElementSyntax: new(w - 48, h)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(w * .35f, 0)`；返回值紧邻使用处：`ExpressionElementSyntax: new(w * .35f, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(w, 0)`；返回值紧邻使用处：`ExpressionElementSyntax: new(w, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(w, h - 48)`；返回值紧邻使用处：`ExpressionElementSyntax: new(w, h - 48)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(w, h)`；返回值紧邻使用处：`ExpressionElementSyntax: new(w, h)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min((w - 24) / source.X, (h - 18) / source.Y)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min((w - 24) / source.X, (h - 18) / source.Y)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(w, h)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(w, h) * .42f`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2d2341b9ff8a"></a>

## `NationalSpire.CareerScreen.AnimatePage() — private void AnimatePage()`

来源：源码第 169 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)

**调用：** `Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.Callable.From<T0>(System.Action<T0>)`；`Godot.CanvasItem.GetGlobalTransform()`；`Godot.CanvasItem.Hide()`；`Godot.CanvasItem.Show()`；`Godot.Color.Color(float, float, float, float)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.CreateTween()`；`Godot.Node.IsInsideTree()`；`Godot.Transform2D.AffineInverse()`；`Godot.Tween.Chain()`；`Godot.Tween.Kill()`；`Godot.Tween.SetEase(Godot.Tween.EaseType)`；`Godot.Tween.SetParallel(bool)`；`Godot.Tween.SetTrans(Godot.Tween.TransitionType)`；`Godot.Tween.TweenCallback(Godot.Callable)`；`Godot.Tween.TweenMethod(Godot.Callable, Godot.Variant, Godot.Variant, double)`；`Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；`NationalSpire.BroadcastTransition.BroadcastTransition()`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastTransition.Progress`；`NationalSpire.CareerScreen._communityFilter`；`NationalSpire.CareerScreen._competitionId`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._pageEffect`；`NationalSpire.CareerScreen._pageTween`；`NationalSpire.CareerScreen._personId`；`NationalSpire.CareerScreen._postId`；`NationalSpire.CareerScreen._profileFilter`；`NationalSpire.CareerScreen._renderVersion`；`NationalSpire.CareerScreen._scroll`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen._visualLocation`；`NationalSpire.CareerScreen._worldSection`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(() =>          {              if (!IsInsideTree() || IsQueuedForDeletion() || version != _renderVersion) return;              if (_pageEffect == null)              {                  _pageEffect = new BroadcastTransition { MouseFilter = MouseFilterEnum.Ignore, ClipContents = true };                  _stage.AddChild(_pageEffect);              }              _pageEffect.Position = _stage.GetGlobalTransform().AffineInverse() * _scroll.GlobalPosition;              _pageEffect.Size = _scroll.Size; _pageEffect.Progress = 0; _pageEffect.Show();              _content.Modulate = new Color(1, 1, 1, .55f);              _pageTween = CreateTween().SetParallel().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Cubic);              _pageTween.TweenProperty(_content, "modulate:a", 1f, .20);              _pageTween.TweenMethod(Callable.From<float>(v => _pageEffect.Progress = v), 0f, 1f, .28);              _pageTween.Chain().TweenCallback(Callable.From(() => _pageEffect.Hide()));          }).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(() =>          {              if (!IsInsideTree() || IsQueuedForDeletion() || version != _renderVersion) return;              if (_pageEffect == null)              {                  _pageEffect = new BroadcastTransition { MouseFilter = MouseFilterEnum.Ignore, ClipContents = true };                  _stage.AddChild(_pageEffect);              }              _pageEffect.Position = _stage.GetGlobalTransform().AffineInverse() * _scroll.GlobalPosition;              _pageEffect.Size = _scroll.Size; _pageEffect.Progress = 0; _pageEffect.Show();              _content.Modulate = new Color(1, 1, 1, .55f);              _pageTween = CreateTween().SetParallel().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Cubic);              _pageTween.TweenProperty(_content, "modulate:a", 1f, .20);              _pageTween.TweenMethod(Callable.From<float>(v => _pageEffect.Progress = v), 0f, 1f, .28);              _pageTween.Chain().TweenCallback(Callable.From(() => _pageEffect.Hide()));          }).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(() =>          {              if (!IsInsideTree() || IsQueuedForDeletion() || version != _renderVersion) return;              if (_pageEffect == null)              {                  _pageEffect = new BroadcastTransition { MouseFilter = MouseFilterEnum.Ignore, ClipContents = true };                  _stage.AddChild(_pageEffect);              }              _pageEffect.Position = _stage.GetGlobalTransform().AffineInverse() * _scroll.GlobalPosition;              _pageEffect.Size = _scroll.Size; _pageEffect.Progress = 0; _pageEffect.Show();              _content.Modulate = new Color(1, 1, 1, .55f);              _pageTween = CreateTween().SetParallel().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Cubic);              _pageTween.TweenProperty(_content, "modulate:a", 1f, .20);              _pageTween.TweenMethod(Callable.From<float>(v => _pageEffect.Progress = v), 0f, 1f, .28);              _pageTween.Chain().TweenCallback(Callable.From(() => _pageEffect.Hide()));          })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(() =>          {              if (!IsInsideTree() || IsQueuedForDeletion() || version != _renderVersion) return;              if (_pageEffect == null)              {                  _pageEffect = new BroadcastTransition { MouseFilter = MouseFilterEnum.Ignore, ClipContents = true };                  _stage.AddChild(_pageEffect);              }              _pageEffect.Position = _stage.GetGlobalTransform().AffineInverse() * _scroll.GlobalPosition;              _pageEffect.Size = _scroll.Size; _pageEffect.Progress = 0; _pageEffect.Show();              _content.Modulate = new Color(1, 1, 1, .55f);              _pageTween = CreateTween().SetParallel().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Cubic);              _pageTween.TweenProperty(_content, "modulate:a", 1f, .20);              _pageTween.TweenMethod(Callable.From<float>(v => _pageEffect.Progress = v), 0f, 1f, .28);              _pageTween.Chain().TweenCallback(Callable.From(() => _pageEffect.Hide()));          }).CallDeferred`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(() => _pageEffect.Hide())`；返回值紧邻使用处：`ArgumentSyntax: Callable.From(() => _pageEffect.Hide())`
- `Godot.Callable.From<T0>(System.Action<T0>)`；输入表达式：`Callable.From<float>(v => _pageEffect.Progress = v)`；返回值紧邻使用处：`ArgumentSyntax: Callable.From<float>(v => _pageEffect.Progress = v)`
- `Godot.CanvasItem.GetGlobalTransform()`；输入表达式：`_stage.GetGlobalTransform()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _stage.GetGlobalTransform().AffineInverse`
- `Godot.CanvasItem.Hide()`；输入表达式：`_pageEffect.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _pageEffect.Hide();`
- `Godot.CanvasItem.Hide()`；输入表达式：`_pageEffect.Hide()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => _pageEffect.Hide()`
- `Godot.CanvasItem.Show()`；输入表达式：`_pageEffect.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: _pageEffect.Show();`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new Color(1, 1, 1, .55f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _content.Modulate = new Color(1, 1, 1, .55f)`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`IsQueuedForDeletion()`；返回值紧邻使用处：`BinaryExpressionSyntax: !IsInsideTree() || IsQueuedForDeletion()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_stage.AddChild(_pageEffect)`；返回值紧邻使用处：`ExpressionStatementSyntax: _stage.AddChild(_pageEffect);`
- `Godot.Node.CreateTween()`；输入表达式：`CreateTween()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CreateTween().SetParallel`
- `Godot.Node.IsInsideTree()`；输入表达式：`IsInsideTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInsideTree()`
- `Godot.Transform2D.AffineInverse()`；输入表达式：`_stage.GetGlobalTransform().AffineInverse()`；返回值紧邻使用处：`BinaryExpressionSyntax: _stage.GetGlobalTransform().AffineInverse() * _scroll.GlobalPosition`
- `Godot.Tween.Chain()`；输入表达式：`_pageTween.Chain()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _pageTween.Chain().TweenCallback`
- `Godot.Tween.Kill()`；输入表达式：`.Kill()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _pageTween?.Kill()`
- `Godot.Tween.SetEase(Godot.Tween.EaseType)`；输入表达式：`CreateTween().SetParallel().SetEase(Tween.EaseType.Out)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CreateTween().SetParallel().SetEase(Tween.EaseType.Out).SetTrans`
- `Godot.Tween.SetParallel(bool)`；输入表达式：`CreateTween().SetParallel()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CreateTween().SetParallel().SetEase`
- `Godot.Tween.SetTrans(Godot.Tween.TransitionType)`；输入表达式：`CreateTween().SetParallel().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Cubic)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _pageTween = CreateTween().SetParallel().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Cubic)`
- `Godot.Tween.TweenCallback(Godot.Callable)`；输入表达式：`_pageTween.Chain().TweenCallback(Callable.From(() => _pageEffect.Hide()))`；返回值紧邻使用处：`ExpressionStatementSyntax: _pageTween.Chain().TweenCallback(Callable.From(() => _pageEffect.Hide()));`
- `Godot.Tween.TweenMethod(Godot.Callable, Godot.Variant, Godot.Variant, double)`；输入表达式：`_pageTween.TweenMethod(Callable.From<float>(v => _pageEffect.Progress = v), 0f, 1f, .28)`；返回值紧邻使用处：`ExpressionStatementSyntax: _pageTween.TweenMethod(Callable.From<float>(v => _pageEffect.Progress = v), 0f, 1f, .28);`
- `Godot.Tween.TweenProperty(Godot.GodotObject, Godot.NodePath, Godot.Variant, double)`；输入表达式：`_pageTween.TweenProperty(_content, "modulate:a", 1f, .20)`；返回值紧邻使用处：`ExpressionStatementSyntax: _pageTween.TweenProperty(_content, "modulate:a", 1f, .20);`
- `NationalSpire.BroadcastTransition.BroadcastTransition()`；输入表达式：`new BroadcastTransition { MouseFilter = MouseFilterEnum.Ignore, ClipContents = true }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _pageEffect = new BroadcastTransition { MouseFilter = MouseFilterEnum.Ignore, ClipContents = true }`

**赋值（含属性/字段和局部值）：**

- `_content.Modulate` = `Colors.White`
- `_content.Modulate` = `new Color(1, 1, 1, .55f)`
- `_pageEffect.Position` = `_stage.GetGlobalTransform().AffineInverse() * _scroll.GlobalPosition`
- `_pageEffect.Progress` = `0`
- `_pageEffect.Progress` = `v`
- `_pageEffect.Size` = `_scroll.Size`
- `_pageEffect` = `new BroadcastTransition { MouseFilter = MouseFilterEnum.Ignore, ClipContents = true }`
- `_pageTween` = `CreateTween().SetParallel().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Cubic)`
- `_visualLocation` = `location`
- `ClipContents` = `true`
- `MouseFilter` = `MouseFilterEnum.Ignore`

<a id="symbol-15d48434171e"></a>

## `NationalSpire.CareerScreen.FilterButton(string, bool, System.Action, float) — private static Button FilterButton(string title, bool selected, Action action, float width)`

来源：源码第 194 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Groups()`](ConsumerPickerScreen.cs.md#symbol-e164aa9ee502)；[`NationalSpire.CareerScreen.AvatarWardrobe(NationalSpire.CareerData, Godot.VBoxContainer)`](CareerAvatars.cs.md#symbol-a00951e0b13d)；[`NationalSpire.CareerScreen.Community(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-75337b99e622)；[`NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`](ConsumerPickerScreen.cs.md#symbol-0f5d28176960)；[`NationalSpire.CareerScreen.ConsumerProducts(Godot.VBoxContainer, NationalSpire.CareerScreen.ConsumerChoice[], NationalSpire.CareerScreen.ConsumerEdit, System.Action)`](ConsumerPickerScreen.cs.md#symbol-e5ebf63e6d3e)；[`NationalSpire.CareerScreen.ConsumerRecipients(Godot.VBoxContainer, NationalSpire.CareerScreen.ConsumerEdit, bool, System.Action)`](ConsumerPickerScreen.cs.md#symbol-d76de74a5483)；[`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)；[`NationalSpire.CareerScreen.DevelopmentScreen(NationalSpire.CareerData)`](DevelopmentScreen.cs.md#symbol-2d48676d5e88)；[`NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-0cdff88b6131)；[`NationalSpire.CareerScreen.PeoplePicker(Godot.VBoxContainer, System.Collections.Generic.IReadOnlyList<NationalSpire.CareerPerson>, System.Collections.Generic.HashSet<string>, bool, System.Action, int)`](PeoplePickerScreen.cs.md#symbol-80a307ead785)；[`NationalSpire.CareerScreen.Profiles(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-70740adc3b48)

**调用：** [`NationalSpire.CareerScreen.Button(string, System.Action, float)`](CareerScreen.cs.md#symbol-716373f2517f)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.BaseButton.SetPressedNoSignal(bool)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Button(string, System.Action, float)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Ink`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.SetPressedNoSignal(bool)`；输入表达式：`button.SetPressedNoSignal(selected)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.SetPressedNoSignal(selected);`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride("font_pressed_color", CareerVisuals.Ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride("font_pressed_color", CareerVisuals.Ink);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("pressed", CareerVisuals.Box("28434c", "699396", 6, 14))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("pressed", CareerVisuals.Box("28434c", "699396", 6, 14));`
- `NationalSpire.CareerScreen.Button(string, System.Action, float)`；输入表达式：`Button(title, action, width)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Button(title, action, width)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("28434c", "699396", 6, 14)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("28434c", "699396", 6, 14)`

**赋值（含属性/字段和局部值）：**

- `button.ToggleMode` = `true`
- `button.TooltipText` = `selected ? "当前筛选：" + title : "切换到：" + title`

<a id="symbol-ddd68d13b687"></a>

## `NationalSpire.CareerScreen.Emphasize(Godot.Button) — private static void Emphasize(Button button)`

来源：源码第 203 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.Ceremony(NationalSpire.CareerData)`](CeremonyScreen.cs.md#symbol-4a515aec3125)；[`NationalSpire.CareerScreen.CeremonyInvitation(NationalSpire.CareerData)`](CeremonyScreen.cs.md#symbol-fe94e59081ff)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerScreen.RenderWeeklyDetail(NationalSpire.CareerData)`](WeeklyScreen.cs.md#symbol-b3f0ffc5fb7d)

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastButton.Primary`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Ink`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`button.AddThemeColorOverride(state, CareerVisuals.Ink)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeColorOverride(state, CareerVisuals.Ink);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("hover", CareerVisuals.Box("3b6269", "83a4a5", 5, 16))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("hover", CareerVisuals.Box("3b6269", "83a4a5", 5, 16));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("normal", CareerVisuals.Box("31545b", "668c91", 5, 16))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("normal", CareerVisuals.Box("31545b", "668c91", 5, 16));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("pressed", CareerVisuals.Box("24434b", "668c91", 5, 16))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("pressed", CareerVisuals.Box("24434b", "668c91", 5, 16));`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("24434b", "668c91", 5, 16)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("24434b", "668c91", 5, 16)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("31545b", "668c91", 5, 16)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("31545b", "668c91", 5, 16)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("3b6269", "83a4a5", 5, 16)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("3b6269", "83a4a5", 5, 16)`

**赋值（含属性/字段和局部值）：**

- `broadcast.Primary` = `true`

<a id="symbol-936e32073293"></a>

## `NationalSpire.CareerScreen.PlayerBanner(NationalSpire.CareerData, string) — private Control PlayerBanner(CareerData data, string id)`

来源：源码第 211 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PersonProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](ProfileScreen.cs.md#symbol-2d802d5a07b9)；[`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`](ProfileScreen.cs.md#symbol-ce70d1ef24b8)

**调用：** [`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-5207a1627331)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`](CareerAvatars.cs.md#symbol-9f2c4623a902)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`](ClubCoaching.cs.md#symbol-8b4ec414486e)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；[`NationalSpire.EsportsWorld.LicenseName(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-921c23662473)；`Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`int.ToString()`；`NationalSpire.BroadcastPanel.BroadcastPanel()`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarFrame.Color`；`NationalSpire.AvatarFrame.Grade`；`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.AvatarIdentity.Ascension`；`NationalSpire.AvatarIdentity.Description`；`NationalSpire.AvatarIdentity.Frame`；`NationalSpire.AvatarIdentity.Role`；`NationalSpire.BroadcastPanel.Accent`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.PlayerCard`；`NationalSpire.CareerData.Rating`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.Handle`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.Name`；`NationalSpire.CareerPerson.Rating`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Lime`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.LicenseName(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color(identity.Frame.Color)`；返回值紧邻使用处：`ArgumentSyntax: new Color(identity.Frame.Color)`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`rating.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: rating.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 26)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 26);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`words.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("172a3a", "426474", 8, 24))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("172a3a", "426474", 8, 24));`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`rating.AddChild(best)`；返回值紧邻使用处：`ExpressionStatementSyntax: rating.AddChild(best);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`rating.AddChild(Text("生涯评分", 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: rating.AddChild(Text("生涯评分", 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`rating.AddChild(Text("生涯最高通关", 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: rating.AddChild(Text("生涯最高通关", 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`rating.AddChild(Text((person?.Rating ?? data.Rating).ToString(), 38, CareerVisuals.Lime))`；返回值紧邻使用处：`ExpressionStatementSyntax: rating.AddChild(Text((person?.Rating ?? data.Rating).ToString(), 38, CareerVisuals.Lime));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(Avatar(data, id, 104, false))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(Avatar(data, id, 104, false));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(rating)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(rating);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(words)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(words);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`words.AddChild(Text("姓名  " + profile.Name, 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddChild(Text("姓名  " + profile.Name, 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`words.AddChild(Text((person?.Country ?? data.Esports.Country) + "   /   " + EsportsWorld.ClubName(data, person?.ClubId ?? data.Esports.ClubId), 17, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddChild(Text((person?.Country ?? data.Esports.Country) + "   /   " + EsportsWorld.ClubName(data, person?.ClubId ?? data.Esports.ClubId), 17, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`words.AddChild(Text((profile?.Role ?? EsportsWorld.LicenseName(data)) + (person != null && ClubCoaching.IsCoach(person) ? " · 俱乐部教练" : ""), 14, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddChild(Text((profile?.Role ?? EsportsWorld.LicenseName(data)) + (person != null && ClubCoaching.IsCoach(person) ? " · 俱乐部教练" : ""), 14, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`words.AddChild(Text(CareerEngine.DisplayName(data, id), 32, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddChild(Text(CareerEngine.DisplayName(data, id), 32, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`words.AddChild(Text(identity.Description, 14, new Color(identity.Frame.Color)))`；返回值紧邻使用处：`ExpressionStatementSyntax: words.AddChild(Text(identity.Description, 14, new Color(identity.Frame.Color)));`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { CustomMinimumSize = new Vector2(175, 0) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { CustomMinimumSize = new Vector2(175, 0) }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(175, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(175, 0)`
- `int.ToString()`；输入表达式：`(person?.Rating ?? data.Rating).ToString()`；返回值紧邻使用处：`ArgumentSyntax: (person?.Rating ?? data.Rating).ToString()`
- `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`AvatarHonors.ForPerson(data, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AvatarHonors.ForPerson(data, id)`
- `NationalSpire.BroadcastPanel.BroadcastPanel()`；输入表达式：`new BroadcastPanel { Accent = CareerVisuals.Lime, SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BroadcastPanel { Accent = CareerVisuals.Lime, SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, id)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.DisplayName(data, id)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Person(data, id)`
- `NationalSpire.CareerScreen.Avatar(NationalSpire.CareerData, string, int, bool, System.Action?)`；输入表达式：`Avatar(data, id, 104, false)`；返回值紧邻使用处：`ArgumentSyntax: Avatar(data, id, 104, false)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("生涯评分", 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("生涯评分", 14, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("生涯最高通关", 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("生涯最高通关", 14, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("姓名  " + profile.Name, 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("姓名  " + profile.Name, 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text((person?.Country ?? data.Esports.Country) + "   /   " + EsportsWorld.ClubName(data, person?.ClubId ?? data.Esports.ClubId), 17, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text((person?.Country ?? data.Esports.Country) + "   /   " + EsportsWorld.ClubName(data, person?.ClubId ?? data.Esports.ClubId), 17, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text((person?.Rating ?? data.Rating).ToString(), 38, CareerVisuals.Lime)`；返回值紧邻使用处：`ArgumentSyntax: Text((person?.Rating ?? data.Rating).ToString(), 38, CareerVisuals.Lime)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text((profile?.Role ?? EsportsWorld.LicenseName(data)) + (person != null && ClubCoaching.IsCoach(person) ? " · 俱乐部教练" : ""), 14, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text((profile?.Role ?? EsportsWorld.LicenseName(data)) + (person != null && ClubCoaching.IsCoach(person) ? " · 俱乐部教练" : ""), 14, CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(CareerEngine.DisplayName(data, id), 32, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(CareerEngine.DisplayName(data, id), 32, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(highest < 0 ? "暂无通关" : $"进阶 {highest}", 20, _gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(highest < 0 ? "暂无通关" : $"进阶 {highest}", 20, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(identity.Description, 14, new Color(identity.Frame.Color))`；返回值紧邻使用处：`ArgumentSyntax: Text(identity.Description, 14, new Color(identity.Frame.Color))`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("172a3a", "426474", 8, 24)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("172a3a", "426474", 8, 24)`
- `NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`；输入表达式：`ClubCoaching.IsCoach(person)`；返回值紧邻使用处：`BinaryExpressionSyntax: person != null && ClubCoaching.IsCoach(person)`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(data, person?.ClubId ?? data.Esports.ClubId)`；返回值紧邻使用处：`BinaryExpressionSyntax: (person?.Country ?? data.Esports.Country) + "   /   " + EsportsWorld.ClubName(data, person?.ClubId ?? data.Esports.ClubId)`
- `NationalSpire.EsportsWorld.LicenseName(NationalSpire.CareerData)`；输入表达式：`EsportsWorld.LicenseName(data)`；返回值紧邻使用处：`BinaryExpressionSyntax: profile?.Role ?? EsportsWorld.LicenseName(data)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`data.HumanIds.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: id == "player" || data.HumanIds.Contains(id)`

**赋值（含属性/字段和局部值）：**

- `Accent` = `CareerVisuals.Lime`
- `best.Name` = `"ProfileHighestClear"`
- `CustomMinimumSize` = `new Vector2(175, 0)`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-dc5a27245e42"></a>

## `NationalSpire.CareerScreen.Matchup(NationalSpire.CareerData, NationalSpire.CareerMatch) — private Control Matchup(CareerData data, CareerMatch match)`

来源：源码第 236 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)

**调用：** [`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`Side(bool)`](BroadcastVisuals.cs.md#symbol-f3d2df3d6c54)；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Lime`；`Side(bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(center)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(center);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(72, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: center.CustomMinimumSize = new Vector2(72, 0)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("VS", 36, CareerVisuals.Lime)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text("VS", 36, CareerVisuals.Lime)`
- `Side(bool)`；输入表达式：`Side(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: Side(false);`
- `Side(bool)`；输入表达式：`Side(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Side(true);`

**赋值（含属性/字段和局部值）：**

- `center.CustomMinimumSize` = `new Vector2(72, 0)`
- `center.HorizontalAlignment` = `HorizontalAlignment.Center`
- `center.SizeFlagsHorizontal` = `SizeFlags.ShrinkCenter`
- `center.VerticalAlignment` = `VerticalAlignment.Center`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-f3d2df3d6c54"></a>

## `Side(bool) — void Side(bool ours)`

来源：源码第 239 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Matchup(NationalSpire.CareerData, NationalSpire.CareerMatch)`](BroadcastVisuals.cs.md#symbol-dc5a27245e42)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerScreen.Card()`](CareerScreen.cs.md#symbol-1542c756f2eb)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.PersonLink(NationalSpire.CareerData, string, string, int)`](CareerAvatars.cs.md#symbol-89d5865e1272)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.GameBridge.Characters()`](GameBridge.cs.md#symbol-1233494dda40)；[`NationalSpire.ICareerSession.Opponents(NationalSpire.CareerMatch)`](CareerSession.cs.md#symbol-a688107298ab)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.SelectedCharacter`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Card()`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.PersonLink(NationalSpire.CareerData, string, string, int)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerTeamMember.Id`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.GameBridge.Characters()`；`NationalSpire.ICareerSession.Opponents(NationalSpire.CareerMatch)`；`NationalSpire.ICareerSession.Team`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(PersonLink(data, id, CareerEngine.DisplayName(data, id) + "   ↗", 54))`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(PersonLink(data, id, CareerEngine.DisplayName(data, id) + "   ↗", 54));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(Text((person?.Country ?? data.Esports.Country) + "   ·   " + character, 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(Text((person?.Country ?? data.Esports.Country) + "   ·   " + character, 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(Text($"{ids.Length} 人共同出战 · 按整队结果判定", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(Text($"{ids.Length} 人共同出战 · 按整队结果判定", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`column.AddChild(Text(ours ? "PLAYER    /    我方阵容" : "OPPONENT    /    对方阵容", 12, CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: column.AddChild(Text(ours ? "PLAYER    /    我方阵容" : "OPPONENT    /    对方阵容", 12, CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(panel);`
- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`.Title.GetFormattedText()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == character)?.Title.GetFormattedText()`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`c.Id.ToString()`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Id.ToString() == character`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.DisplayName(data, id) + "   ↗"`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Person(data, id)`
- `NationalSpire.CareerScreen.Card()`；输入表达式：`Card()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Card()`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(panel)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Inner(panel)`
- `NationalSpire.CareerScreen.PersonLink(NationalSpire.CareerData, string, string, int)`；输入表达式：`PersonLink(data, id, CareerEngine.DisplayName(data, id) + "   ↗", 54)`；返回值紧邻使用处：`ArgumentSyntax: PersonLink(data, id, CareerEngine.DisplayName(data, id) + "   ↗", 54)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text((person?.Country ?? data.Esports.Country) + "   ·   " + character, 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text((person?.Country ?? data.Esports.Country) + "   ·   " + character, 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"{ids.Length} 人共同出战 · 按整队结果判定", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"{ids.Length} 人共同出战 · 按整队结果判定", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(ours ? "PLAYER    /    我方阵容" : "OPPONENT    /    对方阵容", 12, CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Text(ours ? "PLAYER    /    我方阵容" : "OPPONENT    /    对方阵容", 12, CareerVisuals.Teal)`
- `NationalSpire.GameBridge.Characters()`；输入表达式：`GameBridge.Characters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameBridge.Characters().FirstOrDefault`
- `NationalSpire.ICareerSession.Opponents(NationalSpire.CareerMatch)`；输入表达式：`_multiplayer.Opponents(match)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _multiplayer.Opponents(match).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == character)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == character)?.Title.GetFormattedText()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`_multiplayer.Team.Select(m => m.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _multiplayer.Team.Select(m => m.Id).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_multiplayer.Opponents(match).ToArray()`；返回值紧邻使用处：`ConditionalExpressionSyntax: ours ? _multiplayer.Team.Select(m => m.Id).ToArray() : _multiplayer.Opponents(match).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_multiplayer.Team.Select(m => m.Id).ToArray()`；返回值紧邻使用处：`ConditionalExpressionSyntax: ours ? _multiplayer.Team.Select(m => m.Id).ToArray() : _multiplayer.Opponents(match).ToArray()`

**赋值（含属性/字段和局部值）：**

- `character` = `GameBridge.Characters().FirstOrDefault(c => c.Id.ToString() == character)?.Title.GetFormattedText() ?? character`
