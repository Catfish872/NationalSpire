# LiveDateGame.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`C58A838806356854630738B739481E1914FF406063CAF44BADB3B499A0C1F22D`。来源：[源码](../../LiveDateGame.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LiveRunBridge`、`NationalSpire.DateGamePause`。

字段、事件及初始值（源码原样）：

```csharp
private DateGamePause? _datePause;
private Button? _dateChatAction;
private LiveRequestButton? _dateRespondAction;
private bool _datePauseAccepted, _dateRespondRequested;
private double _dateOpenRetry;
private double _dateRequestSeconds = -1;
private double _dateCombatStarted = -1;
private int _dateCombatAct;
private readonly Dictionary<string, (AvatarArt Art, AvatarIdentity Identity)> _dateAvatars = [];
private bool _acquired, _queuesWerePaused;
private readonly ulong _player;
```

<a id="symbol-9805b9d468fe"></a>

## `NationalSpire.LiveRunBridge.DateGameMatchId — internal string DateGameMatchId`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMatch.DateGame`；`NationalSpire.CareerMatch.Id`；`NationalSpire.LiveRunBridge._match`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4bd2094f6d33"></a>

## `NationalSpire.LiveRunBridge.AdvanceDateRequestClock(double, double, bool) — private void AdvanceDateRequestClock(double delta, double runSeconds, bool paused)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge._Process(double)`](LiveRunBridge.cs.md#symbol-d7e63bc009ff)

**调用：** `System.Math.Max(double, double)`

**字段、属性、事件及方法组引用：** `NationalSpire.LiveRunBridge._dateRequestSeconds`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Max(double, double)`；输入表达式：`Math.Max(0, delta)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateRequestSeconds += Math.Max(0, delta)`

**赋值（含属性/字段和局部值）：**

- `_dateRequestSeconds` += `Math.Max(0, delta)`
- `_dateRequestSeconds` = `runSeconds`

<a id="symbol-cb87a418530f"></a>

## `NationalSpire.LiveRunBridge.UpdateDateGame(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, double, ref bool) — private void UpdateDateGame(LiveMatchState live, RivalProgress primary, double seconds, ref bool changed)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.RefreshRace(ref bool)`](LiveRunBridge.cs.md#symbol-f03ac37c2ac4)

**调用：** `MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry.GetEntry(ulong)`；[`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-5207a1627331)；[`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-cd3d95caefab)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；`NationalSpire.CareerMatch.CareerMatch()`；`NationalSpire.DateGameNpc.DateGameNpc(string, NationalSpire.RivalProgress, int)`；`NationalSpire.DateGameObservation.DateGameObservation(int, int, int, int, double, int)`；[`NationalSpire.DateGameTriggers.Next(NationalSpire.DateGameState, System.Collections.Generic.IReadOnlyList<NationalSpire.DateGameRule>, NationalSpire.DateGameObservation, System.Collections.Generic.IReadOnlyList<NationalSpire.DateGameNpc>, int, NationalSpire.DateGameTiming?)`](DateGameTriggers.cs.md#symbol-7f66f37eeebc)；[`NationalSpire.DateGameTriggers.Observe(NationalSpire.DateGameState, NationalSpire.DateGameObservation, System.Collections.Generic.IReadOnlyList<NationalSpire.DateGameNpc>)`](DateGameTriggers.cs.md#symbol-74a3c78bf5b0)；[`NationalSpire.DateGameTriggers.Record(NationalSpire.DateGameState, NationalSpire.DateGameCue, double)`](DateGameTriggers.cs.md#symbol-5883a6a9a040)；[`NationalSpire.DateGameVoices.Event(NationalSpire.CareerData, NationalSpire.DateGameState, NationalSpire.DateGameCue, int)`](DateGameVoices.cs.md#symbol-feac45068c6c)；[`NationalSpire.DateGames.RequestChat(NationalSpire.CareerData, NationalSpire.DateGameState, string, string, string, double)`](DateGames.cs.md#symbol-5947a9bb0cb9)；[`NationalSpire.DateGames.TickChatRequest(NationalSpire.CareerData, NationalSpire.DateGameState, double, bool)`](DateGames.cs.md#symbol-924652d5a4a0)；[`NationalSpire.GameCharacterNames.StartingHp(string)`](GameCharacterNames.cs.md#symbol-1bb238743407)；[`NationalSpire.LiveRaceHud.Say(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?)`](LiveRaceHud.cs.md#symbol-1fd8ee1cca63)；[`NationalSpire.LiveRaceHud.SetRace(string, string, int, int, bool, double)`](LiveRaceHud.cs.md#symbol-cfd9d62c7d32)；[`NationalSpire.LiveRunBridge.CanOpenDateChat()`](LiveDateGame.cs.md#symbol-ae2a19aa7c3a)；[`NationalSpire.LiveRunBridge.OpenDateGameChat(double)`](LiveDateGame.cs.md#symbol-6383bcf560b6)；[`NationalSpire.LiveRunBridge.PlanningMap()`](LiveRunBridge.cs.md#symbol-733c41e89044)；[`NationalSpire.LiveRunBridge.UpdateDateGameAction(NationalSpire.DateGameState, double)`](LiveDateGame.cs.md#symbol-e4061f52dd90)；[`NationalSpire.MatchRules.PrepareOpponent(NationalSpire.CareerData, NationalSpire.CareerMatch)`](MatchRules.cs.md#symbol-cc58cecfce28)；[`NationalSpire.MatchRules.Time(double?)`](MatchRules.cs.md#symbol-13ecc28f8403)；[`NationalSpire.RivalSimulation.At(NationalSpire.LiveMatchState, double)`](LiveMatch.cs.md#symbol-78308976d2a9)；[`NationalSpire.RivalSimulation.Create(NationalSpire.CareerMatch, NationalSpire.CareerPerson, System.Collections.Generic.IReadOnlyList<NationalSpire.RouteNode>, int)`](LiveMatch.cs.md#symbol-d351643744da)；[`NationalSpire.RivalSimulation.RoomName(string)`](LiveMatch.cs.md#symbol-2c599e9f210a)；[`NationalSpire.RivalSimulation.TryAdjustPace(NationalSpire.LiveMatchState, double, int, int)`](LiveMatch.cs.md#symbol-719ee73c10ff)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Math.Max(int, int)`；`System.Random.Next()`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.BroadcastMemory.LastSpoke`；`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.DateGameRules`；`NationalSpire.CareerData.DateGameTiming`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerMatch.ChosenAscension`；`NationalSpire.CareerMatch.DateGame`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CareerMatch.Live`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.RequiredAscension`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.CareerMatch.SeedRandomized`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CareerPerson.Id`；`NationalSpire.DateGameCue.Chat`；`NationalSpire.DateGameCue.Context`；`NationalSpire.DateGameCue.Key`；`NationalSpire.DateGameCue.Person`；`NationalSpire.DateGameNpc.MaxHp`；`NationalSpire.DateGameNpc.Person`；`NationalSpire.DateGameNpc.Progress`；`NationalSpire.DateGameObservation.Act`；`NationalSpire.DateGameObservation.Floor`；`NationalSpire.DateGameObservation.Hp`；`NationalSpire.DateGameObservation.MaxHp`；`NationalSpire.DateGameObservation.Seconds`；`NationalSpire.DateGameState.Companions`；`NationalSpire.DateGameState.PendingChat`；`NationalSpire.DateGameState.People`；`NationalSpire.DateGameState.Snapshot`；`NationalSpire.DateGameTiming.SpeechSeconds`；`NationalSpire.DateGameTriggers.Next(NationalSpire.DateGameState, System.Collections.Generic.IReadOnlyList<NationalSpire.DateGameRule>, NationalSpire.DateGameObservation, System.Collections.Generic.IReadOnlyList<NationalSpire.DateGameNpc>, int, NationalSpire.DateGameTiming?)`；`NationalSpire.DateGameTriggers.Observe(NationalSpire.DateGameState, NationalSpire.DateGameObservation, System.Collections.Generic.IReadOnlyList<NationalSpire.DateGameNpc>)`；`NationalSpire.DateGameTriggers.Record(NationalSpire.DateGameState, NationalSpire.DateGameCue, double)`；`NationalSpire.DateGameVoices.Event(NationalSpire.CareerData, NationalSpire.DateGameState, NationalSpire.DateGameCue, int)`；`NationalSpire.DateGames.RequestChat(NationalSpire.CareerData, NationalSpire.DateGameState, string, string, string, double)`；`NationalSpire.DateGames.TickChatRequest(NationalSpire.CareerData, NationalSpire.DateGameState, double, bool)`；`NationalSpire.GameCharacterNames.StartingHp(string)`；`NationalSpire.LiveMatchState.Commentary`；`NationalSpire.LiveMatchState.MaxHp`；`NationalSpire.LiveMatchState.Steps`；`NationalSpire.LiveRaceHud.Say(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?)`；`NationalSpire.LiveRaceHud.SetRace(string, string, int, int, bool, double)`；`NationalSpire.LiveRunBridge.CanOpenDateChat()`；`NationalSpire.LiveRunBridge.OpenDateGameChat(double)`；`NationalSpire.LiveRunBridge.PlanningMap()`；`NationalSpire.LiveRunBridge.UpdateDateGameAction(NationalSpire.DateGameState, double)`；`NationalSpire.LiveRunBridge._data`；`NationalSpire.LiveRunBridge._dateAvatars`；`NationalSpire.LiveRunBridge._dateOpenRetry`；`NationalSpire.LiveRunBridge._datePause`；`NationalSpire.LiveRunBridge._datePauseAccepted`；`NationalSpire.LiveRunBridge._dateRequestSeconds`；`NationalSpire.LiveRunBridge._hud`；`NationalSpire.LiveRunBridge._match`；`NationalSpire.LiveRunBridge._player`；`NationalSpire.LiveRunBridge._rival`；`NationalSpire.LiveRunBridge._run`；`NationalSpire.MatchRules.PrepareOpponent(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.MatchRules.Time(double?)`；`NationalSpire.RivalProgress.Dead`；`NationalSpire.RivalProgress.Finished`；`NationalSpire.RivalProgress.Hp`；`NationalSpire.RivalProgress.Step`；`NationalSpire.RivalSimulation.At(NationalSpire.LiveMatchState, double)`；`NationalSpire.RivalSimulation.Create(NationalSpire.CareerMatch, NationalSpire.CareerPerson, System.Collections.Generic.IReadOnlyList<NationalSpire.RouteNode>, int)`；`NationalSpire.RivalSimulation.RoomName(string)`；`NationalSpire.RivalSimulation.TryAdjustPace(NationalSpire.LiveMatchState, double, int, int)`；`NationalSpire.RivalStep.Act`；`NationalSpire.RivalStep.Floor`；`NationalSpire.RivalStep.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry.GetEntry(ulong)`；输入表达式：`.GetEntry(_player.NetId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .GetEntry(_player.NetId)?.GoldSpent`
- `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`AvatarHonors.ForPerson(_data, cue.Person)`；返回值紧邻使用处：`ArgumentSyntax: AvatarHonors.ForPerson(_data, cue.Person)`
- `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.ForPerson(_data, cue.Person)`；返回值紧邻使用处：`ArgumentSyntax: CareerAvatars.ForPerson(_data, cue.Person)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(_data, cue.Person)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.DisplayName(_data, cue.Person)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(_data, n.Person)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.DisplayName(_data, n.Person)}`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(_data, n.Person)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.DisplayName(_data, n.Person) + (n.Progress.Dead ? "已倒下" : $" {n.Progress.Step.Floor}层")`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(_data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Person(_data, person)`
- `NationalSpire.CareerMatch.CareerMatch()`；输入表达式：`new() { Id = _match.Id + "/" + person, Kind = "private-friendly", Day = _match.Day, Seed = _match.Seed, SeedRandomized = true, RequiredAscension = _match.RequiredAscension, ChosenAscension = _match.ChosenAscension, OpponentId = person }`；返回值紧邻使用处：`AssignmentExpressionSyntax: companion = new() { Id = _match.Id + "/" + person, Kind = "private-friendly", Day = _match.Day, Seed = _match.Seed, SeedRandomized = true, RequiredAscension = _match.RequiredAscension, ChosenAscension = _match.ChosenAscension, OpponentId = person }`
- `NationalSpire.DateGameNpc.DateGameNpc(string, NationalSpire.RivalProgress, int)`；输入表达式：`new(_rival.Id, primary, live.MaxHp)`；返回值紧邻使用处：`InitializerExpressionSyntax: { new(_rival.Id, primary, live.MaxHp) }`
- `NationalSpire.DateGameNpc.DateGameNpc(string, NationalSpire.RivalProgress, int)`；输入表达式：`new(person, RivalSimulation.At(companion.Live, seconds), companion.Live.MaxHp)`；返回值紧邻使用处：`ArgumentSyntax: new(person, RivalSimulation.At(companion.Live, seconds), companion.Live.MaxHp)`
- `NationalSpire.DateGameObservation.DateGameObservation(int, int, int, int, double, int)`；输入表达式：`new DateGameObservation(_run.TotalFloor, _run.CurrentActIndex, _player.Creature.CurrentHp, _player.Creature.MaxHp, seconds, _run.CurrentMapPointHistoryEntry?.GetEntry(_player.NetId)?.GoldSpent ?? 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new DateGameObservation(_run.TotalFloor, _run.CurrentActIndex, _player.Creature.CurrentHp, _player.Creature.MaxHp, seconds, _run.CurrentMapPointHistoryEntry?.GetEntry(_player.NetId)?.GoldSpent ?? 0)`
- `NationalSpire.DateGameTriggers.Next(NationalSpire.DateGameState, System.Collections.Generic.IReadOnlyList<NationalSpire.DateGameRule>, NationalSpire.DateGameObservation, System.Collections.Generic.IReadOnlyList<NationalSpire.DateGameNpc>, int, NationalSpire.DateGameTiming?)`；输入表达式：`DateGameTriggers.Next(game, _data.DateGameRules, player with { Seconds = requestSeconds }, npcs, Random.Shared.Next(), _data.DateGameTiming)`；返回值紧邻使用处：`IsPatternExpressionSyntax: DateGameTriggers.Next(game, _data.DateGameRules, player with { Seconds = requestSeconds }, npcs, Random.Shared.Next(), _data.DateGameTiming) is { } cue`
- `NationalSpire.DateGameTriggers.Observe(NationalSpire.DateGameState, NationalSpire.DateGameObservation, System.Collections.Generic.IReadOnlyList<NationalSpire.DateGameNpc>)`；输入表达式：`DateGameTriggers.Observe(game, player, npcs)`；返回值紧邻使用处：`AssignmentExpressionSyntax: changed |= DateGameTriggers.Observe(game, player, npcs)`
- `NationalSpire.DateGameTriggers.Record(NationalSpire.DateGameState, NationalSpire.DateGameCue, double)`；输入表达式：`DateGameTriggers.Record(game, cue, requestSeconds)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateGameTriggers.Record(game, cue, requestSeconds);`
- `NationalSpire.DateGameVoices.Event(NationalSpire.CareerData, NationalSpire.DateGameState, NationalSpire.DateGameCue, int)`；输入表达式：`DateGameVoices.Event(_data, game, cue, Random.Shared.Next())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateGameVoices.Event(_data, game, cue, Random.Shared.Next())`
- `NationalSpire.DateGames.RequestChat(NationalSpire.CareerData, NationalSpire.DateGameState, string, string, string, double)`；输入表达式：`DateGames.RequestChat(_data, game, cue.Person, line, cue.Context, requestSeconds)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateGames.RequestChat(_data, game, cue.Person, line, cue.Context, requestSeconds);`
- `NationalSpire.DateGames.TickChatRequest(NationalSpire.CareerData, NationalSpire.DateGameState, double, bool)`；输入表达式：`DateGames.TickChatRequest(_data, game, requestSeconds, _datePauseAccepted)`；返回值紧邻使用处：`AssignmentExpressionSyntax: changed |= DateGames.TickChatRequest(_data, game, requestSeconds, _datePauseAccepted)`
- `NationalSpire.GameCharacterNames.StartingHp(string)`；输入表达式：`GameCharacterNames.StartingHp(npc.Character)`；返回值紧邻使用处：`ArgumentSyntax: GameCharacterNames.StartingHp(npc.Character)`
- `NationalSpire.LiveRaceHud.Say(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?)`；输入表达式：`_hud.Say(CareerEngine.DisplayName(_data, cue.Person), line, "date/" + cue.Key, appearance.Art, appearance.Identity)`；返回值紧邻使用处：`ExpressionStatementSyntax: _hud.Say(CareerEngine.DisplayName(_data, cue.Person), line, "date/" + cue.Key, appearance.Art, appearance.Identity);`
- `NationalSpire.LiveRaceHud.SetRace(string, string, int, int, bool, double)`；输入表达式：`_hud.SetRace("约会对局", string.Join(" · ", npcs.Select(n => CareerEngine.DisplayName(_data, n.Person) + (n.Progress.Dead ? "已倒下" : $" {n.Progress.Step.Floor}层"))), primary.Hp, live.MaxHp, false, seconds)`；返回值紧邻使用处：`ExpressionStatementSyntax: _hud.SetRace("约会对局", string.Join(" · ", npcs.Select(n => CareerEngine.DisplayName(_data, n.Person) + (n.Progress.Dead ? "已倒下" : $" {n.Progress.Step.Floor}层"))), primary.Hp, live.MaxHp, false, seconds);`
- `NationalSpire.LiveRunBridge.CanOpenDateChat()`；输入表达式：`CanOpenDateChat()`；返回值紧邻使用处：`BinaryExpressionSyntax: _datePauseAccepted && seconds >= _dateOpenRetry && CanOpenDateChat()`
- `NationalSpire.LiveRunBridge.OpenDateGameChat(double)`；输入表达式：`OpenDateGameChat(seconds)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenDateGameChat(seconds);`
- `NationalSpire.LiveRunBridge.PlanningMap()`；输入表达式：`PlanningMap()`；返回值紧邻使用处：`ArgumentSyntax: PlanningMap()`
- `NationalSpire.LiveRunBridge.UpdateDateGameAction(NationalSpire.DateGameState, double)`；输入表达式：`UpdateDateGameAction(game, requestSeconds)`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateDateGameAction(game, requestSeconds);`
- `NationalSpire.MatchRules.PrepareOpponent(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`MatchRules.PrepareOpponent(_data, companion)`；返回值紧邻使用处：`ExpressionStatementSyntax: MatchRules.PrepareOpponent(_data, companion);`
- `NationalSpire.MatchRules.Time(double?)`；输入表达式：`MatchRules.Time(seconds)`；返回值紧邻使用处：`InterpolationSyntax: {MatchRules.Time(seconds)}`
- `NationalSpire.RivalSimulation.At(NationalSpire.LiveMatchState, double)`；输入表达式：`RivalSimulation.At(companion.Live, seconds)`；返回值紧邻使用处：`ArgumentSyntax: RivalSimulation.At(companion.Live, seconds)`
- `NationalSpire.RivalSimulation.Create(NationalSpire.CareerMatch, NationalSpire.CareerPerson, System.Collections.Generic.IReadOnlyList<NationalSpire.RouteNode>, int)`；输入表达式：`RivalSimulation.Create(companion, npc, PlanningMap(), GameCharacterNames.StartingHp(npc.Character))`；返回值紧邻使用处：`AssignmentExpressionSyntax: companion.Live = RivalSimulation.Create(companion, npc, PlanningMap(), GameCharacterNames.StartingHp(npc.Character))`
- `NationalSpire.RivalSimulation.RoomName(string)`；输入表达式：`RivalSimulation.RoomName(n.Progress.Step.Kind)`；返回值紧邻使用处：`ConditionalExpressionSyntax: n.Progress.Finished ? "已通关" : RivalSimulation.RoomName(n.Progress.Step.Kind)`
- `NationalSpire.RivalSimulation.TryAdjustPace(NationalSpire.LiveMatchState, double, int, int)`；输入表达式：`RivalSimulation.TryAdjustPace(companion.Live, seconds, _run.CurrentActIndex, _run.TotalFloor)`；返回值紧邻使用处：`AssignmentExpressionSyntax: changed |= RivalSimulation.TryAdjustPace(companion.Live, seconds, _run.CurrentActIndex, _run.TotalFloor)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_dateAvatars.TryGetValue(cue.Person, out var appearance)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_dateAvatars.TryGetValue(cue.Person, out var appearance)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`game.Companions.FirstOrDefault(c => c.OpponentId == person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = game.Companions.FirstOrDefault(c => c.OpponentId == person)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`npcs.Select(n => $"{CareerEngine.DisplayName(_data, n.Person)}：第{n.Progress.Step.Act + 1}幕、第{n.Progress.Step.Floor}层，生命{n.Progress.Hp}/{n.MaxHp}，{(n.Progress.Dead ? "已倒下" : n.Progress.Finished ? "已通关" : RivalSimulation.RoomName(n.Progress.Step.Kind))}。")`；返回值紧邻使用处：`ArgumentSyntax: npcs.Select(n => $"{CareerEngine.DisplayName(_data, n.Person)}：第{n.Progress.Step.Act + 1}幕、第{n.Progress.Step.Floor}层，生命{n.Progress.Hp}/{n.MaxHp}，{(n.Progress.Dead ? "已倒下" : n.Progress.Finished ? "已通关" : RivalSimulation.RoomName(n.Progress.Step.Kind))}。")`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`npcs.Select(n => CareerEngine.DisplayName(_data, n.Person) + (n.Progress.Dead ? "已倒下" : $" {n.Progress.Step.Floor}层"))`；返回值紧邻使用处：`ArgumentSyntax: npcs.Select(n => CareerEngine.DisplayName(_data, n.Person) + (n.Progress.Dead ? "已倒下" : $" {n.Progress.Step.Floor}层"))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`game.People.Where(p => p != _rival.Id)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string person in game.People.Where(p => p != _rival.Id)) { var npc = CareerEngine.Person(_data, person); if (npc == null) continue; var companion = game.Companions.FirstOrDefault(c => c.OpponentId == person); if (companion == null) { companion = new() { Id = _match.Id + "/" + person, Kind = "private-friendly", Day = _match.Day, Seed = _match.Seed, SeedRandomized = true, RequiredAscension = _match.RequiredAscension, ChosenAscension = _match.ChosenAscension, OpponentId = person }; MatchRules.PrepareOpponent(_data, companion); game.Companions.Add(companion); changed = true; } if (companion.Live == null) { companion.Live = RivalSimulation.Create(companion, npc, PlanningMap(), GameCharacterNames.StartingHp(npc.Character)); changed = true; } changed |= RivalSimulation.TryAdjustPace(companion.Live, seconds, _run.CurrentActIndex, _run.TotalFloor); if (companion.Live.Steps.Count > 0) npcs.Add(new(person, RivalSimulation.At(companion.Live, seconds), companion.Live.MaxHp)); }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`game.Companions.Add(companion)`；返回值紧邻使用处：`ExpressionStatementSyntax: game.Companions.Add(companion);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`npcs.Add(new(person, RivalSimulation.At(companion.Live, seconds), companion.Live.MaxHp))`；返回值紧邻使用处：`ExpressionStatementSyntax: npcs.Add(new(person, RivalSimulation.At(companion.Live, seconds), companion.Live.MaxHp));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<DateGameNpc> { new(_rival.Id, primary, live.MaxHp) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<DateGameNpc> { new(_rival.Id, primary, live.MaxHp) }`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1, player.Floor)`；返回值紧邻使用处：`BinaryExpressionSyntax: seconds / Math.Max(1, player.Floor)`
- `System.Random.Next()`；输入表达式：`Random.Shared.Next()`；返回值紧邻使用处：`ArgumentSyntax: Random.Shared.Next()`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join(" · ", npcs.Select(n => CareerEngine.DisplayName(_data, n.Person) + (n.Progress.Dead ? "已倒下" : $" {n.Progress.Step.Floor}层")))`；返回值紧邻使用处：`ArgumentSyntax: string.Join(" · ", npcs.Select(n => CareerEngine.DisplayName(_data, n.Person) + (n.Progress.Dead ? "已倒下" : $" {n.Progress.Step.Floor}层")))`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", npcs.Select(n => $"{CareerEngine.DisplayName(_data, n.Person)}：第{n.Progress.Step.Act + 1}幕、第{n.Progress.Step.Floor}层，生命{n.Progress.Hp}/{n.MaxHp}，{(n.Progress.Dead ? "已倒下" : n.Progress.Finished ? "已通关" : RivalSimulation.RoomName(n.Progress.Step.Kind))}。"))`；返回值紧邻使用处：`BinaryExpressionSyntax: $"玩家：第{player.Act + 1}幕、第{player.Floor}层，生命{player.Hp}/{player.MaxHp}，用时{MatchRules.Time(seconds)}，平均每层{seconds / Math.Max(1, player.Floor):F1}秒。\n" + string.Join("\n", npcs.Select(n => $"{CareerEngine.DisplayName(_data, n.Person)}：第{n.Progress.Step.Act + 1}幕、第{n.Progress.Step.Floor}层，生命{n.Progress.Hp}/{n.MaxHp}，{(n.Progress.Dead ? "已倒下" : n.Progress.Finished ? "已通关" : RivalSimulation.RoomName(n.Progress.Step.Kind))}。"))`

**赋值（含属性/字段和局部值）：**

- `ChosenAscension` = `_match.ChosenAscension`
- `Day` = `_match.Day`
- `Id` = `_match.Id + "/" + person`
- `Kind` = `"private-friendly"`
- `OpponentId` = `person`
- `RequiredAscension` = `_match.RequiredAscension`
- `Seconds` = `requestSeconds`
- `SeedRandomized` = `true`
- `Seed` = `_match.Seed`
- `_dateAvatars[cue.Person]` = `appearance = (CareerAvatars.ForPerson(_data, cue.Person), AvatarHonors.ForPerson(_data, cue.Person))`
- `_datePauseAccepted` = `false`
- `appearance` = `(CareerAvatars.ForPerson(_data, cue.Person), AvatarHonors.ForPerson(_data, cue.Person))`
- `changed` = `true`
- `changed` |= `DateGameTriggers.Observe(game, player, npcs)`
- `changed` |= `DateGames.TickChatRequest(_data, game, requestSeconds, _datePauseAccepted)`
- `changed` |= `RivalSimulation.TryAdjustPace(companion.Live, seconds, _run.CurrentActIndex, _run.TotalFloor)`
- `companion.Live` = `RivalSimulation.Create(companion, npc, PlanningMap(), GameCharacterNames.StartingHp(npc.Character))`
- `companion` = `new() { Id = _match.Id + "/" + person, Kind = "private-friendly", Day = _match.Day, Seed = _match.Seed, SeedRandomized = true, RequiredAscension = _match.RequiredAscension, ChosenAscension = _match.ChosenAscension, OpponentId = person }`
- `game.Snapshot` = `$"玩家：第{player.Act + 1}幕、第{player.Floor}层，生命{player.Hp}/{player.MaxHp}，用时{MatchRules.Time(seconds)}，平均每层{seconds / Math.Max(1, player.Floor):F1}秒。\n" + string.Join("\n", npcs.Select(n => $"{CareerEngine.DisplayName(_data, n.Person)}：第{n.Progress.Step.Act + 1}幕、第{n.Progress.Step.Floor}层，生命{n.Progress.Hp}/{n.MaxHp}，{(n.Progress.Dead ? "已倒下" : n.Progress.Finished ? "已通关" : RivalSimulation.RoomName(n.Progress.Step.Kind))}。"))`
- `live.Commentary.LastSpoke` = `seconds`

<a id="symbol-e4061f52dd90"></a>

## `NationalSpire.LiveRunBridge.UpdateDateGameAction(NationalSpire.DateGameState, double) — private void UpdateDateGameAction(DateGameState game, double seconds)`

来源：源码第 69 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.UpdateDateGame(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, double, ref bool)`](LiveDateGame.cs.md#symbol-cb87a418530f)

**调用：** [`NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`](AvatarHonors.cs.md#symbol-5207a1627331)；[`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-cd3d95caefab)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.LiveRaceHud.AddAction(string, System.Action)`](LiveRaceHud.cs.md#symbol-e4440860b387)；[`NationalSpire.LiveRaceHud.ClearChatRequest()`](LiveRaceHud.cs.md#symbol-c0be666418f2)；[`NationalSpire.LiveRaceHud.HoldChatRequest(bool)`](LiveRaceHud.cs.md#symbol-654af1fb17c1)；[`NationalSpire.LiveRaceHud.ShowChatRequest(string, string, string, NationalSpire.AvatarArt, NationalSpire.AvatarIdentity, double, bool, Godot.Button, System.Action)`](LiveRaceHud.cs.md#symbol-e42d7e040efa)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.DateGameState.Host`；`NationalSpire.DateGameState.OfferId`；`NationalSpire.DateGameState.PendingChat`；`NationalSpire.DateGameState.PendingLine`；`NationalSpire.DateGameState.PendingSpeaker`；`NationalSpire.DateGameState.PendingUntil`；`NationalSpire.LiveRaceHud.AddAction(string, System.Action)`；`NationalSpire.LiveRaceHud.ClearChatRequest()`；`NationalSpire.LiveRaceHud.HoldChatRequest(bool)`；`NationalSpire.LiveRaceHud.ShowChatRequest(string, string, string, NationalSpire.AvatarArt, NationalSpire.AvatarIdentity, double, bool, Godot.Button, System.Action)`；`NationalSpire.LiveRequestButton.Remaining`；`NationalSpire.LiveRunBridge._data`；`NationalSpire.LiveRunBridge._dateAvatars`；`NationalSpire.LiveRunBridge._dateChatAction`；`NationalSpire.LiveRunBridge._datePauseAccepted`；`NationalSpire.LiveRunBridge._dateRespondAction`；`NationalSpire.LiveRunBridge._dateRespondRequested`；`NationalSpire.LiveRunBridge._hud`；`NationalSpire.PrivateConversation.DateSceneStates`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AvatarHonors.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`AvatarHonors.ForPerson(_data, game.PendingSpeaker)`；返回值紧邻使用处：`ArgumentSyntax: AvatarHonors.ForPerson(_data, game.PendingSpeaker)`
- `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.ForPerson(_data, game.PendingSpeaker)`；返回值紧邻使用处：`ArgumentSyntax: CareerAvatars.ForPerson(_data, game.PendingSpeaker)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(_data, game.PendingSpeaker)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.DisplayName(_data, game.PendingSpeaker)`
- `NationalSpire.LiveRaceHud.AddAction(string, System.Action)`；输入表达式：`_hud.AddAction("继续约会", () => { _dateRespondRequested = false; _datePauseAccepted = true; _hud.HoldChatRequest(true); })`；返回值紧邻使用处：`AssignmentExpressionSyntax: _dateChatAction = _hud.AddAction("继续约会", () => { _dateRespondRequested = false; _datePauseAccepted = true; _hud.HoldChatRequest(true); })`
- `NationalSpire.LiveRaceHud.ClearChatRequest()`；输入表达式：`_hud.ClearChatRequest()`；返回值紧邻使用处：`ExpressionStatementSyntax: _hud.ClearChatRequest();`
- `NationalSpire.LiveRaceHud.HoldChatRequest(bool)`；输入表达式：`_hud.HoldChatRequest(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: _hud.HoldChatRequest(true);`
- `NationalSpire.LiveRaceHud.ShowChatRequest(string, string, string, NationalSpire.AvatarArt, NationalSpire.AvatarIdentity, double, bool, Godot.Button, System.Action)`；输入表达式：`_hud.ShowChatRequest(game.PendingChat, CareerEngine.DisplayName(_data, game.PendingSpeaker), game.PendingLine, appearance.Art, appearance.Identity, remaining, _datePauseAccepted || RunManager.Instance.IsPaused, _dateChatAction, () => { _dateRespondRequested = true; _datePauseAccepted = true; })`；返回值紧邻使用处：`CastExpressionSyntax: (LiveRequestButton)_hud.ShowChatRequest(game.PendingChat, CareerEngine.DisplayName(_data, game.PendingSpeaker), game.PendingLine, appearance.Art, appearance.Identity, remaining, _datePauseAccepted || RunManager.Instance.IsPaused, _dateChatAction, () => { _dateRespondRequested = true; _datePauseAccepted = true; })`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(_data, game.Host)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(_data, game.Host)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_dateAvatars.TryGetValue(game.PendingSpeaker, out var appearance)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_dateAvatars.TryGetValue(game.PendingSpeaker, out var appearance)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`conversation.DateSceneStates.GetValueOrDefault(game.OfferId)`；返回值紧邻使用处：`BinaryExpressionSyntax: conversation.DateSceneStates.GetValueOrDefault(game.OfferId) != "ended"`

**赋值（含属性/字段和局部值）：**

- `_dateAvatars[game.PendingSpeaker]` = `appearance = (CareerAvatars.ForPerson(_data, game.PendingSpeaker), AvatarHonors.ForPerson(_data, game.PendingSpeaker))`
- `_dateChatAction.Disabled` = `_datePauseAccepted`
- `_dateChatAction.Name` = `"DateGameContinue"`
- `_dateChatAction.TooltipText` = `_datePauseAccepted ? "当前动作结束后进入约会" : ""`
- `_dateChatAction.Visible` = `available`
- `_dateChatAction` = `_hud.AddAction("继续约会", () => { _dateRespondRequested = false; _datePauseAccepted = true; _hud.HoldChatRequest(true); })`
- `_datePauseAccepted` = `true`
- `_dateRespondAction` = `(LiveRequestButton)_hud.ShowChatRequest(game.PendingChat, CareerEngine.DisplayName(_data, game.PendingSpeaker), game.PendingLine, appearance.Art, appearance.Identity, remaining, _datePauseAccepted || RunManager.Instance.IsPaused, _dateChatAction, () => { _dateRespondRequested = true; _datePauseAccepted = true; })`
- `_dateRespondAction` = `null`
- `_dateRespondRequested` = `false`
- `_dateRespondRequested` = `true`
- `appearance` = `(CareerAvatars.ForPerson(_data, game.PendingSpeaker), AvatarHonors.ForPerson(_data, game.PendingSpeaker))`

<a id="symbol-ae2a19aa7c3a"></a>

## `NationalSpire.LiveRunBridge.CanOpenDateChat() — private bool CanOpenDateChat()`

来源：源码第 92 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.OpenDateGameChat(double)`](LiveDateGame.cs.md#symbol-6383bcf560b6)；[`NationalSpire.LiveRunBridge.UpdateDateGame(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, double, ref bool)`](LiveDateGame.cs.md#symbol-cb87a418530f)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Current`；`NationalSpire.LiveRunBridge._datePause`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6383bcf560b6"></a>

## `NationalSpire.LiveRunBridge.OpenDateGameChat(double) — private void OpenDateGameChat(double seconds)`

来源：源码第 99 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.UpdateDateGame(NationalSpire.LiveMatchState, NationalSpire.RivalProgress, double, ref bool)`](LiveDateGame.cs.md#symbol-cb87a418530f)

**调用：** `Godot.Node.GetParent()`；[`NationalSpire.CareerScreen.OpenRunDate(MegaCrit.Sts2.Core.Nodes.NRun, NationalSpire.CareerMatch, System.Action, bool)`](DateGameScreen.cs.md#symbol-c74330b4dd26)；[`NationalSpire.DateGamePause.Acquire()`](LiveDateGame.cs.md#symbol-c615b37330ed)；[`NationalSpire.DateGamePause.DateGamePause(ulong)`](LiveDateGame.cs.md#symbol-79dcda9d9263)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.LiveRaceHud.HoldChatRequest(bool)`](LiveRaceHud.cs.md#symbol-654af1fb17c1)；[`NationalSpire.LiveRaceHud.Say(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?)`](LiveRaceHud.cs.md#symbol-1fd8ee1cca63)；[`NationalSpire.LiveRunBridge.CanOpenDateChat()`](LiveDateGame.cs.md#symbol-ae2a19aa7c3a)；[`NationalSpire.LiveRunBridge.ResumeDateRun()`](LiveDateGame.cs.md#symbol-9d0f51bc5495)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMatch.DateGame`；`NationalSpire.CareerScreen.OpenRunDate(MegaCrit.Sts2.Core.Nodes.NRun, NationalSpire.CareerMatch, System.Action, bool)`；`NationalSpire.DateGamePause.Acquire()`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.LiveRaceHud.HoldChatRequest(bool)`；`NationalSpire.LiveRaceHud.Say(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?)`；`NationalSpire.LiveRunBridge.CanOpenDateChat()`；`NationalSpire.LiveRunBridge.ResumeDateRun()`；`NationalSpire.LiveRunBridge._dateOpenRetry`；`NationalSpire.LiveRunBridge._datePause`；`NationalSpire.LiveRunBridge._dateRespondRequested`；`NationalSpire.LiveRunBridge._hud`；`NationalSpire.LiveRunBridge._match`；`NationalSpire.LiveRunBridge._player`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.GetParent()`；输入表达式：`GetParent()`；返回值紧邻使用处：`CastExpressionSyntax: (NRun)GetParent()`
- `NationalSpire.CareerScreen.OpenRunDate(MegaCrit.Sts2.Core.Nodes.NRun, NationalSpire.CareerMatch, System.Action, bool)`；输入表达式：`CareerScreen.OpenRunDate((NRun)GetParent(), _match, ResumeDateRun, _dateRespondRequested)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CareerScreen.OpenRunDate((NRun)GetParent(), _match, ResumeDateRun, _dateRespondRequested)`
- `NationalSpire.DateGamePause.Acquire()`；输入表达式：`_datePause.Acquire()`；返回值紧邻使用处：`ExpressionStatementSyntax: _datePause.Acquire();`
- `NationalSpire.DateGamePause.DateGamePause(ulong)`；输入表达式：`new DateGamePause(_player.NetId)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _datePause = new DateGamePause(_player.NetId)`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("date.game.open", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("date.game.open", e);`
- `NationalSpire.LiveRaceHud.HoldChatRequest(bool)`；输入表达式：`_hud.HoldChatRequest(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: _hud.HoldChatRequest(true);`
- `NationalSpire.LiveRaceHud.Say(string, string, string, NationalSpire.AvatarArt?, NationalSpire.AvatarIdentity?)`；输入表达式：`_hud.Say("约会", "暂时无法打开约会，可点击聊天再次尝试。", "date/error")`；返回值紧邻使用处：`ExpressionStatementSyntax: _hud.Say("约会", "暂时无法打开约会，可点击聊天再次尝试。", "date/error");`
- `NationalSpire.LiveRunBridge.CanOpenDateChat()`；输入表达式：`CanOpenDateChat()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CanOpenDateChat()`
- `NationalSpire.LiveRunBridge.ResumeDateRun()`；输入表达式：`ResumeDateRun()`；返回值紧邻使用处：`ExpressionStatementSyntax: ResumeDateRun();`

**赋值（含属性/字段和局部值）：**

- `_dateOpenRetry` = `seconds + 15`
- `_datePause` = `new DateGamePause(_player.NetId)`

<a id="symbol-9d0f51bc5495"></a>

## `NationalSpire.LiveRunBridge.ResumeDateRun() — private void ResumeDateRun()`

来源：源码第 112 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.OpenDateGameChat(double)`](LiveDateGame.cs.md#symbol-6383bcf560b6)；[`NationalSpire.LiveRunBridge._ExitTree()`](LiveRunBridge.cs.md#symbol-1d45315292ab)

**调用：** `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；[`NationalSpire.DateGamePause.Dispose()`](LiveDateGame.cs.md#symbol-1b8e2cb9178c)；[`NationalSpire.LiveRaceHud.HoldChatRequest(bool)`](LiveRaceHud.cs.md#symbol-654af1fb17c1)

**字段、属性、事件及方法组引用：** `NationalSpire.DateGamePause.Dispose()`；`NationalSpire.LiveRaceHud.HoldChatRequest(bool)`；`NationalSpire.LiveRunBridge._datePause`；`NationalSpire.LiveRunBridge._hud`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`IsInstanceValid(_hud)`；返回值紧邻使用处：`IfStatementSyntax: if (IsInstanceValid(_hud)) _hud.HoldChatRequest(false);`
- `NationalSpire.DateGamePause.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: pause?.Dispose()`
- `NationalSpire.LiveRaceHud.HoldChatRequest(bool)`；输入表达式：`_hud.HoldChatRequest(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: _hud.HoldChatRequest(false);`

**赋值（含属性/字段和局部值）：**

- `_datePause` = `null`

<a id="symbol-79dcda9d9263"></a>

## `NationalSpire.DateGamePause.DateGamePause(ulong) — public DateGamePause(ulong player)`

来源：源码第 120 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.OpenDateGameChat(double)`](LiveDateGame.cs.md#symbol-6383bcf560b6)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.DateGamePause._player`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `_player` = `player`

<a id="symbol-c615b37330ed"></a>

## `NationalSpire.DateGamePause.Acquire() — public void Acquire()`

来源：源码第 121 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.OpenDateGameChat(double)`](LiveDateGame.cs.md#symbol-6383bcf560b6)

**调用：** `MegaCrit.Sts2.Core.Combat.CombatManager.Pause()`；`MegaCrit.Sts2.Core.GameActions.ActionExecutor.Pause()`；`MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet.ActionQueueIsPaused(ulong)`；`MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet.PauseAllPlayerQueues()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateGamePause._acquired`；`NationalSpire.DateGamePause._player`；`NationalSpire.DateGamePause._queuesWerePaused`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Combat.CombatManager.Pause()`；输入表达式：`CombatManager.Instance.Pause()`；返回值紧邻使用处：`ExpressionStatementSyntax: CombatManager.Instance.Pause();`
- `MegaCrit.Sts2.Core.GameActions.ActionExecutor.Pause()`；输入表达式：`RunManager.Instance.ActionExecutor.Pause()`；返回值紧邻使用处：`ExpressionStatementSyntax: RunManager.Instance.ActionExecutor.Pause();`
- `MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet.ActionQueueIsPaused(ulong)`；输入表达式：`RunManager.Instance.ActionQueueSet.ActionQueueIsPaused(_player)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _queuesWerePaused = RunManager.Instance.ActionQueueSet.ActionQueueIsPaused(_player)`
- `MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet.PauseAllPlayerQueues()`；输入表达式：`RunManager.Instance.ActionQueueSet.PauseAllPlayerQueues()`；返回值紧邻使用处：`ExpressionStatementSyntax: RunManager.Instance.ActionQueueSet.PauseAllPlayerQueues();`

**赋值（含属性/字段和局部值）：**

- `RunManager.Instance.IsPaused` = `true`
- `_acquired` = `true`
- `_queuesWerePaused` = `RunManager.Instance.ActionQueueSet.ActionQueueIsPaused(_player)`

<a id="symbol-1b8e2cb9178c"></a>

## `NationalSpire.DateGamePause.Dispose() — public void Dispose()`

来源：源码第 131 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LiveRunBridge.ResumeDateRun()`](LiveDateGame.cs.md#symbol-9d0f51bc5495)

**调用：** `MegaCrit.Sts2.Core.Combat.CombatManager.Unpause()`；`MegaCrit.Sts2.Core.GameActions.ActionExecutor.Unpause()`；`MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet.UnpauseAllPlayerQueues()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateGamePause._acquired`；`NationalSpire.DateGamePause._queuesWerePaused`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Combat.CombatManager.Unpause()`；输入表达式：`CombatManager.Instance.Unpause()`；返回值紧邻使用处：`ExpressionStatementSyntax: CombatManager.Instance.Unpause();`
- `MegaCrit.Sts2.Core.GameActions.ActionExecutor.Unpause()`；输入表达式：`RunManager.Instance.ActionExecutor.Unpause()`；返回值紧邻使用处：`ExpressionStatementSyntax: RunManager.Instance.ActionExecutor.Unpause();`
- `MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet.UnpauseAllPlayerQueues()`；输入表达式：`RunManager.Instance.ActionQueueSet.UnpauseAllPlayerQueues()`；返回值紧邻使用处：`ExpressionStatementSyntax: RunManager.Instance.ActionQueueSet.UnpauseAllPlayerQueues();`

**赋值（含属性/字段和局部值）：**

- `RunManager.Instance.IsPaused` = `false`
- `_acquired` = `false`
