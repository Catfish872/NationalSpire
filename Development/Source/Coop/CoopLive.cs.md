# Coop/CoopLive.cs

[返回文件依赖索引](../../SOURCE_MAP.md)

源码 SHA-256：`ECB812970C094EAD39C5B694171BCDD1CB9063AAE2602ED715B6816A55F245FB`。来源：[源码](../../../Coop/CoopLive.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Coop.CoopLive`。

字段、事件及初始值（源码原样）：

```csharp
private LiveRaceHud? _hud;
private CoopBroadcast? _broadcast;
private BroadcastUiState _layout = CoopSettings.ReadLayout();
private readonly HashSet<string> _heard = [];
private string _attached = "";
private string _diagnosticState = "";
private string _diagnosticAttempt = "";
private int _diagnosticResume = -1;
private readonly Dictionary<string, RivalMapOverlay> _maps = [];
```

<a id="symbol-85319a2fb491"></a>

## `NationalSpire.Coop.CoopLive.Close() — public void Close()`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopLive.Update()`](CoopLive.cs.md#symbol-fe745d15ee63)；[`NationalSpire.Coop.CoopRuntime.Disconnect()`](CoopRuntime.cs.md#symbol-a4550fd42c36)；[`NationalSpire.Coop.CoopRuntime.PauseCore(string)`](CoopRuntime.cs.md#symbol-60fe2cb26a8e)

**调用：** [`NationalSpire.Coop.CoopBroadcast.Dispose()`](CoopBroadcast.cs.md#symbol-7bb2229c33dc)；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.QueueFree()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Collections.Generic.HashSet<T>.Clear()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopBroadcast.Dispose()`；`NationalSpire.Coop.CoopLive._attached`；`NationalSpire.Coop.CoopLive._broadcast`；`NationalSpire.Coop.CoopLive._heard`；`NationalSpire.Coop.CoopLive._hud`；`NationalSpire.Coop.CoopLive._maps`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(_hud)`；返回值紧邻使用处：`BinaryExpressionSyntax: _hud != null && GodotObject.IsInstanceValid(_hud)`
- `Godot.Node.QueueFree()`；输入表达式：`_hud.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: _hud.QueueFree();`
- `Godot.Node.QueueFree()`；输入表达式：`map.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: map.QueueFree();`
- `NationalSpire.Coop.CoopBroadcast.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _broadcast?.Dispose()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_maps.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _maps.Clear();`
- `System.Collections.Generic.HashSet<T>.Clear()`；输入表达式：`_heard.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _heard.Clear();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_maps.Values.Where(GodotObject.IsInstanceValid)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var map in _maps.Values.Where(GodotObject.IsInstanceValid)) map.QueueFree();`

**赋值（含属性/字段和局部值）：**

- `_attached` = `""`
- `_broadcast` = `null`
- `_hud` = `null`

<a id="symbol-fe745d15ee63"></a>

## `NationalSpire.Coop.CoopLive.Update() — public void Update()`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRuntime._Process(double)`](CoopRuntime.cs.md#symbol-ec1513bd09b1)

**调用：** [`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`](../AvatarHonors.cs.md#symbol-5207a1627331)；[`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`](../CareerAvatars.cs.md#symbol-cd3d95caefab)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](../CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](../CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CommentatorSelection.Participants(NationalSpire.CareerData, NationalSpire.CareerMatch, System.Collections.Generic.IEnumerable<string>?)`](../CommentatorSelection.cs.md#symbol-e47ee769b462)；[`NationalSpire.Coop.CoopBroadcast.CoopBroadcast(NationalSpire.Coop.CoopCoordinator)`](CoopBroadcast.cs.md#symbol-2885ebc77d3b)；[`NationalSpire.Coop.CoopBroadcast.Tick()`](CoopBroadcast.cs.md#symbol-3be13ce2aa51)；[`NationalSpire.Coop.CoopCoordinator.PublishLive()`](CoopCoordinator.cs.md#symbol-1e3cadd9f597)；[`NationalSpire.Coop.CoopLive.Close()`](CoopLive.cs.md#symbol-85319a2fb491)；[`NationalSpire.Coop.CoopLive.UpdateMap(NationalSpire.Coop.CoopRun, MegaCrit.Sts2.Core.Map.ActMap, int)`](CoopLive.cs.md#symbol-3ddf0280ec69)；[`NationalSpire.Coop.CoopSettings.SaveLayout(NationalSpire.BroadcastUiState)`](CoopRuntime.cs.md#symbol-3613d13461fc)；[`NationalSpire.Diagnostics.RecordMatch(NationalSpire.Coop.CoopWorld, string, object?, bool)`](../MatchDiagnostics.cs.md#symbol-2f83ebe4626e)；[`NationalSpire.GameBridge.Characters()`](../GameBridge.cs.md#symbol-1233494dda40)；[`NationalSpire.LiveMaps.Matches(MegaCrit.Sts2.Core.Map.ActMap, System.Collections.Generic.IEnumerable<NationalSpire.RivalStep>, int)`](../LiveMaps.cs.md#symbol-b7456baf6c82)；[`NationalSpire.LiveMaps.Read(MegaCrit.Sts2.Core.Runs.IRunState, NationalSpire.CareerMatch, bool)`](../LiveMaps.cs.md#symbol-c878186b1e5a)；[`NationalSpire.LiveRaceHud.AddAction(string, System.Action)`](../LiveRaceHud.cs.md#symbol-e4440860b387)；[`NationalSpire.LiveRaceHud.Restore(NationalSpire.BroadcastUiState)`](../LiveRaceHud.cs.md#symbol-5f9621b5d769)；[`NationalSpire.LiveRaceHud.Say(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?)`](../LiveRaceHud.cs.md#symbol-1fd8ee1cca63)；[`NationalSpire.LiveRaceHud.SetRace(string, string, int, int, bool, double)`](../LiveRaceHud.cs.md#symbol-cfd9d62c7d32)；[`NationalSpire.LiveVoices.Byline(string, string)`](../LiveVoices.cs.md#symbol-258e03700c96)；[`NationalSpire.MatchRules.Time(double?)`](../MatchRules.cs.md#symbol-13ecc28f8403)；[`NationalSpire.RivalSimulation.At(NationalSpire.LiveMatchState, double)`](../LiveMatch.cs.md#symbol-78308976d2a9)；[`NationalSpire.RivalSimulation.Create(NationalSpire.CareerMatch, NationalSpire.CareerPerson, System.Collections.Generic.IReadOnlyList<NationalSpire.RouteNode>, int)`](../LiveMatch.cs.md#symbol-d351643744da)；[`NationalSpire.RivalSimulation.RoomName(string)`](../LiveMatch.cs.md#symbol-2c599e9f210a)；[`NationalSpire.RivalSimulation.Route(System.Collections.Generic.IReadOnlyList<NationalSpire.RouteNode>, NationalSpire.CareerPerson, string)`](../LiveMatch.cs.md#symbol-6158dbb0d19d)；[`NationalSpire.RivalSimulation.TryAdjustPace(NationalSpire.LiveMatchState, double, int, int)`](../LiveMatch.cs.md#symbol-719ee73c10ff)；[`NationalSpire.RivalSimulation.UpgradeHealthPlan(NationalSpire.LiveMatchState, NationalSpire.CareerMatch, NationalSpire.CareerPerson, double)`](../LiveMatch.cs.md#symbol-dc9f5474f9f6)；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；`NationalSpire.Coop.CoopLivePlayer.CoopLivePlayer(ulong, string, int, int, bool)`；`NationalSpire.LiveRaceHud.LiveRaceHud()`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.HashSet<T>.IntersectWith(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.IEnumerable<T>.Order<T>()`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SequenceEqual<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Enum.ToString()`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `(int Row, int Col).Col`；`(int Row, int Col).Row`；`<anonymous type: bool Host, System.Collections.Generic.List<string> displayed, long localClock, int localFloor, int localAct, int? row, int? col, string room, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer> localPlayers>.col`；`<anonymous type: bool Host, System.Collections.Generic.List<string> displayed, long localClock, int localFloor, int localAct, int? row, int? col, string room, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer> localPlayers>.displayed`；`<anonymous type: bool Host, System.Collections.Generic.List<string> displayed, long localClock, int localFloor, int localAct, int? row, int? col, string room, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer> localPlayers>.localAct`；`<anonymous type: bool Host, System.Collections.Generic.List<string> displayed, long localClock, int localFloor, int localAct, int? row, int? col, string room, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer> localPlayers>.localClock`；`<anonymous type: bool Host, System.Collections.Generic.List<string> displayed, long localClock, int localFloor, int localAct, int? row, int? col, string room, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer> localPlayers>.localFloor`；`<anonymous type: bool Host, System.Collections.Generic.List<string> displayed, long localClock, int localFloor, int localAct, int? row, int? col, string room, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer> localPlayers>.room`；`<anonymous type: bool Host, System.Collections.Generic.List<string> displayed, long localClock, int localFloor, int localAct, int? row, int? col, string room, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer> localPlayers>.row`；`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CommentatorSelection.Participants(NationalSpire.CareerData, NationalSpire.CareerMatch, System.Collections.Generic.IEnumerable<string>?)`；`NationalSpire.Coop.CoopBroadcast.Tick()`；`NationalSpire.Coop.CoopCoordinator.Full`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.PublishLive()`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopLive._attached`；`NationalSpire.Coop.CoopLive._broadcast`；`NationalSpire.Coop.CoopLive._diagnosticAttempt`；`NationalSpire.Coop.CoopLive._diagnosticResume`；`NationalSpire.Coop.CoopLive._diagnosticState`；`NationalSpire.Coop.CoopLive._heard`；`NationalSpire.Coop.CoopLive._hud`；`NationalSpire.Coop.CoopLive._layout`；`NationalSpire.Coop.CoopLive.Close()`；`NationalSpire.Coop.CoopLive.ConfirmStop()`；`NationalSpire.Coop.CoopLive.UpdateMap(NationalSpire.Coop.CoopRun, MegaCrit.Sts2.Core.Map.ActMap, int)`；`NationalSpire.Coop.CoopLivePlayer.Dead`；`NationalSpire.Coop.CoopLivePlayer.Hp`；`NationalSpire.Coop.CoopLivePlayer.Id`；`NationalSpire.Coop.CoopLivePlayer.MaxHp`；`NationalSpire.Coop.CoopMember.Name`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopRun.Act`；`NationalSpire.Coop.CoopRun.Attempt`；`NationalSpire.Coop.CoopRun.Characters`；`NationalSpire.Coop.CoopRun.Clock`；`NationalSpire.Coop.CoopRun.Commentary`；`NationalSpire.Coop.CoopRun.Floor`；`NationalSpire.Coop.CoopRun.MatchId`；`NationalSpire.Coop.CoopRun.Opponents`；`NationalSpire.Coop.CoopRun.Phase`；`NationalSpire.Coop.CoopRun.Players`；`NationalSpire.Coop.CoopRun.ResumeCount`；`NationalSpire.Coop.CoopRun.Rival`；`NationalSpire.Coop.CoopRun.RivalMembers`；`NationalSpire.Coop.CoopRun.Seed`；`NationalSpire.Coop.CoopRun.Speeches`；`NationalSpire.Coop.CoopSettings.SaveLayout(NationalSpire.BroadcastUiState)`；`NationalSpire.Coop.CoopSpeech.Id`；`NationalSpire.Coop.CoopSpeech.Role`；`NationalSpire.Coop.CoopSpeech.Speaker`；`NationalSpire.Coop.CoopSpeech.Text`；`NationalSpire.Coop.CoopSpeech.Topic`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.Diagnostics.RecordMatch(NationalSpire.Coop.CoopWorld, string, object?, bool)`；`NationalSpire.GameBridge.Characters()`；`NationalSpire.LiveMaps.Matches(MegaCrit.Sts2.Core.Map.ActMap, System.Collections.Generic.IEnumerable<NationalSpire.RivalStep>, int)`；`NationalSpire.LiveMaps.Read(MegaCrit.Sts2.Core.Runs.IRunState, NationalSpire.CareerMatch, bool)`；`NationalSpire.LiveMatchState.MaxHp`；`NationalSpire.LiveMatchState.Steps`；`NationalSpire.LiveRaceHud.AddAction(string, System.Action)`；`NationalSpire.LiveRaceHud.LayoutChanged`；`NationalSpire.LiveRaceHud.Restore(NationalSpire.BroadcastUiState)`；`NationalSpire.LiveRaceHud.Say(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?)`；`NationalSpire.LiveRaceHud.SetRace(string, string, int, int, bool, double)`；`NationalSpire.LiveVoices.Byline(string, string)`；`NationalSpire.MatchRules.Time(double?)`；`NationalSpire.RivalProgress.Dead`；`NationalSpire.RivalProgress.Finished`；`NationalSpire.RivalProgress.Hp`；`NationalSpire.RivalProgress.Step`；`NationalSpire.RivalSimulation.At(NationalSpire.LiveMatchState, double)`；`NationalSpire.RivalSimulation.Create(NationalSpire.CareerMatch, NationalSpire.CareerPerson, System.Collections.Generic.IReadOnlyList<NationalSpire.RouteNode>, int)`；`NationalSpire.RivalSimulation.RoomName(string)`；`NationalSpire.RivalSimulation.Route(System.Collections.Generic.IReadOnlyList<NationalSpire.RouteNode>, NationalSpire.CareerPerson, string)`；`NationalSpire.RivalSimulation.TryAdjustPace(NationalSpire.LiveMatchState, double, int, int)`；`NationalSpire.RivalSimulation.UpgradeHealthPlan(NationalSpire.LiveMatchState, NationalSpire.CareerMatch, NationalSpire.CareerPerson, double)`；`NationalSpire.RivalStep.Act`；`NationalSpire.RivalStep.End`；`NationalSpire.RivalStep.Floor`；`NationalSpire.RivalStep.HpCheckpointFraction`；`NationalSpire.RivalStep.HpCheckpointSeconds`；`NationalSpire.RivalStep.Kind`；`NationalSpire.RivalStep.Start`；`NationalSpire.RouteNode.Act`；`NationalSpire.RouteNode.Children`；`NationalSpire.RouteNode.Col`；`NationalSpire.RouteNode.Row`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(_hud)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GodotObject.IsInstanceValid(_hud)`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`NRun.Instance.GlobalUi.AddChild(_hud)`；返回值紧邻使用处：`ExpressionStatementSyntax: NRun.Instance.GlobalUi.AddChild(_hud);`
- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`c.Title.GetFormattedText()`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Title.GetFormattedText() == npc.Character`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`p.Character.Id.ToString()`；返回值紧邻使用处：`ArgumentSyntax: p.Character.Id.ToString()`
- `MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；输入表达式：`RunManager.Instance.DebugOnlyGetState()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RunManager.Instance.DebugOnlyGetState()`
- `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`AvatarHonors.ForPerson(session.World.World, id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: id.Length > 0 ? AvatarHonors.ForPerson(session.World.World, id) : null`
- `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.ForPerson(session.World.World, id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: id.Length > 0 ? CareerAvatars.ForPerson(session.World.World, id) : null`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(session.World.World, id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: id.Length > 0 ? CareerEngine.DisplayName(session.World.World, id) : "现场"`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(session.World.World, rival.Key)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.DisplayName(session.World.World, rival.Key) + $"  {RivalSimulation.At(rival.Value, live.Clock).Hp}/{rival.Value.MaxHp}"`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(session.World.World, id)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(session.World.World, id)!`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(session.World.World, live.Opponents[0])`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(session.World.World, live.Opponents[0]) is { } teamLeader`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(session.World.World, live.Opponents[0])`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(session.World.World, live.Opponents[0])!`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(session.World.World, pair.Key)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(session.World.World, pair.Key) is { } npc`
- `NationalSpire.CommentatorSelection.Participants(NationalSpire.CareerData, NationalSpire.CareerMatch, System.Collections.Generic.IEnumerable<string>?)`；输入表达式：`CommentatorSelection.Participants(session.World.World, speechMatch, live.Opponents)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommentatorSelection.Participants(session.World.World, speechMatch, live.Opponents).Contains`
- `NationalSpire.Coop.CoopBroadcast.CoopBroadcast(NationalSpire.Coop.CoopCoordinator)`；输入表达式：`new(session)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _broadcast = new(session)`
- `NationalSpire.Coop.CoopBroadcast.Tick()`；输入表达式：`.Tick()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _broadcast?.Tick()`
- `NationalSpire.Coop.CoopCoordinator.PublishLive()`；输入表达式：`session.PublishLive()`；返回值紧邻使用处：`ExpressionStatementSyntax: session.PublishLive();`
- `NationalSpire.Coop.CoopLive.Close()`；输入表达式：`Close()`；返回值紧邻使用处：`ExpressionStatementSyntax: Close();`
- `NationalSpire.Coop.CoopLive.UpdateMap(NationalSpire.Coop.CoopRun, MegaCrit.Sts2.Core.Map.ActMap, int)`；输入表达式：`UpdateMap(live, state.Map, state.CurrentActIndex)`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateMap(live, state.Map, state.CurrentActIndex);`
- `NationalSpire.Coop.CoopLivePlayer.CoopLivePlayer(ulong, string, int, int, bool)`；输入表达式：`new CoopLivePlayer(p.NetId, p.Character.Id.ToString(), p.Creature.CurrentHp, p.Creature.MaxHp, p.Creature.CurrentHp <= 0)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => new CoopLivePlayer(p.NetId, p.Character.Id.ToString(), p.Creature.CurrentHp, p.Creature.MaxHp, p.Creature.CurrentHp <= 0)`
- `NationalSpire.Coop.CoopSettings.SaveLayout(NationalSpire.BroadcastUiState)`；输入表达式：`CoopSettings.SaveLayout(layout)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopSettings.SaveLayout(layout);`
- `NationalSpire.Diagnostics.RecordMatch(NationalSpire.Coop.CoopWorld, string, object?, bool)`；输入表达式：`Diagnostics.RecordMatch(session.World, "route-created", includePlan: true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.RecordMatch(session.World, "route-created", includePlan: true);`
- `NationalSpire.Diagnostics.RecordMatch(NationalSpire.Coop.CoopWorld, string, object?, bool)`；输入表达式：`Diagnostics.RecordMatch(session.World, stage, new              {                  session.Host, displayed = lines, localClock = RunManager.Instance.RunTime, localFloor = state.TotalFloor,                  localAct = state.CurrentActIndex, row = state.CurrentMapPoint?.coord.row, col = state.CurrentMapPoint?.coord.col,                  room = state.CurrentRoom?.RoomType.ToString(), localPlayers              }, includePlan: attached || planChanged || _diagnosticResume != live.ResumeCount)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.RecordMatch(session.World, stage, new              {                  session.Host, displayed = lines, localClock = RunManager.Instance.RunTime, localFloor = state.TotalFloor,                  localAct = state.CurrentActIndex, row = state.CurrentMapPoint?.coord.row, col = state.CurrentMapPoint?.coord.col,                  room = state.CurrentRoom?.RoomType.ToString(), localPlayers              }, includePlan: attached || planChanged || _diagnosticResume != live.ResumeCount);`
- `NationalSpire.GameBridge.Characters()`；输入表达式：`GameBridge.Characters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameBridge.Characters().FirstOrDefault`
- `NationalSpire.LiveMaps.Matches(MegaCrit.Sts2.Core.Map.ActMap, System.Collections.Generic.IEnumerable<NationalSpire.RivalStep>, int)`；输入表达式：`LiveMaps.Matches(state.Map, live.Rival.Steps, state.CurrentActIndex)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !LiveMaps.Matches(state.Map, live.Rival.Steps, state.CurrentActIndex)`
- `NationalSpire.LiveMaps.Read(MegaCrit.Sts2.Core.Runs.IRunState, NationalSpire.CareerMatch, bool)`；输入表达式：`LiveMaps.Read(state, match, true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = LiveMaps.Read(state, match, true)`
- `NationalSpire.LiveRaceHud.AddAction(string, System.Action)`；输入表达式：`_hud.AddAction("暂停并离开房间", ConfirmStop)`；返回值紧邻使用处：`ExpressionStatementSyntax: _hud.AddAction("暂停并离开房间", ConfirmStop);`
- `NationalSpire.LiveRaceHud.LiveRaceHud()`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _hud = new()`
- `NationalSpire.LiveRaceHud.Restore(NationalSpire.BroadcastUiState)`；输入表达式：`_hud.Restore(_layout)`；返回值紧邻使用处：`ExpressionStatementSyntax: _hud.Restore(_layout);`
- `NationalSpire.LiveRaceHud.Say(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?)`；输入表达式：`_hud.Say(LiveVoices.Byline(id.Length > 0 ? CareerEngine.DisplayName(session.World.World, id) : "现场", speech.Role), speech.Text, speech.Topic,                  id.Length > 0 ? CareerAvatars.ForPerson(session.World.World, id) : null,                  id.Length > 0 ? AvatarHonors.ForPerson(session.World.World, id) : null)`；返回值紧邻使用处：`ExpressionStatementSyntax: _hud.Say(LiveVoices.Byline(id.Length > 0 ? CareerEngine.DisplayName(session.World.World, id) : "现场", speech.Role), speech.Text, speech.Topic,                  id.Length > 0 ? CareerAvatars.ForPerson(session.World.World, id) : null,                  id.Length > 0 ? AvatarHonors.ForPerson(session.World.World, id) : null);`
- `NationalSpire.LiveRaceHud.SetRace(string, string, int, int, bool, double)`；输入表达式：`_hud!.SetRace("团队赛事转播", string.Join("\n", lines), live.Players.Sum(p => p.Hp), live.Players.Sum(p => p.MaxHp), false, live.Clock)`；返回值紧邻使用处：`ExpressionStatementSyntax: _hud!.SetRace("团队赛事转播", string.Join("\n", lines), live.Players.Sum(p => p.Hp), live.Players.Sum(p => p.MaxHp), false, live.Clock);`
- `NationalSpire.LiveVoices.Byline(string, string)`；输入表达式：`LiveVoices.Byline(id.Length > 0 ? CareerEngine.DisplayName(session.World.World, id) : "现场", speech.Role)`；返回值紧邻使用处：`ArgumentSyntax: LiveVoices.Byline(id.Length > 0 ? CareerEngine.DisplayName(session.World.World, id) : "现场", speech.Role)`
- `NationalSpire.MatchRules.Time(double?)`；输入表达式：`MatchRules.Time(live.Clock)`；返回值紧邻使用处：`InterpolationSyntax: {MatchRules.Time(live.Clock)}`
- `NationalSpire.RivalSimulation.At(NationalSpire.LiveMatchState, double)`；输入表达式：`RivalSimulation.At(live.Rival, live.Clock)`；返回值紧邻使用处：`ConditionalExpressionSyntax: live.Rival is { Steps.Count: > 0 } ? RivalSimulation.At(live.Rival, live.Clock) : null`
- `NationalSpire.RivalSimulation.At(NationalSpire.LiveMatchState, double)`；输入表达式：`RivalSimulation.At(live.Rival, live.Clock)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RivalSimulation.At(live.Rival, live.Clock)`
- `NationalSpire.RivalSimulation.At(NationalSpire.LiveMatchState, double)`；输入表达式：`RivalSimulation.At(rival.Value, live.Clock)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: RivalSimulation.At(rival.Value, live.Clock).Hp`
- `NationalSpire.RivalSimulation.Create(NationalSpire.CareerMatch, NationalSpire.CareerPerson, System.Collections.Generic.IReadOnlyList<NationalSpire.RouteNode>, int)`；输入表达式：`RivalSimulation.Create(match, leader, shared, 80)`；返回值紧邻使用处：`AssignmentExpressionSyntax: live.Rival = RivalSimulation.Create(match, leader, shared, 80)`
- `NationalSpire.RivalSimulation.Create(NationalSpire.CareerMatch, NationalSpire.CareerPerson, System.Collections.Generic.IReadOnlyList<NationalSpire.RouteNode>, int)`；输入表达式：`RivalSimulation.Create(match, npc, shared, hp)`；返回值紧邻使用处：`AssignmentExpressionSyntax: live.RivalMembers[id] = RivalSimulation.Create(match, npc, shared, hp)`
- `NationalSpire.RivalSimulation.RoomName(string)`；输入表达式：`RivalSimulation.RoomName(progress.Step.Kind)`；返回值紧邻使用处：`BinaryExpressionSyntax: " · " + RivalSimulation.RoomName(progress.Step.Kind)`
- `NationalSpire.RivalSimulation.Route(System.Collections.Generic.IReadOnlyList<NationalSpire.RouteNode>, NationalSpire.CareerPerson, string)`；输入表达式：`RivalSimulation.Route(maps, leader, match.Seed)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RivalSimulation.Route(maps, leader, match.Seed)`
- `NationalSpire.RivalSimulation.TryAdjustPace(NationalSpire.LiveMatchState, double, int, int)`；输入表达式：`RivalSimulation.TryAdjustPace(live.Rival, live.Clock, live.Act, live.Floor)`；返回值紧邻使用处：`AssignmentExpressionSyntax: planChanged = RivalSimulation.TryAdjustPace(live.Rival, live.Clock, live.Act, live.Floor)`
- `NationalSpire.RivalSimulation.UpgradeHealthPlan(NationalSpire.LiveMatchState, NationalSpire.CareerMatch, NationalSpire.CareerPerson, double)`；输入表达式：`RivalSimulation.UpgradeHealthPlan(live.Rival, match, teamLeader, live.Clock)`；返回值紧邻使用处：`ExpressionStatementSyntax: RivalSimulation.UpgradeHealthPlan(live.Rival, match, teamLeader, live.Clock);`
- `NationalSpire.RivalSimulation.UpgradeHealthPlan(NationalSpire.LiveMatchState, NationalSpire.CareerMatch, NationalSpire.CareerPerson, double)`；输入表达式：`RivalSimulation.UpgradeHealthPlan(pair.Value, match, npc, live.Clock)`；返回值紧邻使用处：`ExpressionStatementSyntax: RivalSimulation.UpgradeHealthPlan(pair.Value, match, npc, live.Clock);`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", lines)`；返回值紧邻使用处：`ArgumentSyntax: string.Join("\n", lines)`
- `string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`string.Join(',', live.Players.Select(p => p.Dead))`；返回值紧邻使用处：`BinaryExpressionSyntax: $"{live.Attempt}:{live.ResumeCount}:{live.Phase}:{state.TotalFloor}:{live.Floor}:{state.CurrentRoom?.RoomType}:{rivalProgress?.Step.Floor}:{rivalProgress?.Finished}:{rivalProgress?.Dead}:"              + string.Join(',', localPlayers.Select(p => p.Dead)) + ":" + string.Join(',', live.Players.Select(p => p.Dead))`
- `string.Join<T>(char, System.Collections.Generic.IEnumerable<T>)`；输入表达式：`string.Join(',', localPlayers.Select(p => p.Dead))`；返回值紧邻使用处：`BinaryExpressionSyntax: $"{live.Attempt}:{live.ResumeCount}:{live.Phase}:{state.TotalFloor}:{live.Floor}:{state.CurrentRoom?.RoomType}:{rivalProgress?.Step.Floor}:{rivalProgress?.Finished}:{rivalProgress?.Dead}:"              + string.Join(',', localPlayers.Select(p => p.Dead))`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`_heard.Add(speech.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: _heard.Add(speech.Id);`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_heard.Contains(s.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_heard.Contains(s.Id)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`CommentatorSelection.Participants(session.World.World, speechMatch, live.Opponents).Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: speech.Role != "thought" && CommentatorSelection.Participants(session.World.World, speechMatch, live.Opponents).Contains(id)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`coordinates.Contains((n.Act, c.Row, c.Col))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => coordinates.Contains((n.Act, c.Row, c.Col))`
- `System.Collections.Generic.HashSet<T>.IntersectWith(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`_heard.IntersectWith(live.Speeches.Select(s => s.Id))`；返回值紧邻使用处：`ExpressionStatementSyntax: _heard.IntersectWith(live.Speeches.Select(s => s.Id));`
- `System.Collections.Generic.IEnumerable<T>.Order<T>()`；输入表达式：`live.Characters.Keys.Order()`；返回值紧邻使用处：`ArgumentSyntax: live.Characters.Keys.Order()`
- `System.Collections.Generic.IEnumerable<T>.Order<T>()`；输入表达式：`state.Players.Select(p => p.NetId).Order()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: state.Players.Select(p => p.NetId).Order().SequenceEqual`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`session.World.Members.First(m => m.SteamId == player.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: session.World.Members.First(m => m.SteamId == player.Id).Name`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`GameBridge.Characters().FirstOrDefault(c => c.Title.GetFormattedText() == npc.Character)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: GameBridge.Characters().FirstOrDefault(c => c.Title.GetFormattedText() == npc.Character)?.StartingHp`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`live.Players.Select(p => p.Dead)`；返回值紧邻使用处：`ArgumentSyntax: live.Players.Select(p => p.Dead)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`live.Speeches.Select(s => s.Id)`；返回值紧邻使用处：`ArgumentSyntax: live.Speeches.Select(s => s.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`localPlayers.Select(p => p.Dead)`；返回值紧邻使用处：`ArgumentSyntax: localPlayers.Select(p => p.Dead)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`route.Select(n => (n.Act, n.Row, n.Col))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: route.Select(n => (n.Act, n.Row, n.Col)).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`route.Select(n => n with { Children = n.Children.Where(c => coordinates.Contains((n.Act, c.Row, c.Col))).ToList() })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: route.Select(n => n with { Children = n.Children.Where(c => coordinates.Contains((n.Act, c.Row, c.Col))).ToList() }).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`state.Players.Select(p => new CoopLivePlayer(p.NetId, p.Character.Id.ToString(), p.Creature.CurrentHp, p.Creature.MaxHp, p.Creature.CurrentHp <= 0))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: state.Players.Select(p => new CoopLivePlayer(p.NetId, p.Character.Id.ToString(), p.Creature.CurrentHp, p.Creature.MaxHp, p.Creature.CurrentHp <= 0)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`state.Players.Select(p => p.NetId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: state.Players.Select(p => p.NetId).Order`
- `System.Collections.Generic.IEnumerable<TSource>.SequenceEqual<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`state.Players.Select(p => p.NetId).Order().SequenceEqual(live.Characters.Keys.Order())`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !state.Players.Select(p => p.NetId).Order().SequenceEqual(live.Characters.Keys.Order())`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`session.World.World.Matches.Single(m => m.Id == live.MatchId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = session.World.World.Matches.Single(m => m.Id == live.MatchId)`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`live.Players.Sum(p => p.Hp)`；返回值紧邻使用处：`ArgumentSyntax: live.Players.Sum(p => p.Hp)`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`live.Players.Sum(p => p.MaxHp)`；返回值紧邻使用处：`ArgumentSyntax: live.Players.Sum(p => p.MaxHp)`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`route.Select(n => (n.Act, n.Row, n.Col)).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = route.Select(n => (n.Act, n.Row, n.Col)).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`n.Children.Where(c => coordinates.Contains((n.Act, c.Row, c.Col))).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Children = n.Children.Where(c => coordinates.Contains((n.Act, c.Row, c.Col))).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`route.Select(n => n with { Children = n.Children.Where(c => coordinates.Contains((n.Act, c.Row, c.Col))).ToList() }).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = route.Select(n => n with { Children = n.Children.Where(c => coordinates.Contains((n.Act, c.Row, c.Col))).ToList() }).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`state.Players.Select(p => new CoopLivePlayer(p.NetId, p.Character.Id.ToString(), p.Creature.CurrentHp, p.Creature.MaxHp, p.Creature.CurrentHp <= 0)).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: live.Players = state.Players.Select(p => new CoopLivePlayer(p.NetId, p.Character.Id.ToString(), p.Creature.CurrentHp, p.Creature.MaxHp, p.Creature.CurrentHp <= 0)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`state.Players.Select(p => new CoopLivePlayer(p.NetId, p.Character.Id.ToString(), p.Creature.CurrentHp, p.Creature.MaxHp, p.Creature.CurrentHp <= 0)).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = state.Players.Select(p => new CoopLivePlayer(p.NetId, p.Character.Id.ToString(), p.Creature.CurrentHp, p.Creature.MaxHp, p.Creature.CurrentHp <= 0)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`live.Speeches.Where(s => !_heard.Contains(s.Id))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var speech in live.Speeches.Where(s => !_heard.Contains(s.Id)))          {              _heard.Add(speech.Id); string id = speech.Speaker;              var speechMatch = session.World.World.Matches.Single(m => m.Id == live.MatchId);              if (speech.Role != "thought" && CommentatorSelection.Participants(session.World.World, speechMatch, live.Opponents).Contains(id)) continue;              _hud.Say(LiveVoices.Byline(id.Length > 0 ? CareerEngine.DisplayName(session.World.World, id) : "现场", speech.Role), speech.Text, speech.Topic,                  id.Length > 0 ? CareerAvatars.ForPerson(session.World.World, id) : null,                  id.Length > 0 ? AvatarHonors.ForPerson(session.World.World, id) : null);          }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`n.Children.Where(c => coordinates.Contains((n.Act, c.Row, c.Col)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: n.Children.Where(c => coordinates.Contains((n.Act, c.Row, c.Col))).ToList`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`lines.Add("队员连接中断，正在暂停比赛")`；返回值紧邻使用处：`ExpressionStatementSyntax: lines.Add("队员连接中断，正在暂停比赛");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`lines.Add($"\n对方第 {progress.Step.Act + 1} 幕 · {progress.Step.Floor} 层" + (progress.Finished ? progress.Dead ? " · 全队止步" : " · 已通关" : " · " + RivalSimulation.RoomName(progress.Step.Kind)))`；返回值紧邻使用处：`ExpressionStatementSyntax: lines.Add($"\n对方第 {progress.Step.Act + 1} 幕 · {progress.Step.Floor} 层" + (progress.Finished ? progress.Dead ? " · 全队止步" : " · 已通关" : " · " + RivalSimulation.RoomName(progress.Step.Kind)));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`lines.Add(CareerEngine.DisplayName(session.World.World, rival.Key) + $"  {RivalSimulation.At(rival.Value, live.Clock).Hp}/{rival.Value.MaxHp}")`；返回值紧邻使用处：`ExpressionStatementSyntax: lines.Add(CareerEngine.DisplayName(session.World.World, rival.Key) + $"  {RivalSimulation.At(rival.Value, live.Clock).Hp}/{rival.Value.MaxHp}");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`lines.Add(session.World.Members.First(m => m.SteamId == player.Id).Name + $"  {player.Hp}/{player.MaxHp}" + (player.Dead ? " · 暂时倒下" : ""))`；返回值紧邻使用处：`ExpressionStatementSyntax: lines.Add(session.World.Members.First(m => m.SteamId == player.Id).Name + $"  {player.Hp}/{player.MaxHp}" + (player.Dead ? " · 暂时倒下" : ""));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`live.Commentary.Add("双方队伍已经出发，本场按整队通关结果判定胜负。")`；返回值紧邻使用处：`ExpressionStatementSyntax: live.Commentary.Add("双方队伍已经出发，本场按整队通关结果判定胜负。");`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string> { "共同生涯  /  团队赛", $"我方第 {live.Act + 1} 幕 · {live.Floor} 层 · {MatchRules.Time(live.Clock)}" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string> { "共同生涯  /  团队赛", $"我方第 {live.Act + 1} 幕 · {live.Floor} 层 · {MatchRules.Time(live.Clock)}" }`
- `System.Enum.ToString()`；输入表达式：`.RoomType.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: state.CurrentRoom?.RoomType.ToString()`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(member.Steps.Count, live.Rival.Steps.Count)`；返回值紧邻使用处：`BinaryExpressionSyntax: i < Math.Min(member.Steps.Count, live.Rival.Steps.Count)`

**赋值（含属性/字段和局部值）：**

- `_attached` = `live.Attempt`
- `_broadcast` = `new(session)`
- `_diagnosticAttempt` = `live.Attempt`
- `_diagnosticResume` = `live.ResumeCount`
- `_diagnosticState` = `diagnosticState`
- `_hud.LayoutChanged` += `layout => { _layout = layout; CoopSettings.SaveLayout(layout); }`
- `_hud` = `new()`
- `_layout` = `layout`
- `Children` = `n.Children.Where(c => coordinates.Contains((n.Act, c.Row, c.Col))).ToList()`
- `lines[^1]` += `" · 独立路线"`
- `live.Act` = `state.CurrentActIndex`
- `live.Clock` = `RunManager.Instance.RunTime`
- `live.Floor` = `state.TotalFloor`
- `live.Players` = `state.Players.Select(p => new CoopLivePlayer(p.NetId, p.Character.Id.ToString(), p.Creature.CurrentHp, p.Creature.MaxHp, p.Creature.CurrentHp <= 0)).ToList()`
- `live.Rival` = `RivalSimulation.Create(match, leader, shared, 80)`
- `live.RivalMembers[id]` = `RivalSimulation.Create(match, npc, shared, hp)`
- `member.Steps[i].End` = `live.Rival.Steps[i].End`
- `member.Steps[i].HpCheckpointFraction` = `live.Rival.Steps[i].HpCheckpointFraction`
- `member.Steps[i].HpCheckpointSeconds` = `live.Rival.Steps[i].HpCheckpointSeconds`
- `member.Steps[i].Start` = `live.Rival.Steps[i].Start`
- `planChanged` = `RivalSimulation.TryAdjustPace(live.Rival, live.Clock, live.Act, live.Floor)`

<a id="symbol-30b59f1772bc"></a>

## `NationalSpire.Coop.CoopLive.ConfirmStop() — private void ConfirmStop()`

来源：源码第 113 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerVisuals.Box(string, string, int, int)`](../CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.CareerVisuals.CreateTheme()`](../CareerVisuals.cs.md#symbol-a5f88af9f360)；[`NationalSpire.Coop.CoopRuntime.Disconnect()`](CoopRuntime.cs.md#symbol-a4550fd42c36)；[`NationalSpire.Coop.CoopRuntime.Pause()`](CoopRuntime.cs.md#symbol-4d6b5e85d748)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](../Diagnostics.cs.md#symbol-cb39203375a5)；`Godot.Button.Button()`；`Godot.CenterContainer.CenterContainer()`；`Godot.Color.Color(float, float, float, float)`；`Godot.ColorRect.ColorRect()`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Label.Label()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.QueueFree()`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.CreateTheme()`；`NationalSpire.Coop.CoopRuntime.Current`；`NationalSpire.Coop.CoopRuntime.Disconnect()`；`NationalSpire.Coop.CoopRuntime.Pause()`；`NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button { Text = "继续比赛", CustomMinimumSize = new(180, 48) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Text = "继续比赛", CustomMinimumSize = new(180, 48) }`
- `Godot.Button.Button()`；输入表达式：`new Button { Text = "确认离开", CustomMinimumSize = new(180, 48) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Text = "确认离开", CustomMinimumSize = new(180, 48) }`
- `Godot.CenterContainer.CenterContainer()`；输入表达式：`new CenterContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CenterContainer()`
- `Godot.Color.Color(float, float, float, float)`；输入表达式：`new(0, 0, 0, .78f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Color = new(0, 0, 0, .78f)`
- `Godot.ColorRect.ColorRect()`；输入表达式：`new ColorRect { Color = new(0, 0, 0, .78f), Theme = CareerVisuals.CreateTheme() }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ColorRect { Color = new(0, 0, 0, .78f), Theme = CareerVisuals.CreateTheme() }`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("142431", "69dfd3", 12, 26))`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddThemeStyleboxOverride("panel", CareerVisuals.Box("142431", "69dfd3", 12, 26));`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`center.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: center.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`cover.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect)`；返回值紧邻使用处：`ExpressionStatementSyntax: cover.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(cover)`；返回值紧邻使用处：`IfStatementSyntax: if (GodotObject.IsInstanceValid(cover)) cover.QueueFree();`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HBoxContainer()`
- `Godot.Label.Label()`；输入表达式：`new Label { Text = "暂停并离开房间？\n保留最近一次安全检查点，当前战斗可能需要重打。\n其他队员会返回生涯等待，单人模式可以正常使用。" }`；返回值紧邻使用处：`ArgumentSyntax: new Label { Text = "暂停并离开房间？\n保留最近一次安全检查点，当前战斗可能需要重打。\n其他队员会返回生涯等待，单人模式可以正常使用。" }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(buttons)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(buttons);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(new Label { Text = "暂停并离开房间？\n保留最近一次安全检查点，当前战斗可能需要重打。\n其他队员会返回生涯等待，单人模式可以正常使用。" })`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(new Label { Text = "暂停并离开房间？\n保留最近一次安全检查点，当前战斗可能需要重打。\n其他队员会返回生涯等待，单人模式可以正常使用。" });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`buttons.AddChild(no)`；返回值紧邻使用处：`ExpressionStatementSyntax: buttons.AddChild(no);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`buttons.AddChild(yes)`；返回值紧邻使用处：`ExpressionStatementSyntax: buttons.AddChild(yes);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`center.AddChild(panel)`；返回值紧邻使用处：`ExpressionStatementSyntax: center.AddChild(panel);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`cover.AddChild(center)`；返回值紧邻使用处：`ExpressionStatementSyntax: cover.AddChild(center);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`NRun.Instance.GlobalUi.AddChild(cover)`；返回值紧邻使用处：`ExpressionStatementSyntax: NRun.Instance.GlobalUi.AddChild(cover);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`panel.AddChild(body)`；返回值紧邻使用处：`ExpressionStatementSyntax: panel.AddChild(body);`
- `Godot.Node.QueueFree()`；输入表达式：`cover.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: cover.QueueFree();`
- `Godot.Node.QueueFree()`；输入表达式：`cover.QueueFree()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => cover.QueueFree()`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { CustomMinimumSize = new(580, 180) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PanelContainer { CustomMinimumSize = new(580, 180) }`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(180, 48)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(180, 48)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(580, 180)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new(580, 180)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("142431", "69dfd3", 12, 26)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("142431", "69dfd3", 12, 26)`
- `NationalSpire.CareerVisuals.CreateTheme()`；输入表达式：`CareerVisuals.CreateTheme()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Theme = CareerVisuals.CreateTheme()`
- `NationalSpire.Coop.CoopRuntime.Disconnect()`；输入表达式：`CoopRuntime.Current.Disconnect()`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopRuntime.Current.Disconnect();`
- `NationalSpire.Coop.CoopRuntime.Pause()`；输入表达式：`CoopRuntime.Current!.Pause()`；返回值紧邻使用处：`AwaitExpressionSyntax: await CoopRuntime.Current!.Pause()`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("coop.stop", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("coop.stop", e);`

**赋值（含属性/字段和局部值）：**

- `Color` = `new(0, 0, 0, .78f)`
- `CustomMinimumSize` = `new(180, 48)`
- `CustomMinimumSize` = `new(580, 180)`
- `no.Disabled` = `true`
- `no.Pressed` += `() => cover.QueueFree()`
- `Text` = `"继续比赛"`
- `Text` = `"确认离开"`
- `Text` = `"暂停并离开房间？\n保留最近一次安全检查点，当前战斗可能需要重打。\n其他队员会返回生涯等待，单人模式可以正常使用。"`
- `Theme` = `CareerVisuals.CreateTheme()`
- `yes.Disabled` = `no.Disabled = true`
- `yes.Pressed` += `async () =>          {              yes.Disabled = no.Disabled = true;              try { await CoopRuntime.Current!.Pause(); CoopRuntime.Current.Disconnect(); }              catch (Exception e) { Diagnostics.Error("coop.stop", e); }              finally { if (GodotObject.IsInstanceValid(cover)) cover.QueueFree(); }          }`

<a id="symbol-3ddf0280ec69"></a>

## `NationalSpire.Coop.CoopLive.UpdateMap(NationalSpire.Coop.CoopRun, MegaCrit.Sts2.Core.Map.ActMap, int) — private void UpdateMap(CoopRun live, ActMap actualMap, int act)`

来源：源码第 134 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopLive.Update()`](CoopLive.cs.md#symbol-fe745d15ee63)

**调用：** [`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`](../AvatarHonors.cs.md#symbol-5207a1627331)；[`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`](../CareerAvatars.cs.md#symbol-cd3d95caefab)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](../CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.LiveCompatibility.MapPoints(Godot.Node)`](../LiveCompatibility.cs.md#symbol-e7d2ddafdb60)；[`NationalSpire.LiveMaps.Matches(MegaCrit.Sts2.Core.Map.ActMap, System.Collections.Generic.IEnumerable<NationalSpire.RivalStep>, int)`](../LiveMaps.cs.md#symbol-b7456baf6c82)；[`NationalSpire.RivalMapOverlay.UpdateState(System.Collections.Generic.List<Godot.Vector2>, Godot.Vector2?, string, int, int, bool)`](../LiveRaceHud.cs.md#symbol-683532d7c3b5)；[`NationalSpire.RivalSimulation.At(NationalSpire.LiveMatchState, double)`](../LiveMatch.cs.md#symbol-78308976d2a9)；[`Position(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint)`](CoopLive.cs.md#symbol-8820d151a354)；`Godot.CanvasItem.Hide()`；`Godot.CanvasItem.Show()`；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetParent()`；`Godot.Node.QueueFree()`；`Godot.Vector2.Vector2(float, float)`；`MegaCrit.Sts2.Core.Map.MapCoord.MapCoord(int, int)`；`NationalSpire.RivalMapOverlay.RivalMapOverlay()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.List()`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopLive._maps`；`NationalSpire.Coop.CoopRun.Clock`；`NationalSpire.Coop.CoopRun.Opponents`；`NationalSpire.Coop.CoopRun.Rival`；`NationalSpire.Coop.CoopRun.RivalMembers`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.LiveCompatibility.MapPoints(Godot.Node)`；`NationalSpire.LiveMaps.Matches(MegaCrit.Sts2.Core.Map.ActMap, System.Collections.Generic.IEnumerable<NationalSpire.RivalStep>, int)`；`NationalSpire.LiveMatchState.MaxHp`；`NationalSpire.LiveMatchState.Steps`；`NationalSpire.RivalMapOverlay.Art`；`NationalSpire.RivalMapOverlay.BadgeOffset`；`NationalSpire.RivalMapOverlay.Identity`；`NationalSpire.RivalMapOverlay.UpdateState(System.Collections.Generic.List<Godot.Vector2>, Godot.Vector2?, string, int, int, bool)`；`NationalSpire.RivalProgress.Dead`；`NationalSpire.RivalProgress.Hp`；`NationalSpire.RivalProgress.Step`；`NationalSpire.RivalSimulation.At(NationalSpire.LiveMatchState, double)`；`NationalSpire.RivalStep.Act`；`NationalSpire.RivalStep.Col`；`NationalSpire.RivalStep.Row`；`NationalSpire.RivalStep.Start`；`Position(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`map.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: map.Hide();`
- `Godot.CanvasItem.Show()`；输入表达式：`overlay.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: overlay.Show();`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(old)`；返回值紧邻使用处：`BinaryExpressionSyntax: _maps.TryGetValue(id, out var old) && GodotObject.IsInstanceValid(old)`
- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(overlay)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GodotObject.IsInstanceValid(overlay)`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`parent.AddChild(overlay)`；返回值紧邻使用处：`ExpressionStatementSyntax: parent.AddChild(overlay);`
- `Godot.Node.GetParent()`；输入表达式：`old.GetParent()`；返回值紧邻使用处：`BinaryExpressionSyntax: old.GetParent() != parent`
- `Godot.Node.GetParent()`；输入表达式：`points.Values.First().GetParent()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = points.Values.First().GetParent()`
- `Godot.Node.QueueFree()`；输入表达式：`old.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: old.QueueFree();`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(25 + i / 2 * 240, -48 + i % 2 * 78)`；返回值紧邻使用处：`AssignmentExpressionSyntax: BadgeOffset = new(25 + i / 2 * 240, -48 + i % 2 * 78)`
- `MegaCrit.Sts2.Core.Map.MapCoord.MapCoord(int, int)`；输入表达式：`new(progress.Step.Col, progress.Step.Row)`；返回值紧邻使用处：`ArgumentSyntax: new(progress.Step.Col, progress.Step.Row)`
- `MegaCrit.Sts2.Core.Map.MapCoord.MapCoord(int, int)`；输入表达式：`new(s.Col, s.Row)`；返回值紧邻使用处：`ArgumentSyntax: new(s.Col, s.Row)`
- `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`AvatarHonors.ForPerson(session.World.World, id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Identity = AvatarHonors.ForPerson(session.World.World, id)`
- `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.ForPerson(session.World!.World, id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Art = CareerAvatars.ForPerson(session.World!.World, id)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(session.World!.World, id)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.DisplayName(session.World!.World, id)`
- `NationalSpire.LiveCompatibility.MapPoints(Godot.Node)`；输入表达式：`LiveCompatibility.MapPoints(screen)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = LiveCompatibility.MapPoints(screen)`
- `NationalSpire.LiveMaps.Matches(MegaCrit.Sts2.Core.Map.ActMap, System.Collections.Generic.IEnumerable<NationalSpire.RivalStep>, int)`；输入表达式：`LiveMaps.Matches(actualMap, live.Rival.Steps, act)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !LiveMaps.Matches(actualMap, live.Rival.Steps, act)`
- `NationalSpire.RivalMapOverlay.RivalMapOverlay()`；输入表达式：`new RivalMapOverlay { Art = CareerAvatars.ForPerson(session.World!.World, id), Identity = AvatarHonors.ForPerson(session.World.World, id),                      BadgeOffset = new(25 + i / 2 * 240, -48 + i % 2 * 78) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: overlay = new RivalMapOverlay { Art = CareerAvatars.ForPerson(session.World!.World, id), Identity = AvatarHonors.ForPerson(session.World.World, id),                      BadgeOffset = new(25 + i / 2 * 240, -48 + i % 2 * 78) }`
- `NationalSpire.RivalMapOverlay.UpdateState(System.Collections.Generic.List<Godot.Vector2>, Godot.Vector2?, string, int, int, bool)`；输入表达式：`overlay.UpdateState(path, at, CareerEngine.DisplayName(session.World!.World, id), progress.Hp, member.MaxHp, progress.Dead)`；返回值紧邻使用处：`ExpressionStatementSyntax: overlay.UpdateState(path, at, CareerEngine.DisplayName(session.World!.World, id), progress.Hp, member.MaxHp, progress.Dead);`
- `NationalSpire.RivalSimulation.At(NationalSpire.LiveMatchState, double)`；输入表达式：`RivalSimulation.At(member, live.Clock)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RivalSimulation.At(member, live.Clock)`
- `Position(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint)`；输入表达式：`Position(point)`；返回值紧邻使用处：`ConditionalExpressionSyntax: progress.Step.Act == act && points.TryGetValue(new(progress.Step.Col, progress.Step.Row), out var point) ? Position(point) : null`
- `Position(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint)`；输入表达式：`Position(points[new(s.Col, s.Row)])`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: s => Position(points[new(s.Col, s.Row)])`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`points.ContainsKey(new(s.Col, s.Row))`；返回值紧邻使用处：`BinaryExpressionSyntax: s.Act == act && s.Start <= live.Clock && points.ContainsKey(new(s.Col, s.Row))`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`_maps.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: _maps.Remove(id);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_maps.TryGetValue(id, out var old)`；返回值紧邻使用处：`BinaryExpressionSyntax: _maps.TryGetValue(id, out var old) && GodotObject.IsInstanceValid(old)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_maps.TryGetValue(id, out var overlay)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_maps.TryGetValue(id, out var overlay)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`live.RivalMembers.TryGetValue(id, out var member)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !live.RivalMembers.TryGetValue(id, out var member)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`points.TryGetValue(new(progress.Step.Col, progress.Step.Row), out var point)`；返回值紧邻使用处：`BinaryExpressionSyntax: progress.Step.Act == act && points.TryGetValue(new(progress.Step.Col, progress.Step.Row), out var point)`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；输入表达式：`points.Values.First()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: points.Values.First().GetParent`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`live.Rival.Steps.Where(s => s.Act == act && s.Start <= live.Clock && points.ContainsKey(new(s.Col, s.Row))).Select(s => Position(points[new(s.Col, s.Row)]))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: live.Rival.Steps.Where(s => s.Act == act && s.Start <= live.Clock && points.ContainsKey(new(s.Col, s.Row))).Select(s => Position(points[new(s.Col, s.Row)])).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`live.Rival.Steps.Where(s => s.Act == act && s.Start <= live.Clock && points.ContainsKey(new(s.Col, s.Row))).Select(s => Position(points[new(s.Col, s.Row)])).ToList()`；返回值紧邻使用处：`ConditionalExpressionSyntax: i == 0 ? live.Rival.Steps.Where(s => s.Act == act && s.Start <= live.Clock && points.ContainsKey(new(s.Col, s.Row))).Select(s => Position(points[new(s.Col, s.Row)])).ToList() : new List<Vector2>()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_maps.Values.Where(GodotObject.IsInstanceValid)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var map in _maps.Values.Where(GodotObject.IsInstanceValid)) map.Hide();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`live.Rival.Steps.Where(s => s.Act == act && s.Start <= live.Clock && points.ContainsKey(new(s.Col, s.Row)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: live.Rival.Steps.Where(s => s.Act == act && s.Start <= live.Clock && points.ContainsKey(new(s.Col, s.Row))).Select`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Vector2>()`；返回值紧邻使用处：`ConditionalExpressionSyntax: i == 0 ? live.Rival.Steps.Where(s => s.Act == act && s.Start <= live.Clock && points.ContainsKey(new(s.Col, s.Row))).Select(s => Position(points[new(s.Col, s.Row)])).ToList() : new List<Vector2>()`

**赋值（含属性/字段和局部值）：**

- `_maps[id]` = `overlay`
- `Art` = `CareerAvatars.ForPerson(session.World!.World, id)`
- `BadgeOffset` = `new(25 + i / 2 * 240, -48 + i % 2 * 78)`
- `Identity` = `AvatarHonors.ForPerson(session.World.World, id)`
- `overlay` = `new RivalMapOverlay { Art = CareerAvatars.ForPerson(session.World!.World, id), Identity = AvatarHonors.ForPerson(session.World.World, id),                      BadgeOffset = new(25 + i / 2 * 240, -48 + i % 2 * 78) }`

<a id="symbol-8820d151a354"></a>

## `Position(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint) — Vector2 Position(NMapPoint point)`

来源：源码第 155 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopLive.UpdateMap(NationalSpire.Coop.CoopRun, MegaCrit.Sts2.Core.Map.ActMap, int)`](CoopLive.cs.md#symbol-3ddf0280ec69)

**调用：** `Godot.CanvasItem.GetGlobalTransformWithCanvas()`；`Godot.Transform2D.AffineInverse()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.GetGlobalTransformWithCanvas()`；输入表达式：`overlay.GetGlobalTransformWithCanvas()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: overlay.GetGlobalTransformWithCanvas().AffineInverse`
- `Godot.CanvasItem.GetGlobalTransformWithCanvas()`；输入表达式：`point.GetGlobalTransformWithCanvas()`；返回值紧邻使用处：`BinaryExpressionSyntax: point.GetGlobalTransformWithCanvas() * (point is NNormalMapPoint ? Vector2.Zero : point.Size * .5f)`
- `Godot.Transform2D.AffineInverse()`；输入表达式：`overlay.GetGlobalTransformWithCanvas().AffineInverse()`；返回值紧邻使用处：`BinaryExpressionSyntax: overlay.GetGlobalTransformWithCanvas().AffineInverse() * (point.GetGlobalTransformWithCanvas() * (point is NNormalMapPoint ? Vector2.Zero : point.Size * .5f))`

**赋值（含属性/字段和局部值）：**
