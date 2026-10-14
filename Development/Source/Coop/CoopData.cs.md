# Coop/CoopData.cs

[返回文件依赖索引](../../SOURCE_MAP.md)

源码 SHA-256：`3E9CFE26824ADF472EB9B81D81187831CA705DAFC4E94F626CDA405A1ECA34A0`。来源：[源码](../../../Coop/CoopData.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Coop.CoopJson`、`NationalSpire.Coop.CoopWorld`、`NationalSpire.Coop.CoopMember`、`NationalSpire.Coop.CoopProposal`、`NationalSpire.Coop.CoopRun`、`NationalSpire.Coop.CoopTerminalResult`、`NationalSpire.Coop.CoopSpeech`、`NationalSpire.Coop.CoopLivePlayer`、`NationalSpire.Coop.CoopSettlement`、`NationalSpire.Coop.CoopReceipt`、`NationalSpire.Coop.CoopCommand`、`NationalSpire.Coop.CoopOutcome`、`NationalSpire.Coop.CoopReading`。

字段、事件及初始值（源码原样）：

```csharp
public static readonly JsonSerializerOptions Options = new() { Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
private static readonly JsonSerializerOptions PublicOptions = PublicSettings();
public const int Protocol = 1;
```

<a id="symbol-2877259dff91"></a>

## `NationalSpire.Coop.CoopJson.PublicSettings() — private static JsonSerializerOptions PublicSettings()`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `NationalSpire.AiOptions.AiOptions()`；`System.Collections.Generic.ICollection<T>.Add(T)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Text.Json.JsonSerializerOptions.JsonSerializerOptions(System.Text.Json.JsonSerializerOptions)`；`System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.DefaultJsonTypeInfoResolver()`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.Enabled`；`NationalSpire.CareerData.Ai`；`NationalSpire.Coop.CoopJson.Options`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiOptions.AiOptions()`；输入表达式：`new AiOptions { Enabled = ((CareerData)value).Ai.Enabled }`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: value => new AiOptions { Enabled = ((CareerData)value).Ai.Enabled }`
- `System.Collections.Generic.ICollection<T>.Add(T)`；输入表达式：`resolver.Modifiers.Add(info =>          {              if (info.Type == typeof(CareerData))                  info.Properties.Single(p => p.Name == nameof(CareerData.Ai)).Get = value => new AiOptions { Enabled = ((CareerData)value).Ai.Enabled };          })`；返回值紧邻使用处：`ExpressionStatementSyntax: resolver.Modifiers.Add(info =>          {              if (info.Type == typeof(CareerData))                  info.Properties.Single(p => p.Name == nameof(CareerData.Ai)).Get = value => new AiOptions { Enabled = ((CareerData)value).Ai.Enabled };          });`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`info.Properties.Single(p => p.Name == nameof(CareerData.Ai))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: info.Properties.Single(p => p.Name == nameof(CareerData.Ai)).Get`
- `System.Text.Json.JsonSerializerOptions.JsonSerializerOptions(System.Text.Json.JsonSerializerOptions)`；输入表达式：`new(Options) { TypeInfoResolver = resolver }`；返回值紧邻使用处：`ReturnStatementSyntax: return new(Options) { TypeInfoResolver = resolver };`
- `System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.DefaultJsonTypeInfoResolver()`；输入表达式：`new System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver()`

**赋值（含属性/字段和局部值）：**

- `Enabled` = `((CareerData)value).Ai.Enabled`
- `info.Properties.Single(p => p.Name == nameof(CareerData.Ai)).Get` = `value => new AiOptions { Enabled = ((CareerData)value).Ai.Enabled }`
- `TypeInfoResolver` = `resolver`

<a id="symbol-3f5e7638f9e9"></a>

## `NationalSpire.Coop.CoopJson.PublicBytes<T>(T) — public static byte[] PublicBytes<T>(T value)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLibrary.Create(string, NationalSpire.CareerData)`](../CareerLibrary.cs.md#symbol-bb2b0ce2be9d)；[`NationalSpire.CareerLibrary.Export(NationalSpire.CareerData, byte[]?, byte[]?)`](../CareerLibrary.cs.md#symbol-6f1ccfef974f)；[`NationalSpire.Coop.CoopCoordinator.Broadcast()`](CoopCoordinator.cs.md#symbol-8a047804722d)；[`NationalSpire.Coop.CoopStorage.BackupBeforeDevelopment(NationalSpire.Coop.CoopWorld, byte[]?)`](CoopStorage.cs.md#symbol-955953e36f17)；[`NationalSpire.Coop.CoopStorage.ExportArchive(string)`](CoopStorage.cs.md#symbol-2c9c2a0b54fe)；[`NationalSpire.Coop.CoopStorage.PublicCopy(NationalSpire.Coop.CoopWorld)`](CoopStorage.cs.md#symbol-9dfe7ef480f7)；[`NationalSpire.Coop.CoopStorage.Save(NationalSpire.Coop.CoopWorld, byte[]?)`](CoopStorage.cs.md#symbol-a4c240447248)

**调用：** `System.Text.Json.JsonSerializer.SerializeToUtf8Bytes<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopJson.PublicOptions`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Text.Json.JsonSerializer.SerializeToUtf8Bytes<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.SerializeToUtf8Bytes(value, PublicOptions)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => JsonSerializer.SerializeToUtf8Bytes(value, PublicOptions)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-faeb54cab7ee"></a>

## `NationalSpire.Coop.CoopJson.Bytes<T>(T) — public static byte[] Bytes<T>(T value)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopAi.ProcessDiscussion(NationalSpire.Coop.CoopWorld, (string Generation, string World, string Epoch, string Message))`](CoopAi.cs.md#symbol-b31e3ccef31a)；[`NationalSpire.Coop.CoopAi.ProcessPublications(bool)`](CoopAi.cs.md#symbol-b4b98ce85f62)；[`NationalSpire.Coop.CoopCoordinator.PublishLive()`](CoopCoordinator.cs.md#symbol-1e3cadd9f597)；[`NationalSpire.Coop.CoopCoordinator.ReceiveDiagnostic(ulong, NationalSpire.Coop.CoopWire)`](CoopDiagnostics.cs.md#symbol-fefabf8d6a26)；[`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Encode(ulong, System.Collections.Generic.Dictionary<string, string>)`](CoopPrivateMessages.cs.md#symbol-f433d36af14b)；[`NationalSpire.Coop.CoopCoordinator.StartGroup(ulong, NationalSpire.Coop.CoopCommand)`](CoopGroupChats.cs.md#symbol-83d332761336)；[`NationalSpire.Coop.CoopCoordinator.StartPrivate(ulong, NationalSpire.Coop.CoopCommand)`](CoopPrivateMessages.cs.md#symbol-ebc3f29b5eb6)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.Coop.CoopPacketAssembly.Pack(NationalSpire.Coop.CoopWire)`](CoopWire.cs.md#symbol-1ffd868804d7)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](CoopRules.cs.md#symbol-71eae0adc0d0)；[`NationalSpire.Coop.CoopSettings.SaveLayout(NationalSpire.BroadcastUiState)`](CoopRuntime.cs.md#symbol-3613d13461fc)；[`NationalSpire.Coop.CoopStorage.Save(NationalSpire.Coop.CoopWorld, byte[]?)`](CoopStorage.cs.md#symbol-a4c240447248)

**调用：** `System.Text.Json.JsonSerializer.SerializeToUtf8Bytes<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopJson.Options`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Text.Json.JsonSerializer.SerializeToUtf8Bytes<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.SerializeToUtf8Bytes(value, Options)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => JsonSerializer.SerializeToUtf8Bytes(value, Options)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1f7bf7625062"></a>

## `NationalSpire.Coop.CoopJson.Read<T>(byte[]) — public static T Read<T>(byte[] bytes)`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLibrary.List(string)`](../CareerLibrary.cs.md#symbol-49ca8927a7b3)；[`NationalSpire.CareerScreen.OpenCareerLibrary()`](../CareerLibraryScreen.cs.md#symbol-57e1d5f83960)；[`NationalSpire.Coop.CoopCoordinator.ReceiveDiagnostic(ulong, NationalSpire.Coop.CoopWire)`](CoopDiagnostics.cs.md#symbol-fefabf8d6a26)；[`NationalSpire.Coop.CoopCoordinator.ReceiveNow(ulong, NationalSpire.Coop.CoopWire, System.DateTime)`](CoopCoordinator.cs.md#symbol-796041df5e9f)；[`NationalSpire.Coop.CoopCoordinator.ReceivePrivate(NationalSpire.Coop.CoopWire, System.DateTime)`](CoopPrivateMessages.cs.md#symbol-eca8b0236539)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.Coop.CoopPacketAssembly.Read(ulong, byte[])`](CoopWire.cs.md#symbol-4b11b493c720)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](CoopRules.cs.md#symbol-71eae0adc0d0)；[`NationalSpire.Coop.CoopSettings.ReadLayout()`](CoopRuntime.cs.md#symbol-7bdef2452208)；[`NationalSpire.Coop.CoopStorage.ImportArchive(byte[])`](CoopStorage.cs.md#symbol-73147f08e733)；[`NationalSpire.Coop.CoopStorage.Load(string)`](CoopStorage.cs.md#symbol-efe4d419a020)；[`NationalSpire.Coop.CoopStorage.PublicCopy(NationalSpire.Coop.CoopWorld)`](CoopStorage.cs.md#symbol-9dfe7ef480f7)；[`NationalSpire.Coop.CoopStorage.Save(NationalSpire.Coop.CoopWorld, byte[]?)`](CoopStorage.cs.md#symbol-a4c240447248)；[`Step()`](CoopReception.cs.md#symbol-41b14a0db411)

**调用：** `System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(System.ReadOnlySpan<byte>, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopJson.Options`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("数据为空")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidDataException("数据为空")`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(System.ReadOnlySpan<byte>, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<T>(bytes, Options)`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<T>(bytes, Options) ?? throw new InvalidDataException("数据为空")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-38a51b2b1811"></a>

## `NationalSpire.Coop.CoopJson.Copy<T>(T) — public static T Copy<T>(T value)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Current()`](CoopGroupChats.cs.md#symbol-2c4dd6def46d)；[`NationalSpire.CharacterCards.Apply(NationalSpire.CareerData, NationalSpire.CharacterCardEdit, NationalSpire.CareerLifeState?, string?)`](../CharacterCards.cs.md#symbol-a50771d297a5)；[`NationalSpire.CharacterCards.Read(NationalSpire.CareerData, string)`](../CharacterCards.cs.md#symbol-3c3ff9c389dd)；[`NationalSpire.CharacterCards.Save(NationalSpire.CareerData, NationalSpire.CharacterCardEdit)`](../CharacterCards.cs.md#symbol-4bce7f6af16c)；[`NationalSpire.Coop.CoopAi.ProcessDiscussion(NationalSpire.Coop.CoopWorld, (string Generation, string World, string Epoch, string Message))`](CoopAi.cs.md#symbol-b31e3ccef31a)；[`NationalSpire.Coop.CoopAi.ProcessPublications(bool)`](CoopAi.cs.md#symbol-b4b98ce85f62)；[`NationalSpire.Coop.CoopCareerSession.SaveAi(NationalSpire.CareerData)`](CoopCareerSession.cs.md#symbol-6fb4f052a4e3)；[`NationalSpire.Coop.CoopCoordinator.PrivateSnapshot(NationalSpire.Coop.CoopWorld, ulong)`](CoopPrivateMessages.cs.md#symbol-cdaa536242f4)；[`NationalSpire.Coop.CoopCoordinator.ReceiveNow(ulong, NationalSpire.Coop.CoopWire, System.DateTime)`](CoopCoordinator.cs.md#symbol-796041df5e9f)；[`NationalSpire.Coop.CoopCoordinator.Tick()`](CoopCoordinator.cs.md#symbol-4253349561bc)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](CoopRules.cs.md#symbol-71eae0adc0d0)；[`NationalSpire.Coop.CoopRules.GroupCommand(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.Coop.CoopCommand)`](CoopGroupChats.cs.md#symbol-65a87ad49e08)；[`NationalSpire.Coop.CoopRules.InterfaceView(NationalSpire.Coop.CoopWorld, ulong)`](CoopRules.cs.md#symbol-c23013f591a9)；[`NationalSpire.Coop.CoopRules.RefreshPeople(NationalSpire.Coop.CoopWorld)`](CoopRules.cs.md#symbol-8025e01818d7)；[`NationalSpire.Coop.CoopRules.SavePrivateFailure(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, string)`](CoopPrivateMessages.cs.md#symbol-3dd770b5bab3)；[`NationalSpire.Coop.CoopRules.Settle(NationalSpire.Coop.CoopWorld, string, bool, bool, int, double, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer>, System.Collections.Generic.Dictionary<ulong, NationalSpire.CareerResult>?, bool, bool, bool)`](CoopRules.cs.md#symbol-926ebe8770ca)；[`NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`](CoopRules.cs.md#symbol-d8e501560a84)；[`NationalSpire.Coop.CoopRuntime.Complete(MegaCrit.Sts2.Core.Runs.RunHistory)`](CoopRuntime.cs.md#symbol-732476d12d29)；[`NationalSpire.Coop.CoopRuntime.PauseCore(string)`](CoopRuntime.cs.md#symbol-60fe2cb26a8e)；[`NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>)`](../EconomicActions.cs.md#symbol-6ec38e492fe6)；[`NationalSpire.EconomicActions.Trade(NationalSpire.CareerData, NationalSpire.MarketOrder)`](../EconomicActions.cs.md#symbol-f0516c3ecf95)；[`Save(NationalSpire.CareerData)`](CoopGroupChats.cs.md#symbol-500092220c28)；[`Save(NationalSpire.CareerData)`](CoopPrivateMessages.cs.md#symbol-b25b18b4284d)

**调用：** [`NationalSpire.Coop.CoopJson.Bytes<T>(T)`](CoopData.cs.md#symbol-faeb54cab7ee)；[`NationalSpire.Coop.CoopJson.Read<T>(byte[])`](CoopData.cs.md#symbol-1f7bf7625062)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](../UiPerformance.cs.md#symbol-fb8ca8555fbe)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopJson.Bytes<T>(T)`；`NationalSpire.Coop.CoopJson.Read<T>(byte[])`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.CoopCopy`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopJson.Bytes<T>(T)`；输入表达式：`Bytes(value)`；返回值紧邻使用处：`ArgumentSyntax: Bytes(value)`
- `NationalSpire.Coop.CoopJson.Read<T>(byte[])`；输入表达式：`Read<T>(Bytes(value))`；返回值紧邻使用处：`ReturnStatementSyntax: return Read<T>(Bytes(value));`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.CoopCopy)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.CoopCopy)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ca6c9ee59a2a"></a>

## `NationalSpire.Coop.CoopJson.Hash(byte[]) — public static string Hash(byte[] bytes)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopAi.ProcessDiscussion(NationalSpire.Coop.CoopWorld, (string Generation, string World, string Epoch, string Message))`](CoopAi.cs.md#symbol-b31e3ccef31a)；[`NationalSpire.Coop.CoopAi.ProcessPublications(bool)`](CoopAi.cs.md#symbol-b4b98ce85f62)；[`NationalSpire.Coop.CoopAssembler.Complete.Decode()`](CoopWire.cs.md#symbol-3bc9f4a00527)；[`NationalSpire.Coop.CoopAssembler.Split(byte[])`](CoopWire.cs.md#symbol-67ad26af4646)；[`NationalSpire.Coop.CoopPacketAssembly.Pack(NationalSpire.Coop.CoopWire)`](CoopWire.cs.md#symbol-1ffd868804d7)；[`NationalSpire.Coop.CoopPacketAssembly.Read(ulong, byte[])`](CoopWire.cs.md#symbol-4b11b493c720)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](CoopRules.cs.md#symbol-71eae0adc0d0)；[`NationalSpire.Coop.CoopStorage.Load(string)`](CoopStorage.cs.md#symbol-efe4d419a020)；[`NationalSpire.Coop.CoopStorage.Save(NationalSpire.Coop.CoopWorld, byte[]?)`](CoopStorage.cs.md#symbol-a4c240447248)

**调用：** `System.Convert.ToHexString(byte[])`；`System.Security.Cryptography.SHA256.HashData(byte[])`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Convert.ToHexString(byte[])`；输入表达式：`Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(bytes))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(bytes))`
- `System.Security.Cryptography.SHA256.HashData(byte[])`；输入表达式：`System.Security.Cryptography.SHA256.HashData(bytes)`；返回值紧邻使用处：`ArgumentSyntax: System.Security.Cryptography.SHA256.HashData(bytes)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-85d2410ea3ba"></a>

## `NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData) — public static void Detached(CareerData d)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopAi.ProcessDiscussion(NationalSpire.Coop.CoopWorld, (string Generation, string World, string Epoch, string Message))`](CoopAi.cs.md#symbol-b31e3ccef31a)；[`NationalSpire.Coop.CoopAi.ProcessPublications(bool)`](CoopAi.cs.md#symbol-b4b98ce85f62)；[`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`](CoopCoordinator.cs.md#symbol-e1dfe22e8221)；[`NationalSpire.Coop.CoopCoordinator.PrivateSnapshot(NationalSpire.Coop.CoopWorld, ulong)`](CoopPrivateMessages.cs.md#symbol-cdaa536242f4)；[`NationalSpire.Coop.CoopCoordinator.ReceiveNow(ulong, NationalSpire.Coop.CoopWire, System.DateTime)`](CoopCoordinator.cs.md#symbol-796041df5e9f)；[`NationalSpire.Coop.CoopCoordinator.Tick()`](CoopCoordinator.cs.md#symbol-4253349561bc)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](CoopRules.cs.md#symbol-71eae0adc0d0)；[`NationalSpire.Coop.CoopRules.Create(ulong, string, string, int, string)`](CoopRules.cs.md#symbol-768ae6d9f0c2)；[`NationalSpire.Coop.CoopRules.SavePrivateFailure(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, string)`](CoopPrivateMessages.cs.md#symbol-3dd770b5bab3)；[`NationalSpire.Coop.CoopRules.Settle(NationalSpire.Coop.CoopWorld, string, bool, bool, int, double, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer>, System.Collections.Generic.Dictionary<ulong, NationalSpire.CareerResult>?, bool, bool, bool)`](CoopRules.cs.md#symbol-926ebe8770ca)；[`NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`](CoopRules.cs.md#symbol-d8e501560a84)；[`NationalSpire.Coop.CoopStorage.Load(string)`](CoopStorage.cs.md#symbol-efe4d419a020)；[`NationalSpire.EconomicActions.Save(NationalSpire.CareerData, System.Func<NationalSpire.CareerData, string?>)`](../EconomicActions.cs.md#symbol-6ec38e492fe6)；[`Save(NationalSpire.CareerData)`](CoopGroupChats.cs.md#symbol-500092220c28)；[`Save(NationalSpire.CareerData)`](CoopPrivateMessages.cs.md#symbol-b25b18b4284d)；[`Step()`](CoopReception.cs.md#symbol-41b14a0db411)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.ExternalCurrent`；`NationalSpire.CareerData.ExternalSave`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `d.ExternalCurrent` = `() => false`
- `d.ExternalSave` = `_ => { }`

<a id="symbol-53f45385e616"></a>

## `NationalSpire.Coop.CoopWorld.Schema — public int Schema`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-619977f5944a"></a>

## `NationalSpire.Coop.CoopWorld.Id — public string Id`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Guid.NewGuid()`；`System.Guid.ToString(string?)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Guid.NewGuid().ToString("N")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-562571136db6"></a>

## `NationalSpire.Coop.CoopWorld.Name — public string Name`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b3270d560b8c"></a>

## `NationalSpire.Coop.CoopWorld.Owner — public ulong Owner`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ae516246a634"></a>

## `NationalSpire.Coop.CoopWorld.Capacity — public int Capacity`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3ad6b3bd2eb6"></a>

## `NationalSpire.Coop.CoopWorld.Epoch — public string Epoch`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Guid.NewGuid()`；`System.Guid.ToString(string?)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Guid.NewGuid().ToString("N")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-903f93248ed5"></a>

## `NationalSpire.Coop.CoopWorld.Revision — public long Revision`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-583ce2e4848f"></a>

## `NationalSpire.Coop.CoopWorld.World — public CareerData World`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `NationalSpire.CareerData.CareerData()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerData.CareerData()`；输入表达式：`new()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-04e71d7d4d4c"></a>

## `NationalSpire.Coop.CoopWorld.Members — public List<CoopMember> Members`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-55398c3f10fb"></a>

## `NationalSpire.Coop.CoopWorld.RosterLocked — public bool RosterLocked`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-614e8e4ffb08"></a>

## `NationalSpire.Coop.CoopWorld.CareerStarted — public bool CareerStarted`

来源：源码第 42 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-95511751dee2"></a>

## `NationalSpire.Coop.CoopWorld.EntrySequence — public int EntrySequence`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9ce216a67bf2"></a>

## `NationalSpire.Coop.CoopWorld.Proposal — public CoopProposal? Proposal`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-648dec7a8f87"></a>

## `NationalSpire.Coop.CoopWorld.Run — public CoopRun? Run`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-61dd7eadc0ca"></a>

## `NationalSpire.Coop.CoopWorld.Settlements — public List<CoopSettlement> Settlements`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-99b0026eb6bf"></a>

## `NationalSpire.Coop.CoopWorld.NativeHistoryReceipts — public HashSet<string> NativeHistoryReceipts`

来源：源码第 47 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e788e52dad63"></a>

## `NationalSpire.Coop.CoopWorld.Receipts — public Dictionary<string, CoopReceipt> Receipts`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-594fcdbe70f6"></a>

## `NationalSpire.Coop.CoopWorld.LatestCheckpoint — public string LatestCheckpoint`

来源：源码第 49 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c00698332c46"></a>

## `NationalSpire.Coop.CoopWorld.CheckpointHeader(string) — public CoopWorld CheckpointHeader(string id)`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopStorage.Save(NationalSpire.Coop.CoopWorld, byte[]?)`](CoopStorage.cs.md#symbol-a4c240447248)

**调用：** `object.MemberwiseClone()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopWorld.LatestCheckpoint`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `object.MemberwiseClone()`；输入表达式：`MemberwiseClone()`；返回值紧邻使用处：`CastExpressionSyntax: (CoopWorld)MemberwiseClone()`

**赋值（含属性/字段和局部值）：**

- `copy.LatestCheckpoint` = `id`

<a id="symbol-37c5b2e81f81"></a>

## `NationalSpire.Coop.CoopWorld.RunCheckpoint() — public CoopWorld RunCheckpoint()`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopNativeRun.Save(MegaCrit.Sts2.Core.Saves.SerializableRun)`](CoopNativeRun.cs.md#symbol-5825a51bfef3)

**调用：** [`NationalSpire.Coop.CoopRun.CheckpointCopy()`](CoopData.cs.md#symbol-c743009879ac)；`object.MemberwiseClone()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopRun.CheckpointCopy()`；`NationalSpire.Coop.CoopWorld.Revision`；`NationalSpire.Coop.CoopWorld.Run`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopRun.CheckpointCopy()`；输入表达式：`.CheckpointCopy()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Run?.CheckpointCopy()`
- `object.MemberwiseClone()`；输入表达式：`MemberwiseClone()`；返回值紧邻使用处：`CastExpressionSyntax: (CoopWorld)MemberwiseClone()`

**赋值（含属性/字段和局部值）：**

- `copy.Run` = `Run?.CheckpointCopy()`

<a id="symbol-f18b97f574e6"></a>

## `NationalSpire.Coop.CoopMember.Card — public CareerPerson? Card`

来源：源码第 61 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-55c1b6719134"></a>

## `NationalSpire.Coop.CoopMember.SeenCeremonySeason — public int SeenCeremonySeason`

来源：源码第 62 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-31d7b89e5087"></a>

## `NationalSpire.Coop.CoopMember.CeremonyReceipts — public HashSet<string> CeremonyReceipts`

来源：源码第 63 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a1eeaade10ed"></a>

## `NationalSpire.Coop.CoopMember.CeremonyHonors — public List<CareerHonor> CeremonyHonors`

来源：源码第 64 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-15371633ada4"></a>

## `NationalSpire.Coop.CoopMember.SteamId — public ulong SteamId`

来源：源码第 65 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1275f4732f64"></a>

## `NationalSpire.Coop.CoopMember.PersonId — public string PersonId`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopMember.SteamId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-baff6e78002b"></a>

## `NationalSpire.Coop.CoopMember.Name — public string Name`

来源：源码第 67 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d9b43ad46bbb"></a>

## `NationalSpire.Coop.CoopMember.Gender — public string Gender`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.IdentityGender.Unset`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2484e9949917"></a>

## `NationalSpire.Coop.CoopMember.Character — public string Character`

来源：源码第 69 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b146aa7a2d3c"></a>

## `NationalSpire.Coop.CoopMember.RandomCharacter — public bool RandomCharacter`

来源：源码第 70 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7c3867337d4d"></a>

## `NationalSpire.Coop.CoopMember.Credits — public int Credits`

来源：源码第 71 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2dd28c445586"></a>

## `NationalSpire.Coop.CoopMember.Fans — public int Fans`

来源：源码第 72 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2362a26f4a3b"></a>

## `NationalSpire.Coop.CoopMember.Rating — public int Rating`

来源：源码第 73 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6d6f1bd4732d"></a>

## `NationalSpire.Coop.CoopMember.Wins — public int Wins`

来源：源码第 74 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a2407840b929"></a>

## `NationalSpire.Coop.CoopMember.Losses — public int Losses`

来源：源码第 75 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-239f6d609e08"></a>

## `NationalSpire.Coop.CoopMember.Draws — public int Draws`

来源：源码第 76 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0fbc74ab0f7e"></a>

## `NationalSpire.Coop.CoopMember.HighestClear — public int HighestClear`

来源：源码第 77 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-fd565a1d4c80"></a>

## `NationalSpire.Coop.CoopMember.AvatarFrame — public string AvatarFrame`

来源：源码第 78 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9da77b8550a5"></a>

## `NationalSpire.Coop.CoopMember.Avatar — public PlayerAvatar Avatar`

来源：源码第 79 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `NationalSpire.PlayerAvatar.PlayerAvatar()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PlayerAvatar.PlayerAvatar()`；输入表达式：`new()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7b664ab5e9b4"></a>

## `NationalSpire.Coop.CoopMember.PaidSeason — public int PaidSeason`

来源：源码第 80 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-18c7039bc8ed"></a>

## `NationalSpire.Coop.CoopMember.Life — public CareerLifeState Life`

来源：源码第 81 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `NationalSpire.CareerLifeState.CareerLifeState()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerLifeState.CareerLifeState()`；输入表达式：`new()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-759ba1c147e2"></a>

## `NationalSpire.Coop.CoopMember.Sponsors — public List<SponsorContract> Sponsors`

来源：源码第 82 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-bbe2b4bc53d0"></a>

## `NationalSpire.Coop.CoopMember.SponsorOffers — public List<SponsorContract> SponsorOffers`

来源：源码第 83 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-08396d7c7fb8"></a>

## `NationalSpire.Coop.CoopMember.Results — public List<CareerResult> Results`

来源：源码第 84 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ef0bcc73d8c1"></a>

## `NationalSpire.Coop.CoopMember.Aliases — public List<string> Aliases`

来源：源码第 85 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-65346cada00a"></a>

## `NationalSpire.Coop.CoopMember.ReadPosts — public Dictionary<string, long> ReadPosts`

来源：源码第 86 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8ba539afcdb9"></a>

## `NationalSpire.Coop.CoopMember.ReadWeeks — public Dictionary<int, long> ReadWeeks`

来源：源码第 87 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6e37398e6cdb"></a>

## `NationalSpire.Coop.CoopMember.SeenSettlement — public string SeenSettlement`

来源：源码第 88 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d2cbafad256b"></a>

## `NationalSpire.Coop.CoopProposal.Id — public string Id`

来源：源码第 92 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Guid.NewGuid()`；`System.Guid.ToString(string?)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Guid.NewGuid().ToString("N")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1fe18db869fc"></a>

## `NationalSpire.Coop.CoopProposal.Kind — public string Kind`

来源：源码第 93 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6c4dad85b9cb"></a>

## `NationalSpire.Coop.CoopProposal.Target — public string Target`

来源：源码第 94 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-554542c2fa0b"></a>

## `NationalSpire.Coop.CoopProposal.Number — public int Number`

来源：源码第 95 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3e974cfed905"></a>

## `NationalSpire.Coop.CoopProposal.Label — public string Label`

来源：源码第 96 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ff675ca4241e"></a>

## `NationalSpire.Coop.CoopProposal.Votes — public HashSet<ulong> Votes`

来源：源码第 97 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b7498acb989e"></a>

## `NationalSpire.Coop.CoopProposal.Participants — public HashSet<ulong> Participants`

来源：源码第 98 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7d0a9cf649b6"></a>

## `NationalSpire.Coop.CoopRun.Attempt — public string Attempt`

来源：源码第 102 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Guid.NewGuid()`；`System.Guid.ToString(string?)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Guid.NewGuid().ToString("N")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4044dbf59f17"></a>

## `NationalSpire.Coop.CoopRun.MatchId — public string MatchId`

来源：源码第 103 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-dc2762d343af"></a>

## `NationalSpire.Coop.CoopRun.Phase — public string Phase`

来源：源码第 104 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-da937f8da2dd"></a>

## `NationalSpire.Coop.CoopRun.ResumeCount — public int ResumeCount`

来源：源码第 105 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-77ad9ab36977"></a>

## `NationalSpire.Coop.CoopRun.FailureReason — public string FailureReason`

来源：源码第 106 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-026c30a05390"></a>

## `NationalSpire.Coop.CoopRun.Ascension — public int Ascension`

来源：源码第 107 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-30a77a23a101"></a>

## `NationalSpire.Coop.CoopRun.Seed — public string Seed`

来源：源码第 108 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-553c08791840"></a>

## `NationalSpire.Coop.CoopRun.Characters — public Dictionary<ulong, string> Characters`

来源：源码第 109 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4eabbd8ceefc"></a>

## `NationalSpire.Coop.CoopRun.Opponents — public List<string> Opponents`

来源：源码第 110 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-215e209de9c5"></a>

## `NationalSpire.Coop.CoopRun.Rival — public LiveMatchState? Rival`

来源：源码第 111 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-fd9b464cc209"></a>

## `NationalSpire.Coop.CoopRun.RivalMembers — public Dictionary<string, LiveMatchState> RivalMembers`

来源：源码第 112 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-236a9d4c9593"></a>

## `NationalSpire.Coop.CoopRun.Clock — public double Clock`

来源：源码第 113 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c18cd3e54f8f"></a>

## `NationalSpire.Coop.CoopRun.Floor — public int Floor`

来源：源码第 114 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e7999e27e975"></a>

## `NationalSpire.Coop.CoopRun.Act — public int Act`

来源：源码第 115 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2d8b3ec8f9e0"></a>

## `NationalSpire.Coop.CoopRun.Players — public List<CoopLivePlayer> Players`

来源：源码第 116 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-cb1bc0718fe4"></a>

## `NationalSpire.Coop.CoopRun.Commentary — public List<string> Commentary`

来源：源码第 117 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5b46dac3fd6c"></a>

## `NationalSpire.Coop.CoopRun.Broadcasts — public Dictionary<ulong, BroadcastMemory> Broadcasts`

来源：源码第 118 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-daf9171bd8a7"></a>

## `NationalSpire.Coop.CoopRun.Speeches — public List<CoopSpeech> Speeches`

来源：源码第 119 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-86c839dea7aa"></a>

## `NationalSpire.Coop.CoopRun.Terminal — public CoopTerminalResult? Terminal`

来源：源码第 120 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c743009879ac"></a>

## `NationalSpire.Coop.CoopRun.CheckpointCopy() — public CoopRun CheckpointCopy()`

来源：源码第 121 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopWorld.RunCheckpoint()`](CoopData.cs.md#symbol-37c5b2e81f81)

**调用：** `object.MemberwiseClone()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `object.MemberwiseClone()`；输入表达式：`MemberwiseClone()`；返回值紧邻使用处：`CastExpressionSyntax: (CoopRun)MemberwiseClone()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d642051b95a7"></a>

## `NationalSpire.Coop.CoopTerminalResult.Details — public Dictionary<ulong, CareerResult> Details`

来源：源码第 124 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a621fcd4242b"></a>

## `NationalSpire.Coop.CoopSpeech.Role — public string Role`

来源：源码第 126 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-839bb29fb609"></a>

## `NationalSpire.Coop.CoopSettlement.Attempt — public string Attempt`

来源：源码第 130 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ffd8a3b9d2f2"></a>

## `NationalSpire.Coop.CoopSettlement.MatchId — public string MatchId`

来源：源码第 131 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-900ccbebef1e"></a>

## `NationalSpire.Coop.CoopSettlement.Title — public string Title`

来源：源码第 132 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f6c064c75e01"></a>

## `NationalSpire.Coop.CoopSettlement.Outcome — public string Outcome`

来源：源码第 133 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-24c26199cef5"></a>

## `NationalSpire.Coop.CoopSettlement.Cleared — public bool Cleared`

来源：源码第 134 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9389f6f90b1f"></a>

## `NationalSpire.Coop.CoopSettlement.Floor — public int Floor`

来源：源码第 135 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5263c8791004"></a>

## `NationalSpire.Coop.CoopSettlement.Seconds — public double Seconds`

来源：源码第 136 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b4fcff2876b2"></a>

## `NationalSpire.Coop.CoopSettlement.Day — public int Day`

来源：源码第 137 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3a5aac5d2117"></a>

## `NationalSpire.Coop.CoopSettlement.Payouts — public Dictionary<ulong, int> Payouts`

来源：源码第 138 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f96504349e4f"></a>

## `NationalSpire.Coop.CoopSettlement.Players — public List<CoopLivePlayer> Players`

来源：源码第 139 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-371021dc0814"></a>

## `NationalSpire.Coop.CoopSettlement.Rankings — public SettlementRecord? Rankings`

来源：源码第 140 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6646e7770e58"></a>

## `NationalSpire.Coop.CoopReading.Posts — public Dictionary<string,long> Posts`

来源：源码第 148 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-394e7fc86f1e"></a>

## `NationalSpire.Coop.CoopReading.Weeks — public Dictionary<int,long> Weeks`

来源：源码第 149 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ef6b9c7daf65"></a>

## `NationalSpire.Coop.CoopReading.Settlement — public string Settlement`

来源：源码第 150 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**
