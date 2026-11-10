# CareerScreenExtensions.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`457C7288583CD803CBAF93A97C052F2779A6F6C78D154CEDD5EB1E5F41D30187`。来源：[源码](../../CareerScreenExtensions.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerScreen`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-26423eb2ae0f"></a>

## `NationalSpire.CareerScreen.ConfigureDateRequest(NationalSpire.DateSceneRequest) — protected virtual DateSceneRequest ConfigureDateRequest(DateSceneRequest request)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.SceneRequest(bool)`](DateSceneScreen.cs.md#symbol-277baf4e7cb8)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f968e93601dc"></a>

## `NationalSpire.CareerScreen.DateViewOpened() — protected virtual void DateViewOpened()`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-631ad8b01203"></a>

## `NationalSpire.CareerScreen.DateViewClosing() — protected virtual void DateViewClosing()`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ReleaseDateSceneView()`](DateSceneScreen.cs.md#symbol-ea637ecbc4b0)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6fae41a590eb"></a>

## `NationalSpire.CareerScreen.BeforeDateTick() — protected virtual bool BeforeDateTick()`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-476eceb6dba4"></a>

## `NationalSpire.CareerScreen.DateLineShown(NationalSpire.DateSceneLine, string?, int) — protected virtual void DateLineShown(DateSceneLine line, string? turn = null, int index = -1)`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AppendDateLine(NationalSpire.DateSceneLine)`](DateSceneScreen.cs.md#symbol-243385a70bb8)；[`NationalSpire.CareerScreen.ShowDateHistoryPage(bool)`](DateHistoryReplayScreen.cs.md#symbol-9cf8a8172aa4)；[`NationalSpire.CareerScreen.ShowDateLine()`](DateSceneScreen.cs.md#symbol-1580b0be190e)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a2e85e8c1bbb"></a>

## `NationalSpire.CareerScreen.DatePlaybackInterrupted(bool) — protected virtual void DatePlaybackInterrupted(bool clearWork = false)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ClearDateHistory()`](DateHistoryReplayScreen.cs.md#symbol-7d3932131466)；[`NationalSpire.CareerScreen.ConfirmDateHistoryInput()`](DateHistoryReplayScreen.cs.md#symbol-e9d44f3bf0bb)；[`NationalSpire.CareerScreen.JumpDateHistory(string)`](DateHistoryReplayScreen.cs.md#symbol-7a7ba1016ab5)；[`NationalSpire.CareerScreen.SendDateScene()`](DateSceneScreen.cs.md#symbol-b811d23c8af3)；[`NationalSpire.CareerScreen.ShowDateHistoryPage(bool)`](DateHistoryReplayScreen.cs.md#symbol-9cf8a8172aa4)；[`NationalSpire.CareerScreen.ShowDateLine()`](DateSceneScreen.cs.md#symbol-1580b0be190e)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4c2665ddc2cd"></a>

## `NationalSpire.CareerScreen.AddDateSettings(Godot.VBoxContainer) — protected virtual void AddDateSettings(VBoxContainer box)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateSceneSettings()`](DateSceneScreen.cs.md#symbol-0845ec2acab1)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-db34df2d56c6"></a>

## `NationalSpire.CareerScreen.OpenDateMemoryChoice(NationalSpire.CareerData, string, NationalSpire.DateSceneMemory) — protected virtual void OpenDateMemoryChoice(CareerData data, string person, DateSceneMemory memory)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.EnterDiaryMemory(NationalSpire.CareerData, string, NationalSpire.DateSceneMemory)`](DateDiaryScreen.cs.md#symbol-15d246c49d27)

**调用：** [`NationalSpire.CareerScreen.OpenDateMemory(NationalSpire.CareerData, string, NationalSpire.DateSceneMemory)`](DateSceneMemoryScreen.cs.md#symbol-5a8c8e2619a9)

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen.OpenDateMemory(NationalSpire.CareerData, string, NationalSpire.DateSceneMemory)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerScreen.OpenDateMemory(NationalSpire.CareerData, string, NationalSpire.DateSceneMemory)`；输入表达式：`OpenDateMemory(data, person, memory)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => OpenDateMemory(data, person, memory)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-bd56cbc47967"></a>

## `NationalSpire.CareerScreen.CreateDateMemoryPlayback(NationalSpire.CareerData, NationalSpire.DateSceneMemory) — protected virtual DateMemoryPlayback CreateDateMemoryPlayback(CareerData data, DateSceneMemory memory)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateMemory(NationalSpire.CareerData, string, NationalSpire.DateSceneMemory)`](DateSceneMemoryScreen.cs.md#symbol-5a8c8e2619a9)

**调用：** `NationalSpire.DateMemoryPlayback.DateMemoryPlayback()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerScreen._dialogOverlay`；`NationalSpire.DateMemoryPlayback.Blocked`；`NationalSpire.DateMemoryPlayback.Memory`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateMemoryPlayback.DateMemoryPlayback()`；输入表达式：`new() { Memory = memory, Blocked = () => _dialogOverlay != null }`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new() { Memory = memory, Blocked = () => _dialogOverlay != null }`

**赋值（含属性/字段和局部值）：**

- `Blocked` = `() => _dialogOverlay != null`
- `Memory` = `memory`
