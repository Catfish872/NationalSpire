# RandomEvents.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`53E05436C9C2C3633548739046AD3538F335367A55C798979C1CEDEE32ACC907`。来源：[源码](../../RandomEvents.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.RandomEvents`、`NationalSpire.RandomEventEffects`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly string[] Kinds = ["wallet", "fans", "clubFans", "item", "favour", "impression", "status", "learning", "market", "development", "challenge"];
```

<a id="symbol-b5cb3fa392ea"></a>

## `NationalSpire.RandomEvents.Next(NationalSpire.CareerData, int) — public static RandomEventRecord? Next(CareerData d, int through = int.MaxValue)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.AdvanceToDay(NationalSpire.CareerData, int, bool)`](CareerEngine.cs.md#symbol-0c04b8ec5f73)；[`NationalSpire.CareerScreen.ShowJourneyEncounter()`](EventJourneyScreen.cs.md#symbol-4e94d6a77974)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.RandomEvents`；`NationalSpire.RandomEventRecord.Day`；`NationalSpire.RandomEventRecord.State`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`d.Life.RandomEvents          .Where(e => e.Day >= d.Day && e.Day <= through && e.State is not ("complete" or "skipped"))          .OrderBy(e => e.Day).FirstOrDefault()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => d.Life.RandomEvents          .Where(e => e.Day >= d.Day && e.Day <= through && e.State is not ("complete" or "skipped"))          .OrderBy(e => e.Day).FirstOrDefault()`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Life.RandomEvents          .Where(e => e.Day >= d.Day && e.Day <= through && e.State is not ("complete" or "skipped"))          .OrderBy(e => e.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.RandomEvents          .Where(e => e.Day >= d.Day && e.Day <= through && e.State is not ("complete" or "skipped"))          .OrderBy(e => e.Day).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.RandomEvents          .Where(e => e.Day >= d.Day && e.Day <= through && e.State is not ("complete" or "skipped"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.RandomEvents          .Where(e => e.Day >= d.Day && e.Day <= through && e.State is not ("complete" or "skipped"))          .OrderBy`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3b62c8ad1ca6"></a>

## `NationalSpire.RandomEvents.Stop(NationalSpire.CareerData, string) — public static string? Stop(CareerData d, string id)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EventCommand(string, int, bool, string?, string?)`](RandomEventScreen.cs.md#symbol-07fb309a31aa)；[`NationalSpire.Coop.CoopRules.EventCommand(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.Coop.CoopCommand)`](Coop/CoopRandomEvents.cs.md#symbol-dde49f27790c)

**调用：** [`NationalSpire.AiService.CancelEvent(NationalSpire.CareerData, string)`](AiRandomEvents.cs.md#symbol-5e66dafe8706)；[`NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`](RandomEvents.cs.md#symbol-20d7a260dcab)

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.CancelEvent(NationalSpire.CareerData, string)`；`NationalSpire.RandomEventRecord.CustomOption`；`NationalSpire.RandomEventRecord.CustomState`；`NationalSpire.RandomEventRecord.Error`；`NationalSpire.RandomEventRecord.Options`；`NationalSpire.RandomEventRecord.State`；`NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.CancelEvent(NationalSpire.CareerData, string)`；输入表达式：`AiService.CancelEvent(d, id)`；返回值紧邻使用处：`ExpressionStatementSyntax: AiService.CancelEvent(d, id);`
- `NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`；输入表达式：`Find(d, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Find(d, id)`

**赋值（含属性/字段和局部值）：**

- `e.CustomState` = `e.CustomOption == null ? "idle" : "ready"`
- `e.Error` = `"生成已停止，可以重新生成或跳过。"`
- `e.State` = `e.Options.Count > 0 ? "ready" : "failed"`

<a id="symbol-3df9d24e1f2c"></a>

## `NationalSpire.RandomEvents.Ensure(NationalSpire.CareerData) — public static void Ensure(CareerData d)`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Ensure(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-eb417e39aebf)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.RandomEvents.RememberMatches(NationalSpire.CareerData)`](RandomEvents.cs.md#symbol-f818531770d4)；`NationalSpire.RandomEventRecord.RandomEventRecord()`；`System.Collections.Generic.IEnumerable<int>.Max()`；`System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Math.Max(int, int)`；`System.Random.Next(int, int)`；`System.Random.Random(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerLifeState.RandomEvents`；`NationalSpire.RandomEventRecord.Day`；`NationalSpire.RandomEventRecord.State`；`NationalSpire.RandomEvents.RememberMatches(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(d.WorldId + ":questions:" + day)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.StableHash(d.WorldId + ":questions:" + day)`
- `NationalSpire.RandomEventRecord.RandomEventRecord()`；输入表达式：`new() { Day = day }`；返回值紧邻使用处：`ArgumentSyntax: new() { Day = day }`
- `NationalSpire.RandomEvents.RememberMatches(NationalSpire.CareerData)`；输入表达式：`RememberMatches(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: RememberMatches(d);`
- `System.Collections.Generic.IEnumerable<int>.Max()`；输入表达式：`d.Life.RandomEvents.Select(e => e.Day + 1).DefaultIfEmpty(d.Day).Max()`；返回值紧邻使用处：`ArgumentSyntax: d.Life.RandomEvents.Select(e => e.Day + 1).DefaultIfEmpty(d.Day).Max()`
- `System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；输入表达式：`d.Life.RandomEvents.Select(e => e.Day + 1).DefaultIfEmpty(d.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.RandomEvents.Select(e => e.Day + 1).DefaultIfEmpty(d.Day).Max`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.Life.RandomEvents.Select(e => e.Day + 1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.RandomEvents.Select(e => e.Day + 1).DefaultIfEmpty`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.RandomEvents.Where(e => e.Day < d.Day && e.State is not ("complete" or "skipped"))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var e in d.Life.RandomEvents.Where(e => e.Day < d.Day && e.State is not ("complete" or "skipped"))) e.State = "skipped";`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Life.RandomEvents.Add(new() { Day = day })`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Life.RandomEvents.Add(new() { Day = day });`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(d.Day, d.Life.RandomEvents.Select(e => e.Day + 1).DefaultIfEmpty(d.Day).Max())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Max(d.Day, d.Life.RandomEvents.Select(e => e.Day + 1).DefaultIfEmpty(d.Day).Max())`
- `System.Random.Next(int, int)`；输入表达式：`random.Next(6, 11)`；返回值紧邻使用处：`AssignmentExpressionSyntax: day += random.Next(6, 11)`
- `System.Random.Random(int)`；输入表达式：`new Random(CareerEngine.StableHash(d.WorldId + ":questions:" + day))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Random(CareerEngine.StableHash(d.WorldId + ":questions:" + day))`

**赋值（含属性/字段和局部值）：**

- `day` += `random.Next(6, 11)`
- `Day` = `day`
- `e.State` = `"skipped"`

<a id="symbol-20d7a260dcab"></a>

## `NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string) — public static RandomEventRecord? Find(CareerData d, string id)`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.CreateTestSession(NationalSpire.CareerData, NationalSpire.PromptTestSource, string)`](PromptTesting.cs.md#symbol-c81f52ee7090)；[`NationalSpire.AiService.ProcessEventAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<NationalSpire.EventLive>?)`](AiRandomEvents.cs.md#symbol-5705d03a72b3)；[`NationalSpire.CareerScreen.OpenRandomEvent(string)`](RandomEventScreen.cs.md#symbol-b6a9dfbe8e4f)；[`NationalSpire.CareerScreen.RefreshRandomEvent()`](RandomEventScreen.cs.md#symbol-54853f1d507f)；[`NationalSpire.Coop.CoopRules.EventCommand(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.Coop.CoopCommand)`](Coop/CoopRandomEvents.cs.md#symbol-dde49f27790c)；[`NationalSpire.RandomEvents.Choose(NationalSpire.CareerData, string, int, bool)`](RandomEvents.cs.md#symbol-c0266703d306)；[`NationalSpire.RandomEvents.ChooseCustom(NationalSpire.CareerData, string, bool)`](RandomEvents.cs.md#symbol-c949f4a092a3)；[`NationalSpire.RandomEvents.Custom(NationalSpire.CareerData, string, string)`](RandomEvents.cs.md#symbol-b7d9c2f158f5)；[`NationalSpire.RandomEvents.Skip(NationalSpire.CareerData, string)`](RandomEvents.cs.md#symbol-9b570a0265e9)；[`NationalSpire.RandomEvents.Start(NationalSpire.CareerData, string)`](RandomEvents.cs.md#symbol-605db3348248)；[`NationalSpire.RandomEvents.Stop(NationalSpire.CareerData, string)`](RandomEvents.cs.md#symbol-3b62c8ad1ca6)；[`Save(NationalSpire.CareerData)`](Coop/CoopRandomEvents.cs.md#symbol-5bd2269a96bc)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerLifeState.RandomEvents`；`NationalSpire.RandomEventRecord.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.RandomEvents.FirstOrDefault(e => e.Id == id)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => d.Life.RandomEvents.FirstOrDefault(e => e.Id == id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-605db3348248"></a>

## `NationalSpire.RandomEvents.Start(NationalSpire.CareerData, string) — public static string? Start(CareerData d, string id)`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.CreateTestSession(NationalSpire.CareerData, NationalSpire.PromptTestSource, string)`](PromptTesting.cs.md#symbol-c81f52ee7090)；[`NationalSpire.CareerScreen.EventCommand(string, int, bool, string?, string?)`](RandomEventScreen.cs.md#symbol-07fb309a31aa)；[`NationalSpire.Coop.CoopRules.EventCommand(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.Coop.CoopCommand)`](Coop/CoopRandomEvents.cs.md#symbol-dde49f27790c)

**调用：** [`NationalSpire.AiService.EventBusy(NationalSpire.CareerData, string)`](AiRandomEvents.cs.md#symbol-a251022ff4b2)；[`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.EventPools.SelectRandom(NationalSpire.AiOptions, System.Collections.Generic.ISet<string>, System.Random)`](EventPools.cs.md#symbol-1c1bd4e75154)；[`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-24bc82bdbbd4)；[`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；[`NationalSpire.RandomEventPrompts.Materials(NationalSpire.CareerData, NationalSpire.RandomEventRecord)`](RandomEventPrompts.cs.md#symbol-a96ac205ab9d)；[`NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`](RandomEvents.cs.md#symbol-20d7a260dcab)；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Random.Next()`；`System.Random.Next(int)`；`System.Random.Random(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.Enabled`；`NationalSpire.AiService.EventBusy(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerLifeState.RandomEvents`；`NationalSpire.CareerPerson.Id`；`NationalSpire.EventPools.SelectRandom(NationalSpire.AiOptions, System.Collections.Generic.ISet<string>, System.Random)`；`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；`NationalSpire.RandomEventPrompts.Materials(NationalSpire.CareerData, NationalSpire.RandomEventRecord)`；`NationalSpire.RandomEventRecord.Category`；`NationalSpire.RandomEventRecord.CustomAction`；`NationalSpire.RandomEventRecord.CustomOption`；`NationalSpire.RandomEventRecord.CustomReasoning`；`NationalSpire.RandomEventRecord.CustomState`；`NationalSpire.RandomEventRecord.Day`；`NationalSpire.RandomEventRecord.Error`；`NationalSpire.RandomEventRecord.Id`；`NationalSpire.RandomEventRecord.Materials`；`NationalSpire.RandomEventRecord.People`；`NationalSpire.RandomEventRecord.Seed`；`NationalSpire.RandomEventRecord.State`；`NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`；`NationalSpire.RandomEventSeed.Category`；`NationalSpire.RandomEventSeed.Detail`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.EventBusy(NationalSpire.CareerData, string)`；输入表达式：`AiService.EventBusy(d, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: e.State is "complete" or "skipped" || AiService.EventBusy(d, id)`
- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(d.WorldId + ":event:" + e.Id)`；返回值紧邻使用处：`ArgumentSyntax: CareerEngine.StableHash(d.WorldId + ":event:" + e.Id)`
- `NationalSpire.EventPools.SelectRandom(NationalSpire.AiOptions, System.Collections.Generic.ISet<string>, System.Random)`；输入表达式：`EventPools.SelectRandom(d.Ai, used, random)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = EventPools.SelectRandom(d.Ai, used, random)`
- `NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.IsHuman(d, p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GroupChats.IsHuman(d, p.Id)`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(d, p.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: !GroupChats.IsHuman(d, p.Id) && PrivateMessages.CanChat(d, p.Id)`
- `NationalSpire.RandomEventPrompts.Materials(NationalSpire.CareerData, NationalSpire.RandomEventRecord)`；输入表达式：`RandomEventPrompts.Materials(d, e)`；返回值紧邻使用处：`AssignmentExpressionSyntax: e.Materials = RandomEventPrompts.Materials(d, e)`
- `NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`；输入表达式：`Find(d, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Find(d, id)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.People.Where(p => !GroupChats.IsHuman(d, p.Id) && PrivateMessages.CanChat(d, p.Id)).OrderBy(_ => random.Next())`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => !GroupChats.IsHuman(d, p.Id) && PrivateMessages.CanChat(d, p.Id)).OrderBy(_ => random.Next()).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.Life.RandomEvents.Where(x => x.Seed.Length > 0).TakeLast(24).Select(x => x.Seed)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.RandomEvents.Where(x => x.Seed.Length > 0).TakeLast(24).Select(x => x.Seed).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.People.Where(p => !GroupChats.IsHuman(d, p.Id) && PrivateMessages.CanChat(d, p.Id)).OrderBy(_ => random.Next()).Take(random.Next(4)).Select(p => p.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => !GroupChats.IsHuman(d, p.Id) && PrivateMessages.CanChat(d, p.Id)).OrderBy(_ => random.Next()).Take(random.Next(4)).Select(p => p.Id).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`d.People.Where(p => !GroupChats.IsHuman(d, p.Id) && PrivateMessages.CanChat(d, p.Id)).OrderBy(_ => random.Next()).Take(random.Next(4))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => !GroupChats.IsHuman(d, p.Id) && PrivateMessages.CanChat(d, p.Id)).OrderBy(_ => random.Next()).Take(random.Next(4)).Select`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`d.Life.RandomEvents.Where(x => x.Seed.Length > 0).TakeLast(24)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.RandomEvents.Where(x => x.Seed.Length > 0).TakeLast(24).Select`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`d.Life.RandomEvents.Where(x => x.Seed.Length > 0).TakeLast(24).Select(x => x.Seed).ToHashSet()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Life.RandomEvents.Where(x => x.Seed.Length > 0).TakeLast(24).Select(x => x.Seed).ToHashSet()`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.People.Where(p => !GroupChats.IsHuman(d, p.Id) && PrivateMessages.CanChat(d, p.Id)).OrderBy(_ => random.Next()).Take(random.Next(4)).Select(p => p.Id).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: e.People = d.People.Where(p => !GroupChats.IsHuman(d, p.Id) && PrivateMessages.CanChat(d, p.Id)).OrderBy(_ => random.Next()).Take(random.Next(4)).Select(p => p.Id).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.RandomEvents.Where(x => x.Seed.Length > 0)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.RandomEvents.Where(x => x.Seed.Length > 0).TakeLast`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p => !GroupChats.IsHuman(d, p.Id) && PrivateMessages.CanChat(d, p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => !GroupChats.IsHuman(d, p.Id) && PrivateMessages.CanChat(d, p.Id)).OrderBy`
- `System.Random.Next()`；输入表达式：`random.Next()`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: _ => random.Next()`
- `System.Random.Next(int)`；输入表达式：`random.Next(4)`；返回值紧邻使用处：`ArgumentSyntax: random.Next(4)`
- `System.Random.Random(int)`；输入表达式：`new Random(CareerEngine.StableHash(d.WorldId + ":event:" + e.Id))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Random(CareerEngine.StableHash(d.WorldId + ":event:" + e.Id))`

**赋值（含属性/字段和局部值）：**

- `e.Category` = `selected.Category`
- `e.CustomAction` = `""`
- `e.CustomOption` = `null`
- `e.CustomReasoning` = `""`
- `e.CustomState` = `"idle"`
- `e.Error` = `""`
- `e.Materials` = `RandomEventPrompts.Materials(d, e)`
- `e.People` = `d.People.Where(p => !GroupChats.IsHuman(d, p.Id) && PrivateMessages.CanChat(d, p.Id)).OrderBy(_ => random.Next()).Take(random.Next(4)).Select(p => p.Id).ToList()`
- `e.Seed` = `selected.Detail`
- `e.State` = `"generating"`

<a id="symbol-b7d9c2f158f5"></a>

## `NationalSpire.RandomEvents.Custom(NationalSpire.CareerData, string, string) — public static string? Custom(CareerData d, string id, string action)`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EventCommand(string, int, bool, string?, string?)`](RandomEventScreen.cs.md#symbol-07fb309a31aa)；[`NationalSpire.Coop.CoopRules.EventCommand(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.Coop.CoopCommand)`](Coop/CoopRandomEvents.cs.md#symbol-dde49f27790c)

**调用：** [`NationalSpire.AiService.EventBusy(NationalSpire.CareerData, string)`](AiRandomEvents.cs.md#symbol-a251022ff4b2)；[`NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`](RandomEvents.cs.md#symbol-20d7a260dcab)；`string.IsNullOrWhiteSpace(string?)`；`string.Trim()`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.Enabled`；`NationalSpire.AiService.EventBusy(NationalSpire.CareerData, string)`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerData.Day`；`NationalSpire.RandomEventRecord.CustomAction`；`NationalSpire.RandomEventRecord.CustomOption`；`NationalSpire.RandomEventRecord.CustomState`；`NationalSpire.RandomEventRecord.Day`；`NationalSpire.RandomEventRecord.Error`；`NationalSpire.RandomEventRecord.State`；`NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.EventBusy(NationalSpire.CareerData, string)`；输入表达式：`AiService.EventBusy(d, id)`；返回值紧邻使用处：`IfStatementSyntax: if (AiService.EventBusy(d, id)) return "当前内容正在生成。";`
- `NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`；输入表达式：`Find(d, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Find(d, id)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(action)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(action)) return "请填写你的行动。";`
- `string.Trim()`；输入表达式：`action.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: action = action.Trim()`

**赋值（含属性/字段和局部值）：**

- `action` = `action.Trim()`
- `e.CustomAction` = `action`
- `e.CustomOption` = `null`
- `e.CustomState` = `"generating"`
- `e.Error` = `""`

<a id="symbol-c949f4a092a3"></a>

## `NationalSpire.RandomEvents.ChooseCustom(NationalSpire.CareerData, string, bool) — public static string? ChooseCustom(CareerData d, string id, bool publicly)`

来源：源码第 59 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EventCommand(string, int, bool, string?, string?)`](RandomEventScreen.cs.md#symbol-07fb309a31aa)；[`NationalSpire.Coop.CoopRules.EventCommand(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.Coop.CoopCommand)`](Coop/CoopRandomEvents.cs.md#symbol-dde49f27790c)

**调用：** [`NationalSpire.RandomEventEffects.Check(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-09ecc3f9af33)；[`NationalSpire.RandomEvents.Choose(NationalSpire.CareerData, string, int, bool)`](RandomEvents.cs.md#symbol-c0266703d306)；[`NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`](RandomEvents.cs.md#symbol-20d7a260dcab)；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.RandomEventEffects.Check(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`；`NationalSpire.RandomEventRecord.CustomOption`；`NationalSpire.RandomEventRecord.CustomState`；`NationalSpire.RandomEventRecord.Options`；`NationalSpire.RandomEventRecord.State`；`NationalSpire.RandomEvents.Choose(NationalSpire.CareerData, string, int, bool)`；`NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RandomEventEffects.Check(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`；输入表达式：`RandomEventEffects.Check(d, e, option)`；返回值紧邻使用处：`IsPatternExpressionSyntax: RandomEventEffects.Check(d, e, option) is { } error`
- `NationalSpire.RandomEvents.Choose(NationalSpire.CareerData, string, int, bool)`；输入表达式：`Choose(d, id, e.Options.Count - 1, publicly)`；返回值紧邻使用处：`ReturnStatementSyntax: return Choose(d, id, e.Options.Count - 1, publicly);`
- `NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`；输入表达式：`Find(d, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Find(d, id)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`e.Options.Add(option)`；返回值紧邻使用处：`ExpressionStatementSyntax: e.Options.Add(option);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9b570a0265e9"></a>

## `NationalSpire.RandomEvents.Skip(NationalSpire.CareerData, string) — public static string? Skip(CareerData d, string id)`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EventCommand(string, int, bool, string?, string?)`](RandomEventScreen.cs.md#symbol-07fb309a31aa)；[`NationalSpire.CareerScreen.ShowJourneyEncounter()`](EventJourneyScreen.cs.md#symbol-4e94d6a77974)；[`NationalSpire.Coop.CoopRules.EventCommand(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.Coop.CoopCommand)`](Coop/CoopRandomEvents.cs.md#symbol-dde49f27790c)

**调用：** [`NationalSpire.AiService.CancelEvent(NationalSpire.CareerData, string)`](AiRandomEvents.cs.md#symbol-5e66dafe8706)；[`NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`](RandomEvents.cs.md#symbol-20d7a260dcab)

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.CancelEvent(NationalSpire.CareerData, string)`；`NationalSpire.RandomEventRecord.CustomOption`；`NationalSpire.RandomEventRecord.CustomState`；`NationalSpire.RandomEventRecord.State`；`NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.CancelEvent(NationalSpire.CareerData, string)`；输入表达式：`AiService.CancelEvent(d, id)`；返回值紧邻使用处：`ExpressionStatementSyntax: AiService.CancelEvent(d, id);`
- `NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`；输入表达式：`Find(d, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Find(d, id)`

**赋值（含属性/字段和局部值）：**

- `e.CustomState` = `e.CustomOption == null ? "idle" : "ready"`
- `e.State` = `"skipped"`

<a id="symbol-c0266703d306"></a>

## `NationalSpire.RandomEvents.Choose(NationalSpire.CareerData, string, int, bool) — public static string? Choose(CareerData d, string id, int index, bool publicly)`

来源：源码第 74 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EventCommand(string, int, bool, string?, string?)`](RandomEventScreen.cs.md#symbol-07fb309a31aa)；[`NationalSpire.Coop.CoopRules.EventCommand(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopMember, NationalSpire.Coop.CoopCommand)`](Coop/CoopRandomEvents.cs.md#symbol-dde49f27790c)；[`NationalSpire.RandomEvents.ChooseCustom(NationalSpire.CareerData, string, bool)`](RandomEvents.cs.md#symbol-c949f4a092a3)

**调用：** [`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`](CareerLife.cs.md#symbol-0ea81cb3e558)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.RandomEventEffects.Apply(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-886f350e91dc)；[`NationalSpire.RandomEventEffects.Check(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-09ecc3f9af33)；[`NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`](RandomEvents.cs.md#symbol-20d7a260dcab)；[`NationalSpire.RandomEvents.Remember(NationalSpire.CareerData, NationalSpire.RandomEventRecord, string, string)`](RandomEvents.cs.md#symbol-e25f0d98c349)；`string.Trim()`；`System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.RandomEventEffects.Apply(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`；`NationalSpire.RandomEventEffects.Check(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`；`NationalSpire.RandomEventEffects.Person(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>)`；`NationalSpire.RandomEventOption.Effects`；`NationalSpire.RandomEventOption.Result`；`NationalSpire.RandomEventOption.Text`；`NationalSpire.RandomEventRecord.CustomState`；`NationalSpire.RandomEventRecord.Id`；`NationalSpire.RandomEventRecord.Options`；`NationalSpire.RandomEventRecord.People`；`NationalSpire.RandomEventRecord.Public`；`NationalSpire.RandomEventRecord.Selected`；`NationalSpire.RandomEventRecord.State`；`NationalSpire.RandomEventRecord.Story`；`NationalSpire.RandomEventRecord.Title`；`NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`；`NationalSpire.RandomEvents.Remember(NationalSpire.CareerData, NationalSpire.RandomEventRecord, string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；输入表达式：`CareerLife.AddEvent(d, "question:" + e.Id, "人物日常", e.Title, fact, e.People.Append(GroupChats.Human(d)).Distinct().ToList())`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerLife.AddEvent(d, "question:" + e.Id, "人物日常", e.Title, fact, e.People.Append(GroupChats.Human(d)).Distinct().ToList());`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(d)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Human(d)`
- `NationalSpire.RandomEventEffects.Apply(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`；输入表达式：`RandomEventEffects.Apply(d, e, option)`；返回值紧邻使用处：`ExpressionStatementSyntax: RandomEventEffects.Apply(d, e, option);`
- `NationalSpire.RandomEventEffects.Check(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`；输入表达式：`RandomEventEffects.Check(d, e, option)`；返回值紧邻使用处：`IsPatternExpressionSyntax: RandomEventEffects.Check(d, e, option) is { } error`
- `NationalSpire.RandomEvents.Find(NationalSpire.CareerData, string)`；输入表达式：`Find(d, id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Find(d, id)`
- `NationalSpire.RandomEvents.Remember(NationalSpire.CareerData, NationalSpire.RandomEventRecord, string, string)`；输入表达式：`Remember(d, e, e.Id, fact)`；返回值紧邻使用处：`ExpressionStatementSyntax: Remember(d, e, e.Id, fact);`
- `string.Trim()`；输入表达式：`e.Story.Trim()`；返回值紧邻使用处：`BinaryExpressionSyntax: e.Story.Trim() + "\n玩家选择："`
- `System.Collections.Generic.IEnumerable<TSource>.Append<TSource>(TSource)`；输入表达式：`e.People.Append(GroupChats.Human(d))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: e.People.Append(GroupChats.Human(d)).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`e.People.Append(GroupChats.Human(d)).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: e.People.Append(GroupChats.Human(d)).Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`option.Effects.Select(RandomEventEffects.Person)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: option.Effects.Select(RandomEventEffects.Person).Where`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`e.People.Append(GroupChats.Human(d)).Distinct().ToList()`；返回值紧邻使用处：`ArgumentSyntax: e.People.Append(GroupChats.Human(d)).Distinct().ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`option.Effects.Select(RandomEventEffects.Person).Where(id => id.Length > 0)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string person in option.Effects.Select(RandomEventEffects.Person).Where(id => id.Length > 0))              if (!e.People.Contains(person)) e.People.Add(person);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`e.People.Add(person)`；返回值紧邻使用处：`ExpressionStatementSyntax: e.People.Add(person);`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`e.People.Contains(person)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !e.People.Contains(person)`

**赋值（含属性/字段和局部值）：**

- `e.Public` = `publicly`
- `e.Selected` = `index`
- `e.State` = `"complete"`

<a id="symbol-e25f0d98c349"></a>

## `NationalSpire.RandomEvents.Remember(NationalSpire.CareerData, NationalSpire.RandomEventRecord, string, string) — private static void Remember(CareerData d, RandomEventRecord e, string id, string fact)`

来源：源码第 91 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.RandomEvents.Choose(NationalSpire.CareerData, string, int, bool)`](RandomEvents.cs.md#symbol-c0266703d306)；[`NationalSpire.RandomEvents.RememberMatches(NationalSpire.CareerData)`](RandomEvents.cs.md#symbol-f818531770d4)

**调用：** [`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；[`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-26060b09ab4b)；[`NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-c362351c7a43)；[`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`NationalSpire.PrivateConversation.PrivateConversation()`；`NationalSpire.PrivateTurn.PrivateTurn()`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Prepend<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Season`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；`NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`；`NationalSpire.PrivateConversation.EventOnly`；`NationalSpire.PrivateConversation.MemoryRevision`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateTurn.Applied`；`NationalSpire.PrivateTurn.Day`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.ReplyOrder`；`NationalSpire.PrivateTurn.RequestKind`；`NationalSpire.PrivateTurn.Season`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.User`；`NationalSpire.PrivateTurn.UserOrder`；`NationalSpire.RandomEventRecord.People`；`NationalSpire.RandomEventRecord.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(d)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Human(d)`
- `NationalSpire.GroupChats.Name(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.Name(d, p)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => GroupChats.Name(d, p)`
- `NationalSpire.GroupChats.NextOrder(NationalSpire.CareerData)`；输入表达式：`GroupChats.NextOrder(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GroupChats.NextOrder(d)`
- `NationalSpire.PrivateConversation.PrivateConversation()`；输入表达式：`new() { PersonId = person, EventOnly = true }`；返回值紧邻使用处：`AssignmentExpressionSyntax: c = new() { PersonId = person, EventOnly = true }`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(d, p)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => PrivateMessages.CanChat(d, p)`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Mailbox(d)`
- `NationalSpire.PrivateTurn.PrivateTurn()`；输入表达式：`new() { Id = "event:" + id, Day = d.Day, Season = d.Season, UserOrder = order, ReplyOrder = order,                  RequestKind = "event", User = source + "\n" + fact, Reply = "", ReplyDeleted = true, Status = "complete", Applied = true }`；返回值紧邻使用处：`ArgumentSyntax: new() { Id = "event:" + id, Day = d.Day, Season = d.Season, UserOrder = order, ReplyOrder = order,                  RequestKind = "event", User = source + "\n" + fact, Reply = "", ReplyDeleted = true, Status = "complete", Applied = true }`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", e.People.Prepend(GroupChats.Human(d)).Select(p => GroupChats.Name(d, p)))`；返回值紧邻使用处：`BinaryExpressionSyntax: "随机事件 · " + e.Title + "；参与者：" + string.Join("、", e.People.Prepend(GroupChats.Human(d)).Select(p => GroupChats.Name(d, p)))`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`box.Conversations.TryGetValue(person, out var c)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !box.Conversations.TryGetValue(person, out var c)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.Any(t => t.Id == "event:" + id)`；返回值紧邻使用处：`IfStatementSyntax: if (c.Turns.Any(t => t.Id == "event:" + id)) continue;`
- `System.Collections.Generic.IEnumerable<TSource>.Prepend<TSource>(TSource)`；输入表达式：`e.People.Prepend(GroupChats.Human(d))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: e.People.Prepend(GroupChats.Human(d)).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`e.People.Prepend(GroupChats.Human(d)).Select(p => GroupChats.Name(d, p))`；返回值紧邻使用处：`ArgumentSyntax: e.People.Prepend(GroupChats.Human(d)).Select(p => GroupChats.Name(d, p))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`e.People.Where(p => PrivateMessages.CanChat(d, p))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string person in e.People.Where(p => PrivateMessages.CanChat(d, p)))          {              var box = PrivateMessages.Mailbox(d);              if (!box.Conversations.TryGetValue(person, out var c)) box.Conversations[person] = c = new() { PersonId = person, EventOnly = true };              if (c.Turns.Any(t => t.Id == "event:" + id)) continue;              c.Turns.Add(new() { Id = "event:" + id, Day = d.Day, Season = d.Season, UserOrder = order, ReplyOrder = order,                  RequestKind = "event", User = source + "\n" + fact, Reply = "", ReplyDeleted = true, Status = "complete", Applied = true });              c.MemoryRevision++;          }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.Turns.Add(new() { Id = "event:" + id, Day = d.Day, Season = d.Season, UserOrder = order, ReplyOrder = order,                  RequestKind = "event", User = source + "\n" + fact, Reply = "", ReplyDeleted = true, Status = "complete", Applied = true })`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Turns.Add(new() { Id = "event:" + id, Day = d.Day, Season = d.Season, UserOrder = order, ReplyOrder = order,                  RequestKind = "event", User = source + "\n" + fact, Reply = "", ReplyDeleted = true, Status = "complete", Applied = true });`

**赋值（含属性/字段和局部值）：**

- `Applied` = `true`
- `box.Conversations[person]` = `c = new() { PersonId = person, EventOnly = true }`
- `c` = `new() { PersonId = person, EventOnly = true }`
- `Day` = `d.Day`
- `EventOnly` = `true`
- `Id` = `"event:" + id`
- `PersonId` = `person`
- `Reply` = `""`
- `ReplyDeleted` = `true`
- `ReplyOrder` = `order`
- `RequestKind` = `"event"`
- `Season` = `d.Season`
- `Status` = `"complete"`
- `User` = `source + "\n" + fact`
- `UserOrder` = `order`

<a id="symbol-f818531770d4"></a>

## `NationalSpire.RandomEvents.RememberMatches(NationalSpire.CareerData) — public static void RememberMatches(CareerData d)`

来源：源码第 105 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.RandomEvents.Ensure(NationalSpire.CareerData)`](RandomEvents.cs.md#symbol-3df9d24e1f2c)

**调用：** [`NationalSpire.MatchRules.Time(double?)`](MatchRules.cs.md#symbol-13ecc28f8403)；[`NationalSpire.RandomEvents.Remember(NationalSpire.CareerData, NationalSpire.RandomEventRecord, string, string)`](RandomEvents.cs.md#symbol-e25f0d98c349)；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.HashSet<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerLifeState.RandomEvents`；`NationalSpire.CareerMatch.Draw`；`NationalSpire.CareerMatch.Event`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.PlayerFloor`；`NationalSpire.CareerMatch.PlayerSeconds`；`NationalSpire.CareerMatch.PlayerWon`；`NationalSpire.CareerMatch.Status`；`NationalSpire.MatchRules.Time(double?)`；`NationalSpire.RandomEventRecord.MatchIds`；`NationalSpire.RandomEventRecord.RememberedMatches`；`NationalSpire.RandomEventRecord.State`；`NationalSpire.RandomEvents.Remember(NationalSpire.CareerData, NationalSpire.RandomEventRecord, string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MatchRules.Time(double?)`；输入表达式：`MatchRules.Time(match.PlayerSeconds.Value)`；返回值紧邻使用处：`InterpolationSyntax: {MatchRules.Time(match.PlayerSeconds.Value)}`
- `NationalSpire.RandomEvents.Remember(NationalSpire.CareerData, NationalSpire.RandomEventRecord, string, string)`；输入表达式：`Remember(d, e, id, text)`；返回值紧邻使用处：`ExpressionStatementSyntax: Remember(d, e, id, text);`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`e.RememberedMatches.Add(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: e.RememberedMatches.Add(id);`
- `System.Collections.Generic.HashSet<T>.Contains(T)`；输入表达式：`e.RememberedMatches.Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !e.RememberedMatches.Contains(id)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.FirstOrDefault(m => m.Id == id && m.Status is not ("待赛" or "进行中"))`；返回值紧邻使用处：`IsPatternExpressionSyntax: d.Matches.FirstOrDefault(m => m.Id == id && m.Status is not ("待赛" or "进行中")) is { } match`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.RandomEvents.Where(e => e.State == "complete" && e.MatchIds.Count > e.RememberedMatches.Count)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var e in d.Life.RandomEvents.Where(e => e.State == "complete" && e.MatchIds.Count > e.RememberedMatches.Count))              foreach (string id in e.MatchIds.Where(id => !e.RememberedMatches.Contains(id)))                  if (d.Matches.FirstOrDefault(m => m.Id == id && m.Status is not ("待赛" or "进行中")) is { } match)                  {                      string text = $"由事件约定的{match.Event}：{match.Status}。";                      if (match.PlayerSeconds.HasValue) text += $"玩家{(match.PlayerWon ? "获胜" : match.Draw ? "平局" : "失利")}，到达{match.PlayerFloor}层，用时{MatchRules.Time(match.PlayerSeconds.Value)}。";                      Remember(d, e, id, text); e.RememberedMatches.Add(id);                  }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`e.MatchIds.Where(id => !e.RememberedMatches.Contains(id))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string id in e.MatchIds.Where(id => !e.RememberedMatches.Contains(id)))                  if (d.Matches.FirstOrDefault(m => m.Id == id && m.Status is not ("待赛" or "进行中")) is { } match)                  {                      string text = $"由事件约定的{match.Event}：{match.Status}。";                      if (match.PlayerSeconds.HasValue) text += $"玩家{(match.PlayerWon ? "获胜" : match.Draw ? "平局" : "失利")}，到达{match.PlayerFloor}层，用时{MatchRules.Time(match.PlayerSeconds.Value)}。";                      Remember(d, e, id, text); e.RememberedMatches.Add(id);                  }`

**赋值（含属性/字段和局部值）：**

- `text` += `$"玩家{(match.PlayerWon ? "获胜" : match.Draw ? "平局" : "失利")}，到达{match.PlayerFloor}层，用时{MatchRules.Time(match.PlayerSeconds.Value)}。"`

<a id="symbol-4907ebeabb94"></a>

## `NationalSpire.RandomEventEffects.Kind(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>) — public static string Kind(Dictionary<string, JsonElement> e)`

来源：源码第 121 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.Diagnostics.RecordEventCheck(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption, string)`](EventDiagnostics.cs.md#symbol-cb8ce43827bb)；[`NationalSpire.RandomEventEffects.Apply(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-886f350e91dc)；[`NationalSpire.RandomEventEffects.CheckEffects(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-1a41c3fc699a)；[`NationalSpire.RandomEventEffects.Person(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>)`](RandomEvents.cs.md#symbol-4c2ca1a5a966)；[`NationalSpire.RandomEventEffects.Preview(NationalSpire.CareerData, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-de44eea7b389)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.RandomEventEffects.Kinds`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`Kinds.FirstOrDefault(e.ContainsKey)`；返回值紧邻使用处：`BinaryExpressionSyntax: Kinds.FirstOrDefault(e.ContainsKey) ?? ""`

**赋值（含属性/字段和局部值）：**


<a id="symbol-534439b11d45"></a>

## `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string) — private static decimal Number(Dictionary<string, JsonElement> e, string key)`

来源：源码第 122 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.RandomEventEffects.Apply(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-886f350e91dc)；[`NationalSpire.RandomEventEffects.CheckEffects(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-1a41c3fc699a)；[`NationalSpire.RandomEventEffects.Preview(NationalSpire.CareerData, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-de44eea7b389)

**调用：** `decimal.Parse(string, System.IFormatProvider?)`；`System.Text.Json.JsonElement.GetDecimal()`；`System.Text.Json.JsonElement.GetString()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.Parse(string, System.IFormatProvider?)`；输入表达式：`decimal.Parse(e[key].GetString()!, System.Globalization.CultureInfo.InvariantCulture)`；返回值紧邻使用处：`ConditionalExpressionSyntax: e[key].ValueKind == JsonValueKind.Number ? e[key].GetDecimal()          : decimal.Parse(e[key].GetString()!, System.Globalization.CultureInfo.InvariantCulture)`
- `System.Text.Json.JsonElement.GetDecimal()`；输入表达式：`e[key].GetDecimal()`；返回值紧邻使用处：`ConditionalExpressionSyntax: e[key].ValueKind == JsonValueKind.Number ? e[key].GetDecimal()          : decimal.Parse(e[key].GetString()!, System.Globalization.CultureInfo.InvariantCulture)`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`e[key].GetString()`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: e[key].GetString()!`

**赋值（含属性/字段和局部值）：**


<a id="symbol-dc6f7fe803ad"></a>

## `NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string) — private static string Text(Dictionary<string, JsonElement> e, string key)`

来源：源码第 124 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.RandomEventEffects.Apply(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-886f350e91dc)；[`NationalSpire.RandomEventEffects.CheckEffects(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-1a41c3fc699a)；[`NationalSpire.RandomEventEffects.Person(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>)`](RandomEvents.cs.md#symbol-4c2ca1a5a966)；[`NationalSpire.RandomEventEffects.Preview(NationalSpire.CareerData, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-de44eea7b389)

**调用：** `System.Text.Json.JsonElement.GetString()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Text.Json.JsonElement.GetString()`；输入表达式：`e[key].GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: e[key].GetString() ?? ""`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4c2ca1a5a966"></a>

## `NationalSpire.RandomEventEffects.Person(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>) — internal static string Person(Dictionary<string, JsonElement> e)`

来源：源码第 125 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.RandomEventEffects.CheckEffects(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-1a41c3fc699a)；[`NationalSpire.RandomEventEffects.Preview(NationalSpire.CareerData, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-de44eea7b389)

**调用：** [`NationalSpire.RandomEventEffects.Kind(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>)`](RandomEvents.cs.md#symbol-4907ebeabb94)；[`NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`](RandomEvents.cs.md#symbol-dc6f7fe803ad)

**字段、属性、事件及方法组引用：** `NationalSpire.RandomEventEffects.Kind(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>)`；`NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RandomEventEffects.Kind(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>)`；输入表达式：`Kind(e)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Kind(e)`
- `NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Text(e, kind)`；返回值紧邻使用处：`ConditionalExpressionSyntax: kind is "favour" or "impression" or "status" or "learning" or "challenge" ? Text(e, kind) : ""`

**赋值（含属性/字段和局部值）：**


<a id="symbol-09ecc3f9af33"></a>

## `NationalSpire.RandomEventEffects.Check(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption) — public static string? Check(CareerData d, RandomEventRecord record, RandomEventOption option)`

来源：源码第 130 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EventStoryView.Display(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.EventLive?, bool)`](RandomEventScreen.cs.md#symbol-f847e9f29b0e)；[`NationalSpire.EventStoryView.DisplayCustom(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.EventLive?, bool)`](RandomEventCustomScreen.cs.md#symbol-e43ecd579917)；[`NationalSpire.RandomEvents.Choose(NationalSpire.CareerData, string, int, bool)`](RandomEvents.cs.md#symbol-c0266703d306)；[`NationalSpire.RandomEvents.ChooseCustom(NationalSpire.CareerData, string, bool)`](RandomEvents.cs.md#symbol-c949f4a092a3)

**调用：** [`NationalSpire.Diagnostics.RecordEventCheck(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption, string)`](EventDiagnostics.cs.md#symbol-cb8ce43827bb)；[`NationalSpire.RandomEventEffects.CheckEffects(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-1a41c3fc699a)

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.RecordEventCheck(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption, string)`；`NationalSpire.RandomEventEffects.CheckEffects(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.RecordEventCheck(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption, string)`；输入表达式：`Diagnostics.RecordEventCheck(d, record, option, error)`；返回值紧邻使用处：`ExpressionStatementSyntax: Diagnostics.RecordEventCheck(d, record, option, error);`
- `NationalSpire.RandomEventEffects.CheckEffects(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`；输入表达式：`CheckEffects(d, record, option)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CheckEffects(d, record, option)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1a41c3fc699a"></a>

## `NationalSpire.RandomEventEffects.CheckEffects(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption) — private static string? CheckEffects(CareerData d, RandomEventRecord record, RandomEventOption option)`

来源：源码第 136 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.RandomEventEffects.Check(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-09ecc3f9af33)

**调用：** [`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`](LifeData.cs.md#symbol-de5af63fa4e7)；[`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；[`NationalSpire.GameCalendar.Season(NationalSpire.CareerData, int)`](GameCalendar.cs.md#symbol-c5c99167e359)；[`NationalSpire.GameCalendar.TryDay(NationalSpire.CareerData, string?, out int)`](GameCalendar.cs.md#symbol-ca512729a156)；[`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-8c9ea9f33c3c)；[`NationalSpire.PrivateAppointments.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-e7f8b7355ddf)；[`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；[`NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-13f25fec3dea)；[`NationalSpire.RandomEventEffects.Kind(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>)`](RandomEvents.cs.md#symbol-4907ebeabb94)；[`NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`](RandomEvents.cs.md#symbol-534439b11d45)；[`NationalSpire.RandomEventEffects.Person(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>)`](RandomEvents.cs.md#symbol-4c2ca1a5a966)；[`NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`](RandomEvents.cs.md#symbol-dc6f7fe803ad)；[`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-0f707d2c9895)；`decimal.Truncate(decimal)`；`NationalSpire.PrivateOffer.PrivateOffer()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Fans`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.Market`；`NationalSpire.CareerLifeState.Consumer`；`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；`NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.ConsumerState.Goods`；`NationalSpire.EsportsCareer.Nations`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.GameCalendar.Season(NationalSpire.CareerData, int)`；`NationalSpire.GameCalendar.TryDay(NationalSpire.CareerData, string?, out int)`；`NationalSpire.Good.Collectible`；`NationalSpire.MarketState.Quotes`；`NationalSpire.NationalLegacy.Country`；`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；`NationalSpire.OwnedClubState.Fans`；`NationalSpire.OwnedGood.Consumed`；`NationalSpire.OwnedGood.Id`；`NationalSpire.OwnedGood.Quantity`；`NationalSpire.PrivateAppointments.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；`NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Ascension`；`NationalSpire.PrivateOffer.Day`；`NationalSpire.PrivateOffer.Mode`；`NationalSpire.PrivateOffer.Season`；`NationalSpire.RandomEventEffects.Kind(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>)`；`NationalSpire.RandomEventEffects.Kinds`；`NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；`NationalSpire.RandomEventEffects.Person(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>)`；`NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；`NationalSpire.RandomEventOption.Effects`；`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.Truncate(decimal)`；输入表达式：`decimal.Truncate(count)`；返回值紧邻使用处：`BinaryExpressionSyntax: count != decimal.Truncate(count)`
- `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；输入表达式：`CareerMoney.Balance(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerMoney.Balance(d) * 10`
- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(good)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: ConsumerCatalog.Get(good)?.Collectible`
- `NationalSpire.GameCalendar.Season(NationalSpire.CareerData, int)`；输入表达式：`GameCalendar.Season(d, day)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Season = GameCalendar.Season(d, day)`
- `NationalSpire.GameCalendar.TryDay(NationalSpire.CareerData, string?, out int)`；输入表达式：`GameCalendar.TryDay(d, Text(e, "date"), out int day)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GameCalendar.TryDay(d, Text(e, "date"), out int day)`
- `NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.IsOwner(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !OwnedClubs.IsOwner(d)`
- `NationalSpire.PrivateAppointments.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Error(d, Text(e, kind), new() { Season = GameCalendar.Season(d, day), Day = SeasonCalendar.Day(d, day), Ascension = (int)Number(e, "ascension"), Mode = Text(e, "mode") })`；返回值紧邻使用处：`IsPatternExpressionSyntax: PrivateAppointments.Error(d, Text(e, kind), new() { Season = GameCalendar.Season(d, day), Day = SeasonCalendar.Day(d, day), Ascension = (int)Number(e, "ascension"), Mode = Text(e, "mode") }) is { } invalid`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(d, Person(e))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateMessages.CanChat(d, Person(e))`
- `NationalSpire.PrivateMessages.Favour(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Favour(d, Text(e, kind))`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateMessages.Favour(d, Text(e, kind)) + (int)Number(e, "value")`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new() { Season = GameCalendar.Season(d, day), Day = SeasonCalendar.Day(d, day), Ascension = (int)Number(e, "ascension"), Mode = Text(e, "mode") }`；返回值紧邻使用处：`ArgumentSyntax: new() { Season = GameCalendar.Season(d, day), Day = SeasonCalendar.Day(d, day), Ascension = (int)Number(e, "ascension"), Mode = Text(e, "mode") }`
- `NationalSpire.RandomEventEffects.Kind(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>)`；输入表达式：`Kind(e)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Kind(e)`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, "ascension")`；返回值紧邻使用处：`CastExpressionSyntax: (int)Number(e, "ascension")`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, "ascension")`；返回值紧邻使用处：`IsPatternExpressionSyntax: Number(e, "ascension") is < 0 or > 10`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, "count")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Number(e, "count")`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, "days")`；返回值紧邻使用处：`BinaryExpressionSyntax: Number(e, "days") <= 0`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, "days")`；返回值紧邻使用处：`CastExpressionSyntax: (int)Number(e, "days")`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, "percent")`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = Number(e, "percent")`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, "percent")`；返回值紧邻使用处：`BinaryExpressionSyntax: Number(e, "percent") <= -100`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, "points")`；返回值紧邻使用处：`BinaryExpressionSyntax: Number(e, "points") < 0`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, "points")`；返回值紧邻使用处：`CastExpressionSyntax: (int)Number(e, "points")`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, "value")`；返回值紧邻使用处：`CastExpressionSyntax: (int)Number(e, "value")`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, kind)`；返回值紧邻使用处：`AssignmentExpressionSyntax: wallet += Number(e, kind)`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, kind)`；返回值紧邻使用处：`CastExpressionSyntax: (int)Number(e, kind)`
- `NationalSpire.RandomEventEffects.Person(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>)`；输入表达式：`Person(e)`；返回值紧邻使用处：`ArgumentSyntax: Person(e)`
- `NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Text(e, "date")`；返回值紧邻使用处：`ArgumentSyntax: Text(e, "date")`
- `NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Text(e, "mode")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Mode = Text(e, "mode")`
- `NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Text(e, "mode")`；返回值紧邻使用处：`IsPatternExpressionSyntax: Text(e, "mode") is not ("切磋" or "挑战")`
- `NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Text(e, "name")`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = Text(e, "name")`
- `NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Text(e, "text")`；返回值紧邻使用处：`AssignmentExpressionSyntax: _ = Text(e, "text")`
- `NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Text(e, kind)`；返回值紧邻使用处：`ArgumentSyntax: Text(e, kind)`
- `NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Text(e, kind)`；返回值紧邻使用处：`BinaryExpressionSyntax: n.Country == Text(e, kind)`
- `NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Text(e, kind)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Text(e, kind)`
- `NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Day(d, day)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Day = SeasonCalendar.Day(d, day)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`d.Market.Quotes.ContainsKey(Text(e, kind))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.Market.Quotes.ContainsKey(Text(e, kind))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Nations.Any(n => n.Country == Text(e, kind))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.Esports.Nations.Any(n => n.Country == Text(e, kind))`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`Kinds.Count(e.ContainsKey)`；返回值紧邻使用处：`BinaryExpressionSyntax: Kinds.Count(e.ContainsKey) != 1`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.Life.Consumer.Goods.Where(g => !g.Consumed).GroupBy(g => g.Id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Consumer.Goods.Where(g => !g.Consumed).GroupBy(g => g.Id).ToDictionary`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, long>)`；输入表达式：`g.Sum(x => x.Quantity)`；返回值紧邻使用处：`CastExpressionSyntax: (decimal)g.Sum(x => x.Quantity)`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`d.Life.Consumer.Goods.Where(g => !g.Consumed).GroupBy(g => g.Id).ToDictionary(g => g.Key, g => (decimal)g.Sum(x => x.Quantity))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = d.Life.Consumer.Goods.Where(g => !g.Consumed).GroupBy(g => g.Id).ToDictionary(g => g.Key, g => (decimal)g.Sum(x => x.Quantity))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Life.Consumer.Goods.Where(g => !g.Consumed)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Life.Consumer.Goods.Where(g => !g.Consumed).GroupBy`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`stock.GetValueOrDefault(good)`；返回值紧邻使用处：`BinaryExpressionSyntax: stock.GetValueOrDefault(good) + count`

**赋值（含属性/字段和局部值）：**

- `_` = `checked((int)Number(e, "points") * 7)`
- `_` = `checked(d.Day + (int)Number(e, "days"))`
- `_` = `checked(d.Esports.OwnedClub!.Fans + (int)Number(e, kind))`
- `_` = `checked(d.Fans + (int)Number(e, kind))`
- `_` = `checked(PrivateMessages.Favour(d, Text(e, kind)) + (int)Number(e, "value"))`
- `_` = `Number(e, "percent")`
- `_` = `Text(e, "name")`
- `_` = `Text(e, "text")`
- `Ascension` = `(int)Number(e, "ascension")`
- `Day` = `SeasonCalendar.Day(d, day)`
- `Mode` = `Text(e, "mode")`
- `Season` = `GameCalendar.Season(d, day)`
- `stock[good]` = `stock.GetValueOrDefault(good) + count`
- `wallet` += `Number(e, kind)`

<a id="symbol-de44eea7b389"></a>

## `NationalSpire.RandomEventEffects.Preview(NationalSpire.CareerData, NationalSpire.RandomEventOption) — public static string Preview(CareerData d, RandomEventOption option)`

来源：源码第 177 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ApplyTestResponse(NationalSpire.CareerData, NationalSpire.PromptTestSession, string)`](PromptTesting.cs.md#symbol-7208c4c08018)；[`NationalSpire.EventStoryView.Display(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.EventLive?, bool)`](RandomEventScreen.cs.md#symbol-f847e9f29b0e)；[`NationalSpire.EventStoryView.ShowResultEffects(NationalSpire.CareerData, NationalSpire.RandomEventOption, Godot.VBoxContainer)`](RandomEventScreen.cs.md#symbol-5fbf79c036d6)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；[`NationalSpire.RandomEventEffects.Kind(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>)`](RandomEvents.cs.md#symbol-4907ebeabb94)；[`NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`](RandomEvents.cs.md#symbol-534439b11d45)；[`NationalSpire.RandomEventEffects.Person(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>)`](RandomEvents.cs.md#symbol-4c2ca1a5a966)；[`NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`](RandomEvents.cs.md#symbol-dc6f7fe803ad)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Math.Abs(decimal)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.Good.Name`；`NationalSpire.MarketAsset.Id`；`NationalSpire.MarketAsset.Name`；`NationalSpire.MarketCatalog.Assets`；`NationalSpire.RandomEventEffects.Kind(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>)`；`NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；`NationalSpire.RandomEventEffects.Person(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>)`；`NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；`NationalSpire.RandomEventOption.Effects`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: id.Length > 0 ? CareerEngine.DisplayName(d, id) : ""`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(Math.Abs(Number(e, kind)) / 10)`；返回值紧邻使用处：`BinaryExpressionSyntax: "钱包 " + (Number(e, kind) >= 0 ? "+" : "−") + CareerMoney.Format(Math.Abs(Number(e, kind)) / 10)`
- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(Text(e, kind))`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: ConsumerCatalog.Get(Text(e, kind))?.Name`
- `NationalSpire.RandomEventEffects.Kind(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>)`；输入表达式：`Kind(e)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Kind(e)`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, "ascension")`；返回值紧邻使用处：`InterpolationSyntax: {Number(e, "ascension")}`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, "count")`；返回值紧邻使用处：`InterpolationSyntax: {Number(e, "count"):+0;-0}`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, "days")`；返回值紧邻使用处：`InterpolationSyntax: {Number(e, "days")}`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, "percent")`；返回值紧邻使用处：`InterpolationSyntax: {Number(e, "percent"):+0.##;-0.##}`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, "points")`；返回值紧邻使用处：`InterpolationSyntax: {Number(e, "points")}`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, "value")`；返回值紧邻使用处：`InterpolationSyntax: {Number(e, "value"):+0;-0}`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, kind)`；返回值紧邻使用处：`ArgumentSyntax: Number(e, kind)`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, kind)`；返回值紧邻使用处：`BinaryExpressionSyntax: Number(e, kind) >= 0`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, kind)`；返回值紧邻使用处：`InterpolationSyntax: {Number(e, kind):+0;-0}`
- `NationalSpire.RandomEventEffects.Person(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>)`；输入表达式：`Person(e)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Person(e)`
- `NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Text(e, "date")`；返回值紧邻使用处：`InterpolationSyntax: {Text(e, "date")}`
- `NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Text(e, "mode")`；返回值紧邻使用处：`InterpolationSyntax: {Text(e, "mode")}`
- `NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Text(e, "name")`；返回值紧邻使用处：`InterpolationSyntax: {Text(e, "name")}`
- `NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Text(e, "text")`；返回值紧邻使用处：`BinaryExpressionSyntax: person + "的印象：" + Text(e, "text")`
- `NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Text(e, kind)`；返回值紧邻使用处：`ArgumentSyntax: Text(e, kind)`
- `NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Text(e, kind)`；返回值紧邻使用处：`BinaryExpressionSyntax: a.Id == Text(e, kind)`
- `NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Text(e, kind)`；返回值紧邻使用处：`InterpolationSyntax: {Text(e, kind)}`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", lines)`；返回值紧邻使用处：`ConditionalExpressionSyntax: lines.Count == 0 ? "按所选结局结束这次经历" : string.Join("\n", lines)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`MarketCatalog.Assets.FirstOrDefault(a => a.Id == Text(e, kind))`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: MarketCatalog.Assets.FirstOrDefault(a => a.Id == Text(e, kind))?.Name`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`lines.Add("效果格式待修正")`；返回值紧邻使用处：`ExpressionStatementSyntax: lines.Add("效果格式待修正");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`lines.Add(kind switch                  {                      "wallet" => "钱包 " + (Number(e, kind) >= 0 ? "+" : "−") + CareerMoney.Format(Math.Abs(Number(e, kind)) / 10),                      "fans" => $"个人关注 {Number(e, kind):+0;-0}", "clubFans" => $"俱乐部关注 {Number(e, kind):+0;-0}",                      "item" => $"{ConsumerCatalog.Get(Text(e, kind))?.Name} {Number(e, "count"):+0;-0}",                      "favour" => $"{person}好感 {Number(e, "value"):+0;-0}", "impression" => person + "的印象：" + Text(e, "text"),                      "status" => $"{person} · {Text(e, "name")}：模拟发挥 {Number(e, "percent"):+0.##;-0.##}%，持续{Number(e, "days")}天",                      "learning" => $"{person}长期模拟水平 {Number(e, "percent"):+0.##;-0.##}%",                      "market" => $"{MarketCatalog.Assets.FirstOrDefault(a => a.Id == Text(e, kind))?.Name}报价 {Number(e, "percent"):+0.##;-0.##}%",                      "development" => $"{Text(e, kind)}建设投入 +{Number(e, "points")}国运对应进度",                      "challenge" => $"{Text(e, "date")} · 与{person}{Text(e, "mode")} · 进阶{Number(e, "ascension")}", _ => "效果格式待修正"                  })`；返回值紧邻使用处：`ExpressionStatementSyntax: lines.Add(kind switch                  {                      "wallet" => "钱包 " + (Number(e, kind) >= 0 ? "+" : "−") + CareerMoney.Format(Math.Abs(Number(e, kind)) / 10),                      "fans" => $"个人关注 {Number(e, kind):+0;-0}", "clubFans" => $"俱乐部关注 {Number(e, kind):+0;-0}",                      "item" => $"{ConsumerCatalog.Get(Text(e, kind))?.Name} {Number(e, "count"):+0;-0}",                      "favour" => $"{person}好感 {Number(e, "value"):+0;-0}", "impression" => person + "的印象：" + Text(e, "text"),                      "status" => $"{person} · {Text(e, "name")}：模拟发挥 {Number(e, "percent"):+0.##;-0.##}%，持续{Number(e, "days")}天",                      "learning" => $"{person}长期模拟水平 {Number(e, "percent"):+0.##;-0.##}%",                      "market" => $"{MarketCatalog.Assets.FirstOrDefault(a => a.Id == Text(e, kind))?.Name}报价 {Number(e, "percent"):+0.##;-0.##}%",                      "development" => $"{Text(e, kind)}建设投入 +{Number(e, "points")}国运对应进度",                      "challenge" => $"{Text(e, "date")} · 与{person}{Text(e, "mode")} · 进阶{Number(e, "ascension")}", _ => "效果格式待修正"                  });`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string>()`
- `System.Math.Abs(decimal)`；输入表达式：`Math.Abs(Number(e, kind))`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Abs(Number(e, kind)) / 10`

**赋值（含属性/字段和局部值）：**


<a id="symbol-886f350e91dc"></a>

## `NationalSpire.RandomEventEffects.Apply(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption) — public static void Apply(CareerData d, RandomEventRecord record, RandomEventOption option)`

来源：源码第 200 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.RandomEvents.Choose(NationalSpire.CareerData, string, int, bool)`](RandomEvents.cs.md#symbol-c0266703d306)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerMarket.EventPrice(NationalSpire.CareerData, string, decimal, string, string)`](CareerMarket.cs.md#symbol-cda590dba294)；[`NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`](LifeData.cs.md#symbol-bcb55555a432)；[`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`](LifeData.cs.md#symbol-54a09649188b)；[`NationalSpire.CareerTraining.InvalidateForecast(NationalSpire.CareerData)`](CareerTraining.cs.md#symbol-5df788f3061f)；[`NationalSpire.ConsumerCatalog.Get(string)`](ConsumerData.cs.md#symbol-46828b8901c1)；[`NationalSpire.ConsumerEngine.ChangeInventory(NationalSpire.CareerData, NationalSpire.Good, long)`](ConsumerEngine.cs.md#symbol-57cd1c96aca4)；[`NationalSpire.GameCalendar.TryDay(NationalSpire.CareerData, string?, out int)`](GameCalendar.cs.md#symbol-ca512729a156)；[`NationalSpire.NationalDevelopment.Contribute(NationalSpire.CareerData, NationalSpire.NationalLegacy, int, string)`](NationalDevelopment.cs.md#symbol-c1f2a8832691)；[`NationalSpire.PrivateAppointments.CreateMatch(NationalSpire.CareerData, string, int, int, string, string)`](PrivateAppointments.cs.md#symbol-6eff879f1d6c)；[`NationalSpire.PrivateMessages.ChangeFavour(NationalSpire.CareerData, string, int)`](PrivateMessages.cs.md#symbol-c703192e56c0)；[`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-8a6bb6e78fa5)；[`NationalSpire.RandomEventEffects.Kind(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>)`](RandomEvents.cs.md#symbol-4907ebeabb94)；[`NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`](RandomEvents.cs.md#symbol-534439b11d45)；[`NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`](RandomEvents.cs.md#symbol-dc6f7fe803ad)；`NationalSpire.EventStatus.EventStatus()`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Fans`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerMarket.EventPrice(NationalSpire.CareerData, string, decimal, string, string)`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`；`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；`NationalSpire.CareerPerson.Learning`；`NationalSpire.CareerTraining.InvalidateForecast(NationalSpire.CareerData)`；`NationalSpire.ConsumerCatalog.Get(string)`；`NationalSpire.ConsumerEngine.ChangeInventory(NationalSpire.CareerData, NationalSpire.Good, long)`；`NationalSpire.EsportsCareer.Nations`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.EventStatus.Name`；`NationalSpire.EventStatus.Percent`；`NationalSpire.EventStatus.Source`；`NationalSpire.EventStatus.Until`；`NationalSpire.GameCalendar.TryDay(NationalSpire.CareerData, string?, out int)`；`NationalSpire.NationalDevelopment.Contribute(NationalSpire.CareerData, NationalSpire.NationalLegacy, int, string)`；`NationalSpire.NationalLegacy.Country`；`NationalSpire.NpcLearning.ChanceShift`；`NationalSpire.NpcLearning.EventStatuses`；`NationalSpire.OwnedClubState.Fans`；`NationalSpire.PrivateAppointments.CreateMatch(NationalSpire.CareerData, string, int, int, string, string)`；`NationalSpire.PrivateMessages.ChangeFavour(NationalSpire.CareerData, string, int)`；`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；`NationalSpire.PrivateRelation.Impression`；`NationalSpire.PrivateRelation.Revision`；`NationalSpire.RandomEventEffects.Kind(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>)`；`NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；`NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；`NationalSpire.RandomEventOption.Effects`；`NationalSpire.RandomEventRecord.Id`；`NationalSpire.RandomEventRecord.MatchIds`；`NationalSpire.RandomEventRecord.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, Text(e, kind))`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(d, Text(e, kind))!`
- `NationalSpire.CareerMarket.EventPrice(NationalSpire.CareerData, string, decimal, string, string)`；输入表达式：`CareerMarket.EventPrice(d, Text(e, kind), Number(e, "percent"), record.Id, record.Title)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMarket.EventPrice(d, Text(e, kind), Number(e, "percent"), record.Id, record.Title);`
- `NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`；输入表达式：`CareerMoney.Add(d, amount)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Add(d, amount);`
- `NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；输入表达式：`CareerMoney.Record(d, record.Title, amount)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Record(d, record.Title, amount);`
- `NationalSpire.CareerTraining.InvalidateForecast(NationalSpire.CareerData)`；输入表达式：`CareerTraining.InvalidateForecast(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerTraining.InvalidateForecast(d);`
- `NationalSpire.ConsumerCatalog.Get(string)`；输入表达式：`ConsumerCatalog.Get(Text(e, kind))`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: ConsumerCatalog.Get(Text(e, kind))!`
- `NationalSpire.ConsumerEngine.ChangeInventory(NationalSpire.CareerData, NationalSpire.Good, long)`；输入表达式：`ConsumerEngine.ChangeInventory(d, ConsumerCatalog.Get(Text(e, kind))!, (long)Number(e, "count"))`；返回值紧邻使用处：`ExpressionStatementSyntax: ConsumerEngine.ChangeInventory(d, ConsumerCatalog.Get(Text(e, kind))!, (long)Number(e, "count"));`
- `NationalSpire.EventStatus.EventStatus()`；输入表达式：`new() { Source = record.Id, Name = Text(e, "name"), Percent = (double)Number(e, "percent"), Until = d.Day + (int)Number(e, "days") }`；返回值紧邻使用处：`ArgumentSyntax: new() { Source = record.Id, Name = Text(e, "name"), Percent = (double)Number(e, "percent"), Until = d.Day + (int)Number(e, "days") }`
- `NationalSpire.GameCalendar.TryDay(NationalSpire.CareerData, string?, out int)`；输入表达式：`GameCalendar.TryDay(d, Text(e, "date"), out int day)`；返回值紧邻使用处：`ExpressionStatementSyntax: GameCalendar.TryDay(d, Text(e, "date"), out int day);`
- `NationalSpire.NationalDevelopment.Contribute(NationalSpire.CareerData, NationalSpire.NationalLegacy, int, string)`；输入表达式：`NationalDevelopment.Contribute(d, d.Esports.Nations.Single(n => n.Country == Text(e, kind)), (int)Number(e, "points"), record.Title)`；返回值紧邻使用处：`ExpressionStatementSyntax: NationalDevelopment.Contribute(d, d.Esports.Nations.Single(n => n.Country == Text(e, kind)), (int)Number(e, "points"), record.Title);`
- `NationalSpire.PrivateAppointments.CreateMatch(NationalSpire.CareerData, string, int, int, string, string)`；输入表达式：`PrivateAppointments.CreateMatch(d, Text(e, kind), day, (int)Number(e, "ascension"), Text(e, "mode"), "际遇")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateAppointments.CreateMatch(d, Text(e, kind), day, (int)Number(e, "ascension"), Text(e, "mode"), "际遇")`
- `NationalSpire.PrivateMessages.ChangeFavour(NationalSpire.CareerData, string, int)`；输入表达式：`PrivateMessages.ChangeFavour(d, Text(e, kind), (int)Number(e, "value"))`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateMessages.ChangeFavour(d, Text(e, kind), (int)Number(e, "value"));`
- `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Relation(d, Text(e, kind))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Relation(d, Text(e, kind))`
- `NationalSpire.RandomEventEffects.Kind(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>)`；输入表达式：`Kind(e)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Kind(e)`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, "ascension")`；返回值紧邻使用处：`CastExpressionSyntax: (int)Number(e, "ascension")`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, "count")`；返回值紧邻使用处：`CastExpressionSyntax: (long)Number(e, "count")`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, "days")`；返回值紧邻使用处：`CastExpressionSyntax: (int)Number(e, "days")`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, "percent")`；返回值紧邻使用处：`ArgumentSyntax: Number(e, "percent")`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, "percent")`；返回值紧邻使用处：`CastExpressionSyntax: (double)Number(e, "percent")`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, "points")`；返回值紧邻使用处：`CastExpressionSyntax: (int)Number(e, "points")`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, "value")`；返回值紧邻使用处：`CastExpressionSyntax: (int)Number(e, "value")`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, kind)`；返回值紧邻使用处：`BinaryExpressionSyntax: Number(e, kind) / 10`
- `NationalSpire.RandomEventEffects.Number(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Number(e, kind)`；返回值紧邻使用处：`CastExpressionSyntax: (int)Number(e, kind)`
- `NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Text(e, "date")`；返回值紧邻使用处：`ArgumentSyntax: Text(e, "date")`
- `NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Text(e, "mode")`；返回值紧邻使用处：`ArgumentSyntax: Text(e, "mode")`
- `NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Text(e, "name")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Name = Text(e, "name")`
- `NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Text(e, "text")`；返回值紧邻使用处：`AssignmentExpressionSyntax: relation.Impression = Text(e, "text")`
- `NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Text(e, kind)`；返回值紧邻使用处：`ArgumentSyntax: Text(e, kind)`
- `NationalSpire.RandomEventEffects.Text(System.Collections.Generic.Dictionary<string, System.Text.Json.JsonElement>, string)`；输入表达式：`Text(e, kind)`；返回值紧邻使用处：`BinaryExpressionSyntax: n.Country == Text(e, kind)`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Nations.Single(n => n.Country == Text(e, kind))`；返回值紧邻使用处：`ArgumentSyntax: d.Esports.Nations.Single(n => n.Country == Text(e, kind))`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`CareerEngine.Person(d, Text(e, kind))!.Learning.EventStatuses.Add(new() { Source = record.Id, Name = Text(e, "name"), Percent = (double)Number(e, "percent"), Until = d.Day + (int)Number(e, "days") })`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerEngine.Person(d, Text(e, kind))!.Learning.EventStatuses.Add(new() { Source = record.Id, Name = Text(e, "name"), Percent = (double)Number(e, "percent"), Until = d.Day + (int)Number(e, "days") });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`record.MatchIds.Add(match.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: record.MatchIds.Add(match.Id);`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, d.Esports.OwnedClub.Fans + (int)Number(e, kind))`；返回值紧邻使用处：`AssignmentExpressionSyntax: d.Esports.OwnedClub!.Fans = Math.Max(0, d.Esports.OwnedClub.Fans + (int)Number(e, kind))`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, d.Fans + (int)Number(e, kind))`；返回值紧邻使用处：`AssignmentExpressionSyntax: d.Fans = Math.Max(0, d.Fans + (int)Number(e, kind))`

**赋值（含属性/字段和局部值）：**

- `CareerEngine.Person(d, Text(e, kind))!.Learning.ChanceShift` += `(double)Number(e, "percent") / 100`
- `d.Esports.OwnedClub!.Fans` = `Math.Max(0, d.Esports.OwnedClub.Fans + (int)Number(e, kind))`
- `d.Fans` = `Math.Max(0, d.Fans + (int)Number(e, kind))`
- `Name` = `Text(e, "name")`
- `Percent` = `(double)Number(e, "percent")`
- `relation.Impression` = `Text(e, "text")`
- `Source` = `record.Id`
- `Until` = `d.Day + (int)Number(e, "days")`
