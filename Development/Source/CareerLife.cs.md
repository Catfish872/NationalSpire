# CareerLife.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`5333844A03F628521C2C8F281D2D798C80FC0AD2C1D01965344BF1AC70087373`。来源：[源码](../../CareerLife.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerLife`。

字段、事件及初始值（源码原样）：

```csharp
public const int Version = 5;
```

<a id="symbol-eb417e39aebf"></a>

## `NationalSpire.CareerLife.Ensure(NationalSpire.CareerData) — public static void Ensure(CareerData d)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.CreateTestSession(NationalSpire.CareerData, NationalSpire.PromptTestSource, string)`](PromptTesting.cs.md#symbol-c81f52ee7090)；[`NationalSpire.CareerEngine.CreateNew(bool, int)`](CareerEngine.cs.md#symbol-63d93017946a)；[`NationalSpire.CareerEngine.NormalizeRoster(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-eb11b96e7400)；[`NationalSpire.CareerLife.Advance(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-62ec6434f115)

**调用：** [`NationalSpire.CareerCommerce.Capture(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-02ba08b48a24)；[`NationalSpire.CareerCommerce.IdentityIndex(NationalSpire.CareerData, string)`](CareerCommerce.cs.md#symbol-e72ebe7c108f)；[`NationalSpire.CareerLife.Hash(NationalSpire.CareerData, string)`](CareerLife.cs.md#symbol-0780f4d6b962)；[`NationalSpire.CareerLife.RefreshPublicFacts(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-e81d9b416e03)；[`NationalSpire.CareerLife.RepairActivities(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-ce584c11d638)；[`NationalSpire.CareerLife.UpgradeOffers(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-e7f329375f86)；[`NationalSpire.CareerMoney.Historical(string)`](LifeData.cs.md#symbol-cb85455756cc)；[`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`](LifeData.cs.md#symbol-54a09649188b)；[`NationalSpire.CareerRelics.Shop(NationalSpire.CareerData)`](CareerRelics.cs.md#symbol-b30378b84f42)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；[`NationalSpire.MatchRules.Reward(int, double)`](MatchRules.cs.md#symbol-1b4687e2daa3)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `(string Key, string Title, int Cost).Cost`；`(string Key, string Title, int Cost).Key`；`NationalSpire.CareerClub.Id`；`NationalSpire.CareerClub.NextOperatingDay`；`NationalSpire.CareerClub.OperatingIncome`；`NationalSpire.CareerCommerce.Capture(NationalSpire.CareerData)`；`NationalSpire.CareerCommerce.IdentityIndex(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.CommunityMemories`；`NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerData.SeasonHistory`；`NationalSpire.CareerLife.Hash(NationalSpire.CareerData, string)`；`NationalSpire.CareerLife.RefreshPublicFacts(NationalSpire.CareerData)`；`NationalSpire.CareerLife.RepairActivities(NationalSpire.CareerData)`；`NationalSpire.CareerLife.UpgradeOffers(NationalSpire.CareerData)`；`NationalSpire.CareerLife.Version`；`NationalSpire.CareerLifeState.Activities`；`NationalSpire.CareerLifeState.Collection`；`NationalSpire.CareerLifeState.NextOfferDay`；`NationalSpire.CareerLifeState.NextProjectDay`；`NationalSpire.CareerLifeState.NextWorldEventDay`；`NationalSpire.CareerLifeState.OfferRound`；`NationalSpire.CareerLifeState.PrizeTotal`；`NationalSpire.CareerLifeState.Version`；`NationalSpire.CareerMatch.Draw`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.PlayerWon`；`NationalSpire.CareerMatch.Prize`；`NationalSpire.CareerMoney.Historical(string)`；`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；`NationalSpire.CareerRelics.Shop(NationalSpire.CareerData)`；`NationalSpire.CareerResult.MatchId`；`NationalSpire.CareerResult.RewardMultiplier`；`NationalSpire.CommercialSnapshot.Summary`；`NationalSpire.CommunityMemory.Kind`；`NationalSpire.CommunityMemory.Text`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.SourceBody`；`NationalSpire.CommunityPost.SourceTitle`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.EsportsCareer.Clubs`；`NationalSpire.EsportsCareer.CommercialHistory`；`NationalSpire.EsportsCareer.EcosystemVersion`；`NationalSpire.LifeActivity.Cost`；`NationalSpire.LifeActivity.PaidCost`；`NationalSpire.LifeActivity.Round`；`NationalSpire.LifeActivity.Status`；`NationalSpire.LifeCatalog.Objects`；`NationalSpire.MatchRules.Reward(int, double)`；`NationalSpire.SeasonRecap.Prize`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerCommerce.Capture(NationalSpire.CareerData)`；输入表达式：`CareerCommerce.Capture(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerCommerce.Capture(d);`
- `NationalSpire.CareerCommerce.IdentityIndex(NationalSpire.CareerData, string)`；输入表达式：`CareerCommerce.IdentityIndex(d, club.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerCommerce.IdentityIndex(d, club.Id)`
- `NationalSpire.CareerLife.Hash(NationalSpire.CareerData, string)`；输入表达式：`Hash(d, "first")`；返回值紧邻使用处：`BinaryExpressionSyntax: Hash(d, "first") % 4`
- `NationalSpire.CareerLife.Hash(NationalSpire.CareerData, string)`；输入表达式：`Hash(d, club.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: Hash(d, club.Id) % 151`
- `NationalSpire.CareerLife.Hash(NationalSpire.CareerData, string)`；输入表达式：`Hash(d, club.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: Hash(d, club.Id) % 7`
- `NationalSpire.CareerLife.RefreshPublicFacts(NationalSpire.CareerData)`；输入表达式：`RefreshPublicFacts(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: RefreshPublicFacts(d);`
- `NationalSpire.CareerLife.RepairActivities(NationalSpire.CareerData)`；输入表达式：`RepairActivities(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: RepairActivities(d);`
- `NationalSpire.CareerLife.UpgradeOffers(NationalSpire.CareerData)`；输入表达式：`UpgradeOffers(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: UpgradeOffers(d);`
- `NationalSpire.CareerMoney.Historical(string)`；输入表达式：`CareerMoney.Historical(memory.Text)`；返回值紧邻使用处：`AssignmentExpressionSyntax: memory.Text = CareerMoney.Historical(memory.Text)`
- `NationalSpire.CareerMoney.Historical(string)`；输入表达式：`CareerMoney.Historical(post.SourceBody)`；返回值紧邻使用处：`AssignmentExpressionSyntax: post.SourceBody = CareerMoney.Historical(post.SourceBody)`
- `NationalSpire.CareerMoney.Historical(string)`；输入表达式：`CareerMoney.Historical(post.SourceTitle)`；返回值紧邻使用处：`AssignmentExpressionSyntax: post.SourceTitle = CareerMoney.Historical(post.SourceTitle)`
- `NationalSpire.CareerMoney.Historical(string)`；输入表达式：`CareerMoney.Historical(snapshot.Summary)`；返回值紧邻使用处：`AssignmentExpressionSyntax: snapshot.Summary = CareerMoney.Historical(snapshot.Summary)`
- `NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；输入表达式：`CareerMoney.Record(d, "旧版个人物品退款（收藏保留）", refund)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Record(d, "旧版个人物品退款（收藏保留）", refund);`
- `NationalSpire.CareerRelics.Shop(NationalSpire.CareerData)`；输入表达式：`CareerRelics.Shop(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerRelics.Shop(d);`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(d).Where`
- `NationalSpire.MatchRules.Reward(int, double)`；输入表达式：`MatchRules.Reward(m.Prize / 2, r.RewardMultiplier)`；返回值紧邻使用处：`ConditionalExpressionSyntax: m.Draw ? MatchRules.Reward(m.Prize / 2, r.RewardMultiplier) : 0`
- `NationalSpire.MatchRules.Reward(int, double)`；输入表达式：`MatchRules.Reward(m.Prize, r.RewardMultiplier)`；返回值紧邻使用处：`ConditionalExpressionSyntax: m.PlayerWon ? MatchRules.Reward(m.Prize, r.RewardMultiplier) : m.Draw ? MatchRules.Reward(m.Prize / 2, r.RewardMultiplier) : 0`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`d.Life.Collection.ContainsKey(x.Key)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: x => d.Life.Collection.ContainsKey(x.Key)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.FirstOrDefault(m => m.Id == r.MatchId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: d.Matches.FirstOrDefault(m => m.Id == r.MatchId) is { } m`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, int>)`；输入表达式：`LifeCatalog.Objects.Where(x => d.Life.Collection.ContainsKey(x.Key)).Sum(x => x.Cost)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = LifeCatalog.Objects.Where(x => d.Life.Collection.ContainsKey(x.Key)).Sum(x => x.Cost)`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；输入表达式：`d.Results.Sum(r => (long)(d.Matches.FirstOrDefault(m => m.Id == r.MatchId) is { } m                  ? m.PlayerWon ? MatchRules.Reward(m.Prize, r.RewardMultiplier) : m.Draw ? MatchRules.Reward(m.Prize / 2, r.RewardMultiplier) : 0 : 0))`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Results.Sum(r => (long)(d.Matches.FirstOrDefault(m => m.Id == r.MatchId) is { } m                  ? m.PlayerWon ? MatchRules.Reward(m.Prize, r.RewardMultiplier) : m.Draw ? MatchRules.Reward(m.Prize / 2, r.RewardMultiplier) : 0 : 0))                  + d.SeasonHistory.Sum(s => (long)s.Prize)`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；输入表达式：`d.SeasonHistory.Sum(s => (long)s.Prize)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Results.Sum(r => (long)(d.Matches.FirstOrDefault(m => m.Id == r.MatchId) is { } m                  ? m.PlayerWon ? MatchRules.Reward(m.Prize, r.RewardMultiplier) : m.Draw ? MatchRules.Reward(m.Prize / 2, r.RewardMultiplier) : 0 : 0))                  + d.SeasonHistory.Sum(s => (long)s.Prize)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Life.Activities.Where(a => a.Status == "可安排").ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Life.Activities.Where(a => a.Status == "可安排").ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(d).Where(p => p.AuthorId != "player")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var post in CommunityThreads.All(d).Where(p => p.AuthorId != "player"))              { post.SourceTitle = CareerMoney.Historical(post.SourceTitle); post.SourceBody = CareerMoney.Historical(post.SourceBody); }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.CommunityMemories.Where(m => m.Kind == "fact")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var memory in d.CommunityMemories.Where(m => m.Kind == "fact")) memory.Text = CareerMoney.Historical(memory.Text);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Activities.Where(a => a.Status != "可安排")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var a in d.Life.Activities.Where(a => a.Status != "可安排")) a.PaidCost = a.Cost;`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Activities.Where(a => a.Status == "可安排")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Activities.Where(a => a.Status == "可安排").ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`LifeCatalog.Objects.Where(x => d.Life.Collection.ContainsKey(x.Key))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LifeCatalog.Objects.Where(x => d.Life.Collection.ContainsKey(x.Key)).Sum`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(1, d.Life.OfferRound)`；返回值紧邻使用处：`AssignmentExpressionSyntax: d.Life.OfferRound = Math.Max(1, d.Life.OfferRound)`

**赋值（含属性/字段和局部值）：**

- `a.PaidCost` = `a.Cost`
- `a.Round` = `1`
- `club.NextOperatingDay` = `d.Day + 7 + Hash(d, club.Id) % 7`
- `club.OperatingIncome` = `(kind switch { 0 => 10000, 1 => 7500, 2 => 12000, _ => 6500 }) + Hash(d, club.Id) % 151`
- `d.Credits` += `refund`
- `d.Life.NextOfferDay` = `d.Day + 2 + Hash(d, "first") % 4`
- `d.Life.NextProjectDay` = `d.Day + 21`
- `d.Life.NextWorldEventDay` = `d.Day + 2`
- `d.Life.OfferRound` = `Math.Max(1, d.Life.OfferRound)`
- `d.Life.PrizeTotal` = `d.Results.Sum(r => (long)(d.Matches.FirstOrDefault(m => m.Id == r.MatchId) is { } m                  ? m.PlayerWon ? MatchRules.Reward(m.Prize, r.RewardMultiplier) : m.Draw ? MatchRules.Reward(m.Prize / 2, r.RewardMultiplier) : 0 : 0))                  + d.SeasonHistory.Sum(s => (long)s.Prize)`
- `d.Life.Version` = `Version`
- `memory.Text` = `CareerMoney.Historical(memory.Text)`
- `post.SourceBody` = `CareerMoney.Historical(post.SourceBody)`
- `post.SourceTitle` = `CareerMoney.Historical(post.SourceTitle)`
- `snapshot.Summary` = `CareerMoney.Historical(snapshot.Summary)`

<a id="symbol-e7f329375f86"></a>

## `NationalSpire.CareerLife.UpgradeOffers(NationalSpire.CareerData) — private static void UpgradeOffers(CareerData d)`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Ensure(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-eb417e39aebf)

**调用：** [`NationalSpire.LifeCatalog.Resolve(NationalSpire.LifeActivity)`](LifeCatalog.cs.md#symbol-bc308a2857a8)；`string.Replace(string, string?)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Activities`；`NationalSpire.LifeActivity.Cost`；`NationalSpire.LifeActivity.DefensePoints`；`NationalSpire.LifeActivity.Detail`；`NationalSpire.LifeActivity.Duration`；`NationalSpire.LifeActivity.Kind`；`NationalSpire.LifeActivity.LongProject`；`NationalSpire.LifeActivity.Status`；`NationalSpire.LifeActivity.TemporaryPoints`；`NationalSpire.LifeActivity.TermsVersion`；`NationalSpire.LifeActivity.TrainingStart`；`NationalSpire.LifeActivity.WeeklyGrowthPoints`；`NationalSpire.LifeCatalog.Plan.Cost`；`NationalSpire.LifeCatalog.Plan.Days`；`NationalSpire.LifeCatalog.Plan.Long`；`NationalSpire.LifeCatalog.Resolve(NationalSpire.LifeActivity)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.LifeCatalog.Resolve(NationalSpire.LifeActivity)`；输入表达式：`LifeCatalog.Resolve(a)`；返回值紧邻使用处：`IsPatternExpressionSyntax: LifeCatalog.Resolve(a) is { } p`
- `string.Replace(string, string?)`；输入表达式：`a.Detail.Replace("70%—130%", "84%—156%")`；返回值紧邻使用处：`AssignmentExpressionSyntax: a.Detail = a.Detail.Replace("70%—130%", "84%—156%")`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Activities.Where(a => a.Status is "可安排" or "进行中" && a.TermsVersion < 3)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var a in d.Life.Activities.Where(a => a.Status is "可安排" or "进行中" && a.TermsVersion < 3))          {              if (a.Status == "可安排" && a.TermsVersion < 2 && a.Kind == "经营" && LifeCatalog.Resolve(a) is { } p)              { a.Cost = p.Cost; a.Duration = p.Days; a.LongProject = p.Long; }              // 仅加强尚未结算的效果，保留已付费用、已完成周数与既有成长。              if (a.Status == "进行中" && a.TrainingStart > 0)              { a.TemporaryPoints *= 2; a.DefensePoints *= 2; a.WeeklyGrowthPoints *= 2; }              if (a.Kind == "商业") a.Detail = a.Detail.Replace("70%—130%", "84%—156%");              a.TermsVersion = 3;          }`

**赋值（含属性/字段和局部值）：**

- `a.Cost` = `p.Cost`
- `a.DefensePoints` *= `2`
- `a.Detail` = `a.Detail.Replace("70%—130%", "84%—156%")`
- `a.Duration` = `p.Days`
- `a.LongProject` = `p.Long`
- `a.TemporaryPoints` *= `2`
- `a.TermsVersion` = `3`
- `a.WeeklyGrowthPoints` *= `2`

<a id="symbol-ce584c11d638"></a>

## `NationalSpire.CareerLife.RepairActivities(NationalSpire.CareerData) — private static void RepairActivities(CareerData d)`

来源：源码第 58 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Ensure(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-eb417e39aebf)

**调用：** [`NationalSpire.CareerLife.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerLife.cs.md#symbol-e559cea1bbf6)；[`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`](LifeData.cs.md#symbol-54a09649188b)；[`NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`](CareerTraining.cs.md#symbol-98adbc7a75dc)；[`NationalSpire.CareerTraining.Multiplayer(NationalSpire.CareerData)`](CareerTraining.cs.md#symbol-69fbc353877e)；[`NationalSpire.CareerTraining.Snapshot(NationalSpire.CareerData, NationalSpire.LifeActivity, bool)`](CareerTraining.cs.md#symbol-feb4623577e9)；[`NationalSpire.LifeCatalog.Resolve(NationalSpire.LifeActivity)`](LifeCatalog.cs.md#symbol-bc308a2857a8)；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLife.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.CareerLifeState.Activities`；`NationalSpire.CareerLifeState.RepairNotices`；`NationalSpire.CareerLifeState.RepairReceipts`；`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；`NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`；`NationalSpire.CareerTraining.Multiplayer(NationalSpire.CareerData)`；`NationalSpire.CareerTraining.Snapshot(NationalSpire.CareerData, NationalSpire.LifeActivity, bool)`；`NationalSpire.LifeActivity.Cost`；`NationalSpire.LifeActivity.Id`；`NationalSpire.LifeActivity.Kind`；`NationalSpire.LifeActivity.PaidCost`；`NationalSpire.LifeActivity.Result`；`NationalSpire.LifeActivity.Status`；`NationalSpire.LifeActivity.Title`；`NationalSpire.LifeActivity.Variant`；`NationalSpire.LifeCatalog.Plan.Key`；`NationalSpire.LifeCatalog.Resolve(NationalSpire.LifeActivity)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerLife.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`Complete(d, a)`；返回值紧邻使用处：`ExpressionStatementSyntax: Complete(d, a);`
- `NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；输入表达式：`CareerMoney.Record(d, a.Title + "无效备赛退款", refund)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Record(d, a.Title + "无效备赛退款", refund);`
- `NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`CareerTraining.IsTraining(a)`；返回值紧邻使用处：`IfStatementSyntax: if (CareerTraining.IsTraining(a))              {                  if (CareerTraining.Multiplayer(d))                  {                      if (a.Status is "进行中" or "已完成" && d.Life.RepairReceipts.Add("training-refund:" + a.Id))                      { int refund = Math.Max(0, a.PaidCost >= 0 ? a.PaidCost : a.Cost); d.Credits += refund; CareerMoney.Record(d, a.Title + "无效备赛退款", refund); a.Result = "原备赛未能影响合作比赛，费用已退还。"; }                      a.Status = "已结束";                  }                  else if (a.Status == "进行中") CareerTraining.Snapshot(d, a, true);              }`
- `NationalSpire.CareerTraining.Multiplayer(NationalSpire.CareerData)`；输入表达式：`CareerTraining.Multiplayer(d)`；返回值紧邻使用处：`IfStatementSyntax: if (CareerTraining.Multiplayer(d))                  {                      if (a.Status is "进行中" or "已完成" && d.Life.RepairReceipts.Add("training-refund:" + a.Id))                      { int refund = Math.Max(0, a.PaidCost >= 0 ? a.PaidCost : a.Cost); d.Credits += refund; CareerMoney.Record(d, a.Title + "无效备赛退款", refund); a.Result = "原备赛未能影响合作比赛，费用已退还。"; }                      a.Status = "已结束";                  }                  else if (a.Status == "进行中") CareerTraining.Snapshot(d, a, true);`
- `NationalSpire.CareerTraining.Snapshot(NationalSpire.CareerData, NationalSpire.LifeActivity, bool)`；输入表达式：`CareerTraining.Snapshot(d, a, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerTraining.Snapshot(d, a, true);`
- `NationalSpire.LifeCatalog.Resolve(NationalSpire.LifeActivity)`；输入表达式：`LifeCatalog.Resolve(a)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = LifeCatalog.Resolve(a)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`d.Life.RepairReceipts.Add("activity-repair:" + a.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: plan != null && d.Life.RepairReceipts.Add("activity-repair:" + a.Id)`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`d.Life.RepairReceipts.Add("training-refund:" + a.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: a.Status is "进行中" or "已完成" && d.Life.RepairReceipts.Add("training-refund:" + a.Id)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Life.RepairNotices.Add(a.Title + "的漏发收益已补齐。")`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Life.RepairNotices.Add(a.Title + "的漏发收益已补齐。");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Life.RepairNotices.Add(a.Title + "缺少原始活动定义，保留记录等待核实。")`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Life.RepairNotices.Add(a.Title + "缺少原始活动定义，保留记录等待核实。");`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, a.PaidCost >= 0 ? a.PaidCost : a.Cost)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(0, a.PaidCost >= 0 ? a.PaidCost : a.Cost)`

**赋值（含属性/字段和局部值）：**

- `a.Result` = `"原备赛未能影响合作比赛，费用已退还。"`
- `a.Status` = `"已结束"`
- `a.Variant` = `plan.Key`
- `d.Credits` += `refund`

<a id="symbol-0780f4d6b962"></a>

## `NationalSpire.CareerLife.Hash(NationalSpire.CareerData, string) — private static int Hash(CareerData d, string key)`

来源：源码第 86 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Accept(NationalSpire.CareerData, string, string)`](CareerLife.cs.md#symbol-cce5ea9d3250)；[`NationalSpire.CareerLife.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerLife.cs.md#symbol-e559cea1bbf6)；[`NationalSpire.CareerLife.Ensure(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-eb417e39aebf)；[`NationalSpire.CareerLife.Offer(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-06bdec919490)；[`NationalSpire.CareerLife.SkipRound(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-efe3762d8665)；[`NationalSpire.CareerLife.Thanks(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerLife.cs.md#symbol-f6585e7dbdc5)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(d.WorldId + ":life:" + key)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => CareerEngine.StableHash(d.WorldId + ":life:" + key)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-62ec6434f115"></a>

## `NationalSpire.CareerLife.Advance(NationalSpire.CareerData) — public static void Advance(CareerData d)`

来源：源码第 87 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.MoveToNextDay(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-3836a38a7da9)；[`NationalSpire.Coop.CoopRules.AdvanceMembers(NationalSpire.Coop.CoopWorld)`](Coop/CoopRules.cs.md#symbol-bc24477e89ba)

**调用：** [`NationalSpire.CareerLife.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerLife.cs.md#symbol-e559cea1bbf6)；[`NationalSpire.CareerLife.Ensure(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-eb417e39aebf)；[`NationalSpire.CareerLife.Offer(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-06bdec919490)；[`NationalSpire.CareerLife.Trim(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-e7a1033e94a2)；[`NationalSpire.CareerRelics.Advance(NationalSpire.CareerData)`](CareerRelics.cs.md#symbol-2d82195832e2)；[`NationalSpire.CareerTraining.Advance(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerTraining.cs.md#symbol-b1b089f2949d)；[`NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`](CareerTraining.cs.md#symbol-98adbc7a75dc)；[`NationalSpire.ClubCoaching.Advance(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-52a54f3b0a18)；[`NationalSpire.ClubPrograms.Advance(NationalSpire.CareerData, NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-b01f1c3252f6)；[`NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-f251644672be)；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLife.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.CareerLife.Ensure(NationalSpire.CareerData)`；`NationalSpire.CareerLife.Offer(NationalSpire.CareerData)`；`NationalSpire.CareerLife.Trim(NationalSpire.CareerData)`；`NationalSpire.CareerLifeState.Activities`；`NationalSpire.CareerLifeState.NextOfferDay`；`NationalSpire.CareerRelics.Advance(NationalSpire.CareerData)`；`NationalSpire.CareerTraining.Advance(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`；`NationalSpire.ClubCoaching.Advance(NationalSpire.CareerData)`；`NationalSpire.ClubPrograms.Advance(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`；`NationalSpire.EsportsCareer.EcosystemVersion`；`NationalSpire.LifeActivity.Duration`；`NationalSpire.LifeActivity.ExpiresDay`；`NationalSpire.LifeActivity.FinishDay`；`NationalSpire.LifeActivity.Kind`；`NationalSpire.LifeActivity.ProgressDay`；`NationalSpire.LifeActivity.Result`；`NationalSpire.LifeActivity.StartedDay`；`NationalSpire.LifeActivity.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerLife.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`Complete(d, item)`；返回值紧邻使用处：`ExpressionStatementSyntax: Complete(d, item);`
- `NationalSpire.CareerLife.Ensure(NationalSpire.CareerData)`；输入表达式：`Ensure(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: Ensure(d);`
- `NationalSpire.CareerLife.Offer(NationalSpire.CareerData)`；输入表达式：`Offer(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: Offer(d);`
- `NationalSpire.CareerLife.Trim(NationalSpire.CareerData)`；输入表达式：`Trim(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: Trim(d);`
- `NationalSpire.CareerRelics.Advance(NationalSpire.CareerData)`；输入表达式：`CareerRelics.Advance(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerRelics.Advance(d);`
- `NationalSpire.CareerTraining.Advance(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`CareerTraining.Advance(d, item)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerTraining.Advance(d, item);`
- `NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`CareerTraining.IsTraining(item)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CareerTraining.IsTraining(item)`
- `NationalSpire.ClubCoaching.Advance(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.Advance(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubCoaching.Advance(d);`
- `NationalSpire.ClubPrograms.Advance(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`ClubPrograms.Advance(d, item)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubPrograms.Advance(d, item);`
- `NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`ClubPrograms.IsTraining(item)`；返回值紧邻使用处：`IfStatementSyntax: if (ClubPrograms.IsTraining(item)) ClubPrograms.Advance(d, item);              else CareerTraining.Advance(d, item);`
- `NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`ClubPrograms.IsTraining(item)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ClubPrograms.IsTraining(item)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Life.Activities.Where(a => a.Status == "进行中").ToList()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var item in d.Life.Activities.Where(a => a.Status == "进行中").ToList())          {              if (ClubPrograms.IsTraining(item)) ClubPrograms.Advance(d, item);              else CareerTraining.Advance(d, item);              if (item.FinishDay <= d.Day) Complete(d, item);              else if (!CareerTraining.IsTraining(item) && !ClubPrograms.IsTraining(item) && item.Duration >= 7 && item.ProgressDay == 0 && d.Day >= item.StartedDay + item.Duration / 2)              {                  item.ProgressDay = d.Day;                  item.Result = item.Kind switch {                      "青训" => "阶段安排已过半，对方已确认下一阶段的时间。",                      "商业" => "制作方已确认样品，正在准备交付。",                      "事业" => "筹备进入后半程，负责人员已确认完成时间。",                      "内容" => "素材已经整理，正在完成剪辑与校对。",                      _ => "场地与参与人员已经确认，准备工作按计划推进。" };              }          }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Activities.Where(a => a.Status == "进行中")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Activities.Where(a => a.Status == "进行中").ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Activities.Where(a => a.Status == "可安排" && a.ExpiresDay < d.Day)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var item in d.Life.Activities.Where(a => a.Status == "可安排" && a.ExpiresDay < d.Day)) item.Status = "已结束";`

**赋值（含属性/字段和局部值）：**

- `item.ProgressDay` = `d.Day`
- `item.Result` = `item.Kind switch {                      "青训" => "阶段安排已过半，对方已确认下一阶段的时间。",                      "商业" => "制作方已确认样品，正在准备交付。",                      "事业" => "筹备进入后半程，负责人员已确认完成时间。",                      "内容" => "素材已经整理，正在完成剪辑与校对。",                      _ => "场地与参与人员已经确认，准备工作按计划推进。" }`
- `item.Status` = `"已结束"`

<a id="symbol-06bdec919490"></a>

## `NationalSpire.CareerLife.Offer(NationalSpire.CareerData) — public static void Offer(CareerData d)`

来源：源码第 113 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Advance(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-62ec6434f115)

**调用：** [`NationalSpire.CareerLife.Hash(NationalSpire.CareerData, string)`](CareerLife.cs.md#symbol-0780f4d6b962)；[`NationalSpire.CareerRelics.Has(NationalSpire.CareerData, string)`](CareerRelics.cs.md#symbol-7b703fddee2f)；[`NationalSpire.CareerTraining.ActiveRoster(NationalSpire.CareerData, string)`](CareerTraining.cs.md#symbol-4b84e446c2e4)；[`NationalSpire.CareerTraining.Multiplayer(NationalSpire.CareerData)`](CareerTraining.cs.md#symbol-69fbc353877e)；[`NationalSpire.CareerTraining.Targets(NationalSpire.CareerData)`](CareerTraining.cs.md#symbol-89a5b7a8727b)；[`NationalSpire.ClubPrograms.CanOffer(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-359a3dbeb02e)；[`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3ba0e806ba5c)；[`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`](EsportsWorld.cs.md#symbol-c10dfd5a2e0e)；[`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-871ad0e2a2c9)；[`Text(string)`](CareerLife.cs.md#symbol-44b2b85f41d7)；`NationalSpire.LifeActivity.LifeActivity()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.HashSet<T>.HashSet()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Math.Min(int, int)`；`System.Random.Next()`；`System.Random.Next(int, int)`；`System.Random.Next(int)`；`System.Random.Random(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerClub.Country`；`NationalSpire.CareerClub.Id`；`NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.Results`；`NationalSpire.CareerDuel.PersonId`；`NationalSpire.CareerLife.Hash(NationalSpire.CareerData, string)`；`NationalSpire.CareerLifeState.Activities`；`NationalSpire.CareerLifeState.Figurines`；`NationalSpire.CareerLifeState.LastDecisionDay`；`NationalSpire.CareerLifeState.NextOfferDay`；`NationalSpire.CareerLifeState.NextProjectDay`；`NationalSpire.CareerLifeState.OfferRound`；`NationalSpire.CareerLifeState.Relationships`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerRelics.Has(NationalSpire.CareerData, string)`；`NationalSpire.CareerTraining.ActiveRoster(NationalSpire.CareerData, string)`；`NationalSpire.CareerTraining.Multiplayer(NationalSpire.CareerData)`；`NationalSpire.CareerTraining.Targets(NationalSpire.CareerData)`；`NationalSpire.ClubPrograms.CanOffer(NationalSpire.CareerData, string)`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.Clubs`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsCareer.Duels`；`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；`NationalSpire.FigurineState.Charge`；`NationalSpire.LifeActivity.ClubId`；`NationalSpire.LifeActivity.Cost`；`NationalSpire.LifeActivity.Detail`；`NationalSpire.LifeActivity.Duration`；`NationalSpire.LifeActivity.ExpiresDay`；`NationalSpire.LifeActivity.Id`；`NationalSpire.LifeActivity.Kind`；`NationalSpire.LifeActivity.LongProject`；`NationalSpire.LifeActivity.OfferedDay`；`NationalSpire.LifeActivity.PersonId`；`NationalSpire.LifeActivity.Public`；`NationalSpire.LifeActivity.Round`；`NationalSpire.LifeActivity.Setting`；`NationalSpire.LifeActivity.Status`；`NationalSpire.LifeActivity.TermsVersion`；`NationalSpire.LifeActivity.Title`；`NationalSpire.LifeActivity.Variant`；`NationalSpire.LifeCatalog.Plan.Cost`；`NationalSpire.LifeCatalog.Plan.Days`；`NationalSpire.LifeCatalog.Plan.Key`；`NationalSpire.LifeCatalog.Plan.Kind`；`NationalSpire.LifeCatalog.Plan.Long`；`NationalSpire.LifeCatalog.Plan.Public`；`NationalSpire.LifeCatalog.Plan.Purpose`；`NationalSpire.LifeCatalog.Plan.Title`；`NationalSpire.LifeCatalog.Plans`；`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；`Text(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerLife.Hash(NationalSpire.CareerData, string)`；输入表达式：`Hash(d, "offers:" + d.Day)`；返回值紧邻使用处：`ArgumentSyntax: Hash(d, "offers:" + d.Day)`
- `NationalSpire.CareerLife.Hash(NationalSpire.CareerData, string)`；输入表达式：`Hash(d, plan.Key + p.Id + d.Day)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => Hash(d, plan.Key + p.Id + d.Day)`
- `NationalSpire.CareerRelics.Has(NationalSpire.CareerData, string)`；输入表达式：`CareerRelics.Has(d, "DREAM_CATCHER")`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerRelics.Has(d, "DREAM_CATCHER") && life.Figurines["DREAM_CATCHER"].Charge > 0`
- `NationalSpire.CareerRelics.Has(NationalSpire.CareerData, string)`；输入表达式：`CareerRelics.Has(d, "JUZU_BRACELET")`；返回值紧邻使用处：`IfStatementSyntax: if (CareerRelics.Has(d, "JUZU_BRACELET")) candidates = candidates.OrderBy(p => p.Kind == "生活" ? 0 : p.Kind == "社交" ? 1 : 2).ToList();`
- `NationalSpire.CareerRelics.Has(NationalSpire.CareerData, string)`；输入表达式：`CareerRelics.Has(d, "JUZU_BRACELET")`；返回值紧邻使用处：`IfStatementSyntax: if (CareerRelics.Has(d, "JUZU_BRACELET")) candidates = candidates.OrderBy(p => p.Kind is "生活" or "社交" ? 0 : 1).ToList();`
- `NationalSpire.CareerRelics.Has(NationalSpire.CareerData, string)`；输入表达式：`CareerRelics.Has(d, "TOOLBOX")`；返回值紧邻使用处：`ConditionalExpressionSyntax: CareerRelics.Has(d, "TOOLBOX") ? 6 : 3`
- `NationalSpire.CareerTraining.ActiveRoster(NationalSpire.CareerData, string)`；输入表达式：`CareerTraining.ActiveRoster(d, x.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: x => CareerTraining.ActiveRoster(d, x.Id)`
- `NationalSpire.CareerTraining.Multiplayer(NationalSpire.CareerData)`；输入表达式：`CareerTraining.Multiplayer(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CareerTraining.Multiplayer(d)`
- `NationalSpire.CareerTraining.Targets(NationalSpire.CareerData)`；输入表达式：`CareerTraining.Targets(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CareerTraining.Targets(d).Any`
- `NationalSpire.CareerTraining.Targets(NationalSpire.CareerData)`；输入表达式：`CareerTraining.Targets(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CareerTraining.Targets(d).First`
- `NationalSpire.ClubPrograms.CanOffer(NationalSpire.CareerData, string)`；输入表达式：`ClubPrograms.CanOffer(d, p.Title)`；返回值紧邻使用处：`BinaryExpressionSyntax: OwnedClubs.CanOperate(d) && ClubPrograms.CanOffer(d, p.Title)`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(d, d.Esports.ClubId)`；返回值紧邻使用处：`BinaryExpressionSyntax: EsportsWorld.Club(d, d.Esports.ClubId) ?? EsportsWorld.Club(d, person.ClubId)                  ?? d.Esports.Clubs.First(c => c.Country == d.Esports.Country)`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(d, person.ClubId)`；返回值紧邻使用处：`BinaryExpressionSyntax: EsportsWorld.Club(d, person.ClubId)                  ?? d.Esports.Clubs.First(c => c.Country == d.Esports.Country)`
- `NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；输入表达式：`EsportsWorld.IsProfessional(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.ClubId == d.Esports.ClubId && EsportsWorld.IsProfessional(p)`
- `NationalSpire.LifeActivity.LifeActivity()`；输入表达式：`new LifeActivity { Round = round, Id = "life-" + d.Day + "-" + plan.Key, Kind = plan.Kind, Variant = plan.Key,                  Title = plan.Title, Detail = Text(plan.Purpose), PersonId = person.Id, ClubId = club.Id, Setting = setting,                  Cost = plan.Cost * scale, OfferedDay = d.Day, ExpiresDay = life.NextOfferDay - 1,                  Duration = plan.Days, Public = plan.Public, LongProject = plan.Long, TermsVersion = 3 }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new LifeActivity { Round = round, Id = "life-" + d.Day + "-" + plan.Key, Kind = plan.Kind, Variant = plan.Key,                  Title = plan.Title, Detail = Text(plan.Purpose), PersonId = person.Id, ClubId = club.Id, Setting = setting,                  Cost = plan.Cost * scale, OfferedDay = d.Day, ExpiresDay = life.NextOfferDay - 1,                  Duration = plan.Days, Public = plan.Public, LongProject = plan.Long, TermsVersion = 3 }`
- `NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.CanOperate(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: OwnedClubs.CanOperate(d) && ClubPrograms.CanOffer(d, p.Title)`
- `NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.CanOperate(d)`；返回值紧邻使用处：`IfStatementSyntax: if (OwnedClubs.CanOperate(d)) candidates = candidates.OrderBy(p => p.Kind == "经营" ? 0 : 1).ToList();`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`life.Relationships.ContainsKey(p.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: life.Relationships.ContainsKey(p.Id) || d.Esports.Duels.Any(x => x.PersonId == p.Id)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`life.Relationships.ContainsKey(person.Id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: life.Relationships.ContainsKey(person.Id) ? "你们此前已经有过来往" : d.Esports.Duels.Any(x => x.PersonId == person.Id) ? "你们曾在赛场交手" : "这次可以认识一位圈内的新朋友"`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`kinds.Add(plan.Kind)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !kinds.Add(plan.Kind)`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`used.Contains(p.Key)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !used.Contains(p.Key)`
- `System.Collections.Generic.HashSet<T>.HashSet()`；输入表达式：`new HashSet<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new HashSet<string>()`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`CareerTraining.Targets(d).Any(x => CareerTraining.ActiveRoster(d, x.Id))`；返回值紧邻使用处：`BinaryExpressionSyntax: !CareerTraining.Multiplayer(d) && CareerTraining.Targets(d).Any(x => CareerTraining.ActiveRoster(d, x.Id))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Duels.Any(x => x.PersonId == p.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: life.Relationships.ContainsKey(p.Id) || d.Esports.Duels.Any(x => x.PersonId == p.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Duels.Any(x => x.PersonId == person.Id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: d.Esports.Duels.Any(x => x.PersonId == person.Id) ? "你们曾在赛场交手" : "这次可以认识一位圈内的新朋友"`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`life.Activities.Any(a => a.Kind == "备赛" && a.Status == "进行中")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !life.Activities.Any(a => a.Kind == "备赛" && a.Status == "进行中")`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`life.Activities.Any(a => a.LongProject && a.Status == "进行中")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !life.Activities.Any(a => a.LongProject && a.Status == "进行中")`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`life.Activities.Any(a => a.Status == "可安排" && a.ExpiresDay >= d.Day)`；返回值紧邻使用处：`BinaryExpressionSyntax: life.Activities.Any(a => a.Status == "可安排" && a.ExpiresDay >= d.Day) || life.LastDecisionDay > 0 && d.Day < life.NextOfferDay`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>()`；输入表达式：`CareerTraining.Targets(d).First()`；返回值紧邻使用处：`AssignmentExpressionSyntax: person = CareerTraining.Targets(d).First()`
- `System.Collections.Generic.IEnumerable<TSource>.First<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Clubs.First(c => c.Country == d.Esports.Country)`；返回值紧邻使用处：`BinaryExpressionSyntax: EsportsWorld.Club(d, person.ClubId)                  ?? d.Esports.Clubs.First(c => c.Country == d.Esports.Country)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`candidates.OrderBy(p => p.Kind == "备赛" ? 0 : 1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates.OrderBy(p => p.Kind == "备赛" ? 0 : 1).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`candidates.OrderBy(p => p.Kind == "经营" ? 0 : 1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates.OrderBy(p => p.Kind == "经营" ? 0 : 1).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`candidates.OrderBy(p => p.Kind == "内容" ? 0 : 1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates.OrderBy(p => p.Kind == "内容" ? 0 : 1).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`candidates.OrderBy(p => p.Kind == "生活" ? 0 : p.Kind == "社交" ? 1 : 2)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates.OrderBy(p => p.Kind == "生活" ? 0 : p.Kind == "社交" ? 1 : 2).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`candidates.OrderBy(p => p.Kind is "生活" or "社交" ? 0 : 1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: candidates.OrderBy(p => p.Kind is "生活" or "社交" ? 0 : 1).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`LifeCatalog.Plans.Where(p => !used.Contains(p.Key) && (!p.Long || project)              && (p.Kind is not ("俱乐部" or "备赛" or "培养") || d.Esports.ClubId.Length > 0)              && (p.Kind is not ("备赛" or "培养") || !CareerTraining.Multiplayer(d) && CareerTraining.Targets(d).Any(x => CareerTraining.ActiveRoster(d, x.Id)))              && (p.Kind != "经营" || OwnedClubs.CanOperate(d) && ClubPrograms.CanOffer(d, p.Title))              && (p.Kind != "内容" || d.Results.Count > 0)).OrderBy(p => d.Credits < 300 && p.Cost <= d.Credits ? 0 : 1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LifeCatalog.Plans.Where(p => !used.Contains(p.Key) && (!p.Long || project)              && (p.Kind is not ("俱乐部" or "备赛" or "培养") || d.Esports.ClubId.Length > 0)              && (p.Kind is not ("备赛" or "培养") || !CareerTraining.Multiplayer(d) && CareerTraining.Targets(d).Any(x => CareerTraining.ActiveRoster(d, x.Id)))              && (p.Kind != "经营" || OwnedClubs.CanOperate(d) && ClubPrograms.CanOffer(d, p.Title))              && (p.Kind != "内容" || d.Results.Count > 0)).OrderBy(p => d.Credits < 300 && p.Cost <= d.Credits ? 0 : 1).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.People.Where(p => plan.Kind is "备赛" or "培养"                  ? p.ClubId == d.Esports.ClubId && EsportsWorld.IsProfessional(p)                  : p.Country == d.Esports.Country && (plan.Kind == "青训" ? p.Role == "青训选手" : p.Role is "职业选手" or "普通玩家" or "主播" or "解说员" or "退役选手"))                  .OrderByDescending(p => life.Relationships.ContainsKey(p.Id) || d.Esports.Duels.Any(x => x.PersonId == p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => plan.Kind is "备赛" or "培养"                  ? p.ClubId == d.Esports.ClubId && EsportsWorld.IsProfessional(p)                  : p.Country == d.Esports.Country && (plan.Kind == "青训" ? p.Role == "青训选手" : p.Role is "职业选手" or "普通玩家" or "主播" or "解说员" or "退役选手"))                  .OrderByDescending(p => life.Relationships.ContainsKey(p.Id) || d.Esports.Duels.Any(x => x.PersonId == p.Id))                  .ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`life.Activities.Where(a => a.OfferedDay > d.Day - 28).Select(a => a.Variant)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: life.Activities.Where(a => a.OfferedDay > d.Day - 28).Select(a => a.Variant).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`d.People.Where(p => plan.Kind is "备赛" or "培养"                  ? p.ClubId == d.Esports.ClubId && EsportsWorld.IsProfessional(p)                  : p.Country == d.Esports.Country && (plan.Kind == "青训" ? p.Role == "青训选手" : p.Role is "职业选手" or "普通玩家" or "主播" or "解说员" or "退役选手"))                  .OrderByDescending(p => life.Relationships.ContainsKey(p.Id) || d.Esports.Duels.Any(x => x.PersonId == p.Id))                  .ThenBy(p => Hash(d, plan.Key + p.Id + d.Day)).Take(30)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => plan.Kind is "备赛" or "培养"                  ? p.ClubId == d.Esports.ClubId && EsportsWorld.IsProfessional(p)                  : p.Country == d.Esports.Country && (plan.Kind == "青训" ? p.Role == "青训选手" : p.Role is "职业选手" or "普通玩家" or "主播" or "解说员" or "退役选手"))                  .OrderByDescending(p => life.Relationships.ContainsKey(p.Id) || d.Esports.Duels.Any(x => x.PersonId == p.Id))                  .ThenBy(p => Hash(d, plan.Key + p.Id + d.Day)).Take(30).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`life.Activities.Where(a => a.OfferedDay > d.Day - 28).Select(a => a.Variant).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = life.Activities.Where(a => a.OfferedDay > d.Day - 28).Select(a => a.Variant).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`candidates.OrderBy(p => p.Kind == "备赛" ? 0 : 1).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: candidates = candidates.OrderBy(p => p.Kind == "备赛" ? 0 : 1).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`candidates.OrderBy(p => p.Kind == "经营" ? 0 : 1).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: candidates = candidates.OrderBy(p => p.Kind == "经营" ? 0 : 1).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`candidates.OrderBy(p => p.Kind == "内容" ? 0 : 1).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: candidates = candidates.OrderBy(p => p.Kind == "内容" ? 0 : 1).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`candidates.OrderBy(p => p.Kind == "生活" ? 0 : p.Kind == "社交" ? 1 : 2).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: candidates = candidates.OrderBy(p => p.Kind == "生活" ? 0 : p.Kind == "社交" ? 1 : 2).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`candidates.OrderBy(p => p.Kind is "生活" or "社交" ? 0 : 1).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: candidates = candidates.OrderBy(p => p.Kind is "生活" or "社交" ? 0 : 1).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.People.Where(p => plan.Kind is "备赛" or "培养"                  ? p.ClubId == d.Esports.ClubId && EsportsWorld.IsProfessional(p)                  : p.Country == d.Esports.Country && (plan.Kind == "青训" ? p.Role == "青训选手" : p.Role is "职业选手" or "普通玩家" or "主播" or "解说员" or "退役选手"))                  .OrderByDescending(p => life.Relationships.ContainsKey(p.Id) || d.Esports.Duels.Any(x => x.PersonId == p.Id))                  .ThenBy(p => Hash(d, plan.Key + p.Id + d.Day)).Take(30).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.People.Where(p => plan.Kind is "备赛" or "培养"                  ? p.ClubId == d.Esports.ClubId && EsportsWorld.IsProfessional(p)                  : p.Country == d.Esports.Country && (plan.Kind == "青训" ? p.Role == "青训选手" : p.Role is "职业选手" or "普通玩家" or "主播" or "解说员" or "退役选手"))                  .OrderByDescending(p => life.Relationships.ContainsKey(p.Id) || d.Esports.Duels.Any(x => x.PersonId == p.Id))                  .ThenBy(p => Hash(d, plan.Key + p.Id + d.Day)).Take(30).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`LifeCatalog.Plans.Where(p => !used.Contains(p.Key) && (!p.Long || project)              && (p.Kind is not ("俱乐部" or "备赛" or "培养") || d.Esports.ClubId.Length > 0)              && (p.Kind is not ("备赛" or "培养") || !CareerTraining.Multiplayer(d) && CareerTraining.Targets(d).Any(x => CareerTraining.ActiveRoster(d, x.Id)))              && (p.Kind != "经营" || OwnedClubs.CanOperate(d) && ClubPrograms.CanOffer(d, p.Title))              && (p.Kind != "内容" || d.Results.Count > 0)).OrderBy(p => d.Credits < 300 && p.Cost <= d.Credits ? 0 : 1).ThenBy(_ => rng.Next()).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = LifeCatalog.Plans.Where(p => !used.Contains(p.Key) && (!p.Long || project)              && (p.Kind is not ("俱乐部" or "备赛" or "培养") || d.Esports.ClubId.Length > 0)              && (p.Kind is not ("备赛" or "培养") || !CareerTraining.Multiplayer(d) && CareerTraining.Targets(d).Any(x => CareerTraining.ActiveRoster(d, x.Id)))              && (p.Kind != "经营" || OwnedClubs.CanOperate(d) && ClubPrograms.CanOffer(d, p.Title))              && (p.Kind != "内容" || d.Results.Count > 0)).OrderBy(p => d.Credits < 300 && p.Cost <= d.Credits ? 0 : 1).ThenBy(_ => rng.Next()).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p => plan.Kind is "备赛" or "培养"                  ? p.ClubId == d.Esports.ClubId && EsportsWorld.IsProfessional(p)                  : p.Country == d.Esports.Country && (plan.Kind == "青训" ? p.Role == "青训选手" : p.Role is "职业选手" or "普通玩家" or "主播" or "解说员" or "退役选手"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => plan.Kind is "备赛" or "培养"                  ? p.ClubId == d.Esports.ClubId && EsportsWorld.IsProfessional(p)                  : p.Country == d.Esports.Country && (plan.Kind == "青训" ? p.Role == "青训选手" : p.Role is "职业选手" or "普通玩家" or "主播" or "解说员" or "退役选手"))                  .OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`life.Activities.Where(a => a.OfferedDay > d.Day - 28)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: life.Activities.Where(a => a.OfferedDay > d.Day - 28).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`LifeCatalog.Plans.Where(p => !used.Contains(p.Key) && (!p.Long || project)              && (p.Kind is not ("俱乐部" or "备赛" or "培养") || d.Esports.ClubId.Length > 0)              && (p.Kind is not ("备赛" or "培养") || !CareerTraining.Multiplayer(d) && CareerTraining.Targets(d).Any(x => CareerTraining.ActiveRoster(d, x.Id)))              && (p.Kind != "经营" || OwnedClubs.CanOperate(d) && ClubPrograms.CanOffer(d, p.Title))              && (p.Kind != "内容" || d.Results.Count > 0))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LifeCatalog.Plans.Where(p => !used.Contains(p.Key) && (!p.Long || project)              && (p.Kind is not ("俱乐部" or "备赛" or "培养") || d.Esports.ClubId.Length > 0)              && (p.Kind is not ("备赛" or "培养") || !CareerTraining.Multiplayer(d) && CareerTraining.Targets(d).Any(x => CareerTraining.ActiveRoster(d, x.Id)))              && (p.Kind != "经营" || OwnedClubs.CanOperate(d) && ClubPrograms.CanOffer(d, p.Title))              && (p.Kind != "内容" || d.Results.Count > 0)).OrderBy`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`life.Activities.Add(item)`；返回值紧邻使用处：`ExpressionStatementSyntax: life.Activities.Add(item);`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.People.Where(p => plan.Kind is "备赛" or "培养"                  ? p.ClubId == d.Esports.ClubId && EsportsWorld.IsProfessional(p)                  : p.Country == d.Esports.Country && (plan.Kind == "青训" ? p.Role == "青训选手" : p.Role is "职业选手" or "普通玩家" or "主播" or "解说员" or "退役选手"))                  .OrderByDescending(p => life.Relationships.ContainsKey(p.Id) || d.Esports.Duels.Any(x => x.PersonId == p.Id))                  .ThenBy(p => Hash(d, plan.Key + p.Id + d.Day))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => plan.Kind is "备赛" or "培养"                  ? p.ClubId == d.Esports.ClubId && EsportsWorld.IsProfessional(p)                  : p.Country == d.Esports.Country && (plan.Kind == "青训" ? p.Role == "青训选手" : p.Role is "职业选手" or "普通玩家" or "主播" or "解说员" or "退役选手"))                  .OrderByDescending(p => life.Relationships.ContainsKey(p.Id) || d.Esports.Duels.Any(x => x.PersonId == p.Id))                  .ThenBy(p => Hash(d, plan.Key + p.Id + d.Day)).Take`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`LifeCatalog.Plans.Where(p => !used.Contains(p.Key) && (!p.Long || project)              && (p.Kind is not ("俱乐部" or "备赛" or "培养") || d.Esports.ClubId.Length > 0)              && (p.Kind is not ("备赛" or "培养") || !CareerTraining.Multiplayer(d) && CareerTraining.Targets(d).Any(x => CareerTraining.ActiveRoster(d, x.Id)))              && (p.Kind != "经营" || OwnedClubs.CanOperate(d) && ClubPrograms.CanOffer(d, p.Title))              && (p.Kind != "内容" || d.Results.Count > 0)).OrderBy(p => d.Credits < 300 && p.Cost <= d.Credits ? 0 : 1).ThenBy(_ => rng.Next())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: LifeCatalog.Plans.Where(p => !used.Contains(p.Key) && (!p.Long || project)              && (p.Kind is not ("俱乐部" or "备赛" or "培养") || d.Esports.ClubId.Length > 0)              && (p.Kind is not ("备赛" or "培养") || !CareerTraining.Multiplayer(d) && CareerTraining.Targets(d).Any(x => CareerTraining.ActiveRoster(d, x.Id)))              && (p.Kind != "经营" || OwnedClubs.CanOperate(d) && ClubPrograms.CanOffer(d, p.Title))              && (p.Kind != "内容" || d.Results.Count > 0)).OrderBy(p => d.Credits < 300 && p.Cost <= d.Credits ? 0 : 1).ThenBy(_ => rng.Next()).ToList`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(people.Count, 12)`；返回值紧邻使用处：`ArgumentSyntax: Math.Min(people.Count, 12)`
- `System.Random.Next()`；输入表达式：`rng.Next()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => rng.Next()`
- `System.Random.Next(int, int)`；输入表达式：`rng.Next(1, 4)`；返回值紧邻使用处：`ConditionalExpressionSyntax: plan.Kind is "生活" or "社交" or "备赛" or "培养" or "经营" ? 1 : rng.Next(1, 4)`
- `System.Random.Next(int, int)`；输入表达式：`rng.Next(21, 36)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Day + rng.Next(21, 36)`
- `System.Random.Next(int, int)`；输入表达式：`rng.Next(7, 13)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Day + rng.Next(7, 13)`
- `System.Random.Next(int)`；输入表达式：`rng.Next(5)`；返回值紧邻使用处：`ArgumentSyntax: rng.Next(5)`
- `System.Random.Next(int)`；输入表达式：`rng.Next(Math.Min(people.Count, 12))`；返回值紧邻使用处：`ArgumentSyntax: rng.Next(Math.Min(people.Count, 12))`
- `System.Random.Random(int)`；输入表达式：`new Random(Hash(d, "offers:" + d.Day))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Random(Hash(d, "offers:" + d.Day))`
- `Text(string)`；输入表达式：`Text(plan.Purpose)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Detail = Text(plan.Purpose)`

**赋值（含属性/字段和局部值）：**

- `candidates` = `candidates.OrderBy(p => p.Kind == "备赛" ? 0 : 1).ToList()`
- `candidates` = `candidates.OrderBy(p => p.Kind == "经营" ? 0 : 1).ToList()`
- `candidates` = `candidates.OrderBy(p => p.Kind == "内容" ? 0 : 1).ToList()`
- `candidates` = `candidates.OrderBy(p => p.Kind == "生活" ? 0 : p.Kind == "社交" ? 1 : 2).ToList()`
- `candidates` = `candidates.OrderBy(p => p.Kind is "生活" or "社交" ? 0 : 1).ToList()`
- `ClubId` = `club.Id`
- `Cost` = `plan.Cost * scale`
- `count` += `2`
- `Detail` = `Text(plan.Purpose)`
- `dream` = `false`
- `Duration` = `plan.Days`
- `ExpiresDay` = `life.NextOfferDay - 1`
- `Id` = `"life-" + d.Day + "-" + plan.Key`
- `item.Detail` += `"。" + (life.Relationships.ContainsKey(person.Id) ? "你们此前已经有过来往" : d.Esports.Duels.Any(x => x.PersonId == person.Id) ? "你们曾在赛场交手" : "这次可以认识一位圈内的新朋友")`
- `item.Detail` += `"。" + (plan.Kind switch {                  "青训" => scale == 2 ? "采用更完整的配套服务，覆盖本阶段的准备工作" : "承担本阶段的完整配套费用，方便对方专心参加",                  "内容" => scale == 2 ? "增加现场记录与后期整理的预算" : "安排专人完成拍摄、剪辑与资料整理",                  "社区" => scale == 2 ? "扩大开放名额，补充现场物料" : "扩大活动覆盖范围，配齐场地、物料和后勤人员",                  "俱乐部" => scale == 2 ? "覆盖职业队与青训组的相关需求" : "按全队规模安排，配齐相关设备与后勤支持",                  "商业" => scale == 2 ? "采用中等规模的制作与场地预算" : "按较大规模筹备，增加制作与推广预算",                  _ => scale == 2 ? "扩大项目规模，补充配套设施" : "按完整规模筹备，配齐场地、设施与负责人员" })`
- `item.Detail` += `$"。项目结束后结算一次，预计收回投入的84%—156%，金额随关注度和销售情况变化"`
- `Kind` = `plan.Kind`
- `life.NextOfferDay` = `d.Day + rng.Next(7, 13)`
- `life.NextProjectDay` = `d.Day + rng.Next(21, 36)`
- `LongProject` = `plan.Long`
- `OfferedDay` = `d.Day`
- `person` = `CareerTraining.Targets(d).First()`
- `PersonId` = `person.Id`
- `project` = `false`
- `Public` = `plan.Public`
- `Round` = `round`
- `Setting` = `setting`
- `TermsVersion` = `3`
- `Title` = `plan.Title`
- `Variant` = `plan.Key`

<a id="symbol-44b2b85f41d7"></a>

## `Text(string) — string Text(string s)`

来源：源码第 153 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Offer(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-06bdec919490)

**调用：** `string.Replace(string, string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerClub.Name`；`NationalSpire.CareerPerson.PublicName`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Replace(string, string?)`；输入表达式：`s.Replace("{人}", person.PublicName).Replace("{队}", club.Name).Replace("{地}", setting)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => s.Replace("{人}", person.PublicName).Replace("{队}", club.Name).Replace("{地}", setting)`
- `string.Replace(string, string?)`；输入表达式：`s.Replace("{人}", person.PublicName).Replace("{队}", club.Name)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: s.Replace("{人}", person.PublicName).Replace("{队}", club.Name).Replace`
- `string.Replace(string, string?)`；输入表达式：`s.Replace("{人}", person.PublicName)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: s.Replace("{人}", person.PublicName).Replace`

**赋值（含属性/字段和局部值）：**


<a id="symbol-cce5ea9d3250"></a>

## `NationalSpire.CareerLife.Accept(NationalSpire.CareerData, string, string) — public static string? Accept(CareerData d, string id, string targetId = "")`

来源：源码第 172 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ActivityCard(NationalSpire.CareerData, NationalSpire.LifeActivity)`](LifeScreen.cs.md#symbol-5b3e0aaad277)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`](CareerLife.cs.md#symbol-0ea81cb3e558)；[`NationalSpire.CareerLife.Hash(NationalSpire.CareerData, string)`](CareerLife.cs.md#symbol-0780f4d6b962)；[`NationalSpire.CareerLife.Thanks(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerLife.cs.md#symbol-f6585e7dbdc5)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`](LifeData.cs.md#symbol-54a09649188b)；[`NationalSpire.CareerRelics.Accept(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-c4d68b813d74)；[`NationalSpire.CareerRelics.Cost(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-648cf5a95449)；[`NationalSpire.CareerRelics.Duration(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-5a1db0b8215e)；[`NationalSpire.CareerRelics.Spend(NationalSpire.CareerData)`](CareerRelics.cs.md#symbol-9133387726a4)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.CareerTraining.ActiveRoster(NationalSpire.CareerData, string)`](CareerTraining.cs.md#symbol-4b84e446c2e4)；[`NationalSpire.CareerTraining.GrowthAvailable(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerTraining.cs.md#symbol-3e4c518bdd2a)；[`NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`](CareerTraining.cs.md#symbol-98adbc7a75dc)；[`NationalSpire.CareerTraining.Kind(string)`](CareerTraining.cs.md#symbol-f1d9371f3455)；[`NationalSpire.CareerTraining.Multiplayer(NationalSpire.CareerData)`](CareerTraining.cs.md#symbol-69fbc353877e)；[`NationalSpire.CareerTraining.Snapshot(NationalSpire.CareerData, NationalSpire.LifeActivity, bool)`](CareerTraining.cs.md#symbol-feb4623577e9)；[`NationalSpire.CareerTraining.Targets(NationalSpire.CareerData)`](CareerTraining.cs.md#symbol-89a5b7a8727b)；[`NationalSpire.ClubPrograms.Error(NationalSpire.CareerData, NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-160ff8c6cde3)；[`NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-f251644672be)；[`NationalSpire.ClubPrograms.Snapshot(NationalSpire.CareerData, NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-48edcdfd89d0)；[`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-871ad0e2a2c9)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；`NationalSpire.CareerLife.Hash(NationalSpire.CareerData, string)`；`NationalSpire.CareerLife.Thanks(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.CareerLifeState.Activities`；`NationalSpire.CareerLifeState.LastDecisionDay`；`NationalSpire.CareerLifeState.NextOfferDay`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerRelics.Accept(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.CareerRelics.Cost(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.CareerRelics.Duration(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.CareerRelics.Spend(NationalSpire.CareerData)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.CareerTraining.ActiveRoster(NationalSpire.CareerData, string)`；`NationalSpire.CareerTraining.GrowthAvailable(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`；`NationalSpire.CareerTraining.Kind(string)`；`NationalSpire.CareerTraining.Multiplayer(NationalSpire.CareerData)`；`NationalSpire.CareerTraining.Snapshot(NationalSpire.CareerData, NationalSpire.LifeActivity, bool)`；`NationalSpire.CareerTraining.Targets(NationalSpire.CareerData)`；`NationalSpire.ClubPrograms.Error(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`；`NationalSpire.ClubPrograms.Snapshot(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.LifeActivity.ClubId`；`NationalSpire.LifeActivity.Cost`；`NationalSpire.LifeActivity.Detail`；`NationalSpire.LifeActivity.Duration`；`NationalSpire.LifeActivity.ExpiresDay`；`NationalSpire.LifeActivity.FinishDay`；`NationalSpire.LifeActivity.Id`；`NationalSpire.LifeActivity.Kind`；`NationalSpire.LifeActivity.LongProject`；`NationalSpire.LifeActivity.PaidCost`；`NationalSpire.LifeActivity.PersonId`；`NationalSpire.LifeActivity.Public`；`NationalSpire.LifeActivity.Result`；`NationalSpire.LifeActivity.Round`；`NationalSpire.LifeActivity.StartedDay`；`NationalSpire.LifeActivity.Status`；`NationalSpire.LifeActivity.TermsVersion`；`NationalSpire.LifeActivity.Title`；`NationalSpire.LifeActivity.TrainingEnd`；`NationalSpire.LifeActivity.TrainingStart`；`NationalSpire.LifeActivity.TrainingTargets`；`NationalSpire.LifeActivity.WeeklyGrowthPoints`；`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.Name(d)}`
- `NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；输入表达式：`AddEvent(d, item.Id + ":start", item.Kind, item.Title + "已安排",              $"{CareerEngine.Name(d)}安排了{item.Title}，投入{CareerMoney.Format(cost)}。{item.Detail}。计划第{item.FinishDay}天完成。", ["player", item.PersonId], item.LongProject)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddEvent(d, item.Id + ":start", item.Kind, item.Title + "已安排",              $"{CareerEngine.Name(d)}安排了{item.Title}，投入{CareerMoney.Format(cost)}。{item.Detail}。计划第{item.FinishDay}天完成。", ["player", item.PersonId], item.LongProject);`
- `NationalSpire.CareerLife.Hash(NationalSpire.CareerData, string)`；输入表达式：`Hash(d, "decision:" + item.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: Hash(d, "decision:" + item.Id) % 6`
- `NationalSpire.CareerLife.Thanks(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`Thanks(d, item)`；返回值紧邻使用处：`BinaryExpressionSyntax: " " + Thanks(d, item)`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(cost)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(cost)}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(item.Cost - cost)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(item.Cost - cost)}`
- `NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；输入表达式：`CareerMoney.Record(d, item.Title, -cost)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Record(d, item.Title, -cost);`
- `NationalSpire.CareerRelics.Accept(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`CareerRelics.Accept(d, item)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerRelics.Accept(d, item);`
- `NationalSpire.CareerRelics.Cost(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`CareerRelics.Cost(d, item)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerRelics.Cost(d, item)`
- `NationalSpire.CareerRelics.Duration(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`CareerRelics.Duration(d, item)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerRelics.Duration(d, item)`
- `NationalSpire.CareerRelics.Spend(NationalSpire.CareerData)`；输入表达式：`CareerRelics.Spend(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerRelics.Spend(d);`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(d);`
- `NationalSpire.CareerTraining.ActiveRoster(NationalSpire.CareerData, string)`；输入表达式：`CareerTraining.ActiveRoster(d, p.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => CareerTraining.ActiveRoster(d, p.Id)`
- `NationalSpire.CareerTraining.GrowthAvailable(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`CareerTraining.GrowthAvailable(d, item)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CareerTraining.GrowthAvailable(d, item)`
- `NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`CareerTraining.IsTraining(item)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerTraining.IsTraining(item) || ClubPrograms.IsTraining(item)`
- `NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`CareerTraining.IsTraining(item)`；返回值紧邻使用处：`IfStatementSyntax: if (CareerTraining.IsTraining(item))          {              if (CareerTraining.Multiplayer(d)) return "合作比赛由真人共同完成，这项NPC训练不适用。";              if (item.ClubId != d.Esports.ClubId) return "这项训练属于此前的俱乐部。";              var targets = CareerTraining.Targets(d);              if (targetId.Length > 0 && !targets.Any(p => p.Id == targetId)) return "培养对象已不属于本队职业阵容。";              if (targetId.Length > 0) item.PersonId = targetId;              if (!targets.Any(p => p.Id == item.PersonId)) return "培养对象已不在本队。";              if (!CareerTraining.GrowthAvailable(d, item)) return "当前没有可培养的队友。";              if (CareerTraining.Kind(item.Title) is "team" or "team-growth" && !targets.Any(p => CareerTraining.ActiveRoster(d, p.Id))) return "本队尚无已确认的参赛阵容。";          }`
- `NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`CareerTraining.IsTraining(item)`；返回值紧邻使用处：`IfStatementSyntax: if (CareerTraining.IsTraining(item)) CareerTraining.Snapshot(d, item);          else if (item.Kind == "俱乐部" && item.TermsVersion >= 1)              item.TrainingTargets = CareerTraining.Targets(d).Where(p => CareerTraining.ActiveRoster(d, p.Id)).Select(p => p.Id).ToList();`
- `NationalSpire.CareerTraining.Kind(string)`；输入表达式：`CareerTraining.Kind(item.Title)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerTraining.Kind(item.Title) is "team" or "team-growth"`
- `NationalSpire.CareerTraining.Multiplayer(NationalSpire.CareerData)`；输入表达式：`CareerTraining.Multiplayer(d)`；返回值紧邻使用处：`IfStatementSyntax: if (CareerTraining.Multiplayer(d)) return "合作比赛由真人共同完成，这项NPC训练不适用。";`
- `NationalSpire.CareerTraining.Snapshot(NationalSpire.CareerData, NationalSpire.LifeActivity, bool)`；输入表达式：`CareerTraining.Snapshot(d, item)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerTraining.Snapshot(d, item);`
- `NationalSpire.CareerTraining.Targets(NationalSpire.CareerData)`；输入表达式：`CareerTraining.Targets(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerTraining.Targets(d)`
- `NationalSpire.CareerTraining.Targets(NationalSpire.CareerData)`；输入表达式：`CareerTraining.Targets(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CareerTraining.Targets(d).Where`
- `NationalSpire.ClubPrograms.Error(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`ClubPrograms.Error(d, item)`；返回值紧邻使用处：`IsPatternExpressionSyntax: ClubPrograms.Error(d, item) is { } programError`
- `NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`ClubPrograms.IsTraining(item)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerTraining.IsTraining(item) || ClubPrograms.IsTraining(item)`
- `NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`ClubPrograms.IsTraining(item)`；返回值紧邻使用处：`BinaryExpressionSyntax: ClubPrograms.IsTraining(item) && ClubPrograms.Error(d, item) is { } programError`
- `NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`ClubPrograms.IsTraining(item)`；返回值紧邻使用处：`IfStatementSyntax: if (ClubPrograms.IsTraining(item)) ClubPrograms.Snapshot(d, item);          else if (CareerTraining.IsTraining(item)) CareerTraining.Snapshot(d, item);          else if (item.Kind == "俱乐部" && item.TermsVersion >= 1)              item.TrainingTargets = CareerTraining.Targets(d).Where(p => CareerTraining.ActiveRoster(d, p.Id)).Select(p => p.Id).ToList();`
- `NationalSpire.ClubPrograms.Snapshot(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`ClubPrograms.Snapshot(d, item)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubPrograms.Snapshot(d, item);`
- `NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.CanOperate(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !OwnedClubs.CanOperate(d)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Activities.Any(a => a.LongProject && a.Status == "进行中")`；返回值紧邻使用处：`BinaryExpressionSyntax: item.LongProject && d.Life.Activities.Any(a => a.LongProject && a.Status == "进行中")`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`targets.Any(p => CareerTraining.ActiveRoster(d, p.Id))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !targets.Any(p => CareerTraining.ActiveRoster(d, p.Id))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`targets.Any(p => p.Id == item.PersonId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !targets.Any(p => p.Id == item.PersonId)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`targets.Any(p => p.Id == targetId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !targets.Any(p => p.Id == targetId)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Activities.FirstOrDefault(a => a.Id == id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Life.Activities.FirstOrDefault(a => a.Id == id)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`CareerTraining.Targets(d).Where(p => CareerTraining.ActiveRoster(d, p.Id)).Select(p => p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CareerTraining.Targets(d).Where(p => CareerTraining.ActiveRoster(d, p.Id)).Select(p => p.Id).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`CareerTraining.Targets(d).Where(p => CareerTraining.ActiveRoster(d, p.Id)).Select(p => p.Id).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: item.TrainingTargets = CareerTraining.Targets(d).Where(p => CareerTraining.ActiveRoster(d, p.Id)).Select(p => p.Id).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`CareerTraining.Targets(d).Where(p => CareerTraining.ActiveRoster(d, p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CareerTraining.Targets(d).Where(p => CareerTraining.ActiveRoster(d, p.Id)).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Activities.Where(a => a.Status == "可安排" && a.Round == item.Round)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var other in d.Life.Activities.Where(a => a.Status == "可安排" && a.Round == item.Round)) other.Status = "已结束";`

**赋值（含属性/字段和局部值）：**

- `d.Credits` -= `cost`
- `d.Life.LastDecisionDay` = `d.Day`
- `d.Life.NextOfferDay` = `d.Day + 7 + Hash(d, "decision:" + item.Id) % 6`
- `item.FinishDay` = `d.Day + duration`
- `item.PaidCost` = `cost`
- `item.PersonId` = `targetId`
- `item.Result` += `" " + Thanks(d, item)`
- `item.Result` += `$"本次优惠 {CareerMoney.Format(item.Cost - cost)}。"`
- `item.Result` += `$"筹备缩短 {item.Duration - duration} 天。"`
- `item.Result` = `(CareerTraining.IsTraining(item) || ClubPrograms.IsTraining(item))              ? item.WeeklyGrowthPoints > 0 ? $"第 {item.TrainingStart} 天开始培养，每周记录长期成长，第 {item.FinishDay} 天完成。"                  : $"第 {item.TrainingStart} 天开始备赛，效果持续至第 {item.TrainingEnd} 天（含当天）。第 {item.FinishDay} 天完成结算。"              : $"安排已确认，预计第 {item.FinishDay} 天完成。"`
- `item.StartedDay` = `d.Day`
- `item.Status` = `"进行中"`
- `item.TrainingTargets` = `CareerTraining.Targets(d).Where(p => CareerTraining.ActiveRoster(d, p.Id)).Select(p => p.Id).ToList()`
- `other.Status` = `"已结束"`

<a id="symbol-f6585e7dbdc5"></a>

## `NationalSpire.CareerLife.Thanks(NationalSpire.CareerData, NationalSpire.LifeActivity) — private static string Thanks(CareerData d, LifeActivity item)`

来源：源码第 215 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Accept(NationalSpire.CareerData, string, string)`](CareerLife.cs.md#symbol-cce5ea9d3250)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerLife.Hash(NationalSpire.CareerData, string)`](CareerLife.cs.md#symbol-0780f4d6b962)；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerLife.Hash(NationalSpire.CareerData, string)`；`NationalSpire.CareerLifeState.Relationships`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.LifeActivity.Id`；`NationalSpire.LifeActivity.Kind`；`NationalSpire.LifeActivity.PersonId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, item.PersonId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Person(d, item.PersonId)`
- `NationalSpire.CareerLife.Hash(NationalSpire.CareerData, string)`；输入表达式：`Hash(d, item.Id + ":thanks")`；返回值紧邻使用处：`BinaryExpressionSyntax: Hash(d, item.Id + ":thanks") % pool.Length`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`d.Life.Relationships.GetValueOrDefault(p.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Life.Relationships.GetValueOrDefault(p.Id) > 0`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e559cea1bbf6"></a>

## `NationalSpire.CareerLife.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity) — private static void Complete(CareerData d, LifeActivity a)`

来源：源码第 226 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Advance(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-62ec6434f115)；[`NationalSpire.CareerLife.RepairActivities(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-ce584c11d638)

**调用：** [`NationalSpire.CareerCommerce.TrainingInvestment(int, int)`](CareerCommerce.cs.md#symbol-42a4cc11a866)；[`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerLife.ActivityBenefit(NationalSpire.LifeActivity, int)`](CareerLife.cs.md#symbol-ed5e868de0b9)；[`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`](CareerLife.cs.md#symbol-0ea81cb3e558)；[`NationalSpire.CareerLife.Grow(NationalSpire.CareerData, NationalSpire.CareerPerson, int, string)`](CareerLife.cs.md#symbol-1479dc400873)；[`NationalSpire.CareerLife.Hash(NationalSpire.CareerData, string)`](CareerLife.cs.md#symbol-0780f4d6b962)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`](LifeData.cs.md#symbol-54a09649188b)；[`NationalSpire.CareerRelics.Business(NationalSpire.CareerData, NationalSpire.LifeActivity, int)`](CareerRelics.cs.md#symbol-2a0ab3c0872b)；[`NationalSpire.CareerRelics.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-f756311e9342)；[`NationalSpire.CareerRelics.Training(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-4da6df64d860)；[`NationalSpire.CareerTraining.Gains(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerTraining.cs.md#symbol-6bab0ebe3489)；[`NationalSpire.CareerTraining.Grow(NationalSpire.CareerData, string, int, int)`](CareerTraining.cs.md#symbol-8d0cf5a9811c)；[`NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`](CareerTraining.cs.md#symbol-98adbc7a75dc)；[`NationalSpire.ClubOperations.Entry(NationalSpire.CareerClub, int, string, int)`](ClubOperations.cs.md#symbol-a68dccdac5af)；[`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3ba0e806ba5c)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；[`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`](EsportsWorld.cs.md#symbol-c10dfd5a2e0e)；[`NationalSpire.LifeCatalog.Resolve(NationalSpire.LifeActivity)`](LifeCatalog.cs.md#symbol-bc308a2857a8)；[`NationalSpire.OwnedClubs.CompleteActivity(NationalSpire.CareerData, NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-d53f4fbd3e4e)；[`NationalSpire.PrivateMessages.ChangeFavour(NationalSpire.CareerData, string, int)`](PrivateMessages.cs.md#symbol-c703192e56c0)；[`NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-13f25fec3dea)；`string.Contains(char)`；`string.Replace(string, string?)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Math.Clamp(int, int, int)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerClub.Budget`；`NationalSpire.CareerClub.Id`；`NationalSpire.CareerCommerce.TrainingInvestment(int, int)`；`NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Fans`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerLife.ActivityBenefit(NationalSpire.LifeActivity, int)`；`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；`NationalSpire.CareerLife.Grow(NationalSpire.CareerData, NationalSpire.CareerPerson, int, string)`；`NationalSpire.CareerLife.Hash(NationalSpire.CareerData, string)`；`NationalSpire.CareerLifeState.Collection`；`NationalSpire.CareerLifeState.Facilities`；`NationalSpire.CareerLifeState.Preparation`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerRelics.Business(NationalSpire.CareerData, NationalSpire.LifeActivity, int)`；`NationalSpire.CareerRelics.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.CareerRelics.Training(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.CareerTraining.Gains(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.CareerTraining.Grow(NationalSpire.CareerData, string, int, int)`；`NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`；`NationalSpire.ClubOperations.Entry(NationalSpire.CareerClub, int, string, int)`；`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；`NationalSpire.LifeActivity.ClubId`；`NationalSpire.LifeActivity.Cost`；`NationalSpire.LifeActivity.Id`；`NationalSpire.LifeActivity.Kind`；`NationalSpire.LifeActivity.LongProject`；`NationalSpire.LifeActivity.PersonId`；`NationalSpire.LifeActivity.Public`；`NationalSpire.LifeActivity.Result`；`NationalSpire.LifeActivity.Setting`；`NationalSpire.LifeActivity.Status`；`NationalSpire.LifeActivity.TermsVersion`；`NationalSpire.LifeActivity.Title`；`NationalSpire.LifeActivity.TrainingTargets`；`NationalSpire.LifeActivity.Variant`；`NationalSpire.LifeActivity.WeeklyGrowthPoints`；`NationalSpire.LifeCatalog.Plan.Outcome`；`NationalSpire.LifeCatalog.Resolve(NationalSpire.LifeActivity)`；`NationalSpire.OwnedClubs.CompleteActivity(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.PrivateMessages.ChangeFavour(NationalSpire.CareerData, string, int)`；`NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerCommerce.TrainingInvestment(int, int)`；输入表达式：`CareerCommerce.TrainingInvestment(a.Cost / 2, 150)`；返回值紧邻使用处：`ArgumentSyntax: CareerCommerce.TrainingInvestment(a.Cost / 2, 150)`
- `NationalSpire.CareerCommerce.TrainingInvestment(int, int)`；输入表达式：`CareerCommerce.TrainingInvestment(a.Cost, 300)`；返回值紧邻使用处：`ArgumentSyntax: CareerCommerce.TrainingInvestment(a.Cost, 300)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, a.PersonId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.DisplayName(d, a.PersonId)`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, id)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.DisplayName(d, id)}`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Name(d) + "安排的"`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Name(d) + "的专项支持"`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, a.PersonId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(d, a.PersonId) is { } companion`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, a.PersonId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(d, a.PersonId) is { } youth`
- `NationalSpire.CareerLife.ActivityBenefit(NationalSpire.LifeActivity, int)`；输入表达式：`ActivityBenefit(a, a.Cost * percent / 100)`；返回值紧邻使用处：`ArgumentSyntax: ActivityBenefit(a, a.Cost * percent / 100)`
- `NationalSpire.CareerLife.ActivityBenefit(NationalSpire.LifeActivity, int)`；输入表达式：`ActivityBenefit(a, CareerCommerce.TrainingInvestment(a.Cost / 2, 150))`；返回值紧邻使用处：`ArgumentSyntax: ActivityBenefit(a, CareerCommerce.TrainingInvestment(a.Cost / 2, 150))`
- `NationalSpire.CareerLife.ActivityBenefit(NationalSpire.LifeActivity, int)`；输入表达式：`ActivityBenefit(a, CareerCommerce.TrainingInvestment(a.Cost, 300))`；返回值紧邻使用处：`BinaryExpressionSyntax: ActivityBenefit(a, CareerCommerce.TrainingInvestment(a.Cost, 300)) + CareerRelics.Training(d, a)`
- `NationalSpire.CareerLife.ActivityBenefit(NationalSpire.LifeActivity, int)`；输入表达式：`ActivityBenefit(a, fans * 20)`；返回值紧邻使用处：`AssignmentExpressionSyntax: fans = ActivityBenefit(a, fans * 20)`
- `NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；输入表达式：`AddEvent(d, a.Id + ":finish", a.Kind, a.Title + "完成", CareerEngine.Name(d) + "安排的" + a.Title + "完成。" + a.Result, ["player", a.PersonId], a.LongProject)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddEvent(d, a.Id + ":finish", a.Kind, a.Title + "完成", CareerEngine.Name(d) + "安排的" + a.Title + "完成。" + a.Result, ["player", a.PersonId], a.LongProject);`
- `NationalSpire.CareerLife.Grow(NationalSpire.CareerData, NationalSpire.CareerPerson, int, string)`；输入表达式：`Grow(d, member, ActivityBenefit(a, CareerCommerce.TrainingInvestment(a.Cost / 2, 150)), a.Id + member.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Grow(d, member, ActivityBenefit(a, CareerCommerce.TrainingInvestment(a.Cost / 2, 150)), a.Id + member.Id)`
- `NationalSpire.CareerLife.Grow(NationalSpire.CareerData, NationalSpire.CareerPerson, int, string)`；输入表达式：`Grow(d, youth, ActivityBenefit(a, CareerCommerce.TrainingInvestment(a.Cost, 300)) + CareerRelics.Training(d, a), a.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Grow(d, youth, ActivityBenefit(a, CareerCommerce.TrainingInvestment(a.Cost, 300)) + CareerRelics.Training(d, a), a.Id)`
- `NationalSpire.CareerLife.Hash(NationalSpire.CareerData, string)`；输入表达式：`Hash(d, a.Id + ":sales")`；返回值紧邻使用处：`BinaryExpressionSyntax: Hash(d, a.Id + ":sales") % 41`
- `NationalSpire.CareerLife.Hash(NationalSpire.CareerData, string)`；输入表达式：`Hash(d, a.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: Hash(d, a.Id) % 61`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(revenue)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(revenue)}`
- `NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；输入表达式：`CareerMoney.Record(d, a.Title + "结算", revenue)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Record(d, a.Title + "结算", revenue);`
- `NationalSpire.CareerRelics.Business(NationalSpire.CareerData, NationalSpire.LifeActivity, int)`；输入表达式：`CareerRelics.Business(d, a, ActivityBenefit(a, a.Cost * percent / 100))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerRelics.Business(d, a, ActivityBenefit(a, a.Cost * percent / 100))`
- `NationalSpire.CareerRelics.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`CareerRelics.Complete(d, a)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerRelics.Complete(d, a);`
- `NationalSpire.CareerRelics.Training(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`CareerRelics.Training(d, a)`；返回值紧邻使用处：`BinaryExpressionSyntax: ActivityBenefit(a, CareerCommerce.TrainingInvestment(a.Cost, 300)) + CareerRelics.Training(d, a)`
- `NationalSpire.CareerTraining.Gains(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`CareerTraining.Gains(d, a)`；返回值紧邻使用处：`BinaryExpressionSyntax: "培养完成。" + CareerTraining.Gains(d, a)`
- `NationalSpire.CareerTraining.Grow(NationalSpire.CareerData, string, int, int)`；输入表达式：`CareerTraining.Grow(d, companion.Id, a.TermsVersion >= 3 ? 20 : 10, d.Season)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerTraining.Grow(d, companion.Id, a.TermsVersion >= 3 ? 20 : 10, d.Season) / 100.0`
- `NationalSpire.CareerTraining.Grow(NationalSpire.CareerData, string, int, int)`；输入表达式：`CareerTraining.Grow(d, id, a.TermsVersion >= 3 ? 30 : a.TermsVersion >= 2 ? 15 : 25, d.Season)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerTraining.Grow(d, id, a.TermsVersion >= 3 ? 30 : a.TermsVersion >= 2 ? 15 : 25, d.Season) / 100.0`
- `NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`CareerTraining.IsTraining(a)`；返回值紧邻使用处：`IfStatementSyntax: if (CareerTraining.IsTraining(a)) a.Result = a.WeeklyGrowthPoints > 0 ? "培养完成。" + CareerTraining.Gains(d, a) : "四周备赛已结束。";`
- `NationalSpire.ClubOperations.Entry(NationalSpire.CareerClub, int, string, int)`；输入表达式：`ClubOperations.Entry(team, d.Day, a.Title + "交付支出", -a.Cost)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubOperations.Entry(team, d.Day, a.Title + "交付支出", -a.Cost);`
- `NationalSpire.ClubOperations.Entry(NationalSpire.CareerClub, int, string, int)`；输入表达式：`ClubOperations.Entry(team, d.Day, CareerEngine.Name(d) + "的专项支持", a.Cost)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubOperations.Entry(team, d.Day, CareerEngine.Name(d) + "的专项支持", a.Cost);`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(d, a.ClubId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: EsportsWorld.Club(d, a.ClubId) is { } team`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(d, a.ClubId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = EsportsWorld.ClubName(d, a.ClubId)`
- `NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；输入表达式：`EsportsWorld.IsProfessional(companion)`；返回值紧邻使用处：`BinaryExpressionSyntax: a.TermsVersion >= 1 && a.Title is "重看经典比赛" or "录制选手对谈" && CareerEngine.Person(d, a.PersonId) is { } companion && EsportsWorld.IsProfessional(companion)`
- `NationalSpire.LifeCatalog.Resolve(NationalSpire.LifeActivity)`；输入表达式：`LifeCatalog.Resolve(a)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = LifeCatalog.Resolve(a)`
- `NationalSpire.OwnedClubs.CompleteActivity(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`OwnedClubs.CompleteActivity(d, a)`；返回值紧邻使用处：`AssignmentExpressionSyntax: a.Result += OwnedClubs.CompleteActivity(d, a)`
- `NationalSpire.PrivateMessages.ChangeFavour(NationalSpire.CareerData, string, int)`；输入表达式：`PrivateMessages.ChangeFavour(d, a.PersonId, a.TermsVersion >= 1 && a.Kind == "社交" ? 6 : 3)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateMessages.ChangeFavour(d, a.PersonId, a.TermsVersion >= 1 && a.Kind == "社交" ? 6 : 3);`
- `NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Favour(d, a.PersonId)`；返回值紧邻使用处：`InterpolationSyntax: {PrivateMessages.Favour(d, a.PersonId)}`
- `string.Contains(char)`；输入表达式：`a.Variant.Contains(':')`；返回值紧邻使用处：`BinaryExpressionSyntax: a.Variant.Contains(':') && a.Kind == "社交"`
- `string.Replace(string, string?)`；输入表达式：`plan.Outcome.Replace("{人}", name).Replace("{队}", club).Replace("{地}", a.Setting)`；返回值紧邻使用处：`BinaryExpressionSyntax: plan.Outcome.Replace("{人}", name).Replace("{队}", club).Replace("{地}", a.Setting) + "。"`
- `string.Replace(string, string?)`；输入表达式：`plan.Outcome.Replace("{人}", name).Replace("{队}", club)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: plan.Outcome.Replace("{人}", name).Replace("{队}", club).Replace`
- `string.Replace(string, string?)`；输入表达式：`plan.Outcome.Replace("{人}", name)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: plan.Outcome.Replace("{人}", name).Replace`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`d.People.Where(p => p.ClubId == team.Id && p.Role == "青训选手").Take(2)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var member in d.People.Where(p => p.ClubId == team.Id && p.Role == "青训选手").Take(2))              {                  int gain = Grow(d, member, ActivityBenefit(a, CareerCommerce.TrainingInvestment(a.Cost / 2, 150)), a.Id + member.Id);                  if (gain > 0) a.Result += $"{member.PublicName}从本次安排中有所收获，评分增加{gain}。";              }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p => p.ClubId == team.Id && p.Role == "青训选手")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.ClubId == team.Id && p.Role == "青训选手").Take`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(70 + Hash(d, a.Id + ":sales") % 41 + Math.Min(20, d.Fans / 5000), 70, 130)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Clamp(70 + Hash(d, a.Id + ":sales") % 41 + Math.Min(20, d.Fans / 5000), 70, 130)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(20, d.Fans / 5000)`；返回值紧邻使用处：`BinaryExpressionSyntax: 70 + Hash(d, a.Id + ":sales") % 41 + Math.Min(20, d.Fans / 5000)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(3, d.Life.Facilities + 1)`；返回值紧邻使用处：`AssignmentExpressionSyntax: d.Life.Facilities = Math.Min(3, d.Life.Facilities + 1)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(75, a.Cost / 10)`；返回值紧邻使用处：`BinaryExpressionSyntax: 15 + Hash(d, a.Id) % 61 + Math.Min(75, a.Cost / 10)`

**赋值（含属性/字段和局部值）：**

- `a.Result` += `"本次专项收支已记入俱乐部账目。"`
- `a.Result` += `"休息后整理了想法，下次内容制作费用减少 12%，最多节省 $240，不叠加次数。"`
- `a.Result` += `$"{CareerEngine.DisplayName(d, id)}永久通关率 +{CareerTraining.Grow(d, id, a.TermsVersion >= 3 ? 30 : a.TermsVersion >= 2 ? 15 : 25, d.Season) / 100.0:0.##}%。"`
- `a.Result` += `$"{companion.PublicName}永久通关率 +{CareerTraining.Grow(d, companion.Id, a.TermsVersion >= 3 ? 20 : 10, d.Season) / 100.0:0.##}%。"`
- `a.Result` += `$"{member.PublicName}从本次安排中有所收获，评分增加{gain}。"`
- `a.Result` += `$"{name}对你的好感为 {PrivateMessages.Favour(d, a.PersonId)}。"`
- `a.Result` += `$"本次到账{CareerMoney.Format(revenue)}，项目已结清。"`
- `a.Result` += `$"新增{fans}位关注者。"`
- `a.Result` += `$"长期配套已投入使用：内容和社区活动费用减少 {d.Life.Facilities * 2.4:0.#}%，每次最多节省 $240。"`
- `a.Result` += `gain > 0 ? $"{name}在阶段训练中有所进步，评分增加{gain}。" : $"{name}完成了阶段安排，比赛成绩将由后续赛事记录。"`
- `a.Result` += `OwnedClubs.CompleteActivity(d, a)`
- `a.Result` = `"活动已完成，原有安排记录已经保留。"`
- `a.Result` = `a.WeeklyGrowthPoints > 0 ? "培养完成。" + CareerTraining.Gains(d, a) : "四周备赛已结束。"`
- `a.Result` = `plan.Outcome.Replace("{人}", name).Replace("{队}", club).Replace("{地}", a.Setting) + "。"`
- `a.Status` = `"已完成"`
- `d.Credits` += `revenue`
- `d.Fans` += `fans`
- `d.Life.Collection[a.Variant]` = `a.Title + " · 第" + d.Season + "赛季"`
- `d.Life.Facilities` = `Math.Min(3, d.Life.Facilities + 1)`
- `d.Life.Preparation` = `1`
- `fans` = `ActivityBenefit(a, fans * 20)`
- `fans` = `fans * 6 / 5`
- `team.Budget` -= `a.Cost`
- `team.Budget` += `a.Cost`

<a id="symbol-ed5e868de0b9"></a>

## `NationalSpire.CareerLife.ActivityBenefit(NationalSpire.LifeActivity, int) — public static int ActivityBenefit(LifeActivity a, int value)`

来源：源码第 283 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerLife.cs.md#symbol-e559cea1bbf6)；[`NationalSpire.CareerLife.Expected(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerLife.cs.md#symbol-44d430d90686)；[`NationalSpire.OwnedClubs.CompleteActivity(NationalSpire.CareerData, NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-d53f4fbd3e4e)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.LifeActivity.TermsVersion`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-1479dc400873"></a>

## `NationalSpire.CareerLife.Grow(NationalSpire.CareerData, NationalSpire.CareerPerson, int, string) — public static int Grow(CareerData d, CareerPerson person, int investment, string seed)`

来源：源码第 284 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerLife.cs.md#symbol-e559cea1bbf6)；[`NationalSpire.CircuitLedger.SeasonStart(NationalSpire.CareerData)`](CircuitLedger.cs.md#symbol-b971fd6392cb)；[`NationalSpire.ClubOperations.Advance(NationalSpire.CareerData)`](ClubOperations.cs.md#symbol-213a7e731998)

**调用：** [`NationalSpire.CareerCommerce.Develop(NationalSpire.CareerPerson, int, string, double)`](CareerCommerce.cs.md#symbol-a91e3e6065a8)；`System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerCommerce.Develop(NationalSpire.CareerPerson, int, string, double)`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerLifeState.GrowthSeason`；`NationalSpire.CareerLifeState.GrowthThisSeason`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.MaxAscension`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerCommerce.Develop(NationalSpire.CareerPerson, int, string, double)`；输入表达式：`CareerCommerce.Develop(person, investment, seed, pace)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerCommerce.Develop(person, investment, seed, pace)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Clear()`；输入表达式：`d.Life.GrowthThisSeason.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Life.GrowthThisSeason.Clear();`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`d.Life.GrowthThisSeason.GetValueOrDefault(person.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Life.GrowthThisSeason.GetValueOrDefault(person.Id) / (double)scale`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`d.Life.GrowthThisSeason.GetValueOrDefault(person.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Life.GrowthThisSeason.GetValueOrDefault(person.Id) + gain`

**赋值（含属性/字段和局部值）：**

- `d.Life.GrowthSeason` = `d.Season`
- `d.Life.GrowthThisSeason[person.Id]` = `d.Life.GrowthThisSeason.GetValueOrDefault(person.Id) + gain`

<a id="symbol-1fcea966dfa4"></a>

## `NationalSpire.CareerLife.TeamMatchBonus(NationalSpire.CareerData, NationalSpire.WorldCompetition, string, int, int) — public static double TeamMatchBonus(CareerData d, WorldCompetition competition, string personId, int matchDay, int ascension = 8)`

来源：源码第 294 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.MatchRules.Evaluate(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?, bool)`](MatchRules.cs.md#symbol-92264d5fcfdd)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.ChanceFactors.Growth`；`NationalSpire.ChanceFactors.Practice`；`NationalSpire.ChanceFactors.Training`；`NationalSpire.MatchRules.Evaluate(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, personId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Person(d, personId)`
- `NationalSpire.MatchRules.Evaluate(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?, bool)`；输入表达式：`MatchRules.Evaluate(d, person, ascension, matchDay)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MatchRules.Evaluate(d, person, ascension, matchDay)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-efe3762d8665"></a>

## `NationalSpire.CareerLife.SkipRound(NationalSpire.CareerData) — public static void SkipRound(CareerData d)`

来源：源码第 301 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Life(NationalSpire.CareerData)`](LifeScreen.cs.md#symbol-0cdff88b6131)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** [`NationalSpire.CareerLife.Hash(NationalSpire.CareerData, string)`](CareerLife.cs.md#symbol-0780f4d6b962)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLife.Hash(NationalSpire.CareerData, string)`；`NationalSpire.CareerLifeState.Activities`；`NationalSpire.CareerLifeState.LastDecisionDay`；`NationalSpire.CareerLifeState.NextOfferDay`；`NationalSpire.CareerLifeState.OfferRound`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.LifeActivity.Status`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerLife.Hash(NationalSpire.CareerData, string)`；输入表达式：`Hash(d, "skip:" + d.Life.OfferRound)`；返回值紧邻使用处：`BinaryExpressionSyntax: Hash(d, "skip:" + d.Life.OfferRound) % 6`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(d);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Activities.Any(a => a.Status == "可安排")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.Life.Activities.Any(a => a.Status == "可安排")`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Activities.Where(a => a.Status == "可安排")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var a in d.Life.Activities.Where(a => a.Status == "可安排")) a.Status = "已结束";`

**赋值（含属性/字段和局部值）：**

- `a.Status` = `"已结束"`
- `d.Life.LastDecisionDay` = `d.Day`
- `d.Life.NextOfferDay` = `d.Day + 7 + Hash(d, "skip:" + d.Life.OfferRound) % 6`

<a id="symbol-44d430d90686"></a>

## `NationalSpire.CareerLife.Expected(NationalSpire.CareerData, NationalSpire.LifeActivity) — public static string Expected(CareerData d, LifeActivity a)`

来源：源码第 309 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ActivityCard(NationalSpire.CareerData, NationalSpire.LifeActivity)`](LifeScreen.cs.md#symbol-5b3e0aaad277)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerLife.ActivityBenefit(NationalSpire.LifeActivity, int)`](CareerLife.cs.md#symbol-ed5e868de0b9)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerTraining.Description(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerTraining.cs.md#symbol-8fa9f91feb98)；[`NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`](CareerTraining.cs.md#symbol-98adbc7a75dc)；[`NationalSpire.ClubPrograms.Description(NationalSpire.CareerData, NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-35a5fe8029e5)；[`NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-f251644672be)；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerLife.ActivityBenefit(NationalSpire.LifeActivity, int)`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerTraining.Description(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`；`NationalSpire.ClubPrograms.Description(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`；`NationalSpire.LifeActivity.Cost`；`NationalSpire.LifeActivity.Kind`；`NationalSpire.LifeActivity.LongProject`；`NationalSpire.LifeActivity.PersonId`；`NationalSpire.LifeActivity.TermsVersion`；`NationalSpire.LifeActivity.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, a.PersonId)`；返回值紧邻使用处：`InterpolationSyntax: {CareerEngine.DisplayName(d, a.PersonId)}`
- `NationalSpire.CareerLife.ActivityBenefit(NationalSpire.LifeActivity, int)`；输入表达式：`ActivityBenefit(a, 300)`；返回值紧邻使用处：`InterpolationSyntax: {ActivityBenefit(a, 300)}`
- `NationalSpire.CareerLife.ActivityBenefit(NationalSpire.LifeActivity, int)`；输入表达式：`ActivityBenefit(a, 600)`；返回值紧邻使用处：`InterpolationSyntax: {ActivityBenefit(a, 600)}`
- `NationalSpire.CareerLife.ActivityBenefit(NationalSpire.LifeActivity, int)`；输入表达式：`ActivityBenefit(a, a.Cost * 130 / 100)`；返回值紧邻使用处：`ArgumentSyntax: ActivityBenefit(a, a.Cost * 130 / 100)`
- `NationalSpire.CareerLife.ActivityBenefit(NationalSpire.LifeActivity, int)`；输入表达式：`ActivityBenefit(a, a.Cost * 70 / 100)`；返回值紧邻使用处：`ArgumentSyntax: ActivityBenefit(a, a.Cost * 70 / 100)`
- `NationalSpire.CareerLife.ActivityBenefit(NationalSpire.LifeActivity, int)`；输入表达式：`ActivityBenefit(a, fanHigh * 20)`；返回值紧邻使用处：`AssignmentExpressionSyntax: fanHigh = ActivityBenefit(a, fanHigh * 20)`
- `NationalSpire.CareerLife.ActivityBenefit(NationalSpire.LifeActivity, int)`；输入表达式：`ActivityBenefit(a, fanLow * 20)`；返回值紧邻使用处：`AssignmentExpressionSyntax: fanLow = ActivityBenefit(a, fanLow * 20)`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(ActivityBenefit(a, a.Cost * 130 / 100))`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(ActivityBenefit(a, a.Cost * 130 / 100))}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(ActivityBenefit(a, a.Cost * 70 / 100))`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(ActivityBenefit(a, a.Cost * 70 / 100))}`
- `NationalSpire.CareerTraining.Description(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`CareerTraining.Description(d, a)`；返回值紧邻使用处：`ReturnStatementSyntax: return CareerTraining.Description(d, a);`
- `NationalSpire.CareerTraining.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`CareerTraining.IsTraining(a)`；返回值紧邻使用处：`IfStatementSyntax: if (CareerTraining.IsTraining(a)) return CareerTraining.Description(d, a);`
- `NationalSpire.ClubPrograms.Description(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`ClubPrograms.Description(d, a)`；返回值紧邻使用处：`ReturnStatementSyntax: return ClubPrograms.Description(d, a);`
- `NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`ClubPrograms.IsTraining(a)`；返回值紧邻使用处：`IfStatementSyntax: if (ClubPrograms.IsTraining(a)) return ClubPrograms.Description(d, a);`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(75, a.Cost / 10)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(75, a.Cost / 10)`

**赋值（含属性/字段和局部值）：**

- `fanHigh` = `ActivityBenefit(a, fanHigh * 20)`
- `fanHigh` = `fanHigh * 6 / 5`
- `fanLow` = `ActivityBenefit(a, fanLow * 20)`
- `fanLow` = `fanLow * 6 / 5`

<a id="symbol-0ea81cb3e558"></a>

## `NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool) — public static void AddEvent(CareerData d, string id, string topic, string title, string detail, List<string> people, bool important = false)`

来源：源码第 331 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerCommerce.AcceptSponsor(NationalSpire.CareerData, NationalSpire.SponsorContract)`](CareerCommerce.cs.md#symbol-dde63e77bf01)；[`NationalSpire.CareerCommerce.RefreshOffers(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-3523341b8f0b)；[`NationalSpire.CareerLife.Accept(NationalSpire.CareerData, string, string)`](CareerLife.cs.md#symbol-cce5ea9d3250)；[`NationalSpire.CareerLife.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerLife.cs.md#symbol-e559cea1bbf6)；[`NationalSpire.CircuitPeople.Replenish(NationalSpire.CareerData)`](CircuitPeople.cs.md#symbol-03130719dfb2)；[`NationalSpire.ClubCoaching.Notice(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-d31f98e532af)；[`NationalSpire.ClubOperations.Advance(NationalSpire.CareerData)`](ClubOperations.cs.md#symbol-213a7e731998)；[`NationalSpire.ClubOperations.TryTransfer(NationalSpire.CareerData, NationalSpire.CareerClub)`](ClubOperations.cs.md#symbol-91ececd875b5)；[`NationalSpire.CoachLineups.SeasonStart(NationalSpire.CareerData)`](CoachLineups.cs.md#symbol-e6f5b5e37a12)；[`NationalSpire.ConsumerEvents.Activity(NationalSpire.CareerData, NationalSpire.Good, NationalSpire.GoodVerb, System.Collections.Generic.IReadOnlyList<string>)`](ConsumerEvents.cs.md#symbol-49f04620b21e)；[`NationalSpire.ConsumerEvents.Purchase(NationalSpire.CareerData, string, System.Collections.Generic.IReadOnlyList<string>)`](ConsumerEvents.cs.md#symbol-046119a7c75d)；[`NationalSpire.EsportsWorld.AcceptOffer(NationalSpire.CareerData, NationalSpire.ClubOffer)`](EsportsWorld.cs.md#symbol-09ff5941397c)；[`NationalSpire.OwnedClubs.Advance(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-7fe29c98085a)；[`NationalSpire.OwnedClubs.CreateCore(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-21d1184d2591)；[`NationalSpire.OwnedClubs.Report(NationalSpire.CareerData, string, string, string, System.Collections.Generic.List<string>)`](OwnedClubs.cs.md#symbol-4a616a09019e)；[`NationalSpire.WorldEvents.Advance(NationalSpire.CareerData)`](WorldEvents.cs.md#symbol-6471e41e5007)

**调用：** [`NationalSpire.CareerLife.PublicActivityText(string)`](CareerLife.cs.md#symbol-10028eaa1557)；[`NationalSpire.CircuitLedger.Remember(NationalSpire.CareerData, string, string, System.Collections.Generic.List<string>)`](CircuitLedger.cs.md#symbol-0791637c974d)；`NationalSpire.LifeEvent.LifeEvent()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLife.PublicActivityText(string)`；`NationalSpire.CareerLifeState.Events`；`NationalSpire.CircuitLedger.Remember(NationalSpire.CareerData, string, string, System.Collections.Generic.List<string>)`；`NationalSpire.LifeEvent.Day`；`NationalSpire.LifeEvent.Detail`；`NationalSpire.LifeEvent.Id`；`NationalSpire.LifeEvent.Important`；`NationalSpire.LifeEvent.People`；`NationalSpire.LifeEvent.Title`；`NationalSpire.LifeEvent.Topic`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerLife.PublicActivityText(string)`；输入表达式：`PublicActivityText(detail)`；返回值紧邻使用处：`AssignmentExpressionSyntax: detail = PublicActivityText(detail)`
- `NationalSpire.CircuitLedger.Remember(NationalSpire.CareerData, string, string, System.Collections.Generic.List<string>)`；输入表达式：`CircuitLedger.Remember(d, "life-fact:" + id, title + "：" + detail, people)`；返回值紧邻使用处：`ExpressionStatementSyntax: CircuitLedger.Remember(d, "life-fact:" + id, title + "：" + detail, people);`
- `NationalSpire.LifeEvent.LifeEvent()`；输入表达式：`new() { Id = id, Day = d.Day, Topic = topic, Title = title, Detail = detail, People = people.Distinct().ToList(), Important = important }`；返回值紧邻使用处：`ArgumentSyntax: new() { Id = id, Day = d.Day, Topic = topic, Title = title, Detail = detail, People = people.Distinct().ToList(), Important = important }`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Events.Any(e => e.Id == id)`；返回值紧邻使用处：`IfStatementSyntax: if (d.Life.Events.Any(e => e.Id == id)) return;`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`people.Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: people.Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`people.Distinct().ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: People = people.Distinct().ToList()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Life.Events.Add(new() { Id = id, Day = d.Day, Topic = topic, Title = title, Detail = detail, People = people.Distinct().ToList(), Important = important })`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Life.Events.Add(new() { Id = id, Day = d.Day, Topic = topic, Title = title, Detail = detail, People = people.Distinct().ToList(), Important = important });`

**赋值（含属性/字段和局部值）：**

- `Day` = `d.Day`
- `Detail` = `detail`
- `detail` = `PublicActivityText(detail)`
- `Id` = `id`
- `Important` = `important`
- `People` = `people.Distinct().ToList()`
- `Title` = `title`
- `Topic` = `topic`

<a id="symbol-10028eaa1557"></a>

## `NationalSpire.CareerLife.PublicActivityText(string) — internal static string PublicActivityText(string text)`

来源：源码第 340 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`](CareerLife.cs.md#symbol-0ea81cb3e558)；[`NationalSpire.CareerLife.RefreshPublicFacts(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-e81d9b416e03)

**调用：** `System.Text.RegularExpressions.Regex.Replace(string, string, string)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Text.RegularExpressions.Regex.Replace(string, string, string)`；输入表达式：`System.Text.RegularExpressions.Regex.Replace(text, @"，评分增加\d+", "")`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = System.Text.RegularExpressions.Regex.Replace(text, @"，评分增加\d+", "")`
- `System.Text.RegularExpressions.Regex.Replace(string, string, string)`；输入表达式：`System.Text.RegularExpressions.Regex.Replace(text, @"从交流中获得长期进步，增加 [\d.]+ 个百分点。", "从交流中获得长期进步。")`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = System.Text.RegularExpressions.Regex.Replace(text, @"从交流中获得长期进步，增加 [\d.]+ 个百分点。", "从交流中获得长期进步。")`
- `System.Text.RegularExpressions.Regex.Replace(string, string, string)`；输入表达式：`System.Text.RegularExpressions.Regex.Replace(text, @"休息后整理了想法，下次内容制作费用减少 (?:10|12)%，最多节省 \$(?:200|240)，不叠加次数。", "休息后重新整理了创作想法。")`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = System.Text.RegularExpressions.Regex.Replace(text, @"休息后整理了想法，下次内容制作费用减少 (?:10|12)%，最多节省 \$(?:200|240)，不叠加次数。", "休息后重新整理了创作想法。")`
- `System.Text.RegularExpressions.Regex.Replace(string, string, string)`；输入表达式：`System.Text.RegularExpressions.Regex.Replace(text, @"永久通关率 \+[\d.]+%。", "在专项训练中取得进步。")`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = System.Text.RegularExpressions.Regex.Replace(text, @"永久通关率 \+[\d.]+%。", "在专项训练中取得进步。")`
- `System.Text.RegularExpressions.Regex.Replace(string, string, string)`；输入表达式：`System.Text.RegularExpressions.Regex.Replace(text, @"与[^。\r\n]+的来往程度为 \d+/20。", "")`；返回值紧邻使用处：`ReturnStatementSyntax: return System.Text.RegularExpressions.Regex.Replace(text, @"与[^。\r\n]+的来往程度为 \d+/20。", "");`
- `System.Text.RegularExpressions.Regex.Replace(string, string, string)`；输入表达式：`System.Text.RegularExpressions.Regex.Replace(text, @"长期发挥能力增加 [\d.]+ 个百分点。", "在专项训练中取得进步。")`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = System.Text.RegularExpressions.Regex.Replace(text, @"长期发挥能力增加 [\d.]+ 个百分点。", "在专项训练中取得进步。")`
- `System.Text.RegularExpressions.Regex.Replace(string, string, string)`；输入表达式：`System.Text.RegularExpressions.Regex.Replace(text, @"长期配套已投入使用：内容和社区活动费用减少 [\d.]+%，每次最多节省 \$(?:200|240)。", "长期配套已投入使用。")`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = System.Text.RegularExpressions.Regex.Replace(text, @"长期配套已投入使用：内容和社区活动费用减少 [\d.]+%，每次最多节省 \$(?:200|240)。", "长期配套已投入使用。")`

**赋值（含属性/字段和局部值）：**

- `text` = `System.Text.RegularExpressions.Regex.Replace(text, @"，评分增加\d+", "")`
- `text` = `System.Text.RegularExpressions.Regex.Replace(text, @"从交流中获得长期进步，增加 [\d.]+ 个百分点。", "从交流中获得长期进步。")`
- `text` = `System.Text.RegularExpressions.Regex.Replace(text, @"休息后整理了想法，下次内容制作费用减少 (?:10|12)%，最多节省 \$(?:200|240)，不叠加次数。", "休息后重新整理了创作想法。")`
- `text` = `System.Text.RegularExpressions.Regex.Replace(text, @"永久通关率 \+[\d.]+%。", "在专项训练中取得进步。")`
- `text` = `System.Text.RegularExpressions.Regex.Replace(text, @"长期发挥能力增加 [\d.]+ 个百分点。", "在专项训练中取得进步。")`
- `text` = `System.Text.RegularExpressions.Regex.Replace(text, @"长期配套已投入使用：内容和社区活动费用减少 [\d.]+%，每次最多节省 \$(?:200|240)。", "长期配套已投入使用。")`

<a id="symbol-e81d9b416e03"></a>

## `NationalSpire.CareerLife.RefreshPublicFacts(NationalSpire.CareerData) — private static void RefreshPublicFacts(CareerData d)`

来源：源码第 350 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Ensure(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-eb417e39aebf)

**调用：** [`NationalSpire.CareerLife.PublicActivityText(string)`](CareerLife.cs.md#symbol-10028eaa1557)；[`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`](CommunityThreads.cs.md#symbol-35173ffbb055)；`string.StartsWith(string)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiWorkState.State`；`NationalSpire.CareerData.CommunityMemories`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.WeeklyEditions`；`NationalSpire.CareerLife.PublicActivityText(string)`；`NationalSpire.CareerLifeState.Events`；`NationalSpire.CommunityMemory.Id`；`NationalSpire.CommunityMemory.Kind`；`NationalSpire.CommunityMemory.PostId`；`NationalSpire.CommunityMemory.Text`；`NationalSpire.CommunityPost.AuthorId`；`NationalSpire.CommunityPost.Body`；`NationalSpire.CommunityPost.EventKey`；`NationalSpire.CommunityPost.Id`；`NationalSpire.CommunityPost.NewsGeneration`；`NationalSpire.CommunityPost.SourceBody`；`NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；`NationalSpire.LifeEvent.Detail`；`NationalSpire.WeeklyEdition.Slides`；`NationalSpire.WeeklySlide.EventIds`；`NationalSpire.WeeklySlide.Facts`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerLife.PublicActivityText(string)`；输入表达式：`PublicActivityText(e.Detail)`；返回值紧邻使用处：`AssignmentExpressionSyntax: e.Detail = PublicActivityText(e.Detail)`
- `NationalSpire.CareerLife.PublicActivityText(string)`；输入表达式：`PublicActivityText(memory.Text)`；返回值紧邻使用处：`AssignmentExpressionSyntax: memory.Text = PublicActivityText(memory.Text)`
- `NationalSpire.CareerLife.PublicActivityText(string)`；输入表达式：`PublicActivityText(post.Body)`；返回值紧邻使用处：`AssignmentExpressionSyntax: post.Body = PublicActivityText(post.Body)`
- `NationalSpire.CareerLife.PublicActivityText(string)`；输入表达式：`PublicActivityText(post.SourceBody)`；返回值紧邻使用处：`AssignmentExpressionSyntax: post.SourceBody = PublicActivityText(post.SourceBody)`
- `NationalSpire.CareerLife.PublicActivityText(string)`；输入表达式：`PublicActivityText(slide.Facts)`；返回值紧邻使用处：`AssignmentExpressionSyntax: slide.Facts = PublicActivityText(slide.Facts)`
- `NationalSpire.CommunityThreads.All(NationalSpire.CareerData)`；输入表达式：`CommunityThreads.All(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(d).Where`
- `string.StartsWith(string)`；输入表达式：`m.Id.StartsWith("life-fact:")`；返回值紧邻使用处：`BinaryExpressionSyntax: m.Id.StartsWith("life-fact:")              || postIds.Contains(m.PostId)`
- `string.StartsWith(string)`；输入表达式：`p.EventKey.StartsWith("life-update-")`；返回值紧邻使用处：`BinaryExpressionSyntax: p.AuthorId != "player" && p.EventKey.StartsWith("life-update-")`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`postIds.Contains(m.PostId)`；返回值紧邻使用处：`BinaryExpressionSyntax: m.Id.StartsWith("life-fact:")              || postIds.Contains(m.PostId)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`posts.Select(p => p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: posts.Select(p => p.Id).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`d.WeeklyEditions.SelectMany(w => w.Slides)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.WeeklyEditions.SelectMany(w => w.Slides).Where`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`posts.Select(p => p.Id).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = posts.Select(p => p.Id).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`CommunityThreads.All(d).Where(p => p.AuthorId != "player" && p.EventKey.StartsWith("life-update-")).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CommunityThreads.All(d).Where(p => p.AuthorId != "player" && p.EventKey.StartsWith("life-update-")).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`CommunityThreads.All(d).Where(p => p.AuthorId != "player" && p.EventKey.StartsWith("life-update-"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CommunityThreads.All(d).Where(p => p.AuthorId != "player" && p.EventKey.StartsWith("life-update-")).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.CommunityMemories.Where(m => m.Kind == "fact" && (m.Id.StartsWith("life-fact:")              || postIds.Contains(m.PostId)))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var memory in d.CommunityMemories.Where(m => m.Kind == "fact" && (m.Id.StartsWith("life-fact:")              || postIds.Contains(m.PostId))))              memory.Text = PublicActivityText(memory.Text);`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.WeeklyEditions.SelectMany(w => w.Slides).Where(s => s.EventIds.Count > 0)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var slide in d.WeeklyEditions.SelectMany(w => w.Slides).Where(s => s.EventIds.Count > 0))              slide.Facts = PublicActivityText(slide.Facts);`

**赋值（含属性/字段和局部值）：**

- `e.Detail` = `PublicActivityText(e.Detail)`
- `memory.Text` = `PublicActivityText(memory.Text)`
- `post.Body` = `PublicActivityText(post.Body)`
- `post.SourceBody` = `PublicActivityText(post.SourceBody)`
- `slide.Facts` = `PublicActivityText(slide.Facts)`

<a id="symbol-22e5c183ccfb"></a>

## `NationalSpire.CareerLife.PublishPending(NationalSpire.CareerData) — public static void PublishPending(CareerData d)`

来源：源码第 367 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.MoveToNextDay(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-3836a38a7da9)

**调用：** [`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`](CareerEngine.cs.md#symbol-cd8fd2c800e7)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`string.StartsWith(string)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.Enabled`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerData.CooperativeMembers`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Posts`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；`NationalSpire.CareerLifeState.Events`；`NationalSpire.CommunityPost.EventKey`；`NationalSpire.CommunityPost.Id`；`NationalSpire.LifeEvent.Day`；`NationalSpire.LifeEvent.Detail`；`NationalSpire.LifeEvent.Id`；`NationalSpire.LifeEvent.Important`；`NationalSpire.LifeEvent.People`；`NationalSpire.LifeEvent.PostId`；`NationalSpire.LifeEvent.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Name(d) + "的近期安排与进展"`
- `NationalSpire.CareerEngine.Publish(NationalSpire.CareerData, string, string, string, string, bool, System.Collections.Generic.List<string>?, NationalSpire.CareerMatch?)`；输入表达式：`CareerEngine.Publish(d, key, events.Count == 1 ? first.Title : CareerEngine.Name(d) + "的近期安排与进展",              string.Join("\n", events.OrderBy(e => e.Day).Select(e => $"第{e.Day}天，{e.Title}：{e.Detail}")), "人物日常", true,              events.SelectMany(e => e.People).Distinct().ToList())`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.Publish(d, key, events.Count == 1 ? first.Title : CareerEngine.Name(d) + "的近期安排与进展",              string.Join("\n", events.OrderBy(e => e.Day).Select(e => $"第{e.Day}天，{e.Title}：{e.Detail}")), "人物日常", true,              events.SelectMany(e => e.People).Distinct().ToList());`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", events.OrderBy(e => e.Day).Select(e => $"第{e.Day}天，{e.Title}：{e.Detail}"))`；返回值紧邻使用处：`ArgumentSyntax: string.Join("\n", events.OrderBy(e => e.Day).Select(e => $"第{e.Day}天，{e.Title}：{e.Detail}"))`
- `string.StartsWith(string)`；输入表达式：`e.Id.StartsWith("human-")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !e.Id.StartsWith("human-")`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`e.People.Any(id => id == "player" || d.HumanIds.Contains(id))`；返回值紧邻使用处：`BinaryExpressionSyntax: e.PostId.Length == 0 && e.Day < d.Day && e.Day >= d.Day - 7 && e.People.Any(id => id == "player" || d.HumanIds.Contains(id))`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`events.SelectMany(e => e.People).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: events.SelectMany(e => e.People).Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Posts.FirstOrDefault(p => p.EventKey == key)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Posts.FirstOrDefault(p => p.EventKey == key)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`events.OrderBy(e => e.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: events.OrderBy(e => e.Day).Select`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Life.Events.Where(e => e.PostId.Length == 0 && e.Day < d.Day && e.Day >= d.Day - 7 && e.People.Any(id => id == "player" || d.HumanIds.Contains(id))              && (d.CooperativeMembers <= 1 || !e.Id.StartsWith("human-")))              .OrderByDescending(e => e.Important)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Events.Where(e => e.PostId.Length == 0 && e.Day < d.Day && e.Day >= d.Day - 7 && e.People.Any(id => id == "player" || d.HumanIds.Contains(id))              && (d.CooperativeMembers <= 1 || !e.Id.StartsWith("human-")))              .OrderByDescending(e => e.Important).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`events.OrderBy(e => e.Day).Select(e => $"第{e.Day}天，{e.Title}：{e.Detail}")`；返回值紧邻使用处：`ArgumentSyntax: events.OrderBy(e => e.Day).Select(e => $"第{e.Day}天，{e.Title}：{e.Detail}")`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`events.SelectMany(e => e.People)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: events.SelectMany(e => e.People).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`d.Life.Events.Where(e => e.PostId.Length == 0 && e.Day < d.Day && e.Day >= d.Day - 7 && e.People.Any(id => id == "player" || d.HumanIds.Contains(id))              && (d.CooperativeMembers <= 1 || !e.Id.StartsWith("human-")))              .OrderByDescending(e => e.Important).ThenByDescending(e => e.Day).Take(4)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Events.Where(e => e.PostId.Length == 0 && e.Day < d.Day && e.Day >= d.Day - 7 && e.People.Any(id => id == "player" || d.HumanIds.Contains(id))              && (d.CooperativeMembers <= 1 || !e.Id.StartsWith("human-")))              .OrderByDescending(e => e.Important).ThenByDescending(e => e.Day).Take(4).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Life.Events.Where(e => e.PostId.Length == 0 && e.Day < d.Day && e.Day >= d.Day - 7 && e.People.Any(id => id == "player" || d.HumanIds.Contains(id))              && (d.CooperativeMembers <= 1 || !e.Id.StartsWith("human-")))              .OrderByDescending(e => e.Important).ThenByDescending(e => e.Day).Take(4).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Life.Events.Where(e => e.PostId.Length == 0 && e.Day < d.Day && e.Day >= d.Day - 7 && e.People.Any(id => id == "player" || d.HumanIds.Contains(id))              && (d.CooperativeMembers <= 1 || !e.Id.StartsWith("human-")))              .OrderByDescending(e => e.Important).ThenByDescending(e => e.Day).Take(4).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`events.SelectMany(e => e.People).Distinct().ToList()`；返回值紧邻使用处：`ArgumentSyntax: events.SelectMany(e => e.People).Distinct().ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Events.Where(e => e.PostId.Length == 0 && e.Day < d.Day && e.Day >= d.Day - 7 && e.People.Any(id => id == "player" || d.HumanIds.Contains(id))              && (d.CooperativeMembers <= 1 || !e.Id.StartsWith("human-")))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Events.Where(e => e.PostId.Length == 0 && e.Day < d.Day && e.Day >= d.Day - 7 && e.People.Any(id => id == "player" || d.HumanIds.Contains(id))              && (d.CooperativeMembers <= 1 || !e.Id.StartsWith("human-")))              .OrderByDescending`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`d.HumanIds.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: id == "player" || d.HumanIds.Contains(id)`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Life.Events.Where(e => e.PostId.Length == 0 && e.Day < d.Day && e.Day >= d.Day - 7 && e.People.Any(id => id == "player" || d.HumanIds.Contains(id))              && (d.CooperativeMembers <= 1 || !e.Id.StartsWith("human-")))              .OrderByDescending(e => e.Important).ThenByDescending(e => e.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Events.Where(e => e.PostId.Length == 0 && e.Day < d.Day && e.Day >= d.Day - 7 && e.People.Any(id => id == "player" || d.HumanIds.Contains(id))              && (d.CooperativeMembers <= 1 || !e.Id.StartsWith("human-")))              .OrderByDescending(e => e.Important).ThenByDescending(e => e.Day).Take`

**赋值（含属性/字段和局部值）：**

- `e.PostId` = `post.Id`

<a id="symbol-e7a1033e94a2"></a>

## `NationalSpire.CareerLife.Trim(NationalSpire.CareerData) — private static void Trim(CareerData d)`

来源：源码第 380 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Advance(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-62ec6434f115)

**调用：** `string.StartsWith(string)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；`System.Collections.Generic.List<T>.RemoveRange(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.CommunityMemories`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.Activities`；`NationalSpire.CareerLifeState.Events`；`NationalSpire.CommunityMemory.Day`；`NationalSpire.CommunityMemory.Id`；`NationalSpire.LifeActivity.Status`；`NationalSpire.LifeEvent.Day`；`NationalSpire.LifeEvent.EditionWeek`；`NationalSpire.LifeEvent.Important`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.StartsWith(string)`；输入表达式：`m.Id.StartsWith("life-fact:")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m => m.Id.StartsWith("life-fact:")`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`oldFacts.Contains(m.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: m => oldFacts.Contains(m.Id)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`d.Life.Activities.Where(a => a.Status is "可安排" or "进行中").Concat(d.Life.Activities.Where(a => a.Status == "已完成").TakeLast(48))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Activities.Where(a => a.Status is "可安排" or "进行中").Concat(d.Life.Activities.Where(a => a.Status == "已完成").TakeLast(48)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.CommunityMemories.Where(m => m.Id.StartsWith("life-fact:")).OrderByDescending(m => m.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.CommunityMemories.Where(m => m.Id.StartsWith("life-fact:")).OrderByDescending(m => m.Day).Skip`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.CommunityMemories.Where(m => m.Id.StartsWith("life-fact:")).OrderByDescending(m => m.Day).Skip(384).Select(m => m.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.CommunityMemories.Where(m => m.Id.StartsWith("life-fact:")).OrderByDescending(m => m.Day).Skip(384).Select(m => m.Id).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`d.CommunityMemories.Where(m => m.Id.StartsWith("life-fact:")).OrderByDescending(m => m.Day).Skip(384)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.CommunityMemories.Where(m => m.Id.StartsWith("life-fact:")).OrderByDescending(m => m.Day).Skip(384).Select`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`d.Life.Activities.Where(a => a.Status == "已完成").TakeLast(48)`；返回值紧邻使用处：`ArgumentSyntax: d.Life.Activities.Where(a => a.Status == "已完成").TakeLast(48)`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`d.CommunityMemories.Where(m => m.Id.StartsWith("life-fact:")).OrderByDescending(m => m.Day).Skip(384).Select(m => m.Id).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.CommunityMemories.Where(m => m.Id.StartsWith("life-fact:")).OrderByDescending(m => m.Day).Skip(384).Select(m => m.Id).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Life.Activities.Where(a => a.Status is "可安排" or "进行中").Concat(d.Life.Activities.Where(a => a.Status == "已完成").TakeLast(48)).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Life.Activities.Where(a => a.Status is "可安排" or "进行中").Concat(d.Life.Activities.Where(a => a.Status == "已完成").TakeLast(48)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.CommunityMemories.Where(m => m.Id.StartsWith("life-fact:"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.CommunityMemories.Where(m => m.Id.StartsWith("life-fact:")).OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Activities.Where(a => a.Status == "已完成")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Activities.Where(a => a.Status == "已完成").TakeLast`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Activities.Where(a => a.Status is "可安排" or "进行中")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Activities.Where(a => a.Status is "可安排" or "进行中").Concat`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`d.CommunityMemories.RemoveAll(m => oldFacts.Contains(m.Id))`；返回值紧邻使用处：`ExpressionStatementSyntax: d.CommunityMemories.RemoveAll(m => oldFacts.Contains(m.Id));`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`d.Life.Events.RemoveAll(e => e.Day < d.Day - 168 && (!e.Important || e.EditionWeek > 0))`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Life.Events.RemoveAll(e => e.Day < d.Day - 168 && (!e.Important || e.EditionWeek > 0));`
- `System.Collections.Generic.List<T>.RemoveRange(int, int)`；输入表达式：`d.Life.Events.RemoveRange(0, d.Life.Events.Count - 256)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Life.Events.RemoveRange(0, d.Life.Events.Count - 256);`

**赋值（含属性/字段和局部值）：**

- `d.Life.Activities` = `keep`
