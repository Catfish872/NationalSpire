# PlayerFacingText.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`27B722F6A3CA0B30E73F2D12338FF7EE8C3E97F3757569DDB8D3C022E1A58DDD`。来源：[源码](../../PlayerFacingText.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.PlayerFacingText`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-be617f3bd292"></a>

## `NationalSpire.PlayerFacingText.AiError(string) — public static string AiError(string detail)`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`](CommunityScreen.cs.md#symbol-6bdab2812eba)；[`NationalSpire.PlayerFacingText.AiErrorPreview(string)`](PlayerFacingText.cs.md#symbol-fc1bb7a47c87)；[`NationalSpire.PlayerFacingText.AiStatus(string)`](PlayerFacingText.cs.md#symbol-6179a4a56aad)

**调用：** [`NationalSpire.Diagnostics.Redact(string)`](Diagnostics.cs.md#symbol-f014e01c492a)；`string.IsNullOrWhiteSpace(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.Diagnostics.Redact(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.Diagnostics.Redact(string)`；输入表达式：`Diagnostics.Redact(detail)`；返回值紧邻使用处：`ConditionalExpressionSyntax: string.IsNullOrWhiteSpace(detail)          ? "未记录错误详情，请重试后查看。" : Diagnostics.Redact(detail)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(detail)`；返回值紧邻使用处：`ConditionalExpressionSyntax: string.IsNullOrWhiteSpace(detail)          ? "未记录错误详情，请重试后查看。" : Diagnostics.Redact(detail)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-fc1bb7a47c87"></a>

## `NationalSpire.PlayerFacingText.AiErrorPreview(string) — public static string AiErrorPreview(string detail)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RenderWorkStatus(Godot.VBoxContainer, NationalSpire.AiWorkState, System.Action, string)`](CommunityScreen.cs.md#symbol-6bdab2812eba)

**调用：** [`NationalSpire.PlayerFacingText.AiError(string)`](PlayerFacingText.cs.md#symbol-be617f3bd292)；`string.Replace(string, string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.PlayerFacingText.AiError(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PlayerFacingText.AiError(string)`；输入表达式：`AiError(detail)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AiError(detail).Replace`
- `string.Replace(string, string?)`；输入表达式：`AiError(detail).Replace("\r", "").Replace("\n", " · ")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = AiError(detail).Replace("\r", "").Replace("\n", " · ")`
- `string.Replace(string, string?)`；输入表达式：`AiError(detail).Replace("\r", "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: AiError(detail).Replace("\r", "").Replace`

**赋值（含属性/字段和局部值）：**


<a id="symbol-6179a4a56aad"></a>

## `NationalSpire.PlayerFacingText.AiStatus(string) — public static string AiStatus(string status)`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiSettingsPanel.Build(Godot.VBoxContainer, NationalSpire.AiOptions, System.Action, System.Action, System.Action, System.Action<string, bool>, System.Action?, string, System.Action<System.Action>?)`](AiSettingsPanel.cs.md#symbol-8fb9cbc85381)；[`NationalSpire.CareerScreen._Process(double)`](CareerScreen.cs.md#symbol-de0dbc5f9504)

**调用：** [`NationalSpire.PlayerFacingText.AiError(string)`](PlayerFacingText.cs.md#symbol-be617f3bd292)；`string.Replace(string, string?)`；`string.StartsWith(string)`

**字段、属性、事件及方法组引用：** `NationalSpire.PlayerFacingText.AiError(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.PlayerFacingText.AiError(string)`；输入表达式：`AiError(status)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: _ => AiError(status)`
- `string.Replace(string, string?)`；输入表达式：`status.Replace(" 篇 AI 更新", " 篇新内容")`；返回值紧邻使用处：`SwitchExpressionArmSyntax: _ when status.StartsWith("已发布 ") => status.Replace(" 篇 AI 更新", " 篇新内容")`
- `string.StartsWith(string)`；输入表达式：`status.StartsWith("第 ")`；返回值紧邻使用处：`BinaryExpressionSyntax: status.StartsWith("正在") || status.StartsWith("第 ")`
- `string.StartsWith(string)`；输入表达式：`status.StartsWith("已发布 ")`；返回值紧邻使用处：`WhenClauseSyntax: when status.StartsWith("已发布 ")`
- `string.StartsWith(string)`；输入表达式：`status.StartsWith("正在")`；返回值紧邻使用处：`BinaryExpressionSyntax: status.StartsWith("正在") || status.StartsWith("第 ")`

**赋值（含属性/字段和局部值）：**
