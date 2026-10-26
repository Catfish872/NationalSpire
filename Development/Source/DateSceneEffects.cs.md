# DateSceneEffects.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`F1473DD13900452EE0930128130F84516B167A9D8A758A7176B54B9074221F78`。来源：[源码](../../DateSceneEffects.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DateSceneEffects`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-b961def8188f"></a>

## `NationalSpire.DateSceneEffects.SourceTurn(NationalSpire.PrivateMailbox, string, string) — public static PrivateTurn? SourceTurn(PrivateMailbox mailbox, string person, string turnId)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)；[`NationalSpire.PrivateMessages.ConfirmFavour(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer, bool)`](PrivateMessages.cs.md#symbol-056e9f8e0046)；[`NationalSpire.PrivateMessages.RemoveDeletedOffers(NationalSpire.PrivateConversation, NationalSpire.PrivateMailbox?)`](PrivateMessages.cs.md#symbol-b239ace74471)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateTurn.DatePartyEffects`；`NationalSpire.PrivateTurn.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`mailbox.Conversations.TryGetValue(person, out var direct)`；返回值紧邻使用处：`BinaryExpressionSyntax: mailbox.Conversations.TryGetValue(person, out var direct) && direct.Turns.FirstOrDefault(t => t.Id == turnId) is { } own`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`t.DatePartyEffects.TryGetValue(person, out var child)`；返回值紧邻使用处：`BinaryExpressionSyntax: t.DatePartyEffects.TryGetValue(person, out var child) && child.Id == turnId`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`direct.Turns.FirstOrDefault(t => t.Id == turnId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: direct.Turns.FirstOrDefault(t => t.Id == turnId) is { } own`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`mailbox.Conversations.Values.SelectMany(c => c.Turns).FirstOrDefault(t => t.DatePartyEffects.TryGetValue(person, out var child) && child.Id == turnId)`；返回值紧邻使用处：`ReturnStatementSyntax: return mailbox.Conversations.Values.SelectMany(c => c.Turns).FirstOrDefault(t => t.DatePartyEffects.TryGetValue(person, out var child) && child.Id == turnId);`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`mailbox.Conversations.Values.SelectMany(c => c.Turns)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: mailbox.Conversations.Values.SelectMany(c => c.Turns).FirstOrDefault`

**赋值（含属性/字段和局部值）：**


<a id="symbol-02f9d7b85cad"></a>

## `NationalSpire.DateSceneEffects.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int) — public static void Apply(CareerData data, PrivateConversation conversation, PrivateTurn turn, IReadOnlyList<Dictionary<string, string>> directives, int originalFavour)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.DateGames.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>)`](DateGames.cs.md#symbol-e72b5454cf31)；[`NationalSpire.DateSceneInvitations.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>)`](DateSceneInvitations.cs.md#symbol-b18700ea221f)；[`NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`](PrivateMessages.cs.md#symbol-7bf623828ccc)；[`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`NationalSpire.PrivateTurn.PrivateTurn()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.DateGames.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>)`；`NationalSpire.DateSceneInvitations.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>)`；`NationalSpire.DateSceneLine.Speaker`；`NationalSpire.DateSceneLine.Text`；`NationalSpire.DateSceneParticipant.PersonId`；`NationalSpire.DateSceneRequest.Participants`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateInteractionUndo.PersonId`；`NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateTurn.Applied`；`NationalSpire.PrivateTurn.DatePartyEffects`；`NationalSpire.PrivateTurn.Day`；`NationalSpire.PrivateTurn.Error`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.InteractionUndo`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.SceneLines`；`NationalSpire.PrivateTurn.Season`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.User`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: "\n" + CareerEngine.DisplayName(data, person)`
- `NationalSpire.DateGames.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>)`；输入表达式：`DateGames.Respond(data, conversation, turn, directives)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateGames.Respond(data, conversation, turn, directives);`
- `NationalSpire.DateSceneInvitations.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>)`；输入表达式：`DateSceneInvitations.Respond(data, conversation, turn, directives)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateSceneInvitations.Respond(data, conversation, turn, directives);`
- `NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`；输入表达式：`PrivateMessages.Apply(data, PrivateMessages.Conversation(data, person), child, fields)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateMessages.Apply(data, PrivateMessages.Conversation(data, person), child, fields);`
- `NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`；输入表达式：`PrivateMessages.Apply(data, conversation, turn, directives, originalFavour)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateMessages.Apply(data, conversation, turn, directives, originalFavour);`
- `NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`；输入表达式：`PrivateMessages.Apply(data, conversation, turn, host, originalFavour)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateMessages.Apply(data, conversation, turn, host, originalFavour);`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(data, actor)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateMessages.CanChat(data, actor)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, person)`；返回值紧邻使用处：`ArgumentSyntax: PrivateMessages.Conversation(data, person)`
- `NationalSpire.PrivateTurn.PrivateTurn()`；输入表达式：`new PrivateTurn { Id = turn.Id + "/" + person, Day = turn.Day, Season = turn.Season, Status = "complete", User = turn.User, Reply = string.Join("\n", turn.SceneLines.Where(l => l.Speaker == person).Select(l => l.Text)) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateTurn { Id = turn.Id + "/" + person, Day = turn.Day, Season = turn.Season, Status = "complete", User = turn.User, Reply = string.Join("\n", turn.SceneLines.Where(l => l.Speaker == person).Select(l => l.Text)) }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Attitude")`；返回值紧邻使用处：`BinaryExpressionSyntax: fields.ContainsKey("Favour") || fields.ContainsKey("Attitude")`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Favour")`；返回值紧邻使用处：`BinaryExpressionSyntax: fields.ContainsKey("Favour") || fields.ContainsKey("Attitude")`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Mood")`；返回值紧邻使用处：`BinaryExpressionSyntax: fields.ContainsKey("Favour") || fields.ContainsKey("Attitude") || fields.ContainsKey("Relationship") || fields.ContainsKey("Skill") || fields.ContainsKey("Mood")`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Profile")`；返回值紧邻使用处：`BinaryExpressionSyntax: fields.ContainsKey("Favour") || fields.ContainsKey("Attitude") || fields.ContainsKey("Relationship") || fields.ContainsKey("Skill") || fields.ContainsKey("Mood") || fields.ContainsKey("Profile")`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Relationship")`；返回值紧邻使用处：`BinaryExpressionSyntax: fields.ContainsKey("Favour") || fields.ContainsKey("Attitude") || fields.ContainsKey("Relationship")`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Skill")`；返回值紧邻使用处：`BinaryExpressionSyntax: fields.ContainsKey("Favour") || fields.ContainsKey("Attitude") || fields.ContainsKey("Relationship") || fields.ContainsKey("Skill")`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, List<Dictionary<string, string>>>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, List<Dictionary<string, string>>>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`others.TryGetValue(actor, out var list)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !others.TryGetValue(actor, out var list)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`people.Contains(actor)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !people.Contains(actor)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`scene.Participants.Select(p => p.PersonId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: scene.Participants.Select(p => p.PersonId).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`turn.SceneLines.Where(l => l.Speaker == person).Select(l => l.Text)`；返回值紧邻使用处：`ArgumentSyntax: turn.SceneLines.Where(l => l.Speaker == person).Select(l => l.Text)`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`scene.Participants.Select(p => p.PersonId).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = scene.Participants.Select(p => p.PersonId).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`turn.SceneLines.Where(l => l.Speaker == person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: turn.SceneLines.Where(l => l.Speaker == person).Select`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`fields.GetValueOrDefault("Actor", "")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = fields.GetValueOrDefault("Actor", "")`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`host.Add(fields)`；返回值紧邻使用处：`ExpressionStatementSyntax: host.Add(fields);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`list.Add(fields)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.Add(fields);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`turn.InteractionUndo.Add(undo)`；返回值紧邻使用处：`ExpressionStatementSyntax: turn.InteractionUndo.Add(undo);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Dictionary<string, string>>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<Dictionary<string, string>>()`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", turn.SceneLines.Where(l => l.Speaker == person).Select(l => l.Text))`；返回值紧邻使用处：`AssignmentExpressionSyntax: Reply = string.Join("\n", turn.SceneLines.Where(l => l.Speaker == person).Select(l => l.Text))`

**赋值（含属性/字段和局部值）：**

- `Day` = `turn.Day`
- `Id` = `turn.Id + "/" + person`
- `Reply` = `string.Join("\n", turn.SceneLines.Where(l => l.Speaker == person).Select(l => l.Text))`
- `Season` = `turn.Season`
- `Status` = `"complete"`
- `User` = `turn.User`
- `list` = `[]`
- `others[actor]` = `list = []`
- `turn.DatePartyEffects[person]` = `child`
- `turn.Error` += `"\n" + CareerEngine.DisplayName(data, person) + "：" + child.Error`
- `turn.Error` += `"\n一项交互缺少有效人物编号，已保留原值。"`
- `turn.Error` += `"\n缺少发言内容的人物交互已略过。"`
- `undo.PersonId` = `person`
