# PrivateInteractionUndo.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`38B6AA3715D8366969171F0896613ACFB3DE7651266879CC719CE5819321DB20`。来源：[源码](../../PrivateInteractionUndo.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.PrivateInteractionUndo`、`NationalSpire.PrivateInteractionHistory`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-5bbd37d8c4bb"></a>

## `NationalSpire.PrivateInteractionUndo.Before — public JsonObject Before`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Text.Json.Nodes.JsonObject.JsonObject(System.Text.Json.Nodes.JsonNodeOptions?)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Text.Json.Nodes.JsonObject.JsonObject(System.Text.Json.Nodes.JsonNodeOptions?)`；输入表达式：`new()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-04ab18b67579"></a>

## `NationalSpire.PrivateInteractionUndo.After — public JsonObject After`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Text.Json.Nodes.JsonObject.JsonObject(System.Text.Json.Nodes.JsonNodeOptions?)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Text.Json.Nodes.JsonObject.JsonObject(System.Text.Json.Nodes.JsonNodeOptions?)`；输入表达式：`new()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7345ea0310db"></a>

## `NationalSpire.PrivateInteractionUndo.Contract — public bool Contract`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-58ee4a7730ae"></a>

## `NationalSpire.PrivateInteractionHistory.Node<T>(T) — private static JsonNode? Node<T>(T value)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool)`](PrivateInteractionUndo.cs.md#symbol-de9e985d044d)；[`NationalSpire.PrivateInteractionHistory.Difference(System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, string)`](PrivateInteractionUndo.cs.md#symbol-0a73a9db2a55)

**调用：** `System.Text.Json.JsonSerializer.SerializeToNode<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Text.Json.JsonSerializer.SerializeToNode<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.SerializeToNode(value)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => JsonSerializer.SerializeToNode(value)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-de9e985d044d"></a>

## `NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool) — public static JsonObject Capture(CareerData d, string id, bool contract = false)`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupInteractions.Apply(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn, System.Collections.Generic.IEnumerable<System.Collections.Generic.Dictionary<string, string>>)`](GroupInteractions.cs.md#symbol-2b413a511485)；[`NationalSpire.OwnedClubs.ArriveTransfers(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-2429e4910b3f)；[`NationalSpire.PrivateAppointments.Confirm(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-3089895d205a)；[`NationalSpire.PrivateContracts.Confirm(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, string)`](PrivateAppointments.cs.md#symbol-1c0ddcc69a05)；[`NationalSpire.PrivateInteractionHistory.Record(NationalSpire.CareerData, string, NationalSpire.PrivateTurn, System.Text.Json.Nodes.JsonObject, bool)`](PrivateInteractionUndo.cs.md#symbol-9eda496612ca)；[`NationalSpire.PrivateInteractionHistory.Rewind(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn)`](PrivateInteractionUndo.cs.md#symbol-f2cc1906a6b6)；[`NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`](PrivateMessages.cs.md#symbol-7bf623828ccc)；[`NationalSpire.PrivateMessages.ConfirmFavour(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer, bool)`](PrivateMessages.cs.md#symbol-056e9f8e0046)；[`NationalSpire.SocialAppointments.Confirm(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer)`](SocialAppointments.cs.md#symbol-2f0b4ecea199)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`](LifeData.cs.md#symbol-de5af63fa4e7)；[`NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-1ed5bef75319)；[`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-24bc82bdbbd4)；[`NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`](PrivateAppointments.cs.md#symbol-32f6566791d2)；[`NationalSpire.PrivateInteractionHistory.Node<T>(T)`](PrivateInteractionUndo.cs.md#symbol-58ee4a7730ae)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；[`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-8a6bb6e78fa5)；[`NationalSpire.PrivateProfileChanges.Value(NationalSpire.CareerPerson, string)`](PrivateProfileChanges.cs.md#symbol-2ca919f5172e)；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Text.Json.Nodes.JsonNode.AsObject()`；`System.Text.Json.Nodes.JsonObject.JsonObject(System.Text.Json.Nodes.JsonNodeOptions?)`；`System.Text.Json.Nodes.JsonObject.Remove(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerClub.Budget`；`NationalSpire.CareerClub.Id`；`NationalSpire.CareerData.CommunityMemories`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.People`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerLifeState.Events`；`NationalSpire.CareerLifeState.Ledger`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.ClubPosition`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Learning`；`NationalSpire.CareerPerson.PrivateProfileReceipts`；`NationalSpire.CareerPerson.Role`；`NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`；`NationalSpire.CoachTrainingPlan.PersonId`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.Clubs`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsCareer.LineupRequests`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.NpcLearning.MoodDay`；`NationalSpire.NpcLearning.MoodStrength`；`NationalSpire.NpcLearning.MoodUntil`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubState.PlayerNextPosition`；`NationalSpire.OwnedClubState.PlayerPositionRequest`；`NationalSpire.OwnedClubState.PlayerPositionSeason`；`NationalSpire.OwnedClubState.PlayerReplacement`；`NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateInteractionHistory.Node<T>(T)`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateProfileChanges.Fields`；`NationalSpire.PrivateProfileChanges.Value(NationalSpire.CareerPerson, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(d, id)!`
- `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；输入表达式：`CareerMoney.Balance(d)`；返回值紧邻使用处：`AssignmentExpressionSyntax: snapshot["credits"] = CareerMoney.Balance(d)`
- `NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.TrainingPlans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ClubCoaching.TrainingPlans(d).Where`
- `NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.IsHuman(d, id)`；返回值紧邻使用处：`IfStatementSyntax: if (GroupChats.IsHuman(d, id))              return new JsonObject { ["offers"] = Node(PrivateMessages.Mailbox(d).Conversations[id].Offers) };`
- `NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`；输入表达式：`PrivateAppointments.IsPrivate(m)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateAppointments.IsPrivate(m) && m.OpponentId == id`
- `NationalSpire.PrivateInteractionHistory.Node<T>(T)`；输入表达式：`Node(ClubCoaching.TrainingPlans(d).Where(p => p.PersonId == id).ToList())`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["coachTraining"] = Node(ClubCoaching.TrainingPlans(d).Where(p => p.PersonId == id).ToList())`
- `NationalSpire.PrivateInteractionHistory.Node<T>(T)`；输入表达式：`Node(d.CommunityMemories)`；返回值紧邻使用处：`AssignmentExpressionSyntax: snapshot["memories"] = Node(d.CommunityMemories)`
- `NationalSpire.PrivateInteractionHistory.Node<T>(T)`；输入表达式：`Node(d.Esports.Clubs.ToDictionary(c => c.Id, c => c.Budget))`；返回值紧邻使用处：`AssignmentExpressionSyntax: snapshot["clubBudgets"] = Node(d.Esports.Clubs.ToDictionary(c => c.Id, c => c.Budget))`
- `NationalSpire.PrivateInteractionHistory.Node<T>(T)`；输入表达式：`Node(d.Esports.Competitions)`；返回值紧邻使用处：`AssignmentExpressionSyntax: snapshot["competitions"] = Node(d.Esports.Competitions)`
- `NationalSpire.PrivateInteractionHistory.Node<T>(T)`；输入表达式：`Node(d.Esports.LineupRequests)`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["lineups"] = Node(d.Esports.LineupRequests)`
- `NationalSpire.PrivateInteractionHistory.Node<T>(T)`；输入表达式：`Node(d.Esports.OwnedClub)`；返回值紧邻使用处：`AssignmentExpressionSyntax: snapshot["owned"] = Node(d.Esports.OwnedClub)`
- `NationalSpire.PrivateInteractionHistory.Node<T>(T)`；输入表达式：`Node(d.Life.Events)`；返回值紧邻使用处：`AssignmentExpressionSyntax: snapshot["events"] = Node(d.Life.Events)`
- `NationalSpire.PrivateInteractionHistory.Node<T>(T)`；输入表达式：`Node(d.Life.Ledger)`；返回值紧邻使用处：`AssignmentExpressionSyntax: snapshot["ledger"] = Node(d.Life.Ledger)`
- `NationalSpire.PrivateInteractionHistory.Node<T>(T)`；输入表达式：`Node(d.Matches.Where(m => PrivateAppointments.IsPrivate(m) && m.OpponentId == id).ToList())`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["privateMatches"] = Node(d.Matches.Where(m => PrivateAppointments.IsPrivate(m) && m.OpponentId == id).ToList())`
- `NationalSpire.PrivateInteractionHistory.Node<T>(T)`；输入表达式：`Node(d.Matches)`；返回值紧邻使用处：`AssignmentExpressionSyntax: snapshot["matches"] = Node(d.Matches)`
- `NationalSpire.PrivateInteractionHistory.Node<T>(T)`；输入表达式：`Node(d.People.Where(x => x.ClubId == d.Esports.ClubId).ToDictionary(x => x.Id, x => new { x.Role, x.ClubPosition }))`；返回值紧邻使用处：`AssignmentExpressionSyntax: snapshot["rosterRoles"] = Node(d.People.Where(x => x.ClubId == d.Esports.ClubId).ToDictionary(x => x.Id, x => new { x.Role, x.ClubPosition }))`
- `NationalSpire.PrivateInteractionHistory.Node<T>(T)`；输入表达式：`Node(new { p.Learning.MoodDay, p.Learning.MoodUntil, p.Learning.MoodStrength })`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["mood"] = Node(new { p.Learning.MoodDay, p.Learning.MoodUntil, p.Learning.MoodStrength })`
- `NationalSpire.PrivateInteractionHistory.Node<T>(T)`；输入表达式：`Node(new { seats.ClubId, seats.PlayerPositionSeason,                  seats.PlayerNextPosition, seats.PlayerReplacement, seats.PlayerPositionRequest })`；返回值紧邻使用处：`ConditionalExpressionSyntax: d.Esports.OwnedClub is { } seats ? Node(new { seats.ClubId, seats.PlayerPositionSeason,                  seats.PlayerNextPosition, seats.PlayerReplacement, seats.PlayerPositionRequest }) : null`
- `NationalSpire.PrivateInteractionHistory.Node<T>(T)`；输入表达式：`Node(p.Learning)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Node(p.Learning)!`
- `NationalSpire.PrivateInteractionHistory.Node<T>(T)`；输入表达式：`Node(p.PrivateProfileReceipts)`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["receipts"] = Node(p.PrivateProfileReceipts)`
- `NationalSpire.PrivateInteractionHistory.Node<T>(T)`；输入表达式：`Node(PrivateMessages.Conversation(d, id).Offers)`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["offers"] = Node(PrivateMessages.Conversation(d, id).Offers)`
- `NationalSpire.PrivateInteractionHistory.Node<T>(T)`；输入表达式：`Node(PrivateMessages.Mailbox(d).Conversations[id].Offers)`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["offers"] = Node(PrivateMessages.Mailbox(d).Conversations[id].Offers)`
- `NationalSpire.PrivateInteractionHistory.Node<T>(T)`；输入表达式：`Node(PrivateMessages.Relation(d, id))`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["relation"] = Node(PrivateMessages.Relation(d, id))`
- `NationalSpire.PrivateInteractionHistory.Node<T>(T)`；输入表达式：`Node(PrivateProfileChanges.Fields.ToDictionary(f => f, f => PrivateProfileChanges.Value(p, f)))`；返回值紧邻使用处：`AssignmentExpressionSyntax: ["profile"] = Node(PrivateProfileChanges.Fields.ToDictionary(f => f, f => PrivateProfileChanges.Value(p, f)))`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(d, id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(d, id).Offers`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(d).Conversations`
- `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Relation(d, id)`；返回值紧邻使用处：`ArgumentSyntax: PrivateMessages.Relation(d, id)`
- `NationalSpire.PrivateProfileChanges.Value(NationalSpire.CareerPerson, string)`；输入表达式：`PrivateProfileChanges.Value(p, f)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: f => PrivateProfileChanges.Value(p, f)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`d.Esports.Clubs.ToDictionary(c => c.Id, c => c.Budget)`；返回值紧邻使用处：`ArgumentSyntax: d.Esports.Clubs.ToDictionary(c => c.Id, c => c.Budget)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`d.People.Where(x => x.ClubId == d.Esports.ClubId).ToDictionary(x => x.Id, x => new { x.Role, x.ClubPosition })`；返回值紧邻使用处：`ArgumentSyntax: d.People.Where(x => x.ClubId == d.Esports.ClubId).ToDictionary(x => x.Id, x => new { x.Role, x.ClubPosition })`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`PrivateProfileChanges.Fields.ToDictionary(f => f, f => PrivateProfileChanges.Value(p, f))`；返回值紧邻使用处：`ArgumentSyntax: PrivateProfileChanges.Fields.ToDictionary(f => f, f => PrivateProfileChanges.Value(p, f))`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`ClubCoaching.TrainingPlans(d).Where(p => p.PersonId == id).ToList()`；返回值紧邻使用处：`ArgumentSyntax: ClubCoaching.TrainingPlans(d).Where(p => p.PersonId == id).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Matches.Where(m => PrivateAppointments.IsPrivate(m) && m.OpponentId == id).ToList()`；返回值紧邻使用处：`ArgumentSyntax: d.Matches.Where(m => PrivateAppointments.IsPrivate(m) && m.OpponentId == id).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`ClubCoaching.TrainingPlans(d).Where(p => p.PersonId == id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ClubCoaching.TrainingPlans(d).Where(p => p.PersonId == id).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.Where(m => PrivateAppointments.IsPrivate(m) && m.OpponentId == id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Matches.Where(m => PrivateAppointments.IsPrivate(m) && m.OpponentId == id).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(x => x.ClubId == d.Esports.ClubId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(x => x.ClubId == d.Esports.ClubId).ToDictionary`
- `System.Text.Json.Nodes.JsonNode.AsObject()`；输入表达式：`Node(p.Learning)!.AsObject()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Node(p.Learning)!.AsObject()`
- `System.Text.Json.Nodes.JsonObject.JsonObject(System.Text.Json.Nodes.JsonNodeOptions?)`；输入表达式：`new JsonObject          {              ["profile"] = Node(PrivateProfileChanges.Fields.ToDictionary(f => f, f => PrivateProfileChanges.Value(p, f))),              ["receipts"] = Node(p.PrivateProfileReceipts), ["learning"] = learning,              ["mood"] = Node(new { p.Learning.MoodDay, p.Learning.MoodUntil, p.Learning.MoodStrength }),              ["relation"] = Node(PrivateMessages.Relation(d, id)),              ["offers"] = Node(PrivateMessages.Conversation(d, id).Offers),              ["coachTraining"] = Node(ClubCoaching.TrainingPlans(d).Where(p => p.PersonId == id).ToList()),              ["lineups"] = Node(d.Esports.LineupRequests),              ["playerSeat"] = d.Esports.OwnedClub is { } seats ? Node(new { seats.ClubId, seats.PlayerPositionSeason,                  seats.PlayerNextPosition, seats.PlayerReplacement, seats.PlayerPositionRequest }) : null,              ["privateMatches"] = Node(d.Matches.Where(m => PrivateAppointments.IsPrivate(m) && m.OpponentId == id).ToList())          }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new JsonObject          {              ["profile"] = Node(PrivateProfileChanges.Fields.ToDictionary(f => f, f => PrivateProfileChanges.Value(p, f))),              ["receipts"] = Node(p.PrivateProfileReceipts), ["learning"] = learning,              ["mood"] = Node(new { p.Learning.MoodDay, p.Learning.MoodUntil, p.Learning.MoodStrength }),              ["relation"] = Node(PrivateMessages.Relation(d, id)),              ["offers"] = Node(PrivateMessages.Conversation(d, id).Offers),              ["coachTraining"] = Node(ClubCoaching.TrainingPlans(d).Where(p => p.PersonId == id).ToList()),              ["lineups"] = Node(d.Esports.LineupRequests),              ["playerSeat"] = d.Esports.OwnedClub is { } seats ? Node(new { seats.ClubId, seats.PlayerPositionSeason,                  seats.PlayerNextPosition, seats.PlayerReplacement, seats.PlayerPositionRequest }) : null,              ["privateMatches"] = Node(d.Matches.Where(m => PrivateAppointments.IsPrivate(m) && m.OpponentId == id).ToList())          }`
- `System.Text.Json.Nodes.JsonObject.JsonObject(System.Text.Json.Nodes.JsonNodeOptions?)`；输入表达式：`new JsonObject { ["offers"] = Node(PrivateMessages.Mailbox(d).Conversations[id].Offers) }`；返回值紧邻使用处：`ReturnStatementSyntax: return new JsonObject { ["offers"] = Node(PrivateMessages.Mailbox(d).Conversations[id].Offers) };`
- `System.Text.Json.Nodes.JsonObject.Remove(string)`；输入表达式：`learning.Remove(key)`；返回值紧邻使用处：`ExpressionStatementSyntax: learning.Remove(key);`

**赋值（含属性/字段和局部值）：**

- `["coachTraining"]` = `Node(ClubCoaching.TrainingPlans(d).Where(p => p.PersonId == id).ToList())`
- `["learning"]` = `learning`
- `["lineups"]` = `Node(d.Esports.LineupRequests)`
- `["mood"]` = `Node(new { p.Learning.MoodDay, p.Learning.MoodUntil, p.Learning.MoodStrength })`
- `["offers"]` = `Node(PrivateMessages.Conversation(d, id).Offers)`
- `["offers"]` = `Node(PrivateMessages.Mailbox(d).Conversations[id].Offers)`
- `["playerSeat"]` = `d.Esports.OwnedClub is { } seats ? Node(new { seats.ClubId, seats.PlayerPositionSeason,                  seats.PlayerNextPosition, seats.PlayerReplacement, seats.PlayerPositionRequest }) : null`
- `["privateMatches"]` = `Node(d.Matches.Where(m => PrivateAppointments.IsPrivate(m) && m.OpponentId == id).ToList())`
- `["profile"]` = `Node(PrivateProfileChanges.Fields.ToDictionary(f => f, f => PrivateProfileChanges.Value(p, f)))`
- `["receipts"]` = `Node(p.PrivateProfileReceipts)`
- `["relation"]` = `Node(PrivateMessages.Relation(d, id))`
- `snapshot["club"]` = `p.ClubId`
- `snapshot["clubBudgets"]` = `Node(d.Esports.Clubs.ToDictionary(c => c.Id, c => c.Budget))`
- `snapshot["competitions"]` = `Node(d.Esports.Competitions)`
- `snapshot["credits"]` = `CareerMoney.Balance(d)`
- `snapshot["events"]` = `Node(d.Life.Events)`
- `snapshot["ledger"]` = `Node(d.Life.Ledger)`
- `snapshot["matches"]` = `Node(d.Matches)`
- `snapshot["memories"]` = `Node(d.CommunityMemories)`
- `snapshot["owned"]` = `Node(d.Esports.OwnedClub)`
- `snapshot["position"]` = `p.ClubPosition`
- `snapshot["role"]` = `p.Role`
- `snapshot["rosterRoles"]` = `Node(d.People.Where(x => x.ClubId == d.Esports.ClubId).ToDictionary(x => x.Id, x => new { x.Role, x.ClubPosition }))`

<a id="symbol-9eda496612ca"></a>

## `NationalSpire.PrivateInteractionHistory.Record(NationalSpire.CareerData, string, NationalSpire.PrivateTurn, System.Text.Json.Nodes.JsonObject, bool) — public static void Record(CareerData d, string id, PrivateTurn turn, JsonObject before, bool contract = false)`

来源：源码第 49 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupInteractions.Apply(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn, System.Collections.Generic.IEnumerable<System.Collections.Generic.Dictionary<string, string>>)`](GroupInteractions.cs.md#symbol-2b413a511485)；[`NationalSpire.OwnedClubs.ArriveTransfers(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-2429e4910b3f)；[`NationalSpire.PrivateAppointments.Confirm(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-3089895d205a)；[`NationalSpire.PrivateContracts.Confirm(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, string)`](PrivateAppointments.cs.md#symbol-1c0ddcc69a05)；[`NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`](PrivateMessages.cs.md#symbol-7bf623828ccc)；[`NationalSpire.PrivateMessages.ConfirmFavour(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer, bool)`](PrivateMessages.cs.md#symbol-056e9f8e0046)；[`NationalSpire.SocialAppointments.Confirm(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer)`](SocialAppointments.cs.md#symbol-2f0b4ecea199)

**调用：** [`NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool)`](PrivateInteractionUndo.cs.md#symbol-de9e985d044d)；[`NationalSpire.PrivateInteractionHistory.Difference(System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, string)`](PrivateInteractionUndo.cs.md#symbol-0a73a9db2a55)；`NationalSpire.PrivateInteractionUndo.PrivateInteractionUndo()`；`string.StartsWith(string)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Text.Json.Nodes.JsonNode.AsArray()`；`System.Text.Json.Nodes.JsonNode.GetValue<T>()`

**字段、属性、事件及方法组引用：** `(System.Text.Json.Nodes.JsonNode? Before, System.Text.Json.Nodes.JsonNode? After).After`；`(System.Text.Json.Nodes.JsonNode? Before, System.Text.Json.Nodes.JsonNode? After).Before`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerLifeState.Events`；`NationalSpire.LifeEvent.Id`；`NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool)`；`NationalSpire.PrivateInteractionHistory.Difference(System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, string)`；`NationalSpire.PrivateInteractionUndo.After`；`NationalSpire.PrivateInteractionUndo.Before`；`NationalSpire.PrivateInteractionUndo.Contract`；`NationalSpire.PrivateTurn.InteractionUndo`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool)`；输入表达式：`Capture(d, id, contract)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Capture(d, id, contract)`
- `NationalSpire.PrivateInteractionHistory.Difference(System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, string)`；输入表达式：`Difference(before, after)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Difference(before, after)`
- `NationalSpire.PrivateInteractionUndo.PrivateInteractionUndo()`；输入表达式：`new() { Before = (JsonObject)pair.Before!, After = (JsonObject)pair.After!, Contract = contract }`；返回值紧邻使用处：`ArgumentSyntax: new() { Before = (JsonObject)pair.Before!, After = (JsonObject)pair.After!, Contract = contract }`
- `string.StartsWith(string)`；输入表达式：`e.Id.StartsWith(d.LocalHumanId + "/")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !e.Id.StartsWith(d.LocalHumanId + "/")`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`oldIds.Contains(e.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !oldIds.Contains(e.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`before["events"]!.AsArray().Select(e => e!["Id"]!.GetValue<string>())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: before["events"]!.AsArray().Select(e => e!["Id"]!.GetValue<string>()).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`before["events"]!.AsArray().Select(e => e!["Id"]!.GetValue<string>()).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = before["events"]!.AsArray().Select(e => e!["Id"]!.GetValue<string>()).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Events.Where(e => !oldIds.Contains(e.Id) && !e.Id.StartsWith(d.LocalHumanId + "/"))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var e in d.Life.Events.Where(e => !oldIds.Contains(e.Id) && !e.Id.StartsWith(d.LocalHumanId + "/"))) e.Id = d.LocalHumanId + "/" + e.Id;`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`turn.InteractionUndo.Add(new() { Before = (JsonObject)pair.Before!, After = (JsonObject)pair.After!, Contract = contract })`；返回值紧邻使用处：`ExpressionStatementSyntax: turn.InteractionUndo.Add(new() { Before = (JsonObject)pair.Before!, After = (JsonObject)pair.After!, Contract = contract });`
- `System.Text.Json.Nodes.JsonNode.AsArray()`；输入表达式：`before["events"]!.AsArray()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: before["events"]!.AsArray().Select`
- `System.Text.Json.Nodes.JsonNode.GetValue<T>()`；输入表达式：`e!["Id"]!.GetValue<string>()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: e => e!["Id"]!.GetValue<string>()`

**赋值（含属性/字段和局部值）：**

- `After` = `(JsonObject)pair.After!`
- `Before` = `(JsonObject)pair.Before!`
- `Contract` = `contract`
- `e.Id` = `d.LocalHumanId + "/" + e.Id`

<a id="symbol-9841a56ebf0d"></a>

## `NationalSpire.PrivateInteractionHistory.Identity(System.Text.Json.Nodes.JsonNode?) — private static string Identity(JsonNode? n)`

来源：源码第 62 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateInteractionHistory.Revert(System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, string)`](PrivateInteractionUndo.cs.md#symbol-35a5c57d58cd)

**调用：** `System.Text.Json.Nodes.JsonNode.ToJsonString(System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Text.Json.Nodes.JsonNode.ToJsonString(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`.ToJsonString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: n?.ToJsonString()`
- `System.Text.Json.Nodes.JsonNode.ToJsonString(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`.ToJsonString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: o["Id"]?.ToJsonString()`
- `System.Text.Json.Nodes.JsonNode.ToJsonString(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`.ToJsonString()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: o["PersonId"]?.ToJsonString()`
- `System.Text.Json.Nodes.JsonNode.ToJsonString(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`n.ToJsonString()`；返回值紧邻使用处：`BinaryExpressionSyntax: o["PersonId"]?.ToJsonString() ?? n.ToJsonString()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0a73a9db2a55"></a>

## `NationalSpire.PrivateInteractionHistory.Difference(System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, string) — private static (JsonNode? Before, JsonNode? After)? Difference(JsonNode? before, JsonNode? after, string path = "")`

来源：源码第 64 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateInteractionHistory.Difference(System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, string)`](PrivateInteractionUndo.cs.md#symbol-0a73a9db2a55)；[`NationalSpire.PrivateInteractionHistory.Record(NationalSpire.CareerData, string, NationalSpire.PrivateTurn, System.Text.Json.Nodes.JsonObject, bool)`](PrivateInteractionUndo.cs.md#symbol-9eda496612ca)

**调用：** [`NationalSpire.PrivateInteractionHistory.Difference(System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, string)`](PrivateInteractionUndo.cs.md#symbol-0a73a9db2a55)；[`NationalSpire.PrivateInteractionHistory.Node<T>(T)`](PrivateInteractionUndo.cs.md#symbol-58ee4a7730ae)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Union<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Text.Json.Nodes.JsonArray.Add(System.Text.Json.Nodes.JsonNode?)`；`System.Text.Json.Nodes.JsonArray.JsonArray(System.Text.Json.Nodes.JsonNodeOptions?)`；`System.Text.Json.Nodes.JsonNode.DeepClone()`；`System.Text.Json.Nodes.JsonNode.DeepEquals(System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?)`；`System.Text.Json.Nodes.JsonObject.JsonObject(System.Text.Json.Nodes.JsonNodeOptions?)`

**字段、属性、事件及方法组引用：** `(System.Text.Json.Nodes.JsonNode? Before, System.Text.Json.Nodes.JsonNode? After).After`；`(System.Text.Json.Nodes.JsonNode? Before, System.Text.Json.Nodes.JsonNode? After).Before`；`NationalSpire.PrivateInteractionHistory.Difference(System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, string)`；`NationalSpire.PrivateInteractionHistory.Identity(System.Text.Json.Nodes.JsonNode?)`；`NationalSpire.PrivateInteractionHistory.Node<T>(T)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateInteractionHistory.Difference(System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, string)`；输入表达式：`Difference(a[key], b[key], path + "/" + key)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Difference(a[key], b[key], path + "/" + key) is { } pair`
- `NationalSpire.PrivateInteractionHistory.Node<T>(T)`；输入表达式：`Node(x.Select(Identity).ToArray())`；返回值紧邻使用处：`ConditionalExpressionSyntax: path is "/receipts" or "/learning/Receipts" or "/learning/Sources" ? null : Node(x.Select(Identity).ToArray())`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`x.Any(m => JsonNode.DeepEquals(n, m))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !x.Any(m => JsonNode.DeepEquals(n, m))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`y.Any(m => JsonNode.DeepEquals(n, m))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !y.Any(m => JsonNode.DeepEquals(n, m))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`a.Select(p => p.Key)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: a.Select(p => p.Key).Union`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`b.Select(p => p.Key)`；返回值紧邻使用处：`ArgumentSyntax: b.Select(p => p.Key)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`x.Select(Identity)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: x.Select(Identity).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`x.Select(Identity).ToArray()`；返回值紧邻使用处：`ArgumentSyntax: x.Select(Identity).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Union<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`a.Select(p => p.Key).Union(b.Select(p => p.Key))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string key in a.Select(p => p.Key).Union(b.Select(p => p.Key)))                  if (Difference(a[key], b[key], path + "/" + key) is { } pair)                  { left[key] = pair.Before; right[key] = pair.After; }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`x.Where(n => !y.Any(m => JsonNode.DeepEquals(n, m)))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var item in x.Where(n => !y.Any(m => JsonNode.DeepEquals(n, m)))) left.Add(item?.DeepClone());`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`y.Where(n => !x.Any(m => JsonNode.DeepEquals(n, m)))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var item in y.Where(n => !x.Any(m => JsonNode.DeepEquals(n, m)))) right.Add(item?.DeepClone());`
- `System.Text.Json.Nodes.JsonArray.Add(System.Text.Json.Nodes.JsonNode?)`；输入表达式：`left.Add(item?.DeepClone())`；返回值紧邻使用处：`ExpressionStatementSyntax: left.Add(item?.DeepClone());`
- `System.Text.Json.Nodes.JsonArray.Add(System.Text.Json.Nodes.JsonNode?)`；输入表达式：`right.Add(item?.DeepClone())`；返回值紧邻使用处：`ExpressionStatementSyntax: right.Add(item?.DeepClone());`
- `System.Text.Json.Nodes.JsonArray.JsonArray(System.Text.Json.Nodes.JsonNodeOptions?)`；输入表达式：`new JsonArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new JsonArray()`
- `System.Text.Json.Nodes.JsonNode.DeepClone()`；输入表达式：`.DeepClone()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: after?.DeepClone()`
- `System.Text.Json.Nodes.JsonNode.DeepClone()`；输入表达式：`.DeepClone()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: before?.DeepClone()`
- `System.Text.Json.Nodes.JsonNode.DeepClone()`；输入表达式：`.DeepClone()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: item?.DeepClone()`
- `System.Text.Json.Nodes.JsonNode.DeepEquals(System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?)`；输入表达式：`JsonNode.DeepEquals(before, after)`；返回值紧邻使用处：`IfStatementSyntax: if (JsonNode.DeepEquals(before, after)) return null;`
- `System.Text.Json.Nodes.JsonNode.DeepEquals(System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?)`；输入表达式：`JsonNode.DeepEquals(n, m)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m => JsonNode.DeepEquals(n, m)`
- `System.Text.Json.Nodes.JsonObject.JsonObject(System.Text.Json.Nodes.JsonNodeOptions?)`；输入表达式：`new JsonObject { ["$items"] = left, ["$order"] = order }`；返回值紧邻使用处：`ArgumentSyntax: new JsonObject { ["$items"] = left, ["$order"] = order }`
- `System.Text.Json.Nodes.JsonObject.JsonObject(System.Text.Json.Nodes.JsonNodeOptions?)`；输入表达式：`new JsonObject { ["$items"] = right }`；返回值紧邻使用处：`ArgumentSyntax: new JsonObject { ["$items"] = right }`
- `System.Text.Json.Nodes.JsonObject.JsonObject(System.Text.Json.Nodes.JsonNodeOptions?)`；输入表达式：`new JsonObject()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new JsonObject()`

**赋值（含属性/字段和局部值）：**

- `["$items"]` = `left`
- `["$items"]` = `right`
- `["$order"]` = `order`
- `left[key]` = `pair.Before`
- `right[key]` = `pair.After`

<a id="symbol-35a5c57d58cd"></a>

## `NationalSpire.PrivateInteractionHistory.Revert(System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, string) — private static JsonNode? Revert(JsonNode? current, JsonNode? before, JsonNode? after, string path = "")`

来源：源码第 89 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateInteractionHistory.Revert(System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, string)`](PrivateInteractionUndo.cs.md#symbol-35a5c57d58cd)；[`NationalSpire.PrivateInteractionHistory.Rewind(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn)`](PrivateInteractionUndo.cs.md#symbol-f2cc1906a6b6)

**调用：** [`NationalSpire.PrivateInteractionHistory.Identity(System.Text.Json.Nodes.JsonNode?)`](PrivateInteractionUndo.cs.md#symbol-9841a56ebf0d)；[`NationalSpire.PrivateInteractionHistory.Revert(System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, string)`](PrivateInteractionUndo.cs.md#symbol-35a5c57d58cd)；`decimal.Truncate(decimal)`；`string.StartsWith(string)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>, TSource)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.SkipWhile<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Union<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.IndexOf(T)`；`System.Linq.Enumerable.Range(int, int)`；`System.Text.Json.Nodes.JsonArray.Insert(int, System.Text.Json.Nodes.JsonNode?)`；`System.Text.Json.Nodes.JsonArray.RemoveAt(int)`；`System.Text.Json.Nodes.JsonNode?.Deserialize<TValue>(System.Text.Json.JsonSerializerOptions?)`；`System.Text.Json.Nodes.JsonNode.DeepClone()`；`System.Text.Json.Nodes.JsonNode.DeepEquals(System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?)`；`System.Text.Json.Nodes.JsonNode.GetValue<T>()`；`System.Text.Json.Nodes.JsonNode.GetValueKind()`；`System.Text.Json.Nodes.JsonObject.Remove(string)`；`System.Text.Json.Nodes.JsonValue.Create(decimal, System.Text.Json.Nodes.JsonNodeOptions?)`；`System.Text.Json.Nodes.JsonValue.Create(long, System.Text.Json.Nodes.JsonNodeOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateInteractionHistory.Identity(System.Text.Json.Nodes.JsonNode?)`；`NationalSpire.PrivateInteractionHistory.Revert(System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.Truncate(decimal)`；输入表达式：`decimal.Truncate(value)`；返回值紧邻使用处：`BinaryExpressionSyntax: value == decimal.Truncate(value)`
- `NationalSpire.PrivateInteractionHistory.Identity(System.Text.Json.Nodes.JsonNode?)`；输入表达式：`Identity(added)`；返回值紧邻使用处：`BinaryExpressionSyntax: Identity(n) == Identity(added)`
- `NationalSpire.PrivateInteractionHistory.Identity(System.Text.Json.Nodes.JsonNode?)`；输入表达式：`Identity(added)`；返回值紧邻使用处：`BinaryExpressionSyntax: Identity(z[i]) == Identity(added)`
- `NationalSpire.PrivateInteractionHistory.Identity(System.Text.Json.Nodes.JsonNode?)`；输入表达式：`Identity(item)`；返回值紧邻使用处：`ArgumentSyntax: Identity(item)`
- `NationalSpire.PrivateInteractionHistory.Identity(System.Text.Json.Nodes.JsonNode?)`；输入表达式：`Identity(item)`；返回值紧邻使用处：`BinaryExpressionSyntax: Identity(restored[i]) == Identity(item)`
- `NationalSpire.PrivateInteractionHistory.Identity(System.Text.Json.Nodes.JsonNode?)`；输入表达式：`Identity(m)`；返回值紧邻使用处：`BinaryExpressionSyntax: Identity(n) == Identity(m)`
- `NationalSpire.PrivateInteractionHistory.Identity(System.Text.Json.Nodes.JsonNode?)`；输入表达式：`Identity(n)`；返回值紧邻使用处：`BinaryExpressionSyntax: Identity(n) != Identity(removed)`
- `NationalSpire.PrivateInteractionHistory.Identity(System.Text.Json.Nodes.JsonNode?)`；输入表达式：`Identity(n)`；返回值紧邻使用处：`BinaryExpressionSyntax: Identity(n) == Identity(added)`
- `NationalSpire.PrivateInteractionHistory.Identity(System.Text.Json.Nodes.JsonNode?)`；输入表达式：`Identity(n)`；返回值紧邻使用处：`BinaryExpressionSyntax: Identity(n) == Identity(m)`
- `NationalSpire.PrivateInteractionHistory.Identity(System.Text.Json.Nodes.JsonNode?)`；输入表达式：`Identity(n)`；返回值紧邻使用处：`BinaryExpressionSyntax: Identity(n) == Identity(removed)`
- `NationalSpire.PrivateInteractionHistory.Identity(System.Text.Json.Nodes.JsonNode?)`；输入表达式：`Identity(removed)`；返回值紧邻使用处：`BinaryExpressionSyntax: Identity(n) != Identity(removed)`
- `NationalSpire.PrivateInteractionHistory.Identity(System.Text.Json.Nodes.JsonNode?)`；输入表达式：`Identity(removed)`；返回值紧邻使用处：`BinaryExpressionSyntax: Identity(n) == Identity(removed)`
- `NationalSpire.PrivateInteractionHistory.Identity(System.Text.Json.Nodes.JsonNode?)`；输入表达式：`Identity(restored[i])`；返回值紧邻使用处：`ArgumentSyntax: Identity(restored[i])`
- `NationalSpire.PrivateInteractionHistory.Identity(System.Text.Json.Nodes.JsonNode?)`；输入表达式：`Identity(restored[i])`；返回值紧邻使用处：`BinaryExpressionSyntax: Identity(restored[i]) == Identity(item)`
- `NationalSpire.PrivateInteractionHistory.Identity(System.Text.Json.Nodes.JsonNode?)`；输入表达式：`Identity(z[i])`；返回值紧邻使用处：`ArgumentSyntax: Identity(z[i])`
- `NationalSpire.PrivateInteractionHistory.Identity(System.Text.Json.Nodes.JsonNode?)`；输入表达式：`Identity(z[i])`；返回值紧邻使用处：`BinaryExpressionSyntax: Identity(z[i]) == Identity(added)`
- `NationalSpire.PrivateInteractionHistory.Revert(System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, string)`；输入表达式：`Revert(c[key], a[key], b[key], path + "/" + key)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Revert(c[key], a[key], b[key], path + "/" + key)`
- `NationalSpire.PrivateInteractionHistory.Revert(System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, string)`；输入表达式：`Revert(list, oldItems, newItems, path)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Revert(list, oldItems, newItems, path)!`
- `NationalSpire.PrivateInteractionHistory.Revert(System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, string)`；输入表达式：`Revert(z[index], old, added, path)`；返回值紧邻使用处：`AssignmentExpressionSyntax: z[index] = Revert(z[index], old, added, path)`
- `string.StartsWith(string)`；输入表达式：`path.StartsWith("/clubBudgets/")`；返回值紧邻使用处：`BinaryExpressionSyntax: path is "/credits" or "/owned/CashFlow" or "/learning/ChanceShift" or "/learning/Exposure" or "/relation/Favour"              || path.StartsWith("/learning/Topics/") || path.StartsWith("/clubBudgets/")`
- `string.StartsWith(string)`；输入表达式：`path.StartsWith("/learning/Topics/")`；返回值紧邻使用处：`BinaryExpressionSyntax: path is "/credits" or "/owned/CashFlow" or "/learning/ChanceShift" or "/learning/Exposure" or "/relation/Favour"              || path.StartsWith("/learning/Topics/")`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`following.Contains(Identity(restored[i]))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: i => following.Contains(Identity(restored[i]))`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`following.Contains(Identity(z[i]))`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: i => following.Contains(Identity(z[i]))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`newItems.Any(m => Identity(n) == Identity(m))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !newItems.Any(m => Identity(n) == Identity(m))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`y.Any(m => Identity(n) == Identity(m))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !y.Any(m => Identity(n) == Identity(m))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`z.Any(n => Identity(n) == Identity(removed))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !z.Any(n => Identity(n) == Identity(removed))`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>, TSource)`；输入表达式：`Enumerable.Range(0, restored.Count).FirstOrDefault(i => following.Contains(Identity(restored[i])), restored.Count)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Enumerable.Range(0, restored.Count).FirstOrDefault(i => following.Contains(Identity(restored[i])), restored.Count)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>, TSource)`；输入表达式：`Enumerable.Range(0, restored.Count).FirstOrDefault(i => Identity(restored[i]) == Identity(item), -1)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Enumerable.Range(0, restored.Count).FirstOrDefault(i => Identity(restored[i]) == Identity(item), -1)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>, TSource)`；输入表达式：`Enumerable.Range(0, z.Count).FirstOrDefault(i => following.Contains(Identity(z[i])), z.Count)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Enumerable.Range(0, z.Count).FirstOrDefault(i => following.Contains(Identity(z[i])), z.Count)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>, TSource)`；输入表达式：`Enumerable.Range(0, z.Count).FirstOrDefault(i => Identity(z[i]) == Identity(added), -1)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Enumerable.Range(0, z.Count).FirstOrDefault(i => Identity(z[i]) == Identity(added), -1)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`x.FirstOrDefault(n => Identity(n) == Identity(added))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = x.FirstOrDefault(n => Identity(n) == Identity(added))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`a.Select(p => p.Key)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: a.Select(p => p.Key).Union`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`b.Select(p => p.Key)`；返回值紧邻使用处：`ArgumentSyntax: b.Select(p => p.Key)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`order.Select(n => n!.GetValue<string>())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: order.Select(n => n!.GetValue<string>()).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`x.SkipWhile(n => Identity(n) != Identity(removed)).Skip(1).Select(Identity)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: x.SkipWhile(n => Identity(n) != Identity(removed)).Skip(1).Select(Identity).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`identities.Skip(identities.IndexOf(Identity(item)) + 1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: identities.Skip(identities.IndexOf(Identity(item)) + 1).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`x.SkipWhile(n => Identity(n) != Identity(removed)).Skip(1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: x.SkipWhile(n => Identity(n) != Identity(removed)).Skip(1).Select`
- `System.Collections.Generic.IEnumerable<TSource>.SkipWhile<TSource>(System.Func<TSource, bool>)`；输入表达式：`x.SkipWhile(n => Identity(n) != Identity(removed))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: x.SkipWhile(n => Identity(n) != Identity(removed)).Skip`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`identities.Skip(identities.IndexOf(Identity(item)) + 1).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = identities.Skip(identities.IndexOf(Identity(item)) + 1).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`x.SkipWhile(n => Identity(n) != Identity(removed)).Skip(1).Select(Identity).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = x.SkipWhile(n => Identity(n) != Identity(removed)).Skip(1).Select(Identity).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`order.Select(n => n!.GetValue<string>()).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = order.Select(n => n!.GetValue<string>()).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Union<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`a.Select(p => p.Key).Union(b.Select(p => p.Key))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string key in a.Select(p => p.Key).Union(b.Select(p => p.Key)))              {                  var value = Revert(c[key], a[key], b[key], path + "/" + key);                  if (value == null) c.Remove(key); else c[key] = value;              }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`oldItems.Where(n => !newItems.Any(m => Identity(n) == Identity(m)))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var item in oldItems.Where(n => !newItems.Any(m => Identity(n) == Identity(m))))                  {                      int at = Enumerable.Range(0, restored.Count).FirstOrDefault(i => Identity(restored[i]) == Identity(item), -1);                      if (at < 0) continue;                      var node = restored[at]; restored.RemoveAt(at);                      var following = identities.Skip(identities.IndexOf(Identity(item)) + 1).ToHashSet();                      int insert = Enumerable.Range(0, restored.Count).FirstOrDefault(i => following.Contains(Identity(restored[i])), restored.Count);                      restored.Insert(insert, node);                  }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`x.Where(n => !y.Any(m => Identity(n) == Identity(m)))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var removed in x.Where(n => !y.Any(m => Identity(n) == Identity(m))))                  if (!z.Any(n => Identity(n) == Identity(removed)))                  {                      var following = x.SkipWhile(n => Identity(n) != Identity(removed)).Skip(1).Select(Identity).ToHashSet();                      int insert = Enumerable.Range(0, z.Count).FirstOrDefault(i => following.Contains(Identity(z[i])), z.Count);                      z.Insert(insert, removed?.DeepClone());                  }`
- `System.Collections.Generic.List<T>.IndexOf(T)`；输入表达式：`identities.IndexOf(Identity(item))`；返回值紧邻使用处：`BinaryExpressionSyntax: identities.IndexOf(Identity(item)) + 1`
- `System.Linq.Enumerable.Range(int, int)`；输入表达式：`Enumerable.Range(0, restored.Count)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0, restored.Count).FirstOrDefault`
- `System.Linq.Enumerable.Range(int, int)`；输入表达式：`Enumerable.Range(0, z.Count)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Enumerable.Range(0, z.Count).FirstOrDefault`
- `System.Text.Json.Nodes.JsonArray.Insert(int, System.Text.Json.Nodes.JsonNode?)`；输入表达式：`restored.Insert(insert, node)`；返回值紧邻使用处：`ExpressionStatementSyntax: restored.Insert(insert, node);`
- `System.Text.Json.Nodes.JsonArray.Insert(int, System.Text.Json.Nodes.JsonNode?)`；输入表达式：`z.Insert(insert, removed?.DeepClone())`；返回值紧邻使用处：`ExpressionStatementSyntax: z.Insert(insert, removed?.DeepClone());`
- `System.Text.Json.Nodes.JsonArray.RemoveAt(int)`；输入表达式：`restored.RemoveAt(at)`；返回值紧邻使用处：`ExpressionStatementSyntax: restored.RemoveAt(at);`
- `System.Text.Json.Nodes.JsonArray.RemoveAt(int)`；输入表达式：`z.RemoveAt(index)`；返回值紧邻使用处：`ExpressionStatementSyntax: z.RemoveAt(index);`
- `System.Text.Json.Nodes.JsonNode?.Deserialize<TValue>(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`.Deserialize<decimal>()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: before?.Deserialize<decimal>()`
- `System.Text.Json.Nodes.JsonNode?.Deserialize<TValue>(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`after.Deserialize<decimal>()`；返回值紧邻使用处：`BinaryExpressionSyntax: current.Deserialize<decimal>() - after.Deserialize<decimal>()`
- `System.Text.Json.Nodes.JsonNode?.Deserialize<TValue>(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`current.Deserialize<decimal>()`；返回值紧邻使用处：`BinaryExpressionSyntax: current.Deserialize<decimal>() - after.Deserialize<decimal>()`
- `System.Text.Json.Nodes.JsonNode.DeepClone()`；输入表达式：`.DeepClone()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: (JsonNode.DeepEquals(current, after) ? before : current)?.DeepClone()`
- `System.Text.Json.Nodes.JsonNode.DeepClone()`；输入表达式：`.DeepClone()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: before?.DeepClone()`
- `System.Text.Json.Nodes.JsonNode.DeepClone()`；输入表达式：`.DeepClone()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: current?.DeepClone()`
- `System.Text.Json.Nodes.JsonNode.DeepClone()`；输入表达式：`.DeepClone()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: removed?.DeepClone()`
- `System.Text.Json.Nodes.JsonNode.DeepClone()`；输入表达式：`c.DeepClone()`；返回值紧邻使用处：`ReturnStatementSyntax: return c.DeepClone();`
- `System.Text.Json.Nodes.JsonNode.DeepClone()`；输入表达式：`z.DeepClone()`；返回值紧邻使用处：`ReturnStatementSyntax: return z.DeepClone();`
- `System.Text.Json.Nodes.JsonNode.DeepEquals(System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?)`；输入表达式：`JsonNode.DeepEquals(current, after)`；返回值紧邻使用处：`ConditionalExpressionSyntax: JsonNode.DeepEquals(current, after) ? before : current`
- `System.Text.Json.Nodes.JsonNode.DeepEquals(System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?)`；输入表达式：`JsonNode.DeepEquals(current, after)`；返回值紧邻使用处：`IfStatementSyntax: if (JsonNode.DeepEquals(current, after)) return before?.DeepClone();`
- `System.Text.Json.Nodes.JsonNode.GetValue<T>()`；输入表达式：`n!.GetValue<string>()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: n => n!.GetValue<string>()`
- `System.Text.Json.Nodes.JsonNode.GetValueKind()`；输入表达式：`.GetValueKind()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: after?.GetValueKind()`
- `System.Text.Json.Nodes.JsonNode.GetValueKind()`；输入表达式：`.GetValueKind()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: current?.GetValueKind()`
- `System.Text.Json.Nodes.JsonNode.GetValueKind()`；输入表达式：`before.GetValueKind()`；返回值紧邻使用处：`BinaryExpressionSyntax: before.GetValueKind() == JsonValueKind.Number`
- `System.Text.Json.Nodes.JsonObject.Remove(string)`；输入表达式：`c.Remove(key)`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Remove(key);`
- `System.Text.Json.Nodes.JsonValue.Create(decimal, System.Text.Json.Nodes.JsonNodeOptions?)`；输入表达式：`JsonValue.Create(value)`；返回值紧邻使用处：`ConditionalExpressionSyntax: value == decimal.Truncate(value) ? JsonValue.Create((long)value) : JsonValue.Create(value)`
- `System.Text.Json.Nodes.JsonValue.Create(long, System.Text.Json.Nodes.JsonNodeOptions?)`；输入表达式：`JsonValue.Create((long)value)`；返回值紧邻使用处：`ConditionalExpressionSyntax: value == decimal.Truncate(value) ? JsonValue.Create((long)value) : JsonValue.Create(value)`

**赋值（含属性/字段和局部值）：**

- `c[key]` = `value`
- `z[index]` = `Revert(z[index], old, added, path)`

<a id="symbol-dd91210e87c0"></a>

## `NationalSpire.PrivateInteractionHistory.Restore(NationalSpire.CareerData, string, System.Text.Json.Nodes.JsonObject, bool) — private static void Restore(CareerData d, string id, JsonObject state, bool contract)`

来源：源码第 152 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateInteractionHistory.Rewind(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn)`](PrivateInteractionUndo.cs.md#symbol-f2cc1906a6b6)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`](LifeData.cs.md#symbol-bcb55555a432)；[`NationalSpire.ClubCoaching.ClearPlayerPosition(NationalSpire.OwnedClubState)`](ClubCoaching.cs.md#symbol-d8f43426e219)；[`NationalSpire.ClubCoaching.RestoreTraining(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.CoachTrainingPlan>)`](ClubCoaching.cs.md#symbol-0644d2f9c30d)；[`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-24bc82bdbbd4)；[`NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`](PrivateAppointments.cs.md#symbol-32f6566791d2)；[`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-3712b7336055)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；[`NationalSpire.PrivateProfileChanges.SetValue(NationalSpire.CareerPerson, string, string)`](PrivateProfileChanges.cs.md#symbol-ad07c3469174)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；`System.Math.Clamp(int, int, int)`；`System.Text.Json.Nodes.JsonNode?.Deserialize<TValue>(System.Text.Json.JsonSerializerOptions?)`；`System.Text.Json.Nodes.JsonNode.AsObject()`；`System.Text.Json.Nodes.JsonNode.GetValue<T>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerClub.Budget`；`NationalSpire.CareerClub.Id`；`NationalSpire.CareerData.CommunityMemories`；`NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerLifeState.CreditFraction`；`NationalSpire.CareerLifeState.Events`；`NationalSpire.CareerLifeState.Ledger`；`NationalSpire.CareerLifeState.Relationships`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.ClubPosition`；`NationalSpire.CareerPerson.Learning`；`NationalSpire.CareerPerson.PrivateProfileReceipts`；`NationalSpire.CareerPerson.Role`；`NationalSpire.ClubCoaching.ClearPlayerPosition(NationalSpire.OwnedClubState)`；`NationalSpire.ClubCoaching.RestoreTraining(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.CoachTrainingPlan>)`；`NationalSpire.CoachLineupRequest.ClubId`；`NationalSpire.CoachLineupRequest.First`；`NationalSpire.CoachLineupRequest.Id`；`NationalSpire.CoachLineupRequest.Season`；`NationalSpire.CoachLineupRequest.Second`；`NationalSpire.CoachLineupRequest.State`；`NationalSpire.EsportsCareer.Clubs`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsCareer.LineupRequests`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.NpcLearning.MoodDay`；`NationalSpire.NpcLearning.MoodStrength`；`NationalSpire.NpcLearning.MoodUntil`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubState.PlayerNextPosition`；`NationalSpire.OwnedClubState.PlayerPositionRequest`；`NationalSpire.OwnedClubState.PlayerPositionSeason`；`NationalSpire.OwnedClubState.PlayerReplacement`；`NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMailbox.Relations`；`NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateProfileChanges.SetValue(NationalSpire.CareerPerson, string, string)`；`NationalSpire.PrivateRelation.Favour`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, entry.Key)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(d, entry.Key) is { } member`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(d, id)!`
- `NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`；输入表达式：`CareerMoney.Add(d, state["credits"]!.Deserialize<decimal>())`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Add(d, state["credits"]!.Deserialize<decimal>());`
- `NationalSpire.ClubCoaching.ClearPlayerPosition(NationalSpire.OwnedClubState)`；输入表达式：`ClubCoaching.ClearPlayerPosition(seatClub)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubCoaching.ClearPlayerPosition(seatClub);`
- `NationalSpire.ClubCoaching.RestoreTraining(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.CoachTrainingPlan>)`；输入表达式：`ClubCoaching.RestoreTraining(d, id, restored)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubCoaching.RestoreTraining(d, id, restored);`
- `NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.IsHuman(d, id)`；返回值紧邻使用处：`IfStatementSyntax: if (GroupChats.IsHuman(d, id))          { PrivateMessages.Mailbox(d).Conversations[id].Offers = state["offers"]!.Deserialize<List<PrivateOffer>>()!; return; }`
- `NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`；输入表达式：`PrivateAppointments.IsPrivate(m)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateAppointments.IsPrivate(m) && m.OpponentId == id`
- `NationalSpire.PrivateMessages.Conversation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Conversation(d, id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Conversation(d, id).Offers`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(d).Conversations`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(d).Relations`
- `NationalSpire.PrivateProfileChanges.SetValue(NationalSpire.CareerPerson, string, string)`；输入表达式：`PrivateProfileChanges.SetValue(p, field.Key, field.Value!.GetValue<string>())`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateProfileChanges.SetValue(p, field.Key, field.Value!.GetValue<string>());`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`budgets.TryGetValue(club.Id, out int amount)`；返回值紧邻使用处：`IfStatementSyntax: if (budgets.TryGetValue(club.Id, out int amount)) club.Budget = amount;`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`applied.Any(a => a.ClubId == r.ClubId && a.Season >= r.Season                  && (a.First == r.First || a.First == r.Second || a.Second == r.First || a.Second == r.Second))`；返回值紧邻使用处：`BinaryExpressionSyntax: r.State == "待生效" && applied.Any(a => a.ClubId == r.ClubId && a.Season >= r.Season                  && (a.First == r.First || a.First == r.Second || a.Second == r.First || a.Second == r.Second))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.LineupRequests.Any(r => r.Id == seatClub.PlayerPositionRequest && r.State == "已生效")`；返回值紧邻使用处：`IfStatementSyntax: if (d.Esports.LineupRequests.Any(r => r.Id == seatClub.PlayerPositionRequest && r.State == "已生效")) ClubCoaching.ClearPlayerPosition(seatClub);`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Esports.LineupRequests.Where(r => r.State == "已生效").ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Esports.LineupRequests.Where(r => r.State == "已生效").ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.LineupRequests.Where(r => r.State == "待生效" && applied.Any(a => a.ClubId == r.ClubId && a.Season >= r.Season                  && (a.First == r.First || a.First == r.Second || a.Second == r.First || a.Second == r.Second)))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var request in d.Esports.LineupRequests.Where(r => r.State == "待生效" && applied.Any(a => a.ClubId == r.ClubId && a.Season >= r.Season                  && (a.First == r.First || a.First == r.Second || a.Second == r.First || a.Second == r.Second)))) request.State = "已替换";`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.LineupRequests.Where(r => r.State == "已生效")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.LineupRequests.Where(r => r.State == "已生效").ToList`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Esports.LineupRequests.Add(request)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.LineupRequests.Add(request);`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`d.Matches.AddRange(state["privateMatches"]!.Deserialize<List<CareerMatch>>()!)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Matches.AddRange(state["privateMatches"]!.Deserialize<List<CareerMatch>>()!);`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`d.Esports.LineupRequests.RemoveAll(r => r.Id == request.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.LineupRequests.RemoveAll(r => r.Id == request.Id);`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`d.Matches.RemoveAll(m => PrivateAppointments.IsPrivate(m) && m.OpponentId == id)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Matches.RemoveAll(m => PrivateAppointments.IsPrivate(m) && m.OpponentId == id);`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(relation.Favour, -100, 100)`；返回值紧邻使用处：`AssignmentExpressionSyntax: relation.Favour = Math.Clamp(relation.Favour, -100, 100)`
- `System.Text.Json.Nodes.JsonNode?.Deserialize<TValue>(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`.Deserialize<OwnedClubState>()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: state["owned"]?.Deserialize<OwnedClubState>()`
- `System.Text.Json.Nodes.JsonNode?.Deserialize<TValue>(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`state["clubBudgets"]!.Deserialize<Dictionary<string, int>>()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: state["clubBudgets"]!.Deserialize<Dictionary<string, int>>()!`
- `System.Text.Json.Nodes.JsonNode?.Deserialize<TValue>(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`state["coachTraining"]!.Deserialize<List<CoachTrainingPlan>>()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: state["coachTraining"]!.Deserialize<List<CoachTrainingPlan>>()!`
- `System.Text.Json.Nodes.JsonNode?.Deserialize<TValue>(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`state["competitions"]!.Deserialize<List<WorldCompetition>>()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: state["competitions"]!.Deserialize<List<WorldCompetition>>()!`
- `System.Text.Json.Nodes.JsonNode?.Deserialize<TValue>(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`state["credits"]!.Deserialize<decimal>()`；返回值紧邻使用处：`ArgumentSyntax: state["credits"]!.Deserialize<decimal>()`
- `System.Text.Json.Nodes.JsonNode?.Deserialize<TValue>(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`state["events"]!.Deserialize<List<LifeEvent>>()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: state["events"]!.Deserialize<List<LifeEvent>>()!`
- `System.Text.Json.Nodes.JsonNode?.Deserialize<TValue>(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`state["learning"]!.Deserialize<NpcLearning>()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: state["learning"]!.Deserialize<NpcLearning>()!`
- `System.Text.Json.Nodes.JsonNode?.Deserialize<TValue>(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`state["ledger"]!.Deserialize<List<FinanceEntry>>()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: state["ledger"]!.Deserialize<List<FinanceEntry>>()!`
- `System.Text.Json.Nodes.JsonNode?.Deserialize<TValue>(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`state["lineups"]!.Deserialize<List<CoachLineupRequest>>()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: state["lineups"]!.Deserialize<List<CoachLineupRequest>>()!`
- `System.Text.Json.Nodes.JsonNode?.Deserialize<TValue>(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`state["matches"]!.Deserialize<List<CareerMatch>>()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: state["matches"]!.Deserialize<List<CareerMatch>>()!`
- `System.Text.Json.Nodes.JsonNode?.Deserialize<TValue>(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`state["memories"]!.Deserialize<List<CommunityMemory>>()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: state["memories"]!.Deserialize<List<CommunityMemory>>()!`
- `System.Text.Json.Nodes.JsonNode?.Deserialize<TValue>(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`state["mood"]!["MoodDay"]!.Deserialize<int>()`；返回值紧邻使用处：`AssignmentExpressionSyntax: p.Learning.MoodDay = state["mood"]!["MoodDay"]!.Deserialize<int>()`
- `System.Text.Json.Nodes.JsonNode?.Deserialize<TValue>(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`state["mood"]!["MoodStrength"]!.Deserialize<double>()`；返回值紧邻使用处：`AssignmentExpressionSyntax: p.Learning.MoodStrength = state["mood"]!["MoodStrength"]!.Deserialize<double>()`
- `System.Text.Json.Nodes.JsonNode?.Deserialize<TValue>(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`state["mood"]!["MoodUntil"]!.Deserialize<int>()`；返回值紧邻使用处：`AssignmentExpressionSyntax: p.Learning.MoodUntil = state["mood"]!["MoodUntil"]!.Deserialize<int>()`
- `System.Text.Json.Nodes.JsonNode?.Deserialize<TValue>(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`state["offers"]!.Deserialize<List<PrivateOffer>>()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: state["offers"]!.Deserialize<List<PrivateOffer>>()!`
- `System.Text.Json.Nodes.JsonNode?.Deserialize<TValue>(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`state["privateMatches"]!.Deserialize<List<CareerMatch>>()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: state["privateMatches"]!.Deserialize<List<CareerMatch>>()!`
- `System.Text.Json.Nodes.JsonNode?.Deserialize<TValue>(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`state["receipts"]!.Deserialize<HashSet<string>>()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: state["receipts"]!.Deserialize<HashSet<string>>()!`
- `System.Text.Json.Nodes.JsonNode?.Deserialize<TValue>(System.Text.Json.JsonSerializerOptions?)`；输入表达式：`state["relation"]!.Deserialize<PrivateRelation>()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: state["relation"]!.Deserialize<PrivateRelation>()!`
- `System.Text.Json.Nodes.JsonNode.AsObject()`；输入表达式：`state["profile"]!.AsObject()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var field in state["profile"]!.AsObject()) PrivateProfileChanges.SetValue(p, field.Key, field.Value!.GetValue<string>());`
- `System.Text.Json.Nodes.JsonNode.GetValue<T>()`；输入表达式：`.GetValue<string>()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: state["position"]?.GetValue<string>()`
- `System.Text.Json.Nodes.JsonNode.GetValue<T>()`；输入表达式：`entry.Value!["ClubPosition"]!.GetValue<string>()`；返回值紧邻使用处：`AssignmentExpressionSyntax: member.ClubPosition = entry.Value!["ClubPosition"]!.GetValue<string>()`
- `System.Text.Json.Nodes.JsonNode.GetValue<T>()`；输入表达式：`entry.Value!["Role"]!.GetValue<string>()`；返回值紧邻使用处：`AssignmentExpressionSyntax: member.Role = entry.Value!["Role"]!.GetValue<string>()`
- `System.Text.Json.Nodes.JsonNode.GetValue<T>()`；输入表达式：`field.Value!.GetValue<string>()`；返回值紧邻使用处：`ArgumentSyntax: field.Value!.GetValue<string>()`
- `System.Text.Json.Nodes.JsonNode.GetValue<T>()`；输入表达式：`seat["ClubId"]!.GetValue<string>()`；返回值紧邻使用处：`BinaryExpressionSyntax: seat["ClubId"]!.GetValue<string>() == seatClub.ClubId`
- `System.Text.Json.Nodes.JsonNode.GetValue<T>()`；输入表达式：`seat["PlayerNextPosition"]!.GetValue<string>()`；返回值紧邻使用处：`AssignmentExpressionSyntax: seatClub.PlayerNextPosition = seat["PlayerNextPosition"]!.GetValue<string>()`
- `System.Text.Json.Nodes.JsonNode.GetValue<T>()`；输入表达式：`seat["PlayerPositionRequest"]!.GetValue<string>()`；返回值紧邻使用处：`AssignmentExpressionSyntax: seatClub.PlayerPositionRequest = seat["PlayerPositionRequest"]!.GetValue<string>()`
- `System.Text.Json.Nodes.JsonNode.GetValue<T>()`；输入表达式：`seat["PlayerPositionSeason"]!.GetValue<int>()`；返回值紧邻使用处：`AssignmentExpressionSyntax: seatClub.PlayerPositionSeason = seat["PlayerPositionSeason"]!.GetValue<int>()`
- `System.Text.Json.Nodes.JsonNode.GetValue<T>()`；输入表达式：`seat["PlayerReplacement"]!.GetValue<string>()`；返回值紧邻使用处：`AssignmentExpressionSyntax: seatClub.PlayerReplacement = seat["PlayerReplacement"]!.GetValue<string>()`
- `System.Text.Json.Nodes.JsonNode.GetValue<T>()`；输入表达式：`state["club"]!.GetValue<string>()`；返回值紧邻使用处：`AssignmentExpressionSyntax: p.ClubId = state["club"]!.GetValue<string>()`
- `System.Text.Json.Nodes.JsonNode.GetValue<T>()`；输入表达式：`state["role"]!.GetValue<string>()`；返回值紧邻使用处：`AssignmentExpressionSyntax: p.Role = state["role"]!.GetValue<string>()`

**赋值（含属性/字段和局部值）：**

- `club.Budget` = `amount`
- `d.CommunityMemories` = `state["memories"]!.Deserialize<List<CommunityMemory>>()!`
- `d.Credits` = `0`
- `d.Esports.Competitions` = `state["competitions"]!.Deserialize<List<WorldCompetition>>()!`
- `d.Esports.LineupRequests` = `state["lineups"]!.Deserialize<List<CoachLineupRequest>>()!`
- `d.Esports.OwnedClub` = `state["owned"]?.Deserialize<OwnedClubState>()`
- `d.Life.CreditFraction` = `0`
- `d.Life.Events` = `state["events"]!.Deserialize<List<LifeEvent>>()!`
- `d.Life.Ledger` = `state["ledger"]!.Deserialize<List<FinanceEntry>>()!`
- `d.Life.Relationships[id]` = `relation.Favour`
- `d.Matches` = `state["matches"]!.Deserialize<List<CareerMatch>>()!`
- `member.ClubPosition` = `entry.Value!["ClubPosition"]!.GetValue<string>()`
- `member.Role` = `entry.Value!["Role"]!.GetValue<string>()`
- `p.ClubId` = `state["club"]!.GetValue<string>()`
- `p.ClubPosition` = `state["position"]?.GetValue<string>() ?? p.ClubPosition`
- `p.Learning.MoodDay` = `state["mood"]!["MoodDay"]!.Deserialize<int>()`
- `p.Learning.MoodStrength` = `state["mood"]!["MoodStrength"]!.Deserialize<double>()`
- `p.Learning.MoodUntil` = `state["mood"]!["MoodUntil"]!.Deserialize<int>()`
- `p.Learning` = `state["learning"]!.Deserialize<NpcLearning>()!`
- `p.PrivateProfileReceipts` = `state["receipts"]!.Deserialize<HashSet<string>>()!`
- `p.Role` = `state["role"]!.GetValue<string>()`
- `PrivateMessages.Conversation(d, id).Offers` = `state["offers"]!.Deserialize<List<PrivateOffer>>()!`
- `PrivateMessages.Mailbox(d).Conversations[id].Offers` = `state["offers"]!.Deserialize<List<PrivateOffer>>()!`
- `PrivateMessages.Mailbox(d).Relations[id]` = `relation`
- `relation.Favour` = `Math.Clamp(relation.Favour, -100, 100)`
- `request.State` = `"已替换"`
- `seatClub.PlayerNextPosition` = `seat["PlayerNextPosition"]!.GetValue<string>()`
- `seatClub.PlayerPositionRequest` = `seat["PlayerPositionRequest"]!.GetValue<string>()`
- `seatClub.PlayerPositionSeason` = `seat["PlayerPositionSeason"]!.GetValue<int>()`
- `seatClub.PlayerReplacement` = `seat["PlayerReplacement"]!.GetValue<string>()`

<a id="symbol-f2cc1906a6b6"></a>

## `NationalSpire.PrivateInteractionHistory.Rewind(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn) — public static string? Rewind(CareerData d, PrivateConversation c, PrivateTurn turn)`

来源：源码第 210 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupChats.Rewind(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn)`](GroupChats.cs.md#symbol-d45d31e160a9)；[`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`](PrivateAppointments.cs.md#symbol-32f6566791d2)；[`NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool)`](PrivateInteractionUndo.cs.md#symbol-de9e985d044d)；[`NationalSpire.PrivateInteractionHistory.Restore(NationalSpire.CareerData, string, System.Text.Json.Nodes.JsonObject, bool)`](PrivateInteractionUndo.cs.md#symbol-dd91210e87c0)；[`NationalSpire.PrivateInteractionHistory.Revert(System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, string)`](PrivateInteractionUndo.cs.md#symbol-35a5c57d58cd)；[`NationalSpire.PrivateProfileChanges.SetValue(NationalSpire.CareerPerson, string, string)`](PrivateProfileChanges.cs.md#symbol-ad07c3469174)；[`NationalSpire.PrivateProfileChanges.Value(NationalSpire.CareerPerson, string)`](PrivateProfileChanges.cs.md#symbol-2ca919f5172e)；`System.Collections.Generic.HashSet<T>.Remove(T)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Min<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Clear()`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.IndexOf(T)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.CommunityMemories`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.Posts`；`NationalSpire.CareerData.SavedThreads`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Live`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.OpponentPrepared`；`NationalSpire.CareerMatch.OpponentSeconds`；`NationalSpire.CareerMatch.Status`；`NationalSpire.CareerPerson.PrivateProfileReceipts`；`NationalSpire.CommunityMemory.PostId`；`NationalSpire.CommunityPost.Id`；`NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`；`NationalSpire.PrivateConversation.BigSummaries`；`NationalSpire.PrivateConversation.ContextStart`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateConversation.SmallSummaries`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool)`；`NationalSpire.PrivateInteractionHistory.Restore(NationalSpire.CareerData, string, System.Text.Json.Nodes.JsonObject, bool)`；`NationalSpire.PrivateInteractionHistory.Revert(System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, string)`；`NationalSpire.PrivateInteractionUndo.After`；`NationalSpire.PrivateInteractionUndo.Before`；`NationalSpire.PrivateInteractionUndo.Contract`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.MatchId`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.TurnId`；`NationalSpire.PrivateProfileChange.After`；`NationalSpire.PrivateProfileChange.Before`；`NationalSpire.PrivateProfileChange.Field`；`NationalSpire.PrivateProfileChange.Id`；`NationalSpire.PrivateProfileChanges.SetValue(NationalSpire.CareerPerson, string, string)`；`NationalSpire.PrivateProfileChanges.Value(NationalSpire.CareerPerson, string)`；`NationalSpire.PrivateSummary.From`；`NationalSpire.PrivateSummary.Through`；`NationalSpire.PrivateTurn.Applied`；`NationalSpire.PrivateTurn.Context`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.InteractionUndo`；`NationalSpire.PrivateTurn.Learning`；`NationalSpire.PrivateTurn.Mood`；`NationalSpire.PrivateTurn.ProfileChanges`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, c.PersonId)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(d, c.PersonId)!`
- `NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`；输入表达式：`PrivateAppointments.IsPrivate(m)`；返回值紧邻使用处：`BinaryExpressionSyntax: m.Id == offer.MatchId && PrivateAppointments.IsPrivate(m)`
- `NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool)`；输入表达式：`Capture(d, c.PersonId, undo.Contract)`；返回值紧邻使用处：`ArgumentSyntax: Capture(d, c.PersonId, undo.Contract)`
- `NationalSpire.PrivateInteractionHistory.Restore(NationalSpire.CareerData, string, System.Text.Json.Nodes.JsonObject, bool)`；输入表达式：`Restore(d, c.PersonId, (JsonObject)state!, undo.Contract)`；返回值紧邻使用处：`ExpressionStatementSyntax: Restore(d, c.PersonId, (JsonObject)state!, undo.Contract);`
- `NationalSpire.PrivateInteractionHistory.Revert(System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, System.Text.Json.Nodes.JsonNode?, string)`；输入表达式：`Revert(Capture(d, c.PersonId, undo.Contract), undo.Before, undo.After)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Revert(Capture(d, c.PersonId, undo.Contract), undo.Before, undo.After)`
- `NationalSpire.PrivateProfileChanges.SetValue(NationalSpire.CareerPerson, string, string)`；输入表达式：`PrivateProfileChanges.SetValue(p, change.Field, change.Before)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateProfileChanges.SetValue(p, change.Field, change.Before);`
- `NationalSpire.PrivateProfileChanges.Value(NationalSpire.CareerPerson, string)`；输入表达式：`PrivateProfileChanges.Value(p, change.Field)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateProfileChanges.Value(p, change.Field) == change.After`
- `System.Collections.Generic.HashSet<T>.Remove(T)`；输入表达式：`p.PrivateProfileReceipts.Remove(change.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: p.PrivateProfileReceipts.Remove(change.Id);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.Any(m => m.Id == o.MatchId && (d.PendingMatchId == m.Id || m.Status is not ("待赛" or "已取消")))`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Kind == "match" && o.MatchId.Length > 0 && d.Matches.Any(m => m.Id == o.MatchId && (d.PendingMatchId == m.Id || m.Status is not ("待赛" or "已取消")))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`offers.Any(o => o.Kind == "activity" && o.State == "已赴约")`；返回值紧邻使用处：`IfStatementSyntax: if (offers.Any(o => o.Kind == "activity" && o.State == "已赴约"))              return "这条回复的活动已经赴约，无法通过重新生成撤回。";`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`offers.Any(o => o.Kind == "contract" && o.State == "已确认")`；返回值紧邻使用处：`BinaryExpressionSyntax: offers.Any(o => o.Kind == "contract" && o.State == "已确认") && !turn.InteractionUndo.Any(u => u.Contract)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`offers.Any(o => o.Kind == "match" && o.MatchId.Length > 0 && d.Matches.Any(m => m.Id == o.MatchId && (d.PendingMatchId == m.Id || m.Status is not ("待赛" or "已取消"))))`；返回值紧邻使用处：`IfStatementSyntax: if (offers.Any(o => o.Kind == "match" && o.MatchId.Length > 0 && d.Matches.Any(m => m.Id == o.MatchId && (d.PendingMatchId == m.Id || m.Status is not ("待赛" or "已取消")))))              return "这条回复的约战已经开始或结算，无法通过重新生成撤回赛果。";`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`turn.InteractionUndo.Any(u => u.Contract)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !turn.InteractionUndo.Any(u => u.Contract)`
- `System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；输入表达式：`turn.InteractionUndo.AsEnumerable()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: turn.InteractionUndo.AsEnumerable().Reverse`
- `System.Collections.Generic.IEnumerable<TSource>.AsEnumerable<TSource>()`；输入表达式：`turn.ProfileChanges.AsEnumerable()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: turn.ProfileChanges.AsEnumerable().Reverse`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`c.SmallSummaries.Concat(c.BigSummaries)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.SmallSummaries.Concat(c.BigSummaries).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Min<TSource>(System.Func<TSource, int>)`；输入表达式：`summaries.Min(s => s.From)`；返回值紧邻使用处：`ArgumentSyntax: summaries.Min(s => s.From)`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`turn.InteractionUndo.AsEnumerable().Reverse()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var undo in turn.InteractionUndo.AsEnumerable().Reverse())          {              var state = Revert(Capture(d, c.PersonId, undo.Contract), undo.Before, undo.After);              Restore(d, c.PersonId, (JsonObject)state!, undo.Contract);          }`
- `System.Collections.Generic.IEnumerable<TSource>.Reverse<TSource>()`；输入表达式：`turn.ProfileChanges.AsEnumerable().Reverse()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var change in turn.ProfileChanges.AsEnumerable().Reverse())                  if (PrivateProfileChanges.Value(p, change.Field) == change.After) PrivateProfileChanges.SetValue(p, change.Field, change.Before);`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`c.Offers.Where(o => o.TurnId == turn.Id).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Offers.Where(o => o.TurnId == turn.Id).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`c.SmallSummaries.Concat(c.BigSummaries).Where(s => s.Through > index).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.SmallSummaries.Concat(c.BigSummaries).Where(s => s.Through > index).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Offers.Where(o => o.TurnId == turn.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Offers.Where(o => o.TurnId == turn.Id).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.SmallSummaries.Concat(c.BigSummaries).Where(s => s.Through > index)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.SmallSummaries.Concat(c.BigSummaries).Where(s => s.Through > index).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.Where(m => m.OpponentId == c.PersonId && m.Status == "待赛" && m.Live == null && m.Id != d.PendingMatchId)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var match in d.Matches.Where(m => m.OpponentId == c.PersonId && m.Status == "待赛" && m.Live == null && m.Id != d.PendingMatchId))          { match.OpponentPrepared = false; match.OpponentSeconds = null; }`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`turn.InteractionUndo.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: turn.InteractionUndo.Clear();`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`turn.ProfileChanges.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: turn.ProfileChanges.Clear();`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`summaries.Contains(s)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: s => summaries.Contains(s)`
- `System.Collections.Generic.List<T>.IndexOf(T)`；输入表达式：`c.Turns.IndexOf(turn)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Turns.IndexOf(turn)`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`c.BigSummaries.RemoveAll(s => summaries.Contains(s))`；返回值紧邻使用处：`ExpressionStatementSyntax: c.BigSummaries.RemoveAll(s => summaries.Contains(s));`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`c.Offers.RemoveAll(o => o.TurnId == turn.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Offers.RemoveAll(o => o.TurnId == turn.Id);`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`c.SmallSummaries.RemoveAll(s => summaries.Contains(s))`；返回值紧邻使用处：`ExpressionStatementSyntax: c.SmallSummaries.RemoveAll(s => summaries.Contains(s));`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`d.CommunityMemories.RemoveAll(m => m.PostId == offer.MatchId)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.CommunityMemories.RemoveAll(m => m.PostId == offer.MatchId);`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`d.Matches.RemoveAll(m => m.Id == offer.MatchId && PrivateAppointments.IsPrivate(m))`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Matches.RemoveAll(m => m.Id == offer.MatchId && PrivateAppointments.IsPrivate(m));`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`d.Posts.RemoveAll(p => p.Id == offer.MatchId)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Posts.RemoveAll(p => p.Id == offer.MatchId);`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`d.SavedThreads.RemoveAll(p => p.Id == offer.MatchId)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.SavedThreads.RemoveAll(p => p.Id == offer.MatchId);`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(c.ContextStart, summaries.Min(s => s.From))`；返回值紧邻使用处：`AssignmentExpressionSyntax: c.ContextStart = Math.Min(c.ContextStart, summaries.Min(s => s.From))`

**赋值（含属性/字段和局部值）：**

- `c.ContextStart` = `Math.Min(c.ContextStart, summaries.Min(s => s.From))`
- `match.OpponentPrepared` = `false`
- `match.OpponentSeconds` = `null`
- `turn.Applied` = `false`
- `turn.Context` = `""`
- `turn.Learning` = `null`
- `turn.Mood` = `null`
