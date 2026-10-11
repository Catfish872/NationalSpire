# GameBridge.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`4C7D437B5131C9A9CA71FF6C50C1A86CB2097CFDD1DFDCDAA51FB6EBB5F25CF8`。来源：[源码](../../GameBridge.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.GameBridge`、`NationalSpire.MenuPatch`、`NationalSpire.HistoryPatch`、`NationalSpire.CareerContextPatch`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-1f9959a59e6d"></a>

## `NationalSpire.GameBridge.NativeCareerPath — public static string NativeCareerPath`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerStore.NativeRunPath`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6b85087ac133"></a>

## `NationalSpire.GameBridge.RecoveryMessageFor(bool) — public static string RecoveryMessageFor(bool multiplayer)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)

**调用：** [`NationalSpire.MatchRecovery.Message(bool, bool, bool)`](MatchRecovery.cs.md#symbol-b40088da85fc)

**字段、属性、事件及方法组引用：** `NationalSpire.MatchRecovery.Message(bool, bool, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MatchRecovery.Message(bool, bool, bool)`；输入表达式：`MatchRecovery.Message(false, SaveManager.Instance.HasRunSave, RunManager.Instance.IsInProgress)`；返回值紧邻使用处：`ConditionalExpressionSyntax: multiplayer          ? MatchRecovery.Message(true, false, false)          : MatchRecovery.Message(false, SaveManager.Instance.HasRunSave, RunManager.Instance.IsInProgress)`
- `NationalSpire.MatchRecovery.Message(bool, bool, bool)`；输入表达式：`MatchRecovery.Message(true, false, false)`；返回值紧邻使用处：`ConditionalExpressionSyntax: multiplayer          ? MatchRecovery.Message(true, false, false)          : MatchRecovery.Message(false, SaveManager.Instance.HasRunSave, RunManager.Instance.IsInProgress)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-55db73ec0b74"></a>

## `NationalSpire.GameBridge.CanReleaseMissingRun — public static bool CanReleaseMissingRun`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1233494dda40"></a>

## `NationalSpire.GameBridge.Characters() — public static List<CharacterModel> Characters()`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AvatarAssets.LoadCard(string, string)`](AvatarAssets.cs.md#symbol-5b05259c8c83)；[`NationalSpire.AvatarAssets.ResolveCharacter(string)`](AvatarAssets.cs.md#symbol-4587b5cfa519)；[`NationalSpire.AvatarSources.Characters()`](AvatarSources.cs.md#symbol-6c772247bc69)；[`NationalSpire.CareerAvatars.MainCharacter(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-b9f8261f2cf2)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`](ProfileScreen.cs.md#symbol-ce70d1ef24b8)；[`NationalSpire.CareerScreen.ResolveFailure(string)`](FailureScreen.cs.md#symbol-64d5a395c405)；[`NationalSpire.Coop.CoopCareerSession.Team`](Coop/CoopCareerSession.cs.md#symbol-cbe9a2f65cf3)；[`NationalSpire.Coop.CoopLive.Update()`](Coop/CoopLive.cs.md#symbol-fe745d15ee63)；[`NationalSpire.Coop.CoopNativeRun.Character()`](Coop/CoopNativeRun.cs.md#symbol-5f0977f165e0)；[`NationalSpire.Coop.CoopRuntime.Connect(bool, string, string, int, string, string, string)`](Coop/CoopRuntime.cs.md#symbol-5c58a004498a)；[`NationalSpire.Coop.CoopScreen.WaitingRoom(NationalSpire.Coop.CoopWorld)`](Coop/CoopScreen.cs.md#symbol-b46abec89d85)；[`NationalSpire.Entry.Init()`](Entry.cs.md#symbol-f4f7468c39e8)；[`NationalSpire.LiveRunBridge.EnsurePlan()`](LiveRunBridge.cs.md#symbol-0dd1ac28e6cd)；[`Side(bool)`](BroadcastVisuals.cs.md#symbol-bd78011edf05)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`ModelDb.AllCharacters.Where(c => c is not RandomCharacter).ToList()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ModelDb.AllCharacters.Where(c => c is not RandomCharacter).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`ModelDb.AllCharacters.Where(c => c is not RandomCharacter)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ModelDb.AllCharacters.Where(c => c is not RandomCharacter).ToList`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e436ec882e7b"></a>

## `NationalSpire.GameBridge.RandomChoice() — public static CharacterModel RandomChoice()`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerScreen.ResolveFailure(string)`](FailureScreen.cs.md#symbol-64d5a395c405)；[`NationalSpire.Coop.CoopNativeRun.Character()`](Coop/CoopNativeRun.cs.md#symbol-5f0977f165e0)

**调用：** `MegaCrit.Sts2.Core.Models.ModelDb.Character<T>()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.ModelDb.Character<T>()`；输入表达式：`ModelDb.Character<RandomCharacter>()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ModelDb.Character<RandomCharacter>()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e22050f58fa0"></a>

## `NationalSpire.GameBridge.CreateActSelectionRng(string) — public static Rng CreateActSelectionRng(string seed)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int)`](GameBridge.cs.md#symbol-b93ed89d4fc6)

**调用：** [`NationalSpire.GameCompatibility.ActRng(string)`](GameCompatibility.cs.md#symbol-68363869a9cf)

**字段、属性、事件及方法组引用：** `NationalSpire.GameCompatibility.ActRng(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GameCompatibility.ActRng(string)`；输入表达式：`GameCompatibility.ActRng(seed)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => GameCompatibility.ActRng(seed)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b93ed89d4fc6"></a>

## `NationalSpire.GameBridge.StartMatch(NationalSpire.CareerMatch, MegaCrit.Sts2.Core.Models.CharacterModel, int) — public static async Task<string?> StartMatch(CareerMatch match, CharacterModel character, int ascension)`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerScreen.ResolveFailure(string)`](FailureScreen.cs.md#symbol-64d5a395c405)

**调用：** [`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.Diagnostics.RecordStartFailure(string, System.Exception, System.Collections.Generic.IReadOnlyDictionary<string, System.Func<object?>>, string)`](Diagnostics.cs.md#symbol-a50687dc715c)；[`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`](EsportsWorld.cs.md#symbol-4b9f3e1bf70a)；[`NationalSpire.GameBridge.CreateActSelectionRng(string)`](GameBridge.cs.md#symbol-e22050f58fa0)；[`NationalSpire.GameCompatibility.Version()`](GameCompatibility.cs.md#symbol-f20a223e98d6)；[`NationalSpire.MatchFailure.Locked(NationalSpire.CareerData)`](FailureDecision.cs.md#symbol-7f4fa41ad4c0)；[`NationalSpire.MatchRules.PrepareOpponent(NationalSpire.CareerData, NationalSpire.CareerMatch)`](MatchRules.cs.md#symbol-cc58cecfce28)；[`NationalSpire.MatchRules.PrepareSeed(NationalSpire.CareerData, NationalSpire.CareerMatch)`](MatchRules.cs.md#symbol-27c230d3a150)；[`NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`](RuntimeApi.cs.md#symbol-8426661c18c8)；[`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`](RuntimeApi.cs.md#symbol-65f56c93bd1a)；`Godot.GD.Print(string)`；`Godot.GD.PushError(string)`；`MegaCrit.Sts2.Core.Commands.SfxCmd.Play(string, float)`；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`MegaCrit.Sts2.Core.Nodes.Audio.NAudioManager.StopMusic()`；`MegaCrit.Sts2.Core.Nodes.NGame.ReturnToMainMenuWithInternalError(System.Exception)`；`MegaCrit.Sts2.Core.Nodes.NTransition.FadeIn(float, string, System.Threading.CancellationToken?)`；`MegaCrit.Sts2.Core.Nodes.NTransition.FadeOut(float, string, System.Threading.CancellationToken?)`；`MegaCrit.Sts2.Core.Random.Rng.NextItem<T>(System.Collections.Generic.IEnumerable<T>)`；`MegaCrit.Sts2.Core.Saves.SaveManager.GenerateUnlockStateFromProgress()`；`MegaCrit.Sts2.Core.Saves.SaveManager.GetAllRunHistoryNames()`；`object.GetType()`；`object.ToString()`；`System.Array.Empty<T>()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.Contains(T)`；`System.DateTimeOffset.ToUnixTimeSeconds()`；`System.Diagnostics.Stopwatch.StartNew()`；`System.InvalidOperationException.InvalidOperationException(string?)`；`System.NotSupportedException.NotSupportedException(string?)`；`System.Type.IsAssignableFrom(System.Type?)`

**字段、属性、事件及方法组引用：** `<anonymous type: string game, string rng, string start>.game`；`<anonymous type: string game, string rng, string start>.rng`；`<anonymous type: string game, string rng, string start>.start`；`<anonymous type: string Id, string Seed, int ascension, long saveMs, long prepareMs, long startMs>.prepareMs`；`<anonymous type: string Id, string Seed, int ascension, long saveMs, long prepareMs, long startMs>.saveMs`；`<anonymous type: string Id, string Seed, int ascension, long saveMs, long prepareMs, long startMs>.startMs`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Failure`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PendingHistoryExcluded`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.PendingSince`；`NationalSpire.CareerData.SelectedAscension`；`NationalSpire.CareerData.SelectedCharacter`；`NationalSpire.CareerMatch.ChosenAscension`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Registered`；`NationalSpire.CareerMatch.RequiredAscension`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.CareerMatch.Status`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.CareerStore.Data`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.Diagnostics.RecordStartFailure(string, System.Exception, System.Collections.Generic.IReadOnlyDictionary<string, System.Func<object?>>, string)`；`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.FailureDecision.Result`；`NationalSpire.FailureDecision.RetryRequested`；`NationalSpire.GameBridge.CreateActSelectionRng(string)`；`NationalSpire.GameCompatibility.SeedMode`；`NationalSpire.GameCompatibility.Version()`；`NationalSpire.MatchFailure.Locked(NationalSpire.CareerData)`；`NationalSpire.MatchRecovery.SingleplayerInUse`；`NationalSpire.MatchRules.PrepareOpponent(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.MatchRules.PrepareSeed(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GD.Print(string)`；输入表达式：`GD.Print($"[NationalSpire] 开局耗时：接口检查及章节选择 {preparedAt}ms，转场及生涯保存 {savedAt - preparedAt}ms，原生开局 {clock.ElapsedMilliseconds - savedAt}ms")`；返回值紧邻使用处：`ExpressionStatementSyntax: GD.Print($"[NationalSpire] 开局耗时：接口检查及章节选择 {preparedAt}ms，转场及生涯保存 {savedAt - preparedAt}ms，原生开局 {clock.ElapsedMilliseconds - savedAt}ms");`
- `Godot.GD.PushError(string)`；输入表达式：`GD.PushError("[NationalSpire] 开局失败：" + e)`；返回值紧邻使用处：`ExpressionStatementSyntax: GD.PushError("[NationalSpire] 开局失败：" + e);`
- `MegaCrit.Sts2.Core.Commands.SfxCmd.Play(string, float)`；输入表达式：`SfxCmd.Play(character.CharacterTransitionSfx)`；返回值紧邻使用处：`ExpressionStatementSyntax: SfxCmd.Play(character.CharacterTransitionSfx);`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`character.Id.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: data.SelectedCharacter = character.Id.ToString()`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`character.Id.ToString()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => character.Id.ToString()`
- `MegaCrit.Sts2.Core.Nodes.Audio.NAudioManager.StopMusic()`；输入表达式：`.StopMusic()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: NAudioManager.Instance?.StopMusic()`
- `MegaCrit.Sts2.Core.Nodes.NGame.ReturnToMainMenuWithInternalError(System.Exception)`；输入表达式：`failedGame.ReturnToMainMenuWithInternalError(e)`；返回值紧邻使用处：`AwaitExpressionSyntax: await failedGame.ReturnToMainMenuWithInternalError(e)`
- `MegaCrit.Sts2.Core.Nodes.NTransition.FadeIn(float, string, System.Threading.CancellationToken?)`；输入表达式：`failedGame.Transition.FadeIn(0.2f)`；返回值紧邻使用处：`AwaitExpressionSyntax: await failedGame.Transition.FadeIn(0.2f)`
- `MegaCrit.Sts2.Core.Nodes.NTransition.FadeOut(float, string, System.Threading.CancellationToken?)`；输入表达式：`game.Transition.FadeOut(0.4f, character.CharacterSelectTransitionPath)`；返回值紧邻使用处：`AwaitExpressionSyntax: await game.Transition.FadeOut(0.4f, character.CharacterSelectTransitionPath)`
- `MegaCrit.Sts2.Core.Random.Rng.NextItem<T>(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`rng.NextItem(ModelDb.AllCharacters)`；返回值紧邻使用处：`BinaryExpressionSyntax: rng.NextItem(ModelDb.AllCharacters) ?? throw new InvalidOperationException("没有可用角色。")`
- `MegaCrit.Sts2.Core.Saves.SaveManager.GenerateUnlockStateFromProgress()`；输入表达式：`SaveManager.Instance.GenerateUnlockStateFromProgress()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SaveManager.Instance.GenerateUnlockStateFromProgress()`
- `MegaCrit.Sts2.Core.Saves.SaveManager.GetAllRunHistoryNames()`；输入表达式：`SaveManager.Instance.GetAllRunHistoryNames()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: SaveManager.Instance.GetAllRunHistoryNames().ToHashSet`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("match.preflight", new { game = GameCompatibility.Version(), rng = GameCompatibility.SeedMode, start = start.ToString() })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("match.preflight", new { game = GameCompatibility.Version(), rng = GameCompatibility.SeedMode, start = start.ToString() });`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("match.started", new { match.Id, match.Seed, ascension, saveMs = savedAt - preparedAt, prepareMs = preparedAt, startMs = clock.ElapsedMilliseconds - savedAt })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("match.started", new { match.Id, match.Seed, ascension, saveMs = savedAt - preparedAt, prepareMs = preparedAt, startMs = clock.ElapsedMilliseconds - savedAt });`
- `NationalSpire.Diagnostics.RecordStartFailure(string, System.Exception, System.Collections.Generic.IReadOnlyDictionary<string, System.Func<object?>>, string)`；输入表达式：`Diagnostics.RecordStartFailure("恢复主菜单与画面", recovery, context, "match.start.recovery")`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.RecordStartFailure("恢复主菜单与画面", recovery, context, "match.start.recovery");`
- `NationalSpire.Diagnostics.RecordStartFailure(string, System.Exception, System.Collections.Generic.IReadOnlyDictionary<string, System.Func<object?>>, string)`；输入表达式：`Diagnostics.RecordStartFailure("清理失败的开赛关联", cleanup, context, "match.start.cleanup")`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.RecordStartFailure("清理失败的开赛关联", cleanup, context, "match.start.cleanup");`
- `NationalSpire.Diagnostics.RecordStartFailure(string, System.Exception, System.Collections.Generic.IReadOnlyDictionary<string, System.Func<object?>>, string)`；输入表达式：`Diagnostics.RecordStartFailure(stage, e, context)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Diagnostics.RecordStartFailure(stage, e, context)`
- `NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`EsportsWorld.EntryReason(data, match)`；返回值紧邻使用处：`IsPatternExpressionSyntax: EsportsWorld.EntryReason(data, match) is { } locked`
- `NationalSpire.GameBridge.CreateActSelectionRng(string)`；输入表达式：`CreateActSelectionRng(match.Seed)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CreateActSelectionRng(match.Seed)`
- `NationalSpire.GameCompatibility.Version()`；输入表达式：`GameCompatibility.Version()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: game = GameCompatibility.Version()`
- `NationalSpire.GameCompatibility.Version()`；输入表达式：`GameCompatibility.Version()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => GameCompatibility.Version()`
- `NationalSpire.MatchFailure.Locked(NationalSpire.CareerData)`；输入表达式：`MatchFailure.Locked(data)`；返回值紧邻使用处：`ReturnStatementSyntax: return MatchFailure.Locked(data);`
- `NationalSpire.MatchRules.PrepareOpponent(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`MatchRules.PrepareOpponent(data, match)`；返回值紧邻使用处：`ExpressionStatementSyntax: MatchRules.PrepareOpponent(data, match);`
- `NationalSpire.MatchRules.PrepareSeed(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`MatchRules.PrepareSeed(data, match)`；返回值紧邻使用处：`ExpressionStatementSyntax: MatchRules.PrepareSeed(data, match);`
- `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；输入表达式：`RuntimeApi.Bind(typeof(ActModel), "GetRandomList", true, typeof(Rng), unlock.GetType(), typeof(bool))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RuntimeApi.Bind(typeof(ActModel), "GetRandomList", true, typeof(Rng), unlock.GetType(), typeof(bool))`
- `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；输入表达式：`RuntimeApi.Bind(typeof(NGame), "StartNewSingleplayerRun", false, typeof(CharacterModel), typeof(bool),                  acts.GetType(), typeof(ModifierModel[]), typeof(string), typeof(GameMode), typeof(int))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RuntimeApi.Bind(typeof(NGame), "StartNewSingleplayerRun", false, typeof(CharacterModel), typeof(bool),                  acts.GetType(), typeof(ModifierModel[]), typeof(string), typeof(GameMode), typeof(int))`
- `NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`；输入表达式：`RuntimeApi.Invoke(select, null, rng, unlock, false)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: RuntimeApi.Invoke(select, null, rng, unlock, false)!`
- `NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`；输入表达式：`RuntimeApi.Invoke(start, game, character, true, acts, Array.Empty<ModifierModel>(), match.Seed, GameMode.Standard, ascension)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: RuntimeApi.Invoke(start, game, character, true, acts, Array.Empty<ModifierModel>(), match.Seed, GameMode.Standard, ascension)!`
- `object.GetType()`；输入表达式：`acts.GetType()`；返回值紧邻使用处：`ArgumentSyntax: acts.GetType()`
- `object.GetType()`；输入表达式：`unlock.GetType()`；返回值紧邻使用处：`ArgumentSyntax: unlock.GetType()`
- `object.ToString()`；输入表达式：`start.ToString()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: start = start.ToString()`
- `System.Array.Empty<T>()`；输入表达式：`Array.Empty<ModifierModel>()`；返回值紧邻使用处：`ArgumentSyntax: Array.Empty<ModifierModel>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, Func<object?>>              {                  ["gameVersion"] = () => GameCompatibility.Version(),                  ["profile"] = () => SaveManager.Instance.CurrentProfileId,                  ["matchId"] = () => match.Id,                  ["seed"] = () => match.Seed,                  ["character"] = () => character.Id.ToString(),                  ["ascension"] = () => ascension,                  ["hasRunSave"] = () => SaveManager.Instance.HasRunSave,                  ["runInProgress"] = () => RunManager.Instance.IsInProgress,                  ["pendingMatchId"] = () => data.PendingMatchId              }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, Func<object?>>              {                  ["gameVersion"] = () => GameCompatibility.Version(),                  ["profile"] = () => SaveManager.Instance.CurrentProfileId,                  ["matchId"] = () => match.Id,                  ["seed"] = () => match.Seed,                  ["character"] = () => character.Id.ToString(),                  ["ascension"] = () => ascension,                  ["hasRunSave"] = () => SaveManager.Instance.HasRunSave,                  ["runInProgress"] = () => RunManager.Instance.IsInProgress,                  ["pendingMatchId"] = () => data.PendingMatchId              }`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`SaveManager.Instance.GetAllRunHistoryNames().ToHashSet()`；返回值紧邻使用处：`AssignmentExpressionSyntax: data.PendingHistoryExcluded = SaveManager.Instance.GetAllRunHistoryNames().ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`((IEnumerable<ActModel>)RuntimeApi.Invoke(select, null, rng, unlock, false)!).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ((IEnumerable<ActModel>)RuntimeApi.Invoke(select, null, rng, unlock, false)!).ToList()`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`data.Matches.Contains(match)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !data.Matches.Contains(match)`
- `System.DateTimeOffset.ToUnixTimeSeconds()`；输入表达式：`DateTimeOffset.UtcNow.ToUnixTimeSeconds()`；返回值紧邻使用处：`AssignmentExpressionSyntax: data.PendingSince = DateTimeOffset.UtcNow.ToUnixTimeSeconds()`
- `System.Diagnostics.Stopwatch.StartNew()`；输入表达式：`System.Diagnostics.Stopwatch.StartNew()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = System.Diagnostics.Stopwatch.StartNew()`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("没有可用角色。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidOperationException("没有可用角色。")`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("游戏场景尚未初始化。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidOperationException("游戏场景尚未初始化。")`
- `System.NotSupportedException.NotSupportedException(string?)`；输入表达式：`new NotSupportedException("开局接口的返回类型发生变化。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new NotSupportedException("开局接口的返回类型发生变化。");`
- `System.Type.IsAssignableFrom(System.Type?)`；输入表达式：`typeof(Task).IsAssignableFrom(start.ReturnType)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !typeof(Task).IsAssignableFrom(start.ReturnType)`

**赋值（含属性/字段和局部值）：**

- `["ascension"]` = `() => ascension`
- `["character"]` = `() => character.Id.ToString()`
- `["gameVersion"]` = `() => GameCompatibility.Version()`
- `["hasRunSave"]` = `() => SaveManager.Instance.HasRunSave`
- `["matchId"]` = `() => match.Id`
- `["pendingMatchId"]` = `() => data.PendingMatchId`
- `["profile"]` = `() => SaveManager.Instance.CurrentProfileId`
- `["runInProgress"]` = `() => RunManager.Instance.IsInProgress`
- `["seed"]` = `() => match.Seed`
- `character` = `rng.NextItem(ModelDb.AllCharacters) ?? throw new InvalidOperationException("没有可用角色。")`
- `data.Failure` = `null`
- `data.PendingHistoryExcluded` = `SaveManager.Instance.GetAllRunHistoryNames().ToHashSet()`
- `data.PendingMatchId` = `match.Id`
- `data.PendingMatchId` = `null`
- `data.PendingSince` = `0`
- `data.PendingSince` = `DateTimeOffset.UtcNow.ToUnixTimeSeconds()`
- `data.SelectedAscension` = `ascension`
- `data.SelectedCharacter` = `character.Id.ToString()`
- `match.ChosenAscension` = `ascension`
- `stage` = `"保存比赛与生涯的关联"`
- `stage` = `"保存开赛前的生涯数据"`
- `stage` = `"播放开赛转场"`
- `stage` = `"查找章节选择接口"`
- `stage` = `"创建章节随机源"`
- `stage` = `"读取游戏解锁资料"`
- `stage` = `"检查原生开局接口"`
- `stage` = `"确定出场角色"`
- `stage` = `"生成比赛章节"`
- `stage` = `"执行原生开局"`
- `stage` = `"准备比赛对手"`
- `stage` = `"准备比赛种子"`
- `transitionStarted` = `true`

<a id="symbol-87d1dc26f106"></a>

## `NationalSpire.GameBridge.MatchesPending(NationalSpire.CareerData, MegaCrit.Sts2.Core.Runs.RunHistory) — public static bool MatchesPending(CareerData data, RunHistory history)`

来源：源码第 126 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameBridge.CompleteHistory(MegaCrit.Sts2.Core.Runs.RunHistory)`](GameBridge.cs.md#symbol-4495455c88ce)；[`NationalSpire.GameBridge.RecoverPending()`](GameBridge.cs.md#symbol-7e7d899f5086)

**调用：** [`NationalSpire.CareerRunBinding.Find(NationalSpire.CareerData, string, string, int, int, bool, long?)`](CareerRunBinding.cs.md#symbol-814ae5a03226)；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerRunBinding.Find(NationalSpire.CareerData, string, string, int, int, bool, long?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`.Character.ToString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: history.Players.FirstOrDefault()?.Character.ToString()`
- `NationalSpire.CareerRunBinding.Find(NationalSpire.CareerData, string, string, int, int, bool, long?)`；输入表达式：`CareerRunBinding.Find(data, history.Seed, history.Players.FirstOrDefault()?.Character.ToString() ?? "",              history.Ascension, history.Players.Count, history.GameMode == GameMode.Standard, history.StartTime)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerRunBinding.Find(data, history.Seed, history.Players.FirstOrDefault()?.Character.ToString() ?? "",              history.Ascension, history.Players.Count, history.GameMode == GameMode.Standard, history.StartTime) != null`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`history.Players.FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: history.Players.FirstOrDefault()?.Character.ToString()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4495455c88ce"></a>

## `NationalSpire.GameBridge.CompleteHistory(MegaCrit.Sts2.Core.Runs.RunHistory) — public static void CompleteHistory(RunHistory history)`

来源：源码第 132 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameBridge.RecoverPending()`](GameBridge.cs.md#symbol-7e7d899f5086)；[`NationalSpire.HistoryPatch.Postfix(MegaCrit.Sts2.Core.Runs.RunHistory)`](GameBridge.cs.md#symbol-6216c9815a00)

**调用：** [`NationalSpire.AiService.ProcessPendingAsync(NationalSpire.CareerData?)`](AiService.cs.md#symbol-8243488b636b)；[`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool)`](CareerEngine.cs.md#symbol-2cb7c2afebf9)；[`NationalSpire.GameBridge.MatchesPending(NationalSpire.CareerData, MegaCrit.Sts2.Core.Runs.RunHistory)`](GameBridge.cs.md#symbol-87d1dc26f106)；[`NationalSpire.GameBridge.ReadPlayerHistory(MegaCrit.Sts2.Core.Runs.RunHistory, MegaCrit.Sts2.Core.Runs.RunHistoryPlayer)`](GameBridge.cs.md#symbol-2ddde8df91f3)；[`NationalSpire.PlayerArchive.Invalidate()`](PlayerArchive.cs.md#symbol-2f435607cb43)；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.ProcessPendingAsync(NationalSpire.CareerData?)`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool)`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerResult.Cards`；`NationalSpire.CareerResult.Character`；`NationalSpire.CareerResult.CharacterId`；`NationalSpire.CareerResult.DeckSummary`；`NationalSpire.CareerResult.Evidence`；`NationalSpire.CareerStore.Data`；`NationalSpire.GameBridge.MatchesPending(NationalSpire.CareerData, MegaCrit.Sts2.Core.Runs.RunHistory)`；`NationalSpire.GameBridge.ReadPlayerHistory(MegaCrit.Sts2.Core.Runs.RunHistory, MegaCrit.Sts2.Core.Runs.RunHistoryPlayer)`；`NationalSpire.PlayerArchive.Invalidate()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.ProcessPendingAsync(NationalSpire.CareerData?)`；输入表达式：`AiService.ProcessPendingAsync()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.ProcessPendingAsync()`
- `NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool)`；输入表达式：`CareerEngine.FinishMatch(data, match, history.Win, history.WasAbandoned,              history.MapPointHistory.Sum(a => a.Count), detail.Character, history.Ascension, detail.Cards, history.RunTime, detail.DeckSummary, detail.Evidence, detail.CharacterId)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.FinishMatch(data, match, history.Win, history.WasAbandoned,              history.MapPointHistory.Sum(a => a.Count), detail.Character, history.Ascension, detail.Cards, history.RunTime, detail.DeckSummary, detail.Evidence, detail.CharacterId);`
- `NationalSpire.GameBridge.MatchesPending(NationalSpire.CareerData, MegaCrit.Sts2.Core.Runs.RunHistory)`；输入表达式：`MatchesPending(data, history)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !MatchesPending(data, history)`
- `NationalSpire.GameBridge.ReadPlayerHistory(MegaCrit.Sts2.Core.Runs.RunHistory, MegaCrit.Sts2.Core.Runs.RunHistoryPlayer)`；输入表达式：`ReadPlayerHistory(history, history.Players[0])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ReadPlayerHistory(history, history.Players[0])`
- `NationalSpire.PlayerArchive.Invalidate()`；输入表达式：`PlayerArchive.Invalidate()`；返回值紧邻使用处：`ExpressionStatementSyntax: PlayerArchive.Invalidate();`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.First(m => m.Id == data.PendingMatchId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Matches.First(m => m.Id == data.PendingMatchId)`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`history.MapPointHistory.Sum(a => a.Count)`；返回值紧邻使用处：`ArgumentSyntax: history.MapPointHistory.Sum(a => a.Count)`

**赋值（含属性/字段和局部值）：**

- `_` = `AiService.ProcessPendingAsync()`

<a id="symbol-2ddde8df91f3"></a>

## `NationalSpire.GameBridge.ReadPlayerHistory(MegaCrit.Sts2.Core.Runs.RunHistory, MegaCrit.Sts2.Core.Runs.RunHistoryPlayer) — public static CareerResult ReadPlayerHistory(RunHistory history, RunHistoryPlayer player)`

来源：源码第 144 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRuntime.Complete(MegaCrit.Sts2.Core.Runs.RunHistory)`](Coop/CoopRuntime.cs.md#symbol-732476d12d29)；[`NationalSpire.GameBridge.CompleteHistory(MegaCrit.Sts2.Core.Runs.RunHistory)`](GameBridge.cs.md#symbol-4495455c88ce)

**调用：** [`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.GameBridge.ReadDefeatedEncounters(MegaCrit.Sts2.Core.Runs.RunHistory)`](GameBridge.cs.md#symbol-e0b622ef14ef)；[`NationalSpire.GameText.Plain(string)`](GameText.cs.md#symbol-e2c48dec4564)；[`NationalSpire.PlayerArchive.CharacterName(MegaCrit.Sts2.Core.Models.ModelId)`](PlayerArchive.cs.md#symbol-9ab35bc5f38f)；`MegaCrit.Sts2.Core.Localization.LocString.Exists(string, string)`；`MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；`MegaCrit.Sts2.Core.Localization.LocString.LocString(string, string)`；`MegaCrit.Sts2.Core.Models.CardModel.FromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializableCard)`；`MegaCrit.Sts2.Core.Models.CardModel.GetDescriptionForPile(MegaCrit.Sts2.Core.Entities.Cards.PileType, MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`MegaCrit.Sts2.Core.Models.PotionModel.FromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializablePotion)`；`NationalSpire.CareerResult.CareerResult()`；`NationalSpire.RunBadge.RunBadge()`；`NationalSpire.RunEvidence.RunEvidence()`；`string.ToLowerInvariant()`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Enum.ToString()`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerResult.Cards`；`NationalSpire.CareerResult.Character`；`NationalSpire.CareerResult.CharacterId`；`NationalSpire.CareerResult.DeckSummary`；`NationalSpire.CareerResult.Evidence`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.GameBridge.ReadDefeatedEncounters(MegaCrit.Sts2.Core.Runs.RunHistory)`；`NationalSpire.GameText.Plain(string)`；`NationalSpire.PlayerArchive.CharacterName(MegaCrit.Sts2.Core.Models.ModelId)`；`NationalSpire.RunBadge.Description`；`NationalSpire.RunBadge.Name`；`NationalSpire.RunBadge.Rarity`；`NationalSpire.RunEvidence.Badges`；`NationalSpire.RunEvidence.DefeatedEncounters`；`NationalSpire.RunEvidence.FinalHp`；`NationalSpire.RunEvidence.GoldGained`；`NationalSpire.RunEvidence.MaxHp`；`NationalSpire.RunEvidence.PotionSlots`；`NationalSpire.RunEvidence.PotionsObtained`；`NationalSpire.RunEvidence.PotionsRecorded`；`NationalSpire.RunEvidence.PotionsUsed`；`NationalSpire.RunEvidence.RemainingGold`；`NationalSpire.RunEvidence.RemainingPotions`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Localization.LocString.Exists(string, string)`；输入表达式：`LocString.Exists("badges", badge.Id + "." + prefix + "Title")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = LocString.Exists("badges", badge.Id + "." + prefix + "Title")`
- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`new LocString("badges", badge.Id + (tiered ? "." + prefix + "Description" : ".description")).GetFormattedText()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LocString("badges", badge.Id + (tiered ? "." + prefix + "Description" : ".description")).GetFormattedText()`
- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`new LocString("badges", badge.Id + (tiered ? "." + prefix + "Title" : ".title")).GetFormattedText()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LocString("badges", badge.Id + (tiered ? "." + prefix + "Title" : ".title")).GetFormattedText()`
- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`PotionModel.FromSerializable(potion).Title.GetFormattedText()`；返回值紧邻使用处：`ArgumentSyntax: PotionModel.FromSerializable(potion).Title.GetFormattedText()`
- `MegaCrit.Sts2.Core.Localization.LocString.LocString(string, string)`；输入表达式：`new LocString("badges", badge.Id + (tiered ? "." + prefix + "Description" : ".description"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new LocString("badges", badge.Id + (tiered ? "." + prefix + "Description" : ".description")).GetFormattedText`
- `MegaCrit.Sts2.Core.Localization.LocString.LocString(string, string)`；输入表达式：`new LocString("badges", badge.Id + (tiered ? "." + prefix + "Title" : ".title"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new LocString("badges", badge.Id + (tiered ? "." + prefix + "Title" : ".title")).GetFormattedText`
- `MegaCrit.Sts2.Core.Models.CardModel.FromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializableCard)`；输入表达式：`CardModel.FromSerializable(serialized)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CardModel.FromSerializable(serialized)`
- `MegaCrit.Sts2.Core.Models.CardModel.GetDescriptionForPile(MegaCrit.Sts2.Core.Entities.Cards.PileType, MegaCrit.Sts2.Core.Entities.Creatures.Creature?)`；输入表达式：`card.GetDescriptionForPile(PileType.None)`；返回值紧邻使用处：`BinaryExpressionSyntax: card.Title + "：" + card.GetDescriptionForPile(PileType.None)`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`player.Character.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: CharacterId = player.Character.ToString()`
- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`serialized.Id!.ToString()`；返回值紧邻使用处：`ArgumentSyntax: serialized.Id!.ToString()`
- `MegaCrit.Sts2.Core.Models.PotionModel.FromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializablePotion)`；输入表达式：`PotionModel.FromSerializable(potion)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PotionModel.FromSerializable(potion).Title`
- `NationalSpire.CareerResult.CareerResult()`；输入表达式：`new() { Character = PlayerArchive.CharacterName(player.Character), CharacterId = player.Character.ToString(), Cards = cards, DeckSummary = deckSummary, Evidence = evidence }`；返回值紧邻使用处：`ReturnStatementSyntax: return new() { Character = PlayerArchive.CharacterName(player.Character), CharacterId = player.Character.ToString(), Cards = cards, DeckSummary = deckSummary, Evidence = evidence };`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("history.encounters", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("history.encounters", e);`
- `NationalSpire.GameBridge.ReadDefeatedEncounters(MegaCrit.Sts2.Core.Runs.RunHistory)`；输入表达式：`ReadDefeatedEncounters(history)`；返回值紧邻使用处：`AssignmentExpressionSyntax: evidence.DefeatedEncounters = ReadDefeatedEncounters(history)`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(card.Title + "：" + card.GetDescriptionForPile(PileType.None))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GameText.Plain(card.Title + "：" + card.GetDescriptionForPile(PileType.None))`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(card.Title)`；返回值紧邻使用处：`ArgumentSyntax: GameText.Plain(card.Title)`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(description)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Description = GameText.Plain(description)`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(name)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Name = GameText.Plain(name)`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(PotionModel.FromSerializable(potion).Title.GetFormattedText())`；返回值紧邻使用处：`ArgumentSyntax: GameText.Plain(PotionModel.FromSerializable(potion).Title.GetFormattedText())`
- `NationalSpire.PlayerArchive.CharacterName(MegaCrit.Sts2.Core.Models.ModelId)`；输入表达式：`PlayerArchive.CharacterName(player.Character)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Character = PlayerArchive.CharacterName(player.Character)`
- `NationalSpire.RunBadge.RunBadge()`；输入表达式：`new() { Name = GameText.Plain(name), Description = GameText.Plain(description), Rarity = badge.Rarity.ToString() }`；返回值紧邻使用处：`ArgumentSyntax: new() { Name = GameText.Plain(name), Description = GameText.Plain(description), Rarity = badge.Rarity.ToString() }`
- `NationalSpire.RunEvidence.RunEvidence()`；输入表达式：`new RunEvidence { PotionsRecorded = true, PotionSlots = player.MaxPotionSlotCount }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new RunEvidence { PotionsRecorded = true, PotionSlots = player.MaxPotionSlotCount }`
- `string.ToLowerInvariant()`；输入表达式：`badge.Rarity.ToString().ToLowerInvariant()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = badge.Rarity.ToString().ToLowerInvariant()`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`g.Count()`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Key + " ×" + g.Count()`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`s.PotionChoices.Count(p => p.wasPicked)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: s => s.PotionChoices.Count(p => p.wasPicked)`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`player.Deck.Where(c => c.Id != null)              .OrderByDescending(c => c.CurrentUpgradeLevel).ThenByDescending(c => c.FloorAddedToDeck ?? 0)              .DistinctBy(c => c.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: player.Deck.Where(c => c.Id != null)              .OrderByDescending(c => c.CurrentUpgradeLevel).ThenByDescending(c => c.FloorAddedToDeck ?? 0)              .DistinctBy(c => c.Id).Take`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`deckNames.GroupBy(name => name)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: deckNames.GroupBy(name => name).Select`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`roomStats.LastOrDefault()`；返回值紧邻使用处：`IsPatternExpressionSyntax: roomStats.LastOrDefault() is { } finalStats`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`roomStats.LastOrDefault()`；返回值紧邻使用处：`IsPatternExpressionSyntax: roomStats.LastOrDefault() is { MaxHp: > 0 } last`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`player.Deck.Where(c => c.Id != null)              .OrderByDescending(c => c.CurrentUpgradeLevel)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: player.Deck.Where(c => c.Id != null)              .OrderByDescending(c => c.CurrentUpgradeLevel).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`deckNames.GroupBy(name => name).Select(g => g.Key + " ×" + g.Count())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: deckNames.GroupBy(name => name).Select(g => g.Key + " ×" + g.Count()).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`history.MapPointHistory.SelectMany(a => a).SelectMany(e => e.PlayerStats)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: history.MapPointHistory.SelectMany(a => a).SelectMany(e => e.PlayerStats).Where`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`history.MapPointHistory.SelectMany(a => a)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: history.MapPointHistory.SelectMany(a => a).SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`roomStats.Sum(s => s.GoldGained)`；返回值紧邻使用处：`AssignmentExpressionSyntax: evidence.GoldGained = roomStats.Sum(s => s.GoldGained)`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`roomStats.Sum(s => s.PotionChoices.Count(p => p.wasPicked))`；返回值紧邻使用处：`AssignmentExpressionSyntax: evidence.PotionsObtained = roomStats.Sum(s => s.PotionChoices.Count(p => p.wasPicked))`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`roomStats.Sum(s => s.PotionUsed.Count)`；返回值紧邻使用处：`AssignmentExpressionSyntax: evidence.PotionsUsed = roomStats.Sum(s => s.PotionUsed.Count)`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`player.Deck.Where(c => c.Id != null)              .OrderByDescending(c => c.CurrentUpgradeLevel).ThenByDescending(c => c.FloorAddedToDeck ?? 0)              .DistinctBy(c => c.Id).Take(6)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var serialized in player.Deck.Where(c => c.Id != null)              .OrderByDescending(c => c.CurrentUpgradeLevel).ThenByDescending(c => c.FloorAddedToDeck ?? 0)              .DistinctBy(c => c.Id).Take(6))          {              try              {                  var card = CardModel.FromSerializable(serialized);                  string text = GameText.Plain(card.Title + "：" + card.GetDescriptionForPile(PileType.None));                  cards.Add(text);              }              catch { /* 已卸载的 Mod 卡牌不阻止结算。 */ }          }`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`deckNames.GroupBy(name => name).Select(g => g.Key + " ×" + g.Count()).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = deckNames.GroupBy(name => name).Select(g => g.Key + " ×" + g.Count()).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`history.MapPointHistory.SelectMany(a => a).SelectMany(e => e.PlayerStats).Where(s => s.PlayerId == player.Id).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = history.MapPointHistory.SelectMany(a => a).SelectMany(e => e.PlayerStats).Where(s => s.PlayerId == player.Id).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`history.MapPointHistory.SelectMany(a => a).SelectMany(e => e.PlayerStats).Where(s => s.PlayerId == player.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: history.MapPointHistory.SelectMany(a => a).SelectMany(e => e.PlayerStats).Where(s => s.PlayerId == player.Id).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`player.Deck.Where(c => c.Id != null)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var serialized in player.Deck.Where(c => c.Id != null))          {              try { var card = CardModel.FromSerializable(serialized); deckNames.Add(GameText.Plain(card.Title)); }              catch { deckNames.Add(serialized.Id!.ToString()); }          }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`player.Deck.Where(c => c.Id != null)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: player.Deck.Where(c => c.Id != null)              .OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`player.Potions.Where(p => p.Id != null)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var potion in player.Potions.Where(p => p.Id != null))          {              try { evidence.RemainingPotions.Add(GameText.Plain(PotionModel.FromSerializable(potion).Title.GetFormattedText())); }              catch { evidence.RemainingPotions.Add("未识别药水"); }          }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`cards.Add(text)`；返回值紧邻使用处：`ExpressionStatementSyntax: cards.Add(text);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`deckNames.Add(GameText.Plain(card.Title))`；返回值紧邻使用处：`ExpressionStatementSyntax: deckNames.Add(GameText.Plain(card.Title));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`deckNames.Add(serialized.Id!.ToString())`；返回值紧邻使用处：`ExpressionStatementSyntax: deckNames.Add(serialized.Id!.ToString());`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`evidence.Badges.Add(new() { Name = GameText.Plain(name), Description = GameText.Plain(description), Rarity = badge.Rarity.ToString() })`；返回值紧邻使用处：`ExpressionStatementSyntax: evidence.Badges.Add(new() { Name = GameText.Plain(name), Description = GameText.Plain(description), Rarity = badge.Rarity.ToString() });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`evidence.RemainingPotions.Add("未识别药水")`；返回值紧邻使用处：`ExpressionStatementSyntax: evidence.RemainingPotions.Add("未识别药水");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`evidence.RemainingPotions.Add(GameText.Plain(PotionModel.FromSerializable(potion).Title.GetFormattedText()))`；返回值紧邻使用处：`ExpressionStatementSyntax: evidence.RemainingPotions.Add(GameText.Plain(PotionModel.FromSerializable(potion).Title.GetFormattedText()));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string>()`
- `System.Enum.ToString()`；输入表达式：`badge.Rarity.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Rarity = badge.Rarity.ToString()`
- `System.Enum.ToString()`；输入表达式：`badge.Rarity.ToString()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: badge.Rarity.ToString().ToLowerInvariant`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`player.Deck.Where(c => c.Id != null)              .OrderByDescending(c => c.CurrentUpgradeLevel).ThenByDescending(c => c.FloorAddedToDeck ?? 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: player.Deck.Where(c => c.Id != null)              .OrderByDescending(c => c.CurrentUpgradeLevel).ThenByDescending(c => c.FloorAddedToDeck ?? 0)              .DistinctBy`

**赋值（含属性/字段和局部值）：**

- `Cards` = `cards`
- `Character` = `PlayerArchive.CharacterName(player.Character)`
- `CharacterId` = `player.Character.ToString()`
- `DeckSummary` = `deckSummary`
- `Description` = `GameText.Plain(description)`
- `evidence.DefeatedEncounters` = `ReadDefeatedEncounters(history)`
- `evidence.FinalHp` = `last.CurrentHp`
- `evidence.GoldGained` = `roomStats.Sum(s => s.GoldGained)`
- `evidence.MaxHp` = `last.MaxHp`
- `evidence.PotionsObtained` = `roomStats.Sum(s => s.PotionChoices.Count(p => p.wasPicked))`
- `evidence.PotionsUsed` = `roomStats.Sum(s => s.PotionUsed.Count)`
- `evidence.RemainingGold` = `finalStats.CurrentGold`
- `Evidence` = `evidence`
- `Name` = `GameText.Plain(name)`
- `PotionSlots` = `player.MaxPotionSlotCount`
- `PotionsRecorded` = `true`
- `Rarity` = `badge.Rarity.ToString()`

<a id="symbol-e0b622ef14ef"></a>

## `NationalSpire.GameBridge.ReadDefeatedEncounters(MegaCrit.Sts2.Core.Runs.RunHistory) — private static List<RunEncounter> ReadDefeatedEncounters(RunHistory history)`

来源：源码第 199 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameBridge.ReadPlayerHistory(MegaCrit.Sts2.Core.Runs.RunHistory, MegaCrit.Sts2.Core.Runs.RunHistoryPlayer)`](GameBridge.cs.md#symbol-2ddde8df91f3)

**调用：** [`NationalSpire.GameText.Plain(string)`](GameText.cs.md#symbol-e2c48dec4564)；[`NationalSpire.RunEvidence.CompletedEncounters(System.Collections.Generic.IReadOnlyList<NationalSpire.RunEncounter>, bool, bool)`](RunEvidence.cs.md#symbol-398b1fb61f92)；`MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；`MegaCrit.Sts2.Core.Models.ModelDb.GetByIdOrNull<T>(MegaCrit.Sts2.Core.Models.ModelId)`；`MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；`NationalSpire.RunEncounter.RunEncounter(int, int, string, string)`；`object.ReferenceEquals(object?, object?)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Enum.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.GameText.Plain(string)`；`NationalSpire.RunEvidence.CompletedEncounters(System.Collections.Generic.IReadOnlyList<NationalSpire.RunEncounter>, bool, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Localization.LocString.GetFormattedText()`；输入表达式：`.Title.GetFormattedText()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: ModelDb.GetByIdOrNull<EncounterModel>(id)?.Title.GetFormattedText()`
- `MegaCrit.Sts2.Core.Models.ModelDb.GetByIdOrNull<T>(MegaCrit.Sts2.Core.Models.ModelId)`；输入表达式：`ModelDb.GetByIdOrNull<EncounterModel>(id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: ModelDb.GetByIdOrNull<EncounterModel>(id)?.Title.GetFormattedText()`
- `MegaCrit.Sts2.Core.Runs.RunManager.DebugOnlyGetState()`；输入表达式：`RunManager.Instance.DebugOnlyGetState()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RunManager.Instance.DebugOnlyGetState()`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(name.Length > 0 ? name : kind == "Boss" ? "未识别BOSS" : "未识别精英")`；返回值紧邻使用处：`ArgumentSyntax: GameText.Plain(name.Length > 0 ? name : kind == "Boss" ? "未识别BOSS" : "未识别精英")`
- `NationalSpire.RunEncounter.RunEncounter(int, int, string, string)`；输入表达式：`new(act + 1, floor, kind, GameText.Plain(name.Length > 0 ? name : kind == "Boss" ? "未识别BOSS" : "未识别精英"))`；返回值紧邻使用处：`ArgumentSyntax: new(act + 1, floor, kind, GameText.Plain(name.Length > 0 ? name : kind == "Boss" ? "未识别BOSS" : "未识别精英"))`
- `NationalSpire.RunEvidence.CompletedEncounters(System.Collections.Generic.IReadOnlyList<NationalSpire.RunEncounter>, bool, bool)`；输入表达式：`RunEvidence.CompletedEncounters(rooms, history.Win && !history.WasAbandoned, finalRoomCompleted)`；返回值紧邻使用处：`ReturnStatementSyntax: return RunEvidence.CompletedEncounters(rooms, history.Win && !history.WasAbandoned, finalRoomCompleted);`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(state.CurrentMapPointHistoryEntry, lastPoint)`；返回值紧邻使用处：`BinaryExpressionSyntax: state != null && ReferenceEquals(state.CurrentMapPointHistoryEntry, lastPoint)`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`.LastOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: history.MapPointHistory.LastOrDefault()?.LastOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`history.MapPointHistory.LastOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: history.MapPointHistory.LastOrDefault()?.LastOrDefault()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`rooms.Add(new(act + 1, floor, kind, GameText.Plain(name.Length > 0 ? name : kind == "Boss" ? "未识别BOSS" : "未识别精英")))`；返回值紧邻使用处：`ExpressionStatementSyntax: rooms.Add(new(act + 1, floor, kind, GameText.Plain(name.Length > 0 ? name : kind == "Boss" ? "未识别BOSS" : "未识别精英")));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<RunEncounter>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<RunEncounter>()`
- `System.Enum.ToString()`；输入表达式：`room.RoomType.ToString()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = room.RoomType.ToString()`

**赋值（含属性/字段和局部值）：**

- `name` = `id.Entry`
- `name` = `ModelDb.GetByIdOrNull<EncounterModel>(id)?.Title.GetFormattedText() ?? name`

<a id="symbol-7e7d899f5086"></a>

## `NationalSpire.GameBridge.RecoverPending() — public static void RecoverPending()`

来源：源码第 228 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.GameBridge.ReleaseMissingRun()`](GameBridge.cs.md#symbol-0d1c45a81336)；[`NationalSpire.MenuPatch.Postfix(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`](GameBridge.cs.md#symbol-6939e359db40)

**调用：** [`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.GameBridge.CompleteHistory(MegaCrit.Sts2.Core.Runs.RunHistory)`](GameBridge.cs.md#symbol-4495455c88ce)；[`NationalSpire.GameBridge.MatchesPending(NationalSpire.CareerData, MegaCrit.Sts2.Core.Runs.RunHistory)`](GameBridge.cs.md#symbol-87d1dc26f106)；[`NationalSpire.MatchRecovery.HistoryCandidates(System.Collections.Generic.IEnumerable<string>, long)`](MatchRecovery.cs.md#symbol-c41f1e6650d2)；`MegaCrit.Sts2.Core.Saves.SaveManager.GetAllRunHistoryNames()`；`MegaCrit.Sts2.Core.Saves.SaveManager.LoadRunHistory(string)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `<anonymous type: int profile, string PendingMatchId, long PendingSince, bool hasSave, bool inProgress, int checkedCount, int unreadable>.hasSave`；`<anonymous type: int profile, string PendingMatchId, long PendingSince, bool hasSave, bool inProgress, int checkedCount, int unreadable>.inProgress`；`<anonymous type: int profile, string PendingMatchId, long PendingSince, bool hasSave, bool inProgress, int checkedCount, int unreadable>.profile`；`NationalSpire.CareerData.PendingHistoryExcluded`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.PendingSince`；`NationalSpire.CareerStore.Data`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.GameBridge.CompleteHistory(MegaCrit.Sts2.Core.Runs.RunHistory)`；`NationalSpire.GameBridge.MatchesPending(NationalSpire.CareerData, MegaCrit.Sts2.Core.Runs.RunHistory)`；`NationalSpire.MatchRecovery.HistoryCandidates(System.Collections.Generic.IEnumerable<string>, long)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Saves.SaveManager.GetAllRunHistoryNames()`；输入表达式：`save.GetAllRunHistoryNames()`；返回值紧邻使用处：`ArgumentSyntax: save.GetAllRunHistoryNames()`
- `MegaCrit.Sts2.Core.Saves.SaveManager.LoadRunHistory(string)`；输入表达式：`save.LoadRunHistory(file)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = save.LoadRunHistory(file)`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("match.recovery.history", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("match.recovery.history", e);`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("match.recovery", new { profile = save.CurrentProfileId, data.PendingMatchId,              data.PendingSince, hasSave = save.HasRunSave, inProgress = RunManager.Instance.IsInProgress, checkedCount, unreadable })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("match.recovery", new { profile = save.CurrentProfileId, data.PendingMatchId,              data.PendingSince, hasSave = save.HasRunSave, inProgress = RunManager.Instance.IsInProgress, checkedCount, unreadable });`
- `NationalSpire.GameBridge.CompleteHistory(MegaCrit.Sts2.Core.Runs.RunHistory)`；输入表达式：`CompleteHistory(history)`；返回值紧邻使用处：`ExpressionStatementSyntax: CompleteHistory(history);`
- `NationalSpire.GameBridge.MatchesPending(NationalSpire.CareerData, MegaCrit.Sts2.Core.Runs.RunHistory)`；输入表达式：`MatchesPending(data, history)`；返回值紧邻使用处：`IfStatementSyntax: if (MatchesPending(data, history)) { CompleteHistory(history); return; }`
- `NationalSpire.MatchRecovery.HistoryCandidates(System.Collections.Generic.IEnumerable<string>, long)`；输入表达式：`MatchRecovery.HistoryCandidates(save.GetAllRunHistoryNames(), data.PendingSince)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: MatchRecovery.HistoryCandidates(save.GetAllRunHistoryNames(), data.PendingSince).Where`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`data.PendingHistoryExcluded.Contains(file)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !data.PendingHistoryExcluded.Contains(file)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`MatchRecovery.HistoryCandidates(save.GetAllRunHistoryNames(), data.PendingSince).Where(file => !data.PendingHistoryExcluded.Contains(file))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string file in MatchRecovery.HistoryCandidates(save.GetAllRunHistoryNames(), data.PendingSince).Where(file => !data.PendingHistoryExcluded.Contains(file)))          {              try              {                  var result = save.LoadRunHistory(file); checkedCount++;                  if (result.Success && result.SaveData is { } history)                  {                      if (MatchesPending(data, history)) { CompleteHistory(history); return; }                  }                  else unreadable++;              }              catch (Exception e) { unreadable++; Diagnostics.Error("match.recovery.history", e); }          }`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0d1c45a81336"></a>

## `NationalSpire.GameBridge.ReleaseMissingRun() — public static void ReleaseMissingRun()`

来源：源码第 251 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)

**调用：** [`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.GameBridge.RecoverPending()`](GameBridge.cs.md#symbol-7e7d899f5086)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.PendingSince`；`NationalSpire.CareerStore.Data`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.GameBridge.CanReleaseMissingRun`；`NationalSpire.GameBridge.RecoverPending()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `NationalSpire.GameBridge.RecoverPending()`；输入表达式：`RecoverPending()`；返回值紧邻使用处：`ExpressionStatementSyntax: RecoverPending();`

**赋值（含属性/字段和局部值）：**

- `data.PendingMatchId` = `null`
- `data.PendingSince` = `0`

<a id="symbol-6939e359db40"></a>

## `NationalSpire.MenuPatch.Postfix(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu) — public static void Postfix(NMainMenu __instance)`

来源：源码第 266 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.AiService.ProcessPendingAsync(NationalSpire.CareerData?)`](AiService.cs.md#symbol-8243488b636b)；[`NationalSpire.AvatarAssets.Invalidate()`](AvatarAssets.cs.md#symbol-2e945d7b39a4)；[`NationalSpire.CareerScreen.Open(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu, string?)`](CareerScreen.cs.md#symbol-b760e48de501)；[`NationalSpire.CareerVisuals.CreateTheme()`](CareerVisuals.cs.md#symbol-a5f88af9f360)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.GameBridge.RecoverPending()`](GameBridge.cs.md#symbol-7e7d899f5086)；[`NationalSpire.MainMenuEntries.Bind(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu, Godot.Button)`](MainMenuEntries.cs.md#symbol-04f3caa98ff1)；[`NationalSpire.PlayerArchive.Invalidate()`](PlayerArchive.cs.md#symbol-2f435607cb43)；`Godot.Button.Button()`；`Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；`Godot.GD.PushError(string)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Vector2.Vector2(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.ProcessPendingAsync(NationalSpire.CareerData?)`；`NationalSpire.AvatarAssets.Invalidate()`；`NationalSpire.CareerScreen.Open(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu, string?)`；`NationalSpire.CareerVisuals.CreateTheme()`；`NationalSpire.Coop.CoopRuntime.Bound`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.GameBridge.RecoverPending()`；`NationalSpire.MainMenuEntries.Bind(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu, Godot.Button)`；`NationalSpire.PlayerArchive.Invalidate()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Button.Button()`；输入表达式：`new Button { Text = "国运尖塔：单人生涯", CustomMinimumSize = new Vector2(310, 64), Theme = CareerVisuals.CreateTheme() }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Button { Text = "国运尖塔：单人生涯", CustomMinimumSize = new Vector2(310, 64), Theme = CareerVisuals.CreateTheme() }`
- `Godot.Control.SetAnchorsAndOffsetsPreset(Godot.Control.LayoutPreset, Godot.Control.LayoutPresetMode, int)`；输入表达式：`button.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.BottomLeft)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.BottomLeft);`
- `Godot.GD.PushError(string)`；输入表达式：`GD.PushError("[NationalSpire] 生涯入口初始化失败：" + e)`；返回值紧邻使用处：`ExpressionStatementSyntax: GD.PushError("[NationalSpire] 生涯入口初始化失败：" + e);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`__instance.AddChild(button)`；返回值紧邻使用处：`ExpressionStatementSyntax: __instance.AddChild(button);`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(310, 64)`；返回值紧邻使用处：`AssignmentExpressionSyntax: CustomMinimumSize = new Vector2(310, 64)`
- `NationalSpire.AiService.ProcessPendingAsync(NationalSpire.CareerData?)`；输入表达式：`AiService.ProcessPendingAsync()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.ProcessPendingAsync()`
- `NationalSpire.AvatarAssets.Invalidate()`；输入表达式：`AvatarAssets.Invalidate()`；返回值紧邻使用处：`ExpressionStatementSyntax: AvatarAssets.Invalidate();`
- `NationalSpire.CareerScreen.Open(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu, string?)`；输入表达式：`CareerScreen.Open(__instance)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => CareerScreen.Open(__instance)`
- `NationalSpire.CareerVisuals.CreateTheme()`；输入表达式：`CareerVisuals.CreateTheme()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Theme = CareerVisuals.CreateTheme()`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("career.entry", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("career.entry", e);`
- `NationalSpire.GameBridge.RecoverPending()`；输入表达式：`GameBridge.RecoverPending()`；返回值紧邻使用处：`ExpressionStatementSyntax: GameBridge.RecoverPending();`
- `NationalSpire.MainMenuEntries.Bind(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu, Godot.Button)`；输入表达式：`MainMenuEntries.Bind(__instance, button)`；返回值紧邻使用处：`ExpressionStatementSyntax: MainMenuEntries.Bind(__instance, button);`
- `NationalSpire.PlayerArchive.Invalidate()`；输入表达式：`PlayerArchive.Invalidate()`；返回值紧邻使用处：`ExpressionStatementSyntax: PlayerArchive.Invalidate();`

**赋值（含属性/字段和局部值）：**

- `_` = `AiService.ProcessPendingAsync()`
- `button.OffsetBottom` = `-42`
- `button.OffsetLeft` = `40`
- `button.OffsetRight` = `350`
- `button.OffsetTop` = `-106`
- `button.Pressed` += `() => CareerScreen.Open(__instance)`
- `CustomMinimumSize` = `new Vector2(310, 64)`
- `Text` = `"国运尖塔：单人生涯"`
- `Theme` = `CareerVisuals.CreateTheme()`

<a id="symbol-6216c9815a00"></a>

## `NationalSpire.HistoryPatch.Postfix(MegaCrit.Sts2.Core.Runs.RunHistory) — public static void Postfix(RunHistory history)`

来源：源码第 290 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Diagnostics.Error(string, System.Exception)`](Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.GameBridge.CompleteHistory(MegaCrit.Sts2.Core.Runs.RunHistory)`](GameBridge.cs.md#symbol-4495455c88ce)；`Godot.GD.PushError(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.GameBridge.CompleteHistory(MegaCrit.Sts2.Core.Runs.RunHistory)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.GD.PushError(string)`；输入表达式：`GD.PushError("[NationalSpire] 生涯结算失败：" + e)`；返回值紧邻使用处：`ExpressionStatementSyntax: GD.PushError("[NationalSpire] 生涯结算失败：" + e);`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("match.settlement", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("match.settlement", e);`
- `NationalSpire.GameBridge.CompleteHistory(MegaCrit.Sts2.Core.Runs.RunHistory)`；输入表达式：`GameBridge.CompleteHistory(history)`；返回值紧邻使用处：`ExpressionStatementSyntax: GameBridge.CompleteHistory(history);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4f2ee4be7c21"></a>

## `NationalSpire.CareerContextPatch.Postfix(ref MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext?) — public static void Postfix(ref IScreenContext? __result)`

来源：源码第 300 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.Current`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `__result` = `screen`
