# CalendarPlansScreen.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`0D1002786EEE7201A10A69047B4F3E9794056CF570838E703A68F75181105745`。来源：[源码](../../CalendarPlansScreen.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`、`NationalSpire.CareerScreen.CalendarPlan`、`NationalSpire.CareerScreen.PlanCard`、`NationalSpire.CareerScreen.AgendaItem`、`NationalSpire.CareerScreen.CalendarPeriod`。

字段、事件及初始值（源码原样）：

```csharp
private const string PersonalPlans = "个人生活安排", TrainingPlans = "俱乐部训练安排", SponsorPlans = "俱乐部赞助";
```

<a id="symbol-217e72b481b2"></a>

## `NationalSpire.CareerScreen.ClubPlan(NationalSpire.LifeActivity) — private static bool ClubPlan(LifeActivity activity)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.CalendarPlans(NationalSpire.CareerData)`](CalendarPlansScreen.cs.md#symbol-60a9060c5331)；[`NationalSpire.CareerScreen.PendingPlans(NationalSpire.CareerData)`](CareerDashboard.cs.md#symbol-bf1cbb6ed943)；[`NationalSpire.CareerScreen.PlanPane(NationalSpire.CareerData, Godot.VBoxContainer, Godot.ScrollContainer, System.Collections.Generic.List<NationalSpire.CareerScreen.CalendarPlan>, NationalSpire.CalendarDayButton[])`](CalendarPlansScreen.cs.md#symbol-078c4f908d4c)

**调用：** [`NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`](CareerTraining.cs.md#symbol-98adbc7a75dc)；[`NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-f251644672be)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`；`NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`；`NationalSpire.LifeActivity.Kind`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`CareerTraining.IsTraining(activity)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerTraining.IsTraining(activity) || ClubPrograms.IsTraining(activity)`
- `NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`ClubPrograms.IsTraining(activity)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerTraining.IsTraining(activity) || ClubPrograms.IsTraining(activity)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-60a9060c5331"></a>

## `NationalSpire.CareerScreen.CalendarPlans(NationalSpire.CareerData) — private List<CalendarPlan> CalendarPlans(CareerData d)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Choose(string, string)`](CalendarPlansScreen.cs.md#symbol-9a1d5ca75d7a)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerLife.Accept(NationalSpire.CareerData, string, string)`](CareerLife.cs.md#symbol-cce5ea9d3250)；[`NationalSpire.CareerLife.Expected(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerLife.cs.md#symbol-44d430d90686)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerRelics.Cost(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-648cf5a95449)；[`NationalSpire.CareerRelics.Duration(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-5a1db0b8215e)；[`NationalSpire.CareerScreen.AgendaRange(NationalSpire.CareerData, int, int)`](CalendarPlansScreen.cs.md#symbol-9c53a348d954)；[`NationalSpire.CareerScreen.ClubAction(NationalSpire.CareerData, string, string, string, System.Action?)`](OwnedClubScreen.cs.md#symbol-9c161e058b4e)；[`NationalSpire.CareerScreen.ClubPlan(NationalSpire.LifeActivity)`](CalendarPlansScreen.cs.md#symbol-217e72b481b2)；[`NationalSpire.CareerScreen.FinishPlan(string?)`](CalendarPlansScreen.cs.md#symbol-100b2aec3e40)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.TeamPreparationPlans(NationalSpire.CareerData)`](CalendarPlansScreen.cs.md#symbol-a5b07c06671a)；[`NationalSpire.CareerTraining.Details(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerTraining.cs.md#symbol-2710ec7157e0)；[`NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`](CareerTraining.cs.md#symbol-98adbc7a75dc)；[`NationalSpire.CareerTraining.Kind(string)`](CareerTraining.cs.md#symbol-f1d9371f3455)；[`NationalSpire.CareerTraining.Snapshot(NationalSpire.CareerData, NationalSpire.LifeActivity, bool)`](CareerTraining.cs.md#symbol-feb4623577e9)；[`NationalSpire.CareerTraining.Targets(NationalSpire.CareerData)`](CareerTraining.cs.md#symbol-89a5b7a8727b)；[`NationalSpire.ClubAudience.Total(NationalSpire.CareerData, string)`](ClubAudience.cs.md#symbol-6a78e48d0de3)；[`NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-1ed5bef75319)；[`NationalSpire.ClubPrograms.Details(NationalSpire.CareerData, NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-53ba79900734)；[`NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-f251644672be)；[`NationalSpire.ClubPrograms.Snapshot(NationalSpire.CareerData, NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-48edcdfd89d0)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；[`NationalSpire.GameCalendar.Season(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-c5c99167e359)；[`NationalSpire.LifeActivity.PreviewFor(NationalSpire.CareerData, string)`](LifeData.cs.md#symbol-f86a52faa0da)；[`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-8c9ea9f33c3c)；[`NationalSpire.OwnedClubs.SponsorQuote(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-fb2b56604db1)；[`NationalSpire.OwnedClubs.SponsorWeekly(NationalSpire.OwnedSponsor?, int)`](OwnedClubs.cs.md#symbol-c9d09ed04c48)；[`NationalSpire.OwnedClubs.SponsorWinBonus(NationalSpire.OwnedSponsor, int)`](OwnedClubs.cs.md#symbol-27e3d96628f4)；[`NationalSpire.RegionalOrganizations.SponsorDescription(string)`](RegionalOrganizations.cs.md#symbol-421e3c666278)；[`NationalSpire.SponsorIncome.Retainer(NationalSpire.CareerData, NationalSpire.SponsorContract)`](SponsorIncome.cs.md#symbol-0442434a4986)；`NationalSpire.CareerScreen.CalendarPlan.CalendarPlan(string, string, string, string, string, string, System.Func<int, bool>, System.Action?, bool, System.Collections.Generic.List<NationalSpire.CareerPerson>?, string, int, string, System.Func<string>?)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerLife.Accept(NationalSpire.CareerData, string, string)`；`NationalSpire.CareerLife.Expected(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.CareerLifeState.Activities`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerRelics.Cost(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.CareerRelics.Duration(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.CareerScreen._planKey`；`NationalSpire.CareerScreen._planTarget`；`NationalSpire.CareerScreen.AgendaRange(NationalSpire.CareerData, int, int)`；`NationalSpire.CareerScreen.CanManageClub`；`NationalSpire.CareerScreen.ClearPlan()`；`NationalSpire.CareerScreen.ClubAction(NationalSpire.CareerData, string, string, string, System.Action?)`；`NationalSpire.CareerScreen.ClubPlan(NationalSpire.LifeActivity)`；`NationalSpire.CareerScreen.FinishPlan(string?)`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；`NationalSpire.CareerScreen.PersonalPlans`；`NationalSpire.CareerScreen.SponsorPlans`；`NationalSpire.CareerScreen.TeamPreparationPlans(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.TrainingPlans`；`NationalSpire.CareerTraining.Details(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`；`NationalSpire.CareerTraining.Kind(string)`；`NationalSpire.CareerTraining.Snapshot(NationalSpire.CareerData, NationalSpire.LifeActivity, bool)`；`NationalSpire.CareerTraining.Targets(NationalSpire.CareerData)`；`NationalSpire.ClubAudience.Total(NationalSpire.CareerData, string)`；`NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`；`NationalSpire.ClubPrograms.Details(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`；`NationalSpire.ClubPrograms.Snapshot(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.CoachTrainingPlan.ClubId`；`NationalSpire.CoachTrainingPlan.CoachId`；`NationalSpire.CoachTrainingPlan.Content`；`NationalSpire.CoachTrainingPlan.EndDay`；`NationalSpire.CoachTrainingPlan.Id`；`NationalSpire.CoachTrainingPlan.PersonId`；`NationalSpire.CoachTrainingPlan.StartDay`；`NationalSpire.CoachTrainingPlan.State`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.EsportsCareer.Sponsors`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；`NationalSpire.GameCalendar.Season(NationalSpire.CareerData, int)`；`NationalSpire.LifeActivity.ClubId`；`NationalSpire.LifeActivity.Detail`；`NationalSpire.LifeActivity.ExpiresDay`；`NationalSpire.LifeActivity.Id`；`NationalSpire.LifeActivity.Kind`；`NationalSpire.LifeActivity.LongProject`；`NationalSpire.LifeActivity.PersonId`；`NationalSpire.LifeActivity.PreviewFor(NationalSpire.CareerData, string)`；`NationalSpire.LifeActivity.StartedDay`；`NationalSpire.LifeActivity.Status`；`NationalSpire.LifeActivity.Title`；`NationalSpire.LifeActivity.TrainingEnd`；`NationalSpire.LifeActivity.TrainingStart`；`NationalSpire.LifeActivity.TrainingTargets`；`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.SponsorQuote(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubs.SponsorWeekly(NationalSpire.OwnedSponsor?, int)`；`NationalSpire.OwnedClubs.SponsorWinBonus(NationalSpire.OwnedSponsor, int)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubState.NextPayDay`；`NationalSpire.OwnedClubState.NextSponsor`；`NationalSpire.OwnedClubState.Sponsor`；`NationalSpire.OwnedSponsor.Brand`；`NationalSpire.OwnedSponsor.EndDay`；`NationalSpire.OwnedSponsor.Id`；`NationalSpire.RegionalOrganizations.SponsorDescription(string)`；`NationalSpire.SponsorContract.Brand`；`NationalSpire.SponsorContract.EndedDay`；`NationalSpire.SponsorContract.EndSeason`；`NationalSpire.SponsorContract.Id`；`NationalSpire.SponsorContract.Slogan`；`NationalSpire.SponsorContract.StartSeason`；`NationalSpire.SponsorContract.TargetId`；`NationalSpire.SponsorIncome.Retainer(NationalSpire.CareerData, NationalSpire.SponsorContract)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, target)`；返回值紧邻使用处：`ConditionalExpressionSyntax: a.Kind is "俱乐部" or "经营" ? EsportsWorld.ClubName(d,a.ClubId) : CareerEngine.DisplayName(d, target)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d,id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => CareerEngine.DisplayName(d,id)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d,p.PersonId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.DisplayName(d,p.PersonId)`
- `NationalSpire.CareerLife.Accept(NationalSpire.CareerData, string, string)`；输入表达式：`CareerLife.Accept(d, a.Id, target)`；返回值紧邻使用处：`ArgumentSyntax: CareerLife.Accept(d, a.Id, target)`
- `NationalSpire.CareerLife.Expected(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`CareerLife.Expected(d,quote)`；返回值紧邻使用处：`BinaryExpressionSyntax: quote.Detail+"\n"+CareerLife.Expected(d,quote)`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(OwnedClubs.SponsorWeekly(quote,fans))`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(OwnedClubs.SponsorWeekly(quote,fans))}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(OwnedClubs.SponsorWinBonus(quote,fans))`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(OwnedClubs.SponsorWinBonus(quote,fans))}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(SponsorIncome.Retainer(d,s))`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(SponsorIncome.Retainer(d,s))}`
- `NationalSpire.CareerRelics.Cost(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`CareerRelics.Cost(d, a)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerRelics.Cost(d, a)`
- `NationalSpire.CareerRelics.Duration(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`CareerRelics.Duration(d, a)`；返回值紧邻使用处：`ArgumentSyntax: CareerRelics.Duration(d, a)`
- `NationalSpire.CareerScreen.AgendaRange(NationalSpire.CareerData, int, int)`；输入表达式：`AgendaRange(d,p.StartDay,p.EndDay)`；返回值紧邻使用处：`ArgumentSyntax: AgendaRange(d,p.StartDay,p.EndDay)`
- `NationalSpire.CareerScreen.AgendaRange(NationalSpire.CareerData, int, int)`；输入表达式：`AgendaRange(d,start,end)`；返回值紧邻使用处：`ArgumentSyntax: AgendaRange(d,start,end)`
- `NationalSpire.CareerScreen.CalendarPlan.CalendarPlan(string, string, string, string, string, string, System.Func<int, bool>, System.Action?, bool, System.Collections.Generic.List<NationalSpire.CareerPerson>?, string, int, string, System.Func<string>?)`；输入表达式：`new("active-sponsor:" + s.Id, SponsorPlans, s.Brand, EsportsWorld.ClubName(d,s.TargetId), $"{s.Slogan}\n每赛季支持战队 {CareerMoney.Format(SponsorIncome.Retainer(d,s))}", $"第 {s.StartSeason} 至 {s.EndSeason} 赛季",                      day => GameCalendar.Season(d,day) >= s.StartSeason && GameCalendar.Season(d,day) <= s.EndSeason)`；返回值紧邻使用处：`ArgumentSyntax: new("active-sponsor:" + s.Id, SponsorPlans, s.Brand, EsportsWorld.ClubName(d,s.TargetId), $"{s.Slogan}\n每赛季支持战队 {CareerMoney.Format(SponsorIncome.Retainer(d,s))}", $"第 {s.StartSeason} 至 {s.EndSeason} 赛季",                      day => GameCalendar.Season(d,day) >= s.StartSeason && GameCalendar.Season(d,day) <= s.EndSeason)`
- `NationalSpire.CareerScreen.CalendarPlan.CalendarPlan(string, string, string, string, string, string, System.Func<int, bool>, System.Action?, bool, System.Collections.Generic.List<NationalSpire.CareerPerson>?, string, int, string, System.Func<string>?)`；输入表达式：`new("club-sponsor:" + id, SponsorPlans, quote.Brand + (o.NextSponsor == id ? " · 下期已选" : o.Sponsor?.Id == id ? " · 当前合作" : ""),                      EsportsWorld.ClubName(d,o.ClubId), effect, AgendaRange(d,start,end), day => day >= start && day <= end, () => ClubAction(d, "sponsor", target:id, success:ClearPlan),                      CanManageClub && o.NextSponsor != id)`；返回值紧邻使用处：`ArgumentSyntax: new("club-sponsor:" + id, SponsorPlans, quote.Brand + (o.NextSponsor == id ? " · 下期已选" : o.Sponsor?.Id == id ? " · 当前合作" : ""),                      EsportsWorld.ClubName(d,o.ClubId), effect, AgendaRange(d,start,end), day => day >= start && day <= end, () => ClubAction(d, "sponsor", target:id, success:ClearPlan),                      CanManageClub && o.NextSponsor != id)`
- `NationalSpire.CareerScreen.CalendarPlan.CalendarPlan(string, string, string, string, string, string, System.Func<int, bool>, System.Action?, bool, System.Collections.Generic.List<NationalSpire.CareerPerson>?, string, int, string, System.Func<string>?)`；输入表达式：`new("coach:" + p.Id, TrainingPlans, "教练训练 · " + name,                  name, p.Content, AgendaRange(d,p.StartDay,p.EndDay),                  day => day >= p.StartDay && day <= p.EndDay, () => OpenPrivateMessages(p.CoachId.Length == 0 ? p.PersonId : p.CoachId), ActionText:"查看私信")`；返回值紧邻使用处：`ArgumentSyntax: new("coach:" + p.Id, TrainingPlans, "教练训练 · " + name,                  name, p.Content, AgendaRange(d,p.StartDay,p.EndDay),                  day => day >= p.StartDay && day <= p.EndDay, () => OpenPrivateMessages(p.CoachId.Length == 0 ? p.PersonId : p.CoachId), ActionText:"查看私信")`
- `NationalSpire.CareerScreen.CalendarPlan.CalendarPlan(string, string, string, string, string, string, System.Func<int, bool>, System.Action?, bool, System.Collections.Generic.List<NationalSpire.CareerPerson>?, string, int, string, System.Func<string>?)`；输入表达式：`new(a.Id, club ? TrainingPlans : PersonalPlans, a.Title, names, effect, AgendaRange(d,start,end), day => day >= start && day <= end, () =>              {                  if (MultiplayerCommand("activity", a.Id, target, accepted: ClearPlan)) return;                  FinishPlan(CareerLife.Accept(d, a.Id, target));              }, d.Credits >= cost && !(a.LongProject && d.Life.Activities.Any(x => x.LongProject && x.Status == "进行中")), targets, Cost:cost,                  TrainingDetails: program ? () => ClubPrograms.Details(d, quote) : training ? () => CareerTraining.Details(d, quote) : null)`；返回值紧邻使用处：`ArgumentSyntax: new(a.Id, club ? TrainingPlans : PersonalPlans, a.Title, names, effect, AgendaRange(d,start,end), day => day >= start && day <= end, () =>              {                  if (MultiplayerCommand("activity", a.Id, target, accepted: ClearPlan)) return;                  FinishPlan(CareerLife.Accept(d, a.Id, target));              }, d.Credits >= cost && !(a.LongProject && d.Life.Activities.Any(x => x.LongProject && x.Status == "进行中")), targets, Cost:cost,                  TrainingDetails: program ? () => ClubPrograms.Details(d, quote) : training ? () => CareerTraining.Details(d, quote) : null)`
- `NationalSpire.CareerScreen.ClubAction(NationalSpire.CareerData, string, string, string, System.Action?)`；输入表达式：`ClubAction(d, "sponsor", target:id, success:ClearPlan)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ClubAction(d, "sponsor", target:id, success:ClearPlan)`
- `NationalSpire.CareerScreen.ClubPlan(NationalSpire.LifeActivity)`；输入表达式：`ClubPlan(a)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ClubPlan(a)`
- `NationalSpire.CareerScreen.FinishPlan(string?)`；输入表达式：`FinishPlan(CareerLife.Accept(d, a.Id, target))`；返回值紧邻使用处：`ExpressionStatementSyntax: FinishPlan(CareerLife.Accept(d, a.Id, target));`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("activity", a.Id, target, accepted: ClearPlan)`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("activity", a.Id, target, accepted: ClearPlan)) return;`
- `NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；输入表达式：`OpenPrivateMessages(p.CoachId.Length == 0 ? p.PersonId : p.CoachId)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => OpenPrivateMessages(p.CoachId.Length == 0 ? p.PersonId : p.CoachId)`
- `NationalSpire.CareerScreen.TeamPreparationPlans(NationalSpire.CareerData)`；输入表达式：`TeamPreparationPlans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: TeamPreparationPlans(d).ToList`
- `NationalSpire.CareerTraining.Details(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`CareerTraining.Details(d, quote)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => CareerTraining.Details(d, quote)`
- `NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`CareerTraining.IsTraining(a)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerTraining.IsTraining(a)`
- `NationalSpire.CareerTraining.Kind(string)`；输入表达式：`CareerTraining.Kind(a.Title)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerTraining.Kind(a.Title) is not ("team" or "team-growth")`
- `NationalSpire.CareerTraining.Snapshot(NationalSpire.CareerData, NationalSpire.LifeActivity, bool)`；输入表达式：`CareerTraining.Snapshot(d, quote)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerTraining.Snapshot(d, quote);`
- `NationalSpire.CareerTraining.Targets(NationalSpire.CareerData)`；输入表达式：`CareerTraining.Targets(d)`；返回值紧邻使用处：`ConditionalExpressionSyntax: training && CareerTraining.Kind(a.Title) is not ("team" or "team-growth") ? CareerTraining.Targets(d) : null`
- `NationalSpire.ClubAudience.Total(NationalSpire.CareerData, string)`；输入表达式：`ClubAudience.Total(d,o.ClubId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ClubAudience.Total(d,o.ClubId)`
- `NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.TrainingPlans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ClubCoaching.TrainingPlans(d).Where`
- `NationalSpire.ClubPrograms.Details(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`ClubPrograms.Details(d, quote)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ClubPrograms.Details(d, quote)`
- `NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`ClubPrograms.IsTraining(a)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ClubPrograms.IsTraining(a)`
- `NationalSpire.ClubPrograms.Snapshot(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`ClubPrograms.Snapshot(d, quote)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubPrograms.Snapshot(d, quote);`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(d,a.ClubId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: a.Kind is "俱乐部" or "经营" ? EsportsWorld.ClubName(d,a.ClubId) : CareerEngine.DisplayName(d, target)`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(d,o.ClubId)`；返回值紧邻使用处：`ArgumentSyntax: EsportsWorld.ClubName(d,o.ClubId)`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(d,s.TargetId)`；返回值紧邻使用处：`ArgumentSyntax: EsportsWorld.ClubName(d,s.TargetId)`
- `NationalSpire.GameCalendar.Season(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Season(d,day)`；返回值紧邻使用处：`BinaryExpressionSyntax: GameCalendar.Season(d,day) <= s.EndSeason`
- `NationalSpire.GameCalendar.Season(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Season(d,day)`；返回值紧邻使用处：`BinaryExpressionSyntax: GameCalendar.Season(d,day) >= s.StartSeason`
- `NationalSpire.LifeActivity.PreviewFor(NationalSpire.CareerData, string)`；输入表达式：`a.PreviewFor(d,target)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = a.PreviewFor(d,target)`
- `NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.IsOwner(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: OwnedClubs.IsOwner(d) && d.Esports.OwnedClub is { } o`
- `NationalSpire.OwnedClubs.SponsorQuote(NationalSpire.CareerData, string)`；输入表达式：`OwnedClubs.SponsorQuote(d,id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = OwnedClubs.SponsorQuote(d,id)`
- `NationalSpire.OwnedClubs.SponsorWeekly(NationalSpire.OwnedSponsor?, int)`；输入表达式：`OwnedClubs.SponsorWeekly(quote,fans)`；返回值紧邻使用处：`ArgumentSyntax: OwnedClubs.SponsorWeekly(quote,fans)`
- `NationalSpire.OwnedClubs.SponsorWinBonus(NationalSpire.OwnedSponsor, int)`；输入表达式：`OwnedClubs.SponsorWinBonus(quote,fans)`；返回值紧邻使用处：`ArgumentSyntax: OwnedClubs.SponsorWinBonus(quote,fans)`
- `NationalSpire.RegionalOrganizations.SponsorDescription(string)`；输入表达式：`RegionalOrganizations.SponsorDescription(quote.Brand)`；返回值紧邻使用处：`BinaryExpressionSyntax: RegionalOrganizations.SponsorDescription(quote.Brand) +                      $"\n周结 {CareerMoney.Format(OwnedClubs.SponsorWeekly(quote,fans))} · 胜场 {CareerMoney.Format(OwnedClubs.SponsorWinBonus(quote,fans))}"`
- `NationalSpire.SponsorIncome.Retainer(NationalSpire.CareerData, NationalSpire.SponsorContract)`；输入表达式：`SponsorIncome.Retainer(d,s)`；返回值紧邻使用处：`ArgumentSyntax: SponsorIncome.Retainer(d,s)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", quote.TrainingTargets.Select(id => CareerEngine.DisplayName(d,id)))`；返回值紧邻使用处：`ConditionalExpressionSyntax: quote.TrainingTargets.Count > 0 ? string.Join("、", quote.TrainingTargets.Select(id => CareerEngine.DisplayName(d,id)))                  : a.Kind is "俱乐部" or "经营" ? EsportsWorld.ClubName(d,a.ClubId) : CareerEngine.DisplayName(d, target)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Any(p => p.Id == _planTarget)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: targets?.Any(p => p.Id == _planTarget)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Activities.Any(x => x.LongProject && x.Status == "进行中")`；返回值紧邻使用处：`BinaryExpressionSyntax: a.LongProject && d.Life.Activities.Any(x => x.LongProject && x.Status == "进行中")`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`.FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .FirstOrDefault()?.Id`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.FirstOrDefault(p => p.Id == a.PersonId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .FirstOrDefault(p => p.Id == a.PersonId)?.Id`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`quote.TrainingTargets.Select(id => CareerEngine.DisplayName(d,id))`；返回值紧邻使用处：`ArgumentSyntax: quote.TrainingTargets.Select(id => CareerEngine.DisplayName(d,id))`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`TeamPreparationPlans(d).ToList()`；返回值紧邻使用处：`ConditionalExpressionSyntax: member ? TeamPreparationPlans(d).ToList() : new List<CalendarPlan>()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`ClubCoaching.TrainingPlans(d).Where(p => p.ClubId == d.Esports.ClubId && p.State == "进行中")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var p in ClubCoaching.TrainingPlans(d).Where(p => p.ClubId == d.Esports.ClubId && p.State == "进行中"))          {              string name = CareerEngine.DisplayName(d,p.PersonId);              plans.Add(new("coach:" + p.Id, TrainingPlans, "教练训练 · " + name,                  name, p.Content, AgendaRange(d,p.StartDay,p.EndDay),                  day => day >= p.StartDay && day <= p.EndDay, () => OpenPrivateMessages(p.CoachId.Length == 0 ? p.PersonId : p.CoachId), ActionText:"查看私信"));          }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Sponsors.Where(s => s.TargetId == d.Esports.ClubId && s.EndedDay == 0 && s.StartSeason <= d.Season && s.EndSeason >= d.Season)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var s in d.Esports.Sponsors.Where(s => s.TargetId == d.Esports.ClubId && s.EndedDay == 0 && s.StartSeason <= d.Season && s.EndSeason >= d.Season))                  plans.Add(new("active-sponsor:" + s.Id, SponsorPlans, s.Brand, EsportsWorld.ClubName(d,s.TargetId), $"{s.Slogan}\n每赛季支持战队 {CareerMoney.Format(SponsorIncome.Retainer(d,s))}", $"第 {s.StartSeason} 至 {s.EndSeason} 赛季",                      day => GameCalendar.Season(d,day) >= s.StartSeason && GameCalendar.Season(d,day) <= s.EndSeason));`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Activities.Where(a => a.Status == "可安排" && a.ExpiresDay >= d.Day)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var a in d.Life.Activities.Where(a => a.Status == "可安排" && a.ExpiresDay >= d.Day))          {              bool training = CareerTraining.IsTraining(a), program = ClubPrograms.IsTraining(a);              bool club = ClubPlan(a);              if (club && !member) continue;              var targets = training && CareerTraining.Kind(a.Title) is not ("team" or "team-growth") ? CareerTraining.Targets(d) : null;              string target = a.Id == _planKey && targets?.Any(p => p.Id == _planTarget) == true ? _planTarget :                  targets?.FirstOrDefault(p => p.Id == a.PersonId)?.Id ?? targets?.FirstOrDefault()?.Id ?? a.PersonId;              var quote = a.PreviewFor(d,target);              int start = d.Day, end = start + Math.Max(1, CareerRelics.Duration(d, a)) - 1;              if (training || program)              {                  quote.StartedDay = d.Day;                  if (training) CareerTraining.Snapshot(d, quote); else ClubPrograms.Snapshot(d, quote);                  start = quote.TrainingStart; end = quote.TrainingEnd;              }              string names = quote.TrainingTargets.Count > 0 ? string.Join("、", quote.TrainingTargets.Select(id => CareerEngine.DisplayName(d,id)))                  : a.Kind is "俱乐部" or "经营" ? EsportsWorld.ClubName(d,a.ClubId) : CareerEngine.DisplayName(d, target);              int cost = CareerRelics.Cost(d, a);              string effect = quote.Detail+"\n"+CareerLife.Expected(d,quote);              plans.Add(new(a.Id, club ? TrainingPlans : PersonalPlans, a.Title, names, effect, AgendaRange(d,start,end), day => day >= start && day <= end, () =>              {                  if (MultiplayerCommand("activity", a.Id, target, accepted: ClearPlan)) return;                  FinishPlan(CareerLife.Accept(d, a.Id, target));              }, d.Credits >= cost && !(a.LongProject && d.Life.Activities.Any(x => x.LongProject && x.Status == "进行中")), targets, Cost:cost,                  TrainingDetails: program ? () => ClubPrograms.Details(d, quote) : training ? () => CareerTraining.Details(d, quote) : null));          }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`plans.Add(new("active-sponsor:" + s.Id, SponsorPlans, s.Brand, EsportsWorld.ClubName(d,s.TargetId), $"{s.Slogan}\n每赛季支持战队 {CareerMoney.Format(SponsorIncome.Retainer(d,s))}", $"第 {s.StartSeason} 至 {s.EndSeason} 赛季",                      day => GameCalendar.Season(d,day) >= s.StartSeason && GameCalendar.Season(d,day) <= s.EndSeason))`；返回值紧邻使用处：`ExpressionStatementSyntax: plans.Add(new("active-sponsor:" + s.Id, SponsorPlans, s.Brand, EsportsWorld.ClubName(d,s.TargetId), $"{s.Slogan}\n每赛季支持战队 {CareerMoney.Format(SponsorIncome.Retainer(d,s))}", $"第 {s.StartSeason} 至 {s.EndSeason} 赛季",                      day => GameCalendar.Season(d,day) >= s.StartSeason && GameCalendar.Season(d,day) <= s.EndSeason));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`plans.Add(new("club-sponsor:" + id, SponsorPlans, quote.Brand + (o.NextSponsor == id ? " · 下期已选" : o.Sponsor?.Id == id ? " · 当前合作" : ""),                      EsportsWorld.ClubName(d,o.ClubId), effect, AgendaRange(d,start,end), day => day >= start && day <= end, () => ClubAction(d, "sponsor", target:id, success:ClearPlan),                      CanManageClub && o.NextSponsor != id))`；返回值紧邻使用处：`ExpressionStatementSyntax: plans.Add(new("club-sponsor:" + id, SponsorPlans, quote.Brand + (o.NextSponsor == id ? " · 下期已选" : o.Sponsor?.Id == id ? " · 当前合作" : ""),                      EsportsWorld.ClubName(d,o.ClubId), effect, AgendaRange(d,start,end), day => day >= start && day <= end, () => ClubAction(d, "sponsor", target:id, success:ClearPlan),                      CanManageClub && o.NextSponsor != id));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`plans.Add(new("coach:" + p.Id, TrainingPlans, "教练训练 · " + name,                  name, p.Content, AgendaRange(d,p.StartDay,p.EndDay),                  day => day >= p.StartDay && day <= p.EndDay, () => OpenPrivateMessages(p.CoachId.Length == 0 ? p.PersonId : p.CoachId), ActionText:"查看私信"))`；返回值紧邻使用处：`ExpressionStatementSyntax: plans.Add(new("coach:" + p.Id, TrainingPlans, "教练训练 · " + name,                  name, p.Content, AgendaRange(d,p.StartDay,p.EndDay),                  day => day >= p.StartDay && day <= p.EndDay, () => OpenPrivateMessages(p.CoachId.Length == 0 ? p.PersonId : p.CoachId), ActionText:"查看私信"));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`plans.Add(new(a.Id, club ? TrainingPlans : PersonalPlans, a.Title, names, effect, AgendaRange(d,start,end), day => day >= start && day <= end, () =>              {                  if (MultiplayerCommand("activity", a.Id, target, accepted: ClearPlan)) return;                  FinishPlan(CareerLife.Accept(d, a.Id, target));              }, d.Credits >= cost && !(a.LongProject && d.Life.Activities.Any(x => x.LongProject && x.Status == "进行中")), targets, Cost:cost,                  TrainingDetails: program ? () => ClubPrograms.Details(d, quote) : training ? () => CareerTraining.Details(d, quote) : null))`；返回值紧邻使用处：`ExpressionStatementSyntax: plans.Add(new(a.Id, club ? TrainingPlans : PersonalPlans, a.Title, names, effect, AgendaRange(d,start,end), day => day >= start && day <= end, () =>              {                  if (MultiplayerCommand("activity", a.Id, target, accepted: ClearPlan)) return;                  FinishPlan(CareerLife.Accept(d, a.Id, target));              }, d.Credits >= cost && !(a.LongProject && d.Life.Activities.Any(x => x.LongProject && x.Status == "进行中")), targets, Cost:cost,                  TrainingDetails: program ? () => ClubPrograms.Details(d, quote) : training ? () => CareerTraining.Details(d, quote) : null));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<CalendarPlan>()`；返回值紧邻使用处：`ConditionalExpressionSyntax: member ? TeamPreparationPlans(d).ToList() : new List<CalendarPlan>()`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, (old.EndDay - payday + 6) / 7)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Max(0, (old.EndDay - payday + 6) / 7) * 7`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1, CareerRelics.Duration(d, a))`；返回值紧邻使用处：`BinaryExpressionSyntax: start + Math.Max(1, CareerRelics.Duration(d, a))`

**赋值（含属性/字段和局部值）：**

- `end` = `quote.TrainingEnd`
- `quote.StartedDay` = `d.Day`
- `start` = `payday + Math.Max(0, (old.EndDay - payday + 6) / 7) * 7`
- `start` = `quote.TrainingStart`

<a id="symbol-a5b07c06671a"></a>

## `NationalSpire.CareerScreen.TeamPreparationPlans(NationalSpire.CareerData) — private IEnumerable<CalendarPlan> TeamPreparationPlans(CareerData d)`

来源：源码第 80 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CalendarPlans(NationalSpire.CareerData)`](CalendarPlansScreen.cs.md#symbol-60a9060c5331)

**调用：** [`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`](LifeData.cs.md#symbol-de5af63fa4e7)；[`NationalSpire.CareerScreen.ConfirmTeamPreparation(NationalSpire.CareerData, string)`](TeamPreparationScreen.cs.md#symbol-a2bb56539ef4)；[`NationalSpire.CircuitWorld.TeamName(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`](CircuitWorld.cs.md#symbol-74904a83d22a)；[`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-8a08be365f83)；[`NationalSpire.TeamPreparations.Available(NationalSpire.CareerData)`](TeamPreparation.cs.md#symbol-f2f72b62407b)；[`NationalSpire.TeamPreparations.PlayerTeam(NationalSpire.WorldCompetition)`](TeamPreparation.cs.md#symbol-2f121be9ec37)；`NationalSpire.CareerScreen.CalendarPlan.CalendarPlan(string, string, string, string, string, string, System.Func<int, bool>, System.Action?, bool, System.Collections.Generic.List<NationalSpire.CareerPerson>?, string, int, string, System.Func<string>?)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<T>.Order<T>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.DateOnly.ToString(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.TeamPreparations`；`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen.ConfirmTeamPreparation(NationalSpire.CareerData, string)`；`NationalSpire.CareerScreen.TrainingPlans`；`NationalSpire.CircuitWorld.TeamName(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`；`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；`NationalSpire.ICareerSession.Host`；`NationalSpire.TeamPreparation.CompetitionId`；`NationalSpire.TeamPreparation.Remaining`；`NationalSpire.TeamPreparation.Team`；`NationalSpire.TeamPreparations.Available(NationalSpire.CareerData)`；`NationalSpire.TeamPreparations.Cost`；`NationalSpire.TeamPreparations.PlayerTeam(NationalSpire.WorldCompetition)`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Name`；`NationalSpire.WorldFixture.AwayTeam`；`NationalSpire.WorldFixture.Day`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeTeam`；`NationalSpire.WorldFixture.Round`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；输入表达式：`CareerMoney.Balance(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerMoney.Balance(d) < TeamPreparations.Cost`
- `NationalSpire.CareerScreen.CalendarPlan.CalendarPlan(string, string, string, string, string, string, System.Func<int, bool>, System.Action?, bool, System.Collections.Generic.List<NationalSpire.CareerPerson>?, string, int, string, System.Func<string>?)`；输入表达式：`new("team:" + cup.Id, TrainingPlans, "集体备赛 · " + cup.Name, CircuitWorld.TeamName(d,cup,team),                  effect, dates.Length > 0 ? dates : "待赛程公布", days.Contains, () => ConfirmTeamPreparation(d,cup.Id),                  state.Length == 0, Cost: TeamPreparations.Cost, Availability: state)`；返回值紧邻使用处：`YieldStatementSyntax: yield return new("team:" + cup.Id, TrainingPlans, "集体备赛 · " + cup.Name, CircuitWorld.TeamName(d,cup,team),                  effect, dates.Length > 0 ? dates : "待赛程公布", days.Contains, () => ConfirmTeamPreparation(d,cup.Id),                  state.Length == 0, Cost: TeamPreparations.Cost, Availability: state);`
- `NationalSpire.CareerScreen.CalendarPlan.CalendarPlan(string, string, string, string, string, string, System.Func<int, bool>, System.Action?, bool, System.Collections.Generic.List<NationalSpire.CareerPerson>?, string, int, string, System.Func<string>?)`；输入表达式：`new("team:upcoming", TrainingPlans, "集体备赛", "参赛队友", effect, "待赛程公布", _ => false,                  Cost: TeamPreparations.Cost, Availability: "加入参赛阵容并排定团体对阵后可安排。")`；返回值紧邻使用处：`YieldStatementSyntax: yield return new("team:upcoming", TrainingPlans, "集体备赛", "参赛队友", effect, "待赛程公布", _ => false,                  Cost: TeamPreparations.Cost, Availability: "加入参赛阵容并排定团体对阵后可安排。");`
- `NationalSpire.CareerScreen.ConfirmTeamPreparation(NationalSpire.CareerData, string)`；输入表达式：`ConfirmTeamPreparation(d,cup.Id)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ConfirmTeamPreparation(d,cup.Id)`
- `NationalSpire.CircuitWorld.TeamName(NationalSpire.CareerData, NationalSpire.WorldCompetition, string)`；输入表达式：`CircuitWorld.TeamName(d,cup,team)`；返回值紧邻使用处：`ArgumentSyntax: CircuitWorld.TeamName(d,cup,team)`
- `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Date(d,day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameCalendar.Date(d,day).ToString`
- `NationalSpire.TeamPreparations.Available(NationalSpire.CareerData)`；输入表达式：`TeamPreparations.Available(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: TeamPreparations.Available(d).ToList`
- `NationalSpire.TeamPreparations.PlayerTeam(NationalSpire.WorldCompetition)`；输入表达式：`TeamPreparations.PlayerTeam(cup)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = TeamPreparations.PlayerTeam(cup)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", days.Order().Select(day => GameCalendar.Date(d,day).ToString("M/d")))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = string.Join("、", days.Order().Select(day => GameCalendar.Date(d,day).ToString("M/d")))`
- `System.Collections.Generic.IEnumerable<T>.Order<T>()`；输入表达式：`days.Order()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: days.Order().Select`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.TeamPreparations.FirstOrDefault(p => p.CompetitionId == cup.Id && p.Team == team && p.Remaining > 0)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.TeamPreparations.FirstOrDefault(p => p.CompetitionId == cup.Id && p.Team == team && p.Remaining > 0)`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`cup.Fixtures.Where(f => !f.Finished && (f.HomeTeam == team || f.AwayTeam == team))                  .GroupBy(f => f.Round)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: cup.Fixtures.Where(f => !f.Finished && (f.HomeTeam == team || f.AwayTeam == team))                  .GroupBy(f => f.Round).OrderBy`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`cup.Fixtures.Where(f => !f.Finished && (f.HomeTeam == team || f.AwayTeam == team))                  .GroupBy(f => f.Round).OrderBy(g => g.Key)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: cup.Fixtures.Where(f => !f.Finished && (f.HomeTeam == team || f.AwayTeam == team))                  .GroupBy(f => f.Round).OrderBy(g => g.Key).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`days.Order().Select(day => GameCalendar.Date(d,day).ToString("M/d"))`；返回值紧邻使用处：`ArgumentSyntax: days.Order().Select(day => GameCalendar.Date(d,day).ToString("M/d"))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`g.Select(f => f.Day)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.Select(f => f.Day)`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`cup.Fixtures.Where(f => !f.Finished && (f.HomeTeam == team || f.AwayTeam == team))                  .GroupBy(f => f.Round).OrderBy(g => g.Key).Take(active?.Remaining ?? 3).SelectMany(g => g.Select(f => f.Day))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: cup.Fixtures.Where(f => !f.Finished && (f.HomeTeam == team || f.AwayTeam == team))                  .GroupBy(f => f.Round).OrderBy(g => g.Key).Take(active?.Remaining ?? 3).SelectMany(g => g.Select(f => f.Day)).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`cup.Fixtures.Where(f => !f.Finished && (f.HomeTeam == team || f.AwayTeam == team))                  .GroupBy(f => f.Round).OrderBy(g => g.Key).Take(active?.Remaining ?? 3)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: cup.Fixtures.Where(f => !f.Finished && (f.HomeTeam == team || f.AwayTeam == team))                  .GroupBy(f => f.Round).OrderBy(g => g.Key).Take(active?.Remaining ?? 3).SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`cup.Fixtures.Where(f => !f.Finished && (f.HomeTeam == team || f.AwayTeam == team))                  .GroupBy(f => f.Round).OrderBy(g => g.Key).Take(active?.Remaining ?? 3).SelectMany(g => g.Select(f => f.Day)).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = cup.Fixtures.Where(f => !f.Finished && (f.HomeTeam == team || f.AwayTeam == team))                  .GroupBy(f => f.Round).OrderBy(g => g.Key).Take(active?.Remaining ?? 3).SelectMany(g => g.Select(f => f.Day)).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`TeamPreparations.Available(d).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = TeamPreparations.Available(d).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`cup.Fixtures.Where(f => !f.Finished && (f.HomeTeam == team || f.AwayTeam == team))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: cup.Fixtures.Where(f => !f.Finished && (f.HomeTeam == team || f.AwayTeam == team))                  .GroupBy`
- `System.DateOnly.ToString(string?)`；输入表达式：`GameCalendar.Date(d,day).ToString("M/d")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: day => GameCalendar.Date(d,day).ToString("M/d")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-22ea50ffc52d"></a>

## `NationalSpire.CareerScreen.CurrentPlanScroll() — private int CurrentPlanScroll()`

来源：源码第 101 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CaptureLocation()`](CareerNavigation.cs.md#symbol-67f7f7696f8a)

**调用：** [`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`](CareerVisuals.cs.md#symbol-347d38705528)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._calendarMode`；`NationalSpire.CareerScreen._content`；`NationalSpire.CareerScreen._planScroll`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerVisuals.FindContent(Godot.Node, string)`；输入表达式：`CareerVisuals.FindContent(_content,"CalendarSideScroll")`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerVisuals.FindContent(_content,"CalendarSideScroll") is ScrollContainer pane`

**赋值（含属性/字段和局部值）：**


<a id="symbol-100b2aec3e40"></a>

## `NationalSpire.CareerScreen.FinishPlan(string?) — private void FinishPlan(string? error)`

来源：源码第 104 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CalendarPlans(NationalSpire.CareerData)`](CalendarPlansScreen.cs.md#symbol-60a9060c5331)；[`NationalSpire.CareerScreen.ConfirmTeamPreparation(NationalSpire.CareerData, string)`](TeamPreparationScreen.cs.md#symbol-a2bb56539ef4)；[`NationalSpire.CareerScreen.PlanPane(NationalSpire.CareerData, Godot.VBoxContainer, Godot.ScrollContainer, System.Collections.Generic.List<NationalSpire.CareerScreen.CalendarPlan>, NationalSpire.CalendarDayButton[])`](CalendarPlansScreen.cs.md#symbol-078c4f908d4c)

**调用：** [`NationalSpire.CareerScreen.ClearPlan()`](CareerDashboard.cs.md#symbol-26b8e8ad029b)；[`NationalSpire.CareerScreen.Notice(string, bool)`](CareerScreen.cs.md#symbol-04588f02c308)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.ClearPlan()`；`NationalSpire.CareerScreen.Notice(string, bool)`；`NationalSpire.CareerScreen.Render()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.ClearPlan()`；输入表达式：`ClearPlan()`；返回值紧邻使用处：`ExpressionStatementSyntax: ClearPlan();`
- `NationalSpire.CareerScreen.Notice(string, bool)`；输入表达式：`Notice(error, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(error, true);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c9a82d9a2cd6"></a>

## `NationalSpire.CareerScreen.PlanCard.ShowExpanded(bool) — public void ShowExpanded(bool expanded)`

来源：源码第 111 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Choose(string, string)`](CalendarPlansScreen.cs.md#symbol-9a1d5ca75d7a)

**调用：** [`NationalSpire.CareerScreen.NavigationIcon(string)`](CareerDashboard.cs.md#symbol-3c49977c9503)；`Godot.Color.Color(string)`；`Godot.Control.GetThemeStylebox(Godot.StringName, Godot.StringName)`；`Godot.GodotObject.SetMeta(Godot.StringName, Godot.Variant)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.NavigationIcon(string)`；`NationalSpire.CareerScreen.PlanCard.Arrow`；`NationalSpire.CareerScreen.PlanCard.Panel`；`NationalSpire.CareerScreen.PlanCard.Toggle`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Color.Color(string)`；输入表达式：`new Color(expanded?"80e7db":"36515d")`；返回值紧邻使用处：`AssignmentExpressionSyntax: ((StyleBoxFlat)Panel.GetThemeStylebox("panel")).BorderColor=new Color(expanded?"80e7db":"36515d")`
- `Godot.Control.GetThemeStylebox(Godot.StringName, Godot.StringName)`；输入表达式：`Panel.GetThemeStylebox("panel")`；返回值紧邻使用处：`CastExpressionSyntax: (StyleBoxFlat)Panel.GetThemeStylebox("panel")`
- `Godot.GodotObject.SetMeta(Godot.StringName, Godot.Variant)`；输入表达式：`Toggle.SetMeta("expanded",expanded)`；返回值紧邻使用处：`ExpressionStatementSyntax: Toggle.SetMeta("expanded",expanded);`
- `NationalSpire.CareerScreen.NavigationIcon(string)`；输入表达式：`NavigationIcon(expanded?"chevron-up":"chevron-down")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Arrow.Texture=NavigationIcon(expanded?"chevron-up":"chevron-down")`

**赋值（含属性/字段和局部值）：**

- `((StyleBoxFlat)Panel.GetThemeStylebox("panel")).BorderColor` = `new Color(expanded?"80e7db":"36515d")`
- `Arrow.Texture` = `NavigationIcon(expanded?"chevron-up":"chevron-down")`

<a id="symbol-078c4f908d4c"></a>

## `NationalSpire.CareerScreen.PlanPane(NationalSpire.CareerData, Godot.VBoxContainer, Godot.ScrollContainer, System.Collections.Generic.List<NationalSpire.CareerScreen.CalendarPlan>, NationalSpire.CalendarDayButton[]) — private void PlanPane(CareerData d,VBoxContainer box,ScrollContainer scroll,List<CalendarPlan> plans,CalendarDayButton[] dates)`

来源：源码第 119 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)

**调用：** [`Choose(string, string)`](CalendarPlansScreen.cs.md#symbol-9a1d5ca75d7a)；[`NationalSpire.CareerLife.Expected(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerLife.cs.md#symbol-44d430d90686)；[`NationalSpire.CareerLife.SkipRound(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-efe3762d8665)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`](DashboardControls.cs.md#symbol-5fcff8206cb6)；[`NationalSpire.CareerScreen.AgendaRange(NationalSpire.CareerData, int, int)`](CalendarPlansScreen.cs.md#symbol-9c53a348d954)；[`NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`](CareerDashboard.cs.md#symbol-22831701f7f1)；[`NationalSpire.CareerScreen.ClubPlan(NationalSpire.LifeActivity)`](CalendarPlansScreen.cs.md#symbol-217e72b481b2)；[`NationalSpire.CareerScreen.ConfirmLife(string, string, System.Action)`](LifeScreen.cs.md#symbol-d61ca43b835f)；[`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.FinishPlan(string?)`](CalendarPlansScreen.cs.md#symbol-100b2aec3e40)；[`NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`](DashboardControls.cs.md#symbol-d6b849a02619)；[`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`](DashboardControls.cs.md#symbol-23c9e2f4b76f)；[`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`](CareerScreen.cs.md#symbol-e9950886933d)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.PendingPlans(NationalSpire.CareerData)`](CareerDashboard.cs.md#symbol-bf1cbb6ed943)；[`NationalSpire.CareerScreen.PlanDetails(NationalSpire.CareerData, NationalSpire.CareerScreen.CalendarPlan, System.Action<string>)`](CalendarPlansScreen.cs.md#symbol-0f7a307ccb1c)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`](CareerScreen.cs.md#symbol-c08624e2a07c)；[`NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`](CareerTraining.cs.md#symbol-98adbc7a75dc)；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；[`NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-f251644672be)；[`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-8a08be365f83)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；`Godot.GodotObject.SetDeferred(Godot.StringName, Godot.Variant)`；`Godot.GodotObject.SetMeta(Godot.StringName, Godot.Variant)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.PanelContainer.PanelContainer()`；`Godot.Vector2.Vector2(float, float)`；`NationalSpire.CareerScreen.PlanCard.PlanCard(Godot.PanelContainer, Godot.VBoxContainer, Godot.Button, Godot.TextureRect)`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `Choose(string, string)`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLife.Expected(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.CareerLife.SkipRound(NationalSpire.CareerData)`；`NationalSpire.CareerLifeState.Activities`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._lifeHistoryLimit`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._planKey`；`NationalSpire.CareerScreen._planScroll`；`NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`；`NationalSpire.CareerScreen.AgendaRange(NationalSpire.CareerData, int, int)`；`NationalSpire.CareerScreen.CalendarPlan.Key`；`NationalSpire.CareerScreen.CalendarPlan.Section`；`NationalSpire.CareerScreen.CalendarPlan.Title`；`NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；`NationalSpire.CareerScreen.ClearPlan()`；`NationalSpire.CareerScreen.ClubPlan(NationalSpire.LifeActivity)`；`NationalSpire.CareerScreen.ConfirmLife(string, string, System.Action)`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.FinishPlan(string?)`；`NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；`NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；`NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.PendingPlans(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.PersonalPlans`；`NationalSpire.CareerScreen.PlanDetails(NationalSpire.CareerData, NationalSpire.CareerScreen.CalendarPlan, System.Action<string>)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.SponsorPlans`；`NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；`NationalSpire.CareerScreen.TrainingPlans`；`NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`；`NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；`NationalSpire.LifeActivity.Cost`；`NationalSpire.LifeActivity.FinishDay`；`NationalSpire.LifeActivity.PaidCost`；`NationalSpire.LifeActivity.Result`；`NationalSpire.LifeActivity.StartedDay`；`NationalSpire.LifeActivity.Status`；`NationalSpire.LifeActivity.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Choose(string, string)`；输入表达式：`Choose(_planKey==p.Key?"":p.Key)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>Choose(_planKey==p.Key?"":p.Key)`
- `Choose(string, string)`；输入表达式：`Choose(p.Key,id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id=>Choose(p.Key,id)`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`body.AddThemeConstantOverride("separation",0)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddThemeConstantOverride("separation",0);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation",11)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation",11);`
- `Godot.Control.AddThemeStyleboxOverride(Godot.StringName, Godot.StyleBox)`；输入表达式：`card.AddThemeStyleboxOverride("panel",CareerVisuals.Box("172c38",open?"80e7db":"36515d",5,1))`；返回值紧邻使用处：`ExpressionStatementSyntax: card.AddThemeStyleboxOverride("panel",CareerVisuals.Box("172c38",open?"80e7db":"36515d",5,1));`
- `Godot.GodotObject.SetDeferred(Godot.StringName, Godot.Variant)`；输入表达式：`scroll.SetDeferred(ScrollContainer.PropertyName.ScrollVertical, _planScroll)`；返回值紧邻使用处：`ExpressionStatementSyntax: scroll.SetDeferred(ScrollContainer.PropertyName.ScrollVertical, _planScroll);`
- `Godot.GodotObject.SetMeta(Godot.StringName, Godot.Variant)`；输入表达式：`toggle.SetMeta("expanded",open)`；返回值紧邻使用处：`ExpressionStatementSyntax: toggle.SetMeta("expanded",open);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`body.AddChild(expanded)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.AddChild(expanded);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(CaptionButton("查看更多", () => { _lifeHistoryLimit+=8; _planScroll=scroll.ScrollVertical; Render(); }))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(CaptionButton("查看更多", () => { _lifeHistoryLimit+=8; _planScroll=scroll.ScrollVertical; Render(); }));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(card)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(card);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(FramedAction("跳过此轮", () => ConfirmLife("跳过此轮", "结束当前生活和训练邀请？", () =>          {              if (MultiplayerCommand("skip", accepted:ClearPlan)) return; CareerLife.SkipRound(d); FinishPlan(null);          }),height:43,quiet:true))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(FramedAction("跳过此轮", () => ConfirmLife("跳过此轮", "结束当前生活和训练邀请？", () =>          {              if (MultiplayerCommand("skip", accepted:ClearPlan)) return; CareerLife.SkipRound(d); FinishPlan(null);          }),height:43,quiet:true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(heading)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(heading);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("进行中与过往安排", 18, _gold))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("进行中与过往安排", 18, _gold));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text("暂无可用安排", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text("暂无可用安排", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Text($"{a.Title} · {a.Status}\n{detail}", 15, _muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Text($"{a.Title} · {a.Status}\n{detail}", 15, _muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(arrow)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(arrow);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(DashboardLabel(p.Title,18,_ink,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(DashboardLabel(p.Title,18,_ink,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(Glyph(group==SponsorPlans?"handshake":group==TrainingPlans?"dumbbell":"heart",24,CareerVisuals.Teal))`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(Glyph(group==SponsorPlans?"handshake":group==TrainingPlans?"dumbbell":"heart",24,CareerVisuals.Teal));`
- `Godot.PanelContainer.PanelContainer()`；输入表达式：`new PanelContainer { Name="Plan_"+p.Key }`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new PanelContainer { Name="Plan_"+p.Key }`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,40)`；返回值紧邻使用处：`AssignmentExpressionSyntax: heading.CustomMinimumSize=new(0,40)`
- `NationalSpire.CareerLife.Expected(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`CareerLife.Expected(d, a)`；返回值紧邻使用处：`BinaryExpressionSyntax: "\n" + CareerLife.Expected(d, a)`
- `NationalSpire.CareerLife.SkipRound(NationalSpire.CareerData)`；输入表达式：`CareerLife.SkipRound(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerLife.SkipRound(d);`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(a.PaidCost >= 0 ? a.PaidCost : a.Cost)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(a.PaidCost >= 0 ? a.PaidCost : a.Cost)}`
- `NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`；输入表达式：`ActionRow(body,"PlanHeading",p.Title,()=>Choose(_planKey==p.Key?"":p.Key),row,76,13,10,"172c38","00000000","203d49")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =ActionRow(body,"PlanHeading",p.Title,()=>Choose(_planKey==p.Key?"":p.Key),row,76,13,10,"172c38","00000000","203d49")`
- `NationalSpire.CareerScreen.AgendaRange(NationalSpire.CareerData, int, int)`；输入表达式：`AgendaRange(d, a.StartedDay, a.FinishDay)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AgendaRange(d, a.StartedDay, a.FinishDay)`
- `NationalSpire.CareerScreen.CaptionButton(string, System.Action, bool)`；输入表达式：`CaptionButton("查看更多", () => { _lifeHistoryLimit+=8; _planScroll=scroll.ScrollVertical; Render(); })`；返回值紧邻使用处：`ArgumentSyntax: CaptionButton("查看更多", () => { _lifeHistoryLimit+=8; _planScroll=scroll.ScrollVertical; Render(); })`
- `NationalSpire.CareerScreen.ClubPlan(NationalSpire.LifeActivity)`；输入表达式：`ClubPlan(a)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ClubPlan(a)`
- `NationalSpire.CareerScreen.ConfirmLife(string, string, System.Action)`；输入表达式：`ConfirmLife("跳过此轮", "结束当前生活和训练邀请？", () =>          {              if (MultiplayerCommand("skip", accepted:ClearPlan)) return; CareerLife.SkipRound(d); FinishPlan(null);          })`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: () => ConfirmLife("跳过此轮", "结束当前生活和训练邀请？", () =>          {              if (MultiplayerCommand("skip", accepted:ClearPlan)) return; CareerLife.SkipRound(d); FinishPlan(null);          })`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(group,23,_ink)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardLabel(group,23,_ink)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(p.Title,18,_ink,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(p.Title,18,_ink,true)`
- `NationalSpire.CareerScreen.FinishPlan(string?)`；输入表达式：`FinishPlan(null)`；返回值紧邻使用处：`ExpressionStatementSyntax: FinishPlan(null);`
- `NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；输入表达式：`FramedAction("跳过此轮", () => ConfirmLife("跳过此轮", "结束当前生活和训练邀请？", () =>          {              if (MultiplayerCommand("skip", accepted:ClearPlan)) return; CareerLife.SkipRound(d); FinishPlan(null);          }),height:43,quiet:true)`；返回值紧邻使用处：`ArgumentSyntax: FramedAction("跳过此轮", () => ConfirmLife("跳过此轮", "结束当前生活和训练邀请？", () =>          {              if (MultiplayerCommand("skip", accepted:ClearPlan)) return; CareerLife.SkipRound(d); FinishPlan(null);          }),height:43,quiet:true)`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`Glyph(group==SponsorPlans?"handshake":group==TrainingPlans?"dumbbell":"heart",24,CareerVisuals.Teal)`；返回值紧邻使用处：`ArgumentSyntax: Glyph(group==SponsorPlans?"handshake":group==TrainingPlans?"dumbbell":"heart",24,CareerVisuals.Teal)`
- `NationalSpire.CareerScreen.Glyph(string, int, Godot.Color)`；输入表达式：`Glyph(open?"chevron-up":"chevron-down",18,_gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Glyph(open?"chevron-up":"chevron-down",18,_gold)`
- `NationalSpire.CareerScreen.Inner(Godot.PanelContainer)`；输入表达式：`Inner(card)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Inner(card)`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("skip", accepted:ClearPlan)`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("skip", accepted:ClearPlan)) return;`
- `NationalSpire.CareerScreen.PendingPlans(NationalSpire.CareerData)`；输入表达式：`PendingPlans(d)`；返回值紧邻使用处：`IfStatementSyntax: if (PendingPlans(d)) box.AddChild(FramedAction("跳过此轮", () => ConfirmLife("跳过此轮", "结束当前生活和训练邀请？", () =>          {              if (MultiplayerCommand("skip", accepted:ClearPlan)) return; CareerLife.SkipRound(d); FinishPlan(null);          }),height:43,quiet:true));`
- `NationalSpire.CareerScreen.PlanCard.PlanCard(Godot.PanelContainer, Godot.VBoxContainer, Godot.Button, Godot.TextureRect)`；输入表达式：`new PlanCard(card,body,toggle,arrow)`；返回值紧邻使用处：`AssignmentExpressionSyntax: cards[p.Key]=new PlanCard(card,body,toggle,arrow)`
- `NationalSpire.CareerScreen.PlanDetails(NationalSpire.CareerData, NationalSpire.CareerScreen.CalendarPlan, System.Action<string>)`；输入表达式：`PlanDetails(d,p,id=>Choose(p.Key,id))`；返回值紧邻使用处：`AssignmentExpressionSyntax: expanded=PlanDetails(d,p,id=>Choose(p.Key,id))`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("进行中与过往安排", 18, _gold)`；返回值紧邻使用处：`ArgumentSyntax: Text("进行中与过往安排", 18, _gold)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text("暂无可用安排", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text("暂无可用安排", 15, _muted)`
- `NationalSpire.CareerScreen.Text(string, int, Godot.Color)`；输入表达式：`Text($"{a.Title} · {a.Status}\n{detail}", 15, _muted)`；返回值紧邻使用处：`ArgumentSyntax: Text($"{a.Title} · {a.Status}\n{detail}", 15, _muted)`
- `NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`CareerTraining.IsTraining(a)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerTraining.IsTraining(a) || ClubPrograms.IsTraining(a)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("172c38",open?"80e7db":"36515d",5,1)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("172c38",open?"80e7db":"36515d",5,1)`
- `NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`ClubPrograms.IsTraining(a)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerTraining.IsTraining(a) || ClubPrograms.IsTraining(a)`
- `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Date(d, a.FinishDay)`；返回值紧邻使用处：`InterpolationSyntax: {GameCalendar.Date(d, a.FinishDay):M/d}`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string,PlanCard>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new Dictionary<string,PlanCard>()`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Life.Activities.Where(a => a.Status is "进行中" or "已完成" && (d.Esports.ClubId.Length > 0 || !ClubPlan(a))).OrderByDescending(a => a.StartedDay)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Activities.Where(a => a.Status is "进行中" or "已完成" && (d.Esports.ClubId.Length > 0 || !ClubPlan(a))).OrderByDescending(a => a.StartedDay).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`history.Take(_lifeHistoryLimit)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var a in history.Take(_lifeHistoryLimit))              {                  bool ongoing = a.Status == "进行中";                  string period = AgendaRange(d, a.StartedDay, a.FinishDay);                  string detail = ongoing ? period : $"{GameCalendar.Date(d, a.FinishDay):M/d} · 花费 {CareerMoney.Format(a.PaidCost >= 0 ? a.PaidCost : a.Cost)}";                  if (a.Result.Length > 0) detail += "\n" + a.Result;                  if (ongoing && (CareerTraining.IsTraining(a) || ClubPrograms.IsTraining(a))) detail += "\n" + CareerLife.Expected(d, a);                  box.AddChild(Text($"{a.Title} · {a.Status}\n{detail}", 15, _muted));              }`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Life.Activities.Where(a => a.Status is "进行中" or "已完成" && (d.Esports.ClubId.Length > 0 || !ClubPlan(a))).OrderByDescending(a => a.StartedDay).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Life.Activities.Where(a => a.Status is "进行中" or "已完成" && (d.Esports.ClubId.Length > 0 || !ClubPlan(a))).OrderByDescending(a => a.StartedDay).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`plans.Where(p => p.Section == group).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = plans.Where(p => p.Section == group).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Activities.Where(a => a.Status is "进行中" or "已完成" && (d.Esports.ClubId.Length > 0 || !ClubPlan(a)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Activities.Where(a => a.Status is "进行中" or "已完成" && (d.Esports.ClubId.Length > 0 || !ClubPlan(a))).OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`plans.Where(p => p.Section == group)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: plans.Where(p => p.Section == group).ToList`

**赋值（含属性/字段和局部值）：**

- `_lifeHistoryLimit` += `8`
- `_planScroll` = `scroll.ScrollVertical`
- `arrow.Name` = `"DisclosureArrow"`
- `cards[p.Key]` = `new PlanCard(card,body,toggle,arrow)`
- `detail` += `"\n" + a.Result`
- `detail` += `"\n" + CareerLife.Expected(d, a)`
- `expanded` = `PlanDetails(d,p,id=>Choose(p.Key,id))`
- `heading.CustomMinimumSize` = `new(0,40)`
- `Name` = `"Plan_"+p.Key`

<a id="symbol-9a1d5ca75d7a"></a>

## `Choose(string, string) — void Choose(string key,string target="")`

来源：源码第 124 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Choose(string, string)`](CalendarPlansScreen.cs.md#symbol-9a1d5ca75d7a)；[`NationalSpire.CareerScreen.PlanPane(NationalSpire.CareerData, Godot.VBoxContainer, Godot.ScrollContainer, System.Collections.Generic.List<NationalSpire.CareerScreen.CalendarPlan>, NationalSpire.CalendarDayButton[])`](CalendarPlansScreen.cs.md#symbol-078c4f908d4c)

**调用：** [`Choose(string, string)`](CalendarPlansScreen.cs.md#symbol-9a1d5ca75d7a)；[`NationalSpire.CalendarDayButton.SetPlanPreview(bool)`](CalendarDayButton.cs.md#symbol-98dd56dc07b6)；[`NationalSpire.CareerScreen.CalendarPlans(NationalSpire.CareerData)`](CalendarPlansScreen.cs.md#symbol-60a9060c5331)；[`NationalSpire.CareerScreen.PlanCard.ShowExpanded(bool)`](CalendarPlansScreen.cs.md#symbol-c9a82d9a2cd6)；[`NationalSpire.CareerScreen.PlanDetails(NationalSpire.CareerData, NationalSpire.CareerScreen.CalendarPlan, System.Action<string>)`](CalendarPlansScreen.cs.md#symbol-0f7a307ccb1c)；`Godot.Mathf.RoundToInt(float)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetIndex(bool)`；`Godot.Node.QueueFree()`；`Godot.Node.RemoveChild(Godot.Node)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.List<T>.Find(System.Predicate<T>)`；`System.Func<T, TResult>.Invoke(T)`（委托实际目标见流程文档）；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `Choose(string, string)`；`NationalSpire.CalendarDayButton.Day`；`NationalSpire.CalendarDayButton.SetPlanPreview(bool)`；`NationalSpire.CareerScreen._planKey`；`NationalSpire.CareerScreen._planScroll`；`NationalSpire.CareerScreen._planTarget`；`NationalSpire.CareerScreen.CalendarPlan.Covers`；`NationalSpire.CareerScreen.CalendarPlan.Key`；`NationalSpire.CareerScreen.CalendarPlans(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.PlanCard.Body`；`NationalSpire.CareerScreen.PlanCard.Panel`；`NationalSpire.CareerScreen.PlanCard.ShowExpanded(bool)`；`NationalSpire.CareerScreen.PlanDetails(NationalSpire.CareerData, NationalSpire.CareerScreen.CalendarPlan, System.Action<string>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Choose(string, string)`；输入表达式：`Choose(key,id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id=>Choose(key,id)`
- `Godot.Mathf.RoundToInt(float)`；输入表达式：`Mathf.RoundToInt(expanded.Size.Y)`；返回值紧邻使用处：`AssignmentExpressionSyntax: y-=Mathf.RoundToInt(expanded.Size.Y)`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`current.Body.AddChild(expanded)`；返回值紧邻使用处：`ExpressionStatementSyntax: current.Body.AddChild(expanded);`
- `Godot.Node.GetIndex(bool)`；输入表达式：`next.Panel.GetIndex()`；返回值紧邻使用处：`BinaryExpressionSyntax: previous.Panel.GetIndex()<next.Panel.GetIndex()`
- `Godot.Node.GetIndex(bool)`；输入表达式：`previous.Panel.GetIndex()`；返回值紧邻使用处：`BinaryExpressionSyntax: previous.Panel.GetIndex()<next.Panel.GetIndex()`
- `Godot.Node.QueueFree()`；输入表达式：`expanded.QueueFree()`；返回值紧邻使用处：`ExpressionStatementSyntax: expanded.QueueFree();`
- `Godot.Node.RemoveChild(Godot.Node)`；输入表达式：`previous.Body.RemoveChild(expanded)`；返回值紧邻使用处：`ExpressionStatementSyntax: previous.Body.RemoveChild(expanded);`
- `NationalSpire.CalendarDayButton.SetPlanPreview(bool)`；输入表达式：`date.SetPlanPreview(selected?.Covers(date.Day)==true)`；返回值紧邻使用处：`ExpressionStatementSyntax: date.SetPlanPreview(selected?.Covers(date.Day)==true);`
- `NationalSpire.CareerScreen.CalendarPlans(NationalSpire.CareerData)`；输入表达式：`CalendarPlans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CalendarPlans(d).Find`
- `NationalSpire.CareerScreen.PlanCard.ShowExpanded(bool)`；输入表达式：`current.ShowExpanded(true)`；返回值紧邻使用处：`ExpressionStatementSyntax: current.ShowExpanded(true);`
- `NationalSpire.CareerScreen.PlanCard.ShowExpanded(bool)`；输入表达式：`previous.ShowExpanded(false)`；返回值紧邻使用处：`ExpressionStatementSyntax: previous.ShowExpanded(false);`
- `NationalSpire.CareerScreen.PlanDetails(NationalSpire.CareerData, NationalSpire.CareerScreen.CalendarPlan, System.Action<string>)`；输入表达式：`PlanDetails(d,selected,id=>Choose(key,id))`；返回值紧邻使用处：`AssignmentExpressionSyntax: expanded=PlanDetails(d,selected,id=>Choose(key,id))`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`cards.TryGetValue(_planKey,out var previous)`；返回值紧邻使用处：`BinaryExpressionSyntax: cards.TryGetValue(_planKey,out var previous) && expanded!=null`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`cards.TryGetValue(key,out var current)`；返回值紧邻使用处：`BinaryExpressionSyntax: selected!=null && cards.TryGetValue(key,out var current)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`cards.TryGetValue(key,out var next)`；返回值紧邻使用处：`BinaryExpressionSyntax: cards.TryGetValue(key,out var next) && previous.Panel.GetIndex()<next.Panel.GetIndex()`
- `System.Collections.Generic.List<T>.Find(System.Predicate<T>)`；输入表达式：`CalendarPlans(d).Find(p=>p.Key==key)`；返回值紧邻使用处：`ConditionalExpressionSyntax: key.Length>0 ? CalendarPlans(d).Find(p=>p.Key==key) : null`
- `System.Func<T, TResult>.Invoke(T)`；输入表达式：`.Covers(date.Day)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: selected?.Covers(date.Day)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0,y)`；返回值紧邻使用处：`AssignmentExpressionSyntax: _planScroll=Math.Max(0,y)`

**赋值（含属性/字段和局部值）：**

- `_planKey` = `key`
- `_planScroll` = `Math.Max(0,y)`
- `_planTarget` = `target`
- `expanded` = `null`
- `expanded` = `PlanDetails(d,selected,id=>Choose(key,id))`
- `scroll.ScrollVertical` = `_planScroll`
- `y` -= `Mathf.RoundToInt(expanded.Size.Y)`

<a id="symbol-0f7a307ccb1c"></a>

## `NationalSpire.CareerScreen.PlanDetails(NationalSpire.CareerData, NationalSpire.CareerScreen.CalendarPlan, System.Action<string>) — private MarginContainer PlanDetails(CareerData d,CalendarPlan plan,Action<string> chooseTarget)`

来源：源码第 193 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Choose(string, string)`](CalendarPlansScreen.cs.md#symbol-9a1d5ca75d7a)；[`NationalSpire.CareerScreen.PlanPane(NationalSpire.CareerData, Godot.VBoxContainer, Godot.ScrollContainer, System.Collections.Generic.List<NationalSpire.CareerScreen.CalendarPlan>, NationalSpire.CalendarDayButton[])`](CalendarPlansScreen.cs.md#symbol-078c4f908d4c)

**调用：** [`Field(string, string)`](CalendarPlansScreen.cs.md#symbol-124400be032a)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerRelics.Duration(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-5a1db0b8215e)；[`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`](DashboardControls.cs.md#symbol-0374e90f1c3f)；[`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`](DashboardControls.cs.md#symbol-d6b849a02619)；[`NationalSpire.CareerScreen.Inset(int, int)`](DashboardControls.cs.md#symbol-ebb2fedbb4fc)；[`NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`](DashboardControls.cs.md#symbol-d545a37403bd)；`Godot.CanvasItem.Hide()`；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HSeparator.HSeparator()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.OptionButton.AddItem(string, int)`；`Godot.OptionButton.OptionButton()`；`Godot.OptionButton.Select(int)`；`Godot.VBoxContainer.VBoxContainer()`；`System.Action.Invoke()`（委托实际目标见流程文档）；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `Field(string, string)`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Activities`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerRelics.Duration(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._planTarget`；`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；`NationalSpire.CareerScreen.CalendarPlan.ActionText`；`NationalSpire.CareerScreen.CalendarPlan.Availability`；`NationalSpire.CareerScreen.CalendarPlan.Confirm`；`NationalSpire.CareerScreen.CalendarPlan.Cost`；`NationalSpire.CareerScreen.CalendarPlan.Dates`；`NationalSpire.CareerScreen.CalendarPlan.Effect`；`NationalSpire.CareerScreen.CalendarPlan.Enabled`；`NationalSpire.CareerScreen.CalendarPlan.Key`；`NationalSpire.CareerScreen.CalendarPlan.Target`；`NationalSpire.CareerScreen.CalendarPlan.Targets`；`NationalSpire.CareerScreen.CalendarPlan.TrainingDetails`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；`NationalSpire.CareerScreen.Inset(int, int)`；`NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`；`NationalSpire.LifeActivity.Cost`；`NationalSpire.LifeActivity.Duration`；`NationalSpire.LifeActivity.Id`；`NationalSpire.LifeActivity.PersonId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Field(string, string)`；输入表达式：`Field("筹备与手办优惠", $"原价 {CareerMoney.Format(activity.Cost)} · 原定 {activity.Duration} 天")`；返回值紧邻使用处：`ExpressionStatementSyntax: Field("筹备与手办优惠", $"原价 {CareerMoney.Format(activity.Cost)} · 原定 {activity.Duration} 天");`
- `Field(string, string)`；输入表达式：`Field("费用",CareerMoney.Format(plan.Cost))`；返回值紧邻使用处：`ExpressionStatementSyntax: Field("费用",CareerMoney.Format(plan.Cost));`
- `Field(string, string)`；输入表达式：`Field("覆盖日期",plan.Dates)`；返回值紧邻使用处：`ExpressionStatementSyntax: Field("覆盖日期",plan.Dates);`
- `Field(string, string)`；输入表达式：`Field("计划对象",plan.Target)`；返回值紧邻使用处：`ExpressionStatementSyntax: Field("计划对象",plan.Target);`
- `Field(string, string)`；输入表达式：`Field("实际影响",plan.Effect)`；返回值紧邻使用处：`ExpressionStatementSyntax: Field("实际影响",plan.Effect);`
- `Godot.CanvasItem.Hide()`；输入表达式：`explanation.Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: explanation.Hide();`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`details.AddThemeConstantOverride("separation",5)`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddThemeConstantOverride("separation",5);`
- `Godot.HSeparator.HSeparator()`；输入表达式：`new HSeparator()`；返回值紧邻使用处：`ArgumentSyntax: new HSeparator()`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`details.AddChild(confirm)`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddChild(confirm);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`details.AddChild(DashboardLabel("计划对象",14,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddChild(DashboardLabel("计划对象",14,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`details.AddChild(DashboardLabel(plan.Availability,15,_muted,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddChild(DashboardLabel(plan.Availability,15,_muted,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`details.AddChild(explanation)`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddChild(explanation);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`details.AddChild(list)`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddChild(list);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`details.AddChild(new HSeparator())`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddChild(new HSeparator());`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`details.AddChild(TextLink("训练明细", () =>              {                  if (!explanation.Visible) explanation.Text = breakdown();                  explanation.Visible = !explanation.Visible;              }, 15, underline: true))`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddChild(TextLink("训练明细", () =>              {                  if (!explanation.Visible) explanation.Text = breakdown();                  explanation.Visible = !explanation.Visible;              }, 15, underline: true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`inset.AddChild(details)`；返回值紧邻使用处：`ExpressionStatementSyntax: inset.AddChild(details);`
- `Godot.OptionButton.AddItem(string, int)`；输入表达式：`list.AddItem(person.PublicName)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddItem(person.PublicName);`
- `Godot.OptionButton.OptionButton()`；输入表达式：`new OptionButton {FitToLongestItem=false}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new OptionButton {FitToLongestItem=false}`
- `Godot.OptionButton.Select(int)`；输入表达式：`list.Select(Math.Max(0,people.FindIndex(person=>person.Id==chosen)))`；返回值紧邻使用处：`ExpressionStatementSyntax: list.Select(Math.Max(0,people.FindIndex(person=>person.Id==chosen)));`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer {Name="PlanDetails"}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer {Name="PlanDetails"}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(activity.Cost)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(activity.Cost)}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(plan.Cost)`；返回值紧邻使用处：`ArgumentSyntax: CareerMoney.Format(plan.Cost)`
- `NationalSpire.CareerRelics.Duration(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`CareerRelics.Duration(d, activity)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerRelics.Duration(d, activity) < activity.Duration`
- `NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；输入表达式：`ButtonSurface(confirm,"2b4b51","7b9487","385d61","eed39b",5)`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonSurface(confirm,"2b4b51","7b9487","385d61","eed39b",5);`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("", 15, _muted, true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DashboardLabel("", 15, _muted, true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("计划对象",14,_muted)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel("计划对象",14,_muted)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(plan.Availability,15,_muted,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(plan.Availability,15,_muted,true)`
- `NationalSpire.CareerScreen.FramedAction(string, System.Action, string?, bool, int, int, bool, Godot.Color?, Godot.Color?)`；输入表达式：`FramedAction(plan.ActionText,()=>plan.Confirm?.Invoke(),width:84,height:38)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =FramedAction(plan.ActionText,()=>plan.Confirm?.Invoke(),width:84,height:38)`
- `NationalSpire.CareerScreen.Inset(int, int)`；输入表达式：`Inset(15,12)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Inset(15,12)`
- `NationalSpire.CareerScreen.TextLink(string, System.Action, int, bool, string?)`；输入表达式：`TextLink("训练明细", () =>              {                  if (!explanation.Visible) explanation.Text = breakdown();                  explanation.Visible = !explanation.Visible;              }, 15, underline: true)`；返回值紧邻使用处：`ArgumentSyntax: TextLink("训练明细", () =>              {                  if (!explanation.Visible) explanation.Text = breakdown();                  explanation.Visible = !explanation.Visible;              }, 15, underline: true)`
- `System.Action.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: plan.Confirm?.Invoke()`
- `System.Action<T>.Invoke(T)`；输入表达式：`chooseTarget(people[(int)index].Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: index=>chooseTarget(people[(int)index].Id)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Activities.FirstOrDefault(a => a.Id == plan.Key)`；返回值紧邻使用处：`IsPatternExpressionSyntax: d.Life.Activities.FirstOrDefault(a => a.Id == plan.Key) is { } activity`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Activities.FirstOrDefault(a=>a.Id==plan.Key)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: d.Life.Activities.FirstOrDefault(a=>a.Id==plan.Key)?.PersonId`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`people.FindIndex(person=>person.Id==chosen)`；返回值紧邻使用处：`ArgumentSyntax: people.FindIndex(person=>person.Id==chosen)`
- `System.Func<TResult>.Invoke()`；输入表达式：`breakdown()`；返回值紧邻使用处：`AssignmentExpressionSyntax: explanation.Text = breakdown()`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0,people.FindIndex(person=>person.Id==chosen))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0,people.FindIndex(person=>person.Id==chosen))`

**赋值（含属性/字段和局部值）：**

- `confirm.Disabled` = `plan.Confirm==null || !plan.Enabled`
- `confirm.Name` = `"PlanConfirm"`
- `confirm.SizeFlagsHorizontal` = `SizeFlags.ShrinkEnd`
- `explanation.Text` = `breakdown()`
- `explanation.Visible` = `!explanation.Visible`
- `FitToLongestItem` = `false`
- `list.ItemSelected` += `index=>chooseTarget(people[(int)index].Id)`
- `Name` = `"PlanDetails"`

<a id="symbol-124400be032a"></a>

## `Field(string, string) — void Field(string name,string value)`

来源：源码第 198 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PlanDetails(NationalSpire.CareerData, NationalSpire.CareerScreen.CalendarPlan, System.Action<string>)`](CalendarPlansScreen.cs.md#symbol-0f7a307ccb1c)

**调用：** [`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`details.AddChild(DashboardLabel(name,14,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddChild(DashboardLabel(name,14,_muted));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`details.AddChild(DashboardLabel(value,16,_ink,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: details.AddChild(DashboardLabel(value,16,_ink,true));`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(name,14,_muted)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(name,14,_muted)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(value,16,_ink,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(value,16,_ink,true)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d6b7c872ea02"></a>

## `NationalSpire.CareerScreen.OpenCalendarDay(int) — private void OpenCalendarDay(int day)`

来源：源码第 237 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Advance(int)`](CalendarPlansScreen.cs.md#symbol-29d32a9a20e2)；[`NationalSpire.CareerScreen.AgendaEntry(NationalSpire.CareerData, Godot.VBoxContainer, NationalSpire.CareerScreen.AgendaItem)`](CalendarPlansScreen.cs.md#symbol-d4b6dfb814ed)；[`NationalSpire.CareerScreen.BuildDashboardShell()`](CareerDashboard.cs.md#symbol-168b77d78644)；[`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.OpenAgendaItem(NationalSpire.CareerData, NationalSpire.CareerScreen.AgendaItem)`](CalendarPlansScreen.cs.md#symbol-c0f0934f723d)；[`NationalSpire.CareerScreen.OpenPrivateOfferCalendar(NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-730bf8884640)

**调用：** [`NationalSpire.CalendarMonth.Distance(System.DateOnly, System.DateOnly)`](CalendarMonth.cs.md#symbol-d00453206478)；[`NationalSpire.CalendarMonth.Owner(System.DateOnly)`](CalendarMonth.cs.md#symbol-94d3db2afd40)；[`NationalSpire.CareerScreen.ClearPlan()`](CareerDashboard.cs.md#symbol-26b8e8ad029b)；[`NationalSpire.CareerScreen.Visit(System.Action)`](CareerNavigation.cs.md#symbol-d49752019228)；[`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-8a08be365f83)

**字段、属性、事件及方法组引用：** `NationalSpire.CalendarMonth.Distance(System.DateOnly, System.DateOnly)`；`NationalSpire.CalendarMonth.Owner(System.DateOnly)`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerScreen._calendarMode`；`NationalSpire.CareerScreen._calendarMonth`；`NationalSpire.CareerScreen._selectedDay`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen.ClearPlan()`；`NationalSpire.CareerScreen.ViewData`；`NationalSpire.CareerScreen.Visit(System.Action)`；`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CalendarMonth.Distance(System.DateOnly, System.DateOnly)`；输入表达式：`CalendarMonth.Distance(CalendarMonth.Owner(now),CalendarMonth.Owner(selected))`；返回值紧邻使用处：`AssignmentExpressionSyntax: _calendarMonth = CalendarMonth.Distance(CalendarMonth.Owner(now),CalendarMonth.Owner(selected))`
- `NationalSpire.CalendarMonth.Owner(System.DateOnly)`；输入表达式：`CalendarMonth.Owner(now)`；返回值紧邻使用处：`ArgumentSyntax: CalendarMonth.Owner(now)`
- `NationalSpire.CalendarMonth.Owner(System.DateOnly)`；输入表达式：`CalendarMonth.Owner(selected)`；返回值紧邻使用处：`ArgumentSyntax: CalendarMonth.Owner(selected)`
- `NationalSpire.CareerScreen.ClearPlan()`；输入表达式：`ClearPlan()`；返回值紧邻使用处：`ExpressionStatementSyntax: ClearPlan();`
- `NationalSpire.CareerScreen.Visit(System.Action)`；输入表达式：`Visit(() => { _tab = "日程"; _calendarMonth = CalendarMonth.Distance(CalendarMonth.Owner(now),CalendarMonth.Owner(selected));              _selectedDay = day; _calendarMode = "当日"; ClearPlan(); })`；返回值紧邻使用处：`ExpressionStatementSyntax: Visit(() => { _tab = "日程"; _calendarMonth = CalendarMonth.Distance(CalendarMonth.Owner(now),CalendarMonth.Owner(selected));              _selectedDay = day; _calendarMode = "当日"; ClearPlan(); });`
- `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Date(ViewData, day)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GameCalendar.Date(ViewData, day)`
- `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Date(ViewData, ViewData.Day)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GameCalendar.Date(ViewData, ViewData.Day)`

**赋值（含属性/字段和局部值）：**

- `_calendarMode` = `"当日"`
- `_calendarMonth` = `CalendarMonth.Distance(CalendarMonth.Owner(now),CalendarMonth.Owner(selected))`
- `_selectedDay` = `day`
- `_tab` = `"日程"`

<a id="symbol-9c53a348d954"></a>

## `NationalSpire.CareerScreen.AgendaRange(NationalSpire.CareerData, int, int) — private static string AgendaRange(CareerData data,int start,int end)`

来源：源码第 246 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.CalendarPlans(NationalSpire.CareerData)`](CalendarPlansScreen.cs.md#symbol-60a9060c5331)；[`NationalSpire.CareerScreen.PlanPane(NationalSpire.CareerData, Godot.VBoxContainer, Godot.ScrollContainer, System.Collections.Generic.List<NationalSpire.CareerScreen.CalendarPlan>, NationalSpire.CalendarDayButton[])`](CalendarPlansScreen.cs.md#symbol-078c4f908d4c)

**调用：** [`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-8a08be365f83)；`System.DateOnly.ToString(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Date(data,end)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =GameCalendar.Date(data,end)`
- `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Date(data,start)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =GameCalendar.Date(data,start)`
- `System.DateOnly.ToString(string?)`；输入表达式：`a.ToString("M/d")`；返回值紧邻使用处：`ReturnStatementSyntax: return a.ToString("M/d");`
- `System.DateOnly.ToString(string?)`；输入表达式：`a.ToString(format)`；返回值紧邻使用处：`BinaryExpressionSyntax: a.ToString(format)+"–"`
- `System.DateOnly.ToString(string?)`；输入表达式：`b.ToString(format)`；返回值紧邻使用处：`BinaryExpressionSyntax: a.ToString(format)+"–"+b.ToString(format)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7a2b28fe11e8"></a>

## `NationalSpire.CareerScreen.MatchCaption(NationalSpire.CareerData, NationalSpire.CareerMatch) — private static (string Title,string Stage) MatchCaption(CareerData d,CareerMatch match)`

来源：源码第 254 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.MatchDetail(NationalSpire.CareerData, NationalSpire.CareerMatch)`](CalendarPlansScreen.cs.md#symbol-06ff02fddd30)；[`NationalSpire.CareerScreen.MatchTitle(NationalSpire.CareerData, NationalSpire.CareerMatch)`](CalendarPlansScreen.cs.md#symbol-a9a3a3c86347)

**调用：** [`NationalSpire.CircuitWorld.RoundName(NationalSpire.WorldCompetition, int)`](CircuitWorld.cs.md#symbol-b35defbcdb7c)；[`NationalSpire.EsportsWorld.StageName(string)`](EsportsWorld.cs.md#symbol-c0445cae874d)；`string.LastIndexOf(string, System.StringComparison)`；`string.Replace(string, string?)`；`string.Trim()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerMatch.CompetitionId`；`NationalSpire.CareerMatch.Event`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CareerMatch.Round`；`NationalSpire.CircuitWorld.RoundName(NationalSpire.WorldCompetition, int)`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsWorld.StageName(string)`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Modern`；`NationalSpire.WorldCompetition.Name`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CircuitWorld.RoundName(NationalSpire.WorldCompetition, int)`；输入表达式：`CircuitWorld.RoundName(cup,match.Round)`；返回值紧邻使用处：`ConditionalExpressionSyntax: cup is {Modern:true} ? CircuitWorld.RoundName(cup,match.Round) : $"第{match.Round}轮"`
- `NationalSpire.EsportsWorld.StageName(string)`；输入表达式：`EsportsWorld.StageName(match.Kind)`；返回值紧邻使用处：`BinaryExpressionSyntax: cup?.Name??EsportsWorld.StageName(match.Kind)`
- `string.LastIndexOf(string, System.StringComparison)`；输入表达式：`title.LastIndexOf(" · ",StringComparison.Ordinal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =title.LastIndexOf(" · ",StringComparison.Ordinal)`
- `string.Replace(string, string?)`；输入表达式：`stage.Replace(" ","")`；返回值紧邻使用处：`BinaryExpressionSyntax: compact==stage.Replace(" ","")`
- `string.Replace(string, string?)`；输入表达式：`suffix.Replace(" ","")`；返回值紧邻使用处：`EqualsValueClauseSyntax: =suffix.Replace(" ","")`
- `string.Trim()`；输入表达式：`match.Event.Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =match.Event.Trim()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.FirstOrDefault(c=>c.Id==match.CompetitionId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: match.CompetitionId.Length==0 ? null : d.Esports.Competitions.FirstOrDefault(c=>c.Id==match.CompetitionId)`

**赋值（含属性/字段和局部值）：**

- `title` = `cup?.Name??EsportsWorld.StageName(match.Kind)`

<a id="symbol-a9a3a3c86347"></a>

## `NationalSpire.CareerScreen.MatchTitle(NationalSpire.CareerData, NationalSpire.CareerMatch) — private static string MatchTitle(CareerData d,CareerMatch match)`

来源：源码第 272 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddFixtureRow(NationalSpire.CareerData, NationalSpire.CareerScreen.FixtureEntry, Godot.VBoxContainer, bool)`](FixtureScheduleScreen.cs.md#symbol-237327497b3f)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.Upcoming(NationalSpire.CareerData, bool)`](CalendarPlansScreen.cs.md#symbol-4e05fc1196b2)

**调用：** [`NationalSpire.CareerScreen.MatchCaption(NationalSpire.CareerData, NationalSpire.CareerMatch)`](CalendarPlansScreen.cs.md#symbol-7a2b28fe11e8)

**字段、属性、事件及方法组引用：** `(string Title, string Stage).Title`；`NationalSpire.CareerScreen.MatchCaption(NationalSpire.CareerData, NationalSpire.CareerMatch)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.MatchCaption(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`MatchCaption(d,match)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: MatchCaption(d,match).Title`

**赋值（含属性/字段和局部值）：**


<a id="symbol-06ff02fddd30"></a>

## `NationalSpire.CareerScreen.MatchDetail(NationalSpire.CareerData, NationalSpire.CareerMatch) — private static string MatchDetail(CareerData d,CareerMatch match)`

来源：源码第 273 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.Upcoming(NationalSpire.CareerData, bool)`](CalendarPlansScreen.cs.md#symbol-4e05fc1196b2)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerScreen.MatchCaption(NationalSpire.CareerData, NationalSpire.CareerMatch)`](CalendarPlansScreen.cs.md#symbol-7a2b28fe11e8)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `(string Title, string Stage).Stage`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerScreen.MatchCaption(NationalSpire.CareerData, NationalSpire.CareerMatch)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d,match.OpponentId)`；返回值紧邻使用处：`BinaryExpressionSyntax: "对手："+CareerEngine.DisplayName(d,match.OpponentId)`
- `NationalSpire.CareerScreen.MatchCaption(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`MatchCaption(d,match)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: MatchCaption(d,match).Stage`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join(" · ",new[]{MatchCaption(d,match).Stage,opponent}.Where(s=>s.Length>0))`；返回值紧邻使用处：`ReturnStatementSyntax: return string.Join(" · ",new[]{MatchCaption(d,match).Stage,opponent}.Where(s=>s.Length>0));`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`new[]{MatchCaption(d,match).Stage,opponent}.Where(s=>s.Length>0)`；返回值紧邻使用处：`ArgumentSyntax: new[]{MatchCaption(d,match).Stage,opponent}.Where(s=>s.Length>0)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2a8cdab11ad9"></a>

## `NationalSpire.CareerScreen.CalendarPeriods(NationalSpire.CareerData) — private static IEnumerable<CalendarPeriod> CalendarPeriods(CareerData d)`

来源：源码第 280 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.Upcoming(NationalSpire.CareerData, bool)`](CalendarPlansScreen.cs.md#symbol-4e05fc1196b2)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-1ed5bef75319)；`NationalSpire.CareerScreen.CalendarPeriod.CalendarPeriod(string, string, int, int, int)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerLifeState.Activities`；`NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`；`NationalSpire.CoachTrainingPlan.ClubId`；`NationalSpire.CoachTrainingPlan.EndDay`；`NationalSpire.CoachTrainingPlan.PersonId`；`NationalSpire.CoachTrainingPlan.StartDay`；`NationalSpire.CoachTrainingPlan.State`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.LifeActivity.FinishDay`；`NationalSpire.LifeActivity.StartedDay`；`NationalSpire.LifeActivity.Status`；`NationalSpire.LifeActivity.Title`；`NationalSpire.LifeActivity.TrainingEnd`；`NationalSpire.LifeActivity.TrainingStart`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d,plan.PersonId)`；返回值紧邻使用处：`BinaryExpressionSyntax: "教练训练 · "+CareerEngine.DisplayName(d,plan.PersonId)`
- `NationalSpire.CareerScreen.CalendarPeriod.CalendarPeriod(string, string, int, int, int)`；输入表达式：`new("教练训练 · "+CareerEngine.DisplayName(d,plan.PersonId),plan.State,plan.StartDay,plan.EndDay,plan.EndDay)`；返回值紧邻使用处：`YieldStatementSyntax: yield return new("教练训练 · "+CareerEngine.DisplayName(d,plan.PersonId),plan.State,plan.StartDay,plan.EndDay,plan.EndDay);`
- `NationalSpire.CareerScreen.CalendarPeriod.CalendarPeriod(string, string, int, int, int)`；输入表达式：`new(activity.Title,activity.Status,training?activity.TrainingStart:activity.StartedDay,                  training?activity.TrainingEnd:activity.FinishDay,activity.FinishDay)`；返回值紧邻使用处：`YieldStatementSyntax: yield return new(activity.Title,activity.Status,training?activity.TrainingStart:activity.StartedDay,                  training?activity.TrainingEnd:activity.FinishDay,activity.FinishDay);`
- `NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.TrainingPlans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ClubCoaching.TrainingPlans(d).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`ClubCoaching.TrainingPlans(d).Where(p=>p.ClubId==d.Esports.ClubId && (p.State is "进行中" or "已完成"))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var plan in ClubCoaching.TrainingPlans(d).Where(p=>p.ClubId==d.Esports.ClubId && (p.State is "进行中" or "已完成")))              yield return new("教练训练 · "+CareerEngine.DisplayName(d,plan.PersonId),plan.State,plan.StartDay,plan.EndDay,plan.EndDay);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Activities.Where(a=>a.StartedDay>0 && (a.Status is "进行中" or "已完成"))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var activity in d.Life.Activities.Where(a=>a.StartedDay>0 && (a.Status is "进行中" or "已完成")))          {              bool training=activity.TrainingStart>0 && activity.TrainingEnd>=activity.TrainingStart;              yield return new(activity.Title,activity.Status,training?activity.TrainingStart:activity.StartedDay,                  training?activity.TrainingEnd:activity.FinishDay,activity.FinishDay);          }`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4e05fc1196b2"></a>

## `NationalSpire.CareerScreen.Upcoming(NationalSpire.CareerData, bool) — private static IEnumerable<AgendaItem> Upcoming(CareerData d,bool showPlans=true)`

来源：源码第 292 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.UpcomingDays(NationalSpire.CareerData, Godot.VBoxContainer)`](CalendarPlansScreen.cs.md#symbol-33f94161db0f)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerScreen.CalendarPeriods(NationalSpire.CareerData)`](CalendarPlansScreen.cs.md#symbol-2a8cdab11ad9)；[`NationalSpire.CareerScreen.MatchDetail(NationalSpire.CareerData, NationalSpire.CareerMatch)`](CalendarPlansScreen.cs.md#symbol-06ff02fddd30)；[`NationalSpire.CareerScreen.MatchTitle(NationalSpire.CareerData, NationalSpire.CareerMatch)`](CalendarPlansScreen.cs.md#symbol-a9a3a3c86347)；[`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；[`NationalSpire.SocialAppointments.All(NationalSpire.CareerData)`](SocialAppointments.cs.md#symbol-0596ed8dd544)；`NationalSpire.CareerScreen.AgendaItem.AgendaItem(int, string, string, string, NationalSpire.CareerMatch?, NationalSpire.PrivateOffer?, NationalSpire.RandomEventRecord?)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `(NationalSpire.PrivateConversation Conversation, NationalSpire.PrivateOffer Offer).Conversation`；`(NationalSpire.PrivateConversation Conversation, NationalSpire.PrivateOffer Offer).Offer`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.People`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerLifeState.RandomEvents`；`NationalSpire.CareerMatch.CompetitionId`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.Registered`；`NationalSpire.CareerMatch.Status`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerScreen.AgendaItem.Day`；`NationalSpire.CareerScreen.CalendarPeriod.CompletionDay`；`NationalSpire.CareerScreen.CalendarPeriod.Status`；`NationalSpire.CareerScreen.CalendarPeriod.Title`；`NationalSpire.CareerScreen.CalendarPeriods(NationalSpire.CareerData)`；`NationalSpire.CareerScreen.MatchDetail(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.CareerScreen.MatchTitle(NationalSpire.CareerData, NationalSpire.CareerMatch)`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.Title`；`NationalSpire.RandomEventRecord.Day`；`NationalSpire.RandomEventRecord.People`；`NationalSpire.RandomEventRecord.State`；`NationalSpire.RandomEventRecord.Title`；`NationalSpire.SocialAppointments.All(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d,x.Conversation.PersonId)`；返回值紧邻使用处：`BinaryExpressionSyntax: "对象："+CareerEngine.DisplayName(d,x.Conversation.PersonId)`
- `NationalSpire.CareerScreen.AgendaItem.AgendaItem(int, string, string, string, NationalSpire.CareerMatch?, NationalSpire.PrivateOffer?, NationalSpire.RandomEventRecord?)`；输入表达式：`new AgendaItem(a.CompletionDay,a.Title,"计划完成日")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: a=>new AgendaItem(a.CompletionDay,a.Title,"计划完成日")`
- `NationalSpire.CareerScreen.AgendaItem.AgendaItem(int, string, string, string, NationalSpire.CareerMatch?, NationalSpire.PrivateOffer?, NationalSpire.RandomEventRecord?)`；输入表达式：`new AgendaItem(e.Day,e.Title,"随机事件",e.People.FirstOrDefault(id=>d.People.Any(p=>p.Id==id))??"player",Encounter:e)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: e=>new AgendaItem(e.Day,e.Title,"随机事件",e.People.FirstOrDefault(id=>d.People.Any(p=>p.Id==id))??"player",Encounter:e)`
- `NationalSpire.CareerScreen.AgendaItem.AgendaItem(int, string, string, string, NationalSpire.CareerMatch?, NationalSpire.PrivateOffer?, NationalSpire.RandomEventRecord?)`；输入表达式：`new AgendaItem(m.Day,MatchTitle(d,m),MatchDetail(d,m),m.OpponentId,Match:m)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m=>new AgendaItem(m.Day,MatchTitle(d,m),MatchDetail(d,m),m.OpponentId,Match:m)`
- `NationalSpire.CareerScreen.AgendaItem.AgendaItem(int, string, string, string, NationalSpire.CareerMatch?, NationalSpire.PrivateOffer?, NationalSpire.RandomEventRecord?)`；输入表达式：`new AgendaItem(PrivateAppointments.Date(d,x.Offer),x.Offer.Title,                  "对象："+CareerEngine.DisplayName(d,x.Conversation.PersonId),x.Conversation.PersonId,Visit:x.Offer)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: x=>new AgendaItem(PrivateAppointments.Date(d,x.Offer),x.Offer.Title,                  "对象："+CareerEngine.DisplayName(d,x.Conversation.PersonId),x.Conversation.PersonId,Visit:x.Offer)`
- `NationalSpire.CareerScreen.CalendarPeriods(NationalSpire.CareerData)`；输入表达式：`CalendarPeriods(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CalendarPeriods(d).Where`
- `NationalSpire.CareerScreen.MatchDetail(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`MatchDetail(d,m)`；返回值紧邻使用处：`ArgumentSyntax: MatchDetail(d,m)`
- `NationalSpire.CareerScreen.MatchTitle(NationalSpire.CareerData, NationalSpire.CareerMatch)`；输入表达式：`MatchTitle(d,m)`；返回值紧邻使用处：`ArgumentSyntax: MatchTitle(d,m)`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(d,x.Offer)`；返回值紧邻使用处：`ArgumentSyntax: PrivateAppointments.Date(d,x.Offer)`
- `NationalSpire.SocialAppointments.All(NationalSpire.CareerData)`；输入表达式：`SocialAppointments.All(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: SocialAppointments.All(d).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Any(p=>p.Id==id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id=>d.People.Any(p=>p.Id==id)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`encounters.Concat(visits).Concat(matches).Concat(plans)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: encounters.Concat(visits).Concat(matches).Concat(plans).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`encounters.Concat(visits).Concat(matches)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: encounters.Concat(visits).Concat(matches).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`encounters.Concat(visits)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: encounters.Concat(visits).Concat`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`e.People.FirstOrDefault(id=>d.People.Any(p=>p.Id==id))`；返回值紧邻使用处：`BinaryExpressionSyntax: e.People.FirstOrDefault(id=>d.People.Any(p=>p.Id==id))??"player"`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`encounters.Concat(visits).Concat(matches).Concat(plans).Where(x=>x.Day>=d.Day).OrderBy(x=>x.Day)`；返回值紧邻使用处：`ReturnStatementSyntax: return encounters.Concat(visits).Concat(matches).Concat(plans).Where(x=>x.Day>=d.Day).OrderBy(x=>x.Day);`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Matches.Where(m=>m.Day>=d.Day && m.Registered && m.Status=="待赛").OrderByDescending(m=>m.CompetitionId.Length>0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Matches.Where(m=>m.Day>=d.Day && m.Registered && m.Status=="待赛").OrderByDescending(m=>m.CompetitionId.Length>0)              .Select`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`CalendarPeriods(d).Where(a=>showPlans && a.Status=="进行中").Select(a=>new AgendaItem(a.CompletionDay,a.Title,"计划完成日"))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =CalendarPeriods(d).Where(a=>showPlans && a.Status=="进行中").Select(a=>new AgendaItem(a.CompletionDay,a.Title,"计划完成日"))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.Life.RandomEvents.Where(e=>e.Day>=d.Day && e.State is not ("complete" or "skipped"))              .Select(e=>new AgendaItem(e.Day,e.Title,"随机事件",e.People.FirstOrDefault(id=>d.People.Any(p=>p.Id==id))??"player",Encounter:e))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =d.Life.RandomEvents.Where(e=>e.Day>=d.Day && e.State is not ("complete" or "skipped"))              .Select(e=>new AgendaItem(e.Day,e.Title,"随机事件",e.People.FirstOrDefault(id=>d.People.Any(p=>p.Id==id))??"player",Encounter:e))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.Matches.Where(m=>m.Day>=d.Day && m.Registered && m.Status=="待赛").OrderByDescending(m=>m.CompetitionId.Length>0)              .Select(m=>new AgendaItem(m.Day,MatchTitle(d,m),MatchDetail(d,m),m.OpponentId,Match:m))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =d.Matches.Where(m=>m.Day>=d.Day && m.Registered && m.Status=="待赛").OrderByDescending(m=>m.CompetitionId.Length>0)              .Select(m=>new AgendaItem(m.Day,MatchTitle(d,m),MatchDetail(d,m),m.OpponentId,Match:m))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`SocialAppointments.All(d).Where(x=>x.Offer.State=="已确认")              .Select(x=>new AgendaItem(PrivateAppointments.Date(d,x.Offer),x.Offer.Title,                  "对象："+CareerEngine.DisplayName(d,x.Conversation.PersonId),x.Conversation.PersonId,Visit:x.Offer))`；返回值紧邻使用处：`EqualsValueClauseSyntax: =SocialAppointments.All(d).Where(x=>x.Offer.State=="已确认")              .Select(x=>new AgendaItem(PrivateAppointments.Date(d,x.Offer),x.Offer.Title,                  "对象："+CareerEngine.DisplayName(d,x.Conversation.PersonId),x.Conversation.PersonId,Visit:x.Offer))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`CalendarPeriods(d).Where(a=>showPlans && a.Status=="进行中")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CalendarPeriods(d).Where(a=>showPlans && a.Status=="进行中").Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.RandomEvents.Where(e=>e.Day>=d.Day && e.State is not ("complete" or "skipped"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.RandomEvents.Where(e=>e.Day>=d.Day && e.State is not ("complete" or "skipped"))              .Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.Where(m=>m.Day>=d.Day && m.Registered && m.Status=="待赛")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Matches.Where(m=>m.Day>=d.Day && m.Registered && m.Status=="待赛").OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`encounters.Concat(visits).Concat(matches).Concat(plans).Where(x=>x.Day>=d.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: encounters.Concat(visits).Concat(matches).Concat(plans).Where(x=>x.Day>=d.Day).OrderBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`SocialAppointments.All(d).Where(x=>x.Offer.State=="已确认")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: SocialAppointments.All(d).Where(x=>x.Offer.State=="已确认")              .Select`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c0f0934f723d"></a>

## `NationalSpire.CareerScreen.OpenAgendaItem(NationalSpire.CareerData, NationalSpire.CareerScreen.AgendaItem) — private void OpenAgendaItem(CareerData data,AgendaItem item)`

来源：源码第 305 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)

**调用：** [`NationalSpire.CareerScreen.OpenCalendarDay(int)`](CalendarPlansScreen.cs.md#symbol-d6b7c872ea02)；[`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`](PrivateMessageScreen.cs.md#symbol-3ff4e47d4271)；[`NationalSpire.CareerScreen.OpenRandomEvent(string)`](RandomEventScreen.cs.md#symbol-b6a9dfbe8e4f)；[`NationalSpire.CareerScreen.SelectGroup(string, int)`](GroupChatScreen.cs.md#symbol-72d02215d0db)；[`NationalSpire.CareerScreen.Visit(System.Action)`](CareerNavigation.cs.md#symbol-d49752019228)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerScreen._arenaMatchId`；`NationalSpire.CareerScreen._tab`；`NationalSpire.CareerScreen.AgendaItem.Day`；`NationalSpire.CareerScreen.AgendaItem.Encounter`；`NationalSpire.CareerScreen.AgendaItem.Match`；`NationalSpire.CareerScreen.AgendaItem.Person`；`NationalSpire.CareerScreen.AgendaItem.Visit`；`NationalSpire.CareerScreen.OpenCalendarDay(int)`；`NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；`NationalSpire.CareerScreen.OpenRandomEvent(string)`；`NationalSpire.CareerScreen.SelectGroup(string, int)`；`NationalSpire.CareerScreen.Visit(System.Action)`；`NationalSpire.PrivateOffer.GroupId`；`NationalSpire.RandomEventRecord.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.OpenCalendarDay(int)`；输入表达式：`OpenCalendarDay(item.Day)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenCalendarDay(item.Day);`
- `NationalSpire.CareerScreen.OpenPrivateMessages(string, string, int)`；输入表达式：`OpenPrivateMessages(item.Person)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenPrivateMessages(item.Person);`
- `NationalSpire.CareerScreen.OpenRandomEvent(string)`；输入表达式：`OpenRandomEvent(item.Encounter.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenRandomEvent(item.Encounter.Id);`
- `NationalSpire.CareerScreen.SelectGroup(string, int)`；输入表达式：`SelectGroup(visit.GroupId)`；返回值紧邻使用处：`ExpressionStatementSyntax: SelectGroup(visit.GroupId);`
- `NationalSpire.CareerScreen.Visit(System.Action)`；输入表达式：`Visit(()=>{ _tab="赛事"; _arenaMatchId=match.Id; })`；返回值紧邻使用处：`ExpressionStatementSyntax: Visit(()=>{ _tab="赛事"; _arenaMatchId=match.Id; });`

**赋值（含属性/字段和局部值）：**

- `_arenaMatchId` = `match.Id`
- `_tab` = `"赛事"`

<a id="symbol-d4b6dfb814ed"></a>

## `NationalSpire.CareerScreen.AgendaEntry(NationalSpire.CareerData, Godot.VBoxContainer, NationalSpire.CareerScreen.AgendaItem) — private void AgendaEntry(CareerData d,VBoxContainer box,AgendaItem item)`

来源：源码第 317 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Home(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-059910dfde25)；[`NationalSpire.CareerScreen.UpcomingDays(NationalSpire.CareerData, Godot.VBoxContainer)`](CalendarPlansScreen.cs.md#symbol-33f94161db0f)

**调用：** [`NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`](DashboardControls.cs.md#symbol-5fcff8206cb6)；[`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.Hairline(string)`](DashboardControls.cs.md#symbol-bf15f4abfdcb)；[`NationalSpire.CareerScreen.OpenCalendarDay(int)`](CalendarPlansScreen.cs.md#symbol-d6b7c872ea02)；[`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-8a08be365f83)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.HBoxContainer.HBoxContainer()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildCount(bool)`；`Godot.VBoxContainer.VBoxContainer()`；`Godot.Vector2.Vector2(float, float)`；`System.DateOnly.ToString(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerScreen._gold`；`NationalSpire.CareerScreen._ink`；`NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`；`NationalSpire.CareerScreen.AgendaItem.Day`；`NationalSpire.CareerScreen.AgendaItem.Detail`；`NationalSpire.CareerScreen.AgendaItem.Title`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.Hairline(string)`；`NationalSpire.CareerScreen.OpenCalendarDay(int)`；`NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`copy.AddThemeConstantOverride("separation",3)`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddThemeConstantOverride("separation",3);`
- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`row.AddThemeConstantOverride("separation",15)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddThemeConstantOverride("separation",15);`
- `Godot.HBoxContainer.HBoxContainer()`；输入表达式：`new HBoxContainer {Alignment=BoxContainer.AlignmentMode.Begin}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new HBoxContainer {Alignment=BoxContainer.AlignmentMode.Begin}`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(Hairline())`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(Hairline());`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`copy.AddChild(DashboardLabel(item.Detail,13,_muted,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddChild(DashboardLabel(item.Detail,13,_muted,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`copy.AddChild(DashboardLabel(item.Title,16,_ink,true))`；返回值紧邻使用处：`ExpressionStatementSyntax: copy.AddChild(DashboardLabel(item.Title,16,_ink,true));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(copy)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(copy);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`row.AddChild(when)`；返回值紧邻使用处：`ExpressionStatementSyntax: row.AddChild(when);`
- `Godot.Node.GetChildCount(bool)`；输入表达式：`box.GetChildCount()`；返回值紧邻使用处：`BinaryExpressionSyntax: box.GetChildCount()>0`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill,MouseFilter=MouseFilterEnum.Ignore}`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer {SizeFlagsHorizontal=SizeFlags.ExpandFill,MouseFilter=MouseFilterEnum.Ignore}`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(39,0)`；返回值紧邻使用处：`AssignmentExpressionSyntax: when.CustomMinimumSize=new(39,0)`
- `NationalSpire.CareerScreen.ActionRow(Godot.Container, string, string, System.Action, Godot.Control, int, int, int, string, string, string)`；输入表达式：`ActionRow(box,"AgendaRow",item.Title,()=>OpenCalendarDay(item.Day),row,68,0,8,"00000000","00000000","18303c")`；返回值紧邻使用处：`ExpressionStatementSyntax: ActionRow(box,"AgendaRow",item.Title,()=>OpenCalendarDay(item.Day),row,68,0,8,"00000000","00000000","18303c");`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(item.Day==d.Day?"今天":GameCalendar.Date(d,item.Day).ToString("M/d"),15,_gold)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardLabel(item.Day==d.Day?"今天":GameCalendar.Date(d,item.Day).ToString("M/d"),15,_gold)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(item.Detail,13,_muted,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(item.Detail,13,_muted,true)`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel(item.Title,16,_ink,true)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel(item.Title,16,_ink,true)`
- `NationalSpire.CareerScreen.Hairline(string)`；输入表达式：`Hairline()`；返回值紧邻使用处：`ArgumentSyntax: Hairline()`
- `NationalSpire.CareerScreen.OpenCalendarDay(int)`；输入表达式：`OpenCalendarDay(item.Day)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>OpenCalendarDay(item.Day)`
- `NationalSpire.GameCalendar.Date(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Date(d,item.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GameCalendar.Date(d,item.Day).ToString`
- `System.DateOnly.ToString(string?)`；输入表达式：`GameCalendar.Date(d,item.Day).ToString("M/d")`；返回值紧邻使用处：`ConditionalExpressionSyntax: item.Day==d.Day?"今天":GameCalendar.Date(d,item.Day).ToString("M/d")`

**赋值（含属性/字段和局部值）：**

- `Alignment` = `BoxContainer.AlignmentMode.Begin`
- `MouseFilter` = `MouseFilterEnum.Ignore`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`
- `when.CustomMinimumSize` = `new(39,0)`
- `when.SizeFlagsHorizontal` = `SizeFlags.ShrinkBegin`
- `when.SizeFlagsVertical` = `SizeFlags.ShrinkBegin`

<a id="symbol-33f94161db0f"></a>

## `NationalSpire.CareerScreen.UpcomingDays(NationalSpire.CareerData, Godot.VBoxContainer) — private void UpcomingDays(CareerData d, VBoxContainer box)`

来源：源码第 332 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)

**调用：** [`NationalSpire.CareerScreen.AgendaEntry(NationalSpire.CareerData, Godot.VBoxContainer, NationalSpire.CareerScreen.AgendaItem)`](CalendarPlansScreen.cs.md#symbol-d4b6dfb814ed)；[`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`](DashboardControls.cs.md#symbol-1c4fb2c61c90)；[`NationalSpire.CareerScreen.Upcoming(NationalSpire.CareerData, bool)`](CalendarPlansScreen.cs.md#symbol-4e05fc1196b2)；`Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildCount(bool)`；`Godot.VBoxContainer.VBoxContainer()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._muted`；`NationalSpire.CareerScreen._showCalendarPlans`；`NationalSpire.CareerScreen.AgendaEntry(NationalSpire.CareerData, Godot.VBoxContainer, NationalSpire.CareerScreen.AgendaItem)`；`NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；`NationalSpire.CareerScreen.Upcoming(NationalSpire.CareerData, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Control.AddThemeConstantOverride(Godot.StringName, int)`；输入表达式：`list.AddThemeConstantOverride("separation",0)`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddThemeConstantOverride("separation",0);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(list)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(list);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`list.AddChild(DashboardLabel("暂无后续安排",16,_muted))`；返回值紧邻使用处：`ExpressionStatementSyntax: list.AddChild(DashboardLabel("暂无后续安排",16,_muted));`
- `Godot.Node.GetChildCount(bool)`；输入表达式：`list.GetChildCount()`；返回值紧邻使用处：`BinaryExpressionSyntax: list.GetChildCount()==0`
- `Godot.VBoxContainer.VBoxContainer()`；输入表达式：`new VBoxContainer()`；返回值紧邻使用处：`EqualsValueClauseSyntax: =new VBoxContainer()`
- `NationalSpire.CareerScreen.AgendaEntry(NationalSpire.CareerData, Godot.VBoxContainer, NationalSpire.CareerScreen.AgendaItem)`；输入表达式：`AgendaEntry(d,list,item)`；返回值紧邻使用处：`ExpressionStatementSyntax: AgendaEntry(d,list,item);`
- `NationalSpire.CareerScreen.DashboardLabel(string, int, Godot.Color, bool)`；输入表达式：`DashboardLabel("暂无后续安排",16,_muted)`；返回值紧邻使用处：`ArgumentSyntax: DashboardLabel("暂无后续安排",16,_muted)`
- `NationalSpire.CareerScreen.Upcoming(NationalSpire.CareerData, bool)`；输入表达式：`Upcoming(d,_showCalendarPlans)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var item in Upcoming(d,_showCalendarPlans)) AgendaEntry(d,list,item);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0019411c0ad4"></a>

## `NationalSpire.CareerScreen.CalendarCommands(NationalSpire.CareerData, Godot.HBoxContainer) — private void CalendarCommands(CareerData d, HBoxContainer box)`

来源：源码第 339 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)

**调用：** [`Advance(int)`](CalendarPlansScreen.cs.md#symbol-29d32a9a20e2)；[`NationalSpire.CareerEngine.NextEventDay(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-0dbe0f2d1cdc)；[`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`](DashboardControls.cs.md#symbol-0374e90f1c3f)；[`NationalSpire.CareerScreen.DashboardSwitch(string, bool, System.Action<bool>, int, int)`](DashboardControls.cs.md#symbol-f6780ccb3f84)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.TeamButton(string, System.Action, int)`](CareerSession.cs.md#symbol-a13f3923812a)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.CircuitWorld.AutoEntry(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-43c8211433d7)；[`NationalSpire.SeasonCalendar.End(NationalSpire.CareerData)`](SeasonCalendar.cs.md#symbol-6b4c49a62324)；`Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；`Godot.Control.Control()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`Godot.Node.GetChildren(bool)`；`Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.IEnumerable.OfType<TResult>()`

**字段、属性、事件及方法组引用：** `Advance(int)`；`NationalSpire.CareerData.AutoQualifiers`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerEngine.NextEventDay(NationalSpire.CareerData)`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Kind`；`NationalSpire.CareerMatch.Registered`；`NationalSpire.CareerMatch.Status`；`NationalSpire.CareerScreen._multiplayer`；`NationalSpire.CareerScreen._showCalendarPlans`；`NationalSpire.CareerScreen.AdvanceCareerDay()`；`NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；`NationalSpire.CareerScreen.DashboardSwitch(string, bool, System.Action<bool>, int, int)`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.Render()`；`NationalSpire.CareerScreen.TeamButton(string, System.Action, int)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.CircuitWorld.AutoEntry(NationalSpire.CareerData)`；`NationalSpire.ICareerSession.Host`；`NationalSpire.SeasonCalendar.End(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Advance(int)`；输入表达式：`Advance(d.Day + 28)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>Advance(d.Day + 28)`
- `Advance(int)`；输入表达式：`Advance(day)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>Advance(day)`
- `Advance(int)`；输入表达式：`Advance(SeasonCalendar.End(d)+1)`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: ()=>Advance(SeasonCalendar.End(d)+1)`
- `Godot.Control.AddThemeFontSizeOverride(Godot.StringName, int)`；输入表达式：`button.AddThemeFontSizeOverride("font_size",15)`；返回值紧邻使用处：`ExpressionStatementSyntax: button.AddThemeFontSizeOverride("font_size",15);`
- `Godot.Control.Control()`；输入表达式：`new Control { SizeFlagsHorizontal=SizeFlags.ExpandFill }`；返回值紧邻使用处：`ArgumentSyntax: new Control { SizeFlagsHorizontal=SizeFlags.ExpandFill }`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(auto)`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(auto);`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(DashboardSwitch("显示计划",_showCalendarPlans,on=>{_showCalendarPlans=on; Render();},112,38))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(DashboardSwitch("显示计划",_showCalendarPlans,on=>{_showCalendarPlans=on; Render();},112,38));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(new Control { SizeFlagsHorizontal=SizeFlags.ExpandFill })`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(new Control { SizeFlagsHorizontal=SizeFlags.ExpandFill });`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(TeamButton("跳到下一个事件",()=>Advance(day),0))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(TeamButton("跳到下一个事件",()=>Advance(day),0));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(TeamButton("跳过四周",()=>Advance(d.Day + 28),0))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(TeamButton("跳过四周",()=>Advance(d.Day + 28),0));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(TeamButton("推进一天",AdvanceCareerDay,0))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(TeamButton("推进一天",AdvanceCareerDay,0));`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`box.AddChild(TeamButton("下个赛季",()=>Advance(SeasonCalendar.End(d)+1),0))`；返回值紧邻使用处：`ExpressionStatementSyntax: box.AddChild(TeamButton("下个赛季",()=>Advance(SeasonCalendar.End(d)+1),0));`
- `Godot.Node.GetChildren(bool)`；输入表达式：`box.GetChildren()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: box.GetChildren().OfType<Button>`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new(0,38)`；返回值紧邻使用处：`AssignmentExpressionSyntax: button.CustomMinimumSize=new(0,38)`
- `NationalSpire.CareerEngine.NextEventDay(NationalSpire.CareerData)`；输入表达式：`CareerEngine.NextEventDay(d)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.NextEventDay(d) is int day`
- `NationalSpire.CareerScreen.ButtonSurface(Godot.Button, string, string, string, string, int, int)`；输入表达式：`ButtonSurface(button,"142632","395365","28434c","658c91",6,5)`；返回值紧邻使用处：`ExpressionStatementSyntax: ButtonSurface(button,"142632","395365","28434c","658c91",6,5);`
- `NationalSpire.CareerScreen.DashboardSwitch(string, bool, System.Action<bool>, int, int)`；输入表达式：`DashboardSwitch("显示计划",_showCalendarPlans,on=>{_showCalendarPlans=on; Render();},112,38)`；返回值紧邻使用处：`ArgumentSyntax: DashboardSwitch("显示计划",_showCalendarPlans,on=>{_showCalendarPlans=on; Render();},112,38)`
- `NationalSpire.CareerScreen.DashboardSwitch(string, bool, System.Action<bool>, int, int)`；输入表达式：`DashboardSwitch("选拔赛自动报名",d.AutoQualifiers,on=>          {              if (MultiplayerCommand("propose-auto",number:on ? 1 : 0)) { Render(); return; }              d.AutoQualifiers = on;              if (d.AutoQualifiers) CircuitWorld.AutoEntry(d);              else foreach (var m in d.Matches.Where(m => m.Kind is "local" or "city" or "academy" && m.Status == "待赛" && m.Id != d.PendingMatchId)) m.Registered = false;              CareerStore.Save(d); Render();          },158,38)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =DashboardSwitch("选拔赛自动报名",d.AutoQualifiers,on=>          {              if (MultiplayerCommand("propose-auto",number:on ? 1 : 0)) { Render(); return; }              d.AutoQualifiers = on;              if (d.AutoQualifiers) CircuitWorld.AutoEntry(d);              else foreach (var m in d.Matches.Where(m => m.Kind is "local" or "city" or "academy" && m.Status == "待赛" && m.Id != d.PendingMatchId)) m.Registered = false;              CareerStore.Save(d); Render();          },158,38)`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("propose-auto",number:on ? 1 : 0)`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("propose-auto",number:on ? 1 : 0)) { Render(); return; }`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`
- `NationalSpire.CareerScreen.TeamButton(string, System.Action, int)`；输入表达式：`TeamButton("跳到下一个事件",()=>Advance(day),0)`；返回值紧邻使用处：`ArgumentSyntax: TeamButton("跳到下一个事件",()=>Advance(day),0)`
- `NationalSpire.CareerScreen.TeamButton(string, System.Action, int)`；输入表达式：`TeamButton("跳过四周",()=>Advance(d.Day + 28),0)`；返回值紧邻使用处：`ArgumentSyntax: TeamButton("跳过四周",()=>Advance(d.Day + 28),0)`
- `NationalSpire.CareerScreen.TeamButton(string, System.Action, int)`；输入表达式：`TeamButton("推进一天",AdvanceCareerDay,0)`；返回值紧邻使用处：`ArgumentSyntax: TeamButton("推进一天",AdvanceCareerDay,0)`
- `NationalSpire.CareerScreen.TeamButton(string, System.Action, int)`；输入表达式：`TeamButton("下个赛季",()=>Advance(SeasonCalendar.End(d)+1),0)`；返回值紧邻使用处：`ArgumentSyntax: TeamButton("下个赛季",()=>Advance(SeasonCalendar.End(d)+1),0)`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(d);`
- `NationalSpire.CircuitWorld.AutoEntry(NationalSpire.CareerData)`；输入表达式：`CircuitWorld.AutoEntry(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CircuitWorld.AutoEntry(d);`
- `NationalSpire.SeasonCalendar.End(NationalSpire.CareerData)`；输入表达式：`SeasonCalendar.End(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.End(d)+1`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.Where(m => m.Kind is "local" or "city" or "academy" && m.Status == "待赛" && m.Id != d.PendingMatchId)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var m in d.Matches.Where(m => m.Kind is "local" or "city" or "academy" && m.Status == "待赛" && m.Id != d.PendingMatchId)) m.Registered = false;`
- `System.Collections.IEnumerable.OfType<TResult>()`；输入表达式：`box.GetChildren().OfType<Button>()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach(var button in box.GetChildren().OfType<Button>())          {              button.CustomMinimumSize=new(0,38); button.AddThemeFontSizeOverride("font_size",15);              ButtonSurface(button,"142632","395365","28434c","658c91",6,5);          }`

**赋值（含属性/字段和局部值）：**

- `_showCalendarPlans` = `on`
- `auto.Disabled` = `_multiplayer is {Host:false}`
- `button.CustomMinimumSize` = `new(0,38)`
- `d.AutoQualifiers` = `on`
- `m.Registered` = `false`
- `SizeFlagsHorizontal` = `SizeFlags.ExpandFill`

<a id="symbol-29d32a9a20e2"></a>

## `Advance(int) — void Advance(int day)`

来源：源码第 341 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CalendarCommands(NationalSpire.CareerData, Godot.HBoxContainer)`](CalendarPlansScreen.cs.md#symbol-0019411c0ad4)

**调用：** [`NationalSpire.CareerEngine.AdvanceToDay(NationalSpire.CareerData, int, bool)`](CareerEngine.cs.md#symbol-0c04b8ec5f73)；[`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`](CareerSession.cs.md#symbol-babd46c04a9f)；[`NationalSpire.CareerScreen.OpenCalendarDay(int)`](CalendarPlansScreen.cs.md#symbol-d6b7c872ea02)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerEngine.AdvanceToDay(NationalSpire.CareerData, int, bool)`；`NationalSpire.CareerScreen._calendarMonth`；`NationalSpire.CareerScreen._selectedDay`；`NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；`NationalSpire.CareerScreen.OpenCalendarDay(int)`；`NationalSpire.CareerScreen.Render()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.AdvanceToDay(NationalSpire.CareerData, int, bool)`；输入表达式：`CareerEngine.AdvanceToDay(d,day)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.AdvanceToDay(d,day);`
- `NationalSpire.CareerScreen.MultiplayerCommand(string, string, string, int, string, System.Action?)`；输入表达式：`MultiplayerCommand("propose-advance",number:day)`；返回值紧邻使用处：`IfStatementSyntax: if (MultiplayerCommand("propose-advance",number:day)) return;`
- `NationalSpire.CareerScreen.OpenCalendarDay(int)`；输入表达式：`OpenCalendarDay(day)`；返回值紧邻使用处：`ExpressionStatementSyntax: OpenCalendarDay(day);`
- `NationalSpire.CareerScreen.Render()`；输入表达式：`Render()`；返回值紧邻使用处：`ExpressionStatementSyntax: Render();`

**赋值（含属性/字段和局部值）：**

- `_calendarMonth` = `0`
- `_selectedDay` = `d.Day`
