# GroupStreamParser.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`1E9DE367CEDCB04B06C6BD9020DEA595B895FF1C64E0970655FB6A4E46965389`。来源：[源码](../../GroupStreamParser.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.GroupStreamParser`、`NationalSpire.GroupStreamParser.Speech`。

字段、事件及初始值（源码原样）：

```csharp
private readonly StringBuilder _header = new();
private bool _actions;
```

<a id="symbol-35b8682fefc5"></a>

## `NationalSpire.GroupStreamParser.Speech.Author — public string Author`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a78e0187c235"></a>

## `NationalSpire.GroupStreamParser.Speech.Body — public StringBuilder Body`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Text.StringBuilder.StringBuilder()`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Text.StringBuilder.StringBuilder()`；输入表达式：`new()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-03a7a6ed810b"></a>

## `NationalSpire.GroupStreamParser.Messages — public List<Speech> Messages`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7a8171171ad4"></a>

## `NationalSpire.GroupStreamParser.Actions — public PrivateStreamParser Actions`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.PrivateStreamParser.PrivateStreamParser(params string[])`](PrivateMessages.cs.md#symbol-af0a0ba2ac6c)

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateStreamParser.PrivateStreamParser(params string[])`；输入表达式：`new("Actor", "Target", "Participants", "Related", "Coach")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new("Actor", "Target", "Participants", "Related", "Coach")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-a70c65894b79"></a>

## `NationalSpire.GroupStreamParser.Error — public string Error`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9d7375d651fe"></a>

## `NationalSpire.GroupStreamParser.Feed(string) — public void Feed(string value)`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string>?)`](AiGroupChats.cs.md#symbol-caddadc35a6b)；[`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.CareerScreen.UpdateGroupStream(NationalSpire.GroupChat, string, string)`](GroupChatScreen.cs.md#symbol-c33de3d8ae73)

**调用：** [`NationalSpire.GroupStreamParser.Append(string)`](GroupStreamParser.cs.md#symbol-5d78762a5748)；[`NationalSpire.PrivateStreamParser.Feed(string)`](PrivateMessages.cs.md#symbol-f34e8e2406af)；`char.ToString()`；`NationalSpire.GroupStreamParser.Speech.Speech(string)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`；`System.Text.RegularExpressions.Regex.Match(string, string, System.Text.RegularExpressions.RegexOptions)`；`System.Text.StringBuilder.Append(char)`；`System.Text.StringBuilder.Clear()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.GroupStreamParser._actions`；`NationalSpire.GroupStreamParser._header`；`NationalSpire.GroupStreamParser.Actions`；`NationalSpire.GroupStreamParser.Append(string)`；`NationalSpire.GroupStreamParser.Messages`；`NationalSpire.PrivateStreamParser.Feed(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `char.ToString()`；输入表达式：`c.ToString()`；返回值紧邻使用处：`ArgumentSyntax: c.ToString()`
- `NationalSpire.GroupStreamParser.Append(string)`；输入表达式：`Append(_header.ToString())`；返回值紧邻使用处：`ExpressionStatementSyntax: Append(_header.ToString());`
- `NationalSpire.GroupStreamParser.Append(string)`；输入表达式：`Append(c.ToString())`；返回值紧邻使用处：`ExpressionStatementSyntax: Append(c.ToString());`
- `NationalSpire.GroupStreamParser.Append(string)`；输入表达式：`Append(header)`；返回值紧邻使用处：`ExpressionStatementSyntax: Append(header);`
- `NationalSpire.GroupStreamParser.Speech.Speech(string)`；输入表达式：`new(speaker.Groups[1].Value)`；返回值紧邻使用处：`ArgumentSyntax: new(speaker.Groups[1].Value)`
- `NationalSpire.PrivateStreamParser.Feed(string)`；输入表达式：`Actions.Feed(c.ToString())`；返回值紧邻使用处：`ExpressionStatementSyntax: Actions.Feed(c.ToString());`
- `NationalSpire.PrivateStreamParser.Feed(string)`；输入表达式：`Actions.Feed(header)`；返回值紧邻使用处：`ExpressionStatementSyntax: Actions.Feed(header);`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`Messages.Add(new(speaker.Groups[1].Value))`；返回值紧邻使用处：`ExpressionStatementSyntax: Messages.Add(new(speaker.Groups[1].Value));`
- `System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`；输入表达式：`Regex.IsMatch(header, @"^\[\s*(Favour|Attitude|Relationship|Training|Lineup|Activity|Gift|Oath|Contract|Match|Mood|Skill|Post|Profile)\s*[:：]", RegexOptions.IgnoreCase)`；返回值紧邻使用处：`IfStatementSyntax: if (Regex.IsMatch(header, @"^\[\s*(Favour|Attitude|Relationship|Training|Lineup|Activity|Gift|Oath|Contract|Match|Mood|Skill|Post|Profile)\s*[:：]", RegexOptions.IgnoreCase))                      { _actions = true; Actions.Feed(header); }                      else Append(header);`
- `System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`；输入表达式：`Regex.IsMatch(header, @"^\[\s*Actions\s*\]$", RegexOptions.IgnoreCase)`；返回值紧邻使用处：`IfStatementSyntax: if (Regex.IsMatch(header, @"^\[\s*Actions\s*\]$", RegexOptions.IgnoreCase)) _actions = true;                      else if (Regex.IsMatch(header, @"^\[\s*(Favour|Attitude|Relationship|Training|Lineup|Activity|Gift|Oath|Contract|Match|Mood|Skill|Post|Profile)\s*[:：]", RegexOptions.IgnoreCase))                      { _actions = true; Actions.Feed(header); }                      else Append(header);`
- `System.Text.RegularExpressions.Regex.Match(string, string, System.Text.RegularExpressions.RegexOptions)`；输入表达式：`Regex.Match(header, @"^\[\s*Speaker\s*[:：]\s*([^\]\s]+)\s*\]$", RegexOptions.IgnoreCase)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Regex.Match(header, @"^\[\s*Speaker\s*[:：]\s*([^\]\s]+)\s*\]$", RegexOptions.IgnoreCase)`
- `System.Text.StringBuilder.Append(char)`；输入表达式：`_header.Append(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: _header.Append(c);`
- `System.Text.StringBuilder.Clear()`；输入表达式：`_header.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _header.Clear();`
- `System.Text.StringBuilder.ToString()`；输入表达式：`_header.ToString()`；返回值紧邻使用处：`ArgumentSyntax: _header.ToString()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`_header.ToString()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _header.ToString()`

**赋值（含属性/字段和局部值）：**

- `_actions` = `true`

<a id="symbol-5d78762a5748"></a>

## `NationalSpire.GroupStreamParser.Append(string) — private void Append(string text)`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupStreamParser.Feed(string)`](GroupStreamParser.cs.md#symbol-9d7375d651fe)

**调用：** `string.IsNullOrWhiteSpace(string?)`；`string.StartsWith(string)`；`string.Trim()`；`System.Text.StringBuilder.Append(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.GroupStreamParser.Error`；`NationalSpire.GroupStreamParser.Messages`；`NationalSpire.GroupStreamParser.Speech.Body`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(text)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(text)`
- `string.StartsWith(string)`；输入表达式：`text.Trim().StartsWith("```")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !text.Trim().StartsWith("```")`
- `string.Trim()`；输入表达式：`text.Trim()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.Trim().StartsWith`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`Messages[^1].Body.Append(text)`；返回值紧邻使用处：`ExpressionStatementSyntax: Messages[^1].Body.Append(text);`

**赋值（含属性/字段和局部值）：**

- `Error` = `"部分发言缺少人物编号，未归入聊天。"`

<a id="symbol-4f31ed556cc9"></a>

## `NationalSpire.GroupStreamParser.Finish() — public void Finish()`

来源：源码第 49 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string>?)`](AiGroupChats.cs.md#symbol-caddadc35a6b)

**调用：** [`NationalSpire.PrivateStreamParser.Finish()`](PrivateMessages.cs.md#symbol-90306db26d5a)；`System.Text.StringBuilder.Clear()`

**字段、属性、事件及方法组引用：** `NationalSpire.GroupStreamParser._header`；`NationalSpire.GroupStreamParser.Actions`；`NationalSpire.GroupStreamParser.Error`；`NationalSpire.PrivateStreamParser.Error`；`NationalSpire.PrivateStreamParser.Finish()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PrivateStreamParser.Finish()`；输入表达式：`Actions.Finish()`；返回值紧邻使用处：`ExpressionStatementSyntax: Actions.Finish();`
- `System.Text.StringBuilder.Clear()`；输入表达式：`_header.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _header.Clear();`

**赋值（含属性/字段和局部值）：**

- `Error` = `"末尾标记未完整返回。"`
- `Error` = `Actions.Error`
