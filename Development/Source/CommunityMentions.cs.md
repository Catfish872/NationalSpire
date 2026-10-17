# CommunityMentions.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`EFDA8F88934C48566F8BD6E1CC8B6D55CF0D2B1A6809163727E7D078DEDF6F5B`。来源：[源码](../../CommunityMentions.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CommunityMentions`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-ca8974eb53ca"></a>

## `NationalSpire.CommunityMentions.Token(NationalSpire.CareerData, NationalSpire.CareerPerson) — public static string Token(CareerData data, CareerPerson person)`

来源：源码第 5 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Choose(int)`](MentionComposer.cs.md#symbol-321e08719a8c)；[`NationalSpire.CommunityMentions.Resolve(NationalSpire.CareerData, string)`](CommunityMentions.cs.md#symbol-a915a754512b)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.People`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.PublicName`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.People.Count(p => p.PublicName == person.PublicName)`；返回值紧邻使用处：`BinaryExpressionSyntax: data.People.Count(p => p.PublicName == person.PublicName) > 1`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a915a754512b"></a>

## `NationalSpire.CommunityMentions.Resolve(NationalSpire.CareerData, string) — public static List<string> Resolve(CareerData data, string text)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityMentions.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityMentions.cs.md#symbol-1948490083a8)；[`NationalSpire.CommunityThreads.Publish(NationalSpire.CareerData, string, string)`](CommunityThreads.cs.md#symbol-d9b68d9a8f52)；[`NationalSpire.CommunityThreads.Submit(NationalSpire.CareerData, NationalSpire.CommunityPost, string, string)`](CommunityThreads.cs.md#symbol-4de765d004ff)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)；[`NationalSpire.PrivateProfileChanges.Publish(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](PrivateProfileChanges.cs.md#symbol-930916e1d31b)

**调用：** [`NationalSpire.CommunityMentions.Token(NationalSpire.CareerData, NationalSpire.CareerPerson)`](CommunityMentions.cs.md#symbol-ca8974eb53ca)；[`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`](CommunityThreads.cs.md#symbol-1d3cb55b1636)；[`NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`](SpireArbitration.cs.md#symbol-909e0981d663)；`char.IsAsciiLetterOrDigit(char)`；`string?.AsSpan(int)`；`string.Contains(char)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.List()`；`System.ReadOnlySpan<char>.StartsWith(System.ReadOnlySpan<char>, System.StringComparison)`

**字段、属性、事件及方法组引用：** `(string Id, string Token).Id`；`(string Id, string Token).Token`；`NationalSpire.CareerData.People`；`NationalSpire.CareerPerson.HandleAliases`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Name`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CommunityMentions.Token(NationalSpire.CareerData, NationalSpire.CareerPerson)`；`NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `char.IsAsciiLetterOrDigit(char)`；输入表达式：`char.IsAsciiLetterOrDigit(text[end])`；返回值紧邻使用处：`BinaryExpressionSyntax: end < text.Length && char.IsAsciiLetterOrDigit(text[end])`
- `NationalSpire.CommunityMentions.Token(NationalSpire.CareerData, NationalSpire.CareerPerson)`；输入表达式：`Token(data, p)`；返回值紧邻使用处：`ArgumentSyntax: Token: Token(data, p)`
- `NationalSpire.CommunityThreads.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`CommunityThreads.IsHuman(data, p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CommunityThreads.IsHuman(data, p.Id)`
- `NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`；输入表达式：`SpireArbitration.Muted(p)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !SpireArbitration.Muted(p)`
- `string?.AsSpan(int)`；输入表达式：`text.AsSpan(i)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.AsSpan(i).StartsWith`
- `string.Contains(char)`；输入表达式：`text.Contains('@')`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !text.Contains('@')`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`p.HandleAliases.Append(p.Name).Append(p.PublicName).Where(n => n.Length > 0)                  .Select(n => (p.Id, Token: "@" + n)).Append((p.Id, Token: Token(data, p)))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => p.HandleAliases.Append(p.Name).Append(p.PublicName).Where(n => n.Length > 0)                  .Select(n => (p.Id, Token: "@" + n)).Append((p.Id, Token: Token(data, p)))`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`p.HandleAliases.Append(p.Name).Append(p.PublicName)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.HandleAliases.Append(p.Name).Append(p.PublicName).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`p.HandleAliases.Append(p.Name)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.HandleAliases.Append(p.Name).Append`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`data.People.Where(p => !CommunityThreads.IsHuman(data, p.Id) && !SpireArbitration.Muted(p))              .SelectMany(p => p.HandleAliases.Append(p.Name).Append(p.PublicName).Where(n => n.Length > 0)                  .Select(n => (p.Id, Token: "@" + n)).Append((p.Id, Token: Token(data, p))))              .Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.People.Where(p => !CommunityThreads.IsHuman(data, p.Id) && !SpireArbitration.Muted(p))              .SelectMany(p => p.HandleAliases.Append(p.Name).Append(p.PublicName).Where(n => n.Length > 0)                  .Select(n => (p.Id, Token: "@" + n)).Append((p.Id, Token: Token(data, p))))              .Distinct().OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.People.Where(p => !CommunityThreads.IsHuman(data, p.Id) && !SpireArbitration.Muted(p))              .SelectMany(p => p.HandleAliases.Append(p.Name).Append(p.PublicName).Where(n => n.Length > 0)                  .Select(n => (p.Id, Token: "@" + n)).Append((p.Id, Token: Token(data, p))))              .Distinct().OrderByDescending(p => p.Token.Length)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.People.Where(p => !CommunityThreads.IsHuman(data, p.Id) && !SpireArbitration.Muted(p))              .SelectMany(p => p.HandleAliases.Append(p.Name).Append(p.PublicName).Where(n => n.Length > 0)                  .Select(n => (p.Id, Token: "@" + n)).Append((p.Id, Token: Token(data, p))))              .Distinct().OrderByDescending(p => p.Token.Length).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`p.HandleAliases.Append(p.Name).Append(p.PublicName).Where(n => n.Length > 0)                  .Select(n => (p.Id, Token: "@" + n))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.HandleAliases.Append(p.Name).Append(p.PublicName).Where(n => n.Length > 0)                  .Select(n => (p.Id, Token: "@" + n)).Append`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`data.People.Where(p => !CommunityThreads.IsHuman(data, p.Id) && !SpireArbitration.Muted(p))              .SelectMany(p => p.HandleAliases.Append(p.Name).Append(p.PublicName).Where(n => n.Length > 0)                  .Select(n => (p.Id, Token: "@" + n)).Append((p.Id, Token: Token(data, p))))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.People.Where(p => !CommunityThreads.IsHuman(data, p.Id) && !SpireArbitration.Muted(p))              .SelectMany(p => p.HandleAliases.Append(p.Name).Append(p.PublicName).Where(n => n.Length > 0)                  .Select(n => (p.Id, Token: "@" + n)).Append((p.Id, Token: Token(data, p))))              .Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`data.People.Where(p => !CommunityThreads.IsHuman(data, p.Id) && !SpireArbitration.Muted(p))              .SelectMany(p => p.HandleAliases.Append(p.Name).Append(p.PublicName).Where(n => n.Length > 0)                  .Select(n => (p.Id, Token: "@" + n)).Append((p.Id, Token: Token(data, p))))              .Distinct().OrderByDescending(p => p.Token.Length).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.People.Where(p => !CommunityThreads.IsHuman(data, p.Id) && !SpireArbitration.Muted(p))              .SelectMany(p => p.HandleAliases.Append(p.Name).Append(p.PublicName).Where(n => n.Length > 0)                  .Select(n => (p.Id, Token: "@" + n)).Append((p.Id, Token: Token(data, p))))              .Distinct().OrderByDescending(p => p.Token.Length).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.People.Where(p => !CommunityThreads.IsHuman(data, p.Id) && !SpireArbitration.Muted(p))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.People.Where(p => !CommunityThreads.IsHuman(data, p.Id) && !SpireArbitration.Muted(p))              .SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`p.HandleAliases.Append(p.Name).Append(p.PublicName).Where(n => n.Length > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.HandleAliases.Append(p.Name).Append(p.PublicName).Where(n => n.Length > 0)                  .Select`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.Add(p.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Add(p.Id);`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`result.Contains(p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !result.Contains(p.Id)`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string>()`
- `System.ReadOnlySpan<char>.StartsWith(System.ReadOnlySpan<char>, System.StringComparison)`；输入表达式：`text.AsSpan(i).StartsWith(p.Token, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !text.AsSpan(i).StartsWith(p.Token, StringComparison.OrdinalIgnoreCase)`

**赋值（含属性/字段和局部值）：**

- `i` = `end - 1`

<a id="symbol-ade418ea1da5"></a>

## `NationalSpire.CommunityMentions.Required(NationalSpire.CommunityPost, System.Collections.Generic.ISet<string>) — public static List<string> Required(CommunityPost post, ISet<string> requested)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.DiscussionPeople(NationalSpire.CareerData, NationalSpire.CommunityPost, System.Collections.Generic.ISet<string>)`](AiDiscussion.cs.md#symbol-02eb53d0adba)

**调用：** `System.Collections.Generic.ICollection<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.MentionedPeople`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityReply.MentionedPeople`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.ICollection<T>.Contains(T)`；输入表达式：`requested.Contains(post.Id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: requested.Contains(post.Id) ? post.MentionedPeople : []`
- `System.Collections.Generic.ICollection<T>.Contains(T)`；输入表达式：`requested.Contains(r.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r => requested.Contains(r.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`(requested.Contains(post.Id) ? post.MentionedPeople : [])          .Concat(post.Replies.Where(r => requested.Contains(r.Id)).SelectMany(r => r.MentionedPeople))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (requested.Contains(post.Id) ? post.MentionedPeople : [])          .Concat(post.Replies.Where(r => requested.Contains(r.Id)).SelectMany(r => r.MentionedPeople)).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`(requested.Contains(post.Id) ? post.MentionedPeople : [])          .Concat(post.Replies.Where(r => requested.Contains(r.Id)).SelectMany(r => r.MentionedPeople)).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (requested.Contains(post.Id) ? post.MentionedPeople : [])          .Concat(post.Replies.Where(r => requested.Contains(r.Id)).SelectMany(r => r.MentionedPeople)).Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`post.Replies.Where(r => requested.Contains(r.Id)).SelectMany(r => r.MentionedPeople)`；返回值紧邻使用处：`ArgumentSyntax: post.Replies.Where(r => requested.Contains(r.Id)).SelectMany(r => r.MentionedPeople)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`(requested.Contains(post.Id) ? post.MentionedPeople : [])          .Concat(post.Replies.Where(r => requested.Contains(r.Id)).SelectMany(r => r.MentionedPeople)).Distinct().ToList()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>          (requested.Contains(post.Id) ? post.MentionedPeople : [])          .Concat(post.Replies.Where(r => requested.Contains(r.Id)).SelectMany(r => r.MentionedPeople)).Distinct().ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.Replies.Where(r => requested.Contains(r.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.Replies.Where(r => requested.Contains(r.Id)).SelectMany`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1948490083a8"></a>

## `NationalSpire.CommunityMentions.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost) — public static bool Remember(CareerData data, CommunityPost post)`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityThreads.Remember(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-0da035a7b345)

**调用：** [`NationalSpire.CommunityMentions.Resolve(NationalSpire.CareerData, string)`](CommunityMentions.cs.md#symbol-a915a754512b)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityMentions.Resolve(NationalSpire.CareerData, string)`；`NationalSpire.CommunityPost.Body`；`NationalSpire.CommunityPost.MentionedPeople`；`NationalSpire.CommunityPost.RelatedPeople`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityPost.Title`；`NationalSpire.CommunityReply.Body`；`NationalSpire.CommunityReply.MentionedPeople`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityMentions.Resolve(NationalSpire.CareerData, string)`；输入表达式：`Resolve(data, post.Title + "\n" + post.Body + "\n" + string.Join("\n", post.Replies.Select(r => r.Body)))`；返回值紧邻使用处：`ArgumentSyntax: Resolve(data, post.Title + "\n" + post.Body + "\n" + string.Join("\n", post.Replies.Select(r => r.Body)))`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", post.Replies.Select(r => r.Body))`；返回值紧邻使用处：`BinaryExpressionSyntax: post.Title + "\n" + post.Body + "\n" + string.Join("\n", post.Replies.Select(r => r.Body))`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`post.MentionedPeople.Concat(post.Replies.SelectMany(r => r.MentionedPeople))              .Concat(Resolve(data, post.Title + "\n" + post.Body + "\n" + string.Join("\n", post.Replies.Select(r => r.Body))))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = post.MentionedPeople.Concat(post.Replies.SelectMany(r => r.MentionedPeople))              .Concat(Resolve(data, post.Title + "\n" + post.Body + "\n" + string.Join("\n", post.Replies.Select(r => r.Body))))`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`post.MentionedPeople.Concat(post.Replies.SelectMany(r => r.MentionedPeople))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.MentionedPeople.Concat(post.Replies.SelectMany(r => r.MentionedPeople))              .Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`mentioned.Distinct()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string id in mentioned.Distinct())              if (!post.RelatedPeople.Contains(id)) { post.RelatedPeople.Add(id); changed = true; }`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`post.Replies.Select(r => r.Body)`；返回值紧邻使用处：`ArgumentSyntax: post.Replies.Select(r => r.Body)`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`post.Replies.SelectMany(r => r.MentionedPeople)`；返回值紧邻使用处：`ArgumentSyntax: post.Replies.SelectMany(r => r.MentionedPeople)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`post.RelatedPeople.Add(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: post.RelatedPeople.Add(id);`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`post.RelatedPeople.Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !post.RelatedPeople.Contains(id)`

**赋值（含属性/字段和局部值）：**

- `changed` = `true`
