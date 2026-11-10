# DateHistoryRewind.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`C43CC40FDD77A5F5FBA00C0A309B2A5B6C249F61BA97070C6F71383B5B8D9BFD`。来源：[源码](../../DateHistoryRewind.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DateHistoryRewind`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-b8b9d3bc8651"></a>

## `NationalSpire.DateHistoryRewind.Apply(NationalSpire.CareerData, string, NationalSpire.PrivateMessageCommand, bool) — public static string? Apply(CareerData data, string person, PrivateMessageCommand command, bool save = false)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateCommand(string, NationalSpire.PrivateMessageCommand, System.Action?, string?, System.Action<string>?)`](PrivateMessageScreen.cs.md#symbol-d622e0fb06ab)；[`NationalSpire.PrivateMessageCommands.ApplyCore(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-1472969f513b)

**调用：** [`NationalSpire.AiService.PrivateBusy(NationalSpire.CareerData, string)`](AiPrivateMessages.cs.md#symbol-57be9d2323cb)；[`NationalSpire.CareerData.EncodingHeader()`](CareerData.cs.md#symbol-09cee4b6558d)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.Coop.CoopJson.Copy<T>(T)`](Coop/CoopData.cs.md#symbol-38a51b2b1811)；[`NationalSpire.DateHistoryRewind.Copy(NationalSpire.CareerData, NationalSpire.CareerData)`](DateHistoryRewind.cs.md#symbol-7af6318713eb)；[`NationalSpire.DateScenes.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest, bool)`](DateSceneData.cs.md#symbol-0fd8375508ff)；[`NationalSpire.MatchFailure.Locked(NationalSpire.CareerData)`](FailureDecision.cs.md#symbol-7f4fa41ad4c0)；[`NationalSpire.PrivateInteractionHistory.Rewind(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn)`](PrivateInteractionUndo.cs.md#symbol-f2cc1906a6b6)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`long.ToString()`；`System.Collections.Generic.HashSet<T>.UnionWith(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Clear()`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；`System.Collections.Generic.List<T>.RemoveRange(int, int)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.PrivateBusy(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.EncodingHeader()`；`NationalSpire.CareerData.ExternalCurrent`；`NationalSpire.CareerData.ExternalSave`；`NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.Coop.CoopJson.Copy<T>(T)`；`NationalSpire.DateHistoryRewind.Copy(NationalSpire.CareerData, NationalSpire.CareerData)`；`NationalSpire.DateSceneInvitation.State`；`NationalSpire.DateSceneRequest.Ending`；`NationalSpire.DateSceneRequest.GameEvent`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateSceneRequest.Opening`；`NationalSpire.DateScenes.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest, bool)`；`NationalSpire.MatchFailure.Locked(NationalSpire.CareerData)`；`NationalSpire.PrivateConversation.ContextStart`；`NationalSpire.PrivateConversation.MemoryRevision`；`NationalSpire.PrivateConversation.RewoundDateTurns`；`NationalSpire.PrivateConversation.SeenCount`；`NationalSpire.PrivateConversation.SummaryError`；`NationalSpire.PrivateConversation.SummaryRequest`；`NationalSpire.PrivateConversation.SummaryStatus`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateInteractionHistory.Rewind(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn)`；`NationalSpire.PrivateMessageCommand.Entry`；`NationalSpire.PrivateMessageCommand.Offer`；`NationalSpire.PrivateMessageCommand.Part`；`NationalSpire.PrivateMessageCommand.Replacement`；`NationalSpire.PrivateMessageCommand.Text`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateTurn.Context`；`NationalSpire.PrivateTurn.DateInvitation`；`NationalSpire.PrivateTurn.Error`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.PreviousReasoning`；`NationalSpire.PrivateTurn.PreviousReply`；`NationalSpire.PrivateTurn.Reasoning`；`NationalSpire.PrivateTurn.Regenerating`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.RequestKind`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.SceneChoices`；`NationalSpire.PrivateTurn.SceneLines`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.ToolCalls`；`NationalSpire.PrivateTurn.UserDeleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `long.ToString()`；输入表达式：`current.MemoryRevision.ToString()`；返回值紧邻使用处：`BinaryExpressionSyntax: current.MemoryRevision.ToString() != command.Part`
- `NationalSpire.AiService.PrivateBusy(NationalSpire.CareerData, string)`；输入表达式：`AiService.PrivateBusy(data, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: AiService.PrivateBusy(data, person) || current.Turns.Any(t => t.Status is "queued" or "sending")`
- `NationalSpire.CareerData.EncodingHeader()`；输入表达式：`data.EncodingHeader()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.EncodingHeader()`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(data);`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(conversation.Turns[index])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Copy(conversation.Turns[index])`
- `NationalSpire.Coop.CoopJson.Copy<T>(T)`；输入表达式：`CoopJson.Copy(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CoopJson.Copy(data)`
- `NationalSpire.DateHistoryRewind.Copy(NationalSpire.CareerData, NationalSpire.CareerData)`；输入表达式：`Copy(before, data)`；返回值紧邻使用处：`ExpressionStatementSyntax: Copy(before, data);`
- `NationalSpire.DateHistoryRewind.Copy(NationalSpire.CareerData, NationalSpire.CareerData)`；输入表达式：`Copy(candidate, data)`；返回值紧邻使用处：`ExpressionStatementSyntax: Copy(candidate, data);`
- `NationalSpire.DateScenes.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest, bool)`；输入表达式：`DateScenes.Validate(candidate, conversation, conversation.Turns[index].Scene!, retained: true)`；返回值紧邻使用处：`IsPatternExpressionSyntax: DateScenes.Validate(candidate, conversation, conversation.Turns[index].Scene!, retained: true) is { } invalid`
- `NationalSpire.MatchFailure.Locked(NationalSpire.CareerData)`；输入表达式：`MatchFailure.Locked(data)`；返回值紧邻使用处：`IsPatternExpressionSyntax: MatchFailure.Locked(data) is { } locked`
- `NationalSpire.PrivateInteractionHistory.Rewind(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn)`；输入表达式：`PrivateInteractionHistory.Rewind(candidate, conversation, turn)`；返回值紧邻使用处：`IsPatternExpressionSyntax: PrivateInteractionHistory.Rewind(candidate, conversation, turn) is { } error`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(candidate, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(candidate, person)`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(data, person)`
- `System.Collections.Generic.HashSet<T>.UnionWith(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`conversation.RewoundDateTurns.UnionWith(removed.Select(t => t.Id))`；返回值紧邻使用处：`ExpressionStatementSyntax: conversation.RewoundDateTurns.UnionWith(removed.Select(t => t.Id));`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`current.Turns.Any(t => t.Status is "queued" or "sending")`；返回值紧邻使用处：`BinaryExpressionSyntax: AiService.PrivateBusy(data, person) || current.Turns.Any(t => t.Status is "queued" or "sending")`
- `System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；输入表达式：`removed.AsEnumerable()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: removed.AsEnumerable().Reverse`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`current.Turns.LastOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: current.Turns.LastOrDefault()?.Id`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`removed.AsEnumerable().Reverse()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var turn in removed.AsEnumerable().Reverse())          {              if (turn.DateInvitation is { State: "accepted" } || turn.RequestKind == "arbitration") return "后续记录包含已生效的共同约会或仲裁，请保留这些记录。";              if (PrivateInteractionHistory.Rewind(candidate, conversation, turn) is { } error) return error;          }`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`removed.Select(t => t.Id)`；返回值紧邻使用处：`ArgumentSyntax: removed.Select(t => t.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`conversation.Turns.Skip(index)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: conversation.Turns.Skip(index).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`conversation.Turns.Skip(index).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = conversation.Turns.Skip(index).ToList()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`conversation.Turns.Add(draft)`；返回值紧邻使用处：`ExpressionStatementSyntax: conversation.Turns.Add(draft);`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`draft.SceneChoices.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: draft.SceneChoices.Clear();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`draft.SceneLines.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: draft.SceneLines.Clear();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`draft.ToolCalls.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: draft.ToolCalls.Clear();`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`current.Turns.FindIndex(t => t.Id == command.Entry)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = current.Turns.FindIndex(t => t.Id == command.Entry)`
- `System.Collections.Generic.List<T>.RemoveRange(int, int)`；输入表达式：`conversation.Turns.RemoveRange(index, conversation.Turns.Count - index)`；返回值紧邻使用处：`ExpressionStatementSyntax: conversation.Turns.RemoveRange(index, conversation.Turns.Count - index);`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(conversation.ContextStart, index)`；返回值紧邻使用处：`AssignmentExpressionSyntax: conversation.ContextStart = Math.Min(conversation.ContextStart, index)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(conversation.SeenCount, conversation.Turns.Count)`；返回值紧邻使用处：`AssignmentExpressionSyntax: conversation.SeenCount = Math.Min(conversation.SeenCount, conversation.Turns.Count)`

**赋值（含属性/字段和局部值）：**

- `candidate.ExternalCurrent` = `() => false`
- `candidate.ExternalSave` = `_ => { }`
- `candidate.LocalHumanId` = `data.LocalHumanId`
- `conversation.ContextStart` = `Math.Min(conversation.ContextStart, index)`
- `conversation.SeenCount` = `Math.Min(conversation.SeenCount, conversation.Turns.Count)`
- `conversation.SummaryError` = `""`
- `conversation.SummaryRequest` = `conversation.SummaryStatus = conversation.SummaryError = ""`
- `conversation.SummaryStatus` = `conversation.SummaryError = ""`
- `draft.Context` = `""`
- `draft.Error` = `"已返回这段对话，请编辑后发送。"`
- `draft.Id` = `command.Replacement`
- `draft.PreviousReasoning` = `draft.Context = ""`
- `draft.PreviousReply` = `draft.PreviousReasoning = draft.Context = ""`
- `draft.Reasoning` = `draft.PreviousReply = draft.PreviousReasoning = draft.Context = ""`
- `draft.Regenerating` = `false`
- `draft.Reply` = `draft.Reasoning = draft.PreviousReply = draft.PreviousReasoning = draft.Context = ""`
- `draft.Status` = `"failed"`

<a id="symbol-7af6318713eb"></a>

## `NationalSpire.DateHistoryRewind.Copy(NationalSpire.CareerData, NationalSpire.CareerData) — private static void Copy(CareerData from, CareerData to)`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateHistoryRewind.Apply(NationalSpire.CareerData, string, NationalSpire.PrivateMessageCommand, bool)`](DateHistoryRewind.cs.md#symbol-b8b9d3bc8651)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.CommunityMemories`；`NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.Posts`；`NationalSpire.CareerData.SavedThreads`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `to.CommunityMemories` = `from.CommunityMemories`
- `to.Credits` = `from.Credits`
- `to.Esports` = `from.Esports`
- `to.Life` = `from.Life`
- `to.Matches` = `from.Matches`
- `to.People` = `from.People`
- `to.Posts` = `from.Posts`
- `to.SavedThreads` = `from.SavedThreads`
