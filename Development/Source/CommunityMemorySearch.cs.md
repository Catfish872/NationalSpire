# CommunityMemorySearch.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`C72636F50AABC3A20305B54EA59AEC3057FA0096CFC8292480B220456A21570E`。来源：[源码](../../CommunityMemorySearch.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CommunityMemorySearch`、`NationalSpire.CommunityMemorySearch.Request`。

字段、事件及初始值（源码原样）：

```csharp
private readonly Dictionary<string, HashSet<string>> _terms = new(StringComparer.Ordinal);
private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<CareerData, Dictionary<string, (string Text, HashSet<string> Terms)>> Indexes = new();
private static readonly HashSet<string> ConversationNoise = ["今天", "明天", "昨天", "什么", "为什", "么是", "怎么", "知道", "这个", "那个", "现在", "时候", "事情", "没有", "不是", "可以", "还是", "到底", "一下", "你好", "在吗", "在不", "不在", "你说", "说的", "我们", "你们", "自己", "能不", "不能", "觉得"];
```

<a id="symbol-291651d7ac15"></a>

## `NationalSpire.CommunityMemorySearch.Request.GetTerms(string) — internal HashSet<string> GetTerms(string text)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityMemorySearch.MatchesTopic(string, string, NationalSpire.CommunityMemorySearch.Request?)`](CommunityMemorySearch.cs.md#symbol-9f4e57953da4)；[`NationalSpire.CommunityMemorySearch.Retrieve(NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>, int, System.Collections.Generic.ISet<string>, int, System.Collections.Generic.ISet<string>?, bool, NationalSpire.CommunityMemorySearch.Request?)`](CommunityMemorySearch.cs.md#symbol-f933ce4e4ad8)

**调用：** [`NationalSpire.CommunityMemorySearch.Terms(string)`](CommunityMemorySearch.cs.md#symbol-96d927ec7e23)；`System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityMemorySearch.Request._terms`；`NationalSpire.CommunityMemorySearch.Terms(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityMemorySearch.Terms(string)`；输入表达式：`Terms(text)`；返回值紧邻使用处：`AssignmentExpressionSyntax: terms = Terms(text)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`_terms.Add(text, terms = Terms(text))`；返回值紧邻使用处：`ExpressionStatementSyntax: _terms.Add(text, terms = Terms(text));`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`_terms.TryGetValue(text, out var terms)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !_terms.TryGetValue(text, out var terms)`

**赋值（含属性/字段和局部值）：**

- `terms` = `Terms(text)`

<a id="symbol-96d927ec7e23"></a>

## `NationalSpire.CommunityMemorySearch.Terms(string) — private static HashSet<string> Terms(string text)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`IndexedTerms(NationalSpire.CommunityMemory)`](CommunityMemorySearch.cs.md#symbol-3f63ea03e2a7)；[`NationalSpire.CommunityMemorySearch.MatchesTopic(string, string, NationalSpire.CommunityMemorySearch.Request?)`](CommunityMemorySearch.cs.md#symbol-9f4e57953da4)；[`NationalSpire.CommunityMemorySearch.Request.GetTerms(string)`](CommunityMemorySearch.cs.md#symbol-291651d7ac15)；[`NationalSpire.CommunityMemorySearch.Retrieve(NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>, int, System.Collections.Generic.ISet<string>, int, System.Collections.Generic.ISet<string>?, bool, NationalSpire.CommunityMemorySearch.Request?)`](CommunityMemorySearch.cs.md#symbol-f933ce4e4ad8)

**调用：** `string.Substring(int, int)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.HashSet(System.Collections.Generic.IEqualityComparer<T>?)`；`System.Text.RegularExpressions.Regex.Matches(string, string)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Substring(int, int)`；输入表达式：`word.Substring(i, 2)`；返回值紧邻使用处：`ArgumentSyntax: word.Substring(i, 2)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`terms.Add(word.Substring(i, 2))`；返回值紧邻使用处：`ExpressionStatementSyntax: terms.Add(word.Substring(i, 2));`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`terms.Add(word)`；返回值紧邻使用处：`ExpressionStatementSyntax: terms.Add(word);`
- `System.Collections.Generic.HashSet<T>.HashSet(System.Collections.Generic.IEqualityComparer<T>?)`；输入表达式：`new HashSet<string>(StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HashSet<string>(StringComparer.OrdinalIgnoreCase)`
- `System.Text.RegularExpressions.Regex.Matches(string, string)`；输入表达式：`Regex.Matches(text, @"[a-zA-Z0-9_]+|[\p{IsCJKUnifiedIdeographs}]+")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (Match match in Regex.Matches(text, @"[a-zA-Z0-9_]+|[\p{IsCJKUnifiedIdeographs}]+"))          {              string word = match.Value;              if (word[0] <= 127) terms.Add(word);              else for (int i = 0; i < word.Length - 1; i++) terms.Add(word.Substring(i, 2));          }`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9f4e57953da4"></a>

## `NationalSpire.CommunityMemorySearch.MatchesTopic(string, string, NationalSpire.CommunityMemorySearch.Request?) — public static bool MatchesTopic(string query, string text, Request? request = null)`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityMemorySearch.Retrieve(NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>, int, System.Collections.Generic.ISet<string>, int, System.Collections.Generic.ISet<string>?, bool, NationalSpire.CommunityMemorySearch.Request?)`](CommunityMemorySearch.cs.md#symbol-f933ce4e4ad8)；[`NationalSpire.PrivateMessagePrompts.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-4b9d12b26f65)；[`NationalSpire.PrivatePublicContext.PostTexts(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CareerPerson, string, System.Collections.Generic.IEnumerable<NationalSpire.CommunityMemory>?, NationalSpire.CommunityMemorySearch.Request?)`](PrivatePublicContext.cs.md#symbol-0f3333edf327)；[`Topic(NationalSpire.CommunityPost)`](PrivatePublicContext.cs.md#symbol-7af32d4a06f5)

**调用：** [`NationalSpire.CommunityMemorySearch.Request.GetTerms(string)`](CommunityMemorySearch.cs.md#symbol-291651d7ac15)；[`NationalSpire.CommunityMemorySearch.Terms(string)`](CommunityMemorySearch.cs.md#symbol-96d927ec7e23)；`System.Collections.Generic.HashSet<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityMemorySearch.ConversationNoise`；`NationalSpire.CommunityMemorySearch.Request.GetTerms(string)`；`NationalSpire.CommunityMemorySearch.Terms(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityMemorySearch.Request.GetTerms(string)`；输入表达式：`.GetTerms(query)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: request?.GetTerms(query)`
- `NationalSpire.CommunityMemorySearch.Request.GetTerms(string)`；输入表达式：`.GetTerms(text)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: request?.GetTerms(text)`
- `NationalSpire.CommunityMemorySearch.Terms(string)`；输入表达式：`Terms(query)`；返回值紧邻使用处：`BinaryExpressionSyntax: request?.GetTerms(query) ?? Terms(query)`
- `NationalSpire.CommunityMemorySearch.Terms(string)`；输入表达式：`Terms(text)`；返回值紧邻使用处：`BinaryExpressionSyntax: request?.GetTerms(text) ?? Terms(text)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`ConversationNoise.Contains(term)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ConversationNoise.Contains(term)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`textTerms.Contains(term)`；返回值紧邻使用处：`BinaryExpressionSyntax: !ConversationNoise.Contains(term) && textTerms.Contains(term)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ab53931edb52"></a>

## `NationalSpire.CommunityMemorySearch.PrivateAcquaintance(NationalSpire.CareerData, NationalSpire.CareerPerson) — public static List<CommunityMemory> PrivateAcquaintance(CareerData data, CareerPerson person)`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivatePublicContext.Community(NationalSpire.CareerData, NationalSpire.CareerPerson, string, System.Collections.Generic.ISet<string>?, System.Collections.Generic.List<(string Id, string Text)>?, NationalSpire.CommunityMemorySearch.Request?)`](PrivatePublicContext.cs.md#symbol-58aebbb834b8)

**调用：** [`NationalSpire.AiGeneratedText.Memory(NationalSpire.CommunityMemory)`](AiGeneratedText.cs.md#symbol-ff263d7615f1)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-87fd384e7842)；`NationalSpire.CommunityMemory.CommunityMemory()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiGeneratedText.Memory(NationalSpire.CommunityMemory)`；`NationalSpire.CareerData.CommunityMemories`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerPerson.HandleAliases`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CommunityMemory.Day`；`NationalSpire.CommunityMemory.Id`；`NationalSpire.CommunityMemory.Kind`；`NationalSpire.CommunityMemory.People`；`NationalSpire.CommunityMemory.PostId`；`NationalSpire.CommunityMemory.Text`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.Title`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`Own(NationalSpire.CommunityMemory)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiGeneratedText.Memory(NationalSpire.CommunityMemory)`；输入表达式：`AiGeneratedText.Memory(m)`；返回值紧邻使用处：`ConditionalExpressionSyntax: posts.TryGetValue(m.PostId, out var post) ? $"《{post.Title}》中的记录：{AiGeneratedText.Memory(m)}" : AiGeneratedText.Memory(m)`
- `NationalSpire.AiGeneratedText.Memory(NationalSpire.CommunityMemory)`；输入表达式：`AiGeneratedText.Memory(m)`；返回值紧邻使用处：`InterpolationSyntax: {AiGeneratedText.Memory(m)}`
- `NationalSpire.CommunityMemory.CommunityMemory()`；输入表达式：`new CommunityMemory          {              Id = m.Id, PostId = m.PostId, Day = m.Day, Kind = m.Kind, People = m.People,              Text = posts.TryGetValue(m.PostId, out var post) ? $"《{post.Title}》中的记录：{AiGeneratedText.Memory(m)}" : AiGeneratedText.Memory(m)          }`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m => new CommunityMemory          {              Id = m.Id, PostId = m.PostId, Day = m.Day, Kind = m.Kind, People = m.People,              Text = posts.TryGetValue(m.PostId, out var post) ? $"《{post.Title}》中的记录：{AiGeneratedText.Memory(m)}" : AiGeneratedText.Memory(m)          }`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).DistinctBy`
- `NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.NewsPending(data, post)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CommunityThreads.NewsPending(data, post)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`posts.TryGetValue(m.PostId, out var post)`；返回值紧邻使用处：`ConditionalExpressionSyntax: posts.TryGetValue(m.PostId, out var post) ? $"《{post.Title}》中的记录：{AiGeneratedText.Memory(m)}" : AiGeneratedText.Memory(m)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`posts.TryGetValue(m.PostId, out var post)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !posts.TryGetValue(m.PostId, out var post)`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`person.HandleAliases.Append(person.PublicName)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: person.HandleAliases.Append(person.PublicName).Where`
- `System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；输入表达式：`data.CommunityMemories.AsEnumerable()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.CommunityMemories.AsEnumerable().Reverse`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`own.Concat(shared)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: own.Concat(shared).DistinctBy`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`person.HandleAliases.Append(person.PublicName).Where(n => n.Length > 0).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: person.HandleAliases.Append(person.PublicName).Where(n => n.Length > 0).Distinct().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`CommunityThreads.All(data).DistinctBy(p => p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).DistinctBy(p => p.Id).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`own.Concat(shared).DistinctBy(m => m.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: own.Concat(shared).DistinctBy(m => m.Id).Select`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`available.Where(m => m.Kind == "fact" && m.People.Contains(person.Id) && m.People.Contains(human))              .OrderByDescending(m => m.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: available.Where(m => m.Kind == "fact" && m.People.Contains(person.Id) && m.People.Contains(human))              .OrderByDescending(m => m.Day).Take`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`available.Where(Own).OrderByDescending(m => m.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: available.Where(Own).OrderByDescending(m => m.Day).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`data.CommunityMemories.AsEnumerable().Reverse()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.CommunityMemories.AsEnumerable().Reverse().Where`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`own.Concat(shared).DistinctBy(m => m.Id).Select(m => new CommunityMemory          {              Id = m.Id, PostId = m.PostId, Day = m.Day, Kind = m.Kind, People = m.People,              Text = posts.TryGetValue(m.PostId, out var post) ? $"《{post.Title}》中的记录：{AiGeneratedText.Memory(m)}" : AiGeneratedText.Memory(m)          })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: own.Concat(shared).DistinctBy(m => m.Id).Select(m => new CommunityMemory          {              Id = m.Id, PostId = m.PostId, Day = m.Day, Kind = m.Kind, People = m.People,              Text = posts.TryGetValue(m.PostId, out var post) ? $"《{post.Title}》中的记录：{AiGeneratedText.Memory(m)}" : AiGeneratedText.Memory(m)          }).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`available.Where(m => m.Kind == "fact" && m.People.Contains(person.Id) && m.People.Contains(human))              .OrderByDescending(m => m.Day).Take(2)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = available.Where(m => m.Kind == "fact" && m.People.Contains(person.Id) && m.People.Contains(human))              .OrderByDescending(m => m.Day).Take(2)`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`available.Where(Own).OrderByDescending(m => m.Day).Take(3)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = available.Where(Own).OrderByDescending(m => m.Day).Take(3)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`data.CommunityMemories.AsEnumerable().Reverse().Where(m => m.Day <= data.Day &&              (!posts.TryGetValue(m.PostId, out var post) || !CommunityThreads.NewsPending(data, post))).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.CommunityMemories.AsEnumerable().Reverse().Where(m => m.Day <= data.Day &&              (!posts.TryGetValue(m.PostId, out var post) || !CommunityThreads.NewsPending(data, post))).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`person.HandleAliases.Append(person.PublicName).Where(n => n.Length > 0).Distinct().ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = person.HandleAliases.Append(person.PublicName).Where(n => n.Length > 0).Distinct().ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`CommunityThreads.All(data).DistinctBy(p => p.Id).ToDictionary(p => p.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.All(data).DistinctBy(p => p.Id).ToDictionary(p => p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`own.Concat(shared).DistinctBy(m => m.Id).Select(m => new CommunityMemory          {              Id = m.Id, PostId = m.PostId, Day = m.Day, Kind = m.Kind, People = m.People,              Text = posts.TryGetValue(m.PostId, out var post) ? $"《{post.Title}》中的记录：{AiGeneratedText.Memory(m)}" : AiGeneratedText.Memory(m)          }).ToList()`；返回值紧邻使用处：`ReturnStatementSyntax: return own.Concat(shared).DistinctBy(m => m.Id).Select(m => new CommunityMemory          {              Id = m.Id, PostId = m.PostId, Day = m.Day, Kind = m.Kind, People = m.People,              Text = posts.TryGetValue(m.PostId, out var post) ? $"《{post.Title}》中的记录：{AiGeneratedText.Memory(m)}" : AiGeneratedText.Memory(m)          }).ToList();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`available.Where(m => m.Kind == "fact" && m.People.Contains(person.Id) && m.People.Contains(human))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: available.Where(m => m.Kind == "fact" && m.People.Contains(person.Id) && m.People.Contains(human))              .OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`available.Where(Own)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: available.Where(Own).OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.CommunityMemories.AsEnumerable().Reverse().Where(m => m.Day <= data.Day &&              (!posts.TryGetValue(m.PostId, out var post) || !CommunityThreads.NewsPending(data, post)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.CommunityMemories.AsEnumerable().Reverse().Where(m => m.Day <= data.Day &&              (!posts.TryGetValue(m.PostId, out var post) || !CommunityThreads.NewsPending(data, post))).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`person.HandleAliases.Append(person.PublicName).Where(n => n.Length > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: person.HandleAliases.Append(person.PublicName).Where(n => n.Length > 0).Distinct`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`m.People.Contains(human)`；返回值紧邻使用处：`BinaryExpressionSyntax: m.Kind == "fact" && m.People.Contains(person.Id) && m.People.Contains(human)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`m.People.Contains(person.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: m.Kind == "fact" && m.People.Contains(person.Id)`

**赋值（含属性/字段和局部值）：**

- `Day` = `m.Day`
- `Id` = `m.Id`
- `Kind` = `m.Kind`
- `People` = `m.People`
- `PostId` = `m.PostId`
- `Text` = `posts.TryGetValue(m.PostId, out var post) ? $"《{post.Title}》中的记录：{AiGeneratedText.Memory(m)}" : AiGeneratedText.Memory(m)`

<a id="symbol-42c29caf00aa"></a>

## `Own(NationalSpire.CommunityMemory) — bool Own(CommunityMemory m)`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `string.StartsWith(string, System.StringComparison)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.Id`；`NationalSpire.CommunityMemory.Kind`；`NationalSpire.CommunityMemory.People`；`NationalSpire.CommunityMemory.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.StartsWith(string, System.StringComparison)`；输入表达式：`m.Text.StartsWith(name + "：", StringComparison.Ordinal)`；返回值紧邻使用处：`BinaryExpressionSyntax: m.Text.StartsWith(name + "：", StringComparison.Ordinal) || m.Text.StartsWith(name + "发帖", StringComparison.Ordinal)`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`m.Text.StartsWith(name + "发帖", StringComparison.Ordinal)`；返回值紧邻使用处：`BinaryExpressionSyntax: m.Text.StartsWith(name + "：", StringComparison.Ordinal) || m.Text.StartsWith(name + "发帖", StringComparison.Ordinal)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`names.Any(name =>              m.Text.StartsWith(name + "：", StringComparison.Ordinal) || m.Text.StartsWith(name + "发帖", StringComparison.Ordinal))`；返回值紧邻使用处：`BinaryExpressionSyntax: m.Kind == "opinion" && m.People.Contains(person.Id) && names.Any(name =>              m.Text.StartsWith(name + "：", StringComparison.Ordinal) || m.Text.StartsWith(name + "发帖", StringComparison.Ordinal))`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`m.People.Contains(person.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: m.Kind == "opinion" && m.People.Contains(person.Id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f933ce4e4ad8"></a>

## `NationalSpire.CommunityMemorySearch.Retrieve(NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>, int, System.Collections.Generic.ISet<string>, int, System.Collections.Generic.ISet<string>?, bool, NationalSpire.CommunityMemorySearch.Request?) — public static List<CommunityMemory> Retrieve(CareerData data, string query, IEnumerable<string> people, int day, ISet<string> excludedPosts, int count = 6, ISet<string>? excludedMemories = null, bool requireTopic = false, Request? request = null)`

来源：源码第 57 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.BuildDiscussionPrompt(NationalSpire.CareerData, System.Collections.Generic.ISet<string>, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiDiscussion.cs.md#symbol-142a77613e08)；[`NationalSpire.AiService.BuildNewsContext(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiContext.cs.md#symbol-7b21630a9e2c)；[`NationalSpire.AiService.CreateTestSession(NationalSpire.CareerData, NationalSpire.PromptTestSource, string)`](PromptTesting.cs.md#symbol-c81f52ee7090)；[`NationalSpire.AiService.GenerateWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool, bool)`](AiWeekly.cs.md#symbol-9db02a002768)；[`NationalSpire.PrivatePublicContext.Community(NationalSpire.CareerData, NationalSpire.CareerPerson, string, System.Collections.Generic.ISet<string>?, System.Collections.Generic.List<(string Id, string Text)>?, NationalSpire.CommunityMemorySearch.Request?)`](PrivatePublicContext.cs.md#symbol-58aebbb834b8)；[`NationalSpire.WeeklyJournal.CloseWeek(NationalSpire.CareerData)`](WeeklyJournal.cs.md#symbol-fe6dece0c758)

**调用：** [`IndexedTerms(NationalSpire.CommunityMemory)`](CommunityMemorySearch.cs.md#symbol-3f63ea03e2a7)；[`NationalSpire.AiGeneratedText.Memory(NationalSpire.CommunityMemory)`](AiGeneratedText.cs.md#symbol-ff263d7615f1)；[`NationalSpire.CommunityMemorySearch.MatchesTopic(string, string, NationalSpire.CommunityMemorySearch.Request?)`](CommunityMemorySearch.cs.md#symbol-9f4e57953da4)；[`NationalSpire.CommunityMemorySearch.Request.GetTerms(string)`](CommunityMemorySearch.cs.md#symbol-291651d7ac15)；[`NationalSpire.CommunityMemorySearch.Terms(string)`](CommunityMemorySearch.cs.md#symbol-96d927ec7e23)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-87fd384e7842)；[`NationalSpire.GameText.Plain(string)`](GameText.cs.md#symbol-e2c48dec4564)；`NationalSpire.CommunityMemory.CommunityMemory()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IEqualityComparer<TKey>?)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.HashSet<T>.Overlaps(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.ICollection<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.GetOrCreateValue(TKey)`

**字段、属性、事件及方法组引用：** `(NationalSpire.CommunityMemory Memory, System.Collections.Generic.HashSet<string> Terms).Memory`；`(NationalSpire.CommunityMemory Memory, System.Collections.Generic.HashSet<string> Terms).Terms`；`(string id, int weight).id`；`(string id, int weight).weight`；`IndexedTerms(NationalSpire.CommunityMemory)`；`NationalSpire.AiGeneratedText.Memory(NationalSpire.CommunityMemory)`；`NationalSpire.CareerData.CommunityMemories`；`NationalSpire.CommunityMemory.Day`；`NationalSpire.CommunityMemory.Id`；`NationalSpire.CommunityMemory.Kind`；`NationalSpire.CommunityMemory.People`；`NationalSpire.CommunityMemory.PostId`；`NationalSpire.CommunityMemory.Text`；`NationalSpire.CommunityMemorySearch.Indexes`；`NationalSpire.CommunityMemorySearch.MatchesTopic(string, string, NationalSpire.CommunityMemorySearch.Request?)`；`NationalSpire.CommunityMemorySearch.Request.GetTerms(string)`；`NationalSpire.CommunityMemorySearch.Terms(string)`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；`NationalSpire.GameText.Plain(string)`；`Score((NationalSpire.CommunityMemory Memory, System.Collections.Generic.HashSet<string> Terms))`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `IndexedTerms(NationalSpire.CommunityMemory)`；输入表达式：`IndexedTerms(m)`；返回值紧邻使用处：`ArgumentSyntax: Terms: IndexedTerms(m)`
- `NationalSpire.AiGeneratedText.Memory(NationalSpire.CommunityMemory)`；输入表达式：`AiGeneratedText.Memory(d.Memory)`；返回值紧邻使用处：`ArgumentSyntax: AiGeneratedText.Memory(d.Memory)`
- `NationalSpire.CommunityMemory.CommunityMemory()`；输入表达式：`new CommunityMemory { Id = d.Memory.Id, PostId = d.Memory.PostId, Day = d.Memory.Day, Kind = d.Memory.Kind, People = d.Memory.People, Text = GameText.Plain(AiGeneratedText.Memory(d.Memory)) }`；返回值紧邻使用处：`ConditionalExpressionSyntax: d.Memory.Kind == "fact" ? new CommunityMemory { Id = d.Memory.Id, PostId = d.Memory.PostId, Day = d.Memory.Day, Kind = d.Memory.Kind, People = d.Memory.People, Text = GameText.Plain(AiGeneratedText.Memory(d.Memory)) } : d.Memory`
- `NationalSpire.CommunityMemorySearch.MatchesTopic(string, string, NationalSpire.CommunityMemorySearch.Request?)`；输入表达式：`MatchesTopic(query, d.Memory.Text, request)`；返回值紧邻使用处：`ConditionalExpressionSyntax: requireTopic ? MatchesTopic(query, d.Memory.Text, request) : d.Terms.Overlaps(queryTerms) || d.Memory.People.Any(identities.ContainsKey)`
- `NationalSpire.CommunityMemorySearch.Request.GetTerms(string)`；输入表达式：`.GetTerms(query)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: request?.GetTerms(query)`
- `NationalSpire.CommunityMemorySearch.Terms(string)`；输入表达式：`Terms(query)`；返回值紧邻使用处：`BinaryExpressionSyntax: request?.GetTerms(query) ?? Terms(query)`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).Where`
- `NationalSpire.CommunityThreads.NewsPending(NationalSpire.CareerData, NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.NewsPending(data, p)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => CommunityThreads.NewsPending(data, p)`
- `NationalSpire.GameText.Plain(string)`；输入表达式：`GameText.Plain(AiGeneratedText.Memory(d.Memory))`；返回值紧邻使用处：`AssignmentExpressionSyntax: Text = GameText.Plain(AiGeneratedText.Memory(d.Memory))`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, int>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, int>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IEqualityComparer<TKey>?)`；输入表达式：`new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`doc.Terms.Contains(term)`；返回值紧邻使用处：`IfStatementSyntax: if (doc.Terms.Contains(term)) frequencies[term] = frequencies.GetValueOrDefault(term) + 1;`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`unpublished.Contains(m.PostId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !unpublished.Contains(m.PostId)`
- `System.Collections.Generic.HashSet<T>.Overlaps(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`d.Terms.Overlaps(queryTerms)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Terms.Overlaps(queryTerms) || d.Memory.People.Any(identities.ContainsKey)`
- `System.Collections.Generic.ICollection<T>.Contains(T)`；输入表达式：`.Contains(m.Id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: excludedMemories?.Contains(m.Id)`
- `System.Collections.Generic.ICollection<T>.Contains(T)`；输入表达式：`excludedPosts.Contains(m.PostId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !excludedPosts.Contains(m.PostId)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Memory.People.Any(identities.ContainsKey)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Terms.Overlaps(queryTerms) || d.Memory.People.Any(identities.ContainsKey)`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`people.Where(id => id != "player" && id != "desk").Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: people.Where(id => id != "player" && id != "desk").Distinct()              .Select`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`documents.Where(d => requireTopic ? MatchesTopic(query, d.Memory.Text, request) : d.Terms.Overlaps(queryTerms) || d.Memory.People.Any(identities.ContainsKey))              .OrderByDescending(Score)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: documents.Where(d => requireTopic ? MatchesTopic(query, d.Memory.Text, request) : d.Terms.Overlaps(queryTerms) || d.Memory.People.Any(identities.ContainsKey))              .OrderByDescending(Score).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`people.Where(id => id != "player" && id != "desk").Distinct()              .Select((id, index) => (id, weight: index < 3 ? 8 : 3))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: people.Where(id => id != "player" && id != "desk").Distinct()              .Select((id, index) => (id, weight: index < 3 ? 8 : 3)).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`CommunityThreads.All(data).Where(p => CommunityThreads.NewsPending(data, p)).Select(p => p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).Where(p => CommunityThreads.NewsPending(data, p)).Select(p => p.Id).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`data.CommunityMemories.Where(m => (m.Kind != "opinion" || !unpublished.Contains(m.PostId)) && m.Day <= day && !excludedPosts.Contains(m.PostId) && !(excludedMemories?.Contains(m.Id) ?? false))              .Select(m => (Memory: m, Terms: IndexedTerms(m)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.CommunityMemories.Where(m => (m.Kind != "opinion" || !unpublished.Contains(m.PostId)) && m.Day <= day && !excludedPosts.Contains(m.PostId) && !(excludedMemories?.Contains(m.Id) ?? false))              .Select(m => (Memory: m, Terms: IndexedTerms(m))).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`documents.Where(d => requireTopic ? MatchesTopic(query, d.Memory.Text, request) : d.Terms.Overlaps(queryTerms) || d.Memory.People.Any(identities.ContainsKey))              .OrderByDescending(Score).ThenByDescending(d => d.Memory.Day)              .Where(d => { int used = perPost.GetValueOrDefault(d.Memory.PostId); perPost[d.Memory.PostId] = used + 1; return used < 2; })              .Take(count).Select(d => d.Memory.Kind == "fact" ? new CommunityMemory { Id = d.Memory.Id, PostId = d.Memory.PostId, Day = d.Memory.Day, Kind = d.Memory.Kind, People = d.Memory.People, Text = GameText.Plain(AiGeneratedText.Memory(d.Memory)) } : d.Memory)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: documents.Where(d => requireTopic ? MatchesTopic(query, d.Memory.Text, request) : d.Terms.Overlaps(queryTerms) || d.Memory.People.Any(identities.ContainsKey))              .OrderByDescending(Score).ThenByDescending(d => d.Memory.Day)              .Where(d => { int used = perPost.GetValueOrDefault(d.Memory.PostId); perPost[d.Memory.PostId] = used + 1; return used < 2; })              .Take(count).Select(d => d.Memory.Kind == "fact" ? new CommunityMemory { Id = d.Memory.Id, PostId = d.Memory.PostId, Day = d.Memory.Day, Kind = d.Memory.Kind, People = d.Memory.People, Text = GameText.Plain(AiGeneratedText.Memory(d.Memory)) } : d.Memory).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`documents.Where(d => requireTopic ? MatchesTopic(query, d.Memory.Text, request) : d.Terms.Overlaps(queryTerms) || d.Memory.People.Any(identities.ContainsKey))              .OrderByDescending(Score).ThenByDescending(d => d.Memory.Day)              .Where(d => { int used = perPost.GetValueOrDefault(d.Memory.PostId); perPost[d.Memory.PostId] = used + 1; return used < 2; })              .Take(count)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: documents.Where(d => requireTopic ? MatchesTopic(query, d.Memory.Text, request) : d.Terms.Overlaps(queryTerms) || d.Memory.People.Any(identities.ContainsKey))              .OrderByDescending(Score).ThenByDescending(d => d.Memory.Day)              .Where(d => { int used = perPost.GetValueOrDefault(d.Memory.PostId); perPost[d.Memory.PostId] = used + 1; return used < 2; })              .Take(count).Select`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`people.Where(id => id != "player" && id != "desk").Distinct()              .Select((id, index) => (id, weight: index < 3 ? 8 : 3)).ToDictionary(x => x.id, x => x.weight)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = people.Where(id => id != "player" && id != "desk").Distinct()              .Select((id, index) => (id, weight: index < 3 ? 8 : 3)).ToDictionary(x => x.id, x => x.weight)`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`CommunityThreads.All(data).Where(p => CommunityThreads.NewsPending(data, p)).Select(p => p.Id).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.All(data).Where(p => CommunityThreads.NewsPending(data, p)).Select(p => p.Id).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`data.CommunityMemories.Where(m => (m.Kind != "opinion" || !unpublished.Contains(m.PostId)) && m.Day <= day && !excludedPosts.Contains(m.PostId) && !(excludedMemories?.Contains(m.Id) ?? false))              .Select(m => (Memory: m, Terms: IndexedTerms(m))).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.CommunityMemories.Where(m => (m.Kind != "opinion" || !unpublished.Contains(m.PostId)) && m.Day <= day && !excludedPosts.Contains(m.PostId) && !(excludedMemories?.Contains(m.Id) ?? false))              .Select(m => (Memory: m, Terms: IndexedTerms(m))).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`documents.Where(d => requireTopic ? MatchesTopic(query, d.Memory.Text, request) : d.Terms.Overlaps(queryTerms) || d.Memory.People.Any(identities.ContainsKey))              .OrderByDescending(Score).ThenByDescending(d => d.Memory.Day)              .Where(d => { int used = perPost.GetValueOrDefault(d.Memory.PostId); perPost[d.Memory.PostId] = used + 1; return used < 2; })              .Take(count).Select(d => d.Memory.Kind == "fact" ? new CommunityMemory { Id = d.Memory.Id, PostId = d.Memory.PostId, Day = d.Memory.Day, Kind = d.Memory.Kind, People = d.Memory.People, Text = GameText.Plain(AiGeneratedText.Memory(d.Memory)) } : d.Memory).ToList()`；返回值紧邻使用处：`ReturnStatementSyntax: return documents.Where(d => requireTopic ? MatchesTopic(query, d.Memory.Text, request) : d.Terms.Overlaps(queryTerms) || d.Memory.People.Any(identities.ContainsKey))              .OrderByDescending(Score).ThenByDescending(d => d.Memory.Day)              .Where(d => { int used = perPost.GetValueOrDefault(d.Memory.PostId); perPost[d.Memory.PostId] = used + 1; return used < 2; })              .Take(count).Select(d => d.Memory.Kind == "fact" ? new CommunityMemory { Id = d.Memory.Id, PostId = d.Memory.PostId, Day = d.Memory.Day, Kind = d.Memory.Kind, People = d.Memory.People, Text = GameText.Plain(AiGeneratedText.Memory(d.Memory)) } : d.Memory).ToList();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(data).Where(p => CommunityThreads.NewsPending(data, p))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(data).Where(p => CommunityThreads.NewsPending(data, p)).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.CommunityMemories.Where(m => (m.Kind != "opinion" || !unpublished.Contains(m.PostId)) && m.Day <= day && !excludedPosts.Contains(m.PostId) && !(excludedMemories?.Contains(m.Id) ?? false))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.CommunityMemories.Where(m => (m.Kind != "opinion" || !unpublished.Contains(m.PostId)) && m.Day <= day && !excludedPosts.Contains(m.PostId) && !(excludedMemories?.Contains(m.Id) ?? false))              .Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`documents.Where(d => requireTopic ? MatchesTopic(query, d.Memory.Text, request) : d.Terms.Overlaps(queryTerms) || d.Memory.People.Any(identities.ContainsKey))              .OrderByDescending(Score).ThenByDescending(d => d.Memory.Day)              .Where(d => { int used = perPost.GetValueOrDefault(d.Memory.PostId); perPost[d.Memory.PostId] = used + 1; return used < 2; })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: documents.Where(d => requireTopic ? MatchesTopic(query, d.Memory.Text, request) : d.Terms.Overlaps(queryTerms) || d.Memory.People.Any(identities.ContainsKey))              .OrderByDescending(Score).ThenByDescending(d => d.Memory.Day)              .Where(d => { int used = perPost.GetValueOrDefault(d.Memory.PostId); perPost[d.Memory.PostId] = used + 1; return used < 2; })              .Take`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`documents.Where(d => requireTopic ? MatchesTopic(query, d.Memory.Text, request) : d.Terms.Overlaps(queryTerms) || d.Memory.People.Any(identities.ContainsKey))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: documents.Where(d => requireTopic ? MatchesTopic(query, d.Memory.Text, request) : d.Terms.Overlaps(queryTerms) || d.Memory.People.Any(identities.ContainsKey))              .OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`people.Where(id => id != "player" && id != "desk")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: people.Where(id => id != "player" && id != "desk").Distinct`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`frequencies.GetValueOrDefault(term)`；返回值紧邻使用处：`BinaryExpressionSyntax: frequencies.GetValueOrDefault(term) + 1`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`perPost.GetValueOrDefault(d.Memory.PostId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = perPost.GetValueOrDefault(d.Memory.PostId)`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`documents.Where(d => requireTopic ? MatchesTopic(query, d.Memory.Text, request) : d.Terms.Overlaps(queryTerms) || d.Memory.People.Any(identities.ContainsKey))              .OrderByDescending(Score).ThenByDescending(d => d.Memory.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: documents.Where(d => requireTopic ? MatchesTopic(query, d.Memory.Text, request) : d.Terms.Overlaps(queryTerms) || d.Memory.People.Any(identities.ContainsKey))              .OrderByDescending(Score).ThenByDescending(d => d.Memory.Day)              .Where`
- `System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.GetOrCreateValue(TKey)`；输入表达式：`Indexes.GetOrCreateValue(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Indexes.GetOrCreateValue(data)`

**赋值（含属性/字段和局部值）：**

- `Day` = `d.Memory.Day`
- `frequencies[term]` = `frequencies.GetValueOrDefault(term) + 1`
- `Id` = `d.Memory.Id`
- `Kind` = `d.Memory.Kind`
- `People` = `d.Memory.People`
- `perPost[d.Memory.PostId]` = `used + 1`
- `PostId` = `d.Memory.PostId`
- `Text` = `GameText.Plain(AiGeneratedText.Memory(d.Memory))`

<a id="symbol-3f63ea03e2a7"></a>

## `IndexedTerms(NationalSpire.CommunityMemory) — HashSet<string> IndexedTerms(CommunityMemory memory)`

来源：源码第 63 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CommunityMemorySearch.Retrieve(NationalSpire.CareerData, string, System.Collections.Generic.IEnumerable<string>, int, System.Collections.Generic.ISet<string>, int, System.Collections.Generic.ISet<string>?, bool, NationalSpire.CommunityMemorySearch.Request?)`](CommunityMemorySearch.cs.md#symbol-f933ce4e4ad8)

**调用：** [`NationalSpire.CommunityMemorySearch.Terms(string)`](CommunityMemorySearch.cs.md#symbol-96d927ec7e23)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `(string Text, System.Collections.Generic.HashSet<string> Terms).Terms`；`(string Text, System.Collections.Generic.HashSet<string> Terms).Text`；`NationalSpire.CommunityMemory.Id`；`NationalSpire.CommunityMemory.Text`；`NationalSpire.CommunityMemorySearch.Terms(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityMemorySearch.Terms(string)`；输入表达式：`Terms(memory.Text)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Terms(memory.Text)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`index.TryGetValue(memory.Id, out var cached)`；返回值紧邻使用处：`BinaryExpressionSyntax: index.TryGetValue(memory.Id, out var cached) && cached.Text == memory.Text`

**赋值（含属性/字段和局部值）：**

- `index[memory.Id]` = `(memory.Text, terms)`

<a id="symbol-1400b0025141"></a>

## `Score((NationalSpire.CommunityMemory Memory, System.Collections.Generic.HashSet<string> Terms)) — double Score((CommunityMemory Memory, HashSet<string> Terms) doc)`

来源：源码第 74 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, double>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Math.Log(double)`；`System.Math.Max(int, int)`；`System.Math.Sqrt(double)`

**字段、属性、事件及方法组引用：** `(NationalSpire.CommunityMemory Memory, System.Collections.Generic.HashSet<string> Terms).Memory`；`(NationalSpire.CommunityMemory Memory, System.Collections.Generic.HashSet<string> Terms).Terms`；`NationalSpire.CommunityMemory.Day`；`NationalSpire.CommunityMemory.Kind`；`NationalSpire.CommunityMemory.People`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, double>)`；输入表达式：`doc.Terms.Where(queryTerms.Contains).Sum(t => Math.Log(1 + (documents.Count + 1.0) / frequencies[t]))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = doc.Terms.Where(queryTerms.Contains).Sum(t => Math.Log(1 + (documents.Count + 1.0) / frequencies[t]))`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`doc.Memory.People.Sum(id => identities.GetValueOrDefault(id))`；返回值紧邻使用处：`BinaryExpressionSyntax: lexical / Math.Sqrt(Math.Max(1, doc.Terms.Count)) + doc.Memory.People.Sum(id => identities.GetValueOrDefault(id))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`doc.Terms.Where(queryTerms.Contains)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: doc.Terms.Where(queryTerms.Contains).Sum`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`identities.GetValueOrDefault(id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => identities.GetValueOrDefault(id)`
- `System.Math.Log(double)`；输入表达式：`Math.Log(1 + (documents.Count + 1.0) / frequencies[t])`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: t => Math.Log(1 + (documents.Count + 1.0) / frequencies[t])`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, day - doc.Memory.Day)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(0, day - doc.Memory.Day) / 28.0`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1, doc.Terms.Count)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(1, doc.Terms.Count)`
- `System.Math.Sqrt(double)`；输入表达式：`Math.Sqrt(Math.Max(1, doc.Terms.Count))`；返回值紧邻使用处：`BinaryExpressionSyntax: lexical / Math.Sqrt(Math.Max(1, doc.Terms.Count))`

**赋值（含属性/字段和局部值）：**
