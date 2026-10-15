# MarketAmountInput.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`A852ED6E2423312A83EBCD01C387550D91B1F641EB7A3495303CA2434B8C504A`。来源：[源码](../../MarketAmountInput.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.MarketAmountInput`。

字段、事件及初始值（源码原样）：

```csharp
private decimal? _entered;
```

<a id="symbol-d99439cef9c5"></a>

## `NationalSpire.MarketAmountInput.Amount — internal decimal Amount`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.MarketAmountInput._entered`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8bd963175996"></a>

## `NationalSpire.MarketAmountInput.MarketAmountInput() — internal MarketAmountInput()`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketTerminal.Money()`](MarketTerminal.cs.md#symbol-965685631592)

**调用：** `decimal.TryParse(string?, System.Globalization.NumberStyles, System.IFormatProvider?, out decimal)`；`Godot.SpinBox.GetLineEdit()`；`string.Trim()`；`string.TrimStart(char)`；`System.Math.Abs(double)`；`System.Math.BitIncrement(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketAmountInput._entered`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `decimal.TryParse(string?, System.Globalization.NumberStyles, System.IFormatProvider?, out decimal)`；输入表达式：`decimal.TryParse(text.Trim().TrimStart('$').Trim(), NumberStyles.Float | NumberStyles.AllowThousands,                 CultureInfo.InvariantCulture, out var amount)`；返回值紧邻使用处：`ConditionalExpressionSyntax: decimal.TryParse(text.Trim().TrimStart('$').Trim(), NumberStyles.Float | NumberStyles.AllowThousands,                 CultureInfo.InvariantCulture, out var amount) ? amount : null`
- `Godot.SpinBox.GetLineEdit()`；输入表达式：`GetLineEdit()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: GetLineEdit().TextChanged`
- `string.Trim()`；输入表达式：`text.Trim().TrimStart('$').Trim()`；返回值紧邻使用处：`ArgumentSyntax: text.Trim().TrimStart('$').Trim()`
- `string.Trim()`；输入表达式：`text.Trim()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.Trim().TrimStart`
- `string.TrimStart(char)`；输入表达式：`text.Trim().TrimStart('$')`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.Trim().TrimStart('$').Trim`
- `System.Math.Abs(double)`；输入表达式：`Math.Abs((double)entered - value)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.Abs((double)entered - value) > 4 * Math.Abs(Math.BitIncrement(value) - value)`
- `System.Math.Abs(double)`；输入表达式：`Math.Abs(Math.BitIncrement(value) - value)`；返回值紧邻使用处：`BinaryExpressionSyntax: 4 * Math.Abs(Math.BitIncrement(value) - value)`
- `System.Math.BitIncrement(double)`；输入表达式：`Math.BitIncrement(value)`；返回值紧邻使用处：`BinaryExpressionSyntax: Math.BitIncrement(value) - value`

**赋值（含属性/字段和局部值）：**

- `_entered` = `decimal.TryParse(text.Trim().TrimStart('$').Trim(), NumberStyles.Float | NumberStyles.AllowThousands,                 CultureInfo.InvariantCulture, out var amount) ? amount : null`
- `_entered` = `null`
- `GetLineEdit().TextChanged` += `text =>         {             _entered = decimal.TryParse(text.Trim().TrimStart('$').Trim(), NumberStyles.Float | NumberStyles.AllowThousands,                 CultureInfo.InvariantCulture, out var amount) ? amount : null;         }`
- `ValueChanged` += `value =>         {             // 原生步进会再次舍入浮点表示；仅据此识别控件是否换了数值，交易仍使用十进制原值。             if (_entered is { } entered && Math.Abs((double)entered - value) > 4 * Math.Abs(Math.BitIncrement(value) - value)) _entered = null;         }`

<a id="symbol-b73158988cf2"></a>

## `NationalSpire.MarketAmountInput.SetAmount(decimal) — internal void SetAmount(decimal amount)`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.MarketPositionCard.Edit(bool)`](MarketVisuals.cs.md#symbol-cbcb21a0a9e2)；[`NationalSpire.MarketTerminal.RefreshFee()`](MarketTerminal.cs.md#symbol-1c08f523080f)

**调用：** `Godot.Range.SetValueNoSignal(double)`

**字段、属性、事件及方法组引用：** `NationalSpire.MarketAmountInput._entered`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Range.SetValueNoSignal(double)`；输入表达式：`SetValueNoSignal((double)amount)`；返回值紧邻使用处：`ExpressionStatementSyntax: SetValueNoSignal((double)amount);`

**赋值（含属性/字段和局部值）：**

- `_entered` = `amount`
