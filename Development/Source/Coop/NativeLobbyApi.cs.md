# Coop/NativeLobbyApi.cs

[返回文件依赖索引](../../SOURCE_MAP.md)

源码 SHA-256：`D72F0F0024BB4C47F452C3A85B7AC1406352188F214ADA05EA5E81B096C3E71A`。来源：[源码](../../../Coop/NativeLobbyApi.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Coop.NativeLobbyApi`、`NationalSpire.Coop.NativeLobbyApi.Member`、`NationalSpire.Coop.NativeLobbyListener`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly Dictionary<(Type, string), MemberInfo> Members = [];
```

<a id="symbol-dc3d59409e04"></a>

## `NationalSpire.Coop.NativeLobbyApi.Find(System.Type, string) — private static MemberInfo Find(Type type, string name)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.NativeLobbyApi.Read(object, string)`](NativeLobbyApi.cs.md#symbol-01ff70538942)；[`NationalSpire.Coop.NativeLobbyApi.Validate()`](NativeLobbyApi.cs.md#symbol-de1b7a4fe8ee)；[`NationalSpire.Coop.NativeLobbyApi.Write(object, string, object)`](NativeLobbyApi.cs.md#symbol-2c25ad3060af)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.MissingMemberException.MissingMemberException(string?, string?)`；`System.Type.GetField(string)`；`System.Type.GetProperty(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.NativeLobbyApi.Members`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`Members.TryGetValue((type, name), out var found)`；返回值紧邻使用处：`IfStatementSyntax: if (Members.TryGetValue((type, name), out var found)) return found;`
- `System.MissingMemberException.MissingMemberException(string?, string?)`；输入表达式：`new MissingMemberException(type.FullName, name)`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new MissingMemberException(type.FullName, name)`
- `System.Type.GetField(string)`；输入表达式：`type.GetField(name)`；返回值紧邻使用处：`BinaryExpressionSyntax: type.GetField(name)             ?? throw new MissingMemberException(type.FullName, name)`
- `System.Type.GetProperty(string)`；输入表达式：`type.GetProperty(name)`；返回值紧邻使用处：`CastExpressionSyntax: (MemberInfo?)type.GetProperty(name)`

**赋值（含属性/字段和局部值）：**

- `Members[(type, name)]` = `(MemberInfo?)type.GetProperty(name) ?? type.GetField(name)             ?? throw new MissingMemberException(type.FullName, name)`

<a id="symbol-01ff70538942"></a>

## `NationalSpire.Coop.NativeLobbyApi.Read(object, string) — private static object? Read(object value, string name)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.NativeLobbyApi.Local(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby)`](NativeLobbyApi.cs.md#symbol-81508394bacc)；[`NationalSpire.Coop.NativeLobbyApi.Player(object, bool)`](NativeLobbyApi.cs.md#symbol-60a2df09ad65)；[`NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby)`](NativeLobbyApi.cs.md#symbol-92249f368b32)；[`NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby)`](NativeLobbyApi.cs.md#symbol-433695ce5c9e)

**调用：** [`NationalSpire.Coop.NativeLobbyApi.Find(System.Type, string)`](NativeLobbyApi.cs.md#symbol-dc3d59409e04)；`object.GetType()`；`System.NotSupportedException.NotSupportedException()`；`System.Reflection.FieldInfo.GetValue(object?)`；`System.Reflection.PropertyInfo.GetValue(object?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.NativeLobbyApi.Find(System.Type, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.NativeLobbyApi.Find(System.Type, string)`；输入表达式：`Find(value.GetType(), name)`；返回值紧邻使用处：`SwitchExpressionSyntax: Find(value.GetType(), name) switch     { PropertyInfo p => p.GetValue(value), FieldInfo f => f.GetValue(value), _ => throw new NotSupportedException() }`
- `object.GetType()`；输入表达式：`value.GetType()`；返回值紧邻使用处：`ArgumentSyntax: value.GetType()`
- `System.NotSupportedException.NotSupportedException()`；输入表达式：`new NotSupportedException()`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new NotSupportedException()`
- `System.Reflection.FieldInfo.GetValue(object?)`；输入表达式：`f.GetValue(value)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: FieldInfo f => f.GetValue(value)`
- `System.Reflection.PropertyInfo.GetValue(object?)`；输入表达式：`p.GetValue(value)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: PropertyInfo p => p.GetValue(value)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2c25ad3060af"></a>

## `NationalSpire.Coop.NativeLobbyApi.Write(object, string, object) — private static void Write(object value, string name, object content)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.NativeLobbyApi.JoinRequest(MegaCrit.Sts2.Core.Unlocks.UnlockState, int)`](NativeLobbyApi.cs.md#symbol-44f62ee35a7d)

**调用：** [`NationalSpire.Coop.NativeLobbyApi.Find(System.Type, string)`](NativeLobbyApi.cs.md#symbol-dc3d59409e04)；`object.GetType()`；`System.Reflection.FieldInfo.SetValue(object?, object?)`；`System.Reflection.PropertyInfo.SetValue(object?, object?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.NativeLobbyApi.Find(System.Type, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.NativeLobbyApi.Find(System.Type, string)`；输入表达式：`Find(value.GetType(), name)`；返回值紧邻使用处：`SwitchStatementSyntax: switch (Find(value.GetType(), name))         { case PropertyInfo p: p.SetValue(value, content); break; case FieldInfo f: f.SetValue(value, content); break; }`
- `object.GetType()`；输入表达式：`value.GetType()`；返回值紧邻使用处：`ArgumentSyntax: value.GetType()`
- `System.Reflection.FieldInfo.SetValue(object?, object?)`；输入表达式：`f.SetValue(value, content)`；返回值紧邻使用处：`ExpressionStatementSyntax: f.SetValue(value, content);`
- `System.Reflection.PropertyInfo.SetValue(object?, object?)`；输入表达式：`p.SetValue(value, content)`；返回值紧邻使用处：`ExpressionStatementSyntax: p.SetValue(value, content);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-60a2df09ad65"></a>

## `NationalSpire.Coop.NativeLobbyApi.Player(object, bool) — public static Member Player(object player, bool full = true)`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.Callback(System.Reflection.MethodInfo, object?[])`](CoopNativeRun.cs.md#symbol-2cd18e0c472c)；[`NationalSpire.Coop.NativeLobbyApi.Local(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby)`](NativeLobbyApi.cs.md#symbol-81508394bacc)；[`NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby)`](NativeLobbyApi.cs.md#symbol-92249f368b32)；[`NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby)`](NativeLobbyApi.cs.md#symbol-433695ce5c9e)

**调用：** [`NationalSpire.Coop.NativeLobbyApi.Read(object, string)`](NativeLobbyApi.cs.md#symbol-01ff70538942)；`NationalSpire.Coop.NativeLobbyApi.Member.Member(ulong, bool, MegaCrit.Sts2.Core.Models.CharacterModel?, MegaCrit.Sts2.Core.Unlocks.SerializableUnlockState?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.NativeLobbyApi.Read(object, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.NativeLobbyApi.Member.Member(ulong, bool, MegaCrit.Sts2.Core.Models.CharacterModel?, MegaCrit.Sts2.Core.Unlocks.SerializableUnlockState?)`；输入表达式：`new((ulong)Read(player, "id")!, (bool)Read(player, "isReady")!,         full ? (CharacterModel)Read(player, "character")! : null, full ? (SerializableUnlockState)Read(player, "unlockState")! : null)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new((ulong)Read(player, "id")!, (bool)Read(player, "isReady")!,         full ? (CharacterModel)Read(player, "character")! : null, full ? (SerializableUnlockState)Read(player, "unlockState")! : null)`
- `NationalSpire.Coop.NativeLobbyApi.Read(object, string)`；输入表达式：`Read(player, "character")`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Read(player, "character")!`
- `NationalSpire.Coop.NativeLobbyApi.Read(object, string)`；输入表达式：`Read(player, "id")`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Read(player, "id")!`
- `NationalSpire.Coop.NativeLobbyApi.Read(object, string)`；输入表达式：`Read(player, "isReady")`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Read(player, "isReady")!`
- `NationalSpire.Coop.NativeLobbyApi.Read(object, string)`；输入表达式：`Read(player, "unlockState")`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Read(player, "unlockState")!`

**赋值（含属性/字段和局部值）：**


<a id="symbol-433695ce5c9e"></a>

## `NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby) — public static IReadOnlyList<Member> Players(StartRunLobby lobby)`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.ShouldAllowRunToBegin()`](CoopNativeRun.cs.md#symbol-2d3e3dcdd4d4)；[`NationalSpire.Coop.CoopNativeRun.Update()`](CoopNativeRun.cs.md#symbol-f8b6c697410f)；[`NationalSpire.Coop.CoopNativeRun.WaitingStage()`](CoopNativeRun.cs.md#symbol-40773357613d)；[`NationalSpire.Coop.CoopSteamRunPlatform.BeginNew(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>, string, int, System.Threading.CancellationToken)`](CoopNativeRun.cs.md#symbol-b889ef6fb033)

**调用：** [`NationalSpire.Coop.NativeLobbyApi.Player(object, bool)`](NativeLobbyApi.cs.md#symbol-60a2df09ad65)；[`NationalSpire.Coop.NativeLobbyApi.Read(object, string)`](NativeLobbyApi.cs.md#symbol-01ff70538942)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.IEnumerable.Cast<TResult>()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.NativeLobbyApi.Player(object, bool)`；`NationalSpire.Coop.NativeLobbyApi.Read(object, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.NativeLobbyApi.Player(object, bool)`；输入表达式：`Player(p)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => Player(p)`
- `NationalSpire.Coop.NativeLobbyApi.Read(object, string)`；输入表达式：`Read(lobby, "Players")`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Read(lobby, "Players")!`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`((IEnumerable)Read(lobby, "Players")!).Cast<object>().Select(p => Player(p))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ((IEnumerable)Read(lobby, "Players")!).Cast<object>().Select(p => Player(p)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`((IEnumerable)Read(lobby, "Players")!).Cast<object>().Select(p => Player(p)).ToList()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ((IEnumerable)Read(lobby, "Players")!).Cast<object>().Select(p => Player(p)).ToList()`
- `System.Collections.IEnumerable.Cast<TResult>()`；输入表达式：`((IEnumerable)Read(lobby, "Players")!).Cast<object>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ((IEnumerable)Read(lobby, "Players")!).Cast<object>().Select`

**赋值（含属性/字段和局部值）：**


<a id="symbol-81508394bacc"></a>

## `NationalSpire.Coop.NativeLobbyApi.Local(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby) — public static Member Local(StartRunLobby lobby)`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.Update()`](CoopNativeRun.cs.md#symbol-f8b6c697410f)；[`NationalSpire.Coop.CoopSteamRunPlatform.BeginNew(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>, string, int, System.Threading.CancellationToken)`](CoopNativeRun.cs.md#symbol-b889ef6fb033)

**调用：** [`NationalSpire.Coop.NativeLobbyApi.Player(object, bool)`](NativeLobbyApi.cs.md#symbol-60a2df09ad65)；[`NationalSpire.Coop.NativeLobbyApi.Read(object, string)`](NativeLobbyApi.cs.md#symbol-01ff70538942)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.NativeLobbyApi.Player(object, bool)`；`NationalSpire.Coop.NativeLobbyApi.Read(object, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.NativeLobbyApi.Player(object, bool)`；输入表达式：`Player(Read(lobby, "LocalPlayer")!)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Player(Read(lobby, "LocalPlayer")!)`
- `NationalSpire.Coop.NativeLobbyApi.Read(object, string)`；输入表达式：`Read(lobby, "LocalPlayer")`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Read(lobby, "LocalPlayer")!`

**赋值（含属性/字段和局部值）：**


<a id="symbol-92249f368b32"></a>

## `NationalSpire.Coop.NativeLobbyApi.Players(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby) — public static IReadOnlyList<Member> Players(LoadRunLobby lobby)`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.ShouldAllowRunToBegin()`](CoopNativeRun.cs.md#symbol-2d3e3dcdd4d4)；[`NationalSpire.Coop.CoopNativeRun.Update()`](CoopNativeRun.cs.md#symbol-f8b6c697410f)；[`NationalSpire.Coop.CoopNativeRun.WaitingStage()`](CoopNativeRun.cs.md#symbol-40773357613d)

**调用：** [`NationalSpire.Coop.NativeLobbyApi.Player(object, bool)`](NativeLobbyApi.cs.md#symbol-60a2df09ad65)；[`NationalSpire.Coop.NativeLobbyApi.Read(object, string)`](NativeLobbyApi.cs.md#symbol-01ff70538942)；[`NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`](../RuntimeApi.cs.md#symbol-8426661c18c8)；[`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`](../RuntimeApi.cs.md#symbol-65f56c93bd1a)；`NationalSpire.Coop.NativeLobbyApi.Member.Member(ulong, bool, MegaCrit.Sts2.Core.Models.CharacterModel?, MegaCrit.Sts2.Core.Unlocks.SerializableUnlockState?)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.IEnumerable.Cast<TResult>()`；`System.Reflection.PropertyInfo.GetValue(object?)`；`System.Type.GetProperty(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.NativeLobbyApi.Player(object, bool)`；`NationalSpire.Coop.NativeLobbyApi.Read(object, string)`；`NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.NativeLobbyApi.Member.Member(ulong, bool, MegaCrit.Sts2.Core.Models.CharacterModel?, MegaCrit.Sts2.Core.Unlocks.SerializableUnlockState?)`；输入表达式：`new Member(id, (bool)RuntimeApi.Invoke(ready, lobby, id)!)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => new Member(id, (bool)RuntimeApi.Invoke(ready, lobby, id)!)`
- `NationalSpire.Coop.NativeLobbyApi.Player(object, bool)`；输入表达式：`Player(p, false)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => Player(p, false)`
- `NationalSpire.Coop.NativeLobbyApi.Read(object, string)`；输入表达式：`Read(lobby, "ConnectedPlayerIds")`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Read(lobby, "ConnectedPlayerIds")!`
- `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；输入表达式：`RuntimeApi.Bind(typeof(LoadRunLobby), "IsPlayerReady", false, typeof(ulong))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RuntimeApi.Bind(typeof(LoadRunLobby), "IsPlayerReady", false, typeof(ulong))`
- `NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`；输入表达式：`RuntimeApi.Invoke(ready, lobby, id)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: RuntimeApi.Invoke(ready, lobby, id)!`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`((IEnumerable)players.GetValue(lobby)!).Cast<object>().Select(p => Player(p, false))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ((IEnumerable)players.GetValue(lobby)!).Cast<object>().Select(p => Player(p, false)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`((IEnumerable)Read(lobby, "ConnectedPlayerIds")!).Cast<ulong>().Select(id => new Member(id, (bool)RuntimeApi.Invoke(ready, lobby, id)!))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ((IEnumerable)Read(lobby, "ConnectedPlayerIds")!).Cast<ulong>().Select(id => new Member(id, (bool)RuntimeApi.Invoke(ready, lobby, id)!)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`((IEnumerable)players.GetValue(lobby)!).Cast<object>().Select(p => Player(p, false)).ToList()`；返回值紧邻使用处：`ReturnStatementSyntax: return ((IEnumerable)players.GetValue(lobby)!).Cast<object>().Select(p => Player(p, false)).ToList();`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`((IEnumerable)Read(lobby, "ConnectedPlayerIds")!).Cast<ulong>().Select(id => new Member(id, (bool)RuntimeApi.Invoke(ready, lobby, id)!)).ToList()`；返回值紧邻使用处：`ReturnStatementSyntax: return ((IEnumerable)Read(lobby, "ConnectedPlayerIds")!).Cast<ulong>().Select(id => new Member(id, (bool)RuntimeApi.Invoke(ready, lobby, id)!)).ToList();`
- `System.Collections.IEnumerable.Cast<TResult>()`；输入表达式：`((IEnumerable)players.GetValue(lobby)!).Cast<object>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ((IEnumerable)players.GetValue(lobby)!).Cast<object>().Select`
- `System.Collections.IEnumerable.Cast<TResult>()`；输入表达式：`((IEnumerable)Read(lobby, "ConnectedPlayerIds")!).Cast<ulong>()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ((IEnumerable)Read(lobby, "ConnectedPlayerIds")!).Cast<ulong>().Select`
- `System.Reflection.PropertyInfo.GetValue(object?)`；输入表达式：`players.GetValue(lobby)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: players.GetValue(lobby)!`
- `System.Type.GetProperty(string)`；输入表达式：`typeof(LoadRunLobby).GetProperty("Players")`；返回值紧邻使用处：`IsPatternExpressionSyntax: typeof(LoadRunLobby).GetProperty("Players") is { } players`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f07766b19164"></a>

## `NationalSpire.Coop.NativeLobbyApi.StartConstructor() — private static ConstructorInfo StartConstructor()`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.NativeLobbyApi.CreateStart(MegaCrit.Sts2.Core.Runs.GameMode, MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.IStartRunLobbyListener, int)`](NativeLobbyApi.cs.md#symbol-d1fab72a18ae)；[`NationalSpire.Coop.NativeLobbyApi.Validate()`](NativeLobbyApi.cs.md#symbol-de1b7a4fe8ee)

**调用：** `System.MissingMethodException.MissingMethodException(string?, string?)`；`System.Type.GetConstructor(System.Type[])`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.MissingMethodException.MissingMethodException(string?, string?)`；输入表达式：`new MissingMethodException(typeof(StartRunLobby).FullName, ".ctor")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new MissingMethodException(typeof(StartRunLobby).FullName, ".ctor")`
- `System.Type.GetConstructor(System.Type[])`；输入表达式：`typeof(StartRunLobby).GetConstructor(         [typeof(GameMode), typeof(bool), typeof(INetGameService), typeof(IStartRunLobbyListener), typeof(int)])`；返回值紧邻使用处：`BinaryExpressionSyntax: typeof(StartRunLobby).GetConstructor(         [typeof(GameMode), typeof(bool), typeof(INetGameService), typeof(IStartRunLobbyListener), typeof(int)])         ?? typeof(StartRunLobby).GetConstructor([typeof(GameMode), typeof(INetGameService), typeof(IStartRunLobbyListener), typeof(int)])         ?? throw new MissingMethodException(typeof(StartRunLobby).FullName, ".ctor")`
- `System.Type.GetConstructor(System.Type[])`；输入表达式：`typeof(StartRunLobby).GetConstructor([typeof(GameMode), typeof(INetGameService), typeof(IStartRunLobbyListener), typeof(int)])`；返回值紧邻使用处：`BinaryExpressionSyntax: typeof(StartRunLobby).GetConstructor([typeof(GameMode), typeof(INetGameService), typeof(IStartRunLobbyListener), typeof(int)])         ?? throw new MissingMethodException(typeof(StartRunLobby).FullName, ".ctor")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d1fab72a18ae"></a>

## `NationalSpire.Coop.NativeLobbyApi.CreateStart(MegaCrit.Sts2.Core.Runs.GameMode, MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.IStartRunLobbyListener, int) — public static StartRunLobby CreateStart(GameMode mode, INetGameService service, IStartRunLobbyListener listener, int members)`

来源：源码第 49 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.Host()`](CoopNativeRun.cs.md#symbol-5e85a7e716a1)；[`NationalSpire.Coop.CoopNativeRun.Join(string, bool)`](CoopNativeRun.cs.md#symbol-a3ff2d717caf)

**调用：** [`NationalSpire.Coop.NativeLobbyApi.StartConstructor()`](NativeLobbyApi.cs.md#symbol-f07766b19164)；`System.Reflection.ConstructorInfo.Invoke(object?[]?)`；`System.Reflection.MethodBase.GetParameters()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.NativeLobbyApi.StartConstructor()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.NativeLobbyApi.StartConstructor()`；输入表达式：`StartConstructor()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = StartConstructor()`
- `System.Reflection.ConstructorInfo.Invoke(object?[]?)`；输入表达式：`constructor.Invoke(constructor.GetParameters().Length == 5             ? [mode, false, service, listener, members] : [mode, service, listener, members])`；返回值紧邻使用处：`CastExpressionSyntax: (StartRunLobby)constructor.Invoke(constructor.GetParameters().Length == 5             ? [mode, false, service, listener, members] : [mode, service, listener, members])`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`constructor.GetParameters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: constructor.GetParameters().Length`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f10712477c49"></a>

## `NationalSpire.Coop.NativeLobbyApi.AddLocalMethod() — private static MethodInfo AddLocalMethod()`

来源：源码第 55 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.NativeLobbyApi.AddLocal(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, MegaCrit.Sts2.Core.Unlocks.UnlockState, int)`](NativeLobbyApi.cs.md#symbol-896eb2d8b472)；[`NationalSpire.Coop.NativeLobbyApi.Validate()`](NativeLobbyApi.cs.md#symbol-de1b7a4fe8ee)

**调用：** [`NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`](../RuntimeApi.cs.md#symbol-8426661c18c8)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Reflection.MethodBase.GetParameters()`；`System.Type.GetMethods()`

**字段、属性、事件及方法组引用：** `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；输入表达式：`RuntimeApi.Bind(typeof(StartRunLobby), "AddLocalHostPlayer", false, typeof(UnlockState), typeof(int), typeof(int))`；返回值紧邻使用处：`ConditionalExpressionSyntax: typeof(StartRunLobby).GetMethods().Any(m => m.Name == "AddLocalHostPlayer"         && m.GetParameters().Length >= 3 && m.GetParameters()[2].ParameterType == typeof(int))         ? RuntimeApi.Bind(typeof(StartRunLobby), "AddLocalHostPlayer", false, typeof(UnlockState), typeof(int), typeof(int))         : RuntimeApi.Bind(typeof(StartRunLobby), "AddLocalHostPlayer", false, typeof(UnlockState), typeof(int))`
- `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；输入表达式：`RuntimeApi.Bind(typeof(StartRunLobby), "AddLocalHostPlayer", false, typeof(UnlockState), typeof(int))`；返回值紧邻使用处：`ConditionalExpressionSyntax: typeof(StartRunLobby).GetMethods().Any(m => m.Name == "AddLocalHostPlayer"         && m.GetParameters().Length >= 3 && m.GetParameters()[2].ParameterType == typeof(int))         ? RuntimeApi.Bind(typeof(StartRunLobby), "AddLocalHostPlayer", false, typeof(UnlockState), typeof(int), typeof(int))         : RuntimeApi.Bind(typeof(StartRunLobby), "AddLocalHostPlayer", false, typeof(UnlockState), typeof(int))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`typeof(StartRunLobby).GetMethods().Any(m => m.Name == "AddLocalHostPlayer"         && m.GetParameters().Length >= 3 && m.GetParameters()[2].ParameterType == typeof(int))`；返回值紧邻使用处：`ConditionalExpressionSyntax: typeof(StartRunLobby).GetMethods().Any(m => m.Name == "AddLocalHostPlayer"         && m.GetParameters().Length >= 3 && m.GetParameters()[2].ParameterType == typeof(int))         ? RuntimeApi.Bind(typeof(StartRunLobby), "AddLocalHostPlayer", false, typeof(UnlockState), typeof(int), typeof(int))         : RuntimeApi.Bind(typeof(StartRunLobby), "AddLocalHostPlayer", false, typeof(UnlockState), typeof(int))`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`m.GetParameters()`；返回值紧邻使用处：`ElementAccessExpressionSyntax: m.GetParameters()[2]`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`m.GetParameters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: m.GetParameters().Length`
- `System.Type.GetMethods()`；输入表达式：`typeof(StartRunLobby).GetMethods()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: typeof(StartRunLobby).GetMethods().Any`

**赋值（含属性/字段和局部值）：**


<a id="symbol-896eb2d8b472"></a>

## `NationalSpire.Coop.NativeLobbyApi.AddLocal(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, MegaCrit.Sts2.Core.Unlocks.UnlockState, int) — public static void AddLocal(StartRunLobby lobby, UnlockState unlocks, int ascension)`

来源：源码第 59 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.Host()`](CoopNativeRun.cs.md#symbol-5e85a7e716a1)

**调用：** [`NationalSpire.Coop.NativeLobbyApi.AddLocalMethod()`](NativeLobbyApi.cs.md#symbol-f10712477c49)；[`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`](../RuntimeApi.cs.md#symbol-65f56c93bd1a)；`System.Reflection.MethodBase.GetParameters()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.NativeLobbyApi.AddLocalMethod()`；`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.NativeLobbyApi.AddLocalMethod()`；输入表达式：`AddLocalMethod()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AddLocalMethod()`
- `NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`；输入表达式：`RuntimeApi.Invoke(add, lobby, unlocks, ascension, 5)`；返回值紧邻使用处：`ExpressionStatementSyntax: RuntimeApi.Invoke(add, lobby, unlocks, ascension, 5);`
- `NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`；输入表达式：`RuntimeApi.Invoke(add, lobby, unlocks, ascension)`；返回值紧邻使用处：`ExpressionStatementSyntax: RuntimeApi.Invoke(add, lobby, unlocks, ascension);`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`add.GetParameters()`；返回值紧邻使用处：`ElementAccessExpressionSyntax: add.GetParameters()[2]`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`add.GetParameters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: add.GetParameters().Length`

**赋值（含属性/字段和局部值）：**


<a id="symbol-44f62ee35a7d"></a>

## `NationalSpire.Coop.NativeLobbyApi.JoinRequest(MegaCrit.Sts2.Core.Unlocks.UnlockState, int) — public static ClientLobbyJoinRequestMessage JoinRequest(UnlockState unlocks, int ascension)`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.Join(string, bool)`](CoopNativeRun.cs.md#symbol-a3ff2d717caf)

**调用：** [`NationalSpire.Coop.NativeLobbyApi.Write(object, string, object)`](NativeLobbyApi.cs.md#symbol-2c25ad3060af)；`MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLobbyJoinRequestMessage.ClientLobbyJoinRequestMessage()`；`MegaCrit.Sts2.Core.Unlocks.UnlockState.ToSerializable()`；`object.GetType()`；`System.Type.GetField(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.NativeLobbyApi.Write(object, string, object)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLobbyJoinRequestMessage.ClientLobbyJoinRequestMessage()`；输入表达式：`new ClientLobbyJoinRequestMessage { unlockState = unlocks.ToSerializable() }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ClientLobbyJoinRequestMessage { unlockState = unlocks.ToSerializable() }`
- `MegaCrit.Sts2.Core.Unlocks.UnlockState.ToSerializable()`；输入表达式：`unlocks.ToSerializable()`；返回值紧邻使用处：`AssignmentExpressionSyntax: unlockState = unlocks.ToSerializable()`
- `NationalSpire.Coop.NativeLobbyApi.Write(object, string, object)`；输入表达式：`Write(request, "maxAscensionUnlocked", ascension)`；返回值紧邻使用处：`ExpressionStatementSyntax: Write(request, "maxAscensionUnlocked", ascension);`
- `NationalSpire.Coop.NativeLobbyApi.Write(object, string, object)`；输入表达式：`Write(request, "maxBlitzAscension", 5)`；返回值紧邻使用处：`ExpressionStatementSyntax: Write(request, "maxBlitzAscension", 5);`
- `NationalSpire.Coop.NativeLobbyApi.Write(object, string, object)`；输入表达式：`Write(request, "maxStandardAscension", ascension)`；返回值紧邻使用处：`ExpressionStatementSyntax: Write(request, "maxStandardAscension", ascension);`
- `object.GetType()`；输入表达式：`request.GetType()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: request.GetType().GetField`
- `System.Type.GetField(string)`；输入表达式：`request.GetType().GetField("maxAscensionUnlocked")`；返回值紧邻使用处：`BinaryExpressionSyntax: request.GetType().GetField("maxAscensionUnlocked") != null`

**赋值（含属性/字段和局部值）：**

- `unlockState` = `unlocks.ToSerializable()`

<a id="symbol-2824b2a36794"></a>

## `NationalSpire.Coop.NativeLobbyApi.SetCharacter(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, MegaCrit.Sts2.Core.Models.CharacterModel) — public static void SetCharacter(StartRunLobby lobby, CharacterModel character)`

来源：源码第 73 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.Host()`](CoopNativeRun.cs.md#symbol-5e85a7e716a1)；[`NationalSpire.Coop.CoopNativeRun.Join(string, bool)`](CoopNativeRun.cs.md#symbol-a3ff2d717caf)

**调用：** [`NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`](../RuntimeApi.cs.md#symbol-8426661c18c8)；[`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`](../RuntimeApi.cs.md#symbol-65f56c93bd1a)

**字段、属性、事件及方法组引用：** `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；输入表达式：`RuntimeApi.Bind(typeof(StartRunLobby), "SetLocalCharacter", false, typeof(CharacterModel))`；返回值紧邻使用处：`ArgumentSyntax: RuntimeApi.Bind(typeof(StartRunLobby), "SetLocalCharacter", false, typeof(CharacterModel))`
- `NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`；输入表达式：`RuntimeApi.Invoke(RuntimeApi.Bind(typeof(StartRunLobby), "SetLocalCharacter", false, typeof(CharacterModel)), lobby, character)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>         RuntimeApi.Invoke(RuntimeApi.Bind(typeof(StartRunLobby), "SetLocalCharacter", false, typeof(CharacterModel)), lobby, character)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f172506c2760"></a>

## `NationalSpire.Coop.NativeLobbyApi.DisconnectMethod() — private static MethodInfo DisconnectMethod()`

来源：源码第 75 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.NativeLobbyApi.Disconnect(MegaCrit.Sts2.Core.Multiplayer.NetHostGameService, ulong, MegaCrit.Sts2.Core.Entities.Multiplayer.NetError)`](NativeLobbyApi.cs.md#symbol-48def683ca9b)；[`NationalSpire.Coop.NativeLobbyApi.Validate()`](NativeLobbyApi.cs.md#symbol-de1b7a4fe8ee)

**调用：** [`NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`](../RuntimeApi.cs.md#symbol-8426661c18c8)

**字段、属性、事件及方法组引用：** `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；输入表达式：`RuntimeApi.Bind(typeof(NetHostGameService), "DisconnectClient", false,         typeof(ulong), typeof(NetError), typeof(bool))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => RuntimeApi.Bind(typeof(NetHostGameService), "DisconnectClient", false,         typeof(ulong), typeof(NetError), typeof(bool))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-48def683ca9b"></a>

## `NationalSpire.Coop.NativeLobbyApi.Disconnect(MegaCrit.Sts2.Core.Multiplayer.NetHostGameService, ulong, MegaCrit.Sts2.Core.Entities.Multiplayer.NetError) — public static void Disconnect(NetHostGameService service, ulong player, NetError error)`

来源：源码第 77 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.Host()`](CoopNativeRun.cs.md#symbol-5e85a7e716a1)

**调用：** [`NationalSpire.Coop.NativeLobbyApi.DisconnectMethod()`](NativeLobbyApi.cs.md#symbol-f172506c2760)；[`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`](../RuntimeApi.cs.md#symbol-65f56c93bd1a)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.NativeLobbyApi.DisconnectMethod()`；`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.NativeLobbyApi.DisconnectMethod()`；输入表达式：`DisconnectMethod()`；返回值紧邻使用处：`ArgumentSyntax: DisconnectMethod()`
- `NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`；输入表达式：`RuntimeApi.Invoke(DisconnectMethod(), service, player, error, false)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>         RuntimeApi.Invoke(DisconnectMethod(), service, player, error, false)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9d261ef08b5d"></a>

## `NationalSpire.Coop.NativeLobbyApi.MultiplayerStart(System.Type, System.Type) — public static MethodInfo MultiplayerStart(Type acts, Type modifiers)`

来源：源码第 79 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCompatibility.Check(bool)`](CoopCompatibility.cs.md#symbol-c71e5d5de570)；[`NationalSpire.Coop.CoopSteamRunPlatform.BeginNew(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>, string, int, System.Threading.CancellationToken)`](CoopNativeRun.cs.md#symbol-b889ef6fb033)

**调用：** [`NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`](../RuntimeApi.cs.md#symbol-8426661c18c8)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Reflection.MethodBase.GetParameters()`；`System.Type.GetMethods()`

**字段、属性、事件及方法组引用：** `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；输入表达式：`RuntimeApi.Bind(typeof(NGame), "StartNewMultiplayerRun", false, typeof(List<Player>), typeof(StartRunLobby),                 typeof(bool), acts, modifiers, typeof(string), typeof(int))`；返回值紧邻使用处：`ReturnStatementSyntax: return RuntimeApi.Bind(typeof(NGame), "StartNewMultiplayerRun", false, typeof(List<Player>), typeof(StartRunLobby),                 typeof(bool), acts, modifiers, typeof(string), typeof(int));`
- `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；输入表达式：`RuntimeApi.Bind(typeof(NGame), "StartNewMultiplayerRun", false, typeof(StartRunLobby), typeof(bool),             acts, modifiers, typeof(string), typeof(int))`；返回值紧邻使用处：`ReturnStatementSyntax: return RuntimeApi.Bind(typeof(NGame), "StartNewMultiplayerRun", false, typeof(StartRunLobby), typeof(bool),             acts, modifiers, typeof(string), typeof(int));`
- `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；输入表达式：`RuntimeApi.Bind(typeof(StartRunLobby), "GeneratePlayers", false, typeof(string))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = RuntimeApi.Bind(typeof(StartRunLobby), "GeneratePlayers", false, typeof(string))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`typeof(NGame).GetMethods().Any(m => m.Name == "StartNewMultiplayerRun"             && m.GetParameters().FirstOrDefault()?.ParameterType == typeof(List<Player>))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = typeof(NGame).GetMethods().Any(m => m.Name == "StartNewMultiplayerRun"             && m.GetParameters().FirstOrDefault()?.ParameterType == typeof(List<Player>))`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`m.GetParameters().FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: m.GetParameters().FirstOrDefault()?.ParameterType`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`m.GetParameters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: m.GetParameters().FirstOrDefault`
- `System.Type.GetMethods()`；输入表达式：`typeof(NGame).GetMethods()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: typeof(NGame).GetMethods().Any`

**赋值（含属性/字段和局部值）：**

- `_` = `RuntimeApi.Bind(typeof(StartRunLobby), "GeneratePlayers", false, typeof(string))`

<a id="symbol-fc5021e96790"></a>

## `NationalSpire.Coop.NativeLobbyApi.StartMultiplayer(System.Reflection.MethodInfo, MegaCrit.Sts2.Core.Nodes.NGame, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>, string, int) — public static Task StartMultiplayer(MethodInfo start, NGame game, StartRunLobby lobby, IReadOnlyList<ActModel> acts,         IReadOnlyList<ModifierModel> modifiers, string seed, int ascension)`

来源：源码第 92 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopSteamRunPlatform.BeginNew(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>, string, int, System.Threading.CancellationToken)`](CoopNativeRun.cs.md#symbol-b889ef6fb033)

**调用：** [`NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`](../RuntimeApi.cs.md#symbol-8426661c18c8)；[`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`](../RuntimeApi.cs.md#symbol-65f56c93bd1a)；`System.Reflection.MethodBase.GetParameters()`

**字段、属性、事件及方法组引用：** `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；输入表达式：`RuntimeApi.Bind(typeof(StartRunLobby), "GeneratePlayers", false, typeof(string))`；返回值紧邻使用处：`ArgumentSyntax: RuntimeApi.Bind(typeof(StartRunLobby), "GeneratePlayers", false, typeof(string))`
- `NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`；输入表达式：`RuntimeApi.Invoke(RuntimeApi.Bind(typeof(StartRunLobby), "GeneratePlayers", false, typeof(string)), lobby, seed)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RuntimeApi.Invoke(RuntimeApi.Bind(typeof(StartRunLobby), "GeneratePlayers", false, typeof(string)), lobby, seed)`
- `NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`；输入表达式：`RuntimeApi.Invoke(start, game, lobby, true, acts, modifiers, seed, ascension)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: RuntimeApi.Invoke(start, game, lobby, true, acts, modifiers, seed, ascension)!`
- `NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`；输入表达式：`RuntimeApi.Invoke(start, game, players, lobby, true, acts, modifiers, seed, ascension)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: RuntimeApi.Invoke(start, game, players, lobby, true, acts, modifiers, seed, ascension)!`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`start.GetParameters()`；返回值紧邻使用处：`ElementAccessExpressionSyntax: start.GetParameters()[0]`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b0693755b371"></a>

## `NationalSpire.Coop.NativeLobbyApi.Version() — public static object? Version()`

来源：源码第 103 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopSteamRunPlatform.Version()`](CoopNativeRun.cs.md#symbol-44ba56693565)

**调用：** [`NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`](../RuntimeApi.cs.md#symbol-8426661c18c8)；[`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`](../RuntimeApi.cs.md#symbol-65f56c93bd1a)；`System.Reflection.Assembly.GetType(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；输入表达式：`RuntimeApi.Bind(type, "LocalDefault", true)`；返回值紧邻使用处：`ArgumentSyntax: RuntimeApi.Bind(type, "LocalDefault", true)`
- `NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`；输入表达式：`RuntimeApi.Invoke(RuntimeApi.Bind(type, "LocalDefault", true), null)`；返回值紧邻使用处：`ConditionalExpressionSyntax: type == null ? null : RuntimeApi.Invoke(RuntimeApi.Bind(type, "LocalDefault", true), null)`
- `System.Reflection.Assembly.GetType(string)`；输入表达式：`typeof(NetHostGameService).Assembly.GetType("MegaCrit.Sts2.Core.Multiplayer.PeerVersionInfo")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = typeof(NetHostGameService).Assembly.GetType("MegaCrit.Sts2.Core.Multiplayer.PeerVersionInfo")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ca679536ff2b"></a>

## `NationalSpire.Coop.NativeLobbyApi.Service<T>(object?) — public static T Service<T>(object? version) where T : class`

来源：源码第 108 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.Host()`](CoopNativeRun.cs.md#symbol-5e85a7e716a1)；[`NationalSpire.Coop.CoopNativeRun.Join(string, bool)`](CoopNativeRun.cs.md#symbol-a3ff2d717caf)

**调用：** [`NationalSpire.Coop.NativeLobbyApi.Constructor(System.Type)`](NativeLobbyApi.cs.md#symbol-cc3db70b68a5)；`System.InvalidOperationException.InvalidOperationException(string?)`；`System.Reflection.ConstructorInfo.Invoke(object?[]?)`；`System.Reflection.MethodBase.GetParameters()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.NativeLobbyApi.Constructor(System.Type)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.NativeLobbyApi.Constructor(System.Type)`；输入表达式：`Constructor(typeof(T))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Constructor(typeof(T))`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("当前游戏需要联机版本信息。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidOperationException("当前游戏需要联机版本信息。")`
- `System.Reflection.ConstructorInfo.Invoke(object?[]?)`；输入表达式：`constructor.Invoke(constructor.GetParameters().Length == 0 ? [] : [version ?? throw new InvalidOperationException("当前游戏需要联机版本信息。")])`；返回值紧邻使用处：`CastExpressionSyntax: (T)constructor.Invoke(constructor.GetParameters().Length == 0 ? [] : [version ?? throw new InvalidOperationException("当前游戏需要联机版本信息。")])`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`constructor.GetParameters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: constructor.GetParameters().Length`

**赋值（含属性/字段和局部值）：**


<a id="symbol-cc3db70b68a5"></a>

## `NationalSpire.Coop.NativeLobbyApi.Constructor(System.Type) — private static ConstructorInfo Constructor(Type type)`

来源：源码第 113 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.NativeLobbyApi.Service<T>(object?)`](NativeLobbyApi.cs.md#symbol-ca679536ff2b)；[`NationalSpire.Coop.NativeLobbyApi.Validate()`](NativeLobbyApi.cs.md#symbol-de1b7a4fe8ee)

**调用：** `System.MissingMethodException.MissingMethodException(string?, string?)`；`System.Reflection.Assembly.GetType(string)`；`System.Type.GetConstructor(System.Type[])`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.MissingMethodException.MissingMethodException(string?, string?)`；输入表达式：`new MissingMethodException(type.FullName, "联机服务构造函数")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new MissingMethodException(type.FullName, "联机服务构造函数")`
- `System.Reflection.Assembly.GetType(string)`；输入表达式：`type.Assembly.GetType("MegaCrit.Sts2.Core.Multiplayer.PeerVersionInfo")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = type.Assembly.GetType("MegaCrit.Sts2.Core.Multiplayer.PeerVersionInfo")`
- `System.Type.GetConstructor(System.Type[])`；输入表达式：`type.GetConstructor([versionType])`；返回值紧邻使用处：`ConditionalExpressionSyntax: versionType == null ? type.GetConstructor(Type.EmptyTypes) : type.GetConstructor([versionType])`
- `System.Type.GetConstructor(System.Type[])`；输入表达式：`type.GetConstructor(Type.EmptyTypes)`；返回值紧邻使用处：`ConditionalExpressionSyntax: versionType == null ? type.GetConstructor(Type.EmptyTypes) : type.GetConstructor([versionType])`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2d450bb2d13d"></a>

## `NationalSpire.Coop.NativeLobbyApi.Connect(object, MegaCrit.Sts2.Core.Multiplayer.NetClientGameService, System.Threading.CancellationToken) — public static Task<NetErrorInfo?> Connect(object initializer, NetClientGameService service, CancellationToken token = default)`

来源：源码第 119 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopSteamRunPlatform.Join(MegaCrit.Sts2.Core.Multiplayer.NetClientGameService, string, System.Threading.CancellationToken)`](CoopNativeRun.cs.md#symbol-8fe0cd9c07ab)

**调用：** [`NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`](../RuntimeApi.cs.md#symbol-8426661c18c8)；[`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`](../RuntimeApi.cs.md#symbol-65f56c93bd1a)；`object.GetType()`

**字段、属性、事件及方法组引用：** `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；`NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；输入表达式：`RuntimeApi.Bind(initializer.GetType(), "Connect", false, service.GetType(), typeof(CancellationToken))`；返回值紧邻使用处：`ArgumentSyntax: RuntimeApi.Bind(initializer.GetType(), "Connect", false, service.GetType(), typeof(CancellationToken))`
- `NationalSpire.RuntimeApi.Invoke(System.Reflection.MethodInfo, object?, params object?[])`；输入表达式：`RuntimeApi.Invoke(RuntimeApi.Bind(initializer.GetType(), "Connect", false, service.GetType(), typeof(CancellationToken)), initializer, service, token)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: RuntimeApi.Invoke(RuntimeApi.Bind(initializer.GetType(), "Connect", false, service.GetType(), typeof(CancellationToken)), initializer, service, token)!`
- `object.GetType()`；输入表达式：`initializer.GetType()`；返回值紧邻使用处：`ArgumentSyntax: initializer.GetType()`
- `object.GetType()`；输入表达式：`service.GetType()`；返回值紧邻使用处：`ArgumentSyntax: service.GetType()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-80e9e2678be0"></a>

## `NationalSpire.Coop.NativeLobbyApi.Listener<T>(System.Func<System.Reflection.MethodInfo, object?[], object?>) — public static T Listener<T>(Func<MethodInfo, object?[], object?> callback) where T : class`

来源：源码第 121 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.LoadListener`](CoopNativeRun.cs.md#symbol-cb16516b62ba)；[`NationalSpire.Coop.CoopNativeRun.StartListener`](CoopNativeRun.cs.md#symbol-72549b80e794)

**调用：** `System.Reflection.DispatchProxy.Create<T, TProxy>()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.NativeLobbyListener.Callback`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Reflection.DispatchProxy.Create<T, TProxy>()`；输入表达式：`DispatchProxy.Create<T, NativeLobbyListener>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DispatchProxy.Create<T, NativeLobbyListener>()`

**赋值（含属性/字段和局部值）：**

- `((NativeLobbyListener)(object)listener).Callback` = `callback`

<a id="symbol-de1b7a4fe8ee"></a>

## `NationalSpire.Coop.NativeLobbyApi.Validate() — public static void Validate()`

来源：源码第 127 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCompatibility.Check(bool)`](CoopCompatibility.cs.md#symbol-c71e5d5de570)；[`NationalSpire.Coop.CoopNativeRun.Host()`](CoopNativeRun.cs.md#symbol-5e85a7e716a1)；[`NationalSpire.Coop.CoopNativeRun.Join(string, bool)`](CoopNativeRun.cs.md#symbol-a3ff2d717caf)

**调用：** [`NationalSpire.Coop.NativeLobbyApi.AddLocalMethod()`](NativeLobbyApi.cs.md#symbol-f10712477c49)；[`NationalSpire.Coop.NativeLobbyApi.Constructor(System.Type)`](NativeLobbyApi.cs.md#symbol-cc3db70b68a5)；[`NationalSpire.Coop.NativeLobbyApi.DisconnectMethod()`](NativeLobbyApi.cs.md#symbol-f172506c2760)；[`NationalSpire.Coop.NativeLobbyApi.Find(System.Type, string)`](NativeLobbyApi.cs.md#symbol-dc3d59409e04)；[`NationalSpire.Coop.NativeLobbyApi.StartConstructor()`](NativeLobbyApi.cs.md#symbol-f07766b19164)；[`NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`](../RuntimeApi.cs.md#symbol-8426661c18c8)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SequenceEqual<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>()`；`System.MissingMemberException.MissingMemberException(string?)`；`System.MissingMethodException.MissingMethodException(string?)`；`System.Reflection.Assembly.GetType(string)`；`System.Reflection.MethodBase.GetParameters()`；`System.Type.GetField(string)`；`System.Type.GetGenericArguments()`；`System.Type.GetMethods()`；`System.Type.GetProperty(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.NativeLobbyApi.AddLocalMethod()`；`NationalSpire.Coop.NativeLobbyApi.Constructor(System.Type)`；`NationalSpire.Coop.NativeLobbyApi.DisconnectMethod()`；`NationalSpire.Coop.NativeLobbyApi.Find(System.Type, string)`；`NationalSpire.Coop.NativeLobbyApi.StartConstructor()`；`NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.NativeLobbyApi.AddLocalMethod()`；输入表达式：`AddLocalMethod()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AddLocalMethod()`
- `NationalSpire.Coop.NativeLobbyApi.Constructor(System.Type)`；输入表达式：`Constructor(typeof(NetClientGameService))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = Constructor(typeof(NetClientGameService))`
- `NationalSpire.Coop.NativeLobbyApi.Constructor(System.Type)`；输入表达式：`Constructor(typeof(NetHostGameService))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = Constructor(typeof(NetHostGameService))`
- `NationalSpire.Coop.NativeLobbyApi.DisconnectMethod()`；输入表达式：`DisconnectMethod()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = DisconnectMethod()`
- `NationalSpire.Coop.NativeLobbyApi.Find(System.Type, string)`；输入表达式：`Find(join, name)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = Find(join, name)`
- `NationalSpire.Coop.NativeLobbyApi.Find(System.Type, string)`；输入表达式：`Find(player, "id")`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = Find(player, "id")`
- `NationalSpire.Coop.NativeLobbyApi.Find(System.Type, string)`；输入表达式：`Find(player, "isReady")`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = Find(player, "isReady")`
- `NationalSpire.Coop.NativeLobbyApi.Find(System.Type, string)`；输入表达式：`Find(startPlayer, name)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = Find(startPlayer, name)`
- `NationalSpire.Coop.NativeLobbyApi.Find(System.Type, string)`；输入表达式：`Find(typeof(LoadRunLobby), "ConnectedPlayerIds")`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = Find(typeof(LoadRunLobby), "ConnectedPlayerIds")`
- `NationalSpire.Coop.NativeLobbyApi.Find(System.Type, string)`；输入表达式：`Find(typeof(StartRunLobby), "Players")`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = Find(typeof(StartRunLobby), "Players")`
- `NationalSpire.Coop.NativeLobbyApi.StartConstructor()`；输入表达式：`StartConstructor()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = StartConstructor()`
- `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；输入表达式：`RuntimeApi.Bind(typeof(LoadRunLobby), "IsPlayerReady", false, typeof(ulong))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = RuntimeApi.Bind(typeof(LoadRunLobby), "IsPlayerReady", false, typeof(ulong))`
- `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；输入表达式：`RuntimeApi.Bind(typeof(MegaCrit.Sts2.Core.Multiplayer.Connection.SteamClientConnectionInitializer), "Connect", false, typeof(NetClientGameService), typeof(CancellationToken))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = RuntimeApi.Bind(typeof(MegaCrit.Sts2.Core.Multiplayer.Connection.SteamClientConnectionInitializer), "Connect", false, typeof(NetClientGameService), typeof(CancellationToken))`
- `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；输入表达式：`RuntimeApi.Bind(typeof(StartRunLobby), "SetLocalCharacter", false, typeof(CharacterModel))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = RuntimeApi.Bind(typeof(StartRunLobby), "SetLocalCharacter", false, typeof(CharacterModel))`
- `NationalSpire.RuntimeApi.Bind(System.Type, string, bool, params System.Type[])`；输入表达式：`RuntimeApi.Bind(versionType, "LocalDefault", true)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = RuntimeApi.Bind(versionType, "LocalDefault", true)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`method.GetParameters().Select(p => p.ParameterType)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: method.GetParameters().Select(p => p.ParameterType).SequenceEqual`
- `System.Collections.Generic.IEnumerable<TSource>.SequenceEqual<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`method.GetParameters().Select(p => p.ParameterType).SequenceEqual(new[] { typeof(string), typeof(List<ActModel>), typeof(IReadOnlyList<ModifierModel>) })`；返回值紧邻使用处：`BinaryExpressionSyntax: count == 0 || method.GetParameters().Select(p => p.ParameterType).SequenceEqual(new[] { typeof(string), typeof(List<ActModel>), typeof(IReadOnlyList<ModifierModel>) })`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>()`；输入表达式：`players.PropertyType.GetGenericArguments().Single()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = players.PropertyType.GetGenericArguments().Single()`
- `System.MissingMemberException.MissingMemberException(string?)`；输入表达式：`new MissingMemberException("StartRunLobby.LocalPlayer")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new MissingMemberException("StartRunLobby.LocalPlayer")`
- `System.MissingMethodException.MissingMethodException(string?)`；输入表达式：`new MissingMethodException("尚未适配的大厅回调：" + listener.Name + "." + method.Name)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new MissingMethodException("尚未适配的大厅回调：" + listener.Name + "." + method.Name);`
- `System.Reflection.Assembly.GetType(string)`；输入表达式：`typeof(NetHostGameService).Assembly.GetType("MegaCrit.Sts2.Core.Multiplayer.PeerVersionInfo")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = typeof(NetHostGameService).Assembly.GetType("MegaCrit.Sts2.Core.Multiplayer.PeerVersionInfo")`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`method.GetParameters()`；返回值紧邻使用处：`ElementAccessExpressionSyntax: method.GetParameters()[1]`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`method.GetParameters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: method.GetParameters().Length`
- `System.Reflection.MethodBase.GetParameters()`；输入表达式：`method.GetParameters()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: method.GetParameters().Select`
- `System.Type.GetField(string)`；输入表达式：`join.GetField("maxAscensionUnlocked")`；返回值紧邻使用处：`BinaryExpressionSyntax: join.GetField("maxAscensionUnlocked") != null`
- `System.Type.GetGenericArguments()`；输入表达式：`players.PropertyType.GetGenericArguments()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: players.PropertyType.GetGenericArguments().Single`
- `System.Type.GetMethods()`；输入表达式：`listener.GetMethods()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var method in listener.GetMethods())             {                 int count = method.GetParameters().Length;                 bool valid = method.Name switch                 {                     "BeginRun" => method.ReturnType == typeof(void) && (count == 0 || method.GetParameters().Select(p => p.ParameterType).SequenceEqual(new[] { typeof(string), typeof(List<ActModel>), typeof(IReadOnlyList<ModifierModel>) })),                     "ShouldAllowRunToBegin" => count == 0 && method.ReturnType == typeof(Task<bool>),                     "PlayerChanged" => count == 1 || count == 2 && method.GetParameters()[1].ParameterType == typeof(bool),                     "PlayerConnected" or "RemotePlayerDisconnected" or "LocalPlayerDisconnected" or "PlayerReadyChanged" => count == 1,                     "AscensionChanged" or "SeedChanged" or "ModifiersChanged" or "MaxAscensionChanged" => count == 0,                     "GameModeChanged" => count == 0 && method.ReturnType == typeof(void),                     _ => false                 };                 if (!valid) throw new MissingMethodException("尚未适配的大厅回调：" + listener.Name + "." + method.Name);             }`
- `System.Type.GetProperty(string)`；输入表达式：`typeof(LoadRunLobby).GetProperty("Players")`；返回值紧邻使用处：`IsPatternExpressionSyntax: typeof(LoadRunLobby).GetProperty("Players") is { } players`
- `System.Type.GetProperty(string)`；输入表达式：`typeof(StartRunLobby).GetProperty("LocalPlayer")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: typeof(StartRunLobby).GetProperty("LocalPlayer")?.PropertyType`

**赋值（含属性/字段和局部值）：**

- `_` = `AddLocalMethod()`
- `_` = `Constructor(typeof(NetClientGameService))`
- `_` = `Constructor(typeof(NetHostGameService))`
- `_` = `DisconnectMethod()`
- `_` = `Find(join, name)`
- `_` = `Find(player, "id")`
- `_` = `Find(player, "isReady")`
- `_` = `Find(startPlayer, name)`
- `_` = `Find(typeof(LoadRunLobby), "ConnectedPlayerIds")`
- `_` = `Find(typeof(StartRunLobby), "Players")`
- `_` = `RuntimeApi.Bind(typeof(LoadRunLobby), "IsPlayerReady", false, typeof(ulong))`
- `_` = `RuntimeApi.Bind(typeof(MegaCrit.Sts2.Core.Multiplayer.Connection.SteamClientConnectionInitializer), "Connect", false, typeof(NetClientGameService), typeof(CancellationToken))`
- `_` = `RuntimeApi.Bind(typeof(StartRunLobby), "SetLocalCharacter", false, typeof(CharacterModel))`
- `_` = `RuntimeApi.Bind(versionType, "LocalDefault", true)`
- `_` = `StartConstructor()`

<a id="symbol-ff0abce0d336"></a>

## `NationalSpire.Coop.NativeLobbyListener.Callback — public Func<MethodInfo, object?[], object?> Callback`

来源：源码第 168 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-dcc39e941b02"></a>

## `NationalSpire.Coop.NativeLobbyListener.Invoke(System.Reflection.MethodInfo?, object?[]?) — protected override object? Invoke(MethodInfo? targetMethod, object?[]? args)`

来源：源码第 169 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Func<T1, T2, TResult>.Invoke(T1, T2)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.NativeLobbyListener.Callback`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Func<T1, T2, TResult>.Invoke(T1, T2)`；输入表达式：`Callback(targetMethod!, args ?? [])`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Callback(targetMethod!, args ?? [])`

**赋值（含属性/字段和局部值）：**
