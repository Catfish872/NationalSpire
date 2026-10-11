# LiveVoiceObservation.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`D0A6751D27795F1C450F210F14E56A8B4CBE852D409177AC04BEAD42AEE1A009`。来源：[源码](../../LiveVoiceObservation.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LiveVoiceObservation`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-efed0893a47e"></a>

## `NationalSpire.LiveVoiceObservation.Observe(NationalSpire.LiveVoices?, NationalSpire.BattleObservation, MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Combat.History.CombatHistoryEntry, string, double) — public static void Observe(LiveVoices? voices, BattleObservation battle, ICombatState state, Player player,         CombatHistoryEntry entry, string name, double now)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopBroadcast.Changed()`](Coop/CoopBroadcast.cs.md#symbol-9cb809e0579a)；[`NationalSpire.LiveRunBridge.History(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Combat.History.CombatHistoryEntry)`](LiveRunBridge.cs.md#symbol-42aede5a364b)

**调用：** [`NationalSpire.LiveCueRules.CardScene(string, bool)`](LiveCrowd.cs.md#symbol-f41fe00e7f8a)；[`NationalSpire.LiveVoices.Cue(string, string, int, double, int)`](LiveCrowd.cs.md#symbol-8f4f65d60af0)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Math.Max(double, double)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.BattleObservation.CrowdHpLost`；`NationalSpire.BattleObservation.Floor`；`NationalSpire.BattleObservation.LargeTargetMinHp`；`NationalSpire.BattleObservation.SmallTargetTurn`；`NationalSpire.BattleObservation.Turn`；`NationalSpire.LiveCueRules.CardScene(string, bool)`；`NationalSpire.LiveVoices.Cue(string, string, int, double, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LiveCueRules.CardScene(string, bool)`；输入表达式：`LiveCueRules.CardScene(card.CardPlay.Card.Id.Entry,                 card.CardPlay.Card.Type == CardType.Attack && card.CardPlay.Card.GainsBlock)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = LiveCueRules.CardScene(card.CardPlay.Card.Id.Entry,                 card.CardPlay.Card.Type == CardType.Attack && card.CardPlay.Card.GainsBlock)`
- `NationalSpire.LiveVoices.Cue(string, string, int, double, int)`；输入表达式：`voices.Cue("exact_lethal", name, battle.Floor, now)`；返回值紧邻使用处：`ExpressionStatementSyntax: voices.Cue("exact_lethal", name, battle.Floor, now);`
- `NationalSpire.LiveVoices.Cue(string, string, int, double, int)`；输入表达式：`voices.Cue("ignore_torch", name, battle.Floor, now)`；返回值紧邻使用处：`ExpressionStatementSyntax: voices.Cue("ignore_torch", name, battle.Floor, now);`
- `NationalSpire.LiveVoices.Cue(string, string, int, double, int)`；输入表达式：`voices.Cue("overkill", name, battle.Floor, now)`；返回值紧邻使用处：`ExpressionStatementSyntax: voices.Cue("overkill", name, battle.Floor, now);`
- `NationalSpire.LiveVoices.Cue(string, string, int, double, int)`；输入表达式：`voices.Cue(battle.SmallTargetTurn >= battle.Turn - 1 && largeStillAlive ? "small_focus" : "hurt",             name, battle.Floor, now, battle.CrowdHpLost)`；返回值紧邻使用处：`ExpressionStatementSyntax: voices.Cue(battle.SmallTargetTurn >= battle.Turn - 1 && largeStillAlive ? "small_focus" : "hurt",             name, battle.Floor, now, battle.CrowdHpLost);`
- `NationalSpire.LiveVoices.Cue(string, string, int, double, int)`；输入表达式：`voices.Cue(cue, name, battle.Floor, now)`；返回值紧邻使用处：`ExpressionStatementSyntax: voices.Cue(cue, name, battle.Floor, now);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`state.Enemies.Any(e => e != damage.Receiver && e.IsAlive && e.MaxHp >= damage.Receiver.MaxHp * 1.6)`；返回值紧邻使用处：`BinaryExpressionSyntax: damage.Dealer == player.Creature && damage.Receiver.IsEnemy && damage.Result.UnblockedDamage > 0             && damage.CardSource?.TargetType == TargetType.AnyEnemy             && state.Enemies.Any(e => e != damage.Receiver && e.IsAlive && e.MaxHp >= damage.Receiver.MaxHp * 1.6)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`state.Enemies.Any(e => e.IsAlive && e.MaxHp >= battle.LargeTargetMinHp)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = state.Enemies.Any(e => e.IsAlive && e.MaxHp >= battle.LargeTargetMinHp)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`state.Enemies.Any(e => e.IsAlive && e.Monster?.Id.Entry == "TORCH_HEAD_AMALGAM")`；返回值紧邻使用处：`BinaryExpressionSyntax: entry is CardPlayStartedEntry started && started.CardPlay.Card.Owner == player             && started.CardPlay.Card.TargetType == TargetType.AnyEnemy             && started.CardPlay.Card.Type == CardType.Attack             && started.CardPlay.Target?.Monster?.Id.Entry == "QUEEN"             && state.Enemies.Any(e => e.IsAlive && e.Monster?.Id.Entry == "TORCH_HEAD_AMALGAM")`
- `System.Math.Max(double, double)`；输入表达式：`Math.Max(12, player.Creature.MaxHp * .18)`；返回值紧邻使用处：`BinaryExpressionSyntax: battle.CrowdHpLost < Math.Max(12, player.Creature.MaxHp * .18)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, damage.Result.UnblockedDamage)`；返回值紧邻使用处：`AssignmentExpressionSyntax: battle.CrowdHpLost += Math.Max(0, damage.Result.UnblockedDamage)`

**赋值（含属性/字段和局部值）：**

- `battle.CrowdHpLost` += `Math.Max(0, damage.Result.UnblockedDamage)`
- `battle.LargeTargetMinHp` = `damage.Receiver.MaxHp * 1.6`
- `battle.SmallTargetTurn` = `battle.Turn`
