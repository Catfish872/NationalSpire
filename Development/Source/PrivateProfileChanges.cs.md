# PrivateProfileChanges.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`4B9A84FF815E343C1DB9531693D6BD7A531E47B768AADEDB1DEB2316BAE9577B`。来源：[源码](../../PrivateProfileChanges.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.PrivateProfileChange`、`NationalSpire.PrivateProfileChanges`。

字段、事件及初始值（源码原样）：

```csharp
public static readonly string[] Fields = ["性格类型", "性格概述", "判断事情的习惯", "交往习惯", "面对压力", "玩笑偏好", "亲疏立场", "求知倾向", "打法", "说话习惯", "擅长角色"];
```

<a id="symbol-e167cf6ef1a8"></a>

## `NationalSpire.PrivateProfileChange.Id — public string Id`

来源：源码第 5 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Guid.NewGuid()`；`System.Guid.ToString(string?)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Guid.NewGuid().ToString("N")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1f0e7313c29f"></a>

## `NationalSpire.PrivateProfileChange.Field — public string Field`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-af1b0ab310f1"></a>

## `NationalSpire.PrivateProfileChange.Before — public string Before`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-69108eaa83bf"></a>

## `NationalSpire.PrivateProfileChange.After — public string After`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a5490f3b992c"></a>

## `NationalSpire.PrivateProfileChange.Reason — public string Reason`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6c1d9008f7a2"></a>

## `NationalSpire.PrivateProfileChanges.Label(string) — public static string Label(string field)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPrivateProfileChange(NationalSpire.PrivateProfileChange)`](PrivateMemoryScreen.cs.md#symbol-cd1de98ddea7)；[`NationalSpire.GroupInteractions.Apply(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn, System.Collections.Generic.IEnumerable<System.Collections.Generic.Dictionary<string, string>>)`](GroupInteractions.cs.md#symbol-2b413a511485)；[`NationalSpire.PrivateProfileChanges.Apply(NationalSpire.CareerPerson, NationalSpire.PrivateProfileChange)`](PrivateProfileChanges.cs.md#symbol-c409575d5f79)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2ca919f5172e"></a>

## `NationalSpire.PrivateProfileChanges.Value(NationalSpire.CareerPerson, string) — public static string Value(CareerPerson p, string field)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool)`](PrivateInteractionUndo.cs.md#symbol-de9e985d044d)；[`NationalSpire.PrivateInteractionHistory.Rewind(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn)`](PrivateInteractionUndo.cs.md#symbol-f2cc1906a6b6)；[`NationalSpire.PrivateProfileChanges.Apply(NationalSpire.CareerPerson, NationalSpire.PrivateProfileChange)`](PrivateProfileChanges.cs.md#symbol-c409575d5f79)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.Character`；`NationalSpire.CareerPerson.Personality`；`NationalSpire.CareerPerson.Style`；`NationalSpire.CareerPerson.Temperament`；`NationalSpire.CareerPerson.Voice`；`NationalSpire.PersonalityProfile.Curiosity`；`NationalSpire.PersonalityProfile.Evidence`；`NationalSpire.PersonalityProfile.Humor`；`NationalSpire.PersonalityProfile.Kind`；`NationalSpire.PersonalityProfile.Loyalty`；`NationalSpire.PersonalityProfile.Pressure`；`NationalSpire.PersonalityProfile.Social`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c409575d5f79"></a>

## `NationalSpire.PrivateProfileChanges.Apply(NationalSpire.CareerPerson, NationalSpire.PrivateProfileChange) — public static bool Apply(CareerPerson p, PrivateProfileChange change)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`](PrivateMessages.cs.md#symbol-7bf623828ccc)；[`NationalSpire.PrivateProfileChanges.Merge(NationalSpire.CareerData, NationalSpire.PrivateMailbox)`](PrivateProfileChanges.cs.md#symbol-2bbdc0f01046)；[`NationalSpire.SpireArbitration.Complete(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, NationalSpire.ArbitrationDecision)`](SpireArbitration.cs.md#symbol-7bc24f64a697)

**调用：** [`NationalSpire.PrivateProfileChanges.Label(string)`](PrivateProfileChanges.cs.md#symbol-6c1d9008f7a2)；[`NationalSpire.PrivateProfileChanges.SetValue(NationalSpire.CareerPerson, string, string)`](PrivateProfileChanges.cs.md#symbol-ad07c3469174)；[`NationalSpire.PrivateProfileChanges.Value(NationalSpire.CareerPerson, string)`](PrivateProfileChanges.cs.md#symbol-2ca919f5172e)；`string.IsNullOrWhiteSpace(string?)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.Personality`；`NationalSpire.CareerPerson.PrivateProfileReceipts`；`NationalSpire.CharacterDefinition.DisplayName`；`NationalSpire.CharacterDefinition.Id`；`NationalSpire.CharacterIdentity.Source`；`NationalSpire.PersonalityLibrary.Version`；`NationalSpire.PersonalityProfile.Version`；`NationalSpire.PrivateProfileChange.After`；`NationalSpire.PrivateProfileChange.Before`；`NationalSpire.PrivateProfileChange.Field`；`NationalSpire.PrivateProfileChange.Id`；`NationalSpire.PrivateProfileChange.Reason`；`NationalSpire.PrivateProfileChanges.Fields`；`NationalSpire.PrivateProfileChanges.Label(string)`；`NationalSpire.PrivateProfileChanges.SetValue(NationalSpire.CareerPerson, string, string)`；`NationalSpire.PrivateProfileChanges.Value(NationalSpire.CareerPerson, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateProfileChanges.Label(string)`；输入表达式：`Label(f)`；返回值紧邻使用处：`BinaryExpressionSyntax: Label(f) == change.Field`
- `NationalSpire.PrivateProfileChanges.SetValue(NationalSpire.CareerPerson, string, string)`；输入表达式：`SetValue(p, change.Field, change.After)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetValue(p, change.Field, change.After);`
- `NationalSpire.PrivateProfileChanges.Value(NationalSpire.CareerPerson, string)`；输入表达式：`Value(p, change.Field)`；返回值紧邻使用处：`AssignmentExpressionSyntax: change.Before = Value(p, change.Field)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(change.After)`；返回值紧邻使用处：`BinaryExpressionSyntax: !Fields.Contains(change.Field) || string.IsNullOrWhiteSpace(change.After)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(change.Reason)`；返回值紧邻使用处：`BinaryExpressionSyntax: !Fields.Contains(change.Field) || string.IsNullOrWhiteSpace(change.After) || change.After.Length > 1200              || string.IsNullOrWhiteSpace(change.Reason)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`p.PrivateProfileReceipts.Add(change.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: p.PrivateProfileReceipts.Add(change.Id);`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`p.PrivateProfileReceipts.Contains(change.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: !Fields.Contains(change.Field) || string.IsNullOrWhiteSpace(change.After) || change.After.Length > 1200              || string.IsNullOrWhiteSpace(change.Reason) || p.PrivateProfileReceipts.Contains(change.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`CharacterIdentity.Source().Any(c => c.DisplayName == change.After || c.Id == change.After)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CharacterIdentity.Source().Any(c => c.DisplayName == change.After || c.Id == change.After)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`Fields.Contains(change.Field)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Fields.Contains(change.Field)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`new[] { "铁甲战士", "静默猎手", "故障机器人", "亡灵契约师", "储君" }.Contains(change.After)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !new[] { "铁甲战士", "静默猎手", "故障机器人", "亡灵契约师", "储君" }.Contains(change.After)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`Fields.FirstOrDefault(f => f == change.Field || Label(f) == change.Field)`；返回值紧邻使用处：`BinaryExpressionSyntax: Fields.FirstOrDefault(f => f == change.Field || Label(f) == change.Field) ?? change.Field`
- `System.Func<TResult>.Invoke()`；输入表达式：`CharacterIdentity.Source()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CharacterIdentity.Source().Any`

**赋值（含属性/字段和局部值）：**

- `change.Before` = `Value(p, change.Field)`
- `change.Field` = `Fields.FirstOrDefault(f => f == change.Field || Label(f) == change.Field) ?? change.Field`
- `p.Personality.Version` = `PersonalityLibrary.Version`

<a id="symbol-ad07c3469174"></a>

## `NationalSpire.PrivateProfileChanges.SetValue(NationalSpire.CareerPerson, string, string) — internal static void SetValue(CareerPerson p, string field, string value)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateInteractionHistory.Restore(NationalSpire.CareerData, string, System.Text.Json.Nodes.JsonObject, bool)`](PrivateInteractionUndo.cs.md#symbol-dd91210e87c0)；[`NationalSpire.PrivateInteractionHistory.Rewind(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn)`](PrivateInteractionUndo.cs.md#symbol-f2cc1906a6b6)；[`NationalSpire.PrivateProfileChanges.Apply(NationalSpire.CareerPerson, NationalSpire.PrivateProfileChange)`](PrivateProfileChanges.cs.md#symbol-c409575d5f79)

**调用：** [`NationalSpire.CharacterIdentity.OriginalName(string)`](CharacterIdentity.cs.md#symbol-94292e3754dd)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.Character`；`NationalSpire.CareerPerson.Personality`；`NationalSpire.CareerPerson.Style`；`NationalSpire.CareerPerson.Temperament`；`NationalSpire.CareerPerson.Voice`；`NationalSpire.CharacterIdentity.OriginalName(string)`；`NationalSpire.PersonalityProfile.Curiosity`；`NationalSpire.PersonalityProfile.Evidence`；`NationalSpire.PersonalityProfile.Humor`；`NationalSpire.PersonalityProfile.Kind`；`NationalSpire.PersonalityProfile.Loyalty`；`NationalSpire.PersonalityProfile.Pressure`；`NationalSpire.PersonalityProfile.Social`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CharacterIdentity.OriginalName(string)`；输入表达式：`CharacterIdentity.OriginalName(value)`；返回值紧邻使用处：`BinaryExpressionSyntax: CharacterIdentity.OriginalName(value) ?? value`

**赋值（含属性/字段和局部值）：**

- `p.Character` = `CharacterIdentity.OriginalName(value) ?? value`
- `p.Personality.Curiosity` = `value`
- `p.Personality.Evidence` = `value`
- `p.Personality.Humor` = `value`
- `p.Personality.Kind` = `value`
- `p.Personality.Loyalty` = `value`
- `p.Personality.Pressure` = `value`
- `p.Personality.Social` = `value`
- `p.Style` = `value`
- `p.Temperament` = `value`
- `p.Voice` = `value`

<a id="symbol-2bbdc0f01046"></a>

## `NationalSpire.PrivateProfileChanges.Merge(NationalSpire.CareerData, NationalSpire.PrivateMailbox) — public static void Merge(CareerData data, PrivateMailbox mailbox)`

来源：源码第 58 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Save(NationalSpire.CareerData)`](Coop/CoopPrivateMessages.cs.md#symbol-d510c10d173d)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.PrivateProfileChanges.Apply(NationalSpire.CareerPerson, NationalSpire.PrivateProfileChange)`](PrivateProfileChanges.cs.md#symbol-c409575d5f79)；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateProfileChanges.Apply(NationalSpire.CareerPerson, NationalSpire.PrivateProfileChange)`；`NationalSpire.PrivateTurn.Applied`；`NationalSpire.PrivateTurn.ProfileChanges`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, c.PersonId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(data, c.PersonId) is { } p`
- `NationalSpire.PrivateProfileChanges.Apply(NationalSpire.CareerPerson, NationalSpire.PrivateProfileChange)`；输入表达式：`Apply(p, change)`；返回值紧邻使用处：`ExpressionStatementSyntax: Apply(p, change);`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`c.Turns.Where(t => t.Applied).SelectMany(t => t.ProfileChanges)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var change in c.Turns.Where(t => t.Applied).SelectMany(t => t.ProfileChanges)) Apply(p, change);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.Where(t => t.Applied)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Turns.Where(t => t.Applied).SelectMany`

**赋值（含属性/字段和局部值）：**


<a id="symbol-930916e1d31b"></a>

## `NationalSpire.PrivateProfileChanges.Publish(NationalSpire.CareerData, string, NationalSpire.PrivateOffer) — public static string? Publish(CareerData data, string person, PrivateOffer offer)`

来源：源码第 64 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CommunityMentions.Resolve(NationalSpire.CareerData, string)`](CommunityMentions.cs.md#symbol-a915a754512b)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-0da035a7b345)；[`NationalSpire.CommunityThreads.TrimFeed(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-460bb0bb6649)；[`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；[`NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`](SpireArbitration.cs.md#symbol-909e0981d663)；`NationalSpire.CommunityPost.CommunityPost()`；`string.IsNullOrWhiteSpace(string?)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.Insert(int, T)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiWorkState.State`；`NationalSpire.ArbitrationRecord.Id`；`NationalSpire.ArbitrationRecord.Upheld`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerData.Posts`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Arbitrations`；`NationalSpire.CommunityMentions.Resolve(NationalSpire.CareerData, string)`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Body`；`NationalSpire.CommunityPost.Category`；`NationalSpire.CommunityPost.Day`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.MentionedPeople`；`NationalSpire.CommunityPost.NeedsReaction`；`NationalSpire.CommunityPost.NewsGeneration`；`NationalSpire.CommunityPost.PersonalPost`；`NationalSpire.CommunityPost.RelatedPeople`；`NationalSpire.CommunityPost.Title`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.CommunityThreads.TrimFeed(NationalSpire.CareerData)`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.MatchId`；`NationalSpire.PrivateOffer.RelatedPeople`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.Title`；`NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, person)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(data, person) is { } p`
- `NationalSpire.CommunityMentions.Resolve(NationalSpire.CareerData, string)`；输入表达式：`CommunityMentions.Resolve(data, post.Title + "\n" + post.Body)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityMentions.Resolve(data, post.Title + "\n" + post.Body).Concat`
- `NationalSpire.CommunityPost.CommunityPost()`；输入表达式：`new CommunityPost { Id = id, AuthorId = person, Title = offer.Title, Body = offer.Detail,                  Day = data.Day, Category = "选手动态", PersonalPost = true, NeedsReaction = true, RelatedPeople = [person, data.LocalHumanId.Length > 0 ? data.LocalHumanId : "player"] }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CommunityPost { Id = id, AuthorId = person, Title = offer.Title, Body = offer.Detail,                  Day = data.Day, Category = "选手动态", PersonalPost = true, NeedsReaction = true, RelatedPeople = [person, data.LocalHumanId.Length > 0 ? data.LocalHumanId : "player"] }`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).Any`
- `NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.Remember(data, post)`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.Remember(data, post);`
- `NationalSpire.CommunityThreads.TrimFeed(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.TrimFeed(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: CommunityThreads.TrimFeed(data);`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(data, person)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateMessages.CanChat(data, person)`
- `NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`；输入表达式：`SpireArbitration.Muted(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Person(data, person) is { } p && SpireArbitration.Muted(p)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(offer.Detail)`；返回值紧邻使用处：`BinaryExpressionSyntax: !PrivateMessages.CanChat(data, person) || string.IsNullOrWhiteSpace(offer.Title) || string.IsNullOrWhiteSpace(offer.Detail)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(offer.Title)`；返回值紧邻使用处：`BinaryExpressionSyntax: !PrivateMessages.CanChat(data, person) || string.IsNullOrWhiteSpace(offer.Title)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(data).Any(p => p.Id == id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CommunityThreads.All(data).Any(p => p.Id == id)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`p.Arbitrations.Any(r => offer.Id == "arbitration-" + r.Id && r.Upheld)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !p.Arbitrations.Any(r => offer.Id == "arbitration-" + r.Id && r.Upheld)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`CommunityMentions.Resolve(data, post.Title + "\n" + post.Body).Concat(offer.RelatedPeople)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityMentions.Resolve(data, post.Title + "\n" + post.Body).Concat(offer.RelatedPeople).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`post.RelatedPeople.Concat(offer.RelatedPeople)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.RelatedPeople.Concat(offer.RelatedPeople).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`CommunityMentions.Resolve(data, post.Title + "\n" + post.Body).Concat(offer.RelatedPeople).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityMentions.Resolve(data, post.Title + "\n" + post.Body).Concat(offer.RelatedPeople).Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`post.RelatedPeople.Concat(offer.RelatedPeople).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.RelatedPeople.Concat(offer.RelatedPeople).Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`CommunityMentions.Resolve(data, post.Title + "\n" + post.Body).Concat(offer.RelatedPeople).Distinct().ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: post.MentionedPeople = CommunityMentions.Resolve(data, post.Title + "\n" + post.Body).Concat(offer.RelatedPeople).Distinct().ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`post.RelatedPeople.Concat(offer.RelatedPeople).Distinct().ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: post.RelatedPeople = post.RelatedPeople.Concat(offer.RelatedPeople).Distinct().ToList()`
- `System.Collections.Generic.List<T>.Insert(int, T)`；输入表达式：`data.Posts.Insert(0, post)`；返回值紧邻使用处：`ExpressionStatementSyntax: data.Posts.Insert(0, post);`

**赋值（含属性/字段和局部值）：**

- `AuthorId` = `person`
- `Body` = `offer.Detail`
- `Category` = `"选手动态"`
- `Day` = `data.Day`
- `Id` = `id`
- `NeedsReaction` = `true`
- `offer.MatchId` = `id`
- `offer.State` = `"已确认"`
- `PersonalPost` = `true`
- `post.MentionedPeople` = `CommunityMentions.Resolve(data, post.Title + "\n" + post.Body).Concat(offer.RelatedPeople).Distinct().ToList()`
- `post.NewsGeneration.State` = `"completed"`
- `post.RelatedPeople` = `post.RelatedPeople.Concat(offer.RelatedPeople).Distinct().ToList()`
- `RelatedPeople` = `[person, data.LocalHumanId.Length > 0 ? data.LocalHumanId : "player"]`
- `Title` = `offer.Title`
