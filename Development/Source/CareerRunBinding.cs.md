# CareerRunBinding.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`D622B6D27E02DCAFF6E5B8E6C0BF9BE40B5E38AB405718D0B04CDE8788E1069B`。来源：[源码](../../CareerRunBinding.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CareerRunBinding`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-33566aec03ac"></a>

## `NationalSpire.CareerRunBinding.SameSeed(string, string) — public static bool SameSeed(string expected, string actual)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerRunBinding.Find(NationalSpire.CareerData, string, string, int, int, bool, long?)`](CareerRunBinding.cs.md#symbol-814ae5a03226)

**调用：** `string.Equals(string?, string?, System.StringComparison)`；`string.IsNullOrEmpty(string?)`；`string.StartsWith(string, System.StringComparison)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Equals(string?, string?, System.StringComparison)`；输入表达式：`string.Equals(expected, actual, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`IfStatementSyntax: if (string.Equals(expected, actual, StringComparison.OrdinalIgnoreCase)) return true;`
- `string.Equals(string?, string?, System.StringComparison)`；输入表达式：`string.Equals(expected, actual[3..], StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: expected.StartsWith("NS", StringComparison.Ordinal) && actual.StartsWith("old", StringComparison.Ordinal)             && string.Equals(expected, actual[3..], StringComparison.OrdinalIgnoreCase)`
- `string.IsNullOrEmpty(string?)`；输入表达式：`string.IsNullOrEmpty(actual)`；返回值紧邻使用处：`BinaryExpressionSyntax: string.IsNullOrEmpty(expected) || string.IsNullOrEmpty(actual)`
- `string.IsNullOrEmpty(string?)`；输入表达式：`string.IsNullOrEmpty(expected)`；返回值紧邻使用处：`BinaryExpressionSyntax: string.IsNullOrEmpty(expected) || string.IsNullOrEmpty(actual)`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`actual.StartsWith("old", StringComparison.Ordinal)`；返回值紧邻使用处：`BinaryExpressionSyntax: expected.StartsWith("NS", StringComparison.Ordinal) && actual.StartsWith("old", StringComparison.Ordinal)`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`expected.StartsWith("NS", StringComparison.Ordinal)`；返回值紧邻使用处：`BinaryExpressionSyntax: expected.StartsWith("NS", StringComparison.Ordinal) && actual.StartsWith("old", StringComparison.Ordinal)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-814ae5a03226"></a>

## `NationalSpire.CareerRunBinding.Find(NationalSpire.CareerData, string, string, int, int, bool, long?) — public static CareerMatch? Find(CareerData data, string seed, string character, int ascension,         int playerCount, bool standard, long? startTime = null)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GameBridge.MatchesPending(NationalSpire.CareerData, MegaCrit.Sts2.Core.Runs.RunHistory)`](GameBridge.cs.md#symbol-87d1dc26f106)；[`NationalSpire.LiveRunBridge.Attach(MegaCrit.Sts2.Core.Nodes.NRun, MegaCrit.Sts2.Core.Runs.RunState)`](LiveRunBridge.cs.md#symbol-1af74b766122)

**调用：** [`NationalSpire.CareerRunBinding.SameSeed(string, string)`](CareerRunBinding.cs.md#symbol-33566aec03ac)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Matches`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.CareerData.PendingSince`；`NationalSpire.CareerData.SelectedAscension`；`NationalSpire.CareerData.SelectedCharacter`；`NationalSpire.CareerMatch.Id`；`NationalSpire.CareerMatch.Seed`；`NationalSpire.CareerMatch.Status`；`NationalSpire.CareerRunBinding.SameSeed(string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerRunBinding.SameSeed(string, string)`；输入表达式：`SameSeed(m.Seed, seed)`；返回值紧邻使用处：`BinaryExpressionSyntax: m.Id == data.PendingMatchId && m.Status == "待赛" && SameSeed(m.Seed, seed)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`data.Matches.FirstOrDefault(m => m.Id == data.PendingMatchId && m.Status == "待赛" && SameSeed(m.Seed, seed))`；返回值紧邻使用处：`ReturnStatementSyntax: return data.Matches.FirstOrDefault(m => m.Id == data.PendingMatchId && m.Status == "待赛" && SameSeed(m.Seed, seed));`

**赋值（含属性/字段和局部值）：**
