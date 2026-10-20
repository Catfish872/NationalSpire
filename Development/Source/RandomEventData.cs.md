# RandomEventData.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`9907811B72019B26E1CE9F280E7D3EC1B009BBA6DE8A3B51215A49574B734E94`。来源：[源码](../../RandomEventData.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.EventLive`、`NationalSpire.RandomEventRecord`、`NationalSpire.RandomEventOption`、`NationalSpire.EventStatus`、`NationalSpire.RandomEventParser`。

字段、事件及初始值（源码原样）：

```csharp
private readonly StringBuilder _pending = new();
```

<a id="symbol-83081ac00583"></a>

## `NationalSpire.EventLive.Choices — public List<RandomEventOption> Choices`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ffa016efc1e3"></a>

## `NationalSpire.EventLive.Reasoning — public string Reasoning`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4f3cf4147a04"></a>

## `NationalSpire.EventLive.Phase — public string Phase`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-37fa8a35d371"></a>

## `NationalSpire.RandomEventRecord.Id — public string Id`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Guid.NewGuid()`；`System.Guid.ToString(string?)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Guid.NewGuid()`；输入表达式：`Guid.NewGuid()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Guid.NewGuid().ToString`
- `System.Guid.ToString(string?)`；输入表达式：`Guid.NewGuid().ToString("N")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Guid.NewGuid().ToString("N")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-8501594fdc90"></a>

## `NationalSpire.RandomEventRecord.Day — public int Day`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7b534cce4974"></a>

## `NationalSpire.RandomEventRecord.State — public string State`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ddb07048a599"></a>

## `NationalSpire.RandomEventRecord.Seed — public string Seed`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ee7527272998"></a>

## `NationalSpire.RandomEventRecord.Category — public string Category`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-669de52aa824"></a>

## `NationalSpire.RandomEventRecord.People — public List<string> People`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-083d5672b414"></a>

## `NationalSpire.RandomEventRecord.Materials — public string Materials`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9094ca155c3e"></a>

## `NationalSpire.RandomEventRecord.Title — public string Title`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-853af1f137e3"></a>

## `NationalSpire.RandomEventRecord.Story — public string Story`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-e6573599abb5"></a>

## `NationalSpire.RandomEventRecord.Reasoning — public string Reasoning`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9ed8dd5fcd15"></a>

## `NationalSpire.RandomEventRecord.Options — public List<RandomEventOption> Options`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-216fa6a52d4b"></a>

## `NationalSpire.RandomEventRecord.Error — public string Error`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a5a7f36885ee"></a>

## `NationalSpire.RandomEventRecord.Selected — public int Selected`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2984805c28fc"></a>

## `NationalSpire.RandomEventRecord.Public — public bool Public`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3fe324b904b7"></a>

## `NationalSpire.RandomEventRecord.MatchIds — public List<string> MatchIds`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-76421ffa2563"></a>

## `NationalSpire.RandomEventRecord.RememberedMatches — public HashSet<string> RememberedMatches`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-480c348e646f"></a>

## `NationalSpire.RandomEventOption.Text — public string Text`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8db682f238f7"></a>

## `NationalSpire.RandomEventOption.Result — public string Result`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f3156a03ae79"></a>

## `NationalSpire.RandomEventOption.Effects — public List<Dictionary<string, JsonElement>> Effects`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9670f1e38e01"></a>

## `NationalSpire.EventStatus.Source — public string Source`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9163414d57a7"></a>

## `NationalSpire.EventStatus.Name — public string Name`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-79d4f013463c"></a>

## `NationalSpire.EventStatus.Until — public int Until`

来源：源码第 42 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7f8d47d7e7d6"></a>

## `NationalSpire.EventStatus.Percent — public double Percent`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ed2ed003f2f0"></a>

## `NationalSpire.RandomEventParser.Title — public string Title`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-13dddf40a967"></a>

## `NationalSpire.RandomEventParser.Story — public string Story`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a01ebfa91fa0"></a>

## `NationalSpire.RandomEventParser.Options — public List<RandomEventOption> Options`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4cd2ab5bd045"></a>

## `NationalSpire.RandomEventParser.LiveStory — public string LiveStory`

来源：源码第 53 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.RandomEventParser.PartialStory(string)`](RandomEventData.cs.md#symbol-6e459546dad0)；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.RandomEventParser._pending`；`NationalSpire.RandomEventParser.PartialStory(string)`；`NationalSpire.RandomEventParser.Story`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RandomEventParser.PartialStory(string)`；输入表达式：`PartialStory(_pending.ToString())`；返回值紧邻使用处：`BinaryExpressionSyntax: Story + PartialStory(_pending.ToString())`
- `System.Text.StringBuilder.ToString()`；输入表达式：`_pending.ToString()`；返回值紧邻使用处：`ArgumentSyntax: _pending.ToString()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-af55d7453f88"></a>

## `NationalSpire.RandomEventParser.Feed(string) — public void Feed(string chunk)`

来源：源码第 54 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ApplyTestResponse(NationalSpire.CareerData, NationalSpire.PromptTestSession, string)`](PromptTesting.cs.md#symbol-7208c4c08018)；[`NationalSpire.AiService.ProcessEventAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<NationalSpire.EventLive>?)`](AiRandomEvents.cs.md#symbol-5705d03a72b3)

**调用：** [`NationalSpire.RandomEventParser.Read(string)`](RandomEventData.cs.md#symbol-9db7444c33da)；`System.Text.StringBuilder.Append(char)`；`System.Text.StringBuilder.Clear()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.RandomEventParser._pending`；`NationalSpire.RandomEventParser.Read(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RandomEventParser.Read(string)`；输入表达式：`Read(_pending.ToString())`；返回值紧邻使用处：`ExpressionStatementSyntax: Read(_pending.ToString());`
- `System.Text.StringBuilder.Append(char)`；输入表达式：`_pending.Append(ch)`；返回值紧邻使用处：`ExpressionStatementSyntax: _pending.Append(ch);`
- `System.Text.StringBuilder.Clear()`；输入表达式：`_pending.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _pending.Clear();`
- `System.Text.StringBuilder.ToString()`；输入表达式：`_pending.ToString()`；返回值紧邻使用处：`ArgumentSyntax: _pending.ToString()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9fff6310dec5"></a>

## `NationalSpire.RandomEventParser.Finish() — public void Finish()`

来源：源码第 59 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ApplyTestResponse(NationalSpire.CareerData, NationalSpire.PromptTestSession, string)`](PromptTesting.cs.md#symbol-7208c4c08018)；[`NationalSpire.AiService.ProcessEventAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<NationalSpire.EventLive>?)`](AiRandomEvents.cs.md#symbol-5705d03a72b3)

**调用：** [`NationalSpire.RandomEventParser.Read(string)`](RandomEventData.cs.md#symbol-9db7444c33da)；`System.Text.StringBuilder.Clear()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.RandomEventParser._pending`；`NationalSpire.RandomEventParser.Read(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RandomEventParser.Read(string)`；输入表达式：`Read(_pending.ToString())`；返回值紧邻使用处：`ExpressionStatementSyntax: Read(_pending.ToString());`
- `System.Text.StringBuilder.Clear()`；输入表达式：`_pending.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _pending.Clear();`
- `System.Text.StringBuilder.ToString()`；输入表达式：`_pending.ToString()`；返回值紧邻使用处：`ArgumentSyntax: _pending.ToString()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-39c0a466ac58"></a>

## `NationalSpire.RandomEventParser.Validate() — public void Validate()`

来源：源码第 60 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ApplyTestResponse(NationalSpire.CareerData, NationalSpire.PromptTestSession, string)`](PromptTesting.cs.md#symbol-7208c4c08018)；[`NationalSpire.AiService.ProcessEventAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<NationalSpire.EventLive>?)`](AiRandomEvents.cs.md#symbol-5705d03a72b3)

**调用：** `string.Trim()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.IO.InvalidDataException.InvalidDataException(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.RandomEventOption.Result`；`NationalSpire.RandomEventOption.Text`；`NationalSpire.RandomEventParser.Options`；`NationalSpire.RandomEventParser.Story`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Trim()`；输入表达式：`Story.Trim()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Story.Trim().Length`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`Options.Any(o => o.Text.Length == 0 || o.Result.Length == 0)`；返回值紧邻使用处：`BinaryExpressionSyntax: Story.Trim().Length == 0 || Options.Count is < 2 or > 4 || Options.Any(o => o.Text.Length == 0 || o.Result.Length == 0)`
- `System.IO.InvalidDataException.InvalidDataException(string?)`；输入表达式：`new InvalidDataException("故事或结局尚未完整生成，可以重试或跳过。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidDataException("故事或结局尚未完整生成，可以重试或跳过。");`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9db7444c33da"></a>

## `NationalSpire.RandomEventParser.Read(string) — private void Read(string line)`

来源：源码第 65 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.RandomEventParser.Feed(string)`](RandomEventData.cs.md#symbol-af55d7453f88)；[`NationalSpire.RandomEventParser.Finish()`](RandomEventData.cs.md#symbol-9fff6310dec5)

**调用：** `NationalSpire.RandomEventOption.RandomEventOption()`；`string.StartsWith(string)`；`string.Trim()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；`System.Text.Json.JsonElement.GetProperty(string)`；`System.Text.Json.JsonElement.GetRawText()`；`System.Text.Json.JsonElement.GetString()`；`System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；`System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.RandomEventOption.Effects`；`NationalSpire.RandomEventOption.Result`；`NationalSpire.RandomEventOption.Text`；`NationalSpire.RandomEventParser.Options`；`NationalSpire.RandomEventParser.Story`；`NationalSpire.RandomEventParser.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.RandomEventOption.RandomEventOption()`；输入表达式：`new()          {              Text = option.GetString() ?? "", Result = root.GetProperty("result").GetString() ?? "",              Effects = root.TryGetProperty("effects", out var effects) ? JsonSerializer.Deserialize<List<Dictionary<string, JsonElement>>>(effects.GetRawText()) ?? [] : []          }`；返回值紧邻使用处：`ArgumentSyntax: new()          {              Text = option.GetString() ?? "", Result = root.GetProperty("result").GetString() ?? "",              Effects = root.TryGetProperty("effects", out var effects) ? JsonSerializer.Deserialize<List<Dictionary<string, JsonElement>>>(effects.GetRawText()) ?? [] : []          }`
- `string.StartsWith(string)`；输入表达式：`line.StartsWith("```")`；返回值紧邻使用处：`BinaryExpressionSyntax: line.Length == 0 || line.StartsWith("```")`
- `string.Trim()`；输入表达式：`line.Trim()`；返回值紧邻使用处：`AssignmentExpressionSyntax: line = line.Trim()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`Options.Add(new()          {              Text = option.GetString() ?? "", Result = root.GetProperty("result").GetString() ?? "",              Effects = root.TryGetProperty("effects", out var effects) ? JsonSerializer.Deserialize<List<Dictionary<string, JsonElement>>>(effects.GetRawText()) ?? [] : []          })`；返回值紧邻使用处：`ExpressionStatementSyntax: Options.Add(new()          {              Text = option.GetString() ?? "", Result = root.GetProperty("result").GetString() ?? "",              Effects = root.TryGetProperty("effects", out var effects) ? JsonSerializer.Deserialize<List<Dictionary<string, JsonElement>>>(effects.GetRawText()) ?? [] : []          });`
- `System.Text.Json.JsonDocument.Parse(string, System.Text.Json.JsonDocumentOptions)`；输入表达式：`JsonDocument.Parse(line)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonDocument.Parse(line)`
- `System.Text.Json.JsonElement.GetProperty(string)`；输入表达式：`root.GetProperty("result")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: root.GetProperty("result").GetString`
- `System.Text.Json.JsonElement.GetRawText()`；输入表达式：`effects.GetRawText()`；返回值紧邻使用处：`ArgumentSyntax: effects.GetRawText()`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`option.GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: option.GetString() ?? ""`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`root.GetProperty("result").GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: root.GetProperty("result").GetString() ?? ""`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`story.GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: story.GetString() ?? ""`
- `System.Text.Json.JsonElement.GetString()`；输入表达式：`title.GetString()`；返回值紧邻使用处：`BinaryExpressionSyntax: title.GetString() ?? ""`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`root.TryGetProperty("effects", out var effects)`；返回值紧邻使用处：`ConditionalExpressionSyntax: root.TryGetProperty("effects", out var effects) ? JsonSerializer.Deserialize<List<Dictionary<string, JsonElement>>>(effects.GetRawText()) ?? [] : []`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`root.TryGetProperty("option", out var option)`；返回值紧邻使用处：`IfStatementSyntax: if (root.TryGetProperty("option", out var option)) Options.Add(new()          {              Text = option.GetString() ?? "", Result = root.GetProperty("result").GetString() ?? "",              Effects = root.TryGetProperty("effects", out var effects) ? JsonSerializer.Deserialize<List<Dictionary<string, JsonElement>>>(effects.GetRawText()) ?? [] : []          });`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`root.TryGetProperty("story", out var story)`；返回值紧邻使用处：`IfStatementSyntax: if (root.TryGetProperty("story", out var story)) Story += (story.GetString() ?? "") + "\n\n";`
- `System.Text.Json.JsonElement.TryGetProperty(string, out System.Text.Json.JsonElement)`；输入表达式：`root.TryGetProperty("title", out var title)`；返回值紧邻使用处：`IfStatementSyntax: if (root.TryGetProperty("title", out var title)) Title = title.GetString() ?? "";`
- `System.Text.Json.JsonSerializer.Deserialize<TValue>(string, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Deserialize<List<Dictionary<string, JsonElement>>>(effects.GetRawText())`；返回值紧邻使用处：`BinaryExpressionSyntax: JsonSerializer.Deserialize<List<Dictionary<string, JsonElement>>>(effects.GetRawText()) ?? []`

**赋值（含属性/字段和局部值）：**

- `Effects` = `root.TryGetProperty("effects", out var effects) ? JsonSerializer.Deserialize<List<Dictionary<string, JsonElement>>>(effects.GetRawText()) ?? [] : []`
- `line` = `line.Trim()`
- `Result` = `root.GetProperty("result").GetString() ?? ""`
- `Story` += `(story.GetString() ?? "") + "\n\n"`
- `Text` = `option.GetString() ?? ""`
- `Title` = `title.GetString() ?? ""`

<a id="symbol-6e459546dad0"></a>

## `NationalSpire.RandomEventParser.PartialStory(string) — private static string PartialStory(string text)`

来源：源码第 77 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.RandomEventParser.LiveStory`](RandomEventData.cs.md#symbol-4cd2ab5bd045)

**调用：** `string?.AsSpan(int, int)`；`string.IndexOf(char, int)`；`string.IndexOf(string, System.StringComparison)`；`System.Text.StringBuilder.Append(char)`；`System.Text.StringBuilder.StringBuilder()`；`System.Text.StringBuilder.ToString()`；`ushort.TryParse(System.ReadOnlySpan<char>, System.Globalization.NumberStyles, System.IFormatProvider?, out ushort)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string?.AsSpan(int, int)`；输入表达式：`text.AsSpan(i + 1, 4)`；返回值紧邻使用处：`ArgumentSyntax: text.AsSpan(i + 1, 4)`
- `string.IndexOf(char, int)`；输入表达式：`text.IndexOf(':', key + 7)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = text.IndexOf(':', key + 7)`
- `string.IndexOf(char, int)`；输入表达式：`text.IndexOf('"', colon + 1)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = text.IndexOf('"', colon + 1)`
- `string.IndexOf(string, System.StringComparison)`；输入表达式：`text.IndexOf("\"story\"", StringComparison.Ordinal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = text.IndexOf("\"story\"", StringComparison.Ordinal)`
- `System.Text.StringBuilder.Append(char)`；输入表达式：`result.Append((char)unicode)`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Append((char)unicode);`
- `System.Text.StringBuilder.Append(char)`；输入表达式：`result.Append(ch)`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Append(ch);`
- `System.Text.StringBuilder.StringBuilder()`；输入表达式：`new StringBuilder()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StringBuilder()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`result.ToString()`；返回值紧邻使用处：`ReturnStatementSyntax: return result.ToString();`
- `ushort.TryParse(System.ReadOnlySpan<char>, System.Globalization.NumberStyles, System.IFormatProvider?, out ushort)`；输入表达式：`ushort.TryParse(text.AsSpan(i + 1, 4), System.Globalization.NumberStyles.HexNumber, null, out ushort unicode)`；返回值紧邻使用处：`IfStatementSyntax: if (ushort.TryParse(text.AsSpan(i + 1, 4), System.Globalization.NumberStyles.HexNumber, null, out ushort unicode)) result.Append((char)unicode);`

**赋值（含属性/字段和局部值）：**

- `ch` = `ch switch { 'n' => '\n', 'r' => '\r', 't' => '\t', _ => ch }`
- `ch` = `text[i]`
- `i` += `4`
