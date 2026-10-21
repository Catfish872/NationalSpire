# DateSceneData.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`6A088E762E4BD8CC65B9C2948DBDAF817A8BF76F0FDEB1B5288C57F9722C37F7`。来源：[源码](../../DateSceneData.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DateSceneRequest`、`NationalSpire.DateSceneLine`、`NationalSpire.DateScenes`。

字段、事件及初始值（源码原样）：

```csharp
public const string Protocol = """
当前进入约会场景，继续使用双方已有私聊记录和关系。围绕约会地点、共同活动与彼此感受展开交流。
台词与旁白分行输出，每段开头填写Scene、Emotion、Background。Scene填dialogue或narration；Emotion填写本轮可用表情编号；Background填写本轮可用背景编号，沿用当前背景时填current。人物台词保持角色原有说话方式；旁白描述环境及人物动作。
台词示例：
[Scene: dialogue, Emotion: neutral, Background: current]今天想先去哪里走走？
旁白示例：
[Scene: narration, Emotion: neutral, Background: current]窗边透进柔和的光，桌上的茶还冒着热气。
开场先描写约定地点及人物外观、姿态，再由人物说话。后续承接玩家本轮消息。玩家的发言和行动由玩家决定。活动、赠礼等交互继续使用各自格式。
""";
public const int MaxLineCharacters = 48;
```

<a id="symbol-0054a248837a"></a>

## `NationalSpire.DateSceneRequest.OfferId — public string OfferId`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4acb38c6dea4"></a>

## `NationalSpire.DateSceneRequest.DefaultEmotionId — public string DefaultEmotionId`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-910087e123a1"></a>

## `NationalSpire.DateSceneRequest.Title — public string Title`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-35615cbf6d4b"></a>

## `NationalSpire.DateSceneRequest.Detail — public string Detail`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5170a6b0ef04"></a>

## `NationalSpire.DateSceneRequest.OutfitId — public string OutfitId`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b30553341429"></a>

## `NationalSpire.DateSceneRequest.Opening — public bool Opening`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7ecbd73ba815"></a>

## `NationalSpire.DateSceneRequest.Ending — public bool Ending`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d9416cbb1012"></a>

## `NationalSpire.DateSceneRequest.Emotions — public Dictionary<string, string> Emotions`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b1e4d75e2583"></a>

## `NationalSpire.DateSceneRequest.Backgrounds — public Dictionary<string, string> Backgrounds`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-82991a6f8918"></a>

## `NationalSpire.DateSceneRequest.CurrentBackground — public string CurrentBackground`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-53f610fda3e0"></a>

## `NationalSpire.DateSceneLine.Text — public string Text`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-87e825f01a63"></a>

## `NationalSpire.DateSceneLine.Emotion — public string Emotion`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-46c4bf0bec17"></a>

## `NationalSpire.DateSceneLine.Narration — public bool Narration`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4e7d2cd6abfd"></a>

## `NationalSpire.DateSceneLine.Background — public string Background`

来源：源码第 26 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-3126fba22dfa"></a>

## `NationalSpire.DateScenes.Guidance(NationalSpire.DateSceneRequest) — public static string Guidance(DateSceneRequest scene)`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessagePrompts.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?, string?, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-de94bbbea5ea)

**调用：** `string.Replace(string, string?)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `<anonymous type: string Title, string Detail, bool Opening, string defaultEmotion, System.Collections.Generic.Dictionary<string, string> emotions, System.Collections.Generic.Dictionary<string, string> backgrounds, string currentBackground>.backgrounds`；`<anonymous type: string Title, string Detail, bool Opening, string defaultEmotion, System.Collections.Generic.Dictionary<string, string> emotions, System.Collections.Generic.Dictionary<string, string> backgrounds, string currentBackground>.currentBackground`；`<anonymous type: string Title, string Detail, bool Opening, string defaultEmotion, System.Collections.Generic.Dictionary<string, string> emotions, System.Collections.Generic.Dictionary<string, string> backgrounds, string currentBackground>.defaultEmotion`；`<anonymous type: string Title, string Detail, bool Opening, string defaultEmotion, System.Collections.Generic.Dictionary<string, string> emotions, System.Collections.Generic.Dictionary<string, string> backgrounds, string currentBackground>.emotions`；`NationalSpire.DateSceneRequest.Backgrounds`；`NationalSpire.DateSceneRequest.CurrentBackground`；`NationalSpire.DateSceneRequest.DefaultEmotionId`；`NationalSpire.DateSceneRequest.Detail`；`NationalSpire.DateSceneRequest.Emotions`；`NationalSpire.DateSceneRequest.Opening`；`NationalSpire.DateSceneRequest.Title`；`NationalSpire.DateScenes.Protocol`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Replace(string, string?)`；输入表达式：`Protocol.Replace("Emotion: neutral", "Emotion: " + scene.DefaultEmotionId)`；返回值紧邻使用处：`BinaryExpressionSyntax: Protocol.Replace("Emotion: neutral", "Emotion: " + scene.DefaultEmotionId)          + "\n当前场景资料："`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(new { scene.Title, scene.Detail, scene.Opening, defaultEmotion = scene.DefaultEmotionId,              emotions = scene.Emotions, backgrounds = scene.Backgrounds, currentBackground = scene.CurrentBackground })`；返回值紧邻使用处：`BinaryExpressionSyntax: Protocol.Replace("Emotion: neutral", "Emotion: " + scene.DefaultEmotionId)          + "\n当前场景资料：" + JsonSerializer.Serialize(new { scene.Title, scene.Detail, scene.Opening, defaultEmotion = scene.DefaultEmotionId,              emotions = scene.Emotions, backgrounds = scene.Backgrounds, currentBackground = scene.CurrentBackground })`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5652957ff027"></a>

## `NationalSpire.DateScenes.SafeBackgroundId(string) — public static bool SafeBackgroundId(string id)`

来源：源码第 43 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneBackgrounds.SafeId(string)`](DateSceneBackgrounds.cs.md#symbol-19bb6c988fd7)；[`NationalSpire.DateScenes.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest)`](DateSceneData.cs.md#symbol-190a72e967ad)

**调用：** `char.IsLetterOrDigit(char)`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `char.IsLetterOrDigit(char)`；输入表达式：`char.IsLetterOrDigit(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: char.IsLetterOrDigit(c) || c is '_' or '-'`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`id.All(c => char.IsLetterOrDigit(c) || c is '_' or '-')`；返回值紧邻使用处：`BinaryExpressionSyntax: id.Length is > 0 and <= 100 && id.All(c => char.IsLetterOrDigit(c) || c is '_' or '-')`

**赋值（含属性/字段和局部值）：**


<a id="symbol-dccb0fff0030"></a>

## `NationalSpire.DateScenes.OneToOne(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?) — public static bool OneToOne(CareerData data, PrivateOffer offer, PrivateConversation? conversation)`

来源：源码第 44 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddDateSceneAction(NationalSpire.CareerData, NationalSpire.PrivateOffer, Godot.HBoxContainer)`](DateSceneScreen.cs.md#symbol-413adf55a103)；[`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneData.cs.md#symbol-0d3e014bcb63)

**调用：** [`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；`System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateOffer.GroupId`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Participants`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(data)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Human(data)`
- `System.Collections.Generic.IEnumerable<TSource>.Count<TSource>()`；输入表达式：`offer.Participants.Distinct().Count()`；返回值紧邻使用处：`BinaryExpressionSyntax: offer.Participants.Distinct().Count() == 2`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`offer.Participants.Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: offer.Participants.Distinct().Count`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`offer.Participants.Contains(conversation.PersonId)`；返回值紧邻使用处：`BinaryExpressionSyntax: offer.Participants.Distinct().Count() == 2              && offer.Participants.Contains(GroupChats.Human(data)) && conversation != null && offer.Participants.Contains(conversation.PersonId)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`offer.Participants.Contains(GroupChats.Human(data))`；返回值紧邻使用处：`BinaryExpressionSyntax: offer.Participants.Distinct().Count() == 2              && offer.Participants.Contains(GroupChats.Human(data))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0d3e014bcb63"></a>

## `NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?) — public static bool Available(CareerData data, PrivateOffer offer, PrivateConversation? conversation = null)`

来源：源码第 47 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddDateSceneAction(NationalSpire.CareerData, NationalSpire.PrivateOffer, Godot.HBoxContainer)`](DateSceneScreen.cs.md#symbol-413adf55a103)；[`NationalSpire.CareerScreen.AddPausedDateScenes(NationalSpire.CareerData, NationalSpire.PrivateConversation)`](DateSceneScreen.cs.md#symbol-a5b10d9fb0b8)；[`NationalSpire.CareerScreen.PromptDateScene(string)`](DateSceneScreen.cs.md#symbol-d6c92b4f494c)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)；[`NationalSpire.DateScenes.Leave(NationalSpire.CareerData, NationalSpire.PrivateConversation, string, bool)`](DateSceneData.cs.md#symbol-81bdbfbfe1d8)；[`NationalSpire.DateScenes.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest)`](DateSceneData.cs.md#symbol-190a72e967ad)

**调用：** [`NationalSpire.DateScenes.OneToOne(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneData.cs.md#symbol-dccb0fff0030)；[`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateSceneRequest.Opening`；`NationalSpire.DateScenes.OneToOne(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateConversation.DateSceneStates`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateTurn.Scene`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateScenes.OneToOne(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；输入表达式：`OneToOne(data, offer, conversation)`；返回值紧邻使用处：`BinaryExpressionSyntax: OneToOne(data, offer, conversation)          && offer.State == "已赴约"`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(data, offer)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateAppointments.Date(data, offer) == data.Day`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Turns.Any(t => t.Scene?.OfferId == offer.Id && t.Scene.Opening)`；返回值紧邻使用处：`BinaryExpressionSyntax: conversation.DateSceneStates.GetValueOrDefault(offer.Id) is "active" or "paused" || conversation.Turns.Any(t => t.Scene?.OfferId == offer.Id && t.Scene.Opening)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.DateSceneStates.GetValueOrDefault(offer.Id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: conversation?.DateSceneStates.GetValueOrDefault(offer.Id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`conversation.DateSceneStates.GetValueOrDefault(offer.Id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: conversation.DateSceneStates.GetValueOrDefault(offer.Id) is "active" or "paused"`

**赋值（含属性/字段和局部值）：**


<a id="symbol-81bdbfbfe1d8"></a>

## `NationalSpire.DateScenes.Leave(NationalSpire.CareerData, NationalSpire.PrivateConversation, string, bool) — public static string? Leave(CareerData data, PrivateConversation conversation, string offerId, bool end)`

来源：源码第 50 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)

**调用：** [`NationalSpire.AiService.CancelPrivate(NationalSpire.CareerData, string)`](AiPrivateMessages.cs.md#symbol-14a6fc19e1c1)；[`NationalSpire.DateDiaries.Begin(NationalSpire.PrivateConversation, NationalSpire.PrivateOffer)`](DateDiaries.cs.md#symbol-25266fe7f850)；[`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneData.cs.md#symbol-0d3e014bcb63)；[`NationalSpire.PrivateMessageCommands.RestoreInterrupted(NationalSpire.PrivateTurn, string)`](PrivateMessageCommands.cs.md#symbol-82b01f18fa69)；[`NationalSpire.PrivateMessages.Enqueue(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer?, System.Collections.Generic.List<NationalSpire.PrivateOffer>?, string, bool)`](PrivateMessages.cs.md#symbol-0e61d4a7bbb5)；[`NationalSpire.WeddingAppointments.Complete(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-4cb46102c2e0)；`NationalSpire.DateSceneRequest.DateSceneRequest()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.CancelPrivate(NationalSpire.CareerData, string)`；`NationalSpire.DateDiaries.Begin(NationalSpire.PrivateConversation, NationalSpire.PrivateOffer)`；`NationalSpire.DateSceneRequest.Detail`；`NationalSpire.DateSceneRequest.Ending`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateSceneRequest.Opening`；`NationalSpire.DateSceneRequest.Title`；`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；`NationalSpire.PrivateConversation.DateSceneStates`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessageCommands.RestoreInterrupted(NationalSpire.PrivateTurn, string)`；`NationalSpire.PrivateMessages.Enqueue(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer?, System.Collections.Generic.List<NationalSpire.PrivateOffer>?, string, bool)`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.Title`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.WeddingAppointments.Complete(NationalSpire.CareerData, NationalSpire.PrivateOffer)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.CancelPrivate(NationalSpire.CareerData, string)`；输入表达式：`AiService.CancelPrivate(data, conversation.PersonId)`；返回值紧邻使用处：`ExpressionStatementSyntax: AiService.CancelPrivate(data, conversation.PersonId);`
- `NationalSpire.DateDiaries.Begin(NationalSpire.PrivateConversation, NationalSpire.PrivateOffer)`；输入表达式：`DateDiaries.Begin(conversation, offer)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateDiaries.Begin(conversation, offer);`
- `NationalSpire.DateSceneRequest.DateSceneRequest()`；输入表达式：`new() { OfferId = offerId, Title = offer.Title, Detail = offer.Detail, Ending = true }`；返回值紧邻使用处：`AssignmentExpressionSyntax: reflection.Scene = new() { OfferId = offerId, Title = offer.Title, Detail = offer.Detail, Ending = true }`
- `NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；输入表达式：`Available(data, offer, conversation)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Available(data, offer, conversation)`
- `NationalSpire.PrivateMessageCommands.RestoreInterrupted(NationalSpire.PrivateTurn, string)`；输入表达式：`PrivateMessageCommands.RestoreInterrupted(turn, "本次约会已结束，生成已停止。")`；返回值紧邻使用处：`ExpressionStatementSyntax: PrivateMessageCommands.RestoreInterrupted(turn, "本次约会已结束，生成已停止。");`
- `NationalSpire.PrivateMessages.Enqueue(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer?, System.Collections.Generic.List<NationalSpire.PrivateOffer>?, string, bool)`；输入表达式：`PrivateMessages.Enqueue(data, conversation.PersonId, $"（系统事件：本次约会《{offer.Title}》已结束。请给玩家发送相处后的感想，并整理自己的约会日记。）", queueAfterCurrent: true)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Enqueue(data, conversation.PersonId, $"（系统事件：本次约会《{offer.Title}》已结束。请给玩家发送相处后的感想，并整理自己的约会日记。）", queueAfterCurrent: true)`
- `NationalSpire.WeddingAppointments.Complete(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`WeddingAppointments.Complete(data, offer)`；返回值紧邻使用处：`ExpressionStatementSyntax: WeddingAppointments.Complete(data, offer);`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Turns.Any(t => t.Scene is { Opening: true } scene && scene.OfferId == offerId)`；返回值紧邻使用处：`BinaryExpressionSyntax: conversation.DateSceneStates.GetValueOrDefault(offerId) is "active" or "paused"              || conversation.Turns.Any(t => t.Scene is { Opening: true } scene && scene.OfferId == offerId)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Offers.FirstOrDefault(o => o.Id == offerId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = conversation.Offers.FirstOrDefault(o => o.Id == offerId)`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Turns.LastOrDefault(t => t.Status is "queued" or "sending" && t.Scene?.OfferId == offerId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: conversation.Turns.LastOrDefault(t => t.Status is "queued" or "sending" && t.Scene?.OfferId == offerId) is { } turn`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`conversation.DateSceneStates.GetValueOrDefault(offerId)`；返回值紧邻使用处：`BinaryExpressionSyntax: conversation.DateSceneStates.GetValueOrDefault(offerId) == "ended"`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`conversation.DateSceneStates.GetValueOrDefault(offerId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: conversation.DateSceneStates.GetValueOrDefault(offerId) is "active" or "paused"`

**赋值（含属性/字段和局部值）：**

- `conversation.DateSceneStates[offerId]` = `end ? "ended" : "paused"`
- `Detail` = `offer.Detail`
- `Ending` = `true`
- `offer.State` = `"已结束"`
- `OfferId` = `offerId`
- `reflection.Scene` = `new() { OfferId = offerId, Title = offer.Title, Detail = offer.Detail, Ending = true }`
- `Title` = `offer.Title`

<a id="symbol-190a72e967ad"></a>

## `NationalSpire.DateScenes.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest) — public static string? Validate(CareerData data, PrivateConversation conversation, DateSceneRequest request)`

来源：源码第 74 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateScene(string)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.PrivateMessageCommands.Apply(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-81ef5fba41b8)

**调用：** [`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneData.cs.md#symbol-0d3e014bcb63)；[`NationalSpire.DateScenes.SafeBackgroundId(string)`](DateSceneData.cs.md#symbol-5652957ff027)；[`NationalSpire.PortraitDesigns.SafeId(string)`](PortraitDesign.cs.md#symbol-7497548faaf1)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneRequest.Backgrounds`；`NationalSpire.DateSceneRequest.DefaultEmotionId`；`NationalSpire.DateSceneRequest.Detail`；`NationalSpire.DateSceneRequest.Emotions`；`NationalSpire.DateSceneRequest.Ending`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateSceneRequest.OutfitId`；`NationalSpire.DateSceneRequest.Title`；`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；`NationalSpire.DateScenes.SafeBackgroundId(string)`；`NationalSpire.PortraitDesigns.SafeId(string)`；`NationalSpire.PrivateConversation.DateSceneStates`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.GroupId`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Title`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；输入表达式：`Available(data, offer, conversation)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Available(data, offer, conversation)`
- `NationalSpire.DateScenes.SafeBackgroundId(string)`；输入表达式：`SafeBackgroundId(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !SafeBackgroundId(id)`
- `NationalSpire.PortraitDesigns.SafeId(string)`；输入表达式：`PortraitDesigns.SafeId(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PortraitDesigns.SafeId(id)`
- `NationalSpire.PortraitDesigns.SafeId(string)`；输入表达式：`PortraitDesigns.SafeId(request.OutfitId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PortraitDesigns.SafeId(request.OutfitId)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`request.Emotions.ContainsKey(request.DefaultEmotionId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !request.Emotions.ContainsKey(request.DefaultEmotionId)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`request.Backgrounds.Keys.Any(id => !SafeBackgroundId(id))`；返回值紧邻使用处：`BinaryExpressionSyntax: request.Backgrounds == null || request.Backgrounds.Keys.Any(id => !SafeBackgroundId(id))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`request.Emotions.Keys.Any(id => !PortraitDesigns.SafeId(id))`；返回值紧邻使用处：`BinaryExpressionSyntax: request.Emotions == null || !request.Emotions.ContainsKey(request.DefaultEmotionId) || request.Emotions.Keys.Any(id => !PortraitDesigns.SafeId(id))`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Offers.FirstOrDefault(o => o.Id == request.OfferId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = conversation.Offers.FirstOrDefault(o => o.Id == request.OfferId)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`conversation.DateSceneStates.GetValueOrDefault(request.OfferId)`；返回值紧邻使用处：`BinaryExpressionSyntax: conversation.DateSceneStates.GetValueOrDefault(request.OfferId) != "ended"`

**赋值（含属性/字段和局部值）：**

- `request.Detail` = `offer.Detail`
- `request.Title` = `offer.Title`

<a id="symbol-00bcca1f004c"></a>

## `NationalSpire.DateScenes.TaggedLines(NationalSpire.PrivateStreamParser, NationalSpire.DateSceneRequest) — public static List<DateSceneLine> TaggedLines(PrivateStreamParser parser, DateSceneRequest scene)`

来源：源码第 89 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)；[`Progress(string)`](AiPrivateMessages.cs.md#symbol-d1b345a01158)

**调用：** [`NationalSpire.DateScenes.JoinNarration(System.Collections.Generic.List<NationalSpire.DateSceneLine>)`](DateSceneData.cs.md#symbol-da243e86633f)；[`Segment(int)`](DateSceneData.cs.md#symbol-0eed008cbf1c)；`string.TrimEnd()`；`string.TrimStart()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Last<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.List()`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `(int Offset, System.Collections.Generic.Dictionary<string, string> Fields).Fields`；`(int Offset, System.Collections.Generic.Dictionary<string, string> Fields).Offset`；`NationalSpire.DateSceneLine.Emotion`；`NationalSpire.DateSceneRequest.DefaultEmotionId`；`NationalSpire.DateSceneRequest.Emotions`；`NationalSpire.DateScenes.JoinNarration(System.Collections.Generic.List<NationalSpire.DateSceneLine>)`；`NationalSpire.PrivateStreamParser.SceneCues`；`NationalSpire.PrivateStreamParser.Text`；`Segment(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateScenes.JoinNarration(System.Collections.Generic.List<NationalSpire.DateSceneLine>)`；输入表达式：`JoinNarration(result)`；返回值紧邻使用处：`ReturnStatementSyntax: return JoinNarration(result);`
- `Segment(int)`；输入表达式：`Segment(cue.Offset)`；返回值紧邻使用处：`ExpressionStatementSyntax: Segment(cue.Offset);`
- `Segment(int)`；输入表达式：`Segment(end)`；返回值紧邻使用处：`ExpressionStatementSyntax: Segment(end);`
- `string.TrimEnd()`；输入表达式：`source.TrimEnd()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: source.TrimEnd().Length`
- `string.TrimStart()`；输入表达式：`source.TrimStart()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: source.TrimStart().Length`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`scene.Emotions.ContainsKey(line.Emotion)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !scene.Emotions.ContainsKey(line.Emotion)`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`parser.SceneCues.Where(c => c.Offset <= end).GroupBy(c => Math.Max(start, c.Offset))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parser.SceneCues.Where(c => c.Offset <= end).GroupBy(c => Math.Max(start, c.Offset)).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Last<TSource>()`；输入表达式：`g.Last()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Last().Fields`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`parser.SceneCues.Where(c => c.Offset <= end).GroupBy(c => Math.Max(start, c.Offset)).Select(g => (Offset:g.Key, Fields:g.Last().Fields))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parser.SceneCues.Where(c => c.Offset <= end).GroupBy(c => Math.Max(start, c.Offset)).Select(g => (Offset:g.Key, Fields:g.Last().Fields)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`parser.SceneCues.Where(c => c.Offset <= end).GroupBy(c => Math.Max(start, c.Offset)).Select(g => (Offset:g.Key, Fields:g.Last().Fields)).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = parser.SceneCues.Where(c => c.Offset <= end).GroupBy(c => Math.Max(start, c.Offset)).Select(g => (Offset:g.Key, Fields:g.Last().Fields)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`parser.SceneCues.Where(c => c.Offset <= end)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parser.SceneCues.Where(c => c.Offset <= end).GroupBy`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<DateSceneLine>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<DateSceneLine>()`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(start, c.Offset)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => Math.Max(start, c.Offset)`

**赋值（含属性/字段和局部值）：**

- `fields` = `cue.Fields`
- `line.Emotion` = `scene.DefaultEmotionId`

<a id="symbol-0eed008cbf1c"></a>

## `Segment(int) — void Segment(int limit)`

来源：源码第 95 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.TaggedLines(NationalSpire.PrivateStreamParser, NationalSpire.DateSceneRequest)`](DateSceneData.cs.md#symbol-00bcca1f004c)

**调用：** [`NationalSpire.DateScenes.ReadSegment(string, NationalSpire.DateSceneRequest, System.Collections.Generic.Dictionary<string, string>?)`](DateSceneData.cs.md#symbol-df380ec1333f)；`string.IsNullOrWhiteSpace(string?)`；`System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneLine.Text`；`NationalSpire.DateScenes.ReadSegment(string, NationalSpire.DateSceneRequest, System.Collections.Generic.Dictionary<string, string>?)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateScenes.ReadSegment(string, NationalSpire.DateSceneRequest, System.Collections.Generic.Dictionary<string, string>?)`；输入表达式：`ReadSegment(source[position..limit], scene, fields)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ReadSegment(source[position..limit], scene, fields)`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(source[position..limit])`；返回值紧邻使用处：`BinaryExpressionSyntax: lines.Count == 0 && limit > position && result.Count > 0 && string.IsNullOrWhiteSpace(source[position..limit])`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`result.AddRange(lines)`；返回值紧邻使用处：`ExpressionStatementSyntax: result.AddRange(lines);`

**赋值（含属性/字段和局部值）：**

- `position` = `limit`
- `result[^1].Text` += `source[position..limit]`

<a id="symbol-a6609cbcddd2"></a>

## `NationalSpire.DateScenes.EmotionId(NationalSpire.DateSceneRequest, string) — private static string? EmotionId(DateSceneRequest scene, string value)`

来源：源码第 107 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.EmotionId(NationalSpire.DateSceneRequest, string)`](DateSceneData.cs.md#symbol-a6609cbcddd2)；[`NationalSpire.DateScenes.ReadSegment(string, NationalSpire.DateSceneRequest, System.Collections.Generic.Dictionary<string, string>?)`](DateSceneData.cs.md#symbol-df380ec1333f)

**调用：** [`NationalSpire.DateScenes.EmotionId(NationalSpire.DateSceneRequest, string)`](DateSceneData.cs.md#symbol-a6609cbcddd2)；`string.Equals(string?, System.StringComparison)`；`string.Split(char[]?, System.StringSplitOptions)`；`string.Split(params char[]?)`；`string.Trim()`；`string.Trim(params char[]?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneRequest.Emotions`；`NationalSpire.DateScenes.EmotionId(NationalSpire.DateSceneRequest, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateScenes.EmotionId(NationalSpire.DateSceneRequest, string)`；输入表达式：`EmotionId(scene, part)`；返回值紧邻使用处：`IsPatternExpressionSyntax: EmotionId(scene, part) is { } found`
- `string.Equals(string?, System.StringComparison)`；输入表达式：`id.Equals(value, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: id.Equals(value, StringComparison.OrdinalIgnoreCase) || name.Equals(value, StringComparison.OrdinalIgnoreCase)`
- `string.Equals(string?, System.StringComparison)`；输入表达式：`name.Equals(value, StringComparison.OrdinalIgnoreCase)`；返回值紧邻使用处：`BinaryExpressionSyntax: id.Equals(value, StringComparison.OrdinalIgnoreCase) || name.Equals(value, StringComparison.OrdinalIgnoreCase)`
- `string.Split(char[]?, System.StringSplitOptions)`；输入表达式：`value.Split(['/', '／', '·', '|'], StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string part in value.Split(['/', '／', '·', '|'], StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries))              if (part != value && EmotionId(scene, part) is { } found) return found;`
- `string.Split(params char[]?)`；输入表达式：`description.Split('：', ':')`；返回值紧邻使用处：`ElementAccessExpressionSyntax: description.Split('：', ':')[0]`
- `string.Trim()`；输入表达式：`description.Split('：', ':')[0].Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = description.Split('：', ':')[0].Trim()`
- `string.Trim()`；输入表达式：`value.Trim()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: value.Trim().Trim`
- `string.Trim(params char[]?)`；输入表达式：`value.Trim().Trim('"', '\'', '`')`；返回值紧邻使用处：`AssignmentExpressionSyntax: value = value.Trim().Trim('"', '\'', '`')`

**赋值（含属性/字段和局部值）：**

- `value` = `value.Trim().Trim('"', '\'', '`')`

<a id="symbol-9848e1f83c4c"></a>

## `NationalSpire.DateScenes.InferEmotion(NationalSpire.DateSceneRequest, string) — private static string InferEmotion(DateSceneRequest scene, string text)`

来源：源码第 119 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Add(string)`](DateSceneData.cs.md#symbol-1a3588b38c19)

**调用：** `string.Split(params char[]?)`；`System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`；`System.Text.RegularExpressions.Regex.IsMatch(string, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneRequest.DefaultEmotionId`；`NationalSpire.DateSceneRequest.Emotions`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Split(params char[]?)`；输入表达式：`description.Split('：', ':')`；返回值紧邻使用处：`ElementAccessExpressionSyntax: description.Split('：', ':')[0]`
- `System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`；输入表达式：`Regex.IsMatch(id + "|" + description.Split('：', ':')[0], names, RegexOptions.IgnoreCase)`；返回值紧邻使用处：`IfStatementSyntax: if (Regex.IsMatch(id + "|" + description.Split('：', ':')[0], names, RegexOptions.IgnoreCase)) return id;`
- `System.Text.RegularExpressions.Regex.IsMatch(string, string)`；输入表达式：`Regex.IsMatch(text, words)`；返回值紧邻使用处：`IfStatementSyntax: if (Regex.IsMatch(text, words))                  foreach (var (id, description) in scene.Emotions)                      if (Regex.IsMatch(id + "|" + description.Split('：', ':')[0], names, RegexOptions.IgnoreCase)) return id;`

**赋值（含属性/字段和局部值）：**


<a id="symbol-df380ec1333f"></a>

## `NationalSpire.DateScenes.ReadSegment(string, NationalSpire.DateSceneRequest, System.Collections.Generic.Dictionary<string, string>?) — private static List<DateSceneLine> ReadSegment(string text, DateSceneRequest scene, Dictionary<string, string>? fields)`

来源：源码第 140 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Segment(int)`](DateSceneData.cs.md#symbol-0eed008cbf1c)

**调用：** [`Add(string)`](DateSceneData.cs.md#symbol-1a3588b38c19)；[`NationalSpire.DateScenes.EmotionId(NationalSpire.DateSceneRequest, string)`](DateSceneData.cs.md#symbol-a6609cbcddd2)；`string.ToLowerInvariant()`；`string.Trim()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.List<T>.List()`；`System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`；`System.Text.RegularExpressions.Regex.Matches(string, string)`；`System.Text.RegularExpressions.Regex.Replace(string, string, string, System.Text.RegularExpressions.RegexOptions)`

**字段、属性、事件及方法组引用：** `Add(string)`；`NationalSpire.DateSceneRequest.DefaultEmotionId`；`NationalSpire.DateScenes.EmotionId(NationalSpire.DateSceneRequest, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Add(string)`；输入表达式：`Add(text[at..])`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(text[at..]);`
- `Add(string)`；输入表达式：`Add(text[at..tag.Index])`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(text[at..tag.Index]);`
- `NationalSpire.DateScenes.EmotionId(NationalSpire.DateSceneRequest, string)`；输入表达式：`EmotionId(scene, candidate)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = EmotionId(scene, candidate)`
- `NationalSpire.DateScenes.EmotionId(NationalSpire.DateSceneRequest, string)`；输入表达式：`EmotionId(scene, fields["Emotion"])`；返回值紧邻使用处：`BinaryExpressionSyntax: EmotionId(scene, fields["Emotion"]) ?? scene.DefaultEmotionId`
- `string.ToLowerInvariant()`；输入表达式：`.GetValueOrDefault("Scene", "").ToLowerInvariant()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: fields?.GetValueOrDefault("Scene", "").ToLowerInvariant()`
- `string.Trim()`；输入表达式：`tag.Groups["value"].Value.Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = tag.Groups["value"].Value.Trim()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`.ContainsKey("Emotion")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: fields?.ContainsKey("Emotion")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`.GetValueOrDefault("Background", "")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: fields?.GetValueOrDefault("Background", "")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`.GetValueOrDefault("Scene", "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: .GetValueOrDefault("Scene", "").ToLowerInvariant`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<DateSceneLine>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<DateSceneLine>()`
- `System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`；输入表达式：`Regex.IsMatch(value, @"^(Emotion|情绪)\s*[:：]", RegexOptions.IgnoreCase)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Regex.IsMatch(value, @"^(Emotion|情绪)\s*[:：]", RegexOptions.IgnoreCase)`
- `System.Text.RegularExpressions.Regex.Matches(string, string)`；输入表达式：`Regex.Matches(text, @"[\[（(【](?<value>[^\]\r\n）)】]{1,80})[\]）)】]")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (Match tag in Regex.Matches(text, @"[\[（(【](?<value>[^\]\r\n）)】]{1,80})[\]）)】]"))          {              string value = tag.Groups["value"].Value.Trim();              bool explicitEmotion = Regex.IsMatch(value, @"^(Emotion|情绪)\s*[:：]", RegexOptions.IgnoreCase);              string candidate = explicitEmotion ? Regex.Replace(value, @"^(Emotion|情绪)\s*[:：]\s*", "", RegexOptions.IgnoreCase) : value;              string? found = EmotionId(scene, candidate);              bool narration = value is "旁白" or "narration";              if (found == null && !explicitEmotion && !narration) continue;              Add(text[at..tag.Index]); at = tag.Index + tag.Length;              if (narration) { kind = "narration"; emotion = null; }              else { kind = "dialogue"; emotion = found ?? scene.DefaultEmotionId; }          }`
- `System.Text.RegularExpressions.Regex.Replace(string, string, string, System.Text.RegularExpressions.RegexOptions)`；输入表达式：`Regex.Replace(value, @"^(Emotion|情绪)\s*[:：]\s*", "", RegexOptions.IgnoreCase)`；返回值紧邻使用处：`ConditionalExpressionSyntax: explicitEmotion ? Regex.Replace(value, @"^(Emotion|情绪)\s*[:：]\s*", "", RegexOptions.IgnoreCase) : value`

**赋值（含属性/字段和局部值）：**

- `at` = `tag.Index + tag.Length`
- `emotion` = `found ?? scene.DefaultEmotionId`
- `emotion` = `null`
- `kind` = `"dialogue"`
- `kind` = `"narration"`

<a id="symbol-1a3588b38c19"></a>

## `Add(string) — void Add(string part)`

来源：源码第 146 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.ReadSegment(string, NationalSpire.DateSceneRequest, System.Collections.Generic.Dictionary<string, string>?)`](DateSceneData.cs.md#symbol-df380ec1333f)

**调用：** [`NationalSpire.DateScenes.InferEmotion(NationalSpire.DateSceneRequest, string)`](DateSceneData.cs.md#symbol-9848e1f83c4c)；[`NationalSpire.DateScenes.Split(string, bool)`](DateSceneData.cs.md#symbol-4bfd36365879)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneLine.Background`；`NationalSpire.DateSceneLine.Emotion`；`NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.Text`；`NationalSpire.DateSceneRequest.Backgrounds`；`NationalSpire.DateSceneRequest.DefaultEmotionId`；`NationalSpire.DateScenes.InferEmotion(NationalSpire.DateSceneRequest, string)`；`NationalSpire.DateScenes.Split(string, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateScenes.InferEmotion(NationalSpire.DateSceneRequest, string)`；输入表达式：`InferEmotion(scene, line.Text)`；返回值紧邻使用处：`BinaryExpressionSyntax: emotion ?? InferEmotion(scene, line.Text)`
- `NationalSpire.DateScenes.Split(string, bool)`；输入表达式：`Split(part, kind is "narration" or "旁白")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Split(part, kind is "narration" or "旁白")`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`scene.Backgrounds.ContainsKey(background)`；返回值紧邻使用处：`BinaryExpressionSyntax: lines.Count > 0 && scene.Backgrounds.ContainsKey(background)`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`result.AddRange(lines)`；返回值紧邻使用处：`ExpressionStatementSyntax: result.AddRange(lines);`

**赋值（含属性/字段和局部值）：**

- `background` = `""`
- `line.Emotion` = `line.Narration ? scene.DefaultEmotionId : emotion ?? InferEmotion(scene, line.Text)`
- `line.Narration` |= `kind is "narration" or "旁白"`
- `lines[0].Background` = `background`
- `result[^1].Text` += `part`

<a id="symbol-76bee931e453"></a>

## `NationalSpire.DateScenes.ReplyFailure(string) — public static string? ReplyFailure(string text)`

来源：源码第 174 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)

**调用：** `System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`；输入表达式：`Regex.IsMatch(text,          @"我(?:无法|不能)(?:为你|为您)?(?:生成|提供)|NSFW", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Regex.IsMatch(text,          @"我(?:无法|不能)(?:为你|为您)?(?:生成|提供)|NSFW", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant)          ? "本轮回复包含模型拒绝生成的内容，请重新生成或编辑文字后发送。" : null`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4bfd36365879"></a>

## `NationalSpire.DateScenes.Split(string, bool) — public static List<DateSceneLine> Split(string text, bool narration = false)`

来源：源码第 178 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Add(string)`](DateSceneData.cs.md#symbol-1a3588b38c19)；[`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`](DateSceneData.cs.md#symbol-801111e76ca9)

**调用：** [`Flush()`](DateSceneData.cs.md#symbol-972103714524)；`char.IsWhiteSpace(char)`；`string.Contains(char)`；`System.Collections.Generic.List<T>.List()`；`System.Text.StringBuilder.Append(char)`；`System.Text.StringBuilder.StringBuilder()`

**字段、属性、事件及方法组引用：** `Flush()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `char.IsWhiteSpace(char)`；输入表达式：`char.IsWhiteSpace(text[i + 1])`；返回值紧邻使用处：`BinaryExpressionSyntax: i + 1 == text.Length || char.IsWhiteSpace(text[i + 1])`
- `Flush()`；输入表达式：`Flush()`；返回值紧邻使用处：`ExpressionStatementSyntax: Flush();`
- `string.Contains(char)`；输入表达式：`"。！？!?…\"”’」』）)".Contains(text[i + 1])`；返回值紧邻使用处：`BinaryExpressionSyntax: i + 1 < text.Length && "。！？!?…\"”’」』）)".Contains(text[i + 1])`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<DateSceneLine>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<DateSceneLine>()`
- `System.Text.StringBuilder.Append(char)`；输入表达式：`buffer.Append(ch)`；返回值紧邻使用处：`ExpressionStatementSyntax: buffer.Append(ch);`
- `System.Text.StringBuilder.Append(char)`；输入表达式：`buffer.Append(text[++i])`；返回值紧邻使用处：`ExpressionStatementSyntax: buffer.Append(text[++i]);`
- `System.Text.StringBuilder.StringBuilder()`；输入表达式：`new StringBuilder()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StringBuilder()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-972103714524"></a>

## `Flush() — void Flush()`

来源：源码第 181 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.Split(string, bool)`](DateSceneData.cs.md#symbol-4bfd36365879)

**调用：** [`NationalSpire.DateScenes.ShortParts(string, int)`](DateSceneData.cs.md#symbol-8f114a9558ac)；`NationalSpire.DateSceneLine.DateSceneLine()`；`string.IsNullOrWhiteSpace(string?)`；`string.StartsWith(char)`；`string.Trim()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Text.RegularExpressions.Regex.IsMatch(string, string)`；`System.Text.StringBuilder.Clear()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.Text`；`NationalSpire.DateScenes.MaxLineCharacters`；`NationalSpire.DateScenes.ShortParts(string, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneLine.DateSceneLine()`；输入表达式：`new() { Text = part, Narration = objective }`；返回值紧邻使用处：`ArgumentSyntax: new() { Text = part, Narration = objective }`
- `NationalSpire.DateScenes.ShortParts(string, int)`；输入表达式：`ShortParts(value, objective ? int.MaxValue : MaxLineCharacters)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string part in ShortParts(value, objective ? int.MaxValue : MaxLineCharacters)) result.Add(new() { Text = part, Narration = objective });`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(value)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(value)) { if (result.Count > 0) result[^1].Text += value; return; }`
- `string.StartsWith(char)`；输入表达式：`trimmed.StartsWith('(')`；返回值紧邻使用处：`BinaryExpressionSyntax: trimmed.StartsWith('（') || trimmed.StartsWith('(')`
- `string.StartsWith(char)`；输入表达式：`trimmed.StartsWith('（')`；返回值紧邻使用处：`BinaryExpressionSyntax: trimmed.StartsWith('（') || trimmed.StartsWith('(')`
- `string.Trim()`；输入表达式：`value.Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = value.Trim()`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.Add(new() { Text = part, Narration = objective })`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Add(new() { Text = part, Narration = objective });`
- `System.Text.RegularExpressions.Regex.IsMatch(string, string)`；输入表达式：`Regex.IsMatch(trimmed, "旁白|环境|阳光|灯光|风声|夜色|街道|窗外|微风|空气|抬起|低下|转身|望向|看向|走近|站在|坐在|微笑|轻轻|缓缓|她|他|少女|少年|女孩|男孩|耳朵|尾巴|指尖|脸颊|掌心|目光|视线|脚步|身旁|嘴角|双眼|嘴唇|肩膀")`；返回值紧邻使用处：`BinaryExpressionSyntax: (trimmed.StartsWith('（') || trimmed.StartsWith('(')) && Regex.IsMatch(trimmed, "旁白|环境|阳光|灯光|风声|夜色|街道|窗外|微风|空气|抬起|低下|转身|望向|看向|走近|站在|坐在|微笑|轻轻|缓缓|她|他|少女|少年|女孩|男孩|耳朵|尾巴|指尖|脸颊|掌心|目光|视线|脚步|身旁|嘴角|双眼|嘴唇|肩膀")`
- `System.Text.StringBuilder.Clear()`；输入表达式：`buffer.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: buffer.Clear();`
- `System.Text.StringBuilder.ToString()`；输入表达式：`buffer.ToString()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = buffer.ToString()`

**赋值（含属性/字段和局部值）：**

- `Narration` = `objective`
- `result[^1].Text` += `value`
- `Text` = `part`

<a id="symbol-8f114a9558ac"></a>

## `NationalSpire.DateScenes.ShortParts(string, int) — private static IEnumerable<string> ShortParts(string text, int limit)`

来源：源码第 205 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Flush()`](DateSceneData.cs.md#symbol-972103714524)

**调用：** `char.IsWhiteSpace(char)`；`string.Contains(char)`；`System.Globalization.StringInfo.ParseCombiningCharacters(string)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `char.IsWhiteSpace(char)`；输入表达式：`char.IsWhiteSpace(ch)`；返回值紧邻使用处：`BinaryExpressionSyntax: "，,；;：:、".Contains(ch) || char.IsWhiteSpace(ch)`
- `string.Contains(char)`；输入表达式：`"，,；;：:、".Contains(ch)`；返回值紧邻使用处：`BinaryExpressionSyntax: "，,；;：:、".Contains(ch) || char.IsWhiteSpace(ch)`
- `string.Contains(char)`；输入表达式：`"。！？!?…\"”’」』）)".Contains(text[starts[through]])`；返回值紧邻使用处：`BinaryExpressionSyntax: through < starts.Length && through - from < limit && "。！？!?…\"”’」』）)".Contains(text[starts[through]])`
- `string.Contains(char)`；输入表达式：`"。！？!?\n".Contains(ch)`；返回值紧邻使用处：`BinaryExpressionSyntax: "。！？!?\n".Contains(ch) || ch == '…' && i + 1 < starts.Length && text[starts[i + 1]] == '…'`
- `System.Globalization.StringInfo.ParseCombiningCharacters(string)`；输入表达式：`StringInfo.ParseCombiningCharacters(text)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = StringInfo.ParseCombiningCharacters(text)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(limit, starts.Length - from)`；返回值紧邻使用处：`BinaryExpressionSyntax: from + Math.Min(limit, starts.Length - from)`

**赋值（含属性/字段和局部值）：**

- `from` = `through`
- `natural` = `i + 1`
- `through` = `i + 1`
- `through` = `natural`

<a id="symbol-801111e76ca9"></a>

## `NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn) — public static List<DateSceneLine> Lines(PrivateTurn turn)`

来源：源码第 222 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)；[`NationalSpire.DateScenes.History(NationalSpire.PrivateConversation, string, string, int, string, string)`](DateSceneData.cs.md#symbol-13e129fe5e9e)

**调用：** [`NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`](DateSceneData.cs.md#symbol-711ab692d366)；[`NationalSpire.DateScenes.JoinNarration(System.Collections.Generic.List<NationalSpire.DateSceneLine>)`](DateSceneData.cs.md#symbol-da243e86633f)；[`NationalSpire.DateScenes.Split(string, bool)`](DateSceneData.cs.md#symbol-4bfd36365879)；`NationalSpire.DateSceneLine.DateSceneLine()`；`string.Concat(System.Collections.Generic.IEnumerable<string?>)`；`string.IsNullOrWhiteSpace(string?)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneLine.Background`；`NationalSpire.DateSceneLine.Emotion`；`NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.Text`；`NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`；`NationalSpire.DateScenes.JoinNarration(System.Collections.Generic.List<NationalSpire.DateSceneLine>)`；`NationalSpire.DateScenes.Split(string, bool)`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.SceneLines`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneLine.DateSceneLine()`；输入表达式：`new DateSceneLine          { Text = part.Text, Narration = line.Narration || part.Narration, Emotion = line.Emotion, Background = index == 0 ? line.Background : "" }`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: (part, index) => new DateSceneLine          { Text = part.Text, Narration = line.Narration || part.Narration, Emotion = line.Emotion, Background = index == 0 ? line.Background : "" }`
- `NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`；输入表达式：`DisplayText(line)`；返回值紧邻使用处：`ArgumentSyntax: DisplayText(line)`
- `NationalSpire.DateScenes.JoinNarration(System.Collections.Generic.List<NationalSpire.DateSceneLine>)`；输入表达式：`JoinNarration(source.SelectMany(line => Split(line.Text, line.Narration).Select((part, index) => new DateSceneLine          { Text = part.Text, Narration = line.Narration || part.Narration, Emotion = line.Emotion, Background = index == 0 ? line.Background : "" }))              .Where(line => !string.IsNullOrWhiteSpace(DisplayText(line))).ToList())`；返回值紧邻使用处：`ReturnStatementSyntax: return JoinNarration(source.SelectMany(line => Split(line.Text, line.Narration).Select((part, index) => new DateSceneLine          { Text = part.Text, Narration = line.Narration || part.Narration, Emotion = line.Emotion, Background = index == 0 ? line.Background : "" }))              .Where(line => !string.IsNullOrWhiteSpace(DisplayText(line))).ToList());`
- `NationalSpire.DateScenes.Split(string, bool)`；输入表达式：`Split(line.Text, line.Narration)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Split(line.Text, line.Narration).Select`
- `NationalSpire.DateScenes.Split(string, bool)`；输入表达式：`Split(turn.Reply)`；返回值紧邻使用处：`ConditionalExpressionSyntax: turn.SceneLines.Count > 0 && string.Concat(turn.SceneLines.Select(l => l.Text)) == turn.Reply ? turn.SceneLines : Split(turn.Reply)`
- `string.Concat(System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Concat(turn.SceneLines.Select(l => l.Text))`；返回值紧邻使用处：`BinaryExpressionSyntax: string.Concat(turn.SceneLines.Select(l => l.Text)) == turn.Reply`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(DisplayText(line))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(DisplayText(line))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`Split(line.Text, line.Narration).Select((part, index) => new DateSceneLine          { Text = part.Text, Narration = line.Narration || part.Narration, Emotion = line.Emotion, Background = index == 0 ? line.Background : "" })`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: line => Split(line.Text, line.Narration).Select((part, index) => new DateSceneLine          { Text = part.Text, Narration = line.Narration || part.Narration, Emotion = line.Emotion, Background = index == 0 ? line.Background : "" })`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`turn.SceneLines.Select(l => l.Text)`；返回值紧邻使用处：`ArgumentSyntax: turn.SceneLines.Select(l => l.Text)`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`source.SelectMany(line => Split(line.Text, line.Narration).Select((part, index) => new DateSceneLine          { Text = part.Text, Narration = line.Narration || part.Narration, Emotion = line.Emotion, Background = index == 0 ? line.Background : "" }))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: source.SelectMany(line => Split(line.Text, line.Narration).Select((part, index) => new DateSceneLine          { Text = part.Text, Narration = line.Narration || part.Narration, Emotion = line.Emotion, Background = index == 0 ? line.Background : "" }))              .Where`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`source.SelectMany(line => Split(line.Text, line.Narration).Select((part, index) => new DateSceneLine          { Text = part.Text, Narration = line.Narration || part.Narration, Emotion = line.Emotion, Background = index == 0 ? line.Background : "" }))              .Where(line => !string.IsNullOrWhiteSpace(DisplayText(line))).ToList()`；返回值紧邻使用处：`ArgumentSyntax: source.SelectMany(line => Split(line.Text, line.Narration).Select((part, index) => new DateSceneLine          { Text = part.Text, Narration = line.Narration || part.Narration, Emotion = line.Emotion, Background = index == 0 ? line.Background : "" }))              .Where(line => !string.IsNullOrWhiteSpace(DisplayText(line))).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`source.SelectMany(line => Split(line.Text, line.Narration).Select((part, index) => new DateSceneLine          { Text = part.Text, Narration = line.Narration || part.Narration, Emotion = line.Emotion, Background = index == 0 ? line.Background : "" }))              .Where(line => !string.IsNullOrWhiteSpace(DisplayText(line)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: source.SelectMany(line => Split(line.Text, line.Narration).Select((part, index) => new DateSceneLine          { Text = part.Text, Narration = line.Narration || part.Narration, Emotion = line.Emotion, Background = index == 0 ? line.Background : "" }))              .Where(line => !string.IsNullOrWhiteSpace(DisplayText(line))).ToList`

**赋值（含属性/字段和局部值）：**

- `Background` = `index == 0 ? line.Background : ""`
- `Emotion` = `line.Emotion`
- `Narration` = `line.Narration || part.Narration`
- `Text` = `part.Text`

<a id="symbol-da243e86633f"></a>

## `NationalSpire.DateScenes.JoinNarration(System.Collections.Generic.List<NationalSpire.DateSceneLine>) — private static List<DateSceneLine> JoinNarration(List<DateSceneLine> lines)`

来源：源码第 229 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`](DateSceneData.cs.md#symbol-801111e76ca9)；[`NationalSpire.DateScenes.TaggedLines(NationalSpire.PrivateStreamParser, NationalSpire.DateSceneRequest)`](DateSceneData.cs.md#symbol-00bcca1f004c)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Text.RegularExpressions.Regex.IsMatch(string, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneLine.Background`；`NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>()`；输入表达式：`result.LastOrDefault()`；返回值紧邻使用处：`IsPatternExpressionSyntax: result.LastOrDefault() is { Narration: true } previous`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.Add(line)`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Add(line);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<DateSceneLine>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<DateSceneLine>()`
- `System.Text.RegularExpressions.Regex.IsMatch(string, string)`；输入表达式：`Regex.IsMatch(previous.Text, "[。！？!?….][\\s\\\"”’」』）)]*$")`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Regex.IsMatch(previous.Text, "[。！？!?….][\\s\\\"”’」』）)]*$")`

**赋值（含属性/字段和局部值）：**

- `previous.Text` += `line.Text`

<a id="symbol-e19b4e66ad48"></a>

## `NationalSpire.DateScenes.BackgroundAt(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneLine>, int, string) — public static string BackgroundAt(IEnumerable<DateSceneLine> lines, int index, string initial)`

来源：源码第 240 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ApplyDateBackground()`](DateSceneScreen.cs.md#symbol-4c2055af1c70)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneLine.Background`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`lines.Take(index + 1).LastOrDefault(line => line.Background.Length > 0)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: lines.Take(index + 1).LastOrDefault(line => line.Background.Length > 0)?.Background`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`lines.Take(index + 1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: lines.Take(index + 1).LastOrDefault`

**赋值（含属性/字段和局部值）：**


<a id="symbol-711ab692d366"></a>

## `NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine) — public static string DisplayText(DateSceneLine line)`

来源：源码第 242 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.History(NationalSpire.PrivateConversation, string, string, int, string, string)`](DateSceneData.cs.md#symbol-13e129fe5e9e)；[`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`](DateSceneData.cs.md#symbol-801111e76ca9)；[`NationalSpire.DateSceneView.AppendLine(NationalSpire.DateSceneLine)`](DateSceneView.cs.md#symbol-eecb2292c03b)；[`NationalSpire.DateSceneView.ShowLine(NationalSpire.DateSceneLine, string, Godot.Texture2D)`](DateSceneView.cs.md#symbol-1801b5d93aa1)

**调用：** `string.Replace(string, string?)`；`string.Trim()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.Text`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Replace(string, string?)`；输入表达式：`line.Text.Replace("（", "").Replace("）", "").Replace("(", "").Replace(")", "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: line.Text.Replace("（", "").Replace("）", "").Replace("(", "").Replace(")", "").Trim`
- `string.Replace(string, string?)`；输入表达式：`line.Text.Replace("（", "").Replace("）", "").Replace("(", "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: line.Text.Replace("（", "").Replace("）", "").Replace("(", "").Replace`
- `string.Replace(string, string?)`；输入表达式：`line.Text.Replace("（", "").Replace("）", "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: line.Text.Replace("（", "").Replace("）", "").Replace`
- `string.Replace(string, string?)`；输入表达式：`line.Text.Replace("（", "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: line.Text.Replace("（", "").Replace`
- `string.Trim()`；输入表达式：`line.Text.Replace("（", "").Replace("）", "").Replace("(", "").Replace(")", "").Trim()`；返回值紧邻使用处：`ConditionalExpressionSyntax: line.Narration          ? line.Text.Replace("（", "").Replace("）", "").Replace("(", "").Replace(")", "").Trim() : line.Text.Trim()`
- `string.Trim()`；输入表达式：`line.Text.Trim()`；返回值紧邻使用处：`ConditionalExpressionSyntax: line.Narration          ? line.Text.Replace("（", "").Replace("）", "").Replace("(", "").Replace(")", "").Trim() : line.Text.Trim()`

**赋值（含属性/字段和局部值）：**


<a id="symbol-13e129fe5e9e"></a>

## `NationalSpire.DateScenes.History(NationalSpire.PrivateConversation, string, string, int, string, string) — public static string History(PrivateConversation conversation, string offerId, string currentTurn, int index, string player, string npc)`

来源：源码第 244 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateScene(string)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)

**调用：** [`NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`](DateSceneData.cs.md#symbol-711ab692d366)；[`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`](DateSceneData.cs.md#symbol-801111e76ca9)；`string.TrimEnd()`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Text.StringBuilder.AppendLine()`；`System.Text.StringBuilder.AppendLine(string?)`；`System.Text.StringBuilder.StringBuilder()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneRequest.Ending`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateSceneRequest.Opening`；`NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`；`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.User`；`NationalSpire.PrivateTurn.UserDeleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`；输入表达式：`DisplayText(line)`；返回值紧邻使用处：`ArgumentSyntax: DisplayText(line)`
- `NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`；输入表达式：`Lines(turn)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Lines(turn).Take`
- `string.TrimEnd()`；输入表达式：`result.ToString().TrimEnd()`；返回值紧邻使用处：`ConditionalExpressionSyntax: result.Length > 0 ? result.ToString().TrimEnd() : "约会开始后的对话会显示在这里。"`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`Lines(turn).Take(turn.Id == currentTurn ? index + 1 : int.MaxValue)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var line in Lines(turn).Take(turn.Id == currentTurn ? index + 1 : int.MaxValue))                  {                      if (!line.Narration) result.AppendLine(npc);                      result.AppendLine(DisplayText(line)).AppendLine();                  }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Turns.Where(t => t.Scene?.OfferId == offerId)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var turn in conversation.Turns.Where(t => t.Scene?.OfferId == offerId))          {              if (!turn.UserDeleted && turn.Scene?.Opening != true && turn.Scene?.Ending != true && turn.User.Length > 0) result.AppendLine(player).AppendLine(turn.User).AppendLine();              if (!turn.ReplyDeleted && turn.Status == "complete")                  foreach (var line in Lines(turn).Take(turn.Id == currentTurn ? index + 1 : int.MaxValue))                  {                      if (!line.Narration) result.AppendLine(npc);                      result.AppendLine(DisplayText(line)).AppendLine();                  }              if (turn.Id == currentTurn) break;          }`
- `System.Text.StringBuilder.AppendLine()`；输入表达式：`result.AppendLine(DisplayText(line)).AppendLine()`；返回值紧邻使用处：`ExpressionStatementSyntax: result.AppendLine(DisplayText(line)).AppendLine();`
- `System.Text.StringBuilder.AppendLine()`；输入表达式：`result.AppendLine(player).AppendLine(turn.User).AppendLine()`；返回值紧邻使用处：`ExpressionStatementSyntax: result.AppendLine(player).AppendLine(turn.User).AppendLine();`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`result.AppendLine(DisplayText(line))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.AppendLine(DisplayText(line)).AppendLine`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`result.AppendLine(npc)`；返回值紧邻使用处：`ExpressionStatementSyntax: result.AppendLine(npc);`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`result.AppendLine(player).AppendLine(turn.User)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.AppendLine(player).AppendLine(turn.User).AppendLine`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`result.AppendLine(player)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.AppendLine(player).AppendLine`
- `System.Text.StringBuilder.StringBuilder()`；输入表达式：`new StringBuilder()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StringBuilder()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`result.ToString()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.ToString().TrimEnd`

**赋值（含属性/字段和局部值）：**
