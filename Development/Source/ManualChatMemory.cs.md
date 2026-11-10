# ManualChatMemory.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`F66D475C3A38E045C166BB8C37A80B014A3B5FB1456D40C430C1F2B9DB56002E`。来源：[源码](../../ManualChatMemory.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.ManualChatMemory`、`NationalSpire.ManualChatMemories`。

字段、事件及初始值（源码原样）：

```csharp
public const int MaxLength = 16000;
```

<a id="symbol-4c0bd6910d4a"></a>

## `NationalSpire.ManualChatMemory.Id — public string Id`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Guid.NewGuid()`；`System.Guid.ToString(string?)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Guid.NewGuid().ToString("N")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fe59cc7554f6"></a>

## `NationalSpire.ManualChatMemory.Text — public string Text`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9d558c2ed8d6"></a>

## `NationalSpire.ManualChatMemory.Day — public int Day`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a25c6c1be1e1"></a>

## `NationalSpire.ManualChatMemory.Order — public long Order`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3d0261d63d16"></a>

## `NationalSpire.ManualChatMemories.Validate(string) — public static string? Validate(string text)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EditManualMemory(NationalSpire.ManualChatMemory?)`](ManualMemoryScreen.cs.md#symbol-026ac4d345bc)；[`NationalSpire.ManualChatMemories.Manage(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.ManualChatMemory>, string, string, string)`](ManualChatMemory.cs.md#symbol-711e5637bdb3)

**调用：** `string.IsNullOrWhiteSpace(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.ManualChatMemories.MaxLength`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(text)`；返回值紧邻使用处：`ConditionalExpressionSyntax: string.IsNullOrWhiteSpace(text) ? "请填写记忆总结。" : text.Length > MaxLength ? $"记忆总结最多 {MaxLength} 字。" : null`

**赋值（含属性/字段和局部值）：**


<a id="symbol-711e5637bdb3"></a>

## `NationalSpire.ManualChatMemories.Manage(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.ManualChatMemory>, string, string, string) — public static string? Manage(CareerData data, List<ManualChatMemory> memories, string action, string id, string text)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupChats.CommandCore(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`](GroupChats.cs.md#symbol-136432a1ec5d)；[`NationalSpire.PrivateMessages.Manage(NationalSpire.CareerData, NationalSpire.PrivateConversation, string, NationalSpire.PrivateMessageCommand)`](PrivateMessages.cs.md#symbol-2b57951bede9)

**调用：** [`NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-c362351c7a43)；[`NationalSpire.ManualChatMemories.Validate(string)`](ManualChatMemory.cs.md#symbol-3d0261d63d16)；`NationalSpire.ManualChatMemory.ManualChatMemory()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Remove(T)`；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`；`NationalSpire.ManualChatMemories.Validate(string)`；`NationalSpire.ManualChatMemory.Day`；`NationalSpire.ManualChatMemory.Id`；`NationalSpire.ManualChatMemory.Order`；`NationalSpire.ManualChatMemory.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`；输入表达式：`GroupChats.NextOrder(data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Order = GroupChats.NextOrder(data)`
- `NationalSpire.ManualChatMemories.Validate(string)`；输入表达式：`Validate(text)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Validate(text) is { } error`
- `NationalSpire.ManualChatMemory.ManualChatMemory()`；输入表达式：`new() { Id = id.Length > 0 ? id : Guid.NewGuid().ToString("N"), Day = data.Day, Order = GroupChats.NextOrder(data) }`；返回值紧邻使用处：`AssignmentExpressionSyntax: memory = new() { Id = id.Length > 0 ? id : Guid.NewGuid().ToString("N"), Day = data.Day, Order = GroupChats.NextOrder(data) }`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`memories.FirstOrDefault(m => m.Id == id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = memories.FirstOrDefault(m => m.Id == id)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`memories.Add(memory)`；返回值紧邻使用处：`ExpressionStatementSyntax: memories.Add(memory);`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`memories.Remove(memory!)`；返回值紧邻使用处：`ExpressionStatementSyntax: memories.Remove(memory!);`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`ConditionalExpressionSyntax: id.Length > 0 ? id : Guid.NewGuid().ToString("N")`

**赋值（含属性/字段和局部值）：**

- `Day` = `data.Day`
- `Id` = `id.Length > 0 ? id : Guid.NewGuid().ToString("N")`
- `Order` = `GroupChats.NextOrder(data)`
- `memory!.Text` = `text`
- `memory` = `new() { Id = id.Length > 0 ? id : Guid.NewGuid().ToString("N"), Day = data.Day, Order = GroupChats.NextOrder(data) }`

<a id="symbol-86290ef9b100"></a>

## `NationalSpire.ManualChatMemories.Known(NationalSpire.GroupChat, string) — public static IEnumerable<ManualChatMemory> Known(GroupChat group, string person)`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatTimeline.PublicMemory(NationalSpire.CareerData, NationalSpire.GroupChat, string, int)`](ChatTimeline.cs.md#symbol-6c6e8fc3c1d7)；[`NationalSpire.ChatTimeline.Summaries(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, string, string)`](ChatTimeline.cs.md#symbol-2b6ae7313c3c)

**调用：** [`NationalSpire.ChatMembership.Knows(NationalSpire.GroupChat, string, long)`](ChatMembership.cs.md#symbol-209a25070cf3)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatMembership.Knows(NationalSpire.GroupChat, string, long)`；`NationalSpire.GroupChat.Departures`；`NationalSpire.GroupChat.ManualMemories`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupDeparture.ManualMemories`；`NationalSpire.ManualChatMemory.Order`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatMembership.Knows(NationalSpire.GroupChat, string, long)`；输入表达式：`ChatMembership.Knows(group, person, m.Order)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m => ChatMembership.Knows(group, person, m.Order)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`group.Departures.TryGetValue(person, out var departure)`；返回值紧邻使用处：`ConditionalExpressionSyntax: group.Departures.TryGetValue(person, out var departure) ? departure.ManualMemories : []`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`(group.Members.Contains(person) ? group.ManualMemories : group.Departures.TryGetValue(person, out var departure) ? departure.ManualMemories : []) .Where(m => ChatMembership.Knows(group, person, m.Order))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => (group.Members.Contains(person) ? group.ManualMemories : group.Departures.TryGetValue(person, out var departure) ? departure.ManualMemories : []) .Where(m => ChatMembership.Knows(group, person, m.Order))`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`group.Members.Contains(person)`；返回值紧邻使用处：`ConditionalExpressionSyntax: group.Members.Contains(person) ? group.ManualMemories : group.Departures.TryGetValue(person, out var departure) ? departure.ManualMemories : []`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7188d3f17ab1"></a>

## `NationalSpire.ManualChatMemories.Heading(NationalSpire.CareerData, NationalSpire.ManualChatMemory) — public static string Heading(CareerData data, ManualChatMemory memory)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Add(string, System.Collections.Generic.IEnumerable<NationalSpire.PrivateSummary>, System.Collections.Generic.IEnumerable<NationalSpire.PrivateSummary>, System.Collections.Generic.IReadOnlyCollection<NationalSpire.ManualChatMemory>)`](ChatTimeline.cs.md#symbol-4529458c7605)；[`NationalSpire.CareerScreen.ManualMemoryCard(Godot.VBoxContainer, NationalSpire.ManualChatMemory)`](ManualMemoryScreen.cs.md#symbol-aad226291778)；[`NationalSpire.DateSceneParty.Context(NationalSpire.CareerData, NationalSpire.DateSceneRequest)`](DateSceneParty.cs.md#symbol-fcb96c133a03)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.PrivateMessagePrompts.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?, string?, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-de94bbbea5ea)

**调用：** [`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)

**字段、属性、事件及方法组引用：** `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.ManualChatMemory.Day`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(data, memory.Day)`；返回值紧邻使用处：`BinaryExpressionSyntax: "手动记忆 · " + GameCalendar.Text(data, memory.Day)`

**赋值（含属性/字段和局部值）：**
