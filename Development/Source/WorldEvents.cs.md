# WorldEvents.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`023E47D2B2B108130D9D6F961425815545BE655E214780A1A530AA071BF495B5`。来源：[源码](../../WorldEvents.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.WorldEvents`、`NationalSpire.WorldEvents.Topic`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly Topic[] Topics = [
        new("观众", "{人}遇到远道而来的观众", "{人}在{队}的观众活动中见到了专程赶来的支持者，现场留下了一张合照。"),
        new("观众", "{队}征集新赛季应援图", "{队}向观众征集应援设计，{人}挑选了几份自己喜欢的作品。征集仍在进行。"),
        new("观众", "一张旧门票又被翻了出来", "观众在{队}的交流活动中带来一张早期赛事门票，{人}聊起了那个时期的参赛经历。"),
        new("生活", "{人}分享了一份客场歌单", "{人}在社区分享了出行时常听的音乐，留言里有人推荐了同一支乐队。"),
        new("生活", "{人}晒出新做的杯子", "{人}在休息日体验陶艺，做出的杯口有些歪，仍决定留在训练桌上使用。"),
        new("生活", "{人}的相册里多了几张街景", "{人}整理近期出行拍下的街景，观众在照片里认出了熟悉的街角。"),
        new("生活", "{人}尝试了一道当地菜", "{人}参加了一次地方料理体验，把手写食谱带回了住处。"),
        new("生活", "{人}分享了书架的一角", "{人}贴出最近阅读的书，社区话题从比赛转到了各自喜欢的故事。"),
        new("生活", "{人}给训练桌换了布置", "{人}整理桌面，把观众赠送的纪念品放在了显示器旁边。"),
        new("生活", "{人}在休息日去了小剧场", "{人}分享了当地剧团的节目单，有观众发现彼此看过同一场演出。"),
        new("生活", "{人}加入了一场桌游聚会", "{人}和几位圈内朋友在休息时玩了桌游，合照里还留着没有收好的棋子。"),
        new("生活", "{人}晒出了自己的绿植", "{人}在社区分享桌边绿植的近照，几个观众认真讨论起了浇水频率。"),
        new("创作", "社区画师给{人}画了新头像", "一位社区创作者根据{人}的公开形象画了一张头像，{人}署名转发并表达感谢。"),
        new("创作", "{队}公开一组幕后照片", "{队}发布了一组准备比赛的幕后照片，{人}出现在其中一张合照里。"),
        new("创作", "{人}参与录制观众问答", "{人}回答了关于客场生活和兴趣的问题，这期内容已经在社区公开。"),
        new("创作", "{队}的应援短片上线", "社区创作者完成了{队}的应援短片，使用的赛事镜头注明了来源，{人}转发了作品。"),
        new("创作", "{人}收到一份手工纪念品", "观众送来一件手工制作的参赛纪念品，{人}把它放进了个人收藏。"),
        new("创作", "{队}征集队史旧照片", "{队}开始整理旧照片和物件，{人}也找出了一份早期活动资料。"),
        new("公益", "{人}参加社区义卖", "{人}为当地义卖提供了签名纪念品，主办方在活动结束后公布了收支。"),
        new("公益", "{队}开放外设借用登记", "{队}整理出一批可用的备用外设，开放给本地社区活动登记借用。{人}参加了设备整理。"),
        new("公益", "{人}参加校园兴趣交流", "{人}到当地兴趣社团介绍参赛生活，学生们准备了不少关于比赛的问题。"),
        new("社区", "{人}出现在地方观赛聚会", "{人}参加了当地社区组织的观赛聚会，现场有人第一次认识这位选手。"),
        new("社区", "{队}举办观众解说体验", "{队}邀请观众尝试解说一场社区比赛，{人}在现场参与交流。"),
        new("社区", "{人}整理了一份新人参赛清单", "{人}根据自己的经历整理了报名和出行准备事项，方便社区新人参考。"),
        new("社区", "{队}邀请观众参观队史角", "{队}开放队史展示区，{人}向观众介绍了几件已经留存的老物件。"),
        new("设备", "{人}找回了落下的外设包", "{人}在活动结束后发现外设包落在会场，工作人员确认失主后将它送还。"),
        new("设备", "{队}清理出一批老外设", "{队}整理备用设备，{人}认出了自己早期用过的同款鼠标。"),
        new("设备", "{人}体验了社区制作的桌垫", "社区创作者把设计做成了桌垫，{人}收到样品并分享了使用照片。"),
        new("往事", "{人}认出了多年前的合照", "社区有人分享早期活动合照，{人}认出了照片中的自己，并补充了当时的经历。"),
        new("往事", "{人}收到一封老观众来信", "一位长期观众回顾了关注{人}的经过，{人}回复感谢，并提起了双方曾见面的活动。"),
        new("往事", "{队}的旧队服重新展出", "{队}在队史角展出旧款队服，{人}和观众聊起了当年的设计。"),
        new("兴趣", "{人}参加了一次城市骑行", "{人}在休息时间参加短途骑行，回来后分享了路线与沿途照片。"),
        new("兴趣", "{人}推荐了一家旧书店", "{人}分享休息日逛旧书店的见闻，留言里出现了几位同好。"),
        new("兴趣", "{人}带回一张地方唱片", "{人}在出行期间买了一张本地乐队的唱片，准备带回去慢慢听。"),
        new("兴趣", "{人}体验了一次胶片摄影", "{人}把洗出的照片发到社区，几张失焦的画面也一起保留下来。"),
        new("兴趣", "{人}参加星空观测", "{人}在休息日参加天文馆活动，带回来一张当晚的星图。")
    ];
```

<a id="symbol-6471e41e5007"></a>

## `NationalSpire.WorldEvents.Advance(NationalSpire.CareerData) — public static void Advance(CareerData d)`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.SimulateWorld(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-f80c37dd1019)

**调用：** [`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`](CareerEngine.cs.md#symbol-cd8fd2c800e7)；[`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`](CareerLife.cs.md#symbol-0ea81cb3e558)；[`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`](EsportsWorld.cs.md#symbol-c10dfd5a2e0e)；[`NationalSpire.MarketDynamics.NewsCandidates(NationalSpire.CareerData)`](MarketDynamics.cs.md#symbol-bbda4544b2ee)；[`NationalSpire.MarketDynamics.TryPublish(NationalSpire.CareerData)`](MarketDynamics.cs.md#symbol-9d095f6ad885)；[`NationalSpire.NationalDevelopment.NewsCandidates(NationalSpire.CareerData)`](NationalDevelopment.cs.md#symbol-e576507dcbf6)；[`NationalSpire.NationalDevelopment.TryPublish(NationalSpire.CareerData, System.Random)`](NationalDevelopment.cs.md#symbol-620f6dd04f3a)；[`NationalSpire.WorldEvents.SelectTopic(System.Collections.Generic.IReadOnlyList<string>, System.Random)`](WorldEvents.cs.md#symbol-d4649cc9a093)；[`Render(string)`](WorldEvents.cs.md#symbol-c911d92aabe6)；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Random.Next(int, int)`；`System.Random.Next(int)`；`System.Random.Random(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.Posts`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；`NationalSpire.CareerLifeState.LastTopics`；`NationalSpire.CareerLifeState.NextWorldEventDay`；`NationalSpire.CareerLifeState.Version`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CommunityPost.EventKey`；`NationalSpire.CommunityPost.NewsTopic`；`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；`NationalSpire.MarketDynamics.NewsCandidates(NationalSpire.CareerData)`；`NationalSpire.MarketDynamics.TryPublish(NationalSpire.CareerData)`；`NationalSpire.NationalDevelopment.NewsCandidates(NationalSpire.CareerData)`；`NationalSpire.NationalDevelopment.TryPublish(NationalSpire.CareerData, System.Random)`；`NationalSpire.WorldEvents.SelectTopic(System.Collections.Generic.IReadOnlyList<string>, System.Random)`；`NationalSpire.WorldEvents.Topic.Detail`；`NationalSpire.WorldEvents.Topic.Key`；`NationalSpire.WorldEvents.Topic.Title`；`NationalSpire.WorldEvents.Topics`；`Render(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；输入表达式：`CareerEngine.Publish(d, "world-life-" + d.Day, title, detail, "人物日常", true, [person.Id])`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.Publish(d, "world-life-" + d.Day, title, detail, "人物日常", true, [person.Id]);`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(d.WorldId + ":events:" + d.Day)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.StableHash(d.WorldId + ":events:" + d.Day)`
- `NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；输入表达式：`CareerLife.AddEvent(d, "world-life-" + d.Day, topic.Key, title, detail, [person.Id])`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerLife.AddEvent(d, "world-life-" + d.Day, topic.Key, title, detail, [person.Id]);`
- `NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；输入表达式：`EsportsWorld.IsProfessional(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.ClubId.Length > 0 && EsportsWorld.IsProfessional(p)`
- `NationalSpire.MarketDynamics.NewsCandidates(NationalSpire.CareerData)`；输入表达式：`MarketDynamics.NewsCandidates(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: MarketDynamics.NewsCandidates(d).Length`
- `NationalSpire.MarketDynamics.TryPublish(NationalSpire.CareerData)`；输入表达式：`MarketDynamics.TryPublish(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: MarketDynamics.TryPublish(d);`
- `NationalSpire.NationalDevelopment.NewsCandidates(NationalSpire.CareerData)`；输入表达式：`NationalDevelopment.NewsCandidates(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: NationalDevelopment.NewsCandidates(d).Length`
- `NationalSpire.NationalDevelopment.TryPublish(NationalSpire.CareerData, System.Random)`；输入表达式：`NationalDevelopment.TryPublish(d, rng)`；返回值紧邻使用处：`ExpressionStatementSyntax: NationalDevelopment.TryPublish(d, rng);`
- `NationalSpire.WorldEvents.SelectTopic(System.Collections.Generic.IReadOnlyList<string>, System.Random)`；输入表达式：`SelectTopic(subjects, rng)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SelectTopic(subjects, rng)`
- `Render(string)`；输入表达式：`Render(topic.Detail)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Render(topic.Detail)`
- `Render(string)`；输入表达式：`Render(topic.Title)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Render(topic.Title)`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`candidates.Select(t => t.Key).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates.Select(t => t.Key).Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Posts.FirstOrDefault(p => p.EventKey == "world-life-" + d.Day)`；返回值紧邻使用处：`IsPatternExpressionSyntax: d.Posts.FirstOrDefault(p => p.EventKey == "world-life-" + d.Day) is { } post`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`candidates.Select(t => t.Key)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates.Select(t => t.Key).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`candidates.Where(t => t.Key == subject).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = candidates.Where(t => t.Key == subject).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`candidates.Select(t => t.Key).Distinct().ToList()`；返回值紧邻使用处：`ConditionalExpressionSyntax: people.Count > 0 ? candidates.Select(t => t.Key).Distinct().ToList() : []`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.People.Where(p => p.ClubId.Length > 0 && EsportsWorld.IsProfessional(p)              && d.Day - d.Life.LastTopics.GetValueOrDefault("person:" + p.Id, -100) >= 42).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.People.Where(p => p.ClubId.Length > 0 && EsportsWorld.IsProfessional(p)              && d.Day - d.Life.LastTopics.GetValueOrDefault("person:" + p.Id, -100) >= 42).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`Topics.Where(t => d.Day - d.Life.LastTopics.GetValueOrDefault("world:" + t.Key, -100) >= 14).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Topics.Where(t => d.Day - d.Life.LastTopics.GetValueOrDefault("world:" + t.Key, -100) >= 14).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`candidates.Where(t => t.Key == subject)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates.Where(t => t.Key == subject).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p => p.ClubId.Length > 0 && EsportsWorld.IsProfessional(p)              && d.Day - d.Life.LastTopics.GetValueOrDefault("person:" + p.Id, -100) >= 42)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.ClubId.Length > 0 && EsportsWorld.IsProfessional(p)              && d.Day - d.Life.LastTopics.GetValueOrDefault("person:" + p.Id, -100) >= 42).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Topics.Where(t => d.Day - d.Life.LastTopics.GetValueOrDefault("world:" + t.Key, -100) >= 14)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Topics.Where(t => d.Day - d.Life.LastTopics.GetValueOrDefault("world:" + t.Key, -100) >= 14).ToList`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`d.Life.LastTopics.GetValueOrDefault("person:" + p.Id, -100)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Day - d.Life.LastTopics.GetValueOrDefault("person:" + p.Id, -100)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`d.Life.LastTopics.GetValueOrDefault("world:" + t.Key, -100)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Day - d.Life.LastTopics.GetValueOrDefault("world:" + t.Key, -100)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`subjects.Add("国运发展")`；返回值紧邻使用处：`ExpressionStatementSyntax: subjects.Add("国运发展");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`subjects.Add("市场动态")`；返回值紧邻使用处：`ExpressionStatementSyntax: subjects.Add("市场动态");`
- `System.Random.Next(int, int)`；输入表达式：`rng.Next(3, 7)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Day + rng.Next(3, 7)`
- `System.Random.Next(int)`；输入表达式：`rng.Next(people.Count)`；返回值紧邻使用处：`ArgumentSyntax: rng.Next(people.Count)`
- `System.Random.Next(int)`；输入表达式：`rng.Next(templates.Length)`；返回值紧邻使用处：`ArgumentSyntax: rng.Next(templates.Length)`
- `System.Random.Random(int)`；输入表达式：`new Random(seed)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Random(seed)`

**赋值（含属性/字段和局部值）：**

- `d.Life.LastTopics["person:" + person.Id]` = `d.Day`
- `d.Life.LastTopics["world:" + topic.Key]` = `d.Day`
- `d.Life.NextWorldEventDay` = `d.Day + rng.Next(3, 7)`
- `post.NewsTopic` = `topic.Key`

<a id="symbol-c911d92aabe6"></a>

## `Render(string) — string Render(string s)`

来源：源码第 63 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.WorldEvents.Advance(NationalSpire.CareerData)`](WorldEvents.cs.md#symbol-6471e41e5007)

**调用：** [`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；`string.Replace(string, string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(d, person.ClubId)`；返回值紧邻使用处：`ArgumentSyntax: EsportsWorld.ClubName(d, person.ClubId)`
- `string.Replace(string, string?)`；输入表达式：`s.Replace("{人}", person.PublicName).Replace("{队}", EsportsWorld.ClubName(d, person.ClubId))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => s.Replace("{人}", person.PublicName).Replace("{队}", EsportsWorld.ClubName(d, person.ClubId))`
- `string.Replace(string, string?)`；输入表达式：`s.Replace("{人}", person.PublicName)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: s.Replace("{人}", person.PublicName).Replace`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d4649cc9a093"></a>

## `NationalSpire.WorldEvents.SelectTopic(System.Collections.Generic.IReadOnlyList<string>, System.Random) — public static string SelectTopic(IReadOnlyList<string> subjects, Random random)`

来源：源码第 70 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.WorldEvents.Advance(NationalSpire.CareerData)`](WorldEvents.cs.md#symbol-6471e41e5007)

**调用：** [`Weight(string)`](WorldEvents.cs.md#symbol-a54948f39bb4)；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, double>)`；`System.Random.NextDouble()`

**字段、属性、事件及方法组引用：** `Weight(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, double>)`；输入表达式：`subjects.Sum(Weight)`；返回值紧邻使用处：`BinaryExpressionSyntax: random.NextDouble() * subjects.Sum(Weight)`
- `System.Random.NextDouble()`；输入表达式：`random.NextDouble()`；返回值紧邻使用处：`BinaryExpressionSyntax: random.NextDouble() * subjects.Sum(Weight)`
- `Weight(string)`；输入表达式：`Weight(subject)`；返回值紧邻使用处：`AssignmentExpressionSyntax: choice -= Weight(subject)`

**赋值（含属性/字段和局部值）：**

- `choice` -= `Weight(subject)`

<a id="symbol-a54948f39bb4"></a>

## `Weight(string) — static double Weight(string subject)`

来源：源码第 72 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.WorldEvents.SelectTopic(System.Collections.Generic.IReadOnlyList<string>, System.Random)`](WorldEvents.cs.md#symbol-d4649cc9a093)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-04c812704f65"></a>

## `NationalSpire.WorldEvents.FixtureFacts(NationalSpire.CareerData, NationalSpire.WorldCompetition, System.Collections.Generic.IEnumerable<NationalSpire.WorldFixture>) — public static string FixtureFacts(CareerData d, WorldCompetition c, IEnumerable<WorldFixture> fixtures)`

来源：源码第 79 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool, bool)`](CareerEngine.cs.md#symbol-bdca24d9114c)；[`NationalSpire.MarketDynamics.TryPublish(NationalSpire.CareerData)`](MarketDynamics.cs.md#symbol-9d095f6ad885)；[`NationalSpire.NationalDevelopment.TryPublish(NationalSpire.CareerData, System.Random)`](NationalDevelopment.cs.md#symbol-620f6dd04f3a)

**调用：** [`NationalSpire.CircuitWorld.TeamName(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`](CircuitWorld.cs.md#symbol-74904a83d22a)；[`NationalSpire.MatchRules.Performance(bool, int, double?)`](MatchRules.cs.md#symbol-b38635e79223)；[`NationalSpire.SeasonCeremony.Participants(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, bool)`](SeasonCeremony.cs.md#symbol-c038c48114b1)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `(int Day, int Round, string Home, string Away).Away`；`(int Day, int Round, string Home, string Away).Day`；`(int Day, int Round, string Home, string Away).Home`；`(int Day, int Round, string Home, string Away).Round`；`name(string)`；`NationalSpire.CircuitWorld.TeamName(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`；`NationalSpire.MatchRules.Performance(bool, int, double?)`；`NationalSpire.SeasonCeremony.Participants(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, bool)`；`NationalSpire.WorldCompetition.Name`；`NationalSpire.WorldCompetition.TeamEvent`；`NationalSpire.WorldFixture.AwayCleared`；`NationalSpire.WorldFixture.AwayFloor`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.AwaySeconds`；`NationalSpire.WorldFixture.AwayTeam`；`NationalSpire.WorldFixture.Day`；`NationalSpire.WorldFixture.Draw`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeCleared`；`NationalSpire.WorldFixture.HomeFloor`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.HomeSeconds`；`NationalSpire.WorldFixture.HomeTeam`；`NationalSpire.WorldFixture.Round`；`NationalSpire.WorldFixture.WinnerId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CircuitWorld.TeamName(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`；输入表达式：`CircuitWorld.TeamName(d, c, g.Key.Away)`；返回值紧邻使用处：`InterpolationSyntax: {CircuitWorld.TeamName(d, c, g.Key.Away)}`
- `NationalSpire.CircuitWorld.TeamName(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`；输入表达式：`CircuitWorld.TeamName(d, c, g.Key.Home)`；返回值紧邻使用处：`InterpolationSyntax: {CircuitWorld.TeamName(d, c, g.Key.Home)}`
- `NationalSpire.MatchRules.Performance(bool, int, double?)`；输入表达式：`MatchRules.Performance(f.AwayCleared, f.AwayFloor, f.AwaySeconds)`；返回值紧邻使用处：`InterpolationSyntax: {MatchRules.Performance(f.AwayCleared, f.AwayFloor, f.AwaySeconds)}`
- `NationalSpire.MatchRules.Performance(bool, int, double?)`；输入表达式：`MatchRules.Performance(f.HomeCleared, f.HomeFloor, f.HomeSeconds)`；返回值紧邻使用处：`InterpolationSyntax: {MatchRules.Performance(f.HomeCleared, f.HomeFloor, f.HomeSeconds)}`
- `NationalSpire.SeasonCeremony.Participants(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, bool)`；输入表达式：`SeasonCeremony.Participants(d, c, f, false)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: SeasonCeremony.Participants(d, c, f, false).Select`
- `NationalSpire.SeasonCeremony.Participants(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, bool)`；输入表达式：`SeasonCeremony.Participants(d, c, f, true)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: SeasonCeremony.Participants(d, c, f, true).Select`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", SeasonCeremony.Participants(d, c, f, false).Select(name))`；返回值紧邻使用处：`BinaryExpressionSyntax: string.Join("、", SeasonCeremony.Participants(d, c, f, true).Select(name))                  + (f.Draw ? "战平" : f.WinnerId == f.HomeId ? "战胜" : "负于") + string.Join("、", SeasonCeremony.Participants(d, c, f, false).Select(name))`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", SeasonCeremony.Participants(d, c, f, true).Select(name))`；返回值紧邻使用处：`BinaryExpressionSyntax: string.Join("、", SeasonCeremony.Participants(d, c, f, true).Select(name))                  + (f.Draw ? "战平" : f.WinnerId == f.HomeId ? "战胜" : "负于")`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("；", g.Select(f => string.Join("、", SeasonCeremony.Participants(d, c, f, true).Select(name))                  + (f.Draw ? "战平" : f.WinnerId == f.HomeId ? "战胜" : "负于") + string.Join("、", SeasonCeremony.Participants(d, c, f, false).Select(name))                  + $"（双方成绩：{MatchRules.Performance(f.HomeCleared, f.HomeFloor, f.HomeSeconds)}；{MatchRules.Performance(f.AwayCleared, f.AwayFloor, f.AwaySeconds)}）"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = string.Join("；", g.Select(f => string.Join("、", SeasonCeremony.Participants(d, c, f, true).Select(name))                  + (f.Draw ? "战平" : f.WinnerId == f.HomeId ? "战胜" : "负于") + string.Join("、", SeasonCeremony.Participants(d, c, f, false).Select(name))                  + $"（双方成绩：{MatchRules.Performance(f.HomeCleared, f.HomeFloor, f.HomeSeconds)}；{MatchRules.Performance(f.AwayCleared, f.AwayFloor, f.AwaySeconds)}）"))`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", fixtures.Where(f => f.Finished).GroupBy(f => (f.Day, f.Round, Home: c.TeamEvent ? f.HomeTeam : f.HomeId, Away: c.TeamEvent ? f.AwayTeam : f.AwayId)).Select(g =>          {              string name(string id) => CareerEngine.DisplayName(d, id);              string seats = string.Join("；", g.Select(f => string.Join("、", SeasonCeremony.Participants(d, c, f, true).Select(name))                  + (f.Draw ? "战平" : f.WinnerId == f.HomeId ? "战胜" : "负于") + string.Join("、", SeasonCeremony.Participants(d, c, f, false).Select(name))                  + $"（双方成绩：{MatchRules.Performance(f.HomeCleared, f.HomeFloor, f.HomeSeconds)}；{MatchRules.Performance(f.AwayCleared, f.AwayFloor, f.AwaySeconds)}）"));              string teams = c.TeamEvent ? $"{CircuitWorld.TeamName(d, c, g.Key.Home)}对阵{CircuitWorld.TeamName(d, c, g.Key.Away)}，已完成比分{g.Count(f => f.WinnerId == f.HomeId)}:{g.Count(f => f.WinnerId == f.AwayId)}。" : "";              return $"第{g.Key.Day}天，{c.Name}第{g.Key.Round}轮：{teams}{seats}。";          }))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => string.Join("\n", fixtures.Where(f => f.Finished).GroupBy(f => (f.Day, f.Round, Home: c.TeamEvent ? f.HomeTeam : f.HomeId, Away: c.TeamEvent ? f.AwayTeam : f.AwayId)).Select(g =>          {              string name(string id) => CareerEngine.DisplayName(d, id);              string seats = string.Join("；", g.Select(f => string.Join("、", SeasonCeremony.Participants(d, c, f, true).Select(name))                  + (f.Draw ? "战平" : f.WinnerId == f.HomeId ? "战胜" : "负于") + string.Join("、", SeasonCeremony.Participants(d, c, f, false).Select(name))                  + $"（双方成绩：{MatchRules.Performance(f.HomeCleared, f.HomeFloor, f.HomeSeconds)}；{MatchRules.Performance(f.AwayCleared, f.AwayFloor, f.AwaySeconds)}）"));              string teams = c.TeamEvent ? $"{CircuitWorld.TeamName(d, c, g.Key.Home)}对阵{CircuitWorld.TeamName(d, c, g.Key.Away)}，已完成比分{g.Count(f => f.WinnerId == f.HomeId)}:{g.Count(f => f.WinnerId == f.AwayId)}。" : "";              return $"第{g.Key.Day}天，{c.Name}第{g.Key.Round}轮：{teams}{seats}。";          }))`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Count(f => f.WinnerId == f.AwayId)`；返回值紧邻使用处：`InterpolationSyntax: {g.Count(f => f.WinnerId == f.AwayId)}`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Count(f => f.WinnerId == f.HomeId)`；返回值紧邻使用处：`InterpolationSyntax: {g.Count(f => f.WinnerId == f.HomeId)}`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`fixtures.Where(f => f.Finished).GroupBy(f => (f.Day, f.Round, Home: c.TeamEvent ? f.HomeTeam : f.HomeId, Away: c.TeamEvent ? f.AwayTeam : f.AwayId))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: fixtures.Where(f => f.Finished).GroupBy(f => (f.Day, f.Round, Home: c.TeamEvent ? f.HomeTeam : f.HomeId, Away: c.TeamEvent ? f.AwayTeam : f.AwayId)).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`fixtures.Where(f => f.Finished).GroupBy(f => (f.Day, f.Round, Home: c.TeamEvent ? f.HomeTeam : f.HomeId, Away: c.TeamEvent ? f.AwayTeam : f.AwayId)).Select(g =>          {              string name(string id) => CareerEngine.DisplayName(d, id);              string seats = string.Join("；", g.Select(f => string.Join("、", SeasonCeremony.Participants(d, c, f, true).Select(name))                  + (f.Draw ? "战平" : f.WinnerId == f.HomeId ? "战胜" : "负于") + string.Join("、", SeasonCeremony.Participants(d, c, f, false).Select(name))                  + $"（双方成绩：{MatchRules.Performance(f.HomeCleared, f.HomeFloor, f.HomeSeconds)}；{MatchRules.Performance(f.AwayCleared, f.AwayFloor, f.AwaySeconds)}）"));              string teams = c.TeamEvent ? $"{CircuitWorld.TeamName(d, c, g.Key.Home)}对阵{CircuitWorld.TeamName(d, c, g.Key.Away)}，已完成比分{g.Count(f => f.WinnerId == f.HomeId)}:{g.Count(f => f.WinnerId == f.AwayId)}。" : "";              return $"第{g.Key.Day}天，{c.Name}第{g.Key.Round}轮：{teams}{seats}。";          })`；返回值紧邻使用处：`ArgumentSyntax: fixtures.Where(f => f.Finished).GroupBy(f => (f.Day, f.Round, Home: c.TeamEvent ? f.HomeTeam : f.HomeId, Away: c.TeamEvent ? f.AwayTeam : f.AwayId)).Select(g =>          {              string name(string id) => CareerEngine.DisplayName(d, id);              string seats = string.Join("；", g.Select(f => string.Join("、", SeasonCeremony.Participants(d, c, f, true).Select(name))                  + (f.Draw ? "战平" : f.WinnerId == f.HomeId ? "战胜" : "负于") + string.Join("、", SeasonCeremony.Participants(d, c, f, false).Select(name))                  + $"（双方成绩：{MatchRules.Performance(f.HomeCleared, f.HomeFloor, f.HomeSeconds)}；{MatchRules.Performance(f.AwayCleared, f.AwayFloor, f.AwaySeconds)}）"));              string teams = c.TeamEvent ? $"{CircuitWorld.TeamName(d, c, g.Key.Home)}对阵{CircuitWorld.TeamName(d, c, g.Key.Away)}，已完成比分{g.Count(f => f.WinnerId == f.HomeId)}:{g.Count(f => f.WinnerId == f.AwayId)}。" : "";              return $"第{g.Key.Day}天，{c.Name}第{g.Key.Round}轮：{teams}{seats}。";          })`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`g.Select(f => string.Join("、", SeasonCeremony.Participants(d, c, f, true).Select(name))                  + (f.Draw ? "战平" : f.WinnerId == f.HomeId ? "战胜" : "负于") + string.Join("、", SeasonCeremony.Participants(d, c, f, false).Select(name))                  + $"（双方成绩：{MatchRules.Performance(f.HomeCleared, f.HomeFloor, f.HomeSeconds)}；{MatchRules.Performance(f.AwayCleared, f.AwayFloor, f.AwaySeconds)}）")`；返回值紧邻使用处：`ArgumentSyntax: g.Select(f => string.Join("、", SeasonCeremony.Participants(d, c, f, true).Select(name))                  + (f.Draw ? "战平" : f.WinnerId == f.HomeId ? "战胜" : "负于") + string.Join("、", SeasonCeremony.Participants(d, c, f, false).Select(name))                  + $"（双方成绩：{MatchRules.Performance(f.HomeCleared, f.HomeFloor, f.HomeSeconds)}；{MatchRules.Performance(f.AwayCleared, f.AwayFloor, f.AwaySeconds)}）")`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`SeasonCeremony.Participants(d, c, f, false).Select(name)`；返回值紧邻使用处：`ArgumentSyntax: SeasonCeremony.Participants(d, c, f, false).Select(name)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`SeasonCeremony.Participants(d, c, f, true).Select(name)`；返回值紧邻使用处：`ArgumentSyntax: SeasonCeremony.Participants(d, c, f, true).Select(name)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`fixtures.Where(f => f.Finished)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: fixtures.Where(f => f.Finished).GroupBy`

**赋值（含属性/字段和局部值）：**


<a id="symbol-375f35a0be96"></a>

## `name(string) — string name(string id)`

来源：源码第 82 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, id)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => CareerEngine.DisplayName(d, id)`

**赋值（含属性/字段和局部值）：**
