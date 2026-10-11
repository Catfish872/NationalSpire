# CareerNarrative.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`C6D5393A49B5E1337686979B5B19569EC4E7B3F7B17F1EE9EB34989F6EEFE573`。来源：[源码](../../CareerNarrative.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerNarrative`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-34f9cbe529c8"></a>

## `NationalSpire.CareerNarrative.Audience(NationalSpire.CareerData, string, string, NationalSpire.CareerMatch?, System.Collections.Generic.List<string>?) — public static List<CareerPerson> Audience(CareerData d, string key, string category, CareerMatch? match, List<string>? related)`

来源：源码第 5 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerNarrative.NewsAudience(NationalSpire.CareerData, string, string, NationalSpire.CareerMatch?, System.Collections.Generic.List<string>?)`](CareerNarrative.cs.md#symbol-0dd83004ae4e)；[`NationalSpire.CareerNarrative.RepairNews(NationalSpire.CareerData)`](CareerNarrative.cs.md#symbol-f7d8afb43e10)；[`NationalSpire.CommunityThreads.Audience(NationalSpire.CareerData, NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-a16197b41bab)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`](SpireArbitration.cs.md#symbol-909e0981d663)；`string.IsNullOrEmpty(string?)`；`string.StartsWith(string)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.People`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerMatch.CompetitionId`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Role`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`；`NationalSpire.WorldCompetition.Country`；`NationalSpire.WorldCompetition.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => CareerEngine.Person(d, id)`
- `NationalSpire.SpireArbitration.Muted(NationalSpire.CareerPerson)`；输入表达式：`SpireArbitration.Muted(p)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !SpireArbitration.Muted(p)`
- `string.IsNullOrEmpty(string?)`；输入表达式：`string.IsNullOrEmpty(competition?.Country)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrEmpty(competition?.Country)`
- `string.StartsWith(string)`；输入表达式：`key.StartsWith("draw-")`；返回值紧邻使用处：`BinaryExpressionSyntax: match?.Kind is "continental" or "worldcup" or "worldfinal" or "masters"              || category == "国际赛事" || key.StartsWith("draw-")`
- `string.StartsWith(string)`；输入表达式：`key.StartsWith("international-entry-")`；返回值紧邻使用处：`BinaryExpressionSyntax: match?.Kind is "continental" or "worldcup" or "worldfinal" or "masters"              || category == "国际赛事" || key.StartsWith("draw-") || key.StartsWith("international-entry-")`
- `string.StartsWith(string)`；输入表达式：`key.StartsWith("roundup-" + c.Id + "-")`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Id == match?.CompetitionId              || key == "champion-" + c.Id || key.StartsWith("roundup-" + c.Id + "-")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Select(id => CareerEngine.Person(d, id)).FirstOrDefault(p => p != null)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: related?.Select(id => CareerEngine.Person(d, id)).FirstOrDefault(p => p != null)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.FirstOrDefault(c => c.Id == match?.CompetitionId              || key == "champion-" + c.Id || key.StartsWith("roundup-" + c.Id + "-"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.Competitions.FirstOrDefault(c => c.Id == match?.CompetitionId              || key == "champion-" + c.Id || key.StartsWith("roundup-" + c.Id + "-"))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`.Select(id => CareerEngine.Person(d, id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: .Select(id => CareerEngine.Person(d, id)).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.People.Where(p => p.Id != "desk" && !SpireArbitration.Muted(p) && !d.HumanIds.Contains(p.Id) && (international || p.Country == country)              && (kind != "local" || p.Role == "普通玩家")              && (kind != "city" || p.Role is "普通玩家" or "青训选手")              && (category != "训练日常" || subject?.Role != "普通玩家" || p.Role == "普通玩家")).ToList()`；返回值紧邻使用处：`ReturnStatementSyntax: return d.People.Where(p => p.Id != "desk" && !SpireArbitration.Muted(p) && !d.HumanIds.Contains(p.Id) && (international || p.Country == country)              && (kind != "local" || p.Role == "普通玩家")              && (kind != "city" || p.Role is "普通玩家" or "青训选手")              && (category != "训练日常" || subject?.Role != "普通玩家" || p.Role == "普通玩家")).ToList();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p => p.Id != "desk" && !SpireArbitration.Muted(p) && !d.HumanIds.Contains(p.Id) && (international || p.Country == country)              && (kind != "local" || p.Role == "普通玩家")              && (kind != "city" || p.Role is "普通玩家" or "青训选手")              && (category != "训练日常" || subject?.Role != "普通玩家" || p.Role == "普通玩家"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.Id != "desk" && !SpireArbitration.Muted(p) && !d.HumanIds.Contains(p.Id) && (international || p.Country == country)              && (kind != "local" || p.Role == "普通玩家")              && (kind != "city" || p.Role is "普通玩家" or "青训选手")              && (category != "训练日常" || subject?.Role != "普通玩家" || p.Role == "普通玩家")).ToList`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`d.HumanIds.Contains(p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.HumanIds.Contains(p.Id)`

**赋值（含属性/字段和局部值）：**

- `country` = `competition.Country`

<a id="symbol-c9738315f622"></a>

## `NationalSpire.CareerNarrative.PostAuthor(NationalSpire.CareerData, string, string, NationalSpire.CareerMatch?, System.Collections.Generic.List<string>?) — public static string PostAuthor(CareerData d, string key, string category, CareerMatch? match, List<string>? related)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`](CareerEngine.cs.md#symbol-cd8fd2c800e7)；[`NationalSpire.CareerNarrative.RepairNews(NationalSpire.CareerData)`](CareerNarrative.cs.md#symbol-f7d8afb43e10)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.CareerNarrative.NewsAudience(NationalSpire.CareerData, string, string, NationalSpire.CareerMatch?, System.Collections.Generic.List<string>?)`](CareerNarrative.cs.md#symbol-0dd83004ae4e)；`string.StartsWith(string)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerNarrative.NewsAudience(NationalSpire.CareerData, string, string, NationalSpire.CareerMatch?, System.Collections.Generic.List<string>?)`；`NationalSpire.CareerPerson.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(key + ":poster:" + p.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => CareerEngine.StableHash(key + ":poster:" + p.Id)`
- `NationalSpire.CareerNarrative.NewsAudience(NationalSpire.CareerData, string, string, NationalSpire.CareerMatch?, System.Collections.Generic.List<string>?)`；输入表达式：`NewsAudience(d, key, category, match, related)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = NewsAudience(d, key, category, match, related)`
- `string.StartsWith(string)`；输入表达式：`key.StartsWith("contract-")`；返回值紧邻使用处：`BinaryExpressionSyntax: category is "赛事公告" or "赛季" || key.StartsWith("draw-") || key.StartsWith("contract-")`
- `string.StartsWith(string)`；输入表达式：`key.StartsWith("draw-")`；返回值紧邻使用处：`BinaryExpressionSyntax: category is "赛事公告" or "赛季" || key.StartsWith("draw-")`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`pool.Any(p => p.Id == id)`；返回值紧邻使用处：`BinaryExpressionSyntax: category == "训练日常" && related?.FirstOrDefault() is { } id && pool.Any(p => p.Id == id)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`.FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: related?.FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`pool.OrderBy(p => CareerEngine.StableHash(key + ":poster:" + p.Id)).FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: pool.OrderBy(p => CareerEngine.StableHash(key + ":poster:" + p.Id)).FirstOrDefault()?.Id`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`pool.OrderBy(p => CareerEngine.StableHash(key + ":poster:" + p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pool.OrderBy(p => CareerEngine.StableHash(key + ":poster:" + p.Id)).FirstOrDefault`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0dd83004ae4e"></a>

## `NationalSpire.CareerNarrative.NewsAudience(NationalSpire.CareerData, string, string, NationalSpire.CareerMatch?, System.Collections.Generic.List<string>?) — public static List<CareerPerson> NewsAudience(CareerData d, string key, string category, CareerMatch? match, List<string>? related)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`](CareerEngine.cs.md#symbol-cd8fd2c800e7)；[`NationalSpire.CareerNarrative.PostAuthor(NationalSpire.CareerData, string, string, NationalSpire.CareerMatch?, System.Collections.Generic.List<string>?)`](CareerNarrative.cs.md#symbol-c9738315f622)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.CareerNarrative.Audience(NationalSpire.CareerData, string, string, NationalSpire.CareerMatch?, System.Collections.Generic.List<string>?)`](CareerNarrative.cs.md#symbol-34f9cbe529c8)；[`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`](EsportsWorld.cs.md#symbol-c10dfd5a2e0e)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Posts`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerNarrative.Audience(NationalSpire.CareerData, string, string, NationalSpire.CareerMatch?, System.Collections.Generic.List<string>?)`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash($"{d.WorldId}:{key}:attendance:{p.Id}")`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.StableHash($"{d.WorldId}:{key}:attendance:{p.Id}") % 100`
- `NationalSpire.CareerNarrative.Audience(NationalSpire.CareerData, string, string, NationalSpire.CareerMatch?, System.Collections.Generic.List<string>?)`；输入表达式：`Audience(d, key, category, match, related)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Audience(d, key, category, match, related).Where`
- `NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；输入表达式：`EsportsWorld.IsProfessional(p)`；返回值紧邻使用处：`ConditionalExpressionSyntax: EsportsWorld.IsProfessional(p) ? 35 : p.Role == "青训选手" ? 45 : 55`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`recent.Contains(p.Id)`；返回值紧邻使用处：`IfStatementSyntax: if (recent.Contains(p.Id)) chance -= 15;`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`subjects.Contains(p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !subjects.Contains(p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`(related ?? []).Append(match?.OpponentId ?? "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: (related ?? []).Append(match?.OpponentId ?? "").ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`p.Replies.Select(r => r.AuthorId).Append(p.AuthorId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => p.Replies.Select(r => r.AuthorId).Append(p.AuthorId)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`p.Replies.Select(r => r.AuthorId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.Replies.Select(r => r.AuthorId).Append`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`d.Posts.Take(4).SelectMany(p => p.Replies.Select(r => r.AuthorId).Append(p.AuthorId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Posts.Take(4).SelectMany(p => p.Replies.Select(r => r.AuthorId).Append(p.AuthorId)).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`d.Posts.Take(4)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Posts.Take(4).SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`(related ?? []).Append(match?.OpponentId ?? "").ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = (related ?? []).Append(match?.OpponentId ?? "").ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`d.Posts.Take(4).SelectMany(p => p.Replies.Select(r => r.AuthorId).Append(p.AuthorId)).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Posts.Take(4).SelectMany(p => p.Replies.Select(r => r.AuthorId).Append(p.AuthorId)).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`Audience(d, key, category, match, related).Where(p =>          {              if (!subjects.Contains(p.Id)) return true;              // 与事件相关代表受到关注；是否本人出现在评论区另行决定，并随事件保存。              int chance = EsportsWorld.IsProfessional(p) ? 35 : p.Role == "青训选手" ? 45 : 55;              if (recent.Contains(p.Id)) chance -= 15;              return CareerEngine.StableHash($"{d.WorldId}:{key}:attendance:{p.Id}") % 100 < chance;          }).ToList()`；返回值紧邻使用处：`ReturnStatementSyntax: return Audience(d, key, category, match, related).Where(p =>          {              if (!subjects.Contains(p.Id)) return true;              // 与事件相关代表受到关注；是否本人出现在评论区另行决定，并随事件保存。              int chance = EsportsWorld.IsProfessional(p) ? 35 : p.Role == "青训选手" ? 45 : 55;              if (recent.Contains(p.Id)) chance -= 15;              return CareerEngine.StableHash($"{d.WorldId}:{key}:attendance:{p.Id}") % 100 < chance;          }).ToList();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Audience(d, key, category, match, related).Where(p =>          {              if (!subjects.Contains(p.Id)) return true;              // 与事件相关代表受到关注；是否本人出现在评论区另行决定，并随事件保存。              int chance = EsportsWorld.IsProfessional(p) ? 35 : p.Role == "青训选手" ? 45 : 55;              if (recent.Contains(p.Id)) chance -= 15;              return CareerEngine.StableHash($"{d.WorldId}:{key}:attendance:{p.Id}") % 100 < chance;          })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Audience(d, key, category, match, related).Where(p =>          {              if (!subjects.Contains(p.Id)) return true;              // 与事件相关代表受到关注；是否本人出现在评论区另行决定，并随事件保存。              int chance = EsportsWorld.IsProfessional(p) ? 35 : p.Role == "青训选手" ? 45 : 55;              if (recent.Contains(p.Id)) chance -= 15;              return CareerEngine.StableHash($"{d.WorldId}:{key}:attendance:{p.Id}") % 100 < chance;          }).ToList`

**赋值（含属性/字段和局部值）：**

- `chance` -= `15`

<a id="symbol-d15ddefbd3f2"></a>

## `NationalSpire.CareerNarrative.Feature(NationalSpire.CareerData, NationalSpire.CareerPerson) — public static string Feature(CareerData d, CareerPerson p)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.SimulateWorld(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-f80c37dd1019)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.CharacterIdentity.Name(NationalSpire.CareerData, string)`](CharacterIdentity.cs.md#symbol-4d068357a08b)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.Form`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerPerson.Style`；`NationalSpire.CharacterIdentity.Name(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(d.WorldId + p.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.StableHash(d.WorldId + p.Id) % 3`
- `NationalSpire.CharacterIdentity.Name(NationalSpire.CareerData, string)`；输入表达式：`CharacterIdentity.Name(d, p.Character)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CharacterIdentity.Name(d, p.Character)`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(d, p.ClubId)`；返回值紧邻使用处：`InterpolationSyntax: {EsportsWorld.ClubName(d, p.ClubId)}`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0ebab312a182"></a>

## `NationalSpire.CareerNarrative.PublicNameText(string, NationalSpire.CareerData?) — private static string PublicNameText(string text, CareerData? data = null)`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerNarrative.News(NationalSpire.CareerData, string, string, string, string, NationalSpire.CareerMatch?)`](CareerNarrative.cs.md#symbol-adf20872be24)；[`NationalSpire.CareerNarrative.NewsBody(string, NationalSpire.CareerData?)`](CareerNarrative.cs.md#symbol-40783a5a4a36)；[`NationalSpire.CareerNarrative.RepairNews(NationalSpire.CareerData)`](CareerNarrative.cs.md#symbol-f7d8afb43e10)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；`string.Replace(string, string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerEngine.PlayerName`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(data)`；返回值紧邻使用处：`ConditionalExpressionSyntax: data == null ? CareerEngine.PlayerName : CareerEngine.Name(data)`
- `string.Replace(string, string?)`；输入表达式：`text.Replace(name, "\uE000").Replace("你", name).Replace("\uE000", name)`；返回值紧邻使用处：`ReturnStatementSyntax: return text.Replace(name, "\uE000").Replace("你", name).Replace("\uE000", name);`
- `string.Replace(string, string?)`；输入表达式：`text.Replace(name, "\uE000").Replace("你", name)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.Replace(name, "\uE000").Replace("你", name).Replace`
- `string.Replace(string, string?)`；输入表达式：`text.Replace(name, "\uE000")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.Replace(name, "\uE000").Replace`

**赋值（含属性/字段和局部值）：**


<a id="symbol-40783a5a4a36"></a>

## `NationalSpire.CareerNarrative.NewsBody(string, NationalSpire.CareerData?) — public static string NewsBody(string body, CareerData? data = null)`

来源：源码第 57 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerNarrative.News(NationalSpire.CareerData, string, string, string, string, NationalSpire.CareerMatch?)`](CareerNarrative.cs.md#symbol-adf20872be24)；[`NationalSpire.CareerNarrative.RepairNews(NationalSpire.CareerData)`](CareerNarrative.cs.md#symbol-f7d8afb43e10)

**调用：** [`NationalSpire.CareerNarrative.PublicNameText(string, NationalSpire.CareerData?)`](CareerNarrative.cs.md#symbol-0ebab312a182)；`string.Replace(string, string?)`；`string.Trim()`；`System.Text.RegularExpressions.Regex.Replace(string, string, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerNarrative.PublicNameText(string, NationalSpire.CareerData?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerNarrative.PublicNameText(string, NationalSpire.CareerData?)`；输入表达式：`PublicNameText(body, data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PublicNameText(body, data).Trim`
- `string.Replace(string, string?)`；输入表达式：`body.Replace("你现在是", "选手你取得资格：")              .Replace("前往赛事中心确认报名，代表", "确认报名后可代表")              .Replace("签表可在电竞世界查看，", "签表现已公开，")              .Replace("后续轮次自动报名", "晋级者将进入下一轮")              .Replace("签约奖励已经到账", "双方已确认签约")              .Replace("收官奖励", "赛季奖金")              .Replace("本赛季尚未进入职业联赛。新赛季仍可参加选拔，已经取得的资格与荣誉继续保留。", "你本赛季未参加职业联赛，后续参赛安排有待公布。")              .Replace("已取得的资格、俱乐部合同与荣誉将延续至新赛季。", "新赛季的席位竞争即将开始。")`；返回值紧邻使用处：`AssignmentExpressionSyntax: body = body.Replace("你现在是", "选手你取得资格：")              .Replace("前往赛事中心确认报名，代表", "确认报名后可代表")              .Replace("签表可在电竞世界查看，", "签表现已公开，")              .Replace("后续轮次自动报名", "晋级者将进入下一轮")              .Replace("签约奖励已经到账", "双方已确认签约")              .Replace("收官奖励", "赛季奖金")              .Replace("本赛季尚未进入职业联赛。新赛季仍可参加选拔，已经取得的资格与荣誉继续保留。", "你本赛季未参加职业联赛，后续参赛安排有待公布。")              .Replace("已取得的资格、俱乐部合同与荣誉将延续至新赛季。", "新赛季的席位竞争即将开始。")`
- `string.Replace(string, string?)`；输入表达式：`body.Replace("你现在是", "选手你取得资格：")              .Replace("前往赛事中心确认报名，代表", "确认报名后可代表")              .Replace("签表可在电竞世界查看，", "签表现已公开，")              .Replace("后续轮次自动报名", "晋级者将进入下一轮")              .Replace("签约奖励已经到账", "双方已确认签约")              .Replace("收官奖励", "赛季奖金")              .Replace("本赛季尚未进入职业联赛。新赛季仍可参加选拔，已经取得的资格与荣誉继续保留。", "你本赛季未参加职业联赛，后续参赛安排有待公布。")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: body.Replace("你现在是", "选手你取得资格：")              .Replace("前往赛事中心确认报名，代表", "确认报名后可代表")              .Replace("签表可在电竞世界查看，", "签表现已公开，")              .Replace("后续轮次自动报名", "晋级者将进入下一轮")              .Replace("签约奖励已经到账", "双方已确认签约")              .Replace("收官奖励", "赛季奖金")              .Replace("本赛季尚未进入职业联赛。新赛季仍可参加选拔，已经取得的资格与荣誉继续保留。", "你本赛季未参加职业联赛，后续参赛安排有待公布。")              .Replace`
- `string.Replace(string, string?)`；输入表达式：`body.Replace("你现在是", "选手你取得资格：")              .Replace("前往赛事中心确认报名，代表", "确认报名后可代表")              .Replace("签表可在电竞世界查看，", "签表现已公开，")              .Replace("后续轮次自动报名", "晋级者将进入下一轮")              .Replace("签约奖励已经到账", "双方已确认签约")              .Replace("收官奖励", "赛季奖金")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: body.Replace("你现在是", "选手你取得资格：")              .Replace("前往赛事中心确认报名，代表", "确认报名后可代表")              .Replace("签表可在电竞世界查看，", "签表现已公开，")              .Replace("后续轮次自动报名", "晋级者将进入下一轮")              .Replace("签约奖励已经到账", "双方已确认签约")              .Replace("收官奖励", "赛季奖金")              .Replace`
- `string.Replace(string, string?)`；输入表达式：`body.Replace("你现在是", "选手你取得资格：")              .Replace("前往赛事中心确认报名，代表", "确认报名后可代表")              .Replace("签表可在电竞世界查看，", "签表现已公开，")              .Replace("后续轮次自动报名", "晋级者将进入下一轮")              .Replace("签约奖励已经到账", "双方已确认签约")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: body.Replace("你现在是", "选手你取得资格：")              .Replace("前往赛事中心确认报名，代表", "确认报名后可代表")              .Replace("签表可在电竞世界查看，", "签表现已公开，")              .Replace("后续轮次自动报名", "晋级者将进入下一轮")              .Replace("签约奖励已经到账", "双方已确认签约")              .Replace`
- `string.Replace(string, string?)`；输入表达式：`body.Replace("你现在是", "选手你取得资格：")              .Replace("前往赛事中心确认报名，代表", "确认报名后可代表")              .Replace("签表可在电竞世界查看，", "签表现已公开，")              .Replace("后续轮次自动报名", "晋级者将进入下一轮")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: body.Replace("你现在是", "选手你取得资格：")              .Replace("前往赛事中心确认报名，代表", "确认报名后可代表")              .Replace("签表可在电竞世界查看，", "签表现已公开，")              .Replace("后续轮次自动报名", "晋级者将进入下一轮")              .Replace`
- `string.Replace(string, string?)`；输入表达式：`body.Replace("你现在是", "选手你取得资格：")              .Replace("前往赛事中心确认报名，代表", "确认报名后可代表")              .Replace("签表可在电竞世界查看，", "签表现已公开，")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: body.Replace("你现在是", "选手你取得资格：")              .Replace("前往赛事中心确认报名，代表", "确认报名后可代表")              .Replace("签表可在电竞世界查看，", "签表现已公开，")              .Replace`
- `string.Replace(string, string?)`；输入表达式：`body.Replace("你现在是", "选手你取得资格：")              .Replace("前往赛事中心确认报名，代表", "确认报名后可代表")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: body.Replace("你现在是", "选手你取得资格：")              .Replace("前往赛事中心确认报名，代表", "确认报名后可代表")              .Replace`
- `string.Replace(string, string?)`；输入表达式：`body.Replace("你现在是", "选手你取得资格：")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: body.Replace("你现在是", "选手你取得资格：")              .Replace`
- `string.Trim()`；输入表达式：`PublicNameText(body, data).Trim()`；返回值紧邻使用处：`ReturnStatementSyntax: return PublicNameText(body, data).Trim();`
- `System.Text.RegularExpressions.Regex.Replace(string, string, string)`；输入表达式：`System.Text.RegularExpressions.Regex.Replace(body, @"[^。！？]*(?:与你|你的交手档案|从你的角度|你对这位选手|双方尚无正式对阵记录)[^。！？]*[。！？]?", "")`；返回值紧邻使用处：`AssignmentExpressionSyntax: body = System.Text.RegularExpressions.Regex.Replace(body, @"[^。！？]*(?:与你|你的交手档案|从你的角度|你对这位选手|双方尚无正式对阵记录)[^。！？]*[。！？]?", "")`
- `System.Text.RegularExpressions.Regex.Replace(string, string, string)`；输入表达式：`System.Text.RegularExpressions.Regex.Replace(body, @"\s*关注\s*\+\d+[，,]\s*奖金\s*\+\d+。?", "")`；返回值紧邻使用处：`AssignmentExpressionSyntax: body = System.Text.RegularExpressions.Regex.Replace(body, @"\s*关注\s*\+\d+[，,]\s*奖金\s*\+\d+。?", "")`

**赋值（含属性/字段和局部值）：**

- `body` = `body.Replace("你现在是", "选手你取得资格：")              .Replace("前往赛事中心确认报名，代表", "确认报名后可代表")              .Replace("签表可在电竞世界查看，", "签表现已公开，")              .Replace("后续轮次自动报名", "晋级者将进入下一轮")              .Replace("签约奖励已经到账", "双方已确认签约")              .Replace("收官奖励", "赛季奖金")              .Replace("本赛季尚未进入职业联赛。新赛季仍可参加选拔，已经取得的资格与荣誉继续保留。", "你本赛季未参加职业联赛，后续参赛安排有待公布。")              .Replace("已取得的资格、俱乐部合同与荣誉将延续至新赛季。", "新赛季的席位竞争即将开始。")`
- `body` = `System.Text.RegularExpressions.Regex.Replace(body, @"[^。！？]*(?:与你|你的交手档案|从你的角度|你对这位选手|双方尚无正式对阵记录)[^。！？]*[。！？]?", "")`
- `body` = `System.Text.RegularExpressions.Regex.Replace(body, @"\s*关注\s*\+\d+[，,]\s*奖金\s*\+\d+。?", "")`

<a id="symbol-f7d8afb43e10"></a>

## `NationalSpire.CareerNarrative.RepairNews(NationalSpire.CareerData) — public static bool RepairNews(CareerData data)`

来源：源码第 71 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerStore.Data`](CareerStore.cs.md#symbol-9724f0dac935)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.CareerNarrative.Audience(NationalSpire.CareerData, string, string, NationalSpire.CareerMatch?, System.Collections.Generic.List<string>?)`](CareerNarrative.cs.md#symbol-34f9cbe529c8)；[`NationalSpire.CareerNarrative.FreshReply(NationalSpire.CareerData, NationalSpire.CareerPerson, string, NationalSpire.CareerMatch?, int, string, System.Collections.Generic.ISet<string>)`](CareerNarrative.cs.md#symbol-670f136e0dfa)；[`NationalSpire.CareerNarrative.NewsBody(string, NationalSpire.CareerData?)`](CareerNarrative.cs.md#symbol-40783a5a4a36)；[`NationalSpire.CareerNarrative.PostAuthor(NationalSpire.CareerData, string, string, NationalSpire.CareerMatch?, System.Collections.Generic.List<string>?)`](CareerNarrative.cs.md#symbol-c9738315f622)；[`NationalSpire.CareerNarrative.PublicNameText(string, NationalSpire.CareerData?)`](CareerNarrative.cs.md#symbol-0ebab312a182)；`NationalSpire.CommunityReply.CommunityReply()`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.HashSet<T>.HashSet()`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.Posts`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerNarrative.Audience(NationalSpire.CareerData, string, string, NationalSpire.CareerMatch?, System.Collections.Generic.List<string>?)`；`NationalSpire.CareerNarrative.FreshReply(NationalSpire.CareerData, NationalSpire.CareerPerson, string, NationalSpire.CareerMatch?, int, string, System.Collections.Generic.ISet<string>)`；`NationalSpire.CareerNarrative.NewsBody(string, NationalSpire.CareerData?)`；`NationalSpire.CareerNarrative.PostAuthor(NationalSpire.CareerData, string, string, NationalSpire.CareerMatch?, System.Collections.Generic.List<string>?)`；`NationalSpire.CareerNarrative.PublicNameText(string, NationalSpire.CareerData?)`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CommunityPost.Analysis`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Body`；`NationalSpire.CommunityPost.Category`；`NationalSpire.CommunityPost.EditorialVersion`；`NationalSpire.CommunityPost.EventKey`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.RelatedPeople`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityPost.Title`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.CommunityReply.Body`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(post.Id + p.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => CareerEngine.StableHash(post.Id + p.Id)`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(post.Id + person.Id)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.StableHash(post.Id + person.Id)`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(post.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.StableHash(post.Id) % 5`
- `NationalSpire.CareerNarrative.Audience(NationalSpire.CareerData, string, string, NationalSpire.CareerMatch?, System.Collections.Generic.List<string>?)`；输入表达式：`Audience(data, post.EventKey, post.Category, match, post.RelatedPeople)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Audience(data, post.EventKey, post.Category, match, post.RelatedPeople)`
- `NationalSpire.CareerNarrative.FreshReply(NationalSpire.CareerData, NationalSpire.CareerPerson, string, NationalSpire.CareerMatch?, int, string, System.Collections.Generic.ISet<string>)`；输入表达式：`FreshReply(data, person, post.Category, match, CareerEngine.StableHash(post.Id + person.Id), post.EventKey, used)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Body = FreshReply(data, person, post.Category, match, CareerEngine.StableHash(post.Id + person.Id), post.EventKey, used)`
- `NationalSpire.CareerNarrative.FreshReply(NationalSpire.CareerData, NationalSpire.CareerPerson, string, NationalSpire.CareerMatch?, int, string, System.Collections.Generic.ISet<string>)`；输入表达式：`FreshReply(data, person, post.Category, match, CareerEngine.StableHash(post.Id + person.Id), post.EventKey, used)`；返回值紧邻使用处：`AssignmentExpressionSyntax: reply.Body = FreshReply(data, person, post.Category, match, CareerEngine.StableHash(post.Id + person.Id), post.EventKey, used)`
- `NationalSpire.CareerNarrative.NewsBody(string, NationalSpire.CareerData?)`；输入表达式：`NewsBody(post.Body, data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: post.Body = NewsBody(post.Body, data)`
- `NationalSpire.CareerNarrative.PostAuthor(NationalSpire.CareerData, string, string, NationalSpire.CareerMatch?, System.Collections.Generic.List<string>?)`；输入表达式：`PostAuthor(data, post.EventKey, post.Category, match, post.RelatedPeople)`；返回值紧邻使用处：`AssignmentExpressionSyntax: post.AuthorId = PostAuthor(data, post.EventKey, post.Category, match, post.RelatedPeople)`
- `NationalSpire.CareerNarrative.PublicNameText(string, NationalSpire.CareerData?)`；输入表达式：`PublicNameText(post.Title, data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: post.Title = PublicNameText(post.Title, data)`
- `NationalSpire.CommunityReply.CommunityReply()`；输入表达式：`new CommunityReply { AuthorId = person.Id, Body = FreshReply(data, person, post.Category, match, CareerEngine.StableHash(post.Id + person.Id), post.EventKey, used) }`；返回值紧邻使用处：`ArgumentSyntax: new CommunityReply { AuthorId = person.Id, Body = FreshReply(data, person, post.Category, match, CareerEngine.StableHash(post.Id + person.Id), post.EventKey, used) }`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`authors.Add(person.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: authors.Add(person.Id);`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`authors.Add(reply.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: audience.Any(p => p.Id == reply.AuthorId) && authors.Add(reply.AuthorId)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`authors.Contains(p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !authors.Contains(p.Id)`
- `System.Collections.Generic.HashSet<T>.HashSet()`；输入表达式：`new HashSet<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HashSet<string>()`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`post.Replies.All(r => r.AuthorId != p.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => post.Replies.All(r => r.AuthorId != p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`audience.Any(p => p.Id == reply.AuthorId)`；返回值紧邻使用处：`BinaryExpressionSyntax: audience.Any(p => p.Id == reply.AuthorId) && authors.Add(reply.AuthorId)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`audience.Where(p => !authors.Contains(p.Id)).OrderBy(p => CareerEngine.StableHash(post.Id + p.Id)).FirstOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = audience.Where(p => !authors.Contains(p.Id)).OrderBy(p => CareerEngine.StableHash(post.Id + p.Id)).FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.FirstOrDefault(m => post.EventKey == "match" + m.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Matches.FirstOrDefault(m => post.EventKey == "match" + m.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`audience.Where(p => !authors.Contains(p.Id)).OrderBy(p => CareerEngine.StableHash(post.Id + p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: audience.Where(p => !authors.Contains(p.Id)).OrderBy(p => CareerEngine.StableHash(post.Id + p.Id)).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`audience.Where(p => post.Replies.All(r => r.AuthorId != p.Id)).OrderBy(p => CareerEngine.StableHash(post.Id + p.Id))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var person in audience.Where(p => post.Replies.All(r => r.AuthorId != p.Id)).OrderBy(p => CareerEngine.StableHash(post.Id + p.Id)))                  {                      if (post.Replies.Count >= count) break;                      post.Replies.Add(new CommunityReply { AuthorId = person.Id, Body = FreshReply(data, person, post.Category, match, CareerEngine.StableHash(post.Id + person.Id), post.EventKey, used) });                  }`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`post.Replies.Take(count)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: post.Replies.Take(count).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`post.Replies.Take(count).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: post.Replies = post.Replies.Take(count).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`audience.Where(p => !authors.Contains(p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: audience.Where(p => !authors.Contains(p.Id)).OrderBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`audience.Where(p => post.Replies.All(r => r.AuthorId != p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: audience.Where(p => post.Replies.All(r => r.AuthorId != p.Id)).OrderBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Posts.Where(p => p.EditorialVersion < 1 && p.AuthorId == "desk")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var post in data.Posts.Where(p => p.EditorialVersion < 1 && p.AuthorId == "desk"))          {              post.Title = PublicNameText(post.Title, data);              post.Body = NewsBody(post.Body, data);              if (post.Analysis.Length == 0)              {                  var match = data.Matches.FirstOrDefault(m => post.EventKey == "match" + m.Id);                  var audience = Audience(data, post.EventKey, post.Category, match, post.RelatedPeople);                  var used = new HashSet<string>();                  var authors = new HashSet<string>();                  foreach (var reply in post.Replies)                  {                      if (audience.Any(p => p.Id == reply.AuthorId) && authors.Add(reply.AuthorId)) continue;                      var person = audience.Where(p => !authors.Contains(p.Id)).OrderBy(p => CareerEngine.StableHash(post.Id + p.Id)).FirstOrDefault();                      if (person == null) continue;                      reply.AuthorId = person.Id; authors.Add(person.Id);                      reply.Body = FreshReply(data, person, post.Category, match, CareerEngine.StableHash(post.Id + person.Id), post.EventKey, used);                  }                  post.AuthorId = PostAuthor(data, post.EventKey, post.Category, match, post.RelatedPeople);                  int count = 2 + CareerEngine.StableHash(post.Id) % 5;                  post.Replies = post.Replies.Take(count).ToList();                  foreach (var person in audience.Where(p => post.Replies.All(r => r.AuthorId != p.Id)).OrderBy(p => CareerEngine.StableHash(post.Id + p.Id)))                  {                      if (post.Replies.Count >= count) break;                      post.Replies.Add(new CommunityReply { AuthorId = person.Id, Body = FreshReply(data, person, post.Category, match, CareerEngine.StableHash(post.Id + person.Id), post.EventKey, used) });                  }              }              post.EditorialVersion = 1; changed = true;          }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`post.Replies.Add(new CommunityReply { AuthorId = person.Id, Body = FreshReply(data, person, post.Category, match, CareerEngine.StableHash(post.Id + person.Id), post.EventKey, used) })`；返回值紧邻使用处：`ExpressionStatementSyntax: post.Replies.Add(new CommunityReply { AuthorId = person.Id, Body = FreshReply(data, person, post.Category, match, CareerEngine.StableHash(post.Id + person.Id), post.EventKey, used) });`

**赋值（含属性/字段和局部值）：**

- `AuthorId` = `person.Id`
- `Body` = `FreshReply(data, person, post.Category, match, CareerEngine.StableHash(post.Id + person.Id), post.EventKey, used)`
- `changed` = `true`
- `post.AuthorId` = `PostAuthor(data, post.EventKey, post.Category, match, post.RelatedPeople)`
- `post.Body` = `NewsBody(post.Body, data)`
- `post.EditorialVersion` = `1`
- `post.Replies` = `post.Replies.Take(count).ToList()`
- `post.Title` = `PublicNameText(post.Title, data)`
- `reply.AuthorId` = `person.Id`
- `reply.Body` = `FreshReply(data, person, post.Category, match, CareerEngine.StableHash(post.Id + person.Id), post.EventKey, used)`

<a id="symbol-08d5c3447a84"></a>

## `NationalSpire.CareerNarrative.Pick(string, int) — private static string Pick(string key, int seed)`

来源：源码第 105 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerNarrative.Evaluation(NationalSpire.CareerData, NationalSpire.CareerPerson)`](CareerNarrative.cs.md#symbol-63592bc97cd1)；[`NationalSpire.CareerNarrative.News(NationalSpire.CareerData, string, string, string, string, NationalSpire.CareerMatch?)`](CareerNarrative.cs.md#symbol-adf20872be24)；[`NationalSpire.CareerNarrative.PlayerEvaluation(NationalSpire.CareerData)`](CareerNarrative.cs.md#symbol-07d10dbaaebd)；[`NationalSpire.CareerNarrative.Reply(NationalSpire.CareerData, NationalSpire.CareerPerson, string, NationalSpire.CareerMatch?, int, string)`](CareerNarrative.cs.md#symbol-6be1cdf0085f)

**调用：** [`NationalSpire.NarrativeText.Pick(string, int)`](NarrativeText.cs.md#symbol-06f7751295a7)

**字段、属性、事件及方法组引用：** `NationalSpire.NarrativeText.Pick(string, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.NarrativeText.Pick(string, int)`；输入表达式：`NarrativeText.Pick(key, seed)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => NarrativeText.Pick(key, seed)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-63592bc97cd1"></a>

## `NationalSpire.CareerNarrative.Evaluation(NationalSpire.CareerData, NationalSpire.CareerPerson) — public static string Evaluation(CareerData d, CareerPerson p)`

来源：源码第 106 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PersonProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](ProfileScreen.cs.md#symbol-2d802d5a07b9)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.CareerNarrative.Pick(string, int)`](CareerNarrative.cs.md#symbol-08d5c3447a84)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；[`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`](EsportsWorld.cs.md#symbol-c10dfd5a2e0e)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerDuel.Draws`；`NationalSpire.CareerDuel.Losses`；`NationalSpire.CareerDuel.PersonId`；`NationalSpire.CareerDuel.Wins`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerNarrative.Pick(string, int)`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.Form`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Losses`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerPerson.Wins`；`NationalSpire.EsportsCareer.Duels`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(d.WorldId + p.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.StableHash(d.WorldId + p.Id)`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(p.Id + p.Form + p.Wins + ":" + p.Losses)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.StableHash(p.Id + p.Form + p.Wins + ":" + p.Losses)`
- `NationalSpire.CareerNarrative.Pick(string, int)`；输入表达式：`Pick("profile.trait", stable / 7)`；返回值紧邻使用处：`BinaryExpressionSyntax: introduction + Pick("profile.trait", stable / 7)`
- `NationalSpire.CareerNarrative.Pick(string, int)`；输入表达式：`Pick(p.MaxAscension >= 10 ? "profile.a10" : p.MaxAscension >= 9 ? "profile.a9" : "profile.a8", stable / 13)`；返回值紧邻使用处：`BinaryExpressionSyntax: introduction + Pick("profile.trait", stable / 7) + "。" + Pick(p.MaxAscension >= 10 ? "profile.a10" : p.MaxAscension >= 9 ? "profile.a9" : "profile.a8", stable / 13)`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(d, p.ClubId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = EsportsWorld.ClubName(d, p.ClubId)`
- `NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；输入表达式：`EsportsWorld.IsProfessional(p)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !EsportsWorld.IsProfessional(p)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Duels.FirstOrDefault(x => x.PersonId == p.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.Duels.FirstOrDefault(x => x.PersonId == p.Id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-07d10dbaaebd"></a>

## `NationalSpire.CareerNarrative.PlayerEvaluation(NationalSpire.CareerData) — public static string PlayerEvaluation(CareerData d)`

来源：源码第 141 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.World(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-ce5a79e2aa5c)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.CareerNarrative.Pick(string, int)`](CareerNarrative.cs.md#symbol-08d5c3447a84)；`int.ToString()`；`string.Replace(string, string?)`；`string.StartsWith(string)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Losses`；`NationalSpire.CareerData.Wins`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerHonor.Id`；`NationalSpire.CareerNarrative.Pick(string, int)`；`NationalSpire.EsportsCareer.BestClear`；`NationalSpire.EsportsCareer.Honors`；`NationalSpire.EsportsCareer.License`；`NationalSpire.EsportsCareer.WinStreak`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.ToString()`；输入表达式：`d.Esports.WinStreak.ToString()`；返回值紧邻使用处：`ArgumentSyntax: d.Esports.WinStreak.ToString()`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(d.WorldId + ":player:" + d.Wins + ":" + d.Losses + ":" + d.Esports.Honors.Count)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.StableHash(d.WorldId + ":player:" + d.Wins + ":" + d.Losses + ":" + d.Esports.Honors.Count)`
- `NationalSpire.CareerNarrative.Pick(string, int)`；输入表达式：`Pick("player." + tier, seed)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Pick("player." + tier, seed).Replace`
- `string.Replace(string, string?)`；输入表达式：`Pick("player." + tier, seed).Replace("{streak}", d.Esports.WinStreak.ToString())`；返回值紧邻使用处：`ReturnStatementSyntax: return Pick("player." + tier, seed).Replace("{streak}", d.Esports.WinStreak.ToString());`
- `string.StartsWith(string)`；输入表达式：`h.Id.StartsWith("continental-")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: h => h.Id.StartsWith("continental-")`
- `string.StartsWith(string)`；输入表达式：`h.Id.StartsWith("worldcup-")`；返回值紧邻使用处：`BinaryExpressionSyntax: h.Id.StartsWith("worldcup-") || h.Id.StartsWith("worldfinal-")`
- `string.StartsWith(string)`；输入表达式：`h.Id.StartsWith("worldfinal-")`；返回值紧邻使用处：`BinaryExpressionSyntax: h.Id.StartsWith("worldcup-") || h.Id.StartsWith("worldfinal-")`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Honors.Any(h => h.Id.StartsWith("continental-"))`；返回值紧邻使用处：`ConditionalExpressionSyntax: d.Esports.Honors.Any(h => h.Id.StartsWith("continental-")) ? "club"              : d.Esports.BestClear >= 10 ? "a10" : d.Esports.BestClear >= 9 ? "a9"              : d.Esports.WinStreak >= 3 ? "streak" : d.Esports.License >= 3 ? "pro" : d.Esports.License > 0 ? "youth" : "new"`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Honors.Any(h => h.Id.StartsWith("worldcup-") || h.Id.StartsWith("worldfinal-"))`；返回值紧邻使用处：`ConditionalExpressionSyntax: d.Esports.Honors.Any(h => h.Id.StartsWith("worldcup-") || h.Id.StartsWith("worldfinal-")) ? "world"              : d.Esports.Honors.Any(h => h.Id.StartsWith("continental-")) ? "club"              : d.Esports.BestClear >= 10 ? "a10" : d.Esports.BestClear >= 9 ? "a9"              : d.Esports.WinStreak >= 3 ? "streak" : d.Esports.License >= 3 ? "pro" : d.Esports.License > 0 ? "youth" : "new"`

**赋值（含属性/字段和局部值）：**


<a id="symbol-77d0573f3e7a"></a>

## `NationalSpire.CareerNarrative.Bank(NationalSpire.CareerData, NationalSpire.CareerPerson, string, NationalSpire.CareerMatch?, int, string) — private static string Bank(CareerData d, CareerPerson p, string category, CareerMatch? match, int variant, string eventKey)`

来源：源码第 150 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerNarrative.News(NationalSpire.CareerData, string, string, string, string, NationalSpire.CareerMatch?)`](CareerNarrative.cs.md#symbol-adf20872be24)；[`NationalSpire.CareerNarrative.Reply(NationalSpire.CareerData, NationalSpire.CareerPerson, string, NationalSpire.CareerMatch?, int, string)`](CareerNarrative.cs.md#symbol-6be1cdf0085f)

**调用：** [`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`](EsportsWorld.cs.md#symbol-c10dfd5a2e0e)；`string.Contains(string)`；`string.StartsWith(string)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerData.Wins`；`NationalSpire.CareerDuel.PersonId`；`NationalSpire.CareerDuel.Wins`；`NationalSpire.CareerMatch.Decider`；`NationalSpire.CareerMatch.Draw`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.OpponentWon`；`NationalSpire.CareerMatch.PlayerWon`；`NationalSpire.CareerMatch.RequiredAscension`；`NationalSpire.CareerMatch.Round`；`NationalSpire.CareerMatch.Status`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.CareerResult.Win`；`NationalSpire.EsportsCareer.Duels`；`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；输入表达式：`EsportsWorld.IsProfessional(p)`；返回值紧邻使用处：`ConditionalExpressionSyntax: EsportsWorld.IsProfessional(p) ? "win.pro" : p.Role == "青训选手" ? "win.youth" : "win.fan"`
- `string.Contains(string)`；输入表达式：`match.Decider.Contains("种子顺位")`；返回值紧邻使用处：`IfStatementSyntax: if (match.Decider.Contains("种子顺位")) return match.PlayerWon ? "seed.win" : "seed.loss";`
- `string.StartsWith(string)`；输入表达式：`eventKey.StartsWith("champion-")`；返回值紧邻使用处：`IfStatementSyntax: if (eventKey.StartsWith("champion-")) return "champion";`
- `string.StartsWith(string)`；输入表达式：`eventKey.StartsWith("draw-")`；返回值紧邻使用处：`IfStatementSyntax: if (eventKey.StartsWith("draw-")) return "bracket";`
- `string.StartsWith(string)`；输入表达式：`eventKey.StartsWith("honor-license-")`；返回值紧邻使用处：`BinaryExpressionSyntax: eventKey.StartsWith("qualification-") || eventKey.StartsWith("honor-license-")`
- `string.StartsWith(string)`；输入表达式：`eventKey.StartsWith("honor-sponsor-")`；返回值紧邻使用处：`IfStatementSyntax: if (eventKey.StartsWith("honor-sponsor-")) return "sponsor";`
- `string.StartsWith(string)`；输入表达式：`eventKey.StartsWith("international-entry-")`；返回值紧邻使用处：`BinaryExpressionSyntax: eventKey.StartsWith("league-entry-") || eventKey.StartsWith("international-entry-")`
- `string.StartsWith(string)`；输入表达式：`eventKey.StartsWith("knockout-")`；返回值紧邻使用处：`BinaryExpressionSyntax: eventKey.StartsWith("knockout-") || eventKey.StartsWith("roundup-")`
- `string.StartsWith(string)`；输入表达式：`eventKey.StartsWith("league-entry-")`；返回值紧邻使用处：`BinaryExpressionSyntax: eventKey.StartsWith("league-entry-") || eventKey.StartsWith("international-entry-")`
- `string.StartsWith(string)`；输入表达式：`eventKey.StartsWith("qualification-")`；返回值紧邻使用处：`BinaryExpressionSyntax: eventKey.StartsWith("qualification-") || eventKey.StartsWith("honor-license-")`
- `string.StartsWith(string)`；输入表达式：`eventKey.StartsWith("roundup-")`；返回值紧邻使用处：`BinaryExpressionSyntax: eventKey.StartsWith("knockout-") || eventKey.StartsWith("roundup-")`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Duels.Any(x => x.PersonId == match.OpponentId && x.Wins >= 2)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Esports.Duels.Any(x => x.PersonId == match.OpponentId && x.Wins >= 2) && variant % 4 == 0`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Results.Any(r => r.MatchId == match.Id && r.Win)`；返回值紧邻使用处：`BinaryExpressionSyntax: match.OpponentWon && d.Results.Any(r => r.MatchId == match.Id && r.Win)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Results.Any(r => r.MatchId == match.Id && r.Win)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Results.Any(r => r.MatchId == match.Id && r.Win)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6be1cdf0085f"></a>

## `NationalSpire.CareerNarrative.Reply(NationalSpire.CareerData, NationalSpire.CareerPerson, string, NationalSpire.CareerMatch?, int, string) — public static string Reply(CareerData d, CareerPerson p, string category, CareerMatch? match, int variant, string eventKey = "")`

来源：源码第 180 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMigration.UpgradeRules(NationalSpire.CareerData)`](CareerMigration.cs.md#symbol-94c0855d9c16)；[`NationalSpire.CareerNarrative.FreshReply(NationalSpire.CareerData, NationalSpire.CareerPerson, string, NationalSpire.CareerMatch?, int, string, System.Collections.Generic.ISet<string>)`](CareerNarrative.cs.md#symbol-670f136e0dfa)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerNarrative.Bank(NationalSpire.CareerData, NationalSpire.CareerPerson, string, NationalSpire.CareerMatch?, int, string)`](CareerNarrative.cs.md#symbol-77d0573f3e7a)；[`NationalSpire.CareerNarrative.Pick(string, int)`](CareerNarrative.cs.md#symbol-08d5c3447a84)；`int.ToString()`；`string.Replace(string, string?)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.ContainsKey(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerDuel.PersonId`；`NationalSpire.CareerDuel.Wins`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerNarrative.Bank(NationalSpire.CareerData, NationalSpire.CareerPerson, string, NationalSpire.CareerMatch?, int, string)`；`NationalSpire.CareerNarrative.Pick(string, int)`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerPerson.Temperament`；`NationalSpire.EsportsCareer.Duels`；`NationalSpire.NarrativeText.Banks`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.ToString()`；输入表达式：`(duel?.Wins ?? 0).ToString()`；返回值紧邻使用处：`ArgumentSyntax: (duel?.Wins ?? 0).ToString()`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, match.OpponentId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: match == null ? "对手" : CareerEngine.DisplayName(d, match.OpponentId)`
- `NationalSpire.CareerNarrative.Bank(NationalSpire.CareerData, NationalSpire.CareerPerson, string, NationalSpire.CareerMatch?, int, string)`；输入表达式：`Bank(d, p, category, match, seed, eventKey)`；返回值紧邻使用处：`ArgumentSyntax: Bank(d, p, category, match, seed, eventKey)`
- `NationalSpire.CareerNarrative.Pick(string, int)`；输入表达式：`Pick("voice." + p.Temperament, seed / 19)`；返回值紧邻使用处：`AssignmentExpressionSyntax: text += Pick("voice." + p.Temperament, seed / 19)`
- `NationalSpire.CareerNarrative.Pick(string, int)`；输入表达式：`Pick(Bank(d, p, category, match, seed, eventKey), seed / 5)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Pick(Bank(d, p, category, match, seed, eventKey), seed / 5)`
- `string.Replace(string, string?)`；输入表达式：`text.Replace("{opponent}", match == null ? "对手" : CareerEngine.DisplayName(d, match.OpponentId)).Replace("{duelWins}", (duel?.Wins ?? 0).ToString())`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = text.Replace("{opponent}", match == null ? "对手" : CareerEngine.DisplayName(d, match.OpponentId)).Replace("{duelWins}", (duel?.Wins ?? 0).ToString())`
- `string.Replace(string, string?)`；输入表达式：`text.Replace("{opponent}", match == null ? "对手" : CareerEngine.DisplayName(d, match.OpponentId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.Replace("{opponent}", match == null ? "对手" : CareerEngine.DisplayName(d, match.OpponentId)).Replace`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Duels.FirstOrDefault(x => x.PersonId == match.OpponentId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: match == null ? null : d.Esports.Duels.FirstOrDefault(x => x.PersonId == match.OpponentId)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`NarrativeText.Banks.ContainsKey("voice." + p.Temperament)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Id != match?.OpponentId && seed % 4 != 0 && NarrativeText.Banks.ContainsKey("voice." + p.Temperament)`

**赋值（含属性/字段和局部值）：**

- `text` += `(seed % 4) switch              {                  0 => $"我平时关注{p.Country}赛区，这次也想多看看其他选手。",                  1 => $"来自{p.Country}看台，比赛还是要按成绩说话。",                  2 => $"{p.Country}这边也有人在看这份战报。",                  _ => $"先从{p.Country}赛区过来留个记录。"              }`
- `text` += `Pick("voice." + p.Temperament, seed / 19)`
- `text` = `text.Replace("{opponent}", match == null ? "对手" : CareerEngine.DisplayName(d, match.OpponentId)).Replace("{duelWins}", (duel?.Wins ?? 0).ToString())`

<a id="symbol-670f136e0dfa"></a>

## `NationalSpire.CareerNarrative.FreshReply(NationalSpire.CareerData, NationalSpire.CareerPerson, string, NationalSpire.CareerMatch?, int, string, System.Collections.Generic.ISet<string>) — public static string FreshReply(CareerData d, CareerPerson p, string category, CareerMatch? match, int seed, string eventKey, ISet<string> used)`

来源：源码第 199 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`](CareerEngine.cs.md#symbol-cd8fd2c800e7)；[`NationalSpire.CareerNarrative.RepairNews(NationalSpire.CareerData)`](CareerNarrative.cs.md#symbol-f7d8afb43e10)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.CareerNarrative.Reply(NationalSpire.CareerData, NationalSpire.CareerPerson, string, NationalSpire.CareerMatch?, int, string)`](CareerNarrative.cs.md#symbol-6be1cdf0085f)；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.ICollection<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.ISet<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Posts`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerNarrative.Reply(NationalSpire.CareerData, NationalSpire.CareerPerson, string, NationalSpire.CareerMatch?, int, string)`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.Body`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(seed + ":" + i)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.StableHash(seed + ":" + i)`
- `NationalSpire.CareerNarrative.Reply(NationalSpire.CareerData, NationalSpire.CareerPerson, string, NationalSpire.CareerMatch?, int, string)`；输入表达式：`Reply(d, p, category, match, CareerEngine.StableHash(seed + ":" + i), eventKey)`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = Reply(d, p, category, match, CareerEngine.StableHash(seed + ":" + i), eventKey)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`recent.Contains(text)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !recent.Contains(text)`
- `System.Collections.Generic.ICollection<T>.Contains(T)`；输入表达式：`used.Contains(text)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !used.Contains(text)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.Posts.Take(12).SelectMany(post => post.Replies).Select(r => r.Body)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Posts.Take(12).SelectMany(post => post.Replies).Select(r => r.Body).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`d.Posts.Take(12).SelectMany(post => post.Replies)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Posts.Take(12).SelectMany(post => post.Replies).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`d.Posts.Take(12)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Posts.Take(12).SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`d.Posts.Take(12).SelectMany(post => post.Replies).Select(r => r.Body).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Posts.Take(12).SelectMany(post => post.Replies).Select(r => r.Body).ToHashSet()`
- `System.Collections.Generic.ISet<T>.Add(T)`；输入表达式：`used.Add(text)`；返回值紧邻使用处：`ExpressionStatementSyntax: used.Add(text);`

**赋值（含属性/字段和局部值）：**

- `text` = `Reply(d, p, category, match, CareerEngine.StableHash(seed + ":" + i), eventKey)`

<a id="symbol-adf20872be24"></a>

## `NationalSpire.CareerNarrative.News(NationalSpire.CareerData, string, string, string, string, NationalSpire.CareerMatch?) — public static (string Title, string Body) News(CareerData d, string key, string title, string body, string category, CareerMatch? match)`

来源：源码第 210 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`](CareerEngine.cs.md#symbol-cd8fd2c800e7)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.CareerNarrative.Bank(NationalSpire.CareerData, NationalSpire.CareerPerson, string, NationalSpire.CareerMatch?, int, string)`](CareerNarrative.cs.md#symbol-77d0573f3e7a)；[`NationalSpire.CareerNarrative.NewsBody(string, NationalSpire.CareerData?)`](CareerNarrative.cs.md#symbol-40783a5a4a36)；[`NationalSpire.CareerNarrative.Pick(string, int)`](CareerNarrative.cs.md#symbol-08d5c3447a84)；[`NationalSpire.CareerNarrative.PublicNameText(string, NationalSpire.CareerData?)`](CareerNarrative.cs.md#symbol-0ebab312a182)；`NationalSpire.CareerPerson.CareerPerson()`；`string.IndexOf(char)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.ContainsKey(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerMatch.Draw`；`NationalSpire.CareerMatch.Event`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.PlayerWon`；`NationalSpire.CareerMatch.Status`；`NationalSpire.CareerNarrative.Bank(NationalSpire.CareerData, NationalSpire.CareerPerson, string, NationalSpire.CareerMatch?, int, string)`；`NationalSpire.CareerNarrative.NewsBody(string, NationalSpire.CareerData?)`；`NationalSpire.CareerNarrative.Pick(string, int)`；`NationalSpire.CareerNarrative.PublicNameText(string, NationalSpire.CareerData?)`；`NationalSpire.NarrativeText.Banks`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, match.OpponentId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.DisplayName(d, match.OpponentId)`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(d.WorldId + key)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.StableHash(d.WorldId + key)`
- `NationalSpire.CareerNarrative.Bank(NationalSpire.CareerData, NationalSpire.CareerPerson, string, NationalSpire.CareerMatch?, int, string)`；输入表达式：`Bank(d, new CareerPerson(), category, null, seed, key)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Bank(d, new CareerPerson(), category, null, seed, key)`
- `NationalSpire.CareerNarrative.NewsBody(string, NationalSpire.CareerData?)`；输入表达式：`NewsBody(body, d)`；返回值紧邻使用处：`ArgumentSyntax: NewsBody(body, d)`
- `NationalSpire.CareerNarrative.Pick(string, int)`；输入表达式：`Pick("bulletin." + bank, seed / 7)`；返回值紧邻使用处：`BinaryExpressionSyntax: Pick("bulletin." + bank, seed / 7) + body`
- `NationalSpire.CareerNarrative.PublicNameText(string, NationalSpire.CareerData?)`；输入表达式：`PublicNameText(title, d)`；返回值紧邻使用处：`ArgumentSyntax: PublicNameText(title, d)`
- `NationalSpire.CareerPerson.CareerPerson()`；输入表达式：`new CareerPerson()`；返回值紧邻使用处：`ArgumentSyntax: new CareerPerson()`
- `string.IndexOf(char)`；输入表达式：`title.IndexOf('：')`；返回值紧邻使用处：`EqualsValueClauseSyntax: = title.IndexOf('：')`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`NarrativeText.Banks.ContainsKey("bulletin." + bank)`；返回值紧邻使用处：`IfStatementSyntax: if (NarrativeText.Banks.ContainsKey("bulletin." + bank)) body = Pick("bulletin." + bank, seed / 7) + body;`

**赋值（含属性/字段和局部值）：**

- `body` = `Pick("bulletin." + bank, seed / 7) + body`
- `title` = `(seed % 6) switch              {                  0 => $"{match.Event}战报：你对阵{opponent}，{outcome}",                  1 => $"赛果确认｜{match.Event}，你{outcome}",                  2 => $"你与{opponent}的交手结束：{outcome}",                  3 => $"{match.Event} · {opponent}一战的结果公布：你{outcome}",                  4 => $"今日赛场：你在{match.Event}{outcome}",                  _ => $"正式战报｜你与{opponent}之战，{outcome}"              }`
- `title` = `headings[seed % headings.Length] + "：" + (separator >= 0 ? title[(separator + 1)..] : title)`
