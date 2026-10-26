# DateSceneParty.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`97B7FA0F171CFC8C33B8D435B69BF7DD7BCE06B220A99CCCD67256B1A5003F3E`。来源：[源码](../../DateSceneParty.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.DateSceneParticipant`、`NationalSpire.DateSceneParty`。

字段、事件及初始值（源码原样）：

```csharp
internal static readonly JsonSerializerOptions PromptJson = new() { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
public const int VisibleMaximum = 3;
public const string Protocol = """
本轮是多人在场的连续约会场景。前文以单个私信对象表述的人称在此扩展为参与者名单中的全部NPC；逐人保留原人物设定、说话方式、用词约束和私人记忆边界。
本轮至少让两名在场NPC直接回应彼此，围绕同一个话题往返接话；已经说过话的人应再次回应后续人物。组织为A→B→A、A→B→C→A→B等连续交流，每次接话1—2个短句，在同一轮内完成数次往返。NPC可以追问、补充、打趣或接续其他NPC的动作，分别保持自己的观点；玩家的发言和行动由玩家决定。人数较多时由当前相关的2—3人展开互动，其余人保留在场。玩家明确指定单独回答或保持沉默时依照该要求。
每个完整台词句子都独立写一个Scene标记，即使说话人相同也重新写Speaker和Emotion。每句依据当前语气、动作及对上一人的反应重新选择表情；情绪相同可以复用，发生变化时立即改用相应可用编号。每句填写说话者的完整PersonId，并使用该人物自己的可用Emotion编号：
[Scene: dialogue, Speaker: 人物PersonId, Emotion: neutral, Background: current]台词
旁白仍使用Scene: narration。台词只属于Speaker标明的人物，玩家的发言和行动由玩家决定。
每个关系、状态、档案或学习标记都填写Actor为实际发生变化的NPC完整PersonId，例如 [Favour: 23, Actor: 人物PersonId]、[Skill: 1, Topic: 防御, Reason: 学会依据下回合伤害保留格挡, Actor: 人物PersonId]。关系变化的对象为玩家。其余交互由本次活动的主联系人处理。
""";
```

<a id="symbol-89b27802e6dc"></a>

## `NationalSpire.DateSceneParticipant.PersonId — public string PersonId`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-59b42ba2ddf8"></a>

## `NationalSpire.DateSceneParticipant.Name — public string Name`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-2c0ddea76a3a"></a>

## `NationalSpire.DateSceneParticipant.OutfitId — public string OutfitId`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-73d0ca9694b2"></a>

## `NationalSpire.DateSceneParticipant.DefaultEmotionId — public string DefaultEmotionId`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-eed3c67620e9"></a>

## `NationalSpire.DateSceneParticipant.Emotions — public Dictionary<string, string> Emotions`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-d5df29df1375"></a>

## `NationalSpire.DateSceneParty.ExchangeExample(NationalSpire.DateSceneRequest) — public static string ExchangeExample(DateSceneRequest scene)`

来源：源码第 27 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.Guidance(NationalSpire.DateSceneRequest, bool)`](DateSceneData.cs.md#symbol-42aa2fbcaa1f)

**调用：** [`Changed(NationalSpire.DateSceneParticipant)`](DateSceneParty.cs.md#symbol-b6840c8d666b)；[`Line(NationalSpire.DateSceneParticipant, string, string)`](DateSceneParty.cs.md#symbol-9c2f5712aed0)

**字段、属性、事件及方法组引用：** `Changed(NationalSpire.DateSceneParticipant)`；`Line(NationalSpire.DateSceneParticipant, string, string)`；`NationalSpire.DateSceneParticipant.DefaultEmotionId`；`NationalSpire.DateSceneParticipant.Name`；`NationalSpire.DateSceneRequest.Participants`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Changed(NationalSpire.DateSceneParticipant)`；输入表达式：`Changed(a)`；返回值紧邻使用处：`ArgumentSyntax: Changed(a)`
- `Changed(NationalSpire.DateSceneParticipant)`；输入表达式：`Changed(b)`；返回值紧邻使用处：`ArgumentSyntax: Changed(b)`
- `Line(NationalSpire.DateSceneParticipant, string, string)`；输入表达式：`Line(a, Changed(a), "好，那我们一起想想。")`；返回值紧邻使用处：`BinaryExpressionSyntax: "\n交错与逐句标注示例（只示范结构，具体话题根据当前情境）：\n" + Line(a, a.DefaultEmotionId, b.Name + "，你刚才也注意到了？") + "\n" + Line(b, Changed(b), "嗯，我还想听你多说一点。") + "\n" + Line(a, Changed(a), "好，那我们一起想想。")`
- `Line(NationalSpire.DateSceneParticipant, string, string)`；输入表达式：`Line(a, a.DefaultEmotionId, b.Name + "，你刚才也注意到了？")`；返回值紧邻使用处：`BinaryExpressionSyntax: "\n交错与逐句标注示例（只示范结构，具体话题根据当前情境）：\n" + Line(a, a.DefaultEmotionId, b.Name + "，你刚才也注意到了？")`
- `Line(NationalSpire.DateSceneParticipant, string, string)`；输入表达式：`Line(b, Changed(b), "嗯，我还想听你多说一点。")`；返回值紧邻使用处：`BinaryExpressionSyntax: "\n交错与逐句标注示例（只示范结构，具体话题根据当前情境）：\n" + Line(a, a.DefaultEmotionId, b.Name + "，你刚才也注意到了？") + "\n" + Line(b, Changed(b), "嗯，我还想听你多说一点。")`
- `Line(NationalSpire.DateSceneParticipant, string, string)`；输入表达式：`Line(b, b.DefaultEmotionId, "我有一个想法，大家听听看？")`；返回值紧邻使用处：`BinaryExpressionSyntax: "\n交错与逐句标注示例（只示范结构，具体话题根据当前情境）：\n" + Line(a, a.DefaultEmotionId, b.Name + "，你刚才也注意到了？") + "\n" + Line(b, Changed(b), "嗯，我还想听你多说一点。") + "\n" + Line(a, Changed(a), "好，那我们一起想想。") + "\n" + Line(b, b.DefaultEmotionId, "我有一个想法，大家听听看？")`

**赋值（含属性/字段和局部值）：**


<a id="symbol-b6840c8d666b"></a>

## `Changed(NationalSpire.DateSceneParticipant) — string Changed(DateSceneParticipant p)`

来源：源码第 31 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneParty.ExchangeExample(NationalSpire.DateSceneRequest)`](DateSceneParty.cs.md#symbol-d5df29df1375)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneParticipant.DefaultEmotionId`；`NationalSpire.DateSceneParticipant.Emotions`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`p.Emotions.Keys.FirstOrDefault(id => id != p.DefaultEmotionId)`；返回值紧邻使用处：`BinaryExpressionSyntax: p.Emotions.Keys.FirstOrDefault(id => id != p.DefaultEmotionId) ?? p.DefaultEmotionId`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9c2f5712aed0"></a>

## `Line(NationalSpire.DateSceneParticipant, string, string) — string Line(DateSceneParticipant p, string emotion, string text)`

来源：源码第 32 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneParty.ExchangeExample(NationalSpire.DateSceneRequest)`](DateSceneParty.cs.md#symbol-d5df29df1375)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneParticipant.PersonId`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f9cb6b2133b0"></a>

## `NationalSpire.DateSceneParty.People(NationalSpire.CareerData, NationalSpire.PrivateOffer, string) — public static List<string> People(CareerData data, PrivateOffer offer, string host)`

来源：源码第 39 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddPausedDateScenes(NationalSpire.CareerData, NationalSpire.PrivateConversation)`](DateSceneScreen.cs.md#symbol-a5b10d9fb0b8)；[`NationalSpire.CareerScreen.InviteDateParticipant(string)`](DateScenePartyScreen.cs.md#symbol-71141f3538db)；[`NationalSpire.CareerScreen.LoadDateParty(NationalSpire.CareerData, string, string)`](DateScenePartyScreen.cs.md#symbol-e7d1a77e170a)；[`NationalSpire.CareerScreen.OpenDateSceneReady(string, bool, bool, System.Action?)`](DateSceneScreen.cs.md#symbol-bf30200a2448)；[`NationalSpire.CareerScreen.RefreshDateParty()`](DateScenePartyScreen.cs.md#symbol-3918c1aaf95a)；[`NationalSpire.DateGames.Respond(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.Dictionary<string, string>>)`](DateGames.cs.md#symbol-e72b5454cf31)；[`NationalSpire.DateSceneInvitations.Invite(NationalSpire.CareerData, string, string, string)`](DateSceneInvitations.cs.md#symbol-fbd645f524af)；[`NationalSpire.DateSceneParty.Eligible(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneParty.cs.md#symbol-0b65821baf62)；[`NationalSpire.DateSceneParty.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer, NationalSpire.DateSceneRequest)`](DateSceneParty.cs.md#symbol-9fb95a4d45a5)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-24bc82bdbbd4)；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；`NationalSpire.PrivateOffer.Participants`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Person(data, id) != null`
- `NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.IsHuman(data, id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GroupChats.IsHuman(data, id)`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`new[] { host }.Concat(offer.Participants)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { host }.Concat(offer.Participants).Where`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>()`；输入表达式：`new[] { host }.Concat(offer.Participants).Where(id => !GroupChats.IsHuman(data, id) && CareerEngine.Person(data, id) != null).Distinct()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { host }.Concat(offer.Participants).Where(id => !GroupChats.IsHuman(data, id) && CareerEngine.Person(data, id) != null).Distinct().ToList`
- `System.Collections.Generic.IEnumerable<TSource>.ToList<TSource>()`；输入表达式：`new[] { host }.Concat(offer.Participants).Where(id => !GroupChats.IsHuman(data, id) && CareerEngine.Person(data, id) != null).Distinct().ToList()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => new[] { host }.Concat(offer.Participants).Where(id => !GroupChats.IsHuman(data, id) && CareerEngine.Person(data, id) != null).Distinct().ToList()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`new[] { host }.Concat(offer.Participants).Where(id => !GroupChats.IsHuman(data, id) && CareerEngine.Person(data, id) != null)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: new[] { host }.Concat(offer.Participants).Where(id => !GroupChats.IsHuman(data, id) && CareerEngine.Person(data, id) != null).Distinct`

**赋值（含属性/字段和局部值）：**


<a id="symbol-0b65821baf62"></a>

## `NationalSpire.DateSceneParty.Eligible(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?) — public static bool Eligible(CareerData data, PrivateOffer offer, PrivateConversation? conversation)`

来源：源码第 41 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.AddDateSceneAction(NationalSpire.CareerData, NationalSpire.PrivateOffer, Godot.HBoxContainer)`](DateSceneScreen.cs.md#symbol-413adf55a103)；[`NationalSpire.DateSceneInvitations.Invite(NationalSpire.CareerData, string, string, string)`](DateSceneInvitations.cs.md#symbol-fbd645f524af)；[`NationalSpire.DateScenes.Available(NationalSpire.CareerData, NationalSpire.PrivateOffer, NationalSpire.PrivateConversation?)`](DateSceneData.cs.md#symbol-0d3e014bcb63)

**调用：** [`NationalSpire.DateSceneParty.People(NationalSpire.CareerData, NationalSpire.PrivateOffer, string)`](DateSceneParty.cs.md#symbol-f9cb6b2133b0)；[`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`](GroupChats.cs.md#symbol-d2f9293a6561)；`System.Collections.Generic.List<T>.Contains(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneParty.People(NationalSpire.CareerData, NationalSpire.PrivateOffer, string)`；`NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateOffer.GroupId`；`NationalSpire.PrivateOffer.Kind`；`NationalSpire.PrivateOffer.Participants`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneParty.People(NationalSpire.CareerData, NationalSpire.PrivateOffer, string)`；输入表达式：`People(data, offer, conversation.PersonId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: People(data, offer, conversation.PersonId).Count`
- `NationalSpire.GroupChats.Human(NationalSpire.CareerData)`；输入表达式：`GroupChats.Human(data)`；返回值紧邻使用处：`ArgumentSyntax: GroupChats.Human(data)`
- `System.Collections.Generic.List<T>.Contains(T)`；输入表达式：`offer.Participants.Contains(GroupChats.Human(data))`；返回值紧邻使用处：`BinaryExpressionSyntax: offer.Participants.Count == 0 || offer.Participants.Contains(GroupChats.Human(data))`

**赋值（含属性/字段和局部值）：**


<a id="symbol-9fb95a4d45a5"></a>

## `NationalSpire.DateSceneParty.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateOffer, NationalSpire.DateSceneRequest) — public static string? Validate(CareerData data, PrivateConversation conversation, PrivateOffer offer, DateSceneRequest request)`

来源：源码第 45 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.Validate(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.DateSceneRequest, bool)`](DateSceneData.cs.md#symbol-190a72e967ad)

**调用：** [`NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-f3fe7eb74cad)；[`NationalSpire.DateSceneParty.People(NationalSpire.CareerData, NationalSpire.PrivateOffer, string)`](DateSceneParty.cs.md#symbol-f9cb6b2133b0)；[`NationalSpire.PortraitDesigns.SafeId(string)`](PortraitDesign.cs.md#symbol-7497548faaf1)；[`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-25194feb6779)；`System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；`System.Collections.Generic.HashSet<T>.SetEquals(System.Collections.Generic.IEnumerable<T>)`；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneParticipant.DefaultEmotionId`；`NationalSpire.DateSceneParticipant.Emotions`；`NationalSpire.DateSceneParticipant.Name`；`NationalSpire.DateSceneParticipant.OutfitId`；`NationalSpire.DateSceneParticipant.PersonId`；`NationalSpire.DateSceneParty.People(NationalSpire.CareerData, NationalSpire.PrivateOffer, string)`；`NationalSpire.DateSceneRequest.Participants`；`NationalSpire.PortraitDesigns.SafeId(string)`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.DisplayName(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.DisplayName(data, member.PersonId)`；返回值紧邻使用处：`AssignmentExpressionSyntax: member.Name = CareerEngine.DisplayName(data, member.PersonId)`
- `NationalSpire.DateSceneParty.People(NationalSpire.CareerData, NationalSpire.PrivateOffer, string)`；输入表达式：`People(data, offer, conversation.PersonId)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = People(data, offer, conversation.PersonId)`
- `NationalSpire.PortraitDesigns.SafeId(string)`；输入表达式：`PortraitDesigns.SafeId(id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PortraitDesigns.SafeId(id)`
- `NationalSpire.PortraitDesigns.SafeId(string)`；输入表达式：`PortraitDesigns.SafeId(member.OutfitId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PortraitDesigns.SafeId(member.OutfitId)`
- `NationalSpire.PrivateMessages.CanChat(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.CanChat(data, member.PersonId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !PrivateMessages.CanChat(data, member.PersonId)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.ContainsKey(TKey)`；输入表达式：`member.Emotions.ContainsKey(member.DefaultEmotionId)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !member.Emotions.ContainsKey(member.DefaultEmotionId)`
- `System.Collections.Generic.HashSet<T>.SetEquals(System.Collections.Generic.IEnumerable<T>)`；输入表达式：`request.Participants.Select(p => p.PersonId).ToHashSet().SetEquals(people)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !request.Participants.Select(p => p.PersonId).ToHashSet().SetEquals(people)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`member.Emotions.Keys.Any(id => !PortraitDesigns.SafeId(id))`；返回值紧邻使用处：`BinaryExpressionSyntax: !PortraitDesigns.SafeId(member.OutfitId) || member.Emotions.Count == 0 || member.Emotions.Count > 100 || !member.Emotions.ContainsKey(member.DefaultEmotionId) || member.Emotions.Keys.Any(id => !PortraitDesigns.SafeId(id))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`request.Participants.Select(p => p.PersonId)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: request.Participants.Select(p => p.PersonId).ToHashSet`
- `System.Collections.Generic.IEnumerable<TSource>.ToHashSet<TSource>()`；输入表达式：`request.Participants.Select(p => p.PersonId).ToHashSet()`；返回值紧邻使用处：`MemberAccessExpressionSyntax: request.Participants.Select(p => p.PersonId).ToHashSet().SetEquals`

**赋值（含属性/字段和局部值）：**

- `member.Name` = `CareerEngine.DisplayName(data, member.PersonId)`

<a id="symbol-6bfcef03874d"></a>

## `NationalSpire.DateSceneParty.Resolve(NationalSpire.DateSceneRequest, string) — public static string Resolve(DateSceneRequest scene, string speaker)`

来源：源码第 60 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.ReadSegment(string, NationalSpire.DateSceneRequest, System.Collections.Generic.Dictionary<string, string>?)`](DateSceneData.cs.md#symbol-df380ec1333f)

**调用：** `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneParticipant.Name`；`NationalSpire.DateSceneParticipant.PersonId`；`NationalSpire.DateSceneRequest.Participants`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>()`；输入表达式：`scene.Participants.FirstOrDefault()`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: scene.Participants.FirstOrDefault()?.PersonId`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`scene.Participants.FirstOrDefault(p => p.PersonId == speaker || p.Name == speaker)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: scene.Participants.FirstOrDefault(p => p.PersonId == speaker || p.Name == speaker)?.PersonId`

**赋值（含属性/字段和局部值）：**


<a id="symbol-c3a9f302456e"></a>

## `NationalSpire.DateSceneParty.ForSpeaker(NationalSpire.DateSceneRequest, string) — public static DateSceneRequest ForSpeaker(DateSceneRequest scene, string speaker)`

来源：源码第 63 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateScenes.ReadSegment(string, NationalSpire.DateSceneRequest, System.Collections.Generic.Dictionary<string, string>?)`](DateSceneData.cs.md#symbol-df380ec1333f)；[`NationalSpire.DateScenes.TaggedLines(NationalSpire.PrivateStreamParser, NationalSpire.DateSceneRequest)`](DateSceneData.cs.md#symbol-00bcca1f004c)

**调用：** `NationalSpire.DateSceneRequest.DateSceneRequest()`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateSceneParticipant.DefaultEmotionId`；`NationalSpire.DateSceneParticipant.Emotions`；`NationalSpire.DateSceneParticipant.PersonId`；`NationalSpire.DateSceneRequest.DefaultEmotionId`；`NationalSpire.DateSceneRequest.Emotions`；`NationalSpire.DateSceneRequest.Participants`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateSceneRequest.DateSceneRequest()`；输入表达式：`new() { Emotions = member.Emotions, DefaultEmotionId = member.DefaultEmotionId }`；返回值紧邻使用处：`ConditionalExpressionSyntax: member == null ? scene : new() { Emotions = member.Emotions, DefaultEmotionId = member.DefaultEmotionId }`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`scene.Participants.FirstOrDefault(p => p.PersonId == speaker)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = scene.Participants.FirstOrDefault(p => p.PersonId == speaker)`

**赋值（含属性/字段和局部值）：**

- `DefaultEmotionId` = `member.DefaultEmotionId`
- `Emotions` = `member.Emotions`

<a id="symbol-050345b203c6"></a>

## `NationalSpire.DateSceneParty.Position(int, int) — public static float Position(int count, int index)`

来源：源码第 68 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneView.PortraitPosition(string, int, Godot.Vector2, Godot.Texture2D?)`](DateSceneCast.cs.md#symbol-660b122db429)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-fcb96c133a03"></a>

## `NationalSpire.DateSceneParty.Context(NationalSpire.CareerData, NationalSpire.DateSceneRequest) — public static string Context(CareerData data, DateSceneRequest scene)`

来源：源码第 69 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessagePrompts.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-4b9d12b26f65)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.DateSceneParty.RelationContext(NationalSpire.PrivateRelation)`](DateSceneParty.cs.md#symbol-3d4d35d8688c)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；[`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`](PrivateMessages.cs.md#symbol-8a6bb6e78fa5)；[`NationalSpire.PrivatePublicContext.CharacterProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`](PrivatePublicContext.cs.md#symbol-9d0bf89294e6)；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.DateSceneParticipant.Name`；`NationalSpire.DateSceneParticipant.PersonId`；`NationalSpire.DateSceneParty.PromptJson`；`NationalSpire.DateSceneParty.RelationContext(NationalSpire.PrivateRelation)`；`NationalSpire.DateSceneRequest.Participants`；`NationalSpire.PrivateConversation.BigSummaries`；`NationalSpire.PrivateConversation.Forgotten`；`NationalSpire.PrivateConversation.SmallSummaries`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；`NationalSpire.PrivatePublicContext.CharacterProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`；`NationalSpire.PrivateSummary.Text`；`NationalSpire.PrivateTurn.Reply`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.User`；`NationalSpire.PrivateTurn.UserDeleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, p.PersonId)`；返回值紧邻使用处：`PostfixUnaryExpressionSyntax: CareerEngine.Person(data, p.PersonId)!`
- `NationalSpire.DateSceneParty.RelationContext(NationalSpire.PrivateRelation)`；输入表达式：`RelationContext(PrivateMessages.Relation(data, p.PersonId))`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: relation = RelationContext(PrivateMessages.Relation(data, p.PersonId))`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations`
- `NationalSpire.PrivateMessages.Relation(NationalSpire.CareerData, string)`；输入表达式：`PrivateMessages.Relation(data, p.PersonId)`；返回值紧邻使用处：`ArgumentSyntax: PrivateMessages.Relation(data, p.PersonId)`
- `NationalSpire.PrivatePublicContext.CharacterProfile(NationalSpire.CareerData, NationalSpire.CareerPerson)`；输入表达式：`PrivatePublicContext.CharacterProfile(data, CareerEngine.Person(data, p.PersonId)!)`；返回值紧邻使用处：`AnonymousObjectMemberDeclaratorSyntax: profile = PrivatePublicContext.CharacterProfile(data, CareerEngine.Person(data, p.PersonId)!)`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.TryGetValue(p.PersonId, out var c)`；返回值紧邻使用处：`BinaryExpressionSyntax: PrivateMessages.Mailbox(data).Conversations.TryGetValue(p.PersonId, out var c) && !c.Forgotten`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`c.BigSummaries.Concat(c.SmallSummaries)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.BigSummaries.Concat(c.SmallSummaries).TakeLast`
- `System.Collections.Generic.IEnumerable<TSource>.Concat<TSource>(System.Collections.Generic.IEnumerable<TSource>)`；输入表达式：`c.BigSummaries.Concat(c.SmallSummaries).TakeLast(2).Select(s => s.Text) .Concat(c.Turns.Where(t => t.Status == "complete" && !t.ReplyDeleted && t.Scene == null).TakeLast(3) .Select(t => (t.UserDeleted ? "" : "玩家：" + t.User + "\n") + p.Name + "：" + t.Reply))`；返回值紧邻使用处：`ArgumentSyntax: c.BigSummaries.Concat(c.SmallSummaries).TakeLast(2).Select(s => s.Text) .Concat(c.Turns.Where(t => t.Status == "complete" && !t.ReplyDeleted && t.Scene == null).TakeLast(3) .Select(t => (t.UserDeleted ? "" : "玩家：" + t.User + "\n") + p.Name + "：" + t.Reply))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`c.BigSummaries.Concat(c.SmallSummaries).TakeLast(2).Select(s => s.Text)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.BigSummaries.Concat(c.SmallSummaries).TakeLast(2).Select(s => s.Text) .Concat`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`c.Turns.Where(t => t.Status == "complete" && !t.ReplyDeleted && t.Scene == null).TakeLast(3) .Select(t => (t.UserDeleted ? "" : "玩家：" + t.User + "\n") + p.Name + "：" + t.Reply)`；返回值紧邻使用处：`ArgumentSyntax: c.Turns.Where(t => t.Status == "complete" && !t.ReplyDeleted && t.Scene == null).TakeLast(3) .Select(t => (t.UserDeleted ? "" : "玩家：" + t.User + "\n") + p.Name + "：" + t.Reply)`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`scene.Participants.Skip(1).Select(p => new { p.PersonId, p.Name, profile = PrivatePublicContext.CharacterProfile(data, CareerEngine.Person(data, p.PersonId)!), relation = RelationContext(PrivateMessages.Relation(data, p.PersonId)), memory = PrivateMessages.Mailbox(data).Conversations.TryGetValue(p.PersonId, out var c) && !c.Forgotten ? string.Join("\n", c.BigSummaries.Concat(c.SmallSummaries).TakeLast(2).Select(s => s.Text) .Concat(c.Turns.Where(t => t.Status == "complete" && !t.ReplyDeleted && t.Scene == null).TakeLast(3) .Select(t => (t.UserDeleted ? "" : "玩家：" + t.User + "\n") + p.Name + "：" + t.Reply))) : "" })`；返回值紧邻使用处：`ArgumentSyntax: scene.Participants.Skip(1).Select(p => new { p.PersonId, p.Name, profile = PrivatePublicContext.CharacterProfile(data, CareerEngine.Person(data, p.PersonId)!), relation = RelationContext(PrivateMessages.Relation(data, p.PersonId)), memory = PrivateMessages.Mailbox(data).Conversations.TryGetValue(p.PersonId, out var c) && !c.Forgotten ? string.Join("\n", c.BigSummaries.Concat(c.SmallSummaries).TakeLast(2).Select(s => s.Text) .Concat(c.Turns.Where(t => t.Status == "complete" && !t.ReplyDeleted && t.Scene == null).TakeLast(3) .Select(t => (t.UserDeleted ? "" : "玩家：" + t.User + "\n") + p.Name + "：" + t.Reply))) : "" })`
- `System.Collections.Generic.IEnumerable<TSource>.Skip<TSource>(int)`；输入表达式：`scene.Participants.Skip(1)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: scene.Participants.Skip(1).Select`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`c.BigSummaries.Concat(c.SmallSummaries).TakeLast(2)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.BigSummaries.Concat(c.SmallSummaries).TakeLast(2).Select`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`c.Turns.Where(t => t.Status == "complete" && !t.ReplyDeleted && t.Scene == null).TakeLast(3)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Turns.Where(t => t.Status == "complete" && !t.ReplyDeleted && t.Scene == null).TakeLast(3) .Select`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`c.Turns.Where(t => t.Status == "complete" && !t.ReplyDeleted && t.Scene == null)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: c.Turns.Where(t => t.Status == "complete" && !t.ReplyDeleted && t.Scene == null).TakeLast`
- `System.Text.Json.JsonSerializer.Serialize<TValue>(TValue, System.Text.Json.JsonSerializerOptions?)`；输入表达式：`JsonSerializer.Serialize(scene.Participants.Skip(1).Select(p => new { p.PersonId, p.Name, profile = PrivatePublicContext.CharacterProfile(data, CareerEngine.Person(data, p.PersonId)!), relation = RelationContext(PrivateMessages.Relation(data, p.PersonId)), memory = PrivateMessages.Mailbox(data).Conversations.TryGetValue(p.PersonId, out var c) && !c.Forgotten ? string.Join("\n", c.BigSummaries.Concat(c.SmallSummaries).TakeLast(2).Select(s => s.Text) .Concat(c.Turns.Where(t => t.Status == "complete" && !t.ReplyDeleted && t.Scene == null).TakeLast(3) .Select(t => (t.UserDeleted ? "" : "玩家：" + t.User + "\n") + p.Name + "：" + t.Reply))) : "" }), PromptJson)`；返回值紧邻使用处：`BinaryExpressionSyntax: "主联系人使用前文人物资料、关系与记忆。其余约会参与者资料（人物编号仅用于归属）：\n" + JsonSerializer.Serialize(scene.Participants.Skip(1).Select(p => new { p.PersonId, p.Name, profile = PrivatePublicContext.CharacterProfile(data, CareerEngine.Person(data, p.PersonId)!), relation = RelationContext(PrivateMessages.Relation(data, p.PersonId)), memory = PrivateMessages.Mailbox(data).Conversations.TryGetValue(p.PersonId, out var c) && !c.Forgotten ? string.Join("\n", c.BigSummaries.Concat(c.SmallSummaries).TakeLast(2).Select(s => s.Text) .Concat(c.Turns.Where(t => t.Status == "complete" && !t.ReplyDeleted && t.Scene == null).TakeLast(3) .Select(t => (t.UserDeleted ? "" : "玩家：" + t.User + "\n") + p.Name + "：" + t.Reply))) : "" }), PromptJson)`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", c.BigSummaries.Concat(c.SmallSummaries).TakeLast(2).Select(s => s.Text) .Concat(c.Turns.Where(t => t.Status == "complete" && !t.ReplyDeleted && t.Scene == null).TakeLast(3) .Select(t => (t.UserDeleted ? "" : "玩家：" + t.User + "\n") + p.Name + "：" + t.Reply)))`；返回值紧邻使用处：`ConditionalExpressionSyntax: PrivateMessages.Mailbox(data).Conversations.TryGetValue(p.PersonId, out var c) && !c.Forgotten ? string.Join("\n", c.BigSummaries.Concat(c.SmallSummaries).TakeLast(2).Select(s => s.Text) .Concat(c.Turns.Where(t => t.Status == "complete" && !t.ReplyDeleted && t.Scene == null).TakeLast(3) .Select(t => (t.UserDeleted ? "" : "玩家：" + t.User + "\n") + p.Name + "：" + t.Reply))) : ""`

**赋值（含属性/字段和局部值）：**


<a id="symbol-3d4d35d8688c"></a>

## `NationalSpire.DateSceneParty.RelationContext(NationalSpire.PrivateRelation) — private static object RelationContext(PrivateRelation relation)`

来源：源码第 80 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.DateSceneParty.Context(NationalSpire.CareerData, NationalSpire.DateSceneRequest)`](DateSceneParty.cs.md#symbol-fcb96c133a03)

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.PrivateRelation.Favour`；`NationalSpire.PrivateRelation.Impression`；`NationalSpire.PrivateRelation.OathConfirmed`；`NationalSpire.PrivateRelation.Relationship`；`NationalSpire.PrivateRelation.SelectedBond`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-5315c2e1b812"></a>

## `NationalSpire.DateSceneParty.SharedMemory(NationalSpire.CareerData, string, string) — public static string SharedMemory(CareerData data, string person, string excludeTurn)`

来源：源码第 81 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.PrivateMessagePrompts.Context(NationalSpire.CareerData, NationalSpire.PrivateConversation, NationalSpire.PrivateTurn, System.Collections.Generic.List<NationalSpire.PrivateMessagePrompts.ContextSpan>?)`](PrivateMessagePrompts.cs.md#symbol-4b9d12b26f65)

**调用：** [`NationalSpire.DateGames.HistorySource(NationalSpire.PrivateTurn)`](DateGames.cs.md#symbol-89bfe888bf25)；[`NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`](DateSceneData.cs.md#symbol-711ab692d366)；[`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`](DateSceneData.cs.md#symbol-801111e76ca9)；[`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`](PrivateAppointments.cs.md#symbol-1c549626b284)；[`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`](PrivateMessages.cs.md#symbol-2e8d90d01925)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；`System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；`System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；`System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；`string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`

**字段、属性、事件及方法组引用：** `NationalSpire.DateGames.HistorySource(NationalSpire.PrivateTurn)`；`NationalSpire.DateSceneLine.Narration`；`NationalSpire.DateSceneLine.Speaker`；`NationalSpire.DateSceneParticipant.Name`；`NationalSpire.DateSceneParticipant.PersonId`；`NationalSpire.DateSceneRequest.GameEvent`；`NationalSpire.DateSceneRequest.Participants`；`NationalSpire.DateSceneRequest.Title`；`NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`；`NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`；`NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；`NationalSpire.PrivateConversation.Forgotten`；`NationalSpire.PrivateConversation.PersonId`；`NationalSpire.PrivateConversation.Turns`；`NationalSpire.PrivateMailbox.Conversations`；`NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；`NationalSpire.PrivateTurn.Day`；`NationalSpire.PrivateTurn.Id`；`NationalSpire.PrivateTurn.ReplyDeleted`；`NationalSpire.PrivateTurn.ReplyOrder`；`NationalSpire.PrivateTurn.Scene`；`NationalSpire.PrivateTurn.Status`；`NationalSpire.PrivateTurn.User`；`NationalSpire.PrivateTurn.UserDeleted`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.DateGames.HistorySource(NationalSpire.PrivateTurn)`；输入表达式：`DateGames.HistorySource(t)`；返回值紧邻使用处：`BinaryExpressionSyntax: "\n共同约会记录（在场人物各自只知晓公开交流内容）：\n" + PrivateAppointments.DateText(data, t.Day) + " · " + t.Scene!.Title + "\n" + DateGames.HistorySource(t)`
- `NationalSpire.DateScenes.DisplayText(NationalSpire.DateSceneLine)`；输入表达式：`DateScenes.DisplayText(l)`；返回值紧邻使用处：`BinaryExpressionSyntax: (l.Narration ? "旁白" : t.Scene.Participants.FirstOrDefault(p => p.PersonId == l.Speaker)?.Name ?? "人物") + "：" + DateScenes.DisplayText(l)`
- `NationalSpire.DateScenes.Lines(NationalSpire.PrivateTurn)`；输入表达式：`DateScenes.Lines(t)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: DateScenes.Lines(t).Select`
- `NationalSpire.PrivateAppointments.DateText(NationalSpire.CareerData, int)`；输入表达式：`PrivateAppointments.DateText(data, t.Day)`；返回值紧邻使用处：`BinaryExpressionSyntax: "\n共同约会记录（在场人物各自只知晓公开交流内容）：\n" + PrivateAppointments.DateText(data, t.Day)`
- `NationalSpire.PrivateMessages.Mailbox(NationalSpire.CareerData)`；输入表达式：`PrivateMessages.Mailbox(data)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`.Participants.Any(p => p.PersonId == person)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: t.Scene?.Participants.Any(p => p.PersonId == person)`
- `System.Collections.Generic.IEnumerable<TSource>.FirstOrDefault<TSource>(System.Func<TSource, bool>)`；输入表达式：`t.Scene.Participants.FirstOrDefault(p => p.PersonId == l.Speaker)`；返回值紧邻使用处：`ConditionalAccessExpressionSyntax: t.Scene.Participants.FirstOrDefault(p => p.PersonId == l.Speaker)?.Name`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values.Where(c => c.PersonId != person && !c.Forgotten) .SelectMany(c => c.Turns).Where(t => t.Id != excludeTurn && t.Status == "complete" && !t.ReplyDeleted && t.Scene?.Participants.Any(p => p.PersonId == person) == true).OrderBy(t => t.Day)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations.Values.Where(c => c.PersonId != person && !c.Forgotten) .SelectMany(c => c.Turns).Where(t => t.Id != excludeTurn && t.Status == "complete" && !t.ReplyDeleted && t.Scene?.Participants.Any(p => p.PersonId == person) == true).OrderBy(t => t.Day).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`DateScenes.Lines(t).Select(l => (l.Narration ? "旁白" : t.Scene.Participants.FirstOrDefault(p => p.PersonId == l.Speaker)?.Name ?? "人物") + "：" + DateScenes.DisplayText(l))`；返回值紧邻使用处：`ArgumentSyntax: DateScenes.Lines(t).Select(l => (l.Narration ? "旁白" : t.Scene.Participants.FirstOrDefault(p => p.PersonId == l.Speaker)?.Name ?? "人物") + "：" + DateScenes.DisplayText(l))`
- `System.Collections.Generic.IEnumerable<TSource>.Select<TSource, TResult>(System.Func<TSource, TResult>)`；输入表达式：`turns.Select(t => "\n共同约会记录（在场人物各自只知晓公开交流内容）：\n" + PrivateAppointments.DateText(data, t.Day) + " · " + t.Scene!.Title + "\n" + DateGames.HistorySource(t) + "\n" + (t.UserDeleted || t.Scene.GameEvent.Length > 0 ? "" : "玩家：" + t.User + "\n") + string.Join("\n", DateScenes.Lines(t).Select(l => (l.Narration ? "旁白" : t.Scene.Participants.FirstOrDefault(p => p.PersonId == l.Speaker)?.Name ?? "人物") + "：" + DateScenes.DisplayText(l))))`；返回值紧邻使用处：`ArgumentSyntax: turns.Select(t => "\n共同约会记录（在场人物各自只知晓公开交流内容）：\n" + PrivateAppointments.DateText(data, t.Day) + " · " + t.Scene!.Title + "\n" + DateGames.HistorySource(t) + "\n" + (t.UserDeleted || t.Scene.GameEvent.Length > 0 ? "" : "玩家：" + t.User + "\n") + string.Join("\n", DateScenes.Lines(t).Select(l => (l.Narration ? "旁白" : t.Scene.Participants.FirstOrDefault(p => p.PersonId == l.Speaker)?.Name ?? "人物") + "：" + DateScenes.DisplayText(l))))`
- `System.Collections.Generic.IEnumerable<TSource>.SelectMany<TSource, TResult>(System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values.Where(c => c.PersonId != person && !c.Forgotten) .SelectMany(c => c.Turns)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations.Values.Where(c => c.PersonId != person && !c.Forgotten) .SelectMany(c => c.Turns).Where`
- `System.Collections.Generic.IEnumerable<TSource>.TakeLast<TSource>(int)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values.Where(c => c.PersonId != person && !c.Forgotten) .SelectMany(c => c.Turns).Where(t => t.Id != excludeTurn && t.Status == "complete" && !t.ReplyDeleted && t.Scene?.Participants.Any(p => p.PersonId == person) == true).OrderBy(t => t.Day).ThenBy(t => t.ReplyOrder).TakeLast(5)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = PrivateMessages.Mailbox(data).Conversations.Values.Where(c => c.PersonId != person && !c.Forgotten) .SelectMany(c => c.Turns).Where(t => t.Id != excludeTurn && t.Status == "complete" && !t.ReplyDeleted && t.Scene?.Participants.Any(p => p.PersonId == person) == true).OrderBy(t => t.Day).ThenBy(t => t.ReplyOrder).TakeLast(5)`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values.Where(c => c.PersonId != person && !c.Forgotten)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations.Values.Where(c => c.PersonId != person && !c.Forgotten) .SelectMany`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values.Where(c => c.PersonId != person && !c.Forgotten) .SelectMany(c => c.Turns).Where(t => t.Id != excludeTurn && t.Status == "complete" && !t.ReplyDeleted && t.Scene?.Participants.Any(p => p.PersonId == person) == true)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations.Values.Where(c => c.PersonId != person && !c.Forgotten) .SelectMany(c => c.Turns).Where(t => t.Id != excludeTurn && t.Status == "complete" && !t.ReplyDeleted && t.Scene?.Participants.Any(p => p.PersonId == person) == true).OrderBy`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>)`；输入表达式：`PrivateMessages.Mailbox(data).Conversations.Values.Where(c => c.PersonId != person && !c.Forgotten) .SelectMany(c => c.Turns).Where(t => t.Id != excludeTurn && t.Status == "complete" && !t.ReplyDeleted && t.Scene?.Participants.Any(p => p.PersonId == person) == true).OrderBy(t => t.Day).ThenBy(t => t.ReplyOrder)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: PrivateMessages.Mailbox(data).Conversations.Values.Where(c => c.PersonId != person && !c.Forgotten) .SelectMany(c => c.Turns).Where(t => t.Id != excludeTurn && t.Status == "complete" && !t.ReplyDeleted && t.Scene?.Participants.Any(p => p.PersonId == person) == true).OrderBy(t => t.Day).ThenBy(t => t.ReplyOrder).TakeLast`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("", turns.Select(t => "\n共同约会记录（在场人物各自只知晓公开交流内容）：\n" + PrivateAppointments.DateText(data, t.Day) + " · " + t.Scene!.Title + "\n" + DateGames.HistorySource(t) + "\n" + (t.UserDeleted || t.Scene.GameEvent.Length > 0 ? "" : "玩家：" + t.User + "\n") + string.Join("\n", DateScenes.Lines(t).Select(l => (l.Narration ? "旁白" : t.Scene.Participants.FirstOrDefault(p => p.PersonId == l.Speaker)?.Name ?? "人物") + "：" + DateScenes.DisplayText(l)))))`；返回值紧邻使用处：`ReturnStatementSyntax: return string.Join("", turns.Select(t => "\n共同约会记录（在场人物各自只知晓公开交流内容）：\n" + PrivateAppointments.DateText(data, t.Day) + " · " + t.Scene!.Title + "\n" + DateGames.HistorySource(t) + "\n" + (t.UserDeleted || t.Scene.GameEvent.Length > 0 ? "" : "玩家：" + t.User + "\n") + string.Join("\n", DateScenes.Lines(t).Select(l => (l.Narration ? "旁白" : t.Scene.Participants.FirstOrDefault(p => p.PersonId == l.Speaker)?.Name ?? "人物") + "：" + DateScenes.DisplayText(l)))));`
- `string.Join(string?, System.Collections.Generic.IEnumerable<string?>)`；输入表达式：`string.Join("\n", DateScenes.Lines(t).Select(l => (l.Narration ? "旁白" : t.Scene.Participants.FirstOrDefault(p => p.PersonId == l.Speaker)?.Name ?? "人物") + "：" + DateScenes.DisplayText(l)))`；返回值紧邻使用处：`BinaryExpressionSyntax: "\n共同约会记录（在场人物各自只知晓公开交流内容）：\n" + PrivateAppointments.DateText(data, t.Day) + " · " + t.Scene!.Title + "\n" + DateGames.HistorySource(t) + "\n" + (t.UserDeleted || t.Scene.GameEvent.Length > 0 ? "" : "玩家：" + t.User + "\n") + string.Join("\n", DateScenes.Lines(t).Select(l => (l.Narration ? "旁白" : t.Scene.Participants.FirstOrDefault(p => p.PersonId == l.Speaker)?.Name ?? "人物") + "：" + DateScenes.DisplayText(l)))`

**赋值（含属性/字段和局部值）：**
