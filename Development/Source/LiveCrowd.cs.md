# LiveCrowd.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`DB281B31D1048B75FA7085ABF9075B39F6D8B15BE5AF7424C8D370545BAD7329`。来源：[源码](../../LiveCrowd.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LiveVoices`、`NationalSpire.LiveCueRules`。

字段、事件及初始值（源码原样）：

```csharp
private bool _finished;
private int _crowdFloor = -1;
```

<a id="symbol-ee58b4cd422c"></a>

## `NationalSpire.LiveVoices.RestoreVoiceClock(double) — private void RestoreVoiceClock(double now)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveVoices.Ambient(bool, int, double)`](LiveCrowd.cs.md#symbol-789980beddf3)；[`NationalSpire.LiveVoices.Cue(string, string, int, double, int)`](LiveCrowd.cs.md#symbol-8f4f65d60af0)；[`NationalSpire.LiveVoices.Poll(double, double)`](LiveVoices.cs.md#symbol-fc95fe2519bc)

**调用：** `System.Collections.Generic.Queue<T>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastMemory.Voices`；`NationalSpire.LiveVoices._lastClock`；`NationalSpire.LiveVoices._memory`；`NationalSpire.LiveVoices._pending`；`NationalSpire.LiveVoiceState.LastCueAt`；`NationalSpire.LiveVoiceState.NextCrowdAt`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Queue<T>.Clear()`；输入表达式：`_pending.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _pending.Clear();`

**赋值（含属性/字段和局部值）：**

- `_lastClock` = `now`
- `_memory.Voices.LastCueAt` = `now`
- `_memory.Voices.NextCrowdAt` = `now + 30`

<a id="symbol-e8e2ca38a1de"></a>

## `NationalSpire.LiveVoices.ClearCombatChatter(bool) — private void ClearCombatChatter(bool keepFinishingHit = false)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveVoices.Ambient(bool, int, double)`](LiveCrowd.cs.md#symbol-789980beddf3)；[`NationalSpire.LiveVoices.Cue(string, string, int, double, int)`](LiveCrowd.cs.md#symbol-8f4f65d60af0)

**调用：** `string.Contains(string, System.StringComparison)`；`string.EndsWith(string, System.StringComparison)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.Queue<T>.Clear()`；`System.Collections.Generic.Queue<T>.Enqueue(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastLine.Topic`；`NationalSpire.LiveVoices._pending`；`NationalSpire.LiveVoices.Pending.Line`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Contains(string, System.StringComparison)`；输入表达式：`p.Line.Topic.Contains("_cue_", StringComparison.Ordinal)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !p.Line.Topic.Contains("_cue_", StringComparison.Ordinal)`
- `string.Contains(string, System.StringComparison)`；输入表达式：`p.Line.Topic.Contains("_idle_", StringComparison.Ordinal)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !p.Line.Topic.Contains("_idle_", StringComparison.Ordinal)`
- `string.EndsWith(string, System.StringComparison)`；输入表达式：`p.Line.Topic.EndsWith("_cue_exact_lethal", StringComparison.Ordinal)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Line.Topic.EndsWith("_cue_exact_lethal", StringComparison.Ordinal)                 || p.Line.Topic.EndsWith("_cue_overkill", StringComparison.Ordinal)`
- `string.EndsWith(string, System.StringComparison)`；输入表达式：`p.Line.Topic.EndsWith("_cue_overkill", StringComparison.Ordinal)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Line.Topic.EndsWith("_cue_exact_lethal", StringComparison.Ordinal)                 || p.Line.Topic.EndsWith("_cue_overkill", StringComparison.Ordinal)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_pending.Where(p => keepFinishingHit && (p.Line.Topic.EndsWith("_cue_exact_lethal", StringComparison.Ordinal)                 || p.Line.Topic.EndsWith("_cue_overkill", StringComparison.Ordinal))             || !p.Line.Topic.Contains("_idle_", StringComparison.Ordinal)                 && !p.Line.Topic.Contains("_cue_", StringComparison.Ordinal)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _pending.Where(p => keepFinishingHit && (p.Line.Topic.EndsWith("_cue_exact_lethal", StringComparison.Ordinal)                 || p.Line.Topic.EndsWith("_cue_overkill", StringComparison.Ordinal))             || !p.Line.Topic.Contains("_idle_", StringComparison.Ordinal)                 && !p.Line.Topic.Contains("_cue_", StringComparison.Ordinal)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_pending.Where(p => keepFinishingHit && (p.Line.Topic.EndsWith("_cue_exact_lethal", StringComparison.Ordinal)                 || p.Line.Topic.EndsWith("_cue_overkill", StringComparison.Ordinal))             || !p.Line.Topic.Contains("_idle_", StringComparison.Ordinal)                 && !p.Line.Topic.Contains("_cue_", StringComparison.Ordinal))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _pending.Where(p => keepFinishingHit && (p.Line.Topic.EndsWith("_cue_exact_lethal", StringComparison.Ordinal)                 || p.Line.Topic.EndsWith("_cue_overkill", StringComparison.Ordinal))             || !p.Line.Topic.Contains("_idle_", StringComparison.Ordinal)                 && !p.Line.Topic.Contains("_cue_", StringComparison.Ordinal)).ToArray`
- `System.Collections.Generic.Queue<T>.Clear()`；输入表达式：`_pending.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _pending.Clear();`
- `System.Collections.Generic.Queue<T>.Enqueue(T)`；输入表达式：`_pending.Enqueue(entry)`；返回值紧邻使用处：`ExpressionStatementSyntax: _pending.Enqueue(entry);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-789980beddf3"></a>

## `NationalSpire.LiveVoices.Ambient(bool, int, double) — public void Ambient(bool combat, int floor, double now)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopBroadcast.Tick()`](Coop/CoopBroadcast.cs.md#symbol-3be13ce2aa51)；[`NationalSpire.LiveRunBridge.UpdateRace()`](LiveRunBridge.cs.md#symbol-9566200347bc)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.LiveVoices.Add(NationalSpire.BroadcastLine?, double, string?, bool, double)`](LiveVoices.cs.md#symbol-09cc5837543a)；[`NationalSpire.LiveVoices.ClearCombatChatter(bool)`](LiveCrowd.cs.md#symbol-e8e2ca38a1de)；[`NationalSpire.LiveVoices.Hash(string)`](LiveVoices.cs.md#symbol-8ecd046e0f8e)；[`NationalSpire.LiveVoices.Line(string, string, NationalSpire.CareerPerson?, System.Collections.Generic.Dictionary<string, string>)`](LiveVoices.cs.md#symbol-1b186645d9df)；[`NationalSpire.LiveVoices.RestoreVoiceClock(double)`](LiveCrowd.cs.md#symbol-ee58b4cd422c)；[`NationalSpire.LiveVoices.Spectator(string, string?, bool)`](LiveVoices.cs.md#symbol-57831f321298)；[`NationalSpire.LiveVoices.Tone(NationalSpire.CareerPerson)`](LiveVoices.cs.md#symbol-c3c21233cc88)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastMemory.Voices`；`NationalSpire.CareerClub.Id`；`NationalSpire.CareerClub.Name`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerPerson.SupportedClubId`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.Clubs`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.LiveVoices._crowdFloor`；`NationalSpire.LiveVoices._data`；`NationalSpire.LiveVoices._finished`；`NationalSpire.LiveVoices._memory`；`NationalSpire.LiveVoices._opponents`；`NationalSpire.LiveVoices._pending`；`NationalSpire.LiveVoices.Add(NationalSpire.BroadcastLine?, double, string?, bool, double)`；`NationalSpire.LiveVoices.ClearCombatChatter(bool)`；`NationalSpire.LiveVoices.Hash(string)`；`NationalSpire.LiveVoices.Line(string, string, NationalSpire.CareerPerson?, System.Collections.Generic.Dictionary<string, string>)`；`NationalSpire.LiveVoices.RestoreVoiceClock(double)`；`NationalSpire.LiveVoices.Spectator(string, string?, bool)`；`NationalSpire.LiveVoices.Tone(NationalSpire.CareerPerson)`；`NationalSpire.LiveVoiceState.LastOptional`；`NationalSpire.LiveVoiceState.NextCrowdAt`；`NationalSpire.LiveVoiceState.Sequence`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(_data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["name"] = CareerEngine.Name(_data)`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(_data)`；返回值紧邻使用处：`ConditionalExpressionSyntax: club != null && clubId == _data.Esports.ClubId ? CareerEngine.Name(_data) : clubTarget?.PublicName`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(_data, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => CareerEngine.Person(_data, id)`
- `NationalSpire.LiveVoices.Add(NationalSpire.BroadcastLine?, double, string?, bool, double)`；输入表达式：`Add(Line("audience_idle_" + kind, "audience", person, facts), now, reply, lifetime: 24)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(Line("audience_idle_" + kind, "audience", person, facts), now, reply, lifetime: 24);`
- `NationalSpire.LiveVoices.ClearCombatChatter(bool)`；输入表达式：`ClearCombatChatter()`；返回值紧邻使用处：`ExpressionStatementSyntax: ClearCombatChatter();`
- `NationalSpire.LiveVoices.ClearCombatChatter(bool)`；输入表达式：`ClearCombatChatter(keepFinishingHit: true)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClearCombatChatter(keepFinishingHit: true);`
- `NationalSpire.LiveVoices.Hash(string)`；输入表达式：`Hash("idle:first:" + floor)`；返回值紧邻使用处：`BinaryExpressionSyntax: Hash("idle:first:" + floor) % 26`
- `NationalSpire.LiveVoices.Hash(string)`；输入表达式：`Hash("idle:kind:" + state.Sequence + floor)`；返回值紧邻使用处：`BinaryExpressionSyntax: Hash("idle:kind:" + state.Sequence + floor) % 8`
- `NationalSpire.LiveVoices.Hash(string)`；输入表达式：`Hash("idle:reply:" + state.Sequence)`；返回值紧邻使用处：`BinaryExpressionSyntax: Hash("idle:reply:" + state.Sequence) % 3`
- `NationalSpire.LiveVoices.Hash(string)`；输入表达式：`Hash("idle:wait:" + state.Sequence + floor)`；返回值紧邻使用处：`BinaryExpressionSyntax: Hash("idle:wait:" + state.Sequence + floor) % 29`
- `NationalSpire.LiveVoices.Line(string, string, NationalSpire.CareerPerson?, System.Collections.Generic.Dictionary<string, string>)`；输入表达式：`Line("audience_idle_" + kind, "audience", person, facts)`；返回值紧邻使用处：`ArgumentSyntax: Line("audience_idle_" + kind, "audience", person, facts)`
- `NationalSpire.LiveVoices.RestoreVoiceClock(double)`；输入表达式：`RestoreVoiceClock(now)`；返回值紧邻使用处：`ExpressionStatementSyntax: RestoreVoiceClock(now);`
- `NationalSpire.LiveVoices.Spectator(string, string?, bool)`；输入表达式：`Spectator("idle")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Spectator("idle")`
- `NationalSpire.LiveVoices.Tone(NationalSpire.CareerPerson)`；输入表达式：`Tone(person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Tone(person)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, string> { ["name"] = CareerEngine.Name(_data), ["country"] = person.Country,             ["club"] = club?.Name ?? "", ["supported"] = supported ?? "" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, string> { ["name"] = CareerEngine.Name(_data), ["country"] = person.Country,             ["club"] = club?.Name ?? "", ["supported"] = supported ?? "" }`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`_data.Esports.Clubs.FirstOrDefault(c => c.Id == clubId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _data.Esports.Clubs.FirstOrDefault(c => c.Id == clubId)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`_opponents.Select(id => CareerEngine.Person(_data, id)).FirstOrDefault(p => p?.ClubId == clubId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: club == null ? null : _opponents.Select(id => CareerEngine.Person(_data, id)).FirstOrDefault(p => p?.ClubId == clubId)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`_opponents.Select(id => CareerEngine.Person(_data, id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _opponents.Select(id => CareerEngine.Person(_data, id)).FirstOrDefault`

**赋值（含属性/字段和局部值）：**

- `_crowdFloor` = `floor`
- `["club"]` = `club?.Name ?? ""`
- `["country"]` = `person.Country`
- `["name"]` = `CareerEngine.Name(_data)`
- `["supported"]` = `supported ?? ""`
- `state.NextCrowdAt` = `now + 25 + Hash("idle:first:" + floor) % 26`
- `state.NextCrowdAt` = `now + 25`
- `state.NextCrowdAt` = `now + 32 + Hash("idle:wait:" + state.Sequence + floor) % 29`

<a id="symbol-8f4f65d60af0"></a>

## `NationalSpire.LiveVoices.Cue(string, string, int, double, int) — public void Cue(string scene, string name, int floor, double now, int loss = 0)`

来源：源码第 55 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveVoiceObservation.Observe(NationalSpire.LiveVoices?, NationalSpire.BattleObservation, MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Combat.History.CombatHistoryEntry, string, double)`](LiveVoiceObservation.cs.md#symbol-efed0893a47e)

**调用：** [`NationalSpire.LiveVoices.Add(NationalSpire.BroadcastLine?, double, string?, bool, double)`](LiveVoices.cs.md#symbol-09cc5837543a)；[`NationalSpire.LiveVoices.ClearCombatChatter(bool)`](LiveCrowd.cs.md#symbol-e8e2ca38a1de)；[`NationalSpire.LiveVoices.Hash(string)`](LiveVoices.cs.md#symbol-8ecd046e0f8e)；[`NationalSpire.LiveVoices.Line(string, string, NationalSpire.CareerPerson?, System.Collections.Generic.Dictionary<string, string>)`](LiveVoices.cs.md#symbol-1b186645d9df)；[`NationalSpire.LiveVoices.RestoreVoiceClock(double)`](LiveCrowd.cs.md#symbol-ee58b4cd422c)；[`NationalSpire.LiveVoices.Spectator(string, string?, bool)`](LiveVoices.cs.md#symbol-57831f321298)；`int.ToString()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastMemory.Voices`；`NationalSpire.LiveVoiceCatalog.Banks`；`NationalSpire.LiveVoices._crowdFloor`；`NationalSpire.LiveVoices._finished`；`NationalSpire.LiveVoices._memory`；`NationalSpire.LiveVoices._pending`；`NationalSpire.LiveVoices.Add(NationalSpire.BroadcastLine?, double, string?, bool, double)`；`NationalSpire.LiveVoices.ClearCombatChatter(bool)`；`NationalSpire.LiveVoices.Hash(string)`；`NationalSpire.LiveVoices.Line(string, string, NationalSpire.CareerPerson?, System.Collections.Generic.Dictionary<string, string>)`；`NationalSpire.LiveVoices.RestoreVoiceClock(double)`；`NationalSpire.LiveVoices.Spectator(string, string?, bool)`；`NationalSpire.LiveVoiceState.Floors`；`NationalSpire.LiveVoiceState.LastCueAt`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.ToString()`；输入表达式：`loss.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["loss"] = loss.ToString()`
- `NationalSpire.LiveVoices.Add(NationalSpire.BroadcastLine?, double, string?, bool, double)`；输入表达式：`Add(Line((host ? "host_cue_" : "audience_cue_") + scene, host ? "commentator" : "audience", host ? null : person, facts), now, lifetime: 23)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(Line((host ? "host_cue_" : "audience_cue_") + scene, host ? "commentator" : "audience", host ? null : person, facts), now, lifetime: 23);`
- `NationalSpire.LiveVoices.ClearCombatChatter(bool)`；输入表达式：`ClearCombatChatter()`；返回值紧邻使用处：`ExpressionStatementSyntax: ClearCombatChatter();`
- `NationalSpire.LiveVoices.Hash(string)`；输入表达式：`Hash("cue:chance:" + scene + floor)`；返回值紧邻使用处：`BinaryExpressionSyntax: Hash("cue:chance:" + scene + floor) % 3`
- `NationalSpire.LiveVoices.Hash(string)`；输入表达式：`Hash("cue:host:" + scene + floor)`；返回值紧邻使用处：`BinaryExpressionSyntax: Hash("cue:host:" + scene + floor) % 4`
- `NationalSpire.LiveVoices.Line(string, string, NationalSpire.CareerPerson?, System.Collections.Generic.Dictionary<string, string>)`；输入表达式：`Line((host ? "host_cue_" : "audience_cue_") + scene, host ? "commentator" : "audience", host ? null : person, facts)`；返回值紧邻使用处：`ArgumentSyntax: Line((host ? "host_cue_" : "audience_cue_") + scene, host ? "commentator" : "audience", host ? null : person, facts)`
- `NationalSpire.LiveVoices.RestoreVoiceClock(double)`；输入表达式：`RestoreVoiceClock(now)`；返回值紧邻使用处：`ExpressionStatementSyntax: RestoreVoiceClock(now);`
- `NationalSpire.LiveVoices.Spectator(string, string?, bool)`；输入表达式：`Spectator("cue:" + scene)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Spectator("cue:" + scene)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`LiveVoiceCatalog.Banks.ContainsKey("audience_cue_" + scene)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !LiveVoiceCatalog.Banks.ContainsKey("audience_cue_" + scene)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`LiveVoiceCatalog.Banks.ContainsKey("host_cue_" + scene)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !LiveVoiceCatalog.Banks.ContainsKey("host_cue_" + scene)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, string> { ["name"] = name, ["loss"] = loss.ToString() }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, string> { ["name"] = name, ["loss"] = loss.ToString() }`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`_memory.Voices.Floors.GetValueOrDefault("cue:" + scene, -20)`；返回值紧邻使用处：`BinaryExpressionSyntax: floor - _memory.Voices.Floors.GetValueOrDefault("cue:" + scene, -20)`

**赋值（含属性/字段和局部值）：**

- `_crowdFloor` = `floor`
- `_memory.Voices.Floors["cue:" + scene]` = `floor`
- `_memory.Voices.LastCueAt` = `now`
- `["loss"]` = `loss.ToString()`
- `["name"]` = `name`

<a id="symbol-f41fe00e7f8a"></a>

## `NationalSpire.LiveCueRules.CardScene(string, bool) — internal static string? CardScene(string id, bool attackWithBlock)`

来源：源码第 75 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveVoiceObservation.Observe(NationalSpire.LiveVoices?, NationalSpire.BattleObservation, MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Combat.History.CombatHistoryEntry, string, double)`](LiveVoiceObservation.cs.md#symbol-efed0893a47e)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**
