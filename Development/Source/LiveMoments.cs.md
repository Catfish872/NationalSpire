# LiveMoments.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`F2FB81CEF770AD879A7214D4EA76B31D4AC8B04D7A47939BEF4FD91933A9BA19`。来源：[源码](../../LiveMoments.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LiveCommentary`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly Dictionary<string, string[]> MomentBanks = [];
private static readonly Dictionary<string, string[]> MomentTails = [];
```

<a id="symbol-aececc8f0381"></a>

## `NationalSpire.LiveCommentary.IsCombatLoss(int, int, int, string) — public static bool IsCombatLoss(int before, int after, int max, string room)`

来源：源码第 5 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.HpChanged(int, int)`](LiveRunBridge.cs.md#symbol-f716e330add4)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d358a4a6cc39"></a>

## `NationalSpire.LiveCommentary.MomentTail(NationalSpire.BroadcastMemory, string, string, int) — private static string MomentTail(BroadcastMemory m, string key, string seed, int occurrence)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveCommentary.DiscardPotion(NationalSpire.BroadcastMemory, string, int, int, int, string, string, double)`](LiveMoments.cs.md#symbol-27c5783971c3)；[`NationalSpire.LiveCommentary.PlayerLoss(NationalSpire.BroadcastMemory, int, int, int, int, string, string, double)`](LiveMoments.cs.md#symbol-931725c8305b)；[`NationalSpire.LiveCommentary.PlayerVictory(NationalSpire.BroadcastMemory, bool, double, int, int, string, string, string)`](LiveMoments.cs.md#symbol-44f4d20ad966)；[`NationalSpire.LiveCommentary.Potion(NationalSpire.BroadcastMemory, string, int, int, string, string, double)`](LiveMoments.cs.md#symbol-4eaf89b958c5)；[`NationalSpire.LiveCommentary.SkipReward(NationalSpire.BroadcastMemory, int, int, int, string, string, double)`](LiveMoments.cs.md#symbol-fa1a12d0a085)；[`NationalSpire.LiveCommentary.UnknownRoom(NationalSpire.BroadcastMemory, int, string, int, int, int, string, string, double)`](LiveMoments.cs.md#symbol-64cfa3e4c0ca)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.LiveCommentary.DetailFamily(string)`](CommentaryFocus.cs.md#symbol-8a2891030435)；[`NationalSpire.LiveCommentary.FocusHistory(NationalSpire.BroadcastMemory, string)`](CommentaryFocus.cs.md#symbol-63c4d695beeb)；[`NationalSpire.LiveCommentary.SelectPhrase(NationalSpire.BroadcastMemory, string, string[], string, int)`](LiveCommentary.cs.md#symbol-f557c590d222)；`string.StartsWith(string, System.StringComparison)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.LiveCommentary.DetailFamily(string)`；`NationalSpire.LiveCommentary.FocusHistory(NationalSpire.BroadcastMemory, string)`；`NationalSpire.LiveCommentary.MomentTails`；`NationalSpire.LiveCommentary.SelectPhrase(NationalSpire.BroadcastMemory, string, string[], string, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(seed + ":detail:" + key + occurrence)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.StableHash(seed + ":detail:" + key + occurrence) % (3 + repeats * 2)`
- `NationalSpire.LiveCommentary.DetailFamily(string)`；输入表达式：`DetailFamily(key)`；返回值紧邻使用处：`BinaryExpressionSyntax: t == DetailFamily(key)`
- `NationalSpire.LiveCommentary.FocusHistory(NationalSpire.BroadcastMemory, string)`；输入表达式：`FocusHistory(m, "details")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: FocusHistory(m, "details").TakeLast`
- `NationalSpire.LiveCommentary.SelectPhrase(NationalSpire.BroadcastMemory, string, string[], string, int)`；输入表达式：`SelectPhrase(m, "moment:" + key, bank, seed, occurrence)`；返回值紧邻使用处：`ReturnStatementSyntax: return SelectPhrase(m, "moment:" + key, bank, seed, occurrence);`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`key.StartsWith("victory_", StringComparison.Ordinal)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !key.StartsWith("victory_", StringComparison.Ordinal)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`FocusHistory(m, "details").TakeLast(10).Count(t => t == DetailFamily(key))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = FocusHistory(m, "details").TakeLast(10).Count(t => t == DetailFamily(key))`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`FocusHistory(m, "details").TakeLast(10)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: FocusHistory(m, "details").TakeLast(10).Count`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4eaf89b958c5"></a>

## `NationalSpire.LiveCommentary.Potion(NationalSpire.BroadcastMemory, string, int, int, string, string, double) — public static BroadcastLine? Potion(BroadcastMemory m, string potion, int hp, int max, string name, string seed, double seconds)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.ObservePotions(NationalSpire.BroadcastMemory, double)`](LiveRunBridge.cs.md#symbol-e509c91bb4f4)

**调用：** [`NationalSpire.LiveCommentary.MomentFacts(string, int, int)`](LiveMoments.cs.md#symbol-a7429ac6e843)；[`NationalSpire.LiveCommentary.MomentTail(NationalSpire.BroadcastMemory, string, string, int)`](LiveMoments.cs.md#symbol-d358a4a6cc39)；[`NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`](LiveCommentary.cs.md#symbol-28e751a76070)；`int.ToString()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastMemory.PhraseIndices`；`NationalSpire.BroadcastMemory.TopicTimes`；`NationalSpire.LiveCommentary.MomentFacts(string, int, int)`；`NationalSpire.LiveCommentary.MomentTail(NationalSpire.BroadcastMemory, string, string, int)`；`NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.ToString()`；输入表达式：`burst.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: facts["burst"] = burst.ToString()`
- `NationalSpire.LiveCommentary.MomentFacts(string, int, int)`；输入表达式：`MomentFacts(name, hp, max)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MomentFacts(name, hp, max)`
- `NationalSpire.LiveCommentary.MomentTail(NationalSpire.BroadcastMemory, string, string, int)`；输入表达式：`MomentTail(m, hp <= max * .3 ? "potion_low" : count > 1 ? "potion_repeat" : "potion_first", seed, count)`；返回值紧邻使用处：`AssignmentExpressionSyntax: facts["tail"] = MomentTail(m, hp <= max * .3 ? "potion_low" : count > 1 ? "potion_repeat" : "potion_first", seed, count)`
- `NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`；输入表达式：`Speak(m, burst >= 2 ? "potion_burst" : "potion", seconds, seed, facts, true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Speak(m, burst >= 2 ? "potion_burst" : "potion", seconds, seed, facts, true)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`m.TopicTimes.GetValueOrDefault("potion_observed", -1000)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = m.TopicTimes.GetValueOrDefault("potion_observed", -1000)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`m.TopicTimes.GetValueOrDefault("potion", -1000)`；返回值紧邻使用处：`BinaryExpressionSyntax: seconds - m.TopicTimes.GetValueOrDefault("potion", -1000)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`m.PhraseIndices.GetValueOrDefault("potion_burst_count")`；返回值紧邻使用处：`BinaryExpressionSyntax: m.PhraseIndices.GetValueOrDefault("potion_burst_count") + 1`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`m.PhraseIndices.GetValueOrDefault("potions_used")`；返回值紧邻使用处：`BinaryExpressionSyntax: m.PhraseIndices.GetValueOrDefault("potions_used") + 1`

**赋值（含属性/字段和局部值）：**

- `facts["burst"]` = `burst.ToString()`
- `facts["potion"]` = `potion`
- `facts["tail"]` = `MomentTail(m, hp <= max * .3 ? "potion_low" : count > 1 ? "potion_repeat" : "potion_first", seed, count)`
- `m.PhraseIndices["potion_burst_count"]` = `burst`
- `m.PhraseIndices["potions_used"]` = `count`
- `m.TopicTimes["potion_observed"]` = `seconds`
- `m.TopicTimes["potion"]` = `seconds`

<a id="symbol-27c5783971c3"></a>

## `NationalSpire.LiveCommentary.DiscardPotion(NationalSpire.BroadcastMemory, string, int, int, int, string, string, double) — public static BroadcastLine? DiscardPotion(BroadcastMemory m, string potion, int hp, int max, int left, string name, string seed, double seconds)`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.ObservePotions(NationalSpire.BroadcastMemory, double)`](LiveRunBridge.cs.md#symbol-e509c91bb4f4)

**调用：** [`NationalSpire.LiveCommentary.MomentFacts(string, int, int)`](LiveMoments.cs.md#symbol-a7429ac6e843)；[`NationalSpire.LiveCommentary.MomentTail(NationalSpire.BroadcastMemory, string, string, int)`](LiveMoments.cs.md#symbol-d358a4a6cc39)；[`NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`](LiveCommentary.cs.md#symbol-28e751a76070)；`int.ToString()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastMemory.PhraseIndices`；`NationalSpire.BroadcastMemory.TopicTimes`；`NationalSpire.LiveCommentary.MomentFacts(string, int, int)`；`NationalSpire.LiveCommentary.MomentTail(NationalSpire.BroadcastMemory, string, string, int)`；`NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.ToString()`；输入表达式：`left.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: facts["left"] = left.ToString()`
- `NationalSpire.LiveCommentary.MomentFacts(string, int, int)`；输入表达式：`MomentFacts(name, hp, max)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MomentFacts(name, hp, max)`
- `NationalSpire.LiveCommentary.MomentTail(NationalSpire.BroadcastMemory, string, string, int)`；输入表达式：`MomentTail(m, hp <= max * .3 ? "discard_low" : "discard_normal", seed, count)`；返回值紧邻使用处：`AssignmentExpressionSyntax: facts["tail"] = MomentTail(m, hp <= max * .3 ? "discard_low" : "discard_normal", seed, count)`
- `NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`；输入表达式：`Speak(m, count > 2 ? "discard_repeat" : "discard_potion", seconds, seed, facts, true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Speak(m, count > 2 ? "discard_repeat" : "discard_potion", seconds, seed, facts, true)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`m.TopicTimes.GetValueOrDefault("discard_potion_group", -1000)`；返回值紧邻使用处：`BinaryExpressionSyntax: seconds - m.TopicTimes.GetValueOrDefault("discard_potion_group", -1000)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`m.PhraseIndices.GetValueOrDefault("potions_discarded")`；返回值紧邻使用处：`BinaryExpressionSyntax: m.PhraseIndices.GetValueOrDefault("potions_discarded") + 1`

**赋值（含属性/字段和局部值）：**

- `facts["left"]` = `left.ToString()`
- `facts["potion"]` = `potion`
- `facts["tail"]` = `MomentTail(m, hp <= max * .3 ? "discard_low" : "discard_normal", seed, count)`
- `m.PhraseIndices["potions_discarded"]` = `count`
- `m.TopicTimes["discard_potion_group"]` = `seconds`

<a id="symbol-2a9d8e18ab22"></a>

## `NationalSpire.LiveCommentary.Energy(NationalSpire.BroadcastMemory, int, int, int, int, string, string, double) — public static BroadcastLine? Energy(BroadcastMemory m, int floor, int turn, int gain, int current, string name, string seed, double seconds)`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.EnergyGained(MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState, int)`](LiveRunBridge.cs.md#symbol-1d29bfc1f633)

**调用：** [`NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`](LiveCommentary.cs.md#symbol-28e751a76070)；`int.ToString()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastMemory.PhraseIndices`；`NationalSpire.BroadcastMemory.TopicTimes`；`NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.ToString()`；输入表达式：`current.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["energy"] = current.ToString()`
- `int.ToString()`；输入表达式：`total.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["gain"] = total.ToString()`
- `NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`；输入表达式：`Speak(m, count > 0 ? "energy_repeat" : "energy", seconds, seed,              new() { ["name"] = name, ["gain"] = total.ToString(), ["energy"] = current.ToString() }, true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Speak(m, count > 0 ? "energy_repeat" : "energy", seconds, seed,              new() { ["name"] = name, ["gain"] = total.ToString(), ["energy"] = current.ToString() }, true)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`m.TopicTimes.ContainsKey(key)`；返回值紧邻使用处：`BinaryExpressionSyntax: total < 5 || m.TopicTimes.ContainsKey(key)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new() { ["name"] = name, ["gain"] = total.ToString(), ["energy"] = current.ToString() }`；返回值紧邻使用处：`ArgumentSyntax: new() { ["name"] = name, ["gain"] = total.ToString(), ["energy"] = current.ToString() }`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`m.TopicTimes.GetValueOrDefault("energy_group", -1000)`；返回值紧邻使用处：`BinaryExpressionSyntax: seconds - m.TopicTimes.GetValueOrDefault("energy_group", -1000)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`m.PhraseIndices.GetValueOrDefault("energy_count")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = m.PhraseIndices.GetValueOrDefault("energy_count")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`m.PhraseIndices.GetValueOrDefault(key)`；返回值紧邻使用处：`BinaryExpressionSyntax: m.PhraseIndices.GetValueOrDefault(key) + gain`

**赋值（含属性/字段和局部值）：**

- `["energy"]` = `current.ToString()`
- `["gain"]` = `total.ToString()`
- `["name"]` = `name`
- `m.PhraseIndices["energy_count"]` = `count + 1`
- `m.PhraseIndices[key]` = `total`
- `m.TopicTimes["energy_group"]` = `seconds`
- `m.TopicTimes[key]` = `seconds`

<a id="symbol-fa1a12d0a085"></a>

## `NationalSpire.LiveCommentary.SkipReward(NationalSpire.BroadcastMemory, int, int, int, string, string, double) — public static BroadcastLine? SkipReward(BroadcastMemory m, int floor, int options, int deck, string name, string seed, double seconds)`

来源：源码第 57 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.RewardSkipped(MegaCrit.Sts2.Core.Rewards.CardReward)`](LiveRunBridge.cs.md#symbol-c012e2474371)

**调用：** [`NationalSpire.LiveCommentary.MomentTail(NationalSpire.BroadcastMemory, string, string, int)`](LiveMoments.cs.md#symbol-d358a4a6cc39)；[`NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`](LiveCommentary.cs.md#symbol-28e751a76070)；`int.ToString()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastMemory.CleanStreak`；`NationalSpire.BroadcastMemory.PhraseIndices`；`NationalSpire.BroadcastMemory.TopicTimes`；`NationalSpire.LiveCommentary.MomentTail(NationalSpire.BroadcastMemory, string, string, int)`；`NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.ToString()`；输入表达式：`count.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["count"] = count.ToString()`
- `int.ToString()`；输入表达式：`deck.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["deck"] = deck.ToString()`
- `int.ToString()`；输入表达式：`m.CleanStreak.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["streak"] = m.CleanStreak.ToString()`
- `int.ToString()`；输入表达式：`options.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["options"] = options.ToString()`
- `NationalSpire.LiveCommentary.MomentTail(NationalSpire.BroadcastMemory, string, string, int)`；输入表达式：`MomentTail(m, m.CleanStreak >= 3 ? "skip_clean" : "skip_normal", seed, count)`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["tail"] = MomentTail(m, m.CleanStreak >= 3 ? "skip_clean" : "skip_normal", seed, count)`
- `NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`；输入表达式：`Speak(m, count > 1 ? "skip_repeat" : "skip_reward", seconds, seed, facts, true)`；返回值紧邻使用处：`ReturnStatementSyntax: return Speak(m, count > 1 ? "skip_repeat" : "skip_reward", seconds, seed, facts, true);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`m.TopicTimes.ContainsKey(key)`；返回值紧邻使用处：`BinaryExpressionSyntax: options < 1 || m.TopicTimes.ContainsKey(key)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, string> { ["name"] = name, ["options"] = options.ToString(), ["deck"] = deck.ToString(),              ["count"] = count.ToString(), ["streak"] = m.CleanStreak.ToString(), ["tail"] = MomentTail(m, m.CleanStreak >= 3 ? "skip_clean" : "skip_normal", seed, count) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, string> { ["name"] = name, ["options"] = options.ToString(), ["deck"] = deck.ToString(),              ["count"] = count.ToString(), ["streak"] = m.CleanStreak.ToString(), ["tail"] = MomentTail(m, m.CleanStreak >= 3 ? "skip_clean" : "skip_normal", seed, count) }`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`m.PhraseIndices.GetValueOrDefault("skipped_count")`；返回值紧邻使用处：`BinaryExpressionSyntax: m.PhraseIndices.GetValueOrDefault("skipped_count") + 1`

**赋值（含属性/字段和局部值）：**

- `["count"]` = `count.ToString()`
- `["deck"]` = `deck.ToString()`
- `["name"]` = `name`
- `["options"]` = `options.ToString()`
- `["streak"]` = `m.CleanStreak.ToString()`
- `["tail"]` = `MomentTail(m, m.CleanStreak >= 3 ? "skip_clean" : "skip_normal", seed, count)`
- `m.PhraseIndices["skipped_count"]` = `count`
- `m.TopicTimes[key]` = `seconds`

<a id="symbol-44f4d20ad966"></a>

## `NationalSpire.LiveCommentary.PlayerVictory(NationalSpire.BroadcastMemory, bool, double, int, int, string, string, string) — public static BroadcastLine? PlayerVictory(BroadcastMemory m, bool winner, double seconds, int hp, int max, string name, string rival, string seed)`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.RunEnded(bool)`](LiveRunBridge.cs.md#symbol-d5b5bb6d87cd)

**调用：** [`NationalSpire.LiveCommentary.ChooseFocus(NationalSpire.BroadcastMemory, string, System.Collections.Generic.IEnumerable<string>, string, System.Func<string, string>)`](CommentaryFocus.cs.md#symbol-780e8bcd69dc)；[`NationalSpire.LiveCommentary.DetailFamily(string)`](CommentaryFocus.cs.md#symbol-8a2891030435)；[`NationalSpire.LiveCommentary.MomentFacts(string, int, int)`](LiveMoments.cs.md#symbol-a7429ac6e843)；[`NationalSpire.LiveCommentary.MomentTail(NationalSpire.BroadcastMemory, string, string, int)`](LiveMoments.cs.md#symbol-d358a4a6cc39)；[`NationalSpire.LiveCommentary.RememberFocus(NationalSpire.BroadcastMemory, string, string)`](CommentaryFocus.cs.md#symbol-8c5e2b08bbdb)；[`NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`](LiveCommentary.cs.md#symbol-28e751a76070)；[`NationalSpire.MatchRules.Time(double?)`](MatchRules.cs.md#symbol-13ecc28f8403)；`int.ToString()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastMemory.BestCards`；`NationalSpire.BroadcastMemory.BestCleanStreak`；`NationalSpire.BroadcastMemory.BestDamage`；`NationalSpire.BroadcastMemory.CleanStreak`；`NationalSpire.BroadcastMemory.EliteVisits`；`NationalSpire.BroadcastMemory.TopicTimes`；`NationalSpire.LiveCommentary.ChooseFocus(NationalSpire.BroadcastMemory, string, System.Collections.Generic.IEnumerable<string>, string, System.Func<string, string>)`；`NationalSpire.LiveCommentary.DetailFamily(string)`；`NationalSpire.LiveCommentary.MomentFacts(string, int, int)`；`NationalSpire.LiveCommentary.MomentTail(NationalSpire.BroadcastMemory, string, string, int)`；`NationalSpire.LiveCommentary.RememberFocus(NationalSpire.BroadcastMemory, string, string)`；`NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`；`NationalSpire.MatchRules.Time(double?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.ToString()`；输入表达式：`m.BestCards.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: facts["bestCards"] = m.BestCards.ToString()`
- `int.ToString()`；输入表达式：`m.BestDamage.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: facts["bestDamage"] = m.BestDamage.ToString()`
- `int.ToString()`；输入表达式：`m.EliteVisits.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: facts["elites"] = m.EliteVisits.ToString()`
- `int.ToString()`；输入表达式：`Math.Max(m.BestCleanStreak, m.CleanStreak).ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: facts["bestClean"] = Math.Max(m.BestCleanStreak, m.CleanStreak).ToString()`
- `NationalSpire.LiveCommentary.ChooseFocus(NationalSpire.BroadcastMemory, string, System.Collections.Generic.IEnumerable<string>, string, System.Func<string, string>)`；输入表达式：`ChooseFocus(m, "victory", angles, seed, DetailFamily)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: ChooseFocus(m, "victory", angles, seed, DetailFamily)!`
- `NationalSpire.LiveCommentary.DetailFamily(string)`；输入表达式：`DetailFamily(focus)`；返回值紧邻使用处：`ArgumentSyntax: DetailFamily(focus)`
- `NationalSpire.LiveCommentary.MomentFacts(string, int, int)`；输入表达式：`MomentFacts(name, hp, max)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MomentFacts(name, hp, max)`
- `NationalSpire.LiveCommentary.MomentTail(NationalSpire.BroadcastMemory, string, string, int)`；输入表达式：`MomentTail(m, focus, seed, 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: facts["tail"] = MomentTail(m, focus, seed, 0)`
- `NationalSpire.LiveCommentary.RememberFocus(NationalSpire.BroadcastMemory, string, string)`；输入表达式：`RememberFocus(m, "victory", DetailFamily(focus))`；返回值紧邻使用处：`ExpressionStatementSyntax: RememberFocus(m, "victory", DetailFamily(focus));`
- `NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`；输入表达式：`Speak(m, winner ? "player_champion" : "player_finished", seconds, seed, facts, true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Speak(m, winner ? "player_champion" : "player_finished", seconds, seed, facts, true)`
- `NationalSpire.MatchRules.Time(double?)`；输入表达式：`MatchRules.Time(seconds)`；返回值紧邻使用处：`AssignmentExpressionSyntax: facts["time"] = MatchRules.Time(seconds)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`m.TopicTimes.ContainsKey("player_final")`；返回值紧邻使用处：`IfStatementSyntax: if (m.TopicTimes.ContainsKey("player_final")) return null;`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`angles.Add("victory_cards")`；返回值紧邻使用处：`ExpressionStatementSyntax: angles.Add("victory_cards");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`angles.Add("victory_clean_run")`；返回值紧邻使用处：`ExpressionStatementSyntax: angles.Add("victory_clean_run");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`angles.Add("victory_damage")`；返回值紧邻使用处：`ExpressionStatementSyntax: angles.Add("victory_damage");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`angles.Add("victory_route")`；返回值紧邻使用处：`ExpressionStatementSyntax: angles.Add("victory_route");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`angles.Add(hp <= max * .25 ? "victory_low" : hp >= max * .8 ? "victory_healthy" : "victory_normal")`；返回值紧邻使用处：`ExpressionStatementSyntax: angles.Add(hp <= max * .25 ? "victory_low" : hp >= max * .8 ? "victory_healthy" : "victory_normal");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`angles.Add(seconds <= 2100 ? "victory_sprint" : "victory_fast")`；返回值紧邻使用处：`ExpressionStatementSyntax: angles.Add(seconds <= 2100 ? "victory_sprint" : "victory_fast");`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string> { "victory_closing" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string> { "victory_closing" }`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(m.BestCleanStreak, m.CleanStreak)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(m.BestCleanStreak, m.CleanStreak) >= 3`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(m.BestCleanStreak, m.CleanStreak)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Math.Max(m.BestCleanStreak, m.CleanStreak).ToString`

**赋值（含属性/字段和局部值）：**

- `facts["bestCards"]` = `m.BestCards.ToString()`
- `facts["bestClean"]` = `Math.Max(m.BestCleanStreak, m.CleanStreak).ToString()`
- `facts["bestDamage"]` = `m.BestDamage.ToString()`
- `facts["elites"]` = `m.EliteVisits.ToString()`
- `facts["rival"]` = `rival`
- `facts["tail"]` = `MomentTail(m, focus, seed, 0)`
- `facts["time"]` = `MatchRules.Time(seconds)`
- `m.TopicTimes["player_final"]` = `seconds`

<a id="symbol-931725c8305b"></a>

## `NationalSpire.LiveCommentary.PlayerLoss(NationalSpire.BroadcastMemory, int, int, int, int, string, string, double) — public static BroadcastLine? PlayerLoss(BroadcastMemory m, int floor, int loss, int hp, int max, string name, string seed, double seconds)`

来源：源码第 87 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.UpdateRace()`](LiveRunBridge.cs.md#symbol-9566200347bc)

**调用：** [`NationalSpire.LiveCommentary.MomentFacts(string, int, int)`](LiveMoments.cs.md#symbol-a7429ac6e843)；[`NationalSpire.LiveCommentary.MomentTail(NationalSpire.BroadcastMemory, string, string, int)`](LiveMoments.cs.md#symbol-d358a4a6cc39)；[`NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`](LiveCommentary.cs.md#symbol-28e751a76070)；`int.ToString()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Math.Max(double, double)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastMemory.CleanStreak`；`NationalSpire.BroadcastMemory.PhraseIndices`；`NationalSpire.BroadcastMemory.TopicTimes`；`NationalSpire.LiveCommentary.MomentFacts(string, int, int)`；`NationalSpire.LiveCommentary.MomentTail(NationalSpire.BroadcastMemory, string, string, int)`；`NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.ToString()`；输入表达式：`loss.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: facts["loss"] = loss.ToString()`
- `int.ToString()`；输入表达式：`m.CleanStreak.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: facts["streak"] = m.CleanStreak.ToString()`
- `NationalSpire.LiveCommentary.MomentFacts(string, int, int)`；输入表达式：`MomentFacts(name, hp, max)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MomentFacts(name, hp, max)`
- `NationalSpire.LiveCommentary.MomentTail(NationalSpire.BroadcastMemory, string, string, int)`；输入表达式：`MomentTail(m, "hurt_clean", seed, count)`；返回值紧邻使用处：`ConditionalExpressionSyntax: m.CleanStreak >= 3 ? MomentTail(m, "hurt_clean", seed, count) : count > 1 ? MomentTail(m, "hurt_repeat", seed, count) : ""`
- `NationalSpire.LiveCommentary.MomentTail(NationalSpire.BroadcastMemory, string, string, int)`；输入表达式：`MomentTail(m, "hurt_repeat", seed, count)`；返回值紧邻使用处：`ConditionalExpressionSyntax: count > 1 ? MomentTail(m, "hurt_repeat", seed, count) : ""`
- `NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`；输入表达式：`Speak(m, danger ? "player_danger" : "player_hurt", seconds, seed, facts, true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Speak(m, danger ? "player_danger" : "player_hurt", seconds, seed, facts, true)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`m.TopicTimes.ContainsKey(key)`；返回值紧邻使用处：`BinaryExpressionSyntax: m.TopicTimes.ContainsKey(key) || seconds - m.TopicTimes.GetValueOrDefault("player_health", -1000) < (danger ? 5 : 30)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`m.TopicTimes.GetValueOrDefault("player_health", -1000)`；返回值紧邻使用处：`BinaryExpressionSyntax: seconds - m.TopicTimes.GetValueOrDefault("player_health", -1000)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`m.PhraseIndices.GetValueOrDefault("hurt_count")`；返回值紧邻使用处：`BinaryExpressionSyntax: m.PhraseIndices.GetValueOrDefault("hurt_count") + 1`
- `System.Math.Max(double, double)`；输入表达式：`Math.Max(10, max * .16)`；返回值紧邻使用处：`BinaryExpressionSyntax: loss < Math.Max(10, max * .16)`

**赋值（含属性/字段和局部值）：**

- `facts["loss"]` = `loss.ToString()`
- `facts["streak"]` = `m.CleanStreak.ToString()`
- `facts["tail"]` = `m.CleanStreak >= 3 ? MomentTail(m, "hurt_clean", seed, count) : count > 1 ? MomentTail(m, "hurt_repeat", seed, count) : ""`
- `m.PhraseIndices["hurt_count"]` = `count`
- `m.TopicTimes["player_health"]` = `seconds`
- `m.TopicTimes[key]` = `seconds`

<a id="symbol-64cfa3e4c0ca"></a>

## `NationalSpire.LiveCommentary.UnknownRoom(NationalSpire.BroadcastMemory, int, string, int, int, int, string, string, double) — public static BroadcastLine? UnknownRoom(BroadcastMemory m, int floor, string room, int hp, int max, int gold, string name, string seed, double seconds)`

来源：源码第 100 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.UpdateRace()`](LiveRunBridge.cs.md#symbol-9566200347bc)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.LiveCommentary.MomentFacts(string, int, int)`](LiveMoments.cs.md#symbol-a7429ac6e843)；[`NationalSpire.LiveCommentary.MomentTail(NationalSpire.BroadcastMemory, string, string, int)`](LiveMoments.cs.md#symbol-d358a4a6cc39)；[`NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`](LiveCommentary.cs.md#symbol-28e751a76070)；`int.ToString()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastMemory.PhraseIndices`；`NationalSpire.BroadcastMemory.TopicTimes`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.LiveCommentary.MomentFacts(string, int, int)`；`NationalSpire.LiveCommentary.MomentTail(NationalSpire.BroadcastMemory, string, string, int)`；`NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.ToString()`；输入表达式：`gold.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: facts["gold"] = gold.ToString()`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(seed + floor + room)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.StableHash(seed + floor + room) % 3`
- `NationalSpire.LiveCommentary.MomentFacts(string, int, int)`；输入表达式：`MomentFacts(name, hp, max)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MomentFacts(name, hp, max)`
- `NationalSpire.LiveCommentary.MomentTail(NationalSpire.BroadcastMemory, string, string, int)`；输入表达式：`MomentTail(m, tail, seed, count)`；返回值紧邻使用处：`AssignmentExpressionSyntax: facts["tail"] = MomentTail(m, tail, seed, count)`
- `NationalSpire.LiveCommentary.Speak(NationalSpire.BroadcastMemory, string, double, string, System.Collections.Generic.Dictionary<string, string>, bool)`；输入表达式：`Speak(m, topic, seconds, seed, facts, true)`；返回值紧邻使用处：`ReturnStatementSyntax: return Speak(m, topic, seconds, seed, facts, true);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`m.TopicTimes.ContainsKey("room:" + floor + room)`；返回值紧邻使用处：`BinaryExpressionSyntax: topic.Length == 0 || m.TopicTimes.ContainsKey("room:" + floor + room)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`m.PhraseIndices.GetValueOrDefault("count:" + topic)`；返回值紧邻使用处：`BinaryExpressionSyntax: m.PhraseIndices.GetValueOrDefault("count:" + topic) + 1`

**赋值（含属性/字段和局部值）：**

- `facts["gold"]` = `gold.ToString()`
- `facts["tail"]` = `MomentTail(m, tail, seed, count)`
- `m.PhraseIndices["count:" + topic]` = `count`
- `m.TopicTimes["room:" + floor + room]` = `seconds`

<a id="symbol-a7429ac6e843"></a>

## `NationalSpire.LiveCommentary.MomentFacts(string, int, int) — private static Dictionary<string, string> MomentFacts(string name, int hp, int max)`

来源：源码第 114 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveCommentary.DiscardPotion(NationalSpire.BroadcastMemory, string, int, int, int, string, string, double)`](LiveMoments.cs.md#symbol-27c5783971c3)；[`NationalSpire.LiveCommentary.PlayerLoss(NationalSpire.BroadcastMemory, int, int, int, int, string, string, double)`](LiveMoments.cs.md#symbol-931725c8305b)；[`NationalSpire.LiveCommentary.PlayerVictory(NationalSpire.BroadcastMemory, bool, double, int, int, string, string, string)`](LiveMoments.cs.md#symbol-44f4d20ad966)；[`NationalSpire.LiveCommentary.Potion(NationalSpire.BroadcastMemory, string, int, int, string, string, double)`](LiveMoments.cs.md#symbol-4eaf89b958c5)；[`NationalSpire.LiveCommentary.UnknownRoom(NationalSpire.BroadcastMemory, int, string, int, int, int, string, string, double)`](LiveMoments.cs.md#symbol-64cfa3e4c0ca)

**调用：** `int.ToString()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.ToString()`；输入表达式：`hp.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["hp"] = hp.ToString()`
- `int.ToString()`；输入表达式：`max.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["max"] = max.ToString()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new() { ["name"] = name, ["hp"] = hp.ToString(), ["max"] = max.ToString() }`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new() { ["name"] = name, ["hp"] = hp.ToString(), ["max"] = max.ToString() }`

**赋值（含属性/字段和局部值）：**

- `["hp"]` = `hp.ToString()`
- `["max"]` = `max.ToString()`
- `["name"]` = `name`
