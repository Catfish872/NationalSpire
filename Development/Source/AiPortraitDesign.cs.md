# AiPortraitDesign.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`979552B30F150339312B5A14C946322C13B75D0F7DC4FC66A537CDA859678007`。来源：[源码](../../AiPortraitDesign.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.AiService`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-b767cc172aa6"></a>

## `NationalSpire.AiService.InferPortraitAsync(NationalSpire.CareerData, string, NationalSpire.PortraitDesign, System.Threading.CancellationToken) — public static async Task<string> InferPortraitAsync(CareerData data, string person, PortraitDesign draft, CancellationToken token)`

来源：源码第 5 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Infer()`](PortraitDesignScreen.cs.md#symbol-84dd4f56a6bf)

**调用：** [`NationalSpire.AiRequestQueue.Configure(int)`](AiRequestQueue.cs.md#symbol-7bf81d36c27d)；[`NationalSpire.AiService.EnterPrivateQueue(NationalSpire.CareerData, string, System.Threading.CancellationToken)`](AiPrivateMessages.cs.md#symbol-d73b189170eb)；[`NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string)`](AiPrivateMessages.cs.md#symbol-4da425dc52d5)；[`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`](CareerStore.cs.md#symbol-ead7461ee7cb)；[`NationalSpire.PortraitDesigns.Messages(NationalSpire.CareerData, string, NationalSpire.PortraitDesign)`](PortraitDesign.cs.md#symbol-3f8b0db3fc3f)；`System.InvalidOperationException.InvalidOperationException(string?)`；`System.Math.Clamp(int, int, int)`；`System.OperationCanceledException.OperationCanceledException(string?, System.Threading.CancellationToken)`；`System.Threading.CancellationToken.ThrowIfCancellationRequested()`；`System.Threading.CancellationTokenSource.CancelAfter(System.TimeSpan)`；`System.Threading.CancellationTokenSource.CreateLinkedTokenSource(System.Threading.CancellationToken)`；`System.TimeSpan.FromMinutes(long)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiOptions.Enabled`；`NationalSpire.AiOptions.MaxConcurrentRequests`；`NationalSpire.AiOptions.RequestTimeoutMinutes`；`NationalSpire.AiRequestQueue.Configure(int)`；`NationalSpire.AiService.EnterPrivateQueue(NationalSpire.CareerData, string, System.Threading.CancellationToken)`；`NationalSpire.AiService.PrivateForegroundQueue`；`NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string)`；`NationalSpire.CareerData.Ai`；`NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；`NationalSpire.PortraitDesigns.Messages(NationalSpire.CareerData, string, NationalSpire.PortraitDesign)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiRequestQueue.Configure(int)`；输入表达式：`PrivateForegroundQueue.Configure(data.Ai.MaxConcurrentRequests)`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateForegroundQueue.Configure(data.Ai.MaxConcurrentRequests);`
- `NationalSpire.AiService.EnterPrivateQueue(NationalSpire.CareerData, string, System.Threading.CancellationToken)`；输入表达式：`EnterPrivateQueue(data, "portrait/" + person, cancel.Token)`；返回值紧邻使用处：`AwaitExpressionSyntax: await EnterPrivateQueue(data, "portrait/" + person, cancel.Token)`
- `NationalSpire.AiService.RequestPrivateAsync(NationalSpire.AiOptions, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>, bool, System.Action<string>?, System.Threading.CancellationToken, System.Action<string>?, string, string)`；输入表达式：`RequestPrivateAsync(data.Ai, messages, false, null, cancel.Token, context: "portrait-design/" + person, task: "private")`；返回值紧邻使用处：`AwaitExpressionSyntax: await RequestPrivateAsync(data.Ai, messages, false, null, cancel.Token, context: "portrait-design/" + person, task: "private")`
- `NationalSpire.CareerStore.IsCurrent(NationalSpire.CareerData)`；输入表达式：`CareerStore.IsCurrent(data)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CareerStore.IsCurrent(data)`
- `NationalSpire.PortraitDesigns.Messages(NationalSpire.CareerData, string, NationalSpire.PortraitDesign)`；输入表达式：`PortraitDesigns.Messages(data, person, draft)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PortraitDesigns.Messages(data, person, draft)`
- `System.InvalidOperationException.InvalidOperationException(string?)`；输入表达式：`new InvalidOperationException("启用 AI 后可根据人物资料推测外观；当前设定可直接编辑与导出。")`；返回值紧邻使用处：`ThrowStatementSyntax: throw new InvalidOperationException("启用 AI 后可根据人物资料推测外观；当前设定可直接编辑与导出。");`
- `System.Math.Clamp(int, int, int)`；输入表达式：`Math.Clamp(data.Ai.RequestTimeoutMinutes, 2, 30)`；返回值紧邻使用处：`ArgumentSyntax: Math.Clamp(data.Ai.RequestTimeoutMinutes, 2, 30)`
- `System.OperationCanceledException.OperationCanceledException(string?, System.Threading.CancellationToken)`；输入表达式：`new OperationCanceledException("生涯已切换。", cancel.Token)`；返回值紧邻使用处：`ThrowStatementSyntax: throw new OperationCanceledException("生涯已切换。", cancel.Token);`
- `System.Threading.CancellationToken.ThrowIfCancellationRequested()`；输入表达式：`cancel.Token.ThrowIfCancellationRequested()`；返回值紧邻使用处：`ExpressionStatementSyntax: cancel.Token.ThrowIfCancellationRequested();`
- `System.Threading.CancellationTokenSource.CancelAfter(System.TimeSpan)`；输入表达式：`cancel.CancelAfter(TimeSpan.FromMinutes(Math.Clamp(data.Ai.RequestTimeoutMinutes, 2, 30)))`；返回值紧邻使用处：`ExpressionStatementSyntax: cancel.CancelAfter(TimeSpan.FromMinutes(Math.Clamp(data.Ai.RequestTimeoutMinutes, 2, 30)));`
- `System.Threading.CancellationTokenSource.CreateLinkedTokenSource(System.Threading.CancellationToken)`；输入表达式：`CancellationTokenSource.CreateLinkedTokenSource(token)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = CancellationTokenSource.CreateLinkedTokenSource(token)`
- `System.TimeSpan.FromMinutes(long)`；输入表达式：`TimeSpan.FromMinutes(Math.Clamp(data.Ai.RequestTimeoutMinutes, 2, 30))`；返回值紧邻使用处：`ArgumentSyntax: TimeSpan.FromMinutes(Math.Clamp(data.Ai.RequestTimeoutMinutes, 2, 30))`

**赋值（含属性/字段和局部值）：**
