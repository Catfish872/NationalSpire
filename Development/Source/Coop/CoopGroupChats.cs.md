# Coop/CoopGroupChats.cs

[返回文件依赖索引](../../SOURCE_MAP.md)

源码 SHA-256：`FE7BD5A1C39FD7E2F0B6B01C94FB2B0897F728AAD4B2ACE9542DA069904401B8`。来源：[源码](../../../Coop/CoopGroupChats.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Coop.CoopCoordinator`、`NationalSpire.Coop.CoopRules`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-83d332761336"></a>

## `NationalSpire.Coop.CoopCoordinator.StartGroup(ulong, NationalSpire.Coop.CoopCommand) — private void StartGroup(ulong sender, CoopCommand command)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.Execute(ulong, NationalSpire.Coop.CoopCommand)`](CoopCoordinator.cs.md#symbol-ec0c662c6de0)

**调用：** [`NationalSpire.AiService.ProcessGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string>?)`](../AiGroupChats.cs.md#symbol-caddadc35a6b)；[`NationalSpire.AiService.SummarizeGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, string)`](../AiGroupChats.cs.md#symbol-1e6e737dbe88)；[`NationalSpire.Coop.CoopAssembler.Split(byte[])`](CoopWire.cs.md#symbol-67ad26af4646)；[`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`](CoopCoordinator.cs.md#symbol-0145ddb8062f)；[`NationalSpire.Coop.CoopJson.Bytes<T>(T)`](CoopData.cs.md#symbol-faeb54cab7ee)；`NationalSpire.Coop.CoopPrivateChunk.CoopPrivateChunk(string, string, string, string, string, int, string)`；`NationalSpire.Coop.CoopPrivatePart.CoopPrivatePart(string, NationalSpire.Coop.CoopPart)`；`NationalSpire.GroupCommand.GroupCommand()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `(string Turn, string Text).Text`；`Current()`；`NationalSpire.AiService.GroupReasoningLive`；`NationalSpire.AiService.ProcessGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string>?)`；`NationalSpire.AiService.SummarizeGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, string)`；`NationalSpire.CareerData.Chats`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.Coop.CoopAssembler.Split(byte[])`；`NationalSpire.Coop.CoopCommand.Kind`；`NationalSpire.Coop.CoopCommand.Target`；`NationalSpire.Coop.CoopCommand.Text`；`NationalSpire.Coop.CoopCoordinator._privateSendSequence`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.Self`；`NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopJson.Bytes<T>(T)`；`NationalSpire.Coop.CoopMember.PersonId`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupChat.Turns`；`NationalSpire.GroupCommand.Text`；`NationalSpire.GroupTurn.Id`；`Save(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.ProcessGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string>?)`；输入表达式：`AiService.ProcessGroupAsync(Current, Save, command.Target, text =>          {              if (World?.Id != world || World.Epoch != epoch) return;              var g = World.World.Chats.Groups.FirstOrDefault(g => g.Id == command.Target); if (g == null) return;              var turn = g.Turns.LastOrDefault(); if (turn == null) return;              foreach (var member in World.Members.Where(m => m.SteamId != Self && g.Members.Contains(m.PersonId)))                  foreach (var part in CoopAssembler.Split(CoopJson.Bytes(new CoopPrivateChunk(world, epoch, "group:" + g.Id, turn.Id, text, ++_privateSendSequence, AiService.GroupReasoningLive.GetValueOrDefault(world + "/group/" + g.Id).Text ?? ""))))                      Send(member.SteamId, "private-chunk", new CoopPrivatePart("group:" + g.Id, part));          })`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.ProcessGroupAsync(Current, Save, command.Target, text =>          {              if (World?.Id != world || World.Epoch != epoch) return;              var g = World.World.Chats.Groups.FirstOrDefault(g => g.Id == command.Target); if (g == null) return;              var turn = g.Turns.LastOrDefault(); if (turn == null) return;              foreach (var member in World.Members.Where(m => m.SteamId != Self && g.Members.Contains(m.PersonId)))                  foreach (var part in CoopAssembler.Split(CoopJson.Bytes(new CoopPrivateChunk(world, epoch, "group:" + g.Id, turn.Id, text, ++_privateSendSequence, AiService.GroupReasoningLive.GetValueOrDefault(world + "/group/" + g.Id).Text ?? ""))))                      Send(member.SteamId, "private-chunk", new CoopPrivatePart("group:" + g.Id, part));          })`
- `NationalSpire.AiService.SummarizeGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, string)`；输入表达式：`AiService.SummarizeGroupAsync(Current, Save, command.Target, payload.Text)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = AiService.SummarizeGroupAsync(Current, Save, command.Target, payload.Text)`
- `NationalSpire.Coop.CoopAssembler.Split(byte[])`；输入表达式：`CoopAssembler.Split(CoopJson.Bytes(new CoopPrivateChunk(world, epoch, "group:" + g.Id, turn.Id, text, ++_privateSendSequence, AiService.GroupReasoningLive.GetValueOrDefault(world + "/group/" + g.Id).Text ?? "")))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var part in CoopAssembler.Split(CoopJson.Bytes(new CoopPrivateChunk(world, epoch, "group:" + g.Id, turn.Id, text, ++_privateSendSequence, AiService.GroupReasoningLive.GetValueOrDefault(world + "/group/" + g.Id).Text ?? ""))))                      Send(member.SteamId, "private-chunk", new CoopPrivatePart("group:" + g.Id, part));`
- `NationalSpire.Coop.CoopCoordinator.Send<T>(ulong, string, T)`；输入表达式：`Send(member.SteamId, "private-chunk", new CoopPrivatePart("group:" + g.Id, part))`；返回值紧邻使用处：`ExpressionStatementSyntax: Send(member.SteamId, "private-chunk", new CoopPrivatePart("group:" + g.Id, part));`
- `NationalSpire.Coop.CoopJson.Bytes<T>(T)`；输入表达式：`CoopJson.Bytes(new CoopPrivateChunk(world, epoch, "group:" + g.Id, turn.Id, text, ++_privateSendSequence, AiService.GroupReasoningLive.GetValueOrDefault(world + "/group/" + g.Id).Text ?? ""))`；返回值紧邻使用处：`ArgumentSyntax: CoopJson.Bytes(new CoopPrivateChunk(world, epoch, "group:" + g.Id, turn.Id, text, ++_privateSendSequence, AiService.GroupReasoningLive.GetValueOrDefault(world + "/group/" + g.Id).Text ?? ""))`
- `NationalSpire.Coop.CoopPrivateChunk.CoopPrivateChunk(string, string, string, string, string, int, string)`；输入表达式：`new CoopPrivateChunk(world, epoch, "group:" + g.Id, turn.Id, text, ++_privateSendSequence, AiService.GroupReasoningLive.GetValueOrDefault(world + "/group/" + g.Id).Text ?? "")`；返回值紧邻使用处：`ArgumentSyntax: new CoopPrivateChunk(world, epoch, "group:" + g.Id, turn.Id, text, ++_privateSendSequence, AiService.GroupReasoningLive.GetValueOrDefault(world + "/group/" + g.Id).Text ?? "")`
- `NationalSpire.Coop.CoopPrivatePart.CoopPrivatePart(string, NationalSpire.Coop.CoopPart)`；输入表达式：`new CoopPrivatePart("group:" + g.Id, part)`；返回值紧邻使用处：`ArgumentSyntax: new CoopPrivatePart("group:" + g.Id, part)`
- `NationalSpire.GroupCommand.GroupCommand()`；输入表达式：`new()`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<GroupCommand>(command.Text) ?? new()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`World.World.Chats.Groups.FirstOrDefault(g => g.Id == command.Target)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = World.World.Chats.Groups.FirstOrDefault(g => g.Id == command.Target)`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`g.Turns.LastOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = g.Turns.LastOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`World.Members.Where(m => m.SteamId != Self && g.Members.Contains(m.PersonId))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var member in World.Members.Where(m => m.SteamId != Self && g.Members.Contains(m.PersonId)))                  foreach (var part in CoopAssembler.Split(CoopJson.Bytes(new CoopPrivateChunk(world, epoch, "group:" + g.Id, turn.Id, text, ++_privateSendSequence, AiService.GroupReasoningLive.GetValueOrDefault(world + "/group/" + g.Id).Text ?? ""))))                      Send(member.SteamId, "private-chunk", new CoopPrivatePart("group:" + g.Id, part));`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`AiService.GroupReasoningLive.GetValueOrDefault(world + "/group/" + g.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AiService.GroupReasoningLive.GetValueOrDefault(world + "/group/" + g.Id).Text`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`g.Members.Contains(m.PersonId)`；返回值紧邻使用处：`BinaryExpressionSyntax: m.SteamId != Self && g.Members.Contains(m.PersonId)`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<GroupCommand>(command.Text)`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<GroupCommand>(command.Text) ?? new()`

**赋值（含属性/字段和局部值）：**

- `_` = `AiService.ProcessGroupAsync(Current, Save, command.Target, text =>          {              if (World?.Id != world || World.Epoch != epoch) return;              var g = World.World.Chats.Groups.FirstOrDefault(g => g.Id == command.Target); if (g == null) return;              var turn = g.Turns.LastOrDefault(); if (turn == null) return;              foreach (var member in World.Members.Where(m => m.SteamId != Self && g.Members.Contains(m.PersonId)))                  foreach (var part in CoopAssembler.Split(CoopJson.Bytes(new CoopPrivateChunk(world, epoch, "group:" + g.Id, turn.Id, text, ++_privateSendSequence, AiService.GroupReasoningLive.GetValueOrDefault(world + "/group/" + g.Id).Text ?? ""))))                      Send(member.SteamId, "private-chunk", new CoopPrivatePart("group:" + g.Id, part));          })`
- `_` = `AiService.SummarizeGroupAsync(Current, Save, command.Target, payload.Text)`

<a id="symbol-2c4dd6def46d"></a>

## `Current() — CareerData? Current()`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`](../AiSettingsStore.cs.md#symbol-b37e55b3af97)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`](CoopRules.cs.md#symbol-d8e501560a84)；`NationalSpire.AiOptions.AiOptions()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.PrivateMemorySources`；`NationalSpire.CareerData.PrivatePromptSnapshot`；`NationalSpire.CareerLifeState.Mailbox`；`NationalSpire.Coop.CoopCoordinator._closed`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.Coop.CoopMember.Life`；`NationalSpire.Coop.CoopMember.PersonId`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.CoopWorld.Members`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiOptions.AiOptions()`；输入表达式：`new()`；返回值紧邻使用处：`ArgumentSyntax: new()`
- `NationalSpire.AiSettingsStore.Load(NationalSpire.AiOptions)`；输入表达式：`AiSettingsStore.Load(new())`；返回值紧邻使用处：`AssignmentExpressionSyntax: d.Ai = AiSettingsStore.Load(new())`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(m.Life.Mailbox)`；返回值紧邻使用处：`ConditionalExpressionSyntax: m.PersonId == member.PersonId ? d.Life.Mailbox : CoopJson.Copy(m.Life.Mailbox)`
- `NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`；输入表达式：`CoopRules.View(World, member)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopRules.View(World, member)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`d.PrivatePromptSnapshot.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: d.PrivatePromptSnapshot.Clear();`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`World.Members.FirstOrDefault(m => m.SteamId == sender)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = World.Members.FirstOrDefault(m => m.SteamId == sender)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`World.Members.ToDictionary(m => m.PersonId, m => m.PersonId == member.PersonId ? d.Life.Mailbox : CoopJson.Copy(m.Life.Mailbox))`；返回值紧邻使用处：`AssignmentExpressionSyntax: d.PrivateMemorySources = World.Members.ToDictionary(m => m.PersonId, m => m.PersonId == member.PersonId ? d.Life.Mailbox : CoopJson.Copy(m.Life.Mailbox))`

**赋值（含属性/字段和局部值）：**

- `d.Ai` = `AiSettingsStore.Load(new())`
- `d.PrivateMemorySources` = `World.Members.ToDictionary(m => m.PersonId, m => m.PersonId == member.PersonId ? d.Life.Mailbox : CoopJson.Copy(m.Life.Mailbox))`

<a id="symbol-500092220c28"></a>

## `Save(NationalSpire.CareerData) — void Save(CareerData d)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`](CoopCoordinator.cs.md#symbol-e1dfe22e8221)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`](CoopData.cs.md#symbol-85d2410ea3ba)；[`NationalSpire.Coop.CoopRules.CaptureGroup(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.CareerData)`](CoopGroupChats.cs.md#symbol-e067f985fd23)；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.Coop.CoopCoordinator._closed`；`NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；`NationalSpire.Coop.CoopCoordinator.NativeSave`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopRules.CaptureGroup(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.CareerData)`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Revision`；`NationalSpire.Coop.CoopWorld.World`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCoordinator.Commit(NationalSpire.Coop.CoopWorld, byte[]?, bool)`；输入表达式：`Commit(next, NativeSave)`；返回值紧邻使用处：`ExpressionStatementSyntax: Commit(next, NativeSave);`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(World)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Copy(World)`
- `NationalSpire.Coop.CoopJson.Detached(NationalSpire.CareerData)`；输入表达式：`CoopJson.Detached(next.World)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopJson.Detached(next.World);`
- `NationalSpire.Coop.CoopRules.CaptureGroup(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.CareerData)`；输入表达式：`CoopRules.CaptureGroup(next, next.Members.Single(m => m.SteamId == sender), d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CoopRules.CaptureGroup(next, next.Members.Single(m => m.SteamId == sender), d);`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`next.Members.Single(m => m.SteamId == sender)`；返回值紧邻使用处：`ArgumentSyntax: next.Members.Single(m => m.SteamId == sender)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e067f985fd23"></a>

## `NationalSpire.Coop.CoopRules.CaptureGroup(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.CareerData) — internal static void CaptureGroup(CoopWorld w, CoopMember member, CareerData view)`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.GroupCommand(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.Coop.CoopCommand)`](CoopGroupChats.cs.md#symbol-65a87ad49e08)；[`Save(NationalSpire.CareerData)`](CoopGroupChats.cs.md#symbol-500092220c28)

**调用：** [`NationalSpire.Coop.CoopRules.Capture(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.CareerData)`](CoopRules.cs.md#symbol-99be42ec0491)；[`NationalSpire.Coop.CoopRules.RefreshPeople(NationalSpire.Coop.CoopWorld)`](CoopRules.cs.md#symbol-8025e01818d7)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PrivateMemorySources`；`NationalSpire.CareerLifeState.Mailbox`；`NationalSpire.Coop.CoopMember.Life`；`NationalSpire.Coop.CoopMember.PersonId`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopRules.Capture(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.CareerData)`；`NationalSpire.Coop.CoopRules.RefreshPeople(NationalSpire.Coop.CoopWorld)`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.EsportsCareer.OwnedClub`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopRules.Capture(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.CareerData)`；输入表达式：`Capture(w, member, view)`；返回值紧邻使用处：`ExpressionStatementSyntax: Capture(w, member, view);`
- `NationalSpire.Coop.CoopRules.RefreshPeople(NationalSpire.Coop.CoopWorld)`；输入表达式：`RefreshPeople(w)`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPeople(w);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`view.PrivateMemorySources.TryGetValue(other.PersonId, out var box)`；返回值紧邻使用处：`IfStatementSyntax: if (view.PrivateMemorySources.TryGetValue(other.PersonId, out var box)) other.Life.Mailbox = box;`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`w.Members.Where(m => m.SteamId != member.SteamId)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var other in w.Members.Where(m => m.SteamId != member.SteamId))              if (view.PrivateMemorySources.TryGetValue(other.PersonId, out var box)) other.Life.Mailbox = box;`

**赋值（含属性/字段和局部值）：**

- `other.Life.Mailbox` = `box`
- `w.World.Chats` = `view.Chats`
- `w.World.Esports.OwnedClub` = `view.Esports.OwnedClub`
- `w.World.Matches` = `view.Matches`

<a id="symbol-65a87ad49e08"></a>

## `NationalSpire.Coop.CoopRules.GroupCommand(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.Coop.CoopCommand) — private static string? GroupCommand(CoopWorld w, CoopMember member, CoopCommand command)`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** [`NationalSpire.Coop.CoopJson.Copy<T>(T)`](CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.Coop.CoopRules.CaptureGroup(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.CareerData)`](CoopGroupChats.cs.md#symbol-e067f985fd23)；[`NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`](CoopRules.cs.md#symbol-d8e501560a84)；[`NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`](../GroupChats.cs.md#symbol-e0439deb45ac)；`NationalSpire.GroupCommand.GroupCommand()`；`string.StartsWith(string)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.PrivateMemorySources`；`NationalSpire.CareerLifeState.Mailbox`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.Coop.CoopCommand.Kind`；`NationalSpire.Coop.CoopCommand.Target`；`NationalSpire.Coop.CoopCommand.Text`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.Coop.CoopMember.Life`；`NationalSpire.Coop.CoopMember.PersonId`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopRules.CaptureGroup(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.CareerData)`；`NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Owner`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Interactions`；`NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`；`NationalSpire.GroupCommand.Interaction`；`NationalSpire.GroupCommand.Lane`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateMessageCommand.Offer`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(m.Life.Mailbox)`；返回值紧邻使用处：`ConditionalExpressionSyntax: m.PersonId == member.PersonId ? view.Life.Mailbox : CoopJson.Copy(m.Life.Mailbox)`
- `NationalSpire.Coop.CoopRules.CaptureGroup(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.CareerData)`；输入表达式：`CaptureGroup(w, member, view)`；返回值紧邻使用处：`ExpressionStatementSyntax: CaptureGroup(w, member, view);`
- `NationalSpire.Coop.CoopRules.View(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember)`；输入表达式：`View(w, member)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = View(w, member)`
- `NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`；输入表达式：`GroupChats.Command(view, command.Kind, command.Target, payload)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GroupChats.Command(view, command.Kind, command.Target, payload)`
- `NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`；输入表达式：`GroupChats.Command(view, command.Kind, command.Target, payload)`；返回值紧邻使用处：`ReturnStatementSyntax: return GroupChats.Command(view, command.Kind, command.Target, payload);`
- `NationalSpire.GroupCommand.GroupCommand()`；输入表达式：`new()`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<GroupCommand>(command.Text) ?? new()`
- `string.StartsWith(string)`；输入表达式：`command.Kind.StartsWith("group-offer-")`；返回值紧邻使用处：`BinaryExpressionSyntax: command.Kind.StartsWith("group-offer-") && view.Chats.Groups.FirstOrDefault(g => g.Id == command.Target)?.Interactions.GetValueOrDefault(payload.Lane)?.Offers.FirstOrDefault(o => o.Id == payload.Interaction.Offer)?.Kind == "contract"`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Offers.FirstOrDefault(o => o.Id == payload.Interaction.Offer)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .Offers.FirstOrDefault(o => o.Id == payload.Interaction.Offer)?.Kind`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`view.Chats.Groups.FirstOrDefault(g => g.Id == command.Target)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: view.Chats.Groups.FirstOrDefault(g => g.Id == command.Target)?.Interactions.GetValueOrDefault(payload.Lane)?.Offers.FirstOrDefault(o => o.Id == payload.Interaction.Offer)?.Kind`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`w.Members.ToDictionary(m => m.PersonId, m => m.PersonId == member.PersonId ? view.Life.Mailbox : CoopJson.Copy(m.Life.Mailbox))`；返回值紧邻使用处：`AssignmentExpressionSyntax: view.PrivateMemorySources = w.Members.ToDictionary(m => m.PersonId, m => m.PersonId == member.PersonId ? view.Life.Mailbox : CoopJson.Copy(m.Life.Mailbox))`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.Interactions.GetValueOrDefault(payload.Lane)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .Interactions.GetValueOrDefault(payload.Lane)?.Offers.FirstOrDefault(o => o.Id == payload.Interaction.Offer)?.Kind`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<GroupCommand>(command.Text)`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<GroupCommand>(command.Text) ?? new()`

**赋值（含属性/字段和局部值）：**

- `view.PrivateMemorySources` = `w.Members.ToDictionary(m => m.PersonId, m => m.PersonId == member.PersonId ? view.Life.Mailbox : CoopJson.Copy(m.Life.Mailbox))`
