# ClubCoaching.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`CC763CFAD9A74F38BC012016BA4A6D1D4C61A954B3B649E1B950DE7BC98486AB`。来源：[源码](../../ClubCoaching.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CoachAppointment`、`NationalSpire.CoachTrainingPlan`、`NationalSpire.ClubCoaching`。

字段、事件及初始值（源码原样）：

```csharp
public const string Protocol = """
本轮附件中存在训练计划时，根据具体内容和情况决定是否接受；接受须输出 [Training: 接受, Id: 12]，Id 填对应训练附件的编号；口头答应不会实际生效。接受已有训练的新安排会刷新期限，不叠加训练效果或时长。如果没有训练计划附件但是玩家有安排训练的意向，则先在正文中商谈训练内容，收到对应附件后再输出接受训练标记。
""";
```

<a id="symbol-0d33a211f437"></a>

## `NationalSpire.CoachAppointment.PersonId — public string PersonId`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ce6ca6aa3fe7"></a>

## `NationalSpire.CoachAppointment.Replacement — public string Replacement`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7826e766c0ef"></a>

## `NationalSpire.CoachAppointment.Season — public int Season`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3395605d2c14"></a>

## `NationalSpire.CoachTrainingPlan.CoachId — public string CoachId`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3bcbc2ed34a7"></a>

## `NationalSpire.CoachTrainingPlan.Id — public string Id`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0327d9cf8cd0"></a>

## `NationalSpire.CoachTrainingPlan.PersonId — public string PersonId`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-aaba61a7ec19"></a>

## `NationalSpire.CoachTrainingPlan.TurnId — public string TurnId`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e4b318970d2b"></a>

## `NationalSpire.CoachTrainingPlan.ClubId — public string ClubId`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-bc30699cbe7b"></a>

## `NationalSpire.CoachTrainingPlan.Content — public string Content`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-81acd44254f1"></a>

## `NationalSpire.CoachTrainingPlan.StartDay — public int StartDay`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2c4d11c4eb92"></a>

## `NationalSpire.CoachTrainingPlan.Weeks — public int Weeks`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-67dd8bb8b6e8"></a>

## `NationalSpire.CoachTrainingPlan.PaidWeeks — public int PaidWeeks`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-639e25aee199"></a>

## `NationalSpire.CoachTrainingPlan.Gained — public double Gained`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e5540b3e192f"></a>

## `NationalSpire.CoachTrainingPlan.State — public string State`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a2ccd8d994ca"></a>

## `NationalSpire.CoachTrainingPlan.EndDay — public int EndDay`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CoachTrainingPlan.StartDay`；`NationalSpire.CoachTrainingPlan.Weeks`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e30d7b812432"></a>

## `NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData) — public static bool PlayerFeatures(CareerData d)`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CoachManagement(NationalSpire.CareerData)`](CoachScreen.cs.md#symbol-7f703533cff4)；[`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`](ProfileScreen.cs.md#symbol-ce70d1ef24b8)；[`NationalSpire.ClubCoaching.PlayerCoach(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-26fb5cc468c4)；[`NationalSpire.ClubCoaching.PlayerPositionError(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-7f8dbf0cc1e3)；[`NationalSpire.ClubCoaching.PlayerReserve(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-c5c2fb20bef5)；[`NationalSpire.ClubCoaching.SeasonStart(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-c152f62d57e4)；[`NationalSpire.ClubCoaching.SetPlayerCoach(NationalSpire.CareerData, bool)`](ClubCoaching.cs.md#symbol-fa4109028289)；[`NationalSpire.CoachLineups.Candidates(NationalSpire.CareerData)`](CoachLineups.cs.md#symbol-17ae59ab26cf)；[`NationalSpire.CoachLineups.MemberError(NationalSpire.CareerData, string, string, string, string?, string?)`](CoachLineups.cs.md#symbol-ee32acfaf806)；[`NationalSpire.CoachLineups.Person(NationalSpire.CareerData, string)`](CoachLineups.cs.md#symbol-559e961ef669)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?, bool)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.PrivatePublicContext.Profiles(NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?, bool)`](PrivatePublicContext.cs.md#symbol-3d184de3074e)

**调用：** [`NationalSpire.CareerTraining.Multiplayer(NationalSpire.CareerData)`](CareerTraining.cs.md#symbol-69fbc353877e)；[`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-871ad0e2a2c9)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerTraining.Multiplayer(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerTraining.Multiplayer(NationalSpire.CareerData)`；输入表达式：`CareerTraining.Multiplayer(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CareerTraining.Multiplayer(d)`
- `NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.CanOperate(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: OwnedClubs.CanOperate(d) && !CareerTraining.Multiplayer(d)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c5c2fb20bef5"></a>

## `NationalSpire.ClubCoaching.PlayerReserve(NationalSpire.CareerData) — public static bool PlayerReserve(CareerData d)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`](ProfileScreen.cs.md#symbol-ce70d1ef24b8)；[`NationalSpire.CircuitWorld.EnrollLeague(NationalSpire.CareerData, NationalSpire.WorldCompetition)`](CircuitWorld.cs.md#symbol-8744d18514f7)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?, bool)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.OwnedClubs.RequiredAiStarters(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-462ebb119278)；[`NationalSpire.PrivatePublicContext.Profiles(NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?, bool)`](PrivatePublicContext.cs.md#symbol-3d184de3074e)

**调用：** [`NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-e30d7b812432)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubState.PlayerReserve`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`；输入表达式：`PlayerFeatures(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: PlayerFeatures(d) && d.Esports.OwnedClub!.PlayerReserve`

**赋值（含属性/字段和局部值）：**


<a id="symbol-26fb5cc468c4"></a>

## `NationalSpire.ClubCoaching.PlayerCoach(NationalSpire.CareerData) — public static bool PlayerCoach(CareerData d)`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.GroupTrainingPicker()`](GroupChatDialogs.cs.md#symbol-1e2068d8bf79)；[`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)；[`NationalSpire.CareerScreen.PlayerProfile(NationalSpire.CareerData)`](ProfileScreen.cs.md#symbol-ce70d1ef24b8)；[`NationalSpire.CareerScreen.PrivateActions()`](PrivateMessageScreen.cs.md#symbol-6e8c11ead905)；[`NationalSpire.ClubCoaching.Advance(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-52a54f3b0a18)；[`NationalSpire.ClubCoaching.TrainingError(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](ClubCoaching.cs.md#symbol-061ee769bb78)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?, bool)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.PrivatePublicContext.Profiles(NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?, bool)`](PrivatePublicContext.cs.md#symbol-3d184de3074e)

**调用：** [`NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-e30d7b812432)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubState.PlayerCoach`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`；输入表达式：`PlayerFeatures(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: PlayerFeatures(d) && d.Esports.OwnedClub!.PlayerCoach`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8b4ec414486e"></a>

## `NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson) — public static bool IsCoach(CareerPerson p)`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenPortraitDesigner(NationalSpire.CareerData, string)`](PortraitDesignScreen.cs.md#symbol-3bb5119a73ca)；[`NationalSpire.CareerScreen.PlayerBanner(NationalSpire.CareerData, string)`](BroadcastVisuals.cs.md#symbol-936e32073293)；[`NationalSpire.CareerScreen.PrivateIdentity(NationalSpire.CareerData, string, bool)`](PrivateMemoryScreen.cs.md#symbol-65caddca194f)；[`NationalSpire.CareerScreen.Profiles(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-70740adc3b48)；[`NationalSpire.CareerTraining.Grow(NationalSpire.CareerData, string, int, int)`](CareerTraining.cs.md#symbol-8d0cf5a9811c)；[`NationalSpire.CircuitWorld.CooperativeRoster(NationalSpire.CareerData, NationalSpire.WorldCompetition?, string, string)`](CircuitWorld.cs.md#symbol-4d6f1758c06b)；[`NationalSpire.CircuitWorld.EnsureOpenEvents(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-73f52bc89477)；[`NationalSpire.ClubCoaching.Factor(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-d1aa71b14a7b)；[`NationalSpire.ClubCoaching.Replacements(NationalSpire.CareerData, string)`](ClubCoaching.cs.md#symbol-a26fdb727aca)；[`NationalSpire.ClubCoaching.TrainingMember(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-190f8b335415)；[`NationalSpire.OwnedClubs.GroupPractice(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<string>, int, int?)`](OwnedClubs.cs.md#symbol-64763de09f26)；[`NationalSpire.PrivatePublicContext.Profiles(NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?, bool)`](PrivatePublicContext.cs.md#symbol-3d184de3074e)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.ClubPosition`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c0a761e9458d"></a>

## `NationalSpire.ClubCoaching.Factor(NationalSpire.CareerPerson) — public static double Factor(CareerPerson p)`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubPracticePreview(NationalSpire.CareerData, Godot.VBoxContainer, NationalSpire.ClubSigning, bool)`](OwnedClubScreen.cs.md#symbol-db042267110f)；[`NationalSpire.CareerScreen.OwnedClubPanel(NationalSpire.CareerData)`](OwnedClubScreen.cs.md#symbol-d7bcae181c6a)；[`NationalSpire.ClubCoaching.Factor(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-d1aa71b14a7b)；[`NationalSpire.PrivatePublicContext.Profiles(NationalSpire.CareerData, NationalSpire.CareerPerson, System.Collections.Generic.List<(int Start, int Length, string Group)>?, bool)`](PrivatePublicContext.cs.md#symbol-3d184de3074e)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerPerson.MaxAscension`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d1aa71b14a7b"></a>

## `NationalSpire.ClubCoaching.Factor(NationalSpire.CareerData) — public static double Factor(CareerData d)`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClubPracticePreview(NationalSpire.CareerData, Godot.VBoxContainer, NationalSpire.ClubSigning, bool)`](OwnedClubScreen.cs.md#symbol-db042267110f)；[`NationalSpire.CareerScreen.CoachManagement(NationalSpire.CareerData)`](CoachScreen.cs.md#symbol-7f703533cff4)；[`NationalSpire.OwnedClubs.PracticeBonus(NationalSpire.CareerData, string, int, int?)`](OwnedClubs.cs.md#symbol-5b2c48d0615a)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.ClubCoaching.Factor(NationalSpire.CareerPerson)`](ClubCoaching.cs.md#symbol-c0a761e9458d)；[`NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`](ClubCoaching.cs.md#symbol-8b4ec414486e)；`System.Collections.Generic.IEnumerable<double>.Max()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.People`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Id`；`NationalSpire.ClubCoaching.Factor(NationalSpire.CareerPerson)`；`NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubState.Coaches`；`NationalSpire.OwnedClubState.Contracts`；`NationalSpire.OwnedPlayerContract.PersonId`；`NationalSpire.OwnedPlayerContract.Position`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(d, id)!`
- `NationalSpire.ClubCoaching.Factor(NationalSpire.CareerPerson)`；输入表达式：`Factor(CareerEngine.Person(d, id)!)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: id => Factor(CareerEngine.Person(d, id)!)`
- `NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`；输入表达式：`IsCoach(p)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Id == id && p.ClubId == o.ClubId && IsCoach(p)`
- `System.Collections.Generic.IEnumerable<double>.Max()`；输入表达式：`o.Coaches.Where(id => d.People.Any(p => p.Id == id && p.ClubId == o.ClubId && IsCoach(p)) && o.Contracts.Any(c => c.PersonId == id && c.Position == "教练"))              .Select(id => Factor(CareerEngine.Person(d, id)!)).DefaultIfEmpty(1).Max()`；返回值紧邻使用处：`ConditionalExpressionSyntax: d.Esports.OwnedClub is { } o          ? o.Coaches.Where(id => d.People.Any(p => p.Id == id && p.ClubId == o.ClubId && IsCoach(p)) && o.Contracts.Any(c => c.PersonId == id && c.Position == "教练"))              .Select(id => Factor(CareerEngine.Person(d, id)!)).DefaultIfEmpty(1).Max() : 1`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Any(p => p.Id == id && p.ClubId == o.ClubId && IsCoach(p))`；返回值紧邻使用处：`BinaryExpressionSyntax: d.People.Any(p => p.Id == id && p.ClubId == o.ClubId && IsCoach(p)) && o.Contracts.Any(c => c.PersonId == id && c.Position == "教练")`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`o.Contracts.Any(c => c.PersonId == id && c.Position == "教练")`；返回值紧邻使用处：`BinaryExpressionSyntax: d.People.Any(p => p.Id == id && p.ClubId == o.ClubId && IsCoach(p)) && o.Contracts.Any(c => c.PersonId == id && c.Position == "教练")`
- `System.Collections.Generic.IEnumerable<TSource>.DefaultIfEmpty<TSource>(TSource)`；输入表达式：`o.Coaches.Where(id => d.People.Any(p => p.Id == id && p.ClubId == o.ClubId && IsCoach(p)) && o.Contracts.Any(c => c.PersonId == id && c.Position == "教练"))              .Select(id => Factor(CareerEngine.Person(d, id)!)).DefaultIfEmpty(1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: o.Coaches.Where(id => d.People.Any(p => p.Id == id && p.ClubId == o.ClubId && IsCoach(p)) && o.Contracts.Any(c => c.PersonId == id && c.Position == "教练"))              .Select(id => Factor(CareerEngine.Person(d, id)!)).DefaultIfEmpty(1).Max`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`o.Coaches.Where(id => d.People.Any(p => p.Id == id && p.ClubId == o.ClubId && IsCoach(p)) && o.Contracts.Any(c => c.PersonId == id && c.Position == "教练"))              .Select(id => Factor(CareerEngine.Person(d, id)!))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: o.Coaches.Where(id => d.People.Any(p => p.Id == id && p.ClubId == o.ClubId && IsCoach(p)) && o.Contracts.Any(c => c.PersonId == id && c.Position == "教练"))              .Select(id => Factor(CareerEngine.Person(d, id)!)).DefaultIfEmpty`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`o.Coaches.Where(id => d.People.Any(p => p.Id == id && p.ClubId == o.ClubId && IsCoach(p)) && o.Contracts.Any(c => c.PersonId == id && c.Position == "教练"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: o.Coaches.Where(id => d.People.Any(p => p.Id == id && p.ClubId == o.ClubId && IsCoach(p)) && o.Contracts.Any(c => c.PersonId == id && c.Position == "教练"))              .Select`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4f8141b24cff"></a>

## `NationalSpire.ClubCoaching.Scheduled(NationalSpire.CareerData, string) — public static bool Scheduled(CareerData d, string id)`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CoachAppointmentDialog(NationalSpire.CareerData, string)`](CoachScreen.cs.md#symbol-e2df497af307)；[`NationalSpire.ClubCoaching.Appoint(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-15fbcfa0d281)

**调用：** [`NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`](PrivateAppointments.cs.md#symbol-32f6566791d2)；[`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-12bdfe5d4265)；[`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-ee7b01d76b23)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerMatch.Day`；`NationalSpire.CareerMatch.OpponentId`；`NationalSpire.CareerMatch.Status`；`NationalSpire.EsportsCareer.Competitions`；`NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`；`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；`NationalSpire.WorldCompetition.Cooperative`；`NationalSpire.WorldCompetition.Fixtures`；`NationalSpire.WorldCompetition.Rosters`；`NationalSpire.WorldCompetition.Season`；`NationalSpire.WorldFixture.AwayId`；`NationalSpire.WorldFixture.AwayTeam`；`NationalSpire.WorldFixture.Finished`；`NationalSpire.WorldFixture.HomeId`；`NationalSpire.WorldFixture.HomeTeam`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateAppointments.IsPrivate(NationalSpire.CareerMatch)`；输入表达式：`PrivateAppointments.IsPrivate(m)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateAppointments.IsPrivate(m)`
- `NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Length(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.Start(d) + SeasonCalendar.Length(d)`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: m.Day > SeasonCalendar.Start(d)`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`SeasonCalendar.Start(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: SeasonCalendar.Start(d) + SeasonCalendar.Length(d)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`c.Rosters.TryGetValue(f.AwayTeam, out var away)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Rosters.TryGetValue(f.AwayTeam, out var away) && away.Contains(id)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`c.Rosters.TryGetValue(f.HomeTeam, out var home)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Rosters.TryGetValue(f.HomeTeam, out var home) && home.Contains(id)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Fixtures.Any(f => !f.Finished && (f.HomeId == id || f.AwayId == id              || c.Cooperative && ((c.Rosters.TryGetValue(f.HomeTeam, out var home) && home.Contains(id))                  || (c.Rosters.TryGetValue(f.AwayTeam, out var away) && away.Contains(id)))))`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Season == d.Season          && c.Fixtures.Any(f => !f.Finished && (f.HomeId == id || f.AwayId == id              || c.Cooperative && ((c.Rosters.TryGetValue(f.HomeTeam, out var home) && home.Contains(id))                  || (c.Rosters.TryGetValue(f.AwayTeam, out var away) && away.Contains(id)))))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.Competitions.Any(c => c.Season == d.Season          && c.Fixtures.Any(f => !f.Finished && (f.HomeId == id || f.AwayId == id              || c.Cooperative && ((c.Rosters.TryGetValue(f.HomeTeam, out var home) && home.Contains(id))                  || (c.Rosters.TryGetValue(f.AwayTeam, out var away) && away.Contains(id))))))`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Matches.Any(m => m.Status == "待赛" && m.OpponentId == id          && !PrivateAppointments.IsPrivate(m) && m.Day > SeasonCalendar.Start(d) && m.Day <= SeasonCalendar.Start(d) + SeasonCalendar.Length(d))          || d.Esports.Competitions.Any(c => c.Season == d.Season          && c.Fixtures.Any(f => !f.Finished && (f.HomeId == id || f.AwayId == id              || c.Cooperative && ((c.Rosters.TryGetValue(f.HomeTeam, out var home) && home.Contains(id))                  || (c.Rosters.TryGetValue(f.AwayTeam, out var away) && away.Contains(id))))))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Matches.Any(m => m.Status == "待赛" && m.OpponentId == id          && !PrivateAppointments.IsPrivate(m) && m.Day > SeasonCalendar.Start(d) && m.Day <= SeasonCalendar.Start(d) + SeasonCalendar.Length(d))`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Matches.Any(m => m.Status == "待赛" && m.OpponentId == id          && !PrivateAppointments.IsPrivate(m) && m.Day > SeasonCalendar.Start(d) && m.Day <= SeasonCalendar.Start(d) + SeasonCalendar.Length(d))          || d.Esports.Competitions.Any(c => c.Season == d.Season          && c.Fixtures.Any(f => !f.Finished && (f.HomeId == id || f.AwayId == id              || c.Cooperative && ((c.Rosters.TryGetValue(f.HomeTeam, out var home) && home.Contains(id))                  || (c.Rosters.TryGetValue(f.AwayTeam, out var away) && away.Contains(id))))))`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`away.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Rosters.TryGetValue(f.AwayTeam, out var away) && away.Contains(id)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`home.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: c.Rosters.TryGetValue(f.HomeTeam, out var home) && home.Contains(id)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a26fdb727aca"></a>

## `NationalSpire.ClubCoaching.Replacements(NationalSpire.CareerData, string) — public static List<string> Replacements(CareerData d, string exclude = "")`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CoachAppointmentDialog(NationalSpire.CareerData, string)`](CoachScreen.cs.md#symbol-e2df497af307)；[`NationalSpire.CareerScreen.PlayerPositionDialog(NationalSpire.CareerData)`](CoachScreen.cs.md#symbol-5e31a957c01c)；[`NationalSpire.CharacterDeletion.StarterCandidates(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-3d7604fa699e)；[`NationalSpire.ClubCoaching.Appoint(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-15fbcfa0d281)；[`NationalSpire.ClubCoaching.PlayerPositionError(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-7f8dbf0cc1e3)；[`NationalSpire.ClubCoaching.SeasonStart(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-c152f62d57e4)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`](ClubCoaching.cs.md#symbol-8b4ec414486e)；[`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`](EsportsWorld.cs.md#symbol-c10dfd5a2e0e)；[`NationalSpire.OwnedClubs.ReservedStarter(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-4737fecea097)；[`NationalSpire.OwnedClubs.TransferReserved(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-fda6cea8331b)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.People`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerPerson.MaxAscension`；`NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`；`NationalSpire.CoachAppointment.PersonId`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；`NationalSpire.OwnedClubs.ReservedStarter(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubs.TransferReserved(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubState.CoachAppointments`；`NationalSpire.OwnedClubState.Contracts`；`NationalSpire.OwnedPlayerContract.PersonId`；`NationalSpire.OwnedPlayerContract.Position`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(d, id)!`
- `NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`；输入表达式：`IsCoach(p)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsCoach(p)`
- `NationalSpire.EsportsWorld.IsProfessional(NationalSpire.CareerPerson)`；输入表达式：`EsportsWorld.IsProfessional(CareerEngine.Person(d, id)!)`；返回值紧邻使用处：`BinaryExpressionSyntax: EsportsWorld.IsProfessional(CareerEngine.Person(d, id)!)                  || CareerEngine.Person(d, id)!.MaxAscension >= 8`
- `NationalSpire.OwnedClubs.ReservedStarter(NationalSpire.CareerData, string)`；输入表达式：`OwnedClubs.ReservedStarter(d, c.PersonId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !OwnedClubs.ReservedStarter(d, c.PersonId)`
- `NationalSpire.OwnedClubs.TransferReserved(NationalSpire.CareerData, string)`；输入表达式：`OwnedClubs.TransferReserved(d, c.PersonId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !OwnedClubs.TransferReserved(d, c.PersonId)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Any(p => p.Id == c.PersonId && p.ClubId == o.ClubId && !IsCoach(p))`；返回值紧邻使用处：`BinaryExpressionSyntax: c.PersonId != exclude && c.Position is "轮换" or "青训"              && !OwnedClubs.TransferReserved(d, c.PersonId) && !o.CoachAppointments.Any(a => a.PersonId == c.PersonId)              && !OwnedClubs.ReservedStarter(d, c.PersonId) && d.People.Any(p => p.Id == c.PersonId && p.ClubId == o.ClubId && !IsCoach(p))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`o.CoachAppointments.Any(a => a.PersonId == c.PersonId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !o.CoachAppointments.Any(a => a.PersonId == c.PersonId)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`o.Contracts.Where(c => c.PersonId != exclude && c.Position is "轮换" or "青训"              && !OwnedClubs.TransferReserved(d, c.PersonId) && !o.CoachAppointments.Any(a => a.PersonId == c.PersonId)              && !OwnedClubs.ReservedStarter(d, c.PersonId) && d.People.Any(p => p.Id == c.PersonId && p.ClubId == o.ClubId && !IsCoach(p)))              .Select(c => c.PersonId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: o.Contracts.Where(c => c.PersonId != exclude && c.Position is "轮换" or "青训"              && !OwnedClubs.TransferReserved(d, c.PersonId) && !o.CoachAppointments.Any(a => a.PersonId == c.PersonId)              && !OwnedClubs.ReservedStarter(d, c.PersonId) && d.People.Any(p => p.Id == c.PersonId && p.ClubId == o.ClubId && !IsCoach(p)))              .Select(c => c.PersonId).Where`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`o.Contracts.Where(c => c.PersonId != exclude && c.Position is "轮换" or "青训"              && !OwnedClubs.TransferReserved(d, c.PersonId) && !o.CoachAppointments.Any(a => a.PersonId == c.PersonId)              && !OwnedClubs.ReservedStarter(d, c.PersonId) && d.People.Any(p => p.Id == c.PersonId && p.ClubId == o.ClubId && !IsCoach(p)))              .Select(c => c.PersonId).Where(id => EsportsWorld.IsProfessional(CareerEngine.Person(d, id)!)                  || CareerEngine.Person(d, id)!.MaxAscension >= 8).ToList()`；返回值紧邻使用处：`ConditionalExpressionSyntax: d.Esports.OwnedClub is not { } o ? []          : o.Contracts.Where(c => c.PersonId != exclude && c.Position is "轮换" or "青训"              && !OwnedClubs.TransferReserved(d, c.PersonId) && !o.CoachAppointments.Any(a => a.PersonId == c.PersonId)              && !OwnedClubs.ReservedStarter(d, c.PersonId) && d.People.Any(p => p.Id == c.PersonId && p.ClubId == o.ClubId && !IsCoach(p)))              .Select(c => c.PersonId).Where(id => EsportsWorld.IsProfessional(CareerEngine.Person(d, id)!)                  || CareerEngine.Person(d, id)!.MaxAscension >= 8).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`o.Contracts.Where(c => c.PersonId != exclude && c.Position is "轮换" or "青训"              && !OwnedClubs.TransferReserved(d, c.PersonId) && !o.CoachAppointments.Any(a => a.PersonId == c.PersonId)              && !OwnedClubs.ReservedStarter(d, c.PersonId) && d.People.Any(p => p.Id == c.PersonId && p.ClubId == o.ClubId && !IsCoach(p)))              .Select(c => c.PersonId).Where(id => EsportsWorld.IsProfessional(CareerEngine.Person(d, id)!)                  || CareerEngine.Person(d, id)!.MaxAscension >= 8)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: o.Contracts.Where(c => c.PersonId != exclude && c.Position is "轮换" or "青训"              && !OwnedClubs.TransferReserved(d, c.PersonId) && !o.CoachAppointments.Any(a => a.PersonId == c.PersonId)              && !OwnedClubs.ReservedStarter(d, c.PersonId) && d.People.Any(p => p.Id == c.PersonId && p.ClubId == o.ClubId && !IsCoach(p)))              .Select(c => c.PersonId).Where(id => EsportsWorld.IsProfessional(CareerEngine.Person(d, id)!)                  || CareerEngine.Person(d, id)!.MaxAscension >= 8).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`o.Contracts.Where(c => c.PersonId != exclude && c.Position is "轮换" or "青训"              && !OwnedClubs.TransferReserved(d, c.PersonId) && !o.CoachAppointments.Any(a => a.PersonId == c.PersonId)              && !OwnedClubs.ReservedStarter(d, c.PersonId) && d.People.Any(p => p.Id == c.PersonId && p.ClubId == o.ClubId && !IsCoach(p)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: o.Contracts.Where(c => c.PersonId != exclude && c.Position is "轮换" or "青训"              && !OwnedClubs.TransferReserved(d, c.PersonId) && !o.CoachAppointments.Any(a => a.PersonId == c.PersonId)              && !OwnedClubs.ReservedStarter(d, c.PersonId) && d.People.Any(p => p.Id == c.PersonId && p.ClubId == o.ClubId && !IsCoach(p)))              .Select`

**赋值（含属性/字段和局部值）：**


<a id="symbol-15fbcfa0d281"></a>

## `NationalSpire.ClubCoaching.Appoint(NationalSpire.CareerData, string, string) — public static string? Appoint(CareerData d, string id, string replacement)`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.CoachAppointmentDialog(NationalSpire.CareerData, string)`](CoachScreen.cs.md#symbol-e2df497af307)；[`NationalSpire.OwnedClubs.Command(NationalSpire.CareerData, string, string, string)`](OwnedClubs.cs.md#symbol-12b38cf6ab67)

**调用：** [`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.CareerTraining.InvalidateForecast(NationalSpire.CareerData)`](CareerTraining.cs.md#symbol-5df788f3061f)；[`NationalSpire.ClubCoaching.Convert(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-4c320b941b55)；[`NationalSpire.ClubCoaching.Replacements(NationalSpire.CareerData, string)`](ClubCoaching.cs.md#symbol-a26fdb727aca)；[`NationalSpire.ClubCoaching.Scheduled(NationalSpire.CareerData, string)`](ClubCoaching.cs.md#symbol-4f8141b24cff)；[`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-871ad0e2a2c9)；[`NationalSpire.OwnedClubs.ReservedStarter(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-4737fecea097)；`NationalSpire.CoachAppointment.CoachAppointment()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Id`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.CareerTraining.InvalidateForecast(NationalSpire.CareerData)`；`NationalSpire.ClubCoaching.Convert(NationalSpire.CareerData, string, string)`；`NationalSpire.ClubCoaching.Replacements(NationalSpire.CareerData, string)`；`NationalSpire.ClubCoaching.Scheduled(NationalSpire.CareerData, string)`；`NationalSpire.CoachAppointment.PersonId`；`NationalSpire.CoachAppointment.Replacement`；`NationalSpire.CoachAppointment.Season`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.ReservedStarter(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubState.CoachAppointments`；`NationalSpire.OwnedClubState.Contracts`；`NationalSpire.OwnedClubState.Starters`；`NationalSpire.OwnedPlayerContract.GuaranteedStarter`；`NationalSpire.OwnedPlayerContract.PersonId`；`NationalSpire.OwnedPlayerContract.Position`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(d);`
- `NationalSpire.CareerTraining.InvalidateForecast(NationalSpire.CareerData)`；输入表达式：`CareerTraining.InvalidateForecast(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerTraining.InvalidateForecast(d);`
- `NationalSpire.ClubCoaching.Convert(NationalSpire.CareerData, string, string)`；输入表达式：`Convert(d, id, replacement)`；返回值紧邻使用处：`ExpressionStatementSyntax: Convert(d, id, replacement);`
- `NationalSpire.ClubCoaching.Replacements(NationalSpire.CareerData, string)`；输入表达式：`Replacements(d, id)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Replacements(d, id).Contains`
- `NationalSpire.ClubCoaching.Scheduled(NationalSpire.CareerData, string)`；输入表达式：`Scheduled(d, id)`；返回值紧邻使用处：`IfStatementSyntax: if (Scheduled(d, id))          {              o.CoachAppointments.RemoveAll(a => a.PersonId == id);              o.CoachAppointments.Add(new() { PersonId = id, Replacement = replacement, Season = d.Season + 1 });          }          else Convert(d, id, replacement);`
- `NationalSpire.CoachAppointment.CoachAppointment()`；输入表达式：`new() { PersonId = id, Replacement = replacement, Season = d.Season + 1 }`；返回值紧邻使用处：`ArgumentSyntax: new() { PersonId = id, Replacement = replacement, Season = d.Season + 1 }`
- `NationalSpire.OwnedClubs.CanOperate(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.CanOperate(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !OwnedClubs.CanOperate(d)`
- `NationalSpire.OwnedClubs.ReservedStarter(NationalSpire.CareerData, string)`；输入表达式：`OwnedClubs.ReservedStarter(d, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: contract.GuaranteedStarter || OwnedClubs.ReservedStarter(d, id)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Any(p => p.Id == id && p.ClubId == o.ClubId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !d.People.Any(p => p.Id == id && p.ClubId == o.ClubId)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`o.Contracts.FirstOrDefault(c => c.PersonId == id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = o.Contracts.FirstOrDefault(c => c.PersonId == id)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`o.CoachAppointments.Add(new() { PersonId = id, Replacement = replacement, Season = d.Season + 1 })`；返回值紧邻使用处：`ExpressionStatementSyntax: o.CoachAppointments.Add(new() { PersonId = id, Replacement = replacement, Season = d.Season + 1 });`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`o.Starters.Contains(id)`；返回值紧邻使用处：`BinaryExpressionSyntax: o.Starters.Contains(id) && !Replacements(d, id).Contains(replacement)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`Replacements(d, id).Contains(replacement)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Replacements(d, id).Contains(replacement)`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`o.CoachAppointments.RemoveAll(a => a.PersonId == id)`；返回值紧邻使用处：`ExpressionStatementSyntax: o.CoachAppointments.RemoveAll(a => a.PersonId == id);`

**赋值（含属性/字段和局部值）：**

- `PersonId` = `id`
- `Replacement` = `replacement`
- `Season` = `d.Season + 1`

<a id="symbol-4c320b941b55"></a>

## `NationalSpire.ClubCoaching.Convert(NationalSpire.CareerData, string, string) — private static void Convert(CareerData d, string id, string replacement)`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ClubCoaching.Appoint(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-15fbcfa0d281)；[`NationalSpire.ClubCoaching.SeasonStart(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-c152f62d57e4)

**调用：** [`NationalSpire.ClubCoaching.Move(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-62e6f802776a)；[`NationalSpire.ClubCoaching.StopTraining(NationalSpire.CareerData, string)`](ClubCoaching.cs.md#symbol-eacca79a5d86)；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.ClubCoaching.Move(NationalSpire.CareerData, string, string)`；`NationalSpire.ClubCoaching.StopTraining(NationalSpire.CareerData, string)`；`NationalSpire.CoachAppointment.PersonId`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubState.CoachAppointments`；`NationalSpire.OwnedClubState.Starters`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ClubCoaching.Move(NationalSpire.CareerData, string, string)`；输入表达式：`Move(d, id, "教练")`；返回值紧邻使用处：`ExpressionStatementSyntax: Move(d, id, "教练");`
- `NationalSpire.ClubCoaching.Move(NationalSpire.CareerData, string, string)`；输入表达式：`Move(d, replacement, "首发")`；返回值紧邻使用处：`ExpressionStatementSyntax: Move(d, replacement, "首发");`
- `NationalSpire.ClubCoaching.StopTraining(NationalSpire.CareerData, string)`；输入表达式：`StopTraining(d, id)`；返回值紧邻使用处：`ExpressionStatementSyntax: StopTraining(d, id);`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`o.Starters.Contains(id)`；返回值紧邻使用处：`IfStatementSyntax: if (o.Starters.Contains(id)) Move(d, replacement, "首发");`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`o.CoachAppointments.RemoveAll(a => a.PersonId == id)`；返回值紧邻使用处：`ExpressionStatementSyntax: o.CoachAppointments.RemoveAll(a => a.PersonId == id);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-62e6f802776a"></a>

## `NationalSpire.ClubCoaching.Move(NationalSpire.CareerData, string, string) — public static void Move(CareerData d, string id, string position)`

来源：源码第 75 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterDeletion.Promote(NationalSpire.CareerData, NationalSpire.CareerPerson, int)`](CharacterDeletion.cs.md#symbol-fdd2ed81eace)；[`NationalSpire.ClubCoaching.Convert(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-4c320b941b55)；[`NationalSpire.ClubCoaching.SeasonStart(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-c152f62d57e4)；[`NationalSpire.CoachLineups.SeasonStart(NationalSpire.CareerData)`](CoachLineups.cs.md#symbol-e6f5b5e37a12)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`](OwnedClubs.cs.md#symbol-11696548c7d5)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.Remove(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.ClubPosition`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`；`NationalSpire.OwnedClubState.Contracts`；`NationalSpire.OwnedPlayerContract.PersonId`；`NationalSpire.OwnedPlayerContract.Position`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: CareerEngine.Person(d, id) is { } p`
- `NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`；输入表达式：`OwnedClubs.PositionList(o, position)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: OwnedClubs.PositionList(o, position).Add`
- `NationalSpire.OwnedClubs.PositionList(NationalSpire.OwnedClubState, string)`；输入表达式：`OwnedClubs.PositionList(o, role)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: OwnedClubs.PositionList(o, role).Remove`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`o.Contracts.FirstOrDefault(c => c.PersonId == id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = o.Contracts.FirstOrDefault(c => c.PersonId == id)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`OwnedClubs.PositionList(o, position).Add(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: OwnedClubs.PositionList(o, position).Add(id);`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`OwnedClubs.PositionList(o, role).Remove(id)`；返回值紧邻使用处：`ExpressionStatementSyntax: OwnedClubs.PositionList(o, role).Remove(id);`

**赋值（含属性/字段和局部值）：**

- `c.Position` = `position`
- `p.ClubPosition` = `position`

<a id="symbol-fa4109028289"></a>

## `NationalSpire.ClubCoaching.SetPlayerCoach(NationalSpire.CareerData, bool) — public static string? SetPlayerCoach(CareerData d, bool value)`

来源：源码第 84 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.OwnedClubs.Command(NationalSpire.CareerData, string, string, string)`](OwnedClubs.cs.md#symbol-12b38cf6ab67)

**调用：** [`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-e30d7b812432)；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`；`NationalSpire.CoachTrainingPlan.CoachId`；`NationalSpire.CoachTrainingPlan.State`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubState.CoachTraining`；`NationalSpire.OwnedClubState.PlayerCoach`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(d);`
- `NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`；输入表达式：`PlayerFeatures(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PlayerFeatures(d)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.OwnedClub.CoachTraining.Where(p => p.State == "进行中" && p.CoachId.Length == 0)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var p in d.Esports.OwnedClub.CoachTraining.Where(p => p.State == "进行中" && p.CoachId.Length == 0)) p.State = "已取消";`

**赋值（含属性/字段和局部值）：**

- `d.Esports.OwnedClub!.PlayerCoach` = `value`
- `p.State` = `"已取消"`

<a id="symbol-7f8dbf0cc1e3"></a>

## `NationalSpire.ClubCoaching.PlayerPositionError(NationalSpire.CareerData, string, string) — public static string? PlayerPositionError(CareerData d, string position, string replacement)`

来源：源码第 91 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ClubCoaching.SetPlayerPosition(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-68aeffe9f915)；[`NationalSpire.CoachLineups.MemberError(NationalSpire.CareerData, string, string, string, string?, string?)`](CoachLineups.cs.md#symbol-ee32acfaf806)

**调用：** [`NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-e30d7b812432)；[`NationalSpire.ClubCoaching.Replacements(NationalSpire.CareerData, string)`](ClubCoaching.cs.md#symbol-a26fdb727aca)；[`NationalSpire.OwnedClubs.StarterReplacementError(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-e4678a15386e)；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`；`NationalSpire.ClubCoaching.Replacements(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubs.StarterReplacementError(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`；输入表达式：`PlayerFeatures(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PlayerFeatures(d)`
- `NationalSpire.ClubCoaching.Replacements(NationalSpire.CareerData, string)`；输入表达式：`Replacements(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Replacements(d).Contains`
- `NationalSpire.OwnedClubs.StarterReplacementError(NationalSpire.CareerData, string)`；输入表达式：`OwnedClubs.StarterReplacementError(d, replacement)`；返回值紧邻使用处：`IsPatternExpressionSyntax: OwnedClubs.StarterReplacementError(d, replacement) is { } e`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`Replacements(d).Contains(replacement)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Replacements(d).Contains(replacement)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d8f43426e219"></a>

## `NationalSpire.ClubCoaching.ClearPlayerPosition(NationalSpire.OwnedClubState) — internal static void ClearPlayerPosition(OwnedClubState o)`

来源：源码第 100 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ClubCoaching.SeasonStart(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-c152f62d57e4)；[`NationalSpire.ClubCoaching.SetPlayerPosition(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-68aeffe9f915)；[`NationalSpire.CoachLineups.Cancel(NationalSpire.CareerData, string, string)`](CoachLineups.cs.md#symbol-0318496e1ce1)；[`NationalSpire.CoachLineups.Deleted(NationalSpire.CareerData, string)`](CoachLineups.cs.md#symbol-3582186565b4)；[`NationalSpire.CoachLineups.Register(NationalSpire.CareerData, NationalSpire.CoachLineupRequest)`](CoachLineups.cs.md#symbol-cd01b73a8985)；[`NationalSpire.PrivateInteractionHistory.Restore(NationalSpire.CareerData, string, System.Text.Json.Nodes.JsonObject, bool)`](PrivateInteractionUndo.cs.md#symbol-dd91210e87c0)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.OwnedClubState.PlayerNextPosition`；`NationalSpire.OwnedClubState.PlayerPositionRequest`；`NationalSpire.OwnedClubState.PlayerPositionSeason`；`NationalSpire.OwnedClubState.PlayerReplacement`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `o.PlayerNextPosition` = `o.PlayerPositionRequest = ""`
- `o.PlayerPositionRequest` = `""`
- `o.PlayerPositionSeason` = `0`
- `o.PlayerReplacement` = `o.PlayerNextPosition = o.PlayerPositionRequest = ""`

<a id="symbol-68aeffe9f915"></a>

## `NationalSpire.ClubCoaching.SetPlayerPosition(NationalSpire.CareerData, string, string) — public static string? SetPlayerPosition(CareerData d, string position, string replacement)`

来源：源码第 102 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PlayerPositionDialog(NationalSpire.CareerData)`](CoachScreen.cs.md#symbol-5e31a957c01c)；[`NationalSpire.OwnedClubs.Command(NationalSpire.CareerData, string, string, string)`](OwnedClubs.cs.md#symbol-12b38cf6ab67)

**调用：** [`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`](CareerStore.cs.md#symbol-ad8f6e4706a1)；[`NationalSpire.ClubCoaching.ClearPlayerPosition(NationalSpire.OwnedClubState)`](ClubCoaching.cs.md#symbol-d8f43426e219)；[`NationalSpire.ClubCoaching.PlayerPositionError(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-7f8dbf0cc1e3)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；`NationalSpire.ClubCoaching.ClearPlayerPosition(NationalSpire.OwnedClubState)`；`NationalSpire.ClubCoaching.PlayerPositionError(NationalSpire.CareerData, string, string)`；`NationalSpire.CoachLineupRequest.ClubId`；`NationalSpire.CoachLineupRequest.First`；`NationalSpire.CoachLineupRequest.Id`；`NationalSpire.CoachLineupRequest.Second`；`NationalSpire.CoachLineupRequest.State`；`NationalSpire.EsportsCareer.LineupRequests`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubState.PlayerNextPosition`；`NationalSpire.OwnedClubState.PlayerPositionRequest`；`NationalSpire.OwnedClubState.PlayerPositionSeason`；`NationalSpire.OwnedClubState.PlayerReplacement`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerStore.Save(NationalSpire.CareerData?)`；输入表达式：`CareerStore.Save(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerStore.Save(d);`
- `NationalSpire.ClubCoaching.ClearPlayerPosition(NationalSpire.OwnedClubState)`；输入表达式：`ClearPlayerPosition(o)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClearPlayerPosition(o);`
- `NationalSpire.ClubCoaching.PlayerPositionError(NationalSpire.CareerData, string, string)`；输入表达式：`PlayerPositionError(d, position, replacement)`；返回值紧邻使用处：`IsPatternExpressionSyntax: PlayerPositionError(d, position, replacement) is { } error`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.LineupRequests.FirstOrDefault(r => r.Id == o.PlayerPositionRequest && r.State == "待生效")`；返回值紧邻使用处：`IsPatternExpressionSyntax: d.Esports.LineupRequests.FirstOrDefault(r => r.Id == o.PlayerPositionRequest && r.State == "待生效") is { } pending`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.LineupRequests.Where(r => r.State == "待生效" && r.ClubId == o.ClubId              && (r.First == "player" || r.Second == "player" || r.First == replacement || r.Second == replacement))`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var r in d.Esports.LineupRequests.Where(r => r.State == "待生效" && r.ClubId == o.ClubId              && (r.First == "player" || r.Second == "player" || r.First == replacement || r.Second == replacement))) r.State = "已替换";`

**赋值（含属性/字段和局部值）：**

- `o.PlayerNextPosition` = `position`
- `o.PlayerPositionRequest` = `""`
- `o.PlayerPositionSeason` = `d.Season + 1`
- `o.PlayerReplacement` = `replacement`
- `pending.State` = `"已取消"`
- `r.State` = `"已替换"`

<a id="symbol-c152f62d57e4"></a>

## `NationalSpire.ClubCoaching.SeasonStart(NationalSpire.CareerData) — public static void SeasonStart(CareerData d)`

来源：源码第 117 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CircuitWorld.StartSeason(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-8e4cfe18b2fe)

**调用：** [`NationalSpire.ClubCoaching.ClearPlayerPosition(NationalSpire.OwnedClubState)`](ClubCoaching.cs.md#symbol-d8f43426e219)；[`NationalSpire.ClubCoaching.Convert(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-4c320b941b55)；[`NationalSpire.ClubCoaching.Move(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-62e6f802776a)；[`NationalSpire.ClubCoaching.Notice(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-d31f98e532af)；[`NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-e30d7b812432)；[`NationalSpire.ClubCoaching.Replacements(NationalSpire.CareerData, string)`](ClubCoaching.cs.md#symbol-a26fdb727aca)；[`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-8c9ea9f33c3c)；[`NationalSpire.OwnedClubs.ReplaceableStarters(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-e1cbaaf9f832)；[`NationalSpire.OwnedClubs.ReservedStarter(NationalSpire.CareerData, string)`](OwnedClubs.cs.md#symbol-4737fecea097)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Contains(T)`；`System.Collections.Generic.List<T>.Remove(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.People`；`NationalSpire.CareerData.Season`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Id`；`NationalSpire.ClubCoaching.ClearPlayerPosition(NationalSpire.OwnedClubState)`；`NationalSpire.ClubCoaching.Convert(NationalSpire.CareerData, string, string)`；`NationalSpire.ClubCoaching.Move(NationalSpire.CareerData, string, string)`；`NationalSpire.ClubCoaching.Notice(NationalSpire.CareerData, string, string)`；`NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`；`NationalSpire.ClubCoaching.Replacements(NationalSpire.CareerData, string)`；`NationalSpire.CoachAppointment.PersonId`；`NationalSpire.CoachAppointment.Replacement`；`NationalSpire.CoachAppointment.Season`；`NationalSpire.CoachLineupRequest.Id`；`NationalSpire.CoachLineupRequest.Reason`；`NationalSpire.CoachLineupRequest.State`；`NationalSpire.EsportsCareer.LineupRequests`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.ReplaceableStarters(NationalSpire.CareerData)`；`NationalSpire.OwnedClubs.ReservedStarter(NationalSpire.CareerData, string)`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubState.CoachAppointments`；`NationalSpire.OwnedClubState.Contracts`；`NationalSpire.OwnedClubState.PlayerNextPosition`；`NationalSpire.OwnedClubState.PlayerPositionRequest`；`NationalSpire.OwnedClubState.PlayerPositionSeason`；`NationalSpire.OwnedClubState.PlayerReplacement`；`NationalSpire.OwnedClubState.PlayerReserve`；`NationalSpire.OwnedClubState.Starters`；`NationalSpire.OwnedPlayerContract.GuaranteedStarter`；`NationalSpire.OwnedPlayerContract.PersonId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ClubCoaching.ClearPlayerPosition(NationalSpire.OwnedClubState)`；输入表达式：`ClearPlayerPosition(o)`；返回值紧邻使用处：`ExpressionStatementSyntax: ClearPlayerPosition(o);`
- `NationalSpire.ClubCoaching.Convert(NationalSpire.CareerData, string, string)`；输入表达式：`Convert(d, a.PersonId, a.Replacement)`；返回值紧邻使用处：`ExpressionStatementSyntax: Convert(d, a.PersonId, a.Replacement);`
- `NationalSpire.ClubCoaching.Move(NationalSpire.CareerData, string, string)`；输入表达式：`Move(d, "player", reserve ? "轮换" : "首发")`；返回值紧邻使用处：`ExpressionStatementSyntax: Move(d, "player", reserve ? "轮换" : "首发");`
- `NationalSpire.ClubCoaching.Move(NationalSpire.CareerData, string, string)`；输入表达式：`Move(d, o.PlayerReplacement, reserve ? "首发" : "轮换")`；返回值紧邻使用处：`ExpressionStatementSyntax: Move(d, o.PlayerReplacement, reserve ? "首发" : "轮换");`
- `NationalSpire.ClubCoaching.Notice(NationalSpire.CareerData, string, string)`；输入表达式：`Notice(d, "教练调整未生效", "原席位保留，接替人选或合同条件已变化。")`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(d, "教练调整未生效", "原席位保留，接替人选或合同条件已变化。");`
- `NationalSpire.ClubCoaching.Notice(NationalSpire.CareerData, string, string)`；输入表达式：`Notice(d, "首发调整未生效", "原席位保留，接替人选或合同条件已变化。")`；返回值紧邻使用处：`ExpressionStatementSyntax: Notice(d, "首发调整未生效", "原席位保留，接替人选或合同条件已变化。");`
- `NationalSpire.ClubCoaching.PlayerFeatures(NationalSpire.CareerData)`；输入表达式：`PlayerFeatures(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: PlayerFeatures(d) && (reserve ? Replacements(d).Contains(o.PlayerReplacement)              : OwnedClubs.ReplaceableStarters(d).Contains(o.PlayerReplacement))`
- `NationalSpire.ClubCoaching.Replacements(NationalSpire.CareerData, string)`；输入表达式：`Replacements(d, a.PersonId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Replacements(d, a.PersonId).Contains`
- `NationalSpire.ClubCoaching.Replacements(NationalSpire.CareerData, string)`；输入表达式：`Replacements(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Replacements(d).Contains`
- `NationalSpire.OwnedClubs.IsOwner(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.IsOwner(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !OwnedClubs.IsOwner(d)`
- `NationalSpire.OwnedClubs.ReplaceableStarters(NationalSpire.CareerData)`；输入表达式：`OwnedClubs.ReplaceableStarters(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: OwnedClubs.ReplaceableStarters(d).Contains`
- `NationalSpire.OwnedClubs.ReservedStarter(NationalSpire.CareerData, string)`；输入表达式：`OwnedClubs.ReservedStarter(d, a.PersonId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !OwnedClubs.ReservedStarter(d, a.PersonId)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Any(p => p.Id == a.PersonId && p.ClubId == o.ClubId)`；返回值紧邻使用处：`BinaryExpressionSyntax: c != null && !c.GuaranteedStarter && !OwnedClubs.ReservedStarter(d, a.PersonId)                  && d.People.Any(p => p.Id == a.PersonId && p.ClubId == o.ClubId)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.Esports.LineupRequests.FirstOrDefault(r => r.Id == o.PlayerPositionRequest && r.State == "待生效")`；返回值紧邻使用处：`IsPatternExpressionSyntax: d.Esports.LineupRequests.FirstOrDefault(r => r.Id == o.PlayerPositionRequest && r.State == "待生效") is { } request`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`o.Contracts.FirstOrDefault(c => c.PersonId == a.PersonId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = o.Contracts.FirstOrDefault(c => c.PersonId == a.PersonId)`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`o.CoachAppointments.Where(a => a.Season <= d.Season).ToList()`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var a in o.CoachAppointments.Where(a => a.Season <= d.Season).ToList())          {              var c = o.Contracts.FirstOrDefault(c => c.PersonId == a.PersonId);              bool valid = c != null && !c.GuaranteedStarter && !OwnedClubs.ReservedStarter(d, a.PersonId)                  && d.People.Any(p => p.Id == a.PersonId && p.ClubId == o.ClubId)                  && (!o.Starters.Contains(a.PersonId) || Replacements(d, a.PersonId).Contains(a.Replacement));              if (valid) Convert(d, a.PersonId, a.Replacement);              else { o.CoachAppointments.Remove(a); Notice(d, "教练调整未生效", "原席位保留，接替人选或合同条件已变化。"); }          }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`o.CoachAppointments.Where(a => a.Season <= d.Season)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: o.CoachAppointments.Where(a => a.Season <= d.Season).ToList`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`o.Starters.Contains(a.PersonId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !o.Starters.Contains(a.PersonId)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`OwnedClubs.ReplaceableStarters(d).Contains(o.PlayerReplacement)`；返回值紧邻使用处：`ConditionalExpressionSyntax: reserve ? Replacements(d).Contains(o.PlayerReplacement)              : OwnedClubs.ReplaceableStarters(d).Contains(o.PlayerReplacement)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`Replacements(d, a.PersonId).Contains(a.Replacement)`；返回值紧邻使用处：`BinaryExpressionSyntax: !o.Starters.Contains(a.PersonId) || Replacements(d, a.PersonId).Contains(a.Replacement)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`Replacements(d).Contains(o.PlayerReplacement)`；返回值紧邻使用处：`ConditionalExpressionSyntax: reserve ? Replacements(d).Contains(o.PlayerReplacement)              : OwnedClubs.ReplaceableStarters(d).Contains(o.PlayerReplacement)`
- `System.Collections.Generic.List<T>.Remove(T)`；输入表达式：`o.CoachAppointments.Remove(a)`；返回值紧邻使用处：`ExpressionStatementSyntax: o.CoachAppointments.Remove(a);`

**赋值（含属性/字段和局部值）：**

- `o.PlayerReserve` = `reserve`
- `request.Reason` = `"接替人选或合同条件已变化。"`
- `request.State` = `available ? "已生效" : "未生效"`

<a id="symbol-d31f98e532af"></a>

## `NationalSpire.ClubCoaching.Notice(NationalSpire.CareerData, string, string) — private static void Notice(CareerData d, string title, string text)`

来源：源码第 147 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ClubCoaching.SeasonStart(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-c152f62d57e4)

**调用：** [`NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`](CareerLife.cs.md#symbol-0ea81cb3e558)；`System.Guid.NewGuid()`；`System.Guid.ToString(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerLife.AddEvent(NationalSpire.CareerData, string, string, string, string, System.Collections.Generic.List<string>, bool)`；输入表达式：`CareerLife.AddEvent(d,          "coach-notice-" + Guid.NewGuid().ToString("N"), "俱乐部", title, text, ["player"])`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => CareerLife.AddEvent(d,          "coach-notice-" + Guid.NewGuid().ToString("N"), "俱乐部", title, text, ["player"])`
- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`BinaryExpressionSyntax: "coach-notice-" + Guid.NewGuid().ToString("N")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-1ed5bef75319"></a>

## `NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData) — public static IEnumerable<CoachTrainingPlan> TrainingPlans(CareerData d)`

来源：源码第 154 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPrivateOffer(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateMessageScreen.cs.md#symbol-c7881d245b3d)；[`NationalSpire.CareerScreen.GroupOffer(NationalSpire.GroupChat, NationalSpire.GroupEffect, NationalSpire.PrivateOffer)`](GroupChatScreen.cs.md#symbol-3afa41099b93)；[`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)；[`NationalSpire.ClubCoaching.Advance(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-52a54f3b0a18)；[`NationalSpire.ClubCoaching.StopTraining(NationalSpire.CareerData, string)`](ClubCoaching.cs.md#symbol-eacca79a5d86)；[`NationalSpire.ClubCoaching.TrainingContext(NationalSpire.CareerData, string)`](ClubCoaching.cs.md#symbol-b2b767ed4fea)；[`NationalSpire.GroupChatPrompts.InteractionContext(NationalSpire.CareerData, NationalSpire.GroupChat, int, string, string)`](GroupChatPrompts.cs.md#symbol-ccc55b5e837d)；[`NationalSpire.PrivateInteractionHistory.Capture(NationalSpire.CareerData, string, bool)`](PrivateInteractionUndo.cs.md#symbol-de9e985d044d)；[`NationalSpire.PrivateMessagePrompts.OfferContext(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer, bool)`](PrivateMessagePrompts.cs.md#symbol-67bd27e9ea35)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.EsportsCareer.CoachTraining`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubState.CoachTraining`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`d.Esports.CoachTraining.Concat(d.Esports.OwnedClub?.CoachTraining ?? [])`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: =>          d.Esports.CoachTraining.Concat(d.Esports.OwnedClub?.CoachTraining ?? [])`

**赋值（含属性/字段和局部值）：**


<a id="symbol-750e508942ca"></a>

## `NationalSpire.ClubCoaching.TrainingStore(NationalSpire.CareerData, string) — private static List<CoachTrainingPlan> TrainingStore(CareerData d, string club)`

来源：源码第 156 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ClubCoaching.AcceptTraining(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`](ClubCoaching.cs.md#symbol-fc1017e0877c)；[`NationalSpire.ClubCoaching.RestoreTraining(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.CoachTrainingPlan>)`](ClubCoaching.cs.md#symbol-0644d2f9c30d)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.EsportsCareer.CoachTraining`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubState.CoachTraining`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0644d2f9c30d"></a>

## `NationalSpire.ClubCoaching.RestoreTraining(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.CoachTrainingPlan>) — internal static void RestoreTraining(CareerData d, string person, List<CoachTrainingPlan> plans)`

来源：源码第 158 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateInteractionHistory.Restore(NationalSpire.CareerData, string, System.Text.Json.Nodes.JsonObject, bool)`](PrivateInteractionUndo.cs.md#symbol-dd91210e87c0)

**调用：** [`NationalSpire.ClubCoaching.TrainingStore(NationalSpire.CareerData, string)`](ClubCoaching.cs.md#symbol-750e508942ca)；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.ClubCoaching.TrainingStore(NationalSpire.CareerData, string)`；`NationalSpire.CoachTrainingPlan.ClubId`；`NationalSpire.CoachTrainingPlan.PersonId`；`NationalSpire.EsportsCareer.CoachTraining`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubState.CoachTraining`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ClubCoaching.TrainingStore(NationalSpire.CareerData, string)`；输入表达式：`TrainingStore(d, plan.ClubId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: TrainingStore(d, plan.ClubId).Add`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`TrainingStore(d, plan.ClubId).Add(plan)`；返回值紧邻使用处：`ExpressionStatementSyntax: TrainingStore(d, plan.ClubId).Add(plan);`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`.CoachTraining.RemoveAll(p => p.PersonId == person)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: d.Esports.OwnedClub?.CoachTraining.RemoveAll(p => p.PersonId == person)`
- `System.Collections.Generic.List<T>.RemoveAll(System.Predicate<T>)`；输入表达式：`d.Esports.CoachTraining.RemoveAll(p => p.PersonId == person)`；返回值紧邻使用处：`ExpressionStatementSyntax: d.Esports.CoachTraining.RemoveAll(p => p.PersonId == person);`

**赋值（含属性/字段和局部值）：**


<a id="symbol-190f8b335415"></a>

## `NationalSpire.ClubCoaching.TrainingMember(NationalSpire.CareerData, string, string) — private static bool TrainingMember(CareerData d, string person, string club)`

来源：源码第 164 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ClubCoaching.Advance(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-52a54f3b0a18)；[`NationalSpire.ClubCoaching.TrainingError(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](ClubCoaching.cs.md#symbol-061ee769bb78)

**调用：** [`NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`](ClubCoaching.cs.md#symbol-8b4ec414486e)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.People`；`NationalSpire.CareerPerson.ClubId`；`NationalSpire.CareerPerson.Id`；`NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`；`NationalSpire.EsportsCareer.OwnedClub`；`NationalSpire.OwnedClubState.ClubId`；`NationalSpire.OwnedClubState.Contracts`；`NationalSpire.OwnedPlayerContract.PersonId`；`NationalSpire.OwnedPlayerContract.Position`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ClubCoaching.IsCoach(NationalSpire.CareerPerson)`；输入表达式：`IsCoach(p)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !IsCoach(p)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`d.People.Any(p => p.Id == person && p.ClubId == club && !IsCoach(p))`；返回值紧邻使用处：`BinaryExpressionSyntax: club.Length > 0          && d.People.Any(p => p.Id == person && p.ClubId == club && !IsCoach(p))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`o.Contracts.Any(c => c.PersonId == person && c.Position is "首发" or "轮换" or "青训")`；返回值紧邻使用处：`BinaryExpressionSyntax: d.Esports.OwnedClub is not { } o || o.ClubId != club              || o.Contracts.Any(c => c.PersonId == person && c.Position is "首发" or "轮换" or "青训")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-061ee769bb78"></a>

## `NationalSpire.ClubCoaching.TrainingError(NationalSpire.CareerData, string, NationalSpire.PrivateOffer) — public static string? TrainingError(CareerData d, string person, PrivateOffer attachment)`

来源：源码第 168 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.PrivateTrainingPicker()`](CoachScreen.cs.md#symbol-2609d8a7ba68)；[`NationalSpire.ClubCoaching.AcceptTraining(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`](ClubCoaching.cs.md#symbol-fc1017e0877c)；[`NationalSpire.PrivateMessages.PrepareAttachments(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>)`](PrivateMessages.cs.md#symbol-f2d6d9cf9c86)

**调用：** [`NationalSpire.ClubCoaching.PlayerCoach(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-26fb5cc468c4)；[`NationalSpire.ClubCoaching.TrainingMember(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-190f8b335415)；[`NationalSpire.CoachLineups.CanRequest(NationalSpire.CareerData, string)`](CoachLineups.cs.md#symbol-7ddb21934c39)；`string.IsNullOrWhiteSpace(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.ClubCoaching.PlayerCoach(NationalSpire.CareerData)`；`NationalSpire.ClubCoaching.TrainingMember(NationalSpire.CareerData, string, string)`；`NationalSpire.CoachLineups.CanRequest(NationalSpire.CareerData, string)`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.PrivateOffer.CoachAccepted`；`NationalSpire.PrivateOffer.CoachId`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Weeks`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ClubCoaching.PlayerCoach(NationalSpire.CareerData)`；输入表达式：`PlayerCoach(d)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PlayerCoach(d)`
- `NationalSpire.ClubCoaching.TrainingMember(NationalSpire.CareerData, string, string)`；输入表达式：`TrainingMember(d, person, d.Esports.ClubId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !TrainingMember(d, person, d.Esports.ClubId)`
- `NationalSpire.CoachLineups.CanRequest(NationalSpire.CareerData, string)`；输入表达式：`CoachLineups.CanRequest(d, attachment.CoachId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CoachLineups.CanRequest(d, attachment.CoachId)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(attachment.Detail)`；返回值紧邻使用处：`BinaryExpressionSyntax: attachment.Weeks is < 1 or > 4 || string.IsNullOrWhiteSpace(attachment.Detail)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fc1017e0877c"></a>

## `NationalSpire.ClubCoaching.AcceptTraining(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>) — public static void AcceptTraining(CareerData d, PrivateConversation c, PrivateTurn t, Dictionary<string, string> fields)`

来源：源码第 179 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessages.Apply(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>, int?)`](PrivateMessages.cs.md#symbol-7bf623828ccc)

**调用：** [`NationalSpire.ClubCoaching.TrainingError(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](ClubCoaching.cs.md#symbol-061ee769bb78)；[`NationalSpire.ClubCoaching.TrainingStore(NationalSpire.CareerData, string)`](ClubCoaching.cs.md#symbol-750e508942ca)；[`NationalSpire.PrivateInteractionIds.Ensure(NationalSpire.PrivateConversation)`](PrivateMessageData.cs.md#symbol-2a4d65cc20f8)；[`NationalSpire.PrivateInteractionIds.Resolve(NationalSpire.PrivateConversation, string?)`](PrivateMessageData.cs.md#symbol-ad3e5a4298ba)；`NationalSpire.CoachTrainingPlan.CoachTrainingPlan()`；`NationalSpire.PrivateOffer.PrivateOffer()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.ClubCoaching.TrainingError(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；`NationalSpire.ClubCoaching.TrainingStore(NationalSpire.CareerData, string)`；`NationalSpire.CoachTrainingPlan.ClubId`；`NationalSpire.CoachTrainingPlan.CoachId`；`NationalSpire.CoachTrainingPlan.Content`；`NationalSpire.CoachTrainingPlan.Id`；`NationalSpire.CoachTrainingPlan.PersonId`；`NationalSpire.CoachTrainingPlan.StartDay`；`NationalSpire.CoachTrainingPlan.State`；`NationalSpire.CoachTrainingPlan.TurnId`；`NationalSpire.CoachTrainingPlan.Weeks`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateInteractionIds.Ensure(NationalSpire.PrivateConversation)`；`NationalSpire.PrivateInteractionIds.Resolve(NationalSpire.PrivateConversation, string?)`；`NationalSpire.PrivateOffer.CoachId`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.TurnId`；`NationalSpire.PrivateOffer.Weeks`；`NationalSpire.PrivateTurn.Attachments`；`NationalSpire.PrivateTurn.Error`；`NationalSpire.PrivateTurn.Id`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ClubCoaching.TrainingError(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`；输入表达式：`TrainingError(d, c.PersonId, a)`；返回值紧邻使用处：`IsPatternExpressionSyntax: TrainingError(d, c.PersonId, a) is { } error`
- `NationalSpire.ClubCoaching.TrainingStore(NationalSpire.CareerData, string)`；输入表达式：`TrainingStore(d, d.Esports.ClubId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = TrainingStore(d, d.Esports.ClubId)`
- `NationalSpire.CoachTrainingPlan.CoachTrainingPlan()`；输入表达式：`new() { Id = id, PersonId = c.PersonId, ClubId = d.Esports.ClubId, TurnId = t.Id,              Content = a.Detail, StartDay = d.Day, Weeks = a.Weeks, CoachId = a.CoachId }`；返回值紧邻使用处：`ArgumentSyntax: new() { Id = id, PersonId = c.PersonId, ClubId = d.Esports.ClubId, TurnId = t.Id,              Content = a.Detail, StartDay = d.Day, Weeks = a.Weeks, CoachId = a.CoachId }`
- `NationalSpire.PrivateInteractionIds.Ensure(NationalSpire.PrivateConversation)`；输入表达式：`PrivateInteractionIds.Ensure(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateInteractionIds.Ensure(c);`
- `NationalSpire.PrivateInteractionIds.Resolve(NationalSpire.PrivateConversation, string?)`；输入表达式：`PrivateInteractionIds.Resolve(c, fields.GetValueOrDefault("Id"))`；返回值紧邻使用处：`BinaryExpressionSyntax: a.Id == PrivateInteractionIds.Resolve(c, fields.GetValueOrDefault("Id"))`
- `NationalSpire.PrivateOffer.PrivateOffer()`；输入表达式：`new() { Id = id, Kind = "training", TurnId = t.Id, State = "已接受", Detail = a.Detail, Weeks = a.Weeks }`；返回值紧邻使用处：`ArgumentSyntax: new() { Id = id, Kind = "training", TurnId = t.Id, State = "已接受", Detail = a.Detail, Weeks = a.Weeks }`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`plans.Any(p => p.Id == id)`；返回值紧邻使用处：`IfStatementSyntax: if (plans.Any(p => p.Id == id)) return;`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`t.Attachments.FirstOrDefault(a => a.Kind == "training" && a.Id == PrivateInteractionIds.Resolve(c, fields.GetValueOrDefault("Id")))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = t.Attachments.FirstOrDefault(a => a.Kind == "training" && a.Id == PrivateInteractionIds.Resolve(c, fields.GetValueOrDefault("Id")))`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`plans.Where(p => p.PersonId == c.PersonId && p.State == "进行中")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var old in plans.Where(p => p.PersonId == c.PersonId && p.State == "进行中")) old.State = "已替换";`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`fields.GetValueOrDefault("Id")`；返回值紧邻使用处：`ArgumentSyntax: fields.GetValueOrDefault("Id")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`fields.GetValueOrDefault("Training")`；返回值紧邻使用处：`BinaryExpressionSyntax: fields.GetValueOrDefault("Training") != "接受"`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`c.Offers.Add(new() { Id = id, Kind = "training", TurnId = t.Id, State = "已接受", Detail = a.Detail, Weeks = a.Weeks })`；返回值紧邻使用处：`ExpressionStatementSyntax: c.Offers.Add(new() { Id = id, Kind = "training", TurnId = t.Id, State = "已接受", Detail = a.Detail, Weeks = a.Weeks });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`plans.Add(new() { Id = id, PersonId = c.PersonId, ClubId = d.Esports.ClubId, TurnId = t.Id,              Content = a.Detail, StartDay = d.Day, Weeks = a.Weeks, CoachId = a.CoachId })`；返回值紧邻使用处：`ExpressionStatementSyntax: plans.Add(new() { Id = id, PersonId = c.PersonId, ClubId = d.Esports.ClubId, TurnId = t.Id,              Content = a.Detail, StartDay = d.Day, Weeks = a.Weeks, CoachId = a.CoachId });`

**赋值（含属性/字段和局部值）：**

- `ClubId` = `d.Esports.ClubId`
- `CoachId` = `a.CoachId`
- `Content` = `a.Detail`
- `Detail` = `a.Detail`
- `Id` = `id`
- `Kind` = `"training"`
- `old.State` = `"已替换"`
- `PersonId` = `c.PersonId`
- `StartDay` = `d.Day`
- `State` = `"已接受"`
- `t.Error` += `"\n" + error`
- `t.Error` += `"\n缺少对应训练附件，未执行。"`
- `TurnId` = `t.Id`
- `Weeks` = `a.Weeks`

<a id="symbol-52a54f3b0a18"></a>

## `NationalSpire.ClubCoaching.Advance(NationalSpire.CareerData) — public static void Advance(CareerData d)`

来源：源码第 194 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLife.Advance(NationalSpire.CareerData)`](CareerLife.cs.md#symbol-62ec6434f115)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.CareerTraining.RecordLesson(NationalSpire.CareerData, string, NationalSpire.PrivateLearning)`](CareerTraining.cs.md#symbol-20ac1d8e57c7)；[`NationalSpire.ClubCoaching.PlayerCoach(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-26fb5cc468c4)；[`NationalSpire.ClubCoaching.TrainingMember(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-190f8b335415)；[`NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-1ed5bef75319)；[`NationalSpire.CoachLineups.CanRequest(NationalSpire.CareerData, string)`](CoachLineups.cs.md#symbol-7ddb21934c39)；`NationalSpire.PrivateLearning.PrivateLearning()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Math.Clamp(int, int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Esports`；`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.CareerPerson.Learning`；`NationalSpire.CareerTraining.RecordLesson(NationalSpire.CareerData, string, NationalSpire.PrivateLearning)`；`NationalSpire.ClubCoaching.PlayerCoach(NationalSpire.CareerData)`；`NationalSpire.ClubCoaching.TrainingMember(NationalSpire.CareerData, string, string)`；`NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`；`NationalSpire.CoachLineups.CanRequest(NationalSpire.CareerData, string)`；`NationalSpire.CoachTrainingPlan.ClubId`；`NationalSpire.CoachTrainingPlan.CoachId`；`NationalSpire.CoachTrainingPlan.Content`；`NationalSpire.CoachTrainingPlan.Gained`；`NationalSpire.CoachTrainingPlan.Id`；`NationalSpire.CoachTrainingPlan.PaidWeeks`；`NationalSpire.CoachTrainingPlan.PersonId`；`NationalSpire.CoachTrainingPlan.StartDay`；`NationalSpire.CoachTrainingPlan.State`；`NationalSpire.CoachTrainingPlan.Weeks`；`NationalSpire.EsportsCareer.ClubId`；`NationalSpire.NpcLearning.ChanceShift`；`NationalSpire.PrivateLearning.Id`；`NationalSpire.PrivateLearning.Reason`；`NationalSpire.PrivateLearning.Source`；`NationalSpire.PrivateLearning.Strength`；`NationalSpire.PrivateLearning.Topic`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(d, plan.PersonId)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(d, plan.PersonId)!`
- `NationalSpire.CareerTraining.RecordLesson(NationalSpire.CareerData, string, NationalSpire.PrivateLearning)`；输入表达式：`CareerTraining.RecordLesson(d, plan.PersonId, new PrivateLearning { Id = "coach:" + plan.Id + ":" + week, Topic = plan.Content, Strength = 1, Source = "coach:" + plan.Id + ":" + week, Reason = plan.Content })`；返回值紧邻使用处：`ExpressionStatementSyntax: CareerTraining.RecordLesson(d, plan.PersonId, new PrivateLearning { Id = "coach:" + plan.Id + ":" + week, Topic = plan.Content, Strength = 1, Source = "coach:" + plan.Id + ":" + week, Reason = plan.Content });`
- `NationalSpire.ClubCoaching.PlayerCoach(NationalSpire.CareerData)`；输入表达式：`PlayerCoach(d)`；返回值紧邻使用处：`ConditionalExpressionSyntax: plan.CoachId.Length > 0 ? CoachLineups.CanRequest(d, plan.CoachId) : PlayerCoach(d)`
- `NationalSpire.ClubCoaching.TrainingMember(NationalSpire.CareerData, string, string)`；输入表达式：`TrainingMember(d, plan.PersonId, plan.ClubId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !TrainingMember(d, plan.PersonId, plan.ClubId)`
- `NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`；输入表达式：`TrainingPlans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: TrainingPlans(d).Where`
- `NationalSpire.CoachLineups.CanRequest(NationalSpire.CareerData, string)`；输入表达式：`CoachLineups.CanRequest(d, plan.CoachId)`；返回值紧邻使用处：`ConditionalExpressionSyntax: plan.CoachId.Length > 0 ? CoachLineups.CanRequest(d, plan.CoachId) : PlayerCoach(d)`
- `NationalSpire.PrivateLearning.PrivateLearning()`；输入表达式：`new PrivateLearning { Id = "coach:" + plan.Id + ":" + week, Topic = plan.Content, Strength = 1, Source = "coach:" + plan.Id + ":" + week, Reason = plan.Content }`；返回值紧邻使用处：`ArgumentSyntax: new PrivateLearning { Id = "coach:" + plan.Id + ":" + week, Topic = plan.Content, Strength = 1, Source = "coach:" + plan.Id + ":" + week, Reason = plan.Content }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`TrainingPlans(d).Where(p => p.State == "进行中")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var plan in TrainingPlans(d).Where(p => p.State == "进行中"))          {              if (!(plan.CoachId.Length > 0 ? CoachLineups.CanRequest(d, plan.CoachId) : PlayerCoach(d))                  || plan.ClubId != d.Esports.ClubId || !TrainingMember(d, plan.PersonId, plan.ClubId)) { plan.State = "已取消"; continue; }              int due = Math.Clamp((d.Day - plan.StartDay) / 7, 0, plan.Weeks);              while (plan.PaidWeeks < due)              {                  int week = ++plan.PaidWeeks;                  var before = CareerEngine.Person(d, plan.PersonId)!.Learning.ChanceShift;                  CareerTraining.RecordLesson(d, plan.PersonId, new PrivateLearning { Id = "coach:" + plan.Id + ":" + week, Topic = plan.Content, Strength = 1, Source = "coach:" + plan.Id + ":" + week, Reason = plan.Content });                  plan.Gained += CareerEngine.Person(d, plan.PersonId)!.Learning.ChanceShift - before;              }              if (plan.PaidWeeks == plan.Weeks) plan.State = "已完成";          }`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp((d.Day - plan.StartDay) / 7, 0, plan.Weeks)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Clamp((d.Day - plan.StartDay) / 7, 0, plan.Weeks)`

**赋值（含属性/字段和局部值）：**

- `Id` = `"coach:" + plan.Id + ":" + week`
- `plan.Gained` += `CareerEngine.Person(d, plan.PersonId)!.Learning.ChanceShift - before`
- `plan.State` = `"已取消"`
- `plan.State` = `"已完成"`
- `Reason` = `plan.Content`
- `Source` = `"coach:" + plan.Id + ":" + week`
- `Strength` = `1`
- `Topic` = `plan.Content`

<a id="symbol-eacca79a5d86"></a>

## `NationalSpire.ClubCoaching.StopTraining(NationalSpire.CareerData, string) — public static void StopTraining(CareerData d, string id)`

来源：源码第 211 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CharacterDeletion.Delete(NationalSpire.CareerData, string)`](CharacterDeletion.cs.md#symbol-2eb70f838afa)；[`NationalSpire.ClubCoaching.Convert(NationalSpire.CareerData, string, string)`](ClubCoaching.cs.md#symbol-4c320b941b55)；[`NationalSpire.OwnedClubs.Assign(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-e97dde3c003f)；[`NationalSpire.OwnedClubs.Command(NationalSpire.CareerData, string, string, string)`](OwnedClubs.cs.md#symbol-12b38cf6ab67)；[`NationalSpire.OwnedClubs.Release(NationalSpire.CareerData, string, string)`](OwnedClubs.cs.md#symbol-ab8d716536a6)；[`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)

**调用：** [`NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-1ed5bef75319)；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`；`NationalSpire.CoachTrainingPlan.CoachId`；`NationalSpire.CoachTrainingPlan.PersonId`；`NationalSpire.CoachTrainingPlan.State`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`；输入表达式：`TrainingPlans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: TrainingPlans(d).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`TrainingPlans(d).Where(p => (p.PersonId == id || p.CoachId == id) && p.State == "进行中")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var plan in TrainingPlans(d).Where(p => (p.PersonId == id || p.CoachId == id) && p.State == "进行中")) plan.State = "已取消";`

**赋值（含属性/字段和局部值）：**

- `plan.State` = `"已取消"`

<a id="symbol-b2b767ed4fea"></a>

## `NationalSpire.ClubCoaching.TrainingContext(NationalSpire.CareerData, string) — public static string TrainingContext(CareerData d, string id)`

来源：源码第 215 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RefreshPrivateChat(bool)`](PrivateMessageScreen.cs.md#symbol-cef7c0adba54)；[`NationalSpire.GroupChatPrompts.Compose(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.GroupTurn?, bool)`](GroupChatPrompts.cs.md#symbol-a333ef13db23)；[`NationalSpire.PrivateMessagePrompts.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-4b9d12b26f65)

**调用：** [`NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`](ClubCoaching.cs.md#symbol-1ed5bef75319)；[`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`](PrivateAppointments.cs.md#symbol-1c549626b284)；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`；`NationalSpire.CoachTrainingPlan.Content`；`NationalSpire.CoachTrainingPlan.EndDay`；`NationalSpire.CoachTrainingPlan.Gained`；`NationalSpire.CoachTrainingPlan.PaidWeeks`；`NationalSpire.CoachTrainingPlan.PersonId`；`NationalSpire.CoachTrainingPlan.StartDay`；`NationalSpire.CoachTrainingPlan.State`；`NationalSpire.CoachTrainingPlan.Weeks`；`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ClubCoaching.TrainingPlans(NationalSpire.CareerData)`；输入表达式：`TrainingPlans(d)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: TrainingPlans(d).LastOrDefault`
- `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；输入表达式：`PrivateAppointments.DateText(d, p.EndDay)`；返回值紧邻使用处：`InterpolationSyntax: {PrivateAppointments.DateText(d, p.EndDay)}`
- `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；输入表达式：`PrivateAppointments.DateText(d, p.StartDay)`；返回值紧邻使用处：`InterpolationSyntax: {PrivateAppointments.DateText(d, p.StartDay)}`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`TrainingPlans(d).LastOrDefault(p => p.PersonId == id)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = TrainingPlans(d).LastOrDefault(p => p.PersonId == id)`

**赋值（含属性/字段和局部值）：**
