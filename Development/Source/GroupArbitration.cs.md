# GroupArbitration.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`0FB5A93D9A2A66F269C7D2EC0B3A99F6E46F6C6573B5D6E4795B3C2863F76036`。来源：[源码](../../GroupArbitration.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.GroupArbitration`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-af12ffcc2740"></a>

## `NationalSpire.GroupArbitration.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn) — public static List<Dictionary<string, string>> Compose(CareerData d, GroupChat g, GroupTurn t)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string>?)`](AiGroupChats.cs.md#symbol-caddadc35a6b)

**调用：** [`NationalSpire.GroupChat.Alias(string)`](GroupChatData.cs.md#symbol-917ad43aeded)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?, bool)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.GroupChatPrompts.Section(NationalSpire.CareerData, string)`](GroupChatPrompts.cs.md#symbol-faefbd7982b5)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；[`NationalSpire.PromptInsertions.Apply(System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, System.Collections.Generic.IEnumerable<NationalSpire.PromptInsertion>?)`](PromptInsertions.cs.md#symbol-35674fc9b589)；[`NationalSpire.PromptInsertions.Around(string, System.Collections.Generic.IEnumerable<NationalSpire.PromptInsertion>?, int, int)`](PromptInsertions.cs.md#symbol-3d0f6f332049)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.List<T>.Add(T)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatTimeline.Privacy`；`NationalSpire.GroupChat.Alias(string)`；`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?, bool)`；`NationalSpire.GroupChatPrompts.Section(NationalSpire.CareerData, string)`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.GroupTurn.ArbitrationTargets`；`NationalSpire.GroupTurn.PromptInsertions`；`NationalSpire.GroupTurn.Text`；`NationalSpire.PromptInsertions.Apply(System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, System.Collections.Generic.IEnumerable<NationalSpire.PromptInsertion>?)`；`NationalSpire.PromptInsertions.Around(string, System.Collections.Generic.IEnumerable<NationalSpire.PromptInsertion>?, int, int)`；`NationalSpire.SpireArbitration.Prompt`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChat.Alias(string)`；输入表达式：`g.Alias(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Alias(id) + " "`
- `NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?, bool)`；输入表达式：`GroupChatPrompts.Compose(d, g, t, insertPrompts: false)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GroupChatPrompts.Compose(d, g, t, insertPrompts: false)`
- `NationalSpire.GroupChatPrompts.Section(NationalSpire.CareerData, string)`；输入表达式：`GroupChatPrompts.Section(d, "world")`；返回值紧邻使用处：`BinaryExpressionSyntax: GroupChatPrompts.Section(d, "world") + "\n"`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Alias(id) + " " + GroupChats.Name(d, id)`
- `NationalSpire.PromptInsertions.Apply(System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, System.Collections.Generic.IEnumerable<NationalSpire.PromptInsertion>?)`；输入表达式：`PromptInsertions.Apply(source, t.PromptInsertions)`；返回值紧邻使用处：`ReturnStatementSyntax: return PromptInsertions.Apply(source, t.PromptInsertions);`
- `NationalSpire.PromptInsertions.Around(string, System.Collections.Generic.IEnumerable<NationalSpire.PromptInsertion>?, int, int)`；输入表达式：`PromptInsertions.Around(t.Text, t.PromptInsertions, 1, 2)`；返回值紧邻使用处：`BinaryExpressionSyntax: "本次被申请人：" + string.Join("、", t.ArbitrationTargets.Select(id => g.Alias(id) + " " + GroupChats.Name(d, id))) + "\n申请内容：" + PromptInsertions.Around(t.Text, t.PromptInsertions, 1, 2)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new() { ["role"] = "user", ["content"] = "本次被申请人：" + string.Join("、", t.ArbitrationTargets.Select(id => g.Alias(id) + " " + GroupChats.Name(d, id))) + "\n申请内容：" + PromptInsertions.Around(t.Text, t.PromptInsertions, 1, 2) }`；返回值紧邻使用处：`ArgumentSyntax: new() { ["role"] = "user", ["content"] = "本次被申请人：" + string.Join("、", t.ArbitrationTargets.Select(id => g.Alias(id) + " " + GroupChats.Name(d, id))) + "\n申请内容：" + PromptInsertions.Around(t.Text, t.PromptInsertions, 1, 2) }`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`t.ArbitrationTargets.Select(id => g.Alias(id) + " " + GroupChats.Name(d, id))`；返回值紧邻使用处：`ArgumentSyntax: t.ArbitrationTargets.Select(id => g.Alias(id) + " " + GroupChats.Name(d, id))`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`source.Skip(1)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var message in source.Skip(1)) if (message["role"] == "assistant") { message["role"] = "user"; message["content"] = "本群已经发生的发言\n" + message["content"]; }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`source.Add(new() { ["role"] = "user", ["content"] = "本次被申请人：" + string.Join("、", t.ArbitrationTargets.Select(id => g.Alias(id) + " " + GroupChats.Name(d, id))) + "\n申请内容：" + PromptInsertions.Around(t.Text, t.PromptInsertions, 1, 2) })`；返回值紧邻使用处：`ExpressionStatementSyntax: source.Add(new() { ["role"] = "user", ["content"] = "本次被申请人：" + string.Join("、", t.ArbitrationTargets.Select(id => g.Alias(id) + " " + GroupChats.Name(d, id))) + "\n申请内容：" + PromptInsertions.Around(t.Text, t.PromptInsertions, 1, 2) });`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", t.ArbitrationTargets.Select(id => g.Alias(id) + " " + GroupChats.Name(d, id)))`；返回值紧邻使用处：`BinaryExpressionSyntax: "本次被申请人：" + string.Join("、", t.ArbitrationTargets.Select(id => g.Alias(id) + " " + GroupChats.Name(d, id)))`

**赋值（含属性/字段和局部值）：**

- `["content"]` = `"本次被申请人：" + string.Join("、", t.ArbitrationTargets.Select(id => g.Alias(id) + " " + GroupChats.Name(d, id))) + "\n申请内容：" + PromptInsertions.Around(t.Text, t.PromptInsertions, 1, 2)`
- `["role"]` = `"user"`
- `message["content"]` = `"本群已经发生的发言\n" + message["content"]`
- `message["role"]` = `"user"`
- `source[0]["content"]` = `GroupChatPrompts.Section(d, "world") + "\n" + SpireArbitration.Prompt + "\n" + ChatTimeline.Privacy + "\n" + """ 本次同时审理多名被申请人，分别作出裁决，不因同处一个群聊就认定所有人有责任。 输出一个 JSON 对象：Decisions 是裁决数组，每项包含 Person（被申请人人物编号）与 Decision（上述单人裁决对象）；PublicTitle、PublicBody 为所有申请成立者共同承担具体责任的统一公开致歉草稿，由其中一名责任人代表发布。各 Decision 的 Apology 为该人发到本群的致歉。每人分别填写自己的处罚与性格变化；未成立者不承担他人的处罚。 """`

<a id="symbol-9a6b33178ad4"></a>

## `NationalSpire.GroupArbitration.LinkPublication(NationalSpire.CareerData, NationalSpire.GroupChat, string) — public static void LinkPublication(CareerData d, GroupChat g, string localTurn)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupChats.Command(NationalSpire.CareerData, string, string, NationalSpire.GroupCommand)`](GroupChats.cs.md#symbol-e0439deb45ac)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`

**字段、属性、事件及方法组引用：** `NationalSpire.ArbitrationRecord.Id`；`NationalSpire.ArbitrationRecord.PostId`；`NationalSpire.ArbitrationRecord.Upheld`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Arbitrations`；`NationalSpire.GroupChat.Interactions`；`NationalSpire.GroupChat.Turns`；`NationalSpire.GroupEffect.Lane`；`NationalSpire.GroupEffect.Person`；`NationalSpire.GroupEffect.Turn`；`NationalSpire.GroupTurn.ArbitrationTargets`；`NationalSpire.GroupTurn.Effects`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.MatchId`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.TurnId`；`NationalSpire.PrivateTurn.Arbitration`；`NationalSpire.PrivateTurn.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, effect.Person)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CareerEngine.Person(d, effect.Person)?.Arbitrations.FirstOrDefault(r => r.Id == record.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`t.Effects.Any(e => e.Turn == localTurn)`；返回值紧邻使用处：`BinaryExpressionSyntax: t.ArbitrationTargets.Count > 0 && t.Effects.Any(e => e.Turn == localTurn)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Arbitrations.FirstOrDefault(r => r.Id == record.Id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CareerEngine.Person(d, effect.Person)?.Arbitrations.FirstOrDefault(r => r.Id == record.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Interactions[effect.Lane].Turns.FirstOrDefault(t => t.Id == effect.Turn)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: g.Interactions[effect.Lane].Turns.FirstOrDefault(t => t.Id == effect.Turn)?.Arbitration`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Turns.FirstOrDefault(t => t.ArbitrationTargets.Count > 0 && t.Effects.Any(e => e.Turn == localTurn))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = g.Turns.FirstOrDefault(t => t.ArbitrationTargets.Count > 0 && t.Effects.Any(e => e.Turn == localTurn))`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`turn.Effects.SelectMany(e => g.Interactions[e.Lane].Offers).FirstOrDefault(o => o.TurnId == localTurn && o.State == "已确认" && o.Kind == "publish")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = turn.Effects.SelectMany(e => g.Interactions[e.Lane].Offers).FirstOrDefault(o => o.TurnId == localTurn && o.State == "已确认" && o.Kind == "publish")`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`turn.Effects.SelectMany(e => g.Interactions[e.Lane].Offers)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: turn.Effects.SelectMany(e => g.Interactions[e.Lane].Offers).FirstOrDefault`

**赋值（含属性/字段和局部值）：**

- `record.PostId` = `post.MatchId`
- `saved.PostId` = `post.MatchId`

<a id="symbol-112723169c3a"></a>

## `NationalSpire.GroupArbitration.Apply(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn, string) — public static void Apply(CareerData d, GroupChat g, GroupTurn t, string raw)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string>?)`](AiGroupChats.cs.md#symbol-caddadc35a6b)

**调用：** [`Execute(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`](GroupArbitration.cs.md#symbol-b38ef0bc526d)；[`NationalSpire.GroupChat.Resolve(string)`](GroupChatData.cs.md#symbol-970525ff4872)；[`NationalSpire.GroupChats.PreviewCopy(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-76ad48e0a3a3)；[`NationalSpire.SpireArbitration.Parse(string)`](SpireArbitration.cs.md#symbol-79b7629027ea)；`string.StartsWith(string, System.StringComparison)`；`string.Trim()`；`string.Trim(char)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.List()`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Random.Next(int)`；`System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；`System.Text.Json.JsonElement.EnumerateArray()`；`System.Text.Json.JsonElement.GetProperty(string)`；`System.Text.Json.JsonElement.GetRawText()`；`System.Text.Json.JsonElement.GetString()`

**字段、属性、事件及方法组引用：** `(string Person, NationalSpire.ArbitrationDecision Decision).Decision`；`(string Person, NationalSpire.ArbitrationDecision Decision).Person`；`Execute(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`；`NationalSpire.ArbitrationDecision.Upheld`；`NationalSpire.CareerData.Chats`；`NationalSpire.ChatWorld.Groups`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.Resolve(string)`；`NationalSpire.GroupChat.Turns`；`NationalSpire.GroupChats.PreviewCopy(NationalSpire.CareerData)`；`NationalSpire.GroupTurn.ArbitrationTargets`；`NationalSpire.GroupTurn.Id`；`NationalSpire.SpireArbitration.Parse(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Execute(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`；输入表达式：`Execute(d, g, t)`；返回值紧邻使用处：`ExpressionStatementSyntax: Execute(d, g, t);`
- `Execute(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`；输入表达式：`Execute(probe, probe.Chats.Groups.Single(x => x.Id == g.Id), probe.Chats.Groups.Single(x => x.Id == g.Id).Turns.Single(x => x.Id == t.Id))`；返回值紧邻使用处：`ExpressionStatementSyntax: Execute(probe, probe.Chats.Groups.Single(x => x.Id == g.Id), probe.Chats.Groups.Single(x => x.Id == g.Id).Turns.Single(x => x.Id == t.Id));`
- `NationalSpire.GroupChat.Resolve(string)`；输入表达式：`g.Resolve(row.GetProperty("Person").GetString() ?? "")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = g.Resolve(row.GetProperty("Person").GetString() ?? "")`
- `NationalSpire.GroupChats.PreviewCopy(NationalSpire.CareerData)`；输入表达式：`GroupChats.PreviewCopy(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GroupChats.PreviewCopy(d)`
- `NationalSpire.SpireArbitration.Parse(string)`；输入表达式：`SpireArbitration.Parse(row.GetProperty("Decision").GetRawText())`；返回值紧邻使用处：`ArgumentSyntax: SpireArbitration.Parse(row.GetProperty("Decision").GetRawText())`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`raw.Trim().Trim('`').Trim().StartsWith("json", StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`ConditionalExpressionSyntax: raw.Trim().Trim('`').Trim().StartsWith("json", StringComparison.OrdinalIgnoreCase) ? raw.Trim().Trim('`').Trim()[4..].Trim() : raw.Trim().Trim('`').Trim()`
- `string.Trim()`；输入表达式：`raw.Trim().Trim('`').Trim()[4..].Trim()`；返回值紧邻使用处：`ConditionalExpressionSyntax: raw.Trim().Trim('`').Trim().StartsWith("json", StringComparison.OrdinalIgnoreCase) ? raw.Trim().Trim('`').Trim()[4..].Trim() : raw.Trim().Trim('`').Trim()`
- `string.Trim()`；输入表达式：`raw.Trim().Trim('`').Trim()`；返回值紧邻使用处：`ConditionalExpressionSyntax: raw.Trim().Trim('`').Trim().StartsWith("json", StringComparison.OrdinalIgnoreCase) ? raw.Trim().Trim('`').Trim()[4..].Trim() : raw.Trim().Trim('`').Trim()`
- `string.Trim()`；输入表达式：`raw.Trim().Trim('`').Trim()`；返回值紧邻使用处：`ElementAccessExpressionSyntax: raw.Trim().Trim('`').Trim()[4..]`
- `string.Trim()`；输入表达式：`raw.Trim().Trim('`').Trim()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: raw.Trim().Trim('`').Trim().StartsWith`
- `string.Trim()`；输入表达式：`raw.Trim()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: raw.Trim().Trim`
- `string.Trim(char)`；输入表达式：`raw.Trim().Trim('`')`；返回值紧邻使用处：`MemberAccessExpressionSyntax: raw.Trim().Trim('`').Trim`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`parsed.Any(x => x.Person == id)`；返回值紧邻使用处：`BinaryExpressionSyntax: !t.ArbitrationTargets.Contains(id) || parsed.Any(x => x.Person == id)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`parsed.Where(x => x.Decision.Upheld).Select(x => x.Person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parsed.Where(x => x.Decision.Upheld).Select(x => x.Person).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`probe.Chats.Groups.Single(x => x.Id == g.Id).Turns.Single(x => x.Id == t.Id)`；返回值紧邻使用处：`ArgumentSyntax: probe.Chats.Groups.Single(x => x.Id == g.Id).Turns.Single(x => x.Id == t.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`probe.Chats.Groups.Single(x => x.Id == g.Id)`；返回值紧邻使用处：`ArgumentSyntax: probe.Chats.Groups.Single(x => x.Id == g.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`probe.Chats.Groups.Single(x => x.Id == g.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: probe.Chats.Groups.Single(x => x.Id == g.Id).Turns`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`parsed.Where(x => x.Decision.Upheld).Select(x => x.Person).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = parsed.Where(x => x.Decision.Upheld).Select(x => x.Person).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`parsed.Where(x => x.Decision.Upheld)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parsed.Where(x => x.Decision.Upheld).Select`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`parsed.Add((id, SpireArbitration.Parse(row.GetProperty("Decision").GetRawText())))`；返回值紧邻使用处：`ExpressionStatementSyntax: parsed.Add((id, SpireArbitration.Parse(row.GetProperty("Decision").GetRawText())));`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`t.ArbitrationTargets.Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !t.ArbitrationTargets.Contains(id)`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<(string Person, ArbitrationDecision Decision)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<(string Person, ArbitrationDecision Decision)>()`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("仲裁返回缺少部分被申请人的裁决，尚未执行处罚。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("仲裁返回缺少部分被申请人的裁决，尚未执行处罚。");`
- `System.Random.Next(int)`；输入表达式：`Random.Shared.Next(guilty.Length)`；返回值紧邻使用处：`ArgumentSyntax: Random.Shared.Next(guilty.Length)`
- `System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；输入表达式：`JsonDocument.Parse(raw.Trim().Trim('`').Trim().StartsWith("json", StringComparison.OrdinalIgnoreCase) ? raw.Trim().Trim('`').Trim()[4..].Trim() : raw.Trim().Trim('`').Trim())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonDocument.Parse(raw.Trim().Trim('`').Trim().StartsWith("json", StringComparison.OrdinalIgnoreCase) ? raw.Trim().Trim('`').Trim()[4..].Trim() : raw.Trim().Trim('`').Trim())`
- `System.Text.Json.JsonElement.EnumerateArray()`；输入表达式：`root.GetProperty("Decisions").EnumerateArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var row in root.GetProperty("Decisions").EnumerateArray())         {             string id = g.Resolve(row.GetProperty("Person").GetString() ?? "");             if (!t.ArbitrationTargets.Contains(id) || parsed.Any(x => x.Person == id)) continue;             parsed.Add((id, SpireArbitration.Parse(row.GetProperty("Decision").GetRawText())));         }`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`root.GetProperty("Decisions")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: root.GetProperty("Decisions").EnumerateArray`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`row.GetProperty("Decision")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: row.GetProperty("Decision").GetRawText`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`row.GetProperty("Person")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: row.GetProperty("Person").GetString`
- `System.Text.Json.JsonElement.GetRawText()`；输入表达式：`row.GetProperty("Decision").GetRawText()`；返回值紧邻使用处：`ArgumentSyntax: row.GetProperty("Decision").GetRawText()`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`row.GetProperty("Person").GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: row.GetProperty("Person").GetString() ?? ""`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b38ef0bc526d"></a>

## `Execute(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn) — void Execute(CareerData data, GroupChat group, GroupTurn turn)`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupArbitration.Apply(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn, string)`](GroupArbitration.cs.md#symbol-112723169c3a)

**调用：** [`NationalSpire.GroupChats.InLane<T>(NationalSpire.CareerData, NationalSpire.GroupChat, string, string, string, System.Func<NationalSpire.PrivateConversation, T>)`](GroupChats.cs.md#symbol-167e5090d91a)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；[`NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-c362351c7a43)；[`NationalSpire.PrivateInteractionIds.Ensure(NationalSpire.PrivateConversation)`](PrivateMessageData.cs.md#symbol-2a4d65cc20f8)；[`NationalSpire.PrivateInteractionIds.Number(NationalSpire.PrivateConversation, NationalSpire.PrivateOffer)`](PrivateMessageData.cs.md#symbol-5ca7dee3ea48)；[`NationalSpire.SpireArbitration.Complete(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, NationalSpire.ArbitrationDecision)`](SpireArbitration.cs.md#symbol-7bc24f64a697)；`NationalSpire.GroupEffect.GroupEffect()`；`NationalSpire.GroupEntry.GroupEntry()`；`NationalSpire.PrivateTurn.PrivateTurn()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Remove(T)`；`System.Math.Max(long, long)`；`System.Text.Json.JsonElement.GetString()`；`System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`

**字段、属性、事件及方法组引用：** `NationalSpire.ArbitrationDecision.Apology`；`NationalSpire.ArbitrationDecision.Finding`；`NationalSpire.CareerData.Season`；`NationalSpire.GroupChat.Id`；`NationalSpire.GroupChat.LastInteractionNumber`；`NationalSpire.GroupChats.InLane<T>(NationalSpire.CareerData, NationalSpire.GroupChat, string, string, string, System.Func<NationalSpire.PrivateConversation, T>)`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`；`NationalSpire.GroupEffect.Human`；`NationalSpire.GroupEffect.Lane`；`NationalSpire.GroupEffect.Person`；`NationalSpire.GroupEffect.Turn`；`NationalSpire.GroupEntry.Author`；`NationalSpire.GroupEntry.Day`；`NationalSpire.GroupEntry.Order`；`NationalSpire.GroupEntry.Text`；`NationalSpire.GroupEntry.TurnId`；`NationalSpire.GroupTurn.Day`；`NationalSpire.GroupTurn.Effects`；`NationalSpire.GroupTurn.Id`；`NationalSpire.GroupTurn.Notices`；`NationalSpire.GroupTurn.Replies`；`NationalSpire.GroupTurn.Sender`；`NationalSpire.GroupTurn.Text`；`NationalSpire.PrivateConversation.LastInteractionNumber`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateInteractionIds.Ensure(NationalSpire.PrivateConversation)`；`NationalSpire.PrivateInteractionIds.Number(NationalSpire.PrivateConversation, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateOffer.ActorId`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.GroupId`；`NationalSpire.PrivateOffer.RelatedPeople`；`NationalSpire.PrivateOffer.Title`；`NationalSpire.PrivateOffer.TurnId`；`NationalSpire.PrivateTurn.Day`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.RequestKind`；`NationalSpire.PrivateTurn.Season`；`NationalSpire.PrivateTurn.User`；`NationalSpire.SpireArbitration.Complete(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, NationalSpire.ArbitrationDecision)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChats.InLane<T>(NationalSpire.CareerData, NationalSpire.GroupChat, string, string, string, System.Func<NationalSpire.PrivateConversation, T>)`；输入表达式：`GroupChats.InLane(data, group, turn.Sender, person, "", c =>                 {                     var local = new PrivateTurn { Id = turn.Id + ":arbitration:" + person, User = turn.Text, Day = turn.Day, Season = data.Season, RequestKind = "arbitration" };                     c.Turns.Add(local); SpireArbitration.Complete(data, c, local, decision);                     c.LastInteractionNumber = Math.Max(c.LastInteractionNumber, group.LastInteractionNumber); PrivateInteractionIds.Ensure(c);                     foreach (var offer in c.Offers) PrivateInteractionIds.Number(c, offer);                     group.LastInteractionNumber = c.LastInteractionNumber;                     var post = c.Offers.FirstOrDefault(o => o.TurnId == local.Id);                     if (post != null)                     {                         if (person != representative) c.Offers.Remove(post);                         else                         {                             if (root.TryGetProperty("PublicTitle", out var title)) post.Title = title.GetString() ?? post.Title;                             if (root.TryGetProperty("PublicBody", out var body)) post.Detail = body.GetString() ?? post.Detail;                             post.RelatedPeople = guilty.Where(id => id != representative).ToList(); post.GroupId = group.Id; post.ActorId = person;                         }                     }                     if (decision.Apology.Length > 0) turn.Replies.Add(new() { Author = person, Text = decision.Apology, Day = turn.Day, TurnId = turn.Id, Order = GroupChats.NextOrder(data) });                     turn.Notices.Add(GroupChats.Name(data, person) + "：" + decision.Finding);                     turn.Effects.Add(new() { Human = turn.Sender, Person = person, Lane = turn.Sender + "/" + person + "/", Turn = local.Id });                     return true;                 })`；返回值紧邻使用处：`ExpressionStatementSyntax: GroupChats.InLane(data, group, turn.Sender, person, "", c =>                 {                     var local = new PrivateTurn { Id = turn.Id + ":arbitration:" + person, User = turn.Text, Day = turn.Day, Season = data.Season, RequestKind = "arbitration" };                     c.Turns.Add(local); SpireArbitration.Complete(data, c, local, decision);                     c.LastInteractionNumber = Math.Max(c.LastInteractionNumber, group.LastInteractionNumber); PrivateInteractionIds.Ensure(c);                     foreach (var offer in c.Offers) PrivateInteractionIds.Number(c, offer);                     group.LastInteractionNumber = c.LastInteractionNumber;                     var post = c.Offers.FirstOrDefault(o => o.TurnId == local.Id);                     if (post != null)                     {                         if (person != representative) c.Offers.Remove(post);                         else                         {                             if (root.TryGetProperty("PublicTitle", out var title)) post.Title = title.GetString() ?? post.Title;                             if (root.TryGetProperty("PublicBody", out var body)) post.Detail = body.GetString() ?? post.Detail;                             post.RelatedPeople = guilty.Where(id => id != representative).ToList(); post.GroupId = group.Id; post.ActorId = person;                         }                     }                     if (decision.Apology.Length > 0) turn.Replies.Add(new() { Author = person, Text = decision.Apology, Day = turn.Day, TurnId = turn.Id, Order = GroupChats.NextOrder(data) });                     turn.Notices.Add(GroupChats.Name(data, person) + "：" + decision.Finding);                     turn.Effects.Add(new() { Human = turn.Sender, Person = person, Lane = turn.Sender + "/" + person + "/", Turn = local.Id });                     return true;                 });`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(data, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: GroupChats.Name(data, person) + "："`
- `NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`；输入表达式：`GroupChats.NextOrder(data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Order = GroupChats.NextOrder(data)`
- `NationalSpire.GroupEffect.GroupEffect()`；输入表达式：`new() { Human = turn.Sender, Person = person, Lane = turn.Sender + "/" + person + "/", Turn = local.Id }`；返回值紧邻使用处：`ArgumentSyntax: new() { Human = turn.Sender, Person = person, Lane = turn.Sender + "/" + person + "/", Turn = local.Id }`
- `NationalSpire.GroupEntry.GroupEntry()`；输入表达式：`new() { Author = person, Text = decision.Apology, Day = turn.Day, TurnId = turn.Id, Order = GroupChats.NextOrder(data) }`；返回值紧邻使用处：`ArgumentSyntax: new() { Author = person, Text = decision.Apology, Day = turn.Day, TurnId = turn.Id, Order = GroupChats.NextOrder(data) }`
- `NationalSpire.PrivateInteractionIds.Ensure(NationalSpire.PrivateConversation)`；输入表达式：`PrivateInteractionIds.Ensure(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateInteractionIds.Ensure(c);`
- `NationalSpire.PrivateInteractionIds.Number(NationalSpire.PrivateConversation, NationalSpire.PrivateOffer)`；输入表达式：`PrivateInteractionIds.Number(c, offer)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateInteractionIds.Number(c, offer);`
- `NationalSpire.PrivateTurn.PrivateTurn()`；输入表达式：`new PrivateTurn { Id = turn.Id + ":arbitration:" + person, User = turn.Text, Day = turn.Day, Season = data.Season, RequestKind = "arbitration" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateTurn { Id = turn.Id + ":arbitration:" + person, User = turn.Text, Day = turn.Day, Season = data.Season, RequestKind = "arbitration" }`
- `NationalSpire.SpireArbitration.Complete(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, NationalSpire.ArbitrationDecision)`；输入表达式：`SpireArbitration.Complete(data, c, local, decision)`；返回值紧邻使用处：`ExpressionStatementSyntax: SpireArbitration.Complete(data, c, local, decision);`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Offers.FirstOrDefault(o => o.TurnId == local.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Offers.FirstOrDefault(o => o.TurnId == local.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`guilty.Where(id => id != representative).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: post.RelatedPeople = guilty.Where(id => id != representative).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`guilty.Where(id => id != representative)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: guilty.Where(id => id != representative).ToList`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.Turns.Add(local)`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Turns.Add(local);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`turn.Effects.Add(new() { Human = turn.Sender, Person = person, Lane = turn.Sender + "/" + person + "/", Turn = local.Id })`；返回值紧邻使用处：`ExpressionStatementSyntax: turn.Effects.Add(new() { Human = turn.Sender, Person = person, Lane = turn.Sender + "/" + person + "/", Turn = local.Id });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`turn.Notices.Add(GroupChats.Name(data, person) + "：" + decision.Finding)`；返回值紧邻使用处：`ExpressionStatementSyntax: turn.Notices.Add(GroupChats.Name(data, person) + "：" + decision.Finding);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`turn.Replies.Add(new() { Author = person, Text = decision.Apology, Day = turn.Day, TurnId = turn.Id, Order = GroupChats.NextOrder(data) })`；返回值紧邻使用处：`ExpressionStatementSyntax: turn.Replies.Add(new() { Author = person, Text = decision.Apology, Day = turn.Day, TurnId = turn.Id, Order = GroupChats.NextOrder(data) });`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`c.Offers.Remove(post)`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Offers.Remove(post);`
- `System.Math.Max(long, long)`；输入表达式：`Math.Max(c.LastInteractionNumber, group.LastInteractionNumber)`；返回值紧邻使用处：`AssignmentExpressionSyntax: c.LastInteractionNumber = Math.Max(c.LastInteractionNumber, group.LastInteractionNumber)`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`body.GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: body.GetString() ?? post.Detail`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`title.GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: title.GetString() ?? post.Title`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`root.TryGetProperty("PublicBody", out var body)`；返回值紧邻使用处：`IfStatementSyntax: if (root.TryGetProperty("PublicBody", out var body)) post.Detail = body.GetString() ?? post.Detail;`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`root.TryGetProperty("PublicTitle", out var title)`；返回值紧邻使用处：`IfStatementSyntax: if (root.TryGetProperty("PublicTitle", out var title)) post.Title = title.GetString() ?? post.Title;`

**赋值（含属性/字段和局部值）：**

- `Author` = `person`
- `c.LastInteractionNumber` = `Math.Max(c.LastInteractionNumber, group.LastInteractionNumber)`
- `Day` = `turn.Day`
- `group.LastInteractionNumber` = `c.LastInteractionNumber`
- `Human` = `turn.Sender`
- `Id` = `turn.Id + ":arbitration:" + person`
- `Lane` = `turn.Sender + "/" + person + "/"`
- `Order` = `GroupChats.NextOrder(data)`
- `Person` = `person`
- `post.ActorId` = `person`
- `post.Detail` = `body.GetString() ?? post.Detail`
- `post.GroupId` = `group.Id`
- `post.RelatedPeople` = `guilty.Where(id => id != representative).ToList()`
- `post.Title` = `title.GetString() ?? post.Title`
- `RequestKind` = `"arbitration"`
- `Season` = `data.Season`
- `Text` = `decision.Apology`
- `Turn` = `local.Id`
- `TurnId` = `turn.Id`
- `User` = `turn.Text`
