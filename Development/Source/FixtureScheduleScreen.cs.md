# FixtureScheduleScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`D4184B6F5291AD1DA1DC413C86EA1EC9141C2B288DE942B5DA768C46D009C1EA`。来源：[源码](../../FixtureScheduleScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.BracketColumns`、`NationalSpire.FixtureTimelineRow`、`NationalSpire.CareerScreen`、`NationalSpire.CareerScreen.FixtureEntry`、`NationalSpire.ZoomableBracketScroll`。

字段、事件及初始值（源码原样）：

```csharp
private readonly List<List<Control>> _slots=[];
private readonly HashSet<Control> _advanced = [];
private Control? _invitation;
private Tween? _fade;
private float _light;
private const int FixtureActionWidth = 120, FixtureRowGap = 16, FixtureEndInset = 5;
private int _fixtureLimit = 75;
private int _fixtureSeason;
private Predicate<FixtureEntry>? _fixtureFocus;
private float _bracketZoom=1;
internal Action<float,Vector2>? ZoomStep;
private bool _held, _dragged;
private Vector2 _origin, _offset;
private Button? _card;
```

<a id="symbol-0b92c59df100"></a>

## `NationalSpire.BracketColumns.ConnectInvitation(Godot.Control) — public void ConnectInvitation(Control invitation)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.BracketColumns._invitation`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_invitation` = `invitation`

<a id="symbol-fd2e6d82e689"></a>

## `NationalSpire.BracketColumns.MarkAdvanced(Godot.Control) — public void MarkAdvanced(Control slot)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)

**调用：** `System.Collections.Generic.HashSet<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.BracketColumns._advanced`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`_advanced.Add(slot)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => _advanced.Add(slot)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-de909d9445cb"></a>

## `NationalSpire.BracketColumns.AddSlot(int, Godot.Control) — public void AddSlot(int round,Control slot)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)

**调用：** `System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.BracketColumns._slots`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`_slots.Add([])`；返回值紧邻使用处：`ExpressionStatementSyntax: _slots.Add([]);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`_slots[round-1].Add(slot)`；返回值紧邻使用处：`ExpressionStatementSyntax: _slots[round-1].Add(slot);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3c7656b73c81"></a>

## `NationalSpire.BracketColumns._Notification(int) — public override void _Notification(int what)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.GodotObject.CallDeferred(Godot.StringName, params Godot.Variant[])`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.CallDeferred(Godot.StringName, params Godot.Variant[])`；输入表达式：`CallDeferred(CanvasItem.MethodName.QueueRedraw)`；返回值紧邻使用处：`ExpressionStatementSyntax: CallDeferred(CanvasItem.MethodName.QueueRedraw);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8dab0abe311b"></a>

## `NationalSpire.BracketColumns._Draw() — public override void _Draw()`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawDashedLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, float, bool, bool)`；`Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；`Godot.CanvasItem.GetGlobalTransform()`；`Godot.Color.Color(string)`；`Godot.Control.GetGlobalRect()`；`Godot.Rect2.GetCenter()`；`Godot.Transform2D.AffineInverse()`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.BracketColumns._advanced`；`NationalSpire.BracketColumns._invitation`；`NationalSpire.BracketColumns._slots`；`NationalSpire.CareerVisuals.Gold`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawDashedLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, float, bool, bool)`；输入表达式：`DrawDashedLine(a,new(b.X,a.Y),CareerVisuals.Gold,1.5f,5)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawDashedLine(a,new(b.X,a.Y),CareerVisuals.Gold,1.5f,5);`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([a,new(mid,a.Y),new(mid,b.Y),b],_advanced.Contains(_slots[round-1][i]) ? new Color("80bdb599") : new Color("71899688"),1.5f,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([a,new(mid,a.Y),new(mid,b.Y),b],_advanced.Contains(_slots[round-1][i]) ? new Color("80bdb599") : new Color("71899688"),1.5f,true);`
- `Godot.CanvasItem.GetGlobalTransform()`；输入表达式：`GetGlobalTransform()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetGlobalTransform().AffineInverse`
- `Godot.Color.Color(string)`；输入表达式：`new Color("71899688")`；返回值紧邻使用处：`ConditionalExpressionSyntax: _advanced.Contains(_slots[round-1][i]) ? new Color("80bdb599") : new Color("71899688")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("80bdb599")`；返回值紧邻使用处：`ConditionalExpressionSyntax: _advanced.Contains(_slots[round-1][i]) ? new Color("80bdb599") : new Color("71899688")`
- `Godot.Control.GetGlobalRect()`；输入表达式：`_invitation.GetGlobalRect()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =_invitation.GetGlobalRect()`
- `Godot.Control.GetGlobalRect()`；输入表达式：`_slots[round-1][i].GetGlobalRect()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =_slots[round-1][i].GetGlobalRect()`
- `Godot.Control.GetGlobalRect()`；输入表达式：`_slots[round][i/2].GetGlobalRect()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =_slots[round][i/2].GetGlobalRect()`
- `Godot.Control.GetGlobalRect()`；输入表达式：`final.GetGlobalRect()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =final.GetGlobalRect()`
- `Godot.Rect2.GetCenter()`；输入表达式：`dest.GetCenter()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: dest.GetCenter().Y`
- `Godot.Rect2.GetCenter()`；输入表达式：`from.GetCenter()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: from.GetCenter().Y`
- `Godot.Rect2.GetCenter()`；输入表达式：`src.GetCenter()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: src.GetCenter().Y`
- `Godot.Rect2.GetCenter()`；输入表达式：`to.GetCenter()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: to.GetCenter().Y`
- `Godot.Transform2D.AffineInverse()`；输入表达式：`GetGlobalTransform().AffineInverse()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =GetGlobalTransform().AffineInverse()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(dest.Position.X,dest.GetCenter().Y)`；返回值紧邻使用处：`BinaryExpressionSyntax: inverse*new Vector2(dest.Position.X,dest.GetCenter().Y)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(from.End.X,from.GetCenter().Y)`；返回值紧邻使用处：`BinaryExpressionSyntax: inverse*new Vector2(from.End.X,from.GetCenter().Y)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(src.End.X,src.GetCenter().Y)`；返回值紧邻使用处：`BinaryExpressionSyntax: inverse*new Vector2(src.End.X,src.GetCenter().Y)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(to.Position.X,to.GetCenter().Y)`；返回值紧邻使用处：`BinaryExpressionSyntax: inverse*new Vector2(to.Position.X,to.GetCenter().Y)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(b.X,a.Y)`；返回值紧邻使用处：`ArgumentSyntax: new(b.X,a.Y)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(mid,a.Y)`；返回值紧邻使用处：`ExpressionElementSyntax: new(mid,a.Y)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(mid,b.Y)`；返回值紧邻使用处：`ExpressionElementSyntax: new(mid,b.Y)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_advanced.Contains(_slots[round-1][i])`；返回值紧邻使用处：`ConditionalExpressionSyntax: _advanced.Contains(_slots[round-1][i]) ? new Color("80bdb599") : new Color("71899688")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`.FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _slots.LastOrDefault()?.FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`_slots.LastOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _slots.LastOrDefault()?.FirstOrDefault()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-65468a451caf"></a>

## `NationalSpire.FixtureTimelineRow.FirstOfDay — public bool FirstOfDay`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b906161359cd"></a>

## `NationalSpire.FixtureTimelineRow.Highlight(bool) — public void Highlight(bool active)`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddFixtureRow(NationalSpire.CareerData, NationalSpire.CareerScreen.FixtureEntry, Godot.VBoxContainer, bool)`](FixtureScheduleScreen.cs.md#symbol-237327497b3f)

**调用：** `Godot.Callable.From<T0>(System.Action<T0>)`；`Godot.CanvasItem.QueueRedraw()`；`Godot.Node.CreateTween()`；`Godot.Tween.Kill()`；`Godot.Tween.SetEase(Godot.Tween.EaseType)`；`Godot.Tween.SetTrans(Godot.Tween.TransitionType)`；`Godot.Tween.TweenMethod(Godot.Callable, Godot.Variant, Godot.Variant, double)`

**字段、属性、事件及方法组引用：** `NationalSpire.FixtureTimelineRow._fade`；`NationalSpire.FixtureTimelineRow._light`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.From<T0>(System.Action<T0>)`；输入表达式：`Callable.From<float>(value => { _light = value; QueueRedraw(); })`；返回值紧邻使用处：`ArgumentSyntax: Callable.From<float>(value => { _light = value; QueueRedraw(); })`
- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`
- `Godot.Node.CreateTween()`；输入表达式：`CreateTween()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CreateTween().SetEase`
- `Godot.Tween.Kill()`；输入表达式：`.Kill()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _fade?.Kill()`
- `Godot.Tween.SetEase(Godot.Tween.EaseType)`；输入表达式：`CreateTween().SetEase(Tween.EaseType.Out)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CreateTween().SetEase(Tween.EaseType.Out).SetTrans`
- `Godot.Tween.SetTrans(Godot.Tween.TransitionType)`；输入表达式：`CreateTween().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Cubic)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _fade = CreateTween().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Cubic)`
- `Godot.Tween.TweenMethod(Godot.Callable, Godot.Variant, Godot.Variant, double)`；输入表达式：`_fade.TweenMethod(Callable.From<float>(value => { _light = value; QueueRedraw(); }), _light, active ? 1f : 0f, .16)`；返回值紧邻使用处：`ExpressionStatementSyntax: _fade.TweenMethod(Callable.From<float>(value => { _light = value; QueueRedraw(); }), _light, active ? 1f : 0f, .16);`

**赋值（含属性/字段和局部值）：**

- `_fade` = `CreateTween().SetEase(Tween.EaseType.Out).SetTrans(Tween.TransitionType.Cubic)`
- `_light` = `value`

<a id="symbol-d2a044fc4dfd"></a>

## `NationalSpire.FixtureTimelineRow._Draw() — public override void _Draw()`

来源：源码第 53 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；`Godot.Color.Color(Godot.Color, float)`；`Godot.Color.Color(string)`；`Godot.Rect2.Rect2(float, float, float, float)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Teal`；`NationalSpire.FixtureTimelineRow._light`；`NationalSpire.FixtureTimelineRow.FirstOfDay`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；输入表达式：`DrawCircle(new(13,Size.Y/2),4,new Color("96c9d4"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(new(13,Size.Y/2),4,new Color("96c9d4"));`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new(0,Size.Y-2),new(Size.X*_light,Size.Y-2),new Color(CareerVisuals.Teal,_light),2,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new(0,Size.Y-2),new(Size.X*_light,Size.Y-2),new Color(CareerVisuals.Teal,_light),2,true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new(13,0),new(13,Size.Y),new Color("68909b80"),1,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new(13,0),new(13,Size.Y),new Color("68909b80"),1,true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new(156,Size.Y-1),new(Size.X-10,Size.Y-1),new Color("45627188"),1)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new(156,Size.Y-1),new(Size.X-10,Size.Y-1),new Color("45627188"),1);`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；输入表达式：`DrawRect(new Rect2(0,1,Size.X,Size.Y-2),new Color(new Color("28495a"),.86f*_light))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(new Rect2(0,1,Size.X,Size.Y-2),new Color(new Color("28495a"),.86f*_light));`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(CareerVisuals.Teal,_light)`；返回值紧邻使用处：`ArgumentSyntax: new Color(CareerVisuals.Teal,_light)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(new Color("28495a"),.86f*_light)`；返回值紧邻使用处：`ArgumentSyntax: new Color(new Color("28495a"),.86f*_light)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("28495a")`；返回值紧邻使用处：`ArgumentSyntax: new Color("28495a")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("45627188")`；返回值紧邻使用处：`ArgumentSyntax: new Color("45627188")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("68909b80")`；返回值紧邻使用处：`ArgumentSyntax: new Color("68909b80")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("96c9d4")`；返回值紧邻使用处：`ArgumentSyntax: new Color("96c9d4")`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new Rect2(0,1,Size.X,Size.Y-2)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(0,1,Size.X,Size.Y-2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,Size.Y-2)`；返回值紧邻使用处：`ArgumentSyntax: new(0,Size.Y-2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(13,0)`；返回值紧邻使用处：`ArgumentSyntax: new(13,0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(13,Size.Y)`；返回值紧邻使用处：`ArgumentSyntax: new(13,Size.Y)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(13,Size.Y/2)`；返回值紧邻使用处：`ArgumentSyntax: new(13,Size.Y/2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(156,Size.Y-1)`；返回值紧邻使用处：`ArgumentSyntax: new(156,Size.Y-1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Size.X-10,Size.Y-1)`；返回值紧邻使用处：`ArgumentSyntax: new(Size.X-10,Size.Y-1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(Size.X*_light,Size.Y-2)`；返回值紧邻使用处：`ArgumentSyntax: new(Size.X*_light,Size.Y-2)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0c16c775e891"></a>

## `NationalSpire.FixtureTimelineRow._ExitTree() — public override void _ExitTree()`

来源：源码第 62 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Tween.Kill()`

**字段、属性、事件及方法组引用：** `NationalSpire.FixtureTimelineRow._fade`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Tween.Kill()`；输入表达式：`.Kill()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _fade?.Kill()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-74a2aaad7ff4"></a>

## `NationalSpire.CareerScreen.IsInternationalCup(NationalSpire.WorldCompetition) — private static bool IsInternationalCup(WorldCompetition cup)`

来源：源码第 69 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.FixtureSchedule(NationalSpire.CareerData)`](FixtureScheduleScreen.cs.md#symbol-e95df6046805)；[`NationalSpire.CareerScreen.OpenFixtureFor(NationalSpire.CareerData, int, NationalSpire.WorldCompetition?, NationalSpire.CareerMatch?)`](FixtureScheduleScreen.cs.md#symbol-b6e54268cac8)；[`NationalSpire.CareerScreen.World(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-ce5a79e2aa5c)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.WorldCompetition.Country`；`NationalSpire.WorldCompetition.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b367c62d489f"></a>

## `NationalSpire.CareerScreen.OpenMatchFixture(NationalSpire.CareerData, NationalSpire.CareerMatch) — private void OpenMatchFixture(CareerData data, CareerMatch match)`

来源：源码第 74 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)

**调用：** [`NationalSpire.CareerScreen.OpenFixtureFor(NationalSpire.CareerData, int, NationalSpire.WorldCompetition?, NationalSpire.CareerMatch?)`](FixtureScheduleScreen.cs.md#symbol-b6e54268cac8)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerMatch.CompetitionId`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerScreen.OpenFixtureFor(NationalSpire.CareerData, int, NationalSpire.WorldCompetition?, NationalSpire.CareerMatch?)`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.WorldCompetition.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.OpenFixtureFor(NationalSpire.CareerData, int, NationalSpire.WorldCompetition?, NationalSpire.CareerMatch?)`；输入表达式：`OpenFixtureFor(data, match.Day, cup, match)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenFixtureFor(data, match.Day, cup, match);`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Esports.Competitions.FirstOrDefault(c => c.Id == match.CompetitionId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Esports.Competitions.FirstOrDefault(c => c.Id == match.CompetitionId)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b6e54268cac8"></a>

## `NationalSpire.CareerScreen.OpenFixtureFor(NationalSpire.CareerData, int, NationalSpire.WorldCompetition?, NationalSpire.CareerMatch?) — private void OpenFixtureFor(CareerData d, int day, WorldCompetition? cup, CareerMatch? match = null)`

来源：源码第 80 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.OpenMatchFixture(NationalSpire.CareerData, NationalSpire.CareerMatch)`](FixtureScheduleScreen.cs.md#symbol-b367c62d489f)

**调用：** [`NationalSpire.CareerScreen.IsInternationalCup(NationalSpire.WorldCompetition)`](FixtureScheduleScreen.cs.md#symbol-74a2aaad7ff4)；[`NationalSpire.CareerScreen.Visit(System.Action)`](CareerNavigation.cs.md#symbol-d49752019228)；[`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`](EsportsWorld.cs.md#symbol-4b9f3e1bf70a)；[`NationalSpire.GameCalendar.Season(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-c5c99167e359)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerMatch.FixtureId`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CareerMatch.Registered`；`NationalSpire.CareerScreen._fixtureFocus`；`NationalSpire.CareerScreen._fixtureInternational`；`NationalSpire.CareerScreen._fixtureKind`；`NationalSpire.CareerScreen._fixtureLimit`；`NationalSpire.CareerScreen._fixtureRegion`；`NationalSpire.CareerScreen._fixtureScope`；`NationalSpire.CareerScreen._fixtureSeason`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen.FixtureEntry.Cup`；`NationalSpire.CareerScreen.FixtureEntry.Day`；`NationalSpire.CareerScreen.FixtureEntry.Match`；`NationalSpire.CareerScreen.IsInternationalCup(NationalSpire.WorldCompetition)`；`NationalSpire.CareerScreen.MyFixtures`；`NationalSpire.CareerScreen.Visit(System.Action)`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.GameCalendar.Season(NationalSpire.CareerData, int)`；`NationalSpire.WorldCompetition.Country`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Season`；`NationalSpire.WorldFixture.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.IsInternationalCup(NationalSpire.WorldCompetition)`；输入表达式：`IsInternationalCup(cup)`；返回值紧邻使用处：`BinaryExpressionSyntax: cup!=null && IsInternationalCup(cup)`
- `NationalSpire.CareerScreen.Visit(System.Action)`；输入表达式：`Visit(() =>          {              _tab="赛程"; _fixtureLimit=75;              int season=cup?.Season ?? GameCalendar.Season(d,day);              _fixtureSeason=season==d.Season ? 0 : season;              if (cup!=null && IsInternationalCup(cup))              {                  _fixtureScope="国际赛事"; _fixtureInternational=cup.Id; return;              }              bool abroad=cup!=null && cup.Country!=d.Esports.Country;              _fixtureScope=abroad ? "其他地区" : "国内赛事"; _fixtureRegion=abroad ? cup!.Country : "";              _fixtureKind=match==null || cup!=null && cup.Fixtures.Any(f=>f.Id==match.FixtureId) ? cup!.Kind : match.Kind;              if (match==null || !match.Registered && EsportsWorld.EntryReason(d,match)!=null) MyFixtures=false;              _fixtureFocus=match!=null ? e=>e.Match?.Id==match.Id : e=>e.Cup?.Id==cup!.Id && e.Day==day;          })`；返回值紧邻使用处：`ExpressionStatementSyntax: Visit(() =>          {              _tab="赛程"; _fixtureLimit=75;              int season=cup?.Season ?? GameCalendar.Season(d,day);              _fixtureSeason=season==d.Season ? 0 : season;              if (cup!=null && IsInternationalCup(cup))              {                  _fixtureScope="国际赛事"; _fixtureInternational=cup.Id; return;              }              bool abroad=cup!=null && cup.Country!=d.Esports.Country;              _fixtureScope=abroad ? "其他地区" : "国内赛事"; _fixtureRegion=abroad ? cup!.Country : "";              _fixtureKind=match==null || cup!=null && cup.Fixtures.Any(f=>f.Id==match.FixtureId) ? cup!.Kind : match.Kind;              if (match==null || !match.Registered && EsportsWorld.EntryReason(d,match)!=null) MyFixtures=false;              _fixtureFocus=match!=null ? e=>e.Match?.Id==match.Id : e=>e.Cup?.Id==cup!.Id && e.Day==day;          });`
- `NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`EsportsWorld.EntryReason(d,match)`；返回值紧邻使用处：`BinaryExpressionSyntax: EsportsWorld.EntryReason(d,match)!=null`
- `NationalSpire.GameCalendar.Season(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Season(d,day)`；返回值紧邻使用处：`BinaryExpressionSyntax: cup?.Season ?? GameCalendar.Season(d,day)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`cup.Fixtures.Any(f=>f.Id==match.FixtureId)`；返回值紧邻使用处：`BinaryExpressionSyntax: cup!=null && cup.Fixtures.Any(f=>f.Id==match.FixtureId)`

**赋值（含属性/字段和局部值）：**

- `_fixtureFocus` = `match!=null ? e=>e.Match?.Id==match.Id : e=>e.Cup?.Id==cup!.Id && e.Day==day`
- `_fixtureInternational` = `cup.Id`
- `_fixtureKind` = `match==null || cup!=null && cup.Fixtures.Any(f=>f.Id==match.FixtureId) ? cup!.Kind : match.Kind`
- `_fixtureLimit` = `75`
- `_fixtureRegion` = `abroad ? cup!.Country : ""`
- `_fixtureScope` = `"国际赛事"`
- `_fixtureScope` = `abroad ? "其他地区" : "国内赛事"`
- `_fixtureSeason` = `season==d.Season ? 0 : season`
- `_tab` = `"赛程"`
- `MyFixtures` = `false`

<a id="symbol-e95df6046805"></a>

## `NationalSpire.CareerScreen.FixtureSchedule(NationalSpire.CareerData) — private void FixtureSchedule(CareerData d)`

来源：源码第 99 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)

**调用：** [`AddScheduled(string)`](FixtureScheduleScreen.cs.md#symbol-e74cd7a835f7)；[`InScope(string, NationalSpire.CareerMatch?)`](FixtureScheduleScreen.cs.md#symbol-9a5659850a62)；[`NationalSpire.CareerScreen.AddFixtureRow(NationalSpire.CareerData, NationalSpire.CareerScreen.FixtureEntry, Godot.VBoxContainer, bool)`](FixtureScheduleScreen.cs.md#symbol-237327497b3f)；[`NationalSpire.CareerScreen.Baseline(Godot.Control)`](DashboardControls.cs.md#symbol-d7fcbfd7f416)；[`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`](DashboardControls.cs.md#symbol-0374e90f1c3f)；[`NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`](CareerDashboard.cs.md#symbol-22831701f7f1)；[`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.DashboardSwitch(string, bool, System.Action<bool>, int, int)`](DashboardControls.cs.md#symbol-f6780ccb3f84)；[`NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`](DashboardControls.cs.md#symbol-d6b849a02619)；[`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`](DashboardControls.cs.md#symbol-23c9e2f4b76f)；[`NationalSpire.CareerScreen.Inset(int, int)`](DashboardControls.cs.md#symbol-ebb2fedbb4fc)；[`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)；[`NationalSpire.CareerScreen.IsInternationalCup(NationalSpire.WorldCompetition)`](FixtureScheduleScreen.cs.md#symbol-74a2aaad7ff4)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.TabStrip(Godot.Container, int, bool, bool)`](CareerDashboard.cs.md#symbol-5eacabf68317)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`](DashboardControls.cs.md#symbol-d545a37403bd)；[`NationalSpire.CareerScreen.UnderlineTab(string, System.Action, bool, int, int, bool, bool)`](CareerDashboard.cs.md#symbol-fd46a77c3667)；[`NationalSpire.CircuitWorld.HasWorldFinal(int)`](CircuitWorld.cs.md#symbol-cfb6478eecde)；[`NationalSpire.CircuitWorld.InternationalTeamCup(int)`](CircuitWorld.cs.md#symbol-52fde6b9045a)；[`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`](EsportsWorld.cs.md#symbol-4b9f3e1bf70a)；[`NationalSpire.EsportsWorld.StageName(string)`](EsportsWorld.cs.md#symbol-c0445cae874d)；[`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-12bdfe5d4265)；[`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-ee7b01d76b23)；[`Picker(string, int)`](FixtureScheduleScreen.cs.md#symbol-1ce84475b6f2)；`Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.Control()`；`Godot.Control.GetCombinedMinimumSize()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.SetDeferred(Godot.StringName, Godot.Variant)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Mathf.RoundToInt(float)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChild<T>(int, bool)`；`Godot.Node.GetChildren(bool)`；`Godot.Node.IsInsideTree()`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.Select(int)`；`Godot.ScrollContainer.EnsureControlVisible(Godot.Control)`；`Godot.ScrollContainer.GetVScrollBar()`；`Godot.ScrollContainer.ScrollContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.CareerScreen.FixtureEntry.FixtureEntry(int, string, string, string, NationalSpire.CareerMatch?, NationalSpire.WorldCompetition?, NationalSpire.WorldFixture?)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.HashSet<T>.HashSet()`；`System.Collections.Generic.IEnumerable<T>.Order<T>()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Last<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Prepend<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToLookup<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；`System.Collections.Generic.List<T>.IndexOf(T)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.IEnumerable.OfType<TResult>()`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Math.Max(int, int)`；`System.Predicate<T>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `AddScheduled(string)`；`InScope(string, NationalSpire.CareerMatch?)`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerMatch.CompetitionId`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerMatch.Event`；`NationalSpire.CareerMatch.FixtureId`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CareerMatch.Registered`；`NationalSpire.CareerMatch.Status`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._fixtureFocus`；`NationalSpire.CareerScreen._fixtureInternational`；`NationalSpire.CareerScreen._fixtureKind`；`NationalSpire.CareerScreen._fixtureLimit`；`NationalSpire.CareerScreen._fixtureRegion`；`NationalSpire.CareerScreen._fixtureScope`；`NationalSpire.CareerScreen._fixtureSeason`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.AddFixtureRow(NationalSpire.CareerData, NationalSpire.CareerScreen.FixtureEntry, Godot.VBoxContainer, bool)`；`NationalSpire.CareerScreen.Baseline(Godot.Control)`；`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；`NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.DashboardSwitch(string, bool, System.Action<bool>, int, int)`；`NationalSpire.CareerScreen.FixtureActionWidth`；`NationalSpire.CareerScreen.FixtureEndInset`；`NationalSpire.CareerScreen.FixtureEntry.Country`；`NationalSpire.CareerScreen.FixtureEntry.Day`；`NationalSpire.CareerScreen.FixtureEntry.Kind`；`NationalSpire.CareerScreen.FixtureEntry.Match`；`NationalSpire.CareerScreen.FixtureEntry.Title`；`NationalSpire.CareerScreen.FixtureRowGap`；`NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；`NationalSpire.CareerScreen.Inset(int, int)`；`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`；`NationalSpire.CareerScreen.IsInternationalCup(NationalSpire.WorldCompetition)`；`NationalSpire.CareerScreen.MyFixtures`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.TabStrip(Godot.Container, int, bool, bool)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`；`NationalSpire.CareerScreen.UnderlineTab(string, System.Action, bool, int, int, bool, bool)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.CircuitWorld.HasWorldFinal(int)`；`NationalSpire.CircuitWorld.InternationalTeamCup(int)`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.EsportsWorld.StageName(string)`；`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；`NationalSpire.WorldCompetition.Country`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Modern`；`NationalSpire.WorldCompetition.Name`；`NationalSpire.WorldCompetition.Season`；`NationalSpire.WorldFixture.Day`；`NationalSpire.WorldFixture.Id`；`Picker(string, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `AddScheduled(string)`；输入表达式：`AddScheduled("worldfinal")`；返回值紧邻使用处：`ExpressionStatementSyntax: AddScheduled("worldfinal");`
- `AddScheduled(string)`；输入表达式：`AddScheduled(CircuitWorld.InternationalTeamCup(d.Season))`；返回值紧邻使用处：`ExpressionStatementSyntax: AddScheduled(CircuitWorld.InternationalTeamCup(d.Season));`
- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(()=>{ if (IsInstanceValid(target) && target.IsInsideTree()) scroll.EnsureControlVisible(target); }).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(()=>{ if (IsInstanceValid(target) && target.IsInsideTree()) scroll.EnsureControlVisible(target); }).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(()=>{ if (IsInstanceValid(target) && target.IsInsideTree()) scroll.EnsureControlVisible(target); })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(()=>{ if (IsInstanceValid(target) && target.IsInsideTree()) scroll.EnsureControlVisible(target); }).CallDeferred`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`pick.AddThemeColorOverride("font_color", CareerVisuals.Teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: pick.AddThemeColorOverride("font_color", CareerVisuals.Teal);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`_content.AddThemeConstantOverride("separation",13)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddThemeConstantOverride("separation",13);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`filterBand.AddThemeConstantOverride("margin_right", FixtureRowGap + FixtureEndInset + Mathf.RoundToInt(scroll.GetVScrollBar().GetCombinedMinimumSize().X))`；返回值紧邻使用处：`ExpressionStatementSyntax: filterBand.AddThemeConstantOverride("margin_right", FixtureRowGap + FixtureEndInset + Mathf.RoundToInt(scroll.GetVScrollBar().GetCombinedMinimumSize().X));`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`filters.AddThemeConstantOverride("separation",12)`；返回值紧邻使用处：`ExpressionStatementSyntax: filters.AddThemeConstantOverride("separation",12);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`picks.AddThemeConstantOverride("separation", 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: picks.AddThemeConstantOverride("separation", 10);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`timeline.AddThemeConstantOverride("separation",0)`；返回值紧邻使用处：`ExpressionStatementSyntax: timeline.AddThemeConstantOverride("separation",0);`
- `Godot.Control.Control()`；输入表达式：`new Control {SizeFlagsHorizontal=SizeFlags.ExpandFill}`；返回值紧邻使用处：`ArgumentSyntax: new Control {SizeFlagsHorizontal=SizeFlags.ExpandFill}`
- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`scroll.GetVScrollBar().GetCombinedMinimumSize()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: scroll.GetVScrollBar().GetCombinedMinimumSize().X`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(target)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(target) && target.IsInsideTree()`
- `Godot.GodotObject.SetDeferred(Godot.StringName, Godot.Variant)`；输入表达式：`next.SetDeferred(ScrollContainer.PropertyName.ScrollVertical,y)`；返回值紧邻使用处：`ExpressionStatementSyntax: next.SetDeferred(ScrollContainer.PropertyName.ScrollVertical,y);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { CustomMinimumSize = new(0, 52) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { CustomMinimumSize = new(0, 52) }`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer()`
- `Godot.Mathf.RoundToInt(float)`；输入表达式：`Mathf.RoundToInt(scroll.GetVScrollBar().GetCombinedMinimumSize().X)`；返回值紧邻使用处：`BinaryExpressionSyntax: FixtureRowGap + FixtureEndInset + Mathf.RoundToInt(scroll.GetVScrollBar().GetCombinedMinimumSize().X)`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(filterBand)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(filterBand);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(picks)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(picks);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("本赛季的国际赛事签表尚未公布。",18,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("本赛季的国际赛事签表尚未公布。",18,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(Text("当前筛选下暂无赛事。",18,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(Text("当前筛选下暂无赛事。",18,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`filterBand.AddChild(filters)`；返回值紧邻使用处：`ExpressionStatementSyntax: filterBand.AddChild(filters);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`filters.AddChild(edition)`；返回值紧邻使用处：`ExpressionStatementSyntax: filters.AddChild(edition);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`filters.AddChild(filterTitle)`；返回值紧邻使用处：`ExpressionStatementSyntax: filters.AddChild(filterTitle);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`filters.AddChild(Glyph("list-filter",19,CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: filters.AddChild(Glyph("list-filter",19,CareerVisuals.Teal));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`filters.AddChild(mine)`；返回值紧邻使用处：`ExpressionStatementSyntax: filters.AddChild(mine);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`filters.AddChild(new Control {SizeFlagsHorizontal=SizeFlags.ExpandFill})`；返回值紧邻使用处：`ExpressionStatementSyntax: filters.AddChild(new Control {SizeFlagsHorizontal=SizeFlags.ExpandFill});`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`filters.AddChild(regionTitle)`；返回值紧邻使用处：`ExpressionStatementSyntax: filters.AddChild(regionTitle);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`filters.AddChild(TextLink("返回当前赛季",()=>{_fixtureSeason=0;_fixtureLimit=75;Render();},15,underline:true))`；返回值紧邻使用处：`ExpressionStatementSyntax: filters.AddChild(TextLink("返回当前赛季",()=>{_fixtureSeason=0;_fixtureLimit=75;Render();},15,underline:true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`picks.AddChild(edition)`；返回值紧邻使用处：`ExpressionStatementSyntax: picks.AddChild(edition);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`picks.AddChild(pick)`；返回值紧邻使用处：`ExpressionStatementSyntax: picks.AddChild(pick);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`picks.AddChild(TextLink("返回当前赛季", () => { _fixtureInternational = ""; Render(); }, 16, underline: true))`；返回值紧邻使用处：`ExpressionStatementSyntax: picks.AddChild(TextLink("返回当前赛季", () => { _fixtureInternational = ""; Render(); }, 16, underline: true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(timeline)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(timeline);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`tabs.AddChild(UnderlineTab(scope,()=>{ _fixtureScope=scope; _fixtureKind=""; _fixtureSeason=0; _fixtureLimit=75; Render(); }, _fixtureScope==scope))`；返回值紧邻使用处：`ExpressionStatementSyntax: tabs.AddChild(UnderlineTab(scope,()=>{ _fixtureScope=scope; _fixtureKind=""; _fixtureSeason=0; _fixtureLimit=75; Render(); }, _fixtureScope==scope));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`timeline.AddChild(CaptionButton("显示更多比赛",()=>{int y=scroll.ScrollVertical;_fixtureLimit+=75; Render();var next=_content.GetChildren().OfType<ScrollContainer>().Last();next.SetDeferred(ScrollContainer.PropertyName.ScrollVertical,y);}))`；返回值紧邻使用处：`ExpressionStatementSyntax: timeline.AddChild(CaptionButton("显示更多比赛",()=>{int y=scroll.ScrollVertical;_fixtureLimit+=75; Render();var next=_content.GetChildren().OfType<ScrollContainer>().Last();next.SetDeferred(ScrollContainer.PropertyName.ScrollVertical,y);}));`
- `Godot.Node.GetChild<T>(int, bool)`；输入表达式：`timeline.GetChild<Control>(-1)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =timeline.GetChild<Control>(-1)`
- `Godot.Node.GetChildren(bool)`；输入表达式：`_content.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _content.GetChildren().OfType<ScrollContainer>`
- `Godot.Node.IsInsideTree()`；输入表达式：`target.IsInsideTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(target) && target.IsInsideTree()`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`region.AddItem(country.Length==0 ? "全部地区" : country)`；返回值紧邻使用处：`ExpressionStatementSyntax: region.AddItem(country.Length==0 ? "全部地区" : country);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`select.AddItem(kind.Length==0?"全部赛事":EsportsWorld.StageName(kind))`；返回值紧邻使用处：`ExpressionStatementSyntax: select.AddItem(kind.Length==0?"全部赛事":EsportsWorld.StageName(kind));`
- `Godot.OptionButton.Select(int)`；输入表达式：`region.Select(regions.IndexOf(_fixtureRegion))`；返回值紧邻使用处：`ExpressionStatementSyntax: region.Select(regions.IndexOf(_fixtureRegion));`
- `Godot.OptionButton.Select(int)`；输入表达式：`select.Select(Math.Max(0,kinds.IndexOf(_fixtureKind)))`；返回值紧邻使用处：`ExpressionStatementSyntax: select.Select(Math.Max(0,kinds.IndexOf(_fixtureKind)));`
- `Godot.ScrollContainer.EnsureControlVisible(Godot.Control)`；输入表达式：`scroll.EnsureControlVisible(target)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.EnsureControlVisible(target);`
- `Godot.ScrollContainer.GetVScrollBar()`；输入表达式：`scroll.GetVScrollBar()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: scroll.GetVScrollBar().GetCombinedMinimumSize`
- `Godot.ScrollContainer.ScrollContainer()`；输入表达式：`new ScrollContainer {CustomMinimumSize=new(0,710),HorizontalScrollMode=ScrollContainer.ScrollMode.Disabled,              VerticalScrollMode=ScrollContainer.ScrollMode.Reserve}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new ScrollContainer {CustomMinimumSize=new(0,710),HorizontalScrollMode=ScrollContainer.ScrollMode.Disabled,              VerticalScrollMode=ScrollContainer.ScrollMode.Reserve}`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill}`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 52)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 52)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,710)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,710)`
- `InScope(string, NationalSpire.CareerMatch?)`；输入表达式：`InScope(c.Country, m)`；返回值紧邻使用处：`IfStatementSyntax: if (InScope(c.Country, m)) scheduled.Add(new(f.Day, c.Name, c.Kind, c.Country, m, c, f));`
- `InScope(string, NationalSpire.CareerMatch?)`；输入表达式：`InScope(country, m)`；返回值紧邻使用处：`IfStatementSyntax: if (InScope(country, m)) scheduled.Add(new(m.Day, m.Event, m.Kind, country, m, c, null));`
- `NationalSpire.CareerScreen.AddFixtureRow(NationalSpire.CareerData, NationalSpire.CareerScreen.FixtureEntry, Godot.VBoxContainer, bool)`；输入表达式：`AddFixtureRow(d,e,timeline,e==day.First())`；返回值紧邻使用处：`ExpressionStatementSyntax: AddFixtureRow(d,e,timeline,e==day.First());`
- `NationalSpire.CareerScreen.Baseline(Godot.Control)`；输入表达式：`Baseline(filterBand)`；返回值紧邻使用处：`ExpressionStatementSyntax: Baseline(filterBand);`
- `NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；输入表达式：`ButtonSurface(pick, selectedCup ? "24464b" : "15232f", selectedCup ? "698e90" : "354b58", "294553", "80c7c5", 7)`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonSurface(pick, selectedCup ? "24464b" : "15232f", selectedCup ? "698e90" : "354b58", "294553", "80c7c5", 7);`
- `NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；输入表达式：`CaptionButton("显示更多比赛",()=>{int y=scroll.ScrollVertical;_fixtureLimit+=75; Render();var next=_content.GetChildren().OfType<ScrollContainer>().Last();next.SetDeferred(ScrollContainer.PropertyName.ScrollVertical,y);})`；返回值紧邻使用处：`ArgumentSyntax: CaptionButton("显示更多比赛",()=>{int y=scroll.ScrollVertical;_fixtureLimit+=75; Render();var next=_content.GetChildren().OfType<ScrollContainer>().Last();next.SetDeferred(ScrollContainer.PropertyName.ScrollVertical,y);})`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("赛区",15,_muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardLabel("赛区",15,_muted)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("赛事种类",15,_muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardLabel("赛事种类",15,_muted)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel($"第 {fixtureSeason} 赛季",15,_gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardLabel($"第 {fixtureSeason} 赛季",15,_gold)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel($"第 {season} 赛季", 16, _gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DashboardLabel($"第 {season} 赛季", 16, _gold)`
- `NationalSpire.CareerScreen.DashboardSwitch(string, bool, System.Action<bool>, int, int)`；输入表达式：`DashboardSwitch("我的比赛",MyFixtures,value=>{ MyFixtures=value; _fixtureLimit=75; Render(); },FixtureActionWidth,37)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardSwitch("我的比赛",MyFixtures,value=>{ MyFixtures=value; _fixtureLimit=75; Render(); },FixtureActionWidth,37)`
- `NationalSpire.CareerScreen.FixtureEntry.FixtureEntry(int, string, string, string, NationalSpire.CareerMatch?, NationalSpire.WorldCompetition?, NationalSpire.WorldFixture?)`；输入表达式：`new(f.Day, c.Name, c.Kind, c.Country, m, c, f)`；返回值紧邻使用处：`ArgumentSyntax: new(f.Day, c.Name, c.Kind, c.Country, m, c, f)`
- `NationalSpire.CareerScreen.FixtureEntry.FixtureEntry(int, string, string, string, NationalSpire.CareerMatch?, NationalSpire.WorldCompetition?, NationalSpire.WorldFixture?)`；输入表达式：`new(m.Day, m.Event, m.Kind, country, m, c, null)`；返回值紧邻使用处：`ArgumentSyntax: new(m.Day, m.Event, m.Kind, country, m, c, null)`
- `NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；输入表达式：`FramedAction(entry.Name, () => {                      if (!selectedCup) { _fixtureInternational = entry.Id; Render(); }                  }, height: 42)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = FramedAction(entry.Name, () => {                      if (!selectedCup) { _fixtureInternational = entry.Id; Render(); }                  }, height: 42)`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`Glyph("list-filter",19,CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Glyph("list-filter",19,CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Inset(int, int)`；输入表达式：`Inset(4,10)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Inset(4,10)`
- `NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`；输入表达式：`InternationalBracket(d,cup,picks)`；返回值紧邻使用处：`ExpressionStatementSyntax: InternationalBracket(d,cup,picks);`
- `NationalSpire.CareerScreen.IsInternationalCup(NationalSpire.WorldCompetition)`；输入表达式：`IsInternationalCup(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Id == _fixtureInternational && IsInternationalCup(c)`
- `NationalSpire.CareerScreen.IsInternationalCup(NationalSpire.WorldCompetition)`；输入表达式：`IsInternationalCup(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Season == season && IsInternationalCup(c)`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.TabStrip(Godot.Container, int, bool, bool)`；输入表达式：`TabStrip(_content,30,secondary:true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =TabStrip(_content,30,secondary:true)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("本赛季的国际赛事签表尚未公布。",18,_muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("本赛季的国际赛事签表尚未公布。",18,_muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("当前筛选下暂无赛事。",18,_muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("当前筛选下暂无赛事。",18,_muted)`
- `NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`；输入表达式：`TextLink("返回当前赛季", () => { _fixtureInternational = ""; Render(); }, 16, underline: true)`；返回值紧邻使用处：`ArgumentSyntax: TextLink("返回当前赛季", () => { _fixtureInternational = ""; Render(); }, 16, underline: true)`
- `NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`；输入表达式：`TextLink("返回当前赛季",()=>{_fixtureSeason=0;_fixtureLimit=75;Render();},15,underline:true)`；返回值紧邻使用处：`ArgumentSyntax: TextLink("返回当前赛季",()=>{_fixtureSeason=0;_fixtureLimit=75;Render();},15,underline:true)`
- `NationalSpire.CareerScreen.UnderlineTab(string, System.Action, bool, int, int, bool, bool)`；输入表达式：`UnderlineTab(scope,()=>{ _fixtureScope=scope; _fixtureKind=""; _fixtureSeason=0; _fixtureLimit=75; Render(); }, _fixtureScope==scope)`；返回值紧邻使用处：`ArgumentSyntax: UnderlineTab(scope,()=>{ _fixtureScope=scope; _fixtureKind=""; _fixtureSeason=0; _fixtureLimit=75; Render(); }, _fixtureScope==scope)`
- `NationalSpire.CircuitWorld.HasWorldFinal(int)`；输入表达式：`CircuitWorld.HasWorldFinal(d.Season)`；返回值紧邻使用处：`IfStatementSyntax: if (CircuitWorld.HasWorldFinal(d.Season)) AddScheduled("worldfinal");`
- `NationalSpire.CircuitWorld.InternationalTeamCup(int)`；输入表达式：`CircuitWorld.InternationalTeamCup(d.Season)`；返回值紧邻使用处：`ArgumentSyntax: CircuitWorld.InternationalTeamCup(d.Season)`
- `NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`EsportsWorld.EntryReason(d,m)`；返回值紧邻使用处：`BinaryExpressionSyntax: EsportsWorld.EntryReason(d,m)==null`
- `NationalSpire.EsportsWorld.StageName(string)`；输入表达式：`EsportsWorld.StageName(kind)`；返回值紧邻使用处：`ConditionalExpressionSyntax: kind.Length==0?"全部赛事":EsportsWorld.StageName(kind)`
- `NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Length(d,fixtureSeason)`；返回值紧邻使用处：`BinaryExpressionSyntax: start+SeasonCalendar.Length(d,fixtureSeason)`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(d,fixtureSeason)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.Start(d,fixtureSeason)+1`
- `Picker(string, int)`；输入表达式：`Picker("FixtureKind",174)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Picker("FixtureKind",174)`
- `Picker(string, int)`；输入表达式：`Picker("FixtureRegion",138)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Picker("FixtureRegion",138)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`matched.Add(m.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: matched.Add(m.Id);`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`completed!.Contains(m.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: m.Registered || completed!.Contains(m.Id)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`matched.Contains(m.Id)`；返回值紧邻使用处：`IfStatementSyntax: if (matched.Contains(m.Id)) continue;`
- `System.Collections.Generic.HashSet<T>.HashSet()`；输入表达式：`new HashSet<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HashSet<string>()`
- `System.Collections.Generic.IEnumerable<T>.Order<T>()`；输入表达式：`rows.Select(e=>e.Country).Distinct().Order()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: rows.Select(e=>e.Country).Distinct().Order().Prepend`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`cups.Any(c => c.Modern && c.Kind == "league")`；返回值紧邻使用处：`BinaryExpressionSyntax: season == d.Season && cups.Any(c => c.Modern && c.Kind == "league")`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`rows.Select(e=>e.Country).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: rows.Select(e=>e.Country).Distinct().Order`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`rows.Select(e=>e.Kind).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: rows.Select(e=>e.Kind).Distinct().Prepend`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；输入表达式：`day.First()`；返回值紧邻使用处：`BinaryExpressionSyntax: e==day.First()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`bindings[(c.Id, f.Id)].FirstOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = bindings[(c.Id, f.Id)].FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`international.FirstOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: international.FirstOrDefault(c=>c.Id==_fixtureInternational) ?? international.FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`cups.FirstOrDefault(c => c.Id == m.CompetitionId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = cups.FirstOrDefault(c => c.Id == m.CompetitionId)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.FirstOrDefault(c => c.Id == _fixtureInternational && IsInternationalCup(c))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.Competitions.FirstOrDefault(c => c.Id == _fixtureInternational && IsInternationalCup(c))`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`international.FirstOrDefault(c=>c.Id==_fixtureInternational)`；返回值紧邻使用处：`BinaryExpressionSyntax: international.FirstOrDefault(c=>c.Id==_fixtureInternational) ?? international.FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`rows.Take(_fixtureLimit).GroupBy(e=>e.Day)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var day in rows.Take(_fixtureLimit).GroupBy(e=>e.Day))              foreach(var e in day)              {                  AddFixtureRow(d,e,timeline,e==day.First());                  if (focus?.Invoke(e)==true)                  {                      focus=null;                      var target=timeline.GetChild<Control>(-1);                      Callable.From(()=>{ if (IsInstanceValid(target) && target.IsInsideTree()) scroll.EnsureControlVisible(target); }).CallDeferred();                  }              }`
- `System.Collections.Generic.IEnumerable<TSource>.Last<TSource>()`；输入表达式：`_content.GetChildren().OfType<ScrollContainer>().Last()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =_content.GetChildren().OfType<ScrollContainer>().Last()`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`scheduled.OrderBy(e => e.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: scheduled.OrderBy(e => e.Day).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.Prepend<TSource>(TSource)`；输入表达式：`rows.Select(e=>e.Country).Distinct().Order().Prepend("")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: rows.Select(e=>e.Country).Distinct().Order().Prepend("").ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Prepend<TSource>(TSource)`；输入表达式：`rows.Select(e=>e.Kind).Distinct().Prepend("")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: rows.Select(e=>e.Kind).Distinct().Prepend("").ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.Results.Select(r => r.MatchId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Results.Select(r => r.MatchId).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`rows.Select(e=>e.Country)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: rows.Select(e=>e.Country).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`rows.Select(e=>e.Kind)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: rows.Select(e=>e.Kind).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`rows.Take(_fixtureLimit)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: rows.Take(_fixtureLimit).GroupBy`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`d.Results.Select(r => r.MatchId).ToHashSet()`；返回值紧邻使用处：`ConditionalExpressionSyntax: MyFixtures ? d.Results.Select(r => r.MatchId).ToHashSet() : null`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Esports.Competitions.Where(c => c.Season == season && IsInternationalCup(c)).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.Competitions.Where(c => c.Season == season && IsInternationalCup(c)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Esports.Competitions.Where(c=>c.Season==fixtureSeason).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.Competitions.Where(c=>c.Season==fixtureSeason).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Matches.Where(m=>m.Day>=start && m.Day<=end).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =d.Matches.Where(m=>m.Day>=start && m.Day<=end).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`rows.Select(e=>e.Country).Distinct().Order().Prepend("").ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =rows.Select(e=>e.Country).Distinct().Order().Prepend("").ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`rows.Select(e=>e.Kind).Distinct().Prepend("").ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =rows.Select(e=>e.Kind).Distinct().Prepend("").ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`rows.Where(e=>(_fixtureKind.Length==0 || _fixtureKind==e.Kind) && (!MyFixtures || e.Match is { } m &&              (m.Registered || completed!.Contains(m.Id) || m.Status=="待赛" && m.Day>=d.Day && EsportsWorld.EntryReason(d,m)==null))).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: rows=rows.Where(e=>(_fixtureKind.Length==0 || _fixtureKind==e.Kind) && (!MyFixtures || e.Match is { } m &&              (m.Registered || completed!.Contains(m.Id) || m.Status=="待赛" && m.Day>=d.Day && EsportsWorld.EntryReason(d,m)==null))).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`rows.Where(e=>e.Country==_fixtureRegion).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: rows=rows.Where(e=>e.Country==_fixtureRegion).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`scheduled.OrderBy(e => e.Day).ThenBy(e => e.Title).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = scheduled.OrderBy(e => e.Day).ThenBy(e => e.Title).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToLookup<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`matches.Where(m=>m.FixtureId.Length>0).ToLookup(m=>(m.CompetitionId,m.FixtureId))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =matches.Where(m=>m.FixtureId.Length>0).ToLookup(m=>(m.CompetitionId,m.FixtureId))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Where(c => c.Season == season && IsInternationalCup(c))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Competitions.Where(c => c.Season == season && IsInternationalCup(c)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Where(c=>c.Season==fixtureSeason)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Competitions.Where(c=>c.Season==fixtureSeason).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.Where(m=>m.Day>=start && m.Day<=end)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Matches.Where(m=>m.Day>=start && m.Day<=end).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`matches.Where(m=>m.FixtureId.Length>0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: matches.Where(m=>m.FixtureId.Length>0).ToLookup`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`rows.Where(e=>(_fixtureKind.Length==0 || _fixtureKind==e.Kind) && (!MyFixtures || e.Match is { } m &&              (m.Registered || completed!.Contains(m.Id) || m.Status=="待赛" && m.Day>=d.Day && EsportsWorld.EntryReason(d,m)==null)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: rows.Where(e=>(_fixtureKind.Length==0 || _fixtureKind==e.Kind) && (!MyFixtures || e.Match is { } m &&              (m.Registered || completed!.Contains(m.Id) || m.Status=="待赛" && m.Day>=d.Day && EsportsWorld.EntryReason(d,m)==null))).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`rows.Where(e=>e.Country==_fixtureRegion)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: rows.Where(e=>e.Country==_fixtureRegion).ToList`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`scheduled.Add(new(f.Day, c.Name, c.Kind, c.Country, m, c, f))`；返回值紧邻使用处：`ExpressionStatementSyntax: scheduled.Add(new(f.Day, c.Name, c.Kind, c.Country, m, c, f));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`scheduled.Add(new(m.Day, m.Event, m.Kind, country, m, c, null))`；返回值紧邻使用处：`ExpressionStatementSyntax: scheduled.Add(new(m.Day, m.Event, m.Kind, country, m, c, null));`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`regions.Contains(_fixtureRegion)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !regions.Contains(_fixtureRegion)`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`rows.FindIndex(focus)`；返回值紧邻使用处：`BinaryExpressionSyntax: rows.FindIndex(focus)+1`
- `System.Collections.Generic.List<T>.IndexOf(T)`；输入表达式：`kinds.IndexOf(_fixtureKind)`；返回值紧邻使用处：`ArgumentSyntax: kinds.IndexOf(_fixtureKind)`
- `System.Collections.Generic.List<T>.IndexOf(T)`；输入表达式：`regions.IndexOf(_fixtureRegion)`；返回值紧邻使用处：`ArgumentSyntax: regions.IndexOf(_fixtureRegion)`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<FixtureEntry>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<FixtureEntry>()`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`_content.GetChildren().OfType<ScrollContainer>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _content.GetChildren().OfType<ScrollContainer>().Last`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`scheduled.OrderBy(e => e.Day).ThenBy(e => e.Title)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: scheduled.OrderBy(e => e.Day).ThenBy(e => e.Title).ToList`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(_fixtureLimit,rows.FindIndex(focus)+1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _fixtureLimit=Math.Max(_fixtureLimit,rows.FindIndex(focus)+1)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0,kinds.IndexOf(_fixtureKind))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0,kinds.IndexOf(_fixtureKind))`
- `System.Predicate<T>.Invoke(T)`；输入表达式：`.Invoke(e)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: focus?.Invoke(e)`

**赋值（含属性/字段和局部值）：**

- `_fixtureFocus` = `null`
- `_fixtureInternational` = `""`
- `_fixtureInternational` = `entry.Id`
- `_fixtureKind` = `""`
- `_fixtureKind` = `kinds[(int)i]`
- `_fixtureLimit` += `75`
- `_fixtureLimit` = `75`
- `_fixtureLimit` = `Math.Max(_fixtureLimit,rows.FindIndex(focus)+1)`
- `_fixtureRegion` = `""`
- `_fixtureRegion` = `regions[(int)i]`
- `_fixtureScope` = `scope`
- `_fixtureSeason` = `0`
- `CustomMinimumSize` = `new(0, 52)`
- `CustomMinimumSize` = `new(0,710)`
- `edition.SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `filterBand.Name` = `"FixtureFilters"`
- `filterTitle.AutowrapMode` = `TextServer.AutowrapMode.Off`
- `filterTitle.SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `focus` = `null`
- `HorizontalScrollMode` = `ScrollContainer.ScrollMode.Disabled`
- `MyFixtures` = `value`
- `pick.SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `region.ItemSelected` += `i=>{_fixtureRegion=regions[(int)i];_fixtureLimit=75;Render();}`
- `regionTitle.SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `rows` = `rows.Where(e=>(_fixtureKind.Length==0 || _fixtureKind==e.Kind) && (!MyFixtures || e.Match is { } m &&              (m.Registered || completed!.Contains(m.Id) || m.Status=="待赛" && m.Day>=d.Day && EsportsWorld.EntryReason(d,m)==null))).ToList()`
- `rows` = `rows.Where(e=>e.Country==_fixtureRegion).ToList()`
- `select.ItemSelected` += `i=>{_fixtureKind=kinds[(int)i];_fixtureLimit=75; Render();}`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `VerticalScrollMode` = `ScrollContainer.ScrollMode.Reserve`

<a id="symbol-e74cd7a835f7"></a>

## `AddScheduled(string) — void AddScheduled(string kind)`

来源：源码第 114 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.FixtureSchedule(NationalSpire.CareerData)`](FixtureScheduleScreen.cs.md#symbol-e95df6046805)

**调用：** [`NationalSpire.EsportsWorld.StageName(string)`](EsportsWorld.cs.md#symbol-c0445cae874d)；[`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-12bdfe5d4265)；[`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-ee7b01d76b23)；`NationalSpire.WorldCompetition.WorldCompetition()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Season`；`NationalSpire.EsportsWorld.StageName(string)`；`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；`NationalSpire.WorldCompetition.CalendarDays`；`NationalSpire.WorldCompetition.CalendarStart`；`NationalSpire.WorldCompetition.Country`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Modern`；`NationalSpire.WorldCompetition.Name`；`NationalSpire.WorldCompetition.Season`；`NationalSpire.WorldCompetition.TeamEvent`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EsportsWorld.StageName(string)`；输入表达式：`EsportsWorld.StageName(kind)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Name = EsportsWorld.StageName(kind)`
- `NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Length(d)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CalendarDays = SeasonCalendar.Length(d)`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(d)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CalendarStart = SeasonCalendar.Start(d)`
- `NationalSpire.WorldCompetition.WorldCompetition()`；输入表达式：`new WorldCompetition {                          Id = $"{kind}-{d.Season}", Kind = kind, Name = EsportsWorld.StageName(kind), Country = "国际",                          Season = d.Season, CalendarStart = SeasonCalendar.Start(d), CalendarDays = SeasonCalendar.Length(d),                          TeamEvent = kind != "worldfinal", Modern = true                      }`；返回值紧邻使用处：`ArgumentSyntax: new WorldCompetition {                          Id = $"{kind}-{d.Season}", Kind = kind, Name = EsportsWorld.StageName(kind), Country = "国际",                          Season = d.Season, CalendarStart = SeasonCalendar.Start(d), CalendarDays = SeasonCalendar.Length(d),                          TeamEvent = kind != "worldfinal", Modern = true                      }`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`international.Any(c => c.Kind == kind)`；返回值紧邻使用处：`IfStatementSyntax: if (international.Any(c => c.Kind == kind)) return;`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`international.Add(new WorldCompetition {                          Id = $"{kind}-{d.Season}", Kind = kind, Name = EsportsWorld.StageName(kind), Country = "国际",                          Season = d.Season, CalendarStart = SeasonCalendar.Start(d), CalendarDays = SeasonCalendar.Length(d),                          TeamEvent = kind != "worldfinal", Modern = true                      })`；返回值紧邻使用处：`ExpressionStatementSyntax: international.Add(new WorldCompetition {                          Id = $"{kind}-{d.Season}", Kind = kind, Name = EsportsWorld.StageName(kind), Country = "国际",                          Season = d.Season, CalendarStart = SeasonCalendar.Start(d), CalendarDays = SeasonCalendar.Length(d),                          TeamEvent = kind != "worldfinal", Modern = true                      });`

**赋值（含属性/字段和局部值）：**

- `CalendarDays` = `SeasonCalendar.Length(d)`
- `CalendarStart` = `SeasonCalendar.Start(d)`
- `Country` = `"国际"`
- `Id` = `$"{kind}-{d.Season}"`
- `Kind` = `kind`
- `Modern` = `true`
- `Name` = `EsportsWorld.StageName(kind)`
- `Season` = `d.Season`
- `TeamEvent` = `kind != "worldfinal"`

<a id="symbol-9a5659850a62"></a>

## `InScope(string, NationalSpire.CareerMatch?) — bool InScope(string country, CareerMatch? match)`

来源：源码第 156 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.FixtureSchedule(NationalSpire.CareerData)`](FixtureScheduleScreen.cs.md#symbol-e95df6046805)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.EsportsCareer.Country`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1ce84475b6f2"></a>

## `Picker(string, int) — OptionButton Picker(string name,int width)`

来源：源码第 184 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.FixtureSchedule(NationalSpire.CareerData)`](FixtureScheduleScreen.cs.md#symbol-e95df6046805)

**调用：** [`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`](DashboardControls.cs.md#symbol-0374e90f1c3f)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.OptionButton()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`picker.AddThemeConstantOverride("arrow_margin",8)`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.AddThemeConstantOverride("arrow_margin",8);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`picker.AddThemeFontSizeOverride("font_size",15)`；返回值紧邻使用处：`ExpressionStatementSyntax: picker.AddThemeFontSizeOverride("font_size",15);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`filters.AddChild(picker)`；返回值紧邻使用处：`ExpressionStatementSyntax: filters.AddChild(picker);`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton {Name=name,CustomMinimumSize=new(width,36),FitToLongestItem=false,                  SizeFlagsVertical=SizeFlags.ShrinkCenter,MouseDefaultCursorShape=CursorShape.PointingHand}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new OptionButton {Name=name,CustomMinimumSize=new(width,36),FitToLongestItem=false,                  SizeFlagsVertical=SizeFlags.ShrinkCenter,MouseDefaultCursorShape=CursorShape.PointingHand}`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(width,36)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(width,36)`
- `NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；输入表达式：`ButtonSurface(picker,"172a37","395365","28434c","658c91",5,5)`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonSurface(picker,"172a37","395365","28434c","658c91",5,5);`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(width,36)`
- `FitToLongestItem` = `false`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `Name` = `name`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`

<a id="symbol-237327497b3f"></a>

## `NationalSpire.CareerScreen.AddFixtureRow(NationalSpire.CareerData, NationalSpire.CareerScreen.FixtureEntry, Godot.VBoxContainer, bool) — private void AddFixtureRow(CareerData d, FixtureEntry e,VBoxContainer timeline,bool first)`

来源：源码第 235 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.FixtureSchedule(NationalSpire.CareerData)`](FixtureScheduleScreen.cs.md#symbol-e95df6046805)

**调用：** [`NationalSpire.CareerEngine.AdvanceToDay(NationalSpire.CareerData, int, bool)`](CareerEngine.cs.md#symbol-0c04b8ec5f73)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.SetRegistration(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`](CareerEngine.cs.md#symbol-a453368fed28)；[`NationalSpire.CareerScreen.BracketDetails(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, System.Collections.Generic.List<NationalSpire.WorldFixture>, int)`](FixtureScheduleScreen.cs.md#symbol-1daead3fab8e)；[`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`](DashboardControls.cs.md#symbol-0374e90f1c3f)；[`NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`](CareerDashboard.cs.md#symbol-22831701f7f1)；[`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.Inset(int, int)`](DashboardControls.cs.md#symbol-ebb2fedbb4fc)；[`NationalSpire.CareerScreen.MatchTitle(NationalSpire.CareerData, NationalSpire.CareerMatch)`](CalendarPlansScreen.cs.md#symbol-a9a3a3c86347)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.NavigationIcon(string)`](CareerDashboard.cs.md#symbol-3c49977c9503)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.OpenCompetition(string)`](CareerNavigation.cs.md#symbol-d88417a19f38)；[`NationalSpire.CareerScreen.OpenReview(string)`](MatchArenaScreen.cs.md#symbol-1c01e409299f)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`](CareerDialog.cs.md#symbol-df0355cc8433)；[`NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`](DashboardControls.cs.md#symbol-d545a37403bd)；[`NationalSpire.CareerScreen.Visit(System.Action)`](CareerNavigation.cs.md#symbol-d49752019228)；[`NationalSpire.CircuitWorld.RoundName(NationalSpire.WorldCompetition, int)`](CircuitWorld.cs.md#symbol-b35defbcdb7c)；[`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`](EsportsWorld.cs.md#symbol-4b9f3e1bf70a)；[`NationalSpire.FixtureTimelineRow.Highlight(bool)`](FixtureScheduleScreen.cs.md#symbol-b906161359cd)；[`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-8a08be365f83)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.Color.Color(string)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.Control()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetIndex(bool)`；`Godot.Node.MoveChild(Godot.Node, int)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.FixtureTimelineRow.FixtureTimelineRow()`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.DateOnly.ToString(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerEngine.AdvanceToDay(NationalSpire.CareerData, int, bool)`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.SetRegistration(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerMatch.Event`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.Registered`；`NationalSpire.CareerMatch.RequiredAscension`；`NationalSpire.CareerMatch.Round`；`NationalSpire.CareerMatch.Status`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.CareerScreen._arenaMatchId`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen.BracketDetails(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, System.Collections.Generic.List<NationalSpire.WorldFixture>, int)`；`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；`NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.FixtureActionWidth`；`NationalSpire.CareerScreen.FixtureEndInset`；`NationalSpire.CareerScreen.FixtureEntry.Country`；`NationalSpire.CareerScreen.FixtureEntry.Cup`；`NationalSpire.CareerScreen.FixtureEntry.Day`；`NationalSpire.CareerScreen.FixtureEntry.Fixture`；`NationalSpire.CareerScreen.FixtureEntry.Match`；`NationalSpire.CareerScreen.FixtureEntry.Title`；`NationalSpire.CareerScreen.FixtureRowGap`；`NationalSpire.CareerScreen.Inset(int, int)`；`NationalSpire.CareerScreen.MatchTitle(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.NavigationIcon(string)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.OpenCompetition(string)`；`NationalSpire.CareerScreen.OpenReview(string)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；`NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`；`NationalSpire.CareerScreen.Visit(System.Action)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.CircuitWorld.RoundName(NationalSpire.WorldCompetition, int)`；`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.FixtureTimelineRow.FirstOfDay`；`NationalSpire.FixtureTimelineRow.Highlight(bool)`；`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.ICareerSession.Host`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Modern`；`NationalSpire.WorldFixture.Ascension`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.Round`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`detail.DrawLine(new(13,0),new(13,detail.Size.Y),new Color("68909b80"))`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>detail.DrawLine(new(13,0),new(13,detail.Size.Y),new Color("68909b80"))`
- `Godot.Color.Color(string)`；输入表达式：`new Color("68909b80")`；返回值紧邻使用处：`ArgumentSyntax: new Color("68909b80")`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`body.AddThemeConstantOverride("separation",3)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddThemeConstantOverride("separation",3);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`detail.AddThemeConstantOverride("margin_left",156)`；返回值紧邻使用处：`ExpressionStatementSyntax: detail.AddThemeConstantOverride("margin_left",156);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`detail.AddThemeConstantOverride("margin_right",FixtureRowGap+FixtureEndInset)`；返回值紧邻使用处：`ExpressionStatementSyntax: detail.AddThemeConstantOverride("margin_right",FixtureRowGap+FixtureEndInset);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`disclosure.AddThemeConstantOverride("icon_max_width",14)`；返回值紧邻使用处：`ExpressionStatementSyntax: disclosure.AddThemeConstantOverride("icon_max_width",14);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation",FixtureRowGap)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation",FixtureRowGap);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`stamp.AddThemeConstantOverride("separation",2)`；返回值紧邻使用处：`ExpressionStatementSyntax: stamp.AddThemeConstantOverride("separation",2);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`subline.AddThemeConstantOverride("separation",10)`；返回值紧邻使用处：`ExpressionStatementSyntax: subline.AddThemeConstantOverride("separation",10);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`action.AddThemeFontSizeOverride("font_size",15)`；返回值紧邻使用处：`ExpressionStatementSyntax: action.AddThemeFontSizeOverride("font_size",15);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`disclosure.AddThemeFontSizeOverride("font_size",14)`；返回值紧邻使用处：`ExpressionStatementSyntax: disclosure.AddThemeFontSizeOverride("font_size",14);`
- `Godot.Control.Control()`；输入表达式：`new Control {CustomMinimumSize=new(20,0)}`；返回值紧邻使用处：`ArgumentSyntax: new Control {CustomMinimumSize=new(20,0)}`
- `Godot.Control.Control()`；输入表达式：`new Control {CustomMinimumSize=new(FixtureEndInset,0),MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`ArgumentSyntax: new Control {CustomMinimumSize=new(FixtureEndInset,0),MouseFilter=MouseFilterEnum.Ignore}`
- `Godot.Control.Control()`；输入表达式：`new Control{CustomMinimumSize=new(146,0)}`；返回值紧邻使用处：`ArgumentSyntax: new Control{CustomMinimumSize=new(146,0)}`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(DashboardLabel(m==null?e.Title:MatchTitle(d,m),18,_ink,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(DashboardLabel(m==null?e.Title:MatchTitle(d,m),18,_ink,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(subline)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(subline);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`detail.AddChild(BracketDetails(d,e.Cup,roundText,[f],round))`；返回值紧邻使用处：`ExpressionStatementSyntax: detail.AddChild(BracketDetails(d,e.Cup,roundText,[f],round));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inset.AddChild(body)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.AddChild(body);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(action)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(action);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(inset)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(inset);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(meta)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(meta);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(new Control {CustomMinimumSize=new(20,0)})`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(new Control {CustomMinimumSize=new(20,0)});`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(new Control {CustomMinimumSize=new(FixtureEndInset,0),MouseFilter=MouseFilterEnum.Ignore})`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(new Control {CustomMinimumSize=new(FixtureEndInset,0),MouseFilter=MouseFilterEnum.Ignore});`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(new Control{CustomMinimumSize=new(146,0)})`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(new Control{CustomMinimumSize=new(146,0)});`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(stamp)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(stamp);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(status)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(status);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`stamp.AddChild(DashboardLabel("周"+"日一二三四五六"[(int)date.DayOfWeek]+(e.Day==d.Day?" · 今天":""),14,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: stamp.AddChild(DashboardLabel("周"+"日一二三四五六"[(int)date.DayOfWeek]+(e.Day==d.Day?" · 今天":""),14,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`stamp.AddChild(DashboardLabel(date.ToString("M月d日"),18,e.Day==d.Day?CareerVisuals.Teal:_ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: stamp.AddChild(DashboardLabel(date.ToString("M月d日"),18,e.Day==d.Day?CareerVisuals.Teal:_ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`subline.AddChild(DashboardLabel(pair,14,_muted,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: subline.AddChild(DashboardLabel(pair,14,_muted,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`subline.AddChild(disclosure)`；返回值紧邻使用处：`ExpressionStatementSyntax: subline.AddChild(disclosure);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`timeline.AddChild(detail)`；返回值紧邻使用处：`ExpressionStatementSyntax: timeline.AddChild(detail);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`timeline.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: timeline.AddChild(row);`
- `Godot.Node.GetIndex(bool)`；输入表达式：`row.GetIndex()`；返回值紧邻使用处：`BinaryExpressionSyntax: row.GetIndex()+1`
- `Godot.Node.MoveChild(Godot.Node, int)`；输入表达式：`timeline.MoveChild(detail,row.GetIndex()+1)`；返回值紧邻使用处：`ExpressionStatementSyntax: timeline.MoveChild(detail,row.GetIndex()+1);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer {CustomMinimumSize=new(104,0),Alignment=BoxContainer.AlignmentMode.Center}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer {CustomMinimumSize=new(104,0),Alignment=BoxContainer.AlignmentMode.Center}`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill,Alignment=BoxContainer.AlignmentMode.Center}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill,Alignment=BoxContainer.AlignmentMode.Center}`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,80)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,80)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(104,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(104,0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(13,0)`；返回值紧邻使用处：`ArgumentSyntax: new(13,0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(13,detail.Size.Y)`；返回值紧邻使用处：`ArgumentSyntax: new(13,detail.Size.Y)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(146,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(146,0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(20,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(20,0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(65,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: status.CustomMinimumSize=new(65,0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(84,26)`；返回值紧邻使用处：`AssignmentExpressionSyntax: disclosure.CustomMinimumSize=new(84,26)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(FixtureActionWidth,37)`；返回值紧邻使用处：`AssignmentExpressionSyntax: action.CustomMinimumSize=new(FixtureActionWidth,37)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(FixtureEndInset,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(FixtureEndInset,0)`
- `NationalSpire.CareerEngine.AdvanceToDay(NationalSpire.CareerData, int, bool)`；输入表达式：`CareerEngine.AdvanceToDay(d,m.Day)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.AdvanceToDay(d,m.Day);`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d,f.AwayId)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.DisplayName(d,f.HomeId)+" / "+CareerEngine.DisplayName(d,f.AwayId)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d,f.HomeId)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.DisplayName(d,f.HomeId)+" / "`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d,m.OpponentId)`；返回值紧邻使用处：`BinaryExpressionSyntax: "对手："+CareerEngine.DisplayName(d,m.OpponentId)`
- `NationalSpire.CareerEngine.SetRegistration(NationalSpire.CareerData, NationalSpire.CareerMatch, bool)`；输入表达式：`CareerEngine.SetRegistration(d,m,true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CareerEngine.SetRegistration(d,m,true)`
- `NationalSpire.CareerScreen.BracketDetails(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, System.Collections.Generic.List<NationalSpire.WorldFixture>, int)`；输入表达式：`BracketDetails(d,e.Cup,roundText,[f],round)`；返回值紧邻使用处：`ArgumentSyntax: BracketDetails(d,e.Cup,roundText,[f],round)`
- `NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；输入表达式：`ButtonSurface(action,"1d3040","395365","28434c","658c91",6)`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonSurface(action,"1d3040","395365","28434c","658c91",6);`
- `NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；输入表达式：`CaptionButton("报名比赛",()=>{if(MultiplayerCommand("propose-register",m.Id,number:1)) return; var error=CareerEngine.SetRegistration(d,m,true); Render(); if(error!=null) Notice(error,true);})`；返回值紧邻使用处：`AssignmentExpressionSyntax: action=CaptionButton("报名比赛",()=>{if(MultiplayerCommand("propose-register",m.Id,number:1)) return; var error=CareerEngine.SetRegistration(d,m,true); Render(); if(error!=null) Notice(error,true);})`
- `NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；输入表达式：`CaptionButton("查看战报",()=>OpenReview(m.Id))`；返回值紧邻使用处：`AssignmentExpressionSyntax: action=CaptionButton("查看战报",()=>OpenReview(m.Id))`
- `NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；输入表达式：`CaptionButton("前往赛场",()=>Visit(()=>{_tab="赛事";_arenaMatchId=m.Id;}))`；返回值紧邻使用处：`ConditionalExpressionSyntax: m.Day==d.Day ? CaptionButton("前往赛场",()=>Visit(()=>{_tab="赛事";_arenaMatchId=m.Id;}))                      : CaptionButton("跳到此日",()=>ShowCareerDialog("跳到比赛日",$"{m.Event}\n推进至{GameCalendar.Text(d,m.Day)}？途中会在需处理的事件处停下。",()=>                      { if(!MultiplayerCommand("propose-advance",number:m.Day)) {CareerEngine.AdvanceToDay(d,m.Day);Render();} return true;}))`
- `NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；输入表达式：`CaptionButton("赛事详情",()=>OpenCompetition(e.Cup.Id))`；返回值紧邻使用处：`AssignmentExpressionSyntax: action=CaptionButton("赛事详情",()=>OpenCompetition(e.Cup.Id))`
- `NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；输入表达式：`CaptionButton("跳到此日",()=>ShowCareerDialog("跳到比赛日",$"{m.Event}\n推进至{GameCalendar.Text(d,m.Day)}？途中会在需处理的事件处停下。",()=>                      { if(!MultiplayerCommand("propose-advance",number:m.Day)) {CareerEngine.AdvanceToDay(d,m.Day);Render();} return true;}))`；返回值紧邻使用处：`ConditionalExpressionSyntax: m.Day==d.Day ? CaptionButton("前往赛场",()=>Visit(()=>{_tab="赛事";_arenaMatchId=m.Id;}))                      : CaptionButton("跳到此日",()=>ShowCareerDialog("跳到比赛日",$"{m.Event}\n推进至{GameCalendar.Text(d,m.Day)}？途中会在需处理的事件处停下。",()=>                      { if(!MultiplayerCommand("propose-advance",number:m.Day)) {CareerEngine.AdvanceToDay(d,m.Day);Render();} return true;}))`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("周"+"日一二三四五六"[(int)date.DayOfWeek]+(e.Day==d.Day?" · 今天":""),14,_muted)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel("周"+"日一二三四五六"[(int)date.DayOfWeek]+(e.Day==d.Day?" · 今天":""),14,_muted)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(date.ToString("M月d日"),18,e.Day==d.Day?CareerVisuals.Teal:_ink)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(date.ToString("M月d日"),18,e.Day==d.Day?CareerVisuals.Teal:_ink)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(m==null?e.Title:MatchTitle(d,m),18,_ink,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(m==null?e.Title:MatchTitle(d,m),18,_ink,true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(pair,14,_muted,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(pair,14,_muted,true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(state,15,state=="已报名"?_gold:state=="可报名"?CareerVisuals.Teal:_muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardLabel(state,15,state=="已报名"?_gold:state=="可报名"?CareerVisuals.Teal:_muted)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(string.Join(" · ",new[]{e.Country,roundText,level.HasValue?"进阶 "+level:""}.Where(v=>v.Length>0)),14,_muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardLabel(string.Join(" · ",new[]{e.Country,roundText,level.HasValue?"进阶 "+level:""}.Where(v=>v.Length>0)),14,_muted)`
- `NationalSpire.CareerScreen.Inset(int, int)`；输入表达式：`Inset(0,9)`；返回值紧邻使用处：`AssignmentExpressionSyntax: detail=Inset(0,9)`
- `NationalSpire.CareerScreen.Inset(int, int)`；输入表达式：`Inset(0,9)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Inset(0,9)`
- `NationalSpire.CareerScreen.MatchTitle(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`MatchTitle(d,m)`；返回值紧邻使用处：`ConditionalExpressionSyntax: m==null?e.Title:MatchTitle(d,m)`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("propose-advance",number:m.Day)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !MultiplayerCommand("propose-advance",number:m.Day)`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("propose-register",m.Id,number:1)`；返回值紧邻使用处：`IfStatementSyntax: if(MultiplayerCommand("propose-register",m.Id,number:1)) return;`
- `NationalSpire.CareerScreen.NavigationIcon(string)`；输入表达式：`NavigationIcon("chevron-down")`；返回值紧邻使用处：`AssignmentExpressionSyntax: disclosure.Icon=NavigationIcon("chevron-down")`
- `NationalSpire.CareerScreen.NavigationIcon(string)`；输入表达式：`NavigationIcon(detail.Visible?"chevron-up":"chevron-down")`；返回值紧邻使用处：`AssignmentExpressionSyntax: disclosure.Icon=NavigationIcon(detail.Visible?"chevron-up":"chevron-down")`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(error,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(error,true);`
- `NationalSpire.CareerScreen.OpenCompetition(string)`；输入表达式：`OpenCompetition(e.Cup.Id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>OpenCompetition(e.Cup.Id)`
- `NationalSpire.CareerScreen.OpenReview(string)`；输入表达式：`OpenReview(m.Id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>OpenReview(m.Id)`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.ShowCareerDialog(string, string, System.Func<bool>, string, System.Action<Godot.VBoxContainer>?, bool, bool, string, bool, Godot.StyleBoxFlat?, System.Action<Godot.HBoxContainer, Godot.Button, Godot.Button>?)`；输入表达式：`ShowCareerDialog("跳到比赛日",$"{m.Event}\n推进至{GameCalendar.Text(d,m.Day)}？途中会在需处理的事件处停下。",()=>                      { if(!MultiplayerCommand("propose-advance",number:m.Day)) {CareerEngine.AdvanceToDay(d,m.Day);Render();} return true;})`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>ShowCareerDialog("跳到比赛日",$"{m.Event}\n推进至{GameCalendar.Text(d,m.Day)}？途中会在需处理的事件处停下。",()=>                      { if(!MultiplayerCommand("propose-advance",number:m.Day)) {CareerEngine.AdvanceToDay(d,m.Day);Render();} return true;})`
- `NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`；输入表达式：`TextLink("对局详情",()=>{},13)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =TextLink("对局详情",()=>{},13)`
- `NationalSpire.CareerScreen.Visit(System.Action)`；输入表达式：`Visit(()=>{_tab="赛事";_arenaMatchId=m.Id;})`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>Visit(()=>{_tab="赛事";_arenaMatchId=m.Id;})`
- `NationalSpire.CircuitWorld.RoundName(NationalSpire.WorldCompetition, int)`；输入表达式：`CircuitWorld.RoundName(cup,round)`；返回值紧邻使用处：`ConditionalExpressionSyntax: e.Cup is {Modern:true} cup ? CircuitWorld.RoundName(cup,round) : $"第 {round} 轮"`
- `NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`EsportsWorld.EntryReason(d,m)`；返回值紧邻使用处：`BinaryExpressionSyntax: EsportsWorld.EntryReason(d,m)==null`
- `NationalSpire.FixtureTimelineRow.FixtureTimelineRow()`；输入表达式：`new FixtureTimelineRow {Name="FixtureRow",FirstOfDay=first,CustomMinimumSize=new(0,80)}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new FixtureTimelineRow {Name="FixtureRow",FirstOfDay=first,CustomMinimumSize=new(0,80)}`
- `NationalSpire.FixtureTimelineRow.Highlight(bool)`；输入表达式：`row.Highlight(false)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>row.Highlight(false)`
- `NationalSpire.FixtureTimelineRow.Highlight(bool)`；输入表达式：`row.Highlight(true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>row.Highlight(true)`
- `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Date(d,e.Day)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =GameCalendar.Date(d,e.Day)`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(d,m.Day)`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Text(d,m.Day)}`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join(" · ",new[]{e.Country,roundText,level.HasValue?"进阶 "+level:""}.Where(v=>v.Length>0))`；返回值紧邻使用处：`ArgumentSyntax: string.Join(" · ",new[]{e.Country,roundText,level.HasValue?"进阶 "+level:""}.Where(v=>v.Length>0))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Results.Any(r=>r.MatchId==m.Id)`；返回值紧邻使用处：`IfStatementSyntax: if(d.Results.Any(r=>r.MatchId==m.Id)) action=CaptionButton("查看战报",()=>OpenReview(m.Id));              else if(m.Status=="待赛" && m.Day>=d.Day && m.Registered)                  action=m.Day==d.Day ? CaptionButton("前往赛场",()=>Visit(()=>{_tab="赛事";_arenaMatchId=m.Id;}))                      : CaptionButton("跳到此日",()=>ShowCareerDialog("跳到比赛日",$"{m.Event}\n推进至{GameCalendar.Text(d,m.Day)}？途中会在需处理的事件处停下。",()=>                      { if(!MultiplayerCommand("propose-advance",number:m.Day)) {CareerEngine.AdvanceToDay(d,m.Day);Render();} return true;}));              else if(m.Status=="待赛" && m.Day>=d.Day && EsportsWorld.EntryReason(d,m)==null)                  action=CaptionButton("报名比赛",()=>{if(MultiplayerCommand("propose-register",m.Id,number:1)) return; var error=CareerEngine.SetRegistration(d,m,true); Render(); if(error!=null) Notice(error,true);});`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`new[]{e.Country,roundText,level.HasValue?"进阶 "+level:""}.Where(v=>v.Length>0)`；返回值紧邻使用处：`ArgumentSyntax: new[]{e.Country,roundText,level.HasValue?"进阶 "+level:""}.Where(v=>v.Length>0)`
- `System.DateOnly.ToString(string?)`；输入表达式：`date.ToString("M月d日")`；返回值紧邻使用处：`ArgumentSyntax: date.ToString("M月d日")`

**赋值（含属性/字段和局部值）：**

- `_arenaMatchId` = `m.Id`
- `_tab` = `"赛事"`
- `action.CustomMinimumSize` = `new(FixtureActionWidth,37)`
- `action.Disabled` = `true`
- `action.FocusEntered` += `()=>row.Highlight(true)`
- `action.FocusExited` += `()=>row.Highlight(false)`
- `action.MouseEntered` += `()=>row.Highlight(true)`
- `action.MouseExited` += `()=>row.Highlight(false)`
- `action.SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `action` = `CaptionButton("报名比赛",()=>{if(MultiplayerCommand("propose-register",m.Id,number:1)) return; var error=CareerEngine.SetRegistration(d,m,true); Render(); if(error!=null) Notice(error,true);})`
- `action` = `CaptionButton("查看战报",()=>OpenReview(m.Id))`
- `action` = `CaptionButton("赛事详情",()=>OpenCompetition(e.Cup.Id))`
- `action` = `m.Day==d.Day ? CaptionButton("前往赛场",()=>Visit(()=>{_tab="赛事";_arenaMatchId=m.Id;}))                      : CaptionButton("跳到此日",()=>ShowCareerDialog("跳到比赛日",$"{m.Event}\n推进至{GameCalendar.Text(d,m.Day)}？途中会在需处理的事件处停下。",()=>                      { if(!MultiplayerCommand("propose-advance",number:m.Day)) {CareerEngine.AdvanceToDay(d,m.Day);Render();} return true;}))`
- `Alignment` = `BoxContainer.AlignmentMode.Center`
- `CustomMinimumSize` = `new(0,80)`
- `CustomMinimumSize` = `new(104,0)`
- `CustomMinimumSize` = `new(146,0)`
- `CustomMinimumSize` = `new(20,0)`
- `CustomMinimumSize` = `new(FixtureEndInset,0)`
- `detail.Draw` += `()=>detail.DrawLine(new(13,0),new(13,detail.Size.Y),new Color("68909b80"))`
- `detail.Name` = `"FixtureExpandedDetail"`
- `detail.Visible` = `!detail.Visible`
- `detail` = `Inset(0,9)`
- `disclosure.CustomMinimumSize` = `new(84,26)`
- `disclosure.ExpandIcon` = `true`
- `disclosure.Icon` = `NavigationIcon("chevron-down")`
- `disclosure.Icon` = `NavigationIcon(detail.Visible?"chevron-up":"chevron-down")`
- `disclosure.IconAlignment` = `HorizontalAlignment.Right`
- `disclosure.Pressed` += `()=>{                  if(detail==null)                  {                      detail=Inset(0,9); detail.Name="FixtureExpandedDetail";                      detail.AddThemeConstantOverride("margin_left",156); detail.AddThemeConstantOverride("margin_right",FixtureRowGap+FixtureEndInset);                      timeline.AddChild(detail); timeline.MoveChild(detail,row.GetIndex()+1); detail.AddChild(BracketDetails(d,e.Cup,roundText,[f],round));                      detail.Draw+=()=>detail.DrawLine(new(13,0),new(13,detail.Size.Y),new Color("68909b80"));                  }                  else detail.Visible=!detail.Visible;                  disclosure.Icon=NavigationIcon(detail.Visible?"chevron-up":"chevron-down");              }`
- `disclosure.SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `FirstOfDay` = `first`
- `meta.AutowrapMode` = `TextServer.AutowrapMode.Off`
- `meta.SizeFlagsHorizontal` = `SizeFlags.ShrinkEnd`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"FixtureRow"`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `state` = `"可报名"`
- `status.CustomMinimumSize` = `new(65,0)`
- `status.HorizontalAlignment` = `HorizontalAlignment.Right`
- `status.SizeFlagsHorizontal` = `SizeFlags.ShrinkEnd`

<a id="symbol-f47717b15d24"></a>

## `NationalSpire.CareerScreen.FlagCode(string) — private static string FlagCode(string country)`

来源：源码第 301 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)；[`Side(bool, string, bool)`](FixtureScheduleScreen.cs.md#symbol-766128f05c3d)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6da2999ef4ae"></a>

## `NationalSpire.CareerScreen.TieKey(NationalSpire.WorldCompetition, NationalSpire.WorldFixture) — private static string TieKey(WorldCompetition c,WorldFixture f)`

来源：源码第 302 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)

**调用：** [`NationalSpire.SettlementRecords.FixtureKey(NationalSpire.WorldFixture)`](SettlementRecord.cs.md#symbol-6835127996c4)

**字段、属性、事件及方法组引用：** `NationalSpire.SettlementRecords.FixtureKey(NationalSpire.WorldFixture)`；`NationalSpire.WorldCompetition.TeamEvent`；`NationalSpire.WorldFixture.AwayTeam`；`NationalSpire.WorldFixture.HomeTeam`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.SettlementRecords.FixtureKey(NationalSpire.WorldFixture)`；输入表达式：`SettlementRecords.FixtureKey(f)`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.TeamEvent?f.HomeTeam+"|"+f.AwayTeam:SettlementRecords.FixtureKey(f)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a475f3313082"></a>

## `NationalSpire.CareerScreen.LocalEntrant(NationalSpire.CareerData, string) — private static bool LocalEntrant(CareerData d,string id)`

来源：源码第 303 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)；[`Side(bool, string, bool)`](FixtureScheduleScreen.cs.md#symbol-766128f05c3d)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.LocalHumanId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2ab54bd28e64"></a>

## `NationalSpire.CareerScreen.BracketEntrants(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, bool) — private static IReadOnlyList<string> BracketEntrants(CareerData d, WorldCompetition cup, WorldFixture game, bool home)`

来源：源码第 304 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)；[`Side(bool, string, bool)`](FixtureScheduleScreen.cs.md#symbol-766128f05c3d)

**调用：** [`NationalSpire.SeasonCeremony.Participants(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, bool)`](SeasonCeremony.cs.md#symbol-c038c48114b1)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Season`；`NationalSpire.SeasonCeremony.Participants(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, bool)`；`NationalSpire.WorldCompetition.Cooperative`；`NationalSpire.WorldCompetition.Rosters`；`NationalSpire.WorldCompetition.Season`；`NationalSpire.WorldCompetition.TeamEvent`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.AwayParticipants`；`NationalSpire.WorldFixture.AwayTeam`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.HomeParticipants`；`NationalSpire.WorldFixture.HomeTeam`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.SeasonCeremony.Participants(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, bool)`；输入表达式：`SeasonCeremony.Participants(d,cup,game,home)`；返回值紧邻使用处：`ReturnStatementSyntax: return SeasonCeremony.Participants(d,cup,game,home);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`cup.Rosters.TryGetValue(team,out var roster)`；返回值紧邻使用处：`BinaryExpressionSyntax: cup.TeamEvent && (leader.Length == 0 || leader == team) && cup.Rosters.TryGetValue(team,out var roster)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1daead3fab8e"></a>

## `NationalSpire.CareerScreen.BracketDetails(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, System.Collections.Generic.List<NationalSpire.WorldFixture>, int) — private Control BracketDetails(CareerData data, WorldCompetition cup, string round, List<WorldFixture> tie, int roundNumber)`

来源：源码第 313 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddFixtureRow(NationalSpire.CareerData, NationalSpire.CareerScreen.FixtureEntry, Godot.VBoxContainer, bool)`](FixtureScheduleScreen.cs.md#symbol-237327497b3f)；[`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)

**调用：** [`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CircuitWorld.DayOf(NationalSpire.WorldCompetition, int)`](CircuitWorld.cs.md#symbol-0e5325fbcfe1)；[`NationalSpire.CircuitWorld.KnockoutAscension(NationalSpire.WorldCompetition, int)`](CircuitWorld.cs.md#symbol-6e5ebd93ec3b)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.SettlementRecords.CaptureDuel(NationalSpire.CareerData, NationalSpire.WorldFixture, bool?)`](SettlementRecord.cs.md#symbol-b938ede0e9a5)；[`Side(bool, string, bool)`](FixtureScheduleScreen.cs.md#symbol-766128f05c3d)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Label.Label()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.VBoxContainer.VBoxContainer()`；`NationalSpire.CompetitionDuel.CompetitionDuel()`；`NationalSpire.WorldFixture.WorldFixture()`；`System.Collections.Generic.List<T>.List()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CircuitWorld.DayOf(NationalSpire.WorldCompetition, int)`；`NationalSpire.CircuitWorld.KnockoutAscension(NationalSpire.WorldCompetition, int)`；`NationalSpire.CompetitionDuel.AwayPerformance`；`NationalSpire.CompetitionDuel.HomePerformance`；`NationalSpire.CompetitionDuel.Status`；`NationalSpire.CompetitionDuel.WinnerId`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.SettlementRecords.CaptureDuel(NationalSpire.CareerData, NationalSpire.WorldFixture, bool?)`；`NationalSpire.WorldCompetition.Modern`；`NationalSpire.WorldCompetition.Name`；`NationalSpire.WorldFixture.Ascension`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.Day`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeId`；`Side(bool, string, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`box.AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddThemeConstantOverride("separation", 8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation", 4)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation", 4);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`vs.AddThemeFontSizeOverride("font_size", 12)`；返回值紧邻使用处：`ExpressionStatementSyntax: vs.AddThemeFontSizeOverride("font_size", 12);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Label.Label()`；输入表达式：`new Label { Text = "VS", VerticalAlignment = VerticalAlignment.Center }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { Text = "VS", VerticalAlignment = VerticalAlignment.Center }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(cup.Name + " · " + round, 19, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(cup.Name + " · " + round, 19, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text(date + level + " · " + duel.Status, 14, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text(date + level + " · " + duel.Status, 14, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(vs)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(vs);`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(cup.Name + " · " + round, 19, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text(cup.Name + " · " + round, 19, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(date + level + " · " + duel.Status, 14, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(date + level + " · " + duel.Status, 14, _muted)`
- `NationalSpire.CircuitWorld.DayOf(NationalSpire.WorldCompetition, int)`；输入表达式：`CircuitWorld.DayOf(cup, roundNumber)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Day = CircuitWorld.DayOf(cup, roundNumber)`
- `NationalSpire.CircuitWorld.KnockoutAscension(NationalSpire.WorldCompetition, int)`；输入表达式：`CircuitWorld.KnockoutAscension(cup, roundNumber)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Ascension = CircuitWorld.KnockoutAscension(cup, roundNumber)`
- `NationalSpire.CompetitionDuel.CompetitionDuel()`；输入表达式：`new CompetitionDuel { Status = roundNumber == 1 ? "待抽签" : "待晋级" }`；返回值紧邻使用处：`ConditionalExpressionSyntax: pending ? new CompetitionDuel { Status = roundNumber == 1 ? "待抽签" : "待晋级" } : SettlementRecords.CaptureDuel(data, fixture)`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(data, fixture.Day)`；返回值紧邻使用处：`ConditionalExpressionSyntax: pending && !cup.Modern ? "日期待定" : GameCalendar.Text(data, fixture.Day)`
- `NationalSpire.SettlementRecords.CaptureDuel(NationalSpire.CareerData, NationalSpire.WorldFixture, bool?)`；输入表达式：`SettlementRecords.CaptureDuel(data, fixture)`；返回值紧邻使用处：`ConditionalExpressionSyntax: pending ? new CompetitionDuel { Status = roundNumber == 1 ? "待抽签" : "待晋级" } : SettlementRecords.CaptureDuel(data, fixture)`
- `NationalSpire.WorldFixture.WorldFixture()`；输入表达式：`new() { Day = CircuitWorld.DayOf(cup, roundNumber), Ascension = CircuitWorld.KnockoutAscension(cup, roundNumber) }`；返回值紧邻使用处：`InitializerExpressionSyntax: { new() { Day = CircuitWorld.DayOf(cup, roundNumber), Ascension = CircuitWorld.KnockoutAscension(cup, roundNumber) } }`
- `Side(bool, string, bool)`；输入表达式：`Side(false, duel.AwayPerformance, duel.WinnerId.Length > 0 && duel.WinnerId == fixture.AwayId)`；返回值紧邻使用处：`ExpressionStatementSyntax: Side(false, duel.AwayPerformance, duel.WinnerId.Length > 0 && duel.WinnerId == fixture.AwayId);`
- `Side(bool, string, bool)`；输入表达式：`Side(true, duel.HomePerformance, duel.WinnerId.Length > 0 && duel.WinnerId == fixture.HomeId)`；返回值紧邻使用处：`ExpressionStatementSyntax: Side(true, duel.HomePerformance, duel.WinnerId.Length > 0 && duel.WinnerId == fixture.HomeId);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<WorldFixture> { new() { Day = CircuitWorld.DayOf(cup, roundNumber), Ascension = CircuitWorld.KnockoutAscension(cup, roundNumber) } }`；返回值紧邻使用处：`ConditionalExpressionSyntax: pending              ? new List<WorldFixture> { new() { Day = CircuitWorld.DayOf(cup, roundNumber), Ascension = CircuitWorld.KnockoutAscension(cup, roundNumber) } }              : tie`

**赋值（含属性/字段和局部值）：**

- `Ascension` = `CircuitWorld.KnockoutAscension(cup, roundNumber)`
- `Day` = `CircuitWorld.DayOf(cup, roundNumber)`
- `duel.Status` = `"比赛日"`
- `Status` = `roundNumber == 1 ? "待抽签" : "待晋级"`
- `Text` = `"VS"`
- `VerticalAlignment` = `VerticalAlignment.Center`

<a id="symbol-766128f05c3d"></a>

## `Side(bool, string, bool) — void Side(bool home, string performance, bool won)`

来源：源码第 333 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.BracketDetails(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, System.Collections.Generic.List<NationalSpire.WorldFixture>, int)`](FixtureScheduleScreen.cs.md#symbol-1daead3fab8e)

**调用：** [`NationalSpire.CareerAvatars.MainCharacter(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-b9f8261f2cf2)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerScreen.ArenaCharacterName(string)`](MatchArenaScreen.cs.md#symbol-8a35d94d8045)；[`NationalSpire.CareerScreen.BracketEntrants(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, bool)`](FixtureScheduleScreen.cs.md#symbol-2ab54bd28e64)；[`NationalSpire.CareerScreen.FlagCode(string)`](FixtureScheduleScreen.cs.md#symbol-f47717b15d24)；[`NationalSpire.CareerScreen.LocalEntrant(NationalSpire.CareerData, string)`](FixtureScheduleScreen.cs.md#symbol-a475f3313082)；[`NationalSpire.CareerScreen.NavigationIcon(string)`](CareerDashboard.cs.md#symbol-3c49977c9503)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.EsportsWorld.HistoricCountry(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`](EsportsWorld.cs.md#symbol-9f5901f85a89)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.TextureRect.TextureRect()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`string.IsNullOrEmpty(string?)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAvatars.MainCharacter(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.ArenaCharacterName(string)`；`NationalSpire.CareerScreen.BracketEntrants(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, bool)`；`NationalSpire.CareerScreen.FlagCode(string)`；`NationalSpire.CareerScreen.LocalEntrant(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.NavigationIcon(string)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.CompetitionDuel.Status`；`NationalSpire.EsportsWorld.HistoricCountry(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`line.AddThemeConstantOverride("separation", 6)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddThemeConstantOverride("separation", 6);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`side.AddThemeConstantOverride("separation", 3)`；返回值紧邻使用处：`ExpressionStatementSyntax: side.AddThemeConstantOverride("separation", 3);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box(playerMatch ? "493d28" : won ? "15362f" : "172c38", playerMatch ? "e6bd65" : won ? "4c7066" : "324a57", 4, 8))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box(playerMatch ? "493d28" : won ? "15362f" : "172c38", playerMatch ? "e6bd65" : won ? "4c7066" : "324a57", 4, 8));`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(new TextureRect { Texture = flag, CustomMinimumSize = new(20, 15),                              ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered })`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(new TextureRect { Texture = flag, CustomMinimumSize = new(20, 15),                              ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(Text(CareerEngine.DisplayName(data, player), 16, LocalEntrant(data,player) ? _gold : won ? CareerVisuals.Teal : _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(Text(CareerEngine.DisplayName(data, player), 16, LocalEntrant(data,player) ? _gold : won ? CareerVisuals.Teal : _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(side)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(side);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`side.AddChild(line)`；返回值紧邻使用处：`ExpressionStatementSyntax: side.AddChild(line);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`side.AddChild(Text("角色待定", 13, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: side.AddChild(Text("角色待定", 13, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`side.AddChild(Text(ArenaCharacterName(string.IsNullOrEmpty(character) ? CareerAvatars.MainCharacter(data, player) : character), 13, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: side.AddChild(Text(ArenaCharacterName(string.IsNullOrEmpty(character) ? CareerAvatars.MainCharacter(data, player) : character), 13, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`side.AddChild(Text(duel.Status, 16, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: side.AddChild(Text(duel.Status, 16, _ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`side.AddChild(Text(performance.Length > 0 ? performance : pending ? "待赛" : duel.Status, 14, _ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: side.AddChild(Text(performance.Length > 0 ? performance : pending ? "待赛" : duel.Status, 14, _ink));`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { SizeFlagsHorizontal = SizeFlags.ExpandFill }`
- `Godot.TextureRect.TextureRect()`；输入表达式：`new TextureRect { Texture = flag, CustomMinimumSize = new(20, 15),                              ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered }`；返回值紧邻使用处：`ArgumentSyntax: new TextureRect { Texture = flag, CustomMinimumSize = new(20, 15),                              ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = TextureRect.StretchModeEnum.KeepAspectCentered }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(20, 15)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(20, 15)`
- `NationalSpire.CareerAvatars.MainCharacter(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.MainCharacter(data, player)`；返回值紧邻使用处：`ConditionalExpressionSyntax: string.IsNullOrEmpty(character) ? CareerAvatars.MainCharacter(data, player) : character`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, player)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.DisplayName(data, player)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, player)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CareerEngine.Person(data, player)?.Character`
- `NationalSpire.CareerScreen.ArenaCharacterName(string)`；输入表达式：`ArenaCharacterName(string.IsNullOrEmpty(character) ? CareerAvatars.MainCharacter(data, player) : character)`；返回值紧邻使用处：`ArgumentSyntax: ArenaCharacterName(string.IsNullOrEmpty(character) ? CareerAvatars.MainCharacter(data, player) : character)`
- `NationalSpire.CareerScreen.BracketEntrants(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, bool)`；输入表达式：`BracketEntrants(data,cup,fixture,home)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = BracketEntrants(data,cup,fixture,home)`
- `NationalSpire.CareerScreen.FlagCode(string)`；输入表达式：`FlagCode(country)`；返回值紧邻使用处：`BinaryExpressionSyntax: "flag-" + FlagCode(country)`
- `NationalSpire.CareerScreen.LocalEntrant(NationalSpire.CareerData, string)`；输入表达式：`LocalEntrant(data,id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => LocalEntrant(data,id)`
- `NationalSpire.CareerScreen.LocalEntrant(NationalSpire.CareerData, string)`；输入表达式：`LocalEntrant(data,player)`；返回值紧邻使用处：`ConditionalExpressionSyntax: LocalEntrant(data,player) ? _gold : won ? CareerVisuals.Teal : _ink`
- `NationalSpire.CareerScreen.NavigationIcon(string)`；输入表达式：`NavigationIcon("flag-" + FlagCode(country))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = NavigationIcon("flag-" + FlagCode(country))`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("角色待定", 13, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("角色待定", 13, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(ArenaCharacterName(string.IsNullOrEmpty(character) ? CareerAvatars.MainCharacter(data, player) : character), 13, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(ArenaCharacterName(string.IsNullOrEmpty(character) ? CareerAvatars.MainCharacter(data, player) : character), 13, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(CareerEngine.DisplayName(data, player), 16, LocalEntrant(data,player) ? _gold : won ? CareerVisuals.Teal : _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(CareerEngine.DisplayName(data, player), 16, LocalEntrant(data,player) ? _gold : won ? CareerVisuals.Teal : _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(duel.Status, 16, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(duel.Status, 16, _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(performance.Length > 0 ? performance : pending ? "待赛" : duel.Status, 14, _ink)`；返回值紧邻使用处：`ArgumentSyntax: Text(performance.Length > 0 ? performance : pending ? "待赛" : duel.Status, 14, _ink)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(playerMatch ? "493d28" : won ? "15362f" : "172c38", playerMatch ? "e6bd65" : won ? "4c7066" : "324a57", 4, 8)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box(playerMatch ? "493d28" : won ? "15362f" : "172c38", playerMatch ? "e6bd65" : won ? "4c7066" : "324a57", 4, 8)`
- `NationalSpire.EsportsWorld.HistoricCountry(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`；输入表达式：`EsportsWorld.HistoricCountry(data, cup, player)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = EsportsWorld.HistoricCountry(data, cup, player)`
- `string.IsNullOrEmpty(string?)`；输入表达式：`string.IsNullOrEmpty(character)`；返回值紧邻使用处：`ConditionalExpressionSyntax: string.IsNullOrEmpty(character) ? CareerAvatars.MainCharacter(data, player) : character`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`players.Any(id => LocalEntrant(data,id))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = players.Any(id => LocalEntrant(data,id))`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(20, 15)`
- `ExpandMode` = `TextureRect.ExpandModeEnum.IgnoreSize`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `StretchMode` = `TextureRect.StretchModeEnum.KeepAspectCentered`
- `Texture` = `flag`

<a id="symbol-9df8f68cfc8f"></a>

## `NationalSpire.CareerScreen.BracketRoundName(int) — private static string BracketRoundName(int remaining)`

来源：源码第 373 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-992db6cc73f9"></a>

## `NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer) — private void InternationalBracket(CareerData d, WorldCompetition c,HBoxContainer toolbar)`

来源：源码第 379 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.FixtureSchedule(NationalSpire.CareerData)`](FixtureScheduleScreen.cs.md#symbol-e95df6046805)

**调用：** [`AddHeading(Godot.Control, string, string, bool, bool)`](FixtureScheduleScreen.cs.md#symbol-c9c5e134a317)；[`AlignHeadings()`](FixtureScheduleScreen.cs.md#symbol-4d9584ac0b60)；[`Locate()`](FixtureScheduleScreen.cs.md#symbol-f09c19694fee)；[`LocateAfterLayout()`](FixtureScheduleScreen.cs.md#symbol-230d9e58c65c)；[`NationalSpire.BracketColumns.AddSlot(int, Godot.Control)`](FixtureScheduleScreen.cs.md#symbol-de909d9445cb)；[`NationalSpire.BracketColumns.ConnectInvitation(Godot.Control)`](FixtureScheduleScreen.cs.md#symbol-0b92c59df100)；[`NationalSpire.BracketColumns.MarkAdvanced(Godot.Control)`](FixtureScheduleScreen.cs.md#symbol-fd2e6d82e689)；[`NationalSpire.BracketInspector.Attach(Godot.Control, Godot.ScrollContainer)`](BracketInspector.cs.md#symbol-ddfed770fc0f)；[`NationalSpire.BracketInspector.Bind(Godot.Button, System.Func<Godot.Control>)`](BracketInspector.cs.md#symbol-955dfacc5bbe)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`](DashboardControls.cs.md#symbol-5fcff8206cb6)；[`NationalSpire.CareerScreen.BracketDetails(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, System.Collections.Generic.List<NationalSpire.WorldFixture>, int)`](FixtureScheduleScreen.cs.md#symbol-1daead3fab8e)；[`NationalSpire.CareerScreen.BracketEntrants(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, bool)`](FixtureScheduleScreen.cs.md#symbol-2ab54bd28e64)；[`NationalSpire.CareerScreen.BracketRoundName(int)`](FixtureScheduleScreen.cs.md#symbol-9df8f68cfc8f)；[`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`](DashboardControls.cs.md#symbol-0374e90f1c3f)；[`NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`](CareerDashboard.cs.md#symbol-22831701f7f1)；[`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.FlagCode(string)`](FixtureScheduleScreen.cs.md#symbol-f47717b15d24)；[`NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`](DashboardControls.cs.md#symbol-d6b849a02619)；[`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`](DashboardControls.cs.md#symbol-23c9e2f4b76f)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.Inset(int, int)`](DashboardControls.cs.md#symbol-ebb2fedbb4fc)；[`NationalSpire.CareerScreen.LocalEntrant(NationalSpire.CareerData, string)`](FixtureScheduleScreen.cs.md#symbol-a475f3313082)；[`NationalSpire.CareerScreen.NavigationIcon(string)`](CareerDashboard.cs.md#symbol-3c49977c9503)；[`NationalSpire.CareerScreen.OpenCompetition(string)`](CareerNavigation.cs.md#symbol-d88417a19f38)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerScreen.TieKey(NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`](FixtureScheduleScreen.cs.md#symbol-6da2999ef4ae)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.CircuitWorld.DayOf(NationalSpire.WorldCompetition, int)`](CircuitWorld.cs.md#symbol-0e5325fbcfe1)；[`NationalSpire.CircuitWorld.RoundCount(NationalSpire.WorldCompetition)`](CircuitWorld.cs.md#symbol-95620df3f1f6)；[`NationalSpire.CircuitWorld.TeamName(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`](CircuitWorld.cs.md#symbol-74904a83d22a)；[`NationalSpire.EsportsWorld.HistoricCountry(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`](EsportsWorld.cs.md#symbol-9f5901f85a89)；[`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-8a08be365f83)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-12bdfe5d4265)；[`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-ee7b01d76b23)；[`ResizeBracket()`](FixtureScheduleScreen.cs.md#symbol-d5cfa78289ac)；[`Zoom(float, Godot.Vector2)`](FixtureScheduleScreen.cs.md#symbol-e47c780a6abf)；`Godot.Button.Button()`；`Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；`Godot.Color.Color(string)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.Control()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.SetMeta(Godot.StringName, Godot.Variant)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Label.Label()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.ScrollContainer.GetHScrollBar()`；`Godot.StyleBoxFlat.SetBorderWidthAll(int)`；`Godot.StyleBoxFlat.StyleBoxFlat()`；`Godot.TextureRect.TextureRect()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`int.ToString()`；`NationalSpire.BracketColumns.BracketColumns()`；`NationalSpire.BracketInspector.BracketInspector()`；`NationalSpire.ZoomableBracketScroll.ZoomableBracketScroll()`；`System.Collections.Generic.IEnumerable<int>.Max()`；`System.Collections.Generic.IEnumerable<int>.Min()`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.List()`；`System.DateOnly.ToString(string?)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `AddHeading(Godot.Control, string, string, bool, bool)`；`AlignHeadings()`；`Locate()`；`LocateAfterLayout()`；`NationalSpire.BracketColumns.AddSlot(int, Godot.Control)`；`NationalSpire.BracketColumns.ConnectInvitation(Godot.Control)`；`NationalSpire.BracketColumns.MarkAdvanced(Godot.Control)`；`NationalSpire.BracketInspector.Attach(Godot.Control, Godot.ScrollContainer)`；`NationalSpire.BracketInspector.Bind(Godot.Button, System.Func<Godot.Control>)`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.Registered`；`NationalSpire.CareerMatch.RequiredAscension`；`NationalSpire.CareerResult.Ascension`；`NationalSpire.CareerResult.Day`；`NationalSpire.CareerResult.Kind`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.CareerResult.Opponent`；`NationalSpire.CareerResult.Settlement`；`NationalSpire.CareerScreen._bracketZoom`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._stage`；`NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`；`NationalSpire.CareerScreen.BracketDetails(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, System.Collections.Generic.List<NationalSpire.WorldFixture>, int)`；`NationalSpire.CareerScreen.BracketEntrants(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, bool)`；`NationalSpire.CareerScreen.BracketRoundName(int)`；`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；`NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.FlagCode(string)`；`NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.Inset(int, int)`；`NationalSpire.CareerScreen.LocalEntrant(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.NavigationIcon(string)`；`NationalSpire.CareerScreen.OpenCompetition(string)`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.TieKey(NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.CircuitWorld.DayOf(NationalSpire.WorldCompetition, int)`；`NationalSpire.CircuitWorld.RoundCount(NationalSpire.WorldCompetition)`；`NationalSpire.CircuitWorld.TeamName(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsWorld.HistoricCountry(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`；`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；`NationalSpire.SettlementRecord.Season`；`NationalSpire.WorldCompetition.Finished`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Modern`；`NationalSpire.WorldCompetition.Season`；`NationalSpire.WorldCompetition.TeamEvent`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.AwayTeam`；`NationalSpire.WorldFixture.Day`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.HomeTeam`；`NationalSpire.WorldFixture.Round`；`NationalSpire.WorldFixture.WinnerId`；`NationalSpire.ZoomableBracketScroll.ZoomStep`；`ResizeBracket()`；`Zoom(float, Godot.Vector2)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `AddHeading(Godot.Control, string, string, bool, bool)`；输入表达式：`AddHeading(invitationColumn,"世界纪录邀请赛",GameCalendar.Date(d,invitationDay).ToString("M月d日"),false,true)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddHeading(invitationColumn,"世界纪录邀请赛",GameCalendar.Date(d,invitationDay).ToString("M月d日"),false,true);`
- `AddHeading(Godot.Control, string, string, bool, bool)`；输入表达式：`AddHeading(panel, roundName, day > 0 ? GameCalendar.Date(d, day).ToString("M月d日") : "", currentRound)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddHeading(panel, roundName, day > 0 ? GameCalendar.Date(d, day).ToString("M月d日") : "", currentRound);`
- `AlignHeadings()`；输入表达式：`AlignHeadings()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _=>AlignHeadings()`
- `Godot.Button.Button()`；输入表达式：`new Button { Name = $"BracketMatch_{round}_{i}", Flat = true,                      CustomMinimumSize = new(0, cardHeight), MouseDefaultCursorShape = CursorShape.PointingHand }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Name = $"BracketMatch_{round}_{i}", Flat = true,                      CustomMinimumSize = new(0, cardHeight), MouseDefaultCursorShape = CursorShape.PointingHand }`
- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(()=>{if(IsInstanceValid(inset))ResizeBracket();}).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(()=>{if(IsInstanceValid(inset))ResizeBracket();}).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(()=>{if(IsInstanceValid(inset))ResizeBracket();})`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(()=>{if(IsInstanceValid(inset))ResizeBracket();}).CallDeferred`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`head.DrawLine(new(0,head.Size.Y-1),new(head.Size.X,head.Size.Y-1),new Color("344954"))`；返回值紧邻使用处：`ExpressionStatementSyntax: head.DrawLine(new(0,head.Size.Y-1),new(head.Size.X,head.Size.Y-1),new Color("344954"));`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；输入表达式：`head.DrawRect(new Rect2(Vector2.Zero,head.Size),new Color("162a36"))`；返回值紧邻使用处：`ExpressionStatementSyntax: head.DrawRect(new Rect2(Vector2.Zero,head.Size),new Color("162a36"));`
- `Godot.Color.Color(string)`；输入表达式：`new Color("162a36")`；返回值紧邻使用处：`ArgumentSyntax: new Color("162a36")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("344954")`；返回值紧邻使用处：`ArgumentSyntax: new Color("344954")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("80e7db70")`；返回值紧邻使用处：`AssignmentExpressionSyntax: BorderColor=new Color("80e7db70")`
- `Godot.Color.Color(string)`；输入表达式：`new Color(currentRound ? "80e7db0a" : "00000000")`；返回值紧邻使用处：`AssignmentExpressionSyntax: BgColor=new Color(currentRound ? "80e7db0a" : "00000000")`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`winner.AddThemeColorOverride("font_color", player ? _gold : CareerVisuals.Teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: winner.AddThemeColorOverride("font_color", player ? _gold : CareerVisuals.Teal);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`col.AddThemeConstantOverride("separation", 0)`；返回值紧邻使用处：`ExpressionStatementSyntax: col.AddThemeConstantOverride("separation", 0);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`columns.AddThemeConstantOverride("separation",38)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddThemeConstantOverride("separation",38);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`content.AddThemeConstantOverride("separation", 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddThemeConstantOverride("separation", 1);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`entrant.AddThemeConstantOverride("separation", 8)`；返回值紧邻使用处：`ExpressionStatementSyntax: entrant.AddThemeConstantOverride("separation", 8);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`info.AddThemeConstantOverride("separation",2)`；返回值紧邻使用处：`ExpressionStatementSyntax: info.AddThemeConstantOverride("separation",2);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`layout.AddThemeConstantOverride("separation",0)`；返回值紧邻使用处：`ExpressionStatementSyntax: layout.AddThemeConstantOverride("separation",0);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`pair.AddThemeConstantOverride("separation", 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: pair.AddThemeConstantOverride("separation", 1);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`roster.AddThemeConstantOverride("separation", 4)`；返回值紧邻使用处：`ExpressionStatementSyntax: roster.AddThemeConstantOverride("separation", 4);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`stack.AddThemeConstantOverride("separation",0)`；返回值紧邻使用处：`ExpressionStatementSyntax: stack.AddThemeConstantOverride("separation",0);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`winner.AddThemeFontSizeOverride("font_size", 13)`；返回值紧邻使用处：`ExpressionStatementSyntax: winner.AddThemeFontSizeOverride("font_size", 13);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`band.AddThemeStyleboxOverride("panel", CareerVisuals.Box("172b37", "344954", 4, 4))`；返回值紧邻使用处：`ExpressionStatementSyntax: band.AddThemeStyleboxOverride("panel", CareerVisuals.Box("172b37", "344954", 4, 4));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`band.AddThemeStyleboxOverride("panel",bg)`；返回值紧邻使用处：`ExpressionStatementSyntax: band.AddThemeStyleboxOverride("panel",bg);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`frame.AddThemeStyleboxOverride("panel",CareerVisuals.Box("0e1c28","334d58",6,1))`；返回值紧邻使用处：`ExpressionStatementSyntax: frame.AddThemeStyleboxOverride("panel",CareerVisuals.Box("0e1c28","334d58",6,1));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel",style)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel",style);`
- `Godot.Control.Control()`；输入表达式：`new Control {Name="BracketHeadings",ClipContents=true,CustomMinimumSize=new(0,56),MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Control {Name="BracketHeadings",ClipContents=true,CustomMinimumSize=new(0,56),MouseFilter=MouseFilterEnum.Ignore}`
- `Godot.Control.Control()`；输入表达式：`new Control {SizeFlagsHorizontal=SizeFlags.ExpandFill}`；返回值紧邻使用处：`ArgumentSyntax: new Control {SizeFlagsHorizontal=SizeFlags.ExpandFill}`
- `Godot.Control.Control()`；输入表达式：`new Control{MouseFilter=MouseFilterEnum.Pass}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Control{MouseFilter=MouseFilterEnum.Pass}`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`pair.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: pair.SetAnchorsAndOffsetsPreset(LayoutPreset.FullRect);`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(inset)`；返回值紧邻使用处：`IfStatementSyntax: if(IsInstanceValid(inset))ResizeBracket();`
- `Godot.GodotObject.SetMeta(Godot.StringName, Godot.Variant)`；输入表达式：`frame.SetMeta("competition_id",c.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: frame.SetMeta("competition_id",c.Id);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Label.Label()`；输入表达式：`new Label { Text = c.TeamEvent ? (left ? home : away).ToString() : "胜", MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Label { Text = c.TeamEvent ? (left ? home : away).ToString() : "胜", MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.Label.Label()`；输入表达式：`new Label{Text=$"{_bracketZoom:P0}",CustomMinimumSize=new(54,0),HorizontalAlignment=HorizontalAlignment.Center}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Label{Text=$"{_bracketZoom:P0}",CustomMinimumSize=new(54,0),HorizontalAlignment=HorizontalAlignment.Center}`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_content.AddChild(frame)`；返回值紧邻使用处：`ExpressionStatementSyntax: _content.AddChild(frame);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`band.AddChild(content)`；返回值紧邻使用处：`ExpressionStatementSyntax: band.AddChild(content);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`band.AddChild(Text(round == 1 ? "▫   待抽签" : "▫   待晋级", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: band.AddChild(Text(round == 1 ? "▫   待抽签" : "▫   待晋级", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text("对手："+opponent,18,_ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text("对手："+opponent,18,_ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text("世界纪录邀请赛",22,_gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text("世界纪录邀请赛",22,_gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text("受邀资格：国际赛事冠军、生涯赛事进阶 9 通关。",17,_ink))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text("受邀资格：国际赛事冠军、生涯赛事进阶 9 通关。",17,_ink));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(Text(GameCalendar.Text(d,invitationDay)+" · 进阶 "+ascension,16,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(Text(GameCalendar.Text(d,invitationDay)+" · 进阶 "+ascension,16,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`col.AddChild(slot)`；返回值紧邻使用处：`ExpressionStatementSyntax: col.AddChild(slot);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`columns.AddChild(invitationColumn)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddChild(invitationColumn);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`columns.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(entrant)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(entrant);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`content.AddChild(roster)`；返回值紧邻使用处：`ExpressionStatementSyntax: content.AddChild(roster);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`entrant.AddChild(label)`；返回值紧邻使用处：`ExpressionStatementSyntax: entrant.AddChild(label);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`entrant.AddChild(new TextureRect{Texture=NavigationIcon("flag-"+flag),CustomMinimumSize=new(20,15),                          ExpandMode=TextureRect.ExpandModeEnum.IgnoreSize,StretchMode=TextureRect.StretchModeEnum.KeepAspectCentered,MouseFilter=MouseFilterEnum.Ignore})`；返回值紧邻使用处：`ExpressionStatementSyntax: entrant.AddChild(new TextureRect{Texture=NavigationIcon("flag-"+flag),CustomMinimumSize=new(20,15),                          ExpandMode=TextureRect.ExpandModeEnum.IgnoreSize,StretchMode=TextureRect.StretchModeEnum.KeepAspectCentered,MouseFilter=MouseFilterEnum.Ignore});`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`entrant.AddChild(winner)`；返回值紧邻使用处：`ExpressionStatementSyntax: entrant.AddChild(winner);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`extent.AddChild(inset)`；返回值紧邻使用处：`ExpressionStatementSyntax: extent.AddChild(inset);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`info.AddChild(criteria)`；返回值紧邻使用处：`ExpressionStatementSyntax: info.AddChild(criteria);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`info.AddChild(title)`；返回值紧邻使用处：`ExpressionStatementSyntax: info.AddChild(title);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`info.AddChild(trophy)`；返回值紧邻使用处：`ExpressionStatementSyntax: info.AddChild(trophy);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inset.AddChild(columns)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.AddChild(columns);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`invitationColumn.AddChild(stack)`；返回值紧邻使用处：`ExpressionStatementSyntax: invitationColumn.AddChild(stack);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`layout.AddChild(head)`；返回值紧邻使用处：`ExpressionStatementSyntax: layout.AddChild(head);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`layout.AddChild(scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: layout.AddChild(scroll);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`matchCard.AddChild(pair)`；返回值紧邻使用处：`ExpressionStatementSyntax: matchCard.AddChild(pair);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`pair.AddChild(band)`；返回值紧邻使用处：`ExpressionStatementSyntax: pair.AddChild(band);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(col)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(col);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`roster.AddChild(name)`；返回值紧邻使用处：`ExpressionStatementSyntax: roster.AddChild(name);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scroll.AddChild(extent)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.AddChild(extent);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`slot.AddChild(matchCard)`；返回值紧邻使用处：`ExpressionStatementSyntax: slot.AddChild(matchCard);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`stack.AddChild(invitationSlot)`；返回值紧邻使用处：`ExpressionStatementSyntax: stack.AddChild(invitationSlot);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`toolbar.AddChild(CaptionButton("赛事详情", () => OpenCompetition(c.Id)))`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddChild(CaptionButton("赛事详情", () => OpenCompetition(c.Id)));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`toolbar.AddChild(FramedAction("+",()=>Zoom(_bracketZoom+.1f,scroll.Size/2),width:42,height:36,quiet:true))`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddChild(FramedAction("+",()=>Zoom(_bracketZoom+.1f,scroll.Size/2),width:42,height:36,quiet:true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`toolbar.AddChild(FramedAction("−",()=>Zoom(_bracketZoom-.1f,scroll.Size/2),width:42,height:36,quiet:true))`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddChild(FramedAction("−",()=>Zoom(_bracketZoom-.1f,scroll.Size/2),width:42,height:36,quiet:true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`toolbar.AddChild(FramedAction("定位轮次",()=>{scroll.ScrollVertical=0;Locate();},"locate-fixed",width:118,height:38,quiet:true))`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddChild(FramedAction("定位轮次",()=>{scroll.ScrollVertical=0;Locate();},"locate-fixed",width:118,height:38,quiet:true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`toolbar.AddChild(new Control {SizeFlagsHorizontal=SizeFlags.ExpandFill})`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddChild(new Control {SizeFlagsHorizontal=SizeFlags.ExpandFill});`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`toolbar.AddChild(progress)`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddChild(progress);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`toolbar.AddChild(reset)`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddChild(reset);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`toolbar.AddChild(zoomText)`；返回值紧邻使用处：`ExpressionStatementSyntax: toolbar.AddChild(zoomText);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { MouseFilter = MouseFilterEnum.Ignore, SizeFlagsVertical = SizeFlags.ExpandFill }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { MouseFilter = MouseFilterEnum.Ignore, SizeFlagsVertical = SizeFlags.ExpandFill }`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer {CustomMinimumSize=new(274,0)}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new PanelContainer {CustomMinimumSize=new(274,0)}`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer {MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new PanelContainer {MouseFilter=MouseFilterEnum.Ignore}`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer {Name="BracketFrame",CustomMinimumSize=new(0,712)}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new PanelContainer {Name="BracketFrame",CustomMinimumSize=new(0,712)}`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero,head.Size)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(Vector2.Zero,head.Size)`
- `Godot.ScrollContainer.GetHScrollBar()`；输入表达式：`scroll.GetHScrollBar()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: scroll.GetHScrollBar().ValueChanged`
- `Godot.StyleBoxFlat.SetBorderWidthAll(int)`；输入表达式：`style.SetBorderWidthAll(currentRound ? 1 : 0)`；返回值紧邻使用处：`ExpressionStatementSyntax: style.SetBorderWidthAll(currentRound ? 1 : 0);`
- `Godot.StyleBoxFlat.StyleBoxFlat()`；输入表达式：`new StyleBoxFlat {BgColor=new Color(currentRound ? "80e7db0a" : "00000000"),BorderColor=new Color("80e7db70"),ContentMarginLeft=9,ContentMarginRight=9,ContentMarginTop=9,ContentMarginBottom=9}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new StyleBoxFlat {BgColor=new Color(currentRound ? "80e7db0a" : "00000000"),BorderColor=new Color("80e7db70"),ContentMarginLeft=9,ContentMarginRight=9,ContentMarginTop=9,ContentMarginBottom=9}`
- `Godot.TextureRect.TextureRect()`；输入表达式：`new TextureRect{Texture=NavigationIcon("flag-"+flag),CustomMinimumSize=new(20,15),                          ExpandMode=TextureRect.ExpandModeEnum.IgnoreSize,StretchMode=TextureRect.StretchModeEnum.KeepAspectCentered,MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`ArgumentSyntax: new TextureRect{Texture=NavigationIcon("flag-"+flag),CustomMinimumSize=new(20,15),                          ExpandMode=TextureRect.ExpandModeEnum.IgnoreSize,StretchMode=TextureRect.StretchModeEnum.KeepAspectCentered,MouseFilter=MouseFilterEnum.Ignore}`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { CustomMinimumSize=new(0,Math.Max(60,firstTies*pitch)),Alignment=BoxContainer.AlignmentMode.Center }`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer { CustomMinimumSize=new(0,Math.Max(60,firstTies*pitch)),Alignment=BoxContainer.AlignmentMode.Center }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore, Alignment = BoxContainer.AlignmentMode.Center }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer { MouseFilter = MouseFilterEnum.Ignore, Alignment = BoxContainer.AlignmentMode.Center }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer {Alignment=BoxContainer.AlignmentMode.Center}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer {Alignment=BoxContainer.AlignmentMode.Center}`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer {CustomMinimumSize=new(0,Math.Max(60,firstTies*pitch/slots)),Alignment=BoxContainer.AlignmentMode.Center}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer {CustomMinimumSize=new(0,Math.Max(60,firstTies*pitch/slots)),Alignment=BoxContainer.AlignmentMode.Center}`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, cardHeight)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, cardHeight)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,56)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,56)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,712)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,712)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,head.Size.Y-1)`；返回值紧邻使用处：`ArgumentSyntax: new(0,head.Size.Y-1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,Math.Max(60,firstTies*pitch))`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,Math.Max(60,firstTies*pitch))`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,Math.Max(60,firstTies*pitch/slots))`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(0,Math.Max(60,firstTies*pitch/slots))`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(20,15)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(20,15)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(274,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(274,0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(274,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: invitationColumn.CustomMinimumSize=new(274,0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(54,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(54,0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(head.Size.X,head.Size.Y-1)`；返回值紧邻使用处：`ArgumentSyntax: new(head.Size.X,head.Size.Y-1)`
- `int.ToString()`；输入表达式：`(left ? home : away).ToString()`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.TeamEvent ? (left ? home : away).ToString() : "胜"`
- `Locate()`；输入表达式：`Locate()`；返回值紧邻使用处：`ExpressionStatementSyntax: Locate();`
- `LocateAfterLayout()`；输入表达式：`LocateAfterLayout()`；返回值紧邻使用处：`ExpressionStatementSyntax: LocateAfterLayout();`
- `NationalSpire.BracketColumns.AddSlot(int, Godot.Control)`；输入表达式：`columns.AddSlot(round,matchCard)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.AddSlot(round,matchCard);`
- `NationalSpire.BracketColumns.BracketColumns()`；输入表达式：`new BracketColumns()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new BracketColumns()`
- `NationalSpire.BracketColumns.ConnectInvitation(Godot.Control)`；输入表达式：`columns.ConnectInvitation(invitation)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.ConnectInvitation(invitation);`
- `NationalSpire.BracketColumns.MarkAdvanced(Godot.Control)`；输入表达式：`columns.MarkAdvanced(matchCard)`；返回值紧邻使用处：`ExpressionStatementSyntax: columns.MarkAdvanced(matchCard);`
- `NationalSpire.BracketInspector.Attach(Godot.Control, Godot.ScrollContainer)`；输入表达式：`inspector.Attach(_stage,scroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: inspector.Attach(_stage,scroll);`
- `NationalSpire.BracketInspector.Bind(Godot.Button, System.Func<Godot.Control>)`；输入表达式：`inspector.Bind(invitation,()=>{                  var body=new VBoxContainer();                  body.AddChild(Text("世界纪录邀请赛",22,_gold));                  body.AddChild(Text(GameCalendar.Text(d,invitationDay)+" · 进阶 "+ascension,16,_muted));                  body.AddChild(Text("受邀资格：国际赛事冠军、生涯赛事进阶 9 通关。",17,_ink));                  body.AddChild(Text("对手："+opponent,18,_ink)); return body;              })`；返回值紧邻使用处：`ExpressionStatementSyntax: inspector.Bind(invitation,()=>{                  var body=new VBoxContainer();                  body.AddChild(Text("世界纪录邀请赛",22,_gold));                  body.AddChild(Text(GameCalendar.Text(d,invitationDay)+" · 进阶 "+ascension,16,_muted));                  body.AddChild(Text("受邀资格：国际赛事冠军、生涯赛事进阶 9 通关。",17,_ink));                  body.AddChild(Text("对手："+opponent,18,_ink)); return body;              });`
- `NationalSpire.BracketInspector.Bind(Godot.Button, System.Func<Godot.Control>)`；输入表达式：`inspector.Bind(matchCard, () => BracketDetails(d, c, roundName, [], roundNumber))`；返回值紧邻使用处：`ExpressionStatementSyntax: inspector.Bind(matchCard, () => BracketDetails(d, c, roundName, [], roundNumber));`
- `NationalSpire.BracketInspector.Bind(Godot.Button, System.Func<Godot.Control>)`；输入表达式：`inspector.Bind(matchCard, () => BracketDetails(d, c, roundName, tie, roundNumber))`；返回值紧邻使用处：`ExpressionStatementSyntax: inspector.Bind(matchCard, () => BracketDetails(d, c, roundName, tie, roundNumber));`
- `NationalSpire.BracketInspector.BracketInspector()`；输入表达式：`new BracketInspector()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BracketInspector()`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, member)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.DisplayName(d, member)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d,id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.TeamEvent?CircuitWorld.TeamName(d,c,team):CareerEngine.DisplayName(d,id)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d,invite.OpponentId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: invite != null ? CareerEngine.DisplayName(d,invite.OpponentId) : result!.Opponent`
- `NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`；输入表达式：`ActionRow(invitationSlot,"InvitationCard","世界纪录邀请赛",()=>{},info,104,6,4,"282d29","958264","383d34")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ActionRow(invitationSlot,"InvitationCard","世界纪录邀请赛",()=>{},info,104,6,4,"282d29","958264","383d34")`
- `NationalSpire.CareerScreen.BracketDetails(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, System.Collections.Generic.List<NationalSpire.WorldFixture>, int)`；输入表达式：`BracketDetails(d, c, roundName, [], roundNumber)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => BracketDetails(d, c, roundName, [], roundNumber)`
- `NationalSpire.CareerScreen.BracketDetails(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, System.Collections.Generic.List<NationalSpire.WorldFixture>, int)`；输入表达式：`BracketDetails(d, c, roundName, tie, roundNumber)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => BracketDetails(d, c, roundName, tie, roundNumber)`
- `NationalSpire.CareerScreen.BracketEntrants(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, bool)`；输入表达式：`BracketEntrants(d,c,game,false)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: game => BracketEntrants(d,c,game,false)`
- `NationalSpire.CareerScreen.BracketEntrants(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, bool)`；输入表达式：`BracketEntrants(d,c,game,true)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: game => BracketEntrants(d,c,game,true)`
- `NationalSpire.CareerScreen.BracketRoundName(int)`；输入表达式：`BracketRoundName(count-active+1)`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.Fixtures.Count==0?"待抽签":BracketRoundName(count-active+1)`
- `NationalSpire.CareerScreen.BracketRoundName(int)`；输入表达式：`BracketRoundName(count-round+1)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = BracketRoundName(count-round+1)`
- `NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；输入表达式：`ButtonSurface(invitation,"493d28","e6bd65","51422b","ffe09a",0)`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonSurface(invitation,"493d28","e6bd65","51422b","ffe09a",0);`
- `NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；输入表达式：`ButtonSurface(matchCard,"182c39","405967","1b323e","80e7db",0)`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonSurface(matchCard,"182c39","405967","1b323e","80e7db",0);`
- `NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；输入表达式：`ButtonSurface(matchCard,"383026","e6bd65","51422b","ffe09a",0)`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonSurface(matchCard,"383026","e6bd65","51422b","ffe09a",0);`
- `NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；输入表达式：`CaptionButton("赛事详情", () => OpenCompetition(c.Id))`；返回值紧邻使用处：`ArgumentSyntax: CaptionButton("赛事详情", () => OpenCompetition(c.Id))`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("国际赛事冠军 · 生涯进阶 9 通关",14,_muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardLabel("国际赛事冠军 · 生涯进阶 9 通关",14,_muted)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("世界纪录邀请赛",18,_gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardLabel("世界纪录邀请赛",18,_gold)`
- `NationalSpire.CareerScreen.FlagCode(string)`；输入表达式：`FlagCode(c.TeamEvent && c.Kind=="worldcup" ? team : EsportsWorld.HistoricCountry(d,c,id))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =FlagCode(c.TeamEvent && c.Kind=="worldcup" ? team : EsportsWorld.HistoricCountry(d,c,id))`
- `NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；输入表达式：`FramedAction("+",()=>Zoom(_bracketZoom+.1f,scroll.Size/2),width:42,height:36,quiet:true)`；返回值紧邻使用处：`ArgumentSyntax: FramedAction("+",()=>Zoom(_bracketZoom+.1f,scroll.Size/2),width:42,height:36,quiet:true)`
- `NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；输入表达式：`FramedAction("−",()=>Zoom(_bracketZoom-.1f,scroll.Size/2),width:42,height:36,quiet:true)`；返回值紧邻使用处：`ArgumentSyntax: FramedAction("−",()=>Zoom(_bracketZoom-.1f,scroll.Size/2),width:42,height:36,quiet:true)`
- `NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；输入表达式：`FramedAction("定位轮次",()=>{scroll.ScrollVertical=0;Locate();},"locate-fixed",width:118,height:38,quiet:true)`；返回值紧邻使用处：`ArgumentSyntax: FramedAction("定位轮次",()=>{scroll.ScrollVertical=0;Locate();},"locate-fixed",width:118,height:38,quiet:true)`
- `NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；输入表达式：`FramedAction("原大",()=>Zoom(1,scroll.Size/2),width:62,height:36,quiet:true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =FramedAction("原大",()=>Zoom(1,scroll.Size/2),width:62,height:36,quiet:true)`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`Glyph("trophy",24,_gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Glyph("trophy",24,_gold)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(frame)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Inner(frame)`
- `NationalSpire.CareerScreen.Inset(int, int)`；输入表达式：`Inset(9,0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Inset(9,0)`
- `NationalSpire.CareerScreen.Inset(int, int)`；输入表达式：`Inset(9,9)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Inset(9,9)`
- `NationalSpire.CareerScreen.LocalEntrant(NationalSpire.CareerData, string)`；输入表达式：`LocalEntrant(d,id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => LocalEntrant(d,id)`
- `NationalSpire.CareerScreen.LocalEntrant(NationalSpire.CareerData, string)`；输入表达式：`LocalEntrant(d,member)`；返回值紧邻使用处：`ConditionalExpressionSyntax: LocalEntrant(d,member) ? _gold : _muted`
- `NationalSpire.CareerScreen.NavigationIcon(string)`；输入表达式：`NavigationIcon("flag-"+flag)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Texture=NavigationIcon("flag-"+flag)`
- `NationalSpire.CareerScreen.OpenCompetition(string)`；输入表达式：`OpenCompetition(c.Id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenCompetition(c.Id)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("对手："+opponent,18,_ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("对手："+opponent,18,_ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("世界纪录邀请赛",22,_gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("世界纪录邀请赛",22,_gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("受邀资格：国际赛事冠军、生涯赛事进阶 9 通关。",17,_ink)`；返回值紧邻使用处：`ArgumentSyntax: Text("受邀资格：国际赛事冠军、生涯赛事进阶 9 通关。",17,_ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(c.Finished?"已结束":c.Fixtures.Count==0?"待抽签":BracketRoundName(count-active+1),16,CareerVisuals.Teal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Text(c.Finished?"已结束":c.Fixtures.Count==0?"待抽签":BracketRoundName(count-active+1),16,CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(c.TeamEvent?CircuitWorld.TeamName(d,c,team):CareerEngine.DisplayName(d,id),16,player ? _gold : lost ? _muted : _ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Text(c.TeamEvent?CircuitWorld.TeamName(d,c,team):CareerEngine.DisplayName(d,id),16,player ? _gold : lost ? _muted : _ink)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(CareerEngine.DisplayName(d, member), 12, LocalEntrant(d,member) ? _gold : _muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(CareerEngine.DisplayName(d, member), 12, LocalEntrant(d,member) ? _gold : _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(GameCalendar.Text(d,invitationDay)+" · 进阶 "+ascension,16,_muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(GameCalendar.Text(d,invitationDay)+" · 进阶 "+ascension,16,_muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text(round == 1 ? "▫   待抽签" : "▫   待晋级", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text(round == 1 ? "▫   待抽签" : "▫   待晋级", 15, _muted)`
- `NationalSpire.CareerScreen.TieKey(NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`；输入表达式：`TieKey(c, f)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: f => TieKey(c, f)`
- `NationalSpire.CareerScreen.TieKey(NationalSpire.WorldCompetition, NationalSpire.WorldFixture)`；输入表达式：`TieKey(c,f)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: f=>TieKey(c,f)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("0e1c28","334d58",6,1)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("0e1c28","334d58",6,1)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("172b37", "344954", 4, 4)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("172b37", "344954", 4, 4)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(player ? (lost ? "352e25" : "493d28") : won ? "1b3d3b" : lost ? "13222e" : "182c39",                          player ? "e6bd65" : won ? "80c7b9" : "405967", 3, 3)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerVisuals.Box(player ? (lost ? "352e25" : "493d28") : won ? "1b3d3b" : lost ? "13222e" : "182c39",                          player ? "e6bd65" : won ? "80c7b9" : "405967", 3, 3)`
- `NationalSpire.CircuitWorld.DayOf(NationalSpire.WorldCompetition, int)`；输入表达式：`CircuitWorld.DayOf(c, round)`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.Modern ? CircuitWorld.DayOf(c, round) : 0`
- `NationalSpire.CircuitWorld.RoundCount(NationalSpire.WorldCompetition)`；输入表达式：`CircuitWorld.RoundCount(c)`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.Modern?CircuitWorld.RoundCount(c):Math.Max(active,c.Fixtures.Select(f=>f.Round).DefaultIfEmpty(1).Max())`
- `NationalSpire.CircuitWorld.TeamName(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`；输入表达式：`CircuitWorld.TeamName(d,c,team)`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.TeamEvent?CircuitWorld.TeamName(d,c,team):CareerEngine.DisplayName(d,id)`
- `NationalSpire.EsportsWorld.HistoricCountry(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`；输入表达式：`EsportsWorld.HistoricCountry(d,c,id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.TeamEvent && c.Kind=="worldcup" ? team : EsportsWorld.HistoricCountry(d,c,id)`
- `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Date(d, day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameCalendar.Date(d, day).ToString`
- `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Date(d,invitationDay)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameCalendar.Date(d,invitationDay).ToString`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(d,invitationDay)`；返回值紧邻使用处：`BinaryExpressionSyntax: GameCalendar.Text(d,invitationDay)+" · 进阶 "`
- `NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Length(d,c.Season)`；返回值紧邻使用处：`BinaryExpressionSyntax: seasonStart + SeasonCalendar.Length(d,c.Season)`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(d,c.Season)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SeasonCalendar.Start(d,c.Season)`
- `NationalSpire.ZoomableBracketScroll.ZoomableBracketScroll()`；输入表达式：`new ZoomableBracketScroll {Name="InternationalBracket",SizeFlagsVertical=SizeFlags.ExpandFill,SizeFlagsHorizontal=SizeFlags.ExpandFill}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new ZoomableBracketScroll {Name="InternationalBracket",SizeFlagsVertical=SizeFlags.ExpandFill,SizeFlagsHorizontal=SizeFlags.ExpandFill}`
- `ResizeBracket()`；输入表达式：`ResizeBracket()`；返回值紧邻使用处：`ExpressionStatementSyntax: ResizeBracket();`
- `System.Collections.Generic.IEnumerable<int>.Max()`；输入表达式：`c.Fixtures.Select(f=>f.Round).DefaultIfEmpty(1).Max()`；返回值紧邻使用处：`ArgumentSyntax: c.Fixtures.Select(f=>f.Round).DefaultIfEmpty(1).Max()`
- `System.Collections.Generic.IEnumerable<int>.Min()`；输入表达式：`c.Fixtures.Where(f=>!f.Finished).Select(f=>f.Round).DefaultIfEmpty(c.Fixtures.Select(f=>f.Round).DefaultIfEmpty(1).Max()).Min()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =c.Fixtures.Where(f=>!f.Finished).Select(f=>f.Round).DefaultIfEmpty(c.Fixtures.Select(f=>f.Round).DefaultIfEmpty(1).Max()).Min()`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`tie.All(x=>x.Finished)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =tie.All(x=>x.Finished)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`awayRoster.Any(id => LocalEntrant(d,id))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = awayRoster.Any(id => LocalEntrant(d,id))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`homeRoster.Any(id => LocalEntrant(d,id))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = homeRoster.Any(id => LocalEntrant(d,id))`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`c.Fixtures.Where(f=>f.Round==1).GroupBy(f=>TieKey(c,f)).Count()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =c.Fixtures.Where(f=>f.Round==1).GroupBy(f=>TieKey(c,f)).Count()`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`tie.Count(x=>x.WinnerId.Length>0&&x.WinnerId==x.AwayId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =tie.Count(x=>x.WinnerId.Length>0&&x.WinnerId==x.AwayId)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`tie.Count(x=>x.WinnerId.Length>0&&x.WinnerId==x.HomeId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =tie.Count(x=>x.WinnerId.Length>0&&x.WinnerId==x.HomeId)`
- `System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；输入表达式：`c.Fixtures.Select(f=>f.Round).DefaultIfEmpty(1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Select(f=>f.Round).DefaultIfEmpty(1).Max`
- `System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；输入表达式：`c.Fixtures.Where(f=>!f.Finished).Select(f=>f.Round).DefaultIfEmpty(c.Fixtures.Select(f=>f.Round).DefaultIfEmpty(1).Max())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f=>!f.Finished).Select(f=>f.Round).DefaultIfEmpty(c.Fixtures.Select(f=>f.Round).DefaultIfEmpty(1).Max()).Min`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`tie.SelectMany(game => BracketEntrants(d,c,game,false)).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: tie.SelectMany(game => BracketEntrants(d,c,game,false)).Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`tie.SelectMany(game => BracketEntrants(d,c,game,true)).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: tie.SelectMany(game => BracketEntrants(d,c,game,true)).Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；输入表达式：`ties[0].First()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ties[0].First().Day`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.FirstOrDefault(m => m.Kind=="masters" && m.Day>seasonStart && m.Day<=seasonEnd)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Matches.FirstOrDefault(m => m.Kind=="masters" && m.Day>seasonStart && m.Day<=seasonEnd)`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`c.Fixtures.Where(f => f.Round == round).GroupBy(f => TieKey(c, f))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.Round == round).GroupBy(f => TieKey(c, f)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`c.Fixtures.Where(f=>f.Round==1).GroupBy(f=>TieKey(c,f))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f=>f.Round==1).GroupBy(f=>TieKey(c,f)).Count`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Results.LastOrDefault(r => r.Kind=="masters" && (invite != null ? r.MatchId==invite.Id :              r.Settlement?.Season == c.Season || r.Day>seasonStart && r.Day<=seasonEnd))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Results.LastOrDefault(r => r.Kind=="masters" && (invite != null ? r.MatchId==invite.Id :              r.Settlement?.Season == c.Season || r.Day>seasonStart && r.Day<=seasonEnd))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`c.Fixtures.Select(f=>f.Round)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Select(f=>f.Round).DefaultIfEmpty`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`c.Fixtures.Where(f=>!f.Finished).Select(f=>f.Round)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f=>!f.Finished).Select(f=>f.Round).DefaultIfEmpty`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`tie.SelectMany(game => BracketEntrants(d,c,game,false))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: tie.SelectMany(game => BracketEntrants(d,c,game,false)).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`tie.SelectMany(game => BracketEntrants(d,c,game,true))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: tie.SelectMany(game => BracketEntrants(d,c,game,true)).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`tie.SelectMany(game => BracketEntrants(d,c,game,false)).Distinct().ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = tie.SelectMany(game => BracketEntrants(d,c,game,false)).Distinct().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`tie.SelectMany(game => BracketEntrants(d,c,game,true)).Distinct().ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = tie.SelectMany(game => BracketEntrants(d,c,game,true)).Distinct().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`c.Fixtures.Where(f => f.Round == round).GroupBy(f => TieKey(c, f)).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Fixtures.Where(f => f.Round == round).GroupBy(f => TieKey(c, f)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`ties[i].ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ties[i].ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(f => f.Round == round)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.Round == round).GroupBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(f=>!f.Finished)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f=>!f.Finished).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(f=>f.Round==1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f=>f.Round==1).GroupBy`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`d.Esports.Competitions.Contains(c)`；返回值紧邻使用处：`IfStatementSyntax: if (d.Esports.Competitions.Contains(c)) toolbar.AddChild(CaptionButton("赛事详情", () => OpenCompetition(c.Id)));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<(Control Column,Control Heading)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new List<(Control Column,Control Heading)>()`
- `System.DateOnly.ToString(string?)`；输入表达式：`GameCalendar.Date(d, day).ToString("M月d日")`；返回值紧邻使用处：`ConditionalExpressionSyntax: day > 0 ? GameCalendar.Date(d, day).ToString("M月d日") : ""`
- `System.DateOnly.ToString(string?)`；输入表达式：`GameCalendar.Date(d,invitationDay).ToString("M月d日")`；返回值紧邻使用处：`ArgumentSyntax: GameCalendar.Date(d,invitationDay).ToString("M月d日")`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1,firstTies >> (round-1))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(1,firstTies >> (round-1))`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(60,firstTies*pitch)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(60,firstTies*pitch)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(60,firstTies*pitch/slots)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(60,firstTies*pitch/slots)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(active,c.Fixtures.Select(f=>f.Round).DefaultIfEmpty(1).Max())`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.Modern?CircuitWorld.RoundCount(c):Math.Max(active,c.Fixtures.Select(f=>f.Round).DefaultIfEmpty(1).Max())`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(ties.Count,Math.Max(1,firstTies >> (round-1)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Math.Max(ties.Count,Math.Max(1,firstTies >> (round-1)))`
- `Zoom(float, Godot.Vector2)`；输入表达式：`Zoom(_bracketZoom-.1f,scroll.Size/2)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>Zoom(_bracketZoom-.1f,scroll.Size/2)`
- `Zoom(float, Godot.Vector2)`；输入表达式：`Zoom(_bracketZoom+.1f,scroll.Size/2)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>Zoom(_bracketZoom+.1f,scroll.Size/2)`
- `Zoom(float, Godot.Vector2)`；输入表达式：`Zoom(_bracketZoom+delta,point)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: (delta,point)=>Zoom(_bracketZoom+delta,point)`
- `Zoom(float, Godot.Vector2)`；输入表达式：`Zoom(1,scroll.Size/2)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>Zoom(1,scroll.Size/2)`

**赋值（含属性/字段和局部值）：**

- `Alignment` = `BoxContainer.AlignmentMode.Center`
- `band.SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `bg.BorderWidthLeft` = `3`
- `bg.ContentMarginLeft` = `8`
- `bg.ContentMarginRight` = `8`
- `BgColor` = `new Color(currentRound ? "80e7db0a" : "00000000")`
- `BorderColor` = `new Color("80e7db70")`
- `ClipContents` = `true`
- `columns.SortChildren` += `AlignHeadings`
- `ContentMarginBottom` = `9`
- `ContentMarginLeft` = `9`
- `ContentMarginRight` = `9`
- `ContentMarginTop` = `9`
- `criteria.HorizontalAlignment` = `HorizontalAlignment.Center`
- `current` = `panel`
- `CustomMinimumSize` = `new(0, cardHeight)`
- `CustomMinimumSize` = `new(0,56)`
- `CustomMinimumSize` = `new(0,712)`
- `CustomMinimumSize` = `new(0,Math.Max(60,firstTies*pitch))`
- `CustomMinimumSize` = `new(0,Math.Max(60,firstTies*pitch/slots))`
- `CustomMinimumSize` = `new(20,15)`
- `CustomMinimumSize` = `new(274,0)`
- `CustomMinimumSize` = `new(54,0)`
- `ExpandMode` = `TextureRect.ExpandModeEnum.IgnoreSize`
- `firstTies` = `1 << (count - 1)`
- `Flat` = `true`
- `head.Draw` += `()=>{              head.DrawRect(new Rect2(Vector2.Zero,head.Size),new Color("162a36"));              head.DrawLine(new(0,head.Size.Y-1),new(head.Size.X,head.Size.Y-1),new Color("344954"));          }`
- `head.Resized` += `head.QueueRedraw`
- `HorizontalAlignment` = `HorizontalAlignment.Center`
- `inset.MinimumSizeChanged` += `ResizeBracket`
- `inset.Scale` = `Vector2.One*_bracketZoom`
- `invitationColumn.CustomMinimumSize` = `new(274,0)`
- `invitationColumn.SizeFlagsHorizontal` = `SizeFlags.Fill`
- `label.AutowrapMode` = `TextServer.AutowrapMode.Off`
- `label.MouseFilter` = `MouseFilterEnum.Ignore`
- `label.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `matchCard.Flat` = `false`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `MouseFilter` = `MouseFilterEnum.Pass`
- `name.AutowrapMode` = `TextServer.AutowrapMode.Off`
- `name.TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `Name` = `"BracketFrame"`
- `Name` = `"BracketHeadings"`
- `Name` = `"InternationalBracket"`
- `Name` = `$"BracketMatch_{round}_{i}"`
- `nextMatch` = `matchCard`
- `pair.OffsetBottom` = `-2`
- `pair.OffsetLeft` = `pair.OffsetTop=2`
- `pair.OffsetRight` = `pair.OffsetBottom=-2`
- `pair.OffsetTop` = `2`
- `progress.AutowrapMode` = `TextServer.AutowrapMode.Off`
- `progress.SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `reset.TooltipText` = `"按住左键拖动签表，Ctrl + 滚轮缩放"`
- `scroll.GetHScrollBar().ValueChanged` += `_=>AlignHeadings()`
- `scroll.ScrollVertical` = `0`
- `scroll.ZoomStep` = `(delta,point)=>Zoom(_bracketZoom+delta,point)`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `SizeFlagsVertical` = `SizeFlags.ExpandFill`
- `StretchMode` = `TextureRect.StretchModeEnum.KeepAspectCentered`
- `Text` = `$"{_bracketZoom:P0}"`
- `Text` = `c.TeamEvent ? (left ? home : away).ToString() : "胜"`
- `Texture` = `NavigationIcon("flag-"+flag)`
- `title.HorizontalAlignment` = `HorizontalAlignment.Center`
- `trophy.SizeFlagsHorizontal` = `SizeFlags.ShrinkCenter`

<a id="symbol-4d9584ac0b60"></a>

## `AlignHeadings() — void AlignHeadings()`

来源：源码第 394 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)；[`ResizeBracket()`](FixtureScheduleScreen.cs.md#symbol-d5cfa78289ac)；[`Zoom(float, Godot.Vector2)`](FixtureScheduleScreen.cs.md#symbol-e47c780a6abf)

**调用：** `Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._bracketZoom`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new((column.Position.X+18)*_bracketZoom-scroll.ScrollHorizontal,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: heading.Position=new((column.Position.X+18)*_bracketZoom-scroll.ScrollHorizontal,0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(column.Size.X-18,56)`；返回值紧邻使用处：`AssignmentExpressionSyntax: heading.Size=new(column.Size.X-18,56)`

**赋值（含属性/字段和局部值）：**

- `heading.Position` = `new((column.Position.X+18)*_bracketZoom-scroll.ScrollHorizontal,0)`
- `heading.Scale` = `Vector2.One*_bracketZoom`
- `heading.Size` = `new(column.Size.X-18,56)`

<a id="symbol-c9c5e134a317"></a>

## `AddHeading(Godot.Control, string, string, bool, bool) — void AddHeading(Control column,string title,string date,bool current,bool invitation=false)`

来源：源码第 402 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)

**调用：** [`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.StyleBoxFlat.SetBorderWidthAll(int)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Teal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`heading.AddThemeStyleboxOverride("panel",style)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddThemeStyleboxOverride("panel",style);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer {MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer {MouseFilter=MouseFilterEnum.Ignore}`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`fields.AddChild(DashboardLabel(title,19,current ? CareerVisuals.Teal : invitation ? _gold : _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.AddChild(DashboardLabel(title,19,current ? CareerVisuals.Teal : invitation ? _gold : _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`fields.AddChild(stamp)`；返回值紧邻使用处：`ExpressionStatementSyntax: fields.AddChild(stamp);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`head.AddChild(heading)`；返回值紧邻使用处：`ExpressionStatementSyntax: head.AddChild(heading);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`heading.AddChild(fields)`；返回值紧邻使用处：`ExpressionStatementSyntax: heading.AddChild(fields);`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer {Name="RoundHeading_"+headers.Count,MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new PanelContainer {Name="RoundHeading_"+headers.Count,MouseFilter=MouseFilterEnum.Ignore}`
- `Godot.StyleBoxFlat.SetBorderWidthAll(int)`；输入表达式：`style.SetBorderWidthAll(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: style.SetBorderWidthAll(0);`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(date,13,_muted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardLabel(date,13,_muted)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(title,19,current ? CareerVisuals.Teal : invitation ? _gold : _muted)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(title,19,current ? CareerVisuals.Teal : invitation ? _gold : _muted)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("00000000","80e7db",0,0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CareerVisuals.Box("00000000","80e7db",0,0)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`headers.Add((column,heading))`；返回值紧邻使用处：`ExpressionStatementSyntax: headers.Add((column,heading));`

**赋值（含属性/字段和局部值）：**

- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Name` = `"RoundHeading_"+headers.Count`
- `stamp.SizeFlagsHorizontal` = `SizeFlags.ShrinkEnd`
- `style.BorderWidthBottom` = `current?2:0`
- `style.ContentMarginLeft` = `style.ContentMarginRight=11`
- `style.ContentMarginRight` = `11`

<a id="symbol-d5cfa78289ac"></a>

## `ResizeBracket() — void ResizeBracket()`

来源：源码第 417 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)；[`Zoom(float, Godot.Vector2)`](FixtureScheduleScreen.cs.md#symbol-e47c780a6abf)

**调用：** [`AlignHeadings()`](FixtureScheduleScreen.cs.md#symbol-4d9584ac0b60)；`Godot.Control.GetCombinedMinimumSize()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `AlignHeadings()`；`NationalSpire.CareerScreen._bracketZoom`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `AlignHeadings()`；输入表达式：`AlignHeadings()`；返回值紧邻使用处：`ExpressionStatementSyntax: AlignHeadings();`
- `Godot.Control.GetCombinedMinimumSize()`；输入表达式：`inset.GetCombinedMinimumSize()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =inset.GetCombinedMinimumSize()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,56*_bracketZoom)`；返回值紧邻使用处：`AssignmentExpressionSyntax: head.CustomMinimumSize=new(0,56*_bracketZoom)`

**赋值（含属性/字段和局部值）：**

- `extent.CustomMinimumSize` = `size*_bracketZoom`
- `head.CustomMinimumSize` = `new(0,56*_bracketZoom)`
- `inset.Size` = `size`

<a id="symbol-e47c780a6abf"></a>

## `Zoom(float, Godot.Vector2) — void Zoom(float factor,Vector2 anchor)`

来源：源码第 421 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)

**调用：** [`AlignHeadings()`](FixtureScheduleScreen.cs.md#symbol-4d9584ac0b60)；[`ResizeBracket()`](FixtureScheduleScreen.cs.md#symbol-d5cfa78289ac)；`Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.Vector2.Vector2(float, float)`；`System.Math.Clamp(float, float, float)`；`System.MathF.Round(float)`

**字段、属性、事件及方法组引用：** `AlignHeadings()`；`NationalSpire.CareerScreen._bracketZoom`；`ResizeBracket()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `AlignHeadings()`；输入表达式：`AlignHeadings()`；返回值紧邻使用处：`ExpressionStatementSyntax: AlignHeadings();`
- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(()=>{if(version==revision && IsInstanceValid(scroll) && !scroll.IsQueuedForDeletion()){scroll.ScrollHorizontal=(int)origin.X;scroll.ScrollVertical=(int)origin.Y;AlignHeadings();}}).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(()=>{if(version==revision && IsInstanceValid(scroll) && !scroll.IsQueuedForDeletion()){scroll.ScrollHorizontal=(int)origin.X;scroll.ScrollVertical=(int)origin.Y;AlignHeadings();}}).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(()=>{if(version==revision && IsInstanceValid(scroll) && !scroll.IsQueuedForDeletion()){scroll.ScrollHorizontal=(int)origin.X;scroll.ScrollVertical=(int)origin.Y;AlignHeadings();}})`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(()=>{if(version==revision && IsInstanceValid(scroll) && !scroll.IsQueuedForDeletion()){scroll.ScrollHorizontal=(int)origin.X;scroll.ScrollVertical=(int)origin.Y;AlignHeadings();}}).CallDeferred`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(scroll)`；返回值紧邻使用处：`BinaryExpressionSyntax: version==revision && IsInstanceValid(scroll)`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`scroll.IsQueuedForDeletion()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !scroll.IsQueuedForDeletion()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(scroll.ScrollHorizontal,scroll.ScrollVertical)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(scroll.ScrollHorizontal,scroll.ScrollVertical)+anchor`
- `ResizeBracket()`；输入表达式：`ResizeBracket()`；返回值紧邻使用处：`ExpressionStatementSyntax: ResizeBracket();`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp(MathF.Round(factor*100)/100,.5f,1.5f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _bracketZoom=Math.Clamp(MathF.Round(factor*100)/100,.5f,1.5f)`
- `System.MathF.Round(float)`；输入表达式：`MathF.Round(factor*100)`；返回值紧邻使用处：`BinaryExpressionSyntax: MathF.Round(factor*100)/100`

**赋值（含属性/字段和局部值）：**

- `_bracketZoom` = `Math.Clamp(MathF.Round(factor*100)/100,.5f,1.5f)`
- `inset.Scale` = `Vector2.One*_bracketZoom`
- `scroll.ScrollHorizontal` = `(int)origin.X`
- `scroll.ScrollVertical` = `(int)origin.Y`
- `zoomText.Text` = `$"{_bracketZoom:P0}"`

<a id="symbol-f09c19694fee"></a>

## `Locate() — void Locate()`

来源：源码第 576 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`LocateAfterLayout()`](FixtureScheduleScreen.cs.md#symbol-230d9e58c65c)；[`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)

**调用：** `Godot.CanvasItem.GetGlobalTransform()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.IsInsideTree()`；`Godot.ScrollContainer.GetHScrollBar()`；`Godot.Transform2D.AffineInverse()`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._bracketZoom`；`NationalSpire.WorldCompetition.Finished`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.GetGlobalTransform()`；输入表达式：`columns.GetGlobalTransform()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: columns.GetGlobalTransform().AffineInverse`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(current)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(current)`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(scroll)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(scroll)`
- `Godot.Node.IsInsideTree()`；输入表达式：`scroll.IsInsideTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !scroll.IsInsideTree()`
- `Godot.ScrollContainer.GetHScrollBar()`；输入表达式：`scroll.GetHScrollBar()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: scroll.GetHScrollBar().MaxValue`
- `Godot.Transform2D.AffineInverse()`；输入表达式：`columns.GetGlobalTransform().AffineInverse()`；返回值紧邻使用处：`BinaryExpressionSyntax: columns.GetGlobalTransform().AffineInverse() * nextMatch.GlobalPosition`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, (int)(localY*_bracketZoom - scroll.Size.Y * .30f))`；返回值紧邻使用处：`AssignmentExpressionSyntax: scroll.ScrollVertical = Math.Max(0, (int)(localY*_bracketZoom - scroll.Size.Y * .30f))`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, precedingColumn)`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.Finished ? (int)scroll.GetHScrollBar().MaxValue : Math.Max(0, precedingColumn)`

**赋值（含属性/字段和局部值）：**

- `scroll.ScrollHorizontal` = `c.Finished ? (int)scroll.GetHScrollBar().MaxValue : Math.Max(0, precedingColumn)`
- `scroll.ScrollVertical` = `Math.Max(0, (int)(localY*_bracketZoom - scroll.Size.Y * .30f))`

<a id="symbol-230d9e58c65c"></a>

## `LocateAfterLayout() — async void LocateAfterLayout()`

来源：源码第 593 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)

**调用：** [`Locate()`](FixtureScheduleScreen.cs.md#symbol-f09c19694fee)；`Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；`Godot.Node.GetTree()`

**字段、属性、事件及方法组引用：** `Locate()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.ToSignal(Godot.GodotObject, Godot.StringName)`；输入表达式：`ToSignal(tree, SceneTree.SignalName.ProcessFrame)`；返回值紧邻使用处：`AwaitExpressionSyntax: await ToSignal(tree, SceneTree.SignalName.ProcessFrame)`
- `Godot.Node.GetTree()`；输入表达式：`scroll.GetTree()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = scroll.GetTree()`
- `Locate()`；输入表达式：`Locate()`；返回值紧邻使用处：`ExpressionStatementSyntax: Locate();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c2b93d2a2d7f"></a>

## `NationalSpire.ZoomableBracketScroll._Input(Godot.InputEvent) — public override void _Input(InputEvent e)`

来源：源码第 612 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.GetGlobalTransformWithCanvas()`；`Godot.CanvasItem.IsVisibleInTree()`；`Godot.Control.GrabFocus()`；`Godot.GodotObject.EmitSignal(Godot.StringName, params Godot.Variant[])`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.GetParent()`；`Godot.Node.GetViewport()`；`Godot.Node.IsAncestorOf(Godot.Node)`；`Godot.Rect2.HasPoint(Godot.Vector2)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Transform2D.AffineInverse()`；`Godot.Vector2.LengthSquared()`；`Godot.Vector2.Vector2(float, float)`；`Godot.Viewport.GuiGetHoveredControl()`；`Godot.Viewport.SetInputAsHandled()`；`System.Action<T1, T2>.Invoke(T1, T2)`（委托实际目标见流程文档）；`System.Enum.HasFlag(System.Enum)`

**字段、属性、事件及方法组引用：** `NationalSpire.ZoomableBracketScroll._card`；`NationalSpire.ZoomableBracketScroll._dragged`；`NationalSpire.ZoomableBracketScroll._held`；`NationalSpire.ZoomableBracketScroll._offset`；`NationalSpire.ZoomableBracketScroll._origin`；`NationalSpire.ZoomableBracketScroll.ZoomStep`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.GetGlobalTransformWithCanvas()`；输入表达式：`card.GetGlobalTransformWithCanvas()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: card.GetGlobalTransformWithCanvas().AffineInverse`
- `Godot.CanvasItem.GetGlobalTransformWithCanvas()`；输入表达式：`GetGlobalTransformWithCanvas()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetGlobalTransformWithCanvas().AffineInverse`
- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`card!.IsVisibleInTree()`；返回值紧邻使用处：`BinaryExpressionSyntax: !_dragged && IsInstanceValid(card) && card!.IsVisibleInTree()`
- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`IsVisibleInTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsVisibleInTree()`
- `Godot.Control.GrabFocus()`；输入表达式：`card.GrabFocus()`；返回值紧邻使用处：`ExpressionStatementSyntax: card.GrabFocus();`
- `Godot.GodotObject.EmitSignal(Godot.StringName, params Godot.Variant[])`；输入表达式：`card.EmitSignal(BaseButton.SignalName.Pressed)`；返回值紧邻使用处：`ExpressionStatementSyntax: card.EmitSignal(BaseButton.SignalName.Pressed);`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(card)`；返回值紧邻使用处：`BinaryExpressionSyntax: !_dragged && IsInstanceValid(card)`
- `Godot.Node.GetParent()`；输入表达式：`n.GetParent()`；返回值紧邻使用处：`AssignmentExpressionSyntax: n=n.GetParent()`
- `Godot.Node.GetViewport()`；输入表达式：`GetViewport()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =GetViewport()`
- `Godot.Node.IsAncestorOf(Godot.Node)`；输入表达式：`IsAncestorOf(hovered)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsAncestorOf(hovered)`
- `Godot.Rect2.HasPoint(Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero,card.Size).HasPoint(card.GetGlobalTransformWithCanvas().AffineInverse()*mouse.Position)`；返回值紧邻使用处：`BinaryExpressionSyntax: !_dragged && IsInstanceValid(card) && card!.IsVisibleInTree() && new Rect2(Vector2.Zero,card.Size).HasPoint(card.GetGlobalTransformWithCanvas().AffineInverse()*mouse.Position)`
- `Godot.Rect2.HasPoint(Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero,Size).HasPoint(point)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !new Rect2(Vector2.Zero,Size).HasPoint(point)`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero,card.Size)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new Rect2(Vector2.Zero,card.Size).HasPoint`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(Vector2.Zero,Size)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new Rect2(Vector2.Zero,Size).HasPoint`
- `Godot.Transform2D.AffineInverse()`；输入表达式：`card.GetGlobalTransformWithCanvas().AffineInverse()`；返回值紧邻使用处：`BinaryExpressionSyntax: card.GetGlobalTransformWithCanvas().AffineInverse()*mouse.Position`
- `Godot.Transform2D.AffineInverse()`；输入表达式：`GetGlobalTransformWithCanvas().AffineInverse()`；返回值紧邻使用处：`BinaryExpressionSyntax: GetGlobalTransformWithCanvas().AffineInverse()*mouse.Position`
- `Godot.Vector2.LengthSquared()`；输入表达式：`distance.LengthSquared()`；返回值紧邻使用处：`BinaryExpressionSyntax: distance.LengthSquared()<36`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(ScrollHorizontal,ScrollVertical)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _offset=new(ScrollHorizontal,ScrollVertical)`
- `Godot.Viewport.GuiGetHoveredControl()`；输入表达式：`viewport.GuiGetHoveredControl()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =viewport.GuiGetHoveredControl()`
- `Godot.Viewport.SetInputAsHandled()`；输入表达式：`viewport.SetInputAsHandled()`；返回值紧邻使用处：`ExpressionStatementSyntax: viewport.SetInputAsHandled();`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`.Invoke(button.ButtonIndex==MouseButton.WheelUp?.1f:-.1f,point)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: ZoomStep?.Invoke(button.ButtonIndex==MouseButton.WheelUp?.1f:-.1f,point)`
- `System.Enum.HasFlag(System.Enum)`；输入表达式：`motion.ButtonMask.HasFlag(MouseButtonMask.Left)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !motion.ButtonMask.HasFlag(MouseButtonMask.Left)`

**赋值（含属性/字段和局部值）：**

- `_card` = `null`
- `_card` = `target`
- `_dragged` = `false`
- `_dragged` = `true`
- `_held` = `false`
- `_held` = `true`
- `_offset` = `new(ScrollHorizontal,ScrollVertical)`
- `_origin` = `point`
- `n` = `n.GetParent()`
- `ScrollHorizontal` = `(int)(_offset.X-distance.X)`
- `ScrollVertical` = `(int)(_offset.Y-distance.Y)`
- `target` = `b`
