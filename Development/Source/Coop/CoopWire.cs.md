# Coop/CoopWire.cs

[返回文件依赖索引](../../SOURCE_MAP.md)

源码 SHA-256：`83ACECE36F586B6A518128895B2CDF0B24F3E9EF973AB9184912E29E217EA111`。来源：[源码](../../../Coop/CoopWire.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Coop.CoopWire`、`NationalSpire.Coop.CoopPacketAssembly`、`NationalSpire.Coop.CoopPacketAssembly.Part`、`NationalSpire.Coop.CoopPacketAssembly.Pending`、`NationalSpire.Coop.ICoopTransport`、`NationalSpire.Coop.CoopPart`、`NationalSpire.Coop.CoopAssembler`、`NationalSpire.Coop.CoopAssembler.Complete`。

字段、事件及初始值（源码原样）：

```csharp
private const int ChunkSize = 24000;
private readonly Dictionary<(ulong Peer, string Id), Pending> _pending = [];
event Action<ulong, CoopWire>? Received;
private CoopPart? _header;
private readonly Dictionary<int, byte[]> _parts = [];
private DateTime _started;
```

<a id="symbol-b0a0b417e9fc"></a>

## `NationalSpire.Coop.CoopPacketAssembly.Pending.Header — public Part Header`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-07b525065c14"></a>

## `NationalSpire.Coop.CoopPacketAssembly.Pending.Parts — public Dictionary<int, byte[]> Parts`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1ffd868804d7"></a>

## `NationalSpire.Coop.CoopPacketAssembly.Pack(NationalSpire.Coop.CoopWire) — public static IEnumerable<byte[]> Pack(CoopWire wire)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopSteam.Send(ulong, NationalSpire.Coop.CoopWire)`](CoopSteam.cs.md#symbol-8374c51d760a)

**调用：** [`NationalSpire.Coop.CoopJson.Bytes<T>(T)`](CoopData.cs.md#symbol-faeb54cab7ee)；[`NationalSpire.Coop.CoopJson.Hash(byte[])`](CoopData.cs.md#symbol-ca6c9ee59a2a)；`NationalSpire.Coop.CoopPacketAssembly.Part.Part(string, int, int, string, byte[])`；`NationalSpire.Coop.CoopWire.CoopWire(string, string)`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.Math.Min(int, int)`；`System.Span<T>.ToArray()`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；`T[]?.AsSpan<T>(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopJson.Bytes<T>(T)`；`NationalSpire.Coop.CoopJson.Hash(byte[])`；`NationalSpire.Coop.CoopJson.Options`；`NationalSpire.Coop.CoopPacketAssembly.ChunkSize`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopJson.Bytes<T>(T)`；输入表达式：`CoopJson.Bytes(new CoopWire("packet-part", System.Text.Json.JsonSerializer.Serialize(part, CoopJson.Options)))`；返回值紧邻使用处：`YieldStatementSyntax: yield return CoopJson.Bytes(new CoopWire("packet-part", System.Text.Json.JsonSerializer.Serialize(part, CoopJson.Options)));`
- `NationalSpire.Coop.CoopJson.Bytes<T>(T)`；输入表达式：`CoopJson.Bytes(wire)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Bytes(wire)`
- `NationalSpire.Coop.CoopJson.Hash(byte[])`；输入表达式：`CoopJson.Hash(bytes)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Hash(bytes)`
- `NationalSpire.Coop.CoopPacketAssembly.Part.Part(string, int, int, string, byte[])`；输入表达式：`new Part(id, index, bytes.Length, hash, bytes.AsSpan(offset, size).ToArray())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Part(id, index, bytes.Length, hash, bytes.AsSpan(offset, size).ToArray())`
- `NationalSpire.Coop.CoopWire.CoopWire(string, string)`；输入表达式：`new CoopWire("packet-part", System.Text.Json.JsonSerializer.Serialize(part, CoopJson.Options))`；返回值紧邻使用处：`ArgumentSyntax: new CoopWire("packet-part", System.Text.Json.JsonSerializer.Serialize(part, CoopJson.Options))`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Guid.NewGuid().ToString("N")`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(ChunkSize, bytes.Length - offset)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(ChunkSize, bytes.Length - offset)`
- `System.Span<T>.ToArray()`；输入表达式：`bytes.AsSpan(offset, size).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: bytes.AsSpan(offset, size).ToArray()`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`System.Text.Json.JsonSerializer.Serialize(part, CoopJson.Options)`；返回值紧邻使用处：`ArgumentSyntax: System.Text.Json.JsonSerializer.Serialize(part, CoopJson.Options)`
- `T[]?.AsSpan<T>(int, int)`；输入表达式：`bytes.AsSpan(offset, size)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: bytes.AsSpan(offset, size).ToArray`

**赋值（含属性/字段和局部值）：**

- `offset` += `size`

<a id="symbol-4b11b493c720"></a>

## `NationalSpire.Coop.CoopPacketAssembly.Read(ulong, byte[]) — public CoopWire? Read(ulong peer, byte[] bytes)`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopSteam.Update()`](CoopSteam.cs.md#symbol-fa8dda1e0359)

**调用：** [`NationalSpire.Coop.CoopJson.Hash(byte[])`](CoopData.cs.md#symbol-ca6c9ee59a2a)；[`NationalSpire.Coop.CoopJson.Read<T>(byte[])`](CoopData.cs.md#symbol-1f7bf7625062)；`NationalSpire.Coop.CoopPacketAssembly.Pending.Pending(NationalSpire.Coop.CoopPacketAssembly.Part)`；`System.Array.CopyTo(System.Array, int)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Guid.TryParseExact(string?, string?, out System.Guid)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Math.Min(long, long)`；`System.Span<T>.SequenceEqual<T>(System.ReadOnlySpan<T>)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；`T[]?.AsSpan<T>()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopJson.Hash(byte[])`；`NationalSpire.Coop.CoopJson.Options`；`NationalSpire.Coop.CoopJson.Read<T>(byte[])`；`NationalSpire.Coop.CoopPacketAssembly._pending`；`NationalSpire.Coop.CoopPacketAssembly.ChunkSize`；`NationalSpire.Coop.CoopPacketAssembly.Part.Bytes`；`NationalSpire.Coop.CoopPacketAssembly.Part.Hash`；`NationalSpire.Coop.CoopPacketAssembly.Part.Id`；`NationalSpire.Coop.CoopPacketAssembly.Part.Index`；`NationalSpire.Coop.CoopPacketAssembly.Part.Total`；`NationalSpire.Coop.CoopPacketAssembly.Pending.Header`；`NationalSpire.Coop.CoopPacketAssembly.Pending.Parts`；`NationalSpire.Coop.CoopWire.Kind`；`NationalSpire.Coop.CoopWire.Payload`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopJson.Hash(byte[])`；输入表达式：`CoopJson.Hash(result)`；返回值紧邻使用处：`BinaryExpressionSyntax: CoopJson.Hash(result) != p.Hash`
- `NationalSpire.Coop.CoopJson.Read<T>(byte[])`；输入表达式：`CoopJson.Read<CoopWire>(bytes)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Read<CoopWire>(bytes)`
- `NationalSpire.Coop.CoopJson.Read<T>(byte[])`；输入表达式：`CoopJson.Read<CoopWire>(result)`；返回值紧邻使用处：`ReturnStatementSyntax: return CoopJson.Read<CoopWire>(result);`
- `NationalSpire.Coop.CoopPacketAssembly.Pending.Pending(NationalSpire.Coop.CoopPacketAssembly.Part)`；输入表达式：`new(p)`；返回值紧邻使用处：`AssignmentExpressionSyntax: pending = new(p)`
- `System.Array.CopyTo(System.Array, int)`；输入表达式：`pending.Parts[i].CopyTo(result, i * ChunkSize)`；返回值紧邻使用处：`ExpressionStatementSyntax: pending.Parts[i].CopyTo(result, i * ChunkSize);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`_pending.Remove(key)`；返回值紧邻使用处：`ExpressionStatementSyntax: _pending.Remove(key);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_pending.TryGetValue(key, out var pending)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_pending.TryGetValue(key, out var pending)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`pending.Parts.TryGetValue(p.Index, out var previous)`；返回值紧邻使用处：`BinaryExpressionSyntax: pending.Parts.TryGetValue(p.Index, out var previous) && !previous.AsSpan().SequenceEqual(p.Bytes)`
- `System.Guid.TryParseExact(string?, string?, out System.Guid)`；输入表达式：`Guid.TryParseExact(p.Id, "N", out _)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Guid.TryParseExact(p.Id, "N", out _)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("消息分块内容冲突。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("消息分块内容冲突。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("消息分块为空。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidDataException("消息分块为空。")`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("消息分块无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("消息分块无效。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("消息分块校验失败。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("消息分块校验失败。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("消息分块信息不一致。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("消息分块信息不一致。");`
- `System.Math.Min(long, long)`；输入表达式：`Math.Min(ChunkSize, p.Total - offset)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Bytes.Length != Math.Min(ChunkSize, p.Total - offset)`
- `System.Span<T>.SequenceEqual<T>(System.ReadOnlySpan<T>)`；输入表达式：`previous.AsSpan().SequenceEqual(p.Bytes)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !previous.AsSpan().SequenceEqual(p.Bytes)`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`System.Text.Json.JsonSerializer.Deserialize<Part>(wire.Payload, CoopJson.Options)`；返回值紧邻使用处：`BinaryExpressionSyntax: System.Text.Json.JsonSerializer.Deserialize<Part>(wire.Payload, CoopJson.Options)              ?? throw new InvalidDataException("消息分块为空。")`
- `T[]?.AsSpan<T>()`；输入表达式：`previous.AsSpan()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: previous.AsSpan().SequenceEqual`

**赋值（含属性/字段和局部值）：**

- `_pending[key]` = `pending = new(p)`
- `pending.Parts[p.Index]` = `p.Bytes`
- `pending` = `new(p)`

<a id="symbol-b6a1e8a7621b"></a>

## `NationalSpire.Coop.CoopPacketAssembly.RetainPeers(System.Collections.Generic.IReadOnlySet<ulong>) — public void RetainPeers(IReadOnlySet<ulong> peers)`

来源：源码第 56 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopSteam.Update()`](CoopSteam.cs.md#symbol-fa8dda1e0359)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlySet<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `(ulong Peer, string Id).Peer`；`NationalSpire.Coop.CoopPacketAssembly._pending`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`_pending.Remove(key)`；返回值紧邻使用处：`ExpressionStatementSyntax: _pending.Remove(key);`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_pending.Keys.Where(k => !peers.Contains(k.Peer)).ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var key in _pending.Keys.Where(k => !peers.Contains(k.Peer)).ToArray()) _pending.Remove(key);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_pending.Keys.Where(k => !peers.Contains(k.Peer))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _pending.Keys.Where(k => !peers.Contains(k.Peer)).ToArray`
- `System.Collections.Generic.IReadOnlySet<T>.Contains(T)`；输入表达式：`peers.Contains(k.Peer)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !peers.Contains(k.Peer)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-cd6bfa17797d"></a>

## `NationalSpire.Coop.CoopPacketAssembly.Clear() — public void Clear()`

来源：源码第 60 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopSteam.Dispose()`](CoopSteam.cs.md#symbol-e6ebd27b8764)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopPacketAssembly._pending`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_pending.Clear()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => _pending.Clear()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9d52cfba19dd"></a>

## `NationalSpire.Coop.ICoopTransport.Self —  ulong Self`

来源：源码第 65 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-971f2fd346c0"></a>

## `NationalSpire.Coop.ICoopTransport.Owner —  ulong Owner`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-984bb64766d4"></a>

## `NationalSpire.Coop.ICoopTransport.Peers —  IReadOnlySet<ulong> Peers`

来源：源码第 67 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-fc2e03480549"></a>

## `NationalSpire.Coop.ICoopTransport.Send(ulong, NationalSpire.Coop.CoopWire) — void Send(ulong peer, CoopWire wire);`

来源：源码第 69 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`](CoopCoordinator.cs.md#symbol-0145ddb8062f)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f3bdece34370"></a>

## `NationalSpire.Coop.ICoopTransport.Update() — void Update();`

来源：源码第 70 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.Tick()`](CoopCoordinator.cs.md#symbol-4253349561bc)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d89dceccb833"></a>

## `NationalSpire.Coop.CoopAssembler.Split(byte[], bool) — public static IEnumerable<CoopPart> Split(byte[] raw, bool diagnostic = false)`

来源：源码第 78 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.Broadcast()`](CoopCoordinator.cs.md#symbol-8a047804722d)；[`NationalSpire.Coop.CoopCoordinator.PublishLive()`](CoopCoordinator.cs.md#symbol-1e3cadd9f597)；[`NationalSpire.Coop.CoopCoordinator.ReceiveDiagnostic(ulong, NationalSpire.Coop.CoopWire)`](CoopDiagnostics.cs.md#symbol-fefabf8d6a26)；[`NationalSpire.Coop.CoopCoordinator.StartEvent(ulong, NationalSpire.Coop.CoopCommand)`](CoopRandomEvents.cs.md#symbol-b51ea4166eab)；[`NationalSpire.Coop.CoopCoordinator.StartGroup(ulong, NationalSpire.Coop.CoopCommand)`](CoopGroupChats.cs.md#symbol-83d332761336)；[`NationalSpire.Coop.CoopCoordinator.StartPrivate(ulong, NationalSpire.Coop.CoopCommand)`](CoopPrivateMessages.cs.md#symbol-ebc3f29b5eb6)

**调用：** [`NationalSpire.Coop.CoopJson.Hash(byte[])`](CoopData.cs.md#symbol-ca6c9ee59a2a)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](../UiPerformance.cs.md#symbol-fb8ca8555fbe)；`NationalSpire.Coop.CoopPart.CoopPart(string, int, int, int, string, byte[])`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.IO.Compression.BrotliStream.BrotliStream(System.IO.Stream, System.IO.Compression.CompressionLevel, bool)`；`System.IO.Compression.BrotliStream.Write(System.ReadOnlySpan<byte>)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.MemoryStream.MemoryStream()`；`System.IO.MemoryStream.ToArray()`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopJson.Hash(byte[])`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.CoopCompress`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopJson.Hash(byte[])`；输入表达式：`CoopJson.Hash(bytes)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Hash(bytes)`
- `NationalSpire.Coop.CoopPart.CoopPart(string, int, int, int, string, byte[])`；输入表达式：`new(id, i, count, bytes.Length, hash, bytes[(i * size)..Math.Min(bytes.Length, (i + 1) * size)])`；返回值紧邻使用处：`YieldStatementSyntax: yield return new(id, i, count, bytes.Length, hash, bytes[(i * size)..Math.Min(bytes.Length, (i + 1) * size)]);`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.CoopCompress)`；返回值紧邻使用处：`UsingStatementSyntax: using (UiPerformance.Measure(UiPerformance.Work.CoopCompress))          using (var zip = new BrotliStream(output, CompressionLevel.Fastest, true)) zip.Write(raw);`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Guid.NewGuid().ToString("N")`
- `System.IO.Compression.BrotliStream.BrotliStream(System.IO.Stream, System.IO.Compression.CompressionLevel, bool)`；输入表达式：`new BrotliStream(output, CompressionLevel.Fastest, true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BrotliStream(output, CompressionLevel.Fastest, true)`
- `System.IO.Compression.BrotliStream.Write(System.ReadOnlySpan<byte>)`；输入表达式：`zip.Write(raw)`；返回值紧邻使用处：`ExpressionStatementSyntax: zip.Write(raw);`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("共同生涯超出同步容量。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("共同生涯超出同步容量。");`
- `System.IO.MemoryStream.MemoryStream()`；输入表达式：`new MemoryStream()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MemoryStream()`
- `System.IO.MemoryStream.ToArray()`；输入表达式：`output.ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = output.ToArray()`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(bytes.Length, (i + 1) * size)`；返回值紧邻使用处：`RangeExpressionSyntax: (i * size)..Math.Min(bytes.Length, (i + 1) * size)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8c8a54666033"></a>

## `NationalSpire.Coop.CoopAssembler.Complete.Decode(bool) — public byte[] Decode(bool diagnostic = false)`

来源：源码第 91 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopAssembler.Add(NationalSpire.Coop.CoopPart, System.DateTime)`](CoopWire.cs.md#symbol-e6ffa10e5388)；[`NationalSpire.Coop.CoopCoordinator.ReceiveDiagnostic(ulong, NationalSpire.Coop.CoopWire)`](CoopDiagnostics.cs.md#symbol-fefabf8d6a26)；[`Step()`](CoopReception.cs.md#symbol-41b14a0db411)

**调用：** [`NationalSpire.Coop.CoopJson.Hash(byte[])`](CoopData.cs.md#symbol-ca6c9ee59a2a)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](../UiPerformance.cs.md#symbol-fb8ca8555fbe)；`System.Array.CopyTo(System.Array, int)`；`System.IO.Compression.BrotliStream.BrotliStream(System.IO.Stream, System.IO.Compression.CompressionMode)`；`System.IO.Compression.BrotliStream.Read(System.Span<byte>)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.IO.MemoryStream.MemoryStream()`；`System.IO.MemoryStream.MemoryStream(byte[])`；`System.IO.MemoryStream.ToArray()`；`System.IO.MemoryStream.Write(byte[], int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopAssembler.Complete.Header`；`NationalSpire.Coop.CoopAssembler.Complete.Parts`；`NationalSpire.Coop.CoopJson.Hash(byte[])`；`NationalSpire.Coop.CoopPart.Hash`；`NationalSpire.Coop.CoopPart.Total`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.CoopAssemble`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopJson.Hash(byte[])`；输入表达式：`CoopJson.Hash(bytes)`；返回值紧邻使用处：`BinaryExpressionSyntax: CoopJson.Hash(bytes) != Header.Hash`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.CoopAssemble)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.CoopAssemble)`
- `System.Array.CopyTo(System.Array, int)`；输入表达式：`Parts[i].CopyTo(bytes, i * 24000)`；返回值紧邻使用处：`ExpressionStatementSyntax: Parts[i].CopyTo(bytes, i * 24000);`
- `System.IO.Compression.BrotliStream.BrotliStream(System.IO.Stream, System.IO.Compression.CompressionMode)`；输入表达式：`new BrotliStream(new MemoryStream(bytes), CompressionMode.Decompress)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new BrotliStream(new MemoryStream(bytes), CompressionMode.Decompress)`
- `System.IO.Compression.BrotliStream.Read(System.Span<byte>)`；输入表达式：`zip.Read(buffer)`；返回值紧邻使用处：`AssignmentExpressionSyntax: read = zip.Read(buffer)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("同步数据解压超限。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("同步数据解压超限。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("同步校验失败。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("同步校验失败。");`
- `System.IO.MemoryStream.MemoryStream()`；输入表达式：`new MemoryStream()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MemoryStream()`
- `System.IO.MemoryStream.MemoryStream(byte[])`；输入表达式：`new MemoryStream(bytes)`；返回值紧邻使用处：`ArgumentSyntax: new MemoryStream(bytes)`
- `System.IO.MemoryStream.ToArray()`；输入表达式：`result.ToArray()`；返回值紧邻使用处：`ReturnStatementSyntax: return result.ToArray();`
- `System.IO.MemoryStream.Write(byte[], int, int)`；输入表达式：`result.Write(buffer, 0, read)`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Write(buffer, 0, read);`

**赋值（含属性/字段和局部值）：**

- `read` = `zip.Read(buffer)`

<a id="symbol-b544da8202a5"></a>

## `NationalSpire.Coop.CoopAssembler.Add(NationalSpire.Coop.CoopPart) — public byte[]? Add(CoopPart p)`

来源：源码第 103 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopAssembler.Add(NationalSpire.Coop.CoopPart, System.DateTime)`](CoopWire.cs.md#symbol-e6ffa10e5388)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopAssembler.Add(NationalSpire.Coop.CoopPart, System.DateTime)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopAssembler.Add(NationalSpire.Coop.CoopPart, System.DateTime)`；输入表达式：`Add(p, DateTime.UtcNow)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Add(p, DateTime.UtcNow)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e6ffa10e5388"></a>

## `NationalSpire.Coop.CoopAssembler.Add(NationalSpire.Coop.CoopPart, System.DateTime) — internal byte[]? Add(CoopPart p, DateTime received)`

来源：源码第 104 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopAssembler.Add(NationalSpire.Coop.CoopPart)`](CoopWire.cs.md#symbol-b544da8202a5)；[`NationalSpire.Coop.CoopCoordinator.ReceiveNow(ulong, NationalSpire.Coop.CoopWire, System.DateTime)`](CoopCoordinator.cs.md#symbol-796041df5e9f)；[`NationalSpire.Coop.CoopCoordinator.ReceivePrivate(NationalSpire.Coop.CoopWire, System.DateTime)`](CoopPrivateMessages.cs.md#symbol-eca8b0236539)

**调用：** [`NationalSpire.Coop.CoopAssembler.Collect(NationalSpire.Coop.CoopPart, System.DateTime)`](CoopWire.cs.md#symbol-35fc52cbee4a)；[`NationalSpire.Coop.CoopAssembler.Complete.Decode(bool)`](CoopWire.cs.md#symbol-8c8a54666033)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopAssembler.Collect(NationalSpire.Coop.CoopPart, System.DateTime)`；`NationalSpire.Coop.CoopAssembler.Complete.Decode(bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopAssembler.Collect(NationalSpire.Coop.CoopPart, System.DateTime)`；输入表达式：`Collect(p, received)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Collect(p, received)?.Decode(diagnostic)`
- `NationalSpire.Coop.CoopAssembler.Complete.Decode(bool)`；输入表达式：`.Decode(diagnostic)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Collect(p, received)?.Decode(diagnostic)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-dcb9a42ff122"></a>

## `NationalSpire.Coop.CoopAssembler.Missing() — internal int[]? Missing()`

来源：源码第 105 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.CollectDiagnosticReports(System.TimeSpan?)`](CoopDiagnostics.cs.md#symbol-44ff9d375651)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Linq.Enumerable.Range(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopAssembler._header`；`NationalSpire.Coop.CoopAssembler._parts`；`NationalSpire.Coop.CoopPart.Count`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`_parts.ContainsKey(i)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_parts.ContainsKey(i)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Enumerable.Range(0, _header.Count).Where(i => !_parts.ContainsKey(i)).ToArray()`；返回值紧邻使用处：`ConditionalExpressionSyntax: _header == null ? null : Enumerable.Range(0, _header.Count).Where(i => !_parts.ContainsKey(i)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Enumerable.Range(0, _header.Count).Where(i => !_parts.ContainsKey(i))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0, _header.Count).Where(i => !_parts.ContainsKey(i)).ToArray`
- `System.Linq.Enumerable.Range(int, int)`；输入表达式：`Enumerable.Range(0, _header.Count)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0, _header.Count).Where`

**赋值（含属性/字段和局部值）：**


<a id="symbol-35fc52cbee4a"></a>

## `NationalSpire.Coop.CoopAssembler.Collect(NationalSpire.Coop.CoopPart, System.DateTime) — internal Complete? Collect(CoopPart p, DateTime received)`

来源：源码第 106 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopAssembler.Add(NationalSpire.Coop.CoopPart, System.DateTime)`](CoopWire.cs.md#symbol-e6ffa10e5388)；[`NationalSpire.Coop.CoopCoordinator.Receive(ulong, NationalSpire.Coop.CoopWire)`](CoopCoordinator.cs.md#symbol-892f19740afa)；[`NationalSpire.Coop.CoopCoordinator.ReceiveDiagnostic(ulong, NationalSpire.Coop.CoopWire)`](CoopDiagnostics.cs.md#symbol-fefabf8d6a26)

**调用：** `NationalSpire.Coop.CoopAssembler.Complete.Complete(NationalSpire.Coop.CoopPart, byte[][])`；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Linq.Enumerable.Range(int, int)`；`System.Math.Min(int, int)`；`System.Span<T>.SequenceEqual<T>(System.ReadOnlySpan<T>)`；`System.TimeSpan.FromSeconds(long)`；`T[]?.AsSpan<T>()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopAssembler._header`；`NationalSpire.Coop.CoopAssembler._parts`；`NationalSpire.Coop.CoopAssembler._started`；`NationalSpire.Coop.CoopPart.Bytes`；`NationalSpire.Coop.CoopPart.Count`；`NationalSpire.Coop.CoopPart.Hash`；`NationalSpire.Coop.CoopPart.Id`；`NationalSpire.Coop.CoopPart.Index`；`NationalSpire.Coop.CoopPart.Total`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopAssembler.Complete.Complete(NationalSpire.Coop.CoopPart, byte[][])`；输入表达式：`new Complete(_header, Enumerable.Range(0, p.Count).Select(i => _parts[i]).ToArray())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Complete(_header, Enumerable.Range(0, p.Count).Select(i => _parts[i]).ToArray())`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`_parts.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _parts.Clear();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_parts.TryGetValue(p.Index, out var old)`；返回值紧邻使用处：`BinaryExpressionSyntax: _parts.TryGetValue(p.Index, out var old) && !old.AsSpan().SequenceEqual(p.Bytes)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Enumerable.Range(0, p.Count).Select(i => _parts[i])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0, p.Count).Select(i => _parts[i]).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`Enumerable.Range(0, p.Count).Select(i => _parts[i]).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: Enumerable.Range(0, p.Count).Select(i => _parts[i]).ToArray()`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("同步分片无效。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("同步分片无效。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("同步分片元数据不一致。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("同步分片元数据不一致。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("重复分片冲突。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("重复分片冲突。");`
- `System.Linq.Enumerable.Range(int, int)`；输入表达式：`Enumerable.Range(0, p.Count)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0, p.Count).Select`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(24000, p.Total - p.Index * 24000)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Bytes.Length != Math.Min(24000, p.Total - p.Index * 24000)`
- `System.Span<T>.SequenceEqual<T>(System.ReadOnlySpan<T>)`；输入表达式：`old.AsSpan().SequenceEqual(p.Bytes)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !old.AsSpan().SequenceEqual(p.Bytes)`
- `System.TimeSpan.FromSeconds(long)`；输入表达式：`TimeSpan.FromSeconds(60)`；返回值紧邻使用处：`BinaryExpressionSyntax: received - _started > TimeSpan.FromSeconds(60)`
- `T[]?.AsSpan<T>()`；输入表达式：`old.AsSpan()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: old.AsSpan().SequenceEqual`

**赋值（含属性/字段和局部值）：**

- `_header` = `null`
- `_header` = `p`
- `_parts[p.Index]` = `p.Bytes`
- `_started` = `received`
