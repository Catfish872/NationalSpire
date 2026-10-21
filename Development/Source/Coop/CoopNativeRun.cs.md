# Coop/CoopNativeRun.cs

[返回文件依赖索引](../../SOURCE_MAP.md)

源码 SHA-256：`993444CB0C44A268D6A1086220CCFF6ED7B1248CF6CC1F6E2EEABCF4F3D5A249`。来源：[源码](../../../Coop/CoopNativeRun.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Coop.ICoopNativePlatform`、`NationalSpire.Coop.CoopSteamRunPlatform`、`NationalSpire.Coop.CoopNativeRun`。

字段、事件及初始值（源码原样）：

```csharp
private readonly ICoopNativePlatform _platform = platform ?? new CoopSteamRunPlatform();
private INetGameService? _service;
private StartRunLobby? _start;
private LoadRunLobby? _load;
private string _attempt = "", _lobby = "";
private bool _busy, _launched, _failed, _stopping;
private bool _entering;
private TaskCompletionSource? _entryCompleted;
private int _generation;
private CancellationTokenSource _lifetime = new();
private DateTime _announced, _began;
private DateTime _checkedStage;
private string _waitingStage = "";
```

<a id="symbol-a3aab1a67801"></a>

## `NationalSpire.Coop.ICoopNativePlatform.Version() — object? Version();`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.Host()`](CoopNativeRun.cs.md#symbol-5e85a7e716a1)；[`NationalSpire.Coop.CoopNativeRun.Join(string, bool)`](CoopNativeRun.cs.md#symbol-a3ff2d717caf)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2e2568167f2d"></a>

## `NationalSpire.Coop.ICoopNativePlatform.Host(MegaCrit.Sts2.Core.Multiplayer.NetHostGameService, int) — Task<string> Host(NetHostGameService service, int members);`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.Host()`](CoopNativeRun.cs.md#symbol-5e85a7e716a1)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6666ab41f1e9"></a>

## `NationalSpire.Coop.ICoopNativePlatform.Join(MegaCrit.Sts2.Core.Multiplayer.NetClientGameService, string, System.Threading.CancellationToken) — Task<NetErrorInfo?> Join(NetClientGameService service, string lobby, CancellationToken token);`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.Join(string, bool)`](CoopNativeRun.cs.md#symbol-a3ff2d717caf)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2ebc550752a9"></a>

## `NationalSpire.Coop.ICoopNativePlatform.BeginNew(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>, string, int, System.Threading.CancellationToken) — Task BeginNew(StartRunLobby lobby, IReadOnlyList<ActModel> acts, IReadOnlyList<ModifierModel> modifiers, string seed, int ascension, CancellationToken token = default);`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.BeginRun(string, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>)`](CoopNativeRun.cs.md#symbol-ddd22369fd06)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0623ae9e3550"></a>

## `NationalSpire.Coop.ICoopNativePlatform.BeginSaved(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby, System.Threading.CancellationToken) — Task BeginSaved(LoadRunLobby lobby, CancellationToken token = default);`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.BeginRun()`](CoopNativeRun.cs.md#symbol-77d1b0a8ef74)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-44ba56693565"></a>

## `NationalSpire.Coop.CoopSteamRunPlatform.Version() — public object? Version()`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.NativeLobbyApi.Version()`](NativeLobbyApi.cs.md#symbol-b0693755b371)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.NativeLobbyApi.Version()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.NativeLobbyApi.Version()`；输入表达式：`NativeLobbyApi.Version()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => NativeLobbyApi.Version()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-023bc386272b"></a>

## `NationalSpire.Coop.CoopSteamRunPlatform.Host(MegaCrit.Sts2.Core.Multiplayer.NetHostGameService, int) — public async Task<string> Host(NetHostGameService service, int members)`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopSteamRunPlatform.LeaveOriginalLobby(System.Threading.CancellationToken)`](CoopNativeRun.cs.md#symbol-e4d08012a590)；`MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo.ToString()`；`MegaCrit.Sts2.Core.Multiplayer.NetHostGameService.GetRawLobbyIdentifier()`；`MegaCrit.Sts2.Core.Multiplayer.NetHostGameService.StartSteamHost(int)`；`System.IO.IOException.IOException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopSteamRunPlatform.LeaveOriginalLobby(System.Threading.CancellationToken)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo.ToString()`；输入表达式：`error.ToString()`；返回值紧邻使用处：`ArgumentSyntax: error.ToString()`
- `MegaCrit.Sts2.Core.Multiplayer.NetHostGameService.GetRawLobbyIdentifier()`；输入表达式：`service.GetRawLobbyIdentifier()`；返回值紧邻使用处：`BinaryExpressionSyntax: service.GetRawLobbyIdentifier() ?? throw new IOException("原版未返回联机大厅标识。")`
- `MegaCrit.Sts2.Core.Multiplayer.NetHostGameService.StartSteamHost(int)`；输入表达式：`service.StartSteamHost(members)`；返回值紧邻使用处：`AwaitExpressionSyntax: await service.StartSteamHost(members)`
- `NationalSpire.Coop.CoopSteamRunPlatform.LeaveOriginalLobby(System.Threading.CancellationToken)`；输入表达式：`LeaveOriginalLobby()`；返回值紧邻使用处：`AwaitExpressionSyntax: await LeaveOriginalLobby()`
- `System.IO.IOException.IOException(string?)`；输入表达式：`new IOException("原版未返回联机大厅标识。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new IOException("原版未返回联机大厅标识。")`
- `System.IO.IOException.IOException(string?)`；输入表达式：`new IOException(error.ToString())`；返回值紧邻使用处：`ThrowStatementSyntax: throw new IOException(error.ToString());`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8fe0cd9c07ab"></a>

## `NationalSpire.Coop.CoopSteamRunPlatform.Join(MegaCrit.Sts2.Core.Multiplayer.NetClientGameService, string, System.Threading.CancellationToken) — public async Task<NetErrorInfo?> Join(NetClientGameService service, string lobby, CancellationToken token)`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopSteamRunPlatform.LeaveOriginalLobby(System.Threading.CancellationToken)`](CoopNativeRun.cs.md#symbol-e4d08012a590)；[`NationalSpire.Coop.NativeLobbyApi.Connect(object, MegaCrit.Sts2.Core.Multiplayer.NetClientGameService, System.Threading.CancellationToken)`](NativeLobbyApi.cs.md#symbol-2d450bb2d13d)；`MegaCrit.Sts2.Core.Multiplayer.Connection.SteamClientConnectionInitializer.FromLobby(ulong)`；`System.IO.IOException.IOException(string?)`；`ulong.TryParse(string?, out ulong)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopSteamRunPlatform.LeaveOriginalLobby(System.Threading.CancellationToken)`；`NationalSpire.Coop.NativeLobbyApi.Connect(object, MegaCrit.Sts2.Core.Multiplayer.NetClientGameService, System.Threading.CancellationToken)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Multiplayer.Connection.SteamClientConnectionInitializer.FromLobby(ulong)`；输入表达式：`SteamClientConnectionInitializer.FromLobby(id)`；返回值紧邻使用处：`ArgumentSyntax: SteamClientConnectionInitializer.FromLobby(id)`
- `NationalSpire.Coop.CoopSteamRunPlatform.LeaveOriginalLobby(System.Threading.CancellationToken)`；输入表达式：`LeaveOriginalLobby(token)`；返回值紧邻使用处：`AwaitExpressionSyntax: await LeaveOriginalLobby(token)`
- `NationalSpire.Coop.NativeLobbyApi.Connect(object, MegaCrit.Sts2.Core.Multiplayer.NetClientGameService, System.Threading.CancellationToken)`；输入表达式：`NativeLobbyApi.Connect(SteamClientConnectionInitializer.FromLobby(id), service, token)`；返回值紧邻使用处：`AwaitExpressionSyntax: await NativeLobbyApi.Connect(SteamClientConnectionInitializer.FromLobby(id), service, token)`
- `System.IO.IOException.IOException(string?)`；输入表达式：`new IOException("原版大厅标识无效。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new IOException("原版大厅标识无效。")`
- `ulong.TryParse(string?, out ulong)`；输入表达式：`ulong.TryParse(lobby, out ulong id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ulong.TryParse(lobby, out ulong id) ? await NativeLobbyApi.Connect(SteamClientConnectionInitializer.FromLobby(id), service, token) : throw new IOException("原版大厅标识无效。")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e4d08012a590"></a>

## `NationalSpire.Coop.CoopSteamRunPlatform.LeaveOriginalLobby(System.Threading.CancellationToken) — private static async Task LeaveOriginalLobby(CancellationToken token = default)`

来源：源码第 42 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopSteamRunPlatform.Host(MegaCrit.Sts2.Core.Multiplayer.NetHostGameService, int)`](CoopNativeRun.cs.md#symbol-023bc386272b)；[`NationalSpire.Coop.CoopSteamRunPlatform.Join(MegaCrit.Sts2.Core.Multiplayer.NetClientGameService, string, System.Threading.CancellationToken)`](CoopNativeRun.cs.md#symbol-8fe0cd9c07ab)

**调用：** [`NationalSpire.Diagnostics.Record(string, object)`](../Diagnostics.cs.md#symbol-1b5632793cd0)；`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuStack.Pop()`；`System.InvalidOperationException.InvalidOperationException(string?)`；`System.Threading.Tasks.Task.Delay(int, System.Threading.CancellationToken)`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.Record(string, object)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuStack.Pop()`；输入表达式：`stack.Pop()`；返回值紧邻使用处：`ExpressionStatementSyntax: stack.Pop();`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("coop.native.menu-cleanup", "已退出原版子菜单，等待其延迟关闭监听端口。")`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("coop.native.menu-cleanup", "已退出原版子菜单，等待其延迟关闭监听端口。");`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("请先退出正在进行的原版对局。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("请先退出正在进行的原版对局。");`
- `System.Threading.Tasks.Task.Delay(int, System.Threading.CancellationToken)`；输入表达式：`Task.Delay(1100, token)`；返回值紧邻使用处：`AwaitExpressionSyntax: await Task.Delay(1100, token)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b889ef6fb033"></a>

## `NationalSpire.Coop.CoopSteamRunPlatform.BeginNew(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>, string, int, System.Threading.CancellationToken) — public async Task BeginNew(StartRunLobby lobby, IReadOnlyList<ActModel> acts, IReadOnlyList<ModifierModel> modifiers, string seed, int ascension, CancellationToken token = default)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.CloseCurrent()`](../CareerSession.cs.md#symbol-5830f879d8f9)；[`NationalSpire.Coop.CoopScreen.CloseCurrent()`](CoopScreen.cs.md#symbol-3f7660e3fc51)；[`NationalSpire.Coop.NativeLobbyApi.Local(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby)`](NativeLobbyApi.cs.md#symbol-81508394bacc)；[`NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby)`](NativeLobbyApi.cs.md#symbol-433695ce5c9e)；[`NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`](../RuntimeApi.cs.md#symbol-8426661c18c8)；[`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`](../RuntimeApi.cs.md#symbol-65f56c93bd1a)；`MegaCrit.Sts2.Core.Commands.SfxCmd.Play(string, float)`；`MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.CleanUp(bool, MegaCrit.Sts2.Core.Entities.Multiplayer.NetError)`；`MegaCrit.Sts2.Core.Nodes.Audio.NAudioManager.StopMusic()`；`MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteMouseCursorContainer.Initialize(MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput.PeerInputSynchronizer, System.Collections.Generic.IEnumerable<ulong>)`；`MegaCrit.Sts2.Core.Nodes.NTransition.FadeIn(float, string, System.Threading.CancellationToken?)`；`MegaCrit.Sts2.Core.Nodes.NTransition.FadeOut(float, string, System.Threading.CancellationToken?)`；`MegaCrit.Sts2.Core.Nodes.Reaction.NReactionContainer.InitializeNetworking(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService)`；`object.GetType()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.InvalidOperationException.InvalidOperationException(string?)`；`System.Threading.CancellationToken.ThrowIfCancellationRequested()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.CloseCurrent()`；`NationalSpire.Coop.CoopScreen.CloseCurrent()`；`NationalSpire.Coop.NativeLobbyApi.Local(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby)`；`NationalSpire.Coop.NativeLobbyApi.Member.Character`；`NationalSpire.Coop.NativeLobbyApi.Member.Id`；`NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby)`；`NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Commands.SfxCmd.Play(string, float)`；输入表达式：`SfxCmd.Play(character.CharacterTransitionSfx)`；返回值紧邻使用处：`ExpressionStatementSyntax: SfxCmd.Play(character.CharacterTransitionSfx);`
- `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.CleanUp(bool, MegaCrit.Sts2.Core.Entities.Multiplayer.NetError)`；输入表达式：`lobby.CleanUp(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: lobby.CleanUp(false);`
- `MegaCrit.Sts2.Core.Nodes.Audio.NAudioManager.StopMusic()`；输入表达式：`.StopMusic()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: NAudioManager.Instance?.StopMusic()`
- `MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteMouseCursorContainer.Initialize(MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput.PeerInputSynchronizer, System.Collections.Generic.IEnumerable<ulong>)`；输入表达式：`game.RemoteCursorContainer.Initialize(lobby.InputSynchronizer, NativeLobbyApi.Players(lobby).Select(p => p.Id))`；返回值紧邻使用处：`ExpressionStatementSyntax: game.RemoteCursorContainer.Initialize(lobby.InputSynchronizer, NativeLobbyApi.Players(lobby).Select(p => p.Id));`
- `MegaCrit.Sts2.Core.Nodes.NTransition.FadeIn(float, string, System.Threading.CancellationToken?)`；输入表达式：`game.Transition.FadeIn(.2f)`；返回值紧邻使用处：`AwaitExpressionSyntax: await game.Transition.FadeIn(.2f)`
- `MegaCrit.Sts2.Core.Nodes.NTransition.FadeOut(float, string, System.Threading.CancellationToken?)`；输入表达式：`game.Transition.FadeOut(.4f, character.CharacterSelectTransitionPath)`；返回值紧邻使用处：`AwaitExpressionSyntax: await game.Transition.FadeOut(.4f, character.CharacterSelectTransitionPath)`
- `MegaCrit.Sts2.Core.Nodes.Reaction.NReactionContainer.InitializeNetworking(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService)`；输入表达式：`game.ReactionContainer.InitializeNetworking(lobby.NetService)`；返回值紧邻使用处：`ExpressionStatementSyntax: game.ReactionContainer.InitializeNetworking(lobby.NetService);`
- `NationalSpire.CareerScreen.CloseCurrent()`；输入表达式：`CareerScreen.CloseCurrent()`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerScreen.CloseCurrent();`
- `NationalSpire.Coop.CoopScreen.CloseCurrent()`；输入表达式：`CoopScreen.CloseCurrent()`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopScreen.CloseCurrent();`
- `NationalSpire.Coop.NativeLobbyApi.Local(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby)`；输入表达式：`NativeLobbyApi.Local(lobby)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: NativeLobbyApi.Local(lobby).Character`
- `NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby)`；输入表达式：`NativeLobbyApi.Players(lobby)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: NativeLobbyApi.Players(lobby).Select`
- `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；输入表达式：`RuntimeApi.Bind(typeof(NGame), "StartNewMultiplayerRun", false, typeof(StartRunLobby), typeof(bool),              acts.GetType(), modifiers.GetType(), typeof(string), typeof(int))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RuntimeApi.Bind(typeof(NGame), "StartNewMultiplayerRun", false, typeof(StartRunLobby), typeof(bool),              acts.GetType(), modifiers.GetType(), typeof(string), typeof(int))`
- `NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`；输入表达式：`RuntimeApi.Invoke(start, game, lobby, true, acts, modifiers, seed, ascension)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: RuntimeApi.Invoke(start, game, lobby, true, acts, modifiers, seed, ascension)!`
- `object.GetType()`；输入表达式：`acts.GetType()`；返回值紧邻使用处：`ArgumentSyntax: acts.GetType()`
- `object.GetType()`；输入表达式：`modifiers.GetType()`；返回值紧邻使用处：`ArgumentSyntax: modifiers.GetType()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`NativeLobbyApi.Players(lobby).Select(p => p.Id)`；返回值紧邻使用处：`ArgumentSyntax: NativeLobbyApi.Players(lobby).Select(p => p.Id)`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("游戏场景尚未初始化。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidOperationException("游戏场景尚未初始化。")`
- `System.Threading.CancellationToken.ThrowIfCancellationRequested()`；输入表达式：`token.ThrowIfCancellationRequested()`；返回值紧邻使用处：`ExpressionStatementSyntax: token.ThrowIfCancellationRequested();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-dc951f669f46"></a>

## `NationalSpire.Coop.CoopSteamRunPlatform.BeginSaved(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby, System.Threading.CancellationToken) — public async Task BeginSaved(LoadRunLobby lobby, CancellationToken token = default)`

来源：源码第 73 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerScreen.CloseCurrent()`](../CareerSession.cs.md#symbol-5830f879d8f9)；[`NationalSpire.Coop.CoopScreen.CloseCurrent()`](CoopScreen.cs.md#symbol-3f7660e3fc51)；[`NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`](../RuntimeApi.cs.md#symbol-8426661c18c8)；[`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`](../RuntimeApi.cs.md#symbol-65f56c93bd1a)；`MegaCrit.Sts2.Core.Commands.SfxCmd.Play(string, float)`；`MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby.CleanUp(bool, MegaCrit.Sts2.Core.Entities.Multiplayer.NetError)`；`MegaCrit.Sts2.Core.Nodes.Audio.NAudioManager.StopMusic()`；`MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteMouseCursorContainer.Initialize(MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput.PeerInputSynchronizer, System.Collections.Generic.IEnumerable<ulong>)`；`MegaCrit.Sts2.Core.Nodes.NTransition.FadeIn(float, string, System.Threading.CancellationToken?)`；`MegaCrit.Sts2.Core.Nodes.NTransition.FadeOut(float, string, System.Threading.CancellationToken?)`；`MegaCrit.Sts2.Core.Nodes.Reaction.NReactionContainer.InitializeNetworking(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService)`；`MegaCrit.Sts2.Core.Runs.RunState.FromSerializable(MegaCrit.Sts2.Core.Saves.SerializableRun)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.InvalidOperationException.InvalidOperationException(string?)`；`System.Threading.CancellationToken.ThrowIfCancellationRequested()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.CloseCurrent()`；`NationalSpire.Coop.CoopScreen.CloseCurrent()`；`NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Commands.SfxCmd.Play(string, float)`；输入表达式：`SfxCmd.Play(character.CharacterTransitionSfx)`；返回值紧邻使用处：`ExpressionStatementSyntax: SfxCmd.Play(character.CharacterTransitionSfx);`
- `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby.CleanUp(bool, MegaCrit.Sts2.Core.Entities.Multiplayer.NetError)`；输入表达式：`lobby.CleanUp(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: lobby.CleanUp(false);`
- `MegaCrit.Sts2.Core.Nodes.Audio.NAudioManager.StopMusic()`；输入表达式：`.StopMusic()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: NAudioManager.Instance?.StopMusic()`
- `MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteMouseCursorContainer.Initialize(MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput.PeerInputSynchronizer, System.Collections.Generic.IEnumerable<ulong>)`；输入表达式：`game.RemoteCursorContainer.Initialize(lobby.InputSynchronizer, state.Players.Select(p => p.NetId))`；返回值紧邻使用处：`ExpressionStatementSyntax: game.RemoteCursorContainer.Initialize(lobby.InputSynchronizer, state.Players.Select(p => p.NetId));`
- `MegaCrit.Sts2.Core.Nodes.NTransition.FadeIn(float, string, System.Threading.CancellationToken?)`；输入表达式：`game.Transition.FadeIn(.2f)`；返回值紧邻使用处：`AwaitExpressionSyntax: await game.Transition.FadeIn(.2f)`
- `MegaCrit.Sts2.Core.Nodes.NTransition.FadeOut(float, string, System.Threading.CancellationToken?)`；输入表达式：`game.Transition.FadeOut(.4f, character.CharacterSelectTransitionPath)`；返回值紧邻使用处：`AwaitExpressionSyntax: await game.Transition.FadeOut(.4f, character.CharacterSelectTransitionPath)`
- `MegaCrit.Sts2.Core.Nodes.Reaction.NReactionContainer.InitializeNetworking(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService)`；输入表达式：`game.ReactionContainer.InitializeNetworking(lobby.NetService)`；返回值紧邻使用处：`ExpressionStatementSyntax: game.ReactionContainer.InitializeNetworking(lobby.NetService);`
- `MegaCrit.Sts2.Core.Runs.RunState.FromSerializable(MegaCrit.Sts2.Core.Saves.SerializableRun)`；输入表达式：`RunState.FromSerializable(lobby.Run)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RunState.FromSerializable(lobby.Run)`
- `NationalSpire.CareerScreen.CloseCurrent()`；输入表达式：`CareerScreen.CloseCurrent()`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerScreen.CloseCurrent();`
- `NationalSpire.Coop.CoopScreen.CloseCurrent()`；输入表达式：`CoopScreen.CloseCurrent()`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopScreen.CloseCurrent();`
- `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；输入表达式：`RuntimeApi.Bind(typeof(NGame), "LoadRun", false, typeof(RunState), typeof(SerializableRoom))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RuntimeApi.Bind(typeof(NGame), "LoadRun", false, typeof(RunState), typeof(SerializableRoom))`
- `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；输入表达式：`RuntimeApi.Bind(typeof(RunManager), "SetUpSavedMultiplayer", false, typeof(RunState), typeof(LoadRunLobby))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RuntimeApi.Bind(typeof(RunManager), "SetUpSavedMultiplayer", false, typeof(RunState), typeof(LoadRunLobby))`
- `NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`；输入表达式：`RuntimeApi.Invoke(load, game, state, lobby.Run.PreFinishedRoom)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: RuntimeApi.Invoke(load, game, state, lobby.Run.PreFinishedRoom)!`
- `NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`；输入表达式：`RuntimeApi.Invoke(setup, RunManager.Instance, state, lobby)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: RuntimeApi.Invoke(setup, RunManager.Instance, state, lobby)!`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`state.Players.Select(p => p.NetId)`；返回值紧邻使用处：`ArgumentSyntax: state.Players.Select(p => p.NetId)`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`state.Players.Single(p => p.NetId == lobby.NetService.NetId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: state.Players.Single(p => p.NetId == lobby.NetService.NetId).Character`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("游戏场景尚未初始化。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidOperationException("游戏场景尚未初始化。")`
- `System.Threading.CancellationToken.ThrowIfCancellationRequested()`；输入表达式：`token.ThrowIfCancellationRequested()`；返回值紧邻使用处：`ExpressionStatementSyntax: token.ThrowIfCancellationRequested();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-72549b80e794"></a>

## `NationalSpire.Coop.CoopNativeRun.StartListener — private IStartRunLobbyListener StartListener`

来源：源码第 99 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.NativeLobbyApi.Listener<T>(System.Func<System.Reflection.MethodInfo, object?[], object?>)`](NativeLobbyApi.cs.md#symbol-80e9e2678be0)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopNativeRun.Callback(System.Reflection.MethodInfo, object?[])`；`NationalSpire.Coop.NativeLobbyApi.Listener<T>(System.Func<System.Reflection.MethodInfo, object?[], object?>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.NativeLobbyApi.Listener<T>(System.Func<System.Reflection.MethodInfo, object?[], object?>)`；输入表达式：`NativeLobbyApi.Listener<IStartRunLobbyListener>(Callback)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => NativeLobbyApi.Listener<IStartRunLobbyListener>(Callback)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-cb16516b62ba"></a>

## `NationalSpire.Coop.CoopNativeRun.LoadListener — private ILoadRunLobbyListener LoadListener`

来源：源码第 100 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.NativeLobbyApi.Listener<T>(System.Func<System.Reflection.MethodInfo, object?[], object?>)`](NativeLobbyApi.cs.md#symbol-80e9e2678be0)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopNativeRun.Callback(System.Reflection.MethodInfo, object?[])`；`NationalSpire.Coop.NativeLobbyApi.Listener<T>(System.Func<System.Reflection.MethodInfo, object?[], object?>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.NativeLobbyApi.Listener<T>(System.Func<System.Reflection.MethodInfo, object?[], object?>)`；输入表达式：`NativeLobbyApi.Listener<ILoadRunLobbyListener>(Callback)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => NativeLobbyApi.Listener<ILoadRunLobbyListener>(Callback)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2cd18e0c472c"></a>

## `NationalSpire.Coop.CoopNativeRun.Callback(System.Reflection.MethodInfo, object?[]) — private object? Callback(System.Reflection.MethodInfo method, object?[] args)`

来源：源码第 101 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopNativeRun.BeginRun()`](CoopNativeRun.cs.md#symbol-77d1b0a8ef74)；[`NationalSpire.Coop.CoopNativeRun.BeginRun(string, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>)`](CoopNativeRun.cs.md#symbol-ddd22369fd06)；[`NationalSpire.Coop.CoopNativeRun.PlayerChanged(NationalSpire.Coop.NativeLobbyApi.Member, bool)`](CoopNativeRun.cs.md#symbol-9053b1c2c84a)；[`NationalSpire.Coop.CoopNativeRun.ShouldAllowRunToBegin()`](CoopNativeRun.cs.md#symbol-2d3e3dcdd4d4)；[`NationalSpire.Coop.NativeLobbyApi.Player(object, bool)`](NativeLobbyApi.cs.md#symbol-60a2df09ad65)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopNativeRun._entering`；`NationalSpire.Coop.CoopNativeRun._launched`；`NationalSpire.Coop.CoopNativeRun._stopping`；`NationalSpire.Coop.CoopNativeRun.BeginRun()`；`NationalSpire.Coop.CoopNativeRun.BeginRun(string, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>)`；`NationalSpire.Coop.CoopNativeRun.HasConnection`；`NationalSpire.Coop.CoopNativeRun.NeedsPause`；`NationalSpire.Coop.CoopNativeRun.PlayerChanged(NationalSpire.Coop.NativeLobbyApi.Member, bool)`；`NationalSpire.Coop.CoopNativeRun.ShouldAllowRunToBegin()`；`NationalSpire.Coop.NativeLobbyApi.Player(object, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopNativeRun.BeginRun()`；输入表达式：`BeginRun()`；返回值紧邻使用处：`ExpressionStatementSyntax: BeginRun();`
- `NationalSpire.Coop.CoopNativeRun.BeginRun(string, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>)`；输入表达式：`BeginRun((string)args[0]!, (List<ActModel>)args[1]!, (IReadOnlyList<ModifierModel>)args[2]!)`；返回值紧邻使用处：`ExpressionStatementSyntax: BeginRun((string)args[0]!, (List<ActModel>)args[1]!, (IReadOnlyList<ModifierModel>)args[2]!);`
- `NationalSpire.Coop.CoopNativeRun.PlayerChanged(NationalSpire.Coop.NativeLobbyApi.Member, bool)`；输入表达式：`PlayerChanged(NativeLobbyApi.Player(args[0]!), (bool)args[1]!)`；返回值紧邻使用处：`ExpressionStatementSyntax: PlayerChanged(NativeLobbyApi.Player(args[0]!), (bool)args[1]!);`
- `NationalSpire.Coop.CoopNativeRun.ShouldAllowRunToBegin()`；输入表达式：`ShouldAllowRunToBegin()`；返回值紧邻使用处：`ReturnStatementSyntax: return ShouldAllowRunToBegin();`
- `NationalSpire.Coop.NativeLobbyApi.Player(object, bool)`；输入表达式：`NativeLobbyApi.Player(args[0]!)`；返回值紧邻使用处：`ArgumentSyntax: NativeLobbyApi.Player(args[0]!)`

**赋值（含属性/字段和局部值）：**

- `NeedsPause` = `true`

<a id="symbol-030a171e1ddd"></a>

## `NationalSpire.Coop.CoopNativeRun.PauseRequestedByHost — public bool PauseRequestedByHost`

来源：源码第 121 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-732cd261f291"></a>

## `NationalSpire.Coop.CoopNativeRun.Status — public string Status`

来源：源码第 129 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-dc516f4db111"></a>

## `NationalSpire.Coop.CoopNativeRun.LastError — public string LastError`

来源：源码第 130 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-10c22cc41c35"></a>

## `NationalSpire.Coop.CoopNativeRun.Launched — public bool Launched`

来源：源码第 131 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopNativeRun._launched`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-51403a6d5234"></a>

## `NationalSpire.Coop.CoopNativeRun.Entering — public bool Entering`

来源：源码第 132 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopNativeRun._entering`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c81cf8511287"></a>

## `NationalSpire.Coop.CoopNativeRun.WaitForEntry() — public Task WaitForEntry()`

来源：源码第 133 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRuntime.PauseCore(string)`](CoopRuntime.cs.md#symbol-60fe2cb26a8e)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopNativeRun._entryCompleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1871890e93b8"></a>

## `NationalSpire.Coop.CoopNativeRun.HasConnection — public bool HasConnection`

来源：源码第 134 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopNativeRun._service`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9ae33170e5e0"></a>

## `NationalSpire.Coop.CoopNativeRun.OwnsConnection(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService) — public bool OwnsConnection(INetGameService service)`

来源：源码第 135 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopDisconnectMenuPatch.Prefix(MegaCrit.Sts2.Core.Runs.RunManager, ref System.Threading.Tasks.Task)`](CoopRuntime.cs.md#symbol-a193812f456a)

**调用：** `object.ReferenceEquals(object?, object?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopNativeRun._service`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(_service, service)`；返回值紧邻使用处：`BinaryExpressionSyntax: _service != null && ReferenceEquals(_service, service)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-173b8340e058"></a>

## `NationalSpire.Coop.CoopNativeRun.StopConnection() — public void StopConnection()`

来源：源码第 136 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRuntime.PauseCore(string)`](CoopRuntime.cs.md#symbol-60fe2cb26a8e)

**调用：** `MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService.Disconnect(MegaCrit.Sts2.Core.Entities.Multiplayer.NetError, bool)`；`System.Threading.CancellationTokenSource.Cancel()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopNativeRun._lifetime`；`NationalSpire.Coop.CoopNativeRun._service`；`NationalSpire.Coop.CoopNativeRun._stopping`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService.Disconnect(MegaCrit.Sts2.Core.Entities.Multiplayer.NetError, bool)`；输入表达式：`_service.Disconnect(NetError.Quit)`；返回值紧邻使用处：`ExpressionStatementSyntax: _service.Disconnect(NetError.Quit);`
- `System.Threading.CancellationTokenSource.Cancel()`；输入表达式：`_lifetime.Cancel()`；返回值紧邻使用处：`ExpressionStatementSyntax: _lifetime.Cancel();`

**赋值（含属性/字段和局部值）：**

- `_stopping` = `true`

<a id="symbol-1e34d21d8d03"></a>

## `NationalSpire.Coop.CoopNativeRun.PumpPendingNetwork() — public void PumpPendingNetwork()`

来源：源码第 142 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.Update()`](CoopNativeRun.cs.md#symbol-f8b6c697410f)；[`NationalSpire.Coop.CoopRuntime._Process(double)`](CoopRuntime.cs.md#symbol-ec1513bd09b1)

**调用：** `MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService.Update()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopNativeRun._launched`；`NationalSpire.Coop.CoopNativeRun._service`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService.Update()`；输入表达式：`.Update()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _service?.Update()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-12b525d33d59"></a>

## `NationalSpire.Coop.CoopNativeRun.NeedsPause — public bool NeedsPause`

来源：源码第 143 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f8b6c697410f"></a>

## `NationalSpire.Coop.CoopNativeRun.Update() — public void Update()`

来源：源码第 144 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRuntime._Process(double)`](CoopRuntime.cs.md#symbol-ec1513bd09b1)

**调用：** [`NationalSpire.Coop.CoopCoordinator.SendRun(string, object)`](CoopCoordinator.cs.md#symbol-99375ad602b4)；[`NationalSpire.Coop.CoopNativeRun.Close()`](CoopNativeRun.cs.md#symbol-c8afc67dbfe3)；[`NationalSpire.Coop.CoopNativeRun.Fail(System.Exception)`](CoopNativeRun.cs.md#symbol-fa50e38bdb28)；[`NationalSpire.Coop.CoopNativeRun.Host()`](CoopNativeRun.cs.md#symbol-5e85a7e716a1)；[`NationalSpire.Coop.CoopNativeRun.PumpPendingNetwork()`](CoopNativeRun.cs.md#symbol-1e34d21d8d03)；[`NationalSpire.Coop.CoopNativeRun.WaitingStage()`](CoopNativeRun.cs.md#symbol-40773357613d)；[`NationalSpire.Coop.NativeLobbyApi.Local(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby)`](NativeLobbyApi.cs.md#symbol-81508394bacc)；[`NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby)`](NativeLobbyApi.cs.md#symbol-92249f368b32)；[`NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby)`](NativeLobbyApi.cs.md#symbol-433695ce5c9e)；[`NationalSpire.Diagnostics.Record(string, object)`](../Diagnostics.cs.md#symbol-1b5632793cd0)；`MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby.SetReady(bool)`；`MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.SetReady(bool)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.TimeoutException.TimeoutException(string?)`；`System.TimeSpan.FromSeconds(long)`

**字段、属性、事件及方法组引用：** `<anonymous type: bool host, string attempt, string stage>.attempt`；`<anonymous type: bool host, string attempt, string stage>.host`；`<anonymous type: string epoch, string attempt, int resume, string lobby, bool load>.attempt`；`<anonymous type: string epoch, string attempt, int resume, string lobby, bool load>.epoch`；`<anonymous type: string epoch, string attempt, int resume, string lobby, bool load>.load`；`<anonymous type: string epoch, string attempt, int resume, string lobby, bool load>.lobby`；`<anonymous type: string epoch, string attempt, int resume, string lobby, bool load>.resume`；`NationalSpire.Coop.CoopCoordinator.Full`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.NativeSave`；`NationalSpire.Coop.CoopCoordinator.Receiving`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.SendRun(string, object)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopNativeRun._announced`；`NationalSpire.Coop.CoopNativeRun._attempt`；`NationalSpire.Coop.CoopNativeRun._began`；`NationalSpire.Coop.CoopNativeRun._busy`；`NationalSpire.Coop.CoopNativeRun._checkedStage`；`NationalSpire.Coop.CoopNativeRun._failed`；`NationalSpire.Coop.CoopNativeRun._launched`；`NationalSpire.Coop.CoopNativeRun._load`；`NationalSpire.Coop.CoopNativeRun._lobby`；`NationalSpire.Coop.CoopNativeRun._service`；`NationalSpire.Coop.CoopNativeRun._start`；`NationalSpire.Coop.CoopNativeRun._stopping`；`NationalSpire.Coop.CoopNativeRun._waitingStage`；`NationalSpire.Coop.CoopNativeRun.Close()`；`NationalSpire.Coop.CoopNativeRun.Fail(System.Exception)`；`NationalSpire.Coop.CoopNativeRun.Host()`；`NationalSpire.Coop.CoopNativeRun.NeedsPause`；`NationalSpire.Coop.CoopNativeRun.PumpPendingNetwork()`；`NationalSpire.Coop.CoopNativeRun.Status`；`NationalSpire.Coop.CoopNativeRun.WaitingStage()`；`NationalSpire.Coop.CoopRun.Characters`；`NationalSpire.Coop.CoopRun.Phase`；`NationalSpire.Coop.CoopRun.ResumeCount`；`NationalSpire.Coop.CoopRun.Terminal`；`NationalSpire.Coop.CoopRuntime.Current`；`NationalSpire.Coop.CoopRuntime.ResumeRequired`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.NativeLobbyApi.Local(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby)`；`NationalSpire.Coop.NativeLobbyApi.Member.Id`；`NationalSpire.Coop.NativeLobbyApi.Member.Ready`；`NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby)`；`NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby)`；`NationalSpire.Diagnostics.Record(string, object)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby.SetReady(bool)`；输入表达式：`_load.SetReady(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: _load.SetReady(true);`
- `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.SetReady(bool)`；输入表达式：`_start.SetReady(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: _start.SetReady(true);`
- `NationalSpire.Coop.CoopCoordinator.SendRun(string, object)`；输入表达式：`session.SendRun("run-host", new { epoch = session.World.Epoch, attempt = _attempt, resume = session.World.Run.ResumeCount, lobby = _lobby, load = session.NativeSave != null })`；返回值紧邻使用处：`ExpressionStatementSyntax: session.SendRun("run-host", new { epoch = session.World.Epoch, attempt = _attempt, resume = session.World.Run.ResumeCount, lobby = _lobby, load = session.NativeSave != null });`
- `NationalSpire.Coop.CoopNativeRun.Close()`；输入表达式：`Close()`；返回值紧邻使用处：`ExpressionStatementSyntax: Close();`
- `NationalSpire.Coop.CoopNativeRun.Fail(System.Exception)`；输入表达式：`Fail(new TimeoutException("等待队员开赛超时，检查点已保留。" + _waitingStage + "。请检查双方联机模组是否一致。"))`；返回值紧邻使用处：`ExpressionStatementSyntax: Fail(new TimeoutException("等待队员开赛超时，检查点已保留。" + _waitingStage + "。请检查双方联机模组是否一致。"));`
- `NationalSpire.Coop.CoopNativeRun.Host()`；输入表达式：`Host()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = Host()`
- `NationalSpire.Coop.CoopNativeRun.PumpPendingNetwork()`；输入表达式：`PumpPendingNetwork()`；返回值紧邻使用处：`ExpressionStatementSyntax: PumpPendingNetwork();`
- `NationalSpire.Coop.CoopNativeRun.WaitingStage()`；输入表达式：`WaitingStage()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = WaitingStage()`
- `NationalSpire.Coop.NativeLobbyApi.Local(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby)`；输入表达式：`NativeLobbyApi.Local(_start)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: NativeLobbyApi.Local(_start).Ready`
- `NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby)`；输入表达式：`NativeLobbyApi.Players(_load)`；返回值紧邻使用处：`IsPatternExpressionSyntax: NativeLobbyApi.Players(_load) is var loading`
- `NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby)`；输入表达式：`NativeLobbyApi.Players(_start)`；返回值紧邻使用处：`IsPatternExpressionSyntax: NativeLobbyApi.Players(_start) is var starting`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("coop.native.wait", new { host = session.Host, attempt = _attempt, stage })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("coop.native.wait", new { host = session.Host, attempt = _attempt, stage });`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`session.World.Run.Characters.ContainsKey(session.Self)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !session.World.Run.Characters.ContainsKey(session.Self)`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`loading.Where(p => p.Id != session.Self).All(p => p.Ready)`；返回值紧邻使用处：`BinaryExpressionSyntax: _load != null && NativeLobbyApi.Players(_load) is var loading && loading.Count == session.World!.Run!.Characters.Count && !loading.First(p => p.Id == session.Self).Ready                  && loading.Where(p => p.Id != session.Self).All(p => p.Ready)`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`starting.Where(p => p.Id != session.Self).All(p => p.Ready)`；返回值紧邻使用处：`BinaryExpressionSyntax: _start != null && NativeLobbyApi.Players(_start) is var starting && starting.Count == session.World!.Run!.Characters.Count && !NativeLobbyApi.Local(_start).Ready                  && starting.Where(p => p.Id != session.Self).All(p => p.Ready)`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`loading.First(p => p.Id == session.Self)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: loading.First(p => p.Id == session.Self).Ready`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`loading.Where(p => p.Id != session.Self)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: loading.Where(p => p.Id != session.Self).All`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`starting.Where(p => p.Id != session.Self)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: starting.Where(p => p.Id != session.Self).All`
- `System.TimeoutException.TimeoutException(string?)`；输入表达式：`new TimeoutException("等待队员开赛超时，检查点已保留。" + _waitingStage + "。请检查双方联机模组是否一致。")`；返回值紧邻使用处：`ArgumentSyntax: new TimeoutException("等待队员开赛超时，检查点已保留。" + _waitingStage + "。请检查双方联机模组是否一致。")`
- `System.TimeSpan.FromSeconds(long)`；输入表达式：`TimeSpan.FromSeconds(2)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateTime.UtcNow - _checkedStage > TimeSpan.FromSeconds(2)`
- `System.TimeSpan.FromSeconds(long)`；输入表达式：`TimeSpan.FromSeconds(4)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateTime.UtcNow - _announced > TimeSpan.FromSeconds(4)`
- `System.TimeSpan.FromSeconds(long)`；输入表达式：`TimeSpan.FromSeconds(90)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateTime.UtcNow - _began > TimeSpan.FromSeconds(90)`

**赋值（含属性/字段和局部值）：**

- `_` = `Host()`
- `_announced` = `DateTime.UtcNow`
- `_checkedStage` = `DateTime.UtcNow`
- `_waitingStage` = `stage`
- `NeedsPause` = `true`
- `Status` = `stage`

<a id="symbol-40773357613d"></a>

## `NationalSpire.Coop.CoopNativeRun.WaitingStage() — private string WaitingStage()`

来源：源码第 176 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.Update()`](CoopNativeRun.cs.md#symbol-f8b6c697410f)

**调用：** [`NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby)`](NativeLobbyApi.cs.md#symbol-92249f368b32)；[`NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby)`](NativeLobbyApi.cs.md#symbol-433695ce5c9e)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopMember.Name`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopNativeRun._entering`；`NationalSpire.Coop.CoopNativeRun._load`；`NationalSpire.Coop.CoopNativeRun._start`；`NationalSpire.Coop.CoopRun.Characters`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.NativeLobbyApi.Member.Id`；`NationalSpire.Coop.NativeLobbyApi.Member.Ready`；`NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby)`；`NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby)`；输入表达式：`NativeLobbyApi.Players(_load)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _load != null ? NativeLobbyApi.Players(_load) : null`
- `NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby)`；输入表达式：`NativeLobbyApi.Players(_start)`；返回值紧邻使用处：`ConditionalExpressionSyntax: _start != null ? NativeLobbyApi.Players(_start) : _load != null ? NativeLobbyApi.Players(_load) : null`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", waiting)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = string.Join("、", waiting)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`session.World.Members.FirstOrDefault(m => m.SteamId == p.Id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: session.World.Members.FirstOrDefault(m => m.SteamId == p.Id)?.Name`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`players.Where(p => !p.Ready).Select(p => session.World.Members.FirstOrDefault(m => m.SteamId == p.Id)?.Name ?? "队员")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = players.Where(p => !p.Ready).Select(p => session.World.Members.FirstOrDefault(m => m.SteamId == p.Id)?.Name ?? "队员")`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`players.Where(p => !p.Ready)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: players.Where(p => !p.Ready).Select`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5e85a7e716a1"></a>

## `NationalSpire.Coop.CoopNativeRun.Host() — private async Task Host()`

来源：源码第 187 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.Update()`](CoopNativeRun.cs.md#symbol-f8b6c697410f)

**调用：** [`NationalSpire.Coop.CoopNativeRun.Character()`](CoopNativeRun.cs.md#symbol-5f0977f165e0)；[`NationalSpire.Coop.CoopNativeRun.Decode(byte[])`](CoopNativeRun.cs.md#symbol-6a539dbdaec6)；[`NationalSpire.Coop.CoopNativeRun.Fail(System.Exception)`](CoopNativeRun.cs.md#symbol-fa50e38bdb28)；[`NationalSpire.Coop.CoopNativeRun.Validate(MegaCrit.Sts2.Core.Saves.SerializableRun)`](CoopNativeRun.cs.md#symbol-6504cc92be0b)；[`NationalSpire.Coop.ICoopNativePlatform.Host(MegaCrit.Sts2.Core.Multiplayer.NetHostGameService, int)`](CoopNativeRun.cs.md#symbol-2e2568167f2d)；[`NationalSpire.Coop.ICoopNativePlatform.Version()`](CoopNativeRun.cs.md#symbol-a3aab1a67801)；[`NationalSpire.Coop.NativeLobbyApi.AddLocal(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, MegaCrit.Sts2.Core.Unlocks.UnlockState, int)`](NativeLobbyApi.cs.md#symbol-896eb2d8b472)；[`NationalSpire.Coop.NativeLobbyApi.Service<T>(object?)`](NativeLobbyApi.cs.md#symbol-ca679536ff2b)；[`NationalSpire.Coop.NativeLobbyApi.Validate()`](NativeLobbyApi.cs.md#symbol-de1b7a4fe8ee)；`MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby.AddLocalHostPlayer()`；`MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby.LoadRunLobby(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.ILoadRunLobbyListener, MegaCrit.Sts2.Core.Saves.SerializableRun)`；`MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.SetLocalCharacter(MegaCrit.Sts2.Core.Models.CharacterModel)`；`MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.SetSeed(string?)`；`MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.StartRunLobby(MegaCrit.Sts2.Core.Runs.GameMode, MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.IStartRunLobbyListener, int)`；`MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.SyncAscensionChange(int)`；`MegaCrit.Sts2.Core.Multiplayer.NetHostGameService.Disconnect(MegaCrit.Sts2.Core.Entities.Multiplayer.NetError, bool)`；`MegaCrit.Sts2.Core.Multiplayer.NetHostGameService.DisconnectClient(ulong, MegaCrit.Sts2.Core.Entities.Multiplayer.NetError, bool)`；`object.ReferenceEquals(object?, object?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.NativeSave`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopNativeRun._attempt`；`NationalSpire.Coop.CoopNativeRun._began`；`NationalSpire.Coop.CoopNativeRun._busy`；`NationalSpire.Coop.CoopNativeRun._entering`；`NationalSpire.Coop.CoopNativeRun._generation`；`NationalSpire.Coop.CoopNativeRun._launched`；`NationalSpire.Coop.CoopNativeRun._load`；`NationalSpire.Coop.CoopNativeRun._lobby`；`NationalSpire.Coop.CoopNativeRun._platform`；`NationalSpire.Coop.CoopNativeRun._service`；`NationalSpire.Coop.CoopNativeRun._start`；`NationalSpire.Coop.CoopNativeRun._stopping`；`NationalSpire.Coop.CoopNativeRun.Character()`；`NationalSpire.Coop.CoopNativeRun.Decode(byte[])`；`NationalSpire.Coop.CoopNativeRun.Fail(System.Exception)`；`NationalSpire.Coop.CoopNativeRun.LastError`；`NationalSpire.Coop.CoopNativeRun.LoadListener`；`NationalSpire.Coop.CoopNativeRun.NeedsPause`；`NationalSpire.Coop.CoopNativeRun.PauseRequestedByHost`；`NationalSpire.Coop.CoopNativeRun.StartListener`；`NationalSpire.Coop.CoopNativeRun.Status`；`NationalSpire.Coop.CoopNativeRun.Validate(MegaCrit.Sts2.Core.Saves.SerializableRun)`；`NationalSpire.Coop.CoopRun.Ascension`；`NationalSpire.Coop.CoopRun.Attempt`；`NationalSpire.Coop.CoopRun.Characters`；`NationalSpire.Coop.CoopRun.Seed`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.ICoopNativePlatform.Host(MegaCrit.Sts2.Core.Multiplayer.NetHostGameService, int)`；`NationalSpire.Coop.ICoopNativePlatform.Version()`；`NationalSpire.Coop.NativeLobbyApi.AddLocal(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, MegaCrit.Sts2.Core.Unlocks.UnlockState, int)`；`NationalSpire.Coop.NativeLobbyApi.Service<T>(object?)`；`NationalSpire.Coop.NativeLobbyApi.Validate()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby.AddLocalHostPlayer()`；输入表达式：`_load.AddLocalHostPlayer()`；返回值紧邻使用处：`ExpressionStatementSyntax: _load.AddLocalHostPlayer();`
- `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby.LoadRunLobby(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.ILoadRunLobbyListener, MegaCrit.Sts2.Core.Saves.SerializableRun)`；输入表达式：`new(service, LoadListener, save)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _load = new(service, LoadListener, save)`
- `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.SetLocalCharacter(MegaCrit.Sts2.Core.Models.CharacterModel)`；输入表达式：`_start.SetLocalCharacter(Character())`；返回值紧邻使用处：`ExpressionStatementSyntax: _start.SetLocalCharacter(Character());`
- `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.SetSeed(string?)`；输入表达式：`_start.SetSeed(session.World.Run.Seed)`；返回值紧邻使用处：`ExpressionStatementSyntax: _start.SetSeed(session.World.Run.Seed);`
- `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.StartRunLobby(MegaCrit.Sts2.Core.Runs.GameMode, MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.IStartRunLobbyListener, int)`；输入表达式：`new(GameMode.Standard, service, StartListener, session.World.Run!.Characters.Count)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _start = new(GameMode.Standard, service, StartListener, session.World.Run!.Characters.Count)`
- `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.SyncAscensionChange(int)`；输入表达式：`_start.SyncAscensionChange(session.World.Run.Ascension)`；返回值紧邻使用处：`ExpressionStatementSyntax: _start.SyncAscensionChange(session.World.Run.Ascension);`
- `MegaCrit.Sts2.Core.Multiplayer.NetHostGameService.Disconnect(MegaCrit.Sts2.Core.Entities.Multiplayer.NetError, bool)`；输入表达式：`service.Disconnect(NetError.Quit)`；返回值紧邻使用处：`ExpressionStatementSyntax: service.Disconnect(NetError.Quit);`
- `MegaCrit.Sts2.Core.Multiplayer.NetHostGameService.DisconnectClient(ulong, MegaCrit.Sts2.Core.Entities.Multiplayer.NetError, bool)`；输入表达式：`service.DisconnectClient(id, NetError.Quit)`；返回值紧邻使用处：`ExpressionStatementSyntax: service.DisconnectClient(id, NetError.Quit);`
- `NationalSpire.Coop.CoopNativeRun.Character()`；输入表达式：`Character()`；返回值紧邻使用处：`ArgumentSyntax: Character()`
- `NationalSpire.Coop.CoopNativeRun.Decode(byte[])`；输入表达式：`Decode(bytes)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Decode(bytes)`
- `NationalSpire.Coop.CoopNativeRun.Fail(System.Exception)`；输入表达式：`Fail(e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Fail(e);`
- `NationalSpire.Coop.CoopNativeRun.Validate(MegaCrit.Sts2.Core.Saves.SerializableRun)`；输入表达式：`Validate(save)`；返回值紧邻使用处：`ExpressionStatementSyntax: Validate(save);`
- `NationalSpire.Coop.ICoopNativePlatform.Host(MegaCrit.Sts2.Core.Multiplayer.NetHostGameService, int)`；输入表达式：`_platform.Host(service, session.World.Run!.Characters.Count)`；返回值紧邻使用处：`AwaitExpressionSyntax: await _platform.Host(service, session.World.Run!.Characters.Count)`
- `NationalSpire.Coop.ICoopNativePlatform.Version()`；输入表达式：`_platform.Version()`；返回值紧邻使用处：`ArgumentSyntax: _platform.Version()`
- `NationalSpire.Coop.NativeLobbyApi.AddLocal(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, MegaCrit.Sts2.Core.Unlocks.UnlockState, int)`；输入表达式：`NativeLobbyApi.AddLocal(_start, UnlockState.all, 10)`；返回值紧邻使用处：`ExpressionStatementSyntax: NativeLobbyApi.AddLocal(_start, UnlockState.all, 10);`
- `NationalSpire.Coop.NativeLobbyApi.Service<T>(object?)`；输入表达式：`NativeLobbyApi.Service<NetHostGameService>(_platform.Version())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = NativeLobbyApi.Service<NetHostGameService>(_platform.Version())`
- `NationalSpire.Coop.NativeLobbyApi.Validate()`；输入表达式：`NativeLobbyApi.Validate()`；返回值紧邻使用处：`ExpressionStatementSyntax: NativeLobbyApi.Validate();`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(service, _service)`；返回值紧邻使用处：`BinaryExpressionSyntax: !_stopping && generation == _generation && ReferenceEquals(service, _service)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`session.World!.Run!.Characters.ContainsKey(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !session.World!.Run!.Characters.ContainsKey(id)`

**赋值（含属性/字段和局部值）：**

- `_attempt` = `session.World!.Run!.Attempt`
- `_began` = `DateTime.UtcNow`
- `_busy` = `false`
- `_busy` = `true`
- `_load` = `new(service, LoadListener, save)`
- `_lobby` = `lobbyId`
- `_service` = `service`
- `_start` = `new(GameMode.Standard, service, StartListener, session.World.Run!.Characters.Count)`
- `_stopping` = `false`
- `LastError` = `""`
- `NeedsPause` = `true`
- `PauseRequestedByHost` = `false`
- `service.ClientConnected` += `id => { if (!session.World!.Run!.Characters.ContainsKey(id)) service.DisconnectClient(id, NetError.Quit); }`
- `service.ClientDisconnected` += `(_, _) => { if (!_stopping && generation == _generation && ReferenceEquals(service, _service) && (_launched || _entering)) NeedsPause = true; }`
- `Status` = `"等待全体队员进入比赛"`

<a id="symbol-3f383e39c601"></a>

## `NationalSpire.Coop.CoopNativeRun.Message(NationalSpire.Coop.CoopWire) — public void Message(CoopWire wire)`

来源：源码第 218 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopNativeRun.Join(string, bool)`](CoopNativeRun.cs.md#symbol-a3ff2d717caf)；[`NationalSpire.Diagnostics.Record(string, object)`](../Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.Diagnostics.Redact(string)`](../Diagnostics.cs.md#symbol-f014e01c492a)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；`System.Text.Json.JsonElement.GetBoolean()`；`System.Text.Json.JsonElement.GetInt32()`；`System.Text.Json.JsonElement.GetProperty(string)`；`System.Text.Json.JsonElement.GetString()`；`System.Text.Json.JsonElement.GetUInt64()`；`System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`

**字段、属性、事件及方法组引用：** `<anonymous type: ulong sender, string error>.error`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopNativeRun._busy`；`NationalSpire.Coop.CoopNativeRun._launched`；`NationalSpire.Coop.CoopNativeRun._service`；`NationalSpire.Coop.CoopNativeRun._stopping`；`NationalSpire.Coop.CoopNativeRun.HasConnection`；`NationalSpire.Coop.CoopNativeRun.Join(string, bool)`；`NationalSpire.Coop.CoopNativeRun.LastError`；`NationalSpire.Coop.CoopNativeRun.NeedsPause`；`NationalSpire.Coop.CoopNativeRun.PauseRequestedByHost`；`NationalSpire.Coop.CoopNativeRun.Status`；`NationalSpire.Coop.CoopRun.Attempt`；`NationalSpire.Coop.CoopRun.Characters`；`NationalSpire.Coop.CoopRun.Phase`；`NationalSpire.Coop.CoopRun.ResumeCount`；`NationalSpire.Coop.CoopRuntime.Current`；`NationalSpire.Coop.CoopRuntime.ResumeRequired`；`NationalSpire.Coop.CoopWire.Kind`；`NationalSpire.Coop.CoopWire.Payload`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Owner`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.Diagnostics.Redact(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopNativeRun.Join(string, bool)`；输入表达式：`Join(value.GetProperty("lobby").GetString()!, value.GetProperty("load").GetBoolean())`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = Join(value.GetProperty("lobby").GetString()!, value.GetProperty("load").GetBoolean())`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("coop.native.remote-failure", new { sender, error = LastError })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("coop.native.remote-failure", new { sender, error = LastError });`
- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Diagnostics.Redact(error.Length > 2000 ? error[..2000] : error)`；返回值紧邻使用处：`AssignmentExpressionSyntax: LastError = Diagnostics.Redact(error.Length > 2000 ? error[..2000] : error)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`run.Characters.ContainsKey(session.Self)`；返回值紧邻使用处：`BinaryExpressionSyntax: wire.Kind == "run-host" && !session.Host && run.Characters.ContainsKey(session.Self)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`session.World.Members.Any(m => m.SteamId == sender)`；返回值紧邻使用处：`BinaryExpressionSyntax: wire.Kind == "run-failed" && session.World.Members.Any(m => m.SteamId == sender)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`session.World.Members.Any(m => m.SteamId == sender)`；返回值紧邻使用处：`BinaryExpressionSyntax: wire.Kind == "run-pause" && session.Host && run.Phase != "paused" && session.World.Members.Any(m => m.SteamId == sender)`
- `System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；输入表达式：`JsonDocument.Parse(envelope.RootElement.GetProperty("payload").GetString()!)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonDocument.Parse(envelope.RootElement.GetProperty("payload").GetString()!)`
- `System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；输入表达式：`JsonDocument.Parse(wire.Payload)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonDocument.Parse(wire.Payload)`
- `System.Text.Json.JsonElement.GetBoolean()`；输入表达式：`value.GetProperty("load").GetBoolean()`；返回值紧邻使用处：`ArgumentSyntax: value.GetProperty("load").GetBoolean()`
- `System.Text.Json.JsonElement.GetInt32()`；输入表达式：`resume.GetInt32()`；返回值紧邻使用处：`BinaryExpressionSyntax: resume.GetInt32() != run.ResumeCount`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`envelope.RootElement.GetProperty("payload")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: envelope.RootElement.GetProperty("payload").GetString`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`envelope.RootElement.GetProperty("sender")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: envelope.RootElement.GetProperty("sender").GetUInt64`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`value.GetProperty("attempt")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: value.GetProperty("attempt").GetString`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`value.GetProperty("error")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: value.GetProperty("error").GetString`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`value.GetProperty("load")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: value.GetProperty("load").GetBoolean`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`value.GetProperty("lobby")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: value.GetProperty("lobby").GetString`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`envelope.RootElement.GetProperty("payload").GetString()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: envelope.RootElement.GetProperty("payload").GetString()!`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`epoch.GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: epoch.GetString() != session.World.Epoch`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`value.GetProperty("attempt").GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: value.GetProperty("attempt").GetString() != run.Attempt`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`value.GetProperty("error").GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: value.GetProperty("error").GetString() ?? "队友连接失败"`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`value.GetProperty("lobby").GetString()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: value.GetProperty("lobby").GetString()!`
- `System.Text.Json.JsonElement.GetUInt64()`；输入表达式：`envelope.RootElement.GetProperty("sender").GetUInt64()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = envelope.RootElement.GetProperty("sender").GetUInt64()`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`value.TryGetProperty("epoch", out var epoch)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !value.TryGetProperty("epoch", out var epoch)`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`value.TryGetProperty("resume", out var resume)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !value.TryGetProperty("resume", out var resume)`

**赋值（含属性/字段和局部值）：**

- `_` = `Join(value.GetProperty("lobby").GetString()!, value.GetProperty("load").GetBoolean())`
- `LastError` = `Diagnostics.Redact(error.Length > 2000 ? error[..2000] : error)`
- `NeedsPause` = `true`
- `PauseRequestedByHost` = `true`
- `Status` = `"比赛连接失败：" + LastError`

<a id="symbol-a3ff2d717caf"></a>

## `NationalSpire.Coop.CoopNativeRun.Join(string, bool) — private async Task Join(string lobby, bool load)`

来源：源码第 239 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.Message(NationalSpire.Coop.CoopWire)`](CoopNativeRun.cs.md#symbol-3f383e39c601)

**调用：** [`NationalSpire.Coop.CoopCoordinator.WaitForReceived()`](CoopReception.cs.md#symbol-1cfc8ada58bd)；[`NationalSpire.Coop.CoopNativeRun.Character()`](CoopNativeRun.cs.md#symbol-5f0977f165e0)；[`NationalSpire.Coop.CoopNativeRun.Fail(System.Exception)`](CoopNativeRun.cs.md#symbol-fa50e38bdb28)；[`NationalSpire.Coop.CoopNativeRun.Validate(MegaCrit.Sts2.Core.Saves.SerializableRun)`](CoopNativeRun.cs.md#symbol-6504cc92be0b)；[`NationalSpire.Coop.ICoopNativePlatform.Join(MegaCrit.Sts2.Core.Multiplayer.NetClientGameService, string, System.Threading.CancellationToken)`](CoopNativeRun.cs.md#symbol-6666ab41f1e9)；[`NationalSpire.Coop.ICoopNativePlatform.Version()`](CoopNativeRun.cs.md#symbol-a3aab1a67801)；[`NationalSpire.Coop.NativeLobbyApi.Service<T>(object?)`](NativeLobbyApi.cs.md#symbol-ca679536ff2b)；[`NationalSpire.Coop.NativeLobbyApi.Validate()`](NativeLobbyApi.cs.md#symbol-de1b7a4fe8ee)；`MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo.ToString()`；`MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby.LoadRunLobby(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.ILoadRunLobbyListener, MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLoadJoinResponseMessage)`；`MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby.SetReady(bool)`；`MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.InitializeFromMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLobbyJoinResponseMessage)`；`MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.SetLocalCharacter(MegaCrit.Sts2.Core.Models.CharacterModel)`；`MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.SetReady(bool)`；`MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.StartRunLobby(MegaCrit.Sts2.Core.Runs.GameMode, MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.IStartRunLobbyListener, int)`；`MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLoadJoinRequestMessage.ClientLoadJoinRequestMessage()`；`MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLobbyJoinRequestMessage.ClientLobbyJoinRequestMessage()`；`MegaCrit.Sts2.Core.Multiplayer.NetClientGameService.RegisterMessageHandler<T>(MegaCrit.Sts2.Core.Multiplayer.Game.MessageHandlerDelegate<T>)`；`MegaCrit.Sts2.Core.Multiplayer.NetClientGameService.SendMessage<T>(T)`；`MegaCrit.Sts2.Core.Unlocks.UnlockState.ToSerializable()`；`object.ReferenceEquals(object?, object?)`；`System.IO.IOException.IOException(string?)`；`System.Threading.CancellationTokenSource.CancelAfter(System.TimeSpan)`；`System.Threading.CancellationTokenSource.CreateLinkedTokenSource(System.Threading.CancellationToken)`；`System.Threading.Tasks.Task.WaitAsync(System.Threading.CancellationToken)`；`System.Threading.Tasks.TaskCompletionSource.TaskCompletionSource()`；`System.Threading.Tasks.TaskCompletionSource.TrySetResult()`；`System.TimeSpan.FromSeconds(long)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.WaitForReceived()`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopNativeRun._attempt`；`NationalSpire.Coop.CoopNativeRun._began`；`NationalSpire.Coop.CoopNativeRun._busy`；`NationalSpire.Coop.CoopNativeRun._entering`；`NationalSpire.Coop.CoopNativeRun._generation`；`NationalSpire.Coop.CoopNativeRun._launched`；`NationalSpire.Coop.CoopNativeRun._lifetime`；`NationalSpire.Coop.CoopNativeRun._load`；`NationalSpire.Coop.CoopNativeRun._platform`；`NationalSpire.Coop.CoopNativeRun._service`；`NationalSpire.Coop.CoopNativeRun._start`；`NationalSpire.Coop.CoopNativeRun._stopping`；`NationalSpire.Coop.CoopNativeRun.Character()`；`NationalSpire.Coop.CoopNativeRun.Fail(System.Exception)`；`NationalSpire.Coop.CoopNativeRun.LastError`；`NationalSpire.Coop.CoopNativeRun.LoadListener`；`NationalSpire.Coop.CoopNativeRun.NeedsPause`；`NationalSpire.Coop.CoopNativeRun.PauseRequestedByHost`；`NationalSpire.Coop.CoopNativeRun.StartListener`；`NationalSpire.Coop.CoopNativeRun.Validate(MegaCrit.Sts2.Core.Saves.SerializableRun)`；`NationalSpire.Coop.CoopRun.Attempt`；`NationalSpire.Coop.CoopRun.Characters`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.ICoopNativePlatform.Join(MegaCrit.Sts2.Core.Multiplayer.NetClientGameService, string, System.Threading.CancellationToken)`；`NationalSpire.Coop.ICoopNativePlatform.Version()`；`NationalSpire.Coop.NativeLobbyApi.Service<T>(object?)`；`NationalSpire.Coop.NativeLobbyApi.Validate()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo.ToString()`；输入表达式：`error.ToString()`；返回值紧邻使用处：`ArgumentSyntax: error.ToString()`
- `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby.LoadRunLobby(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.ILoadRunLobbyListener, MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLoadJoinResponseMessage)`；输入表达式：`new(service, LoadListener, message)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _load = new(service, LoadListener, message)`
- `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby.SetReady(bool)`；输入表达式：`_load.SetReady(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: _load.SetReady(true);`
- `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.InitializeFromMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLobbyJoinResponseMessage)`；输入表达式：`_start.InitializeFromMessage(message)`；返回值紧邻使用处：`ExpressionStatementSyntax: _start.InitializeFromMessage(message);`
- `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.SetLocalCharacter(MegaCrit.Sts2.Core.Models.CharacterModel)`；输入表达式：`_start.SetLocalCharacter(Character())`；返回值紧邻使用处：`ExpressionStatementSyntax: _start.SetLocalCharacter(Character());`
- `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.SetReady(bool)`；输入表达式：`_start.SetReady(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: _start.SetReady(true);`
- `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.StartRunLobby(MegaCrit.Sts2.Core.Runs.GameMode, MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.IStartRunLobbyListener, int)`；输入表达式：`new(GameMode.Standard, service, StartListener, session.World!.Run!.Characters.Count)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _start = new(GameMode.Standard, service, StartListener, session.World!.Run!.Characters.Count)`
- `MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLoadJoinRequestMessage.ClientLoadJoinRequestMessage()`；输入表达式：`new ClientLoadJoinRequestMessage()`；返回值紧邻使用处：`ArgumentSyntax: new ClientLoadJoinRequestMessage()`
- `MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLobbyJoinRequestMessage.ClientLobbyJoinRequestMessage()`；输入表达式：`new ClientLobbyJoinRequestMessage { maxAscensionUnlocked = 10, unlockState = UnlockState.all.ToSerializable() }`；返回值紧邻使用处：`ArgumentSyntax: new ClientLobbyJoinRequestMessage { maxAscensionUnlocked = 10, unlockState = UnlockState.all.ToSerializable() }`
- `MegaCrit.Sts2.Core.Multiplayer.NetClientGameService.RegisterMessageHandler<T>(MegaCrit.Sts2.Core.Multiplayer.Game.MessageHandlerDelegate<T>)`；输入表达式：`service.RegisterMessageHandler<ClientLoadJoinResponseMessage>(async (message, _) =>              {                  try                  {                      await session.WaitForReceived();                      if (generation != _generation || !ReferenceEquals(service, _service)) return;                      _load = new(service, LoadListener, message); Validate(_load.Run); _load.SetReady(true);                  }                  catch (Exception e) { if (generation == _generation) Fail(e); }              })`；返回值紧邻使用处：`ExpressionStatementSyntax: service.RegisterMessageHandler<ClientLoadJoinResponseMessage>(async (message, _) =>              {                  try                  {                      await session.WaitForReceived();                      if (generation != _generation || !ReferenceEquals(service, _service)) return;                      _load = new(service, LoadListener, message); Validate(_load.Run); _load.SetReady(true);                  }                  catch (Exception e) { if (generation == _generation) Fail(e); }              });`
- `MegaCrit.Sts2.Core.Multiplayer.NetClientGameService.RegisterMessageHandler<T>(MegaCrit.Sts2.Core.Multiplayer.Game.MessageHandlerDelegate<T>)`；输入表达式：`service.RegisterMessageHandler<ClientLobbyJoinResponseMessage>(async (message, _) =>              {                  try                  {                      await session.WaitForReceived();                      if (generation != _generation || !ReferenceEquals(service, _service)) return;                      _start = new(GameMode.Standard, service, StartListener, session.World!.Run!.Characters.Count); _start.InitializeFromMessage(message); _start.SetLocalCharacter(Character()); _start.SetReady(true);                  }                  catch (Exception e) { if (generation == _generation) Fail(e); }              })`；返回值紧邻使用处：`ExpressionStatementSyntax: service.RegisterMessageHandler<ClientLobbyJoinResponseMessage>(async (message, _) =>              {                  try                  {                      await session.WaitForReceived();                      if (generation != _generation || !ReferenceEquals(service, _service)) return;                      _start = new(GameMode.Standard, service, StartListener, session.World!.Run!.Characters.Count); _start.InitializeFromMessage(message); _start.SetLocalCharacter(Character()); _start.SetReady(true);                  }                  catch (Exception e) { if (generation == _generation) Fail(e); }              });`
- `MegaCrit.Sts2.Core.Multiplayer.NetClientGameService.RegisterMessageHandler<T>(MegaCrit.Sts2.Core.Multiplayer.Game.MessageHandlerDelegate<T>)`；输入表达式：`service.RegisterMessageHandler<InitialGameInfoMessage>((_, _) => { })`；返回值紧邻使用处：`ExpressionStatementSyntax: service.RegisterMessageHandler<InitialGameInfoMessage>((_, _) => { });`
- `MegaCrit.Sts2.Core.Multiplayer.NetClientGameService.SendMessage<T>(T)`；输入表达式：`service.SendMessage(new ClientLoadJoinRequestMessage())`；返回值紧邻使用处：`ExpressionStatementSyntax: service.SendMessage(new ClientLoadJoinRequestMessage());`
- `MegaCrit.Sts2.Core.Multiplayer.NetClientGameService.SendMessage<T>(T)`；输入表达式：`service.SendMessage(new ClientLobbyJoinRequestMessage { maxAscensionUnlocked = 10, unlockState = UnlockState.all.ToSerializable() })`；返回值紧邻使用处：`ExpressionStatementSyntax: service.SendMessage(new ClientLobbyJoinRequestMessage { maxAscensionUnlocked = 10, unlockState = UnlockState.all.ToSerializable() });`
- `MegaCrit.Sts2.Core.Unlocks.UnlockState.ToSerializable()`；输入表达式：`UnlockState.all.ToSerializable()`；返回值紧邻使用处：`AssignmentExpressionSyntax: unlockState = UnlockState.all.ToSerializable()`
- `NationalSpire.Coop.CoopCoordinator.WaitForReceived()`；输入表达式：`session.WaitForReceived()`；返回值紧邻使用处：`AwaitExpressionSyntax: await session.WaitForReceived()`
- `NationalSpire.Coop.CoopNativeRun.Character()`；输入表达式：`Character()`；返回值紧邻使用处：`ArgumentSyntax: Character()`
- `NationalSpire.Coop.CoopNativeRun.Fail(System.Exception)`；输入表达式：`Fail(e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Fail(e);`
- `NationalSpire.Coop.CoopNativeRun.Validate(MegaCrit.Sts2.Core.Saves.SerializableRun)`；输入表达式：`Validate(_load.Run)`；返回值紧邻使用处：`ExpressionStatementSyntax: Validate(_load.Run);`
- `NationalSpire.Coop.ICoopNativePlatform.Join(MegaCrit.Sts2.Core.Multiplayer.NetClientGameService, string, System.Threading.CancellationToken)`；输入表达式：`_platform.Join(service, lobby, timeout.Token)`；返回值紧邻使用处：`AwaitExpressionSyntax: await _platform.Join(service, lobby, timeout.Token)`
- `NationalSpire.Coop.ICoopNativePlatform.Version()`；输入表达式：`_platform.Version()`；返回值紧邻使用处：`ArgumentSyntax: _platform.Version()`
- `NationalSpire.Coop.NativeLobbyApi.Service<T>(object?)`；输入表达式：`NativeLobbyApi.Service<NetClientGameService>(_platform.Version())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = NativeLobbyApi.Service<NetClientGameService>(_platform.Version())`
- `NationalSpire.Coop.NativeLobbyApi.Validate()`；输入表达式：`NativeLobbyApi.Validate()`；返回值紧邻使用处：`ExpressionStatementSyntax: NativeLobbyApi.Validate();`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(service, _service)`；返回值紧邻使用处：`BinaryExpressionSyntax: !_stopping && generation == _generation && ReferenceEquals(service, _service)`
- `object.ReferenceEquals(object?, object?)`；输入表达式：`ReferenceEquals(service, _service)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ReferenceEquals(service, _service)`
- `System.IO.IOException.IOException(string?)`；输入表达式：`new IOException(error.ToString())`；返回值紧邻使用处：`ThrowStatementSyntax: throw new IOException(error.ToString());`
- `System.Threading.CancellationTokenSource.CancelAfter(System.TimeSpan)`；输入表达式：`timeout.CancelAfter(TimeSpan.FromSeconds(30))`；返回值紧邻使用处：`ExpressionStatementSyntax: timeout.CancelAfter(TimeSpan.FromSeconds(30));`
- `System.Threading.CancellationTokenSource.CreateLinkedTokenSource(System.Threading.CancellationToken)`；输入表达式：`CancellationTokenSource.CreateLinkedTokenSource(_lifetime.Token)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CancellationTokenSource.CreateLinkedTokenSource(_lifetime.Token)`
- `System.Threading.Tasks.Task.WaitAsync(System.Threading.CancellationToken)`；输入表达式：`connected.Task.WaitAsync(timeout.Token)`；返回值紧邻使用处：`AwaitExpressionSyntax: await connected.Task.WaitAsync(timeout.Token)`
- `System.Threading.Tasks.TaskCompletionSource.TaskCompletionSource()`；输入表达式：`new TaskCompletionSource()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TaskCompletionSource()`
- `System.Threading.Tasks.TaskCompletionSource.TrySetResult()`；输入表达式：`connected.TrySetResult()`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => connected.TrySetResult()`
- `System.TimeSpan.FromSeconds(long)`；输入表达式：`TimeSpan.FromSeconds(30)`；返回值紧邻使用处：`ArgumentSyntax: TimeSpan.FromSeconds(30)`

**赋值（含属性/字段和局部值）：**

- `_attempt` = `session.World!.Run!.Attempt`
- `_began` = `DateTime.UtcNow`
- `_busy` = `false`
- `_busy` = `true`
- `_load` = `new(service, LoadListener, message)`
- `_service` = `service`
- `_start` = `new(GameMode.Standard, service, StartListener, session.World!.Run!.Characters.Count)`
- `_stopping` = `false`
- `LastError` = `""`
- `maxAscensionUnlocked` = `10`
- `NeedsPause` = `true`
- `PauseRequestedByHost` = `false`
- `service.ConnectedToHost` += `() => connected.TrySetResult()`
- `service.Disconnected` += `_ => { if (!_stopping && generation == _generation && ReferenceEquals(service, _service) && (_launched || _entering)) NeedsPause = true; }`
- `unlockState` = `UnlockState.all.ToSerializable()`

<a id="symbol-5f0977f165e0"></a>

## `NationalSpire.Coop.CoopNativeRun.Character() — private CharacterModel Character()`

来源：源码第 282 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.Host()`](CoopNativeRun.cs.md#symbol-5e85a7e716a1)；[`NationalSpire.Coop.CoopNativeRun.Join(string, bool)`](CoopNativeRun.cs.md#symbol-a3ff2d717caf)

**调用：** [`NationalSpire.GameBridge.Characters()`](../GameBridge.cs.md#symbol-1233494dda40)；[`NationalSpire.GameBridge.RandomChoice()`](../GameBridge.cs.md#symbol-e436ec882e7b)；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.RandomCharacterChoice`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRun.Characters`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.GameBridge.Characters()`；`NationalSpire.GameBridge.RandomChoice()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`c.Id.ToString()`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Id.ToString() == session.World.Run.Characters[session.Self]`
- `NationalSpire.GameBridge.Characters()`；输入表达式：`GameBridge.Characters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameBridge.Characters().Single`
- `NationalSpire.GameBridge.RandomChoice()`；输入表达式：`GameBridge.RandomChoice()`；返回值紧邻使用处：`ConditionalExpressionSyntax: session.World!.Run!.Characters[session.Self] == CareerEngine.RandomCharacterChoice          ? GameBridge.RandomChoice() : GameBridge.Characters().Single(c => c.Id.ToString() == session.World.Run.Characters[session.Self])`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`GameBridge.Characters().Single(c => c.Id.ToString() == session.World.Run.Characters[session.Self])`；返回值紧邻使用处：`ConditionalExpressionSyntax: session.World!.Run!.Characters[session.Self] == CareerEngine.RandomCharacterChoice          ? GameBridge.RandomChoice() : GameBridge.Characters().Single(c => c.Id.ToString() == session.World.Run.Characters[session.Self])`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e1fc04234566"></a>

## `NationalSpire.Coop.CoopNativeRun.Encode(MegaCrit.Sts2.Core.Saves.SerializableRun) — public static byte[] Encode(SerializableRun save)`

来源：源码第 284 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.Save(MegaCrit.Sts2.Core.Saves.SerializableRun)`](CoopNativeRun.cs.md#symbol-5825a51bfef3)

**调用：** `MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter.PacketWriter()`；`MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter.Write<T>(T)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter.PacketWriter()`；输入表达式：`new PacketWriter { WarnOnGrow = false }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PacketWriter { WarnOnGrow = false }`
- `MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter.Write<T>(T)`；输入表达式：`writer.Write(save)`；返回值紧邻使用处：`ExpressionStatementSyntax: writer.Write(save);`

**赋值（含属性/字段和局部值）：**

- `WarnOnGrow` = `false`

<a id="symbol-6a539dbdaec6"></a>

## `NationalSpire.Coop.CoopNativeRun.Decode(byte[]) — public static SerializableRun Decode(byte[] bytes)`

来源：源码第 286 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.Host()`](CoopNativeRun.cs.md#symbol-5e85a7e716a1)

**调用：** `MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader.PacketReader()`；`MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader.Read<T>()`；`MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader.Reset(byte[])`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader.PacketReader()`；输入表达式：`new PacketReader()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PacketReader()`
- `MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader.Read<T>()`；输入表达式：`reader.Read<SerializableRun>()`；返回值紧邻使用处：`ReturnStatementSyntax: return reader.Read<SerializableRun>();`
- `MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader.Reset(byte[])`；输入表达式：`reader.Reset(bytes)`；返回值紧邻使用处：`ExpressionStatementSyntax: reader.Reset(bytes);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6504cc92be0b"></a>

## `NationalSpire.Coop.CoopNativeRun.Validate(MegaCrit.Sts2.Core.Saves.SerializableRun) — private void Validate(SerializableRun save)`

来源：源码第 288 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.BeginRun()`](CoopNativeRun.cs.md#symbol-77d1b0a8ef74)；[`NationalSpire.Coop.CoopNativeRun.Host()`](CoopNativeRun.cs.md#symbol-5e85a7e716a1)；[`NationalSpire.Coop.CoopNativeRun.Join(string, bool)`](CoopNativeRun.cs.md#symbol-a3ff2d717caf)；[`NationalSpire.Coop.CoopNativeRun.Save(MegaCrit.Sts2.Core.Saves.SerializableRun)`](CoopNativeRun.cs.md#symbol-5825a51bfef3)

**调用：** `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`MegaCrit.Sts2.Core.Runs.RunState.FromSerializable(MegaCrit.Sts2.Core.Saves.SerializableRun)`；`System.Collections.Generic.IEnumerable<T>.Order<T>()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SequenceEqual<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.IO.InvalidDataException.InvalidDataException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRun.Ascension`；`NationalSpire.Coop.CoopRun.Characters`；`NationalSpire.Coop.CoopRun.Seed`；`NationalSpire.Coop.CoopWorld.Run`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`p.Character.Id.ToString()`；返回值紧邻使用处：`BinaryExpressionSyntax: run.Characters[p.NetId] != p.Character.Id.ToString()`
- `MegaCrit.Sts2.Core.Runs.RunState.FromSerializable(MegaCrit.Sts2.Core.Saves.SerializableRun)`；输入表达式：`RunState.FromSerializable(save)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RunState.FromSerializable(save)`
- `System.Collections.Generic.IEnumerable<T>.Order<T>()`；输入表达式：`run.Characters.Keys.Order()`；返回值紧邻使用处：`ArgumentSyntax: run.Characters.Keys.Order()`
- `System.Collections.Generic.IEnumerable<T>.Order<T>()`；输入表达式：`state.Players.Select(p => p.NetId).Order()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: state.Players.Select(p => p.NetId).Order().SequenceEqual`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`state.Players.Any(p => run.Characters[p.NetId] != p.Character.Id.ToString())`；返回值紧邻使用处：`BinaryExpressionSyntax: state.Rng.StringSeed != run.Seed || state.AscensionLevel != run.Ascension || !state.Players.Select(p => p.NetId).Order().SequenceEqual(run.Characters.Keys.Order())              || state.Players.Any(p => run.Characters[p.NetId] != p.Character.Id.ToString())`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`state.Players.Select(p => p.NetId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: state.Players.Select(p => p.NetId).Order`
- `System.Collections.Generic.IEnumerable<TSource>.SequenceEqual<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`state.Players.Select(p => p.NetId).Order().SequenceEqual(run.Characters.Keys.Order())`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !state.Players.Select(p => p.NetId).Order().SequenceEqual(run.Characters.Keys.Order())`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("原版对局与共同生涯绑定不一致。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("原版对局与共同生涯绑定不一致。");`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2d3e3dcdd4d4"></a>

## `NationalSpire.Coop.CoopNativeRun.ShouldAllowRunToBegin() — public async Task<bool> ShouldAllowRunToBegin()`

来源：源码第 294 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.BeginRun()`](CoopNativeRun.cs.md#symbol-77d1b0a8ef74)；[`NationalSpire.Coop.CoopNativeRun.BeginRun(string, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>)`](CoopNativeRun.cs.md#symbol-ddd22369fd06)；[`NationalSpire.Coop.CoopNativeRun.Callback(System.Reflection.MethodInfo, object?[])`](CoopNativeRun.cs.md#symbol-2cd18e0c472c)

**调用：** [`NationalSpire.Coop.CoopCoordinator.WaitForReceived()`](CoopReception.cs.md#symbol-1cfc8ada58bd)；[`NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby)`](NativeLobbyApi.cs.md#symbol-92249f368b32)；[`NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby)`](NativeLobbyApi.cs.md#symbol-433695ce5c9e)；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.RandomCharacterChoice`；`NationalSpire.Coop.CoopCoordinator.Full`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.WaitForReceived()`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopNativeRun._load`；`NationalSpire.Coop.CoopNativeRun._start`；`NationalSpire.Coop.CoopRun.Ascension`；`NationalSpire.Coop.CoopRun.Characters`；`NationalSpire.Coop.CoopRun.Phase`；`NationalSpire.Coop.CoopRun.Seed`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.NativeLobbyApi.Member.Character`；`NationalSpire.Coop.NativeLobbyApi.Member.Id`；`NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby)`；`NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`p.Character!.Id.ToString()`；返回值紧邻使用处：`BinaryExpressionSyntax: character == p.Character!.Id.ToString()`
- `NationalSpire.Coop.CoopCoordinator.WaitForReceived()`；输入表达式：`session.WaitForReceived()`；返回值紧邻使用处：`AwaitExpressionSyntax: await session.WaitForReceived()`
- `NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby)`；输入表达式：`NativeLobbyApi.Players(_load)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: NativeLobbyApi.Players(_load).Count`
- `NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby)`；输入表达式：`NativeLobbyApi.Players(_start)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: NativeLobbyApi.Players(_start).All`
- `NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby)`；输入表达式：`NativeLobbyApi.Players(_start)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: NativeLobbyApi.Players(_start).Count`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`run.Characters.TryGetValue(p.Id, out string? character)`；返回值紧邻使用处：`BinaryExpressionSyntax: run.Characters.TryGetValue(p.Id, out string? character) && (character == p.Character!.Id.ToString() || character == CareerEngine.RandomCharacterChoice && p.Character is MegaCrit.Sts2.Core.Models.Characters.RandomCharacter)`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`NativeLobbyApi.Players(_start).All(p => run.Characters.TryGetValue(p.Id, out string? character) && (character == p.Character!.Id.ToString() || character == CareerEngine.RandomCharacterChoice && p.Character is MegaCrit.Sts2.Core.Models.Characters.RandomCharacter))`；返回值紧邻使用处：`BinaryExpressionSyntax: NativeLobbyApi.Players(_start).Count == run.Characters.Count && NativeLobbyApi.Players(_start).All(p => run.Characters.TryGetValue(p.Id, out string? character) && (character == p.Character!.Id.ToString() || character == CareerEngine.RandomCharacterChoice && p.Character is MegaCrit.Sts2.Core.Models.Characters.RandomCharacter))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ddd22369fd06"></a>

## `NationalSpire.Coop.CoopNativeRun.BeginRun(string, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>) — public async void BeginRun(string seed, List<ActModel> acts, IReadOnlyList<ModifierModel> modifiers)`

来源：源码第 301 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.Callback(System.Reflection.MethodInfo, object?[])`](CoopNativeRun.cs.md#symbol-2cd18e0c472c)

**调用：** [`NationalSpire.Coop.CoopNativeRun.Fail(System.Exception)`](CoopNativeRun.cs.md#symbol-fa50e38bdb28)；[`NationalSpire.Coop.CoopNativeRun.Save(MegaCrit.Sts2.Core.Saves.SerializableRun)`](CoopNativeRun.cs.md#symbol-5825a51bfef3)；[`NationalSpire.Coop.CoopNativeRun.ShouldAllowRunToBegin()`](CoopNativeRun.cs.md#symbol-2d3e3dcdd4d4)；[`NationalSpire.Coop.ICoopNativePlatform.BeginNew(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>, string, int, System.Threading.CancellationToken)`](CoopNativeRun.cs.md#symbol-2ebc550752a9)；`MegaCrit.Sts2.Core.Runs.RunManager.ToSave(MegaCrit.Sts2.Core.Rooms.AbstractRoom?)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Threading.Tasks.TaskCompletionSource.TaskCompletionSource()`；`System.Threading.Tasks.TaskCompletionSource.TrySetResult()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopNativeRun._entering`；`NationalSpire.Coop.CoopNativeRun._entryCompleted`；`NationalSpire.Coop.CoopNativeRun._generation`；`NationalSpire.Coop.CoopNativeRun._launched`；`NationalSpire.Coop.CoopNativeRun._lifetime`；`NationalSpire.Coop.CoopNativeRun._platform`；`NationalSpire.Coop.CoopNativeRun._start`；`NationalSpire.Coop.CoopNativeRun.Fail(System.Exception)`；`NationalSpire.Coop.CoopNativeRun.Save(MegaCrit.Sts2.Core.Saves.SerializableRun)`；`NationalSpire.Coop.CoopNativeRun.ShouldAllowRunToBegin()`；`NationalSpire.Coop.CoopNativeRun.Status`；`NationalSpire.Coop.CoopRun.Ascension`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.ICoopNativePlatform.BeginNew(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>, string, int, System.Threading.CancellationToken)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Runs.RunManager.ToSave(MegaCrit.Sts2.Core.Rooms.AbstractRoom?)`；输入表达式：`RunManager.Instance.ToSave(null)`；返回值紧邻使用处：`ArgumentSyntax: RunManager.Instance.ToSave(null)`
- `NationalSpire.Coop.CoopNativeRun.Fail(System.Exception)`；输入表达式：`Fail(e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Fail(e);`
- `NationalSpire.Coop.CoopNativeRun.Save(MegaCrit.Sts2.Core.Saves.SerializableRun)`；输入表达式：`Save(RunManager.Instance.ToSave(null))`；返回值紧邻使用处：`ExpressionStatementSyntax: Save(RunManager.Instance.ToSave(null));`
- `NationalSpire.Coop.CoopNativeRun.ShouldAllowRunToBegin()`；输入表达式：`ShouldAllowRunToBegin()`；返回值紧邻使用处：`AwaitExpressionSyntax: await ShouldAllowRunToBegin()`
- `NationalSpire.Coop.ICoopNativePlatform.BeginNew(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>, string, int, System.Threading.CancellationToken)`；输入表达式：`_platform.BeginNew(lobby, acts, modifiers, seed, session.World!.Run!.Ascension, _lifetime.Token)`；返回值紧邻使用处：`AwaitExpressionSyntax: await _platform.BeginNew(lobby, acts, modifiers, seed, session.World!.Run!.Ascension, _lifetime.Token)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("队伍开赛条件发生变化。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("队伍开赛条件发生变化。");`
- `System.Threading.Tasks.TaskCompletionSource.TaskCompletionSource()`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _entryCompleted = new()`
- `System.Threading.Tasks.TaskCompletionSource.TrySetResult()`；输入表达式：`completed.TrySetResult()`；返回值紧邻使用处：`ExpressionStatementSyntax: completed.TrySetResult();`

**赋值（含属性/字段和局部值）：**

- `_entering` = `false`
- `_entering` = `true`
- `_entryCompleted` = `new()`
- `_launched` = `true`
- `_start` = `null`
- `Status` = `"比赛进行中"`

<a id="symbol-77d1b0a8ef74"></a>

## `NationalSpire.Coop.CoopNativeRun.BeginRun() — public async void BeginRun()`

来源：源码第 320 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.Callback(System.Reflection.MethodInfo, object?[])`](CoopNativeRun.cs.md#symbol-2cd18e0c472c)

**调用：** [`NationalSpire.Coop.CoopCoordinator.WaitForReceived()`](CoopReception.cs.md#symbol-1cfc8ada58bd)；[`NationalSpire.Coop.CoopNativeRun.Fail(System.Exception)`](CoopNativeRun.cs.md#symbol-fa50e38bdb28)；[`NationalSpire.Coop.CoopNativeRun.ShouldAllowRunToBegin()`](CoopNativeRun.cs.md#symbol-2d3e3dcdd4d4)；[`NationalSpire.Coop.CoopNativeRun.Validate(MegaCrit.Sts2.Core.Saves.SerializableRun)`](CoopNativeRun.cs.md#symbol-6504cc92be0b)；[`NationalSpire.Coop.ICoopNativePlatform.BeginSaved(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby, System.Threading.CancellationToken)`](CoopNativeRun.cs.md#symbol-0623ae9e3550)；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Threading.Tasks.TaskCompletionSource.TaskCompletionSource()`；`System.Threading.Tasks.TaskCompletionSource.TrySetResult()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.WaitForReceived()`；`NationalSpire.Coop.CoopNativeRun._entering`；`NationalSpire.Coop.CoopNativeRun._entryCompleted`；`NationalSpire.Coop.CoopNativeRun._generation`；`NationalSpire.Coop.CoopNativeRun._launched`；`NationalSpire.Coop.CoopNativeRun._lifetime`；`NationalSpire.Coop.CoopNativeRun._load`；`NationalSpire.Coop.CoopNativeRun._platform`；`NationalSpire.Coop.CoopNativeRun.Fail(System.Exception)`；`NationalSpire.Coop.CoopNativeRun.ShouldAllowRunToBegin()`；`NationalSpire.Coop.CoopNativeRun.Status`；`NationalSpire.Coop.CoopNativeRun.Validate(MegaCrit.Sts2.Core.Saves.SerializableRun)`；`NationalSpire.Coop.ICoopNativePlatform.BeginSaved(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby, System.Threading.CancellationToken)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCoordinator.WaitForReceived()`；输入表达式：`session.WaitForReceived()`；返回值紧邻使用处：`AwaitExpressionSyntax: await session.WaitForReceived()`
- `NationalSpire.Coop.CoopNativeRun.Fail(System.Exception)`；输入表达式：`Fail(e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Fail(e);`
- `NationalSpire.Coop.CoopNativeRun.ShouldAllowRunToBegin()`；输入表达式：`ShouldAllowRunToBegin()`；返回值紧邻使用处：`AwaitExpressionSyntax: await ShouldAllowRunToBegin()`
- `NationalSpire.Coop.CoopNativeRun.Validate(MegaCrit.Sts2.Core.Saves.SerializableRun)`；输入表达式：`Validate(lobby.Run)`；返回值紧邻使用处：`ExpressionStatementSyntax: Validate(lobby.Run);`
- `NationalSpire.Coop.ICoopNativePlatform.BeginSaved(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby, System.Threading.CancellationToken)`；输入表达式：`_platform.BeginSaved(lobby, _lifetime.Token)`；返回值紧邻使用处：`AwaitExpressionSyntax: await _platform.BeginSaved(lobby, _lifetime.Token)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("队伍尚未全部连接。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("队伍尚未全部连接。");`
- `System.Threading.Tasks.TaskCompletionSource.TaskCompletionSource()`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _entryCompleted = new()`
- `System.Threading.Tasks.TaskCompletionSource.TrySetResult()`；输入表达式：`completed.TrySetResult()`；返回值紧邻使用处：`ExpressionStatementSyntax: completed.TrySetResult();`

**赋值（含属性/字段和局部值）：**

- `_entering` = `false`
- `_entering` = `true`
- `_entryCompleted` = `new()`
- `_launched` = `true`
- `_load` = `null`
- `Status` = `"比赛已恢复"`

<a id="symbol-5825a51bfef3"></a>

## `NationalSpire.Coop.CoopNativeRun.Save(MegaCrit.Sts2.Core.Saves.SerializableRun) — public void Save(SerializableRun save)`

来源：源码第 340 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.BeginRun(string, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>)`](CoopNativeRun.cs.md#symbol-ddd22369fd06)；[`NationalSpire.Coop.CoopSavePatch.Prefix(MegaCrit.Sts2.Core.Saves.SerializableRun, bool, ref System.Threading.Tasks.Task)`](CoopRuntime.cs.md#symbol-5743aede4fef)

**调用：** [`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`](CoopCoordinator.cs.md#symbol-e1dfe22e8221)；[`NationalSpire.Coop.CoopJson.Hash(byte[])`](CoopData.cs.md#symbol-ca6c9ee59a2a)；[`NationalSpire.Coop.CoopNativeRun.Encode(MegaCrit.Sts2.Core.Saves.SerializableRun)`](CoopNativeRun.cs.md#symbol-e1fc04234566)；[`NationalSpire.Coop.CoopNativeRun.Validate(MegaCrit.Sts2.Core.Saves.SerializableRun)`](CoopNativeRun.cs.md#symbol-6504cc92be0b)；[`NationalSpire.Coop.CoopWorld.RunCheckpoint()`](CoopData.cs.md#symbol-37c5b2e81f81)；[`NationalSpire.Diagnostics.Record(string, object)`](../Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.Diagnostics.RecordMatch(NationalSpire.Coop.CoopWorld, string, object?, bool)`](../MatchDiagnostics.cs.md#symbol-2f83ebe4626e)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `<anonymous type: bool Host, string attempt, string phase, string reason>.attempt`；`<anonymous type: bool Host, string attempt, string phase, string reason>.phase`；`<anonymous type: bool Host, string attempt, string phase, string reason>.reason`；`<anonymous type: int checkpointBytes, int CurrentActIndex, long RunTime, int visited, int[] hp>.checkpointBytes`；`<anonymous type: int checkpointBytes, int CurrentActIndex, long RunTime, int visited, int[] hp>.hp`；`<anonymous type: int checkpointBytes, int CurrentActIndex, long RunTime, int visited, int[] hp>.visited`；`<anonymous type: int checkpointBytes, string hash, long revision>.checkpointBytes`；`<anonymous type: int checkpointBytes, string hash, long revision>.hash`；`<anonymous type: int checkpointBytes, string hash, long revision>.revision`；`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.NativeSave`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopJson.Hash(byte[])`；`NationalSpire.Coop.CoopNativeRun.Encode(MegaCrit.Sts2.Core.Saves.SerializableRun)`；`NationalSpire.Coop.CoopNativeRun.Validate(MegaCrit.Sts2.Core.Saves.SerializableRun)`；`NationalSpire.Coop.CoopRun.Attempt`；`NationalSpire.Coop.CoopRun.Phase`；`NationalSpire.Coop.CoopWorld.Revision`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.CoopWorld.RunCheckpoint()`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.Diagnostics.RecordMatch(NationalSpire.Coop.CoopWorld, string, object?, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；输入表达式：`session.Commit(next, bytes)`；返回值紧邻使用处：`ExpressionStatementSyntax: session.Commit(next, bytes);`
- `NationalSpire.Coop.CoopJson.Hash(byte[])`；输入表达式：`CoopJson.Hash(bytes)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: hash = CoopJson.Hash(bytes)`
- `NationalSpire.Coop.CoopNativeRun.Encode(MegaCrit.Sts2.Core.Saves.SerializableRun)`；输入表达式：`Encode(save)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Encode(save)`
- `NationalSpire.Coop.CoopNativeRun.Validate(MegaCrit.Sts2.Core.Saves.SerializableRun)`；输入表达式：`Validate(save)`；返回值紧邻使用处：`ExpressionStatementSyntax: Validate(save);`
- `NationalSpire.Coop.CoopWorld.RunCheckpoint()`；输入表达式：`session.World.RunCheckpoint()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = session.World.RunCheckpoint()`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("coop.autosave.skipped", new { session.Host, attempt = session.World?.Run?.Attempt, phase = session.World?.Run?.Phase, reason = !session.Host ? "client" : session.World?.Run == null ? "no-run" : "paused" })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("coop.autosave.skipped", new { session.Host, attempt = session.World?.Run?.Attempt, phase = session.World?.Run?.Phase, reason = !session.Host ? "client" : session.World?.Run == null ? "no-run" : "paused" });`
- `NationalSpire.Diagnostics.RecordMatch(NationalSpire.Coop.CoopWorld, string, object?, bool)`；输入表达式：`Diagnostics.RecordMatch(session.World, "autosave-committed", new { checkpointBytes = bytes.Length, hash = CoopJson.Hash(bytes), revision = session.World.Revision })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.RecordMatch(session.World, "autosave-committed", new { checkpointBytes = bytes.Length, hash = CoopJson.Hash(bytes), revision = session.World.Revision });`
- `NationalSpire.Diagnostics.RecordMatch(NationalSpire.Coop.CoopWorld, string, object?, bool)`；输入表达式：`Diagnostics.RecordMatch(session.World, "autosave-entry", new { checkpointBytes = session.NativeSave?.Length ?? 0,              save.CurrentActIndex, save.RunTime, visited = save.VisitedMapCoords.Count, hp = save.Players.Select(p => p.CurrentHp).ToArray() })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.RecordMatch(session.World, "autosave-entry", new { checkpointBytes = session.NativeSave?.Length ?? 0,              save.CurrentActIndex, save.RunTime, visited = save.VisitedMapCoords.Count, hp = save.Players.Select(p => p.CurrentHp).ToArray() });`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`save.Players.Select(p => p.CurrentHp)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: save.Players.Select(p => p.CurrentHp).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`save.Players.Select(p => p.CurrentHp).ToArray()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: hp = save.Players.Select(p => p.CurrentHp).ToArray()`

**赋值（含属性/字段和局部值）：**

- `next.Run!.Phase` = `"running"`

<a id="symbol-fa50e38bdb28"></a>

## `NationalSpire.Coop.CoopNativeRun.Fail(System.Exception) — private void Fail(Exception e)`

来源：源码第 351 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.BeginRun()`](CoopNativeRun.cs.md#symbol-77d1b0a8ef74)；[`NationalSpire.Coop.CoopNativeRun.BeginRun(string, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>)`](CoopNativeRun.cs.md#symbol-ddd22369fd06)；[`NationalSpire.Coop.CoopNativeRun.Host()`](CoopNativeRun.cs.md#symbol-5e85a7e716a1)；[`NationalSpire.Coop.CoopNativeRun.Join(string, bool)`](CoopNativeRun.cs.md#symbol-a3ff2d717caf)；[`NationalSpire.Coop.CoopNativeRun.Update()`](CoopNativeRun.cs.md#symbol-f8b6c697410f)

**调用：** [`NationalSpire.Coop.CoopCoordinator.SendRun(string, object)`](CoopCoordinator.cs.md#symbol-99375ad602b4)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](../Diagnostics.cs.md#symbol-cb39203375a5)；[`NationalSpire.Diagnostics.Redact(string)`](../Diagnostics.cs.md#symbol-f014e01c492a)

**字段、属性、事件及方法组引用：** `<anonymous type: string epoch, string attempt, int resume, string error>.attempt`；`<anonymous type: string epoch, string attempt, int resume, string error>.epoch`；`<anonymous type: string epoch, string attempt, int resume, string error>.error`；`<anonymous type: string epoch, string attempt, int resume, string error>.resume`；`NationalSpire.Coop.CoopCoordinator.SendRun(string, object)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopNativeRun._failed`；`NationalSpire.Coop.CoopNativeRun.LastError`；`NationalSpire.Coop.CoopNativeRun.NeedsPause`；`NationalSpire.Coop.CoopNativeRun.Status`；`NationalSpire.Coop.CoopRun.Attempt`；`NationalSpire.Coop.CoopRun.ResumeCount`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Diagnostics.Error(string, System.Exception)`；`NationalSpire.Diagnostics.Redact(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCoordinator.SendRun(string, object)`；输入表达式：`session.SendRun("run-failed", new { epoch = session.World.Epoch, attempt = run.Attempt, resume = run.ResumeCount, error = LastError })`；返回值紧邻使用处：`ExpressionStatementSyntax: session.SendRun("run-failed", new { epoch = session.World.Epoch, attempt = run.Attempt, resume = run.ResumeCount, error = LastError });`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("coop.native", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("coop.native", e);`
- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Diagnostics.Redact(e.Message)`；返回值紧邻使用处：`AssignmentExpressionSyntax: LastError = Diagnostics.Redact(e.Message)`

**赋值（含属性/字段和局部值）：**

- `_failed` = `true`
- `LastError` = `Diagnostics.Redact(e.Message)`
- `NeedsPause` = `true`
- `Status` = `"比赛连接失败：" + LastError`

<a id="symbol-c8afc67dbfe3"></a>

## `NationalSpire.Coop.CoopNativeRun.Close() — public void Close()`

来源：源码第 358 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.Update()`](CoopNativeRun.cs.md#symbol-f8b6c697410f)；[`NationalSpire.Coop.CoopRuntime._Process(double)`](CoopRuntime.cs.md#symbol-ec1513bd09b1)；[`NationalSpire.Coop.CoopRuntime.Disconnect()`](CoopRuntime.cs.md#symbol-a4550fd42c36)；[`NationalSpire.Coop.CoopRuntime.PauseCore(string)`](CoopRuntime.cs.md#symbol-60fe2cb26a8e)

**调用：** `MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService.Disconnect(MegaCrit.Sts2.Core.Entities.Multiplayer.NetError, bool)`；`MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby.CleanUp(bool, MegaCrit.Sts2.Core.Entities.Multiplayer.NetError)`；`MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.CleanUp(bool, MegaCrit.Sts2.Core.Entities.Multiplayer.NetError)`；`System.Threading.CancellationTokenSource.Cancel()`；`System.Threading.CancellationTokenSource.CancellationTokenSource()`；`System.Threading.CancellationTokenSource.Dispose()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopNativeRun._busy`；`NationalSpire.Coop.CoopNativeRun._checkedStage`；`NationalSpire.Coop.CoopNativeRun._entering`；`NationalSpire.Coop.CoopNativeRun._failed`；`NationalSpire.Coop.CoopNativeRun._generation`；`NationalSpire.Coop.CoopNativeRun._launched`；`NationalSpire.Coop.CoopNativeRun._lifetime`；`NationalSpire.Coop.CoopNativeRun._load`；`NationalSpire.Coop.CoopNativeRun._lobby`；`NationalSpire.Coop.CoopNativeRun._service`；`NationalSpire.Coop.CoopNativeRun._start`；`NationalSpire.Coop.CoopNativeRun._stopping`；`NationalSpire.Coop.CoopNativeRun._waitingStage`；`NationalSpire.Coop.CoopNativeRun.NeedsPause`；`NationalSpire.Coop.CoopNativeRun.PauseRequestedByHost`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService.Disconnect(MegaCrit.Sts2.Core.Entities.Multiplayer.NetError, bool)`；输入表达式：`service.Disconnect(NetError.Quit)`；返回值紧邻使用处：`ExpressionStatementSyntax: service.Disconnect(NetError.Quit);`
- `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby.CleanUp(bool, MegaCrit.Sts2.Core.Entities.Multiplayer.NetError)`；输入表达式：`.CleanUp(false)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _load?.CleanUp(false)`
- `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.CleanUp(bool, MegaCrit.Sts2.Core.Entities.Multiplayer.NetError)`；输入表达式：`.CleanUp(false)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _start?.CleanUp(false)`
- `System.Threading.CancellationTokenSource.Cancel()`；输入表达式：`_lifetime.Cancel()`；返回值紧邻使用处：`ExpressionStatementSyntax: _lifetime.Cancel();`
- `System.Threading.CancellationTokenSource.CancellationTokenSource()`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _lifetime = new()`
- `System.Threading.CancellationTokenSource.Dispose()`；输入表达式：`_lifetime.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: _lifetime.Dispose();`

**赋值（含属性/字段和局部值）：**

- `_busy` = `_failed = _entering = NeedsPause = PauseRequestedByHost = false`
- `_checkedStage` = `default`
- `_entering` = `NeedsPause = PauseRequestedByHost = false`
- `_failed` = `_entering = NeedsPause = PauseRequestedByHost = false`
- `_launched` = `_busy = _failed = _entering = NeedsPause = PauseRequestedByHost = false`
- `_lifetime` = `new()`
- `_load` = `null`
- `_lobby` = `""`
- `_service` = `null`
- `_start` = `null`
- `_stopping` = `true`
- `_waitingStage` = `""`
- `NeedsPause` = `PauseRequestedByHost = false`
- `PauseRequestedByHost` = `false`

<a id="symbol-9053b1c2c84a"></a>

## `NationalSpire.Coop.CoopNativeRun.PlayerChanged(NationalSpire.Coop.NativeLobbyApi.Member, bool) — private void PlayerChanged(NativeLobbyApi.Member player, bool isRandomCharacterResolution)`

来源：源码第 367 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.Callback(System.Reflection.MethodInfo, object?[])`](CoopNativeRun.cs.md#symbol-2cd18e0c472c)

**调用：** [`NationalSpire.Coop.CoopCoordinator.ApplyReceived(System.Action)`](CoopReception.cs.md#symbol-f7e7dbbfc94b)；`MegaCrit.Sts2.Core.Models.ModelId.ToString()`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.RandomCharacterChoice`；`NationalSpire.Coop.CoopCoordinator.ApplyReceived(System.Action)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopMember.Character`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopNativeRun._generation`；`NationalSpire.Coop.CoopRun.Attempt`；`NationalSpire.Coop.CoopRun.Characters`；`NationalSpire.Coop.CoopRun.ResumeCount`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.NativeLobbyApi.Member.Character`；`NationalSpire.Coop.NativeLobbyApi.Member.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Models.ModelId.ToString()`；输入表达式：`player.Character.Id.ToString()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = player.Character.Id.ToString()`
- `NationalSpire.Coop.CoopCoordinator.ApplyReceived(System.Action)`；输入表达式：`session.ApplyReceived(() =>          {          if (generation != _generation || session.World?.Epoch != epoch || session.World.Run is not { } run || run.Attempt != attempt || run.ResumeCount != resume || run.Characters.GetValueOrDefault(player.Id) != CareerEngine.RandomCharacterChoice) return;          // 原版大厅已统一确定结果，存档只记录实际角色，恢复时不再随机。          run.Characters[player.Id] = character;          var member = session.World.Members.Single(m => m.SteamId == player.Id); member.Character = character;          })`；返回值紧邻使用处：`ExpressionStatementSyntax: session.ApplyReceived(() =>          {          if (generation != _generation || session.World?.Epoch != epoch || session.World.Run is not { } run || run.Attempt != attempt || run.ResumeCount != resume || run.Characters.GetValueOrDefault(player.Id) != CareerEngine.RandomCharacterChoice) return;          // 原版大厅已统一确定结果，存档只记录实际角色，恢复时不再随机。          run.Characters[player.Id] = character;          var member = session.World.Members.Single(m => m.SteamId == player.Id); member.Character = character;          });`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`session.World.Members.Single(m => m.SteamId == player.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = session.World.Members.Single(m => m.SteamId == player.Id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`run.Characters.GetValueOrDefault(player.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: run.Characters.GetValueOrDefault(player.Id) != CareerEngine.RandomCharacterChoice`

**赋值（含属性/字段和局部值）：**

- `member.Character` = `character`
- `run.Characters[player.Id]` = `character`
