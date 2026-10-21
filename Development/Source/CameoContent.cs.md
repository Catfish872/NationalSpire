# CameoContent.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`EBDD8DC014388CFA4B471C58568230266D558E6AC1F58058DD7F3112ACF92B41`。来源：[源码](../../CameoContent.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CameoState`、`NationalSpire.CameoContent`、`NationalSpire.CameoContent.Person`、`NationalSpire.CameoContent.Story`。

字段、事件及初始值（源码原样）：

```csharp
public const int Version = 2;
public static readonly Person[] People =
    [
        new("baiqu", "白区se", "静默猎手", "玄武猎手，通过大量格挡抵御伤害",
            "白区se a1 53连高手 职业选手+主播 擅长静默猎手，通过大量的格挡让怪物难以撼动半分，被誉为“玄武猎手”。但是平时管不住手脚，总喜欢在各种店里办卡，明明之后就再也没去过那家店。", ["职业选手", "主播"], "baiqu.jpg"),
        new("xiaofu", "小夫", "故障机器人", "使用自行研发的卡9流派",
            "小夫 920连高手 惊人的连胜场数证明了他的实力 擅长故障机器人，使用其研发的卡9流派，无往不胜。曾经是上班族，不过如今已经是职业选手出道。有传言道他与白区se之间有某种难以言说的关系。", ["职业选手", "上班族出身"], "xiaofu.jpg"),
        new("caichu", "菜厨来辣", "铁甲战士", "抓取大量质量上乘的好卡来迅速提升战斗力",
            "菜厨来辣 主播 战士选手，擅长抓取大量质量上乘的好卡来迅速提升战斗力，不知道为什么，明明是战士选手，却选择了储君的卡牌作为头像......", ["职业选手", "主播"], "COSMIC_INDIFFERENCE"),
        new("guangtou", "愤怒的光头", "铁甲战士", "稳健而扎实的打法",
            "愤怒的光头 战士选手 稳健而扎实的打法吸引了大量的粉丝，平时也非常温和，是一名少有的正常选手。但是在某天直播的夜里，因不明原因愤怒异常......", ["职业选手", "主播"], "guangtou.jpg"),
        new("weijimi", "维基米游戏解说", "", "依赖关键牌，抓到关键牌时会惊声尖叫",
            "维基米游戏解说 成功从解说进入职业选手队伍的范例，其打法依赖于关键牌的获取。每当抓到关键牌时，总会发出惊声尖叫，仿佛在害怕着什么东西被刺破一样。", ["职业选手", "解说员"], "weijimi.jpg")
    ];
public static readonly Story[] Stories =
    [
        new("cameo-dispute", 2, "震惊！白区se与小夫之间，居然闹出了这般矛盾！",
            "本台记者抢先报道，a1 53连高手白区se与920连高手小夫，近日就大卡组与小卡组的孰优孰劣问题，产生了激烈的口角，并进一步演变为斗殴！到底是什么，让两名职业选手如此大打出手？我们拍摄了事件发生时的珍贵历史影像。",
            "dispute.png", "https://www.bilibili.com/video/BV1hphY6sELv/"),
        new("cameo-duel", 3, "震惊！小夫920连胜 VS 白区sea153连胜 正式发起决斗！",
            "前段时间，两位选手之间的矛盾不仅没有得到解决，现在愈演愈烈，终于，二人发起了正式的决斗！本台记者冒着生命危险，成功记录下了这珍贵的一刻！",
            "duel.png", "https://www.bilibili.com/video/BV1Utey68EQj/")
    ];
```

<a id="symbol-e0f221a3cac5"></a>

## `NationalSpire.CameoState.Version — public int Version`

来源：源码第 5 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-cd69cafe0efe"></a>

## `NationalSpire.CameoState.Editions — public int Editions`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-65ece66579e6"></a>

## `NationalSpire.CameoState.LastEndDay — public int LastEndDay`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-37cea0979aaf"></a>

## `NationalSpire.CameoContent.FindStory(NationalSpire.WeeklySlide) — public static Story? FindStory(WeeklySlide slide)`

来源：源码第 37 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CameoAssets.ForStory(NationalSpire.WeeklySlide)`](CameoAssets.cs.md#symbol-89a6e69b1880)；[`NationalSpire.CameoContent.GeneratedSlides(NationalSpire.WeeklyEdition)`](CameoContent.cs.md#symbol-57586e8f0819)；[`NationalSpire.CameoContent.VisibleSlides(NationalSpire.WeeklyEdition)`](CameoContent.cs.md#symbol-29d9526009c4)；[`NationalSpire.CareerScreen.RenderWeeklyDetail(NationalSpire.CareerData)`](WeeklyScreen.cs.md#symbol-b3f0ffc5fb7d)；[`NationalSpire.WeeklyJournal.Recover(NationalSpire.CareerData)`](WeeklyJournal.cs.md#symbol-f465ec0d1539)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CameoContent.Stories`；`NationalSpire.CameoContent.Story.Key`；`NationalSpire.WeeklySlide.CameoStoryId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`Stories.FirstOrDefault(s => s.Key == slide.CameoStoryId)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Stories.FirstOrDefault(s => s.Key == slide.CameoStoryId)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-57586e8f0819"></a>

## `NationalSpire.CameoContent.GeneratedSlides(NationalSpire.WeeklyEdition) — public static IEnumerable<WeeklySlide> GeneratedSlides(WeeklyEdition issue)`

来源：源码第 38 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ApplyWeeklyResponse(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool, string)`](AiWeekly.cs.md#symbol-48defc4d8c32)；[`NationalSpire.AiService.BuildWeeklyContext(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool)`](AiWeekly.cs.md#symbol-d24065dcfca3)；[`NationalSpire.AiService.GenerateWeekly(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool, bool)`](AiWeekly.cs.md#symbol-9db02a002768)

**调用：** [`NationalSpire.CameoContent.FindStory(NationalSpire.WeeklySlide)`](CameoContent.cs.md#symbol-37cea0979aaf)；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CameoContent.FindStory(NationalSpire.WeeklySlide)`；`NationalSpire.WeeklyEdition.Slides`；`NationalSpire.WeeklySlide.CeremonySeason`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CameoContent.FindStory(NationalSpire.WeeklySlide)`；输入表达式：`FindStory(s)`；返回值紧邻使用处：`BinaryExpressionSyntax: FindStory(s) == null`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`issue.Slides.Where(s => FindStory(s) == null && s.CeremonySeason == 0)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => issue.Slides.Where(s => FindStory(s) == null && s.CeremonySeason == 0)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-29d9526009c4"></a>

## `NationalSpire.CameoContent.VisibleSlides(NationalSpire.WeeklyEdition) — public static List<WeeklySlide> VisibleSlides(WeeklyEdition issue)`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RenderWeeklySlide(NationalSpire.CareerData, bool)`](WeeklyScreen.cs.md#symbol-184e7ff58940)；[`NationalSpire.CareerScreen.TickWeekly(double)`](WeeklyScreen.cs.md#symbol-90f7d7772fea)；[`NationalSpire.CareerScreen.WeeklyCarousel(NationalSpire.CareerData)`](WeeklyScreen.cs.md#symbol-86166c5fd833)

**调用：** [`NationalSpire.CameoContent.FindStory(NationalSpire.WeeklySlide)`](CameoContent.cs.md#symbol-37cea0979aaf)；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiWorkState.State`；`NationalSpire.CameoContent.FindStory(NationalSpire.WeeklySlide)`；`NationalSpire.WeeklyEdition.NewsWork`；`NationalSpire.WeeklyEdition.Slides`；`NationalSpire.WeeklySlide.CeremonySeason`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CameoContent.FindStory(NationalSpire.WeeklySlide)`；输入表达式：`FindStory(s)`；返回值紧邻使用处：`BinaryExpressionSyntax: FindStory(s) != null`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`issue.Slides         .Where(s => s.CeremonySeason > 0 || issue.NewsWork.State == "completed" || issue.NewsWork.State == "disabled" && FindStory(s) != null)         .OrderByDescending(s => s.CeremonySeason)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: issue.Slides         .Where(s => s.CeremonySeason > 0 || issue.NewsWork.State == "completed" || issue.NewsWork.State == "disabled" && FindStory(s) != null)         .OrderByDescending(s => s.CeremonySeason).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`issue.Slides         .Where(s => s.CeremonySeason > 0 || issue.NewsWork.State == "completed" || issue.NewsWork.State == "disabled" && FindStory(s) != null)         .OrderByDescending(s => s.CeremonySeason).ToList()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => issue.Slides         .Where(s => s.CeremonySeason > 0 || issue.NewsWork.State == "completed" || issue.NewsWork.State == "disabled" && FindStory(s) != null)         .OrderByDescending(s => s.CeremonySeason).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`issue.Slides         .Where(s => s.CeremonySeason > 0 || issue.NewsWork.State == "completed" || issue.NewsWork.State == "disabled" && FindStory(s) != null)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: issue.Slides         .Where(s => s.CeremonySeason > 0 || issue.NewsWork.State == "completed" || issue.NewsWork.State == "disabled" && FindStory(s) != null)         .OrderByDescending`

**赋值（含属性/字段和局部值）：**


<a id="symbol-be5fe8cf27bd"></a>

## `NationalSpire.CameoContent.Ensure(NationalSpire.CareerData) — public static void Ensure(CareerData data)`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CameoContent.AppendPreview(NationalSpire.CareerData)`](CameoContent.cs.md#symbol-82d9b3373a64)；[`NationalSpire.CareerEngine.CreateNew(bool, int)`](CareerEngine.cs.md#symbol-63d93017946a)；[`NationalSpire.CareerEngine.NormalizeRoster(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-eb11b96e7400)

**调用：** [`NationalSpire.CameoContent.UpgradeRecords(NationalSpire.CareerData)`](CameoContent.cs.md#symbol-f8a845ee5b69)；[`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`](EsportsWorld.cs.md#symbol-c10dfd5a2e0e)；`NationalSpire.PersonalityProfile.PersonalityProfile()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<int>.Max()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Clear()`；`System.Collections.Generic.List<T>.Remove(T)`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CameoContent.People`；`NationalSpire.CameoContent.Person.Biography`；`NationalSpire.CameoContent.Person.Character`；`NationalSpire.CameoContent.Person.Identities`；`NationalSpire.CameoContent.Person.Key`；`NationalSpire.CameoContent.Person.Name`；`NationalSpire.CameoContent.Person.Style`；`NationalSpire.CameoContent.UpgradeRecords(NationalSpire.CareerData)`；`NationalSpire.CameoContent.Version`；`NationalSpire.CameoState.LastEndDay`；`NationalSpire.CameoState.Version`；`NationalSpire.CareerClub.Country`；`NationalSpire.CareerClub.Id`；`NationalSpire.CareerData.Cameos`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.Posts`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerData.SavedThreads`；`NationalSpire.CareerData.WeeklyEditions`；`NationalSpire.CareerData.WeeklyPersonBaselines`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerLifeState.Relationships`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerPerson.AiIntroduction`；`NationalSpire.CareerPerson.Biography`；`NationalSpire.CareerPerson.CameoId`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Connections`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.Gender`；`NationalSpire.CareerPerson.Handle`；`NationalSpire.CareerPerson.HandleAliases`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Identities`；`NationalSpire.CareerPerson.IntroductionDay`；`NationalSpire.CareerPerson.Name`；`NationalSpire.CareerPerson.Personality`；`NationalSpire.CareerPerson.Style`；`NationalSpire.CareerPerson.SupportedClubId`；`NationalSpire.CareerPerson.Temperament`；`NationalSpire.CareerPerson.Voice`；`NationalSpire.CareerResult.OpponentId`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.RelatedPeople`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.AuthorId`；`NationalSpire.EsportsCareer.Clubs`；`NationalSpire.EsportsCareer.EcosystemVersion`；`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；`NationalSpire.PersonalityProfile.Version`；`NationalSpire.WeeklyEdition.EndDay`；`NationalSpire.WeeklyEdition.Profiles`；`NationalSpire.WeeklyEdition.Slides`；`NationalSpire.WeeklyProfile.Id`；`NationalSpire.WeeklySlide.People`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CameoContent.UpgradeRecords(NationalSpire.CareerData)`；输入表达式：`UpgradeRecords(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: UpgradeRecords(data);`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(data.WorldId + ":cameo:" + p.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => CareerEngine.StableHash(data.WorldId + ":cameo:" + p.Id)`
- `NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；输入表达式：`EsportsWorld.IsProfessional(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.CameoId.Length == 0 && p.Country == "中国" && clubs.Contains(p.ClubId)                     && EsportsWorld.IsProfessional(p)`
- `NationalSpire.PersonalityProfile.PersonalityProfile()`；输入表达式：`new() { Version = 1 }`；返回值紧邻使用处：`AssignmentExpressionSyntax: person.Personality = new() { Version = 1 }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`data.WeeklyPersonBaselines.Remove(person.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: data.WeeklyPersonBaselines.Remove(person.Id);`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`clubs.Contains(p.ClubId)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.CameoId.Length == 0 && p.Country == "中国" && clubs.Contains(p.ClubId)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`known.Contains(p.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => known.Contains(p.Id)`
- `System.Collections.Generic.IEnumerable<int>.Max()`；输入表达式：`data.WeeklyEditions.Select(w => w.EndDay).DefaultIfEmpty(0).Max()`；返回值紧邻使用处：`AssignmentExpressionSyntax: data.Cameos.LastEndDay = data.WeeklyEditions.Select(w => w.EndDay).DefaultIfEmpty(0).Max()`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.People.Any(p => p.CameoId == definition.Key)`；返回值紧邻使用处：`IfStatementSyntax: if (data.People.Any(p => p.CameoId == definition.Key)) continue;`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId)).Append(p.AuthorId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId)).Append(p.AuthorId)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`data.Posts.Concat(data.SavedThreads)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Posts.Concat(data.SavedThreads).SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`data.Results.Select(r => r.OpponentId)             .Concat(data.Posts.Concat(data.SavedThreads).SelectMany(p => p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId)).Append(p.AuthorId)))             .Concat(data.WeeklyEditions.SelectMany(w => w.Profiles.Select(p => p.Id).Concat(w.Slides.SelectMany(s => s.People))))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Results.Select(r => r.OpponentId)             .Concat(data.Posts.Concat(data.SavedThreads).SelectMany(p => p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId)).Append(p.AuthorId)))             .Concat(data.WeeklyEditions.SelectMany(w => w.Profiles.Select(p => p.Id).Concat(w.Slides.SelectMany(s => s.People)))).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`data.Results.Select(r => r.OpponentId)             .Concat(data.Posts.Concat(data.SavedThreads).SelectMany(p => p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId)).Append(p.AuthorId)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Results.Select(r => r.OpponentId)             .Concat(data.Posts.Concat(data.SavedThreads).SelectMany(p => p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId)).Append(p.AuthorId)))             .Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId)).Append`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`w.Profiles.Select(p => p.Id).Concat(w.Slides.SelectMany(s => s.People))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: w => w.Profiles.Select(p => p.Id).Concat(w.Slides.SelectMany(s => s.People))`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.People.Count(c => c.CameoId.Length > 0 && c.ClubId == p.ClubId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => data.People.Count(c => c.CameoId.Length > 0 && c.ClubId == p.ClubId)`
- `System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；输入表达式：`data.WeeklyEditions.Select(w => w.EndDay).DefaultIfEmpty(0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.WeeklyEditions.Select(w => w.EndDay).DefaultIfEmpty(0).Max`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`data.People.Where(p => p.CameoId.Length == 0 && p.Country == "中国" && clubs.Contains(p.ClubId)                     && EsportsWorld.IsProfessional(p) && p.Id != pendingOpponent)                 .OrderBy(p => data.Life.Relationships.GetValueOrDefault(p.Id)).ThenBy(p => known.Contains(p.Id))                 .ThenBy(p => data.People.Count(c => c.CameoId.Length > 0 && c.ClubId == p.ClubId))                 .ThenBy(p => CareerEngine.StableHash(data.WorldId + ":cameo:" + p.Id)).FirstOrDefault()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.People.Where(p => p.CameoId.Length == 0 && p.Country == "中国" && clubs.Contains(p.ClubId)                     && EsportsWorld.IsProfessional(p) && p.Id != pendingOpponent)                 .OrderBy(p => data.Life.Relationships.GetValueOrDefault(p.Id)).ThenBy(p => known.Contains(p.Id))                 .ThenBy(p => data.People.Count(c => c.CameoId.Length > 0 && c.ClubId == p.ClubId))                 .ThenBy(p => CareerEngine.StableHash(data.WorldId + ":cameo:" + p.Id)).FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.FirstOrDefault(m => m.Id == data.PendingMatchId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: data.Matches.FirstOrDefault(m => m.Id == data.PendingMatchId)?.OpponentId`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.People.Where(p => p.CameoId.Length == 0 && p.Country == "中国" && clubs.Contains(p.ClubId)                     && EsportsWorld.IsProfessional(p) && p.Id != pendingOpponent)                 .OrderBy(p => data.Life.Relationships.GetValueOrDefault(p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.People.Where(p => p.CameoId.Length == 0 && p.Country == "中国" && clubs.Contains(p.ClubId)                     && EsportsWorld.IsProfessional(p) && p.Id != pendingOpponent)                 .OrderBy(p => data.Life.Relationships.GetValueOrDefault(p.Id)).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`data.Esports.Clubs.Where(c => c.Country == "中国").Select(c => c.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Esports.Clubs.Where(c => c.Country == "中国").Select(c => c.Id).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`data.Results.Select(r => r.OpponentId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Results.Select(r => r.OpponentId)             .Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`data.WeeklyEditions.Select(w => w.EndDay)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.WeeklyEditions.Select(w => w.EndDay).DefaultIfEmpty`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`p.Replies.Select(r => r.AuthorId)`；返回值紧邻使用处：`ArgumentSyntax: p.Replies.Select(r => r.AuthorId)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`pair.Where(p => p != person).Select(p => p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pair.Where(p => p != person).Select(p => p.Id).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`w.Profiles.Select(p => p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: w.Profiles.Select(p => p.Id).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`data.Posts.Concat(data.SavedThreads).SelectMany(p => p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId)).Append(p.AuthorId))`；返回值紧邻使用处：`ArgumentSyntax: data.Posts.Concat(data.SavedThreads).SelectMany(p => p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId)).Append(p.AuthorId))`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`data.WeeklyEditions.SelectMany(w => w.Profiles.Select(p => p.Id).Concat(w.Slides.SelectMany(s => s.People)))`；返回值紧邻使用处：`ArgumentSyntax: data.WeeklyEditions.SelectMany(w => w.Profiles.Select(p => p.Id).Concat(w.Slides.SelectMany(s => s.People)))`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`w.Slides.SelectMany(s => s.People)`；返回值紧邻使用处：`ArgumentSyntax: w.Slides.SelectMany(s => s.People)`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`data.Esports.Clubs.Where(c => c.Country == "中国").Select(c => c.Id).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Esports.Clubs.Where(c => c.Country == "中国").Select(c => c.Id).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`data.Results.Select(r => r.OpponentId)             .Concat(data.Posts.Concat(data.SavedThreads).SelectMany(p => p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId)).Append(p.AuthorId)))             .Concat(data.WeeklyEditions.SelectMany(w => w.Profiles.Select(p => p.Id).Concat(w.Slides.SelectMany(s => s.People)))).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Results.Select(r => r.OpponentId)             .Concat(data.Posts.Concat(data.SavedThreads).SelectMany(p => p.RelatedPeople.Concat(p.Replies.Select(r => r.AuthorId)).Append(p.AuthorId)))             .Concat(data.WeeklyEditions.SelectMany(w => w.Profiles.Select(p => p.Id).Concat(w.Slides.SelectMany(s => s.People)))).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`data.People.Where(p => p.CameoId is "baiqu" or "xiaofu").ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.People.Where(p => p.CameoId is "baiqu" or "xiaofu").ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`definition.Identities.ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: person.Identities = definition.Identities.ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`pair.Where(p => p != person).Select(p => p.Id).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: person.Connections = pair.Where(p => p != person).Select(p => p.Id).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Esports.Clubs.Where(c => c.Country == "中国")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Esports.Clubs.Where(c => c.Country == "中国").Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.People.Where(p => p.CameoId is "baiqu" or "xiaofu")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.People.Where(p => p.CameoId is "baiqu" or "xiaofu").ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.People.Where(p => p.CameoId.Length == 0 && p.Country == "中国" && clubs.Contains(p.ClubId)                     && EsportsWorld.IsProfessional(p) && p.Id != pendingOpponent)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.People.Where(p => p.CameoId.Length == 0 && p.Country == "中国" && clubs.Contains(p.ClubId)                     && EsportsWorld.IsProfessional(p) && p.Id != pendingOpponent)                 .OrderBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.People.Where(p => p.CameoId.Length > 0)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var person in data.People.Where(p => p.CameoId.Length > 0)) person.Gender = "男";`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`pair.Where(p => p != person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pair.Where(p => p != person).Select`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`data.Life.Relationships.GetValueOrDefault(p.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => data.Life.Relationships.GetValueOrDefault(p.Id)`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`person.Connections.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: person.Connections.Clear();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`person.HandleAliases.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: person.HandleAliases.Clear();`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`other.Connections.Remove(person.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: other.Connections.Remove(person.Id);`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.People.Where(p => p.CameoId.Length == 0 && p.Country == "中国" && clubs.Contains(p.ClubId)                     && EsportsWorld.IsProfessional(p) && p.Id != pendingOpponent)                 .OrderBy(p => data.Life.Relationships.GetValueOrDefault(p.Id)).ThenBy(p => known.Contains(p.Id))                 .ThenBy(p => data.People.Count(c => c.CameoId.Length > 0 && c.ClubId == p.ClubId))                 .ThenBy(p => CareerEngine.StableHash(data.WorldId + ":cameo:" + p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.People.Where(p => p.CameoId.Length == 0 && p.Country == "中国" && clubs.Contains(p.ClubId)                     && EsportsWorld.IsProfessional(p) && p.Id != pendingOpponent)                 .OrderBy(p => data.Life.Relationships.GetValueOrDefault(p.Id)).ThenBy(p => known.Contains(p.Id))                 .ThenBy(p => data.People.Count(c => c.CameoId.Length > 0 && c.ClubId == p.ClubId))                 .ThenBy(p => CareerEngine.StableHash(data.WorldId + ":cameo:" + p.Id)).FirstOrDefault`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.People.Where(p => p.CameoId.Length == 0 && p.Country == "中国" && clubs.Contains(p.ClubId)                     && EsportsWorld.IsProfessional(p) && p.Id != pendingOpponent)                 .OrderBy(p => data.Life.Relationships.GetValueOrDefault(p.Id)).ThenBy(p => known.Contains(p.Id))                 .ThenBy(p => data.People.Count(c => c.CameoId.Length > 0 && c.ClubId == p.ClubId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.People.Where(p => p.CameoId.Length == 0 && p.Country == "中国" && clubs.Contains(p.ClubId)                     && EsportsWorld.IsProfessional(p) && p.Id != pendingOpponent)                 .OrderBy(p => data.Life.Relationships.GetValueOrDefault(p.Id)).ThenBy(p => known.Contains(p.Id))                 .ThenBy(p => data.People.Count(c => c.CameoId.Length > 0 && c.ClubId == p.ClubId))                 .ThenBy`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.People.Where(p => p.CameoId.Length == 0 && p.Country == "中国" && clubs.Contains(p.ClubId)                     && EsportsWorld.IsProfessional(p) && p.Id != pendingOpponent)                 .OrderBy(p => data.Life.Relationships.GetValueOrDefault(p.Id)).ThenBy(p => known.Contains(p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.People.Where(p => p.CameoId.Length == 0 && p.Country == "中国" && clubs.Contains(p.ClubId)                     && EsportsWorld.IsProfessional(p) && p.Id != pendingOpponent)                 .OrderBy(p => data.Life.Relationships.GetValueOrDefault(p.Id)).ThenBy(p => known.Contains(p.Id))                 .ThenBy`

**赋值（含属性/字段和局部值）：**

- `data.Cameos.LastEndDay` = `data.WeeklyEditions.Select(w => w.EndDay).DefaultIfEmpty(0).Max()`
- `data.Cameos.Version` = `1`
- `person.AiIntroduction` = `""`
- `person.Biography` = `definition.Biography`
- `person.CameoId` = `definition.Key`
- `person.Character` = `definition.Character`
- `person.Connections` = `pair.Where(p => p != person).Select(p => p.Id).ToList()`
- `person.Gender` = `"男"`
- `person.Handle` = `definition.Name`
- `person.Identities` = `definition.Identities.ToList()`
- `person.IntroductionDay` = `0`
- `person.Name` = `person.Handle = definition.Name`
- `person.Personality` = `new() { Version = 1 }`
- `person.Style` = `definition.Style`
- `person.SupportedClubId` = `person.ClubId`
- `person.Temperament` = `definition.Key == "guangtou" ? "温和" : ""`
- `person.Voice` = `definition.Key == "weijimi" ? "抓到关键牌时容易惊声尖叫" : ""`
- `Version` = `1`

<a id="symbol-4b0402048b3d"></a>

## `NationalSpire.CameoContent.StreakText(NationalSpire.CareerPerson) — public static string StreakText(CareerPerson person)`

来源：源码第 88 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.Persona(NationalSpire.CareerData, NationalSpire.CareerPerson, string, int?, int?, NationalSpire.PersonalityProfile?, int, System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>?, NationalSpire.ChatTimeline.PublicMemoryRequest?)`](AiDiscussion.cs.md#symbol-7fe54dbd182e)；[`NationalSpire.CareerScreen.PersonProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](ProfileScreen.cs.md#symbol-2d802d5a07b9)；[`NationalSpire.PrivatePublicContext.Profiles(NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?, bool, bool)`](PrivatePublicContext.cs.md#symbol-4b2e31466c7e)；[`NationalSpire.WeeklyJournal.CloseWeek(NationalSpire.CareerData)`](WeeklyJournal.cs.md#symbol-fe6dece0c758)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.RecordedStreakAscension`；`NationalSpire.CareerPerson.RecordedWinStreak`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f8a845ee5b69"></a>

## `NationalSpire.CameoContent.UpgradeRecords(NationalSpire.CareerData) — private static void UpgradeRecords(CareerData data)`

来源：源码第 91 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CameoContent.Ensure(NationalSpire.CareerData)`](CameoContent.cs.md#symbol-be5fe8cf27bd)

**调用：** [`NationalSpire.CameoContent.ApplyRecord(NationalSpire.CareerPerson)`](CameoContent.cs.md#symbol-b7b57c1ed1c6)；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CameoContent.ApplyRecord(NationalSpire.CareerPerson)`；`NationalSpire.CameoContent.Version`；`NationalSpire.CameoState.Version`；`NationalSpire.CareerData.Cameos`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.Posts`；`NationalSpire.CareerData.SavedThreads`；`NationalSpire.CareerData.WeeklyPersonBaselines`；`NationalSpire.CareerPerson.AiIntroduction`；`NationalSpire.CareerPerson.Biography`；`NationalSpire.CareerPerson.CameoId`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.IntroductionDay`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CommunityPost.PeopleAtEvent`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CameoContent.ApplyRecord(NationalSpire.CareerPerson)`；输入表达式：`ApplyRecord(person)`；返回值紧邻使用处：`ExpressionStatementSyntax: ApplyRecord(person);`
- `NationalSpire.CameoContent.ApplyRecord(NationalSpire.CareerPerson)`；输入表达式：`ApplyRecord(snapshot)`；返回值紧邻使用处：`ExpressionStatementSyntax: ApplyRecord(snapshot);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`data.WeeklyPersonBaselines.Remove(person.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: data.WeeklyPersonBaselines.Remove(person.Id);`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`data.Posts.Concat(data.SavedThreads)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Posts.Concat(data.SavedThreads).SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.People.FirstOrDefault(p => p.Id == snapshot.Id && p.CameoId.Length > 0 && p.PublicName == snapshot.PublicName)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.People.FirstOrDefault(p => p.Id == snapshot.Id && p.CameoId.Length > 0 && p.PublicName == snapshot.PublicName)`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`data.Posts.Concat(data.SavedThreads).SelectMany(p => p.PeopleAtEvent)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var snapshot in data.Posts.Concat(data.SavedThreads).SelectMany(p => p.PeopleAtEvent))         {             var current = data.People.FirstOrDefault(p => p.Id == snapshot.Id && p.CameoId.Length > 0 && p.PublicName == snapshot.PublicName);             if (current == null) continue;             snapshot.CameoId = current.CameoId; snapshot.Biography = current.Biography;             ApplyRecord(snapshot);         }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.People.Where(p => p.CameoId.Length > 0)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var person in data.People.Where(p => p.CameoId.Length > 0))         {             ApplyRecord(person);             person.AiIntroduction = "";             person.IntroductionDay = 0;             // 补入生涯开始前的既有履历，不能算作本期新增通关。             data.WeeklyPersonBaselines.Remove(person.Id);         }`

**赋值（含属性/字段和局部值）：**

- `data.Cameos.Version` = `Version`
- `person.AiIntroduction` = `""`
- `person.IntroductionDay` = `0`
- `snapshot.Biography` = `current.Biography`
- `snapshot.CameoId` = `current.CameoId`

<a id="symbol-b7b57c1ed1c6"></a>

## `NationalSpire.CameoContent.ApplyRecord(NationalSpire.CareerPerson) — private static void ApplyRecord(CareerPerson person)`

来源：源码第 111 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CameoContent.UpgradeRecords(NationalSpire.CareerData)`](CameoContent.cs.md#symbol-f8a845ee5b69)

**调用：** `System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.CameoId`；`NationalSpire.CareerPerson.RecordedStreakAscension`；`NationalSpire.CareerPerson.RecordedWinStreak`；`NationalSpire.CareerPerson.Wins`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Max(int, int)`；输入表达式：`Math.Max(person.RecordedWinStreak, streak)`；返回值紧邻使用处：`AssignmentExpressionSyntax: person.RecordedWinStreak = Math.Max(person.RecordedWinStreak, streak)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(person.Wins, streak)`；返回值紧邻使用处：`AssignmentExpressionSyntax: person.Wins = Math.Max(person.Wins, streak)`

**赋值（含属性/字段和局部值）：**

- `person.RecordedStreakAscension` = `person.CameoId == "baiqu" ? 1 : -1`
- `person.RecordedWinStreak` = `Math.Max(person.RecordedWinStreak, streak)`
- `person.Wins` = `Math.Max(person.Wins, streak)`

<a id="symbol-6770922220c7"></a>

## `NationalSpire.CameoContent.CloseEdition(NationalSpire.CareerData, NationalSpire.WeeklyEdition) — public static void CloseEdition(CareerData data, WeeklyEdition issue)`

来源：源码第 120 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.WeeklyJournal.CloseWeek(NationalSpire.CareerData)`](WeeklyJournal.cs.md#symbol-fe6dece0c758)

**调用：** [`NationalSpire.CameoContent.Append(NationalSpire.CareerData, NationalSpire.WeeklyEdition, NationalSpire.CameoContent.Story)`](CameoContent.cs.md#symbol-1ac92e8b4ce5)；[`NationalSpire.CircuitLedger.Remember(NationalSpire.CareerData, string, string, System.Collections.Generic.List<string>)`](CircuitLedger.cs.md#symbol-0791637c974d)；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CameoContent.Append(NationalSpire.CareerData, NationalSpire.WeeklyEdition, NationalSpire.CameoContent.Story)`；`NationalSpire.CameoContent.Stories`；`NationalSpire.CameoContent.Story.Body`；`NationalSpire.CameoContent.Story.Edition`；`NationalSpire.CameoContent.Story.Key`；`NationalSpire.CameoState.Editions`；`NationalSpire.CameoState.LastEndDay`；`NationalSpire.CameoState.Version`；`NationalSpire.CareerData.Cameos`；`NationalSpire.CircuitLedger.Remember(NationalSpire.CareerData, string, string, System.Collections.Generic.List<string>)`；`NationalSpire.WeeklyEdition.EndDay`；`NationalSpire.WeeklyEdition.Slides`；`NationalSpire.WeeklySlide.CameoStoryId`；`NationalSpire.WeeklySlide.People`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CameoContent.Append(NationalSpire.CareerData, NationalSpire.WeeklyEdition, NationalSpire.CameoContent.Story)`；输入表达式：`Append(data, issue, story)`；返回值紧邻使用处：`ExpressionStatementSyntax: Append(data, issue, story);`
- `NationalSpire.CircuitLedger.Remember(NationalSpire.CareerData, string, string, System.Collections.Generic.List<string>)`；输入表达式：`CircuitLedger.Remember(data, story.Key, story.Body, issue.Slides.Single(s => s.CameoStoryId == story.Key).People)`；返回值紧邻使用处：`ExpressionStatementSyntax: CircuitLedger.Remember(data, story.Key, story.Body, issue.Slides.Single(s => s.CameoStoryId == story.Key).People);`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`issue.Slides.Single(s => s.CameoStoryId == story.Key)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: issue.Slides.Single(s => s.CameoStoryId == story.Key).People`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Stories.Where(s => s.Edition == data.Cameos.Editions)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var story in Stories.Where(s => s.Edition == data.Cameos.Editions))         {             Append(data, issue, story);             CircuitLedger.Remember(data, story.Key, story.Body, issue.Slides.Single(s => s.CameoStoryId == story.Key).People);         }`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(4, data.Cameos.Editions + 1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: data.Cameos.Editions = Math.Min(4, data.Cameos.Editions + 1)`

**赋值（含属性/字段和局部值）：**

- `data.Cameos.Editions` = `Math.Min(4, data.Cameos.Editions + 1)`
- `data.Cameos.LastEndDay` = `issue.EndDay`

<a id="symbol-82d9b3373a64"></a>

## `NationalSpire.CameoContent.AppendPreview(NationalSpire.CareerData) — public static void AppendPreview(CareerData data)`

来源：源码第 132 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CameoContent.Append(NationalSpire.CareerData, NationalSpire.WeeklyEdition, NationalSpire.CameoContent.Story)`](CameoContent.cs.md#symbol-1ac92e8b4ce5)；[`NationalSpire.CameoContent.Ensure(NationalSpire.CareerData)`](CameoContent.cs.md#symbol-be5fe8cf27bd)；`System.Collections.Generic.IEnumerable<TSource>.MaxBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.InvalidOperationException.InvalidOperationException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CameoContent.Append(NationalSpire.CareerData, NationalSpire.WeeklyEdition, NationalSpire.CameoContent.Story)`；`NationalSpire.CameoContent.Ensure(NationalSpire.CareerData)`；`NationalSpire.CameoContent.Stories`；`NationalSpire.CareerData.WeeklyEditions`；`NationalSpire.WeeklyEdition.EndDay`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CameoContent.Append(NationalSpire.CareerData, NationalSpire.WeeklyEdition, NationalSpire.CameoContent.Story)`；输入表达式：`Append(data, issue, story)`；返回值紧邻使用处：`ExpressionStatementSyntax: Append(data, issue, story);`
- `NationalSpire.CameoContent.Ensure(NationalSpire.CareerData)`；输入表达式：`Ensure(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: Ensure(data);`
- `System.Collections.Generic.IEnumerable<TSource>.MaxBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.WeeklyEditions.MaxBy(w => w.EndDay)`；返回值紧邻使用处：`BinaryExpressionSyntax: data.WeeklyEditions.MaxBy(w => w.EndDay) ?? throw new InvalidOperationException("当前生涯尚无周刊。")`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("当前生涯尚无周刊。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidOperationException("当前生涯尚无周刊。")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1ac92e8b4ce5"></a>

## `NationalSpire.CameoContent.Append(NationalSpire.CareerData, NationalSpire.WeeklyEdition, NationalSpire.CameoContent.Story) — private static void Append(CareerData data, WeeklyEdition issue, Story story)`

来源：源码第 139 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CameoContent.AppendPreview(NationalSpire.CareerData)`](CameoContent.cs.md#symbol-82d9b3373a64)；[`NationalSpire.CameoContent.CloseEdition(NationalSpire.CareerData, NationalSpire.WeeklyEdition)`](CameoContent.cs.md#symbol-6770922220c7)

**调用：** `NationalSpire.WeeklySlide.WeeklySlide()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CameoContent.Story.Body`；`NationalSpire.CameoContent.Story.Key`；`NationalSpire.CameoContent.Story.Title`；`NationalSpire.CareerData.People`；`NationalSpire.CareerPerson.CameoId`；`NationalSpire.CareerPerson.Id`；`NationalSpire.WeeklyEdition.Revision`；`NationalSpire.WeeklyEdition.Slides`；`NationalSpire.WeeklySlide.Body`；`NationalSpire.WeeklySlide.CameoStoryId`；`NationalSpire.WeeklySlide.Character`；`NationalSpire.WeeklySlide.Facts`；`NationalSpire.WeeklySlide.Id`；`NationalSpire.WeeklySlide.Importance`；`NationalSpire.WeeklySlide.People`；`NationalSpire.WeeklySlide.Title`；`NationalSpire.WeeklySlide.Topic`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.WeeklySlide.WeeklySlide()`；输入表达式：`new() { Id = story.Key, CameoStoryId = story.Key, Topic = "选手动态", Title = story.Title, Body = story.Body,             Facts = story.Body, Character = "静默猎手", Importance = 3,             People = data.People.Where(p => p.CameoId is "baiqu" or "xiaofu").Select(p => p.Id).ToList() }`；返回值紧邻使用处：`ArgumentSyntax: new() { Id = story.Key, CameoStoryId = story.Key, Topic = "选手动态", Title = story.Title, Body = story.Body,             Facts = story.Body, Character = "静默猎手", Importance = 3,             People = data.People.Where(p => p.CameoId is "baiqu" or "xiaofu").Select(p => p.Id).ToList() }`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`issue.Slides.Any(s => s.CameoStoryId == story.Key)`；返回值紧邻使用处：`IfStatementSyntax: if (issue.Slides.Any(s => s.CameoStoryId == story.Key)) return;`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`data.People.Where(p => p.CameoId is "baiqu" or "xiaofu").Select(p => p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.People.Where(p => p.CameoId is "baiqu" or "xiaofu").Select(p => p.Id).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`data.People.Where(p => p.CameoId is "baiqu" or "xiaofu").Select(p => p.Id).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: People = data.People.Where(p => p.CameoId is "baiqu" or "xiaofu").Select(p => p.Id).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.People.Where(p => p.CameoId is "baiqu" or "xiaofu")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.People.Where(p => p.CameoId is "baiqu" or "xiaofu").Select`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`issue.Slides.Add(new() { Id = story.Key, CameoStoryId = story.Key, Topic = "选手动态", Title = story.Title, Body = story.Body,             Facts = story.Body, Character = "静默猎手", Importance = 3,             People = data.People.Where(p => p.CameoId is "baiqu" or "xiaofu").Select(p => p.Id).ToList() })`；返回值紧邻使用处：`ExpressionStatementSyntax: issue.Slides.Add(new() { Id = story.Key, CameoStoryId = story.Key, Topic = "选手动态", Title = story.Title, Body = story.Body,             Facts = story.Body, Character = "静默猎手", Importance = 3,             People = data.People.Where(p => p.CameoId is "baiqu" or "xiaofu").Select(p => p.Id).ToList() });`

**赋值（含属性/字段和局部值）：**

- `Body` = `story.Body`
- `CameoStoryId` = `story.Key`
- `Character` = `"静默猎手"`
- `Facts` = `story.Body`
- `Id` = `story.Key`
- `Importance` = `3`
- `People` = `data.People.Where(p => p.CameoId is "baiqu" or "xiaofu").Select(p => p.Id).ToList()`
- `Title` = `story.Title`
- `Topic` = `"选手动态"`
