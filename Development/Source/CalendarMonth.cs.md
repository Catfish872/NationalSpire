# CalendarMonth.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`3CC4D637509A95FFF12B8C7DF8DFCCD45D2EB50CFEFA1504FE9A50769986A938`。来源：[源码](../../CalendarMonth.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CalendarMonth`。

字段、事件及初始值（源码原样）：

```csharp
internal const int Slots = 35;
```

<a id="symbol-7866642fdd1c"></a>

## `NationalSpire.CalendarMonth.First(System.DateOnly) — private static DateOnly First(DateOnly date)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CalendarMonth.GridStart(System.DateOnly)`](CalendarMonth.cs.md#symbol-9c0d6943fe74)；[`NationalSpire.CalendarMonth.Owner(System.DateOnly)`](CalendarMonth.cs.md#symbol-94d3db2afd40)

**调用：** `System.DateOnly.DateOnly(int, int, int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.DateOnly.DateOnly(int, int, int)`；输入表达式：`new(date.Year,date.Month,1)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new(date.Year,date.Month,1)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-47600cada58a"></a>

## `NationalSpire.CalendarMonth.Offset(System.DateOnly) — private static int Offset(DateOnly first)`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CalendarMonth.GridStart(System.DateOnly)`](CalendarMonth.cs.md#symbol-9c0d6943fe74)；[`NationalSpire.CalendarMonth.MoveFirstWeek(System.DateOnly)`](CalendarMonth.cs.md#symbol-d95d8b0f92db)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d95d8b0f92db"></a>

## `NationalSpire.CalendarMonth.MoveFirstWeek(System.DateOnly) — private static bool MoveFirstWeek(DateOnly first)`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CalendarMonth.GridStart(System.DateOnly)`](CalendarMonth.cs.md#symbol-9c0d6943fe74)

**调用：** [`NationalSpire.CalendarMonth.Offset(System.DateOnly)`](CalendarMonth.cs.md#symbol-47600cada58a)；`System.DateTime.DaysInMonth(int, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CalendarMonth.Offset(System.DateOnly)`；`NationalSpire.CalendarMonth.Slots`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CalendarMonth.Offset(System.DateOnly)`；输入表达式：`Offset(first)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =Offset(first)`
- `System.DateTime.DaysInMonth(int, int)`；输入表达式：`DateTime.DaysInMonth(first.Year,first.Month)`；返回值紧邻使用处：`BinaryExpressionSyntax: offset+DateTime.DaysInMonth(first.Year,first.Month)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9c0d6943fe74"></a>

## `NationalSpire.CalendarMonth.GridStart(System.DateOnly) — internal static DateOnly GridStart(DateOnly month)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CalendarMonth.Owner(System.DateOnly)`](CalendarMonth.cs.md#symbol-94d3db2afd40)；[`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)

**调用：** [`NationalSpire.CalendarMonth.First(System.DateOnly)`](CalendarMonth.cs.md#symbol-7866642fdd1c)；[`NationalSpire.CalendarMonth.MoveFirstWeek(System.DateOnly)`](CalendarMonth.cs.md#symbol-d95d8b0f92db)；[`NationalSpire.CalendarMonth.Offset(System.DateOnly)`](CalendarMonth.cs.md#symbol-47600cada58a)；`System.DateOnly.AddDays(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CalendarMonth.First(System.DateOnly)`；`NationalSpire.CalendarMonth.MoveFirstWeek(System.DateOnly)`；`NationalSpire.CalendarMonth.Offset(System.DateOnly)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CalendarMonth.First(System.DateOnly)`；输入表达式：`First(month)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =First(month)`
- `NationalSpire.CalendarMonth.MoveFirstWeek(System.DateOnly)`；输入表达式：`MoveFirstWeek(first)`；返回值紧邻使用处：`ConditionalExpressionSyntax: MoveFirstWeek(first) ? 7 : 0`
- `NationalSpire.CalendarMonth.Offset(System.DateOnly)`；输入表达式：`Offset(first)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: -Offset(first)`
- `System.DateOnly.AddDays(int)`；输入表达式：`first.AddDays(-Offset(first)+(MoveFirstWeek(first) ? 7 : 0))`；返回值紧邻使用处：`ReturnStatementSyntax: return first.AddDays(-Offset(first)+(MoveFirstWeek(first) ? 7 : 0));`

**赋值（含属性/字段和局部值）：**


<a id="symbol-94d3db2afd40"></a>

## `NationalSpire.CalendarMonth.Owner(System.DateOnly) — internal static DateOnly Owner(DateOnly date)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.Calendar(NationalSpire.CareerData)`](CareerScreen.cs.md#symbol-a96caa224878)；[`NationalSpire.CareerScreen.OpenCalendarDay(int)`](CalendarPlansScreen.cs.md#symbol-d6b7c872ea02)

**调用：** [`NationalSpire.CalendarMonth.First(System.DateOnly)`](CalendarMonth.cs.md#symbol-7866642fdd1c)；[`NationalSpire.CalendarMonth.GridStart(System.DateOnly)`](CalendarMonth.cs.md#symbol-9c0d6943fe74)；`System.DateOnly.AddMonths(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CalendarMonth.First(System.DateOnly)`；`NationalSpire.CalendarMonth.GridStart(System.DateOnly)`；`NationalSpire.CalendarMonth.Slots`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CalendarMonth.First(System.DateOnly)`；输入表达式：`First(date)`；返回值紧邻使用处：`EqualsValueClauseSyntax: =First(date)`
- `NationalSpire.CalendarMonth.GridStart(System.DateOnly)`；输入表达式：`GridStart(first)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GridStart(first).DayNumber`
- `System.DateOnly.AddMonths(int)`；输入表达式：`first.AddMonths(-1)`；返回值紧邻使用处：`ConditionalExpressionSyntax: index<0 ? first.AddMonths(-1) : index>=Slots ? first.AddMonths(1) : first`
- `System.DateOnly.AddMonths(int)`；输入表达式：`first.AddMonths(1)`；返回值紧邻使用处：`ConditionalExpressionSyntax: index>=Slots ? first.AddMonths(1) : first`

**赋值（含属性/字段和局部值）：**


<a id="symbol-d00453206478"></a>

## `NationalSpire.CalendarMonth.Distance(System.DateOnly, System.DateOnly) — internal static int Distance(DateOnly from,DateOnly to)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenCalendarDay(int)`](CalendarPlansScreen.cs.md#symbol-d6b7c872ea02)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**
