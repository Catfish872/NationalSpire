# PublicSchedule.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`561EAD36E64137F198C732DBD7DBFDF8DD0BD4437FE62005AA0772A728CC733D`。来源：[源码](../../PublicSchedule.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.PublicSchedule`、`NationalSpire.PublicMatch`、`NationalSpire.PublicMeeting`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-6c4cbefc0f4f"></a>

## `NationalSpire.PublicSchedule.AsOfDay — public int AsOfDay`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-10b630d950e8"></a>

## `NationalSpire.PublicSchedule.Upcoming — public List<PublicMatch> Upcoming`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6b3df0ff9384"></a>

## `NationalSpire.PublicSchedule.RecentMeetings — public List<PublicMeeting> RecentMeetings`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-27c215cbf3ea"></a>

## `NationalSpire.PublicSchedule.RelatedFixtures — public List<PublicMatch> RelatedFixtures`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-51c76e2ccd4b"></a>

## `NationalSpire.PublicSchedule.ForPrompt(NationalSpire.CareerData, NationalSpire.PublicSchedule?) — public static object? ForPrompt(CareerData data, PublicSchedule? schedule)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.BuildDiscussionPrompt(NationalSpire.CareerData, System.Collections.Generic.ISet<string>, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiDiscussion.cs.md#symbol-142a77613e08)；[`NationalSpire.AiService.BuildNewsContext(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiContext.cs.md#symbol-7b21630a9e2c)；[`NationalSpire.AiService.BuildWeeklyContext(NationalSpire.CareerData, NationalSpire.WeeklyEdition, bool)`](AiWeekly.cs.md#symbol-d24065dcfca3)

**调用：** [`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`

**字段、属性、事件及方法组引用：** `<anonymous type: int AsOfDay, string 资料日期, System.Collections.Generic.IEnumerable<<anonymous type: int Day, string Event, int Ascension, string 参赛情况>> Upcoming, System.Collections.Generic.IEnumerable<<anonymous type: int Day, string Event, int Ascension, string 比赛记录>> RecentMeetings, System.Collections.Generic.IEnumerable<<anonymous type: int Day, string Event, int Ascension, string 对阵情况>> RelatedFixtures>.资料日期`；`<anonymous type: int AsOfDay, string 资料日期, System.Collections.Generic.IEnumerable<<anonymous type: int Day, string Event, int Ascension, string 参赛情况>> Upcoming, System.Collections.Generic.IEnumerable<<anonymous type: int Day, string Event, int Ascension, string 比赛记录>> RecentMeetings, System.Collections.Generic.IEnumerable<<anonymous type: int Day, string Event, int Ascension, string 对阵情况>> RelatedFixtures>.RecentMeetings`；`<anonymous type: int AsOfDay, string 资料日期, System.Collections.Generic.IEnumerable<<anonymous type: int Day, string Event, int Ascension, string 参赛情况>> Upcoming, System.Collections.Generic.IEnumerable<<anonymous type: int Day, string Event, int Ascension, string 比赛记录>> RecentMeetings, System.Collections.Generic.IEnumerable<<anonymous type: int Day, string Event, int Ascension, string 对阵情况>> RelatedFixtures>.RelatedFixtures`；`<anonymous type: int AsOfDay, string 资料日期, System.Collections.Generic.IEnumerable<<anonymous type: int Day, string Event, int Ascension, string 参赛情况>> Upcoming, System.Collections.Generic.IEnumerable<<anonymous type: int Day, string Event, int Ascension, string 比赛记录>> RecentMeetings, System.Collections.Generic.IEnumerable<<anonymous type: int Day, string Event, int Ascension, string 对阵情况>> RelatedFixtures>.Upcoming`；`<anonymous type: int Day, string Event, int Ascension, string 比赛记录>.比赛记录`；`<anonymous type: int Day, string Event, int Ascension, string 参赛情况>.参赛情况`；`<anonymous type: int Day, string Event, int Ascension, string 对阵情况>.对阵情况`；`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；`NationalSpire.PublicMatch.Ascension`；`NationalSpire.PublicMatch.Away`；`NationalSpire.PublicMatch.Day`；`NationalSpire.PublicMatch.Event`；`NationalSpire.PublicMatch.Home`；`NationalSpire.PublicMatch.Status`；`NationalSpire.PublicMeeting.Ascension`；`NationalSpire.PublicMeeting.Day`；`NationalSpire.PublicMeeting.Event`；`NationalSpire.PublicMeeting.Opponent`；`NationalSpire.PublicMeeting.Outcome`；`NationalSpire.PublicMeeting.Participant`；`NationalSpire.PublicMeeting.Performance`；`NationalSpire.PublicSchedule.AsOfDay`；`NationalSpire.PublicSchedule.RecentMeetings`；`NationalSpire.PublicSchedule.RelatedFixtures`；`NationalSpire.PublicSchedule.Upcoming`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Text(data, schedule.AsOfDay)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: 资料日期 = GameCalendar.Text(data, schedule.AsOfDay)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`schedule.RecentMeetings.Select(m => new { m.Day, m.Event, m.Ascension,              比赛记录 = $"{(m.Participant.Length > 0 ? m.Participant : "玩家")}对阵{m.Opponent}，{(m.Participant.Length > 0 ? m.Participant : "玩家")}的赛果为{m.Outcome}，表现为{m.Performance}。" })`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: RecentMeetings = schedule.RecentMeetings.Select(m => new { m.Day, m.Event, m.Ascension,              比赛记录 = $"{(m.Participant.Length > 0 ? m.Participant : "玩家")}对阵{m.Opponent}，{(m.Participant.Length > 0 ? m.Participant : "玩家")}的赛果为{m.Outcome}，表现为{m.Performance}。" })`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`schedule.RelatedFixtures.Select(m => new { m.Day, m.Event, m.Ascension,              对阵情况 = $"{m.Home}与{m.Away}将在{m.Event}交手，{m.Status}。" })`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: RelatedFixtures = schedule.RelatedFixtures.Select(m => new { m.Day, m.Event, m.Ascension,              对阵情况 = $"{m.Home}与{m.Away}将在{m.Event}交手，{m.Status}。" })`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`schedule.Upcoming.Select(m => new { m.Day, m.Event, m.Ascension,              参赛情况 = m.Status == "可报名，尚未报名"                  ? $"{m.Home}可以报名{m.Event}，目前尚未报名；报名后预定对手为{m.Away}。"                  : $"{m.Home}在{m.Event}的状态为{m.Status}，对手为{m.Away}。" })`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: Upcoming = schedule.Upcoming.Select(m => new { m.Day, m.Event, m.Ascension,              参赛情况 = m.Status == "可报名，尚未报名"                  ? $"{m.Home}可以报名{m.Event}，目前尚未报名；报名后预定对手为{m.Away}。"                  : $"{m.Home}在{m.Event}的状态为{m.Status}，对手为{m.Away}。" })`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0253014360da"></a>

## `NationalSpire.PublicSchedule.Capture(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>) — public static PublicSchedule Capture(CareerData data, IEnumerable<string> related)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.BuildDiscussionPrompt(NationalSpire.CareerData, System.Collections.Generic.ISet<string>, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiDiscussion.cs.md#symbol-142a77613e08)；[`NationalSpire.AiService.BuildNewsContext(NationalSpire.CareerData, System.Collections.Generic.List<NationalSpire.CommunityPost>)`](AiContext.cs.md#symbol-7b21630a9e2c)；[`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`](CareerEngine.cs.md#symbol-cd8fd2c800e7)；[`NationalSpire.WeeklyJournal.CloseWeek(NationalSpire.CareerData)`](WeeklyJournal.cs.md#symbol-fe6dece0c758)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`](EsportsWorld.cs.md#symbol-4b9f3e1bf70a)；[`NationalSpire.MatchRules.Performance(bool, int, double?)`](MatchRules.cs.md#symbol-b38635e79223)；`NationalSpire.PublicMatch.PublicMatch()`；`NationalSpire.PublicMeeting.PublicMeeting()`；`NationalSpire.PublicSchedule.PublicSchedule()`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.IEnumerable.OfType<TResult>()`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerMatch.Event`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.Registered`；`NationalSpire.CareerMatch.RegistrationDeclined`；`NationalSpire.CareerMatch.RequiredAscension`；`NationalSpire.CareerMatch.Status`；`NationalSpire.CareerResult.Ascension`；`NationalSpire.CareerResult.Day`；`NationalSpire.CareerResult.Event`；`NationalSpire.CareerResult.Floor`；`NationalSpire.CareerResult.Kind`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.CareerResult.OfficialAscensionVerified`；`NationalSpire.CareerResult.OpponentId`；`NationalSpire.CareerResult.Outcome`；`NationalSpire.CareerResult.RunSeconds`；`NationalSpire.CareerResult.Win`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.MatchRules.Performance(bool, int, double?)`；`NationalSpire.PublicMatch.Ascension`；`NationalSpire.PublicMatch.Away`；`NationalSpire.PublicMatch.Day`；`NationalSpire.PublicMatch.Event`；`NationalSpire.PublicMatch.Home`；`NationalSpire.PublicMatch.Status`；`NationalSpire.PublicMeeting.Ascension`；`NationalSpire.PublicMeeting.Day`；`NationalSpire.PublicMeeting.Event`；`NationalSpire.PublicMeeting.Opponent`；`NationalSpire.PublicMeeting.Outcome`；`NationalSpire.PublicMeeting.Participant`；`NationalSpire.PublicMeeting.Performance`；`NationalSpire.PublicSchedule.AsOfDay`；`NationalSpire.PublicSchedule.RecentMeetings`；`NationalSpire.PublicSchedule.RelatedFixtures`；`NationalSpire.PublicSchedule.Upcoming`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Name`；`NationalSpire.WorldFixture.Ascension`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.Day`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, f.AwayId)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Away = CareerEngine.DisplayName(data, f.AwayId)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, f.HomeId)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Home = CareerEngine.DisplayName(data, f.HomeId)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, m.OpponentId)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Away = CareerEngine.DisplayName(data, m.OpponentId)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, r.OpponentId)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Opponent = CareerEngine.DisplayName(data, r.OpponentId)`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Home = CareerEngine.Name(data)`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(data)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Participant = CareerEngine.Name(data)`
- `NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`EsportsWorld.EntryReason(data, m)`；返回值紧邻使用处：`BinaryExpressionSyntax: EsportsWorld.EntryReason(data, m) == null`
- `NationalSpire.MatchRules.Performance(bool, int, double?)`；输入表达式：`MatchRules.Performance(r.Win, r.Floor, r.RunSeconds)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Performance = MatchRules.Performance(r.Win, r.Floor, r.RunSeconds)`
- `NationalSpire.PublicMatch.PublicMatch()`；输入表达式：`new PublicMatch                  { Day = f.Day, Event = c.Name, Home = CareerEngine.DisplayName(data, f.HomeId), Away = CareerEngine.DisplayName(data, f.AwayId),                      Ascension = f.Ascension, Status = "对阵已公布" }`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: f => new PublicMatch                  { Day = f.Day, Event = c.Name, Home = CareerEngine.DisplayName(data, f.HomeId), Away = CareerEngine.DisplayName(data, f.AwayId),                      Ascension = f.Ascension, Status = "对阵已公布" }`
- `NationalSpire.PublicMatch.PublicMatch()`；输入表达式：`new PublicMatch { Day = m.Day, Event = m.Event, Ascension = m.RequiredAscension,                  Home = CareerEngine.Name(data), Away = CareerEngine.DisplayName(data, m.OpponentId),                  Status = m.Id == data.PendingMatchId ? "正在比赛" : m.Registered ? "已报名" : "可报名，尚未报名" }`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m => new PublicMatch { Day = m.Day, Event = m.Event, Ascension = m.RequiredAscension,                  Home = CareerEngine.Name(data), Away = CareerEngine.DisplayName(data, m.OpponentId),                  Status = m.Id == data.PendingMatchId ? "正在比赛" : m.Registered ? "已报名" : "可报名，尚未报名" }`
- `NationalSpire.PublicMeeting.PublicMeeting()`；输入表达式：`new PublicMeeting { Day = r.Day, Event = r.Event, Participant = CareerEngine.Name(data),                  Opponent = CareerEngine.DisplayName(data, r.OpponentId), Outcome = r.Outcome, Ascension = r.Ascension,                  Performance = MatchRules.Performance(r.Win, r.Floor, r.RunSeconds) }`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: r => new PublicMeeting { Day = r.Day, Event = r.Event, Participant = CareerEngine.Name(data),                  Opponent = CareerEngine.DisplayName(data, r.OpponentId), Outcome = r.Outcome, Ascension = r.Ascension,                  Performance = MatchRules.Performance(r.Win, r.Floor, r.RunSeconds) }`
- `NationalSpire.PublicSchedule.PublicSchedule()`；输入表达式：`new()          {              AsOfDay = data.Day,              Upcoming = upcoming.Select(m => new PublicMatch { Day = m.Day, Event = m.Event, Ascension = m.RequiredAscension,                  Home = CareerEngine.Name(data), Away = CareerEngine.DisplayName(data, m.OpponentId),                  Status = m.Id == data.PendingMatchId ? "正在比赛" : m.Registered ? "已报名" : "可报名，尚未报名" }).ToList(),              RecentMeetings = meetings.Select(r => new PublicMeeting { Day = r.Day, Event = r.Event, Participant = CareerEngine.Name(data),                  Opponent = CareerEngine.DisplayName(data, r.OpponentId), Outcome = r.Outcome, Ascension = r.Ascension,                  Performance = MatchRules.Performance(r.Win, r.Floor, r.RunSeconds) }).ToList(),              RelatedFixtures = data.Esports.Competitions.SelectMany(c => c.Fixtures.Where(f => !f.Finished && f.Day >= data.Day                  && f.Day <= data.Day + 14 && f.HomeId != "player" && f.AwayId != "player"                  && (subjects.Contains(f.HomeId) || subjects.Contains(f.AwayId))).Select(f => new PublicMatch                  { Day = f.Day, Event = c.Name, Home = CareerEngine.DisplayName(data, f.HomeId), Away = CareerEngine.DisplayName(data, f.AwayId),                      Ascension = f.Ascension, Status = "对阵已公布" })).OrderBy(f => f.Day).Take(2).ToList()          }`；返回值紧邻使用处：`ReturnStatementSyntax: return new()          {              AsOfDay = data.Day,              Upcoming = upcoming.Select(m => new PublicMatch { Day = m.Day, Event = m.Event, Ascension = m.RequiredAscension,                  Home = CareerEngine.Name(data), Away = CareerEngine.DisplayName(data, m.OpponentId),                  Status = m.Id == data.PendingMatchId ? "正在比赛" : m.Registered ? "已报名" : "可报名，尚未报名" }).ToList(),              RecentMeetings = meetings.Select(r => new PublicMeeting { Day = r.Day, Event = r.Event, Participant = CareerEngine.Name(data),                  Opponent = CareerEngine.DisplayName(data, r.OpponentId), Outcome = r.Outcome, Ascension = r.Ascension,                  Performance = MatchRules.Performance(r.Win, r.Floor, r.RunSeconds) }).ToList(),              RelatedFixtures = data.Esports.Competitions.SelectMany(c => c.Fixtures.Where(f => !f.Finished && f.Day >= data.Day                  && f.Day <= data.Day + 14 && f.HomeId != "player" && f.AwayId != "player"                  && (subjects.Contains(f.HomeId) || subjects.Contains(f.AwayId))).Select(f => new PublicMatch                  { Day = f.Day, Event = c.Name, Home = CareerEngine.DisplayName(data, f.HomeId), Away = CareerEngine.DisplayName(data, f.AwayId),                      Ascension = f.Ascension, Status = "对阵已公布" })).OrderBy(f => f.Day).Take(2).ToList()          };`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`subjects.Contains(f.AwayId)`；返回值紧邻使用处：`BinaryExpressionSyntax: subjects.Contains(f.HomeId) || subjects.Contains(f.AwayId)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`subjects.Contains(f.HomeId)`；返回值紧邻使用处：`BinaryExpressionSyntax: subjects.Contains(f.HomeId) || subjects.Contains(f.AwayId)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`past.TakeLast(2).Concat(opponents.Select(id => past.LastOrDefault(r => r.OpponentId == id))              .OfType<CareerResult>())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: past.TakeLast(2).Concat(opponents.Select(id => past.LastOrDefault(r => r.OpponentId == id))              .OfType<CareerResult>()).DistinctBy`
- `System.Collections.Generic.IEnumerable<TSource>.DistinctBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`past.TakeLast(2).Concat(opponents.Select(id => past.LastOrDefault(r => r.OpponentId == id))              .OfType<CareerResult>()).DistinctBy(r => r.MatchId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: past.TakeLast(2).Concat(opponents.Select(id => past.LastOrDefault(r => r.OpponentId == id))              .OfType<CareerResult>()).DistinctBy(r => r.MatchId).OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`past.LastOrDefault(r => r.OpponentId == id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => past.LastOrDefault(r => r.OpponentId == id)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.Esports.Competitions.SelectMany(c => c.Fixtures.Where(f => !f.Finished && f.Day >= data.Day                  && f.Day <= data.Day + 14 && f.HomeId != "player" && f.AwayId != "player"                  && (subjects.Contains(f.HomeId) || subjects.Contains(f.AwayId))).Select(f => new PublicMatch                  { Day = f.Day, Event = c.Name, Home = CareerEngine.DisplayName(data, f.HomeId), Away = CareerEngine.DisplayName(data, f.AwayId),                      Ascension = f.Ascension, Status = "对阵已公布" })).OrderBy(f => f.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Esports.Competitions.SelectMany(c => c.Fixtures.Where(f => !f.Finished && f.Day >= data.Day                  && f.Day <= data.Day + 14 && f.HomeId != "player" && f.AwayId != "player"                  && (subjects.Contains(f.HomeId) || subjects.Contains(f.AwayId))).Select(f => new PublicMatch                  { Day = f.Day, Event = c.Name, Home = CareerEngine.DisplayName(data, f.HomeId), Away = CareerEngine.DisplayName(data, f.AwayId),                      Ascension = f.Ascension, Status = "对阵已公布" })).OrderBy(f => f.Day).Take`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.Matches.Where(m => m.Day >= data.Day && m.Status is "待赛" or "进行中")              .Where(m => m.Registered || m.Id == data.PendingMatchId || !m.RegistrationDeclined && EsportsWorld.EntryReason(data, m) == null)              .OrderByDescending(m => m.Registered || m.Id == data.PendingMatchId).ThenBy(m => m.Day).Take(3).OrderBy(m => m.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Matches.Where(m => m.Day >= data.Day && m.Status is "待赛" or "进行中")              .Where(m => m.Registered || m.Id == data.PendingMatchId || !m.RegistrationDeclined && EsportsWorld.EntryReason(data, m) == null)              .OrderByDescending(m => m.Registered || m.Id == data.PendingMatchId).ThenBy(m => m.Day).Take(3).OrderBy(m => m.Day).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.Matches.Where(m => m.Day >= data.Day && m.Status is "待赛" or "进行中")              .Where(m => m.Registered || m.Id == data.PendingMatchId || !m.RegistrationDeclined && EsportsWorld.EntryReason(data, m) == null)              .OrderByDescending(m => m.Registered || m.Id == data.PendingMatchId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Matches.Where(m => m.Day >= data.Day && m.Status is "待赛" or "进行中")              .Where(m => m.Registered || m.Id == data.PendingMatchId || !m.RegistrationDeclined && EsportsWorld.EntryReason(data, m) == null)              .OrderByDescending(m => m.Registered || m.Id == data.PendingMatchId).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`past.TakeLast(2).Concat(opponents.Select(id => past.LastOrDefault(r => r.OpponentId == id))              .OfType<CareerResult>()).DistinctBy(r => r.MatchId).OrderByDescending(r => r.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: past.TakeLast(2).Concat(opponents.Select(id => past.LastOrDefault(r => r.OpponentId == id))              .OfType<CareerResult>()).DistinctBy(r => r.MatchId).OrderByDescending(r => r.Day).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`c.Fixtures.Where(f => !f.Finished && f.Day >= data.Day                  && f.Day <= data.Day + 14 && f.HomeId != "player" && f.AwayId != "player"                  && (subjects.Contains(f.HomeId) || subjects.Contains(f.AwayId))).Select(f => new PublicMatch                  { Day = f.Day, Event = c.Name, Home = CareerEngine.DisplayName(data, f.HomeId), Away = CareerEngine.DisplayName(data, f.AwayId),                      Ascension = f.Ascension, Status = "对阵已公布" })`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => c.Fixtures.Where(f => !f.Finished && f.Day >= data.Day                  && f.Day <= data.Day + 14 && f.HomeId != "player" && f.AwayId != "player"                  && (subjects.Contains(f.HomeId) || subjects.Contains(f.AwayId))).Select(f => new PublicMatch                  { Day = f.Day, Event = c.Name, Home = CareerEngine.DisplayName(data, f.HomeId), Away = CareerEngine.DisplayName(data, f.AwayId),                      Ascension = f.Ascension, Status = "对阵已公布" })`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`meetings.Select(r => new PublicMeeting { Day = r.Day, Event = r.Event, Participant = CareerEngine.Name(data),                  Opponent = CareerEngine.DisplayName(data, r.OpponentId), Outcome = r.Outcome, Ascension = r.Ascension,                  Performance = MatchRules.Performance(r.Win, r.Floor, r.RunSeconds) })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: meetings.Select(r => new PublicMeeting { Day = r.Day, Event = r.Event, Participant = CareerEngine.Name(data),                  Opponent = CareerEngine.DisplayName(data, r.OpponentId), Outcome = r.Outcome, Ascension = r.Ascension,                  Performance = MatchRules.Performance(r.Win, r.Floor, r.RunSeconds) }).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`opponents.Select(id => past.LastOrDefault(r => r.OpponentId == id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: opponents.Select(id => past.LastOrDefault(r => r.OpponentId == id))              .OfType<CareerResult>`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`upcoming.Select(m => m.OpponentId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: upcoming.Select(m => m.OpponentId).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`upcoming.Select(m => new PublicMatch { Day = m.Day, Event = m.Event, Ascension = m.RequiredAscension,                  Home = CareerEngine.Name(data), Away = CareerEngine.DisplayName(data, m.OpponentId),                  Status = m.Id == data.PendingMatchId ? "正在比赛" : m.Registered ? "已报名" : "可报名，尚未报名" })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: upcoming.Select(m => new PublicMatch { Day = m.Day, Event = m.Event, Ascension = m.RequiredAscension,                  Home = CareerEngine.Name(data), Away = CareerEngine.DisplayName(data, m.OpponentId),                  Status = m.Id == data.PendingMatchId ? "正在比赛" : m.Registered ? "已报名" : "可报名，尚未报名" }).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`data.Esports.Competitions.SelectMany(c => c.Fixtures.Where(f => !f.Finished && f.Day >= data.Day                  && f.Day <= data.Day + 14 && f.HomeId != "player" && f.AwayId != "player"                  && (subjects.Contains(f.HomeId) || subjects.Contains(f.AwayId))).Select(f => new PublicMatch                  { Day = f.Day, Event = c.Name, Home = CareerEngine.DisplayName(data, f.HomeId), Away = CareerEngine.DisplayName(data, f.AwayId),                      Ascension = f.Ascension, Status = "对阵已公布" }))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Esports.Competitions.SelectMany(c => c.Fixtures.Where(f => !f.Finished && f.Day >= data.Day                  && f.Day <= data.Day + 14 && f.HomeId != "player" && f.AwayId != "player"                  && (subjects.Contains(f.HomeId) || subjects.Contains(f.AwayId))).Select(f => new PublicMatch                  { Day = f.Day, Event = c.Name, Home = CareerEngine.DisplayName(data, f.HomeId), Away = CareerEngine.DisplayName(data, f.AwayId),                      Ascension = f.Ascension, Status = "对阵已公布" })).OrderBy`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`data.Esports.Competitions.SelectMany(c => c.Fixtures.Where(f => !f.Finished && f.Day >= data.Day                  && f.Day <= data.Day + 14 && f.HomeId != "player" && f.AwayId != "player"                  && (subjects.Contains(f.HomeId) || subjects.Contains(f.AwayId))).Select(f => new PublicMatch                  { Day = f.Day, Event = c.Name, Home = CareerEngine.DisplayName(data, f.HomeId), Away = CareerEngine.DisplayName(data, f.AwayId),                      Ascension = f.Ascension, Status = "对阵已公布" })).OrderBy(f => f.Day).Take(2)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Esports.Competitions.SelectMany(c => c.Fixtures.Where(f => !f.Finished && f.Day >= data.Day                  && f.Day <= data.Day + 14 && f.HomeId != "player" && f.AwayId != "player"                  && (subjects.Contains(f.HomeId) || subjects.Contains(f.AwayId))).Select(f => new PublicMatch                  { Day = f.Day, Event = c.Name, Home = CareerEngine.DisplayName(data, f.HomeId), Away = CareerEngine.DisplayName(data, f.AwayId),                      Ascension = f.Ascension, Status = "对阵已公布" })).OrderBy(f => f.Day).Take(2).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`data.Matches.Where(m => m.Day >= data.Day && m.Status is "待赛" or "进行中")              .Where(m => m.Registered || m.Id == data.PendingMatchId || !m.RegistrationDeclined && EsportsWorld.EntryReason(data, m) == null)              .OrderByDescending(m => m.Registered || m.Id == data.PendingMatchId).ThenBy(m => m.Day).Take(3)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Matches.Where(m => m.Day >= data.Day && m.Status is "待赛" or "进行中")              .Where(m => m.Registered || m.Id == data.PendingMatchId || !m.RegistrationDeclined && EsportsWorld.EntryReason(data, m) == null)              .OrderByDescending(m => m.Registered || m.Id == data.PendingMatchId).ThenBy(m => m.Day).Take(3).OrderBy`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`past.TakeLast(2).Concat(opponents.Select(id => past.LastOrDefault(r => r.OpponentId == id))              .OfType<CareerResult>()).DistinctBy(r => r.MatchId).OrderByDescending(r => r.Day).Take(5)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = past.TakeLast(2).Concat(opponents.Select(id => past.LastOrDefault(r => r.OpponentId == id))              .OfType<CareerResult>()).DistinctBy(r => r.MatchId).OrderByDescending(r => r.Day).Take(5)`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`past.TakeLast(2)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: past.TakeLast(2).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`related.Where(id => id != "player" && id != "desk").ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = related.Where(id => id != "player" && id != "desk").ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`upcoming.Select(m => m.OpponentId).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = upcoming.Select(m => m.OpponentId).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`data.Esports.Competitions.SelectMany(c => c.Fixtures.Where(f => !f.Finished && f.Day >= data.Day                  && f.Day <= data.Day + 14 && f.HomeId != "player" && f.AwayId != "player"                  && (subjects.Contains(f.HomeId) || subjects.Contains(f.AwayId))).Select(f => new PublicMatch                  { Day = f.Day, Event = c.Name, Home = CareerEngine.DisplayName(data, f.HomeId), Away = CareerEngine.DisplayName(data, f.AwayId),                      Ascension = f.Ascension, Status = "对阵已公布" })).OrderBy(f => f.Day).Take(2).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: RelatedFixtures = data.Esports.Competitions.SelectMany(c => c.Fixtures.Where(f => !f.Finished && f.Day >= data.Day                  && f.Day <= data.Day + 14 && f.HomeId != "player" && f.AwayId != "player"                  && (subjects.Contains(f.HomeId) || subjects.Contains(f.AwayId))).Select(f => new PublicMatch                  { Day = f.Day, Event = c.Name, Home = CareerEngine.DisplayName(data, f.HomeId), Away = CareerEngine.DisplayName(data, f.AwayId),                      Ascension = f.Ascension, Status = "对阵已公布" })).OrderBy(f => f.Day).Take(2).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`data.Matches.Where(m => m.Day >= data.Day && m.Status is "待赛" or "进行中")              .Where(m => m.Registered || m.Id == data.PendingMatchId || !m.RegistrationDeclined && EsportsWorld.EntryReason(data, m) == null)              .OrderByDescending(m => m.Registered || m.Id == data.PendingMatchId).ThenBy(m => m.Day).Take(3).OrderBy(m => m.Day).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Matches.Where(m => m.Day >= data.Day && m.Status is "待赛" or "进行中")              .Where(m => m.Registered || m.Id == data.PendingMatchId || !m.RegistrationDeclined && EsportsWorld.EntryReason(data, m) == null)              .OrderByDescending(m => m.Registered || m.Id == data.PendingMatchId).ThenBy(m => m.Day).Take(3).OrderBy(m => m.Day).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`data.Results.Where(r => r.OfficialAscensionVerified && r.Day <= data.Day && r.Kind != "private-friendly").ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Results.Where(r => r.OfficialAscensionVerified && r.Day <= data.Day && r.Kind != "private-friendly").ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`meetings.Select(r => new PublicMeeting { Day = r.Day, Event = r.Event, Participant = CareerEngine.Name(data),                  Opponent = CareerEngine.DisplayName(data, r.OpponentId), Outcome = r.Outcome, Ascension = r.Ascension,                  Performance = MatchRules.Performance(r.Win, r.Floor, r.RunSeconds) }).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: RecentMeetings = meetings.Select(r => new PublicMeeting { Day = r.Day, Event = r.Event, Participant = CareerEngine.Name(data),                  Opponent = CareerEngine.DisplayName(data, r.OpponentId), Outcome = r.Outcome, Ascension = r.Ascension,                  Performance = MatchRules.Performance(r.Win, r.Floor, r.RunSeconds) }).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`upcoming.Select(m => new PublicMatch { Day = m.Day, Event = m.Event, Ascension = m.RequiredAscension,                  Home = CareerEngine.Name(data), Away = CareerEngine.DisplayName(data, m.OpponentId),                  Status = m.Id == data.PendingMatchId ? "正在比赛" : m.Registered ? "已报名" : "可报名，尚未报名" }).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Upcoming = upcoming.Select(m => new PublicMatch { Day = m.Day, Event = m.Event, Ascension = m.RequiredAscension,                  Home = CareerEngine.Name(data), Away = CareerEngine.DisplayName(data, m.OpponentId),                  Status = m.Id == data.PendingMatchId ? "正在比赛" : m.Registered ? "已报名" : "可报名，尚未报名" }).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(f => !f.Finished && f.Day >= data.Day                  && f.Day <= data.Day + 14 && f.HomeId != "player" && f.AwayId != "player"                  && (subjects.Contains(f.HomeId) || subjects.Contains(f.AwayId)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => !f.Finished && f.Day >= data.Day                  && f.Day <= data.Day + 14 && f.HomeId != "player" && f.AwayId != "player"                  && (subjects.Contains(f.HomeId) || subjects.Contains(f.AwayId))).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.Where(m => m.Day >= data.Day && m.Status is "待赛" or "进行中")              .Where(m => m.Registered || m.Id == data.PendingMatchId || !m.RegistrationDeclined && EsportsWorld.EntryReason(data, m) == null)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Matches.Where(m => m.Day >= data.Day && m.Status is "待赛" or "进行中")              .Where(m => m.Registered || m.Id == data.PendingMatchId || !m.RegistrationDeclined && EsportsWorld.EntryReason(data, m) == null)              .OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.Where(m => m.Day >= data.Day && m.Status is "待赛" or "进行中")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Matches.Where(m => m.Day >= data.Day && m.Status is "待赛" or "进行中")              .Where`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Results.Where(r => r.OfficialAscensionVerified && r.Day <= data.Day && r.Kind != "private-friendly")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Results.Where(r => r.OfficialAscensionVerified && r.Day <= data.Day && r.Kind != "private-friendly").ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`related.Where(id => id != "player" && id != "desk")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: related.Where(id => id != "player" && id != "desk").ToHashSet`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`opponents.Select(id => past.LastOrDefault(r => r.OpponentId == id))              .OfType<CareerResult>()`；返回值紧邻使用处：`ArgumentSyntax: opponents.Select(id => past.LastOrDefault(r => r.OpponentId == id))              .OfType<CareerResult>()`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`data.Matches.Where(m => m.Day >= data.Day && m.Status is "待赛" or "进行中")              .Where(m => m.Registered || m.Id == data.PendingMatchId || !m.RegistrationDeclined && EsportsWorld.EntryReason(data, m) == null)              .OrderByDescending(m => m.Registered || m.Id == data.PendingMatchId).ThenBy(m => m.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Matches.Where(m => m.Day >= data.Day && m.Status is "待赛" or "进行中")              .Where(m => m.Registered || m.Id == data.PendingMatchId || !m.RegistrationDeclined && EsportsWorld.EntryReason(data, m) == null)              .OrderByDescending(m => m.Registered || m.Id == data.PendingMatchId).ThenBy(m => m.Day).Take`

**赋值（含属性/字段和局部值）：**

- `Ascension` = `f.Ascension`
- `Ascension` = `m.RequiredAscension`
- `Ascension` = `r.Ascension`
- `AsOfDay` = `data.Day`
- `Away` = `CareerEngine.DisplayName(data, f.AwayId)`
- `Away` = `CareerEngine.DisplayName(data, m.OpponentId)`
- `Day` = `f.Day`
- `Day` = `m.Day`
- `Day` = `r.Day`
- `Event` = `c.Name`
- `Event` = `m.Event`
- `Event` = `r.Event`
- `Home` = `CareerEngine.DisplayName(data, f.HomeId)`
- `Home` = `CareerEngine.Name(data)`
- `Opponent` = `CareerEngine.DisplayName(data, r.OpponentId)`
- `Outcome` = `r.Outcome`
- `Participant` = `CareerEngine.Name(data)`
- `Performance` = `MatchRules.Performance(r.Win, r.Floor, r.RunSeconds)`
- `RecentMeetings` = `meetings.Select(r => new PublicMeeting { Day = r.Day, Event = r.Event, Participant = CareerEngine.Name(data),                  Opponent = CareerEngine.DisplayName(data, r.OpponentId), Outcome = r.Outcome, Ascension = r.Ascension,                  Performance = MatchRules.Performance(r.Win, r.Floor, r.RunSeconds) }).ToList()`
- `RelatedFixtures` = `data.Esports.Competitions.SelectMany(c => c.Fixtures.Where(f => !f.Finished && f.Day >= data.Day                  && f.Day <= data.Day + 14 && f.HomeId != "player" && f.AwayId != "player"                  && (subjects.Contains(f.HomeId) || subjects.Contains(f.AwayId))).Select(f => new PublicMatch                  { Day = f.Day, Event = c.Name, Home = CareerEngine.DisplayName(data, f.HomeId), Away = CareerEngine.DisplayName(data, f.AwayId),                      Ascension = f.Ascension, Status = "对阵已公布" })).OrderBy(f => f.Day).Take(2).ToList()`
- `Status` = `"对阵已公布"`
- `Status` = `m.Id == data.PendingMatchId ? "正在比赛" : m.Registered ? "已报名" : "可报名，尚未报名"`
- `Upcoming` = `upcoming.Select(m => new PublicMatch { Day = m.Day, Event = m.Event, Ascension = m.RequiredAscension,                  Home = CareerEngine.Name(data), Away = CareerEngine.DisplayName(data, m.OpponentId),                  Status = m.Id == data.PendingMatchId ? "正在比赛" : m.Registered ? "已报名" : "可报名，尚未报名" }).ToList()`

<a id="symbol-a78b8bb209c1"></a>

## `NationalSpire.PublicMatch.Day — public int Day`

来源：源码第 55 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-de937846a5ff"></a>

## `NationalSpire.PublicMatch.Event — public string Event`

来源：源码第 56 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7a8f43bcbb68"></a>

## `NationalSpire.PublicMatch.Home — public string Home`

来源：源码第 57 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d876527e3e90"></a>

## `NationalSpire.PublicMatch.Away — public string Away`

来源：源码第 58 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0e05b9610120"></a>

## `NationalSpire.PublicMatch.Ascension — public int Ascension`

来源：源码第 59 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-50762531e4b1"></a>

## `NationalSpire.PublicMatch.Status — public string Status`

来源：源码第 60 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4f90d011f0a9"></a>

## `NationalSpire.PublicMeeting.Participant — public string Participant`

来源：源码第 64 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9b13ea065c3d"></a>

## `NationalSpire.PublicMeeting.Day — public int Day`

来源：源码第 65 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-947f0a2a38a0"></a>

## `NationalSpire.PublicMeeting.Event — public string Event`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c9e914dfdc62"></a>

## `NationalSpire.PublicMeeting.Opponent — public string Opponent`

来源：源码第 67 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-288a0d10ea9a"></a>

## `NationalSpire.PublicMeeting.Outcome — public string Outcome`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7c4b597aa87c"></a>

## `NationalSpire.PublicMeeting.Ascension — public int Ascension`

来源：源码第 69 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8d9562d37d90"></a>

## `NationalSpire.PublicMeeting.Performance — public string Performance`

来源：源码第 70 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**
