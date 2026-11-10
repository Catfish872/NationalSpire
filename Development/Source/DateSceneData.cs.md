# DateSceneData.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`C1977F038084F32124EFC75584DFCC9C6A2FE1FB3B6F37DE8C3DA11D97A36F90`。来源：[源码](../../DateSceneData.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DateSceneRequest`、`NationalSpire.DateSceneLine`、`NationalSpire.DateScenes`。

字段、事件及初始值（源码原样）：

```csharp
public const string Protocol = """
当前进入约会场景，继续使用双方已有私聊记录和关系。围绕约会地点、共同活动与彼此感受展开交流。
以下规则负责约会场景的组织及显示格式，人物语气、性格和用词沿前文规定。台词逐句输出：每个完整句子单独成行，每行开头填写Scene、Emotion、Background；连续属于同一人物的句子也逐句重新标注。Scene填dialogue或narration；Emotion依据这一句的情绪与动作从该人物可用编号重新选择，背景填写本轮可用编号，沿用当前背景时填current。情绪变化时切换对应差分，只有默认图的人物沿用默认编号。旁白按完整语句标注，描述环境及人物动作。
场景连续性：currentBackground是本轮开始时实际显示的地点与时段，说明见backgrounds；Title、Detail是原活动安排。优先承接当前地点和最近已经发生的行动。只有人物实际到达新地点或时间实际变化时，才在对应句段填写新背景编号，之后沿用current。current承接最近一次已发生的转场；回忆、提及其他地点、计划和待选建议均保持现场背景。空的currentBackground表示开场尚未选图，此时依据开场实际地点选择背景。
台词示例：
[Scene: dialogue, Emotion: neutral, Background: current]今天想先去哪里走走？
旁白示例：
[Scene: narration, Emotion: neutral, Background: current]窗边透进柔和的光，桌上的茶还冒着热气。
开场先描写约定地点及人物外观、姿态，再由人物说话。后续承接玩家本轮消息。玩家的发言和行动由玩家决定。活动、赠礼等交互继续使用各自格式。
正文结束后，提供两个简短且不同的玩家回应或动作建议，各用一行 [DateChoice: 建议文字]，每项最多24个字。建议由玩家选择后才发生，正文中保持尚未执行。建议须承接本轮对话；只输出这两条标记，不另写选项标题。
""";
public const int MaxLineCharacters = 48;
```

<a id="symbol-2ff404ccb4ad"></a>

## `NationalSpire.DateSceneRequest.GameInvitation — public bool GameInvitation`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6d091f905f09"></a>

## `NationalSpire.DateSceneRequest.GameContext — public string GameContext`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ed32a27208d7"></a>

## `NationalSpire.DateSceneRequest.GameChatRequest — public string GameChatRequest`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6ef560633743"></a>

## `NationalSpire.DateSceneRequest.GameMatchId — public string GameMatchId`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-422da7b9cade"></a>

## `NationalSpire.DateSceneRequest.GameEvent — public string GameEvent`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-97a6b2724f4c"></a>

## `NationalSpire.DateSceneRequest.Participants — public List<DateSceneParticipant> Participants`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-0054a248837a"></a>

## `NationalSpire.DateSceneRequest.OfferId — public string OfferId`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4acb38c6dea4"></a>

## `NationalSpire.DateSceneRequest.DefaultEmotionId — public string DefaultEmotionId`

来源：源码第 17 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-910087e123a1"></a>

## `NationalSpire.DateSceneRequest.Title — public string Title`

来源：源码第 18 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-35615cbf6d4b"></a>

## `NationalSpire.DateSceneRequest.Detail — public string Detail`

来源：源码第 19 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5170a6b0ef04"></a>

## `NationalSpire.DateSceneRequest.OutfitId — public string OutfitId`

来源：源码第 20 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b30553341429"></a>

## `NationalSpire.DateSceneRequest.Opening — public bool Opening`

来源：源码第 21 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-7ecbd73ba815"></a>

## `NationalSpire.DateSceneRequest.Ending — public bool Ending`

来源：源码第 22 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d9416cbb1012"></a>

## `NationalSpire.DateSceneRequest.Emotions — public Dictionary<string, string> Emotions`

来源：源码第 23 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b1e4d75e2583"></a>

## `NationalSpire.DateSceneRequest.Backgrounds — public Dictionary<string, string> Backgrounds`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-82991a6f8918"></a>

## `NationalSpire.DateSceneRequest.CurrentBackground — public string CurrentBackground`

来源：源码第 25 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-8159eb41b387"></a>

## `NationalSpire.DateSceneLine.Speaker — public string Speaker`

来源：源码第 29 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-53f610fda3e0"></a>

## `NationalSpire.DateSceneLine.Text — public string Text`

来源：源码第 30 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-87e825f01a63"></a>

## `NationalSpire.DateSceneLine.Emotion — public string Emotion`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-46c4bf0bec17"></a>

## `NationalSpire.DateSceneLine.Narration — public bool Narration`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-b9f0b4583c66"></a>

## `NationalSpire.DateSceneLine.SceneContinuation — public bool SceneContinuation`

来源：源码第 34 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-4e7d2cd6abfd"></a>

## `NationalSpire.DateSceneLine.Background — public string Background`

来源：源码第 36 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-42aa2fbcaa1f"></a>

## `NationalSpire.DateScenes.Guidance(NationalSpire.DateSceneRequest, bool) — public static string Guidance(DateSceneRequest scene, bool tools = false)`

来源：源码第 52 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatTools.Create(NationalSpire.CareerData, NationalSpire.PrivateConversation?, NationalSpire.PrivateTurn?, NationalSpire.GroupChat?)`](ChatTools.cs.md#symbol-da501aed0ab9)；[`NationalSpire.PrivateMessagePrompts.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?, string?, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-de94bbbea5ea)

**调用：** [`Format(string)`](DateSceneData.cs.md#symbol-cf8fc3afc5c7)；[`NationalSpire.DateSceneParty.ExchangeExample(NationalSpire.DateSceneRequest)`](DateSceneParty.cs.md#symbol-d5df29df1375)；[`NationalSpire.DateScenes.PromptMaterials(NationalSpire.DateSceneRequest)`](DateSceneData.cs.md#symbol-ef9b9e70ca5d)；[`NationalSpire.IDateSceneExtension.Guidance(NationalSpire.DateSceneRequest, bool)`](DateSceneExtensions.cs.md#symbol-13d12c07d9db)；`string.Replace(string, string?)`

**字段、属性、事件及方法组引用：** `Format(string)`；`NationalSpire.DateGames.InvitationProtocol`；`NationalSpire.DateSceneExtensions.Current`；`NationalSpire.DateSceneParty.ExchangeExample(NationalSpire.DateSceneRequest)`；`NationalSpire.DateSceneParty.Protocol`；`NationalSpire.DateSceneRequest.DefaultEmotionId`；`NationalSpire.DateSceneRequest.GameContext`；`NationalSpire.DateSceneRequest.GameInvitation`；`NationalSpire.DateSceneRequest.Participants`；`NationalSpire.DateScenes.PromptMaterials(NationalSpire.DateSceneRequest)`；`NationalSpire.DateScenes.Protocol`；`NationalSpire.IDateSceneExtension.Guidance(NationalSpire.DateSceneRequest, bool)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Format(string)`；输入表达式：`Format("依据玩家提出的具体技巧，使用现有Skill标记记录确实产生的学习。")`；返回值紧邻使用处：`BinaryExpressionSyntax: "\n本轮消息中提供了当前对局编号、最新进程与聊天缘由，承接该进程交流。" + Format("依据玩家提出的具体技巧，使用现有Skill标记记录确实产生的学习。")`
- `Format(string)`；输入表达式：`Format(DateGames.InvitationProtocol)`；返回值紧邻使用处：`BinaryExpressionSyntax: "\n" + Format(DateGames.InvitationProtocol)`
- `Format(string)`；输入表达式：`Format(DateSceneParty.Protocol + DateSceneParty.ExchangeExample(scene))`；返回值紧邻使用处：`BinaryExpressionSyntax: "\n" + Format(DateSceneParty.Protocol + DateSceneParty.ExchangeExample(scene))`
- `Format(string)`；输入表达式：`Format(Protocol.Replace("Emotion: neutral", "Emotion: " + scene.DefaultEmotionId))`；返回值紧邻使用处：`BinaryExpressionSyntax: Format(Protocol.Replace("Emotion: neutral", "Emotion: " + scene.DefaultEmotionId))          + "\n历史记录会合并同人物、同情绪的连续片段；本轮输出仍逐句标注。当前场景资料（每人的emotions指向emotionSets中同名的完整差分字典）："`
- `NationalSpire.DateSceneParty.ExchangeExample(NationalSpire.DateSceneRequest)`；输入表达式：`DateSceneParty.ExchangeExample(scene)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateSceneParty.Protocol + DateSceneParty.ExchangeExample(scene)`
- `NationalSpire.DateScenes.PromptMaterials(NationalSpire.DateSceneRequest)`；输入表达式：`PromptMaterials(scene)`；返回值紧邻使用处：`BinaryExpressionSyntax: Format(Protocol.Replace("Emotion: neutral", "Emotion: " + scene.DefaultEmotionId))          + "\n历史记录会合并同人物、同情绪的连续片段；本轮输出仍逐句标注。当前场景资料（每人的emotions指向emotionSets中同名的完整差分字典）：" + PromptMaterials(scene)`
- `NationalSpire.IDateSceneExtension.Guidance(NationalSpire.DateSceneRequest, bool)`；输入表达式：`.Guidance(scene, tools)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: DateSceneExtensions.Current?.Guidance(scene, tools)`
- `string.Replace(string, string?)`；输入表达式：`Protocol.Replace("Emotion: neutral", "Emotion: " + scene.DefaultEmotionId)`；返回值紧邻使用处：`ArgumentSyntax: Protocol.Replace("Emotion: neutral", "Emotion: " + scene.DefaultEmotionId)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-cf8fc3afc5c7"></a>

## `Format(string) — string Format(string text)`

来源：源码第 54 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.Guidance(NationalSpire.DateSceneRequest, bool)`](DateSceneData.cs.md#symbol-42aa2fbcaa1f)

**调用：** [`NationalSpire.ChatTools.SceneGuidance(string)`](ChatTools.cs.md#symbol-fdd76a823cce)

**字段、属性、事件及方法组引用：** `NationalSpire.ChatTools.SceneGuidance(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatTools.SceneGuidance(string)`；输入表达式：`ChatTools.SceneGuidance(text)`；返回值紧邻使用处：`ConditionalExpressionSyntax: tools ? ChatTools.SceneGuidance(text) : text`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ef9b9e70ca5d"></a>

## `NationalSpire.DateScenes.PromptMaterials(NationalSpire.DateSceneRequest) — private static string PromptMaterials(DateSceneRequest scene)`

来源：源码第 62 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.Guidance(NationalSpire.DateSceneRequest, bool)`](DateSceneData.cs.md#symbol-42aa2fbcaa1f)

**调用：** [`NationalSpire.IDateSceneExtension.Materials(NationalSpire.DateSceneRequest, System.Collections.Generic.Dictionary<string, object?>)`](DateSceneExtensions.cs.md#symbol-28302b18c917)；[`Register(System.Collections.Generic.Dictionary<string, string>)`](DateSceneData.cs.md#symbol-15bb22af29af)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IEqualityComparer<TKey>?)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `<anonymous type: string PersonId, string Name, string defaultEmotion, string emotions>.defaultEmotion`；`<anonymous type: string PersonId, string Name, string defaultEmotion, string emotions>.emotions`；`NationalSpire.DateSceneExtensions.Current`；`NationalSpire.DateSceneParticipant.DefaultEmotionId`；`NationalSpire.DateSceneParticipant.Emotions`；`NationalSpire.DateSceneParticipant.Name`；`NationalSpire.DateSceneParticipant.PersonId`；`NationalSpire.DateSceneParty.PromptJson`；`NationalSpire.DateSceneRequest.Backgrounds`；`NationalSpire.DateSceneRequest.CurrentBackground`；`NationalSpire.DateSceneRequest.DefaultEmotionId`；`NationalSpire.DateSceneRequest.Detail`；`NationalSpire.DateSceneRequest.Emotions`；`NationalSpire.DateSceneRequest.Opening`；`NationalSpire.DateSceneRequest.Participants`；`NationalSpire.DateSceneRequest.Title`；`NationalSpire.IDateSceneExtension.Materials(NationalSpire.DateSceneRequest, System.Collections.Generic.Dictionary<string, object?>)`；`Register(System.Collections.Generic.Dictionary<string, string>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.IDateSceneExtension.Materials(NationalSpire.DateSceneRequest, System.Collections.Generic.Dictionary<string, object?>)`；输入表达式：`.Materials(scene, material)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: DateSceneExtensions.Current?.Materials(scene, material)`
- `Register(System.Collections.Generic.Dictionary<string, string>)`；输入表达式：`Register(p.Emotions)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: emotions = Register(p.Emotions)`
- `Register(System.Collections.Generic.Dictionary<string, string>)`；输入表达式：`Register(scene.Emotions)`；返回值紧邻使用处：`ConditionalExpressionSyntax: participants.Length == 0 ? Register(scene.Emotions) : null`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, Dictionary<string, string>>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, Dictionary<string, string>>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, object?>          {              ["Title"] = scene.Title, ["Detail"] = scene.Detail, ["Opening"] = scene.Opening,              ["participants"] = participants, ["emotionSets"] = sets,              ["backgrounds"] = scene.Backgrounds, ["currentBackground"] = scene.CurrentBackground          }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, object?>          {              ["Title"] = scene.Title, ["Detail"] = scene.Detail, ["Opening"] = scene.Opening,              ["participants"] = participants, ["emotionSets"] = sets,              ["backgrounds"] = scene.Backgrounds, ["currentBackground"] = scene.CurrentBackground          }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IEqualityComparer<TKey>?)`；输入表达式：`new Dictionary<string, string>(StringComparer.Ordinal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, string>(StringComparer.Ordinal)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`scene.Participants.Select(p => new          { p.PersonId, p.Name, defaultEmotion = p.DefaultEmotionId, emotions = Register(p.Emotions) })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: scene.Participants.Select(p => new          { p.PersonId, p.Name, defaultEmotion = p.DefaultEmotionId, emotions = Register(p.Emotions) }).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`scene.Participants.Select(p => new          { p.PersonId, p.Name, defaultEmotion = p.DefaultEmotionId, emotions = Register(p.Emotions) }).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = scene.Participants.Select(p => new          { p.PersonId, p.Name, defaultEmotion = p.DefaultEmotionId, emotions = Register(p.Emotions) }).ToArray()`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(material, DateSceneParty.PromptJson)`；返回值紧邻使用处：`ReturnStatementSyntax: return JsonSerializer.Serialize(material, DateSceneParty.PromptJson);`

**赋值（含属性/字段和局部值）：**

- `["backgrounds"]` = `scene.Backgrounds`
- `["currentBackground"]` = `scene.CurrentBackground`
- `["Detail"]` = `scene.Detail`
- `["emotionSets"]` = `sets`
- `["Opening"]` = `scene.Opening`
- `["participants"]` = `participants`
- `["Title"]` = `scene.Title`
- `material["defaultEmotion"]` = `scene.DefaultEmotionId`
- `material["emotions"]` = `singleEmotions`

<a id="symbol-15bb22af29af"></a>

## `Register(System.Collections.Generic.Dictionary<string, string>) — string Register(Dictionary<string, string> emotions)`

来源：源码第 66 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.PromptMaterials(NationalSpire.DateSceneRequest)`](DateSceneData.cs.md#symbol-ef9b9e70ca5d)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneParty.PromptJson`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`references.Add(key, id)`；返回值紧邻使用处：`ExpressionStatementSyntax: references.Add(key, id);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Add(TKey, TValue)`；输入表达式：`sets.Add(id, emotions)`；返回值紧邻使用处：`ExpressionStatementSyntax: sets.Add(id, emotions);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`references.TryGetValue(key, out var existing)`；返回值紧邻使用处：`IfStatementSyntax: if (references.TryGetValue(key, out var existing)) return existing;`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`emotions.OrderBy(p => p.Key, StringComparer.Ordinal)`；返回值紧邻使用处：`ArgumentSyntax: emotions.OrderBy(p => p.Key, StringComparer.Ordinal)`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(emotions.OrderBy(p => p.Key, StringComparer.Ordinal), DateSceneParty.PromptJson)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JsonSerializer.Serialize(emotions.OrderBy(p => p.Key, StringComparer.Ordinal), DateSceneParty.PromptJson)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-5652957ff027"></a>

## `NationalSpire.DateScenes.SafeBackgroundId(string) — public static bool SafeBackgroundId(string id)`

来源：源码第 87 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneBackgrounds.SafeId(string)`](DateSceneBackgrounds.cs.md#symbol-19bb6c988fd7)；[`NationalSpire.DateScenes.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest, bool)`](DateSceneData.cs.md#symbol-0fd8375508ff)

**调用：** `char.IsLetterOrDigit(char)`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `char.IsLetterOrDigit(char)`；输入表达式：`char.IsLetterOrDigit(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: char.IsLetterOrDigit(c) || c is '_' or '-'`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`id.All(c => char.IsLetterOrDigit(c) || c is '_' or '-')`；返回值紧邻使用处：`BinaryExpressionSyntax: id.Length is > 0 and <= 100 && id.All(c => char.IsLetterOrDigit(c) || c is '_' or '-')`

**赋值（含属性/字段和局部值）：**


<a id="symbol-dccb0fff0030"></a>

## `NationalSpire.DateScenes.OneToOne(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?) — public static bool OneToOne(CareerData data, PrivateOffer offer, PrivateConversation? conversation)`

来源：源码第 88 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

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

来源：源码第 91 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddDateSceneAction(NationalSpire.CareerData, NationalSpire.PrivateOffer, Godot.HBoxContainer)`](DateSceneScreen.cs.md#symbol-413adf55a103)；[`NationalSpire.CareerScreen.AddPausedDateScenes(NationalSpire.CareerData, NationalSpire.PrivateConversation)`](DateSceneScreen.cs.md#symbol-a5b10d9fb0b8)；[`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)；[`NationalSpire.CareerScreen.ResumeSettledDate(NationalSpire.CareerData, NationalSpire.CareerMatch)`](DateGameReturn.cs.md#symbol-9e75de0044f4)；[`NationalSpire.CareerScreen.ShowSceneOfferOutsideHistory(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer, System.Collections.Generic.IReadOnlySet<string>)`](PrivateMessageScreen.cs.md#symbol-ef223dfd3ae0)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)；[`NationalSpire.DateGames.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>)`](DateGames.cs.md#symbol-e72b5454cf31)；[`NationalSpire.DateGroupBridge.Begin(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.PrivateOffer, bool)`](DateGroupBridge.cs.md#symbol-5d930edf4c6f)；[`NationalSpire.DateScenes.Leave(NationalSpire.CareerData, NationalSpire.PrivateConversation, string, bool)`](DateSceneData.cs.md#symbol-81bdbfbfe1d8)；[`NationalSpire.DateScenes.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest, bool)`](DateSceneData.cs.md#symbol-0fd8375508ff)；[`NationalSpire.PrivateMessages.PrepareAttachments(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>)`](PrivateMessages.cs.md#symbol-f2d6d9cf9c86)

**调用：** [`NationalSpire.DateGroupBridge.SourceActive(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](DateGroupBridge.cs.md#symbol-f6c6214fb9e2)；[`NationalSpire.DateSceneParty.Eligible(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneParty.cs.md#symbol-0b65821baf62)；[`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.DateGroupBridge.SourceActive(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.DateSceneParty.Eligible(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateSceneRequest.Opening`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateConversation.DateSceneStates`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateTurn.Scene`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGroupBridge.SourceActive(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`DateGroupBridge.SourceActive(data, offer)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateSceneParty.Eligible(data, offer, conversation)          && DateGroupBridge.SourceActive(data, offer)`
- `NationalSpire.DateSceneParty.Eligible(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；输入表达式：`DateSceneParty.Eligible(data, offer, conversation)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateSceneParty.Eligible(data, offer, conversation)          && DateGroupBridge.SourceActive(data, offer)`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(data, offer)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateAppointments.Date(data, offer) == data.Day`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Turns.Any(t => t.Scene?.OfferId == offer.Id && t.Scene.Opening)`；返回值紧邻使用处：`BinaryExpressionSyntax: conversation.DateSceneStates.GetValueOrDefault(offer.Id) is "active" or "paused" || conversation.Turns.Any(t => t.Scene?.OfferId == offer.Id && t.Scene.Opening)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.DateSceneStates.GetValueOrDefault(offer.Id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: conversation?.DateSceneStates.GetValueOrDefault(offer.Id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`conversation.DateSceneStates.GetValueOrDefault(offer.Id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: conversation.DateSceneStates.GetValueOrDefault(offer.Id) is "active" or "paused"`

**赋值（含属性/字段和局部值）：**


<a id="symbol-81bdbfbfe1d8"></a>

## `NationalSpire.DateScenes.Leave(NationalSpire.CareerData, NationalSpire.PrivateConversation, string, bool) — public static string? Leave(CareerData data, PrivateConversation conversation, string offerId, bool end)`

来源：源码第 95 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessageCommands.ApplyCore(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-1472969f513b)

**调用：** [`NationalSpire.AiService.CancelPrivate(NationalSpire.CareerData, string)`](AiPrivateMessages.cs.md#symbol-14a6fc19e1c1)；[`NationalSpire.DateDiaries.Begin(NationalSpire.PrivateConversation, NationalSpire.PrivateOffer)`](DateDiaries.cs.md#symbol-25266fe7f850)；[`NationalSpire.DateGroupBridge.Sync(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](DateGroupBridge.cs.md#symbol-26e379588751)；[`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneData.cs.md#symbol-0d3e014bcb63)；[`NationalSpire.PrivateMessageCommands.RestoreInterrupted(NationalSpire.PrivateTurn, string)`](PrivateMessageCommands.cs.md#symbol-82b01f18fa69)；[`NationalSpire.PrivateMessages.Enqueue(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer?, System.Collections.Generic.List<NationalSpire.PrivateOffer>?, string, bool)`](PrivateMessages.cs.md#symbol-0e61d4a7bbb5)；[`NationalSpire.WeddingAppointments.Complete(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-4cb46102c2e0)；`NationalSpire.DateSceneRequest.DateSceneRequest()`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.AiService.CancelPrivate(NationalSpire.CareerData, string)`；`NationalSpire.DateDiaries.Begin(NationalSpire.PrivateConversation, NationalSpire.PrivateOffer)`；`NationalSpire.DateGroupBridge.Sync(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.DateSceneRequest.Detail`；`NationalSpire.DateSceneRequest.Ending`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateSceneRequest.Opening`；`NationalSpire.DateSceneRequest.Title`；`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；`NationalSpire.PrivateConversation.DateSceneStates`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMessageCommands.RestoreInterrupted(NationalSpire.PrivateTurn, string)`；`NationalSpire.PrivateMessages.Enqueue(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer?, System.Collections.Generic.List<NationalSpire.PrivateOffer>?, string, bool)`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateOffer.Title`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.WeddingAppointments.Complete(NationalSpire.CareerData, NationalSpire.PrivateOffer)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.AiService.CancelPrivate(NationalSpire.CareerData, string)`；输入表达式：`AiService.CancelPrivate(data, conversation.PersonId)`；返回值紧邻使用处：`ExpressionStatementSyntax: AiService.CancelPrivate(data, conversation.PersonId);`
- `NationalSpire.DateDiaries.Begin(NationalSpire.PrivateConversation, NationalSpire.PrivateOffer)`；输入表达式：`DateDiaries.Begin(conversation, offer)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateDiaries.Begin(conversation, offer);`
- `NationalSpire.DateGroupBridge.Sync(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`DateGroupBridge.Sync(data, offer)`；返回值紧邻使用处：`ExpressionStatementSyntax: DateGroupBridge.Sync(data, offer);`
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

<a id="symbol-0fd8375508ff"></a>

## `NationalSpire.DateScenes.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest, bool) — public static string? Validate(CareerData data, PrivateConversation conversation, DateSceneRequest request, bool retained = false)`

来源：源码第 120 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)；[`NationalSpire.DateGames.FollowUp(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest)`](DateGames.cs.md#symbol-7a75a34b8321)；[`NationalSpire.DateHistoryRewind.Apply(NationalSpire.CareerData, string, NationalSpire.PrivateMessageCommand, bool)`](DateHistoryRewind.cs.md#symbol-b8b9d3bc8651)；[`NationalSpire.PrivateMessageCommands.ApplyCore(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-1472969f513b)

**调用：** [`NationalSpire.DateGames.ValidateContext(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest, bool)`](DateGames.cs.md#symbol-e6d10e3baa71)；[`NationalSpire.DateSceneParty.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer, NationalSpire.DateSceneRequest)`](DateSceneParty.cs.md#symbol-9fb95a4d45a5)；[`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneData.cs.md#symbol-0d3e014bcb63)；[`NationalSpire.DateScenes.SafeBackgroundId(string)`](DateSceneData.cs.md#symbol-5652957ff027)；[`NationalSpire.PortraitDesigns.SafeId(string)`](PortraitDesign.cs.md#symbol-7497548faaf1)；[`NationalSpire.WeddingAppointments.Description(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-b0c3ba2ccdb6)；[`NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-f30a9608f6f8)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.LocalHumanId`；`NationalSpire.CareerData.PendingMatchId`；`NationalSpire.DateGames.ValidateContext(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest, bool)`；`NationalSpire.DateSceneParty.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer, NationalSpire.DateSceneRequest)`；`NationalSpire.DateSceneRequest.Backgrounds`；`NationalSpire.DateSceneRequest.DefaultEmotionId`；`NationalSpire.DateSceneRequest.Detail`；`NationalSpire.DateSceneRequest.Emotions`；`NationalSpire.DateSceneRequest.Ending`；`NationalSpire.DateSceneRequest.GameInvitation`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateSceneRequest.OutfitId`；`NationalSpire.DateSceneRequest.Title`；`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；`NationalSpire.DateScenes.SafeBackgroundId(string)`；`NationalSpire.PortraitDesigns.SafeId(string)`；`NationalSpire.PrivateConversation.DateSceneStates`；`NationalSpire.PrivateConversation.Offers`；`NationalSpire.PrivateOffer.Detail`；`NationalSpire.PrivateOffer.GroupId`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Title`；`NationalSpire.WeddingAppointments.Description(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGames.ValidateContext(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest, bool)`；输入表达式：`DateGames.ValidateContext(data, conversation, request, retained)`；返回值紧邻使用处：`IsPatternExpressionSyntax: DateGames.ValidateContext(data, conversation, request, retained) is { } gameError`
- `NationalSpire.DateSceneParty.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer, NationalSpire.DateSceneRequest)`；输入表达式：`DateSceneParty.Validate(data, conversation, offer, request)`；返回值紧邻使用处：`IsPatternExpressionSyntax: DateSceneParty.Validate(data, conversation, offer, request) is { } partyError`
- `NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；输入表达式：`Available(data, offer, conversation)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !Available(data, offer, conversation)`
- `NationalSpire.DateScenes.SafeBackgroundId(string)`；输入表达式：`SafeBackgroundId(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !SafeBackgroundId(id)`
- `NationalSpire.PortraitDesigns.SafeId(string)`；输入表达式：`PortraitDesigns.SafeId(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PortraitDesigns.SafeId(id)`
- `NationalSpire.PortraitDesigns.SafeId(string)`；输入表达式：`PortraitDesigns.SafeId(request.OutfitId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PortraitDesigns.SafeId(request.OutfitId)`
- `NationalSpire.WeddingAppointments.Description(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`WeddingAppointments.Description(data, offer)`；返回值紧邻使用处：`BinaryExpressionSyntax: "\n" + WeddingAppointments.Description(data, offer)`
- `NationalSpire.WeddingAppointments.IsWedding(NationalSpire.PrivateOffer)`；输入表达式：`WeddingAppointments.IsWedding(offer)`；返回值紧邻使用处：`ConditionalExpressionSyntax: WeddingAppointments.IsWedding(offer) ? "\n" + WeddingAppointments.Description(data, offer) : ""`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`request.Emotions.ContainsKey(request.DefaultEmotionId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !request.Emotions.ContainsKey(request.DefaultEmotionId)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`request.Backgrounds.Keys.Any(id => !SafeBackgroundId(id))`；返回值紧邻使用处：`BinaryExpressionSyntax: request.Backgrounds == null || request.Backgrounds.Keys.Any(id => !SafeBackgroundId(id))`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`request.Emotions.Keys.Any(id => !PortraitDesigns.SafeId(id))`；返回值紧邻使用处：`BinaryExpressionSyntax: request.Emotions == null || !request.Emotions.ContainsKey(request.DefaultEmotionId) || request.Emotions.Keys.Any(id => !PortraitDesigns.SafeId(id))`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Offers.FirstOrDefault(o => o.Id == request.OfferId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = conversation.Offers.FirstOrDefault(o => o.Id == request.OfferId)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`conversation.DateSceneStates.GetValueOrDefault(request.OfferId)`；返回值紧邻使用处：`BinaryExpressionSyntax: conversation.DateSceneStates.GetValueOrDefault(request.OfferId) != "ended"`

**赋值（含属性/字段和局部值）：**

- `request.Detail` = `offer.Detail + (WeddingAppointments.IsWedding(offer) ? "\n" + WeddingAppointments.Description(data, offer) : "")`
- `request.Title` = `offer.Title`

<a id="symbol-b774d4ba1cbe"></a>

## `NationalSpire.DateScenes.Choices(NationalSpire.PrivateStreamParser) — public static List<string> Choices(PrivateStreamParser parser)`

来源：源码第 138 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)

**调用：** `string.Replace(char, char)`；`string.Trim()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateStreamParser.Directives`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Replace(char, char)`；输入表达式：`d["DateChoice"].Trim().Replace('\n', ' ').Replace('\r', ' ')`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: d => d["DateChoice"].Trim().Replace('\n', ' ').Replace('\r', ' ')`
- `string.Replace(char, char)`；输入表达式：`d["DateChoice"].Trim().Replace('\n', ' ')`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d["DateChoice"].Trim().Replace('\n', ' ').Replace`
- `string.Trim()`；输入表达式：`d["DateChoice"].Trim()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d["DateChoice"].Trim().Replace`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`d.ContainsKey("DateChoice")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: d => d.ContainsKey("DateChoice")`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`；输入表达式：`parser.Directives          .Where(d => d.ContainsKey("DateChoice")).Select(d => d["DateChoice"].Trim().Replace('\n', ' ').Replace('\r', ' '))          .Where(t => t.Length is > 0 and <= 80).Distinct(StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parser.Directives          .Where(d => d.ContainsKey("DateChoice")).Select(d => d["DateChoice"].Trim().Replace('\n', ' ').Replace('\r', ' '))          .Where(t => t.Length is > 0 and <= 80).Distinct(StringComparer.Ordinal).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`parser.Directives          .Where(d => d.ContainsKey("DateChoice")).Select(d => d["DateChoice"].Trim().Replace('\n', ' ').Replace('\r', ' '))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parser.Directives          .Where(d => d.ContainsKey("DateChoice")).Select(d => d["DateChoice"].Trim().Replace('\n', ' ').Replace('\r', ' '))          .Where`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`parser.Directives          .Where(d => d.ContainsKey("DateChoice")).Select(d => d["DateChoice"].Trim().Replace('\n', ' ').Replace('\r', ' '))          .Where(t => t.Length is > 0 and <= 80).Distinct(StringComparer.Ordinal).Take(2)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parser.Directives          .Where(d => d.ContainsKey("DateChoice")).Select(d => d["DateChoice"].Trim().Replace('\n', ' ').Replace('\r', ' '))          .Where(t => t.Length is > 0 and <= 80).Distinct(StringComparer.Ordinal).Take(2).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`parser.Directives          .Where(d => d.ContainsKey("DateChoice")).Select(d => d["DateChoice"].Trim().Replace('\n', ' ').Replace('\r', ' '))          .Where(t => t.Length is > 0 and <= 80).Distinct(StringComparer.Ordinal).Take(2).ToList()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => parser.Directives          .Where(d => d.ContainsKey("DateChoice")).Select(d => d["DateChoice"].Trim().Replace('\n', ' ').Replace('\r', ' '))          .Where(t => t.Length is > 0 and <= 80).Distinct(StringComparer.Ordinal).Take(2).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`parser.Directives          .Where(d => d.ContainsKey("DateChoice")).Select(d => d["DateChoice"].Trim().Replace('\n', ' ').Replace('\r', ' '))          .Where(t => t.Length is > 0 and <= 80)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parser.Directives          .Where(d => d.ContainsKey("DateChoice")).Select(d => d["DateChoice"].Trim().Replace('\n', ' ').Replace('\r', ' '))          .Where(t => t.Length is > 0 and <= 80).Distinct`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`parser.Directives          .Where(d => d.ContainsKey("DateChoice"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parser.Directives          .Where(d => d.ContainsKey("DateChoice")).Select`

**赋值（含属性/字段和局部值）：**


<a id="symbol-00bcca1f004c"></a>

## `NationalSpire.DateScenes.TaggedLines(NationalSpire.PrivateStreamParser, NationalSpire.DateSceneRequest) — public static List<DateSceneLine> TaggedLines(PrivateStreamParser parser, DateSceneRequest scene)`

来源：源码第 141 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)；[`Progress(string)`](AiPrivateMessages.cs.md#symbol-bdf6717976f9)

**调用：** [`NationalSpire.DateSceneParty.ForSpeaker(NationalSpire.DateSceneRequest, string)`](DateSceneParty.cs.md#symbol-c3a9f302456e)；[`NationalSpire.DateScenes.JoinNarration(System.Collections.Generic.List<NationalSpire.DateSceneLine>)`](DateSceneData.cs.md#symbol-da243e86633f)；[`Segment(int)`](DateSceneData.cs.md#symbol-0336a6b42ddf)；`string.TrimEnd()`；`string.TrimStart()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Last<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.List()`；`System.Math.Max(int, int)`

**字段、属性、事件及方法组引用：** `(int Offset, System.Collections.Generic.Dictionary<string, string> Fields).Fields`；`(int Offset, System.Collections.Generic.Dictionary<string, string> Fields).Offset`；`NationalSpire.DateSceneLine.Emotion`；`NationalSpire.DateSceneLine.Speaker`；`NationalSpire.DateSceneParty.ForSpeaker(NationalSpire.DateSceneRequest, string)`；`NationalSpire.DateSceneRequest.DefaultEmotionId`；`NationalSpire.DateSceneRequest.Emotions`；`NationalSpire.DateScenes.JoinNarration(System.Collections.Generic.List<NationalSpire.DateSceneLine>)`；`NationalSpire.PrivateStreamParser.SceneCues`；`NationalSpire.PrivateStreamParser.Text`；`Segment(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneParty.ForSpeaker(NationalSpire.DateSceneRequest, string)`；输入表达式：`DateSceneParty.ForSpeaker(scene, line.Speaker)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneParty.ForSpeaker(scene, line.Speaker)`
- `NationalSpire.DateScenes.JoinNarration(System.Collections.Generic.List<NationalSpire.DateSceneLine>)`；输入表达式：`JoinNarration(result)`；返回值紧邻使用处：`ReturnStatementSyntax: return JoinNarration(result);`
- `Segment(int)`；输入表达式：`Segment(cue.Offset)`；返回值紧邻使用处：`ExpressionStatementSyntax: Segment(cue.Offset);`
- `Segment(int)`；输入表达式：`Segment(end)`；返回值紧邻使用处：`ExpressionStatementSyntax: Segment(end);`
- `string.TrimEnd()`；输入表达式：`source.TrimEnd()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: source.TrimEnd().Length`
- `string.TrimStart()`；输入表达式：`source.TrimStart()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: source.TrimStart().Length`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`speaker.Emotions.ContainsKey(line.Emotion)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !speaker.Emotions.ContainsKey(line.Emotion)`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`parser.SceneCues.Where(c => c.Offset <= end).GroupBy(c => Math.Max(start, c.Offset))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parser.SceneCues.Where(c => c.Offset <= end).GroupBy(c => Math.Max(start, c.Offset)).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Last<TSource>()`；输入表达式：`g.Last()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Last().Fields`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`parser.SceneCues.Where(c => c.Offset <= end).GroupBy(c => Math.Max(start, c.Offset)).Select(g => (Offset:g.Key, Fields:g.Last().Fields))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parser.SceneCues.Where(c => c.Offset <= end).GroupBy(c => Math.Max(start, c.Offset)).Select(g => (Offset:g.Key, Fields:g.Last().Fields)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`parser.SceneCues.Where(c => c.Offset <= end).GroupBy(c => Math.Max(start, c.Offset)).Select(g => (Offset:g.Key, Fields:g.Last().Fields)).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = parser.SceneCues.Where(c => c.Offset <= end).GroupBy(c => Math.Max(start, c.Offset)).Select(g => (Offset:g.Key, Fields:g.Last().Fields)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`parser.SceneCues.Where(c => c.Offset <= end)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parser.SceneCues.Where(c => c.Offset <= end).GroupBy`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<DateSceneLine>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<DateSceneLine>()`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(start, c.Offset)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => Math.Max(start, c.Offset)`

**赋值（含属性/字段和局部值）：**

- `fields` = `cue.Fields`
- `line.Emotion` = `speaker.DefaultEmotionId`

<a id="symbol-0336a6b42ddf"></a>

## `Segment(int) — void Segment(int limit)`

来源：源码第 147 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 163 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 175 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Add(string)`](DateSceneData.cs.md#symbol-dc8d8641b666)

**调用：** `string.Split(params char[]?)`；`System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`；`System.Text.RegularExpressions.Regex.IsMatch(string, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneRequest.DefaultEmotionId`；`NationalSpire.DateSceneRequest.Emotions`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Split(params char[]?)`；输入表达式：`description.Split('：', ':')`；返回值紧邻使用处：`ElementAccessExpressionSyntax: description.Split('：', ':')[0]`
- `System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`；输入表达式：`Regex.IsMatch(id + "|" + description.Split('：', ':')[0], names, RegexOptions.IgnoreCase)`；返回值紧邻使用处：`IfStatementSyntax: if (Regex.IsMatch(id + "|" + description.Split('：', ':')[0], names, RegexOptions.IgnoreCase)) return id;`
- `System.Text.RegularExpressions.Regex.IsMatch(string, string)`；输入表达式：`Regex.IsMatch(text, words)`；返回值紧邻使用处：`IfStatementSyntax: if (Regex.IsMatch(text, words))                  foreach (var (id, description) in scene.Emotions)                      if (Regex.IsMatch(id + "|" + description.Split('：', ':')[0], names, RegexOptions.IgnoreCase)) return id;`

**赋值（含属性/字段和局部值）：**


<a id="symbol-df380ec1333f"></a>

## `NationalSpire.DateScenes.ReadSegment(string, NationalSpire.DateSceneRequest, System.Collections.Generic.Dictionary<string, string>?) — private static List<DateSceneLine> ReadSegment(string text, DateSceneRequest scene, Dictionary<string, string>? fields)`

来源：源码第 196 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Segment(int)`](DateSceneData.cs.md#symbol-0336a6b42ddf)

**调用：** [`Add(string)`](DateSceneData.cs.md#symbol-dc8d8641b666)；[`NationalSpire.DateSceneParty.ForSpeaker(NationalSpire.DateSceneRequest, string)`](DateSceneParty.cs.md#symbol-c3a9f302456e)；[`NationalSpire.DateSceneParty.Resolve(NationalSpire.DateSceneRequest, string)`](DateSceneParty.cs.md#symbol-6bfcef03874d)；[`NationalSpire.DateScenes.EmotionId(NationalSpire.DateSceneRequest, string)`](DateSceneData.cs.md#symbol-a6609cbcddd2)；[`NationalSpire.IDateSceneExtension.ReadSegment(NationalSpire.DateSceneRequest, System.Collections.Generic.Dictionary<string, string>?, System.Collections.Generic.List<NationalSpire.DateSceneLine>)`](DateSceneExtensions.cs.md#symbol-a9b634965b55)；`string.ToLowerInvariant()`；`string.Trim()`；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.List<T>.List()`；`System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`；`System.Text.RegularExpressions.Regex.Matches(string, string)`；`System.Text.RegularExpressions.Regex.Replace(string, string, string, System.Text.RegularExpressions.RegexOptions)`

**字段、属性、事件及方法组引用：** `Add(string)`；`NationalSpire.DateSceneExtensions.Current`；`NationalSpire.DateSceneParty.ForSpeaker(NationalSpire.DateSceneRequest, string)`；`NationalSpire.DateSceneParty.Resolve(NationalSpire.DateSceneRequest, string)`；`NationalSpire.DateSceneRequest.DefaultEmotionId`；`NationalSpire.DateScenes.EmotionId(NationalSpire.DateSceneRequest, string)`；`NationalSpire.IDateSceneExtension.ReadSegment(NationalSpire.DateSceneRequest, System.Collections.Generic.Dictionary<string, string>?, System.Collections.Generic.List<NationalSpire.DateSceneLine>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Add(string)`；输入表达式：`Add(text[at..])`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(text[at..]);`
- `Add(string)`；输入表达式：`Add(text[at..tag.Index])`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(text[at..tag.Index]);`
- `NationalSpire.DateSceneParty.ForSpeaker(NationalSpire.DateSceneRequest, string)`；输入表达式：`DateSceneParty.ForSpeaker(scene, speaker)`；返回值紧邻使用处：`AssignmentExpressionSyntax: scene = DateSceneParty.ForSpeaker(scene, speaker)`
- `NationalSpire.DateSceneParty.Resolve(NationalSpire.DateSceneRequest, string)`；输入表达式：`DateSceneParty.Resolve(scene, fields?.GetValueOrDefault("Speaker", "") ?? "")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneParty.Resolve(scene, fields?.GetValueOrDefault("Speaker", "") ?? "")`
- `NationalSpire.DateScenes.EmotionId(NationalSpire.DateSceneRequest, string)`；输入表达式：`EmotionId(scene, candidate)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = EmotionId(scene, candidate)`
- `NationalSpire.DateScenes.EmotionId(NationalSpire.DateSceneRequest, string)`；输入表达式：`EmotionId(scene, fields["Emotion"])`；返回值紧邻使用处：`BinaryExpressionSyntax: EmotionId(scene, fields["Emotion"]) ?? scene.DefaultEmotionId`
- `NationalSpire.IDateSceneExtension.ReadSegment(NationalSpire.DateSceneRequest, System.Collections.Generic.Dictionary<string, string>?, System.Collections.Generic.List<NationalSpire.DateSceneLine>)`；输入表达式：`.ReadSegment(original, fields, result)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: DateSceneExtensions.Current?.ReadSegment(original, fields, result)`
- `string.ToLowerInvariant()`；输入表达式：`.GetValueOrDefault("Scene", "").ToLowerInvariant()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: fields?.GetValueOrDefault("Scene", "").ToLowerInvariant()`
- `string.Trim()`；输入表达式：`tag.Groups["value"].Value.Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = tag.Groups["value"].Value.Trim()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`.ContainsKey("Emotion")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: fields?.ContainsKey("Emotion")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`.GetValueOrDefault("Background", "")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: fields?.GetValueOrDefault("Background", "")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`.GetValueOrDefault("Scene", "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: .GetValueOrDefault("Scene", "").ToLowerInvariant`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`.GetValueOrDefault("Speaker", "")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: fields?.GetValueOrDefault("Speaker", "")`
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
- `scene` = `DateSceneParty.ForSpeaker(scene, speaker)`

<a id="symbol-dc8d8641b666"></a>

## `Add(string) — void Add(string part)`

来源：源码第 205 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.ReadSegment(string, NationalSpire.DateSceneRequest, System.Collections.Generic.Dictionary<string, string>?)`](DateSceneData.cs.md#symbol-df380ec1333f)

**调用：** [`NationalSpire.DateScenes.InferEmotion(NationalSpire.DateSceneRequest, string)`](DateSceneData.cs.md#symbol-9848e1f83c4c)；[`NationalSpire.DateScenes.Split(string, bool)`](DateSceneData.cs.md#symbol-4bfd36365879)；[`NationalSpire.DateScenes.SplitSentences(string, bool, int)`](DateSceneData.cs.md#symbol-dd74e35c7d6b)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.List<T>.List()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneLine.Background`；`NationalSpire.DateSceneLine.Emotion`；`NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.Speaker`；`NationalSpire.DateSceneLine.Text`；`NationalSpire.DateSceneRequest.Backgrounds`；`NationalSpire.DateSceneRequest.DefaultEmotionId`；`NationalSpire.DateScenes.InferEmotion(NationalSpire.DateSceneRequest, string)`；`NationalSpire.DateScenes.Split(string, bool)`；`NationalSpire.DateScenes.SplitSentences(string, bool, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateScenes.InferEmotion(NationalSpire.DateSceneRequest, string)`；输入表达式：`InferEmotion(scene, sentence.Text)`；返回值紧邻使用处：`BinaryExpressionSyntax: emotion ?? InferEmotion(scene, sentence.Text)`
- `NationalSpire.DateScenes.Split(string, bool)`；输入表达式：`Split(sentence.Text, sentence.Narration)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var line in Split(sentence.Text, sentence.Narration))                  {                      line.Speaker = line.Narration ? "" : speaker;                      line.Emotion = sentenceEmotion;                      lines.Add(line);                  }`
- `NationalSpire.DateScenes.SplitSentences(string, bool, int)`；输入表达式：`SplitSentences(part, kind is "narration" or "旁白", int.MaxValue)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var sentence in SplitSentences(part, kind is "narration" or "旁白", int.MaxValue))              {                  string sentenceEmotion = sentence.Narration ? scene.DefaultEmotionId : emotion ?? InferEmotion(scene, sentence.Text);                  foreach (var line in Split(sentence.Text, sentence.Narration))                  {                      line.Speaker = line.Narration ? "" : speaker;                      line.Emotion = sentenceEmotion;                      lines.Add(line);                  }                  // A Scene/Emotion cue owns its entire text segment. Sentence and                  // display-length splits retain it until the next explicit cue.              }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`original.Backgrounds.ContainsKey(background)`；返回值紧邻使用处：`BinaryExpressionSyntax: lines.Count > 0 && original.Backgrounds.ContainsKey(background)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`lines.Add(line)`；返回值紧邻使用处：`ExpressionStatementSyntax: lines.Add(line);`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`result.AddRange(lines)`；返回值紧邻使用处：`ExpressionStatementSyntax: result.AddRange(lines);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<DateSceneLine>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<DateSceneLine>()`

**赋值（含属性/字段和局部值）：**

- `background` = `""`
- `line.Emotion` = `sentenceEmotion`
- `line.Speaker` = `line.Narration ? "" : speaker`
- `lines[0].Background` = `background`
- `result[^1].Text` += `part`

<a id="symbol-76bee931e453"></a>

## `NationalSpire.DateScenes.ReplyFailure(string) — public static string? ReplyFailure(string text)`

来源：源码第 242 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)

**调用：** `System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`；输入表达式：`Regex.IsMatch(text,          @"我(?:无法|不能)(?:为你|为您)?(?:生成|提供)|NSFW", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Regex.IsMatch(text,          @"我(?:无法|不能)(?:为你|为您)?(?:生成|提供)|NSFW", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant)          ? "本轮回复包含模型拒绝生成的内容，请重新生成或编辑文字后发送。" : null`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4bfd36365879"></a>

## `NationalSpire.DateScenes.Split(string, bool) — public static List<DateSceneLine> Split(string text, bool narration = false)`

来源：源码第 246 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Add(string)`](DateSceneData.cs.md#symbol-dc8d8641b666)；[`NationalSpire.DateScenes.DisplayParts(NationalSpire.DateSceneLine)`](DateSceneData.cs.md#symbol-2d444f7f549e)；[`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`](DateSceneData.cs.md#symbol-801111e76ca9)

**调用：** [`NationalSpire.DateScenes.SplitSentences(string, bool, int)`](DateSceneData.cs.md#symbol-dd74e35c7d6b)

**字段、属性、事件及方法组引用：** `NationalSpire.DateScenes.MaxLineCharacters`；`NationalSpire.DateScenes.SplitSentences(string, bool, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateScenes.SplitSentences(string, bool, int)`；输入表达式：`SplitSentences(text, narration, MaxLineCharacters)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => SplitSentences(text, narration, MaxLineCharacters)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f781869eac8a"></a>

## `NationalSpire.DateScenes.ExpressionSpans(string) — private static List<(int Start, int End)> ExpressionSpans(string text)`

来源：源码第 248 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.ShortParts(string, int)`](DateSceneData.cs.md#symbol-8f114a9558ac)；[`NationalSpire.DateScenes.SplitSentences(string, bool, int)`](DateSceneData.cs.md#symbol-dd74e35c7d6b)

**调用：** `char.IsPunctuation(char)`；`char.IsSymbol(char)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Text.RegularExpressions.Regex.Matches(string, string, System.Text.RegularExpressions.RegexOptions)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `char.IsPunctuation(char)`；输入表达式：`char.IsPunctuation(ch)`；返回值紧邻使用处：`BinaryExpressionSyntax: char.IsPunctuation(ch) || char.IsSymbol(ch)`
- `char.IsSymbol(char)`；输入表达式：`char.IsSymbol(ch)`；返回值紧邻使用处：`BinaryExpressionSyntax: char.IsPunctuation(ch) || char.IsSymbol(ch)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`face.Any(ch => ch is >= '\u3400' and <= '\u9fff')`；返回值紧邻使用处：`BinaryExpressionSyntax: face.Any(ch => ch is >= '\u3400' and <= '\u9fff') || match.Length > 120`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`face.Any(ch => char.IsPunctuation(ch) || char.IsSymbol(ch))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !face.Any(ch => char.IsPunctuation(ch) || char.IsSymbol(ch))`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.Add((match.Index, match.Index + match.Length))`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Add((match.Index, match.Index + match.Length));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<(int, int)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<(int, int)>()`
- `System.Text.RegularExpressions.Regex.Matches(string, string, System.Text.RegularExpressions.RegexOptions)`；输入表达式：`Regex.Matches(text, pattern, RegexOptions.CultureInvariant)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (Match match in Regex.Matches(text, pattern, RegexOptions.CultureInvariant))          {              string face = match.Groups["face"].Value;              if (face.Any(ch => ch is >= '\u3400' and <= '\u9fff') || match.Length > 120) continue;              if (face.Length > 1 && !face.Any(ch => char.IsPunctuation(ch) || char.IsSymbol(ch))) continue;              result.Add((match.Index, match.Index + match.Length));          }`

**赋值（含属性/字段和局部值）：**


<a id="symbol-64fe7cb50f21"></a>

## `NationalSpire.DateScenes.SentenceTail(string, int, System.Collections.Generic.Dictionary<int, int>) — private static int SentenceTail(string text, int at, Dictionary<int, int> expressions)`

来源：源码第 264 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.SplitSentences(string, bool, int)`](DateSceneData.cs.md#symbol-dd74e35c7d6b)

**调用：** `string.Contains(char)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Globalization.StringInfo.GetNextTextElement(string, int)`；`System.Text.Rune.GetUnicodeCategory(System.Text.Rune)`；`System.Text.Rune.TryGetRuneAt(string, int, out System.Text.Rune)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Contains(char)`；输入表达式：`"。！？!?…\"”’」』）)".Contains(text[at])`；返回值紧邻使用处：`IfStatementSyntax: if ("。！？!?…\"”’」』）)".Contains(text[at])) { at++; continue; }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`expressions.TryGetValue(at, out int end)`；返回值紧邻使用处：`IfStatementSyntax: if (expressions.TryGetValue(at, out int end)) { at = end; continue; }`
- `System.Globalization.StringInfo.GetNextTextElement(string, int)`；输入表达式：`StringInfo.GetNextTextElement(text, at)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: StringInfo.GetNextTextElement(text, at).Length`
- `System.Text.Rune.GetUnicodeCategory(System.Text.Rune)`；输入表达式：`Rune.GetUnicodeCategory(rune)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Rune.GetUnicodeCategory(rune) is UnicodeCategory.OtherSymbol or UnicodeCategory.ModifierSymbol`
- `System.Text.Rune.TryGetRuneAt(string, int, out System.Text.Rune)`；输入表达式：`Rune.TryGetRuneAt(text, at, out var rune)`；返回值紧邻使用处：`BinaryExpressionSyntax: Rune.TryGetRuneAt(text, at, out var rune) && Rune.GetUnicodeCategory(rune) is UnicodeCategory.OtherSymbol or UnicodeCategory.ModifierSymbol`

**赋值（含属性/字段和局部值）：**

- `at` += `StringInfo.GetNextTextElement(text, at).Length`
- `at` = `end`

<a id="symbol-dd74e35c7d6b"></a>

## `NationalSpire.DateScenes.SplitSentences(string, bool, int) — private static List<DateSceneLine> SplitSentences(string text, bool narration, int limit)`

来源：源码第 276 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Add(string)`](DateSceneData.cs.md#symbol-dc8d8641b666)；[`NationalSpire.DateScenes.Split(string, bool)`](DateSceneData.cs.md#symbol-4bfd36365879)

**调用：** [`Flush()`](DateSceneData.cs.md#symbol-d44125df6223)；[`NationalSpire.DateScenes.ExpressionSpans(string)`](DateSceneData.cs.md#symbol-f781869eac8a)；[`NationalSpire.DateScenes.SentenceTail(string, int, System.Collections.Generic.Dictionary<int, int>)`](DateSceneData.cs.md#symbol-64fe7cb50f21)；`char.IsWhiteSpace(char)`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.List<T>.List()`；`System.Text.StringBuilder.Append(char)`；`System.Text.StringBuilder.Append(string?, int, int)`；`System.Text.StringBuilder.StringBuilder()`

**字段、属性、事件及方法组引用：** `(int Start, int End).End`；`(int Start, int End).Start`；`Flush()`；`NationalSpire.DateScenes.ExpressionSpans(string)`；`NationalSpire.DateScenes.SentenceTail(string, int, System.Collections.Generic.Dictionary<int, int>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `char.IsWhiteSpace(char)`；输入表达式：`char.IsWhiteSpace(text[i + 1])`；返回值紧邻使用处：`BinaryExpressionSyntax: i + 1 == text.Length || char.IsWhiteSpace(text[i + 1])`
- `Flush()`；输入表达式：`Flush()`；返回值紧邻使用处：`ExpressionStatementSyntax: Flush();`
- `NationalSpire.DateScenes.ExpressionSpans(string)`；输入表达式：`ExpressionSpans(text)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ExpressionSpans(text).ToDictionary`
- `NationalSpire.DateScenes.SentenceTail(string, int, System.Collections.Generic.Dictionary<int, int>)`；输入表达式：`SentenceTail(text, i + 1, expressions)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SentenceTail(text, i + 1, expressions)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`expressions.TryGetValue(i, out int expressionEnd)`；返回值紧邻使用处：`IfStatementSyntax: if (expressions.TryGetValue(i, out int expressionEnd))              { buffer.Append(text, i, expressionEnd - i); i = expressionEnd - 1; continue; }`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`ExpressionSpans(text).ToDictionary(span => span.Start, span => span.End)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ExpressionSpans(text).ToDictionary(span => span.Start, span => span.End)`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<DateSceneLine>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<DateSceneLine>()`
- `System.Text.StringBuilder.Append(char)`；输入表达式：`buffer.Append(ch)`；返回值紧邻使用处：`ExpressionStatementSyntax: buffer.Append(ch);`
- `System.Text.StringBuilder.Append(string?, int, int)`；输入表达式：`buffer.Append(text, i + 1, end - i - 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: buffer.Append(text, i + 1, end - i - 1);`
- `System.Text.StringBuilder.Append(string?, int, int)`；输入表达式：`buffer.Append(text, i, expressionEnd - i)`；返回值紧邻使用处：`ExpressionStatementSyntax: buffer.Append(text, i, expressionEnd - i);`
- `System.Text.StringBuilder.StringBuilder()`；输入表达式：`new StringBuilder()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StringBuilder()`

**赋值（含属性/字段和局部值）：**

- `i` = `end - 1`
- `i` = `expressionEnd - 1`

<a id="symbol-d44125df6223"></a>

## `Flush() — void Flush()`

来源：源码第 280 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.SplitSentences(string, bool, int)`](DateSceneData.cs.md#symbol-dd74e35c7d6b)

**调用：** [`NationalSpire.DateScenes.ShortParts(string, int)`](DateSceneData.cs.md#symbol-8f114a9558ac)；`NationalSpire.DateSceneLine.DateSceneLine()`；`string.IsNullOrWhiteSpace(string?)`；`string.StartsWith(char)`；`string.Trim()`；`System.Collections.Generic.List<T>.Add(T)`；`System.Text.RegularExpressions.Regex.IsMatch(string, string)`；`System.Text.StringBuilder.Clear()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.Text`；`NationalSpire.DateScenes.ShortParts(string, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneLine.DateSceneLine()`；输入表达式：`new() { Text = part, Narration = objective }`；返回值紧邻使用处：`ArgumentSyntax: new() { Text = part, Narration = objective }`
- `NationalSpire.DateScenes.ShortParts(string, int)`；输入表达式：`ShortParts(value, objective ? int.MaxValue : limit)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string part in ShortParts(value, objective ? int.MaxValue : limit)) result.Add(new() { Text = part, Narration = objective });`
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

来源：源码第 307 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Flush()`](DateSceneData.cs.md#symbol-d44125df6223)

**调用：** [`CanCut(int)`](DateSceneData.cs.md#symbol-5aaa0833e082)；[`NationalSpire.DateScenes.ExpressionSpans(string)`](DateSceneData.cs.md#symbol-f781869eac8a)；`char.IsWhiteSpace(char)`；`string.Contains(char)`；`System.Globalization.StringInfo.ParseCombiningCharacters(string)`；`System.Math.Min(int, int)`

**字段、属性、事件及方法组引用：** `CanCut(int)`；`NationalSpire.DateScenes.ExpressionSpans(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CanCut(int)`；输入表达式：`CanCut(starts[i + 1])`；返回值紧邻使用处：`BinaryExpressionSyntax: i + 1 == starts.Length || CanCut(starts[i + 1])`
- `CanCut(int)`；输入表达式：`CanCut(starts[through])`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CanCut(starts[through])`
- `char.IsWhiteSpace(char)`；输入表达式：`char.IsWhiteSpace(ch)`；返回值紧邻使用处：`BinaryExpressionSyntax: "，,；;：:".Contains(ch) || char.IsWhiteSpace(ch)`
- `NationalSpire.DateScenes.ExpressionSpans(string)`；输入表达式：`ExpressionSpans(text)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ExpressionSpans(text)`
- `string.Contains(char)`；输入表达式：`"，,；;：:".Contains(ch)`；返回值紧邻使用处：`BinaryExpressionSyntax: "，,；;：:".Contains(ch) || char.IsWhiteSpace(ch)`
- `System.Globalization.StringInfo.ParseCombiningCharacters(string)`；输入表达式：`StringInfo.ParseCombiningCharacters(text)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = StringInfo.ParseCombiningCharacters(text)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(limit, starts.Length - from)`；返回值紧邻使用处：`BinaryExpressionSyntax: from + Math.Min(limit, starts.Length - from)`

**赋值（含属性/字段和局部值）：**

- `from` = `through`
- `natural` = `i + 1`
- `through` = `fallback`
- `through` = `natural`

<a id="symbol-5aaa0833e082"></a>

## `CanCut(int) — bool CanCut(int at)`

来源：源码第 311 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.ShortParts(string, int)`](DateSceneData.cs.md#symbol-8f114a9558ac)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `(int Start, int End).End`；`(int Start, int End).Start`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`expressions.Any(span => at > span.Start && at < span.End)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !expressions.Any(span => at > span.Start && at < span.End)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-801111e76ca9"></a>

## `NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn) — public static List<DateSceneLine> Lines(PrivateTurn turn)`

来源：源码第 333 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.DateHistoryHasReply(NationalSpire.PrivateTurn)`](DateHistoryReplayScreen.cs.md#symbol-7558f6f313ac)；[`NationalSpire.CareerScreen.FinishDateHistory()`](DateHistoryReplayScreen.cs.md#symbol-fe282030be0f)；[`NationalSpire.CareerScreen.JumpDateHistory(string)`](DateHistoryReplayScreen.cs.md#symbol-7a7ba1016ab5)；[`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)；[`NationalSpire.DateMemoryRecorder.Sync(NationalSpire.PrivateConversation)`](DateSceneMemories.cs.md#symbol-949d37f3d89e)；[`NationalSpire.DateSceneParty.SharedMemory(NationalSpire.CareerData, string, string)`](DateSceneParty.cs.md#symbol-5315c2e1b812)；[`NationalSpire.DateScenes.HistoryEntries(NationalSpire.PrivateConversation, string, string, int, string, string)`](DateSceneData.cs.md#symbol-e8fbec0a77e3)；[`NationalSpire.DateScenes.PromptHistory(NationalSpire.PrivateTurn, string)`](DateSceneData.cs.md#symbol-1bee81f08078)

**调用：** [`NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`](DateSceneData.cs.md#symbol-711ab692d366)；[`NationalSpire.DateScenes.JoinNarration(System.Collections.Generic.List<NationalSpire.DateSceneLine>)`](DateSceneData.cs.md#symbol-da243e86633f)；[`NationalSpire.DateScenes.RestoreSentenceEmotions(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>)`](DateSceneData.cs.md#symbol-c33e325f9eea)；[`NationalSpire.DateScenes.Split(string, bool)`](DateSceneData.cs.md#symbol-4bfd36365879)；`string.Concat(System.Collections.Generic.IEnumerable<string?>)`；`string.IsNullOrWhiteSpace(string?)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneLine.Text`；`NationalSpire.DateScenes.DisplayParts(NationalSpire.DateSceneLine)`；`NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`；`NationalSpire.DateScenes.JoinNarration(System.Collections.Generic.List<NationalSpire.DateSceneLine>)`；`NationalSpire.DateScenes.RestoreSentenceEmotions(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>)`；`NationalSpire.DateScenes.Split(string, bool)`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.SceneLines`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`；输入表达式：`DisplayText(line)`；返回值紧邻使用处：`ArgumentSyntax: DisplayText(line)`
- `NationalSpire.DateScenes.JoinNarration(System.Collections.Generic.List<NationalSpire.DateSceneLine>)`；输入表达式：`JoinNarration(source.SelectMany(DisplayParts)              .Where(line => !string.IsNullOrWhiteSpace(DisplayText(line))).ToList())`；返回值紧邻使用处：`EqualsValueClauseSyntax: = JoinNarration(source.SelectMany(DisplayParts)              .Where(line => !string.IsNullOrWhiteSpace(DisplayText(line))).ToList())`
- `NationalSpire.DateScenes.RestoreSentenceEmotions(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>)`；输入表达式：`RestoreSentenceEmotions(lines)`；返回值紧邻使用处：`ExpressionStatementSyntax: RestoreSentenceEmotions(lines);`
- `NationalSpire.DateScenes.Split(string, bool)`；输入表达式：`Split(turn.Reply)`；返回值紧邻使用处：`ConditionalExpressionSyntax: turn.SceneLines.Count > 0 && string.Concat(turn.SceneLines.Select(l => l.Text)) == turn.Reply ? turn.SceneLines : Split(turn.Reply)`
- `string.Concat(System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Concat(turn.SceneLines.Select(l => l.Text))`；返回值紧邻使用处：`BinaryExpressionSyntax: string.Concat(turn.SceneLines.Select(l => l.Text)) == turn.Reply`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(DisplayText(line))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(DisplayText(line))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`turn.SceneLines.Select(l => l.Text)`；返回值紧邻使用处：`ArgumentSyntax: turn.SceneLines.Select(l => l.Text)`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`source.SelectMany(DisplayParts)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: source.SelectMany(DisplayParts)              .Where`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`source.SelectMany(DisplayParts)              .Where(line => !string.IsNullOrWhiteSpace(DisplayText(line))).ToList()`；返回值紧邻使用处：`ArgumentSyntax: source.SelectMany(DisplayParts)              .Where(line => !string.IsNullOrWhiteSpace(DisplayText(line))).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`source.SelectMany(DisplayParts)              .Where(line => !string.IsNullOrWhiteSpace(DisplayText(line)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: source.SelectMany(DisplayParts)              .Where(line => !string.IsNullOrWhiteSpace(DisplayText(line))).ToList`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c33e325f9eea"></a>

## `NationalSpire.DateScenes.RestoreSentenceEmotions(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>) — public static void RestoreSentenceEmotions(IReadOnlyList<DateSceneLine> lines)`

来源：源码第 341 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateMemoryPlayback.BuildPages()`](DateSceneMemoryPlayback.cs.md#symbol-e09e5b7ddabe)；[`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`](DateSceneData.cs.md#symbol-801111e76ca9)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneLine.Emotion`；`NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.SceneContinuation`；`NationalSpire.DateSceneLine.Speaker`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `lines[i].Emotion` = `lines[i - 1].Emotion`

<a id="symbol-2d444f7f549e"></a>

## `NationalSpire.DateScenes.DisplayParts(NationalSpire.DateSceneLine) — private static IEnumerable<DateSceneLine> DisplayParts(DateSceneLine line)`

来源：源码第 347 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** [`NationalSpire.DateScenes.Split(string, bool)`](DateSceneData.cs.md#symbol-4bfd36365879)；[`NationalSpire.ExtensibleData.CopyExtra()`](ExtensionData.cs.md#symbol-e92ffbabd9a6)；[`NationalSpire.IDateSceneExtension.SplitLine(NationalSpire.DateSceneLine, NationalSpire.DateSceneLine, int)`](DateSceneExtensions.cs.md#symbol-7ce3600d7671)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneExtensions.Current`；`NationalSpire.DateSceneLine.Background`；`NationalSpire.DateSceneLine.Emotion`；`NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.SceneContinuation`；`NationalSpire.DateSceneLine.Speaker`；`NationalSpire.DateSceneLine.Text`；`NationalSpire.DateScenes.Split(string, bool)`；`NationalSpire.ExtensibleData.CopyExtra()`；`NationalSpire.ExtensibleData.Extra`；`NationalSpire.IDateSceneExtension.SplitLine(NationalSpire.DateSceneLine, NationalSpire.DateSceneLine, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateScenes.Split(string, bool)`；输入表达式：`Split(line.Text, line.Narration)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Split(line.Text, line.Narration)`
- `NationalSpire.ExtensibleData.CopyExtra()`；输入表达式：`line.CopyExtra()`；返回值紧邻使用处：`AssignmentExpressionSyntax: part.Extra = line.CopyExtra()`
- `NationalSpire.IDateSceneExtension.SplitLine(NationalSpire.DateSceneLine, NationalSpire.DateSceneLine, int)`；输入表达式：`.SplitLine(line, part, index)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: DateSceneExtensions.Current?.SplitLine(line, part, index)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`parts.Select((part, index) =>          {              part.Speaker = line.Speaker; part.Narration |= line.Narration; part.Emotion = line.Emotion;              part.Background = index == 0 ? line.Background : ""; part.Extra = line.CopyExtra();              part.SceneContinuation = !part.Narration && (line.SceneContinuation || index > 0);              DateSceneExtensions.Current?.SplitLine(line, part, index);              return part;          })`；返回值紧邻使用处：`ReturnStatementSyntax: return parts.Select((part, index) =>          {              part.Speaker = line.Speaker; part.Narration |= line.Narration; part.Emotion = line.Emotion;              part.Background = index == 0 ? line.Background : ""; part.Extra = line.CopyExtra();              part.SceneContinuation = !part.Narration && (line.SceneContinuation || index > 0);              DateSceneExtensions.Current?.SplitLine(line, part, index);              return part;          });`

**赋值（含属性/字段和局部值）：**

- `part.Background` = `index == 0 ? line.Background : ""`
- `part.Emotion` = `line.Emotion`
- `part.Extra` = `line.CopyExtra()`
- `part.Narration` |= `line.Narration`
- `part.SceneContinuation` = `!part.Narration && (line.SceneContinuation || index > 0)`
- `part.Speaker` = `line.Speaker`

<a id="symbol-1bee81f08078"></a>

## `NationalSpire.DateScenes.PromptHistory(NationalSpire.PrivateTurn, string) — public static string PromptHistory(PrivateTurn turn, string host)`

来源：源码第 359 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatTimeline.PrivateHistory(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?)`](ChatTimeline.cs.md#symbol-4c7ee0ce6871)；[`NationalSpire.DateDiaries.Guidance(NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest)`](DateDiaries.cs.md#symbol-81cb927c13c4)

**调用：** [`Flush()`](DateSceneData.cs.md#symbol-58fa9ff0ce57)；[`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`](DateSceneData.cs.md#symbol-801111e76ca9)；[`NationalSpire.IDateSceneExtension.MergeHistory(NationalSpire.DateSceneLine, NationalSpire.DateSceneLine)`](DateSceneExtensions.cs.md#symbol-b666a4747dcc)；`System.Text.StringBuilder.Append(string?)`；`System.Text.StringBuilder.StringBuilder()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `Flush()`；`NationalSpire.DateSceneExtensions.Current`；`NationalSpire.DateSceneLine.Background`；`NationalSpire.DateSceneLine.Emotion`；`NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.Speaker`；`NationalSpire.DateSceneLine.Text`；`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`；`NationalSpire.IDateSceneExtension.MergeHistory(NationalSpire.DateSceneLine, NationalSpire.DateSceneLine)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Flush()`；输入表达式：`Flush()`；返回值紧邻使用处：`ExpressionStatementSyntax: Flush();`
- `NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`；输入表达式：`Lines(turn)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var line in Lines(turn))          {              // 历史恢复真实的说话人/情绪/转场边界；界面自动分页无需重复完整显示标签。              bool same = current != null && line.Narration == current.Narration && line.Speaker == current.Speaker                  && (line.Narration || line.Emotion == current.Emotion && (DateSceneExtensions.Current?.MergeHistory(current, line) ?? true)) && line.Background.Length == 0;              if (!same) { Flush(); current = line; }              body.Append(line.Text);          }`
- `NationalSpire.IDateSceneExtension.MergeHistory(NationalSpire.DateSceneLine, NationalSpire.DateSceneLine)`；输入表达式：`.MergeHistory(current, line)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: DateSceneExtensions.Current?.MergeHistory(current, line)`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`body.Append(line.Text)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.Append(line.Text);`
- `System.Text.StringBuilder.StringBuilder()`；输入表达式：`new StringBuilder()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StringBuilder()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`result.ToString()`；返回值紧邻使用处：`ReturnStatementSyntax: return result.ToString();`

**赋值（含属性/字段和局部值）：**

- `current` = `line`

<a id="symbol-58fa9ff0ce57"></a>

## `Flush() — void Flush()`

来源：源码第 362 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.PromptHistory(NationalSpire.PrivateTurn, string)`](DateSceneData.cs.md#symbol-1bee81f08078)

**调用：** [`NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`](DateSceneData.cs.md#symbol-711ab692d366)；[`NationalSpire.IDateSceneExtension.HistoryCue(NationalSpire.DateSceneLine)`](DateSceneExtensions.cs.md#symbol-5dda5c304d1f)；`NationalSpire.DateSceneLine.DateSceneLine()`；`string.Trim()`；`System.Text.StringBuilder.Append(char)`；`System.Text.StringBuilder.Append(string?)`；`System.Text.StringBuilder.Clear()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneExtensions.Current`；`NationalSpire.DateSceneLine.Background`；`NationalSpire.DateSceneLine.Emotion`；`NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.Speaker`；`NationalSpire.DateSceneLine.Text`；`NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`；`NationalSpire.IDateSceneExtension.HistoryCue(NationalSpire.DateSceneLine)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneLine.DateSceneLine()`；输入表达式：`new() { Narration = true, Text = body.ToString() }`；返回值紧邻使用处：`ArgumentSyntax: new() { Narration = true, Text = body.ToString() }`
- `NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`；输入表达式：`DisplayText(new() { Narration = true, Text = body.ToString() })`；返回值紧邻使用处：`ArgumentSyntax: DisplayText(new() { Narration = true, Text = body.ToString() })`
- `NationalSpire.IDateSceneExtension.HistoryCue(NationalSpire.DateSceneLine)`；输入表达式：`.HistoryCue(current)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: DateSceneExtensions.Current?.HistoryCue(current)`
- `string.Trim()`；输入表达式：`body.ToString().Trim()`；返回值紧邻使用处：`ArgumentSyntax: body.ToString().Trim()`
- `System.Text.StringBuilder.Append(char)`；输入表达式：`result.Append('\n')`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Append('\n');`
- `System.Text.StringBuilder.Append(char)`；输入表达式：`result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host)                  .Append(", Emotion: ").Append(current.Emotion).Append(DateSceneExtensions.Current?.HistoryCue(current) ?? "").Append(", Background: ").Append(background).Append(']')`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host)                  .Append(", Emotion: ").Append(current.Emotion).Append(DateSceneExtensions.Current?.HistoryCue(current) ?? "").Append(", Background: ").Append(background).Append(']').Append`
- `System.Text.StringBuilder.Append(char)`；输入表达式：`result.Append("[Scene: narration, Background: ").Append(background).Append(']')`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Append("[Scene: narration, Background: ").Append(background).Append(']')                      .Append`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host)                  .Append(", Emotion: ").Append(current.Emotion).Append(DateSceneExtensions.Current?.HistoryCue(current) ?? "").Append(", Background: ").Append(background).Append(']').Append(body.ToString().Trim())`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host)                  .Append(", Emotion: ").Append(current.Emotion).Append(DateSceneExtensions.Current?.HistoryCue(current) ?? "").Append(", Background: ").Append(background).Append(']').Append(body.ToString().Trim());`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host)                  .Append(", Emotion: ").Append(current.Emotion).Append(DateSceneExtensions.Current?.HistoryCue(current) ?? "").Append(", Background: ").Append(background)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host)                  .Append(", Emotion: ").Append(current.Emotion).Append(DateSceneExtensions.Current?.HistoryCue(current) ?? "").Append(", Background: ").Append(background).Append`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host)                  .Append(", Emotion: ").Append(current.Emotion).Append(DateSceneExtensions.Current?.HistoryCue(current) ?? "").Append(", Background: ")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host)                  .Append(", Emotion: ").Append(current.Emotion).Append(DateSceneExtensions.Current?.HistoryCue(current) ?? "").Append(", Background: ").Append`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host)                  .Append(", Emotion: ").Append(current.Emotion).Append(DateSceneExtensions.Current?.HistoryCue(current) ?? "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host)                  .Append(", Emotion: ").Append(current.Emotion).Append(DateSceneExtensions.Current?.HistoryCue(current) ?? "").Append`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host)                  .Append(", Emotion: ").Append(current.Emotion)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host)                  .Append(", Emotion: ").Append(current.Emotion).Append`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host)                  .Append(", Emotion: ")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host)                  .Append(", Emotion: ").Append`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host)                  .Append`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`result.Append("[Scene: dialogue, Speaker: ")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Append("[Scene: dialogue, Speaker: ").Append`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`result.Append("[Scene: narration, Background: ").Append(background).Append(']')                      .Append(DisplayText(new() { Narration = true, Text = body.ToString() }))`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Append("[Scene: narration, Background: ").Append(background).Append(']')                      .Append(DisplayText(new() { Narration = true, Text = body.ToString() }));`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`result.Append("[Scene: narration, Background: ").Append(background)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Append("[Scene: narration, Background: ").Append(background).Append`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`result.Append("[Scene: narration, Background: ")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Append("[Scene: narration, Background: ").Append`
- `System.Text.StringBuilder.Clear()`；输入表达式：`body.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: body.Clear();`
- `System.Text.StringBuilder.ToString()`；输入表达式：`body.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Text = body.ToString()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`body.ToString()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: body.ToString().Trim`

**赋值（含属性/字段和局部值）：**

- `Narration` = `true`
- `Text` = `body.ToString()`

<a id="symbol-da243e86633f"></a>

## `NationalSpire.DateScenes.JoinNarration(System.Collections.Generic.List<NationalSpire.DateSceneLine>) — private static List<DateSceneLine> JoinNarration(List<DateSceneLine> lines)`

来源：源码第 384 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

<a id="symbol-4fd8ecc5aec1"></a>

## `NationalSpire.DateScenes.BackgroundAt(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneLine>, int, string, System.Collections.Generic.ISet<string>?) — public static string BackgroundAt(IEnumerable<DateSceneLine> lines, int index, string initial, ISet<string>? available = null)`

来源：源码第 395 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneBackgrounds.At(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>, System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, string, string)`](DateSceneBackgrounds.cs.md#symbol-0f51af8c0e19)

**调用：** `System.Collections.Generic.ICollection<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneLine.Background`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.ICollection<T>.Contains(T)`；输入表达式：`available.Contains(line.Background)`；返回值紧邻使用处：`BinaryExpressionSyntax: available == null || available.Contains(line.Background)`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`lines.Take(index + 1).LastOrDefault(line => line.Background.Length > 0 && line.Background != "current"              && (available == null || available.Contains(line.Background)))`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: lines.Take(index + 1).LastOrDefault(line => line.Background.Length > 0 && line.Background != "current"              && (available == null || available.Contains(line.Background)))?.Background`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`lines.Take(index + 1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: lines.Take(index + 1).LastOrDefault`

**赋值（含属性/字段和局部值）：**


<a id="symbol-711ab692d366"></a>

## `NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine) — public static string DisplayText(DateSceneLine line)`

来源：源码第 398 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Flush()`](DateSceneData.cs.md#symbol-58fa9ff0ce57)；[`NationalSpire.DateMemoryPlayback.History()`](DateSceneMemoryPlayback.cs.md#symbol-b888e2863847)；[`NationalSpire.DateMemoryPlayback.HistoryEntries()`](DateSceneMemoryPlayback.cs.md#symbol-095d68561b37)；[`NationalSpire.DateSceneParty.SharedMemory(NationalSpire.CareerData, string, string)`](DateSceneParty.cs.md#symbol-5315c2e1b812)；[`NationalSpire.DateScenes.HistoryEntries(NationalSpire.PrivateConversation, string, string, int, string, string)`](DateSceneData.cs.md#symbol-e8fbec0a77e3)；[`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`](DateSceneData.cs.md#symbol-801111e76ca9)；[`NationalSpire.DateSceneView.AppendLine(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, System.Func<(string Name, Godot.Texture2D Texture)>?)`](DateSceneView.cs.md#symbol-c061601183cb)；[`NationalSpire.DateSceneView.ShowLineCore(NationalSpire.DateSceneLine, string, Godot.Texture2D, bool)`](DateSceneView.cs.md#symbol-d19549d8d807)

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

来源：源码第 400 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)

**调用：** [`NationalSpire.DateScenes.HistoryEntries(NationalSpire.PrivateConversation, string, string, int, string, string)`](DateSceneData.cs.md#symbol-e8fbec0a77e3)；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateHistoryEntry.Text`；`NationalSpire.DateScenes.HistoryEntries(NationalSpire.PrivateConversation, string, string, int, string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateScenes.HistoryEntries(NationalSpire.PrivateConversation, string, string, int, string, string)`；输入表达式：`HistoryEntries(conversation, offerId, currentTurn, index, player, npc)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = HistoryEntries(conversation, offerId, currentTurn, index, player, npc)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n\n", entries.Select(e => e.Text))`；返回值紧邻使用处：`ConditionalExpressionSyntax: entries.Count > 0 ? string.Join("\n\n", entries.Select(e => e.Text)) : "约会开始后的对话会显示在这里。"`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`entries.Select(e => e.Text)`；返回值紧邻使用处：`ArgumentSyntax: entries.Select(e => e.Text)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e8fbec0a77e3"></a>

## `NationalSpire.DateScenes.HistoryEntries(NationalSpire.PrivateConversation, string, string, int, string, string) — public static IReadOnlyList<DateHistoryEntry> HistoryEntries(PrivateConversation conversation, string offerId, string currentTurn, int index, string player, string npc)`

来源：源码第 405 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)；[`NationalSpire.DateScenes.History(NationalSpire.PrivateConversation, string, string, int, string, string)`](DateSceneData.cs.md#symbol-13e129fe5e9e)

**调用：** [`NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`](DateSceneData.cs.md#symbol-711ab692d366)；[`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`](DateSceneData.cs.md#symbol-801111e76ca9)；`NationalSpire.DateHistoryEntry.DateHistoryEntry(string, string, bool)`；`string.IsNullOrEmpty(string?)`；`string.TrimEnd()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Text.StringBuilder.AppendLine()`；`System.Text.StringBuilder.AppendLine(string?)`；`System.Text.StringBuilder.StringBuilder()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.Speaker`；`NationalSpire.DateSceneParticipant.Name`；`NationalSpire.DateSceneParticipant.PersonId`；`NationalSpire.DateSceneRequest.Ending`；`NationalSpire.DateSceneRequest.GameEvent`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateSceneRequest.Opening`；`NationalSpire.DateSceneRequest.Participants`；`NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`；`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.User`；`NationalSpire.PrivateTurn.UserDeleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateHistoryEntry.DateHistoryEntry(string, string, bool)`；输入表达式：`new(turn.Id, player + "\n" + turn.User, false)`；返回值紧邻使用处：`ArgumentSyntax: new(turn.Id, player + "\n" + turn.User, false)`
- `NationalSpire.DateHistoryEntry.DateHistoryEntry(string, string, bool)`；输入表达式：`new(turn.Id, text.ToString().TrimEnd(), true)`；返回值紧邻使用处：`ArgumentSyntax: new(turn.Id, text.ToString().TrimEnd(), true)`
- `NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`；输入表达式：`DisplayText(line)`；返回值紧邻使用处：`ArgumentSyntax: DisplayText(line)`
- `NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`；输入表达式：`Lines(turn)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Lines(turn).Take`
- `string.IsNullOrEmpty(string?)`；输入表达式：`string.IsNullOrEmpty(turn.Scene?.GameEvent)`；返回值紧邻使用处：`BinaryExpressionSyntax: !turn.UserDeleted && turn.Scene?.Opening != true && turn.Scene?.Ending != true && string.IsNullOrEmpty(turn.Scene?.GameEvent)`
- `string.TrimEnd()`；输入表达式：`text.ToString().TrimEnd()`；返回值紧邻使用处：`ArgumentSyntax: text.ToString().TrimEnd()`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Participants.FirstOrDefault(p => p.PersonId == line.Speaker)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .Participants.FirstOrDefault(p => p.PersonId == line.Speaker)?.Name`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`Lines(turn).Take(turn.Id == currentTurn ? index + 1 : int.MaxValue)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var line in Lines(turn).Take(turn.Id == currentTurn ? index + 1 : int.MaxValue))                  {                      if (!line.Narration) text.AppendLine(turn.Scene?.Participants.FirstOrDefault(p => p.PersonId == line.Speaker)?.Name ?? npc);                      text.AppendLine(DisplayText(line)).AppendLine();                  }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Turns.Where(t => t.Scene?.OfferId == offerId)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var turn in conversation.Turns.Where(t => t.Scene?.OfferId == offerId))          {              if (!turn.UserDeleted && turn.Scene?.Opening != true && turn.Scene?.Ending != true && string.IsNullOrEmpty(turn.Scene?.GameEvent) && turn.User.Length > 0) result.Add(new(turn.Id, player + "\n" + turn.User, false));              if (!turn.ReplyDeleted && turn.Status == "complete")              {                  var text = new StringBuilder();                  foreach (var line in Lines(turn).Take(turn.Id == currentTurn ? index + 1 : int.MaxValue))                  {                      if (!line.Narration) text.AppendLine(turn.Scene?.Participants.FirstOrDefault(p => p.PersonId == line.Speaker)?.Name ?? npc);                      text.AppendLine(DisplayText(line)).AppendLine();                  }                  if (text.Length > 0) result.Add(new(turn.Id, text.ToString().TrimEnd(), true));              }              if (turn.Id == currentTurn) break;          }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.Add(new(turn.Id, player + "\n" + turn.User, false))`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Add(new(turn.Id, player + "\n" + turn.User, false));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.Add(new(turn.Id, text.ToString().TrimEnd(), true))`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Add(new(turn.Id, text.ToString().TrimEnd(), true));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<DateHistoryEntry>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<DateHistoryEntry>()`
- `System.Text.StringBuilder.AppendLine()`；输入表达式：`text.AppendLine(DisplayText(line)).AppendLine()`；返回值紧邻使用处：`ExpressionStatementSyntax: text.AppendLine(DisplayText(line)).AppendLine();`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`text.AppendLine(DisplayText(line))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.AppendLine(DisplayText(line)).AppendLine`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`text.AppendLine(turn.Scene?.Participants.FirstOrDefault(p => p.PersonId == line.Speaker)?.Name ?? npc)`；返回值紧邻使用处：`ExpressionStatementSyntax: text.AppendLine(turn.Scene?.Participants.FirstOrDefault(p => p.PersonId == line.Speaker)?.Name ?? npc);`
- `System.Text.StringBuilder.StringBuilder()`；输入表达式：`new StringBuilder()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StringBuilder()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`text.ToString()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.ToString().TrimEnd`

**赋值（含属性/字段和局部值）：**
