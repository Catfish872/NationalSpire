# DateSceneExtensions.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`051EF6C16CA6BA1B3424DAC1E0C6C22D74F10AB5A6E0FCB755749D5FFB3BE472`。来源：[源码](../../DateSceneExtensions.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DateSceneExtensions`、`NationalSpire.IDateSceneExtension`。

字段、事件及初始值（源码原样）：

```csharp
```

<a id="symbol-b83037fa95c3"></a>

## `NationalSpire.DateSceneExtensions.CreateCareerScreen — public static Func<CareerScreen>? CreateCareerScreen`

来源：源码第 6 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-01a51301cbd7"></a>

## `NationalSpire.DateSceneExtensions.CreateView — public static Func<DateSceneView>? CreateView`

来源：源码第 7 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7cc3b88a9061"></a>

## `NationalSpire.DateSceneExtensions.Current — public static IDateSceneExtension? Current`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-54c33728d696"></a>

## `NationalSpire.DateSceneExtensions.NewView() — public static DateSceneView NewView()`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)；[`NationalSpire.DateMemoryPlayback.OpenPlayback()`](DateSceneMemoryPlayback.cs.md#symbol-314d3bb28f9e)

**调用：** `NationalSpire.DateSceneView.DateSceneView()`；`System.Func<TResult>.Invoke()`（委托实际目标见流程文档）

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneExtensions.CreateView`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneView.DateSceneView()`；输入表达式：`new DateSceneView()`；返回值紧邻使用处：`BinaryExpressionSyntax: CreateView?.Invoke() ?? new DateSceneView()`
- `System.Func<TResult>.Invoke()`；输入表达式：`.Invoke()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: CreateView?.Invoke()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0bf370c7adf5"></a>

## `NationalSpire.DateSceneExtensions.MetadataFields — public static IEnumerable<string> MetadataFields`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneExtensions.Current`；`NationalSpire.IDateSceneExtension.MetadataFields`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`new[] { "Scene", "Emotion", "Background", "Speaker" }          .Concat(Current?.MetadataFields ?? [])`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new[] { "Scene", "Emotion", "Background", "Speaker" }          .Concat(Current?.MetadataFields ?? [])`

**赋值（含属性/字段和局部值）：**


<a id="symbol-269d8398eaac"></a>

## `NationalSpire.IDateSceneExtension.MetadataFields —  IEnumerable<string> MetadataFields`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-13d12c07d9db"></a>

## `NationalSpire.IDateSceneExtension.Guidance(NationalSpire.DateSceneRequest, bool) — string Guidance(DateSceneRequest scene, bool tools);`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.Guidance(NationalSpire.DateSceneRequest, bool)`](DateSceneData.cs.md#symbol-42aa2fbcaa1f)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-28302b18c917"></a>

## `NationalSpire.IDateSceneExtension.Materials(NationalSpire.DateSceneRequest, System.Collections.Generic.Dictionary<string, object?>) — void Materials(DateSceneRequest scene, Dictionary<string, object?> materials);`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.PromptMaterials(NationalSpire.DateSceneRequest)`](DateSceneData.cs.md#symbol-ef9b9e70ca5d)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-bfc252430145"></a>

## `NationalSpire.IDateSceneExtension.ReplySchema(NationalSpire.DateSceneRequest, System.Collections.Generic.Dictionary<string, object>) — void ReplySchema(DateSceneRequest scene, Dictionary<string, object> properties);`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatTools.Create(NationalSpire.CareerData, NationalSpire.PrivateConversation?, NationalSpire.PrivateTurn?, NationalSpire.GroupChat?)`](ChatTools.cs.md#symbol-da501aed0ab9)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f4b624b75fe6"></a>

## `NationalSpire.IDateSceneExtension.ReplyExample(NationalSpire.DateSceneRequest) — string ReplyExample(DateSceneRequest scene);`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatTools.Create(NationalSpire.CareerData, NationalSpire.PrivateConversation?, NationalSpire.PrivateTurn?, NationalSpire.GroupChat?)`](ChatTools.cs.md#symbol-da501aed0ab9)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5dda5c304d1f"></a>

## `NationalSpire.IDateSceneExtension.HistoryCue(NationalSpire.DateSceneLine) — string HistoryCue(DateSceneLine line);`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Flush()`](DateSceneData.cs.md#symbol-58fa9ff0ce57)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b666a4747dcc"></a>

## `NationalSpire.IDateSceneExtension.MergeHistory(NationalSpire.DateSceneLine, NationalSpire.DateSceneLine) — bool MergeHistory(DateSceneLine first, DateSceneLine next);`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.PromptHistory(NationalSpire.PrivateTurn, string)`](DateSceneData.cs.md#symbol-1bee81f08078)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a87019935579"></a>

## `NationalSpire.IDateSceneExtension.RequiredMetadata(NationalSpire.DateSceneRequest?) — string[] RequiredMetadata(DateSceneRequest? scene);`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatTools.Create(NationalSpire.CareerData, NationalSpire.PrivateConversation?, NationalSpire.PrivateTurn?, NationalSpire.GroupChat?)`](ChatTools.cs.md#symbol-da501aed0ab9)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-a9b634965b55"></a>

## `NationalSpire.IDateSceneExtension.ReadSegment(NationalSpire.DateSceneRequest, System.Collections.Generic.Dictionary<string, string>?, System.Collections.Generic.List<NationalSpire.DateSceneLine>) — void ReadSegment(DateSceneRequest scene, Dictionary<string, string>? fields, List<DateSceneLine> lines);`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.ReadSegment(string, NationalSpire.DateSceneRequest, System.Collections.Generic.Dictionary<string, string>?)`](DateSceneData.cs.md#symbol-df380ec1333f)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7ce3600d7671"></a>

## `NationalSpire.IDateSceneExtension.SplitLine(NationalSpire.DateSceneLine, NationalSpire.DateSceneLine, int) — void SplitLine(DateSceneLine original, DateSceneLine part, int index);`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.DisplayParts(NationalSpire.DateSceneLine)`](DateSceneData.cs.md#symbol-2d444f7f549e)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-45c2e47b1379"></a>

## `NationalSpire.IDateSceneExtension.RecordTurn(NationalSpire.DateMemoryTurn, NationalSpire.DateSceneRequest) — void RecordTurn(DateMemoryTurn entry, DateSceneRequest scene);`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateMemoryRecorder.Sync(NationalSpire.PrivateConversation)`](DateSceneMemories.cs.md#symbol-949d37f3d89e)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-de17d2b01e2b"></a>

## `NationalSpire.IDateSceneExtension.DeleteMemory(NationalSpire.CareerData, string) — void DeleteMemory(CareerData data, string offer);`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneMemories.Delete(NationalSpire.CareerData, string)`](DateSceneMemories.cs.md#symbol-a32b756f581f)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-c5a58933906f"></a>

## `NationalSpire.IDateSceneExtension.RefreshRequest(NationalSpire.CareerData, string, NationalSpire.DateSceneRequest, NationalSpire.DateSceneRequest?) — DateSceneRequest RefreshRequest(CareerData data, string person, DateSceneRequest previous, DateSceneRequest? current);`

来源：源码第 28 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**
