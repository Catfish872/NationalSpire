# LiveRunBridge.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`28FCCE017DFF4AE02B238E592778E93B2B6D775830F7BE89975F125A8D33A4A8`。来源：[源码](../../LiveRunBridge.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LiveRunBridge`、`NationalSpire.LiveRunReadyPatch`、`NationalSpire.LiveEnergyPatch`、`NationalSpire.LiveSkippedRewardPatch`、`NationalSpire.LiveVictoryPatch`。

字段、事件及初始值（源码原样）：

```csharp
private RunState _run = null!;
private CareerData _data = null!;
private CareerMatch _match = null!;
private CareerPerson _rival = null!;
private Player _player = null!;
private BattleObservation? _battle;
private LiveRaceHud _hud = null!;
private RivalMapOverlay? _mapOverlay;
private double _tick;
private double _mapCheck;
private bool _faulted, _commentaryFaulted, _ended;
private double _mapRetryAt, _artRetryAt;
private int _pendingLoss, _lossFloor = -1;
private int _potionFloor = -1, _observedPotions, _discardedPotions;
private int _historyCount;
private LiveVoices? _voices;
private LiveShopObserver _shop = null!;
private Dictionary<MapCoord, NMapPoint>? _mapPoints;
private NMapScreen? _mapScreen;
private ActMap? _lastMap;
private bool _mapCompatible = true;
```

<a id="symbol-4c738a13c885"></a>

## `NationalSpire.LiveRunBridge.Current — public static LiveRunBridge? Current`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6d1acedb20da"></a>

## `NationalSpire.LiveRunBridge.DiagnosticSnapshot() — internal object DiagnosticSnapshot()`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Entry.Init()`](Entry.cs.md#symbol-f4f7468c39e8)

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`

**字段、属性、事件及方法组引用：** `<anonymous type: string match, string seed, int act, int floor, int hp, NationalSpire.BattleObservation battle, bool faulted, bool commentaryFaulted, bool ended, int? healthPlanVersion, bool mapCompatible, int? mapPoints, double mapRetryAt, bool hudVisible, bool overlayVisible>.act`；`<anonymous type: string match, string seed, int act, int floor, int hp, NationalSpire.BattleObservation battle, bool faulted, bool commentaryFaulted, bool ended, int? healthPlanVersion, bool mapCompatible, int? mapPoints, double mapRetryAt, bool hudVisible, bool overlayVisible>.battle`；`<anonymous type: string match, string seed, int act, int floor, int hp, NationalSpire.BattleObservation battle, bool faulted, bool commentaryFaulted, bool ended, int? healthPlanVersion, bool mapCompatible, int? mapPoints, double mapRetryAt, bool hudVisible, bool overlayVisible>.commentaryFaulted`；`<anonymous type: string match, string seed, int act, int floor, int hp, NationalSpire.BattleObservation battle, bool faulted, bool commentaryFaulted, bool ended, int? healthPlanVersion, bool mapCompatible, int? mapPoints, double mapRetryAt, bool hudVisible, bool overlayVisible>.ended`；`<anonymous type: string match, string seed, int act, int floor, int hp, NationalSpire.BattleObservation battle, bool faulted, bool commentaryFaulted, bool ended, int? healthPlanVersion, bool mapCompatible, int? mapPoints, double mapRetryAt, bool hudVisible, bool overlayVisible>.faulted`；`<anonymous type: string match, string seed, int act, int floor, int hp, NationalSpire.BattleObservation battle, bool faulted, bool commentaryFaulted, bool ended, int? healthPlanVersion, bool mapCompatible, int? mapPoints, double mapRetryAt, bool hudVisible, bool overlayVisible>.floor`；`<anonymous type: string match, string seed, int act, int floor, int hp, NationalSpire.BattleObservation battle, bool faulted, bool commentaryFaulted, bool ended, int? healthPlanVersion, bool mapCompatible, int? mapPoints, double mapRetryAt, bool hudVisible, bool overlayVisible>.healthPlanVersion`；`<anonymous type: string match, string seed, int act, int floor, int hp, NationalSpire.BattleObservation battle, bool faulted, bool commentaryFaulted, bool ended, int? healthPlanVersion, bool mapCompatible, int? mapPoints, double mapRetryAt, bool hudVisible, bool overlayVisible>.hp`；`<anonymous type: string match, string seed, int act, int floor, int hp, NationalSpire.BattleObservation battle, bool faulted, bool commentaryFaulted, bool ended, int? healthPlanVersion, bool mapCompatible, int? mapPoints, double mapRetryAt, bool hudVisible, bool overlayVisible>.hudVisible`；`<anonymous type: string match, string seed, int act, int floor, int hp, NationalSpire.BattleObservation battle, bool faulted, bool commentaryFaulted, bool ended, int? healthPlanVersion, bool mapCompatible, int? mapPoints, double mapRetryAt, bool hudVisible, bool overlayVisible>.mapCompatible`；`<anonymous type: string match, string seed, int act, int floor, int hp, NationalSpire.BattleObservation battle, bool faulted, bool commentaryFaulted, bool ended, int? healthPlanVersion, bool mapCompatible, int? mapPoints, double mapRetryAt, bool hudVisible, bool overlayVisible>.mapPoints`；`<anonymous type: string match, string seed, int act, int floor, int hp, NationalSpire.BattleObservation battle, bool faulted, bool commentaryFaulted, bool ended, int? healthPlanVersion, bool mapCompatible, int? mapPoints, double mapRetryAt, bool hudVisible, bool overlayVisible>.mapRetryAt`；`<anonymous type: string match, string seed, int act, int floor, int hp, NationalSpire.BattleObservation battle, bool faulted, bool commentaryFaulted, bool ended, int? healthPlanVersion, bool mapCompatible, int? mapPoints, double mapRetryAt, bool hudVisible, bool overlayVisible>.match`；`<anonymous type: string match, string seed, int act, int floor, int hp, NationalSpire.BattleObservation battle, bool faulted, bool commentaryFaulted, bool ended, int? healthPlanVersion, bool mapCompatible, int? mapPoints, double mapRetryAt, bool hudVisible, bool overlayVisible>.overlayVisible`；`<anonymous type: string match, string seed, int act, int floor, int hp, NationalSpire.BattleObservation battle, bool faulted, bool commentaryFaulted, bool ended, int? healthPlanVersion, bool mapCompatible, int? mapPoints, double mapRetryAt, bool hudVisible, bool overlayVisible>.seed`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Live`；`NationalSpire.LiveMatchState.HealthPlanVersion`；`NationalSpire.LiveRunBridge._battle`；`NationalSpire.LiveRunBridge._commentaryFaulted`；`NationalSpire.LiveRunBridge._ended`；`NationalSpire.LiveRunBridge._faulted`；`NationalSpire.LiveRunBridge._hud`；`NationalSpire.LiveRunBridge._mapCompatible`；`NationalSpire.LiveRunBridge._mapOverlay`；`NationalSpire.LiveRunBridge._mapPoints`；`NationalSpire.LiveRunBridge._mapRetryAt`；`NationalSpire.LiveRunBridge._match`；`NationalSpire.LiveRunBridge._player`；`NationalSpire.LiveRunBridge._run`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_hud)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(_hud) && _hud.Visible`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_mapOverlay)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(_mapOverlay) && _mapOverlay!.Visible`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1af74b766122"></a>

## `NationalSpire.LiveRunBridge.Attach(MegaCrit.Sts2.Core.Nodes.NRun, MegaCrit.Sts2.Core.Runs.RunState) — public static void Attach(NRun node, RunState run)`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunReadyPatch.Postfix(MegaCrit.Sts2.Core.Nodes.NRun)`](LiveRunBridge.cs.md#symbol-5639c4c6edfd)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerRunBinding.Find(NationalSpire.CareerData, string, string, int, int, bool, long?)`](CareerRunBinding.cs.md#symbol-814ae5a03226)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildren(bool)`；`MegaCrit.Sts2.Core.Context.LocalContext.GetMe(MegaCrit.Sts2.Core.Runs.IPlayerCollection?)`；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`NationalSpire.LiveRunBridge.LiveRunBridge()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.IEnumerable.OfType<TResult>()`；`System.Enum.ToString()`

**字段、属性、事件及方法组引用：** `<anonymous type: string PendingMatchId, string runSeed, string expectedSeed, int AscensionLevel, int players, string mode, string character, string SelectedCharacter, int SelectedAscension>.character`；`<anonymous type: string PendingMatchId, string runSeed, string expectedSeed, int AscensionLevel, int players, string mode, string character, string SelectedCharacter, int SelectedAscension>.expectedSeed`；`<anonymous type: string PendingMatchId, string runSeed, string expectedSeed, int AscensionLevel, int players, string mode, string character, string SelectedCharacter, int SelectedAscension>.mode`；`<anonymous type: string PendingMatchId, string runSeed, string expectedSeed, int AscensionLevel, int players, string mode, string character, string SelectedCharacter, int SelectedAscension>.players`；`<anonymous type: string PendingMatchId, string runSeed, string expectedSeed, int AscensionLevel, int players, string mode, string character, string SelectedCharacter, int SelectedAscension>.runSeed`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.SelectedAscension`；`NationalSpire.CareerData.SelectedCharacter`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.CareerRunBinding.Find(NationalSpire.CareerData, string, string, int, int, bool, long?)`；`NationalSpire.CareerStore.Data`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.LiveRunBridge._data`；`NationalSpire.LiveRunBridge._match`；`NationalSpire.LiveRunBridge._player`；`NationalSpire.LiveRunBridge._rival`；`NationalSpire.LiveRunBridge._run`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`node.AddChild(bridge)`；返回值紧邻使用处：`ExpressionStatementSyntax: node.AddChild(bridge);`
- `Godot.Node.GetChildren(bool)`；输入表达式：`node.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: node.GetChildren().OfType<LiveRunBridge>`
- `MegaCrit.Sts2.Core.Context.LocalContext.GetMe(MegaCrit.Sts2.Core.Runs.IPlayerCollection?)`；输入表达式：`LocalContext.GetMe(run)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = LocalContext.GetMe(run)`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`.Character.Id.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: run.Players.FirstOrDefault()?.Character.Id.ToString()`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, match.OpponentId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(data, match.OpponentId) is not { } rival`
- `NationalSpire.CareerRunBinding.Find(NationalSpire.CareerData, string, string, int, int, bool, long?)`；输入表达式：`CareerRunBinding.Find(data, run.Rng.StringSeed, run.Players.FirstOrDefault()?.Character.Id.ToString() ?? "",              run.AscensionLevel, run.Players.Count, run.GameMode == GameMode.Standard)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerRunBinding.Find(data, run.Rng.StringSeed, run.Players.FirstOrDefault()?.Character.Id.ToString() ?? "",              run.AscensionLevel, run.Players.Count, run.GameMode == GameMode.Standard)`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("live.binding_skipped", new { data.PendingMatchId, runSeed = run.Rng.StringSeed,                  expectedSeed = data.Matches.FirstOrDefault(m => m.Id == data.PendingMatchId)?.Seed,                  run.AscensionLevel, players = run.Players.Count, mode = run.GameMode.ToString(),                  character = run.Players.FirstOrDefault()?.Character.Id.ToString(), data.SelectedCharacter, data.SelectedAscension })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("live.binding_skipped", new { data.PendingMatchId, runSeed = run.Rng.StringSeed,                  expectedSeed = data.Matches.FirstOrDefault(m => m.Id == data.PendingMatchId)?.Seed,                  run.AscensionLevel, players = run.Players.Count, mode = run.GameMode.ToString(),                  character = run.Players.FirstOrDefault()?.Character.Id.ToString(), data.SelectedCharacter, data.SelectedAscension });`
- `NationalSpire.LiveRunBridge.LiveRunBridge()`；输入表达式：`new LiveRunBridge { _run = run, _data = data, _match = match, _rival = rival, _player = player }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LiveRunBridge { _run = run, _data = data, _match = match, _rival = rival, _player = player }`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>()`；输入表达式：`node.GetChildren().OfType<LiveRunBridge>().Any()`；返回值紧邻使用处：`IfStatementSyntax: if (node.GetChildren().OfType<LiveRunBridge>().Any()) return;`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`run.Players.FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: run.Players.FirstOrDefault()?.Character.Id.ToString()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.FirstOrDefault(m => m.Id == data.PendingMatchId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: data.Matches.FirstOrDefault(m => m.Id == data.PendingMatchId)?.Seed`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`node.GetChildren().OfType<LiveRunBridge>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: node.GetChildren().OfType<LiveRunBridge>().Any`
- `System.Enum.ToString()`；输入表达式：`run.GameMode.ToString()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: mode = run.GameMode.ToString()`

**赋值（含属性/字段和局部值）：**

- `_data` = `data`
- `_match` = `match`
- `_player` = `player`
- `_rival` = `rival`
- `_run` = `run`

<a id="symbol-26fa8bae2af0"></a>

## `NationalSpire.LiveRunBridge._Ready() — public override void _Ready()`

来源：源码第 71 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.LiveRaceHud.Restore(NationalSpire.BroadcastUiState)`](LiveRaceHud.cs.md#symbol-5f9621b5d769)；[`NationalSpire.LiveRunBridge.OnCombat(MegaCrit.Sts2.Core.Combat.ICombatState)`](LiveRunBridge.cs.md#symbol-e13750e1d813)；[`NationalSpire.LiveShopObserver.LiveShopObserver(MegaCrit.Sts2.Core.Runs.RunState)`](LiveShopObserver.cs.md#symbol-9c0734afb2ba)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetParent()`；`MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry.GetEntry(ulong)`；`NationalSpire.LiveRaceHud.LiveRaceHud()`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`

**字段、属性、事件及方法组引用：** `<anonymous type: string match, string seed, int act, int floor>.act`；`<anonymous type: string match, string seed, int act, int floor>.floor`；`<anonymous type: string match, string seed, int act, int floor>.match`；`<anonymous type: string match, string seed, int act, int floor>.seed`；`NationalSpire.BattleObservation.CompleteObservation`；`NationalSpire.CareerData.BroadcastUi`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.LiveRaceHud.LayoutChanged`；`NationalSpire.LiveRaceHud.Restore(NationalSpire.BroadcastUiState)`；`NationalSpire.LiveRunBridge._battle`；`NationalSpire.LiveRunBridge._data`；`NationalSpire.LiveRunBridge._discardedPotions`；`NationalSpire.LiveRunBridge._historyCount`；`NationalSpire.LiveRunBridge._hud`；`NationalSpire.LiveRunBridge._match`；`NationalSpire.LiveRunBridge._observedPotions`；`NationalSpire.LiveRunBridge._player`；`NationalSpire.LiveRunBridge._potionFloor`；`NationalSpire.LiveRunBridge._run`；`NationalSpire.LiveRunBridge._shop`；`NationalSpire.LiveRunBridge.Current`；`NationalSpire.LiveRunBridge.HpChanged(int, int)`；`NationalSpire.LiveRunBridge.OnCombat(MegaCrit.Sts2.Core.Combat.ICombatState)`；`NationalSpire.LiveRunBridge.OnHistoryChanged()`；`NationalSpire.LiveRunBridge.OnWon(MegaCrit.Sts2.Core.Rooms.CombatRoom)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`((NRun)GetParent()).GlobalUi.AddChild(_hud)`；返回值紧邻使用处：`ExpressionStatementSyntax: ((NRun)GetParent()).GlobalUi.AddChild(_hud);`
- `Godot.Node.GetParent()`；输入表达式：`GetParent()`；返回值紧邻使用处：`CastExpressionSyntax: (NRun)GetParent()`
- `MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry.GetEntry(ulong)`；输入表达式：`.GetEntry(_player.NetId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: .GetEntry(_player.NetId).PotionDiscarded`
- `MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry.GetEntry(ulong)`；输入表达式：`.GetEntry(_player.NetId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: .GetEntry(_player.NetId).PotionUsed`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(_data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(_data);`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("live.attached", new { match = _match.Id, seed = _run.Rng.StringSeed, act = _run.CurrentActIndex, floor = _run.TotalFloor })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("live.attached", new { match = _match.Id, seed = _run.Rng.StringSeed, act = _run.CurrentActIndex, floor = _run.TotalFloor });`
- `NationalSpire.LiveRaceHud.LiveRaceHud()`；输入表达式：`new LiveRaceHud()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _hud = new LiveRaceHud()`
- `NationalSpire.LiveRaceHud.Restore(NationalSpire.BroadcastUiState)`；输入表达式：`_hud.Restore(_data.BroadcastUi)`；返回值紧邻使用处：`ExpressionStatementSyntax: _hud.Restore(_data.BroadcastUi);`
- `NationalSpire.LiveRunBridge.OnCombat(MegaCrit.Sts2.Core.Combat.ICombatState)`；输入表达式：`OnCombat(combat)`；返回值紧邻使用处：`ExpressionStatementSyntax: OnCombat(combat);`
- `NationalSpire.LiveShopObserver.LiveShopObserver(MegaCrit.Sts2.Core.Runs.RunState)`；输入表达式：`new(_run)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _shop = new(_run)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`CombatManager.Instance.History.Entries.Count()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _historyCount = CombatManager.Instance.History.Entries.Count()`

**赋值（含属性/字段和局部值）：**

- `_battle!.CompleteObservation` = `false`
- `_data.BroadcastUi` = `layout`
- `_discardedPotions` = `_run.CurrentMapPointHistoryEntry?.GetEntry(_player.NetId).PotionDiscarded.Count ?? 0`
- `_historyCount` = `CombatManager.Instance.History.Entries.Count()`
- `_hud.LayoutChanged` += `layout => { _data.BroadcastUi = layout; CareerStore.Save(_data); }`
- `_hud` = `new LiveRaceHud()`
- `_observedPotions` = `_run.CurrentMapPointHistoryEntry?.GetEntry(_player.NetId).PotionUsed.Count ?? 0`
- `_player.Creature.CurrentHpChanged` += `HpChanged`
- `_potionFloor` = `_run.TotalFloor`
- `_shop` = `new(_run)`
- `CombatManager.Instance.CombatSetUp` += `OnCombat`
- `CombatManager.Instance.CombatWon` += `OnWon`
- `CombatManager.Instance.History.Changed` += `OnHistoryChanged`
- `Current` = `this`

<a id="symbol-1d45315292ab"></a>

## `NationalSpire.LiveRunBridge._ExitTree() — public override void _ExitTree()`

来源：源码第 90 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.QueueFree()`

**字段、属性、事件及方法组引用：** `NationalSpire.LiveRunBridge._hud`；`NationalSpire.LiveRunBridge._mapOverlay`；`NationalSpire.LiveRunBridge._player`；`NationalSpire.LiveRunBridge.Current`；`NationalSpire.LiveRunBridge.HpChanged(int, int)`；`NationalSpire.LiveRunBridge.OnCombat(MegaCrit.Sts2.Core.Combat.ICombatState)`；`NationalSpire.LiveRunBridge.OnHistoryChanged()`；`NationalSpire.LiveRunBridge.OnWon(MegaCrit.Sts2.Core.Rooms.CombatRoom)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_hud)`；返回值紧邻使用处：`IfStatementSyntax: if (IsInstanceValid(_hud)) _hud.QueueFree();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_mapOverlay)`；返回值紧邻使用处：`IfStatementSyntax: if (IsInstanceValid(_mapOverlay)) _mapOverlay!.QueueFree();`
- `Godot.Node.QueueFree()`；输入表达式：`_hud.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: _hud.QueueFree();`
- `Godot.Node.QueueFree()`；输入表达式：`_mapOverlay!.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: _mapOverlay!.QueueFree();`

**赋值（含属性/字段和局部值）：**

- `_player.Creature.CurrentHpChanged` -= `HpChanged`
- `CombatManager.Instance.CombatSetUp` -= `OnCombat`
- `CombatManager.Instance.CombatWon` -= `OnWon`
- `CombatManager.Instance.History.Changed` -= `OnHistoryChanged`
- `Current` = `null`

<a id="symbol-65a24868959d"></a>

## `NationalSpire.LiveRunBridge.Guard(System.Action, bool) — internal static void Guard(Action action, bool commentaryOnly = false)`

来源：源码第 100 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveEnergyPatch.Postfix(MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState, int)`](LiveRunBridge.cs.md#symbol-74af22831368)；[`NationalSpire.LiveRunBridge._Process(double)`](LiveRunBridge.cs.md#symbol-d7e63bc009ff)；[`NationalSpire.LiveRunBridge.OnHistoryChanged()`](LiveRunBridge.cs.md#symbol-10bf254b1599)；[`NationalSpire.LiveRunBridge.OnWon(MegaCrit.Sts2.Core.Rooms.CombatRoom)`](LiveRunBridge.cs.md#symbol-df914af86259)；[`NationalSpire.LiveRunReadyPatch.Postfix(MegaCrit.Sts2.Core.Nodes.NRun)`](LiveRunBridge.cs.md#symbol-5639c4c6edfd)；[`NationalSpire.LiveSkippedRewardPatch.Postfix(MegaCrit.Sts2.Core.Rewards.CardReward)`](LiveRunBridge.cs.md#symbol-81cb2332df19)；[`NationalSpire.LiveVictoryPatch.Prefix(bool)`](LiveRunBridge.cs.md#symbol-363ebe5825ab)

**调用：** [`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；`Godot.CanvasItem.Hide()`；`Godot.GD.PushWarning(string)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`System.Action.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.LiveRunBridge._commentaryFaulted`；`NationalSpire.LiveRunBridge._faulted`；`NationalSpire.LiveRunBridge._hud`；`NationalSpire.LiveRunBridge.Current`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`current._hud.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: current._hud.Hide();`
- `Godot.GD.PushWarning(string)`；输入表达式：`GD.PushWarning("[NationalSpire] 局内播报暂停：" + e.Message)`；返回值紧邻使用处：`ExpressionStatementSyntax: GD.PushWarning("[NationalSpire] 局内播报暂停：" + e.Message);`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(current._hud)`；返回值紧邻使用处：`IfStatementSyntax: if (IsInstanceValid(current._hud)) current._hud.Hide();`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error(commentaryOnly ? "live.commentary" : "live.update", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error(commentaryOnly ? "live.commentary" : "live.update", e);`
- `System.Action.Invoke()`；输入表达式：`action()`；返回值紧邻使用处：`ExpressionStatementSyntax: action();`

**赋值（含属性/字段和局部值）：**

- `current._commentaryFaulted` = `true`
- `current._faulted` = `true`

<a id="symbol-d7e63bc009ff"></a>

## `NationalSpire.LiveRunBridge._Process(double) — public override void _Process(double delta)`

来源：源码第 114 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`](CareerStore.cs.md#symbol-ead7461ee7cb)；[`NationalSpire.LiveRunBridge.Guard(System.Action, bool)`](LiveRunBridge.cs.md#symbol-65a24868959d)；`Godot.CanvasItem.Hide()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；`NationalSpire.LiveRunBridge._data`；`NationalSpire.LiveRunBridge._ended`；`NationalSpire.LiveRunBridge._faulted`；`NationalSpire.LiveRunBridge._hud`；`NationalSpire.LiveRunBridge._mapCheck`；`NationalSpire.LiveRunBridge._mapOverlay`；`NationalSpire.LiveRunBridge._match`；`NationalSpire.LiveRunBridge._tick`；`NationalSpire.LiveRunBridge.Guard(System.Action, bool)`；`NationalSpire.LiveRunBridge.UpdateRace()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`_hud.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _hud.Hide();`
- `Godot.CanvasItem.Hide()`；输入表达式：`_mapOverlay!.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _mapOverlay!.Hide();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_mapOverlay)`；返回值紧邻使用处：`IfStatementSyntax: if (IsInstanceValid(_mapOverlay)) _mapOverlay!.Hide();`
- `NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；输入表达式：`CareerStore.IsCurrent(_data)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CareerStore.IsCurrent(_data)`
- `NationalSpire.LiveRunBridge.Guard(System.Action, bool)`；输入表达式：`Guard(UpdateRace)`；返回值紧邻使用处：`ExpressionStatementSyntax: Guard(UpdateRace);`

**赋值（含属性/字段和局部值）：**

- `_mapCheck` += `delta`
- `_tick` += `delta`
- `_tick` = `0`

<a id="symbol-03b8653f5c4b"></a>

## `NationalSpire.LiveRunBridge.CopyMap(MegaCrit.Sts2.Core.Map.ActMap, int, bool) — private static List<RouteNode> CopyMap(ActMap map, int act, bool secondBoss)`

来源：源码第 125 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LiveMaps.Copy(MegaCrit.Sts2.Core.Map.ActMap, int, bool)`](LiveMaps.cs.md#symbol-4f5b35fc24c7)

**字段、属性、事件及方法组引用：** `NationalSpire.LiveMaps.Copy(MegaCrit.Sts2.Core.Map.ActMap, int, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LiveMaps.Copy(MegaCrit.Sts2.Core.Map.ActMap, int, bool)`；输入表达式：`LiveMaps.Copy(map, act, secondBoss)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => LiveMaps.Copy(map, act, secondBoss)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0dd1ac28e6cd"></a>

## `NationalSpire.LiveRunBridge.EnsurePlan() — private void EnsurePlan()`

来源：源码第 127 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.UpdateRace()`](LiveRunBridge.cs.md#symbol-9566200347bc)

**调用：** [`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.GameBridge.Characters()`](GameBridge.cs.md#symbol-1233494dda40)；[`NationalSpire.LiveMaps.Read(MegaCrit.Sts2.Core.Runs.IRunState, NationalSpire.CareerMatch, bool)`](LiveMaps.cs.md#symbol-c878186b1e5a)；[`NationalSpire.MatchRules.PrepareOpponent(NationalSpire.CareerData, NationalSpire.CareerMatch)`](MatchRules.cs.md#symbol-cc58cecfce28)；[`NationalSpire.RivalSimulation.Create(NationalSpire.CareerMatch, NationalSpire.CareerPerson, System.Collections.Generic.IReadOnlyList<NationalSpire.RouteNode>, int)`](LiveMatch.cs.md#symbol-d351643744da)；`MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.BroadcastMemory.SharedPhrases`；`NationalSpire.CareerData.BroadcastHistory`；`NationalSpire.CareerMatch.Live`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.GameBridge.Characters()`；`NationalSpire.LiveMaps.Read(MegaCrit.Sts2.Core.Runs.IRunState, NationalSpire.CareerMatch, bool)`；`NationalSpire.LiveMatchState.Commentary`；`NationalSpire.LiveRunBridge._data`；`NationalSpire.LiveRunBridge._match`；`NationalSpire.LiveRunBridge._rival`；`NationalSpire.LiveRunBridge._run`；`NationalSpire.MatchRules.PrepareOpponent(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.RivalSimulation.Create(NationalSpire.CareerMatch, NationalSpire.CareerPerson, System.Collections.Generic.IReadOnlyList<NationalSpire.RouteNode>, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`c.Title.GetFormattedText()`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Title.GetFormattedText() == _rival.Character`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(_data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(_data);`
- `NationalSpire.GameBridge.Characters()`；输入表达式：`GameBridge.Characters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameBridge.Characters().FirstOrDefault`
- `NationalSpire.LiveMaps.Read(MegaCrit.Sts2.Core.Runs.IRunState, NationalSpire.CareerMatch, bool)`；输入表达式：`LiveMaps.Read(_run, _match, false)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = LiveMaps.Read(_run, _match, false)`
- `NationalSpire.MatchRules.PrepareOpponent(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`MatchRules.PrepareOpponent(_data, _match)`；返回值紧邻使用处：`ExpressionStatementSyntax: MatchRules.PrepareOpponent(_data, _match);`
- `NationalSpire.RivalSimulation.Create(NationalSpire.CareerMatch, NationalSpire.CareerPerson, System.Collections.Generic.IReadOnlyList<NationalSpire.RouteNode>, int)`；输入表达式：`RivalSimulation.Create(_match, _rival, maps, hp)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _match.Live = RivalSimulation.Create(_match, _rival, maps, hp)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`GameBridge.Characters().FirstOrDefault(c => c.Title.GetFormattedText() == _rival.Character)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GameBridge.Characters().FirstOrDefault(c => c.Title.GetFormattedText() == _rival.Character)`

**赋值（含属性/字段和局部值）：**

- `_match.Live.Commentary.SharedPhrases` = `_data.BroadcastHistory`
- `_match.Live` = `RivalSimulation.Create(_match, _rival, maps, hp)`

<a id="symbol-9566200347bc"></a>

## `NationalSpire.LiveRunBridge.UpdateRace() — private void UpdateRace()`

来源：源码第 139 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.LiveCommentary.Atmosphere(NationalSpire.BroadcastMemory, NationalSpire.AtmosphereContext, string, double)`](LiveAtmosphere.cs.md#symbol-0b25ed42c5ca)；[`NationalSpire.LiveCommentary.Gap(NationalSpire.BroadcastMemory, int, int, int, int, string, string, int, int, double, string)`](LiveCommentary.cs.md#symbol-dd61728b3570)；[`NationalSpire.LiveCommentary.PlayerLoss(NationalSpire.BroadcastMemory, int, int, int, int, string, string, double)`](LiveMoments.cs.md#symbol-931725c8305b)；[`NationalSpire.LiveCommentary.RebaseGap(NationalSpire.BroadcastMemory, int, int, double)`](LiveCommentary.cs.md#symbol-7a552211c71b)；[`NationalSpire.LiveCommentary.Rival(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, string, string, string, double)`](LiveAtmosphere.cs.md#symbol-5475ccc1b529)；[`NationalSpire.LiveCommentary.Route(NationalSpire.BroadcastMemory, NationalSpire.BattleObservation, string, string, double)`](LiveCommentary.cs.md#symbol-ee9616c0239b)；[`NationalSpire.LiveCommentary.UnknownRoom(NationalSpire.BroadcastMemory, int, string, int, int, int, string, string, double)`](LiveMoments.cs.md#symbol-64cfa3e4c0ca)；[`NationalSpire.LiveRaceHud.SetRace(string, string, int, int, bool, double)`](LiveRaceHud.cs.md#symbol-cfd9d62c7d32)；[`NationalSpire.LiveRunBridge.CalibrateMap(NationalSpire.LiveMatchState)`](LiveRunBridge.cs.md#symbol-7252231ccb09)；[`NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`](LiveRunBridge.cs.md#symbol-c7a514513ce3)；[`NationalSpire.LiveRunBridge.EnsurePlan()`](LiveRunBridge.cs.md#symbol-0dd1ac28e6cd)；[`NationalSpire.LiveRunBridge.ObservePotions(NationalSpire.BroadcastMemory, double)`](LiveRunBridge.cs.md#symbol-e509c91bb4f4)；[`NationalSpire.LiveRunBridge.UpdateMap(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, double)`](LiveRunBridge.cs.md#symbol-cedfec15a9e5)；[`NationalSpire.LiveShopObserver.Read(MegaCrit.Sts2.Core.Runs.RunState, bool)`](LiveShopObserver.cs.md#symbol-76febe44c2f1)；[`NationalSpire.LiveVoices.Ambient(bool, int, double)`](LiveCrowd.cs.md#symbol-789980beddf3)；[`NationalSpire.LiveVoices.LiveVoices(NationalSpire.CareerData, NationalSpire.CareerMatch, NationalSpire.BroadcastMemory, System.Collections.Generic.IEnumerable<string>)`](LiveVoices.cs.md#symbol-3ffa230aebe8)；[`NationalSpire.LiveVoices.Poll(double, double)`](LiveVoices.cs.md#symbol-fc95fe2519bc)；[`NationalSpire.LiveVoices.Rival(int, int, int, int, NationalSpire.RivalProgress, NationalSpire.LiveMatchState, double, System.Collections.Generic.IEnumerable<(string Id, NationalSpire.RivalProgress Progress, int MaxHp)>?)`](LiveVoices.cs.md#symbol-ea0ff7a1e0eb)；[`NationalSpire.LiveVoices.Shop(string, string, int, int, string, int, double, string)`](LiveVoices.cs.md#symbol-44512aead226)；[`NationalSpire.MatchRules.Time(double?)`](MatchRules.cs.md#symbol-13ecc28f8403)；[`NationalSpire.RivalSimulation.At(NationalSpire.LiveMatchState, double)`](LiveMatch.cs.md#symbol-78308976d2a9)；[`NationalSpire.RivalSimulation.RoomName(string)`](LiveMatch.cs.md#symbol-2c599e9f210a)；[`NationalSpire.RivalSimulation.TryAdjustPace(NationalSpire.LiveMatchState, double, int, int)`](LiveMatch.cs.md#symbol-719ee73c10ff)；[`NationalSpire.RivalSimulation.UpgradeHealthPlan(NationalSpire.LiveMatchState, NationalSpire.CareerMatch, NationalSpire.CareerPerson, double)`](LiveMatch.cs.md#symbol-dc9f5474f9f6)；`Godot.CanvasItem.Hide()`；`Godot.GD.PushWarning(string)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`NationalSpire.AtmosphereContext.AtmosphereContext(string, string, string, string, int, int, int, string, int, int, int, int, bool)`；`NationalSpire.BattleObservation.BattleObservation()`；`object.ReferenceEquals(object?, object?)`；`System.Enum.ToString()`

**字段、属性、事件及方法组引用：** `<anonymous type: string match, double seconds, int playerAct, int playerFloor, System.Collections.Generic.List<int> adjustedActs, double finish>.adjustedActs`；`<anonymous type: string match, double seconds, int playerAct, int playerFloor, System.Collections.Generic.List<int> adjustedActs, double finish>.finish`；`<anonymous type: string match, double seconds, int playerAct, int playerFloor, System.Collections.Generic.List<int> adjustedActs, double finish>.match`；`<anonymous type: string match, double seconds, int playerAct, int playerFloor, System.Collections.Generic.List<int> adjustedActs, double finish>.playerAct`；`<anonymous type: string match, double seconds, int playerAct, int playerFloor, System.Collections.Generic.List<int> adjustedActs, double finish>.playerFloor`；`NationalSpire.BattleObservation.Floor`；`NationalSpire.BattleObservation.Hp`；`NationalSpire.BattleObservation.Kind`；`NationalSpire.BattleObservation.MaxHp`；`NationalSpire.BattleObservation.Turn`；`NationalSpire.BroadcastMemory.LastSpoke`；`NationalSpire.BroadcastMemory.RouteFloor`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerMatch.Event`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Live`；`NationalSpire.CareerMatch.OpponentSeconds`；`NationalSpire.CareerMatch.RequiredAscension`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.LiveCommentary.Atmosphere(NationalSpire.BroadcastMemory, NationalSpire.AtmosphereContext, string, double)`；`NationalSpire.LiveCommentary.Gap(NationalSpire.BroadcastMemory, int, int, int, int, string, string, int, int, double, string)`；`NationalSpire.LiveCommentary.PlayerLoss(NationalSpire.BroadcastMemory, int, int, int, int, string, string, double)`；`NationalSpire.LiveCommentary.RebaseGap(NationalSpire.BroadcastMemory, int, int, double)`；`NationalSpire.LiveCommentary.Rival(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, string, string, string, double)`；`NationalSpire.LiveCommentary.Route(NationalSpire.BroadcastMemory, NationalSpire.BattleObservation, string, string, double)`；`NationalSpire.LiveCommentary.UnknownRoom(NationalSpire.BroadcastMemory, int, string, int, int, int, string, string, double)`；`NationalSpire.LiveMatchState.Commentary`；`NationalSpire.LiveMatchState.MaxHp`；`NationalSpire.LiveMatchState.PaceAdjustedActs`；`NationalSpire.LiveMatchState.PaceNeutralUntil`；`NationalSpire.LiveMatchState.Steps`；`NationalSpire.LiveRaceHud.SetRace(string, string, int, int, bool, double)`；`NationalSpire.LiveRunBridge._battle`；`NationalSpire.LiveRunBridge._commentaryFaulted`；`NationalSpire.LiveRunBridge._data`；`NationalSpire.LiveRunBridge._hud`；`NationalSpire.LiveRunBridge._lastMap`；`NationalSpire.LiveRunBridge._lossFloor`；`NationalSpire.LiveRunBridge._mapCheck`；`NationalSpire.LiveRunBridge._mapCompatible`；`NationalSpire.LiveRunBridge._mapOverlay`；`NationalSpire.LiveRunBridge._mapPoints`；`NationalSpire.LiveRunBridge._mapRetryAt`；`NationalSpire.LiveRunBridge._match`；`NationalSpire.LiveRunBridge._pendingLoss`；`NationalSpire.LiveRunBridge._player`；`NationalSpire.LiveRunBridge._rival`；`NationalSpire.LiveRunBridge._run`；`NationalSpire.LiveRunBridge._shop`；`NationalSpire.LiveRunBridge._voices`；`NationalSpire.LiveRunBridge.CalibrateMap(NationalSpire.LiveMatchState)`；`NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`；`NationalSpire.LiveRunBridge.EnsurePlan()`；`NationalSpire.LiveRunBridge.ObservePotions(NationalSpire.BroadcastMemory, double)`；`NationalSpire.LiveRunBridge.UpdateMap(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, double)`；`NationalSpire.LiveShopChange.CardType`；`NationalSpire.LiveShopChange.DeckSize`；`NationalSpire.LiveShopChange.Gold`；`NationalSpire.LiveShopChange.Item`；`NationalSpire.LiveShopChange.Kind`；`NationalSpire.LiveShopObserver.Read(MegaCrit.Sts2.Core.Runs.RunState, bool)`；`NationalSpire.LiveVoices.Ambient(bool, int, double)`；`NationalSpire.LiveVoices.Poll(double, double)`；`NationalSpire.LiveVoices.Rival(int, int, int, int, NationalSpire.RivalProgress, NationalSpire.LiveMatchState, double, System.Collections.Generic.IEnumerable<(string Id, NationalSpire.RivalProgress Progress, int MaxHp)>?)`；`NationalSpire.LiveVoices.Shop(string, string, int, int, string, int, double, string)`；`NationalSpire.MatchRules.Time(double?)`；`NationalSpire.RivalProgress.Dead`；`NationalSpire.RivalProgress.Finished`；`NationalSpire.RivalProgress.Hp`；`NationalSpire.RivalProgress.Step`；`NationalSpire.RivalSimulation.At(NationalSpire.LiveMatchState, double)`；`NationalSpire.RivalSimulation.RoomName(string)`；`NationalSpire.RivalSimulation.TryAdjustPace(NationalSpire.LiveMatchState, double, int, int)`；`NationalSpire.RivalSimulation.UpgradeHealthPlan(NationalSpire.LiveMatchState, NationalSpire.CareerMatch, NationalSpire.CareerPerson, double)`；`NationalSpire.RivalStep.Act`；`NationalSpire.RivalStep.End`；`NationalSpire.RivalStep.Floor`；`NationalSpire.RivalStep.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`_mapOverlay!.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _mapOverlay!.Hide();`
- `Godot.GD.PushWarning(string)`；输入表达式：`GD.PushWarning("[NationalSpire] 地图标记等待重建：" + e.Message)`；返回值紧邻使用处：`ExpressionStatementSyntax: GD.PushWarning("[NationalSpire] 地图标记等待重建：" + e.Message);`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_mapOverlay)`；返回值紧邻使用处：`IfStatementSyntax: if (IsInstanceValid(_mapOverlay)) _mapOverlay!.Hide();`
- `NationalSpire.AtmosphereContext.AtmosphereContext(string, string, string, string, int, int, int, string, int, int, int, int, bool)`；输入表达式：`new AtmosphereContext(CareerEngine.Name(_data), _rival.PublicName, _match.Event,                  _rival.Character, _match.RequiredAscension, _run.TotalFloor, _run.CurrentActIndex, _run.CurrentRoom?.RoomType.ToString() ?? "",                  _player.Creature.CurrentHp, _player.Creature.MaxHp, _player.Gold, _battle?.Turn ?? 0, CombatManager.Instance.IsInProgress)`；返回值紧邻使用处：`ArgumentSyntax: new AtmosphereContext(CareerEngine.Name(_data), _rival.PublicName, _match.Event,                  _rival.Character, _match.RequiredAscension, _run.TotalFloor, _run.CurrentActIndex, _run.CurrentRoom?.RoomType.ToString() ?? "",                  _player.Creature.CurrentHp, _player.Creature.MaxHp, _player.Gold, _battle?.Turn ?? 0, CombatManager.Instance.IsInProgress)`
- `NationalSpire.BattleObservation.BattleObservation()`；输入表达式：`new BattleObservation { Floor = _run.TotalFloor, Kind = _run.CurrentMapPoint?.PointType.ToString() ?? "", Hp = _player.Creature.CurrentHp, MaxHp = _player.Creature.MaxHp }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BattleObservation { Floor = _run.TotalFloor, Kind = _run.CurrentMapPoint?.PointType.ToString() ?? "", Hp = _player.Creature.CurrentHp, MaxHp = _player.Creature.MaxHp }`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(_data)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.Name(_data)`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(_data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(_data);`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("live.map", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("live.map", e);`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("live.pace_adjusted", new { match = _match.Id, seconds, playerAct = _run.CurrentActIndex,                  playerFloor = _run.TotalFloor, adjustedActs = live.PaceAdjustedActs, finish = live.Steps[^1].End })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("live.pace_adjusted", new { match = _match.Id, seconds, playerAct = _run.CurrentActIndex,                  playerFloor = _run.TotalFloor, adjustedActs = live.PaceAdjustedActs, finish = live.Steps[^1].End });`
- `NationalSpire.LiveCommentary.Atmosphere(NationalSpire.BroadcastMemory, NationalSpire.AtmosphereContext, string, double)`；输入表达式：`LiveCommentary.Atmosphere(live.Commentary, new AtmosphereContext(CareerEngine.Name(_data), _rival.PublicName, _match.Event,                  _rival.Character, _match.RequiredAscension, _run.TotalFloor, _run.CurrentActIndex, _run.CurrentRoom?.RoomType.ToString() ?? "",                  _player.Creature.CurrentHp, _player.Creature.MaxHp, _player.Gold, _battle?.Turn ?? 0, CombatManager.Instance.IsInProgress), _match.Seed, seconds)`；返回值紧邻使用处：`ArgumentSyntax: LiveCommentary.Atmosphere(live.Commentary, new AtmosphereContext(CareerEngine.Name(_data), _rival.PublicName, _match.Event,                  _rival.Character, _match.RequiredAscension, _run.TotalFloor, _run.CurrentActIndex, _run.CurrentRoom?.RoomType.ToString() ?? "",                  _player.Creature.CurrentHp, _player.Creature.MaxHp, _player.Gold, _battle?.Turn ?? 0, CombatManager.Instance.IsInProgress), _match.Seed, seconds)`
- `NationalSpire.LiveCommentary.Gap(NationalSpire.BroadcastMemory, int, int, int, int, string, string, int, int, double, string)`；输入表达式：`LiveCommentary.Gap(live.Commentary, _run.TotalFloor, progress.Step.Floor, _run.CurrentActIndex, progress.Step.Act,                  CareerEngine.Name(_data), _rival.PublicName, _player.Creature.CurrentHp, _player.Creature.MaxHp, seconds, _match.Seed)`；返回值紧邻使用处：`ArgumentSyntax: LiveCommentary.Gap(live.Commentary, _run.TotalFloor, progress.Step.Floor, _run.CurrentActIndex, progress.Step.Act,                  CareerEngine.Name(_data), _rival.PublicName, _player.Creature.CurrentHp, _player.Creature.MaxHp, seconds, _match.Seed)`
- `NationalSpire.LiveCommentary.PlayerLoss(NationalSpire.BroadcastMemory, int, int, int, int, string, string, double)`；输入表达式：`LiveCommentary.PlayerLoss(live.Commentary, _run.TotalFloor, _pendingLoss, _player.Creature.CurrentHp,                          _player.Creature.MaxHp, CareerEngine.Name(_data), _match.Seed, seconds)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = LiveCommentary.PlayerLoss(live.Commentary, _run.TotalFloor, _pendingLoss, _player.Creature.CurrentHp,                          _player.Creature.MaxHp, CareerEngine.Name(_data), _match.Seed, seconds)`
- `NationalSpire.LiveCommentary.RebaseGap(NationalSpire.BroadcastMemory, int, int, double)`；输入表达式：`LiveCommentary.RebaseGap(live.Commentary, _run.TotalFloor, progress.Step.Floor, seconds)`；返回值紧邻使用处：`ExpressionStatementSyntax: LiveCommentary.RebaseGap(live.Commentary, _run.TotalFloor, progress.Step.Floor, seconds);`
- `NationalSpire.LiveCommentary.Rival(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, string, string, string, double)`；输入表达式：`LiveCommentary.Rival(live, progress, CareerEngine.Name(_data), _rival.PublicName, _match.Seed, seconds)`；返回值紧邻使用处：`ArgumentSyntax: LiveCommentary.Rival(live, progress, CareerEngine.Name(_data), _rival.PublicName, _match.Seed, seconds)`
- `NationalSpire.LiveCommentary.Route(NationalSpire.BroadcastMemory, NationalSpire.BattleObservation, string, string, double)`；输入表达式：`LiveCommentary.Route(live.Commentary, observation, CareerEngine.Name(_data), _match.Seed, seconds)`；返回值紧邻使用处：`ArgumentSyntax: LiveCommentary.Route(live.Commentary, observation, CareerEngine.Name(_data), _match.Seed, seconds)`
- `NationalSpire.LiveCommentary.UnknownRoom(NationalSpire.BroadcastMemory, int, string, int, int, int, string, string, double)`；输入表达式：`LiveCommentary.UnknownRoom(live.Commentary, _run.TotalFloor, _run.CurrentRoom?.RoomType.ToString() ?? "",                      _player.Creature.CurrentHp, _player.Creature.MaxHp, _player.Gold, CareerEngine.Name(_data), _match.Seed, seconds)`；返回值紧邻使用处：`ArgumentSyntax: LiveCommentary.UnknownRoom(live.Commentary, _run.TotalFloor, _run.CurrentRoom?.RoomType.ToString() ?? "",                      _player.Creature.CurrentHp, _player.Creature.MaxHp, _player.Gold, CareerEngine.Name(_data), _match.Seed, seconds)`
- `NationalSpire.LiveRaceHud.SetRace(string, string, int, int, bool, double)`；输入表达式：`_hud.SetRace(_rival.PublicName, status, progress.Hp, live.MaxHp, progress.Step.Act != _run.CurrentActIndex, seconds)`；返回值紧邻使用处：`ExpressionStatementSyntax: _hud.SetRace(_rival.PublicName, status, progress.Hp, live.MaxHp, progress.Step.Act != _run.CurrentActIndex, seconds);`
- `NationalSpire.LiveRunBridge.CalibrateMap(NationalSpire.LiveMatchState)`；输入表达式：`CalibrateMap(live)`；返回值紧邻使用处：`ExpressionStatementSyntax: CalibrateMap(live);`
- `NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`；输入表达式：`Emit(_voices.Poll(seconds, live.Commentary.LastSpoke))`；返回值紧邻使用处：`ExpressionStatementSyntax: Emit(_voices.Poll(seconds, live.Commentary.LastSpoke));`
- `NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`；输入表达式：`Emit(injury)`；返回值紧邻使用处：`ExpressionStatementSyntax: Emit(injury);`
- `NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`；输入表达式：`Emit(LiveCommentary.Atmosphere(live.Commentary, new AtmosphereContext(CareerEngine.Name(_data), _rival.PublicName, _match.Event,                  _rival.Character, _match.RequiredAscension, _run.TotalFloor, _run.CurrentActIndex, _run.CurrentRoom?.RoomType.ToString() ?? "",                  _player.Creature.CurrentHp, _player.Creature.MaxHp, _player.Gold, _battle?.Turn ?? 0, CombatManager.Instance.IsInProgress), _match.Seed, seconds))`；返回值紧邻使用处：`ExpressionStatementSyntax: Emit(LiveCommentary.Atmosphere(live.Commentary, new AtmosphereContext(CareerEngine.Name(_data), _rival.PublicName, _match.Event,                  _rival.Character, _match.RequiredAscension, _run.TotalFloor, _run.CurrentActIndex, _run.CurrentRoom?.RoomType.ToString() ?? "",                  _player.Creature.CurrentHp, _player.Creature.MaxHp, _player.Gold, _battle?.Turn ?? 0, CombatManager.Instance.IsInProgress), _match.Seed, seconds));`
- `NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`；输入表达式：`Emit(LiveCommentary.Gap(live.Commentary, _run.TotalFloor, progress.Step.Floor, _run.CurrentActIndex, progress.Step.Act,                  CareerEngine.Name(_data), _rival.PublicName, _player.Creature.CurrentHp, _player.Creature.MaxHp, seconds, _match.Seed))`；返回值紧邻使用处：`ExpressionStatementSyntax: Emit(LiveCommentary.Gap(live.Commentary, _run.TotalFloor, progress.Step.Floor, _run.CurrentActIndex, progress.Step.Act,                  CareerEngine.Name(_data), _rival.PublicName, _player.Creature.CurrentHp, _player.Creature.MaxHp, seconds, _match.Seed));`
- `NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`；输入表达式：`Emit(LiveCommentary.Rival(live, progress, CareerEngine.Name(_data), _rival.PublicName, _match.Seed, seconds))`；返回值紧邻使用处：`ExpressionStatementSyntax: Emit(LiveCommentary.Rival(live, progress, CareerEngine.Name(_data), _rival.PublicName, _match.Seed, seconds));`
- `NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`；输入表达式：`Emit(LiveCommentary.Route(live.Commentary, observation, CareerEngine.Name(_data), _match.Seed, seconds))`；返回值紧邻使用处：`ExpressionStatementSyntax: Emit(LiveCommentary.Route(live.Commentary, observation, CareerEngine.Name(_data), _match.Seed, seconds));`
- `NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`；输入表达式：`Emit(LiveCommentary.UnknownRoom(live.Commentary, _run.TotalFloor, _run.CurrentRoom?.RoomType.ToString() ?? "",                      _player.Creature.CurrentHp, _player.Creature.MaxHp, _player.Gold, CareerEngine.Name(_data), _match.Seed, seconds))`；返回值紧邻使用处：`ExpressionStatementSyntax: Emit(LiveCommentary.UnknownRoom(live.Commentary, _run.TotalFloor, _run.CurrentRoom?.RoomType.ToString() ?? "",                      _player.Creature.CurrentHp, _player.Creature.MaxHp, _player.Gold, CareerEngine.Name(_data), _match.Seed, seconds));`
- `NationalSpire.LiveRunBridge.EnsurePlan()`；输入表达式：`EnsurePlan()`；返回值紧邻使用处：`ExpressionStatementSyntax: EnsurePlan();`
- `NationalSpire.LiveRunBridge.ObservePotions(NationalSpire.BroadcastMemory, double)`；输入表达式：`ObservePotions(live.Commentary, seconds)`；返回值紧邻使用处：`ExpressionStatementSyntax: ObservePotions(live.Commentary, seconds);`
- `NationalSpire.LiveRunBridge.UpdateMap(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, double)`；输入表达式：`UpdateMap(live, progress, seconds)`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateMap(live, progress, seconds);`
- `NationalSpire.LiveShopObserver.Read(MegaCrit.Sts2.Core.Runs.RunState, bool)`；输入表达式：`_shop.Read(_run)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var change in _shop.Read(_run))                  _voices.Shop(change.Kind, change.Item, change.DeckSize, change.Gold, CareerEngine.Name(_data), _run.TotalFloor, seconds, change.CardType);`
- `NationalSpire.LiveVoices.Ambient(bool, int, double)`；输入表达式：`_voices.Ambient(CombatManager.Instance.IsInProgress && !CombatManager.Instance.IsEnding, _run.TotalFloor, seconds)`；返回值紧邻使用处：`ExpressionStatementSyntax: _voices.Ambient(CombatManager.Instance.IsInProgress && !CombatManager.Instance.IsEnding, _run.TotalFloor, seconds);`
- `NationalSpire.LiveVoices.LiveVoices(NationalSpire.CareerData, NationalSpire.CareerMatch, NationalSpire.BroadcastMemory, System.Collections.Generic.IEnumerable<string>)`；输入表达式：`new(_data, _match, live.Commentary, [_rival.Id])`；返回值紧邻使用处：`AssignmentExpressionSyntax: _voices ??= new(_data, _match, live.Commentary, [_rival.Id])`
- `NationalSpire.LiveVoices.Poll(double, double)`；输入表达式：`_voices.Poll(seconds, live.Commentary.LastSpoke)`；返回值紧邻使用处：`ArgumentSyntax: _voices.Poll(seconds, live.Commentary.LastSpoke)`
- `NationalSpire.LiveVoices.Rival(int, int, int, int, NationalSpire.RivalProgress, NationalSpire.LiveMatchState, double, System.Collections.Generic.IEnumerable<(string Id, NationalSpire.RivalProgress Progress, int MaxHp)>?)`；输入表达式：`_voices.Rival(_run.TotalFloor, _run.CurrentActIndex, _player.Creature.CurrentHp, _player.Creature.MaxHp, progress, live, seconds)`；返回值紧邻使用处：`ExpressionStatementSyntax: _voices.Rival(_run.TotalFloor, _run.CurrentActIndex, _player.Creature.CurrentHp, _player.Creature.MaxHp, progress, live, seconds);`
- `NationalSpire.LiveVoices.Shop(string, string, int, int, string, int, double, string)`；输入表达式：`_voices.Shop(change.Kind, change.Item, change.DeckSize, change.Gold, CareerEngine.Name(_data), _run.TotalFloor, seconds, change.CardType)`；返回值紧邻使用处：`ExpressionStatementSyntax: _voices.Shop(change.Kind, change.Item, change.DeckSize, change.Gold, CareerEngine.Name(_data), _run.TotalFloor, seconds, change.CardType);`
- `NationalSpire.MatchRules.Time(double?)`；输入表达式：`MatchRules.Time(_match.OpponentSeconds)`；返回值紧邻使用处：`BinaryExpressionSyntax: "已通关 · " + MatchRules.Time(_match.OpponentSeconds)`
- `NationalSpire.RivalSimulation.At(NationalSpire.LiveMatchState, double)`；输入表达式：`RivalSimulation.At(live, seconds)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RivalSimulation.At(live, seconds)`
- `NationalSpire.RivalSimulation.RoomName(string)`；输入表达式：`RivalSimulation.RoomName(progress.Step.Kind)`；返回值紧邻使用处：`InterpolationSyntax: {RivalSimulation.RoomName(progress.Step.Kind)}`
- `NationalSpire.RivalSimulation.TryAdjustPace(NationalSpire.LiveMatchState, double, int, int)`；输入表达式：`RivalSimulation.TryAdjustPace(live, seconds, _run.CurrentActIndex, _run.TotalFloor)`；返回值紧邻使用处：`IfStatementSyntax: if (RivalSimulation.TryAdjustPace(live, seconds, _run.CurrentActIndex, _run.TotalFloor))          {              Diagnostics.Record("live.pace_adjusted", new { match = _match.Id, seconds, playerAct = _run.CurrentActIndex,                  playerFloor = _run.TotalFloor, adjustedActs = live.PaceAdjustedActs, finish = live.Steps[^1].End });              CareerStore.Save(_data);          }`
- `NationalSpire.RivalSimulation.UpgradeHealthPlan(NationalSpire.LiveMatchState, NationalSpire.CareerMatch, NationalSpire.CareerPerson, double)`；输入表达式：`RivalSimulation.UpgradeHealthPlan(live, _match, _rival, seconds)`；返回值紧邻使用处：`IfStatementSyntax: if (RivalSimulation.UpgradeHealthPlan(live, _match, _rival, seconds)) CareerStore.Save(_data);`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(_lastMap, _run.Map)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ReferenceEquals(_lastMap, _run.Map)`
- `System.Enum.ToString()`；输入表达式：`.PointType.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _run.CurrentMapPoint?.PointType.ToString()`
- `System.Enum.ToString()`；输入表达式：`.RoomType.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _run.CurrentRoom?.RoomType.ToString()`

**赋值（含属性/字段和局部值）：**

- `_lastMap` = `_run.Map`
- `_mapCheck` = `0`
- `_mapPoints` = `null`
- `_mapRetryAt` = `seconds + 5`
- `_pendingLoss` = `0`
- `_voices` ??= `new(_data, _match, live.Commentary, [_rival.Id])`
- `Floor` = `_run.TotalFloor`
- `Hp` = `_player.Creature.CurrentHp`
- `Kind` = `_run.CurrentMapPoint?.PointType.ToString() ?? ""`
- `MaxHp` = `_player.Creature.MaxHp`
- `status` += `" · 独立路线"`

<a id="symbol-e509c91bb4f4"></a>

## `NationalSpire.LiveRunBridge.ObservePotions(NationalSpire.BroadcastMemory, double) — private void ObservePotions(BroadcastMemory memory, double seconds)`

来源：源码第 210 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.UpdateRace()`](LiveRunBridge.cs.md#symbol-9566200347bc)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.GameText.Plain(string)`](GameText.cs.md#symbol-e2c48dec4564)；[`NationalSpire.LiveCommentary.DiscardPotion(NationalSpire.BroadcastMemory, string, int, int, int, string, string, double)`](LiveMoments.cs.md#symbol-27c5783971c3)；[`NationalSpire.LiveCommentary.Potion(NationalSpire.BroadcastMemory, string, int, int, string, string, double)`](LiveMoments.cs.md#symbol-4eaf89b958c5)；[`NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`](LiveRunBridge.cs.md#symbol-c7a514513ce3)；`MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；`MegaCrit.Sts2.Core.Models.ModelDb.GetByIdOrNull<T>(MegaCrit.Sts2.Core.Models.ModelId)`；`MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry.GetEntry(ulong)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.GameText.Plain(string)`；`NationalSpire.LiveCommentary.DiscardPotion(NationalSpire.BroadcastMemory, string, int, int, int, string, string, double)`；`NationalSpire.LiveCommentary.Potion(NationalSpire.BroadcastMemory, string, int, int, string, string, double)`；`NationalSpire.LiveRunBridge._data`；`NationalSpire.LiveRunBridge._discardedPotions`；`NationalSpire.LiveRunBridge._match`；`NationalSpire.LiveRunBridge._observedPotions`；`NationalSpire.LiveRunBridge._player`；`NationalSpire.LiveRunBridge._potionFloor`；`NationalSpire.LiveRunBridge._run`；`NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`model.Title.GetFormattedText()`；返回值紧邻使用处：`ArgumentSyntax: model.Title.GetFormattedText()`
- `MegaCrit.Sts2.Core.Models.ModelDb.GetByIdOrNull<T>(MegaCrit.Sts2.Core.Models.ModelId)`；输入表达式：`ModelDb.GetByIdOrNull<PotionModel>(roomHistory.PotionDiscarded[_discardedPotions++])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ModelDb.GetByIdOrNull<PotionModel>(roomHistory.PotionDiscarded[_discardedPotions++])`
- `MegaCrit.Sts2.Core.Models.ModelDb.GetByIdOrNull<T>(MegaCrit.Sts2.Core.Models.ModelId)`；输入表达式：`ModelDb.GetByIdOrNull<PotionModel>(used[_observedPotions++])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ModelDb.GetByIdOrNull<PotionModel>(used[_observedPotions++])`
- `MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry.GetEntry(ulong)`；输入表达式：`.GetEntry(_player.NetId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _run.CurrentMapPointHistoryEntry?.GetEntry(_player.NetId)`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(_data)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.Name(_data)`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(model.Title.GetFormattedText())`；返回值紧邻使用处：`ArgumentSyntax: GameText.Plain(model.Title.GetFormattedText())`
- `NationalSpire.LiveCommentary.DiscardPotion(NationalSpire.BroadcastMemory, string, int, int, int, string, string, double)`；输入表达式：`LiveCommentary.DiscardPotion(memory, GameText.Plain(model.Title.GetFormattedText()), _player.Creature.CurrentHp,                  _player.Creature.MaxHp, _player.Potions.Count(), CareerEngine.Name(_data), _match.Seed, seconds)`；返回值紧邻使用处：`ArgumentSyntax: LiveCommentary.DiscardPotion(memory, GameText.Plain(model.Title.GetFormattedText()), _player.Creature.CurrentHp,                  _player.Creature.MaxHp, _player.Potions.Count(), CareerEngine.Name(_data), _match.Seed, seconds)`
- `NationalSpire.LiveCommentary.Potion(NationalSpire.BroadcastMemory, string, int, int, string, string, double)`；输入表达式：`LiveCommentary.Potion(memory, GameText.Plain(model.Title.GetFormattedText()), _player.Creature.CurrentHp,                  _player.Creature.MaxHp, CareerEngine.Name(_data), _match.Seed, seconds)`；返回值紧邻使用处：`ArgumentSyntax: LiveCommentary.Potion(memory, GameText.Plain(model.Title.GetFormattedText()), _player.Creature.CurrentHp,                  _player.Creature.MaxHp, CareerEngine.Name(_data), _match.Seed, seconds)`
- `NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`；输入表达式：`Emit(LiveCommentary.DiscardPotion(memory, GameText.Plain(model.Title.GetFormattedText()), _player.Creature.CurrentHp,                  _player.Creature.MaxHp, _player.Potions.Count(), CareerEngine.Name(_data), _match.Seed, seconds))`；返回值紧邻使用处：`ExpressionStatementSyntax: Emit(LiveCommentary.DiscardPotion(memory, GameText.Plain(model.Title.GetFormattedText()), _player.Creature.CurrentHp,                  _player.Creature.MaxHp, _player.Potions.Count(), CareerEngine.Name(_data), _match.Seed, seconds));`
- `NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`；输入表达式：`Emit(LiveCommentary.Potion(memory, GameText.Plain(model.Title.GetFormattedText()), _player.Creature.CurrentHp,                  _player.Creature.MaxHp, CareerEngine.Name(_data), _match.Seed, seconds))`；返回值紧邻使用处：`ExpressionStatementSyntax: Emit(LiveCommentary.Potion(memory, GameText.Plain(model.Title.GetFormattedText()), _player.Creature.CurrentHp,                  _player.Creature.MaxHp, CareerEngine.Name(_data), _match.Seed, seconds));`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`_player.Potions.Count()`；返回值紧邻使用处：`ArgumentSyntax: _player.Potions.Count()`

**赋值（含属性/字段和局部值）：**

- `_discardedPotions` = `0`
- `_observedPotions` = `_discardedPotions = 0`
- `_potionFloor` = `_run.TotalFloor`

<a id="symbol-1d29bfc1f633"></a>

## `NationalSpire.LiveRunBridge.EnergyGained(MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState, int) — public void EnergyGained(PlayerCombatState state, int gain)`

来源：源码第 232 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveEnergyPatch.Postfix(MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState, int)`](LiveRunBridge.cs.md#symbol-74af22831368)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.LiveCommentary.Energy(NationalSpire.BroadcastMemory, int, int, int, int, string, string, double)`](LiveMoments.cs.md#symbol-2a9d8e18ab22)；[`NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`](LiveRunBridge.cs.md#symbol-c7a514513ce3)；`object.ReferenceEquals(object?, object?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerMatch.Live`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.LiveCommentary.Energy(NationalSpire.BroadcastMemory, int, int, int, int, string, string, double)`；`NationalSpire.LiveMatchState.Commentary`；`NationalSpire.LiveRunBridge._commentaryFaulted`；`NationalSpire.LiveRunBridge._data`；`NationalSpire.LiveRunBridge._ended`；`NationalSpire.LiveRunBridge._faulted`；`NationalSpire.LiveRunBridge._match`；`NationalSpire.LiveRunBridge._player`；`NationalSpire.LiveRunBridge._run`；`NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(_data)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.Name(_data)`
- `NationalSpire.LiveCommentary.Energy(NationalSpire.BroadcastMemory, int, int, int, int, string, string, double)`；输入表达式：`LiveCommentary.Energy(_match.Live.Commentary, _run.TotalFloor, state.TurnNumber, gain, state.Energy,              CareerEngine.Name(_data), _match.Seed, RunManager.Instance.RunTime)`；返回值紧邻使用处：`ArgumentSyntax: LiveCommentary.Energy(_match.Live.Commentary, _run.TotalFloor, state.TurnNumber, gain, state.Energy,              CareerEngine.Name(_data), _match.Seed, RunManager.Instance.RunTime)`
- `NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`；输入表达式：`Emit(LiveCommentary.Energy(_match.Live.Commentary, _run.TotalFloor, state.TurnNumber, gain, state.Energy,              CareerEngine.Name(_data), _match.Seed, RunManager.Instance.RunTime))`；返回值紧邻使用处：`ExpressionStatementSyntax: Emit(LiveCommentary.Energy(_match.Live.Commentary, _run.TotalFloor, state.TurnNumber, gain, state.Energy,              CareerEngine.Name(_data), _match.Seed, RunManager.Instance.RunTime));`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(state, _player.PlayerCombatState)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ReferenceEquals(state, _player.PlayerCombatState)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c012e2474371"></a>

## `NationalSpire.LiveRunBridge.RewardSkipped(MegaCrit.Sts2.Core.Rewards.CardReward) — public void RewardSkipped(CardReward reward)`

来源：源码第 239 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveSkippedRewardPatch.Postfix(MegaCrit.Sts2.Core.Rewards.CardReward)`](LiveRunBridge.cs.md#symbol-81cb2332df19)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.LiveCommentary.SkipReward(NationalSpire.BroadcastMemory, int, int, int, string, string, double)`](LiveMoments.cs.md#symbol-fa1a12d0a085)；[`NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`](LiveRunBridge.cs.md#symbol-c7a514513ce3)；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerMatch.Live`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.LiveCommentary.SkipReward(NationalSpire.BroadcastMemory, int, int, int, string, string, double)`；`NationalSpire.LiveMatchState.Commentary`；`NationalSpire.LiveRunBridge._commentaryFaulted`；`NationalSpire.LiveRunBridge._data`；`NationalSpire.LiveRunBridge._ended`；`NationalSpire.LiveRunBridge._faulted`；`NationalSpire.LiveRunBridge._match`；`NationalSpire.LiveRunBridge._player`；`NationalSpire.LiveRunBridge._run`；`NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(_data)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.Name(_data)`
- `NationalSpire.LiveCommentary.SkipReward(NationalSpire.BroadcastMemory, int, int, int, string, string, double)`；输入表达式：`LiveCommentary.SkipReward(_match.Live.Commentary, _run.TotalFloor, reward.Cards.Count(), _player.Deck.Cards.Count,              CareerEngine.Name(_data), _match.Seed, RunManager.Instance.RunTime)`；返回值紧邻使用处：`ArgumentSyntax: LiveCommentary.SkipReward(_match.Live.Commentary, _run.TotalFloor, reward.Cards.Count(), _player.Deck.Cards.Count,              CareerEngine.Name(_data), _match.Seed, RunManager.Instance.RunTime)`
- `NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`；输入表达式：`Emit(LiveCommentary.SkipReward(_match.Live.Commentary, _run.TotalFloor, reward.Cards.Count(), _player.Deck.Cards.Count,              CareerEngine.Name(_data), _match.Seed, RunManager.Instance.RunTime))`；返回值紧邻使用处：`ExpressionStatementSyntax: Emit(LiveCommentary.SkipReward(_match.Live.Commentary, _run.TotalFloor, reward.Cards.Count(), _player.Deck.Cards.Count,              CareerEngine.Name(_data), _match.Seed, RunManager.Instance.RunTime));`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`reward.Cards.Count()`；返回值紧邻使用处：`ArgumentSyntax: reward.Cards.Count()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d5b5bb6d87cd"></a>

## `NationalSpire.LiveRunBridge.RunEnded(bool) — public void RunEnded(bool victory)`

来源：源码第 245 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveVictoryPatch.Prefix(bool)`](LiveRunBridge.cs.md#symbol-363ebe5825ab)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`](CareerStore.cs.md#symbol-ead7461ee7cb)；[`NationalSpire.LiveCommentary.PlayerVictory(NationalSpire.BroadcastMemory, bool, double, int, int, string, string, string)`](LiveMoments.cs.md#symbol-44f4d20ad966)；[`NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`](LiveRunBridge.cs.md#symbol-c7a514513ce3)；[`NationalSpire.MatchRules.Compare(NationalSpire.RunPerformance, NationalSpire.RunPerformance)`](MatchRules.cs.md#symbol-08f53c7e29ff)；`NationalSpire.RunPerformance.RunPerformance(bool, int, double)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Live`；`NationalSpire.CareerMatch.OpponentFloor`；`NationalSpire.CareerMatch.OpponentSeconds`；`NationalSpire.CareerMatch.OpponentWon`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；`NationalSpire.LiveCommentary.PlayerVictory(NationalSpire.BroadcastMemory, bool, double, int, int, string, string, string)`；`NationalSpire.LiveMatchState.Commentary`；`NationalSpire.LiveRunBridge._data`；`NationalSpire.LiveRunBridge._ended`；`NationalSpire.LiveRunBridge._faulted`；`NationalSpire.LiveRunBridge._match`；`NationalSpire.LiveRunBridge._player`；`NationalSpire.LiveRunBridge._rival`；`NationalSpire.LiveRunBridge._run`；`NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`；`NationalSpire.MatchRules.Compare(NationalSpire.RunPerformance, NationalSpire.RunPerformance)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(_data)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.Name(_data)`
- `NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；输入表达式：`CareerStore.IsCurrent(_data)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CareerStore.IsCurrent(_data)`
- `NationalSpire.LiveCommentary.PlayerVictory(NationalSpire.BroadcastMemory, bool, double, int, int, string, string, string)`；输入表达式：`LiveCommentary.PlayerVictory(_match.Live.Commentary, winner, seconds, _player.Creature.CurrentHp,              _player.Creature.MaxHp, CareerEngine.Name(_data), _rival.PublicName, _match.Seed)`；返回值紧邻使用处：`ArgumentSyntax: LiveCommentary.PlayerVictory(_match.Live.Commentary, winner, seconds, _player.Creature.CurrentHp,              _player.Creature.MaxHp, CareerEngine.Name(_data), _rival.PublicName, _match.Seed)`
- `NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`；输入表达式：`Emit(LiveCommentary.PlayerVictory(_match.Live.Commentary, winner, seconds, _player.Creature.CurrentHp,              _player.Creature.MaxHp, CareerEngine.Name(_data), _rival.PublicName, _match.Seed))`；返回值紧邻使用处：`ExpressionStatementSyntax: Emit(LiveCommentary.PlayerVictory(_match.Live.Commentary, winner, seconds, _player.Creature.CurrentHp,              _player.Creature.MaxHp, CareerEngine.Name(_data), _rival.PublicName, _match.Seed));`
- `NationalSpire.MatchRules.Compare(NationalSpire.RunPerformance, NationalSpire.RunPerformance)`；输入表达式：`MatchRules.Compare(new(true, _run.TotalFloor, seconds), new(true, _match.OpponentFloor, _match.OpponentSeconds.Value))`；返回值紧邻使用处：`BinaryExpressionSyntax: MatchRules.Compare(new(true, _run.TotalFloor, seconds), new(true, _match.OpponentFloor, _match.OpponentSeconds.Value)) > 0`
- `NationalSpire.RunPerformance.RunPerformance(bool, int, double)`；输入表达式：`new(true, _match.OpponentFloor, _match.OpponentSeconds.Value)`；返回值紧邻使用处：`ArgumentSyntax: new(true, _match.OpponentFloor, _match.OpponentSeconds.Value)`
- `NationalSpire.RunPerformance.RunPerformance(bool, int, double)`；输入表达式：`new(true, _run.TotalFloor, seconds)`；返回值紧邻使用处：`ArgumentSyntax: new(true, _run.TotalFloor, seconds)`

**赋值（含属性/字段和局部值）：**

- `_ended` = `true`

<a id="symbol-7252231ccb09"></a>

## `NationalSpire.LiveRunBridge.CalibrateMap(NationalSpire.LiveMatchState) — private void CalibrateMap(LiveMatchState live)`

来源：源码第 256 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.UpdateRace()`](LiveRunBridge.cs.md#symbol-9566200347bc)

**调用：** [`NationalSpire.LiveMaps.Matches(MegaCrit.Sts2.Core.Map.ActMap, System.Collections.Generic.IEnumerable<NationalSpire.RivalStep>, int)`](LiveMaps.cs.md#symbol-b7456baf6c82)

**字段、属性、事件及方法组引用：** `NationalSpire.LiveMaps.Matches(MegaCrit.Sts2.Core.Map.ActMap, System.Collections.Generic.IEnumerable<NationalSpire.RivalStep>, int)`；`NationalSpire.LiveMatchState.Steps`；`NationalSpire.LiveRunBridge._mapCompatible`；`NationalSpire.LiveRunBridge._run`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LiveMaps.Matches(MegaCrit.Sts2.Core.Map.ActMap, System.Collections.Generic.IEnumerable<NationalSpire.RivalStep>, int)`；输入表达式：`LiveMaps.Matches(_run.Map, live.Steps, _run.CurrentActIndex)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _mapCompatible = LiveMaps.Matches(_run.Map, live.Steps, _run.CurrentActIndex)`

**赋值（含属性/字段和局部值）：**

- `_mapCompatible` = `LiveMaps.Matches(_run.Map, live.Steps, _run.CurrentActIndex)`

<a id="symbol-cedfec15a9e5"></a>

## `NationalSpire.LiveRunBridge.UpdateMap(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, double) — private void UpdateMap(LiveMatchState live, RivalProgress progress, double seconds)`

来源：源码第 262 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.UpdateRace()`](LiveRunBridge.cs.md#symbol-9566200347bc)

**调用：** [`NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`](AvatarAssets.cs.md#symbol-1d4beb6f533e)；[`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-5207a1627331)；[`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-cd3d95caefab)；[`NationalSpire.LiveCompatibility.MapPoints(Godot.Node)`](LiveCompatibility.cs.md#symbol-e7d2ddafdb60)；[`NationalSpire.LiveRunBridge.MapPosition(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint)`](LiveRunBridge.cs.md#symbol-2f08e8cbdbe3)；[`NationalSpire.RivalMapOverlay.RefreshArt(NationalSpire.AvatarArt)`](LiveRaceHud.cs.md#symbol-6200daa39f4a)；[`NationalSpire.RivalMapOverlay.UpdateState(System.Collections.Generic.List<Godot.Vector2>, Godot.Vector2?, string, int, int, bool)`](LiveRaceHud.cs.md#symbol-683532d7c3b5)；`Godot.CanvasItem.Hide()`；`Godot.CanvasItem.Show()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.GodotObject.IsQueuedForDeletion()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetParent()`；`Godot.Node.QueueFree()`；`MegaCrit.Sts2.Core.Map.MapCoord.MapCoord(int, int)`；`NationalSpire.RivalMapOverlay.RivalMapOverlay()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarArt.Texture`；`NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`；`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.LiveCompatibility.MapPoints(Godot.Node)`；`NationalSpire.LiveMatchState.MaxHp`；`NationalSpire.LiveMatchState.Steps`；`NationalSpire.LiveRunBridge._artRetryAt`；`NationalSpire.LiveRunBridge._data`；`NationalSpire.LiveRunBridge._mapCompatible`；`NationalSpire.LiveRunBridge._mapOverlay`；`NationalSpire.LiveRunBridge._mapPoints`；`NationalSpire.LiveRunBridge._mapScreen`；`NationalSpire.LiveRunBridge._rival`；`NationalSpire.LiveRunBridge._run`；`NationalSpire.LiveRunBridge.MapPosition(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint)`；`NationalSpire.RivalMapOverlay.Art`；`NationalSpire.RivalMapOverlay.Identity`；`NationalSpire.RivalMapOverlay.RefreshArt(NationalSpire.AvatarArt)`；`NationalSpire.RivalMapOverlay.UpdateState(System.Collections.Generic.List<Godot.Vector2>, Godot.Vector2?, string, int, int, bool)`；`NationalSpire.RivalProgress.Dead`；`NationalSpire.RivalProgress.Hp`；`NationalSpire.RivalProgress.Step`；`NationalSpire.RivalStep.Act`；`NationalSpire.RivalStep.Col`；`NationalSpire.RivalStep.Row`；`NationalSpire.RivalStep.Start`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`_mapOverlay!.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _mapOverlay!.Hide();`
- `Godot.CanvasItem.Show()`；输入表达式：`_mapOverlay!.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: _mapOverlay!.Show();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_mapOverlay)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsInstanceValid(_mapOverlay) && _mapOverlay!.GetParent() != mapParent`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_mapOverlay)`；返回值紧邻使用处：`IfStatementSyntax: if (IsInstanceValid(_mapOverlay)) _mapOverlay!.Hide();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_mapOverlay)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(_mapOverlay)`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(p)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsInstanceValid(p)`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`_mapOverlay!.IsQueuedForDeletion()`；返回值紧邻使用处：`BinaryExpressionSyntax: !IsInstanceValid(_mapOverlay) || _mapOverlay!.IsQueuedForDeletion()`
- `Godot.GodotObject.IsQueuedForDeletion()`；输入表达式：`p.IsQueuedForDeletion()`；返回值紧邻使用处：`BinaryExpressionSyntax: !IsInstanceValid(p) || p.IsQueuedForDeletion()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`mapParent.AddChild(_mapOverlay)`；返回值紧邻使用处：`ExpressionStatementSyntax: mapParent.AddChild(_mapOverlay);`
- `Godot.Node.GetParent()`；输入表达式：`_mapOverlay!.GetParent()`；返回值紧邻使用处：`BinaryExpressionSyntax: _mapOverlay!.GetParent() != mapParent`
- `Godot.Node.GetParent()`；输入表达式：`points.Values.First().GetParent()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = points.Values.First().GetParent()`
- `Godot.Node.QueueFree()`；输入表达式：`_mapOverlay.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: _mapOverlay.QueueFree();`
- `MegaCrit.Sts2.Core.Map.MapCoord.MapCoord(int, int)`；输入表达式：`new MapCoord(progress.Step.Col, progress.Step.Row)`；返回值紧邻使用处：`ArgumentSyntax: new MapCoord(progress.Step.Col, progress.Step.Row)`
- `MegaCrit.Sts2.Core.Map.MapCoord.MapCoord(int, int)`；输入表达式：`new MapCoord(step.Col, step.Row)`；返回值紧邻使用处：`ArgumentSyntax: new MapCoord(step.Col, step.Row)`
- `NationalSpire.AvatarAssets.Usable(Godot.Texture2D?)`；输入表达式：`AvatarAssets.Usable(_mapOverlay.Art.Texture)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !AvatarAssets.Usable(_mapOverlay.Art.Texture)`
- `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`AvatarHonors.ForPerson(_data, _rival.Id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Identity = AvatarHonors.ForPerson(_data, _rival.Id)`
- `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.ForPerson(_data, _rival.Id)`；返回值紧邻使用处：`ArgumentSyntax: CareerAvatars.ForPerson(_data, _rival.Id)`
- `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.ForPerson(_data, _rival.Id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Art = CareerAvatars.ForPerson(_data, _rival.Id)`
- `NationalSpire.LiveCompatibility.MapPoints(Godot.Node)`；输入表达式：`LiveCompatibility.MapPoints(screen)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _mapPoints = LiveCompatibility.MapPoints(screen)`
- `NationalSpire.LiveRunBridge.MapPosition(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint)`；输入表达式：`MapPosition(at)`；返回值紧邻使用处：`AssignmentExpressionSyntax: marker = MapPosition(at)`
- `NationalSpire.LiveRunBridge.MapPosition(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint)`；输入表达式：`MapPosition(point)`；返回值紧邻使用处：`ArgumentSyntax: MapPosition(point)`
- `NationalSpire.RivalMapOverlay.RefreshArt(NationalSpire.AvatarArt)`；输入表达式：`_mapOverlay.RefreshArt(CareerAvatars.ForPerson(_data, _rival.Id))`；返回值紧邻使用处：`ExpressionStatementSyntax: _mapOverlay.RefreshArt(CareerAvatars.ForPerson(_data, _rival.Id));`
- `NationalSpire.RivalMapOverlay.RivalMapOverlay()`；输入表达式：`new RivalMapOverlay { Art = CareerAvatars.ForPerson(_data, _rival.Id), Identity = AvatarHonors.ForPerson(_data, _rival.Id) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _mapOverlay = new RivalMapOverlay { Art = CareerAvatars.ForPerson(_data, _rival.Id), Identity = AvatarHonors.ForPerson(_data, _rival.Id) }`
- `NationalSpire.RivalMapOverlay.UpdateState(System.Collections.Generic.List<Godot.Vector2>, Godot.Vector2?, string, int, int, bool)`；输入表达式：`_mapOverlay.UpdateState(path, marker, _rival.PublicName, progress.Hp, live.MaxHp, progress.Dead)`；返回值紧邻使用处：`ExpressionStatementSyntax: _mapOverlay.UpdateState(path, marker, _rival.PublicName, progress.Hp, live.MaxHp, progress.Dead);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`points.TryGetValue(new MapCoord(progress.Step.Col, progress.Step.Row), out var at)`；返回值紧邻使用处：`BinaryExpressionSyntax: progress.Step.Act == _run.CurrentActIndex && points.TryGetValue(new MapCoord(progress.Step.Col, progress.Step.Row), out var at)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`points.TryGetValue(new MapCoord(step.Col, step.Row), out var point)`；返回值紧邻使用处：`IfStatementSyntax: if (points.TryGetValue(new MapCoord(step.Col, step.Row), out var point)) path.Add(MapPosition(point));`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`_mapPoints.Values.Any(p => !IsInstanceValid(p) || p.IsQueuedForDeletion())`；返回值紧邻使用处：`BinaryExpressionSyntax: _mapScreen != screen || _mapPoints == null || _mapPoints.Count == 0 || _mapPoints.Values.Any(p => !IsInstanceValid(p) || p.IsQueuedForDeletion())`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；输入表达式：`points.Values.First()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: points.Values.First().GetParent`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`live.Steps.Where(s => s.Act == _run.CurrentActIndex && s.Start <= seconds)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var step in live.Steps.Where(s => s.Act == _run.CurrentActIndex && s.Start <= seconds))          {              if (points.TryGetValue(new MapCoord(step.Col, step.Row), out var point)) path.Add(MapPosition(point));          }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`path.Add(MapPosition(point))`；返回值紧邻使用处：`ExpressionStatementSyntax: path.Add(MapPosition(point));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Vector2>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<Vector2>()`

**赋值（含属性/字段和局部值）：**

- `_artRetryAt` = `seconds + 3`
- `_mapOverlay` = `new RivalMapOverlay { Art = CareerAvatars.ForPerson(_data, _rival.Id), Identity = AvatarHonors.ForPerson(_data, _rival.Id) }`
- `_mapOverlay` = `null`
- `_mapPoints` = `LiveCompatibility.MapPoints(screen)`
- `_mapScreen` = `screen`
- `Art` = `CareerAvatars.ForPerson(_data, _rival.Id)`
- `Identity` = `AvatarHonors.ForPerson(_data, _rival.Id)`
- `marker` = `MapPosition(at)`

<a id="symbol-2f08e8cbdbe3"></a>

## `NationalSpire.LiveRunBridge.MapPosition(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint) — private Vector2 MapPosition(NMapPoint point)`

来源：源码第 291 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.UpdateMap(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, double)`](LiveRunBridge.cs.md#symbol-cedfec15a9e5)

**调用：** `Godot.CanvasItem.GetGlobalTransformWithCanvas()`；`Godot.Transform2D.AffineInverse()`

**字段、属性、事件及方法组引用：** `NationalSpire.LiveRunBridge._mapOverlay`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.GetGlobalTransformWithCanvas()`；输入表达式：`_mapOverlay!.GetGlobalTransformWithCanvas()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _mapOverlay!.GetGlobalTransformWithCanvas().AffineInverse`
- `Godot.CanvasItem.GetGlobalTransformWithCanvas()`；输入表达式：`point.GetGlobalTransformWithCanvas()`；返回值紧邻使用处：`BinaryExpressionSyntax: point.GetGlobalTransformWithCanvas() * (point is NNormalMapPoint ? Vector2.Zero : point.Size * .5f)`
- `Godot.Transform2D.AffineInverse()`；输入表达式：`_mapOverlay!.GetGlobalTransformWithCanvas().AffineInverse()`；返回值紧邻使用处：`BinaryExpressionSyntax: _mapOverlay!.GetGlobalTransformWithCanvas().AffineInverse()          * (point.GetGlobalTransformWithCanvas() * (point is NNormalMapPoint ? Vector2.Zero : point.Size * .5f))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-df914af86259"></a>

## `NationalSpire.LiveRunBridge.OnWon(MegaCrit.Sts2.Core.Rooms.CombatRoom) — private void OnWon(CombatRoom room)`

来源：源码第 293 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LiveRunBridge.Guard(System.Action, bool)`](LiveRunBridge.cs.md#symbol-65a24868959d)

**字段、属性、事件及方法组引用：** `NationalSpire.LiveRunBridge._commentaryFaulted`；`NationalSpire.LiveRunBridge.FinishCombat()`；`NationalSpire.LiveRunBridge.Guard(System.Action, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LiveRunBridge.Guard(System.Action, bool)`；输入表达式：`Guard(FinishCombat, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Guard(FinishCombat, true);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-10bf254b1599"></a>

## `NationalSpire.LiveRunBridge.OnHistoryChanged() — private void OnHistoryChanged()`

来源：源码第 294 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LiveRunBridge.Guard(System.Action, bool)`](LiveRunBridge.cs.md#symbol-65a24868959d)；[`NationalSpire.LiveRunBridge.History(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Combat.History.CombatHistoryEntry)`](LiveRunBridge.cs.md#symbol-42aede5a364b)；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.LiveRunBridge._commentaryFaulted`；`NationalSpire.LiveRunBridge._historyCount`；`NationalSpire.LiveRunBridge._player`；`NationalSpire.LiveRunBridge.Guard(System.Action, bool)`；`NationalSpire.LiveRunBridge.History(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Combat.History.CombatHistoryEntry)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LiveRunBridge.Guard(System.Action, bool)`；输入表达式：`Guard(() =>          {              var entries = CombatManager.Instance.History.Entries;              var list = entries as IReadOnlyList<CombatHistoryEntry> ?? entries.ToList();              if (list.Count < _historyCount) _historyCount = 0;              if (_player.Creature.CombatState is { } state)                  for (int i = _historyCount; i < list.Count; i++) History(state, list[i]);              _historyCount = list.Count;          }, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Guard(() =>          {              var entries = CombatManager.Instance.History.Entries;              var list = entries as IReadOnlyList<CombatHistoryEntry> ?? entries.ToList();              if (list.Count < _historyCount) _historyCount = 0;              if (_player.Creature.CombatState is { } state)                  for (int i = _historyCount; i < list.Count; i++) History(state, list[i]);              _historyCount = list.Count;          }, true);`
- `NationalSpire.LiveRunBridge.History(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Combat.History.CombatHistoryEntry)`；输入表达式：`History(state, list[i])`；返回值紧邻使用处：`ExpressionStatementSyntax: History(state, list[i]);`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`entries.ToList()`；返回值紧邻使用处：`BinaryExpressionSyntax: entries as IReadOnlyList<CombatHistoryEntry> ?? entries.ToList()`

**赋值（含属性/字段和局部值）：**

- `_historyCount` = `0`
- `_historyCount` = `list.Count`

<a id="symbol-e13750e1d813"></a>

## `NationalSpire.LiveRunBridge.OnCombat(MegaCrit.Sts2.Core.Combat.ICombatState) — private void OnCombat(ICombatState state)`

来源：源码第 307 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge._Ready()`](LiveRunBridge.cs.md#symbol-26fa8bae2af0)

**调用：** `NationalSpire.BattleObservation.BattleObservation()`；`object.ReferenceEquals(object?, object?)`；`System.Enum.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.BattleObservation.Floor`；`NationalSpire.BattleObservation.Kind`；`NationalSpire.LiveRunBridge._battle`；`NationalSpire.LiveRunBridge._run`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.BattleObservation.BattleObservation()`；输入表达式：`new BattleObservation { Floor = _run.TotalFloor, Kind = _run.CurrentRoom?.RoomType.ToString() ?? "Monster" }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _battle = new BattleObservation { Floor = _run.TotalFloor, Kind = _run.CurrentRoom?.RoomType.ToString() ?? "Monster" }`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(state.RunState, _run)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ReferenceEquals(state.RunState, _run)`
- `System.Enum.ToString()`；输入表达式：`.RoomType.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _run.CurrentRoom?.RoomType.ToString()`

**赋值（含属性/字段和局部值）：**

- `_battle` = `new BattleObservation { Floor = _run.TotalFloor, Kind = _run.CurrentRoom?.RoomType.ToString() ?? "Monster" }`
- `Floor` = `_run.TotalFloor`
- `Kind` = `_run.CurrentRoom?.RoomType.ToString() ?? "Monster"`

<a id="symbol-f716e330add4"></a>

## `NationalSpire.LiveRunBridge.HpChanged(int, int) — private void HpChanged(int before, int after)`

来源：源码第 312 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LiveCommentary.IsCombatLoss(int, int, int, string)`](LiveMoments.cs.md#symbol-aececc8f0381)；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.BattleObservation.Floor`；`NationalSpire.BattleObservation.HpLost`；`NationalSpire.BattleObservation.Kind`；`NationalSpire.LiveCommentary.IsCombatLoss(int, int, int, string)`；`NationalSpire.LiveRunBridge._battle`；`NationalSpire.LiveRunBridge._lossFloor`；`NationalSpire.LiveRunBridge._pendingLoss`；`NationalSpire.LiveRunBridge._player`；`NationalSpire.LiveRunBridge._run`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LiveCommentary.IsCombatLoss(int, int, int, string)`；输入表达式：`LiveCommentary.IsCombatLoss(before, after, _player.Creature.MaxHp, _battle.Kind)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !LiveCommentary.IsCombatLoss(before, after, _player.Creature.MaxHp, _battle.Kind)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, before - after)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _pendingLoss += Math.Max(0, before - after)`

**赋值（含属性/字段和局部值）：**

- `_battle.HpLost` += `before - after`
- `_lossFloor` = `_run.TotalFloor`
- `_pendingLoss` += `Math.Max(0, before - after)`
- `_pendingLoss` = `0`

<a id="symbol-42aede5a364b"></a>

## `NationalSpire.LiveRunBridge.History(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Combat.History.CombatHistoryEntry) — public void History(ICombatState state, CombatHistoryEntry entry)`

来源：源码第 320 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.OnHistoryChanged()`](LiveRunBridge.cs.md#symbol-10bf254b1599)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.GameText.Plain(string)`](GameText.cs.md#symbol-e2c48dec4564)；[`NationalSpire.LiveCommentary.ObserveTurn(NationalSpire.BroadcastMemory, NationalSpire.BattleObservation, string, string, double)`](LiveCommentary.cs.md#symbol-8cbc1ed10ae3)；[`NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`](LiveRunBridge.cs.md#symbol-c7a514513ce3)；[`NationalSpire.LiveVoiceObservation.Observe(NationalSpire.LiveVoices?, NationalSpire.BattleObservation, MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Combat.History.CombatHistoryEntry, string, double)`](LiveVoiceObservation.cs.md#symbol-efed0893a47e)；`NationalSpire.BattleObservation.BattleObservation()`；`object.ReferenceEquals(object?, object?)`；`System.Enum.ToString()`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.BattleObservation.Cards`；`NationalSpire.BattleObservation.Damage`；`NationalSpire.BattleObservation.Draws`；`NationalSpire.BattleObservation.Floor`；`NationalSpire.BattleObservation.Hp`；`NationalSpire.BattleObservation.Kind`；`NationalSpire.BattleObservation.LastCard`；`NationalSpire.BattleObservation.MaxHp`；`NationalSpire.BattleObservation.PeakCards`；`NationalSpire.BattleObservation.PeakDamage`；`NationalSpire.BattleObservation.PeakDraws`；`NationalSpire.BattleObservation.Turn`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerMatch.Live`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.GameText.Plain(string)`；`NationalSpire.LiveCommentary.ObserveTurn(NationalSpire.BroadcastMemory, NationalSpire.BattleObservation, string, string, double)`；`NationalSpire.LiveMatchState.Commentary`；`NationalSpire.LiveRunBridge._battle`；`NationalSpire.LiveRunBridge._commentaryFaulted`；`NationalSpire.LiveRunBridge._data`；`NationalSpire.LiveRunBridge._faulted`；`NationalSpire.LiveRunBridge._match`；`NationalSpire.LiveRunBridge._player`；`NationalSpire.LiveRunBridge._run`；`NationalSpire.LiveRunBridge._voices`；`NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`；`NationalSpire.LiveVoiceObservation.Observe(NationalSpire.LiveVoices?, NationalSpire.BattleObservation, MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Combat.History.CombatHistoryEntry, string, double)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.BattleObservation.BattleObservation()`；输入表达式：`new BattleObservation { Floor = _run.TotalFloor, Kind = _run.CurrentRoom?.RoomType.ToString() ?? "Monster" }`；返回值紧邻使用处：`AssignmentExpressionSyntax: _battle ??= new BattleObservation { Floor = _run.TotalFloor, Kind = _run.CurrentRoom?.RoomType.ToString() ?? "Monster" }`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(_data)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.Name(_data)`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(card.CardPlay.Card.Title)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _battle.LastCard = GameText.Plain(card.CardPlay.Card.Title)`
- `NationalSpire.LiveCommentary.ObserveTurn(NationalSpire.BroadcastMemory, NationalSpire.BattleObservation, string, string, double)`；输入表达式：`LiveCommentary.ObserveTurn(_match.Live.Commentary, _battle, CareerEngine.Name(_data), _match.Seed, RunManager.Instance.RunTime)`；返回值紧邻使用处：`ArgumentSyntax: LiveCommentary.ObserveTurn(_match.Live.Commentary, _battle, CareerEngine.Name(_data), _match.Seed, RunManager.Instance.RunTime)`
- `NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`；输入表达式：`Emit(LiveCommentary.ObserveTurn(_match.Live.Commentary, _battle, CareerEngine.Name(_data), _match.Seed, RunManager.Instance.RunTime))`；返回值紧邻使用处：`ExpressionStatementSyntax: Emit(LiveCommentary.ObserveTurn(_match.Live.Commentary, _battle, CareerEngine.Name(_data), _match.Seed, RunManager.Instance.RunTime));`
- `NationalSpire.LiveVoiceObservation.Observe(NationalSpire.LiveVoices?, NationalSpire.BattleObservation, MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Combat.History.CombatHistoryEntry, string, double)`；输入表达式：`LiveVoiceObservation.Observe(_voices, _battle, state, _player, entry, CareerEngine.Name(_data), RunManager.Instance.RunTime)`；返回值紧邻使用处：`ExpressionStatementSyntax: LiveVoiceObservation.Observe(_voices, _battle, state, _player, entry, CareerEngine.Name(_data), RunManager.Instance.RunTime);`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(state.RunState, _run)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ReferenceEquals(state.RunState, _run)`
- `System.Enum.ToString()`；输入表达式：`.RoomType.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _run.CurrentRoom?.RoomType.ToString()`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(_battle.PeakCards, _battle.Cards)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _battle.PeakCards = Math.Max(_battle.PeakCards, _battle.Cards)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(_battle.PeakDamage, _battle.Damage)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _battle.PeakDamage = Math.Max(_battle.PeakDamage, _battle.Damage)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(_battle.PeakDraws, _battle.Draws)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _battle.PeakDraws = Math.Max(_battle.PeakDraws, _battle.Draws)`

**赋值（含属性/字段和局部值）：**

- `_battle.Cards` = `_battle.Draws = _battle.Damage = 0`
- `_battle.Damage` += `damage.Result.UnblockedDamage`
- `_battle.Damage` = `0`
- `_battle.Draws` = `_battle.Damage = 0`
- `_battle.Hp` = `_player.Creature.CurrentHp`
- `_battle.LastCard` = `GameText.Plain(card.CardPlay.Card.Title)`
- `_battle.MaxHp` = `_player.Creature.MaxHp`
- `_battle.PeakCards` = `Math.Max(_battle.PeakCards, _battle.Cards)`
- `_battle.PeakDamage` = `Math.Max(_battle.PeakDamage, _battle.Damage)`
- `_battle.PeakDraws` = `Math.Max(_battle.PeakDraws, _battle.Draws)`
- `_battle.Turn` = `turn`
- `_battle` ??= `new BattleObservation { Floor = _run.TotalFloor, Kind = _run.CurrentRoom?.RoomType.ToString() ?? "Monster" }`
- `Floor` = `_run.TotalFloor`
- `Kind` = `_run.CurrentRoom?.RoomType.ToString() ?? "Monster"`

<a id="symbol-1e798ae2b209"></a>

## `NationalSpire.LiveRunBridge.FinishCombat() — public void FinishCombat()`

来源：源码第 335 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.LiveCommentary.Finish(NationalSpire.BroadcastMemory, NationalSpire.BattleObservation, string, string, double)`](LiveCommentary.cs.md#symbol-243aedb210e3)；[`NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`](LiveRunBridge.cs.md#symbol-c7a514513ce3)；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.BattleObservation.Hp`；`NationalSpire.BattleObservation.MaxHp`；`NationalSpire.BattleObservation.Turn`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerMatch.Live`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.LiveCommentary.Finish(NationalSpire.BroadcastMemory, NationalSpire.BattleObservation, string, string, double)`；`NationalSpire.LiveMatchState.Commentary`；`NationalSpire.LiveRunBridge._battle`；`NationalSpire.LiveRunBridge._data`；`NationalSpire.LiveRunBridge._faulted`；`NationalSpire.LiveRunBridge._match`；`NationalSpire.LiveRunBridge._pendingLoss`；`NationalSpire.LiveRunBridge._player`；`NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(_data)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.Name(_data)`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(_data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(_data);`
- `NationalSpire.LiveCommentary.Finish(NationalSpire.BroadcastMemory, NationalSpire.BattleObservation, string, string, double)`；输入表达式：`LiveCommentary.Finish(_match.Live.Commentary, _battle, CareerEngine.Name(_data), _match.Seed, RunManager.Instance.RunTime)`；返回值紧邻使用处：`ArgumentSyntax: LiveCommentary.Finish(_match.Live.Commentary, _battle, CareerEngine.Name(_data), _match.Seed, RunManager.Instance.RunTime)`
- `NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?)`；输入表达式：`Emit(LiveCommentary.Finish(_match.Live.Commentary, _battle, CareerEngine.Name(_data), _match.Seed, RunManager.Instance.RunTime))`；返回值紧邻使用处：`ExpressionStatementSyntax: Emit(LiveCommentary.Finish(_match.Live.Commentary, _battle, CareerEngine.Name(_data), _match.Seed, RunManager.Instance.RunTime));`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(_battle.Turn, _player.PlayerCombatState?.TurnNumber ?? 1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _battle.Turn = Math.Max(_battle.Turn, _player.PlayerCombatState?.TurnNumber ?? 1)`

**赋值（含属性/字段和局部值）：**

- `_battle.Hp` = `_player.Creature.CurrentHp`
- `_battle.MaxHp` = `_player.Creature.MaxHp`
- `_battle.Turn` = `Math.Max(_battle.Turn, _player.PlayerCombatState?.TurnNumber ?? 1)`
- `_battle` = `null`
- `_pendingLoss` = `0`

<a id="symbol-c7a514513ce3"></a>

## `NationalSpire.LiveRunBridge.Emit(NationalSpire.BroadcastLine?) — private void Emit(BroadcastLine? line)`

来源：源码第 343 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.EnergyGained(MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState, int)`](LiveRunBridge.cs.md#symbol-1d29bfc1f633)；[`NationalSpire.LiveRunBridge.FinishCombat()`](LiveRunBridge.cs.md#symbol-1e798ae2b209)；[`NationalSpire.LiveRunBridge.History(MegaCrit.Sts2.Core.Combat.ICombatState, MegaCrit.Sts2.Core.Combat.History.CombatHistoryEntry)`](LiveRunBridge.cs.md#symbol-42aede5a364b)；[`NationalSpire.LiveRunBridge.ObservePotions(NationalSpire.BroadcastMemory, double)`](LiveRunBridge.cs.md#symbol-e509c91bb4f4)；[`NationalSpire.LiveRunBridge.RewardSkipped(MegaCrit.Sts2.Core.Rewards.CardReward)`](LiveRunBridge.cs.md#symbol-c012e2474371)；[`NationalSpire.LiveRunBridge.RunEnded(bool)`](LiveRunBridge.cs.md#symbol-d5b5bb6d87cd)；[`NationalSpire.LiveRunBridge.UpdateRace()`](LiveRunBridge.cs.md#symbol-9566200347bc)

**调用：** [`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-5207a1627331)；[`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-cd3d95caefab)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CommentatorSelection.ForMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, System.Collections.Generic.IEnumerable<string>?)`](CommentatorSelection.cs.md#symbol-2c2966603311)；[`NationalSpire.CommentatorSelection.Participants(NationalSpire.CareerData, NationalSpire.CareerMatch, System.Collections.Generic.IEnumerable<string>?)`](CommentatorSelection.cs.md#symbol-e47ee769b462)；[`NationalSpire.LiveRaceHud.Say(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?)`](LiveRaceHud.cs.md#symbol-1fd8ee1cca63)；[`NationalSpire.LiveVoices.Byline(string, string)`](LiveVoices.cs.md#symbol-258e03700c96)；[`NationalSpire.LiveVoices.React(string, int, double)`](LiveVoices.cs.md#symbol-ca2aacab4a81)；`System.Collections.Generic.HashSet<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.BroadcastLine.Analyst`；`NationalSpire.BroadcastLine.Role`；`NationalSpire.BroadcastLine.SpeakerId`；`NationalSpire.BroadcastLine.Text`；`NationalSpire.BroadcastLine.Topic`；`NationalSpire.BroadcastMemory.LastSpoke`；`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerMatch.Live`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CommentatorSelection.ForMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, System.Collections.Generic.IEnumerable<string>?)`；`NationalSpire.CommentatorSelection.Participants(NationalSpire.CareerData, NationalSpire.CareerMatch, System.Collections.Generic.IEnumerable<string>?)`；`NationalSpire.LiveMatchState.Commentary`；`NationalSpire.LiveRaceHud.Say(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?)`；`NationalSpire.LiveRunBridge._commentaryFaulted`；`NationalSpire.LiveRunBridge._data`；`NationalSpire.LiveRunBridge._hud`；`NationalSpire.LiveRunBridge._match`；`NationalSpire.LiveRunBridge._run`；`NationalSpire.LiveRunBridge._voices`；`NationalSpire.LiveVoices.Byline(string, string)`；`NationalSpire.LiveVoices.React(string, int, double)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`AvatarHonors.ForPerson(_data, person.Id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: person != null ? AvatarHonors.ForPerson(_data, person.Id) : null`
- `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.ForPerson(_data, person.Id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: person != null ? CareerAvatars.ForPerson(_data, person.Id) : null`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(_data, person.Id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: person != null ? CareerEngine.DisplayName(_data, person.Id) : line.Analyst ? "分析席" : "现场"`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(_data, line.SpeakerId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: line.SpeakerId.Length > 0 ? CareerEngine.Person(_data, line.SpeakerId)              : speakers.Count > 0 ? speakers[(line.Analyst ? 1 : 0) % speakers.Count] : null`
- `NationalSpire.CommentatorSelection.ForMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, System.Collections.Generic.IEnumerable<string>?)`；输入表达式：`CommentatorSelection.ForMatch(_data, _match)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommentatorSelection.ForMatch(_data, _match)`
- `NationalSpire.CommentatorSelection.Participants(NationalSpire.CareerData, NationalSpire.CareerMatch, System.Collections.Generic.IEnumerable<string>?)`；输入表达式：`CommentatorSelection.Participants(_data, _match)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommentatorSelection.Participants(_data, _match).Contains`
- `NationalSpire.LiveRaceHud.Say(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?)`；输入表达式：`_hud.Say(LiveVoices.Byline(speaker, line.Role), line.Text, line.Topic, person != null ? CareerAvatars.ForPerson(_data, person.Id) : null,              person != null ? AvatarHonors.ForPerson(_data, person.Id) : null)`；返回值紧邻使用处：`ExpressionStatementSyntax: _hud.Say(LiveVoices.Byline(speaker, line.Role), line.Text, line.Topic, person != null ? CareerAvatars.ForPerson(_data, person.Id) : null,              person != null ? AvatarHonors.ForPerson(_data, person.Id) : null);`
- `NationalSpire.LiveVoices.Byline(string, string)`；输入表达式：`LiveVoices.Byline(speaker, line.Role)`；返回值紧邻使用处：`ArgumentSyntax: LiveVoices.Byline(speaker, line.Role)`
- `NationalSpire.LiveVoices.React(string, int, double)`；输入表达式：`.React(line.Topic, _run.TotalFloor, RunManager.Instance.RunTime)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _voices?.React(line.Topic, _run.TotalFloor, RunManager.Instance.RunTime)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`CommentatorSelection.Participants(_data, _match).Contains(person.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: person != null && line.Role != "thought" && CommentatorSelection.Participants(_data, _match).Contains(person.Id)`

**赋值（含属性/字段和局部值）：**

- `live.Commentary.LastSpoke` = `RunManager.Instance.RunTime`

<a id="symbol-9e4cba4dced9"></a>

## `NationalSpire.LiveRunReadyPatch.Prepare() — public static bool Prepare()`

来源：源码第 364 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(NRun), nameof(NRun._Ready), Type.EmptyTypes)`；返回值紧邻使用处：`BinaryExpressionSyntax: AccessTools.Method(typeof(NRun), nameof(NRun._Ready), Type.EmptyTypes) != null`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5639c4c6edfd"></a>

## `NationalSpire.LiveRunReadyPatch.Postfix(MegaCrit.Sts2.Core.Nodes.NRun) — public static void Postfix(NRun __instance)`

来源：源码第 365 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LiveCompatibility.ReadState(MegaCrit.Sts2.Core.Nodes.NRun)`](LiveCompatibility.cs.md#symbol-b0c55be23807)；[`NationalSpire.LiveRunBridge.Attach(MegaCrit.Sts2.Core.Nodes.NRun, MegaCrit.Sts2.Core.Runs.RunState)`](LiveRunBridge.cs.md#symbol-1af74b766122)；[`NationalSpire.LiveRunBridge.Guard(System.Action, bool)`](LiveRunBridge.cs.md#symbol-65a24868959d)；`Godot.GD.PushWarning(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.LiveCompatibility.ReadState(MegaCrit.Sts2.Core.Nodes.NRun)`；`NationalSpire.LiveRunBridge.Attach(MegaCrit.Sts2.Core.Nodes.NRun, MegaCrit.Sts2.Core.Runs.RunState)`；`NationalSpire.LiveRunBridge.Guard(System.Action, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GD.PushWarning(string)`；输入表达式：`GD.PushWarning("[NationalSpire] 当前版本未提供局内状态，生涯比赛仍可正常进行。")`；返回值紧邻使用处：`ExpressionStatementSyntax: GD.PushWarning("[NationalSpire] 当前版本未提供局内状态，生涯比赛仍可正常进行。");`
- `NationalSpire.LiveCompatibility.ReadState(MegaCrit.Sts2.Core.Nodes.NRun)`；输入表达式：`LiveCompatibility.ReadState(__instance)`；返回值紧邻使用处：`IsPatternExpressionSyntax: LiveCompatibility.ReadState(__instance) is { } state`
- `NationalSpire.LiveRunBridge.Attach(MegaCrit.Sts2.Core.Nodes.NRun, MegaCrit.Sts2.Core.Runs.RunState)`；输入表达式：`LiveRunBridge.Attach(__instance, state)`；返回值紧邻使用处：`ExpressionStatementSyntax: LiveRunBridge.Attach(__instance, state);`
- `NationalSpire.LiveRunBridge.Guard(System.Action, bool)`；输入表达式：`LiveRunBridge.Guard(() =>      {          if (LiveCompatibility.ReadState(__instance) is { } state) LiveRunBridge.Attach(__instance, state);          else GD.PushWarning("[NationalSpire] 当前版本未提供局内状态，生涯比赛仍可正常进行。");      })`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => LiveRunBridge.Guard(() =>      {          if (LiveCompatibility.ReadState(__instance) is { } state) LiveRunBridge.Attach(__instance, state);          else GD.PushWarning("[NationalSpire] 当前版本未提供局内状态，生涯比赛仍可正常进行。");      })`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ed93b7a9a428"></a>

## `NationalSpire.LiveEnergyPatch.Prepare() — public static bool Prepare()`

来源：源码第 375 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(PlayerCombatState), nameof(PlayerCombatState.GainEnergy), [typeof(decimal)])`；返回值紧邻使用处：`BinaryExpressionSyntax: AccessTools.Method(typeof(PlayerCombatState), nameof(PlayerCombatState.GainEnergy), [typeof(decimal)]) != null`

**赋值（含属性/字段和局部值）：**


<a id="symbol-73fb902710a6"></a>

## `NationalSpire.LiveEnergyPatch.Prefix(MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState, out int) — public static void Prefix(PlayerCombatState __instance, out int __state)`

来源：源码第 376 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `__state` = `__instance.Energy`

<a id="symbol-74af22831368"></a>

## `NationalSpire.LiveEnergyPatch.Postfix(MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState, int) — public static void Postfix(PlayerCombatState __instance, int __state)`

来源：源码第 377 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LiveRunBridge.EnergyGained(MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState, int)`](LiveRunBridge.cs.md#symbol-1d29bfc1f633)；[`NationalSpire.LiveRunBridge.Guard(System.Action, bool)`](LiveRunBridge.cs.md#symbol-65a24868959d)；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.LiveRunBridge.Current`；`NationalSpire.LiveRunBridge.EnergyGained(MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState, int)`；`NationalSpire.LiveRunBridge.Guard(System.Action, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LiveRunBridge.EnergyGained(MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState, int)`；输入表达式：`.EnergyGained(__instance, Math.Max(0, __instance.Energy - __state))`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: LiveRunBridge.Current?.EnergyGained(__instance, Math.Max(0, __instance.Energy - __state))`
- `NationalSpire.LiveRunBridge.Guard(System.Action, bool)`；输入表达式：`LiveRunBridge.Guard(() => LiveRunBridge.Current?.EnergyGained(__instance, Math.Max(0, __instance.Energy - __state)), true)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => LiveRunBridge.Guard(() => LiveRunBridge.Current?.EnergyGained(__instance, Math.Max(0, __instance.Energy - __state)), true)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, __instance.Energy - __state)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, __instance.Energy - __state)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-cb3ce4c38c42"></a>

## `NationalSpire.LiveSkippedRewardPatch.Prepare() — public static bool Prepare()`

来源：源码第 384 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(CardReward), nameof(CardReward.OnSkipped), Type.EmptyTypes)`；返回值紧邻使用处：`BinaryExpressionSyntax: AccessTools.Method(typeof(CardReward), nameof(CardReward.OnSkipped), Type.EmptyTypes) != null`

**赋值（含属性/字段和局部值）：**


<a id="symbol-81cb2332df19"></a>

## `NationalSpire.LiveSkippedRewardPatch.Postfix(MegaCrit.Sts2.Core.Rewards.CardReward) — public static void Postfix(CardReward __instance)`

来源：源码第 385 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LiveRunBridge.Guard(System.Action, bool)`](LiveRunBridge.cs.md#symbol-65a24868959d)；[`NationalSpire.LiveRunBridge.RewardSkipped(MegaCrit.Sts2.Core.Rewards.CardReward)`](LiveRunBridge.cs.md#symbol-c012e2474371)

**字段、属性、事件及方法组引用：** `NationalSpire.LiveRunBridge.Current`；`NationalSpire.LiveRunBridge.Guard(System.Action, bool)`；`NationalSpire.LiveRunBridge.RewardSkipped(MegaCrit.Sts2.Core.Rewards.CardReward)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LiveRunBridge.Guard(System.Action, bool)`；输入表达式：`LiveRunBridge.Guard(() => LiveRunBridge.Current?.RewardSkipped(__instance), true)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => LiveRunBridge.Guard(() => LiveRunBridge.Current?.RewardSkipped(__instance), true)`
- `NationalSpire.LiveRunBridge.RewardSkipped(MegaCrit.Sts2.Core.Rewards.CardReward)`；输入表达式：`.RewardSkipped(__instance)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: LiveRunBridge.Current?.RewardSkipped(__instance)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fbd2c953fe79"></a>

## `NationalSpire.LiveVictoryPatch.Prepare() — public static bool Prepare()`

来源：源码第 391 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(RunManager), nameof(RunManager.OnEnded), [typeof(bool)])`；返回值紧邻使用处：`BinaryExpressionSyntax: AccessTools.Method(typeof(RunManager), nameof(RunManager.OnEnded), [typeof(bool)]) != null`

**赋值（含属性/字段和局部值）：**


<a id="symbol-363ebe5825ab"></a>

## `NationalSpire.LiveVictoryPatch.Prefix(bool) — public static void Prefix(bool isVictory)`

来源：源码第 392 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LiveRunBridge.Guard(System.Action, bool)`](LiveRunBridge.cs.md#symbol-65a24868959d)；[`NationalSpire.LiveRunBridge.RunEnded(bool)`](LiveRunBridge.cs.md#symbol-d5b5bb6d87cd)

**字段、属性、事件及方法组引用：** `NationalSpire.LiveRunBridge.Current`；`NationalSpire.LiveRunBridge.Guard(System.Action, bool)`；`NationalSpire.LiveRunBridge.RunEnded(bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LiveRunBridge.Guard(System.Action, bool)`；输入表达式：`LiveRunBridge.Guard(() => LiveRunBridge.Current?.RunEnded(isVictory), true)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => LiveRunBridge.Guard(() => LiveRunBridge.Current?.RunEnded(isVictory), true)`
- `NationalSpire.LiveRunBridge.RunEnded(bool)`；输入表达式：`.RunEnded(isVictory)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: LiveRunBridge.Current?.RunEnded(isVictory)`

**赋值（含属性/字段和局部值）：**
