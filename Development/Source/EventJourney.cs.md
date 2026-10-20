# EventJourney.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`BB6BF64A5412E8869184A64AE1CC66F1AD8256DE251869E06D4A2E8ACD0F5FDD`。来源：[源码](../../EventJourney.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.EventJourney`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-650a972e5dcf"></a>

## `NationalSpire.EventJourney.Destination — public int Destination`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4bd51c5dbb0b"></a>

## `NationalSpire.EventJourney.PausedDay — public int PausedDay`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ce63ebdddde9"></a>

## `NationalSpire.EventJourney.ResumePublications — public bool ResumePublications`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5010e9adc2fd"></a>

## `NationalSpire.EventJourney.PublicationsPaused(NationalSpire.CareerData) — public static bool PublicationsPaused(CareerData data)`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessPendingAsync(NationalSpire.CareerData?, bool)`](AiService.cs.md#symbol-4f47e0824ca3)；[`NationalSpire.CareerEngine.AdvanceToDay(NationalSpire.CareerData, int, bool)`](CareerEngine.cs.md#symbol-0c04b8ec5f73)；[`NationalSpire.CareerScreen.Render()`](CareerScreen.cs.md#symbol-d4a4496fddb9)；[`NationalSpire.CareerScreen.ShowJourneyEncounter()`](EventJourneyScreen.cs.md#symbol-4e94d6a77974)；[`NationalSpire.Coop.CoopAi.ProcessPublications(bool)`](Coop/CoopAi.cs.md#symbol-b4b98ce85f62)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Journey`；`NationalSpire.EventJourney.PausedDay`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-06d0dae6e94e"></a>

## `NationalSpire.EventJourney.Begin(NationalSpire.CareerData, int) — public static void Begin(CareerData data, int destination)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.AdvanceToDay(NationalSpire.CareerData, int, bool)`](CareerEngine.cs.md#symbol-0c04b8ec5f73)

**调用：** [`NationalSpire.EventJourney.Resume(NationalSpire.CareerData)`](EventJourney.cs.md#symbol-eab8348c25b2)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Journey`；`NationalSpire.EventJourney.Destination`；`NationalSpire.EventJourney.Resume(NationalSpire.CareerData)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.EventJourney.Resume(NationalSpire.CareerData)`；输入表达式：`Resume(data)`；返回值紧邻使用处：`ExpressionStatementSyntax: Resume(data);`

**赋值（含属性/字段和局部值）：**

- `data.Journey.Destination` = `destination`

<a id="symbol-eab8348c25b2"></a>

## `NationalSpire.EventJourney.Resume(NationalSpire.CareerData) — public static void Resume(CareerData data)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.AdvanceOneDay(NationalSpire.CareerData)`](CareerEngine.cs.md#symbol-5b81bcd72cc1)；[`NationalSpire.EventJourney.Begin(NationalSpire.CareerData, int)`](EventJourney.cs.md#symbol-06d0dae6e94e)；[`NationalSpire.WorldEvents.AfterMatch(NationalSpire.CareerData, NationalSpire.CareerMatch)`](WorldEvents.cs.md#symbol-dd13ed02e783)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Journey`；`NationalSpire.EventJourney.Destination`；`NationalSpire.EventJourney.PausedDay`；`NationalSpire.EventJourney.ResumePublications`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `data.Journey.Destination` = `0`
- `data.Journey.PausedDay` = `0`
- `data.Journey.ResumePublications` = `true`

<a id="symbol-b6993f2cab5d"></a>

## `NationalSpire.EventJourney.Stop(NationalSpire.CareerData, int, bool, bool) — public static bool Stop(CareerData data, int destination, bool ordinaryStop, bool hasEvent)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerEngine.AdvanceToDay(NationalSpire.CareerData, int, bool)`](CareerEngine.cs.md#symbol-0c04b8ec5f73)；[`NationalSpire.Coop.CoopRules.ExecuteProposal(NationalSpire.Coop.CoopWorld, NationalSpire.Coop.CoopProposal, System.Collections.Generic.IReadOnlySet<string>)`](Coop/CoopRules.cs.md#symbol-fecbe30f550e)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.CareerData.Journey`；`NationalSpire.EventJourney.Destination`；`NationalSpire.EventJourney.PausedDay`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `data.Journey.Destination` = `0`
- `data.Journey.Destination` = `destination`
- `data.Journey.PausedDay` = `data.Day`
