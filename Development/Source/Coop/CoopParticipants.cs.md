# Coop/CoopParticipants.cs

[返回文件依赖索引](../../SOURCE_MAP.md)

源码 SHA-256：`82153DEF50020A18A43F2797752268BA0A20FA5AB80413B4139B7D8EC4F44AF2`。来源：[源码](../../../Coop/CoopParticipants.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Coop.CoopRules`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-bc80580d2b20"></a>

## `NationalSpire.Coop.CoopRules.SetParticipants(NationalSpire.Coop.CoopWorld, System.Collections.Generic.IReadOnlySet<ulong>) — public static void SetParticipants(CoopWorld w, IReadOnlySet<ulong> ids)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.Tick()`](CoopCoordinator.cs.md#symbol-4253349561bc)；[`NationalSpire.Coop.CoopRules.Prepare(NationalSpire.Coop.CoopWorld, string, int, System.Collections.Generic.IReadOnlySet<string>, System.Collections.Generic.IReadOnlySet<ulong>?)`](CoopRules.cs.md#symbol-570bf786ec18)；[`NationalSpire.Coop.CoopRules.Settle(NationalSpire.Coop.CoopWorld, string, bool, bool, int, double, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer>, System.Collections.Generic.Dictionary<ulong, NationalSpire.CareerResult>?, bool, bool, bool)`](CoopRules.cs.md#symbol-926ebe8770ca)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](../CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CircuitWorld.EnsureHumanRosters(NationalSpire.CareerData)`](../CircuitWorld.cs.md#symbol-dd22ca4c2081)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlySet<T>.Contains(T)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.Remove(T)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.CooperativeMembers`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.MatchHumanIds`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.ClubPosition`；`NationalSpire.CircuitWorld.EnsureHumanRosters(NationalSpire.CareerData)`；`NationalSpire.Coop.CoopMember.PersonId`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubState.Contracts`；`NationalSpire.OwnedClubState.Reserves`；`NationalSpire.OwnedClubState.Starters`；`NationalSpire.OwnedPlayerContract.PersonId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(d, id) is { } p`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, m.PersonId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(d, m.PersonId) is { } p`
- `NationalSpire.CircuitWorld.EnsureHumanRosters(NationalSpire.CareerData)`；输入表达式：`CircuitWorld.EnsureHumanRosters(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CircuitWorld.EnsureHumanRosters(d);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`owned.Contracts.Any(c => c.PersonId == id)`；返回值紧邻使用处：`BinaryExpressionSyntax: !d.HumanIds.Contains(id) && owned.Contracts.Any(c => c.PersonId == id)`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`owned.Starters.Where(id => !d.HumanIds.Contains(id)).Reverse()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: owned.Starters.Where(id => !d.HumanIds.Contains(id)).Reverse().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`active.Select(m => m.PersonId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: active.Select(m => m.PersonId).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`active.Select(m => m.PersonId).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: d.MatchHumanIds = active.Select(m => m.PersonId).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`owned.Reserves.Where(id => !d.HumanIds.Contains(id) && owned.Contracts.Any(c => c.PersonId == id)).ToList()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string id in owned.Reserves.Where(id => !d.HumanIds.Contains(id) && owned.Contracts.Any(c => c.PersonId == id)).ToList())             {                 if (owned.Starters.Count >= capacity) break;                 owned.Reserves.Remove(id); owned.Starters.Add(id);                 if (CareerEngine.Person(d, id) is { } p) p.ClubPosition = "首发";             }`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`owned.Starters.Where(id => !d.HumanIds.Contains(id)).Reverse().ToList()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string id in owned.Starters.Where(id => !d.HumanIds.Contains(id)).Reverse().ToList())             {                 if (owned.Starters.Count <= capacity) break;                 owned.Starters.Remove(id); if (!owned.Reserves.Contains(id)) owned.Reserves.Add(id);                 if (CareerEngine.Person(d, id) is { } p) p.ClubPosition = "轮换";             }`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`w.Members.Where(m => ids.Contains(m.SteamId)).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = w.Members.Where(m => ids.Contains(m.SteamId)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`owned.Reserves.Where(id => !d.HumanIds.Contains(id) && owned.Contracts.Any(c => c.PersonId == id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: owned.Reserves.Where(id => !d.HumanIds.Contains(id) && owned.Contracts.Any(c => c.PersonId == id)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`owned.Starters.Where(id => !d.HumanIds.Contains(id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: owned.Starters.Where(id => !d.HumanIds.Contains(id)).Reverse`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`w.Members.Where(m => ids.Contains(m.SteamId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: w.Members.Where(m => ids.Contains(m.SteamId)).ToList`
- `System.Collections.Generic.IReadOnlySet<T>.Contains(T)`；输入表达式：`ids.Contains(m.SteamId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ids.Contains(m.SteamId) ? "首发" : "轮换"`
- `System.Collections.Generic.IReadOnlySet<T>.Contains(T)`；输入表达式：`ids.Contains(m.SteamId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ids.Contains(m.SteamId) ? owned.Starters : owned.Reserves`
- `System.Collections.Generic.IReadOnlySet<T>.Contains(T)`；输入表达式：`ids.Contains(m.SteamId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m => ids.Contains(m.SteamId)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`(ids.Contains(m.SteamId) ? owned.Starters : owned.Reserves).Add(m.PersonId)`；返回值紧邻使用处：`ExpressionStatementSyntax: (ids.Contains(m.SteamId) ? owned.Starters : owned.Reserves).Add(m.PersonId);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`owned.Reserves.Add(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: owned.Reserves.Add(id);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`owned.Starters.Add(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: owned.Starters.Add(id);`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`d.HumanIds.Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.HumanIds.Contains(id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`owned.Reserves.Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !owned.Reserves.Contains(id)`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`owned.Reserves.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: owned.Reserves.Remove(id);`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`owned.Reserves.Remove(m.PersonId)`；返回值紧邻使用处：`ExpressionStatementSyntax: owned.Reserves.Remove(m.PersonId);`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`owned.Starters.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: owned.Starters.Remove(id);`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`owned.Starters.Remove(m.PersonId)`；返回值紧邻使用处：`ExpressionStatementSyntax: owned.Starters.Remove(m.PersonId);`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(3, active.Count)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(3, active.Count)`

**赋值（含属性/字段和局部值）：**

- `d.CooperativeMembers` = `active.Count`
- `d.MatchHumanIds` = `active.Select(m => m.PersonId).ToList()`
- `p.ClubPosition` = `"轮换"`
- `p.ClubPosition` = `"首发"`
- `p.ClubPosition` = `ids.Contains(m.SteamId) ? "首发" : "轮换"`
