# ConsumerVisuals.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`1426E67A406541BC2ECE929851BB9EF6BCA82C2E23E37745AADE00505440CBCE`。来源：[源码](../../ConsumerVisuals.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.ConsumerVisuals`、`NationalSpire.ConsumerSeal`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly Dictionary<(bool, bool), StyleBoxFlat> Styles = [];
private static readonly Dictionary<(bool Current, bool Selected, bool Hover), StyleBoxFlat> Products = [];
```

<a id="symbol-4d4df8cb62c8"></a>

## `NationalSpire.ConsumerVisuals.ProductStyle(Godot.Button, bool, bool) — public static void ProductStyle(Button button, bool current, bool selected)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)；[`Select(NationalSpire.Good)`](ConsumerScreen.cs.md#symbol-5012d526c517)

**调用：** [`Get(bool, bool)`](ConsumerVisuals.cs.md#symbol-0db6dc7411c3)；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`

**字段、属性、事件及方法组引用：** `Get(bool, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Get(bool, bool)`；输入表达式：`Get(selected, false)`；返回值紧邻使用处：`ArgumentSyntax: Get(selected, false)`
- `Get(bool, bool)`；输入表达式：`Get(selected, true)`；返回值紧邻使用处：`ArgumentSyntax: Get(selected, true)`
- `Get(bool, bool)`；输入表达式：`Get(true, false)`；返回值紧邻使用处：`ArgumentSyntax: Get(true, false)`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("hover", Get(selected, true))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("hover", Get(selected, true));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("normal", Get(selected, false))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("normal", Get(selected, false));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`button.AddThemeStyleboxOverride("pressed", Get(true, false))`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeStyleboxOverride("pressed", Get(true, false));`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0db6dc7411c3"></a>

## `Get(bool, bool) — StyleBoxFlat Get(bool active, bool hover)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ConsumerVisuals.ProductStyle(Godot.Button, bool, bool)`](ConsumerVisuals.cs.md#symbol-4d4df8cb62c8)

**调用：** [`NationalSpire.ConsumerVisuals.Accent(bool)`](ConsumerVisuals.cs.md#symbol-03b075ea8cd2)；[`NationalSpire.ConsumerVisuals.Style(bool, bool)`](ConsumerVisuals.cs.md#symbol-340545590823)；`Godot.Color.Color(Godot.Color, float)`；`Godot.Color.Color(string)`；`Godot.Color.Lerp(Godot.Color, float)`；`Godot.Resource.Duplicate(bool)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerVisuals.Accent(bool)`；`NationalSpire.ConsumerVisuals.Products`；`NationalSpire.ConsumerVisuals.Style(bool, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(Accent(current), active ? .95f : hover ? .7f : .3f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: style.BorderColor = new Color(Accent(current), active ? .95f : hover ? .7f : .3f)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("10202d")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new Color("10202d").Lerp`
- `Godot.Color.Lerp(Godot.Color, float)`；输入表达式：`new Color("10202d").Lerp(Accent(current), active ? .18f : hover ? .12f : .04f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: style.BgColor = new Color("10202d").Lerp(Accent(current), active ? .18f : hover ? .12f : .04f)`
- `Godot.Resource.Duplicate(bool)`；输入表达式：`Style(current, false).Duplicate()`；返回值紧邻使用处：`CastExpressionSyntax: (StyleBoxFlat)Style(current, false).Duplicate()`
- `NationalSpire.ConsumerVisuals.Accent(bool)`；输入表达式：`Accent(current)`；返回值紧邻使用处：`ArgumentSyntax: Accent(current)`
- `NationalSpire.ConsumerVisuals.Style(bool, bool)`；输入表达式：`Style(current, false)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Style(current, false).Duplicate`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Products.TryGetValue((current, active, hover), out var cached)`；返回值紧邻使用处：`IfStatementSyntax: if (Products.TryGetValue((current, active, hover), out var cached)) return cached;`

**赋值（含属性/字段和局部值）：**

- `Products[(current, active, hover)]` = `style`
- `style.BgColor` = `new Color("10202d").Lerp(Accent(current), active ? .18f : hover ? .12f : .04f)`
- `style.BorderColor` = `new Color(Accent(current), active ? .95f : hover ? .7f : .3f)`
- `style.BorderWidthLeft` = `active ? 4 : 2`

<a id="symbol-03b075ea8cd2"></a>

## `NationalSpire.ConsumerVisuals.Accent(bool) — public static Color Accent(bool current)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Get(bool, bool)`](ConsumerVisuals.cs.md#symbol-0db6dc7411c3)；[`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)；[`NationalSpire.ConsumerSeal._Draw()`](ConsumerVisuals.cs.md#symbol-7339db409b51)；[`NationalSpire.ConsumerVisuals.Style(bool, bool)`](ConsumerVisuals.cs.md#symbol-340545590823)

**调用：** `Godot.Color.Color(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Teal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color("e4c780")`；返回值紧邻使用处：`ConditionalExpressionSyntax: current ? CareerVisuals.Teal : new Color("e4c780")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-340545590823"></a>

## `NationalSpire.ConsumerVisuals.Style(bool, bool) — public static StyleBoxFlat Style(bool current, bool badge)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Get(bool, bool)`](ConsumerVisuals.cs.md#symbol-0db6dc7411c3)；[`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.ConsumerVisuals.Accent(bool)`](ConsumerVisuals.cs.md#symbol-03b075ea8cd2)；`Godot.Color.Color(Godot.Color, float)`；`Godot.Color.Color(string)`；`Godot.Color.Lerp(Godot.Color, float)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.ConsumerVisuals.Accent(bool)`；`NationalSpire.ConsumerVisuals.Styles`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(accent, badge ? .8f : .55f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: style.BorderColor = new Color(accent, badge ? .8f : .55f)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(new Color("10202d").Lerp(accent, badge ? .16f : .065f), .98f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: style.BgColor = new Color(new Color("10202d").Lerp(accent, badge ? .16f : .065f), .98f)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("10202d")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new Color("10202d").Lerp`
- `Godot.Color.Lerp(Godot.Color, float)`；输入表达式：`new Color("10202d").Lerp(accent, badge ? .16f : .065f)`；返回值紧邻使用处：`ArgumentSyntax: new Color("10202d").Lerp(accent, badge ? .16f : .065f)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("10232e", "345363", badge ? 7 : 12, badge ? 7 : 16)`；返回值紧邻使用处：`AssignmentExpressionSyntax: style = CareerVisuals.Box("10232e", "345363", badge ? 7 : 12, badge ? 7 : 16)`
- `NationalSpire.ConsumerVisuals.Accent(bool)`；输入表达式：`Accent(current)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Accent(current)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Styles.TryGetValue((current, badge), out var style)`；返回值紧邻使用处：`IfStatementSyntax: if (Styles.TryGetValue((current, badge), out var style)) return style;`

**赋值（含属性/字段和局部值）：**

- `style.BgColor` = `new Color(new Color("10202d").Lerp(accent, badge ? .16f : .065f), .98f)`
- `style.BorderColor` = `new Color(accent, badge ? .8f : .55f)`
- `style.BorderWidthLeft` = `3`
- `style` = `CareerVisuals.Box("10232e", "345363", badge ? 7 : 12, badge ? 7 : 16)`
- `Styles[(current, badge)]` = `style`

<a id="symbol-7943fd7c0a0e"></a>

## `NationalSpire.ConsumerSeal.Current — public bool Current`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a125ab141376"></a>

## `NationalSpire.ConsumerSeal.Ticket — public bool Ticket`

来源：源码第 42 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-cf18fc608c5b"></a>

## `NationalSpire.ConsumerSeal.Promo — public bool Promo`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-378d84a3bedd"></a>

## `NationalSpire.ConsumerSeal.Count — public int Count`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3a6432da4809"></a>

## `NationalSpire.ConsumerSeal.ConsumerSeal() — public ConsumerSeal()`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerShop(NationalSpire.CareerData)`](ConsumerScreen.cs.md#symbol-992c668fa0a5)

**调用：** `Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(24, 24)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(24, 24)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new(24, 24)`
- `MouseFilter` = `MouseFilterEnum.Ignore`

<a id="symbol-7339db409b51"></a>

## `NationalSpire.ConsumerSeal._Draw() — public override void _Draw()`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.ConsumerVisuals.Accent(bool)`](ConsumerVisuals.cs.md#symbol-03b075ea8cd2)；`Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；`Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；`Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float)`；`Godot.Color.Color(Godot.Color, float)`；`Godot.Rect2.Rect2(float, float, float, float)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.ConsumerCatalog.PromoPerSeason`；`NationalSpire.ConsumerSeal.Count`；`NationalSpire.ConsumerSeal.Current`；`NationalSpire.ConsumerSeal.Promo`；`NationalSpire.ConsumerSeal.Ticket`；`NationalSpire.ConsumerVisuals.Accent(bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(new(12, 12), 10, 0, Mathf.Tau, 32, color, 1.5f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(new(12, 12), 10, 0, Mathf.Tau, 32, color, 1.5f, true);`
- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；输入表达式：`DrawCircle(new(12, 12), 10, new Color(color, .2f))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(new(12, 12), 10, new Color(color, .2f));`
- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；输入表达式：`DrawCircle(new(12, 12), 3, color)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(new(12, 12), 3, color);`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon([new(12, 2), new(22, 12), new(12, 22), new(2, 12)], new Color(color, .2f))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon([new(12, 2), new(22, 12), new(12, 22), new(2, 12)], new Color(color, .2f));`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new(16, 6), new(16, 18), color, 1.5f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new(16, 6), new(16, 18), color, 1.5f, true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new(5, 10), new(12, 10), color, 1.5f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new(5, 10), new(12, 10), color, 1.5f, true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(new(5, 14), new(10, 14), color, 1.5f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(new(5, 14), new(10, 14), color, 1.5f, true);`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([new(12, 2), new(22, 12), new(12, 22), new(2, 12), new(12, 2)], color, 1.5f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([new(12, 2), new(22, 12), new(12, 22), new(2, 12), new(12, 2)], color, 1.5f, true);`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([new(6, 12), new(10, 16), new(18, 8)], color, 2.5f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([new(6, 12), new(10, 16), new(18, 8)], color, 2.5f, true);`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；输入表达式：`DrawRect(new Rect2(2, 5, 20, 14), new Color(color, .18f))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(new Rect2(2, 5, 20, 14), new Color(color, .18f));`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；输入表达式：`DrawRect(rect, i < Count ? color : new Color(color, .12f))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(rect, i < Count ? color : new Color(color, .12f));`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float, bool)`；输入表达式：`DrawRect(rect, new Color(color, .7f), false)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(rect, new Color(color, .7f), false);`
- `Godot.CanvasItem.DrawRect(Godot.Rect2, Godot.Color, bool, float)`；输入表达式：`DrawRect(new Rect2(2, 5, 20, 14), color, false, 1.5f)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawRect(new Rect2(2, 5, 20, 14), color, false, 1.5f);`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(color, .12f)`；返回值紧邻使用处：`ConditionalExpressionSyntax: i < Count ? color : new Color(color, .12f)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(color, .18f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(color, .18f)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(color, .2f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(color, .2f)`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(color, .7f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(color, .7f)`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new Rect2(2, 5, 20, 14)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(2, 5, 20, 14)`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new Rect2(i * 8, 6, 5, 13)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Rect2(i * 8, 6, 5, 13)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(10, 14)`；返回值紧邻使用处：`ArgumentSyntax: new(10, 14)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(10, 16)`；返回值紧邻使用处：`ExpressionElementSyntax: new(10, 16)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(12, 10)`；返回值紧邻使用处：`ArgumentSyntax: new(12, 10)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(12, 12)`；返回值紧邻使用处：`ArgumentSyntax: new(12, 12)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(12, 2)`；返回值紧邻使用处：`ExpressionElementSyntax: new(12, 2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(12, 22)`；返回值紧邻使用处：`ExpressionElementSyntax: new(12, 22)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(16, 18)`；返回值紧邻使用处：`ArgumentSyntax: new(16, 18)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(16, 6)`；返回值紧邻使用处：`ArgumentSyntax: new(16, 6)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(18, 8)`；返回值紧邻使用处：`ExpressionElementSyntax: new(18, 8)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(2, 12)`；返回值紧邻使用处：`ExpressionElementSyntax: new(2, 12)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(22, 12)`；返回值紧邻使用处：`ExpressionElementSyntax: new(22, 12)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(5, 10)`；返回值紧邻使用处：`ArgumentSyntax: new(5, 10)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(5, 14)`；返回值紧邻使用处：`ArgumentSyntax: new(5, 14)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(6, 12)`；返回值紧邻使用处：`ExpressionElementSyntax: new(6, 12)`
- `NationalSpire.ConsumerVisuals.Accent(bool)`；输入表达式：`ConsumerVisuals.Accent(Current)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ConsumerVisuals.Accent(Current)`

**赋值（含属性/字段和局部值）：**
