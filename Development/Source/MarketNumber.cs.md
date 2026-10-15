# MarketNumber.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`36B3E73CD5FE0CF375555697DBB7FC2D7DE77CB6B36C738E2FBC4EAA79D82F2D`。来源：[源码](../../MarketNumber.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.MarketNumber`、`NationalSpire.MarketNumberConverter`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly BigInteger Scale = BigInteger.Pow(10, 28);
private readonly BigInteger value;
```

<a id="symbol-84f74dcc6239"></a>

## `NationalSpire.MarketNumber.MarketNumber(System.Numerics.BigInteger) — private MarketNumber(BigInteger scaled)`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketNumber.implicit operator NationalSpire.MarketNumber(decimal)`](MarketNumber.cs.md#symbol-6f3343e45b7c)；[`NationalSpire.MarketNumber.operator -(NationalSpire.MarketNumber, NationalSpire.MarketNumber)`](MarketNumber.cs.md#symbol-9eb51e04bd9b)；[`NationalSpire.MarketNumber.operator -(NationalSpire.MarketNumber)`](MarketNumber.cs.md#symbol-7b14bc2067f9)；[`NationalSpire.MarketNumber.operator *(NationalSpire.MarketNumber, NationalSpire.MarketNumber)`](MarketNumber.cs.md#symbol-dfe5a007f1e3)；[`NationalSpire.MarketNumber.operator /(NationalSpire.MarketNumber, NationalSpire.MarketNumber)`](MarketNumber.cs.md#symbol-fb2c51db513d)；[`NationalSpire.MarketNumber.operator +(NationalSpire.MarketNumber, NationalSpire.MarketNumber)`](MarketNumber.cs.md#symbol-03408c8b8cb9)；[`NationalSpire.MarketNumber.Parse(string)`](MarketNumber.cs.md#symbol-fd06b4e8340e)；[`NationalSpire.MarketNumber.Round(NationalSpire.MarketNumber, int)`](MarketNumber.cs.md#symbol-a3385d50f19f)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.MarketNumber.value`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `value` = `scaled`

<a id="symbol-6f3343e45b7c"></a>

## `NationalSpire.MarketNumber.implicit operator NationalSpire.MarketNumber(decimal) — public static implicit operator MarketNumber(decimal number)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.MarketNumber.MarketNumber(System.Numerics.BigInteger)`](MarketNumber.cs.md#symbol-84f74dcc6239)；`decimal.GetBits(decimal)`；`System.Numerics.BigInteger.Pow(System.Numerics.BigInteger, int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.GetBits(decimal)`；输入表达式：`decimal.GetBits(number)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = decimal.GetBits(number)`
- `NationalSpire.MarketNumber.MarketNumber(System.Numerics.BigInteger)`；输入表达式：`new(bits[3] < 0 ? -integer : integer)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(bits[3] < 0 ? -integer : integer);`
- `System.Numerics.BigInteger.Pow(System.Numerics.BigInteger, int)`；输入表达式：`BigInteger.Pow(10, 28 - ((bits[3] >> 16) & 255))`；返回值紧邻使用处：`AssignmentExpressionSyntax: integer *= BigInteger.Pow(10, 28 - ((bits[3] >> 16) & 255))`

**赋值（含属性/字段和局部值）：**

- `integer` *= `BigInteger.Pow(10, 28 - ((bits[3] >> 16) & 255))`

<a id="symbol-dcdb9de32f94"></a>

## `NationalSpire.MarketNumber.explicit operator decimal(NationalSpire.MarketNumber) — public static explicit operator decimal(MarketNumber number)`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.MarketNumber.ToString()`](MarketNumber.cs.md#symbol-b93eea41cb69)；`decimal.Parse(string, System.Globalization.NumberStyles, System.IFormatProvider?)`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketNumber.ToString()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.Parse(string, System.Globalization.NumberStyles, System.IFormatProvider?)`；输入表达式：`decimal.Parse(number.ToString(), NumberStyles.Number, CultureInfo.InvariantCulture)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => decimal.Parse(number.ToString(), NumberStyles.Number, CultureInfo.InvariantCulture)`
- `NationalSpire.MarketNumber.ToString()`；输入表达式：`number.ToString()`；返回值紧邻使用处：`ArgumentSyntax: number.ToString()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-264af5995242"></a>

## `NationalSpire.MarketNumber.explicit operator double(NationalSpire.MarketNumber) — public static explicit operator double(MarketNumber number)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.MarketNumber.Scale`；`NationalSpire.MarketNumber.value`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-03408c8b8cb9"></a>

## `NationalSpire.MarketNumber.operator +(NationalSpire.MarketNumber, NationalSpire.MarketNumber) — public static MarketNumber operator +(MarketNumber a, MarketNumber b)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.MarketNumber.MarketNumber(System.Numerics.BigInteger)`](MarketNumber.cs.md#symbol-84f74dcc6239)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketNumber.value`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketNumber.MarketNumber(System.Numerics.BigInteger)`；输入表达式：`new(a.value + b.value)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new(a.value + b.value)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9eb51e04bd9b"></a>

## `NationalSpire.MarketNumber.operator -(NationalSpire.MarketNumber, NationalSpire.MarketNumber) — public static MarketNumber operator -(MarketNumber a, MarketNumber b)`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.MarketNumber.MarketNumber(System.Numerics.BigInteger)`](MarketNumber.cs.md#symbol-84f74dcc6239)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketNumber.value`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketNumber.MarketNumber(System.Numerics.BigInteger)`；输入表达式：`new(a.value - b.value)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new(a.value - b.value)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-7b14bc2067f9"></a>

## `NationalSpire.MarketNumber.operator -(NationalSpire.MarketNumber) — public static MarketNumber operator -(MarketNumber a)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.MarketNumber.MarketNumber(System.Numerics.BigInteger)`](MarketNumber.cs.md#symbol-84f74dcc6239)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketNumber.value`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketNumber.MarketNumber(System.Numerics.BigInteger)`；输入表达式：`new(-a.value)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new(-a.value)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-dfe5a007f1e3"></a>

## `NationalSpire.MarketNumber.operator *(NationalSpire.MarketNumber, NationalSpire.MarketNumber) — public static MarketNumber operator *(MarketNumber a, MarketNumber b)`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.MarketNumber.MarketNumber(System.Numerics.BigInteger)`](MarketNumber.cs.md#symbol-84f74dcc6239)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketNumber.Scale`；`NationalSpire.MarketNumber.value`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketNumber.MarketNumber(System.Numerics.BigInteger)`；输入表达式：`new(a.value * b.value / Scale)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new(a.value * b.value / Scale)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fb2c51db513d"></a>

## `NationalSpire.MarketNumber.operator /(NationalSpire.MarketNumber, NationalSpire.MarketNumber) — public static MarketNumber operator /(MarketNumber a, MarketNumber b)`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.MarketNumber.MarketNumber(System.Numerics.BigInteger)`](MarketNumber.cs.md#symbol-84f74dcc6239)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketNumber.Scale`；`NationalSpire.MarketNumber.value`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketNumber.MarketNumber(System.Numerics.BigInteger)`；输入表达式：`new(a.value * Scale / b.value)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new(a.value * Scale / b.value)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5c00a32a9f57"></a>

## `NationalSpire.MarketNumber.operator <(NationalSpire.MarketNumber, NationalSpire.MarketNumber) — public static bool operator <(MarketNumber a, MarketNumber b)`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.MarketNumber.value`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-829acc79062b"></a>

## `NationalSpire.MarketNumber.operator >(NationalSpire.MarketNumber, NationalSpire.MarketNumber) — public static bool operator >(MarketNumber a, MarketNumber b)`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.MarketNumber.value`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3f25249fd803"></a>

## `NationalSpire.MarketNumber.operator <=(NationalSpire.MarketNumber, NationalSpire.MarketNumber) — public static bool operator <=(MarketNumber a, MarketNumber b)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.MarketNumber.value`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3599131398e8"></a>

## `NationalSpire.MarketNumber.operator >=(NationalSpire.MarketNumber, NationalSpire.MarketNumber) — public static bool operator >=(MarketNumber a, MarketNumber b)`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.MarketNumber.value`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6c15326debf0"></a>

## `NationalSpire.MarketNumber.CompareTo(NationalSpire.MarketNumber) — public int CompareTo(MarketNumber other)`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Numerics.BigInteger.CompareTo(System.Numerics.BigInteger)`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketNumber.value`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Numerics.BigInteger.CompareTo(System.Numerics.BigInteger)`；输入表达式：`value.CompareTo(other.value)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => value.CompareTo(other.value)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0cf4c87609b0"></a>

## `NationalSpire.MarketNumber.Max(NationalSpire.MarketNumber, NationalSpire.MarketNumber) — public static MarketNumber Max(MarketNumber a, MarketNumber b)`

来源：源码第 35 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-2508c79f1fc5)；[`NationalSpire.MarketExecution.Used(NationalSpire.MarketQuote, int)`](MarketExecution.cs.md#symbol-722e0831cb22)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a3385d50f19f"></a>

## `NationalSpire.MarketNumber.Round(NationalSpire.MarketNumber, int) — public static MarketNumber Round(MarketNumber number, int digits)`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketExecution.Close(NationalSpire.MarketPosition, NationalSpire.MarketQuote)`](MarketExecution.cs.md#symbol-2508c79f1fc5)；[`NationalSpire.MarketNumber.ToString(string?)`](MarketNumber.cs.md#symbol-0137dc156117)

**调用：** [`NationalSpire.MarketNumber.MarketNumber(System.Numerics.BigInteger)`](MarketNumber.cs.md#symbol-84f74dcc6239)；`System.Numerics.BigInteger.Abs(System.Numerics.BigInteger)`；`System.Numerics.BigInteger.CompareTo(System.Numerics.BigInteger)`；`System.Numerics.BigInteger.DivRem(System.Numerics.BigInteger, System.Numerics.BigInteger, out System.Numerics.BigInteger)`；`System.Numerics.BigInteger.Pow(System.Numerics.BigInteger, int)`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketNumber.value`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketNumber.MarketNumber(System.Numerics.BigInteger)`；输入表达式：`new(whole * step)`；返回值紧邻使用处：`ReturnStatementSyntax: return new(whole * step);`
- `System.Numerics.BigInteger.Abs(System.Numerics.BigInteger)`；输入表达式：`BigInteger.Abs(rest)`；返回值紧邻使用处：`BinaryExpressionSyntax: BigInteger.Abs(rest) * 2`
- `System.Numerics.BigInteger.CompareTo(System.Numerics.BigInteger)`；输入表达式：`(BigInteger.Abs(rest) * 2).CompareTo(step)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = (BigInteger.Abs(rest) * 2).CompareTo(step)`
- `System.Numerics.BigInteger.DivRem(System.Numerics.BigInteger, System.Numerics.BigInteger, out System.Numerics.BigInteger)`；输入表达式：`BigInteger.DivRem(number.value, step, out var rest)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = BigInteger.DivRem(number.value, step, out var rest)`
- `System.Numerics.BigInteger.Pow(System.Numerics.BigInteger, int)`；输入表达式：`BigInteger.Pow(10, 28 - digits)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = BigInteger.Pow(10, 28 - digits)`

**赋值（含属性/字段和局部值）：**

- `whole` += `number.value.Sign`

<a id="symbol-b93eea41cb69"></a>

## `NationalSpire.MarketNumber.ToString() — public override string ToString()`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketNumber.explicit operator decimal(NationalSpire.MarketNumber)`](MarketNumber.cs.md#symbol-dcdb9de32f94)；[`NationalSpire.MarketNumberConverter.Write(System.Text.Json.Utf8JsonWriter, NationalSpire.MarketNumber, System.Text.Json.JsonSerializerOptions)`](MarketNumber.cs.md#symbol-648483dc02ac)

**调用：** [`NationalSpire.MarketNumber.ToString(string?)`](MarketNumber.cs.md#symbol-0137dc156117)

**字段、属性、事件及方法组引用：** `NationalSpire.MarketNumber.ToString(string?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketNumber.ToString(string?)`；输入表达式：`ToString(null)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => ToString(null)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0137dc156117"></a>

## `NationalSpire.MarketNumber.ToString(string?) — public string ToString(string? format)`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Leverage(NationalSpire.MarketNumber)`](MarketVisuals.cs.md#symbol-4e2f52b03c4f)；[`NationalSpire.CareerMoney.Compact(NationalSpire.MarketNumber)`](LifeData.cs.md#symbol-9439f9696cab)；[`NationalSpire.CareerMoney.Format(NationalSpire.MarketNumber)`](LifeData.cs.md#symbol-c64f7b9abf31)；[`NationalSpire.MarketNumber.ToString()`](MarketNumber.cs.md#symbol-b93eea41cb69)

**调用：** [`NationalSpire.MarketNumber.Round(NationalSpire.MarketNumber, int)`](MarketNumber.cs.md#symbol-a3385d50f19f)；`string.Contains(char)`；`string.Contains(string)`；`string.TrimEnd(char)`；`System.Numerics.BigInteger.Abs(System.Numerics.BigInteger)`；`System.Numerics.BigInteger.DivRem(System.Numerics.BigInteger, System.Numerics.BigInteger, out System.Numerics.BigInteger)`；`System.Numerics.BigInteger.ToString(string?, System.IFormatProvider?)`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketNumber.Round(NationalSpire.MarketNumber, int)`；`NationalSpire.MarketNumber.Scale`；`NationalSpire.MarketNumber.value`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketNumber.Round(NationalSpire.MarketNumber, int)`；输入表达式：`Round(this, format.Contains(".##") ? 2 : 0)`；返回值紧邻使用处：`ConditionalExpressionSyntax: format == null ? this : Round(this, format.Contains(".##") ? 2 : 0)`
- `string.Contains(char)`；输入表达式：`.Contains(',')`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: format?.Contains(',')`
- `string.Contains(string)`；输入表达式：`format.Contains(".##")`；返回值紧邻使用处：`ConditionalExpressionSyntax: format.Contains(".##") ? 2 : 0`
- `string.TrimEnd(char)`；输入表达式：`fraction.ToString("D28", CultureInfo.InvariantCulture).TrimEnd('0')`；返回值紧邻使用处：`BinaryExpressionSyntax: "." + fraction.ToString("D28", CultureInfo.InvariantCulture).TrimEnd('0')`
- `System.Numerics.BigInteger.Abs(System.Numerics.BigInteger)`；输入表达式：`BigInteger.Abs(n.value)`；返回值紧邻使用处：`ArgumentSyntax: BigInteger.Abs(n.value)`
- `System.Numerics.BigInteger.DivRem(System.Numerics.BigInteger, System.Numerics.BigInteger, out System.Numerics.BigInteger)`；输入表达式：`BigInteger.DivRem(BigInteger.Abs(n.value), Scale, out var fraction)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = BigInteger.DivRem(BigInteger.Abs(n.value), Scale, out var fraction)`
- `System.Numerics.BigInteger.ToString(string?, System.IFormatProvider?)`；输入表达式：`fraction.ToString("D28", CultureInfo.InvariantCulture)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: fraction.ToString("D28", CultureInfo.InvariantCulture).TrimEnd`
- `System.Numerics.BigInteger.ToString(string?, System.IFormatProvider?)`；输入表达式：`integer.ToString(format?.Contains(',') == true ? "N0" : "D", CultureInfo.InvariantCulture)`；返回值紧邻使用处：`BinaryExpressionSyntax: (n.value.Sign < 0 ? "-" : "") + integer.ToString(format?.Contains(',') == true ? "N0" : "D", CultureInfo.InvariantCulture)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fd06b4e8340e"></a>

## `NationalSpire.MarketNumber.Parse(string) — public static MarketNumber Parse(string text)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketExecution.Root(NationalSpire.MarketNumber, int)`](MarketExecution.cs.md#symbol-614fd34b2cf6)；[`NationalSpire.MarketNumberConverter.Read(ref System.Text.Json.Utf8JsonReader, System.Type, System.Text.Json.JsonSerializerOptions)`](MarketNumber.cs.md#symbol-d9c48181e0d9)

**调用：** [`NationalSpire.MarketNumber.MarketNumber(System.Numerics.BigInteger)`](MarketNumber.cs.md#symbol-84f74dcc6239)；`int.Parse(string, System.IFormatProvider?)`；`string.IndexOf(char)`；`string.IndexOfAny(char[])`；`string.Replace(string, string?)`；`System.Numerics.BigInteger.Parse(string, System.IFormatProvider?)`；`System.Numerics.BigInteger.Pow(System.Numerics.BigInteger, int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `int.Parse(string, System.IFormatProvider?)`；输入表达式：`int.Parse(text[(exponentAt + 1)..], CultureInfo.InvariantCulture)`；返回值紧邻使用处：`ConditionalExpressionSyntax: exponentAt < 0 ? 0 : int.Parse(text[(exponentAt + 1)..], CultureInfo.InvariantCulture)`
- `NationalSpire.MarketNumber.MarketNumber(System.Numerics.BigInteger)`；输入表达式：`new(shift >= 0 ? integer * BigInteger.Pow(10, shift) : integer / BigInteger.Pow(10, -shift))`；返回值紧邻使用处：`ReturnStatementSyntax: return new(shift >= 0 ? integer * BigInteger.Pow(10, shift) : integer / BigInteger.Pow(10, -shift));`
- `string.IndexOf(char)`；输入表达式：`text.IndexOf('.')`；返回值紧邻使用处：`EqualsValueClauseSyntax: = text.IndexOf('.')`
- `string.IndexOfAny(char[])`；输入表达式：`text.IndexOfAny(['e', 'E'])`；返回值紧邻使用处：`EqualsValueClauseSyntax: = text.IndexOfAny(['e', 'E'])`
- `string.Replace(string, string?)`；输入表达式：`text.Replace(".", "")`；返回值紧邻使用处：`ArgumentSyntax: text.Replace(".", "")`
- `System.Numerics.BigInteger.Parse(string, System.IFormatProvider?)`；输入表达式：`BigInteger.Parse(text.Replace(".", ""), CultureInfo.InvariantCulture)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = BigInteger.Parse(text.Replace(".", ""), CultureInfo.InvariantCulture)`
- `System.Numerics.BigInteger.Pow(System.Numerics.BigInteger, int)`；输入表达式：`BigInteger.Pow(10, -shift)`；返回值紧邻使用处：`BinaryExpressionSyntax: integer / BigInteger.Pow(10, -shift)`
- `System.Numerics.BigInteger.Pow(System.Numerics.BigInteger, int)`；输入表达式：`BigInteger.Pow(10, shift)`；返回值紧邻使用处：`BinaryExpressionSyntax: integer * BigInteger.Pow(10, shift)`

**赋值（含属性/字段和局部值）：**

- `text` = `text[..exponentAt]`

<a id="symbol-d9c48181e0d9"></a>

## `NationalSpire.MarketNumberConverter.Read(ref System.Text.Json.Utf8JsonReader, System.Type, System.Text.Json.JsonSerializerOptions) — public override MarketNumber Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.MarketNumber.Parse(string)`](MarketNumber.cs.md#symbol-fd06b4e8340e)；`System.Text.Json.JsonDocument.ParseValue(ref System.Text.Json.Utf8JsonReader)`；`System.Text.Json.JsonElement.GetRawText()`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketNumber.Parse(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketNumber.Parse(string)`；输入表达式：`MarketNumber.Parse(document.RootElement.GetRawText())`；返回值紧邻使用处：`ReturnStatementSyntax: return MarketNumber.Parse(document.RootElement.GetRawText());`
- `System.Text.Json.JsonDocument.ParseValue(ref System.Text.Json.Utf8JsonReader)`；输入表达式：`JsonDocument.ParseValue(ref reader)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonDocument.ParseValue(ref reader)`
- `System.Text.Json.JsonElement.GetRawText()`；输入表达式：`document.RootElement.GetRawText()`；返回值紧邻使用处：`ArgumentSyntax: document.RootElement.GetRawText()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-648483dc02ac"></a>

## `NationalSpire.MarketNumberConverter.Write(System.Text.Json.Utf8JsonWriter, NationalSpire.MarketNumber, System.Text.Json.JsonSerializerOptions) — public override void Write(Utf8JsonWriter writer, MarketNumber value, JsonSerializerOptions options)`

来源：源码第 71 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.MarketNumber.ToString()`](MarketNumber.cs.md#symbol-b93eea41cb69)；`System.Text.Json.Utf8JsonWriter.WriteRawValue(string, bool)`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketNumber.ToString()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.MarketNumber.ToString()`；输入表达式：`value.ToString()`；返回值紧邻使用处：`ArgumentSyntax: value.ToString()`
- `System.Text.Json.Utf8JsonWriter.WriteRawValue(string, bool)`；输入表达式：`writer.WriteRawValue(value.ToString())`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => writer.WriteRawValue(value.ToString())`

**赋值（含属性/字段和局部值）：**
