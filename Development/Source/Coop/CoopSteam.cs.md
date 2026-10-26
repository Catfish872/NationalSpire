# Coop/CoopSteam.cs

[返回文件依赖索引](../../SOURCE_MAP.md)

源码 SHA-256：`B859686007CA4A7D74A20898F463FF8F1AFACA1E19FFA94B59CB2E0E677B1C8B`。来源：[源码](../../../Coop/CoopSteam.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Coop.CoopSteam`。

字段、事件及初始值（源码原样）：

```csharp
private const int Channel = 19831;
private CSteamID _lobby;
private readonly HashSet<ulong> _peers = [];
private readonly Queue<(ulong Peer, byte[] Bytes)> _outgoing = [];
private readonly Queue<(ulong Peer, byte[] Bytes)> _control = [];
private readonly CoopPacketAssembly _packets = new();
private readonly Callback<SteamNetworkingMessagesSessionRequest_t> _requests;
private CallResult<LobbyCreated_t>? _create;
private CallResult<LobbyEnter_t>? _enter;
private bool _closed;
private TaskCompletionSource? _pending;
public event Action<ulong, CoopWire>? Received;
```

<a id="symbol-e838f2dd9dec"></a>

## `NationalSpire.Coop.CoopSteam.Self — public ulong Self`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Steamworks.SteamUser.GetSteamID()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Steamworks.SteamUser.GetSteamID()`；输入表达式：`SteamUser.GetSteamID()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: SteamUser.GetSteamID().m_SteamID`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a60781cf11fd"></a>

## `NationalSpire.Coop.CoopSteam.Owner — public ulong Owner`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a91426134af8"></a>

## `NationalSpire.Coop.CoopSteam.Peers — public IReadOnlySet<ulong> Peers`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopSteam._peers`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4a13c5530bf0"></a>

## `NationalSpire.Coop.CoopSteam.Code — public string Code`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-45ca19e6132b"></a>

## `NationalSpire.Coop.CoopSteam.Token — public string Token`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b1f078737dd8"></a>

## `NationalSpire.Coop.CoopSteam.CoopSteam() — public CoopSteam()`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRuntime.Connect(bool, string, string, int, string, string, string, NationalSpire.NpcGenerationSetup?)`](CoopRuntime.cs.md#symbol-5c58a004498a)

**调用：** [`NationalSpire.Coop.CoopSteam.Member(ulong)`](CoopSteam.cs.md#symbol-6ecf0776c951)；`Steamworks.Callback<T>.Create(Steamworks.Callback<T>.DispatchDelegate)`；`Steamworks.SteamNetworkingIdentity.GetSteamID64()`；`Steamworks.SteamNetworkingMessages.AcceptSessionWithUser(ref Steamworks.SteamNetworkingIdentity)`；`Steamworks.SteamUser.BLoggedOn()`；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopSteam._closed`；`NationalSpire.Coop.CoopSteam._requests`；`NationalSpire.Coop.CoopSteam.Member(ulong)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopSteam.Member(ulong)`；输入表达式：`Member(r.m_identityRemote.GetSteamID64())`；返回值紧邻使用处：`BinaryExpressionSyntax: !_closed && Member(r.m_identityRemote.GetSteamID64())`
- `Steamworks.Callback<T>.Create(Steamworks.Callback<T>.DispatchDelegate)`；输入表达式：`Callback<SteamNetworkingMessagesSessionRequest_t>.Create(r =>         {             if (!_closed && Member(r.m_identityRemote.GetSteamID64())) SteamNetworkingMessages.AcceptSessionWithUser(ref r.m_identityRemote);         })`；返回值紧邻使用处：`AssignmentExpressionSyntax: _requests = Callback<SteamNetworkingMessagesSessionRequest_t>.Create(r =>         {             if (!_closed && Member(r.m_identityRemote.GetSteamID64())) SteamNetworkingMessages.AcceptSessionWithUser(ref r.m_identityRemote);         })`
- `Steamworks.SteamNetworkingIdentity.GetSteamID64()`；输入表达式：`r.m_identityRemote.GetSteamID64()`；返回值紧邻使用处：`ArgumentSyntax: r.m_identityRemote.GetSteamID64()`
- `Steamworks.SteamNetworkingMessages.AcceptSessionWithUser(ref Steamworks.SteamNetworkingIdentity)`；输入表达式：`SteamNetworkingMessages.AcceptSessionWithUser(ref r.m_identityRemote)`；返回值紧邻使用处：`ExpressionStatementSyntax: SteamNetworkingMessages.AcceptSessionWithUser(ref r.m_identityRemote);`
- `Steamworks.SteamUser.BLoggedOn()`；输入表达式：`SteamUser.BLoggedOn()`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !SteamUser.BLoggedOn()`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("请先登录 Steam。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("请先登录 Steam。");`

**赋值（含属性/字段和局部值）：**

- `_requests` = `Callback<SteamNetworkingMessagesSessionRequest_t>.Create(r =>         {             if (!_closed && Member(r.m_identityRemote.GetSteamID64())) SteamNetworkingMessages.AcceptSessionWithUser(ref r.m_identityRemote);         })`

<a id="symbol-6ecf0776c951"></a>

## `NationalSpire.Coop.CoopSteam.Member(ulong) — private bool Member(ulong id)`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopSteam.CoopSteam()`](CoopSteam.cs.md#symbol-b1f078737dd8)；[`NationalSpire.Coop.CoopSteam.Join(string)`](CoopSteam.cs.md#symbol-d63147221932)

**调用：** `Steamworks.SteamMatchmaking.GetLobbyMemberByIndex(Steamworks.CSteamID, int)`；`Steamworks.SteamMatchmaking.GetNumLobbyMembers(Steamworks.CSteamID)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopSteam._lobby`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Steamworks.SteamMatchmaking.GetLobbyMemberByIndex(Steamworks.CSteamID, int)`；输入表达式：`SteamMatchmaking.GetLobbyMemberByIndex(_lobby, i)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: SteamMatchmaking.GetLobbyMemberByIndex(_lobby, i).m_SteamID`
- `Steamworks.SteamMatchmaking.GetNumLobbyMembers(Steamworks.CSteamID)`；输入表达式：`SteamMatchmaking.GetNumLobbyMembers(_lobby)`；返回值紧邻使用处：`BinaryExpressionSyntax: i < SteamMatchmaking.GetNumLobbyMembers(_lobby)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2ebe266758ac"></a>

## `NationalSpire.Coop.CoopSteam.Host(int) — public async Task Host(int capacity)`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRuntime.Connect(bool, string, string, int, string, string, string, NationalSpire.NpcGenerationSetup?)`](CoopRuntime.cs.md#symbol-5c58a004498a)

**调用：** `int.ToString()`；`Steamworks.CallResult<T>.Create(Steamworks.CallResult<T>.APIDispatchDelegate)`；`Steamworks.CallResult<T>.Set(Steamworks.SteamAPICall_t, Steamworks.CallResult<T>.APIDispatchDelegate)`；`Steamworks.CSteamID.CSteamID(ulong)`；`Steamworks.SteamMatchmaking.CreateLobby(Steamworks.ELobbyType, int)`；`Steamworks.SteamMatchmaking.SetLobbyData(Steamworks.CSteamID, string, string)`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.IO.IOException.IOException(string?)`；`System.Threading.Tasks.Task.WaitAsync(System.TimeSpan)`；`System.Threading.Tasks.TaskCompletionSource.TaskCompletionSource()`；`System.Threading.Tasks.TaskCompletionSource.TrySetException(System.Exception)`；`System.Threading.Tasks.TaskCompletionSource.TrySetResult()`；`System.TimeSpan.FromSeconds(long)`；`ulong.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopSteam._closed`；`NationalSpire.Coop.CoopSteam._create`；`NationalSpire.Coop.CoopSteam._lobby`；`NationalSpire.Coop.CoopSteam._pending`；`NationalSpire.Coop.CoopSteam.Code`；`NationalSpire.Coop.CoopSteam.Owner`；`NationalSpire.Coop.CoopSteam.Self`；`NationalSpire.Coop.CoopSteam.Token`；`NationalSpire.Coop.CoopWorld.Protocol`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.ToString()`；输入表达式：`CoopWorld.Protocol.ToString()`；返回值紧邻使用处：`ArgumentSyntax: CoopWorld.Protocol.ToString()`
- `Steamworks.CallResult<T>.Create(Steamworks.CallResult<T>.APIDispatchDelegate)`；输入表达式：`CallResult<LobbyCreated_t>.Create((r, error) =>         {             if (_closed) return;             if (error || r.m_eResult != EResult.k_EResultOK) { ready.TrySetException(new IOException("Steam 创建房间失败。")); return; }             _lobby = new(r.m_ulSteamIDLobby); Owner = Self; Token = Guid.NewGuid().ToString("N"); Code = _lobby.m_SteamID + "-" + Token;             SteamMatchmaking.SetLobbyData(_lobby, "nationalspire", CoopWorld.Protocol.ToString());             SteamMatchmaking.SetLobbyData(_lobby, "career_owner", Self.ToString());             ready.TrySetResult();         })`；返回值紧邻使用处：`AssignmentExpressionSyntax: _create = CallResult<LobbyCreated_t>.Create((r, error) =>         {             if (_closed) return;             if (error || r.m_eResult != EResult.k_EResultOK) { ready.TrySetException(new IOException("Steam 创建房间失败。")); return; }             _lobby = new(r.m_ulSteamIDLobby); Owner = Self; Token = Guid.NewGuid().ToString("N"); Code = _lobby.m_SteamID + "-" + Token;             SteamMatchmaking.SetLobbyData(_lobby, "nationalspire", CoopWorld.Protocol.ToString());             SteamMatchmaking.SetLobbyData(_lobby, "career_owner", Self.ToString());             ready.TrySetResult();         })`
- `Steamworks.CallResult<T>.Set(Steamworks.SteamAPICall_t, Steamworks.CallResult<T>.APIDispatchDelegate)`；输入表达式：`_create.Set(SteamMatchmaking.CreateLobby(ELobbyType.k_ELobbyTypeInvisible, capacity))`；返回值紧邻使用处：`ExpressionStatementSyntax: _create.Set(SteamMatchmaking.CreateLobby(ELobbyType.k_ELobbyTypeInvisible, capacity));`
- `Steamworks.CSteamID.CSteamID(ulong)`；输入表达式：`new(r.m_ulSteamIDLobby)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _lobby = new(r.m_ulSteamIDLobby)`
- `Steamworks.SteamMatchmaking.CreateLobby(Steamworks.ELobbyType, int)`；输入表达式：`SteamMatchmaking.CreateLobby(ELobbyType.k_ELobbyTypeInvisible, capacity)`；返回值紧邻使用处：`ArgumentSyntax: SteamMatchmaking.CreateLobby(ELobbyType.k_ELobbyTypeInvisible, capacity)`
- `Steamworks.SteamMatchmaking.SetLobbyData(Steamworks.CSteamID, string, string)`；输入表达式：`SteamMatchmaking.SetLobbyData(_lobby, "career_owner", Self.ToString())`；返回值紧邻使用处：`ExpressionStatementSyntax: SteamMatchmaking.SetLobbyData(_lobby, "career_owner", Self.ToString());`
- `Steamworks.SteamMatchmaking.SetLobbyData(Steamworks.CSteamID, string, string)`；输入表达式：`SteamMatchmaking.SetLobbyData(_lobby, "nationalspire", CoopWorld.Protocol.ToString())`；返回值紧邻使用处：`ExpressionStatementSyntax: SteamMatchmaking.SetLobbyData(_lobby, "nationalspire", CoopWorld.Protocol.ToString());`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Token = Guid.NewGuid().ToString("N")`
- `System.IO.IOException.IOException(string?)`；输入表达式：`new IOException("Steam 创建房间失败。")`；返回值紧邻使用处：`ArgumentSyntax: new IOException("Steam 创建房间失败。")`
- `System.Threading.Tasks.Task.WaitAsync(System.TimeSpan)`；输入表达式：`ready.Task.WaitAsync(TimeSpan.FromSeconds(30))`；返回值紧邻使用处：`AwaitExpressionSyntax: await ready.Task.WaitAsync(TimeSpan.FromSeconds(30))`
- `System.Threading.Tasks.TaskCompletionSource.TaskCompletionSource()`；输入表达式：`new TaskCompletionSource()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _pending = new TaskCompletionSource()`
- `System.Threading.Tasks.TaskCompletionSource.TrySetException(System.Exception)`；输入表达式：`ready.TrySetException(new IOException("Steam 创建房间失败。"))`；返回值紧邻使用处：`ExpressionStatementSyntax: ready.TrySetException(new IOException("Steam 创建房间失败。"));`
- `System.Threading.Tasks.TaskCompletionSource.TrySetResult()`；输入表达式：`ready.TrySetResult()`；返回值紧邻使用处：`ExpressionStatementSyntax: ready.TrySetResult();`
- `System.TimeSpan.FromSeconds(long)`；输入表达式：`TimeSpan.FromSeconds(30)`；返回值紧邻使用处：`ArgumentSyntax: TimeSpan.FromSeconds(30)`
- `ulong.ToString()`；输入表达式：`Self.ToString()`；返回值紧邻使用处：`ArgumentSyntax: Self.ToString()`

**赋值（含属性/字段和局部值）：**

- `_create` = `CallResult<LobbyCreated_t>.Create((r, error) =>         {             if (_closed) return;             if (error || r.m_eResult != EResult.k_EResultOK) { ready.TrySetException(new IOException("Steam 创建房间失败。")); return; }             _lobby = new(r.m_ulSteamIDLobby); Owner = Self; Token = Guid.NewGuid().ToString("N"); Code = _lobby.m_SteamID + "-" + Token;             SteamMatchmaking.SetLobbyData(_lobby, "nationalspire", CoopWorld.Protocol.ToString());             SteamMatchmaking.SetLobbyData(_lobby, "career_owner", Self.ToString());             ready.TrySetResult();         })`
- `_lobby` = `new(r.m_ulSteamIDLobby)`
- `_pending` = `new TaskCompletionSource()`
- `Code` = `_lobby.m_SteamID + "-" + Token`
- `Owner` = `Self`
- `Token` = `Guid.NewGuid().ToString("N")`

<a id="symbol-d63147221932"></a>

## `NationalSpire.Coop.CoopSteam.Join(string) — public async Task Join(string code)`

来源：源码第 56 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRuntime.Connect(bool, string, string, int, string, string, string, NationalSpire.NpcGenerationSetup?)`](CoopRuntime.cs.md#symbol-5c58a004498a)

**调用：** [`NationalSpire.Coop.CoopSteam.Member(ulong)`](CoopSteam.cs.md#symbol-6ecf0776c951)；`int.ToString()`；`Steamworks.CallResult<T>.Create(Steamworks.CallResult<T>.APIDispatchDelegate)`；`Steamworks.CallResult<T>.Set(Steamworks.SteamAPICall_t, Steamworks.CallResult<T>.APIDispatchDelegate)`；`Steamworks.CSteamID.CSteamID(ulong)`；`Steamworks.SteamMatchmaking.GetLobbyData(Steamworks.CSteamID, string)`；`Steamworks.SteamMatchmaking.JoinLobby(Steamworks.CSteamID)`；`string.Split(char, System.StringSplitOptions)`；`string.Trim()`；`System.Guid.TryParseExact(string?, string?, out System.Guid)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.IOException.IOException(string?)`；`System.Threading.Tasks.Task.WaitAsync(System.TimeSpan)`；`System.Threading.Tasks.TaskCompletionSource.TaskCompletionSource()`；`System.Threading.Tasks.TaskCompletionSource.TrySetException(System.Exception)`；`System.Threading.Tasks.TaskCompletionSource.TrySetResult()`；`System.TimeSpan.FromSeconds(long)`；`ulong.TryParse(string?, out ulong)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopSteam._closed`；`NationalSpire.Coop.CoopSteam._enter`；`NationalSpire.Coop.CoopSteam._lobby`；`NationalSpire.Coop.CoopSteam._pending`；`NationalSpire.Coop.CoopSteam.Code`；`NationalSpire.Coop.CoopSteam.Member(ulong)`；`NationalSpire.Coop.CoopSteam.Owner`；`NationalSpire.Coop.CoopSteam.Token`；`NationalSpire.Coop.CoopWorld.Protocol`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.ToString()`；输入表达式：`CoopWorld.Protocol.ToString()`；返回值紧邻使用处：`BinaryExpressionSyntax: SteamMatchmaking.GetLobbyData(_lobby, "nationalspire") != CoopWorld.Protocol.ToString()`
- `NationalSpire.Coop.CoopSteam.Member(ulong)`；输入表达式：`Member(owner)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Member(owner)`
- `Steamworks.CallResult<T>.Create(Steamworks.CallResult<T>.APIDispatchDelegate)`；输入表达式：`CallResult<LobbyEnter_t>.Create((r, error) =>         {             if (_closed) return;             if (error || r.m_EChatRoomEnterResponse != (uint)EChatRoomEnterResponse.k_EChatRoomEnterResponseSuccess) { ready.TrySetException(new IOException("无法进入 Steam 房间。")); return; }             _lobby = new(r.m_ulSteamIDLobby);             if (SteamMatchmaking.GetLobbyData(_lobby, "nationalspire") != CoopWorld.Protocol.ToString() || !ulong.TryParse(SteamMatchmaking.GetLobbyData(_lobby, "career_owner"), out ulong owner) || !Member(owner))             { ready.TrySetException(new InvalidDataException("共同生涯房间协议不匹配或主机已离线。")); return; }             Owner = owner; Code = code.Trim(); ready.TrySetResult();         })`；返回值紧邻使用处：`AssignmentExpressionSyntax: _enter = CallResult<LobbyEnter_t>.Create((r, error) =>         {             if (_closed) return;             if (error || r.m_EChatRoomEnterResponse != (uint)EChatRoomEnterResponse.k_EChatRoomEnterResponseSuccess) { ready.TrySetException(new IOException("无法进入 Steam 房间。")); return; }             _lobby = new(r.m_ulSteamIDLobby);             if (SteamMatchmaking.GetLobbyData(_lobby, "nationalspire") != CoopWorld.Protocol.ToString() || !ulong.TryParse(SteamMatchmaking.GetLobbyData(_lobby, "career_owner"), out ulong owner) || !Member(owner))             { ready.TrySetException(new InvalidDataException("共同生涯房间协议不匹配或主机已离线。")); return; }             Owner = owner; Code = code.Trim(); ready.TrySetResult();         })`
- `Steamworks.CallResult<T>.Set(Steamworks.SteamAPICall_t, Steamworks.CallResult<T>.APIDispatchDelegate)`；输入表达式：`_enter.Set(SteamMatchmaking.JoinLobby(new(lobby)))`；返回值紧邻使用处：`ExpressionStatementSyntax: _enter.Set(SteamMatchmaking.JoinLobby(new(lobby)));`
- `Steamworks.CSteamID.CSteamID(ulong)`；输入表达式：`new(lobby)`；返回值紧邻使用处：`ArgumentSyntax: new(lobby)`
- `Steamworks.CSteamID.CSteamID(ulong)`；输入表达式：`new(r.m_ulSteamIDLobby)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _lobby = new(r.m_ulSteamIDLobby)`
- `Steamworks.SteamMatchmaking.GetLobbyData(Steamworks.CSteamID, string)`；输入表达式：`SteamMatchmaking.GetLobbyData(_lobby, "career_owner")`；返回值紧邻使用处：`ArgumentSyntax: SteamMatchmaking.GetLobbyData(_lobby, "career_owner")`
- `Steamworks.SteamMatchmaking.GetLobbyData(Steamworks.CSteamID, string)`；输入表达式：`SteamMatchmaking.GetLobbyData(_lobby, "nationalspire")`；返回值紧邻使用处：`BinaryExpressionSyntax: SteamMatchmaking.GetLobbyData(_lobby, "nationalspire") != CoopWorld.Protocol.ToString()`
- `Steamworks.SteamMatchmaking.JoinLobby(Steamworks.CSteamID)`；输入表达式：`SteamMatchmaking.JoinLobby(new(lobby))`；返回值紧邻使用处：`ArgumentSyntax: SteamMatchmaking.JoinLobby(new(lobby))`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`code.Trim().Split('-')`；返回值紧邻使用处：`EqualsValueClauseSyntax: = code.Trim().Split('-')`
- `string.Trim()`；输入表达式：`code.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Code = code.Trim()`
- `string.Trim()`；输入表达式：`code.Trim()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: code.Trim().Split`
- `System.Guid.TryParseExact(string?, string?, out System.Guid)`；输入表达式：`Guid.TryParseExact(parts[1], "N", out _)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Guid.TryParseExact(parts[1], "N", out _)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("房间邀请代码无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("房间邀请代码无效。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("共同生涯房间协议不匹配或主机已离线。")`；返回值紧邻使用处：`ArgumentSyntax: new InvalidDataException("共同生涯房间协议不匹配或主机已离线。")`
- `System.IO.IOException.IOException(string?)`；输入表达式：`new IOException("无法进入 Steam 房间。")`；返回值紧邻使用处：`ArgumentSyntax: new IOException("无法进入 Steam 房间。")`
- `System.Threading.Tasks.Task.WaitAsync(System.TimeSpan)`；输入表达式：`ready.Task.WaitAsync(TimeSpan.FromSeconds(30))`；返回值紧邻使用处：`AwaitExpressionSyntax: await ready.Task.WaitAsync(TimeSpan.FromSeconds(30))`
- `System.Threading.Tasks.TaskCompletionSource.TaskCompletionSource()`；输入表达式：`new TaskCompletionSource()`；返回值紧邻使用处：`AssignmentExpressionSyntax: _pending = new TaskCompletionSource()`
- `System.Threading.Tasks.TaskCompletionSource.TrySetException(System.Exception)`；输入表达式：`ready.TrySetException(new InvalidDataException("共同生涯房间协议不匹配或主机已离线。"))`；返回值紧邻使用处：`ExpressionStatementSyntax: ready.TrySetException(new InvalidDataException("共同生涯房间协议不匹配或主机已离线。"));`
- `System.Threading.Tasks.TaskCompletionSource.TrySetException(System.Exception)`；输入表达式：`ready.TrySetException(new IOException("无法进入 Steam 房间。"))`；返回值紧邻使用处：`ExpressionStatementSyntax: ready.TrySetException(new IOException("无法进入 Steam 房间。"));`
- `System.Threading.Tasks.TaskCompletionSource.TrySetResult()`；输入表达式：`ready.TrySetResult()`；返回值紧邻使用处：`ExpressionStatementSyntax: ready.TrySetResult();`
- `System.TimeSpan.FromSeconds(long)`；输入表达式：`TimeSpan.FromSeconds(30)`；返回值紧邻使用处：`ArgumentSyntax: TimeSpan.FromSeconds(30)`
- `ulong.TryParse(string?, out ulong)`；输入表达式：`ulong.TryParse(parts[0], out ulong lobby)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ulong.TryParse(parts[0], out ulong lobby)`
- `ulong.TryParse(string?, out ulong)`；输入表达式：`ulong.TryParse(SteamMatchmaking.GetLobbyData(_lobby, "career_owner"), out ulong owner)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ulong.TryParse(SteamMatchmaking.GetLobbyData(_lobby, "career_owner"), out ulong owner)`

**赋值（含属性/字段和局部值）：**

- `_enter` = `CallResult<LobbyEnter_t>.Create((r, error) =>         {             if (_closed) return;             if (error || r.m_EChatRoomEnterResponse != (uint)EChatRoomEnterResponse.k_EChatRoomEnterResponseSuccess) { ready.TrySetException(new IOException("无法进入 Steam 房间。")); return; }             _lobby = new(r.m_ulSteamIDLobby);             if (SteamMatchmaking.GetLobbyData(_lobby, "nationalspire") != CoopWorld.Protocol.ToString() || !ulong.TryParse(SteamMatchmaking.GetLobbyData(_lobby, "career_owner"), out ulong owner) || !Member(owner))             { ready.TrySetException(new InvalidDataException("共同生涯房间协议不匹配或主机已离线。")); return; }             Owner = owner; Code = code.Trim(); ready.TrySetResult();         })`
- `_lobby` = `new(r.m_ulSteamIDLobby)`
- `_pending` = `new TaskCompletionSource()`
- `Code` = `code.Trim()`
- `Owner` = `owner`
- `Token` = `parts[1]`

<a id="symbol-8374c51d760a"></a>

## `NationalSpire.Coop.CoopSteam.Send(ulong, NationalSpire.Coop.CoopWire) — public void Send(ulong peer, CoopWire wire)`

来源：源码第 73 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopPacketAssembly.Pack(NationalSpire.Coop.CoopWire)`](CoopWire.cs.md#symbol-1ffd868804d7)；`System.Collections.Generic.Queue<T>.Enqueue(T)`；`System.IO.IOException.IOException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopPacketAssembly.Pack(NationalSpire.Coop.CoopWire)`；`NationalSpire.Coop.CoopSteam._closed`；`NationalSpire.Coop.CoopSteam._control`；`NationalSpire.Coop.CoopSteam._outgoing`；`NationalSpire.Coop.CoopSteam.Self`；`NationalSpire.Coop.CoopWire.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopPacketAssembly.Pack(NationalSpire.Coop.CoopWire)`；输入表达式：`CoopPacketAssembly.Pack(wire)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (byte[] bytes in CoopPacketAssembly.Pack(wire)) queue.Enqueue((peer, bytes));`
- `System.Collections.Generic.Queue<T>.Enqueue(T)`；输入表达式：`queue.Enqueue((peer, bytes))`；返回值紧邻使用处：`ExpressionStatementSyntax: queue.Enqueue((peer, bytes));`
- `System.IO.IOException.IOException(string?)`；输入表达式：`new IOException("房间发送队列超出限制。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new IOException("房间发送队列超出限制。");`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fa8dda1e0359"></a>

## `NationalSpire.Coop.CoopSteam.Update() — public void Update()`

来源：源码第 80 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopPacketAssembly.Read(ulong, byte[])`](CoopWire.cs.md#symbol-4b11b493c720)；[`NationalSpire.Coop.CoopPacketAssembly.RetainPeers(System.Collections.Generic.IReadOnlySet<ulong>)`](CoopWire.cs.md#symbol-b6a1e8a7621b)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](../Diagnostics.cs.md#symbol-cb39203375a5)；`Steamworks.SteamMatchmaking.GetLobbyMemberByIndex(Steamworks.CSteamID, int)`；`Steamworks.SteamMatchmaking.GetNumLobbyMembers(Steamworks.CSteamID)`；`Steamworks.SteamNetworkingIdentity.GetSteamID64()`；`Steamworks.SteamNetworkingIdentity.SetSteamID64(ulong)`；`Steamworks.SteamNetworkingIdentity.SteamNetworkingIdentity()`；`Steamworks.SteamNetworkingMessage_t.FromIntPtr(nint)`；`Steamworks.SteamNetworkingMessage_t.Release(nint)`；`Steamworks.SteamNetworkingMessages.ReceiveMessagesOnChannel(int, nint[], int)`；`Steamworks.SteamNetworkingMessages.SendMessageToUser(ref Steamworks.SteamNetworkingIdentity, nint, uint, int, int)`；`System.Action<T1, T2>.Invoke(T1, T2)`（委托实际目标见流程文档）；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Clear()`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.Queue<T>.Dequeue()`；`System.Collections.Generic.Queue<T>.TryPeek(out T)`；`System.IO.IOException.IOException(string?)`；`System.Runtime.InteropServices.GCHandle.AddrOfPinnedObject()`；`System.Runtime.InteropServices.GCHandle.Alloc(object?, System.Runtime.InteropServices.GCHandleType)`；`System.Runtime.InteropServices.GCHandle.Free()`；`System.Runtime.InteropServices.Marshal.Copy(nint, byte[], int, int)`

**字段、属性、事件及方法组引用：** `(ulong Peer, byte[] Bytes).Bytes`；`(ulong Peer, byte[] Bytes).Peer`；`NationalSpire.Coop.CoopPacketAssembly.Read(ulong, byte[])`；`NationalSpire.Coop.CoopPacketAssembly.RetainPeers(System.Collections.Generic.IReadOnlySet<ulong>)`；`NationalSpire.Coop.CoopSteam._closed`；`NationalSpire.Coop.CoopSteam._control`；`NationalSpire.Coop.CoopSteam._lobby`；`NationalSpire.Coop.CoopSteam._outgoing`；`NationalSpire.Coop.CoopSteam._packets`；`NationalSpire.Coop.CoopSteam._peers`；`NationalSpire.Coop.CoopSteam.Channel`；`NationalSpire.Coop.CoopSteam.Received`；`NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopPacketAssembly.Read(ulong, byte[])`；输入表达式：`_packets.Read(sender, bytes)`；返回值紧邻使用处：`IsPatternExpressionSyntax: _packets.Read(sender, bytes) is { } wire`
- `NationalSpire.Coop.CoopPacketAssembly.RetainPeers(System.Collections.Generic.IReadOnlySet<ulong>)`；输入表达式：`_packets.RetainPeers(_peers)`；返回值紧邻使用处：`ExpressionStatementSyntax: _packets.RetainPeers(_peers);`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("coop.packet", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("coop.packet", e);`
- `Steamworks.SteamMatchmaking.GetLobbyMemberByIndex(Steamworks.CSteamID, int)`；输入表达式：`SteamMatchmaking.GetLobbyMemberByIndex(_lobby, i)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: SteamMatchmaking.GetLobbyMemberByIndex(_lobby, i).m_SteamID`
- `Steamworks.SteamMatchmaking.GetNumLobbyMembers(Steamworks.CSteamID)`；输入表达式：`SteamMatchmaking.GetNumLobbyMembers(_lobby)`；返回值紧邻使用处：`BinaryExpressionSyntax: i < SteamMatchmaking.GetNumLobbyMembers(_lobby)`
- `Steamworks.SteamNetworkingIdentity.GetSteamID64()`；输入表达式：`packet.m_identityPeer.GetSteamID64()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = packet.m_identityPeer.GetSteamID64()`
- `Steamworks.SteamNetworkingIdentity.SetSteamID64(ulong)`；输入表达式：`identity.SetSteamID64(send.Peer)`；返回值紧邻使用处：`ExpressionStatementSyntax: identity.SetSteamID64(send.Peer);`
- `Steamworks.SteamNetworkingIdentity.SteamNetworkingIdentity()`；输入表达式：`new SteamNetworkingIdentity()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new SteamNetworkingIdentity()`
- `Steamworks.SteamNetworkingMessage_t.FromIntPtr(nint)`；输入表达式：`SteamNetworkingMessage_t.FromIntPtr(messages[i])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SteamNetworkingMessage_t.FromIntPtr(messages[i])`
- `Steamworks.SteamNetworkingMessage_t.Release(nint)`；输入表达式：`SteamNetworkingMessage_t.Release(messages[i])`；返回值紧邻使用处：`ExpressionStatementSyntax: SteamNetworkingMessage_t.Release(messages[i]);`
- `Steamworks.SteamNetworkingMessages.ReceiveMessagesOnChannel(int, nint[], int)`；输入表达式：`SteamNetworkingMessages.ReceiveMessagesOnChannel(Channel, messages, messages.Length)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SteamNetworkingMessages.ReceiveMessagesOnChannel(Channel, messages, messages.Length)`
- `Steamworks.SteamNetworkingMessages.SendMessageToUser(ref Steamworks.SteamNetworkingIdentity, nint, uint, int, int)`；输入表达式：`SteamNetworkingMessages.SendMessageToUser(ref identity, pin.AddrOfPinnedObject(), (uint)send.Bytes.Length, Constants.k_nSteamNetworkingSend_Reliable, Channel)`；返回值紧邻使用处：`AssignmentExpressionSyntax: result = SteamNetworkingMessages.SendMessageToUser(ref identity, pin.AddrOfPinnedObject(), (uint)send.Bytes.Length, Constants.k_nSteamNetworkingSend_Reliable, Channel)`
- `System.Action<T1, T2>.Invoke(T1, T2)`；输入表达式：`.Invoke(sender, wire)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Received?.Invoke(sender, wire)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`_peers.Add(SteamMatchmaking.GetLobbyMemberByIndex(_lobby, i).m_SteamID)`；返回值紧邻使用处：`ExpressionStatementSyntax: _peers.Add(SteamMatchmaking.GetLobbyMemberByIndex(_lobby, i).m_SteamID);`
- `System.Collections.Generic.HashSet<T>.Clear()`；输入表达式：`_peers.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _peers.Clear();`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_peers.Contains(send.Peer)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_peers.Contains(send.Peer)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`_peers.Contains(sender)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_peers.Contains(sender)`
- `System.Collections.Generic.Queue<T>.Dequeue()`；输入表达式：`queue.Dequeue()`；返回值紧邻使用处：`ExpressionStatementSyntax: queue.Dequeue();`
- `System.Collections.Generic.Queue<T>.TryPeek(out T)`；输入表达式：`queue.TryPeek(out var send)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !queue.TryPeek(out var send)`
- `System.IO.IOException.IOException(string?)`；输入表达式：`new IOException("Steam 生涯消息发送失败：" + result)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new IOException("Steam 生涯消息发送失败：" + result);`
- `System.Runtime.InteropServices.GCHandle.AddrOfPinnedObject()`；输入表达式：`pin.AddrOfPinnedObject()`；返回值紧邻使用处：`ArgumentSyntax: pin.AddrOfPinnedObject()`
- `System.Runtime.InteropServices.GCHandle.Alloc(object?, System.Runtime.InteropServices.GCHandleType)`；输入表达式：`GCHandle.Alloc(send.Bytes, GCHandleType.Pinned)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GCHandle.Alloc(send.Bytes, GCHandleType.Pinned)`
- `System.Runtime.InteropServices.GCHandle.Free()`；输入表达式：`pin.Free()`；返回值紧邻使用处：`ExpressionStatementSyntax: pin.Free();`
- `System.Runtime.InteropServices.Marshal.Copy(nint, byte[], int, int)`；输入表达式：`Marshal.Copy(packet.m_pData, bytes, 0, bytes.Length)`；返回值紧邻使用处：`ExpressionStatementSyntax: Marshal.Copy(packet.m_pData, bytes, 0, bytes.Length);`

**赋值（含属性/字段和局部值）：**

- `result` = `SteamNetworkingMessages.SendMessageToUser(ref identity, pin.AddrOfPinnedObject(), (uint)send.Bytes.Length, Constants.k_nSteamNetworkingSend_Reliable, Channel)`

<a id="symbol-e6ebd27b8764"></a>

## `NationalSpire.Coop.CoopSteam.Dispose() — public void Dispose()`

来源：源码第 116 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRuntime.CancelConnection()`](CoopRuntime.cs.md#symbol-e77a969fcfd3)；[`NationalSpire.Coop.CoopRuntime.Connect(bool, string, string, int, string, string, string, NationalSpire.NpcGenerationSetup?)`](CoopRuntime.cs.md#symbol-5c58a004498a)

**调用：** [`NationalSpire.Coop.CoopPacketAssembly.Clear()`](CoopWire.cs.md#symbol-cd6bfa17797d)；`Steamworks.Callback<T>.Dispose()`；`Steamworks.CallResult<T>.Dispose()`；`Steamworks.SteamMatchmaking.LeaveLobby(Steamworks.CSteamID)`；`Steamworks.SteamNetworkingIdentity.SetSteamID64(ulong)`；`Steamworks.SteamNetworkingIdentity.SteamNetworkingIdentity()`；`Steamworks.SteamNetworkingMessages.CloseChannelWithUser(ref Steamworks.SteamNetworkingIdentity, int)`；`System.Collections.Generic.HashSet<T>.Clear()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.Queue<T>.Clear()`；`System.Threading.Tasks.TaskCompletionSource.TrySetCanceled()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopPacketAssembly.Clear()`；`NationalSpire.Coop.CoopSteam._closed`；`NationalSpire.Coop.CoopSteam._control`；`NationalSpire.Coop.CoopSteam._create`；`NationalSpire.Coop.CoopSteam._enter`；`NationalSpire.Coop.CoopSteam._lobby`；`NationalSpire.Coop.CoopSteam._outgoing`；`NationalSpire.Coop.CoopSteam._packets`；`NationalSpire.Coop.CoopSteam._peers`；`NationalSpire.Coop.CoopSteam._pending`；`NationalSpire.Coop.CoopSteam._requests`；`NationalSpire.Coop.CoopSteam.Channel`；`NationalSpire.Coop.CoopSteam.Self`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopPacketAssembly.Clear()`；输入表达式：`_packets.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _packets.Clear();`
- `Steamworks.Callback<T>.Dispose()`；输入表达式：`_requests.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: _requests.Dispose();`
- `Steamworks.CallResult<T>.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _create?.Dispose()`
- `Steamworks.CallResult<T>.Dispose()`；输入表达式：`.Dispose()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _enter?.Dispose()`
- `Steamworks.SteamMatchmaking.LeaveLobby(Steamworks.CSteamID)`；输入表达式：`SteamMatchmaking.LeaveLobby(_lobby)`；返回值紧邻使用处：`ExpressionStatementSyntax: SteamMatchmaking.LeaveLobby(_lobby);`
- `Steamworks.SteamNetworkingIdentity.SetSteamID64(ulong)`；输入表达式：`id.SetSteamID64(peer)`；返回值紧邻使用处：`ExpressionStatementSyntax: id.SetSteamID64(peer);`
- `Steamworks.SteamNetworkingIdentity.SteamNetworkingIdentity()`；输入表达式：`new SteamNetworkingIdentity()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new SteamNetworkingIdentity()`
- `Steamworks.SteamNetworkingMessages.CloseChannelWithUser(ref Steamworks.SteamNetworkingIdentity, int)`；输入表达式：`SteamNetworkingMessages.CloseChannelWithUser(ref id, Channel)`；返回值紧邻使用处：`ExpressionStatementSyntax: SteamNetworkingMessages.CloseChannelWithUser(ref id, Channel);`
- `System.Collections.Generic.HashSet<T>.Clear()`；输入表达式：`_peers.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _peers.Clear();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_peers.Where(p => p != Self)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (ulong peer in _peers.Where(p => p != Self)) { var id = new SteamNetworkingIdentity(); id.SetSteamID64(peer); SteamNetworkingMessages.CloseChannelWithUser(ref id, Channel); }`
- `System.Collections.Generic.Queue<T>.Clear()`；输入表达式：`_control.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _control.Clear();`
- `System.Collections.Generic.Queue<T>.Clear()`；输入表达式：`_outgoing.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _outgoing.Clear();`
- `System.Threading.Tasks.TaskCompletionSource.TrySetCanceled()`；输入表达式：`.TrySetCanceled()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: _pending?.TrySetCanceled()`

**赋值（含属性/字段和局部值）：**

- `_closed` = `true`
- `_pending` = `null`
