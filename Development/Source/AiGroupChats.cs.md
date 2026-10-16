# AiGroupChats.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`C08BC412768B81296BA191C78557CD9EE3F79E5F6B4251C2A522A2B06D111E36`。来源：[源码](../../AiGroupChats.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.AiService`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly Dictionary<string, CancellationTokenSource> GroupRequests = [];
private static readonly HashSet<string> GroupSummaries = [];
public static readonly Dictionary<string, string> GroupLive = [];
public static readonly Dictionary<string, (string Turn, string Text)> GroupReasoningLive = [];
```

<a id="symbol-ed8efb8958b5"></a>

## `NationalSpire.AiService.GroupKey(NationalSpire.CareerData, string) — public static string GroupKey(CareerData d, string group)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.CancelGroup(NationalSpire.CareerData, string)`](AiGroupChats.cs.md#symbol-8ecf66adf72d)；[`NationalSpire.AiService.ProcessGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string>?)`](AiGroupChats.cs.md#symbol-caddadc35a6b)；[`NationalSpire.AiService.SummarizeGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, string)`](AiGroupChats.cs.md#symbol-1e6e737dbe88)；[`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.AvatarWorldId`；`NationalSpire.CareerData.WorldId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8ecf66adf72d"></a>

## `NationalSpire.AiService.CancelGroup(NationalSpire.CareerData, string) — public static void CancelGroup(CareerData d, string group)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`](GroupChats.cs.md#symbol-e0439deb45ac)

**调用：** [`NationalSpire.AiService.GroupKey(NationalSpire.CareerData, string)`](AiGroupChats.cs.md#symbol-ed8efb8958b5)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Threading.CancellationTokenSource.Cancel()`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.GroupKey(NationalSpire.CareerData, string)`；`NationalSpire.AiService.GroupRequests`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.GroupKey(NationalSpire.CareerData, string)`；输入表达式：`GroupKey(d, group)`；返回值紧邻使用处：`ArgumentSyntax: GroupKey(d, group)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`GroupRequests.TryGetValue(GroupKey(d, group), out var request)`；返回值紧邻使用处：`IfStatementSyntax: if (GroupRequests.TryGetValue(GroupKey(d, group), out var request)) request.Cancel();`
- `System.Threading.CancellationTokenSource.Cancel()`；输入表达式：`request.Cancel()`；返回值紧邻使用处：`ExpressionStatementSyntax: request.Cancel();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-caddadc35a6b"></a>

## `NationalSpire.AiService.ProcessGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string>?) — public static async Task ProcessGroupAsync(Func<CareerData?> current, Action<CareerData> save, string group, Action<string>? progress = null)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.Coop.CoopCoordinator.StartGroup(ulong, NationalSpire.Coop.CoopCommand)`](Coop/CoopGroupChats.cs.md#symbol-83d332761336)

**调用：** [`NationalSpire.AiRequestQueue.Configure(int)`](AiRequestQueue.cs.md#symbol-7bf81d36c27d)；[`NationalSpire.AiService.EnterPrivateQueue(NationalSpire.CareerData, string, System.Threading.CancellationToken)`](AiPrivateMessages.cs.md#symbol-d73b189170eb)；[`NationalSpire.AiService.FailureReason(System.Exception)`](AiService.cs.md#symbol-a50bcbf6dda5)；[`NationalSpire.AiService.GroupKey(NationalSpire.CareerData, string)`](AiGroupChats.cs.md#symbol-ed8efb8958b5)；[`NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string)`](AiPrivateMessages.cs.md#symbol-4da425dc52d5)；[`NationalSpire.AiService.SummarizeGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, string)`](AiGroupChats.cs.md#symbol-1e6e737dbe88)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；[`NationalSpire.GroupArbitration.Apply(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn, string)`](GroupArbitration.cs.md#symbol-112723169c3a)；[`NationalSpire.GroupArbitration.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`](GroupArbitration.cs.md#symbol-af12ffcc2740)；[`NationalSpire.GroupChat.Resolve(string)`](GroupChatData.cs.md#symbol-970525ff4872)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-c362351c7a43)；[`NationalSpire.GroupChats.SpeechUnavailable(NationalSpire.CareerData, NationalSpire.GroupChat, string)`](GroupChats.cs.md#symbol-77b18ea82814)；[`NationalSpire.GroupInteractions.Apply(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn, System.Collections.Generic.IEnumerable<System.Collections.Generic.Dictionary<string, string>>)`](GroupInteractions.cs.md#symbol-2b413a511485)；[`NationalSpire.GroupStreamParser.Feed(string)`](GroupStreamParser.cs.md#symbol-9d7375d651fe)；[`NationalSpire.GroupStreamParser.Finish()`](GroupStreamParser.cs.md#symbol-4f31ed556cc9)；[`Notify()`](AiGroupChats.cs.md#symbol-57c976501a7f)；`NationalSpire.GroupEntry.GroupEntry()`；`NationalSpire.GroupStreamParser.GroupStreamParser()`；`string.Trim()`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）；`System.InvalidOperationException.InvalidOperationException(string?)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Math.Clamp(int, int, int)`；`System.Text.StringBuilder.Append(string?)`；`System.Text.StringBuilder.StringBuilder()`；`System.Text.StringBuilder.ToString()`；`System.Threading.CancellationToken.ThrowIfCancellationRequested()`；`System.Threading.CancellationTokenSource.CancellationTokenSource(System.TimeSpan)`；`System.TimeSpan.FromMinutes(long)`

**字段、属性、事件及方法组引用：** `<anonymous type: string group, string turn, string error>.error`；`<anonymous type: string group, string turn, string error>.turn`；`<anonymous type: string group, string turn, string[] speakers, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>> interactions, string error>.error`；`<anonymous type: string group, string turn, string[] speakers, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>> interactions, string error>.interactions`；`<anonymous type: string group, string turn, string[] speakers, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>> interactions, string error>.speakers`；`<anonymous type: string group, string turn, string[] speakers, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>> interactions, string error>.turn`；`NationalSpire.AiOptions.Enabled`；`NationalSpire.AiOptions.MaxConcurrentRequests`；`NationalSpire.AiOptions.RequestTimeoutMinutes`；`NationalSpire.AiRequestQueue.Configure(int)`；`NationalSpire.AiService.EnterPrivateQueue(NationalSpire.CareerData, string, System.Threading.CancellationToken)`；`NationalSpire.AiService.FailureReason(System.Exception)`；`NationalSpire.AiService.GroupKey(NationalSpire.CareerData, string)`；`NationalSpire.AiService.GroupLive`；`NationalSpire.AiService.GroupReasoningLive`；`NationalSpire.AiService.GroupRequests`；`NationalSpire.AiService.PrivateForegroundQueue`；`NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string)`；`NationalSpire.AiService.SummarizeGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, string)`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerData.Chats`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.Diagnostics.Record(string, object)`；`NationalSpire.GroupArbitration.Apply(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn, string)`；`NationalSpire.GroupArbitration.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Resolve(string)`；`NationalSpire.GroupChat.Revision`；`NationalSpire.GroupChat.Turns`；`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`；`NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`；`NationalSpire.GroupChats.SpeechUnavailable(NationalSpire.CareerData, NationalSpire.GroupChat, string)`；`NationalSpire.GroupEntry.Author`；`NationalSpire.GroupEntry.Day`；`NationalSpire.GroupEntry.Order`；`NationalSpire.GroupEntry.Text`；`NationalSpire.GroupEntry.TurnId`；`NationalSpire.GroupInteractions.Apply(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn, System.Collections.Generic.IEnumerable<System.Collections.Generic.Dictionary<string, string>>)`；`NationalSpire.GroupStreamParser.Actions`；`NationalSpire.GroupStreamParser.Error`；`NationalSpire.GroupStreamParser.Feed(string)`；`NationalSpire.GroupStreamParser.Finish()`；`NationalSpire.GroupStreamParser.Messages`；`NationalSpire.GroupStreamParser.Speech.Author`；`NationalSpire.GroupStreamParser.Speech.Body`；`NationalSpire.GroupTurn.ArbitrationTargets`；`NationalSpire.GroupTurn.Day`；`NationalSpire.GroupTurn.Error`；`NationalSpire.GroupTurn.Id`；`NationalSpire.GroupTurn.Notices`；`NationalSpire.GroupTurn.Raw`；`NationalSpire.GroupTurn.Reasoning`；`NationalSpire.GroupTurn.Replies`；`NationalSpire.GroupTurn.SpeechOrders`；`NationalSpire.GroupTurn.Status`；`NationalSpire.PrivateStreamParser.Directives`；`Notify()`；`Reasoning(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiRequestQueue.Configure(int)`；输入表达式：`PrivateForegroundQueue.Configure(d.Ai.MaxConcurrentRequests)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateForegroundQueue.Configure(d.Ai.MaxConcurrentRequests);`
- `NationalSpire.AiService.EnterPrivateQueue(NationalSpire.CareerData, string, System.Threading.CancellationToken)`；输入表达式：`EnterPrivateQueue(d, key, cancel.Token)`；返回值紧邻使用处：`AwaitExpressionSyntax: await EnterPrivateQueue(d, key, cancel.Token)`
- `NationalSpire.AiService.FailureReason(System.Exception)`；输入表达式：`FailureReason(e)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: error = FailureReason(e)`
- `NationalSpire.AiService.FailureReason(System.Exception)`；输入表达式：`FailureReason(e)`；返回值紧邻使用处：`ConditionalExpressionSyntax: e is OperationCanceledException ? "回复中断，交互未执行，可以重试。" : FailureReason(e)`
- `NationalSpire.AiService.GroupKey(NationalSpire.CareerData, string)`；输入表达式：`GroupKey(d, group)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GroupKey(d, group)`
- `NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string)`；输入表达式：`RequestPrivateAsync(d.Ai, GroupArbitration.Compose(d, g, turn), false, null, cancel.Token, Reasoning, context: "group/" + group + "/" + id, task: "arbitration")`；返回值紧邻使用处：`AwaitExpressionSyntax: await RequestPrivateAsync(d.Ai, GroupArbitration.Compose(d, g, turn), false, null, cancel.Token, Reasoning, context: "group/" + group + "/" + id, task: "arbitration")`
- `NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string)`；输入表达式：`RequestPrivateAsync(d.Ai, messages, true, chunk =>              {                  raw.Append(chunk); parser.Feed(chunk); GroupLive[key] = raw.ToString();                  if (parser.Messages.Count > turn.SpeechOrders.Count)                  {                      var latest = current(); var active = latest?.Chats.Groups.FirstOrDefault(x => x.Id == group)?.Turns.FirstOrDefault(x => x.Id == id);                      if (latest != null && active != null)                      {                          while (active.SpeechOrders.Count < parser.Messages.Count) active.SpeechOrders.Add(GroupChats.NextOrder(latest));                          turn.SpeechOrders = active.SpeechOrders.ToList(); save(latest);                      }                  }                  if ((DateTime.UtcNow - sent).TotalMilliseconds >= 100) { sent = DateTime.UtcNow; Notify(); }              }, cancel.Token, Reasoning, context: "group/" + group + "/" + id, task: "group")`；返回值紧邻使用处：`AwaitExpressionSyntax: await RequestPrivateAsync(d.Ai, messages, true, chunk =>              {                  raw.Append(chunk); parser.Feed(chunk); GroupLive[key] = raw.ToString();                  if (parser.Messages.Count > turn.SpeechOrders.Count)                  {                      var latest = current(); var active = latest?.Chats.Groups.FirstOrDefault(x => x.Id == group)?.Turns.FirstOrDefault(x => x.Id == id);                      if (latest != null && active != null)                      {                          while (active.SpeechOrders.Count < parser.Messages.Count) active.SpeechOrders.Add(GroupChats.NextOrder(latest));                          turn.SpeechOrders = active.SpeechOrders.ToList(); save(latest);                      }                  }                  if ((DateTime.UtcNow - sent).TotalMilliseconds >= 100) { sent = DateTime.UtcNow; Notify(); }              }, cancel.Token, Reasoning, context: "group/" + group + "/" + id, task: "group")`
- `NationalSpire.AiService.SummarizeGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, string)`；输入表达式：`SummarizeGroupAsync(current, save, group)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = SummarizeGroupAsync(current, save, group)`
- `NationalSpire.AiService.SummarizeGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, string)`；输入表达式：`SummarizeGroupAsync(current, save, group)`；返回值紧邻使用处：`AwaitExpressionSyntax: await SummarizeGroupAsync(current, save, group)`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("group.failed", new { group, turn = id, error = FailureReason(e) })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("group.failed", new { group, turn = id, error = FailureReason(e) });`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("group.parsed", new { group, turn = id, speakers = parser.Messages.Select(s => s.Author).ToArray(), interactions = parser.Actions.Directives, error = parser.Error })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("group.parsed", new { group, turn = id, speakers = parser.Messages.Select(s => s.Author).ToArray(), interactions = parser.Actions.Directives, error = parser.Error });`
- `NationalSpire.GroupArbitration.Apply(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn, string)`；输入表达式：`GroupArbitration.Apply(d, g, turn, verdict)`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupArbitration.Apply(d, g, turn, verdict);`
- `NationalSpire.GroupArbitration.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`；输入表达式：`GroupArbitration.Compose(d, g, turn)`；返回值紧邻使用处：`ArgumentSyntax: GroupArbitration.Compose(d, g, turn)`
- `NationalSpire.GroupChat.Resolve(string)`；输入表达式：`g.Resolve(speech.Author)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = g.Resolve(speech.Author)`
- `NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`；输入表达式：`GroupChatPrompts.Compose(d, g, turn)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GroupChatPrompts.Compose(d, g, turn)`
- `NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`；输入表达式：`GroupChats.NextOrder(d)`；返回值紧邻使用处：`ConditionalExpressionSyntax: speechIndex < turn.SpeechOrders.Count ? turn.SpeechOrders[speechIndex] : GroupChats.NextOrder(d)`
- `NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`；输入表达式：`GroupChats.NextOrder(latest)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.NextOrder(latest)`
- `NationalSpire.GroupChats.SpeechUnavailable(NationalSpire.CareerData, NationalSpire.GroupChat, string)`；输入表达式：`GroupChats.SpeechUnavailable(d, g, author)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GroupChats.SpeechUnavailable(d, g, author)`
- `NationalSpire.GroupEntry.GroupEntry()`；输入表达式：`new() { Author = author, Text = text, Day = turn.Day, Order = speechIndex < turn.SpeechOrders.Count ? turn.SpeechOrders[speechIndex] : GroupChats.NextOrder(d), TurnId = turn.Id }`；返回值紧邻使用处：`ArgumentSyntax: new() { Author = author, Text = text, Day = turn.Day, Order = speechIndex < turn.SpeechOrders.Count ? turn.SpeechOrders[speechIndex] : GroupChats.NextOrder(d), TurnId = turn.Id }`
- `NationalSpire.GroupInteractions.Apply(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn, System.Collections.Generic.IEnumerable<System.Collections.Generic.Dictionary<string, string>>)`；输入表达式：`GroupInteractions.Apply(d, g, turn, parser.Actions.Directives)`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupInteractions.Apply(d, g, turn, parser.Actions.Directives);`
- `NationalSpire.GroupStreamParser.Feed(string)`；输入表达式：`parser.Feed(chunk)`；返回值紧邻使用处：`ExpressionStatementSyntax: parser.Feed(chunk);`
- `NationalSpire.GroupStreamParser.Finish()`；输入表达式：`parser.Finish()`；返回值紧邻使用处：`ExpressionStatementSyntax: parser.Finish();`
- `NationalSpire.GroupStreamParser.GroupStreamParser()`；输入表达式：`new GroupStreamParser()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GroupStreamParser()`
- `Notify()`；输入表达式：`Notify()`；返回值紧邻使用处：`ExpressionStatementSyntax: Notify();`
- `string.Trim()`；输入表达式：`speech.Body.ToString().Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = speech.Body.ToString().Trim()`
- `System.Action<T>.Invoke(T)`；输入表达式：`save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: save(d);`
- `System.Action<T>.Invoke(T)`；输入表达式：`save(latest)`；返回值紧邻使用处：`ExpressionStatementSyntax: save(latest);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`GroupRequests.ContainsKey(key)`；返回值紧邻使用处：`IfStatementSyntax: if (GroupRequests.ContainsKey(key)) return;`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`GroupLive.Remove(key)`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupLive.Remove(key);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`GroupReasoningLive.Remove(key)`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupReasoningLive.Remove(key);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`GroupRequests.Remove(key)`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupRequests.Remove(key);`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Chats.Groups.FirstOrDefault(g => g.Id == group)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: d?.Chats.Groups.FirstOrDefault(g => g.Id == group)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Chats.Groups.FirstOrDefault(x => x.Id == group)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .Chats.Groups.FirstOrDefault(x => x.Id == group)?.Turns.FirstOrDefault(x => x.Id == id)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Chats.Groups.FirstOrDefault(x => x.Id == group)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: d?.Chats.Groups.FirstOrDefault(x => x.Id == group)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Turns.FirstOrDefault(t => t.Status == "queued")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: g?.Turns.FirstOrDefault(t => t.Status == "queued")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Turns.FirstOrDefault(x => x.Id == id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .Chats.Groups.FirstOrDefault(x => x.Id == group)?.Turns.FirstOrDefault(x => x.Id == id)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Turns.FirstOrDefault(x => x.Id == id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: g?.Turns.FirstOrDefault(x => x.Id == id)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`parser.Messages.Select(s => s.Author)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parser.Messages.Select(s => s.Author).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`parser.Messages.Select(s => s.Author).ToArray()`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: speakers = parser.Messages.Select(s => s.Author).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`active.SpeechOrders.ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: turn.SpeechOrders = active.SpeechOrders.ToList()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`active.SpeechOrders.Add(GroupChats.NextOrder(latest))`；返回值紧邻使用处：`ExpressionStatementSyntax: active.SpeechOrders.Add(GroupChats.NextOrder(latest));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`turn.Notices.Add("一条发言未发送：" + unavailable)`；返回值紧邻使用处：`ExpressionStatementSyntax: turn.Notices.Add("一条发言未发送：" + unavailable);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`turn.Replies.Add(new() { Author = author, Text = text, Day = turn.Day, Order = speechIndex < turn.SpeechOrders.Count ? turn.SpeechOrders[speechIndex] : GroupChats.NextOrder(d), TurnId = turn.Id })`；返回值紧邻使用处：`ExpressionStatementSyntax: turn.Replies.Add(new() { Author = author, Text = text, Day = turn.Day, Order = speechIndex < turn.SpeechOrders.Count ? turn.SpeechOrders[speechIndex] : GroupChats.NextOrder(d), TurnId = turn.Id });`
- `System.Func<TResult>.Invoke()`；输入表达式：`current()`；返回值紧邻使用处：`AssignmentExpressionSyntax: d = current()`
- `System.Func<TResult>.Invoke()`；输入表达式：`current()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = current()`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("请先启用 AI。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("请先启用 AI。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("没有返回可识别的群聊消息，请重试。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("没有返回可识别的群聊消息，请重试。");`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(d.Ai.RequestTimeoutMinutes, 2, 30)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(d.Ai.RequestTimeoutMinutes, 2, 30)`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`raw.Append(chunk)`；返回值紧邻使用处：`ExpressionStatementSyntax: raw.Append(chunk);`
- `System.Text.StringBuilder.StringBuilder()`；输入表达式：`new StringBuilder()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StringBuilder()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`raw.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: GroupLive[key] = raw.ToString()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`raw.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: turn.Raw = raw.ToString()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`reasoning.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: turn.Reasoning = reasoning.ToString()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`speech.Body.ToString()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: speech.Body.ToString().Trim`
- `System.Threading.CancellationToken.ThrowIfCancellationRequested()`；输入表达式：`cancel.Token.ThrowIfCancellationRequested()`；返回值紧邻使用处：`ExpressionStatementSyntax: cancel.Token.ThrowIfCancellationRequested();`
- `System.Threading.CancellationTokenSource.CancellationTokenSource(System.TimeSpan)`；输入表达式：`new CancellationTokenSource(TimeSpan.FromMinutes(Math.Clamp(d.Ai.RequestTimeoutMinutes, 2, 30)))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CancellationTokenSource(TimeSpan.FromMinutes(Math.Clamp(d.Ai.RequestTimeoutMinutes, 2, 30)))`
- `System.TimeSpan.FromMinutes(long)`；输入表达式：`TimeSpan.FromMinutes(Math.Clamp(d.Ai.RequestTimeoutMinutes, 2, 30))`；返回值紧邻使用处：`ArgumentSyntax: TimeSpan.FromMinutes(Math.Clamp(d.Ai.RequestTimeoutMinutes, 2, 30))`

**赋值（含属性/字段和局部值）：**

- `_` = `SummarizeGroupAsync(current, save, group)`
- `Author` = `author`
- `d` = `current()`
- `Day` = `turn.Day`
- `g` = `d?.Chats.Groups.FirstOrDefault(x => x.Id == group)`
- `GroupLive[key]` = `raw.ToString()`
- `GroupRequests[key]` = `cancel`
- `Order` = `speechIndex < turn.SpeechOrders.Count ? turn.SpeechOrders[speechIndex] : GroupChats.NextOrder(d)`
- `sent` = `DateTime.UtcNow`
- `Text` = `text`
- `turn.Error` = `e is OperationCanceledException ? "回复中断，交互未执行，可以重试。" : FailureReason(e)`
- `turn.Error` = `parser.Error`
- `turn.Raw` = `raw.ToString()`
- `turn.Reasoning` = `reasoning.ToString()`
- `turn.SpeechOrders` = `active.SpeechOrders.ToList()`
- `turn.Status` = `"complete"`
- `turn.Status` = `"failed"`
- `turn.Status` = `"sending"`
- `turn` = `g?.Turns.FirstOrDefault(x => x.Id == id)`
- `TurnId` = `turn.Id`

<a id="symbol-0f0a8c9e68b3"></a>

## `Reasoning(string) — void Reasoning(string chunk)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`Notify()`](AiGroupChats.cs.md#symbol-57c976501a7f)；`System.Text.StringBuilder.Append(string?)`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.GroupReasoningLive`；`Notify()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Notify()`；输入表达式：`Notify()`；返回值紧邻使用处：`ExpressionStatementSyntax: Notify();`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`reasoning.Append(chunk)`；返回值紧邻使用处：`ExpressionStatementSyntax: reasoning.Append(chunk);`
- `System.Text.StringBuilder.ToString()`；输入表达式：`reasoning.ToString()`；返回值紧邻使用处：`ArgumentSyntax: reasoning.ToString()`

**赋值（含属性/字段和局部值）：**

- `GroupReasoningLive[key]` = `(id, reasoning.ToString())`
- `sent` = `DateTime.UtcNow`

<a id="symbol-57c976501a7f"></a>

## `Notify() — void Notify()`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string>?)`](AiGroupChats.cs.md#symbol-caddadc35a6b)；[`Reasoning(string)`](AiGroupChats.cs.md#symbol-0f0a8c9e68b3)

**调用：** [`NationalSpire.AiService.FailureReason(System.Exception)`](AiService.cs.md#symbol-a50bcbf6dda5)；[`NationalSpire.Diagnostics.Record(string, object)`](Diagnostics.cs.md#symbol-1b5632793cd0)；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `<anonymous type: string group, string turn, string error>.error`；`<anonymous type: string group, string turn, string error>.turn`；`NationalSpire.AiService.FailureReason(System.Exception)`；`NationalSpire.Diagnostics.Record(string, object)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.FailureReason(System.Exception)`；输入表达式：`FailureReason(e)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: error = FailureReason(e)`
- `NationalSpire.Diagnostics.Record(string, object)`；输入表达式：`Diagnostics.Record("group.delivery.failed", new { group, turn = id, error = FailureReason(e) })`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.Record("group.delivery.failed", new { group, turn = id, error = FailureReason(e) });`
- `System.Action<T>.Invoke(T)`；输入表达式：`.Invoke(raw.ToString())`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: progress?.Invoke(raw.ToString())`
- `System.Text.StringBuilder.ToString()`；输入表达式：`raw.ToString()`；返回值紧邻使用处：`ArgumentSyntax: raw.ToString()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1e6e737dbe88"></a>

## `NationalSpire.AiService.SummarizeGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, string) — public static async Task SummarizeGroupAsync(Func<CareerData?> current, Action<CareerData> save, string group, string manual = "")`

来源：源码第 98 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string>?)`](AiGroupChats.cs.md#symbol-caddadc35a6b)；[`NationalSpire.CareerScreen.GroupCommand(string, NationalSpire.GroupCommand, System.Action?)`](GroupChatScreen.cs.md#symbol-9f2d53ad7587)；[`NationalSpire.Coop.CoopCoordinator.StartGroup(ulong, NationalSpire.Coop.CoopCommand)`](Coop/CoopGroupChats.cs.md#symbol-83d332761336)

**调用：** [`NationalSpire.AiService.FailureReason(System.Exception)`](AiService.cs.md#symbol-a50bcbf6dda5)；[`NationalSpire.AiService.GroupKey(NationalSpire.CareerData, string)`](AiGroupChats.cs.md#symbol-ed8efb8958b5)；[`NationalSpire.AiService.SummaryRequest(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, string)`](AiPrivateMessages.cs.md#symbol-1b3123f418a5)；[`NationalSpire.GroupChatPrompts.InteractionContext(NationalSpire.CareerData, NationalSpire.GroupChat, int, string, string)`](GroupChatPrompts.cs.md#symbol-ccc55b5e837d)；[`NationalSpire.GroupChatPrompts.Section(NationalSpire.CareerData, string)`](GroupChatPrompts.cs.md#symbol-faefbd7982b5)；[`NationalSpire.GroupChatPrompts.UserText(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`](GroupChatPrompts.cs.md#symbol-28b2a2534bee)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；[`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`](PrivateAppointments.cs.md#symbol-1c549626b284)；`NationalSpire.PrivateSummary.PrivateSummary()`；`string.IsNullOrWhiteSpace(string?)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.HashSet<T>.Remove(T)`；`System.Collections.Generic.IEnumerable<long>.Max()`；`System.Collections.Generic.IEnumerable<long>.Min()`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Max<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.Min<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.FindLastIndex(System.Predicate<T>)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `<anonymous type: string 群聊, System.Collections.Generic.IEnumerable<<anonymous type: string 日期, string 玩家, string 消息, System.Collections.Generic.IEnumerable<<anonymous type: string 姓名, string 内容>> 发言, System.Collections.Generic.IEnumerable<string> 变化, System.Collections.Generic.IEnumerable<string> 交互>> 聊天, System.Collections.Generic.IEnumerable<<anonymous type: string 日期, string Text>> 成员变化>.成员变化`；`<anonymous type: string 群聊, System.Collections.Generic.IEnumerable<<anonymous type: string 日期, string 玩家, string 消息, System.Collections.Generic.IEnumerable<<anonymous type: string 姓名, string 内容>> 发言, System.Collections.Generic.IEnumerable<string> 变化, System.Collections.Generic.IEnumerable<string> 交互>> 聊天, System.Collections.Generic.IEnumerable<<anonymous type: string 日期, string Text>> 成员变化>.聊天`；`<anonymous type: string 群聊, System.Collections.Generic.IEnumerable<<anonymous type: string 日期, string 玩家, string 消息, System.Collections.Generic.IEnumerable<<anonymous type: string 姓名, string 内容>> 发言, System.Collections.Generic.IEnumerable<string> 变化, System.Collections.Generic.IEnumerable<string> 交互>> 聊天, System.Collections.Generic.IEnumerable<<anonymous type: string 日期, string Text>> 成员变化>.群聊`；`<anonymous type: string 日期, string 玩家, string 消息, System.Collections.Generic.IEnumerable<<anonymous type: string 姓名, string 内容>> 发言, System.Collections.Generic.IEnumerable<string> 变化, System.Collections.Generic.IEnumerable<string> 交互>.变化`；`<anonymous type: string 日期, string 玩家, string 消息, System.Collections.Generic.IEnumerable<<anonymous type: string 姓名, string 内容>> 发言, System.Collections.Generic.IEnumerable<string> 变化, System.Collections.Generic.IEnumerable<string> 交互>.发言`；`<anonymous type: string 日期, string 玩家, string 消息, System.Collections.Generic.IEnumerable<<anonymous type: string 姓名, string 内容>> 发言, System.Collections.Generic.IEnumerable<string> 变化, System.Collections.Generic.IEnumerable<string> 交互>.交互`；`<anonymous type: string 日期, string 玩家, string 消息, System.Collections.Generic.IEnumerable<<anonymous type: string 姓名, string 内容>> 发言, System.Collections.Generic.IEnumerable<string> 变化, System.Collections.Generic.IEnumerable<string> 交互>.日期`；`<anonymous type: string 日期, string 玩家, string 消息, System.Collections.Generic.IEnumerable<<anonymous type: string 姓名, string 内容>> 发言, System.Collections.Generic.IEnumerable<string> 变化, System.Collections.Generic.IEnumerable<string> 交互>.玩家`；`<anonymous type: string 日期, string 玩家, string 消息, System.Collections.Generic.IEnumerable<<anonymous type: string 姓名, string 内容>> 发言, System.Collections.Generic.IEnumerable<string> 变化, System.Collections.Generic.IEnumerable<string> 交互>.消息`；`<anonymous type: string 日期, string Text>.日期`；`<anonymous type: string 姓名, string 内容>.内容`；`<anonymous type: string 姓名, string 内容>.姓名`；`NationalSpire.AiService.FailureReason(System.Exception)`；`NationalSpire.AiService.GroupKey(NationalSpire.CareerData, string)`；`NationalSpire.AiService.GroupSummaries`；`NationalSpire.AiService.Json`；`NationalSpire.AiService.SummaryRequest(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, string)`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerData.Chats`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.GroupChat.BigSummaries`；`NationalSpire.GroupChat.Entries`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Name`；`NationalSpire.GroupChat.Revision`；`NationalSpire.GroupChat.Settings`；`NationalSpire.GroupChat.SmallSummaries`；`NationalSpire.GroupChat.SummarizedThrough`；`NationalSpire.GroupChat.SummaryError`；`NationalSpire.GroupChat.SummaryStatus`；`NationalSpire.GroupChat.Turns`；`NationalSpire.GroupChatPrompts.InteractionContext(NationalSpire.CareerData, NationalSpire.GroupChat, int, string, string)`；`NationalSpire.GroupChatPrompts.Section(NationalSpire.CareerData, string)`；`NationalSpire.GroupChatPrompts.UserText(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.GroupEffect.Person`；`NationalSpire.GroupEffect.Text`；`NationalSpire.GroupEffect.Turn`；`NationalSpire.GroupEntry.Author`；`NationalSpire.GroupEntry.Day`；`NationalSpire.GroupEntry.Order`；`NationalSpire.GroupEntry.Text`；`NationalSpire.GroupHistorySettings.MergeOldest`；`NationalSpire.GroupHistorySettings.SmallSummaryLimit`；`NationalSpire.GroupHistorySettings.SummaryEvery`；`NationalSpire.GroupTurn.Day`；`NationalSpire.GroupTurn.Effects`；`NationalSpire.GroupTurn.Notices`；`NationalSpire.GroupTurn.Order`；`NationalSpire.GroupTurn.Replies`；`NationalSpire.GroupTurn.Sender`；`NationalSpire.GroupTurn.Status`；`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；`NationalSpire.PrivateSummary.From`；`NationalSpire.PrivateSummary.Id`；`NationalSpire.PrivateSummary.Text`；`NationalSpire.PrivateSummary.Through`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.FailureReason(System.Exception)`；输入表达式：`FailureReason(e)`；返回值紧邻使用处：`BinaryExpressionSyntax: "总结未完成，下次回复后重试：" + FailureReason(e)`
- `NationalSpire.AiService.GroupKey(NationalSpire.CareerData, string)`；输入表达式：`GroupKey(d, group)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GroupKey(d, group)`
- `NationalSpire.AiService.SummaryRequest(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, string)`；输入表达式：`SummaryRequest(d.Ai, [new() { ["role"] = "system", ["content"] = GroupChatPrompts.Section(d, "group-long-summary") }, new() { ["role"] = "user", ["content"] = string.Join("\n\n", selected.Select(s => s.Text)) }], "group-summary")`；返回值紧邻使用处：`AwaitExpressionSyntax: await SummaryRequest(d.Ai, [new() { ["role"] = "system", ["content"] = GroupChatPrompts.Section(d, "group-long-summary") }, new() { ["role"] = "user", ["content"] = string.Join("\n\n", selected.Select(s => s.Text)) }], "group-summary")`
- `NationalSpire.AiService.SummaryRequest(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, string)`；输入表达式：`SummaryRequest(d.Ai, [new() { ["role"] = "system", ["content"] = GroupChatPrompts.Section(d, "group-summary") }, new() { ["role"] = "user", ["content"] = source }], "group-summary")`；返回值紧邻使用处：`AwaitExpressionSyntax: await SummaryRequest(d.Ai, [new() { ["role"] = "system", ["content"] = GroupChatPrompts.Section(d, "group-summary") }, new() { ["role"] = "user", ["content"] = source }], "group-summary")`
- `NationalSpire.GroupChatPrompts.InteractionContext(NationalSpire.CareerData, NationalSpire.GroupChat, int, string, string)`；输入表达式：`GroupChatPrompts.InteractionContext(d, g, 0, turnId: e.Turn)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: e => GroupChatPrompts.InteractionContext(d, g, 0, turnId: e.Turn)`
- `NationalSpire.GroupChatPrompts.Section(NationalSpire.CareerData, string)`；输入表达式：`GroupChatPrompts.Section(d, "group-long-summary")`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["content"] = GroupChatPrompts.Section(d, "group-long-summary")`
- `NationalSpire.GroupChatPrompts.Section(NationalSpire.CareerData, string)`；输入表达式：`GroupChatPrompts.Section(d, "group-summary")`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["content"] = GroupChatPrompts.Section(d, "group-summary")`
- `NationalSpire.GroupChatPrompts.UserText(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`；输入表达式：`GroupChatPrompts.UserText(d, g, t)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: 消息 = GroupChatPrompts.UserText(d, g, t)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, e.Person)`；返回值紧邻使用处：`BinaryExpressionSyntax: GroupChats.Name(d, e.Person) + "："`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, r.Author)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: 姓名 = GroupChats.Name(d, r.Author)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, t.Sender)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: 玩家 = GroupChats.Name(d, t.Sender)`
- `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；输入表达式：`PrivateAppointments.DateText(d, e.Day)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: 日期 = PrivateAppointments.DateText(d, e.Day)`
- `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；输入表达式：`PrivateAppointments.DateText(d, t.Day)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: 日期 = PrivateAppointments.DateText(d, t.Day)`
- `NationalSpire.PrivateSummary.PrivateSummary()`；输入表达式：`new() { From = from, Through = end, Text = text }`；返回值紧邻使用处：`ArgumentSyntax: new() { From = from, Through = end, Text = text }`
- `NationalSpire.PrivateSummary.PrivateSummary()`；输入表达式：`new() { From = selected.Min(s => s.From), Through = selected.Max(s => s.Through), Text = text }`；返回值紧邻使用处：`ArgumentSyntax: new() { From = selected.Min(s => s.From), Through = selected.Max(s => s.Through), Text = text }`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(text)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(text)) throw new InvalidDataException("群聊长期总结为空。");`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(text)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(text)) throw new InvalidDataException("群聊总结为空。");`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n\n", selected.Select(s => s.Text))`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["content"] = string.Join("\n\n", selected.Select(s => s.Text))`
- `System.Action<T>.Invoke(T)`；输入表达式：`save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: save(d);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new() { ["role"] = "system", ["content"] = GroupChatPrompts.Section(d, "group-long-summary") }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { ["role"] = "system", ["content"] = GroupChatPrompts.Section(d, "group-long-summary") }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new() { ["role"] = "system", ["content"] = GroupChatPrompts.Section(d, "group-summary") }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { ["role"] = "system", ["content"] = GroupChatPrompts.Section(d, "group-summary") }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new() { ["role"] = "user", ["content"] = source }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { ["role"] = "user", ["content"] = source }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new() { ["role"] = "user", ["content"] = string.Join("\n\n", selected.Select(s => s.Text)) }`；返回值紧邻使用处：`ExpressionElementSyntax: new() { ["role"] = "user", ["content"] = string.Join("\n\n", selected.Select(s => s.Text)) }`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`GroupSummaries.Add(key)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GroupSummaries.Add(key)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`ids.Contains(s.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: s => ids.Contains(s.Id)`
- `System.Collections.Generic.HashSet<T>.Remove(T)`；输入表达式：`GroupSummaries.Remove(key)`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupSummaries.Remove(key);`
- `System.Collections.Generic.IEnumerable<long>.Max()`；输入表达式：`g.Turns.Take(end).SelectMany(t => t.Replies.Select(r => r.Order).Append(t.Order)).DefaultIfEmpty(0).Max()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = g.Turns.Take(end).SelectMany(t => t.Replies.Select(r => r.Order).Append(t.Order)).DefaultIfEmpty(0).Max()`
- `System.Collections.Generic.IEnumerable<long>.Min()`；输入表达式：`g.Turns.Skip(from).Take(end - from).Select(t => t.Order).DefaultIfEmpty(0).Min()`；返回值紧邻使用处：`ConditionalExpressionSyntax: from == 0 ? 0 : g.Turns.Skip(from).Take(end - from).Select(t => t.Order).DefaultIfEmpty(0).Min()`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`t.Replies.Select(r => r.Order).Append(t.Order)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: t => t.Replies.Select(r => r.Order).Append(t.Order)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`t.Effects.Where(e => e.Text.Length > 0).Select(e => GroupChats.Name(d, e.Person) + "：" + e.Text).Concat(t.Notices)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: 变化 = t.Effects.Where(e => e.Text.Length > 0).Select(e => GroupChats.Name(d, e.Person) + "：" + e.Text).Concat(t.Notices)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Turns.Skip(from).Count(t => t.Status == "complete")`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Turns.Skip(from).Count(t => t.Status == "complete") >= g.Settings.SummaryEvery`
- `System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；输入表达式：`g.Turns.Skip(from).Take(end - from).Select(t => t.Order).DefaultIfEmpty(0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Turns.Skip(from).Take(end - from).Select(t => t.Order).DefaultIfEmpty(0).Min`
- `System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；输入表达式：`g.Turns.Take(end).SelectMany(t => t.Replies.Select(r => r.Order).Append(t.Order)).DefaultIfEmpty(0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Turns.Take(end).SelectMany(t => t.Replies.Select(r => r.Order).Append(t.Order)).DefaultIfEmpty(0).Max`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Chats.Groups.FirstOrDefault(g => g.Id == group)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: d?.Chats.Groups.FirstOrDefault(g => g.Id == group)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Chats.Groups.FirstOrDefault(x => x.Id == group)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: d?.Chats.Groups.FirstOrDefault(x => x.Id == group)`
- `System.Collections.Generic.IEnumerable<TSource>.Max<TSource>(System.Func<TSource, int>)`；输入表达式：`selected.Max(s => s.Through)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Through = selected.Max(s => s.Through)`
- `System.Collections.Generic.IEnumerable<TSource>.Min<TSource>(System.Func<TSource, int>)`；输入表达式：`selected.Min(s => s.From)`；返回值紧邻使用处：`AssignmentExpressionSyntax: From = selected.Min(s => s.From)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`g.Entries.Where(e => e.Order >= first && e.Order <= last).Select(e => new { 日期 = PrivateAppointments.DateText(d, e.Day), e.Text })`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: 成员变化 = g.Entries.Where(e => e.Order >= first && e.Order <= last).Select(e => new { 日期 = PrivateAppointments.DateText(d, e.Day), e.Text })`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`g.Turns.Skip(from).Take(end - from).Select(t => t.Order)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Turns.Skip(from).Take(end - from).Select(t => t.Order).DefaultIfEmpty`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`g.Turns.Skip(from).Take(end - from).Where(t => t.Status == "complete").Select(t => new                  {                      日期 = PrivateAppointments.DateText(d, t.Day), 玩家 = GroupChats.Name(d, t.Sender), 消息 = GroupChatPrompts.UserText(d, g, t),                      发言 = t.Replies.Select(r => new { 姓名 = GroupChats.Name(d, r.Author), 内容 = r.Text }),                      变化 = t.Effects.Where(e => e.Text.Length > 0).Select(e => GroupChats.Name(d, e.Person) + "：" + e.Text).Concat(t.Notices),                      交互 = t.Effects.Select(e => GroupChatPrompts.InteractionContext(d, g, 0, turnId: e.Turn)).Where(text => text.Length > 0)                  })`；返回值紧邻使用处：`EqualsValueClauseSyntax: = g.Turns.Skip(from).Take(end - from).Where(t => t.Status == "complete").Select(t => new                  {                      日期 = PrivateAppointments.DateText(d, t.Day), 玩家 = GroupChats.Name(d, t.Sender), 消息 = GroupChatPrompts.UserText(d, g, t),                      发言 = t.Replies.Select(r => new { 姓名 = GroupChats.Name(d, r.Author), 内容 = r.Text }),                      变化 = t.Effects.Where(e => e.Text.Length > 0).Select(e => GroupChats.Name(d, e.Person) + "：" + e.Text).Concat(t.Notices),                      交互 = t.Effects.Select(e => GroupChatPrompts.InteractionContext(d, g, 0, turnId: e.Turn)).Where(text => text.Length > 0)                  })`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`selected.Select(s => s.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: selected.Select(s => s.Id).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`selected.Select(s => s.Text)`；返回值紧邻使用处：`ArgumentSyntax: selected.Select(s => s.Text)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`t.Effects.Select(e => GroupChatPrompts.InteractionContext(d, g, 0, turnId: e.Turn))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: t.Effects.Select(e => GroupChatPrompts.InteractionContext(d, g, 0, turnId: e.Turn)).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`t.Effects.Where(e => e.Text.Length > 0).Select(e => GroupChats.Name(d, e.Person) + "：" + e.Text)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: t.Effects.Where(e => e.Text.Length > 0).Select(e => GroupChats.Name(d, e.Person) + "：" + e.Text).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`t.Replies.Select(r => new { 姓名 = GroupChats.Name(d, r.Author), 内容 = r.Text })`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: 发言 = t.Replies.Select(r => new { 姓名 = GroupChats.Name(d, r.Author), 内容 = r.Text })`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`t.Replies.Select(r => r.Order)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: t.Replies.Select(r => r.Order).Append`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`g.Turns.Take(end).SelectMany(t => t.Replies.Select(r => r.Order).Append(t.Order))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Turns.Take(end).SelectMany(t => t.Replies.Select(r => r.Order).Append(t.Order)).DefaultIfEmpty`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`g.Turns.Skip(from)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Turns.Skip(from).Count`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`g.Turns.Skip(from)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Turns.Skip(from).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`g.SmallSummaries.Take(g.Settings.MergeOldest)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.SmallSummaries.Take(g.Settings.MergeOldest).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`g.Turns.Skip(from).Take(end - from)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Turns.Skip(from).Take(end - from).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`g.Turns.Skip(from).Take(end - from)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Turns.Skip(from).Take(end - from).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`g.Turns.Take(end)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Turns.Take(end).SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`g.SmallSummaries.Take(g.Settings.MergeOldest).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = g.SmallSummaries.Take(g.Settings.MergeOldest).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`selected.Select(s => s.Id).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = selected.Select(s => s.Id).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Entries.Where(e => e.Order >= first && e.Order <= last)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Entries.Where(e => e.Order >= first && e.Order <= last).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Turns.Skip(from).Take(end - from).Where(t => t.Status == "complete")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Turns.Skip(from).Take(end - from).Where(t => t.Status == "complete").Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`t.Effects.Select(e => GroupChatPrompts.InteractionContext(d, g, 0, turnId: e.Turn)).Where(text => text.Length > 0)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: 交互 = t.Effects.Select(e => GroupChatPrompts.InteractionContext(d, g, 0, turnId: e.Turn)).Where(text => text.Length > 0)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`t.Effects.Where(e => e.Text.Length > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: t.Effects.Where(e => e.Text.Length > 0).Select`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`g.BigSummaries.Add(new() { From = selected.Min(s => s.From), Through = selected.Max(s => s.Through), Text = text })`；返回值紧邻使用处：`ExpressionStatementSyntax: g.BigSummaries.Add(new() { From = selected.Min(s => s.From), Through = selected.Max(s => s.Through), Text = text });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`g.SmallSummaries.Add(new() { From = from, Through = end, Text = text })`；返回值紧邻使用处：`ExpressionStatementSyntax: g.SmallSummaries.Add(new() { From = from, Through = end, Text = text });`
- `System.Collections.Generic.List<T>.FindLastIndex(System.Predicate<T>)`；输入表达式：`g.Turns.FindLastIndex(t => t.Status == "complete")`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Turns.FindLastIndex(t => t.Status == "complete") + 1`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`g.SmallSummaries.RemoveAll(s => ids.Contains(s.Id))`；返回值紧邻使用处：`ExpressionStatementSyntax: g.SmallSummaries.RemoveAll(s => ids.Contains(s.Id));`
- `System.Func<TResult>.Invoke()`；输入表达式：`current()`；返回值紧邻使用处：`AssignmentExpressionSyntax: d = current()`
- `System.Func<TResult>.Invoke()`；输入表达式：`current()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = current()`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("群聊长期总结为空。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("群聊长期总结为空。");`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("群聊总结为空。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("群聊总结为空。");`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(new { 群聊 = g.Name, 聊天 = own, 成员变化 = g.Entries.Where(e => e.Order >= first && e.Order <= last).Select(e => new { 日期 = PrivateAppointments.DateText(d, e.Day), e.Text }) }, Json)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonSerializer.Serialize(new { 群聊 = g.Name, 聊天 = own, 成员变化 = g.Entries.Where(e => e.Order >= first && e.Order <= last).Select(e => new { 日期 = PrivateAppointments.DateText(d, e.Day), e.Text }) }, Json)`

**赋值（含属性/字段和局部值）：**

- `["content"]` = `GroupChatPrompts.Section(d, "group-long-summary")`
- `["content"]` = `GroupChatPrompts.Section(d, "group-summary")`
- `["content"]` = `source`
- `["content"]` = `string.Join("\n\n", selected.Select(s => s.Text))`
- `["role"]` = `"system"`
- `["role"]` = `"user"`
- `d` = `current()`
- `From` = `from`
- `From` = `selected.Min(s => s.From)`
- `g.SummarizedThrough` = `end`
- `g.SummaryError` = `""`
- `g.SummaryError` = `"总结未完成，下次回复后重试：" + FailureReason(e)`
- `g.SummaryStatus` = `""`
- `g.SummaryStatus` = `"正在合并长期记忆"`
- `g.SummaryStatus` = `"正在整理聊天记忆"`
- `g` = `d?.Chats.Groups.FirstOrDefault(g => g.Id == group)`
- `g` = `d?.Chats.Groups.FirstOrDefault(x => x.Id == group)`
- `Text` = `text`
- `Through` = `end`
- `Through` = `selected.Max(s => s.Through)`
