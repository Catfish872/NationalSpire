# LeadingReasoningStream.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`F7C28D6FB04FCBDA227D84CE51B23E701CF39B62C05E3531DF5C3BCBDE82DB7C`。来源：[源码](../../LeadingReasoningStream.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.LeadingReasoningStream`。

字段、事件及初始值（源码原样）：

```csharp
private const string Open = "<think>", Close = "</think>";
private readonly StringBuilder pending = new();
private int state;
```

<a id="symbol-db75a9cd1314"></a>

## `NationalSpire.LeadingReasoningStream.Feed(string) — public void Feed(string chunk)`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string, NationalSpire.ChatToolRequest?)`](AiPrivateMessages.cs.md#symbol-bab48bdb57c8)；[`ToolText(string)`](AiPrivateMessages.cs.md#symbol-542215f57a19)

**调用：** `string.IndexOf(string, System.StringComparison)`；`string.StartsWith(string, System.StringComparison)`；`string.TrimStart()`；`System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Math.Min(int, int)`；`System.Text.StringBuilder.Append(string?)`；`System.Text.StringBuilder.Clear()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeadingReasoningStream.Close`；`NationalSpire.LeadingReasoningStream.Open`；`NationalSpire.LeadingReasoningStream.pending`；`NationalSpire.LeadingReasoningStream.state`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.IndexOf(string, System.StringComparison)`；输入表达式：`text.IndexOf(Close, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = text.IndexOf(Close, StringComparison.OrdinalIgnoreCase)`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`Close.StartsWith(text[^keep..], StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Close.StartsWith(text[^keep..], StringComparison.OrdinalIgnoreCase)`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`Open.StartsWith(start, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: start.Length == 0 || Open.StartsWith(start, StringComparison.OrdinalIgnoreCase)`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`start.StartsWith(Open, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !start.StartsWith(Open, StringComparison.OrdinalIgnoreCase)`
- `string.TrimStart()`；输入表达式：`pending.ToString().TrimStart()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = pending.ToString().TrimStart()`
- `System.Action<T>.Invoke(T)`；输入表达式：`content(chunk)`；返回值紧邻使用处：`ExpressionStatementSyntax: content(chunk);`
- `System.Action<T>.Invoke(T)`；输入表达式：`content(pending.ToString())`；返回值紧邻使用处：`ExpressionStatementSyntax: content(pending.ToString());`
- `System.Action<T>.Invoke(T)`；输入表达式：`content(text[(end + Close.Length)..])`；返回值紧邻使用处：`ExpressionStatementSyntax: content(text[(end + Close.Length)..]);`
- `System.Action<T>.Invoke(T)`；输入表达式：`reasoning(text[..(text.Length - keep)])`；返回值紧邻使用处：`ExpressionStatementSyntax: reasoning(text[..(text.Length - keep)]);`
- `System.Action<T>.Invoke(T)`；输入表达式：`reasoning(text[..end])`；返回值紧邻使用处：`ExpressionStatementSyntax: reasoning(text[..end]);`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(Close.Length - 1, text.Length)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(Close.Length - 1, text.Length)`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`pending.Append(chunk)`；返回值紧邻使用处：`ExpressionStatementSyntax: pending.Append(chunk);`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`pending.Append(start[Open.Length..])`；返回值紧邻使用处：`ExpressionStatementSyntax: pending.Append(start[Open.Length..]);`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`pending.Append(text[^keep..])`；返回值紧邻使用处：`ExpressionStatementSyntax: pending.Append(text[^keep..]);`
- `System.Text.StringBuilder.Clear()`；输入表达式：`pending.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: pending.Clear();`
- `System.Text.StringBuilder.ToString()`；输入表达式：`pending.ToString()`；返回值紧邻使用处：`ArgumentSyntax: pending.ToString()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`pending.ToString()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = pending.ToString()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`pending.ToString()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pending.ToString().TrimStart`

**赋值（含属性/字段和局部值）：**

- `state` = `1`
- `state` = `2`

<a id="symbol-90a675c31e54"></a>

## `NationalSpire.LeadingReasoningStream.Finish() — public void Finish()`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`FinishText()`](AiPrivateMessages.cs.md#symbol-dc8b71e7b71c)

**调用：** `System.Action<T>.Invoke(T)`（委托实际目标见流程文档）；`System.Text.StringBuilder.Clear()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.LeadingReasoningStream.pending`；`NationalSpire.LeadingReasoningStream.state`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Action<T>.Invoke(T)`；输入表达式：`content(pending.ToString())`；返回值紧邻使用处：`ExpressionStatementSyntax: content(pending.ToString());`
- `System.Action<T>.Invoke(T)`；输入表达式：`reasoning(pending.ToString())`；返回值紧邻使用处：`ExpressionStatementSyntax: reasoning(pending.ToString());`
- `System.Text.StringBuilder.Clear()`；输入表达式：`pending.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: pending.Clear();`
- `System.Text.StringBuilder.ToString()`；输入表达式：`pending.ToString()`；返回值紧邻使用处：`ArgumentSyntax: pending.ToString()`

**赋值（含属性/字段和局部值）：**
