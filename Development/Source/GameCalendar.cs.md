# GameCalendar.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`459A491BE43A7C521F43CBBC16D581D78DED5D68CBF21E4071F3A66D9ECBD1A2`。来源：[源码](../../GameCalendar.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.GameCalendar`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-006ea3a9bcad"></a>

## `NationalSpire.GameCalendar.Initialize(NationalSpire.CareerData) — public static bool Initialize(CareerData data)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.NormalizeRoster(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-eb11b96e7400)；[`NationalSpire.CareerLibrary.Create(string, NationalSpire.CareerData)`](CareerLibrary.cs.md#symbol-bb2b0ce2be9d)；[`NationalSpire.Coop.CoopCoordinator.CoopCoordinator(NationalSpire.Coop.ICoopTransport, NationalSpire.Coop.CoopStorage, string, string, string, System.Collections.Generic.IReadOnlySet<string>, NationalSpire.Coop.CoopStorage.Checkpoint?)`](Coop/CoopCoordinator.cs.md#symbol-778097f34ec3)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.CalendarStartYear`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `data.CalendarStartYear` = `DateTime.Now.Year`

<a id="symbol-44ea23440cd8"></a>

## `NationalSpire.GameCalendar.Epoch(NationalSpire.CareerData) — private static DateOnly Epoch(CareerData data)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-8a08be365f83)；[`NationalSpire.GameCalendar.Day(NationalSpire.CareerData, System.DateOnly)`](GameCalendar.cs.md#symbol-c755526e8036)

**调用：** `System.DateOnly.DateOnly(int, int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.CalendarStartYear`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.DateOnly.DateOnly(int, int, int)`；输入表达式：`new(data.CalendarStartYear == 0 ? DateTime.Now.Year : data.CalendarStartYear, 1, 1)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new(data.CalendarStartYear == 0 ? DateTime.Now.Year : data.CalendarStartYear, 1, 1)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8a08be365f83"></a>

## `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int) — public static DateOnly Date(CareerData data, int day)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddFixtureRow(NationalSpire.CareerData, NationalSpire.CareerScreen.FixtureEntry, Godot.VBoxContainer, bool)`](FixtureScheduleScreen.cs.md#symbol-237327497b3f)；[`NationalSpire.CareerScreen.AddLedgerTable(Godot.VBoxContainer, NationalSpire.CareerData, System.Collections.Generic.IReadOnlyList<NationalSpire.FinanceEntry>, int)`](CareerBoardsScreen.cs.md#symbol-efdf49030123)；[`NationalSpire.CareerScreen.AgendaEntry(NationalSpire.CareerData, Godot.VBoxContainer, NationalSpire.CareerScreen.AgendaItem)`](CalendarPlansScreen.cs.md#symbol-d4b6dfb814ed)；[`NationalSpire.CareerScreen.AgendaRange(NationalSpire.CareerData, int, int)`](CalendarPlansScreen.cs.md#symbol-9c53a348d954)；[`NationalSpire.CareerScreen.AppointmentCalendar(NationalSpire.CareerData, int, System.Collections.Generic.IEnumerable<string>, int, System.Action<int>)`](AppointmentCalendarScreen.cs.md#symbol-b5cb4cb371f4)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)；[`NationalSpire.CareerScreen.MatchArena(NationalSpire.CareerData, string, string, string, string, string, Godot.Color, out Godot.HBoxContainer, int, System.Action?, string?, string?, string)`](MatchArenaScreen.cs.md#symbol-c382a00cf2e6)；[`NationalSpire.CareerScreen.OpenCalendarDay(int)`](CalendarPlansScreen.cs.md#symbol-d6b7c872ea02)；[`NationalSpire.CareerScreen.PlanPane(NationalSpire.CareerData, Godot.VBoxContainer, Godot.ScrollContainer, System.Collections.Generic.List<NationalSpire.CareerScreen.CalendarPlan>, NationalSpire.CalendarDayButton[])`](CalendarPlansScreen.cs.md#symbol-078c4f908d4c)；[`NationalSpire.CareerScreen.RosterMember(NationalSpire.CareerData, NationalSpire.OwnedClubState, Godot.VBoxContainer, string, string, bool)`](ClubRosterScreen.cs.md#symbol-8191d4b2f80f)；[`NationalSpire.CareerScreen.TeamPreparationPlans(NationalSpire.CareerData)`](CalendarPlansScreen.cs.md#symbol-a5b07c06671a)；[`NationalSpire.CareerScreen.UpdateHeaderAccount(NationalSpire.CareerData)`](CareerDashboard.cs.md#symbol-52ec8ee2b3ad)；[`NationalSpire.GameCalendar.Iso(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-baf7d6edae6c)；[`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)；[`NationalSpire.MarketChart._Draw()`](MarketTerminal.cs.md#symbol-b9c7f00ce2d0)

**调用：** [`NationalSpire.GameCalendar.Epoch(NationalSpire.CareerData)`](GameCalendar.cs.md#symbol-44ea23440cd8)；`System.DateOnly.AddDays(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.GameCalendar.Epoch(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GameCalendar.Epoch(NationalSpire.CareerData)`；输入表达式：`Epoch(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Epoch(data).AddDays`
- `System.DateOnly.AddDays(int)`；输入表达式：`Epoch(data).AddDays(day - 1)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Epoch(data).AddDays(day - 1)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c755526e8036"></a>

## `NationalSpire.GameCalendar.Day(NationalSpire.CareerData, System.DateOnly) — public static int Day(CareerData data, DateOnly date)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.GameCalendar.TryDay(NationalSpire.CareerData, string?, out int)`](GameCalendar.cs.md#symbol-ca512729a156)

**调用：** [`NationalSpire.GameCalendar.Epoch(NationalSpire.CareerData)`](GameCalendar.cs.md#symbol-44ea23440cd8)

**字段、属性、事件及方法组引用：** `NationalSpire.GameCalendar.Epoch(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GameCalendar.Epoch(NationalSpire.CareerData)`；输入表达式：`Epoch(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Epoch(data).DayNumber`

**赋值（含属性/字段和局部值）：**


<a id="symbol-eb37c8a67b51"></a>

## `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int) — public static string Text(CareerData data, int day)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`AddScore(int)`](SettlementScreen.cs.md#symbol-3636f8db239a)；[`Calendar()`](ConsumerPickerScreen.cs.md#symbol-23c01045c057)；[`Calendar()`](PrivateMessageScreen.cs.md#symbol-0868430bed16)；[`NationalSpire.AiService.SummarizePrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string)`](AiPrivateMessages.cs.md#symbol-198521296d15)；[`NationalSpire.AiService.TestSources(NationalSpire.CareerData, string)`](PromptTesting.cs.md#symbol-bac6770dfaa1)；[`NationalSpire.CareerEngine.PublishMatchDay(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-1e1428a365f6)；[`NationalSpire.CareerEngine.WorldActivity(NationalSpire.CareerData, System.Random)`](CareerEngine.cs.md#symbol-03d4a3e5e0cd)；[`NationalSpire.CareerLibrary.List(string)`](CareerLibrary.cs.md#symbol-49ca8927a7b3)；[`NationalSpire.CareerLife.Accept(NationalSpire.CareerData, string, string)`](CareerLife.cs.md#symbol-cce5ea9d3250)；[`NationalSpire.CareerLife.PublishPending(NationalSpire.CareerData, bool, string)`](CareerLife.cs.md#symbol-1c0521dc0643)；[`NationalSpire.CareerScreen.AddCompletedDateCard(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](DateDiaryScreen.cs.md#symbol-0154b9cfbb28)；[`NationalSpire.CareerScreen.AddFixtureRow(NationalSpire.CareerData, NationalSpire.CareerScreen.FixtureEntry, Godot.VBoxContainer, bool)`](FixtureScheduleScreen.cs.md#symbol-237327497b3f)；[`NationalSpire.CareerScreen.AddPostCard(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.Container)`](CareerScreen.cs.md#symbol-ce65b4128fee)；[`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.AppointmentCalendar(NationalSpire.CareerData, int, System.Collections.Generic.IEnumerable<string>, int, System.Action<int>)`](AppointmentCalendarScreen.cs.md#symbol-b5cb4cb371f4)；[`NationalSpire.CareerScreen.BracketDetails(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, System.Collections.Generic.List<NationalSpire.WorldFixture>, int)`](FixtureScheduleScreen.cs.md#symbol-1daead3fab8e)；[`NationalSpire.CareerScreen.ClubSummary(NationalSpire.CareerData, NationalSpire.CareerClub, Godot.Container)`](CareerWorldScreen.cs.md#symbol-119e71d5db33)；[`NationalSpire.CareerScreen.Competition(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CareerWorldScreen.cs.md#symbol-35113b1f49bd)；[`NationalSpire.CareerScreen.CompetitionOverview(NationalSpire.CareerData, NationalSpire.CompetitionReview)`](SettlementScreen.cs.md#symbol-f0fb4e109457)；[`NationalSpire.CareerScreen.ConsumerAttachmentConfirmation(NationalSpire.ConsumerComposer, NationalSpire.PrivateOffer, System.Action?)`](ConsumerCommerceScreen.cs.md#symbol-f3a03a858f88)；[`NationalSpire.CareerScreen.ConsumerDetail(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.ConsumerPurchases, Godot.VBoxContainer)`](ConsumerScreen.cs.md#symbol-d0b5fafc7e7c)；[`NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`](ConsumerPickerScreen.cs.md#symbol-0f5d28176960)；[`NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`](DateDiaryScreen.cs.md#symbol-fb4ba1a3b5fa)；[`NationalSpire.CareerScreen.DevelopmentScreen(NationalSpire.CareerData)`](DevelopmentScreen.cs.md#symbol-2d48676d5e88)；[`NationalSpire.CareerScreen.EventCards(NationalSpire.CareerData, Godot.VBoxContainer, int)`](RandomEventScreen.cs.md#symbol-e27dca18c72a)；[`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`](GroupChatScreen.cs.md#symbol-3afa41099b93)；[`NationalSpire.CareerScreen.Honors(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-fd656e0e98e6)；[`NationalSpire.CareerScreen.InternationalBracket(NationalSpire.CareerData, NationalSpire.WorldCompetition, Godot.HBoxContainer)`](FixtureScheduleScreen.cs.md#symbol-992db6cc73f9)；[`NationalSpire.CareerScreen.JourneyResumeButton(NationalSpire.CareerData, Godot.VBoxContainer)`](EventJourneyScreen.cs.md#symbol-a869d888b335)；[`NationalSpire.CareerScreen.LifeCollection(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-7fd7cd27279c)；[`NationalSpire.CareerScreen.LifeNews(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-825caeb63a3b)；[`NationalSpire.CareerScreen.ModernCompetition(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CircuitScreen.cs.md#symbol-6edbcc2815f7)；[`NationalSpire.CareerScreen.OpenCareerLibrary()`](CareerLibraryScreen.cs.md#symbol-57e1d5f83960)；[`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)；[`NationalSpire.CareerScreen.PrivateSharePicker(string)`](PrivateMemoryScreen.cs.md#symbol-b8d901a6cb80)；[`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-1799ee450143)；[`NationalSpire.CareerScreen.RenderPostHeader(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-4c514e4927ad)；[`NationalSpire.CareerScreen.Settlement(NationalSpire.CareerData)`](SettlementScreen.cs.md#symbol-ec46df6667fd)；[`NationalSpire.CareerScreen.ShowJourneyEncounter()`](EventJourneyScreen.cs.md#symbol-4e94d6a77974)；[`NationalSpire.ChatTimeline.PrivateHistory(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?)`](ChatTimeline.cs.md#symbol-4c7ee0ce6871)；[`NationalSpire.ChatTimeline.PublicMemory(NationalSpire.CareerData, NationalSpire.GroupChat, string, int)`](ChatTimeline.cs.md#symbol-6c6e8fc3c1d7)；[`NationalSpire.ChatTranscript.Markdown(NationalSpire.CareerData, NationalSpire.ChatTranscript.Document)`](ChatTranscript.cs.md#symbol-1d0d44b593e7)；[`NationalSpire.ClubOperations.Advance(NationalSpire.CareerData)`](ClubOperations.cs.md#symbol-213a7e731998)；[`NationalSpire.Coop.CoopRules.AdvanceMembers(NationalSpire.Coop.CoopWorld)`](Coop/CoopRules.cs.md#symbol-bc24477e89ba)；[`NationalSpire.Coop.CoopRules.PrivateCommand(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.Coop.CoopCommand)`](Coop/CoopPrivateMessages.cs.md#symbol-d33f4b1ffce8)；[`NationalSpire.Coop.CoopRules.ProposalLabel(NationalSpire.Coop.CoopWorld, string, string, int)`](Coop/CoopRules.cs.md#symbol-c3d56826da72)；[`NationalSpire.Coop.CoopScreen.Entrance()`](Coop/CoopScreen.cs.md#symbol-ef98f9c7ba09)；[`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`](EsportsWorld.cs.md#symbol-4b9f3e1bf70a)；[`NationalSpire.EsportsWorld.NextGoal(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-469e0396c2c6)；[`NationalSpire.EventStoryView.Display(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.EventLive?, bool)`](RandomEventScreen.cs.md#symbol-f847e9f29b0e)；[`NationalSpire.GameCalendar.Range(NationalSpire.CareerData, int, int)`](GameCalendar.cs.md#symbol-57fa2dd71e81)；[`NationalSpire.GroupChatPrompts.InteractionContext(NationalSpire.CareerData, NationalSpire.GroupChat, int, string, string)`](GroupChatPrompts.cs.md#symbol-ccc55b5e837d)；[`NationalSpire.ManualChatMemories.Heading(NationalSpire.CareerData, NationalSpire.ManualChatMemory)`](ManualChatMemory.cs.md#symbol-7188d3f17ab1)；[`NationalSpire.MarketChart._Draw()`](MarketTerminal.cs.md#symbol-b9c7f00ce2d0)；[`NationalSpire.MarketDynamics.TryPublish(NationalSpire.CareerData)`](MarketDynamics.cs.md#symbol-9d095f6ad885)；[`NationalSpire.MarketEventRow.Bind(NationalSpire.CareerData, NationalSpire.MarketEvent, string)`](MarketVisuals.cs.md#symbol-a69640a62077)；[`NationalSpire.MarketTerminal.RefreshAccount(bool)`](MarketTerminal.cs.md#symbol-9559baf40113)；[`NationalSpire.NationalDevelopment.TryPublish(NationalSpire.CareerData, System.Random)`](NationalDevelopment.cs.md#symbol-620f6dd04f3a)；[`NationalSpire.OwnedClubs.EntryText(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-24aec8a4b1b4)；[`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`](PrivateAppointments.cs.md#symbol-1c549626b284)；[`NationalSpire.PrivateMessagePrompts.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?, string?, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-de94bbbea5ea)；[`NationalSpire.PrivateMessagePrompts.OfferContext(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer, bool)`](PrivateMessagePrompts.cs.md#symbol-67bd27e9ea35)；[`NationalSpire.PrivateMessages.AttachmentTitle(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessages.cs.md#symbol-125ddcdf1602)；[`NationalSpire.PrivateMessages.PrepareAttachments(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>)`](PrivateMessages.cs.md#symbol-f2d6d9cf9c86)；[`NationalSpire.PrivateMessages.PublicMemory(NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.IEnumerable<NationalSpire.CommunityPost>, int)`](PrivateMessages.cs.md#symbol-81234ccf975f)；[`NationalSpire.PublicSchedule.ForPrompt(NationalSpire.CareerData, NationalSpire.PublicSchedule?)`](PublicSchedule.cs.md#symbol-51c76e2ccd4b)；[`NationalSpire.WeeklyJournal.CloseWeek(NationalSpire.CareerData)`](WeeklyJournal.cs.md#symbol-fe6dece0c758)；[`NationalSpire.WorldEvents.FixtureFacts(NationalSpire.CareerData, NationalSpire.WorldCompetition, System.Collections.Generic.IEnumerable<NationalSpire.WorldFixture>)`](WorldEvents.cs.md#symbol-04c812704f65)；[`WeekStats(string)`](WeeklyJournal.cs.md#symbol-00d5e0a30f60)

**调用：** [`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-8a08be365f83)；`System.DateOnly.ToString(string?, System.IFormatProvider?)`

**字段、属性、事件及方法组引用：** `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；输入表达式：`Date(data, day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Date(data, day).ToString`
- `System.DateOnly.ToString(string?, System.IFormatProvider?)`；输入表达式：`Date(data, day).ToString("yyyy年M月d日", CultureInfo.InvariantCulture)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Date(data, day).ToString("yyyy年M月d日", CultureInfo.InvariantCulture)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-baf7d6edae6c"></a>

## `NationalSpire.GameCalendar.Iso(NationalSpire.CareerData, int) — public static string Iso(CareerData data, int day)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatAttachments.Material(NationalSpire.CareerData, NationalSpire.PrivateOffer, string)`](ChatAttachments.cs.md#symbol-90d268266519)；[`NationalSpire.ChatAttachments.ResponseInstructions(NationalSpire.CareerData, NationalSpire.PrivateOffer, string, NationalSpire.GroupChat?, string)`](ChatAttachments.cs.md#symbol-f98de794e2ca)；[`NationalSpire.CommunitySharing.Text(NationalSpire.CareerData, NationalSpire.CommunityQuote)`](CommunitySharing.cs.md#symbol-276822babdcb)；[`NationalSpire.GameCalendar.ConvertDateField(NationalSpire.CareerData, System.Text.Json.Nodes.JsonObject, string)`](GameCalendar.cs.md#symbol-2d733d924840)；[`NationalSpire.PrivatePublicContext.PlayerCompetitionRecord(NationalSpire.CareerData, int?)`](PrivatePublicContext.cs.md#symbol-1317b4730da2)；[`NationalSpire.RandomEventPrompts.Materials(NationalSpire.CareerData, NationalSpire.RandomEventRecord)`](RandomEventPrompts.cs.md#symbol-a96ac205ab9d)；[`NationalSpire.RandomEventPrompts.PlayerRecord(NationalSpire.CareerData)`](RandomEventPrompts.cs.md#symbol-abde1c36176c)

**调用：** [`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-8a08be365f83)；`System.DateOnly.ToString(string?, System.IFormatProvider?)`

**字段、属性、事件及方法组引用：** `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；输入表达式：`Date(data, day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Date(data, day).ToString`
- `System.DateOnly.ToString(string?, System.IFormatProvider?)`；输入表达式：`Date(data, day).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Date(data, day).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c5c99167e359"></a>

## `NationalSpire.GameCalendar.Season(NationalSpire.CareerData, int) — public static int Season(CareerData data, int day)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CalendarPlans(NationalSpire.CareerData)`](CalendarPlansScreen.cs.md#symbol-60a9060c5331)；[`NationalSpire.CareerScreen.OpenFixtureFor(NationalSpire.CareerData, int, NationalSpire.WorldCompetition?, NationalSpire.CareerMatch?)`](FixtureScheduleScreen.cs.md#symbol-b6e54268cac8)；[`NationalSpire.GameCalendar.NormalizeFields(NationalSpire.CareerData, System.Collections.Generic.Dictionary<string, string>)`](GameCalendar.cs.md#symbol-65b6dda6244b)；[`NationalSpire.RandomEventEffects.CheckEffects(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-1a41c3fc699a)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.LongSeasonsFrom`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ca512729a156"></a>

## `NationalSpire.GameCalendar.TryDay(NationalSpire.CareerData, string?, out int) — public static bool TryDay(CareerData data, string? text, out int day)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameCalendar.NormalizeFields(NationalSpire.CareerData, System.Collections.Generic.Dictionary<string, string>)`](GameCalendar.cs.md#symbol-65b6dda6244b)；[`NationalSpire.RandomEventEffects.Apply(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-886f350e91dc)；[`NationalSpire.RandomEventEffects.CheckEffects(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-1a41c3fc699a)

**调用：** [`NationalSpire.GameCalendar.Day(NationalSpire.CareerData, System.DateOnly)`](GameCalendar.cs.md#symbol-c755526e8036)；`System.DateOnly.TryParseExact(string?, string?, System.IFormatProvider?, System.Globalization.DateTimeStyles, out System.DateOnly)`

**字段、属性、事件及方法组引用：** `NationalSpire.GameCalendar.Day(NationalSpire.CareerData, System.DateOnly)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GameCalendar.Day(NationalSpire.CareerData, System.DateOnly)`；输入表达式：`Day(data, date)`；返回值紧邻使用处：`AssignmentExpressionSyntax: day = Day(data, date)`
- `System.DateOnly.TryParseExact(string?, string?, System.IFormatProvider?, System.Globalization.DateTimeStyles, out System.DateOnly)`；输入表达式：`DateOnly.TryParseExact(text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var date)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !DateOnly.TryParseExact(text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var date)`

**赋值（含属性/字段和局部值）：**

- `day` = `0`
- `day` = `Day(data, date)`

<a id="symbol-57fa2dd71e81"></a>

## `NationalSpire.GameCalendar.Range(NationalSpire.CareerData, int, int) — public static string Range(CareerData data, int first, int last)`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Add()`](PrivateAppointments.cs.md#symbol-e23e6cb20ab2)；[`NationalSpire.CareerScreen.Clubs(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-f5bb582dc7eb)；[`NationalSpire.CareerScreen.RenderWeeklyDetail(NationalSpire.CareerData)`](WeeklyScreen.cs.md#symbol-b3f0ffc5fb7d)；[`NationalSpire.CareerScreen.WeeklyCarousel(NationalSpire.CareerData)`](WeeklyScreen.cs.md#symbol-86166c5fd833)；[`NationalSpire.CareerTraining.Details(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerTraining.cs.md#symbol-2710ec7157e0)；[`NationalSpire.EsportsWorld.AcceptOffer(NationalSpire.CareerData, NationalSpire.ClubOffer)`](EsportsWorld.cs.md#symbol-09ff5941397c)；[`Section(string)`](PrivateMemoryScreen.cs.md#symbol-dfcd5054cde2)

**调用：** [`NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-eb37c8a67b51)

**字段、属性、事件及方法组引用：** `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`Text(data, first)`；返回值紧邻使用处：`BinaryExpressionSyntax: Text(data, first) + "至"`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`Text(data, first)`；返回值紧邻使用处：`ConditionalExpressionSyntax: first == last ? Text(data, first) : Text(data, first) + "至" + Text(data, last)`
- `NationalSpire.GameCalendar.Text(NationalSpire.CareerData, int)`；输入表达式：`Text(data, last)`；返回值紧邻使用处：`BinaryExpressionSyntax: Text(data, first) + "至" + Text(data, last)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2d733d924840"></a>

## `NationalSpire.GameCalendar.ConvertDateField(NationalSpire.CareerData, System.Text.Json.Nodes.JsonObject, string) — public static bool ConvertDateField(CareerData data, JsonObject obj, string key)`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiWireProtocol.Rewrite(System.Text.Json.Nodes.JsonNode, System.Collections.Generic.Dictionary<string, string>, bool, NationalSpire.CareerData?)`](AiWireProtocol.cs.md#symbol-cb7b09cee7e3)；[`NationalSpire.GameCalendar.ConvertJsonDates(NationalSpire.CareerData, System.Text.Json.Nodes.JsonNode)`](GameCalendar.cs.md#symbol-c34ff65ec393)

**调用：** [`NationalSpire.GameCalendar.Iso(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-baf7d6edae6c)；`string.EndsWith(string, System.StringComparison)`；`string.Equals(string?, System.StringComparison)`；`System.Text.Json.Nodes.JsonNode.GetValue<T>()`；`System.Text.Json.Nodes.JsonObject.Remove(string)`；`System.Text.Json.Nodes.JsonValue.TryGetValue<T>(out T?)`

**字段、属性、事件及方法组引用：** `NationalSpire.GameCalendar.Iso(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GameCalendar.Iso(NationalSpire.CareerData, int)`；输入表达式：`Iso(data, day)`；返回值紧邻使用处：`ConditionalExpressionSyntax: day > 0 ? Iso(data, day) : null`
- `string.EndsWith(string, System.StringComparison)`；输入表达式：`key.EndsWith("Day", StringComparison.Ordinal)`；返回值紧邻使用处：`BinaryExpressionSyntax: key.Equals("day", StringComparison.OrdinalIgnoreCase) || key.EndsWith("Day", StringComparison.Ordinal)`
- `string.Equals(string?, System.StringComparison)`；输入表达式：`key.Equals("day", StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: key.Equals("day", StringComparison.OrdinalIgnoreCase) || key.EndsWith("Day", StringComparison.Ordinal)`
- `System.Text.Json.Nodes.JsonNode.GetValue<T>()`；输入表达式：`.GetValue<int>()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: value?.GetValue<int>()`
- `System.Text.Json.Nodes.JsonObject.Remove(string)`；输入表达式：`obj.Remove(key)`；返回值紧邻使用处：`ExpressionStatementSyntax: obj.Remove(key);`
- `System.Text.Json.Nodes.JsonValue.TryGetValue<T>(out T?)`；输入表达式：`date.TryGetValue<int>(out _)`；返回值紧邻使用处：`BinaryExpressionSyntax: value is JsonValue date && date.TryGetValue<int>(out _)`

**赋值（含属性/字段和局部值）：**

- `obj[key[..^3] + (key == "day" ? "date" : "Date")]` = `day > 0 ? Iso(data, day) : null`

<a id="symbol-c34ff65ec393"></a>

## `NationalSpire.GameCalendar.ConvertJsonDates(NationalSpire.CareerData, System.Text.Json.Nodes.JsonNode) — public static void ConvertJsonDates(CareerData data, JsonNode node)`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiGeneratedText.Attachment(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](AiGeneratedText.cs.md#symbol-ac6a46b66492)；[`NationalSpire.GameCalendar.ConvertJsonDates(NationalSpire.CareerData, System.Text.Json.Nodes.JsonNode)`](GameCalendar.cs.md#symbol-c34ff65ec393)

**调用：** [`NationalSpire.GameCalendar.ConvertDateField(NationalSpire.CareerData, System.Text.Json.Nodes.JsonObject, string)`](GameCalendar.cs.md#symbol-2d733d924840)；[`NationalSpire.GameCalendar.ConvertJsonDates(NationalSpire.CareerData, System.Text.Json.Nodes.JsonNode)`](GameCalendar.cs.md#symbol-c34ff65ec393)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.GameCalendar.ConvertDateField(NationalSpire.CareerData, System.Text.Json.Nodes.JsonObject, string)`；`NationalSpire.GameCalendar.ConvertJsonDates(NationalSpire.CareerData, System.Text.Json.Nodes.JsonNode)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GameCalendar.ConvertDateField(NationalSpire.CareerData, System.Text.Json.Nodes.JsonObject, string)`；输入表达式：`ConvertDateField(data, obj, key)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ConvertDateField(data, obj, key)`
- `NationalSpire.GameCalendar.ConvertJsonDates(NationalSpire.CareerData, System.Text.Json.Nodes.JsonNode)`；输入表达式：`ConvertJsonDates(data, child)`；返回值紧邻使用处：`ExpressionStatementSyntax: ConvertJsonDates(data, child);`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`obj.Select(p => p.Key)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: obj.Select(p => p.Key).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`obj.Select(p => p.Key).ToArray()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string key in obj.Select(p => p.Key).ToArray())                  if (!ConvertDateField(data, obj, key) && obj[key] is { } child) ConvertJsonDates(data, child);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-65b6dda6244b"></a>

## `NationalSpire.GameCalendar.NormalizeFields(NationalSpire.CareerData, System.Collections.Generic.Dictionary<string, string>) — public static bool NormalizeFields(CareerData data, Dictionary<string, string> fields)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateAppointments.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>, string)`](PrivateAppointments.cs.md#symbol-32d5ee024249)；[`NationalSpire.SocialAppointments.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`](SocialAppointments.cs.md#symbol-33a4725630bd)

**调用：** [`NationalSpire.GameCalendar.Season(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-c5c99167e359)；[`NationalSpire.GameCalendar.TryDay(NationalSpire.CareerData, string?, out int)`](GameCalendar.cs.md#symbol-ca512729a156)；[`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-0f707d2c9895)；`int.ToString(System.IFormatProvider?)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`

**字段、属性、事件及方法组引用：** `NationalSpire.GameCalendar.Season(NationalSpire.CareerData, int)`；`NationalSpire.GameCalendar.TryDay(NationalSpire.CareerData, string?, out int)`；`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.ToString(System.IFormatProvider?)`；输入表达式：`Season(data, day).ToString(CultureInfo.InvariantCulture)`；返回值紧邻使用处：`AssignmentExpressionSyntax: fields["Season"] = Season(data, day).ToString(CultureInfo.InvariantCulture)`
- `int.ToString(System.IFormatProvider?)`；输入表达式：`SeasonCalendar.Day(data, day).ToString(CultureInfo.InvariantCulture)`；返回值紧邻使用处：`AssignmentExpressionSyntax: fields["Day"] = SeasonCalendar.Day(data, day).ToString(CultureInfo.InvariantCulture)`
- `NationalSpire.GameCalendar.Season(NationalSpire.CareerData, int)`；输入表达式：`Season(data, day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Season(data, day).ToString`
- `NationalSpire.GameCalendar.TryDay(NationalSpire.CareerData, string?, out int)`；输入表达式：`TryDay(data, value, out int day)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !TryDay(data, value, out int day)`
- `NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Day(data, day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: SeasonCalendar.Day(data, day).ToString`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`fields.TryGetValue("Date", out var value)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !fields.TryGetValue("Date", out var value)`

**赋值（含属性/字段和局部值）：**

- `fields["Day"]` = `SeasonCalendar.Day(data, day).ToString(CultureInfo.InvariantCulture)`
- `fields["Season"]` = `Season(data, day).ToString(CultureInfo.InvariantCulture)`
