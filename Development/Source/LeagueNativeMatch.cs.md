# LeagueNativeMatch.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`991C6DB8AD477F901DEF359E636BBF43F18324C1A43A7A644B994E54CA666905`。来源：[源码](../../LeagueNativeMatch.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LeagueNativeMatch`、`NationalSpire.LeagueNativeMatch.DoomIntent`、`NationalSpire.LeagueNativeMatch.RecordedIntent`、`NationalSpire.LeagueEncounter`、`NationalSpire.LeagueOpponent`、`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
internal static LeagueDuel? Current;
private static CombatRoom? _room;
private static bool _installed,_opener,_returning;
private static ICareerSession? _session;
private static RunState? _run;
private static Button? _exit;
private static ConfirmationDialog? _exitDialog;
```

<a id="symbol-5db2520de882"></a>

## `NationalSpire.LeagueNativeMatch.Start(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], int, NationalSpire.ICareerSession?, string, int, System.Collections.Generic.IReadOnlyDictionary<string, int>?, System.Collections.Generic.Dictionary<string, int>?, int, string?) — public static async Task Start(CharacterModel first,CardModel[] cards,CharacterModel other,CardModel[] rival,int seed,ICareerSession? session,string opponentName,int tier,IReadOnlyDictionary<string,int>? upgrades=null,Dictionary<string,int>? rivalUpgrades=null,int playerTier=0,string? style=null)`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Begin()`](LeagueArenaScreen.cs.md#symbol-6efcffde32aa)

**调用：** [`NationalSpire.CareerScreen.UseOpening(string?)`](LeagueArenaScreen.cs.md#symbol-714fe2bbacbd)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.GameBridge.CreateActSelectionRng(string)`](GameBridge.cs.md#symbol-e22050f58fa0)；[`NationalSpire.LeagueArchetypes.Resolve(string, string)`](LeagueArchetypes.cs.md#symbol-8cffe8f79fa2)；[`NationalSpire.LeagueBattleApi.Create(MegaCrit.Sts2.Core.Entities.Players.Player[], System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel>, string)`](LeagueBattleApi.cs.md#symbol-3ef9bfd7ad99)；[`NationalSpire.LeagueDuel.LeagueDuel(MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Models.CardModel[], int, string, int, System.Collections.Generic.Dictionary<string, int>?, System.Collections.Generic.List<NationalSpire.LeagueDuel.Hit>?)`](LeagueDuel.cs.md#symbol-83cd52462f7a)；[`NationalSpire.LeagueLadder.RivalOpens(int)`](LeagueLadder.cs.md#symbol-3b4c257e5975)；[`NationalSpire.LeagueNativeMatch.EnterMatchScene(MegaCrit.Sts2.Core.Nodes.NGame, MegaCrit.Sts2.Core.Runs.RunState)`](LeagueNativeMatch.cs.md#symbol-4d22b3101f75)；[`NationalSpire.LeagueNativeMatch.EquipDeck(MegaCrit.Sts2.Core.Runs.RunState, MegaCrit.Sts2.Core.Entities.Players.Player, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, System.Collections.Generic.IReadOnlyDictionary<string, int>?, int)`](LeagueTeamMatch.cs.md#symbol-40715405ce22)；[`NationalSpire.LeagueNativeMatch.Install()`](LeagueNativeMatch.cs.md#symbol-8277ecd62500)；[`NationalSpire.LeagueNativeMatch.InstallExit(MegaCrit.Sts2.Core.Nodes.NRun)`](LeagueNativeMatch.cs.md#symbol-c7bf6cbb732d)；[`NationalSpire.LeagueNativeMatch.Release()`](LeagueNativeMatch.cs.md#symbol-242512cbc319)；[`NationalSpire.LeagueNativeMatch.Return(string?, bool?)`](LeagueNativeMatch.cs.md#symbol-1b324a0cbccb)；`int.ToString()`；`MegaCrit.Sts2.Core.Assets.PreloadManager.LoadActAssets(MegaCrit.Sts2.Core.Models.ActModel)`；`MegaCrit.Sts2.Core.Assets.PreloadManager.LoadRunAssets(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CharacterModel>)`；`MegaCrit.Sts2.Core.Entities.Players.Player.CreateForNewRun(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Unlocks.UnlockState, ulong)`；`MegaCrit.Sts2.Core.Entities.Players.Player.InitializeSeed(string)`；`MegaCrit.Sts2.Core.Models.ActModel.GetRandomList(MegaCrit.Sts2.Core.Random.Rng, MegaCrit.Sts2.Core.Unlocks.UnlockState, bool)`；`MegaCrit.Sts2.Core.Models.ActModel.ToMutable()`；`MegaCrit.Sts2.Core.Models.EncounterModel.ToMutable()`；`MegaCrit.Sts2.Core.Models.ModelDb.Encounter<T>()`；`MegaCrit.Sts2.Core.Nodes.NTransition.FadeIn(float, string, System.Threading.CancellationToken?)`；`MegaCrit.Sts2.Core.Nodes.NTransition.FadeOut(float, string, System.Threading.CancellationToken?)`；`MegaCrit.Sts2.Core.Runs.RunManager.EnterRoomDebug(MegaCrit.Sts2.Core.Rooms.RoomType, MegaCrit.Sts2.Core.Map.MapPointType, MegaCrit.Sts2.Core.Models.AbstractModel?, bool)`；`MegaCrit.Sts2.Core.Runs.RunManager.Launch()`；`MegaCrit.Sts2.Core.Runs.RunManager.SetActInternal(int)`；`MegaCrit.Sts2.Core.Runs.RunManager.SetUpNewSingleplayer(MegaCrit.Sts2.Core.Runs.RunState, bool, System.DateTimeOffset?)`；`MegaCrit.Sts2.Core.Saves.SaveManager.GenerateUnlockStateFromProgress()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Exception.GetBaseException()`；`System.IDisposable.Dispose()`；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.UseOpening(string?)`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.GameBridge.CreateActSelectionRng(string)`；`NationalSpire.LeagueArchetypes.Plan.Anchors`；`NationalSpire.LeagueArchetypes.Resolve(string, string)`；`NationalSpire.LeagueBattleApi.Create(MegaCrit.Sts2.Core.Entities.Players.Player[], System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel>, string)`；`NationalSpire.LeagueDuel.SetupCards`；`NationalSpire.LeagueLadder.RivalOpens(int)`；`NationalSpire.LeagueNativeMatch._opener`；`NationalSpire.LeagueNativeMatch._returning`；`NationalSpire.LeagueNativeMatch._room`；`NationalSpire.LeagueNativeMatch._run`；`NationalSpire.LeagueNativeMatch._session`；`NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.Ended(MegaCrit.Sts2.Core.Rooms.CombatRoom)`；`NationalSpire.LeagueNativeMatch.EnterMatchScene(MegaCrit.Sts2.Core.Nodes.NGame, MegaCrit.Sts2.Core.Runs.RunState)`；`NationalSpire.LeagueNativeMatch.EquipDeck(MegaCrit.Sts2.Core.Runs.RunState, MegaCrit.Sts2.Core.Entities.Players.Player, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, System.Collections.Generic.IReadOnlyDictionary<string, int>?, int)`；`NationalSpire.LeagueNativeMatch.Install()`；`NationalSpire.LeagueNativeMatch.InstallExit(MegaCrit.Sts2.Core.Nodes.NRun)`；`NationalSpire.LeagueNativeMatch.PlayerTurn(MegaCrit.Sts2.Core.Combat.CombatState)`；`NationalSpire.LeagueNativeMatch.Release()`；`NationalSpire.LeagueNativeMatch.Return(string?, bool?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.ToString()`；输入表达式：`seed.ToString()`；返回值紧邻使用处：`ArgumentSyntax: seed.ToString()`
- `MegaCrit.Sts2.Core.Assets.PreloadManager.LoadActAssets(MegaCrit.Sts2.Core.Models.ActModel)`；输入表达式：`PreloadManager.LoadActAssets(acts[0])`；返回值紧邻使用处：`AwaitExpressionSyntax: await PreloadManager.LoadActAssets(acts[0])`
- `MegaCrit.Sts2.Core.Assets.PreloadManager.LoadRunAssets(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CharacterModel>)`；输入表达式：`PreloadManager.LoadRunAssets([first,other])`；返回值紧邻使用处：`AwaitExpressionSyntax: await PreloadManager.LoadRunAssets([first,other])`
- `MegaCrit.Sts2.Core.Entities.Players.Player.CreateForNewRun(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Unlocks.UnlockState, ulong)`；输入表达式：`Player.CreateForNewRun(first,unlock,1)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Player.CreateForNewRun(first,unlock,1)`
- `MegaCrit.Sts2.Core.Entities.Players.Player.CreateForNewRun(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Unlocks.UnlockState, ulong)`；输入表达式：`Player.CreateForNewRun(other,unlock,2)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Player.CreateForNewRun(other,unlock,2)`
- `MegaCrit.Sts2.Core.Entities.Players.Player.InitializeSeed(string)`；输入表达式：`bot.InitializeSeed(seed.ToString())`；返回值紧邻使用处：`ExpressionStatementSyntax: bot.InitializeSeed(seed.ToString());`
- `MegaCrit.Sts2.Core.Models.ActModel.GetRandomList(MegaCrit.Sts2.Core.Random.Rng, MegaCrit.Sts2.Core.Unlocks.UnlockState, bool)`；输入表达式：`ActModel.GetRandomList(GameBridge.CreateActSelectionRng(seed.ToString()),unlock,false)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ActModel.GetRandomList(GameBridge.CreateActSelectionRng(seed.ToString()),unlock,false).Select`
- `MegaCrit.Sts2.Core.Models.ActModel.ToMutable()`；输入表达式：`a.ToMutable()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: a=>a.ToMutable()`
- `MegaCrit.Sts2.Core.Models.EncounterModel.ToMutable()`；输入表达式：`ModelDb.Encounter<LeagueEncounter>().ToMutable()`；返回值紧邻使用处：`ArgumentSyntax: model:ModelDb.Encounter<LeagueEncounter>().ToMutable()`
- `MegaCrit.Sts2.Core.Models.ModelDb.Encounter<T>()`；输入表达式：`ModelDb.Encounter<LeagueEncounter>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ModelDb.Encounter<LeagueEncounter>().ToMutable`
- `MegaCrit.Sts2.Core.Nodes.NTransition.FadeIn(float, string, System.Threading.CancellationToken?)`；输入表达式：`game.Transition.FadeIn(.24f)`；返回值紧邻使用处：`AwaitExpressionSyntax: await game.Transition.FadeIn(.24f)`
- `MegaCrit.Sts2.Core.Nodes.NTransition.FadeOut(float, string, System.Threading.CancellationToken?)`；输入表达式：`game.Transition.FadeOut(.24f)`；返回值紧邻使用处：`AwaitExpressionSyntax: await game.Transition.FadeOut(.24f)`
- `MegaCrit.Sts2.Core.Runs.RunManager.EnterRoomDebug(MegaCrit.Sts2.Core.Rooms.RoomType, MegaCrit.Sts2.Core.Map.MapPointType, MegaCrit.Sts2.Core.Models.AbstractModel?, bool)`；输入表达式：`RunManager.Instance.EnterRoomDebug(RoomType.Monster,model:ModelDb.Encounter<LeagueEncounter>().ToMutable(),showTransition:false)`；返回值紧邻使用处：`AwaitExpressionSyntax: await RunManager.Instance.EnterRoomDebug(RoomType.Monster,model:ModelDb.Encounter<LeagueEncounter>().ToMutable(),showTransition:false)`
- `MegaCrit.Sts2.Core.Runs.RunManager.Launch()`；输入表达式：`RunManager.Instance.Launch()`；返回值紧邻使用处：`ExpressionStatementSyntax: RunManager.Instance.Launch();`
- `MegaCrit.Sts2.Core.Runs.RunManager.SetActInternal(int)`；输入表达式：`RunManager.Instance.SetActInternal(0)`；返回值紧邻使用处：`AwaitExpressionSyntax: await RunManager.Instance.SetActInternal(0)`
- `MegaCrit.Sts2.Core.Runs.RunManager.SetUpNewSingleplayer(MegaCrit.Sts2.Core.Runs.RunState, bool, System.DateTimeOffset?)`；输入表达式：`RunManager.Instance.SetUpNewSingleplayer(run,false)`；返回值紧邻使用处：`ExpressionStatementSyntax: RunManager.Instance.SetUpNewSingleplayer(run,false);`
- `MegaCrit.Sts2.Core.Saves.SaveManager.GenerateUnlockStateFromProgress()`；输入表达式：`SaveManager.Instance.GenerateUnlockStateFromProgress()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =SaveManager.Instance.GenerateUnlockStateFromProgress()`
- `NationalSpire.CareerScreen.UseOpening(string?)`；输入表达式：`CareerScreen.UseOpening()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CareerScreen.UseOpening()`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("league-match",ex)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("league-match",ex);`
- `NationalSpire.GameBridge.CreateActSelectionRng(string)`；输入表达式：`GameBridge.CreateActSelectionRng(seed.ToString())`；返回值紧邻使用处：`ArgumentSyntax: GameBridge.CreateActSelectionRng(seed.ToString())`
- `NationalSpire.LeagueArchetypes.Resolve(string, string)`；输入表达式：`LeagueArchetypes.Resolve(other.Id.Entry,style)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LeagueArchetypes.Resolve(other.Id.Entry,style).Anchors`
- `NationalSpire.LeagueBattleApi.Create(MegaCrit.Sts2.Core.Entities.Players.Player[], System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel>, string)`；输入表达式：`LeagueBattleApi.Create([hero],acts,seed.ToString())`；返回值紧邻使用处：`EqualsValueClauseSyntax: =LeagueBattleApi.Create([hero],acts,seed.ToString())`
- `NationalSpire.LeagueDuel.LeagueDuel(MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Models.CardModel[], int, string, int, System.Collections.Generic.Dictionary<string, int>?, System.Collections.Generic.List<NationalSpire.LeagueDuel.Hit>?)`；输入表达式：`new(bot,rival,seed,opponentName,tier,rivalUpgrades)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Current=new(bot,rival,seed,opponentName,tier,rivalUpgrades)`
- `NationalSpire.LeagueLadder.RivalOpens(int)`；输入表达式：`LeagueLadder.RivalOpens(seed)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _opener=LeagueLadder.RivalOpens(seed)`
- `NationalSpire.LeagueNativeMatch.EnterMatchScene(MegaCrit.Sts2.Core.Nodes.NGame, MegaCrit.Sts2.Core.Runs.RunState)`；输入表达式：`EnterMatchScene(game,run)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =EnterMatchScene(game,run)`
- `NationalSpire.LeagueNativeMatch.EquipDeck(MegaCrit.Sts2.Core.Runs.RunState, MegaCrit.Sts2.Core.Entities.Players.Player, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, System.Collections.Generic.IReadOnlyDictionary<string, int>?, int)`；输入表达式：`EquipDeck(run,hero,cards,upgrades,playerTier)`；返回值紧邻使用处：`ExpressionStatementSyntax: EquipDeck(run,hero,cards,upgrades,playerTier);`
- `NationalSpire.LeagueNativeMatch.Install()`；输入表达式：`Install()`；返回值紧邻使用处：`ExpressionStatementSyntax: Install();`
- `NationalSpire.LeagueNativeMatch.InstallExit(MegaCrit.Sts2.Core.Nodes.NRun)`；输入表达式：`InstallExit(scene)`；返回值紧邻使用处：`ExpressionStatementSyntax: InstallExit(scene);`
- `NationalSpire.LeagueNativeMatch.Release()`；输入表达式：`Release()`；返回值紧邻使用处：`ExpressionStatementSyntax: Release();`
- `NationalSpire.LeagueNativeMatch.Return(string?, bool?)`；输入表达式：`Return("对决未能开始 · "+ex.GetBaseException().Message)`；返回值紧邻使用处：`AwaitExpressionSyntax: await Return("对决未能开始 · "+ex.GetBaseException().Message)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`ActModel.GetRandomList(GameBridge.CreateActSelectionRng(seed.ToString()),unlock,false).Select(a=>a.ToMutable())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ActModel.GetRandomList(GameBridge.CreateActSelectionRng(seed.ToString()),unlock,false).Select(a=>a.ToMutable()).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`ActModel.GetRandomList(GameBridge.CreateActSelectionRng(seed.ToString()),unlock,false).Select(a=>a.ToMutable()).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ActModel.GetRandomList(GameBridge.CreateActSelectionRng(seed.ToString()),unlock,false).Select(a=>a.ToMutable()).ToList()`
- `System.Exception.GetBaseException()`；输入表达式：`ex.GetBaseException()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ex.GetBaseException().Message`
- `System.IDisposable.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _session?.Dispose()`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("请先结束当前对局。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("请先结束当前对局。");`

**赋值（含属性/字段和局部值）：**

- `_opener` = `LeagueLadder.RivalOpens(seed)`
- `_returning` = `false`
- `_room` = `room`
- `_run` = `run`
- `_session` = `null`
- `_session` = `session`
- `bot.RunState` = `run`
- `CombatManager.Instance.CombatEnded` += `Ended`
- `CombatManager.Instance.TurnStarted` += `PlayerTurn`
- `Current.SetupCards` = `style==null?[]:LeagueArchetypes.Resolve(other.Id.Entry,style).Anchors`
- `Current` = `new(bot,rival,seed,opponentName,tier,rivalUpgrades)`
- `scene.TreeExiting` += `()=>{if(_run==run&&!_returning){Release();_session?.Dispose();_session=null;}}`

<a id="symbol-4d22b3101f75"></a>

## `NationalSpire.LeagueNativeMatch.EnterMatchScene(MegaCrit.Sts2.Core.Nodes.NGame, MegaCrit.Sts2.Core.Runs.RunState) — private static NRun EnterMatchScene(NGame game,RunState run)`

来源：源码第 60 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Begin()`](LeagueTeamMatch.cs.md#symbol-7113ab57a2bd)；[`NationalSpire.LeagueNativeMatch.Start(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], int, NationalSpire.ICareerSession?, string, int, System.Collections.Generic.IReadOnlyDictionary<string, int>?, System.Collections.Generic.Dictionary<string, int>?, int, string?)`](LeagueNativeMatch.cs.md#symbol-5db2520de882)

**调用：** `MegaCrit.Sts2.Core.Nodes.Audio.NAudioManager.StopMusic()`；`MegaCrit.Sts2.Core.Nodes.NRun.Create(MegaCrit.Sts2.Core.Runs.RunState)`；`MegaCrit.Sts2.Core.Nodes.NSceneContainer.SetCurrentScene(Godot.Control)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Nodes.Audio.NAudioManager.StopMusic()`；输入表达式：`.StopMusic()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: MegaCrit.Sts2.Core.Nodes.Audio.NAudioManager.Instance?.StopMusic()`
- `MegaCrit.Sts2.Core.Nodes.NRun.Create(MegaCrit.Sts2.Core.Runs.RunState)`；输入表达式：`NRun.Create(run)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =NRun.Create(run)`
- `MegaCrit.Sts2.Core.Nodes.NSceneContainer.SetCurrentScene(Godot.Control)`；输入表达式：`game.RootSceneContainer.SetCurrentScene(scene)`；返回值紧邻使用处：`ExpressionStatementSyntax: game.RootSceneContainer.SetCurrentScene(scene);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f78a44bdbc8e"></a>

## `NationalSpire.LeagueNativeMatch.Bind(NationalSpire.LeagueOpponent) — internal static void Bind(LeagueOpponent opponent)`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueOpponent.AfterAddedToRoom()`](LeagueNativeMatch.cs.md#symbol-6aafa46bf081)

**调用：** [`NationalSpire.LeagueDuel.Attach(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`](LeagueDuel.cs.md#symbol-af76d282a609)；[`NationalSpire.LeagueNativeMatch.OrbDisplay(MegaCrit.Sts2.Core.Nodes.Combat.NCreature)`](LeagueBattleVisuals.cs.md#symbol-088a8c52e9b8)；`MegaCrit.Sts2.Core.Entities.Creatures.Creature.SetCurrentHpInternal(decimal)`；`MegaCrit.Sts2.Core.Entities.Creatures.Creature.SetMaxHpInternal(decimal)`；`MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom.GetCreatureNode(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Attach(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`NationalSpire.LeagueDuel.OpeningHp`；`NationalSpire.LeagueDuel.OpeningMax`；`NationalSpire.LeagueNativeMatch._room`；`NationalSpire.LeagueNativeMatch._run`；`NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.OrbDisplay(MegaCrit.Sts2.Core.Nodes.Combat.NCreature)`；`NationalSpire.LeagueOpponent.Fighter`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Entities.Creatures.Creature.SetCurrentHpInternal(decimal)`；输入表达式：`opponent.Creature.SetCurrentHpInternal(hp)`；返回值紧邻使用处：`ExpressionStatementSyntax: opponent.Creature.SetCurrentHpInternal(hp);`
- `MegaCrit.Sts2.Core.Entities.Creatures.Creature.SetMaxHpInternal(decimal)`；输入表达式：`opponent.Creature.SetMaxHpInternal(fighter.OpeningMax)`；返回值紧邻使用处：`ExpressionStatementSyntax: opponent.Creature.SetMaxHpInternal(fighter.OpeningMax);`
- `MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom.GetCreatureNode(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`.GetCreatureNode(opponent.Creature)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: NCombatRoom.Instance?.GetCreatureNode(opponent.Creature)`
- `NationalSpire.LeagueDuel.Attach(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`fighter.Attach(opponent.Creature)`；返回值紧邻使用处：`ExpressionStatementSyntax: fighter.Attach(opponent.Creature);`
- `NationalSpire.LeagueNativeMatch.OrbDisplay(MegaCrit.Sts2.Core.Nodes.Combat.NCreature)`；输入表达式：`OrbDisplay(view)`；返回值紧邻使用处：`ExpressionStatementSyntax: OrbDisplay(view);`

**赋值（含属性/字段和局部值）：**

- `_room` = `_run?.CurrentRoom as CombatRoom`

<a id="symbol-2e5d42d12c6a"></a>

## `NationalSpire.LeagueNativeMatch.First(NationalSpire.LeagueOpponent) — internal static async Task First(LeagueOpponent opponent)`

来源：源码第 70 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueOpponent.AfterPlayerTurnStartEarly(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Players.Player)`](LeagueNativeMatch.cs.md#symbol-611d7429d107)

**调用：** [`NationalSpire.LeagueDuel.Act()`](LeagueDuel.cs.md#symbol-0b7f3276ecd9)；[`NationalSpire.LeagueNativeMatch.OrbDisplay(MegaCrit.Sts2.Core.Nodes.Combat.NCreature)`](LeagueBattleVisuals.cs.md#symbol-088a8c52e9b8)；[`NationalSpire.LeagueNativeMatch.Refresh(NationalSpire.LeagueOpponent)`](LeagueNativeMatch.cs.md#symbol-5fb078947d8b)；`MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom.GetCreatureNode(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；`MegaCrit.Sts2.Core.Runs.PlayerMapPointHistoryEntry.PlayerMapPointHistoryEntry()`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Act()`；`NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueNativeMatch._opener`；`NationalSpire.LeagueNativeMatch._run`；`NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.Opened`；`NationalSpire.LeagueNativeMatch.OrbDisplay(MegaCrit.Sts2.Core.Nodes.Combat.NCreature)`；`NationalSpire.LeagueNativeMatch.Refresh(NationalSpire.LeagueOpponent)`；`NationalSpire.LeagueOpponent.Fighter`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom.GetCreatureNode(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`.GetCreatureNode(opponent.Creature)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: NCombatRoom.Instance?.GetCreatureNode(opponent.Creature)`
- `MegaCrit.Sts2.Core.Runs.PlayerMapPointHistoryEntry.PlayerMapPointHistoryEntry()`；输入表达式：`new(){PlayerId=rival.NetId}`；返回值紧邻使用处：`ArgumentSyntax: new(){PlayerId=rival.NetId}`
- `NationalSpire.LeagueDuel.Act()`；输入表达式：`fighter.Act()`；返回值紧邻使用处：`AwaitExpressionSyntax: await fighter.Act()`
- `NationalSpire.LeagueNativeMatch.OrbDisplay(MegaCrit.Sts2.Core.Nodes.Combat.NCreature)`；输入表达式：`OrbDisplay(view)`；返回值紧邻使用处：`ExpressionStatementSyntax: OrbDisplay(view);`
- `NationalSpire.LeagueNativeMatch.Refresh(NationalSpire.LeagueOpponent)`；输入表达式：`Refresh(opponent)`；返回值紧邻使用处：`ExpressionStatementSyntax: Refresh(opponent);`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`Opened.Add(fighter)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Opened.Add(fighter)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`floor.PlayerStats.Any(p=>p.PlayerId==rival.NetId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !floor.PlayerStats.Any(p=>p.PlayerId==rival.NetId)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`floor.PlayerStats.Add(new(){PlayerId=rival.NetId})`；返回值紧邻使用处：`ExpressionStatementSyntax: floor.PlayerStats.Add(new(){PlayerId=rival.NetId});`

**赋值（含属性/字段和局部值）：**

- `PlayerId` = `rival.NetId`

<a id="symbol-531731d36b7d"></a>

## `NationalSpire.LeagueNativeMatch.Enemy(NationalSpire.LeagueOpponent) — internal static async Task Enemy(LeagueOpponent opponent)`

来源：源码第 76 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueOpponent.GenerateMoveStateMachine()`](LeagueNativeMatch.cs.md#symbol-20670b475877)

**调用：** [`NationalSpire.LeagueDuel.Act()`](LeagueDuel.cs.md#symbol-0b7f3276ecd9)；[`NationalSpire.LeagueNativeMatch.Refresh(NationalSpire.LeagueOpponent)`](LeagueNativeMatch.cs.md#symbol-5fb078947d8b)

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Act()`；`NationalSpire.LeagueNativeMatch._opener`；`NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.Refresh(NationalSpire.LeagueOpponent)`；`NationalSpire.LeagueOpponent.Fighter`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueDuel.Act()`；输入表达式：`fighter.Act()`；返回值紧邻使用处：`AwaitExpressionSyntax: await fighter.Act()`
- `NationalSpire.LeagueNativeMatch.Refresh(NationalSpire.LeagueOpponent)`；输入表达式：`Refresh(opponent)`；返回值紧邻使用处：`ExpressionStatementSyntax: Refresh(opponent);`

**赋值（含属性/字段和局部值）：**

- `_opener` = `false`

<a id="symbol-bea557065b97"></a>

## `NationalSpire.LeagueNativeMatch.Resolve(MegaCrit.Sts2.Core.Combat.CombatSide) — internal static async Task Resolve(CombatSide side)`

来源：源码第 79 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueOpponent.BeforeSideTurnEndVeryEarly(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Combat.CombatSide, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>)`](LeagueNativeMatch.cs.md#symbol-4c7f9766c6ed)

**调用：** [`NationalSpire.LeagueBattleApi.Deliver(NationalSpire.LeagueDuel.Hit)`](LeagueBattleApi.cs.md#symbol-0e3bd31351e4)；[`NationalSpire.LeagueBattleApi.SpendGuard(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature, int, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`](LeagueBattleApi.cs.md#symbol-3002944bf337)；[`NationalSpire.LeagueNativeMatch.Refresh(NationalSpire.LeagueOpponent)`](LeagueNativeMatch.cs.md#symbol-5fb078947d8b)；`Godot.Node.GetChild(int, bool)`；`Godot.Node.GetChildCount(bool)`；`Godot.Node.GetNodeOrNull<T>(Godot.NodePath)`；`MegaCrit.Sts2.Core.Commands.PowerCmd.Apply<T>(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, bool)`；`MegaCrit.Sts2.Core.GameActions.Multiplayer.BlockingPlayerChoiceContext.BlockingPlayerChoiceContext()`；`MegaCrit.Sts2.Core.Models.Powers.DoomPower.DoomKill(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature>)`；`MegaCrit.Sts2.Core.Models.Powers.DoomPower.GetDoomedCreatures(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature>)`；`MegaCrit.Sts2.Core.Nodes.Combat.NIntent.PlayPerform()`；`MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom.GetCreatureNode(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Remove(T)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueBattleApi.Deliver(NationalSpire.LeagueDuel.Hit)`；`NationalSpire.LeagueBattleApi.SpendGuard(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature, int, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`NationalSpire.LeagueDuel.Hit.Amount`；`NationalSpire.LeagueDuel.Hit.Dealer`；`NationalSpire.LeagueDuel.Hit.Doom`；`NationalSpire.LeagueDuel.Hit.DoomSource`；`NationalSpire.LeagueDuel.Hit.Target`；`NationalSpire.LeagueDuel.Pending`；`NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueNativeMatch._passApplication`；`NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.Refresh(NationalSpire.LeagueOpponent)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.GetChild(int, bool)`；输入表达式：`icons.GetChild(0)`；返回值紧邻使用处：`IsPatternExpressionSyntax: icons.GetChild(0) is NIntent icon`
- `Godot.Node.GetChildCount(bool)`；输入表达式：`icons.GetChildCount()`；返回值紧邻使用处：`BinaryExpressionSyntax: icons.GetChildCount()>1`
- `Godot.Node.GetNodeOrNull<T>(Godot.NodePath)`；输入表达式：`.GetNodeOrNull<GridContainer>("LeagueAttackOrder")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .GetCreatureNode(hit.Dealer)?.GetNodeOrNull<GridContainer>("LeagueAttackOrder")`
- `MegaCrit.Sts2.Core.Commands.PowerCmd.Apply<T>(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, bool)`；输入表达式：`MegaCrit.Sts2.Core.Commands.PowerCmd.Apply<MegaCrit.Sts2.Core.Models.Powers.DoomPower>(ctx,receiver,extra,hit.Dealer,hit.DoomSource)`；返回值紧邻使用处：`AssignmentExpressionSyntax: application=MegaCrit.Sts2.Core.Commands.PowerCmd.Apply<MegaCrit.Sts2.Core.Models.Powers.DoomPower>(ctx,receiver,extra,hit.Dealer,hit.DoomSource)`
- `MegaCrit.Sts2.Core.GameActions.Multiplayer.BlockingPlayerChoiceContext.BlockingPlayerChoiceContext()`；输入表达式：`new BlockingPlayerChoiceContext()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new BlockingPlayerChoiceContext()`
- `MegaCrit.Sts2.Core.Models.Powers.DoomPower.DoomKill(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature>)`；输入表达式：`MegaCrit.Sts2.Core.Models.Powers.DoomPower.DoomKill(MegaCrit.Sts2.Core.Models.Powers.DoomPower.GetDoomedCreatures([receiver]))`；返回值紧邻使用处：`AwaitExpressionSyntax: await MegaCrit.Sts2.Core.Models.Powers.DoomPower.DoomKill(MegaCrit.Sts2.Core.Models.Powers.DoomPower.GetDoomedCreatures([receiver]))`
- `MegaCrit.Sts2.Core.Models.Powers.DoomPower.GetDoomedCreatures(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature>)`；输入表达式：`MegaCrit.Sts2.Core.Models.Powers.DoomPower.GetDoomedCreatures([receiver])`；返回值紧邻使用处：`ArgumentSyntax: MegaCrit.Sts2.Core.Models.Powers.DoomPower.GetDoomedCreatures([receiver])`
- `MegaCrit.Sts2.Core.Nodes.Combat.NIntent.PlayPerform()`；输入表达式：`icon.PlayPerform()`；返回值紧邻使用处：`ExpressionStatementSyntax: icon.PlayPerform();`
- `MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom.GetCreatureNode(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`.GetCreatureNode(hit.Dealer)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .GetCreatureNode(hit.Dealer)?.GetNodeOrNull<GridContainer>("LeagueAttackOrder")`
- `NationalSpire.LeagueBattleApi.Deliver(NationalSpire.LeagueDuel.Hit)`；输入表达式：`LeagueBattleApi.Deliver(hit)`；返回值紧邻使用处：`AwaitExpressionSyntax: await LeagueBattleApi.Deliver(hit)`
- `NationalSpire.LeagueBattleApi.SpendGuard(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature, int, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`LeagueBattleApi.SpendGuard(ctx,receiver,blocked,hit.Dealer)`；返回值紧邻使用处：`AwaitExpressionSyntax: await LeagueBattleApi.SpendGuard(ctx,receiver,blocked,hit.Dealer)`
- `NationalSpire.LeagueNativeMatch.Refresh(NationalSpire.LeagueOpponent)`；输入表达式：`Refresh(active)`；返回值紧邻使用处：`ExpressionStatementSyntax: Refresh(active);`
- `NationalSpire.LeagueNativeMatch.Refresh(NationalSpire.LeagueOpponent)`；输入表达式：`Refresh(foe)`；返回值紧邻使用处：`ExpressionStatementSyntax: Refresh(foe);`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`duel.Pending.Where(h=>h.Target.Side==side).ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var hit in duel.Pending.Where(h=>h.Target.Side==side).ToArray()){              var receiver=hit.Target;duel.Pending.Remove(hit);if(!receiver.IsAlive)continue;              if(NCombatRoom.Instance?.GetCreatureNode(hit.Dealer)?.GetNodeOrNull<GridContainer>("LeagueAttackOrder") is {} icons && icons.GetChildCount()>1 && icons.GetChild(0) is NIntent icon)icon.PlayPerform();              if(hit.Doom){                  var ctx=new BlockingPlayerChoiceContext();int blocked=Math.Min(receiver.Block,(int)hit.Amount);int extra=(int)hit.Amount-blocked;                  if(blocked>0)await LeagueBattleApi.SpendGuard(ctx,receiver,blocked,hit.Dealer);                  if(extra>0){Task application;_passApplication=true;                      try{application=MegaCrit.Sts2.Core.Commands.PowerCmd.Apply<MegaCrit.Sts2.Core.Models.Powers.DoomPower>(ctx,receiver,extra,hit.Dealer,hit.DoomSource);}                      finally{_passApplication=false;}await application;}                  if(hit.DoomSource?.Id.Entry=="END_OF_DAYS")await MegaCrit.Sts2.Core.Models.Powers.DoomPower.DoomKill(MegaCrit.Sts2.Core.Models.Powers.DoomPower.GetDoomedCreatures([receiver]));              }else await LeagueBattleApi.Deliver(hit);              if(duel.Rival.Creature.Monster is LeagueOpponent active)Refresh(active);          }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`duel.Pending.Where(h=>h.Target.Side==side)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: duel.Pending.Where(h=>h.Target.Side==side).ToArray`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`duel.Pending.Remove(hit)`；返回值紧邻使用处：`ExpressionStatementSyntax: duel.Pending.Remove(hit);`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(receiver.Block,(int)hit.Amount)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Math.Min(receiver.Block,(int)hit.Amount)`

**赋值（含属性/字段和局部值）：**

- `_passApplication` = `false`
- `_passApplication` = `true`
- `application` = `MegaCrit.Sts2.Core.Commands.PowerCmd.Apply<MegaCrit.Sts2.Core.Models.Powers.DoomPower>(ctx,receiver,extra,hit.Dealer,hit.DoomSource)`

<a id="symbol-8277ecd62500"></a>

## `NationalSpire.LeagueNativeMatch.Install() — private static void Install()`

来源：源码第 96 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.Start(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], int, NationalSpire.ICareerSession?, string, int, System.Collections.Generic.IReadOnlyDictionary<string, int>?, System.Collections.Generic.Dictionary<string, int>?, int, string?)`](LeagueNativeMatch.cs.md#symbol-5db2520de882)；[`NationalSpire.LeagueNativeMatch.StartFinal()`](ArchitectFinal.cs.md#symbol-bdca44c3d251)；[`NationalSpire.LeagueNativeMatch.StartTeam(NationalSpire.Coop.CoopCoordinator, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>)`](LeagueTeamMatch.cs.md#symbol-81e11d18adc7)

**调用：** [`NationalSpire.FinalEndHooks.Install(HarmonyLib.Harmony)`](ArchitectFinal.cs.md#symbol-e1677896058b)；[`NationalSpire.LeagueBattleApi.Install(HarmonyLib.Harmony)`](LeagueBattleApi.cs.md#symbol-5be518807d86)；[`NationalSpire.LeagueDuel.InstallSelections(HarmonyLib.Harmony)`](LeagueCardChoices.cs.md#symbol-de6736b83858)；[`NationalSpire.LeagueNativeMatch.InstallEffectTargets(HarmonyLib.Harmony)`](LeagueEffectTargets.cs.md#symbol-e5c8dd52e1ac)；[`NationalSpire.LeagueNativeMatch.InstallVisuals(HarmonyLib.Harmony)`](LeagueBattleVisuals.cs.md#symbol-12673676d8ef)；[`NationalSpire.LeagueNativeMatch.RemoveBattlePatches(HarmonyLib.Harmony)`](LeagueNativeMatch.cs.md#symbol-38de57ce7505)；[`OwnerPatch(string, string, bool)`](LeagueNativeMatch.cs.md#symbol-3f5a401b69dd)；`HarmonyLib.AccessTools.AsyncMoveNext(System.Reflection.MethodBase)`；`HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.Harmony.Harmony(string)`；`HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；`HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；`System.Reflection.Assembly.GetType(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.FinalEndHooks.Install(HarmonyLib.Harmony)`；`NationalSpire.LeagueBattleApi.Install(HarmonyLib.Harmony)`；`NationalSpire.LeagueDuel.InstallSelections(HarmonyLib.Harmony)`；`NationalSpire.LeagueNativeMatch._installed`；`NationalSpire.LeagueNativeMatch.InstallEffectTargets(HarmonyLib.Harmony)`；`NationalSpire.LeagueNativeMatch.InstallVisuals(HarmonyLib.Harmony)`；`NationalSpire.LeagueNativeMatch.RemoveBattlePatches(HarmonyLib.Harmony)`；`OwnerPatch(string, string, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.AsyncMoveNext(System.Reflection.MethodBase)`；输入表达式：`AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(eyes,"OnPlay"))`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(eyes,"OnPlay"))`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(eyes,"OnPlay")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.DeclaredMethod(eyes,"OnPlay")`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(impaled,"AfterApplied")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.DeclaredMethod(impaled,"AfterApplied")`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(tune,"AfterSideTurnEnd")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =AccessTools.DeclaredMethod(tune,"AfterSideTurnEnd")`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(CombatManager),"RunTurnLoopAfter")`；返回值紧邻使用处：`IsPatternExpressionSyntax: AccessTools.DeclaredMethod(typeof(CombatManager),"RunTurnLoopAfter") is {} loop`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(typeof(CreatureCmd),"Stun",[typeof(Creature),typeof(string)])`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.DeclaredMethod(typeof(CreatureCmd),"Stun",[typeof(Creature),typeof(string)])`
- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(SaveManager),nameof(SaveManager.UpdateProgressAfterCombatWon))`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.Method(typeof(SaveManager),nameof(SaveManager.UpdateProgressAfterCombatWon))`
- `HarmonyLib.Harmony.Harmony(string)`；输入表达式：`new Harmony("nationalspire.league.native")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Harmony("nationalspire.league.native")`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(eyes,"OnPlay")),transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(IntentReader)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.AsyncMoveNext(AccessTools.DeclaredMethod(eyes,"OnPlay")),transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(IntentReader)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.DeclaredMethod(impaled,"AfterApplied"),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ArrowOwner)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.DeclaredMethod(impaled,"AfterApplied"),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ArrowOwner)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.DeclaredMethod(typeof(CreatureCmd),"Stun",[typeof(Creature),typeof(string)]),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(StunFighter)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.DeclaredMethod(typeof(CreatureCmd),"Stun",[typeof(Creature),typeof(string)]),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(StunFighter)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(AccessTools.Method(typeof(SaveManager),nameof(SaveManager.UpdateProgressAfterCombatWon)),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(KeepAdventureStats)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(AccessTools.Method(typeof(SaveManager),nameof(SaveManager.UpdateProgressAfterCombatWon)),prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(KeepAdventureStats)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(loop,postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ObserveCombat)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(loop,postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ObserveCombat)));`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(m,prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(MelodySide)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(m,prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(MelodySide)));`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ArrowOwner))`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ArrowOwner))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(IntentReader))`；返回值紧邻使用处：`ArgumentSyntax: transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(IntentReader))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(KeepAdventureStats))`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(KeepAdventureStats))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(MelodySide))`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(MelodySide))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ObserveCombat))`；返回值紧邻使用处：`ArgumentSyntax: postfix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(ObserveCombat))`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(StunFighter))`；返回值紧邻使用处：`ArgumentSyntax: prefix:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(StunFighter))`
- `NationalSpire.FinalEndHooks.Install(HarmonyLib.Harmony)`；输入表达式：`FinalEndHooks.Install(h)`；返回值紧邻使用处：`ExpressionStatementSyntax: FinalEndHooks.Install(h);`
- `NationalSpire.LeagueBattleApi.Install(HarmonyLib.Harmony)`；输入表达式：`LeagueBattleApi.Install(h)`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueBattleApi.Install(h);`
- `NationalSpire.LeagueDuel.InstallSelections(HarmonyLib.Harmony)`；输入表达式：`LeagueDuel.InstallSelections(h)`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueDuel.InstallSelections(h);`
- `NationalSpire.LeagueNativeMatch.InstallEffectTargets(HarmonyLib.Harmony)`；输入表达式：`InstallEffectTargets(h)`；返回值紧邻使用处：`ExpressionStatementSyntax: InstallEffectTargets(h);`
- `NationalSpire.LeagueNativeMatch.InstallVisuals(HarmonyLib.Harmony)`；输入表达式：`InstallVisuals(h)`；返回值紧邻使用处：`ExpressionStatementSyntax: InstallVisuals(h);`
- `NationalSpire.LeagueNativeMatch.RemoveBattlePatches(HarmonyLib.Harmony)`；输入表达式：`RemoveBattlePatches(h)`；返回值紧邻使用处：`ExpressionStatementSyntax: RemoveBattlePatches(h);`
- `OwnerPatch(string, string, bool)`；输入表达式：`OwnerPatch("Commands.Builders.AttackCommand","Execute")`；返回值紧邻使用处：`ExpressionStatementSyntax: OwnerPatch("Commands.Builders.AttackCommand","Execute");`
- `OwnerPatch(string, string, bool)`；输入表达式：`OwnerPatch("Models.Powers.HellraiserPower","BeforeAttack",false)`；返回值紧邻使用处：`ExpressionStatementSyntax: OwnerPatch("Models.Powers.HellraiserPower","BeforeAttack",false);`
- `System.Reflection.Assembly.GetType(string)`；输入表达式：`typeof(CardModel).Assembly.GetType("MegaCrit.Sts2.Core.Models.Cards.GoForTheEyes")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =typeof(CardModel).Assembly.GetType("MegaCrit.Sts2.Core.Models.Cards.GoForTheEyes")`
- `System.Reflection.Assembly.GetType(string)`；输入表达式：`typeof(PowerModel).Assembly.GetType("MegaCrit.Sts2.Core.Models.Powers.ImpaledPower")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =typeof(PowerModel).Assembly.GetType("MegaCrit.Sts2.Core.Models.Powers.ImpaledPower")`
- `System.Reflection.Assembly.GetType(string)`；输入表达式：`typeof(PowerModel).Assembly.GetType("MegaCrit.Sts2.Core.Models.Powers.TunePower")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =typeof(PowerModel).Assembly.GetType("MegaCrit.Sts2.Core.Models.Powers.TunePower")`

**赋值（含属性/字段和局部值）：**

- `_installed` = `true`

<a id="symbol-3f5a401b69dd"></a>

## `OwnerPatch(string, string, bool) — void OwnerPatch(string type,string method,bool async=true)`

来源：源码第 105 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.Install()`](LeagueNativeMatch.cs.md#symbol-8277ecd62500)

**调用：** `HarmonyLib.AccessTools.AsyncMoveNext(System.Reflection.MethodBase)`；`HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；`HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；`System.Reflection.Assembly.GetType(string)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.AsyncMoveNext(System.Reflection.MethodBase)`；输入表达式：`AccessTools.AsyncMoveNext(m)`；返回值紧邻使用处：`ConditionalExpressionSyntax: async?AccessTools.AsyncMoveNext(m):m`
- `HarmonyLib.AccessTools.DeclaredMethod(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.DeclaredMethod(t,method)`；返回值紧邻使用处：`IsPatternExpressionSyntax: AccessTools.DeclaredMethod(t,method) is not {} m`
- `HarmonyLib.Harmony.Patch(System.Reflection.MethodBase, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod, HarmonyLib.HarmonyMethod)`；输入表达式：`h.Patch(async?AccessTools.AsyncMoveNext(m):m,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(LeagueOwner)))`；返回值紧邻使用处：`ExpressionStatementSyntax: h.Patch(async?AccessTools.AsyncMoveNext(m):m,transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(LeagueOwner)));`
- `HarmonyLib.HarmonyMethod.HarmonyMethod(System.Type, string, System.Type[])`；输入表达式：`new HarmonyMethod(typeof(LeagueNativeMatch),nameof(LeagueOwner))`；返回值紧邻使用处：`ArgumentSyntax: transpiler:new HarmonyMethod(typeof(LeagueNativeMatch),nameof(LeagueOwner))`
- `System.Reflection.Assembly.GetType(string)`；输入表达式：`typeof(PowerModel).Assembly.GetType("MegaCrit.Sts2.Core."+type)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =typeof(PowerModel).Assembly.GetType("MegaCrit.Sts2.Core."+type)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-38de57ce7505"></a>

## `NationalSpire.LeagueNativeMatch.RemoveBattlePatches(HarmonyLib.Harmony) — private static void RemoveBattlePatches(Harmony h)`

来源：源码第 120 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.Install()`](LeagueNativeMatch.cs.md#symbol-8277ecd62500)；[`NationalSpire.LeagueNativeMatch.Release()`](LeagueNativeMatch.cs.md#symbol-242512cbc319)

**调用：** `HarmonyLib.Harmony.UnpatchAll(string)`；`System.Collections.Generic.HashSet<T>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch._installed`；`NationalSpire.LeagueNativeMatch.EffectPatches`；`NationalSpire.LeagueNativeMatch.SeenPowers`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.Harmony.UnpatchAll(string)`；输入表达式：`h.UnpatchAll(h.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: h.UnpatchAll(h.Id);`
- `System.Collections.Generic.HashSet<T>.Clear()`；输入表达式：`EffectPatches.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: EffectPatches.Clear();`
- `System.Collections.Generic.HashSet<T>.Clear()`；输入表达式：`SeenPowers.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: SeenPowers.Clear();`

**赋值（含属性/字段和局部值）：**

- `_installed` = `false`

<a id="symbol-1084f38840f0"></a>

## `NationalSpire.LeagueNativeMatch.StunFighter(MegaCrit.Sts2.Core.Entities.Creatures.Creature, ref System.Threading.Tasks.Task) — private static bool StunFighter(Creature creature,ref Task __result)`

来源：源码第 123 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`](ArchitectFinal.cs.md#symbol-943fdb98d018)；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Stunned`；`NationalSpire.LeagueNativeMatch._run`；`NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`For(creature)`；返回值紧邻使用处：`BinaryExpressionSyntax: For(creature)==null`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`duel.Stunned.Add(creature)`；返回值紧邻使用处：`ExpressionStatementSyntax: duel.Stunned.Add(creature);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Players.Any(p=>p.Creature==creature)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _run?.Players.Any(p=>p.Creature==creature)`

**赋值（含属性/字段和局部值）：**

- `__result` = `Task.CompletedTask`

<a id="symbol-1ebfa08e7076"></a>

## `NationalSpire.LeagueNativeMatch.ConsumeStun(MegaCrit.Sts2.Core.Entities.Creatures.Creature) — internal static bool ConsumeStun(Creature creature)`

来源：源码第 128 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueDuel.Act()`](LeagueDuel.cs.md#symbol-0b7f3276ecd9)；[`NationalSpire.LeagueNativeMatch.PlayerTurn(MegaCrit.Sts2.Core.Combat.CombatState)`](LeagueNativeMatch.cs.md#symbol-0389816f56fc)

**调用：** `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`MegaCrit.Sts2.Core.Nodes.Vfx.NStunnedVfx.Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`System.Collections.Generic.HashSet<T>.Remove(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Stunned`；`NationalSpire.LeagueNativeMatch.Current`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`.AddChild(fx)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: NCombatRoom.Instance?.AddChild(fx)`
- `MegaCrit.Sts2.Core.Nodes.Vfx.NStunnedVfx.Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`MegaCrit.Sts2.Core.Nodes.Vfx.NStunnedVfx.Create(creature)`；返回值紧邻使用处：`IsPatternExpressionSyntax: MegaCrit.Sts2.Core.Nodes.Vfx.NStunnedVfx.Create(creature) is {} fx`
- `System.Collections.Generic.HashSet<T>.Remove(T)`；输入表达式：`.Stunned.Remove(creature)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Current?.Stunned.Remove(creature)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0389816f56fc"></a>

## `NationalSpire.LeagueNativeMatch.PlayerTurn(MegaCrit.Sts2.Core.Combat.CombatState) — private static void PlayerTurn(CombatState state)`

来源：源码第 133 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.ConsumeStun(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`](LeagueNativeMatch.cs.md#symbol-1ebfa08e7076)；`MegaCrit.Sts2.Core.Combat.CombatManager.SetReadyToEndTurn(MegaCrit.Sts2.Core.Entities.Players.Player, bool, System.Func<System.Threading.Tasks.Task>?)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch._run`；`NationalSpire.LeagueNativeMatch.ConsumeStun(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Combat.CombatManager.SetReadyToEndTurn(MegaCrit.Sts2.Core.Entities.Players.Player, bool, System.Func<System.Threading.Tasks.Task>?)`；输入表达式：`CombatManager.Instance.SetReadyToEndTurn(player,false)`；返回值紧邻使用处：`ExpressionStatementSyntax: CombatManager.Instance.SetReadyToEndTurn(player,false);`
- `NationalSpire.LeagueNativeMatch.ConsumeStun(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`ConsumeStun(p.Creature)`；返回值紧邻使用处：`BinaryExpressionSyntax: state==p.Creature.CombatState&&ConsumeStun(p.Creature)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_run.Players.Where(p=>state==p.Creature.CombatState&&ConsumeStun(p.Creature))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var player in _run.Players.Where(p=>state==p.Creature.CombatState&&ConsumeStun(p.Creature)))              CombatManager.Instance.SetReadyToEndTurn(player,false);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4d6a6f8d1a9e"></a>

## `NationalSpire.LeagueNativeMatch.LeagueOwner(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction>) — private static IEnumerable<CodeInstruction> LeagueOwner(IEnumerable<CodeInstruction> instructions)`

来源：源码第 139 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.AccessTools.PropertyGetter(System.Type, string)`；`HarmonyLib.CodeInstruction.Calls(System.Reflection.MethodInfo)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(LeagueNativeMatch),nameof(LeaguePlayer))`；返回值紧邻使用处：`AssignmentExpressionSyntax: instruction.operand=AccessTools.Method(typeof(LeagueNativeMatch),nameof(LeaguePlayer))`
- `HarmonyLib.AccessTools.PropertyGetter(System.Type, string)`；输入表达式：`AccessTools.PropertyGetter(typeof(Creature),nameof(Creature.Player))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =AccessTools.PropertyGetter(typeof(Creature),nameof(Creature.Player))`
- `HarmonyLib.CodeInstruction.Calls(System.Reflection.MethodInfo)`；输入表达式：`instruction.Calls(getter)`；返回值紧邻使用处：`IfStatementSyntax: if(instruction.Calls(getter)){instruction.opcode=System.Reflection.Emit.OpCodes.Call;instruction.operand=AccessTools.Method(typeof(LeagueNativeMatch),nameof(LeaguePlayer));}`

**赋值（含属性/字段和局部值）：**

- `instruction.opcode` = `System.Reflection.Emit.OpCodes.Call`
- `instruction.operand` = `AccessTools.Method(typeof(LeagueNativeMatch),nameof(LeaguePlayer))`

<a id="symbol-130a97fef955"></a>

## `NationalSpire.LeagueNativeMatch.LeaguePlayer(MegaCrit.Sts2.Core.Entities.Creatures.Creature) — private static Player? LeaguePlayer(Creature owner)`

来源：源码第 146 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.Refresh(NationalSpire.LeagueOpponent)`](LeagueNativeMatch.cs.md#symbol-5fb078947d8b)

**调用：** [`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`](ArchitectFinal.cs.md#symbol-943fdb98d018)

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`For(owner)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: For(owner)?.Rival`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d5f6c0324093"></a>

## `NationalSpire.LeagueNativeMatch.MelodySide(MegaCrit.Sts2.Core.Models.PowerModel, ref MegaCrit.Sts2.Core.Combat.CombatSide) — private static void MelodySide(PowerModel __instance,ref CombatSide side)`

来源：源码第 147 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`](ArchitectFinal.cs.md#symbol-943fdb98d018)

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`For(__instance.Owner)`；返回值紧邻使用处：`BinaryExpressionSyntax: For(__instance.Owner)!=null`

**赋值（含属性/字段和局部值）：**

- `side` = `side==CombatSide.Enemy?CombatSide.Player:CombatSide.Enemy`

<a id="symbol-4a4c64c576cc"></a>

## `NationalSpire.LeagueNativeMatch.IntentReader(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction>) — private static IEnumerable<CodeInstruction> IntentReader(IEnumerable<CodeInstruction> instructions)`

来源：源码第 148 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；`HarmonyLib.AccessTools.PropertyGetter(System.Type, string)`；`HarmonyLib.CodeInstruction.Calls(System.Reflection.MethodInfo)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HarmonyLib.AccessTools.Method(System.Type, string, System.Type[], System.Type[])`；输入表达式：`AccessTools.Method(typeof(LeagueNativeMatch),nameof(HasAttack))`；返回值紧邻使用处：`AssignmentExpressionSyntax: code[i].operand=AccessTools.Method(typeof(LeagueNativeMatch),nameof(HasAttack))`
- `HarmonyLib.AccessTools.PropertyGetter(System.Type, string)`；输入表达式：`AccessTools.PropertyGetter(typeof(Creature),"Monster")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.PropertyGetter(typeof(Creature),"Monster")`
- `HarmonyLib.AccessTools.PropertyGetter(System.Type, string)`；输入表达式：`AccessTools.PropertyGetter(typeof(MonsterModel),"IntendsToAttack")`；返回值紧邻使用处：`ArgumentSyntax: AccessTools.PropertyGetter(typeof(MonsterModel),"IntendsToAttack")`
- `HarmonyLib.CodeInstruction.Calls(System.Reflection.MethodInfo)`；输入表达式：`code[i].Calls(AccessTools.PropertyGetter(typeof(Creature),"Monster"))`；返回值紧邻使用处：`BinaryExpressionSyntax: code[i].Calls(AccessTools.PropertyGetter(typeof(Creature),"Monster"))&&code[i+1].Calls(AccessTools.PropertyGetter(typeof(MonsterModel),"IntendsToAttack"))`
- `HarmonyLib.CodeInstruction.Calls(System.Reflection.MethodInfo)`；输入表达式：`code[i+1].Calls(AccessTools.PropertyGetter(typeof(MonsterModel),"IntendsToAttack"))`；返回值紧邻使用处：`BinaryExpressionSyntax: code[i].Calls(AccessTools.PropertyGetter(typeof(Creature),"Monster"))&&code[i+1].Calls(AccessTools.PropertyGetter(typeof(MonsterModel),"IntendsToAttack"))`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`instructions.ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =instructions.ToList()`

**赋值（含属性/字段和局部值）：**

- `code[i].opcode` = `System.Reflection.Emit.OpCodes.Call`
- `code[i].operand` = `AccessTools.Method(typeof(LeagueNativeMatch),nameof(HasAttack))`
- `code[i+1].opcode` = `System.Reflection.Emit.OpCodes.Nop`
- `code[i+1].operand` = `null`

<a id="symbol-8a9e318f041c"></a>

## `NationalSpire.LeagueNativeMatch.HasAttack(MegaCrit.Sts2.Core.Entities.Creatures.Creature) — private static bool HasAttack(Creature c)`

来源：源码第 153 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Hit.Amount`；`NationalSpire.LeagueDuel.Hit.Dealer`；`NationalSpire.LeagueDuel.Pending`；`NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueNativeMatch.Current`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`duel.Pending.Any(h=>h.Dealer==c&&h.Amount>0)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Current is {} duel&&c.CombatState==duel.Rival.Creature.CombatState?duel.Pending.Any(h=>h.Dealer==c&&h.Amount>0):c.Monster?.IntendsToAttack==true`

**赋值（含属性/字段和局部值）：**


<a id="symbol-45c09f5d42b0"></a>

## `NationalSpire.LeagueNativeMatch.ObserveCombat(System.Threading.Tasks.Task) — private static void ObserveCombat(Task __result)`

来源：源码第 156 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.NoticeFailure(System.Threading.Tasks.Task, NationalSpire.LeagueDuel)`](LeagueNativeMatch.cs.md#symbol-a4936685f05f)

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.NoticeFailure(System.Threading.Tasks.Task, NationalSpire.LeagueDuel)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueNativeMatch.NoticeFailure(System.Threading.Tasks.Task, NationalSpire.LeagueDuel)`；输入表达式：`NoticeFailure(__result,duel)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _=NoticeFailure(__result,duel)`

**赋值（含属性/字段和局部值）：**

- `_` = `NoticeFailure(__result,duel)`

<a id="symbol-a4936685f05f"></a>

## `NationalSpire.LeagueNativeMatch.NoticeFailure(System.Threading.Tasks.Task, NationalSpire.LeagueDuel) — private static async Task NoticeFailure(Task running,LeagueDuel duel)`

来源：源码第 157 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.ObserveCombat(System.Threading.Tasks.Task)`](LeagueNativeMatch.cs.md#symbol-45c09f5d42b0)

**调用：** [`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.LeagueNativeMatch.FinishFinal(bool?)`](ArchitectFinal.cs.md#symbol-eb8d4b32d343)；`Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；`Godot.Window.PopupCentered(Godot.Vector2I?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.LeagueNativeMatch._exit`；`NationalSpire.LeagueNativeMatch._exitDialog`；`NationalSpire.LeagueNativeMatch._returning`；`NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.FinishFinal(bool?)`；`NationalSpire.LeagueNativeMatch.InFinal`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GodotObject.IsInstanceValid(Godot.GodotObject?)`；输入表达式：`GodotObject.IsInstanceValid(_exitDialog)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GodotObject.IsInstanceValid(_exitDialog)`
- `Godot.Window.PopupCentered(Godot.Vector2I?)`；输入表达式：`_exitDialog.PopupCentered()`；返回值紧邻使用处：`ExpressionStatementSyntax: _exitDialog.PopupCentered();`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("league-match",error)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("league-match",error);`
- `NationalSpire.LeagueNativeMatch.FinishFinal(bool?)`；输入表达式：`FinishFinal(null)`；返回值紧邻使用处：`AwaitExpressionSyntax: await FinishFinal(null)`

**赋值（含属性/字段和局部值）：**

- `_exit!.Text` = `"对战中断 · 返回"`
- `_exitDialog!.Title` = `"本场对战中断"`
- `_exitDialog.CancelButtonText` = `"留在战场"`
- `_exitDialog.DialogText` = `"游戏无法继续本回合。可以返回集卡重新匹配，本场不记录胜负或积分。"`
- `_exitDialog.OkButtonText` = `"返回集卡"`

<a id="symbol-c7bf6cbb732d"></a>

## `NationalSpire.LeagueNativeMatch.InstallExit(MegaCrit.Sts2.Core.Nodes.NRun) — private static void InstallExit(NRun scene)`

来源：源码第 168 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Begin()`](LeagueTeamMatch.cs.md#symbol-7113ab57a2bd)；[`NationalSpire.LeagueNativeMatch.Start(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], int, NationalSpire.ICareerSession?, string, int, System.Collections.Generic.IReadOnlyDictionary<string, int>?, System.Collections.Generic.Dictionary<string, int>?, int, string?)`](LeagueNativeMatch.cs.md#symbol-5db2520de882)

**调用：** [`NationalSpire.Coop.CoopRuntime.Pause()`](Coop/CoopRuntime.cs.md#symbol-4d6b5e85d748)；[`NationalSpire.LeagueNativeMatch.Return(string?, bool?)`](LeagueNativeMatch.cs.md#symbol-1b324a0cbccb)；`Godot.Button.Button()`；`Godot.CanvasLayer.CanvasLayer()`；`Godot.ConfirmationDialog.ConfirmationDialog()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Window.PopupCentered(Godot.Vector2I?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopRuntime.Current`；`NationalSpire.Coop.CoopRuntime.Pause()`；`NationalSpire.LeagueNativeMatch._exit`；`NationalSpire.LeagueNativeMatch._exitDialog`；`NationalSpire.LeagueNativeMatch._returning`；`NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.IsTeamMatch`；`NationalSpire.LeagueNativeMatch.Return(string?, bool?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button{Text="退出联赛",TooltipText="中止本场，返回集卡对战",FocusMode=Control.FocusModeEnum.None}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Button{Text="退出联赛",TooltipText="中止本场，返回集卡对战",FocusMode=Control.FocusModeEnum.None}`
- `Godot.CanvasLayer.CanvasLayer()`；输入表达式：`new CanvasLayer{Layer=75}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new CanvasLayer{Layer=75}`
- `Godot.ConfirmationDialog.ConfirmationDialog()`；输入表达式：`new ConfirmationDialog{Title="退出本场联赛",DialogText="返回集卡对战。本场中止，不记录胜负或积分。",OkButtonText="退出对战",CancelButtonText="继续对战"}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new ConfirmationDialog{Title="退出本场联赛",DialogText="返回集卡对战。本场中止，不记录胜负或积分。",OkButtonText="退出对战",CancelButtonText="继续对战"}`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`button.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.TopRight)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.TopRight);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`layer.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: layer.AddChild(button);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`layer.AddChild(dialog)`；返回值紧邻使用处：`ExpressionStatementSyntax: layer.AddChild(dialog);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`scene.AddChild(layer)`；返回值紧邻使用处：`ExpressionStatementSyntax: scene.AddChild(layer);`
- `Godot.Window.PopupCentered(Godot.Vector2I?)`；输入表达式：`dialog.PopupCentered()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>dialog.PopupCentered()`
- `NationalSpire.Coop.CoopRuntime.Pause()`；输入表达式：`Coop.CoopRuntime.Current!.Pause()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _=Coop.CoopRuntime.Current!.Pause()`
- `NationalSpire.LeagueNativeMatch.Return(string?, bool?)`；输入表达式：`Return("本场已中止。")`；返回值紧邻使用处：`AssignmentExpressionSyntax: _=Return("本场已中止。")`

**赋值（含属性/字段和局部值）：**

- `_` = `Coop.CoopRuntime.Current!.Pause()`
- `_` = `Return("本场已中止。")`
- `_exit` = `button`
- `_exitDialog` = `dialog`
- `_returning` = `true`
- `button.OffsetBottom` = `122`
- `button.OffsetLeft` = `-167`
- `button.OffsetRight` = `-30`
- `button.OffsetTop` = `82`
- `button.Pressed` += `()=>dialog.PopupCentered()`
- `CancelButtonText` = `"继续对战"`
- `dialog.Confirmed` += `()=>{if(Current!=null&&!_returning){if(IsTeamMatch)_=Coop.CoopRuntime.Current!.Pause();else{_returning=true;_=Return("本场已中止。");}}}`
- `DialogText` = `"返回集卡对战。本场中止，不记录胜负或积分。"`
- `FocusMode` = `Control.FocusModeEnum.None`
- `Layer` = `75`
- `OkButtonText` = `"退出对战"`
- `Text` = `"退出联赛"`
- `Title` = `"退出本场联赛"`
- `TooltipText` = `"中止本场，返回集卡对战"`

<a id="symbol-d9c32e869c77"></a>

## `NationalSpire.LeagueNativeMatch.KeepAdventureStats(MegaCrit.Sts2.Core.Rooms.CombatRoom) — private static bool KeepAdventureStats(CombatRoom combatRoom)`

来源：源码第 174 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch._room`；`NationalSpire.LeagueNativeMatch.Current`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3daab8f54d5d"></a>

## `NationalSpire.LeagueNativeMatch.ArrowOwner(MegaCrit.Sts2.Core.Models.PowerModel, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, ref System.Threading.Tasks.Task) — private static bool ArrowOwner(PowerModel __instance,Creature? applier,ref Task __result)`

来源：源码第 175 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`](ArchitectFinal.cs.md#symbol-943fdb98d018)

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.OpponentName`；`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`For(applier)`；返回值紧邻使用处：`IsPatternExpressionSyntax: For(applier) is not {} shooter`

**赋值（含属性/字段和局部值）：**

- `__result` = `Task.CompletedTask`
- `((MegaCrit.Sts2.Core.Localization.DynamicVars.StringVar)__instance.DynamicVars["Applier"]).StringValue` = `shooter.OpponentName`

<a id="symbol-699665317746"></a>

## `NationalSpire.LeagueNativeMatch.QueueHits(System.Collections.Generic.IEnumerable<(MegaCrit.Sts2.Core.Entities.Creatures.Creature Target, string? Vfx, bool Center)>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>>) — internal static bool QueueHits(IEnumerable<(Creature Target,string? Vfx,bool Center)> targets,decimal amount,ValueProp props,Creature? dealer,CardModel? source,CardPlay? play,ModifyDamageHookType modifiers,ref Task<IEnumerable<DamageResult>> result)`

来源：源码第 180 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueBattleApi.Detailed<T>.Record(System.Collections.Generic.IEnumerable<T>?, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>>)`](LeagueBattleApi.cs.md#symbol-ed3c116afc58)；[`NationalSpire.LeagueBattleApi.Record(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>?, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>>)`](LeagueBattleApi.cs.md#symbol-91446c9c5697)；[`NationalSpire.LeagueNativeMatch.EffectHit(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`](LeagueEffectTargets.cs.md#symbol-71ee665e8771)；[`NationalSpire.LeagueNativeMatch.PoisonHit(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?)`](LeagueEffectTargets.cs.md#symbol-ee7b115c5652)；[`NationalSpire.LeagueNativeMatch.ThornHit(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?)`](LeagueEffectTargets.cs.md#symbol-4719d5d30a29)

**调用：** [`NationalSpire.LeagueNativeMatch.Refresh(NationalSpire.LeagueOpponent)`](LeagueNativeMatch.cs.md#symbol-5fb078947d8b)；`MegaCrit.Sts2.Core.Entities.Creatures.DamageResult.DamageResult(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.ValueProps.ValueProp)`；`MegaCrit.Sts2.Core.Hooks.Hook.ModifyDamage(MegaCrit.Sts2.Core.Runs.IRunState, MegaCrit.Sts2.Core.Combat.ICombatState?, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, MegaCrit.Sts2.Core.Entities.Cards.CardPreviewMode, out System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel>)`；`NationalSpire.LeagueDuel.Hit.Hit(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, string?, bool)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Math.Max(decimal, decimal)`；`System.Threading.Tasks.Task.FromResult<TResult>(TResult)`

**字段、属性、事件及方法组引用：** `(MegaCrit.Sts2.Core.Entities.Creatures.Creature Target, string Vfx, bool Center).Center`；`(MegaCrit.Sts2.Core.Entities.Creatures.Creature Target, string Vfx, bool Center).Target`；`(MegaCrit.Sts2.Core.Entities.Creatures.Creature Target, string Vfx, bool Center).Vfx`；`NationalSpire.LeagueDuel.Pending`；`NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueNativeMatch._room`；`NationalSpire.LeagueNativeMatch._run`；`NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.Refresh(NationalSpire.LeagueOpponent)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Entities.Creatures.DamageResult.DamageResult(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.ValueProps.ValueProp)`；输入表达式：`new DamageResult(t.Target,props)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: t=>new DamageResult(t.Target,props)`
- `MegaCrit.Sts2.Core.Hooks.Hook.ModifyDamage(MegaCrit.Sts2.Core.Runs.IRunState, MegaCrit.Sts2.Core.Combat.ICombatState?, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, MegaCrit.Sts2.Core.Entities.Cards.CardPreviewMode, out System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel>)`；输入表达式：`Hook.ModifyDamage(_run!,_room.CombatState,item.Target,dealer,amount,props,source,play,modifiers,CardPreviewMode.None,out _)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Hook.ModifyDamage(_run!,_room.CombatState,item.Target,dealer,amount,props,source,play,modifiers,CardPreviewMode.None,out _)`
- `NationalSpire.LeagueDuel.Hit.Hit(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, string?, bool)`；输入表达式：`new(dealer,item.Target,Math.Max(0,val),props,item.Vfx,item.Center)`；返回值紧邻使用处：`ArgumentSyntax: new(dealer,item.Target,Math.Max(0,val),props,item.Vfx,item.Center)`
- `NationalSpire.LeagueNativeMatch.Refresh(NationalSpire.LeagueOpponent)`；输入表达式：`Refresh(foe)`；返回值紧邻使用处：`ExpressionStatementSyntax: Refresh(foe);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`items.Any(t=>t.Target.Side==dealer.Side)`；返回值紧邻使用处：`BinaryExpressionSyntax: items.Length==0||items.Any(t=>t.Target.Side==dealer.Side)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`items.Select(t=>new DamageResult(t.Target,props))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: items.Select(t=>new DamageResult(t.Target,props)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`targets.ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =targets.ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`items.Select(t=>new DamageResult(t.Target,props)).ToList()`；返回值紧邻使用处：`ArgumentSyntax: items.Select(t=>new DamageResult(t.Target,props)).ToList()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`Current.Pending.Add(new(dealer,item.Target,Math.Max(0,val),props,item.Vfx,item.Center))`；返回值紧邻使用处：`ExpressionStatementSyntax: Current.Pending.Add(new(dealer,item.Target,Math.Max(0,val),props,item.Vfx,item.Center));`
- `System.Math.Max(decimal, decimal)`；输入表达式：`Math.Max(0,val)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0,val)`
- `System.Threading.Tasks.Task.FromResult<TResult>(TResult)`；输入表达式：`Task.FromResult<IEnumerable<DamageResult>>(items.Select(t=>new DamageResult(t.Target,props)).ToList())`；返回值紧邻使用处：`AssignmentExpressionSyntax: result=Task.FromResult<IEnumerable<DamageResult>>(items.Select(t=>new DamageResult(t.Target,props)).ToList())`

**赋值（含属性/字段和局部值）：**

- `result` = `Task.FromResult<IEnumerable<DamageResult>>(items.Select(t=>new DamageResult(t.Target,props)).ToList())`

<a id="symbol-5fb078947d8b"></a>

## `NationalSpire.LeagueNativeMatch.Refresh(NationalSpire.LeagueOpponent) — private static void Refresh(LeagueOpponent foe)`

来源：源码第 190 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.Enemy(NationalSpire.LeagueOpponent)`](LeagueNativeMatch.cs.md#symbol-531731d36b7d)；[`NationalSpire.LeagueNativeMatch.First(NationalSpire.LeagueOpponent)`](LeagueNativeMatch.cs.md#symbol-2e5d42d12c6a)；[`NationalSpire.LeagueNativeMatch.QueueDoom(MegaCrit.Sts2.Core.Models.PowerModel, MegaCrit.Sts2.Core.Entities.Creatures.Creature, decimal, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?)`](LeagueEffectTargets.cs.md#symbol-ebb77af45201)；[`NationalSpire.LeagueNativeMatch.QueueHits(System.Collections.Generic.IEnumerable<(MegaCrit.Sts2.Core.Entities.Creatures.Creature Target, string? Vfx, bool Center)>, decimal, MegaCrit.Sts2.Core.ValueProps.ValueProp, MegaCrit.Sts2.Core.Entities.Creatures.Creature?, MegaCrit.Sts2.Core.Models.CardModel?, MegaCrit.Sts2.Core.Entities.Cards.CardPlay?, MegaCrit.Sts2.Core.Hooks.ModifyDamageHookType, ref System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>>)`](LeagueNativeMatch.cs.md#symbol-699665317746)；[`NationalSpire.LeagueNativeMatch.Resolve(MegaCrit.Sts2.Core.Combat.CombatSide)`](LeagueNativeMatch.cs.md#symbol-bea557065b97)

**调用：** [`NationalSpire.LeagueNativeMatch.LeaguePlayer(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`](LeagueNativeMatch.cs.md#symbol-130a97fef955)；[`NationalSpire.LeagueNativeMatch.ShowTeamIntent(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Nodes.Combat.NCreature)`](LeagueNativeMatch.cs.md#symbol-50df0eb4b7be)；`Godot.CanvasItem.GetViewportRect()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.GetGlobalRect()`；`Godot.Control.ResetSize()`；`Godot.GridContainer.GridContainer()`；`Godot.Label.Label()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChild(int, bool)`；`Godot.Node.GetChild<T>(int, bool)`；`Godot.Node.GetChildCount(bool)`；`Godot.Node.GetNodeOrNull<T>(Godot.NodePath)`；`Godot.Node.MoveChild(Godot.Node, int)`；`Godot.Node.QueueFree()`；`Godot.Node.RemoveChild(Godot.Node)`；`Godot.Vector2.Vector2(float, float)`；`MegaCrit.Sts2.Core.Nodes.Combat.NIntent.Create(float)`；`MegaCrit.Sts2.Core.Nodes.Combat.NIntent.UpdateIntent(MegaCrit.Sts2.Core.MonsterMoves.Intents.AbstractIntent, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom.GetCreatureNode(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；`NationalSpire.LeagueNativeMatch.DoomIntent.DoomIntent(int)`；`NationalSpire.LeagueNativeMatch.RecordedIntent.RecordedIntent(int)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Math.Clamp(float, float, float)`；`System.Math.Max(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Hit.Amount`；`NationalSpire.LeagueDuel.Hit.Dealer`；`NationalSpire.LeagueDuel.Hit.Doom`；`NationalSpire.LeagueDuel.Hit.Target`；`NationalSpire.LeagueDuel.Pending`；`NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueNativeMatch._run`；`NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.Fighters`；`NationalSpire.LeagueNativeMatch.LeaguePlayer(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`NationalSpire.LeagueNativeMatch.ShowTeamIntent(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Nodes.Combat.NCreature)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.GetViewportRect()`；输入表达式：`node.GetViewportRect()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =node.GetViewportRect()`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`line.AddThemeConstantOverride("h_separation",3)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddThemeConstantOverride("h_separation",3);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`line.AddThemeConstantOverride("v_separation",2)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddThemeConstantOverride("v_separation",2);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`sum.AddThemeConstantOverride("outline_size",6)`；返回值紧邻使用处：`ExpressionStatementSyntax: sum.AddThemeConstantOverride("outline_size",6);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`sum.AddThemeFontSizeOverride("font_size",26)`；返回值紧邻使用处：`ExpressionStatementSyntax: sum.AddThemeFontSizeOverride("font_size",26);`
- `Godot.Control.GetGlobalRect()`；输入表达式：`line.GetGlobalRect()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =line.GetGlobalRect()`
- `Godot.Control.ResetSize()`；输入表达式：`line.ResetSize()`；返回值紧邻使用处：`ExpressionStatementSyntax: line.ResetSize();`
- `Godot.GridContainer.GridContainer()`；输入表达式：`new(){Name="LeagueAttackOrder",Columns=team?3:6,MouseFilter=Control.MouseFilterEnum.Ignore}`；返回值紧邻使用处：`AssignmentExpressionSyntax: line=new(){Name="LeagueAttackOrder",Columns=team?3:6,MouseFilter=Control.MouseFilterEnum.Ignore}`
- `Godot.Label.Label()`；输入表达式：`new Label{Name="Total",VerticalAlignment=VerticalAlignment.Center,MouseFilter=Control.MouseFilterEnum.Ignore}`；返回值紧邻使用处：`AssignmentExpressionSyntax: sum=new Label{Name="Total",VerticalAlignment=VerticalAlignment.Center,MouseFilter=Control.MouseFilterEnum.Ignore}`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(icon)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(icon);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`line.AddChild(sum)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.AddChild(sum);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`node.AddChild(line)`；返回值紧邻使用处：`ExpressionStatementSyntax: node.AddChild(line);`
- `Godot.Node.GetChild(int, bool)`；输入表达式：`line.GetChild(--shown)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =line.GetChild(--shown)`
- `Godot.Node.GetChild<T>(int, bool)`；输入表达式：`line.GetChild<NIntent>(i)`；返回值紧邻使用处：`AssignmentExpressionSyntax: icon=line.GetChild<NIntent>(i)`
- `Godot.Node.GetChildCount(bool)`；输入表达式：`line.GetChildCount()`；返回值紧邻使用处：`BinaryExpressionSyntax: line.GetChildCount()-1`
- `Godot.Node.GetNodeOrNull<T>(Godot.NodePath)`；输入表达式：`line.GetNodeOrNull<Label>("Total")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =line.GetNodeOrNull<Label>("Total")`
- `Godot.Node.GetNodeOrNull<T>(Godot.NodePath)`；输入表达式：`node.GetNodeOrNull<GridContainer>("LeagueAttackOrder")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =node.GetNodeOrNull<GridContainer>("LeagueAttackOrder")`
- `Godot.Node.MoveChild(Godot.Node, int)`；输入表达式：`line.MoveChild(icon,i)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.MoveChild(icon,i);`
- `Godot.Node.QueueFree()`；输入表达式：`old.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: old.QueueFree();`
- `Godot.Node.RemoveChild(Godot.Node)`；输入表达式：`line.RemoveChild(old)`；返回值紧邻使用处：`ExpressionStatementSyntax: line.RemoveChild(old);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(line.Size.X/2,line.Size.Y-32+orbit)`；返回值紧邻使用处：`BinaryExpressionSyntax: anchor.Position+anchor.Size*.5f-new Vector2(line.Size.X/2,line.Size.Y-32+orbit)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(Math.Clamp(rect.Position.X,viewport.Position.X+8,Math.Max(viewport.Position.X+8,viewport.End.X-rect.Size.X-8))-rect.Position.X,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: line.GlobalPosition+=new Vector2(Math.Clamp(rect.Position.X,viewport.Position.X+8,Math.Max(viewport.Position.X+8,viewport.End.X-rect.Size.X-8))-rect.Position.X,0)`
- `MegaCrit.Sts2.Core.Nodes.Combat.NIntent.Create(float)`；输入表达式：`NIntent.Create(i*.3f)`；返回值紧邻使用处：`AssignmentExpressionSyntax: icon=NIntent.Create(i*.3f)`
- `MegaCrit.Sts2.Core.Nodes.Combat.NIntent.UpdateIntent(MegaCrit.Sts2.Core.MonsterMoves.Intents.AbstractIntent, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`icon.UpdateIntent(hit.Doom?new DoomIntent((int)hit.Amount):new RecordedIntent((int)hit.Amount),[hit.Target],hit.Dealer)`；返回值紧邻使用处：`ExpressionStatementSyntax: icon.UpdateIntent(hit.Doom?new DoomIntent((int)hit.Amount):new RecordedIntent((int)hit.Amount),[hit.Target],hit.Dealer);`
- `MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom.GetCreatureNode(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`NCombatRoom.Instance.GetCreatureNode(creature)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =NCombatRoom.Instance.GetCreatureNode(creature)`
- `NationalSpire.LeagueNativeMatch.DoomIntent.DoomIntent(int)`；输入表达式：`new DoomIntent((int)hit.Amount)`；返回值紧邻使用处：`ConditionalExpressionSyntax: hit.Doom?new DoomIntent((int)hit.Amount):new RecordedIntent((int)hit.Amount)`
- `NationalSpire.LeagueNativeMatch.LeaguePlayer(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`LeaguePlayer(creature)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: LeaguePlayer(creature)?.PlayerCombatState?.OrbQueue.Capacity`
- `NationalSpire.LeagueNativeMatch.RecordedIntent.RecordedIntent(int)`；输入表达式：`new RecordedIntent((int)hit.Amount)`；返回值紧邻使用处：`ConditionalExpressionSyntax: hit.Doom?new DoomIntent((int)hit.Amount):new RecordedIntent((int)hit.Amount)`
- `NationalSpire.LeagueNativeMatch.ShowTeamIntent(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Nodes.Combat.NCreature)`；输入表达式：`ShowTeamIntent(creature,node)`；返回值紧邻使用处：`ExpressionStatementSyntax: ShowTeamIntent(creature,node);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`hits.Any(h=>h.Doom)`；返回值紧邻使用处：`ConditionalExpressionSyntax: hits.Any(h=>h.Doom)?$"（伤害 {hits.Where(h=>!h.Doom).Sum(h=>(int)h.Amount)} · 灾厄 {hits.Where(h=>h.Doom).Sum(h=>(int)h.Amount)}）":$"（{hits.Sum(h=>(int)h.Amount)}）"`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`Fighters.Select(f=>f.Rival.Creature).Concat(_run!.Players.Select(p=>p.Creature))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var creature in Fighters.Select(f=>f.Rival.Creature).Concat(_run!.Players.Select(p=>p.Creature))){              var node=NCombatRoom.Instance.GetCreatureNode(creature);if(node==null)continue;              bool team=_run.Players.Count>1;if(team)ShowTeamIntent(creature,node);              var line=node.GetNodeOrNull<GridContainer>("LeagueAttackOrder");              if(line==null){line=new(){Name="LeagueAttackOrder",Columns=team?3:6,MouseFilter=Control.MouseFilterEnum.Ignore};                  line.AddThemeConstantOverride("h_separation",3);line.AddThemeConstantOverride("v_separation",2);node.AddChild(line);}              var hits=Current.Pending.Where(h=>h.Dealer==creature||h.Dealer.PetOwner?.Creature==creature).ToArray();              var sum=line.GetNodeOrNull<Label>("Total");              if(sum==null){sum=new Label{Name="Total",VerticalAlignment=VerticalAlignment.Center,MouseFilter=Control.MouseFilterEnum.Ignore};                  sum.AddThemeFontSizeOverride("font_size",26);sum.AddThemeConstantOverride("outline_size",6);line.AddChild(sum);}              int shown=line.GetChildCount()-1;              while(shown>hits.Length){var old=line.GetChild(--shown);line.RemoveChild(old);old.QueueFree();}              for(int i=0;i<hits.Length;i++){                  NIntent icon;                  if(i<shown)icon=line.GetChild<NIntent>(i);                  else{icon=NIntent.Create(i*.3f);line.AddChild(icon);line.MoveChild(icon,i);}                  var hit=hits[i];icon.UpdateIntent(hit.Doom?new DoomIntent((int)hit.Amount):new RecordedIntent((int)hit.Amount),[hit.Target],hit.Dealer);              }              sum.Text=hits.Any(h=>h.Doom)?$"（伤害 {hits.Where(h=>!h.Doom).Sum(h=>(int)h.Amount)} · 灾厄 {hits.Where(h=>h.Doom).Sum(h=>(int)h.Amount)}）":$"（{hits.Sum(h=>(int)h.Amount)}）";sum.Visible=!team;line.Visible=hits.Length>0;              line.ResetSize();var anchor=node.IntentContainer;              float orbit=LeaguePlayer(creature)?.PlayerCombatState?.OrbQueue.Capacity>0?106:0;              line.Position=anchor.Position+anchor.Size*.5f-new Vector2(line.Size.X/2,line.Size.Y-32+orbit);              if(team){var viewport=node.GetViewportRect();var rect=line.GetGlobalRect();line.GlobalPosition+=new Vector2(Math.Clamp(rect.Position.X,viewport.Position.X+8,Math.Max(viewport.Position.X+8,viewport.End.X-rect.Size.X-8))-rect.Position.X,0);}            }`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`_run!.Players.Select(p=>p.Creature)`；返回值紧邻使用处：`ArgumentSyntax: _run!.Players.Select(p=>p.Creature)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Fighters.Select(f=>f.Rival.Creature)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Fighters.Select(f=>f.Rival.Creature).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`hits.Sum(h=>(int)h.Amount)`；返回值紧邻使用处：`InterpolationSyntax: {hits.Sum(h=>(int)h.Amount)}`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`hits.Where(h=>!h.Doom).Sum(h=>(int)h.Amount)`；返回值紧邻使用处：`InterpolationSyntax: {hits.Where(h=>!h.Doom).Sum(h=>(int)h.Amount)}`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`hits.Where(h=>h.Doom).Sum(h=>(int)h.Amount)`；返回值紧邻使用处：`InterpolationSyntax: {hits.Where(h=>h.Doom).Sum(h=>(int)h.Amount)}`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Current.Pending.Where(h=>h.Dealer==creature||h.Dealer.PetOwner?.Creature==creature).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Current.Pending.Where(h=>h.Dealer==creature||h.Dealer.PetOwner?.Creature==creature).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Current.Pending.Where(h=>h.Dealer==creature||h.Dealer.PetOwner?.Creature==creature)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Current.Pending.Where(h=>h.Dealer==creature||h.Dealer.PetOwner?.Creature==creature).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`hits.Where(h=>!h.Doom)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: hits.Where(h=>!h.Doom).Sum`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`hits.Where(h=>h.Doom)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: hits.Where(h=>h.Doom).Sum`
- `System.Math.Clamp(float, float, float)`；输入表达式：`Math.Clamp(rect.Position.X,viewport.Position.X+8,Math.Max(viewport.Position.X+8,viewport.End.X-rect.Size.X-8))`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Clamp(rect.Position.X,viewport.Position.X+8,Math.Max(viewport.Position.X+8,viewport.End.X-rect.Size.X-8))-rect.Position.X`
- `System.Math.Max(float, float)`；输入表达式：`Math.Max(viewport.Position.X+8,viewport.End.X-rect.Size.X-8)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(viewport.Position.X+8,viewport.End.X-rect.Size.X-8)`

**赋值（含属性/字段和局部值）：**

- `Columns` = `team?3:6`
- `icon` = `line.GetChild<NIntent>(i)`
- `icon` = `NIntent.Create(i*.3f)`
- `line.GlobalPosition` += `new Vector2(Math.Clamp(rect.Position.X,viewport.Position.X+8,Math.Max(viewport.Position.X+8,viewport.End.X-rect.Size.X-8))-rect.Position.X,0)`
- `line.Position` = `anchor.Position+anchor.Size*.5f-new Vector2(line.Size.X/2,line.Size.Y-32+orbit)`
- `line.Visible` = `hits.Length>0`
- `line` = `new(){Name="LeagueAttackOrder",Columns=team?3:6,MouseFilter=Control.MouseFilterEnum.Ignore}`
- `MouseFilter` = `Control.MouseFilterEnum.Ignore`
- `Name` = `"LeagueAttackOrder"`
- `Name` = `"Total"`
- `sum.Text` = `hits.Any(h=>h.Doom)?$"（伤害 {hits.Where(h=>!h.Doom).Sum(h=>(int)h.Amount)} · 灾厄 {hits.Where(h=>h.Doom).Sum(h=>(int)h.Amount)}）":$"（{hits.Sum(h=>(int)h.Amount)}）"`
- `sum.Visible` = `!team`
- `sum` = `new Label{Name="Total",VerticalAlignment=VerticalAlignment.Center,MouseFilter=Control.MouseFilterEnum.Ignore}`
- `VerticalAlignment` = `VerticalAlignment.Center`

<a id="symbol-50df0eb4b7be"></a>

## `NationalSpire.LeagueNativeMatch.ShowTeamIntent(MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Nodes.Combat.NCreature) — private static void ShowTeamIntent(Creature target,NCreature node)`

来源：源码第 219 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.Refresh(NationalSpire.LeagueOpponent)`](LeagueNativeMatch.cs.md#symbol-5fb078947d8b)

**调用：** [`NationalSpire.AvatarImages.Read(NationalSpire.PlayerAvatar?)`](AvatarImages.cs.md#symbol-1edd50772202)；[`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-cd3d95caefab)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`](ArchitectFinal.cs.md#symbol-943fdb98d018)；[`NationalSpire.LeagueNativeMatch.TargetName(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`](ArchitectFinal.cs.md#symbol-bf4f2e6056f3)；`Godot.CanvasItem.Hide()`；`Godot.CanvasItem.Show()`；`Godot.Color.Color(string)`；`Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.Control.ResetSize()`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Label.Label()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChild(int, bool)`；`Godot.Node.GetChild<T>(int, bool)`；`Godot.Node.GetNodeOrNull<T>(Godot.NodePath)`；`Godot.PanelContainer.PanelContainer()`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；`NationalSpire.CareerAvatar.CareerAvatar()`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.IndexOf(T)`

**字段、属性、事件及方法组引用：** `(MegaCrit.Sts2.Core.Entities.Creatures.Creature Dealer, MegaCrit.Sts2.Core.Entities.Creatures.Creature Target).Dealer`；`(MegaCrit.Sts2.Core.Entities.Creatures.Creature Dealer, MegaCrit.Sts2.Core.Entities.Creatures.Creature Target).Target`；`NationalSpire.AvatarImages.Read(NationalSpire.PlayerAvatar?)`；`NationalSpire.CareerAvatar.Art`；`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopMember.Avatar`；`NationalSpire.Coop.CoopMember.Name`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopRun.Opponents`；`NationalSpire.Coop.CoopRuntime.Current`；`NationalSpire.Coop.CoopRuntime.Session`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.LeagueDuel.Hit.Amount`；`NationalSpire.LeagueDuel.Hit.Dealer`；`NationalSpire.LeagueDuel.Hit.Doom`；`NationalSpire.LeagueDuel.Hit.Target`；`NationalSpire.LeagueDuel.Pending`；`NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；`NationalSpire.LeagueNativeMatch.TargetName(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`NationalSpire.LeagueNativeMatch.Team`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`.Hide()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: badge?.Hide()`
- `Godot.CanvasItem.Show()`；输入表达式：`badge.Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: badge.Show();`
- `Godot.Color.Color(string)`；输入表达式：`new Color("ffc082")`；返回值紧邻使用处：`ArgumentSyntax: new Color("ffc082")`
- `Godot.Control.AddThemeColorOverride(Godot.StringName, Godot.Color)`；输入表达式：`total.AddThemeColorOverride("font_color",new Color("ffc082"))`；返回值紧邻使用处：`ExpressionStatementSyntax: total.AddThemeColorOverride("font_color",new Color("ffc082"));`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`col.AddThemeConstantOverride("separation",0)`；返回值紧邻使用处：`ExpressionStatementSyntax: col.AddThemeConstantOverride("separation",0);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation",5)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation",5);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`total.AddThemeFontSizeOverride("font_size",21)`；返回值紧邻使用处：`ExpressionStatementSyntax: total.AddThemeFontSizeOverride("font_size",21);`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`who.AddThemeFontSizeOverride("font_size",15)`；返回值紧邻使用处：`ExpressionStatementSyntax: who.AddThemeFontSizeOverride("font_size",15);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`badge.AddThemeStyleboxOverride("panel",CareerVisuals.Box("14232df0",local?"78d9cd":"967e60",8,1))`；返回值紧邻使用处：`ExpressionStatementSyntax: badge.AddThemeStyleboxOverride("panel",CareerVisuals.Box("14232df0",local?"78d9cd":"967e60",8,1));`
- `Godot.Control.ResetSize()`；输入表达式：`badge.ResetSize()`；返回值紧邻使用处：`ExpressionStatementSyntax: badge.ResetSize();`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer()`
- `Godot.Label.Label()`；输入表达式：`new Label{Name="IncomingTotal"}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Label{Name="IncomingTotal"}`
- `Godot.Label.Label()`；输入表达式：`new Label{Text=(local?"你 · ":"")+(member?.Name??TargetName(target)),CustomMinimumSize=new(104,0),TextOverrunBehavior=TextServer.OverrunBehavior.TrimEllipsis}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Label{Text=(local?"你 · ":"")+(member?.Name??TargetName(target)),CustomMinimumSize=new(104,0),TextOverrunBehavior=TextServer.OverrunBehavior.TrimEllipsis}`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`badge.AddChild(row)`；返回值紧邻使用处：`ExpressionStatementSyntax: badge.AddChild(row);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`col.AddChild(total)`；返回值紧邻使用处：`ExpressionStatementSyntax: col.AddChild(total);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`col.AddChild(who)`；返回值紧邻使用处：`ExpressionStatementSyntax: col.AddChild(who);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`node.AddChild(badge)`；返回值紧邻使用处：`ExpressionStatementSyntax: node.AddChild(badge);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(col)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(col);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(new CareerAvatar{Art=art,CustomMinimumSize=new(38,38),MouseFilter=Control.MouseFilterEnum.Ignore})`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(new CareerAvatar{Art=art,CustomMinimumSize=new(38,38),MouseFilter=Control.MouseFilterEnum.Ignore});`
- `Godot.Node.GetChild(int, bool)`；输入表达式：`badge.GetChild(0).GetChild(1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: badge.GetChild(0).GetChild(1).GetChild<Label>`
- `Godot.Node.GetChild(int, bool)`；输入表达式：`badge.GetChild(0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: badge.GetChild(0).GetChild`
- `Godot.Node.GetChild<T>(int, bool)`；输入表达式：`badge.GetChild(0).GetChild(1).GetChild<Label>(1)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =badge.GetChild(0).GetChild(1).GetChild<Label>(1)`
- `Godot.Node.GetNodeOrNull<T>(Godot.NodePath)`；输入表达式：`node.GetNodeOrNull<PanelContainer>("LeagueIncoming")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =node.GetNodeOrNull<PanelContainer>("LeagueIncoming")`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer{Name="LeagueIncoming",MouseFilter=Control.MouseFilterEnum.Stop}`；返回值紧邻使用处：`AssignmentExpressionSyntax: badge=new PanelContainer{Name="LeagueIncoming",MouseFilter=Control.MouseFilterEnum.Stop}`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer()`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(-badge.Size.X/2,42)`；返回值紧邻使用处：`AssignmentExpressionSyntax: badge.Position=new(-badge.Size.X/2,42)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(104,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(104,0)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(38,38)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize=new(38,38)`
- `NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；输入表达式：`new AvatarArt(fighter?.Rival.Character.IconTexture,CareerVisuals.Teal,TargetName(target))`；返回值紧邻使用处：`ConditionalExpressionSyntax: index>=0&&world.Run!=null&&index<world.Run.Opponents.Count?CareerAvatars.ForPerson(world.World,world.Run.Opponents[index]):                  new AvatarArt(fighter?.Rival.Character.IconTexture,CareerVisuals.Teal,TargetName(target))`
- `NationalSpire.AvatarArt.AvatarArt(Godot.Texture2D?, Godot.Color, string)`；输入表达式：`new AvatarArt(target.Player!.Character.IconTexture,CareerVisuals.Teal,member.Name)`；返回值紧邻使用处：`BinaryExpressionSyntax: AvatarImages.Read(member.Avatar)??new AvatarArt(target.Player!.Character.IconTexture,CareerVisuals.Teal,member.Name)`
- `NationalSpire.AvatarImages.Read(NationalSpire.PlayerAvatar?)`；输入表达式：`AvatarImages.Read(member.Avatar)`；返回值紧邻使用处：`BinaryExpressionSyntax: AvatarImages.Read(member.Avatar)??new AvatarArt(target.Player!.Character.IconTexture,CareerVisuals.Teal,member.Name)`
- `NationalSpire.CareerAvatar.CareerAvatar()`；输入表达式：`new CareerAvatar{Art=art,CustomMinimumSize=new(38,38),MouseFilter=Control.MouseFilterEnum.Ignore}`；返回值紧邻使用处：`ArgumentSyntax: new CareerAvatar{Art=art,CustomMinimumSize=new(38,38),MouseFilter=Control.MouseFilterEnum.Ignore}`
- `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.ForPerson(world.World,world.Run.Opponents[index])`；返回值紧邻使用处：`ConditionalExpressionSyntax: index>=0&&world.Run!=null&&index<world.Run.Opponents.Count?CareerAvatars.ForPerson(world.World,world.Run.Opponents[index]):                  new AvatarArt(fighter?.Rival.Character.IconTexture,CareerVisuals.Teal,TargetName(target))`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("14232df0",local?"78d9cd":"967e60",8,1)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("14232df0",local?"78d9cd":"967e60",8,1)`
- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`For(target)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =For(target)`
- `NationalSpire.LeagueNativeMatch.TargetName(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`TargetName(g.Key.Dealer)`；返回值紧邻使用处：`BinaryExpressionSyntax: TargetName(g.Key.Dealer)+" → "`
- `NationalSpire.LeagueNativeMatch.TargetName(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`TargetName(g.Key.Target)`；返回值紧邻使用处：`BinaryExpressionSyntax: TargetName(g.Key.Dealer)+" → "+TargetName(g.Key.Target)`
- `NationalSpire.LeagueNativeMatch.TargetName(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`TargetName(target)`；返回值紧邻使用处：`ArgumentSyntax: TargetName(target)`
- `NationalSpire.LeagueNativeMatch.TargetName(MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`TargetName(target)`；返回值紧邻使用处：`BinaryExpressionSyntax: member?.Name??TargetName(target)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join(" + ",g.Select(h=>(h.Doom?"灾厄 ":"")+(int)h.Amount))`；返回值紧邻使用处：`BinaryExpressionSyntax: TargetName(g.Key.Dealer)+" → "+TargetName(g.Key.Target)+"  "+string.Join(" + ",g.Select(h=>(h.Doom?"灾厄 ":"")+(int)h.Amount))`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n",hits.GroupBy(h=>(h.Dealer,h.Target)).Select(g=>TargetName(g.Key.Dealer)+" → "+TargetName(g.Key.Target)+"  "+string.Join(" + ",g.Select(h=>(h.Doom?"灾厄 ":"")+(int)h.Amount))))`；返回值紧邻使用处：`AssignmentExpressionSyntax: badge.TooltipText=string.Join("\n",hits.GroupBy(h=>(h.Dealer,h.Target)).Select(g=>TargetName(g.Key.Dealer)+" → "+TargetName(g.Key.Target)+"  "+string.Join(" + ",g.Select(h=>(h.Doom?"灾厄 ":"")+(int)h.Amount))))`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`world.Members.FirstOrDefault(m=>m.SteamId==target.Player?.NetId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =world.Members.FirstOrDefault(m=>m.SteamId==target.Player?.NetId)`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`hits.GroupBy(h=>(h.Dealer,h.Target))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: hits.GroupBy(h=>(h.Dealer,h.Target)).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`g.Select(h=>(h.Doom?"灾厄 ":"")+(int)h.Amount)`；返回值紧邻使用处：`ArgumentSyntax: g.Select(h=>(h.Doom?"灾厄 ":"")+(int)h.Amount)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`hits.GroupBy(h=>(h.Dealer,h.Target)).Select(g=>TargetName(g.Key.Dealer)+" → "+TargetName(g.Key.Target)+"  "+string.Join(" + ",g.Select(h=>(h.Doom?"灾厄 ":"")+(int)h.Amount)))`；返回值紧邻使用处：`ArgumentSyntax: hits.GroupBy(h=>(h.Dealer,h.Target)).Select(g=>TargetName(g.Key.Dealer)+" → "+TargetName(g.Key.Target)+"  "+string.Join(" + ",g.Select(h=>(h.Doom?"灾厄 ":"")+(int)h.Amount)))`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`hits.Where(h=>!h.Doom&&h.Target==target).Sum(h=>(int)h.Amount)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =hits.Where(h=>!h.Doom&&h.Target==target).Sum(h=>(int)h.Amount)`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`hits.Where(h=>h.Doom&&h.Target==target).Sum(h=>(int)h.Amount)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =hits.Where(h=>h.Doom&&h.Target==target).Sum(h=>(int)h.Amount)`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`hits.Where(h=>h.Target!=target).Sum(h=>(int)h.Amount)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =hits.Where(h=>h.Target!=target).Sum(h=>(int)h.Amount)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Current!.Pending.Where(h=>h.Target==target||h.Target.PetOwner?.Creature==target).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Current!.Pending.Where(h=>h.Target==target||h.Target.PetOwner?.Creature==target).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Current!.Pending.Where(h=>h.Target==target||h.Target.PetOwner?.Creature==target)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Current!.Pending.Where(h=>h.Target==target||h.Target.PetOwner?.Creature==target).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`hits.Where(h=>!h.Doom&&h.Target==target)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: hits.Where(h=>!h.Doom&&h.Target==target).Sum`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`hits.Where(h=>h.Doom&&h.Target==target)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: hits.Where(h=>h.Doom&&h.Target==target).Sum`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`hits.Where(h=>h.Target!=target)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: hits.Where(h=>h.Target!=target).Sum`
- `System.Collections.Generic.List<T>.IndexOf(T)`；输入表达式：`Team.IndexOf(fighter)`；返回值紧邻使用处：`ConditionalExpressionSyntax: fighter==null?-1:Team.IndexOf(fighter)`

**赋值（含属性/字段和局部值）：**

- `Art` = `art`
- `badge.Position` = `new(-badge.Size.X/2,42)`
- `badge.TooltipText` = `string.Join("\n",hits.GroupBy(h=>(h.Dealer,h.Target)).Select(g=>TargetName(g.Key.Dealer)+" → "+TargetName(g.Key.Target)+"  "+string.Join(" + ",g.Select(h=>(h.Doom?"灾厄 ":"")+(int)h.Amount))))`
- `badge` = `new PanelContainer{Name="LeagueIncoming",MouseFilter=Control.MouseFilterEnum.Stop}`
- `CustomMinimumSize` = `new(104,0)`
- `CustomMinimumSize` = `new(38,38)`
- `MouseFilter` = `Control.MouseFilterEnum.Ignore`
- `MouseFilter` = `Control.MouseFilterEnum.Stop`
- `Name` = `"IncomingTotal"`
- `Name` = `"LeagueIncoming"`
- `Text` = `(local?"你 · ":"")+(member?.Name??TargetName(target))`
- `TextOverrunBehavior` = `TextServer.OverrunBehavior.TrimEllipsis`
- `value.Text` = `"来袭 "+damage+(doom>0?"  灾厄 "+doom:"")+(pet>0?"  随从 "+pet:"")`

<a id="symbol-7c563df50ffb"></a>

## `NationalSpire.LeagueNativeMatch.DoomIntent.GetTexture(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>, MegaCrit.Sts2.Core.Entities.Creatures.Creature) — public override Texture2D GetTexture(IEnumerable<Creature> targets,Creature owner)`

来源：源码第 249 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `MegaCrit.Sts2.Core.Models.ModelDb.Power<T>()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.ModelDb.Power<T>()`；输入表达式：`ModelDb.Power<MegaCrit.Sts2.Core.Models.Powers.DoomPower>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ModelDb.Power<MegaCrit.Sts2.Core.Models.Powers.DoomPower>().Icon`

**赋值（含属性/字段和局部值）：**


<a id="symbol-31633dad207e"></a>

## `NationalSpire.LeagueNativeMatch.RecordedIntent.GetTotalDamage(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>, MegaCrit.Sts2.Core.Entities.Creatures.Creature) — public override int GetTotalDamage(IEnumerable<Creature> targets,Creature owner)`

来源：源码第 252 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Func<TResult>.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Func<TResult>.Invoke()`；输入表达式：`DamageCalc!()`；返回值紧邻使用处：`CastExpressionSyntax: (int)DamageCalc!()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f9884d853b57"></a>

## `NationalSpire.LeagueNativeMatch.Ended(MegaCrit.Sts2.Core.Rooms.CombatRoom) — private static void Ended(CombatRoom room)`

来源：源码第 254 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.Return(string?, bool?)`](LeagueNativeMatch.cs.md#symbol-1b324a0cbccb)；`Godot.Callable.CallDeferred(params Godot.Variant[])`；`Godot.Callable.From(System.Action)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch._returning`；`NationalSpire.LeagueNativeMatch._room`；`NationalSpire.LeagueNativeMatch._run`；`NationalSpire.LeagueNativeMatch.Return(string?, bool?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Callable.CallDeferred(params Godot.Variant[])`；输入表达式：`Callable.From(()=>{_=Return(won?"对决胜利":"对决结束 · 惜败",won);}).CallDeferred()`；返回值紧邻使用处：`ExpressionStatementSyntax: Callable.From(()=>{_=Return(won?"对决胜利":"对决结束 · 惜败",won);}).CallDeferred();`
- `Godot.Callable.From(System.Action)`；输入表达式：`Callable.From(()=>{_=Return(won?"对决胜利":"对决结束 · 惜败",won);})`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Callable.From(()=>{_=Return(won?"对决胜利":"对决结束 · 惜败",won);}).CallDeferred`
- `NationalSpire.LeagueNativeMatch.Return(string?, bool?)`；输入表达式：`Return(won?"对决胜利":"对决结束 · 惜败",won)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _=Return(won?"对决胜利":"对决结束 · 惜败",won)`

**赋值（含属性/字段和局部值）：**

- `_` = `Return(won?"对决胜利":"对决结束 · 惜败",won)`
- `_returning` = `true`

<a id="symbol-242512cbc319"></a>

## `NationalSpire.LeagueNativeMatch.Release() — private static void Release()`

来源：源码第 255 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Begin()`](LeagueTeamMatch.cs.md#symbol-7113ab57a2bd)；[`NationalSpire.LeagueNativeMatch.EndTeam(bool)`](LeagueTeamMatch.cs.md#symbol-20c50965f995)；[`NationalSpire.LeagueNativeMatch.FinishFinal(bool?)`](ArchitectFinal.cs.md#symbol-eb8d4b32d343)；[`NationalSpire.LeagueNativeMatch.OnAdventureExit()`](ArchitectFinal.cs.md#symbol-86926a42c207)；[`NationalSpire.LeagueNativeMatch.Return(string?, bool?)`](LeagueNativeMatch.cs.md#symbol-1b324a0cbccb)；[`NationalSpire.LeagueNativeMatch.Start(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], int, NationalSpire.ICareerSession?, string, int, System.Collections.Generic.IReadOnlyDictionary<string, int>?, System.Collections.Generic.Dictionary<string, int>?, int, string?)`](LeagueNativeMatch.cs.md#symbol-5db2520de882)

**调用：** [`NationalSpire.LeagueNativeMatch.RemoveBattlePatches(HarmonyLib.Harmony)`](LeagueNativeMatch.cs.md#symbol-38de57ce7505)；`MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.AfterCombatEnd()`；`System.Collections.Generic.HashSet<T>.Clear()`；`System.Collections.Generic.List<T>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueNativeMatch._exit`；`NationalSpire.LeagueNativeMatch._exitDialog`；`NationalSpire.LeagueNativeMatch._installed`；`NationalSpire.LeagueNativeMatch._leagueHarmony`；`NationalSpire.LeagueNativeMatch._room`；`NationalSpire.LeagueNativeMatch._run`；`NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.Ended(MegaCrit.Sts2.Core.Rooms.CombatRoom)`；`NationalSpire.LeagueNativeMatch.Fighters`；`NationalSpire.LeagueNativeMatch.Opened`；`NationalSpire.LeagueNativeMatch.PlayerTurn(MegaCrit.Sts2.Core.Combat.CombatState)`；`NationalSpire.LeagueNativeMatch.RemoveBattlePatches(HarmonyLib.Harmony)`；`NationalSpire.LeagueNativeMatch.Team`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState.AfterCombatEnd()`；输入表达式：`.AfterCombatEnd()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: f.Rival.PlayerCombatState?.AfterCombatEnd()`
- `NationalSpire.LeagueNativeMatch.RemoveBattlePatches(HarmonyLib.Harmony)`；输入表达式：`RemoveBattlePatches(_leagueHarmony)`；返回值紧邻使用处：`ExpressionStatementSyntax: RemoveBattlePatches(_leagueHarmony);`
- `System.Collections.Generic.HashSet<T>.Clear()`；输入表达式：`Opened.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: Opened.Clear();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`Team.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: Team.Clear();`

**赋值（含属性/字段和局部值）：**

- `_exit` = `null`
- `_exitDialog` = `null`
- `_room` = `null`
- `_run` = `null`
- `CombatManager.Instance.CombatEnded` -= `Ended`
- `CombatManager.Instance.TurnStarted` -= `PlayerTurn`
- `Current` = `null`

<a id="symbol-1b324a0cbccb"></a>

## `NationalSpire.LeagueNativeMatch.Return(string?, bool?) — private static async Task Return(string? result,bool? won=null)`

来源：源码第 259 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.Ended(MegaCrit.Sts2.Core.Rooms.CombatRoom)`](LeagueNativeMatch.cs.md#symbol-f9884d853b57)；[`NationalSpire.LeagueNativeMatch.InstallExit(MegaCrit.Sts2.Core.Nodes.NRun)`](LeagueNativeMatch.cs.md#symbol-c7bf6cbb732d)；[`NationalSpire.LeagueNativeMatch.Start(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Models.CardModel[], int, NationalSpire.ICareerSession?, string, int, System.Collections.Generic.IReadOnlyDictionary<string, int>?, System.Collections.Generic.Dictionary<string, int>?, int, string?)`](LeagueNativeMatch.cs.md#symbol-5db2520de882)

**调用：** [`NationalSpire.CareerScreen.OpenLeagueResult(Godot.Control, NationalSpire.ICareerSession?, string, bool?, NationalSpire.LeagueFinish?)`](LeagueNativeMatch.cs.md#symbol-c1cb4b5f9df0)；[`NationalSpire.LeagueNativeMatch.Release()`](LeagueNativeMatch.cs.md#symbol-242512cbc319)；`MegaCrit.Sts2.Core.Nodes.NGame.ReturnToMainMenu()`；`MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；`NationalSpire.LeagueFinish.LeagueFinish(string, string, int)`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.OpenLeagueResult(Godot.Control, NationalSpire.ICareerSession?, string, bool?, NationalSpire.LeagueFinish?)`；`NationalSpire.LeagueDuel.OpponentName`；`NationalSpire.LeagueDuel.Tier`；`NationalSpire.LeagueNativeMatch._returning`；`NationalSpire.LeagueNativeMatch._run`；`NationalSpire.LeagueNativeMatch._session`；`NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueNativeMatch.Release()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Nodes.NGame.ReturnToMainMenu()`；输入表达式：`game.ReturnToMainMenu()`；返回值紧邻使用处：`AwaitExpressionSyntax: await game.ReturnToMainMenu()`
- `MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；输入表达式：`RunManager.Instance.DebugOnlyGetState()`；返回值紧邻使用处：`BinaryExpressionSyntax: RunManager.Instance.DebugOnlyGetState()==_run`
- `NationalSpire.CareerScreen.OpenLeagueResult(Godot.Control, NationalSpire.ICareerSession?, string, bool?, NationalSpire.LeagueFinish?)`；输入表达式：`CareerScreen.OpenLeagueResult(menu,session,result,won,finish)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerScreen.OpenLeagueResult(menu,session,result,won,finish);`
- `NationalSpire.LeagueFinish.LeagueFinish(string, string, int)`；输入表达式：`new LeagueFinish(Guid.NewGuid().ToString("N"),d.OpponentName,d.Tier)`；返回值紧邻使用处：`ConditionalExpressionSyntax: won.HasValue&&Current is {} d?new LeagueFinish(Guid.NewGuid().ToString("N"),d.OpponentName,d.Tier):null`
- `NationalSpire.LeagueNativeMatch.Release()`；输入表达式：`Release()`；返回值紧邻使用处：`ExpressionStatementSyntax: Release();`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`ArgumentSyntax: Guid.NewGuid().ToString("N")`

**赋值（含属性/字段和局部值）：**

- `_returning` = `true`
- `_session` = `null`

<a id="symbol-9b19159d440f"></a>

## `NationalSpire.LeagueEncounter.RoomType — public override RoomType RoomType`

来源：源码第 269 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-25de8b29c6aa"></a>

## `NationalSpire.LeagueEncounter.ShouldGiveRewards — public override bool ShouldGiveRewards`

来源：源码第 270 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-27d9bf3126a8"></a>

## `NationalSpire.LeagueEncounter.AllPossibleMonsters — public override IEnumerable<MonsterModel> AllPossibleMonsters`

来源：源码第 271 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `MegaCrit.Sts2.Core.Models.ModelDb.Monster<T>()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.ModelDb.Monster<T>()`；输入表达式：`ModelDb.Monster<LeagueOpponent>()`；返回值紧邻使用处：`ExpressionElementSyntax: ModelDb.Monster<LeagueOpponent>()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a892fa6c9367"></a>

## `NationalSpire.LeagueEncounter.GenerateMonsters() — protected override IReadOnlyList<(MonsterModel,string?)> GenerateMonsters()`

来源：源码第 272 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.Opponents()`](ArchitectFinal.cs.md#symbol-9cee1b48fd83)

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.Opponents()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueNativeMatch.Opponents()`；输入表达式：`LeagueNativeMatch.Opponents()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>LeagueNativeMatch.Opponents()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-283d161cc207"></a>

## `NationalSpire.LeagueOpponent.Fighter — internal LeagueDuel? Fighter`

来源：源码第 276 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7c7e51259de5"></a>

## `NationalSpire.LeagueOpponent.Role — private CharacterModel Role`

来源：源码第 277 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `MegaCrit.Sts2.Core.Models.ModelDb.Character<T>()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.Rival`；`NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueOpponent.Fighter`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.ModelDb.Character<T>()`；输入表达式：`ModelDb.Character<MegaCrit.Sts2.Core.Models.Characters.Ironclad>()`；返回值紧邻使用处：`BinaryExpressionSyntax: (Fighter??LeagueNativeMatch.Current)?.Rival.Character??ModelDb.Character<MegaCrit.Sts2.Core.Models.Characters.Ironclad>()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-61f955e46c77"></a>

## `NationalSpire.LeagueOpponent.MinInitialHp — public override int MinInitialHp`

来源：源码第 278 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueLadder.Health(MegaCrit.Sts2.Core.Models.CharacterModel, int)`](LeagueLadder.cs.md#symbol-9d40de0014e6)

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueDuel.OpeningMax`；`NationalSpire.LeagueDuel.Tier`；`NationalSpire.LeagueLadder.Health(MegaCrit.Sts2.Core.Models.CharacterModel, int)`；`NationalSpire.LeagueNativeMatch.Current`；`NationalSpire.LeagueOpponent.Fighter`；`NationalSpire.LeagueOpponent.Role`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueLadder.Health(MegaCrit.Sts2.Core.Models.CharacterModel, int)`；输入表达式：`LeagueLadder.Health(Role,LeagueNativeMatch.Current?.Tier??0)`；返回值紧邻使用处：`BinaryExpressionSyntax: Fighter?.OpeningMax??LeagueLadder.Health(Role,LeagueNativeMatch.Current?.Tier??0)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9132031bd036"></a>

## `NationalSpire.LeagueOpponent.MaxInitialHp — public override int MaxInitialHp`

来源：源码第 279 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueOpponent.MinInitialHp`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ef653a5bc2bd"></a>

## `NationalSpire.LeagueOpponent.ShouldShowInCompendium — public override bool ShouldShowInCompendium`

来源：源码第 280 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e7e3fb3e20c8"></a>

## `NationalSpire.LeagueOpponent.Title — public override LocString Title`

来源：源码第 281 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueOpponent.Role`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ee1f24b0a354"></a>

## `NationalSpire.LeagueOpponent.DeathSfx — public override string DeathSfx`

来源：源码第 282 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueOpponent.Role`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9ee8c260389b"></a>

## `NationalSpire.LeagueOpponent.VisualsPath — protected override string VisualsPath`

来源：源码第 283 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `string.ToLowerInvariant()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueOpponent.Role`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.ToLowerInvariant()`；输入表达式：`Role.Id.Entry.ToLowerInvariant()`；返回值紧邻使用处：`BinaryExpressionSyntax: "res://scenes/creature_visuals/"+Role.Id.Entry.ToLowerInvariant()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ff658a1871b3"></a>

## `NationalSpire.LeagueOpponent.GenerateAnimator(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite) — public override CreatureAnimator GenerateAnimator(MegaSprite sprite)`

来源：源码第 284 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueBattleApi.Animator(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`](LeagueBattleApi.cs.md#symbol-d9f23a519955)

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueBattleApi.Animator(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；`NationalSpire.LeagueOpponent.Role`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueBattleApi.Animator(MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite, MegaCrit.Sts2.Core.Entities.Creatures.Creature)`；输入表达式：`LeagueBattleApi.Animator(Role,sprite,Creature)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>LeagueBattleApi.Animator(Role,sprite,Creature)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-20670b475877"></a>

## `NationalSpire.LeagueOpponent.GenerateMoveStateMachine() — protected override MonsterMoveStateMachine GenerateMoveStateMachine()`

来源：源码第 285 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.Enemy(NationalSpire.LeagueOpponent)`](LeagueNativeMatch.cs.md#symbol-531731d36b7d)；`MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine.MonsterMoveStateMachine.MonsterMoveStateMachine(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine.MonsterState>, MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine.MonsterState)`；`MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine.MoveState.MoveState(string, System.Func<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature>, System.Threading.Tasks.Task>, params MegaCrit.Sts2.Core.MonsterMoves.Intents.AbstractIntent[])`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.Enemy(NationalSpire.LeagueOpponent)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine.MonsterMoveStateMachine.MonsterMoveStateMachine(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine.MonsterState>, MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine.MonsterState)`；输入表达式：`new([move],move)`；返回值紧邻使用处：`ReturnStatementSyntax: return new([move],move);`
- `MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine.MoveState.MoveState(string, System.Func<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature>, System.Threading.Tasks.Task>, params MegaCrit.Sts2.Core.MonsterMoves.Intents.AbstractIntent[])`；输入表达式：`new MoveState("LEAGUE_PLAY",_=>LeagueNativeMatch.Enemy(this))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new MoveState("LEAGUE_PLAY",_=>LeagueNativeMatch.Enemy(this))`
- `NationalSpire.LeagueNativeMatch.Enemy(NationalSpire.LeagueOpponent)`；输入表达式：`LeagueNativeMatch.Enemy(this)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _=>LeagueNativeMatch.Enemy(this)`

**赋值（含属性/字段和局部值）：**

- `move.FollowUpState` = `move`

<a id="symbol-6aafa46bf081"></a>

## `NationalSpire.LeagueOpponent.AfterAddedToRoom() — public override Task AfterAddedToRoom()`

来源：源码第 286 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.Bind(NationalSpire.LeagueOpponent)`](LeagueNativeMatch.cs.md#symbol-f78a44bdbc8e)

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.Bind(NationalSpire.LeagueOpponent)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueNativeMatch.Bind(NationalSpire.LeagueOpponent)`；输入表达式：`LeagueNativeMatch.Bind(this)`；返回值紧邻使用处：`ExpressionStatementSyntax: LeagueNativeMatch.Bind(this);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-611d7429d107"></a>

## `NationalSpire.LeagueOpponent.AfterPlayerTurnStartEarly(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Entities.Players.Player) — public override Task AfterPlayerTurnStartEarly(PlayerChoiceContext context,Player player)`

来源：源码第 287 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.First(NationalSpire.LeagueOpponent)`](LeagueNativeMatch.cs.md#symbol-2e5d42d12c6a)；[`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`](ArchitectFinal.cs.md#symbol-dfa68774ae32)

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.First(NationalSpire.LeagueOpponent)`；`NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`；`NationalSpire.LeagueNativeMatch.HumanLead`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueNativeMatch.First(NationalSpire.LeagueOpponent)`；输入表达式：`LeagueNativeMatch.First(this)`；返回值紧邻使用处：`ConditionalExpressionSyntax: player.NetId!=LeagueNativeMatch.HumanLead||LeagueNativeMatch.For(player)!=null?Task.CompletedTask:LeagueNativeMatch.First(this)`
- `NationalSpire.LeagueNativeMatch.For(MegaCrit.Sts2.Core.Entities.Players.Player?)`；输入表达式：`LeagueNativeMatch.For(player)`；返回值紧邻使用处：`BinaryExpressionSyntax: LeagueNativeMatch.For(player)!=null`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4c7f9766c6ed"></a>

## `NationalSpire.LeagueOpponent.BeforeSideTurnEndVeryEarly(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext, MegaCrit.Sts2.Core.Combat.CombatSide, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>) — public override Task BeforeSideTurnEndVeryEarly(PlayerChoiceContext context,CombatSide side,IEnumerable<Creature> participants)`

来源：源码第 288 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.LeagueNativeMatch.Resolve(MegaCrit.Sts2.Core.Combat.CombatSide)`](LeagueNativeMatch.cs.md#symbol-bea557065b97)；`object.ReferenceEquals(object?, object?)`

**字段、属性、事件及方法组引用：** `NationalSpire.LeagueNativeMatch.FirstLiving`；`NationalSpire.LeagueNativeMatch.Resolve(MegaCrit.Sts2.Core.Combat.CombatSide)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LeagueNativeMatch.Resolve(MegaCrit.Sts2.Core.Combat.CombatSide)`；输入表达式：`LeagueNativeMatch.Resolve(side)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ReferenceEquals(this,LeagueNativeMatch.FirstLiving)?LeagueNativeMatch.Resolve(side):Task.CompletedTask`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(this,LeagueNativeMatch.FirstLiving)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ReferenceEquals(this,LeagueNativeMatch.FirstLiving)?LeagueNativeMatch.Resolve(side):Task.CompletedTask`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c1cb4b5f9df0"></a>

## `NationalSpire.CareerScreen.OpenLeagueResult(Godot.Control, NationalSpire.ICareerSession?, string, bool?, NationalSpire.LeagueFinish?) — internal static void OpenLeagueResult(Control menu,ICareerSession? session,string result,bool? won,LeagueFinish? finish)`

来源：源码第 292 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.LeagueNativeMatch.Return(string?, bool?)`](LeagueNativeMatch.cs.md#symbol-1b324a0cbccb)

**调用：** [`NationalSpire.CareerScreen.LeagueAction(string, string, int, Godot.Control?)`](LeagueScreen.cs.md#symbol-c5858ab8fb69)；[`NationalSpire.CareerScreen.LeagueGo(string)`](LeagueScreen.cs.md#symbol-46069e214cbd)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?)`](CareerScreen.cs.md#symbol-2b6ef58a9693)；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Current`；`NationalSpire.CareerScreen.LeagueAction(string, string, int, Godot.Control?)`；`NationalSpire.CareerScreen.LeagueGo(string)`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.LeagueAction(string, string, int, Godot.Control?)`；输入表达式：`screen.LeagueAction("result",System.Text.Json.JsonSerializer.Serialize(finish),won.Value?1:0)`；返回值紧邻使用处：`ExpressionStatementSyntax: screen.LeagueAction("result",System.Text.Json.JsonSerializer.Serialize(finish),won.Value?1:0);`
- `NationalSpire.CareerScreen.LeagueGo(string)`；输入表达式：`screen.LeagueGo("对战")`；返回值紧邻使用处：`ExpressionStatementSyntax: screen.LeagueGo("对战");`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`screen.Notice(result,false)`；返回值紧邻使用处：`ExpressionStatementSyntax: screen.Notice(result,false);`
- `NationalSpire.CareerScreen.OpenView(Godot.Control, NationalSpire.ICareerSession?, string?)`；输入表达式：`OpenView(menu,session,"生涯生活")`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenView(menu,session,"生涯生活");`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`System.Text.Json.JsonSerializer.Serialize(finish)`；返回值紧邻使用处：`ArgumentSyntax: System.Text.Json.JsonSerializer.Serialize(finish)`

**赋值（含属性/字段和局部值）：**
