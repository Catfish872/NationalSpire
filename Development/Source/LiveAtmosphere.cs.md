# LiveAtmosphere.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`72E78FA2C2F1ECC775B9ACF15B1ACC693656308415AA56ECCDF636A65783BA04`。来源：[源码](../../LiveAtmosphere.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.AtmosphereContext`、`NationalSpire.LiveCommentary`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly Dictionary<string, string[]> AtmosphereBanks = [];
```

<a id="symbol-0b25ed42c5ca"></a>

## `NationalSpire.LiveCommentary.Atmosphere(NationalSpire.BroadcastMemory, NationalSpire.AtmosphereContext, string, double) — public static BroadcastLine? Atmosphere(BroadcastMemory m, AtmosphereContext c, string seed, double seconds)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopBroadcast.Tick()`](Coop/CoopBroadcast.cs.md#symbol-3be13ce2aa51)；[`NationalSpire.LiveRunBridge.UpdateRace()`](LiveRunBridge.cs.md#symbol-9566200347bc)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.LiveCommentary.ChooseFocus(NationalSpire.BroadcastMemory, string, System.Collections.Generic.IEnumerable<string>, string, System.Func<string, string>)`](CommentaryFocus.cs.md#symbol-780e8bcd69dc)；[`NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`](LiveCommentary.cs.md#symbol-28e751a76070)；`int.ToString()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AtmosphereContext.Act`；`NationalSpire.AtmosphereContext.Ascension`；`NationalSpire.AtmosphereContext.Character`；`NationalSpire.AtmosphereContext.Event`；`NationalSpire.AtmosphereContext.Floor`；`NationalSpire.AtmosphereContext.Gold`；`NationalSpire.AtmosphereContext.Hp`；`NationalSpire.AtmosphereContext.InCombat`；`NationalSpire.AtmosphereContext.Kind`；`NationalSpire.AtmosphereContext.MaxHp`；`NationalSpire.AtmosphereContext.Name`；`NationalSpire.AtmosphereContext.Rival`；`NationalSpire.AtmosphereContext.Turn`；`NationalSpire.BroadcastMemory.AtmosphereFloor`；`NationalSpire.BroadcastMemory.Battles`；`NationalSpire.BroadcastMemory.LastSpoke`；`NationalSpire.BroadcastMemory.NextAtmosphereAt`；`NationalSpire.BroadcastMemory.PhraseIndices`；`NationalSpire.BroadcastMemory.TopicTimes`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.LiveCommentary.ChooseFocus(NationalSpire.BroadcastMemory, string, System.Collections.Generic.IEnumerable<string>, string, System.Func<string, string>)`；`NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`；`NationalSpire.LiveCommentary.TopicFamily(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.ToString()`；输入表达式：`c.Ascension.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["asc"] = c.Ascension.ToString()`
- `int.ToString()`；输入表达式：`c.Floor.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["floor"] = c.Floor.ToString()`
- `int.ToString()`；输入表达式：`c.Gold.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["gold"] = c.Gold.ToString()`
- `int.ToString()`；输入表达式：`c.Hp.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["hp"] = c.Hp.ToString()`
- `int.ToString()`；输入表达式：`c.MaxHp.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["max"] = c.MaxHp.ToString()`
- `int.ToString()`；输入表达式：`c.Turn.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["turn"] = c.Turn.ToString()`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(seed + c.Floor)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.StableHash(seed + c.Floor) % 34`
- `NationalSpire.LiveCommentary.ChooseFocus(NationalSpire.BroadcastMemory, string, System.Collections.Generic.IEnumerable<string>, string, System.Func<string, string>)`；输入表达式：`ChooseFocus(m, "topics", topics, seed + ":chat:" + c.Floor, TopicFamily)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: ChooseFocus(m, "topics", topics, seed + ":chat:" + c.Floor, TopicFamily)!`
- `NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`；输入表达式：`Speak(m, topic, seconds, seed, facts)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Speak(m, topic, seconds, seed, facts)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`m.TopicTimes.ContainsKey("opening")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !m.TopicTimes.ContainsKey("opening")`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, string> { ["name"] = c.Name, ["rival"] = c.Rival, ["event"] = c.Event, ["character"] = c.Character, ["asc"] = c.Ascension.ToString(),              ["floor"] = c.Floor.ToString(), ["hp"] = c.Hp.ToString(), ["max"] = c.MaxHp.ToString(), ["gold"] = c.Gold.ToString(), ["turn"] = c.Turn.ToString() }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, string> { ["name"] = c.Name, ["rival"] = c.Rival, ["event"] = c.Event, ["character"] = c.Character, ["asc"] = c.Ascension.ToString(),              ["floor"] = c.Floor.ToString(), ["hp"] = c.Hp.ToString(), ["max"] = c.MaxHp.ToString(), ["gold"] = c.Gold.ToString(), ["turn"] = c.Turn.ToString() }`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`m.TopicTimes.GetValueOrDefault(t, -1000)`；返回值紧邻使用处：`BinaryExpressionSyntax: seconds - m.TopicTimes.GetValueOrDefault(t, -1000)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`m.PhraseIndices.GetValueOrDefault("count:" + t)`；返回值紧邻使用处：`BinaryExpressionSyntax: m.PhraseIndices.GetValueOrDefault("count:" + t) >= 2`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`m.PhraseIndices.GetValueOrDefault("count:" + topic)`；返回值紧邻使用处：`BinaryExpressionSyntax: m.PhraseIndices.GetValueOrDefault("count:" + topic) + 1`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`topics.Add("early_chat")`；返回值紧邻使用处：`ExpressionStatementSyntax: topics.Add("early_chat");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`topics.Add("healthy_chat")`；返回值紧邻使用处：`ExpressionStatementSyntax: topics.Add("healthy_chat");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`topics.Add("long_battle")`；返回值紧邻使用处：`ExpressionStatementSyntax: topics.Add("long_battle");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`topics.Add("opening")`；返回值紧邻使用处：`ExpressionStatementSyntax: topics.Add("opening");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`topics.Add("rest_chat")`；返回值紧邻使用处：`ExpressionStatementSyntax: topics.Add("rest_chat");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`topics.Add("shop_chat")`；返回值紧邻使用处：`ExpressionStatementSyntax: topics.Add("shop_chat");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`topics.Add("unknown_chat")`；返回值紧邻使用处：`ExpressionStatementSyntax: topics.Add("unknown_chat");`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string>()`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`topics.RemoveAll(t => m.PhraseIndices.GetValueOrDefault("count:" + t) >= 2 || seconds - m.TopicTimes.GetValueOrDefault(t, -1000) < 140)`；返回值紧邻使用处：`ExpressionStatementSyntax: topics.RemoveAll(t => m.PhraseIndices.GetValueOrDefault("count:" + t) >= 2 || seconds - m.TopicTimes.GetValueOrDefault(t, -1000) < 140);`

**赋值（含属性/字段和局部值）：**

- `["asc"]` = `c.Ascension.ToString()`
- `["character"]` = `c.Character`
- `["event"]` = `c.Event`
- `["floor"]` = `c.Floor.ToString()`
- `["gold"]` = `c.Gold.ToString()`
- `["hp"]` = `c.Hp.ToString()`
- `["max"]` = `c.MaxHp.ToString()`
- `["name"]` = `c.Name`
- `["rival"]` = `c.Rival`
- `["turn"]` = `c.Turn.ToString()`
- `m.AtmosphereFloor` = `c.Floor`
- `m.NextAtmosphereAt` = `seconds + 58 + CareerEngine.StableHash(seed + c.Floor) % 34`
- `m.PhraseIndices["count:" + topic]` = `m.PhraseIndices.GetValueOrDefault("count:" + topic) + 1`

<a id="symbol-5475ccc1b529"></a>

## `NationalSpire.LiveCommentary.Rival(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, string, string, string, double) — public static BroadcastLine? Rival(LiveMatchState live, RivalProgress progress, string name, string rival, string seed, double seconds)`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopBroadcast.Tick()`](Coop/CoopBroadcast.cs.md#symbol-3be13ce2aa51)；[`NationalSpire.LiveRunBridge.UpdateRace()`](LiveRunBridge.cs.md#symbol-9566200347bc)

**调用：** [`NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`](LiveCommentary.cs.md#symbol-28e751a76070)；[`NationalSpire.MatchRules.Time(double?)`](MatchRules.cs.md#symbol-13ecc28f8403)；[`NationalSpire.RivalSimulation.RoomName(string)`](LiveMatch.cs.md#symbol-2c599e9f210a)；`int.ToString()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Math.Max(double, double)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastMemory.RivalAct`；`NationalSpire.BroadcastMemory.RivalInjuryFloor`；`NationalSpire.BroadcastMemory.RivalRecoveryFloor`；`NationalSpire.BroadcastMemory.TopicTimes`；`NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`；`NationalSpire.LiveMatchState.Commentary`；`NationalSpire.LiveMatchState.MaxHp`；`NationalSpire.LiveMatchState.Steps`；`NationalSpire.MatchRules.Time(double?)`；`NationalSpire.RivalProgress.Dead`；`NationalSpire.RivalProgress.Finished`；`NationalSpire.RivalProgress.Hp`；`NationalSpire.RivalProgress.Step`；`NationalSpire.RivalSimulation.RoomName(string)`；`NationalSpire.RivalStep.Act`；`NationalSpire.RivalStep.End`；`NationalSpire.RivalStep.Floor`；`NationalSpire.RivalStep.HpAfter`；`NationalSpire.RivalStep.HpBefore`；`NationalSpire.RivalStep.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.ToString()`；输入表达式：`(previous.HpAfter - previous.HpBefore).ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: facts["gain"] = (previous.HpAfter - previous.HpBefore).ToString()`
- `int.ToString()`；输入表达式：`(step.Act + 1).ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["act"] = (step.Act + 1).ToString()`
- `int.ToString()`；输入表达式：`live.MaxHp.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["max"] = live.MaxHp.ToString()`
- `int.ToString()`；输入表达式：`loss.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: facts["loss"] = loss.ToString()`
- `int.ToString()`；输入表达式：`previous.HpAfter.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: facts["hp"] = previous.HpAfter.ToString()`
- `int.ToString()`；输入表达式：`progress.Hp.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["hp"] = progress.Hp.ToString()`
- `int.ToString()`；输入表达式：`step.Floor.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["floor"] = step.Floor.ToString()`
- `NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`；输入表达式：`Speak(m, "rival_act", seconds, seed, facts)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Speak(m, "rival_act", seconds, seed, facts)`
- `NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`；输入表达式：`Speak(m, "rival_recover", seconds, seed, facts)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Speak(m, "rival_recover", seconds, seed, facts)`
- `NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`；输入表达式：`Speak(m, progress.Dead ? "rival_dead" : "rival_clear", seconds, seed, facts, true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Speak(m, progress.Dead ? "rival_dead" : "rival_clear", seconds, seed, facts, true)`
- `NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`；输入表达式：`Speak(m, progress.Hp <= live.MaxHp * .25 ? "rival_danger" : "rival_hurt", seconds, seed, facts)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Speak(m, progress.Hp <= live.MaxHp * .25 ? "rival_danger" : "rival_hurt", seconds, seed, facts)`
- `NationalSpire.MatchRules.Time(double?)`；输入表达式：`MatchRules.Time(live.Steps[^1].End)`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["time"] = MatchRules.Time(live.Steps[^1].End)`
- `NationalSpire.RivalSimulation.RoomName(string)`；输入表达式：`RivalSimulation.RoomName(step.Kind)`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["room"] = RivalSimulation.RoomName(step.Kind)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`m.TopicTimes.ContainsKey("rival_final")`；返回值紧邻使用处：`IfStatementSyntax: if (m.TopicTimes.ContainsKey("rival_final")) return null;`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, string> { ["name"] = name, ["rival"] = rival, ["floor"] = step.Floor.ToString(), ["act"] = (step.Act + 1).ToString(),              ["hp"] = progress.Hp.ToString(), ["max"] = live.MaxHp.ToString(), ["time"] = MatchRules.Time(live.Steps[^1].End), ["room"] = RivalSimulation.RoomName(step.Kind) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, string> { ["name"] = name, ["rival"] = rival, ["floor"] = step.Floor.ToString(), ["act"] = (step.Act + 1).ToString(),              ["hp"] = progress.Hp.ToString(), ["max"] = live.MaxHp.ToString(), ["time"] = MatchRules.Time(live.Steps[^1].End), ["room"] = RivalSimulation.RoomName(step.Kind) }`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`live.Steps.LastOrDefault(s => s.End <= seconds)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = live.Steps.LastOrDefault(s => s.End <= seconds)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`m.TopicTimes.GetValueOrDefault("rival_health", -1000)`；返回值紧邻使用处：`BinaryExpressionSyntax: seconds - m.TopicTimes.GetValueOrDefault("rival_health", -1000)`
- `System.Math.Max(double, double)`；输入表达式：`Math.Max(12, live.MaxHp * .2)`；返回值紧邻使用处：`BinaryExpressionSyntax: loss >= Math.Max(12, live.MaxHp * .2)`

**赋值（含属性/字段和局部值）：**

- `["act"]` = `(step.Act + 1).ToString()`
- `["floor"]` = `step.Floor.ToString()`
- `["hp"]` = `progress.Hp.ToString()`
- `["max"]` = `live.MaxHp.ToString()`
- `["name"]` = `name`
- `["rival"]` = `rival`
- `["room"]` = `RivalSimulation.RoomName(step.Kind)`
- `["time"]` = `MatchRules.Time(live.Steps[^1].End)`
- `facts["gain"]` = `(previous.HpAfter - previous.HpBefore).ToString()`
- `facts["hp"]` = `previous.HpAfter.ToString()`
- `facts["loss"]` = `loss.ToString()`
- `m.RivalAct` = `step.Act`
- `m.RivalInjuryFloor` = `step.Floor`
- `m.RivalRecoveryFloor` = `previous.Floor`
- `m.TopicTimes["rival_final"]` = `seconds`
- `m.TopicTimes["rival_health"]` = `seconds`
