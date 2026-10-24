# GroupStreamParser.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`7D5F109555F52C0B0ED7679F841A1CDDF0C21EC0B9739249E50D7F2C5E04116C`。来源：[源码](../../GroupStreamParser.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.GroupStreamParser`、`NationalSpire.GroupStreamParser.Speech`。

字段、事件及初始值（源码原样）：

```csharp
private static readonly Regex Canonical = new(@"^\[\s*Speaker\s*[:：]\s*([^\]\s]+)\s*\]$", RegexOptions.IgnoreCase | RegexOptions.Compiled);
private static readonly Regex Number = new(@"(?<![\p{L}\p{N}_])p\s*([0-9]+)(?![\p{L}\p{N}_])", RegexOptions.IgnoreCase | RegexOptions.Compiled);
private static readonly Regex NumberFirst = new(@"^(?:(?:Speaker|发言人|说话人|人物|角色)\s*[:：]?\s*)?p\s*[0-9]+(?:\s*[:：,，|｜/·\-—(（]\s*[^\r\n]+|\s+[^\r\n]+)?$", RegexOptions.IgnoreCase | RegexOptions.Compiled);
private static readonly Regex NameFirst = new(@"^[^\[\]【】［］()（）:：|｜/]+?[\s:：|｜/·\-—(（]+p\s*[0-9]+\s*[)）]?$", RegexOptions.IgnoreCase | RegexOptions.Compiled);
private static readonly string[] SpeakerLabels = ["Speaker", "发言人", "说话人", "人物", "角色"];
private readonly StringBuilder _header = new();
private bool _actions, _lineStart = true, _headerAtStart;
private char _close;
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

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-9d7375d651fe"></a>

## `NationalSpire.GroupStreamParser.Feed(string) — public void Feed(string value)`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string>?)`](AiGroupChats.cs.md#symbol-caddadc35a6b)；[`NationalSpire.CareerScreen.RefreshGroupChat()`](GroupChatScreen.cs.md#symbol-b56fe79b2db7)；[`NationalSpire.CareerScreen.UpdateGroupStream(NationalSpire.GroupChat, string, string)`](GroupChatScreen.cs.md#symbol-c33de3d8ae73)

**调用：** [`NationalSpire.GroupStreamParser.Append(string)`](GroupStreamParser.cs.md#symbol-5d78762a5748)；[`NationalSpire.GroupStreamParser.BarePrefix(string)`](GroupStreamParser.cs.md#symbol-263b0bd03db9)；[`NationalSpire.GroupStreamParser.Normalize(string)`](GroupStreamParser.cs.md#symbol-06d52914e647)；[`NationalSpire.GroupStreamParser.TrySpeaker(string, out string)`](GroupStreamParser.cs.md#symbol-26619136db8e)；[`NationalSpire.PrivateStreamParser.Feed(string)`](PrivateMessages.cs.md#symbol-f34e8e2406af)；`char.IsWhiteSpace(char)`；`char.ToString()`；`NationalSpire.GroupStreamParser.Speech.Speech(string)`；`string.Trim()`；`string.TrimEnd()`；`string.TrimEnd(params char[]?)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`；`System.Text.RegularExpressions.Regex.Match(string)`；`System.Text.StringBuilder.Append(char)`；`System.Text.StringBuilder.Clear()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.GroupStreamParser._actions`；`NationalSpire.GroupStreamParser._close`；`NationalSpire.GroupStreamParser._header`；`NationalSpire.GroupStreamParser._headerAtStart`；`NationalSpire.GroupStreamParser._lineStart`；`NationalSpire.GroupStreamParser.Actions`；`NationalSpire.GroupStreamParser.Append(string)`；`NationalSpire.GroupStreamParser.BarePrefix(string)`；`NationalSpire.GroupStreamParser.Canonical`；`NationalSpire.GroupStreamParser.Messages`；`NationalSpire.GroupStreamParser.Normalize(string)`；`NationalSpire.GroupStreamParser.TrySpeaker(string, out string)`；`NationalSpire.PrivateStreamParser.Feed(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `char.IsWhiteSpace(char)`；输入表达式：`char.IsWhiteSpace(c)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !char.IsWhiteSpace(c)`
- `char.ToString()`；输入表达式：`c.ToString()`；返回值紧邻使用处：`ArgumentSyntax: c.ToString()`
- `NationalSpire.GroupStreamParser.Append(string)`；输入表达式：`Append(_header.ToString())`；返回值紧邻使用处：`ExpressionStatementSyntax: Append(_header.ToString());`
- `NationalSpire.GroupStreamParser.Append(string)`；输入表达式：`Append(c.ToString())`；返回值紧邻使用处：`ExpressionStatementSyntax: Append(c.ToString());`
- `NationalSpire.GroupStreamParser.Append(string)`；输入表达式：`Append(header)`；返回值紧邻使用处：`ExpressionStatementSyntax: Append(header);`
- `NationalSpire.GroupStreamParser.Append(string)`；输入表达式：`Append(pending)`；返回值紧邻使用处：`ExpressionStatementSyntax: Append(pending);`
- `NationalSpire.GroupStreamParser.BarePrefix(string)`；输入表达式：`BarePrefix(c.ToString())`；返回值紧邻使用处：`BinaryExpressionSyntax: _lineStart && !char.IsWhiteSpace(c) && BarePrefix(c.ToString())`
- `NationalSpire.GroupStreamParser.BarePrefix(string)`；输入表达式：`BarePrefix(pending)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !BarePrefix(pending)`
- `NationalSpire.GroupStreamParser.Normalize(string)`；输入表达式：`Normalize(speaker.Groups[1].Value)`；返回值紧邻使用处：`ArgumentSyntax: Normalize(speaker.Groups[1].Value)`
- `NationalSpire.GroupStreamParser.Speech.Speech(string)`；输入表达式：`new(author)`；返回值紧邻使用处：`ArgumentSyntax: new(author)`
- `NationalSpire.GroupStreamParser.Speech.Speech(string)`；输入表达式：`new(Normalize(speaker.Groups[1].Value))`；返回值紧邻使用处：`ArgumentSyntax: new(Normalize(speaker.Groups[1].Value))`
- `NationalSpire.GroupStreamParser.TrySpeaker(string, out string)`；输入表达式：`TrySpeaker(header[1..^1].Trim(), out string author)`；返回值紧邻使用处：`BinaryExpressionSyntax: (_headerAtStart || speaker.Success) && TrySpeaker(header[1..^1].Trim(), out string author)`
- `NationalSpire.GroupStreamParser.TrySpeaker(string, out string)`；输入表达式：`TrySpeaker(heading, out string author)`；返回值紧邻使用处：`IfStatementSyntax: if (TrySpeaker(heading, out string author)) { Messages.Add(new(author)); _header.Clear(); _lineStart = c == '\n'; }                          else if (c == '\n') { Append(pending); _header.Clear(); }`
- `NationalSpire.PrivateStreamParser.Feed(string)`；输入表达式：`Actions.Feed(c.ToString())`；返回值紧邻使用处：`ExpressionStatementSyntax: Actions.Feed(c.ToString());`
- `NationalSpire.PrivateStreamParser.Feed(string)`；输入表达式：`Actions.Feed(header)`；返回值紧邻使用处：`ExpressionStatementSyntax: Actions.Feed(header);`
- `string.Trim()`；输入表达式：`header[1..^1].Trim()`；返回值紧邻使用处：`ArgumentSyntax: header[1..^1].Trim()`
- `string.Trim()`；输入表达式：`pending.Trim()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pending.Trim().TrimEnd`
- `string.TrimEnd()`；输入表达式：`pending.Trim().TrimEnd(':', '：').TrimEnd()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = pending.Trim().TrimEnd(':', '：').TrimEnd()`
- `string.TrimEnd(params char[]?)`；输入表达式：`pending.Trim().TrimEnd(':', '：')`；返回值紧邻使用处：`MemberAccessExpressionSyntax: pending.Trim().TrimEnd(':', '：').TrimEnd`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`Messages.Add(new(author))`；返回值紧邻使用处：`ExpressionStatementSyntax: Messages.Add(new(author));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`Messages.Add(new(Normalize(speaker.Groups[1].Value)))`；返回值紧邻使用处：`ExpressionStatementSyntax: Messages.Add(new(Normalize(speaker.Groups[1].Value)));`
- `System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`；输入表达式：`Regex.IsMatch(header, @"^\[\s*(Favour|Attitude|Relationship|Training|Lineup|Activity|Gift|Oath|Contract|Match|Mood|Skill|Post|Profile)\s*[:：]", RegexOptions.IgnoreCase)`；返回值紧邻使用处：`IfStatementSyntax: if (Regex.IsMatch(header, @"^\[\s*(Favour|Attitude|Relationship|Training|Lineup|Activity|Gift|Oath|Contract|Match|Mood|Skill|Post|Profile)\s*[:：]", RegexOptions.IgnoreCase))                      { _actions = true; Actions.Feed(header); }                      // 简写只识别行首标题；正文中的人物编号引用仍属于当前发言。                      else if ((_headerAtStart || speaker.Success) && TrySpeaker(header[1..^1].Trim(), out string author)) { Messages.Add(new(author)); _lineStart = false; }                      else if (speaker.Success) { Messages.Add(new(Normalize(speaker.Groups[1].Value))); _lineStart = false; }                      else Append(header);`
- `System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`；输入表达式：`Regex.IsMatch(header, @"^\[\s*Actions\s*\]$", RegexOptions.IgnoreCase)`；返回值紧邻使用处：`IfStatementSyntax: if (Regex.IsMatch(header, @"^\[\s*Actions\s*\]$", RegexOptions.IgnoreCase)) _actions = true;                      else if (Regex.IsMatch(header, @"^\[\s*(Favour|Attitude|Relationship|Training|Lineup|Activity|Gift|Oath|Contract|Match|Mood|Skill|Post|Profile)\s*[:：]", RegexOptions.IgnoreCase))                      { _actions = true; Actions.Feed(header); }                      // 简写只识别行首标题；正文中的人物编号引用仍属于当前发言。                      else if ((_headerAtStart || speaker.Success) && TrySpeaker(header[1..^1].Trim(), out string author)) { Messages.Add(new(author)); _lineStart = false; }                      else if (speaker.Success) { Messages.Add(new(Normalize(speaker.Groups[1].Value))); _lineStart = false; }                      else Append(header);`
- `System.Text.RegularExpressions.Regex.Match(string)`；输入表达式：`Canonical.Match(header)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Canonical.Match(header)`
- `System.Text.StringBuilder.Append(char)`；输入表达式：`_header.Append(c)`；返回值紧邻使用处：`ExpressionStatementSyntax: _header.Append(c);`
- `System.Text.StringBuilder.Clear()`；输入表达式：`_header.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _header.Clear();`
- `System.Text.StringBuilder.ToString()`；输入表达式：`_header.ToString()`；返回值紧邻使用处：`ArgumentSyntax: _header.ToString()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`_header.ToString()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _header.ToString()`

**赋值（含属性/字段和局部值）：**

- `_actions` = `true`
- `_close` = `'\0'`
- `_close` = `close`
- `_headerAtStart` = `_lineStart`
- `_lineStart` = `c == '\n'`
- `_lineStart` = `false`

<a id="symbol-5d78762a5748"></a>

## `NationalSpire.GroupStreamParser.Append(string) — private void Append(string text)`

来源：源码第 65 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupStreamParser.Feed(string)`](GroupStreamParser.cs.md#symbol-9d7375d651fe)；[`NationalSpire.GroupStreamParser.Finish()`](GroupStreamParser.cs.md#symbol-4f31ed556cc9)

**调用：** `char.IsWhiteSpace(char)`；`string.IsNullOrWhiteSpace(string?)`；`string.StartsWith(string)`；`string.Trim()`；`System.Text.StringBuilder.Append(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.GroupStreamParser._lineStart`；`NationalSpire.GroupStreamParser.Error`；`NationalSpire.GroupStreamParser.Messages`；`NationalSpire.GroupStreamParser.Speech.Body`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `char.IsWhiteSpace(char)`；输入表达式：`char.IsWhiteSpace(c)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !char.IsWhiteSpace(c)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(text)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(text)`
- `string.StartsWith(string)`；输入表达式：`text.Trim().StartsWith("```")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !text.Trim().StartsWith("```")`
- `string.Trim()`；输入表达式：`text.Trim()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.Trim().StartsWith`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`Messages[^1].Body.Append(text)`；返回值紧邻使用处：`ExpressionStatementSyntax: Messages[^1].Body.Append(text);`

**赋值（含属性/字段和局部值）：**

- `_lineStart` = `false`
- `_lineStart` = `true`
- `Error` = `"部分发言缺少人物编号，未归入聊天。"`

<a id="symbol-06d52914e647"></a>

## `NationalSpire.GroupStreamParser.Normalize(string) — private static string Normalize(string author)`

来源：源码第 71 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupStreamParser.Feed(string)`](GroupStreamParser.cs.md#symbol-9d7375d651fe)

**调用：** `string.ToLowerInvariant()`；`System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.ToLowerInvariant()`；输入表达式：`author.ToLowerInvariant()`；返回值紧邻使用处：`ConditionalExpressionSyntax: Regex.IsMatch(author, @"^p[0-9]+$", RegexOptions.IgnoreCase) ? author.ToLowerInvariant() : author`
- `System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`；输入表达式：`Regex.IsMatch(author, @"^p[0-9]+$", RegexOptions.IgnoreCase)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Regex.IsMatch(author, @"^p[0-9]+$", RegexOptions.IgnoreCase) ? author.ToLowerInvariant() : author`

**赋值（含属性/字段和局部值）：**


<a id="symbol-26619136db8e"></a>

## `NationalSpire.GroupStreamParser.TrySpeaker(string, out string) — private static bool TrySpeaker(string heading, out string author)`

来源：源码第 72 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupStreamParser.Feed(string)`](GroupStreamParser.cs.md#symbol-9d7375d651fe)

**调用：** `System.Text.RegularExpressions.Regex.IsMatch(string)`；`System.Text.RegularExpressions.Regex.Matches(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.GroupStreamParser.NameFirst`；`NationalSpire.GroupStreamParser.Number`；`NationalSpire.GroupStreamParser.NumberFirst`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Text.RegularExpressions.Regex.IsMatch(string)`；输入表达式：`NameFirst.IsMatch(heading)`；返回值紧邻使用处：`BinaryExpressionSyntax: NumberFirst.IsMatch(heading) || NameFirst.IsMatch(heading)`
- `System.Text.RegularExpressions.Regex.IsMatch(string)`；输入表达式：`NumberFirst.IsMatch(heading)`；返回值紧邻使用处：`BinaryExpressionSyntax: NumberFirst.IsMatch(heading) || NameFirst.IsMatch(heading)`
- `System.Text.RegularExpressions.Regex.Matches(string)`；输入表达式：`Number.Matches(heading)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Number.Matches(heading)`

**赋值（含属性/字段和局部值）：**

- `author` = `""`
- `author` = `"p" + numbers[0].Groups[1].Value`

<a id="symbol-263b0bd03db9"></a>

## `NationalSpire.GroupStreamParser.BarePrefix(string) — private static bool BarePrefix(string text)`

来源：源码第 78 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupStreamParser.Feed(string)`](GroupStreamParser.cs.md#symbol-9d7375d651fe)

**调用：** `string.StartsWith(string, System.StringComparison)`；`string.TrimStart()`；`string.TrimStart(params char[]?)`；`System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`

**字段、属性、事件及方法组引用：** `NationalSpire.GroupStreamParser.SpeakerLabels`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.StartsWith(string, System.StringComparison)`；输入表达式：`label.StartsWith(text, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`IfStatementSyntax: if (label.StartsWith(text, StringComparison.OrdinalIgnoreCase)) return true;`
- `string.StartsWith(string, System.StringComparison)`；输入表达式：`text.StartsWith(label, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`IfStatementSyntax: if (text.StartsWith(label, StringComparison.OrdinalIgnoreCase)) { text = text[label.Length..].TrimStart().TrimStart(':', '：').TrimStart(); break; }`
- `string.TrimStart()`；输入表达式：`text[label.Length..].TrimStart().TrimStart(':', '：').TrimStart()`；返回值紧邻使用处：`AssignmentExpressionSyntax: text = text[label.Length..].TrimStart().TrimStart(':', '：').TrimStart()`
- `string.TrimStart()`；输入表达式：`text[label.Length..].TrimStart()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text[label.Length..].TrimStart().TrimStart`
- `string.TrimStart(params char[]?)`；输入表达式：`text[label.Length..].TrimStart().TrimStart(':', '：')`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text[label.Length..].TrimStart().TrimStart(':', '：').TrimStart`
- `System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`；输入表达式：`Regex.IsMatch(text, @"^p\s*[0-9]*\s*$", RegexOptions.IgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: text.Length == 0 || Regex.IsMatch(text, @"^p\s*[0-9]*\s*$", RegexOptions.IgnoreCase)`

**赋值（含属性/字段和局部值）：**

- `text` = `text[label.Length..].TrimStart().TrimStart(':', '：').TrimStart()`

<a id="symbol-4f31ed556cc9"></a>

## `NationalSpire.GroupStreamParser.Finish() — public void Finish()`

来源：源码第 87 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessGroupAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string>?)`](AiGroupChats.cs.md#symbol-caddadc35a6b)

**调用：** [`NationalSpire.GroupStreamParser.Append(string)`](GroupStreamParser.cs.md#symbol-5d78762a5748)；[`NationalSpire.PrivateStreamParser.Finish()`](PrivateMessages.cs.md#symbol-90306db26d5a)；`System.Text.StringBuilder.Clear()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.GroupStreamParser._close`；`NationalSpire.GroupStreamParser._header`；`NationalSpire.GroupStreamParser.Actions`；`NationalSpire.GroupStreamParser.Append(string)`；`NationalSpire.GroupStreamParser.Error`；`NationalSpire.PrivateStreamParser.Error`；`NationalSpire.PrivateStreamParser.Finish()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupStreamParser.Append(string)`；输入表达式：`Append(_header.ToString())`；返回值紧邻使用处：`ExpressionStatementSyntax: Append(_header.ToString());`
- `NationalSpire.PrivateStreamParser.Finish()`；输入表达式：`Actions.Finish()`；返回值紧邻使用处：`ExpressionStatementSyntax: Actions.Finish();`
- `System.Text.StringBuilder.Clear()`；输入表达式：`_header.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: _header.Clear();`
- `System.Text.StringBuilder.ToString()`；输入表达式：`_header.ToString()`；返回值紧邻使用处：`ArgumentSyntax: _header.ToString()`

**赋值（含属性/字段和局部值）：**

- `Error` = `"末尾标记未完整返回。"`
- `Error` = `Actions.Error`
