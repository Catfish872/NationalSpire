# SeasonCalendar.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`3DD0BF9926087829D6032FF8C24BDC5D9E1539857BA4500E690DC669E76F7243`。来源：[源码](../../SeasonCalendar.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.SeasonCalendar`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-12bdfe5d4265"></a>

## `NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int) — public static int Length(CareerData d, int season = 0)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AppointmentCalendar(NationalSpire.CareerData, int, System.Collections.Generic.IEnumerable<string>, int, System.Action<int>)`](AppointmentCalendarScreen.cs.md#symbol-b5cb4cb371f4)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`](ConsumerPickerScreen.cs.md#symbol-0f5d28176960)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerScreen.World(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-ce5a79e2aa5c)；[`NationalSpire.CareerTraining.SeasonAt(NationalSpire.CareerData, int)`](CareerTraining.cs.md#symbol-21aa7b4188db)；[`NationalSpire.ChatAttachments.Prepare(NationalSpire.CareerData, string, NationalSpire.PrivateOffer, bool)`](ChatAttachments.cs.md#symbol-4e7c361b1f77)；[`NationalSpire.CircuitWorld.BuildLeague(NationalSpire.CareerData, string, string)`](CircuitWorld.cs.md#symbol-a4180110ef1d)；[`NationalSpire.CircuitWorld.CreateFinals(NationalSpire.CareerData, bool)`](CircuitWorld.cs.md#symbol-cb2c18d20a39)；[`NationalSpire.CircuitWorld.EnsureOpenEvents(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-73f52bc89477)；[`NationalSpire.ClubCoaching.Scheduled(NationalSpire.CareerData, string)`](ClubCoaching.cs.md#symbol-4f8141b24cff)；[`NationalSpire.NationalDevelopment.SeasonsPerYear(NationalSpire.CareerData)`](NationalDevelopment.cs.md#symbol-9715a2dc78f5)；[`NationalSpire.PrivateAppointments.Error(NationalSpire.CareerData, string, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-e7f8b7355ddf)；[`NationalSpire.SeasonCalendar.End(NationalSpire.CareerData)`](SeasonCalendar.cs.md#symbol-6b4c49a62324)；[`NationalSpire.SeasonCalendar.LeagueDeadline(NationalSpire.CareerData)`](SeasonCalendar.cs.md#symbol-bca858704a5e)；[`NationalSpire.SeasonCalendar.LeagueEnd(NationalSpire.CareerData)`](SeasonCalendar.cs.md#symbol-694fe9ba6582)；[`NationalSpire.SocialAppointments.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>)`](SocialAppointments.cs.md#symbol-33a4725630bd)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.LongSeasonsFrom`；`NationalSpire.CareerData.Season`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ee7b01d76b23"></a>

## `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int) — public static int Start(CareerData d, int season = 0)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Calendar()`](ConsumerPickerScreen.cs.md#symbol-8eb2036c6dbc)；[`Calendar()`](PrivateMessageScreen.cs.md#symbol-a46807051ffe)；[`NationalSpire.CareerEngine.MoveToNextDay(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-3836a38a7da9)；[`NationalSpire.CareerLibrary.Import(string, byte[])`](CareerLibrary.cs.md#symbol-b347de421d96)；[`NationalSpire.CareerScreen.AppointmentCalendar(NationalSpire.CareerData, int, System.Collections.Generic.IEnumerable<string>, int, System.Action<int>)`](AppointmentCalendarScreen.cs.md#symbol-b5cb4cb371f4)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.Clubs(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-f5bb582dc7eb)；[`NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`](ConsumerPickerScreen.cs.md#symbol-0f5d28176960)；[`NationalSpire.CareerScreen.DateDiaryEntryDialog(NationalSpire.CareerData, string, string)`](DateDiaryScreen.cs.md#symbol-fb4ba1a3b5fa)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerStore.Read(string)`](CareerStore.cs.md#symbol-bd7895ebe52b)；[`NationalSpire.CareerTraining.SeasonAt(NationalSpire.CareerData, int)`](CareerTraining.cs.md#symbol-21aa7b4188db)；[`NationalSpire.CircuitWorld.BuildLeague(NationalSpire.CareerData, string, string)`](CircuitWorld.cs.md#symbol-a4180110ef1d)；[`NationalSpire.CircuitWorld.CreateFinals(NationalSpire.CareerData, bool)`](CircuitWorld.cs.md#symbol-cb2c18d20a39)；[`NationalSpire.CircuitWorld.EnsureOpenEvents(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-73f52bc89477)；[`NationalSpire.CircuitWorld.StartSeason(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-8e4cfe18b2fe)；[`NationalSpire.ClubCoaching.Scheduled(NationalSpire.CareerData, string)`](ClubCoaching.cs.md#symbol-4f8141b24cff)；[`NationalSpire.EsportsWorld.AcceptOffer(NationalSpire.CareerData, NationalSpire.ClubOffer)`](EsportsWorld.cs.md#symbol-09ff5941397c)；[`NationalSpire.EsportsWorld.EntryReason(NationalSpire.CareerData, NationalSpire.CareerMatch)`](EsportsWorld.cs.md#symbol-4b9f3e1bf70a)；[`NationalSpire.OwnedClubs.FirstLeagueDay(NationalSpire.CareerData)`](OwnedClubs.cs.md#symbol-4dd05f6eadef)；[`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；[`NationalSpire.SeasonCalendar.End(NationalSpire.CareerData)`](SeasonCalendar.cs.md#symbol-6b4c49a62324)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.LongSeasonsFrom`；`NationalSpire.CareerData.Season`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `season` = `season == 0 ? d.Season : season`

<a id="symbol-6b4c49a62324"></a>

## `NationalSpire.SeasonCalendar.End(NationalSpire.CareerData) — public static int End(CareerData d)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.MoveToNextDay(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-3836a38a7da9)；[`NationalSpire.CareerLibrary.Import(string, byte[])`](CareerLibrary.cs.md#symbol-b347de421d96)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.Matches(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-c8051d511377)；[`NationalSpire.CareerStore.Read(string)`](CareerStore.cs.md#symbol-bd7895ebe52b)

**调用：** [`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-12bdfe5d4265)；[`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-ee7b01d76b23)

**字段、属性、事件及方法组引用：** `NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；`NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；输入表达式：`Length(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: Start(d) + Length(d)`
- `NationalSpire.SeasonCalendar.Start(NationalSpire.CareerData, int)`；输入表达式：`Start(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: Start(d) + Length(d)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0f707d2c9895"></a>

## `NationalSpire.SeasonCalendar.Day(NationalSpire.CareerData, int) — public static int Day(CareerData d, int absolute)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerLibrary.List(string)`](CareerLibrary.cs.md#symbol-49ca8927a7b3)；[`NationalSpire.CareerScreen.ConsumerEditor(bool, NationalSpire.ConsumerComposer?, NationalSpire.PrivateOffer?, string, string, NationalSpire.CareerScreen.ConsumerEdit?)`](ConsumerPickerScreen.cs.md#symbol-0f5d28176960)；[`NationalSpire.CircuitWorld.AutoEntry(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-43c8211433d7)；[`NationalSpire.ClubOperations.TryTransfer(NationalSpire.CareerData, NationalSpire.CareerClub)`](ClubOperations.cs.md#symbol-91ececd875b5)；[`NationalSpire.EsportsWorld.AcceptOffer(NationalSpire.CareerData, NationalSpire.ClubOffer)`](EsportsWorld.cs.md#symbol-09ff5941397c)；[`NationalSpire.EsportsWorld.SettleDay(NationalSpire.CareerData, int, bool, bool)`](EsportsWorld.cs.md#symbol-0a6be40070dd)；[`NationalSpire.GameCalendar.NormalizeFields(NationalSpire.CareerData, System.Collections.Generic.Dictionary<string, string>)`](GameCalendar.cs.md#symbol-65b6dda6244b)；[`NationalSpire.PrivateAppointments.DateRanges(NationalSpire.CareerData, System.Collections.Generic.IEnumerable<int>)`](PrivateAppointments.cs.md#symbol-9915e0a4ada0)；[`NationalSpire.PrivateAppointments.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.Dictionary<string, string>, string)`](PrivateAppointments.cs.md#symbol-32d5ee024249)；[`NationalSpire.RandomEventEffects.CheckEffects(NationalSpire.CareerData, NationalSpire.RandomEventRecord, NationalSpire.RandomEventOption)`](RandomEvents.cs.md#symbol-1a41c3fc699a)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.LongSeasonsFrom`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-bca858704a5e"></a>

## `NationalSpire.SeasonCalendar.LeagueDeadline(NationalSpire.CareerData) — public static int LeagueDeadline(CareerData d)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Clubs(NationalSpire.CareerData)`](CareerWorldScreen.cs.md#symbol-f5bb582dc7eb)；[`NationalSpire.CircuitWorld.AutoEntry(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-43c8211433d7)；[`NationalSpire.ClubOperations.TryTransfer(NationalSpire.CareerData, NationalSpire.CareerClub)`](ClubOperations.cs.md#symbol-91ececd875b5)；[`NationalSpire.EsportsWorld.AcceptOffer(NationalSpire.CareerData, NationalSpire.ClubOffer)`](EsportsWorld.cs.md#symbol-09ff5941397c)

**调用：** [`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-12bdfe5d4265)

**字段、属性、事件及方法组引用：** `NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；输入表达式：`Length(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: Length(d) == 84`

**赋值（含属性/字段和局部值）：**


<a id="symbol-694fe9ba6582"></a>

## `NationalSpire.SeasonCalendar.LeagueEnd(NationalSpire.CareerData) — public static int LeagueEnd(CareerData d)`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.EsportsWorld.SettleDay(NationalSpire.CareerData, int, bool, bool)`](EsportsWorld.cs.md#symbol-0a6be40070dd)

**调用：** [`NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`](SeasonCalendar.cs.md#symbol-12bdfe5d4265)

**字段、属性、事件及方法组引用：** `NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.SeasonCalendar.Length(NationalSpire.CareerData, int)`；输入表达式：`Length(d)`；返回值紧邻使用处：`BinaryExpressionSyntax: Length(d) == 84`

**赋值（含属性/字段和局部值）：**


<a id="symbol-52079aa15d28"></a>

## `NationalSpire.SeasonCalendar.Upgrade(NationalSpire.CareerData) — public static bool Upgrade(CareerData d)`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.NormalizeRoster(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-eb11b96e7400)

**调用：** [`NationalSpire.CircuitWorld.EnsureOpenEvents(NationalSpire.CareerData)`](CircuitWorld.cs.md#symbol-73f52bc89477)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Esports`；`NationalSpire.CareerData.LongSeasonsFrom`；`NationalSpire.CareerData.Season`；`NationalSpire.CircuitWorld.EnsureOpenEvents(NationalSpire.CareerData)`；`NationalSpire.EsportsCareer.EcosystemVersion`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CircuitWorld.EnsureOpenEvents(NationalSpire.CareerData)`；输入表达式：`CircuitWorld.EnsureOpenEvents(d)`；返回值紧邻使用处：`ExpressionStatementSyntax: CircuitWorld.EnsureOpenEvents(d);`

**赋值（含属性/字段和局部值）：**

- `d.LongSeasonsFrom` = `d.Season + 1`
