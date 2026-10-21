# Coop/CoopRandomEvents.cs

[返回文件依赖索引](../../SOURCE_MAP.md)

源码 SHA-256：`80A026CCC19D4AE6522C3C141EEC644C2B68DAB3634510F1D18BEBFA32A603C7`。来源：[源码](../../../Coop/CoopRandomEvents.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Coop.CoopRules`、`NationalSpire.Coop.CoopCoordinator`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-dde49f27790c"></a>

## `NationalSpire.Coop.CoopRules.EventCommand(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.Coop.CoopCommand) — private static string? EventCommand(CoopWorld w, CoopMember member, CoopCommand command)`

来源：源码第 5 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** [`NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`](../AiSettingsStore.cs.md#symbol-b37e55b3af97)；[`NationalSpire.Coop.CoopRules.Capture(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.CareerData)`](CoopRules.cs.md#symbol-99be42ec0491)；[`NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`](CoopRules.cs.md#symbol-d8e501560a84)；[`NationalSpire.RandomEvents.Choose(NationalSpire.CareerData, string, int, bool)`](../RandomEvents.cs.md#symbol-c0266703d306)；[`NationalSpire.RandomEvents.ChooseCustom(NationalSpire.CareerData, string, bool)`](../RandomEvents.cs.md#symbol-c949f4a092a3)；[`NationalSpire.RandomEvents.Custom(NationalSpire.CareerData, string, string)`](../RandomEvents.cs.md#symbol-b7d9c2f158f5)；[`NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`](../RandomEvents.cs.md#symbol-20d7a260dcab)；[`NationalSpire.RandomEvents.Skip(NationalSpire.CareerData, string)`](../RandomEvents.cs.md#symbol-9b570a0265e9)；[`NationalSpire.RandomEvents.Start(NationalSpire.CareerData, string)`](../RandomEvents.cs.md#symbol-605db3348248)；[`NationalSpire.RandomEvents.Stop(NationalSpire.CareerData, string)`](../RandomEvents.cs.md#symbol-3b62c8ad1ca6)；`NationalSpire.AiOptions.AiOptions()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Market`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Registered`；`NationalSpire.Coop.CoopCommand.Kind`；`NationalSpire.Coop.CoopCommand.Number`；`NationalSpire.Coop.CoopCommand.Target`；`NationalSpire.Coop.CoopCommand.Text`；`NationalSpire.Coop.CoopRules.Capture(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.CareerData)`；`NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.EsportsCareer.Nations`；`NationalSpire.RandomEventRecord.MatchIds`；`NationalSpire.RandomEvents.Choose(NationalSpire.CareerData, string, int, bool)`；`NationalSpire.RandomEvents.ChooseCustom(NationalSpire.CareerData, string, bool)`；`NationalSpire.RandomEvents.Custom(NationalSpire.CareerData, string, string)`；`NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`；`NationalSpire.RandomEvents.Skip(NationalSpire.CareerData, string)`；`NationalSpire.RandomEvents.Start(NationalSpire.CareerData, string)`；`NationalSpire.RandomEvents.Stop(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiOptions.AiOptions()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；输入表达式：`AiSettingsStore.Load(new())`；返回值紧邻使用处：`AssignmentExpressionSyntax: d.Ai = AiSettingsStore.Load(new())`
- `NationalSpire.Coop.CoopRules.Capture(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.CareerData)`；输入表达式：`Capture(w, member, d)`；返回值紧邻使用处：`ExpressionStatementSyntax: Capture(w, member, d);`
- `NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`；输入表达式：`View(w, member)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = View(w, member)`
- `NationalSpire.RandomEvents.Choose(NationalSpire.CareerData, string, int, bool)`；输入表达式：`RandomEvents.Choose(d, command.Target, command.Number, command.Text == "public")`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "event-choose" => RandomEvents.Choose(d, command.Target, command.Number, command.Text == "public")`
- `NationalSpire.RandomEvents.ChooseCustom(NationalSpire.CareerData, string, bool)`；输入表达式：`RandomEvents.ChooseCustom(d, command.Target, command.Text == "public")`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "event-custom-choose" => RandomEvents.ChooseCustom(d, command.Target, command.Text == "public")`
- `NationalSpire.RandomEvents.Custom(NationalSpire.CareerData, string, string)`；输入表达式：`RandomEvents.Custom(d, command.Target, command.Text)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "event-custom" => RandomEvents.Custom(d, command.Target, command.Text)`
- `NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`；输入表达式：`RandomEvents.Find(d, command.Target)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: RandomEvents.Find(d, command.Target)?.MatchIds.Contains(m.Id)`
- `NationalSpire.RandomEvents.Skip(NationalSpire.CareerData, string)`；输入表达式：`RandomEvents.Skip(d, command.Target)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "event-skip" => RandomEvents.Skip(d, command.Target)`
- `NationalSpire.RandomEvents.Start(NationalSpire.CareerData, string)`；输入表达式：`RandomEvents.Start(d, command.Target)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "event-start" => RandomEvents.Start(d, command.Target)`
- `NationalSpire.RandomEvents.Stop(NationalSpire.CareerData, string)`；输入表达式：`RandomEvents.Stop(d, command.Target)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "event-stop" => RandomEvents.Stop(d, command.Target)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.Where(m => RandomEvents.Find(d, command.Target)?.MatchIds.Contains(m.Id) == true)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var match in d.Matches.Where(m => RandomEvents.Find(d, command.Target)?.MatchIds.Contains(m.Id) == true)) match.Registered = true;`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`.MatchIds.Contains(m.Id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: RandomEvents.Find(d, command.Target)?.MatchIds.Contains(m.Id)`

**赋值（含属性/字段和局部值）：**

- `d.Ai` = `AiSettingsStore.Load(new())`
- `match.Registered` = `true`
- `w.World.Esports.Nations` = `d.Esports.Nations`
- `w.World.Market` = `d.Market`
- `w.World.Matches` = `d.Matches`

<a id="symbol-b51ea4166eab"></a>

## `NationalSpire.Coop.CoopCoordinator.StartEvent(ulong, NationalSpire.Coop.CoopCommand) — private void StartEvent(ulong sender, CoopCommand command)`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

<a id="symbol-4802c825eb0f"></a>

## `Current() — CareerData? Current()`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

<a id="symbol-5bd2269a96bc"></a>

## `Save(NationalSpire.CareerData) — void Save(CareerData data)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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
