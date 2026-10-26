# DateSceneData.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`B459823B7A41827566CAD087EBF8A2A7C3716F096898630641FC0E660770EE5F`。来源：[源码](../../DateSceneData.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

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

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6d091f905f09"></a>

## `NationalSpire.DateSceneRequest.GameContext — public string GameContext`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-ed32a27208d7"></a>

## `NationalSpire.DateSceneRequest.GameChatRequest — public string GameChatRequest`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-6ef560633743"></a>

## `NationalSpire.DateSceneRequest.GameMatchId — public string GameMatchId`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-422da7b9cade"></a>

## `NationalSpire.DateSceneRequest.GameEvent — public string GameEvent`

来源：源码第 14 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-97a6b2724f4c"></a>

## `NationalSpire.DateSceneRequest.Participants — public List<DateSceneParticipant> Participants`

来源：源码第 15 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

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

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

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


<a id="symbol-4e7d2cd6abfd"></a>

## `NationalSpire.DateSceneLine.Background — public string Background`

来源：源码第 33 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-42aa2fbcaa1f"></a>

## `NationalSpire.DateScenes.Guidance(NationalSpire.DateSceneRequest, bool) — public static string Guidance(DateSceneRequest scene, bool tools = false)`

来源：源码第 49 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatTools.Create(NationalSpire.CareerData, NationalSpire.PrivateConversation?, NationalSpire.PrivateTurn?, NationalSpire.GroupChat?)`](ChatTools.cs.md#symbol-da501aed0ab9)；[`NationalSpire.PrivateMessagePrompts.Compose(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?, string?, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-de94bbbea5ea)

**调用：** [`Format(string)`](DateSceneData.cs.md#symbol-484b95e40c27)；[`NationalSpire.DateSceneParty.ExchangeExample(NationalSpire.DateSceneRequest)`](DateSceneParty.cs.md#symbol-d5df29df1375)；[`NationalSpire.DateScenes.PromptMaterials(NationalSpire.DateSceneRequest)`](DateSceneData.cs.md#symbol-ef9b9e70ca5d)；`string.Replace(string, string?)`

**字段、属性、事件及方法组引用：** `Format(string)`；`NationalSpire.DateGames.InvitationProtocol`；`NationalSpire.DateSceneParty.ExchangeExample(NationalSpire.DateSceneRequest)`；`NationalSpire.DateSceneParty.Protocol`；`NationalSpire.DateSceneRequest.DefaultEmotionId`；`NationalSpire.DateSceneRequest.GameContext`；`NationalSpire.DateSceneRequest.GameInvitation`；`NationalSpire.DateSceneRequest.Participants`；`NationalSpire.DateScenes.PromptMaterials(NationalSpire.DateSceneRequest)`；`NationalSpire.DateScenes.Protocol`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Format(string)`；输入表达式：`Format("依据玩家提出的具体技巧，使用现有Skill标记记录确实产生的学习。")`；返回值紧邻使用处：`BinaryExpressionSyntax: "\n本轮消息中提供了当前对局编号、最新进程与聊天缘由，承接该进程交流。" + Format("依据玩家提出的具体技巧，使用现有Skill标记记录确实产生的学习。")`
- `Format(string)`；输入表达式：`Format(DateGames.InvitationProtocol)`；返回值紧邻使用处：`BinaryExpressionSyntax: "\n" + Format(DateGames.InvitationProtocol)`
- `Format(string)`；输入表达式：`Format(DateSceneParty.Protocol + DateSceneParty.ExchangeExample(scene))`；返回值紧邻使用处：`BinaryExpressionSyntax: "\n" + Format(DateSceneParty.Protocol + DateSceneParty.ExchangeExample(scene))`
- `Format(string)`；输入表达式：`Format(Protocol.Replace("Emotion: neutral", "Emotion: " + scene.DefaultEmotionId))`；返回值紧邻使用处：`BinaryExpressionSyntax: Format(Protocol.Replace("Emotion: neutral", "Emotion: " + scene.DefaultEmotionId)) + "\n历史记录会合并同人物、同情绪的连续片段；本轮输出仍逐句标注。当前场景资料（每人的emotions指向emotionSets中同名的完整差分字典）："`
- `NationalSpire.DateSceneParty.ExchangeExample(NationalSpire.DateSceneRequest)`；输入表达式：`DateSceneParty.ExchangeExample(scene)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateSceneParty.Protocol + DateSceneParty.ExchangeExample(scene)`
- `NationalSpire.DateScenes.PromptMaterials(NationalSpire.DateSceneRequest)`；输入表达式：`PromptMaterials(scene)`；返回值紧邻使用处：`BinaryExpressionSyntax: Format(Protocol.Replace("Emotion: neutral", "Emotion: " + scene.DefaultEmotionId)) + "\n历史记录会合并同人物、同情绪的连续片段；本轮输出仍逐句标注。当前场景资料（每人的emotions指向emotionSets中同名的完整差分字典）：" + PromptMaterials(scene)`
- `string.Replace(string, string?)`；输入表达式：`Protocol.Replace("Emotion: neutral", "Emotion: " + scene.DefaultEmotionId)`；返回值紧邻使用处：`ArgumentSyntax: Protocol.Replace("Emotion: neutral", "Emotion: " + scene.DefaultEmotionId)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-484b95e40c27"></a>

## `Format(string) — string Format(string text)`

来源：源码第 51 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.Guidance(NationalSpire.DateSceneRequest, bool)`](DateSceneData.cs.md#symbol-42aa2fbcaa1f)

**调用：** [`NationalSpire.ChatTools.SceneGuidance(string)`](ChatTools.cs.md#symbol-fdd76a823cce)

**字段、属性、事件及方法组引用：** `NationalSpire.ChatTools.SceneGuidance(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.ChatTools.SceneGuidance(string)`；输入表达式：`ChatTools.SceneGuidance(text)`；返回值紧邻使用处：`ConditionalExpressionSyntax: tools ? ChatTools.SceneGuidance(text) : text`

**赋值（含属性/字段和局部值）：**


<a id="symbol-ef9b9e70ca5d"></a>

## `NationalSpire.DateScenes.PromptMaterials(NationalSpire.DateSceneRequest) — private static string PromptMaterials(DateSceneRequest scene)`

来源：源码第 58 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.Guidance(NationalSpire.DateSceneRequest, bool)`](DateSceneData.cs.md#symbol-42aa2fbcaa1f)

**调用：** [`Register(System.Collections.Generic.Dictionary<string, string>)`](DateSceneData.cs.md#symbol-6062c19c6f71)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IEqualityComparer<TKey>?)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneParticipant.DefaultEmotionId`；`NationalSpire.DateSceneParticipant.Emotions`；`NationalSpire.DateSceneParticipant.Name`；`NationalSpire.DateSceneParticipant.PersonId`；`NationalSpire.DateSceneParty.PromptJson`；`NationalSpire.DateSceneRequest.Backgrounds`；`NationalSpire.DateSceneRequest.CurrentBackground`；`NationalSpire.DateSceneRequest.DefaultEmotionId`；`NationalSpire.DateSceneRequest.Detail`；`NationalSpire.DateSceneRequest.Emotions`；`NationalSpire.DateSceneRequest.Opening`；`NationalSpire.DateSceneRequest.Participants`；`NationalSpire.DateSceneRequest.Title`；`Register(System.Collections.Generic.Dictionary<string, string>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Register(System.Collections.Generic.Dictionary<string, string>)`；输入表达式：`Register(p.Emotions)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: emotions = Register(p.Emotions)`
- `Register(System.Collections.Generic.Dictionary<string, string>)`；输入表达式：`Register(scene.Emotions)`；返回值紧邻使用处：`ConditionalExpressionSyntax: participants.Length == 0 ? Register(scene.Emotions) : null`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, Dictionary<string, string>>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, Dictionary<string, string>>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, object?> { ["Title"] = scene.Title, ["Detail"] = scene.Detail, ["Opening"] = scene.Opening, ["participants"] = participants, ["emotionSets"] = sets, ["backgrounds"] = scene.Backgrounds, ["currentBackground"] = scene.CurrentBackground }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, object?> { ["Title"] = scene.Title, ["Detail"] = scene.Detail, ["Opening"] = scene.Opening, ["participants"] = participants, ["emotionSets"] = sets, ["backgrounds"] = scene.Backgrounds, ["currentBackground"] = scene.CurrentBackground }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary(System.Collections.Generic.IEqualityComparer<TKey>?)`；输入表达式：`new Dictionary<string, string>(StringComparer.Ordinal)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, string>(StringComparer.Ordinal)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`scene.Participants.Select(p => new { p.PersonId, p.Name, defaultEmotion = p.DefaultEmotionId, emotions = Register(p.Emotions) })`；返回值紧邻使用处：`MemberAccessExpressionSyntax: scene.Participants.Select(p => new { p.PersonId, p.Name, defaultEmotion = p.DefaultEmotionId, emotions = Register(p.Emotions) }).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`scene.Participants.Select(p => new { p.PersonId, p.Name, defaultEmotion = p.DefaultEmotionId, emotions = Register(p.Emotions) }).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = scene.Participants.Select(p => new { p.PersonId, p.Name, defaultEmotion = p.DefaultEmotionId, emotions = Register(p.Emotions) }).ToArray()`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(material, DateSceneParty.PromptJson)`；返回值紧邻使用处：`ReturnStatementSyntax: return JsonSerializer.Serialize(material, DateSceneParty.PromptJson);`

**赋值（含属性/字段和局部值）：**

- `["Detail"]` = `scene.Detail`
- `["Opening"]` = `scene.Opening`
- `["Title"]` = `scene.Title`
- `["backgrounds"]` = `scene.Backgrounds`
- `["currentBackground"]` = `scene.CurrentBackground`
- `["emotionSets"]` = `sets`
- `["participants"]` = `participants`
- `material["defaultEmotion"]` = `scene.DefaultEmotionId`
- `material["emotions"]` = `singleEmotions`

<a id="symbol-6062c19c6f71"></a>

## `Register(System.Collections.Generic.Dictionary<string, string>) — string Register(Dictionary<string, string> emotions)`

来源：源码第 62 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 82 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneBackgrounds.SafeId(string)`](DateSceneBackgrounds.cs.md#symbol-19bb6c988fd7)；[`NationalSpire.DateScenes.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest, bool)`](DateSceneData.cs.md#symbol-190a72e967ad)

**调用：** `char.IsLetterOrDigit(char)`；`System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `char.IsLetterOrDigit(char)`；输入表达式：`char.IsLetterOrDigit(c)`；返回值紧邻使用处：`BinaryExpressionSyntax: char.IsLetterOrDigit(c) || c is '_' or '-'`
- `System.Collections.Generic.IEnumerable<TSource>.All<TSource>(System.Func<TSource, bool>)`；输入表达式：`id.All(c => char.IsLetterOrDigit(c) || c is '_' or '-')`；返回值紧邻使用处：`BinaryExpressionSyntax: id.Length is > 0 and <= 100 && id.All(c => char.IsLetterOrDigit(c) || c is '_' or '-')`

**赋值（含属性/字段和局部值）：**


<a id="symbol-dccb0fff0030"></a>

## `NationalSpire.DateScenes.OneToOne(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?) — public static bool OneToOne(CareerData data, PrivateOffer offer, PrivateConversation? conversation)`

来源：源码第 83 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 86 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddDateSceneAction(NationalSpire.CareerData, NationalSpire.PrivateOffer, Godot.HBoxContainer)`](DateSceneScreen.cs.md#symbol-413adf55a103)；[`NationalSpire.CareerScreen.AddPausedDateScenes(NationalSpire.CareerData, NationalSpire.PrivateConversation)`](DateSceneScreen.cs.md#symbol-a5b10d9fb0b8)；[`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)；[`NationalSpire.CareerScreen.PromptDateScene(string)`](DateSceneScreen.cs.md#symbol-d6c92b4f494c)；[`NationalSpire.CareerScreen.ReturnFromDatePhone()`](DateGameScreen.cs.md#symbol-006d35effe08)；[`NationalSpire.CareerScreen.ReturnToDate(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu)`](DateGameReturn.cs.md#symbol-f14ac682e7c3)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)；[`NationalSpire.DateGames.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>)`](DateGames.cs.md#symbol-e72b5454cf31)；[`NationalSpire.DateGroupBridge.Begin(NationalSpire.CareerData, NationalSpire.GroupChat, NationalSpire.PrivateOffer)`](DateGroupBridge.cs.md#symbol-3f1369ff69ca)；[`NationalSpire.DateScenes.Leave(NationalSpire.CareerData, NationalSpire.PrivateConversation, string, bool)`](DateSceneData.cs.md#symbol-81bdbfbfe1d8)；[`NationalSpire.DateScenes.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest, bool)`](DateSceneData.cs.md#symbol-190a72e967ad)；[`NationalSpire.PrivateMessages.PrepareAttachments(NationalSpire.CareerData, string, System.Collections.Generic.List<NationalSpire.PrivateOffer>)`](PrivateMessages.cs.md#symbol-f2d6d9cf9c86)

**调用：** [`NationalSpire.DateGroupBridge.SourceActive(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](DateGroupBridge.cs.md#symbol-f6c6214fb9e2)；[`NationalSpire.DateSceneParty.Eligible(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneParty.cs.md#symbol-0b65821baf62)；[`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](PrivateAppointments.cs.md#symbol-15c716ec61a1)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerData.Day`；`NationalSpire.DateGroupBridge.SourceActive(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.DateSceneParty.Eligible(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateSceneRequest.Opening`；`NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；`NationalSpire.PrivateConversation.DateSceneStates`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateOffer.Id`；`NationalSpire.PrivateOffer.State`；`NationalSpire.PrivateTurn.Scene`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGroupBridge.SourceActive(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`DateGroupBridge.SourceActive(data, offer)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateSceneParty.Eligible(data, offer, conversation) && DateGroupBridge.SourceActive(data, offer)`
- `NationalSpire.DateSceneParty.Eligible(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`；输入表达式：`DateSceneParty.Eligible(data, offer, conversation)`；返回值紧邻使用处：`BinaryExpressionSyntax: DateSceneParty.Eligible(data, offer, conversation) && DateGroupBridge.SourceActive(data, offer)`
- `NationalSpire.PrivateAppointments.Date(NationalSpire.CareerData, NationalSpire.PrivateOffer)`；输入表达式：`PrivateAppointments.Date(data, offer)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateAppointments.Date(data, offer) == data.Day`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Turns.Any(t => t.Scene?.OfferId == offer.Id && t.Scene.Opening)`；返回值紧邻使用处：`BinaryExpressionSyntax: conversation.DateSceneStates.GetValueOrDefault(offer.Id) is "active" or "paused" || conversation.Turns.Any(t => t.Scene?.OfferId == offer.Id && t.Scene.Opening)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`.DateSceneStates.GetValueOrDefault(offer.Id)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: conversation?.DateSceneStates.GetValueOrDefault(offer.Id)`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`conversation.DateSceneStates.GetValueOrDefault(offer.Id)`；返回值紧邻使用处：`IsPatternExpressionSyntax: conversation.DateSceneStates.GetValueOrDefault(offer.Id) is "active" or "paused"`

**赋值（含属性/字段和局部值）：**


<a id="symbol-81bdbfbfe1d8"></a>

## `NationalSpire.DateScenes.Leave(NationalSpire.CareerData, NationalSpire.PrivateConversation, string, bool) — public static string? Leave(CareerData data, PrivateConversation conversation, string offerId, bool end)`

来源：源码第 90 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessageCommands.ApplyCore(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-1472969f513b)

**调用：** [`NationalSpire.AiService.CancelPrivate(NationalSpire.CareerData, string)`](AiPrivateMessages.cs.md#symbol-14a6fc19e1c1)；[`NationalSpire.DateDiaries.Begin(NationalSpire.PrivateConversation, NationalSpire.PrivateOffer)`](DateDiaries.cs.md#symbol-25266fe7f850)；[`NationalSpire.DateGroupBridge.Sync(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](DateGroupBridge.cs.md#symbol-26e379588751)；`NationalSpire.DateSceneRequest.DateSceneRequest()`；[`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneData.cs.md#symbol-0d3e014bcb63)；[`NationalSpire.PrivateMessageCommands.RestoreInterrupted(NationalSpire.PrivateTurn, string)`](PrivateMessageCommands.cs.md#symbol-82b01f18fa69)；[`NationalSpire.PrivateMessages.Enqueue(NationalSpire.CareerData, string, string, NationalSpire.PrivateOffer?, System.Collections.Generic.List<NationalSpire.PrivateOffer>?, string, bool)`](PrivateMessages.cs.md#symbol-0e61d4a7bbb5)；[`NationalSpire.WeddingAppointments.Complete(NationalSpire.CareerData, NationalSpire.PrivateOffer)`](WeddingAppointments.cs.md#symbol-4cb46102c2e0)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`

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
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Turns.Any(t => t.Scene is { Opening: true } scene && scene.OfferId == offerId)`；返回值紧邻使用处：`BinaryExpressionSyntax: conversation.DateSceneStates.GetValueOrDefault(offerId) is "active" or "paused" || conversation.Turns.Any(t => t.Scene is { Opening: true } scene && scene.OfferId == offerId)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Offers.FirstOrDefault(o => o.Id == offerId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = conversation.Offers.FirstOrDefault(o => o.Id == offerId)`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Turns.LastOrDefault(t => t.Status is "queued" or "sending" && t.Scene?.OfferId == offerId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: conversation.Turns.LastOrDefault(t => t.Status is "queued" or "sending" && t.Scene?.OfferId == offerId) is { } turn`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`conversation.DateSceneStates.GetValueOrDefault(offerId)`；返回值紧邻使用处：`BinaryExpressionSyntax: conversation.DateSceneStates.GetValueOrDefault(offerId) == "ended"`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey)`；输入表达式：`conversation.DateSceneStates.GetValueOrDefault(offerId)`；返回值紧邻使用处：`IsPatternExpressionSyntax: conversation.DateSceneStates.GetValueOrDefault(offerId) is "active" or "paused"`

**赋值（含属性/字段和局部值）：**

- `Detail` = `offer.Detail`
- `Ending` = `true`
- `OfferId` = `offerId`
- `Title` = `offer.Title`
- `conversation.DateSceneStates[offerId]` = `end ? "ended" : "paused"`
- `offer.State` = `"已结束"`
- `reflection.Scene` = `new() { OfferId = offerId, Title = offer.Title, Detail = offer.Detail, Ending = true }`

<a id="symbol-190a72e967ad"></a>

## `NationalSpire.DateScenes.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest, bool) — public static string? Validate(CareerData data, PrivateConversation conversation, DateSceneRequest request, bool retained = false)`

来源：源码第 115 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateScene(string, bool, bool)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)；[`NationalSpire.DateGames.FollowUp(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest)`](DateGames.cs.md#symbol-7a75a34b8321)；[`NationalSpire.PrivateMessageCommands.ApplyCore(NationalSpire.CareerData, string, string, NationalSpire.PrivateMessageCommand)`](PrivateMessageCommands.cs.md#symbol-1472969f513b)

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

来源：源码第 133 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`string.Replace(char, char)`；`string.Trim()`

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateStreamParser.Directives`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`d.ContainsKey("DateChoice")`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: d => d.ContainsKey("DateChoice")`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`；输入表达式：`parser.Directives .Where(d => d.ContainsKey("DateChoice")).Select(d => d["DateChoice"].Trim().Replace('\n', ' ').Replace('\r', ' ')) .Where(t => t.Length is > 0 and <= 80).Distinct(StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parser.Directives .Where(d => d.ContainsKey("DateChoice")).Select(d => d["DateChoice"].Trim().Replace('\n', ' ').Replace('\r', ' ')) .Where(t => t.Length is > 0 and <= 80).Distinct(StringComparer.Ordinal).Take`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`parser.Directives .Where(d => d.ContainsKey("DateChoice")).Select(d => d["DateChoice"].Trim().Replace('\n', ' ').Replace('\r', ' '))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parser.Directives .Where(d => d.ContainsKey("DateChoice")).Select(d => d["DateChoice"].Trim().Replace('\n', ' ').Replace('\r', ' ')) .Where`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`parser.Directives .Where(d => d.ContainsKey("DateChoice")).Select(d => d["DateChoice"].Trim().Replace('\n', ' ').Replace('\r', ' ')) .Where(t => t.Length is > 0 and <= 80).Distinct(StringComparer.Ordinal).Take(2)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parser.Directives .Where(d => d.ContainsKey("DateChoice")).Select(d => d["DateChoice"].Trim().Replace('\n', ' ').Replace('\r', ' ')) .Where(t => t.Length is > 0 and <= 80).Distinct(StringComparer.Ordinal).Take(2).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`parser.Directives .Where(d => d.ContainsKey("DateChoice")).Select(d => d["DateChoice"].Trim().Replace('\n', ' ').Replace('\r', ' ')) .Where(t => t.Length is > 0 and <= 80).Distinct(StringComparer.Ordinal).Take(2).ToList()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => parser.Directives .Where(d => d.ContainsKey("DateChoice")).Select(d => d["DateChoice"].Trim().Replace('\n', ' ').Replace('\r', ' ')) .Where(t => t.Length is > 0 and <= 80).Distinct(StringComparer.Ordinal).Take(2).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`parser.Directives .Where(d => d.ContainsKey("DateChoice"))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parser.Directives .Where(d => d.ContainsKey("DateChoice")).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`parser.Directives .Where(d => d.ContainsKey("DateChoice")).Select(d => d["DateChoice"].Trim().Replace('\n', ' ').Replace('\r', ' ')) .Where(t => t.Length is > 0 and <= 80)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parser.Directives .Where(d => d.ContainsKey("DateChoice")).Select(d => d["DateChoice"].Trim().Replace('\n', ' ').Replace('\r', ' ')) .Where(t => t.Length is > 0 and <= 80).Distinct`
- `string.Replace(char, char)`；输入表达式：`d["DateChoice"].Trim().Replace('\n', ' ')`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d["DateChoice"].Trim().Replace('\n', ' ').Replace`
- `string.Replace(char, char)`；输入表达式：`d["DateChoice"].Trim().Replace('\n', ' ').Replace('\r', ' ')`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: d => d["DateChoice"].Trim().Replace('\n', ' ').Replace('\r', ' ')`
- `string.Trim()`；输入表达式：`d["DateChoice"].Trim()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: d["DateChoice"].Trim().Replace`

**赋值（含属性/字段和局部值）：**


<a id="symbol-00bcca1f004c"></a>

## `NationalSpire.DateScenes.TaggedLines(NationalSpire.PrivateStreamParser, NationalSpire.DateSceneRequest) — public static List<DateSceneLine> TaggedLines(PrivateStreamParser parser, DateSceneRequest scene)`

来源：源码第 136 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)；[`NationalSpire.DateSceneTesting._Process(double)`](DateSceneTesting.cs.md#symbol-e5cbbec1bb0d)；[`Progress(string)`](AiPrivateMessages.cs.md#symbol-a004e611929b)

**调用：** [`NationalSpire.DateSceneParty.ForSpeaker(NationalSpire.DateSceneRequest, string)`](DateSceneParty.cs.md#symbol-c3a9f302456e)；[`NationalSpire.DateScenes.JoinNarration(System.Collections.Generic.List<NationalSpire.DateSceneLine>)`](DateSceneData.cs.md#symbol-da243e86633f)；[`Segment(int)`](DateSceneData.cs.md#symbol-d9b852a716e1)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Last<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.List()`；`System.Math.Max(int, int)`；`string.TrimEnd()`；`string.TrimStart()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneLine.Emotion`；`NationalSpire.DateSceneLine.Speaker`；`NationalSpire.DateSceneParty.ForSpeaker(NationalSpire.DateSceneRequest, string)`；`NationalSpire.DateSceneRequest.DefaultEmotionId`；`NationalSpire.DateSceneRequest.Emotions`；`NationalSpire.DateScenes.JoinNarration(System.Collections.Generic.List<NationalSpire.DateSceneLine>)`；`NationalSpire.PrivateStreamParser.SceneCues`；`NationalSpire.PrivateStreamParser.Text`；`Segment(int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneParty.ForSpeaker(NationalSpire.DateSceneRequest, string)`；输入表达式：`DateSceneParty.ForSpeaker(scene, line.Speaker)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneParty.ForSpeaker(scene, line.Speaker)`
- `NationalSpire.DateScenes.JoinNarration(System.Collections.Generic.List<NationalSpire.DateSceneLine>)`；输入表达式：`JoinNarration(result)`；返回值紧邻使用处：`ReturnStatementSyntax: return JoinNarration(result);`
- `Segment(int)`；输入表达式：`Segment(cue.Offset)`；返回值紧邻使用处：`ExpressionStatementSyntax: Segment(cue.Offset);`
- `Segment(int)`；输入表达式：`Segment(end)`；返回值紧邻使用处：`ExpressionStatementSyntax: Segment(end);`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`speaker.Emotions.ContainsKey(line.Emotion)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !speaker.Emotions.ContainsKey(line.Emotion)`
- `System.Collections.Generic.IEnumerable<TSource>.GroupBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`parser.SceneCues.Where(c => c.Offset <= end).GroupBy(c => Math.Max(start, c.Offset))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parser.SceneCues.Where(c => c.Offset <= end).GroupBy(c => Math.Max(start, c.Offset)).Select`
- `System.Collections.Generic.IEnumerable<TSource>.Last<TSource>()`；输入表达式：`g.Last()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: g.Last().Fields`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`parser.SceneCues.Where(c => c.Offset <= end).GroupBy(c => Math.Max(start, c.Offset)).Select(g => (Offset:g.Key, Fields:g.Last().Fields))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parser.SceneCues.Where(c => c.Offset <= end).GroupBy(c => Math.Max(start, c.Offset)).Select(g => (Offset:g.Key, Fields:g.Last().Fields)).ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`parser.SceneCues.Where(c => c.Offset <= end).GroupBy(c => Math.Max(start, c.Offset)).Select(g => (Offset:g.Key, Fields:g.Last().Fields)).ToList()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = parser.SceneCues.Where(c => c.Offset <= end).GroupBy(c => Math.Max(start, c.Offset)).Select(g => (Offset:g.Key, Fields:g.Last().Fields)).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`parser.SceneCues.Where(c => c.Offset <= end)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: parser.SceneCues.Where(c => c.Offset <= end).GroupBy`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<DateSceneLine>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<DateSceneLine>()`
- `System.Math.Max(int, int)`；输入表达式：`Math.Max(start, c.Offset)`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: c => Math.Max(start, c.Offset)`
- `string.TrimEnd()`；输入表达式：`source.TrimEnd()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: source.TrimEnd().Length`
- `string.TrimStart()`；输入表达式：`source.TrimStart()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: source.TrimStart().Length`

**赋值（含属性/字段和局部值）：**

- `fields` = `cue.Fields`
- `line.Emotion` = `speaker.DefaultEmotionId`

<a id="symbol-d9b852a716e1"></a>

## `Segment(int) — void Segment(int limit)`

来源：源码第 142 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 158 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

来源：源码第 170 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Add(string)`](DateSceneData.cs.md#symbol-cc5d8bbe1494)

**调用：** `string.Split(params char[]?)`；`System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`；`System.Text.RegularExpressions.Regex.IsMatch(string, string)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneRequest.DefaultEmotionId`；`NationalSpire.DateSceneRequest.Emotions`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `string.Split(params char[]?)`；输入表达式：`description.Split('：', ':')`；返回值紧邻使用处：`ElementAccessExpressionSyntax: description.Split('：', ':')[0]`
- `System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`；输入表达式：`Regex.IsMatch(id + "|" + description.Split('：', ':')[0], names, RegexOptions.IgnoreCase)`；返回值紧邻使用处：`IfStatementSyntax: if (Regex.IsMatch(id + "|" + description.Split('：', ':')[0], names, RegexOptions.IgnoreCase)) return id;`
- `System.Text.RegularExpressions.Regex.IsMatch(string, string)`；输入表达式：`Regex.IsMatch(text, words)`；返回值紧邻使用处：`IfStatementSyntax: if (Regex.IsMatch(text, words))                  foreach (var (id, description) in scene.Emotions)                      if (Regex.IsMatch(id + "|" + description.Split('：', ':')[0], names, RegexOptions.IgnoreCase)) return id;`

**赋值（含属性/字段和局部值）：**


<a id="symbol-df380ec1333f"></a>

## `NationalSpire.DateScenes.ReadSegment(string, NationalSpire.DateSceneRequest, System.Collections.Generic.Dictionary<string, string>?) — private static List<DateSceneLine> ReadSegment(string text, DateSceneRequest scene, Dictionary<string, string>? fields)`

来源：源码第 191 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Segment(int)`](DateSceneData.cs.md#symbol-d9b852a716e1)

**调用：** [`Add(string)`](DateSceneData.cs.md#symbol-cc5d8bbe1494)；[`NationalSpire.DateSceneParty.ForSpeaker(NationalSpire.DateSceneRequest, string)`](DateSceneParty.cs.md#symbol-c3a9f302456e)；[`NationalSpire.DateSceneParty.Resolve(NationalSpire.DateSceneRequest, string)`](DateSceneParty.cs.md#symbol-6bfcef03874d)；[`NationalSpire.DateScenes.EmotionId(NationalSpire.DateSceneRequest, string)`](DateSceneData.cs.md#symbol-a6609cbcddd2)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；`System.Collections.Generic.List<T>.List()`；`System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`；`System.Text.RegularExpressions.Regex.Matches(string, string)`；`System.Text.RegularExpressions.Regex.Replace(string, string, string, System.Text.RegularExpressions.RegexOptions)`；`string.ToLowerInvariant()`；`string.Trim()`

**字段、属性、事件及方法组引用：** `Add(string)`；`NationalSpire.DateSceneParty.ForSpeaker(NationalSpire.DateSceneRequest, string)`；`NationalSpire.DateSceneParty.Resolve(NationalSpire.DateSceneRequest, string)`；`NationalSpire.DateSceneRequest.DefaultEmotionId`；`NationalSpire.DateScenes.EmotionId(NationalSpire.DateSceneRequest, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Add(string)`；输入表达式：`Add(text[at..])`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(text[at..]);`
- `Add(string)`；输入表达式：`Add(text[at..tag.Index])`；返回值紧邻使用处：`ExpressionStatementSyntax: Add(text[at..tag.Index]);`
- `NationalSpire.DateSceneParty.ForSpeaker(NationalSpire.DateSceneRequest, string)`；输入表达式：`DateSceneParty.ForSpeaker(scene, speaker)`；返回值紧邻使用处：`AssignmentExpressionSyntax: scene = DateSceneParty.ForSpeaker(scene, speaker)`
- `NationalSpire.DateSceneParty.Resolve(NationalSpire.DateSceneRequest, string)`；输入表达式：`DateSceneParty.Resolve(scene, fields?.GetValueOrDefault("Speaker", "") ?? "")`；返回值紧邻使用处：`EqualsValueClauseSyntax: = DateSceneParty.Resolve(scene, fields?.GetValueOrDefault("Speaker", "") ?? "")`
- `NationalSpire.DateScenes.EmotionId(NationalSpire.DateSceneRequest, string)`；输入表达式：`EmotionId(scene, candidate)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = EmotionId(scene, candidate)`
- `NationalSpire.DateScenes.EmotionId(NationalSpire.DateSceneRequest, string)`；输入表达式：`EmotionId(scene, fields["Emotion"])`；返回值紧邻使用处：`BinaryExpressionSyntax: EmotionId(scene, fields["Emotion"]) ?? scene.DefaultEmotionId`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`.ContainsKey("Emotion")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: fields?.ContainsKey("Emotion")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`.GetValueOrDefault("Background", "")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: fields?.GetValueOrDefault("Background", "")`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`.GetValueOrDefault("Scene", "")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: .GetValueOrDefault("Scene", "").ToLowerInvariant`
- `System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.GetValueOrDefault<TKey, TValue>(TKey, TValue)`；输入表达式：`.GetValueOrDefault("Speaker", "")`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: fields?.GetValueOrDefault("Speaker", "")`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<DateSceneLine>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<DateSceneLine>()`
- `System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`；输入表达式：`Regex.IsMatch(value, @"^(Emotion|情绪)\s*[:：]", RegexOptions.IgnoreCase)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Regex.IsMatch(value, @"^(Emotion|情绪)\s*[:：]", RegexOptions.IgnoreCase)`
- `System.Text.RegularExpressions.Regex.Matches(string, string)`；输入表达式：`Regex.Matches(text, @"[\[（(【](?<value>[^\]\r\n）)】]{1,80})[\]）)】]")`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (Match tag in Regex.Matches(text, @"[\[（(【](?<value>[^\]\r\n）)】]{1,80})[\]）)】]")) { string value = tag.Groups["value"].Value.Trim(); bool explicitEmotion = Regex.IsMatch(value, @"^(Emotion|情绪)\s*[:：]", RegexOptions.IgnoreCase); string candidate = explicitEmotion ? Regex.Replace(value, @"^(Emotion|情绪)\s*[:：]\s*", "", RegexOptions.IgnoreCase) : value; string? found = EmotionId(scene, candidate); bool narration = value is "旁白" or "narration"; if (found == null && !explicitEmotion && !narration) continue; Add(text[at..tag.Index]); at = tag.Index + tag.Length; if (narration) { kind = "narration"; emotion = null; } else { kind = "dialogue"; emotion = found ?? scene.DefaultEmotionId; } }`
- `System.Text.RegularExpressions.Regex.Replace(string, string, string, System.Text.RegularExpressions.RegexOptions)`；输入表达式：`Regex.Replace(value, @"^(Emotion|情绪)\s*[:：]\s*", "", RegexOptions.IgnoreCase)`；返回值紧邻使用处：`ConditionalExpressionSyntax: explicitEmotion ? Regex.Replace(value, @"^(Emotion|情绪)\s*[:：]\s*", "", RegexOptions.IgnoreCase) : value`
- `string.ToLowerInvariant()`；输入表达式：`.GetValueOrDefault("Scene", "").ToLowerInvariant()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: fields?.GetValueOrDefault("Scene", "").ToLowerInvariant()`
- `string.Trim()`；输入表达式：`tag.Groups["value"].Value.Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = tag.Groups["value"].Value.Trim()`

**赋值（含属性/字段和局部值）：**

- `at` = `tag.Index + tag.Length`
- `emotion` = `found ?? scene.DefaultEmotionId`
- `emotion` = `null`
- `kind` = `"dialogue"`
- `kind` = `"narration"`
- `scene` = `DateSceneParty.ForSpeaker(scene, speaker)`

<a id="symbol-cc5d8bbe1494"></a>

## `Add(string) — void Add(string part)`

来源：源码第 200 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.ReadSegment(string, NationalSpire.DateSceneRequest, System.Collections.Generic.Dictionary<string, string>?)`](DateSceneData.cs.md#symbol-df380ec1333f)

**调用：** [`NationalSpire.DateScenes.InferEmotion(NationalSpire.DateSceneRequest, string)`](DateSceneData.cs.md#symbol-9848e1f83c4c)；[`NationalSpire.DateScenes.Split(string, bool)`](DateSceneData.cs.md#symbol-4bfd36365879)；[`NationalSpire.DateScenes.SplitSentences(string, bool, int)`](DateSceneData.cs.md#symbol-dd74e35c7d6b)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.List<T>.List()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneLine.Background`；`NationalSpire.DateSceneLine.Emotion`；`NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.Speaker`；`NationalSpire.DateSceneLine.Text`；`NationalSpire.DateSceneRequest.Backgrounds`；`NationalSpire.DateSceneRequest.DefaultEmotionId`；`NationalSpire.DateScenes.InferEmotion(NationalSpire.DateSceneRequest, string)`；`NationalSpire.DateScenes.Split(string, bool)`；`NationalSpire.DateScenes.SplitSentences(string, bool, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateScenes.InferEmotion(NationalSpire.DateSceneRequest, string)`；输入表达式：`InferEmotion(scene, sentence.Text)`；返回值紧邻使用处：`BinaryExpressionSyntax: emotion ?? InferEmotion(scene, sentence.Text)`
- `NationalSpire.DateScenes.Split(string, bool)`；输入表达式：`Split(sentence.Text, sentence.Narration)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var line in Split(sentence.Text, sentence.Narration)) { line.Speaker = line.Narration ? "" : speaker; line.Emotion = sentenceEmotion; lines.Add(line); }`
- `NationalSpire.DateScenes.SplitSentences(string, bool, int)`；输入表达式：`SplitSentences(part, kind is "narration" or "旁白", int.MaxValue)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var sentence in SplitSentences(part, kind is "narration" or "旁白", int.MaxValue)) { string sentenceEmotion = sentence.Narration ? scene.DefaultEmotionId : emotion ?? InferEmotion(scene, sentence.Text); foreach (var line in Split(sentence.Text, sentence.Narration)) { line.Speaker = line.Narration ? "" : speaker; line.Emotion = sentenceEmotion; lines.Add(line); } // 显式差分作用于完整句；为显示长度拆出的片段共享该句差分。 if (!sentence.Narration) emotion = null; }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`original.Backgrounds.ContainsKey(background)`；返回值紧邻使用处：`BinaryExpressionSyntax: lines.Count > 0 && original.Backgrounds.ContainsKey(background)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`lines.Add(line)`；返回值紧邻使用处：`ExpressionStatementSyntax: lines.Add(line);`
- `System.Collections.Generic.List<T>.AddRange(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`result.AddRange(lines)`；返回值紧邻使用处：`ExpressionStatementSyntax: result.AddRange(lines);`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<DateSceneLine>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<DateSceneLine>()`

**赋值（含属性/字段和局部值）：**

- `background` = `""`
- `emotion` = `null`
- `line.Emotion` = `sentenceEmotion`
- `line.Speaker` = `line.Narration ? "" : speaker`
- `lines[0].Background` = `background`
- `result[^1].Text` += `part`

<a id="symbol-76bee931e453"></a>

## `NationalSpire.DateScenes.ReplyFailure(string) — public static string? ReplyFailure(string text)`

来源：源码第 235 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.AiService.ProcessPrivateAsync(System.Func<NationalSpire.CareerData?>, System.Action<NationalSpire.CareerData>, string, System.Action<string, string>?)`](AiPrivateMessages.cs.md#symbol-935c714481c1)

**调用：** `System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`

**字段、属性、事件及方法组引用：** 无已绑定项目引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Text.RegularExpressions.Regex.IsMatch(string, string, System.Text.RegularExpressions.RegexOptions)`；输入表达式：`Regex.IsMatch(text,          @"我(?:无法|不能)(?:为你|为您)?(?:生成|提供)|NSFW", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant)`；返回值紧邻使用处：`ConditionalExpressionSyntax: Regex.IsMatch(text,          @"我(?:无法|不能)(?:为你|为您)?(?:生成|提供)|NSFW", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant)          ? "本轮回复包含模型拒绝生成的内容，请重新生成或编辑文字后发送。" : null`

**赋值（含属性/字段和局部值）：**


<a id="symbol-4bfd36365879"></a>

## `NationalSpire.DateScenes.Split(string, bool) — public static List<DateSceneLine> Split(string text, bool narration = false)`

来源：源码第 239 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Add(string)`](DateSceneData.cs.md#symbol-cc5d8bbe1494)；[`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`](DateSceneData.cs.md#symbol-801111e76ca9)

**调用：** [`NationalSpire.DateScenes.SplitSentences(string, bool, int)`](DateSceneData.cs.md#symbol-dd74e35c7d6b)

**字段、属性、事件及方法组引用：** `NationalSpire.DateScenes.MaxLineCharacters`；`NationalSpire.DateScenes.SplitSentences(string, bool, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateScenes.SplitSentences(string, bool, int)`；输入表达式：`SplitSentences(text, narration, MaxLineCharacters)`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => SplitSentences(text, narration, MaxLineCharacters)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f781869eac8a"></a>

## `NationalSpire.DateScenes.ExpressionSpans(string) — private static List<(int Start, int End)> ExpressionSpans(string text)`

来源：源码第 241 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.ShortParts(string, int)`](DateSceneData.cs.md#symbol-8f114a9558ac)；[`NationalSpire.DateScenes.SplitSentences(string, bool, int)`](DateSceneData.cs.md#symbol-dd74e35c7d6b)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Text.RegularExpressions.Regex.Matches(string, string, System.Text.RegularExpressions.RegexOptions)`；`char.IsPunctuation(char)`；`char.IsSymbol(char)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`face.Any(ch => ch is >= '\u3400' and <= '\u9fff')`；返回值紧邻使用处：`BinaryExpressionSyntax: face.Any(ch => ch is >= '\u3400' and <= '\u9fff') || match.Length > 120`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`face.Any(ch => char.IsPunctuation(ch) || char.IsSymbol(ch))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !face.Any(ch => char.IsPunctuation(ch) || char.IsSymbol(ch))`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.Add((match.Index, match.Index + match.Length))`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Add((match.Index, match.Index + match.Length));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<(int, int)>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<(int, int)>()`
- `System.Text.RegularExpressions.Regex.Matches(string, string, System.Text.RegularExpressions.RegexOptions)`；输入表达式：`Regex.Matches(text, pattern, RegexOptions.CultureInvariant)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (Match match in Regex.Matches(text, pattern, RegexOptions.CultureInvariant)) { string face = match.Groups["face"].Value; if (face.Any(ch => ch is >= '\u3400' and <= '\u9fff') || match.Length > 120) continue; if (face.Length > 1 && !face.Any(ch => char.IsPunctuation(ch) || char.IsSymbol(ch))) continue; result.Add((match.Index, match.Index + match.Length)); }`
- `char.IsPunctuation(char)`；输入表达式：`char.IsPunctuation(ch)`；返回值紧邻使用处：`BinaryExpressionSyntax: char.IsPunctuation(ch) || char.IsSymbol(ch)`
- `char.IsSymbol(char)`；输入表达式：`char.IsSymbol(ch)`；返回值紧邻使用处：`BinaryExpressionSyntax: char.IsPunctuation(ch) || char.IsSymbol(ch)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-64fe7cb50f21"></a>

## `NationalSpire.DateScenes.SentenceTail(string, int, System.Collections.Generic.Dictionary<int, int>) — private static int SentenceTail(string text, int at, Dictionary<int, int> expressions)`

来源：源码第 257 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.SplitSentences(string, bool, int)`](DateSceneData.cs.md#symbol-dd74e35c7d6b)

**调用：** `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Globalization.StringInfo.GetNextTextElement(string, int)`；`System.Text.Rune.GetUnicodeCategory(System.Text.Rune)`；`System.Text.Rune.TryGetRuneAt(string, int, out System.Text.Rune)`；`string.Contains(char)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`expressions.TryGetValue(at, out int end)`；返回值紧邻使用处：`IfStatementSyntax: if (expressions.TryGetValue(at, out int end)) { at = end; continue; }`
- `System.Globalization.StringInfo.GetNextTextElement(string, int)`；输入表达式：`StringInfo.GetNextTextElement(text, at)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: StringInfo.GetNextTextElement(text, at).Length`
- `System.Text.Rune.GetUnicodeCategory(System.Text.Rune)`；输入表达式：`Rune.GetUnicodeCategory(rune)`；返回值紧邻使用处：`IsPatternExpressionSyntax: Rune.GetUnicodeCategory(rune) is UnicodeCategory.OtherSymbol or UnicodeCategory.ModifierSymbol`
- `System.Text.Rune.TryGetRuneAt(string, int, out System.Text.Rune)`；输入表达式：`Rune.TryGetRuneAt(text, at, out var rune)`；返回值紧邻使用处：`BinaryExpressionSyntax: Rune.TryGetRuneAt(text, at, out var rune) && Rune.GetUnicodeCategory(rune) is UnicodeCategory.OtherSymbol or UnicodeCategory.ModifierSymbol`
- `string.Contains(char)`；输入表达式：`"。！？!?…\"”’」』）)".Contains(text[at])`；返回值紧邻使用处：`IfStatementSyntax: if ("。！？!?…\"”’」』）)".Contains(text[at])) { at++; continue; }`

**赋值（含属性/字段和局部值）：**

- `at` += `StringInfo.GetNextTextElement(text, at).Length`
- `at` = `end`

<a id="symbol-dd74e35c7d6b"></a>

## `NationalSpire.DateScenes.SplitSentences(string, bool, int) — private static List<DateSceneLine> SplitSentences(string text, bool narration, int limit)`

来源：源码第 269 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Add(string)`](DateSceneData.cs.md#symbol-cc5d8bbe1494)；[`NationalSpire.DateScenes.Split(string, bool)`](DateSceneData.cs.md#symbol-4bfd36365879)

**调用：** [`Flush()`](DateSceneData.cs.md#symbol-04a627eaa3b2)；[`NationalSpire.DateScenes.ExpressionSpans(string)`](DateSceneData.cs.md#symbol-f781869eac8a)；[`NationalSpire.DateScenes.SentenceTail(string, int, System.Collections.Generic.Dictionary<int, int>)`](DateSceneData.cs.md#symbol-64fe7cb50f21)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；`System.Collections.Generic.List<T>.List()`；`System.Text.StringBuilder.Append(char)`；`System.Text.StringBuilder.Append(string?, int, int)`；`System.Text.StringBuilder.StringBuilder()`；`char.IsWhiteSpace(char)`

**字段、属性、事件及方法组引用：** `Flush()`；`NationalSpire.DateScenes.ExpressionSpans(string)`；`NationalSpire.DateScenes.SentenceTail(string, int, System.Collections.Generic.Dictionary<int, int>)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Flush()`；输入表达式：`Flush()`；返回值紧邻使用处：`ExpressionStatementSyntax: Flush();`
- `NationalSpire.DateScenes.ExpressionSpans(string)`；输入表达式：`ExpressionSpans(text)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: ExpressionSpans(text).ToDictionary`
- `NationalSpire.DateScenes.SentenceTail(string, int, System.Collections.Generic.Dictionary<int, int>)`；输入表达式：`SentenceTail(text, i + 1, expressions)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = SentenceTail(text, i + 1, expressions)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`expressions.TryGetValue(i, out int expressionEnd)`；返回值紧邻使用处：`IfStatementSyntax: if (expressions.TryGetValue(i, out int expressionEnd)) { buffer.Append(text, i, expressionEnd - i); i = expressionEnd - 1; continue; }`
- `System.Collections.Generic.IEnumerable<TSource>.ToDictionary<TSource, TKey, TElement>(System.Func<TSource, TKey>, System.Func<TSource, TElement>)`；输入表达式：`ExpressionSpans(text).ToDictionary(span => span.Start, span => span.End)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ExpressionSpans(text).ToDictionary(span => span.Start, span => span.End)`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<DateSceneLine>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<DateSceneLine>()`
- `System.Text.StringBuilder.Append(char)`；输入表达式：`buffer.Append(ch)`；返回值紧邻使用处：`ExpressionStatementSyntax: buffer.Append(ch);`
- `System.Text.StringBuilder.Append(string?, int, int)`；输入表达式：`buffer.Append(text, i + 1, end - i - 1)`；返回值紧邻使用处：`ExpressionStatementSyntax: buffer.Append(text, i + 1, end - i - 1);`
- `System.Text.StringBuilder.Append(string?, int, int)`；输入表达式：`buffer.Append(text, i, expressionEnd - i)`；返回值紧邻使用处：`ExpressionStatementSyntax: buffer.Append(text, i, expressionEnd - i);`
- `System.Text.StringBuilder.StringBuilder()`；输入表达式：`new StringBuilder()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StringBuilder()`
- `char.IsWhiteSpace(char)`；输入表达式：`char.IsWhiteSpace(text[i + 1])`；返回值紧邻使用处：`BinaryExpressionSyntax: i + 1 == text.Length || char.IsWhiteSpace(text[i + 1])`

**赋值（含属性/字段和局部值）：**

- `i` = `end - 1`
- `i` = `expressionEnd - 1`

<a id="symbol-04a627eaa3b2"></a>

## `Flush() — void Flush()`

来源：源码第 273 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.SplitSentences(string, bool, int)`](DateSceneData.cs.md#symbol-dd74e35c7d6b)

**调用：** `NationalSpire.DateSceneLine.DateSceneLine()`；[`NationalSpire.DateScenes.ShortParts(string, int)`](DateSceneData.cs.md#symbol-8f114a9558ac)；`System.Collections.Generic.List<T>.Add(T)`；`System.Text.RegularExpressions.Regex.IsMatch(string, string)`；`System.Text.StringBuilder.Clear()`；`System.Text.StringBuilder.ToString()`；`string.IsNullOrWhiteSpace(string?)`；`string.StartsWith(char)`；`string.Trim()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.Text`；`NationalSpire.DateScenes.ShortParts(string, int)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneLine.DateSceneLine()`；输入表达式：`new() { Text = part, Narration = objective }`；返回值紧邻使用处：`ArgumentSyntax: new() { Text = part, Narration = objective }`
- `NationalSpire.DateScenes.ShortParts(string, int)`；输入表达式：`ShortParts(value, objective ? int.MaxValue : limit)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (string part in ShortParts(value, objective ? int.MaxValue : limit)) result.Add(new() { Text = part, Narration = objective });`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.Add(new() { Text = part, Narration = objective })`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Add(new() { Text = part, Narration = objective });`
- `System.Text.RegularExpressions.Regex.IsMatch(string, string)`；输入表达式：`Regex.IsMatch(trimmed, "旁白|环境|阳光|灯光|风声|夜色|街道|窗外|微风|空气|抬起|低下|转身|望向|看向|走近|站在|坐在|微笑|轻轻|缓缓|她|他|少女|少年|女孩|男孩|耳朵|尾巴|指尖|脸颊|掌心|目光|视线|脚步|身旁|嘴角|双眼|嘴唇|肩膀")`；返回值紧邻使用处：`BinaryExpressionSyntax: (trimmed.StartsWith('（') || trimmed.StartsWith('(')) && Regex.IsMatch(trimmed, "旁白|环境|阳光|灯光|风声|夜色|街道|窗外|微风|空气|抬起|低下|转身|望向|看向|走近|站在|坐在|微笑|轻轻|缓缓|她|他|少女|少年|女孩|男孩|耳朵|尾巴|指尖|脸颊|掌心|目光|视线|脚步|身旁|嘴角|双眼|嘴唇|肩膀")`
- `System.Text.StringBuilder.Clear()`；输入表达式：`buffer.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: buffer.Clear();`
- `System.Text.StringBuilder.ToString()`；输入表达式：`buffer.ToString()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = buffer.ToString()`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(value)`；返回值紧邻使用处：`IfStatementSyntax: if (string.IsNullOrWhiteSpace(value)) { if (result.Count > 0) result[^1].Text += value; return; }`
- `string.StartsWith(char)`；输入表达式：`trimmed.StartsWith('(')`；返回值紧邻使用处：`BinaryExpressionSyntax: trimmed.StartsWith('（') || trimmed.StartsWith('(')`
- `string.StartsWith(char)`；输入表达式：`trimmed.StartsWith('（')`；返回值紧邻使用处：`BinaryExpressionSyntax: trimmed.StartsWith('（') || trimmed.StartsWith('(')`
- `string.Trim()`；输入表达式：`value.Trim()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = value.Trim()`

**赋值（含属性/字段和局部值）：**

- `Narration` = `objective`
- `Text` = `part`
- `result[^1].Text` += `value`

<a id="symbol-8f114a9558ac"></a>

## `NationalSpire.DateScenes.ShortParts(string, int) — private static IEnumerable<string> ShortParts(string text, int limit)`

来源：源码第 300 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Flush()`](DateSceneData.cs.md#symbol-04a627eaa3b2)

**调用：** [`CanCut(int)`](DateSceneData.cs.md#symbol-840525e8660b)；[`NationalSpire.DateScenes.ExpressionSpans(string)`](DateSceneData.cs.md#symbol-f781869eac8a)；`System.Globalization.StringInfo.ParseCombiningCharacters(string)`；`System.Math.Min(int, int)`；`char.IsWhiteSpace(char)`；`string.Contains(char)`

**字段、属性、事件及方法组引用：** `CanCut(int)`；`NationalSpire.DateScenes.ExpressionSpans(string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `CanCut(int)`；输入表达式：`CanCut(starts[i + 1])`；返回值紧邻使用处：`BinaryExpressionSyntax: i + 1 == starts.Length || CanCut(starts[i + 1])`
- `CanCut(int)`；输入表达式：`CanCut(starts[through])`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !CanCut(starts[through])`
- `NationalSpire.DateScenes.ExpressionSpans(string)`；输入表达式：`ExpressionSpans(text)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = ExpressionSpans(text)`
- `System.Globalization.StringInfo.ParseCombiningCharacters(string)`；输入表达式：`StringInfo.ParseCombiningCharacters(text)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = StringInfo.ParseCombiningCharacters(text)`
- `System.Math.Min(int, int)`；输入表达式：`Math.Min(limit, starts.Length - from)`；返回值紧邻使用处：`BinaryExpressionSyntax: from + Math.Min(limit, starts.Length - from)`
- `char.IsWhiteSpace(char)`；输入表达式：`char.IsWhiteSpace(ch)`；返回值紧邻使用处：`BinaryExpressionSyntax: "，,；;：:".Contains(ch) || char.IsWhiteSpace(ch)`
- `string.Contains(char)`；输入表达式：`"，,；;：:".Contains(ch)`；返回值紧邻使用处：`BinaryExpressionSyntax: "，,；;：:".Contains(ch) || char.IsWhiteSpace(ch)`

**赋值（含属性/字段和局部值）：**

- `from` = `through`
- `natural` = `i + 1`
- `through` = `fallback`
- `through` = `natural`

<a id="symbol-840525e8660b"></a>

## `CanCut(int) — bool CanCut(int at)`

来源：源码第 304 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.ShortParts(string, int)`](DateSceneData.cs.md#symbol-8f114a9558ac)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`expressions.Any(span => at > span.Start && at < span.End)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !expressions.Any(span => at > span.Start && at < span.End)`

**赋值（含属性/字段和局部值）：**


<a id="symbol-801111e76ca9"></a>

## `NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn) — public static List<DateSceneLine> Lines(PrivateTurn turn)`

来源：源码第 326 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)；[`NationalSpire.CareerScreen.TickDateScene()`](DateSceneScreen.cs.md#symbol-5923316321e9)；[`NationalSpire.DateMemoryRecorder.Sync(NationalSpire.PrivateConversation)`](DateSceneMemories.cs.md#symbol-949d37f3d89e)；[`NationalSpire.DateSceneParty.SharedMemory(NationalSpire.CareerData, string, string)`](DateSceneParty.cs.md#symbol-5315c2e1b812)；[`NationalSpire.DateScenes.HistoryEntries(NationalSpire.PrivateConversation, string, string, int, string, string)`](DateSceneData.cs.md#symbol-e8fbec0a77e3)；[`NationalSpire.DateScenes.PromptHistory(NationalSpire.PrivateTurn, string)`](DateSceneData.cs.md#symbol-1bee81f08078)

**调用：** `NationalSpire.DateSceneLine.DateSceneLine()`；[`NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`](DateSceneData.cs.md#symbol-711ab692d366)；[`NationalSpire.DateScenes.JoinNarration(System.Collections.Generic.List<NationalSpire.DateSceneLine>)`](DateSceneData.cs.md#symbol-da243e86633f)；[`NationalSpire.DateScenes.Split(string, bool)`](DateSceneData.cs.md#symbol-4bfd36365879)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`string.Concat(System.Collections.Generic.IEnumerable<string?>)`；`string.IsNullOrWhiteSpace(string?)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneLine.Background`；`NationalSpire.DateSceneLine.Emotion`；`NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.Speaker`；`NationalSpire.DateSceneLine.Text`；`NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`；`NationalSpire.DateScenes.JoinNarration(System.Collections.Generic.List<NationalSpire.DateSceneLine>)`；`NationalSpire.DateScenes.Split(string, bool)`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.SceneLines`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneLine.DateSceneLine()`；输入表达式：`new DateSceneLine { Speaker = line.Speaker, Text = part.Text, Narration = line.Narration || part.Narration, Emotion = line.Emotion, Background = index == 0 ? line.Background : "" }`；返回值紧邻使用处：`ParenthesizedLambdaExpressionSyntax: (part, index) => new DateSceneLine { Speaker = line.Speaker, Text = part.Text, Narration = line.Narration || part.Narration, Emotion = line.Emotion, Background = index == 0 ? line.Background : "" }`
- `NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`；输入表达式：`DisplayText(line)`；返回值紧邻使用处：`ArgumentSyntax: DisplayText(line)`
- `NationalSpire.DateScenes.JoinNarration(System.Collections.Generic.List<NationalSpire.DateSceneLine>)`；输入表达式：`JoinNarration(source.SelectMany(line => Split(line.Text, line.Narration).Select((part, index) => new DateSceneLine { Speaker = line.Speaker, Text = part.Text, Narration = line.Narration || part.Narration, Emotion = line.Emotion, Background = index == 0 ? line.Background : "" })) .Where(line => !string.IsNullOrWhiteSpace(DisplayText(line))).ToList())`；返回值紧邻使用处：`ReturnStatementSyntax: return JoinNarration(source.SelectMany(line => Split(line.Text, line.Narration).Select((part, index) => new DateSceneLine { Speaker = line.Speaker, Text = part.Text, Narration = line.Narration || part.Narration, Emotion = line.Emotion, Background = index == 0 ? line.Background : "" })) .Where(line => !string.IsNullOrWhiteSpace(DisplayText(line))).ToList());`
- `NationalSpire.DateScenes.Split(string, bool)`；输入表达式：`Split(line.Text, line.Narration)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Split(line.Text, line.Narration).Select`
- `NationalSpire.DateScenes.Split(string, bool)`；输入表达式：`Split(turn.Reply)`；返回值紧邻使用处：`ConditionalExpressionSyntax: turn.SceneLines.Count > 0 && string.Concat(turn.SceneLines.Select(l => l.Text)) == turn.Reply ? turn.SceneLines : Split(turn.Reply)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`turn.SceneLines.Select(l => l.Text)`；返回值紧邻使用处：`ArgumentSyntax: turn.SceneLines.Select(l => l.Text)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, int, TResult>)`；输入表达式：`Split(line.Text, line.Narration).Select((part, index) => new DateSceneLine { Speaker = line.Speaker, Text = part.Text, Narration = line.Narration || part.Narration, Emotion = line.Emotion, Background = index == 0 ? line.Background : "" })`；返回值紧邻使用处：`SimpleLambdaExpressionSyntax: line => Split(line.Text, line.Narration).Select((part, index) => new DateSceneLine { Speaker = line.Speaker, Text = part.Text, Narration = line.Narration || part.Narration, Emotion = line.Emotion, Background = index == 0 ? line.Background : "" })`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`source.SelectMany(line => Split(line.Text, line.Narration).Select((part, index) => new DateSceneLine { Speaker = line.Speaker, Text = part.Text, Narration = line.Narration || part.Narration, Emotion = line.Emotion, Background = index == 0 ? line.Background : "" }))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: source.SelectMany(line => Split(line.Text, line.Narration).Select((part, index) => new DateSceneLine { Speaker = line.Speaker, Text = part.Text, Narration = line.Narration || part.Narration, Emotion = line.Emotion, Background = index == 0 ? line.Background : "" })) .Where`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`source.SelectMany(line => Split(line.Text, line.Narration).Select((part, index) => new DateSceneLine { Speaker = line.Speaker, Text = part.Text, Narration = line.Narration || part.Narration, Emotion = line.Emotion, Background = index == 0 ? line.Background : "" })) .Where(line => !string.IsNullOrWhiteSpace(DisplayText(line))).ToList()`；返回值紧邻使用处：`ArgumentSyntax: source.SelectMany(line => Split(line.Text, line.Narration).Select((part, index) => new DateSceneLine { Speaker = line.Speaker, Text = part.Text, Narration = line.Narration || part.Narration, Emotion = line.Emotion, Background = index == 0 ? line.Background : "" })) .Where(line => !string.IsNullOrWhiteSpace(DisplayText(line))).ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`source.SelectMany(line => Split(line.Text, line.Narration).Select((part, index) => new DateSceneLine { Speaker = line.Speaker, Text = part.Text, Narration = line.Narration || part.Narration, Emotion = line.Emotion, Background = index == 0 ? line.Background : "" })) .Where(line => !string.IsNullOrWhiteSpace(DisplayText(line)))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: source.SelectMany(line => Split(line.Text, line.Narration).Select((part, index) => new DateSceneLine { Speaker = line.Speaker, Text = part.Text, Narration = line.Narration || part.Narration, Emotion = line.Emotion, Background = index == 0 ? line.Background : "" })) .Where(line => !string.IsNullOrWhiteSpace(DisplayText(line))).ToList`
- `string.Concat(System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Concat(turn.SceneLines.Select(l => l.Text))`；返回值紧邻使用处：`BinaryExpressionSyntax: string.Concat(turn.SceneLines.Select(l => l.Text)) == turn.Reply`
- `string.IsNullOrWhiteSpace(string?)`；输入表达式：`string.IsNullOrWhiteSpace(DisplayText(line))`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !string.IsNullOrWhiteSpace(DisplayText(line))`

**赋值（含属性/字段和局部值）：**

- `Background` = `index == 0 ? line.Background : ""`
- `Emotion` = `line.Emotion`
- `Narration` = `line.Narration || part.Narration`
- `Speaker` = `line.Speaker`
- `Text` = `part.Text`

<a id="symbol-1bee81f08078"></a>

## `NationalSpire.DateScenes.PromptHistory(NationalSpire.PrivateTurn, string) — public static string PromptHistory(PrivateTurn turn, string host)`

来源：源码第 333 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.ChatTimeline.PrivateHistory(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn?)`](ChatTimeline.cs.md#symbol-4c7ee0ce6871)；[`NationalSpire.DateDiaries.Guidance(NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest)`](DateDiaries.cs.md#symbol-81cb927c13c4)

**调用：** [`Flush()`](DateSceneData.cs.md#symbol-5a50e4e9d311)；[`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`](DateSceneData.cs.md#symbol-801111e76ca9)；`System.Text.StringBuilder.Append(string?)`；`System.Text.StringBuilder.StringBuilder()`；`System.Text.StringBuilder.ToString()`

**字段、属性、事件及方法组引用：** `Flush()`；`NationalSpire.DateSceneLine.Background`；`NationalSpire.DateSceneLine.Emotion`；`NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.Speaker`；`NationalSpire.DateSceneLine.Text`；`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Flush()`；输入表达式：`Flush()`；返回值紧邻使用处：`ExpressionStatementSyntax: Flush();`
- `NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`；输入表达式：`Lines(turn)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var line in Lines(turn)) { // 历史恢复真实的说话人/情绪/转场边界；界面自动分页无需重复完整显示标签。 bool same = current != null && line.Narration == current.Narration && line.Speaker == current.Speaker && (line.Narration || line.Emotion == current.Emotion) && line.Background.Length == 0; if (!same) { Flush(); current = line; } body.Append(line.Text); }`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`body.Append(line.Text)`；返回值紧邻使用处：`ExpressionStatementSyntax: body.Append(line.Text);`
- `System.Text.StringBuilder.StringBuilder()`；输入表达式：`new StringBuilder()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StringBuilder()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`result.ToString()`；返回值紧邻使用处：`ReturnStatementSyntax: return result.ToString();`

**赋值（含属性/字段和局部值）：**

- `current` = `line`

<a id="symbol-5a50e4e9d311"></a>

## `Flush() — void Flush()`

来源：源码第 336 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.PromptHistory(NationalSpire.PrivateTurn, string)`](DateSceneData.cs.md#symbol-1bee81f08078)

**调用：** `NationalSpire.DateSceneLine.DateSceneLine()`；[`NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`](DateSceneData.cs.md#symbol-711ab692d366)；`System.Text.StringBuilder.Append(char)`；`System.Text.StringBuilder.Append(string?)`；`System.Text.StringBuilder.Clear()`；`System.Text.StringBuilder.ToString()`；`string.Trim()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneLine.Background`；`NationalSpire.DateSceneLine.Emotion`；`NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.Speaker`；`NationalSpire.DateSceneLine.Text`；`NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneLine.DateSceneLine()`；输入表达式：`new() { Narration = true, Text = body.ToString() }`；返回值紧邻使用处：`ArgumentSyntax: new() { Narration = true, Text = body.ToString() }`
- `NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`；输入表达式：`DisplayText(new() { Narration = true, Text = body.ToString() })`；返回值紧邻使用处：`ArgumentSyntax: DisplayText(new() { Narration = true, Text = body.ToString() })`
- `System.Text.StringBuilder.Append(char)`；输入表达式：`result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host) .Append(", Emotion: ").Append(current.Emotion).Append(", Background: ").Append(background).Append(']')`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host) .Append(", Emotion: ").Append(current.Emotion).Append(", Background: ").Append(background).Append(']').Append`
- `System.Text.StringBuilder.Append(char)`；输入表达式：`result.Append("[Scene: narration, Background: ").Append(background).Append(']')`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Append("[Scene: narration, Background: ").Append(background).Append(']') .Append`
- `System.Text.StringBuilder.Append(char)`；输入表达式：`result.Append('\n')`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Append('\n');`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`result.Append("[Scene: dialogue, Speaker: ")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Append("[Scene: dialogue, Speaker: ").Append`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host) .Append`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host) .Append(", Emotion: ")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host) .Append(", Emotion: ").Append`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host) .Append(", Emotion: ").Append(current.Emotion)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host) .Append(", Emotion: ").Append(current.Emotion).Append`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host) .Append(", Emotion: ").Append(current.Emotion).Append(", Background: ")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host) .Append(", Emotion: ").Append(current.Emotion).Append(", Background: ").Append`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host) .Append(", Emotion: ").Append(current.Emotion).Append(", Background: ").Append(background)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host) .Append(", Emotion: ").Append(current.Emotion).Append(", Background: ").Append(background).Append`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host) .Append(", Emotion: ").Append(current.Emotion).Append(", Background: ").Append(background).Append(']').Append(body.ToString().Trim())`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Append("[Scene: dialogue, Speaker: ").Append(current.Speaker.Length > 0 ? current.Speaker : host) .Append(", Emotion: ").Append(current.Emotion).Append(", Background: ").Append(background).Append(']').Append(body.ToString().Trim());`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`result.Append("[Scene: narration, Background: ")`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Append("[Scene: narration, Background: ").Append`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`result.Append("[Scene: narration, Background: ").Append(background)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: result.Append("[Scene: narration, Background: ").Append(background).Append`
- `System.Text.StringBuilder.Append(string?)`；输入表达式：`result.Append("[Scene: narration, Background: ").Append(background).Append(']') .Append(DisplayText(new() { Narration = true, Text = body.ToString() }))`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Append("[Scene: narration, Background: ").Append(background).Append(']') .Append(DisplayText(new() { Narration = true, Text = body.ToString() }));`
- `System.Text.StringBuilder.Clear()`；输入表达式：`body.Clear()`；返回值紧邻使用处：`ExpressionStatementSyntax: body.Clear();`
- `System.Text.StringBuilder.ToString()`；输入表达式：`body.ToString()`；返回值紧邻使用处：`AssignmentExpressionSyntax: Text = body.ToString()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`body.ToString()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: body.ToString().Trim`
- `string.Trim()`；输入表达式：`body.ToString().Trim()`；返回值紧邻使用处：`ArgumentSyntax: body.ToString().Trim()`

**赋值（含属性/字段和局部值）：**

- `Narration` = `true`
- `Text` = `body.ToString()`

<a id="symbol-da243e86633f"></a>

## `NationalSpire.DateScenes.JoinNarration(System.Collections.Generic.List<NationalSpire.DateSceneLine>) — private static List<DateSceneLine> JoinNarration(List<DateSceneLine> lines)`

来源：源码第 358 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

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

## `NationalSpire.DateScenes.BackgroundAt(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneLine>, int, string, System.Collections.Generic.ISet<string>?) — public static string BackgroundAt(IEnumerable<DateSceneLine> lines, int index, string initial, ISet<string>? available = null)`

来源：源码第 369 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneBackgrounds.At(System.Collections.Generic.IEnumerable<NationalSpire.DateSceneBackground>, System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, string, string)`](DateSceneBackgrounds.cs.md#symbol-0f51af8c0e19)

**调用：** `System.Collections.Generic.ICollection<T>.Contains(T)`；`System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneLine.Background`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.ICollection<T>.Contains(T)`；输入表达式：`available.Contains(line.Background)`；返回值紧邻使用处：`BinaryExpressionSyntax: available == null || available.Contains(line.Background)`
- `System.Collections.Generic.IEnumerable<TSource>.LastOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`lines.Take(index + 1).LastOrDefault(line => line.Background.Length > 0 && line.Background != "current" && (available == null || available.Contains(line.Background)))`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: lines.Take(index + 1).LastOrDefault(line => line.Background.Length > 0 && line.Background != "current" && (available == null || available.Contains(line.Background)))?.Background`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`lines.Take(index + 1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: lines.Take(index + 1).LastOrDefault`

**赋值（含属性/字段和局部值）：**


<a id="symbol-711ab692d366"></a>

## `NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine) — public static string DisplayText(DateSceneLine line)`

来源：源码第 372 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`Flush()`](DateSceneData.cs.md#symbol-5a50e4e9d311)；[`NationalSpire.DateMemoryPlayback.History()`](DateSceneMemoryPlayback.cs.md#symbol-b888e2863847)；[`NationalSpire.DateMemoryPlayback.HistoryEntries()`](DateSceneMemoryPlayback.cs.md#symbol-095d68561b37)；[`NationalSpire.DateSceneParty.SharedMemory(NationalSpire.CareerData, string, string)`](DateSceneParty.cs.md#symbol-5315c2e1b812)；[`NationalSpire.DateScenes.HistoryEntries(NationalSpire.PrivateConversation, string, string, int, string, string)`](DateSceneData.cs.md#symbol-e8fbec0a77e3)；[`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`](DateSceneData.cs.md#symbol-801111e76ca9)；[`NationalSpire.DateSceneTesting._Process(double)`](DateSceneTesting.cs.md#symbol-e5cbbec1bb0d)；[`NationalSpire.DateSceneView.AppendLine(System.Collections.Generic.IReadOnlyList<NationalSpire.DateSceneLine>, int, System.Func<(string Name, Godot.Texture2D Texture)>?)`](DateSceneView.cs.md#symbol-eecb2292c03b)；[`NationalSpire.DateSceneView.ShowLineCore(NationalSpire.DateSceneLine, string, Godot.Texture2D, bool)`](DateSceneView.cs.md#symbol-d19549d8d807)

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

来源：源码第 374 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateScene(string, bool, bool)`](DateSceneScreen.cs.md#symbol-bb8a80d5df80)；[`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)

**调用：** [`NationalSpire.DateScenes.HistoryEntries(NationalSpire.PrivateConversation, string, string, int, string, string)`](DateSceneData.cs.md#symbol-e8fbec0a77e3)；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateHistoryEntry.Text`；`NationalSpire.DateScenes.HistoryEntries(NationalSpire.PrivateConversation, string, string, int, string, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateScenes.HistoryEntries(NationalSpire.PrivateConversation, string, string, int, string, string)`；输入表达式：`HistoryEntries(conversation, offerId, currentTurn, index, player, npc)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = HistoryEntries(conversation, offerId, currentTurn, index, player, npc)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`entries.Select(e => e.Text)`；返回值紧邻使用处：`ArgumentSyntax: entries.Select(e => e.Text)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n\n", entries.Select(e => e.Text))`；返回值紧邻使用处：`ConditionalExpressionSyntax: entries.Count > 0 ? string.Join("\n\n", entries.Select(e => e.Text)) : "约会开始后的对话会显示在这里。"`

**赋值（含属性/字段和局部值）：**


<a id="symbol-e8fbec0a77e3"></a>

## `NationalSpire.DateScenes.HistoryEntries(NationalSpire.PrivateConversation, string, string, int, string, string) — public static IReadOnlyList<DateHistoryEntry> HistoryEntries(PrivateConversation conversation, string offerId, string currentTurn, int index, string player, string npc)`

来源：源码第 379 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)；[`NationalSpire.DateScenes.History(NationalSpire.PrivateConversation, string, string, int, string, string)`](DateSceneData.cs.md#symbol-13e129fe5e9e)

**调用：** `NationalSpire.DateHistoryEntry.DateHistoryEntry(string, string, bool)`；[`NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`](DateSceneData.cs.md#symbol-711ab692d366)；[`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`](DateSceneData.cs.md#symbol-801111e76ca9)；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List()`；`System.Text.StringBuilder.AppendLine()`；`System.Text.StringBuilder.AppendLine(string?)`；`System.Text.StringBuilder.StringBuilder()`；`System.Text.StringBuilder.ToString()`；`string.IsNullOrEmpty(string?)`；`string.TrimEnd()`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.Speaker`；`NationalSpire.DateSceneParticipant.Name`；`NationalSpire.DateSceneParticipant.PersonId`；`NationalSpire.DateSceneRequest.Ending`；`NationalSpire.DateSceneRequest.GameEvent`；`NationalSpire.DateSceneRequest.OfferId`；`NationalSpire.DateSceneRequest.Opening`；`NationalSpire.DateSceneRequest.Participants`；`NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`；`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.User`；`NationalSpire.PrivateTurn.UserDeleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateHistoryEntry.DateHistoryEntry(string, string, bool)`；输入表达式：`new(turn.Id, player + "\n" + turn.User, false)`；返回值紧邻使用处：`ArgumentSyntax: new(turn.Id, player + "\n" + turn.User, false)`
- `NationalSpire.DateHistoryEntry.DateHistoryEntry(string, string, bool)`；输入表达式：`new(turn.Id, text.ToString().TrimEnd(), true)`；返回值紧邻使用处：`ArgumentSyntax: new(turn.Id, text.ToString().TrimEnd(), true)`
- `NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`；输入表达式：`DisplayText(line)`；返回值紧邻使用处：`ArgumentSyntax: DisplayText(line)`
- `NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`；输入表达式：`Lines(turn)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: Lines(turn).Take`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Participants.FirstOrDefault(p => p.PersonId == line.Speaker)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: .Participants.FirstOrDefault(p => p.PersonId == line.Speaker)?.Name`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`Lines(turn).Take(turn.Id == currentTurn ? index + 1 : int.MaxValue)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var line in Lines(turn).Take(turn.Id == currentTurn ? index + 1 : int.MaxValue)) { if (!line.Narration) text.AppendLine(turn.Scene?.Participants.FirstOrDefault(p => p.PersonId == line.Speaker)?.Name ?? npc); text.AppendLine(DisplayText(line)).AppendLine(); }`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`conversation.Turns.Where(t => t.Scene?.OfferId == offerId)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var turn in conversation.Turns.Where(t => t.Scene?.OfferId == offerId)) { if (!turn.UserDeleted && turn.Scene?.Opening != true && turn.Scene?.Ending != true && string.IsNullOrEmpty(turn.Scene?.GameEvent) && turn.User.Length > 0) result.Add(new(turn.Id, player + "\n" + turn.User, false)); if (!turn.ReplyDeleted && turn.Status == "complete") { var text = new StringBuilder(); foreach (var line in Lines(turn).Take(turn.Id == currentTurn ? index + 1 : int.MaxValue)) { if (!line.Narration) text.AppendLine(turn.Scene?.Participants.FirstOrDefault(p => p.PersonId == line.Speaker)?.Name ?? npc); text.AppendLine(DisplayText(line)).AppendLine(); } if (text.Length > 0) result.Add(new(turn.Id, text.ToString().TrimEnd(), true)); } if (turn.Id == currentTurn) break; }`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.Add(new(turn.Id, player + "\n" + turn.User, false))`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Add(new(turn.Id, player + "\n" + turn.User, false));`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`result.Add(new(turn.Id, text.ToString().TrimEnd(), true))`；返回值紧邻使用处：`ExpressionStatementSyntax: result.Add(new(turn.Id, text.ToString().TrimEnd(), true));`
- `System.Collections.Generic.List<T>.List()`；输入表达式：`new List<DateHistoryEntry>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<DateHistoryEntry>()`
- `System.Text.StringBuilder.AppendLine()`；输入表达式：`text.AppendLine(DisplayText(line)).AppendLine()`；返回值紧邻使用处：`ExpressionStatementSyntax: text.AppendLine(DisplayText(line)).AppendLine();`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`text.AppendLine(DisplayText(line))`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.AppendLine(DisplayText(line)).AppendLine`
- `System.Text.StringBuilder.AppendLine(string?)`；输入表达式：`text.AppendLine(turn.Scene?.Participants.FirstOrDefault(p => p.PersonId == line.Speaker)?.Name ?? npc)`；返回值紧邻使用处：`ExpressionStatementSyntax: text.AppendLine(turn.Scene?.Participants.FirstOrDefault(p => p.PersonId == line.Speaker)?.Name ?? npc);`
- `System.Text.StringBuilder.StringBuilder()`；输入表达式：`new StringBuilder()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new StringBuilder()`
- `System.Text.StringBuilder.ToString()`；输入表达式：`text.ToString()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: text.ToString().TrimEnd`
- `string.IsNullOrEmpty(string?)`；输入表达式：`string.IsNullOrEmpty(turn.Scene?.GameEvent)`；返回值紧邻使用处：`BinaryExpressionSyntax: !turn.UserDeleted && turn.Scene?.Opening != true && turn.Scene?.Ending != true && string.IsNullOrEmpty(turn.Scene?.GameEvent)`
- `string.TrimEnd()`；输入表达式：`text.ToString().TrimEnd()`；返回值紧邻使用处：`ArgumentSyntax: text.ToString().TrimEnd()`

**赋值（含属性/字段和局部值）：**
