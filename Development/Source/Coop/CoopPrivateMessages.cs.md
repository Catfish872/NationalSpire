# Coop/CoopPrivateMessages.cs

[返回文件依赖索引](../../SOURCE_MAP.md)

源码 SHA-256：`897CB841C28DF3F81278BD8116DF07260A62C3DF84769B355E5EC01D7AB506B1`。来源：[源码](../../../Coop/CoopPrivateMessages.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Coop.CoopPrivateChunk`、`NationalSpire.Coop.CoopPrivatePart`、`NationalSpire.Coop.CoopCoordinator`、`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder`、`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value`、`NationalSpire.Coop.CoopRules`。

字段、事件及初始值（源码原样）：

```csharp
private readonly Dictionary<string, int> _privateSequences = [];
private readonly Dictionary<string, CoopAssembler> _privateAssemblers = [];
private int _privateSendSequence;
internal string Name = "", Path = "";
internal int Start, Length;
internal List<Value>? Children;
internal ulong Member;
internal HashSet<string>? Members;
private readonly byte[] _source, _mailbox = CoopJson.Bytes(new PrivateMailbox());
private readonly Value _root;
```

<a id="symbol-3d07402de490"></a>

## `NationalSpire.Coop.CoopCoordinator.ReceivePrivate(NationalSpire.Coop.CoopWire) — private void ReceivePrivate(CoopWire wire)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.Receive(ulong, NationalSpire.Coop.CoopWire)`](CoopCoordinator.cs.md#symbol-892f19740afa)

**调用：** [`NationalSpire.Coop.CoopAssembler.Add(NationalSpire.Coop.CoopPart)`](CoopWire.cs.md#symbol-b544da8202a5)；[`NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`](CoopCoordinator.cs.md#symbol-4239da75be84)；[`NationalSpire.Coop.CoopJson.Read<T>(byte[])`](CoopData.cs.md#symbol-1f7bf7625062)；[`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](../PrivateMessages.cs.md#symbol-25194feb6779)；`NationalSpire.Coop.CoopAssembler.CoopAssembler()`；`string.StartsWith(string)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.GroupLive`；`NationalSpire.AiService.GroupReasoningLive`；`NationalSpire.AiService.PrivateLive`；`NationalSpire.AiService.PrivateReasoningLive`；`NationalSpire.CareerData.Chats`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.Coop.CoopAssembler.Add(NationalSpire.Coop.CoopPart)`；`NationalSpire.Coop.CoopCoordinator._privateAssemblers`；`NationalSpire.Coop.CoopCoordinator._privateSequences`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopJson.Read<T>(byte[])`；`NationalSpire.Coop.CoopMember.PersonId`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopPart.Total`；`NationalSpire.Coop.CoopPrivateChunk.Epoch`；`NationalSpire.Coop.CoopPrivateChunk.Person`；`NationalSpire.Coop.CoopPrivateChunk.Reasoning`；`NationalSpire.Coop.CoopPrivateChunk.Sequence`；`NationalSpire.Coop.CoopPrivateChunk.Text`；`NationalSpire.Coop.CoopPrivateChunk.Turn`；`NationalSpire.Coop.CoopPrivateChunk.World`；`NationalSpire.Coop.CoopPrivatePart.Part`；`NationalSpire.Coop.CoopPrivatePart.Person`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupChat.Turns`；`NationalSpire.GroupTurn.Id`；`NationalSpire.GroupTurn.Status`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopAssembler.Add(NationalSpire.Coop.CoopPart)`；输入表达式：`assembler.Add(part.Part)`；返回值紧邻使用处：`IsPatternExpressionSyntax: assembler.Add(part.Part) is not { } bytes`
- `NationalSpire.Coop.CoopAssembler.CoopAssembler()`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: assembler = new()`
- `NationalSpire.Coop.CoopCoordinator.Read<T>(NationalSpire.Coop.CoopWire)`；输入表达式：`Read<CoopPrivatePart>(wire)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Read<CoopPrivatePart>(wire)`
- `NationalSpire.Coop.CoopJson.Read<T>(byte[])`；输入表达式：`CoopJson.Read<CoopPrivateChunk>(bytes)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Read<CoopPrivateChunk>(bytes)`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(World.World, part.Person)`；返回值紧邻使用处：`ConditionalExpressionSyntax: part.Person.StartsWith("group:") ? World.World.Chats.Groups.Any(g => "group:" + g.Id == part.Person && g.Members.Contains(World.Members.Single(m => m.SteamId == Self).PersonId)) : PrivateMessages.CanChat(World.World, part.Person)`
- `string.StartsWith(string)`；输入表达式：`chunk.Person.StartsWith("group:")`；返回值紧邻使用处：`IfStatementSyntax: if (chunk.Person.StartsWith("group:"))          {              var active = World.World.Chats.Groups.FirstOrDefault(g => g.Id == chunk.Person[6..])?.Turns.LastOrDefault();              if (active?.Id == chunk.Turn && active.Status is "queued" or "sending") { AiService.GroupLive[World.Id + "/group/" + chunk.Person[6..]] = chunk.Text; AiService.GroupReasoningLive[World.Id + "/group/" + chunk.Person[6..]] = (chunk.Turn, chunk.Reasoning); }              return;          }`
- `string.StartsWith(string)`；输入表达式：`part.Person.StartsWith("group:")`；返回值紧邻使用处：`ConditionalExpressionSyntax: part.Person.StartsWith("group:") ? World.World.Chats.Groups.Any(g => "group:" + g.Id == part.Person && g.Members.Contains(World.Members.Single(m => m.SteamId == Self).PersonId)) : PrivateMessages.CanChat(World.World, part.Person)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`_privateAssemblers.Remove(_privateAssemblers.Keys.First())`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateAssemblers.Remove(_privateAssemblers.Keys.First());`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`_privateSequences.Remove(_privateSequences.Keys.First())`；返回值紧邻使用处：`ExpressionStatementSyntax: _privateSequences.Remove(_privateSequences.Keys.First());`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_privateAssemblers.TryGetValue(part.Person, out var assembler)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_privateAssemblers.TryGetValue(part.Person, out var assembler)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`World.World.Chats.Groups.Any(g => "group:" + g.Id == part.Person && g.Members.Contains(World.Members.Single(m => m.SteamId == Self).PersonId))`；返回值紧邻使用处：`ConditionalExpressionSyntax: part.Person.StartsWith("group:") ? World.World.Chats.Groups.Any(g => "group:" + g.Id == part.Person && g.Members.Contains(World.Members.Single(m => m.SteamId == Self).PersonId)) : PrivateMessages.CanChat(World.World, part.Person)`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；输入表达式：`_privateAssemblers.Keys.First()`；返回值紧邻使用处：`ArgumentSyntax: _privateAssemblers.Keys.First()`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；输入表达式：`_privateSequences.Keys.First()`；返回值紧邻使用处：`ArgumentSyntax: _privateSequences.Keys.First()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`World.World.Chats.Groups.FirstOrDefault(g => g.Id == chunk.Person[6..])`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: World.World.Chats.Groups.FirstOrDefault(g => g.Id == chunk.Person[6..])?.Turns.LastOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`.Turns.LastOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: World.World.Chats.Groups.FirstOrDefault(g => g.Id == chunk.Person[6..])?.Turns.LastOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`World.Members.Single(m => m.SteamId == Self)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: World.Members.Single(m => m.SteamId == Self).PersonId`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`_privateSequences.GetValueOrDefault(sequence)`；返回值紧邻使用处：`BinaryExpressionSyntax: _privateSequences.GetValueOrDefault(sequence) >= chunk.Sequence`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`g.Members.Contains(World.Members.Single(m => m.SteamId == Self).PersonId)`；返回值紧邻使用处：`BinaryExpressionSyntax: "group:" + g.Id == part.Person && g.Members.Contains(World.Members.Single(m => m.SteamId == Self).PersonId)`

**赋值（含属性/字段和局部值）：**

- `_privateAssemblers[part.Person]` = `assembler = new()`
- `_privateSequences[sequence]` = `chunk.Sequence`
- `AiService.GroupLive[World.Id + "/group/" + chunk.Person[6..]]` = `chunk.Text`
- `AiService.GroupReasoningLive[World.Id + "/group/" + chunk.Person[6..]]` = `(chunk.Turn, chunk.Reasoning)`
- `AiService.PrivateLive[World.Id + "-" + Self + "/" + chunk.Person]` = `(chunk.Turn, chunk.Text)`
- `AiService.PrivateReasoningLive[World.Id + "-" + Self + "/" + chunk.Person]` = `(chunk.Turn, chunk.Reasoning)`
- `assembler` = `new()`

<a id="symbol-ebc3f29b5eb6"></a>

## `NationalSpire.Coop.CoopCoordinator.StartPrivate(ulong, NationalSpire.Coop.CoopCommand) — private void StartPrivate(ulong sender, CoopCommand command)`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.Execute(ulong, NationalSpire.Coop.CoopCommand)`](CoopCoordinator.cs.md#symbol-ec0c662c6de0)

**调用：** [`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](../AiPrivateMessages.cs.md#symbol-935c714481c1)；[`NationalSpire.AiService.SummarizePrivateManually(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string)`](../AiPrivateMessages.cs.md#symbol-88f72cb1c19e)；[`NationalSpire.Coop.CoopAssembler.Split(byte[])`](CoopWire.cs.md#symbol-67ad26af4646)；[`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`](CoopCoordinator.cs.md#symbol-0145ddb8062f)；[`NationalSpire.Coop.CoopJson.Bytes<T>(T)`](CoopData.cs.md#symbol-faeb54cab7ee)；`NationalSpire.Coop.CoopPrivateChunk.CoopPrivateChunk(string, string, string, string, string, int, string)`；`NationalSpire.Coop.CoopPrivatePart.CoopPrivatePart(string, NationalSpire.Coop.CoopPart)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `(string Turn, string Text).Text`；`Current()`；`NationalSpire.AiService.PrivateReasoningLive`；`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`；`NationalSpire.AiService.SummarizePrivateManually(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string)`；`NationalSpire.Coop.CoopAssembler.Split(byte[])`；`NationalSpire.Coop.CoopCommand.Kind`；`NationalSpire.Coop.CoopCommand.Target`；`NationalSpire.Coop.CoopCoordinator._closed`；`NationalSpire.Coop.CoopCoordinator._privateSendSequence`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopJson.Bytes<T>(T)`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Id`；`Save(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`；输入表达式：`AiService.ProcessPrivateAsync(Current, Save, command.Target, (turn, text) =>          {              if (!_closed && World?.Epoch == epoch && sender != Self)                  // 只回传这次私信的发起者，沿用正文的收件人隔离，禁止广播给其他队友。                  foreach (var part in CoopAssembler.Split(CoopJson.Bytes(new CoopPrivateChunk(worldId, epoch, command.Target, turn, text, ++_privateSendSequence,                      AiService.PrivateReasoningLive.GetValueOrDefault(worldId + "-" + sender + "/" + command.Target).Text ?? ""))))                      Send(sender, "private-chunk", new CoopPrivatePart(command.Target, part));          })`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.ProcessPrivateAsync(Current, Save, command.Target, (turn, text) =>          {              if (!_closed && World?.Epoch == epoch && sender != Self)                  // 只回传这次私信的发起者，沿用正文的收件人隔离，禁止广播给其他队友。                  foreach (var part in CoopAssembler.Split(CoopJson.Bytes(new CoopPrivateChunk(worldId, epoch, command.Target, turn, text, ++_privateSendSequence,                      AiService.PrivateReasoningLive.GetValueOrDefault(worldId + "-" + sender + "/" + command.Target).Text ?? ""))))                      Send(sender, "private-chunk", new CoopPrivatePart(command.Target, part));          })`
- `NationalSpire.AiService.SummarizePrivateManually(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string)`；输入表达式：`AiService.SummarizePrivateManually(Current, Save, command.Target)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.SummarizePrivateManually(Current, Save, command.Target)`
- `NationalSpire.Coop.CoopAssembler.Split(byte[])`；输入表达式：`CoopAssembler.Split(CoopJson.Bytes(new CoopPrivateChunk(worldId, epoch, command.Target, turn, text, ++_privateSendSequence,                      AiService.PrivateReasoningLive.GetValueOrDefault(worldId + "-" + sender + "/" + command.Target).Text ?? "")))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var part in CoopAssembler.Split(CoopJson.Bytes(new CoopPrivateChunk(worldId, epoch, command.Target, turn, text, ++_privateSendSequence,                      AiService.PrivateReasoningLive.GetValueOrDefault(worldId + "-" + sender + "/" + command.Target).Text ?? ""))))                      Send(sender, "private-chunk", new CoopPrivatePart(command.Target, part));`
- `NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；输入表达式：`Send(sender, "private-chunk", new CoopPrivatePart(command.Target, part))`；返回值紧邻使用处：`ExpressionStatementSyntax: Send(sender, "private-chunk", new CoopPrivatePart(command.Target, part));`
- `NationalSpire.Coop.CoopJson.Bytes<T>(T)`；输入表达式：`CoopJson.Bytes(new CoopPrivateChunk(worldId, epoch, command.Target, turn, text, ++_privateSendSequence,                      AiService.PrivateReasoningLive.GetValueOrDefault(worldId + "-" + sender + "/" + command.Target).Text ?? ""))`；返回值紧邻使用处：`ArgumentSyntax: CoopJson.Bytes(new CoopPrivateChunk(worldId, epoch, command.Target, turn, text, ++_privateSendSequence,                      AiService.PrivateReasoningLive.GetValueOrDefault(worldId + "-" + sender + "/" + command.Target).Text ?? ""))`
- `NationalSpire.Coop.CoopPrivateChunk.CoopPrivateChunk(string, string, string, string, string, int, string)`；输入表达式：`new CoopPrivateChunk(worldId, epoch, command.Target, turn, text, ++_privateSendSequence,                      AiService.PrivateReasoningLive.GetValueOrDefault(worldId + "-" + sender + "/" + command.Target).Text ?? "")`；返回值紧邻使用处：`ArgumentSyntax: new CoopPrivateChunk(worldId, epoch, command.Target, turn, text, ++_privateSendSequence,                      AiService.PrivateReasoningLive.GetValueOrDefault(worldId + "-" + sender + "/" + command.Target).Text ?? "")`
- `NationalSpire.Coop.CoopPrivatePart.CoopPrivatePart(string, NationalSpire.Coop.CoopPart)`；输入表达式：`new CoopPrivatePart(command.Target, part)`；返回值紧邻使用处：`ArgumentSyntax: new CoopPrivatePart(command.Target, part)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`AiService.PrivateReasoningLive.GetValueOrDefault(worldId + "-" + sender + "/" + command.Target)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AiService.PrivateReasoningLive.GetValueOrDefault(worldId + "-" + sender + "/" + command.Target).Text`

**赋值（含属性/字段和局部值）：**

- `_` = `AiService.ProcessPrivateAsync(Current, Save, command.Target, (turn, text) =>          {              if (!_closed && World?.Epoch == epoch && sender != Self)                  // 只回传这次私信的发起者，沿用正文的收件人隔离，禁止广播给其他队友。                  foreach (var part in CoopAssembler.Split(CoopJson.Bytes(new CoopPrivateChunk(worldId, epoch, command.Target, turn, text, ++_privateSendSequence,                      AiService.PrivateReasoningLive.GetValueOrDefault(worldId + "-" + sender + "/" + command.Target).Text ?? ""))))                      Send(sender, "private-chunk", new CoopPrivatePart(command.Target, part));          })`
- `_` = `AiService.SummarizePrivateManually(Current, Save, command.Target)`

<a id="symbol-b02c38cdc4a6"></a>

## `Current() — CareerData? Current()`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`](../AiSettingsStore.cs.md#symbol-b37e55b3af97)；[`NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`](CoopRules.cs.md#symbol-d8e501560a84)；`NationalSpire.AiOptions.AiOptions()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerData.PrivatePromptSnapshot`；`NationalSpire.Coop.CoopCoordinator._closed`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.CoopWorld.Members`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiOptions.AiOptions()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；输入表达式：`AiSettingsStore.Load(new())`；返回值紧邻使用处：`AssignmentExpressionSyntax: data.Ai = AiSettingsStore.Load(new())`
- `NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`；输入表达式：`CoopRules.View(World, member)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopRules.View(World, member)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`data.PrivatePromptSnapshot.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: data.PrivatePromptSnapshot.Clear();`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`World.Members.FirstOrDefault(m => m.SteamId == sender)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = World.Members.FirstOrDefault(m => m.SteamId == sender)`

**赋值（含属性/字段和局部值）：**

- `data.Ai` = `AiSettingsStore.Load(new())`

<a id="symbol-d510c10d173d"></a>

## `Save(NationalSpire.CareerData) — void Save(CareerData data)`

来源：源码第 49 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerTraining.MergePrivateLearning(NationalSpire.CareerData, NationalSpire.PrivateMailbox)`](../CareerTraining.cs.md#symbol-caf4108315c3)；[`NationalSpire.CoachLineups.Merge(NationalSpire.CareerData, NationalSpire.CareerData)`](../CoachLineups.cs.md#symbol-99b1a0a2f49c)；[`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`](CoopCoordinator.cs.md#symbol-e1dfe22e8221)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`](CoopData.cs.md#symbol-85d2410ea3ba)；[`NationalSpire.Coop.CoopRules.RefreshPeople(NationalSpire.Coop.CoopWorld)`](CoopRules.cs.md#symbol-8025e01818d7)；[`NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`](../PrivateAppointments.cs.md#symbol-32f6566791d2)；[`NationalSpire.PrivateProfileChanges.Merge(NationalSpire.CareerData, NationalSpire.PrivateMailbox)`](../PrivateProfileChanges.cs.md#symbol-2bbdc0f01046)；[`NationalSpire.SpireArbitration.Merge(NationalSpire.CareerData, NationalSpire.PrivateMailbox)`](../SpireArbitration.cs.md#symbol-1e9be12b9d1a)；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；`System.Math.Max(long, long)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerLifeState.Mailbox`；`NationalSpire.CareerLifeState.Relationships`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerTraining.MergePrivateLearning(NationalSpire.CareerData, NationalSpire.PrivateMailbox)`；`NationalSpire.ChatWorld.Order`；`NationalSpire.CoachLineups.Merge(NationalSpire.CareerData, NationalSpire.CareerData)`；`NationalSpire.Coop.CoopCommand.Target`；`NationalSpire.Coop.CoopCoordinator._closed`；`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；`NationalSpire.Coop.CoopCoordinator.NativeSave`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`；`NationalSpire.Coop.CoopMember.Life`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopRules.RefreshPeople(NationalSpire.Coop.CoopWorld)`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Revision`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`；`NationalSpire.PrivateProfileChanges.Merge(NationalSpire.CareerData, NationalSpire.PrivateMailbox)`；`NationalSpire.SpireArbitration.Merge(NationalSpire.CareerData, NationalSpire.PrivateMailbox)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerTraining.MergePrivateLearning(NationalSpire.CareerData, NationalSpire.PrivateMailbox)`；输入表达式：`CareerTraining.MergePrivateLearning(copy.World, member.Life.Mailbox)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerTraining.MergePrivateLearning(copy.World, member.Life.Mailbox);`
- `NationalSpire.CoachLineups.Merge(NationalSpire.CareerData, NationalSpire.CareerData)`；输入表达式：`CoachLineups.Merge(copy.World, data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoachLineups.Merge(copy.World, data);`
- `NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；输入表达式：`Commit(copy, NativeSave)`；返回值紧邻使用处：`ExpressionStatementSyntax: Commit(copy, NativeSave);`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(match)`；返回值紧邻使用处：`AssignmentExpressionSyntax: copy.World.Matches[index] = CoopJson.Copy(match)`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(World)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Copy(World)`
- `NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`；输入表达式：`CoopJson.Detached(copy.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopJson.Detached(copy.World);`
- `NationalSpire.Coop.CoopRules.RefreshPeople(NationalSpire.Coop.CoopWorld)`；输入表达式：`CoopRules.RefreshPeople(copy)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopRules.RefreshPeople(copy);`
- `NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`；输入表达式：`PrivateAppointments.IsPrivate(m)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateAppointments.IsPrivate(m) && m.OpponentId == command.Target`
- `NationalSpire.PrivateProfileChanges.Merge(NationalSpire.CareerData, NationalSpire.PrivateMailbox)`；输入表达式：`PrivateProfileChanges.Merge(copy.World, member.Life.Mailbox)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateProfileChanges.Merge(copy.World, member.Life.Mailbox);`
- `NationalSpire.SpireArbitration.Merge(NationalSpire.CareerData, NationalSpire.PrivateMailbox)`；输入表达式：`SpireArbitration.Merge(copy.World, member.Life.Mailbox)`；返回值紧邻使用处：`ExpressionStatementSyntax: SpireArbitration.Merge(copy.World, member.Life.Mailbox);`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`copy.Members.Single(m => m.SteamId == sender)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = copy.Members.Single(m => m.SteamId == sender)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.Where(m => PrivateAppointments.IsPrivate(m) && m.OpponentId == command.Target)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var match in data.Matches.Where(m => PrivateAppointments.IsPrivate(m) && m.OpponentId == command.Target))              {                  int index = copy.World.Matches.FindIndex(m => m.Id == match.Id);                  if (index >= 0) copy.World.Matches[index] = CoopJson.Copy(match);              }`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`copy.World.Matches.FindIndex(m => m.Id == match.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = copy.World.Matches.FindIndex(m => m.Id == match.Id)`
- `System.Math.Max(long, long)`；输入表达式：`Math.Max(copy.World.Chats.Order, data.Chats.Order)`；返回值紧邻使用处：`AssignmentExpressionSyntax: copy.World.Chats.Order = Math.Max(copy.World.Chats.Order, data.Chats.Order)`

**赋值（含属性/字段和局部值）：**

- `copy.World.Chats.Order` = `Math.Max(copy.World.Chats.Order, data.Chats.Order)`
- `copy.World.Matches[index]` = `CoopJson.Copy(match)`
- `member.Life.Mailbox` = `data.Life.Mailbox`
- `member.Life.Relationships` = `data.Life.Relationships`

<a id="symbol-cdaa536242f4"></a>

## `NationalSpire.Coop.CoopCoordinator.PrivateSnapshot(NationalSpire.Coop.CoopWorld, ulong) — public static CoopWorld PrivateSnapshot(CoopWorld source, ulong recipient)`

来源：源码第 77 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopJson.Copy<T>(T)`](CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`](CoopData.cs.md#symbol-85d2410ea3ba)；`NationalSpire.PrivateMailbox.PrivateMailbox()`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Mailbox`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`；`NationalSpire.Coop.CoopMember.Life`；`NationalSpire.Coop.CoopMember.PersonId`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.GroupChat.Members`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(source)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Copy(source)`
- `NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`；输入表达式：`CoopJson.Detached(copy.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopJson.Detached(copy.World);`
- `NationalSpire.PrivateMailbox.PrivateMailbox()`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: copy.World.Life.Mailbox = new()`
- `NationalSpire.PrivateMailbox.PrivateMailbox()`；输入表达式：`new()`；返回值紧邻使用处：`AssignmentExpressionSyntax: member.Life.Mailbox = new()`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`copy.Members.Single(m => m.SteamId == recipient)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: copy.Members.Single(m => m.SteamId == recipient).PersonId`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`copy.Members.Where(m => m.SteamId != recipient)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var member in copy.Members.Where(m => m.SteamId != recipient)) member.Life.Mailbox = new();`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`g.Members.Contains(copy.Members.Single(m => m.SteamId == recipient).PersonId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !g.Members.Contains(copy.Members.Single(m => m.SteamId == recipient).PersonId)`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`copy.World.Chats.Groups.RemoveAll(g => !g.Members.Contains(copy.Members.Single(m => m.SteamId == recipient).PersonId))`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.World.Chats.Groups.RemoveAll(g => !g.Members.Contains(copy.Members.Single(m => m.SteamId == recipient).PersonId));`

**赋值（含属性/字段和局部值）：**

- `copy.World.Life.Mailbox` = `new()`
- `member.Life.Mailbox` = `new()`

<a id="symbol-a91c619526df"></a>

## `NationalSpire.Coop.CoopCoordinator.SnapshotBytes(byte[], ulong, System.Collections.Generic.Dictionary<string, string>) — internal static byte[] SnapshotBytes(byte[] snapshot, ulong recipient, Dictionary<string, string> templates)`

来源：源码第 86 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Encode(ulong, System.Collections.Generic.Dictionary<string, string>)`](CoopPrivateMessages.cs.md#symbol-f433d36af14b)；[`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.SnapshotEncoder(byte[])`](CoopPrivateMessages.cs.md#symbol-ee70e3f1cbb7)

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Encode(ulong, System.Collections.Generic.Dictionary<string, string>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Encode(ulong, System.Collections.Generic.Dictionary<string, string>)`；输入表达式：`new SnapshotEncoder(snapshot).Encode(recipient, templates)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new SnapshotEncoder(snapshot).Encode(recipient, templates)`
- `NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.SnapshotEncoder(byte[])`；输入表达式：`new SnapshotEncoder(snapshot)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new SnapshotEncoder(snapshot).Encode`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ee70e3f1cbb7"></a>

## `NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.SnapshotEncoder(byte[]) — internal SnapshotEncoder(byte[] source)`

来源：源码第 102 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.Broadcast()`](CoopCoordinator.cs.md#symbol-8a047804722d)；[`NationalSpire.Coop.CoopCoordinator.SnapshotBytes(byte[], ulong, System.Collections.Generic.Dictionary<string, string>)`](CoopPrivateMessages.cs.md#symbol-a91c619526df)

**调用：** [`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Read(ref System.Text.Json.Utf8JsonReader, string)`](CoopPrivateMessages.cs.md#symbol-9520339625bf)；`System.Text.Json.Utf8JsonReader.Read()`；`System.Text.Json.Utf8JsonReader.Utf8JsonReader(System.ReadOnlySpan<byte>, System.Text.Json.JsonReaderOptions)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.SnapshotEncoder._root`；`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder._source`；`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Read(ref System.Text.Json.Utf8JsonReader, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Read(ref System.Text.Json.Utf8JsonReader, string)`；输入表达式：`Read(ref reader, "snapshot")`；返回值紧邻使用处：`AssignmentExpressionSyntax: _root = Read(ref reader, "snapshot")`
- `System.Text.Json.Utf8JsonReader.Read()`；输入表达式：`reader.Read()`；返回值紧邻使用处：`ExpressionStatementSyntax: reader.Read();`
- `System.Text.Json.Utf8JsonReader.Utf8JsonReader(System.ReadOnlySpan<byte>, System.Text.Json.JsonReaderOptions)`；输入表达式：`new Utf8JsonReader(source)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Utf8JsonReader(source)`

**赋值（含属性/字段和局部值）：**

- `_root` = `Read(ref reader, "snapshot")`
- `_source` = `source`

<a id="symbol-9520339625bf"></a>

## `NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Read(ref System.Text.Json.Utf8JsonReader, string) — private Value Read(ref Utf8JsonReader reader, string path)`

来源：源码第 106 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Read(ref System.Text.Json.Utf8JsonReader, string)`](CoopPrivateMessages.cs.md#symbol-9520339625bf)；[`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.SnapshotEncoder(byte[])`](CoopPrivateMessages.cs.md#symbol-ee70e3f1cbb7)

**调用：** [`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Read(ref System.Text.Json.Utf8JsonReader, string)`](CoopPrivateMessages.cs.md#symbol-9520339625bf)；`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value.Value()`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Text.Json.Utf8JsonReader.GetString()`；`System.Text.Json.Utf8JsonReader.GetUInt64()`；`System.Text.Json.Utf8JsonReader.Read()`；`System.Text.Json.Utf8JsonReader.Skip()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Read(ref System.Text.Json.Utf8JsonReader, string)`；`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value.Children`；`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value.Length`；`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value.Member`；`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value.Members`；`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value.Name`；`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value.Path`；`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value.Start`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Read(ref System.Text.Json.Utf8JsonReader, string)`；输入表达式：`Read(ref reader, nested)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Read(ref reader, nested)`
- `NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Read(ref System.Text.Json.Utf8JsonReader, string)`；输入表达式：`Read(ref reader, path == "members" ? "member" : "group")`；返回值紧邻使用处：`ArgumentSyntax: Read(ref reader, path == "members" ? "member" : "group")`
- `NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value.Value()`；输入表达式：`new Value { Path = path, Start = checked((int)reader.TokenStartIndex) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Value { Path = path, Start = checked((int)reader.TokenStartIndex) }`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`value.Members.Add(scan.GetString()!)`；返回值紧邻使用处：`ExpressionStatementSyntax: value.Members.Add(scan.GetString()!);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`value.Children.Add(child)`；返回值紧邻使用处：`ExpressionStatementSyntax: value.Children.Add(child);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`value.Children.Add(Read(ref reader, path == "members" ? "member" : "group"))`；返回值紧邻使用处：`ExpressionStatementSyntax: value.Children.Add(Read(ref reader, path == "members" ? "member" : "group"));`
- `System.Text.Json.Utf8JsonReader.GetString()`；输入表达式：`reader.GetString()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: reader.GetString()!`
- `System.Text.Json.Utf8JsonReader.GetString()`；输入表达式：`scan.GetString()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: scan.GetString()!`
- `System.Text.Json.Utf8JsonReader.GetUInt64()`；输入表达式：`reader.GetUInt64()`；返回值紧邻使用处：`AssignmentExpressionSyntax: value.Member = reader.GetUInt64()`
- `System.Text.Json.Utf8JsonReader.Read()`；输入表达式：`reader.Read()`；返回值紧邻使用处：`BinaryExpressionSyntax: reader.Read() && reader.TokenType != JsonTokenType.EndArray`
- `System.Text.Json.Utf8JsonReader.Read()`；输入表达式：`reader.Read()`；返回值紧邻使用处：`BinaryExpressionSyntax: reader.Read() && reader.TokenType != JsonTokenType.EndObject`
- `System.Text.Json.Utf8JsonReader.Read()`；输入表达式：`reader.Read()`；返回值紧邻使用处：`ExpressionStatementSyntax: reader.Read();`
- `System.Text.Json.Utf8JsonReader.Read()`；输入表达式：`scan.Read()`；返回值紧邻使用处：`BinaryExpressionSyntax: scan.Read() && scan.TokenType != JsonTokenType.EndArray`
- `System.Text.Json.Utf8JsonReader.Read()`；输入表达式：`scan.Read()`；返回值紧邻使用处：`BinaryExpressionSyntax: scan.Read() && scan.TokenType != JsonTokenType.EndObject`
- `System.Text.Json.Utf8JsonReader.Read()`；输入表达式：`scan.Read()`；返回值紧邻使用处：`ExpressionStatementSyntax: scan.Read();`
- `System.Text.Json.Utf8JsonReader.Skip()`；输入表达式：`reader.Skip()`；返回值紧邻使用处：`ExpressionStatementSyntax: reader.Skip();`
- `System.Text.Json.Utf8JsonReader.Skip()`；输入表达式：`scan.Skip()`；返回值紧邻使用处：`ExpressionStatementSyntax: scan.Skip();`

**赋值（含属性/字段和局部值）：**

- `child.Name` = `name`
- `Path` = `path`
- `Start` = `checked((int)reader.TokenStartIndex)`
- `value.Children` = `[]`
- `value.Length` = `checked((int)reader.BytesConsumed) - value.Start`
- `value.Member` = `reader.GetUInt64()`
- `value.Members` = `[]`

<a id="symbol-f433d36af14b"></a>

## `NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Encode(ulong, System.Collections.Generic.Dictionary<string, string>) — internal byte[] Encode(ulong recipient, Dictionary<string, string> templates)`

来源：源码第 145 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.Broadcast()`](CoopCoordinator.cs.md#symbol-8a047804722d)；[`NationalSpire.Coop.CoopCoordinator.SnapshotBytes(byte[], ulong, System.Collections.Generic.Dictionary<string, string>)`](CoopPrivateMessages.cs.md#symbol-a91c619526df)

**调用：** [`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Write(NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value, System.Text.Json.Utf8JsonWriter, ulong, byte[])`](CoopPrivateMessages.cs.md#symbol-fa9ee6fab973)；[`NationalSpire.Coop.CoopJson.Bytes<T>(T)`](CoopData.cs.md#symbol-faeb54cab7ee)；[`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`](../UiPerformance.cs.md#symbol-fb8ca8555fbe)；`System.IO.MemoryStream.MemoryStream()`；`System.IO.MemoryStream.ToArray()`；`System.Text.Json.JsonWriterOptions.JsonWriterOptions()`；`System.Text.Json.Utf8JsonWriter.Utf8JsonWriter(System.IO.Stream, System.Text.Json.JsonWriterOptions)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.SnapshotEncoder._root`；`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Write(NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value, System.Text.Json.Utf8JsonWriter, ulong, byte[])`；`NationalSpire.Coop.CoopJson.Bytes<T>(T)`；`NationalSpire.Coop.CoopJson.Options`；`NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；`NationalSpire.UiPerformance.Work.CoopEncode`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Write(NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value, System.Text.Json.Utf8JsonWriter, ulong, byte[])`；输入表达式：`Write(_root, writer, recipient, CoopJson.Bytes(templates))`；返回值紧邻使用处：`ExpressionStatementSyntax: Write(_root, writer, recipient, CoopJson.Bytes(templates));`
- `NationalSpire.Coop.CoopJson.Bytes<T>(T)`；输入表达式：`CoopJson.Bytes(templates)`；返回值紧邻使用处：`ArgumentSyntax: CoopJson.Bytes(templates)`
- `NationalSpire.UiPerformance.Measure(NationalSpire.UiPerformance.Work, string?)`；输入表达式：`UiPerformance.Measure(UiPerformance.Work.CoopEncode)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = UiPerformance.Measure(UiPerformance.Work.CoopEncode)`
- `System.IO.MemoryStream.MemoryStream()`；输入表达式：`new MemoryStream()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new MemoryStream()`
- `System.IO.MemoryStream.ToArray()`；输入表达式：`buffer.ToArray()`；返回值紧邻使用处：`ReturnStatementSyntax: return buffer.ToArray();`
- `System.Text.Json.JsonWriterOptions.JsonWriterOptions()`；输入表达式：`new() { Encoder = CoopJson.Options.Encoder }`；返回值紧邻使用处：`ArgumentSyntax: new() { Encoder = CoopJson.Options.Encoder }`
- `System.Text.Json.Utf8JsonWriter.Utf8JsonWriter(System.IO.Stream, System.Text.Json.JsonWriterOptions)`；输入表达式：`new Utf8JsonWriter(buffer, new() { Encoder = CoopJson.Options.Encoder })`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Utf8JsonWriter(buffer, new() { Encoder = CoopJson.Options.Encoder })`

**赋值（含属性/字段和局部值）：**

- `Encoder` = `CoopJson.Options.Encoder`

<a id="symbol-bd7144bd84e1"></a>

## `NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Raw(NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value, System.Text.Json.Utf8JsonWriter) — private void Raw(Value value, Utf8JsonWriter writer)`

来源：源码第 152 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Write(NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value, System.Text.Json.Utf8JsonWriter, ulong, byte[])`](CoopPrivateMessages.cs.md#symbol-fa9ee6fab973)

**调用：** `System.Text.Json.Utf8JsonWriter.WriteRawValue(System.ReadOnlySpan<byte>, bool)`；`T[]?.AsSpan<T>(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.SnapshotEncoder._source`；`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value.Length`；`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value.Start`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Text.Json.Utf8JsonWriter.WriteRawValue(System.ReadOnlySpan<byte>, bool)`；输入表达式：`writer.WriteRawValue(_source.AsSpan(value.Start, value.Length), skipInputValidation: true)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => writer.WriteRawValue(_source.AsSpan(value.Start, value.Length), skipInputValidation: true)`
- `T[]?.AsSpan<T>(int, int)`；输入表达式：`_source.AsSpan(value.Start, value.Length)`；返回值紧邻使用处：`ArgumentSyntax: _source.AsSpan(value.Start, value.Length)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fa9ee6fab973"></a>

## `NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Write(NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value, System.Text.Json.Utf8JsonWriter, ulong, byte[]) — private void Write(Value value, Utf8JsonWriter writer, ulong recipient, byte[] templates)`

来源：源码第 153 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Encode(ulong, System.Collections.Generic.Dictionary<string, string>)`](CoopPrivateMessages.cs.md#symbol-f433d36af14b)；[`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Write(NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value, System.Text.Json.Utf8JsonWriter, ulong, byte[])`](CoopPrivateMessages.cs.md#symbol-fa9ee6fab973)

**调用：** [`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Raw(NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value, System.Text.Json.Utf8JsonWriter)`](CoopPrivateMessages.cs.md#symbol-bd7144bd84e1)；[`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Write(NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value, System.Text.Json.Utf8JsonWriter, ulong, byte[])`](CoopPrivateMessages.cs.md#symbol-fa9ee6fab973)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Text.Json.Utf8JsonWriter.WriteEndArray()`；`System.Text.Json.Utf8JsonWriter.WriteEndObject()`；`System.Text.Json.Utf8JsonWriter.WritePropertyName(string)`；`System.Text.Json.Utf8JsonWriter.WriteRawValue(System.ReadOnlySpan<byte>, bool)`；`System.Text.Json.Utf8JsonWriter.WriteStartArray()`；`System.Text.Json.Utf8JsonWriter.WriteStartObject()`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator.SnapshotEncoder._mailbox`；`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Raw(NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value, System.Text.Json.Utf8JsonWriter)`；`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value.Children`；`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value.Member`；`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value.Members`；`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value.Name`；`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value.Path`；`NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Write(NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value, System.Text.Json.Utf8JsonWriter, ulong, byte[])`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Raw(NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value, System.Text.Json.Utf8JsonWriter)`；输入表达式：`Raw(child, writer)`；返回值紧邻使用处：`ExpressionStatementSyntax: Raw(child, writer);`
- `NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Write(NationalSpire.Coop.CoopCoordinator.SnapshotEncoder.Value, System.Text.Json.Utf8JsonWriter, ulong, byte[])`；输入表达式：`Write(child, writer, recipient, templates)`；返回值紧邻使用处：`ExpressionStatementSyntax: Write(child, writer, recipient, templates);`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`child.Members!.Contains("human-" + recipient)`；返回值紧邻使用处：`IfStatementSyntax: if (child.Members!.Contains("human-" + recipient)) Raw(child, writer);`
- `System.Text.Json.Utf8JsonWriter.WriteEndArray()`；输入表达式：`writer.WriteEndArray()`；返回值紧邻使用处：`ExpressionStatementSyntax: writer.WriteEndArray();`
- `System.Text.Json.Utf8JsonWriter.WriteEndObject()`；输入表达式：`writer.WriteEndObject()`；返回值紧邻使用处：`ExpressionStatementSyntax: writer.WriteEndObject();`
- `System.Text.Json.Utf8JsonWriter.WritePropertyName(string)`；输入表达式：`writer.WritePropertyName(child.Name)`；返回值紧邻使用处：`ExpressionStatementSyntax: writer.WritePropertyName(child.Name);`
- `System.Text.Json.Utf8JsonWriter.WriteRawValue(System.ReadOnlySpan<byte>, bool)`；输入表达式：`writer.WriteRawValue(_mailbox, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: writer.WriteRawValue(_mailbox, true);`
- `System.Text.Json.Utf8JsonWriter.WriteRawValue(System.ReadOnlySpan<byte>, bool)`；输入表达式：`writer.WriteRawValue(templates, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: writer.WriteRawValue(templates, true);`
- `System.Text.Json.Utf8JsonWriter.WriteStartArray()`；输入表达式：`writer.WriteStartArray()`；返回值紧邻使用处：`ExpressionStatementSyntax: writer.WriteStartArray();`
- `System.Text.Json.Utf8JsonWriter.WriteStartObject()`；输入表达式：`writer.WriteStartObject()`；返回值紧邻使用处：`ExpressionStatementSyntax: writer.WriteStartObject();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3dd770b5bab3"></a>

## `NationalSpire.Coop.CoopRules.SavePrivateFailure(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, string) — private static CoopWorld SavePrivateFailure(CoopWorld original, ulong sender, CoopCommand command, string error)`

来源：源码第 180 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** [`NationalSpire.Coop.CoopJson.Copy<T>(T)`](CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`](CoopData.cs.md#symbol-85d2410ea3ba)；[`NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`](CoopRules.cs.md#symbol-d8e501560a84)；[`NationalSpire.PrivateMessageCommands.RecordFailure(NationalSpire.CareerData, string, NationalSpire.PrivateMessageCommand, string)`](../PrivateMessageCommands.cs.md#symbol-b4c1683dbba9)；`NationalSpire.GroupCommand.GroupCommand()`；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Mailbox`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.Coop.CoopCommand.Kind`；`NationalSpire.Coop.CoopCommand.Target`；`NationalSpire.Coop.CoopCommand.Text`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`；`NationalSpire.Coop.CoopJson.Options`；`NationalSpire.Coop.CoopMember.Life`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Revision`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Interactions`；`NationalSpire.GroupChat.Revision`；`NationalSpire.GroupCommand.Interaction`；`NationalSpire.GroupCommand.Lane`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateMessageCommand.Offer`；`NationalSpire.PrivateMessageCommands.RecordFailure(NationalSpire.CareerData, string, NationalSpire.PrivateMessageCommand, string)`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.State`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(original)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Copy(original)`
- `NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`；输入表达式：`CoopJson.Detached(copy.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopJson.Detached(copy.World);`
- `NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`；输入表达式：`CoopJson.Detached(groupCopy.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopJson.Detached(groupCopy.World);`
- `NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`；输入表达式：`View(copy, member)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = View(copy, member)`
- `NationalSpire.GroupCommand.GroupCommand()`；输入表达式：`new()`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<GroupCommand>(command.Text) ?? new()`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new()`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<PrivateMessageCommand>(command.Text, CoopJson.Options) ?? new()`
- `NationalSpire.PrivateMessageCommands.RecordFailure(NationalSpire.CareerData, string, NationalSpire.PrivateMessageCommand, string)`；输入表达式：`PrivateMessageCommands.RecordFailure(view, command.Target, payload, error)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateMessageCommands.RecordFailure(view, command.Target, payload, error)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Offers.FirstOrDefault(o => o.Id == groupPayload.Interaction.Offer)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .Interactions.GetValueOrDefault(groupPayload.Lane)?.Offers.FirstOrDefault(o => o.Id == groupPayload.Interaction.Offer)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`groupCopy.World.Chats.Groups.FirstOrDefault(g => g.Id == command.Target)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = groupCopy.World.Chats.Groups.FirstOrDefault(g => g.Id == command.Target)`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`copy.Members.Single(m => m.SteamId == sender)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = copy.Members.Single(m => m.SteamId == sender)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.Interactions.GetValueOrDefault(groupPayload.Lane)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .Interactions.GetValueOrDefault(groupPayload.Lane)?.Offers.FirstOrDefault(o => o.Id == groupPayload.Interaction.Offer)`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<GroupCommand>(command.Text)`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<GroupCommand>(command.Text) ?? new()`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<PrivateMessageCommand>(command.Text, CoopJson.Options)`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<PrivateMessageCommand>(command.Text, CoopJson.Options) ?? new()`

**赋值（含属性/字段和局部值）：**

- `member.Life.Mailbox` = `view.Life.Mailbox`
- `offer.Detail` = `error`

<a id="symbol-d33f4b1ffce8"></a>

## `NationalSpire.Coop.CoopRules.PrivateCommand(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.Coop.CoopCommand) — private static string? PrivateCommand(CoopWorld w, CoopMember member, CoopCommand command)`

来源：源码第 201 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](../CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.Coop.CoopRules.Capture(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.CareerData)`](CoopRules.cs.md#symbol-99be42ec0491)；[`NationalSpire.Coop.CoopRules.ConfirmPrivateMatch(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopProposal)`](CoopPrivateMessages.cs.md#symbol-ec0e4056cf90)；[`NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`](CoopRules.cs.md#symbol-d8e501560a84)；[`NationalSpire.PrivateAppointments.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](../PrivateAppointments.cs.md#symbol-e7f8b7355ddf)；[`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](../PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](../PrivateMessages.cs.md#symbol-3712b7336055)；`NationalSpire.Coop.CoopProposal.CoopProposal()`；`NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；`string.StartsWith(string)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.Coop.CoopCommand.Kind`；`NationalSpire.Coop.CoopCommand.Target`；`NationalSpire.Coop.CoopCommand.Text`；`NationalSpire.Coop.CoopJson.Options`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopProposal.Kind`；`NationalSpire.Coop.CoopProposal.Label`；`NationalSpire.Coop.CoopProposal.Number`；`NationalSpire.Coop.CoopProposal.Target`；`NationalSpire.Coop.CoopProposal.Votes`；`NationalSpire.Coop.CoopRules.Capture(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.CareerData)`；`NationalSpire.Coop.CoopRules.ConfirmPrivateMatch(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopProposal)`；`NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`；`NationalSpire.Coop.CoopWorld.Owner`；`NationalSpire.Coop.CoopWorld.Proposal`；`NationalSpire.Coop.CoopWorld.Run`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.PrivateAppointments.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateMessageCommand.Offer`；`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Ascension`；`NationalSpire.PrivateOffer.Day`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.MatchId`；`NationalSpire.PrivateOffer.Mode`；`NationalSpire.PrivateOffer.Season`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(w.World, command.Target)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.DisplayName(w.World, command.Target)}`
- `NationalSpire.Coop.CoopProposal.CoopProposal()`；输入表达式：`new CoopProposal { Kind = "dm-match", Target = member.SteamId + "/" + command.Target + "/" + offer.Id,                      Number = command.Kind == "dm-confirm" ? 1 : 0, Votes = [member.SteamId],                      Label = (command.Kind == "dm-confirm" ? "安排" : "取消") + $"与{CareerEngine.DisplayName(w.World, command.Target)}的{offer.Mode} · 第{offer.Season}赛季第{offer.Day}天 · 进阶{offer.Ascension}" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CoopProposal { Kind = "dm-match", Target = member.SteamId + "/" + command.Target + "/" + offer.Id,                      Number = command.Kind == "dm-confirm" ? 1 : 0, Votes = [member.SteamId],                      Label = (command.Kind == "dm-confirm" ? "安排" : "取消") + $"与{CareerEngine.DisplayName(w.World, command.Target)}的{offer.Mode} · 第{offer.Season}赛季第{offer.Day}天 · 进阶{offer.Ascension}" }`
- `NationalSpire.Coop.CoopRules.Capture(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.CareerData)`；输入表达式：`Capture(w, member, view)`；返回值紧邻使用处：`ExpressionStatementSyntax: Capture(w, member, view);`
- `NationalSpire.Coop.CoopRules.ConfirmPrivateMatch(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopProposal)`；输入表达式：`ConfirmPrivateMatch(w, arrangement)`；返回值紧邻使用处：`ReturnStatementSyntax: return ConfirmPrivateMatch(w, arrangement);`
- `NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`；输入表达式：`View(w, member)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = View(w, member)`
- `NationalSpire.PrivateAppointments.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Error(w.World, command.Target, offer)`；返回值紧邻使用处：`IsPatternExpressionSyntax: PrivateAppointments.Error(w.World, command.Target, offer) is { } error`
- `NationalSpire.PrivateMessageCommand.PrivateMessageCommand()`；输入表达式：`new()`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<PrivateMessageCommand>(command.Text, CoopJson.Options) ?? new()`
- `NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`；输入表达式：`PrivateMessageCommands.Apply(view, command.Kind, command.Target, payload)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessageCommands.Apply(view, command.Kind, command.Target, payload)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(view, command.Target)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(view, command.Target).Offers`
- `string.StartsWith(string)`；输入表达式：`pending.Target.StartsWith(prefix)`；返回值紧邻使用处：`BinaryExpressionSyntax: pending.Target.StartsWith(prefix) && !PrivateMessages.Conversation(view, command.Target).Offers.Any(o => o.Id == pending.Target[prefix.Length..])`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Conversation(view, command.Target).Offers.Any(o => o.Id == pending.Target[prefix.Length..])`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateMessages.Conversation(view, command.Target).Offers.Any(o => o.Id == pending.Target[prefix.Length..])`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Conversation(view, command.Target).Offers.FirstOrDefault(o => o.Id == payload.Offer)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(view, command.Target).Offers.FirstOrDefault(o => o.Id == payload.Offer)`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<PrivateMessageCommand>(command.Text, CoopJson.Options)`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<PrivateMessageCommand>(command.Text, CoopJson.Options) ?? new()`

**赋值（含属性/字段和局部值）：**

- `Kind` = `"dm-match"`
- `Label` = `(command.Kind == "dm-confirm" ? "安排" : "取消") + $"与{CareerEngine.DisplayName(w.World, command.Target)}的{offer.Mode} · 第{offer.Season}赛季第{offer.Day}天 · 进阶{offer.Ascension}"`
- `Number` = `command.Kind == "dm-confirm" ? 1 : 0`
- `Target` = `member.SteamId + "/" + command.Target + "/" + offer.Id`
- `Votes` = `[member.SteamId]`
- `w.Proposal` = `null`
- `w.World.Esports.Competitions` = `view.Esports.Competitions`
- `w.World.Matches` = `view.Matches`

<a id="symbol-ec0e4056cf90"></a>

## `NationalSpire.Coop.CoopRules.ConfirmPrivateMatch(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopProposal) — private static string? ConfirmPrivateMatch(CoopWorld w, CoopProposal proposal)`

来源：源码第 235 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.ExecuteProposal(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopProposal, System.Collections.Generic.IReadOnlySet<string>)`](CoopRules.cs.md#symbol-fecbe30f550e)；[`NationalSpire.Coop.CoopRules.PrivateCommand(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.Coop.CoopCommand)`](CoopPrivateMessages.cs.md#symbol-d33f4b1ffce8)

**调用：** [`NationalSpire.Coop.CoopRules.Capture(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.CareerData)`](CoopRules.cs.md#symbol-99be42ec0491)；[`NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`](CoopRules.cs.md#symbol-d8e501560a84)；[`NationalSpire.PrivateAppointments.Cancel(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](../PrivateAppointments.cs.md#symbol-02dfe1ba8dd5)；[`NationalSpire.PrivateAppointments.Confirm(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](../PrivateAppointments.cs.md#symbol-3089895d205a)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](../PrivateMessages.cs.md#symbol-3712b7336055)；`string.Split(char, System.StringSplitOptions)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`ulong.TryParse(string?, out ulong)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Matches`；`NationalSpire.CareerLifeState.Mailbox`；`NationalSpire.Coop.CoopMember.Life`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopProposal.Number`；`NationalSpire.Coop.CoopProposal.Target`；`NationalSpire.Coop.CoopRules.Capture(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.CareerData)`；`NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.PrivateAppointments.Cancel(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateAppointments.Confirm(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopRules.Capture(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.CareerData)`；输入表达式：`Capture(w, member!, view)`；返回值紧邻使用处：`ExpressionStatementSyntax: Capture(w, member!, view);`
- `NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`；输入表达式：`View(w, member!)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = View(w, member!)`
- `NationalSpire.PrivateAppointments.Cancel(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Cancel(view, local)`；返回值紧邻使用处：`ConditionalExpressionSyntax: proposal.Number == 1 ? PrivateAppointments.Confirm(view, ids[1], local) : PrivateAppointments.Cancel(view, local)`
- `NationalSpire.PrivateAppointments.Confirm(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Confirm(view, ids[1], local)`；返回值紧邻使用处：`ConditionalExpressionSyntax: proposal.Number == 1 ? PrivateAppointments.Confirm(view, ids[1], local) : PrivateAppointments.Cancel(view, local)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(view, ids[1])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(view, ids[1]).Offers`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`proposal.Target.Split('/')`；返回值紧邻使用处：`EqualsValueClauseSyntax: = proposal.Target.Split('/')`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Offers.FirstOrDefault(o => o.Id == ids[2])`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: c?.Offers.FirstOrDefault(o => o.Id == ids[2])`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`w.Members.FirstOrDefault(m => m.SteamId == sender)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = w.Members.FirstOrDefault(m => m.SteamId == sender)`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Conversation(view, ids[1]).Offers.Single(o => o.Id == ids[2])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(view, ids[1]).Offers.Single(o => o.Id == ids[2])`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.Life.Mailbox.Conversations.GetValueOrDefault(ids[1])`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: member?.Life.Mailbox.Conversations.GetValueOrDefault(ids[1])`
- `ulong.TryParse(string?, out ulong)`；输入表达式：`ulong.TryParse(ids[0], out ulong sender)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ulong.TryParse(ids[0], out ulong sender)`

**赋值（含属性/字段和局部值）：**

- `w.World.Matches` = `view.Matches`
