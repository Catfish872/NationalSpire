# DreadFacts.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`5DD3745CA904D57E5373389CCE2282307753E0F58B2A9ADB795E3A155FDE1F33`。来源：[源码](../../DreadFacts.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DreadFacts`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly MethodInfo? Dominion = typeof(EncounterModel).GetMethod("GetDominion", Type.EmptyTypes);
private static readonly PropertyInfo? Description = typeof(EncounterModel).Assembly
        .GetType("MegaCrit.Sts2.Core.Models.Dread.DominionModel")?.GetProperty("Description");
```

<a id="symbol-f5ed76aeee69"></a>

## `NationalSpire.DreadFacts.Capture(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Runs.IRunState) — public static void Capture(CareerMatch match, IRunState run)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameBridge.ReadDefeatedEncounters(MegaCrit.Sts2.Core.Runs.RunHistory, NationalSpire.CareerMatch?)`](GameBridge.cs.md#symbol-0910b7cd5c5f)；[`NationalSpire.LiveMaps.Read(MegaCrit.Sts2.Core.Runs.IRunState, NationalSpire.CareerMatch, bool)`](LiveMaps.cs.md#symbol-c878186b1e5a)

**调用：** [`NationalSpire.DreadFacts.BossEffect(MegaCrit.Sts2.Core.Models.EncounterModel)`](DreadFacts.cs.md#symbol-b14b262663e9)；[`NationalSpire.GameText.Plain(string)`](GameText.cs.md#symbol-e2c48dec4564)；`MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`NationalSpire.DreadActFact.DreadActFact(string, string)`；`object.GetType()`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`string.Replace(string, string?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Enum.ToString()`；`System.Reflection.MethodBase.Invoke(object?, object?[]?)`；`System.Reflection.PropertyInfo.GetValue(object?)`

**字段、属性、事件及方法组引用：** `(MegaCrit.Sts2.Core.Models.EncounterModel Boss, string Effect).Boss`；`(MegaCrit.Sts2.Core.Models.EncounterModel Boss, string Effect).Effect`；`NationalSpire.CareerMatch.DreadDominions`；`NationalSpire.DreadActFact.Boss`；`NationalSpire.DreadFacts.BossEffect(MegaCrit.Sts2.Core.Models.EncounterModel)`；`NationalSpire.DreadFacts.Description`；`NationalSpire.DreadFacts.Dominion`；`NationalSpire.GameText.Plain(string)`；`NationalSpire.MatchModes.Dread`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`b.Boss.Title.GetFormattedText()`；返回值紧邻使用处：`ArgumentSyntax: b.Boss.Title.GetFormattedText()`
- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`description.GetFormattedText()`；返回值紧邻使用处：`ArgumentSyntax: description.GetFormattedText()`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`encounter.Id.ToString()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = encounter.Id.ToString()`
- `NationalSpire.DreadActFact.DreadActFact(string, string)`；输入表达式：`new(id, "普通战斗中，" + ordinary + "精英战斗中，" + elite + (boss.Length > 0 ? (bosses.Length == 1 ? "首领战中，" : "") + boss : ""))`；返回值紧邻使用处：`AssignmentExpressionSyntax: match.DreadDominions[act + 1] = new(id, "普通战斗中，" + ordinary + "精英战斗中，" + elite + (boss.Length > 0 ? (bosses.Length == 1 ? "首领战中，" : "") + boss : ""))`
- `NationalSpire.DreadFacts.BossEffect(MegaCrit.Sts2.Core.Models.EncounterModel)`；输入表达式：`BossEffect(b!)`；返回值紧邻使用处：`ArgumentSyntax: Effect: BossEffect(b!)`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(b.Boss.Title.GetFormattedText())`；返回值紧邻使用处：`BinaryExpressionSyntax: GameText.Plain(b.Boss.Title.GetFormattedText()) + "的首领战中，"`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(description.GetFormattedText())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GameText.Plain(description.GetFormattedText())`
- `object.GetType()`；输入表达式：`encounter.GetType()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: encounter.GetType().Name`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("", bosses.Select(b => bosses.Length > 1 ? GameText.Plain(b.Boss.Title.GetFormattedText()) + "的首领战中，" + b.Effect : b.Effect))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = string.Join("", bosses.Select(b => bosses.Length > 1 ? GameText.Plain(b.Boss.Title.GetFormattedText()) + "的首领战中，" + b.Effect : b.Effect))`
- `string.Replace(string, string?)`；输入表达式：`text.Replace("你的", "玩家的").Replace("你在", "玩家在")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = text.Replace("你的", "玩家的").Replace("你在", "玩家在")`
- `string.Replace(string, string?)`；输入表达式：`text.Replace("你的", "玩家的")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.Replace("你的", "玩家的").Replace`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`match.DreadDominions.TryGetValue(act + 1, out var previous)`；返回值紧邻使用处：`BinaryExpressionSyntax: match.DreadDominions.TryGetValue(act + 1, out var previous) && previous.Boss == id`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`bosses.Select(b => bosses.Length > 1 ? GameText.Plain(b.Boss.Title.GetFormattedText()) + "的首领战中，" + b.Effect : b.Effect)`；返回值紧邻使用处：`ArgumentSyntax: bosses.Select(b => bosses.Length > 1 ? GameText.Plain(b.Boss.Title.GetFormattedText()) + "的首领战中，" + b.Effect : b.Effect)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`new[] { run.Acts[act].BossEncounter, run.Acts[act].SecondBossEncounter }                 .Where(b => b != null).Select(b => (Boss: b!, Effect: BossEffect(b!)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { run.Acts[act].BossEncounter, run.Acts[act].SecondBossEncounter }                 .Where(b => b != null).Select(b => (Boss: b!, Effect: BossEffect(b!))).Where`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`new[] { run.Acts[act].BossEncounter, run.Acts[act].SecondBossEncounter }                 .Where(b => b != null).Select(b => (Boss: b!, Effect: BossEffect(b!))).Where(b => b.Effect.Length > 0).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new[] { run.Acts[act].BossEncounter, run.Acts[act].SecondBossEncounter }                 .Where(b => b != null).Select(b => (Boss: b!, Effect: BossEffect(b!))).Where(b => b.Effect.Length > 0).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`new[] { run.Acts[act].BossEncounter, run.Acts[act].SecondBossEncounter }                 .Where(b => b != null).Select(b => (Boss: b!, Effect: BossEffect(b!))).Where(b => b.Effect.Length > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { run.Acts[act].BossEncounter, run.Acts[act].SecondBossEncounter }                 .Where(b => b != null).Select(b => (Boss: b!, Effect: BossEffect(b!))).Where(b => b.Effect.Length > 0).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`new[] { run.Acts[act].BossEncounter, run.Acts[act].SecondBossEncounter }                 .Where(b => b != null)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { run.Acts[act].BossEncounter, run.Acts[act].SecondBossEncounter }                 .Where(b => b != null).Select`
- `System.Enum.ToString()`；输入表达式：`run.GameMode.ToString()`；返回值紧邻使用处：`BinaryExpressionSyntax: run.GameMode.ToString() != MatchModes.Dread`
- `System.Reflection.MethodBase.Invoke(object?, object?[]?)`；输入表达式：`.Invoke(encounter, null)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Dominion?.Invoke(encounter, null)`
- `System.Reflection.PropertyInfo.GetValue(object?)`；输入表达式：`.GetValue(dominion)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Description?.GetValue(dominion)`

**赋值（含属性/字段和局部值）：**

- `elite` = `"敌人进入战斗时获得2层滑溜，后续召唤的敌人获得1层滑溜。"`
- `elite` = `"敌人死亡时造成爆炸伤害。多名敌人时每只造成3点，单个精英造成7点。"`
- `elite` = `"第2回合开始时，玩家获得3层虚弱、易伤和脆弱。"`
- `elite` = `"首回合从懒惰和失忆中选择1项灾祸。懒惰使玩家每回合最多打出3张牌；失忆使玩家本回合少抽2张牌，并失去1点能量。"`
- `elite` = `"玩家每回合结束时受到当前回合数加2点伤害。"`
- `match.DreadDominions[act + 1]` = `new(id, "普通战斗中，" + ordinary + "精英战斗中，" + elite + (boss.Length > 0 ? (bosses.Length == 1 ? "首领战中，" : "") + boss : ""))`
- `match.DreadDominions` ??= `[]`
- `ordinary` = `"敌人进入战斗时获得1层滑溜，后续召唤的敌人也获得1层滑溜。"`
- `ordinary` = `"敌人死亡时造成爆炸伤害。多名敌人时每只造成3点；单个弱敌造成4点，其他单个普通敌人造成5点。"`
- `ordinary` = `elite = "第2回合开始时，玩家获得3层虚弱、易伤和脆弱。"`
- `ordinary` = `elite = "首回合从懒惰和失忆中选择1项灾祸。懒惰使玩家每回合最多打出3张牌；失忆使玩家本回合少抽2张牌，并失去1点能量。"`
- `ordinary` = `elite = "玩家每回合结束时受到当前回合数加2点伤害。"`
- `text` = `"所有敌人进入战斗时获得3点力量。"`

<a id="symbol-eed00a23a71a"></a>

## `NationalSpire.DreadFacts.Effect(NationalSpire.CareerMatch?, int, string) — public static string? Effect(CareerMatch? match, int act, string encounter)`

来源：源码第 54 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameBridge.ReadDefeatedEncounters(MegaCrit.Sts2.Core.Runs.RunHistory, NationalSpire.CareerMatch?)`](GameBridge.cs.md#symbol-0910b7cd5c5f)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMatch.DreadDominions`；`NationalSpire.DreadActFact.Boss`；`NationalSpire.DreadActFact.Description`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`.TryGetValue(act, out var fact)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .DreadDominions?.TryGetValue(act, out var fact)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b14b262663e9"></a>

## `NationalSpire.DreadFacts.BossEffect(MegaCrit.Sts2.Core.Models.EncounterModel) — private static string BossEffect(EncounterModel boss)`

来源：源码第 58 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DreadFacts.Capture(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Runs.IRunState)`](DreadFacts.cs.md#symbol-f5ed76aeee69)

**调用：** `object.GetType()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `object.GetType()`；输入表达式：`boss.GetType()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: boss.GetType().Name`

**赋值（含属性/字段和局部值）：**
