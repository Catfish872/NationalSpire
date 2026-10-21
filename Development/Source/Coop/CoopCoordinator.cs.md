# Coop/CoopCoordinator.cs

[返回文件依赖索引](../../SOURCE_MAP.md)

源码 SHA-256：`B94A3C841E05741C2F351B015D99B66B14BB7208CE9AFD09B1D881983507F027`。来源：[源码](../../../Coop/CoopCoordinator.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Coop.CoopSnapshot`、`NationalSpire.Coop.CoopHello`、`NationalSpire.Coop.CoopReply`、`NationalSpire.Coop.CoopHeartbeat`、`NationalSpire.Coop.CoopCoordinator`。

字段、事件及初始值（源码原样）：

```csharp
private readonly ICoopTransport _transport;
private readonly CoopStorage _storage;
private readonly string _compatibility, _token, _name;
private readonly IReadOnlySet<string> _characters;
private readonly Dictionary<ulong, DateTime> _seen = [];
private readonly Dictionary<ulong, (DateTime At, int Count)> _rates = [];
private readonly CoopAssembler _assembler = new();
private readonly CoopAssembler _liveAssembler = new();
private DateTime _lastHello, _lastHeartbeat;
private bool _closed;
private string _lastJoinError = "";
private readonly Dictionary<string, (CoopCommand Command, DateTime Sent, CoopReply? Reply)> _pendingCommands = [];
public event Action? Changed;
public event Action<string>? TriggerAi;
public event Action<CoopWire>? RunMessage;
public event Action<CoopReply>? Replied;
```

<a id="symbol-04c658fdc81a"></a>

## `NationalSpire.Coop.CoopCoordinator.World — public CoopWorld? World`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4f0292a9b151"></a>

## `NationalSpire.Coop.CoopCoordinator.NativeSave — public byte[]? NativeSave`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-47400c7dd10c"></a>

## `NationalSpire.Coop.CoopCoordinator.Self — public ulong Self`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator._transport`；`NationalSpire.Coop.ICoopTransport.Self`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e4220974d058"></a>

## `NationalSpire.Coop.CoopCoordinator.Host — public bool Host`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator._transport`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.ICoopTransport.Owner`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d56467663ae5"></a>

## `NationalSpire.Coop.CoopCoordinator.Online — public HashSet<ulong> Online`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlySet<T>.Contains(T)`；`System.TimeSpan.FromSeconds(long)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator._seen`；`NationalSpire.Coop.CoopCoordinator._transport`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.ICoopTransport.Peers`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`_seen.Where(p => DateTime.UtcNow - p.Value < TimeSpan.FromSeconds(15) && _transport.Peers.Contains(p.Key)).Select(p => p.Key).Append(Self)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _seen.Where(p => DateTime.UtcNow - p.Value < TimeSpan.FromSeconds(15) && _transport.Peers.Contains(p.Key)).Select(p => p.Key).Append(Self).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`_seen.Where(p => DateTime.UtcNow - p.Value < TimeSpan.FromSeconds(15) && _transport.Peers.Contains(p.Key)).Select(p => p.Key)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _seen.Where(p => DateTime.UtcNow - p.Value < TimeSpan.FromSeconds(15) && _transport.Peers.Contains(p.Key)).Select(p => p.Key).Append`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`_seen.Where(p => DateTime.UtcNow - p.Value < TimeSpan.FromSeconds(15) && _transport.Peers.Contains(p.Key)).Select(p => p.Key).Append(Self).ToHashSet()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => _seen.Where(p => DateTime.UtcNow - p.Value < TimeSpan.FromSeconds(15) && _transport.Peers.Contains(p.Key)).Select(p => p.Key).Append(Self).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_seen.Where(p => DateTime.UtcNow - p.Value < TimeSpan.FromSeconds(15) && _transport.Peers.Contains(p.Key))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _seen.Where(p => DateTime.UtcNow - p.Value < TimeSpan.FromSeconds(15) && _transport.Peers.Contains(p.Key)).Select`
- `System.Collections.Generic.IReadOnlySet<T>.Contains(T)`；输入表达式：`_transport.Peers.Contains(p.Key)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateTime.UtcNow - p.Value < TimeSpan.FromSeconds(15) && _transport.Peers.Contains(p.Key)`
- `System.TimeSpan.FromSeconds(long)`；输入表达式：`TimeSpan.FromSeconds(15)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateTime.UtcNow - p.Value < TimeSpan.FromSeconds(15)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f3249e3212d5"></a>

## `NationalSpire.Coop.CoopCoordinator.Full — public bool Full`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.Online`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopRun.Characters`；`NationalSpire.Coop.CoopWorld.Run`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`w.Run.Characters.Keys.All(Online.Contains)`；返回值紧邻使用处：`ConditionalExpressionSyntax: w.Run != null ? w.Run.Characters.Keys.All(Online.Contains) : Online.Count is >= 2 and <= 4`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5b483c9bb484"></a>

## `NationalSpire.Coop.CoopCoordinator.Status — public string Status`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-778097f34ec3"></a>

## `NationalSpire.Coop.CoopCoordinator.CoopCoordinator(NationalSpire.Coop.ICoopTransport, NationalSpire.Coop.CoopStorage, string, string, string, System.Collections.Generic.IReadOnlySet<string>, NationalSpire.Coop.CoopStorage.Checkpoint?) — public CoopCoordinator(ICoopTransport transport, CoopStorage storage, string compatibility, string token, string name, IReadOnlySet<string> characters, CoopStorage.Checkpoint? hostWorld = null)`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRuntime.Connect(bool, string, string, int, string, string, string)`](CoopRuntime.cs.md#symbol-5c58a004498a)

**调用：** [`NationalSpire.CircuitPeople.Replenish(NationalSpire.CareerData)`](../CircuitPeople.cs.md#symbol-03130719dfb2)；[`NationalSpire.CommunityThreads.Normalize(NationalSpire.CareerData)`](../CommunityThreads.cs.md#symbol-95e97a5c9007)；[`NationalSpire.CommunityThreads.RecoverInterrupted(NationalSpire.CareerData)`](../CommunityThreads.cs.md#symbol-e83d7ef9fb98)；[`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`](CoopCoordinator.cs.md#symbol-e1dfe22e8221)；[`NationalSpire.Coop.CoopRules.AdvanceMembers(NationalSpire.Coop.CoopWorld)`](CoopRules.cs.md#symbol-bc24477e89ba)；[`NationalSpire.Coop.CoopRules.InitializeMarket(NationalSpire.Coop.CoopWorld)`](CoopMarket.cs.md#symbol-0d9508e5083b)；[`NationalSpire.Coop.CoopStorage.BackupBeforeDevelopment(NationalSpire.Coop.CoopWorld, byte[]?)`](CoopStorage.cs.md#symbol-955953e36f17)；[`NationalSpire.EsportsWorld.ClearInvalidRegistrations(NationalSpire.CareerData)`](../EsportsWorld.cs.md#symbol-b694be794ed8)；[`NationalSpire.EsportsWorld.RefreshLeagueMatches(NationalSpire.CareerData)`](../EsportsWorld.cs.md#symbol-6b77d7c9e9bf)；[`NationalSpire.GameCalendar.Initialize(NationalSpire.CareerData)`](../GameCalendar.cs.md#symbol-006ea3a9bcad)；[`NationalSpire.GroupChats.Recover(NationalSpire.CareerData)`](../GroupChats.cs.md#symbol-01d7b7cae92b)；[`NationalSpire.NationalDevelopment.Ensure(NationalSpire.CareerData)`](../NationalDevelopment.cs.md#symbol-7b51466d6927)；[`NationalSpire.NpcRecords.Ensure(NationalSpire.CareerData)`](../NpcRecords.cs.md#symbol-13b4702fac73)；[`NationalSpire.OwnedClubs.EnsureMarket(NationalSpire.CareerData)`](../OwnedClubs.cs.md#symbol-3dba497c8606)；[`NationalSpire.OwnedClubs.RepairContractRoster(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.PrivateMailbox>?)`](../OwnedClubs.cs.md#symbol-3b98b543bc03)；[`NationalSpire.PersonalityLibrary.EnsureAll(NationalSpire.CareerData)`](../PersonalityLibrary.cs.md#symbol-60a4e59dd008)；[`NationalSpire.PlayerIdentity.Ensure(NationalSpire.CareerData)`](../PlayerIdentity.cs.md#symbol-340085e81d95)；[`NationalSpire.PrivateMessageCommands.Recover(NationalSpire.CareerLifeState)`](../PrivateMessageCommands.cs.md#symbol-1ce050227fd9)；[`NationalSpire.WeeklyJournal.ActivateLatest(NationalSpire.CareerData)`](../WeeklyJournal.cs.md#symbol-182dc6fd73e0)；[`NationalSpire.WeeklyJournal.Recover(NationalSpire.CareerData)`](../WeeklyJournal.cs.md#symbol-f465ec0d1539)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerLife.Version`；`NationalSpire.CareerLifeState.Mailbox`；`NationalSpire.CareerLifeState.Version`；`NationalSpire.CircuitPeople.Replenish(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.Normalize(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.RecoverInterrupted(NationalSpire.CareerData)`；`NationalSpire.Coop.CoopCoordinator._characters`；`NationalSpire.Coop.CoopCoordinator._compatibility`；`NationalSpire.Coop.CoopCoordinator._name`；`NationalSpire.Coop.CoopCoordinator._storage`；`NationalSpire.Coop.CoopCoordinator._token`；`NationalSpire.Coop.CoopCoordinator._transport`；`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.NativeSave`；`NationalSpire.Coop.CoopCoordinator.Receive(ulong, NationalSpire.Coop.CoopWire)`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopMember.Life`；`NationalSpire.Coop.CoopRules.AdvanceMembers(NationalSpire.Coop.CoopWorld)`；`NationalSpire.Coop.CoopRules.InitializeMarket(NationalSpire.Coop.CoopWorld)`；`NationalSpire.Coop.CoopStorage.BackupBeforeDevelopment(NationalSpire.Coop.CoopWorld, byte[]?)`；`NationalSpire.Coop.CoopStorage.Checkpoint.Run`；`NationalSpire.Coop.CoopStorage.Checkpoint.World`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Owner`；`NationalSpire.Coop.CoopWorld.Proposal`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.Coop.ICoopTransport.Received`；`NationalSpire.EsportsWorld.ClearInvalidRegistrations(NationalSpire.CareerData)`；`NationalSpire.EsportsWorld.RefreshLeagueMatches(NationalSpire.CareerData)`；`NationalSpire.GameCalendar.Initialize(NationalSpire.CareerData)`；`NationalSpire.GroupChats.Recover(NationalSpire.CareerData)`；`NationalSpire.NationalDevelopment.Ensure(NationalSpire.CareerData)`；`NationalSpire.NpcRecords.Ensure(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.EnsureMarket(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.RepairContractRoster(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.PrivateMailbox>?)`；`NationalSpire.PersonalityLibrary.EnsureAll(NationalSpire.CareerData)`；`NationalSpire.PlayerIdentity.Ensure(NationalSpire.CareerData)`；`NationalSpire.PrivateMessageCommands.Recover(NationalSpire.CareerLifeState)`；`NationalSpire.WeeklyJournal.ActivateLatest(NationalSpire.CareerData)`；`NationalSpire.WeeklyJournal.Recover(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CircuitPeople.Replenish(NationalSpire.CareerData)`；输入表达式：`CircuitPeople.Replenish(World.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: CircuitPeople.Replenish(World.World);`
- `NationalSpire.CommunityThreads.Normalize(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.Normalize(World.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.Normalize(World.World);`
- `NationalSpire.CommunityThreads.RecoverInterrupted(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.RecoverInterrupted(World.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.RecoverInterrupted(World.World);`
- `NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；输入表达式：`Commit(World, NativeSave, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: Commit(World, NativeSave, false);`
- `NationalSpire.Coop.CoopRules.AdvanceMembers(NationalSpire.Coop.CoopWorld)`；输入表达式：`CoopRules.AdvanceMembers(World)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopRules.AdvanceMembers(World);`
- `NationalSpire.Coop.CoopRules.InitializeMarket(NationalSpire.Coop.CoopWorld)`；输入表达式：`CoopRules.InitializeMarket(World)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopRules.InitializeMarket(World);`
- `NationalSpire.Coop.CoopStorage.BackupBeforeDevelopment(NationalSpire.Coop.CoopWorld, byte[]?)`；输入表达式：`storage.BackupBeforeDevelopment(hostWorld.World, hostWorld.Run)`；返回值紧邻使用处：`ExpressionStatementSyntax: storage.BackupBeforeDevelopment(hostWorld.World, hostWorld.Run);`
- `NationalSpire.EsportsWorld.ClearInvalidRegistrations(NationalSpire.CareerData)`；输入表达式：`EsportsWorld.ClearInvalidRegistrations(World.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: EsportsWorld.ClearInvalidRegistrations(World.World);`
- `NationalSpire.EsportsWorld.RefreshLeagueMatches(NationalSpire.CareerData)`；输入表达式：`EsportsWorld.RefreshLeagueMatches(World.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: EsportsWorld.RefreshLeagueMatches(World.World);`
- `NationalSpire.GameCalendar.Initialize(NationalSpire.CareerData)`；输入表达式：`GameCalendar.Initialize(World.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: GameCalendar.Initialize(World.World);`
- `NationalSpire.GroupChats.Recover(NationalSpire.CareerData)`；输入表达式：`GroupChats.Recover(World.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupChats.Recover(World.World);`
- `NationalSpire.NationalDevelopment.Ensure(NationalSpire.CareerData)`；输入表达式：`NationalDevelopment.Ensure(World.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: NationalDevelopment.Ensure(World.World);`
- `NationalSpire.NpcRecords.Ensure(NationalSpire.CareerData)`；输入表达式：`NpcRecords.Ensure(World.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: NpcRecords.Ensure(World.World);`
- `NationalSpire.OwnedClubs.EnsureMarket(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.EnsureMarket(World.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: OwnedClubs.EnsureMarket(World.World);`
- `NationalSpire.OwnedClubs.RepairContractRoster(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.PrivateMailbox>?)`；输入表达式：`OwnedClubs.RepairContractRoster(World.World, World.Members.Select(m => m.Life.Mailbox))`；返回值紧邻使用处：`ExpressionStatementSyntax: OwnedClubs.RepairContractRoster(World.World, World.Members.Select(m => m.Life.Mailbox));`
- `NationalSpire.PersonalityLibrary.EnsureAll(NationalSpire.CareerData)`；输入表达式：`PersonalityLibrary.EnsureAll(World.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: PersonalityLibrary.EnsureAll(World.World);`
- `NationalSpire.PlayerIdentity.Ensure(NationalSpire.CareerData)`；输入表达式：`PlayerIdentity.Ensure(World.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: PlayerIdentity.Ensure(World.World);`
- `NationalSpire.PrivateMessageCommands.Recover(NationalSpire.CareerLifeState)`；输入表达式：`PrivateMessageCommands.Recover(member.Life)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateMessageCommands.Recover(member.Life);`
- `NationalSpire.WeeklyJournal.ActivateLatest(NationalSpire.CareerData)`；输入表达式：`WeeklyJournal.ActivateLatest(World.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: WeeklyJournal.ActivateLatest(World.World);`
- `NationalSpire.WeeklyJournal.Recover(NationalSpire.CareerData)`；输入表达式：`WeeklyJournal.Recover(World.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: WeeklyJournal.Recover(World.World);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`hostWorld.World.Members.Any(m => m.Life.Version < CareerLife.Version)`；返回值紧邻使用处：`IfStatementSyntax: if (hostWorld.World.Members.Any(m => m.Life.Version < CareerLife.Version))                  storage.BackupBeforeDevelopment(hostWorld.World, hostWorld.Run);`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`World.Members.Select(m => m.Life.Mailbox)`；返回值紧邻使用处：`ArgumentSyntax: World.Members.Select(m => m.Life.Mailbox)`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`AssignmentExpressionSyntax: World.Epoch = Guid.NewGuid().ToString("N")`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("只有原主机能恢复这个世界。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("只有原主机能恢复这个世界。");`

**赋值（含属性/字段和局部值）：**

- `_characters` = `characters`
- `_compatibility` = `compatibility`
- `_name` = `name`
- `_storage` = `storage`
- `_token` = `token`
- `_transport.Received` += `Receive`
- `_transport` = `transport`
- `NativeSave` = `hostWorld.Run`
- `World.Epoch` = `Guid.NewGuid().ToString("N")`
- `World.Proposal` = `null`
- `World` = `hostWorld.World`

<a id="symbol-4253349561bc"></a>

## `NationalSpire.Coop.CoopCoordinator.Tick() — public void Tick()`

来源：源码第 65 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRuntime._Process(double)`](CoopRuntime.cs.md#symbol-ec1513bd09b1)

**调用：** [`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`](CoopCoordinator.cs.md#symbol-e1dfe22e8221)；[`NationalSpire.Coop.CoopCoordinator.PumpDiagnostics()`](CoopDiagnostics.cs.md#symbol-3c9a89501f77)；[`NationalSpire.Coop.CoopCoordinator.PumpReceived()`](CoopReception.cs.md#symbol-a09fec904cc1)；[`NationalSpire.Coop.CoopCoordinator.Retry(NationalSpire.Coop.CoopCommand)`](CoopCoordinator.cs.md#symbol-11ae699cefda)；[`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`](CoopCoordinator.cs.md#symbol-0145ddb8062f)；[`NationalSpire.Coop.CoopCoordinator.StartProactiveChats()`](CoopProactiveChats.cs.md#symbol-119c1a541077)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`](CoopData.cs.md#symbol-85d2410ea3ba)；[`NationalSpire.Coop.CoopRules.SetParticipants(NationalSpire.Coop.CoopWorld, System.Collections.Generic.IReadOnlySet<ulong>)`](CoopParticipants.cs.md#symbol-bc80580d2b20)；[`NationalSpire.Coop.ICoopTransport.Update()`](CoopWire.cs.md#symbol-f3bdece34370)；`NationalSpire.Coop.CoopHeartbeat.CoopHeartbeat(string, ulong[])`；`NationalSpire.Coop.CoopHello.CoopHello(int, string, string, string)`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.HashSet<T>.SetEquals(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.TimeSpan.FromSeconds(long)`

**字段、属性、事件及方法组引用：** `(NationalSpire.Coop.CoopCommand Command, System.DateTime Sent, NationalSpire.Coop.CoopReply Reply).Command`；`(NationalSpire.Coop.CoopCommand Command, System.DateTime Sent, NationalSpire.Coop.CoopReply Reply).Reply`；`(NationalSpire.Coop.CoopCommand Command, System.DateTime Sent, NationalSpire.Coop.CoopReply Reply).Sent`；`NationalSpire.CareerData.MatchHumanIds`；`NationalSpire.Coop.CoopCoordinator._closed`；`NationalSpire.Coop.CoopCoordinator._compatibility`；`NationalSpire.Coop.CoopCoordinator._lastHeartbeat`；`NationalSpire.Coop.CoopCoordinator._lastHello`；`NationalSpire.Coop.CoopCoordinator._name`；`NationalSpire.Coop.CoopCoordinator._pendingCommands`；`NationalSpire.Coop.CoopCoordinator._token`；`NationalSpire.Coop.CoopCoordinator._transport`；`NationalSpire.Coop.CoopCoordinator.Changed`；`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.Online`；`NationalSpire.Coop.CoopCoordinator.PumpDiagnostics()`；`NationalSpire.Coop.CoopCoordinator.PumpReceived()`；`NationalSpire.Coop.CoopCoordinator.Retry(NationalSpire.Coop.CoopCommand)`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；`NationalSpire.Coop.CoopCoordinator.StartProactiveChats()`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`；`NationalSpire.Coop.CoopMember.PersonId`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopRules.SetParticipants(NationalSpire.Coop.CoopWorld, System.Collections.Generic.IReadOnlySet<ulong>)`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Proposal`；`NationalSpire.Coop.CoopWorld.Protocol`；`NationalSpire.Coop.CoopWorld.Revision`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.Coop.ICoopTransport.Owner`；`NationalSpire.Coop.ICoopTransport.Update()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；输入表达式：`Commit(copy, null)`；返回值紧邻使用处：`ExpressionStatementSyntax: Commit(copy, null);`
- `NationalSpire.Coop.CoopCoordinator.PumpDiagnostics()`；输入表达式：`PumpDiagnostics()`；返回值紧邻使用处：`ExpressionStatementSyntax: PumpDiagnostics();`
- `NationalSpire.Coop.CoopCoordinator.PumpReceived()`；输入表达式：`PumpReceived()`；返回值紧邻使用处：`ExpressionStatementSyntax: PumpReceived();`
- `NationalSpire.Coop.CoopCoordinator.Retry(NationalSpire.Coop.CoopCommand)`；输入表达式：`Retry(pending.Command)`；返回值紧邻使用处：`ExpressionStatementSyntax: Retry(pending.Command);`
- `NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；输入表达式：`Send(_transport.Owner, "hello", new CoopHello(CoopWorld.Protocol, _compatibility, _token, _name))`；返回值紧邻使用处：`ExpressionStatementSyntax: Send(_transport.Owner, "hello", new CoopHello(CoopWorld.Protocol, _compatibility, _token, _name));`
- `NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；输入表达式：`Send(_transport.Owner, "pong", World.Epoch)`；返回值紧邻使用处：`ExpressionStatementSyntax: Send(_transport.Owner, "pong", World.Epoch);`
- `NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；输入表达式：`Send(m.SteamId, "ping", new CoopHeartbeat(World.Epoch, Online.ToArray()))`；返回值紧邻使用处：`ExpressionStatementSyntax: Send(m.SteamId, "ping", new CoopHeartbeat(World.Epoch, Online.ToArray()));`
- `NationalSpire.Coop.CoopCoordinator.StartProactiveChats()`；输入表达式：`StartProactiveChats()`；返回值紧邻使用处：`ExpressionStatementSyntax: StartProactiveChats();`
- `NationalSpire.Coop.CoopHeartbeat.CoopHeartbeat(string, ulong[])`；输入表达式：`new CoopHeartbeat(World.Epoch, Online.ToArray())`；返回值紧邻使用处：`ArgumentSyntax: new CoopHeartbeat(World.Epoch, Online.ToArray())`
- `NationalSpire.Coop.CoopHello.CoopHello(int, string, string, string)`；输入表达式：`new CoopHello(CoopWorld.Protocol, _compatibility, _token, _name)`；返回值紧邻使用处：`ArgumentSyntax: new CoopHello(CoopWorld.Protocol, _compatibility, _token, _name)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(idle)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Copy(idle)`
- `NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`；输入表达式：`CoopJson.Detached(copy.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopJson.Detached(copy.World);`
- `NationalSpire.Coop.CoopRules.SetParticipants(NationalSpire.Coop.CoopWorld, System.Collections.Generic.IReadOnlySet<ulong>)`；输入表达式：`CoopRules.SetParticipants(copy, Online)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopRules.SetParticipants(copy, Online);`
- `NationalSpire.Coop.ICoopTransport.Update()`；输入表达式：`_transport.Update()`；返回值紧邻使用处：`ExpressionStatementSyntax: _transport.Update();`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Changed?.Invoke()`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`Online.Contains(m.SteamId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m => Online.Contains(m.SteamId)`
- `System.Collections.Generic.HashSet<T>.SetEquals(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`idle.World.MatchHumanIds.ToHashSet().SetEquals(idle.Members.Where(m => Online.Contains(m.SteamId)).Select(m => m.PersonId))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !idle.World.MatchHumanIds.ToHashSet().SetEquals(idle.Members.Where(m => Online.Contains(m.SteamId)).Select(m => m.PersonId))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`idle.Members.Where(m => Online.Contains(m.SteamId)).Select(m => m.PersonId)`；返回值紧邻使用处：`ArgumentSyntax: idle.Members.Where(m => Online.Contains(m.SteamId)).Select(m => m.PersonId)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_pendingCommands.Values.ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var pending in _pendingCommands.Values.ToArray())                  if (pending.Reply == null && DateTime.UtcNow - pending.Sent >= TimeSpan.FromSeconds(3)) Retry(pending.Command);`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Online.ToArray()`；返回值紧邻使用处：`ArgumentSyntax: Online.ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`idle.World.MatchHumanIds.ToHashSet()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: idle.World.MatchHumanIds.ToHashSet().SetEquals`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`idle.Members.Where(m => Online.Contains(m.SteamId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: idle.Members.Where(m => Online.Contains(m.SteamId)).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`World.Members.Where(m => m.SteamId != Self)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var m in World.Members.Where(m => m.SteamId != Self)) Send(m.SteamId, "ping", new CoopHeartbeat(World.Epoch, Online.ToArray()));`
- `System.TimeSpan.FromSeconds(long)`；输入表达式：`TimeSpan.FromSeconds(3)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateTime.UtcNow - _lastHeartbeat > TimeSpan.FromSeconds(3)`
- `System.TimeSpan.FromSeconds(long)`；输入表达式：`TimeSpan.FromSeconds(3)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateTime.UtcNow - _lastHello > TimeSpan.FromSeconds(3)`
- `System.TimeSpan.FromSeconds(long)`；输入表达式：`TimeSpan.FromSeconds(3)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateTime.UtcNow - pending.Sent >= TimeSpan.FromSeconds(3)`

**赋值（含属性/字段和局部值）：**

- `_lastHeartbeat` = `DateTime.UtcNow`
- `_lastHello` = `DateTime.UtcNow`

<a id="symbol-0145ddb8062f"></a>

## `NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T) — private void Send<T>(ulong peer, string kind, T value)`

来源：源码第 91 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.Broadcast()`](CoopCoordinator.cs.md#symbol-8a047804722d)；[`NationalSpire.Coop.CoopCoordinator.Execute(ulong, NationalSpire.Coop.CoopCommand)`](CoopCoordinator.cs.md#symbol-ec0c662c6de0)；[`NationalSpire.Coop.CoopCoordinator.InspectMarket(NationalSpire.MarketInspection)`](CoopMarket.cs.md#symbol-fa87d36508d0)；[`NationalSpire.Coop.CoopCoordinator.PublishLive()`](CoopCoordinator.cs.md#symbol-1e3cadd9f597)；[`NationalSpire.Coop.CoopCoordinator.Receive(ulong, NationalSpire.Coop.CoopWire)`](CoopCoordinator.cs.md#symbol-892f19740afa)；[`NationalSpire.Coop.CoopCoordinator.ReceiveMarket(ulong, NationalSpire.Coop.CoopWire)`](CoopMarket.cs.md#symbol-1d6c27a5f526)；[`NationalSpire.Coop.CoopCoordinator.ReceiveNow(ulong, NationalSpire.Coop.CoopWire, System.DateTime)`](CoopCoordinator.cs.md#symbol-796041df5e9f)；[`NationalSpire.Coop.CoopCoordinator.Retry(NationalSpire.Coop.CoopCommand)`](CoopCoordinator.cs.md#symbol-11ae699cefda)；[`NationalSpire.Coop.CoopCoordinator.SendDiagnostic<T>(ulong, string, T)`](CoopDiagnostics.cs.md#symbol-88bc4c237586)；[`NationalSpire.Coop.CoopCoordinator.SendRun(string, object)`](CoopCoordinator.cs.md#symbol-99375ad602b4)；[`NationalSpire.Coop.CoopCoordinator.StartEvent(ulong, NationalSpire.Coop.CoopCommand)`](CoopRandomEvents.cs.md#symbol-b51ea4166eab)；[`NationalSpire.Coop.CoopCoordinator.StartGroup(ulong, NationalSpire.Coop.CoopCommand)`](CoopGroupChats.cs.md#symbol-83d332761336)；[`NationalSpire.Coop.CoopCoordinator.StartPrivate(ulong, NationalSpire.Coop.CoopCommand)`](CoopPrivateMessages.cs.md#symbol-ebc3f29b5eb6)；[`NationalSpire.Coop.CoopCoordinator.Tick()`](CoopCoordinator.cs.md#symbol-4253349561bc)

**调用：** [`NationalSpire.Coop.ICoopTransport.Send(ulong, NationalSpire.Coop.CoopWire)`](CoopWire.cs.md#symbol-fc2e03480549)；`NationalSpire.Coop.CoopWire.CoopWire(string, string)`；`System.Collections.Generic.IReadOnlySet<T>.Contains(T)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator._transport`；`NationalSpire.Coop.CoopJson.Options`；`NationalSpire.Coop.ICoopTransport.Peers`；`NationalSpire.Coop.ICoopTransport.Send(ulong, NationalSpire.Coop.CoopWire)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopWire.CoopWire(string, string)`；输入表达式：`new(kind, JsonSerializer.Serialize(value, CoopJson.Options))`；返回值紧邻使用处：`ArgumentSyntax: new(kind, JsonSerializer.Serialize(value, CoopJson.Options))`
- `NationalSpire.Coop.ICoopTransport.Send(ulong, NationalSpire.Coop.CoopWire)`；输入表达式：`_transport.Send(peer, new(kind, JsonSerializer.Serialize(value, CoopJson.Options)))`；返回值紧邻使用处：`ExpressionStatementSyntax: _transport.Send(peer, new(kind, JsonSerializer.Serialize(value, CoopJson.Options)));`
- `System.Collections.Generic.IReadOnlySet<T>.Contains(T)`；输入表达式：`_transport.Peers.Contains(peer)`；返回值紧邻使用处：`IfStatementSyntax: if (_transport.Peers.Contains(peer)) _transport.Send(peer, new(kind, JsonSerializer.Serialize(value, CoopJson.Options)));`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(value, CoopJson.Options)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(value, CoopJson.Options)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-99375ad602b4"></a>

## `NationalSpire.Coop.CoopCoordinator.SendRun(string, object) — public void SendRun(string kind, object payload)`

来源：源码第 93 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.Fail(System.Exception)`](CoopNativeRun.cs.md#symbol-fa50e38bdb28)；[`NationalSpire.Coop.CoopNativeRun.Update()`](CoopNativeRun.cs.md#symbol-f8b6c697410f)；[`NationalSpire.Coop.CoopRuntime.PauseCore(string)`](CoopRuntime.cs.md#symbol-60fe2cb26a8e)

**调用：** [`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`](CoopCoordinator.cs.md#symbol-0145ddb8062f)；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Owner`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；输入表达式：`Send(m.SteamId, kind, payload)`；返回值紧邻使用处：`ExpressionStatementSyntax: Send(m.SteamId, kind, payload);`
- `NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；输入表达式：`Send(World.Owner, kind, payload)`；返回值紧邻使用处：`ExpressionStatementSyntax: Send(World.Owner, kind, payload);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`World.Members.Where(m => m.SteamId != Self)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var m in World.Members.Where(m => m.SteamId != Self)) Send(m.SteamId, kind, payload);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4239da75be84"></a>

## `NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire) — private static T Read<T>(CoopWire wire)`

来源：源码第 99 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.Receive(ulong, NationalSpire.Coop.CoopWire)`](CoopCoordinator.cs.md#symbol-892f19740afa)；[`NationalSpire.Coop.CoopCoordinator.ReceiveDiagnostic(ulong, NationalSpire.Coop.CoopWire)`](CoopDiagnostics.cs.md#symbol-fefabf8d6a26)；[`NationalSpire.Coop.CoopCoordinator.ReceiveMarket(ulong, NationalSpire.Coop.CoopWire)`](CoopMarket.cs.md#symbol-1d6c27a5f526)；[`NationalSpire.Coop.CoopCoordinator.ReceiveNow(ulong, NationalSpire.Coop.CoopWire, System.DateTime)`](CoopCoordinator.cs.md#symbol-796041df5e9f)；[`NationalSpire.Coop.CoopCoordinator.ReceivePrivate(NationalSpire.Coop.CoopWire, System.DateTime)`](CoopPrivateMessages.cs.md#symbol-eca8b0236539)

**调用：** `System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopJson.Options`；`NationalSpire.Coop.CoopWire.Payload`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("房间消息为空。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidDataException("房间消息为空。")`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<T>(wire.Payload, CoopJson.Options)`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<T>(wire.Payload, CoopJson.Options) ?? throw new InvalidDataException("房间消息为空。")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-892f19740afa"></a>

## `NationalSpire.Coop.CoopCoordinator.Receive(ulong, NationalSpire.Coop.CoopWire) — private void Receive(ulong sender, CoopWire wire)`

来源：源码第 100 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopAssembler.Collect(NationalSpire.Coop.CoopPart, System.DateTime)`](CoopWire.cs.md#symbol-35fc52cbee4a)；[`NationalSpire.Coop.CoopCoordinator.QueueSnapshot(ulong, NationalSpire.Coop.CoopAssembler.Complete)`](CoopReception.cs.md#symbol-15289643ead0)；[`NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`](CoopCoordinator.cs.md#symbol-4239da75be84)；[`NationalSpire.Coop.CoopCoordinator.ReceiveError(System.Exception)`](CoopReception.cs.md#symbol-fb570e3c7ba0)；[`NationalSpire.Coop.CoopCoordinator.ReceiveNow(ulong, NationalSpire.Coop.CoopWire, System.DateTime)`](CoopCoordinator.cs.md#symbol-796041df5e9f)；[`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`](CoopCoordinator.cs.md#symbol-0145ddb8062f)；`NationalSpire.Coop.CoopCoordinator.ReceivedWork.ReceivedWork(System.Func<bool>, System.Action?, System.Action?, bool)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Collections.Generic.Queue<T>.Enqueue(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopAssembler.Collect(NationalSpire.Coop.CoopPart, System.DateTime)`；`NationalSpire.Coop.CoopCoordinator._assembler`；`NationalSpire.Coop.CoopCoordinator._closed`；`NationalSpire.Coop.CoopCoordinator._received`；`NationalSpire.Coop.CoopCoordinator._seen`；`NationalSpire.Coop.CoopCoordinator._transport`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.QueueSnapshot(ulong, NationalSpire.Coop.CoopAssembler.Complete)`；`NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`；`NationalSpire.Coop.CoopCoordinator.ReceiveError(System.Exception)`；`NationalSpire.Coop.CoopCoordinator.ReceiveNow(ulong, NationalSpire.Coop.CoopWire, System.DateTime)`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；`NationalSpire.Coop.CoopHeartbeat.Epoch`；`NationalSpire.Coop.CoopHeartbeat.Online`；`NationalSpire.Coop.CoopWire.Kind`；`NationalSpire.Coop.ICoopTransport.Owner`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopAssembler.Collect(NationalSpire.Coop.CoopPart, System.DateTime)`；输入表达式：`_assembler.Collect(Read<CoopPart>(wire), received)`；返回值紧邻使用处：`IsPatternExpressionSyntax: _assembler.Collect(Read<CoopPart>(wire), received) is { } complete`
- `NationalSpire.Coop.CoopCoordinator.QueueSnapshot(ulong, NationalSpire.Coop.CoopAssembler.Complete)`；输入表达式：`QueueSnapshot(sender, complete)`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueSnapshot(sender, complete);`
- `NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`；输入表达式：`Read<CoopHeartbeat>(wire)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Read<CoopHeartbeat>(wire)`
- `NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`；输入表达式：`Read<CoopPart>(wire)`；返回值紧邻使用处：`ArgumentSyntax: Read<CoopPart>(wire)`
- `NationalSpire.Coop.CoopCoordinator.ReceivedWork.ReceivedWork(System.Func<bool>, System.Action?, System.Action?, bool)`；输入表达式：`new(() => true, () => ReceiveNow(sender, wire, received))`；返回值紧邻使用处：`ArgumentSyntax: new(() => true, () => ReceiveNow(sender, wire, received))`
- `NationalSpire.Coop.CoopCoordinator.ReceiveError(System.Exception)`；输入表达式：`ReceiveError(error)`；返回值紧邻使用处：`ExpressionStatementSyntax: ReceiveError(error);`
- `NationalSpire.Coop.CoopCoordinator.ReceiveNow(ulong, NationalSpire.Coop.CoopWire, System.DateTime)`；输入表达式：`ReceiveNow(sender, wire, DateTime.UtcNow)`；返回值紧邻使用处：`ExpressionStatementSyntax: ReceiveNow(sender, wire, DateTime.UtcNow);`
- `NationalSpire.Coop.CoopCoordinator.ReceiveNow(ulong, NationalSpire.Coop.CoopWire, System.DateTime)`；输入表达式：`ReceiveNow(sender, wire, received)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ReceiveNow(sender, wire, received)`
- `NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；输入表达式：`Send(sender, "pong", heartbeat.Epoch)`；返回值紧邻使用处：`ExpressionStatementSyntax: Send(sender, "pong", heartbeat.Epoch);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_seen.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _seen.Clear();`
- `System.Collections.Generic.Queue<T>.Enqueue(T)`；输入表达式：`_received.Enqueue(new(() => true, () => ReceiveNow(sender, wire, received)))`；返回值紧邻使用处：`ExpressionStatementSyntax: _received.Enqueue(new(() => true, () => ReceiveNow(sender, wire, received)));`

**赋值（含属性/字段和局部值）：**

- `_seen[id]` = `received`
- `_seen[sender]` = `received`

<a id="symbol-796041df5e9f"></a>

## `NationalSpire.Coop.CoopCoordinator.ReceiveNow(ulong, NationalSpire.Coop.CoopWire, System.DateTime) — private void ReceiveNow(ulong sender, CoopWire wire, DateTime received)`

来源：源码第 123 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.Receive(ulong, NationalSpire.Coop.CoopWire)`](CoopCoordinator.cs.md#symbol-892f19740afa)

**调用：** [`NationalSpire.Coop.CoopAssembler.Add(NationalSpire.Coop.CoopPart, System.DateTime)`](CoopWire.cs.md#symbol-e6ffa10e5388)；[`NationalSpire.Coop.CoopContentIdentity.Difference(string, string)`](CoopContentIdentity.cs.md#symbol-71a611ce4e39)；[`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`](CoopCoordinator.cs.md#symbol-e1dfe22e8221)；[`NationalSpire.Coop.CoopCoordinator.CompleteReplies()`](CoopCoordinator.cs.md#symbol-4f91858a07d3)；[`NationalSpire.Coop.CoopCoordinator.Execute(ulong, NationalSpire.Coop.CoopCommand)`](CoopCoordinator.cs.md#symbol-ec0c662c6de0)；[`NationalSpire.Coop.CoopCoordinator.Rate(ulong)`](CoopCoordinator.cs.md#symbol-d72b98487984)；[`NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`](CoopCoordinator.cs.md#symbol-4239da75be84)；[`NationalSpire.Coop.CoopCoordinator.ReceiveDiagnostic(ulong, NationalSpire.Coop.CoopWire)`](CoopDiagnostics.cs.md#symbol-fefabf8d6a26)；[`NationalSpire.Coop.CoopCoordinator.ReceiveMarket(ulong, NationalSpire.Coop.CoopWire)`](CoopMarket.cs.md#symbol-1d6c27a5f526)；[`NationalSpire.Coop.CoopCoordinator.ReceivePrivate(NationalSpire.Coop.CoopWire, System.DateTime)`](CoopPrivateMessages.cs.md#symbol-eca8b0236539)；[`NationalSpire.Coop.CoopCoordinator.RecordJoinError(string)`](CoopCoordinator.cs.md#symbol-a8a225b353ea)；[`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`](CoopCoordinator.cs.md#symbol-0145ddb8062f)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`](CoopData.cs.md#symbol-85d2410ea3ba)；[`NationalSpire.Coop.CoopJson.Read<T>(byte[])`](CoopData.cs.md#symbol-1f7bf7625062)；[`NationalSpire.Coop.CoopRules.AddMember(NationalSpire.Coop.CoopWorld, ulong, string)`](CoopRules.cs.md#symbol-fedd425e9ea0)；[`NationalSpire.Diagnostics.Error(string, System.Exception)`](../Diagnostics.cs.md#symbol-cb39203375a5)；`NationalSpire.Coop.CoopOutcome.CoopOutcome(bool, string, bool)`；`NationalSpire.Coop.CoopReply.CoopReply(string, NationalSpire.Coop.CoopOutcome, long)`；`NationalSpire.Coop.CoopWire.CoopWire(string, string)`；`string.StartsWith(string, System.StringComparison)`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `(NationalSpire.Coop.CoopCommand Command, System.DateTime Sent, NationalSpire.Coop.CoopReply? Reply).Command`；`(NationalSpire.Coop.CoopCommand Command, System.DateTime Sent, NationalSpire.Coop.CoopReply? Reply).Sent`；`<anonymous type: ulong sender, string payload>.payload`；`NationalSpire.Coop.CoopAssembler.Add(NationalSpire.Coop.CoopPart, System.DateTime)`；`NationalSpire.Coop.CoopCommand.Id`；`NationalSpire.Coop.CoopCommand.Kind`；`NationalSpire.Coop.CoopCommand.Target`；`NationalSpire.Coop.CoopContentIdentity.Difference(string, string)`；`NationalSpire.Coop.CoopCoordinator._closed`；`NationalSpire.Coop.CoopCoordinator._compatibility`；`NationalSpire.Coop.CoopCoordinator._liveAssembler`；`NationalSpire.Coop.CoopCoordinator._pendingCommands`；`NationalSpire.Coop.CoopCoordinator._preparedView`；`NationalSpire.Coop.CoopCoordinator._seen`；`NationalSpire.Coop.CoopCoordinator._token`；`NationalSpire.Coop.CoopCoordinator._transport`；`NationalSpire.Coop.CoopCoordinator.Changed`；`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；`NationalSpire.Coop.CoopCoordinator.CompleteReplies()`；`NationalSpire.Coop.CoopCoordinator.Execute(ulong, NationalSpire.Coop.CoopCommand)`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.NativeSave`；`NationalSpire.Coop.CoopCoordinator.Rate(ulong)`；`NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`；`NationalSpire.Coop.CoopCoordinator.ReceiveDiagnostic(ulong, NationalSpire.Coop.CoopWire)`；`NationalSpire.Coop.CoopCoordinator.ReceiveMarket(ulong, NationalSpire.Coop.CoopWire)`；`NationalSpire.Coop.CoopCoordinator.ReceivePrivate(NationalSpire.Coop.CoopWire, System.DateTime)`；`NationalSpire.Coop.CoopCoordinator.RecordJoinError(string)`；`NationalSpire.Coop.CoopCoordinator.RunMessage`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；`NationalSpire.Coop.CoopCoordinator.Status`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopHeartbeat.Epoch`；`NationalSpire.Coop.CoopHello.Compatibility`；`NationalSpire.Coop.CoopHello.Name`；`NationalSpire.Coop.CoopHello.Protocol`；`NationalSpire.Coop.CoopHello.Token`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`；`NationalSpire.Coop.CoopJson.Read<T>(byte[])`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopOutcome.Accepted`；`NationalSpire.Coop.CoopOutcome.Message`；`NationalSpire.Coop.CoopProposal.Id`；`NationalSpire.Coop.CoopProposal.Votes`；`NationalSpire.Coop.CoopReply.Id`；`NationalSpire.Coop.CoopReply.Outcome`；`NationalSpire.Coop.CoopRules.AddMember(NationalSpire.Coop.CoopWorld, ulong, string)`；`NationalSpire.Coop.CoopRun.Attempt`；`NationalSpire.Coop.CoopRun.Phase`；`NationalSpire.Coop.CoopRun.ResumeCount`；`NationalSpire.Coop.CoopWire.Kind`；`NationalSpire.Coop.CoopWire.Payload`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Proposal`；`NationalSpire.Coop.CoopWorld.Protocol`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.Coop.ICoopTransport.Owner`；`NationalSpire.Diagnostics.Error(string, System.Exception)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopAssembler.Add(NationalSpire.Coop.CoopPart, System.DateTime)`；输入表达式：`_liveAssembler.Add(Read<CoopPart>(wire), received)`；返回值紧邻使用处：`IsPatternExpressionSyntax: _liveAssembler.Add(Read<CoopPart>(wire), received) is not { } liveBytes`
- `NationalSpire.Coop.CoopContentIdentity.Difference(string, string)`；输入表达式：`CoopContentIdentity.Difference(_compatibility, hello.Compatibility)`；返回值紧邻使用处：`ConditionalExpressionSyntax: hello.Protocol != CoopWorld.Protocol ? $"国运尖塔联机协议不同：房主 {CoopWorld.Protocol}，客机 {hello.Protocol}。请双方更新模组并完全重启游戏。"                      : CoopContentIdentity.Difference(_compatibility, hello.Compatibility)`
- `NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；输入表达式：`Commit(copy, NativeSave)`；返回值紧邻使用处：`ExpressionStatementSyntax: Commit(copy, NativeSave);`
- `NationalSpire.Coop.CoopCoordinator.CompleteReplies()`；输入表达式：`CompleteReplies()`；返回值紧邻使用处：`ExpressionStatementSyntax: CompleteReplies();`
- `NationalSpire.Coop.CoopCoordinator.Execute(ulong, NationalSpire.Coop.CoopCommand)`；输入表达式：`Execute(sender, command)`；返回值紧邻使用处：`ExpressionStatementSyntax: Execute(sender, command);`
- `NationalSpire.Coop.CoopCoordinator.Rate(ulong)`；输入表达式：`Rate(sender)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Rate(sender)`
- `NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`；输入表达式：`Read<CoopCommand>(wire)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Read<CoopCommand>(wire)`
- `NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`；输入表达式：`Read<CoopHeartbeat>(wire)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Read<CoopHeartbeat>(wire)`
- `NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`；输入表达式：`Read<CoopHello>(wire)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Read<CoopHello>(wire)`
- `NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`；输入表达式：`Read<CoopPart>(wire)`；返回值紧邻使用处：`ArgumentSyntax: Read<CoopPart>(wire)`
- `NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`；输入表达式：`Read<CoopReply>(wire)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Read<CoopReply>(wire)`
- `NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`；输入表达式：`Read<string>(wire)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Status = Read<string>(wire)`
- `NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`；输入表达式：`Read<string>(wire)`；返回值紧邻使用处：`BinaryExpressionSyntax: Read<string>(wire) == World!.Epoch`
- `NationalSpire.Coop.CoopCoordinator.ReceiveDiagnostic(ulong, NationalSpire.Coop.CoopWire)`；输入表达式：`ReceiveDiagnostic(sender, wire)`；返回值紧邻使用处：`ExpressionStatementSyntax: ReceiveDiagnostic(sender, wire);`
- `NationalSpire.Coop.CoopCoordinator.ReceiveMarket(ulong, NationalSpire.Coop.CoopWire)`；输入表达式：`ReceiveMarket(sender, wire)`；返回值紧邻使用处：`ExpressionStatementSyntax: ReceiveMarket(sender, wire);`
- `NationalSpire.Coop.CoopCoordinator.ReceivePrivate(NationalSpire.Coop.CoopWire, System.DateTime)`；输入表达式：`ReceivePrivate(wire, received)`；返回值紧邻使用处：`ExpressionStatementSyntax: ReceivePrivate(wire, received);`
- `NationalSpire.Coop.CoopCoordinator.RecordJoinError(string)`；输入表达式：`RecordJoinError(error)`；返回值紧邻使用处：`ExpressionStatementSyntax: RecordJoinError(error);`
- `NationalSpire.Coop.CoopCoordinator.RecordJoinError(string)`；输入表达式：`RecordJoinError(Status)`；返回值紧邻使用处：`ExpressionStatementSyntax: RecordJoinError(Status);`
- `NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；输入表达式：`Send(sender, "error", error)`；返回值紧邻使用处：`ExpressionStatementSyntax: Send(sender, "error", error);`
- `NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；输入表达式：`Send(sender, "reply", new CoopReply(command.Id, new(false, "操作过于频繁，请稍后再试。")))`；返回值紧邻使用处：`ExpressionStatementSyntax: Send(sender, "reply", new CoopReply(command.Id, new(false, "操作过于频繁，请稍后再试。")));`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(World)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Copy(World)`
- `NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`；输入表达式：`CoopJson.Detached(copy.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopJson.Detached(copy.World);`
- `NationalSpire.Coop.CoopJson.Read<T>(byte[])`；输入表达式：`CoopJson.Read<CoopRun>(liveBytes)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Read<CoopRun>(liveBytes)`
- `NationalSpire.Coop.CoopOutcome.CoopOutcome(bool, string, bool)`；输入表达式：`new(false, "操作过于频繁，请稍后再试。")`；返回值紧邻使用处：`ArgumentSyntax: new(false, "操作过于频繁，请稍后再试。")`
- `NationalSpire.Coop.CoopReply.CoopReply(string, NationalSpire.Coop.CoopOutcome, long)`；输入表达式：`new CoopReply(command.Id, new(false, "操作过于频繁，请稍后再试。"))`；返回值紧邻使用处：`ArgumentSyntax: new CoopReply(command.Id, new(false, "操作过于频繁，请稍后再试。"))`
- `NationalSpire.Coop.CoopRules.AddMember(NationalSpire.Coop.CoopWorld, ulong, string)`；输入表达式：`CoopRules.AddMember(copy, sender, hello.Name)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopRules.AddMember(copy, sender, hello.Name);`
- `NationalSpire.Coop.CoopWire.CoopWire(string, string)`；输入表达式：`new(wire.Kind, JsonSerializer.Serialize(new { sender, payload = wire.Payload }))`；返回值紧邻使用处：`ArgumentSyntax: new(wire.Kind, JsonSerializer.Serialize(new { sender, payload = wire.Payload }))`
- `NationalSpire.Diagnostics.Error(string, System.Exception)`；输入表达式：`Diagnostics.Error("coop.receive", e)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Error("coop.receive", e);`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`wire.Kind.StartsWith("run-", StringComparison.Ordinal)`；返回值紧邻使用处：`IfStatementSyntax: if (wire.Kind.StartsWith("run-", StringComparison.Ordinal)) RunMessage?.Invoke(new(wire.Kind, JsonSerializer.Serialize(new { sender, payload = wire.Payload })));`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Changed?.Invoke()`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(new(wire.Kind, JsonSerializer.Serialize(new { sender, payload = wire.Payload })))`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: RunMessage?.Invoke(new(wire.Kind, JsonSerializer.Serialize(new { sender, payload = wire.Payload })))`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`_seen.ContainsKey(sender)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_seen.ContainsKey(sender)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_pendingCommands.TryGetValue(reply.Id, out var pending)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_pendingCommands.TryGetValue(reply.Id, out var pending)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`World.Proposal.Votes.Add(Self)`；返回值紧邻使用处：`ExpressionStatementSyntax: World.Proposal.Votes.Add(Self);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`World.Members.Any(m => m.SteamId == sender)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !World.Members.Any(m => m.SteamId == sender)`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(new { sender, payload = wire.Payload })`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(new { sender, payload = wire.Payload })`

**赋值（含属性/字段和局部值）：**

- `_pendingCommands[reply.Id]` = `(pending.Command, pending.Sent, reply)`
- `_preparedView` = `null`
- `_seen[sender]` = `DateTime.UtcNow`
- `copy.Proposal` = `null`
- `NativeSave` = `null`
- `Status` = `"同步操作失败：" + e.Message`
- `Status` = `Read<string>(wire)`
- `Status` = `reply.Outcome.Accepted ? "主机已确认，正在同步。" : reply.Outcome.Message`
- `World.Run` = `live`
- `World` = `null`

<a id="symbol-a8a225b353ea"></a>

## `NationalSpire.Coop.CoopCoordinator.RecordJoinError(string) — private void RecordJoinError(string error)`

来源：源码第 181 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.ReceiveNow(ulong, NationalSpire.Coop.CoopWire, System.DateTime)`](CoopCoordinator.cs.md#symbol-796041df5e9f)

**调用：** [`NationalSpire.Diagnostics.Record(string, object)`](../Diagnostics.cs.md#symbol-1b5632793cd0)；`System.Console.WriteLine(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator._lastJoinError`；`NationalSpire.Diagnostics.Record(string, object)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("coop.join.rejected", error)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("coop.join.rejected", error);`
- `System.Console.WriteLine(string?)`；输入表达式：`Console.WriteLine("[NationalSpire] " + error)`；返回值紧邻使用处：`ExpressionStatementSyntax: Console.WriteLine("[NationalSpire] " + error);`

**赋值（含属性/字段和局部值）：**

- `_lastJoinError` = `error`

<a id="symbol-d72b98487984"></a>

## `NationalSpire.Coop.CoopCoordinator.Rate(ulong) — private bool Rate(ulong sender)`

来源：源码第 188 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.ReceiveNow(ulong, NationalSpire.Coop.CoopWire, System.DateTime)`](CoopCoordinator.cs.md#symbol-796041df5e9f)

**调用：** `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.TimeSpan.FromSeconds(long)`

**字段、属性、事件及方法组引用：** `(System.DateTime At, int Count).At`；`(System.DateTime At, int Count).Count`；`NationalSpire.Coop.CoopCoordinator._rates`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`_rates.GetValueOrDefault(sender)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _rates.GetValueOrDefault(sender)`
- `System.TimeSpan.FromSeconds(long)`；输入表达式：`TimeSpan.FromSeconds(10)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateTime.UtcNow - rate.At > TimeSpan.FromSeconds(10)`

**赋值（含属性/字段和局部值）：**

- `_rates[sender]` = `(rate.At, rate.Count + 1)`
- `rate` = `(DateTime.UtcNow, 0)`

<a id="symbol-d7ec39d842f3"></a>

## `NationalSpire.Coop.CoopCoordinator.Submit(string, string, string, int, string) — public CoopCommand Submit(string kind, string target = "", string text = "", int number = 0, string parent = "")`

来源：源码第 194 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopCoordinator.SubmitReady(NationalSpire.Coop.CoopCommand, System.Action<NationalSpire.Coop.CoopCommand>, System.Action<System.Exception>)`](CoopReception.cs.md#symbol-ebee1cc829c5)；`NationalSpire.Coop.CoopCommand.CoopCommand(string, string, string, long, string, string, string, int, string)`；`NationalSpire.Coop.CoopOutcome.CoopOutcome(bool, string, bool)`；`NationalSpire.Coop.CoopReply.CoopReply(string, NationalSpire.Coop.CoopOutcome, long)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCommand.Id`；`NationalSpire.Coop.CoopCoordinator.Replied`；`NationalSpire.Coop.CoopCoordinator.SubmitReady(NationalSpire.Coop.CoopCommand, System.Action<NationalSpire.Coop.CoopCommand>, System.Action<System.Exception>)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.CoopWorld.Revision`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCommand.CoopCommand(string, string, string, long, string, string, string, int, string)`；输入表达式：`new CoopCommand(w.Id, w.Epoch, Guid.NewGuid().ToString("N"), w.Revision, kind, target, text, number, parent)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CoopCommand(w.Id, w.Epoch, Guid.NewGuid().ToString("N"), w.Revision, kind, target, text, number, parent)`
- `NationalSpire.Coop.CoopCoordinator.SubmitReady(NationalSpire.Coop.CoopCommand, System.Action<NationalSpire.Coop.CoopCommand>, System.Action<System.Exception>)`；输入表达式：`SubmitReady(command, _ => { }, error => Replied?.Invoke(new(command.Id, new(false, error.Message))))`；返回值紧邻使用处：`ExpressionStatementSyntax: SubmitReady(command, _ => { }, error => Replied?.Invoke(new(command.Id, new(false, error.Message))));`
- `NationalSpire.Coop.CoopOutcome.CoopOutcome(bool, string, bool)`；输入表达式：`new(false, error.Message)`；返回值紧邻使用处：`ArgumentSyntax: new(false, error.Message)`
- `NationalSpire.Coop.CoopReply.CoopReply(string, NationalSpire.Coop.CoopOutcome, long)`；输入表达式：`new(command.Id, new(false, error.Message))`；返回值紧邻使用处：`ArgumentSyntax: new(command.Id, new(false, error.Message))`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(new(command.Id, new(false, error.Message)))`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Replied?.Invoke(new(command.Id, new(false, error.Message)))`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`ArgumentSyntax: Guid.NewGuid().ToString("N")`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("世界尚未同步。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidOperationException("世界尚未同步。")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-11ae699cefda"></a>

## `NationalSpire.Coop.CoopCoordinator.Retry(NationalSpire.Coop.CoopCommand) — public void Retry(CoopCommand command)`

来源：源码第 200 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.Tick()`](CoopCoordinator.cs.md#symbol-4253349561bc)；[`Submit()`](CoopReception.cs.md#symbol-690f4f77e4f1)

**调用：** [`NationalSpire.Coop.CoopCoordinator.Execute(ulong, NationalSpire.Coop.CoopCommand)`](CoopCoordinator.cs.md#symbol-ec0c662c6de0)；[`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`](CoopCoordinator.cs.md#symbol-0145ddb8062f)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.TimeSpan.FromSeconds(long)`

**字段、属性、事件及方法组引用：** `(NationalSpire.Coop.CoopCommand Command, System.DateTime Sent, NationalSpire.Coop.CoopReply? Reply).Reply`；`(NationalSpire.Coop.CoopCommand Command, System.DateTime Sent, NationalSpire.Coop.CoopReply? Reply).Sent`；`NationalSpire.Coop.CoopCommand.Id`；`NationalSpire.Coop.CoopCoordinator._pendingCommands`；`NationalSpire.Coop.CoopCoordinator._transport`；`NationalSpire.Coop.CoopCoordinator.Execute(ulong, NationalSpire.Coop.CoopCommand)`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；`NationalSpire.Coop.ICoopTransport.Owner`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCoordinator.Execute(ulong, NationalSpire.Coop.CoopCommand)`；输入表达式：`Execute(Self, command)`；返回值紧邻使用处：`ExpressionStatementSyntax: Execute(Self, command);`
- `NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；输入表达式：`Send(_transport.Owner, "command", command)`；返回值紧邻使用处：`ExpressionStatementSyntax: Send(_transport.Owner, "command", command);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_pendingCommands.TryGetValue(command.Id, out var previous)`；返回值紧邻使用处：`BinaryExpressionSyntax: _pendingCommands.TryGetValue(command.Id, out var previous)              && (previous.Reply != null || DateTime.UtcNow - previous.Sent < TimeSpan.FromSeconds(3))`
- `System.TimeSpan.FromSeconds(long)`；输入表达式：`TimeSpan.FromSeconds(3)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateTime.UtcNow - previous.Sent < TimeSpan.FromSeconds(3)`

**赋值（含属性/字段和局部值）：**

- `_pendingCommands[command.Id]` = `(command, DateTime.UtcNow, null)`

<a id="symbol-4f91858a07d3"></a>

## `NationalSpire.Coop.CoopCoordinator.CompleteReplies() — private void CompleteReplies()`

来源：源码第 208 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.QueueSnapshot(ulong, NationalSpire.Coop.CoopAssembler.Complete)`](CoopReception.cs.md#symbol-15289643ead0)；[`NationalSpire.Coop.CoopCoordinator.ReceiveNow(ulong, NationalSpire.Coop.CoopWire, System.DateTime)`](CoopCoordinator.cs.md#symbol-796041df5e9f)

**调用：** `NationalSpire.Coop.CoopOutcome.CoopOutcome(bool, string, bool)`；`NationalSpire.Coop.CoopReply.CoopReply(string, NationalSpire.Coop.CoopOutcome, long)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `(NationalSpire.Coop.CoopCommand Command, System.DateTime Sent, NationalSpire.Coop.CoopReply Reply).Command`；`(NationalSpire.Coop.CoopCommand Command, System.DateTime Sent, NationalSpire.Coop.CoopReply Reply).Reply`；`NationalSpire.Coop.CoopCommand.Epoch`；`NationalSpire.Coop.CoopCommand.Id`；`NationalSpire.Coop.CoopCommand.World`；`NationalSpire.Coop.CoopCoordinator._pendingCommands`；`NationalSpire.Coop.CoopCoordinator.Replied`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopOutcome.Accepted`；`NationalSpire.Coop.CoopReply.Id`；`NationalSpire.Coop.CoopReply.Outcome`；`NationalSpire.Coop.CoopReply.Revision`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.CoopWorld.Revision`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopOutcome.CoopOutcome(bool, string, bool)`；输入表达式：`new(false, "房间会话已改变，请重新操作。")`；返回值紧邻使用处：`ArgumentSyntax: new(false, "房间会话已改变，请重新操作。")`
- `NationalSpire.Coop.CoopReply.CoopReply(string, NationalSpire.Coop.CoopOutcome, long)`；输入表达式：`new(pending.Command.Id, new(false, "房间会话已改变，请重新操作。"))`；返回值紧邻使用处：`ArgumentSyntax: new(pending.Command.Id, new(false, "房间会话已改变，请重新操作。"))`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(new(pending.Command.Id, new(false, "房间会话已改变，请重新操作。")))`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Replied?.Invoke(new(pending.Command.Id, new(false, "房间会话已改变，请重新操作。")))`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(reply)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Replied?.Invoke(reply)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`_pendingCommands.Remove(pending.Command.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: _pendingCommands.Remove(pending.Command.Id);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`_pendingCommands.Remove(reply.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: _pendingCommands.Remove(reply.Id);`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_pendingCommands.Values.ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var pending in _pendingCommands.Values.ToArray())          {              if (World != null && (pending.Command.World != World.Id || pending.Command.Epoch != World.Epoch))              {                  _pendingCommands.Remove(pending.Command.Id);                  Replied?.Invoke(new(pending.Command.Id, new(false, "房间会话已改变，请重新操作。")));                  continue;              }              if (pending.Reply is not { } reply) continue;              if (reply.Outcome.Accepted && (World == null || World.Revision < reply.Revision)) continue;              _pendingCommands.Remove(reply.Id);              Replied?.Invoke(reply);          }`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ec0c662c6de0"></a>

## `NationalSpire.Coop.CoopCoordinator.Execute(ulong, NationalSpire.Coop.CoopCommand) — private void Execute(ulong sender, CoopCommand command)`

来源：源码第 224 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.ReceiveNow(ulong, NationalSpire.Coop.CoopWire, System.DateTime)`](CoopCoordinator.cs.md#symbol-796041df5e9f)；[`NationalSpire.Coop.CoopCoordinator.Retry(NationalSpire.Coop.CoopCommand)`](CoopCoordinator.cs.md#symbol-11ae699cefda)

**调用：** [`NationalSpire.Coop.CoopCoordinator.Broadcast()`](CoopCoordinator.cs.md#symbol-8a047804722d)；[`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`](CoopCoordinator.cs.md#symbol-e1dfe22e8221)；[`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`](CoopCoordinator.cs.md#symbol-0145ddb8062f)；[`NationalSpire.Coop.CoopCoordinator.StartEvent(ulong, NationalSpire.Coop.CoopCommand)`](CoopRandomEvents.cs.md#symbol-b51ea4166eab)；[`NationalSpire.Coop.CoopCoordinator.StartGroup(ulong, NationalSpire.Coop.CoopCommand)`](CoopGroupChats.cs.md#symbol-83d332761336)；[`NationalSpire.Coop.CoopCoordinator.StartPrivate(ulong, NationalSpire.Coop.CoopCommand)`](CoopPrivateMessages.cs.md#symbol-ebc3f29b5eb6)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](CoopRules.cs.md#symbol-71eae0adc0d0)；[`NationalSpire.Diagnostics.Record(string, object)`](../Diagnostics.cs.md#symbol-1b5632793cd0)；`NationalSpire.Coop.CoopReply.CoopReply(string, NationalSpire.Coop.CoopOutcome, long)`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `(NationalSpire.Coop.CoopWorld World, NationalSpire.Coop.CoopOutcome Outcome).Outcome`；`(NationalSpire.Coop.CoopWorld World, NationalSpire.Coop.CoopOutcome Outcome).World`；`<anonymous type: string world, ulong sender, string Id, string Kind, long Revision, bool Accepted, bool Duplicate, string Message>.world`；`NationalSpire.Coop.CoopCommand.Id`；`NationalSpire.Coop.CoopCommand.Kind`；`NationalSpire.Coop.CoopCommand.Revision`；`NationalSpire.Coop.CoopCoordinator._characters`；`NationalSpire.Coop.CoopCoordinator.Broadcast()`；`NationalSpire.Coop.CoopCoordinator.Changed`；`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；`NationalSpire.Coop.CoopCoordinator.NativeSave`；`NationalSpire.Coop.CoopCoordinator.Online`；`NationalSpire.Coop.CoopCoordinator.Replied`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；`NationalSpire.Coop.CoopCoordinator.StartEvent(ulong, NationalSpire.Coop.CoopCommand)`；`NationalSpire.Coop.CoopCoordinator.StartGroup(ulong, NationalSpire.Coop.CoopCommand)`；`NationalSpire.Coop.CoopCoordinator.StartPrivate(ulong, NationalSpire.Coop.CoopCommand)`；`NationalSpire.Coop.CoopCoordinator.Status`；`NationalSpire.Coop.CoopCoordinator.TriggerAi`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopOutcome.Accepted`；`NationalSpire.Coop.CoopOutcome.Duplicate`；`NationalSpire.Coop.CoopOutcome.Message`；`NationalSpire.Coop.CoopReply.Outcome`；`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`；`NationalSpire.Coop.CoopRun.Attempt`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.CoopWorld.Revision`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Diagnostics.Record(string, object)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCoordinator.Broadcast()`；输入表达式：`Broadcast()`；返回值紧邻使用处：`ExpressionStatementSyntax: Broadcast();`
- `NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；输入表达式：`Commit(result.World, result.World.Run?.Attempt == World.Run?.Attempt && result.World.Run != null ? NativeSave : null, false)`；返回值紧邻使用处：`ExpressionStatementSyntax: Commit(result.World, result.World.Run?.Attempt == World.Run?.Attempt && result.World.Run != null ? NativeSave : null, false);`
- `NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；输入表达式：`Send(sender, "reply", reply)`；返回值紧邻使用处：`ExpressionStatementSyntax: Send(sender, "reply", reply);`
- `NationalSpire.Coop.CoopCoordinator.StartEvent(ulong, NationalSpire.Coop.CoopCommand)`；输入表达式：`StartEvent(sender, command)`；返回值紧邻使用处：`ExpressionStatementSyntax: StartEvent(sender, command);`
- `NationalSpire.Coop.CoopCoordinator.StartGroup(ulong, NationalSpire.Coop.CoopCommand)`；输入表达式：`StartGroup(sender, command)`；返回值紧邻使用处：`ExpressionStatementSyntax: StartGroup(sender, command);`
- `NationalSpire.Coop.CoopCoordinator.StartPrivate(ulong, NationalSpire.Coop.CoopCommand)`；输入表达式：`StartPrivate(sender, command)`；返回值紧邻使用处：`ExpressionStatementSyntax: StartPrivate(sender, command);`
- `NationalSpire.Coop.CoopReply.CoopReply(string, NationalSpire.Coop.CoopOutcome, long)`；输入表达式：`new CoopReply(command.Id, result.Outcome, World.Revision)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CoopReply(command.Id, result.Outcome, World.Revision)`
- `NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`；输入表达式：`CoopRules.Apply(World, sender, command, Online, _characters)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopRules.Apply(World, sender, command, Online, _characters)`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("coop.command", new { world = World.Id, sender, command.Id, command.Kind, command.Revision, result.Outcome.Accepted, result.Outcome.Duplicate, result.Outcome.Message })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("coop.command", new { world = World.Id, sender, command.Id, command.Kind, command.Revision, result.Outcome.Accepted, result.Outcome.Duplicate, result.Outcome.Message });`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Changed?.Invoke()`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(command.Kind)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: TriggerAi?.Invoke(command.Kind)`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(reply)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Replied?.Invoke(reply)`

**赋值（含属性/字段和局部值）：**

- `Status` = `reply.Outcome.Message`

<a id="symbol-e1dfe22e8221"></a>

## `NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool) — public void Commit(CoopWorld world, byte[]? nativeSave, bool broadcast = true)`

来源：源码第 241 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopAi.ProcessDiscussion(NationalSpire.Coop.CoopWorld, (string Generation, string World, string Epoch, string Message))`](CoopAi.cs.md#symbol-b31e3ccef31a)；[`NationalSpire.Coop.CoopAi.ProcessPublications(bool)`](CoopAi.cs.md#symbol-b4b98ce85f62)；[`NationalSpire.Coop.CoopCareerSession.SaveAi(NationalSpire.CareerData)`](CoopCareerSession.cs.md#symbol-6fb4f052a4e3)；[`NationalSpire.Coop.CoopCoordinator.CoopCoordinator(NationalSpire.Coop.ICoopTransport, NationalSpire.Coop.CoopStorage, string, string, string, System.Collections.Generic.IReadOnlySet<string>, NationalSpire.Coop.CoopStorage.Checkpoint?)`](CoopCoordinator.cs.md#symbol-778097f34ec3)；[`NationalSpire.Coop.CoopCoordinator.Execute(ulong, NationalSpire.Coop.CoopCommand)`](CoopCoordinator.cs.md#symbol-ec0c662c6de0)；[`NationalSpire.Coop.CoopCoordinator.ReceiveNow(ulong, NationalSpire.Coop.CoopWire, System.DateTime)`](CoopCoordinator.cs.md#symbol-796041df5e9f)；[`NationalSpire.Coop.CoopCoordinator.Tick()`](CoopCoordinator.cs.md#symbol-4253349561bc)；[`NationalSpire.Coop.CoopNativeRun.Save(MegaCrit.Sts2.Core.Saves.SerializableRun)`](CoopNativeRun.cs.md#symbol-5825a51bfef3)；[`NationalSpire.Coop.CoopRuntime.Complete(MegaCrit.Sts2.Core.Runs.RunHistory)`](CoopRuntime.cs.md#symbol-732476d12d29)；[`NationalSpire.Coop.CoopRuntime.FinishTerminal()`](CoopRuntime.cs.md#symbol-9dbe454d0582)；[`NationalSpire.Coop.CoopRuntime.PauseCore(string)`](CoopRuntime.cs.md#symbol-60fe2cb26a8e)；[`Save(NationalSpire.CareerData)`](CoopGroupChats.cs.md#symbol-500092220c28)；[`Save(NationalSpire.CareerData)`](CoopPrivateMessages.cs.md#symbol-08dfeba4e37a)；[`Save(NationalSpire.CareerData)`](CoopRandomEvents.cs.md#symbol-5bd2269a96bc)

**调用：** [`NationalSpire.Coop.CoopCoordinator.Broadcast()`](CoopCoordinator.cs.md#symbol-8a047804722d)；[`NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`](CoopData.cs.md#symbol-85d2410ea3ba)；[`NationalSpire.Coop.CoopStorage.Save(NationalSpire.Coop.CoopWorld, byte[]?)`](CoopStorage.cs.md#symbol-a4c240447248)；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator._closed`；`NationalSpire.Coop.CoopCoordinator._storage`；`NationalSpire.Coop.CoopCoordinator.Broadcast()`；`NationalSpire.Coop.CoopCoordinator.Changed`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.NativeSave`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`；`NationalSpire.Coop.CoopStorage.Save(NationalSpire.Coop.CoopWorld, byte[]?)`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.CoopWorld.Owner`；`NationalSpire.Coop.CoopWorld.World`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCoordinator.Broadcast()`；输入表达式：`Broadcast()`；返回值紧邻使用处：`ExpressionStatementSyntax: Broadcast();`
- `NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`；输入表达式：`CoopJson.Detached(World.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopJson.Detached(World.World);`
- `NationalSpire.Coop.CoopStorage.Save(NationalSpire.Coop.CoopWorld, byte[]?)`；输入表达式：`_storage.Save(world, nativeSave)`；返回值紧邻使用处：`ExpressionStatementSyntax: _storage.Save(world, nativeSave);`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Changed?.Invoke()`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("无权提交这个世界。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("无权提交这个世界。");`

**赋值（含属性/字段和局部值）：**

- `NativeSave` = `nativeSave`
- `World` = `world`

<a id="symbol-8a047804722d"></a>

## `NationalSpire.Coop.CoopCoordinator.Broadcast() — public void Broadcast()`

来源：源码第 247 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`](CoopCoordinator.cs.md#symbol-e1dfe22e8221)；[`NationalSpire.Coop.CoopCoordinator.Execute(ulong, NationalSpire.Coop.CoopCommand)`](CoopCoordinator.cs.md#symbol-ec0c662c6de0)

**调用：** [`NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`](../AiSettingsStore.cs.md#symbol-b37e55b3af97)；[`NationalSpire.Coop.CoopAssembler.Split(byte[], bool)`](CoopWire.cs.md#symbol-d89dceccb833)；[`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`](CoopCoordinator.cs.md#symbol-0145ddb8062f)；[`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Encode(ulong, System.Collections.Generic.Dictionary<string, string>)`](CoopPrivateMessages.cs.md#symbol-f433d36af14b)；[`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.SnapshotEncoder(byte[])`](CoopPrivateMessages.cs.md#symbol-ee70e3f1cbb7)；[`NationalSpire.Coop.CoopJson.PublicBytes<T>(T)`](CoopData.cs.md#symbol-3f5e7638f9e9)；[`NationalSpire.PromptLibrary.Get(NationalSpire.AiOptions, string)`](../PromptLibrary.cs.md#symbol-3f64d002bbbe)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](../UiPerformance.cs.md#symbol-fb8ca8555fbe)；`NationalSpire.AiOptions.AiOptions()`；`NationalSpire.Coop.CoopSnapshot.CoopSnapshot(NationalSpire.Coop.CoopWorld, byte[]?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；`NationalSpire.Coop.CoopAssembler.Split(byte[], bool)`；`NationalSpire.Coop.CoopCoordinator._seen`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.NativeSave`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Encode(ulong, System.Collections.Generic.Dictionary<string, string>)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopJson.PublicBytes<T>(T)`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.GroupChatPrompts.SectionIds`；`NationalSpire.PrivateMessagePrompts.SectionIds`；`NationalSpire.PromptLibrary.Get(NationalSpire.AiOptions, string)`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.CoopBroadcast`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiOptions.AiOptions()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；输入表达式：`AiSettingsStore.Load(new())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AiSettingsStore.Load(new())`
- `NationalSpire.Coop.CoopAssembler.Split(byte[], bool)`；输入表达式：`CoopAssembler.Split(encoded.Encode(peer, templates))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CoopAssembler.Split(encoded.Encode(peer, templates)).ToArray`
- `NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；输入表达式：`Send(peer, "snapshot", part)`；返回值紧邻使用处：`ExpressionStatementSyntax: Send(peer, "snapshot", part);`
- `NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Encode(ulong, System.Collections.Generic.Dictionary<string, string>)`；输入表达式：`encoded.Encode(peer, templates)`；返回值紧邻使用处：`ArgumentSyntax: encoded.Encode(peer, templates)`
- `NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.SnapshotEncoder(byte[])`；输入表达式：`new SnapshotEncoder(CoopJson.PublicBytes(new CoopSnapshot(World, NativeSave)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new SnapshotEncoder(CoopJson.PublicBytes(new CoopSnapshot(World, NativeSave)))`
- `NationalSpire.Coop.CoopJson.PublicBytes<T>(T)`；输入表达式：`CoopJson.PublicBytes(new CoopSnapshot(World, NativeSave))`；返回值紧邻使用处：`ArgumentSyntax: CoopJson.PublicBytes(new CoopSnapshot(World, NativeSave))`
- `NationalSpire.Coop.CoopSnapshot.CoopSnapshot(NationalSpire.Coop.CoopWorld, byte[]?)`；输入表达式：`new CoopSnapshot(World, NativeSave)`；返回值紧邻使用处：`ArgumentSyntax: new CoopSnapshot(World, NativeSave)`
- `NationalSpire.PromptLibrary.Get(NationalSpire.AiOptions, string)`；输入表达式：`PromptLibrary.Get(settings, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => PromptLibrary.Get(settings, id)`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.CoopBroadcast)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.CoopBroadcast)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`_seen.ContainsKey(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: p != Self && _seen.ContainsKey(p)`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`PrivateMessagePrompts.SectionIds.Concat(GroupChatPrompts.SectionIds).Append("world")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessagePrompts.SectionIds.Concat(GroupChatPrompts.SectionIds).Append("world").ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`PrivateMessagePrompts.SectionIds.Concat(GroupChatPrompts.SectionIds)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessagePrompts.SectionIds.Concat(GroupChatPrompts.SectionIds).Append`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`World.Members.Select(m => m.SteamId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: World.Members.Select(m => m.SteamId).Where`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`CoopAssembler.Split(encoded.Encode(peer, templates)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopAssembler.Split(encoded.Encode(peer, templates)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`World.Members.Select(m => m.SteamId).Where(p => p != Self && _seen.ContainsKey(p)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = World.Members.Select(m => m.SteamId).Where(p => p != Self && _seen.ContainsKey(p)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`PrivateMessagePrompts.SectionIds.Concat(GroupChatPrompts.SectionIds).Append("world").ToDictionary(id => id, id => PromptLibrary.Get(settings, id))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessagePrompts.SectionIds.Concat(GroupChatPrompts.SectionIds).Append("world").ToDictionary(id => id, id => PromptLibrary.Get(settings, id))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`World.Members.Select(m => m.SteamId).Where(p => p != Self && _seen.ContainsKey(p))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: World.Members.Select(m => m.SteamId).Where(p => p != Self && _seen.ContainsKey(p)).ToArray`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1e3cadd9f597"></a>

## `NationalSpire.Coop.CoopCoordinator.PublishLive() — public void PublishLive()`

来源：源码第 262 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopLive.Update()`](CoopLive.cs.md#symbol-fe745d15ee63)

**调用：** [`NationalSpire.Coop.CoopAssembler.Split(byte[], bool)`](CoopWire.cs.md#symbol-d89dceccb833)；[`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`](CoopCoordinator.cs.md#symbol-0145ddb8062f)；[`NationalSpire.Coop.CoopJson.Bytes<T>(T)`](CoopData.cs.md#symbol-faeb54cab7ee)；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopAssembler.Split(byte[], bool)`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopJson.Bytes<T>(T)`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Run`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopAssembler.Split(byte[], bool)`；输入表达式：`CoopAssembler.Split(CoopJson.Bytes(World.Run))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CoopAssembler.Split(CoopJson.Bytes(World.Run)).ToArray`
- `NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；输入表达式：`Send(member.SteamId, "live", part)`；返回值紧邻使用处：`ExpressionStatementSyntax: Send(member.SteamId, "live", part);`
- `NationalSpire.Coop.CoopJson.Bytes<T>(T)`；输入表达式：`CoopJson.Bytes(World.Run)`；返回值紧邻使用处：`ArgumentSyntax: CoopJson.Bytes(World.Run)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`CoopAssembler.Split(CoopJson.Bytes(World.Run)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopAssembler.Split(CoopJson.Bytes(World.Run)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`World.Members.Where(m => m.SteamId != Self)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var member in World.Members.Where(m => m.SteamId != Self))              foreach (var part in parts) Send(member.SteamId, "live", part);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a57b33d7004f"></a>

## `NationalSpire.Coop.CoopCoordinator.Dispose() — public void Dispose()`

来源：源码第 269 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRuntime.Disconnect()`](CoopRuntime.cs.md#symbol-a4550fd42c36)

**调用：** [`NationalSpire.Coop.CoopCoordinator.CloseDiagnostics()`](CoopDiagnostics.cs.md#symbol-07bc8f9e58a0)；[`NationalSpire.Coop.CoopCoordinator.CloseReceived()`](CoopReception.cs.md#symbol-5e40e274e59c)；`System.IDisposable.Dispose()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator._closed`；`NationalSpire.Coop.CoopCoordinator._transport`；`NationalSpire.Coop.CoopCoordinator.CloseDiagnostics()`；`NationalSpire.Coop.CoopCoordinator.CloseReceived()`；`NationalSpire.Coop.CoopCoordinator.Receive(ulong, NationalSpire.Coop.CoopWire)`；`NationalSpire.Coop.ICoopTransport.Received`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCoordinator.CloseDiagnostics()`；输入表达式：`CloseDiagnostics()`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseDiagnostics();`
- `NationalSpire.Coop.CoopCoordinator.CloseReceived()`；输入表达式：`CloseReceived()`；返回值紧邻使用处：`ExpressionStatementSyntax: CloseReceived();`
- `System.IDisposable.Dispose()`；输入表达式：`_transport.Dispose()`；返回值紧邻使用处：`ExpressionStatementSyntax: _transport.Dispose();`

**赋值（含属性/字段和局部值）：**

- `_closed` = `true`
- `_transport.Received` -= `Receive`
