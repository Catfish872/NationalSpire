# ChatTranscript.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`AEC67BFB821058F111CFB73FF8C2F99C8BC60F5B17F499B2930C19374C414800`。来源：[源码](../../ChatTranscript.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.ChatTranscript`、`NationalSpire.ChatTranscript.Message`、`NationalSpire.ChatTranscript.Document`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-03037cb1cba8"></a>

## `NationalSpire.ChatTranscript.Private(NationalSpire.CareerData, NationalSpire.PrivateConversation) — public static Document Private(CareerData data, PrivateConversation conversation)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ExportChatTranscript()`](ChatUtilitiesScreen.cs.md#symbol-1bb784a2ab9d)

**调用：** `NationalSpire.ChatTranscript.Document.Document(string, string, string, System.Collections.Generic.List<NationalSpire.ChatTranscript.Message>)`；`NationalSpire.ChatTranscript.Message.Message(string, int, long, string)`；[`NationalSpire.ChatTranscript.Ordered(System.Collections.Generic.IEnumerable<NationalSpire.ChatTranscript.Message>)`](ChatTranscript.cs.md#symbol-30424a778408)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatTranscript.Ordered(System.Collections.Generic.IEnumerable<NationalSpire.ChatTranscript.Message>)`；`NationalSpire.DateSceneRequest.Ending`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessages.VisibleInCommunications(NationalSpire.PrivateTurn)`；`NationalSpire.PrivateTurn.Day`；`NationalSpire.PrivateTurn.ProactiveReason`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.ReplyOrder`；`NationalSpire.PrivateTurn.RequestKind`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.User`；`NationalSpire.PrivateTurn.UserDeleted`；`NationalSpire.PrivateTurn.UserOrder`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatTranscript.Document.Document(string, string, string, System.Collections.Generic.List<NationalSpire.ChatTranscript.Message>)`；输入表达式：`new(GroupChats.Name(data, conversation.PersonId), conversation.PersonId, "私聊", Ordered(messages))`；返回值紧邻使用处：`ReturnStatementSyntax: return new(GroupChats.Name(data, conversation.PersonId), conversation.PersonId, "私聊", Ordered(messages));`
- `NationalSpire.ChatTranscript.Message.Message(string, int, long, string)`；输入表达式：`new(GroupChats.Human(data), turn.Day, turn.UserOrder, turn.User)`；返回值紧邻使用处：`ArgumentSyntax: new(GroupChats.Human(data), turn.Day, turn.UserOrder, turn.User)`
- `NationalSpire.ChatTranscript.Message.Message(string, int, long, string)`；输入表达式：`new(conversation.PersonId, turn.Day, turn.ReplyOrder, turn.Reply)`；返回值紧邻使用处：`ArgumentSyntax: new(conversation.PersonId, turn.Day, turn.ReplyOrder, turn.Reply)`
- `NationalSpire.ChatTranscript.Ordered(System.Collections.Generic.IEnumerable<NationalSpire.ChatTranscript.Message>)`；输入表达式：`Ordered(messages)`；返回值紧邻使用处：`ArgumentSyntax: Ordered(messages)`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(data)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Human(data)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(data, conversation.PersonId)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Name(data, conversation.PersonId)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Turns.Where(PrivateMessages.VisibleInCommunications)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var turn in conversation.Turns.Where(PrivateMessages.VisibleInCommunications)) { if (turn.RequestKind == "event") continue; if (!turn.UserDeleted && turn.ProactiveReason.Length == 0 && turn.Scene?.Ending != true && turn.User.Length > 0) messages.Add(new(GroupChats.Human(data), turn.Day, turn.UserOrder, turn.User)); if (!turn.ReplyDeleted && turn.Reply.Length > 0) messages.Add(new(conversation.PersonId, turn.Day, turn.ReplyOrder, turn.Reply)); }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`messages.Add(new(GroupChats.Human(data), turn.Day, turn.UserOrder, turn.User))`；返回值紧邻使用处：`ExpressionStatementSyntax: messages.Add(new(GroupChats.Human(data), turn.Day, turn.UserOrder, turn.User));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`messages.Add(new(conversation.PersonId, turn.Day, turn.ReplyOrder, turn.Reply))`；返回值紧邻使用处：`ExpressionStatementSyntax: messages.Add(new(conversation.PersonId, turn.Day, turn.ReplyOrder, turn.Reply));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<Message>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<Message>()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f3a90964e01d"></a>

## `NationalSpire.ChatTranscript.Group(NationalSpire.CareerData, NationalSpire.GroupChat) — public static Document Group(CareerData data, GroupChat group)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ExportChatTranscript()`](ChatUtilitiesScreen.cs.md#symbol-1bb784a2ab9d)

**调用：** `NationalSpire.ChatTranscript.Document.Document(string, string, string, System.Collections.Generic.List<NationalSpire.ChatTranscript.Message>)`；`NationalSpire.ChatTranscript.Message.Message(string, int, long, string)`；[`NationalSpire.ChatTranscript.Ordered(System.Collections.Generic.IEnumerable<NationalSpire.ChatTranscript.Message>)`](ChatTranscript.cs.md#symbol-30424a778408)；[`NationalSpire.GroupChat.Resolve(string)`](GroupChatData.cs.md#symbol-970525ff4872)；[`NationalSpire.GroupChats.SpeechUnavailable(NationalSpire.CareerData, NationalSpire.GroupChat, string)`](GroupChats.cs.md#symbol-77b18ea82814)；[`NationalSpire.GroupStreamParser.Feed(string)`](GroupStreamParser.cs.md#symbol-9d7375d651fe)；`NationalSpire.GroupStreamParser.GroupStreamParser()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Text.StringBuilder.ToString()`；`string.Trim()`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatTranscript.Ordered(System.Collections.Generic.IEnumerable<NationalSpire.ChatTranscript.Message>)`；`NationalSpire.GroupChat.Entries`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Name`；`NationalSpire.GroupChat.Resolve(string)`；`NationalSpire.GroupChat.Turns`；`NationalSpire.GroupChats.SpeechUnavailable(NationalSpire.CareerData, NationalSpire.GroupChat, string)`；`NationalSpire.GroupEntry.Author`；`NationalSpire.GroupEntry.Day`；`NationalSpire.GroupEntry.Notice`；`NationalSpire.GroupEntry.Order`；`NationalSpire.GroupEntry.Text`；`NationalSpire.GroupStreamParser.Feed(string)`；`NationalSpire.GroupStreamParser.Messages`；`NationalSpire.GroupStreamParser.Speech.Author`；`NationalSpire.GroupStreamParser.Speech.Body`；`NationalSpire.GroupTurn.Day`；`NationalSpire.GroupTurn.Order`；`NationalSpire.GroupTurn.Raw`；`NationalSpire.GroupTurn.Replies`；`NationalSpire.GroupTurn.Sender`；`NationalSpire.GroupTurn.SpeechOrders`；`NationalSpire.GroupTurn.Status`；`NationalSpire.GroupTurn.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatTranscript.Document.Document(string, string, string, System.Collections.Generic.List<NationalSpire.ChatTranscript.Message>)`；输入表达式：`new(group.Name, group.Id, "群聊", Ordered(messages))`；返回值紧邻使用处：`ReturnStatementSyntax: return new(group.Name, group.Id, "群聊", Ordered(messages));`
- `NationalSpire.ChatTranscript.Message.Message(string, int, long, string)`；输入表达式：`new Message(e.Author, e.Day, e.Order, e.Text)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: e => new Message(e.Author, e.Day, e.Order, e.Text)`
- `NationalSpire.ChatTranscript.Message.Message(string, int, long, string)`；输入表达式：`new(author, turn.Day, index < turn.SpeechOrders.Count ? turn.SpeechOrders[index] : turn.Order, body)`；返回值紧邻使用处：`ArgumentSyntax: new(author, turn.Day, index < turn.SpeechOrders.Count ? turn.SpeechOrders[index] : turn.Order, body)`
- `NationalSpire.ChatTranscript.Message.Message(string, int, long, string)`；输入表达式：`new(reply.Author, reply.Day, reply.Order, reply.Text)`；返回值紧邻使用处：`ArgumentSyntax: new(reply.Author, reply.Day, reply.Order, reply.Text)`
- `NationalSpire.ChatTranscript.Message.Message(string, int, long, string)`；输入表达式：`new(turn.Sender, turn.Day, turn.Order, turn.Text)`；返回值紧邻使用处：`ArgumentSyntax: new(turn.Sender, turn.Day, turn.Order, turn.Text)`
- `NationalSpire.ChatTranscript.Ordered(System.Collections.Generic.IEnumerable<NationalSpire.ChatTranscript.Message>)`；输入表达式：`Ordered(messages)`；返回值紧邻使用处：`ArgumentSyntax: Ordered(messages)`
- `NationalSpire.GroupChat.Resolve(string)`；输入表达式：`group.Resolve(speech.Author)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = group.Resolve(speech.Author)`
- `NationalSpire.GroupChats.SpeechUnavailable(NationalSpire.CareerData, NationalSpire.GroupChat, string)`；输入表达式：`GroupChats.SpeechUnavailable(data, group, author)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GroupChats.SpeechUnavailable(data, group, author).Length`
- `NationalSpire.GroupStreamParser.Feed(string)`；输入表达式：`parser.Feed(turn.Raw)`；返回值紧邻使用处：`ExpressionStatementSyntax: parser.Feed(turn.Raw);`
- `NationalSpire.GroupStreamParser.GroupStreamParser()`；输入表达式：`new GroupStreamParser()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new GroupStreamParser()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`group.Entries.Where(e => !e.Notice && e.Text.Length > 0) .Select(e => new Message(e.Author, e.Day, e.Order, e.Text))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: group.Entries.Where(e => !e.Notice && e.Text.Length > 0) .Select(e => new Message(e.Author, e.Day, e.Order, e.Text)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`parser.Messages.Select((speech, index) => (speech, index))`；返回值紧邻使用处：`ForEachVariableStatementSyntax: foreach (var (speech, index) in parser.Messages.Select((speech, index) => (speech, index))) { string author = group.Resolve(speech.Author), body = speech.Body.ToString().Trim(); if (body.Length > 0 && GroupChats.SpeechUnavailable(data, group, author).Length == 0) messages.Add(new(author, turn.Day, index < turn.SpeechOrders.Count ? turn.SpeechOrders[index] : turn.Order, body)); }`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`group.Entries.Where(e => !e.Notice && e.Text.Length > 0) .Select(e => new Message(e.Author, e.Day, e.Order, e.Text)).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = group.Entries.Where(e => !e.Notice && e.Text.Length > 0) .Select(e => new Message(e.Author, e.Day, e.Order, e.Text)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`group.Entries.Where(e => !e.Notice && e.Text.Length > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: group.Entries.Where(e => !e.Notice && e.Text.Length > 0) .Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`turn.Replies.Where(r => !r.Notice && r.Text.Length > 0)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var reply in turn.Replies.Where(r => !r.Notice && r.Text.Length > 0)) messages.Add(new(reply.Author, reply.Day, reply.Order, reply.Text));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`messages.Add(new(author, turn.Day, index < turn.SpeechOrders.Count ? turn.SpeechOrders[index] : turn.Order, body))`；返回值紧邻使用处：`ExpressionStatementSyntax: messages.Add(new(author, turn.Day, index < turn.SpeechOrders.Count ? turn.SpeechOrders[index] : turn.Order, body));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`messages.Add(new(reply.Author, reply.Day, reply.Order, reply.Text))`；返回值紧邻使用处：`ExpressionStatementSyntax: messages.Add(new(reply.Author, reply.Day, reply.Order, reply.Text));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`messages.Add(new(turn.Sender, turn.Day, turn.Order, turn.Text))`；返回值紧邻使用处：`ExpressionStatementSyntax: messages.Add(new(turn.Sender, turn.Day, turn.Order, turn.Text));`
- `System.Text.StringBuilder.ToString()`；输入表达式：`speech.Body.ToString()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: speech.Body.ToString().Trim`
- `string.Trim()`；输入表达式：`speech.Body.ToString().Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = speech.Body.ToString().Trim()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-30424a778408"></a>

## `NationalSpire.ChatTranscript.Ordered(System.Collections.Generic.IEnumerable<NationalSpire.ChatTranscript.Message>) — private static List<Message> Ordered(IEnumerable<Message> messages)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatTranscript.Group(NationalSpire.CareerData, NationalSpire.GroupChat)`](ChatTranscript.cs.md#symbol-f3a90964e01d)；[`NationalSpire.ChatTranscript.Private(NationalSpire.CareerData, NationalSpire.PrivateConversation)`](ChatTranscript.cs.md#symbol-03037cb1cba8)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatTranscript.Message.Day`；`NationalSpire.ChatTranscript.Message.Order`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`messages.OrderBy(m => m.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: messages.OrderBy(m => m.Day).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`messages.OrderBy(m => m.Day).ThenBy(m => m.Order).ToList()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => messages.OrderBy(m => m.Day).ThenBy(m => m.Order).ToList()`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`messages.OrderBy(m => m.Day).ThenBy(m => m.Order)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: messages.OrderBy(m => m.Day).ThenBy(m => m.Order).ToList`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1d0d44b593e7"></a>

## `NationalSpire.ChatTranscript.Markdown(NationalSpire.CareerData, NationalSpire.ChatTranscript.Document) — public static string Markdown(CareerData data, Document document)`

来源：源码第 54 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatTranscript.Write(NationalSpire.CareerData, NationalSpire.ChatTranscript.Document, string)`](ChatTranscript.cs.md#symbol-a117ad117085)

**调用：** [`Inline(string)`](ChatTranscript.cs.md#symbol-0af26d369a6d)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；`System.Text.StringBuilder.Append(string?)`；`System.Text.StringBuilder.AppendLine()`；`System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；`System.Text.StringBuilder.AppendLine(string?)`；`System.Text.StringBuilder.StringBuilder()`；`System.Text.StringBuilder.ToString()`；`long.ToString()`；`string.Replace(string, string?)`；`string.Split(char, System.StringSplitOptions)`

**字段、属性、事件及方法组引用：** `Inline(string)`；`NationalSpire.ChatTranscript.Document.ConversationId`；`NationalSpire.ChatTranscript.Document.Kind`；`NationalSpire.ChatTranscript.Document.Messages`；`NationalSpire.ChatTranscript.Document.Title`；`NationalSpire.ChatTranscript.Message.AuthorId`；`NationalSpire.ChatTranscript.Message.Day`；`NationalSpire.ChatTranscript.Message.Order`；`NationalSpire.ChatTranscript.Message.Text`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Inline(string)`；输入表达式：`Inline(GroupChats.Name(data, message.AuthorId))`；返回值紧邻使用处：`InterpolationSyntax: {Inline(GroupChats.Name(data, message.AuthorId))}`
- `Inline(string)`；输入表达式：`Inline(document.ConversationId)`；返回值紧邻使用处：`BinaryExpressionSyntax: "会话 ID：" + Inline(document.ConversationId)`
- `Inline(string)`；输入表达式：`Inline(document.Title)`；返回值紧邻使用处：`BinaryExpressionSyntax: "# " + document.Kind + "记录 · " + Inline(document.Title)`
- `Inline(string)`；输入表达式：`Inline(message.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: "人物 ID：" + Inline(message.AuthorId)`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(data, message.Day)`；返回值紧邻使用处：`BinaryExpressionSyntax: "日期：" + GameCalendar.Text(data, message.Day)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(data, message.AuthorId)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Name(data, message.AuthorId)`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`text.Append("> ")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.Append("> ").AppendLine`
- `System.Text.StringBuilder.AppendLine()`；输入表达式：`new StringBuilder().AppendLine("# " + document.Kind + "记录 · " + Inline(document.Title)) .AppendLine()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new StringBuilder().AppendLine("# " + document.Kind + "记录 · " + Inline(document.Title)) .AppendLine().AppendLine`
- `System.Text.StringBuilder.AppendLine()`；输入表达式：`new StringBuilder().AppendLine("# " + document.Kind + "记录 · " + Inline(document.Title)) .AppendLine().AppendLine("会话 ID：" + Inline(document.ConversationId)) .AppendLine()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new StringBuilder().AppendLine("# " + document.Kind + "记录 · " + Inline(document.Title)) .AppendLine().AppendLine("会话 ID：" + Inline(document.ConversationId)) .AppendLine().AppendLine`
- `System.Text.StringBuilder.AppendLine()`；输入表达式：`new StringBuilder().AppendLine("# " + document.Kind + "记录 · " + Inline(document.Title)) .AppendLine().AppendLine("会话 ID：" + Inline(document.ConversationId)) .AppendLine().AppendLine("时间使用存档中的游戏日期；同日消息按发言顺序排列。") .AppendLine()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new StringBuilder().AppendLine("# " + document.Kind + "记录 · " + Inline(document.Title)) .AppendLine().AppendLine("会话 ID：" + Inline(document.ConversationId)) .AppendLine().AppendLine("时间使用存档中的游戏日期；同日消息按发言顺序排列。") .AppendLine().AppendLine`
- `System.Text.StringBuilder.AppendLine()`；输入表达式：`text.AppendLine()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.AppendLine().AppendLine`
- `System.Text.StringBuilder.AppendLine()`；输入表达式：`text.AppendLine().AppendLine($"## {++index} · {Inline(GroupChats.Name(data, message.AuthorId))}") .AppendLine()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.AppendLine().AppendLine($"## {++index} · {Inline(GroupChats.Name(data, message.AuthorId))}") .AppendLine().AppendLine`
- `System.Text.StringBuilder.AppendLine()`；输入表达式：`text.AppendLine().AppendLine($"## {++index} · {Inline(GroupChats.Name(data, message.AuthorId))}") .AppendLine().AppendLine("人物 ID：" + Inline(message.AuthorId)) .AppendLine()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.AppendLine().AppendLine($"## {++index} · {Inline(GroupChats.Name(data, message.AuthorId))}") .AppendLine().AppendLine("人物 ID：" + Inline(message.AuthorId)) .AppendLine().AppendLine`
- `System.Text.StringBuilder.AppendLine()`；输入表达式：`text.AppendLine().AppendLine($"## {++index} · {Inline(GroupChats.Name(data, message.AuthorId))}") .AppendLine().AppendLine("人物 ID：" + Inline(message.AuthorId)) .AppendLine().AppendLine("日期：" + GameCalendar.Text(data, message.Day)) .AppendLine()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.AppendLine().AppendLine($"## {++index} · {Inline(GroupChats.Name(data, message.AuthorId))}") .AppendLine().AppendLine("人物 ID：" + Inline(message.AuthorId)) .AppendLine().AppendLine("日期：" + GameCalendar.Text(data, message.Day)) .AppendLine().AppendLine`
- `System.Text.StringBuilder.AppendLine()`；输入表达式：`text.AppendLine().AppendLine($"## {++index} · {Inline(GroupChats.Name(data, message.AuthorId))}") .AppendLine().AppendLine("人物 ID：" + Inline(message.AuthorId)) .AppendLine().AppendLine("日期：" + GameCalendar.Text(data, message.Day)) .AppendLine().AppendLine("发言顺序：" + (message.Order > 0 ? message.Order.ToString() : "旧记录未保存同日顺序")) .AppendLine()`；返回值紧邻使用处：`ExpressionStatementSyntax: text.AppendLine().AppendLine($"## {++index} · {Inline(GroupChats.Name(data, message.AuthorId))}") .AppendLine().AppendLine("人物 ID：" + Inline(message.AuthorId)) .AppendLine().AppendLine("日期：" + GameCalendar.Text(data, message.Day)) .AppendLine().AppendLine("发言顺序：" + (message.Order > 0 ? message.Order.ToString() : "旧记录未保存同日顺序")) .AppendLine();`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`new StringBuilder().AppendLine("# " + document.Kind + "记录 · " + Inline(document.Title)) .AppendLine().AppendLine("会话 ID：" + Inline(document.ConversationId)) .AppendLine().AppendLine("时间使用存档中的游戏日期；同日消息按发言顺序排列。") .AppendLine().AppendLine($"共 {document.Messages.Count} 条已保存消息。")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StringBuilder().AppendLine("# " + document.Kind + "记录 · " + Inline(document.Title)) .AppendLine().AppendLine("会话 ID：" + Inline(document.ConversationId)) .AppendLine().AppendLine("时间使用存档中的游戏日期；同日消息按发言顺序排列。") .AppendLine().AppendLine($"共 {document.Messages.Count} 条已保存消息。")`
- `System.Text.StringBuilder.AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler)`；输入表达式：`text.AppendLine().AppendLine($"## {++index} · {Inline(GroupChats.Name(data, message.AuthorId))}")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.AppendLine().AppendLine($"## {++index} · {Inline(GroupChats.Name(data, message.AuthorId))}") .AppendLine`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`new StringBuilder().AppendLine("# " + document.Kind + "记录 · " + Inline(document.Title))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new StringBuilder().AppendLine("# " + document.Kind + "记录 · " + Inline(document.Title)) .AppendLine`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`new StringBuilder().AppendLine("# " + document.Kind + "记录 · " + Inline(document.Title)) .AppendLine().AppendLine("会话 ID：" + Inline(document.ConversationId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new StringBuilder().AppendLine("# " + document.Kind + "记录 · " + Inline(document.Title)) .AppendLine().AppendLine("会话 ID：" + Inline(document.ConversationId)) .AppendLine`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`new StringBuilder().AppendLine("# " + document.Kind + "记录 · " + Inline(document.Title)) .AppendLine().AppendLine("会话 ID：" + Inline(document.ConversationId)) .AppendLine().AppendLine("时间使用存档中的游戏日期；同日消息按发言顺序排列。")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new StringBuilder().AppendLine("# " + document.Kind + "记录 · " + Inline(document.Title)) .AppendLine().AppendLine("会话 ID：" + Inline(document.ConversationId)) .AppendLine().AppendLine("时间使用存档中的游戏日期；同日消息按发言顺序排列。") .AppendLine`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`text.Append("> ").AppendLine(line)`；返回值紧邻使用处：`ExpressionStatementSyntax: text.Append("> ").AppendLine(line);`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`text.AppendLine().AppendLine($"## {++index} · {Inline(GroupChats.Name(data, message.AuthorId))}") .AppendLine().AppendLine("人物 ID：" + Inline(message.AuthorId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.AppendLine().AppendLine($"## {++index} · {Inline(GroupChats.Name(data, message.AuthorId))}") .AppendLine().AppendLine("人物 ID：" + Inline(message.AuthorId)) .AppendLine`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`text.AppendLine().AppendLine($"## {++index} · {Inline(GroupChats.Name(data, message.AuthorId))}") .AppendLine().AppendLine("人物 ID：" + Inline(message.AuthorId)) .AppendLine().AppendLine("日期：" + GameCalendar.Text(data, message.Day))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.AppendLine().AppendLine($"## {++index} · {Inline(GroupChats.Name(data, message.AuthorId))}") .AppendLine().AppendLine("人物 ID：" + Inline(message.AuthorId)) .AppendLine().AppendLine("日期：" + GameCalendar.Text(data, message.Day)) .AppendLine`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`text.AppendLine().AppendLine($"## {++index} · {Inline(GroupChats.Name(data, message.AuthorId))}") .AppendLine().AppendLine("人物 ID：" + Inline(message.AuthorId)) .AppendLine().AppendLine("日期：" + GameCalendar.Text(data, message.Day)) .AppendLine().AppendLine("发言顺序：" + (message.Order > 0 ? message.Order.ToString() : "旧记录未保存同日顺序"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.AppendLine().AppendLine($"## {++index} · {Inline(GroupChats.Name(data, message.AuthorId))}") .AppendLine().AppendLine("人物 ID：" + Inline(message.AuthorId)) .AppendLine().AppendLine("日期：" + GameCalendar.Text(data, message.Day)) .AppendLine().AppendLine("发言顺序：" + (message.Order > 0 ? message.Order.ToString() : "旧记录未保存同日顺序")) .AppendLine`
- `System.Text.StringBuilder.StringBuilder()`；输入表达式：`new StringBuilder()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new StringBuilder().AppendLine`
- `System.Text.StringBuilder.ToString()`；输入表达式：`text.ToString()`；返回值紧邻使用处：`ReturnStatementSyntax: return text.ToString();`
- `long.ToString()`；输入表达式：`message.Order.ToString()`；返回值紧邻使用处：`ConditionalExpressionSyntax: message.Order > 0 ? message.Order.ToString() : "旧记录未保存同日顺序"`
- `string.Replace(string, string?)`；输入表达式：`message.Text.Replace("\r\n", "\n")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: message.Text.Replace("\r\n", "\n").Split`
- `string.Split(char, System.StringSplitOptions)`；输入表达式：`message.Text.Replace("\r\n", "\n").Split('\n')`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string line in message.Text.Replace("\r\n", "\n").Split('\n')) text.Append("> ").AppendLine(line);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0af26d369a6d"></a>

## `Inline(string) — static string Inline(string value)`

来源：源码第 56 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatTranscript.Markdown(NationalSpire.CareerData, NationalSpire.ChatTranscript.Document)`](ChatTranscript.cs.md#symbol-1d0d44b593e7)

**调用：** `string.Replace(string, string?)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Replace(string, string?)`；输入表达式：`value.Replace("\r", " ")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: value.Replace("\r", " ").Replace`
- `string.Replace(string, string?)`；输入表达式：`value.Replace("\r", " ").Replace("\n", " ")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: value.Replace("\r", " ").Replace("\n", " ").Replace`
- `string.Replace(string, string?)`；输入表达式：`value.Replace("\r", " ").Replace("\n", " ").Replace("`", "\\`")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => value.Replace("\r", " ").Replace("\n", " ").Replace("`", "\\`")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a117ad117085"></a>

## `NationalSpire.ChatTranscript.Write(NationalSpire.CareerData, NationalSpire.ChatTranscript.Document, string) — public static string Write(CareerData data, Document document, string directory)`

来源：源码第 74 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ExportChatTranscript()`](ChatUtilitiesScreen.cs.md#symbol-1bb784a2ab9d)

**调用：** [`NationalSpire.ChatTranscript.Markdown(NationalSpire.CareerData, NationalSpire.ChatTranscript.Document)`](ChatTranscript.cs.md#symbol-1d0d44b593e7)；`System.Guid.NewGuid()`；`System.IO.Directory.CreateDirectory(string)`；`System.IO.FileStream.FileStream(string, System.IO.FileMode, System.IO.FileAccess)`；`System.IO.Path.Combine(string, string)`；`System.IO.StreamWriter.StreamWriter(System.IO.Stream, System.Text.Encoding)`；`System.IO.StreamWriter.Write(string?)`；`System.Text.UTF8Encoding.UTF8Encoding(bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatTranscript.Document.Kind`；`NationalSpire.ChatTranscript.Markdown(NationalSpire.CareerData, NationalSpire.ChatTranscript.Document)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatTranscript.Markdown(NationalSpire.CareerData, NationalSpire.ChatTranscript.Document)`；输入表达式：`Markdown(data, document)`；返回值紧邻使用处：`ArgumentSyntax: Markdown(data, document)`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`InterpolationSyntax: {Guid.NewGuid():N}`
- `System.IO.Directory.CreateDirectory(string)`；输入表达式：`Directory.CreateDirectory(directory)`；返回值紧邻使用处：`ExpressionStatementSyntax: Directory.CreateDirectory(directory);`
- `System.IO.FileStream.FileStream(string, System.IO.FileMode, System.IO.FileAccess)`；输入表达式：`new FileStream(path, FileMode.CreateNew, FileAccess.Write)`；返回值紧邻使用处：`ArgumentSyntax: new FileStream(path, FileMode.CreateNew, FileAccess.Write)`
- `System.IO.Path.Combine(string, string)`；输入表达式：`Path.Combine(directory, $"国运尖塔-{document.Kind}记录-{DateTime.Now:yyyyMMdd-HHmmss}-{Guid.NewGuid():N}.md")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Path.Combine(directory, $"国运尖塔-{document.Kind}记录-{DateTime.Now:yyyyMMdd-HHmmss}-{Guid.NewGuid():N}.md")`
- `System.IO.StreamWriter.StreamWriter(System.IO.Stream, System.Text.Encoding)`；输入表达式：`new StreamWriter(new FileStream(path, FileMode.CreateNew, FileAccess.Write), new UTF8Encoding(false))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StreamWriter(new FileStream(path, FileMode.CreateNew, FileAccess.Write), new UTF8Encoding(false))`
- `System.IO.StreamWriter.Write(string?)`；输入表达式：`writer.Write(Markdown(data, document))`；返回值紧邻使用处：`ExpressionStatementSyntax: writer.Write(Markdown(data, document));`
- `System.Text.UTF8Encoding.UTF8Encoding(bool)`；输入表达式：`new UTF8Encoding(false)`；返回值紧邻使用处：`ArgumentSyntax: new UTF8Encoding(false)`

**赋值（含属性/字段和局部值）：**
