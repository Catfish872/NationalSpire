# Coop/CoopRandomEvents.cs

[返回文件依赖索引](../../SOURCE_MAP.md)

源码 SHA-256：`EE136A6BB6EE0EC63F77A228F3DE4A12A2941B65306C23F6924D87DE3B1C7C54`。来源：[源码](../../../Coop/CoopRandomEvents.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Coop.CoopRules`、`NationalSpire.Coop.CoopCoordinator`、`NationalSpire.Coop.CoopCoordinator.PoolQuery`、`NationalSpire.Coop.CoopCoordinator.PoolAnswer`。

字段、事件及初始值（源码原样）：

```csharp
private event Action<PoolAnswer>? PoolReceived;
```

<a id="symbol-f66a72d13c3e"></a>

## `NationalSpire.Coop.CoopRules.SynchronizeEventSchedule(NationalSpire.Coop.CoopWorld) — public static void SynchronizeEventSchedule(CoopWorld w)`

来源：源码第 5 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.AddMember(NationalSpire.Coop.CoopWorld, ulong, string, NationalSpire.CareerOpeningPlayer?)`](CoopRules.cs.md#symbol-8d3bfcd3efe2)；[`NationalSpire.Coop.CoopRules.AdvanceMembers(NationalSpire.Coop.CoopWorld)`](CoopRules.cs.md#symbol-bc24477e89ba)；[`NationalSpire.Coop.CoopRules.EventCommand(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.Coop.CoopCommand)`](CoopRandomEvents.cs.md#symbol-dde49f27790c)

**调用：** [`NationalSpire.RandomEvents.Schedule(NationalSpire.CareerLifeState, int, string, int?)`](../RandomEvents.cs.md#symbol-f546dd3643ba)；[`NationalSpire.RandomEvents.SynchronizeSchedule(NationalSpire.CareerLifeState, NationalSpire.CareerLifeState, int)`](../RandomEvents.cs.md#symbol-bec384082476)；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.Coop.CoopMember.Life`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Owner`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.RandomEvents.Schedule(NationalSpire.CareerLifeState, int, string, int?)`；`NationalSpire.RandomEvents.SynchronizeSchedule(NationalSpire.CareerLifeState, NationalSpire.CareerLifeState, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RandomEvents.Schedule(NationalSpire.CareerLifeState, int, string, int?)`；输入表达式：`RandomEvents.Schedule(owner.Life, w.World.Day, w.Id + "-" + owner.SteamId)`；返回值紧邻使用处：`ExpressionStatementSyntax: RandomEvents.Schedule(owner.Life, w.World.Day, w.Id + "-" + owner.SteamId);`
- `NationalSpire.RandomEvents.SynchronizeSchedule(NationalSpire.CareerLifeState, NationalSpire.CareerLifeState, int)`；输入表达式：`RandomEvents.SynchronizeSchedule(member.Life, owner.Life, w.World.Day)`；返回值紧邻使用处：`ExpressionStatementSyntax: RandomEvents.SynchronizeSchedule(member.Life, owner.Life, w.World.Day);`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`w.Members.Single(m => m.SteamId == w.Owner)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = w.Members.Single(m => m.SteamId == w.Owner)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`w.Members.Where(m => m.SteamId != w.Owner)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var member in w.Members.Where(m => m.SteamId != w.Owner))              RandomEvents.SynchronizeSchedule(member.Life, owner.Life, w.World.Day);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-dde49f27790c"></a>

## `NationalSpire.Coop.CoopRules.EventCommand(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.Coop.CoopCommand) — private static string? EventCommand(CoopWorld w, CoopMember member, CoopCommand command)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** [`NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`](../AiSettingsStore.cs.md#symbol-b37e55b3af97)；[`NationalSpire.Coop.CoopRules.Capture(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.CareerData)`](CoopRules.cs.md#symbol-99be42ec0491)；[`NationalSpire.Coop.CoopRules.SynchronizeEventSchedule(NationalSpire.Coop.CoopWorld)`](CoopRandomEvents.cs.md#symbol-f66a72d13c3e)；[`NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`](CoopRules.cs.md#symbol-d8e501560a84)；[`NationalSpire.RandomEvents.Choose(NationalSpire.CareerData, string, int, bool)`](../RandomEvents.cs.md#symbol-c0266703d306)；[`NationalSpire.RandomEvents.ChooseCustom(NationalSpire.CareerData, string, bool)`](../RandomEvents.cs.md#symbol-c949f4a092a3)；[`NationalSpire.RandomEvents.Custom(NationalSpire.CareerData, string, string)`](../RandomEvents.cs.md#symbol-b7d9c2f158f5)；[`NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`](../RandomEvents.cs.md#symbol-20d7a260dcab)；[`NationalSpire.RandomEvents.SetFrequency(NationalSpire.CareerData, int, int)`](../RandomEvents.cs.md#symbol-f57e4579867f)；[`NationalSpire.RandomEvents.Skip(NationalSpire.CareerData, string)`](../RandomEvents.cs.md#symbol-9b570a0265e9)；[`NationalSpire.RandomEvents.Start(NationalSpire.CareerData, string, NationalSpire.EventOpeningChoice?)`](../RandomEvents.cs.md#symbol-913aeeb9683c)；[`NationalSpire.RandomEvents.Stop(NationalSpire.CareerData, string)`](../RandomEvents.cs.md#symbol-3b62c8ad1ca6)；`int.Parse(string, System.IFormatProvider?)`；`NationalSpire.AiOptions.AiOptions()`；`string.StartsWith(char)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Market`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Registered`；`NationalSpire.Coop.CoopCommand.Kind`；`NationalSpire.Coop.CoopCommand.Number`；`NationalSpire.Coop.CoopCommand.Target`；`NationalSpire.Coop.CoopCommand.Text`；`NationalSpire.Coop.CoopJson.Options`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopRules.Capture(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.CareerData)`；`NationalSpire.Coop.CoopRules.SynchronizeEventSchedule(NationalSpire.Coop.CoopWorld)`；`NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`；`NationalSpire.Coop.CoopWorld.Owner`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.EsportsCareer.Nations`；`NationalSpire.RandomEventRecord.MatchIds`；`NationalSpire.RandomEvents.Choose(NationalSpire.CareerData, string, int, bool)`；`NationalSpire.RandomEvents.ChooseCustom(NationalSpire.CareerData, string, bool)`；`NationalSpire.RandomEvents.Custom(NationalSpire.CareerData, string, string)`；`NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`；`NationalSpire.RandomEvents.SetFrequency(NationalSpire.CareerData, int, int)`；`NationalSpire.RandomEvents.Skip(NationalSpire.CareerData, string)`；`NationalSpire.RandomEvents.Start(NationalSpire.CareerData, string, NationalSpire.EventOpeningChoice?)`；`NationalSpire.RandomEvents.Stop(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.Parse(string, System.IFormatProvider?)`；输入表达式：`int.Parse(command.Text, System.Globalization.CultureInfo.InvariantCulture)`；返回值紧邻使用处：`ArgumentSyntax: int.Parse(command.Text, System.Globalization.CultureInfo.InvariantCulture)`
- `NationalSpire.AiOptions.AiOptions()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；输入表达式：`AiSettingsStore.Load(new())`；返回值紧邻使用处：`AssignmentExpressionSyntax: d.Ai = AiSettingsStore.Load(new())`
- `NationalSpire.Coop.CoopRules.Capture(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.CareerData)`；输入表达式：`Capture(w, member, d)`；返回值紧邻使用处：`ExpressionStatementSyntax: Capture(w, member, d);`
- `NationalSpire.Coop.CoopRules.SynchronizeEventSchedule(NationalSpire.Coop.CoopWorld)`；输入表达式：`SynchronizeEventSchedule(w)`；返回值紧邻使用处：`ExpressionStatementSyntax: SynchronizeEventSchedule(w);`
- `NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`；输入表达式：`View(w, member)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = View(w, member)`
- `NationalSpire.RandomEvents.Choose(NationalSpire.CareerData, string, int, bool)`；输入表达式：`RandomEvents.Choose(d, command.Target, command.Number, command.Text == "public")`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "event-choose" => RandomEvents.Choose(d, command.Target, command.Number, command.Text == "public")`
- `NationalSpire.RandomEvents.ChooseCustom(NationalSpire.CareerData, string, bool)`；输入表达式：`RandomEvents.ChooseCustom(d, command.Target, command.Text == "public")`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "event-custom-choose" => RandomEvents.ChooseCustom(d, command.Target, command.Text == "public")`
- `NationalSpire.RandomEvents.Custom(NationalSpire.CareerData, string, string)`；输入表达式：`RandomEvents.Custom(d, command.Target, command.Text)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "event-custom" => RandomEvents.Custom(d, command.Target, command.Text)`
- `NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`；输入表达式：`RandomEvents.Find(d, command.Target)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: RandomEvents.Find(d, command.Target)?.MatchIds.Contains(m.Id)`
- `NationalSpire.RandomEvents.SetFrequency(NationalSpire.CareerData, int, int)`；输入表达式：`RandomEvents.SetFrequency(d, command.Number, int.Parse(command.Text, System.Globalization.CultureInfo.InvariantCulture))`；返回值紧邻使用处：`ExpressionStatementSyntax: RandomEvents.SetFrequency(d, command.Number, int.Parse(command.Text, System.Globalization.CultureInfo.InvariantCulture));`
- `NationalSpire.RandomEvents.Skip(NationalSpire.CareerData, string)`；输入表达式：`RandomEvents.Skip(d, command.Target)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "event-skip" => RandomEvents.Skip(d, command.Target)`
- `NationalSpire.RandomEvents.Start(NationalSpire.CareerData, string, NationalSpire.EventOpeningChoice?)`；输入表达式：`RandomEvents.Start(d, command.Target, command.Text.StartsWith('{')                  ? System.Text.Json.JsonSerializer.Deserialize<EventOpeningChoice>(command.Text, CoopJson.Options) : null)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "event-start" => RandomEvents.Start(d, command.Target, command.Text.StartsWith('{')                  ? System.Text.Json.JsonSerializer.Deserialize<EventOpeningChoice>(command.Text, CoopJson.Options) : null)`
- `NationalSpire.RandomEvents.Stop(NationalSpire.CareerData, string)`；输入表达式：`RandomEvents.Stop(d, command.Target)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "event-stop" => RandomEvents.Stop(d, command.Target)`
- `string.StartsWith(char)`；输入表达式：`command.Text.StartsWith('{')`；返回值紧邻使用处：`ConditionalExpressionSyntax: command.Text.StartsWith('{')                  ? System.Text.Json.JsonSerializer.Deserialize<EventOpeningChoice>(command.Text, CoopJson.Options) : null`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.Where(m => RandomEvents.Find(d, command.Target)?.MatchIds.Contains(m.Id) == true)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var match in d.Matches.Where(m => RandomEvents.Find(d, command.Target)?.MatchIds.Contains(m.Id) == true)) match.Registered = true;`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`.MatchIds.Contains(m.Id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: RandomEvents.Find(d, command.Target)?.MatchIds.Contains(m.Id)`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`System.Text.Json.JsonSerializer.Deserialize<EventOpeningChoice>(command.Text, CoopJson.Options)`；返回值紧邻使用处：`ConditionalExpressionSyntax: command.Text.StartsWith('{')                  ? System.Text.Json.JsonSerializer.Deserialize<EventOpeningChoice>(command.Text, CoopJson.Options) : null`

**赋值（含属性/字段和局部值）：**

- `d.Ai` = `AiSettingsStore.Load(new())`
- `match.Registered` = `true`
- `w.World.Esports.Nations` = `d.Esports.Nations`
- `w.World.Market` = `d.Market`
- `w.World.Matches` = `d.Matches`

<a id="symbol-191944b9b478"></a>

## `NationalSpire.Coop.CoopCoordinator.ReadEventPool(System.Threading.CancellationToken) — internal async Task<RandomEventSeed[]> ReadEventPool(CancellationToken cancel)`

来源：源码第 47 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCareerSession.ReadEventPool(System.Threading.CancellationToken)`](CoopCareerSession.cs.md#symbol-ddd5192fa0da)

**调用：** [`NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`](../AiSettingsStore.cs.md#symbol-b37e55b3af97)；[`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`](CoopCoordinator.cs.md#symbol-0145ddb8062f)；[`NationalSpire.EventPools.Get(NationalSpire.AiOptions)`](../EventPools.cs.md#symbol-5c94170cef9e)；`NationalSpire.AiOptions.AiOptions()`；`NationalSpire.Coop.CoopCoordinator.PoolQuery.PoolQuery(string, string, string)`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`；`System.Threading.Tasks.Task<TResult>.WaitAsync(System.TimeSpan, System.Threading.CancellationToken)`；`System.Threading.Tasks.TaskCompletionSource<TResult>.TaskCompletionSource()`；`System.TimeSpan.FromSeconds(long)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；`NationalSpire.Coop.CoopCoordinator._transport`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.PoolReceived`；`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.ICoopTransport.Owner`；`NationalSpire.EventPools.Get(NationalSpire.AiOptions)`；`NationalSpire.EventPools.Snapshot.Random`；`ReceiveAnswer(NationalSpire.Coop.CoopCoordinator.PoolAnswer)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiOptions.AiOptions()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；输入表达式：`AiSettingsStore.Load(new())`；返回值紧邻使用处：`ArgumentSyntax: AiSettingsStore.Load(new())`
- `NationalSpire.Coop.CoopCoordinator.PoolQuery.PoolQuery(string, string, string)`；输入表达式：`new PoolQuery(Guid.NewGuid().ToString("N"), World!.Id, World.Epoch)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PoolQuery(Guid.NewGuid().ToString("N"), World!.Id, World.Epoch)`
- `NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；输入表达式：`Send(_transport.Owner, "event-pool-query", query)`；返回值紧邻使用处：`ExpressionStatementSyntax: Send(_transport.Owner, "event-pool-query", query);`
- `NationalSpire.EventPools.Get(NationalSpire.AiOptions)`；输入表达式：`EventPools.Get(AiSettingsStore.Load(new()))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: EventPools.Get(AiSettingsStore.Load(new())).Random`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`ArgumentSyntax: Guid.NewGuid().ToString("N")`
- `System.Threading.Tasks.Task<TResult>.WaitAsync(System.TimeSpan, System.Threading.CancellationToken)`；输入表达式：`ready.Task.WaitAsync(TimeSpan.FromSeconds(10), cancel)`；返回值紧邻使用处：`AwaitExpressionSyntax: await ready.Task.WaitAsync(TimeSpan.FromSeconds(10), cancel)`
- `System.Threading.Tasks.TaskCompletionSource<TResult>.TaskCompletionSource()`；输入表达式：`new TaskCompletionSource<RandomEventSeed[]>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new TaskCompletionSource<RandomEventSeed[]>()`
- `System.TimeSpan.FromSeconds(long)`；输入表达式：`TimeSpan.FromSeconds(10)`；返回值紧邻使用处：`ArgumentSyntax: TimeSpan.FromSeconds(10)`

**赋值（含属性/字段和局部值）：**

- `PoolReceived` -= `ReceiveAnswer`
- `PoolReceived` += `ReceiveAnswer`

<a id="symbol-966194d547c5"></a>

## `ReceiveAnswer(NationalSpire.Coop.CoopCoordinator.PoolAnswer) — void ReceiveAnswer(PoolAnswer answer)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Threading.Tasks.TaskCompletionSource<TResult>.TrySetResult(TResult)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.PoolAnswer.Entries`；`NationalSpire.Coop.CoopCoordinator.PoolAnswer.Query`；`NationalSpire.Coop.CoopCoordinator.PoolQuery.Epoch`；`NationalSpire.Coop.CoopCoordinator.PoolQuery.World`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Threading.Tasks.TaskCompletionSource<TResult>.TrySetResult(TResult)`；输入表达式：`ready.TrySetResult(answer.Entries)`；返回值紧邻使用处：`ExpressionStatementSyntax: ready.TrySetResult(answer.Entries);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7d2949d41b65"></a>

## `NationalSpire.Coop.CoopCoordinator.ReceiveEventPool(ulong, NationalSpire.Coop.CoopWire) — private void ReceiveEventPool(ulong sender, CoopWire wire)`

来源：源码第 65 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.ReceiveNow(ulong, NationalSpire.Coop.CoopWire, System.DateTime)`](CoopCoordinator.cs.md#symbol-796041df5e9f)

**调用：** [`NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`](../AiSettingsStore.cs.md#symbol-b37e55b3af97)；[`NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`](CoopCoordinator.cs.md#symbol-4239da75be84)；[`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`](CoopCoordinator.cs.md#symbol-0145ddb8062f)；[`NationalSpire.EventPools.Get(NationalSpire.AiOptions)`](../EventPools.cs.md#symbol-5c94170cef9e)；`NationalSpire.AiOptions.AiOptions()`；`NationalSpire.Coop.CoopCoordinator.PoolAnswer.PoolAnswer(NationalSpire.Coop.CoopCoordinator.PoolQuery, NationalSpire.RandomEventSeed[])`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.PoolQuery.Epoch`；`NationalSpire.Coop.CoopCoordinator.PoolQuery.World`；`NationalSpire.Coop.CoopCoordinator.PoolReceived`；`NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`；`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopWire.Kind`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.EventPools.Get(NationalSpire.AiOptions)`；`NationalSpire.EventPools.Snapshot.Random`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiOptions.AiOptions()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；输入表达式：`AiSettingsStore.Load(new())`；返回值紧邻使用处：`ArgumentSyntax: AiSettingsStore.Load(new())`
- `NationalSpire.Coop.CoopCoordinator.PoolAnswer.PoolAnswer(NationalSpire.Coop.CoopCoordinator.PoolQuery, NationalSpire.RandomEventSeed[])`；输入表达式：`new PoolAnswer(query,entries)`；返回值紧邻使用处：`ArgumentSyntax: new PoolAnswer(query,entries)`
- `NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`；输入表达式：`Read<PoolAnswer>(wire)`；返回值紧邻使用处：`ArgumentSyntax: Read<PoolAnswer>(wire)`
- `NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`；输入表达式：`Read<PoolQuery>(wire)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Read<PoolQuery>(wire)`
- `NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；输入表达式：`Send(sender, "event-pool-answer", new PoolAnswer(query,entries))`；返回值紧邻使用处：`ExpressionStatementSyntax: Send(sender, "event-pool-answer", new PoolAnswer(query,entries));`
- `NationalSpire.EventPools.Get(NationalSpire.AiOptions)`；输入表达式：`EventPools.Get(AiSettingsStore.Load(new()))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: EventPools.Get(AiSettingsStore.Load(new())).Random`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(Read<PoolAnswer>(wire))`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: PoolReceived?.Invoke(Read<PoolAnswer>(wire))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b51ea4166eab"></a>

## `NationalSpire.Coop.CoopCoordinator.StartEvent(ulong, NationalSpire.Coop.CoopCommand) — private void StartEvent(ulong sender, CoopCommand command)`

来源：源码第 74 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.Execute(ulong, NationalSpire.Coop.CoopCommand)`](CoopCoordinator.cs.md#symbol-ec0c662c6de0)

**调用：** [`NationalSpire.AiService.ProcessEventAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<NationalSpire.EventLive>?)`](../AiRandomEvents.cs.md#symbol-5705d03a72b3)；[`NationalSpire.Coop.CoopAssembler.Split(byte[], bool)`](CoopWire.cs.md#symbol-d89dceccb833)；[`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`](CoopCoordinator.cs.md#symbol-0145ddb8062f)；[`NationalSpire.Coop.CoopJson.Bytes<T>(T)`](CoopData.cs.md#symbol-faeb54cab7ee)；`NationalSpire.Coop.CoopPrivateChunk.CoopPrivateChunk(string, string, string, string, string, int, string, System.Collections.Generic.List<NationalSpire.DateSceneLine>?)`；`NationalSpire.Coop.CoopPrivatePart.CoopPrivatePart(string, NationalSpire.Coop.CoopPart)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `Current()`；`NationalSpire.AiService.ProcessEventAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<NationalSpire.EventLive>?)`；`NationalSpire.Coop.CoopAssembler.Split(byte[], bool)`；`NationalSpire.Coop.CoopCommand.Kind`；`NationalSpire.Coop.CoopCommand.Target`；`NationalSpire.Coop.CoopCoordinator._closed`；`NationalSpire.Coop.CoopCoordinator._privateSendSequence`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopJson.Bytes<T>(T)`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Id`；`Save(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.ProcessEventAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<NationalSpire.EventLive>?)`；输入表达式：`AiService.ProcessEventAsync(Current, Save, command.Target, live =>          {              if (_closed || World?.Epoch != epoch || sender == Self) return;              string person = "event:" + command.Target;              foreach (var part in CoopAssembler.Split(CoopJson.Bytes(new CoopPrivateChunk(worldId, epoch, person, command.Target,                  System.Text.Json.JsonSerializer.Serialize(live), ++_privateSendSequence))))                  Send(sender, "private-chunk", new CoopPrivatePart(person, part));          })`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.ProcessEventAsync(Current, Save, command.Target, live =>          {              if (_closed || World?.Epoch != epoch || sender == Self) return;              string person = "event:" + command.Target;              foreach (var part in CoopAssembler.Split(CoopJson.Bytes(new CoopPrivateChunk(worldId, epoch, person, command.Target,                  System.Text.Json.JsonSerializer.Serialize(live), ++_privateSendSequence))))                  Send(sender, "private-chunk", new CoopPrivatePart(person, part));          })`
- `NationalSpire.Coop.CoopAssembler.Split(byte[], bool)`；输入表达式：`CoopAssembler.Split(CoopJson.Bytes(new CoopPrivateChunk(worldId, epoch, person, command.Target,                  System.Text.Json.JsonSerializer.Serialize(live), ++_privateSendSequence)))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var part in CoopAssembler.Split(CoopJson.Bytes(new CoopPrivateChunk(worldId, epoch, person, command.Target,                  System.Text.Json.JsonSerializer.Serialize(live), ++_privateSendSequence))))                  Send(sender, "private-chunk", new CoopPrivatePart(person, part));`
- `NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；输入表达式：`Send(sender, "private-chunk", new CoopPrivatePart(person, part))`；返回值紧邻使用处：`ExpressionStatementSyntax: Send(sender, "private-chunk", new CoopPrivatePart(person, part));`
- `NationalSpire.Coop.CoopJson.Bytes<T>(T)`；输入表达式：`CoopJson.Bytes(new CoopPrivateChunk(worldId, epoch, person, command.Target,                  System.Text.Json.JsonSerializer.Serialize(live), ++_privateSendSequence))`；返回值紧邻使用处：`ArgumentSyntax: CoopJson.Bytes(new CoopPrivateChunk(worldId, epoch, person, command.Target,                  System.Text.Json.JsonSerializer.Serialize(live), ++_privateSendSequence))`
- `NationalSpire.Coop.CoopPrivateChunk.CoopPrivateChunk(string, string, string, string, string, int, string, System.Collections.Generic.List<NationalSpire.DateSceneLine>?)`；输入表达式：`new CoopPrivateChunk(worldId, epoch, person, command.Target,                  System.Text.Json.JsonSerializer.Serialize(live), ++_privateSendSequence)`；返回值紧邻使用处：`ArgumentSyntax: new CoopPrivateChunk(worldId, epoch, person, command.Target,                  System.Text.Json.JsonSerializer.Serialize(live), ++_privateSendSequence)`
- `NationalSpire.Coop.CoopPrivatePart.CoopPrivatePart(string, NationalSpire.Coop.CoopPart)`；输入表达式：`new CoopPrivatePart(person, part)`；返回值紧邻使用处：`ArgumentSyntax: new CoopPrivatePart(person, part)`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`System.Text.Json.JsonSerializer.Serialize(live)`；返回值紧邻使用处：`ArgumentSyntax: System.Text.Json.JsonSerializer.Serialize(live)`

**赋值（含属性/字段和局部值）：**

- `_` = `AiService.ProcessEventAsync(Current, Save, command.Target, live =>          {              if (_closed || World?.Epoch != epoch || sender == Self) return;              string person = "event:" + command.Target;              foreach (var part in CoopAssembler.Split(CoopJson.Bytes(new CoopPrivateChunk(worldId, epoch, person, command.Target,                  System.Text.Json.JsonSerializer.Serialize(live), ++_privateSendSequence))))                  Send(sender, "private-chunk", new CoopPrivatePart(person, part));          })`

<a id="symbol-bcc9a6b982c3"></a>

## `Current() — CareerData? Current()`

来源：源码第 78 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`](../AiSettingsStore.cs.md#symbol-b37e55b3af97)；[`NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`](CoopRules.cs.md#symbol-d8e501560a84)；`NationalSpire.AiOptions.AiOptions()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；`NationalSpire.CareerData.Ai`；`NationalSpire.Coop.CoopCoordinator._closed`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.CoopWorld.Members`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiOptions.AiOptions()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；输入表达式：`AiSettingsStore.Load(new())`；返回值紧邻使用处：`AssignmentExpressionSyntax: data.Ai = AiSettingsStore.Load(new())`
- `NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`；输入表达式：`CoopRules.View(World, member)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopRules.View(World, member)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`World.Members.FirstOrDefault(m => m.SteamId == sender)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = World.Members.FirstOrDefault(m => m.SteamId == sender)`

**赋值（含属性/字段和局部值）：**

- `data.Ai` = `AiSettingsStore.Load(new())`

<a id="symbol-93dcc724ca8f"></a>

## `Save(NationalSpire.CareerData) — void Save(CareerData data)`

来源：源码第 84 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`](CoopCoordinator.cs.md#symbol-e1dfe22e8221)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`](CoopData.cs.md#symbol-85d2410ea3ba)；[`NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`](../RandomEvents.cs.md#symbol-20d7a260dcab)；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerLifeState.RandomEvents`；`NationalSpire.Coop.CoopCommand.Target`；`NationalSpire.Coop.CoopCoordinator._closed`；`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；`NationalSpire.Coop.CoopCoordinator.NativeSave`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`；`NationalSpire.Coop.CoopMember.Life`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Revision`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.RandomEventRecord.CustomState`；`NationalSpire.RandomEventRecord.Id`；`NationalSpire.RandomEventRecord.State`；`NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；输入表达式：`Commit(copy, NativeSave)`；返回值紧邻使用处：`ExpressionStatementSyntax: Commit(copy, NativeSave);`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(World)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Copy(World)`
- `NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`；输入表达式：`CoopJson.Detached(copy.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopJson.Detached(copy.World);`
- `NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`；输入表达式：`RandomEvents.Find(data, command.Target)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: RandomEvents.Find(data, command.Target)!`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`copy.Members.Single(m => m.SteamId == sender)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = copy.Members.Single(m => m.SteamId == sender)`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`member.Life.RandomEvents.FindIndex(e => e.Id == command.Target)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = member.Life.RandomEvents.FindIndex(e => e.Id == command.Target)`

**赋值（含属性/字段和局部值）：**

- `member.Life.RandomEvents[index]` = `RandomEvents.Find(data, command.Target)!`
