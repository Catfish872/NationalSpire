# OwnedClubs.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`9B1D59E0C2FDC2CB795B528802BAD90F606F51C69EEDBB26AF3CE7B1ED31E0E3`。来源：[源码](../../OwnedClubs.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.OwnedClubs`、`NationalSpire.ClubPrograms`、`NationalSpire.ClubPrograms.Terms`。

字段、事件及初始值（源码原样）：

```csharp
public const int HumanWeeklyWage = 280, HumanWinBonus = 200;
public const int FoundingCost = 20000, WeeklyOverhead = 80;
public static readonly string[] Colors = ["69dfd3", "eed39b", "a997ed", "ee929d", "84b8ef"];
```

<a id="symbol-8c9ea9f33c3c"></a>

## `NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData) — public static bool IsOwner(CareerData d)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerCommerce.Upgrade(NationalSpire.CareerData)`](CareerCommerce.cs.md#symbol-d734109c7eea)；[`NationalSpire.CareerScreen.ClubInvitation(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-2eeae75151b7)；[`NationalSpire.CareerScreen.ClubProfileActions(NationalSpire.CareerData, NationalSpire.CareerPerson, Godot.VBoxContainer)`](OwnedClubScreen.cs.md#symbol-07281993c5a0)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.World(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-ce5a79e2aa5c)；[`NationalSpire.ClubCoaching.SeasonStart(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-c152f62d57e4)；[`NationalSpire.Coop.CoopRules.PayClubMembers(NationalSpire.Coop.CoopWorld)`](Coop/CoopRules.cs.md#symbol-6ee521cc017d)；[`NationalSpire.Coop.CoopRules.UseOwnerWallet(NationalSpire.Coop.CoopWorld)`](Coop/CoopRules.cs.md#symbol-e04444ebfbff)；[`NationalSpire.EsportsWorld.AcceptOffer(NationalSpire.CareerData, NationalSpire.ClubOffer)`](EsportsWorld.cs.md#symbol-09ff5941397c)；[`NationalSpire.EsportsWorld.Milestone(NationalSpire.CareerData, string, string, string, int, int)`](EsportsWorld.cs.md#symbol-83220601bb1f)；[`NationalSpire.OwnedClubs.Advance(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-7fe29c98085a)；[`NationalSpire.OwnedClubs.ArriveTransfers(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-2429e4910b3f)；[`NationalSpire.OwnedClubs.Assign(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-e97dde3c003f)；[`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-871ad0e2a2c9)；[`NationalSpire.OwnedClubs.ChangeSponsor(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-a1b523b0541a)；[`NationalSpire.OwnedClubs.CreationError(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-c66d40eab5e9)；[`NationalSpire.OwnedClubs.PayDebt(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-98b9722b6128)；[`NationalSpire.OwnedClubs.PracticeBonus(NationalSpire.CareerData, string, int, int?)`](OwnedClubs.cs.md#symbol-5b2c48d0615a)；[`NationalSpire.OwnedClubs.RecruitError(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-af6739305612)；[`NationalSpire.OwnedClubs.Release(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-ab8d716536a6)；[`NationalSpire.OwnedClubs.SettleAchievements(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-51faa8d5ccbd)；[`NationalSpire.OwnedClubs.SettleResults(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-7c6dba67fe98)；[`NationalSpire.OwnedClubs.StarterReplacementError(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-e4678a15386e)；[`NationalSpire.OwnedClubs.Swap(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-581cdf4f2390)；[`NationalSpire.OwnedClubs.TransferError(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-dd969fd199a4)；[`NationalSpire.OwnedClubSchedule.ChangeRegion(NationalSpire.CareerData, string)`](OwnedClubSchedule.cs.md#symbol-b24bb65463ab)；[`NationalSpire.TeamPreparations.Buy(NationalSpire.CareerData, string)`](TeamPreparation.cs.md#symbol-440f4ccf2595)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubState.ClubId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-87d58351738a"></a>

## `NationalSpire.OwnedClubs.Tier(NationalSpire.CareerPerson) — public static string Tier(CareerPerson p)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubMarket(NationalSpire.CareerData, bool)`](OwnedClubScreen.cs.md#symbol-b1e2f4fe72a4)；[`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.MaxAscension`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f0042770c2f0"></a>

## `NationalSpire.OwnedClubs.PlanName(string) — public static string PlanName(string plan)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubReview(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubScreen.cs.md#symbol-ae7b54f0270a)；[`NationalSpire.CareerScreen.ClubWizard(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-8f3c0cb211aa)；[`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)；[`NationalSpire.OwnedClubs.Recruit(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-bad0a27b1a6b)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3dba497c8606"></a>

## `NationalSpire.OwnedClubs.EnsureMarket(NationalSpire.CareerData) — public static void EnsureMarket(CareerData d)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.CreateNew(bool, int)`](CareerEngine.cs.md#symbol-63d93017946a)；[`NationalSpire.CareerEngine.NormalizeRoster(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-eb11b96e7400)；[`NationalSpire.Coop.CoopCoordinator.CoopCoordinator(NationalSpire.Coop.ICoopTransport, NationalSpire.Coop.CoopStorage, string, string, string, System.Collections.Generic.IReadOnlySet<string>, NationalSpire.Coop.CoopStorage.Checkpoint?)`](Coop/CoopCoordinator.cs.md#symbol-778097f34ec3)；[`NationalSpire.Coop.CoopRules.Create(ulong, string, string, int, string)`](Coop/CoopRules.cs.md#symbol-768ae6d9f0c2)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.IdentityGender.Assigned(NationalSpire.CareerData, string)`](IdentityGender.cs.md#symbol-9b3f1de1d44a)；[`NationalSpire.OwnedClubs.InitializeRecruit(NationalSpire.CareerData, NationalSpire.CareerPerson)`](OwnedClubs.cs.md#symbol-16ca5da8a4ee)；[`NationalSpire.OwnedClubs.RepairContractRoster(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.PrivateMailbox>?)`](OwnedClubs.cs.md#symbol-3b98b543bc03)；[`NationalSpire.OwnedClubs.UpgradeEconomy(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-f459a7689794)；[`NationalSpire.PersonalityLibrary.Ensure(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PersonalityLibrary.cs.md#symbol-902b2bd837d2)；[`NationalSpire.WorldPeople.Name(NationalSpire.CareerData, string, string, bool)`](WorldPeople.cs.md#symbol-731e781389c6)；[`NationalSpire.WorldPeople.PlayingStyle(int, int)`](ExpandedPeople.cs.md#symbol-d239e2d11a5b)；`NationalSpire.CareerPerson.CareerPerson()`；`string.StartsWith(string)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerPerson.Biography`；`NationalSpire.CareerPerson.Character`；`NationalSpire.CareerPerson.Country`；`NationalSpire.CareerPerson.Gender`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.Name`；`NationalSpire.CareerPerson.Rating`；`NationalSpire.CareerPerson.Region`；`NationalSpire.CareerPerson.Role`；`NationalSpire.CareerPerson.Style`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsCareer.EcosystemVersion`；`NationalSpire.EsportsCareer.FreeAgentVersion`；`NationalSpire.IdentityGender.Assigned(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubs.InitializeRecruit(NationalSpire.CareerData, NationalSpire.CareerPerson)`；`NationalSpire.OwnedClubs.RepairContractRoster(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.PrivateMailbox>?)`；`NationalSpire.OwnedClubs.UpgradeEconomy(NationalSpire.CareerData)`；`NationalSpire.PersonalityLibrary.Ensure(NationalSpire.CareerData, NationalSpire.CareerPerson)`；`NationalSpire.WorldPeople.Name(NationalSpire.CareerData, string, string, bool)`；`NationalSpire.WorldPeople.PlayingStyle(int, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(d.WorldId + id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.StableHash(d.WorldId + id)`
- `NationalSpire.CareerPerson.CareerPerson()`；输入表达式：`new CareerPerson { Id = id, Gender = IdentityGender.Assigned(d, id), Country = d.Esports.Country, Region = d.Esports.Country + "赛区",                  Name = WorldPeople.Name(d, id, d.Esports.Country, false), Role = level == 6 ? "青训选手" : "职业选手",                  MaxAscension = level, Rating = 680 + level * 76 + seed % 201, Character = chars[seed % 5],                  Style = WorldPeople.PlayingStyle(seed % 5, seed / 5), Biography = "自由选手，正在寻找适合自己的俱乐部。" }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CareerPerson { Id = id, Gender = IdentityGender.Assigned(d, id), Country = d.Esports.Country, Region = d.Esports.Country + "赛区",                  Name = WorldPeople.Name(d, id, d.Esports.Country, false), Role = level == 6 ? "青训选手" : "职业选手",                  MaxAscension = level, Rating = 680 + level * 76 + seed % 201, Character = chars[seed % 5],                  Style = WorldPeople.PlayingStyle(seed % 5, seed / 5), Biography = "自由选手，正在寻找适合自己的俱乐部。" }`
- `NationalSpire.IdentityGender.Assigned(NationalSpire.CareerData, string)`；输入表达式：`IdentityGender.Assigned(d, id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Gender = IdentityGender.Assigned(d, id)`
- `NationalSpire.OwnedClubs.InitializeRecruit(NationalSpire.CareerData, NationalSpire.CareerPerson)`；输入表达式：`InitializeRecruit(d, existing)`；返回值紧邻使用处：`ExpressionStatementSyntax: InitializeRecruit(d, existing);`
- `NationalSpire.OwnedClubs.InitializeRecruit(NationalSpire.CareerData, NationalSpire.CareerPerson)`；输入表达式：`InitializeRecruit(d, p)`；返回值紧邻使用处：`ExpressionStatementSyntax: InitializeRecruit(d, p);`
- `NationalSpire.OwnedClubs.RepairContractRoster(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.PrivateMailbox>?)`；输入表达式：`RepairContractRoster(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: RepairContractRoster(d);`
- `NationalSpire.OwnedClubs.UpgradeEconomy(NationalSpire.CareerData)`；输入表达式：`UpgradeEconomy(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: UpgradeEconomy(d);`
- `NationalSpire.PersonalityLibrary.Ensure(NationalSpire.CareerData, NationalSpire.CareerPerson)`；输入表达式：`PersonalityLibrary.Ensure(d, p)`；返回值紧邻使用处：`ExpressionStatementSyntax: PersonalityLibrary.Ensure(d, p);`
- `NationalSpire.WorldPeople.Name(NationalSpire.CareerData, string, string, bool)`；输入表达式：`WorldPeople.Name(d, id, d.Esports.Country, false)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Name = WorldPeople.Name(d, id, d.Esports.Country, false)`
- `NationalSpire.WorldPeople.PlayingStyle(int, int)`；输入表达式：`WorldPeople.PlayingStyle(seed % 5, seed / 5)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Style = WorldPeople.PlayingStyle(seed % 5, seed / 5)`
- `string.StartsWith(string)`；输入表达式：`p.Id.StartsWith("free-agent-")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => p.Id.StartsWith("free-agent-")`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Any(p => p.Id == id)`；返回值紧邻使用处：`IfStatementSyntax: if (d.People.Any(p => p.Id == id)) continue;`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p => p.Id.StartsWith("free-agent-"))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var existing in d.People.Where(p => p.Id.StartsWith("free-agent-"))) InitializeRecruit(d, existing);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.People.Add(p)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.People.Add(p);`

**赋值（含属性/字段和局部值）：**

- `Biography` = `"自由选手，正在寻找适合自己的俱乐部。"`
- `Character` = `chars[seed % 5]`
- `Country` = `d.Esports.Country`
- `d.Esports.FreeAgentVersion` = `2`
- `Gender` = `IdentityGender.Assigned(d, id)`
- `Id` = `id`
- `MaxAscension` = `level`
- `Name` = `WorldPeople.Name(d, id, d.Esports.Country, false)`
- `Rating` = `680 + level * 76 + seed % 201`
- `Region` = `d.Esports.Country + "赛区"`
- `Role` = `level == 6 ? "青训选手" : "职业选手"`
- `Style` = `WorldPeople.PlayingStyle(seed % 5, seed / 5)`

<a id="symbol-16ca5da8a4ee"></a>

## `NationalSpire.OwnedClubs.InitializeRecruit(NationalSpire.CareerData, NationalSpire.CareerPerson) — private static void InitializeRecruit(CareerData d, CareerPerson p)`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OwnedClubs.EnsureMarket(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-3dba497c8606)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.NpcRecords.Initialize(NationalSpire.CareerPerson, int)`](NpcRecords.cs.md#symbol-321539fa4eea)；`System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.WeeklyPersonBaselines`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Losses`；`NationalSpire.CareerPerson.Rating`；`NationalSpire.CareerPerson.RecruitVersion`；`NationalSpire.NpcRecords.Initialize(NationalSpire.CareerPerson, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(d.WorldId + p.Id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.StableHash(d.WorldId + p.Id)`
- `NationalSpire.NpcRecords.Initialize(NationalSpire.CareerPerson, int)`；输入表达式：`NpcRecords.Initialize(p, seed)`；返回值紧邻使用处：`ExpressionStatementSyntax: NpcRecords.Initialize(p, seed);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Remove(TKey)`；输入表达式：`d.WeeklyPersonBaselines.Remove(p.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.WeeklyPersonBaselines.Remove(p.Id);`

**赋值（含属性/字段和局部值）：**

- `p.Losses` += `55 + seed % 96`
- `p.Rating` += `160`
- `p.RecruitVersion` = `1`

<a id="symbol-11345d1ef285"></a>

## `NationalSpire.OwnedClubs.IsRecruitable(NationalSpire.CareerPerson) — public static bool IsRecruitable(CareerPerson p)`

来源：源码第 46 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubProfileActions(NationalSpire.CareerData, NationalSpire.CareerPerson, Godot.VBoxContainer)`](OwnedClubScreen.cs.md#symbol-07281993c5a0)；[`NationalSpire.CareerScreen.PrivateActions()`](PrivateMessageScreen.cs.md#symbol-6e8c11ead905)；[`NationalSpire.OwnedClubs.Candidates(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-86d3ae3f2a68)；[`NationalSpire.OwnedClubs.TransferError(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-dd969fd199a4)；[`NationalSpire.PrivateMessagePrompts.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-4b9d12b26f65)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3b98b543bc03"></a>

## `NationalSpire.OwnedClubs.RepairContractRoster(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.PrivateMailbox>?) — public static bool RepairContractRoster(CareerData d, IEnumerable<PrivateMailbox>? mailboxes = null)`

来源：源码第 48 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerStore.Data`](CareerStore.cs.md#symbol-9724f0dac935)；[`NationalSpire.Coop.CoopCoordinator.CoopCoordinator(NationalSpire.Coop.ICoopTransport, NationalSpire.Coop.CoopStorage, string, string, string, System.Collections.Generic.IReadOnlySet<string>, NationalSpire.Coop.CoopStorage.Checkpoint?)`](Coop/CoopCoordinator.cs.md#symbol-778097f34ec3)；[`NationalSpire.OwnedClubs.EnsureMarket(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-3dba497c8606)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CharacterDeletion.RepairStarters(NationalSpire.CareerData, bool)`](CharacterDeletion.cs.md#symbol-c88a1645b627)；[`NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-49a6a4a933e2)；[`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-241a535c93f9)；[`NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`](OwnedClubs.cs.md#symbol-11696548c7d5)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerLifeState.Mailbox`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.ClubPosition`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CharacterDeletion.RepairStarters(NationalSpire.CareerData, bool)`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubState.Contracts`；`NationalSpire.OwnedClubState.Starters`；`NationalSpire.OwnedPlayerContract.PersonId`；`NationalSpire.OwnedPlayerContract.Position`；`NationalSpire.OwnedPlayerContract.Signing`；`NationalSpire.OwnedPlayerContract.Wage`；`NationalSpire.OwnedPlayerContract.WinBonus`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Role`；`NationalSpire.PrivateOffer.Signing`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.Wage`；`NationalSpire.PrivateOffer.WinBonus`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, contract.PersonId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Person(d, contract.PersonId)`
- `NationalSpire.CharacterDeletion.RepairStarters(NationalSpire.CareerData, bool)`；输入表达式：`CharacterDeletion.RepairStarters(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: CharacterDeletion.RepairStarters(d) || changed`
- `NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`；输入表达式：`ActiveHumans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ActiveHumans(d).Count`
- `NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；输入表达式：`Humans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Humans(d).Contains`
- `NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`；输入表达式：`PositionList(own, position)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PositionList(own, position).Add`
- `NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`；输入表达式：`PositionList(own, role)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PositionList(own, role).Contains`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`positions.FirstOrDefault()`；返回值紧邻使用处：`BinaryExpressionSyntax: positions.FirstOrDefault() ?? (contract.Position.Length > 0 ? contract.Position : p.ClubPosition)`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`boxes.SelectMany(b => b.Conversations.GetValueOrDefault(p.Id)?.Offers ?? [])                      .LastOrDefault(o => o.Kind == "contract" && o.State == "已确认" && o.Signing / 10m == contract.Signing                          && o.Wage / 10m == contract.Wage && o.WinBonus / 10m == contract.WinBonus)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: boxes.SelectMany(b => b.Conversations.GetValueOrDefault(p.Id)?.Offers ?? [])                      .LastOrDefault(o => o.Kind == "contract" && o.State == "已确认" && o.Signing / 10m == contract.Signing                          && o.Wage / 10m == contract.Wage && o.WinBonus / 10m == contract.WinBonus)?.Role`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`boxes.SelectMany(b => b.Conversations.GetValueOrDefault(p.Id)?.Offers ?? [])`；返回值紧邻使用处：`MemberAccessExpressionSyntax: boxes.SelectMany(b => b.Conversations.GetValueOrDefault(p.Id)?.Offers ?? [])                      .LastOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`new[] { "首发", "轮换", "青训", "教练" }.Where(role => PositionList(own, role).Contains(p.Id)).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new[] { "首发", "轮换", "青训", "教练" }.Where(role => PositionList(own, role).Contains(p.Id)).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`new[] { "首发", "轮换", "青训", "教练" }.Where(role => PositionList(own, role).Contains(p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { "首发", "轮换", "青训", "教练" }.Where(role => PositionList(own, role).Contains(p.Id)).ToArray`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`b.Conversations.GetValueOrDefault(p.Id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: b.Conversations.GetValueOrDefault(p.Id)?.Offers`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`PositionList(own, position).Add(p.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: PositionList(own, position).Add(p.Id);`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`Humans(d).Contains(p.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: p == null || Humans(d).Contains(p.Id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`PositionList(own, role).Contains(p.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: role => PositionList(own, role).Contains(p.Id)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(3, ActiveHumans(d).Count)`；返回值紧邻使用处：`BinaryExpressionSyntax: own.Starters.Count >= Math.Max(3, ActiveHumans(d).Count)`

**赋值（含属性/字段和局部值）：**

- `changed` = `true`
- `contract.Position` = `position`
- `p.ClubId` = `own.ClubId`
- `p.ClubPosition` = `position`
- `position` = `boxes.SelectMany(b => b.Conversations.GetValueOrDefault(p.Id)?.Offers ?? [])                      .LastOrDefault(o => o.Kind == "contract" && o.State == "已确认" && o.Signing / 10m == contract.Signing                          && o.Wage / 10m == contract.Wage && o.WinBonus / 10m == contract.WinBonus)?.Role ?? ""`

<a id="symbol-86d3ae3f2a68"></a>

## `NationalSpire.OwnedClubs.Candidates(NationalSpire.CareerData) — public static List<CareerPerson> Candidates(CareerData d)`

来源：源码第 75 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubMarket(NationalSpire.CareerData, bool)`](OwnedClubScreen.cs.md#symbol-b1e2f4fe72a4)；[`NationalSpire.OwnedClubs.SigningError(NationalSpire.CareerData, NationalSpire.ClubSigning, bool)`](OwnedClubs.cs.md#symbol-e45e226b122d)

**调用：** [`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-241a535c93f9)；[`NationalSpire.OwnedClubs.IsRecruitable(NationalSpire.CareerPerson)`](OwnedClubs.cs.md#symbol-11345d1ef285)；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.People`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.Rating`；`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.IsRecruitable(NationalSpire.CareerPerson)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；输入表达式：`Humans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Humans(d).Contains`
- `NationalSpire.OwnedClubs.IsRecruitable(NationalSpire.CareerPerson)`；输入表达式：`IsRecruitable(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.ClubId.Length == 0          && IsRecruitable(p)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.People.Where(p => p.ClubId.Length == 0          && IsRecruitable(p) && !Humans(d).Contains(p.Id))          .OrderByDescending(p => p.MaxAscension)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.ClubId.Length == 0          && IsRecruitable(p) && !Humans(d).Contains(p.Id))          .OrderByDescending(p => p.MaxAscension).ThenByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.People.Where(p => p.ClubId.Length == 0          && IsRecruitable(p) && !Humans(d).Contains(p.Id))          .OrderByDescending(p => p.MaxAscension).ThenByDescending(p => p.Rating).ToList()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => d.People.Where(p => p.ClubId.Length == 0          && IsRecruitable(p) && !Humans(d).Contains(p.Id))          .OrderByDescending(p => p.MaxAscension).ThenByDescending(p => p.Rating).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p => p.ClubId.Length == 0          && IsRecruitable(p) && !Humans(d).Contains(p.Id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.ClubId.Length == 0          && IsRecruitable(p) && !Humans(d).Contains(p.Id))          .OrderByDescending`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`Humans(d).Contains(p.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Humans(d).Contains(p.Id)`
- `System.Linq.IOrderedEnumerable<TSource>.ThenByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`d.People.Where(p => p.ClubId.Length == 0          && IsRecruitable(p) && !Humans(d).Contains(p.Id))          .OrderByDescending(p => p.MaxAscension).ThenByDescending(p => p.Rating)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.People.Where(p => p.ClubId.Length == 0          && IsRecruitable(p) && !Humans(d).Contains(p.Id))          .OrderByDescending(p => p.MaxAscension).ThenByDescending(p => p.Rating).ToList`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6507b91ba56b"></a>

## `NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string) — public static OwnedPlayerContract Quote(CareerPerson p, string plan)`

来源：源码第 78 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubMarket(NationalSpire.CareerData, bool)`](OwnedClubScreen.cs.md#symbol-b1e2f4fe72a4)；[`NationalSpire.CareerScreen.ClubProfileActions(NationalSpire.CareerData, NationalSpire.CareerPerson, Godot.VBoxContainer)`](OwnedClubScreen.cs.md#symbol-07281993c5a0)；[`NationalSpire.CareerScreen.ClubReview(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubScreen.cs.md#symbol-ae7b54f0270a)；[`NationalSpire.OwnedClubs.ArrangeTransfer(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-66be5c09e822)；[`NationalSpire.OwnedClubs.InitialCost(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-522aa99991c7)；[`NationalSpire.OwnedClubs.RecruitError(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-af6739305612)；[`NationalSpire.OwnedClubs.SignUnchecked(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-4f3afc350ac9)；[`NationalSpire.OwnedClubs.TransferError(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-dd969fd199a4)；[`NationalSpire.OwnedClubs.TransferFee(NationalSpire.CareerPerson)`](OwnedClubs.cs.md#symbol-35a81fabab41)；[`NationalSpire.OwnedClubs.WeeklyWages(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-d56a24efadf8)；[`NationalSpire.PrivateContracts.Confirm(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, string)`](PrivateAppointments.cs.md#symbol-1c0ddcc69a05)；[`NationalSpire.PrivateContracts.Guidance(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivateAppointments.cs.md#symbol-3c22aa703fb0)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；`NationalSpire.OwnedPlayerContract.OwnedPlayerContract()`；`System.Math.Round(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.OwnedPlayerContract.Days`；`NationalSpire.OwnedPlayerContract.PersonId`；`NationalSpire.OwnedPlayerContract.Plan`；`NationalSpire.OwnedPlayerContract.Signing`；`NationalSpire.OwnedPlayerContract.Wage`；`NationalSpire.OwnedPlayerContract.WinBonus`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(p.Id + ":contract")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.StableHash(p.Id + ":contract")`
- `NationalSpire.OwnedPlayerContract.OwnedPlayerContract()`；输入表达式：`new() { PersonId = p.Id, Plan = plan, Days = plan == "growth" ? 84 : 56,              Signing = plan == "performance" ? signing * 3 / 5 : plan == "growth" ? signing / 2 : signing,              Wage = plan == "performance" ? wage * 7 / 10 : plan == "growth" ? wage * 12 / 10 : wage,              WinBonus = plan == "performance" ? wage : plan == "growth" ? wage / 5 : wage / 4 }`；返回值紧邻使用处：`ReturnStatementSyntax: return new() { PersonId = p.Id, Plan = plan, Days = plan == "growth" ? 84 : 56,              Signing = plan == "performance" ? signing * 3 / 5 : plan == "growth" ? signing / 2 : signing,              Wage = plan == "performance" ? wage * 7 / 10 : plan == "growth" ? wage * 12 / 10 : wage,              WinBonus = plan == "performance" ? wage : plan == "growth" ? wage / 5 : wage / 4 };`
- `System.Math.Round(double)`；输入表达式：`Math.Round(signing * (85 + terms / 23 % 31) / 100.0)`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round(signing * (85 + terms / 23 % 31) / 100.0)`
- `System.Math.Round(double)`；输入表达式：`Math.Round(wage * (90 + terms % 21) / 100.0)`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round(wage * (90 + terms % 21) / 100.0)`

**赋值（含属性/字段和局部值）：**

- `Days` = `plan == "growth" ? 84 : 56`
- `PersonId` = `p.Id`
- `Plan` = `plan`
- `signing` = `(int)Math.Round(signing * (85 + terms / 23 % 31) / 100.0)`
- `Signing` = `plan == "performance" ? signing * 3 / 5 : plan == "growth" ? signing / 2 : signing`
- `wage` = `(int)Math.Round(wage * (90 + terms % 21) / 100.0)`
- `Wage` = `plan == "performance" ? wage * 7 / 10 : plan == "growth" ? wage * 12 / 10 : wage`
- `WinBonus` = `plan == "performance" ? wage : plan == "growth" ? wage / 5 : wage / 4`

<a id="symbol-e45e226b122d"></a>

## `NationalSpire.OwnedClubs.SigningError(NationalSpire.CareerData, NationalSpire.ClubSigning, bool) — public static string? SigningError(CareerData d, ClubSigning signing, bool transfer = false)`

来源：源码第 90 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OwnedClubs.CreationError(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-c66d40eab5e9)；[`NationalSpire.OwnedClubs.RecruitError(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-af6739305612)；[`NationalSpire.OwnedClubs.TransferError(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-dd969fd199a4)；[`NationalSpire.PrivateContracts.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-dbd791b573e7)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.OwnedClubs.Candidates(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-86d3ae3f2a68)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Id`；`NationalSpire.ClubSigning.PersonId`；`NationalSpire.ClubSigning.Plan`；`NationalSpire.ClubSigning.Position`；`NationalSpire.OwnedClubs.Candidates(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, signing.PersonId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: transfer ? CareerEngine.Person(d, signing.PersonId) : Candidates(d).FirstOrDefault(p => p.Id == signing.PersonId)`
- `NationalSpire.OwnedClubs.Candidates(NationalSpire.CareerData)`；输入表达式：`Candidates(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Candidates(d).FirstOrDefault`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`Candidates(d).FirstOrDefault(p => p.Id == signing.PersonId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: transfer ? CareerEngine.Person(d, signing.PersonId) : Candidates(d).FirstOrDefault(p => p.Id == signing.PersonId)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fb2b56604db1"></a>

## `NationalSpire.OwnedClubs.SponsorQuote(NationalSpire.CareerData, string) — public static OwnedSponsor SponsorQuote(CareerData d, string id)`

来源：源码第 97 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubReview(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubScreen.cs.md#symbol-ae7b54f0270a)；[`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)；[`NationalSpire.OwnedClubs.Advance(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-7fe29c98085a)；[`NationalSpire.OwnedClubs.ChangeSponsor(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-a1b523b0541a)；[`NationalSpire.OwnedClubs.CreateCore(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-21d1184d2591)

**调用：** [`NationalSpire.RegionalOrganizations.Sponsor(NationalSpire.CareerData, string, int, string)`](RegionalOrganizations.cs.md#symbol-fac63dbdfc35)；`NationalSpire.OwnedSponsor.OwnedSponsor()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.OwnedSponsor.AudienceVersion`；`NationalSpire.OwnedSponsor.Brand`；`NationalSpire.OwnedSponsor.EndDay`；`NationalSpire.OwnedSponsor.FanRate`；`NationalSpire.OwnedSponsor.Id`；`NationalSpire.OwnedSponsor.Weekly`；`NationalSpire.OwnedSponsor.WinBonus`；`NationalSpire.RegionalOrganizations.Sponsor(NationalSpire.CareerData, string, int, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.OwnedSponsor.OwnedSponsor()`；输入表达式：`new() { AudienceVersion = 1, Id = "steady", Brand = RegionalOrganizations.Sponsor(d, d.Esports.Country, 0, "owned"), Weekly = 1400, WinBonus = 400, FanRate = 10, EndDay = d.Day + 56 }`；返回值紧邻使用处：`SwitchExpressionArmSyntax: _ => new() { AudienceVersion = 1, Id = "steady", Brand = RegionalOrganizations.Sponsor(d, d.Esports.Country, 0, "owned"), Weekly = 1400, WinBonus = 400, FanRate = 10, EndDay = d.Day + 56 }`
- `NationalSpire.OwnedSponsor.OwnedSponsor()`；输入表达式：`new() { AudienceVersion = 1, Id = id, Brand = RegionalOrganizations.Sponsor(d, d.Esports.Country, 1, "owned"), Weekly = 1100, WinBonus = 1000, FanRate = 15, EndDay = d.Day + 56 }`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "results" => new() { AudienceVersion = 1, Id = id, Brand = RegionalOrganizations.Sponsor(d, d.Esports.Country, 1, "owned"), Weekly = 1100, WinBonus = 1000, FanRate = 15, EndDay = d.Day + 56 }`
- `NationalSpire.OwnedSponsor.OwnedSponsor()`；输入表达式：`new() { AudienceVersion = 1, Id = id, Brand = RegionalOrganizations.Sponsor(d, d.Esports.Country, 2, "owned"), Weekly = 1000, WinBonus = 300, FanRate = 4, EndDay = d.Day + 56 }`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "fans" => new() { AudienceVersion = 1, Id = id, Brand = RegionalOrganizations.Sponsor(d, d.Esports.Country, 2, "owned"), Weekly = 1000, WinBonus = 300, FanRate = 4, EndDay = d.Day + 56 }`
- `NationalSpire.RegionalOrganizations.Sponsor(NationalSpire.CareerData, string, int, string)`；输入表达式：`RegionalOrganizations.Sponsor(d, d.Esports.Country, 0, "owned")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Brand = RegionalOrganizations.Sponsor(d, d.Esports.Country, 0, "owned")`
- `NationalSpire.RegionalOrganizations.Sponsor(NationalSpire.CareerData, string, int, string)`；输入表达式：`RegionalOrganizations.Sponsor(d, d.Esports.Country, 1, "owned")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Brand = RegionalOrganizations.Sponsor(d, d.Esports.Country, 1, "owned")`
- `NationalSpire.RegionalOrganizations.Sponsor(NationalSpire.CareerData, string, int, string)`；输入表达式：`RegionalOrganizations.Sponsor(d, d.Esports.Country, 2, "owned")`；返回值紧邻使用处：`AssignmentExpressionSyntax: Brand = RegionalOrganizations.Sponsor(d, d.Esports.Country, 2, "owned")`

**赋值（含属性/字段和局部值）：**

- `AudienceVersion` = `1`
- `Brand` = `RegionalOrganizations.Sponsor(d, d.Esports.Country, 0, "owned")`
- `Brand` = `RegionalOrganizations.Sponsor(d, d.Esports.Country, 1, "owned")`
- `Brand` = `RegionalOrganizations.Sponsor(d, d.Esports.Country, 2, "owned")`
- `EndDay` = `d.Day + 56`
- `FanRate` = `10`
- `FanRate` = `15`
- `FanRate` = `4`
- `Id` = `"steady"`
- `Id` = `id`
- `Weekly` = `1000`
- `Weekly` = `1100`
- `Weekly` = `1400`
- `WinBonus` = `1000`
- `WinBonus` = `300`
- `WinBonus` = `400`

<a id="symbol-c9d09ed04c48"></a>

## `NationalSpire.OwnedClubs.SponsorWeekly(NationalSpire.OwnedSponsor?, int) — public static int SponsorWeekly(OwnedSponsor? s, int fans)`

来源：源码第 103 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubWeeklyFinance(Godot.VBoxContainer, NationalSpire.OwnedSponsor?, int, decimal, int)`](OwnedClubScreen.cs.md#symbol-e4836a392d68)；[`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)；[`NationalSpire.OwnedClubs.Advance(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-7fe29c98085a)；[`NationalSpire.OwnedClubs.BreakEvenFans(NationalSpire.OwnedSponsor?, decimal)`](OwnedClubs.cs.md#symbol-8b262987c35a)

**调用：** [`NationalSpire.CareerAudience.ClubMultiplier(int)`](CareerAudience.cs.md#symbol-6230afa93ab3)；`System.Math.Round(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAudience.ClubMultiplier(int)`；`NationalSpire.OwnedSponsor.Weekly`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerAudience.ClubMultiplier(int)`；输入表达式：`CareerAudience.ClubMultiplier(fans)`；返回值紧邻使用处：`BinaryExpressionSyntax: s.Weekly * CareerAudience.ClubMultiplier(fans)`
- `System.Math.Round(double)`；输入表达式：`Math.Round(s.Weekly * CareerAudience.ClubMultiplier(fans))`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round(s.Weekly * CareerAudience.ClubMultiplier(fans))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-27e3d96628f4"></a>

## `NationalSpire.OwnedClubs.SponsorWinBonus(NationalSpire.OwnedSponsor, int) — public static int SponsorWinBonus(OwnedSponsor s, int fans)`

来源：源码第 104 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)；[`NationalSpire.OwnedClubs.SettleResults(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-7c6dba67fe98)

**调用：** [`NationalSpire.CareerAudience.ClubMultiplier(int)`](CareerAudience.cs.md#symbol-6230afa93ab3)；`System.Math.Round(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAudience.ClubMultiplier(int)`；`NationalSpire.OwnedSponsor.WinBonus`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerAudience.ClubMultiplier(int)`；输入表达式：`CareerAudience.ClubMultiplier(fans)`；返回值紧邻使用处：`BinaryExpressionSyntax: s.WinBonus * CareerAudience.ClubMultiplier(fans)`
- `System.Math.Round(double)`；输入表达式：`Math.Round(s.WinBonus * CareerAudience.ClubMultiplier(fans))`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round(s.WinBonus * CareerAudience.ClubMultiplier(fans))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b2b3c8e1de88"></a>

## `NationalSpire.OwnedClubs.AudienceIncome(int) — public static int AudienceIncome(int fans)`

来源：源码第 105 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubWeeklyFinance(Godot.VBoxContainer, NationalSpire.OwnedSponsor?, int, decimal, int)`](OwnedClubScreen.cs.md#symbol-e4836a392d68)；[`NationalSpire.OwnedClubs.Advance(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-7fe29c98085a)；[`NationalSpire.OwnedClubs.BreakEvenFans(NationalSpire.OwnedSponsor?, decimal)`](OwnedClubs.cs.md#symbol-8b262987c35a)

**调用：** [`NationalSpire.CareerAudience.ClubMultiplier(int)`](CareerAudience.cs.md#symbol-6230afa93ab3)；`System.Math.Round(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAudience.ClubMultiplier(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerAudience.ClubMultiplier(int)`；输入表达式：`CareerAudience.ClubMultiplier(fans)`；返回值紧邻使用处：`BinaryExpressionSyntax: 100 * CareerAudience.ClubMultiplier(fans)`
- `System.Math.Round(double)`；输入表达式：`Math.Round(100 * CareerAudience.ClubMultiplier(fans))`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Round(100 * CareerAudience.ClubMultiplier(fans))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-522aa99991c7"></a>

## `NationalSpire.OwnedClubs.InitialCost(NationalSpire.CareerData, NationalSpire.ClubDraft) — public static decimal InitialCost(CareerData d, ClubDraft draft)`

来源：源码第 106 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubReview(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubScreen.cs.md#symbol-ae7b54f0270a)；[`NationalSpire.CareerScreen.ClubWizard(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-8f3c0cb211aa)；[`NationalSpire.OwnedClubs.CreationError(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-c66d40eab5e9)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`](OwnedClubs.cs.md#symbol-6507b91ba56b)；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, decimal>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.ClubDraft.Signings`；`NationalSpire.ClubSigning.PersonId`；`NationalSpire.ClubSigning.Plan`；`NationalSpire.OwnedClubs.FoundingCost`；`NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`；`NationalSpire.OwnedPlayerContract.Signing`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, s.PersonId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(d, s.PersonId) is { } p`
- `NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`；输入表达式：`Quote(p, s.Plan)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Quote(p, s.Plan).Signing`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, decimal>)`；输入表达式：`draft.Signings.Sum(s =>          CareerEngine.Person(d, s.PersonId) is { } p ? Quote(p, s.Plan).Signing : 0)`；返回值紧邻使用处：`BinaryExpressionSyntax: FoundingCost + draft.Signings.Sum(s =>          CareerEngine.Person(d, s.PersonId) is { } p ? Quote(p, s.Plan).Signing : 0)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d56a24efadf8"></a>

## `NationalSpire.OwnedClubs.WeeklyWages(NationalSpire.CareerData, NationalSpire.ClubDraft) — public static decimal WeeklyWages(CareerData d, ClubDraft draft)`

来源：源码第 108 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubReview(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubScreen.cs.md#symbol-ae7b54f0270a)；[`NationalSpire.CareerScreen.ClubWizard(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-8f3c0cb211aa)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.OwnedClubs.HumanWages(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-c289d3fb015c)；[`NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`](OwnedClubs.cs.md#symbol-6507b91ba56b)；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, decimal>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.ClubDraft.Signings`；`NationalSpire.ClubSigning.PersonId`；`NationalSpire.ClubSigning.Plan`；`NationalSpire.OwnedClubs.HumanWages(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`；`NationalSpire.OwnedPlayerContract.Wage`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, s.PersonId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(d, s.PersonId) is { } p`
- `NationalSpire.OwnedClubs.HumanWages(NationalSpire.CareerData)`；输入表达式：`HumanWages(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: HumanWages(d) + draft.Signings.Sum(s => CareerEngine.Person(d, s.PersonId) is { } p ? Quote(p, s.Plan).Wage : 0)`
- `NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`；输入表达式：`Quote(p, s.Plan)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Quote(p, s.Plan).Wage`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, decimal>)`；输入表达式：`draft.Signings.Sum(s => CareerEngine.Person(d, s.PersonId) is { } p ? Quote(p, s.Plan).Wage : 0)`；返回值紧邻使用处：`BinaryExpressionSyntax: HumanWages(d) + draft.Signings.Sum(s => CareerEngine.Person(d, s.PersonId) is { } p ? Quote(p, s.Plan).Wage : 0)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1036b8f22501"></a>

## `NationalSpire.OwnedClubs.PaidHumans(NationalSpire.CareerData) — public static List<string> PaidHumans(CareerData d)`

来源：源码第 109 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)；[`NationalSpire.OwnedClubs.AccrueHumanPay(NationalSpire.CareerData, int)`](OwnedClubs.cs.md#symbol-9f011457ce0c)；[`NationalSpire.OwnedClubs.HumanWages(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-c289d3fb015c)

**调用：** [`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-241a535c93f9)；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubState.ManagerId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；输入表达式：`Humans(d)`；返回值紧邻使用处：`ElementAccessExpressionSyntax: Humans(d)[0]`
- `NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；输入表达式：`Humans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Humans(d).Where`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`Humans(d).Where(id => id != (d.Esports.OwnedClub?.ManagerId is { } manager && d.HumanIds.Contains(manager) ? manager : Humans(d)[0])).ToList()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Humans(d).Where(id => id != (d.Esports.OwnedClub?.ManagerId is { } manager && d.HumanIds.Contains(manager) ? manager : Humans(d)[0])).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`Humans(d).Where(id => id != (d.Esports.OwnedClub?.ManagerId is { } manager && d.HumanIds.Contains(manager) ? manager : Humans(d)[0]))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Humans(d).Where(id => id != (d.Esports.OwnedClub?.ManagerId is { } manager && d.HumanIds.Contains(manager) ? manager : Humans(d)[0])).ToList`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`d.HumanIds.Contains(manager)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Esports.OwnedClub?.ManagerId is { } manager && d.HumanIds.Contains(manager)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c289d3fb015c"></a>

## `NationalSpire.OwnedClubs.HumanWages(NationalSpire.CareerData) — public static int HumanWages(CareerData d)`

来源：源码第 110 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubReview(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubScreen.cs.md#symbol-ae7b54f0270a)；[`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)；[`NationalSpire.OwnedClubs.WeeklyWages(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-d56a24efadf8)

**调用：** [`NationalSpire.OwnedClubs.PaidHumans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-1036b8f22501)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.HumanWeeklyWage`；`NationalSpire.OwnedClubs.PaidHumans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubState.HumanWeeklyWage`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.OwnedClubs.PaidHumans(NationalSpire.CareerData)`；输入表达式：`PaidHumans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PaidHumans(d).Count`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9f011457ce0c"></a>

## `NationalSpire.OwnedClubs.AccrueHumanPay(NationalSpire.CareerData, int) — public static void AccrueHumanPay(CareerData d, int amount)`

来源：源码第 111 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OwnedClubs.Advance(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-7fe29c98085a)；[`NationalSpire.OwnedClubs.SettleResults(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-7c6dba67fe98)

**调用：** [`NationalSpire.OwnedClubs.PaidHumans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-1036b8f22501)；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.PaidHumans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubState.HumanPayDue`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.OwnedClubs.PaidHumans(NationalSpire.CareerData)`；输入表达式：`PaidHumans(d)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string id in PaidHumans(d))              d.Esports.OwnedClub!.HumanPayDue[id] = checked(d.Esports.OwnedClub.HumanPayDue.GetValueOrDefault(id) + amount);`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`d.Esports.OwnedClub.HumanPayDue.GetValueOrDefault(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Esports.OwnedClub.HumanPayDue.GetValueOrDefault(id) + amount`

**赋值（含属性/字段和局部值）：**

- `d.Esports.OwnedClub!.HumanPayDue[id]` = `checked(d.Esports.OwnedClub.HumanPayDue.GetValueOrDefault(id) + amount)`

<a id="symbol-c667223bed4e"></a>

## `NationalSpire.OwnedClubs.GrantFans(NationalSpire.OwnedClubState, int) — public static int GrantFans(OwnedClubState o, int baseGain)`

来源：源码第 116 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OwnedClubs.AwardCommercial(NationalSpire.CareerData, string, string, int, int)`](OwnedClubs.cs.md#symbol-6b465628386d)；[`NationalSpire.OwnedClubs.CompleteActivity(NationalSpire.CareerData, NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-d53f4fbd3e4e)；[`NationalSpire.OwnedClubs.SettleResults(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-7c6dba67fe98)

**调用：** `System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.OwnedClubState.Fans`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Min(int, int)`；输入表达式：`Math.Min(int.MaxValue - o.Fans, baseGain)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(int.MaxValue - o.Fans, baseGain)`

**赋值（含属性/字段和局部值）：**

- `o.Fans` += `added`

<a id="symbol-e35919f4f29f"></a>

## `NationalSpire.OwnedClubs.StartingFans(NationalSpire.CareerData) — public static int StartingFans(CareerData d)`

来源：源码第 122 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubReview(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubScreen.cs.md#symbol-ae7b54f0270a)；[`NationalSpire.OwnedClubs.CreateCore(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-21d1184d2591)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f459a7689794"></a>

## `NationalSpire.OwnedClubs.UpgradeEconomy(NationalSpire.CareerData) — public static void UpgradeEconomy(CareerData d)`

来源：源码第 123 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OwnedClubs.EnsureMarket(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-3dba497c8606)；[`NationalSpire.OwnedClubs.SettleResults(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-7c6dba67fe98)

**调用：** `System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubState.EconomyVersion`；`NationalSpire.OwnedClubState.Fans`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Max(int, int)`；输入表达式：`Math.Max(300, o.Fans)`；返回值紧邻使用处：`AssignmentExpressionSyntax: o.Fans = Math.Max(300, o.Fans)`

**赋值（含属性/字段和局部值）：**

- `o.EconomyVersion` = `1`
- `o.Fans` = `Math.Max(300, o.Fans)`

<a id="symbol-6261fe2caa42"></a>

## `NationalSpire.OwnedClubs.AchievementWeekly(NationalSpire.CareerData, int?) — public static int AchievementWeekly(CareerData d, int? day = null)`

来源：源码第 129 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)；[`NationalSpire.OwnedClubs.Advance(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-7fe29c98085a)

**调用：** `System.Collections.Generic.IEnumerable<int>.Max()`；`System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedAchievementSponsor.EndDay`；`NationalSpire.OwnedAchievementSponsor.StartDay`；`NationalSpire.OwnedAchievementSponsor.Weekly`；`NationalSpire.OwnedClubState.AchievementSponsors`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<int>.Max()`；输入表达式：`.AchievementSponsors          .Where(s => day.HasValue ? s.StartDay < day.Value && s.EndDay >= day.Value : s.StartDay <= d.Day && s.EndDay > d.Day).Select(s => s.Weekly).DefaultIfEmpty().Max()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: d.Esports.OwnedClub?.AchievementSponsors          .Where(s => day.HasValue ? s.StartDay < day.Value && s.EndDay >= day.Value : s.StartDay <= d.Day && s.EndDay > d.Day).Select(s => s.Weekly).DefaultIfEmpty().Max()`
- `System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>()`；输入表达式：`.AchievementSponsors          .Where(s => day.HasValue ? s.StartDay < day.Value && s.EndDay >= day.Value : s.StartDay <= d.Day && s.EndDay > d.Day).Select(s => s.Weekly).DefaultIfEmpty()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: .AchievementSponsors          .Where(s => day.HasValue ? s.StartDay < day.Value && s.EndDay >= day.Value : s.StartDay <= d.Day && s.EndDay > d.Day).Select(s => s.Weekly).DefaultIfEmpty().Max`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`.AchievementSponsors          .Where(s => day.HasValue ? s.StartDay < day.Value && s.EndDay >= day.Value : s.StartDay <= d.Day && s.EndDay > d.Day).Select(s => s.Weekly)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: .AchievementSponsors          .Where(s => day.HasValue ? s.StartDay < day.Value && s.EndDay >= day.Value : s.StartDay <= d.Day && s.EndDay > d.Day).Select(s => s.Weekly).DefaultIfEmpty`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`.AchievementSponsors          .Where(s => day.HasValue ? s.StartDay < day.Value && s.EndDay >= day.Value : s.StartDay <= d.Day && s.EndDay > d.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: .AchievementSponsors          .Where(s => day.HasValue ? s.StartDay < day.Value && s.EndDay >= day.Value : s.StartDay <= d.Day && s.EndDay > d.Day).Select`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5451d41611c1"></a>

## `NationalSpire.OwnedClubs.PlacementReward(string, int) — public static (int Fans, int Weekly) PlacementReward(string kind, int rank)`

来源：源码第 131 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OwnedClubs.SettleAchievements(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-51faa8d5ccbd)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `(T1, T2).Item1`；`(T1, T2).Item2`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6b465628386d"></a>

## `NationalSpire.OwnedClubs.AwardCommercial(NationalSpire.CareerData, string, string, int, int) — private static void AwardCommercial(CareerData d, string key, string title, int fans, int weekly)`

来源：源码第 136 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OwnedClubs.SettleAchievements(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-51faa8d5ccbd)

**调用：** [`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.OwnedClubs.GrantFans(NationalSpire.OwnedClubState, int)`](OwnedClubs.cs.md#symbol-c667223bed4e)；[`NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`](OwnedClubs.cs.md#symbol-3b85db324fce)；[`NationalSpire.OwnedClubs.Report(NationalSpire.CareerData, string, string, string, System.Collections.Generic.List<string>)`](OwnedClubs.cs.md#symbol-4a616a09019e)；`NationalSpire.OwnedAchievementSponsor.OwnedAchievementSponsor()`；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedAchievementSponsor.EndDay`；`NationalSpire.OwnedAchievementSponsor.StartDay`；`NationalSpire.OwnedAchievementSponsor.Title`；`NationalSpire.OwnedAchievementSponsor.Weekly`；`NationalSpire.OwnedClubs.GrantFans(NationalSpire.OwnedClubState, int)`；`NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；`NationalSpire.OwnedClubs.Report(NationalSpire.CareerData, string, string, string, System.Collections.Generic.List<string>)`；`NationalSpire.OwnedClubState.AchievementSponsors`；`NationalSpire.OwnedClubState.RevenueAwards`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(weekly * 2)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(weekly * 2)}`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(weekly)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(weekly)}`
- `NationalSpire.OwnedAchievementSponsor.OwnedAchievementSponsor()`；输入表达式：`new() { Title = title, Weekly = weekly, StartDay = d.Day, EndDay = d.Day + 56 }`；返回值紧邻使用处：`ArgumentSyntax: new() { Title = title, Weekly = weekly, StartDay = d.Day, EndDay = d.Day + 56 }`
- `NationalSpire.OwnedClubs.GrantFans(NationalSpire.OwnedClubState, int)`；输入表达式：`GrantFans(o, fans)`；返回值紧邻使用处：`AssignmentExpressionSyntax: fans = GrantFans(o, fans)`
- `NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；输入表达式：`Pay(d, title + "赞助签约奖励", weekly * 2)`；返回值紧邻使用处：`ExpressionStatementSyntax: Pay(d, title + "赞助签约奖励", weekly * 2);`
- `NationalSpire.OwnedClubs.Report(NationalSpire.CareerData, string, string, string, System.Collections.Generic.List<string>)`；输入表达式：`Report(d, "赞助", title + "带来新赞助", $"关注增加{fans}，签约奖励{CareerMoney.Format(weekly * 2)}，未来八周成绩赞助每周{CareerMoney.Format(weekly)}。同类成绩赞助按最高档支付。", [])`；返回值紧邻使用处：`ExpressionStatementSyntax: Report(d, "赞助", title + "带来新赞助", $"关注增加{fans}，签约奖励{CareerMoney.Format(weekly * 2)}，未来八周成绩赞助每周{CareerMoney.Format(weekly)}。同类成绩赞助按最高档支付。", []);`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`o.RevenueAwards.Add(key)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !o.RevenueAwards.Add(key)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`o.AchievementSponsors.Add(new() { Title = title, Weekly = weekly, StartDay = d.Day, EndDay = d.Day + 56 })`；返回值紧邻使用处：`ExpressionStatementSyntax: o.AchievementSponsors.Add(new() { Title = title, Weekly = weekly, StartDay = d.Day, EndDay = d.Day + 56 });`

**赋值（含属性/字段和局部值）：**

- `EndDay` = `d.Day + 56`
- `fans` = `GrantFans(o, fans)`
- `StartDay` = `d.Day`
- `Title` = `title`
- `Weekly` = `weekly`

<a id="symbol-51faa8d5ccbd"></a>

## `NationalSpire.OwnedClubs.SettleAchievements(NationalSpire.CareerData) — public static void SettleAchievements(CareerData d)`

来源：源码第 145 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitLedger.Settle(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`](CircuitLedger.cs.md#symbol-8ff7b69864e0)；[`NationalSpire.OwnedClubs.SettleResults(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-7c6dba67fe98)

**调用：** [`NationalSpire.CircuitWorld.RoundCount(NationalSpire.WorldCompetition)`](CircuitWorld.cs.md#symbol-95620df3f1f6)；[`NationalSpire.CircuitWorld.TeamTable(NationalSpire.WorldCompetition)`](CircuitWorld.cs.md#symbol-ca39b3e6a0f0)；[`NationalSpire.OwnedClubs.AwardCommercial(NationalSpire.CareerData, string, string, int, int)`](OwnedClubs.cs.md#symbol-6b465628386d)；[`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-8c9ea9f33c3c)；[`NationalSpire.OwnedClubs.PlacementReward(string, int)`](OwnedClubs.cs.md#symbol-5451d41611c1)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Max<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.Min<TSource>(System.Func<TSource, int>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`

**字段、属性、事件及方法组引用：** `(int Fans, int Weekly).Fans`；`(int Fans, int Weekly).Weekly`；`(int Round, string HomeTeam, string AwayTeam).HomeTeam`；`(int Round, string HomeTeam, string AwayTeam).Round`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerStanding.PersonId`；`NationalSpire.CircuitWorld.RoundCount(NationalSpire.WorldCompetition)`；`NationalSpire.CircuitWorld.TeamTable(NationalSpire.WorldCompetition)`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.AwardCommercial(NationalSpire.CareerData, string, string, int, int)`；`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.PlacementReward(string, int)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.WorldCompetition.ChampionTeam`；`NationalSpire.WorldCompetition.Cooperative`；`NationalSpire.WorldCompetition.Finished`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Name`；`NationalSpire.WorldCompetition.TeamEvent`；`NationalSpire.WorldCompetition.Teams`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.AwayTeam`；`NationalSpire.WorldFixture.Day`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.HomeTeam`；`NationalSpire.WorldFixture.Round`；`NationalSpire.WorldFixture.Walkover`；`NationalSpire.WorldFixture.WinnerId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CircuitWorld.RoundCount(NationalSpire.WorldCompetition)`；输入表达式：`CircuitWorld.RoundCount(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: CircuitWorld.RoundCount(c) - ties.Max(g => g.Key.Round)`
- `NationalSpire.CircuitWorld.TeamTable(NationalSpire.WorldCompetition)`；输入表达式：`CircuitWorld.TeamTable(c)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: CircuitWorld.TeamTable(c).FindIndex`
- `NationalSpire.OwnedClubs.AwardCommercial(NationalSpire.CareerData, string, string, int, int)`；输入表达式：`AwardCommercial(d, c.Id + ":placement", c.Name + (rank == 1 ? "冠军" : rank == 2 ? "亚军" : c.Kind == "league" ? $"第{rank}名" : $"{rank}强"), reward.Fans, reward.Weekly)`；返回值紧邻使用处：`ExpressionStatementSyntax: AwardCommercial(d, c.Id + ":placement", c.Name + (rank == 1 ? "冠军" : rank == 2 ? "亚军" : c.Kind == "league" ? $"第{rank}名" : $"{rank}强"), reward.Fans, reward.Weekly);`
- `NationalSpire.OwnedClubs.AwardCommercial(NationalSpire.CareerData, string, string, int, int)`；输入表达式：`AwardCommercial(d, c.Id + ":streak3", "联赛三连胜", 600, 300)`；返回值紧邻使用处：`ExpressionStatementSyntax: AwardCommercial(d, c.Id + ":streak3", "联赛三连胜", 600, 300);`
- `NationalSpire.OwnedClubs.AwardCommercial(NationalSpire.CareerData, string, string, int, int)`；输入表达式：`AwardCommercial(d, c.Id + ":streak5", "联赛五连胜", 1200, 600)`；返回值紧邻使用处：`ExpressionStatementSyntax: AwardCommercial(d, c.Id + ":streak5", "联赛五连胜", 1200, 600);`
- `NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；输入表达式：`IsOwner(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsOwner(d)`
- `NationalSpire.OwnedClubs.PlacementReward(string, int)`；输入表达式：`PlacementReward(c.Kind, rank)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PlacementReward(c.Kind, rank)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.Any(f => !f.Finished)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.Any(f => !f.Finished)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`tie.Any(f => !f.Finished)`；返回值紧邻使用处：`BinaryExpressionSyntax: tie.Count() != (c.Cooperative ? 1 : 3) || tie.Any(f => !f.Finished)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`tie.Any(f => f.Walkover)`；返回值紧邻使用处：`IfStatementSyntax: if (tie.Any(f => f.Walkover)) continue;`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`ties.Any(g => g.Any(f => !f.Finished))`；返回值紧邻使用处：`BinaryExpressionSyntax: !c.Finished || ties.Count == 0 || ties.Any(g => g.Any(f => !f.Finished))`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`tie.Count()`；返回值紧邻使用处：`BinaryExpressionSyntax: tie.Count() != (c.Cooperative ? 1 : 3)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`tie.Count(f => f.WinnerId == (home ? f.HomeId : f.AwayId))`；返回值紧邻使用处：`BinaryExpressionSyntax: tie.Count(f => f.WinnerId == (home ? f.HomeId : f.AwayId)) >= (c.Cooperative ? 1 : 2)`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`c.Fixtures.Where(f => f.HomeTeam == o.ClubId || f.AwayTeam == o.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.HomeTeam == o.ClubId || f.AwayTeam == o.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).OrderBy`
- `System.Collections.Generic.IEnumerable<TSource>.Max<TSource>(System.Func<TSource, int>)`；输入表达式：`ties.Max(g => g.Key.Round)`；返回值紧邻使用处：`BinaryExpressionSyntax: CircuitWorld.RoundCount(c) - ties.Max(g => g.Key.Round)`
- `System.Collections.Generic.IEnumerable<TSource>.Min<TSource>(System.Func<TSource, int>)`；输入表达式：`g.Min(f => f.Day)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: g => g.Min(f => f.Day)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`c.Fixtures.Where(f => f.HomeTeam == o.ClubId || f.AwayTeam == o.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).OrderBy(g => g.Min(f => f.Day))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.HomeTeam == o.ClubId || f.AwayTeam == o.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).OrderBy(g => g.Min(f => f.Day)).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`c.Fixtures.Where(f => f.HomeTeam == o.ClubId || f.AwayTeam == o.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).OrderBy(g => g.Min(f => f.Day)).ThenBy(g => g.Key.Round).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = c.Fixtures.Where(f => f.HomeTeam == o.ClubId || f.AwayTeam == o.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).OrderBy(g => g.Min(f => f.Day)).ThenBy(g => g.Key.Round).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(f => f.HomeTeam == o.ClubId || f.AwayTeam == o.ClubId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.HomeTeam == o.ClubId || f.AwayTeam == o.ClubId)                  .GroupBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Where(c => c.TeamEvent && c.Kind is "league" or "continental" && c.Teams.Contains(o.ClubId))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var c in d.Esports.Competitions.Where(c => c.TeamEvent && c.Kind is "league" or "continental" && c.Teams.Contains(o.ClubId)))          {              var ties = c.Fixtures.Where(f => f.HomeTeam == o.ClubId || f.AwayTeam == o.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).OrderBy(g => g.Min(f => f.Day)).ThenBy(g => g.Key.Round).ToList();              if (c.Kind == "league")              {                  int streak = 0;                  foreach (var tie in ties)                  {                      if (tie.Count() != (c.Cooperative ? 1 : 3) || tie.Any(f => !f.Finished)) break;                      if (tie.Any(f => f.Walkover)) continue;                      bool home = tie.Key.HomeTeam == o.ClubId;                      bool won = tie.Count(f => f.WinnerId == (home ? f.HomeId : f.AwayId)) >= (c.Cooperative ? 1 : 2);                      streak = won ? streak + 1 : 0;                      if (streak == 3) AwardCommercial(d, c.Id + ":streak3", "联赛三连胜", 600, 300);                      if (streak == 5) AwardCommercial(d, c.Id + ":streak5", "联赛五连胜", 1200, 600);                  }              }              if (!c.Finished || ties.Count == 0 || ties.Any(g => g.Any(f => !f.Finished))) continue;              int rank = c.Kind == "league" ? CircuitWorld.TeamTable(c).FindIndex(t => t.PersonId == o.ClubId) + 1                  : c.ChampionTeam == o.ClubId ? 1 : 1 << (CircuitWorld.RoundCount(c) - ties.Max(g => g.Key.Round) + 1);              if (rank < 1) continue;              var reward = PlacementReward(c.Kind, rank);              AwardCommercial(d, c.Id + ":placement", c.Name + (rank == 1 ? "冠军" : rank == 2 ? "亚军" : c.Kind == "league" ? $"第{rank}名" : $"{rank}强"), reward.Fans, reward.Weekly);          }`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`c.Teams.Contains(o.ClubId)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.TeamEvent && c.Kind is "league" or "continental" && c.Teams.Contains(o.ClubId)`
- `System.Collections.Generic.List<T>.FindIndex(System.Predicate<T>)`；输入表达式：`CircuitWorld.TeamTable(c).FindIndex(t => t.PersonId == o.ClubId)`；返回值紧邻使用处：`BinaryExpressionSyntax: CircuitWorld.TeamTable(c).FindIndex(t => t.PersonId == o.ClubId) + 1`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`c.Fixtures.Where(f => f.HomeTeam == o.ClubId || f.AwayTeam == o.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).OrderBy(g => g.Min(f => f.Day)).ThenBy(g => g.Key.Round)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.HomeTeam == o.ClubId || f.AwayTeam == o.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).OrderBy(g => g.Min(f => f.Day)).ThenBy(g => g.Key.Round).ToList`

**赋值（含属性/字段和局部值）：**

- `streak` = `won ? streak + 1 : 0`

<a id="symbol-4dd05f6eadef"></a>

## `NationalSpire.OwnedClubs.FirstLeagueDay(NationalSpire.CareerData) — public static int FirstLeagueDay(CareerData d)`

来源：源码第 175 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OwnedClubs.CanJoinThisSeason(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-9b2deafefa7e)；[`NationalSpire.OwnedClubs.EntryText(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-24aec8a4b1b4)

**调用：** [`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-ee7b01d76b23)；`System.Collections.Generic.IEnumerable<int>.Min()`；`System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Modern`；`NationalSpire.WorldCompetition.Season`；`NationalSpire.WorldFixture.Day`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.Start(d) + 22`
- `System.Collections.Generic.IEnumerable<int>.Min()`；输入表达式：`d.Esports.Competitions.Where(c => c.Season == d.Season && c.Kind == "league" && c.Modern)          .SelectMany(c => c.Fixtures).Select(f => f.Day).DefaultIfEmpty(SeasonCalendar.Start(d) + 22).Min()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => d.Esports.Competitions.Where(c => c.Season == d.Season && c.Kind == "league" && c.Modern)          .SelectMany(c => c.Fixtures).Select(f => f.Day).DefaultIfEmpty(SeasonCalendar.Start(d) + 22).Min()`
- `System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；输入表达式：`d.Esports.Competitions.Where(c => c.Season == d.Season && c.Kind == "league" && c.Modern)          .SelectMany(c => c.Fixtures).Select(f => f.Day).DefaultIfEmpty(SeasonCalendar.Start(d) + 22)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Competitions.Where(c => c.Season == d.Season && c.Kind == "league" && c.Modern)          .SelectMany(c => c.Fixtures).Select(f => f.Day).DefaultIfEmpty(SeasonCalendar.Start(d) + 22).Min`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`d.Esports.Competitions.Where(c => c.Season == d.Season && c.Kind == "league" && c.Modern)          .SelectMany(c => c.Fixtures).Select(f => f.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Competitions.Where(c => c.Season == d.Season && c.Kind == "league" && c.Modern)          .SelectMany(c => c.Fixtures).Select(f => f.Day).DefaultIfEmpty`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`d.Esports.Competitions.Where(c => c.Season == d.Season && c.Kind == "league" && c.Modern)          .SelectMany(c => c.Fixtures)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Competitions.Where(c => c.Season == d.Season && c.Kind == "league" && c.Modern)          .SelectMany(c => c.Fixtures).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Where(c => c.Season == d.Season && c.Kind == "league" && c.Modern)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Competitions.Where(c => c.Season == d.Season && c.Kind == "league" && c.Modern)          .SelectMany`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9b2deafefa7e"></a>

## `NationalSpire.OwnedClubs.CanJoinThisSeason(NationalSpire.CareerData) — public static bool CanJoinThisSeason(CareerData d)`

来源：源码第 177 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubEntry(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-cebea5b172ab)；[`NationalSpire.CareerScreen.ClubInvitation(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-2eeae75151b7)；[`NationalSpire.CareerScreen.ClubWizard(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-8f3c0cb211aa)；[`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.OwnedClubs.CreationError(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-c66d40eab5e9)；[`NationalSpire.OwnedClubSchedule.ChangeRegion(NationalSpire.CareerData, string)`](OwnedClubSchedule.cs.md#symbol-b24bb65463ab)；[`NationalSpire.OwnedClubSchedule.Join(NationalSpire.CareerData, string?)`](OwnedClubSchedule.cs.md#symbol-e637b6152d8b)

**调用：** [`NationalSpire.OwnedClubs.FirstLeagueDay(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-4dd05f6eadef)；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.OwnedClubs.FirstLeagueDay(NationalSpire.CareerData)`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.Season`；`NationalSpire.WorldFixture.Finished`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.OwnedClubs.FirstLeagueDay(NationalSpire.CareerData)`；输入表达式：`FirstLeagueDay(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Day < FirstLeagueDay(d)`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.All(f => !f.Finished)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => c.Fixtures.All(f => !f.Finished)`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Where(c => c.Season == d.Season && c.Kind == "league").All(c => c.Fixtures.All(f => !f.Finished))`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Day < FirstLeagueDay(d)          && d.Esports.Competitions.Where(c => c.Season == d.Season && c.Kind == "league").All(c => c.Fixtures.All(f => !f.Finished))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Where(c => c.Season == d.Season && c.Kind == "league")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.Competitions.Where(c => c.Season == d.Season && c.Kind == "league").All`

**赋值（含属性/字段和局部值）：**


<a id="symbol-241a535c93f9"></a>

## `NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData) — public static List<string> Humans(CareerData d)`

来源：源码第 179 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubProfileActions(NationalSpire.CareerData, NationalSpire.CareerPerson, Godot.VBoxContainer)`](OwnedClubScreen.cs.md#symbol-07281993c5a0)；[`NationalSpire.CareerScreen.ClubWizard(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-8f3c0cb211aa)；[`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)；[`NationalSpire.CharacterDeletion.StarterCandidates(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-3d7604fa699e)；[`NationalSpire.ClubPrograms.Targets(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-30a147299dc6)；[`NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-49a6a4a933e2)；[`NationalSpire.OwnedClubs.Candidates(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-86d3ae3f2a68)；[`NationalSpire.OwnedClubs.CreateCore(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-21d1184d2591)；[`NationalSpire.OwnedClubs.GroupPractice(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, int, int?)`](OwnedClubs.cs.md#symbol-64763de09f26)；[`NationalSpire.OwnedClubs.PaidHumans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-1036b8f22501)；[`NationalSpire.OwnedClubs.PracticeBonus(NationalSpire.CareerData, string, int, int?)`](OwnedClubs.cs.md#symbol-5b2c48d0615a)；[`NationalSpire.OwnedClubs.RepairContractRoster(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.PrivateMailbox>?)`](OwnedClubs.cs.md#symbol-3b98b543bc03)；[`NationalSpire.OwnedClubs.ReplaceableStarters(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-e1cbaaf9f832)；[`NationalSpire.OwnedClubs.StarterReplacementError(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-e4678a15386e)；[`NationalSpire.OwnedClubs.Swap(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-581cdf4f2390)；[`NationalSpire.OwnedClubs.TransferError(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-dd969fd199a4)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.HumanIds`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.HumanIds.ToList()`；返回值紧邻使用处：`ConditionalExpressionSyntax: d.HumanIds.Count > 0 ? d.HumanIds.ToList() : ["player"]`

**赋值（含属性/字段和局部值）：**


<a id="symbol-49a6a4a933e2"></a>

## `NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData) — public static List<string> ActiveHumans(CareerData d)`

来源：源码第 180 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubProfileActions(NationalSpire.CareerData, NationalSpire.CareerPerson, Godot.VBoxContainer)`](OwnedClubScreen.cs.md#symbol-07281993c5a0)；[`NationalSpire.CareerScreen.ClubReview(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubScreen.cs.md#symbol-ae7b54f0270a)；[`NationalSpire.CareerScreen.ClubWizard(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-8f3c0cb211aa)；[`NationalSpire.CharacterDeletion.DeletedStarterVacancy(NationalSpire.CareerData)`](CharacterDeletion.cs.md#symbol-a8f554428afa)；[`NationalSpire.CharacterDeletion.NeedsReplacement(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-9fff1f12bd20)；[`NationalSpire.CharacterDeletion.RepairStarters(NationalSpire.CareerData, bool)`](CharacterDeletion.cs.md#symbol-c88a1645b627)；[`NationalSpire.CircuitWorld.CreateFinals(NationalSpire.CareerData, bool)`](CircuitWorld.cs.md#symbol-cb2c18d20a39)；[`NationalSpire.CircuitWorld.EnsureHumanRosters(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-dd22ca4c2081)；[`NationalSpire.OwnedClubs.CreateCore(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-21d1184d2591)；[`NationalSpire.OwnedClubs.Release(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-ab8d716536a6)；[`NationalSpire.OwnedClubs.RepairContractRoster(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.PrivateMailbox>?)`](OwnedClubs.cs.md#symbol-3b98b543bc03)；[`NationalSpire.OwnedClubs.RequiredAiStarters(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-462ebb119278)；[`NationalSpire.OwnedClubSchedule.OfficialRoster(NationalSpire.CareerData)`](OwnedClubSchedule.cs.md#symbol-d58acd091dd3)

**调用：** [`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-241a535c93f9)；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.MatchHumanIds`；`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；输入表达式：`Humans(d)`；返回值紧邻使用处：`ConditionalExpressionSyntax: d.MatchHumanIds.Count > 0 ? d.MatchHumanIds.ToList() : Humans(d)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.MatchHumanIds.ToList()`；返回值紧邻使用处：`ConditionalExpressionSyntax: d.MatchHumanIds.Count > 0 ? d.MatchHumanIds.ToList() : Humans(d)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-462ebb119278"></a>

## `NationalSpire.OwnedClubs.RequiredAiStarters(NationalSpire.CareerData) — public static int RequiredAiStarters(CareerData d)`

来源：源码第 181 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubMarket(NationalSpire.CareerData, bool)`](OwnedClubScreen.cs.md#symbol-b1e2f4fe72a4)；[`NationalSpire.CareerScreen.ClubWizard(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-8f3c0cb211aa)；[`NationalSpire.OwnedClubs.CreationError(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-c66d40eab5e9)

**调用：** [`NationalSpire.ClubCoaching.PlayerReserve(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-c5c2fb20bef5)；[`NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-49a6a4a933e2)；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.ClubCoaching.PlayerReserve(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ClubCoaching.PlayerReserve(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.PlayerReserve(d)`；返回值紧邻使用处：`ConditionalExpressionSyntax: ClubCoaching.PlayerReserve(d) ? 0 : ActiveHumans(d).Count`
- `NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`；输入表达式：`ActiveHumans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ActiveHumans(d).Count`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, 3 - (ClubCoaching.PlayerReserve(d) ? 0 : ActiveHumans(d).Count))`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => Math.Max(0, 3 - (ClubCoaching.PlayerReserve(d) ? 0 : ActiveHumans(d).Count))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-24aec8a4b1b4"></a>

## `NationalSpire.OwnedClubs.EntryText(NationalSpire.CareerData) — public static string EntryText(CareerData d)`

来源：源码第 182 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubEntry(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-cebea5b172ab)；[`NationalSpire.CareerScreen.ClubInvitation(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-2eeae75151b7)

**调用：** [`NationalSpire.OwnedClubs.FirstLeagueDay(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-4dd05f6eadef)；[`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-0f707d2c9895)

**字段、属性、事件及方法组引用：** `NationalSpire.OwnedClubs.FirstLeagueDay(NationalSpire.CareerData)`；`NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.OwnedClubs.FirstLeagueDay(NationalSpire.CareerData)`；输入表达式：`FirstLeagueDay(d)`；返回值紧邻使用处：`ArgumentSyntax: FirstLeagueDay(d)`
- `NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Day(d, FirstLeagueDay(d))`；返回值紧邻使用处：`InterpolationSyntax: {SeasonCalendar.Day(d, FirstLeagueDay(d))}`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c66d40eab5e9"></a>

## `NationalSpire.OwnedClubs.CreationError(NationalSpire.CareerData, NationalSpire.ClubDraft) — public static string? CreationError(CareerData d, ClubDraft draft)`

来源：源码第 183 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubReview(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubScreen.cs.md#symbol-ae7b54f0270a)；[`NationalSpire.OwnedClubs.Create(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-2a700a81b2ac)

**调用：** [`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.OwnedClubs.CanJoinThisSeason(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-9b2deafefa7e)；[`NationalSpire.OwnedClubs.InitialCost(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-522aa99991c7)；[`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-8c9ea9f33c3c)；[`NationalSpire.OwnedClubs.RequiredAiStarters(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-462ebb119278)；[`NationalSpire.OwnedClubs.SigningError(NationalSpire.CareerData, NationalSpire.ClubSigning, bool)`](OwnedClubs.cs.md#symbol-e45e226b122d)；`string.IsNullOrWhiteSpace(string?)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`string.Trim()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerClub.Name`；`NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.ClubDraft.Color`；`NationalSpire.ClubDraft.Name`；`NationalSpire.ClubDraft.Region`；`NationalSpire.ClubDraft.Signings`；`NationalSpire.ClubDraft.Sponsor`；`NationalSpire.ClubSigning.PersonId`；`NationalSpire.ClubSigning.Position`；`NationalSpire.EsportsCareer.Clubs`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsCareer.EcosystemVersion`；`NationalSpire.EsportsWorld.Countries`；`NationalSpire.OwnedClubs.CanJoinThisSeason(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.Colors`；`NationalSpire.OwnedClubs.InitialCost(NationalSpire.CareerData, NationalSpire.ClubDraft)`；`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.RequiredAiStarters(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.SigningError(NationalSpire.CareerData, NationalSpire.ClubSigning, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(cost - d.Credits)`；返回值紧邻使用处：`BinaryExpressionSyntax: "资金不足，还差 " + CareerMoney.Format(cost - d.Credits)`
- `NationalSpire.OwnedClubs.CanJoinThisSeason(NationalSpire.CareerData)`；输入表达式：`CanJoinThisSeason(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CanJoinThisSeason(d)`
- `NationalSpire.OwnedClubs.InitialCost(NationalSpire.CareerData, NationalSpire.ClubDraft)`；输入表达式：`InitialCost(d, draft)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = InitialCost(d, draft)`
- `NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；输入表达式：`IsOwner(d)`；返回值紧邻使用处：`IfStatementSyntax: if (IsOwner(d)) return "你已经拥有一家俱乐部。";`
- `NationalSpire.OwnedClubs.RequiredAiStarters(NationalSpire.CareerData)`；输入表达式：`RequiredAiStarters(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = RequiredAiStarters(d)`
- `NationalSpire.OwnedClubs.SigningError(NationalSpire.CareerData, NationalSpire.ClubSigning, bool)`；输入表达式：`SigningError(d, s)`；返回值紧邻使用处：`IsPatternExpressionSyntax: SigningError(d, s) is { } error`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(draft.Name)`；返回值紧邻使用处：`BinaryExpressionSyntax: string.IsNullOrWhiteSpace(draft.Name) || draft.Name.Trim().Length > 20`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", missing)`；返回值紧邻使用处：`BinaryExpressionSyntax: "还缺 " + string.Join("、", missing)`
- `string.Trim()`；输入表达式：`draft.Name.Trim()`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Name == draft.Name.Trim()`
- `string.Trim()`；输入表达式：`draft.Name.Trim()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: draft.Name.Trim().Length`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Clubs.Any(c => c.Name == draft.Name.Trim())`；返回值紧邻使用处：`IfStatementSyntax: if (d.Esports.Clubs.Any(c => c.Name == draft.Name.Trim())) return "已经有同名俱乐部。";`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`draft.Name.Any(char.IsControl)`；返回值紧邻使用处：`BinaryExpressionSyntax: string.IsNullOrWhiteSpace(draft.Name) || draft.Name.Trim().Length > 20 || draft.Name.Any(char.IsControl)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`Colors.Contains(draft.Color)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Colors.Contains(draft.Color)`
- `System.Collections.Generic.IEnumerable<TSource>.Contains<TSource>(TSource)`；输入表达式：`EsportsWorld.Countries.Contains(draft.Region.Length == 0 ? d.Esports.Country : draft.Region)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !EsportsWorld.Countries.Contains(draft.Region.Length == 0 ? d.Esports.Country : draft.Region)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`draft.Signings.Select(s => s.PersonId).Distinct().Count()`；返回值紧邻使用处：`BinaryExpressionSyntax: draft.Signings.Select(s => s.PersonId).Distinct().Count() != draft.Signings.Count`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`draft.Signings.Count(s => s.Position == "轮换")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = draft.Signings.Count(s => s.Position == "轮换")`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`draft.Signings.Count(s => s.Position == "首发")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = draft.Signings.Count(s => s.Position == "首发")`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`draft.Signings.Select(s => s.PersonId).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: draft.Signings.Select(s => s.PersonId).Distinct().Count`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`draft.Signings.Select(s => s.PersonId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: draft.Signings.Select(s => s.PersonId).Distinct`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`missing.Add($"{3 - reserves} 名轮换")`；返回值紧邻使用处：`ExpressionStatementSyntax: missing.Add($"{3 - reserves} 名轮换");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`missing.Add($"{required - selected} 名首发")`；返回值紧邻使用处：`ExpressionStatementSyntax: missing.Add($"{required - selected} 名首发");`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string>()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-2a700a81b2ac"></a>

## `NationalSpire.OwnedClubs.Create(NationalSpire.CareerData, NationalSpire.ClubDraft) — public static string? Create(CareerData d, ClubDraft draft)`

来源：源码第 206 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OwnedClubs.Command(NationalSpire.CareerData, string, string, string)`](OwnedClubs.cs.md#symbol-12b38cf6ab67)

**调用：** [`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.OwnedClubs.CreateCore(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-21d1184d2591)；[`NationalSpire.OwnedClubs.CreationError(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-c66d40eab5e9)；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.CommunityMemories`；`NationalSpire.CareerData.Credits`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.ExternalSave`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.Standings`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.OwnedClubs.CreateCore(NationalSpire.CareerData, NationalSpire.ClubDraft)`；`NationalSpire.OwnedClubs.CreationError(NationalSpire.CareerData, NationalSpire.ClubDraft)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(d);`
- `NationalSpire.OwnedClubs.CreateCore(NationalSpire.CareerData, NationalSpire.ClubDraft)`；输入表达式：`CreateCore(copy, draft)`；返回值紧邻使用处：`ExpressionStatementSyntax: CreateCore(copy, draft);`
- `NationalSpire.OwnedClubs.CreationError(NationalSpire.CareerData, NationalSpire.ClubDraft)`；输入表达式：`CreationError(d, draft)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CreationError(d, draft) is { } error`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<CareerData>(JsonSerializer.Serialize(d))`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: JsonSerializer.Deserialize<CareerData>(JsonSerializer.Serialize(d))!`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(d)`；返回值紧邻使用处：`ArgumentSyntax: JsonSerializer.Serialize(d)`

**赋值（含属性/字段和局部值）：**

- `(d.Esports, d.People, d.Matches, d.Standings, d.Life, d.CommunityMemories, d.Credits)` = `original`
- `copy.ExternalSave` = `_ => { }`
- `copy.LocalHumanId` = `d.LocalHumanId`
- `d.CommunityMemories` = `copy.CommunityMemories`
- `d.Credits` = `copy.Credits`
- `d.Esports` = `copy.Esports`
- `d.Life` = `copy.Life`
- `d.Matches` = `copy.Matches`
- `d.People` = `copy.People`
- `d.Standings` = `copy.Standings`

<a id="symbol-21d1184d2591"></a>

## `NationalSpire.OwnedClubs.CreateCore(NationalSpire.CareerData, NationalSpire.ClubDraft) — private static void CreateCore(CareerData d, ClubDraft draft)`

来源：源码第 228 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OwnedClubs.Create(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-2a700a81b2ac)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-00283e0414cc)；[`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`](CareerLife.cs.md#symbol-0ea81cb3e558)；[`NationalSpire.CircuitWorld.LeavePreseason(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-713aae182e5e)；[`NationalSpire.EsportsWorld.ClearInvalidRegistrations(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-b694be794ed8)；[`NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`](EsportsWorld.cs.md#symbol-fcdf6a1b178e)；[`NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-49a6a4a933e2)；[`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-241a535c93f9)；[`NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`](OwnedClubs.cs.md#symbol-3b85db324fce)；[`NationalSpire.OwnedClubs.SignUnchecked(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-4f3afc350ac9)；[`NationalSpire.OwnedClubs.SponsorQuote(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-fb2b56604db1)；[`NationalSpire.OwnedClubs.StartingFans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-e35919f4f29f)；[`NationalSpire.OwnedClubSchedule.Join(NationalSpire.CareerData, string?)`](OwnedClubSchedule.cs.md#symbol-e637b6152d8b)；`NationalSpire.CareerClub.CareerClub()`；`NationalSpire.OwnedClubState.OwnedClubState()`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`string.Trim()`；`System.Collections.Generic.IEnumerable<TSource>.Except<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Clear()`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerClub.Color`；`NationalSpire.CareerClub.Country`；`NationalSpire.CareerClub.Id`；`NationalSpire.CareerClub.Identity`；`NationalSpire.CareerClub.Motto`；`NationalSpire.CareerClub.Name`；`NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.HumanIds`；`NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CircuitWorld.LeavePreseason(NationalSpire.CareerData)`；`NationalSpire.ClubDraft.Color`；`NationalSpire.ClubDraft.Name`；`NationalSpire.ClubDraft.Region`；`NationalSpire.ClubDraft.Signings`；`NationalSpire.ClubDraft.Sponsor`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.Clubs`；`NationalSpire.EsportsCareer.Country`；`NationalSpire.EsportsCareer.License`；`NationalSpire.EsportsCareer.Offers`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.EsportsCareer.PlayerContract`；`NationalSpire.EsportsWorld.ClearInvalidRegistrations(NationalSpire.CareerData)`；`NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.FoundingCost`；`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.HumanWeeklyWage`；`NationalSpire.OwnedClubs.HumanWinBonus`；`NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；`NationalSpire.OwnedClubs.SignUnchecked(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`；`NationalSpire.OwnedClubs.SponsorQuote(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubs.StartingFans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubSchedule.Join(NationalSpire.CareerData, string?)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubState.Contracts`；`NationalSpire.OwnedClubState.EconomyVersion`；`NationalSpire.OwnedClubState.Fans`；`NationalSpire.OwnedClubState.FoundedDay`；`NationalSpire.OwnedClubState.HumanWeeklyWage`；`NationalSpire.OwnedClubState.HumanWinBonus`；`NationalSpire.OwnedClubState.ManagerId`；`NationalSpire.OwnedClubState.NextPayDay`；`NationalSpire.OwnedClubState.Reserves`；`NationalSpire.OwnedClubState.Sponsor`；`NationalSpire.OwnedClubState.Starters`；`NationalSpire.OwnedPlayerContract.PersonId`；`NationalSpire.WorldCompetition.Country`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerClub.CareerClub()`；输入表达式：`new() { Id = id, Name = draft.Name.Trim(), Color = draft.Color, Country = region,              Identity = "自建俱乐部", Motto = "从自己的队伍开始，向下一座冠军出发" }`；返回值紧邻使用处：`ArgumentSyntax: new() { Id = id, Name = draft.Name.Trim(), Color = draft.Color, Country = region,              Identity = "自建俱乐部", Motto = "从自己的队伍开始，向下一座冠军出发" }`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, c.PersonId)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => CareerEngine.DisplayName(d, c.PersonId)`
- `NationalSpire.CareerEngine.Name(NationalSpire.CareerData)`；输入表达式：`CareerEngine.Name(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Name(d) + "组建了"`
- `NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；输入表达式：`CareerLife.AddEvent(d, "club-founded-" + id, "俱乐部", draft.Name.Trim() + "成立", CareerEngine.Name(d) + "组建了" + draft.Name.Trim()              + "，签下" + string.Join("、", own.Contracts.Select(c => CareerEngine.DisplayName(d, c.PersonId))) + "。" + "新阵容将参加本季联赛。", [..Humans(d), ..own.Contracts.Select(c => c.PersonId)], true)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerLife.AddEvent(d, "club-founded-" + id, "俱乐部", draft.Name.Trim() + "成立", CareerEngine.Name(d) + "组建了" + draft.Name.Trim()              + "，签下" + string.Join("、", own.Contracts.Select(c => CareerEngine.DisplayName(d, c.PersonId))) + "。" + "新阵容将参加本季联赛。", [..Humans(d), ..own.Contracts.Select(c => c.PersonId)], true);`
- `NationalSpire.CircuitWorld.LeavePreseason(NationalSpire.CareerData)`；输入表达式：`CircuitWorld.LeavePreseason(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CircuitWorld.LeavePreseason(d);`
- `NationalSpire.EsportsWorld.ClearInvalidRegistrations(NationalSpire.CareerData)`；输入表达式：`EsportsWorld.ClearInvalidRegistrations(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: EsportsWorld.ClearInvalidRegistrations(d);`
- `NationalSpire.EsportsWorld.PlayerLeague(NationalSpire.CareerData)`；输入表达式：`EsportsWorld.PlayerLeague(d)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: EsportsWorld.PlayerLeague(d)?.Country`
- `NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`；输入表达式：`ActiveHumans(d)`；返回值紧邻使用处：`ArgumentSyntax: ActiveHumans(d)`
- `NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`；输入表达式：`ActiveHumans(d)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Starters = ActiveHumans(d)`
- `NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；输入表达式：`Humans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Humans(d).Except`
- `NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；输入表达式：`Humans(d)`；返回值紧邻使用处：`SpreadElementSyntax: ..Humans(d)`
- `NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；输入表达式：`Pay(d, "俱乐部注册与场地筹备", -FoundingCost)`；返回值紧邻使用处：`ExpressionStatementSyntax: Pay(d, "俱乐部注册与场地筹备", -FoundingCost);`
- `NationalSpire.OwnedClubs.SignUnchecked(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`；输入表达式：`SignUnchecked(d, s)`；返回值紧邻使用处：`ExpressionStatementSyntax: SignUnchecked(d, s);`
- `NationalSpire.OwnedClubs.SponsorQuote(NationalSpire.CareerData, string)`；输入表达式：`SponsorQuote(d, draft.Sponsor)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Sponsor = SponsorQuote(d, draft.Sponsor)`
- `NationalSpire.OwnedClubs.StartingFans(NationalSpire.CareerData)`；输入表达式：`StartingFans(d)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Fans = StartingFans(d)`
- `NationalSpire.OwnedClubSchedule.Join(NationalSpire.CareerData, string?)`；输入表达式：`OwnedClubSchedule.Join(d, previousRegion)`；返回值紧邻使用处：`ExpressionStatementSyntax: OwnedClubSchedule.Join(d, previousRegion);`
- `NationalSpire.OwnedClubState.OwnedClubState()`；输入表达式：`new OwnedClubState { HumanWeeklyWage = HumanWeeklyWage, HumanWinBonus = HumanWinBonus, ClubId = id, FoundedDay = d.Day, NextPayDay = d.Day + 7, Fans = StartingFans(d), EconomyVersion = 1,              Starters = ActiveHumans(d), Reserves = Humans(d).Except(ActiveHumans(d)).ToList(), ManagerId = d.LocalHumanId.Length > 0 ? d.LocalHumanId : "player", Sponsor = SponsorQuote(d, draft.Sponsor) }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new OwnedClubState { HumanWeeklyWage = HumanWeeklyWage, HumanWinBonus = HumanWinBonus, ClubId = id, FoundedDay = d.Day, NextPayDay = d.Day + 7, Fans = StartingFans(d), EconomyVersion = 1,              Starters = ActiveHumans(d), Reserves = Humans(d).Except(ActiveHumans(d)).ToList(), ManagerId = d.LocalHumanId.Length > 0 ? d.LocalHumanId : "player", Sponsor = SponsorQuote(d, draft.Sponsor) }`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", own.Contracts.Select(c => CareerEngine.DisplayName(d, c.PersonId)))`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Name(d) + "组建了" + draft.Name.Trim()              + "，签下" + string.Join("、", own.Contracts.Select(c => CareerEngine.DisplayName(d, c.PersonId)))`
- `string.Trim()`；输入表达式：`draft.Name.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Name = draft.Name.Trim()`
- `string.Trim()`；输入表达式：`draft.Name.Trim()`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Name(d) + "组建了" + draft.Name.Trim()`
- `string.Trim()`；输入表达式：`draft.Name.Trim()`；返回值紧邻使用处：`BinaryExpressionSyntax: draft.Name.Trim() + "成立"`
- `System.Collections.Generic.IEnumerable<TSource>.Except<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`Humans(d).Except(ActiveHumans(d))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Humans(d).Except(ActiveHumans(d)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`own.Contracts.Select(c => c.PersonId)`；返回值紧邻使用处：`SpreadElementSyntax: ..own.Contracts.Select(c => c.PersonId)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`own.Contracts.Select(c => CareerEngine.DisplayName(d, c.PersonId))`；返回值紧邻使用处：`ArgumentSyntax: own.Contracts.Select(c => CareerEngine.DisplayName(d, c.PersonId))`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`Humans(d).Except(ActiveHumans(d)).ToList()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Reserves = Humans(d).Except(ActiveHumans(d)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Where(p => d.HumanIds.Contains(p.Id))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var person in d.People.Where(p => d.HumanIds.Contains(p.Id))) person.ClubId = id;`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Esports.Clubs.Add(new() { Id = id, Name = draft.Name.Trim(), Color = draft.Color, Country = region,              Identity = "自建俱乐部", Motto = "从自己的队伍开始，向下一座冠军出发" })`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.Clubs.Add(new() { Id = id, Name = draft.Name.Trim(), Color = draft.Color, Country = region,              Identity = "自建俱乐部", Motto = "从自己的队伍开始，向下一座冠军出发" });`
- `System.Collections.Generic.List<T>.Clear()`；输入表达式：`d.Esports.Offers.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.Offers.Clear();`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`d.HumanIds.Contains(p.Id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => d.HumanIds.Contains(p.Id)`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(3, d.Esports.License)`；返回值紧邻使用处：`AssignmentExpressionSyntax: d.Esports.License = Math.Max(3, d.Esports.License)`

**赋值（含属性/字段和局部值）：**

- `ClubId` = `id`
- `Color` = `draft.Color`
- `Country` = `region`
- `d.Esports.ClubId` = `id`
- `d.Esports.License` = `Math.Max(3, d.Esports.License)`
- `d.Esports.OwnedClub` = `own`
- `d.Esports.PlayerContract` = `null`
- `EconomyVersion` = `1`
- `Fans` = `StartingFans(d)`
- `FoundedDay` = `d.Day`
- `HumanWeeklyWage` = `HumanWeeklyWage`
- `HumanWinBonus` = `HumanWinBonus`
- `Id` = `id`
- `Identity` = `"自建俱乐部"`
- `ManagerId` = `d.LocalHumanId.Length > 0 ? d.LocalHumanId : "player"`
- `Motto` = `"从自己的队伍开始，向下一座冠军出发"`
- `Name` = `draft.Name.Trim()`
- `NextPayDay` = `d.Day + 7`
- `person.ClubId` = `id`
- `Reserves` = `Humans(d).Except(ActiveHumans(d)).ToList()`
- `Sponsor` = `SponsorQuote(d, draft.Sponsor)`
- `Starters` = `ActiveHumans(d)`

<a id="symbol-4f3afc350ac9"></a>

## `NationalSpire.OwnedClubs.SignUnchecked(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?) — private static void SignUnchecked(CareerData d, ClubSigning signing, OwnedPlayerContract? negotiated = null)`

来源：源码第 249 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OwnedClubs.CreateCore(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-21d1184d2591)；[`NationalSpire.OwnedClubs.Recruit(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-bad0a27b1a6b)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`](OwnedClubs.cs.md#symbol-3b85db324fce)；[`NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`](OwnedClubs.cs.md#symbol-11696548c7d5)；[`NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`](OwnedClubs.cs.md#symbol-6507b91ba56b)；[`NationalSpire.OwnedClubs.UpdateRosterRole(NationalSpire.CareerPerson, string)`](OwnedClubs.cs.md#symbol-64e7ad9283a5)；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.ClubSigning.PersonId`；`NationalSpire.ClubSigning.Plan`；`NationalSpire.ClubSigning.Position`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；`NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`；`NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`；`NationalSpire.OwnedClubs.UpdateRosterRole(NationalSpire.CareerPerson, string)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubState.Contracts`；`NationalSpire.OwnedPlayerContract.Days`；`NationalSpire.OwnedPlayerContract.EndDay`；`NationalSpire.OwnedPlayerContract.Position`；`NationalSpire.OwnedPlayerContract.SignedDay`；`NationalSpire.OwnedPlayerContract.Signing`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, signing.PersonId)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(d, signing.PersonId)!`
- `NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；输入表达式：`Pay(d, p.PublicName + "签约费", -contract.Signing)`；返回值紧邻使用处：`ExpressionStatementSyntax: Pay(d, p.PublicName + "签约费", -contract.Signing);`
- `NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`；输入表达式：`PositionList(own, signing.Position)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PositionList(own, signing.Position).Add`
- `NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`；输入表达式：`Quote(p, signing.Plan)`；返回值紧邻使用处：`BinaryExpressionSyntax: negotiated ?? Quote(p, signing.Plan)`
- `NationalSpire.OwnedClubs.UpdateRosterRole(NationalSpire.CareerPerson, string)`；输入表达式：`UpdateRosterRole(p, signing.Position)`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateRosterRole(p, signing.Position);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`own.Contracts.Add(contract)`；返回值紧邻使用处：`ExpressionStatementSyntax: own.Contracts.Add(contract);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`PositionList(own, signing.Position).Add(p.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: PositionList(own, signing.Position).Add(p.Id);`

**赋值（含属性/字段和局部值）：**

- `contract.EndDay` = `d.Day + contract.Days`
- `contract.Position` = `signing.Position`
- `contract.SignedDay` = `d.Day`
- `p.ClubId` = `own.ClubId`

<a id="symbol-11696548c7d5"></a>

## `NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string) — public static List<string> PositionList(OwnedClubState own, string position)`

来源：源码第 259 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Group(string)`](OwnedClubScreen.cs.md#symbol-e620b39a371f)；[`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)；[`NationalSpire.ClubCoaching.Move(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-62e6f802776a)；[`NationalSpire.OwnedClubs.ArriveTransfers(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-2429e4910b3f)；[`NationalSpire.OwnedClubs.Assign(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-e97dde3c003f)；[`NationalSpire.OwnedClubs.RepairContractRoster(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<NationalSpire.PrivateMailbox>?)`](OwnedClubs.cs.md#symbol-3b98b543bc03)；[`NationalSpire.OwnedClubs.SignUnchecked(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-4f3afc350ac9)；[`NationalSpire.OwnedClubs.Swap(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-581cdf4f2390)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.OwnedClubState.Coaches`；`NationalSpire.OwnedClubState.Reserves`；`NationalSpire.OwnedClubState.Starters`；`NationalSpire.OwnedClubState.Youth`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-64e7ad9283a5"></a>

## `NationalSpire.OwnedClubs.UpdateRosterRole(NationalSpire.CareerPerson, string) — internal static void UpdateRosterRole(CareerPerson p, string position)`

来源：源码第 260 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterDeletion.Promote(NationalSpire.CareerData, NationalSpire.CareerPerson, int)`](CharacterDeletion.cs.md#symbol-fdd2ed81eace)；[`NationalSpire.CoachLineups.SeasonStart(NationalSpire.CareerData)`](CoachLineups.cs.md#symbol-e6f5b5e37a12)；[`NationalSpire.OwnedClubs.ArriveTransfers(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-2429e4910b3f)；[`NationalSpire.OwnedClubs.Assign(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-e97dde3c003f)；[`NationalSpire.OwnedClubs.Recruit(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-bad0a27b1a6b)；[`NationalSpire.OwnedClubs.Release(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-ab8d716536a6)；[`NationalSpire.OwnedClubs.SignUnchecked(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-4f3afc350ac9)；[`NationalSpire.OwnedClubs.Swap(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-581cdf4f2390)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.ClubPosition`；`NationalSpire.CareerPerson.EditedCard`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.Role`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `p.ClubPosition` = `position`
- `p.Role` = `position == "青训" ? "青训选手" : p.MaxAscension >= 9 ? "世界顶尖" : "职业选手"`

<a id="symbol-e5d4bf00dda1"></a>

## `NationalSpire.OwnedClubs.Position(NationalSpire.OwnedClubState, string) — public static string Position(OwnedClubState own, string id)`

来源：源码第 267 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubRole(NationalSpire.CareerData, string, string)`](CircuitScreen.cs.md#symbol-d0421d26c8fd)；[`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)；[`NationalSpire.CoachLineups.MemberError(NationalSpire.CareerData, string, string, string, string?, string?)`](CoachLineups.cs.md#symbol-ee32acfaf806)；[`NationalSpire.CoachLineups.Position(NationalSpire.CareerData, NationalSpire.CareerPerson)`](CoachLineups.cs.md#symbol-f16167ebabfe)；[`NationalSpire.OwnedClubs.Swap(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-581cdf4f2390)；[`NationalSpire.PrivatePublicContext.AppendCareerDetails(System.Text.StringBuilder, NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?)`](PrivateCareerContext.cs.md#symbol-12edc643ff32)

**调用：** `System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.OwnedClubState.Coaches`；`NationalSpire.OwnedClubState.Reserves`；`NationalSpire.OwnedClubState.Starters`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`own.Coaches.Contains(id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: own.Coaches.Contains(id) ? "教练" : "青训"`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`own.Reserves.Contains(id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: own.Reserves.Contains(id) ? "轮换" : own.Coaches.Contains(id) ? "教练" : "青训"`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`own.Starters.Contains(id)`；返回值紧邻使用处：`ConditionalExpressionSyntax: own.Starters.Contains(id) ? "首发" : own.Reserves.Contains(id) ? "轮换" : own.Coaches.Contains(id) ? "教练" : "青训"`

**赋值（含属性/字段和局部值）：**


<a id="symbol-af6739305612"></a>

## `NationalSpire.OwnedClubs.RecruitError(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?) — public static string? RecruitError(CareerData d, ClubSigning signing, OwnedPlayerContract? negotiated = null)`

来源：源码第 268 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubProfileActions(NationalSpire.CareerData, NationalSpire.CareerPerson, Godot.VBoxContainer)`](OwnedClubScreen.cs.md#symbol-07281993c5a0)；[`NationalSpire.OwnedClubs.Recruit(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-bad0a27b1a6b)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`](LifeData.cs.md#symbol-de5af63fa4e7)；[`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-8c9ea9f33c3c)；[`NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`](OwnedClubs.cs.md#symbol-6507b91ba56b)；[`NationalSpire.OwnedClubs.ReservedStarter(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-4737fecea097)；[`NationalSpire.OwnedClubs.SigningError(NationalSpire.CareerData, NationalSpire.ClubSigning, bool)`](OwnedClubs.cs.md#symbol-e45e226b122d)；[`NationalSpire.OwnedClubs.StarterReplacementError(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-e4678a15386e)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；`NationalSpire.ClubSigning.PersonId`；`NationalSpire.ClubSigning.Plan`；`NationalSpire.ClubSigning.Position`；`NationalSpire.ClubSigning.ReplaceId`；`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`；`NationalSpire.OwnedClubs.ReservedStarter(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubs.SigningError(NationalSpire.CareerData, NationalSpire.ClubSigning, bool)`；`NationalSpire.OwnedClubs.StarterReplacementError(NationalSpire.CareerData, string)`；`NationalSpire.OwnedPlayerContract.Signing`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, signing.PersonId)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(d, signing.PersonId)!`
- `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；输入表达式：`CareerMoney.Balance(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerMoney.Balance(d) < (negotiated ?? Quote(CareerEngine.Person(d, signing.PersonId)!, signing.Plan)).Signing`
- `NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；输入表达式：`IsOwner(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsOwner(d)`
- `NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`；输入表达式：`Quote(CareerEngine.Person(d, signing.PersonId)!, signing.Plan)`；返回值紧邻使用处：`BinaryExpressionSyntax: negotiated ?? Quote(CareerEngine.Person(d, signing.PersonId)!, signing.Plan)`
- `NationalSpire.OwnedClubs.ReservedStarter(NationalSpire.CareerData, string)`；输入表达式：`ReservedStarter(d, signing.ReplaceId)`；返回值紧邻使用处：`IfStatementSyntax: if (ReservedStarter(d, signing.ReplaceId)) return "这位首发已约定下赛季被转会选手接替。";`
- `NationalSpire.OwnedClubs.SigningError(NationalSpire.CareerData, NationalSpire.ClubSigning, bool)`；输入表达式：`SigningError(d, signing)`；返回值紧邻使用处：`IsPatternExpressionSyntax: SigningError(d, signing) is { } error`
- `NationalSpire.OwnedClubs.StarterReplacementError(NationalSpire.CareerData, string)`；输入表达式：`StarterReplacementError(d, signing.ReplaceId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: StarterReplacementError(d, signing.ReplaceId) is { } replacementError`

**赋值（含属性/字段和局部值）：**


<a id="symbol-bad0a27b1a6b"></a>

## `NationalSpire.OwnedClubs.Recruit(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?) — public static string? Recruit(CareerData d, ClubSigning signing, OwnedPlayerContract? negotiated = null)`

来源：源码第 278 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OwnedClubs.Command(NationalSpire.CareerData, string, string, string)`](OwnedClubs.cs.md#symbol-12b38cf6ab67)；[`NationalSpire.PrivateContracts.Confirm(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, string)`](PrivateAppointments.cs.md#symbol-1c0ddcc69a05)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.OwnedClubs.PlanName(string)`](OwnedClubs.cs.md#symbol-f0042770c2f0)；[`NationalSpire.OwnedClubs.RecruitError(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-af6739305612)；[`NationalSpire.OwnedClubs.Report(NationalSpire.CareerData, string, string, string, System.Collections.Generic.List<string>)`](OwnedClubs.cs.md#symbol-4a616a09019e)；[`NationalSpire.OwnedClubs.SignUnchecked(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-4f3afc350ac9)；[`NationalSpire.OwnedClubs.UpdateRosterRole(NationalSpire.CareerPerson, string)`](OwnedClubs.cs.md#symbol-64e7ad9283a5)；[`NationalSpire.OwnedClubSchedule.UpdateLineup(NationalSpire.CareerData)`](OwnedClubSchedule.cs.md#symbol-ba8eef47d52c)；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Remove(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.ClubSigning.PersonId`；`NationalSpire.ClubSigning.Plan`；`NationalSpire.ClubSigning.Position`；`NationalSpire.ClubSigning.ReplaceId`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.PlanName(string)`；`NationalSpire.OwnedClubs.RecruitError(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`；`NationalSpire.OwnedClubs.Report(NationalSpire.CareerData, string, string, string, System.Collections.Generic.List<string>)`；`NationalSpire.OwnedClubs.SignUnchecked(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`；`NationalSpire.OwnedClubs.UpdateRosterRole(NationalSpire.CareerPerson, string)`；`NationalSpire.OwnedClubSchedule.UpdateLineup(NationalSpire.CareerData)`；`NationalSpire.OwnedClubState.Reserves`；`NationalSpire.OwnedClubState.Starters`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, signing.PersonId)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.DisplayName(d, signing.PersonId) + "加盟"`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, signing.ReplaceId)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(d, signing.ReplaceId)!`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(d);`
- `NationalSpire.OwnedClubs.PlanName(string)`；输入表达式：`PlanName(signing.Plan)`；返回值紧邻使用处：`BinaryExpressionSyntax: "签订" + PlanName(signing.Plan)`
- `NationalSpire.OwnedClubs.RecruitError(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`；输入表达式：`RecruitError(d, signing, negotiated)`；返回值紧邻使用处：`IsPatternExpressionSyntax: RecruitError(d, signing, negotiated) is { } error`
- `NationalSpire.OwnedClubs.Report(NationalSpire.CareerData, string, string, string, System.Collections.Generic.List<string>)`；输入表达式：`Report(d, "签约", CareerEngine.DisplayName(d, signing.PersonId) + "加盟", "签订" + PlanName(signing.Plan) + "合同，进入" + signing.Position + "阵容。", [signing.PersonId])`；返回值紧邻使用处：`ExpressionStatementSyntax: Report(d, "签约", CareerEngine.DisplayName(d, signing.PersonId) + "加盟", "签订" + PlanName(signing.Plan) + "合同，进入" + signing.Position + "阵容。", [signing.PersonId]);`
- `NationalSpire.OwnedClubs.SignUnchecked(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`；输入表达式：`SignUnchecked(d, signing, negotiated)`；返回值紧邻使用处：`ExpressionStatementSyntax: SignUnchecked(d, signing, negotiated);`
- `NationalSpire.OwnedClubs.UpdateRosterRole(NationalSpire.CareerPerson, string)`；输入表达式：`UpdateRosterRole(CareerEngine.Person(d, signing.ReplaceId)!, "轮换")`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateRosterRole(CareerEngine.Person(d, signing.ReplaceId)!, "轮换");`
- `NationalSpire.OwnedClubSchedule.UpdateLineup(NationalSpire.CareerData)`；输入表达式：`OwnedClubSchedule.UpdateLineup(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: OwnedClubSchedule.UpdateLineup(d);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`o.Reserves.Add(signing.ReplaceId)`；返回值紧邻使用处：`ExpressionStatementSyntax: o.Reserves.Add(signing.ReplaceId);`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`o.Starters.Remove(signing.ReplaceId)`；返回值紧邻使用处：`ExpressionStatementSyntax: o.Starters.Remove(signing.ReplaceId);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-581cdf4f2390"></a>

## `NationalSpire.OwnedClubs.Swap(NationalSpire.CareerData, string, string) — public static string? Swap(CareerData d, string first, string second)`

来源：源码第 288 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OwnedClubs.Command(NationalSpire.CareerData, string, string, string)`](OwnedClubs.cs.md#symbol-12b38cf6ab67)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.CharacterDeletion.DeletedStarterVacancy(NationalSpire.CareerData)`](CharacterDeletion.cs.md#symbol-a8f554428afa)；[`NationalSpire.CharacterDeletion.RepairStarters(NationalSpire.CareerData, bool)`](CharacterDeletion.cs.md#symbol-c88a1645b627)；[`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-241a535c93f9)；[`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-8c9ea9f33c3c)；[`NationalSpire.OwnedClubs.Position(NationalSpire.OwnedClubState, string)`](OwnedClubs.cs.md#symbol-e5d4bf00dda1)；[`NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`](OwnedClubs.cs.md#symbol-11696548c7d5)；[`NationalSpire.OwnedClubs.ReservedStarter(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-4737fecea097)；[`NationalSpire.OwnedClubs.UpdateRosterRole(NationalSpire.CareerPerson, string)`](OwnedClubs.cs.md#symbol-64e7ad9283a5)；[`NationalSpire.OwnedClubSchedule.UpdateLineup(NationalSpire.CareerData)`](OwnedClubSchedule.cs.md#symbol-ba8eef47d52c)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.Remove(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.CharacterDeletion.DeletedStarterVacancy(NationalSpire.CareerData)`；`NationalSpire.CharacterDeletion.MissingStarter`；`NationalSpire.CharacterDeletion.RepairStarters(NationalSpire.CareerData, bool)`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.Position(NationalSpire.OwnedClubState, string)`；`NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`；`NationalSpire.OwnedClubs.ReservedStarter(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubs.UpdateRosterRole(NationalSpire.CareerPerson, string)`；`NationalSpire.OwnedClubSchedule.UpdateLineup(NationalSpire.CareerData)`；`NationalSpire.OwnedClubState.Contracts`；`NationalSpire.OwnedPlayerContract.GuaranteedStarter`；`NationalSpire.OwnedPlayerContract.PersonId`；`NationalSpire.OwnedPlayerContract.Position`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(d, id)!`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(d);`
- `NationalSpire.CharacterDeletion.DeletedStarterVacancy(NationalSpire.CareerData)`；输入表达式：`CharacterDeletion.DeletedStarterVacancy(d)`；返回值紧邻使用处：`IfStatementSyntax: if (CharacterDeletion.DeletedStarterVacancy(d)) return CharacterDeletion.MissingStarter;`
- `NationalSpire.CharacterDeletion.RepairStarters(NationalSpire.CareerData, bool)`；输入表达式：`CharacterDeletion.RepairStarters(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CharacterDeletion.RepairStarters(d);`
- `NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；输入表达式：`Humans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Humans(d).Contains`
- `NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；输入表达式：`IsOwner(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsOwner(d)`
- `NationalSpire.OwnedClubs.Position(NationalSpire.OwnedClubState, string)`；输入表达式：`Position(o, first)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Position(o, first)`
- `NationalSpire.OwnedClubs.Position(NationalSpire.OwnedClubState, string)`；输入表达式：`Position(o, id)`；返回值紧邻使用处：`ArgumentSyntax: Position(o, id)`
- `NationalSpire.OwnedClubs.Position(NationalSpire.OwnedClubState, string)`；输入表达式：`Position(o, second)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Position(o, second)`
- `NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`；输入表达式：`PositionList(o, a)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PositionList(o, a).Add`
- `NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`；输入表达式：`PositionList(o, a)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PositionList(o, a).Remove`
- `NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`；输入表达式：`PositionList(o, b)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PositionList(o, b).Add`
- `NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`；输入表达式：`PositionList(o, b)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PositionList(o, b).Remove`
- `NationalSpire.OwnedClubs.ReservedStarter(NationalSpire.CareerData, string)`；输入表达式：`ReservedStarter(d, first)`；返回值紧邻使用处：`BinaryExpressionSyntax: ReservedStarter(d, first) || ReservedStarter(d, second)`
- `NationalSpire.OwnedClubs.ReservedStarter(NationalSpire.CareerData, string)`；输入表达式：`ReservedStarter(d, second)`；返回值紧邻使用处：`BinaryExpressionSyntax: ReservedStarter(d, first) || ReservedStarter(d, second)`
- `NationalSpire.OwnedClubs.UpdateRosterRole(NationalSpire.CareerPerson, string)`；输入表达式：`UpdateRosterRole(CareerEngine.Person(d, id)!, Position(o, id))`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateRosterRole(CareerEngine.Person(d, id)!, Position(o, id));`
- `NationalSpire.OwnedClubSchedule.UpdateLineup(NationalSpire.CareerData)`；输入表达式：`OwnedClubSchedule.UpdateLineup(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: OwnedClubSchedule.UpdateLineup(d);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`o.Contracts.Any(c => c.PersonId == first && c.GuaranteedStarter)`；返回值紧邻使用处：`BinaryExpressionSyntax: b != "首发" && o.Contracts.Any(c => c.PersonId == first && c.GuaranteedStarter)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`o.Contracts.Any(c => c.PersonId == first)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !o.Contracts.Any(c => c.PersonId == first)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`o.Contracts.Any(c => c.PersonId == second && c.GuaranteedStarter)`；返回值紧邻使用处：`BinaryExpressionSyntax: a != "首发" && o.Contracts.Any(c => c.PersonId == second && c.GuaranteedStarter)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`o.Contracts.Any(c => c.PersonId == second)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !o.Contracts.Any(c => c.PersonId == second)`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`o.Contracts.Single(c => c.PersonId == first)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: o.Contracts.Single(c => c.PersonId == first).Position`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`o.Contracts.Single(c => c.PersonId == second)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: o.Contracts.Single(c => c.PersonId == second).Position`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`PositionList(o, a).Add(second)`；返回值紧邻使用处：`ExpressionStatementSyntax: PositionList(o, a).Add(second);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`PositionList(o, b).Add(first)`；返回值紧邻使用处：`ExpressionStatementSyntax: PositionList(o, b).Add(first);`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`Humans(d).Contains(first)`；返回值紧邻使用处：`BinaryExpressionSyntax: Humans(d).Contains(first) || Humans(d).Contains(second)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`Humans(d).Contains(second)`；返回值紧邻使用处：`BinaryExpressionSyntax: Humans(d).Contains(first) || Humans(d).Contains(second)`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`PositionList(o, a).Remove(first)`；返回值紧邻使用处：`ExpressionStatementSyntax: PositionList(o, a).Remove(first);`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`PositionList(o, b).Remove(second)`；返回值紧邻使用处：`ExpressionStatementSyntax: PositionList(o, b).Remove(second);`

**赋值（含属性/字段和局部值）：**

- `o.Contracts.Single(c => c.PersonId == first).Position` = `b`
- `o.Contracts.Single(c => c.PersonId == second).Position` = `a`

<a id="symbol-ab8d716536a6"></a>

## `NationalSpire.OwnedClubs.Release(NationalSpire.CareerData, string, string) — public static string? Release(CareerData d, string id, string replacement = "")`

来源：源码第 306 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OwnedClubs.Command(NationalSpire.CareerData, string, string, string)`](OwnedClubs.cs.md#symbol-12b38cf6ab67)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`](LifeData.cs.md#symbol-de5af63fa4e7)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.CareerTraining.InvalidateForecast(NationalSpire.CareerData)`](CareerTraining.cs.md#symbol-5df788f3061f)；[`NationalSpire.ClubCoaching.StopTraining(NationalSpire.CareerData, string)`](ClubCoaching.cs.md#symbol-eacca79a5d86)；[`NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-49a6a4a933e2)；[`NationalSpire.OwnedClubs.ExitFee(NationalSpire.CareerData, NationalSpire.OwnedPlayerContract)`](OwnedClubs.cs.md#symbol-157b8775d91c)；[`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-8c9ea9f33c3c)；[`NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`](OwnedClubs.cs.md#symbol-3b85db324fce)；[`NationalSpire.OwnedClubs.Report(NationalSpire.CareerData, string, string, string, System.Collections.Generic.List<string>)`](OwnedClubs.cs.md#symbol-4a616a09019e)；[`NationalSpire.OwnedClubs.ReservedStarter(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-4737fecea097)；[`NationalSpire.OwnedClubs.UpdateRosterRole(NationalSpire.CareerPerson, string)`](OwnedClubs.cs.md#symbol-64e7ad9283a5)；[`NationalSpire.OwnedClubSchedule.UpdateLineup(NationalSpire.CareerData)`](OwnedClubSchedule.cs.md#symbol-ba8eef47d52c)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.Remove(T)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.ClubPosition`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.CareerTraining.InvalidateForecast(NationalSpire.CareerData)`；`NationalSpire.ClubCoaching.StopTraining(NationalSpire.CareerData, string)`；`NationalSpire.CoachAppointment.PersonId`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.ExitFee(NationalSpire.CareerData, NationalSpire.OwnedPlayerContract)`；`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；`NationalSpire.OwnedClubs.Report(NationalSpire.CareerData, string, string, string, System.Collections.Generic.List<string>)`；`NationalSpire.OwnedClubs.ReservedStarter(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubs.UpdateRosterRole(NationalSpire.CareerPerson, string)`；`NationalSpire.OwnedClubSchedule.UpdateLineup(NationalSpire.CareerData)`；`NationalSpire.OwnedClubState.CoachAppointments`；`NationalSpire.OwnedClubState.Coaches`；`NationalSpire.OwnedClubState.Contracts`；`NationalSpire.OwnedClubState.Reserves`；`NationalSpire.OwnedClubState.Starters`；`NationalSpire.OwnedClubState.Youth`；`NationalSpire.OwnedPlayerContract.PersonId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.DisplayName(d, id) + "解约补偿"`
- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.DisplayName(d, id) + "离队"`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(d, id)!`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, replacement)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(d, replacement)!`
- `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；输入表达式：`CareerMoney.Balance(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerMoney.Balance(d) < fee`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(d);`
- `NationalSpire.CareerTraining.InvalidateForecast(NationalSpire.CareerData)`；输入表达式：`CareerTraining.InvalidateForecast(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerTraining.InvalidateForecast(d);`
- `NationalSpire.ClubCoaching.StopTraining(NationalSpire.CareerData, string)`；输入表达式：`ClubCoaching.StopTraining(d, id)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubCoaching.StopTraining(d, id);`
- `NationalSpire.OwnedClubs.ActiveHumans(NationalSpire.CareerData)`；输入表达式：`ActiveHumans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ActiveHumans(d).Count`
- `NationalSpire.OwnedClubs.ExitFee(NationalSpire.CareerData, NationalSpire.OwnedPlayerContract)`；输入表达式：`ExitFee(d, c)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ExitFee(d, c)`
- `NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；输入表达式：`IsOwner(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsOwner(d)`
- `NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；输入表达式：`Pay(d, CareerEngine.DisplayName(d, id) + "解约补偿", -fee)`；返回值紧邻使用处：`ExpressionStatementSyntax: Pay(d, CareerEngine.DisplayName(d, id) + "解约补偿", -fee);`
- `NationalSpire.OwnedClubs.Report(NationalSpire.CareerData, string, string, string, System.Collections.Generic.List<string>)`；输入表达式：`Report(d, "转会", CareerEngine.DisplayName(d, id) + "离队", "双方结束球员合同，选手重新进入自由市场。", [id])`；返回值紧邻使用处：`ExpressionStatementSyntax: Report(d, "转会", CareerEngine.DisplayName(d, id) + "离队", "双方结束球员合同，选手重新进入自由市场。", [id]);`
- `NationalSpire.OwnedClubs.ReservedStarter(NationalSpire.CareerData, string)`；输入表达式：`ReservedStarter(d, id)`；返回值紧邻使用处：`IfStatementSyntax: if (ReservedStarter(d, id)) return "该首发已约定下赛季被转会选手接替，届时可解约。";`
- `NationalSpire.OwnedClubs.UpdateRosterRole(NationalSpire.CareerPerson, string)`；输入表达式：`UpdateRosterRole(CareerEngine.Person(d, replacement)!, "首发")`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateRosterRole(CareerEngine.Person(d, replacement)!, "首发");`
- `NationalSpire.OwnedClubSchedule.UpdateLineup(NationalSpire.CareerData)`；输入表达式：`OwnedClubSchedule.UpdateLineup(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: OwnedClubSchedule.UpdateLineup(d);`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`o.Contracts.FirstOrDefault(c => c.PersonId == id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = o.Contracts.FirstOrDefault(c => c.PersonId == id)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`o.Starters.Add(replacement)`；返回值紧邻使用处：`ExpressionStatementSyntax: o.Starters.Add(replacement);`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`o.Reserves.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: !starter && o.Reserves.Contains(id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`o.Reserves.Contains(replacement)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !o.Reserves.Contains(replacement)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`o.Starters.Contains(id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = o.Starters.Contains(id)`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`o.Coaches.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: o.Coaches.Remove(id);`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`o.Contracts.Remove(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: o.Contracts.Remove(c);`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`o.Reserves.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: o.Reserves.Remove(id);`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`o.Reserves.Remove(replacement)`；返回值紧邻使用处：`ExpressionStatementSyntax: o.Reserves.Remove(replacement);`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`o.Starters.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: o.Starters.Remove(id);`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`o.Youth.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: o.Youth.Remove(id);`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`o.CoachAppointments.RemoveAll(a => a.PersonId == id)`；返回值紧邻使用处：`ExpressionStatementSyntax: o.CoachAppointments.RemoveAll(a => a.PersonId == id);`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(3, ActiveHumans(d).Count)`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Starters.Count <= Math.Max(3, ActiveHumans(d).Count)`

**赋值（含属性/字段和局部值）：**

- `CareerEngine.Person(d, id)!.ClubId` = `""`
- `CareerEngine.Person(d, id)!.ClubPosition` = `""`

<a id="symbol-e97dde3c003f"></a>

## `NationalSpire.OwnedClubs.Assign(NationalSpire.CareerData, string, string) — public static string? Assign(CareerData d, string id, string position)`

来源：源码第 326 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OwnedClubs.Command(NationalSpire.CareerData, string, string, string)`](OwnedClubs.cs.md#symbol-12b38cf6ab67)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.CareerTraining.InvalidateForecast(NationalSpire.CareerData)`](CareerTraining.cs.md#symbol-5df788f3061f)；[`NationalSpire.ClubCoaching.StopTraining(NationalSpire.CareerData, string)`](ClubCoaching.cs.md#symbol-eacca79a5d86)；[`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-8c9ea9f33c3c)；[`NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`](OwnedClubs.cs.md#symbol-11696548c7d5)；[`NationalSpire.OwnedClubs.UpdateRosterRole(NationalSpire.CareerPerson, string)`](OwnedClubs.cs.md#symbol-64e7ad9283a5)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.Remove(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.CareerTraining.InvalidateForecast(NationalSpire.CareerData)`；`NationalSpire.ClubCoaching.StopTraining(NationalSpire.CareerData, string)`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`；`NationalSpire.OwnedClubs.UpdateRosterRole(NationalSpire.CareerPerson, string)`；`NationalSpire.OwnedClubState.Coaches`；`NationalSpire.OwnedClubState.Contracts`；`NationalSpire.OwnedClubState.Reserves`；`NationalSpire.OwnedClubState.Starters`；`NationalSpire.OwnedClubState.Youth`；`NationalSpire.OwnedPlayerContract.PersonId`；`NationalSpire.OwnedPlayerContract.Position`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(d, id)!`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(d);`
- `NationalSpire.CareerTraining.InvalidateForecast(NationalSpire.CareerData)`；输入表达式：`CareerTraining.InvalidateForecast(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerTraining.InvalidateForecast(d);`
- `NationalSpire.ClubCoaching.StopTraining(NationalSpire.CareerData, string)`；输入表达式：`ClubCoaching.StopTraining(d, id)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubCoaching.StopTraining(d, id);`
- `NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；输入表达式：`IsOwner(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsOwner(d)`
- `NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`；输入表达式：`PositionList(o, position)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PositionList(o, position).Add`
- `NationalSpire.OwnedClubs.UpdateRosterRole(NationalSpire.CareerPerson, string)`；输入表达式：`UpdateRosterRole(CareerEngine.Person(d, id)!, position)`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateRosterRole(CareerEngine.Person(d, id)!, position);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`o.Contracts.Any(c => c.PersonId == id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !o.Contracts.Any(c => c.PersonId == id)`
- `System.Collections.Generic.IEnumerable<TSource>.Single<TSource>(System.Func<TSource, bool>)`；输入表达式：`o.Contracts.Single(c => c.PersonId == id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: o.Contracts.Single(c => c.PersonId == id).Position`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`PositionList(o, position).Add(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: PositionList(o, position).Add(id);`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`o.Coaches.Contains(id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = o.Coaches.Contains(id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`o.Reserves.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: position == "青训" && o.Reserves.Contains(id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`o.Starters.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: !o.Contracts.Any(c => c.PersonId == id) || position is not ("轮换" or "青训") || o.Starters.Contains(id)`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`o.Coaches.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: o.Coaches.Remove(id);`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`o.Reserves.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: o.Reserves.Remove(id);`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`o.Youth.Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: o.Youth.Remove(id);`

**赋值（含属性/字段和局部值）：**

- `o.Contracts.Single(c => c.PersonId == id).Position` = `position`

<a id="symbol-157b8775d91c"></a>

## `NationalSpire.OwnedClubs.ExitFee(NationalSpire.CareerData, NationalSpire.OwnedPlayerContract) — public static decimal ExitFee(CareerData d, OwnedPlayerContract c)`

来源：源码第 339 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubProfileActions(NationalSpire.CareerData, NationalSpire.CareerPerson, Godot.VBoxContainer)`](OwnedClubScreen.cs.md#symbol-07281993c5a0)；[`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)；[`NationalSpire.OwnedClubs.Release(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-ab8d716536a6)

**调用：** `System.Math.Max(int, int)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.OwnedPlayerContract.EndDay`；`NationalSpire.OwnedPlayerContract.Wage`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Math.Max(int, int)`；输入表达式：`Math.Max(0, (c.EndDay - d.Day + 6) / 7)`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, (c.EndDay - d.Day + 6) / 7)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(4, Math.Max(0, (c.EndDay - d.Day + 6) / 7))`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Min(4, Math.Max(0, (c.EndDay - d.Day + 6) / 7)) * c.Wage`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fda6cea8331b"></a>

## `NationalSpire.OwnedClubs.TransferReserved(NationalSpire.CareerData, string) — public static bool TransferReserved(CareerData d, string id)`

来源：源码第 340 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitPeople.SeasonChange(NationalSpire.CareerData)`](CircuitPeople.cs.md#symbol-d77bf6cf914a)；[`NationalSpire.ClubCoaching.Replacements(NationalSpire.CareerData, string)`](ClubCoaching.cs.md#symbol-a26fdb727aca)；[`NationalSpire.ClubOperations.TryTransfer(NationalSpire.CareerData, NationalSpire.CareerClub)`](ClubOperations.cs.md#symbol-91ececd875b5)；[`NationalSpire.OwnedClubs.TransferError(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-dd969fd199a4)；[`NationalSpire.PrivateContracts.Guidance(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivateAppointments.cs.md#symbol-3c22aa703fb0)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubState.Transfers`；`NationalSpire.OwnedPlayerContract.PersonId`；`NationalSpire.OwnedTransfer.Arrived`；`NationalSpire.OwnedTransfer.Contract`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Transfers.Any(t => !t.Arrived && t.Contract.PersonId == id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: d.Esports.OwnedClub?.Transfers.Any(t => !t.Arrived && t.Contract.PersonId == id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4737fecea097"></a>

## `NationalSpire.OwnedClubs.ReservedStarter(NationalSpire.CareerData, string) — public static bool ReservedStarter(CareerData d, string id)`

来源：源码第 341 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ClubCoaching.Appoint(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-15fbcfa0d281)；[`NationalSpire.ClubCoaching.Replacements(NationalSpire.CareerData, string)`](ClubCoaching.cs.md#symbol-a26fdb727aca)；[`NationalSpire.ClubCoaching.SeasonStart(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-c152f62d57e4)；[`NationalSpire.CoachLineups.MemberError(NationalSpire.CareerData, string, string, string, string?, string?)`](CoachLineups.cs.md#symbol-ee32acfaf806)；[`NationalSpire.OwnedClubs.RecruitError(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-af6739305612)；[`NationalSpire.OwnedClubs.Release(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-ab8d716536a6)；[`NationalSpire.OwnedClubs.ReplaceableStarters(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-e1cbaaf9f832)；[`NationalSpire.OwnedClubs.StarterReplacementError(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-e4678a15386e)；[`NationalSpire.OwnedClubs.Swap(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-581cdf4f2390)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubState.Transfers`；`NationalSpire.OwnedTransfer.Arrived`；`NationalSpire.OwnedTransfer.ReplaceId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Transfers.Any(t => !t.Arrived && t.ReplaceId == id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: d.Esports.OwnedClub?.Transfers.Any(t => !t.Arrived && t.ReplaceId == id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e1cbaaf9f832"></a>

## `NationalSpire.OwnedClubs.ReplaceableStarters(NationalSpire.CareerData) — public static List<string> ReplaceableStarters(CareerData d)`

来源：源码第 342 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.ClubMarket(NationalSpire.CareerData, bool)`](OwnedClubScreen.cs.md#symbol-b1e2f4fe72a4)；[`NationalSpire.CareerScreen.ClubProfileActions(NationalSpire.CareerData, NationalSpire.CareerPerson, Godot.VBoxContainer)`](OwnedClubScreen.cs.md#symbol-07281993c5a0)；[`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`](GroupChatScreen.cs.md#symbol-3afa41099b93)；[`NationalSpire.CareerScreen.PlayerPositionDialog(NationalSpire.CareerData)`](CoachScreen.cs.md#symbol-5e31a957c01c)；[`NationalSpire.ClubCoaching.SeasonStart(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-c152f62d57e4)；[`NationalSpire.OwnedClubs.StarterReplacementError(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-e4678a15386e)

**调用：** [`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-241a535c93f9)；[`NationalSpire.OwnedClubs.ReservedStarter(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-4737fecea097)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.ReservedStarter(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubState.Contracts`；`NationalSpire.OwnedClubState.Starters`；`NationalSpire.OwnedPlayerContract.GuaranteedStarter`；`NationalSpire.OwnedPlayerContract.PersonId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；输入表达式：`Humans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Humans(d).Contains`
- `NationalSpire.OwnedClubs.ReservedStarter(NationalSpire.CareerData, string)`；输入表达式：`ReservedStarter(d, id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ReservedStarter(d, id)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.OwnedClub.Contracts.Any(c => c.PersonId == id && c.GuaranteedStarter)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.Esports.OwnedClub.Contracts.Any(c => c.PersonId == id && c.GuaranteedStarter)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`d.Esports.OwnedClub!.Starters.Where(id => !Humans(d).Contains(id)          && !d.Esports.OwnedClub.Contracts.Any(c => c.PersonId == id && c.GuaranteedStarter) && !ReservedStarter(d, id)).ToList()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => d.Esports.OwnedClub!.Starters.Where(id => !Humans(d).Contains(id)          && !d.Esports.OwnedClub.Contracts.Any(c => c.PersonId == id && c.GuaranteedStarter) && !ReservedStarter(d, id)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.OwnedClub!.Starters.Where(id => !Humans(d).Contains(id)          && !d.Esports.OwnedClub.Contracts.Any(c => c.PersonId == id && c.GuaranteedStarter) && !ReservedStarter(d, id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d.Esports.OwnedClub!.Starters.Where(id => !Humans(d).Contains(id)          && !d.Esports.OwnedClub.Contracts.Any(c => c.PersonId == id && c.GuaranteedStarter) && !ReservedStarter(d, id)).ToList`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`Humans(d).Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Humans(d).Contains(id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e4678a15386e"></a>

## `NationalSpire.OwnedClubs.StarterReplacementError(NationalSpire.CareerData, string) — public static string? StarterReplacementError(CareerData d, string replacement)`

来源：源码第 344 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.ClubMarket(NationalSpire.CareerData, bool)`](OwnedClubScreen.cs.md#symbol-b1e2f4fe72a4)；[`NationalSpire.ClubCoaching.PlayerPositionError(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-7f8dbf0cc1e3)；[`NationalSpire.OwnedClubs.RecruitError(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-af6739305612)；[`NationalSpire.OwnedClubs.TransferError(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-dd969fd199a4)

**调用：** [`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-241a535c93f9)；[`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-8c9ea9f33c3c)；[`NationalSpire.OwnedClubs.ReplaceableStarters(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-e1cbaaf9f832)；[`NationalSpire.OwnedClubs.ReservedStarter(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-4737fecea097)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.List()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.ReplaceableStarters(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.ReservedStarter(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubState.Contracts`；`NationalSpire.OwnedClubState.Starters`；`NationalSpire.OwnedPlayerContract.GuaranteedStarter`；`NationalSpire.OwnedPlayerContract.PersonId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；输入表达式：`Humans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Humans(d).Contains`
- `NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；输入表达式：`IsOwner(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsOwner(d)`
- `NationalSpire.OwnedClubs.ReplaceableStarters(NationalSpire.CareerData)`；输入表达式：`ReplaceableStarters(d)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ReplaceableStarters(d)`
- `NationalSpire.OwnedClubs.ReservedStarter(NationalSpire.CareerData, string)`；输入表达式：`ReservedStarter(d, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => ReservedStarter(d, id)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("；", reasons)`；返回值紧邻使用处：`BinaryExpressionSyntax: "：" + string.Join("；", reasons)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`own.Contracts.Any(c => c.PersonId == id && c.GuaranteedStarter)`；返回值紧邻使用处：`BinaryExpressionSyntax: !Humans(d).Contains(id) && own.Contracts.Any(c => c.PersonId == id && c.GuaranteedStarter)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`own.Starters.Any(id => !Humans(d).Contains(id) && own.Contracts.Any(c => c.PersonId == id && c.GuaranteedStarter))`；返回值紧邻使用处：`IfStatementSyntax: if (own.Starters.Any(id => !Humans(d).Contains(id) && own.Contracts.Any(c => c.PersonId == id && c.GuaranteedStarter))) reasons.Add("现役选手有首发保障合同");`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`own.Starters.Any(id => Humans(d).Contains(id))`；返回值紧邻使用处：`IfStatementSyntax: if (own.Starters.Any(id => Humans(d).Contains(id))) reasons.Add("真人固定首发");`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`own.Starters.Any(id => ReservedStarter(d, id))`；返回值紧邻使用处：`IfStatementSyntax: if (own.Starters.Any(id => ReservedStarter(d, id))) reasons.Add("席位已预约给下赛季加盟选手");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`reasons.Add("席位已预约给下赛季加盟选手")`；返回值紧邻使用处：`ExpressionStatementSyntax: reasons.Add("席位已预约给下赛季加盟选手");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`reasons.Add("现役选手有首发保障合同")`；返回值紧邻使用处：`ExpressionStatementSyntax: reasons.Add("现役选手有首发保障合同");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`reasons.Add("真人固定首发")`；返回值紧邻使用处：`ExpressionStatementSyntax: reasons.Add("真人固定首发");`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`available.Contains(replacement)`；返回值紧邻使用处：`IfStatementSyntax: if (available.Contains(replacement)) return null;`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`Humans(d).Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Humans(d).Contains(id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`Humans(d).Contains(id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => Humans(d).Contains(id)`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string>()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-35a81fabab41"></a>

## `NationalSpire.OwnedClubs.TransferFee(NationalSpire.CareerPerson) — public static int TransferFee(CareerPerson p)`

来源：源码第 357 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.ClubProfileActions(NationalSpire.CareerData, NationalSpire.CareerPerson, Godot.VBoxContainer)`](OwnedClubScreen.cs.md#symbol-07281993c5a0)；[`NationalSpire.OwnedClubs.ArrangeTransfer(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-66be5c09e822)；[`NationalSpire.OwnedClubs.TransferError(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-dd969fd199a4)；[`NationalSpire.PrivateContracts.Guidance(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivateAppointments.cs.md#symbol-3c22aa703fb0)

**调用：** [`NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`](OwnedClubs.cs.md#symbol-6507b91ba56b)

**字段、属性、事件及方法组引用：** `NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`；`NationalSpire.OwnedPlayerContract.Signing`；`NationalSpire.OwnedPlayerContract.Wage`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`；输入表达式：`Quote(p, "steady")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Quote(p, "steady").Signing`
- `NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`；输入表达式：`Quote(p, "steady")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Quote(p, "steady").Wage`

**赋值（含属性/字段和局部值）：**


<a id="symbol-dd969fd199a4"></a>

## `NationalSpire.OwnedClubs.TransferError(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?) — public static string? TransferError(CareerData d, ClubSigning signing, OwnedPlayerContract? negotiated = null)`

来源：源码第 358 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubProfileActions(NationalSpire.CareerData, NationalSpire.CareerPerson, Godot.VBoxContainer)`](OwnedClubScreen.cs.md#symbol-07281993c5a0)；[`NationalSpire.OwnedClubs.ArrangeTransfer(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-66be5c09e822)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`](LifeData.cs.md#symbol-de5af63fa4e7)；[`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-241a535c93f9)；[`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-8c9ea9f33c3c)；[`NationalSpire.OwnedClubs.IsRecruitable(NationalSpire.CareerPerson)`](OwnedClubs.cs.md#symbol-11345d1ef285)；[`NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`](OwnedClubs.cs.md#symbol-6507b91ba56b)；[`NationalSpire.OwnedClubs.SigningError(NationalSpire.CareerData, NationalSpire.ClubSigning, bool)`](OwnedClubs.cs.md#symbol-e45e226b122d)；[`NationalSpire.OwnedClubs.StarterReplacementError(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-e4678a15386e)；[`NationalSpire.OwnedClubs.TransferFee(NationalSpire.CareerPerson)`](OwnedClubs.cs.md#symbol-35a81fabab41)；[`NationalSpire.OwnedClubs.TransferReserved(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-fda6cea8331b)；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Id`；`NationalSpire.ClubSigning.PersonId`；`NationalSpire.ClubSigning.Plan`；`NationalSpire.ClubSigning.Position`；`NationalSpire.ClubSigning.ReplaceId`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.IsRecruitable(NationalSpire.CareerPerson)`；`NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`；`NationalSpire.OwnedClubs.SigningError(NationalSpire.CareerData, NationalSpire.ClubSigning, bool)`；`NationalSpire.OwnedClubs.StarterReplacementError(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubs.TransferFee(NationalSpire.CareerPerson)`；`NationalSpire.OwnedClubs.TransferReserved(NationalSpire.CareerData, string)`；`NationalSpire.OwnedPlayerContract.Signing`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, signing.PersonId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CareerEngine.Person(d, signing.PersonId)`
- `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；输入表达式：`CareerMoney.Balance(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerMoney.Balance(d) < TransferFee(p) + (negotiated ?? Quote(p, signing.Plan)).Signing`
- `NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；输入表达式：`Humans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Humans(d).Contains`
- `NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；输入表达式：`IsOwner(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsOwner(d)`
- `NationalSpire.OwnedClubs.IsRecruitable(NationalSpire.CareerPerson)`；输入表达式：`IsRecruitable(p)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsRecruitable(p)`
- `NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`；输入表达式：`Quote(p, signing.Plan)`；返回值紧邻使用处：`BinaryExpressionSyntax: negotiated ?? Quote(p, signing.Plan)`
- `NationalSpire.OwnedClubs.SigningError(NationalSpire.CareerData, NationalSpire.ClubSigning, bool)`；输入表达式：`SigningError(d, signing, true)`；返回值紧邻使用处：`IsPatternExpressionSyntax: SigningError(d, signing, true) is { } error`
- `NationalSpire.OwnedClubs.StarterReplacementError(NationalSpire.CareerData, string)`；输入表达式：`StarterReplacementError(d, signing.ReplaceId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: StarterReplacementError(d, signing.ReplaceId) is { } replacementError`
- `NationalSpire.OwnedClubs.TransferFee(NationalSpire.CareerPerson)`；输入表达式：`TransferFee(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: TransferFee(p) + (negotiated ?? Quote(p, signing.Plan)).Signing`
- `NationalSpire.OwnedClubs.TransferReserved(NationalSpire.CareerData, string)`；输入表达式：`TransferReserved(d, p.Id)`；返回值紧邻使用处：`IfStatementSyntax: if (TransferReserved(d, p.Id)) return "已经签订下赛季加盟合同。";`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`Humans(d).Contains(p.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: p == null || Humans(d).Contains(p.Id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-66be5c09e822"></a>

## `NationalSpire.OwnedClubs.ArrangeTransfer(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?) — public static string? ArrangeTransfer(CareerData d, ClubSigning signing, OwnedPlayerContract? negotiated = null)`

来源：源码第 371 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OwnedClubs.Command(NationalSpire.CareerData, string, string, string)`](OwnedClubs.cs.md#symbol-12b38cf6ab67)；[`NationalSpire.PrivateContracts.Confirm(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, string)`](PrivateAppointments.cs.md#symbol-1c0ddcc69a05)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-3ba0e806ba5c)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；[`NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`](OwnedClubs.cs.md#symbol-3b85db324fce)；[`NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`](OwnedClubs.cs.md#symbol-6507b91ba56b)；[`NationalSpire.OwnedClubs.Report(NationalSpire.CareerData, string, string, string, System.Collections.Generic.List<string>)`](OwnedClubs.cs.md#symbol-4a616a09019e)；[`NationalSpire.OwnedClubs.TransferError(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-dd969fd199a4)；[`NationalSpire.OwnedClubs.TransferFee(NationalSpire.CareerPerson)`](OwnedClubs.cs.md#symbol-35a81fabab41)；`NationalSpire.OwnedTransfer.OwnedTransfer()`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerClub.Budget`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.ClubSigning.PersonId`；`NationalSpire.ClubSigning.Plan`；`NationalSpire.ClubSigning.Position`；`NationalSpire.ClubSigning.ReplaceId`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；`NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`；`NationalSpire.OwnedClubs.Report(NationalSpire.CareerData, string, string, string, System.Collections.Generic.List<string>)`；`NationalSpire.OwnedClubs.TransferError(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`；`NationalSpire.OwnedClubs.TransferFee(NationalSpire.CareerPerson)`；`NationalSpire.OwnedClubState.Transfers`；`NationalSpire.OwnedPlayerContract.Position`；`NationalSpire.OwnedPlayerContract.Signing`；`NationalSpire.OwnedTransfer.ArrivalSeason`；`NationalSpire.OwnedTransfer.Contract`；`NationalSpire.OwnedTransfer.Fee`；`NationalSpire.OwnedTransfer.Position`；`NationalSpire.OwnedTransfer.ReplaceId`；`NationalSpire.OwnedTransfer.SellerId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, signing.PersonId)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(d, signing.PersonId)!`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(fee)`；返回值紧邻使用处：`InterpolationSyntax: {CareerMoney.Format(fee)}`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(d);`
- `NationalSpire.EsportsWorld.Club(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.Club(d, p.ClubId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: EsportsWorld.Club(d, p.ClubId) is { } seller`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(d, p.ClubId)`；返回值紧邻使用处：`InterpolationSyntax: {EsportsWorld.ClubName(d, p.ClubId)}`
- `NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；输入表达式：`Pay(d, p.PublicName + "转会与签约", -fee - contract.Signing)`；返回值紧邻使用处：`ExpressionStatementSyntax: Pay(d, p.PublicName + "转会与签约", -fee - contract.Signing);`
- `NationalSpire.OwnedClubs.Quote(NationalSpire.CareerPerson, string)`；输入表达式：`Quote(p, signing.Plan)`；返回值紧邻使用处：`BinaryExpressionSyntax: negotiated ?? Quote(p, signing.Plan)`
- `NationalSpire.OwnedClubs.Report(NationalSpire.CareerData, string, string, string, System.Collections.Generic.List<string>)`；输入表达式：`Report(d, "转会", p.PublicName + "将在下赛季加盟", $"与{EsportsWorld.ClubName(d, p.ClubId)}达成协议，转会费{CareerMoney.Format(fee)}，进入{signing.Position}阵容。本赛季继续代表原俱乐部出战。", [p.Id])`；返回值紧邻使用处：`ExpressionStatementSyntax: Report(d, "转会", p.PublicName + "将在下赛季加盟", $"与{EsportsWorld.ClubName(d, p.ClubId)}达成协议，转会费{CareerMoney.Format(fee)}，进入{signing.Position}阵容。本赛季继续代表原俱乐部出战。", [p.Id]);`
- `NationalSpire.OwnedClubs.TransferError(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`；输入表达式：`TransferError(d, signing, negotiated)`；返回值紧邻使用处：`IsPatternExpressionSyntax: TransferError(d, signing, negotiated) is { } error`
- `NationalSpire.OwnedClubs.TransferFee(NationalSpire.CareerPerson)`；输入表达式：`TransferFee(p)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = TransferFee(p)`
- `NationalSpire.OwnedTransfer.OwnedTransfer()`；输入表达式：`new() { SellerId = p.ClubId, ArrivalSeason = d.Season + 1, Position = signing.Position, ReplaceId = signing.Position == "首发" ? signing.ReplaceId : "", Fee = fee, Contract = contract }`；返回值紧邻使用处：`ArgumentSyntax: new() { SellerId = p.ClubId, ArrivalSeason = d.Season + 1, Position = signing.Position, ReplaceId = signing.Position == "首发" ? signing.ReplaceId : "", Fee = fee, Contract = contract }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`d.Esports.OwnedClub!.Transfers.Add(new() { SellerId = p.ClubId, ArrivalSeason = d.Season + 1, Position = signing.Position, ReplaceId = signing.Position == "首发" ? signing.ReplaceId : "", Fee = fee, Contract = contract })`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.OwnedClub!.Transfers.Add(new() { SellerId = p.ClubId, ArrivalSeason = d.Season + 1, Position = signing.Position, ReplaceId = signing.Position == "首发" ? signing.ReplaceId : "", Fee = fee, Contract = contract });`

**赋值（含属性/字段和局部值）：**

- `ArrivalSeason` = `d.Season + 1`
- `contract.Position` = `signing.Position`
- `Contract` = `contract`
- `Fee` = `fee`
- `Position` = `signing.Position`
- `ReplaceId` = `signing.Position == "首发" ? signing.ReplaceId : ""`
- `seller.Budget` += `fee`
- `SellerId` = `p.ClubId`

<a id="symbol-2429e4910b3f"></a>

## `NationalSpire.OwnedClubs.ArriveTransfers(NationalSpire.CareerData) — public static void ArriveTransfers(CareerData d)`

来源：源码第 385 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitWorld.StartSeason(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-8e4cfe18b2fe)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-8c9ea9f33c3c)；[`NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`](OwnedClubs.cs.md#symbol-11696548c7d5)；[`NationalSpire.OwnedClubs.Report(NationalSpire.CareerData, string, string, string, System.Collections.Generic.List<string>)`](OwnedClubs.cs.md#symbol-4a616a09019e)；[`NationalSpire.OwnedClubs.UpdateRosterRole(NationalSpire.CareerPerson, string)`](OwnedClubs.cs.md#symbol-64e7ad9283a5)；[`NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool)`](PrivateInteractionUndo.cs.md#symbol-de9e985d044d)；[`NationalSpire.PrivateInteractionHistory.Record(NationalSpire.CareerData, string, NationalSpire.PrivateTurn, System.Text.Json.Nodes.JsonObject, bool)`](PrivateInteractionUndo.cs.md#symbol-9eda496612ca)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Remove(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Life`；`NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerData.PrivateMemorySources`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerLifeState.Mailbox`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.PublicName`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`；`NationalSpire.OwnedClubs.Report(NationalSpire.CareerData, string, string, string, System.Collections.Generic.List<string>)`；`NationalSpire.OwnedClubs.UpdateRosterRole(NationalSpire.CareerPerson, string)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubState.Contracts`；`NationalSpire.OwnedClubState.Reserves`；`NationalSpire.OwnedClubState.Starters`；`NationalSpire.OwnedClubState.Transfers`；`NationalSpire.OwnedPlayerContract.Days`；`NationalSpire.OwnedPlayerContract.EndDay`；`NationalSpire.OwnedPlayerContract.PersonId`；`NationalSpire.OwnedPlayerContract.Position`；`NationalSpire.OwnedPlayerContract.SignedDay`；`NationalSpire.OwnedTransfer.ArrivalSeason`；`NationalSpire.OwnedTransfer.Arrived`；`NationalSpire.OwnedTransfer.Contract`；`NationalSpire.OwnedTransfer.Position`；`NationalSpire.OwnedTransfer.ReplaceId`；`NationalSpire.OwnedTransfer.SourceHumanId`；`NationalSpire.OwnedTransfer.SourceTurnId`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool)`；`NationalSpire.PrivateInteractionHistory.Record(NationalSpire.CareerData, string, NationalSpire.PrivateTurn, System.Text.Json.Nodes.JsonObject, bool)`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateTurn.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, c.PersonId)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(d, c.PersonId)!`
- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, transfer.ReplaceId)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(d, transfer.ReplaceId)!`
- `NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；输入表达式：`IsOwner(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsOwner(d)`
- `NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`；输入表达式：`PositionList(o, transfer.Position)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PositionList(o, transfer.Position).Add`
- `NationalSpire.OwnedClubs.Report(NationalSpire.CareerData, string, string, string, System.Collections.Generic.List<string>)`；输入表达式：`Report(d, "转会", p.PublicName + "正式报到", $"新赛季合同生效，进入{transfer.Position}阵容。", [p.Id])`；返回值紧邻使用处：`ExpressionStatementSyntax: Report(d, "转会", p.PublicName + "正式报到", $"新赛季合同生效，进入{transfer.Position}阵容。", [p.Id]);`
- `NationalSpire.OwnedClubs.UpdateRosterRole(NationalSpire.CareerPerson, string)`；输入表达式：`UpdateRosterRole(CareerEngine.Person(d, transfer.ReplaceId)!, "轮换")`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateRosterRole(CareerEngine.Person(d, transfer.ReplaceId)!, "轮换");`
- `NationalSpire.OwnedClubs.UpdateRosterRole(NationalSpire.CareerPerson, string)`；输入表达式：`UpdateRosterRole(p, transfer.Position)`；返回值紧邻使用处：`ExpressionStatementSyntax: UpdateRosterRole(p, transfer.Position);`
- `NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool)`；输入表达式：`PrivateInteractionHistory.Capture(d, p.Id, true)`；返回值紧邻使用处：`AssignmentExpressionSyntax: before = PrivateInteractionHistory.Capture(d, p.Id, true)`
- `NationalSpire.PrivateInteractionHistory.Record(NationalSpire.CareerData, string, NationalSpire.PrivateTurn, System.Text.Json.Nodes.JsonObject, bool)`；输入表达式：`PrivateInteractionHistory.Record(d, p.Id, turn, before!, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateInteractionHistory.Record(d, p.Id, turn, before!, true);`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Turns.FirstOrDefault(t => t.Id == transfer.SourceTurnId)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .Conversations.GetValueOrDefault(p.Id)?.Turns.FirstOrDefault(t => t.Id == transfer.SourceTurnId)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`o.Transfers.Where(t => !t.Arrived && t.ArrivalSeason <= d.Season)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var transfer in o.Transfers.Where(t => !t.Arrived && t.ArrivalSeason <= d.Season))          {              var c = transfer.Contract; var p = CareerEngine.Person(d, c.PersonId)!;              var mailbox = transfer.SourceHumanId.Length == 0 ? d.Life.Mailbox : d.PrivateMemorySources.GetValueOrDefault(transfer.SourceHumanId);              var turn = mailbox?.Conversations.GetValueOrDefault(p.Id)?.Turns.FirstOrDefault(t => t.Id == transfer.SourceTurnId);              var originalMailbox = d.Life.Mailbox; string originalHuman = d.LocalHumanId;              // 加盟仍属于原合同交互，使用来源轮次保存撤回记录，不通过金额猜测关联。              System.Text.Json.Nodes.JsonObject? before = null;              if (turn != null)              {                  d.Life.Mailbox = mailbox!; d.LocalHumanId = transfer.SourceHumanId;              }              try              {                  if (turn != null) before = PrivateInteractionHistory.Capture(d, p.Id, true);                  c.SignedDay = d.Day; c.EndDay = d.Day + c.Days;                  if (transfer.Position == "首发")                  {                      o.Starters.Remove(transfer.ReplaceId); o.Reserves.Add(transfer.ReplaceId); UpdateRosterRole(CareerEngine.Person(d, transfer.ReplaceId)!, "轮换");                  }                  c.Position = transfer.Position;                  o.Contracts.Add(c); PositionList(o, transfer.Position).Add(p.Id);                  p.ClubId = o.ClubId; UpdateRosterRole(p, transfer.Position);                  transfer.Arrived = true;                  Report(d, "转会", p.PublicName + "正式报到", $"新赛季合同生效，进入{transfer.Position}阵容。", [p.Id]);                  if (turn != null) PrivateInteractionHistory.Record(d, p.Id, turn, before!, true);              }              finally { d.Life.Mailbox = originalMailbox; d.LocalHumanId = originalHuman; }          }`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.Conversations.GetValueOrDefault(p.Id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .Conversations.GetValueOrDefault(p.Id)?.Turns.FirstOrDefault(t => t.Id == transfer.SourceTurnId)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`d.PrivateMemorySources.GetValueOrDefault(transfer.SourceHumanId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: transfer.SourceHumanId.Length == 0 ? d.Life.Mailbox : d.PrivateMemorySources.GetValueOrDefault(transfer.SourceHumanId)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`o.Contracts.Add(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: o.Contracts.Add(c);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`o.Reserves.Add(transfer.ReplaceId)`；返回值紧邻使用处：`ExpressionStatementSyntax: o.Reserves.Add(transfer.ReplaceId);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`PositionList(o, transfer.Position).Add(p.Id)`；返回值紧邻使用处：`ExpressionStatementSyntax: PositionList(o, transfer.Position).Add(p.Id);`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`o.Starters.Remove(transfer.ReplaceId)`；返回值紧邻使用处：`ExpressionStatementSyntax: o.Starters.Remove(transfer.ReplaceId);`

**赋值（含属性/字段和局部值）：**

- `before` = `PrivateInteractionHistory.Capture(d, p.Id, true)`
- `c.EndDay` = `d.Day + c.Days`
- `c.Position` = `transfer.Position`
- `c.SignedDay` = `d.Day`
- `d.Life.Mailbox` = `mailbox!`
- `d.Life.Mailbox` = `originalMailbox`
- `d.LocalHumanId` = `originalHuman`
- `d.LocalHumanId` = `transfer.SourceHumanId`
- `p.ClubId` = `o.ClubId`
- `transfer.Arrived` = `true`

<a id="symbol-3b85db324fce"></a>

## `NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal) — public static void Pay(CareerData d, string title, decimal amount)`

来源：源码第 419 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterDeletion.Delete(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-2eb70f838afa)；[`NationalSpire.CircuitLedger.SeasonStart(NationalSpire.CareerData)`](CircuitLedger.cs.md#symbol-b971fd6392cb)；[`NationalSpire.CircuitLedger.Settle(NationalSpire.CareerData, NationalSpire.WorldCompetition, bool)`](CircuitLedger.cs.md#symbol-8ff7b69864e0)；[`NationalSpire.Coop.CoopRules.PayClubMembers(NationalSpire.Coop.CoopWorld)`](Coop/CoopRules.cs.md#symbol-6ee521cc017d)；[`NationalSpire.OwnedClubs.Advance(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-7fe29c98085a)；[`NationalSpire.OwnedClubs.ArrangeTransfer(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-66be5c09e822)；[`NationalSpire.OwnedClubs.AwardCommercial(NationalSpire.CareerData, string, string, int, int)`](OwnedClubs.cs.md#symbol-6b465628386d)；[`NationalSpire.OwnedClubs.CreateCore(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-21d1184d2591)；[`NationalSpire.OwnedClubs.PayDebt(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-98b9722b6128)；[`NationalSpire.OwnedClubs.Release(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-ab8d716536a6)；[`NationalSpire.OwnedClubs.SettleResults(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-7c6dba67fe98)；[`NationalSpire.OwnedClubs.SignUnchecked(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-4f3afc350ac9)；[`NationalSpire.TeamPreparations.Buy(NationalSpire.CareerData, string)`](TeamPreparation.cs.md#symbol-440f4ccf2595)

**调用：** [`NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`](LifeData.cs.md#symbol-bcb55555a432)；[`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`](LifeData.cs.md#symbol-de5af63fa4e7)；[`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`](LifeData.cs.md#symbol-54a09649188b)；`NationalSpire.FinanceEntry.FinanceEntry()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.RemoveAt(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`；`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；`NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.FinanceEntry.Amount`；`NationalSpire.FinanceEntry.Balance`；`NationalSpire.FinanceEntry.Day`；`NationalSpire.FinanceEntry.Title`；`NationalSpire.OwnedClubState.CashFlow`；`NationalSpire.OwnedClubState.Ledger`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMoney.Add(NationalSpire.CareerData, decimal)`；输入表达式：`CareerMoney.Add(d, amount)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Add(d, amount);`
- `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；输入表达式：`CareerMoney.Balance(d)`；返回值紧邻使用处：`AssignmentExpressionSyntax: Balance = CareerMoney.Balance(d)`
- `NationalSpire.CareerMoney.Record(NationalSpire.CareerData, string, decimal)`；输入表达式：`CareerMoney.Record(d, title, amount)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerMoney.Record(d, title, amount);`
- `NationalSpire.FinanceEntry.FinanceEntry()`；输入表达式：`new() { Day = d.Day, Title = title, Amount = amount, Balance = CareerMoney.Balance(d) }`；返回值紧邻使用处：`ArgumentSyntax: new() { Day = d.Day, Title = title, Amount = amount, Balance = CareerMoney.Balance(d) }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`o.Ledger.Add(new() { Day = d.Day, Title = title, Amount = amount, Balance = CareerMoney.Balance(d) })`；返回值紧邻使用处：`ExpressionStatementSyntax: o.Ledger.Add(new() { Day = d.Day, Title = title, Amount = amount, Balance = CareerMoney.Balance(d) });`
- `System.Collections.Generic.List<T>.RemoveAt(int)`；输入表达式：`o.Ledger.RemoveAt(0)`；返回值紧邻使用处：`ExpressionStatementSyntax: o.Ledger.RemoveAt(0);`

**赋值（含属性/字段和局部值）：**

- `Amount` = `amount`
- `Balance` = `CareerMoney.Balance(d)`
- `Day` = `d.Day`
- `o.CashFlow` += `amount`
- `Title` = `title`

<a id="symbol-5b2c48d0615a"></a>

## `NationalSpire.OwnedClubs.PracticeBonus(NationalSpire.CareerData, string, int, int?) — public static double PracticeBonus(CareerData d, string person, int asc, int? day = null)`

来源：源码第 426 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MatchRules.Evaluate(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?, bool)`](MatchRules.cs.md#symbol-92264d5fcfdd)

**调用：** [`NationalSpire.ClubCoaching.Factor(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-d1aa71b14a7b)；[`NationalSpire.OwnedClubs.GroupPractice(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, int, int?)`](OwnedClubs.cs.md#symbol-64763de09f26)；[`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-241a535c93f9)；[`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-8c9ea9f33c3c)；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.ClubCoaching.Factor(NationalSpire.CareerData)`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.GroupPractice(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, int, int?)`；`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；`NationalSpire.OwnedClubState.Debt`；`NationalSpire.OwnedClubState.Reserves`；`NationalSpire.OwnedClubState.Starters`；`NationalSpire.OwnedClubState.Youth`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ClubCoaching.Factor(NationalSpire.CareerData)`；输入表达式：`ClubCoaching.Factor(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: (GroupPractice(d, o.Reserves, asc, day) + GroupPractice(d, o.Youth, asc, day)) * ClubCoaching.Factor(d)`
- `NationalSpire.OwnedClubs.GroupPractice(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, int, int?)`；输入表达式：`GroupPractice(d, o.Reserves, asc, day)`；返回值紧邻使用处：`BinaryExpressionSyntax: GroupPractice(d, o.Reserves, asc, day) + GroupPractice(d, o.Youth, asc, day)`
- `NationalSpire.OwnedClubs.GroupPractice(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, int, int?)`；输入表达式：`GroupPractice(d, o.Youth, asc, day)`；返回值紧邻使用处：`BinaryExpressionSyntax: GroupPractice(d, o.Reserves, asc, day) + GroupPractice(d, o.Youth, asc, day)`
- `NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；输入表达式：`Humans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Humans(d).Contains`
- `NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；输入表达式：`IsOwner(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsOwner(d)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`Humans(d).Contains(person)`；返回值紧邻使用处：`BinaryExpressionSyntax: !IsOwner(d) || d.Esports.OwnedClub is not { } o || !o.Starters.Contains(person) || Humans(d).Contains(person)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`o.Starters.Contains(person)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !o.Starters.Contains(person)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6e1b22fd81bb"></a>

## `NationalSpire.OwnedClubs.PracticeContribution(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?) — public static double PracticeContribution(CareerData d, CareerPerson p, int asc, int? day = null)`

来源：源码第 431 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OwnedClubs.GroupPractice(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, int, int?)`](OwnedClubs.cs.md#symbol-64763de09f26)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.MatchRules.Evaluate(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?, bool)`](MatchRules.cs.md#symbol-92264d5fcfdd)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.AvatarWorldId`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerPerson.Id`；`NationalSpire.ChanceFactors.Final`；`NationalSpire.MatchRules.Evaluate(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(world + ":club-practice:" + p.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.StableHash(world + ":club-practice:" + p.Id) % 10001`
- `NationalSpire.MatchRules.Evaluate(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?, bool)`；输入表达式：`MatchRules.Evaluate(d, p, asc, day, includePractice: false)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: MatchRules.Evaluate(d, p, asc, day, includePractice: false).Final`

**赋值（含属性/字段和局部值）：**


<a id="symbol-64763de09f26"></a>

## `NationalSpire.OwnedClubs.GroupPractice(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, int, int?) — public static double GroupPractice(CareerData d, IEnumerable<string> ids, int asc, int? day = null)`

来源：源码第 441 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubPracticePreview(NationalSpire.CareerData, Godot.VBoxContainer, NationalSpire.ClubSigning, bool)`](OwnedClubScreen.cs.md#symbol-db042267110f)；[`NationalSpire.OwnedClubs.PracticeBonus(NationalSpire.CareerData, string, int, int?)`](OwnedClubs.cs.md#symbol-5b2c48d0615a)

**调用：** [`NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`](ClubCoaching.cs.md#symbol-8b4ec414486e)；[`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-241a535c93f9)；[`NationalSpire.OwnedClubs.PracticeContribution(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?)`](OwnedClubs.cs.md#symbol-6e1b22fd81bb)；`System.Collections.Generic.IEnumerable<double>.Sum()`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Math.Log(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.People`；`NationalSpire.CareerPerson.Id`；`NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`；`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.PracticeContribution(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`；输入表达式：`ClubCoaching.IsCoach(p)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !ClubCoaching.IsCoach(p)`
- `NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；输入表达式：`Humans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Humans(d).Contains`
- `NationalSpire.OwnedClubs.PracticeContribution(NationalSpire.CareerData, NationalSpire.CareerPerson, int, int?)`；输入表达式：`PracticeContribution(d, p!, asc, day)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: p => PracticeContribution(d, p!, asc, day)`
- `System.Collections.Generic.IEnumerable<double>.Sum()`；输入表达式：`members.Select(p => PracticeContribution(d, p!, asc, day)).OrderByDescending(value => value)              .Select((value, index) => index < 3 ? value : value / ((index - 1) * (1 + Math.Log(index - 1)))).Sum()`；返回值紧邻使用处：`ReturnStatementSyntax: return members.Select(p => PracticeContribution(d, p!, asc, day)).OrderByDescending(value => value)              .Select((value, index) => index < 3 ? value : value / ((index - 1) * (1 + Math.Log(index - 1)))).Sum();`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`ids.Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ids.Distinct().Where`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.FirstOrDefault(p => p.Id == id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => d.People.FirstOrDefault(p => p.Id == id)`
- `System.Collections.Generic.IEnumerable<TSource>.OrderByDescending<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`members.Select(p => PracticeContribution(d, p!, asc, day)).OrderByDescending(value => value)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: members.Select(p => PracticeContribution(d, p!, asc, day)).OrderByDescending(value => value)              .Select`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`members.Select(p => PracticeContribution(d, p!, asc, day)).OrderByDescending(value => value)              .Select((value, index) => index < 3 ? value : value / ((index - 1) * (1 + Math.Log(index - 1))))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: members.Select(p => PracticeContribution(d, p!, asc, day)).OrderByDescending(value => value)              .Select((value, index) => index < 3 ? value : value / ((index - 1) * (1 + Math.Log(index - 1)))).Sum`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`ids.Distinct().Where(id => !Humans(d).Contains(id)).Select(id => d.People.FirstOrDefault(p => p.Id == id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ids.Distinct().Where(id => !Humans(d).Contains(id)).Select(id => d.People.FirstOrDefault(p => p.Id == id)).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`members.Select(p => PracticeContribution(d, p!, asc, day))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: members.Select(p => PracticeContribution(d, p!, asc, day)).OrderByDescending`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`ids.Distinct().Where(id => !Humans(d).Contains(id)).Select(id => d.People.FirstOrDefault(p => p.Id == id)).Where(p => p != null && !ClubCoaching.IsCoach(p)).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ids.Distinct().Where(id => !Humans(d).Contains(id)).Select(id => d.People.FirstOrDefault(p => p.Id == id)).Where(p => p != null && !ClubCoaching.IsCoach(p)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`ids.Distinct().Where(id => !Humans(d).Contains(id)).Select(id => d.People.FirstOrDefault(p => p.Id == id)).Where(p => p != null && !ClubCoaching.IsCoach(p))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ids.Distinct().Where(id => !Humans(d).Contains(id)).Select(id => d.People.FirstOrDefault(p => p.Id == id)).Where(p => p != null && !ClubCoaching.IsCoach(p)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`ids.Distinct().Where(id => !Humans(d).Contains(id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ids.Distinct().Where(id => !Humans(d).Contains(id)).Select`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`Humans(d).Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Humans(d).Contains(id)`
- `System.Math.Log(double)`；输入表达式：`Math.Log(index - 1)`；返回值紧邻使用处：`BinaryExpressionSyntax: 1 + Math.Log(index - 1)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8b262987c35a"></a>

## `NationalSpire.OwnedClubs.BreakEvenFans(NationalSpire.OwnedSponsor?, decimal) — public static int? BreakEvenFans(OwnedSponsor? sponsor, decimal weeklyCost)`

来源：源码第 448 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubWeeklyFinance(Godot.VBoxContainer, NationalSpire.OwnedSponsor?, int, decimal, int)`](OwnedClubScreen.cs.md#symbol-e4836a392d68)

**调用：** [`NationalSpire.OwnedClubs.AudienceIncome(int)`](OwnedClubs.cs.md#symbol-b2b3c8e1de88)；[`NationalSpire.OwnedClubs.SponsorWeekly(NationalSpire.OwnedSponsor?, int)`](OwnedClubs.cs.md#symbol-c9d09ed04c48)；`System.Math.Min(long, long)`

**字段、属性、事件及方法组引用：** `NationalSpire.OwnedClubs.AudienceIncome(int)`；`NationalSpire.OwnedClubs.SponsorWeekly(NationalSpire.OwnedSponsor?, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.OwnedClubs.AudienceIncome(int)`；输入表达式：`AudienceIncome(high)`；返回值紧邻使用处：`BinaryExpressionSyntax: SponsorWeekly(sponsor, high) + AudienceIncome(high)`
- `NationalSpire.OwnedClubs.AudienceIncome(int)`；输入表达式：`AudienceIncome(mid)`；返回值紧邻使用处：`BinaryExpressionSyntax: SponsorWeekly(sponsor, mid) + AudienceIncome(mid)`
- `NationalSpire.OwnedClubs.SponsorWeekly(NationalSpire.OwnedSponsor?, int)`；输入表达式：`SponsorWeekly(sponsor, high)`；返回值紧邻使用处：`BinaryExpressionSyntax: SponsorWeekly(sponsor, high) + AudienceIncome(high)`
- `NationalSpire.OwnedClubs.SponsorWeekly(NationalSpire.OwnedSponsor?, int)`；输入表达式：`SponsorWeekly(sponsor, mid)`；返回值紧邻使用处：`BinaryExpressionSyntax: SponsorWeekly(sponsor, mid) + AudienceIncome(mid)`
- `System.Math.Min(long, long)`；输入表达式：`Math.Min(int.MaxValue, (long)high * 2)`；返回值紧邻使用处：`CastExpressionSyntax: (int)Math.Min(int.MaxValue, (long)high * 2)`

**赋值（含属性/字段和局部值）：**

- `high` = `(int)Math.Min(int.MaxValue, (long)high * 2)`
- `high` = `mid`
- `low` = `mid + 1`

<a id="symbol-a1b523b0541a"></a>

## `NationalSpire.OwnedClubs.ChangeSponsor(NationalSpire.CareerData, string) — public static string? ChangeSponsor(CareerData d, string id)`

来源：源码第 459 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OwnedClubs.Command(NationalSpire.CareerData, string, string, string)`](OwnedClubs.cs.md#symbol-12b38cf6ab67)

**调用：** [`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-8c9ea9f33c3c)；[`NationalSpire.OwnedClubs.Report(NationalSpire.CareerData, string, string, string, System.Collections.Generic.List<string>)`](OwnedClubs.cs.md#symbol-4a616a09019e)；[`NationalSpire.OwnedClubs.SponsorQuote(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-fb2b56604db1)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.Report(NationalSpire.CareerData, string, string, string, System.Collections.Generic.List<string>)`；`NationalSpire.OwnedClubs.SponsorQuote(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubState.NextSponsor`；`NationalSpire.OwnedClubState.Sponsor`；`NationalSpire.OwnedSponsor.Brand`；`NationalSpire.OwnedSponsor.EndDay`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(d);`
- `NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；输入表达式：`IsOwner(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsOwner(d)`
- `NationalSpire.OwnedClubs.Report(NationalSpire.CareerData, string, string, string, System.Collections.Generic.List<string>)`；输入表达式：`Report(d, "赞助", "俱乐部确认赞助合作", SponsorQuote(d, id).Brand + "将在当前合约结束后接续合作。", [])`；返回值紧邻使用处：`ExpressionStatementSyntax: Report(d, "赞助", "俱乐部确认赞助合作", SponsorQuote(d, id).Brand + "将在当前合约结束后接续合作。", []);`
- `NationalSpire.OwnedClubs.SponsorQuote(NationalSpire.CareerData, string)`；输入表达式：`SponsorQuote(d, id)`；返回值紧邻使用处：`AssignmentExpressionSyntax: o.Sponsor = SponsorQuote(d, id)`
- `NationalSpire.OwnedClubs.SponsorQuote(NationalSpire.CareerData, string)`；输入表达式：`SponsorQuote(d, id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: SponsorQuote(d, id).Brand`

**赋值（含属性/字段和局部值）：**

- `o.NextSponsor` = `id`
- `o.Sponsor` = `SponsorQuote(d, id)`

<a id="symbol-7fe29c98085a"></a>

## `NationalSpire.OwnedClubs.Advance(NationalSpire.CareerData) — public static void Advance(CareerData d)`

来源：源码第 467 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.MoveToNextDay(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-3836a38a7da9)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`](CareerLife.cs.md#symbol-0ea81cb3e558)；[`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`](LifeData.cs.md#symbol-de5af63fa4e7)；[`NationalSpire.CareerMoney.Format(decimal)`](LifeData.cs.md#symbol-c94be8205c96)；[`NationalSpire.CareerTraining.Grow(NationalSpire.CareerData, string, int, int)`](CareerTraining.cs.md#symbol-8d0cf5a9811c)；[`NationalSpire.ClubAudience.Total(NationalSpire.CareerData, string)`](ClubAudience.cs.md#symbol-6a78e48d0de3)；[`NationalSpire.MatchRules.Simulate(NationalSpire.CareerData, string, int, string, int?, bool, NationalSpire.WorldCompetition?, string?)`](MatchRules.cs.md#symbol-8fd1cedc82b2)；[`NationalSpire.OwnedClubs.AccrueHumanPay(NationalSpire.CareerData, int)`](OwnedClubs.cs.md#symbol-9f011457ce0c)；[`NationalSpire.OwnedClubs.AchievementWeekly(NationalSpire.CareerData, int?)`](OwnedClubs.cs.md#symbol-6261fe2caa42)；[`NationalSpire.OwnedClubs.AudienceIncome(int)`](OwnedClubs.cs.md#symbol-b2b3c8e1de88)；[`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-8c9ea9f33c3c)；[`NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`](OwnedClubs.cs.md#symbol-3b85db324fce)；[`NationalSpire.OwnedClubs.SettleResults(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-7c6dba67fe98)；[`NationalSpire.OwnedClubs.SponsorQuote(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-fb2b56604db1)；[`NationalSpire.OwnedClubs.SponsorWeekly(NationalSpire.OwnedSponsor?, int)`](OwnedClubs.cs.md#symbol-c9d09ed04c48)；`System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, decimal>)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Math.Max(decimal, decimal)`；`System.Math.Min(decimal, decimal)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；`NationalSpire.CareerMoney.Format(decimal)`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.Losses`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.CareerPerson.Wins`；`NationalSpire.CareerTraining.Grow(NationalSpire.CareerData, string, int, int)`；`NationalSpire.ClubAudience.Total(NationalSpire.CareerData, string)`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.MatchRules.Simulate(NationalSpire.CareerData, string, int, string, int?, bool, NationalSpire.WorldCompetition?, string?)`；`NationalSpire.OwnedClubs.AccrueHumanPay(NationalSpire.CareerData, int)`；`NationalSpire.OwnedClubs.AchievementWeekly(NationalSpire.CareerData, int?)`；`NationalSpire.OwnedClubs.AudienceIncome(int)`；`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；`NationalSpire.OwnedClubs.SettleResults(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.SponsorQuote(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubs.SponsorWeekly(NationalSpire.OwnedSponsor?, int)`；`NationalSpire.OwnedClubs.WeeklyOverhead`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubState.Contracts`；`NationalSpire.OwnedClubState.Debt`；`NationalSpire.OwnedClubState.HumanWeeklyWage`；`NationalSpire.OwnedClubState.NextPayDay`；`NationalSpire.OwnedClubState.NextSponsor`；`NationalSpire.OwnedClubState.Sponsor`；`NationalSpire.OwnedClubState.Youth`；`NationalSpire.OwnedPlayerContract.Days`；`NationalSpire.OwnedPlayerContract.EndDay`；`NationalSpire.OwnedPlayerContract.PersonId`；`NationalSpire.OwnedPlayerContract.Plan`；`NationalSpire.OwnedPlayerContract.Position`；`NationalSpire.OwnedPlayerContract.Wage`；`NationalSpire.OwnedSponsor.Brand`；`NationalSpire.OwnedSponsor.EndDay`；`NationalSpire.RunPerformance.Cleared`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, c.PersonId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(d, c.PersonId) is { } p`
- `NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；输入表达式：`CareerLife.AddEvent(d, "club-debt-" + date, "俱乐部", "俱乐部周结资金不足", "尚有" + CareerMoney.Format(o.Debt) + "待支付，陪练与青训暂停。", ["player"])`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerLife.AddEvent(d, "club-debt-" + date, "俱乐部", "俱乐部周结资金不足", "尚有" + CareerMoney.Format(o.Debt) + "待支付，陪练与青训暂停。", ["player"]);`
- `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；输入表达式：`CareerMoney.Balance(d)`；返回值紧邻使用处：`ArgumentSyntax: CareerMoney.Balance(d)`
- `NationalSpire.CareerMoney.Format(decimal)`；输入表达式：`CareerMoney.Format(o.Debt)`；返回值紧邻使用处：`BinaryExpressionSyntax: "尚有" + CareerMoney.Format(o.Debt)`
- `NationalSpire.CareerTraining.Grow(NationalSpire.CareerData, string, int, int)`；输入表达式：`CareerTraining.Grow(d, p.Id, 25, d.Season)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerTraining.Grow(d, p.Id, 25, d.Season);`
- `NationalSpire.ClubAudience.Total(NationalSpire.CareerData, string)`；输入表达式：`ClubAudience.Total(d, o.ClubId)`；返回值紧邻使用处：`ArgumentSyntax: ClubAudience.Total(d, o.ClubId)`
- `NationalSpire.MatchRules.Simulate(NationalSpire.CareerData, string, int, string, int?, bool, NationalSpire.WorldCompetition?, string?)`；输入表达式：`MatchRules.Simulate(d, p.Id, next, d.WorldId + ":youth-test:" + p.Id + date, date)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = MatchRules.Simulate(d, p.Id, next, d.WorldId + ":youth-test:" + p.Id + date, date)`
- `NationalSpire.OwnedClubs.AccrueHumanPay(NationalSpire.CareerData, int)`；输入表达式：`AccrueHumanPay(d, o.HumanWeeklyWage)`；返回值紧邻使用处：`ExpressionStatementSyntax: AccrueHumanPay(d, o.HumanWeeklyWage);`
- `NationalSpire.OwnedClubs.AchievementWeekly(NationalSpire.CareerData, int?)`；输入表达式：`AchievementWeekly(d, date)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AchievementWeekly(d, date)`
- `NationalSpire.OwnedClubs.AudienceIncome(int)`；输入表达式：`AudienceIncome(ClubAudience.Total(d, o.ClubId))`；返回值紧邻使用处：`ArgumentSyntax: AudienceIncome(ClubAudience.Total(d, o.ClubId))`
- `NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；输入表达式：`IsOwner(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsOwner(d)`
- `NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；输入表达式：`Pay(d, "俱乐部成绩赞助周结", achievement)`；返回值紧邻使用处：`ExpressionStatementSyntax: Pay(d, "俱乐部成绩赞助周结", achievement);`
- `NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；输入表达式：`Pay(d, "俱乐部会员与周边收入", AudienceIncome(ClubAudience.Total(d, o.ClubId)))`；返回值紧邻使用处：`ExpressionStatementSyntax: Pay(d, "俱乐部会员与周边收入", AudienceIncome(ClubAudience.Total(d, o.ClubId)));`
- `NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；输入表达式：`Pay(d, "俱乐部赞助周结 · " + s.Brand, SponsorWeekly(s, ClubAudience.Total(d, o.ClubId)))`；返回值紧邻使用处：`ExpressionStatementSyntax: Pay(d, "俱乐部赞助周结 · " + s.Brand, SponsorWeekly(s, ClubAudience.Total(d, o.ClubId)));`
- `NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；输入表达式：`Pay(d, "俱乐部周薪与运营" + (o.Debt > 0 ? "（部分支付）" : ""), -paid)`；返回值紧邻使用处：`ExpressionStatementSyntax: Pay(d, "俱乐部周薪与运营" + (o.Debt > 0 ? "（部分支付）" : ""), -paid);`
- `NationalSpire.OwnedClubs.SettleResults(NationalSpire.CareerData)`；输入表达式：`SettleResults(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: SettleResults(d);`
- `NationalSpire.OwnedClubs.SponsorQuote(NationalSpire.CareerData, string)`；输入表达式：`SponsorQuote(d, o.NextSponsor)`；返回值紧邻使用处：`AssignmentExpressionSyntax: o.Sponsor = SponsorQuote(d, o.NextSponsor)`
- `NationalSpire.OwnedClubs.SponsorWeekly(NationalSpire.OwnedSponsor?, int)`；输入表达式：`SponsorWeekly(s, ClubAudience.Total(d, o.ClubId))`；返回值紧邻使用处：`ArgumentSyntax: SponsorWeekly(s, ClubAudience.Total(d, o.ClubId))`
- `System.Collections.Generic.IEnumerable<TSource>.Sum<TSource>(System.Func<TSource, decimal>)`；输入表达式：`o.Contracts.Sum(c => c.Wage)`；返回值紧邻使用处：`BinaryExpressionSyntax: WeeklyOverhead + o.Contracts.Sum(c => c.Wage)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`o.Youth.Contains(c.PersonId)`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Youth.Contains(c.PersonId) || c.Plan == "growth"`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`o.Youth.Contains(p.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Youth.Contains(p.Id) && p.MaxAscension < 8`
- `System.Math.Max(decimal, decimal)`；输入表达式：`Math.Max(0, CareerMoney.Balance(d))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, CareerMoney.Balance(d))`
- `System.Math.Min(decimal, decimal)`；输入表达式：`Math.Min(Math.Max(0, CareerMoney.Balance(d)), bill)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(Math.Max(0, CareerMoney.Balance(d)), bill)`

**赋值（含属性/字段和局部值）：**

- `c.EndDay` += `c.Days`
- `o.Debt` = `bill - paid`
- `o.NextPayDay` += `7`
- `o.NextSponsor` = `""`
- `o.Sponsor` = `SponsorQuote(d, o.NextSponsor)`
- `p.MaxAscension` = `next`
- `s.EndDay` += `56`

<a id="symbol-7c6dba67fe98"></a>

## `NationalSpire.OwnedClubs.SettleResults(NationalSpire.CareerData) — public static void SettleResults(CareerData d)`

来源：源码第 507 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EsportsWorld.FinishFixture(NationalSpire.CareerData, NationalSpire.WorldCompetition, NationalSpire.WorldFixture, string, bool)`](EsportsWorld.cs.md#symbol-f16aef3da82a)；[`NationalSpire.OwnedClubs.Advance(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-7fe29c98085a)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`](LifeData.cs.md#symbol-de5af63fa4e7)；[`NationalSpire.ClubAudience.RoundGain(string, int, bool)`](ClubAudience.cs.md#symbol-10f11d54fbbe)；[`NationalSpire.ClubAudience.Total(NationalSpire.CareerData, string)`](ClubAudience.cs.md#symbol-6a78e48d0de3)；[`NationalSpire.OwnedClubs.AccrueHumanPay(NationalSpire.CareerData, int)`](OwnedClubs.cs.md#symbol-9f011457ce0c)；[`NationalSpire.OwnedClubs.GrantFans(NationalSpire.OwnedClubState, int)`](OwnedClubs.cs.md#symbol-c667223bed4e)；[`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-8c9ea9f33c3c)；[`NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`](OwnedClubs.cs.md#symbol-3b85db324fce)；[`NationalSpire.OwnedClubs.SettleAchievements(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-51faa8d5ccbd)；[`NationalSpire.OwnedClubs.SponsorWinBonus(NationalSpire.OwnedSponsor, int)`](OwnedClubs.cs.md#symbol-27e3d96628f4)；[`NationalSpire.OwnedClubs.UpgradeEconomy(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-f459a7689794)；`System.Collections.Generic.HashSet<T>.Add(T)`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Math.Max(decimal, decimal)`；`System.Math.Min(decimal, decimal)`

**字段、属性、事件及方法组引用：** `(int Round, string HomeTeam, string AwayTeam).AwayTeam`；`(int Round, string HomeTeam, string AwayTeam).HomeTeam`；`(int Round, string HomeTeam, string AwayTeam).Round`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；`NationalSpire.ClubAudience.RoundGain(string, int, bool)`；`NationalSpire.ClubAudience.Total(NationalSpire.CareerData, string)`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.AccrueHumanPay(NationalSpire.CareerData, int)`；`NationalSpire.OwnedClubs.GrantFans(NationalSpire.OwnedClubState, int)`；`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；`NationalSpire.OwnedClubs.SettleAchievements(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.SponsorWinBonus(NationalSpire.OwnedSponsor, int)`；`NationalSpire.OwnedClubs.UpgradeEconomy(NationalSpire.CareerData)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubState.Contracts`；`NationalSpire.OwnedClubState.Debt`；`NationalSpire.OwnedClubState.HumanWinBonus`；`NationalSpire.OwnedClubState.PaidResults`；`NationalSpire.OwnedClubState.Sponsor`；`NationalSpire.OwnedPlayerContract.PersonId`；`NationalSpire.OwnedPlayerContract.WinBonus`；`NationalSpire.WorldCompetition.Cooperative`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Id`；`NationalSpire.WorldCompetition.Kind`；`NationalSpire.WorldCompetition.TeamEvent`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.AwayTeam`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.HomeTeam`；`NationalSpire.WorldFixture.Round`；`NationalSpire.WorldFixture.WinnerId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, f.WinnerId)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.DisplayName(d, f.WinnerId) + "获胜奖金"`
- `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；输入表达式：`CareerMoney.Balance(d)`；返回值紧邻使用处：`ArgumentSyntax: CareerMoney.Balance(d)`
- `NationalSpire.ClubAudience.RoundGain(string, int, bool)`；输入表达式：`ClubAudience.RoundGain(c.Kind, tie.Key.Round, wins >= (c.Cooperative ? 1 : 2))`；返回值紧邻使用处：`ArgumentSyntax: ClubAudience.RoundGain(c.Kind, tie.Key.Round, wins >= (c.Cooperative ? 1 : 2))`
- `NationalSpire.ClubAudience.Total(NationalSpire.CareerData, string)`；输入表达式：`ClubAudience.Total(d, o.ClubId)`；返回值紧邻使用处：`ArgumentSyntax: ClubAudience.Total(d, o.ClubId)`
- `NationalSpire.OwnedClubs.AccrueHumanPay(NationalSpire.CareerData, int)`；输入表达式：`AccrueHumanPay(d, o.HumanWinBonus)`；返回值紧邻使用处：`ExpressionStatementSyntax: AccrueHumanPay(d, o.HumanWinBonus);`
- `NationalSpire.OwnedClubs.GrantFans(NationalSpire.OwnedClubState, int)`；输入表达式：`GrantFans(o, ClubAudience.RoundGain(c.Kind, tie.Key.Round, wins >= (c.Cooperative ? 1 : 2)))`；返回值紧邻使用处：`ExpressionStatementSyntax: GrantFans(o, ClubAudience.RoundGain(c.Kind, tie.Key.Round, wins >= (c.Cooperative ? 1 : 2)));`
- `NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；输入表达式：`IsOwner(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsOwner(d)`
- `NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；输入表达式：`Pay(d, "俱乐部获胜赞助奖金", SponsorWinBonus(sponsor, ClubAudience.Total(d, o.ClubId)))`；返回值紧邻使用处：`ExpressionStatementSyntax: Pay(d, "俱乐部获胜赞助奖金", SponsorWinBonus(sponsor, ClubAudience.Total(d, o.ClubId)));`
- `NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；输入表达式：`Pay(d, CareerEngine.DisplayName(d, f.WinnerId) + "获胜奖金", -paid)`；返回值紧邻使用处：`ExpressionStatementSyntax: Pay(d, CareerEngine.DisplayName(d, f.WinnerId) + "获胜奖金", -paid);`
- `NationalSpire.OwnedClubs.SettleAchievements(NationalSpire.CareerData)`；输入表达式：`SettleAchievements(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: SettleAchievements(d);`
- `NationalSpire.OwnedClubs.SponsorWinBonus(NationalSpire.OwnedSponsor, int)`；输入表达式：`SponsorWinBonus(sponsor, ClubAudience.Total(d, o.ClubId))`；返回值紧邻使用处：`ArgumentSyntax: SponsorWinBonus(sponsor, ClubAudience.Total(d, o.ClubId))`
- `NationalSpire.OwnedClubs.UpgradeEconomy(NationalSpire.CareerData)`；输入表达式：`UpgradeEconomy(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: UpgradeEconomy(d);`
- `System.Collections.Generic.HashSet<T>.Add(T)`；输入表达式：`o.PaidResults.Add(receipt)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !o.PaidResults.Add(receipt)`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`g.All(f => f.Finished)`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Count() == (c.Cooperative ? 1 : 3) && g.All(f => f.Finished)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`g.Count()`；返回值紧邻使用处：`BinaryExpressionSyntax: g.Count() == (c.Cooperative ? 1 : 3)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>(System.Func<TSource, bool>)`；输入表达式：`tie.Count(f => f.WinnerId == (home ? f.HomeId : f.AwayId))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = tie.Count(f => f.WinnerId == (home ? f.HomeId : f.AwayId))`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`o.Contracts.FirstOrDefault(ct => ct.PersonId == f.WinnerId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: o.Contracts.FirstOrDefault(ct => ct.PersonId == f.WinnerId) is { } contract`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`c.Fixtures.Where(f => f.HomeTeam == o.ClubId || f.AwayTeam == o.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.HomeTeam == o.ClubId || f.AwayTeam == o.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(f => f.HomeTeam == o.ClubId || f.AwayTeam == o.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).Where(g => g.Count() == (c.Cooperative ? 1 : 3) && g.All(f => f.Finished))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var tie in c.Fixtures.Where(f => f.HomeTeam == o.ClubId || f.AwayTeam == o.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).Where(g => g.Count() == (c.Cooperative ? 1 : 3) && g.All(f => f.Finished)))              {                  string receipt = c.Id + ":" + tie.Key.Round + ":" + tie.Key.HomeTeam + ":" + tie.Key.AwayTeam;                  if (!o.PaidResults.Add(receipt)) continue;                  bool home = tie.Key.HomeTeam == o.ClubId;                  int wins = tie.Count(f => f.WinnerId == (home ? f.HomeId : f.AwayId));                  GrantFans(o, ClubAudience.RoundGain(c.Kind, tie.Key.Round, wins >= (c.Cooperative ? 1 : 2)));                  if (c.Cooperative && wins >= 1) AccrueHumanPay(d, o.HumanWinBonus);                  if (wins >= (c.Cooperative ? 1 : 2) && o.Sponsor is { } sponsor) Pay(d, "俱乐部获胜赞助奖金", SponsorWinBonus(sponsor, ClubAudience.Total(d, o.ClubId)));                  foreach (var f in tie.Where(f => f.WinnerId == (home ? f.HomeId : f.AwayId)))                      if (!c.Cooperative && o.Contracts.FirstOrDefault(ct => ct.PersonId == f.WinnerId) is { } contract)                      {                          decimal paid = Math.Min(Math.Max(0, CareerMoney.Balance(d)), contract.WinBonus);                          Pay(d, CareerEngine.DisplayName(d, f.WinnerId) + "获胜奖金", -paid); o.Debt += contract.WinBonus - paid;                      }              }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Where(f => f.HomeTeam == o.ClubId || f.AwayTeam == o.ClubId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Fixtures.Where(f => f.HomeTeam == o.ClubId || f.AwayTeam == o.ClubId)                  .GroupBy`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Where(c => c.TeamEvent && c.Kind is "league" or "continental")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var c in d.Esports.Competitions.Where(c => c.TeamEvent && c.Kind is "league" or "continental"))              foreach (var tie in c.Fixtures.Where(f => f.HomeTeam == o.ClubId || f.AwayTeam == o.ClubId)                  .GroupBy(f => (f.Round, f.HomeTeam, f.AwayTeam)).Where(g => g.Count() == (c.Cooperative ? 1 : 3) && g.All(f => f.Finished)))              {                  string receipt = c.Id + ":" + tie.Key.Round + ":" + tie.Key.HomeTeam + ":" + tie.Key.AwayTeam;                  if (!o.PaidResults.Add(receipt)) continue;                  bool home = tie.Key.HomeTeam == o.ClubId;                  int wins = tie.Count(f => f.WinnerId == (home ? f.HomeId : f.AwayId));                  GrantFans(o, ClubAudience.RoundGain(c.Kind, tie.Key.Round, wins >= (c.Cooperative ? 1 : 2)));                  if (c.Cooperative && wins >= 1) AccrueHumanPay(d, o.HumanWinBonus);                  if (wins >= (c.Cooperative ? 1 : 2) && o.Sponsor is { } sponsor) Pay(d, "俱乐部获胜赞助奖金", SponsorWinBonus(sponsor, ClubAudience.Total(d, o.ClubId)));                  foreach (var f in tie.Where(f => f.WinnerId == (home ? f.HomeId : f.AwayId)))                      if (!c.Cooperative && o.Contracts.FirstOrDefault(ct => ct.PersonId == f.WinnerId) is { } contract)                      {                          decimal paid = Math.Min(Math.Max(0, CareerMoney.Balance(d)), contract.WinBonus);                          Pay(d, CareerEngine.DisplayName(d, f.WinnerId) + "获胜奖金", -paid); o.Debt += contract.WinBonus - paid;                      }              }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`tie.Where(f => f.WinnerId == (home ? f.HomeId : f.AwayId))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var f in tie.Where(f => f.WinnerId == (home ? f.HomeId : f.AwayId)))                      if (!c.Cooperative && o.Contracts.FirstOrDefault(ct => ct.PersonId == f.WinnerId) is { } contract)                      {                          decimal paid = Math.Min(Math.Max(0, CareerMoney.Balance(d)), contract.WinBonus);                          Pay(d, CareerEngine.DisplayName(d, f.WinnerId) + "获胜奖金", -paid); o.Debt += contract.WinBonus - paid;                      }`
- `System.Math.Max(decimal, decimal)`；输入表达式：`Math.Max(0, CareerMoney.Balance(d))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, CareerMoney.Balance(d))`
- `System.Math.Min(decimal, decimal)`；输入表达式：`Math.Min(Math.Max(0, CareerMoney.Balance(d)), contract.WinBonus)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(Math.Max(0, CareerMoney.Balance(d)), contract.WinBonus)`

**赋值（含属性/字段和局部值）：**

- `o.Debt` += `contract.WinBonus - paid`

<a id="symbol-4a616a09019e"></a>

## `NationalSpire.OwnedClubs.Report(NationalSpire.CareerData, string, string, string, System.Collections.Generic.List<string>) — public static void Report(CareerData d, string topic, string title, string detail, List<string> people)`

来源：源码第 532 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OwnedClubs.ArrangeTransfer(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-66be5c09e822)；[`NationalSpire.OwnedClubs.ArriveTransfers(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-2429e4910b3f)；[`NationalSpire.OwnedClubs.AwardCommercial(NationalSpire.CareerData, string, string, int, int)`](OwnedClubs.cs.md#symbol-6b465628386d)；[`NationalSpire.OwnedClubs.ChangeSponsor(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-a1b523b0541a)；[`NationalSpire.OwnedClubs.Recruit(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-bad0a27b1a6b)；[`NationalSpire.OwnedClubs.Release(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-ab8d716536a6)

**调用：** [`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`](CareerLife.cs.md#symbol-0ea81cb3e558)；[`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`](EsportsWorld.cs.md#symbol-54b1e9fa0cf0)；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubState.ManagerId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；输入表达式：`CareerLife.AddEvent(d, "owned-" + Guid.NewGuid().ToString("N"), topic, EsportsWorld.ClubName(d, d.Esports.ClubId) + " · " + title, detail, [d.Esports.OwnedClub?.ManagerId ?? "player", ..people], true)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>          CareerLife.AddEvent(d, "owned-" + Guid.NewGuid().ToString("N"), topic, EsportsWorld.ClubName(d, d.Esports.ClubId) + " · " + title, detail, [d.Esports.OwnedClub?.ManagerId ?? "player", ..people], true)`
- `NationalSpire.EsportsWorld.ClubName(NationalSpire.CareerData, string)`；输入表达式：`EsportsWorld.ClubName(d, d.Esports.ClubId)`；返回值紧邻使用处：`BinaryExpressionSyntax: EsportsWorld.ClubName(d, d.Esports.ClubId) + " · "`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`BinaryExpressionSyntax: "owned-" + Guid.NewGuid().ToString("N")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-871ad0e2a2c9"></a>

## `NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData) — public static bool CanOperate(CareerData d)`

来源：源码第 534 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Accept(NationalSpire.CareerData, string, string)`](CareerLife.cs.md#symbol-cce5ea9d3250)；[`NationalSpire.CareerLife.Offer(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-06bdec919490)；[`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.PrivateActions()`](PrivateMessageScreen.cs.md#symbol-6e8c11ead905)；[`NationalSpire.ClubCoaching.Appoint(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-15fbcfa0d281)；[`NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-e30d7b812432)；[`NationalSpire.ClubPrograms.Advance(NationalSpire.CareerData, NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-b01f1c3252f6)；[`NationalSpire.ClubPrograms.Error(NationalSpire.CareerData, NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-160ff8c6cde3)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.OwnedClubs.CompleteActivity(NationalSpire.CareerData, NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-d53f4fbd3e4e)；[`NationalSpire.PrivateContracts.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-dbd791b573e7)；[`NationalSpire.PrivateMessagePrompts.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-4b9d12b26f65)；[`NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`](PrivateMessages.cs.md#symbol-7bf623828ccc)；[`NationalSpire.PrivateMessages.PrepareAttachments(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>)`](PrivateMessages.cs.md#symbol-f2d6d9cf9c86)；[`NationalSpire.PrivatePublicContext.Profiles(NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?)`](PrivatePublicContext.cs.md#symbol-d9c12bf4e41b)

**调用：** [`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-8c9ea9f33c3c)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.LocalHumanId`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；`NationalSpire.OwnedClubState.ManagerId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；输入表达式：`IsOwner(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: IsOwner(d) && (d.LocalHumanId.Length == 0 || d.LocalHumanId == d.Esports.OwnedClub!.ManagerId)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d53f4fbd3e4e"></a>

## `NationalSpire.OwnedClubs.CompleteActivity(NationalSpire.CareerData, NationalSpire.LifeActivity) — public static string CompleteActivity(CareerData d, LifeActivity a)`

来源：源码第 535 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Complete(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerLife.cs.md#symbol-e559cea1bbf6)

**调用：** [`NationalSpire.CareerEngine.StableHash(string)`](CareerEngine.cs.md#symbol-8e24f8ce19fb)；[`NationalSpire.CareerLife.ActivityBenefit(NationalSpire.LifeActivity, int)`](CareerLife.cs.md#symbol-ed5e868de0b9)；[`NationalSpire.CareerTraining.Gains(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerTraining.cs.md#symbol-6bab0ebe3489)；[`NationalSpire.CareerTraining.Grow(NationalSpire.CareerData, string, int, int)`](CareerTraining.cs.md#symbol-8d0cf5a9811c)；[`NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-f251644672be)；[`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-871ad0e2a2c9)；[`NationalSpire.OwnedClubs.GrantFans(NationalSpire.OwnedClubState, int)`](OwnedClubs.cs.md#symbol-c667223bed4e)；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerData.WorldId`；`NationalSpire.CareerEngine.StableHash(string)`；`NationalSpire.CareerLife.ActivityBenefit(NationalSpire.LifeActivity, int)`；`NationalSpire.CareerTraining.Gains(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.CareerTraining.Grow(NationalSpire.CareerData, string, int, int)`；`NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.LifeActivity.ClubId`；`NationalSpire.LifeActivity.Id`；`NationalSpire.LifeActivity.LongProject`；`NationalSpire.LifeActivity.TermsVersion`；`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.GrantFans(NationalSpire.OwnedClubState, int)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubState.Contracts`；`NationalSpire.OwnedPlayerContract.PersonId`；`NationalSpire.OwnedPlayerContract.Position`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.StableHash(string)`；输入表达式：`CareerEngine.StableHash(d.WorldId + a.Id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.StableHash(d.WorldId + a.Id) % 301`
- `NationalSpire.CareerLife.ActivityBenefit(NationalSpire.LifeActivity, int)`；输入表达式：`CareerLife.ActivityBenefit(a, 300 + CareerEngine.StableHash(d.WorldId + a.Id) % 301)`；返回值紧邻使用处：`ArgumentSyntax: CareerLife.ActivityBenefit(a, 300 + CareerEngine.StableHash(d.WorldId + a.Id) % 301)`
- `NationalSpire.CareerTraining.Gains(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`CareerTraining.Gains(d, a)`；返回值紧邻使用处：`BinaryExpressionSyntax: "训练完成。" + CareerTraining.Gains(d, a)`
- `NationalSpire.CareerTraining.Grow(NationalSpire.CareerData, string, int, int)`；输入表达式：`CareerTraining.Grow(d, c.PersonId, a.TermsVersion >= 3 ? 100 : 50, d.Season)`；返回值紧邻使用处：`AssignmentExpressionSyntax: total += CareerTraining.Grow(d, c.PersonId, a.TermsVersion >= 3 ? 100 : 50, d.Season)`
- `NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`；输入表达式：`ClubPrograms.IsTraining(a)`；返回值紧邻使用处：`IfStatementSyntax: if (ClubPrograms.IsTraining(a)) return "训练完成。" + CareerTraining.Gains(d, a);`
- `NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；输入表达式：`CanOperate(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CanOperate(d)`
- `NationalSpire.OwnedClubs.GrantFans(NationalSpire.OwnedClubState, int)`；输入表达式：`GrantFans(o, CareerLife.ActivityBenefit(a, 300 + CareerEngine.StableHash(d.WorldId + a.Id) % 301))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = GrantFans(o, CareerLife.ActivityBenefit(a, 300 + CareerEngine.StableHash(d.WorldId + a.Id) % 301))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`o.Contracts.Where(c => c.Position != "教练")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var c in o.Contracts.Where(c => c.Position != "教练")) total += CareerTraining.Grow(d, c.PersonId, a.TermsVersion >= 3 ? 100 : 50, d.Season);`

**赋值（含属性/字段和局部值）：**

- `total` += `CareerTraining.Grow(d, c.PersonId, a.TermsVersion >= 3 ? 100 : 50, d.Season)`

<a id="symbol-12b38cf6ab67"></a>

## `NationalSpire.OwnedClubs.Command(NationalSpire.CareerData, string, string, string) — public static string? Command(CareerData d, string kind, string target, string text)`

来源：源码第 549 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubAction(NationalSpire.CareerData, string, string, string, System.Action?)`](OwnedClubScreen.cs.md#symbol-9c161e058b4e)；[`NationalSpire.Coop.CoopRules.Apply(NationalSpire.Coop.CoopWorld, ulong, NationalSpire.Coop.CoopCommand, System.Collections.Generic.IReadOnlySet<ulong>, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-71eae0adc0d0)

**调用：** [`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.ClubCoaching.Appoint(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-15fbcfa0d281)；[`NationalSpire.ClubCoaching.SetPlayerCoach(NationalSpire.CareerData, bool)`](ClubCoaching.cs.md#symbol-fa4109028289)；[`NationalSpire.ClubCoaching.SetPlayerPosition(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-68aeffe9f915)；[`NationalSpire.ClubCoaching.StopTraining(NationalSpire.CareerData, string)`](ClubCoaching.cs.md#symbol-eacca79a5d86)；[`NationalSpire.OwnedClubs.ArrangeTransfer(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-66be5c09e822)；[`NationalSpire.OwnedClubs.Assign(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-e97dde3c003f)；[`NationalSpire.OwnedClubs.ChangeSponsor(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-a1b523b0541a)；[`NationalSpire.OwnedClubs.Create(NationalSpire.CareerData, NationalSpire.ClubDraft)`](OwnedClubs.cs.md#symbol-2a700a81b2ac)；[`NationalSpire.OwnedClubs.PayDebt(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-98b9722b6128)；[`NationalSpire.OwnedClubs.Recruit(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`](OwnedClubs.cs.md#symbol-bad0a27b1a6b)；[`NationalSpire.OwnedClubs.Release(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-ab8d716536a6)；[`NationalSpire.OwnedClubs.Swap(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-581cdf4f2390)；[`NationalSpire.OwnedClubSchedule.ChangeRegion(NationalSpire.CareerData, string)`](OwnedClubSchedule.cs.md#symbol-b24bb65463ab)；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；`System.IO.InvalidDataException.InvalidDataException(string?)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.ClubCoaching.Appoint(NationalSpire.CareerData, string, string)`；`NationalSpire.ClubCoaching.SetPlayerCoach(NationalSpire.CareerData, bool)`；`NationalSpire.ClubCoaching.SetPlayerPosition(NationalSpire.CareerData, string, string)`；`NationalSpire.ClubCoaching.StopTraining(NationalSpire.CareerData, string)`；`NationalSpire.CoachAppointment.PersonId`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.ArrangeTransfer(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`；`NationalSpire.OwnedClubs.Assign(NationalSpire.CareerData, string, string)`；`NationalSpire.OwnedClubs.ChangeSponsor(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubs.Create(NationalSpire.CareerData, NationalSpire.ClubDraft)`；`NationalSpire.OwnedClubs.PayDebt(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.Recruit(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`；`NationalSpire.OwnedClubs.Release(NationalSpire.CareerData, string, string)`；`NationalSpire.OwnedClubs.Swap(NationalSpire.CareerData, string, string)`；`NationalSpire.OwnedClubSchedule.ChangeRegion(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubState.CoachAppointments`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(d);`
- `NationalSpire.ClubCoaching.Appoint(NationalSpire.CareerData, string, string)`；输入表达式：`ClubCoaching.Appoint(d, target, text)`；返回值紧邻使用处：`ReturnStatementSyntax: return ClubCoaching.Appoint(d, target, text);`
- `NationalSpire.ClubCoaching.SetPlayerCoach(NationalSpire.CareerData, bool)`；输入表达式：`ClubCoaching.SetPlayerCoach(d, text == "1")`；返回值紧邻使用处：`ReturnStatementSyntax: return ClubCoaching.SetPlayerCoach(d, text == "1");`
- `NationalSpire.ClubCoaching.SetPlayerPosition(NationalSpire.CareerData, string, string)`；输入表达式：`ClubCoaching.SetPlayerPosition(d, target, text)`；返回值紧邻使用处：`ReturnStatementSyntax: return ClubCoaching.SetPlayerPosition(d, target, text);`
- `NationalSpire.ClubCoaching.StopTraining(NationalSpire.CareerData, string)`；输入表达式：`ClubCoaching.StopTraining(d, target)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClubCoaching.StopTraining(d, target);`
- `NationalSpire.OwnedClubs.ArrangeTransfer(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`；输入表达式：`ArrangeTransfer(d, JsonSerializer.Deserialize<ClubSigning>(text) ?? throw new InvalidDataException("合同为空。"))`；返回值紧邻使用处：`ReturnStatementSyntax: return ArrangeTransfer(d, JsonSerializer.Deserialize<ClubSigning>(text) ?? throw new InvalidDataException("合同为空。"));`
- `NationalSpire.OwnedClubs.Assign(NationalSpire.CareerData, string, string)`；输入表达式：`Assign(d, target, text)`；返回值紧邻使用处：`ReturnStatementSyntax: return Assign(d, target, text);`
- `NationalSpire.OwnedClubs.ChangeSponsor(NationalSpire.CareerData, string)`；输入表达式：`ChangeSponsor(d, target)`；返回值紧邻使用处：`ReturnStatementSyntax: return ChangeSponsor(d, target);`
- `NationalSpire.OwnedClubs.Create(NationalSpire.CareerData, NationalSpire.ClubDraft)`；输入表达式：`Create(d, JsonSerializer.Deserialize<ClubDraft>(text) ?? throw new InvalidDataException("草案为空。"))`；返回值紧邻使用处：`ReturnStatementSyntax: return Create(d, JsonSerializer.Deserialize<ClubDraft>(text) ?? throw new InvalidDataException("草案为空。"));`
- `NationalSpire.OwnedClubs.PayDebt(NationalSpire.CareerData)`；输入表达式：`PayDebt(d)`；返回值紧邻使用处：`ReturnStatementSyntax: return PayDebt(d);`
- `NationalSpire.OwnedClubs.Recruit(NationalSpire.CareerData, NationalSpire.ClubSigning, NationalSpire.OwnedPlayerContract?)`；输入表达式：`Recruit(d, JsonSerializer.Deserialize<ClubSigning>(text) ?? throw new InvalidDataException("签约内容为空。"))`；返回值紧邻使用处：`ReturnStatementSyntax: return Recruit(d, JsonSerializer.Deserialize<ClubSigning>(text) ?? throw new InvalidDataException("签约内容为空。"));`
- `NationalSpire.OwnedClubs.Release(NationalSpire.CareerData, string, string)`；输入表达式：`Release(d, target, text)`；返回值紧邻使用处：`ReturnStatementSyntax: return Release(d, target, text);`
- `NationalSpire.OwnedClubs.Swap(NationalSpire.CareerData, string, string)`；输入表达式：`Swap(d, target, text)`；返回值紧邻使用处：`ReturnStatementSyntax: return Swap(d, target, text);`
- `NationalSpire.OwnedClubSchedule.ChangeRegion(NationalSpire.CareerData, string)`；输入表达式：`OwnedClubSchedule.ChangeRegion(d, target)`；返回值紧邻使用处：`ReturnStatementSyntax: return OwnedClubSchedule.ChangeRegion(d, target);`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`d.Esports.OwnedClub!.CoachAppointments.RemoveAll(a => a.PersonId == target)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.OwnedClub!.CoachAppointments.RemoveAll(a => a.PersonId == target);`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("草案为空。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidDataException("草案为空。")`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("合同为空。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidDataException("合同为空。")`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("签约内容为空。")`；返回值紧邻使用处：`ThrowExpressionSyntax: throw new InvalidDataException("签约内容为空。")`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<ClubDraft>(text)`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<ClubDraft>(text) ?? throw new InvalidDataException("草案为空。")`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<ClubSigning>(text)`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<ClubSigning>(text) ?? throw new InvalidDataException("合同为空。")`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<ClubSigning>(text)`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<ClubSigning>(text) ?? throw new InvalidDataException("签约内容为空。")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-98b9722b6128"></a>

## `NationalSpire.OwnedClubs.PayDebt(NationalSpire.CareerData) — public static string? PayDebt(CareerData d)`

来源：源码第 570 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OwnedClubs.Command(NationalSpire.CareerData, string, string, string)`](OwnedClubs.cs.md#symbol-12b38cf6ab67)

**调用：** [`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`](LifeData.cs.md#symbol-de5af63fa4e7)；[`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-8c9ea9f33c3c)；[`NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`](OwnedClubs.cs.md#symbol-3b85db324fce)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Math.Max(decimal, decimal)`；`System.Math.Min(decimal, decimal)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；`NationalSpire.OwnedClubState.Debt`；`NationalSpire.OwnedClubState.HumanPayDue`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerMoney.Balance(NationalSpire.CareerData)`；输入表达式：`CareerMoney.Balance(d)`；返回值紧邻使用处：`ArgumentSyntax: CareerMoney.Balance(d)`
- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(d);`
- `NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；输入表达式：`IsOwner(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsOwner(d)`
- `NationalSpire.OwnedClubs.Pay(NationalSpire.CareerData, string, decimal)`；输入表达式：`Pay(d, "补发俱乐部欠款", -amount)`；返回值紧邻使用处：`ExpressionStatementSyntax: Pay(d, "补发俱乐部欠款", -amount);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.OwnedClub.HumanPayDue.Values.Any(value => value > 0)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.Esports.OwnedClub.HumanPayDue.Values.Any(value => value > 0)`
- `System.Math.Max(decimal, decimal)`；输入表达式：`Math.Max(0, CareerMoney.Balance(d))`；返回值紧邻使用处：`ArgumentSyntax: Math.Max(0, CareerMoney.Balance(d))`
- `System.Math.Min(decimal, decimal)`；输入表达式：`Math.Min(Math.Max(0, CareerMoney.Balance(d)), d.Esports.OwnedClub.Debt)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(Math.Max(0, CareerMoney.Balance(d)), d.Esports.OwnedClub.Debt)`

**赋值（含属性/字段和局部值）：**

- `d.Esports.OwnedClub.Debt` -= `amount`

<a id="symbol-72f89f54f561"></a>

## `NationalSpire.ClubPrograms.Get(string) — private static Terms? Get(string title)`

来源：源码第 584 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ClubPrograms.CanOffer(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-359a3dbeb02e)；[`NationalSpire.ClubPrograms.Effective(NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-b76b0b763ab3)；[`NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-f251644672be)；[`NationalSpire.ClubPrograms.Targets(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-30a147299dc6)

**调用：** `NationalSpire.ClubPrograms.Terms.Terms(int, int, int, bool)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ClubPrograms.Terms.Terms(int, int, int, bool)`；输入表达式：`new(Defense: 1400)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "高压战斗特训" => new(Defense: 1400)`
- `NationalSpire.ClubPrograms.Terms.Terms(int, int, int, bool)`；输入表达式：`new(Temporary: 600, Weekly: 50)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "教练驻队指导" => new(Temporary: 600, Weekly: 50)`
- `NationalSpire.ClubPrograms.Terms.Terms(int, int, int, bool)`；输入表达式：`new(Temporary: 800)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "全队集中备赛" => new(Temporary: 800)`
- `NationalSpire.ClubPrograms.Terms.Terms(int, int, int, bool)`；输入表达式：`new(Weekly: 50)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "整理战队录像库" => new(Weekly: 50)`
- `NationalSpire.ClubPrograms.Terms.Terms(int, int, int, bool)`；输入表达式：`new(Weekly: 75, Academy: true)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "建设青训课程" => new(Weekly: 75, Academy: true)`
- `NationalSpire.ClubPrograms.Terms.Terms(int, int, int, bool)`；输入表达式：`new(Weekly: 75)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: "建立全队训练体系" => new(Weekly: 75)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b76b0b763ab3"></a>

## `NationalSpire.ClubPrograms.Effective(NationalSpire.LifeActivity) — private static Terms Effective(LifeActivity a)`

来源：源码第 594 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ClubPrograms.Description(NationalSpire.CareerData, NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-35a5fe8029e5)；[`NationalSpire.ClubPrograms.Snapshot(NationalSpire.CareerData, NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-48edcdfd89d0)

**调用：** [`NationalSpire.ClubPrograms.Get(string)`](OwnedClubs.cs.md#symbol-72f89f54f561)

**字段、属性、事件及方法组引用：** `NationalSpire.ClubPrograms.Get(string)`；`NationalSpire.ClubPrograms.Terms.Defense`；`NationalSpire.ClubPrograms.Terms.Temporary`；`NationalSpire.ClubPrograms.Terms.Weekly`；`NationalSpire.LifeActivity.TermsVersion`；`NationalSpire.LifeActivity.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ClubPrograms.Get(string)`；输入表达式：`Get(a.Title)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: Get(a.Title)!`

**赋值（含属性/字段和局部值）：**

- `Defense` = `t.Defense * 2`
- `Temporary` = `t.Temporary * 2`
- `Weekly` = `t.Weekly * 2`

<a id="symbol-f251644672be"></a>

## `NationalSpire.ClubPrograms.IsTraining(NationalSpire.LifeActivity) — public static bool IsTraining(LifeActivity a)`

来源：源码第 599 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Accept(NationalSpire.CareerData, string, string)`](CareerLife.cs.md#symbol-cce5ea9d3250)；[`NationalSpire.CareerLife.Advance(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-62ec6434f115)；[`NationalSpire.CareerLife.Expected(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerLife.cs.md#symbol-44d430d90686)；[`NationalSpire.CareerRelics.Duration(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerRelics.cs.md#symbol-5a1db0b8215e)；[`NationalSpire.CareerScreen.ActivityCard(NationalSpire.CareerData, NationalSpire.LifeActivity)`](LifeScreen.cs.md#symbol-5b3e0aaad277)；[`NationalSpire.CareerTraining.Temporary(NationalSpire.CareerData, string, int, bool)`](CareerTraining.cs.md#symbol-3a66a2b5dee0)；[`NationalSpire.OwnedClubs.CompleteActivity(NationalSpire.CareerData, NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-d53f4fbd3e4e)

**调用：** [`NationalSpire.ClubPrograms.Get(string)`](OwnedClubs.cs.md#symbol-72f89f54f561)

**字段、属性、事件及方法组引用：** `NationalSpire.ClubPrograms.Get(string)`；`NationalSpire.LifeActivity.Kind`；`NationalSpire.LifeActivity.TermsVersion`；`NationalSpire.LifeActivity.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ClubPrograms.Get(string)`；输入表达式：`Get(a.Title)`；返回值紧邻使用处：`BinaryExpressionSyntax: Get(a.Title) != null`

**赋值（含属性/字段和局部值）：**


<a id="symbol-30a147299dc6"></a>

## `NationalSpire.ClubPrograms.Targets(NationalSpire.CareerData, string) — private static List<string> Targets(CareerData d, string title)`

来源：源码第 600 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ClubPrograms.CanOffer(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-359a3dbeb02e)；[`NationalSpire.ClubPrograms.Description(NationalSpire.CareerData, NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-35a5fe8029e5)；[`NationalSpire.ClubPrograms.Details(NationalSpire.CareerData, NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-53ba79900734)；[`NationalSpire.ClubPrograms.Snapshot(NationalSpire.CareerData, NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-48edcdfd89d0)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.ClubPrograms.Get(string)`](OwnedClubs.cs.md#symbol-72f89f54f561)；[`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-241a535c93f9)；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.ClubPrograms.Get(string)`；`NationalSpire.ClubPrograms.Terms.Academy`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubState.Coaches`；`NationalSpire.OwnedClubState.Contracts`；`NationalSpire.OwnedClubState.Reserves`；`NationalSpire.OwnedClubState.Youth`；`NationalSpire.OwnedPlayerContract.PersonId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CareerEngine.Person(d, id)?.ClubId`
- `NationalSpire.ClubPrograms.Get(string)`；输入表达式：`Get(title)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: Get(title)?.Academy`
- `NationalSpire.OwnedClubs.Humans(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.Humans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: OwnedClubs.Humans(d).Contains`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`o.Contracts.Select(c => c.PersonId).Where(id => !OwnedClubs.Humans(d).Contains(id)              && CareerEngine.Person(d, id)?.ClubId == o.ClubId && !o.Coaches.Contains(id) && (!academy || o.Reserves.Contains(id) || o.Youth.Contains(id))).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: o.Contracts.Select(c => c.PersonId).Where(id => !OwnedClubs.Humans(d).Contains(id)              && CareerEngine.Person(d, id)?.ClubId == o.ClubId && !o.Coaches.Contains(id) && (!academy || o.Reserves.Contains(id) || o.Youth.Contains(id))).Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`o.Contracts.Select(c => c.PersonId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: o.Contracts.Select(c => c.PersonId).Where`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`o.Contracts.Select(c => c.PersonId).Where(id => !OwnedClubs.Humans(d).Contains(id)              && CareerEngine.Person(d, id)?.ClubId == o.ClubId && !o.Coaches.Contains(id) && (!academy || o.Reserves.Contains(id) || o.Youth.Contains(id))).Distinct().ToList()`；返回值紧邻使用处：`ReturnStatementSyntax: return o.Contracts.Select(c => c.PersonId).Where(id => !OwnedClubs.Humans(d).Contains(id)              && CareerEngine.Person(d, id)?.ClubId == o.ClubId && !o.Coaches.Contains(id) && (!academy || o.Reserves.Contains(id) || o.Youth.Contains(id))).Distinct().ToList();`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`o.Contracts.Select(c => c.PersonId).Where(id => !OwnedClubs.Humans(d).Contains(id)              && CareerEngine.Person(d, id)?.ClubId == o.ClubId && !o.Coaches.Contains(id) && (!academy || o.Reserves.Contains(id) || o.Youth.Contains(id)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: o.Contracts.Select(c => c.PersonId).Where(id => !OwnedClubs.Humans(d).Contains(id)              && CareerEngine.Person(d, id)?.ClubId == o.ClubId && !o.Coaches.Contains(id) && (!academy || o.Reserves.Contains(id) || o.Youth.Contains(id))).Distinct`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`o.Coaches.Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !o.Coaches.Contains(id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`o.Reserves.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: !academy || o.Reserves.Contains(id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`o.Youth.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: !academy || o.Reserves.Contains(id) || o.Youth.Contains(id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`OwnedClubs.Humans(d).Contains(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !OwnedClubs.Humans(d).Contains(id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-359a3dbeb02e"></a>

## `NationalSpire.ClubPrograms.CanOffer(NationalSpire.CareerData, string) — public static bool CanOffer(CareerData d, string title)`

来源：源码第 607 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Offer(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-06bdec919490)；[`NationalSpire.ClubPrograms.Error(NationalSpire.CareerData, NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-160ff8c6cde3)

**调用：** [`NationalSpire.CareerTraining.Multiplayer(NationalSpire.CareerData)`](CareerTraining.cs.md#symbol-69fbc353877e)；[`NationalSpire.ClubPrograms.Get(string)`](OwnedClubs.cs.md#symbol-72f89f54f561)；[`NationalSpire.ClubPrograms.Targets(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-30a147299dc6)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerTraining.Multiplayer(NationalSpire.CareerData)`；`NationalSpire.ClubPrograms.Get(string)`；`NationalSpire.ClubPrograms.Targets(NationalSpire.CareerData, string)`；`NationalSpire.ClubPrograms.Terms.Defense`；`NationalSpire.ClubPrograms.Terms.Temporary`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerTraining.Multiplayer(NationalSpire.CareerData)`；输入表达式：`CareerTraining.Multiplayer(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerTraining.Multiplayer(d) && (terms.Temporary > 0 || terms.Defense > 0)`
- `NationalSpire.ClubPrograms.Get(string)`；输入表达式：`Get(title)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Get(title)`
- `NationalSpire.ClubPrograms.Targets(NationalSpire.CareerData, string)`；输入表达式：`Targets(d, title)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Targets(d, title).Count`

**赋值（含属性/字段和局部值）：**


<a id="symbol-160ff8c6cde3"></a>

## `NationalSpire.ClubPrograms.Error(NationalSpire.CareerData, NationalSpire.LifeActivity) — public static string? Error(CareerData d, LifeActivity a)`

来源：源码第 614 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Accept(NationalSpire.CareerData, string, string)`](CareerLife.cs.md#symbol-cce5ea9d3250)

**调用：** [`NationalSpire.ClubPrograms.CanOffer(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-359a3dbeb02e)；[`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-871ad0e2a2c9)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.ClubPrograms.CanOffer(NationalSpire.CareerData, string)`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.LifeActivity.ClubId`；`NationalSpire.LifeActivity.Title`；`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；`NationalSpire.OwnedClubState.ClubId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ClubPrograms.CanOffer(NationalSpire.CareerData, string)`；输入表达式：`CanOffer(d, a.Title)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CanOffer(d, a.Title)`
- `NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.CanOperate(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !OwnedClubs.CanOperate(d)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-48edcdfd89d0"></a>

## `NationalSpire.ClubPrograms.Snapshot(NationalSpire.CareerData, NationalSpire.LifeActivity) — public static void Snapshot(CareerData d, LifeActivity a)`

来源：源码第 620 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Accept(NationalSpire.CareerData, string, string)`](CareerLife.cs.md#symbol-cce5ea9d3250)

**调用：** [`NationalSpire.ClubPrograms.Effective(NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-b76b0b763ab3)；[`NationalSpire.ClubPrograms.Targets(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-30a147299dc6)

**字段、属性、事件及方法组引用：** `NationalSpire.ClubPrograms.Effective(NationalSpire.LifeActivity)`；`NationalSpire.ClubPrograms.Targets(NationalSpire.CareerData, string)`；`NationalSpire.ClubPrograms.Terms.Defense`；`NationalSpire.ClubPrograms.Terms.Temporary`；`NationalSpire.ClubPrograms.Terms.Weekly`；`NationalSpire.LifeActivity.DefensePoints`；`NationalSpire.LifeActivity.FinishDay`；`NationalSpire.LifeActivity.StartedDay`；`NationalSpire.LifeActivity.TemporaryPoints`；`NationalSpire.LifeActivity.Title`；`NationalSpire.LifeActivity.TrainingEnd`；`NationalSpire.LifeActivity.TrainingKind`；`NationalSpire.LifeActivity.TrainingStart`；`NationalSpire.LifeActivity.TrainingTargets`；`NationalSpire.LifeActivity.WeeklyGrowthPoints`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ClubPrograms.Effective(NationalSpire.LifeActivity)`；输入表达式：`Effective(a)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Effective(a)`
- `NationalSpire.ClubPrograms.Targets(NationalSpire.CareerData, string)`；输入表达式：`Targets(d, a.Title)`；返回值紧邻使用处：`AssignmentExpressionSyntax: a.TrainingTargets = Targets(d, a.Title)`

**赋值（含属性/字段和局部值）：**

- `a.DefensePoints` = `t.Defense`
- `a.FinishDay` = `a.TrainingEnd + 1`
- `a.TemporaryPoints` = `t.Temporary`
- `a.TrainingEnd` = `a.StartedDay + 28`
- `a.TrainingKind` = `"club"`
- `a.TrainingStart` = `a.StartedDay + 1`
- `a.TrainingTargets` = `Targets(d, a.Title)`
- `a.WeeklyGrowthPoints` = `t.Weekly`

<a id="symbol-b01f1c3252f6"></a>

## `NationalSpire.ClubPrograms.Advance(NationalSpire.CareerData, NationalSpire.LifeActivity) — public static void Advance(CareerData d, LifeActivity a)`

来源：源码第 627 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Advance(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-62ec6434f115)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerTraining.Advance(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerTraining.cs.md#symbol-b1b089f2949d)；[`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-871ad0e2a2c9)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerTraining.Advance(NationalSpire.CareerData, NationalSpire.LifeActivity)`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.LifeActivity.ClubId`；`NationalSpire.LifeActivity.TrainingTargets`；`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubState.Contracts`；`NationalSpire.OwnedPlayerContract.PersonId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CareerEngine.Person(d, id)?.ClubId`
- `NationalSpire.CareerTraining.Advance(NationalSpire.CareerData, NationalSpire.LifeActivity)`；输入表达式：`CareerTraining.Advance(d, a)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerTraining.Advance(d, a);`
- `NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.CanOperate(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !OwnedClubs.CanOperate(d)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.OwnedClub.Contracts.Any(c => c.PersonId == id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.Esports.OwnedClub.Contracts.Any(c => c.PersonId == id)`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`a.TrainingTargets.RemoveAll(id => CareerEngine.Person(d, id)?.ClubId != a.ClubId              || !d.Esports.OwnedClub.Contracts.Any(c => c.PersonId == id))`；返回值紧邻使用处：`ExpressionStatementSyntax: a.TrainingTargets.RemoveAll(id => CareerEngine.Person(d, id)?.ClubId != a.ClubId              || !d.Esports.OwnedClub.Contracts.Any(c => c.PersonId == id));`

**赋值（含属性/字段和局部值）：**


<a id="symbol-35a5fe8029e5"></a>

## `NationalSpire.ClubPrograms.Description(NationalSpire.CareerData, NationalSpire.LifeActivity) — public static string Description(CareerData d, LifeActivity a)`

来源：源码第 634 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Expected(NationalSpire.CareerData, NationalSpire.LifeActivity)`](CareerLife.cs.md#symbol-44d430d90686)

**调用：** [`NationalSpire.CareerTraining.ExpectedGrowth(NationalSpire.CareerData, NationalSpire.LifeActivity, string, int)`](CareerTraining.cs.md#symbol-19da8bbb9563)；[`NationalSpire.ClubPrograms.Effective(NationalSpire.LifeActivity)`](OwnedClubs.cs.md#symbol-b76b0b763ab3)；[`NationalSpire.ClubPrograms.Targets(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-30a147299dc6)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<int>.Max()`；`System.Collections.Generic.IEnumerable<int>.Min()`；`System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerTraining.ExpectedGrowth(NationalSpire.CareerData, NationalSpire.LifeActivity, string, int)`；`NationalSpire.ClubPrograms.Effective(NationalSpire.LifeActivity)`；`NationalSpire.ClubPrograms.Targets(NationalSpire.CareerData, string)`；`NationalSpire.ClubPrograms.Terms.Academy`；`NationalSpire.ClubPrograms.Terms.Defense`；`NationalSpire.ClubPrograms.Terms.Temporary`；`NationalSpire.ClubPrograms.Terms.Weekly`；`NationalSpire.LifeActivity.DefensePoints`；`NationalSpire.LifeActivity.TemporaryPoints`；`NationalSpire.LifeActivity.Title`；`NationalSpire.LifeActivity.TrainingGained`；`NationalSpire.LifeActivity.TrainingStart`；`NationalSpire.LifeActivity.TrainingTargets`；`NationalSpire.LifeActivity.WeeklyGrowthPoints`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerTraining.ExpectedGrowth(NationalSpire.CareerData, NationalSpire.LifeActivity, string, int)`；输入表达式：`CareerTraining.ExpectedGrowth(d, a, id, weekly)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerTraining.ExpectedGrowth(d, a, id, weekly) + a.TrainingGained.GetValueOrDefault(id)`
- `NationalSpire.ClubPrograms.Effective(NationalSpire.LifeActivity)`；输入表达式：`Effective(a)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Effective(a)`
- `NationalSpire.ClubPrograms.Targets(NationalSpire.CareerData, string)`；输入表达式：`Targets(d, a.Title)`；返回值紧邻使用处：`ConditionalExpressionSyntax: a.TrainingStart > 0 ? a.TrainingTargets : Targets(d, a.Title)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", effects)`；返回值紧邻使用处：`BinaryExpressionSyntax: scope + "\n" + string.Join("\n", effects)`
- `System.Collections.Generic.IEnumerable<int>.Max()`；输入表达式：`gains.Max()`；返回值紧邻使用处：`BinaryExpressionSyntax: gains.Max() / 100.0`
- `System.Collections.Generic.IEnumerable<int>.Max()`；输入表达式：`gains.Max()`；返回值紧邻使用处：`BinaryExpressionSyntax: gains.Max() == 0`
- `System.Collections.Generic.IEnumerable<int>.Max()`；输入表达式：`gains.Max()`；返回值紧邻使用处：`BinaryExpressionSyntax: gains.Min() == gains.Max()`
- `System.Collections.Generic.IEnumerable<int>.Min()`；输入表达式：`gains.Min()`；返回值紧邻使用处：`BinaryExpressionSyntax: gains.Min() / 100.0`
- `System.Collections.Generic.IEnumerable<int>.Min()`；输入表达式：`gains.Min()`；返回值紧邻使用处：`BinaryExpressionSyntax: gains.Min() == gains.Max()`
- `System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>()`；输入表达式：`ids.Select(id => CareerTraining.ExpectedGrowth(d, a, id, weekly) + a.TrainingGained.GetValueOrDefault(id)).DefaultIfEmpty()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ids.Select(id => CareerTraining.ExpectedGrowth(d, a, id, weekly) + a.TrainingGained.GetValueOrDefault(id)).DefaultIfEmpty().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`ids.Select(id => CareerTraining.ExpectedGrowth(d, a, id, weekly) + a.TrainingGained.GetValueOrDefault(id))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ids.Select(id => CareerTraining.ExpectedGrowth(d, a, id, weekly) + a.TrainingGained.GetValueOrDefault(id)).DefaultIfEmpty`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`ids.Select(id => CareerTraining.ExpectedGrowth(d, a, id, weekly) + a.TrainingGained.GetValueOrDefault(id)).DefaultIfEmpty().ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ids.Select(id => CareerTraining.ExpectedGrowth(d, a, id, weekly) + a.TrainingGained.GetValueOrDefault(id)).DefaultIfEmpty().ToList()`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`a.TrainingGained.GetValueOrDefault(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerTraining.ExpectedGrowth(d, a, id, weekly) + a.TrainingGained.GetValueOrDefault(id)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`effects.Add($"每人预计永久提升 {value}，分四周结算")`；返回值紧邻使用处：`ExpressionStatementSyntax: effects.Add($"每人预计永久提升 {value}，分四周结算");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`effects.Add($"通关率 +{temporary / 100.0:0.##}%，持续 28 天")`；返回值紧邻使用处：`ExpressionStatementSyntax: effects.Add($"通关率 +{temporary / 100.0:0.##}%，持续 28 天");`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`effects.Add($"未通关时，首幕出局率最多降低 {defense / 100.0:0.##}%，持续 28 天")`；返回值紧邻使用处：`ExpressionStatementSyntax: effects.Add($"未通关时，首幕出局率最多降低 {defense / 100.0:0.##}%，持续 28 天");`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<string>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<string>()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-53ba79900734"></a>

## `NationalSpire.ClubPrograms.Details(NationalSpire.CareerData, NationalSpire.LifeActivity) — public static string Details(CareerData d, LifeActivity a)`

来源：源码第 653 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ActivityCard(NationalSpire.CareerData, NationalSpire.LifeActivity)`](LifeScreen.cs.md#symbol-5b3e0aaad277)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.ClubPrograms.Targets(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-30a147299dc6)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.ClubPrograms.Targets(NationalSpire.CareerData, string)`；`NationalSpire.LifeActivity.Title`；`NationalSpire.LifeActivity.TrainingStart`；`NationalSpire.LifeActivity.TrainingTargets`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(d, id)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => CareerEngine.DisplayName(d, id)`
- `NationalSpire.ClubPrograms.Targets(NationalSpire.CareerData, string)`；输入表达式：`Targets(d, a.Title)`；返回值紧邻使用处：`ConditionalExpressionSyntax: a.TrainingStart > 0 ? a.TrainingTargets : Targets(d, a.Title)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("、", (a.TrainingStart > 0 ? a.TrainingTargets : Targets(d, a.Title)).Select(id => CareerEngine.DisplayName(d, id)))`；返回值紧邻使用处：`BinaryExpressionSyntax: "次日起生效，持续四周。临时效果取最高值，不叠加。永久成长随累计提升和本季投入逐渐减慢，小数进度保留，各进阶均生效。\n"          + string.Join("、", (a.TrainingStart > 0 ? a.TrainingTargets : Targets(d, a.Title)).Select(id => CareerEngine.DisplayName(d, id)))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`(a.TrainingStart > 0 ? a.TrainingTargets : Targets(d, a.Title)).Select(id => CareerEngine.DisplayName(d, id))`；返回值紧邻使用处：`ArgumentSyntax: (a.TrainingStart > 0 ? a.TrainingTargets : Targets(d, a.Title)).Select(id => CareerEngine.DisplayName(d, id))`

**赋值（含属性/字段和局部值）：**
