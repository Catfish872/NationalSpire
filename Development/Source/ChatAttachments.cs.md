# ChatAttachments.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`35C210F78516458DB121D628E11F7358DC0166349AFF0003CC528A3D306742D1`。来源：[源码](../../ChatAttachments.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.ChatAttachments`。

字段、事件及初始值（源码原样）：

```csharp
public const string ResponseGuide = "请根据交互格式要求来回应附件，口头回复不会视为成功回应。";
public const string GiftProtocol = """
玩家可以通过礼物附件赠送物品。附件列明礼物编号、物品、数量、赠送者和接收者。根据人物关系、当前交流和个人意愿决定接受或拒绝。
人物决定接受或拒绝礼物时，必须在本轮回复中输出对应的 Gift 标记，程序据此登记礼物处理结果。
每条礼物标记完整填写 Gift、Id。Gift 填接受或拒绝，Id 填对应礼物附件的编号。
接受礼物：
[Gift: 接受, Id: 12]
拒绝礼物：
[Gift: 拒绝, Id: 12]
只有标记才登记交互，口头答应无法触发实际效果。
普通礼物附件附有确定恋人关系的请求时，接受礼物后成为恋人。接受誓约之戒或盛大婚礼后，双方可以择期举办婚礼；完成婚礼活动后正式缔结誓约。拒绝礼物则保持当前关系。
""";
```

<a id="symbol-f98de794e2ca"></a>

## `NationalSpire.ChatAttachments.ResponseInstructions(NationalSpire.CareerData, NationalSpire.PrivateOffer, string, NationalSpire.GroupChat?, string) — public static string ResponseInstructions(CareerData data, PrivateOffer a, string number, GroupChat? group = null, string sender = "")`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupChatPrompts.UserText(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`](GroupChatPrompts.cs.md#symbol-28b2a2534bee)；[`NationalSpire.PrivateMessagePrompts.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-4b9d12b26f65)；[`NationalSpire.PrivateMessagePrompts.UserText(NationalSpire.CareerData, NationalSpire.PrivateTurn, NationalSpire.PrivateConversation, bool)`](PrivateMessagePrompts.cs.md#symbol-2e632c46656c)

**调用：** [`NationalSpire.GameCalendar.Iso(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-baf7d6edae6c)；[`NationalSpire.GroupChat.Alias(string)`](GroupChatData.cs.md#symbol-917ad43aeded)；[`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；[`NationalSpire.RelationshipGifts.Description(NationalSpire.PrivateOffer)`](RelationshipGifts.cs.md#symbol-315d5a4ef0fd)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`string.Replace(string, string?)`；`string.StartsWith(string)`；`string.TrimEnd(char)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.List<T>.Insert(int, T)`；`System.Collections.Generic.List<T>.List()`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；`System.Text.RegularExpressions.Regex.Matches(string, string)`；`System.Text.RegularExpressions.Regex.Replace(string, string, System.Text.RegularExpressions.MatchEvaluator)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatAttachments.GiftProtocol`；`NationalSpire.ChatAttachments.GroupGiftProtocol`；`NationalSpire.ChatAttachments.ResponseGuide`；`NationalSpire.ClubCoaching.Protocol`；`NationalSpire.CoachLineups.Protocol`；`NationalSpire.GameCalendar.Iso(NationalSpire.CareerData, int)`；`NationalSpire.GroupChat.Alias(string)`；`NationalSpire.OathAttachments.GroupProtocol`；`NationalSpire.OathAttachments.Kind`；`NationalSpire.OathAttachments.Protocol`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateMessagePrompts.ContractProtocol`；`NationalSpire.PrivateMessagePrompts.MatchProtocol`；`NationalSpire.PrivateOffer.ActorId`；`NationalSpire.PrivateOffer.Ascension`；`NationalSpire.PrivateOffer.CoachId`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Mode`；`NationalSpire.PrivateOffer.Participants`；`NationalSpire.PrivateOffer.Title`；`NationalSpire.RelationshipGifts.Description(NationalSpire.PrivateOffer)`；`NationalSpire.SocialAppointments.GroupProtocol`；`NationalSpire.SocialAppointments.Protocol`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GameCalendar.Iso(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Iso(data, PrivateAppointments.Date(data, a))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => GameCalendar.Iso(data, PrivateAppointments.Date(data, a))`
- `NationalSpire.GroupChat.Alias(string)`；输入表达式：`.Alias(a.ActorId.Length > 0 ? a.ActorId : a.Participants.FirstOrDefault(p => p != sender) ?? "")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: group?.Alias(a.ActorId.Length > 0 ? a.ActorId : a.Participants.FirstOrDefault(p => p != sender) ?? "")`
- `NationalSpire.GroupChat.Alias(string)`；输入表达式：`group.Alias(a.CoachId)`；返回值紧邻使用处：`InterpolationSyntax: {group.Alias(a.CoachId)}`
- `NationalSpire.GroupChat.Alias(string)`；输入表达式：`group.Alias(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: "Actor: " + group.Alias(p)`
- `NationalSpire.GroupChat.Alias(string)`；输入表达式：`group.Alias(sender)`；返回值紧邻使用处：`BinaryExpressionSyntax: ", Target: " + group.Alias(sender)`
- `NationalSpire.GroupChat.Alias(string)`；输入表达式：`group.Alias(sender)`；返回值紧邻使用处：`BinaryExpressionSyntax: "Actor: " + group.Alias(sender)`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(data, a)`；返回值紧邻使用处：`ArgumentSyntax: PrivateAppointments.Date(data, a)`
- `NationalSpire.RelationshipGifts.Description(NationalSpire.PrivateOffer)`；输入表达式：`RelationshipGifts.Description(a)`；返回值紧邻使用处：`BinaryExpressionSyntax: "\n" + RelationshipGifts.Description(a)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", formats)`；返回值紧邻使用处：`BinaryExpressionSyntax: ResponseGuide + "\n交互格式：\n" + (group == null ? "" : "[Actions]\n") + string.Join("\n", formats)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("|", a.Participants.Select(group.Alias))`；返回值紧邻使用处：`BinaryExpressionSyntax: "Participants: " + string.Join("|", a.Participants.Select(group.Alias))`
- `string.Replace(string, string?)`；输入表达式：`examples[0].Replace("Match: 邀请", "Match: " + action)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: action => examples[0].Replace("Match: 邀请", "Match: " + action)`
- `string.Replace(string, string?)`；输入表达式：`text.Replace("Actor: " + actor + (a.Kind == "match" ? "," : "]"),                          "Actor: " + group.Alias(p) + (a.Kind == "match" ? "," : "]"))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => text.Replace("Actor: " + actor + (a.Kind == "match" ? "," : "]"),                          "Actor: " + group.Alias(p) + (a.Kind == "match" ? "," : "]"))`
- `string.Replace(string, string?)`；输入表达式：`text.Replace("Actor: p1", "Actor: " + group.Alias(sender))                      .Replace("Participants: p1|p2|p3", "Participants: " + string.Join("|", a.Participants.Select(group.Alias)))`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = text.Replace("Actor: p1", "Actor: " + group.Alias(sender))                      .Replace("Participants: p1|p2|p3", "Participants: " + string.Join("|", a.Participants.Select(group.Alias)))`
- `string.Replace(string, string?)`；输入表达式：`text.Replace("Actor: p1", "Actor: " + group.Alias(sender))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.Replace("Actor: p1", "Actor: " + group.Alias(sender))                      .Replace`
- `string.Replace(string, string?)`；输入表达式：`text.Replace("Actor: p2", "Actor: " + actor)`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = text.Replace("Actor: p2", "Actor: " + actor)`
- `string.Replace(string, string?)`；输入表达式：`text.Replace("Ascension: 6", "Ascension: " + a.Ascension).Replace("Mode: 切磋", "Mode: " + a.Mode)`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = text.Replace("Ascension: 6", "Ascension: " + a.Ascension).Replace("Mode: 切磋", "Mode: " + a.Mode)`
- `string.Replace(string, string?)`；输入表达式：`text.Replace("Ascension: 6", "Ascension: " + a.Ascension)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.Replace("Ascension: 6", "Ascension: " + a.Ascension).Replace`
- `string.Replace(string, string?)`；输入表达式：`text.Replace("Title: 一起看录像", "Title: " + a.Title)                  .Replace("Detail: 讨论今天的比赛", "Detail: " + a.Detail)`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = text.Replace("Title: 一起看录像", "Title: " + a.Title)                  .Replace("Detail: 讨论今天的比赛", "Detail: " + a.Detail)`
- `string.Replace(string, string?)`；输入表达式：`text.Replace("Title: 一起看录像", "Title: " + a.Title)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.Replace("Title: 一起看录像", "Title: " + a.Title)                  .Replace`
- `string.StartsWith(string)`；输入表达式：`e.StartsWith("[Activity: 邀请,")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: e => e.StartsWith("[Activity: 邀请,")`
- `string.TrimEnd(char)`；输入表达式：`text.TrimEnd(']')`；返回值紧邻使用处：`BinaryExpressionSyntax: text.TrimEnd(']') + ", Actor: "`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`a.Participants.FirstOrDefault(p => p != sender)`；返回值紧邻使用处：`BinaryExpressionSyntax: a.Participants.FirstOrDefault(p => p != sender) ?? ""`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`a.Participants.Select(group.Alias)`；返回值紧邻使用处：`ArgumentSyntax: a.Participants.Select(group.Alias)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`a.Participants.Where(p => p != sender).Select(p => text.Replace("Actor: " + actor + (a.Kind == "match" ? "," : "]"),                          "Actor: " + group.Alias(p) + (a.Kind == "match" ? "," : "]")))`；返回值紧邻使用处：`ArgumentSyntax: a.Participants.Where(p => p != sender).Select(p => text.Replace("Actor: " + actor + (a.Kind == "match" ? "," : "]"),                          "Actor: " + group.Alias(p) + (a.Kind == "match" ? "," : "]")))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`new[] { "接受", "拒绝", "改期" }              .Select(action => examples[0].Replace("Match: 邀请", "Match: " + action))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { "接受", "拒绝", "改期" }              .Select(action => examples[0].Replace("Match: 邀请", "Match: " + action)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`System.Text.RegularExpressions.Regex.Matches(protocol, @"\[(?:Gift|Oath|Activity|Match|Training|Lineup|Contract):[^\r\n\]]+\]")              .Select(m => m.Value)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: System.Text.RegularExpressions.Regex.Matches(protocol, @"\[(?:Gift|Oath|Activity|Match|Training|Lineup|Contract):[^\r\n\]]+\]")              .Select(m => m.Value).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`new[] { "接受", "拒绝", "改期" }              .Select(action => examples[0].Replace("Match: 邀请", "Match: " + action)).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: examples = new[] { "接受", "拒绝", "改期" }              .Select(action => examples[0].Replace("Match: 邀请", "Match: " + action)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`System.Text.RegularExpressions.Regex.Matches(protocol, @"\[(?:Gift|Oath|Activity|Match|Training|Lineup|Contract):[^\r\n\]]+\]")              .Select(m => m.Value).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = System.Text.RegularExpressions.Regex.Matches(protocol, @"\[(?:Gift|Oath|Activity|Match|Training|Lineup|Contract):[^\r\n\]]+\]")              .Select(m => m.Value).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`a.Participants.Where(p => p != sender)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: a.Participants.Where(p => p != sender).Select`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`formats.Add(text)`；返回值紧邻使用处：`ExpressionStatementSyntax: formats.Add(text);`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`formats.AddRange(a.Participants.Where(p => p != sender).Select(p => text.Replace("Actor: " + actor + (a.Kind == "match" ? "," : "]"),                          "Actor: " + group.Alias(p) + (a.Kind == "match" ? "," : "]"))))`；返回值紧邻使用处：`ExpressionStatementSyntax: formats.AddRange(a.Participants.Where(p => p != sender).Select(p => text.Replace("Actor: " + actor + (a.Kind == "match" ? "," : "]"),                          "Actor: " + group.Alias(p) + (a.Kind == "match" ? "," : "]"))));`
- `System.Collections.Generic.List<T>.Insert(int, T)`；输入表达式：`formats.Insert(0, $"[Training: 同意, Id: {number}, Actor: {group.Alias(a.CoachId)}]")`；返回值紧邻使用处：`ExpressionStatementSyntax: formats.Insert(0, $"[Training: 同意, Id: {number}, Actor: {group.Alias(a.CoachId)}]");`
- `System.Collections.Generic.List<T>.Insert(int, T)`；输入表达式：`formats.Insert(1, $"[Training: 拒绝, Id: {number}, Actor: {group.Alias(a.CoachId)}]")`；返回值紧邻使用处：`ExpressionStatementSyntax: formats.Insert(1, $"[Training: 拒绝, Id: {number}, Actor: {group.Alias(a.CoachId)}]");`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string>()`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`examples.RemoveAll(e => e.StartsWith("[Activity: 邀请,"))`；返回值紧邻使用处：`ExpressionStatementSyntax: examples.RemoveAll(e => e.StartsWith("[Activity: 邀请,"));`
- `System.Text.RegularExpressions.Regex.Matches(string, string)`；输入表达式：`System.Text.RegularExpressions.Regex.Matches(protocol, @"\[(?:Gift|Oath|Activity|Match|Training|Lineup|Contract):[^\r\n\]]+\]")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: System.Text.RegularExpressions.Regex.Matches(protocol, @"\[(?:Gift|Oath|Activity|Match|Training|Lineup|Contract):[^\r\n\]]+\]")              .Select`
- `System.Text.RegularExpressions.Regex.Replace(string, string, System.Text.RegularExpressions.MatchEvaluator)`；输入表达式：`System.Text.RegularExpressions.Regex.Replace(example, @"(?<=Id: )\d+", _ => number)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = System.Text.RegularExpressions.Regex.Replace(example, @"(?<=Id: )\d+", _ => number)`
- `System.Text.RegularExpressions.Regex.Replace(string, string, System.Text.RegularExpressions.MatchEvaluator)`；输入表达式：`System.Text.RegularExpressions.Regex.Replace(text, @"(?<=Date: )\d{4}-\d{2}-\d{2}", _ => GameCalendar.Iso(data, PrivateAppointments.Date(data, a)))`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = System.Text.RegularExpressions.Regex.Replace(text, @"(?<=Date: )\d{4}-\d{2}-\d{2}", _ => GameCalendar.Iso(data, PrivateAppointments.Date(data, a)))`

**赋值（含属性/字段和局部值）：**

- `examples` = `new[] { "接受", "拒绝", "改期" }              .Select(action => examples[0].Replace("Match: 邀请", "Match: " + action)).ToList()`
- `text` = `System.Text.RegularExpressions.Regex.Replace(text, @"(?<=Date: )\d{4}-\d{2}-\d{2}", _ => GameCalendar.Iso(data, PrivateAppointments.Date(data, a)))`
- `text` = `text.Replace("Actor: p1", "Actor: " + group.Alias(sender))                      .Replace("Participants: p1|p2|p3", "Participants: " + string.Join("|", a.Participants.Select(group.Alias)))`
- `text` = `text.Replace("Actor: p2", "Actor: " + actor)`
- `text` = `text.Replace("Ascension: 6", "Ascension: " + a.Ascension).Replace("Mode: 切磋", "Mode: " + a.Mode)`
- `text` = `text.Replace("Title: 一起看录像", "Title: " + a.Title)                  .Replace("Detail: 讨论今天的比赛", "Detail: " + a.Detail)`
- `text` = `text.TrimEnd(']') + ", Actor: " + actor + (a.Kind == "match" ? ", Target: " + group.Alias(sender) : "") + "]"`

<a id="symbol-af8ef8cfe1fc"></a>

## `NationalSpire.ChatAttachments.GroupGiftProtocol — public static string GroupGiftProtocol`

来源：源码第 74 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `string.Replace(string, string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatAttachments.GiftProtocol`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Replace(string, string?)`；输入表达式：`GiftProtocol          .Replace("每条礼物标记完整填写 Gift、Id。", "每条礼物标记完整填写 Gift、Id、Actor。Actor 填接收者的编号。")          .Replace("[Gift: 接受, Id: 12]", "[Gift: 接受, Id: 12, Actor: p2]")          .Replace("[Gift: 拒绝, Id: 12]", "[Gift: 拒绝, Id: 12, Actor: p2]")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => GiftProtocol          .Replace("每条礼物标记完整填写 Gift、Id。", "每条礼物标记完整填写 Gift、Id、Actor。Actor 填接收者的编号。")          .Replace("[Gift: 接受, Id: 12]", "[Gift: 接受, Id: 12, Actor: p2]")          .Replace("[Gift: 拒绝, Id: 12]", "[Gift: 拒绝, Id: 12, Actor: p2]")`
- `string.Replace(string, string?)`；输入表达式：`GiftProtocol          .Replace("每条礼物标记完整填写 Gift、Id。", "每条礼物标记完整填写 Gift、Id、Actor。Actor 填接收者的编号。")          .Replace("[Gift: 接受, Id: 12]", "[Gift: 接受, Id: 12, Actor: p2]")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GiftProtocol          .Replace("每条礼物标记完整填写 Gift、Id。", "每条礼物标记完整填写 Gift、Id、Actor。Actor 填接收者的编号。")          .Replace("[Gift: 接受, Id: 12]", "[Gift: 接受, Id: 12, Actor: p2]")          .Replace`
- `string.Replace(string, string?)`；输入表达式：`GiftProtocol          .Replace("每条礼物标记完整填写 Gift、Id。", "每条礼物标记完整填写 Gift、Id、Actor。Actor 填接收者的编号。")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GiftProtocol          .Replace("每条礼物标记完整填写 Gift、Id。", "每条礼物标记完整填写 Gift、Id、Actor。Actor 填接收者的编号。")          .Replace`

**赋值（含属性/字段和局部值）：**


<a id="symbol-10ee34a4e855"></a>

## `NationalSpire.ChatAttachments.Find(NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, string, System.Collections.Generic.Dictionary<string, string>) — public static PrivateOffer? Find(PrivateConversation c, PrivateTurn turn, string kind, Dictionary<string, string> fields)`

来源：源码第 79 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatAttachments.Gift(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`](ChatAttachments.cs.md#symbol-cc6db06cee88)；[`NationalSpire.OathAttachments.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`](OathAttachments.cs.md#symbol-80bb2ac38dee)；[`NationalSpire.SocialAppointments.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`](SocialAppointments.cs.md#symbol-33a4725630bd)

**调用：** [`NationalSpire.PrivateInteractionIds.Resolve(NationalSpire.PrivateConversation, string?)`](PrivateMessageData.cs.md#symbol-ad3e5a4298ba)；`int.ToString()`；`string.IsNullOrEmpty(string?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateInteractionIds.Resolve(NationalSpire.PrivateConversation, string?)`；`NationalSpire.PrivateOffer.Day`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Season`；`NationalSpire.PrivateOffer.Title`；`NationalSpire.PrivateTurn.Attachments`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.ToString()`；输入表达式：`a.Day.ToString()`；返回值紧邻使用处：`BinaryExpressionSyntax: a.Day.ToString() == day`
- `int.ToString()`；输入表达式：`a.Season.ToString()`；返回值紧邻使用处：`BinaryExpressionSyntax: a.Season.ToString() == season`
- `NationalSpire.PrivateInteractionIds.Resolve(NationalSpire.PrivateConversation, string?)`；输入表达式：`PrivateInteractionIds.Resolve(c, fields.GetValueOrDefault("Id"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateInteractionIds.Resolve(c, fields.GetValueOrDefault("Id"))`
- `string.IsNullOrEmpty(string?)`；输入表达式：`string.IsNullOrEmpty(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrEmpty(id)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`fields.TryGetValue("Day", out var day)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !fields.TryGetValue("Day", out var day)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`fields.TryGetValue("Season", out var season)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !fields.TryGetValue("Season", out var season)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`fields.TryGetValue("Title", out var title)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !fields.TryGetValue("Title", out var title)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.SelectMany(t => t.Attachments).FirstOrDefault(a => a.Kind == kind && a.Id == id)`；返回值紧邻使用处：`BinaryExpressionSyntax: candidates.FirstOrDefault(a => a.Id == id)                  ?? c.Turns.SelectMany(t => t.Attachments).FirstOrDefault(a => a.Kind == kind && a.Id == id)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`candidates.FirstOrDefault(a => a.Id == id)`；返回值紧邻使用处：`BinaryExpressionSyntax: candidates.FirstOrDefault(a => a.Id == id)                  ?? c.Turns.SelectMany(t => t.Attachments).FirstOrDefault(a => a.Kind == kind && a.Id == id)`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`c.Turns.SelectMany(t => t.Attachments)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Turns.SelectMany(t => t.Attachments).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`candidates.Where(a => (!fields.TryGetValue("Title", out var title) || a.Title == title)              && (!fields.TryGetValue("Day", out var day) || a.Day.ToString() == day)              && (!fields.TryGetValue("Season", out var season) || a.Season.ToString() == season)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = candidates.Where(a => (!fields.TryGetValue("Title", out var title) || a.Title == title)              && (!fields.TryGetValue("Day", out var day) || a.Day.ToString() == day)              && (!fields.TryGetValue("Season", out var season) || a.Season.ToString() == season)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`turn.Attachments.Where(a => a.Kind == kind).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = turn.Attachments.Where(a => a.Kind == kind).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`candidates.Where(a => (!fields.TryGetValue("Title", out var title) || a.Title == title)              && (!fields.TryGetValue("Day", out var day) || a.Day.ToString() == day)              && (!fields.TryGetValue("Season", out var season) || a.Season.ToString() == season))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates.Where(a => (!fields.TryGetValue("Title", out var title) || a.Title == title)              && (!fields.TryGetValue("Day", out var day) || a.Day.ToString() == day)              && (!fields.TryGetValue("Season", out var season) || a.Season.ToString() == season)).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`turn.Attachments.Where(a => a.Kind == kind)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: turn.Attachments.Where(a => a.Kind == kind).ToArray`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`fields.GetValueOrDefault("Id")`；返回值紧邻使用处：`ArgumentSyntax: fields.GetValueOrDefault("Id")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4e7c361b1f77"></a>

## `NationalSpire.ChatAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool) — public static string? Prepare(CareerData d, string person, PrivateOffer a, bool shopping = false)`

来源：源码第 92 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`](ConsumerPickerScreen.cs.md#symbol-0f5d28176960)；[`NationalSpire.ConsumerAttachments.Prepare(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer)`](ConsumerAttachments.cs.md#symbol-bb17fc71b2da)；[`NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`](GroupChats.cs.md#symbol-e0439deb45ac)；[`NationalSpire.PrivateMessages.PrepareAttachments(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>)`](PrivateMessages.cs.md#symbol-f2d6d9cf9c86)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.ConsumerAttachments.Available(NationalSpire.CareerData, NationalSpire.Good)`](ConsumerAttachments.cs.md#symbol-6c24344e1310)；[`NationalSpire.ConsumerAttachments.Find(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](ConsumerAttachments.cs.md#symbol-eb0f1a1bbf73)；[`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；[`NationalSpire.OathAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](OathAttachments.cs.md#symbol-9abb4f75eb8f)；[`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；[`NationalSpire.RelationshipGifts.Description(NationalSpire.PrivateOffer)`](RelationshipGifts.cs.md#symbol-315d5a4ef0fd)；[`NationalSpire.RelationshipGifts.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](RelationshipGifts.cs.md#symbol-a99c2d3aea53)；[`NationalSpire.RelationshipGifts.Intent(NationalSpire.PrivateOffer)`](RelationshipGifts.cs.md#symbol-4e26695a8286)；[`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-12bdfe5d4265)；[`NationalSpire.WeddingAppointments.Error(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-9b3600926b30)；`string.IsNullOrWhiteSpace(string?)`；`string.Trim()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.ConsumerAttachments.Available(NationalSpire.CareerData, NationalSpire.Good)`；`NationalSpire.ConsumerAttachments.Find(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.Good.Giftable`；`NationalSpire.Good.Name`；`NationalSpire.OathAttachments.Kind`；`NationalSpire.OathAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateOffer.ActorId`；`NationalSpire.PrivateOffer.Day`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.GoodId`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Quantity`；`NationalSpire.PrivateOffer.RelationshipIntent`；`NationalSpire.PrivateOffer.Season`；`NationalSpire.PrivateOffer.Title`；`NationalSpire.RelationshipGifts.Description(NationalSpire.PrivateOffer)`；`NationalSpire.RelationshipGifts.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；`NationalSpire.RelationshipGifts.Intent(NationalSpire.PrivateOffer)`；`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；`NationalSpire.SocialAppointments.ExpiredDate`；`NationalSpire.WeddingAppointments.Error(NationalSpire.CareerData, NationalSpire.PrivateOffer)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, person)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.DisplayName(d, person)}`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.Name(d)}`
- `NationalSpire.ConsumerAttachments.Available(NationalSpire.CareerData, NationalSpire.Good)`；输入表达式：`ConsumerAttachments.Available(d, good)`；返回值紧邻使用处：`BinaryExpressionSyntax: ConsumerAttachments.Available(d, good) < a.Quantity`
- `NationalSpire.ConsumerAttachments.Find(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`ConsumerAttachments.Find(d, a)`；返回值紧邻使用处：`BinaryExpressionSyntax: ConsumerAttachments.Find(d, a) == null`
- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(a.GoodId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ConsumerCatalog.Get(a.GoodId)`
- `NationalSpire.OathAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；输入表达式：`OathAttachments.Prepare(d, person, a)`；返回值紧邻使用处：`ReturnStatementSyntax: return OathAttachments.Prepare(d, person, a);`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(d, a)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateAppointments.Date(d, a) < d.Day`
- `NationalSpire.RelationshipGifts.Description(NationalSpire.PrivateOffer)`；输入表达式：`RelationshipGifts.Description(a)`；返回值紧邻使用处：`IsPatternExpressionSyntax: RelationshipGifts.Description(a) is { Length: > 0 } description`
- `NationalSpire.RelationshipGifts.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；输入表达式：`RelationshipGifts.Error(d, person, a)`；返回值紧邻使用处：`IsPatternExpressionSyntax: RelationshipGifts.Error(d, person, a) is { } relationshipError`
- `NationalSpire.RelationshipGifts.Intent(NationalSpire.PrivateOffer)`；输入表达式：`RelationshipGifts.Intent(a)`；返回值紧邻使用处：`AssignmentExpressionSyntax: a.RelationshipIntent = RelationshipGifts.Intent(a)`
- `NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Length(d, a.Season)`；返回值紧邻使用处：`BinaryExpressionSyntax: a.Day > SeasonCalendar.Length(d, a.Season)`
- `NationalSpire.WeddingAppointments.Error(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`WeddingAppointments.Error(d, a)`；返回值紧邻使用处：`ReturnStatementSyntax: return WeddingAppointments.Error(d, a);`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(a.Title)`；返回值紧邻使用处：`BinaryExpressionSyntax: string.IsNullOrWhiteSpace(a.Title) || a.Season < 1`
- `string.Trim()`；输入表达式：`a.Detail.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: a.Detail = a.Detail.Trim()`

**赋值（含属性/字段和局部值）：**

- `a.ActorId` = `person`
- `a.Detail` += `"\n" + description`
- `a.Detail` = `$"赠送者：{CareerEngine.Name(d)}\n接收者：{CareerEngine.DisplayName(d, person)}\n礼物：{good.Name}×{a.Quantity}"`
- `a.Detail` = `a.Detail.Trim()`
- `a.RelationshipIntent` = `RelationshipGifts.Intent(a)`
- `a.Title` = `good.Name`

<a id="symbol-90d268266519"></a>

## `NationalSpire.ChatAttachments.Material(NationalSpire.CareerData, NationalSpire.PrivateOffer, string) — public static string Material(CareerData data, PrivateOffer a, string number)`

来源：源码第 113 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupChatPrompts.UserText(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`](GroupChatPrompts.cs.md#symbol-28b2a2534bee)；[`NationalSpire.PrivateMessagePrompts.UserText(NationalSpire.CareerData, NationalSpire.PrivateTurn, NationalSpire.PrivateConversation, bool)`](PrivateMessagePrompts.cs.md#symbol-2e632c46656c)

**调用：** [`NationalSpire.AiGeneratedText.Attachment(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](AiGeneratedText.cs.md#symbol-ac6a46b66492)；[`NationalSpire.GameCalendar.Iso(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-baf7d6edae6c)；[`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)

**字段、属性、事件及方法组引用：** `NationalSpire.AiGeneratedText.Attachment(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.GameCalendar.Iso(NationalSpire.CareerData, int)`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiGeneratedText.Attachment(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`AiGeneratedText.Attachment(data, a)`；返回值紧邻使用处：`ConditionalExpressionSyntax: a.Kind == "activity"          ? $"[Activity: 邀请, Id: {number}, Title: {a.Title}, Date: {GameCalendar.Iso(data, PrivateAppointments.Date(data, a))}, Detail: {a.Detail}]"          : AiGeneratedText.Attachment(data, a)`
- `NationalSpire.GameCalendar.Iso(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Iso(data, PrivateAppointments.Date(data, a))`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Iso(data, PrivateAppointments.Date(data, a))}`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(data, a)`；返回值紧邻使用处：`ArgumentSyntax: PrivateAppointments.Date(data, a)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-cc6db06cee88"></a>

## `NationalSpire.ChatAttachments.Gift(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>) — public static void Gift(CareerData d, PrivateConversation c, PrivateTurn turn, Dictionary<string, string> fields)`

来源：源码第 117 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`](PrivateMessages.cs.md#symbol-7bf623828ccc)

**调用：** [`NationalSpire.ChatAttachments.Find(NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, string, System.Collections.Generic.Dictionary<string, string>)`](ChatAttachments.cs.md#symbol-10ee34a4e855)；[`NationalSpire.ConsumerAttachments.Find(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](ConsumerAttachments.cs.md#symbol-eb0f1a1bbf73)；[`NationalSpire.ConsumerAttachments.Resolve(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool)`](ConsumerAttachments.cs.md#symbol-f88b230b016a)；[`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；[`NationalSpire.RelationshipGifts.Accept(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](RelationshipGifts.cs.md#symbol-821bf6a43163)；[`NationalSpire.RelationshipGifts.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](RelationshipGifts.cs.md#symbol-a99c2d3aea53)；`NationalSpire.PrivateOffer.PrivateOffer()`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Math.Min(long, long)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.ChatAttachments.Find(NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, string, System.Collections.Generic.Dictionary<string, string>)`；`NationalSpire.ConsumerAttachments.Find(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.ConsumerAttachments.Resolve(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool)`；`NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.ConsumerState.GiftReceipts`；`NationalSpire.ConsumerState.Goods`；`NationalSpire.Good.Instant`；`NationalSpire.OwnedGood.Consumed`；`NationalSpire.OwnedGood.Id`；`NationalSpire.OwnedGood.Quantity`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateOffer.ActorId`；`NationalSpire.PrivateOffer.ConsumerAttachmentId`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.GoodId`；`NationalSpire.PrivateOffer.GroupId`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Quantity`；`NationalSpire.PrivateOffer.RelationshipIntent`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.Title`；`NationalSpire.PrivateOffer.TurnId`；`NationalSpire.PrivateTurn.Error`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.RelationshipGifts.Accept(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；`NationalSpire.RelationshipGifts.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatAttachments.Find(NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, string, System.Collections.Generic.Dictionary<string, string>)`；输入表达式：`Find(c, turn, "gift", fields)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Find(c, turn, "gift", fields)`
- `NationalSpire.ConsumerAttachments.Find(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`ConsumerAttachments.Find(d, a)`；返回值紧邻使用处：`BinaryExpressionSyntax: ConsumerAttachments.Find(d, a) != null`
- `NationalSpire.ConsumerAttachments.Resolve(NationalSpire.CareerData, NationalSpire.PrivateOffer, bool)`；输入表达式：`ConsumerAttachments.Resolve(d, a, action == "接受")`；返回值紧邻使用处：`ExpressionStatementSyntax: ConsumerAttachments.Resolve(d, a, action == "接受");`
- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(a.GoodId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: ConsumerCatalog.Get(a.GoodId)?.Instant`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new() { Id = a.Id, Kind = "gift", TurnId = turn.Id, GoodId = a.GoodId, Quantity = a.Quantity,              ConsumerAttachmentId = a.ConsumerAttachmentId, ActorId = a.ActorId, Title = a.Title, Detail = a.Detail, RelationshipIntent = a.RelationshipIntent, State = action == "接受" ? "已接受" : "已拒绝" }`；返回值紧邻使用处：`ArgumentSyntax: new() { Id = a.Id, Kind = "gift", TurnId = turn.Id, GoodId = a.GoodId, Quantity = a.Quantity,              ConsumerAttachmentId = a.ConsumerAttachmentId, ActorId = a.ActorId, Title = a.Title, Detail = a.Detail, RelationshipIntent = a.RelationshipIntent, State = action == "接受" ? "已接受" : "已拒绝" }`
- `NationalSpire.RelationshipGifts.Accept(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；输入表达式：`RelationshipGifts.Accept(d, c.PersonId, a)`；返回值紧邻使用处：`ExpressionStatementSyntax: RelationshipGifts.Accept(d, c.PersonId, a);`
- `NationalSpire.RelationshipGifts.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；输入表达式：`RelationshipGifts.Error(d, c.PersonId, a)`；返回值紧邻使用处：`IsPatternExpressionSyntax: RelationshipGifts.Error(d, c.PersonId, a) is { } relationshipError`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`d.Life.Consumer.GiftReceipts.Add(receipt)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Life.Consumer.GiftReceipts.Add(receipt);`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`d.Life.Consumer.GiftReceipts.Contains(receipt)`；返回值紧邻使用处：`BinaryExpressionSyntax: a.ActorId != c.PersonId || d.Life.Consumer.GiftReceipts.Contains(receipt)`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；输入表达式：`goods.Sum(g => g.Quantity)`；返回值紧邻使用处：`BinaryExpressionSyntax: goods.Sum(g => g.Quantity) < a.Quantity`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`d.Life.Consumer.Goods.Where(g => g.Id == a.GoodId && !g.Consumed).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Life.Consumer.Goods.Where(g => g.Id == a.GoodId && !g.Consumed).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Consumer.Goods.Where(g => g.Id == a.GoodId && !g.Consumed)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Consumer.Goods.Where(g => g.Id == a.GoodId && !g.Consumed).ToArray`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`fields.GetValueOrDefault("Gift", "")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = fields.GetValueOrDefault("Gift", "")`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.Offers.Add(new() { Id = a.Id, Kind = "gift", TurnId = turn.Id, GoodId = a.GoodId, Quantity = a.Quantity,              ConsumerAttachmentId = a.ConsumerAttachmentId, ActorId = a.ActorId, Title = a.Title, Detail = a.Detail, RelationshipIntent = a.RelationshipIntent, State = action == "接受" ? "已接受" : "已拒绝" })`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Offers.Add(new() { Id = a.Id, Kind = "gift", TurnId = turn.Id, GoodId = a.GoodId, Quantity = a.Quantity,              ConsumerAttachmentId = a.ConsumerAttachmentId, ActorId = a.ActorId, Title = a.Title, Detail = a.Detail, RelationshipIntent = a.RelationshipIntent, State = action == "接受" ? "已接受" : "已拒绝" });`
- `System.Math.Min(long, long)`；输入表达式：`Math.Min(remaining, good.Quantity)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(remaining, good.Quantity)`

**赋值（含属性/字段和局部值）：**

- `ActorId` = `a.ActorId`
- `ConsumerAttachmentId` = `a.ConsumerAttachmentId`
- `Detail` = `a.Detail`
- `good.Quantity` -= `count`
- `GoodId` = `a.GoodId`
- `Id` = `a.Id`
- `Kind` = `"gift"`
- `Quantity` = `a.Quantity`
- `RelationshipIntent` = `a.RelationshipIntent`
- `remaining` -= `count`
- `State` = `action == "接受" ? "已接受" : "已拒绝"`
- `Title` = `a.Title`
- `turn.Error` += `"\n" + relationshipError`
- `turn.Error` += `"\n礼物库存已变化，请调整赠送数量。"`
- `turn.Error` += `"\n请在礼物附件中明确本次处理的礼物编号。"`
- `TurnId` = `turn.Id`
