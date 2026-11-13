# BlitzRivalMarkers.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`43DF1FE9E5D897F081E488B201F01B9E1F22D7BF979DAAC286F2547BEE629613`。来源：[源码](../../BlitzRivalMarkers.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LiveMapRival`、`NationalSpire.BlitzRivalMarkers`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly Type? PointType = typeof(ActMap).Assembly.GetType("MegaCrit.Sts2.Core.Nodes.CommonUi.NBlitzTopBarMapPoint");
private static readonly PropertyInfo? Point = PointType?.GetProperty("Point");
private readonly Dictionary<string, RivalMapOverlay> _overlays = [];
private Dictionary<MapCoord, Control> _points = [];
private Node? _parent;
private ActMap? _map;
private double _artRetryAt;
```

<a id="symbol-9f0927789a81"></a>

## `NationalSpire.BlitzRivalMarkers.Update(NationalSpire.CareerData, Godot.Control, MegaCrit.Sts2.Core.Map.ActMap, int, double, System.Collections.Generic.IReadOnlyList<NationalSpire.LiveMapRival>) — public void Update(CareerData data, Control globalUi, ActMap map, int act, double seconds, IReadOnlyList<LiveMapRival> rivals)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopLive.UpdateMap(NationalSpire.Coop.CoopRun, MegaCrit.Sts2.Core.Runs.IRunState, System.Collections.Generic.IReadOnlyList<NationalSpire.LiveMapRival>)`](Coop/CoopLive.cs.md#symbol-a444164580e0)；[`NationalSpire.LiveRunBridge.UpdateMap(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, double)`](LiveRunBridge.cs.md#symbol-cedfec15a9e5)

**调用：** [`Location(NationalSpire.LiveMapRival)`](BlitzRivalMarkers.cs.md#symbol-e0496cf712b4)；[`NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`](AvatarAssets.cs.md#symbol-1d4beb6f533e)；[`NationalSpire.BlitzRivalMarkers.Dispose()`](BlitzRivalMarkers.cs.md#symbol-5d22b60b0de2)；[`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-cd3d95caefab)；[`NationalSpire.RivalMapOverlay.RefreshArt(NationalSpire.AvatarArt)`](LiveRaceHud.cs.md#symbol-6200daa39f4a)；[`NationalSpire.RivalMapOverlay.UpdateState(System.Collections.Generic.List<Godot.Vector2>, Godot.Vector2?, string, int, int, bool, string, string)`](LiveRaceHud.cs.md#symbol-7b27533a2169)；[`Position(Godot.Control)`](BlitzRivalMarkers.cs.md#symbol-6a21e2a1cd98)；`Godot.CanvasItem.Show()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.FindChild(string, bool, bool)`；`Godot.Node.GetChildren(bool)`；`Godot.Vector2.Vector2(float, float)`；`MegaCrit.Sts2.Core.Map.MapCoord.MapCoord(int, int)`；`NationalSpire.RivalMapOverlay.RivalMapOverlay()`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.IEnumerable.OfType<TResult>()`；`System.Math.Sign(int)`；`System.Reflection.PropertyInfo.GetValue(object?)`；`System.Type.IsInstanceOfType(object?)`

**字段、属性、事件及方法组引用：** `(MegaCrit.Sts2.Core.Map.MapCoord, int Side).Side`；`(T1, T2).Item1`；`Detail(NationalSpire.LiveMapRival)`；`Location(NationalSpire.LiveMapRival)`；`NationalSpire.AvatarArt.Texture`；`NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`；`NationalSpire.BlitzRivalMarkers._artRetryAt`；`NationalSpire.BlitzRivalMarkers._map`；`NationalSpire.BlitzRivalMarkers._overlays`；`NationalSpire.BlitzRivalMarkers._parent`；`NationalSpire.BlitzRivalMarkers._points`；`NationalSpire.BlitzRivalMarkers.Dispose()`；`NationalSpire.BlitzRivalMarkers.Point`；`NationalSpire.BlitzRivalMarkers.PointType`；`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.LiveMapRival.Id`；`NationalSpire.LiveMapRival.MaxHp`；`NationalSpire.LiveMapRival.Name`；`NationalSpire.LiveMapRival.Progress`；`NationalSpire.LiveMapRival.Steps`；`NationalSpire.RivalMapOverlay.Art`；`NationalSpire.RivalMapOverlay.BadgeOffset`；`NationalSpire.RivalMapOverlay.Compact`；`NationalSpire.RivalMapOverlay.RefreshArt(NationalSpire.AvatarArt)`；`NationalSpire.RivalMapOverlay.UpdateState(System.Collections.Generic.List<Godot.Vector2>, Godot.Vector2?, string, int, int, bool, string, string)`；`NationalSpire.RivalProgress.Dead`；`NationalSpire.RivalProgress.Hp`；`NationalSpire.RivalProgress.Step`；`NationalSpire.RivalStep.Act`；`NationalSpire.RivalStep.Col`；`NationalSpire.RivalStep.Row`；`NationalSpire.RivalStep.Start`；`Position(Godot.Control)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Show()`；输入表达式：`overlay.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: overlay.Show();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(_parent)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GodotObject.IsInstanceValid(_parent)`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(overlay)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GodotObject.IsInstanceValid(overlay)`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(p)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GodotObject.IsInstanceValid(p)`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`p.IsQueuedForDeletion()`；返回值紧邻使用处：`BinaryExpressionSyntax: !GodotObject.IsInstanceValid(p) || p.IsQueuedForDeletion()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`_parent!.AddChild(overlay)`；返回值紧邻使用处：`ExpressionStatementSyntax: _parent!.AddChild(overlay);`
- `Godot.Node.FindChild(string, bool, bool)`；输入表达式：`globalUi.FindChild("BlitzMapPoints", true, false)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _parent = globalUi.FindChild("BlitzMapPoints", true, false)`
- `Godot.Node.GetChildren(bool)`；输入表达式：`_parent.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _parent.GetChildren().OfType<Control>`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(group.Key.Side * 28, 0)`；返回值紧邻使用处：`BinaryExpressionSyntax: Position(point) + new Vector2(group.Key.Side * 28, 0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(-13 + (i - (members.Length - 1) / 2f) * 8, -42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: overlay.BadgeOffset = new(-13 + (i - (members.Length - 1) / 2f) * 8, -42)`
- `Location(NationalSpire.LiveMapRival)`；输入表达式：`Location(r)`；返回值紧邻使用处：`ArgumentSyntax: Location(r)`
- `MegaCrit.Sts2.Core.Map.MapCoord.MapCoord(int, int)`；输入表达式：`new(s.Col, s.Row)`；返回值紧邻使用处：`ArgumentSyntax: new(s.Col, s.Row)`
- `NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`；输入表达式：`AvatarAssets.Usable(overlay.Art.Texture)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !AvatarAssets.Usable(overlay.Art.Texture)`
- `NationalSpire.BlitzRivalMarkers.Dispose()`；输入表达式：`Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: Dispose();`
- `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.ForPerson(data, rival.Id)`；返回值紧邻使用处：`ArgumentSyntax: CareerAvatars.ForPerson(data, rival.Id)`
- `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.ForPerson(data, rival.Id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Art = CareerAvatars.ForPerson(data, rival.Id)`
- `NationalSpire.RivalMapOverlay.RefreshArt(NationalSpire.AvatarArt)`；输入表达式：`overlay.RefreshArt(CareerAvatars.ForPerson(data, rival.Id))`；返回值紧邻使用处：`ExpressionStatementSyntax: overlay.RefreshArt(CareerAvatars.ForPerson(data, rival.Id));`
- `NationalSpire.RivalMapOverlay.RivalMapOverlay()`；输入表达式：`new RivalMapOverlay { Compact = true, Art = CareerAvatars.ForPerson(data, rival.Id) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: overlay = new RivalMapOverlay { Compact = true, Art = CareerAvatars.ForPerson(data, rival.Id) }`
- `NationalSpire.RivalMapOverlay.UpdateState(System.Collections.Generic.List<Godot.Vector2>, Godot.Vector2?, string, int, int, bool, string, string)`；输入表达式：`overlay.UpdateState(path, marker, rival.Name, rival.Progress.Hp, rival.MaxHp, rival.Progress.Dead,                     tooltip, group.Key.Side == 0 ? "" : $"{rival.Progress.Step.Act + 1}幕")`；返回值紧邻使用处：`ExpressionStatementSyntax: overlay.UpdateState(path, marker, rival.Name, rival.Progress.Hp, rival.MaxHp, rival.Progress.Dead,                     tooltip, group.Key.Side == 0 ? "" : $"{rival.Progress.Step.Act + 1}幕");`
- `Position(Godot.Control)`；输入表达式：`Position(_points[new(s.Col, s.Row)])`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: s => Position(_points[new(s.Col, s.Row)])`
- `Position(Godot.Control)`；输入表达式：`Position(point)`；返回值紧邻使用处：`BinaryExpressionSyntax: Position(point) + new Vector2(group.Key.Side * 28, 0)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n\n", members.Select(Detail))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = string.Join("\n\n", members.Select(Detail))`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`_points.ContainsKey(new(s.Col, s.Row))`；返回值紧邻使用处：`BinaryExpressionSyntax: s.Act == act && s.Start <= seconds && _points.ContainsKey(new(s.Col, s.Row))`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_overlays.TryGetValue(rival.Id, out var overlay)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_overlays.TryGetValue(rival.Id, out var overlay)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_points.TryGetValue(group.Key.Item1, out var point)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_points.TryGetValue(group.Key.Item1, out var point)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`_points.Values.Any(p => !GodotObject.IsInstanceValid(p) || p.IsQueuedForDeletion())`；返回值紧邻使用处：`BinaryExpressionSyntax: _map != map || !GodotObject.IsInstanceValid(_parent)             || _points.Values.Any(p => !GodotObject.IsInstanceValid(p) || p.IsQueuedForDeletion())`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`rivals.GroupBy(r => (Location(r), Side: Math.Sign(r.Progress.Step.Act - act)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = rivals.GroupBy(r => (Location(r), Side: Math.Sign(r.Progress.Step.Act - act)))`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`_points.OrderBy(p => p.Key.row)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _points.OrderBy(p => p.Key.row).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`members.Select(Detail)`；返回值紧邻使用处：`ArgumentSyntax: members.Select(Detail)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`rival.Steps.Where(s => s.Act == act && s.Start <= seconds && _points.ContainsKey(new(s.Col, s.Row)))                     .Select(s => Position(_points[new(s.Col, s.Row)]))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: rival.Steps.Where(s => s.Act == act && s.Start <= seconds && _points.ContainsKey(new(s.Col, s.Row)))                     .Select(s => Position(_points[new(s.Col, s.Row)])).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_points.OrderBy(p => p.Key.row).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _points.OrderBy(p => p.Key.row).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`group.ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = group.ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`_parent.GetChildren().OfType<Control>().Where(c => PointType?.IsInstanceOfType(c) == true)                 .ToDictionary(c => ((MapPoint)Point!.GetValue(c)!).coord)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _points = _parent.GetChildren().OfType<Control>().Where(c => PointType?.IsInstanceOfType(c) == true)                 .ToDictionary(c => ((MapPoint)Point!.GetValue(c)!).coord)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`rival.Steps.Where(s => s.Act == act && s.Start <= seconds && _points.ContainsKey(new(s.Col, s.Row)))                     .Select(s => Position(_points[new(s.Col, s.Row)])).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = rival.Steps.Where(s => s.Act == act && s.Start <= seconds && _points.ContainsKey(new(s.Col, s.Row)))                     .Select(s => Position(_points[new(s.Col, s.Row)])).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_parent.GetChildren().OfType<Control>().Where(c => PointType?.IsInstanceOfType(c) == true)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _parent.GetChildren().OfType<Control>().Where(c => PointType?.IsInstanceOfType(c) == true)                 .ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`rival.Steps.Where(s => s.Act == act && s.Start <= seconds && _points.ContainsKey(new(s.Col, s.Row)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: rival.Steps.Where(s => s.Act == act && s.Start <= seconds && _points.ContainsKey(new(s.Col, s.Row)))                     .Select`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`_parent.GetChildren().OfType<Control>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _parent.GetChildren().OfType<Control>().Where`
- `System.Math.Sign(int)`；输入表达式：`Math.Sign(r.Progress.Step.Act - act)`；返回值紧邻使用处：`ArgumentSyntax: Side: Math.Sign(r.Progress.Step.Act - act)`
- `System.Reflection.PropertyInfo.GetValue(object?)`；输入表达式：`Point!.GetValue(c)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Point!.GetValue(c)!`
- `System.Type.IsInstanceOfType(object?)`；输入表达式：`.IsInstanceOfType(c)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: PointType?.IsInstanceOfType(c)`

**赋值（含属性/字段和局部值）：**

- `_artRetryAt` = `seconds + 3`
- `_map` = `map`
- `_map` = `null`
- `_overlays[rival.Id]` = `overlay`
- `_parent` = `globalUi.FindChild("BlitzMapPoints", true, false)`
- `_points` = `_parent.GetChildren().OfType<Control>().Where(c => PointType?.IsInstanceOfType(c) == true)                 .ToDictionary(c => ((MapPoint)Point!.GetValue(c)!).coord)`
- `Art` = `CareerAvatars.ForPerson(data, rival.Id)`
- `Compact` = `true`
- `overlay.BadgeOffset` = `new(-13 + (i - (members.Length - 1) / 2f) * 8, -42)`
- `overlay` = `new RivalMapOverlay { Compact = true, Art = CareerAvatars.ForPerson(data, rival.Id) }`

<a id="symbol-e0496cf712b4"></a>

## `Location(NationalSpire.LiveMapRival) — MapCoord Location(LiveMapRival rival)`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.BlitzRivalMarkers.Update(NationalSpire.CareerData, Godot.Control, MegaCrit.Sts2.Core.Map.ActMap, int, double, System.Collections.Generic.IReadOnlyList<NationalSpire.LiveMapRival>)`](BlitzRivalMarkers.cs.md#symbol-9f0927789a81)

**调用：** `MegaCrit.Sts2.Core.Map.MapCoord.MapCoord(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.LiveMapRival.Progress`；`NationalSpire.RivalProgress.Step`；`NationalSpire.RivalStep.Act`；`NationalSpire.RivalStep.Col`；`NationalSpire.RivalStep.Row`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Map.MapCoord.MapCoord(int, int)`；输入表达式：`new(rival.Progress.Step.Col, rival.Progress.Step.Row)`；返回值紧邻使用处：`ConditionalExpressionSyntax: rival.Progress.Step.Act == act             ? new(rival.Progress.Step.Col, rival.Progress.Step.Row)             : rival.Progress.Step.Act < act ? ordered[0].Key : ordered[^1].Key`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ead317e94a86"></a>

## `Detail(NationalSpire.LiveMapRival) — string Detail(LiveMapRival rival)`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.RivalSimulation.RoomName(string)`](LiveMatch.cs.md#symbol-2c599e9f210a)

**字段、属性、事件及方法组引用：** `NationalSpire.LiveMapRival.MaxHp`；`NationalSpire.LiveMapRival.Name`；`NationalSpire.LiveMapRival.Progress`；`NationalSpire.RivalProgress.Dead`；`NationalSpire.RivalProgress.Finished`；`NationalSpire.RivalProgress.Hp`；`NationalSpire.RivalProgress.Step`；`NationalSpire.RivalSimulation.RoomName(string)`；`NationalSpire.RivalStep.Act`；`NationalSpire.RivalStep.Floor`；`NationalSpire.RivalStep.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RivalSimulation.RoomName(string)`；输入表达式：`RivalSimulation.RoomName(rival.Progress.Step.Kind)`；返回值紧邻使用处：`ConditionalExpressionSyntax: rival.Progress.Finished ? rival.Progress.Dead ? "已出局" : "已通关" : RivalSimulation.RoomName(rival.Progress.Step.Kind)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6a21e2a1cd98"></a>

## `Position(Godot.Control) — Vector2 Position(Control node)`

来源：源码第 58 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.BlitzRivalMarkers.Update(NationalSpire.CareerData, Godot.Control, MegaCrit.Sts2.Core.Map.ActMap, int, double, System.Collections.Generic.IReadOnlyList<NationalSpire.LiveMapRival>)`](BlitzRivalMarkers.cs.md#symbol-9f0927789a81)

**调用：** `Godot.CanvasItem.GetGlobalTransformWithCanvas()`；`Godot.Transform2D.AffineInverse()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.GetGlobalTransformWithCanvas()`；输入表达式：`node.GetGlobalTransformWithCanvas()`；返回值紧邻使用处：`BinaryExpressionSyntax: node.GetGlobalTransformWithCanvas() * (node.Size * .5f)`
- `Godot.CanvasItem.GetGlobalTransformWithCanvas()`；输入表达式：`overlay.GetGlobalTransformWithCanvas()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: overlay.GetGlobalTransformWithCanvas().AffineInverse`
- `Godot.Transform2D.AffineInverse()`；输入表达式：`overlay.GetGlobalTransformWithCanvas().AffineInverse()`；返回值紧邻使用处：`BinaryExpressionSyntax: overlay.GetGlobalTransformWithCanvas().AffineInverse()                     * (node.GetGlobalTransformWithCanvas() * (node.Size * .5f))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a0b3dcfd2e88"></a>

## `NationalSpire.BlitzRivalMarkers.Hide() — public void Hide()`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge._Process(double)`](LiveRunBridge.cs.md#symbol-d7e63bc009ff)；[`NationalSpire.LiveRunBridge.RefreshRace(ref bool)`](LiveRunBridge.cs.md#symbol-f03ac37c2ac4)

**调用：** `Godot.CanvasItem.Hide()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.BlitzRivalMarkers._overlays`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`overlay.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: overlay.Hide();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_overlays.Values.Where(GodotObject.IsInstanceValid)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var overlay in _overlays.Values.Where(GodotObject.IsInstanceValid)) overlay.Hide();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5d22b60b0de2"></a>

## `NationalSpire.BlitzRivalMarkers.Dispose() — public void Dispose()`

来源：源码第 69 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.BlitzRivalMarkers.Update(NationalSpire.CareerData, Godot.Control, MegaCrit.Sts2.Core.Map.ActMap, int, double, System.Collections.Generic.IReadOnlyList<NationalSpire.LiveMapRival>)`](BlitzRivalMarkers.cs.md#symbol-9f0927789a81)；[`NationalSpire.Coop.CoopLive.Close()`](Coop/CoopLive.cs.md#symbol-85319a2fb491)；[`NationalSpire.LiveRunBridge._ExitTree()`](LiveRunBridge.cs.md#symbol-1d45315292ab)

**调用：** `Godot.Node.QueueFree()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.BlitzRivalMarkers._map`；`NationalSpire.BlitzRivalMarkers._overlays`；`NationalSpire.BlitzRivalMarkers._parent`；`NationalSpire.BlitzRivalMarkers._points`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.QueueFree()`；输入表达式：`overlay.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: overlay.QueueFree();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_overlays.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _overlays.Clear();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_points.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _points.Clear();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_overlays.Values.Where(GodotObject.IsInstanceValid)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var overlay in _overlays.Values.Where(GodotObject.IsInstanceValid)) overlay.QueueFree();`

**赋值（含属性/字段和局部值）：**

- `_map` = `null`
- `_parent` = `null`
