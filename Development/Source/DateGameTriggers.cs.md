# DateGameTriggers.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`023C1A0707D5E994E2827C26AC81D8A0037802E2DFB62C2488B584F3E06C627B`。来源：[源码](../../DateGameTriggers.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DateGameObservation`、`NationalSpire.DateGameNpc`、`NationalSpire.DateGameCue`、`NationalSpire.DateGameFact`、`NationalSpire.DateGameTriggers`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-ad6c37e866d1"></a>

## `NationalSpire.DateGameTriggers.Remember(NationalSpire.DateGameState, NationalSpire.DateGameFact) — private static bool Remember(DateGameState state, DateGameFact fact)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameTriggers.Observe(NationalSpire.DateGameState, NationalSpire.DateGameObservation, System.Collections.Generic.IReadOnlyList<NationalSpire.DateGameNpc>)`](DateGameTriggers.cs.md#symbol-74a3c78bf5b0)

**调用：** `System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameFact.Act`；`NationalSpire.DateGameFact.Person`；`NationalSpire.DateGameFact.Trigger`；`NationalSpire.DateGameFact.Value`；`NationalSpire.DateGameState.Facts`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`state.Facts.Add(fact)`；返回值紧邻使用处：`ExpressionStatementSyntax: state.Facts.Add(fact);`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`state.Facts.FindIndex(f => f.Trigger == fact.Trigger && f.Act == fact.Act && f.Person == fact.Person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = state.Facts.FindIndex(f => f.Trigger == fact.Trigger && f.Act == fact.Act && f.Person == fact.Person)`

**赋值（含属性/字段和局部值）：**

- `state.Facts[index]` = `fact`

<a id="symbol-74a3c78bf5b0"></a>

## `NationalSpire.DateGameTriggers.Observe(NationalSpire.DateGameState, NationalSpire.DateGameObservation, System.Collections.Generic.IReadOnlyList<NationalSpire.DateGameNpc>) — public static bool Observe(DateGameState state, DateGameObservation player, IReadOnlyList<DateGameNpc> npcs)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.UpdateDateGame(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, double, ref bool)`](LiveDateGame.cs.md#symbol-cb87a418530f)

**调用：** `NationalSpire.DateGameFact.DateGameFact(string, int, int, double, string)`；[`NationalSpire.DateGameTriggers.Remember(NationalSpire.DateGameState, NationalSpire.DateGameFact)`](DateGameTriggers.cs.md#symbol-ad6c37e866d1)；`System.Math.Abs(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameNpc.MaxHp`；`NationalSpire.DateGameNpc.Person`；`NationalSpire.DateGameNpc.Progress`；`NationalSpire.DateGameObservation.Act`；`NationalSpire.DateGameObservation.Floor`；`NationalSpire.DateGameObservation.GoldSpent`；`NationalSpire.DateGameTriggers.Remember(NationalSpire.DateGameState, NationalSpire.DateGameFact)`；`NationalSpire.RivalProgress.Hp`；`NationalSpire.RivalProgress.Step`；`NationalSpire.RivalStep.Act`；`NationalSpire.RivalStep.Floor`；`NationalSpire.RivalStep.HpBefore`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameFact.DateGameFact(string, int, int, double, string)`；输入表达式：`new("floor-gap", player.Act, player.Floor, gap, npc.Person)`；返回值紧邻使用处：`ArgumentSyntax: new("floor-gap", player.Act, player.Floor, gap, npc.Person)`
- `NationalSpire.DateGameFact.DateGameFact(string, int, int, double, string)`；输入表达式：`new("gold-spent", player.Act, player.Floor, player.GoldSpent)`；返回值紧邻使用处：`ArgumentSyntax: new("gold-spent", player.Act, player.Floor, player.GoldSpent)`
- `NationalSpire.DateGameFact.DateGameFact(string, int, int, double, string)`；输入表达式：`new("npc-damage", npc.Progress.Step.Act, npc.Progress.Step.Floor, damage, npc.Person)`；返回值紧邻使用处：`ArgumentSyntax: new("npc-damage", npc.Progress.Step.Act, npc.Progress.Step.Floor, damage, npc.Person)`
- `NationalSpire.DateGameTriggers.Remember(NationalSpire.DateGameState, NationalSpire.DateGameFact)`；输入表达式：`Remember(state, new("floor-gap", player.Act, player.Floor, gap, npc.Person))`；返回值紧邻使用处：`AssignmentExpressionSyntax: changed |= Remember(state, new("floor-gap", player.Act, player.Floor, gap, npc.Person))`
- `NationalSpire.DateGameTriggers.Remember(NationalSpire.DateGameState, NationalSpire.DateGameFact)`；输入表达式：`Remember(state, new("gold-spent", player.Act, player.Floor, player.GoldSpent))`；返回值紧邻使用处：`BinaryExpressionSyntax: player.GoldSpent > 0 && Remember(state, new("gold-spent", player.Act, player.Floor, player.GoldSpent))`
- `NationalSpire.DateGameTriggers.Remember(NationalSpire.DateGameState, NationalSpire.DateGameFact)`；输入表达式：`Remember(state, new("npc-damage", npc.Progress.Step.Act, npc.Progress.Step.Floor, damage, npc.Person))`；返回值紧邻使用处：`AssignmentExpressionSyntax: changed |= Remember(state, new("npc-damage", npc.Progress.Step.Act, npc.Progress.Step.Floor, damage, npc.Person))`
- `System.Math.Abs(int)`；输入表达式：`Math.Abs(player.Floor - npc.Progress.Step.Floor)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Abs(player.Floor - npc.Progress.Step.Floor)`

**赋值（含属性/字段和局部值）：**

- `changed` |= `Remember(state, new("floor-gap", player.Act, player.Floor, gap, npc.Person))`
- `changed` |= `Remember(state, new("npc-damage", npc.Progress.Step.Act, npc.Progress.Step.Floor, damage, npc.Person))`

<a id="symbol-e51142d802f7"></a>

## `NationalSpire.DateGameTriggers.CombatWon(NationalSpire.DateGameState, string, int, int, double, double, bool) — public static bool CombatWon(DateGameState state, string kind, int act, int floor, double started, double ended, bool complete)`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.FinishCombat()`](LiveRunBridge.cs.md#symbol-1e798ae2b209)

**调用：** `NationalSpire.DateGameFact.DateGameFact(string, int, int, double, string)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`double.IsFinite(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameFact.Act`；`NationalSpire.DateGameFact.Floor`；`NationalSpire.DateGameFact.Trigger`；`NationalSpire.DateGameState.Facts`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameFact.DateGameFact(string, int, int, double, string)`；输入表达式：`new(trigger, act, floor, ended - started)`；返回值紧邻使用处：`ArgumentSyntax: new(trigger, act, floor, ended - started)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`state.Facts.Any(f => f.Trigger == trigger && f.Act == act && f.Floor == floor)`；返回值紧邻使用处：`IfStatementSyntax: if (state.Facts.Any(f => f.Trigger == trigger && f.Act == act && f.Floor == floor)) return false;`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`state.Facts.Add(new(trigger, act, floor, ended - started))`；返回值紧邻使用处：`ExpressionStatementSyntax: state.Facts.Add(new(trigger, act, floor, ended - started));`
- `double.IsFinite(double)`；输入表达式：`double.IsFinite(ended)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !double.IsFinite(ended)`
- `double.IsFinite(double)`；输入表达式：`double.IsFinite(started)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !double.IsFinite(started)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-502aaf3f8bdb"></a>

## `NationalSpire.DateGameTriggers.PerAct(string) — private static bool PerAct(string trigger)`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameTriggers.Next(NationalSpire.DateGameState, System.Collections.Generic.IReadOnlyList<NationalSpire.DateGameRule>, NationalSpire.DateGameObservation, System.Collections.Generic.IReadOnlyList<NationalSpire.DateGameNpc>, int, NationalSpire.DateGameTiming?)`](DateGameTriggers.cs.md#symbol-7f66f37eeebc)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7f66f37eeebc"></a>

## `NationalSpire.DateGameTriggers.Next(NationalSpire.DateGameState, System.Collections.Generic.IReadOnlyList<NationalSpire.DateGameRule>, NationalSpire.DateGameObservation, System.Collections.Generic.IReadOnlyList<NationalSpire.DateGameNpc>, int, NationalSpire.DateGameTiming?) — public static DateGameCue? Next(DateGameState state, IReadOnlyList<DateGameRule> rules, DateGameObservation player, IReadOnlyList<DateGameNpc> npcs, int choice, DateGameTiming? timing = null)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.UpdateDateGame(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, double, ref bool)`](LiveDateGame.cs.md#symbol-cb87a418530f)

**调用：** `NationalSpire.DateGameCue.DateGameCue(string, string, string, bool, string)`；`NationalSpire.DateGameTiming.DateGameTiming()`；[`NationalSpire.DateGameTriggers.LabelFact(NationalSpire.DateGameFact)`](DateGameTriggers.cs.md#symbol-09def76dbb03)；[`NationalSpire.DateGameTriggers.PerAct(string)`](DateGameTriggers.cs.md#symbol-502aaf3f8bdb)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Math.Max(double, double)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameFact.Act`；`NationalSpire.DateGameFact.Floor`；`NationalSpire.DateGameFact.Person`；`NationalSpire.DateGameFact.Trigger`；`NationalSpire.DateGameFact.Value`；`NationalSpire.DateGameNpc.Person`；`NationalSpire.DateGameNpc.Progress`；`NationalSpire.DateGameObservation.Act`；`NationalSpire.DateGameObservation.Floor`；`NationalSpire.DateGameObservation.Hp`；`NationalSpire.DateGameObservation.MaxHp`；`NationalSpire.DateGameObservation.Seconds`；`NationalSpire.DateGameRule.Chat`；`NationalSpire.DateGameRule.Enabled`；`NationalSpire.DateGameRule.Lines`；`NationalSpire.DateGameRule.Threshold`；`NationalSpire.DateGameRule.Trigger`；`NationalSpire.DateGameState.Facts`；`NationalSpire.DateGameState.Fired`；`NationalSpire.DateGameState.LastChat`；`NationalSpire.DateGameState.LastSpeech`；`NationalSpire.DateGameState.PendingChat`；`NationalSpire.DateGameTiming.ChatSeconds`；`NationalSpire.DateGameTiming.FastMinimumFloor`；`NationalSpire.DateGameTiming.SpeechSeconds`；`NationalSpire.DateGameTriggers.LabelFact(NationalSpire.DateGameFact)`；`NationalSpire.DateGameTriggers.PerAct(string)`；`NationalSpire.DateGames.ChatRequestInterval`；`NationalSpire.RivalProgress.Dead`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGameCue.DateGameCue(string, string, string, bool, string)`；输入表达式：`new(speaker.Person, factKey, rule.Lines[(choice & int.MaxValue) % rule.Lines.Count], rule.Chat, context)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(speaker.Person, factKey, rule.Lines[(choice & int.MaxValue) % rule.Lines.Count], rule.Chat, context);`
- `NationalSpire.DateGameCue.DateGameCue(string, string, string, bool, string)`；输入表达式：`new(speaker.Person, key, rule.Lines[(choice & int.MaxValue) % rule.Lines.Count], rule.Chat)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(speaker.Person, key, rule.Lines[(choice & int.MaxValue) % rule.Lines.Count], rule.Chat);`
- `NationalSpire.DateGameTiming.DateGameTiming()`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: timing ??= new()`
- `NationalSpire.DateGameTriggers.LabelFact(NationalSpire.DateGameFact)`；输入表达式：`LabelFact(fact)`；返回值紧邻使用处：`InterpolationSyntax: {LabelFact(fact)}`
- `NationalSpire.DateGameTriggers.PerAct(string)`；输入表达式：`PerAct(rule.Trigger)`；返回值紧邻使用处：`BinaryExpressionSyntax: PerAct(rule.Trigger) || rule.Trigger == "floor-gap"`
- `NationalSpire.DateGameTriggers.PerAct(string)`；输入表达式：`PerAct(rule.Trigger)`；返回值紧邻使用处：`ConditionalExpressionSyntax: PerAct(rule.Trigger) ? "/act/" + fact.Act : ""`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`state.Fired.Contains(factKey)`；返回值紧邻使用处：`IfStatementSyntax: if (state.Fired.Contains(factKey)) continue;`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`state.Fired.Contains(key)`；返回值紧邻使用处：`IfStatementSyntax: if (state.Fired.Contains(key)) continue;`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`npcs.FirstOrDefault(n => n.Person == fact.Person)`；返回值紧邻使用处：`BinaryExpressionSyntax: npcs.FirstOrDefault(n => n.Person == fact.Person) ?? npcs[(choice & int.MaxValue) % npcs.Count]`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`rules.Where(r => r.Enabled && r.Lines.Count > 0)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var rule in rules.Where(r => r.Enabled && r.Lines.Count > 0)) { if (rule.Chat && (state.PendingChat.Length > 0 || player.Seconds - state.LastChat < Math.Max(DateGames.ChatRequestInterval, timing.ChatSeconds))) continue; if (PerAct(rule.Trigger) || rule.Trigger == "floor-gap") { foreach (var fact in state.Facts.Where(f => f.Trigger == rule.Trigger && (rule.Trigger is "elite-fast" or "boss-fast" ? f.Value < rule.Threshold : f.Value >= rule.Threshold))) { string factKey = rule.Trigger + (PerAct(rule.Trigger) ? "/act/" + fact.Act : ""); if (state.Fired.Contains(factKey)) continue; var speaker = npcs.FirstOrDefault(n => n.Person == fact.Person) ?? npcs[(choice & int.MaxValue) % npcs.Count]; string context = $"触发事实：第{fact.Act + 1}幕，第{fact.Floor}层；{LabelFact(fact)}。"; return new(speaker.Person, factKey, rule.Lines[(choice & int.MaxValue) % rule.Lines.Count], rule.Chat, context); } continue; } foreach (var npc in npcs) { var progress = npc.Progress; bool match = rule.Trigger switch { "fast" => player.Floor >= Math.Max(20, timing.FastMinimumFloor) && player.Seconds / player.Floor <= rule.Threshold, "act1" => player.Act >= 1, "act2" => player.Act >= 2, "npc-death" => progress.Dead, "player-danger" => player.MaxHp > 0 && 100.0 * player.Hp / player.MaxHp <= rule.Threshold, _ => false }; if (!match) continue; bool perNpc = rule.Trigger == "npc-death"; string key = rule.Trigger + (perNpc ? "/" + npc.Person : ""); if (state.Fired.Contains(key)) continue; var speaker = perNpc ? npc : npcs[(choice & int.MaxValue) % npcs.Count]; return new(speaker.Person, key, rule.Lines[(choice & int.MaxValue) % rule.Lines.Count], rule.Chat); } }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`state.Facts.Where(f => f.Trigger == rule.Trigger && (rule.Trigger is "elite-fast" or "boss-fast" ? f.Value < rule.Threshold : f.Value >= rule.Threshold))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var fact in state.Facts.Where(f => f.Trigger == rule.Trigger && (rule.Trigger is "elite-fast" or "boss-fast" ? f.Value < rule.Threshold : f.Value >= rule.Threshold))) { string factKey = rule.Trigger + (PerAct(rule.Trigger) ? "/act/" + fact.Act : ""); if (state.Fired.Contains(factKey)) continue; var speaker = npcs.FirstOrDefault(n => n.Person == fact.Person) ?? npcs[(choice & int.MaxValue) % npcs.Count]; string context = $"触发事实：第{fact.Act + 1}幕，第{fact.Floor}层；{LabelFact(fact)}。"; return new(speaker.Person, factKey, rule.Lines[(choice & int.MaxValue) % rule.Lines.Count], rule.Chat, context); }`
- `System.Math.Max(double, double)`；输入表达式：`Math.Max(DateGames.ChatRequestInterval, timing.ChatSeconds)`；返回值紧邻使用处：`BinaryExpressionSyntax: player.Seconds - state.LastChat < Math.Max(DateGames.ChatRequestInterval, timing.ChatSeconds)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(20, timing.FastMinimumFloor)`；返回值紧邻使用处：`BinaryExpressionSyntax: player.Floor >= Math.Max(20, timing.FastMinimumFloor)`

**赋值（含属性/字段和局部值）：**

- `timing` ??= `new()`

<a id="symbol-09def76dbb03"></a>

## `NationalSpire.DateGameTriggers.LabelFact(NationalSpire.DateGameFact) — private static string LabelFact(DateGameFact fact)`

来源：源码第 81 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateGameTriggers.Next(NationalSpire.DateGameState, System.Collections.Generic.IReadOnlyList<NationalSpire.DateGameRule>, NationalSpire.DateGameObservation, System.Collections.Generic.IReadOnlyList<NationalSpire.DateGameNpc>, int, NationalSpire.DateGameTiming?)`](DateGameTriggers.cs.md#symbol-7f66f37eeebc)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameFact.Trigger`；`NationalSpire.DateGameFact.Value`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5883a6a9a040"></a>

## `NationalSpire.DateGameTriggers.Record(NationalSpire.DateGameState, NationalSpire.DateGameCue, double) — public static void Record(DateGameState state, DateGameCue cue, double seconds)`

来源：源码第 89 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.UpdateDateGame(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, double, ref bool)`](LiveDateGame.cs.md#symbol-cb87a418530f)

**调用：** `System.Collections.Generic.HashSet<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateGameCue.Chat`；`NationalSpire.DateGameCue.Key`；`NationalSpire.DateGameCue.Text`；`NationalSpire.DateGameState.Fired`；`NationalSpire.DateGameState.LastChat`；`NationalSpire.DateGameState.LastSpeech`；`NationalSpire.DateGameState.PendingChat`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`state.Fired.Add(cue.Key)`；返回值紧邻使用处：`ExpressionStatementSyntax: state.Fired.Add(cue.Key);`

**赋值（含属性/字段和局部值）：**

- `state.LastChat` = `seconds`
- `state.LastSpeech` = `seconds`
- `state.PendingChat` = `cue.Text`
