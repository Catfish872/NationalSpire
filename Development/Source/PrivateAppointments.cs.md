# PrivateAppointments.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`6D8BDF0BEB03F447F56059EE79FF6AB2CCC53543CCFE5DB7FCD4085371F6F583`。来源：[源码](../../PrivateAppointments.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.PrivateAppointments`、`NationalSpire.PrivateAppointments.ScheduleEntry`、`NationalSpire.PrivateContracts`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-15c716ec61a1"></a>

## `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer) — public static int Date(CareerData data, PrivateOffer offer)`

来源：源码第 5 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`](GroupChatScreen.cs.md#symbol-3afa41099b93)；[`NationalSpire.PrivateAppointments.Confirm(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-3089895d205a)；[`NationalSpire.PrivateAppointments.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-e7f8b7355ddf)；[`NationalSpire.PrivateAppointments.Schedule(NationalSpire.CareerData, string, int)`](PrivateAppointments.cs.md#symbol-8d91a4d33a55)；[`NationalSpire.SocialAppointments.Attend(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](SocialAppointments.cs.md#symbol-4dbc4f79108f)；[`NationalSpire.SocialAppointments.Confirm(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer)`](SocialAppointments.cs.md#symbol-2f0b4ecea199)；[`NationalSpire.SocialAppointments.Due(NationalSpire.CareerData)`](SocialAppointments.cs.md#symbol-d348017d127b)；[`NationalSpire.SocialAppointments.Expire(NationalSpire.CareerData)`](SocialAppointments.cs.md#symbol-53508b4eaa4e)；[`NationalSpire.SocialAppointments.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`](SocialAppointments.cs.md#symbol-33a4725630bd)；[`NationalSpire.SocialAppointments.StatusText(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](SocialAppointments.cs.md#symbol-56b98eeeac09)

**调用：** [`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-ee7b01d76b23)

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateOffer.Day`；`NationalSpire.PrivateOffer.Season`；`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(data, offer.Season)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.Start(data, offer.Season) + offer.Day`

**赋值（含属性/字段和局部值）：**


<a id="symbol-10c695594457"></a>

## `NationalSpire.PrivateAppointments.Busy(NationalSpire.CareerData, string, int) — public static string Busy(CareerData data, string person, int date)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Calendar()`](PrivateMessageScreen.cs.md#symbol-87dbe5a56d80)

**调用：** [`NationalSpire.PrivateAppointments.Schedule(NationalSpire.CareerData, string, int)`](PrivateAppointments.cs.md#symbol-8d91a4d33a55)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateAppointments.Schedule(NationalSpire.CareerData, string, int)`；`NationalSpire.PrivateAppointments.ScheduleEntry.Event`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateAppointments.Schedule(NationalSpire.CareerData, string, int)`；输入表达式：`Schedule(data, person, date)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Schedule(data, person, date).Select`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", Schedule(data, person, date).Select(s => s.Event).Distinct())`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => string.Join("、", Schedule(data, person, date).Select(s => s.Event).Distinct())`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`Schedule(data, person, date).Select(s => s.Event).Distinct()`；返回值紧邻使用处：`ArgumentSyntax: Schedule(data, person, date).Select(s => s.Event).Distinct()`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`Schedule(data, person, date).Select(s => s.Event)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Schedule(data, person, date).Select(s => s.Event).Distinct`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8d91a4d33a55"></a>

## `NationalSpire.PrivateAppointments.Schedule(NationalSpire.CareerData, string, int) — public static List<ScheduleEntry> Schedule(CareerData data, string person, int date)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Calendar()`](PrivateMessageScreen.cs.md#symbol-87dbe5a56d80)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.PrivateAppointments.Busy(NationalSpire.CareerData, string, int)`](PrivateAppointments.cs.md#symbol-10c695594457)；[`NationalSpire.PrivateMessagePrompts.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-4b9d12b26f65)

**调用：** [`FixtureText(NationalSpire.WorldFixture, NationalSpire.WorldCompetition)`](PrivateAppointments.cs.md#symbol-083f0c73893a)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`](EsportsWorld.cs.md#symbol-4b9f3e1bf70a)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；[`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；[`NationalSpire.SocialAppointments.All(NationalSpire.CareerData)`](SocialAppointments.cs.md#symbol-0596ed8dd544)；[`TeamInvolved(NationalSpire.WorldCompetition, string)`](PrivateAppointments.cs.md#symbol-ad4e79e98843)；`NationalSpire.PrivateAppointments.ScheduleEntry.ScheduleEntry(int, string, string, bool)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `(NationalSpire.PrivateConversation Conversation, NationalSpire.PrivateOffer Offer).Conversation`；`(NationalSpire.PrivateConversation Conversation, NationalSpire.PrivateOffer Offer).Offer`；`FixtureText(NationalSpire.WorldFixture, NationalSpire.WorldCompetition)`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerMatch.CompetitionId`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerMatch.Event`；`NationalSpire.CareerMatch.FixtureId`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.Registered`；`NationalSpire.CareerMatch.RegistrationDeclined`；`NationalSpire.CareerMatch.RequiredAscension`；`NationalSpire.CareerMatch.Status`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.GroupId`；`NationalSpire.PrivateOffer.Participants`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.Title`；`NationalSpire.SocialAppointments.All(NationalSpire.CareerData)`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Name`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.AwayParticipants`；`NationalSpire.WorldFixture.AwayTeam`；`NationalSpire.WorldFixture.Day`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.HomeParticipants`；`NationalSpire.WorldFixture.HomeTeam`；`NationalSpire.WorldFixture.Id`；`TeamInvolved(NationalSpire.WorldCompetition, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `FixtureText(NationalSpire.WorldFixture, NationalSpire.WorldCompetition)`；输入表达式：`FixtureText(f, c)`；返回值紧邻使用处：`ArgumentSyntax: FixtureText(f, c)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, m.OpponentId)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.DisplayName(data, m.OpponentId)}`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, x.Conversation.PersonId)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.DisplayName(data, x.Conversation.PersonId)}`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(data)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Name(data)`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Person(data, person)`
- `NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`EsportsWorld.EntryReason(data, m)`；返回值紧邻使用处：`BinaryExpressionSyntax: EsportsWorld.EntryReason(data, m) == null`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(data, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => GroupChats.Name(data, id)`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`Date(data, x.Offer)`；返回值紧邻使用处：`BinaryExpressionSyntax: Date(data, x.Offer) == date`
- `NationalSpire.PrivateAppointments.ScheduleEntry.ScheduleEntry(int, string, string, bool)`；输入表达式：`new ScheduleEntry(date, c.Name, FixtureText(f, c))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: f => new ScheduleEntry(date, c.Name, FixtureText(f, c))`
- `NationalSpire.PrivateAppointments.ScheduleEntry.ScheduleEntry(int, string, string, bool)`；输入表达式：`new ScheduleEntry(date, m.Event, m.Id == data.PendingMatchId || m.Status == "进行中"                  ? $"{player}正在参加{m.Event}，对手为{CareerEngine.DisplayName(data, m.OpponentId)}，进阶{m.RequiredAscension}。"                  : m.Registered ? $"{player}已报名{m.Event}，对手为{CareerEngine.DisplayName(data, m.OpponentId)}，进阶{m.RequiredAscension}，比赛尚未开始。"                  : $"{player}可以报名{m.Event}，目前尚未报名；报名后预定对手为{CareerEngine.DisplayName(data, m.OpponentId)}，进阶{m.RequiredAscension}。", m.Registered || m.Id == data.PendingMatchId || m.Status == "进行中")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m => new ScheduleEntry(date, m.Event, m.Id == data.PendingMatchId || m.Status == "进行中"                  ? $"{player}正在参加{m.Event}，对手为{CareerEngine.DisplayName(data, m.OpponentId)}，进阶{m.RequiredAscension}。"                  : m.Registered ? $"{player}已报名{m.Event}，对手为{CareerEngine.DisplayName(data, m.OpponentId)}，进阶{m.RequiredAscension}，比赛尚未开始。"                  : $"{player}可以报名{m.Event}，目前尚未报名；报名后预定对手为{CareerEngine.DisplayName(data, m.OpponentId)}，进阶{m.RequiredAscension}。", m.Registered || m.Id == data.PendingMatchId || m.Status == "进行中")`
- `NationalSpire.PrivateAppointments.ScheduleEntry.ScheduleEntry(int, string, string, bool)`；输入表达式：`new ScheduleEntry(date, x.Offer.Title, (x.Offer.GroupId.Length > 0                  ? string.Join("、", x.Offer.Participants.Select(id => GroupChats.Name(data, id)))                  : $"{player}与{CareerEngine.DisplayName(data, x.Conversation.PersonId)}") + $"已约定《{x.Offer.Title}》。{x.Offer.Detail}")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: x => new ScheduleEntry(date, x.Offer.Title, (x.Offer.GroupId.Length > 0                  ? string.Join("、", x.Offer.Participants.Select(id => GroupChats.Name(data, id)))                  : $"{player}与{CareerEngine.DisplayName(data, x.Conversation.PersonId)}") + $"已约定《{x.Offer.Title}》。{x.Offer.Detail}")`
- `NationalSpire.SocialAppointments.All(NationalSpire.CareerData)`；输入表达式：`SocialAppointments.All(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: SocialAppointments.All(data).Where`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", x.Offer.Participants.Select(id => GroupChats.Name(data, id)))`；返回值紧邻使用处：`ConditionalExpressionSyntax: x.Offer.GroupId.Length > 0                  ? string.Join("、", x.Offer.Participants.Select(id => GroupChats.Name(data, id)))                  : $"{player}与{CareerEngine.DisplayName(data, x.Conversation.PersonId)}"`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`participants.Contains(f.AwayId)`；返回值紧邻使用处：`BinaryExpressionSyntax: participants.Contains(f.HomeId) || participants.Contains(f.AwayId)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`participants.Contains(f.HomeId)`；返回值紧邻使用处：`BinaryExpressionSyntax: participants.Contains(f.HomeId) || participants.Contains(f.AwayId)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.Any(m => m.Day == date && m.CompetitionId == c.Id && m.FixtureId == f.Id                  && m.Status is "待赛" or "进行中" && (m.Registered || m.Id == data.PendingMatchId))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !data.Matches.Any(m => m.Day == date && m.CompetitionId == c.Id && m.FixtureId == f.Id                  && m.Status is "待赛" or "进行中" && (m.Registered || m.Id == data.PendingMatchId))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`f.AwayParticipants.Any(participants.Contains)`；返回值紧邻使用处：`BinaryExpressionSyntax: participants.Contains(f.HomeId) || participants.Contains(f.AwayId) || f.HomeParticipants.Any(participants.Contains) || f.AwayParticipants.Any(participants.Contains)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`f.HomeParticipants.Any(participants.Contains)`；返回值紧邻使用处：`BinaryExpressionSyntax: participants.Contains(f.HomeId) || participants.Contains(f.AwayId) || f.HomeParticipants.Any(participants.Contains)`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`data.HumanIds.Append("player").Append(person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.HumanIds.Append("player").Append(person).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`data.HumanIds.Append("player")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.HumanIds.Append("player").Append`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`matches.Concat(fixtures).Concat(activities)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: matches.Concat(fixtures).Concat(activities).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`matches.Concat(fixtures)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: matches.Concat(fixtures).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`matches.Concat(fixtures).Concat(activities).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: matches.Concat(fixtures).Concat(activities).Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`c.Fixtures.Where(f => f.Day == date && !f.Finished              && (participants.Contains(f.HomeId) || participants.Contains(f.AwayId) || f.HomeParticipants.Any(participants.Contains) || f.AwayParticipants.Any(participants.Contains)                  || TeamInvolved(c, f.HomeTeam) || TeamInvolved(c, f.AwayTeam)))              // 已报名的同一场玩家赛事已含日期、双方和进阶，避免重复成两项安排。              .Where(f => !data.Matches.Any(m => m.Day == date && m.CompetitionId == c.Id && m.FixtureId == f.Id                  && m.Status is "待赛" or "进行中" && (m.Registered || m.Id == data.PendingMatchId)))              .Select(f => new ScheduleEntry(date, c.Name, FixtureText(f, c)))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => c.Fixtures.Where(f => f.Day == date && !f.Finished              && (participants.Contains(f.HomeId) || participants.Contains(f.AwayId) || f.HomeParticipants.Any(participants.Contains) || f.AwayParticipants.Any(participants.Contains)                  || TeamInvolved(c, f.HomeTeam) || TeamInvolved(c, f.AwayTeam)))              // 已报名的同一场玩家赛事已含日期、双方和进阶，避免重复成两项安排。              .Where(f => !data.Matches.Any(m => m.Day == date && m.CompetitionId == c.Id && m.FixtureId == f.Id                  && m.Status is "待赛" or "进行中" && (m.Registered || m.Id == data.PendingMatchId)))              .Select(f => new ScheduleEntry(date, c.Name, FixtureText(f, c)))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`data.Matches.Where(m => m.Day == date && m.Status is "待赛" or "进行中"              && (m.Registered || m.Id == data.PendingMatchId || !m.RegistrationDeclined && EsportsWorld.EntryReason(data, m) == null))              .Select(m => new ScheduleEntry(date, m.Event, m.Id == data.PendingMatchId || m.Status == "进行中"                  ? $"{player}正在参加{m.Event}，对手为{CareerEngine.DisplayName(data, m.OpponentId)}，进阶{m.RequiredAscension}。"                  : m.Registered ? $"{player}已报名{m.Event}，对手为{CareerEngine.DisplayName(data, m.OpponentId)}，进阶{m.RequiredAscension}，比赛尚未开始。"                  : $"{player}可以报名{m.Event}，目前尚未报名；报名后预定对手为{CareerEngine.DisplayName(data, m.OpponentId)}，进阶{m.RequiredAscension}。", m.Registered || m.Id == data.PendingMatchId || m.Status == "进行中"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Matches.Where(m => m.Day == date && m.Status is "待赛" or "进行中"              && (m.Registered || m.Id == data.PendingMatchId || !m.RegistrationDeclined && EsportsWorld.EntryReason(data, m) == null))              .Select(m => new ScheduleEntry(date, m.Event, m.Id == data.PendingMatchId || m.Status == "进行中"                  ? $"{player}正在参加{m.Event}，对手为{CareerEngine.DisplayName(data, m.OpponentId)}，进阶{m.RequiredAscension}。"                  : m.Registered ? $"{player}已报名{m.Event}，对手为{CareerEngine.DisplayName(data, m.OpponentId)}，进阶{m.RequiredAscension}，比赛尚未开始。"                  : $"{player}可以报名{m.Event}，目前尚未报名；报名后预定对手为{CareerEngine.DisplayName(data, m.OpponentId)}，进阶{m.RequiredAscension}。", m.Registered || m.Id == data.PendingMatchId || m.Status == "进行中"))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`SocialAppointments.All(data).Where(x => x.Offer.State == "已确认" && Date(data, x.Offer) == date)              .Select(x => new ScheduleEntry(date, x.Offer.Title, (x.Offer.GroupId.Length > 0                  ? string.Join("、", x.Offer.Participants.Select(id => GroupChats.Name(data, id)))                  : $"{player}与{CareerEngine.DisplayName(data, x.Conversation.PersonId)}") + $"已约定《{x.Offer.Title}》。{x.Offer.Detail}"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SocialAppointments.All(data).Where(x => x.Offer.State == "已确认" && Date(data, x.Offer) == date)              .Select(x => new ScheduleEntry(date, x.Offer.Title, (x.Offer.GroupId.Length > 0                  ? string.Join("、", x.Offer.Participants.Select(id => GroupChats.Name(data, id)))                  : $"{player}与{CareerEngine.DisplayName(data, x.Conversation.PersonId)}") + $"已约定《{x.Offer.Title}》。{x.Offer.Detail}"))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`x.Offer.Participants.Select(id => GroupChats.Name(data, id))`；返回值紧邻使用处：`ArgumentSyntax: x.Offer.Participants.Select(id => GroupChats.Name(data, id))`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`data.Esports.Competitions.SelectMany(c => c.Fixtures.Where(f => f.Day == date && !f.Finished              && (participants.Contains(f.HomeId) || participants.Contains(f.AwayId) || f.HomeParticipants.Any(participants.Contains) || f.AwayParticipants.Any(participants.Contains)                  || TeamInvolved(c, f.HomeTeam) || TeamInvolved(c, f.AwayTeam)))              // 已报名的同一场玩家赛事已含日期、双方和进阶，避免重复成两项安排。              .Where(f => !data.Matches.Any(m => m.Day == date && m.CompetitionId == c.Id && m.FixtureId == f.Id                  && m.Status is "待赛" or "进行中" && (m.Registered || m.Id == data.PendingMatchId)))              .Select(f => new ScheduleEntry(date, c.Name, FixtureText(f, c))))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Esports.Competitions.SelectMany(c => c.Fixtures.Where(f => f.Day == date && !f.Finished              && (participants.Contains(f.HomeId) || participants.Contains(f.AwayId) || f.HomeParticipants.Any(participants.Contains) || f.AwayParticipants.Any(participants.Contains)                  || TeamInvolved(c, f.HomeTeam) || TeamInvolved(c, f.AwayTeam)))              // 已报名的同一场玩家赛事已含日期、双方和进阶，避免重复成两项安排。              .Where(f => !data.Matches.Any(m => m.Day == date && m.CompetitionId == c.Id && m.FixtureId == f.Id                  && m.Status is "待赛" or "进行中" && (m.Registered || m.Id == data.PendingMatchId)))              .Select(f => new ScheduleEntry(date, c.Name, FixtureText(f, c))))`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`data.HumanIds.Append("player").Append(person).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.HumanIds.Append("player").Append(person).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`matches.Concat(fixtures).Concat(activities).Distinct().ToList()`；返回值紧邻使用处：`ReturnStatementSyntax: return matches.Concat(fixtures).Concat(activities).Distinct().ToList();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(f => f.Day == date && !f.Finished              && (participants.Contains(f.HomeId) || participants.Contains(f.AwayId) || f.HomeParticipants.Any(participants.Contains) || f.AwayParticipants.Any(participants.Contains)                  || TeamInvolved(c, f.HomeTeam) || TeamInvolved(c, f.AwayTeam)))              // 已报名的同一场玩家赛事已含日期、双方和进阶，避免重复成两项安排。              .Where(f => !data.Matches.Any(m => m.Day == date && m.CompetitionId == c.Id && m.FixtureId == f.Id                  && m.Status is "待赛" or "进行中" && (m.Registered || m.Id == data.PendingMatchId)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.Day == date && !f.Finished              && (participants.Contains(f.HomeId) || participants.Contains(f.AwayId) || f.HomeParticipants.Any(participants.Contains) || f.AwayParticipants.Any(participants.Contains)                  || TeamInvolved(c, f.HomeTeam) || TeamInvolved(c, f.AwayTeam)))              // 已报名的同一场玩家赛事已含日期、双方和进阶，避免重复成两项安排。              .Where(f => !data.Matches.Any(m => m.Day == date && m.CompetitionId == c.Id && m.FixtureId == f.Id                  && m.Status is "待赛" or "进行中" && (m.Registered || m.Id == data.PendingMatchId)))              .Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(f => f.Day == date && !f.Finished              && (participants.Contains(f.HomeId) || participants.Contains(f.AwayId) || f.HomeParticipants.Any(participants.Contains) || f.AwayParticipants.Any(participants.Contains)                  || TeamInvolved(c, f.HomeTeam) || TeamInvolved(c, f.AwayTeam)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.Day == date && !f.Finished              && (participants.Contains(f.HomeId) || participants.Contains(f.AwayId) || f.HomeParticipants.Any(participants.Contains) || f.AwayParticipants.Any(participants.Contains)                  || TeamInvolved(c, f.HomeTeam) || TeamInvolved(c, f.AwayTeam)))              // 已报名的同一场玩家赛事已含日期、双方和进阶，避免重复成两项安排。              .Where`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.Where(m => m.Day == date && m.Status is "待赛" or "进行中"              && (m.Registered || m.Id == data.PendingMatchId || !m.RegistrationDeclined && EsportsWorld.EntryReason(data, m) == null))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: data.Matches.Where(m => m.Day == date && m.Status is "待赛" or "进行中"              && (m.Registered || m.Id == data.PendingMatchId || !m.RegistrationDeclined && EsportsWorld.EntryReason(data, m) == null))              .Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`SocialAppointments.All(data).Where(x => x.Offer.State == "已确认" && Date(data, x.Offer) == date)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: SocialAppointments.All(data).Where(x => x.Offer.State == "已确认" && Date(data, x.Offer) == date)              .Select`
- `TeamInvolved(NationalSpire.WorldCompetition, string)`；输入表达式：`TeamInvolved(c, f.AwayTeam)`；返回值紧邻使用处：`BinaryExpressionSyntax: participants.Contains(f.HomeId) || participants.Contains(f.AwayId) || f.HomeParticipants.Any(participants.Contains) || f.AwayParticipants.Any(participants.Contains)                  || TeamInvolved(c, f.HomeTeam) || TeamInvolved(c, f.AwayTeam)`
- `TeamInvolved(NationalSpire.WorldCompetition, string)`；输入表达式：`TeamInvolved(c, f.HomeTeam)`；返回值紧邻使用处：`BinaryExpressionSyntax: participants.Contains(f.HomeId) || participants.Contains(f.AwayId) || f.HomeParticipants.Any(participants.Contains) || f.AwayParticipants.Any(participants.Contains)                  || TeamInvolved(c, f.HomeTeam)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ad4e79e98843"></a>

## `TeamInvolved(NationalSpire.WorldCompetition, string) — bool TeamInvolved(WorldCompetition competition, string team)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateAppointments.Schedule(NationalSpire.CareerData, string, int)`](PrivateAppointments.cs.md#symbol-8d91a4d33a55)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.WorldCompetition.Rosters`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Any(participants.Contains)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: competition.Rosters.GetValueOrDefault(team)?.Any(participants.Contains)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`competition.Rosters.GetValueOrDefault(team)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: competition.Rosters.GetValueOrDefault(team)?.Any(participants.Contains)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-083f0c73893a"></a>

## `FixtureText(NationalSpire.WorldFixture, NationalSpire.WorldCompetition) — string FixtureText(WorldFixture f, WorldCompetition c)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateAppointments.Schedule(NationalSpire.CareerData, string, int)`](PrivateAppointments.cs.md#symbol-8d91a4d33a55)

**调用：** [`HumanName(string)`](PrivateAppointments.cs.md#symbol-11b3ef0b7941)；[`Side(string, string)`](PrivateAppointments.cs.md#symbol-023dd4ead03f)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`string.StartsWith(string, System.StringComparison)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.List()`

**字段、属性、事件及方法组引用：** `HumanName(string)`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.WorldCompetition.Name`；`NationalSpire.WorldCompetition.Rosters`；`NationalSpire.WorldFixture.Ascension`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.AwayParticipants`；`NationalSpire.WorldFixture.AwayTeam`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.HomeParticipants`；`NationalSpire.WorldFixture.HomeTeam`；`Side(string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `HumanName(string)`；输入表达式：`HumanName(id)`；返回值紧邻使用处：`ArgumentSyntax: HumanName(id)`
- `HumanName(string)`；输入表达式：`HumanName(id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: id == person ? p!.PublicName : HumanName(id)`
- `Side(string, string)`；输入表达式：`Side(f.AwayId, f.AwayTeam)`；返回值紧邻使用处：`InterpolationSyntax: {Side(f.AwayId, f.AwayTeam)}`
- `Side(string, string)`；输入表达式：`Side(f.HomeId, f.HomeTeam)`；返回值紧邻使用处：`InterpolationSyntax: {Side(f.HomeId, f.HomeTeam)}`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", involved.Distinct())`；返回值紧邻使用处：`InterpolationSyntax: {string.Join("、", involved.Distinct())}`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`s.StartsWith(name, StringComparison.Ordinal)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: s => s.StartsWith(name, StringComparison.Ordinal)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`involved.Any(s => s.StartsWith(name, StringComparison.Ordinal))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !involved.Any(s => s.StartsWith(name, StringComparison.Ordinal))`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`involved.Distinct()`；返回值紧邻使用处：`ArgumentSyntax: involved.Distinct()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`participants.Where(id => c.Rosters.GetValueOrDefault(f.HomeTeam)?.Contains(id) == true || c.Rosters.GetValueOrDefault(f.AwayTeam)?.Contains(id) == true)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string id in participants.Where(id => c.Rosters.GetValueOrDefault(f.HomeTeam)?.Contains(id) == true || c.Rosters.GetValueOrDefault(f.AwayTeam)?.Contains(id) == true))              {                  string name = id == person ? p!.PublicName : HumanName(id);                  if (!involved.Any(s => s.StartsWith(name, StringComparison.Ordinal))) involved.Add(name + "所属队伍");              }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`participants.Where(id => id != person && (f.HomeId == id || f.AwayId == id || f.HomeParticipants.Contains(id) || f.AwayParticipants.Contains(id)))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string id in participants.Where(id => id != person && (f.HomeId == id || f.AwayId == id || f.HomeParticipants.Contains(id) || f.AwayParticipants.Contains(id)))) involved.Add(HumanName(id));`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`c.Rosters.GetValueOrDefault(f.AwayTeam)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: c.Rosters.GetValueOrDefault(f.AwayTeam)?.Contains(id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`c.Rosters.GetValueOrDefault(f.HomeTeam)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: c.Rosters.GetValueOrDefault(f.HomeTeam)?.Contains(id)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`involved.Add(HumanName(id))`；返回值紧邻使用处：`ExpressionStatementSyntax: involved.Add(HumanName(id));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`involved.Add(name + "所属队伍")`；返回值紧邻使用处：`ExpressionStatementSyntax: involved.Add(name + "所属队伍");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`involved.Add(p!.PublicName)`；返回值紧邻使用处：`ExpressionStatementSyntax: involved.Add(p!.PublicName);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`involved.Add(p.PublicName + "所属俱乐部")`；返回值紧邻使用处：`ExpressionStatementSyntax: involved.Add(p.PublicName + "所属俱乐部");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`involved.Add(player + "所属俱乐部")`；返回值紧邻使用处：`ExpressionStatementSyntax: involved.Add(player + "所属俱乐部");`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`.Contains(id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: c.Rosters.GetValueOrDefault(f.AwayTeam)?.Contains(id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`.Contains(id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: c.Rosters.GetValueOrDefault(f.HomeTeam)?.Contains(id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`f.AwayParticipants.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: f.HomeId == id || f.AwayId == id || f.HomeParticipants.Contains(id) || f.AwayParticipants.Contains(id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`f.AwayParticipants.Contains(person)`；返回值紧邻使用处：`BinaryExpressionSyntax: f.HomeId == person || f.AwayId == person || f.HomeParticipants.Contains(person) || f.AwayParticipants.Contains(person)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`f.HomeParticipants.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: f.HomeId == id || f.AwayId == id || f.HomeParticipants.Contains(id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`f.HomeParticipants.Contains(person)`；返回值紧邻使用处：`BinaryExpressionSyntax: f.HomeId == person || f.AwayId == person || f.HomeParticipants.Contains(person)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`involved.Contains(player)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !involved.Contains(player)`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string>()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-023dd4ead03f"></a>

## `Side(string, string) — string Side(string id, string team)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`FixtureText(NationalSpire.WorldFixture, NationalSpire.WorldCompetition)`](PrivateAppointments.cs.md#symbol-083f0c73893a)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；`NationalSpire.WorldCompetition.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: team.Length > 0 ? (c.Kind == "worldcup" ? team : EsportsWorld.ClubName(data, team)) : CareerEngine.DisplayName(data, id)`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(data, team)`；返回值紧邻使用处：`ConditionalExpressionSyntax: c.Kind == "worldcup" ? team : EsportsWorld.ClubName(data, team)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-11b3ef0b7941"></a>

## `HumanName(string) — string HumanName(string id)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`FixtureText(NationalSpire.WorldFixture, NationalSpire.WorldCompetition)`](PrivateAppointments.cs.md#symbol-083f0c73893a)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: id == "player" || id == data.LocalHumanId ? player : CareerEngine.DisplayName(data, id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1c549626b284"></a>

## `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int) — public static string DateText(CareerData data, int date)`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Add()`](PrivateAppointments.cs.md#symbol-72968688758c)；[`NationalSpire.AiService.SummarizeGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, string)`](AiGroupChats.cs.md#symbol-1e6e737dbe88)；[`NationalSpire.CareerScreen.ArbitrationCard(NationalSpire.CareerData, NationalSpire.ArbitrationRecord)`](ArbitrationScreen.cs.md#symbol-8d41f13d5476)；[`NationalSpire.CareerScreen.PrivateTrainingCard(NationalSpire.CareerData, NationalSpire.CoachTrainingPlan, Godot.VBoxContainer, System.Action<string, NationalSpire.PrivateMessageCommand>?)`](CoachScreen.cs.md#symbol-c2e37e4a0f14)；[`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.ChatTimeline.PublicMemories(NationalSpire.CareerData, string, int)`](ChatTimeline.cs.md#symbol-26f194fa1e79)；[`NationalSpire.ChatTimeline.Text(NationalSpire.CareerData, NationalSpire.ChatTimeline.Item)`](ChatTimeline.cs.md#symbol-127674c9926b)；[`NationalSpire.ClubCoaching.TrainingContext(NationalSpire.CareerData, string)`](ClubCoaching.cs.md#symbol-b2b767ed4fea)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.GroupChatPrompts.InteractionContext(NationalSpire.CareerData, NationalSpire.GroupChat, int, string, string)`](GroupChatPrompts.cs.md#symbol-ccc55b5e837d)；[`NationalSpire.PrivateMessagePrompts.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-4b9d12b26f65)；[`NationalSpire.PrivateMessages.PublicMemory(NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int)`](PrivateMessages.cs.md#symbol-81234ccf975f)；[`NationalSpire.PrivatePublicContext.AppendCareerDetails(System.Text.StringBuilder, NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?)`](PrivateCareerContext.cs.md#symbol-12edc643ff32)；[`NationalSpire.PrivatePublicContext.AppendClubDetails(System.Text.StringBuilder, NationalSpire.CareerData, NationalSpire.CareerClub, string, System.Collections.Generic.List<(int Start, int Length, string Group)>?)`](PrivateCareerContext.cs.md#symbol-7b4c2e1f7909)；[`NationalSpire.PrivatePublicContext.AppendRecentResults(System.Text.StringBuilder, NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivateCareerContext.cs.md#symbol-8c2348c334d4)；[`NationalSpire.PrivatePublicContext.Community(NationalSpire.CareerData, NationalSpire.CareerPerson, string, System.Collections.Generic.ISet<string>?, System.Collections.Generic.List<(string Id, string Text)>?, NationalSpire.CommunityMemorySearch.Request?)`](PrivatePublicContext.cs.md#symbol-58aebbb834b8)；[`NationalSpire.PrivatePublicContext.ContractTerms(NationalSpire.CareerData, NationalSpire.OwnedPlayerContract)`](PrivateCareerContext.cs.md#symbol-5fd0dbcab017)；[`NationalSpire.PrivatePublicContext.PostTexts(NationalSpire.CareerData, NationalSpire.CommunityPost, NationalSpire.CareerPerson, string, System.Collections.Generic.IEnumerable<NationalSpire.CommunityMemory>?, NationalSpire.CommunityMemorySearch.Request?)`](PrivatePublicContext.cs.md#symbol-0f3333edf327)；[`NationalSpire.PrivatePublicContext.Profiles(NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?)`](PrivatePublicContext.cs.md#symbol-d9c12bf4e41b)；[`NationalSpire.SpireArbitration.Memory(NationalSpire.CareerData, NationalSpire.CareerPerson)`](SpireArbitration.cs.md#symbol-7208d87df58d)；[`NationalSpire.SpireArbitration.Status(NationalSpire.ArbitrationRecord, NationalSpire.CareerData)`](SpireArbitration.cs.md#symbol-21e1b87da56b)；[`NoticesThrough(long)`](GroupChatScreen.cs.md#symbol-1a6ef767505d)；[`Summary(NationalSpire.PrivateSummary?)`](PrivateMessages.cs.md#symbol-c2e6abcf5336)；[`SummaryHeader(NationalSpire.PrivateSummary, string)`](PrivateMessagePrompts.cs.md#symbol-599deee1a419)

**调用：** [`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-12bdfe5d4265)；[`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-ee7b01d76b23)；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Season`；`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Length(data, season)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.Start(data, season) + SeasonCalendar.Length(data, season)`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(data, season)`；返回值紧邻使用处：`BinaryExpressionSyntax: date - SeasonCalendar.Start(data, season)`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(data, season)`；返回值紧邻使用处：`BinaryExpressionSyntax: date <= SeasonCalendar.Start(data, season)`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(data, season)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.Start(data, season) + SeasonCalendar.Length(data, season)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1, data.Season)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(1, data.Season)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9915e0a4ada0"></a>

## `NationalSpire.PrivateAppointments.DateRanges(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<int>) — public static string DateRanges(CareerData data, IEnumerable<int> dates)`

来源：源码第 58 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessagePrompts.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-4b9d12b26f65)

**调用：** [`Add()`](PrivateAppointments.cs.md#symbol-72968688758c)；[`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-0f707d2c9895)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<T>.Order<T>()`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.List<T>.List()`

**字段、属性、事件及方法组引用：** `Add()`；`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Add()`；输入表达式：`Add()`；返回值紧邻使用处：`ExpressionStatementSyntax: Add();`
- `NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Day(data, date)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.Day(data, date) != 1`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", ranges)`；返回值紧邻使用处：`ReturnStatementSyntax: return string.Join("、", ranges);`
- `System.Collections.Generic.IEnumerable<T>.Order<T>()`；输入表达式：`dates.Distinct().Order()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: dates.Distinct().Order().ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`dates.Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: dates.Distinct().Order`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`values.Skip(1)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (int date in values.Skip(1))          {              if (date == end + 1 && SeasonCalendar.Day(data, date) != 1) { end = date; continue; }              Add(); start = end = date;          }`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`dates.Distinct().Order().ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = dates.Distinct().Order().ToArray()`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string>()`

**赋值（含属性/字段和局部值）：**

- `end` = `date`
- `start` = `end = date`

<a id="symbol-72968688758c"></a>

## `Add() — void Add()`

来源：源码第 63 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateAppointments.DateRanges(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<int>)`](PrivateAppointments.cs.md#symbol-9915e0a4ada0)

**调用：** [`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`](PrivateAppointments.cs.md#symbol-1c549626b284)；[`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-0f707d2c9895)；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；输入表达式：`DateText(data, start)`；返回值紧邻使用处：`ConditionalExpressionSyntax: start == end ? DateText(data, start) : DateText(data, start)[..^1] + "至" + SeasonCalendar.Day(data, end) + "天"`
- `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；输入表达式：`DateText(data, start)`；返回值紧邻使用处：`ElementAccessExpressionSyntax: DateText(data, start)[..^1]`
- `NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Day(data, end)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateText(data, start)[..^1] + "至" + SeasonCalendar.Day(data, end)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`ranges.Add(start == end ? DateText(data, start) : DateText(data, start)[..^1] + "至" + SeasonCalendar.Day(data, end) + "天")`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ranges.Add(start == end ? DateText(data, start) : DateText(data, start)[..^1] + "至" + SeasonCalendar.Day(data, end) + "天")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e7f8b7355ddf"></a>

## `NationalSpire.PrivateAppointments.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer) — public static string? Error(CareerData data, string person, PrivateOffer offer)`

来源：源码第 71 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateMatchPicker()`](PrivateMessageScreen.cs.md#symbol-aa7339f37b26)；[`NationalSpire.Coop.CoopRules.PrivateCommand(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.Coop.CoopCommand)`](Coop/CoopPrivateMessages.cs.md#symbol-d33f4b1ffce8)；[`NationalSpire.PrivateAppointments.Confirm(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-3089895d205a)；[`NationalSpire.PrivateAppointments.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>, string)`](PrivateAppointments.cs.md#symbol-32d5ee024249)；[`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)；[`NationalSpire.PrivateMessages.PrepareAttachments(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>)`](PrivateMessages.cs.md#symbol-f2d6d9cf9c86)

**调用：** [`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；[`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；[`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-12bdfe5d4265)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Season`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Ascension`；`NationalSpire.PrivateOffer.Day`；`NationalSpire.PrivateOffer.Mode`；`NationalSpire.PrivateOffer.Season`；`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`Date(data, offer)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Date(data, offer)`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(data, person)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateMessages.CanChat(data, person)`
- `NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Length(data, offer.Season)`；返回值紧邻使用处：`BinaryExpressionSyntax: offer.Day > SeasonCalendar.Length(data, offer.Season)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3089895d205a"></a>

## `NationalSpire.PrivateAppointments.Confirm(NationalSpire.CareerData, string, NationalSpire.PrivateOffer) — public static string? Confirm(CareerData data, string person, PrivateOffer offer)`

来源：源码第 80 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.ConfirmPrivateMatch(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopProposal)`](Coop/CoopPrivateMessages.cs.md#symbol-ec0e4056cf90)；[`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.PrivateAppointments.Cancel(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-02dfe1ba8dd5)；[`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；[`NationalSpire.PrivateAppointments.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-e7f8b7355ddf)；[`NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool)`](PrivateInteractionUndo.cs.md#symbol-de9e985d044d)；[`NationalSpire.PrivateInteractionHistory.Record(NationalSpire.CareerData, string, NationalSpire.PrivateTurn, System.Text.Json.Nodes.JsonObject, bool)`](PrivateInteractionUndo.cs.md#symbol-9eda496612ca)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`NationalSpire.CareerMatch.CareerMatch()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Matches`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerMatch.Event`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.Prize`；`NationalSpire.CareerMatch.Registered`；`NationalSpire.CareerMatch.RequiredAscension`；`NationalSpire.PrivateAppointments.Cancel(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateAppointments.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool)`；`NationalSpire.PrivateInteractionHistory.Record(NationalSpire.CareerData, string, NationalSpire.PrivateTurn, System.Text.Json.Nodes.JsonObject, bool)`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Ascension`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.MatchId`；`NationalSpire.PrivateOffer.Mode`；`NationalSpire.PrivateOffer.ReplacesOfferId`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.TurnId`；`NationalSpire.PrivateTurn.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, person)`；返回值紧邻使用处：`BinaryExpressionSyntax: "私信" + offer.Mode + " · " + CareerEngine.DisplayName(data, person)`
- `NationalSpire.CareerMatch.CareerMatch()`；输入表达式：`new CareerMatch { Day = Date(data, offer), Event = "私信" + offer.Mode + " · " + CareerEngine.DisplayName(data, person), OpponentId = person,              Kind = offer.Mode == "挑战" ? "private-challenge" : "private-friendly", RequiredAscension = offer.Ascension, Registered = true, Prize = 0 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CareerMatch { Day = Date(data, offer), Event = "私信" + offer.Mode + " · " + CareerEngine.DisplayName(data, person), OpponentId = person,              Kind = offer.Mode == "挑战" ? "private-challenge" : "private-friendly", RequiredAscension = offer.Ascension, Registered = true, Prize = 0 }`
- `NationalSpire.PrivateAppointments.Cancel(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`Cancel(data, previous)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Cancel(data, previous) is { } cancellationError`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`Date(data, offer)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Day = Date(data, offer)`
- `NationalSpire.PrivateAppointments.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；输入表达式：`Error(data, person, offer)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Error(data, person, offer) is { } error`
- `NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool)`；输入表达式：`PrivateInteractionHistory.Capture(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateInteractionHistory.Capture(data, person)`
- `NationalSpire.PrivateInteractionHistory.Record(NationalSpire.CareerData, string, NationalSpire.PrivateTurn, System.Text.Json.Nodes.JsonObject, bool)`；输入表达式：`PrivateInteractionHistory.Record(data, person, turn, before)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateInteractionHistory.Record(data, person, turn, before);`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(data, person).Offers`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(data, person).Turns`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Conversation(data, person).Offers.FirstOrDefault(o => o.Id == offer.ReplacesOfferId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Conversation(data, person).Offers.FirstOrDefault(o => o.Id == offer.ReplacesOfferId)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Conversation(data, person).Turns.FirstOrDefault(t => t.Id == offer.TurnId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: PrivateMessages.Conversation(data, person).Turns.FirstOrDefault(t => t.Id == offer.TurnId) is { } turn`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`data.Matches.Add(match)`；返回值紧邻使用处：`ExpressionStatementSyntax: data.Matches.Add(match);`

**赋值（含属性/字段和局部值）：**

- `Day` = `Date(data, offer)`
- `Event` = `"私信" + offer.Mode + " · " + CareerEngine.DisplayName(data, person)`
- `Kind` = `offer.Mode == "挑战" ? "private-challenge" : "private-friendly"`
- `offer.MatchId` = `match.Id`
- `offer.State` = `"已确认"`
- `OpponentId` = `person`
- `Prize` = `0`
- `Registered` = `true`
- `RequiredAscension` = `offer.Ascension`

<a id="symbol-32d5ee024249"></a>

## `NationalSpire.PrivateAppointments.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>, string) — public static void Respond(CareerData data, PrivateConversation c, PrivateTurn turn, Dictionary<string, string> fields, string action)`

来源：源码第 97 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`](PrivateMessages.cs.md#symbol-7bf623828ccc)

**调用：** [`NationalSpire.PrivateAppointments.Cancel(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-02dfe1ba8dd5)；[`NationalSpire.PrivateAppointments.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-e7f8b7355ddf)；[`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-0f707d2c9895)；[`Read(string, int)`](PrivateAppointments.cs.md#symbol-5360f69585d5)；`NationalSpire.PrivateOffer.PrivateOffer()`；`string.IsNullOrWhiteSpace(string?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Season`；`NationalSpire.PrivateAppointments.Cancel(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateAppointments.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateOffer.Ascension`；`NationalSpire.PrivateOffer.Day`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Mode`；`NationalSpire.PrivateOffer.ReplacesOfferId`；`NationalSpire.PrivateOffer.ResponseAction`；`NationalSpire.PrivateOffer.Season`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.TurnId`；`NationalSpire.PrivateTurn.Attachments`；`NationalSpire.PrivateTurn.Error`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.Request`；`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`；`Read(string, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateAppointments.Cancel(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`Cancel(data, previous)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Cancel(data, previous) is { } error`
- `NationalSpire.PrivateAppointments.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；输入表达式：`Error(data, c.PersonId, offer)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Error(data, c.PersonId, offer) is { } invalid`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new PrivateOffer { Kind = "match", ResponseAction = action, TurnId = turn.Id,              Season = Read("Season", basis?.Season ?? data.Season), Day = Read("Day", basis?.Day ?? SeasonCalendar.Day(data, data.Day)),              Ascension = Read("Ascension", 0), Mode = string.IsNullOrWhiteSpace(fields.GetValueOrDefault("Mode")) ? "切磋" : fields["Mode"] }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new PrivateOffer { Kind = "match", ResponseAction = action, TurnId = turn.Id,              Season = Read("Season", basis?.Season ?? data.Season), Day = Read("Day", basis?.Day ?? SeasonCalendar.Day(data, data.Day)),              Ascension = Read("Ascension", 0), Mode = string.IsNullOrWhiteSpace(fields.GetValueOrDefault("Mode")) ? "切磋" : fields["Mode"] }`
- `NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Day(data, data.Day)`；返回值紧邻使用处：`BinaryExpressionSyntax: basis?.Day ?? SeasonCalendar.Day(data, data.Day)`
- `Read(string, int)`；输入表达式：`Read("Ascension", 0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Ascension = Read("Ascension", 0)`
- `Read(string, int)`；输入表达式：`Read("Day", -1)`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Day == Read("Day", -1)`
- `Read(string, int)`；输入表达式：`Read("Day", a.Day)`；返回值紧邻使用处：`BinaryExpressionSyntax: a.Day == Read("Day", a.Day)`
- `Read(string, int)`；输入表达式：`Read("Day", basis?.Day ?? SeasonCalendar.Day(data, data.Day))`；返回值紧邻使用处：`AssignmentExpressionSyntax: Day = Read("Day", basis?.Day ?? SeasonCalendar.Day(data, data.Day))`
- `Read(string, int)`；输入表达式：`Read("Season", -1)`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Season == Read("Season", -1)`
- `Read(string, int)`；输入表达式：`Read("Season", a.Season)`；返回值紧邻使用处：`BinaryExpressionSyntax: a.Season == Read("Season", a.Season)`
- `Read(string, int)`；输入表达式：`Read("Season", basis?.Season ?? data.Season)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Season = Read("Season", basis?.Season ?? data.Season)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(fields.GetValueOrDefault("Mode"))`；返回值紧邻使用处：`ConditionalExpressionSyntax: string.IsNullOrWhiteSpace(fields.GetValueOrDefault("Mode")) ? "切磋" : fields["Mode"]`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`fields.ContainsKey("Day")`；返回值紧邻使用处：`IfStatementSyntax: if (fields.ContainsKey("Day")) previous = active.LastOrDefault(o => o.Season == offer.Season && o.Day == offer.Day);`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`active.LastOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: active.LastOrDefault(o => o.Season == Read("Season", -1) && o.Day == Read("Day", -1)) ?? active.LastOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`active.LastOrDefault(o => o.Season == offer.Season && o.Day == offer.Day && o.Ascension == offer.Ascension && o.Mode == offer.Mode)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = active.LastOrDefault(o => o.Season == offer.Season && o.Day == offer.Day && o.Ascension == offer.Ascension && o.Mode == offer.Mode)`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`active.LastOrDefault(o => o.Season == offer.Season && o.Day == offer.Day)`；返回值紧邻使用处：`AssignmentExpressionSyntax: previous = active.LastOrDefault(o => o.Season == offer.Season && o.Day == offer.Day)`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`active.LastOrDefault(o => o.Season == Read("Season", -1) && o.Day == Read("Day", -1))`；返回值紧邻使用处：`BinaryExpressionSyntax: active.LastOrDefault(o => o.Season == Read("Season", -1) && o.Day == Read("Day", -1)) ?? active.LastOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`active.LastOrDefault(o => o.Season == request.Season && o.Day == request.Day && o.Ascension == request.Ascension && o.Mode == request.Mode)`；返回值紧邻使用处：`AssignmentExpressionSyntax: previous = active.LastOrDefault(o => o.Season == request.Season && o.Day == request.Day && o.Ascension == request.Ascension && o.Mode == request.Mode)`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`turn.Attachments.LastOrDefault(a => a.Kind == "match" && a.Season == Read("Season", a.Season) && a.Day == Read("Day", a.Day))`；返回值紧邻使用处：`BinaryExpressionSyntax: turn.Attachments.LastOrDefault(a => a.Kind == "match" && a.Season == Read("Season", a.Season) && a.Day == Read("Day", a.Day))              ?? turn.Attachments.LastOrDefault(a => a.Kind == "match") ?? (turn.Request?.Kind == "match" ? turn.Request : null)`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`turn.Attachments.LastOrDefault(a => a.Kind == "match")`；返回值紧邻使用处：`BinaryExpressionSyntax: turn.Attachments.LastOrDefault(a => a.Kind == "match") ?? (turn.Request?.Kind == "match" ? turn.Request : null)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`c.Offers.Where(o => o.Kind == "match" && o.State is "待确认" or "已确认").ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Offers.Where(o => o.Kind == "match" && o.State is "待确认" or "已确认").ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Offers.Where(o => o.Kind == "match" && o.State is "待确认" or "已确认")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Offers.Where(o => o.Kind == "match" && o.State is "待确认" or "已确认").ToList`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`fields.GetValueOrDefault("Mode")`；返回值紧邻使用处：`ArgumentSyntax: fields.GetValueOrDefault("Mode")`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.Offers.Add(offer)`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Offers.Add(offer);`

**赋值（含属性/字段和局部值）：**

- `action` = `"邀请"`
- `Ascension` = `Read("Ascension", 0)`
- `Day` = `Read("Day", basis?.Day ?? SeasonCalendar.Day(data, data.Day))`
- `Kind` = `"match"`
- `Mode` = `string.IsNullOrWhiteSpace(fields.GetValueOrDefault("Mode")) ? "切磋" : fields["Mode"]`
- `offer.Detail` = `invalid`
- `offer.ReplacesOfferId` = `previous.Id`
- `offer.State` = `"无效"`
- `offer.State` = `"已拒绝"`
- `previous.State` = `"已改期"`
- `previous.State` = `"已拒绝"`
- `previous` = `active.LastOrDefault(o => o.Season == offer.Season && o.Day == offer.Day)`
- `previous` = `active.LastOrDefault(o => o.Season == request.Season && o.Day == request.Day && o.Ascension == request.Ascension && o.Mode == request.Mode)`
- `ResponseAction` = `action`
- `same.ResponseAction` = `action`
- `Season` = `Read("Season", basis?.Season ?? data.Season)`
- `turn.Error` += `"\n" + error`
- `TurnId` = `turn.Id`

<a id="symbol-5360f69585d5"></a>

## `Read(string, int) — int Read(string key, int fallback)`

来源：源码第 100 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateAppointments.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>, string)`](PrivateAppointments.cs.md#symbol-32d5ee024249)

**调用：** `int.TryParse(string?, out int)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.TryParse(string?, out int)`；输入表达式：`int.TryParse(fields.GetValueOrDefault(key), out int value)`；返回值紧邻使用处：`ConditionalExpressionSyntax: int.TryParse(fields.GetValueOrDefault(key), out int value) ? value : fallback`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`fields.GetValueOrDefault(key)`；返回值紧邻使用处：`ArgumentSyntax: fields.GetValueOrDefault(key)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-02dfe1ba8dd5"></a>

## `NationalSpire.PrivateAppointments.Cancel(NationalSpire.CareerData, NationalSpire.PrivateOffer) — public static string? Cancel(CareerData data, PrivateOffer offer)`

来源：源码第 135 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Coop.CoopRules.ConfirmPrivateMatch(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopProposal)`](Coop/CoopPrivateMessages.cs.md#symbol-ec0e4056cf90)；[`NationalSpire.PrivateAppointments.Confirm(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-3089895d205a)；[`NationalSpire.PrivateAppointments.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>, string)`](PrivateAppointments.cs.md#symbol-32d5ee024249)；[`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Registered`；`NationalSpire.CareerMatch.Status`；`NationalSpire.PrivateOffer.MatchId`；`NationalSpire.PrivateOffer.State`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.FirstOrDefault(m => m.Id == offer.MatchId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = data.Matches.FirstOrDefault(m => m.Id == offer.MatchId)`

**赋值（含属性/字段和局部值）：**

- `match.Registered` = `false`
- `match.Status` = `"已取消"`
- `offer.State` = `"已取消"`

<a id="symbol-32f6566791d2"></a>

## `NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch) — public static bool IsPrivate(CareerMatch match)`

来源：源码第 145 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.FinishMatch(NationalSpire.CareerData, NationalSpire.CareerMatch, bool, bool, int, string, int, System.Collections.Generic.List<string>, double, System.Collections.Generic.List<string>?, NationalSpire.RunEvidence?, string, bool, bool)`](CareerEngine.cs.md#symbol-2cb7c2afebf9)；[`NationalSpire.CharacterDeletion.Delete(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-2eb70f838afa)；[`NationalSpire.ClubCoaching.Scheduled(NationalSpire.CareerData, string)`](ClubCoaching.cs.md#symbol-4f8141b24cff)；[`NationalSpire.Coop.CoopRules.Settle(NationalSpire.Coop.CoopWorld, string, bool, bool, int, double, System.Collections.Generic.List<NationalSpire.Coop.CoopLivePlayer>, System.Collections.Generic.Dictionary<ulong, NationalSpire.CareerResult>?, bool, bool)`](Coop/CoopRules.cs.md#symbol-ad906fb9e519)；[`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`](EsportsWorld.cs.md#symbol-4b9f3e1bf70a)；[`NationalSpire.NpcRecords.RecordPrivateClear(NationalSpire.CareerData, NationalSpire.CareerMatch)`](NpcRecords.cs.md#symbol-43e8a659d2a2)；[`NationalSpire.NpcRecords.RestorePrivateClears(NationalSpire.CareerData)`](NpcRecords.cs.md#symbol-09ad91cd55b4)；[`NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool)`](PrivateInteractionUndo.cs.md#symbol-de9e985d044d)；[`NationalSpire.PrivateInteractionHistory.Restore(NationalSpire.CareerData, string, System.Text.Json.Nodes.JsonObject, bool)`](PrivateInteractionUndo.cs.md#symbol-dd91210e87c0)；[`NationalSpire.PrivateInteractionHistory.Rewind(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn)`](PrivateInteractionUndo.cs.md#symbol-f2cc1906a6b6)；[`Save(NationalSpire.CareerData)`](Coop/CoopPrivateMessages.cs.md#symbol-d510c10d173d)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerMatch.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-31b52db37f88"></a>

## `NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerResult) — public static bool IsPrivate(CareerResult result)`

来源：源码第 146 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerMigration.UpgradeRules(NationalSpire.CareerData)`](CareerMigration.cs.md#symbol-94c0855d9c16)；[`NationalSpire.EsportsWorld.Initialize(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-ca5840a56e8d)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerResult.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3c22aa703fb0"></a>

## `NationalSpire.PrivateContracts.Guidance(NationalSpire.CareerData, NationalSpire.CareerPerson) — public static string Guidance(CareerData data, CareerPerson p)`

来源：源码第 151 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.PrivateMessagePrompts.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-4b9d12b26f65)

**调用：** [`NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`](OwnedClubs.cs.md#symbol-6507b91ba56b)；[`NationalSpire.OwnedClubs.TransferFee(NationalSpire.CareerPerson)`](OwnedClubs.cs.md#symbol-35a81fabab41)；[`NationalSpire.OwnedClubs.TransferReserved(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-fda6cea8331b)；[`NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-13f25fec3dea)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`；`NationalSpire.OwnedClubs.TransferFee(NationalSpire.CareerPerson)`；`NationalSpire.OwnedClubs.TransferReserved(NationalSpire.CareerData, string)`；`NationalSpire.OwnedPlayerContract.Signing`；`NationalSpire.OwnedPlayerContract.Wage`；`NationalSpire.OwnedPlayerContract.WinBonus`；`NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`；输入表达式：`OwnedClubs.Quote(p, "steady")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = OwnedClubs.Quote(p, "steady")`
- `NationalSpire.OwnedClubs.TransferFee(NationalSpire.CareerPerson)`；输入表达式：`OwnedClubs.TransferFee(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: OwnedClubs.TransferFee(p) * 10`
- `NationalSpire.OwnedClubs.TransferReserved(NationalSpire.CareerData, string)`；输入表达式：`OwnedClubs.TransferReserved(data, p.Id)`；返回值紧邻使用处：`IfStatementSyntax: if (OwnedClubs.TransferReserved(data, p.Id)) return $"{p.PublicName}已经签订加盟合同，具体条款和加盟时间见当前资料。";`
- `NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Favour(data, p.Id)`；返回值紧邻使用处：`InterpolationSyntax: {PrivateMessages.Favour(data, p.Id)}`

**赋值（含属性/字段和局部值）：**


<a id="symbol-dbd791b573e7"></a>

## `NationalSpire.PrivateContracts.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer) — public static string? Error(CareerData data, string person, PrivateOffer offer)`

来源：源码第 159 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateContracts.Confirm(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, string)`](PrivateAppointments.cs.md#symbol-1c0ddcc69a05)；[`NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`](PrivateMessages.cs.md#symbol-7bf623828ccc)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-871ad0e2a2c9)；[`NationalSpire.OwnedClubs.SigningError(NationalSpire.CareerData, NationalSpire.ClubSigning, bool)`](OwnedClubs.cs.md#symbol-e45e226b122d)；[`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；`NationalSpire.ClubSigning.ClubSigning()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.ClubSigning.PersonId`；`NationalSpire.ClubSigning.Plan`；`NationalSpire.ClubSigning.Position`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.SigningError(NationalSpire.CareerData, NationalSpire.ClubSigning, bool)`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Role`；`NationalSpire.PrivateOffer.Weeks`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, person)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Person(data, person)`
- `NationalSpire.ClubSigning.ClubSigning()`；输入表达式：`new() { PersonId = person, Plan = "steady", Position = offer.Role }`；返回值紧邻使用处：`ArgumentSyntax: new() { PersonId = person, Plan = "steady", Position = offer.Role }`
- `NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.CanOperate(data)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !OwnedClubs.CanOperate(data)`
- `NationalSpire.OwnedClubs.SigningError(NationalSpire.CareerData, NationalSpire.ClubSigning, bool)`；输入表达式：`OwnedClubs.SigningError(data, new() { PersonId = person, Plan = "steady", Position = offer.Role }, p.ClubId.Length > 0)`；返回值紧邻使用处：`ReturnStatementSyntax: return OwnedClubs.SigningError(data, new() { PersonId = person, Plan = "steady", Position = offer.Role }, p.ClubId.Length > 0);`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(data, person)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateMessages.CanChat(data, person)`

**赋值（含属性/字段和局部值）：**

- `PersonId` = `person`
- `Plan` = `"steady"`
- `Position` = `offer.Role`

<a id="symbol-1c0ddcc69a05"></a>

## `NationalSpire.PrivateContracts.Confirm(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, string) — public static string? Confirm(CareerData data, string person, PrivateOffer offer, string replacement)`

来源：源码第 167 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.OwnedClubs.ArrangeTransfer(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-66be5c09e822)；[`NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`](OwnedClubs.cs.md#symbol-6507b91ba56b)；[`NationalSpire.OwnedClubs.Recruit(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-bad0a27b1a6b)；[`NationalSpire.PrivateContracts.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-dbd791b573e7)；[`NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool)`](PrivateInteractionUndo.cs.md#symbol-de9e985d044d)；[`NationalSpire.PrivateInteractionHistory.Record(NationalSpire.CareerData, string, NationalSpire.PrivateTurn, System.Text.Json.Nodes.JsonObject, bool)`](PrivateInteractionUndo.cs.md#symbol-9eda496612ca)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；`NationalSpire.ClubSigning.ClubSigning()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.ClubSigning.PersonId`；`NationalSpire.ClubSigning.Plan`；`NationalSpire.ClubSigning.Position`；`NationalSpire.ClubSigning.ReplaceId`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.ArrangeTransfer(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`；`NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`；`NationalSpire.OwnedClubs.Recruit(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`；`NationalSpire.OwnedClubState.Transfers`；`NationalSpire.OwnedPlayerContract.Days`；`NationalSpire.OwnedPlayerContract.PersonId`；`NationalSpire.OwnedPlayerContract.Signing`；`NationalSpire.OwnedPlayerContract.Wage`；`NationalSpire.OwnedPlayerContract.WinBonus`；`NationalSpire.OwnedTransfer.Arrived`；`NationalSpire.OwnedTransfer.Contract`；`NationalSpire.OwnedTransfer.SourceHumanId`；`NationalSpire.OwnedTransfer.SourceTurnId`；`NationalSpire.PrivateContracts.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool)`；`NationalSpire.PrivateInteractionHistory.Record(NationalSpire.CareerData, string, NationalSpire.PrivateTurn, System.Text.Json.Nodes.JsonObject, bool)`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Role`；`NationalSpire.PrivateOffer.Signing`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.TurnId`；`NationalSpire.PrivateOffer.Wage`；`NationalSpire.PrivateOffer.Weeks`；`NationalSpire.PrivateOffer.WinBonus`；`NationalSpire.PrivateTurn.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, person)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(data, person)!`
- `NationalSpire.ClubSigning.ClubSigning()`；输入表达式：`new ClubSigning { PersonId = person, Plan = "steady", Position = offer.Role, ReplaceId = replacement }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new ClubSigning { PersonId = person, Plan = "steady", Position = offer.Role, ReplaceId = replacement }`
- `NationalSpire.OwnedClubs.ArrangeTransfer(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`；输入表达式：`OwnedClubs.ArrangeTransfer(data, signing, terms)`；返回值紧邻使用处：`ConditionalExpressionSyntax: p.ClubId.Length > 0 ? OwnedClubs.ArrangeTransfer(data, signing, terms) : OwnedClubs.Recruit(data, signing, terms)`
- `NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`；输入表达式：`OwnedClubs.Quote(p, "steady")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = OwnedClubs.Quote(p, "steady")`
- `NationalSpire.OwnedClubs.Recruit(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`；输入表达式：`OwnedClubs.Recruit(data, signing, terms)`；返回值紧邻使用处：`ConditionalExpressionSyntax: p.ClubId.Length > 0 ? OwnedClubs.ArrangeTransfer(data, signing, terms) : OwnedClubs.Recruit(data, signing, terms)`
- `NationalSpire.PrivateContracts.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；输入表达式：`Error(data, person, offer)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Error(data, person, offer) is { } error`
- `NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool)`；输入表达式：`PrivateInteractionHistory.Capture(data, person, true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateInteractionHistory.Capture(data, person, true)`
- `NationalSpire.PrivateInteractionHistory.Record(NationalSpire.CareerData, string, NationalSpire.PrivateTurn, System.Text.Json.Nodes.JsonObject, bool)`；输入表达式：`PrivateInteractionHistory.Record(data, person, turn, before, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateInteractionHistory.Record(data, person, turn, before, true);`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(data, person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(data, person).Turns`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Conversation(data, person).Turns.FirstOrDefault(t => t.Id == offer.TurnId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: PrivateMessages.Conversation(data, person).Turns.FirstOrDefault(t => t.Id == offer.TurnId) is { } turn`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Esports.OwnedClub!.Transfers.LastOrDefault(t => !t.Arrived && t.Contract.PersonId == person)`；返回值紧邻使用处：`IsPatternExpressionSyntax: data.Esports.OwnedClub!.Transfers.LastOrDefault(t => !t.Arrived && t.Contract.PersonId == person) is { } transfer`

**赋值（含属性/字段和局部值）：**

- `offer.State` = `"已确认"`
- `PersonId` = `person`
- `Plan` = `"steady"`
- `Position` = `offer.Role`
- `ReplaceId` = `replacement`
- `terms.Days` = `offer.Weeks * 7`
- `terms.Signing` = `offer.Signing / 10m`
- `terms.Wage` = `offer.Wage / 10m`
- `terms.WinBonus` = `offer.WinBonus / 10m`
- `transfer.SourceHumanId` = `data.LocalHumanId`
- `transfer.SourceTurnId` = `offer.TurnId`
