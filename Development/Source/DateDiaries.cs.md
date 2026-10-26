# DateDiaries.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`07A5DF925F9634A68577B55494097480BE0EC2B0289FEC506544523EC0882167`。来源：[源码](../../DateDiaries.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DateDiary`、`NationalSpire.DateDiaries`。

字段、事件及初始值（源码原样）：

```csharp
public const string Protocol = "本次约会已由玩家明确结束。先以NPC身份发送自然的私信感想，再在回复末尾附一条隐藏日记标记："
            + "[DateDiary: 用NPC第一人称写下这次相处的经过、印象与感受, Location: 实际约会地点]。"
            + "日记依据下面完整的本次约会记录，约150至350字；只经历开场时如实简述。地点未明确时写地点未明确。"
            + "日记与私信同一轮输出；日记标记放在正文之后，内容中的方括号改用中文圆括号。其余私信交互标记沿用原规则。\n";
public const string ToolEnding = "本次约会已结束。本轮同时提交两项内容：Replies填写NPC发给玩家的自然私聊感想；Interactions填写一项Type为date_diary的日记记录，DateDiary用NPC第一人称记述本次经过、印象与感受，约150至350字，Location填写实际地点，地点未明确时写地点未明确。只经历开场时如实简述。已有日记时根据本次完整记录重新整理，返回内容用于更新同一篇日记。其他实际交互按各项说明另行填写。";
```

<a id="symbol-cbe88c909001"></a>

## `NationalSpire.DateDiary.OfferId — public string OfferId`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9f601c531d1e"></a>

## `NationalSpire.DateDiary.Season — public int Season`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1d63cae84ee0"></a>

## `NationalSpire.DateDiary.Day — public int Day`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-60e53ed7ca6b"></a>

## `NationalSpire.DateDiary.Title — public string Title`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8d49255fef9e"></a>

## `NationalSpire.DateDiary.Content — public string Content`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b5985fbd4437"></a>

## `NationalSpire.DateDiary.Location — public string Location`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b57fec85da5a"></a>

## `NationalSpire.DateDiary.Summary — public string Summary`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-24329f1d823f"></a>

## `NationalSpire.DateDiaries.Records(NationalSpire.PrivateConversation) — public static IReadOnlyList<DateDiary> Records(PrivateConversation conversation)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`](DateDiaryScreen.cs.md#symbol-fb4ba1a3b5fa)；[`NationalSpire.DateDiaries.Delete(NationalSpire.CareerData, string, string)`](DateDiaries.cs.md#symbol-cc817bdd15ec)；[`NationalSpire.DateDiaries.ForPerson(NationalSpire.CareerData, string)`](DateDiaries.cs.md#symbol-61a0ccdee0e3)

**调用：** `NationalSpire.DateDiary.DateDiary()`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateDiary.Content`；`NationalSpire.DateDiary.Day`；`NationalSpire.DateDiary.Location`；`NationalSpire.DateDiary.OfferId`；`NationalSpire.DateDiary.Season`；`NationalSpire.DateDiary.Summary`；`NationalSpire.DateDiary.Title`；`NationalSpire.DateSceneRequest.Detail`；`NationalSpire.DateSceneRequest.Ending`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateSceneRequest.Opening`；`NationalSpire.DateSceneRequest.Title`；`NationalSpire.PrivateConversation.DateDiaries`；`NationalSpire.PrivateConversation.DeletedDateDiaries`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateOffer.Day`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Season`；`NationalSpire.PrivateOffer.Title`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.Season`；`NationalSpire.PrivateTurn.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateDiary.DateDiary()`；输入表达式：`new() { OfferId = group.Key, Season = offer?.Season ?? first.Season, Day = offer?.Day ?? 0, Title = offer?.Title ?? first.Scene!.Title, Content = offer?.Detail ?? first.Scene!.Detail, Location = "历史记录未标注地点", Summary = reflection?.Reply ?? "这次约会尚未生成日记。" }`；返回值紧邻使用处：`ArgumentSyntax: new() { OfferId = group.Key, Season = offer?.Season ?? first.Season, Day = offer?.Day ?? 0, Title = offer?.Title ?? first.Scene!.Title, Content = offer?.Detail ?? first.Scene!.Detail, Location = "历史记录未标注地点", Summary = reflection?.Reply ?? "这次约会尚未生成日记。" }`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`conversation.DeletedDateDiaries.Contains(d.OfferId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !conversation.DeletedDateDiaries.Contains(d.OfferId)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`conversation.DeletedDateDiaries.Contains(group.Key)`；返回值紧邻使用处：`BinaryExpressionSyntax: conversation.DeletedDateDiaries.Contains(group.Key) || records.Any(d => d.OfferId == group.Key)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`records.Any(d => d.OfferId == group.Key)`；返回值紧邻使用处：`BinaryExpressionSyntax: conversation.DeletedDateDiaries.Contains(group.Key) || records.Any(d => d.OfferId == group.Key)`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；输入表达式：`group.First()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = group.First()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Offers.FirstOrDefault(o => o.Id == group.Key)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = conversation.Offers.FirstOrDefault(o => o.Id == group.Key)`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`conversation.Turns.Where(t => t.Scene is { Opening: true } or { Ending: true }).GroupBy(t => t.Scene!.OfferId)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var group in conversation.Turns.Where(t => t.Scene is { Opening: true } or { Ending: true }).GroupBy(t => t.Scene!.OfferId)) { if (conversation.DeletedDateDiaries.Contains(group.Key) || records.Any(d => d.OfferId == group.Key)) continue; var first = group.First(); var offer = conversation.Offers.FirstOrDefault(o => o.Id == group.Key); var reflection = group.LastOrDefault(t => t.Scene!.Ending && t.Status == "complete" && !t.ReplyDeleted); records.Add(new() { OfferId = group.Key, Season = offer?.Season ?? first.Season, Day = offer?.Day ?? 0, Title = offer?.Title ?? first.Scene!.Title, Content = offer?.Detail ?? first.Scene!.Detail, Location = "历史记录未标注地点", Summary = reflection?.Reply ?? "这次约会尚未生成日记。" }); }`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`group.LastOrDefault(t => t.Scene!.Ending && t.Status == "complete" && !t.ReplyDeleted)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = group.LastOrDefault(t => t.Scene!.Ending && t.Status == "complete" && !t.ReplyDeleted)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`conversation.DateDiaries.Where(d => !conversation.DeletedDateDiaries.Contains(d.OfferId)).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = conversation.DateDiaries.Where(d => !conversation.DeletedDateDiaries.Contains(d.OfferId)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.DateDiaries.Where(d => !conversation.DeletedDateDiaries.Contains(d.OfferId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: conversation.DateDiaries.Where(d => !conversation.DeletedDateDiaries.Contains(d.OfferId)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Turns.Where(t => t.Scene is { Opening: true } or { Ending: true })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: conversation.Turns.Where(t => t.Scene is { Opening: true } or { Ending: true }).GroupBy`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`records.Add(new() { OfferId = group.Key, Season = offer?.Season ?? first.Season, Day = offer?.Day ?? 0, Title = offer?.Title ?? first.Scene!.Title, Content = offer?.Detail ?? first.Scene!.Detail, Location = "历史记录未标注地点", Summary = reflection?.Reply ?? "这次约会尚未生成日记。" })`；返回值紧邻使用处：`ExpressionStatementSyntax: records.Add(new() { OfferId = group.Key, Season = offer?.Season ?? first.Season, Day = offer?.Day ?? 0, Title = offer?.Title ?? first.Scene!.Title, Content = offer?.Detail ?? first.Scene!.Detail, Location = "历史记录未标注地点", Summary = reflection?.Reply ?? "这次约会尚未生成日记。" });`

**赋值（含属性/字段和局部值）：**

- `Content` = `offer?.Detail ?? first.Scene!.Detail`
- `Day` = `offer?.Day ?? 0`
- `Location` = `"历史记录未标注地点"`
- `OfferId` = `group.Key`
- `Season` = `offer?.Season ?? first.Season`
- `Summary` = `reflection?.Reply ?? "这次约会尚未生成日记。"`
- `Title` = `offer?.Title ?? first.Scene!.Title`

<a id="symbol-cc817bdd15ec"></a>

## `NationalSpire.DateDiaries.Delete(NationalSpire.CareerData, string, string) — public static string? Delete(CareerData data, string person, string offerId)`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessageCommands.ApplyCore(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-1472969f513b)

**调用：** [`NationalSpire.DateDiaries.Records(NationalSpire.PrivateConversation)`](DateDiaries.cs.md#symbol-24329f1d823f)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateDiaries.Records(NationalSpire.PrivateConversation)`；`NationalSpire.DateDiary.OfferId`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.PrivateConversation.DateDiaries`；`NationalSpire.PrivateConversation.DateSceneStates`；`NationalSpire.PrivateConversation.DeletedDateDiaries`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateTurn.Scene`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateDiaries.Records(NationalSpire.PrivateConversation)`；输入表达式：`Records(c)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Records(c).Any`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`c.DeletedDateDiaries.Add(offerId)`；返回值紧邻使用处：`ExpressionStatementSyntax: c.DeletedDateDiaries.Add(offerId);`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`c.DeletedDateDiaries.Contains(offerId)`；返回值紧邻使用处：`BinaryExpressionSyntax: Records(c).Any(d => d.OfferId == offerId) || c.DeletedDateDiaries.Contains(offerId)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`Records(c).Any(d => d.OfferId == offerId)`；返回值紧邻使用处：`BinaryExpressionSyntax: Records(c).Any(d => d.OfferId == offerId) || c.DeletedDateDiaries.Contains(offerId)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.DateDiaries.Any(d => d.OfferId == offerId)`；返回值紧邻使用处：`BinaryExpressionSyntax: c == source || c.DateDiaries.Any(d => d.OfferId == offerId)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.Any(t => t.Scene?.OfferId == offerId)`；返回值紧邻使用处：`BinaryExpressionSyntax: c == source || c.DateDiaries.Any(d => d.OfferId == offerId) || c.Turns.Any(t => t.Scene?.OfferId == offerId)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversations.FirstOrDefault(c => c.PersonId == person && (Records(c).Any(d => d.OfferId == offerId) || c.DeletedDateDiaries.Contains(offerId) || c.DateSceneStates.GetValueOrDefault(offerId) == "ended"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = conversations.FirstOrDefault(c => c.PersonId == person && (Records(c).Any(d => d.OfferId == offerId) || c.DeletedDateDiaries.Contains(offerId) || c.DateSceneStates.GetValueOrDefault(offerId) == "ended"))`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values.ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Mailbox(data).Conversations.Values.ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversations.Where(c => c == source || c.DateDiaries.Any(d => d.OfferId == offerId) || c.Turns.Any(t => t.Scene?.OfferId == offerId))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var c in conversations.Where(c => c == source || c.DateDiaries.Any(d => d.OfferId == offerId) || c.Turns.Any(t => t.Scene?.OfferId == offerId))) { c.DateDiaries.RemoveAll(d => d.OfferId == offerId); c.DeletedDateDiaries.Add(offerId); }`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`c.DateSceneStates.GetValueOrDefault(offerId)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.DateSceneStates.GetValueOrDefault(offerId) == "ended"`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`source.DateSceneStates.GetValueOrDefault(offerId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: source.DateSceneStates.GetValueOrDefault(offerId) is "active" or "paused"`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`c.DateDiaries.RemoveAll(d => d.OfferId == offerId)`；返回值紧邻使用处：`ExpressionStatementSyntax: c.DateDiaries.RemoveAll(d => d.OfferId == offerId);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-61a0ccdee0e3"></a>

## `NationalSpire.DateDiaries.ForPerson(NationalSpire.CareerData, string) — public static List<(string Host, DateDiary Diary)> ForPerson(CareerData data, string person)`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`](DateDiaryScreen.cs.md#symbol-fb4ba1a3b5fa)；[`NationalSpire.CareerScreen.DeleteDateDiaryDialog(NationalSpire.CareerData, string, NationalSpire.DateDiary, NationalSpire.DateSceneMemory?)`](DateDiaryScreen.cs.md#symbol-d6865c262849)；[`NationalSpire.CareerScreen.PrivateProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivateMessageScreen.cs.md#symbol-8e28d3a34860)

**调用：** [`NationalSpire.DateDiaries.Records(NationalSpire.PrivateConversation)`](DateDiaries.cs.md#symbol-24329f1d823f)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.List()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateDiaries.Records(NationalSpire.PrivateConversation)`；`NationalSpire.DateDiary.OfferId`；`NationalSpire.DateSceneParticipant.PersonId`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateSceneRequest.Participants`；`NationalSpire.PrivateConversation.DeletedDateDiaries`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Participants`；`NationalSpire.PrivateTurn.Scene`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateDiaries.Records(NationalSpire.PrivateConversation)`；输入表达式：`Records(c)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var diary in Records(c)) if (!deleted.Contains(diary.OfferId) && (c.PersonId == person || joined.Contains(diary.OfferId)) && result.All(e => e.Diary.OfferId != diary.OfferId)) result.Add((c.PersonId, diary));`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`deleted.Contains(diary.OfferId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !deleted.Contains(diary.OfferId)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`joined.Contains(diary.OfferId)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.PersonId == person || joined.Contains(diary.OfferId)`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`result.All(e => e.Diary.OfferId != diary.OfferId)`；返回值紧邻使用处：`BinaryExpressionSyntax: !deleted.Contains(diary.OfferId) && (c.PersonId == person || joined.Contains(diary.OfferId)) && result.All(e => e.Diary.OfferId != diary.OfferId)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Participants.Any(p => p.PersonId == person)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: t.Scene?.Participants.Any(p => p.PersonId == person)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`c.Offers.Where(o => o.Participants.Contains(person)).Select(o => o.Id) .Concat(c.Turns.Where(t => t.Scene?.Participants.Any(p => p.PersonId == person) == true).Select(t => t.Scene!.OfferId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Offers.Where(o => o.Participants.Contains(person)).Select(o => o.Id) .Concat(c.Turns.Where(t => t.Scene?.Participants.Any(p => p.PersonId == person) == true).Select(t => t.Scene!.OfferId)).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`c.Offers.Where(o => o.Participants.Contains(person)).Select(o => o.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Offers.Where(o => o.Participants.Contains(person)).Select(o => o.Id) .Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`c.Turns.Where(t => t.Scene?.Participants.Any(p => p.PersonId == person) == true).Select(t => t.Scene!.OfferId)`；返回值紧邻使用处：`ArgumentSyntax: c.Turns.Where(t => t.Scene?.Participants.Any(p => p.PersonId == person) == true).Select(t => t.Scene!.OfferId)`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`conversations.SelectMany(c => c.DeletedDateDiaries)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: conversations.SelectMany(c => c.DeletedDateDiaries).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`c.Offers.Where(o => o.Participants.Contains(person)).Select(o => o.Id) .Concat(c.Turns.Where(t => t.Scene?.Participants.Any(p => p.PersonId == person) == true).Select(t => t.Scene!.OfferId)).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Offers.Where(o => o.Participants.Contains(person)).Select(o => o.Id) .Concat(c.Turns.Where(t => t.Scene?.Participants.Any(p => p.PersonId == person) == true).Select(t => t.Scene!.OfferId)).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`conversations.SelectMany(c => c.DeletedDateDiaries).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = conversations.SelectMany(c => c.DeletedDateDiaries).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Offers.Where(o => o.Participants.Contains(person))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Offers.Where(o => o.Participants.Contains(person)).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.Where(t => t.Scene?.Participants.Any(p => p.PersonId == person) == true)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Turns.Where(t => t.Scene?.Participants.Any(p => p.PersonId == person) == true).Select`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.Add((c.PersonId, diary))`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Add((c.PersonId, diary));`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`o.Participants.Contains(person)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: o => o.Participants.Contains(person)`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<(string Host, DateDiary Diary)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<(string Host, DateDiary Diary)>()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-25266fe7f850"></a>

## `NationalSpire.DateDiaries.Begin(NationalSpire.PrivateConversation, NationalSpire.PrivateOffer) — public static DateDiary Begin(PrivateConversation conversation, PrivateOffer offer)`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateDiaries.Complete(NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IEnumerable<System.Collections.Generic.Dictionary<string, string>>)`](DateDiaries.cs.md#symbol-947bb3a428c9)；[`NationalSpire.DateScenes.Leave(NationalSpire.CareerData, NationalSpire.PrivateConversation, string, bool)`](DateSceneData.cs.md#symbol-81bdbfbfe1d8)

**调用：** `NationalSpire.DateDiary.DateDiary()`；`string.StartsWith(string, System.StringComparison)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateDiary.Content`；`NationalSpire.DateDiary.Day`；`NationalSpire.DateDiary.OfferId`；`NationalSpire.DateDiary.Season`；`NationalSpire.DateDiary.Title`；`NationalSpire.PrivateConversation.DateDiaries`；`NationalSpire.PrivateOffer.Day`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Season`；`NationalSpire.PrivateOffer.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateDiary.DateDiary()`；输入表达式：`new DateDiary { OfferId = offer.Id, Season = offer.Season, Day = offer.Day, Title = offer.Title,              Content = offer.Detail.StartsWith("约会内容：", StringComparison.Ordinal) ? offer.Detail[5..] : offer.Detail }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new DateDiary { OfferId = offer.Id, Season = offer.Season, Day = offer.Day, Title = offer.Title,              Content = offer.Detail.StartsWith("约会内容：", StringComparison.Ordinal) ? offer.Detail[5..] : offer.Detail }`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`offer.Detail.StartsWith("约会内容：", StringComparison.Ordinal)`；返回值紧邻使用处：`ConditionalExpressionSyntax: offer.Detail.StartsWith("约会内容：", StringComparison.Ordinal) ? offer.Detail[5..] : offer.Detail`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.DateDiaries.FirstOrDefault(d => d.OfferId == offer.Id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: conversation.DateDiaries.FirstOrDefault(d => d.OfferId == offer.Id) is { } old`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`conversation.DateDiaries.Add(entry)`；返回值紧邻使用处：`ExpressionStatementSyntax: conversation.DateDiaries.Add(entry);`

**赋值（含属性/字段和局部值）：**

- `Content` = `offer.Detail.StartsWith("约会内容：", StringComparison.Ordinal) ? offer.Detail[5..] : offer.Detail`
- `Day` = `offer.Day`
- `OfferId` = `offer.Id`
- `Season` = `offer.Season`
- `Title` = `offer.Title`

<a id="symbol-81cb927c13c4"></a>

## `NationalSpire.DateDiaries.Guidance(NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest) — public static string Guidance(PrivateConversation conversation, DateSceneRequest scene)`

来源：源码第 73 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessagePrompts.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?, string?, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-de94bbbea5ea)

**调用：** [`NationalSpire.DateScenes.PromptHistory(NationalSpire.PrivateTurn, string)`](DateSceneData.cs.md#symbol-1bee81f08078)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.ChatTools.InPrompt`；`NationalSpire.DateDiaries.Protocol`；`NationalSpire.DateDiaries.ToolEnding`；`NationalSpire.DateSceneRequest.Detail`；`NationalSpire.DateSceneRequest.Ending`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateSceneRequest.Opening`；`NationalSpire.DateSceneRequest.Participants`；`NationalSpire.DateSceneRequest.Title`；`NationalSpire.DateScenes.PromptHistory(NationalSpire.PrivateTurn, string)`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.User`；`NationalSpire.PrivateTurn.UserDeleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateScenes.PromptHistory(NationalSpire.PrivateTurn, string)`；输入表达式：`DateScenes.PromptHistory(t, conversation.PersonId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: t.Scene!.Participants.Count > 1 ? DateScenes.PromptHistory(t, conversation.PersonId) : t.Reply`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`turns.Select(t => new { player = t.UserDeleted || t.Scene!.Opening ? null : t.User, npc = t.ReplyDeleted ? null : t.Scene!.Participants.Count > 1 ? DateScenes.PromptHistory(t, conversation.PersonId) : t.Reply })`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: turns = turns.Select(t => new { player = t.UserDeleted || t.Scene!.Opening ? null : t.User, npc = t.ReplyDeleted ? null : t.Scene!.Participants.Count > 1 ? DateScenes.PromptHistory(t, conversation.PersonId) : t.Reply })`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Turns.Where(t => t.Scene?.OfferId == scene.OfferId && !t.Scene.Ending && t.Status == "complete")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = conversation.Turns.Where(t => t.Scene?.OfferId == scene.OfferId && !t.Scene.Ending && t.Status == "complete")`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(new { scene.Title, scene.Detail, turns = turns.Select(t => new { player = t.UserDeleted || t.Scene!.Opening ? null : t.User, npc = t.ReplyDeleted ? null : t.Scene!.Participants.Count > 1 ? DateScenes.PromptHistory(t, conversation.PersonId) : t.Reply }) })`；返回值紧邻使用处：`BinaryExpressionSyntax: ToolEnding + "以下为本次约会的完整记录。\n" + JsonSerializer.Serialize(new { scene.Title, scene.Detail, turns = turns.Select(t => new { player = t.UserDeleted || t.Scene!.Opening ? null : t.User, npc = t.ReplyDeleted ? null : t.Scene!.Participants.Count > 1 ? DateScenes.PromptHistory(t, conversation.PersonId) : t.Reply }) })`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(new { scene.Title, scene.Detail, turns = turns.Select(t => new { player = t.UserDeleted || t.Scene!.Opening ? null : t.User, npc = t.ReplyDeleted ? null : t.Scene!.Participants.Count > 1 ? DateScenes.PromptHistory(t, conversation.PersonId) : t.Reply }) })`；返回值紧邻使用处：`BinaryExpressionSyntax: Protocol + JsonSerializer.Serialize(new { scene.Title, scene.Detail, turns = turns.Select(t => new { player = t.UserDeleted || t.Scene!.Opening ? null : t.User, npc = t.ReplyDeleted ? null : t.Scene!.Participants.Count > 1 ? DateScenes.PromptHistory(t, conversation.PersonId) : t.Reply }) })`

**赋值（含属性/字段和局部值）：**


<a id="symbol-947bb3a428c9"></a>

## `NationalSpire.DateDiaries.Complete(NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IEnumerable<System.Collections.Generic.Dictionary<string, string>>) — public static void Complete(PrivateConversation conversation, PrivateTurn turn, IEnumerable<Dictionary<string, string>> directives)`

来源：源码第 81 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)

**调用：** [`NationalSpire.DateDiaries.Begin(NationalSpire.PrivateConversation, NationalSpire.PrivateOffer)`](DateDiaries.cs.md#symbol-25266fe7f850)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Math.Min(int, int)`；`System.Text.RegularExpressions.Regex.Match(string, string, System.Text.RegularExpressions.RegexOptions)`；`string.Trim()`；`string.TrimEnd()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateDiaries.Begin(NationalSpire.PrivateConversation, NationalSpire.PrivateOffer)`；`NationalSpire.DateDiary.Location`；`NationalSpire.DateDiary.Summary`；`NationalSpire.DateSceneRequest.Ending`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.PrivateConversation.DeletedDateDiaries`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateTurn.Error`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.Scene`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateDiaries.Begin(NationalSpire.PrivateConversation, NationalSpire.PrivateOffer)`；输入表达式：`Begin(conversation, offer)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Begin(conversation, offer)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`f.ContainsKey("DateDiary")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: f => f.ContainsKey("DateDiary")`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`conversation.DeletedDateDiaries.Contains(scene.OfferId)`；返回值紧邻使用处：`BinaryExpressionSyntax: turn.Scene is not { Ending: true } scene || conversation.DeletedDateDiaries.Contains(scene.OfferId)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Offers.FirstOrDefault(o => o.Id == scene.OfferId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = conversation.Offers.FirstOrDefault(o => o.Id == scene.OfferId)`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`directives.LastOrDefault(f => f.ContainsKey("DateDiary"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = directives.LastOrDefault(f => f.ContainsKey("DateDiary"))`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`.GetValueOrDefault("DateDiary", "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: .GetValueOrDefault("DateDiary", "").Trim`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`.GetValueOrDefault("Location", "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: .GetValueOrDefault("Location", "").Trim`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(300, location.Length)`；返回值紧邻使用处：`RangeExpressionSyntax: ..Math.Min(300, location.Length)`
- `System.Text.RegularExpressions.Regex.Match(string, string, System.Text.RegularExpressions.RegexOptions)`；输入表达式：`Regex.Match(summary, @"\s*[（(]\s*(?:Location|地点)\s*[:：]\s*([^（）()]+)[）)]\s*$", RegexOptions.IgnoreCase)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Regex.Match(summary, @"\s*[（(]\s*(?:Location|地点)\s*[:：]\s*([^（）()]+)[）)]\s*$", RegexOptions.IgnoreCase) is { Success: true } inline`
- `System.Text.RegularExpressions.Regex.Match(string, string, System.Text.RegularExpressions.RegexOptions)`；输入表达式：`Regex.Match(turn.Reply, @"[,，]\s*Location\s*[:：]\s*([^\r\n\[\]]+)\]?\s*$", RegexOptions.IgnoreCase)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Regex.Match(turn.Reply, @"[,，]\s*Location\s*[:：]\s*([^\r\n\[\]]+)\]?\s*$", RegexOptions.IgnoreCase) is { Success: true } trailing`
- `string.Trim()`；输入表达式：`.GetValueOrDefault("DateDiary", "").Trim()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: fields?.GetValueOrDefault("DateDiary", "").Trim()`
- `string.Trim()`；输入表达式：`.GetValueOrDefault("Location", "").Trim()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: fields?.GetValueOrDefault("Location", "").Trim()`
- `string.Trim()`；输入表达式：`inline.Groups[1].Value.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: location = inline.Groups[1].Value.Trim()`
- `string.Trim()`；输入表达式：`trailing.Groups[1].Value.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: location = trailing.Groups[1].Value.Trim()`
- `string.TrimEnd()`；输入表达式：`summary[..inline.Index].TrimEnd()`；返回值紧邻使用处：`AssignmentExpressionSyntax: summary = summary[..inline.Index].TrimEnd()`
- `string.TrimEnd()`；输入表达式：`turn.Reply[..trailing.Index].TrimEnd()`；返回值紧邻使用处：`AssignmentExpressionSyntax: turn.Reply = turn.Reply[..trailing.Index].TrimEnd()`

**赋值（含属性/字段和局部值）：**

- `entry.Location` = `location.Length == 0 ? "地点未明确" : location[..Math.Min(300, location.Length)]`
- `entry.Summary` = `summary.Length > 12000 ? summary[..12000] : summary`
- `location` = `"地点未明确"`
- `location` = `inline.Groups[1].Value.Trim()`
- `location` = `trailing.Groups[1].Value.Trim()`
- `summary` = `summary[..inline.Index].TrimEnd()`
- `turn.Error` += `"\n本次感想已保留，约会日记尚未返回。"`
- `turn.Reply` = `turn.Reply[..trailing.Index].TrimEnd()`
