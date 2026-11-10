# CommunityDiscussionVisuals.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`6497A642DB8A63A434CC22E9E5B36B68893DB1F3DF54192B5E53263A3946A383`。来源：[源码](../../CommunityDiscussionVisuals.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CommunityDiscussionLines`、`NationalSpire.CommunityReplyButton`、`NationalSpire.CommunityVoteButton`、`NationalSpire.CommunityShareButton`、`NationalSpire.CommunityReportButton`、`NationalSpire.CommunityBranchToggle`。

字段、事件及初始值（源码原样）：

```csharp
private readonly Dictionary<Control, List<Control>> _branches = new();
private readonly HashSet<Control> _observedCards = [];
private readonly HashSet<Control> _toggles = [];
private ArrayMesh? _guideMesh;
public const int Gutter = 32;
public const int Indent = 32;
public const int MaximumIndentDepth = 5;
public static readonly Color GuideColor = new("9ccfdf8c");
public const float AnchorY = 32;
```

<a id="symbol-22cd8303ac1f"></a>

## `NationalSpire.CommunityDiscussionLines._Ready() — public override void _Ready()`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Resized` += `QueueRedraw`
- `SortChildren` += `QueueRedraw`

<a id="symbol-1122f82357ce"></a>

## `NationalSpire.CommunityDiscussionLines.ConnectReply(Godot.Control, Godot.Control) — public void ConnectReply(Control parent, Control child)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-1799ee450143)

**调用：** `Godot.CanvasItem.QueueRedraw()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityDiscussionLines._branches`；`NationalSpire.CommunityDiscussionLines._observedCards`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_branches.TryGetValue(parent, out var children)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_branches.TryGetValue(parent, out var children)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`_observedCards.Add(child)`；返回值紧邻使用处：`IfStatementSyntax: if (_observedCards.Add(child)) child.ItemRectChanged += QueueRedraw;`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`_observedCards.Add(parent)`；返回值紧邻使用处：`IfStatementSyntax: if (_observedCards.Add(parent)) parent.ItemRectChanged += QueueRedraw;`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`children.Add(child)`；返回值紧邻使用处：`ExpressionStatementSyntax: children.Add(child);`

**赋值（含属性/字段和局部值）：**

- `_branches[parent]` = `children = []`
- `child.ItemRectChanged` += `QueueRedraw`
- `children` = `[]`
- `parent.ItemRectChanged` += `QueueRedraw`

<a id="symbol-bd63ab26d1a0"></a>

## `NationalSpire.CommunityDiscussionLines.RegisterToggle(Godot.Control) — public void RegisterToggle(Control card)`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-1799ee450143)

**调用：** `Godot.CanvasItem.QueueRedraw()`；`System.Collections.Generic.HashSet<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityDiscussionLines._observedCards`；`NationalSpire.CommunityDiscussionLines._toggles`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`_observedCards.Add(card)`；返回值紧邻使用处：`IfStatementSyntax: if (_observedCards.Add(card)) card.ItemRectChanged += QueueRedraw;`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`_toggles.Add(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: _toggles.Add(card);`

**赋值（含属性/字段和局部值）：**

- `card.ItemRectChanged` += `QueueRedraw`

<a id="symbol-a96fc3d1562d"></a>

## `NationalSpire.CommunityDiscussionLines._ExitTree() — public override void _ExitTree()`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.GodotObject.Dispose()`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityDiscussionLines._guideMesh`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _guideMesh?.Dispose()`

**赋值（含属性/字段和局部值）：**

- `_guideMesh` = `null`

<a id="symbol-cbb586cf4902"></a>

## `NationalSpire.CommunityDiscussionLines._Draw() — public override void _Draw()`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CommunityDiscussionLines.GuideGeometry(System.Collections.Generic.IReadOnlyList<Godot.Rect2>, System.Collections.Generic.IReadOnlyList<Godot.Rect2>)`](CommunityDiscussionVisuals.cs.md#symbol-b32fdd308a98)；`Godot.ArrayMesh.AddSurfaceFromArrays(Godot.Mesh.PrimitiveType, Godot.Collections.Array, Godot.Collections.Array<Godot.Collections.Array>, Godot.Collections.Dictionary, Godot.Mesh.ArrayFormat)`；`Godot.ArrayMesh.ArrayMesh()`；`Godot.CanvasItem.DrawMesh(Godot.Mesh, Godot.Texture2D, Godot.Transform2D?, Godot.Color?)`；`Godot.CanvasItem.GetGlobalTransform()`；`Godot.CanvasItem.IsVisibleInTree()`；`Godot.Collections.Array.Array()`；`Godot.Collections.Array.Resize(int)`；`Godot.GodotObject.Dispose()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Rect2.Rect2(float, float, float, float)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Transform2D.AffineInverse()`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Math.Max(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityDiscussionLines._branches`；`NationalSpire.CommunityDiscussionLines._guideMesh`；`NationalSpire.CommunityDiscussionLines._toggles`；`NationalSpire.CommunityDiscussionLines.AnchorY`；`NationalSpire.CommunityDiscussionLines.GuideColor`；`NationalSpire.CommunityDiscussionLines.GuideGeometry(System.Collections.Generic.IReadOnlyList<Godot.Rect2>, System.Collections.Generic.IReadOnlyList<Godot.Rect2>)`；`NationalSpire.CommunityDiscussionLines.Gutter`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.ArrayMesh.AddSurfaceFromArrays(Godot.Mesh.PrimitiveType, Godot.Collections.Array, Godot.Collections.Array<Godot.Collections.Array>, Godot.Collections.Dictionary, Godot.Mesh.ArrayFormat)`；输入表达式：`_guideMesh.AddSurfaceFromArrays(Mesh.PrimitiveType.Triangles, arrays)`；返回值紧邻使用处：`ExpressionStatementSyntax: _guideMesh.AddSurfaceFromArrays(Mesh.PrimitiveType.Triangles, arrays);`
- `Godot.ArrayMesh.ArrayMesh()`；输入表达式：`new ArrayMesh()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _guideMesh = new ArrayMesh()`
- `Godot.CanvasItem.DrawMesh(Godot.Mesh, Godot.Texture2D, Godot.Transform2D?, Godot.Color?)`；输入表达式：`DrawMesh(_guideMesh, null, Transform2D.Identity, GuideColor)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawMesh(_guideMesh, null, Transform2D.Identity, GuideColor);`
- `Godot.CanvasItem.GetGlobalTransform()`；输入表达式：`GetGlobalTransform()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetGlobalTransform().AffineInverse`
- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`card.IsVisibleInTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !card.IsVisibleInTree()`
- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`child.IsVisibleInTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !child.IsVisibleInTree()`
- `Godot.CanvasItem.IsVisibleInTree()`；输入表达式：`parent.IsVisibleInTree()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !parent.IsVisibleInTree()`
- `Godot.Collections.Array.Array()`；输入表达式：`new Godot.Collections.Array()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Godot.Collections.Array()`
- `Godot.Collections.Array.Resize(int)`；输入表达式：`arrays.Resize((int)Mesh.ArrayType.Max)`；返回值紧邻使用处：`ExpressionStatementSyntax: arrays.Resize((int)Mesh.ArrayType.Max);`
- `Godot.GodotObject.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _guideMesh?.Dispose()`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(card)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(card)`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(child)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(child)`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(parent)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(parent)`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new Rect2(from.X - halfWidth, from.Y, halfWidth * 2, bottom - from.Y + halfWidth)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(from.X - halfWidth, from.Y, halfWidth * 2, bottom - from.Y + halfWidth)`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new Rect2(from.X - halfWidth, to.Y - halfWidth, to.X - from.X + halfWidth, halfWidth * 2)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(from.X - halfWidth, to.Y - halfWidth, to.X - from.X + halfWidth, halfWidth * 2)`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new Rect2(center - new Vector2(11, 11), new Vector2(22, 22))`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(center - new Vector2(11, 11), new Vector2(22, 22))`
- `Godot.Transform2D.AffineInverse()`；输入表达式：`GetGlobalTransform().AffineInverse()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GetGlobalTransform().AffineInverse()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-3, AnchorY)`；返回值紧邻使用处：`BinaryExpressionSyntax: inverse * child.GlobalPosition + new Vector2(-3, AnchorY)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-Gutter / 2f, AnchorY)`；返回值紧邻使用处：`BinaryExpressionSyntax: inverse * card.GlobalPosition + new Vector2(-Gutter / 2f, AnchorY)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-Gutter / 2f, AnchorY)`；返回值紧邻使用处：`BinaryExpressionSyntax: inverse * parent.GlobalPosition + new Vector2(-Gutter / 2f, AnchorY)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(11, 11)`；返回值紧邻使用处：`BinaryExpressionSyntax: center - new Vector2(11, 11)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(22, 22)`；返回值紧邻使用处：`ArgumentSyntax: new Vector2(22, 22)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(rectangle.End.X, rectangle.Position.Y)`；返回值紧邻使用处：`AssignmentExpressionSyntax: vertices[v + 1] = new(rectangle.End.X, rectangle.Position.Y)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(rectangle.Position.X, rectangle.End.Y)`；返回值紧邻使用处：`AssignmentExpressionSyntax: vertices[v + 3] = new(rectangle.Position.X, rectangle.End.Y)`
- `NationalSpire.CommunityDiscussionLines.GuideGeometry(System.Collections.Generic.IReadOnlyList<Godot.Rect2>, System.Collections.Generic.IReadOnlyList<Godot.Rect2>)`；输入表达式：`GuideGeometry(strokes, holes)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GuideGeometry(strokes, holes)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`holes.Add(new Rect2(center - new Vector2(11, 11), new Vector2(22, 22)))`；返回值紧邻使用处：`ExpressionStatementSyntax: holes.Add(new Rect2(center - new Vector2(11, 11), new Vector2(22, 22)));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`strokes.Add(new Rect2(from.X - halfWidth, from.Y, halfWidth * 2, bottom - from.Y + halfWidth))`；返回值紧邻使用处：`ExpressionStatementSyntax: strokes.Add(new Rect2(from.X - halfWidth, from.Y, halfWidth * 2, bottom - from.Y + halfWidth));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`strokes.Add(new Rect2(from.X - halfWidth, to.Y - halfWidth, to.X - from.X + halfWidth, halfWidth * 2))`；返回值紧邻使用处：`ExpressionStatementSyntax: strokes.Add(new Rect2(from.X - halfWidth, to.Y - halfWidth, to.X - from.X + halfWidth, halfWidth * 2));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Rect2>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<Rect2>()`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(bottom, to.Y)`；返回值紧邻使用处：`AssignmentExpressionSyntax: bottom = Math.Max(bottom, to.Y)`

**赋值（含属性/字段和局部值）：**

- `_guideMesh` = `new ArrayMesh()`
- `_guideMesh` = `null`
- `arrays[(int)Mesh.ArrayType.Index]` = `indices`
- `arrays[(int)Mesh.ArrayType.Vertex]` = `vertices`
- `bottom` = `Math.Max(bottom, to.Y)`
- `indices[t + 1]` = `v + 1`
- `indices[t + 2]` = `v + 2`
- `indices[t + 3]` = `v`
- `indices[t + 4]` = `v + 2`
- `indices[t + 5]` = `v + 3`
- `indices[t]` = `v`
- `vertices[v + 1]` = `new(rectangle.End.X, rectangle.Position.Y)`
- `vertices[v + 2]` = `rectangle.End`
- `vertices[v + 3]` = `new(rectangle.Position.X, rectangle.End.Y)`
- `vertices[v]` = `rectangle.Position`

<a id="symbol-b32fdd308a98"></a>

## `NationalSpire.CommunityDiscussionLines.GuideGeometry(System.Collections.Generic.IReadOnlyList<Godot.Rect2>, System.Collections.Generic.IReadOnlyList<Godot.Rect2>) — internal static List<Rect2> GuideGeometry(IReadOnlyList<Rect2> strokes, IReadOnlyList<Rect2> holes)`

来源：源码第 90 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityDiscussionLines._Draw()`](CommunityDiscussionVisuals.cs.md#symbol-cbb586cf4902)

**调用：** [`Add(Godot.Rect2, bool)`](CommunityDiscussionVisuals.cs.md#symbol-be2fe26002a7)；`Godot.Rect2.Rect2(float, float, float, float)`；`System.Collections.Generic.IEnumerable<T>.Order<T>()`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.Generic.SortedDictionary<TKey, TValue>.SortedDictionary()`

**字段、属性、事件及方法组引用：** `(float x, int i).i`；`(float x, int i).x`；`(int Begin, int End, int Delta, bool Hole).Begin`；`(int Begin, int End, int Delta, bool Hole).Delta`；`(int Begin, int End, int Delta, bool Hole).End`；`(int Begin, int End, int Delta, bool Hole).Hole`；`Add(Godot.Rect2, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Add(Godot.Rect2, bool)`；输入表达式：`Add(hole, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(hole, true);`
- `Add(Godot.Rect2, bool)`；输入表达式：`Add(stroke, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(stroke, false);`
- `Godot.Rect2.Rect2(float, float, float, float)`；输入表达式：`new Rect2(xs[start], previous, xs[x] - xs[start], y - previous)`；返回值紧邻使用处：`ArgumentSyntax: new Rect2(xs[start], previous, xs[x] - xs[start], y - previous)`
- `System.Collections.Generic.IEnumerable<T>.Order<T>()`；输入表达式：`all.SelectMany(r => new[] { r.Position.X, r.End.X }).Distinct().Order()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: all.SelectMany(r => new[] { r.Position.X, r.End.X }).Distinct().Order().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`strokes.Concat(holes)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: strokes.Concat(holes).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`all.SelectMany(r => new[] { r.Position.X, r.End.X }).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: all.SelectMany(r => new[] { r.Position.X, r.End.X }).Distinct().Order`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；输入表达式：`events.First()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: events.First().Key`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`xs.Select((x, i) => (x, i))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: xs.Select((x, i) => (x, i)).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`all.SelectMany(r => new[] { r.Position.X, r.End.X })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: all.SelectMany(r => new[] { r.Position.X, r.End.X }).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`all.SelectMany(r => new[] { r.Position.X, r.End.X }).Distinct().Order().ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = all.SelectMany(r => new[] { r.Position.X, r.End.X }).Distinct().Order().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`strokes.Concat(holes).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = strokes.Concat(holes).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`xs.Select((x, i) => (x, i)).ToDictionary(p => p.x, p => p.i)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = xs.Select((x, i) => (x, i)).ToDictionary(p => p.x, p => p.i)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.Add(new Rect2(xs[start], previous, xs[x] - xs[start], y - previous))`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Add(new Rect2(xs[start], previous, xs[x] - xs[start], y - previous));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Rect2>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<Rect2>()`
- `System.Collections.Generic.SortedDictionary<TKey, TValue>.SortedDictionary()`；输入表达式：`new SortedDictionary<float, List<(int Begin, int End, int Delta, bool Hole)>>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new SortedDictionary<float, List<(int Begin, int End, int Delta, bool Hole)>>()`

**赋值（含属性/字段和局部值）：**

- `(entry.Hole ? cut : paint)[x]` += `entry.Delta`
- `previous` = `y`
- `start` = `-1`
- `start` = `x`

<a id="symbol-be2fe26002a7"></a>

## `Add(Godot.Rect2, bool) — void Add(Rect2 rect, bool hole)`

来源：源码第 98 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityDiscussionLines.GuideGeometry(System.Collections.Generic.IReadOnlyList<Godot.Rect2>, System.Collections.Generic.IReadOnlyList<Godot.Rect2>)`](CommunityDiscussionVisuals.cs.md#symbol-b32fdd308a98)

**调用：** `System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.SortedDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`entries.Add((columns[rect.Position.X], columns[rect.End.X], delta, hole))`；返回值紧邻使用处：`ExpressionStatementSyntax: entries.Add((columns[rect.Position.X], columns[rect.End.X], delta, hole));`
- `System.Collections.Generic.SortedDictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`events.TryGetValue(y, out var entries)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !events.TryGetValue(y, out var entries)`

**赋值（含属性/字段和局部值）：**

- `entries` = `[]`
- `events[y]` = `entries = []`

<a id="symbol-6642cc1b3037"></a>

## `NationalSpire.CommunityReplyButton.MainPost — public bool MainPost`

来源：源码第 130 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1e11e4f0b913"></a>

## `NationalSpire.CommunityReplyButton._Ready() — public override void _Ready()`

来源：源码第 132 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CommunityReplyButton.MainPost`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`AddThemeStyleboxOverride("focus", CareerVisuals.Box("00000000", "789aa4", 6, 0))`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeStyleboxOverride("focus", CareerVisuals.Box("00000000", "789aa4", 6, 0));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`AddThemeStyleboxOverride("hover", CareerVisuals.Box("28495a", "28495a", 6, 0))`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeStyleboxOverride("hover", CareerVisuals.Box("28495a", "28495a", 6, 0));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`AddThemeStyleboxOverride("normal", new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeStyleboxOverride("normal", new StyleBoxEmpty());`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`AddThemeStyleboxOverride("pressed", CareerVisuals.Box("304f60", "70d4bc", 6, 0))`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeStyleboxOverride("pressed", CareerVisuals.Box("304f60", "70d4bc", 6, 0));`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(34, 30)`；返回值紧邻使用处：`ConditionalExpressionSyntax: MainPost ? new Vector2(40, 36) : new Vector2(34, 30)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(40, 36)`；返回值紧邻使用处：`ConditionalExpressionSyntax: MainPost ? new Vector2(40, 36) : new Vector2(34, 30)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("00000000", "789aa4", 6, 0)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("00000000", "789aa4", 6, 0)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("28495a", "28495a", 6, 0)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("28495a", "28495a", 6, 0)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("304f60", "70d4bc", 6, 0)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("304f60", "70d4bc", 6, 0)`

**赋值（含属性/字段和局部值）：**

- `ButtonDown` += `QueueRedraw`
- `ButtonUp` += `QueueRedraw`
- `CustomMinimumSize` = `MainPost ? new Vector2(40, 36) : new Vector2(34, 30)`
- `Flat` = `true`
- `FocusEntered` += `QueueRedraw`
- `FocusExited` += `QueueRedraw`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `MouseEntered` += `QueueRedraw`
- `MouseExited` += `QueueRedraw`
- `Resized` += `QueueRedraw`
- `SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`

<a id="symbol-ad5a59182a9d"></a>

## `NationalSpire.CommunityReplyButton._Draw() — public override void _Draw()`

来源：源码第 148 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`P(float, float)`](CommunityDiscussionVisuals.cs.md#symbol-e35b9baf76e6)；`Godot.BaseButton.IsHovered()`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；`Godot.Control.HasFocus()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Ink`；`NationalSpire.CareerVisuals.Muted`；`NationalSpire.CommunityReplyButton.MainPost`；`P(float, float)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.IsHovered()`；输入表达式：`IsHovered()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsHovered() || HasFocus()`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(P(-4, -1), P(4, -1), color, 1.3f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(P(-4, -1), P(4, -1), color, 1.3f, true);`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([P(-7, -6), P(7, -6), P(9, -4), P(9, 3), P(7, 5), P(-1, 5),              P(-6, 9), P(-6, 5), P(-7, 5), P(-9, 3), P(-9, -4), P(-7, -6)], color, 1.5f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([P(-7, -6), P(7, -6), P(9, -4), P(9, 3), P(7, 5), P(-1, 5),              P(-6, 9), P(-6, 5), P(-7, 5), P(-9, 3), P(-9, -4), P(-7, -6)], color, 1.5f, true);`
- `Godot.Control.HasFocus()`；输入表达式：`HasFocus()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsHovered() || HasFocus()`
- `P(float, float)`；输入表达式：`P(-1, 5)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-1, 5)`
- `P(float, float)`；输入表达式：`P(-4, -1)`；返回值紧邻使用处：`ArgumentSyntax: P(-4, -1)`
- `P(float, float)`；输入表达式：`P(-6, 5)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-6, 5)`
- `P(float, float)`；输入表达式：`P(-6, 9)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-6, 9)`
- `P(float, float)`；输入表达式：`P(-7, -6)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-7, -6)`
- `P(float, float)`；输入表达式：`P(-7, 5)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-7, 5)`
- `P(float, float)`；输入表达式：`P(-9, -4)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-9, -4)`
- `P(float, float)`；输入表达式：`P(-9, 3)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-9, 3)`
- `P(float, float)`；输入表达式：`P(4, -1)`；返回值紧邻使用处：`ArgumentSyntax: P(4, -1)`
- `P(float, float)`；输入表达式：`P(7, -6)`；返回值紧邻使用处：`ExpressionElementSyntax: P(7, -6)`
- `P(float, float)`；输入表达式：`P(7, 5)`；返回值紧邻使用处：`ExpressionElementSyntax: P(7, 5)`
- `P(float, float)`；输入表达式：`P(9, -4)`；返回值紧邻使用处：`ExpressionElementSyntax: P(9, -4)`
- `P(float, float)`；输入表达式：`P(9, 3)`；返回值紧邻使用处：`ExpressionElementSyntax: P(9, 3)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e35b9baf76e6"></a>

## `P(float, float) — Vector2 P(float x, float y)`

来源：源码第 153 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityReplyButton._Draw()`](CommunityDiscussionVisuals.cs.md#symbol-ad5a59182a9d)

**调用：** `Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(x, y)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(x, y) * scale`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c33f3f704bcd"></a>

## `NationalSpire.CommunityVoteButton.Direction — public int Direction`

来源：源码第 163 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3213f0d16f2f"></a>

## `NationalSpire.CommunityVoteButton.MainPost — public bool MainPost`

来源：源码第 164 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-19ed81df80db"></a>

## `NationalSpire.CommunityVoteButton._Ready() — public override void _Ready()`

来源：源码第 166 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CommunityVoteButton.MainPost`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`AddThemeStyleboxOverride("focus", CareerVisuals.Box("00000000", "789aa4", 6, 0))`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeStyleboxOverride("focus", CareerVisuals.Box("00000000", "789aa4", 6, 0));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`AddThemeStyleboxOverride("normal", new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeStyleboxOverride("normal", new StyleBoxEmpty());`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(34, 30)`；返回值紧邻使用处：`ConditionalExpressionSyntax: MainPost ? new Vector2(40, 36) : new Vector2(34, 30)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(40, 36)`；返回值紧邻使用处：`ConditionalExpressionSyntax: MainPost ? new Vector2(40, 36) : new Vector2(34, 30)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("00000000", "789aa4", 6, 0)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("00000000", "789aa4", 6, 0)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `MainPost ? new Vector2(40, 36) : new Vector2(34, 30)`
- `Flat` = `true`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`
- `ToggleMode` = `true`

<a id="symbol-1ecae47c2c04"></a>

## `NationalSpire.CommunityVoteButton._Notification(int) — public override void _Notification(int what)`

来源：源码第 176 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.QueueRedraw()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7a14da46f25c"></a>

## `NationalSpire.CommunityVoteButton._Draw() — public override void _Draw()`

来源：源码第 182 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`P(float, float)`](CommunityDiscussionVisuals.cs.md#symbol-ba2eeb522fe8)；`Godot.BaseButton.IsHovered()`；`Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；`Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；`Godot.Color.Color(string)`；`Godot.Control.HasFocus()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Ink`；`NationalSpire.CareerVisuals.Muted`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.CommunityVoteButton.Direction`；`NationalSpire.CommunityVoteButton.MainPost`；`P(float, float)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.IsHovered()`；输入表达式：`IsHovered()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsHovered() || HasFocus()`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon(cuff[..^1], color)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon(cuff[..^1], color);`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon(hand[..^1], color)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon(hand[..^1], color);`
- `Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；输入表达式：`DrawPolyline(cuff, color, 1.5f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline(cuff, color, 1.5f, true);`
- `Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；输入表达式：`DrawPolyline(hand, color, 1.5f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline(hand, color, 1.5f, true);`
- `Godot.Color.Color(string)`；输入表达式：`new Color("f09090")`；返回值紧邻使用处：`ConditionalExpressionSyntax: Direction > 0 ? CareerVisuals.Teal : new Color("f09090")`
- `Godot.Control.HasFocus()`；输入表达式：`HasFocus()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsHovered() || HasFocus()`
- `P(float, float)`；输入表达式：`P(-4, -2)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-4, -2)`
- `P(float, float)`；输入表达式：`P(-4, 8)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-4, 8)`
- `P(float, float)`；输入表达式：`P(-8, -2)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-8, -2)`
- `P(float, float)`；输入表达式：`P(-8, 8)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-8, 8)`
- `P(float, float)`；输入表达式：`P(0, -10)`；返回值紧邻使用处：`ExpressionElementSyntax: P(0, -10)`
- `P(float, float)`；输入表达式：`P(0, -7)`；返回值紧邻使用处：`ExpressionElementSyntax: P(0, -7)`
- `P(float, float)`；输入表达式：`P(10, -1)`；返回值紧邻使用处：`ExpressionElementSyntax: P(10, -1)`
- `P(float, float)`；输入表达式：`P(3, -10)`；返回值紧邻使用处：`ExpressionElementSyntax: P(3, -10)`
- `P(float, float)`；输入表达式：`P(3, -3)`；返回值紧邻使用处：`ExpressionElementSyntax: P(3, -3)`
- `P(float, float)`；输入表达式：`P(4, -7)`；返回值紧邻使用处：`ExpressionElementSyntax: P(4, -7)`
- `P(float, float)`；输入表达式：`P(6, 8)`；返回值紧邻使用处：`ExpressionElementSyntax: P(6, 8)`
- `P(float, float)`；输入表达式：`P(8, -3)`；返回值紧邻使用处：`ExpressionElementSyntax: P(8, -3)`
- `P(float, float)`；输入表达式：`P(8, 6)`；返回值紧邻使用处：`ExpressionElementSyntax: P(8, 6)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ba2eeb522fe8"></a>

## `P(float, float) — Vector2 P(float x, float y)`

来源：源码第 188 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityVoteButton._Draw()`](CommunityDiscussionVisuals.cs.md#symbol-7a14da46f25c)

**调用：** `Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityVoteButton.Direction`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(x, y * Direction)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(x, y * Direction) * scale`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9b1ecb690f6f"></a>

## `NationalSpire.CommunityShareButton.MainPost — public bool MainPost`

来源：源码第 201 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c9b514864c3c"></a>

## `NationalSpire.CommunityShareButton._Ready() — public override void _Ready()`

来源：源码第 203 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CommunityShareButton.MainPost`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`AddThemeStyleboxOverride("focus", CareerVisuals.Box("00000000", "789aa4", 6, 0))`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeStyleboxOverride("focus", CareerVisuals.Box("00000000", "789aa4", 6, 0));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`AddThemeStyleboxOverride("normal", new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeStyleboxOverride("normal", new StyleBoxEmpty());`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(34, 30)`；返回值紧邻使用处：`ConditionalExpressionSyntax: MainPost ? new Vector2(40, 36) : new Vector2(34, 30)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(40, 36)`；返回值紧邻使用处：`ConditionalExpressionSyntax: MainPost ? new Vector2(40, 36) : new Vector2(34, 30)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("00000000", "789aa4", 6, 0)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("00000000", "789aa4", 6, 0)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `MainPost ? new Vector2(40, 36) : new Vector2(34, 30)`
- `Flat` = `true`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`

<a id="symbol-91e8bb97a2b1"></a>

## `NationalSpire.CommunityShareButton._Notification(int) — public override void _Notification(int what)`

来源：源码第 213 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.QueueRedraw()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2636868a2ff3"></a>

## `NationalSpire.CommunityShareButton._Draw() — public override void _Draw()`

来源：源码第 218 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`P(float, float)`](CommunityDiscussionVisuals.cs.md#symbol-6904267349fe)；`Godot.BaseButton.IsHovered()`；`Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.Control.HasFocus()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Ink`；`NationalSpire.CareerVisuals.Muted`；`NationalSpire.CommunityShareButton.MainPost`；`P(float, float)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.IsHovered()`；输入表达式：`IsHovered()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsHovered() || HasFocus()`
- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(point, 3 * scale, 0, Mathf.Tau, 24, color, 1.5f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(point, 3 * scale, 0, Mathf.Tau, 24, color, 1.5f, true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(P(-4, -1.5f), P(4, -6), color, 1.5f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(P(-4, -1.5f), P(4, -6), color, 1.5f, true);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(P(-4, 1.5f), P(4, 6), color, 1.5f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(P(-4, 1.5f), P(4, 6), color, 1.5f, true);`
- `Godot.Control.HasFocus()`；输入表达式：`HasFocus()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsHovered() || HasFocus()`
- `P(float, float)`；输入表达式：`P(-4, -1.5f)`；返回值紧邻使用处：`ArgumentSyntax: P(-4, -1.5f)`
- `P(float, float)`；输入表达式：`P(-4, 1.5f)`；返回值紧邻使用处：`ArgumentSyntax: P(-4, 1.5f)`
- `P(float, float)`；输入表达式：`P(-7, 0)`；返回值紧邻使用处：`InitializerExpressionSyntax: { P(-7, 0), P(7, -7), P(7, 7) }`
- `P(float, float)`；输入表达式：`P(4, -6)`；返回值紧邻使用处：`ArgumentSyntax: P(4, -6)`
- `P(float, float)`；输入表达式：`P(4, 6)`；返回值紧邻使用处：`ArgumentSyntax: P(4, 6)`
- `P(float, float)`；输入表达式：`P(7, -7)`；返回值紧邻使用处：`InitializerExpressionSyntax: { P(-7, 0), P(7, -7), P(7, 7) }`
- `P(float, float)`；输入表达式：`P(7, 7)`；返回值紧邻使用处：`InitializerExpressionSyntax: { P(-7, 0), P(7, -7), P(7, 7) }`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6904267349fe"></a>

## `P(float, float) — Vector2 P(float x, float y)`

来源：源码第 223 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityShareButton._Draw()`](CommunityDiscussionVisuals.cs.md#symbol-2636868a2ff3)

**调用：** `Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(x, y)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(x, y) * scale`

**赋值（含属性/字段和局部值）：**


<a id="symbol-51d0f6ee9c9f"></a>

## `NationalSpire.CommunityReportButton.MainPost — public bool MainPost`

来源：源码第 234 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a9c948c158eb"></a>

## `NationalSpire.CommunityReportButton._Ready() — public override void _Ready()`

来源：源码第 236 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CommunityReportButton.MainPost`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`AddThemeStyleboxOverride("focus", CareerVisuals.Box("00000000", "789aa4", 6, 0))`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeStyleboxOverride("focus", CareerVisuals.Box("00000000", "789aa4", 6, 0));`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`AddThemeStyleboxOverride("normal", new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeStyleboxOverride("normal", new StyleBoxEmpty());`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(34, 30)`；返回值紧邻使用处：`ConditionalExpressionSyntax: MainPost ? new Vector2(40, 36) : new Vector2(34, 30)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(40, 36)`；返回值紧邻使用处：`ConditionalExpressionSyntax: MainPost ? new Vector2(40, 36) : new Vector2(34, 30)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("00000000", "789aa4", 6, 0)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("00000000", "789aa4", 6, 0)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `MainPost ? new Vector2(40, 36) : new Vector2(34, 30)`
- `Flat` = `true`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `SizeFlagsVertical` = `SizeFlags.ShrinkCenter`

<a id="symbol-4eee2b234157"></a>

## `NationalSpire.CommunityReportButton._Notification(int) — public override void _Notification(int what)`

来源：源码第 246 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.QueueRedraw()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d864c02753f7"></a>

## `NationalSpire.CommunityReportButton._Draw() — public override void _Draw()`

来源：源码第 251 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`P(float, float)`](CommunityDiscussionVisuals.cs.md#symbol-49913ad08b35)；`Godot.BaseButton.IsHovered()`；`Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；`Godot.Control.HasFocus()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Gold`；`NationalSpire.CareerVisuals.Muted`；`NationalSpire.CommunityReportButton.MainPost`；`P(float, float)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.IsHovered()`；输入表达式：`IsHovered()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsHovered() || HasFocus()`
- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；输入表达式：`DrawCircle(P(0, 5), 1 * scale, color)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(P(0, 5), 1 * scale, color);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(P(0, -3), P(0, 2), color, 1.8f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(P(0, -3), P(0, 2), color, 1.8f, true);`
- `Godot.CanvasItem.DrawPolyline(System.ReadOnlySpan<Godot.Vector2>, Godot.Color, float, bool)`；输入表达式：`DrawPolyline([P(0, -11), P(12, 10), P(-12, 10), P(0, -11)], color, 1.5f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline([P(0, -11), P(12, 10), P(-12, 10), P(0, -11)], color, 1.5f, true);`
- `Godot.Control.HasFocus()`；输入表达式：`HasFocus()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsHovered() || HasFocus()`
- `P(float, float)`；输入表达式：`P(-12, 10)`；返回值紧邻使用处：`ExpressionElementSyntax: P(-12, 10)`
- `P(float, float)`；输入表达式：`P(0, -11)`；返回值紧邻使用处：`ExpressionElementSyntax: P(0, -11)`
- `P(float, float)`；输入表达式：`P(0, -3)`；返回值紧邻使用处：`ArgumentSyntax: P(0, -3)`
- `P(float, float)`；输入表达式：`P(0, 2)`；返回值紧邻使用处：`ArgumentSyntax: P(0, 2)`
- `P(float, float)`；输入表达式：`P(0, 5)`；返回值紧邻使用处：`ArgumentSyntax: P(0, 5)`
- `P(float, float)`；输入表达式：`P(12, 10)`；返回值紧邻使用处：`ExpressionElementSyntax: P(12, 10)`

**赋值（含属性/字段和局部值）：**

- `A` = `.35f`

<a id="symbol-49913ad08b35"></a>

## `P(float, float) — Vector2 P(float x, float y)`

来源：源码第 257 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityReportButton._Draw()`](CommunityDiscussionVisuals.cs.md#symbol-d864c02753f7)

**调用：** `Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(x, y)`；返回值紧邻使用处：`BinaryExpressionSyntax: new Vector2(x, y) * scale`

**赋值（含属性/字段和局部值）：**


<a id="symbol-bfc34e301cbd"></a>

## `NationalSpire.CommunityBranchToggle.Collapsed — public bool Collapsed`

来源：源码第 266 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4a0a87159c6b"></a>

## `NationalSpire.CommunityBranchToggle._Ready() — public override void _Ready()`

来源：源码第 268 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.StyleBoxEmpty.StyleBoxEmpty()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`AddThemeStyleboxOverride(state, new StyleBoxEmpty())`；返回值紧邻使用处：`ExpressionStatementSyntax: AddThemeStyleboxOverride(state, new StyleBoxEmpty());`
- `Godot.StyleBoxEmpty.StyleBoxEmpty()`；输入表达式：`new StyleBoxEmpty()`；返回值紧邻使用处：`ArgumentSyntax: new StyleBoxEmpty()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(28, 28)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(28, 28)`

**赋值（含属性/字段和局部值）：**

- `CustomMinimumSize` = `new Vector2(28, 28)`
- `Flat` = `true`
- `FocusEntered` += `QueueRedraw`
- `FocusExited` += `QueueRedraw`
- `MouseDefaultCursorShape` = `CursorShape.PointingHand`
- `MouseEntered` += `QueueRedraw`
- `MouseExited` += `QueueRedraw`
- `Resized` += `QueueRedraw`

<a id="symbol-491baf06a41d"></a>

## `NationalSpire.CommunityBranchToggle._Draw() — public override void _Draw()`

来源：源码第 280 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.BaseButton.IsHovered()`；`Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；`Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；`Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；`Godot.Color.Color(string)`；`Godot.Color.Lightened(float)`；`Godot.Control.HasFocus()`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityBranchToggle.Collapsed`；`NationalSpire.CommunityDiscussionLines.GuideColor`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.BaseButton.IsHovered()`；输入表达式：`IsHovered()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsHovered() || HasFocus()`
- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(center, 9, 0, Mathf.Tau, 32, color, 1.4f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(center, 9, 0, Mathf.Tau, 32, color, 1.4f, true);`
- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；输入表达式：`DrawCircle(center, 9, new Color("142332"))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(center, 9, new Color("142332"));`
- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon(new Vector2[] { new(-4,-.75f),new(-.75f,-.75f),new(-.75f,-4),new(.75f,-4),new(.75f,-.75f),new(4,-.75f),new(4,.75f),new(.75f,.75f),new(.75f,4),new(-.75f,4),new(-.75f,.75f),new(-4,.75f) }.Select(p => center + p).ToArray(), color)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawColoredPolygon(new Vector2[] { new(-4,-.75f),new(-.75f,-.75f),new(-.75f,-4),new(.75f,-4),new(.75f,-.75f),new(4,-.75f),new(4,.75f),new(.75f,.75f),new(.75f,4),new(-.75f,4),new(-.75f,.75f),new(-4,.75f) }.Select(p => center + p).ToArray(), color);`
- `Godot.CanvasItem.DrawLine(Godot.Vector2, Godot.Vector2, Godot.Color, float, bool)`；输入表达式：`DrawLine(center + new Vector2(-4, 0), center + new Vector2(4, 0), color, 1.5f, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawLine(center + new Vector2(-4, 0), center + new Vector2(4, 0), color, 1.5f, true);`
- `Godot.Color.Color(string)`；输入表达式：`new Color("142332")`；返回值紧邻使用处：`ArgumentSyntax: new Color("142332")`
- `Godot.Color.Lightened(float)`；输入表达式：`CommunityDiscussionLines.GuideColor.Lightened(.15f)`；返回值紧邻使用处：`ConditionalExpressionSyntax: highlighted ? CommunityDiscussionLines.GuideColor.Lightened(.15f) : CommunityDiscussionLines.GuideColor`
- `Godot.Control.HasFocus()`；输入表达式：`HasFocus()`；返回值紧邻使用处：`BinaryExpressionSyntax: IsHovered() || HasFocus()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(-4, 0)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(-4, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(4, 0)`；返回值紧邻使用处：`BinaryExpressionSyntax: center + new Vector2(4, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(-.75f,-.75f)`；返回值紧邻使用处：`InitializerExpressionSyntax: { new(-4,-.75f),new(-.75f,-.75f),new(-.75f,-4),new(.75f,-4),new(.75f,-.75f),new(4,-.75f),new(4,.75f),new(.75f,.75f),new(.75f,4),new(-.75f,4),new(-.75f,.75f),new(-4,.75f) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(-.75f,-4)`；返回值紧邻使用处：`InitializerExpressionSyntax: { new(-4,-.75f),new(-.75f,-.75f),new(-.75f,-4),new(.75f,-4),new(.75f,-.75f),new(4,-.75f),new(4,.75f),new(.75f,.75f),new(.75f,4),new(-.75f,4),new(-.75f,.75f),new(-4,.75f) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(-.75f,.75f)`；返回值紧邻使用处：`InitializerExpressionSyntax: { new(-4,-.75f),new(-.75f,-.75f),new(-.75f,-4),new(.75f,-4),new(.75f,-.75f),new(4,-.75f),new(4,.75f),new(.75f,.75f),new(.75f,4),new(-.75f,4),new(-.75f,.75f),new(-4,.75f) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(-.75f,4)`；返回值紧邻使用处：`InitializerExpressionSyntax: { new(-4,-.75f),new(-.75f,-.75f),new(-.75f,-4),new(.75f,-4),new(.75f,-.75f),new(4,-.75f),new(4,.75f),new(.75f,.75f),new(.75f,4),new(-.75f,4),new(-.75f,.75f),new(-4,.75f) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(-4,-.75f)`；返回值紧邻使用处：`InitializerExpressionSyntax: { new(-4,-.75f),new(-.75f,-.75f),new(-.75f,-4),new(.75f,-4),new(.75f,-.75f),new(4,-.75f),new(4,.75f),new(.75f,.75f),new(.75f,4),new(-.75f,4),new(-.75f,.75f),new(-4,.75f) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(-4,.75f)`；返回值紧邻使用处：`InitializerExpressionSyntax: { new(-4,-.75f),new(-.75f,-.75f),new(-.75f,-4),new(.75f,-4),new(.75f,-.75f),new(4,-.75f),new(4,.75f),new(.75f,.75f),new(.75f,4),new(-.75f,4),new(-.75f,.75f),new(-4,.75f) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(.75f,-.75f)`；返回值紧邻使用处：`InitializerExpressionSyntax: { new(-4,-.75f),new(-.75f,-.75f),new(-.75f,-4),new(.75f,-4),new(.75f,-.75f),new(4,-.75f),new(4,.75f),new(.75f,.75f),new(.75f,4),new(-.75f,4),new(-.75f,.75f),new(-4,.75f) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(.75f,-4)`；返回值紧邻使用处：`InitializerExpressionSyntax: { new(-4,-.75f),new(-.75f,-.75f),new(-.75f,-4),new(.75f,-4),new(.75f,-.75f),new(4,-.75f),new(4,.75f),new(.75f,.75f),new(.75f,4),new(-.75f,4),new(-.75f,.75f),new(-4,.75f) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(.75f,.75f)`；返回值紧邻使用处：`InitializerExpressionSyntax: { new(-4,-.75f),new(-.75f,-.75f),new(-.75f,-4),new(.75f,-4),new(.75f,-.75f),new(4,-.75f),new(4,.75f),new(.75f,.75f),new(.75f,4),new(-.75f,4),new(-.75f,.75f),new(-4,.75f) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(.75f,4)`；返回值紧邻使用处：`InitializerExpressionSyntax: { new(-4,-.75f),new(-.75f,-.75f),new(-.75f,-4),new(.75f,-4),new(.75f,-.75f),new(4,-.75f),new(4,.75f),new(.75f,.75f),new(.75f,4),new(-.75f,4),new(-.75f,.75f),new(-4,.75f) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(4,-.75f)`；返回值紧邻使用处：`InitializerExpressionSyntax: { new(-4,-.75f),new(-.75f,-.75f),new(-.75f,-4),new(.75f,-4),new(.75f,-.75f),new(4,-.75f),new(4,.75f),new(.75f,.75f),new(.75f,4),new(-.75f,4),new(-.75f,.75f),new(-4,.75f) }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(4,.75f)`；返回值紧邻使用处：`InitializerExpressionSyntax: { new(-4,-.75f),new(-.75f,-.75f),new(-.75f,-4),new(.75f,-4),new(.75f,-.75f),new(4,-.75f),new(4,.75f),new(.75f,.75f),new(.75f,4),new(-.75f,4),new(-.75f,.75f),new(-4,.75f) }`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`new Vector2[] { new(-4,-.75f),new(-.75f,-.75f),new(-.75f,-4),new(.75f,-4),new(.75f,-.75f),new(4,-.75f),new(4,.75f),new(.75f,.75f),new(.75f,4),new(-.75f,4),new(-.75f,.75f),new(-4,.75f) }.Select(p => center + p)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new Vector2[] { new(-4,-.75f),new(-.75f,-.75f),new(-.75f,-4),new(.75f,-4),new(.75f,-.75f),new(4,-.75f),new(4,.75f),new(.75f,.75f),new(.75f,4),new(-.75f,4),new(-.75f,.75f),new(-4,.75f) }.Select(p => center + p).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`new Vector2[] { new(-4,-.75f),new(-.75f,-.75f),new(-.75f,-4),new(.75f,-4),new(.75f,-.75f),new(4,-.75f),new(4,.75f),new(.75f,.75f),new(.75f,4),new(-.75f,4),new(-.75f,.75f),new(-4,.75f) }.Select(p => center + p).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: new Vector2[] { new(-4,-.75f),new(-.75f,-.75f),new(-.75f,-4),new(.75f,-4),new(.75f,-.75f),new(4,-.75f),new(4,.75f),new(.75f,.75f),new(.75f,4),new(-.75f,4),new(-.75f,.75f),new(-4,.75f) }.Select(p => center + p).ToArray()`

**赋值（含属性/字段和局部值）：**
