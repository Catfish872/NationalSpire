# LiveMaps.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`F78F70849E466880C5A3EDB1BCCDBB31BA7CE80C38737753FB36229E224FB924`。来源：[源码](../../LiveMaps.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LiveMaps`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-c878186b1e5a"></a>

## `NationalSpire.LiveMaps.Read(MegaCrit.Sts2.Core.Runs.IRunState, NationalSpire.CareerMatch, bool) — public static List<RouteNode> Read(IRunState run, CareerMatch match, bool cooperative)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopLive.Update()`](Coop/CoopLive.cs.md#symbol-fe745d15ee63)；[`NationalSpire.LiveRunBridge.EnsurePlan(ref bool)`](LiveRunBridge.cs.md#symbol-0dd1ac28e6cd)；[`NationalSpire.LiveRunBridge.PlanningMap()`](LiveRunBridge.cs.md#symbol-733c41e89044)

**调用：** [`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.GameCompatibility.MapRng(object, int)`](GameCompatibility.cs.md#symbol-a2187753991c)；[`NationalSpire.LiveMaps.Copy(MegaCrit.Sts2.Core.Map.ActMap, int, bool)`](LiveMaps.cs.md#symbol-4f5b35fc24c7)；[`NationalSpire.RivalSimulation.IndependentMap(int, int, bool, string)`](LiveMatch.cs.md#symbol-3b51df8cd703)；`MegaCrit.Sts2.Core.Map.StandardActMap.StandardActMap(MegaCrit.Sts2.Core.Random.Rng, MegaCrit.Sts2.Core.Models.ActModel, bool, bool, bool, MegaCrit.Sts2.Core.Map.MapPointTypeCounts?, bool)`；`MegaCrit.Sts2.Core.Models.ActModel.GetNumberOfRooms(bool)`；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.List<T>.List()`

**字段、属性、事件及方法组引用：** `<anonymous type: string match, int act, bool cooperative, string model>.match`；`<anonymous type: string match, int act, bool cooperative, string model>.model`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.RequiredAscension`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.GameCompatibility.MapRng(object, int)`；`NationalSpire.LiveMaps.Copy(MegaCrit.Sts2.Core.Map.ActMap, int, bool)`；`NationalSpire.RivalSimulation.IndependentMap(int, int, bool, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Map.StandardActMap.StandardActMap(MegaCrit.Sts2.Core.Random.Rng, MegaCrit.Sts2.Core.Models.ActModel, bool, bool, bool, MegaCrit.Sts2.Core.Map.MapPointTypeCounts?, bool)`；输入表达式：`new StandardActMap(GameCompatibility.MapRng(run.Rng, act + 1), run.Acts[act], cooperative, false, second)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StandardActMap(GameCompatibility.MapRng(run.Rng, act + 1), run.Acts[act], cooperative, false, second)`
- `MegaCrit.Sts2.Core.Models.ActModel.GetNumberOfRooms(bool)`；输入表达式：`run.Acts[act].GetNumberOfRooms(cooperative)`；返回值紧邻使用处：`ArgumentSyntax: run.Acts[act].GetNumberOfRooms(cooperative)`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`run.Acts[act].Id.ToString()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: model = run.Acts[act].Id.ToString()`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("live.map_prediction", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("live.map_prediction", e);`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("live.independent_route", new { match = match.Id, act, cooperative, model = run.Acts[act].Id.ToString() })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("live.independent_route", new { match = match.Id, act, cooperative, model = run.Acts[act].Id.ToString() });`
- `NationalSpire.GameCompatibility.MapRng(object, int)`；输入表达式：`GameCompatibility.MapRng(run.Rng, act + 1)`；返回值紧邻使用处：`ArgumentSyntax: GameCompatibility.MapRng(run.Rng, act + 1)`
- `NationalSpire.LiveMaps.Copy(MegaCrit.Sts2.Core.Map.ActMap, int, bool)`；输入表达式：`Copy(map, act, second)`；返回值紧邻使用处：`ArgumentSyntax: Copy(map, act, second)`
- `NationalSpire.LiveMaps.Copy(MegaCrit.Sts2.Core.Map.ActMap, int, bool)`；输入表达式：`Copy(run.Map, act, second)`；返回值紧邻使用处：`ArgumentSyntax: Copy(run.Map, act, second)`
- `NationalSpire.RivalSimulation.IndependentMap(int, int, bool, string)`；输入表达式：`RivalSimulation.IndependentMap(act, run.Acts[act].GetNumberOfRooms(cooperative), second, match.Seed)`；返回值紧邻使用处：`ArgumentSyntax: RivalSimulation.IndependentMap(act, run.Acts[act].GetNumberOfRooms(cooperative), second, match.Seed)`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`nodes.AddRange(Copy(map, act, second))`；返回值紧邻使用处：`ExpressionStatementSyntax: nodes.AddRange(Copy(map, act, second));`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`nodes.AddRange(Copy(run.Map, act, second))`；返回值紧邻使用处：`ExpressionStatementSyntax: nodes.AddRange(Copy(run.Map, act, second));`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`nodes.AddRange(RivalSimulation.IndependentMap(act, run.Acts[act].GetNumberOfRooms(cooperative), second, match.Seed))`；返回值紧邻使用处：`ExpressionStatementSyntax: nodes.AddRange(RivalSimulation.IndependentMap(act, run.Acts[act].GetNumberOfRooms(cooperative), second, match.Seed));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<RouteNode>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<RouteNode>()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4f5b35fc24c7"></a>

## `NationalSpire.LiveMaps.Copy(MegaCrit.Sts2.Core.Map.ActMap, int, bool) — public static List<RouteNode> Copy(ActMap map, int act, bool secondBoss)`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveMaps.Read(MegaCrit.Sts2.Core.Runs.IRunState, NationalSpire.CareerMatch, bool)`](LiveMaps.cs.md#symbol-c878186b1e5a)；[`NationalSpire.LiveRunBridge.CopyMap(MegaCrit.Sts2.Core.Map.ActMap, int, bool)`](LiveRunBridge.cs.md#symbol-03b8653f5c4b)

**调用：** `MegaCrit.Sts2.Core.Map.ActMap.GetAllMapPoints()`；`NationalSpire.RouteNode.RouteNode(int, int, int, string, System.Collections.Generic.List<(int Row, int Col)>)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Enum.ToString()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Map.ActMap.GetAllMapPoints()`；输入表达式：`map.GetAllMapPoints()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: map.GetAllMapPoints().Append`
- `NationalSpire.RouteNode.RouteNode(int, int, int, string, System.Collections.Generic.List<(int Row, int Col)>)`；输入表达式：`new RouteNode(act, p.coord.row, p.coord.col, p.PointType.ToString(),             p.Children.Where(c => secondBoss || c != map.SecondBossMapPoint).Select(c => (c.coord.row, c.coord.col)).ToList())`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => new RouteNode(act, p.coord.row, p.coord.col, p.PointType.ToString(),             p.Children.Where(c => secondBoss || c != map.SecondBossMapPoint).Select(c => (c.coord.row, c.coord.col)).ToList())`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`all.Append(map.SecondBossMapPoint)`；返回值紧邻使用处：`AssignmentExpressionSyntax: all = all.Append(map.SecondBossMapPoint)`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`map.GetAllMapPoints().Append(map.StartingMapPoint).Append(map.BossMapPoint)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = map.GetAllMapPoints().Append(map.StartingMapPoint).Append(map.BossMapPoint)`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`map.GetAllMapPoints().Append(map.StartingMapPoint)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: map.GetAllMapPoints().Append(map.StartingMapPoint).Append`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`all.DistinctBy(p => p.coord)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: all.DistinctBy(p => p.coord).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`all.DistinctBy(p => p.coord).Select(p => new RouteNode(act, p.coord.row, p.coord.col, p.PointType.ToString(),             p.Children.Where(c => secondBoss || c != map.SecondBossMapPoint).Select(c => (c.coord.row, c.coord.col)).ToList()))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: all.DistinctBy(p => p.coord).Select(p => new RouteNode(act, p.coord.row, p.coord.col, p.PointType.ToString(),             p.Children.Where(c => secondBoss || c != map.SecondBossMapPoint).Select(c => (c.coord.row, c.coord.col)).ToList())).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`p.Children.Where(c => secondBoss || c != map.SecondBossMapPoint).Select(c => (c.coord.row, c.coord.col))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.Children.Where(c => secondBoss || c != map.SecondBossMapPoint).Select(c => (c.coord.row, c.coord.col)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`all.DistinctBy(p => p.coord).Select(p => new RouteNode(act, p.coord.row, p.coord.col, p.PointType.ToString(),             p.Children.Where(c => secondBoss || c != map.SecondBossMapPoint).Select(c => (c.coord.row, c.coord.col)).ToList())).ToList()`；返回值紧邻使用处：`ReturnStatementSyntax: return all.DistinctBy(p => p.coord).Select(p => new RouteNode(act, p.coord.row, p.coord.col, p.PointType.ToString(),             p.Children.Where(c => secondBoss || c != map.SecondBossMapPoint).Select(c => (c.coord.row, c.coord.col)).ToList())).ToList();`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`p.Children.Where(c => secondBoss || c != map.SecondBossMapPoint).Select(c => (c.coord.row, c.coord.col)).ToList()`；返回值紧邻使用处：`ArgumentSyntax: p.Children.Where(c => secondBoss || c != map.SecondBossMapPoint).Select(c => (c.coord.row, c.coord.col)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`p.Children.Where(c => secondBoss || c != map.SecondBossMapPoint)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.Children.Where(c => secondBoss || c != map.SecondBossMapPoint).Select`
- `System.Enum.ToString()`；输入表达式：`p.PointType.ToString()`；返回值紧邻使用处：`ArgumentSyntax: p.PointType.ToString()`

**赋值（含属性/字段和局部值）：**

- `all` = `all.Append(map.SecondBossMapPoint)`

<a id="symbol-b7456baf6c82"></a>

## `NationalSpire.LiveMaps.Matches(MegaCrit.Sts2.Core.Map.ActMap, System.Collections.Generic.IEnumerable<NationalSpire.RivalStep>, int) — public static bool Matches(ActMap map, IEnumerable<RivalStep> steps, int act)`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopLive.Update()`](Coop/CoopLive.cs.md#symbol-fe745d15ee63)；[`NationalSpire.Coop.CoopLive.UpdateMap(NationalSpire.Coop.CoopRun, MegaCrit.Sts2.Core.Map.ActMap, int)`](Coop/CoopLive.cs.md#symbol-3ddf0280ec69)；[`NationalSpire.LiveRunBridge.CalibrateMap(NationalSpire.LiveMatchState)`](LiveRunBridge.cs.md#symbol-7252231ccb09)

**调用：** `MegaCrit.Sts2.Core.Map.ActMap.GetPoint(MegaCrit.Sts2.Core.Map.MapCoord)`；`MegaCrit.Sts2.Core.Map.MapCoord.MapCoord(int, int)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Enum.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.RivalStep.Act`；`NationalSpire.RivalStep.Col`；`NationalSpire.RivalStep.IndependentRoute`；`NationalSpire.RivalStep.Kind`；`NationalSpire.RivalStep.Row`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Map.ActMap.GetPoint(MegaCrit.Sts2.Core.Map.MapCoord)`；输入表达式：`map.GetPoint(new(route[i - 1].Col, route[i - 1].Row))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = map.GetPoint(new(route[i - 1].Col, route[i - 1].Row))`
- `MegaCrit.Sts2.Core.Map.ActMap.GetPoint(MegaCrit.Sts2.Core.Map.MapCoord)`；输入表达式：`map.GetPoint(new(step.Col, step.Row))`；返回值紧邻使用处：`IsPatternExpressionSyntax: map.GetPoint(new(step.Col, step.Row)) is not { } point`
- `MegaCrit.Sts2.Core.Map.MapCoord.MapCoord(int, int)`；输入表达式：`new(route[i - 1].Col, route[i - 1].Row)`；返回值紧邻使用处：`ArgumentSyntax: new(route[i - 1].Col, route[i - 1].Row)`
- `MegaCrit.Sts2.Core.Map.MapCoord.MapCoord(int, int)`；输入表达式：`new(step.Col, step.Row)`；返回值紧邻使用处：`ArgumentSyntax: new(step.Col, step.Row)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`previous.Children.Any(c => c.coord == point.coord)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !previous.Children.Any(c => c.coord == point.coord)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`steps.Where(s => s.Act == act).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = steps.Where(s => s.Act == act).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`steps.Where(s => s.Act == act)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: steps.Where(s => s.Act == act).ToList`
- `System.Enum.ToString()`；输入表达式：`point.PointType.ToString()`；返回值紧邻使用处：`BinaryExpressionSyntax: point.PointType.ToString() != step.Kind`

**赋值（含属性/字段和局部值）：**
