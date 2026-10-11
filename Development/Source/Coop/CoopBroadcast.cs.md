# Coop/CoopBroadcast.cs

[返回文件依赖索引](../../SOURCE_MAP.md)

源码 SHA-256：`18925C23ADD526F7E3B50505F969E26870BDAAD4D3AD376134D5C542BDCC57F8`。来源：[源码](../../../Coop/CoopBroadcast.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Coop.CoopBroadcast`。

字段、事件及初始值（源码原样）：

```csharp
private readonly CoopCoordinator _session;
private readonly Dictionary<ulong, BattleObservation> _battles = [];
private int _historyCount, _speakerTurn;
private LiveVoices? _voices;
private LiveShopObserver? _shop;
```

<a id="symbol-2885ebc77d3b"></a>

## `NationalSpire.Coop.CoopBroadcast.CoopBroadcast(NationalSpire.Coop.CoopCoordinator) — public CoopBroadcast(CoopCoordinator session)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopLive.Update()`](CoopLive.cs.md#symbol-fe745d15ee63)

**调用：** [`NationalSpire.Coop.CoopBroadcast.Initialize(bool)`](CoopBroadcast.cs.md#symbol-0f7a729aba61)；[`NationalSpire.LiveShopObserver.LiveShopObserver(MegaCrit.Sts2.Core.Runs.RunState)`](../LiveShopObserver.cs.md#symbol-9c0734afb2ba)；`MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopBroadcast._historyCount`；`NationalSpire.Coop.CoopBroadcast._session`；`NationalSpire.Coop.CoopBroadcast._shop`；`NationalSpire.Coop.CoopBroadcast.Changed()`；`NationalSpire.Coop.CoopBroadcast.Initialize(bool)`；`NationalSpire.Coop.CoopBroadcast.Started(MegaCrit.Sts2.Core.Combat.ICombatState)`；`NationalSpire.Coop.CoopBroadcast.Won(MegaCrit.Sts2.Core.Rooms.CombatRoom)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；输入表达式：`RunManager.Instance.DebugOnlyGetState()`；返回值紧邻使用处：`IsPatternExpressionSyntax: RunManager.Instance.DebugOnlyGetState() is { } run`
- `NationalSpire.Coop.CoopBroadcast.Initialize(bool)`；输入表达式：`Initialize(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: Initialize(false);`
- `NationalSpire.LiveShopObserver.LiveShopObserver(MegaCrit.Sts2.Core.Runs.RunState)`；输入表达式：`new(run)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _shop = new(run)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`CombatManager.Instance.History.Entries.Count()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _historyCount = CombatManager.Instance.History.Entries.Count()`

**赋值（含属性/字段和局部值）：**

- `_historyCount` = `CombatManager.Instance.History.Entries.Count()`
- `_session` = `session`
- `_shop` = `new(run)`
- `CombatManager.Instance.CombatSetUp` += `Started`
- `CombatManager.Instance.CombatWon` += `Won`
- `CombatManager.Instance.History.Changed` += `Changed`

<a id="symbol-e0d0b0c2ad9c"></a>

## `NationalSpire.Coop.CoopBroadcast.Active — private bool Active`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopBroadcast._session`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRun.Seed`；`NationalSpire.Coop.CoopRun.Terminal`；`NationalSpire.Coop.CoopWorld.Run`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；输入表达式：`RunManager.Instance.DebugOnlyGetState()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: RunManager.Instance.DebugOnlyGetState()?.Rng.StringSeed`

**赋值（含属性/字段和局部值）：**


<a id="symbol-845730f8a94c"></a>

## `NationalSpire.Coop.CoopBroadcast.Guard(System.Action) — private void Guard(Action action)`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopBroadcast.Changed()`](CoopBroadcast.cs.md#symbol-9cb809e0579a)；[`NationalSpire.Coop.CoopBroadcast.Started(MegaCrit.Sts2.Core.Combat.ICombatState)`](CoopBroadcast.cs.md#symbol-b61679ac8942)；[`NationalSpire.Coop.CoopBroadcast.Tick()`](CoopBroadcast.cs.md#symbol-3be13ce2aa51)；[`NationalSpire.Coop.CoopBroadcast.Won(MegaCrit.Sts2.Core.Rooms.CombatRoom)`](CoopBroadcast.cs.md#symbol-bf9e47770d28)

**调用：** [`NationalSpire.Coop.CoopBroadcast.RestoreClock()`](CoopBroadcast.cs.md#symbol-9e0e10e71ef1)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](../Diagnostics.cs.md#symbol-cb39203375a5)；`System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopBroadcast.Active`；`NationalSpire.Coop.CoopBroadcast.RestoreClock()`；`NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopBroadcast.RestoreClock()`；输入表达式：`RestoreClock()`；返回值紧邻使用处：`ExpressionStatementSyntax: RestoreClock();`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("coop.commentary", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("coop.commentary", e);`
- `System.Action.Invoke()`；输入表达式：`action()`；返回值紧邻使用处：`ExpressionStatementSyntax: action();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b61679ac8942"></a>

## `NationalSpire.Coop.CoopBroadcast.Started(MegaCrit.Sts2.Core.Combat.ICombatState) — private void Started(ICombatState state)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopBroadcast.Guard(System.Action)`](CoopBroadcast.cs.md#symbol-845730f8a94c)；[`NationalSpire.Coop.CoopBroadcast.Initialize(bool)`](CoopBroadcast.cs.md#symbol-0f7a729aba61)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopBroadcast.Guard(System.Action)`；`NationalSpire.Coop.CoopBroadcast.Initialize(bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopBroadcast.Guard(System.Action)`；输入表达式：`Guard(() => Initialize(true))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Guard(() => Initialize(true))`
- `NationalSpire.Coop.CoopBroadcast.Initialize(bool)`；输入表达式：`Initialize(true)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => Initialize(true)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0f7a729aba61"></a>

## `NationalSpire.Coop.CoopBroadcast.Initialize(bool) — private void Initialize(bool complete)`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopBroadcast.Changed()`](CoopBroadcast.cs.md#symbol-9cb809e0579a)；[`NationalSpire.Coop.CoopBroadcast.CoopBroadcast(NationalSpire.Coop.CoopCoordinator)`](CoopBroadcast.cs.md#symbol-2885ebc77d3b)；[`NationalSpire.Coop.CoopBroadcast.Started(MegaCrit.Sts2.Core.Combat.ICombatState)`](CoopBroadcast.cs.md#symbol-b61679ac8942)

**调用：** `MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；`NationalSpire.BattleObservation.BattleObservation()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Enum.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.BattleObservation.CompleteObservation`；`NationalSpire.BattleObservation.Floor`；`NationalSpire.BattleObservation.Hp`；`NationalSpire.BattleObservation.Kind`；`NationalSpire.BattleObservation.MaxHp`；`NationalSpire.Coop.CoopBroadcast._battles`；`NationalSpire.Coop.CoopBroadcast._historyCount`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；输入表达式：`RunManager.Instance.DebugOnlyGetState()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RunManager.Instance.DebugOnlyGetState()`
- `NationalSpire.BattleObservation.BattleObservation()`；输入表达式：`new() { Floor = state.TotalFloor, Kind = state.CurrentRoom?.RoomType.ToString() ?? "Monster", Hp = p.Creature.CurrentHp, MaxHp = p.Creature.MaxHp, CompleteObservation = complete }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _battles[p.NetId] = new() { Floor = state.TotalFloor, Kind = state.CurrentRoom?.RoomType.ToString() ?? "Monster", Hp = p.Creature.CurrentHp, MaxHp = p.Creature.MaxHp, CompleteObservation = complete }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_battles.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _battles.Clear();`
- `System.Enum.ToString()`；输入表达式：`.RoomType.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: state.CurrentRoom?.RoomType.ToString()`

**赋值（含属性/字段和局部值）：**

- `_battles[p.NetId]` = `new() { Floor = state.TotalFloor, Kind = state.CurrentRoom?.RoomType.ToString() ?? "Monster", Hp = p.Creature.CurrentHp, MaxHp = p.Creature.MaxHp, CompleteObservation = complete }`
- `_historyCount` = `0`
- `CompleteObservation` = `complete`
- `Floor` = `state.TotalFloor`
- `Hp` = `p.Creature.CurrentHp`
- `Kind` = `state.CurrentRoom?.RoomType.ToString() ?? "Monster"`
- `MaxHp` = `p.Creature.MaxHp`

<a id="symbol-ffccdc0feb66"></a>

## `NationalSpire.Coop.CoopBroadcast.Memory(ulong) — private BroadcastMemory Memory(ulong id)`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopBroadcast.CanSpeak`](CoopBroadcast.cs.md#symbol-6f8e1294aaa6)；[`NationalSpire.Coop.CoopBroadcast.Changed()`](CoopBroadcast.cs.md#symbol-9cb809e0579a)；[`NationalSpire.Coop.CoopBroadcast.Tick()`](CoopBroadcast.cs.md#symbol-3be13ce2aa51)；[`NationalSpire.Coop.CoopBroadcast.Won(MegaCrit.Sts2.Core.Rooms.CombatRoom)`](CoopBroadcast.cs.md#symbol-bf9e47770d28)

**调用：** `NationalSpire.BroadcastMemory.BroadcastMemory()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastMemory.SharedPhrases`；`NationalSpire.CareerData.BroadcastHistory`；`NationalSpire.Coop.CoopBroadcast._session`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRun.Broadcasts`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.CoopWorld.World`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.BroadcastMemory.BroadcastMemory()`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: memory = new()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`live.Broadcasts.TryGetValue(id, out var memory)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !live.Broadcasts.TryGetValue(id, out var memory)`

**赋值（含属性/字段和局部值）：**

- `live.Broadcasts[id]` = `memory = new()`
- `memory.SharedPhrases` = `_session.World.World.BroadcastHistory`
- `memory` = `new()`

<a id="symbol-9e0e10e71ef1"></a>

## `NationalSpire.Coop.CoopBroadcast.RestoreClock() — private void RestoreClock()`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopBroadcast.Guard(System.Action)`](CoopBroadcast.cs.md#symbol-845730f8a94c)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Math.Min(double, double)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastMemory.LastSpoke`；`NationalSpire.BroadcastMemory.NextAtmosphereAt`；`NationalSpire.BroadcastMemory.TopicTimes`；`NationalSpire.Coop.CoopBroadcast._session`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRun.Broadcasts`；`NationalSpire.Coop.CoopRun.Rival`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.LiveMatchState.Commentary`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`live.Broadcasts.Values.Concat(live.Rival == null ? [] : new[] { live.Rival.Commentary })`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var memory in live.Broadcasts.Values.Concat(live.Rival == null ? [] : new[] { live.Rival.Commentary }))          {              if (memory.LastSpoke <= now) continue;              double shift = memory.LastSpoke - now + 6;              memory.LastSpoke -= shift;              foreach (string topic in memory.TopicTimes.Keys.ToArray()) memory.TopicTimes[topic] -= shift;              memory.NextAtmosphereAt = Math.Min(memory.NextAtmosphereAt, now + 10);          }`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`memory.TopicTimes.Keys.ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string topic in memory.TopicTimes.Keys.ToArray()) memory.TopicTimes[topic] -= shift;`
- `System.Math.Min(double, double)`；输入表达式：`Math.Min(memory.NextAtmosphereAt, now + 10)`；返回值紧邻使用处：`AssignmentExpressionSyntax: memory.NextAtmosphereAt = Math.Min(memory.NextAtmosphereAt, now + 10)`

**赋值（含属性/字段和局部值）：**

- `memory.LastSpoke` -= `shift`
- `memory.NextAtmosphereAt` = `Math.Min(memory.NextAtmosphereAt, now + 10)`
- `memory.TopicTimes[topic]` -= `shift`

<a id="symbol-6f8e1294aaa6"></a>

## `NationalSpire.Coop.CoopBroadcast.CanSpeak — private bool CanSpeak`

来源：源码第 56 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopBroadcast.Memory(ulong)`](CoopBroadcast.cs.md#symbol-ffccdc0feb66)

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastMemory.LastSpoke`；`NationalSpire.Coop.CoopBroadcast.Memory(ulong)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopBroadcast.Memory(ulong)`；输入表达式：`Memory(0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Memory(0).LastSpoke`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3be13ce2aa51"></a>

## `NationalSpire.Coop.CoopBroadcast.Tick() — public void Tick()`

来源：源码第 57 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopLive.Update()`](CoopLive.cs.md#symbol-fe745d15ee63)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](../CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.Coop.CoopBroadcast.Broadcast(NationalSpire.Coop.CoopCoordinator, NationalSpire.BroadcastLine?)`](CoopBroadcast.cs.md#symbol-647e8c7161ba)；[`NationalSpire.Coop.CoopBroadcast.Guard(System.Action)`](CoopBroadcast.cs.md#symbol-845730f8a94c)；[`NationalSpire.Coop.CoopBroadcast.Memory(ulong)`](CoopBroadcast.cs.md#symbol-ffccdc0feb66)；[`NationalSpire.Coop.CoopBroadcast.Name(ulong)`](CoopBroadcast.cs.md#symbol-eccbe21df9a0)；[`NationalSpire.LiveCommentary.Atmosphere(NationalSpire.BroadcastMemory, NationalSpire.AtmosphereContext, string, double)`](../LiveAtmosphere.cs.md#symbol-0b25ed42c5ca)；[`NationalSpire.LiveCommentary.Gap(NationalSpire.BroadcastMemory, int, int, int, int, string, string, int, int, double, string)`](../LiveCommentary.cs.md#symbol-dd61728b3570)；[`NationalSpire.LiveCommentary.RebaseGap(NationalSpire.BroadcastMemory, int, int, double)`](../LiveCommentary.cs.md#symbol-7a552211c71b)；[`NationalSpire.LiveCommentary.Rival(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, string, string, string, double)`](../LiveAtmosphere.cs.md#symbol-5475ccc1b529)；[`NationalSpire.LiveCommentary.Route(NationalSpire.BroadcastMemory, NationalSpire.BattleObservation, string, string, double)`](../LiveCommentary.cs.md#symbol-ee9616c0239b)；[`NationalSpire.LiveShopObserver.LiveShopObserver(MegaCrit.Sts2.Core.Runs.RunState)`](../LiveShopObserver.cs.md#symbol-9c0734afb2ba)；[`NationalSpire.LiveShopObserver.Read(MegaCrit.Sts2.Core.Runs.RunState, bool)`](../LiveShopObserver.cs.md#symbol-76febe44c2f1)；[`NationalSpire.LiveVoices.Ambient(bool, int, double)`](../LiveCrowd.cs.md#symbol-789980beddf3)；[`NationalSpire.LiveVoices.LiveVoices(NationalSpire.CareerData, NationalSpire.CareerMatch, NationalSpire.BroadcastMemory, System.Collections.Generic.IEnumerable<string>)`](../LiveVoices.cs.md#symbol-3ffa230aebe8)；[`NationalSpire.LiveVoices.Poll(double, double)`](../LiveVoices.cs.md#symbol-fc95fe2519bc)；[`NationalSpire.LiveVoices.Rival(int, int, int, int, NationalSpire.RivalProgress, NationalSpire.LiveMatchState, double, System.Collections.Generic.IEnumerable<(string Id, NationalSpire.RivalProgress Progress, int MaxHp)>?)`](../LiveVoices.cs.md#symbol-ea0ff7a1e0eb)；[`NationalSpire.LiveVoices.Shop(string, string, int, int, string, int, double, string)`](../LiveVoices.cs.md#symbol-44512aead226)；[`NationalSpire.RivalSimulation.At(NationalSpire.LiveMatchState, double)`](../LiveMatch.cs.md#symbol-78308976d2a9)；`MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；`NationalSpire.AtmosphereContext.AtmosphereContext(string, string, string, string, int, int, int, string, int, int, int, int, bool)`；`NationalSpire.BattleObservation.BattleObservation()`；`string.Replace(string, string?)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Enum.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.BattleObservation.Floor`；`NationalSpire.BattleObservation.Hp`；`NationalSpire.BattleObservation.Kind`；`NationalSpire.BattleObservation.MaxHp`；`NationalSpire.BattleObservation.Turn`；`NationalSpire.BroadcastLine.Text`；`NationalSpire.BroadcastLine.Topic`；`NationalSpire.BroadcastMemory.LastSpoke`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerMatch.Event`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerPerson.Character`；`NationalSpire.Coop.CoopBroadcast._battles`；`NationalSpire.Coop.CoopBroadcast._session`；`NationalSpire.Coop.CoopBroadcast._shop`；`NationalSpire.Coop.CoopBroadcast._speakerTurn`；`NationalSpire.Coop.CoopBroadcast._voices`；`NationalSpire.Coop.CoopBroadcast.Broadcast(NationalSpire.Coop.CoopCoordinator, NationalSpire.BroadcastLine?)`；`NationalSpire.Coop.CoopBroadcast.CanSpeak`；`NationalSpire.Coop.CoopBroadcast.Guard(System.Action)`；`NationalSpire.Coop.CoopBroadcast.Memory(ulong)`；`NationalSpire.Coop.CoopBroadcast.Name(ulong)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRun.Ascension`；`NationalSpire.Coop.CoopRun.MatchId`；`NationalSpire.Coop.CoopRun.Opponents`；`NationalSpire.Coop.CoopRun.Rival`；`NationalSpire.Coop.CoopRun.RivalMembers`；`NationalSpire.Coop.CoopRun.Seed`；`NationalSpire.Coop.CoopWorld.Name`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.LiveCommentary.Atmosphere(NationalSpire.BroadcastMemory, NationalSpire.AtmosphereContext, string, double)`；`NationalSpire.LiveCommentary.Gap(NationalSpire.BroadcastMemory, int, int, int, int, string, string, int, int, double, string)`；`NationalSpire.LiveCommentary.RebaseGap(NationalSpire.BroadcastMemory, int, int, double)`；`NationalSpire.LiveCommentary.Rival(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, string, string, string, double)`；`NationalSpire.LiveCommentary.Route(NationalSpire.BroadcastMemory, NationalSpire.BattleObservation, string, string, double)`；`NationalSpire.LiveMatchState.MaxHp`；`NationalSpire.LiveMatchState.PaceNeutralUntil`；`NationalSpire.LiveMatchState.Steps`；`NationalSpire.LiveShopChange.CardType`；`NationalSpire.LiveShopChange.DeckSize`；`NationalSpire.LiveShopChange.Gold`；`NationalSpire.LiveShopChange.Item`；`NationalSpire.LiveShopChange.Kind`；`NationalSpire.LiveShopChange.Player`；`NationalSpire.LiveShopObserver.Read(MegaCrit.Sts2.Core.Runs.RunState, bool)`；`NationalSpire.LiveVoices.Ambient(bool, int, double)`；`NationalSpire.LiveVoices.Poll(double, double)`；`NationalSpire.LiveVoices.Rival(int, int, int, int, NationalSpire.RivalProgress, NationalSpire.LiveMatchState, double, System.Collections.Generic.IEnumerable<(string Id, NationalSpire.RivalProgress Progress, int MaxHp)>?)`；`NationalSpire.LiveVoices.Shop(string, string, int, int, string, int, double, string)`；`NationalSpire.RivalProgress.Finished`；`NationalSpire.RivalProgress.Step`；`NationalSpire.RivalSimulation.At(NationalSpire.LiveMatchState, double)`；`NationalSpire.RivalStep.Act`；`NationalSpire.RivalStep.Floor`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；输入表达式：`RunManager.Instance.DebugOnlyGetState()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: RunManager.Instance.DebugOnlyGetState()!`
- `NationalSpire.AtmosphereContext.AtmosphereContext(string, string, string, string, int, int, int, string, int, int, int, int, bool)`；输入表达式：`new AtmosphereContext(Name(p.NetId), "对手队伍", match.Event,                  CareerEngine.Person(_session.World.World, live.Opponents[(_speakerTurn + i) % live.Opponents.Count])?.Character ?? "未知角色", live.Ascension, state.TotalFloor, state.CurrentActIndex,                  state.CurrentRoom?.RoomType.ToString() ?? "", p.Creature.CurrentHp, p.Creature.MaxHp, p.Gold,                  battle?.Turn ?? 0, CombatManager.Instance.IsInProgress)`；返回值紧邻使用处：`ArgumentSyntax: new AtmosphereContext(Name(p.NetId), "对手队伍", match.Event,                  CareerEngine.Person(_session.World.World, live.Opponents[(_speakerTurn + i) % live.Opponents.Count])?.Character ?? "未知角色", live.Ascension, state.TotalFloor, state.CurrentActIndex,                  state.CurrentRoom?.RoomType.ToString() ?? "", p.Creature.CurrentHp, p.Creature.MaxHp, p.Gold,                  battle?.Turn ?? 0, CombatManager.Instance.IsInProgress)`
- `NationalSpire.BattleObservation.BattleObservation()`；输入表达式：`new BattleObservation { Floor = state.TotalFloor, Kind = state.CurrentMapPoint?.PointType.ToString() ?? "",                  Hp = p.Creature.CurrentHp, MaxHp = p.Creature.MaxHp }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BattleObservation { Floor = state.TotalFloor, Kind = state.CurrentMapPoint?.PointType.ToString() ?? "",                  Hp = p.Creature.CurrentHp, MaxHp = p.Creature.MaxHp }`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(_session.World.World, live.Opponents[(_speakerTurn + i) % live.Opponents.Count])`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CareerEngine.Person(_session.World.World, live.Opponents[(_speakerTurn + i) % live.Opponents.Count])?.Character`
- `NationalSpire.Coop.CoopBroadcast.Broadcast(NationalSpire.Coop.CoopCoordinator, NationalSpire.BroadcastLine?)`；输入表达式：`Broadcast(_session, _voices.Poll(now, Memory(0).LastSpoke))`；返回值紧邻使用处：`ExpressionStatementSyntax: Broadcast(_session, _voices.Poll(now, Memory(0).LastSpoke));`
- `NationalSpire.Coop.CoopBroadcast.Broadcast(NationalSpire.Coop.CoopCoordinator, NationalSpire.BroadcastLine?)`；输入表达式：`Broadcast(_session, line)`；返回值紧邻使用处：`ExpressionStatementSyntax: Broadcast(_session, line);`
- `NationalSpire.Coop.CoopBroadcast.Broadcast(NationalSpire.Coop.CoopCoordinator, NationalSpire.BroadcastLine?)`；输入表达式：`Broadcast(_session, LiveCommentary.Gap(shared, state.TotalFloor, progress.Step.Floor, state.CurrentActIndex, progress.Step.Act,                      _session.World.Name, "对手队伍", state.Players.Sum(p => p.Creature.CurrentHp), state.Players.Sum(p => p.Creature.MaxHp), now, live.Seed))`；返回值紧邻使用处：`ExpressionStatementSyntax: Broadcast(_session, LiveCommentary.Gap(shared, state.TotalFloor, progress.Step.Floor, state.CurrentActIndex, progress.Step.Act,                      _session.World.Name, "对手队伍", state.Players.Sum(p => p.Creature.CurrentHp), state.Players.Sum(p => p.Creature.MaxHp), now, live.Seed));`
- `NationalSpire.Coop.CoopBroadcast.Broadcast(NationalSpire.Coop.CoopCoordinator, NationalSpire.BroadcastLine?)`；输入表达式：`Broadcast(_session, LiveCommentary.Rival(rival, progress, _session.World.Name, "对手队伍", live.Seed, now))`；返回值紧邻使用处：`ExpressionStatementSyntax: Broadcast(_session, LiveCommentary.Rival(rival, progress, _session.World.Name, "对手队伍", live.Seed, now));`
- `NationalSpire.Coop.CoopBroadcast.Guard(System.Action)`；输入表达式：`Guard(() =>      {          var state = RunManager.Instance.DebugOnlyGetState()!;          var live = _session.World!.Run!; var match = _session.World.World.Matches.Single(m => m.Id == live.MatchId);          double now = RunManager.Instance.RunTime; var shared = Memory(ulong.MaxValue);          if (live.Rival is { Steps.Count: > 0 } rival)          {              var progress = RivalSimulation.At(rival, now);              if (CanSpeak || progress.Finished) Broadcast(_session, LiveCommentary.Rival(rival, progress, _session.World.Name, "对手队伍", live.Seed, now));              if (now <= rival.PaceNeutralUntil) LiveCommentary.RebaseGap(shared, state.TotalFloor, progress.Step.Floor, now);              else if (CanSpeak && !progress.Finished)                  Broadcast(_session, LiveCommentary.Gap(shared, state.TotalFloor, progress.Step.Floor, state.CurrentActIndex, progress.Step.Act,                      _session.World.Name, "对手队伍", state.Players.Sum(p => p.Creature.CurrentHp), state.Players.Sum(p => p.Creature.MaxHp), now, live.Seed));          }          _voices ??= new(_session.World.World, match, shared, live.Opponents);          _shop ??= new(state);          foreach (var change in _shop.Read(state))              _voices.Shop(change.Kind, change.Item, change.DeckSize, change.Gold, Name(change.Player), state.TotalFloor, now, change.CardType);          if (live.Rival is { Steps.Count: > 0 } route)              _voices.Rival(state.TotalFloor, state.CurrentActIndex, state.Players.Sum(p => p.Creature.CurrentHp), state.Players.Sum(p => p.Creature.MaxHp),                  RivalSimulation.At(route, now), route, now,                  live.RivalMembers.Select(pair => (pair.Key, RivalSimulation.At(pair.Value, now), pair.Value.MaxHp)));          _voices.Ambient(CombatManager.Instance.IsInProgress && !CombatManager.Instance.IsEnding, state.TotalFloor, now);          Broadcast(_session, _voices.Poll(now, Memory(0).LastSpoke));          if (!CanSpeak) return;          var players = state.Players.Where(p => p.Creature.CurrentHp > 0).ToArray();          for (int i = 0; i < players.Length; i++)          {              var p = players[(_speakerTurn + i) % players.Length]; var memory = Memory(p.NetId);              var battle = _battles.GetValueOrDefault(p.NetId);              var observation = new BattleObservation { Floor = state.TotalFloor, Kind = state.CurrentMapPoint?.PointType.ToString() ?? "",                  Hp = p.Creature.CurrentHp, MaxHp = p.Creature.MaxHp };              var line = LiveCommentary.Route(memory, observation, Name(p.NetId), live.Seed + p.NetId, now);              line ??= LiveCommentary.Atmosphere(memory, new AtmosphereContext(Name(p.NetId), "对手队伍", match.Event,                  CareerEngine.Person(_session.World.World, live.Opponents[(_speakerTurn + i) % live.Opponents.Count])?.Character ?? "未知角色", live.Ascension, state.TotalFloor, state.CurrentActIndex,                  state.CurrentRoom?.RoomType.ToString() ?? "", p.Creature.CurrentHp, p.Creature.MaxHp, p.Gold,                  battle?.Turn ?? 0, CombatManager.Instance.IsInProgress), live.Seed + p.NetId, now);              if (line == null) continue;              if (line.Topic == "opening") line = line with { Text = line.Text.Replace("两位", "两支队伍") };              Broadcast(_session, line); _speakerTurn = (_speakerTurn + i + 1) % players.Length; break;          }      })`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Guard(() =>      {          var state = RunManager.Instance.DebugOnlyGetState()!;          var live = _session.World!.Run!; var match = _session.World.World.Matches.Single(m => m.Id == live.MatchId);          double now = RunManager.Instance.RunTime; var shared = Memory(ulong.MaxValue);          if (live.Rival is { Steps.Count: > 0 } rival)          {              var progress = RivalSimulation.At(rival, now);              if (CanSpeak || progress.Finished) Broadcast(_session, LiveCommentary.Rival(rival, progress, _session.World.Name, "对手队伍", live.Seed, now));              if (now <= rival.PaceNeutralUntil) LiveCommentary.RebaseGap(shared, state.TotalFloor, progress.Step.Floor, now);              else if (CanSpeak && !progress.Finished)                  Broadcast(_session, LiveCommentary.Gap(shared, state.TotalFloor, progress.Step.Floor, state.CurrentActIndex, progress.Step.Act,                      _session.World.Name, "对手队伍", state.Players.Sum(p => p.Creature.CurrentHp), state.Players.Sum(p => p.Creature.MaxHp), now, live.Seed));          }          _voices ??= new(_session.World.World, match, shared, live.Opponents);          _shop ??= new(state);          foreach (var change in _shop.Read(state))              _voices.Shop(change.Kind, change.Item, change.DeckSize, change.Gold, Name(change.Player), state.TotalFloor, now, change.CardType);          if (live.Rival is { Steps.Count: > 0 } route)              _voices.Rival(state.TotalFloor, state.CurrentActIndex, state.Players.Sum(p => p.Creature.CurrentHp), state.Players.Sum(p => p.Creature.MaxHp),                  RivalSimulation.At(route, now), route, now,                  live.RivalMembers.Select(pair => (pair.Key, RivalSimulation.At(pair.Value, now), pair.Value.MaxHp)));          _voices.Ambient(CombatManager.Instance.IsInProgress && !CombatManager.Instance.IsEnding, state.TotalFloor, now);          Broadcast(_session, _voices.Poll(now, Memory(0).LastSpoke));          if (!CanSpeak) return;          var players = state.Players.Where(p => p.Creature.CurrentHp > 0).ToArray();          for (int i = 0; i < players.Length; i++)          {              var p = players[(_speakerTurn + i) % players.Length]; var memory = Memory(p.NetId);              var battle = _battles.GetValueOrDefault(p.NetId);              var observation = new BattleObservation { Floor = state.TotalFloor, Kind = state.CurrentMapPoint?.PointType.ToString() ?? "",                  Hp = p.Creature.CurrentHp, MaxHp = p.Creature.MaxHp };              var line = LiveCommentary.Route(memory, observation, Name(p.NetId), live.Seed + p.NetId, now);              line ??= LiveCommentary.Atmosphere(memory, new AtmosphereContext(Name(p.NetId), "对手队伍", match.Event,                  CareerEngine.Person(_session.World.World, live.Opponents[(_speakerTurn + i) % live.Opponents.Count])?.Character ?? "未知角色", live.Ascension, state.TotalFloor, state.CurrentActIndex,                  state.CurrentRoom?.RoomType.ToString() ?? "", p.Creature.CurrentHp, p.Creature.MaxHp, p.Gold,                  battle?.Turn ?? 0, CombatManager.Instance.IsInProgress), live.Seed + p.NetId, now);              if (line == null) continue;              if (line.Topic == "opening") line = line with { Text = line.Text.Replace("两位", "两支队伍") };              Broadcast(_session, line); _speakerTurn = (_speakerTurn + i + 1) % players.Length; break;          }      })`
- `NationalSpire.Coop.CoopBroadcast.Memory(ulong)`；输入表达式：`Memory(0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Memory(0).LastSpoke`
- `NationalSpire.Coop.CoopBroadcast.Memory(ulong)`；输入表达式：`Memory(p.NetId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Memory(p.NetId)`
- `NationalSpire.Coop.CoopBroadcast.Memory(ulong)`；输入表达式：`Memory(ulong.MaxValue)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Memory(ulong.MaxValue)`
- `NationalSpire.Coop.CoopBroadcast.Name(ulong)`；输入表达式：`Name(change.Player)`；返回值紧邻使用处：`ArgumentSyntax: Name(change.Player)`
- `NationalSpire.Coop.CoopBroadcast.Name(ulong)`；输入表达式：`Name(p.NetId)`；返回值紧邻使用处：`ArgumentSyntax: Name(p.NetId)`
- `NationalSpire.LiveCommentary.Atmosphere(NationalSpire.BroadcastMemory, NationalSpire.AtmosphereContext, string, double)`；输入表达式：`LiveCommentary.Atmosphere(memory, new AtmosphereContext(Name(p.NetId), "对手队伍", match.Event,                  CareerEngine.Person(_session.World.World, live.Opponents[(_speakerTurn + i) % live.Opponents.Count])?.Character ?? "未知角色", live.Ascension, state.TotalFloor, state.CurrentActIndex,                  state.CurrentRoom?.RoomType.ToString() ?? "", p.Creature.CurrentHp, p.Creature.MaxHp, p.Gold,                  battle?.Turn ?? 0, CombatManager.Instance.IsInProgress), live.Seed + p.NetId, now)`；返回值紧邻使用处：`AssignmentExpressionSyntax: line ??= LiveCommentary.Atmosphere(memory, new AtmosphereContext(Name(p.NetId), "对手队伍", match.Event,                  CareerEngine.Person(_session.World.World, live.Opponents[(_speakerTurn + i) % live.Opponents.Count])?.Character ?? "未知角色", live.Ascension, state.TotalFloor, state.CurrentActIndex,                  state.CurrentRoom?.RoomType.ToString() ?? "", p.Creature.CurrentHp, p.Creature.MaxHp, p.Gold,                  battle?.Turn ?? 0, CombatManager.Instance.IsInProgress), live.Seed + p.NetId, now)`
- `NationalSpire.LiveCommentary.Gap(NationalSpire.BroadcastMemory, int, int, int, int, string, string, int, int, double, string)`；输入表达式：`LiveCommentary.Gap(shared, state.TotalFloor, progress.Step.Floor, state.CurrentActIndex, progress.Step.Act,                      _session.World.Name, "对手队伍", state.Players.Sum(p => p.Creature.CurrentHp), state.Players.Sum(p => p.Creature.MaxHp), now, live.Seed)`；返回值紧邻使用处：`ArgumentSyntax: LiveCommentary.Gap(shared, state.TotalFloor, progress.Step.Floor, state.CurrentActIndex, progress.Step.Act,                      _session.World.Name, "对手队伍", state.Players.Sum(p => p.Creature.CurrentHp), state.Players.Sum(p => p.Creature.MaxHp), now, live.Seed)`
- `NationalSpire.LiveCommentary.RebaseGap(NationalSpire.BroadcastMemory, int, int, double)`；输入表达式：`LiveCommentary.RebaseGap(shared, state.TotalFloor, progress.Step.Floor, now)`；返回值紧邻使用处：`ExpressionStatementSyntax: LiveCommentary.RebaseGap(shared, state.TotalFloor, progress.Step.Floor, now);`
- `NationalSpire.LiveCommentary.Rival(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, string, string, string, double)`；输入表达式：`LiveCommentary.Rival(rival, progress, _session.World.Name, "对手队伍", live.Seed, now)`；返回值紧邻使用处：`ArgumentSyntax: LiveCommentary.Rival(rival, progress, _session.World.Name, "对手队伍", live.Seed, now)`
- `NationalSpire.LiveCommentary.Route(NationalSpire.BroadcastMemory, NationalSpire.BattleObservation, string, string, double)`；输入表达式：`LiveCommentary.Route(memory, observation, Name(p.NetId), live.Seed + p.NetId, now)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = LiveCommentary.Route(memory, observation, Name(p.NetId), live.Seed + p.NetId, now)`
- `NationalSpire.LiveShopObserver.LiveShopObserver(MegaCrit.Sts2.Core.Runs.RunState)`；输入表达式：`new(state)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _shop ??= new(state)`
- `NationalSpire.LiveShopObserver.Read(MegaCrit.Sts2.Core.Runs.RunState, bool)`；输入表达式：`_shop.Read(state)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var change in _shop.Read(state))              _voices.Shop(change.Kind, change.Item, change.DeckSize, change.Gold, Name(change.Player), state.TotalFloor, now, change.CardType);`
- `NationalSpire.LiveVoices.Ambient(bool, int, double)`；输入表达式：`_voices.Ambient(CombatManager.Instance.IsInProgress && !CombatManager.Instance.IsEnding, state.TotalFloor, now)`；返回值紧邻使用处：`ExpressionStatementSyntax: _voices.Ambient(CombatManager.Instance.IsInProgress && !CombatManager.Instance.IsEnding, state.TotalFloor, now);`
- `NationalSpire.LiveVoices.LiveVoices(NationalSpire.CareerData, NationalSpire.CareerMatch, NationalSpire.BroadcastMemory, System.Collections.Generic.IEnumerable<string>)`；输入表达式：`new(_session.World.World, match, shared, live.Opponents)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _voices ??= new(_session.World.World, match, shared, live.Opponents)`
- `NationalSpire.LiveVoices.Poll(double, double)`；输入表达式：`_voices.Poll(now, Memory(0).LastSpoke)`；返回值紧邻使用处：`ArgumentSyntax: _voices.Poll(now, Memory(0).LastSpoke)`
- `NationalSpire.LiveVoices.Rival(int, int, int, int, NationalSpire.RivalProgress, NationalSpire.LiveMatchState, double, System.Collections.Generic.IEnumerable<(string Id, NationalSpire.RivalProgress Progress, int MaxHp)>?)`；输入表达式：`_voices.Rival(state.TotalFloor, state.CurrentActIndex, state.Players.Sum(p => p.Creature.CurrentHp), state.Players.Sum(p => p.Creature.MaxHp),                  RivalSimulation.At(route, now), route, now,                  live.RivalMembers.Select(pair => (pair.Key, RivalSimulation.At(pair.Value, now), pair.Value.MaxHp)))`；返回值紧邻使用处：`ExpressionStatementSyntax: _voices.Rival(state.TotalFloor, state.CurrentActIndex, state.Players.Sum(p => p.Creature.CurrentHp), state.Players.Sum(p => p.Creature.MaxHp),                  RivalSimulation.At(route, now), route, now,                  live.RivalMembers.Select(pair => (pair.Key, RivalSimulation.At(pair.Value, now), pair.Value.MaxHp)));`
- `NationalSpire.LiveVoices.Shop(string, string, int, int, string, int, double, string)`；输入表达式：`_voices.Shop(change.Kind, change.Item, change.DeckSize, change.Gold, Name(change.Player), state.TotalFloor, now, change.CardType)`；返回值紧邻使用处：`ExpressionStatementSyntax: _voices.Shop(change.Kind, change.Item, change.DeckSize, change.Gold, Name(change.Player), state.TotalFloor, now, change.CardType);`
- `NationalSpire.RivalSimulation.At(NationalSpire.LiveMatchState, double)`；输入表达式：`RivalSimulation.At(pair.Value, now)`；返回值紧邻使用处：`ArgumentSyntax: RivalSimulation.At(pair.Value, now)`
- `NationalSpire.RivalSimulation.At(NationalSpire.LiveMatchState, double)`；输入表达式：`RivalSimulation.At(rival, now)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RivalSimulation.At(rival, now)`
- `NationalSpire.RivalSimulation.At(NationalSpire.LiveMatchState, double)`；输入表达式：`RivalSimulation.At(route, now)`；返回值紧邻使用处：`ArgumentSyntax: RivalSimulation.At(route, now)`
- `string.Replace(string, string?)`；输入表达式：`line.Text.Replace("两位", "两支队伍")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Text = line.Text.Replace("两位", "两支队伍")`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`live.RivalMembers.Select(pair => (pair.Key, RivalSimulation.At(pair.Value, now), pair.Value.MaxHp))`；返回值紧邻使用处：`ArgumentSyntax: live.RivalMembers.Select(pair => (pair.Key, RivalSimulation.At(pair.Value, now), pair.Value.MaxHp))`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`_session.World.World.Matches.Single(m => m.Id == live.MatchId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _session.World.World.Matches.Single(m => m.Id == live.MatchId)`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`state.Players.Sum(p => p.Creature.CurrentHp)`；返回值紧邻使用处：`ArgumentSyntax: state.Players.Sum(p => p.Creature.CurrentHp)`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`state.Players.Sum(p => p.Creature.MaxHp)`；返回值紧邻使用处：`ArgumentSyntax: state.Players.Sum(p => p.Creature.MaxHp)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`state.Players.Where(p => p.Creature.CurrentHp > 0).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = state.Players.Where(p => p.Creature.CurrentHp > 0).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`state.Players.Where(p => p.Creature.CurrentHp > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: state.Players.Where(p => p.Creature.CurrentHp > 0).ToArray`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`_battles.GetValueOrDefault(p.NetId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _battles.GetValueOrDefault(p.NetId)`
- `System.Enum.ToString()`；输入表达式：`.PointType.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: state.CurrentMapPoint?.PointType.ToString()`
- `System.Enum.ToString()`；输入表达式：`.RoomType.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: state.CurrentRoom?.RoomType.ToString()`

**赋值（含属性/字段和局部值）：**

- `_shop` ??= `new(state)`
- `_speakerTurn` = `(_speakerTurn + i + 1) % players.Length`
- `_voices` ??= `new(_session.World.World, match, shared, live.Opponents)`
- `Floor` = `state.TotalFloor`
- `Hp` = `p.Creature.CurrentHp`
- `Kind` = `state.CurrentMapPoint?.PointType.ToString() ?? ""`
- `line` ??= `LiveCommentary.Atmosphere(memory, new AtmosphereContext(Name(p.NetId), "对手队伍", match.Event,                  CareerEngine.Person(_session.World.World, live.Opponents[(_speakerTurn + i) % live.Opponents.Count])?.Character ?? "未知角色", live.Ascension, state.TotalFloor, state.CurrentActIndex,                  state.CurrentRoom?.RoomType.ToString() ?? "", p.Creature.CurrentHp, p.Creature.MaxHp, p.Gold,                  battle?.Turn ?? 0, CombatManager.Instance.IsInProgress), live.Seed + p.NetId, now)`
- `line` = `line with { Text = line.Text.Replace("两位", "两支队伍") }`
- `MaxHp` = `p.Creature.MaxHp`
- `Text` = `line.Text.Replace("两位", "两支队伍")`

<a id="symbol-9cb809e0579a"></a>

## `NationalSpire.Coop.CoopBroadcast.Changed() — private void Changed()`

来源：源码第 99 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopBroadcast.Broadcast(NationalSpire.Coop.CoopCoordinator, NationalSpire.BroadcastLine?)`](CoopBroadcast.cs.md#symbol-647e8c7161ba)；[`NationalSpire.Coop.CoopBroadcast.Guard(System.Action)`](CoopBroadcast.cs.md#symbol-845730f8a94c)；[`NationalSpire.Coop.CoopBroadcast.Initialize(bool)`](CoopBroadcast.cs.md#symbol-0f7a729aba61)；[`NationalSpire.Coop.CoopBroadcast.Memory(ulong)`](CoopBroadcast.cs.md#symbol-ffccdc0feb66)；[`NationalSpire.Coop.CoopBroadcast.Name(ulong)`](CoopBroadcast.cs.md#symbol-eccbe21df9a0)；[`NationalSpire.GameText.Plain(string)`](../GameText.cs.md#symbol-e2c48dec4564)；[`NationalSpire.LiveCommentary.ObserveTurn(NationalSpire.BroadcastMemory, NationalSpire.BattleObservation, string, string, double)`](../LiveCommentary.cs.md#symbol-8cbc1ed10ae3)；[`NationalSpire.LiveVoiceObservation.Observe(NationalSpire.LiveVoices?, NationalSpire.BattleObservation, MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Combat.History.CombatHistoryEntry, string, double)`](../LiveVoiceObservation.cs.md#symbol-efed0893a47e)；`MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.BattleObservation.Cards`；`NationalSpire.BattleObservation.Damage`；`NationalSpire.BattleObservation.Draws`；`NationalSpire.BattleObservation.Hp`；`NationalSpire.BattleObservation.HpLost`；`NationalSpire.BattleObservation.LastCard`；`NationalSpire.BattleObservation.MaxHp`；`NationalSpire.BattleObservation.PeakCards`；`NationalSpire.BattleObservation.PeakDamage`；`NationalSpire.BattleObservation.PeakDraws`；`NationalSpire.BattleObservation.Turn`；`NationalSpire.Coop.CoopBroadcast._battles`；`NationalSpire.Coop.CoopBroadcast._historyCount`；`NationalSpire.Coop.CoopBroadcast._session`；`NationalSpire.Coop.CoopBroadcast._voices`；`NationalSpire.Coop.CoopBroadcast.Broadcast(NationalSpire.Coop.CoopCoordinator, NationalSpire.BroadcastLine?)`；`NationalSpire.Coop.CoopBroadcast.CanSpeak`；`NationalSpire.Coop.CoopBroadcast.Guard(System.Action)`；`NationalSpire.Coop.CoopBroadcast.Initialize(bool)`；`NationalSpire.Coop.CoopBroadcast.Memory(ulong)`；`NationalSpire.Coop.CoopBroadcast.Name(ulong)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRun.Seed`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.GameText.Plain(string)`；`NationalSpire.LiveCommentary.ObserveTurn(NationalSpire.BroadcastMemory, NationalSpire.BattleObservation, string, string, double)`；`NationalSpire.LiveVoiceObservation.Observe(NationalSpire.LiveVoices?, NationalSpire.BattleObservation, MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Combat.History.CombatHistoryEntry, string, double)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；输入表达式：`RunManager.Instance.DebugOnlyGetState()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: RunManager.Instance.DebugOnlyGetState()!`
- `NationalSpire.Coop.CoopBroadcast.Broadcast(NationalSpire.Coop.CoopCoordinator, NationalSpire.BroadcastLine?)`；输入表达式：`Broadcast(_session, LiveCommentary.ObserveTurn(Memory(p.NetId), b, Name(p.NetId), _session.World!.Run!.Seed + p.NetId, RunManager.Instance.RunTime))`；返回值紧邻使用处：`ExpressionStatementSyntax: Broadcast(_session, LiveCommentary.ObserveTurn(Memory(p.NetId), b, Name(p.NetId), _session.World!.Run!.Seed + p.NetId, RunManager.Instance.RunTime));`
- `NationalSpire.Coop.CoopBroadcast.Guard(System.Action)`；输入表达式：`Guard(() =>      {          if (!CombatManager.Instance.IsInProgress) return;          var state = RunManager.Instance.DebugOnlyGetState()!;          var entries = CombatManager.Instance.History.Entries.ToList();          if (_historyCount > entries.Count) _historyCount = 0;          if (_battles.Count == 0) Initialize(false);          foreach (var entry in entries.Skip(_historyCount)) foreach (var p in state.Players)          {              if (!_battles.TryGetValue(p.NetId, out var b)) continue;              int turn = p.PlayerCombatState?.TurnNumber ?? 1;              if (b.Turn != turn) { b.Turn = turn; b.Cards = b.Draws = b.Damage = 0; }              if (entry is CardPlayFinishedEntry card && card.CardPlay.Card.Owner == p) { b.Cards++; b.LastCard = GameText.Plain(card.CardPlay.Card.Title); }              if (entry is CardDrawnEntry draw && draw.Card.Owner == p && !draw.FromHandDraw) b.Draws++;              if (entry is DamageReceivedEntry damage)              {                  if (damage.Receiver.IsEnemy && damage.Dealer == p.Creature) b.Damage += damage.Result.UnblockedDamage;                  if (damage.Receiver == p.Creature) b.HpLost += Math.Max(0, damage.Result.UnblockedDamage);              }              b.PeakCards = Math.Max(b.PeakCards, b.Cards); b.PeakDraws = Math.Max(b.PeakDraws, b.Draws); b.PeakDamage = Math.Max(b.PeakDamage, b.Damage);              b.Hp = p.Creature.CurrentHp; b.MaxHp = p.Creature.MaxHp;              if (p.Creature.CombatState is { } combat)                  LiveVoiceObservation.Observe(_voices, b, combat, p, entry, Name(p.NetId), RunManager.Instance.RunTime);              if (entry is CardPlayFinishedEntry played && played.CardPlay.Card.Owner == p && !CombatManager.Instance.IsEnding && CanSpeak)                  Broadcast(_session, LiveCommentary.ObserveTurn(Memory(p.NetId), b, Name(p.NetId), _session.World!.Run!.Seed + p.NetId, RunManager.Instance.RunTime));          }          _historyCount = entries.Count;      })`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Guard(() =>      {          if (!CombatManager.Instance.IsInProgress) return;          var state = RunManager.Instance.DebugOnlyGetState()!;          var entries = CombatManager.Instance.History.Entries.ToList();          if (_historyCount > entries.Count) _historyCount = 0;          if (_battles.Count == 0) Initialize(false);          foreach (var entry in entries.Skip(_historyCount)) foreach (var p in state.Players)          {              if (!_battles.TryGetValue(p.NetId, out var b)) continue;              int turn = p.PlayerCombatState?.TurnNumber ?? 1;              if (b.Turn != turn) { b.Turn = turn; b.Cards = b.Draws = b.Damage = 0; }              if (entry is CardPlayFinishedEntry card && card.CardPlay.Card.Owner == p) { b.Cards++; b.LastCard = GameText.Plain(card.CardPlay.Card.Title); }              if (entry is CardDrawnEntry draw && draw.Card.Owner == p && !draw.FromHandDraw) b.Draws++;              if (entry is DamageReceivedEntry damage)              {                  if (damage.Receiver.IsEnemy && damage.Dealer == p.Creature) b.Damage += damage.Result.UnblockedDamage;                  if (damage.Receiver == p.Creature) b.HpLost += Math.Max(0, damage.Result.UnblockedDamage);              }              b.PeakCards = Math.Max(b.PeakCards, b.Cards); b.PeakDraws = Math.Max(b.PeakDraws, b.Draws); b.PeakDamage = Math.Max(b.PeakDamage, b.Damage);              b.Hp = p.Creature.CurrentHp; b.MaxHp = p.Creature.MaxHp;              if (p.Creature.CombatState is { } combat)                  LiveVoiceObservation.Observe(_voices, b, combat, p, entry, Name(p.NetId), RunManager.Instance.RunTime);              if (entry is CardPlayFinishedEntry played && played.CardPlay.Card.Owner == p && !CombatManager.Instance.IsEnding && CanSpeak)                  Broadcast(_session, LiveCommentary.ObserveTurn(Memory(p.NetId), b, Name(p.NetId), _session.World!.Run!.Seed + p.NetId, RunManager.Instance.RunTime));          }          _historyCount = entries.Count;      })`
- `NationalSpire.Coop.CoopBroadcast.Initialize(bool)`；输入表达式：`Initialize(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: Initialize(false);`
- `NationalSpire.Coop.CoopBroadcast.Memory(ulong)`；输入表达式：`Memory(p.NetId)`；返回值紧邻使用处：`ArgumentSyntax: Memory(p.NetId)`
- `NationalSpire.Coop.CoopBroadcast.Name(ulong)`；输入表达式：`Name(p.NetId)`；返回值紧邻使用处：`ArgumentSyntax: Name(p.NetId)`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(card.CardPlay.Card.Title)`；返回值紧邻使用处：`AssignmentExpressionSyntax: b.LastCard = GameText.Plain(card.CardPlay.Card.Title)`
- `NationalSpire.LiveCommentary.ObserveTurn(NationalSpire.BroadcastMemory, NationalSpire.BattleObservation, string, string, double)`；输入表达式：`LiveCommentary.ObserveTurn(Memory(p.NetId), b, Name(p.NetId), _session.World!.Run!.Seed + p.NetId, RunManager.Instance.RunTime)`；返回值紧邻使用处：`ArgumentSyntax: LiveCommentary.ObserveTurn(Memory(p.NetId), b, Name(p.NetId), _session.World!.Run!.Seed + p.NetId, RunManager.Instance.RunTime)`
- `NationalSpire.LiveVoiceObservation.Observe(NationalSpire.LiveVoices?, NationalSpire.BattleObservation, MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Combat.History.CombatHistoryEntry, string, double)`；输入表达式：`LiveVoiceObservation.Observe(_voices, b, combat, p, entry, Name(p.NetId), RunManager.Instance.RunTime)`；返回值紧邻使用处：`ExpressionStatementSyntax: LiveVoiceObservation.Observe(_voices, b, combat, p, entry, Name(p.NetId), RunManager.Instance.RunTime);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_battles.TryGetValue(p.NetId, out var b)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_battles.TryGetValue(p.NetId, out var b)`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`entries.Skip(_historyCount)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var entry in entries.Skip(_historyCount)) foreach (var p in state.Players)          {              if (!_battles.TryGetValue(p.NetId, out var b)) continue;              int turn = p.PlayerCombatState?.TurnNumber ?? 1;              if (b.Turn != turn) { b.Turn = turn; b.Cards = b.Draws = b.Damage = 0; }              if (entry is CardPlayFinishedEntry card && card.CardPlay.Card.Owner == p) { b.Cards++; b.LastCard = GameText.Plain(card.CardPlay.Card.Title); }              if (entry is CardDrawnEntry draw && draw.Card.Owner == p && !draw.FromHandDraw) b.Draws++;              if (entry is DamageReceivedEntry damage)              {                  if (damage.Receiver.IsEnemy && damage.Dealer == p.Creature) b.Damage += damage.Result.UnblockedDamage;                  if (damage.Receiver == p.Creature) b.HpLost += Math.Max(0, damage.Result.UnblockedDamage);              }              b.PeakCards = Math.Max(b.PeakCards, b.Cards); b.PeakDraws = Math.Max(b.PeakDraws, b.Draws); b.PeakDamage = Math.Max(b.PeakDamage, b.Damage);              b.Hp = p.Creature.CurrentHp; b.MaxHp = p.Creature.MaxHp;              if (p.Creature.CombatState is { } combat)                  LiveVoiceObservation.Observe(_voices, b, combat, p, entry, Name(p.NetId), RunManager.Instance.RunTime);              if (entry is CardPlayFinishedEntry played && played.CardPlay.Card.Owner == p && !CombatManager.Instance.IsEnding && CanSpeak)                  Broadcast(_session, LiveCommentary.ObserveTurn(Memory(p.NetId), b, Name(p.NetId), _session.World!.Run!.Seed + p.NetId, RunManager.Instance.RunTime));          }`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`CombatManager.Instance.History.Entries.ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CombatManager.Instance.History.Entries.ToList()`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, damage.Result.UnblockedDamage)`；返回值紧邻使用处：`AssignmentExpressionSyntax: b.HpLost += Math.Max(0, damage.Result.UnblockedDamage)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(b.PeakCards, b.Cards)`；返回值紧邻使用处：`AssignmentExpressionSyntax: b.PeakCards = Math.Max(b.PeakCards, b.Cards)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(b.PeakDamage, b.Damage)`；返回值紧邻使用处：`AssignmentExpressionSyntax: b.PeakDamage = Math.Max(b.PeakDamage, b.Damage)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(b.PeakDraws, b.Draws)`；返回值紧邻使用处：`AssignmentExpressionSyntax: b.PeakDraws = Math.Max(b.PeakDraws, b.Draws)`

**赋值（含属性/字段和局部值）：**

- `_historyCount` = `0`
- `_historyCount` = `entries.Count`
- `b.Cards` = `b.Draws = b.Damage = 0`
- `b.Damage` += `damage.Result.UnblockedDamage`
- `b.Damage` = `0`
- `b.Draws` = `b.Damage = 0`
- `b.Hp` = `p.Creature.CurrentHp`
- `b.HpLost` += `Math.Max(0, damage.Result.UnblockedDamage)`
- `b.LastCard` = `GameText.Plain(card.CardPlay.Card.Title)`
- `b.MaxHp` = `p.Creature.MaxHp`
- `b.PeakCards` = `Math.Max(b.PeakCards, b.Cards)`
- `b.PeakDamage` = `Math.Max(b.PeakDamage, b.Damage)`
- `b.PeakDraws` = `Math.Max(b.PeakDraws, b.Draws)`
- `b.Turn` = `turn`

<a id="symbol-eccbe21df9a0"></a>

## `NationalSpire.Coop.CoopBroadcast.Name(ulong) — private string Name(ulong id)`

来源：源码第 127 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopBroadcast.Changed()`](CoopBroadcast.cs.md#symbol-9cb809e0579a)；[`NationalSpire.Coop.CoopBroadcast.Tick()`](CoopBroadcast.cs.md#symbol-3be13ce2aa51)；[`NationalSpire.Coop.CoopBroadcast.Won(MegaCrit.Sts2.Core.Rooms.CombatRoom)`](CoopBroadcast.cs.md#symbol-bf9e47770d28)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopBroadcast._session`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopMember.Name`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopWorld.Members`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`_session.World!.Members.Single(m => m.SteamId == id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _session.World!.Members.Single(m => m.SteamId == id).Name`

**赋值（含属性/字段和局部值）：**


<a id="symbol-bf9e47770d28"></a>

## `NationalSpire.Coop.CoopBroadcast.Won(MegaCrit.Sts2.Core.Rooms.CombatRoom) — private void Won(CombatRoom room)`

来源：源码第 128 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopBroadcast.Broadcast(NationalSpire.Coop.CoopCoordinator, NationalSpire.BroadcastLine?)`](CoopBroadcast.cs.md#symbol-647e8c7161ba)；[`NationalSpire.Coop.CoopBroadcast.Guard(System.Action)`](CoopBroadcast.cs.md#symbol-845730f8a94c)；[`NationalSpire.Coop.CoopBroadcast.Memory(ulong)`](CoopBroadcast.cs.md#symbol-ffccdc0feb66)；[`NationalSpire.Coop.CoopBroadcast.Name(ulong)`](CoopBroadcast.cs.md#symbol-eccbe21df9a0)；[`NationalSpire.LiveCommentary.Finish(NationalSpire.BroadcastMemory, NationalSpire.BattleObservation, string, string, double)`](../LiveCommentary.cs.md#symbol-243aedb210e3)；`MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.BattleObservation.CompleteObservation`；`NationalSpire.BattleObservation.Hp`；`NationalSpire.BattleObservation.MaxHp`；`NationalSpire.Coop.CoopBroadcast._battles`；`NationalSpire.Coop.CoopBroadcast._session`；`NationalSpire.Coop.CoopBroadcast.Broadcast(NationalSpire.Coop.CoopCoordinator, NationalSpire.BroadcastLine?)`；`NationalSpire.Coop.CoopBroadcast.Guard(System.Action)`；`NationalSpire.Coop.CoopBroadcast.Memory(ulong)`；`NationalSpire.Coop.CoopBroadcast.Name(ulong)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRun.Seed`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.LiveCommentary.Finish(NationalSpire.BroadcastMemory, NationalSpire.BattleObservation, string, string, double)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；输入表达式：`RunManager.Instance.DebugOnlyGetState()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: RunManager.Instance.DebugOnlyGetState()!`
- `NationalSpire.Coop.CoopBroadcast.Broadcast(NationalSpire.Coop.CoopCoordinator, NationalSpire.BroadcastLine?)`；输入表达式：`Broadcast(_session, LiveCommentary.Finish(Memory(p.NetId), b, Name(p.NetId), _session.World!.Run!.Seed + p.NetId, RunManager.Instance.RunTime))`；返回值紧邻使用处：`ExpressionStatementSyntax: Broadcast(_session, LiveCommentary.Finish(Memory(p.NetId), b, Name(p.NetId), _session.World!.Run!.Seed + p.NetId, RunManager.Instance.RunTime));`
- `NationalSpire.Coop.CoopBroadcast.Guard(System.Action)`；输入表达式：`Guard(() =>      {          var state = RunManager.Instance.DebugOnlyGetState()!;          foreach (var p in state.Players)          {              if (!_battles.TryGetValue(p.NetId, out var b)) continue;              b.Hp = p.Creature.CurrentHp; b.MaxHp = p.Creature.MaxHp;              if (b.Hp <= 0) { b.CompleteObservation = false; continue; }              Broadcast(_session, LiveCommentary.Finish(Memory(p.NetId), b, Name(p.NetId), _session.World!.Run!.Seed + p.NetId, RunManager.Instance.RunTime));          }          _battles.Clear();      })`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Guard(() =>      {          var state = RunManager.Instance.DebugOnlyGetState()!;          foreach (var p in state.Players)          {              if (!_battles.TryGetValue(p.NetId, out var b)) continue;              b.Hp = p.Creature.CurrentHp; b.MaxHp = p.Creature.MaxHp;              if (b.Hp <= 0) { b.CompleteObservation = false; continue; }              Broadcast(_session, LiveCommentary.Finish(Memory(p.NetId), b, Name(p.NetId), _session.World!.Run!.Seed + p.NetId, RunManager.Instance.RunTime));          }          _battles.Clear();      })`
- `NationalSpire.Coop.CoopBroadcast.Memory(ulong)`；输入表达式：`Memory(p.NetId)`；返回值紧邻使用处：`ArgumentSyntax: Memory(p.NetId)`
- `NationalSpire.Coop.CoopBroadcast.Name(ulong)`；输入表达式：`Name(p.NetId)`；返回值紧邻使用处：`ArgumentSyntax: Name(p.NetId)`
- `NationalSpire.LiveCommentary.Finish(NationalSpire.BroadcastMemory, NationalSpire.BattleObservation, string, string, double)`；输入表达式：`LiveCommentary.Finish(Memory(p.NetId), b, Name(p.NetId), _session.World!.Run!.Seed + p.NetId, RunManager.Instance.RunTime)`；返回值紧邻使用处：`ArgumentSyntax: LiveCommentary.Finish(Memory(p.NetId), b, Name(p.NetId), _session.World!.Run!.Seed + p.NetId, RunManager.Instance.RunTime)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_battles.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _battles.Clear();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_battles.TryGetValue(p.NetId, out var b)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_battles.TryGetValue(p.NetId, out var b)`

**赋值（含属性/字段和局部值）：**

- `b.CompleteObservation` = `false`
- `b.Hp` = `p.Creature.CurrentHp`
- `b.MaxHp` = `p.Creature.MaxHp`

<a id="symbol-647e8c7161ba"></a>

## `NationalSpire.Coop.CoopBroadcast.Broadcast(NationalSpire.Coop.CoopCoordinator, NationalSpire.BroadcastLine?) — private void Broadcast(CoopCoordinator session, BroadcastLine? line)`

来源：源码第 140 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopBroadcast.Changed()`](CoopBroadcast.cs.md#symbol-9cb809e0579a)；[`NationalSpire.Coop.CoopBroadcast.Tick()`](CoopBroadcast.cs.md#symbol-3be13ce2aa51)；[`NationalSpire.Coop.CoopBroadcast.Won(MegaCrit.Sts2.Core.Rooms.CombatRoom)`](CoopBroadcast.cs.md#symbol-bf9e47770d28)

**调用：** [`NationalSpire.Coop.CoopBroadcast.EmitLine(NationalSpire.Coop.CoopCoordinator, NationalSpire.BroadcastLine?)`](CoopBroadcast.cs.md#symbol-8da73f7de069)；[`NationalSpire.LiveVoices.React(string, int, double)`](../LiveVoices.cs.md#symbol-ca2aacab4a81)；`MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastLine.Role`；`NationalSpire.BroadcastLine.Topic`；`NationalSpire.Coop.CoopBroadcast._voices`；`NationalSpire.Coop.CoopBroadcast.EmitLine(NationalSpire.Coop.CoopCoordinator, NationalSpire.BroadcastLine?)`；`NationalSpire.LiveVoices.React(string, int, double)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；输入表达式：`RunManager.Instance.DebugOnlyGetState()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: RunManager.Instance.DebugOnlyGetState()?.TotalFloor`
- `NationalSpire.Coop.CoopBroadcast.EmitLine(NationalSpire.Coop.CoopCoordinator, NationalSpire.BroadcastLine?)`；输入表达式：`EmitLine(session, line)`；返回值紧邻使用处：`BinaryExpressionSyntax: EmitLine(session, line) && line.Role == "commentator"`
- `NationalSpire.LiveVoices.React(string, int, double)`；输入表达式：`.React(line.Topic, RunManager.Instance.DebugOnlyGetState()?.TotalFloor ?? 0, RunManager.Instance.RunTime)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _voices?.React(line.Topic, RunManager.Instance.DebugOnlyGetState()?.TotalFloor ?? 0, RunManager.Instance.RunTime)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-22df7c0c92f1"></a>

## `NationalSpire.Coop.CoopBroadcast.Emit(NationalSpire.Coop.CoopCoordinator, NationalSpire.BroadcastLine?) — public static void Emit(CoopCoordinator session, BroadcastLine? line)`

来源：源码第 146 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopBroadcast.EmitLine(NationalSpire.Coop.CoopCoordinator, NationalSpire.BroadcastLine?)`](CoopBroadcast.cs.md#symbol-8da73f7de069)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopBroadcast.EmitLine(NationalSpire.Coop.CoopCoordinator, NationalSpire.BroadcastLine?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopBroadcast.EmitLine(NationalSpire.Coop.CoopCoordinator, NationalSpire.BroadcastLine?)`；输入表达式：`EmitLine(session, line)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => EmitLine(session, line)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8da73f7de069"></a>

## `NationalSpire.Coop.CoopBroadcast.EmitLine(NationalSpire.Coop.CoopCoordinator, NationalSpire.BroadcastLine?) — private static bool EmitLine(CoopCoordinator session, BroadcastLine? line)`

来源：源码第 147 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopBroadcast.Broadcast(NationalSpire.Coop.CoopCoordinator, NationalSpire.BroadcastLine?)`](CoopBroadcast.cs.md#symbol-647e8c7161ba)；[`NationalSpire.Coop.CoopBroadcast.Emit(NationalSpire.Coop.CoopCoordinator, NationalSpire.BroadcastLine?)`](CoopBroadcast.cs.md#symbol-22df7c0c92f1)

**调用：** [`NationalSpire.CommentatorSelection.ForMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, System.Collections.Generic.IEnumerable<string>?)`](../CommentatorSelection.cs.md#symbol-2c2966603311)；`NationalSpire.BroadcastMemory.BroadcastMemory()`；`NationalSpire.Coop.CoopSpeech.CoopSpeech(string, string, string, string)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.RemoveAt(int)`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastLine.Analyst`；`NationalSpire.BroadcastLine.Role`；`NationalSpire.BroadcastLine.SpeakerId`；`NationalSpire.BroadcastLine.Text`；`NationalSpire.BroadcastLine.Topic`；`NationalSpire.BroadcastMemory.LastSpoke`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CommentatorSelection.ForMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, System.Collections.Generic.IEnumerable<string>?)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRun.Broadcasts`；`NationalSpire.Coop.CoopRun.MatchId`；`NationalSpire.Coop.CoopRun.Opponents`；`NationalSpire.Coop.CoopRun.Speeches`；`NationalSpire.Coop.CoopSpeech.Role`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.CoopWorld.World`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.BroadcastMemory.BroadcastMemory()`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: shared = new()`
- `NationalSpire.CommentatorSelection.ForMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, System.Collections.Generic.IEnumerable<string>?)`；输入表达式：`CommentatorSelection.ForMatch(session.World.World, session.World.World.Matches.Single(m => m.Id == live.MatchId), live.Opponents)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommentatorSelection.ForMatch(session.World.World, session.World.World.Matches.Single(m => m.Id == live.MatchId), live.Opponents)`
- `NationalSpire.Coop.CoopSpeech.CoopSpeech(string, string, string, string)`；输入表达式：`new(Guid.NewGuid().ToString("N"), speaker, line.Text, line.Topic) { Role = line.Role }`；返回值紧邻使用处：`ArgumentSyntax: new(Guid.NewGuid().ToString("N"), speaker, line.Text, line.Topic) { Role = line.Role }`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`session.World.World.Matches.Single(m => m.Id == live.MatchId)`；返回值紧邻使用处：`ArgumentSyntax: session.World.World.Matches.Single(m => m.Id == live.MatchId)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`live.Broadcasts.GetValueOrDefault(0UL)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = live.Broadcasts.GetValueOrDefault(0UL)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`live.Speeches.Add(new(Guid.NewGuid().ToString("N"), speaker, line.Text, line.Topic) { Role = line.Role })`；返回值紧邻使用处：`ExpressionStatementSyntax: live.Speeches.Add(new(Guid.NewGuid().ToString("N"), speaker, line.Text, line.Topic) { Role = line.Role });`
- `System.Collections.Generic.List<T>.RemoveAt(int)`；输入表达式：`live.Speeches.RemoveAt(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: live.Speeches.RemoveAt(0);`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`ArgumentSyntax: Guid.NewGuid().ToString("N")`

**赋值（含属性/字段和局部值）：**

- `live.Broadcasts[0]` = `shared = new()`
- `Role` = `line.Role`
- `shared.LastSpoke` = `now`
- `shared` = `new()`

<a id="symbol-7bb2229c33dc"></a>

## `NationalSpire.Coop.CoopBroadcast.Dispose() — public void Dispose()`

来源：源码第 161 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopLive.Close()`](CoopLive.cs.md#symbol-85319a2fb491)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopBroadcast.Changed()`；`NationalSpire.Coop.CoopBroadcast.Started(MegaCrit.Sts2.Core.Combat.ICombatState)`；`NationalSpire.Coop.CoopBroadcast.Won(MegaCrit.Sts2.Core.Rooms.CombatRoom)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `CombatManager.Instance.CombatSetUp` -= `Started`
- `CombatManager.Instance.CombatWon` -= `Won`
- `CombatManager.Instance.History.Changed` -= `Changed`
