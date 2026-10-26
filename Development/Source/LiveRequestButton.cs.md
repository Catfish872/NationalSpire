# LiveRequestButton.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`3334B41785B28F36501FE514037DA8B8BDA36A76183B83DCC953FBD86A4A817D`。来源：[源码](../../LiveRequestButton.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LiveRequestButton`。

字段、事件及初始值（源码原样）：

```csharp
public event Action? Elapsed;
private Vector2[] _path = [];
private float[] _lengths = [];
private Vector2 _pathSize;
```

<a id="symbol-5bcb5414d3be"></a>

## `NationalSpire.LiveRequestButton.Remaining — public double Remaining`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2c8444f60075"></a>

## `NationalSpire.LiveRequestButton.Held — public bool Held`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e8accbc7d310"></a>

## `NationalSpire.LiveRequestButton.LiveRequestButton() — public LiveRequestButton()`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRaceHud.ShowChatRequest(string, string, string, NationalSpire.AvatarArt, NationalSpire.AvatarIdentity, double, bool, Godot.Button, System.Action)`](LiveRaceHud.cs.md#symbol-e42d7e040efa)

**调用：** `Godot.Color.Color(string)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("f4dce8")`；返回值紧邻使用处：`ArgumentSyntax: new Color("f4dce8")`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`AddThemeColorOverride(state, new Color("f4dce8"))`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeColorOverride(state, new Color("f4dce8"));`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`AddThemeFontSizeOverride("font_size", 15)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeFontSizeOverride("font_size", 15);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`AddThemeStyleboxOverride(state, CareerVisuals.Box(fill, "b7809d", 7, 10))`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeStyleboxOverride(state, CareerVisuals.Box(fill, "b7809d", 7, 10));`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 54)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(0, 54)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box(fill, "b7809d", 7, 10)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box(fill, "b7809d", 7, 10)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(0, 54)`
- `FocusMode` = `FocusModeEnum.None`
- `Name` = `"DateGameRespond"`
- `Text` = `"回应请求"`

<a id="symbol-c1257288a26f"></a>

## `NationalSpire.LiveRequestButton.Sync(double, bool) — public void Sync(double seconds, bool held)`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRaceHud.ShowChatRequest(string, string, string, NationalSpire.AvatarArt, NationalSpire.AvatarIdentity, double, bool, Godot.Button, System.Action)`](LiveRaceHud.cs.md#symbol-e42d7e040efa)

**调用：** `Godot.CanvasItem.QueueRedraw()`；[`NationalSpire.LiveRequestButton.Hold(bool)`](LiveRequestButton.cs.md#symbol-104cb7b7e93b)；`System.Math.Clamp(double, double, double)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateGames.ChatRequestSeconds`；`NationalSpire.LiveRequestButton.Hold(bool)`；`NationalSpire.LiveRequestButton.Remaining`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`
- `NationalSpire.LiveRequestButton.Hold(bool)`；输入表达式：`Hold(held)`；返回值紧邻使用处：`ExpressionStatementSyntax: Hold(held);`
- `System.Math.Clamp(double, double, double)`；输入表达式：`Math.Clamp(seconds, 0, DateGames.ChatRequestSeconds)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Remaining = Math.Clamp(seconds, 0, DateGames.ChatRequestSeconds)`

**赋值（含属性/字段和局部值）：**

- `Remaining` = `Math.Clamp(seconds, 0, DateGames.ChatRequestSeconds)`

<a id="symbol-104cb7b7e93b"></a>

## `NationalSpire.LiveRequestButton.Hold(bool) — public void Hold(bool held)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRaceHud.HoldChatRequest(bool)`](LiveRaceHud.cs.md#symbol-654af1fb17c1)；[`NationalSpire.LiveRaceHud.ShowChatRequest(string, string, string, NationalSpire.AvatarArt, NationalSpire.AvatarIdentity, double, bool, Godot.Button, System.Action)`](LiveRaceHud.cs.md#symbol-e42d7e040efa)；[`NationalSpire.LiveRequestButton.Sync(double, bool)`](LiveRequestButton.cs.md#symbol-c1257288a26f)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.LiveRequestButton.Held`；`NationalSpire.LiveRequestButton.Remaining`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `Disabled` = `held || Remaining <= 0`
- `Held` = `held`

<a id="symbol-9b6f34a7b4c8"></a>

## `NationalSpire.LiveRequestButton._Process(double) — public override void _Process(double delta)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.QueueRedraw()`；`System.Action.Invoke()`；`System.Math.Max(double, double)`

**字段、属性、事件及方法组引用：** `NationalSpire.LiveRequestButton.Elapsed`；`NationalSpire.LiveRequestButton.Held`；`NationalSpire.LiveRequestButton.Remaining`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Elapsed?.Invoke()`
- `System.Math.Max(double, double)`；输入表达式：`Math.Max(0, Remaining - delta)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Remaining = Math.Max(0, Remaining - delta)`

**赋值（含属性/字段和局部值）：**

- `Disabled` = `true`
- `Remaining` = `Math.Max(0, Remaining - delta)`

<a id="symbol-ff5abb90e6b4"></a>

## `NationalSpire.LiveRequestButton.MeasurePath() — private void MeasurePath()`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRequestButton._Draw()`](LiveRequestButton.cs.md#symbol-c15d43ebdf55)

**调用：** [`Arc(Godot.Vector2, float)`](LiveRequestButton.cs.md#symbol-6fc1ad3d4e4c)；`Godot.Vector2.DistanceTo(Godot.Vector2)`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.Generic.List<T>.ToArray()`；`System.Math.Max(float, float)`

**字段、属性、事件及方法组引用：** `Arc(Godot.Vector2, float)`；`NationalSpire.LiveRequestButton._lengths`；`NationalSpire.LiveRequestButton._path`；`NationalSpire.LiveRequestButton._pathSize`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Arc(Godot.Vector2, float)`；输入表达式：`Arc(new(left + radius, bottom - radius), -180)`；返回值紧邻使用处：`ExpressionStatementSyntax: Arc(new(left + radius, bottom - radius), -180);`
- `Arc(Godot.Vector2, float)`；输入表达式：`Arc(new(left + radius, top + radius), -90)`；返回值紧邻使用处：`ExpressionStatementSyntax: Arc(new(left + radius, top + radius), -90);`
- `Arc(Godot.Vector2, float)`；输入表达式：`Arc(new(right - radius, bottom - radius), -270)`；返回值紧邻使用处：`ExpressionStatementSyntax: Arc(new(right - radius, bottom - radius), -270);`
- `Arc(Godot.Vector2, float)`；输入表达式：`Arc(new(right - radius, top + radius), 0)`；返回值紧邻使用处：`ExpressionStatementSyntax: Arc(new(right - radius, top + radius), 0);`
- `Godot.Vector2.DistanceTo(Godot.Vector2)`；输入表达式：`_path[i - 1].DistanceTo(_path[i])`；返回值紧邻使用处：`BinaryExpressionSyntax: _lengths[i - 1] + _path[i - 1].DistanceTo(_path[i])`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(left + radius, bottom - radius)`；返回值紧邻使用处：`ArgumentSyntax: new(left + radius, bottom - radius)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(left + radius, top + radius)`；返回值紧邻使用处：`ArgumentSyntax: new(left + radius, top + radius)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(right - radius, bottom - radius)`；返回值紧邻使用处：`ArgumentSyntax: new(right - radius, bottom - radius)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(right - radius, top + radius)`；返回值紧邻使用处：`ArgumentSyntax: new(right - radius, top + radius)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`points.Add(points[0])`；返回值紧邻使用处：`ExpressionStatementSyntax: points.Add(points[0]);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Vector2>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<Vector2>()`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`points.ToArray()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _path = points.ToArray()`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(left + radius * 2, Size.X - inset)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(left + radius * 2, Size.X - inset)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(top + radius * 2, Size.Y - inset)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(top + radius * 2, Size.Y - inset)`

**赋值（含属性/字段和局部值）：**

- `_lengths[i]` = `_lengths[i - 1] + _path[i - 1].DistanceTo(_path[i])`
- `_lengths` = `new float[_path.Length]`
- `_pathSize` = `Size`
- `_path` = `points.ToArray()`

<a id="symbol-6fc1ad3d4e4c"></a>

## `Arc(Godot.Vector2, float) — void Arc(Vector2 center, float from)`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRequestButton.MeasurePath()`](LiveRequestButton.cs.md#symbol-ff5abb90e6b4)

**调用：** `Godot.Mathf.Cos(float)`；`Godot.Mathf.DegToRad(float)`；`Godot.Mathf.Sin(float)`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Mathf.Cos(float)`；输入表达式：`Mathf.Cos(angle)`；返回值紧邻使用处：`ArgumentSyntax: Mathf.Cos(angle)`
- `Godot.Mathf.DegToRad(float)`；输入表达式：`Mathf.DegToRad(from - i * 9)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Mathf.DegToRad(from - i * 9)`
- `Godot.Mathf.Sin(float)`；输入表达式：`Mathf.Sin(angle)`；返回值紧邻使用处：`ArgumentSyntax: Mathf.Sin(angle)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(Mathf.Cos(angle), Mathf.Sin(angle))`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)) * radius`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`points.Add(center + new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)) * radius)`；返回值紧邻使用处：`ExpressionStatementSyntax: points.Add(center + new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)) * radius);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c15d43ebdf55"></a>

## `NationalSpire.LiveRequestButton._Draw() — public override void _Draw()`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.Color.Color(string)`；`Godot.Vector2.Lerp(Godot.Vector2, float)`；[`NationalSpire.LiveRequestButton.MeasurePath()`](LiveRequestButton.cs.md#symbol-ff5abb90e6b4)；`System.Math.Clamp(float, float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateGames.ChatRequestSeconds`；`NationalSpire.LiveRequestButton.MeasurePath()`；`NationalSpire.LiveRequestButton.Remaining`；`NationalSpire.LiveRequestButton._lengths`；`NationalSpire.LiveRequestButton._path`；`NationalSpire.LiveRequestButton._pathSize`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(start, _path[i], color, 3.5f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(start, _path[i], color, 3.5f, true);`
- `Godot.Color.Color(string)`；输入表达式：`new Color("d6ccd1")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Color("d6ccd1")`
- `Godot.Vector2.Lerp(Godot.Vector2, float)`；输入表达式：`_path[i - 1].Lerp(_path[i], Math.Clamp((cut - _lengths[i - 1]) / segment, 0, 1))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _path[i - 1].Lerp(_path[i], Math.Clamp((cut - _lengths[i - 1]) / segment, 0, 1))`
- `NationalSpire.LiveRequestButton.MeasurePath()`；输入表达式：`MeasurePath()`；返回值紧邻使用处：`ExpressionStatementSyntax: MeasurePath();`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp((cut - _lengths[i - 1]) / segment, 0, 1)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp((cut - _lengths[i - 1]) / segment, 0, 1)`

**赋值（含属性/字段和局部值）：**
