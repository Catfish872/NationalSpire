# AvatarFrameDrawing.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`8CA77617734948E1E44C225A73C11969845C8DF158980BA3EA13D163937361E9`。来源：[源码](../../AvatarFrameDrawing.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerAvatar`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-85654168c2bc"></a>

## `NationalSpire.CareerAvatar.DrawMetalFrame(NationalSpire.AvatarFrame) — private void DrawMetalFrame(AvatarFrame frame)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAvatar.DrawHonors(NationalSpire.AvatarIdentity)`](CareerAvatars.cs.md#symbol-e94ed9976fb6)

**调用：** [`Octagon(float, float)`](AvatarFrameDrawing.cs.md#symbol-aa56b78dde46)；[`P(float, float)`](AvatarFrameDrawing.cs.md#symbol-02a7b3d8e0ed)；[`P(float, float)`](AvatarFrameDrawing.cs.md#symbol-7b66cc740838)；[`Ring(float, float, Godot.Color)`](AvatarFrameDrawing.cs.md#symbol-70e0c20a0ac2)；[`Shape(Godot.Color, params Godot.Vector2[])`](AvatarFrameDrawing.cs.md#symbol-806f5f5a7a65)；[`Stroke(Godot.Color, float, params Godot.Vector2[])`](AvatarFrameDrawing.cs.md#symbol-218332effc6c)；`Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；`Godot.Color.Color(Godot.Color, float)`；`Godot.Color.Color(string)`；`Godot.Color.Darkened(float)`；`Godot.Color.Lightened(float)`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Math.Max(float, float)`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarFrame.Color`；`NationalSpire.AvatarFrame.Grade`；`Octagon(float, float)`；`P(float, float)`；`Ring(float, float, Godot.Color)`；`Shape(Godot.Color, params Godot.Vector2[])`；`Stroke(Godot.Color, float, params Godot.Vector2[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；输入表达式：`DrawPolyline(halo.Append(halo[0]).ToArray(), new Color(glow, .14f), Math.Max(2, scale * 5), true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline(halo.Append(halo[0]).ToArray(), new Color(glow, .14f), Math.Max(2, scale * 5), true);`
- `Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；输入表达式：`DrawPolyline(insetEdge.Append(insetEdge[0]).ToArray(), new Color("07131f"), Math.Max(1, scale * 2), true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolyline(insetEdge.Append(insetEdge[0]).ToArray(), new Color("07131f"), Math.Max(1, scale * 2), true);`
- `Godot.Color.Color(Godot.Color, float)`；输入表达式：`new Color(glow, .14f)`；返回值紧邻使用处：`ArgumentSyntax: new Color(glow, .14f)`
- `Godot.Color.Color(string)`；输入表达式：`new Color("07131f")`；返回值紧邻使用处：`ArgumentSyntax: new Color("07131f")`
- `Godot.Color.Color(string)`；输入表达式：`new Color("65dad1")`；返回值紧邻使用处：`ArgumentSyntax: new Color("65dad1")`
- `Godot.Color.Color(string)`；输入表达式：`new Color(frame.Color)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Color(frame.Color)`
- `Godot.Color.Color(string)`；输入表达式：`new Color(frame.Grade == 2 ? "81cfe5" : frame.Grade >= 7 ? "fff0b6" : frame.Color)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Color(frame.Grade == 2 ? "81cfe5" : frame.Grade >= 7 ? "fff0b6" : frame.Color)`
- `Godot.Color.Darkened(float)`；输入表达式：`glow.Darkened(.15f)`；返回值紧邻使用处：`ArgumentSyntax: glow.Darkened(.15f)`
- `Godot.Color.Darkened(float)`；输入表达式：`metal.Darkened(.12f)`；返回值紧邻使用处：`ArgumentSyntax: metal.Darkened(.12f)`
- `Godot.Color.Darkened(float)`；输入表达式：`metal.Darkened(.58f)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = metal.Darkened(.58f)`
- `Godot.Color.Lightened(float)`；输入表达式：`metal.Lightened(.6f)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = metal.Lightened(.6f)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0, 58)`；返回值紧邻使用处：`ArgumentSyntax: new(0, 58)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(100, 58)`；返回值紧邻使用处：`ArgumentSyntax: new(100, 58)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(11, 18)`；返回值紧邻使用处：`ArgumentSyntax: new(11, 18)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(11, 37)`；返回值紧邻使用处：`ArgumentSyntax: new(11, 37)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(12, 66)`；返回值紧邻使用处：`ArgumentSyntax: new(12, 66)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(12, 82)`；返回值紧邻使用处：`ArgumentSyntax: new(12, 82)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(16, 11)`；返回值紧邻使用处：`ArgumentSyntax: new(16, 11)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(16, 82)`；返回值紧邻使用处：`ArgumentSyntax: new(16, 82)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(18, 88)`；返回值紧邻使用处：`ArgumentSyntax: new(18, 88)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(23, 94)`；返回值紧邻使用处：`ArgumentSyntax: new(23, 94)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(28, 0)`；返回值紧邻使用处：`ArgumentSyntax: new(28, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(30, 1)`；返回值紧邻使用处：`ArgumentSyntax: new(30, 1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(30, 6)`；返回值紧邻使用处：`ArgumentSyntax: new(30, 6)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(33, 3)`；返回值紧邻使用处：`ArgumentSyntax: new(33, 3)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(34, 20)`；返回值紧邻使用处：`ArgumentSyntax: new(34, 20)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(35, 10)`；返回值紧邻使用处：`ArgumentSyntax: new(35, 10)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(35, 11)`；返回值紧邻使用处：`ArgumentSyntax: new(35, 11)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(36, 14)`；返回值紧邻使用处：`ArgumentSyntax: new(36, 14)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(36, 16)`；返回值紧邻使用处：`ArgumentSyntax: new(36, 16)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(36, 17)`；返回值紧邻使用处：`ArgumentSyntax: new(36, 17)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(38, 1)`；返回值紧邻使用处：`ArgumentSyntax: new(38, 1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(39, 5)`；返回值紧邻使用处：`ArgumentSyntax: new(39, 5)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(4, 25)`；返回值紧邻使用处：`ArgumentSyntax: new(4, 25)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(4, 33)`；返回值紧邻使用处：`ArgumentSyntax: new(4, 33)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(4, 44)`；返回值紧邻使用处：`ArgumentSyntax: new(4, 44)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(41, 3)`；返回值紧邻使用处：`ArgumentSyntax: new(41, 3)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(41, 5)`；返回值紧邻使用处：`ArgumentSyntax: new(41, 5)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(42, 10)`；返回值紧邻使用处：`ArgumentSyntax: new(42, 10)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(42, 8)`；返回值紧邻使用处：`ArgumentSyntax: new(42, 8)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(44, 2)`；返回值紧邻使用处：`ArgumentSyntax: new(44, 2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(47, 10)`；返回值紧邻使用处：`ArgumentSyntax: new(47, 10)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(50 - gem - 3, 6)`；返回值紧邻使用处：`ArgumentSyntax: new(50 - gem - 3, 6)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(50 - gem, 6)`；返回值紧邻使用处：`ArgumentSyntax: new(50 - gem, 6)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(50 + gem + 3, 6)`；返回值紧邻使用处：`ArgumentSyntax: new(50 + gem + 3, 6)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(50 + gem, 6)`；返回值紧邻使用处：`ArgumentSyntax: new(50 + gem, 6)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(50, 0)`；返回值紧邻使用处：`ArgumentSyntax: new(50, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(50, 1)`；返回值紧邻使用处：`ArgumentSyntax: new(50, 1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(50, 10)`；返回值紧邻使用处：`ArgumentSyntax: new(50, 10)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(50, 14)`；返回值紧邻使用处：`ArgumentSyntax: new(50, 14)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(50, 15)`；返回值紧邻使用处：`ArgumentSyntax: new(50, 15)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(50, 16)`；返回值紧邻使用处：`ArgumentSyntax: new(50, 16)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(50, 19)`；返回值紧邻使用处：`ArgumentSyntax: new(50, 19)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(50, 6)`；返回值紧邻使用处：`ArgumentSyntax: new(50, 6)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(50, 8)`；返回值紧邻使用处：`ArgumentSyntax: new(50, 8)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(51, 94)`；返回值紧邻使用处：`ArgumentSyntax: new(51, 94)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(53, 10)`；返回值紧邻使用处：`ArgumentSyntax: new(53, 10)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(56, 2)`；返回值紧邻使用处：`ArgumentSyntax: new(56, 2)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(56, 88)`；返回值紧邻使用处：`ArgumentSyntax: new(56, 88)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(58, 10)`；返回值紧邻使用处：`ArgumentSyntax: new(58, 10)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(58, 8)`；返回值紧邻使用处：`ArgumentSyntax: new(58, 8)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(59, 3)`；返回值紧邻使用处：`ArgumentSyntax: new(59, 3)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(59, 5)`；返回值紧邻使用处：`ArgumentSyntax: new(59, 5)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(61, 5)`；返回值紧邻使用处：`ArgumentSyntax: new(61, 5)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(62, 1)`；返回值紧邻使用处：`ArgumentSyntax: new(62, 1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(64, 16)`；返回值紧邻使用处：`ArgumentSyntax: new(64, 16)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(64, 17)`；返回值紧邻使用处：`ArgumentSyntax: new(64, 17)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(65, 10)`；返回值紧邻使用处：`ArgumentSyntax: new(65, 10)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(66, 20)`；返回值紧邻使用处：`ArgumentSyntax: new(66, 20)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(67, 3)`；返回值紧邻使用处：`ArgumentSyntax: new(67, 3)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(7, 73)`；返回值紧邻使用处：`ArgumentSyntax: new(7, 73)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(70, 1)`；返回值紧邻使用处：`ArgumentSyntax: new(70, 1)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(70, 6)`；返回值紧邻使用处：`ArgumentSyntax: new(70, 6)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(72, 0)`；返回值紧邻使用处：`ArgumentSyntax: new(72, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(8, 28)`；返回值紧邻使用处：`ArgumentSyntax: new(8, 28)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(84, 82)`；返回值紧邻使用处：`ArgumentSyntax: new(84, 82)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(88, 66)`；返回值紧邻使用处：`ArgumentSyntax: new(88, 66)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(89, 36)`；返回值紧邻使用处：`ArgumentSyntax: new(89, 36)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(89, 63)`；返回值紧邻使用处：`ArgumentSyntax: new(89, 63)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(9, 61)`；返回值紧邻使用处：`ArgumentSyntax: new(9, 61)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(91, 61)`；返回值紧邻使用处：`ArgumentSyntax: new(91, 61)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(93, 73)`；返回值紧邻使用处：`ArgumentSyntax: new(93, 73)`
- `Octagon(float, float)`；输入表达式：`Octagon(2, 11)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Octagon(2, 11)`
- `Octagon(float, float)`；输入表达式：`Octagon(grade == 1 ? 8 : 10, 8)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Octagon(grade == 1 ? 8 : 10, 8)`
- `P(float, float)`；输入表达式：`P(0, 17)`；返回值紧邻使用处：`ArgumentSyntax: P(0, 17)`
- `P(float, float)`；输入表达式：`P(0, 39)`；返回值紧邻使用处：`ArgumentSyntax: P(0, 39)`
- `P(float, float)`；输入表达式：`P(0, y + 3)`；返回值紧邻使用处：`ArgumentSyntax: P(0, y + 3)`
- `P(float, float)`；输入表达式：`P(1, 17)`；返回值紧邻使用处：`ArgumentSyntax: P(1, 17)`
- `P(float, float)`；输入表达式：`P(1, 19)`；返回值紧邻使用处：`ArgumentSyntax: P(1, 19)`
- `P(float, float)`；输入表达式：`P(1, 35)`；返回值紧邻使用处：`ArgumentSyntax: P(1, 35)`
- `P(float, float)`；输入表达式：`P(1, 44)`；返回值紧邻使用处：`ArgumentSyntax: P(1, 44)`
- `P(float, float)`；输入表达式：`P(1, 60)`；返回值紧邻使用处：`ArgumentSyntax: P(1, 60)`
- `P(float, float)`；输入表达式：`P(1, y - 4)`；返回值紧邻使用处：`ArgumentSyntax: P(1, y - 4)`
- `P(float, float)`；输入表达式：`P(13, 76)`；返回值紧邻使用处：`ArgumentSyntax: P(13, 76)`
- `P(float, float)`；输入表达式：`P(14, y + 5)`；返回值紧邻使用处：`ArgumentSyntax: P(14, y + 5)`
- `P(float, float)`；输入表达式：`P(15, 5)`；返回值紧邻使用处：`ArgumentSyntax: P(15, 5)`
- `P(float, float)`；输入表达式：`P(15, y - 2)`；返回值紧邻使用处：`ArgumentSyntax: P(15, y - 2)`
- `P(float, float)`；输入表达式：`P(16, 8)`；返回值紧邻使用处：`ArgumentSyntax: P(16, 8)`
- `P(float, float)`；输入表达式：`P(17, 0)`；返回值紧邻使用处：`ArgumentSyntax: P(17, 0)`
- `P(float, float)`；输入表达式：`P(17, 1)`；返回值紧邻使用处：`ArgumentSyntax: P(17, 1)`
- `P(float, float)`；输入表达式：`P(28, 5)`；返回值紧邻使用处：`ArgumentSyntax: P(28, 5)`
- `P(float, float)`；输入表达式：`P(29, 7)`；返回值紧邻使用处：`ArgumentSyntax: P(29, 7)`
- `P(float, float)`；输入表达式：`P(34, 1)`；返回值紧邻使用处：`ArgumentSyntax: P(34, 1)`
- `P(float, float)`；输入表达式：`P(36, 0)`；返回值紧邻使用处：`ArgumentSyntax: P(36, 0)`
- `P(float, float)`；输入表达式：`P(5, 16)`；返回值紧邻使用处：`ArgumentSyntax: P(5, 16)`
- `P(float, float)`；输入表达式：`P(6, 16)`；返回值紧邻使用处：`ArgumentSyntax: P(6, 16)`
- `P(float, float)`；输入表达式：`P(6, 30)`；返回值紧邻使用处：`ArgumentSyntax: P(6, 30)`
- `P(float, float)`；输入表达式：`P(7, 30)`；返回值紧邻使用处：`ArgumentSyntax: P(7, 30)`
- `P(float, float)`；输入表达式：`P(7, 32)`；返回值紧邻使用处：`ArgumentSyntax: P(7, 32)`
- `P(float, float)`；输入表达式：`P(7, 39)`；返回值紧邻使用处：`ArgumentSyntax: P(7, 39)`
- `P(float, float)`；输入表达式：`P(7, 54)`；返回值紧邻使用处：`ArgumentSyntax: P(7, 54)`
- `P(float, float)`；输入表达式：`P(7, 60)`；返回值紧邻使用处：`ArgumentSyntax: P(7, 60)`
- `P(float, float)`；输入表达式：`P(7, y + 12)`；返回值紧邻使用处：`ArgumentSyntax: P(7, y + 12)`
- `P(float, float)`；输入表达式：`P(8, 18)`；返回值紧邻使用处：`ArgumentSyntax: P(8, 18)`
- `P(float, float)`；输入表达式：`P(8, y + 3)`；返回值紧邻使用处：`ArgumentSyntax: P(8, y + 3)`
- `Ring(float, float, Godot.Color)`；输入表达式：`Ring(3, grade == 1 ? 4 : 6, metal)`；返回值紧邻使用处：`ExpressionStatementSyntax: Ring(3, grade == 1 ? 4 : 6, metal);`
- `Shape(Godot.Color, params Godot.Vector2[])`；输入表达式：`Shape(glow, P(1, 44), P(7, 39), P(7, 54), P(1, 60))`；返回值紧邻使用处：`ExpressionStatementSyntax: Shape(glow, P(1, 44), P(7, 39), P(7, 54), P(1, 60));`
- `Shape(Godot.Color, params Godot.Vector2[])`；输入表达式：`Shape(light, new(0, 58), new(9, 61), new(12, 66))`；返回值紧邻使用处：`ExpressionStatementSyntax: Shape(light, new(0, 58), new(9, 61), new(12, 66));`
- `Shape(Godot.Color, params Godot.Vector2[])`；输入表达式：`Shape(light, new(100, 58), new(91, 61), new(88, 66))`；返回值紧邻使用处：`ExpressionStatementSyntax: Shape(light, new(100, 58), new(91, 61), new(88, 66));`
- `Shape(Godot.Color, params Godot.Vector2[])`；输入表达式：`Shape(light, new(30, 1), new(42, 8), new(50, 0), new(50, 14), new(36, 14))`；返回值紧邻使用处：`ExpressionStatementSyntax: Shape(light, new(30, 1), new(42, 8), new(50, 0), new(50, 14), new(36, 14));`
- `Shape(Godot.Color, params Godot.Vector2[])`；输入表达式：`Shape(light, new(33, 3), new(39, 5), new(35, 10), new(30, 6))`；返回值紧邻使用处：`ExpressionStatementSyntax: Shape(light, new(33, 3), new(39, 5), new(35, 10), new(30, 6));`
- `Shape(Godot.Color, params Godot.Vector2[])`；输入表达式：`Shape(light, new(4, 25), new(11, 18), new(8, 28), new(4, 33))`；返回值紧邻使用处：`ExpressionStatementSyntax: Shape(light, new(4, 25), new(11, 18), new(8, 28), new(4, 33));`
- `Shape(Godot.Color, params Godot.Vector2[])`；输入表达式：`Shape(light, new(50 - gem, 6), new(50, 1), new(50, 16))`；返回值紧邻使用处：`ExpressionStatementSyntax: Shape(light, new(50 - gem, 6), new(50, 1), new(50, 16));`
- `Shape(Godot.Color, params Godot.Vector2[])`；输入表达式：`Shape(light, new(67, 3), new(61, 5), new(65, 10), new(70, 6))`；返回值紧邻使用处：`ExpressionStatementSyntax: Shape(light, new(67, 3), new(61, 5), new(65, 10), new(70, 6));`
- `Shape(Godot.Color, params Godot.Vector2[])`；输入表达式：`Shape(light, P(1, 17), P(17, 1), P(34, 1), P(28, 5), P(15, 5), P(5, 16))`；返回值紧邻使用处：`ExpressionStatementSyntax: Shape(light, P(1, 17), P(17, 1), P(34, 1), P(28, 5), P(15, 5), P(5, 16));`
- `Shape(Godot.Color, params Godot.Vector2[])`；输入表达式：`Shape(light, P(7, y + 12), P(8, y + 3), P(15, y - 2), P(14, y + 5))`；返回值紧邻使用处：`ExpressionStatementSyntax: Shape(light, P(7, y + 12), P(8, y + 3), P(15, y - 2), P(14, y + 5));`
- `Shape(Godot.Color, params Godot.Vector2[])`；输入表达式：`Shape(metal, new(0, 58), new(12, 66), new(16, 82), new(7, 73))`；返回值紧邻使用处：`ExpressionStatementSyntax: Shape(metal, new(0, 58), new(12, 66), new(16, 82), new(7, 73));`
- `Shape(Godot.Color, params Godot.Vector2[])`；输入表达式：`Shape(metal, new(100, 58), new(88, 66), new(84, 82), new(93, 73))`；返回值紧邻使用处：`ExpressionStatementSyntax: Shape(metal, new(100, 58), new(88, 66), new(84, 82), new(93, 73));`
- `Shape(Godot.Color, params Godot.Vector2[])`；输入表达式：`Shape(metal, new(30, 1), new(42, 8), new(50, 0), new(58, 8), new(70, 1), new(64, 16), new(36, 16))`；返回值紧邻使用处：`ExpressionStatementSyntax: Shape(metal, new(30, 1), new(42, 8), new(50, 0), new(58, 8), new(70, 1), new(64, 16), new(36, 16));`
- `Shape(Godot.Color, params Godot.Vector2[])`；输入表达式：`Shape(metal, new(4, 25), new(11, 18), new(11, 37), new(4, 44))`；返回值紧邻使用处：`ExpressionStatementSyntax: Shape(metal, new(4, 25), new(11, 18), new(11, 37), new(4, 44));`
- `Shape(Godot.Color, params Godot.Vector2[])`；输入表达式：`Shape(metal, P(1, 19), P(6, 16), P(6, 30), P(1, 35))`；返回值紧邻使用处：`ExpressionStatementSyntax: Shape(metal, P(1, 19), P(6, 16), P(6, 30), P(1, 35));`
- `Shape(Godot.Color, params Godot.Vector2[])`；输入表达式：`Shape(metal, P(7, y + 12), P(0, y + 3), P(1, y - 4), P(8, y + 3))`；返回值紧邻使用处：`ExpressionStatementSyntax: Shape(metal, P(7, y + 12), P(0, y + 3), P(1, y - 4), P(8, y + 3));`
- `Shape(Godot.Color, params Godot.Vector2[])`；输入表达式：`Shape(metal.Darkened(.12f), new(50, 1), new(50 + gem, 6), new(50, 16))`；返回值紧邻使用处：`ExpressionStatementSyntax: Shape(metal.Darkened(.12f), new(50, 1), new(50 + gem, 6), new(50, 16));`
- `Shape(Godot.Color, params Godot.Vector2[])`；输入表达式：`Shape(new Color("65dad1"), new(47, 10), new(50, 6), new(53, 10), new(50, 14))`；返回值紧邻使用处：`ExpressionStatementSyntax: Shape(new Color("65dad1"), new(47, 10), new(50, 6), new(53, 10), new(50, 14));`
- `Shape(Godot.Color, params Godot.Vector2[])`；输入表达式：`Shape(shade, new(28, 0), new(41, 5), new(50, 0), new(59, 5), new(72, 0), new(66, 20), new(34, 20))`；返回值紧邻使用处：`ExpressionStatementSyntax: Shape(shade, new(28, 0), new(41, 5), new(50, 0), new(59, 5), new(72, 0), new(66, 20), new(34, 20));`
- `Shape(Godot.Color, params Godot.Vector2[])`；输入表达式：`Shape(shade, new(38, 1), new(62, 1), new(58, 10), new(50, 15), new(42, 10))`；返回值紧邻使用处：`ExpressionStatementSyntax: Shape(shade, new(38, 1), new(62, 1), new(58, 10), new(50, 15), new(42, 10));`
- `Shape(Godot.Color, params Godot.Vector2[])`；输入表达式：`Shape(shade, new(50 - gem - 3, 6), new(50, 0), new(50 + gem + 3, 6), new(50, 19))`；返回值紧邻使用处：`ExpressionStatementSyntax: Shape(shade, new(50 - gem - 3, 6), new(50, 0), new(50 + gem + 3, 6), new(50, 19));`
- `Shape(Godot.Color, params Godot.Vector2[])`；输入表达式：`Shape(shade, P(0, 17), P(17, 0), P(36, 0), P(29, 7), P(16, 8), P(8, 18), P(7, 32), P(0, 39))`；返回值紧邻使用处：`ExpressionStatementSyntax: Shape(shade, P(0, 17), P(17, 0), P(36, 0), P(29, 7), P(16, 8), P(8, 18), P(7, 32), P(0, 39));`
- `Stroke(Godot.Color, float, params Godot.Vector2[])`；输入表达式：`Stroke(glow, 1, new(50 - gem, 6), new(50, 8), new(50 + gem, 6))`；返回值紧邻使用处：`ExpressionStatementSyntax: Stroke(glow, 1, new(50 - gem, 6), new(50, 8), new(50 + gem, 6));`
- `Stroke(Godot.Color, float, params Godot.Vector2[])`；输入表达式：`Stroke(glow, 1.5f, new(16, 11), new(35, 11))`；返回值紧邻使用处：`ExpressionStatementSyntax: Stroke(glow, 1.5f, new(16, 11), new(35, 11));`
- `Stroke(Godot.Color, float, params Godot.Vector2[])`；输入表达式：`Stroke(glow, 1.5f, new(44, 2), new(50, 6), new(56, 2))`；返回值紧邻使用处：`ExpressionStatementSyntax: Stroke(glow, 1.5f, new(44, 2), new(50, 6), new(56, 2));`
- `Stroke(Godot.Color, float, params Godot.Vector2[])`；输入表达式：`Stroke(glow, 2, new(23, 94), new(51, 94))`；返回值紧邻使用处：`ExpressionStatementSyntax: Stroke(glow, 2, new(23, 94), new(51, 94));`
- `Stroke(Godot.Color, float, params Godot.Vector2[])`；输入表达式：`Stroke(glow, 2, new(36, 17), new(64, 17))`；返回值紧邻使用处：`ExpressionStatementSyntax: Stroke(glow, 2, new(36, 17), new(64, 17));`
- `Stroke(Godot.Color, float, params Godot.Vector2[])`；输入表达式：`Stroke(glow.Darkened(.15f), 1.5f, new(89, 36), new(89, 63))`；返回值紧邻使用处：`ExpressionStatementSyntax: Stroke(glow.Darkened(.15f), 1.5f, new(89, 36), new(89, 63));`
- `Stroke(Godot.Color, float, params Godot.Vector2[])`；输入表达式：`Stroke(light, 2, new(12, 82), new(18, 88), new(56, 88))`；返回值紧邻使用处：`ExpressionStatementSyntax: Stroke(light, 2, new(12, 82), new(18, 88), new(56, 88));`
- `Stroke(Godot.Color, float, params Godot.Vector2[])`；输入表达式：`Stroke(light, 2, new(41, 3), new(50, 10), new(59, 3))`；返回值紧邻使用处：`ExpressionStatementSyntax: Stroke(light, 2, new(41, 3), new(50, 10), new(59, 3));`
- `Stroke(Godot.Color, float, params Godot.Vector2[])`；输入表达式：`Stroke(shade, 2, P(13, 76), P(7, 60), P(7, 30))`；返回值紧邻使用处：`ExpressionStatementSyntax: Stroke(shade, 2, P(13, 76), P(7, 60), P(7, 30));`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`halo.Append(halo[0])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: halo.Append(halo[0]).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`insetEdge.Append(insetEdge[0])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: insetEdge.Append(insetEdge[0]).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`halo.Append(halo[0]).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: halo.Append(halo[0]).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`insetEdge.Append(insetEdge[0]).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: insetEdge.Append(insetEdge[0]).ToArray()`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(1, scale * 2)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(1, scale * 2)`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(2, scale * 5)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(2, scale * 5)`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(Size.X, Size.Y)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(Size.X, Size.Y) / 100f`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d02a65dd0a6f"></a>

## `Point(float, float) — Vector2 Point(float x, float y)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Octagon(float, float)`](AvatarFrameDrawing.cs.md#symbol-aa56b78dde46)

**调用：** `Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(x * scale, y * scale)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new(x * scale, y * scale)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-806f5f5a7a65"></a>

## `Shape(Godot.Color, params Godot.Vector2[]) — void Shape(Color tint, params Vector2[] points)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAvatar.DrawMetalFrame(NationalSpire.AvatarFrame)`](AvatarFrameDrawing.cs.md#symbol-85654168c2bc)

**调用：** `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawColoredPolygon(Godot.Vector2[], Godot.Color, Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawColoredPolygon(points.Select(p => p * scale).ToArray(), tint)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => DrawColoredPolygon(points.Select(p => p * scale).ToArray(), tint)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`points.Select(p => p * scale)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: points.Select(p => p * scale).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`points.Select(p => p * scale).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: points.Select(p => p * scale).ToArray()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-218332effc6c"></a>

## `Stroke(Godot.Color, float, params Godot.Vector2[]) — void Stroke(Color tint, float width, params Vector2[] points)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAvatar.DrawMetalFrame(NationalSpire.AvatarFrame)`](AvatarFrameDrawing.cs.md#symbol-85654168c2bc)

**调用：** `Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Math.Max(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawPolyline(Godot.Vector2[], Godot.Color, float, bool)`；输入表达式：`DrawPolyline(points.Select(p => p * scale).ToArray(), tint, Math.Max(.75f, width * scale), true)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => DrawPolyline(points.Select(p => p * scale).ToArray(), tint, Math.Max(.75f, width * scale), true)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`points.Select(p => p * scale)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: points.Select(p => p * scale).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`points.Select(p => p * scale).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: points.Select(p => p * scale).ToArray()`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(.75f, width * scale)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(.75f, width * scale)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-aa56b78dde46"></a>

## `Octagon(float, float) — Vector2[] Octagon(float inset, float cut)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAvatar.DrawMetalFrame(NationalSpire.AvatarFrame)`](AvatarFrameDrawing.cs.md#symbol-85654168c2bc)；[`Ring(float, float, Godot.Color)`](AvatarFrameDrawing.cs.md#symbol-70e0c20a0ac2)

**调用：** [`Point(float, float)`](AvatarFrameDrawing.cs.md#symbol-d02a65dd0a6f)

**字段、属性、事件及方法组引用：** `Point(float, float)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Point(float, float)`；输入表达式：`Point(100 - inset - cut, 100 - inset)`；返回值紧邻使用处：`ExpressionElementSyntax: Point(100 - inset - cut, 100 - inset)`
- `Point(float, float)`；输入表达式：`Point(100 - inset - cut, inset)`；返回值紧邻使用处：`ExpressionElementSyntax: Point(100 - inset - cut, inset)`
- `Point(float, float)`；输入表达式：`Point(100 - inset, 100 - inset - cut)`；返回值紧邻使用处：`ExpressionElementSyntax: Point(100 - inset, 100 - inset - cut)`
- `Point(float, float)`；输入表达式：`Point(100 - inset, inset + cut)`；返回值紧邻使用处：`ExpressionElementSyntax: Point(100 - inset, inset + cut)`
- `Point(float, float)`；输入表达式：`Point(inset + cut, 100 - inset)`；返回值紧邻使用处：`ExpressionElementSyntax: Point(inset + cut, 100 - inset)`
- `Point(float, float)`；输入表达式：`Point(inset + cut, inset)`；返回值紧邻使用处：`ExpressionElementSyntax: Point(inset + cut, inset)`
- `Point(float, float)`；输入表达式：`Point(inset, 100 - inset - cut)`；返回值紧邻使用处：`ExpressionElementSyntax: Point(inset, 100 - inset - cut)`
- `Point(float, float)`；输入表达式：`Point(inset, inset + cut)`；返回值紧邻使用处：`ExpressionElementSyntax: Point(inset, inset + cut)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-70e0c20a0ac2"></a>

## `Ring(float, float, Godot.Color) — void Ring(float inset, float thickness, Color tint)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAvatar.DrawMetalFrame(NationalSpire.AvatarFrame)`](AvatarFrameDrawing.cs.md#symbol-85654168c2bc)

**调用：** [`Octagon(float, float)`](AvatarFrameDrawing.cs.md#symbol-aa56b78dde46)；`Godot.CanvasItem.DrawPolygon(Godot.Vector2[], Godot.Color[], Godot.Vector2[], Godot.Texture2D)`；`Godot.Color.Darkened(float)`；`Godot.Color.Lightened(float)`

**字段、属性、事件及方法组引用：** `Octagon(float, float)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawPolygon(Godot.Vector2[], Godot.Color[], Godot.Vector2[], Godot.Texture2D)`；输入表达式：`DrawPolygon([outer[i], outer[next], inner[next], inner[i]], [face, face, face.Darkened(.25f), face.Darkened(.25f)])`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawPolygon([outer[i], outer[next], inner[next], inner[i]], [face, face, face.Darkened(.25f), face.Darkened(.25f)]);`
- `Godot.Color.Darkened(float)`；输入表达式：`face.Darkened(.25f)`；返回值紧邻使用处：`ExpressionElementSyntax: face.Darkened(.25f)`
- `Godot.Color.Darkened(float)`；输入表达式：`tint.Darkened(.38f)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: _ => tint.Darkened(.38f)`
- `Godot.Color.Lightened(float)`；输入表达式：`tint.Lightened(.15f)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: 1 or 6 => tint.Lightened(.15f)`
- `Godot.Color.Lightened(float)`；输入表达式：`tint.Lightened(.52f)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: 0 or 7 => tint.Lightened(.52f)`
- `Octagon(float, float)`；输入表达式：`Octagon(inset + thickness, 8)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Octagon(inset + thickness, 8)`
- `Octagon(float, float)`；输入表达式：`Octagon(inset, 11)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Octagon(inset, 11)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-02a7b3d8e0ed"></a>

## `P(float, float) — Vector2 P(float x, float y)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAvatar.DrawMetalFrame(NationalSpire.AvatarFrame)`](AvatarFrameDrawing.cs.md#symbol-85654168c2bc)

**调用：** `Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(right ? 100 - x : x, y)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new(right ? 100 - x : x, y)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7b66cc740838"></a>

## `P(float, float) — Vector2 P(float x, float y)`

来源：源码第 93 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerAvatar.DrawMetalFrame(NationalSpire.AvatarFrame)`](AvatarFrameDrawing.cs.md#symbol-85654168c2bc)

**调用：** `Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(right ? 100 - x : x, y)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new(right ? 100 - x : x, y)`

**赋值（含属性/字段和局部值）：**
