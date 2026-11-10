# LiveShopObserver.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`59E6188A7C61E75CBB96AD351ACAA7D63E74996BC765B766E1B576AF2D61DE2F`。来源：[源码](../../LiveShopObserver.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LiveShopChange`、`NationalSpire.LiveShopObserver`、`NationalSpire.LiveShopObserver.Cursor`。

字段、事件及初始值（源码原样）：

```csharp
private readonly Dictionary<ulong, Cursor> _seen = [];
private int _floor;
private bool _disabled;
```

<a id="symbol-9c0734afb2ba"></a>

## `NationalSpire.LiveShopObserver.LiveShopObserver(MegaCrit.Sts2.Core.Runs.RunState) — public LiveShopObserver(RunState run)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopBroadcast.CoopBroadcast(NationalSpire.Coop.CoopCoordinator)`](Coop/CoopBroadcast.cs.md#symbol-2885ebc77d3b)；[`NationalSpire.Coop.CoopBroadcast.Tick()`](Coop/CoopBroadcast.cs.md#symbol-3be13ce2aa51)；[`NationalSpire.LiveRunBridge._Ready()`](LiveRunBridge.cs.md#symbol-26fa8bae2af0)

**调用：** [`NationalSpire.LiveShopObserver.Read(MegaCrit.Sts2.Core.Runs.RunState, bool)`](LiveShopObserver.cs.md#symbol-76febe44c2f1)

**字段、属性、事件及方法组引用：** `NationalSpire.LiveShopObserver._floor`；`NationalSpire.LiveShopObserver.Read(MegaCrit.Sts2.Core.Runs.RunState, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LiveShopObserver.Read(MegaCrit.Sts2.Core.Runs.RunState, bool)`；输入表达式：`Read(run, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: Read(run, false);`

**赋值（含属性/字段和局部值）：**

- `_floor` = `run.TotalFloor`

<a id="symbol-76febe44c2f1"></a>

## `NationalSpire.LiveShopObserver.Read(MegaCrit.Sts2.Core.Runs.RunState, bool) — public IReadOnlyList<LiveShopChange> Read(RunState run, bool publish = true)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopBroadcast.Tick()`](Coop/CoopBroadcast.cs.md#symbol-3be13ce2aa51)；[`NationalSpire.LiveRunBridge.RefreshRace(ref bool)`](LiveRunBridge.cs.md#symbol-f03ac37c2ac4)；[`NationalSpire.LiveShopObserver.LiveShopObserver(MegaCrit.Sts2.Core.Runs.RunState)`](LiveShopObserver.cs.md#symbol-9c0734afb2ba)

**调用：** [`Add(string, string, string)`](LiveShopObserver.cs.md#symbol-3cb46534a05e)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；`MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；`MegaCrit.Sts2.Core.Models.ModelDb.GetByIdOrNull<T>(MegaCrit.Sts2.Core.Models.ModelId)`；`MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry.GetEntry(ulong)`；`NationalSpire.LiveShopObserver.Cursor.Cursor(int, int, int, int, int)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.List<T>.List()`；`System.Enum.ToString()`

**字段、属性、事件及方法组引用：** `Add(string, string, string)`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.LiveShopObserver._disabled`；`NationalSpire.LiveShopObserver._floor`；`NationalSpire.LiveShopObserver._seen`；`NationalSpire.LiveShopObserver.Cursor.Cards`；`NationalSpire.LiveShopObserver.Cursor.Potions`；`NationalSpire.LiveShopObserver.Cursor.Relics`；`NationalSpire.LiveShopObserver.Cursor.Removed`；`NationalSpire.LiveShopObserver.Cursor.Spent`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Add(string, string, string)`；输入表达式：`Add("buy_potion", model.Title.GetFormattedText())`；返回值紧邻使用处：`ExpressionStatementSyntax: Add("buy_potion", model.Title.GetFormattedText());`
- `Add(string, string, string)`；输入表达式：`Add("buy_relic", model.Title.GetFormattedText())`；返回值紧邻使用处：`ExpressionStatementSyntax: Add("buy_relic", model.Title.GetFormattedText());`
- `Add(string, string, string)`；输入表达式：`Add(model.Type.ToString() switch { "Attack" => "remove_attack", "Curse" => "remove_curse", _ => "remove_defend" }, model.Title)`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(model.Type.ToString() switch { "Attack" => "remove_attack", "Curse" => "remove_curse", _ => "remove_defend" }, model.Title);`
- `Add(string, string, string)`；输入表达式：`Add(shop ? h.GoldSpent > before.Spent ? "buy_card" : "gain_card" : "reward_card", model.Title, model.Type.ToString())`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(shop ? h.GoldSpent > before.Spent ? "buy_card" : "gain_card" : "reward_card", model.Title, model.Type.ToString());`
- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`model.Title.GetFormattedText()`；返回值紧邻使用处：`ArgumentSyntax: model.Title.GetFormattedText()`
- `MegaCrit.Sts2.Core.Models.ModelDb.GetByIdOrNull<T>(MegaCrit.Sts2.Core.Models.ModelId)`；输入表达式：`ModelDb.GetByIdOrNull<CardModel>(id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ModelDb.GetByIdOrNull<CardModel>(id) is { } model`
- `MegaCrit.Sts2.Core.Models.ModelDb.GetByIdOrNull<T>(MegaCrit.Sts2.Core.Models.ModelId)`；输入表达式：`ModelDb.GetByIdOrNull<PotionModel>(id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ModelDb.GetByIdOrNull<PotionModel>(id) is { } model`
- `MegaCrit.Sts2.Core.Models.ModelDb.GetByIdOrNull<T>(MegaCrit.Sts2.Core.Models.ModelId)`；输入表达式：`ModelDb.GetByIdOrNull<RelicModel>(id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ModelDb.GetByIdOrNull<RelicModel>(id) is { } model`
- `MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry.GetEntry(ulong)`；输入表达式：`.GetEntry(p.NetId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: run.CurrentMapPointHistoryEntry?.GetEntry(p.NetId)`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("live.shop", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("live.shop", e);`
- `NationalSpire.LiveShopObserver.Cursor.Cursor(int, int, int, int, int)`；输入表达式：`new(0, 0, 0, 0, 0)`；返回值紧邻使用处：`ArgumentSyntax: new(0, 0, 0, 0, 0)`
- `NationalSpire.LiveShopObserver.Cursor.Cursor(int, int, int, int, int)`；输入表达式：`new(h.CardsRemoved.Count, h.CardsGained.Count, h.BoughtRelics.Count, h.BoughtPotions.Count, h.GoldSpent)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _seen[p.NetId] = new(h.CardsRemoved.Count, h.CardsGained.Count, h.BoughtRelics.Count, h.BoughtPotions.Count, h.GoldSpent)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_seen.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _seen.Clear();`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`h.BoughtPotions.Skip(before.Potions)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var id in h.BoughtPotions.Skip(before.Potions))                     if (ModelDb.GetByIdOrNull<PotionModel>(id) is { } model) Add("buy_potion", model.Title.GetFormattedText());`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`h.BoughtRelics.Skip(before.Relics)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var id in h.BoughtRelics.Skip(before.Relics))                     if (ModelDb.GetByIdOrNull<RelicModel>(id) is { } model) Add("buy_relic", model.Title.GetFormattedText());`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`h.CardsGained.Skip(before.Cards)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var card in h.CardsGained.Skip(before.Cards))                     if (card.Id is { } id && ModelDb.GetByIdOrNull<CardModel>(id) is { } model)                         Add(shop ? h.GoldSpent > before.Spent ? "buy_card" : "gain_card" : "reward_card", model.Title, model.Type.ToString());`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`h.CardsRemoved.Skip(before.Removed)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var card in h.CardsRemoved.Skip(before.Removed))                     if (card.Id is { } id && ModelDb.GetByIdOrNull<CardModel>(id) is { } model)                         Add(model.Type.ToString() switch { "Attack" => "remove_attack", "Curse" => "remove_curse", _ => "remove_defend" }, model.Title);`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`_seen.GetValueOrDefault(p.NetId, new(0, 0, 0, 0, 0))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _seen.GetValueOrDefault(p.NetId, new(0, 0, 0, 0, 0))`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<LiveShopChange>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<LiveShopChange>()`
- `System.Enum.ToString()`；输入表达式：`.RoomType.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: run.CurrentRoom?.RoomType.ToString()`
- `System.Enum.ToString()`；输入表达式：`model.Type.ToString()`；返回值紧邻使用处：`ArgumentSyntax: model.Type.ToString()`
- `System.Enum.ToString()`；输入表达式：`model.Type.ToString()`；返回值紧邻使用处：`SwitchExpressionSyntax: model.Type.ToString() switch { "Attack" => "remove_attack", "Curse" => "remove_curse", _ => "remove_defend" }`

**赋值（含属性/字段和局部值）：**

- `_disabled` = `true`
- `_floor` = `run.TotalFloor`
- `_seen[p.NetId]` = `new(h.CardsRemoved.Count, h.CardsGained.Count, h.BoughtRelics.Count, h.BoughtPotions.Count, h.GoldSpent)`

<a id="symbol-3cb46534a05e"></a>

## `Add(string, string, string) — void Add(string kind, string name, string cardType = "")`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveShopObserver.Read(MegaCrit.Sts2.Core.Runs.RunState, bool)`](LiveShopObserver.cs.md#symbol-76febe44c2f1)

**调用：** [`NationalSpire.GameText.Plain(string)`](GameText.cs.md#symbol-e2c48dec4564)；`NationalSpire.LiveShopChange.LiveShopChange(ulong, string, string, int, int, string)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.GameText.Plain(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(name)`；返回值紧邻使用处：`ArgumentSyntax: GameText.Plain(name)`
- `NationalSpire.LiveShopChange.LiveShopChange(ulong, string, string, int, int, string)`；输入表达式：`new(p.NetId, kind, GameText.Plain(name), p.Deck.Cards.Count, p.Gold, cardType)`；返回值紧邻使用处：`ArgumentSyntax: new(p.NetId, kind, GameText.Plain(name), p.Deck.Cards.Count, p.Gold, cardType)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.Add(new(p.NetId, kind, GameText.Plain(name), p.Deck.Cards.Count, p.Gold, cardType))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => result.Add(new(p.NetId, kind, GameText.Plain(name), p.Deck.Cards.Count, p.Gold, cardType))`

**赋值（含属性/字段和局部值）：**
