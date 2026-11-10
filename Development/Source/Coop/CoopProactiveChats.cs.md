# Coop/CoopProactiveChats.cs

[返回文件依赖索引](../../SOURCE_MAP.md)

源码 SHA-256：`A22BE8A4A6EB78178F70D7133330DC5202D78C6032E0B3FD99D63F40B0ECB715`。来源：[源码](../../../Coop/CoopProactiveChats.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.Coop.CoopCoordinator`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-119c1a541077"></a>

## `NationalSpire.Coop.CoopCoordinator.StartProactiveChats() — private void StartProactiveChats()`

来源：源码第 5 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopCoordinator.Tick()`](CoopCoordinator.cs.md#symbol-4253349561bc)

**调用：** [`NationalSpire.Coop.CoopCoordinator.StartGroup(ulong, NationalSpire.Coop.CoopCommand)`](CoopGroupChats.cs.md#symbol-83d332761336)；[`NationalSpire.Coop.CoopCoordinator.StartPrivate(ulong, NationalSpire.Coop.CoopCommand)`](CoopPrivateMessages.cs.md#symbol-ebc3f29b5eb6)；`NationalSpire.Coop.CoopCommand.CoopCommand(string, string, string, long, string, string, string, int, string)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.ToArray()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Chats`；`NationalSpire.CareerLifeState.Mailbox`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.Coop.CoopCoordinator.Host`；`NationalSpire.Coop.CoopCoordinator.StartGroup(ulong, NationalSpire.Coop.CoopCommand)`；`NationalSpire.Coop.CoopCoordinator.StartPrivate(ulong, NationalSpire.Coop.CoopCommand)`；`NationalSpire.Coop.CoopCoordinator.World`；`NationalSpire.Coop.CoopMember.Life`；`NationalSpire.Coop.CoopMember.PersonId`；`NationalSpire.Coop.CoopMember.SteamId`；`NationalSpire.Coop.CoopWorld.Epoch`；`NationalSpire.Coop.CoopWorld.Id`；`NationalSpire.Coop.CoopWorld.Members`；`NationalSpire.Coop.CoopWorld.Revision`；`NationalSpire.Coop.CoopWorld.World`；`NationalSpire.GroupChat.Dissolved`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupChat.Turns`；`NationalSpire.GroupTurn.ProactiveReason`；`NationalSpire.GroupTurn.Sender`；`NationalSpire.GroupTurn.Status`；`NationalSpire.PrivateConversation.Hidden`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateTurn.ProactiveReason`；`NationalSpire.PrivateTurn.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Coop.CoopCommand.CoopCommand(string, string, string, long, string, string, string, int, string)`；输入表达式：`new(World.Id, World.Epoch, "", World.Revision, "dm-send", c.PersonId)`；返回值紧邻使用处：`ArgumentSyntax: new(World.Id, World.Epoch, "", World.Revision, "dm-send", c.PersonId)`
- `NationalSpire.Coop.CoopCommand.CoopCommand(string, string, string, long, string, string, string, int, string)`；输入表达式：`new(World.Id, World.Epoch, "", World.Revision, "group-send", g.Id)`；返回值紧邻使用处：`ArgumentSyntax: new(World.Id, World.Epoch, "", World.Revision, "group-send", g.Id)`
- `NationalSpire.Coop.CoopCoordinator.StartGroup(ulong, NationalSpire.Coop.CoopCommand)`；输入表达式：`StartGroup(member.SteamId, new(World.Id, World.Epoch, "", World.Revision, "group-send", g.Id))`；返回值紧邻使用处：`ExpressionStatementSyntax: StartGroup(member.SteamId, new(World.Id, World.Epoch, "", World.Revision, "group-send", g.Id));`
- `NationalSpire.Coop.CoopCoordinator.StartPrivate(ulong, NationalSpire.Coop.CoopCommand)`；输入表达式：`StartPrivate(member.SteamId, new(World.Id, World.Epoch, "", World.Revision, "dm-send", c.PersonId))`；返回值紧邻使用处：`ExpressionStatementSyntax: StartPrivate(member.SteamId, new(World.Id, World.Epoch, "", World.Revision, "dm-send", c.PersonId));`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`c.Turns.LastOrDefault()`；返回值紧邻使用处：`IsPatternExpressionSyntax: c.Turns.LastOrDefault() is { Status: "queued", ProactiveReason.Length: > 0 }`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`g.Turns.LastOrDefault()`；返回值紧邻使用处：`IsPatternExpressionSyntax: g.Turns.LastOrDefault() is { Status: "queued", ProactiveReason.Length: > 0 } turn`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`member.Life.Mailbox.Conversations.Values.ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var c in member.Life.Mailbox.Conversations.Values.ToArray())                 if (!c.Hidden && c.Turns.LastOrDefault() is { Status: "queued", ProactiveReason.Length: > 0 })                     StartPrivate(member.SteamId, new(World.Id, World.Epoch, "", World.Revision, "dm-send", c.PersonId));`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`World.World.Chats.Groups.Where(g => !g.Dissolved && g.Members.Contains(member.PersonId)).ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var g in World.World.Chats.Groups.Where(g => !g.Dissolved && g.Members.Contains(member.PersonId)).ToArray())                 if (g.Turns.LastOrDefault() is { Status: "queued", ProactiveReason.Length: > 0 } turn && turn.Sender == member.PersonId)                     StartGroup(member.SteamId, new(World.Id, World.Epoch, "", World.Revision, "group-send", g.Id));`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`World.World.Chats.Groups.Where(g => !g.Dissolved && g.Members.Contains(member.PersonId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: World.World.Chats.Groups.Where(g => !g.Dissolved && g.Members.Contains(member.PersonId)).ToArray`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`g.Members.Contains(member.PersonId)`；返回值紧邻使用处：`BinaryExpressionSyntax: !g.Dissolved && g.Members.Contains(member.PersonId)`
- `System.Collections.Generic.List<T>.ToArray()`；输入表达式：`World.Members.ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var member in World.Members.ToArray())         {             foreach (var c in member.Life.Mailbox.Conversations.Values.ToArray())                 if (!c.Hidden && c.Turns.LastOrDefault() is { Status: "queued", ProactiveReason.Length: > 0 })                     StartPrivate(member.SteamId, new(World.Id, World.Epoch, "", World.Revision, "dm-send", c.PersonId));             foreach (var g in World.World.Chats.Groups.Where(g => !g.Dissolved && g.Members.Contains(member.PersonId)).ToArray())                 if (g.Turns.LastOrDefault() is { Status: "queued", ProactiveReason.Length: > 0 } turn && turn.Sender == member.PersonId)                     StartGroup(member.SteamId, new(World.Id, World.Epoch, "", World.Revision, "group-send", g.Id));         }`

**赋值（含属性/字段和局部值）：**
